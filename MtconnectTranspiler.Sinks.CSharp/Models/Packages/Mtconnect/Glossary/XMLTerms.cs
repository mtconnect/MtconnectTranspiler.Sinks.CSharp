
using System;
using System.CodeDom.Compiler;
using Package = Mtconnect.Glossary.XMLTerms;

using Mtconnect;

namespace Mtconnect.Glossary {
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "1.0.15.3")]
	public class XMLTermsPackage {


	private Package.NamespaceClass _Namespace;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.NamespaceClass Namespace => _Namespace ?? (_Namespace = new Package.NamespaceClass());

	private Package.XMLSchemaClass _XMLSchema;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.XMLSchemaClass XMLSchema => _XMLSchema ?? (_XMLSchema = new Package.XMLSchemaClass());

	private Package.RootElementClass _RootElement;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.RootElementClass RootElement => _RootElement ?? (_RootElement = new Package.RootElementClass());

	private Package.DocumentBodyClass _DocumentBody;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.DocumentBodyClass DocumentBody => _DocumentBody ?? (_DocumentBody = new Package.DocumentBodyClass());

	private Package.XMLDocumentClass _XMLDocument;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.XMLDocumentClass XMLDocument => _XMLDocument ?? (_XMLDocument = new Package.XMLDocumentClass());

	private Package.DocumentHeaderClass _DocumentHeader;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.DocumentHeaderClass DocumentHeader => _DocumentHeader ?? (_DocumentHeader = new Package.DocumentHeaderClass());

	private Package.AttributeClass _Attribute;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.AttributeClass Attribute => _Attribute ?? (_Attribute = new Package.AttributeClass());

	private Package.AbstractElementClass _AbstractElement;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.AbstractElementClass AbstractElement => _AbstractElement ?? (_AbstractElement = new Package.AbstractElementClass());

	private Package.ChildElementClass _ChildElement;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.ChildElementClass ChildElement => _ChildElement ?? (_ChildElement = new Package.ChildElementClass());

	private Package.ParentElementClass _ParentElement;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.ParentElementClass ParentElement => _ParentElement ?? (_ParentElement = new Package.ParentElementClass());

	private Package.StructuralElementClass _StructuralElement;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.StructuralElementClass StructuralElement => _StructuralElement ?? (_StructuralElement = new Package.StructuralElementClass());

	private Package.ElementNameClass _ElementName;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.ElementNameClass ElementName => _ElementName ?? (_ElementName = new Package.ElementNameClass());
	}
}