using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;
using Package = Mtconnect.AssetInformationModel;
// using Mtconnect;

namespace Mtconnect {
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "1.0.15.3")]
	public class AssetInformationModelPackage : IPackage {
		public IPackage[] Packages => new IPackage[] {
			CuttingToolPackage,
			FilesPackage,
			RawMaterialPackage,
			QIFPackage,
			ComponentConfigurationParametersPackage,
		};

		public IClass[] Classes => new IClass[] {
			AssetClass,
		};
	private Package.CuttingToolPackage _CuttingToolPackage;
	public Package.CuttingToolPackage CuttingToolPackage => _CuttingToolPackage ?? (_CuttingToolPackage = new Package.CuttingToolPackage());
	private Package.FilesPackage _FilesPackage;
	public Package.FilesPackage FilesPackage => _FilesPackage ?? (_FilesPackage = new Package.FilesPackage());
	private Package.RawMaterialPackage _RawMaterialPackage;
	public Package.RawMaterialPackage RawMaterialPackage => _RawMaterialPackage ?? (_RawMaterialPackage = new Package.RawMaterialPackage());
	private Package.QIFPackage _QIFPackage;
	public Package.QIFPackage QIFPackage => _QIFPackage ?? (_QIFPackage = new Package.QIFPackage());
	private Package.ComponentConfigurationParametersPackage _ComponentConfigurationParametersPackage;
	public Package.ComponentConfigurationParametersPackage ComponentConfigurationParametersPackage => _ComponentConfigurationParametersPackage ?? (_ComponentConfigurationParametersPackage = new Package.ComponentConfigurationParametersPackage());

	private Package.AssetClass _AssetClass;
	public Package.AssetClass AssetClass => _AssetClass ?? (_AssetClass = new Package.AssetClass());
	}
}