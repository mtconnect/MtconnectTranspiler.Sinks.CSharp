using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;

namespace Mtconnect.Glossary.ProtocolTerms
{
	/// <summary>
	/// <i>observation</i>s published by a piece of equipment defined by the <i>equipment metadata</i>.
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.3.0.0")]
	public sealed class StreamingDataClass : IClass
	{
		/// <inheritdoc />
		public string ReferenceId => "_19_0_3_68e0225_1623664375187_272252_2094";
		
		/// <inheritdoc />
		public string Summary => @"/// <i>observation</i>s published by a piece of equipment defined by the <i>equipment metadata</i>.";

		/// <inheritdoc />
		public string Name => "StreamingDataClass";
		
		/// <inheritdoc />
		public string AccessModifier => "public";
				
		/// <inheritdoc />
		public string Modifier => "";
				
		/// <inheritdoc />
		public string NormativeVersion => "";
				
		/// <inheritdoc />
		public string DeprecatedVersion => "";
		
		/// <inheritdoc />
		public string Generalization => "_19_0_3_68e0225_1623664375180_561625_2067";

		public IPropertyList Properties => null;

	}
}