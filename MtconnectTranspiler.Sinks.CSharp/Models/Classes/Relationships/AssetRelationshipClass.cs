#pragma warning disable CS0109 // Member does not hide an inherited member; new keyword is not required
#pragma warning disable CS1574 // XML comment has cref attribute that could not be resolved
#pragma warning disable CS1584 // XML comment has syntactically incorrect cref attribute
#pragma warning disable CS0618 // Type or member is obsolete
using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;
using System.Linq;

namespace Mtconnect.DeviceInformationModel.Configurations.Relationships
{
	/// <summary>﻿<see cref="ConfigurationRelationship">ConfigurationRelationship</see> that describes the association between a <see cref="Component">Component</see> and an <see cref="Asset">Asset</see>.<br /><br /><br />
	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Structure___19_0_3_68e0225_1658942745281_216676_1135">model.mtconnect.org</seealso> for more information.
	/// </summary>
	/// <remarks>
	/// <list type="bullet">
	/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_2.1">v2.1</see></item>
	/// </list>
	/// </remarks>

	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public sealed class AssetRelationshipClass : IClass
	{
		/// <summary>Constant value for <see cref="AssetRelationshipClass.ReferenceId" /></summary>
		public const string REFERENCE_ID = "_19_0_3_68e0225_1658942745281_216676_1135";
		/// <summary>Constant value for <see cref="AssetRelationshipClass.HelpUrl" /></summary>
		public const string HELP_URL = "https://model.mtconnect.org/#Structure___19_0_3_68e0225_1658942745281_216676_1135";
		/// <summary>Constant value for <see cref="AssetRelationshipClass.Summary" /></summary>
		public const string SUMMARY = @"&#10;&#10;&#10;{{block(ConfigurationRelationship)}} that describes the association between a {{block(Component)}} and an {{block(Asset)}}.&#10;
";
		/// <summary>Constant value for <see cref="AssetRelationshipClass.Name" /></summary>
		public const string NAME = "AssetRelationship";
		/// <summary>Constant value for <see cref="AssetRelationshipClass.AccessModifier" /></summary>
		public const string ACCESS_MODIFIER = "public";
		/// <summary>Constant value for <see cref="AssetRelationshipClass.Modifier" /></summary>
		public const string MODIFIER = "";
		/// <summary>Constant value for <see cref="AssetRelationshipClass.NormativeVersion" /></summary>
		public const string NORMATIVE_VERSION = "2.1";
		/// <summary>Constant value for <see cref="AssetRelationshipClass.DeprecatedVersion" /></summary>
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
		/// Original Type: EAID_28132294_DF39_4e8e_8AE5_B79565F991A2
		/// </remarks>
		public Type Generalization => typeof(Mtconnect.DeviceInformationModel.Configurations.Relationships.ConfigurationRelationshipClass);

		/// <inheritdoc />
		public new AssetRelationshipClassProperties Properties { get; } = new AssetRelationshipClassProperties();
        IPropertyList IClass.Properties => Properties;
		/// <summary>
		/// Property list for <see cref="AssetRelationshipClass" />.
		/// <br/><b>Note</b>, some properties (<see cref="IProperty" />) are inherited from <see cref="Mtconnect.DeviceInformationModel.Configurations.Relationships.ConfigurationRelationshipClass.ConfigurationRelationshipClassProperties" />.
		/// </summary>
		public class AssetRelationshipClassProperties : Mtconnect.DeviceInformationModel.Configurations.Relationships.ConfigurationRelationshipClass.ConfigurationRelationshipClassProperties
		{
			/// <inheritdoc />
			public override IProperty[] Properties => new IProperty[] {
				AssetIdRef,
				AssetType,
				Href,
			}.Concat(base.Properties).ToArray();
			/// <summary>
			/// <inheritdoc cref="AssetIdRefProperty" path="/summary" /><br/>
			/// <remarks>Original Name: AssetIdRef</remarks>
			/// </summary>
			public new AssetIdRefProperty AssetIdRef { get; } = new AssetIdRefProperty();
			
			/// <summary>﻿uuid of the related <see cref="Asset">Asset</see>.<br /><br /><br />
			/// </summary>
			public new sealed class AssetIdRefProperty : IProperty
			{
				/// <summary>Constant value for <see cref="AssetIdRefProperty.Name" /></summary>
				public const string NAME = "assetIdRef";
				/// <summary>Constant value for <see cref="AssetIdRefProperty.Summary" /></summary>
				public const string SUMMARY = @"&#10;&#10;&#10;uuid of the related {{block(Asset)}}.&#10;
";
				/// <summary>Constant value for <see cref="AssetIdRefProperty.AccessModifier" /></summary>
				public const string ACCESS_MODIFIER = "public";
				/// <summary>Constant value for <see cref="AssetIdRefProperty.Modifier" /></summary>
				public const string MODIFIER = "";
				/// <summary>Constant value for <see cref="AssetIdRefProperty.NormativeVersion" /></summary>
				public const string NORMATIVE_VERSION = "2.1";
				/// <summary>Constant value for <see cref="AssetIdRefProperty.DeprecatedVersion" /></summary>
				public const string DEPRECATED_VERSION = "";
				/// <summary>Constant value for <see cref="AssetIdRefProperty.Aggregation" /></summary>
				public const string AGGREGATION = "";
				/// <summary>Constant value for <see cref="AssetIdRefProperty.Extension" /></summary>
				public const string EXTENSION = "MagicDraw UML 2024x";
				/// <summary>Constant value for <see cref="AssetIdRefProperty.Association" /></summary>
				public const string ASSOCIATION = "";
				/// <summary>Constant value for <see cref="AssetIdRefProperty.DefaultValue" /></summary>
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
			/// <inheritdoc cref="AssetTypeProperty" path="/summary" /><br/>
			/// <remarks>Original Name: AssetType</remarks>
			/// </summary>
			public new AssetTypeProperty AssetType { get; } = new AssetTypeProperty();
			
			/// <summary>﻿type of <see cref="Asset">Asset</see> being referenced.<br /><br /><br />
			/// </summary>
			public new sealed class AssetTypeProperty : IProperty
			{
				/// <summary>Constant value for <see cref="AssetTypeProperty.Name" /></summary>
				public const string NAME = "assetType";
				/// <summary>Constant value for <see cref="AssetTypeProperty.Summary" /></summary>
				public const string SUMMARY = @"&#10;&#10;&#10;type of {{block(Asset)}} being referenced.&#10;
";
				/// <summary>Constant value for <see cref="AssetTypeProperty.AccessModifier" /></summary>
				public const string ACCESS_MODIFIER = "public";
				/// <summary>Constant value for <see cref="AssetTypeProperty.Modifier" /></summary>
				public const string MODIFIER = "";
				/// <summary>Constant value for <see cref="AssetTypeProperty.NormativeVersion" /></summary>
				public const string NORMATIVE_VERSION = "2.1";
				/// <summary>Constant value for <see cref="AssetTypeProperty.DeprecatedVersion" /></summary>
				public const string DEPRECATED_VERSION = "";
				/// <summary>Constant value for <see cref="AssetTypeProperty.Aggregation" /></summary>
				public const string AGGREGATION = "composite";
				/// <summary>Constant value for <see cref="AssetTypeProperty.Extension" /></summary>
				public const string EXTENSION = "MagicDraw UML 2024x";
				/// <summary>Constant value for <see cref="AssetTypeProperty.Association" /></summary>
				public const string ASSOCIATION = "";
				/// <summary>Constant value for <see cref="AssetTypeProperty.DefaultValue" /></summary>
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
			/// <inheritdoc cref="HrefProperty" path="/summary" /><br/>
			/// <remarks>Original Name: Href</remarks>
			/// </summary>
			public new HrefProperty Href { get; } = new HrefProperty();
			
			/// <summary>﻿<i>URI</i> reference to the associated <see cref="Asset">Asset</see>.<br /><br /><br />Description<br /><br /><see cref="AssetRelationship.href">href in AssetRelationship</see> <b>MUST</b> also include the <see cref="Device.uuid">uuid in Device</see> for that specific piece of equipment.<br /><br /><see cref="AssetRelationship.href">href in AssetRelationship</see> is of type <c>xlink:href</c> from the W3C XLink specification: <seealso href="https://www.google.com/search?q=https://www.w3.org/TR/xlink11/&amp;btnI=I">https://www.w3.org/TR/xlink11/</seealso>.<br /><br /><br /><br /><br />
			/// </summary>
			public new sealed class HrefProperty : IProperty
			{
				/// <summary>Constant value for <see cref="HrefProperty.Name" /></summary>
				public const string NAME = "href";
				/// <summary>Constant value for <see cref="HrefProperty.Summary" /></summary>
				public const string SUMMARY = @"&#10;&#10;&#10;{{term(URI)}} reference to the associated {{block(Asset)}}.&#10;
&#10;&#10;&#10;Description&#10;&#10;&#10;&#10;{{property(AssetRelationship::href)}} **MUST** also include the {{property(Device::uuid)}} for that specific piece of equipment.

{{property(AssetRelationship::href)}} is of type `xlink:href` from the W3C XLink specification: {{cite(https://www.w3.org/TR/xlink11/)}}.&#10;
";
				/// <summary>Constant value for <see cref="HrefProperty.AccessModifier" /></summary>
				public const string ACCESS_MODIFIER = "public";
				/// <summary>Constant value for <see cref="HrefProperty.Modifier" /></summary>
				public const string MODIFIER = "";
				/// <summary>Constant value for <see cref="HrefProperty.NormativeVersion" /></summary>
				public const string NORMATIVE_VERSION = "2.1";
				/// <summary>Constant value for <see cref="HrefProperty.DeprecatedVersion" /></summary>
				public const string DEPRECATED_VERSION = "";
				/// <summary>Constant value for <see cref="HrefProperty.Aggregation" /></summary>
				public const string AGGREGATION = "";
				/// <summary>Constant value for <see cref="HrefProperty.Extension" /></summary>
				public const string EXTENSION = "MagicDraw UML 2024x";
				/// <summary>Constant value for <see cref="HrefProperty.Association" /></summary>
				public const string ASSOCIATION = "";
				/// <summary>Constant value for <see cref="HrefProperty.DefaultValue" /></summary>
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