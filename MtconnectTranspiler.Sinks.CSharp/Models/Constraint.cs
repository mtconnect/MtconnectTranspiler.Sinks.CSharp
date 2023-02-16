using CaseExtensions;
using MtconnectTranspiler.Model;
using MtconnectTranspiler.Xmi.UML;

namespace MtconnectTranspiler.Sinks.CSharp.Models
{
    public class Constraint : MtconnectVersionedObject
    {
        protected string _name { get; set; }
        public string Name
        {
            get
            {
                if (string.IsNullOrEmpty(_name))
                {
                    _name = base.SysML_Name.ToPascalCase();
                }
                return _name;
            }
            set { _name = value; }
        }

        public string SourceLanguage { get; set; } = "Unspecified";

        public string RawScript { get; set; }

        public Constraint(MTConnectModel model, UmlConstraint source) : base(model, source)
        {
            SourceLanguage = source.Specification?.Language;
            RawScript = source.Specification?.Body;
        }
    }
}
