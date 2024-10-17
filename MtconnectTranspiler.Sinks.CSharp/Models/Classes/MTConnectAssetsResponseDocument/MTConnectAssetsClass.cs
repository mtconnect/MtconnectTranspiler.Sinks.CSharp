#pragma warning disable CS0109 // Member does not hide an inherited member; new keyword is not required
#pragma warning disable CS1574 // XML comment has cref attribute that could not be resolved
#pragma warning disable CS1584 // XML comment has syntactically incorrect cref attribute
#pragma warning disable CS0618 // Type or member is obsolete
using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;

namespace Mtconnect.Fundamentals.MTConnectProtocol.MTConnectAssetsResponseDocument
{
	/// <summary>﻿root entity of an <i>MTConnectAssets Response Document</i> that contains the <i>Asset Information Model</i> of <see cref="Asset">Asset</see> types.<br /><br />![MTConnectAssets](figures/MTConnectAssets.png "MTConnectAssets"){: width="0.8"}<br /><br />&gt; Note: Additional properties of <see cref="MTConnectAssets">MTConnectAssets</see> <b>MAY</b> be defined for schema and namespace declaration. See <see cref="Schema and Namespace Declaration Information">Schema and Namespace Declaration Information</see> for an <i>XML</i> example.<br /><br /><br />
	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Structure__EAID_AD98C122_E276_4506_AD69_B82107CB3802">model.mtconnect.org</seealso> for more information.
	/// </summary>
	/// <remarks>
	/// <list type="bullet">
	/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.2">v1.2</see></item>
	/// </list>
	/// </remarks>

	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public sealed class MTConnectAssetsClass : IClass
	{
		/// <summary>Constant value for <see cref="MTConnectAssetsClass.ReferenceId" /></summary>
		public const string REFERENCE_ID = "EAID_AD98C122_E276_4506_AD69_B82107CB3802";
		/// <summary>Constant value for <see cref="MTConnectAssetsClass.HelpUrl" /></summary>
		public const string HELP_URL = "https://model.mtconnect.org/#Structure__EAID_AD98C122_E276_4506_AD69_B82107CB3802";
		/// <summary>Constant value for <see cref="MTConnectAssetsClass.Summary" /></summary>
		public const string SUMMARY = @"&#10;&#10;&#10;root entity of an {{term(MTConnectAssets Response Document)}} that contains the {{term(Asset Information Model)}} of {{block(Asset)}} types.

![MTConnectAssets](figures/MTConnectAssets.png ""MTConnectAssets""){: width=""0.8""}

> Note: Additional properties of {{block(MTConnectAssets)}} **MAY** be defined for schema and namespace declaration. See {{sect(Schema and Namespace Declaration Information)}} for an {{term(XML)}} example.&#10;
";
		/// <summary>Constant value for <see cref="MTConnectAssetsClass.Name" /></summary>
		public const string NAME = "MTConnectAssets";
		/// <summary>Constant value for <see cref="MTConnectAssetsClass.AccessModifier" /></summary>
		public const string ACCESS_MODIFIER = "public";
		/// <summary>Constant value for <see cref="MTConnectAssetsClass.Modifier" /></summary>
		public const string MODIFIER = "";
		/// <summary>Constant value for <see cref="MTConnectAssetsClass.NormativeVersion" /></summary>
		public const string NORMATIVE_VERSION = "1.2";
		/// <summary>Constant value for <see cref="MTConnectAssetsClass.DeprecatedVersion" /></summary>
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
		public new MTConnectAssetsClassProperties Properties { get; } = new MTConnectAssetsClassProperties();
        IPropertyList IClass.Properties => Properties;
		/// <summary>
		/// Property list for <see cref="MTConnectAssetsClass" />.
		/// </summary>
		public class MTConnectAssetsClassProperties : IPropertyList
		{
			/// <inheritdoc />
			public virtual IProperty[] Properties => new IProperty[] {
				HasHeaderPart,
				HasAssetPart,
			};
			/// <summary>
			/// <inheritdoc cref="HasHeaderPartProperty" path="/summary" /><br/>
			/// <remarks>Original Name: HasHeader</remarks>
			/// </summary>
			public HasHeaderPartProperty HasHeaderPart { get; } = new HasHeaderPartProperty();
			
			/// <summary>﻿
			/// </summary>
			public sealed class HasHeaderPartProperty : IProperty
			{
				/// <summary>Constant value for <see cref="HasHeaderPartProperty.Name" /></summary>
				public const string NAME = "hasHeader";
				/// <summary>Constant value for <see cref="HasHeaderPartProperty.Summary" /></summary>
				public const string SUMMARY = @"";
				/// <summary>Constant value for <see cref="HasHeaderPartProperty.AccessModifier" /></summary>
				public const string ACCESS_MODIFIER = "public";
				/// <summary>Constant value for <see cref="HasHeaderPartProperty.Modifier" /></summary>
				public const string MODIFIER = "";
				/// <summary>Constant value for <see cref="HasHeaderPartProperty.NormativeVersion" /></summary>
				public const string NORMATIVE_VERSION = "";
				/// <summary>Constant value for <see cref="HasHeaderPartProperty.DeprecatedVersion" /></summary>
				public const string DEPRECATED_VERSION = "";
				/// <summary>Constant value for <see cref="HasHeaderPartProperty.Aggregation" /></summary>
				public const string AGGREGATION = "";
				/// <summary>Constant value for <see cref="HasHeaderPartProperty.Extension" /></summary>
				public const string EXTENSION = "MagicDraw UML 2024x";
				/// <summary>Constant value for <see cref="HasHeaderPartProperty.Association" /></summary>
				public const string ASSOCIATION = "Header";
				/// <summary>Constant value for <see cref="HasHeaderPartProperty.DefaultValue" /></summary>
				public const string DEFAULT_VALUE = "";

				/// <summary>
				/// <inheritdoc />
				/// <remarks> Type: HeaderClass </remarks>
				/// </summary>
				public System.Type Type => typeof(Mtconnect.Fundamentals.MTConnectProtocol.MTConnectAssetsResponseDocument.HeaderClass);
				
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
			/// <inheritdoc cref="HasAssetPartProperty" path="/summary" /><br/>
			/// <remarks>Original Name: HasAsset</remarks>
			/// </summary>
			public HasAssetPartProperty HasAssetPart { get; } = new HasAssetPartProperty();
			
			/// <summary>﻿
			/// </summary>
			public sealed class HasAssetPartProperty : IProperty
			{
				/// <summary>Constant value for <see cref="HasAssetPartProperty.Name" /></summary>
				public const string NAME = "hasAsset";
				/// <summary>Constant value for <see cref="HasAssetPartProperty.Summary" /></summary>
				public const string SUMMARY = @"";
				/// <summary>Constant value for <see cref="HasAssetPartProperty.AccessModifier" /></summary>
				public const string ACCESS_MODIFIER = "public";
				/// <summary>Constant value for <see cref="HasAssetPartProperty.Modifier" /></summary>
				public const string MODIFIER = "";
				/// <summary>Constant value for <see cref="HasAssetPartProperty.NormativeVersion" /></summary>
				public const string NORMATIVE_VERSION = "";
				/// <summary>Constant value for <see cref="HasAssetPartProperty.DeprecatedVersion" /></summary>
				public const string DEPRECATED_VERSION = "";
				/// <summary>Constant value for <see cref="HasAssetPartProperty.Aggregation" /></summary>
				public const string AGGREGATION = "composite";
				/// <summary>Constant value for <see cref="HasAssetPartProperty.Extension" /></summary>
				public const string EXTENSION = "";
				/// <summary>Constant value for <see cref="HasAssetPartProperty.Association" /></summary>
				public const string ASSOCIATION = "Assets";
				/// <summary>Constant value for <see cref="HasAssetPartProperty.DefaultValue" /></summary>
				public const string DEFAULT_VALUE = "";

				/// <summary>
				/// <inheritdoc />
				/// <remarks> Type: AssetClass </remarks>
				/// </summary>
				public System.Type Type => typeof(Mtconnect.AssetInformationModel.AssetClass);
				
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