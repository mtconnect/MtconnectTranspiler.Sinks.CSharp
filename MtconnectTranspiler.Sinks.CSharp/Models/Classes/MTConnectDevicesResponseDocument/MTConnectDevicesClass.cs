#pragma warning disable CS0109 // Member does not hide an inherited member; new keyword is not required
#pragma warning disable CS1574 // XML comment has cref attribute that could not be resolved
#pragma warning disable CS1584 // XML comment has syntactically incorrect cref attribute
#pragma warning disable CS0618 // Type or member is obsolete
using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;

namespace Mtconnect.Fundamentals.MTConnectProtocol.MTConnectDevicesResponseDocument
{
	/// <summary>﻿root entity of an <i>MTConnectDevices Response Document</i> that contains the <i>Device Information Model</i> of one or more <see cref="Device">Device</see> entities.<br /><br />![MTConnectDevices](figures/MTConnectDevices.png "MTConnectDevices"){: width="0.8"}<br /><br />&gt; Note: Additional properties of <see cref="MTConnectDevices">MTConnectDevices</see> <b>MAY</b> be defined for schema and namespace declaration. See <see cref="Schema and Namespace Declaration Information">Schema and Namespace Declaration Information</see> for an <i>XML</i> example.<br /><br /><br />
	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Structure__EAID_76BFE349_267B_45b3_B5FF_3C89D29AE715">model.mtconnect.org</seealso> for more information.
	/// </summary>
	/// <remarks>
	/// <list type="bullet">
	/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
	/// </list>
	/// </remarks>

	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public sealed class MTConnectDevicesClass : IClass
	{
		/// <summary>Constant value for <see cref="MTConnectDevicesClass.ReferenceId" /></summary>
		public const string REFERENCE_ID = "EAID_76BFE349_267B_45b3_B5FF_3C89D29AE715";
		/// <summary>Constant value for <see cref="MTConnectDevicesClass.HelpUrl" /></summary>
		public const string HELP_URL = "https://model.mtconnect.org/#Structure__EAID_76BFE349_267B_45b3_B5FF_3C89D29AE715";
		/// <summary>Constant value for <see cref="MTConnectDevicesClass.Summary" /></summary>
		public const string SUMMARY = @"&#10;&#10;&#10;root entity of an {{term(MTConnectDevices Response Document)}} that contains the {{term(Device Information Model)}} of one or more {{block(Device)}} entities.

![MTConnectDevices](figures/MTConnectDevices.png ""MTConnectDevices""){: width=""0.8""}

> Note: Additional properties of {{block(MTConnectDevices)}} **MAY** be defined for schema and namespace declaration. See {{sect(Schema and Namespace Declaration Information)}} for an {{term(XML)}} example.&#10;
";
		/// <summary>Constant value for <see cref="MTConnectDevicesClass.Name" /></summary>
		public const string NAME = "MTConnectDevices";
		/// <summary>Constant value for <see cref="MTConnectDevicesClass.AccessModifier" /></summary>
		public const string ACCESS_MODIFIER = "public";
		/// <summary>Constant value for <see cref="MTConnectDevicesClass.Modifier" /></summary>
		public const string MODIFIER = "";
		/// <summary>Constant value for <see cref="MTConnectDevicesClass.NormativeVersion" /></summary>
		public const string NORMATIVE_VERSION = "1.0";
		/// <summary>Constant value for <see cref="MTConnectDevicesClass.DeprecatedVersion" /></summary>
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
		public new MTConnectDevicesClassProperties Properties { get; } = new MTConnectDevicesClassProperties();
        IPropertyList IClass.Properties => Properties;
		/// <summary>
		/// Property list for <see cref="MTConnectDevicesClass" />.
		/// </summary>
		public class MTConnectDevicesClassProperties : IPropertyList
		{
			/// <inheritdoc />
			public virtual IProperty[] Properties => new IProperty[] {
				HasHeaderPart,
				HasDevicePart,
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
				public const string AGGREGATION = "composite";
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
				public System.Type Type => typeof(Mtconnect.Fundamentals.MTConnectProtocol.MTConnectDevicesResponseDocument.HeaderClass);
				
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
			/// <inheritdoc cref="HasDevicePartProperty" path="/summary" /><br/>
			/// <remarks>Original Name: HasDevice</remarks>
			/// </summary>
			public HasDevicePartProperty HasDevicePart { get; } = new HasDevicePartProperty();
			
			/// <summary>﻿
			/// </summary>
			public sealed class HasDevicePartProperty : IProperty
			{
				/// <summary>Constant value for <see cref="HasDevicePartProperty.Name" /></summary>
				public const string NAME = "hasDevice";
				/// <summary>Constant value for <see cref="HasDevicePartProperty.Summary" /></summary>
				public const string SUMMARY = @"";
				/// <summary>Constant value for <see cref="HasDevicePartProperty.AccessModifier" /></summary>
				public const string ACCESS_MODIFIER = "public";
				/// <summary>Constant value for <see cref="HasDevicePartProperty.Modifier" /></summary>
				public const string MODIFIER = "";
				/// <summary>Constant value for <see cref="HasDevicePartProperty.NormativeVersion" /></summary>
				public const string NORMATIVE_VERSION = "";
				/// <summary>Constant value for <see cref="HasDevicePartProperty.DeprecatedVersion" /></summary>
				public const string DEPRECATED_VERSION = "";
				/// <summary>Constant value for <see cref="HasDevicePartProperty.Aggregation" /></summary>
				public const string AGGREGATION = "composite";
				/// <summary>Constant value for <see cref="HasDevicePartProperty.Extension" /></summary>
				public const string EXTENSION = "MagicDraw UML 2024x";
				/// <summary>Constant value for <see cref="HasDevicePartProperty.Association" /></summary>
				public const string ASSOCIATION = "Devices";
				/// <summary>Constant value for <see cref="HasDevicePartProperty.DefaultValue" /></summary>
				public const string DEFAULT_VALUE = "";

				/// <summary>
				/// <inheritdoc />
				/// <remarks> Type: DeviceClass </remarks>
				/// </summary>
				public System.Type Type => typeof(Mtconnect.DeviceInformationModel.DeviceClass);
				
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

		# region Rules
		/// <summary>
		/// MtconnectDevices1
		/// </summary>
		/// <remarks>Specification Language: <c>Unspecified</c></remarks>
		public string MtconnectDevices1 => @"Components::Component::allInstances()->forAll(comp1, comp2 | comp1 <> comp2 implies comp1.id <> comp2.id and comp1.name <> comp2.name)  and 
DataItems::DataItem::allInstances()->forAll(di1, di2 | di1 <> di2 implies di1.id <> di2.id and di1.name <> di2.name) and
Components::Devices::Device::allInstances()->forAll(d1, d2 | d1 <> d2 implies d1.id <> d2.id and d1.name <> d2.name) and 
Compositions::Composition::allInstances()->forAll(compn1, compn2 | compn1 <> compn2 implies compn1.id <> compn2.id and compn1.name <> compn2.name)
 ";
		/*
		Components::Component::allInstances()->forAll(comp1, comp2 | comp1 <> comp2 implies comp1.id <> comp2.id and comp1.name <> comp2.name)  and 
		DataItems::DataItem::allInstances()->forAll(di1, di2 | di1 <> di2 implies di1.id <> di2.id and di1.name <> di2.name) and
		Components::Devices::Device::allInstances()->forAll(d1, d2 | d1 <> d2 implies d1.id <> d2.id and d1.name <> d2.name) and 
		Compositions::Composition::allInstances()->forAll(compn1, compn2 | compn1 <> compn2 implies compn1.id <> compn2.id and compn1.name <> compn2.name)
		 
		*/
		# endregion
	}
}