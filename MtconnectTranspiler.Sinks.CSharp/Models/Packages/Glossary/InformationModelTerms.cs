using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;
using Package = Mtconnect.Glossary.InformationModelTerms;
// using Mtconnect;

namespace Mtconnect.Glossary {
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "1.0.15.3")]
	public class InformationModelTermsPackage : IPackage {
		public IPackage[] Packages => new IPackage[] {
		};

		public IClass[] Classes => new IClass[] {
			ErrorInformationModelClass,
			AssetInformationModelClass,
			MTConnectInformationModelGeneralization,
			ObservationInformationModelClass,
			DeviceInformationModelClass,
		};

	private Package.ErrorInformationModelClass _ErrorInformationModelClass;
	public Package.ErrorInformationModelClass ErrorInformationModelClass => _ErrorInformationModelClass ?? (_ErrorInformationModelClass = new Package.ErrorInformationModelClass());
	private Package.AssetInformationModelClass _AssetInformationModelClass;
	public Package.AssetInformationModelClass AssetInformationModelClass => _AssetInformationModelClass ?? (_AssetInformationModelClass = new Package.AssetInformationModelClass());
	private Package.MTConnectInformationModelGeneralization _MTConnectInformationModelGeneralization;
	public Package.MTConnectInformationModelGeneralization MTConnectInformationModelGeneralization => _MTConnectInformationModelGeneralization ?? (_MTConnectInformationModelGeneralization = new Package.MTConnectInformationModelGeneralization());
	private Package.ObservationInformationModelClass _ObservationInformationModelClass;
	public Package.ObservationInformationModelClass ObservationInformationModelClass => _ObservationInformationModelClass ?? (_ObservationInformationModelClass = new Package.ObservationInformationModelClass());
	private Package.DeviceInformationModelClass _DeviceInformationModelClass;
	public Package.DeviceInformationModelClass DeviceInformationModelClass => _DeviceInformationModelClass ?? (_DeviceInformationModelClass = new Package.DeviceInformationModelClass());
	}
}