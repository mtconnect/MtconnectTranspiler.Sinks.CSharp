#pragma warning disable CS1574 // XML comment has cref attribute that could not be resolved
#pragma warning disable CS1584 // XML comment has syntactically incorrect cref attribute
#pragma warning disable CS0618 // Type or member is obsolete
using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;
using Package = Mtconnect.Glossary.XMLTerms;

namespace Mtconnect.Glossary
{
	/// <summary>﻿
	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Package___19_0_3_68e0225_1623664567542_661579_6860">model.mtconnect.org</seealso> for more information.
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public class XMLTermsPackage : IPackage
	{
		/// <summary>Constant value for <see cref="XMLTermsPackage.ReferenceId" /></summary>
		public const string REFERENCE_ID = "_19_0_3_68e0225_1623664567542_661579_6860";
		/// <summary>Constant value for <see cref="XMLTermsPackage.HelpUrl" /></summary>
		public const string HELP_URL = "https://model.mtconnect.org/#Package___19_0_3_68e0225_1623664567542_661579_6860";
		/// <summary>Constant value for <see cref="XMLTermsPackage.Name" /></summary>
		public const string NAME = "XML Terms";
		/// <summary>Constant value for <see cref="XMLTermsPackage.Summary" /></summary>
		public const string SUMMARY = @"";

		/// <inheritdoc />
		public string ReferenceId => REFERENCE_ID;
		
		/// <inheritdoc />
		public string HelpUrl => HELP_URL;
		
		/// <inheritdoc />
		public string Name => NAME;

		/// <inheritdoc />
		public string Summary => SUMMARY;

		/// <inheritdoc />
		public IPackage[] Packages => new IPackage[] {
		};
		
		/// <inheritdoc />
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
		
		/// <inheritdoc />
		public IEnum[] Enums => new IEnum[] {
		};

		#region Packages
	#endregion

	#region Classes
	private Package.NamespaceClass _NamespaceClass;
	/// <summary>
	/// <inheritdoc cref="Package.NamespaceClass" path="/summary" />
	/// </summary>
	public Package.NamespaceClass NamespaceClass => _NamespaceClass ?? (_NamespaceClass = new Package.NamespaceClass());

	private Package.XMLSchemaGeneralization _XMLSchemaGeneralization;
	/// <summary>
	/// <inheritdoc cref="Package.XMLSchemaGeneralization" path="/summary" />
	/// </summary>
	public Package.XMLSchemaGeneralization XMLSchemaGeneralization => _XMLSchemaGeneralization ?? (_XMLSchemaGeneralization = new Package.XMLSchemaGeneralization());

	private Package.RootElementGeneralization _RootElementGeneralization;
	/// <summary>
	/// <inheritdoc cref="Package.RootElementGeneralization" path="/summary" />
	/// </summary>
	public Package.RootElementGeneralization RootElementGeneralization => _RootElementGeneralization ?? (_RootElementGeneralization = new Package.RootElementGeneralization());

	private Package.DocumentBodyClass _DocumentBodyClass;
	/// <summary>
	/// <inheritdoc cref="Package.DocumentBodyClass" path="/summary" />
	/// </summary>
	public Package.DocumentBodyClass DocumentBodyClass => _DocumentBodyClass ?? (_DocumentBodyClass = new Package.DocumentBodyClass());

	private Package.XMLDocumentGeneralization _XMLDocumentGeneralization;
	/// <summary>
	/// <inheritdoc cref="Package.XMLDocumentGeneralization" path="/summary" />
	/// </summary>
	public Package.XMLDocumentGeneralization XMLDocumentGeneralization => _XMLDocumentGeneralization ?? (_XMLDocumentGeneralization = new Package.XMLDocumentGeneralization());

	private Package.DocumentHeaderClass _DocumentHeaderClass;
	/// <summary>
	/// <inheritdoc cref="Package.DocumentHeaderClass" path="/summary" />
	/// </summary>
	public Package.DocumentHeaderClass DocumentHeaderClass => _DocumentHeaderClass ?? (_DocumentHeaderClass = new Package.DocumentHeaderClass());

	private Package.AttributeClass _AttributeClass;
	/// <summary>
	/// <inheritdoc cref="Package.AttributeClass" path="/summary" />
	/// </summary>
	public Package.AttributeClass AttributeClass => _AttributeClass ?? (_AttributeClass = new Package.AttributeClass());

	private Package.AbstractElementGeneralization _AbstractElementGeneralization;
	/// <summary>
	/// <inheritdoc cref="Package.AbstractElementGeneralization" path="/summary" />
	/// </summary>
	public Package.AbstractElementGeneralization AbstractElementGeneralization => _AbstractElementGeneralization ?? (_AbstractElementGeneralization = new Package.AbstractElementGeneralization());

	private Package.ChildElementGeneralization _ChildElementGeneralization;
	/// <summary>
	/// <inheritdoc cref="Package.ChildElementGeneralization" path="/summary" />
	/// </summary>
	public Package.ChildElementGeneralization ChildElementGeneralization => _ChildElementGeneralization ?? (_ChildElementGeneralization = new Package.ChildElementGeneralization());

	private Package.ParentElementGeneralization _ParentElementGeneralization;
	/// <summary>
	/// <inheritdoc cref="Package.ParentElementGeneralization" path="/summary" />
	/// </summary>
	public Package.ParentElementGeneralization ParentElementGeneralization => _ParentElementGeneralization ?? (_ParentElementGeneralization = new Package.ParentElementGeneralization());

	private Package.StructuralElementClass _StructuralElementClass;
	/// <summary>
	/// <inheritdoc cref="Package.StructuralElementClass" path="/summary" />
	/// </summary>
	public Package.StructuralElementClass StructuralElementClass => _StructuralElementClass ?? (_StructuralElementClass = new Package.StructuralElementClass());

	private Package.ElementNameClass _ElementNameClass;
	/// <summary>
	/// <inheritdoc cref="Package.ElementNameClass" path="/summary" />
	/// </summary>
	public Package.ElementNameClass ElementNameClass => _ElementNameClass ?? (_ElementNameClass = new Package.ElementNameClass());

	#endregion

	#region Enums
	#endregion
	}
}