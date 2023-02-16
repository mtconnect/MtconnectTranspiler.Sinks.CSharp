using MtconnectTranspiler.Model;
using MtconnectTranspiler.Xmi.UML;

namespace MtconnectTranspiler.Sinks.CSharp.Models
{
    public class EnumItem : MtconnectVersionedObject
    {
        /// <summary>
        /// Reference to any Comments written in the SysML model to be converted into a C# format <c>&lt;summary /&gt;</c>
        /// </summary>
        public Summary Summary { get; protected set; }

        protected string _name { get; set; }
        public string Name
        {
            get
            {
                if (string.IsNullOrEmpty(_name))
                {
                    _name = ScribanHelperMethods.ToSnakeCase(base.SysML_Name);
                }
                return _name;
            }
            set { _name = value; }
        }

        public EnumItem(MTConnectModel model, UmlEnumerationLiteral source) : base(model, source)
        {
            if (source?.Comments?.Length > 0)
            {
                Summary = new Summary(source.Comments);
            }
        }
        public EnumItem(MTConnectModel model, UmlClass source) : base(model, source)
        {
            if (source?.Comments?.Length > 0)
            {
                Summary = new Summary(source.Comments);
            }
        }
    }
}
