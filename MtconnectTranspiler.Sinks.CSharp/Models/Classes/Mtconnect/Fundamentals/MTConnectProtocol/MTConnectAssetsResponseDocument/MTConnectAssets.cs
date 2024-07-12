
using System;
using System.CodeDom.Compiler;

using Mtconnect.Fundamentals.MTConnectProtocol.MTConnectAssetsResponseDocument;
using Mtconnect.AssetInformationModel;

namespace Mtconnect.Fundamentals.MTConnectProtocol.MTConnectAssetsResponseDocument
{
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "1.0.15.3")]
	public sealed class MTConnectAssetsClass
	{
		/// <inheritdoc cref="Class.ReferenceId" />
		public string ReferenceId => "EAID_AD98C122_E276_4506_AD69_B82107CB3802";
		
		/// <inheritdoc cref="Class.Name" />
		public string Name => "MTConnectAssets";
		
		/// <inheritdoc cref="Class.AccessModifier" />
		public string AccessModifier => "public";
				
		/// <inheritdoc cref="Class.Modifier" />
		public string Modifier => "";
				
		/// <inheritdoc cref="Class.NormativeVersion" />
		public string NormativeVersion => "MtconnectVersions.V_1_2_0";
				
		/// <inheritdoc cref="Class.DeprecatedVersion" />
		public string DeprecatedVersion => "";

		public string Generalization => "";

		public MTConnectAssetsProperties Properties { get; } = new MTConnectAssetsProperties();
		public sealed class MTConnectAssetsProperties
		{
		
		
			/// <remarks>Original Name: HasHeader</remarks>
			public HasHeaderPartProperty HasHeaderPart { get; } = new HasHeaderPartProperty();
			public sealed class HasHeaderPartProperty
			{
				/// <inheritdoc cref="Property.Type" />
				/// Original Type: EAID_B6A102D0_7CF7_495e_816A_17AC11572B70
				public Type Type => typeof(HeaderClass);
				
				/// <inheritdoc cref="Property.Name" />
				public string Name => "HasHeader";
				
				/// <inheritdoc cref="Property.AccessModifier" />
				public string AccessModifier => "public";
				
				/// <inheritdoc cref="Property.Modifier" />
				public string Modifier => "";
				
				/// <inheritdoc cref="Property.NormativeVersion" />
				public string NormativeVersion => "";
				
				/// <inheritdoc cref="Property.DeprecatedVersion" />
				public string DeprecatedVersion => "";
				
				public string Aggregation => "";

				// Note: Extension.Extender
				public string Extension => "MagicDraw UML 19.0";

				public string Association => "Header";

				// Note: DefaultValue.Name
				public string DefaultValue => "";

				// TODO: Add Summary
			}
		
		
			/// <remarks>Original Name: HasAsset</remarks>
			public HasAssetPartProperty HasAssetPart { get; } = new HasAssetPartProperty();
			public sealed class HasAssetPartProperty
			{
				/// <inheritdoc cref="Property.Type" />
				/// Original Type: EAID_C7D39183_23CB_416b_A62D_F60815E08B1A
				public Type Type => typeof(AssetClass);
				
				/// <inheritdoc cref="Property.Name" />
				public string Name => "HasAsset";
				
				/// <inheritdoc cref="Property.AccessModifier" />
				public string AccessModifier => "public";
				
				/// <inheritdoc cref="Property.Modifier" />
				public string Modifier => "";
				
				/// <inheritdoc cref="Property.NormativeVersion" />
				public string NormativeVersion => "";
				
				/// <inheritdoc cref="Property.DeprecatedVersion" />
				public string DeprecatedVersion => "";
				
				public string Aggregation => "composite";

				// Note: Extension.Extender
				public string Extension => "";

				public string Association => "Assets";

				// Note: DefaultValue.Name
				public string DefaultValue => "";

				// TODO: Add Summary
			}
		};

	}
}