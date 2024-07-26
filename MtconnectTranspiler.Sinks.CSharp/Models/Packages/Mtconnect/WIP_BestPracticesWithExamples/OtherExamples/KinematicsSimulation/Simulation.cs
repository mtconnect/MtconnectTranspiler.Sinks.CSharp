
using System;
using System.CodeDom.Compiler;
using Package = Mtconnect.WIP_BestPracticesWithExamples.OtherExamples.KinematicsSimulation.Simulation;

using Mtconnect;

namespace Mtconnect.WIP_BestPracticesWithExamples.OtherExamples.KinematicsSimulation {
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "1.0.15.3")]
	public class SimulationPackage {


	private Package.KinematicsClass _Kinematics;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.KinematicsClass Kinematics => _Kinematics ?? (_Kinematics = new Package.KinematicsClass());
	}
}