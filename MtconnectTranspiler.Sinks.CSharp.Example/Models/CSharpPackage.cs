using CaseExtensions;
using MtconnectTranspiler.Sinks.CSharp.Models;
using MtconnectTranspiler.Sinks.Models;
using MtconnectTranspiler.Sinks.ScribanTemplates;
using MtconnectTranspiler.Xmi;
using MtconnectTranspiler.Xmi.UML;
using System.Data;

namespace MtconnectTranspiler.Sinks.CSharp.Example.Models
{
    [ScribanTemplate("CSharp.Package.scriban")]
    public class CSharpPackage : IFileSource
    {
        /// <summary>
        /// The intended namespace for the C# type.
        /// </summary>
        public virtual string Namespace { get; set; } = "Mtconnect";

        /// <summary>
        /// Internal string, used by <see cref="Name"/>.
        /// </summary>
        protected string _name { get; set; }
        /// <summary>
        /// The intended name for the C# type.
        /// </summary>
        public new string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        /// <summary>
        /// Reference to the xmi:id
        /// </summary>
        public string ReferenceId { get; set; }

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
                    _filename = $"{Namespace.Replace(".", "/").Replace(":", "_")}/{Name.ToPascalCase().Replace(":", "_")}.cs";
                return _filename;
            }
            set { _filename = value; }
        }

        /// <summary>
        /// Internal list of <see cref="CSharpPackage"/>, used by <see cref="Packages"/>.
        /// </summary>
        protected List<CSharpPackage> _packages = new List<CSharpPackage>();
        /// <summary>
        /// Collection of <inheritdoc cref="CSharpPackage"/>
        /// </summary>
        public new IEnumerable<CSharpPackage> Packages => _packages;

        /// <summary>
        /// Internal list of <see cref="CSharpClass"/>, used by <see cref="Classes"/>.
        /// </summary>
        protected List<CSharpClass> _classes = new List<CSharpClass>();
        /// <summary>
        /// Collection of <inheritdoc cref="CSharpClass"/>
        /// </summary>
        public new IEnumerable<CSharpClass> Classes => _classes;

        /// <summary>
        /// Internal list of <see cref="CSharpEnum"/>, used by <see cref="Enums"/>.
        /// </summary>
        protected List<CSharpEnum> _enums = new List<CSharpEnum>();
        /// <summary>
        /// Collection of <inheritdoc cref="CSharpEnum"/>
        /// </summary>
        public IEnumerable<CSharpEnum> Enums => _enums;

        public CSharpPackage(XmiDocument model, UmlPackage source) : base()
        {
            _name = CSharpHelperMethods.ToPascalCase(source.Name);

            ReferenceId = source!.Id;

            _packages = source!.Packages
                ?.Select(o => new CSharpPackage(model, o))
                ?.ToList()
                ?? new List<CSharpPackage>();

            _classes = source!.Classes
                ?.Select(o => new CSharpClass(model, o))
                ?.ToList()
                ?? new List<CSharpClass>();

            _enums = source!.Enumerations
                ?.Select(o => new CSharpEnum(model, o))
                ?.ToList()
                ?? new List<CSharpEnum>();
        }
    }
}
