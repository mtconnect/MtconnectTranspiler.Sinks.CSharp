using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;
using Package = Mtconnect.DeviceInformationModel.DataItems;

namespace Mtconnect.DeviceInformationModel
{
	/// <summary>
	﻿/// This section provides semantic information for the <see cref="DataItem">DataItem</see> entity. {{figure(DataItems)}} shows the <see cref="DataItem">DataItem</see> model. <br /><br />![DataItems](figures/DataItems.png "DataItems"){: width="0.8"}<br /><br />> Note: See <see cref="DataItems Schema Diagrams">DataItems Schema Diagrams</see> for XML schema.<br/><br />DataItems Model<br/>For an <see cref="MTConnectDevices">MTConnectDevices</see> entity, <i>DataItem</i>s describe data that can be reported by a piece of equipment and are associated with <see cref="Device">Device</see> and <see cref="Component">Component</see> entities. While the <i>DataItem</i>s describe the data that can be reported by a piece of equipment as an <see cref="MTConnectDevices">MTConnectDevices</see> entity, the actual data values are provided by the <see cref="MTConnectStreams">MTConnectStreams</see> entity in the <i>MTConnectStreams Response Document</i>. See <see cref="Observation Information Model">Observation Information Model</see> for detail on the reported values.<br /><br />Each <i>DataItem</i> <b>SHOULD</b> be modeled for the <see cref="MTConnectDevices">MTConnectDevices</see> entity such that it is associated with the entity that the reported data directly applies.<br /><br /><see cref="DataItem">DataItem</see> describes specific types of <i>DataItem</i>s that represent a numeric value, a functioning state, or a health status reported by a piece of equipment. <see cref="DataItem">DataItem</see> provides a detailed description for each <i>DataItem</i> that is reported; it defines the type of data being reported and an array of optional attributes that further describe that data. The different types of <see cref="DataItem">DataItem</see> elements are defined in <see cref="DataItem Types">DataItem Types</see>.<br/><br/><br />

	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Package__EAPK_0FAC31E7_7957_49d2_AD4C_BCFBEF9878FD">model.mtconnect.org</seealso> for more information.
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public class DataItemsPackage : IPackage
	{
		/// <inheritdoc />
		public string ReferenceId => "EAPK_0FAC31E7_7957_49d2_AD4C_BCFBEF9878FD";
		
		/// <inheritdoc />
		public string Name => "DataItems";

		/// <inheritdoc />
		public string Summary => @"&#10;&#10;&#10;This section provides semantic information for the {{block(DataItem)}} entity. {{figure(DataItems)}} shows the {{block(DataItem)}} model. 

![DataItems](figures/DataItems.png ""DataItems""){: width=""0.8""}

> Note: See {{sect(DataItems Schema Diagrams)}} for XML schema.&#10;
&#10;&#10;&#10;DataItems Model&#10;&#10;&#10;&#10;For an {{block(MTConnectDevices)}} entity, {{termplural(DataItem)}} describe data that can be reported by a piece of equipment and are associated with {{block(Device)}} and {{block(Component)}} entities. While the {{termplural(DataItem)}} describe the data that can be reported by a piece of equipment as an {{block(MTConnectDevices)}} entity, the actual data values are provided by the {{block(MTConnectStreams)}} entity in the {{term(MTConnectStreams Response Document)}}. See {{package(Observation Information Model)}} for detail on the reported values.

Each {{term(DataItem)}} **SHOULD** be modeled for the {{block(MTConnectDevices)}} entity such that it is associated with the entity that the reported data directly applies.

{{block(DataItem)}} describes specific types of {{termplural(DataItem)}} that represent a numeric value, a functioning state, or a health status reported by a piece of equipment. {{block(DataItem)}} provides a detailed description for each {{term(DataItem)}} that is reported; it defines the type of data being reported and an array of optional attributes that further describe that data. The different types of {{block(DataItem)}} elements are defined in {{package(DataItem Types)}}.&#10;
";

		/// <inheritdoc />
		public IPackage[] Packages => new IPackage[] {
			DataItemTypesPackage,
			PropertiesOfDataItemPackage,
		};
		
		/// <inheritdoc />
		public IClass[] Classes => new IClass[] {
			DataItemClass,
		};
		#region Packages
	private Package.DataItemTypesPackage _DataItemTypesPackage;
	/// <summary>
	/// <inheritdoc cref="Package.DataItemTypesPackage" path="/summary" />
	/// </summary>
	public Package.DataItemTypesPackage DataItemTypesPackage => _DataItemTypesPackage ?? (_DataItemTypesPackage = new Package.DataItemTypesPackage());

	private Package.PropertiesOfDataItemPackage _PropertiesOfDataItemPackage;
	/// <summary>
	/// <inheritdoc cref="Package.PropertiesOfDataItemPackage" path="/summary" />
	/// </summary>
	public Package.PropertiesOfDataItemPackage PropertiesOfDataItemPackage => _PropertiesOfDataItemPackage ?? (_PropertiesOfDataItemPackage = new Package.PropertiesOfDataItemPackage());

	#endregion

	#region Classes
	private Package.DataItemClass _DataItemClass;
	/// <summary>
	/// <inheritdoc cref="Package.DataItemClass" path="/summary" />
	/// </summary>
	public Package.DataItemClass DataItemClass => _DataItemClass ?? (_DataItemClass = new Package.DataItemClass());

	#endregion
	}
}