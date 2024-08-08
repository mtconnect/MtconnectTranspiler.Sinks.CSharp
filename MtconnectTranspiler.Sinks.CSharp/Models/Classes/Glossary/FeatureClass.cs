using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;

namespace Mtconnect.Glossary
{
	/// <summary>
	/// topological entity(ies) or design requirements related to a geometric model. <seealso href="https://www.google.com/search?q=QIF 3.0-3.4.59&btnI=I">QIF 3.0-3.4.59</seealso>
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.3.0.0")]
	public sealed class FeatureClass : IClass
	{
		/// <inheritdoc />
		public string ReferenceId => "_19_0_3_68e0225_1677579525403_572309_444";
		
		/// <inheritdoc />
		public string Summary => @"/// topological entity(ies) or design requirements related to a geometric model. <seealso href=""https://www.google.com/search?q=QIF 3.0-3.4.59&btnI=I"">QIF 3.0-3.4.59</seealso>";

		/// <inheritdoc />
		public string Name => "FeatureClass";
		
		/// <inheritdoc />
		public string AccessModifier => "public";
				
		/// <inheritdoc />
		public string Modifier => "";
				
		/// <inheritdoc />
		public string NormativeVersion => "2.2";
				
		/// <inheritdoc />
		public string DeprecatedVersion => "";
		
		/// <inheritdoc />
		public string Generalization => "";

		public IPropertyList Properties => null;

	}
}