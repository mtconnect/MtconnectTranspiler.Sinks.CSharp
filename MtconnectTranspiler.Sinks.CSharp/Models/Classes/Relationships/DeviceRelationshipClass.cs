using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;
// using Mtconnect.DataTypes;

namespace Mtconnect.DeviceInformationModel.Configurations.Relationships
{
	/// <summary>
	/// <see cref="ConfigurationRelationship">ConfigurationRelationship</see> that describes the association between two pieces of equipment that function independently but together perform a manufacturing operation.
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.3.0.0")]
	public sealed class DeviceRelationshipClass : IClass
	{
		/// <inheritdoc />
		public string ReferenceId => "EAID_E20AAF35_BE17_40e8_8701_D2D7676EDC69";
		
		/// <inheritdoc />
		public string Summary => @"/// <see cref=""ConfigurationRelationship"">ConfigurationRelationship</see> that describes the association between two pieces of equipment that function independently but together perform a manufacturing operation.";

		/// <inheritdoc />
		public string Name => "DeviceRelationshipClass";
		
		/// <inheritdoc />
		public string AccessModifier => "public";
				
		/// <inheritdoc />
		public string Modifier => "";
				
		/// <inheritdoc />
		public string NormativeVersion => "1.5";
				
		/// <inheritdoc />
		public string DeprecatedVersion => "";
		
		/// <inheritdoc />
		public string Generalization => "EAID_28132294_DF39_4e8e_8AE5_B79565F991A2";

		/// <inheritdoc />
		public DeviceRelationshipClassProperties Properties { get; } = new DeviceRelationshipClassProperties();
        IPropertyList IClass.Properties => Properties;
		public sealed class DeviceRelationshipClassProperties : IPropertyList
		{
			/// <inheritdoc />
			public IProperty[] Properties => new IProperty[] {
				DeviceUuidRef,
				Href,
				Role,
				Xlink_Type,
			};
			/// <summary>
			/// <inheritdoc cref="DeviceUuidRefProperty" path="/summary" /><br/>
			/// <remarks>Original Name: DeviceUuidRef</remarks>
			/// </summary>
			public DeviceUuidRefProperty DeviceUuidRef { get; } = new DeviceUuidRefProperty();
			/// <summary>
			/// reference to the <see cref="Device::uuid" /> of the associated piece of equipment.
			/// </summary>
			public sealed class DeviceUuidRefProperty : IProperty
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
				public string Name => "DeviceUuidRef";
				
				/// <inheritdoc />
				public string Summary => @"/// <see cref=""ConfigurationRelationship"">ConfigurationRelationship</see> that describes the association between two pieces of equipment that function independently but together perform a manufacturing operation.";

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
			public HrefProperty Href { get; } = new HrefProperty();
			/// <summary>
			/// <i>URI</i> identifying the <i>agent</i> that is publishing information for the associated piece of equipment. /// Description
			/// </summary>
			public sealed class HrefProperty : IProperty
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
				public string Name => "Href";
				
				/// <inheritdoc />
				public string Summary => @"/// <see cref=""ConfigurationRelationship"">ConfigurationRelationship</see> that describes the association between two pieces of equipment that function independently but together perform a manufacturing operation.";

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
			public RoleProperty Role { get; } = new RoleProperty();
			/// <summary>
			/// defines the services or capabilities that the referenced piece of equipment provides relative to this piece of equipment.
			/// </summary>
			public sealed class RoleProperty : IProperty
			{
				/// <summary>
				/// <inheritdoc />
				/// <remarks>
				/// <list type="bullet">
				/// <item>Original Type: _19_0_3_91b028d_1579301039819_63145_6975</item>
				/// <item>Type: RoleTypeEnum</item>
				/// <item>Namespace: Mtconnect.DataTypes</item>
				/// </list>
				/// </remarks>
				/// </summary>
				public System.Type Type => typeof(Mtconnect.DataTypes.RoleTypeEnum);
				
				/// <inheritdoc />
				public string Name => "Role";
				
				/// <inheritdoc />
				public string Summary => @"/// <see cref=""ConfigurationRelationship"">ConfigurationRelationship</see> that describes the association between two pieces of equipment that function independently but together perform a manufacturing operation.";

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
			public Xlink_TypeProperty Xlink_Type { get; } = new Xlink_TypeProperty();
			/// <summary>
			/// <c>xlink:type</c><b>MUST</b> have a fixed value of <c>locator</c> as defined in W3C XLink 1.1 <seealso href="https://www.google.com/search?q=https://www.w3.org/TR/xlink11/&btnI=I">https://www.w3.org/TR/xlink11/</seealso>./// Description
			/// </summary>
			public sealed class Xlink_TypeProperty : IProperty
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
				public string Name => "Xlink:Type";
				
				/// <inheritdoc />
				public string Summary => @"/// <see cref=""ConfigurationRelationship"">ConfigurationRelationship</see> that describes the association between two pieces of equipment that function independently but together perform a manufacturing operation.";

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