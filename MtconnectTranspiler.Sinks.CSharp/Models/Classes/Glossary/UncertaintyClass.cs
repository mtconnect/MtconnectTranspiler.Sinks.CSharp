using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;

namespace Mtconnect.Glossary
{
	/// <summary>
	/// uncertainty (of measurement) parameter, associated with the result of a measurement, that characterizes the dispersion of the values that could reasonably be attributed to the measurand. <seealso href="https://www.google.com/search?q=JCGM 100:2008 2.2.3&btnI=I">JCGM 100:2008 2.2.3</seealso>  > Note: Use of the term uncertainty refers to uncertainty of measurement.
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.3.0.0")]
	public sealed class UncertaintyClass : IClass
	{
		/// <inheritdoc />
		public string ReferenceId => "_19_0_3_68e0225_1678196835831_469201_17550";
		
		/// <inheritdoc />
		public string Summary => @"/// uncertainty (of measurement) parameter, associated with the result of a measurement, that characterizes the dispersion of the values that could reasonably be attributed to the measurand. <seealso href=""https://www.google.com/search?q=JCGM 100:2008 2.2.3&btnI=I"">JCGM 100:2008 2.2.3</seealso>  > Note: Use of the term uncertainty refers to uncertainty of measurement.";

		/// <inheritdoc />
		public string Name => "UncertaintyClass";
		
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