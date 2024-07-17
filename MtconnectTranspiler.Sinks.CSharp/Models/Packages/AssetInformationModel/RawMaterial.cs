using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;
using Package = Mtconnect.AssetInformationModel.RawMaterial;
// using Mtconnect;

namespace Mtconnect.AssetInformationModel {
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "1.0.15.3")]
	public class RawMaterialPackage : IPackage {
		public IPackage[] Packages => new IPackage[] {
		};

		public IClass[] Classes => new IClass[] {
			RawMaterialClass,
			MaterialClass,
		};

	private Package.RawMaterialClass _RawMaterialClass;
	public Package.RawMaterialClass RawMaterialClass => _RawMaterialClass ?? (_RawMaterialClass = new Package.RawMaterialClass());
	private Package.MaterialClass _MaterialClass;
	public Package.MaterialClass MaterialClass => _MaterialClass ?? (_MaterialClass = new Package.MaterialClass());
	}
}