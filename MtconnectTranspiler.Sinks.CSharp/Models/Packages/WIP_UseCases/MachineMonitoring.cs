#pragma warning disable CS1574 // XML comment has cref attribute that could not be resolved
#pragma warning disable CS1584 // XML comment has syntactically incorrect cref attribute
#pragma warning disable CS0618 // Type or member is obsolete
using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;
using Package = Mtconnect.WIP_UseCases.MachineMonitoring;

namespace Mtconnect.WIP_UseCases
{
	/// <summary>﻿
	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Package___19_0_3_68e0225_1702396421910_311633_28">model.mtconnect.org</seealso> for more information.
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public class MachineMonitoringPackage : IPackage
	{
		/// <summary>Constant value for <see cref="MachineMonitoringPackage.ReferenceId" /></summary>
		public const string REFERENCE_ID = "_19_0_3_68e0225_1702396421910_311633_28";
		/// <summary>Constant value for <see cref="MachineMonitoringPackage.HelpUrl" /></summary>
		public const string HELP_URL = "https://model.mtconnect.org/#Package___19_0_3_68e0225_1702396421910_311633_28";
		/// <summary>Constant value for <see cref="MachineMonitoringPackage.Name" /></summary>
		public const string NAME = "Machine Monitoring";
		/// <summary>Constant value for <see cref="MachineMonitoringPackage.Summary" /></summary>
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
			RequirementsPackage,
			UseCasesPackage,
		};
		
		/// <inheritdoc />
		public IClass[] Classes => new IClass[] {
			ManufacturingEquipmentClass,
			MTConnectDeviceWithOperationalStatesClass,
		};
		
		/// <inheritdoc />
		public IEnum[] Enums => new IEnum[] {
		};

		#region Packages
	private Package.RequirementsPackage _RequirementsPackage;
	/// <summary>
	/// <inheritdoc cref="Package.RequirementsPackage" path="/summary" />
	/// </summary>
	public Package.RequirementsPackage RequirementsPackage => _RequirementsPackage ?? (_RequirementsPackage = new Package.RequirementsPackage());

	private Package.UseCasesPackage _UseCasesPackage;
	/// <summary>
	/// <inheritdoc cref="Package.UseCasesPackage" path="/summary" />
	/// </summary>
	public Package.UseCasesPackage UseCasesPackage => _UseCasesPackage ?? (_UseCasesPackage = new Package.UseCasesPackage());

	#endregion

	#region Classes
	private Package.ManufacturingEquipmentClass _ManufacturingEquipmentClass;
	/// <summary>
	/// <inheritdoc cref="Package.ManufacturingEquipmentClass" path="/summary" />
	/// </summary>
	public Package.ManufacturingEquipmentClass ManufacturingEquipmentClass => _ManufacturingEquipmentClass ?? (_ManufacturingEquipmentClass = new Package.ManufacturingEquipmentClass());

	private Package.MTConnectDeviceWithOperationalStatesClass _MTConnectDeviceWithOperationalStatesClass;
	/// <summary>
	/// <inheritdoc cref="Package.MTConnectDeviceWithOperationalStatesClass" path="/summary" />
	/// </summary>
	public Package.MTConnectDeviceWithOperationalStatesClass MTConnectDeviceWithOperationalStatesClass => _MTConnectDeviceWithOperationalStatesClass ?? (_MTConnectDeviceWithOperationalStatesClass = new Package.MTConnectDeviceWithOperationalStatesClass());

	#endregion

	#region Enums
	#endregion
	}
}