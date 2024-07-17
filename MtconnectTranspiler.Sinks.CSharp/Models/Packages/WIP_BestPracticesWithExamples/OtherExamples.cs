using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;
using Package = Mtconnect.WIP_BestPracticesWithExamples.OtherExamples;

namespace Mtconnect.WIP_BestPracticesWithExamples {
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "1.0.15.3")]
	public class OtherExamplesPackage : IPackage {
		public IPackage[] Packages => new IPackage[] {
			PocketNCPackage,
			KinematicsSimulationPackage,
			MillW_PER_SmoothGPackage,
		};

		public IClass[] Classes => new IClass[] {
		};
	private Package.PocketNCPackage _PocketNCPackage;
	public Package.PocketNCPackage PocketNCPackage => _PocketNCPackage ?? (_PocketNCPackage = new Package.PocketNCPackage());
	private Package.KinematicsSimulationPackage _KinematicsSimulationPackage;
	public Package.KinematicsSimulationPackage KinematicsSimulationPackage => _KinematicsSimulationPackage ?? (_KinematicsSimulationPackage = new Package.KinematicsSimulationPackage());
	private Package.MillW_PER_SmoothGPackage _MillW_PER_SmoothGPackage;
	public Package.MillW_PER_SmoothGPackage MillW_PER_SmoothGPackage => _MillW_PER_SmoothGPackage ?? (_MillW_PER_SmoothGPackage = new Package.MillW_PER_SmoothGPackage());

	}
}