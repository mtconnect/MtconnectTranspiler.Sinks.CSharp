using Microsoft.Extensions.Logging;
using MtconnectTranspiler.Sinks.CSharp.Models;
using MtconnectTranspiler.Sinks.CSharp.Example.Models;
using MtconnectTranspiler.Xmi.UML;
using Scriban.Runtime;
using MtconnectTranspiler.Xmi;
using MtconnectTranspiler.Contracts;
using System.Linq;
using CaseExtensions;
using MtconnectTranspiler.Sinks.ScribanTemplates;
using System.Text.RegularExpressions;

namespace MtconnectTranspiler.Sinks.CSharp.Example
{
    public class CategoryFunctions : ScriptObject
    {
        public static bool CategoryContainsType(CSharpEnum @enum, EnumItem item) => @enum.SubTypes.ContainsKey(item.Name);
        public static bool CategoryContainsValue(CSharpEnum @enum, EnumItem item) => @enum.ValueTypes.ContainsKey(item.Name);
        public static bool EnumHasValues(CSharpEnum @enum) => @enum.ValueTypes.Any();
        public static string ToCodeSafe(string input, string replaceBy = "_")
        {
            if (input.Contains("^2"))
                input = input.Replace("^2", "_SQUARED");
            if (input.Contains("^3"))
                input = input.Replace("^3", "_CUBED");
            if (input.Contains("/"))
                input = input.Replace("/", "_PER_");
            char[] numbers = new char[] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
            if (numbers.Any(c => input.StartsWith(c)))
                input = $"_{input}";

            var invlidFileCharacters = System.IO.Path
            .GetInvalidFileNameChars()
            .Concat(new char[] { ' ', '{', '}', '[', ']', '(', ')', '^', '`', '&', '+', '-', '!', '?', '%', '*', '<', '>', ',', '|', '\\', '/', '=', ':', ';' })
            .ToArray();
            /// <summary>
            /// Regular expression to replace the <see cref="InvalidCharacters"/>
            /// </summary>
            var regex = new Regex(@"\" + String.Join(@"|\", invlidFileCharacters), RegexOptions.Compiled);
            return regex.Replace(input, replaceBy);
        }
        public static string GetTypeNamespace(string typeName)
            => TypeCache.GetTypeNamespace(typeName);
        public static string[] GetClassNamespaces(CSharpClass cSharpClass)
        {
            var namespaces = new List<string>();
            foreach (var property in cSharpClass.Properties)
            {
                namespaces.Add(TypeCache.GetTypeNamespace(property.Type));
            }
            return namespaces.Distinct().Where(o => !string.IsNullOrEmpty(o)).ToArray();
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
    internal class Transpiler : ScribanTranspiler
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="projectPath"></param>
        public Transpiler(string projectPath, ILogger<ITranspilerSink>? logger = default) : base(projectPath, logger) { }

        public override void Transpile(XmiDocument model, CancellationToken cancellationToken = default)
        {
            _logger?.LogInformation("Received MTConnectModel, beginning transpilation");

            Model.SetValue("model", model, true);

            base.TemplateContext.PushGlobal(new CategoryFunctions());

            //// Process the template into enum files
            var allPackages = new List<CSharpPackage>();
            var allClasses = new List<CSharpClass>();
            var allEnumerations = new List<CSharpEnum>();
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

            //var csharpPackages = allPackages.Select(o => new CSharpPackage(model, o));
            //var csharpClasses = allClasses.Select(o => new CSharpClass(model, o));
            //var csharpEnums = allEnumerations.Select(o => new CSharpEnum(model, o));

            //var nullPackages = csharpPackages.Where(o => o == null).ToList();
            //var nullClasses = csharpClasses.Where(o => o == null).ToList();
            //var nullEnums = csharpEnums.Where(o => o == null).ToList();

            ProcessTemplate(allPackages, Path.Combine(ProjectPath, "Packages"), true);
            ProcessTemplate(allClasses, Path.Combine(ProjectPath, "Classes"), true);
            ProcessTemplate(allEnumerations, Path.Combine(ProjectPath, "Enums"), true);
            //ProcessTemplate(dataItemTypeEnums, Path.Combine(ProjectPath, "Enums", "Devices", "DataItemTypes"), true);
            //ProcessTemplate(valueEnums, Path.Combine(ProjectPath, "Enums", "Streams"), true);
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

    }
}
