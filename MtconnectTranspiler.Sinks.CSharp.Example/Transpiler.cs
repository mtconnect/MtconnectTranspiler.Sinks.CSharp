using Microsoft.Extensions.Logging;
using MtconnectTranspiler.Sinks.CSharp.Models;
using MtconnectTranspiler.Sinks.CSharp.Example.Models;
using MtconnectTranspiler.Xmi.UML;
using Scriban.Runtime;
using MtconnectTranspiler.Xmi;
using MtconnectTranspiler.Contracts;
using System.Linq;
using CaseExtensions;
using System.Text.RegularExpressions;
using MtconnectTranspiler.CodeGenerators.ScribanTemplates;
using System.Reflection;
using Scriban;

namespace MtconnectTranspiler.Sinks.CSharp.Example
{
    public class CategoryFunctions : ScriptObject
    {
        public static bool CategoryContainsType(CSharpEnum @enum, EnumItem item) => @enum.SubTypes.ContainsKey(item.Name);
        public static bool CategoryContainsValue(CSharpEnum @enum, EnumItem item) => @enum.ValueTypes.ContainsKey(item.Name);
        public static bool EnumHasValues(CSharpEnum @enum) => @enum.ValueTypes.Any();
        public static string RemoveDots(string? input) => input?.Replace(".", string.Empty) ?? string.Empty;
        public static string ToCSharpLiteral(object? input)
        {
            if (input == null)
                return string.Empty;

            return input.ToString()?
                .Replace("\"", "\"\"")
                .Replace("\\", "\\\\")
                ?? string.Empty;
        }
        public static string ToCodeSafe(string? input, string replaceBy = "_")
        {
            if (string.IsNullOrEmpty(input))
                return string.Empty;
            if (input.Contains("^2"))
                input = input.Replace("^2", "_SQUARED");
            if (input.Contains("^3"))
                input = input.Replace("^3", "_CUBED");
            if (input.Contains("/"))
                input = input.Replace("/", "_PER_");
            if (input.Equals("float[]", StringComparison.OrdinalIgnoreCase))
                return input;
            if (input.Equals("float[3]", StringComparison.OrdinalIgnoreCase))
                return input;
            char[] numbers = new char[] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
            if (numbers.Any(c => input.StartsWith(c)))
                input = $"_{input}";

            var invalidFileCharacters = System.IO.Path
                .GetInvalidFileNameChars()
                .Concat(new char[] { ' ', '{', '}', '[', ']', '(', ')', '^', '`', '&', '+', '-', '!', '?', '%', '*', '<', '>', ',', '|', '\\', '/', '=', ':', ';' })
                .ToArray();
            return ReplaceCharacters(input, invalidFileCharacters, replaceBy);
        }
        public static string ToCSharpCodeSafe(string? input, string replaceBy = "_")
            => ToCodeSafe(input, replaceBy);
        public static string ToPathSafe(string? input, string replaceBy = "_")
        {
            if (string.IsNullOrEmpty(input))
                return string.Empty;
            var invalidFileCharacters = System.IO.Path
                .GetInvalidFileNameChars()
                .ToArray();
            return ReplaceCharacters(input, invalidFileCharacters, replaceBy);
        }
        public static string ReplaceCharacters(string input, IEnumerable<char> characters, string replaceBy)
        {
            string pattern = string.Join("|", characters.Distinct().Select(o => Regex.Escape(o.ToString())));
            return string.IsNullOrEmpty(pattern)
                ? input
                : Regex.Replace(input, pattern, replaceBy);
        }
        public static string? GetTypeNamespace(string? referenceId)
            => string.IsNullOrWhiteSpace(referenceId) ? null : TypeCache.GetTypeNamespaceFromId(referenceId);
        public static string[] GetClassNamespaces(CSharpClass cSharpClass)
        {
            var result = new List<string>();
            foreach (var property in cSharpClass.Properties)
            {
                string[] namespaces = TypeCache.GetTypeNamespaceFromName(property.Type);
                if (namespaces?.Length > 0)
                {
                    result.AddRange(namespaces);
                } else
                {
                    System.Diagnostics.Debug.WriteLine("Missing namespace for '" + property.Type + "'");
                }
            }
            return result.Distinct().Where(o => !string.IsNullOrEmpty(o)).ToArray();
        }
        public static string[] GetPackageNamespaces(CSharpPackage cSharpPackage)
        {
            var namespaces = new List<string>();
            foreach (var csharpClass in cSharpPackage.Classes)
            {
                namespaces.Add(csharpClass.Namespace);
            }
            return namespaces.Distinct().Where(o => !string.IsNullOrEmpty(o)).ToArray();
        }
    }
    internal class Transpiler : ITranspilerSink
    {
        private readonly ILogger<ITranspilerSink>? _logger;

        private readonly IScribanTemplateGenerator _generator;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="projectPath"></param>
        public Transpiler(IScribanTemplateGenerator generator, ILogger<ITranspilerSink>? logger = default)
        {
            _logger = logger;

            _generator = generator;
        }

        public void Transpile(XmiDocument model, CancellationToken cancellationToken = default)
        {
            _logger?.LogInformation("Received MTConnectModel, beginning transpilation");

            _generator.UpdateModel("model", model);

            _generator.Model.Import(typeof(CategoryFunctions));

            //// Process the template into enum files
            var allPackages = new List<CSharpPackage>();
            var allClasses = new List<CSharpClass>();
            var allEnumerations = new List<CSharpEnum>();
            // TODO: Add Operations; aka functions
            MtconnectModel rootPackage = new MtconnectModel(model, model.Model);
            foreach (var package in model.Model.Packages)
            {
                allPackages.Add(new CSharpPackage(model, package) { Namespace = "Mtconnect" });
                // Packages
                var subpackages = getPackages(model, package);
                if (subpackages.Any())
                    allPackages.AddRange(subpackages);

                // Classes
                var classes = getClasses(model, package);
                if (classes.Any())
                    allClasses.AddRange(classes);

                // Enumerations
                var enumerations = getEnums(model, package);
                if (enumerations.Any())
                    allEnumerations.AddRange(enumerations);
            }
            // Profiles
            foreach (var profile in model.Model.Profiles)
            {
                if (profile.Packages.Any())
                {
                    foreach (var package in profile.Packages)
                    {
                        allPackages.Add(new CSharpPackage(model, package) { Namespace = "Mtconnect" });
                        // Packages
                        var subpackages = getPackages(model, package);
                        if (subpackages.Any())
                            allPackages.AddRange(subpackages);

                        // Classes
                        var classes = getClasses(model, package);
                        if (classes.Any())
                            allClasses.AddRange(classes);

                        // Enumerations
                        var enumerations = getEnums(model, package);
                        if (enumerations.Any())
                            allEnumerations.AddRange(enumerations);
                    }
                }
            }

            _logger?.LogInformation("Saving Packages...");
            ProcessTemplate(allPackages, Path.Combine(_generator.OutputPath, "Packages"), true);
            _logger?.LogInformation("Saving Classes...");
            ProcessTemplate(allClasses, Path.Combine(_generator.OutputPath, "Classes"), true);
            _logger?.LogInformation("Saving Enums...");
            ProcessTemplate(allEnumerations, Path.Combine(_generator.OutputPath, "Enums"), true);

            _logger?.LogInformation("Saving Root Package...");
            ProcessTemplate(rootPackage, _generator.OutputPath, true);
        }

        private IEnumerable<CSharpPackage> getPackages(XmiDocument model, UmlPackage package, string namespacePrefix = "Mtconnect")
        {
            namespacePrefix = $"{namespacePrefix}.{package.Name.ToPascalCase()}";
            var results = new List<CSharpPackage>();
            foreach (var subpackage in package.Packages)
            {
                results.Add(new CSharpPackage(model, subpackage) { Namespace = namespacePrefix });
                if (subpackage.Packages.Count > 0)
                    results.AddRange(getPackages(model, subpackage, namespacePrefix));
            }
            return results;
        }

        private IEnumerable<CSharpEnum> getEnums(XmiDocument model, UmlPackage package, string namespacePrefix = "Mtconnect")
        {
            namespacePrefix = $"{namespacePrefix}.{package.Name.ToPascalCase()}";
            var results = new List<CSharpEnum>();
            if (package.Enumerations.Count > 0)
                foreach (var item in package.Enumerations)
                    results.Add(new CSharpEnum(model, item) { Namespace = namespacePrefix });
            if (package.Packages.Count > 0)
            {
                foreach (var item in package.Packages)
                {
                    var subEnums = getEnums(model, item, namespacePrefix);
                    if (subEnums.Any())
                        results.AddRange(subEnums);
                }
            }
            return results;
        }

        private IEnumerable<CSharpClass> getClasses(XmiDocument model, UmlPackage package, string namespacePrefix = "Mtconnect")
        {
            namespacePrefix = $"{namespacePrefix}.{package.Name.ToPascalCase()}";
            var results = new List<CSharpClass>();
            if (package.Classes.Count > 0)
                foreach (var item in package.Classes)
                    results.Add(new CSharpClass(model, item) { Namespace = namespacePrefix });

            if (package.AssociationClasses.Count > 0)
                foreach (var item in package.AssociationClasses)
                    results.Add(new CSharpClass(model, item) { Namespace = namespacePrefix });
            
            if ( package.Packages.Count > 0)
            {
                foreach(var item in package.Packages)
                {
                    var subClasses = getClasses(model, item, namespacePrefix);
                    if (subClasses.Any())
                        results.AddRange(subClasses);
                }
            }
            return results;
        }

        private void ProcessTemplate<T>(IEnumerable<T> items, string folderPath, bool overwriteExisting) where T : IFileSource
        {
            foreach (var item in items)
            {
                ProcessTemplate(item, folderPath, overwriteExisting);
            }
        }

        private void ProcessTemplate<T>(T item, string folderPath, bool overwriteExisting) where T : IFileSource
        {
            string output = RenderTemplate(item);
            if (string.IsNullOrEmpty(output))
                throw new InvalidOperationException($"Template rendered empty for {item.Filename}. {DescribeItem(item)}");

            string filePath = GetOutputFilePath(folderPath, item.Filename);
            if (!overwriteExisting && File.Exists(filePath))
                return;

            string? directory = Path.GetDirectoryName(filePath);
            if (!string.IsNullOrEmpty(directory))
                Directory.CreateDirectory(directory);

            File.WriteAllText(filePath, output);
        }

        private string RenderTemplate<T>(T item) where T : IFileSource
        {
            var attribute = item.GetType()
                .GetCustomAttributes(typeof(ScribanTemplateAttribute), true)
                .OfType<ScribanTemplateAttribute>()
                .FirstOrDefault();
            if (attribute == null)
                throw new InvalidOperationException($"Missing {nameof(ScribanTemplateAttribute)} for {item.GetType().FullName}.");

            try
            {
                if (GetGeneratorMethod("GetTemplate", 1)
                    .Invoke(_generator, new object?[] { attribute.Filename }) is not Template template)
                    throw new InvalidOperationException($"Template {attribute.Filename} could not be loaded.");

                _generator.UpdateModel("source", item);
                var context = new TemplateContext
                {
                    TemplateLoader = _generator.TemplateContext.TemplateLoader
                };
                context.PushGlobal(_generator.Model);

                string output = template.Render(context);
                if (string.IsNullOrEmpty(output))
                    throw new InvalidOperationException($"Template render returned empty. {DescribeTemplateMessages(template, context)}");

                return output;
            }
            catch (TargetInvocationException ex)
            {
                throw new InvalidOperationException($"Failed to render {item.Filename}.", ex.InnerException ?? ex);
            }
        }

        private MethodInfo GetGeneratorMethod(string name, int parameterCount)
        {
            return _generator.GetType()
                .GetMethods(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic)
                .FirstOrDefault(o => o.Name == name && o.GetParameters().Length == parameterCount)
                ?? throw new InvalidOperationException($"{_generator.GetType().FullName} does not expose {name}.");
        }

        private static string DescribeTemplateMessages(params object?[] sources)
        {
            var result = new List<string>();

            foreach (var source in sources)
            {
                if (source == null)
                    continue;

                var messagesProperty = source.GetType()
                    .GetProperties(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic)
                    .FirstOrDefault(o => o.Name == "Messages");
                if (messagesProperty?.GetValue(source) is System.Collections.IEnumerable messages)
                {
                    var messageText = messages
                        .Cast<object?>()
                        .Where(o => o != null)
                        .Select(o => o!.ToString())
                        .Where(o => !string.IsNullOrWhiteSpace(o))
                        .Select(o => o!);
                    result.AddRange(messageText);
                }
            }

            return result.Count > 0
                ? string.Join(" | ", result)
                : "No template or context messages.";
        }

        private static string DescribeItem(IFileSource item)
        {
            return item switch
            {
                CSharpPackage package => $"Package={package.Name}, Namespace={package.Namespace}, Packages={package.Packages.Count()}, Classes={package.Classes.Count()}, Enums={package.Enums.Count()}, HasSummary={package.Summary != null}.",
                CSharpClass csharpClass => $"Class={csharpClass.Name}, Namespace={csharpClass.Namespace}, Properties={csharpClass.Properties.Count()}, Constraints={csharpClass.Constraints.Count()}, HasSummary={csharpClass.Summary != null}.",
                CSharpEnum csharpEnum => $"Enum={csharpEnum.Name}, Namespace={csharpEnum.Namespace}, Items={csharpEnum.Items.Count()}, HasSummary={csharpEnum.Summary != null}, DataType={csharpEnum.DataType ?? ""}.",
                _ => $"Type={item.GetType().FullName}."
            };
        }

        private static string GetOutputFilePath(string folderPath, string filename)
        {
            string root = Path.GetFullPath(folderPath);
            if (!root.EndsWith(Path.DirectorySeparatorChar))
                root += Path.DirectorySeparatorChar;

            string filePath = Path.GetFullPath(Path.Combine(root, filename));

            if (!filePath.StartsWith(root, StringComparison.OrdinalIgnoreCase))
                throw new InvalidOperationException($"Refusing to write outside output folder: {filePath}");

            return filePath;
        }

    }
}
