using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;

namespace Mtconnect.DeviceInformationModel.Configurations.Relationships
{
	/// <summary>
	/// <see cref="ConfigurationRelationship">ConfigurationRelationship</see> that describes the association between a <see cref="Component">Component</see> and an <see cref="Asset">Asset</see>.
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.3.0.0")]
	public sealed class AssetRelationshipClass : IClass
	{
		/// <inheritdoc />
		public string ReferenceId => "_19_0_3_68e0225_1658942745281_216676_1135";
		
		/// <inheritdoc />
		public string Summary => @"/// <see cref=""ConfigurationRelationship"">ConfigurationRelationship</see> that describes the association between a <see cref=""Component"">Component</see> and an <see cref=""Asset"">Asset</see>.";

		/// <inheritdoc />
		public string Name => "AssetRelationshipClass";
		
		/// <inheritdoc />
		public string AccessModifier => "public";
				
		/// <inheritdoc />
		public string Modifier => "";
				
		/// <inheritdoc />
		public string NormativeVersion => "2.1";
				
		/// <inheritdoc />
		public string DeprecatedVersion => "";
		
		/// <inheritdoc />
		public string Generalization => "EAID_28132294_DF39_4e8e_8AE5_B79565F991A2";

		/// <inheritdoc />
		public AssetRelationshipClassProperties Properties { get; } = new AssetRelationshipClassProperties();
        IPropertyList IClass.Properties => Properties;
		public sealed class AssetRelationshipClassProperties : IPropertyList
		{
			/// <inheritdoc />
			public IProperty[] Properties => new IProperty[] {
				AssetIdRef,
				AssetType,
				Href,
			};
			/// <summary>
			/// <inheritdoc cref="AssetIdRefProperty" path="/summary" /><br/>
			/// <remarks>Original Name: AssetIdRef</remarks>
			/// </summary>
			public AssetIdRefProperty AssetIdRef { get; } = new AssetIdRefProperty();
			/// <summary>
			/// uuid of the related <see cref="Asset">Asset</see>.
			/// </summary>
			public sealed class AssetIdRefProperty : IProperty
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
				public string Name => "AssetIdRef";
				
				/// <inheritdoc />
				public string Summary => @"/// <see cref=""ConfigurationRelationship"">ConfigurationRelationship</see> that describes the association between a <see cref=""Component"">Component</see> and an <see cref=""Asset"">Asset</see>.";

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
			public AssetTypeProperty AssetType { get; } = new AssetTypeProperty();
			/// <summary>
			/// type of <see cref="Asset">Asset</see> being referenced.
			/// </summary>
			public sealed class AssetTypeProperty : IProperty
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
				public string Name => "AssetType";
				
				/// <inheritdoc />
				public string Summary => @"/// <see cref=""ConfigurationRelationship"">ConfigurationRelationship</see> that describes the association between a <see cref=""Component"">Component</see> and an <see cref=""Asset"">Asset</see>.";

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
			public HrefProperty Href { get; } = new HrefProperty();
			/// <summary>
			/// <i>URI</i> reference to the associated <see cref="Asset">Asset</see>./// Description
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
				public string Summary => @"/// <see cref=""ConfigurationRelationship"">ConfigurationRelationship</see> that describes the association between a <see cref=""Component"">Component</see> and an <see cref=""Asset"">Asset</see>.";

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