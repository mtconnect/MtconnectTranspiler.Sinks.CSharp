using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;
using Package = Mtconnect.WIP_BestPracticesWithExamples.MachineTool.DeviceExamples.OperationalState;
// using Mtconnect;

namespace Mtconnect.WIP_BestPracticesWithExamples.MachineTool.DeviceExamples {
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "1.0.15.3")]
	public class OperationalStatePackage : IPackage {
		public IPackage[] Packages => new IPackage[] {
			UseCasesPackage,
			ActorsPackage,
		};

		public IClass[] Classes => new IClass[] {
			MTConnectDeviceWithOperationalStatesClass,
		};
	private Package.UseCasesPackage _UseCasesPackage;
	public Package.UseCasesPackage UseCasesPackage => _UseCasesPackage ?? (_UseCasesPackage = new Package.UseCasesPackage());
	private Package.ActorsPackage _ActorsPackage;
	public Package.ActorsPackage ActorsPackage => _ActorsPackage ?? (_ActorsPackage = new Package.ActorsPackage());

	private Package.MTConnectDeviceWithOperationalStatesClass _MTConnectDeviceWithOperationalStatesClass;
	public Package.MTConnectDeviceWithOperationalStatesClass MTConnectDeviceWithOperationalStatesClass => _MTConnectDeviceWithOperationalStatesClass ?? (_MTConnectDeviceWithOperationalStatesClass = new Package.MTConnectDeviceWithOperationalStatesClass());
	}
}