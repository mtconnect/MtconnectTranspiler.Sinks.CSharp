using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;
using System.Linq;

namespace Mtconnect.AssetInformationModel
{
	/// <summary>
	﻿/// abstract <i>Asset</i>. <br/><br />Description<br/>It is used in the manufacturing process, but is not permanently associated with a single piece of equipment. It can be removed from the piece of equipment without compromising its function, and can be associated with other pieces of equipment during its lifecycle.<br /><br /><br />![Asset](figures/Asset.png "Asset"){: width="0.8"}<br /><br />> Note: See <see cref="Assets Schema Diagrams">Assets Schema Diagrams</see> for XML schema.<br/><br/><br />

	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Structure__EAID_C7D39183_23CB_416b_A62D_F60815E08B1A">model.mtconnect.org</seealso> for more information.
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public sealed class AssetClass : IClass
	{
		/// <inheritdoc />
		public string ReferenceId => "EAID_C7D39183_23CB_416b_A62D_F60815E08B1A";
		
		/// <inheritdoc />
		public string Summary => @"&#10;&#10;&#10;abstract {{term(Asset)}}. &#10;
&#10;&#10;&#10;Description&#10;&#10;&#10;&#10;It is used in the manufacturing process, but is not permanently associated with a single piece of equipment. It can be removed from the piece of equipment without compromising its function, and can be associated with other pieces of equipment during its lifecycle.


![Asset](figures/Asset.png ""Asset""){: width=""0.8""}

> Note: See {{sect(Assets Schema Diagrams)}} for XML schema.&#10;
";

		/// <inheritdoc />
		public string Name => "Asset";
		
		/// <inheritdoc />
		public string AccessModifier => "public";
				
		/// <inheritdoc />
		public string Modifier => "abstract";
				
		/// <inheritdoc />
		public string NormativeVersion => "1.2";
				
		/// <inheritdoc />
		public string DeprecatedVersion => "";
		
		/// <inheritdoc />
		/// <remarks>
		/// Original Type: _19_0_3_45f01b9_1581734255313_425984_984
		/// </remarks>
		public Type Generalization => typeof(Mtconnect.Glossary.MTConnectTerms.AssetGeneralization);

		/// <inheritdoc />
		public AssetClassProperties Properties { get; } = new AssetClassProperties();
        IPropertyList IClass.Properties => Properties;
		public class AssetClassProperties : Mtconnect.Glossary.MTConnectTerms.AssetGeneralization.AssetGeneralizationProperties
		{
			/// <inheritdoc />
			public IProperty[] Properties => new IProperty[] {
				AssetId,
				DeviceUuid,
				Removed,
				Timestamp,
				HasDescriptionPart,
				HasConfigurationPart,
				Hash,
			}.Concat(base.Properties).ToArray();
			/// <summary>
			/// <inheritdoc cref="AssetIdProperty" path="/summary" /><br/>
			/// <remarks>Original Name: AssetId</remarks>
			/// </summary>
			public AssetIdProperty AssetId { get; } = new AssetIdProperty();
			/// <summary>
			﻿/// unique identifier for an <see cref="Asset">Asset</see>.<br/><br />

			/// </summary>
			public sealed class AssetIdProperty : IProperty
			{
				/// <summary>
				/// <inheritdoc />
				/// <remarks>
				/// <list type="bullet">
				/// <item>Original Type: _19_0_3_91b028d_1579272245466_691733_672</item>
				/// <item>Type: String</item>
				/// <item>Namespace: </item>
				/// </list>
				/// </remarks>
				/// </summary>
				public System.Type Type => typeof(String);
				
				/// <inheritdoc />
				public string Name => "assetId";
				
				/// <inheritdoc />
				public string Summary => @"&#10;&#10;&#10;unique identifier for an {{block(Asset)}}.&#10;
";

				/// <inheritdoc />
				public string AccessModifier => "public";
				
				/// <inheritdoc />
				public string Modifier => "";
				
				/// <inheritdoc />
				public string NormativeVersion => "1.2";
				
				/// <inheritdoc />
				public string DeprecatedVersion => "";
				
				/// <inheritdoc />
				public string Aggregation => "";

				// Note: Extension.Extender
				/// <inheritdoc />
				public string Extension => "MagicDraw UML 19.0";
				
				/// <inheritdoc />
				public string Association => "";

				// Note: DefaultValue.Name
				/// <inheritdoc />
				public string DefaultValue => "";
			}
			/// <summary>
			/// <inheritdoc cref="DeviceUuidProperty" path="/summary" /><br/>
			/// <remarks>Original Name: DeviceUuid</remarks>
			/// </summary>
			public DeviceUuidProperty DeviceUuid { get; } = new DeviceUuidProperty();
			/// <summary>
			﻿/// associated piece of equipment's <i>UUID</i> that supplied the <see cref="Asset">Asset</see>'s data.<br /><br />It references to <see cref="Device.uuid">uuid in Device</see> defined in <see cref="Device Information Model">Device Information Model</see>.<br/><br />

			/// </summary>
			public sealed class DeviceUuidProperty : IProperty
			{
				/// <summary>
				/// <inheritdoc />
				/// <remarks>
				/// <list type="bullet">
				/// <item>Original Type: _19_0_3_91b028d_1579272245466_691733_672</item>
				/// <item>Type: String</item>
				/// <item>Namespace: </item>
				/// </list>
				/// </remarks>
				/// </summary>
				public System.Type Type => typeof(String);
				
				/// <inheritdoc />
				public string Name => "deviceUuid";
				
				/// <inheritdoc />
				public string Summary => @"&#10;&#10;&#10;associated piece of equipment's {{term(UUID)}} that supplied the {{block(Asset)}}'s data.

It references to {{property(Device::uuid)}} defined in {{package(Device Information Model)}}.&#10;
";

				/// <inheritdoc />
				public string AccessModifier => "public";
				
				/// <inheritdoc />
				public string Modifier => "";
				
				/// <inheritdoc />
				public string NormativeVersion => "1.2";
				
				/// <inheritdoc />
				public string DeprecatedVersion => "";
				
				/// <inheritdoc />
				public string Aggregation => "";

				// Note: Extension.Extender
				/// <inheritdoc />
				public string Extension => "MagicDraw UML 19.0";
				
				/// <inheritdoc />
				public string Association => "";

				// Note: DefaultValue.Name
				/// <inheritdoc />
				public string DefaultValue => "";
			}
			/// <summary>
			/// <inheritdoc cref="RemovedProperty" path="/summary" /><br/>
			/// <remarks>Original Name: Removed</remarks>
			/// </summary>
			public RemovedProperty Removed { get; } = new RemovedProperty();
			/// <summary>
			﻿/// indicator that the <see cref="Asset">Asset</see> has been removed from the piece of equipment.<br/><br />

			/// </summary>
			public sealed class RemovedProperty : IProperty
			{
				/// <summary>
				/// <inheritdoc />
				/// <remarks>
				/// <list type="bullet">
				/// <item>Original Type: _19_0_3_91b028d_1579278876899_683310_3821</item>
				/// <item>Type: Boolean</item>
				/// <item>Namespace: </item>
				/// </list>
				/// </remarks>
				/// </summary>
				public System.Type Type => typeof(Boolean);
				
				/// <inheritdoc />
				public string Name => "removed";
				
				/// <inheritdoc />
				public string Summary => @"&#10;&#10;&#10;indicator that the {{block(Asset)}} has been removed from the piece of equipment.&#10;
";

				/// <inheritdoc />
				public string AccessModifier => "public";
				
				/// <inheritdoc />
				public string Modifier => "";
				
				/// <inheritdoc />
				public string NormativeVersion => "1.3";
				
				/// <inheritdoc />
				public string DeprecatedVersion => "";
				
				/// <inheritdoc />
				public string Aggregation => "";

				// Note: Extension.Extender
				/// <inheritdoc />
				public string Extension => "MagicDraw UML 19.0";
				
				/// <inheritdoc />
				public string Association => "";

				// Note: DefaultValue.Name
				/// <inheritdoc />
				public string DefaultValue => "";
			}
			/// <summary>
			/// <inheritdoc cref="TimestampProperty" path="/summary" /><br/>
			/// <remarks>Original Name: Timestamp</remarks>
			/// </summary>
			public TimestampProperty Timestamp { get; } = new TimestampProperty();
			/// <summary>
			﻿/// time the <see cref="Asset">Asset</see> data was last modified.<br/><br />

			/// </summary>
			public sealed class TimestampProperty : IProperty
			{
				/// <summary>
				/// <inheritdoc />
				/// <remarks>
				/// <list type="bullet">
				/// <item>Original Type: _19_0_3_91b028d_1579272233011_597138_670</item>
				/// <item>Type: DateTime</item>
				/// <item>Namespace: </item>
				/// </list>
				/// </remarks>
				/// </summary>
				public System.Type Type => typeof(DateTime);
				
				/// <inheritdoc />
				public string Name => "timestamp";
				
				/// <inheritdoc />
				public string Summary => @"&#10;&#10;&#10;time the {{block(Asset)}} data was last modified.&#10;
";

				/// <inheritdoc />
				public string AccessModifier => "public";
				
				/// <inheritdoc />
				public string Modifier => "";
				
				/// <inheritdoc />
				public string NormativeVersion => "1.2";
				
				/// <inheritdoc />
				public string DeprecatedVersion => "";
				
				/// <inheritdoc />
				public string Aggregation => "";

				// Note: Extension.Extender
				/// <inheritdoc />
				public string Extension => "MagicDraw UML 19.0";
				
				/// <inheritdoc />
				public string Association => "";

				// Note: DefaultValue.Name
				/// <inheritdoc />
				public string DefaultValue => "";
			}
			/// <summary>
			/// <inheritdoc cref="HasDescriptionPartProperty" path="/summary" /><br/>
			/// <remarks>Original Name: HasDescription</remarks>
			/// </summary>
			public HasDescriptionPartProperty HasDescriptionPart { get; } = new HasDescriptionPartProperty();
			/// <summary>
			﻿/// Description can contain any descriptive content about the Asset.<br/><br />

			/// </summary>
			public sealed class HasDescriptionPartProperty : IProperty
			{
				/// <summary>
				/// <inheritdoc />
				/// <remarks>
				/// <list type="bullet">
				/// <item>Original Type: EAID_64352755_7251_46af_846D_937E5A1E3949</item>
				/// <item>Type: DescriptionClass</item>
				/// <item>Namespace: Mtconnect.DeviceInformationModel.Components</item>
				/// </list>
				/// </remarks>
				/// </summary>
				public System.Type Type => typeof(Mtconnect.DeviceInformationModel.Components.DescriptionClass);
				
				/// <inheritdoc />
				public string Name => "hasDescription";
				
				/// <inheritdoc />
				public string Summary => @"&#10;&#10;&#10;Description can contain any descriptive content about the Asset.&#10;
";

				/// <inheritdoc />
				public string AccessModifier => "public";
				
				/// <inheritdoc />
				public string Modifier => "";
				
				/// <inheritdoc />
				public string NormativeVersion => "";
				
				/// <inheritdoc />
				public string DeprecatedVersion => "";
				
				/// <inheritdoc />
				public string Aggregation => "composite";

				// Note: Extension.Extender
				/// <inheritdoc />
				public string Extension => "MagicDraw UML 19.0";
				
				/// <inheritdoc />
				public string Association => "Description";

				// Note: DefaultValue.Name
				/// <inheritdoc />
				public string DefaultValue => "";
			}
			/// <summary>
			/// <inheritdoc cref="HasConfigurationPartProperty" path="/summary" /><br/>
			/// <remarks>Original Name: HasConfiguration</remarks>
			/// </summary>
			public HasConfigurationPartProperty HasConfigurationPart { get; } = new HasConfigurationPartProperty();
			public sealed class HasConfigurationPartProperty : IProperty
			{
				/// <summary>
				/// <inheritdoc />
				/// <remarks>
				/// <list type="bullet">
				/// <item>Original Type: EAID_C04DCC77_16E8_4cef_92D4_B777AFC52570</item>
				/// <item>Type: ConfigurationClass</item>
				/// <item>Namespace: Mtconnect.DeviceInformationModel.Configurations</item>
				/// </list>
				/// </remarks>
				/// </summary>
				public System.Type Type => typeof(Mtconnect.DeviceInformationModel.Configurations.ConfigurationClass);
				
				/// <inheritdoc />
				public string Name => "hasConfiguration";
				
				/// <inheritdoc />
				public string Summary => @"";

				/// <inheritdoc />
				public string AccessModifier => "public";
				
				/// <inheritdoc />
				public string Modifier => "";
				
				/// <inheritdoc />
				public string NormativeVersion => "";
				
				/// <inheritdoc />
				public string DeprecatedVersion => "";
				
				/// <inheritdoc />
				public string Aggregation => "composite";

				// Note: Extension.Extender
				/// <inheritdoc />
				public string Extension => "MagicDraw UML 19.0";
				
				/// <inheritdoc />
				public string Association => "Configuration";

				// Note: DefaultValue.Name
				/// <inheritdoc />
				public string DefaultValue => "";
			}
			/// <summary>
			/// <inheritdoc cref="HashProperty" path="/summary" /><br/>
			/// <remarks>Original Name: Hash</remarks>
			/// </summary>
			public HashProperty Hash { get; } = new HashProperty();
			/// <summary>
			﻿/// condensed message digest from a secure one-way hash function. <seealso href="https://www.google.com/search?q=FIPS PUB 180-4&btnI=I">FIPS PUB 180-4</seealso><br/><br />

			/// </summary>
			public sealed class HashProperty : IProperty
			{
				/// <summary>
				/// <inheritdoc />
				/// <remarks>
				/// <list type="bullet">
				/// <item>Original Type: _19_0_3_91b028d_1579272360416_763325_681</item>
				/// <item>Type: String</item>
				/// <item>Namespace: </item>
				/// </list>
				/// </remarks>
				/// </summary>
				public System.Type Type => typeof(String);
				
				/// <inheritdoc />
				public string Name => "hash";
				
				/// <inheritdoc />
				public string Summary => @"&#10;&#10;&#10;condensed message digest from a secure one-way hash function. {{cite(FIPS PUB 180-4)}}&#10;
";

				/// <inheritdoc />
				public string AccessModifier => "public";
				
				/// <inheritdoc />
				public string Modifier => "";
				
				/// <inheritdoc />
				public string NormativeVersion => "2.2";
				
				/// <inheritdoc />
				public string DeprecatedVersion => "";
				
				/// <inheritdoc />
				public string Aggregation => "composite";

				// Note: Extension.Extender
				/// <inheritdoc />
				public string Extension => "MagicDraw UML 19.0";
				
				/// <inheritdoc />
				public string Association => "";

				// Note: DefaultValue.Name
				/// <inheritdoc />
				public string DefaultValue => "";
			}
		};

	}
}