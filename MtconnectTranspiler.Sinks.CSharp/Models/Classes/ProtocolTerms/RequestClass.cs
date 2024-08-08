using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;

namespace Mtconnect.Glossary.ProtocolTerms
{
	/// <summary>
	/// communications method where a <i>client</i> transmits a message to an <i>agent</i>.  That message instructs the <i>agent</i> to respond with specific information.
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.3.0.0")]
	public sealed class RequestClass : IClass
	{
		/// <inheritdoc />
		public string ReferenceId => "_19_0_3_68e0225_1623664375181_991321_2071";
		
		/// <inheritdoc />
		public string Summary => @"/// communications method where a <i>client</i> transmits a message to an <i>agent</i>.  That message instructs the <i>agent</i> to respond with specific information.";

		/// <inheritdoc />
		public string Name => "RequestClass";
		
		/// <inheritdoc />
		public string AccessModifier => "public";
				
		/// <inheritdoc />
		public string Modifier => "";
				
		/// <inheritdoc />
		public string NormativeVersion => "";
				
		/// <inheritdoc />
		public string DeprecatedVersion => "";
		
		/// <inheritdoc />
		public string Generalization => "_19_0_3_68e0225_1623664375180_471026_2065";

		public IPropertyList Properties => null;

	}
}