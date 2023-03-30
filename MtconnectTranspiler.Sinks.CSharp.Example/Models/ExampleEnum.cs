using MtconnectTranspiler.Sinks.CSharp.Attributes;
using MtconnectTranspiler.Xmi;
using MtconnectTranspiler.Xmi.UML;

namespace MtconnectTranspiler.Sinks.CSharp.Example.Models
{
    [ScribanTemplate("Example.Enum.scriban")]
    public class ExampleEnum : CSharp.Models.Enum
    {
        // NOTE: Only used for CATEGORY types that have subTypes.
        public Dictionary<string, string> SubTypes { get; set; } = new Dictionary<string, string>();

        // NOTE: Only used for CATEGORY types that have value enums.
        public Dictionary<string, string> ValueTypes { get; set; } = new Dictionary<string, string>();

        public ExampleEnum(XmiDocument model, XmiElement source, string name) : base(model, source, name) { }

        public ExampleEnum(XmiDocument model, UmlEnumeration source) : base(model, source) { }

        public ExampleEnum(XmiDocument model, UmlPackage source) : base(model, source) { }
    }
}
