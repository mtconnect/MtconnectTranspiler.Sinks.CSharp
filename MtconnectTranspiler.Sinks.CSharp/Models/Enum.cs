using MtconnectTranspiler.Model;
using MtconnectTranspiler.Sinks.CSharp.Attributes;
using MtconnectTranspiler.Xmi;
using MtconnectTranspiler.Xmi.UML;
using System.Collections.Generic;
using System.Linq;

namespace MtconnectTranspiler.Sinks.CSharp.Models
{
    [ScribanTemplate("Enum.scriban")]
    public class Enum : MtconnectVersionedObject, IFileSource
    {
        /// <summary>
        /// Reference to any Comments written in the SysML model to be converted into a C# format <c>&lt;summary /&gt;</c>
        /// </summary>
        public Summary Summary { get; protected set; }

        protected string _name { get; set; }
        /// <inheritdoc />
        public string Name {
            get {
                if (string.IsNullOrEmpty(_name))
                {
                    _name = ScribanHelperMethods.ToPascalCase(base.SysML_Name);
                }
                return _name;
            }
            set { _name = value; }
        }

        protected List<EnumItem> _items { get; set; } = new List<EnumItem>();
        /// <summary>
        /// Collection of Enum values
        /// </summary>
        public EnumItem[] Items => _items.ToArray();

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

        /// <summary>
        /// Constructs an <see cref="Enum"/> more generically. **NOTE**: You'll need to add items manually from here.
        /// </summary>
        /// <param name="model"><inheritdoc cref="MTConnectModel" path="/summary"/></param>
        /// <param name="source"><inheritdoc cref="XmiElement" path="/summary"/></param>
        /// <param name="name"><inheritdoc cref="Name"/></param>
        public Enum(MTConnectModel model, XmiElement source, string name) : base(model,source)
        {
            Name = name;
        }
        public Enum(MTConnectModel model, UmlEnumeration source) : base(model, source)
        {
            AddItems(model, source.Items);
        }
        public Enum(MTConnectModel model, UmlPackage source) : base(model, source)
        {
            AddItems(model, source.Elements?.Where(o => o is UmlClass)?.Select(o => o as UmlClass)?.ToList());
            
            if (source.Comments?.Length > 0)
            {
                Summary = new Summary(source.Comments);
            }
        }
        public Enum(MTConnectModel model, MTConnectDeviceInformationModel source) : base(model, source)
        {
            AddItems(model, source.Classes);

            if (source.Comments?.Length > 0)
            {
                Summary = new Summary(source.Comments);
            }
        }

        public void AddItem(MTConnectModel model, UmlClass item)
        {
            var enumItem = new EnumItem(model, item);
            _items.Add(enumItem);
        }
        public void AddItem(MTConnectModel model, UmlEnumerationLiteral item)
        {
            var enumItem = new EnumItem(model, item);
            _items.Add(enumItem);
        }

        public void AddItems(MTConnectModel model, IEnumerable<UmlClass> items)
        {
            if (items == null) return;

            var arr = items.ToArray();
            if (arr.Length <= 0) return;

            foreach (var item in arr)
            {
                AddItem(model, item);
            }
        }
        public void AddItems(MTConnectModel model, IEnumerable<UmlEnumerationLiteral> items)
        {
            if (items == null) return;

            var arr = items.ToArray();
            if (arr.Length <= 0) return;

            foreach (var item in arr)
            {
                AddItem(model, item);
            }
        }
    }
}
