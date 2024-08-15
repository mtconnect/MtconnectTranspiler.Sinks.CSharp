using ConsoulLibrary;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using MtconnectTranspiler;
using MtconnectTranspiler.CodeGenerators.ScribanTemplates;
using MtconnectTranspiler.CodeGenerators.ScribanTemplates.Formatters;
using MtconnectTranspiler.Extensions;
using MtconnectTranspiler.Interpreters;
using MtconnectTranspiler.Sinks.CSharp.Example;
using MtconnectTranspiler.XmiOptions;

internal class Program
{
    private static void Main(string[] args)
    {
        if (args.Length == 0) throw new ArgumentNullException(nameof(args), "Missing projectPath argument");

        string projectPath = args[0];
        if (!Directory.Exists(projectPath))
        {
            Consoul.Write("Creating project path: " + projectPath);
            Directory.CreateDirectory(projectPath);
        }
        IConfiguration configuration = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
            .AddEnvironmentVariables()
            .AddCommandLine(args)
            .Build();

        //setup our DI
        var services = new ServiceCollection()
            .AddLogging((builder) =>
            {
                builder.AddConsoulLogger();
            });
        var serviceProvider = services
            .AddSingleton(configuration)
            .AddScribanServices(builder =>
            {
                string templatePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Templates");
                builder
                    // Use the local "/Templates" directory to store ".scriban" files
                    .UseTemplatesPath(templatePath)
                    // If using embedded resources to store ".scriban" files, then provide the assembly
                    //.UseResourceAssembly(typeof(Transpiler).Assembly, "MtconnectTranspiler.Sinks.CSharp.Example")
                    // Configure a Scriban ScriptObject capable of interpreting SysML comment contents into other formats.
                    .AddMarkdownInterpreter("csharp_docs", new VisualStudioSummaryInterpreter())
                    // Configure a Scriban ScriptObject capable of formatting strings into code safe formats.
                    .AddCodeFormatter("csharp_formatter", new CSharpCodeFormatter())
                    .ConfigureGenerator((options) => {
                        options.OutputPath = configuration["OutputPath"];
                    });
            })
            .AddScoped<Transpiler>()
            .BuildServiceProvider();

        //configure console logging
        //serviceProvider
        //    .GetService<ILoggerFactory>()
        //    .AddConsole(LogLevel.Debug);

        var logger = serviceProvider.GetService<ILoggerFactory>()
            .CreateLogger<Program>();
        logger.LogDebug("Starting application");


        //var logFactory = LoggerFactory.Create((o) => o.AddConsoulLogger());
        //var dispatchLogger = logFactory.CreateLogger<TranspilerDispatcher>();
        //var transpilerLogger = logFactory.CreateLogger<ITranspilerSink>();


        // NOTE: The GitHubRelease can be a reference to a specific tag referring to the version in which to download.
        TranspilerDispatcherOptions? dispatchOptions = null;
        if (args.Length > 1)
        {
            if (!File.Exists(args[1])) throw new FileNotFoundException(args[1]);

            dispatchOptions = new FromFileOptions() { Filepath = args[1] };
            Consoul.Write("Dispatching from file: " + args[1]);
        }
        else
        {
            dispatchOptions = new FromGitHubOptions() { GitHubRelease = "latest" };
            Consoul.Write("Dispatching from GitHub's latest release");
        }

        using (var tokenSource = new CancellationTokenSource())
        using (var dispatcher = new TranspilerDispatcher(dispatchOptions, serviceProvider.GetService<ILoggerFactory>()
            .CreateLogger<TranspilerDispatcher>()))
        {
            var defaultTranspiler = serviceProvider.GetService<Transpiler>();
            dispatcher.AddSink(defaultTranspiler);

            Consoul.Write("Beginning deserialization and dispatching");
            var task = Task.Run(() => dispatcher.TranspileAsync(tokenSource.Token));

#if DEBUG
            task = task.ContinueWith((t) => tokenSource.Cancel());
            Consoul.Wait(cancellationToken: tokenSource.Token);
#else
            task.Wait();
#endif

            if (task.IsCompletedSuccessfully)
            {
                Consoul.Write("Done!", ConsoleColor.Green);

                Environment.Exit(0);
            }
            else
            {
                Consoul.Write("Cancelled", ConsoleColor.Red);
                Environment.Exit(1);
            }

        }
    }
}