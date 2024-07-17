using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;
using Package = Mtconnect.DeviceInformationModel.DataItems;
// using Mtconnect;

namespace Mtconnect.DeviceInformationModel {
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "1.0.15.3")]
	public class DataItemsPackage : IPackage {
		public IPackage[] Packages => new IPackage[] {
			DataItemTypesPackage,
			PropertiesOfDataItemPackage,
		};

		public IClass[] Classes => new IClass[] {
			DataItemClass,
		};
	private Package.DataItemTypesPackage _DataItemTypesPackage;
	public Package.DataItemTypesPackage DataItemTypesPackage => _DataItemTypesPackage ?? (_DataItemTypesPackage = new Package.DataItemTypesPackage());
	private Package.PropertiesOfDataItemPackage _PropertiesOfDataItemPackage;
	public Package.PropertiesOfDataItemPackage PropertiesOfDataItemPackage => _PropertiesOfDataItemPackage ?? (_PropertiesOfDataItemPackage = new Package.PropertiesOfDataItemPackage());

	private Package.DataItemClass _DataItemClass;
	public Package.DataItemClass DataItemClass => _DataItemClass ?? (_DataItemClass = new Package.DataItemClass());
	}
}