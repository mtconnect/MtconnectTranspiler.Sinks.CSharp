#pragma warning disable CS0109 // Member does not hide an inherited member; new keyword is not required
#pragma warning disable CS1574 // XML comment has cref attribute that could not be resolved
#pragma warning disable CS1584 // XML comment has syntactically incorrect cref attribute
#pragma warning disable CS0618 // Type or member is obsolete
using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;

namespace Mtconnect.ObservationInformationModel
{
	/// <summary>﻿<i>organize</i>s data reported from a <see cref="Device">Device</see>.<br /><br /><br />Description<br /><br /><see cref="DeviceStream">DeviceStream</see> <b>MUST</b> be provided for each <see cref="Device">Device</see> reporting data in an <i>MTConnectStreams Response Document</i>.<br /><br />If the response to the request for data from an <i>agent</i> does not contain any data for a specific <see cref="Device">Device</see>, an empty <see cref="DeviceStream">DeviceStream</see> entity <b>MAY</b> be created to indicate that the <see cref="Device">Device</see> exists, but there was no data available.<br /><br /><br /><br /><br />
	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Structure__EAID_02192189_58E6_456c_A679_CDDFF559DA00">model.mtconnect.org</seealso> for more information.
	/// </summary>
	/// <remarks>
	/// <list type="bullet">
	/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
	/// </list>
	/// </remarks>

	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public sealed class DeviceStreamClass : IClass
	{
		/// <summary>Constant value for <see cref="DeviceStreamClass.ReferenceId" /></summary>
		public const string REFERENCE_ID = "EAID_02192189_58E6_456c_A679_CDDFF559DA00";
		/// <summary>Constant value for <see cref="DeviceStreamClass.HelpUrl" /></summary>
		public const string HELP_URL = "https://model.mtconnect.org/#Structure__EAID_02192189_58E6_456c_A679_CDDFF559DA00";
		/// <summary>Constant value for <see cref="DeviceStreamClass.Summary" /></summary>
		public const string SUMMARY = @"&#10;&#10;&#10;{{termplural(organize)}} data reported from a {{block(Device)}}.&#10;
&#10;&#10;&#10;Description&#10;&#10;&#10;&#10;{{block(DeviceStream)}} **MUST** be provided for each {{block(Device)}} reporting data in an {{term(MTConnectStreams Response Document)}}.

If the response to the request for data from an {{term(agent)}} does not contain any data for a specific {{block(Device)}}, an empty {{block(DeviceStream)}} entity **MAY** be created to indicate that the {{block(Device)}} exists, but there was no data available.&#10;
";
		/// <summary>Constant value for <see cref="DeviceStreamClass.Name" /></summary>
		public const string NAME = "DeviceStream";
		/// <summary>Constant value for <see cref="DeviceStreamClass.AccessModifier" /></summary>
		public const string ACCESS_MODIFIER = "public";
		/// <summary>Constant value for <see cref="DeviceStreamClass.Modifier" /></summary>
		public const string MODIFIER = "";
		/// <summary>Constant value for <see cref="DeviceStreamClass.NormativeVersion" /></summary>
		public const string NORMATIVE_VERSION = "1.0";
		/// <summary>Constant value for <see cref="DeviceStreamClass.DeprecatedVersion" /></summary>
		public const string DEPRECATED_VERSION = "";

		/// <inheritdoc />
		public string ReferenceId => REFERENCE_ID;
		
		/// <inheritdoc />
		public string HelpUrl => HELP_URL;

		/// <inheritdoc />
		public string Summary => SUMMARY;

		/// <inheritdoc />
		public string Name => NAME;
		
		/// <inheritdoc />
		public string AccessModifier => ACCESS_MODIFIER;
				
		/// <inheritdoc />
		public string Modifier => MODIFIER;
				
		/// <inheritdoc />
		public string NormativeVersion => NORMATIVE_VERSION;
				
		/// <inheritdoc />
		public string DeprecatedVersion => DEPRECATED_VERSION;
		
		/// <inheritdoc />
		public Type Generalization => null;

		/// <inheritdoc />
		public new DeviceStreamClassProperties Properties { get; } = new DeviceStreamClassProperties();
        IPropertyList IClass.Properties => Properties;
		/// <summary>
		/// Property list for <see cref="DeviceStreamClass" />.
		/// </summary>
		public class DeviceStreamClassProperties : IPropertyList
		{
			/// <inheritdoc />
			public virtual IProperty[] Properties => new IProperty[] {
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
				/// <summary>Constant value for <see cref="NameProperty.Name" /></summary>
				public const string NAME = "name";
				/// <summary>Constant value for <see cref="NameProperty.Summary" /></summary>
				public const string SUMMARY = @"&#10;&#10;&#10;name of the {{block(Device)}}.

The value reported for {{property(DeviceStream::name)}} **MUST** be the same as the value defined for the {{property(Device::name)}} in the {{term(MTConnectDevices Response Document)}}.&#10;
";
				/// <summary>Constant value for <see cref="NameProperty.AccessModifier" /></summary>
				public const string ACCESS_MODIFIER = "public";
				/// <summary>Constant value for <see cref="NameProperty.Modifier" /></summary>
				public const string MODIFIER = "";
				/// <summary>Constant value for <see cref="NameProperty.NormativeVersion" /></summary>
				public const string NORMATIVE_VERSION = "1.0";
				/// <summary>Constant value for <see cref="NameProperty.DeprecatedVersion" /></summary>
				public const string DEPRECATED_VERSION = "";
				/// <summary>Constant value for <see cref="NameProperty.Aggregation" /></summary>
				public const string AGGREGATION = "";
				/// <summary>Constant value for <see cref="NameProperty.Extension" /></summary>
				public const string EXTENSION = "MagicDraw UML 2024x";
				/// <summary>Constant value for <see cref="NameProperty.Association" /></summary>
				public const string ASSOCIATION = "";
				/// <summary>Constant value for <see cref="NameProperty.DefaultValue" /></summary>
				public const string DEFAULT_VALUE = "";

				/// <summary>
				/// <inheritdoc />
				/// <remarks> Type: String </remarks>
				/// </summary>
				public System.Type Type => typeof(String);
				
				/// <inheritdoc />
				public string Name => NAME;
				
				/// <inheritdoc />
				public string Summary => SUMMARY;

				/// <inheritdoc />
				public string AccessModifier => ACCESS_MODIFIER;
				
				/// <inheritdoc />
				public string Modifier => MODIFIER;
				
				/// <inheritdoc />
				public string NormativeVersion => NORMATIVE_VERSION;
				
				/// <inheritdoc />
				public string DeprecatedVersion => DEPRECATED_VERSION;
				
				/// <inheritdoc />
				public string Aggregation => AGGREGATION;

				// Note: Extension.Extender
				/// <inheritdoc />
				public string Extension => EXTENSION;
				
				/// <inheritdoc />
				public string Association => ASSOCIATION;

				// Note: DefaultValue.Name
				/// <inheritdoc />
				public string DefaultValue => DEFAULT_VALUE;
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
				/// <summary>Constant value for <see cref="UuidProperty.Name" /></summary>
				public const string NAME = "uuid";
				/// <summary>Constant value for <see cref="UuidProperty.Summary" /></summary>
				public const string SUMMARY = @"&#10;&#10;&#10;uuid of the {{block(Device)}}.  The value reported for {{property(DeviceStream::uuid)}} **MUST** be the same as the value defined for the {{property(Device::uuid)}} of the same {{block(Device)}} in the {{term(MTConnectDevices Response Document)}}.&#10;
";
				/// <summary>Constant value for <see cref="UuidProperty.AccessModifier" /></summary>
				public const string ACCESS_MODIFIER = "public";
				/// <summary>Constant value for <see cref="UuidProperty.Modifier" /></summary>
				public const string MODIFIER = "";
				/// <summary>Constant value for <see cref="UuidProperty.NormativeVersion" /></summary>
				public const string NORMATIVE_VERSION = "1.0";
				/// <summary>Constant value for <see cref="UuidProperty.DeprecatedVersion" /></summary>
				public const string DEPRECATED_VERSION = "";
				/// <summary>Constant value for <see cref="UuidProperty.Aggregation" /></summary>
				public const string AGGREGATION = "";
				/// <summary>Constant value for <see cref="UuidProperty.Extension" /></summary>
				public const string EXTENSION = "MagicDraw UML 2024x";
				/// <summary>Constant value for <see cref="UuidProperty.Association" /></summary>
				public const string ASSOCIATION = "";
				/// <summary>Constant value for <see cref="UuidProperty.DefaultValue" /></summary>
				public const string DEFAULT_VALUE = "";

				/// <summary>
				/// <inheritdoc />
				/// <remarks> Type: Object </remarks>
				/// </summary>
				public System.Type Type => typeof(object);
				
				/// <inheritdoc />
				public string Name => NAME;
				
				/// <inheritdoc />
				public string Summary => SUMMARY;

				/// <inheritdoc />
				public string AccessModifier => ACCESS_MODIFIER;
				
				/// <inheritdoc />
				public string Modifier => MODIFIER;
				
				/// <inheritdoc />
				public string NormativeVersion => NORMATIVE_VERSION;
				
				/// <inheritdoc />
				public string DeprecatedVersion => DEPRECATED_VERSION;
				
				/// <inheritdoc />
				public string Aggregation => AGGREGATION;

				// Note: Extension.Extender
				/// <inheritdoc />
				public string Extension => EXTENSION;
				
				/// <inheritdoc />
				public string Association => ASSOCIATION;

				// Note: DefaultValue.Name
				/// <inheritdoc />
				public string DefaultValue => DEFAULT_VALUE;
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
				/// <summary>Constant value for <see cref="HasComponentStreamPartProperty.Name" /></summary>
				public const string NAME = "hasComponentStream";
				/// <summary>Constant value for <see cref="HasComponentStreamPartProperty.Summary" /></summary>
				public const string SUMMARY = @"";
				/// <summary>Constant value for <see cref="HasComponentStreamPartProperty.AccessModifier" /></summary>
				public const string ACCESS_MODIFIER = "public";
				/// <summary>Constant value for <see cref="HasComponentStreamPartProperty.Modifier" /></summary>
				public const string MODIFIER = "";
				/// <summary>Constant value for <see cref="HasComponentStreamPartProperty.NormativeVersion" /></summary>
				public const string NORMATIVE_VERSION = "";
				/// <summary>Constant value for <see cref="HasComponentStreamPartProperty.DeprecatedVersion" /></summary>
				public const string DEPRECATED_VERSION = "";
				/// <summary>Constant value for <see cref="HasComponentStreamPartProperty.Aggregation" /></summary>
				public const string AGGREGATION = "composite";
				/// <summary>Constant value for <see cref="HasComponentStreamPartProperty.Extension" /></summary>
				public const string EXTENSION = "MagicDraw UML 2024x";
				/// <summary>Constant value for <see cref="HasComponentStreamPartProperty.Association" /></summary>
				public const string ASSOCIATION = "ComponentStream";
				/// <summary>Constant value for <see cref="HasComponentStreamPartProperty.DefaultValue" /></summary>
				public const string DEFAULT_VALUE = "";

				/// <summary>
				/// <inheritdoc />
				/// <remarks> Type: ComponentStreamClass </remarks>
				/// </summary>
				public System.Type Type => typeof(Mtconnect.ObservationInformationModel.ComponentStreamClass);
				
				/// <inheritdoc />
				public string Name => NAME;
				
				/// <inheritdoc />
				public string Summary => SUMMARY;

				/// <inheritdoc />
				public string AccessModifier => ACCESS_MODIFIER;
				
				/// <inheritdoc />
				public string Modifier => MODIFIER;
				
				/// <inheritdoc />
				public string NormativeVersion => NORMATIVE_VERSION;
				
				/// <inheritdoc />
				public string DeprecatedVersion => DEPRECATED_VERSION;
				
				/// <inheritdoc />
				public string Aggregation => AGGREGATION;

				// Note: Extension.Extender
				/// <inheritdoc />
				public string Extension => EXTENSION;
				
				/// <inheritdoc />
				public string Association => ASSOCIATION;

				// Note: DefaultValue.Name
				/// <inheritdoc />
				public string DefaultValue => DEFAULT_VALUE;
			}
		};

	}
}