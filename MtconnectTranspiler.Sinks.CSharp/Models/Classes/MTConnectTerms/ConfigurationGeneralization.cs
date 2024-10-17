#pragma warning disable CS0109 // Member does not hide an inherited member; new keyword is not required
#pragma warning disable CS1574 // XML comment has cref attribute that could not be resolved
#pragma warning disable CS1584 // XML comment has syntactically incorrect cref attribute
#pragma warning disable CS0618 // Type or member is obsolete
using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;
using System.Linq;

namespace Mtconnect.Glossary.MTConnectTerms
{
	/// <summary>﻿<i>configuration</i> for a <i>Component</i><br /><br /><br />
	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Structure___19_0_3_68e0225_1635251403887_914466_345">model.mtconnect.org</seealso> for more information.
	/// </summary>
	
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public sealed class ConfigurationGeneralization : IClass
	{
		/// <summary>Constant value for <see cref="ConfigurationGeneralization.ReferenceId" /></summary>
		public const string REFERENCE_ID = "_19_0_3_68e0225_1635251403887_914466_345";
		/// <summary>Constant value for <see cref="ConfigurationGeneralization.HelpUrl" /></summary>
		public const string HELP_URL = "https://model.mtconnect.org/#Structure___19_0_3_68e0225_1635251403887_914466_345";
		/// <summary>Constant value for <see cref="ConfigurationGeneralization.Summary" /></summary>
		public const string SUMMARY = @"&#10;&#10;&#10;{{term(configuration)}} for a {{term(Component)}}&#10;
";
		/// <summary>Constant value for <see cref="ConfigurationGeneralization.Name" /></summary>
		public const string NAME = "Configuration";
		/// <summary>Constant value for <see cref="ConfigurationGeneralization.AccessModifier" /></summary>
		public const string ACCESS_MODIFIER = "public";
		/// <summary>Constant value for <see cref="ConfigurationGeneralization.Modifier" /></summary>
		public const string MODIFIER = "";
		/// <summary>Constant value for <see cref="ConfigurationGeneralization.NormativeVersion" /></summary>
		public const string NORMATIVE_VERSION = "";
		/// <summary>Constant value for <see cref="ConfigurationGeneralization.DeprecatedVersion" /></summary>
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
		/// Original Type: _19_0_3_45f01b9_1581970391175_482710_6078
		/// </remarks>
		public Type Generalization => typeof(Mtconnect.Glossary.IndustrialTerms.ConfigurationClass);

		/// <inheritdoc />
		public new ConfigurationGeneralizationProperties Properties { get; } = new ConfigurationGeneralizationProperties();
        IPropertyList IClass.Properties => Properties;
		/// <summary>
		/// Property list for <see cref="ConfigurationGeneralization" />.
		/// <br/><b>Note</b>, some properties (<see cref="IProperty" />) are inherited from <see cref="Mtconnect.Glossary.IndustrialTerms.ConfigurationClass.ConfigurationClassProperties" />.
		/// </summary>
		public class ConfigurationGeneralizationProperties : Mtconnect.Glossary.IndustrialTerms.ConfigurationClass.ConfigurationClassProperties
		{
			/// <inheritdoc />
			public override IProperty[] Properties => new IProperty[] {
				ConfigurationFor,
			}.Concat(base.Properties).ToArray();
			/// <summary>
			/// <inheritdoc cref="ConfigurationForProperty" path="/summary" /><br/>
			/// <remarks>Original Name: ConfigurationFor</remarks>
			/// </summary>
			public new ConfigurationForProperty ConfigurationFor { get; } = new ConfigurationForProperty();
			
			/// <summary>﻿
			/// </summary>
			public new sealed class ConfigurationForProperty : IProperty
			{
				/// <summary>Constant value for <see cref="ConfigurationForProperty.Name" /></summary>
				public const string NAME = "configuration for";
				/// <summary>Constant value for <see cref="ConfigurationForProperty.Summary" /></summary>
				public const string SUMMARY = @"";
				/// <summary>Constant value for <see cref="ConfigurationForProperty.AccessModifier" /></summary>
				public const string ACCESS_MODIFIER = "private";
				/// <summary>Constant value for <see cref="ConfigurationForProperty.Modifier" /></summary>
				public const string MODIFIER = "";
				/// <summary>Constant value for <see cref="ConfigurationForProperty.NormativeVersion" /></summary>
				public const string NORMATIVE_VERSION = "";
				/// <summary>Constant value for <see cref="ConfigurationForProperty.DeprecatedVersion" /></summary>
				public const string DEPRECATED_VERSION = "";
				/// <summary>Constant value for <see cref="ConfigurationForProperty.Aggregation" /></summary>
				public const string AGGREGATION = "";
				/// <summary>Constant value for <see cref="ConfigurationForProperty.Extension" /></summary>
				public const string EXTENSION = "MagicDraw UML 2024x";
				/// <summary>Constant value for <see cref="ConfigurationForProperty.Association" /></summary>
				public const string ASSOCIATION = "";
				/// <summary>Constant value for <see cref="ConfigurationForProperty.DefaultValue" /></summary>
				public const string DEFAULT_VALUE = "";

				/// <summary>
				/// <inheritdoc />
				/// <remarks> Type: ComponentClass </remarks>
				/// </summary>
				public System.Type Type => typeof(Mtconnect.Glossary.MTConnectTerms.ComponentClass);
				
				/// <inheritdoc />
				public string Name => NAME;
				
				/// <inheritdoc />
				public string Summary => SUMMARY;

				/// <inheritdoc />
				public string AccessModifier => ACCESS_MODIFIER;
				
				/// <inheritdoc />
				public string Modifier => MODIFIER;
				
				/// <inheritdoc />
				public string NormativeVersion => NORMATIVE_VERSION;
				
				/// <inheritdoc />
				public string DeprecatedVersion => DEPRECATED_VERSION;
				
				/// <inheritdoc />
				public string Aggregation => AGGREGATION;

				// Note: Extension.Extender
				/// <inheritdoc />
				public string Extension => EXTENSION;
				
				/// <inheritdoc />
				public string Association => ASSOCIATION;

				// Note: DefaultValue.Name
				/// <inheritdoc />
				public string DefaultValue => DEFAULT_VALUE;
			}
		};

	}
}