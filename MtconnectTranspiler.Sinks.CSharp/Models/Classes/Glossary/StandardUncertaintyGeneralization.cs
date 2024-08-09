using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;
using System.Linq;

namespace Mtconnect.Glossary
{
	/// <summary>
	/// <i>uncertainty</i> of the result of a measurement expressed as a standard deviation. <seealso href="https://www.google.com/search?q=JCGM 100:2008 2.3.1&btnI=I">JCGM 100:2008 2.3.1</seealso>
	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Structure___19_0_3_68e0225_1678196842084_529316_17608">model.mtconnect.org</seealso> for more information.
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.3.0.0")]
	public sealed class StandardUncertaintyGeneralization : IClass
	{
		/// <inheritdoc />
		public string ReferenceId => "_19_0_3_68e0225_1678196842084_529316_17608";
		
		/// <inheritdoc />
		public string Summary => @"/// <i>uncertainty</i> of the result of a measurement expressed as a standard deviation. <seealso href=""https://www.google.com/search?q=JCGM 100:2008 2.3.1&btnI=I"">JCGM 100:2008 2.3.1</seealso>";

		/// <inheritdoc />
		public string Name => "standard uncertainty";
		
		/// <inheritdoc />
		public string AccessModifier => "public";
				
		/// <inheritdoc />
		public string Modifier => "";
				
		/// <inheritdoc />
		public string NormativeVersion => "2.2";
				
		/// <inheritdoc />
		public string DeprecatedVersion => "";
		
		/// <inheritdoc />
		/// <remarks>
		/// Original Type: _19_0_3_68e0225_1678196835831_469201_17550
		/// </remarks>
		public Type Generalization => typeof(Mtconnect.Glossary.UncertaintyClass);

		/// <inheritdoc />
		public StandardUncertaintyGeneralizationProperties Properties { get; } = new StandardUncertaintyGeneralizationProperties();
        IPropertyList IClass.Properties => Properties;
		public class StandardUncertaintyGeneralizationProperties : Mtconnect.Glossary.UncertaintyClass.UncertaintyClassProperties
		{
			/// <inheritdoc />
			public IProperty[] Properties => new IProperty[] {
			}.Concat(base.Properties).ToArray();
		};

	}
}