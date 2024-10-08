#pragma warning disable CS1574 // XML comment has cref attribute that could not be resolved
#pragma warning disable CS1584 // XML comment has syntactically incorrect cref attribute
#pragma warning disable CS0618 // Type or member is obsolete
using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;
using Package = Mtconnect.Imports.UnitImports.BasicUnits;

namespace Mtconnect.Imports.UnitImports
{
	/// <summary>﻿
	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Package___19_0_3_45f01b9_1579105790699_574141_162915">model.mtconnect.org</seealso> for more information.
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public class BasicUnitsPackage : IPackage
	{
		/// <summary>Constant value for <see cref="BasicUnitsPackage.ReferenceId" /></summary>
		public const string REFERENCE_ID = "_19_0_3_45f01b9_1579105790699_574141_162915";
		/// <summary>Constant value for <see cref="BasicUnitsPackage.HelpUrl" /></summary>
		public const string HELP_URL = "https://model.mtconnect.org/#Package___19_0_3_45f01b9_1579105790699_574141_162915";
		/// <summary>Constant value for <see cref="BasicUnitsPackage.Name" /></summary>
		public const string NAME = "Basic Units";
		/// <summary>Constant value for <see cref="BasicUnitsPackage.Summary" /></summary>
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
			BasicLengthPackage,
			BasicMassPackage,
			BasicAreaPackage,
			BasicVolumePackage,
			BasicTimePackage,
			BasicElectricCurrentPackage,
			BasicThermodynamicTemperaturePackage,
			BasicAmountOfSubstancePackage,
			BasicLuminousIntensityPackage,
			BasicSpeedAndVelocityPackage,
			BasicAccelerationPackage,
			BasicMassDensityPackage,
			BasicElectricCurrentDensityPackage,
			BasicAmountOfSubstanceConcentrationPackage,
			BasicMagneticFieldStrengthPackage,
			BasicLuminancePackage,
		};
		
		/// <inheritdoc />
		public IClass[] Classes => new IClass[] {
		};
		
		/// <inheritdoc />
		public IEnum[] Enums => new IEnum[] {
		};

		#region Packages
	private Package.BasicLengthPackage _BasicLengthPackage;
	/// <summary>
	/// <inheritdoc cref="Package.BasicLengthPackage" path="/summary" />
	/// </summary>
	public Package.BasicLengthPackage BasicLengthPackage => _BasicLengthPackage ?? (_BasicLengthPackage = new Package.BasicLengthPackage());

	private Package.BasicMassPackage _BasicMassPackage;
	/// <summary>
	/// <inheritdoc cref="Package.BasicMassPackage" path="/summary" />
	/// </summary>
	public Package.BasicMassPackage BasicMassPackage => _BasicMassPackage ?? (_BasicMassPackage = new Package.BasicMassPackage());

	private Package.BasicAreaPackage _BasicAreaPackage;
	/// <summary>
	/// <inheritdoc cref="Package.BasicAreaPackage" path="/summary" />
	/// </summary>
	public Package.BasicAreaPackage BasicAreaPackage => _BasicAreaPackage ?? (_BasicAreaPackage = new Package.BasicAreaPackage());

	private Package.BasicVolumePackage _BasicVolumePackage;
	/// <summary>
	/// <inheritdoc cref="Package.BasicVolumePackage" path="/summary" />
	/// </summary>
	public Package.BasicVolumePackage BasicVolumePackage => _BasicVolumePackage ?? (_BasicVolumePackage = new Package.BasicVolumePackage());

	private Package.BasicTimePackage _BasicTimePackage;
	/// <summary>
	/// <inheritdoc cref="Package.BasicTimePackage" path="/summary" />
	/// </summary>
	public Package.BasicTimePackage BasicTimePackage => _BasicTimePackage ?? (_BasicTimePackage = new Package.BasicTimePackage());

	private Package.BasicElectricCurrentPackage _BasicElectricCurrentPackage;
	/// <summary>
	/// <inheritdoc cref="Package.BasicElectricCurrentPackage" path="/summary" />
	/// </summary>
	public Package.BasicElectricCurrentPackage BasicElectricCurrentPackage => _BasicElectricCurrentPackage ?? (_BasicElectricCurrentPackage = new Package.BasicElectricCurrentPackage());

	private Package.BasicThermodynamicTemperaturePackage _BasicThermodynamicTemperaturePackage;
	/// <summary>
	/// <inheritdoc cref="Package.BasicThermodynamicTemperaturePackage" path="/summary" />
	/// </summary>
	public Package.BasicThermodynamicTemperaturePackage BasicThermodynamicTemperaturePackage => _BasicThermodynamicTemperaturePackage ?? (_BasicThermodynamicTemperaturePackage = new Package.BasicThermodynamicTemperaturePackage());

	private Package.BasicAmountOfSubstancePackage _BasicAmountOfSubstancePackage;
	/// <summary>
	/// <inheritdoc cref="Package.BasicAmountOfSubstancePackage" path="/summary" />
	/// </summary>
	public Package.BasicAmountOfSubstancePackage BasicAmountOfSubstancePackage => _BasicAmountOfSubstancePackage ?? (_BasicAmountOfSubstancePackage = new Package.BasicAmountOfSubstancePackage());

	private Package.BasicLuminousIntensityPackage _BasicLuminousIntensityPackage;
	/// <summary>
	/// <inheritdoc cref="Package.BasicLuminousIntensityPackage" path="/summary" />
	/// </summary>
	public Package.BasicLuminousIntensityPackage BasicLuminousIntensityPackage => _BasicLuminousIntensityPackage ?? (_BasicLuminousIntensityPackage = new Package.BasicLuminousIntensityPackage());

	private Package.BasicSpeedAndVelocityPackage _BasicSpeedAndVelocityPackage;
	/// <summary>
	/// <inheritdoc cref="Package.BasicSpeedAndVelocityPackage" path="/summary" />
	/// </summary>
	public Package.BasicSpeedAndVelocityPackage BasicSpeedAndVelocityPackage => _BasicSpeedAndVelocityPackage ?? (_BasicSpeedAndVelocityPackage = new Package.BasicSpeedAndVelocityPackage());

	private Package.BasicAccelerationPackage _BasicAccelerationPackage;
	/// <summary>
	/// <inheritdoc cref="Package.BasicAccelerationPackage" path="/summary" />
	/// </summary>
	public Package.BasicAccelerationPackage BasicAccelerationPackage => _BasicAccelerationPackage ?? (_BasicAccelerationPackage = new Package.BasicAccelerationPackage());

	private Package.BasicMassDensityPackage _BasicMassDensityPackage;
	/// <summary>
	/// <inheritdoc cref="Package.BasicMassDensityPackage" path="/summary" />
	/// </summary>
	public Package.BasicMassDensityPackage BasicMassDensityPackage => _BasicMassDensityPackage ?? (_BasicMassDensityPackage = new Package.BasicMassDensityPackage());

	private Package.BasicElectricCurrentDensityPackage _BasicElectricCurrentDensityPackage;
	/// <summary>
	/// <inheritdoc cref="Package.BasicElectricCurrentDensityPackage" path="/summary" />
	/// </summary>
	public Package.BasicElectricCurrentDensityPackage BasicElectricCurrentDensityPackage => _BasicElectricCurrentDensityPackage ?? (_BasicElectricCurrentDensityPackage = new Package.BasicElectricCurrentDensityPackage());

	private Package.BasicAmountOfSubstanceConcentrationPackage _BasicAmountOfSubstanceConcentrationPackage;
	/// <summary>
	/// <inheritdoc cref="Package.BasicAmountOfSubstanceConcentrationPackage" path="/summary" />
	/// </summary>
	public Package.BasicAmountOfSubstanceConcentrationPackage BasicAmountOfSubstanceConcentrationPackage => _BasicAmountOfSubstanceConcentrationPackage ?? (_BasicAmountOfSubstanceConcentrationPackage = new Package.BasicAmountOfSubstanceConcentrationPackage());

	private Package.BasicMagneticFieldStrengthPackage _BasicMagneticFieldStrengthPackage;
	/// <summary>
	/// <inheritdoc cref="Package.BasicMagneticFieldStrengthPackage" path="/summary" />
	/// </summary>
	public Package.BasicMagneticFieldStrengthPackage BasicMagneticFieldStrengthPackage => _BasicMagneticFieldStrengthPackage ?? (_BasicMagneticFieldStrengthPackage = new Package.BasicMagneticFieldStrengthPackage());

	private Package.BasicLuminancePackage _BasicLuminancePackage;
	/// <summary>
	/// <inheritdoc cref="Package.BasicLuminancePackage" path="/summary" />
	/// </summary>
	public Package.BasicLuminancePackage BasicLuminancePackage => _BasicLuminancePackage ?? (_BasicLuminancePackage = new Package.BasicLuminancePackage());

	#endregion

	#region Classes
	#endregion

	#region Enums
	#endregion
	}
}