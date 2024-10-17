#pragma warning disable CS0109 // Member does not hide an inherited member; new keyword is not required
#pragma warning disable CS1574 // XML comment has cref attribute that could not be resolved
#pragma warning disable CS1584 // XML comment has syntactically incorrect cref attribute
#pragma warning disable CS0618 // Type or member is obsolete
using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;
using System.Linq;

namespace Mtconnect.AssetInformationModel
{
	/// <summary>﻿abstract <i>Asset</i>. <br /><br /><br />Description<br /><br />It is used in the manufacturing process, but is not permanently associated with a single piece of equipment. It can be removed from the piece of equipment without compromising its function, and can be associated with other pieces of equipment during its lifecycle.<br /><br /><br />![Asset](figures/Asset.png "Asset"){: width="0.8"}<br /><br />&gt; Note: See <see cref="Assets Schema Diagrams">Assets Schema Diagrams</see> for XML schema.<br /><br /><br /><br /><br />
	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Structure__EAID_C7D39183_23CB_416b_A62D_F60815E08B1A">model.mtconnect.org</seealso> for more information.
	/// </summary>
	/// <remarks>
	/// <list type="bullet">
	/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.2">v1.2</see></item>
	/// </list>
	/// </remarks>

	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public sealed class AssetClass : IClass
	{
		/// <summary>Constant value for <see cref="AssetClass.ReferenceId" /></summary>
		public const string REFERENCE_ID = "EAID_C7D39183_23CB_416b_A62D_F60815E08B1A";
		/// <summary>Constant value for <see cref="AssetClass.HelpUrl" /></summary>
		public const string HELP_URL = "https://model.mtconnect.org/#Structure__EAID_C7D39183_23CB_416b_A62D_F60815E08B1A";
		/// <summary>Constant value for <see cref="AssetClass.Summary" /></summary>
		public const string SUMMARY = @"&#10;&#10;&#10;abstract {{term(Asset)}}. &#10;
&#10;&#10;&#10;Description&#10;&#10;&#10;&#10;It is used in the manufacturing process, but is not permanently associated with a single piece of equipment. It can be removed from the piece of equipment without compromising its function, and can be associated with other pieces of equipment during its lifecycle.


![Asset](figures/Asset.png ""Asset""){: width=""0.8""}

> Note: See {{sect(Assets Schema Diagrams)}} for XML schema.&#10;
";
		/// <summary>Constant value for <see cref="AssetClass.Name" /></summary>
		public const string NAME = "Asset";
		/// <summary>Constant value for <see cref="AssetClass.AccessModifier" /></summary>
		public const string ACCESS_MODIFIER = "public";
		/// <summary>Constant value for <see cref="AssetClass.Modifier" /></summary>
		public const string MODIFIER = "abstract";
		/// <summary>Constant value for <see cref="AssetClass.NormativeVersion" /></summary>
		public const string NORMATIVE_VERSION = "1.2";
		/// <summary>Constant value for <see cref="AssetClass.DeprecatedVersion" /></summary>
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
		/// Original Type: _19_0_3_45f01b9_1581734255313_425984_984
		/// </remarks>
		public Type Generalization => typeof(Mtconnect.Glossary.MTConnectTerms.AssetGeneralization);

		/// <inheritdoc />
		public new AssetClassProperties Properties { get; } = new AssetClassProperties();
        IPropertyList IClass.Properties => Properties;
		/// <summary>
		/// Property list for <see cref="AssetClass" />.
		/// <br/><b>Note</b>, some properties (<see cref="IProperty" />) are inherited from <see cref="Mtconnect.Glossary.MTConnectTerms.AssetGeneralization.AssetGeneralizationProperties" />.
		/// </summary>
		public class AssetClassProperties : Mtconnect.Glossary.MTConnectTerms.AssetGeneralization.AssetGeneralizationProperties
		{
			/// <inheritdoc />
			public override IProperty[] Properties => new IProperty[] {
				AssetId,
				DeviceUuid,
				Removed,
				Timestamp,
				HasConfigurationPart,
				Hash,
				Description,
				Manufacturers,
				Model,
				SerialNumber,
				Station,
			}.Concat(base.Properties).ToArray();
			/// <summary>
			/// <inheritdoc cref="AssetIdProperty" path="/summary" /><br/>
			/// <remarks>Original Name: AssetId</remarks>
			/// </summary>
			public new AssetIdProperty AssetId { get; } = new AssetIdProperty();
			
			/// <summary>﻿unique identifier for an <see cref="Asset">Asset</see>.<br /><br /><br />
			/// </summary>
			public new sealed class AssetIdProperty : IProperty
			{
				/// <summary>Constant value for <see cref="AssetIdProperty.Name" /></summary>
				public const string NAME = "assetId";
				/// <summary>Constant value for <see cref="AssetIdProperty.Summary" /></summary>
				public const string SUMMARY = @"&#10;&#10;&#10;unique identifier for an {{block(Asset)}}.&#10;
";
				/// <summary>Constant value for <see cref="AssetIdProperty.AccessModifier" /></summary>
				public const string ACCESS_MODIFIER = "public";
				/// <summary>Constant value for <see cref="AssetIdProperty.Modifier" /></summary>
				public const string MODIFIER = "";
				/// <summary>Constant value for <see cref="AssetIdProperty.NormativeVersion" /></summary>
				public const string NORMATIVE_VERSION = "1.2";
				/// <summary>Constant value for <see cref="AssetIdProperty.DeprecatedVersion" /></summary>
				public const string DEPRECATED_VERSION = "";
				/// <summary>Constant value for <see cref="AssetIdProperty.Aggregation" /></summary>
				public const string AGGREGATION = "";
				/// <summary>Constant value for <see cref="AssetIdProperty.Extension" /></summary>
				public const string EXTENSION = "MagicDraw UML 2024x";
				/// <summary>Constant value for <see cref="AssetIdProperty.Association" /></summary>
				public const string ASSOCIATION = "";
				/// <summary>Constant value for <see cref="AssetIdProperty.DefaultValue" /></summary>
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
			/// <inheritdoc cref="DeviceUuidProperty" path="/summary" /><br/>
			/// <remarks>Original Name: DeviceUuid</remarks>
			/// </summary>
			public new DeviceUuidProperty DeviceUuid { get; } = new DeviceUuidProperty();
			
			/// <summary>﻿associated piece of equipment's <i>UUID</i> that supplied the <see cref="Asset">Asset</see>'s data.<br /><br />It references to <see cref="Device.uuid">uuid in Device</see> defined in <see cref="Device Information Model">Device Information Model</see>.<br /><br /><br />
			/// </summary>
			public new sealed class DeviceUuidProperty : IProperty
			{
				/// <summary>Constant value for <see cref="DeviceUuidProperty.Name" /></summary>
				public const string NAME = "deviceUuid";
				/// <summary>Constant value for <see cref="DeviceUuidProperty.Summary" /></summary>
				public const string SUMMARY = @"&#10;&#10;&#10;associated piece of equipment's {{term(UUID)}} that supplied the {{block(Asset)}}'s data.

It references to {{property(Device::uuid)}} defined in {{package(Device Information Model)}}.&#10;
";
				/// <summary>Constant value for <see cref="DeviceUuidProperty.AccessModifier" /></summary>
				public const string ACCESS_MODIFIER = "public";
				/// <summary>Constant value for <see cref="DeviceUuidProperty.Modifier" /></summary>
				public const string MODIFIER = "";
				/// <summary>Constant value for <see cref="DeviceUuidProperty.NormativeVersion" /></summary>
				public const string NORMATIVE_VERSION = "1.2";
				/// <summary>Constant value for <see cref="DeviceUuidProperty.DeprecatedVersion" /></summary>
				public const string DEPRECATED_VERSION = "";
				/// <summary>Constant value for <see cref="DeviceUuidProperty.Aggregation" /></summary>
				public const string AGGREGATION = "";
				/// <summary>Constant value for <see cref="DeviceUuidProperty.Extension" /></summary>
				public const string EXTENSION = "MagicDraw UML 2024x";
				/// <summary>Constant value for <see cref="DeviceUuidProperty.Association" /></summary>
				public const string ASSOCIATION = "";
				/// <summary>Constant value for <see cref="DeviceUuidProperty.DefaultValue" /></summary>
				public const string DEFAULT_VALUE = "";

				/// <summary>
				/// <inheritdoc />
				/// <remarks> Type: Object </remarks>
				/// </summary>
				public System.Type Type => typeof(object);
				
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
			/// <inheritdoc cref="RemovedProperty" path="/summary" /><br/>
			/// <remarks>Original Name: Removed</remarks>
			/// </summary>
			public new RemovedProperty Removed { get; } = new RemovedProperty();
			
			/// <summary>﻿indicator that the <see cref="Asset">Asset</see> has been removed from the piece of equipment.<br /><br /><br />
			/// </summary>
			public new sealed class RemovedProperty : IProperty
			{
				/// <summary>Constant value for <see cref="RemovedProperty.Name" /></summary>
				public const string NAME = "removed";
				/// <summary>Constant value for <see cref="RemovedProperty.Summary" /></summary>
				public const string SUMMARY = @"&#10;&#10;&#10;indicator that the {{block(Asset)}} has been removed from the piece of equipment.&#10;
";
				/// <summary>Constant value for <see cref="RemovedProperty.AccessModifier" /></summary>
				public const string ACCESS_MODIFIER = "public";
				/// <summary>Constant value for <see cref="RemovedProperty.Modifier" /></summary>
				public const string MODIFIER = "";
				/// <summary>Constant value for <see cref="RemovedProperty.NormativeVersion" /></summary>
				public const string NORMATIVE_VERSION = "1.3";
				/// <summary>Constant value for <see cref="RemovedProperty.DeprecatedVersion" /></summary>
				public const string DEPRECATED_VERSION = "";
				/// <summary>Constant value for <see cref="RemovedProperty.Aggregation" /></summary>
				public const string AGGREGATION = "";
				/// <summary>Constant value for <see cref="RemovedProperty.Extension" /></summary>
				public const string EXTENSION = "MagicDraw UML 2024x";
				/// <summary>Constant value for <see cref="RemovedProperty.Association" /></summary>
				public const string ASSOCIATION = "";
				/// <summary>Constant value for <see cref="RemovedProperty.DefaultValue" /></summary>
				public const string DEFAULT_VALUE = "";

				/// <summary>
				/// <inheritdoc />
				/// <remarks> Type: Boolean </remarks>
				/// </summary>
				public System.Type Type => typeof(Boolean);
				
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
			/// <inheritdoc cref="TimestampProperty" path="/summary" /><br/>
			/// <remarks>Original Name: Timestamp</remarks>
			/// </summary>
			public new TimestampProperty Timestamp { get; } = new TimestampProperty();
			
			/// <summary>﻿time the <see cref="Asset">Asset</see> data was last modified.<br /><br /><br />
			/// </summary>
			public new sealed class TimestampProperty : IProperty
			{
				/// <summary>Constant value for <see cref="TimestampProperty.Name" /></summary>
				public const string NAME = "timestamp";
				/// <summary>Constant value for <see cref="TimestampProperty.Summary" /></summary>
				public const string SUMMARY = @"&#10;&#10;&#10;time the {{block(Asset)}} data was last modified.&#10;
";
				/// <summary>Constant value for <see cref="TimestampProperty.AccessModifier" /></summary>
				public const string ACCESS_MODIFIER = "public";
				/// <summary>Constant value for <see cref="TimestampProperty.Modifier" /></summary>
				public const string MODIFIER = "";
				/// <summary>Constant value for <see cref="TimestampProperty.NormativeVersion" /></summary>
				public const string NORMATIVE_VERSION = "1.2";
				/// <summary>Constant value for <see cref="TimestampProperty.DeprecatedVersion" /></summary>
				public const string DEPRECATED_VERSION = "";
				/// <summary>Constant value for <see cref="TimestampProperty.Aggregation" /></summary>
				public const string AGGREGATION = "";
				/// <summary>Constant value for <see cref="TimestampProperty.Extension" /></summary>
				public const string EXTENSION = "MagicDraw UML 2024x";
				/// <summary>Constant value for <see cref="TimestampProperty.Association" /></summary>
				public const string ASSOCIATION = "";
				/// <summary>Constant value for <see cref="TimestampProperty.DefaultValue" /></summary>
				public const string DEFAULT_VALUE = "";

				/// <summary>
				/// <inheritdoc />
				/// <remarks> Type: DateTime </remarks>
				/// </summary>
				public System.Type Type => typeof(DateTime);
				
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
			/// <inheritdoc cref="HasConfigurationPartProperty" path="/summary" /><br/>
			/// <remarks>Original Name: HasConfiguration</remarks>
			/// </summary>
			public new HasConfigurationPartProperty HasConfigurationPart { get; } = new HasConfigurationPartProperty();
			
			/// <summary>﻿
			/// </summary>
			public new sealed class HasConfigurationPartProperty : IProperty
			{
				/// <summary>Constant value for <see cref="HasConfigurationPartProperty.Name" /></summary>
				public const string NAME = "hasConfiguration";
				/// <summary>Constant value for <see cref="HasConfigurationPartProperty.Summary" /></summary>
				public const string SUMMARY = @"";
				/// <summary>Constant value for <see cref="HasConfigurationPartProperty.AccessModifier" /></summary>
				public const string ACCESS_MODIFIER = "public";
				/// <summary>Constant value for <see cref="HasConfigurationPartProperty.Modifier" /></summary>
				public const string MODIFIER = "";
				/// <summary>Constant value for <see cref="HasConfigurationPartProperty.NormativeVersion" /></summary>
				public const string NORMATIVE_VERSION = "";
				/// <summary>Constant value for <see cref="HasConfigurationPartProperty.DeprecatedVersion" /></summary>
				public const string DEPRECATED_VERSION = "";
				/// <summary>Constant value for <see cref="HasConfigurationPartProperty.Aggregation" /></summary>
				public const string AGGREGATION = "composite";
				/// <summary>Constant value for <see cref="HasConfigurationPartProperty.Extension" /></summary>
				public const string EXTENSION = "MagicDraw UML 2024x";
				/// <summary>Constant value for <see cref="HasConfigurationPartProperty.Association" /></summary>
				public const string ASSOCIATION = "Configuration";
				/// <summary>Constant value for <see cref="HasConfigurationPartProperty.DefaultValue" /></summary>
				public const string DEFAULT_VALUE = "";

				/// <summary>
				/// <inheritdoc />
				/// <remarks> Type: ConfigurationClass </remarks>
				/// </summary>
				public System.Type Type => typeof(Mtconnect.DeviceInformationModel.Configurations.ConfigurationClass);
				
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
			/// <inheritdoc cref="HashProperty" path="/summary" /><br/>
			/// <remarks>Original Name: Hash</remarks>
			/// </summary>
			public new HashProperty Hash { get; } = new HashProperty();
			
			/// <summary>﻿condensed message digest from a secure one-way hash function. <seealso href="https://www.google.com/search?q=FIPS PUB 180-4&amp;btnI=I">FIPS PUB 180-4</seealso><br /><br /><br />
			/// </summary>
			public new sealed class HashProperty : IProperty
			{
				/// <summary>Constant value for <see cref="HashProperty.Name" /></summary>
				public const string NAME = "hash";
				/// <summary>Constant value for <see cref="HashProperty.Summary" /></summary>
				public const string SUMMARY = @"&#10;&#10;&#10;condensed message digest from a secure one-way hash function. {{cite(FIPS PUB 180-4)}}&#10;
";
				/// <summary>Constant value for <see cref="HashProperty.AccessModifier" /></summary>
				public const string ACCESS_MODIFIER = "public";
				/// <summary>Constant value for <see cref="HashProperty.Modifier" /></summary>
				public const string MODIFIER = "";
				/// <summary>Constant value for <see cref="HashProperty.NormativeVersion" /></summary>
				public const string NORMATIVE_VERSION = "2.2";
				/// <summary>Constant value for <see cref="HashProperty.DeprecatedVersion" /></summary>
				public const string DEPRECATED_VERSION = "";
				/// <summary>Constant value for <see cref="HashProperty.Aggregation" /></summary>
				public const string AGGREGATION = "composite";
				/// <summary>Constant value for <see cref="HashProperty.Extension" /></summary>
				public const string EXTENSION = "MagicDraw UML 2024x";
				/// <summary>Constant value for <see cref="HashProperty.Association" /></summary>
				public const string ASSOCIATION = "";
				/// <summary>Constant value for <see cref="HashProperty.DefaultValue" /></summary>
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
			/// <inheritdoc cref="DescriptionProperty" path="/summary" /><br/>
			/// <remarks>Original Name: Description</remarks>
			/// </summary>
			public new DescriptionProperty Description { get; } = new DescriptionProperty();
			
			/// <summary>﻿textual description for <see cref="Asset">Asset</see>.<br /><br /><br />
			/// </summary>
			public new sealed class DescriptionProperty : IProperty
			{
				/// <summary>Constant value for <see cref="DescriptionProperty.Name" /></summary>
				public const string NAME = "Description";
				/// <summary>Constant value for <see cref="DescriptionProperty.Summary" /></summary>
				public const string SUMMARY = @"&#10;&#10;&#10;textual description for {{block(Asset)}}.&#10;
";
				/// <summary>Constant value for <see cref="DescriptionProperty.AccessModifier" /></summary>
				public const string ACCESS_MODIFIER = "private";
				/// <summary>Constant value for <see cref="DescriptionProperty.Modifier" /></summary>
				public const string MODIFIER = "";
				/// <summary>Constant value for <see cref="DescriptionProperty.NormativeVersion" /></summary>
				public const string NORMATIVE_VERSION = "1.2";
				/// <summary>Constant value for <see cref="DescriptionProperty.DeprecatedVersion" /></summary>
				public const string DEPRECATED_VERSION = "";
				/// <summary>Constant value for <see cref="DescriptionProperty.Aggregation" /></summary>
				public const string AGGREGATION = "composite";
				/// <summary>Constant value for <see cref="DescriptionProperty.Extension" /></summary>
				public const string EXTENSION = "MagicDraw UML 2024x";
				/// <summary>Constant value for <see cref="DescriptionProperty.Association" /></summary>
				public const string ASSOCIATION = "";
				/// <summary>Constant value for <see cref="DescriptionProperty.DefaultValue" /></summary>
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
			/// <inheritdoc cref="ManufacturersProperty" path="/summary" /><br/>
			/// <remarks>Original Name: Manufacturers</remarks>
			/// </summary>
			public new ManufacturersProperty Manufacturers { get; } = new ManufacturersProperty();
			
			/// <summary>﻿
			/// </summary>
			public new sealed class ManufacturersProperty : IProperty
			{
				/// <summary>Constant value for <see cref="ManufacturersProperty.Name" /></summary>
				public const string NAME = "manufacturers";
				/// <summary>Constant value for <see cref="ManufacturersProperty.Summary" /></summary>
				public const string SUMMARY = @"";
				/// <summary>Constant value for <see cref="ManufacturersProperty.AccessModifier" /></summary>
				public const string ACCESS_MODIFIER = "private";
				/// <summary>Constant value for <see cref="ManufacturersProperty.Modifier" /></summary>
				public const string MODIFIER = "";
				/// <summary>Constant value for <see cref="ManufacturersProperty.NormativeVersion" /></summary>
				public const string NORMATIVE_VERSION = "1.2";
				/// <summary>Constant value for <see cref="ManufacturersProperty.DeprecatedVersion" /></summary>
				public const string DEPRECATED_VERSION = "";
				/// <summary>Constant value for <see cref="ManufacturersProperty.Aggregation" /></summary>
				public const string AGGREGATION = "composite";
				/// <summary>Constant value for <see cref="ManufacturersProperty.Extension" /></summary>
				public const string EXTENSION = "";
				/// <summary>Constant value for <see cref="ManufacturersProperty.Association" /></summary>
				public const string ASSOCIATION = "";
				/// <summary>Constant value for <see cref="ManufacturersProperty.DefaultValue" /></summary>
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
			/// <inheritdoc cref="ModelProperty" path="/summary" /><br/>
			/// <remarks>Original Name: Model</remarks>
			/// </summary>
			public new ModelProperty Model { get; } = new ModelProperty();
			
			/// <summary>﻿
			/// </summary>
			public new sealed class ModelProperty : IProperty
			{
				/// <summary>Constant value for <see cref="ModelProperty.Name" /></summary>
				public const string NAME = "model";
				/// <summary>Constant value for <see cref="ModelProperty.Summary" /></summary>
				public const string SUMMARY = @"";
				/// <summary>Constant value for <see cref="ModelProperty.AccessModifier" /></summary>
				public const string ACCESS_MODIFIER = "private";
				/// <summary>Constant value for <see cref="ModelProperty.Modifier" /></summary>
				public const string MODIFIER = "";
				/// <summary>Constant value for <see cref="ModelProperty.NormativeVersion" /></summary>
				public const string NORMATIVE_VERSION = "1.2";
				/// <summary>Constant value for <see cref="ModelProperty.DeprecatedVersion" /></summary>
				public const string DEPRECATED_VERSION = "";
				/// <summary>Constant value for <see cref="ModelProperty.Aggregation" /></summary>
				public const string AGGREGATION = "composite";
				/// <summary>Constant value for <see cref="ModelProperty.Extension" /></summary>
				public const string EXTENSION = "MagicDraw UML 2024x";
				/// <summary>Constant value for <see cref="ModelProperty.Association" /></summary>
				public const string ASSOCIATION = "";
				/// <summary>Constant value for <see cref="ModelProperty.DefaultValue" /></summary>
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
			/// <inheritdoc cref="SerialNumberProperty" path="/summary" /><br/>
			/// <remarks>Original Name: SerialNumber</remarks>
			/// </summary>
			public new SerialNumberProperty SerialNumber { get; } = new SerialNumberProperty();
			
			/// <summary>﻿
			/// </summary>
			public new sealed class SerialNumberProperty : IProperty
			{
				/// <summary>Constant value for <see cref="SerialNumberProperty.Name" /></summary>
				public const string NAME = "serialNumber";
				/// <summary>Constant value for <see cref="SerialNumberProperty.Summary" /></summary>
				public const string SUMMARY = @"";
				/// <summary>Constant value for <see cref="SerialNumberProperty.AccessModifier" /></summary>
				public const string ACCESS_MODIFIER = "private";
				/// <summary>Constant value for <see cref="SerialNumberProperty.Modifier" /></summary>
				public const string MODIFIER = "";
				/// <summary>Constant value for <see cref="SerialNumberProperty.NormativeVersion" /></summary>
				public const string NORMATIVE_VERSION = "1.2";
				/// <summary>Constant value for <see cref="SerialNumberProperty.DeprecatedVersion" /></summary>
				public const string DEPRECATED_VERSION = "";
				/// <summary>Constant value for <see cref="SerialNumberProperty.Aggregation" /></summary>
				public const string AGGREGATION = "composite";
				/// <summary>Constant value for <see cref="SerialNumberProperty.Extension" /></summary>
				public const string EXTENSION = "MagicDraw UML 2024x";
				/// <summary>Constant value for <see cref="SerialNumberProperty.Association" /></summary>
				public const string ASSOCIATION = "";
				/// <summary>Constant value for <see cref="SerialNumberProperty.DefaultValue" /></summary>
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
			/// <inheritdoc cref="StationProperty" path="/summary" /><br/>
			/// <remarks>Original Name: Station</remarks>
			/// </summary>
			public new StationProperty Station { get; } = new StationProperty();
			
			/// <summary>﻿
			/// </summary>
			public new sealed class StationProperty : IProperty
			{
				/// <summary>Constant value for <see cref="StationProperty.Name" /></summary>
				public const string NAME = "station";
				/// <summary>Constant value for <see cref="StationProperty.Summary" /></summary>
				public const string SUMMARY = @"";
				/// <summary>Constant value for <see cref="StationProperty.AccessModifier" /></summary>
				public const string ACCESS_MODIFIER = "private";
				/// <summary>Constant value for <see cref="StationProperty.Modifier" /></summary>
				public const string MODIFIER = "";
				/// <summary>Constant value for <see cref="StationProperty.NormativeVersion" /></summary>
				public const string NORMATIVE_VERSION = "1.2";
				/// <summary>Constant value for <see cref="StationProperty.DeprecatedVersion" /></summary>
				public const string DEPRECATED_VERSION = "";
				/// <summary>Constant value for <see cref="StationProperty.Aggregation" /></summary>
				public const string AGGREGATION = "composite";
				/// <summary>Constant value for <see cref="StationProperty.Extension" /></summary>
				public const string EXTENSION = "MagicDraw UML 2024x";
				/// <summary>Constant value for <see cref="StationProperty.Association" /></summary>
				public const string ASSOCIATION = "";
				/// <summary>Constant value for <see cref="StationProperty.DefaultValue" /></summary>
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