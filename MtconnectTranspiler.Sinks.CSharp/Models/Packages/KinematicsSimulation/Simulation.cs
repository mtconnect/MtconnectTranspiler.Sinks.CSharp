using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;
using Package = Mtconnect.WIP_BestPracticesWithExamples.OtherExamples.KinematicsSimulation.Simulation;
// using Mtconnect;

namespace Mtconnect.WIP_BestPracticesWithExamples.OtherExamples.KinematicsSimulation {
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "1.0.15.3")]
	public class SimulationPackage : IPackage {
		public IPackage[] Packages => new IPackage[] {
		};

		public IClass[] Classes => new IClass[] {
			KinematicsClass,
		};

	private Package.KinematicsClass _KinematicsClass;
	public Package.KinematicsClass KinematicsClass => _KinematicsClass ?? (_KinematicsClass = new Package.KinematicsClass());
	}
}