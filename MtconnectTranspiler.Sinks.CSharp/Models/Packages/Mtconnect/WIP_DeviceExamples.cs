#pragma warning disable CS1574 // XML comment has cref attribute that could not be resolved
#pragma warning disable CS1584 // XML comment has syntactically incorrect cref attribute
#pragma warning disable CS0618 // Type or member is obsolete
using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;
using Package = Mtconnect.WIP_DeviceExamples;

namespace Mtconnect
{
	/// <summary>﻿
	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Package___19_0_3_68e0225_1620229279383_649426_1067">model.mtconnect.org</seealso> for more information.
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public class WIP_DeviceExamplesPackage : IPackage
	{
		/// <summary>Constant value for <see cref="WIP_DeviceExamplesPackage.ReferenceId" /></summary>
		public const string REFERENCE_ID = "_19_0_3_68e0225_1620229279383_649426_1067";
		/// <summary>Constant value for <see cref="WIP_DeviceExamplesPackage.HelpUrl" /></summary>
		public const string HELP_URL = "https://model.mtconnect.org/#Package___19_0_3_68e0225_1620229279383_649426_1067";
		/// <summary>Constant value for <see cref="WIP_DeviceExamplesPackage.Name" /></summary>
		public const string NAME = "WIP: Device Examples";
		/// <summary>Constant value for <see cref="WIP_DeviceExamplesPackage.Summary" /></summary>
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
			PocketNCPackage,
			KinematicsSimulationPackage,
			MillW_PER_SmoothGPackage,
		};
		
		/// <inheritdoc />
		public IClass[] Classes => new IClass[] {
		};
		
		/// <inheritdoc />
		public IEnum[] Enums => new IEnum[] {
		};

		#region Packages
	private Package.PocketNCPackage _PocketNCPackage;
	/// <summary>
	/// <inheritdoc cref="Package.PocketNCPackage" path="/summary" />
	/// </summary>
	public Package.PocketNCPackage PocketNCPackage => _PocketNCPackage ?? (_PocketNCPackage = new Package.PocketNCPackage());

	private Package.KinematicsSimulationPackage _KinematicsSimulationPackage;
	/// <summary>
	/// <inheritdoc cref="Package.KinematicsSimulationPackage" path="/summary" />
	/// </summary>
	public Package.KinematicsSimulationPackage KinematicsSimulationPackage => _KinematicsSimulationPackage ?? (_KinematicsSimulationPackage = new Package.KinematicsSimulationPackage());

	private Package.MillW_PER_SmoothGPackage _MillW_PER_SmoothGPackage;
	/// <summary>
	/// <inheritdoc cref="Package.MillW_PER_SmoothGPackage" path="/summary" />
	/// </summary>
	public Package.MillW_PER_SmoothGPackage MillW_PER_SmoothGPackage => _MillW_PER_SmoothGPackage ?? (_MillW_PER_SmoothGPackage = new Package.MillW_PER_SmoothGPackage());

	#endregion

	#region Classes
	#endregion

	#region Enums
	#endregion
	}
}