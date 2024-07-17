using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;
// using Mtconnect.Fundamentals.MTConnectProtocol.MTConnectAssetsResponseDocument;
// using Mtconnect.AssetInformationModel;

namespace Mtconnect.Fundamentals.MTConnectProtocol.MTConnectAssetsResponseDocument
{
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "1.0.15.3")]
	public sealed class MTConnectAssetsClass : IClass
	{
		/// <inheritdoc />
		public string ReferenceId => "EAID_AD98C122_E276_4506_AD69_B82107CB3802";
		
		/// <inheritdoc />
		public string Name => "MTConnectAssetsClass";
		
		/// <inheritdoc />
		public string AccessModifier => "public";
				
		/// <inheritdoc />
		public string Modifier => "";
				
		/// <inheritdoc />
		public string NormativeVersion => "1.2";
				
		/// <inheritdoc />
		public string DeprecatedVersion => "";
		
		/// <inheritdoc />
		public string Generalization => "";

		/// <inheritdoc />
		public MTConnectAssetsClassProperties Properties { get; } = new MTConnectAssetsClassProperties();
        IPropertyList IClass.Properties => Properties;
		public sealed class MTConnectAssetsClassProperties : IPropertyList
		{
			/// <inheritdoc />
			public IProperty[] Properties => new IProperty[] {
				HasHeaderPart,
				HasAssetPart,
			};
			/// <remarks>Original Name: HasHeader</remarks>
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
				public string Name => "HasHeader";
				
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

				// TODO: Add Summary
			}
			/// <remarks>Original Name: HasAsset</remarks>
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
				public string Name => "HasAsset";
				
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

				// TODO: Add Summary
			}
		};

	}
}