using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;
using Package = Mtconnect.AssetInformationModel.RawMaterial;

namespace Mtconnect.AssetInformationModel
{
	/// <summary>
	/// This section provides semantic information for the <see cref="RawMaterial">RawMaterial</see> model.  ![RawMaterial](figures/RawMaterial.png "RawMaterial"){: width="0.5"}  > Note: See <see cref="RawMaterial Schema Diagrams">RawMaterial Schema Diagrams</see> for XML schema./// Raw Material Asset Information Model
	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Package___19_0_3_68e0225_1618829862497_960144_123">model.mtconnect.org</seealso> for more information.
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.3.0.0")]
	public class RawMaterialPackage : IPackage
	{
		/// <inheritdoc />
		public string ReferenceId => "_19_0_3_68e0225_1618829862497_960144_123";
		
		/// <inheritdoc />
		public string Name => "Raw Material";

		/// <inheritdoc />
		public string Summary => @"/// This section provides semantic information for the <see cref=""RawMaterial"">RawMaterial</see> model.  ![RawMaterial](figures/RawMaterial.png ""RawMaterial""){: width=""0.5""}  > Note: See <see cref=""RawMaterial Schema Diagrams"">RawMaterial Schema Diagrams</see> for XML schema./// Raw Material Asset Information Model";

		/// <inheritdoc />
		public IPackage[] Packages => new IPackage[] {
		};
		
		/// <inheritdoc />
		public IClass[] Classes => new IClass[] {
			RawMaterialClass,
			MaterialClass,
		};
		#region Packages
	#endregion

	#region Classes
	private Package.RawMaterialClass _RawMaterialClass;
	/// <summary>
	/// <inheritdoc cref="Package.RawMaterialClass" path="/summary" />
	/// </summary>
	public Package.RawMaterialClass RawMaterialClass => _RawMaterialClass ?? (_RawMaterialClass = new Package.RawMaterialClass());

	private Package.MaterialClass _MaterialClass;
	/// <summary>
	/// <inheritdoc cref="Package.MaterialClass" path="/summary" />
	/// </summary>
	public Package.MaterialClass MaterialClass => _MaterialClass ?? (_MaterialClass = new Package.MaterialClass());

	#endregion
	}
}