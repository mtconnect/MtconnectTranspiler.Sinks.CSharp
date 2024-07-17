using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;
using Package = Mtconnect.WIP_BestPracticesWithExamples.MachineTool;

namespace Mtconnect.WIP_BestPracticesWithExamples {
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "1.0.15.3")]
	public class MachineToolPackage : IPackage {
		public IPackage[] Packages => new IPackage[] {
			DeviceExamplesPackage,
		};

		public IClass[] Classes => new IClass[] {
		};
	private Package.DeviceExamplesPackage _DeviceExamplesPackage;
	public Package.DeviceExamplesPackage DeviceExamplesPackage => _DeviceExamplesPackage ?? (_DeviceExamplesPackage = new Package.DeviceExamplesPackage());

	}
}