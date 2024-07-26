
using System;
using System.CodeDom.Compiler;
using Package = Mtconnect.WIP_BestPracticesWithExamples.OtherExamples.KinematicsSimulation;

using Mtconnect;

namespace Mtconnect.WIP_BestPracticesWithExamples.OtherExamples {
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "1.0.15.3")]
	public class KinematicsSimulationPackage {

	private Package.SimulationPackage _SimulationPackage;
	public Package.SimulationPackage SimulationPackage => _SimulationPackage ?? (_SimulationPackage = new Package.SimulationPackage());

	private Package.XArm7ModelPackage _XArm7ModelPackage;
	public Package.XArm7ModelPackage XArm7ModelPackage => _XArm7ModelPackage ?? (_XArm7ModelPackage = new Package.XArm7ModelPackage());

	private Package.XArm7InstancePackage _XArm7InstancePackage;
	public Package.XArm7InstancePackage XArm7InstancePackage => _XArm7InstancePackage ?? (_XArm7InstancePackage = new Package.XArm7InstancePackage());


	private Package.Robot7axesClass _Robot7axes;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.Robot7axesClass Robot7axes => _Robot7axes ?? (_Robot7axes = new Package.Robot7axesClass());
	}
}