#pragma warning disable CS1574 // XML comment has cref attribute that could not be resolved
#pragma warning disable CS1584 // XML comment has syntactically incorrect cref attribute
using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;
using Package = Mtconnect.WIP_BestPracticesWithExamples.OtherExamples.KinematicsSimulation.Simulation;

namespace Mtconnect.WIP_BestPracticesWithExamples.OtherExamples.KinematicsSimulation
{
	/// <summary>﻿
	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Package___19_0_3_91b028d_1582232371587_1993_123">model.mtconnect.org</seealso> for more information.
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public class SimulationPackage : IPackage
	{
		/// <inheritdoc />
		public string ReferenceId => "_19_0_3_91b028d_1582232371587_1993_123";
		
		/// <inheritdoc />
		public string Name => "Simulation";

		/// <inheritdoc />
		public string Summary => @"";

		/// <inheritdoc />
		public IPackage[] Packages => new IPackage[] {
		};
		
		/// <inheritdoc />
		public IClass[] Classes => new IClass[] {
			KinematicsClass,
		};
		
		/// <inheritdoc />
		public IEnum[] Enums => new IEnum[] {
		};

		#region Packages
	#endregion

	#region Classes
	private Package.KinematicsClass _KinematicsClass;
	/// <summary>
	/// <inheritdoc cref="Package.KinematicsClass" path="/summary" />
	/// </summary>
	public Package.KinematicsClass KinematicsClass => _KinematicsClass ?? (_KinematicsClass = new Package.KinematicsClass());

	#endregion

	#region Enums
	#endregion
	}
}