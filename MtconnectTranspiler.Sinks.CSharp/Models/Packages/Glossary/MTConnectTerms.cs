using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;
using Package = Mtconnect.Glossary.MTConnectTerms;
// using Mtconnect;

namespace Mtconnect.Glossary {
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "1.0.15.3")]
	public class MTConnectTermsPackage : IPackage {
		public IPackage[] Packages => new IPackage[] {
			AdditionalObservationTermsPackage,
		};

		public IClass[] Classes => new IClass[] {
			ComponentClass,
			MTConnectAgentGeneralization,
			AssetGeneralization,
			CompositionClass,
			MTConnectDocumentGeneralization,
			ConfigurationGeneralization,
			DeviceClass,
			MTConnectInterfaceClass,
			ObservationClass,
			MTConnectEventGeneralization,
			DataItemClass,
		};
	private Package.AdditionalObservationTermsPackage _AdditionalObservationTermsPackage;
	public Package.AdditionalObservationTermsPackage AdditionalObservationTermsPackage => _AdditionalObservationTermsPackage ?? (_AdditionalObservationTermsPackage = new Package.AdditionalObservationTermsPackage());

	private Package.ComponentClass _ComponentClass;
	public Package.ComponentClass ComponentClass => _ComponentClass ?? (_ComponentClass = new Package.ComponentClass());
	private Package.MTConnectAgentGeneralization _MTConnectAgentGeneralization;
	public Package.MTConnectAgentGeneralization MTConnectAgentGeneralization => _MTConnectAgentGeneralization ?? (_MTConnectAgentGeneralization = new Package.MTConnectAgentGeneralization());
	private Package.AssetGeneralization _AssetGeneralization;
	public Package.AssetGeneralization AssetGeneralization => _AssetGeneralization ?? (_AssetGeneralization = new Package.AssetGeneralization());
	private Package.CompositionClass _CompositionClass;
	public Package.CompositionClass CompositionClass => _CompositionClass ?? (_CompositionClass = new Package.CompositionClass());
	private Package.MTConnectDocumentGeneralization _MTConnectDocumentGeneralization;
	public Package.MTConnectDocumentGeneralization MTConnectDocumentGeneralization => _MTConnectDocumentGeneralization ?? (_MTConnectDocumentGeneralization = new Package.MTConnectDocumentGeneralization());
	private Package.ConfigurationGeneralization _ConfigurationGeneralization;
	public Package.ConfigurationGeneralization ConfigurationGeneralization => _ConfigurationGeneralization ?? (_ConfigurationGeneralization = new Package.ConfigurationGeneralization());
	private Package.DeviceClass _DeviceClass;
	public Package.DeviceClass DeviceClass => _DeviceClass ?? (_DeviceClass = new Package.DeviceClass());
	private Package.MTConnectInterfaceClass _MTConnectInterfaceClass;
	public Package.MTConnectInterfaceClass MTConnectInterfaceClass => _MTConnectInterfaceClass ?? (_MTConnectInterfaceClass = new Package.MTConnectInterfaceClass());
	private Package.ObservationClass _ObservationClass;
	public Package.ObservationClass ObservationClass => _ObservationClass ?? (_ObservationClass = new Package.ObservationClass());
	private Package.MTConnectEventGeneralization _MTConnectEventGeneralization;
	public Package.MTConnectEventGeneralization MTConnectEventGeneralization => _MTConnectEventGeneralization ?? (_MTConnectEventGeneralization = new Package.MTConnectEventGeneralization());
	private Package.DataItemClass _DataItemClass;
	public Package.DataItemClass DataItemClass => _DataItemClass ?? (_DataItemClass = new Package.DataItemClass());
	}
}