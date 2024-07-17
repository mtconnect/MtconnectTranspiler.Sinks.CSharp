using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;
using Package = Mtconnect.Glossary.XMLTerms;
// using Mtconnect;

namespace Mtconnect.Glossary {
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "1.0.15.3")]
	public class XMLTermsPackage : IPackage {
		public IPackage[] Packages => new IPackage[] {
		};

		public IClass[] Classes => new IClass[] {
			NamespaceClass,
			XMLSchemaGeneralization,
			RootElementGeneralization,
			DocumentBodyClass,
			XMLDocumentGeneralization,
			DocumentHeaderClass,
			AttributeClass,
			AbstractElementGeneralization,
			ChildElementGeneralization,
			ParentElementGeneralization,
			StructuralElementClass,
			ElementNameClass,
		};

	private Package.NamespaceClass _NamespaceClass;
	public Package.NamespaceClass NamespaceClass => _NamespaceClass ?? (_NamespaceClass = new Package.NamespaceClass());
	private Package.XMLSchemaGeneralization _XMLSchemaGeneralization;
	public Package.XMLSchemaGeneralization XMLSchemaGeneralization => _XMLSchemaGeneralization ?? (_XMLSchemaGeneralization = new Package.XMLSchemaGeneralization());
	private Package.RootElementGeneralization _RootElementGeneralization;
	public Package.RootElementGeneralization RootElementGeneralization => _RootElementGeneralization ?? (_RootElementGeneralization = new Package.RootElementGeneralization());
	private Package.DocumentBodyClass _DocumentBodyClass;
	public Package.DocumentBodyClass DocumentBodyClass => _DocumentBodyClass ?? (_DocumentBodyClass = new Package.DocumentBodyClass());
	private Package.XMLDocumentGeneralization _XMLDocumentGeneralization;
	public Package.XMLDocumentGeneralization XMLDocumentGeneralization => _XMLDocumentGeneralization ?? (_XMLDocumentGeneralization = new Package.XMLDocumentGeneralization());
	private Package.DocumentHeaderClass _DocumentHeaderClass;
	public Package.DocumentHeaderClass DocumentHeaderClass => _DocumentHeaderClass ?? (_DocumentHeaderClass = new Package.DocumentHeaderClass());
	private Package.AttributeClass _AttributeClass;
	public Package.AttributeClass AttributeClass => _AttributeClass ?? (_AttributeClass = new Package.AttributeClass());
	private Package.AbstractElementGeneralization _AbstractElementGeneralization;
	public Package.AbstractElementGeneralization AbstractElementGeneralization => _AbstractElementGeneralization ?? (_AbstractElementGeneralization = new Package.AbstractElementGeneralization());
	private Package.ChildElementGeneralization _ChildElementGeneralization;
	public Package.ChildElementGeneralization ChildElementGeneralization => _ChildElementGeneralization ?? (_ChildElementGeneralization = new Package.ChildElementGeneralization());
	private Package.ParentElementGeneralization _ParentElementGeneralization;
	public Package.ParentElementGeneralization ParentElementGeneralization => _ParentElementGeneralization ?? (_ParentElementGeneralization = new Package.ParentElementGeneralization());
	private Package.StructuralElementClass _StructuralElementClass;
	public Package.StructuralElementClass StructuralElementClass => _StructuralElementClass ?? (_StructuralElementClass = new Package.StructuralElementClass());
	private Package.ElementNameClass _ElementNameClass;
	public Package.ElementNameClass ElementNameClass => _ElementNameClass ?? (_ElementNameClass = new Package.ElementNameClass());
	}
}