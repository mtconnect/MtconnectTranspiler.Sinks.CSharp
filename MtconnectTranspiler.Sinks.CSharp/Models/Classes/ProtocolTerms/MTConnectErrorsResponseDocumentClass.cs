#pragma warning disable CS0109 // Member does not hide an inherited member; new keyword is not required
#pragma warning disable CS1574 // XML comment has cref attribute that could not be resolved
#pragma warning disable CS1584 // XML comment has syntactically incorrect cref attribute
using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;
using System.Linq;

namespace Mtconnect.Glossary.ProtocolTerms
{
	/// <summary>﻿<i>response document</i> published by an <i>MTConnect Agent</i> whenever it encounters an error while interpreting an <i>MTConnect Request</i>.<br /><br /><br />
	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Structure___19_0_3_68e0225_1623664375174_389187_2045">model.mtconnect.org</seealso> for more information.
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public sealed class MTConnectErrorsResponseDocumentClass : IClass
	{
		/// <inheritdoc />
		public string ReferenceId => "_19_0_3_68e0225_1623664375174_389187_2045";
		
		/// <inheritdoc />
		public string Summary => @"&#10;&#10;&#10;{{term(response document)}} published by an {{term(MTConnect Agent)}} whenever it encounters an error while interpreting an {{term(MTConnect Request)}}.&#10;
";

		/// <inheritdoc />
		public string Name => "MTConnectErrors Response Document";
		
		/// <inheritdoc />
		public string AccessModifier => "public";
				
		/// <inheritdoc />
		public string Modifier => "";
				
		/// <inheritdoc />
		public string NormativeVersion => "";
				
		/// <inheritdoc />
		public string DeprecatedVersion => "";
		
		/// <inheritdoc />
		/// <remarks>
		/// Original Type: _19_0_3_68e0225_1623664375173_527411_2040
		/// </remarks>
		public Type Generalization => typeof(Mtconnect.Glossary.ProtocolTerms.MTConnectResponseDocumentClass);

		/// <inheritdoc />
		public new MTConnectErrorsResponseDocumentClassProperties Properties { get; } = new MTConnectErrorsResponseDocumentClassProperties();
        IPropertyList IClass.Properties => Properties;
		/// <summary>
		/// Property list for <see cref="MTConnectErrorsResponseDocumentClass" />.
		/// <br/><b>Note</b>, some properties (<see cref="IProperty" />) are inherited from <see cref="Mtconnect.Glossary.ProtocolTerms.MTConnectResponseDocumentClass.MTConnectResponseDocumentClassProperties" />.
		/// </summary>
		public class MTConnectErrorsResponseDocumentClassProperties : Mtconnect.Glossary.ProtocolTerms.MTConnectResponseDocumentClass.MTConnectResponseDocumentClassProperties
		{
			/// <inheritdoc />
			public new IProperty[] Properties => new IProperty[] {
			}.Concat(base.Properties).ToArray();
		};

	}
}