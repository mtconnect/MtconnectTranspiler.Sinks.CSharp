using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;
// using Mtconnect.Fundamentals.MTConnectProtocol.MTConnectAssetsResponseDocument;
// using Mtconnect.ObservationInformationModel;

namespace Mtconnect.Fundamentals.MTConnectProtocol.MTConnectStreamsResponseDocument
{
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "1.0.15.3")]
	public sealed class MTConnectStreamsClass : IClass
	{
		/// <inheritdoc />
		public string ReferenceId => "EAID_156BB3E5_EB08_4e64_A874_6DDFC07D68CC";
		
		/// <inheritdoc />
		public string Name => "MTConnectStreamsClass";
		
		/// <inheritdoc />
		public string AccessModifier => "public";
				
		/// <inheritdoc />
		public string Modifier => "";
				
		/// <inheritdoc />
		public string NormativeVersion => "1.0";
				
		/// <inheritdoc />
		public string DeprecatedVersion => "";
		
		/// <inheritdoc />
		public string Generalization => "";

		/// <inheritdoc />
		public MTConnectStreamsClassProperties Properties { get; } = new MTConnectStreamsClassProperties();
        IPropertyList IClass.Properties => Properties;
		public sealed class MTConnectStreamsClassProperties : IPropertyList
		{
			/// <inheritdoc />
			public IProperty[] Properties => new IProperty[] {
				HasHeaderPart,
				HasDeviceStreamPart,
			};
			/// <remarks>Original Name: HasHeader</remarks>
			public HasHeaderPartProperty HasHeaderPart { get; } = new HasHeaderPartProperty();
			public sealed class HasHeaderPartProperty : IProperty
			{
				/// <summary>
				/// <inheritdoc />
				/// <remarks>
				/// <list type="bullet">
				/// <item>Original Type: EAID_2299B0B3_B209_47ae_B93A_BA694AD50051</item>
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
			/// <remarks>Original Name: HasDeviceStream</remarks>
			public HasDeviceStreamPartProperty HasDeviceStreamPart { get; } = new HasDeviceStreamPartProperty();
			public sealed class HasDeviceStreamPartProperty : IProperty
			{
				/// <summary>
				/// <inheritdoc />
				/// <remarks>
				/// <list type="bullet">
				/// <item>Original Type: EAID_02192189_58E6_456c_A679_CDDFF559DA00</item>
				/// <item>Type: DeviceStreamClass</item>
				/// <item>Namespace: Mtconnect.ObservationInformationModel</item>
				/// </list>
				/// </remarks>
				/// </summary>
				public System.Type Type => typeof(Mtconnect.ObservationInformationModel.DeviceStreamClass);
				
				/// <inheritdoc />
				public string Name => "HasDeviceStream";
				
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
				public string Association => "Streams";

				// Note: DefaultValue.Name
				/// <inheritdoc />
				public string DefaultValue => "";

				// TODO: Add Summary
			}
		};

	}
}