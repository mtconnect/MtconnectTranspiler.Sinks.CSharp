#pragma warning disable CS0109 // Member does not hide an inherited member; new keyword is not required
#pragma warning disable CS1574 // XML comment has cref attribute that could not be resolved
#pragma warning disable CS1584 // XML comment has syntactically incorrect cref attribute
#pragma warning disable CS0618 // Type or member is obsolete
using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;
using System.Linq;

namespace Mtconnect.Glossary
{
	/// <summary>﻿<i>uncertainty</i> of the result of a measurement expressed as a standard deviation. <seealso href="https://www.google.com/search?q=JCGM 100:2008 2.3.1&amp;btnI=I">JCGM 100:2008 2.3.1</seealso><br /><br /><br />
	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Structure___19_0_3_68e0225_1678196842084_529316_17608">model.mtconnect.org</seealso> for more information.
	/// </summary>
	/// <remarks>
	/// <list type="bullet">
	/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_2.2">v2.2</see></item>
	/// </list>
	/// </remarks>

	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public sealed class StandardUncertaintyGeneralization : IClass
	{
		/// <summary>Constant value for <see cref="StandardUncertaintyGeneralization.ReferenceId" /></summary>
		public const string REFERENCE_ID = "_19_0_3_68e0225_1678196842084_529316_17608";
		/// <summary>Constant value for <see cref="StandardUncertaintyGeneralization.HelpUrl" /></summary>
		public const string HELP_URL = "https://model.mtconnect.org/#Structure___19_0_3_68e0225_1678196842084_529316_17608";
		/// <summary>Constant value for <see cref="StandardUncertaintyGeneralization.Summary" /></summary>
		public const string SUMMARY = @"&#10;&#10;&#10;{{term(uncertainty)}} of the result of a measurement expressed as a standard deviation. {{cite(JCGM 100:2008 2.3.1)}}&#10;
";
		/// <summary>Constant value for <see cref="StandardUncertaintyGeneralization.Name" /></summary>
		public const string NAME = "standard uncertainty";
		/// <summary>Constant value for <see cref="StandardUncertaintyGeneralization.AccessModifier" /></summary>
		public const string ACCESS_MODIFIER = "public";
		/// <summary>Constant value for <see cref="StandardUncertaintyGeneralization.Modifier" /></summary>
		public const string MODIFIER = "";
		/// <summary>Constant value for <see cref="StandardUncertaintyGeneralization.NormativeVersion" /></summary>
		public const string NORMATIVE_VERSION = "2.2";
		/// <summary>Constant value for <see cref="StandardUncertaintyGeneralization.DeprecatedVersion" /></summary>
		public const string DEPRECATED_VERSION = "";

		/// <inheritdoc />
		public string ReferenceId => REFERENCE_ID;
		
		/// <inheritdoc />
		public string HelpUrl => HELP_URL;

		/// <inheritdoc />
		public string Summary => SUMMARY;

		/// <inheritdoc />
		public string Name => NAME;
		
		/// <inheritdoc />
		public string AccessModifier => ACCESS_MODIFIER;
				
		/// <inheritdoc />
		public string Modifier => MODIFIER;
				
		/// <inheritdoc />
		public string NormativeVersion => NORMATIVE_VERSION;
				
		/// <inheritdoc />
		public string DeprecatedVersion => DEPRECATED_VERSION;
		
		/// <inheritdoc />
		/// <remarks>
		/// Original Type: _19_0_3_68e0225_1678196835831_469201_17550
		/// </remarks>
		public Type Generalization => typeof(Mtconnect.Glossary.UncertaintyClass);

		/// <inheritdoc />
		public new StandardUncertaintyGeneralizationProperties Properties { get; } = new StandardUncertaintyGeneralizationProperties();
        IPropertyList IClass.Properties => Properties;
		/// <summary>
		/// Property list for <see cref="StandardUncertaintyGeneralization" />.
		/// <br/><b>Note</b>, some properties (<see cref="IProperty" />) are inherited from <see cref="Mtconnect.Glossary.UncertaintyClass.UncertaintyClassProperties" />.
		/// </summary>
		public class StandardUncertaintyGeneralizationProperties : Mtconnect.Glossary.UncertaintyClass.UncertaintyClassProperties
		{
			/// <inheritdoc />
			public override IProperty[] Properties => new IProperty[] {
			}.Concat(base.Properties).ToArray();
		};

	}
}