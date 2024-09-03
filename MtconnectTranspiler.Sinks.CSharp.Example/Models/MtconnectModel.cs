using MtconnectTranspiler.Sinks.CSharp.Models;
using MtconnectTranspiler.Xmi.UML;
using MtconnectTranspiler.Xmi;
using MtconnectTranspiler.CodeGenerators.ScribanTemplates;

namespace MtconnectTranspiler.Sinks.CSharp.Example.Models
{
    [ScribanTemplate("CSharp.Model.scriban")]
    public class MtconnectModel : CsharpType, IFileSource
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
                    _filename = $"MtconnectModel.cs";
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
        public IEnumerable<CSharpPackage> Packages => _packages;

        public MtconnectModel(XmiDocument model, UmlModel source) : base(model, source)
        {
            _name = CSharpHelperMethods.ToPascalCase(source.Name);

            ReferenceId = source!.Id;

            _packages = source!.Packages
                ?.Select(o => new CSharpPackage(model, o))
                ?.ToList()
                ?? new List<CSharpPackage>();
            foreach(var profile in source!.Profiles)
            {
                foreach (var package in profile.Packages)
                {
                    _packages.Add(new CSharpPackage(model, package));
                }
            }
        }
    }
}
