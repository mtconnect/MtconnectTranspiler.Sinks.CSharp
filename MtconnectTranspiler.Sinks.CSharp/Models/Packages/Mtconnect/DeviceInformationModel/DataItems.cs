
using System;
using System.CodeDom.Compiler;
using Package = Mtconnect.DeviceInformationModel.DataItems;

using Mtconnect;

namespace Mtconnect.DeviceInformationModel {
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "1.0.15.3")]
	public class DataItemsPackage {

	private Package.DataItemTypesPackage _DataItemTypesPackage;
	public Package.DataItemTypesPackage DataItemTypesPackage => _DataItemTypesPackage ?? (_DataItemTypesPackage = new Package.DataItemTypesPackage());

	private Package.PropertiesOfDataItemPackage _PropertiesOfDataItemPackage;
	public Package.PropertiesOfDataItemPackage PropertiesOfDataItemPackage => _PropertiesOfDataItemPackage ?? (_PropertiesOfDataItemPackage = new Package.PropertiesOfDataItemPackage());


	private Package.DataItemClass _DataItem;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.DataItemClass DataItem => _DataItem ?? (_DataItem = new Package.DataItemClass());
	}
}