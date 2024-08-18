#pragma warning disable CS0109 // Member does not hide an inherited member; new keyword is not required
#pragma warning disable CS1574 // XML comment has cref attribute that could not be resolved
#pragma warning disable CS1584 // XML comment has syntactically incorrect cref attribute
using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;
using System.Linq;

namespace Mtconnect.Glossary
{
	/// <summary>﻿<i>standard uncertainty</i> of the result of a measurement when that result is obtained from the values of a number of other quantities, equal to the positive square root of a sum of terms, the terms being the variances or covariances of these other quantities weighted according to how the measurement result varies with changes in these quantities. <seealso href="https://www.google.com/search?q=JCGM 100:2008 2.3.4&btnI=I">JCGM 100:2008 2.3.4</seealso><br /><br /><br />
	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Structure___19_0_3_68e0225_1678196848613_590918_17633">model.mtconnect.org</seealso> for more information.
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public sealed class CombinedStandardUncertaintyClass : IClass
	{
		/// <inheritdoc />
		public string ReferenceId => "_19_0_3_68e0225_1678196848613_590918_17633";
		
		/// <inheritdoc />
		public string Summary => @"&#10;&#10;&#10;{{term(standard uncertainty)}} of the result of a measurement when that result is obtained from the values of a number of other quantities, equal to the positive square root of a sum of terms, the terms being the variances or covariances of these other quantities weighted according to how the measurement result varies with changes in these quantities. {{cite(JCGM 100:2008 2.3.4)}}&#10;
";

		/// <inheritdoc />
		public string Name => "combined standard uncertainty";
		
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
		/// Original Type: _19_0_3_68e0225_1678196842084_529316_17608
		/// </remarks>
		public Type Generalization => typeof(Mtconnect.Glossary.StandardUncertaintyGeneralization);

		/// <inheritdoc />
		public new CombinedStandardUncertaintyClassProperties Properties { get; } = new CombinedStandardUncertaintyClassProperties();
        IPropertyList IClass.Properties => Properties;
		/// <summary>
		/// Property list for <see cref="CombinedStandardUncertaintyClass" />.
		/// <br/><b>Note</b>, some properties (<see cref="IProperty" />) are inherited from <see cref="Mtconnect.Glossary.StandardUncertaintyGeneralization.StandardUncertaintyGeneralizationProperties" />.
		/// </summary>
		public class CombinedStandardUncertaintyClassProperties : Mtconnect.Glossary.StandardUncertaintyGeneralization.StandardUncertaintyGeneralizationProperties
		{
			/// <inheritdoc />
			public new IProperty[] Properties => new IProperty[] {
			}.Concat(base.Properties).ToArray();
		};

	}
}