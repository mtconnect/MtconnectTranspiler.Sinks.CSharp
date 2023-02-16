using CaseExtensions;
using MtconnectTranspiler.Model;
using MtconnectTranspiler.Sinks.CSharp.Attributes;
using MtconnectTranspiler.Xmi.UML;
using System.Linq;

namespace MtconnectTranspiler.Sinks.CSharp.Models
{
    [ScribanTemplate("Class.scriban")]
    public partial class Class : MtconnectVersionedObject, IFileSource
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
            set
            {
                _name = value;
            }
        }

        protected string _filename { get; set; }
        /// <inheritdoc />
        public string Filename
        {
            get
            {
                if (string.IsNullOrEmpty(_filename))
                {
                    _filename = $"{Name}.cs";
                }
                return _filename;
            }
            set { _filename = value; }
        }

        /// <inheritdoc />
        public string Namespace { get; set; }

        public string AccessModifier { get; set; } = "public";

        public string Modifier { get; set; }

        public Property[] Items { get; set; }

        public Constraint[] Constraints { get; set; }

        public Class(MTConnectModel model, UmlClass source) : base(model, source)
        {
            if (source.Comments?.Length > 0)
            {
                Summary = new Summary(source.Comments);
            }

            if (source.IsAbstract)
            {
                Modifier = "abstract";
            }

            Items = source.Properties
                ?.Select(o => new Property(model, o))
                ?.ToArray();

            Constraints = source.Constraints
                ?.Select(o => new Constraint(model, o))
                ?.ToArray();
        }
    }
}
