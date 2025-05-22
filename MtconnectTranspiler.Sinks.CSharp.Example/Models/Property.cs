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

            AccessModifier = source.Visibility;

            Modifier = source.IsStatic ? "static" : source.IsReadOnly ? "readonly" : "";

            XmiElement? remoteType = null;
            Type = CSharpHelperMethods.ToPrimitiveType(model, source)?.Name
                ?? CSharpHelperMethods.TypeDeepSearch(model, source.PropertyType, out remoteType)
                ?? "object";

            OriginalPropertyType = source.PropertyType;

            Aggregation = source.Aggregation;
            Extension = string.Join(";", source.Extensions?.Select(o => o.Extender)?.DefaultIfEmpty("").ToArray());
            Association = CSharpHelperMethods.TypeDeepSearch(model, source.Association, out remoteType);
            if (source.DefaultValue is UmlInstanceValue instanceValue)
            {
                DefaultValue = CSharpHelperMethods.TypeDeepSearch(model, instanceValue.Instance, out XmiElement instanceType);
            } else
            {
                DefaultValue = source.DefaultValue?.Name;
            }

            var lowerValueExtension = source.LowerValue ?? source.Extensions?.Select(o => o.ChildElements.Where(c => c is LowerValue).FirstOrDefault()).FirstOrDefault() as LowerValue;
            var upperValueExtension = source.Extensions?.Select(o => o.ChildElements.Where(c => c is UpperValue).FirstOrDefault()).FirstOrDefault() as UpperValue;
            Multiplicity = lowerValueExtension != null && upperValueExtension != null
                ? $"{lowerValueExtension.Value ?? "0"}..{upperValueExtension.Value}"
                : upperValueExtension != null
                    ? $"{upperValueExtension.Value}"
                    : lowerValueExtension != null
                        ? $"{lowerValueExtension.Value ?? "0"}"
                        : string.Empty;
            // QUESTION: What are the options for lowerValue.Value and upperValue.Value?
        }

    }
}
