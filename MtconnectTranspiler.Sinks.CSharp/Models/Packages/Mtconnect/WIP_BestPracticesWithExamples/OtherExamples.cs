
using System;
using System.CodeDom.Compiler;
using Package = Mtconnect.WIP_BestPracticesWithExamples.OtherExamples;


namespace Mtconnect.WIP_BestPracticesWithExamples {
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "1.0.15.3")]
	public class OtherExamplesPackage {

	private Package.PocketNCPackage _PocketNCPackage;
	public Package.PocketNCPackage PocketNCPackage => _PocketNCPackage ?? (_PocketNCPackage = new Package.PocketNCPackage());

	private Package.KinematicsSimulationPackage _KinematicsSimulationPackage;
	public Package.KinematicsSimulationPackage KinematicsSimulationPackage => _KinematicsSimulationPackage ?? (_KinematicsSimulationPackage = new Package.KinematicsSimulationPackage());

	private Package.MillW_PER_SmoothGPackage _MillW_PER_SmoothGPackage;
	public Package.MillW_PER_SmoothGPackage MillW_PER_SmoothGPackage => _MillW_PER_SmoothGPackage ?? (_MillW_PER_SmoothGPackage = new Package.MillW_PER_SmoothGPackage());

	}
}