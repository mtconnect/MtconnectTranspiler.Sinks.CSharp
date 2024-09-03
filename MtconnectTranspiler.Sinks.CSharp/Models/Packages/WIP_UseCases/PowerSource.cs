#pragma warning disable CS1574 // XML comment has cref attribute that could not be resolved
#pragma warning disable CS1584 // XML comment has syntactically incorrect cref attribute
#pragma warning disable CS0618 // Type or member is obsolete
using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;
using Package = Mtconnect.WIP_UseCases.PowerSource;

namespace Mtconnect.WIP_UseCases
{
	/// <summary>﻿
	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Package___19_0_3_68e0225_1702476290341_54831_73">model.mtconnect.org</seealso> for more information.
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public class PowerSourcePackage : IPackage
	{
		/// <summary>Constant value for <see cref="PowerSourcePackage.ReferenceId" /></summary>
		public const string REFERENCE_ID = "_19_0_3_68e0225_1702476290341_54831_73";
		/// <summary>Constant value for <see cref="PowerSourcePackage.HelpUrl" /></summary>
		public const string HELP_URL = "https://model.mtconnect.org/#Package___19_0_3_68e0225_1702476290341_54831_73";
		/// <summary>Constant value for <see cref="PowerSourcePackage.Name" /></summary>
		public const string NAME = "Power Source";
		/// <summary>Constant value for <see cref="PowerSourcePackage.Summary" /></summary>
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
			MTConnectDeviceWithPowerSourceConfigClass,
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

	private Package.MTConnectDeviceWithPowerSourceConfigClass _MTConnectDeviceWithPowerSourceConfigClass;
	/// <summary>
	/// <inheritdoc cref="Package.MTConnectDeviceWithPowerSourceConfigClass" path="/summary" />
	/// </summary>
	public Package.MTConnectDeviceWithPowerSourceConfigClass MTConnectDeviceWithPowerSourceConfigClass => _MTConnectDeviceWithPowerSourceConfigClass ?? (_MTConnectDeviceWithPowerSourceConfigClass = new Package.MTConnectDeviceWithPowerSourceConfigClass());

	#endregion

	#region Enums
	#endregion
	}
}