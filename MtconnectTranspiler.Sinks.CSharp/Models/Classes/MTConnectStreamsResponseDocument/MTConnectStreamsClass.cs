using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;

namespace Mtconnect.Fundamentals.MTConnectProtocol.MTConnectStreamsResponseDocument
{
	/// <summary>
	/// root entity of an <i>MTConnectStreams Response Document</i> that contains the <i>Observation Information Model</i> of one or more <see cref="Device">Device</see> entities.  ![MTConnectStreams](figures/MTConnectStreams.png "MTConnectStreams"){: width="0.8"}  > Note: Additional properties of <see cref="MTConnectStreams">MTConnectStreams</see> <b>MAY</b> be defined for schema and namespace declaration. See <see cref="Schema and Namespace Declaration Information">Schema and Namespace Declaration Information</see> for an <i>XML</i> example.
	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Structure__EAID_156BB3E5_EB08_4e64_A874_6DDFC07D68CC">model.mtconnect.org</seealso> for more information.
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.3.0.0")]
	public sealed class MTConnectStreamsClass : IClass
	{
		/// <inheritdoc />
		public string ReferenceId => "EAID_156BB3E5_EB08_4e64_A874_6DDFC07D68CC";
		
		/// <inheritdoc />
		public string Summary => @"/// root entity of an <i>MTConnectStreams Response Document</i> that contains the <i>Observation Information Model</i> of one or more <see cref=""Device"">Device</see> entities.  ![MTConnectStreams](figures/MTConnectStreams.png ""MTConnectStreams""){: width=""0.8""}  > Note: Additional properties of <see cref=""MTConnectStreams"">MTConnectStreams</see> <b>MAY</b> be defined for schema and namespace declaration. See <see cref=""Schema and Namespace Declaration Information"">Schema and Namespace Declaration Information</see> for an <i>XML</i> example.";

		/// <inheritdoc />
		public string Name => "MTConnectStreams";
		
		/// <inheritdoc />
		public string AccessModifier => "public";
				
		/// <inheritdoc />
		public string Modifier => "";
				
		/// <inheritdoc />
		public string NormativeVersion => "1.0";
				
		/// <inheritdoc />
		public string DeprecatedVersion => "";
		
		/// <inheritdoc />
		public Type Generalization => null;

		/// <inheritdoc />
		public MTConnectStreamsClassProperties Properties { get; } = new MTConnectStreamsClassProperties();
        IPropertyList IClass.Properties => Properties;
		public class MTConnectStreamsClassProperties : IPropertyList
		{
			/// <inheritdoc />
			public IProperty[] Properties => new IProperty[] {
				HasHeaderPart,
				HasDeviceStreamPart,
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
				/// <item>Original Type: EAID_2299B0B3_B209_47ae_B93A_BA694AD50051</item>
				/// <item>Type: HeaderClass</item>
				/// <item>Namespace: Mtconnect.Fundamentals.MTConnectProtocol.MTConnectStreamsResponseDocument</item>
				/// </list>
				/// </remarks>
				/// </summary>
				public System.Type Type => typeof(Mtconnect.Fundamentals.MTConnectProtocol.MTConnectStreamsResponseDocument.HeaderClass);
				
				/// <inheritdoc />
				public string Name => "hasHeader";
				
				/// <inheritdoc />
				public string Summary => @"/// root entity of an <i>MTConnectStreams Response Document</i> that contains the <i>Observation Information Model</i> of one or more <see cref=""Device"">Device</see> entities.  ![MTConnectStreams](figures/MTConnectStreams.png ""MTConnectStreams""){: width=""0.8""}  > Note: Additional properties of <see cref=""MTConnectStreams"">MTConnectStreams</see> <b>MAY</b> be defined for schema and namespace declaration. See <see cref=""Schema and Namespace Declaration Information"">Schema and Namespace Declaration Information</see> for an <i>XML</i> example.";

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
			/// <inheritdoc cref="HasDeviceStreamPartProperty" path="/summary" /><br/>
			/// <remarks>Original Name: HasDeviceStream</remarks>
			/// </summary>
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
				public string Name => "hasDeviceStream";
				
				/// <inheritdoc />
				public string Summary => @"/// root entity of an <i>MTConnectStreams Response Document</i> that contains the <i>Observation Information Model</i> of one or more <see cref=""Device"">Device</see> entities.  ![MTConnectStreams](figures/MTConnectStreams.png ""MTConnectStreams""){: width=""0.8""}  > Note: Additional properties of <see cref=""MTConnectStreams"">MTConnectStreams</see> <b>MAY</b> be defined for schema and namespace declaration. See <see cref=""Schema and Namespace Declaration Information"">Schema and Namespace Declaration Information</see> for an <i>XML</i> example.";

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
			}
		};

	}
}