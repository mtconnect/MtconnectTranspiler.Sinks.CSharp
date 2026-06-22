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
        /// Reference to the <c>name</c> attribute.
        /// </summary>
        public string NormativeName { get; set; }

        /// <summary>
        /// Reference to any Comments written in the SysML model to be converted into a C# format <c>&lt;summary /&gt;</c>
        /// </summary>
        public Summary Summary { get; protected set; }

        /// <summary>
        /// Reference to the expected property type
        /// </summary>
        public string Type { get; set; }

        /// <summary>
        /// SysML model value for <c>xmi:type</c>
        /// </summary>
        public string OriginalPropertyType { get; set; }

        /// <summary>
        /// Relationship of with other parts. E.g. <c>composite</c> indicates a "has-a" relationship with an associated object
        /// </summary>
        public string Aggregation { get; set; }

        /// <summary>
        /// UML extension, delimitted by semi-colon (;)
        /// </summary>
        public string Extension { get; set; }

        /// <summary>
        /// Reference to a related remote object
        /// </summary>
        public string Association { get; set; }

        public string DefaultValue { get; set; }

        public string Multiplicity { get; set; }

        private XmiElement? _remoteType { get; set; }

        /// <summary>
        /// Constructs an <see cref="Property"/> more generically. <b>NOTE</b>: You'll need to add items manually from here.
        /// </summary>
        /// <param name="model"><inheritdoc cref="XmiDocument" path="/summary"/></param>
        /// <param name="source"><inheritdoc cref="XmiElement" path="/summary"/></param>
        public Property(XmiDocument model, UmlProperty source) : base(model, source)
        {
            NormativeName = source.Name;

            if (source.Comments?.Length > 0)
                Summary = new Summary(source.Comments);

            AccessModifier = source.Visibility ?? "public";

            Modifier = source.IsStatic ? "static" : source.IsReadOnly ? "readonly" : "";

            XmiElement? remoteType = null;
            Type = CSharpHelperMethods.ToPrimitiveType(model, source)?.Name
                ?? CSharpHelperMethods.TypeDeepSearch(model, source.PropertyType, out remoteType)
                ?? "object";

            OriginalPropertyType = source.PropertyType;

            Aggregation = source.Aggregation;
            var extensions = source.Extensions?.Select(o => o.Extender)?.DefaultIfEmpty("")?.ToArray();
            if (extensions != null && extensions.Any())
                Extension = string.Join(";", extensions);
            Association = CSharpHelperMethods.TypeDeepSearch(model, source.Association, out remoteType);
            if (source.DefaultValue != null)
            {
                if (source.DefaultValue is UmlInstanceValue instanceValue)
                {
                    DefaultValue = CSharpHelperMethods.TypeDeepSearch(model, instanceValue.Instance, out XmiElement instanceType);
                }
                else if (source.DefaultValue is UmlLiteralBoolean booleanValue)
                {
                    DefaultValue = booleanValue.Value.GetValueOrDefault().ToString().ToLower();
                }
                else if (source.DefaultValue is UmlLiteralInteger integerValue)
                {
                    DefaultValue = integerValue.Value.GetValueOrDefault().ToString();
                }
                else if (source.DefaultValue is UmlLiteralString stringValue)
                {
                    DefaultValue = stringValue.Value;
                    if (DefaultValue.StartsWith("\"") && DefaultValue.EndsWith("\""))
                    {
                        // Already quoted
                        DefaultValue = DefaultValue.Remove(DefaultValue.Length - 1, 1).Remove(0, 1);
                    }
                } else if (source.DefaultValue is UmlLiteralReal realValue)
                {
                    DefaultValue = realValue.Value.GetValueOrDefault().ToString();
                }
                else if (!string.IsNullOrEmpty(source.DefaultValue?.Name))
                {
                    DefaultValue = source.DefaultValue?.Name;
                }
            }

            var lowerValueExtension = source.LowerValue
                ?? source.Extensions?
                    .Select(o =>
                        o.ModelExtension?
                        .LowerValue
                    )
                    .FirstOrDefault(o => o != null) as LowerValue;
            var upperValueExtension = source.UpperValue
                ?? source.Extensions?
                    .Select(o =>
                        o.ModelExtension?
                        .UpperValue
                    )
                    .FirstOrDefault(o => o != null) as UpperValue;

            string lowerValue = lowerValueExtension?.Type == "uml:LiteralUnlimitedNatural"
                ? lowerValueExtension?.Value ?? "*"
                : lowerValueExtension != null
                    ? lowerValueExtension?.Value ?? "0"
                    : string.Empty;
            string upperValue = upperValueExtension?.Type == "uml:LiteralUnlimitedNatural"
                ? upperValueExtension?.Value ?? "*" // Sometimes a value is not present and that means "*"
                : upperValueExtension?.Value;

            Multiplicity = !string.IsNullOrEmpty(lowerValue) && !string.IsNullOrEmpty(upperValue)
                ? $"{lowerValue}..{upperValue}"
                : !string.IsNullOrEmpty(upperValue)
                    ? $"{upperValue}"
                    : lowerValueExtension != null
                        ? $"{lowerValueExtension.Value ?? "0"}"
                        : string.Empty;
            if (Multiplicity == "1..1")
                Multiplicity = "1";
            if (Multiplicity == "0..0")
                Multiplicity = string.Empty;
            // QUESTION: What are the options for lowerValue.Value and upperValue.Value?
        }

    }
}
