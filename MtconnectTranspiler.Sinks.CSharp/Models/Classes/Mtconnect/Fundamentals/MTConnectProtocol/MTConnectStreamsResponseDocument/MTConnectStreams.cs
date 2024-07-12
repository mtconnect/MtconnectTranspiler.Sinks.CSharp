
using System;
using System.CodeDom.Compiler;

using Mtconnect.Fundamentals.MTConnectProtocol.MTConnectAssetsResponseDocument;
using Mtconnect.ObservationInformationModel;

namespace Mtconnect.Fundamentals.MTConnectProtocol.MTConnectStreamsResponseDocument
{
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "1.0.15.3")]
	public sealed class MTConnectStreamsClass
	{
		/// <inheritdoc cref="Class.ReferenceId" />
		public string ReferenceId => "EAID_156BB3E5_EB08_4e64_A874_6DDFC07D68CC";
		
		/// <inheritdoc cref="Class.Name" />
		public string Name => "MTConnectStreams";
		
		/// <inheritdoc cref="Class.AccessModifier" />
		public string AccessModifier => "public";
				
		/// <inheritdoc cref="Class.Modifier" />
		public string Modifier => "";
				
		/// <inheritdoc cref="Class.NormativeVersion" />
		public string NormativeVersion => "MtconnectVersions.V_1_0_1";
				
		/// <inheritdoc cref="Class.DeprecatedVersion" />
		public string DeprecatedVersion => "";

		public string Generalization => "";

		public MTConnectStreamsProperties Properties { get; } = new MTConnectStreamsProperties();
		public sealed class MTConnectStreamsProperties
		{
		
		
			/// <remarks>Original Name: HasHeader</remarks>
			public HasHeaderPartProperty HasHeaderPart { get; } = new HasHeaderPartProperty();
			public sealed class HasHeaderPartProperty
			{
				/// <inheritdoc cref="Property.Type" />
				/// Original Type: EAID_2299B0B3_B209_47ae_B93A_BA694AD50051
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
		
		
			/// <remarks>Original Name: HasDeviceStream</remarks>
			public HasDeviceStreamPartProperty HasDeviceStreamPart { get; } = new HasDeviceStreamPartProperty();
			public sealed class HasDeviceStreamPartProperty
			{
				/// <inheritdoc cref="Property.Type" />
				/// Original Type: EAID_02192189_58E6_456c_A679_CDDFF559DA00
				public Type Type => typeof(DeviceStreamClass);
				
				/// <inheritdoc cref="Property.Name" />
				public string Name => "HasDeviceStream";
				
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

				public string Association => "Streams";

				// Note: DefaultValue.Name
				public string DefaultValue => "";

				// TODO: Add Summary
			}
		};

	}
}