using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;
using Package = Mtconnect.WIP_BestPracticesWithExamples.OtherExamples.KinematicsSimulation;
// using Mtconnect;

namespace Mtconnect.WIP_BestPracticesWithExamples.OtherExamples
{
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.3.0.0")]
	public class KinematicsSimulationPackage : IPackage
	{
		/// <inheritdoc />
		public string ReferenceId => "EAPK_C2851860_6C4E_4c7a_AABF_D7D01EA6F98D";
		
		/// <inheritdoc />
		public string Name => "KinematicsSimulation";

		/// <inheritdoc />
		public string Summary => @"";

		/// <inheritdoc />
		public IPackage[] Packages => new IPackage[] {
			SimulationPackage,
			XArm7ModelPackage,
			XArm7InstancePackage,
		};
		
		/// <inheritdoc />
		public IClass[] Classes => new IClass[] {
			Robot7axesClass,
		};
		#region Packages
	private Package.SimulationPackage _SimulationPackage;
	/// <summary>
	/// <inheritdoc cref="Package.SimulationPackage" path="/summary" />
	/// </summary>
	public Package.SimulationPackage SimulationPackage => _SimulationPackage ?? (_SimulationPackage = new Package.SimulationPackage());

	private Package.XArm7ModelPackage _XArm7ModelPackage;
	/// <summary>
	/// <inheritdoc cref="Package.XArm7ModelPackage" path="/summary" />
	/// </summary>
	public Package.XArm7ModelPackage XArm7ModelPackage => _XArm7ModelPackage ?? (_XArm7ModelPackage = new Package.XArm7ModelPackage());

	private Package.XArm7InstancePackage _XArm7InstancePackage;
	/// <summary>
	/// <inheritdoc cref="Package.XArm7InstancePackage" path="/summary" />
	/// </summary>
	public Package.XArm7InstancePackage XArm7InstancePackage => _XArm7InstancePackage ?? (_XArm7InstancePackage = new Package.XArm7InstancePackage());

	#endregion

	#region Classes
	private Package.Robot7axesClass _Robot7axesClass;
	/// <summary>
	/// <inheritdoc cref="Package.Robot7axesClass" path="/summary" />
	/// </summary>
	public Package.Robot7axesClass Robot7axesClass => _Robot7axesClass ?? (_Robot7axesClass = new Package.Robot7axesClass());

	#endregion
	}
}