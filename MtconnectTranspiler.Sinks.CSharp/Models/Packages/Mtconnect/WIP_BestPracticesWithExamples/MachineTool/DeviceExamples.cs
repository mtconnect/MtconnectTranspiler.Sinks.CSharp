
using System;
using System.CodeDom.Compiler;
using Package = Mtconnect.WIP_BestPracticesWithExamples.MachineTool.DeviceExamples;


namespace Mtconnect.WIP_BestPracticesWithExamples.MachineTool {
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "1.0.15.3")]
	public class DeviceExamplesPackage {

	private Package.OperationalStatePackage _OperationalStatePackage;
	public Package.OperationalStatePackage OperationalStatePackage => _OperationalStatePackage ?? (_OperationalStatePackage = new Package.OperationalStatePackage());

	}
}