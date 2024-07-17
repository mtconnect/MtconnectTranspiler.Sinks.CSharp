using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;
using Package = Mtconnect.ObservationInformationModel.ObservationTypes.SampleTypes;
// using Mtconnect;

namespace Mtconnect.ObservationInformationModel.ObservationTypes {
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "1.0.15.3")]
	public class SampleTypesPackage : IPackage {
		public IPackage[] Packages => new IPackage[] {
		};

		public IClass[] Classes => new IClass[] {
			AccelerationClass,
			AccumulatedTimeClass,
			AmperageClass,
			AmperageAlternatingClass,
			AmperageDirectClass,
			AmperageActualClass,
			AmperageTargetClass,
			AngleClass,
			AngleCommandedClass,
			AngleActualClass,
			AngularAccelerationClass,
			AngularVelocityClass,
			AxisFeedrateClass,
			AxisFeedrateActualClass,
			AxisFeedrateCommandedClass,
			AxisFeedrateJogClass,
			AxisFeedrateProgrammedClass,
			AxisFeedrateRapidClass,
			AxisFeedrateOverrideClass,
			CapacityFluidClass,
			CapacitySpatialClass,
			ConcentrationClass,
			ConductivityClass,
			CuttingSpeedClass,
			CuttingSpeedActualClass,
			CuttingSpeedCommandedClass,
			CuttingSpeedProgrammedClass,
			DensityClass,
			DepositionAccelerationVolumetricClass,
			DepositionAccelerationVolumetricActualClass,
			DepositionAccelerationVolumetricCommandedClass,
			DepositionDensityClass,
			DepositionDensityActualClass,
			DepositionDensityCommandedClass,
			DepositionMassClass,
			DepositionMassActualClass,
			DepositionMassCommandedClass,
			DepositionRateVolumetricClass,
			DepositionRateVolumetricActualClass,
			DepositionRateVolumetricCommandedClass,
			DepositionVolumeClass,
			DepositionVolumeActualClass,
			DepositionVolumeCommandedClass,
			DisplacementClass,
			ElectricalEnergyClass,
			EquipmentTimerClass,
			EquipmentTimerLoadedClass,
			EquipmentTimerWorkingClass,
			EquipmentTimerOperatingClass,
			EquipmentTimerPoweredClass,
			EquipmentTimerDelayClass,
			FillLevelClass,
			FlowClass,
			FrequencyClass,
			GlobalPositionClass,
			LengthClass,
			LengthStandardClass,
			LengthRemainingClass,
			LengthUseableClass,
			LevelClass,
			LinearForceClass,
			LoadClass,
			MassClass,
			PathFeedrateClass,
			PathFeedrateActualClass,
			PathFeedrateCommandedClass,
			PathFeedrateJogClass,
			PathFeedrateProgrammedClass,
			PathFeedrateRapidClass,
			PathFeedrateOverrideClass,
			PathFeedratePerRevolutionClass,
			PathFeedratePerRevolutionActualClass,
			PathFeedratePerRevolutionCommandedClass,
			PathFeedratePerRevolutionProgrammedClass,
			PathPositionClass,
			PathPositionActualClass,
			PathPositionCommandedClass,
			PathPositionTargetClass,
			PathPositionProbeClass,
			PHClass,
			PositionClass,
			PositionActualClass,
			PositionCommandedClass,
			PositionProgrammedClass,
			PositionTargetClass,
			PowerFactorClass,
			PressureClass,
			ProcessTimerClass,
			ProcessTimerProcessClass,
			ProcessTimerDelayClass,
			ResistanceClass,
			RotaryVelocityClass,
			RotaryVelocityActualClass,
			RotaryVelocityCommandedClass,
			RotaryVelocityProgrammedClass,
			RotaryVelocityOverrideClass,
			SoundLevelClass,
			SoundLevelNoScaleClass,
			SoundLevelAScaleClass,
			SoundLevelBScaleClass,
			SoundLevelCScaleClass,
			SoundLevelDScaleClass,
			SpindleSpeedClass,
			SpindleSpeedActualClass,
			SpindleSpeedCommandedClass,
			SpindleSpeedOverrideClass,
			StrainClass,
			TemperatureClass,
			TensionClass,
			TiltClass,
			TorqueClass,
			VelocityClass,
			ViscosityClass,
			VoltageClass,
			VoltageAlternatingClass,
			VoltageDirectClass,
			VoltageActualClass,
			VoltageTargetClass,
			VoltAmpereClass,
			VoltAmpereReactiveClass,
			VolumeFluidClass,
			VolumeFluidActualClass,
			VolumeFluidConsumedClass,
			VolumeSpatialClass,
			VolumeSpatialActualClass,
			VolumeSpatialConsumedClass,
			WattageClass,
			WattageActualClass,
			WattageTargetClass,
			AmperageDCClass,
			AmperageDCActualClass,
			AmperageDCCommandedClass,
			AmperageDCProgrammedClass,
			AmperageACClass,
			AmperageACActualClass,
			AmperageACCommandedClass,
			AmperageACProgrammedClass,
			VoltageACActualClass,
			VoltageACClass,
			VoltageACCommandedClass,
			VoltageACProgrammedClass,
			VoltageDCActualClass,
			VoltageDCCommandedClass,
			VoltageDCProgrammedClass,
			VoltageDCClass,
			XDimensionClass,
			YDimensionClass,
			ZDimensionClass,
			DiameterClass,
			OrientationActualClass,
			OrientationClass,
			OrientationCommandedClass,
			HumidityRelativeClass,
			HumidityRelativeCommandedClass,
			HumidityRelativeActualClass,
			HumidityAbsoluteClass,
			HumidityAbsoluteActualClass,
			HumidityAbsoluteCommandedClass,
			HumiditySpecificClass,
			HumiditySpecificActualClass,
			HumiditySpecificCommandedClass,
			AngularDecelerationActualClass,
			DecelerationProgrammedClass,
			AngularDecelerationProgrammedClass,
			PressurizationRateClass,
			AngularDecelerationCommandedClass,
			DecelerationClass,
			AssetUpdateRateClass,
			AngularDecelerationClass,
			ObservationUpdateRateClass,
			DecelerationCommandedClass,
			DecelerationActualClass,
			PressureAbsoluteClass,
			AccelerationActualClass,
			VolumeFluidPartClass,
			AngularAccelerationProgrammedClass,
			PressurizationRateCommandedClass,
			AccelerationProgrammedClass,
			AccelerationCommandedClass,
			VolumeFluidWasteClass,
			VolumeSpatialPartClass,
			VolumeFluidStartClass,
			AngularAccelerationActualClass,
			VolumeSpatialWasteClass,
			PressurizationRateActualClass,
			VolumeSpatialEndedClass,
			AngularAccelerationCommandedClass,
			PressurizationRateProgrammedClass,
			VolumeSpatialStartClass,
			VolumeFluidEndedClass,
			OpennessClass,
			GlobalPositionActualClass,
			GlobalPositionCommandedClass,
			DewPointClass,
			GravitationalForceClass,
			GravitationalAccelerationClass,
			BatteryCapacityClass,
			BatteryCapacityActualClass,
			BatteryCapacityTargetClass,
			DischargeRateClass,
			DischargeRateActualClass,
			DischargeRateTargetClass,
			ChargeRateClass,
			ChargeRateActualClass,
			ChargeRateTargetClass,
			BatteryChargeClass,
			BatteryChargeActualClass,
			BatteryChargeTargetClass,
			SettlingErrorClass,
			SettlingErrorActualClass,
			SettlingErrorLinearClass,
			SettlingErrorLinearActualClass,
			SettlingErrorAngularClass,
			SettlingErrorAngularActualClass,
			FollowingErrorClass,
			FollowingErrorActualClass,
			FollowingErrorAngularClass,
			FollowingErrorLinearClass,
			FollowingErrorAngularActualClass,
			FollowingErrorLinearActualClass,
			DisplacementLinearClass,
			DisplacementAngularClass,
			PositionCartesianClass,
		};

	private Package.AccelerationClass _AccelerationClass;
	public Package.AccelerationClass AccelerationClass => _AccelerationClass ?? (_AccelerationClass = new Package.AccelerationClass());
	private Package.AccumulatedTimeClass _AccumulatedTimeClass;
	public Package.AccumulatedTimeClass AccumulatedTimeClass => _AccumulatedTimeClass ?? (_AccumulatedTimeClass = new Package.AccumulatedTimeClass());
	private Package.AmperageClass _AmperageClass;
	public Package.AmperageClass AmperageClass => _AmperageClass ?? (_AmperageClass = new Package.AmperageClass());
	private Package.AmperageAlternatingClass _AmperageAlternatingClass;
	public Package.AmperageAlternatingClass AmperageAlternatingClass => _AmperageAlternatingClass ?? (_AmperageAlternatingClass = new Package.AmperageAlternatingClass());
	private Package.AmperageDirectClass _AmperageDirectClass;
	public Package.AmperageDirectClass AmperageDirectClass => _AmperageDirectClass ?? (_AmperageDirectClass = new Package.AmperageDirectClass());
	private Package.AmperageActualClass _AmperageActualClass;
	public Package.AmperageActualClass AmperageActualClass => _AmperageActualClass ?? (_AmperageActualClass = new Package.AmperageActualClass());
	private Package.AmperageTargetClass _AmperageTargetClass;
	public Package.AmperageTargetClass AmperageTargetClass => _AmperageTargetClass ?? (_AmperageTargetClass = new Package.AmperageTargetClass());
	private Package.AngleClass _AngleClass;
	public Package.AngleClass AngleClass => _AngleClass ?? (_AngleClass = new Package.AngleClass());
	private Package.AngleCommandedClass _AngleCommandedClass;
	public Package.AngleCommandedClass AngleCommandedClass => _AngleCommandedClass ?? (_AngleCommandedClass = new Package.AngleCommandedClass());
	private Package.AngleActualClass _AngleActualClass;
	public Package.AngleActualClass AngleActualClass => _AngleActualClass ?? (_AngleActualClass = new Package.AngleActualClass());
	private Package.AngularAccelerationClass _AngularAccelerationClass;
	public Package.AngularAccelerationClass AngularAccelerationClass => _AngularAccelerationClass ?? (_AngularAccelerationClass = new Package.AngularAccelerationClass());
	private Package.AngularVelocityClass _AngularVelocityClass;
	public Package.AngularVelocityClass AngularVelocityClass => _AngularVelocityClass ?? (_AngularVelocityClass = new Package.AngularVelocityClass());
	private Package.AxisFeedrateClass _AxisFeedrateClass;
	public Package.AxisFeedrateClass AxisFeedrateClass => _AxisFeedrateClass ?? (_AxisFeedrateClass = new Package.AxisFeedrateClass());
	private Package.AxisFeedrateActualClass _AxisFeedrateActualClass;
	public Package.AxisFeedrateActualClass AxisFeedrateActualClass => _AxisFeedrateActualClass ?? (_AxisFeedrateActualClass = new Package.AxisFeedrateActualClass());
	private Package.AxisFeedrateCommandedClass _AxisFeedrateCommandedClass;
	public Package.AxisFeedrateCommandedClass AxisFeedrateCommandedClass => _AxisFeedrateCommandedClass ?? (_AxisFeedrateCommandedClass = new Package.AxisFeedrateCommandedClass());
	private Package.AxisFeedrateJogClass _AxisFeedrateJogClass;
	public Package.AxisFeedrateJogClass AxisFeedrateJogClass => _AxisFeedrateJogClass ?? (_AxisFeedrateJogClass = new Package.AxisFeedrateJogClass());
	private Package.AxisFeedrateProgrammedClass _AxisFeedrateProgrammedClass;
	public Package.AxisFeedrateProgrammedClass AxisFeedrateProgrammedClass => _AxisFeedrateProgrammedClass ?? (_AxisFeedrateProgrammedClass = new Package.AxisFeedrateProgrammedClass());
	private Package.AxisFeedrateRapidClass _AxisFeedrateRapidClass;
	public Package.AxisFeedrateRapidClass AxisFeedrateRapidClass => _AxisFeedrateRapidClass ?? (_AxisFeedrateRapidClass = new Package.AxisFeedrateRapidClass());
	private Package.AxisFeedrateOverrideClass _AxisFeedrateOverrideClass;
	public Package.AxisFeedrateOverrideClass AxisFeedrateOverrideClass => _AxisFeedrateOverrideClass ?? (_AxisFeedrateOverrideClass = new Package.AxisFeedrateOverrideClass());
	private Package.CapacityFluidClass _CapacityFluidClass;
	public Package.CapacityFluidClass CapacityFluidClass => _CapacityFluidClass ?? (_CapacityFluidClass = new Package.CapacityFluidClass());
	private Package.CapacitySpatialClass _CapacitySpatialClass;
	public Package.CapacitySpatialClass CapacitySpatialClass => _CapacitySpatialClass ?? (_CapacitySpatialClass = new Package.CapacitySpatialClass());
	private Package.ConcentrationClass _ConcentrationClass;
	public Package.ConcentrationClass ConcentrationClass => _ConcentrationClass ?? (_ConcentrationClass = new Package.ConcentrationClass());
	private Package.ConductivityClass _ConductivityClass;
	public Package.ConductivityClass ConductivityClass => _ConductivityClass ?? (_ConductivityClass = new Package.ConductivityClass());
	private Package.CuttingSpeedClass _CuttingSpeedClass;
	public Package.CuttingSpeedClass CuttingSpeedClass => _CuttingSpeedClass ?? (_CuttingSpeedClass = new Package.CuttingSpeedClass());
	private Package.CuttingSpeedActualClass _CuttingSpeedActualClass;
	public Package.CuttingSpeedActualClass CuttingSpeedActualClass => _CuttingSpeedActualClass ?? (_CuttingSpeedActualClass = new Package.CuttingSpeedActualClass());
	private Package.CuttingSpeedCommandedClass _CuttingSpeedCommandedClass;
	public Package.CuttingSpeedCommandedClass CuttingSpeedCommandedClass => _CuttingSpeedCommandedClass ?? (_CuttingSpeedCommandedClass = new Package.CuttingSpeedCommandedClass());
	private Package.CuttingSpeedProgrammedClass _CuttingSpeedProgrammedClass;
	public Package.CuttingSpeedProgrammedClass CuttingSpeedProgrammedClass => _CuttingSpeedProgrammedClass ?? (_CuttingSpeedProgrammedClass = new Package.CuttingSpeedProgrammedClass());
	private Package.DensityClass _DensityClass;
	public Package.DensityClass DensityClass => _DensityClass ?? (_DensityClass = new Package.DensityClass());
	private Package.DepositionAccelerationVolumetricClass _DepositionAccelerationVolumetricClass;
	public Package.DepositionAccelerationVolumetricClass DepositionAccelerationVolumetricClass => _DepositionAccelerationVolumetricClass ?? (_DepositionAccelerationVolumetricClass = new Package.DepositionAccelerationVolumetricClass());
	private Package.DepositionAccelerationVolumetricActualClass _DepositionAccelerationVolumetricActualClass;
	public Package.DepositionAccelerationVolumetricActualClass DepositionAccelerationVolumetricActualClass => _DepositionAccelerationVolumetricActualClass ?? (_DepositionAccelerationVolumetricActualClass = new Package.DepositionAccelerationVolumetricActualClass());
	private Package.DepositionAccelerationVolumetricCommandedClass _DepositionAccelerationVolumetricCommandedClass;
	public Package.DepositionAccelerationVolumetricCommandedClass DepositionAccelerationVolumetricCommandedClass => _DepositionAccelerationVolumetricCommandedClass ?? (_DepositionAccelerationVolumetricCommandedClass = new Package.DepositionAccelerationVolumetricCommandedClass());
	private Package.DepositionDensityClass _DepositionDensityClass;
	public Package.DepositionDensityClass DepositionDensityClass => _DepositionDensityClass ?? (_DepositionDensityClass = new Package.DepositionDensityClass());
	private Package.DepositionDensityActualClass _DepositionDensityActualClass;
	public Package.DepositionDensityActualClass DepositionDensityActualClass => _DepositionDensityActualClass ?? (_DepositionDensityActualClass = new Package.DepositionDensityActualClass());
	private Package.DepositionDensityCommandedClass _DepositionDensityCommandedClass;
	public Package.DepositionDensityCommandedClass DepositionDensityCommandedClass => _DepositionDensityCommandedClass ?? (_DepositionDensityCommandedClass = new Package.DepositionDensityCommandedClass());
	private Package.DepositionMassClass _DepositionMassClass;
	public Package.DepositionMassClass DepositionMassClass => _DepositionMassClass ?? (_DepositionMassClass = new Package.DepositionMassClass());
	private Package.DepositionMassActualClass _DepositionMassActualClass;
	public Package.DepositionMassActualClass DepositionMassActualClass => _DepositionMassActualClass ?? (_DepositionMassActualClass = new Package.DepositionMassActualClass());
	private Package.DepositionMassCommandedClass _DepositionMassCommandedClass;
	public Package.DepositionMassCommandedClass DepositionMassCommandedClass => _DepositionMassCommandedClass ?? (_DepositionMassCommandedClass = new Package.DepositionMassCommandedClass());
	private Package.DepositionRateVolumetricClass _DepositionRateVolumetricClass;
	public Package.DepositionRateVolumetricClass DepositionRateVolumetricClass => _DepositionRateVolumetricClass ?? (_DepositionRateVolumetricClass = new Package.DepositionRateVolumetricClass());
	private Package.DepositionRateVolumetricActualClass _DepositionRateVolumetricActualClass;
	public Package.DepositionRateVolumetricActualClass DepositionRateVolumetricActualClass => _DepositionRateVolumetricActualClass ?? (_DepositionRateVolumetricActualClass = new Package.DepositionRateVolumetricActualClass());
	private Package.DepositionRateVolumetricCommandedClass _DepositionRateVolumetricCommandedClass;
	public Package.DepositionRateVolumetricCommandedClass DepositionRateVolumetricCommandedClass => _DepositionRateVolumetricCommandedClass ?? (_DepositionRateVolumetricCommandedClass = new Package.DepositionRateVolumetricCommandedClass());
	private Package.DepositionVolumeClass _DepositionVolumeClass;
	public Package.DepositionVolumeClass DepositionVolumeClass => _DepositionVolumeClass ?? (_DepositionVolumeClass = new Package.DepositionVolumeClass());
	private Package.DepositionVolumeActualClass _DepositionVolumeActualClass;
	public Package.DepositionVolumeActualClass DepositionVolumeActualClass => _DepositionVolumeActualClass ?? (_DepositionVolumeActualClass = new Package.DepositionVolumeActualClass());
	private Package.DepositionVolumeCommandedClass _DepositionVolumeCommandedClass;
	public Package.DepositionVolumeCommandedClass DepositionVolumeCommandedClass => _DepositionVolumeCommandedClass ?? (_DepositionVolumeCommandedClass = new Package.DepositionVolumeCommandedClass());
	private Package.DisplacementClass _DisplacementClass;
	public Package.DisplacementClass DisplacementClass => _DisplacementClass ?? (_DisplacementClass = new Package.DisplacementClass());
	private Package.ElectricalEnergyClass _ElectricalEnergyClass;
	public Package.ElectricalEnergyClass ElectricalEnergyClass => _ElectricalEnergyClass ?? (_ElectricalEnergyClass = new Package.ElectricalEnergyClass());
	private Package.EquipmentTimerClass _EquipmentTimerClass;
	public Package.EquipmentTimerClass EquipmentTimerClass => _EquipmentTimerClass ?? (_EquipmentTimerClass = new Package.EquipmentTimerClass());
	private Package.EquipmentTimerLoadedClass _EquipmentTimerLoadedClass;
	public Package.EquipmentTimerLoadedClass EquipmentTimerLoadedClass => _EquipmentTimerLoadedClass ?? (_EquipmentTimerLoadedClass = new Package.EquipmentTimerLoadedClass());
	private Package.EquipmentTimerWorkingClass _EquipmentTimerWorkingClass;
	public Package.EquipmentTimerWorkingClass EquipmentTimerWorkingClass => _EquipmentTimerWorkingClass ?? (_EquipmentTimerWorkingClass = new Package.EquipmentTimerWorkingClass());
	private Package.EquipmentTimerOperatingClass _EquipmentTimerOperatingClass;
	public Package.EquipmentTimerOperatingClass EquipmentTimerOperatingClass => _EquipmentTimerOperatingClass ?? (_EquipmentTimerOperatingClass = new Package.EquipmentTimerOperatingClass());
	private Package.EquipmentTimerPoweredClass _EquipmentTimerPoweredClass;
	public Package.EquipmentTimerPoweredClass EquipmentTimerPoweredClass => _EquipmentTimerPoweredClass ?? (_EquipmentTimerPoweredClass = new Package.EquipmentTimerPoweredClass());
	private Package.EquipmentTimerDelayClass _EquipmentTimerDelayClass;
	public Package.EquipmentTimerDelayClass EquipmentTimerDelayClass => _EquipmentTimerDelayClass ?? (_EquipmentTimerDelayClass = new Package.EquipmentTimerDelayClass());
	private Package.FillLevelClass _FillLevelClass;
	public Package.FillLevelClass FillLevelClass => _FillLevelClass ?? (_FillLevelClass = new Package.FillLevelClass());
	private Package.FlowClass _FlowClass;
	public Package.FlowClass FlowClass => _FlowClass ?? (_FlowClass = new Package.FlowClass());
	private Package.FrequencyClass _FrequencyClass;
	public Package.FrequencyClass FrequencyClass => _FrequencyClass ?? (_FrequencyClass = new Package.FrequencyClass());
	private Package.GlobalPositionClass _GlobalPositionClass;
	public Package.GlobalPositionClass GlobalPositionClass => _GlobalPositionClass ?? (_GlobalPositionClass = new Package.GlobalPositionClass());
	private Package.LengthClass _LengthClass;
	public Package.LengthClass LengthClass => _LengthClass ?? (_LengthClass = new Package.LengthClass());
	private Package.LengthStandardClass _LengthStandardClass;
	public Package.LengthStandardClass LengthStandardClass => _LengthStandardClass ?? (_LengthStandardClass = new Package.LengthStandardClass());
	private Package.LengthRemainingClass _LengthRemainingClass;
	public Package.LengthRemainingClass LengthRemainingClass => _LengthRemainingClass ?? (_LengthRemainingClass = new Package.LengthRemainingClass());
	private Package.LengthUseableClass _LengthUseableClass;
	public Package.LengthUseableClass LengthUseableClass => _LengthUseableClass ?? (_LengthUseableClass = new Package.LengthUseableClass());
	private Package.LevelClass _LevelClass;
	public Package.LevelClass LevelClass => _LevelClass ?? (_LevelClass = new Package.LevelClass());
	private Package.LinearForceClass _LinearForceClass;
	public Package.LinearForceClass LinearForceClass => _LinearForceClass ?? (_LinearForceClass = new Package.LinearForceClass());
	private Package.LoadClass _LoadClass;
	public Package.LoadClass LoadClass => _LoadClass ?? (_LoadClass = new Package.LoadClass());
	private Package.MassClass _MassClass;
	public Package.MassClass MassClass => _MassClass ?? (_MassClass = new Package.MassClass());
	private Package.PathFeedrateClass _PathFeedrateClass;
	public Package.PathFeedrateClass PathFeedrateClass => _PathFeedrateClass ?? (_PathFeedrateClass = new Package.PathFeedrateClass());
	private Package.PathFeedrateActualClass _PathFeedrateActualClass;
	public Package.PathFeedrateActualClass PathFeedrateActualClass => _PathFeedrateActualClass ?? (_PathFeedrateActualClass = new Package.PathFeedrateActualClass());
	private Package.PathFeedrateCommandedClass _PathFeedrateCommandedClass;
	public Package.PathFeedrateCommandedClass PathFeedrateCommandedClass => _PathFeedrateCommandedClass ?? (_PathFeedrateCommandedClass = new Package.PathFeedrateCommandedClass());
	private Package.PathFeedrateJogClass _PathFeedrateJogClass;
	public Package.PathFeedrateJogClass PathFeedrateJogClass => _PathFeedrateJogClass ?? (_PathFeedrateJogClass = new Package.PathFeedrateJogClass());
	private Package.PathFeedrateProgrammedClass _PathFeedrateProgrammedClass;
	public Package.PathFeedrateProgrammedClass PathFeedrateProgrammedClass => _PathFeedrateProgrammedClass ?? (_PathFeedrateProgrammedClass = new Package.PathFeedrateProgrammedClass());
	private Package.PathFeedrateRapidClass _PathFeedrateRapidClass;
	public Package.PathFeedrateRapidClass PathFeedrateRapidClass => _PathFeedrateRapidClass ?? (_PathFeedrateRapidClass = new Package.PathFeedrateRapidClass());
	private Package.PathFeedrateOverrideClass _PathFeedrateOverrideClass;
	public Package.PathFeedrateOverrideClass PathFeedrateOverrideClass => _PathFeedrateOverrideClass ?? (_PathFeedrateOverrideClass = new Package.PathFeedrateOverrideClass());
	private Package.PathFeedratePerRevolutionClass _PathFeedratePerRevolutionClass;
	public Package.PathFeedratePerRevolutionClass PathFeedratePerRevolutionClass => _PathFeedratePerRevolutionClass ?? (_PathFeedratePerRevolutionClass = new Package.PathFeedratePerRevolutionClass());
	private Package.PathFeedratePerRevolutionActualClass _PathFeedratePerRevolutionActualClass;
	public Package.PathFeedratePerRevolutionActualClass PathFeedratePerRevolutionActualClass => _PathFeedratePerRevolutionActualClass ?? (_PathFeedratePerRevolutionActualClass = new Package.PathFeedratePerRevolutionActualClass());
	private Package.PathFeedratePerRevolutionCommandedClass _PathFeedratePerRevolutionCommandedClass;
	public Package.PathFeedratePerRevolutionCommandedClass PathFeedratePerRevolutionCommandedClass => _PathFeedratePerRevolutionCommandedClass ?? (_PathFeedratePerRevolutionCommandedClass = new Package.PathFeedratePerRevolutionCommandedClass());
	private Package.PathFeedratePerRevolutionProgrammedClass _PathFeedratePerRevolutionProgrammedClass;
	public Package.PathFeedratePerRevolutionProgrammedClass PathFeedratePerRevolutionProgrammedClass => _PathFeedratePerRevolutionProgrammedClass ?? (_PathFeedratePerRevolutionProgrammedClass = new Package.PathFeedratePerRevolutionProgrammedClass());
	private Package.PathPositionClass _PathPositionClass;
	public Package.PathPositionClass PathPositionClass => _PathPositionClass ?? (_PathPositionClass = new Package.PathPositionClass());
	private Package.PathPositionActualClass _PathPositionActualClass;
	public Package.PathPositionActualClass PathPositionActualClass => _PathPositionActualClass ?? (_PathPositionActualClass = new Package.PathPositionActualClass());
	private Package.PathPositionCommandedClass _PathPositionCommandedClass;
	public Package.PathPositionCommandedClass PathPositionCommandedClass => _PathPositionCommandedClass ?? (_PathPositionCommandedClass = new Package.PathPositionCommandedClass());
	private Package.PathPositionTargetClass _PathPositionTargetClass;
	public Package.PathPositionTargetClass PathPositionTargetClass => _PathPositionTargetClass ?? (_PathPositionTargetClass = new Package.PathPositionTargetClass());
	private Package.PathPositionProbeClass _PathPositionProbeClass;
	public Package.PathPositionProbeClass PathPositionProbeClass => _PathPositionProbeClass ?? (_PathPositionProbeClass = new Package.PathPositionProbeClass());
	private Package.PHClass _PHClass;
	public Package.PHClass PHClass => _PHClass ?? (_PHClass = new Package.PHClass());
	private Package.PositionClass _PositionClass;
	public Package.PositionClass PositionClass => _PositionClass ?? (_PositionClass = new Package.PositionClass());
	private Package.PositionActualClass _PositionActualClass;
	public Package.PositionActualClass PositionActualClass => _PositionActualClass ?? (_PositionActualClass = new Package.PositionActualClass());
	private Package.PositionCommandedClass _PositionCommandedClass;
	public Package.PositionCommandedClass PositionCommandedClass => _PositionCommandedClass ?? (_PositionCommandedClass = new Package.PositionCommandedClass());
	private Package.PositionProgrammedClass _PositionProgrammedClass;
	public Package.PositionProgrammedClass PositionProgrammedClass => _PositionProgrammedClass ?? (_PositionProgrammedClass = new Package.PositionProgrammedClass());
	private Package.PositionTargetClass _PositionTargetClass;
	public Package.PositionTargetClass PositionTargetClass => _PositionTargetClass ?? (_PositionTargetClass = new Package.PositionTargetClass());
	private Package.PowerFactorClass _PowerFactorClass;
	public Package.PowerFactorClass PowerFactorClass => _PowerFactorClass ?? (_PowerFactorClass = new Package.PowerFactorClass());
	private Package.PressureClass _PressureClass;
	public Package.PressureClass PressureClass => _PressureClass ?? (_PressureClass = new Package.PressureClass());
	private Package.ProcessTimerClass _ProcessTimerClass;
	public Package.ProcessTimerClass ProcessTimerClass => _ProcessTimerClass ?? (_ProcessTimerClass = new Package.ProcessTimerClass());
	private Package.ProcessTimerProcessClass _ProcessTimerProcessClass;
	public Package.ProcessTimerProcessClass ProcessTimerProcessClass => _ProcessTimerProcessClass ?? (_ProcessTimerProcessClass = new Package.ProcessTimerProcessClass());
	private Package.ProcessTimerDelayClass _ProcessTimerDelayClass;
	public Package.ProcessTimerDelayClass ProcessTimerDelayClass => _ProcessTimerDelayClass ?? (_ProcessTimerDelayClass = new Package.ProcessTimerDelayClass());
	private Package.ResistanceClass _ResistanceClass;
	public Package.ResistanceClass ResistanceClass => _ResistanceClass ?? (_ResistanceClass = new Package.ResistanceClass());
	private Package.RotaryVelocityClass _RotaryVelocityClass;
	public Package.RotaryVelocityClass RotaryVelocityClass => _RotaryVelocityClass ?? (_RotaryVelocityClass = new Package.RotaryVelocityClass());
	private Package.RotaryVelocityActualClass _RotaryVelocityActualClass;
	public Package.RotaryVelocityActualClass RotaryVelocityActualClass => _RotaryVelocityActualClass ?? (_RotaryVelocityActualClass = new Package.RotaryVelocityActualClass());
	private Package.RotaryVelocityCommandedClass _RotaryVelocityCommandedClass;
	public Package.RotaryVelocityCommandedClass RotaryVelocityCommandedClass => _RotaryVelocityCommandedClass ?? (_RotaryVelocityCommandedClass = new Package.RotaryVelocityCommandedClass());
	private Package.RotaryVelocityProgrammedClass _RotaryVelocityProgrammedClass;
	public Package.RotaryVelocityProgrammedClass RotaryVelocityProgrammedClass => _RotaryVelocityProgrammedClass ?? (_RotaryVelocityProgrammedClass = new Package.RotaryVelocityProgrammedClass());
	private Package.RotaryVelocityOverrideClass _RotaryVelocityOverrideClass;
	public Package.RotaryVelocityOverrideClass RotaryVelocityOverrideClass => _RotaryVelocityOverrideClass ?? (_RotaryVelocityOverrideClass = new Package.RotaryVelocityOverrideClass());
	private Package.SoundLevelClass _SoundLevelClass;
	public Package.SoundLevelClass SoundLevelClass => _SoundLevelClass ?? (_SoundLevelClass = new Package.SoundLevelClass());
	private Package.SoundLevelNoScaleClass _SoundLevelNoScaleClass;
	public Package.SoundLevelNoScaleClass SoundLevelNoScaleClass => _SoundLevelNoScaleClass ?? (_SoundLevelNoScaleClass = new Package.SoundLevelNoScaleClass());
	private Package.SoundLevelAScaleClass _SoundLevelAScaleClass;
	public Package.SoundLevelAScaleClass SoundLevelAScaleClass => _SoundLevelAScaleClass ?? (_SoundLevelAScaleClass = new Package.SoundLevelAScaleClass());
	private Package.SoundLevelBScaleClass _SoundLevelBScaleClass;
	public Package.SoundLevelBScaleClass SoundLevelBScaleClass => _SoundLevelBScaleClass ?? (_SoundLevelBScaleClass = new Package.SoundLevelBScaleClass());
	private Package.SoundLevelCScaleClass _SoundLevelCScaleClass;
	public Package.SoundLevelCScaleClass SoundLevelCScaleClass => _SoundLevelCScaleClass ?? (_SoundLevelCScaleClass = new Package.SoundLevelCScaleClass());
	private Package.SoundLevelDScaleClass _SoundLevelDScaleClass;
	public Package.SoundLevelDScaleClass SoundLevelDScaleClass => _SoundLevelDScaleClass ?? (_SoundLevelDScaleClass = new Package.SoundLevelDScaleClass());
	private Package.SpindleSpeedClass _SpindleSpeedClass;
	public Package.SpindleSpeedClass SpindleSpeedClass => _SpindleSpeedClass ?? (_SpindleSpeedClass = new Package.SpindleSpeedClass());
	private Package.SpindleSpeedActualClass _SpindleSpeedActualClass;
	public Package.SpindleSpeedActualClass SpindleSpeedActualClass => _SpindleSpeedActualClass ?? (_SpindleSpeedActualClass = new Package.SpindleSpeedActualClass());
	private Package.SpindleSpeedCommandedClass _SpindleSpeedCommandedClass;
	public Package.SpindleSpeedCommandedClass SpindleSpeedCommandedClass => _SpindleSpeedCommandedClass ?? (_SpindleSpeedCommandedClass = new Package.SpindleSpeedCommandedClass());
	private Package.SpindleSpeedOverrideClass _SpindleSpeedOverrideClass;
	public Package.SpindleSpeedOverrideClass SpindleSpeedOverrideClass => _SpindleSpeedOverrideClass ?? (_SpindleSpeedOverrideClass = new Package.SpindleSpeedOverrideClass());
	private Package.StrainClass _StrainClass;
	public Package.StrainClass StrainClass => _StrainClass ?? (_StrainClass = new Package.StrainClass());
	private Package.TemperatureClass _TemperatureClass;
	public Package.TemperatureClass TemperatureClass => _TemperatureClass ?? (_TemperatureClass = new Package.TemperatureClass());
	private Package.TensionClass _TensionClass;
	public Package.TensionClass TensionClass => _TensionClass ?? (_TensionClass = new Package.TensionClass());
	private Package.TiltClass _TiltClass;
	public Package.TiltClass TiltClass => _TiltClass ?? (_TiltClass = new Package.TiltClass());
	private Package.TorqueClass _TorqueClass;
	public Package.TorqueClass TorqueClass => _TorqueClass ?? (_TorqueClass = new Package.TorqueClass());
	private Package.VelocityClass _VelocityClass;
	public Package.VelocityClass VelocityClass => _VelocityClass ?? (_VelocityClass = new Package.VelocityClass());
	private Package.ViscosityClass _ViscosityClass;
	public Package.ViscosityClass ViscosityClass => _ViscosityClass ?? (_ViscosityClass = new Package.ViscosityClass());
	private Package.VoltageClass _VoltageClass;
	public Package.VoltageClass VoltageClass => _VoltageClass ?? (_VoltageClass = new Package.VoltageClass());
	private Package.VoltageAlternatingClass _VoltageAlternatingClass;
	public Package.VoltageAlternatingClass VoltageAlternatingClass => _VoltageAlternatingClass ?? (_VoltageAlternatingClass = new Package.VoltageAlternatingClass());
	private Package.VoltageDirectClass _VoltageDirectClass;
	public Package.VoltageDirectClass VoltageDirectClass => _VoltageDirectClass ?? (_VoltageDirectClass = new Package.VoltageDirectClass());
	private Package.VoltageActualClass _VoltageActualClass;
	public Package.VoltageActualClass VoltageActualClass => _VoltageActualClass ?? (_VoltageActualClass = new Package.VoltageActualClass());
	private Package.VoltageTargetClass _VoltageTargetClass;
	public Package.VoltageTargetClass VoltageTargetClass => _VoltageTargetClass ?? (_VoltageTargetClass = new Package.VoltageTargetClass());
	private Package.VoltAmpereClass _VoltAmpereClass;
	public Package.VoltAmpereClass VoltAmpereClass => _VoltAmpereClass ?? (_VoltAmpereClass = new Package.VoltAmpereClass());
	private Package.VoltAmpereReactiveClass _VoltAmpereReactiveClass;
	public Package.VoltAmpereReactiveClass VoltAmpereReactiveClass => _VoltAmpereReactiveClass ?? (_VoltAmpereReactiveClass = new Package.VoltAmpereReactiveClass());
	private Package.VolumeFluidClass _VolumeFluidClass;
	public Package.VolumeFluidClass VolumeFluidClass => _VolumeFluidClass ?? (_VolumeFluidClass = new Package.VolumeFluidClass());
	private Package.VolumeFluidActualClass _VolumeFluidActualClass;
	public Package.VolumeFluidActualClass VolumeFluidActualClass => _VolumeFluidActualClass ?? (_VolumeFluidActualClass = new Package.VolumeFluidActualClass());
	private Package.VolumeFluidConsumedClass _VolumeFluidConsumedClass;
	public Package.VolumeFluidConsumedClass VolumeFluidConsumedClass => _VolumeFluidConsumedClass ?? (_VolumeFluidConsumedClass = new Package.VolumeFluidConsumedClass());
	private Package.VolumeSpatialClass _VolumeSpatialClass;
	public Package.VolumeSpatialClass VolumeSpatialClass => _VolumeSpatialClass ?? (_VolumeSpatialClass = new Package.VolumeSpatialClass());
	private Package.VolumeSpatialActualClass _VolumeSpatialActualClass;
	public Package.VolumeSpatialActualClass VolumeSpatialActualClass => _VolumeSpatialActualClass ?? (_VolumeSpatialActualClass = new Package.VolumeSpatialActualClass());
	private Package.VolumeSpatialConsumedClass _VolumeSpatialConsumedClass;
	public Package.VolumeSpatialConsumedClass VolumeSpatialConsumedClass => _VolumeSpatialConsumedClass ?? (_VolumeSpatialConsumedClass = new Package.VolumeSpatialConsumedClass());
	private Package.WattageClass _WattageClass;
	public Package.WattageClass WattageClass => _WattageClass ?? (_WattageClass = new Package.WattageClass());
	private Package.WattageActualClass _WattageActualClass;
	public Package.WattageActualClass WattageActualClass => _WattageActualClass ?? (_WattageActualClass = new Package.WattageActualClass());
	private Package.WattageTargetClass _WattageTargetClass;
	public Package.WattageTargetClass WattageTargetClass => _WattageTargetClass ?? (_WattageTargetClass = new Package.WattageTargetClass());
	private Package.AmperageDCClass _AmperageDCClass;
	public Package.AmperageDCClass AmperageDCClass => _AmperageDCClass ?? (_AmperageDCClass = new Package.AmperageDCClass());
	private Package.AmperageDCActualClass _AmperageDCActualClass;
	public Package.AmperageDCActualClass AmperageDCActualClass => _AmperageDCActualClass ?? (_AmperageDCActualClass = new Package.AmperageDCActualClass());
	private Package.AmperageDCCommandedClass _AmperageDCCommandedClass;
	public Package.AmperageDCCommandedClass AmperageDCCommandedClass => _AmperageDCCommandedClass ?? (_AmperageDCCommandedClass = new Package.AmperageDCCommandedClass());
	private Package.AmperageDCProgrammedClass _AmperageDCProgrammedClass;
	public Package.AmperageDCProgrammedClass AmperageDCProgrammedClass => _AmperageDCProgrammedClass ?? (_AmperageDCProgrammedClass = new Package.AmperageDCProgrammedClass());
	private Package.AmperageACClass _AmperageACClass;
	public Package.AmperageACClass AmperageACClass => _AmperageACClass ?? (_AmperageACClass = new Package.AmperageACClass());
	private Package.AmperageACActualClass _AmperageACActualClass;
	public Package.AmperageACActualClass AmperageACActualClass => _AmperageACActualClass ?? (_AmperageACActualClass = new Package.AmperageACActualClass());
	private Package.AmperageACCommandedClass _AmperageACCommandedClass;
	public Package.AmperageACCommandedClass AmperageACCommandedClass => _AmperageACCommandedClass ?? (_AmperageACCommandedClass = new Package.AmperageACCommandedClass());
	private Package.AmperageACProgrammedClass _AmperageACProgrammedClass;
	public Package.AmperageACProgrammedClass AmperageACProgrammedClass => _AmperageACProgrammedClass ?? (_AmperageACProgrammedClass = new Package.AmperageACProgrammedClass());
	private Package.VoltageACActualClass _VoltageACActualClass;
	public Package.VoltageACActualClass VoltageACActualClass => _VoltageACActualClass ?? (_VoltageACActualClass = new Package.VoltageACActualClass());
	private Package.VoltageACClass _VoltageACClass;
	public Package.VoltageACClass VoltageACClass => _VoltageACClass ?? (_VoltageACClass = new Package.VoltageACClass());
	private Package.VoltageACCommandedClass _VoltageACCommandedClass;
	public Package.VoltageACCommandedClass VoltageACCommandedClass => _VoltageACCommandedClass ?? (_VoltageACCommandedClass = new Package.VoltageACCommandedClass());
	private Package.VoltageACProgrammedClass _VoltageACProgrammedClass;
	public Package.VoltageACProgrammedClass VoltageACProgrammedClass => _VoltageACProgrammedClass ?? (_VoltageACProgrammedClass = new Package.VoltageACProgrammedClass());
	private Package.VoltageDCActualClass _VoltageDCActualClass;
	public Package.VoltageDCActualClass VoltageDCActualClass => _VoltageDCActualClass ?? (_VoltageDCActualClass = new Package.VoltageDCActualClass());
	private Package.VoltageDCCommandedClass _VoltageDCCommandedClass;
	public Package.VoltageDCCommandedClass VoltageDCCommandedClass => _VoltageDCCommandedClass ?? (_VoltageDCCommandedClass = new Package.VoltageDCCommandedClass());
	private Package.VoltageDCProgrammedClass _VoltageDCProgrammedClass;
	public Package.VoltageDCProgrammedClass VoltageDCProgrammedClass => _VoltageDCProgrammedClass ?? (_VoltageDCProgrammedClass = new Package.VoltageDCProgrammedClass());
	private Package.VoltageDCClass _VoltageDCClass;
	public Package.VoltageDCClass VoltageDCClass => _VoltageDCClass ?? (_VoltageDCClass = new Package.VoltageDCClass());
	private Package.XDimensionClass _XDimensionClass;
	public Package.XDimensionClass XDimensionClass => _XDimensionClass ?? (_XDimensionClass = new Package.XDimensionClass());
	private Package.YDimensionClass _YDimensionClass;
	public Package.YDimensionClass YDimensionClass => _YDimensionClass ?? (_YDimensionClass = new Package.YDimensionClass());
	private Package.ZDimensionClass _ZDimensionClass;
	public Package.ZDimensionClass ZDimensionClass => _ZDimensionClass ?? (_ZDimensionClass = new Package.ZDimensionClass());
	private Package.DiameterClass _DiameterClass;
	public Package.DiameterClass DiameterClass => _DiameterClass ?? (_DiameterClass = new Package.DiameterClass());
	private Package.OrientationActualClass _OrientationActualClass;
	public Package.OrientationActualClass OrientationActualClass => _OrientationActualClass ?? (_OrientationActualClass = new Package.OrientationActualClass());
	private Package.OrientationClass _OrientationClass;
	public Package.OrientationClass OrientationClass => _OrientationClass ?? (_OrientationClass = new Package.OrientationClass());
	private Package.OrientationCommandedClass _OrientationCommandedClass;
	public Package.OrientationCommandedClass OrientationCommandedClass => _OrientationCommandedClass ?? (_OrientationCommandedClass = new Package.OrientationCommandedClass());
	private Package.HumidityRelativeClass _HumidityRelativeClass;
	public Package.HumidityRelativeClass HumidityRelativeClass => _HumidityRelativeClass ?? (_HumidityRelativeClass = new Package.HumidityRelativeClass());
	private Package.HumidityRelativeCommandedClass _HumidityRelativeCommandedClass;
	public Package.HumidityRelativeCommandedClass HumidityRelativeCommandedClass => _HumidityRelativeCommandedClass ?? (_HumidityRelativeCommandedClass = new Package.HumidityRelativeCommandedClass());
	private Package.HumidityRelativeActualClass _HumidityRelativeActualClass;
	public Package.HumidityRelativeActualClass HumidityRelativeActualClass => _HumidityRelativeActualClass ?? (_HumidityRelativeActualClass = new Package.HumidityRelativeActualClass());
	private Package.HumidityAbsoluteClass _HumidityAbsoluteClass;
	public Package.HumidityAbsoluteClass HumidityAbsoluteClass => _HumidityAbsoluteClass ?? (_HumidityAbsoluteClass = new Package.HumidityAbsoluteClass());
	private Package.HumidityAbsoluteActualClass _HumidityAbsoluteActualClass;
	public Package.HumidityAbsoluteActualClass HumidityAbsoluteActualClass => _HumidityAbsoluteActualClass ?? (_HumidityAbsoluteActualClass = new Package.HumidityAbsoluteActualClass());
	private Package.HumidityAbsoluteCommandedClass _HumidityAbsoluteCommandedClass;
	public Package.HumidityAbsoluteCommandedClass HumidityAbsoluteCommandedClass => _HumidityAbsoluteCommandedClass ?? (_HumidityAbsoluteCommandedClass = new Package.HumidityAbsoluteCommandedClass());
	private Package.HumiditySpecificClass _HumiditySpecificClass;
	public Package.HumiditySpecificClass HumiditySpecificClass => _HumiditySpecificClass ?? (_HumiditySpecificClass = new Package.HumiditySpecificClass());
	private Package.HumiditySpecificActualClass _HumiditySpecificActualClass;
	public Package.HumiditySpecificActualClass HumiditySpecificActualClass => _HumiditySpecificActualClass ?? (_HumiditySpecificActualClass = new Package.HumiditySpecificActualClass());
	private Package.HumiditySpecificCommandedClass _HumiditySpecificCommandedClass;
	public Package.HumiditySpecificCommandedClass HumiditySpecificCommandedClass => _HumiditySpecificCommandedClass ?? (_HumiditySpecificCommandedClass = new Package.HumiditySpecificCommandedClass());
	private Package.AngularDecelerationActualClass _AngularDecelerationActualClass;
	public Package.AngularDecelerationActualClass AngularDecelerationActualClass => _AngularDecelerationActualClass ?? (_AngularDecelerationActualClass = new Package.AngularDecelerationActualClass());
	private Package.DecelerationProgrammedClass _DecelerationProgrammedClass;
	public Package.DecelerationProgrammedClass DecelerationProgrammedClass => _DecelerationProgrammedClass ?? (_DecelerationProgrammedClass = new Package.DecelerationProgrammedClass());
	private Package.AngularDecelerationProgrammedClass _AngularDecelerationProgrammedClass;
	public Package.AngularDecelerationProgrammedClass AngularDecelerationProgrammedClass => _AngularDecelerationProgrammedClass ?? (_AngularDecelerationProgrammedClass = new Package.AngularDecelerationProgrammedClass());
	private Package.PressurizationRateClass _PressurizationRateClass;
	public Package.PressurizationRateClass PressurizationRateClass => _PressurizationRateClass ?? (_PressurizationRateClass = new Package.PressurizationRateClass());
	private Package.AngularDecelerationCommandedClass _AngularDecelerationCommandedClass;
	public Package.AngularDecelerationCommandedClass AngularDecelerationCommandedClass => _AngularDecelerationCommandedClass ?? (_AngularDecelerationCommandedClass = new Package.AngularDecelerationCommandedClass());
	private Package.DecelerationClass _DecelerationClass;
	public Package.DecelerationClass DecelerationClass => _DecelerationClass ?? (_DecelerationClass = new Package.DecelerationClass());
	private Package.AssetUpdateRateClass _AssetUpdateRateClass;
	public Package.AssetUpdateRateClass AssetUpdateRateClass => _AssetUpdateRateClass ?? (_AssetUpdateRateClass = new Package.AssetUpdateRateClass());
	private Package.AngularDecelerationClass _AngularDecelerationClass;
	public Package.AngularDecelerationClass AngularDecelerationClass => _AngularDecelerationClass ?? (_AngularDecelerationClass = new Package.AngularDecelerationClass());
	private Package.ObservationUpdateRateClass _ObservationUpdateRateClass;
	public Package.ObservationUpdateRateClass ObservationUpdateRateClass => _ObservationUpdateRateClass ?? (_ObservationUpdateRateClass = new Package.ObservationUpdateRateClass());
	private Package.DecelerationCommandedClass _DecelerationCommandedClass;
	public Package.DecelerationCommandedClass DecelerationCommandedClass => _DecelerationCommandedClass ?? (_DecelerationCommandedClass = new Package.DecelerationCommandedClass());
	private Package.DecelerationActualClass _DecelerationActualClass;
	public Package.DecelerationActualClass DecelerationActualClass => _DecelerationActualClass ?? (_DecelerationActualClass = new Package.DecelerationActualClass());
	private Package.PressureAbsoluteClass _PressureAbsoluteClass;
	public Package.PressureAbsoluteClass PressureAbsoluteClass => _PressureAbsoluteClass ?? (_PressureAbsoluteClass = new Package.PressureAbsoluteClass());
	private Package.AccelerationActualClass _AccelerationActualClass;
	public Package.AccelerationActualClass AccelerationActualClass => _AccelerationActualClass ?? (_AccelerationActualClass = new Package.AccelerationActualClass());
	private Package.VolumeFluidPartClass _VolumeFluidPartClass;
	public Package.VolumeFluidPartClass VolumeFluidPartClass => _VolumeFluidPartClass ?? (_VolumeFluidPartClass = new Package.VolumeFluidPartClass());
	private Package.AngularAccelerationProgrammedClass _AngularAccelerationProgrammedClass;
	public Package.AngularAccelerationProgrammedClass AngularAccelerationProgrammedClass => _AngularAccelerationProgrammedClass ?? (_AngularAccelerationProgrammedClass = new Package.AngularAccelerationProgrammedClass());
	private Package.PressurizationRateCommandedClass _PressurizationRateCommandedClass;
	public Package.PressurizationRateCommandedClass PressurizationRateCommandedClass => _PressurizationRateCommandedClass ?? (_PressurizationRateCommandedClass = new Package.PressurizationRateCommandedClass());
	private Package.AccelerationProgrammedClass _AccelerationProgrammedClass;
	public Package.AccelerationProgrammedClass AccelerationProgrammedClass => _AccelerationProgrammedClass ?? (_AccelerationProgrammedClass = new Package.AccelerationProgrammedClass());
	private Package.AccelerationCommandedClass _AccelerationCommandedClass;
	public Package.AccelerationCommandedClass AccelerationCommandedClass => _AccelerationCommandedClass ?? (_AccelerationCommandedClass = new Package.AccelerationCommandedClass());
	private Package.VolumeFluidWasteClass _VolumeFluidWasteClass;
	public Package.VolumeFluidWasteClass VolumeFluidWasteClass => _VolumeFluidWasteClass ?? (_VolumeFluidWasteClass = new Package.VolumeFluidWasteClass());
	private Package.VolumeSpatialPartClass _VolumeSpatialPartClass;
	public Package.VolumeSpatialPartClass VolumeSpatialPartClass => _VolumeSpatialPartClass ?? (_VolumeSpatialPartClass = new Package.VolumeSpatialPartClass());
	private Package.VolumeFluidStartClass _VolumeFluidStartClass;
	public Package.VolumeFluidStartClass VolumeFluidStartClass => _VolumeFluidStartClass ?? (_VolumeFluidStartClass = new Package.VolumeFluidStartClass());
	private Package.AngularAccelerationActualClass _AngularAccelerationActualClass;
	public Package.AngularAccelerationActualClass AngularAccelerationActualClass => _AngularAccelerationActualClass ?? (_AngularAccelerationActualClass = new Package.AngularAccelerationActualClass());
	private Package.VolumeSpatialWasteClass _VolumeSpatialWasteClass;
	public Package.VolumeSpatialWasteClass VolumeSpatialWasteClass => _VolumeSpatialWasteClass ?? (_VolumeSpatialWasteClass = new Package.VolumeSpatialWasteClass());
	private Package.PressurizationRateActualClass _PressurizationRateActualClass;
	public Package.PressurizationRateActualClass PressurizationRateActualClass => _PressurizationRateActualClass ?? (_PressurizationRateActualClass = new Package.PressurizationRateActualClass());
	private Package.VolumeSpatialEndedClass _VolumeSpatialEndedClass;
	public Package.VolumeSpatialEndedClass VolumeSpatialEndedClass => _VolumeSpatialEndedClass ?? (_VolumeSpatialEndedClass = new Package.VolumeSpatialEndedClass());
	private Package.AngularAccelerationCommandedClass _AngularAccelerationCommandedClass;
	public Package.AngularAccelerationCommandedClass AngularAccelerationCommandedClass => _AngularAccelerationCommandedClass ?? (_AngularAccelerationCommandedClass = new Package.AngularAccelerationCommandedClass());
	private Package.PressurizationRateProgrammedClass _PressurizationRateProgrammedClass;
	public Package.PressurizationRateProgrammedClass PressurizationRateProgrammedClass => _PressurizationRateProgrammedClass ?? (_PressurizationRateProgrammedClass = new Package.PressurizationRateProgrammedClass());
	private Package.VolumeSpatialStartClass _VolumeSpatialStartClass;
	public Package.VolumeSpatialStartClass VolumeSpatialStartClass => _VolumeSpatialStartClass ?? (_VolumeSpatialStartClass = new Package.VolumeSpatialStartClass());
	private Package.VolumeFluidEndedClass _VolumeFluidEndedClass;
	public Package.VolumeFluidEndedClass VolumeFluidEndedClass => _VolumeFluidEndedClass ?? (_VolumeFluidEndedClass = new Package.VolumeFluidEndedClass());
	private Package.OpennessClass _OpennessClass;
	public Package.OpennessClass OpennessClass => _OpennessClass ?? (_OpennessClass = new Package.OpennessClass());
	private Package.GlobalPositionActualClass _GlobalPositionActualClass;
	public Package.GlobalPositionActualClass GlobalPositionActualClass => _GlobalPositionActualClass ?? (_GlobalPositionActualClass = new Package.GlobalPositionActualClass());
	private Package.GlobalPositionCommandedClass _GlobalPositionCommandedClass;
	public Package.GlobalPositionCommandedClass GlobalPositionCommandedClass => _GlobalPositionCommandedClass ?? (_GlobalPositionCommandedClass = new Package.GlobalPositionCommandedClass());
	private Package.DewPointClass _DewPointClass;
	public Package.DewPointClass DewPointClass => _DewPointClass ?? (_DewPointClass = new Package.DewPointClass());
	private Package.GravitationalForceClass _GravitationalForceClass;
	public Package.GravitationalForceClass GravitationalForceClass => _GravitationalForceClass ?? (_GravitationalForceClass = new Package.GravitationalForceClass());
	private Package.GravitationalAccelerationClass _GravitationalAccelerationClass;
	public Package.GravitationalAccelerationClass GravitationalAccelerationClass => _GravitationalAccelerationClass ?? (_GravitationalAccelerationClass = new Package.GravitationalAccelerationClass());
	private Package.BatteryCapacityClass _BatteryCapacityClass;
	public Package.BatteryCapacityClass BatteryCapacityClass => _BatteryCapacityClass ?? (_BatteryCapacityClass = new Package.BatteryCapacityClass());
	private Package.BatteryCapacityActualClass _BatteryCapacityActualClass;
	public Package.BatteryCapacityActualClass BatteryCapacityActualClass => _BatteryCapacityActualClass ?? (_BatteryCapacityActualClass = new Package.BatteryCapacityActualClass());
	private Package.BatteryCapacityTargetClass _BatteryCapacityTargetClass;
	public Package.BatteryCapacityTargetClass BatteryCapacityTargetClass => _BatteryCapacityTargetClass ?? (_BatteryCapacityTargetClass = new Package.BatteryCapacityTargetClass());
	private Package.DischargeRateClass _DischargeRateClass;
	public Package.DischargeRateClass DischargeRateClass => _DischargeRateClass ?? (_DischargeRateClass = new Package.DischargeRateClass());
	private Package.DischargeRateActualClass _DischargeRateActualClass;
	public Package.DischargeRateActualClass DischargeRateActualClass => _DischargeRateActualClass ?? (_DischargeRateActualClass = new Package.DischargeRateActualClass());
	private Package.DischargeRateTargetClass _DischargeRateTargetClass;
	public Package.DischargeRateTargetClass DischargeRateTargetClass => _DischargeRateTargetClass ?? (_DischargeRateTargetClass = new Package.DischargeRateTargetClass());
	private Package.ChargeRateClass _ChargeRateClass;
	public Package.ChargeRateClass ChargeRateClass => _ChargeRateClass ?? (_ChargeRateClass = new Package.ChargeRateClass());
	private Package.ChargeRateActualClass _ChargeRateActualClass;
	public Package.ChargeRateActualClass ChargeRateActualClass => _ChargeRateActualClass ?? (_ChargeRateActualClass = new Package.ChargeRateActualClass());
	private Package.ChargeRateTargetClass _ChargeRateTargetClass;
	public Package.ChargeRateTargetClass ChargeRateTargetClass => _ChargeRateTargetClass ?? (_ChargeRateTargetClass = new Package.ChargeRateTargetClass());
	private Package.BatteryChargeClass _BatteryChargeClass;
	public Package.BatteryChargeClass BatteryChargeClass => _BatteryChargeClass ?? (_BatteryChargeClass = new Package.BatteryChargeClass());
	private Package.BatteryChargeActualClass _BatteryChargeActualClass;
	public Package.BatteryChargeActualClass BatteryChargeActualClass => _BatteryChargeActualClass ?? (_BatteryChargeActualClass = new Package.BatteryChargeActualClass());
	private Package.BatteryChargeTargetClass _BatteryChargeTargetClass;
	public Package.BatteryChargeTargetClass BatteryChargeTargetClass => _BatteryChargeTargetClass ?? (_BatteryChargeTargetClass = new Package.BatteryChargeTargetClass());
	private Package.SettlingErrorClass _SettlingErrorClass;
	public Package.SettlingErrorClass SettlingErrorClass => _SettlingErrorClass ?? (_SettlingErrorClass = new Package.SettlingErrorClass());
	private Package.SettlingErrorActualClass _SettlingErrorActualClass;
	public Package.SettlingErrorActualClass SettlingErrorActualClass => _SettlingErrorActualClass ?? (_SettlingErrorActualClass = new Package.SettlingErrorActualClass());
	private Package.SettlingErrorLinearClass _SettlingErrorLinearClass;
	public Package.SettlingErrorLinearClass SettlingErrorLinearClass => _SettlingErrorLinearClass ?? (_SettlingErrorLinearClass = new Package.SettlingErrorLinearClass());
	private Package.SettlingErrorLinearActualClass _SettlingErrorLinearActualClass;
	public Package.SettlingErrorLinearActualClass SettlingErrorLinearActualClass => _SettlingErrorLinearActualClass ?? (_SettlingErrorLinearActualClass = new Package.SettlingErrorLinearActualClass());
	private Package.SettlingErrorAngularClass _SettlingErrorAngularClass;
	public Package.SettlingErrorAngularClass SettlingErrorAngularClass => _SettlingErrorAngularClass ?? (_SettlingErrorAngularClass = new Package.SettlingErrorAngularClass());
	private Package.SettlingErrorAngularActualClass _SettlingErrorAngularActualClass;
	public Package.SettlingErrorAngularActualClass SettlingErrorAngularActualClass => _SettlingErrorAngularActualClass ?? (_SettlingErrorAngularActualClass = new Package.SettlingErrorAngularActualClass());
	private Package.FollowingErrorClass _FollowingErrorClass;
	public Package.FollowingErrorClass FollowingErrorClass => _FollowingErrorClass ?? (_FollowingErrorClass = new Package.FollowingErrorClass());
	private Package.FollowingErrorActualClass _FollowingErrorActualClass;
	public Package.FollowingErrorActualClass FollowingErrorActualClass => _FollowingErrorActualClass ?? (_FollowingErrorActualClass = new Package.FollowingErrorActualClass());
	private Package.FollowingErrorAngularClass _FollowingErrorAngularClass;
	public Package.FollowingErrorAngularClass FollowingErrorAngularClass => _FollowingErrorAngularClass ?? (_FollowingErrorAngularClass = new Package.FollowingErrorAngularClass());
	private Package.FollowingErrorLinearClass _FollowingErrorLinearClass;
	public Package.FollowingErrorLinearClass FollowingErrorLinearClass => _FollowingErrorLinearClass ?? (_FollowingErrorLinearClass = new Package.FollowingErrorLinearClass());
	private Package.FollowingErrorAngularActualClass _FollowingErrorAngularActualClass;
	public Package.FollowingErrorAngularActualClass FollowingErrorAngularActualClass => _FollowingErrorAngularActualClass ?? (_FollowingErrorAngularActualClass = new Package.FollowingErrorAngularActualClass());
	private Package.FollowingErrorLinearActualClass _FollowingErrorLinearActualClass;
	public Package.FollowingErrorLinearActualClass FollowingErrorLinearActualClass => _FollowingErrorLinearActualClass ?? (_FollowingErrorLinearActualClass = new Package.FollowingErrorLinearActualClass());
	private Package.DisplacementLinearClass _DisplacementLinearClass;
	public Package.DisplacementLinearClass DisplacementLinearClass => _DisplacementLinearClass ?? (_DisplacementLinearClass = new Package.DisplacementLinearClass());
	private Package.DisplacementAngularClass _DisplacementAngularClass;
	public Package.DisplacementAngularClass DisplacementAngularClass => _DisplacementAngularClass ?? (_DisplacementAngularClass = new Package.DisplacementAngularClass());
	private Package.PositionCartesianClass _PositionCartesianClass;
	public Package.PositionCartesianClass PositionCartesianClass => _PositionCartesianClass ?? (_PositionCartesianClass = new Package.PositionCartesianClass());
	}
}