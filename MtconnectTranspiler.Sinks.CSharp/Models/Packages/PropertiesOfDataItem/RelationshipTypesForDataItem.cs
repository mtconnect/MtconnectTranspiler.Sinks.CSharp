using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;
using Package = Mtconnect.DeviceInformationModel.DataItems.PropertiesOfDataItem.RelationshipTypesForDataItem;
// using Mtconnect;

namespace Mtconnect.DeviceInformationModel.DataItems.PropertiesOfDataItem {
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "1.0.15.3")]
	public class RelationshipTypesForDataItemPackage : IPackage {
		public IPackage[] Packages => new IPackage[] {
		};

		public IClass[] Classes => new IClass[] {
			SpecificationRelationshipClass,
			DataItemRelationshipClass,
			AbstractDataItemRelationshipClass,
		};

	private Package.SpecificationRelationshipClass _SpecificationRelationshipClass;
	public Package.SpecificationRelationshipClass SpecificationRelationshipClass => _SpecificationRelationshipClass ?? (_SpecificationRelationshipClass = new Package.SpecificationRelationshipClass());
	private Package.DataItemRelationshipClass _DataItemRelationshipClass;
	public Package.DataItemRelationshipClass DataItemRelationshipClass => _DataItemRelationshipClass ?? (_DataItemRelationshipClass = new Package.DataItemRelationshipClass());
	private Package.AbstractDataItemRelationshipClass _AbstractDataItemRelationshipClass;
	public Package.AbstractDataItemRelationshipClass AbstractDataItemRelationshipClass => _AbstractDataItemRelationshipClass ?? (_AbstractDataItemRelationshipClass = new Package.AbstractDataItemRelationshipClass());
	}
}