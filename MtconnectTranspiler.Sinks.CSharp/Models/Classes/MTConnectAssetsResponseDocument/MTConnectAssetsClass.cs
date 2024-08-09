using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;

namespace Mtconnect.Fundamentals.MTConnectProtocol.MTConnectAssetsResponseDocument
{
	/// <summary>
	/// root entity of an <i>MTConnectAssets Response Document</i> that contains the <i>Asset Information Model</i> of <see cref="Asset">Asset</see> types.  ![MTConnectAssets](figures/MTConnectAssets.png "MTConnectAssets"){: width="0.8"}  > Note: Additional properties of <see cref="MTConnectAssets">MTConnectAssets</see> <b>MAY</b> be defined for schema and namespace declaration. See <see cref="Schema and Namespace Declaration Information">Schema and Namespace Declaration Information</see> for an <i>XML</i> example.
	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Structure__EAID_AD98C122_E276_4506_AD69_B82107CB3802">model.mtconnect.org</seealso> for more information.
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.3.0.0")]
	public sealed class MTConnectAssetsClass : IClass
	{
		/// <inheritdoc />
		public string ReferenceId => "EAID_AD98C122_E276_4506_AD69_B82107CB3802";
		
		/// <inheritdoc />
		public string Summary => @"/// root entity of an <i>MTConnectAssets Response Document</i> that contains the <i>Asset Information Model</i> of <see cref=""Asset"">Asset</see> types.  ![MTConnectAssets](figures/MTConnectAssets.png ""MTConnectAssets""){: width=""0.8""}  > Note: Additional properties of <see cref=""MTConnectAssets"">MTConnectAssets</see> <b>MAY</b> be defined for schema and namespace declaration. See <see cref=""Schema and Namespace Declaration Information"">Schema and Namespace Declaration Information</see> for an <i>XML</i> example.";

		/// <inheritdoc />
		public string Name => "MTConnectAssets";
		
		/// <inheritdoc />
		public string AccessModifier => "public";
				
		/// <inheritdoc />
		public string Modifier => "";
				
		/// <inheritdoc />
		public string NormativeVersion => "1.2";
				
		/// <inheritdoc />
		public string DeprecatedVersion => "";
		
		/// <inheritdoc />
		public Type Generalization => null;

		/// <inheritdoc />
		public MTConnectAssetsClassProperties Properties { get; } = new MTConnectAssetsClassProperties();
        IPropertyList IClass.Properties => Properties;
		public class MTConnectAssetsClassProperties : IPropertyList
		{
			/// <inheritdoc />
			public IProperty[] Properties => new IProperty[] {
				HasHeaderPart,
				HasAssetPart,
			};
			/// <summary>
			/// <inheritdoc cref="HasHeaderPartProperty" path="/summary" /><br/>
			/// <remarks>Original Name: HasHeader</remarks>
			/// </summary>
			public HasHeaderPartProperty HasHeaderPart { get; } = new HasHeaderPartProperty();
			public sealed class HasHeaderPartProperty : IProperty
			{
				/// <summary>
				/// <inheritdoc />
				/// <remarks>
				/// <list type="bullet">
				/// <item>Original Type: EAID_B6A102D0_7CF7_495e_816A_17AC11572B70</item>
				/// <item>Type: HeaderClass</item>
				/// <item>Namespace: Mtconnect.Fundamentals.MTConnectProtocol.MTConnectAssetsResponseDocument</item>
				/// </list>
				/// </remarks>
				/// </summary>
				public System.Type Type => typeof(Mtconnect.Fundamentals.MTConnectProtocol.MTConnectAssetsResponseDocument.HeaderClass);
				
				/// <inheritdoc />
				public string Name => "hasHeader";
				
				/// <inheritdoc />
				public string Summary => @"/// root entity of an <i>MTConnectAssets Response Document</i> that contains the <i>Asset Information Model</i> of <see cref=""Asset"">Asset</see> types.  ![MTConnectAssets](figures/MTConnectAssets.png ""MTConnectAssets""){: width=""0.8""}  > Note: Additional properties of <see cref=""MTConnectAssets"">MTConnectAssets</see> <b>MAY</b> be defined for schema and namespace declaration. See <see cref=""Schema and Namespace Declaration Information"">Schema and Namespace Declaration Information</see> for an <i>XML</i> example.";

				/// <inheritdoc />
				public string AccessModifier => "public";
				
				/// <inheritdoc />
				public string Modifier => "";
				
				/// <inheritdoc />
				public string NormativeVersion => "";
				
				/// <inheritdoc />
				public string DeprecatedVersion => "";
				
				/// <inheritdoc />
				public string Aggregation => "";

				// Note: Extension.Extender
				/// <inheritdoc />
				public string Extension => "MagicDraw UML 19.0";
				
				/// <inheritdoc />
				public string Association => "Header";

				// Note: DefaultValue.Name
				/// <inheritdoc />
				public string DefaultValue => "";
			}
			/// <summary>
			/// <inheritdoc cref="HasAssetPartProperty" path="/summary" /><br/>
			/// <remarks>Original Name: HasAsset</remarks>
			/// </summary>
			public HasAssetPartProperty HasAssetPart { get; } = new HasAssetPartProperty();
			public sealed class HasAssetPartProperty : IProperty
			{
				/// <summary>
				/// <inheritdoc />
				/// <remarks>
				/// <list type="bullet">
				/// <item>Original Type: EAID_C7D39183_23CB_416b_A62D_F60815E08B1A</item>
				/// <item>Type: AssetClass</item>
				/// <item>Namespace: Mtconnect.AssetInformationModel</item>
				/// </list>
				/// </remarks>
				/// </summary>
				public System.Type Type => typeof(Mtconnect.AssetInformationModel.AssetClass);
				
				/// <inheritdoc />
				public string Name => "hasAsset";
				
				/// <inheritdoc />
				public string Summary => @"/// root entity of an <i>MTConnectAssets Response Document</i> that contains the <i>Asset Information Model</i> of <see cref=""Asset"">Asset</see> types.  ![MTConnectAssets](figures/MTConnectAssets.png ""MTConnectAssets""){: width=""0.8""}  > Note: Additional properties of <see cref=""MTConnectAssets"">MTConnectAssets</see> <b>MAY</b> be defined for schema and namespace declaration. See <see cref=""Schema and Namespace Declaration Information"">Schema and Namespace Declaration Information</see> for an <i>XML</i> example.";

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
				public string Extension => "";
				
				/// <inheritdoc />
				public string Association => "Assets";

				// Note: DefaultValue.Name
				/// <inheritdoc />
				public string DefaultValue => "";
			}
		};

	}
}