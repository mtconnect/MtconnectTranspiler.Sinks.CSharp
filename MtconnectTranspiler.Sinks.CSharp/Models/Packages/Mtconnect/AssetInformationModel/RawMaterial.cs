
using System;
using System.CodeDom.Compiler;
using Package = Mtconnect.AssetInformationModel.RawMaterial;

using Mtconnect;

namespace Mtconnect.AssetInformationModel {
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "1.0.15.3")]
	public class RawMaterialPackage {


	private Package.RawMaterialClass _RawMaterial;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.RawMaterialClass RawMaterial => _RawMaterial ?? (_RawMaterial = new Package.RawMaterialClass());

	private Package.MaterialClass _Material;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.MaterialClass Material => _Material ?? (_Material = new Package.MaterialClass());
	}
}