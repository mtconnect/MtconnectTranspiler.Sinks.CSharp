#pragma warning disable CS0109 // Member does not hide an inherited member; new keyword is not required
#pragma warning disable CS1574 // XML comment has cref attribute that could not be resolved
#pragma warning disable CS1584 // XML comment has syntactically incorrect cref attribute
#pragma warning disable CS0618 // Type or member is obsolete
using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;

namespace Mtconnect.Fundamentals.MTConnectProtocol.MTConnectStreamsResponseDocument
{
	/// <summary>﻿root entity of an <i>MTConnectStreams Response Document</i> that contains the <i>Observation Information Model</i> of one or more <see cref="Device">Device</see> entities.<br /><br />![MTConnectStreams](figures/MTConnectStreams.png "MTConnectStreams"){: width="0.8"}<br /><br />&gt; Note: Additional properties of <see cref="MTConnectStreams">MTConnectStreams</see> <b>MAY</b> be defined for schema and namespace declaration. See <see cref="Schema and Namespace Declaration Information">Schema and Namespace Declaration Information</see> for an <i>XML</i> example.<br /><br /><br />
	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Structure__EAID_156BB3E5_EB08_4e64_A874_6DDFC07D68CC">model.mtconnect.org</seealso> for more information.
	/// </summary>
	/// <remarks>
	/// <list type="bullet">
	/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
	/// </list>
	/// </remarks>

	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public sealed class MTConnectStreamsClass : IClass
	{
		/// <summary>Constant value for <see cref="MTConnectStreamsClass.ReferenceId" /></summary>
		public const string REFERENCE_ID = "EAID_156BB3E5_EB08_4e64_A874_6DDFC07D68CC";
		/// <summary>Constant value for <see cref="MTConnectStreamsClass.HelpUrl" /></summary>
		public const string HELP_URL = "https://model.mtconnect.org/#Structure__EAID_156BB3E5_EB08_4e64_A874_6DDFC07D68CC";
		/// <summary>Constant value for <see cref="MTConnectStreamsClass.Summary" /></summary>
		public const string SUMMARY = @"&#10;&#10;&#10;root entity of an {{term(MTConnectStreams Response Document)}} that contains the {{term(Observation Information Model)}} of one or more {{block(Device)}} entities.

![MTConnectStreams](figures/MTConnectStreams.png ""MTConnectStreams""){: width=""0.8""}

> Note: Additional properties of {{block(MTConnectStreams)}} **MAY** be defined for schema and namespace declaration. See {{sect(Schema and Namespace Declaration Information)}} for an {{term(XML)}} example.&#10;
";
		/// <summary>Constant value for <see cref="MTConnectStreamsClass.Name" /></summary>
		public const string NAME = "MTConnectStreams";
		/// <summary>Constant value for <see cref="MTConnectStreamsClass.AccessModifier" /></summary>
		public const string ACCESS_MODIFIER = "public";
		/// <summary>Constant value for <see cref="MTConnectStreamsClass.Modifier" /></summary>
		public const string MODIFIER = "";
		/// <summary>Constant value for <see cref="MTConnectStreamsClass.NormativeVersion" /></summary>
		public const string NORMATIVE_VERSION = "1.0";
		/// <summary>Constant value for <see cref="MTConnectStreamsClass.DeprecatedVersion" /></summary>
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
		public new MTConnectStreamsClassProperties Properties { get; } = new MTConnectStreamsClassProperties();
        IPropertyList IClass.Properties => Properties;
		/// <summary>
		/// Property list for <see cref="MTConnectStreamsClass" />.
		/// </summary>
		public class MTConnectStreamsClassProperties : IPropertyList
		{
			/// <inheritdoc />
			public virtual IProperty[] Properties => new IProperty[] {
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
				/// <summary>Constant value for <see cref="HasHeaderPartProperty.Name" /></summary>
				public const string NAME = "hasHeader";
				/// <summary>Constant value for <see cref="HasHeaderPartProperty.Summary" /></summary>
				public const string SUMMARY = @"";
				/// <summary>Constant value for <see cref="HasHeaderPartProperty.AccessModifier" /></summary>
				public const string ACCESS_MODIFIER = "public";
				/// <summary>Constant value for <see cref="HasHeaderPartProperty.Modifier" /></summary>
				public const string MODIFIER = "";
				/// <summary>Constant value for <see cref="HasHeaderPartProperty.NormativeVersion" /></summary>
				public const string NORMATIVE_VERSION = "";
				/// <summary>Constant value for <see cref="HasHeaderPartProperty.DeprecatedVersion" /></summary>
				public const string DEPRECATED_VERSION = "";
				/// <summary>Constant value for <see cref="HasHeaderPartProperty.Aggregation" /></summary>
				public const string AGGREGATION = "";
				/// <summary>Constant value for <see cref="HasHeaderPartProperty.Extension" /></summary>
				public const string EXTENSION = "MagicDraw UML 2024x";
				/// <summary>Constant value for <see cref="HasHeaderPartProperty.Association" /></summary>
				public const string ASSOCIATION = "Header";
				/// <summary>Constant value for <see cref="HasHeaderPartProperty.DefaultValue" /></summary>
				public const string DEFAULT_VALUE = "";

				/// <summary>
				/// <inheritdoc />
				/// <remarks> Type: HeaderClass </remarks>
				/// </summary>
				public System.Type Type => typeof(Mtconnect.Fundamentals.MTConnectProtocol.MTConnectStreamsResponseDocument.HeaderClass);
				
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
			/// <inheritdoc cref="HasDeviceStreamPartProperty" path="/summary" /><br/>
			/// <remarks>Original Name: HasDeviceStream</remarks>
			/// </summary>
			public HasDeviceStreamPartProperty HasDeviceStreamPart { get; } = new HasDeviceStreamPartProperty();
			
			/// <summary>﻿
			/// </summary>
			public sealed class HasDeviceStreamPartProperty : IProperty
			{
				/// <summary>Constant value for <see cref="HasDeviceStreamPartProperty.Name" /></summary>
				public const string NAME = "hasDeviceStream";
				/// <summary>Constant value for <see cref="HasDeviceStreamPartProperty.Summary" /></summary>
				public const string SUMMARY = @"";
				/// <summary>Constant value for <see cref="HasDeviceStreamPartProperty.AccessModifier" /></summary>
				public const string ACCESS_MODIFIER = "public";
				/// <summary>Constant value for <see cref="HasDeviceStreamPartProperty.Modifier" /></summary>
				public const string MODIFIER = "";
				/// <summary>Constant value for <see cref="HasDeviceStreamPartProperty.NormativeVersion" /></summary>
				public const string NORMATIVE_VERSION = "";
				/// <summary>Constant value for <see cref="HasDeviceStreamPartProperty.DeprecatedVersion" /></summary>
				public const string DEPRECATED_VERSION = "";
				/// <summary>Constant value for <see cref="HasDeviceStreamPartProperty.Aggregation" /></summary>
				public const string AGGREGATION = "composite";
				/// <summary>Constant value for <see cref="HasDeviceStreamPartProperty.Extension" /></summary>
				public const string EXTENSION = "";
				/// <summary>Constant value for <see cref="HasDeviceStreamPartProperty.Association" /></summary>
				public const string ASSOCIATION = "Streams";
				/// <summary>Constant value for <see cref="HasDeviceStreamPartProperty.DefaultValue" /></summary>
				public const string DEFAULT_VALUE = "";

				/// <summary>
				/// <inheritdoc />
				/// <remarks> Type: DeviceStreamClass </remarks>
				/// </summary>
				public System.Type Type => typeof(Mtconnect.ObservationInformationModel.DeviceStreamClass);
				
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