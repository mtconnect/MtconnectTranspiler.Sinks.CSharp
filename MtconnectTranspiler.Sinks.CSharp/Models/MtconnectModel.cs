using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;

namespace Mtconnect
{
	/// <summary>
	/// Static root for the MTConnect SysML model.
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public static class MtconnectModel
	{
		/// <summary>
		/// Collection of root <see cref="IPackage" />s.
		/// </summary>
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

		/// <summary>
		/// Collection of root <see cref="IClass" />'.
		/// </summary>
		public static IClass[] Classes => new IClass[] {
		};

		#region Packages
	private static AssetInformationModelPackage _AssetInformationModelPackage;
	/// <summary>
	/// <ineritdoc cref="Mtconnect.AssetInformationModelPackage" path="/summary" />
	/// </summary>
	public static AssetInformationModelPackage AssetInformationModelPackage => _AssetInformationModelPackage ?? (_AssetInformationModelPackage = new AssetInformationModelPackage());

		private static FundamentalsPackage _FundamentalsPackage;
	/// <summary>
	/// <ineritdoc cref="Mtconnect.FundamentalsPackage" path="/summary" />
	/// </summary>
	public static FundamentalsPackage FundamentalsPackage => _FundamentalsPackage ?? (_FundamentalsPackage = new FundamentalsPackage());

		private static ObservationInformationModelPackage _ObservationInformationModelPackage;
	/// <summary>
	/// <ineritdoc cref="Mtconnect.ObservationInformationModelPackage" path="/summary" />
	/// </summary>
	public static ObservationInformationModelPackage ObservationInformationModelPackage => _ObservationInformationModelPackage ?? (_ObservationInformationModelPackage = new ObservationInformationModelPackage());

		private static GlossaryPackage _GlossaryPackage;
	/// <summary>
	/// <ineritdoc cref="Mtconnect.GlossaryPackage" path="/summary" />
	/// </summary>
	public static GlossaryPackage GlossaryPackage => _GlossaryPackage ?? (_GlossaryPackage = new GlossaryPackage());

		private static AgentArchitecturePackage _AgentArchitecturePackage;
	/// <summary>
	/// <ineritdoc cref="Mtconnect.AgentArchitecturePackage" path="/summary" />
	/// </summary>
	public static AgentArchitecturePackage AgentArchitecturePackage => _AgentArchitecturePackage ?? (_AgentArchitecturePackage = new AgentArchitecturePackage());

		private static DevelopmentProcessPackage _DevelopmentProcessPackage;
	/// <summary>
	/// <ineritdoc cref="Mtconnect.DevelopmentProcessPackage" path="/summary" />
	/// </summary>
	public static DevelopmentProcessPackage DevelopmentProcessPackage => _DevelopmentProcessPackage ?? (_DevelopmentProcessPackage = new DevelopmentProcessPackage());

		private static SupportingDocumentsPackage _SupportingDocumentsPackage;
	/// <summary>
	/// <ineritdoc cref="Mtconnect.SupportingDocumentsPackage" path="/summary" />
	/// </summary>
	public static SupportingDocumentsPackage SupportingDocumentsPackage => _SupportingDocumentsPackage ?? (_SupportingDocumentsPackage = new SupportingDocumentsPackage());

		private static WIP_BestPracticesWithExamplesPackage _WIP_BestPracticesWithExamplesPackage;
	/// <summary>
	/// <ineritdoc cref="Mtconnect.WIP_BestPracticesWithExamplesPackage" path="/summary" />
	/// </summary>
	public static WIP_BestPracticesWithExamplesPackage WIP_BestPracticesWithExamplesPackage => _WIP_BestPracticesWithExamplesPackage ?? (_WIP_BestPracticesWithExamplesPackage = new WIP_BestPracticesWithExamplesPackage());

		private static MTConnectDeviceValidationSuitePackage _MTConnectDeviceValidationSuitePackage;
	/// <summary>
	/// <ineritdoc cref="Mtconnect.MTConnectDeviceValidationSuitePackage" path="/summary" />
	/// </summary>
	public static MTConnectDeviceValidationSuitePackage MTConnectDeviceValidationSuitePackage => _MTConnectDeviceValidationSuitePackage ?? (_MTConnectDeviceValidationSuitePackage = new MTConnectDeviceValidationSuitePackage());

		private static InterfaceInteractionModelPackage _InterfaceInteractionModelPackage;
	/// <summary>
	/// <ineritdoc cref="Mtconnect.InterfaceInteractionModelPackage" path="/summary" />
	/// </summary>
	public static InterfaceInteractionModelPackage InterfaceInteractionModelPackage => _InterfaceInteractionModelPackage ?? (_InterfaceInteractionModelPackage = new InterfaceInteractionModelPackage());

		private static DeviceInformationModelPackage _DeviceInformationModelPackage;
	/// <summary>
	/// <ineritdoc cref="Mtconnect.DeviceInformationModelPackage" path="/summary" />
	/// </summary>
	public static DeviceInformationModelPackage DeviceInformationModelPackage => _DeviceInformationModelPackage ?? (_DeviceInformationModelPackage = new DeviceInformationModelPackage());

		private static ImportsPackage _ImportsPackage;
	/// <summary>
	/// <ineritdoc cref="Mtconnect.ImportsPackage" path="/summary" />
	/// </summary>
	public static ImportsPackage ImportsPackage => _ImportsPackage ?? (_ImportsPackage = new ImportsPackage());

		#endregion

	#region Classes
	#endregion
	}
}