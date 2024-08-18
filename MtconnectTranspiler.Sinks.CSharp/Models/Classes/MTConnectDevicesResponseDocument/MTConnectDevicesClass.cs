#pragma warning disable CS0109 // Member does not hide an inherited member; new keyword is not required
#pragma warning disable CS1574 // XML comment has cref attribute that could not be resolved
#pragma warning disable CS1584 // XML comment has syntactically incorrect cref attribute
using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;

namespace Mtconnect.Fundamentals.MTConnectProtocol.MTConnectDevicesResponseDocument
{
	/// <summary>﻿root entity of an <i>MTConnectDevices Response Document</i> that contains the <i>Device Information Model</i> of one or more <see cref="Device">Device</see> entities.<br /><br />![MTConnectDevices](figures/MTConnectDevices.png "MTConnectDevices"){: width="0.8"}<br /><br />&gt; Note: Additional properties of <see cref="MTConnectDevices">MTConnectDevices</see> <b>MAY</b> be defined for schema and namespace declaration. See <see cref="Schema and Namespace Declaration Information">Schema and Namespace Declaration Information</see> for an <i>XML</i> example.<br /><br /><br />
	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Structure__EAID_76BFE349_267B_45b3_B5FF_3C89D29AE715">model.mtconnect.org</seealso> for more information.
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public sealed class MTConnectDevicesClass : IClass
	{
		/// <inheritdoc />
		public string ReferenceId => "EAID_76BFE349_267B_45b3_B5FF_3C89D29AE715";
		
		/// <inheritdoc />
		public string Summary => @"&#10;&#10;&#10;root entity of an {{term(MTConnectDevices Response Document)}} that contains the {{term(Device Information Model)}} of one or more {{block(Device)}} entities.

![MTConnectDevices](figures/MTConnectDevices.png ""MTConnectDevices""){: width=""0.8""}

> Note: Additional properties of {{block(MTConnectDevices)}} **MAY** be defined for schema and namespace declaration. See {{sect(Schema and Namespace Declaration Information)}} for an {{term(XML)}} example.&#10;
";

		/// <inheritdoc />
		public string Name => "MTConnectDevices";
		
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
		public new MTConnectDevicesClassProperties Properties { get; } = new MTConnectDevicesClassProperties();
        IPropertyList IClass.Properties => Properties;
		/// <summary>
		/// Property list for <see cref="MTConnectDevicesClass" />.
		/// </summary>
		public class MTConnectDevicesClassProperties : IPropertyList
		{
			/// <inheritdoc />
			public IProperty[] Properties => new IProperty[] {
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
				/// <summary>
				/// <inheritdoc />
				/// <remarks>
				/// <list type="bullet">
				/// <item>Original Type: EAID_08B1605D_39B4_4475_A436_A457B1D646A2</item>
				/// <item>Type: HeaderClass</item>
				/// <item>Namespace: Mtconnect.Fundamentals.MTConnectProtocol.MTConnectDevicesResponseDocument</item>
				/// </list>
				/// </remarks>
				/// </summary>
				public System.Type Type => typeof(Mtconnect.Fundamentals.MTConnectProtocol.MTConnectDevicesResponseDocument.HeaderClass);
				
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
				public string Aggregation => "composite";

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
			/// <inheritdoc cref="HasDevicePartProperty" path="/summary" /><br/>
			/// <remarks>Original Name: HasDevice</remarks>
			/// </summary>
			public HasDevicePartProperty HasDevicePart { get; } = new HasDevicePartProperty();
			
			/// <summary>﻿
			/// </summary>
			public sealed class HasDevicePartProperty : IProperty
			{
				/// <summary>
				/// <inheritdoc />
				/// <remarks>
				/// <list type="bullet">
				/// <item>Original Type: _19_0_3_68e0225_1620240839406_285612_1596</item>
				/// <item>Type: DeviceClass</item>
				/// <item>Namespace: Mtconnect.DeviceInformationModel</item>
				/// </list>
				/// </remarks>
				/// </summary>
				public System.Type Type => typeof(Mtconnect.DeviceInformationModel.DeviceClass);
				
				/// <inheritdoc />
				public string Name => "hasDevice";
				
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
				public string Association => "Devices";

				// Note: DefaultValue.Name
				/// <inheritdoc />
				public string DefaultValue => "";
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