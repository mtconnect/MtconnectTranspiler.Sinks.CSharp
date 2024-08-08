using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;

namespace Mtconnect.Glossary
{
	/// <summary>
	/// <i>standard uncertainty</i> of the result of a measurement when that result is obtained from the values of a number of other quantities, equal to the positive square root of a sum of terms, the terms being the variances or covariances of these other quantities weighted according to how the measurement result varies with changes in these quantities. <seealso href="https://www.google.com/search?q=JCGM 100:2008 2.3.4&btnI=I">JCGM 100:2008 2.3.4</seealso>
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.3.0.0")]
	public sealed class CombinedStandardUncertaintyClass : IClass
	{
		/// <inheritdoc />
		public string ReferenceId => "_19_0_3_68e0225_1678196848613_590918_17633";
		
		/// <inheritdoc />
		public string Summary => @"/// <i>standard uncertainty</i> of the result of a measurement when that result is obtained from the values of a number of other quantities, equal to the positive square root of a sum of terms, the terms being the variances or covariances of these other quantities weighted according to how the measurement result varies with changes in these quantities. <seealso href=""https://www.google.com/search?q=JCGM 100:2008 2.3.4&btnI=I"">JCGM 100:2008 2.3.4</seealso>";

		/// <inheritdoc />
		public string Name => "CombinedStandardUncertaintyClass";
		
		/// <inheritdoc />
		public string AccessModifier => "public";
				
		/// <inheritdoc />
		public string Modifier => "";
				
		/// <inheritdoc />
		public string NormativeVersion => "2.2";
				
		/// <inheritdoc />
		public string DeprecatedVersion => "";
		
		/// <inheritdoc />
		public string Generalization => "_19_0_3_68e0225_1678196842084_529316_17608";

		public IPropertyList Properties => null;

	}
}