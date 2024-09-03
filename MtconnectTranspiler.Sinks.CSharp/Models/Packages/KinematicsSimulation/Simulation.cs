#pragma warning disable CS1574 // XML comment has cref attribute that could not be resolved
#pragma warning disable CS1584 // XML comment has syntactically incorrect cref attribute
#pragma warning disable CS0618 // Type or member is obsolete
using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;
using Package = Mtconnect.WIP_DeviceExamples.KinematicsSimulation.Simulation;

namespace Mtconnect.WIP_DeviceExamples.KinematicsSimulation
{
	/// <summary>﻿
	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Package___19_0_3_91b028d_1582232371587_1993_123">model.mtconnect.org</seealso> for more information.
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public class SimulationPackage : IPackage
	{
		/// <summary>Constant value for <see cref="SimulationPackage.ReferenceId" /></summary>
		public const string REFERENCE_ID = "_19_0_3_91b028d_1582232371587_1993_123";
		/// <summary>Constant value for <see cref="SimulationPackage.HelpUrl" /></summary>
		public const string HELP_URL = "https://model.mtconnect.org/#Package___19_0_3_91b028d_1582232371587_1993_123";
		/// <summary>Constant value for <see cref="SimulationPackage.Name" /></summary>
		public const string NAME = "Simulation";
		/// <summary>Constant value for <see cref="SimulationPackage.Summary" /></summary>
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