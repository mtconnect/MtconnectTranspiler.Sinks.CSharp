#pragma warning disable CS1574 // XML comment has cref attribute that could not be resolved
#pragma warning disable CS1584 // XML comment has syntactically incorrect cref attribute
#pragma warning disable CS0618 // Type or member is obsolete
using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;
using Package = Mtconnect.WIP_UseCases;

namespace Mtconnect
{
	/// <summary>﻿
	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Package___19_0_3_68e0225_1702396340324_876240_24">model.mtconnect.org</seealso> for more information.
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public class WIP_UseCasesPackage : IPackage
	{
		/// <summary>Constant value for <see cref="WIP_UseCasesPackage.ReferenceId" /></summary>
		public const string REFERENCE_ID = "_19_0_3_68e0225_1702396340324_876240_24";
		/// <summary>Constant value for <see cref="WIP_UseCasesPackage.HelpUrl" /></summary>
		public const string HELP_URL = "https://model.mtconnect.org/#Package___19_0_3_68e0225_1702396340324_876240_24";
		/// <summary>Constant value for <see cref="WIP_UseCasesPackage.Name" /></summary>
		public const string NAME = "WIP: Use Cases";
		/// <summary>Constant value for <see cref="WIP_UseCasesPackage.Summary" /></summary>
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
			MachineMonitoringPackage,
			ActorsPackage,
			PowerSourcePackage,
		};
		
		/// <inheritdoc />
		public IClass[] Classes => new IClass[] {
		};
		
		/// <inheritdoc />
		public IEnum[] Enums => new IEnum[] {
		};

		#region Packages
	private Package.MachineMonitoringPackage _MachineMonitoringPackage;
	/// <summary>
	/// <inheritdoc cref="Package.MachineMonitoringPackage" path="/summary" />
	/// </summary>
	public Package.MachineMonitoringPackage MachineMonitoringPackage => _MachineMonitoringPackage ?? (_MachineMonitoringPackage = new Package.MachineMonitoringPackage());

	private Package.ActorsPackage _ActorsPackage;
	/// <summary>
	/// <inheritdoc cref="Package.ActorsPackage" path="/summary" />
	/// </summary>
	public Package.ActorsPackage ActorsPackage => _ActorsPackage ?? (_ActorsPackage = new Package.ActorsPackage());

	private Package.PowerSourcePackage _PowerSourcePackage;
	/// <summary>
	/// <inheritdoc cref="Package.PowerSourcePackage" path="/summary" />
	/// </summary>
	public Package.PowerSourcePackage PowerSourcePackage => _PowerSourcePackage ?? (_PowerSourcePackage = new Package.PowerSourcePackage());

	#endregion

	#region Classes
	#endregion

	#region Enums
	#endregion
	}
}