using Microsoft.Extensions.Logging;
using MtconnectTranspiler.Sinks.CSharp.Models;
using MtconnectTranspiler.Sinks.CSharp.Example.Models;
using MtconnectTranspiler.Xmi.UML;
using Scriban.Runtime;
using MtconnectTranspiler.Xmi;
using MtconnectTranspiler.Contracts;

namespace MtconnectTranspiler.Sinks.CSharp.Example
{
    public class CategoryFunctions : ScriptObject
    {
        public static bool CategoryContainsType(ExampleEnum @enum, EnumItem item) => @enum.SubTypes.ContainsKey(item.Name);
        public static bool CategoryContainsValue(ExampleEnum @enum, EnumItem item) => @enum.ValueTypes.ContainsKey(item.Name);
        public static bool EnumHasValues(ExampleEnum @enum) => @enum.ValueTypes.Any();
    }
    internal class Transpiler : CsharpTranspiler
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

            const string DataItemNamespace = "Example.Enums.DataItemTypes";
            const string DataItemValueNamespace = "Example.Enums.DataItemValues";

            // Process DataItem Types/Sub-Types
            var dataItemTypeEnums = new List<ExampleEnum>();
            var valueEnums = new List<ExampleEnum>();
            string[] categories = new string[] { "Sample", "Event", "Condition" };

            foreach (var category in categories)
            {
                // Get the UmlPackage for the category (ie. Samples, Events, Conditions).
                var typesPackage = MTConnectHelper.JumpToPackage(
                    model!,
                    MTConnectHelper.PackageNavigationTree.ObservationInformationModel.ObservationTypes
                    )?
                    .Packages
                    .FirstOrDefault(o => o.Name == $"{category} Types");
                if (typesPackage == null)
                {
                    _logger?.LogTrace("Couldn't find {Category} Types", category);
                    continue;
                }

                // Get all DataItem Type and SubType references
                var allTypes = typesPackage
                    .Classes;
                // Filter to get just the Type references
                var types = allTypes
                    ?.Where(o => !o!.Name!.Contains('.'));
                if (types == null)
                {
                    _logger?.LogTrace("Couldn't find type classes for {Category} Types", category);
                    continue;
                }

                // Filter and group each SubType by the relevant Type reference
                var subTypes = allTypes
                    ?.Where(o => o!.Name!.Contains('.'))
                    ?.GroupBy(o => o!.Name![..o.Name!.IndexOf(".")], o => o)
                    ?.Where(o => o.Any())
                    ?.ToDictionary(o => o.Key, o => o?.ToList());

                var categoryEnum = new ExampleEnum(model!, typesPackage)
                {
                    Name = $"{category}Types",
                    Namespace = DataItemNamespace
                };

                foreach (var type in types)
                {
                    // Add type to CATEGORY enum
                    categoryEnum.Add(model, type);

                    // Find value
                    var typeResult = type!.Properties?.FirstOrDefault(o => o.Name == "result");
                    if (typeResult != null)
                    {
                        var typeValuesSysEnum = MTConnectHelper.JumpToPackage(model!, MTConnectHelper.PackageNavigationTree.Profile.DataTypes)?
                            .Enumerations
                            .GetById(typeResult.PropertyType);
                        if (typeValuesSysEnum != null && typeValuesSysEnum is UmlEnumeration)
                        {
                            var typeValuesEnum = new ExampleEnum(model!, typeValuesSysEnum!)
                            {
                                Namespace = DataItemValueNamespace,
                                Name = $"{type.Name}Values"
                            };
                            foreach (var value in typeValuesEnum.Items)
                            {
                                value.Name = value.SysML_Name;
                            }
                            if (!categoryEnum.ValueTypes.ContainsKey(type.Name!)) categoryEnum.ValueTypes.Add(ScribanHelperMethods.ToUpperSnakeCode(type.Name), $"{type.Name}Values");
                            valueEnums.Add(typeValuesEnum);
                        }
                    }

                    // Add subType as enum
                    if (subTypes != null && subTypes.ContainsKey(type.Name!))
                    {
                        // Register type as having a subType in the CATEGORY enum
                        if (!categoryEnum.SubTypes.ContainsKey(type.Name!)) categoryEnum.SubTypes.Add(ScribanHelperMethods.ToUpperSnakeCode(type.Name), $"{type.Name}SubTypes");

                        var subTypeEnum = new ExampleEnum(model!, type, $"{type.Name}SubTypes") { Namespace = DataItemNamespace };

                        var typeSubTypes = subTypes[type.Name!];
                        subTypeEnum.AddRange(model, typeSubTypes);

                        // Cleanup Enum names
                        foreach (var item in subTypeEnum.Items)
                        {
                            if (!item.Name.Contains('.')) continue;
                            item.Name = ScribanHelperMethods.ToUpperSnakeCode(item.Name[(item.Name.IndexOf(".") + 1)..]);
                        }

                        // Register the DataItem SubType Enum
                        dataItemTypeEnums.Add(subTypeEnum);
                    }
                }

                // Cleanup Enum names
                foreach (var item in categoryEnum.Items)
                {
                    item.Name = ScribanHelperMethods.ToUpperSnakeCode(item.Name);
                }

                // Register the DataItem Category Enum (ie. Samples, Events, Conditions)
                dataItemTypeEnums.Add(categoryEnum);
            }

            _logger?.LogInformation("Processing {Count} DataItem types/subTypes", dataItemTypeEnums.Count);

            // Process the template into enum files
            ProcessTemplate(dataItemTypeEnums, Path.Combine(ProjectPath, "Enums", "Devices", "DataItemTypes"), true);
            ProcessTemplate(valueEnums, Path.Combine(ProjectPath, "Enums", "Streams"), true);
        }
    }
}
