using CaseExtensions;
using MtconnectTranspiler.Model;
using MtconnectTranspiler.Xmi.UML;

namespace MtconnectTranspiler.Sinks.CSharp.Models
{
    public class Property : MtconnectVersionedObject
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
                    _name = base.SysML_Name.ToPascalCase();
                }
                return _name;
            }
            set { _name = value; }
        }

        /// <summary>
        /// Reference to the access modifier for the property. Default is <c>public</c>
        /// </summary>
        public string AccessModifier { get; set; } = "public";

        /// <summary>
        /// Reference to the expected property type
        /// </summary>
        public string Type { get; set; }

        public Property(MTConnectModel model, UmlProperty source) : base(model, source)
        {
            if (source.Comments?.Length > 0)
            {
                Summary = new Summary(source.Comments);
            }

            AccessModifier = source.Visibility;

            Type = MTConnectHelperMethods.LookupCsharpDataType(model, source);
        }
    }
}
