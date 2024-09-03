#pragma warning disable CS1574 // XML comment has cref attribute that could not be resolved
#pragma warning disable CS1584 // XML comment has syntactically incorrect cref attribute
#pragma warning disable CS0618 // Type or member is obsolete
using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;
using Package = Mtconnect.WIP_DeviceExamples.KinematicsSimulation;

namespace Mtconnect.WIP_DeviceExamples
{
	/// <summary>﻿
	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Package__EAPK_C2851860_6C4E_4c7a_AABF_D7D01EA6F98D">model.mtconnect.org</seealso> for more information.
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public class KinematicsSimulationPackage : IPackage
	{
		/// <summary>Constant value for <see cref="KinematicsSimulationPackage.ReferenceId" /></summary>
		public const string REFERENCE_ID = "EAPK_C2851860_6C4E_4c7a_AABF_D7D01EA6F98D";
		/// <summary>Constant value for <see cref="KinematicsSimulationPackage.HelpUrl" /></summary>
		public const string HELP_URL = "https://model.mtconnect.org/#Package__EAPK_C2851860_6C4E_4c7a_AABF_D7D01EA6F98D";
		/// <summary>Constant value for <see cref="KinematicsSimulationPackage.Name" /></summary>
		public const string NAME = "Kinematics Simulation";
		/// <summary>Constant value for <see cref="KinematicsSimulationPackage.Summary" /></summary>
		public const string SUMMARY = @"";

		/// <inheritdoc />
		public string ReferenceId => REFERENCE_ID;
		
		/// <inheritdoc />
		public string HelpUrl => HELP_URL;
		
		/// <inheritdoc />
		public string Name => NAME;

		/// <inheritdoc />
		public string Summary => SUMMARY;

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
		
		/// <inheritdoc />
		public IEnum[] Enums => new IEnum[] {
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

	#region Enums
	#endregion
	}
}