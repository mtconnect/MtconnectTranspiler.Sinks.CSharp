#pragma warning disable CS0109 // Member does not hide an inherited member; new keyword is not required
#pragma warning disable CS1574 // XML comment has cref attribute that could not be resolved
#pragma warning disable CS1584 // XML comment has syntactically incorrect cref attribute
using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;
using System.Linq;

namespace Mtconnect.DeviceInformationModel.Configurations.Relationships
{
	/// <summary>﻿<see cref="ConfigurationRelationship">ConfigurationRelationship</see> that describes the association between two pieces of equipment that function independently but together perform a manufacturing operation.<br /><br /><br />
	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Structure__EAID_E20AAF35_BE17_40e8_8701_D2D7676EDC69">model.mtconnect.org</seealso> for more information.
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public sealed class DeviceRelationshipClass : IClass
	{
		/// <inheritdoc />
		public string ReferenceId => "EAID_E20AAF35_BE17_40e8_8701_D2D7676EDC69";
		
		/// <inheritdoc />
		public string Summary => @"&#10;&#10;&#10;{{block(ConfigurationRelationship)}} that describes the association between two pieces of equipment that function independently but together perform a manufacturing operation.&#10;
";

		/// <inheritdoc />
		public string Name => "DeviceRelationship";
		
		/// <inheritdoc />
		public string AccessModifier => "public";
				
		/// <inheritdoc />
		public string Modifier => "";
				
		/// <inheritdoc />
		public string NormativeVersion => "1.5";
				
		/// <inheritdoc />
		public string DeprecatedVersion => "";
		
		/// <inheritdoc />
		/// <remarks>
		/// Original Type: EAID_28132294_DF39_4e8e_8AE5_B79565F991A2
		/// </remarks>
		public Type Generalization => typeof(Mtconnect.DeviceInformationModel.Configurations.Relationships.ConfigurationRelationshipClass);

		/// <inheritdoc />
		public DeviceRelationshipClassProperties Properties { get; } = new DeviceRelationshipClassProperties();
        IPropertyList IClass.Properties => Properties;
		/// <summary>
		/// Property list for <see cref="DeviceRelationshipClass" />.
		/// <br/><b>Note</b>, some properties (<see cref="IProperty" />) are inherited from <see cref="Mtconnect.DeviceInformationModel.Configurations.Relationships.ConfigurationRelationshipClass.ConfigurationRelationshipClassProperties" />.
		/// </summary>
		public class DeviceRelationshipClassProperties : Mtconnect.DeviceInformationModel.Configurations.Relationships.ConfigurationRelationshipClass.ConfigurationRelationshipClassProperties
		{
			/// <inheritdoc />
			public new IProperty[] Properties => new IProperty[] {
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
				public string Name => "deviceUuidRef";
				
				/// <inheritdoc />
				public string Summary => @"&#10;&#10;&#10;reference to the {{property(Device::uuid)}} of the associated piece of equipment.&#10;
";

				/// <inheritdoc />
				public string AccessModifier => "public";
				
				/// <inheritdoc />
				public string Modifier => "";
				
				/// <inheritdoc />
				public string NormativeVersion => "1.5";
				
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
			/// <inheritdoc cref="HrefProperty" path="/summary" /><br/>
			/// <remarks>Original Name: Href</remarks>
			/// </summary>
			public new HrefProperty Href { get; } = new HrefProperty();
			
			/// <summary>﻿<i>URI</i> identifying the <i>agent</i> that is publishing information for the associated piece of equipment. <br /><br /><br />Description<br /><br /><see cref="DeviceRelationship.href">href in DeviceRelationship</see> <b>MUST</b> also include the <see cref="Device.uuid">uuid in Device</see> for that specific piece of equipment.<br /><br />{{property(href)}} is of type <c>xlink:href</c> from the W3C XLink specification: <seealso href="https://www.google.com/search?q=https://www.w3.org/TR/xlink11/&btnI=I">https://www.w3.org/TR/xlink11/</seealso>.<br /><br /><br /><br /><br />
			/// </summary>
			public new sealed class HrefProperty : IProperty
			{
				/// <summary>
				/// <inheritdoc />
				/// <remarks>
				/// <list type="bullet">
				/// <item>Original Type: _19_0_3_91b028d_1579298271303_312832_6966</item>
				/// <item>Type: String</item>
				/// <item>Namespace: </item>
				/// </list>
				/// </remarks>
				/// </summary>
				public System.Type Type => typeof(String);
				
				/// <inheritdoc />
				public string Name => "href";
				
				/// <inheritdoc />
				public string Summary => @"&#10;&#10;&#10;{{term(URI)}} identifying the {{term(agent)}} that is publishing information for the associated piece of equipment. &#10;
&#10;&#10;&#10;Description&#10;&#10;&#10;&#10;{{property(DeviceRelationship::href)}} **MUST** also include the {{property(Device::uuid)}} for that specific piece of equipment.

{{property(href)}} is of type `xlink:href` from the W3C XLink specification: {{cite(https://www.w3.org/TR/xlink11/)}}.&#10;
";

				/// <inheritdoc />
				public string AccessModifier => "public";
				
				/// <inheritdoc />
				public string Modifier => "";
				
				/// <inheritdoc />
				public string NormativeVersion => "1.5";
				
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
			/// <inheritdoc cref="RoleProperty" path="/summary" /><br/>
			/// <remarks>Original Name: Role</remarks>
			/// </summary>
			public new RoleProperty Role { get; } = new RoleProperty();
			
			/// <summary>﻿defines the services or capabilities that the referenced piece of equipment provides relative to this piece of equipment.<br /><br /><br />
			/// </summary>
			public new sealed class RoleProperty : IProperty
			{
				/// <summary>
				/// <inheritdoc />
				/// <remarks>
				/// <list type="bullet">
				/// <item>Original Type: _19_0_3_91b028d_1579301039819_63145_6975</item>
				/// <item>Type: RoleTypeEnumMetaClass</item>
				/// <item>Namespace: Mtconnect.DataTypes</item>
				/// </list>
				/// </remarks>
				/// </summary>
				public System.Type Type => typeof(Mtconnect.DataTypes.RoleTypeEnumMetaClass);
				
				/// <inheritdoc />
				public string Name => "role";
				
				/// <inheritdoc />
				public string Summary => @"&#10;&#10;&#10;defines the services or capabilities that the referenced piece of equipment provides relative to this piece of equipment.&#10;
";

				/// <inheritdoc />
				public string AccessModifier => "public";
				
				/// <inheritdoc />
				public string Modifier => "";
				
				/// <inheritdoc />
				public string NormativeVersion => "1.5";
				
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
			/// <inheritdoc cref="Xlink_TypeProperty" path="/summary" /><br/>
			/// <remarks>Original Name: Xlink:Type</remarks>
			/// </summary>
			public new Xlink_TypeProperty Xlink_Type { get; } = new Xlink_TypeProperty();
			
			/// <summary>﻿<c>xlink:type</c><b>MUST</b> have a fixed value of <c>locator</c> as defined in W3C XLink 1.1 <seealso href="https://www.google.com/search?q=https://www.w3.org/TR/xlink11/&btnI=I">https://www.w3.org/TR/xlink11/</seealso>.<br /><br /><br />Description<br /><br />If the <see cref="DeviceRelationship.href">href in DeviceRelationship</see> is provided, it <b>MUST</b> conform to the <i>URI</i> syntactic rules as defined in IETF RFC 3986 for Uniform Resource Identifiers. <seealso href="https://www.google.com/search?q=https://www.ietf.org/rfc/rfc3986.txt&btnI=I">https://www.ietf.org/rfc/rfc3986.txt</seealso><br /><br /><br /><br /><br />
			/// </summary>
			public new sealed class Xlink_TypeProperty : IProperty
			{
				/// <summary>
				/// <inheritdoc />
				/// <remarks>
				/// <list type="bullet">
				/// <item>Original Type: _19_0_3_91b028d_1579298283941_424312_6968</item>
				/// <item>Type: String</item>
				/// <item>Namespace: </item>
				/// </list>
				/// </remarks>
				/// </summary>
				public System.Type Type => typeof(String);
				
				/// <inheritdoc />
				public string Name => "xlink:type";
				
				/// <inheritdoc />
				public string Summary => @"&#10;&#10;&#10;`xlink:type`**MUST** have a fixed value of `locator` as defined in W3C XLink 1.1 {{cite(https://www.w3.org/TR/xlink11/)}}.&#10;
&#10;&#10;&#10;Description&#10;&#10;&#10;&#10;If the {{property(DeviceRelationship::href)}} is provided, it **MUST** conform to the {{term(URI)}} syntactic rules as defined in IETF RFC 3986 for Uniform Resource Identifiers. {{cite(https://www.ietf.org/rfc/rfc3986.txt)}}&#10;
";

				/// <inheritdoc />
				public string AccessModifier => "public";
				
				/// <inheritdoc />
				public string Modifier => "";
				
				/// <inheritdoc />
				public string NormativeVersion => "1.5";
				
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
		};

	}
}