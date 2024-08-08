using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;

namespace Mtconnect.Glossary
{
	/// <summary>
	/// ability for an implementer to extend <i>MTConnect Information Model</i> by adding content not currently addressed in the MTConnect Standard. 
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.3.0.0")]
	public sealed class ExtensibleClass : IClass
	{
		/// <inheritdoc />
		public string ReferenceId => "_19_0_3_68e0225_1623664375160_631627_1992";
		
		/// <inheritdoc />
		public string Summary => @"/// ability for an implementer to extend <i>MTConnect Information Model</i> by adding content not currently addressed in the MTConnect Standard. ";

		/// <inheritdoc />
		public string Name => "ExtensibleClass";
		
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