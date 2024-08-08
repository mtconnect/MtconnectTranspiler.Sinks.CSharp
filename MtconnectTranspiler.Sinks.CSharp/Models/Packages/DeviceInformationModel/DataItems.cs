using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;
using Package = Mtconnect.DeviceInformationModel.DataItems;
// using Mtconnect;

namespace Mtconnect.DeviceInformationModel
{
	/// <summary>
	/// This section provides semantic information for the <see cref="DataItem">DataItem</see> entity. {{figure(DataItems)}} shows the <see cref="DataItem">DataItem</see> model.   ![DataItems](figures/DataItems.png "DataItems"){: width="0.8"}  > Note: See <see cref="DataItems Schema Diagrams">DataItems Schema Diagrams</see> for XML schema./// DataItems Model
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.3.0.0")]
	public class DataItemsPackage : IPackage
	{
		/// <inheritdoc />
		public string ReferenceId => "EAPK_0FAC31E7_7957_49d2_AD4C_BCFBEF9878FD";
		
		/// <inheritdoc />
		public string Name => "DataItems";

		/// <inheritdoc />
		public string Summary => @"/// This section provides semantic information for the <see cref=""DataItem"">DataItem</see> entity. {{figure(DataItems)}} shows the <see cref=""DataItem"">DataItem</see> model.   ![DataItems](figures/DataItems.png ""DataItems""){: width=""0.8""}  > Note: See <see cref=""DataItems Schema Diagrams"">DataItems Schema Diagrams</see> for XML schema./// DataItems Model";

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