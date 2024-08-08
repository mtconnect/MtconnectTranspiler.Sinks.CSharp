using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;

namespace Mtconnect.Glossary
{
	/// <summary>
	/// describes a set of <i>streaming data</i> in an <i>agent</i>.  Each time an <i>agent</i> is restarted with an empty <i>buffer</i>, data placed in the <i>buffer</i> represents a new <i>instance</i> of the <i>agent</i>.
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.3.0.0")]
	public sealed class InstanceClass : IClass
	{
		/// <inheritdoc />
		public string ReferenceId => "_19_0_3_68e0225_1623664375166_228257_2016";
		
		/// <inheritdoc />
		public string Summary => @"/// describes a set of <i>streaming data</i> in an <i>agent</i>.  Each time an <i>agent</i> is restarted with an empty <i>buffer</i>, data placed in the <i>buffer</i> represents a new <i>instance</i> of the <i>agent</i>.";

		/// <inheritdoc />
		public string Name => "InstanceClass";
		
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