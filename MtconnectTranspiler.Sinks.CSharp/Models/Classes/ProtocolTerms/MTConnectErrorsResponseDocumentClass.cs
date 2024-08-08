using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;

namespace Mtconnect.Glossary.ProtocolTerms
{
	/// <summary>
	/// <i>response document</i> published by an <i>MTConnect Agent</i> whenever it encounters an error while interpreting an <i>MTConnect Request</i>.
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.3.0.0")]
	public sealed class MTConnectErrorsResponseDocumentClass : IClass
	{
		/// <inheritdoc />
		public string ReferenceId => "_19_0_3_68e0225_1623664375174_389187_2045";
		
		/// <inheritdoc />
		public string Summary => @"/// <i>response document</i> published by an <i>MTConnect Agent</i> whenever it encounters an error while interpreting an <i>MTConnect Request</i>.";

		/// <inheritdoc />
		public string Name => "MTConnectErrorsResponseDocumentClass";
		
		/// <inheritdoc />
		public string AccessModifier => "public";
				
		/// <inheritdoc />
		public string Modifier => "";
				
		/// <inheritdoc />
		public string NormativeVersion => "";
				
		/// <inheritdoc />
		public string DeprecatedVersion => "";
		
		/// <inheritdoc />
		public string Generalization => "_19_0_3_68e0225_1623664375173_527411_2040";

		public IPropertyList Properties => null;

	}
}