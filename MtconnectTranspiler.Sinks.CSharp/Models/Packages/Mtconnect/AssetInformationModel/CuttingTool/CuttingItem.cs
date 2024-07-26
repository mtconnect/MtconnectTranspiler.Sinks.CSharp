
using System;
using System.CodeDom.Compiler;
using Package = Mtconnect.AssetInformationModel.CuttingTool.CuttingItem;

using Mtconnect;

namespace Mtconnect.AssetInformationModel.CuttingTool {
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "1.0.15.3")]
	public class CuttingItemPackage {

	private Package.CuttingItemMeasurementSubtypesPackage _CuttingItemMeasurementSubtypesPackage;
	public Package.CuttingItemMeasurementSubtypesPackage CuttingItemMeasurementSubtypesPackage => _CuttingItemMeasurementSubtypesPackage ?? (_CuttingItemMeasurementSubtypesPackage = new Package.CuttingItemMeasurementSubtypesPackage());


	private Package.CuttingItemClass _CuttingItem;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.CuttingItemClass CuttingItem => _CuttingItem ?? (_CuttingItem = new Package.CuttingItemClass());

	private Package.ItemLifeClass _ItemLife;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.ItemLifeClass ItemLife => _ItemLife ?? (_ItemLife = new Package.ItemLifeClass());
	}
}