
using System;
using System.CodeDom.Compiler;

using Mtconnect.ObservationInformationModel;
using Mtconnect.AssetInformationModel;

namespace Mtconnect.Fundamentals.MTConnectProtocol.RESTProtocol
{
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "1.0.15.3")]
	public sealed class AgentClass
	{
		/// <inheritdoc cref="Class.ReferenceId" />
		public string ReferenceId => "_19_0_4_45f01b9_1637708823096_359717_5786";
		
		/// <inheritdoc cref="Class.Name" />
		public string Name => "Agent";
		
		/// <inheritdoc cref="Class.AccessModifier" />
		public string AccessModifier => "public";
				
		/// <inheritdoc cref="Class.Modifier" />
		public string Modifier => "";
				
		/// <inheritdoc cref="Class.NormativeVersion" />
		public string NormativeVersion => "MtconnectVersions.V_1_0_1";
				
		/// <inheritdoc cref="Class.DeprecatedVersion" />
		public string DeprecatedVersion => "";

		public string Generalization => "";

		public AgentProperties Properties { get; } = new AgentProperties();
		public sealed class AgentProperties
		{
		
		
			/// <remarks>Original Name: InstanceId</remarks>
			public InstanceIdProperty InstanceId { get; } = new InstanceIdProperty();
			public sealed class InstanceIdProperty
			{
				/// <inheritdoc cref="Property.Type" />
				/// Original Type: _19_0_3_68e0225_1638533232267_921642_410
				public Type Type => typeof(UInt32);
				
				/// <inheritdoc cref="Property.Name" />
				public string Name => "InstanceId";
				
				/// <inheritdoc cref="Property.AccessModifier" />
				public string AccessModifier => "public";
				
				/// <inheritdoc cref="Property.Modifier" />
				public string Modifier => "";
				
				/// <inheritdoc cref="Property.NormativeVersion" />
				public string NormativeVersion => "MtconnectVersions.V_1_0_1";
				
				/// <inheritdoc cref="Property.DeprecatedVersion" />
				public string DeprecatedVersion => "";
				
				public string Aggregation => "composite";

				// Note: Extension.Extender
				public string Extension => "";

				public string Association => "";

				// Note: DefaultValue.Name
				public string DefaultValue => "";

				// TODO: Add Summary
			}
		
		
			/// <remarks>Original Name: SequenceNumber</remarks>
			public SequenceNumberProperty SequenceNumber { get; } = new SequenceNumberProperty();
			public sealed class SequenceNumberProperty
			{
				/// <inheritdoc cref="Property.Type" />
				/// Original Type: _19_0_3_68e0225_1638534140373_733270_671
				public Type Type => typeof(UInt64);
				
				/// <inheritdoc cref="Property.Name" />
				public string Name => "SequenceNumber";
				
				/// <inheritdoc cref="Property.AccessModifier" />
				public string AccessModifier => "public";
				
				/// <inheritdoc cref="Property.Modifier" />
				public string Modifier => "";
				
				/// <inheritdoc cref="Property.NormativeVersion" />
				public string NormativeVersion => "MtconnectVersions.V_1_0_1";
				
				/// <inheritdoc cref="Property.DeprecatedVersion" />
				public string DeprecatedVersion => "";
				
				public string Aggregation => "composite";

				// Note: Extension.Extender
				public string Extension => "";

				public string Association => "";

				// Note: DefaultValue.Name
				public string DefaultValue => "";

				// TODO: Add Summary
			}
		
		
			/// <remarks>Original Name: BufferSize</remarks>
			public BufferSizeProperty BufferSize { get; } = new BufferSizeProperty();
			public sealed class BufferSizeProperty
			{
				/// <inheritdoc cref="Property.Type" />
				/// Original Type: _19_0_3_68e0225_1638533232267_921642_410
				public Type Type => typeof(UInt32);
				
				/// <inheritdoc cref="Property.Name" />
				public string Name => "BufferSize";
				
				/// <inheritdoc cref="Property.AccessModifier" />
				public string AccessModifier => "public";
				
				/// <inheritdoc cref="Property.Modifier" />
				public string Modifier => "";
				
				/// <inheritdoc cref="Property.NormativeVersion" />
				public string NormativeVersion => "MtconnectVersions.V_1_0_1";
				
				/// <inheritdoc cref="Property.DeprecatedVersion" />
				public string DeprecatedVersion => "";
				
				public string Aggregation => "composite";

				// Note: Extension.Extender
				public string Extension => "";

				public string Association => "";

				// Note: DefaultValue.Name
				public string DefaultValue => "";

				// TODO: Add Summary
			}
		
		
			/// <remarks>Original Name: MaxAssets</remarks>
			public MaxAssetsProperty MaxAssets { get; } = new MaxAssetsProperty();
			public sealed class MaxAssetsProperty
			{
				/// <inheritdoc cref="Property.Type" />
				/// Original Type: _19_0_3_68e0225_1638533232267_921642_410
				public Type Type => typeof(UInt32);
				
				/// <inheritdoc cref="Property.Name" />
				public string Name => "MaxAssets";
				
				/// <inheritdoc cref="Property.AccessModifier" />
				public string AccessModifier => "public";
				
				/// <inheritdoc cref="Property.Modifier" />
				public string Modifier => "";
				
				/// <inheritdoc cref="Property.NormativeVersion" />
				public string NormativeVersion => "MtconnectVersions.V_1_2_0";
				
				/// <inheritdoc cref="Property.DeprecatedVersion" />
				public string DeprecatedVersion => "";
				
				public string Aggregation => "composite";

				// Note: Extension.Extender
				public string Extension => "";

				public string Association => "";

				// Note: DefaultValue.Name
				public string DefaultValue => "";

				// TODO: Add Summary
			}
		
		
			/// <remarks>Original Name: AssetCount</remarks>
			public AssetCountProperty AssetCount { get; } = new AssetCountProperty();
			public sealed class AssetCountProperty
			{
				/// <inheritdoc cref="Property.Type" />
				/// Original Type: _19_0_3_68e0225_1638533232267_921642_410
				public Type Type => typeof(UInt32);
				
				/// <inheritdoc cref="Property.Name" />
				public string Name => "AssetCount";
				
				/// <inheritdoc cref="Property.AccessModifier" />
				public string AccessModifier => "public";
				
				/// <inheritdoc cref="Property.Modifier" />
				public string Modifier => "";
				
				/// <inheritdoc cref="Property.NormativeVersion" />
				public string NormativeVersion => "MtconnectVersions.V_1_2_0";
				
				/// <inheritdoc cref="Property.DeprecatedVersion" />
				public string DeprecatedVersion => "";
				
				public string Aggregation => "composite";

				// Note: Extension.Extender
				public string Extension => "";

				public string Association => "";

				// Note: DefaultValue.Name
				public string DefaultValue => "";

				// TODO: Add Summary
			}
		
		
			/// <remarks>Original Name: HasObservation</remarks>
			public HasObservationPartProperty HasObservationPart { get; } = new HasObservationPartProperty();
			public sealed class HasObservationPartProperty
			{
				/// <inheritdoc cref="Property.Type" />
				/// Original Type: _19_0_3_45f01b9_1579566531115_47734_25731
				public Type Type => typeof(ObservationClass);
				
				/// <inheritdoc cref="Property.Name" />
				public string Name => "HasObservation";
				
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

				public string Association => "buffer";

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

				public string Association => "assetBuffer";

				// Note: DefaultValue.Name
				public string DefaultValue => "";

				// TODO: Add Summary
			}
		};

		# region Rules
		/// <summary>
		/// SufficientObservationSpace
		/// </summary>
		/// <remarks>Specification Language: <c>Unspecified</c></remarks>
		/*
		buffer.length < agent.bufferSize
		*/
		/// <summary>
		/// SufficientAssetSpace
		/// </summary>
		/// <remarks>Specification Language: <c>Unspecified</c></remarks>
		/*
		assetBuffer.length < agent.maxAssets
		*/
		# endregion
	}
}