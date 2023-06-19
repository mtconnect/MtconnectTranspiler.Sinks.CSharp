using MtconnectTranspiler.Sinks.CSharp.Models;
using MtconnectTranspiler.Sinks.ScribanTemplates;
using MtconnectTranspiler.Xmi;
using MtconnectTranspiler.Xmi.UML;

namespace MtconnectTranspiler.Sinks.CSharp.Example.Models
{
    [ScribanTemplate("MtconnectCore.Class.scriban")]
    public class ExampleClass : Class
    {
        public ExampleClass(XmiDocument model, UmlClass source) : base(model, source) { }
    }
}
