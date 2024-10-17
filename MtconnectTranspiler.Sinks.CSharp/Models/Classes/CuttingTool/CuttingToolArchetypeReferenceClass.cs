#pragma warning disable CS0109 // Member does not hide an inherited member; new keyword is not required
#pragma warning disable CS1574 // XML comment has cref attribute that could not be resolved
#pragma warning disable CS1584 // XML comment has syntactically incorrect cref attribute
#pragma warning disable CS0618 // Type or member is obsolete
using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;

namespace Mtconnect.AssetInformationModel.CuttingTool
{
	/// <summary>﻿reference information about the <see cref="Asset.assetId">assetId in Asset</see> and/or the URL of the data source of <see cref="CuttingToolArchetype">CuttingToolArchetype</see>.<br /><br /><br />
	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Structure__EAID_D4CAAB4A_DE00_489d_ACCA_F00FC7296F0C">model.mtconnect.org</seealso> for more information.
	/// </summary>
	/// <remarks>
	/// <list type="bullet">
	/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.3">v1.3</see></item>
	/// </list>
	/// </remarks>

	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public sealed class CuttingToolArchetypeReferenceClass : IClass
	{
		/// <summary>Constant value for <see cref="CuttingToolArchetypeReferenceClass.ReferenceId" /></summary>
		public const string REFERENCE_ID = "EAID_D4CAAB4A_DE00_489d_ACCA_F00FC7296F0C";
		/// <summary>Constant value for <see cref="CuttingToolArchetypeReferenceClass.HelpUrl" /></summary>
		public const string HELP_URL = "https://model.mtconnect.org/#Structure__EAID_D4CAAB4A_DE00_489d_ACCA_F00FC7296F0C";
		/// <summary>Constant value for <see cref="CuttingToolArchetypeReferenceClass.Summary" /></summary>
		public const string SUMMARY = @"&#10;&#10;&#10;reference information about the {{property(Asset::assetId)}} and/or the URL of the data source of {{block(CuttingToolArchetype)}}.&#10;
";
		/// <summary>Constant value for <see cref="CuttingToolArchetypeReferenceClass.Name" /></summary>
		public const string NAME = "CuttingToolArchetypeReference";
		/// <summary>Constant value for <see cref="CuttingToolArchetypeReferenceClass.AccessModifier" /></summary>
		public const string ACCESS_MODIFIER = "public";
		/// <summary>Constant value for <see cref="CuttingToolArchetypeReferenceClass.Modifier" /></summary>
		public const string MODIFIER = "";
		/// <summary>Constant value for <see cref="CuttingToolArchetypeReferenceClass.NormativeVersion" /></summary>
		public const string NORMATIVE_VERSION = "1.3";
		/// <summary>Constant value for <see cref="CuttingToolArchetypeReferenceClass.DeprecatedVersion" /></summary>
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
		public Type Generalization => null;

		/// <inheritdoc />
		public new CuttingToolArchetypeReferenceClassProperties Properties { get; } = new CuttingToolArchetypeReferenceClassProperties();
        IPropertyList IClass.Properties => Properties;
		/// <summary>
		/// Property list for <see cref="CuttingToolArchetypeReferenceClass" />.
		/// </summary>
		public class CuttingToolArchetypeReferenceClassProperties : IPropertyList
		{
			/// <inheritdoc />
			public virtual IProperty[] Properties => new IProperty[] {
				Source,
				Value,
			};
			/// <summary>
			/// <inheritdoc cref="SourceProperty" path="/summary" /><br/>
			/// <remarks>Original Name: Source</remarks>
			/// </summary>
			public SourceProperty Source { get; } = new SourceProperty();
			
			/// <summary>﻿<i>URL</i> of the <see cref="CuttingToolArchetype">CuttingToolArchetype</see> <i>information model</i>.<br /><br /><br /><br />
			/// </summary>
			public sealed class SourceProperty : IProperty
			{
				/// <summary>Constant value for <see cref="SourceProperty.Name" /></summary>
				public const string NAME = "source";
				/// <summary>Constant value for <see cref="SourceProperty.Summary" /></summary>
				public const string SUMMARY = @"&#10;&#10;&#10;{{term(URL)}} of the {{block(CuttingToolArchetype)}} {{term(information model)}}.&#10;
";
				/// <summary>Constant value for <see cref="SourceProperty.AccessModifier" /></summary>
				public const string ACCESS_MODIFIER = "public";
				/// <summary>Constant value for <see cref="SourceProperty.Modifier" /></summary>
				public const string MODIFIER = "";
				/// <summary>Constant value for <see cref="SourceProperty.NormativeVersion" /></summary>
				public const string NORMATIVE_VERSION = "1.3";
				/// <summary>Constant value for <see cref="SourceProperty.DeprecatedVersion" /></summary>
				public const string DEPRECATED_VERSION = "";
				/// <summary>Constant value for <see cref="SourceProperty.Aggregation" /></summary>
				public const string AGGREGATION = "";
				/// <summary>Constant value for <see cref="SourceProperty.Extension" /></summary>
				public const string EXTENSION = "MagicDraw UML 2024x";
				/// <summary>Constant value for <see cref="SourceProperty.Association" /></summary>
				public const string ASSOCIATION = "";
				/// <summary>Constant value for <see cref="SourceProperty.DefaultValue" /></summary>
				public const string DEFAULT_VALUE = "";

				/// <summary>
				/// <inheritdoc />
				/// <remarks> Type: String </remarks>
				/// </summary>
				public System.Type Type => typeof(String);
				
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
			/// <summary>
			/// <inheritdoc cref="ValueProperty" path="/summary" /><br/>
			/// <remarks>Original Name: Value</remarks>
			/// </summary>
			public ValueProperty Value { get; } = new ValueProperty();
			
			/// <summary>﻿<c>assetId</c> of the related <see cref="CuttingToolArchetype">CuttingToolArchetype</see>.<br /><br /><br />
			/// </summary>
			public sealed class ValueProperty : IProperty
			{
				/// <summary>Constant value for <see cref="ValueProperty.Name" /></summary>
				public const string NAME = "value";
				/// <summary>Constant value for <see cref="ValueProperty.Summary" /></summary>
				public const string SUMMARY = @"&#10;&#10;&#10;`assetId` of the related {{block(CuttingToolArchetype)}}.&#10;
";
				/// <summary>Constant value for <see cref="ValueProperty.AccessModifier" /></summary>
				public const string ACCESS_MODIFIER = "public";
				/// <summary>Constant value for <see cref="ValueProperty.Modifier" /></summary>
				public const string MODIFIER = "";
				/// <summary>Constant value for <see cref="ValueProperty.NormativeVersion" /></summary>
				public const string NORMATIVE_VERSION = "1.3";
				/// <summary>Constant value for <see cref="ValueProperty.DeprecatedVersion" /></summary>
				public const string DEPRECATED_VERSION = "";
				/// <summary>Constant value for <see cref="ValueProperty.Aggregation" /></summary>
				public const string AGGREGATION = "composite";
				/// <summary>Constant value for <see cref="ValueProperty.Extension" /></summary>
				public const string EXTENSION = "MagicDraw UML 2024x";
				/// <summary>Constant value for <see cref="ValueProperty.Association" /></summary>
				public const string ASSOCIATION = "";
				/// <summary>Constant value for <see cref="ValueProperty.DefaultValue" /></summary>
				public const string DEFAULT_VALUE = "";

				/// <summary>
				/// <inheritdoc />
				/// <remarks> Type: String </remarks>
				/// </summary>
				public System.Type Type => typeof(String);
				
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