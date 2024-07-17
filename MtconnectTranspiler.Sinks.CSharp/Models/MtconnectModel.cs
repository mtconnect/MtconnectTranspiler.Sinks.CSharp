using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;

namespace Mtconnect
{
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "1.0.15.3")]
	public static class MtconnectModel
	{
		public static IPackage[] Packages => new IPackage[] {
			AssetInformationModelPackage,
			FundamentalsPackage,
			ObservationInformationModelPackage,
			GlossaryPackage,
			AgentArchitecturePackage,
			DevelopmentProcessPackage,
			SupportingDocumentsPackage,
			WIP_BestPracticesWithExamplesPackage,
			MTConnectDeviceValidationSuitePackage,
			InterfaceInteractionModelPackage,
			DeviceInformationModelPackage,
			ImportsPackage,
		};

		public static IClass[] Classes => new IClass[] {
		};
	private static AssetInformationModelPackage _AssetInformationModelPackage;
	public static AssetInformationModelPackage AssetInformationModelPackage => _AssetInformationModelPackage ?? (_AssetInformationModelPackage = new AssetInformationModelPackage());
	private static FundamentalsPackage _FundamentalsPackage;
	public static FundamentalsPackage FundamentalsPackage => _FundamentalsPackage ?? (_FundamentalsPackage = new FundamentalsPackage());
	private static ObservationInformationModelPackage _ObservationInformationModelPackage;
	public static ObservationInformationModelPackage ObservationInformationModelPackage => _ObservationInformationModelPackage ?? (_ObservationInformationModelPackage = new ObservationInformationModelPackage());
	private static GlossaryPackage _GlossaryPackage;
	public static GlossaryPackage GlossaryPackage => _GlossaryPackage ?? (_GlossaryPackage = new GlossaryPackage());
	private static AgentArchitecturePackage _AgentArchitecturePackage;
	public static AgentArchitecturePackage AgentArchitecturePackage => _AgentArchitecturePackage ?? (_AgentArchitecturePackage = new AgentArchitecturePackage());
	private static DevelopmentProcessPackage _DevelopmentProcessPackage;
	public static DevelopmentProcessPackage DevelopmentProcessPackage => _DevelopmentProcessPackage ?? (_DevelopmentProcessPackage = new DevelopmentProcessPackage());
	private static SupportingDocumentsPackage _SupportingDocumentsPackage;
	public static SupportingDocumentsPackage SupportingDocumentsPackage => _SupportingDocumentsPackage ?? (_SupportingDocumentsPackage = new SupportingDocumentsPackage());
	private static WIP_BestPracticesWithExamplesPackage _WIP_BestPracticesWithExamplesPackage;
	public static WIP_BestPracticesWithExamplesPackage WIP_BestPracticesWithExamplesPackage => _WIP_BestPracticesWithExamplesPackage ?? (_WIP_BestPracticesWithExamplesPackage = new WIP_BestPracticesWithExamplesPackage());
	private static MTConnectDeviceValidationSuitePackage _MTConnectDeviceValidationSuitePackage;
	public static MTConnectDeviceValidationSuitePackage MTConnectDeviceValidationSuitePackage => _MTConnectDeviceValidationSuitePackage ?? (_MTConnectDeviceValidationSuitePackage = new MTConnectDeviceValidationSuitePackage());
	private static InterfaceInteractionModelPackage _InterfaceInteractionModelPackage;
	public static InterfaceInteractionModelPackage InterfaceInteractionModelPackage => _InterfaceInteractionModelPackage ?? (_InterfaceInteractionModelPackage = new InterfaceInteractionModelPackage());
	private static DeviceInformationModelPackage _DeviceInformationModelPackage;
	public static DeviceInformationModelPackage DeviceInformationModelPackage => _DeviceInformationModelPackage ?? (_DeviceInformationModelPackage = new DeviceInformationModelPackage());
	private static ImportsPackage _ImportsPackage;
	public static ImportsPackage ImportsPackage => _ImportsPackage ?? (_ImportsPackage = new ImportsPackage());

	}
}