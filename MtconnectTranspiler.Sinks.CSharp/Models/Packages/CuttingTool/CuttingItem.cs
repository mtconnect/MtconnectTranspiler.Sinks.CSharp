using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;
using Package = Mtconnect.AssetInformationModel.CuttingTool.CuttingItem;

namespace Mtconnect.AssetInformationModel.CuttingTool
{
	/// <summary>
	/// A <see cref="CuttingItem">CuttingItem</see> is the portion of the tool that physically removes the material from the workpiece by shear deformation. The cutting item can be either a single piece of material attached to the <see cref="CuttingTool">CuttingTool</see> or it can be one or more separate pieces of material attached to the <see cref="CuttingTool">CuttingTool</see> using a permanent or removable attachment.  A <see cref="CuttingItem">CuttingItem</see> can be comprised of one or more cutting edges. Cutting items include: replaceable inserts, brazed tips and the cutting portions of solid <see cref="CuttingTools">CuttingTools</see>.  MTConnect Standard considers <see cref="CuttingItems">CuttingItems</see> as part of the <see cref="CuttingTool">CuttingTool</see>.  A <see cref="CuttingItems">CuttingItems</see> <b>MUST NOT</b> exist in MTConnect unless it is attached to a <see cref="CuttingTool">CuttingTool</see>.  Some of the measurements, such as <see cref="FunctionalLength">FunctionalLength</see>, <b>MUST</b> be made with reference to the entire <see cref="CuttingTool">CuttingTool</see> to be meaningful.  ![CuttingItem](figures/CuttingItem.png "CuttingItem"){: width="0.8"}  > Note: See <see cref="CuttingItem Schema Diagrams">CuttingItem Schema Diagrams</see> for XML schema.
	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Package__EAPK_2734C012_030C_44a6_8CE6_559328AFDCB9">model.mtconnect.org</seealso> for more information.
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.3.0.0")]
	public class CuttingItemPackage : IPackage
	{
		/// <inheritdoc />
		public string ReferenceId => "EAPK_2734C012_030C_44a6_8CE6_559328AFDCB9";
		
		/// <inheritdoc />
		public string Name => "Cutting Item";

		/// <inheritdoc />
		public string Summary => @"/// A <see cref=""CuttingItem"">CuttingItem</see> is the portion of the tool that physically removes the material from the workpiece by shear deformation. The cutting item can be either a single piece of material attached to the <see cref=""CuttingTool"">CuttingTool</see> or it can be one or more separate pieces of material attached to the <see cref=""CuttingTool"">CuttingTool</see> using a permanent or removable attachment.  A <see cref=""CuttingItem"">CuttingItem</see> can be comprised of one or more cutting edges. Cutting items include: replaceable inserts, brazed tips and the cutting portions of solid <see cref=""CuttingTools"">CuttingTools</see>.  MTConnect Standard considers <see cref=""CuttingItems"">CuttingItems</see> as part of the <see cref=""CuttingTool"">CuttingTool</see>.  A <see cref=""CuttingItems"">CuttingItems</see> <b>MUST NOT</b> exist in MTConnect unless it is attached to a <see cref=""CuttingTool"">CuttingTool</see>.  Some of the measurements, such as <see cref=""FunctionalLength"">FunctionalLength</see>, <b>MUST</b> be made with reference to the entire <see cref=""CuttingTool"">CuttingTool</see> to be meaningful.  ![CuttingItem](figures/CuttingItem.png ""CuttingItem""){: width=""0.8""}  > Note: See <see cref=""CuttingItem Schema Diagrams"">CuttingItem Schema Diagrams</see> for XML schema.";

		/// <inheritdoc />
		public IPackage[] Packages => new IPackage[] {
			CuttingItemMeasurementSubtypesPackage,
		};
		
		/// <inheritdoc />
		public IClass[] Classes => new IClass[] {
			CuttingItemClass,
			ItemLifeClass,
		};
		#region Packages
	private Package.CuttingItemMeasurementSubtypesPackage _CuttingItemMeasurementSubtypesPackage;
	/// <summary>
	/// <inheritdoc cref="Package.CuttingItemMeasurementSubtypesPackage" path="/summary" />
	/// </summary>
	public Package.CuttingItemMeasurementSubtypesPackage CuttingItemMeasurementSubtypesPackage => _CuttingItemMeasurementSubtypesPackage ?? (_CuttingItemMeasurementSubtypesPackage = new Package.CuttingItemMeasurementSubtypesPackage());

	#endregion

	#region Classes
	private Package.CuttingItemClass _CuttingItemClass;
	/// <summary>
	/// <inheritdoc cref="Package.CuttingItemClass" path="/summary" />
	/// </summary>
	public Package.CuttingItemClass CuttingItemClass => _CuttingItemClass ?? (_CuttingItemClass = new Package.CuttingItemClass());

	private Package.ItemLifeClass _ItemLifeClass;
	/// <summary>
	/// <inheritdoc cref="Package.ItemLifeClass" path="/summary" />
	/// </summary>
	public Package.ItemLifeClass ItemLifeClass => _ItemLifeClass ?? (_ItemLifeClass = new Package.ItemLifeClass());

	#endregion
	}
}