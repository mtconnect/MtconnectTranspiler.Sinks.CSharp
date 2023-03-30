using MtconnectTranspiler.Sinks.CSharp.Attributes;
using MtconnectTranspiler.Xmi;
using MtconnectTranspiler.Xmi.UML;
using System.Collections.Generic;
using System.Linq;

namespace MtconnectTranspiler.Sinks.CSharp.Models
{
    /// <summary>
    /// Represents a C# class
    /// </summary>
    [ScribanTemplate("Class.scriban")]
    public partial class Class : CsharpType, IFileSource
    {
        /// <summary>
        /// Reference to the xmi:id
        /// </summary>
        public string ReferenceId { get; set; }

        /// <summary>
        /// Reference to any Comments written in the SysML model to be converted into a C# format <c>&lt;summary /&gt;</c>
        /// </summary>
        public Summary Summary { get; protected set; }

        /// <summary>
        /// Internal reference to the class filename.
        /// </summary>
        protected string _filename { get; set; }
        /// <inheritdoc />
        public string Filename
        {
            get
            {
                if (string.IsNullOrEmpty(_filename))
                    _filename = $"{Name}.cs";
                return _filename;
            }
            set { _filename = value; }
        }

        /// <summary>
        /// Internal list of <see cref="Property"/>, used by <see cref="Properties"/>.
        /// </summary>
        protected List<Property> _properties = new List<Property>();
        /// <summary>
        /// Collection of <inheritdoc cref="Property"/>
        /// </summary>
        public IEnumerable<Property> Properties => _properties;

        /// <summary>
        /// Internal list of <see cref="Constraint"/>, used by <see cref="Constraints"/>.
        /// </summary>
        protected List<Constraint> _constraints = new List<Constraint>();
        /// <summary>
        /// Collection of <inheritdoc cref="Constraint"/>
        /// </summary>
        public IEnumerable<Constraint> Constraints => _constraints;

        /// <summary>
        /// Constructs an <see cref="Class"/> more generically. <b>NOTE</b>: You'll need to add items manually from here.
        /// </summary>
        /// <param name="model"><inheritdoc cref="XmiDocument" path="/summary"/></param>
        /// <param name="source"><inheritdoc cref="XmiElement" path="/summary"/></param>
        public Class(XmiDocument model, UmlClass source) : base(model, source)
        {
            ReferenceId = source.Id;

            if (source.Comments?.Length > 0)
                Summary = new Summary(source.Comments);

            if (source.IsAbstract)
                Modifier = "abstract";

            _properties = source.Properties
                ?.Select(o => new Property(model, o))
                ?.ToList();

            _constraints = source.Constraints
                ?.Select(o => new Constraint(model, o))
                ?.ToList();
        }

        /// <summary>
        /// Adds a new <see cref="Property"/>
        /// </summary>
        /// <param name="property">Reference to the source <see cref="Property"/> to add</param>
        public void Add(Property property)
            => _properties.Add(property);

    }
}
