#pragma warning disable CS1574 // XML comment has cref attribute that could not be resolved
#pragma warning disable CS1584 // XML comment has syntactically incorrect cref attribute
#pragma warning disable CS0618 // Type or member is obsolete
using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;
using Package = Mtconnect.WIP_UseCases.MachineMonitoring.Requirements;

namespace Mtconnect.WIP_UseCases.MachineMonitoring
{
	/// <summary>﻿
	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Package___19_0_3_68e0225_1702299138734_709411_320">model.mtconnect.org</seealso> for more information.
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public class RequirementsPackage : IPackage
	{
		/// <summary>Constant value for <see cref="RequirementsPackage.ReferenceId" /></summary>
		public const string REFERENCE_ID = "_19_0_3_68e0225_1702299138734_709411_320";
		/// <summary>Constant value for <see cref="RequirementsPackage.HelpUrl" /></summary>
		public const string HELP_URL = "https://model.mtconnect.org/#Package___19_0_3_68e0225_1702299138734_709411_320";
		/// <summary>Constant value for <see cref="RequirementsPackage.Name" /></summary>
		public const string NAME = "Requirements";
		/// <summary>Constant value for <see cref="RequirementsPackage.Summary" /></summary>
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
			OperationalStatesClass,
			DeviceUtilizationClass,
		};
		
		/// <inheritdoc />
		public IEnum[] Enums => new IEnum[] {
		};

		#region Packages
	#endregion

	#region Classes
	private Package.OperationalStatesClass _OperationalStatesClass;
	/// <summary>
	/// <inheritdoc cref="Package.OperationalStatesClass" path="/summary" />
	/// </summary>
	public Package.OperationalStatesClass OperationalStatesClass => _OperationalStatesClass ?? (_OperationalStatesClass = new Package.OperationalStatesClass());

	private Package.DeviceUtilizationClass _DeviceUtilizationClass;
	/// <summary>
	/// <inheritdoc cref="Package.DeviceUtilizationClass" path="/summary" />
	/// </summary>
	public Package.DeviceUtilizationClass DeviceUtilizationClass => _DeviceUtilizationClass ?? (_DeviceUtilizationClass = new Package.DeviceUtilizationClass());

	#endregion

	#region Enums
	#endregion
	}
}