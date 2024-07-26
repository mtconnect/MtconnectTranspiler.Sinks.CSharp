
using System;
using System.CodeDom.Compiler;
using Package = Mtconnect.WIP_BestPracticesWithExamples.MachineTool;


namespace Mtconnect.WIP_BestPracticesWithExamples {
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "1.0.15.3")]
	public class MachineToolPackage {

	private Package.DeviceExamplesPackage _DeviceExamplesPackage;
	public Package.DeviceExamplesPackage DeviceExamplesPackage => _DeviceExamplesPackage ?? (_DeviceExamplesPackage = new Package.DeviceExamplesPackage());

	}
}