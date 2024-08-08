using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;

namespace Mtconnect.Glossary
{
	/// <summary>
	/// <i>archetype</i> provides the requirements, constraints, and common properties for a type of <i>Asset</i>.
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.3.0.0")]
	public sealed class ArchetypeClass : IClass
	{
		/// <inheritdoc />
		public string ReferenceId => "_19_0_3_68e0225_1623664375141_294923_1950";
		
		/// <inheritdoc />
		public string Summary => @"/// <i>archetype</i> provides the requirements, constraints, and common properties for a type of <i>Asset</i>.";

		/// <inheritdoc />
		public string Name => "ArchetypeClass";
		
		/// <inheritdoc />
		public string AccessModifier => "public";
				
		/// <inheritdoc />
		public string Modifier => "";
				
		/// <inheritdoc />
		public string NormativeVersion => "";
				
		/// <inheritdoc />
		public string DeprecatedVersion => "";
		
		/// <inheritdoc />
		public string Generalization => "_19_0_3_45f01b9_1580561892811_529841_16867";

		public IPropertyList Properties => null;

	}
}