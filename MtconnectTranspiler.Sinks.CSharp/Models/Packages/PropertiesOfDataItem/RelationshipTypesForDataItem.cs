using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;
using Package = Mtconnect.DeviceInformationModel.DataItems.PropertiesOfDataItem.RelationshipTypesForDataItem;

namespace Mtconnect.DeviceInformationModel.DataItems.PropertiesOfDataItem
{
	/// <summary>
	/// This section provides semantic information for the types of <see cref="AbstractDataItemRelationship">AbstractDataItemRelationship</see> that can be defined for a <see cref="DataItem">DataItem</see>.
	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Package___19_0_3_68e0225_1605645450472_400925_2872">model.mtconnect.org</seealso> for more information.
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.3.0.0")]
	public class RelationshipTypesForDataItemPackage : IPackage
	{
		/// <inheritdoc />
		public string ReferenceId => "_19_0_3_68e0225_1605645450472_400925_2872";
		
		/// <inheritdoc />
		public string Name => "Relationship Types for DataItem";

		/// <inheritdoc />
		public string Summary => @"/// This section provides semantic information for the types of <see cref=""AbstractDataItemRelationship"">AbstractDataItemRelationship</see> that can be defined for a <see cref=""DataItem"">DataItem</see>.";

		/// <inheritdoc />
		public IPackage[] Packages => new IPackage[] {
		};
		
		/// <inheritdoc />
		public IClass[] Classes => new IClass[] {
			SpecificationRelationshipClass,
			DataItemRelationshipClass,
			AbstractDataItemRelationshipClass,
		};
		#region Packages
	#endregion

	#region Classes
	private Package.SpecificationRelationshipClass _SpecificationRelationshipClass;
	/// <summary>
	/// <inheritdoc cref="Package.SpecificationRelationshipClass" path="/summary" />
	/// </summary>
	public Package.SpecificationRelationshipClass SpecificationRelationshipClass => _SpecificationRelationshipClass ?? (_SpecificationRelationshipClass = new Package.SpecificationRelationshipClass());

	private Package.DataItemRelationshipClass _DataItemRelationshipClass;
	/// <summary>
	/// <inheritdoc cref="Package.DataItemRelationshipClass" path="/summary" />
	/// </summary>
	public Package.DataItemRelationshipClass DataItemRelationshipClass => _DataItemRelationshipClass ?? (_DataItemRelationshipClass = new Package.DataItemRelationshipClass());

	private Package.AbstractDataItemRelationshipClass _AbstractDataItemRelationshipClass;
	/// <summary>
	/// <inheritdoc cref="Package.AbstractDataItemRelationshipClass" path="/summary" />
	/// </summary>
	public Package.AbstractDataItemRelationshipClass AbstractDataItemRelationshipClass => _AbstractDataItemRelationshipClass ?? (_AbstractDataItemRelationshipClass = new Package.AbstractDataItemRelationshipClass());

	#endregion
	}
}