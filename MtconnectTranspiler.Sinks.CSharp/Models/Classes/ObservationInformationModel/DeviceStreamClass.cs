#pragma warning disable CS0109 // Member does not hide an inherited member; new keyword is not required
#pragma warning disable CS1574 // XML comment has cref attribute that could not be resolved
#pragma warning disable CS1584 // XML comment has syntactically incorrect cref attribute
using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;

namespace Mtconnect.ObservationInformationModel
{
	/// <summary>﻿<i>organize</i>s data reported from a <see cref="Device">Device</see>.<br /><br /><br />Description<br /><br /><see cref="DeviceStream">DeviceStream</see> <b>MUST</b> be provided for each <see cref="Device">Device</see> reporting data in an <i>MTConnectStreams Response Document</i>.<br /><br />If the response to the request for data from an <i>agent</i> does not contain any data for a specific <see cref="Device">Device</see>, an empty <see cref="DeviceStream">DeviceStream</see> entity <b>MAY</b> be created to indicate that the <see cref="Device">Device</see> exists, but there was no data available.<br /><br /><br /><br /><br />
	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Structure__EAID_02192189_58E6_456c_A679_CDDFF559DA00">model.mtconnect.org</seealso> for more information.
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public sealed class DeviceStreamClass : IClass
	{
		/// <inheritdoc />
		public string ReferenceId => "EAID_02192189_58E6_456c_A679_CDDFF559DA00";
		
		/// <inheritdoc />
		public string Summary => @"&#10;&#10;&#10;{{termplural(organize)}} data reported from a {{block(Device)}}.&#10;
&#10;&#10;&#10;Description&#10;&#10;&#10;&#10;{{block(DeviceStream)}} **MUST** be provided for each {{block(Device)}} reporting data in an {{term(MTConnectStreams Response Document)}}.

If the response to the request for data from an {{term(agent)}} does not contain any data for a specific {{block(Device)}}, an empty {{block(DeviceStream)}} entity **MAY** be created to indicate that the {{block(Device)}} exists, but there was no data available.&#10;
";

		/// <inheritdoc />
		public string Name => "DeviceStream";
		
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
		public DeviceStreamClassProperties Properties { get; } = new DeviceStreamClassProperties();
        IPropertyList IClass.Properties => Properties;
		/// <summary>
		/// Property list for <see cref="DeviceStreamClass" />.
		/// </summary>
		public class DeviceStreamClassProperties : IPropertyList
		{
			/// <inheritdoc />
			public IProperty[] Properties => new IProperty[] {
				Name,
				Uuid,
				HasComponentStreamPart,
			};
			/// <summary>
			/// <inheritdoc cref="NameProperty" path="/summary" /><br/>
			/// <remarks>Original Name: Name</remarks>
			/// </summary>
			public NameProperty Name { get; } = new NameProperty();
			
			/// <summary>﻿name of the <see cref="Device">Device</see>.<br /><br />The value reported for <see cref="DeviceStream.name">name in DeviceStream</see> <b>MUST</b> be the same as the value defined for the <see cref="Device.name">name in Device</see> in the <i>MTConnectDevices Response Document</i>.<br /><br /><br />
			/// </summary>
			public sealed class NameProperty : IProperty
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
				public string Name => "name";
				
				/// <inheritdoc />
				public string Summary => @"&#10;&#10;&#10;name of the {{block(Device)}}.

The value reported for {{property(DeviceStream::name)}} **MUST** be the same as the value defined for the {{property(Device::name)}} in the {{term(MTConnectDevices Response Document)}}.&#10;
";

				/// <inheritdoc />
				public string AccessModifier => "public";
				
				/// <inheritdoc />
				public string Modifier => "";
				
				/// <inheritdoc />
				public string NormativeVersion => "1.0";
				
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
			/// <inheritdoc cref="UuidProperty" path="/summary" /><br/>
			/// <remarks>Original Name: Uuid</remarks>
			/// </summary>
			public UuidProperty Uuid { get; } = new UuidProperty();
			
			/// <summary>﻿uuid of the <see cref="Device">Device</see>.  The value reported for <see cref="DeviceStream.uuid">uuid in DeviceStream</see> <b>MUST</b> be the same as the value defined for the <see cref="Device.uuid">uuid in Device</see> of the same <see cref="Device">Device</see> in the <i>MTConnectDevices Response Document</i>.<br /><br /><br />
			/// </summary>
			public sealed class UuidProperty : IProperty
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
				public string Name => "uuid";
				
				/// <inheritdoc />
				public string Summary => @"&#10;&#10;&#10;uuid of the {{block(Device)}}.  The value reported for {{property(DeviceStream::uuid)}} **MUST** be the same as the value defined for the {{property(Device::uuid)}} of the same {{block(Device)}} in the {{term(MTConnectDevices Response Document)}}.&#10;
";

				/// <inheritdoc />
				public string AccessModifier => "public";
				
				/// <inheritdoc />
				public string Modifier => "";
				
				/// <inheritdoc />
				public string NormativeVersion => "1.0";
				
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
			/// <inheritdoc cref="HasComponentStreamPartProperty" path="/summary" /><br/>
			/// <remarks>Original Name: HasComponentStream</remarks>
			/// </summary>
			public HasComponentStreamPartProperty HasComponentStreamPart { get; } = new HasComponentStreamPartProperty();
			
			/// <summary>﻿
			/// </summary>
			public sealed class HasComponentStreamPartProperty : IProperty
			{
				/// <summary>
				/// <inheritdoc />
				/// <remarks>
				/// <list type="bullet">
				/// <item>Original Type: EAID_9057AAF9_4687_42be_BD2B_E2F18DF049DC</item>
				/// <item>Type: ComponentStreamClass</item>
				/// <item>Namespace: Mtconnect.ObservationInformationModel</item>
				/// </list>
				/// </remarks>
				/// </summary>
				public System.Type Type => typeof(Mtconnect.ObservationInformationModel.ComponentStreamClass);
				
				/// <inheritdoc />
				public string Name => "hasComponentStream";
				
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
				public string Extension => "MagicDraw UML 19.0";
				
				/// <inheritdoc />
				public string Association => "ComponentStream";

				// Note: DefaultValue.Name
				/// <inheritdoc />
				public string DefaultValue => "";
			}
		};

	}
}