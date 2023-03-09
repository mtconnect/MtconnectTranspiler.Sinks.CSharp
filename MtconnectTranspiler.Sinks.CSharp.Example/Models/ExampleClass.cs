using MtconnectTranspiler.Model;
using MtconnectTranspiler.Sinks.CSharp.Attributes;
using MtconnectTranspiler.Sinks.CSharp.Models;
using MtconnectTranspiler.Xmi.UML;

namespace MtconnectTranspiler.Sinks.CSharp.Example.Models
{
    [ScribanTemplate("MtconnectCore.Class.scriban")]
    public class ExampleClass : Class
    {
        public ExampleClass(MTConnectModel model, UmlClass source) : base(model, source) { }
    }
}
