#pragma warning disable CS0109 // Member does not hide an inherited member; new keyword is not required
#pragma warning disable CS1574 // XML comment has cref attribute that could not be resolved
#pragma warning disable CS1584 // XML comment has syntactically incorrect cref attribute
using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;

namespace Mtconnect.Fundamentals.MTConnectProtocol.MTConnectStreamsResponseDocument
{
	/// <summary>﻿root entity of an <i>MTConnectStreams Response Document</i> that contains the <i>Observation Information Model</i> of one or more <see cref="Device">Device</see> entities.<br /><br />![MTConnectStreams](figures/MTConnectStreams.png "MTConnectStreams"){: width="0.8"}<br /><br />&gt; Note: Additional properties of <see cref="MTConnectStreams">MTConnectStreams</see> <b>MAY</b> be defined for schema and namespace declaration. See <see cref="Schema and Namespace Declaration Information">Schema and Namespace Declaration Information</see> for an <i>XML</i> example.<br /><br /><br />
	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Structure__EAID_156BB3E5_EB08_4e64_A874_6DDFC07D68CC">model.mtconnect.org</seealso> for more information.
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public sealed class MTConnectStreamsClass : IClass
	{
		/// <inheritdoc />
		public string ReferenceId => "EAID_156BB3E5_EB08_4e64_A874_6DDFC07D68CC";
		
		/// <inheritdoc />
		public string Summary => @"&#10;&#10;&#10;root entity of an {{term(MTConnectStreams Response Document)}} that contains the {{term(Observation Information Model)}} of one or more {{block(Device)}} entities.

![MTConnectStreams](figures/MTConnectStreams.png ""MTConnectStreams""){: width=""0.8""}

> Note: Additional properties of {{block(MTConnectStreams)}} **MAY** be defined for schema and namespace declaration. See {{sect(Schema and Namespace Declaration Information)}} for an {{term(XML)}} example.&#10;
";

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
		public new MTConnectStreamsClassProperties Properties { get; } = new MTConnectStreamsClassProperties();
        IPropertyList IClass.Properties => Properties;
		/// <summary>
		/// Property list for <see cref="MTConnectStreamsClass" />.
		/// </summary>
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
			
			/// <summary>﻿
			/// </summary>
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
				public string Summary => @"";

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
			
			/// <summary>﻿
			/// </summary>
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
				public string Summary => @"";

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