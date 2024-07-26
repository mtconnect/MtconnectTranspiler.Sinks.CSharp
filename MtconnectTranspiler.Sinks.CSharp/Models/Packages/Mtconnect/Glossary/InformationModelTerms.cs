
using System;
using System.CodeDom.Compiler;
using Package = Mtconnect.Glossary.InformationModelTerms;

using Mtconnect;

namespace Mtconnect.Glossary {
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "1.0.15.3")]
	public class InformationModelTermsPackage {


	private Package.ErrorInformationModelClass _ErrorInformationModel;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.ErrorInformationModelClass ErrorInformationModel => _ErrorInformationModel ?? (_ErrorInformationModel = new Package.ErrorInformationModelClass());

	private Package.AssetInformationModelClass _AssetInformationModel;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.AssetInformationModelClass AssetInformationModel => _AssetInformationModel ?? (_AssetInformationModel = new Package.AssetInformationModelClass());

	private Package.MTConnectInformationModelClass _MTConnectInformationModel;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.MTConnectInformationModelClass MTConnectInformationModel => _MTConnectInformationModel ?? (_MTConnectInformationModel = new Package.MTConnectInformationModelClass());

	private Package.ObservationInformationModelClass _ObservationInformationModel;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.ObservationInformationModelClass ObservationInformationModel => _ObservationInformationModel ?? (_ObservationInformationModel = new Package.ObservationInformationModelClass());

	private Package.DeviceInformationModelClass _DeviceInformationModel;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.DeviceInformationModelClass DeviceInformationModel => _DeviceInformationModel ?? (_DeviceInformationModel = new Package.DeviceInformationModelClass());
	}
}