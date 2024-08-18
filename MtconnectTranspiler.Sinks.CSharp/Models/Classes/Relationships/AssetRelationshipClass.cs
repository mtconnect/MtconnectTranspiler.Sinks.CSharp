#pragma warning disable CS0109 // Member does not hide an inherited member; new keyword is not required
#pragma warning disable CS1574 // XML comment has cref attribute that could not be resolved
#pragma warning disable CS1584 // XML comment has syntactically incorrect cref attribute
using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;
using System.Linq;

namespace Mtconnect.DeviceInformationModel.Configurations.Relationships
{
	/// <summary>﻿<see cref="ConfigurationRelationship">ConfigurationRelationship</see> that describes the association between a <see cref="Component">Component</see> and an <see cref="Asset">Asset</see>.<br /><br /><br />
	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Structure___19_0_3_68e0225_1658942745281_216676_1135">model.mtconnect.org</seealso> for more information.
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public sealed class AssetRelationshipClass : IClass
	{
		/// <inheritdoc />
		public string ReferenceId => "_19_0_3_68e0225_1658942745281_216676_1135";
		
		/// <inheritdoc />
		public string Summary => @"&#10;&#10;&#10;{{block(ConfigurationRelationship)}} that describes the association between a {{block(Component)}} and an {{block(Asset)}}.&#10;
";

		/// <inheritdoc />
		public string Name => "AssetRelationship";
		
		/// <inheritdoc />
		public string AccessModifier => "public";
				
		/// <inheritdoc />
		public string Modifier => "";
				
		/// <inheritdoc />
		public string NormativeVersion => "2.1";
				
		/// <inheritdoc />
		public string DeprecatedVersion => "";
		
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
				public string Name => "assetIdRef";
				
				/// <inheritdoc />
				public string Summary => @"&#10;&#10;&#10;uuid of the related {{block(Asset)}}.&#10;
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
			/// <inheritdoc cref="AssetTypeProperty" path="/summary" /><br/>
			/// <remarks>Original Name: AssetType</remarks>
			/// </summary>
			public new AssetTypeProperty AssetType { get; } = new AssetTypeProperty();
			
			/// <summary>﻿type of <see cref="Asset">Asset</see> being referenced.<br /><br /><br />
			/// </summary>
			public new sealed class AssetTypeProperty : IProperty
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
				public string Name => "assetType";
				
				/// <inheritdoc />
				public string Summary => @"&#10;&#10;&#10;type of {{block(Asset)}} being referenced.&#10;
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
			
			/// <summary>﻿<i>URI</i> reference to the associated <see cref="Asset">Asset</see>.<br /><br /><br />Description<br /><br /><see cref="AssetRelationship.href">href in AssetRelationship</see> <b>MUST</b> also include the <see cref="Device.uuid">uuid in Device</see> for that specific piece of equipment.<br /><br /><see cref="AssetRelationship.href">href in AssetRelationship</see> is of type <c>xlink:href</c> from the W3C XLink specification: <seealso href="https://www.google.com/search?q=https://www.w3.org/TR/xlink11/&btnI=I">https://www.w3.org/TR/xlink11/</seealso>.<br /><br /><br /><br /><br />
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
				public string Summary => @"&#10;&#10;&#10;{{term(URI)}} reference to the associated {{block(Asset)}}.&#10;
&#10;&#10;&#10;Description&#10;&#10;&#10;&#10;{{property(AssetRelationship::href)}} **MUST** also include the {{property(Device::uuid)}} for that specific piece of equipment.

{{property(AssetRelationship::href)}} is of type `xlink:href` from the W3C XLink specification: {{cite(https://www.w3.org/TR/xlink11/)}}.&#10;
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