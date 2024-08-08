using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;

namespace Mtconnect.Glossary.ProtocolTerms
{
	/// <summary>
	/// method for an <i>agent</i> to provide a continuous stream of information in response to a single <i>request</i> from a <i>client</i>.
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.3.0.0")]
	public sealed class DataStreamingClass : IClass
	{
		/// <inheritdoc />
		public string ReferenceId => "_19_0_3_68e0225_1623664375154_395455_1977";
		
		/// <inheritdoc />
		public string Summary => @"/// method for an <i>agent</i> to provide a continuous stream of information in response to a single <i>request</i> from a <i>client</i>.";

		/// <inheritdoc />
		public string Name => "DataStreamingClass";
		
		/// <inheritdoc />
		public string AccessModifier => "public";
				
		/// <inheritdoc />
		public string Modifier => "";
				
		/// <inheritdoc />
		public string NormativeVersion => "";
				
		/// <inheritdoc />
		public string DeprecatedVersion => "";
		
		/// <inheritdoc />
		public string Generalization => "_19_0_3_68e0225_1623664375187_272252_2094";

		public IPropertyList Properties => null;

	}
}