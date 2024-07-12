using MtconnectTranspiler.Xmi;
using MtconnectTranspiler.Xmi.UML;

namespace MtconnectTranspiler.Sinks.CSharp.Models
{
    /// <summary>
    /// Represents a C# property
    /// </summary>
    public class Property : CsharpType
    {
        /// <summary>
        /// Reference to any Comments written in the SysML model to be converted into a C# format <c>&lt;summary /&gt;</c>
        /// </summary>
        public Summary Summary { get; protected set; }

        /// <summary>
        /// Reference to the expected property type
        /// </summary>
        public string Type { get; set; }

        public string OriginalPropertyType { get; set; }

        public string Aggregation { get; set; }

        public string Extension { get; set; }

        public string Association { get; set; }

        public string DefaultValue { get; set; }

        /// <summary>
        /// Constructs an <see cref="Property"/> more generically. <b>NOTE</b>: You'll need to add items manually from here.
        /// </summary>
        /// <param name="model"><inheritdoc cref="XmiDocument" path="/summary"/></param>
        /// <param name="source"><inheritdoc cref="XmiElement" path="/summary"/></param>
        public Property(XmiDocument model, UmlProperty source) : base(model, source)
        {
            if (source.Comments?.Length > 0)
                Summary = new Summary(source.Comments);

            AccessModifier = source.Visibility;

            Modifier = source.IsStatic ? "static" : source.IsReadOnly ? "readonly" : "";

            Type = CSharpHelperMethods.ToPrimitiveType(model, source)?.Name
                ?? typeDeepSearch(model, source.PropertyType)
                ?? "object";
            OriginalPropertyType = source.PropertyType;

            Aggregation = source.Aggregation;
            Extension = source.Extension?.Extender;
            Association = typeDeepSearch(model, source.Association);
            DefaultValue = source.DefaultValue?.Name;
        }

        private string typeDeepSearch(XmiDocument model, string propertyType)
        {
            if (string.IsNullOrEmpty(propertyType))
                return null;
            // TODO: Also cache the namespaces that each of these properties are contained within
            object remoteType;
            if (model.IdCache.TryGetValue(propertyType, out remoteType))
            {
                switch (remoteType)
                {
                    case UmlEnumeration umlEnum:
                        return umlEnum.Name;
                    case UmlClass umlClass:
                        return $"{umlClass.Name}Class";
                    case UmlDataType umlDataType:
                        switch (umlDataType.Name)
                        {
                            case "float3d":
                                return "float[]";
                            case "binary":
                                return "bool";
                            default:
                                break;
                        }
                        break;
                    case UmlAssociation umlAssociation:
                        return umlAssociation.Name;
                    default:
                        break;
                }
            }
            return null;
        }
    }
}
