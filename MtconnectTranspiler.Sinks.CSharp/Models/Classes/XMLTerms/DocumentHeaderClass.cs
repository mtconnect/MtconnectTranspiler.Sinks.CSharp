using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;

namespace Mtconnect.Glossary.XMLTerms
{
	/// <summary>
	﻿/// portion of the content of an <i>MTConnect Response Document</i> that provides information from an <i>agent</i> defining version information, storage capacity, protocol, and other information associated with the management of the data stored in or retrieved from the <i>agent</i>.<br /><br/><br />

	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Structure___19_0_3_68e0225_1623664375157_278948_1984">model.mtconnect.org</seealso> for more information.
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public sealed class DocumentHeaderClass : IClass
	{
		/// <inheritdoc />
		public string ReferenceId => "_19_0_3_68e0225_1623664375157_278948_1984";
		
		/// <inheritdoc />
		public string Summary => @"&#10;&#10;&#10;portion of the content of an {{term(MTConnect Response Document)}} that provides information from an {{term(agent)}} defining version information, storage capacity, protocol, and other information associated with the management of the data stored in or retrieved from the {{term(agent)}}.
&#10;
";

		/// <inheritdoc />
		public string Name => "document header";
		
		/// <inheritdoc />
		public string AccessModifier => "public";
				
		/// <inheritdoc />
		public string Modifier => "";
				
		/// <inheritdoc />
		public string NormativeVersion => "";
				
		/// <inheritdoc />
		public string DeprecatedVersion => "";
		
		/// <inheritdoc />
		public Type Generalization => null;

		/// <inheritdoc />
		public DocumentHeaderClassProperties Properties { get; } = new DocumentHeaderClassProperties();
        IPropertyList IClass.Properties => Properties;
		public class DocumentHeaderClassProperties : IPropertyList
		{
			/// <inheritdoc />
			public IProperty[] Properties => new IProperty[] {
			};
		};

	}
}