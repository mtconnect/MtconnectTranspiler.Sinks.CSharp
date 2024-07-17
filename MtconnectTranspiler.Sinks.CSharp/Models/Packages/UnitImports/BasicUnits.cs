using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;
using Package = Mtconnect.Imports.UnitImports.BasicUnits;

namespace Mtconnect.Imports.UnitImports {
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "1.0.15.3")]
	public class BasicUnitsPackage : IPackage {
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

		public IClass[] Classes => new IClass[] {
		};
	private Package.BasicLengthPackage _BasicLengthPackage;
	public Package.BasicLengthPackage BasicLengthPackage => _BasicLengthPackage ?? (_BasicLengthPackage = new Package.BasicLengthPackage());
	private Package.BasicMassPackage _BasicMassPackage;
	public Package.BasicMassPackage BasicMassPackage => _BasicMassPackage ?? (_BasicMassPackage = new Package.BasicMassPackage());
	private Package.BasicAreaPackage _BasicAreaPackage;
	public Package.BasicAreaPackage BasicAreaPackage => _BasicAreaPackage ?? (_BasicAreaPackage = new Package.BasicAreaPackage());
	private Package.BasicVolumePackage _BasicVolumePackage;
	public Package.BasicVolumePackage BasicVolumePackage => _BasicVolumePackage ?? (_BasicVolumePackage = new Package.BasicVolumePackage());
	private Package.BasicTimePackage _BasicTimePackage;
	public Package.BasicTimePackage BasicTimePackage => _BasicTimePackage ?? (_BasicTimePackage = new Package.BasicTimePackage());
	private Package.BasicElectricCurrentPackage _BasicElectricCurrentPackage;
	public Package.BasicElectricCurrentPackage BasicElectricCurrentPackage => _BasicElectricCurrentPackage ?? (_BasicElectricCurrentPackage = new Package.BasicElectricCurrentPackage());
	private Package.BasicThermodynamicTemperaturePackage _BasicThermodynamicTemperaturePackage;
	public Package.BasicThermodynamicTemperaturePackage BasicThermodynamicTemperaturePackage => _BasicThermodynamicTemperaturePackage ?? (_BasicThermodynamicTemperaturePackage = new Package.BasicThermodynamicTemperaturePackage());
	private Package.BasicAmountOfSubstancePackage _BasicAmountOfSubstancePackage;
	public Package.BasicAmountOfSubstancePackage BasicAmountOfSubstancePackage => _BasicAmountOfSubstancePackage ?? (_BasicAmountOfSubstancePackage = new Package.BasicAmountOfSubstancePackage());
	private Package.BasicLuminousIntensityPackage _BasicLuminousIntensityPackage;
	public Package.BasicLuminousIntensityPackage BasicLuminousIntensityPackage => _BasicLuminousIntensityPackage ?? (_BasicLuminousIntensityPackage = new Package.BasicLuminousIntensityPackage());
	private Package.BasicSpeedAndVelocityPackage _BasicSpeedAndVelocityPackage;
	public Package.BasicSpeedAndVelocityPackage BasicSpeedAndVelocityPackage => _BasicSpeedAndVelocityPackage ?? (_BasicSpeedAndVelocityPackage = new Package.BasicSpeedAndVelocityPackage());
	private Package.BasicAccelerationPackage _BasicAccelerationPackage;
	public Package.BasicAccelerationPackage BasicAccelerationPackage => _BasicAccelerationPackage ?? (_BasicAccelerationPackage = new Package.BasicAccelerationPackage());
	private Package.BasicMassDensityPackage _BasicMassDensityPackage;
	public Package.BasicMassDensityPackage BasicMassDensityPackage => _BasicMassDensityPackage ?? (_BasicMassDensityPackage = new Package.BasicMassDensityPackage());
	private Package.BasicElectricCurrentDensityPackage _BasicElectricCurrentDensityPackage;
	public Package.BasicElectricCurrentDensityPackage BasicElectricCurrentDensityPackage => _BasicElectricCurrentDensityPackage ?? (_BasicElectricCurrentDensityPackage = new Package.BasicElectricCurrentDensityPackage());
	private Package.BasicAmountOfSubstanceConcentrationPackage _BasicAmountOfSubstanceConcentrationPackage;
	public Package.BasicAmountOfSubstanceConcentrationPackage BasicAmountOfSubstanceConcentrationPackage => _BasicAmountOfSubstanceConcentrationPackage ?? (_BasicAmountOfSubstanceConcentrationPackage = new Package.BasicAmountOfSubstanceConcentrationPackage());
	private Package.BasicMagneticFieldStrengthPackage _BasicMagneticFieldStrengthPackage;
	public Package.BasicMagneticFieldStrengthPackage BasicMagneticFieldStrengthPackage => _BasicMagneticFieldStrengthPackage ?? (_BasicMagneticFieldStrengthPackage = new Package.BasicMagneticFieldStrengthPackage());
	private Package.BasicLuminancePackage _BasicLuminancePackage;
	public Package.BasicLuminancePackage BasicLuminancePackage => _BasicLuminancePackage ?? (_BasicLuminancePackage = new Package.BasicLuminancePackage());

	}
}