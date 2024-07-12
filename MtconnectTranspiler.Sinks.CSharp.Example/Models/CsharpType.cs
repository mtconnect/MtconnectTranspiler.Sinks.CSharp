using MtconnectTranspiler.Sinks.CSharp.Example;
using MtconnectTranspiler.Sinks.CSharp.Example.Models;
using MtconnectTranspiler.Xmi;

namespace MtconnectTranspiler.Sinks.CSharp.Models
{
    /// <summary>
    /// Represents the abstract for many C# types
    /// </summary>
    public abstract class CsharpType : MtconnectVersionedObject
    {
        private string _namespace = "Mtconnect";
        /// <summary>
        /// The intended namespace for the C# type.
        /// </summary>
        public virtual string Namespace
        {
            get { return _namespace; }
            set
            {
                _namespace = value;
                switch (this)
                {
                    case CSharpClass csharpClass:
                        TypeCache.RegisterType($"{csharpClass.Name}Class", csharpClass.Namespace);
                        break;
                    case Property csharpProperty:
                        TypeCache.RegisterType(csharpProperty.Name, csharpProperty.Namespace);
                        break;
                    case CSharpPackage csharpPackage:
                        TypeCache.RegisterType(csharpPackage.Name, csharpPackage.Namespace);
                        break;
                    case CSharpEnum csharpEnum:
                        TypeCache.RegisterType(csharpEnum.Name, csharpEnum.Namespace);
                        break;
                    default:
                        break;
                }
            }
        }

        /// <summary>
        /// Internal string, used by <see cref="Name"/>.
        /// </summary>
        protected string _name { get; set; }
        /// <summary>
        /// The intended name for the C# type.
        /// </summary>
        public virtual string Name
        {
            get
            {
                if (string.IsNullOrEmpty(_name))
                    _name = CSharpHelperMethods.ToPascalCase(base.SysML_Name);
                return _name;
            }
            set { _name = value; }
        }

        /// <summary>
        /// The accessibilty of the C# type.
        /// <list type="bullet">
        /// <item>public</item>
        /// <item>private</item>
        /// <item>protected</item>
        /// <item>internal</item>
        /// <item>protected internal</item>
        /// <item>private protected</item>
        /// </list>
        /// </summary>
        public string AccessModifier { get; set; } = "public";

        /// <summary>
        /// A modifier for the C# type.
        /// <list type="bullet">
        /// <item>abstract</item>
        /// <item>static</item>
        /// <item>sealed</item>
        /// <item>const</item>
        /// <item>event</item>
        /// <item>override</item>
        /// <item>virtual</item>
        /// <item>volatile</item>
        /// <item>extern</item>
        /// </list>
        /// </summary>
        public string Modifier { get; set; }

        /// <summary>
        /// Constructs an <see cref="CsharpType"/> more generically. <b>NOTE</b>: You'll need to add items manually from here.
        /// </summary>
        /// <param name="model"><inheritdoc cref="XmiDocument" path="/summary"/></param>
        /// <param name="source"><inheritdoc cref="XmiElement" path="/summary"/></param>
        protected CsharpType(XmiDocument model, XmiElement source) : base(model, source) { }
    }
}
