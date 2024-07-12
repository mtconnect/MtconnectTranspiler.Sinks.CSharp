//using MtconnectTranspiler.Sinks.ScribanTemplates;
//using MtconnectTranspiler.Xmi;
//using MtconnectTranspiler.Xmi.UML;

//namespace MtconnectTranspiler.Sinks.CSharp.Example.Models
//{
//    [ScribanTemplate("CSharp.Enum.scriban")]
//    public class CSharpEnum : CSharp.Models.Enum
//    {
//        // NOTE: Only used for CATEGORY types that have subTypes.
//        public Dictionary<string, string> SubTypes { get; set; } = new Dictionary<string, string>();

//        // NOTE: Only used for CATEGORY types that have value enums.
//        public Dictionary<string, string> ValueTypes { get; set; } = new Dictionary<string, string>();

//        public CSharpEnum(XmiDocument model, XmiElement source, string name) : base(model, source, name) { }

//        public CSharpEnum(XmiDocument model, UmlEnumeration source) : base(model, source) { }

//        public CSharpEnum(XmiDocument model, UmlPackage source) : base(model, source) { }
//    }
//}
