using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;

namespace Mtconnect.Glossary
{
	/// <summary>
	/// indication that specific content in an <i>MTConnect Document</i> may be changed to <i>deprecated</i> in a future release of the standard.
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.3.0.0")]
	public sealed class DeprecationWarningClass : IClass
	{
		/// <inheritdoc />
		public string ReferenceId => "_19_0_3_68e0225_1623664375155_239668_1979";
		
		/// <inheritdoc />
		public string Summary => @"/// indication that specific content in an <i>MTConnect Document</i> may be changed to <i>deprecated</i> in a future release of the standard.";

		/// <inheritdoc />
		public string Name => "DeprecationWarningClass";
		
		/// <inheritdoc />
		public string AccessModifier => "public";
				
		/// <inheritdoc />
		public string Modifier => "";
				
		/// <inheritdoc />
		public string NormativeVersion => "";
				
		/// <inheritdoc />
		public string DeprecatedVersion => "";
		
		/// <inheritdoc />
		public string Generalization => "";

		public IPropertyList Properties => null;

	}
}