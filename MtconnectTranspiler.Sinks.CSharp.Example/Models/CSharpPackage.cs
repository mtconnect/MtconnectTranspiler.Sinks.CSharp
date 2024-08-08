using CaseExtensions;
using MtconnectTranspiler.CodeGenerators.ScribanTemplates;
using MtconnectTranspiler.Sinks.CSharp.Models;
using MtconnectTranspiler.Xmi;
using MtconnectTranspiler.Xmi.UML;
using System.Data;

namespace MtconnectTranspiler.Sinks.CSharp.Example.Models
{
    [ScribanTemplate("CSharp.Package.scriban")]
    public class CSharpPackage : CsharpType, IFileSource
    {
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
                    _filename = $"{CategoryFunctions.ToPathSafe(Namespace.Substring(Namespace.LastIndexOf(".") + 1))}/{CategoryFunctions.ToPathSafe(Name.ToPascalCase())}.cs";
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

        /// <summary>
        /// Reference to any Comments written in the SysML model to be converted into a C# format <c>&lt;summary /&gt;</c>
        /// </summary>
        public Summary Summary { get; protected set; }

        public CSharpPackage(XmiDocument model, UmlPackage source) : base(model, source)
        {
            _name = CSharpHelperMethods.ToPascalCase(source.Name);

            ReferenceId = source!.Id;

            if (source.Comments?.Length > 0)
                Summary = new Summary(source.Comments);

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
