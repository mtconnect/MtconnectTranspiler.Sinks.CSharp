using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;
using Package = Mtconnect.AssetInformationModel.CuttingTool.CuttingItem;
// using Mtconnect;

namespace Mtconnect.AssetInformationModel.CuttingTool {
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "1.0.15.3")]
	public class CuttingItemPackage : IPackage {
		public IPackage[] Packages => new IPackage[] {
			CuttingItemMeasurementSubtypesPackage,
		};

		public IClass[] Classes => new IClass[] {
			CuttingItemClass,
			ItemLifeClass,
		};
	private Package.CuttingItemMeasurementSubtypesPackage _CuttingItemMeasurementSubtypesPackage;
	public Package.CuttingItemMeasurementSubtypesPackage CuttingItemMeasurementSubtypesPackage => _CuttingItemMeasurementSubtypesPackage ?? (_CuttingItemMeasurementSubtypesPackage = new Package.CuttingItemMeasurementSubtypesPackage());

	private Package.CuttingItemClass _CuttingItemClass;
	public Package.CuttingItemClass CuttingItemClass => _CuttingItemClass ?? (_CuttingItemClass = new Package.CuttingItemClass());
	private Package.ItemLifeClass _ItemLifeClass;
	public Package.ItemLifeClass ItemLifeClass => _ItemLifeClass ?? (_ItemLifeClass = new Package.ItemLifeClass());
	}
}