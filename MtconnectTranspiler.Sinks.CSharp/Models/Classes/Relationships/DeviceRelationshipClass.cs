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
	/// <summary>﻿<see cref="ConfigurationRelationship">ConfigurationRelationship</see> that describes the association between two pieces of equipment that function independently but together perform a manufacturing operation.<br /><br /><br />
	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Structure__EAID_E20AAF35_BE17_40e8_8701_D2D7676EDC69">model.mtconnect.org</seealso> for more information.
	/// </summary>
	/// <remarks>
	/// <list type="bullet">
	/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.5">v1.5</see></item>
	/// </list>
	/// </remarks>

	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public sealed class DeviceRelationshipClass : IClass
	{
		/// <summary>Constant value for <see cref="DeviceRelationshipClass.ReferenceId" /></summary>
		public const string REFERENCE_ID = "EAID_E20AAF35_BE17_40e8_8701_D2D7676EDC69";
		/// <summary>Constant value for <see cref="DeviceRelationshipClass.HelpUrl" /></summary>
		public const string HELP_URL = "https://model.mtconnect.org/#Structure__EAID_E20AAF35_BE17_40e8_8701_D2D7676EDC69";
		/// <summary>Constant value for <see cref="DeviceRelationshipClass.Summary" /></summary>
		public const string SUMMARY = @"&#10;&#10;&#10;{{block(ConfigurationRelationship)}} that describes the association between two pieces of equipment that function independently but together perform a manufacturing operation.&#10;
";
		/// <summary>Constant value for <see cref="DeviceRelationshipClass.Name" /></summary>
		public const string NAME = "DeviceRelationship";
		/// <summary>Constant value for <see cref="DeviceRelationshipClass.AccessModifier" /></summary>
		public const string ACCESS_MODIFIER = "public";
		/// <summary>Constant value for <see cref="DeviceRelationshipClass.Modifier" /></summary>
		public const string MODIFIER = "";
		/// <summary>Constant value for <see cref="DeviceRelationshipClass.NormativeVersion" /></summary>
		public const string NORMATIVE_VERSION = "1.5";
		/// <summary>Constant value for <see cref="DeviceRelationshipClass.DeprecatedVersion" /></summary>
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
		public new DeviceRelationshipClassProperties Properties { get; } = new DeviceRelationshipClassProperties();
        IPropertyList IClass.Properties => Properties;
		/// <summary>
		/// Property list for <see cref="DeviceRelationshipClass" />.
		/// <br/><b>Note</b>, some properties (<see cref="IProperty" />) are inherited from <see cref="Mtconnect.DeviceInformationModel.Configurations.Relationships.ConfigurationRelationshipClass.ConfigurationRelationshipClassProperties" />.
		/// </summary>
		public class DeviceRelationshipClassProperties : Mtconnect.DeviceInformationModel.Configurations.Relationships.ConfigurationRelationshipClass.ConfigurationRelationshipClassProperties
		{
			/// <inheritdoc />
			public override IProperty[] Properties => new IProperty[] {
				DeviceUuidRef,
				Href,
				Role,
				Xlink_Type,
			}.Concat(base.Properties).ToArray();
			/// <summary>
			/// <inheritdoc cref="DeviceUuidRefProperty" path="/summary" /><br/>
			/// <remarks>Original Name: DeviceUuidRef</remarks>
			/// </summary>
			public new DeviceUuidRefProperty DeviceUuidRef { get; } = new DeviceUuidRefProperty();
			
			/// <summary>﻿reference to the <see cref="Device.uuid">uuid in Device</see> of the associated piece of equipment.<br /><br /><br />
			/// </summary>
			public new sealed class DeviceUuidRefProperty : IProperty
			{
				/// <summary>Constant value for <see cref="DeviceUuidRefProperty.Name" /></summary>
				public const string NAME = "deviceUuidRef";
				/// <summary>Constant value for <see cref="DeviceUuidRefProperty.Summary" /></summary>
				public const string SUMMARY = @"&#10;&#10;&#10;reference to the {{property(Device::uuid)}} of the associated piece of equipment.&#10;
";
				/// <summary>Constant value for <see cref="DeviceUuidRefProperty.AccessModifier" /></summary>
				public const string ACCESS_MODIFIER = "public";
				/// <summary>Constant value for <see cref="DeviceUuidRefProperty.Modifier" /></summary>
				public const string MODIFIER = "";
				/// <summary>Constant value for <see cref="DeviceUuidRefProperty.NormativeVersion" /></summary>
				public const string NORMATIVE_VERSION = "1.5";
				/// <summary>Constant value for <see cref="DeviceUuidRefProperty.DeprecatedVersion" /></summary>
				public const string DEPRECATED_VERSION = "";
				/// <summary>Constant value for <see cref="DeviceUuidRefProperty.Aggregation" /></summary>
				public const string AGGREGATION = "";
				/// <summary>Constant value for <see cref="DeviceUuidRefProperty.Extension" /></summary>
				public const string EXTENSION = "MagicDraw UML 2024x";
				/// <summary>Constant value for <see cref="DeviceUuidRefProperty.Association" /></summary>
				public const string ASSOCIATION = "";
				/// <summary>Constant value for <see cref="DeviceUuidRefProperty.DefaultValue" /></summary>
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
			/// <inheritdoc cref="HrefProperty" path="/summary" /><br/>
			/// <remarks>Original Name: Href</remarks>
			/// </summary>
			public new HrefProperty Href { get; } = new HrefProperty();
			
			/// <summary>﻿<i>URI</i> identifying the <i>agent</i> that is publishing information for the associated piece of equipment. <br /><br /><br />Description<br /><br /><see cref="DeviceRelationship.href">href in DeviceRelationship</see> <b>MUST</b> also include the <see cref="Device.uuid">uuid in Device</see> for that specific piece of equipment.<br /><br />{{property(href)}} is of type <c>xlink:href</c> from the W3C XLink specification: <seealso href="https://www.google.com/search?q=https://www.w3.org/TR/xlink11/&amp;btnI=I">https://www.w3.org/TR/xlink11/</seealso>.<br /><br /><br /><br /><br />
			/// </summary>
			public new sealed class HrefProperty : IProperty
			{
				/// <summary>Constant value for <see cref="HrefProperty.Name" /></summary>
				public const string NAME = "href";
				/// <summary>Constant value for <see cref="HrefProperty.Summary" /></summary>
				public const string SUMMARY = @"&#10;&#10;&#10;{{term(URI)}} identifying the {{term(agent)}} that is publishing information for the associated piece of equipment. &#10;
&#10;&#10;&#10;Description&#10;&#10;&#10;&#10;{{property(DeviceRelationship::href)}} **MUST** also include the {{property(Device::uuid)}} for that specific piece of equipment.

{{property(href)}} is of type `xlink:href` from the W3C XLink specification: {{cite(https://www.w3.org/TR/xlink11/)}}.&#10;
";
				/// <summary>Constant value for <see cref="HrefProperty.AccessModifier" /></summary>
				public const string ACCESS_MODIFIER = "public";
				/// <summary>Constant value for <see cref="HrefProperty.Modifier" /></summary>
				public const string MODIFIER = "";
				/// <summary>Constant value for <see cref="HrefProperty.NormativeVersion" /></summary>
				public const string NORMATIVE_VERSION = "1.5";
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
			/// <summary>
			/// <inheritdoc cref="RoleProperty" path="/summary" /><br/>
			/// <remarks>Original Name: Role</remarks>
			/// </summary>
			public new RoleProperty Role { get; } = new RoleProperty();
			
			/// <summary>﻿defines the services or capabilities that the referenced piece of equipment provides relative to this piece of equipment.<br /><br /><br />
			/// </summary>
			public new sealed class RoleProperty : IProperty
			{
				/// <summary>Constant value for <see cref="RoleProperty.Name" /></summary>
				public const string NAME = "role";
				/// <summary>Constant value for <see cref="RoleProperty.Summary" /></summary>
				public const string SUMMARY = @"&#10;&#10;&#10;defines the services or capabilities that the referenced piece of equipment provides relative to this piece of equipment.&#10;
";
				/// <summary>Constant value for <see cref="RoleProperty.AccessModifier" /></summary>
				public const string ACCESS_MODIFIER = "public";
				/// <summary>Constant value for <see cref="RoleProperty.Modifier" /></summary>
				public const string MODIFIER = "";
				/// <summary>Constant value for <see cref="RoleProperty.NormativeVersion" /></summary>
				public const string NORMATIVE_VERSION = "1.5";
				/// <summary>Constant value for <see cref="RoleProperty.DeprecatedVersion" /></summary>
				public const string DEPRECATED_VERSION = "";
				/// <summary>Constant value for <see cref="RoleProperty.Aggregation" /></summary>
				public const string AGGREGATION = "";
				/// <summary>Constant value for <see cref="RoleProperty.Extension" /></summary>
				public const string EXTENSION = "MagicDraw UML 2024x";
				/// <summary>Constant value for <see cref="RoleProperty.Association" /></summary>
				public const string ASSOCIATION = "";
				/// <summary>Constant value for <see cref="RoleProperty.DefaultValue" /></summary>
				public const string DEFAULT_VALUE = "";

				/// <summary>
				/// <inheritdoc />
				/// <remarks> Type: RoleTypeEnumMetaClass </remarks>
				/// </summary>
				public System.Type Type => typeof(Mtconnect.DataTypes.RoleTypeEnumMetaClass);
				
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
			/// <inheritdoc cref="Xlink_TypeProperty" path="/summary" /><br/>
			/// <remarks>Original Name: Xlink:Type</remarks>
			/// </summary>
			public new Xlink_TypeProperty Xlink_Type { get; } = new Xlink_TypeProperty();
			
			/// <summary>﻿<c>xlink:type</c><b>MUST</b> have a fixed value of <c>locator</c> as defined in W3C XLink 1.1 <seealso href="https://www.google.com/search?q=https://www.w3.org/TR/xlink11/&amp;btnI=I">https://www.w3.org/TR/xlink11/</seealso>.<br /><br /><br />Description<br /><br />If the <see cref="DeviceRelationship.href">href in DeviceRelationship</see> is provided, it <b>MUST</b> conform to the <i>URI</i> syntactic rules as defined in IETF RFC 3986 for Uniform Resource Identifiers. <seealso href="https://www.google.com/search?q=https://www.ietf.org/rfc/rfc3986.txt&amp;btnI=I">https://www.ietf.org/rfc/rfc3986.txt</seealso><br /><br /><br /><br /><br />
			/// </summary>
			public new sealed class Xlink_TypeProperty : IProperty
			{
				/// <summary>Constant value for <see cref="Xlink_TypeProperty.Name" /></summary>
				public const string NAME = "xlink:type";
				/// <summary>Constant value for <see cref="Xlink_TypeProperty.Summary" /></summary>
				public const string SUMMARY = @"&#10;&#10;&#10;`xlink:type`**MUST** have a fixed value of `locator` as defined in W3C XLink 1.1 {{cite(https://www.w3.org/TR/xlink11/)}}.&#10;
&#10;&#10;&#10;Description&#10;&#10;&#10;&#10;If the {{property(DeviceRelationship::href)}} is provided, it **MUST** conform to the {{term(URI)}} syntactic rules as defined in IETF RFC 3986 for Uniform Resource Identifiers. {{cite(https://www.ietf.org/rfc/rfc3986.txt)}}&#10;
";
				/// <summary>Constant value for <see cref="Xlink_TypeProperty.AccessModifier" /></summary>
				public const string ACCESS_MODIFIER = "public";
				/// <summary>Constant value for <see cref="Xlink_TypeProperty.Modifier" /></summary>
				public const string MODIFIER = "";
				/// <summary>Constant value for <see cref="Xlink_TypeProperty.NormativeVersion" /></summary>
				public const string NORMATIVE_VERSION = "1.5";
				/// <summary>Constant value for <see cref="Xlink_TypeProperty.DeprecatedVersion" /></summary>
				public const string DEPRECATED_VERSION = "";
				/// <summary>Constant value for <see cref="Xlink_TypeProperty.Aggregation" /></summary>
				public const string AGGREGATION = "";
				/// <summary>Constant value for <see cref="Xlink_TypeProperty.Extension" /></summary>
				public const string EXTENSION = "MagicDraw UML 2024x";
				/// <summary>Constant value for <see cref="Xlink_TypeProperty.Association" /></summary>
				public const string ASSOCIATION = "";
				/// <summary>Constant value for <see cref="Xlink_TypeProperty.DefaultValue" /></summary>
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