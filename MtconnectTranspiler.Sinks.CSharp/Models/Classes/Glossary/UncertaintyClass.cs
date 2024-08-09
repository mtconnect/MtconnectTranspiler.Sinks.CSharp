using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;

namespace Mtconnect.Glossary
{
	/// <summary>
	/// uncertainty (of measurement) parameter, associated with the result of a measurement, that characterizes the dispersion of the values that could reasonably be attributed to the measurand. <seealso href="https://www.google.com/search?q=JCGM 100:2008 2.2.3&btnI=I">JCGM 100:2008 2.2.3</seealso>  > Note: Use of the term uncertainty refers to uncertainty of measurement.
	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Structure___19_0_3_68e0225_1678196835831_469201_17550">model.mtconnect.org</seealso> for more information.
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.3.0.0")]
	public sealed class UncertaintyClass : IClass
	{
		/// <inheritdoc />
		public string ReferenceId => "_19_0_3_68e0225_1678196835831_469201_17550";
		
		/// <inheritdoc />
		public string Summary => @"/// uncertainty (of measurement) parameter, associated with the result of a measurement, that characterizes the dispersion of the values that could reasonably be attributed to the measurand. <seealso href=""https://www.google.com/search?q=JCGM 100:2008 2.2.3&btnI=I"">JCGM 100:2008 2.2.3</seealso>  > Note: Use of the term uncertainty refers to uncertainty of measurement.";

		/// <inheritdoc />
		public string Name => "uncertainty";
		
		/// <inheritdoc />
		public string AccessModifier => "public";
				
		/// <inheritdoc />
		public string Modifier => "";
				
		/// <inheritdoc />
		public string NormativeVersion => "2.2";
				
		/// <inheritdoc />
		public string DeprecatedVersion => "";
		
		/// <inheritdoc />
		public Type Generalization => null;

		/// <inheritdoc />
		public UncertaintyClassProperties Properties { get; } = new UncertaintyClassProperties();
        IPropertyList IClass.Properties => Properties;
		public class UncertaintyClassProperties : IPropertyList
		{
			/// <inheritdoc />
			public IProperty[] Properties => new IProperty[] {
			};
		};

	}
}