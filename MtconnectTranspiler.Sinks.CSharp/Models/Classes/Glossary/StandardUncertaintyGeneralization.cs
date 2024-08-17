#pragma warning disable CS0109 // Member does not hide an inherited member; new keyword is not required
#pragma warning disable CS1574 // XML comment has cref attribute that could not be resolved
#pragma warning disable CS1584 // XML comment has syntactically incorrect cref attribute
using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;
using System.Linq;

namespace Mtconnect.Glossary
{
	/// <summary>﻿<i>uncertainty</i> of the result of a measurement expressed as a standard deviation. <seealso href="https://www.google.com/search?q=JCGM 100:2008 2.3.1&btnI=I">JCGM 100:2008 2.3.1</seealso><br /><br /><br />
	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Structure___19_0_3_68e0225_1678196842084_529316_17608">model.mtconnect.org</seealso> for more information.
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public sealed class StandardUncertaintyGeneralization : IClass
	{
		/// <inheritdoc />
		public string ReferenceId => "_19_0_3_68e0225_1678196842084_529316_17608";
		
		/// <inheritdoc />
		public string Summary => @"&#10;&#10;&#10;{{term(uncertainty)}} of the result of a measurement expressed as a standard deviation. {{cite(JCGM 100:2008 2.3.1)}}&#10;
";

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
		/// <summary>
		/// Property list for <see cref="StandardUncertaintyGeneralization" />.
		/// <br/><b>Note</b>, some properties (<see cref="IProperty" />) are inherited from <see cref="Mtconnect.Glossary.UncertaintyClass.UncertaintyClassProperties" />.
		/// </summary>
		public class StandardUncertaintyGeneralizationProperties : Mtconnect.Glossary.UncertaintyClass.UncertaintyClassProperties
		{
			/// <inheritdoc />
			public new IProperty[] Properties => new IProperty[] {
			}.Concat(base.Properties).ToArray();
		};

	}
}