
using System;
using System.CodeDom.Compiler;
using Package = Mtconnect.DeviceInformationModel.DataItems.PropertiesOfDataItem.RelationshipTypesForDataItem;

using Mtconnect;

namespace Mtconnect.DeviceInformationModel.DataItems.PropertiesOfDataItem {
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "1.0.15.3")]
	public class RelationshipTypesForDataItemPackage {


	private Package.SpecificationRelationshipClass _SpecificationRelationship;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.SpecificationRelationshipClass SpecificationRelationship => _SpecificationRelationship ?? (_SpecificationRelationship = new Package.SpecificationRelationshipClass());

	private Package.DataItemRelationshipClass _DataItemRelationship;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.DataItemRelationshipClass DataItemRelationship => _DataItemRelationship ?? (_DataItemRelationship = new Package.DataItemRelationshipClass());

	private Package.AbstractDataItemRelationshipClass _AbstractDataItemRelationship;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.AbstractDataItemRelationshipClass AbstractDataItemRelationship => _AbstractDataItemRelationship ?? (_AbstractDataItemRelationship = new Package.AbstractDataItemRelationshipClass());
	}
}