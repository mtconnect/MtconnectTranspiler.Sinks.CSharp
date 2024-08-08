using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;

namespace Mtconnect.Glossary.XMLTerms
{
	/// <summary>
	/// element that defines a set of common characteristics that are shared by a group of elements. An abstract entity cannot appear in a document. In a specific implementation, an abstract entity is replaced by a derived element that is itself not an abstract entity. The characteristics for the derived element are inherited from the abstract entity.   
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.3.0.0")]
	public sealed class AbstractElementGeneralization : IClass
	{
		/// <inheritdoc />
		public string ReferenceId => "_19_0_3_68e0225_1623664375135_564027_1945";
		
		/// <inheritdoc />
		public string Summary => @"/// element that defines a set of common characteristics that are shared by a group of elements. An abstract entity cannot appear in a document. In a specific implementation, an abstract entity is replaced by a derived element that is itself not an abstract entity. The characteristics for the derived element are inherited from the abstract entity.   ";

		/// <inheritdoc />
		public string Name => "AbstractElementGeneralization";
		
		/// <inheritdoc />
		public string AccessModifier => "public";
				
		/// <inheritdoc />
		public string Modifier => "";
				
		/// <inheritdoc />
		public string NormativeVersion => "";
				
		/// <inheritdoc />
		public string DeprecatedVersion => "";
		
		/// <inheritdoc />
		public string Generalization => "_19_0_3_68e0225_1623664375158_867680_1986";

		public IPropertyList Properties => null;

	}
}