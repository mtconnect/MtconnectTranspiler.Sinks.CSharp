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
			ReferenceAgentArchitecturePackage,
			DevelopmentProcessPackage,
			SupportingDocumentsPackage,
			WIP_DeviceExamplesPackage,
			MTConnectDeviceValidationSuitePackage,
			InterfaceInteractionModelPackage,
			DeviceInformationModelPackage,
			ImportsPackage,
			WIP_UseCasesPackage,
			DataTypesPackage,
			StereotypesPackage,
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

		private static ReferenceAgentArchitecturePackage _ReferenceAgentArchitecturePackage;
	/// <summary>
	/// <ineritdoc cref="Mtconnect.ReferenceAgentArchitecturePackage" path="/summary" />
	/// </summary>
	public static ReferenceAgentArchitecturePackage ReferenceAgentArchitecturePackage => _ReferenceAgentArchitecturePackage ?? (_ReferenceAgentArchitecturePackage = new ReferenceAgentArchitecturePackage());

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

		private static WIP_DeviceExamplesPackage _WIP_DeviceExamplesPackage;
	/// <summary>
	/// <ineritdoc cref="Mtconnect.WIP_DeviceExamplesPackage" path="/summary" />
	/// </summary>
	public static WIP_DeviceExamplesPackage WIP_DeviceExamplesPackage => _WIP_DeviceExamplesPackage ?? (_WIP_DeviceExamplesPackage = new WIP_DeviceExamplesPackage());

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

		private static WIP_UseCasesPackage _WIP_UseCasesPackage;
	/// <summary>
	/// <ineritdoc cref="Mtconnect.WIP_UseCasesPackage" path="/summary" />
	/// </summary>
	public static WIP_UseCasesPackage WIP_UseCasesPackage => _WIP_UseCasesPackage ?? (_WIP_UseCasesPackage = new WIP_UseCasesPackage());

		private static DataTypesPackage _DataTypesPackage;
	/// <summary>
	/// <ineritdoc cref="Mtconnect.DataTypesPackage" path="/summary" />
	/// </summary>
	public static DataTypesPackage DataTypesPackage => _DataTypesPackage ?? (_DataTypesPackage = new DataTypesPackage());

		private static StereotypesPackage _StereotypesPackage;
	/// <summary>
	/// <ineritdoc cref="Mtconnect.StereotypesPackage" path="/summary" />
	/// </summary>
	public static StereotypesPackage StereotypesPackage => _StereotypesPackage ?? (_StereotypesPackage = new StereotypesPackage());

		#endregion
	}
}