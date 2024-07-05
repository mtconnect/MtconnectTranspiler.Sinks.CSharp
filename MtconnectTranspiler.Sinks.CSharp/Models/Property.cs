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

            Type = CSharpHelperMethods.ToPrimitiveType(model, source)?.Name ?? "object";
        }
    }
}
