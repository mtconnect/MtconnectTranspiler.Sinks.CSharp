using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;
using Package = Mtconnect.AssetInformationModel;

namespace Mtconnect
{
	/// <summary>
	/// The MTConnect Standard supports a simple distributed storage mechanism that allows applications and equipment to share and exchange complex information models in a similar way to a distributed data store.  The <i>Asset Information Model</i> associates each <see cref="MTConnectAssets">MTConnectAssets</see> entity with a unique identifier and allows for some predefined mechanisms to find, create, request, update, and delete these electronic documents in a way that provides for consistency across multiple pieces of equipment.  The protocol provides a limited mechanism of accessing <i>Asset</i>s using the following properties: <see cref="Asset::assetId" />, <i>asset</i> type (element name of <i>asset</i> root), and the piece of equipment associated with the <i>asset</i>.  These access strategies will provide the following services and answer the following questions: What <i>asset</i>s are from a particular piece of equipment?  What are the <i>asset</i>s of a particular type? What <i>asset</i> is stored for a given <see cref="Asset::assetId" />?  Although these mechanisms are provided, an <i>agent</i> should not be considered a data store or a system of reference.  The <i>agent</i> is providing an ephemeral storage capability that will temporarily manage the data for applications wishing to communicate and manage data as needed by the various processes.  An application cannot rely on an <i>agent</i> for long term persistence or durability since the <i>agent</i> is only required to temporarily store the <i>asset</i> data and may require another system to provide the source data upon initialization.  An <i>agent</i> is always providing the best-known equipment centric view of the data given the limitations of that piece of equipment.  The MTConnect Standard has two data item types to support change notification when an <i>Asset</i> is added, updated or removed. <see cref="AssetChanged">AssetChanged</see> states the <see cref="Asset::assetId" /> of the <i>Asset</i> that has been added or updated. <see cref="AssetRemoved">AssetRemoved</see> states the <see cref="Asset::assetId" /> of the <i>Asset</i> that has been removed. See <see cref="Observation Information Model">Observation Information Model</see> for more details./// Assets Appendix
	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Package__EAPK_029C7254_810A_45f2_8400_D4E69ED8DF85">model.mtconnect.org</seealso> for more information.
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.3.0.0")]
	public class AssetInformationModelPackage : IPackage
	{
		/// <inheritdoc />
		public string ReferenceId => "EAPK_029C7254_810A_45f2_8400_D4E69ED8DF85";
		
		/// <inheritdoc />
		public string Name => "Asset Information Model";

		/// <inheritdoc />
		public string Summary => @"/// The MTConnect Standard supports a simple distributed storage mechanism that allows applications and equipment to share and exchange complex information models in a similar way to a distributed data store.  The <i>Asset Information Model</i> associates each <see cref=""MTConnectAssets"">MTConnectAssets</see> entity with a unique identifier and allows for some predefined mechanisms to find, create, request, update, and delete these electronic documents in a way that provides for consistency across multiple pieces of equipment.  The protocol provides a limited mechanism of accessing <i>Asset</i>s using the following properties: <see cref=""Asset::assetId"" />, <i>asset</i> type (element name of <i>asset</i> root), and the piece of equipment associated with the <i>asset</i>.  These access strategies will provide the following services and answer the following questions: What <i>asset</i>s are from a particular piece of equipment?  What are the <i>asset</i>s of a particular type? What <i>asset</i> is stored for a given <see cref=""Asset::assetId"" />?  Although these mechanisms are provided, an <i>agent</i> should not be considered a data store or a system of reference.  The <i>agent</i> is providing an ephemeral storage capability that will temporarily manage the data for applications wishing to communicate and manage data as needed by the various processes.  An application cannot rely on an <i>agent</i> for long term persistence or durability since the <i>agent</i> is only required to temporarily store the <i>asset</i> data and may require another system to provide the source data upon initialization.  An <i>agent</i> is always providing the best-known equipment centric view of the data given the limitations of that piece of equipment.  The MTConnect Standard has two data item types to support change notification when an <i>Asset</i> is added, updated or removed. <see cref=""AssetChanged"">AssetChanged</see> states the <see cref=""Asset::assetId"" /> of the <i>Asset</i> that has been added or updated. <see cref=""AssetRemoved"">AssetRemoved</see> states the <see cref=""Asset::assetId"" /> of the <i>Asset</i> that has been removed. See <see cref=""Observation Information Model"">Observation Information Model</see> for more details./// Assets Appendix";

		/// <inheritdoc />
		public IPackage[] Packages => new IPackage[] {
			CuttingToolPackage,
			FilesPackage,
			RawMaterialPackage,
			QIFPackage,
			ComponentConfigurationParametersPackage,
		};
		
		/// <inheritdoc />
		public IClass[] Classes => new IClass[] {
			AssetClass,
		};
		#region Packages
	private Package.CuttingToolPackage _CuttingToolPackage;
	/// <summary>
	/// <inheritdoc cref="Package.CuttingToolPackage" path="/summary" />
	/// </summary>
	public Package.CuttingToolPackage CuttingToolPackage => _CuttingToolPackage ?? (_CuttingToolPackage = new Package.CuttingToolPackage());

	private Package.FilesPackage _FilesPackage;
	/// <summary>
	/// <inheritdoc cref="Package.FilesPackage" path="/summary" />
	/// </summary>
	public Package.FilesPackage FilesPackage => _FilesPackage ?? (_FilesPackage = new Package.FilesPackage());

	private Package.RawMaterialPackage _RawMaterialPackage;
	/// <summary>
	/// <inheritdoc cref="Package.RawMaterialPackage" path="/summary" />
	/// </summary>
	public Package.RawMaterialPackage RawMaterialPackage => _RawMaterialPackage ?? (_RawMaterialPackage = new Package.RawMaterialPackage());

	private Package.QIFPackage _QIFPackage;
	/// <summary>
	/// <inheritdoc cref="Package.QIFPackage" path="/summary" />
	/// </summary>
	public Package.QIFPackage QIFPackage => _QIFPackage ?? (_QIFPackage = new Package.QIFPackage());

	private Package.ComponentConfigurationParametersPackage _ComponentConfigurationParametersPackage;
	/// <summary>
	/// <inheritdoc cref="Package.ComponentConfigurationParametersPackage" path="/summary" />
	/// </summary>
	public Package.ComponentConfigurationParametersPackage ComponentConfigurationParametersPackage => _ComponentConfigurationParametersPackage ?? (_ComponentConfigurationParametersPackage = new Package.ComponentConfigurationParametersPackage());

	#endregion

	#region Classes
	private Package.AssetClass _AssetClass;
	/// <summary>
	/// <inheritdoc cref="Package.AssetClass" path="/summary" />
	/// </summary>
	public Package.AssetClass AssetClass => _AssetClass ?? (_AssetClass = new Package.AssetClass());

	#endregion
	}
}