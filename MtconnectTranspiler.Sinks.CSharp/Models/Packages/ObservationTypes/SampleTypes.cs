using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;
using Package = Mtconnect.ObservationInformationModel.ObservationTypes.SampleTypes;

namespace Mtconnect.ObservationInformationModel.ObservationTypes
{
	/// <summary>
	/// This section provides semantic information for <see cref="Sample">Sample</see> types.
	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Package___19_0_3_45f01b9_1580309868367_570061_44359">model.mtconnect.org</seealso> for more information.
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.3.0.0")]
	public class SampleTypesPackage : IPackage
	{
		/// <inheritdoc />
		public string ReferenceId => "_19_0_3_45f01b9_1580309868367_570061_44359";
		
		/// <inheritdoc />
		public string Name => "Sample Types";

		/// <inheritdoc />
		public string Summary => @"/// This section provides semantic information for <see cref=""Sample"">Sample</see> types.";

		/// <inheritdoc />
		public IPackage[] Packages => new IPackage[] {
		};
		
		/// <inheritdoc />
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
		#region Packages
	#endregion

	#region Classes
	private Package.AccelerationClass _AccelerationClass;
	/// <summary>
	/// <inheritdoc cref="Package.AccelerationClass" path="/summary" />
	/// </summary>
	public Package.AccelerationClass AccelerationClass => _AccelerationClass ?? (_AccelerationClass = new Package.AccelerationClass());

	private Package.AccumulatedTimeClass _AccumulatedTimeClass;
	/// <summary>
	/// <inheritdoc cref="Package.AccumulatedTimeClass" path="/summary" />
	/// </summary>
	public Package.AccumulatedTimeClass AccumulatedTimeClass => _AccumulatedTimeClass ?? (_AccumulatedTimeClass = new Package.AccumulatedTimeClass());

	private Package.AmperageClass _AmperageClass;
	/// <summary>
	/// <inheritdoc cref="Package.AmperageClass" path="/summary" />
	/// </summary>
	public Package.AmperageClass AmperageClass => _AmperageClass ?? (_AmperageClass = new Package.AmperageClass());

	private Package.AmperageAlternatingClass _AmperageAlternatingClass;
	/// <summary>
	/// <inheritdoc cref="Package.AmperageAlternatingClass" path="/summary" />
	/// </summary>
	public Package.AmperageAlternatingClass AmperageAlternatingClass => _AmperageAlternatingClass ?? (_AmperageAlternatingClass = new Package.AmperageAlternatingClass());

	private Package.AmperageDirectClass _AmperageDirectClass;
	/// <summary>
	/// <inheritdoc cref="Package.AmperageDirectClass" path="/summary" />
	/// </summary>
	public Package.AmperageDirectClass AmperageDirectClass => _AmperageDirectClass ?? (_AmperageDirectClass = new Package.AmperageDirectClass());

	private Package.AmperageActualClass _AmperageActualClass;
	/// <summary>
	/// <inheritdoc cref="Package.AmperageActualClass" path="/summary" />
	/// </summary>
	public Package.AmperageActualClass AmperageActualClass => _AmperageActualClass ?? (_AmperageActualClass = new Package.AmperageActualClass());

	private Package.AmperageTargetClass _AmperageTargetClass;
	/// <summary>
	/// <inheritdoc cref="Package.AmperageTargetClass" path="/summary" />
	/// </summary>
	public Package.AmperageTargetClass AmperageTargetClass => _AmperageTargetClass ?? (_AmperageTargetClass = new Package.AmperageTargetClass());

	private Package.AngleClass _AngleClass;
	/// <summary>
	/// <inheritdoc cref="Package.AngleClass" path="/summary" />
	/// </summary>
	public Package.AngleClass AngleClass => _AngleClass ?? (_AngleClass = new Package.AngleClass());

	private Package.AngleCommandedClass _AngleCommandedClass;
	/// <summary>
	/// <inheritdoc cref="Package.AngleCommandedClass" path="/summary" />
	/// </summary>
	public Package.AngleCommandedClass AngleCommandedClass => _AngleCommandedClass ?? (_AngleCommandedClass = new Package.AngleCommandedClass());

	private Package.AngleActualClass _AngleActualClass;
	/// <summary>
	/// <inheritdoc cref="Package.AngleActualClass" path="/summary" />
	/// </summary>
	public Package.AngleActualClass AngleActualClass => _AngleActualClass ?? (_AngleActualClass = new Package.AngleActualClass());

	private Package.AngularAccelerationClass _AngularAccelerationClass;
	/// <summary>
	/// <inheritdoc cref="Package.AngularAccelerationClass" path="/summary" />
	/// </summary>
	public Package.AngularAccelerationClass AngularAccelerationClass => _AngularAccelerationClass ?? (_AngularAccelerationClass = new Package.AngularAccelerationClass());

	private Package.AngularVelocityClass _AngularVelocityClass;
	/// <summary>
	/// <inheritdoc cref="Package.AngularVelocityClass" path="/summary" />
	/// </summary>
	public Package.AngularVelocityClass AngularVelocityClass => _AngularVelocityClass ?? (_AngularVelocityClass = new Package.AngularVelocityClass());

	private Package.AxisFeedrateClass _AxisFeedrateClass;
	/// <summary>
	/// <inheritdoc cref="Package.AxisFeedrateClass" path="/summary" />
	/// </summary>
	public Package.AxisFeedrateClass AxisFeedrateClass => _AxisFeedrateClass ?? (_AxisFeedrateClass = new Package.AxisFeedrateClass());

	private Package.AxisFeedrateActualClass _AxisFeedrateActualClass;
	/// <summary>
	/// <inheritdoc cref="Package.AxisFeedrateActualClass" path="/summary" />
	/// </summary>
	public Package.AxisFeedrateActualClass AxisFeedrateActualClass => _AxisFeedrateActualClass ?? (_AxisFeedrateActualClass = new Package.AxisFeedrateActualClass());

	private Package.AxisFeedrateCommandedClass _AxisFeedrateCommandedClass;
	/// <summary>
	/// <inheritdoc cref="Package.AxisFeedrateCommandedClass" path="/summary" />
	/// </summary>
	public Package.AxisFeedrateCommandedClass AxisFeedrateCommandedClass => _AxisFeedrateCommandedClass ?? (_AxisFeedrateCommandedClass = new Package.AxisFeedrateCommandedClass());

	private Package.AxisFeedrateJogClass _AxisFeedrateJogClass;
	/// <summary>
	/// <inheritdoc cref="Package.AxisFeedrateJogClass" path="/summary" />
	/// </summary>
	public Package.AxisFeedrateJogClass AxisFeedrateJogClass => _AxisFeedrateJogClass ?? (_AxisFeedrateJogClass = new Package.AxisFeedrateJogClass());

	private Package.AxisFeedrateProgrammedClass _AxisFeedrateProgrammedClass;
	/// <summary>
	/// <inheritdoc cref="Package.AxisFeedrateProgrammedClass" path="/summary" />
	/// </summary>
	public Package.AxisFeedrateProgrammedClass AxisFeedrateProgrammedClass => _AxisFeedrateProgrammedClass ?? (_AxisFeedrateProgrammedClass = new Package.AxisFeedrateProgrammedClass());

	private Package.AxisFeedrateRapidClass _AxisFeedrateRapidClass;
	/// <summary>
	/// <inheritdoc cref="Package.AxisFeedrateRapidClass" path="/summary" />
	/// </summary>
	public Package.AxisFeedrateRapidClass AxisFeedrateRapidClass => _AxisFeedrateRapidClass ?? (_AxisFeedrateRapidClass = new Package.AxisFeedrateRapidClass());

	private Package.AxisFeedrateOverrideClass _AxisFeedrateOverrideClass;
	/// <summary>
	/// <inheritdoc cref="Package.AxisFeedrateOverrideClass" path="/summary" />
	/// </summary>
	public Package.AxisFeedrateOverrideClass AxisFeedrateOverrideClass => _AxisFeedrateOverrideClass ?? (_AxisFeedrateOverrideClass = new Package.AxisFeedrateOverrideClass());

	private Package.CapacityFluidClass _CapacityFluidClass;
	/// <summary>
	/// <inheritdoc cref="Package.CapacityFluidClass" path="/summary" />
	/// </summary>
	public Package.CapacityFluidClass CapacityFluidClass => _CapacityFluidClass ?? (_CapacityFluidClass = new Package.CapacityFluidClass());

	private Package.CapacitySpatialClass _CapacitySpatialClass;
	/// <summary>
	/// <inheritdoc cref="Package.CapacitySpatialClass" path="/summary" />
	/// </summary>
	public Package.CapacitySpatialClass CapacitySpatialClass => _CapacitySpatialClass ?? (_CapacitySpatialClass = new Package.CapacitySpatialClass());

	private Package.ConcentrationClass _ConcentrationClass;
	/// <summary>
	/// <inheritdoc cref="Package.ConcentrationClass" path="/summary" />
	/// </summary>
	public Package.ConcentrationClass ConcentrationClass => _ConcentrationClass ?? (_ConcentrationClass = new Package.ConcentrationClass());

	private Package.ConductivityClass _ConductivityClass;
	/// <summary>
	/// <inheritdoc cref="Package.ConductivityClass" path="/summary" />
	/// </summary>
	public Package.ConductivityClass ConductivityClass => _ConductivityClass ?? (_ConductivityClass = new Package.ConductivityClass());

	private Package.CuttingSpeedClass _CuttingSpeedClass;
	/// <summary>
	/// <inheritdoc cref="Package.CuttingSpeedClass" path="/summary" />
	/// </summary>
	public Package.CuttingSpeedClass CuttingSpeedClass => _CuttingSpeedClass ?? (_CuttingSpeedClass = new Package.CuttingSpeedClass());

	private Package.CuttingSpeedActualClass _CuttingSpeedActualClass;
	/// <summary>
	/// <inheritdoc cref="Package.CuttingSpeedActualClass" path="/summary" />
	/// </summary>
	public Package.CuttingSpeedActualClass CuttingSpeedActualClass => _CuttingSpeedActualClass ?? (_CuttingSpeedActualClass = new Package.CuttingSpeedActualClass());

	private Package.CuttingSpeedCommandedClass _CuttingSpeedCommandedClass;
	/// <summary>
	/// <inheritdoc cref="Package.CuttingSpeedCommandedClass" path="/summary" />
	/// </summary>
	public Package.CuttingSpeedCommandedClass CuttingSpeedCommandedClass => _CuttingSpeedCommandedClass ?? (_CuttingSpeedCommandedClass = new Package.CuttingSpeedCommandedClass());

	private Package.CuttingSpeedProgrammedClass _CuttingSpeedProgrammedClass;
	/// <summary>
	/// <inheritdoc cref="Package.CuttingSpeedProgrammedClass" path="/summary" />
	/// </summary>
	public Package.CuttingSpeedProgrammedClass CuttingSpeedProgrammedClass => _CuttingSpeedProgrammedClass ?? (_CuttingSpeedProgrammedClass = new Package.CuttingSpeedProgrammedClass());

	private Package.DensityClass _DensityClass;
	/// <summary>
	/// <inheritdoc cref="Package.DensityClass" path="/summary" />
	/// </summary>
	public Package.DensityClass DensityClass => _DensityClass ?? (_DensityClass = new Package.DensityClass());

	private Package.DepositionAccelerationVolumetricClass _DepositionAccelerationVolumetricClass;
	/// <summary>
	/// <inheritdoc cref="Package.DepositionAccelerationVolumetricClass" path="/summary" />
	/// </summary>
	public Package.DepositionAccelerationVolumetricClass DepositionAccelerationVolumetricClass => _DepositionAccelerationVolumetricClass ?? (_DepositionAccelerationVolumetricClass = new Package.DepositionAccelerationVolumetricClass());

	private Package.DepositionAccelerationVolumetricActualClass _DepositionAccelerationVolumetricActualClass;
	/// <summary>
	/// <inheritdoc cref="Package.DepositionAccelerationVolumetricActualClass" path="/summary" />
	/// </summary>
	public Package.DepositionAccelerationVolumetricActualClass DepositionAccelerationVolumetricActualClass => _DepositionAccelerationVolumetricActualClass ?? (_DepositionAccelerationVolumetricActualClass = new Package.DepositionAccelerationVolumetricActualClass());

	private Package.DepositionAccelerationVolumetricCommandedClass _DepositionAccelerationVolumetricCommandedClass;
	/// <summary>
	/// <inheritdoc cref="Package.DepositionAccelerationVolumetricCommandedClass" path="/summary" />
	/// </summary>
	public Package.DepositionAccelerationVolumetricCommandedClass DepositionAccelerationVolumetricCommandedClass => _DepositionAccelerationVolumetricCommandedClass ?? (_DepositionAccelerationVolumetricCommandedClass = new Package.DepositionAccelerationVolumetricCommandedClass());

	private Package.DepositionDensityClass _DepositionDensityClass;
	/// <summary>
	/// <inheritdoc cref="Package.DepositionDensityClass" path="/summary" />
	/// </summary>
	public Package.DepositionDensityClass DepositionDensityClass => _DepositionDensityClass ?? (_DepositionDensityClass = new Package.DepositionDensityClass());

	private Package.DepositionDensityActualClass _DepositionDensityActualClass;
	/// <summary>
	/// <inheritdoc cref="Package.DepositionDensityActualClass" path="/summary" />
	/// </summary>
	public Package.DepositionDensityActualClass DepositionDensityActualClass => _DepositionDensityActualClass ?? (_DepositionDensityActualClass = new Package.DepositionDensityActualClass());

	private Package.DepositionDensityCommandedClass _DepositionDensityCommandedClass;
	/// <summary>
	/// <inheritdoc cref="Package.DepositionDensityCommandedClass" path="/summary" />
	/// </summary>
	public Package.DepositionDensityCommandedClass DepositionDensityCommandedClass => _DepositionDensityCommandedClass ?? (_DepositionDensityCommandedClass = new Package.DepositionDensityCommandedClass());

	private Package.DepositionMassClass _DepositionMassClass;
	/// <summary>
	/// <inheritdoc cref="Package.DepositionMassClass" path="/summary" />
	/// </summary>
	public Package.DepositionMassClass DepositionMassClass => _DepositionMassClass ?? (_DepositionMassClass = new Package.DepositionMassClass());

	private Package.DepositionMassActualClass _DepositionMassActualClass;
	/// <summary>
	/// <inheritdoc cref="Package.DepositionMassActualClass" path="/summary" />
	/// </summary>
	public Package.DepositionMassActualClass DepositionMassActualClass => _DepositionMassActualClass ?? (_DepositionMassActualClass = new Package.DepositionMassActualClass());

	private Package.DepositionMassCommandedClass _DepositionMassCommandedClass;
	/// <summary>
	/// <inheritdoc cref="Package.DepositionMassCommandedClass" path="/summary" />
	/// </summary>
	public Package.DepositionMassCommandedClass DepositionMassCommandedClass => _DepositionMassCommandedClass ?? (_DepositionMassCommandedClass = new Package.DepositionMassCommandedClass());

	private Package.DepositionRateVolumetricClass _DepositionRateVolumetricClass;
	/// <summary>
	/// <inheritdoc cref="Package.DepositionRateVolumetricClass" path="/summary" />
	/// </summary>
	public Package.DepositionRateVolumetricClass DepositionRateVolumetricClass => _DepositionRateVolumetricClass ?? (_DepositionRateVolumetricClass = new Package.DepositionRateVolumetricClass());

	private Package.DepositionRateVolumetricActualClass _DepositionRateVolumetricActualClass;
	/// <summary>
	/// <inheritdoc cref="Package.DepositionRateVolumetricActualClass" path="/summary" />
	/// </summary>
	public Package.DepositionRateVolumetricActualClass DepositionRateVolumetricActualClass => _DepositionRateVolumetricActualClass ?? (_DepositionRateVolumetricActualClass = new Package.DepositionRateVolumetricActualClass());

	private Package.DepositionRateVolumetricCommandedClass _DepositionRateVolumetricCommandedClass;
	/// <summary>
	/// <inheritdoc cref="Package.DepositionRateVolumetricCommandedClass" path="/summary" />
	/// </summary>
	public Package.DepositionRateVolumetricCommandedClass DepositionRateVolumetricCommandedClass => _DepositionRateVolumetricCommandedClass ?? (_DepositionRateVolumetricCommandedClass = new Package.DepositionRateVolumetricCommandedClass());

	private Package.DepositionVolumeClass _DepositionVolumeClass;
	/// <summary>
	/// <inheritdoc cref="Package.DepositionVolumeClass" path="/summary" />
	/// </summary>
	public Package.DepositionVolumeClass DepositionVolumeClass => _DepositionVolumeClass ?? (_DepositionVolumeClass = new Package.DepositionVolumeClass());

	private Package.DepositionVolumeActualClass _DepositionVolumeActualClass;
	/// <summary>
	/// <inheritdoc cref="Package.DepositionVolumeActualClass" path="/summary" />
	/// </summary>
	public Package.DepositionVolumeActualClass DepositionVolumeActualClass => _DepositionVolumeActualClass ?? (_DepositionVolumeActualClass = new Package.DepositionVolumeActualClass());

	private Package.DepositionVolumeCommandedClass _DepositionVolumeCommandedClass;
	/// <summary>
	/// <inheritdoc cref="Package.DepositionVolumeCommandedClass" path="/summary" />
	/// </summary>
	public Package.DepositionVolumeCommandedClass DepositionVolumeCommandedClass => _DepositionVolumeCommandedClass ?? (_DepositionVolumeCommandedClass = new Package.DepositionVolumeCommandedClass());

	private Package.DisplacementClass _DisplacementClass;
	/// <summary>
	/// <inheritdoc cref="Package.DisplacementClass" path="/summary" />
	/// </summary>
	public Package.DisplacementClass DisplacementClass => _DisplacementClass ?? (_DisplacementClass = new Package.DisplacementClass());

	private Package.ElectricalEnergyClass _ElectricalEnergyClass;
	/// <summary>
	/// <inheritdoc cref="Package.ElectricalEnergyClass" path="/summary" />
	/// </summary>
	public Package.ElectricalEnergyClass ElectricalEnergyClass => _ElectricalEnergyClass ?? (_ElectricalEnergyClass = new Package.ElectricalEnergyClass());

	private Package.EquipmentTimerClass _EquipmentTimerClass;
	/// <summary>
	/// <inheritdoc cref="Package.EquipmentTimerClass" path="/summary" />
	/// </summary>
	public Package.EquipmentTimerClass EquipmentTimerClass => _EquipmentTimerClass ?? (_EquipmentTimerClass = new Package.EquipmentTimerClass());

	private Package.EquipmentTimerLoadedClass _EquipmentTimerLoadedClass;
	/// <summary>
	/// <inheritdoc cref="Package.EquipmentTimerLoadedClass" path="/summary" />
	/// </summary>
	public Package.EquipmentTimerLoadedClass EquipmentTimerLoadedClass => _EquipmentTimerLoadedClass ?? (_EquipmentTimerLoadedClass = new Package.EquipmentTimerLoadedClass());

	private Package.EquipmentTimerWorkingClass _EquipmentTimerWorkingClass;
	/// <summary>
	/// <inheritdoc cref="Package.EquipmentTimerWorkingClass" path="/summary" />
	/// </summary>
	public Package.EquipmentTimerWorkingClass EquipmentTimerWorkingClass => _EquipmentTimerWorkingClass ?? (_EquipmentTimerWorkingClass = new Package.EquipmentTimerWorkingClass());

	private Package.EquipmentTimerOperatingClass _EquipmentTimerOperatingClass;
	/// <summary>
	/// <inheritdoc cref="Package.EquipmentTimerOperatingClass" path="/summary" />
	/// </summary>
	public Package.EquipmentTimerOperatingClass EquipmentTimerOperatingClass => _EquipmentTimerOperatingClass ?? (_EquipmentTimerOperatingClass = new Package.EquipmentTimerOperatingClass());

	private Package.EquipmentTimerPoweredClass _EquipmentTimerPoweredClass;
	/// <summary>
	/// <inheritdoc cref="Package.EquipmentTimerPoweredClass" path="/summary" />
	/// </summary>
	public Package.EquipmentTimerPoweredClass EquipmentTimerPoweredClass => _EquipmentTimerPoweredClass ?? (_EquipmentTimerPoweredClass = new Package.EquipmentTimerPoweredClass());

	private Package.EquipmentTimerDelayClass _EquipmentTimerDelayClass;
	/// <summary>
	/// <inheritdoc cref="Package.EquipmentTimerDelayClass" path="/summary" />
	/// </summary>
	public Package.EquipmentTimerDelayClass EquipmentTimerDelayClass => _EquipmentTimerDelayClass ?? (_EquipmentTimerDelayClass = new Package.EquipmentTimerDelayClass());

	private Package.FillLevelClass _FillLevelClass;
	/// <summary>
	/// <inheritdoc cref="Package.FillLevelClass" path="/summary" />
	/// </summary>
	public Package.FillLevelClass FillLevelClass => _FillLevelClass ?? (_FillLevelClass = new Package.FillLevelClass());

	private Package.FlowClass _FlowClass;
	/// <summary>
	/// <inheritdoc cref="Package.FlowClass" path="/summary" />
	/// </summary>
	public Package.FlowClass FlowClass => _FlowClass ?? (_FlowClass = new Package.FlowClass());

	private Package.FrequencyClass _FrequencyClass;
	/// <summary>
	/// <inheritdoc cref="Package.FrequencyClass" path="/summary" />
	/// </summary>
	public Package.FrequencyClass FrequencyClass => _FrequencyClass ?? (_FrequencyClass = new Package.FrequencyClass());

	private Package.GlobalPositionClass _GlobalPositionClass;
	/// <summary>
	/// <inheritdoc cref="Package.GlobalPositionClass" path="/summary" />
	/// </summary>
	public Package.GlobalPositionClass GlobalPositionClass => _GlobalPositionClass ?? (_GlobalPositionClass = new Package.GlobalPositionClass());

	private Package.LengthClass _LengthClass;
	/// <summary>
	/// <inheritdoc cref="Package.LengthClass" path="/summary" />
	/// </summary>
	public Package.LengthClass LengthClass => _LengthClass ?? (_LengthClass = new Package.LengthClass());

	private Package.LengthStandardClass _LengthStandardClass;
	/// <summary>
	/// <inheritdoc cref="Package.LengthStandardClass" path="/summary" />
	/// </summary>
	public Package.LengthStandardClass LengthStandardClass => _LengthStandardClass ?? (_LengthStandardClass = new Package.LengthStandardClass());

	private Package.LengthRemainingClass _LengthRemainingClass;
	/// <summary>
	/// <inheritdoc cref="Package.LengthRemainingClass" path="/summary" />
	/// </summary>
	public Package.LengthRemainingClass LengthRemainingClass => _LengthRemainingClass ?? (_LengthRemainingClass = new Package.LengthRemainingClass());

	private Package.LengthUseableClass _LengthUseableClass;
	/// <summary>
	/// <inheritdoc cref="Package.LengthUseableClass" path="/summary" />
	/// </summary>
	public Package.LengthUseableClass LengthUseableClass => _LengthUseableClass ?? (_LengthUseableClass = new Package.LengthUseableClass());

	private Package.LevelClass _LevelClass;
	/// <summary>
	/// <inheritdoc cref="Package.LevelClass" path="/summary" />
	/// </summary>
	public Package.LevelClass LevelClass => _LevelClass ?? (_LevelClass = new Package.LevelClass());

	private Package.LinearForceClass _LinearForceClass;
	/// <summary>
	/// <inheritdoc cref="Package.LinearForceClass" path="/summary" />
	/// </summary>
	public Package.LinearForceClass LinearForceClass => _LinearForceClass ?? (_LinearForceClass = new Package.LinearForceClass());

	private Package.LoadClass _LoadClass;
	/// <summary>
	/// <inheritdoc cref="Package.LoadClass" path="/summary" />
	/// </summary>
	public Package.LoadClass LoadClass => _LoadClass ?? (_LoadClass = new Package.LoadClass());

	private Package.MassClass _MassClass;
	/// <summary>
	/// <inheritdoc cref="Package.MassClass" path="/summary" />
	/// </summary>
	public Package.MassClass MassClass => _MassClass ?? (_MassClass = new Package.MassClass());

	private Package.PathFeedrateClass _PathFeedrateClass;
	/// <summary>
	/// <inheritdoc cref="Package.PathFeedrateClass" path="/summary" />
	/// </summary>
	public Package.PathFeedrateClass PathFeedrateClass => _PathFeedrateClass ?? (_PathFeedrateClass = new Package.PathFeedrateClass());

	private Package.PathFeedrateActualClass _PathFeedrateActualClass;
	/// <summary>
	/// <inheritdoc cref="Package.PathFeedrateActualClass" path="/summary" />
	/// </summary>
	public Package.PathFeedrateActualClass PathFeedrateActualClass => _PathFeedrateActualClass ?? (_PathFeedrateActualClass = new Package.PathFeedrateActualClass());

	private Package.PathFeedrateCommandedClass _PathFeedrateCommandedClass;
	/// <summary>
	/// <inheritdoc cref="Package.PathFeedrateCommandedClass" path="/summary" />
	/// </summary>
	public Package.PathFeedrateCommandedClass PathFeedrateCommandedClass => _PathFeedrateCommandedClass ?? (_PathFeedrateCommandedClass = new Package.PathFeedrateCommandedClass());

	private Package.PathFeedrateJogClass _PathFeedrateJogClass;
	/// <summary>
	/// <inheritdoc cref="Package.PathFeedrateJogClass" path="/summary" />
	/// </summary>
	public Package.PathFeedrateJogClass PathFeedrateJogClass => _PathFeedrateJogClass ?? (_PathFeedrateJogClass = new Package.PathFeedrateJogClass());

	private Package.PathFeedrateProgrammedClass _PathFeedrateProgrammedClass;
	/// <summary>
	/// <inheritdoc cref="Package.PathFeedrateProgrammedClass" path="/summary" />
	/// </summary>
	public Package.PathFeedrateProgrammedClass PathFeedrateProgrammedClass => _PathFeedrateProgrammedClass ?? (_PathFeedrateProgrammedClass = new Package.PathFeedrateProgrammedClass());

	private Package.PathFeedrateRapidClass _PathFeedrateRapidClass;
	/// <summary>
	/// <inheritdoc cref="Package.PathFeedrateRapidClass" path="/summary" />
	/// </summary>
	public Package.PathFeedrateRapidClass PathFeedrateRapidClass => _PathFeedrateRapidClass ?? (_PathFeedrateRapidClass = new Package.PathFeedrateRapidClass());

	private Package.PathFeedrateOverrideClass _PathFeedrateOverrideClass;
	/// <summary>
	/// <inheritdoc cref="Package.PathFeedrateOverrideClass" path="/summary" />
	/// </summary>
	public Package.PathFeedrateOverrideClass PathFeedrateOverrideClass => _PathFeedrateOverrideClass ?? (_PathFeedrateOverrideClass = new Package.PathFeedrateOverrideClass());

	private Package.PathFeedratePerRevolutionClass _PathFeedratePerRevolutionClass;
	/// <summary>
	/// <inheritdoc cref="Package.PathFeedratePerRevolutionClass" path="/summary" />
	/// </summary>
	public Package.PathFeedratePerRevolutionClass PathFeedratePerRevolutionClass => _PathFeedratePerRevolutionClass ?? (_PathFeedratePerRevolutionClass = new Package.PathFeedratePerRevolutionClass());

	private Package.PathFeedratePerRevolutionActualClass _PathFeedratePerRevolutionActualClass;
	/// <summary>
	/// <inheritdoc cref="Package.PathFeedratePerRevolutionActualClass" path="/summary" />
	/// </summary>
	public Package.PathFeedratePerRevolutionActualClass PathFeedratePerRevolutionActualClass => _PathFeedratePerRevolutionActualClass ?? (_PathFeedratePerRevolutionActualClass = new Package.PathFeedratePerRevolutionActualClass());

	private Package.PathFeedratePerRevolutionCommandedClass _PathFeedratePerRevolutionCommandedClass;
	/// <summary>
	/// <inheritdoc cref="Package.PathFeedratePerRevolutionCommandedClass" path="/summary" />
	/// </summary>
	public Package.PathFeedratePerRevolutionCommandedClass PathFeedratePerRevolutionCommandedClass => _PathFeedratePerRevolutionCommandedClass ?? (_PathFeedratePerRevolutionCommandedClass = new Package.PathFeedratePerRevolutionCommandedClass());

	private Package.PathFeedratePerRevolutionProgrammedClass _PathFeedratePerRevolutionProgrammedClass;
	/// <summary>
	/// <inheritdoc cref="Package.PathFeedratePerRevolutionProgrammedClass" path="/summary" />
	/// </summary>
	public Package.PathFeedratePerRevolutionProgrammedClass PathFeedratePerRevolutionProgrammedClass => _PathFeedratePerRevolutionProgrammedClass ?? (_PathFeedratePerRevolutionProgrammedClass = new Package.PathFeedratePerRevolutionProgrammedClass());

	private Package.PathPositionClass _PathPositionClass;
	/// <summary>
	/// <inheritdoc cref="Package.PathPositionClass" path="/summary" />
	/// </summary>
	public Package.PathPositionClass PathPositionClass => _PathPositionClass ?? (_PathPositionClass = new Package.PathPositionClass());

	private Package.PathPositionActualClass _PathPositionActualClass;
	/// <summary>
	/// <inheritdoc cref="Package.PathPositionActualClass" path="/summary" />
	/// </summary>
	public Package.PathPositionActualClass PathPositionActualClass => _PathPositionActualClass ?? (_PathPositionActualClass = new Package.PathPositionActualClass());

	private Package.PathPositionCommandedClass _PathPositionCommandedClass;
	/// <summary>
	/// <inheritdoc cref="Package.PathPositionCommandedClass" path="/summary" />
	/// </summary>
	public Package.PathPositionCommandedClass PathPositionCommandedClass => _PathPositionCommandedClass ?? (_PathPositionCommandedClass = new Package.PathPositionCommandedClass());

	private Package.PathPositionTargetClass _PathPositionTargetClass;
	/// <summary>
	/// <inheritdoc cref="Package.PathPositionTargetClass" path="/summary" />
	/// </summary>
	public Package.PathPositionTargetClass PathPositionTargetClass => _PathPositionTargetClass ?? (_PathPositionTargetClass = new Package.PathPositionTargetClass());

	private Package.PathPositionProbeClass _PathPositionProbeClass;
	/// <summary>
	/// <inheritdoc cref="Package.PathPositionProbeClass" path="/summary" />
	/// </summary>
	public Package.PathPositionProbeClass PathPositionProbeClass => _PathPositionProbeClass ?? (_PathPositionProbeClass = new Package.PathPositionProbeClass());

	private Package.PHClass _PHClass;
	/// <summary>
	/// <inheritdoc cref="Package.PHClass" path="/summary" />
	/// </summary>
	public Package.PHClass PHClass => _PHClass ?? (_PHClass = new Package.PHClass());

	private Package.PositionClass _PositionClass;
	/// <summary>
	/// <inheritdoc cref="Package.PositionClass" path="/summary" />
	/// </summary>
	public Package.PositionClass PositionClass => _PositionClass ?? (_PositionClass = new Package.PositionClass());

	private Package.PositionActualClass _PositionActualClass;
	/// <summary>
	/// <inheritdoc cref="Package.PositionActualClass" path="/summary" />
	/// </summary>
	public Package.PositionActualClass PositionActualClass => _PositionActualClass ?? (_PositionActualClass = new Package.PositionActualClass());

	private Package.PositionCommandedClass _PositionCommandedClass;
	/// <summary>
	/// <inheritdoc cref="Package.PositionCommandedClass" path="/summary" />
	/// </summary>
	public Package.PositionCommandedClass PositionCommandedClass => _PositionCommandedClass ?? (_PositionCommandedClass = new Package.PositionCommandedClass());

	private Package.PositionProgrammedClass _PositionProgrammedClass;
	/// <summary>
	/// <inheritdoc cref="Package.PositionProgrammedClass" path="/summary" />
	/// </summary>
	public Package.PositionProgrammedClass PositionProgrammedClass => _PositionProgrammedClass ?? (_PositionProgrammedClass = new Package.PositionProgrammedClass());

	private Package.PositionTargetClass _PositionTargetClass;
	/// <summary>
	/// <inheritdoc cref="Package.PositionTargetClass" path="/summary" />
	/// </summary>
	public Package.PositionTargetClass PositionTargetClass => _PositionTargetClass ?? (_PositionTargetClass = new Package.PositionTargetClass());

	private Package.PowerFactorClass _PowerFactorClass;
	/// <summary>
	/// <inheritdoc cref="Package.PowerFactorClass" path="/summary" />
	/// </summary>
	public Package.PowerFactorClass PowerFactorClass => _PowerFactorClass ?? (_PowerFactorClass = new Package.PowerFactorClass());

	private Package.PressureClass _PressureClass;
	/// <summary>
	/// <inheritdoc cref="Package.PressureClass" path="/summary" />
	/// </summary>
	public Package.PressureClass PressureClass => _PressureClass ?? (_PressureClass = new Package.PressureClass());

	private Package.ProcessTimerClass _ProcessTimerClass;
	/// <summary>
	/// <inheritdoc cref="Package.ProcessTimerClass" path="/summary" />
	/// </summary>
	public Package.ProcessTimerClass ProcessTimerClass => _ProcessTimerClass ?? (_ProcessTimerClass = new Package.ProcessTimerClass());

	private Package.ProcessTimerProcessClass _ProcessTimerProcessClass;
	/// <summary>
	/// <inheritdoc cref="Package.ProcessTimerProcessClass" path="/summary" />
	/// </summary>
	public Package.ProcessTimerProcessClass ProcessTimerProcessClass => _ProcessTimerProcessClass ?? (_ProcessTimerProcessClass = new Package.ProcessTimerProcessClass());

	private Package.ProcessTimerDelayClass _ProcessTimerDelayClass;
	/// <summary>
	/// <inheritdoc cref="Package.ProcessTimerDelayClass" path="/summary" />
	/// </summary>
	public Package.ProcessTimerDelayClass ProcessTimerDelayClass => _ProcessTimerDelayClass ?? (_ProcessTimerDelayClass = new Package.ProcessTimerDelayClass());

	private Package.ResistanceClass _ResistanceClass;
	/// <summary>
	/// <inheritdoc cref="Package.ResistanceClass" path="/summary" />
	/// </summary>
	public Package.ResistanceClass ResistanceClass => _ResistanceClass ?? (_ResistanceClass = new Package.ResistanceClass());

	private Package.RotaryVelocityClass _RotaryVelocityClass;
	/// <summary>
	/// <inheritdoc cref="Package.RotaryVelocityClass" path="/summary" />
	/// </summary>
	public Package.RotaryVelocityClass RotaryVelocityClass => _RotaryVelocityClass ?? (_RotaryVelocityClass = new Package.RotaryVelocityClass());

	private Package.RotaryVelocityActualClass _RotaryVelocityActualClass;
	/// <summary>
	/// <inheritdoc cref="Package.RotaryVelocityActualClass" path="/summary" />
	/// </summary>
	public Package.RotaryVelocityActualClass RotaryVelocityActualClass => _RotaryVelocityActualClass ?? (_RotaryVelocityActualClass = new Package.RotaryVelocityActualClass());

	private Package.RotaryVelocityCommandedClass _RotaryVelocityCommandedClass;
	/// <summary>
	/// <inheritdoc cref="Package.RotaryVelocityCommandedClass" path="/summary" />
	/// </summary>
	public Package.RotaryVelocityCommandedClass RotaryVelocityCommandedClass => _RotaryVelocityCommandedClass ?? (_RotaryVelocityCommandedClass = new Package.RotaryVelocityCommandedClass());

	private Package.RotaryVelocityProgrammedClass _RotaryVelocityProgrammedClass;
	/// <summary>
	/// <inheritdoc cref="Package.RotaryVelocityProgrammedClass" path="/summary" />
	/// </summary>
	public Package.RotaryVelocityProgrammedClass RotaryVelocityProgrammedClass => _RotaryVelocityProgrammedClass ?? (_RotaryVelocityProgrammedClass = new Package.RotaryVelocityProgrammedClass());

	private Package.RotaryVelocityOverrideClass _RotaryVelocityOverrideClass;
	/// <summary>
	/// <inheritdoc cref="Package.RotaryVelocityOverrideClass" path="/summary" />
	/// </summary>
	public Package.RotaryVelocityOverrideClass RotaryVelocityOverrideClass => _RotaryVelocityOverrideClass ?? (_RotaryVelocityOverrideClass = new Package.RotaryVelocityOverrideClass());

	private Package.SoundLevelClass _SoundLevelClass;
	/// <summary>
	/// <inheritdoc cref="Package.SoundLevelClass" path="/summary" />
	/// </summary>
	public Package.SoundLevelClass SoundLevelClass => _SoundLevelClass ?? (_SoundLevelClass = new Package.SoundLevelClass());

	private Package.SoundLevelNoScaleClass _SoundLevelNoScaleClass;
	/// <summary>
	/// <inheritdoc cref="Package.SoundLevelNoScaleClass" path="/summary" />
	/// </summary>
	public Package.SoundLevelNoScaleClass SoundLevelNoScaleClass => _SoundLevelNoScaleClass ?? (_SoundLevelNoScaleClass = new Package.SoundLevelNoScaleClass());

	private Package.SoundLevelAScaleClass _SoundLevelAScaleClass;
	/// <summary>
	/// <inheritdoc cref="Package.SoundLevelAScaleClass" path="/summary" />
	/// </summary>
	public Package.SoundLevelAScaleClass SoundLevelAScaleClass => _SoundLevelAScaleClass ?? (_SoundLevelAScaleClass = new Package.SoundLevelAScaleClass());

	private Package.SoundLevelBScaleClass _SoundLevelBScaleClass;
	/// <summary>
	/// <inheritdoc cref="Package.SoundLevelBScaleClass" path="/summary" />
	/// </summary>
	public Package.SoundLevelBScaleClass SoundLevelBScaleClass => _SoundLevelBScaleClass ?? (_SoundLevelBScaleClass = new Package.SoundLevelBScaleClass());

	private Package.SoundLevelCScaleClass _SoundLevelCScaleClass;
	/// <summary>
	/// <inheritdoc cref="Package.SoundLevelCScaleClass" path="/summary" />
	/// </summary>
	public Package.SoundLevelCScaleClass SoundLevelCScaleClass => _SoundLevelCScaleClass ?? (_SoundLevelCScaleClass = new Package.SoundLevelCScaleClass());

	private Package.SoundLevelDScaleClass _SoundLevelDScaleClass;
	/// <summary>
	/// <inheritdoc cref="Package.SoundLevelDScaleClass" path="/summary" />
	/// </summary>
	public Package.SoundLevelDScaleClass SoundLevelDScaleClass => _SoundLevelDScaleClass ?? (_SoundLevelDScaleClass = new Package.SoundLevelDScaleClass());

	private Package.SpindleSpeedClass _SpindleSpeedClass;
	/// <summary>
	/// <inheritdoc cref="Package.SpindleSpeedClass" path="/summary" />
	/// </summary>
	public Package.SpindleSpeedClass SpindleSpeedClass => _SpindleSpeedClass ?? (_SpindleSpeedClass = new Package.SpindleSpeedClass());

	private Package.SpindleSpeedActualClass _SpindleSpeedActualClass;
	/// <summary>
	/// <inheritdoc cref="Package.SpindleSpeedActualClass" path="/summary" />
	/// </summary>
	public Package.SpindleSpeedActualClass SpindleSpeedActualClass => _SpindleSpeedActualClass ?? (_SpindleSpeedActualClass = new Package.SpindleSpeedActualClass());

	private Package.SpindleSpeedCommandedClass _SpindleSpeedCommandedClass;
	/// <summary>
	/// <inheritdoc cref="Package.SpindleSpeedCommandedClass" path="/summary" />
	/// </summary>
	public Package.SpindleSpeedCommandedClass SpindleSpeedCommandedClass => _SpindleSpeedCommandedClass ?? (_SpindleSpeedCommandedClass = new Package.SpindleSpeedCommandedClass());

	private Package.SpindleSpeedOverrideClass _SpindleSpeedOverrideClass;
	/// <summary>
	/// <inheritdoc cref="Package.SpindleSpeedOverrideClass" path="/summary" />
	/// </summary>
	public Package.SpindleSpeedOverrideClass SpindleSpeedOverrideClass => _SpindleSpeedOverrideClass ?? (_SpindleSpeedOverrideClass = new Package.SpindleSpeedOverrideClass());

	private Package.StrainClass _StrainClass;
	/// <summary>
	/// <inheritdoc cref="Package.StrainClass" path="/summary" />
	/// </summary>
	public Package.StrainClass StrainClass => _StrainClass ?? (_StrainClass = new Package.StrainClass());

	private Package.TemperatureClass _TemperatureClass;
	/// <summary>
	/// <inheritdoc cref="Package.TemperatureClass" path="/summary" />
	/// </summary>
	public Package.TemperatureClass TemperatureClass => _TemperatureClass ?? (_TemperatureClass = new Package.TemperatureClass());

	private Package.TensionClass _TensionClass;
	/// <summary>
	/// <inheritdoc cref="Package.TensionClass" path="/summary" />
	/// </summary>
	public Package.TensionClass TensionClass => _TensionClass ?? (_TensionClass = new Package.TensionClass());

	private Package.TiltClass _TiltClass;
	/// <summary>
	/// <inheritdoc cref="Package.TiltClass" path="/summary" />
	/// </summary>
	public Package.TiltClass TiltClass => _TiltClass ?? (_TiltClass = new Package.TiltClass());

	private Package.TorqueClass _TorqueClass;
	/// <summary>
	/// <inheritdoc cref="Package.TorqueClass" path="/summary" />
	/// </summary>
	public Package.TorqueClass TorqueClass => _TorqueClass ?? (_TorqueClass = new Package.TorqueClass());

	private Package.VelocityClass _VelocityClass;
	/// <summary>
	/// <inheritdoc cref="Package.VelocityClass" path="/summary" />
	/// </summary>
	public Package.VelocityClass VelocityClass => _VelocityClass ?? (_VelocityClass = new Package.VelocityClass());

	private Package.ViscosityClass _ViscosityClass;
	/// <summary>
	/// <inheritdoc cref="Package.ViscosityClass" path="/summary" />
	/// </summary>
	public Package.ViscosityClass ViscosityClass => _ViscosityClass ?? (_ViscosityClass = new Package.ViscosityClass());

	private Package.VoltageClass _VoltageClass;
	/// <summary>
	/// <inheritdoc cref="Package.VoltageClass" path="/summary" />
	/// </summary>
	public Package.VoltageClass VoltageClass => _VoltageClass ?? (_VoltageClass = new Package.VoltageClass());

	private Package.VoltageAlternatingClass _VoltageAlternatingClass;
	/// <summary>
	/// <inheritdoc cref="Package.VoltageAlternatingClass" path="/summary" />
	/// </summary>
	public Package.VoltageAlternatingClass VoltageAlternatingClass => _VoltageAlternatingClass ?? (_VoltageAlternatingClass = new Package.VoltageAlternatingClass());

	private Package.VoltageDirectClass _VoltageDirectClass;
	/// <summary>
	/// <inheritdoc cref="Package.VoltageDirectClass" path="/summary" />
	/// </summary>
	public Package.VoltageDirectClass VoltageDirectClass => _VoltageDirectClass ?? (_VoltageDirectClass = new Package.VoltageDirectClass());

	private Package.VoltageActualClass _VoltageActualClass;
	/// <summary>
	/// <inheritdoc cref="Package.VoltageActualClass" path="/summary" />
	/// </summary>
	public Package.VoltageActualClass VoltageActualClass => _VoltageActualClass ?? (_VoltageActualClass = new Package.VoltageActualClass());

	private Package.VoltageTargetClass _VoltageTargetClass;
	/// <summary>
	/// <inheritdoc cref="Package.VoltageTargetClass" path="/summary" />
	/// </summary>
	public Package.VoltageTargetClass VoltageTargetClass => _VoltageTargetClass ?? (_VoltageTargetClass = new Package.VoltageTargetClass());

	private Package.VoltAmpereClass _VoltAmpereClass;
	/// <summary>
	/// <inheritdoc cref="Package.VoltAmpereClass" path="/summary" />
	/// </summary>
	public Package.VoltAmpereClass VoltAmpereClass => _VoltAmpereClass ?? (_VoltAmpereClass = new Package.VoltAmpereClass());

	private Package.VoltAmpereReactiveClass _VoltAmpereReactiveClass;
	/// <summary>
	/// <inheritdoc cref="Package.VoltAmpereReactiveClass" path="/summary" />
	/// </summary>
	public Package.VoltAmpereReactiveClass VoltAmpereReactiveClass => _VoltAmpereReactiveClass ?? (_VoltAmpereReactiveClass = new Package.VoltAmpereReactiveClass());

	private Package.VolumeFluidClass _VolumeFluidClass;
	/// <summary>
	/// <inheritdoc cref="Package.VolumeFluidClass" path="/summary" />
	/// </summary>
	public Package.VolumeFluidClass VolumeFluidClass => _VolumeFluidClass ?? (_VolumeFluidClass = new Package.VolumeFluidClass());

	private Package.VolumeFluidActualClass _VolumeFluidActualClass;
	/// <summary>
	/// <inheritdoc cref="Package.VolumeFluidActualClass" path="/summary" />
	/// </summary>
	public Package.VolumeFluidActualClass VolumeFluidActualClass => _VolumeFluidActualClass ?? (_VolumeFluidActualClass = new Package.VolumeFluidActualClass());

	private Package.VolumeFluidConsumedClass _VolumeFluidConsumedClass;
	/// <summary>
	/// <inheritdoc cref="Package.VolumeFluidConsumedClass" path="/summary" />
	/// </summary>
	public Package.VolumeFluidConsumedClass VolumeFluidConsumedClass => _VolumeFluidConsumedClass ?? (_VolumeFluidConsumedClass = new Package.VolumeFluidConsumedClass());

	private Package.VolumeSpatialClass _VolumeSpatialClass;
	/// <summary>
	/// <inheritdoc cref="Package.VolumeSpatialClass" path="/summary" />
	/// </summary>
	public Package.VolumeSpatialClass VolumeSpatialClass => _VolumeSpatialClass ?? (_VolumeSpatialClass = new Package.VolumeSpatialClass());

	private Package.VolumeSpatialActualClass _VolumeSpatialActualClass;
	/// <summary>
	/// <inheritdoc cref="Package.VolumeSpatialActualClass" path="/summary" />
	/// </summary>
	public Package.VolumeSpatialActualClass VolumeSpatialActualClass => _VolumeSpatialActualClass ?? (_VolumeSpatialActualClass = new Package.VolumeSpatialActualClass());

	private Package.VolumeSpatialConsumedClass _VolumeSpatialConsumedClass;
	/// <summary>
	/// <inheritdoc cref="Package.VolumeSpatialConsumedClass" path="/summary" />
	/// </summary>
	public Package.VolumeSpatialConsumedClass VolumeSpatialConsumedClass => _VolumeSpatialConsumedClass ?? (_VolumeSpatialConsumedClass = new Package.VolumeSpatialConsumedClass());

	private Package.WattageClass _WattageClass;
	/// <summary>
	/// <inheritdoc cref="Package.WattageClass" path="/summary" />
	/// </summary>
	public Package.WattageClass WattageClass => _WattageClass ?? (_WattageClass = new Package.WattageClass());

	private Package.WattageActualClass _WattageActualClass;
	/// <summary>
	/// <inheritdoc cref="Package.WattageActualClass" path="/summary" />
	/// </summary>
	public Package.WattageActualClass WattageActualClass => _WattageActualClass ?? (_WattageActualClass = new Package.WattageActualClass());

	private Package.WattageTargetClass _WattageTargetClass;
	/// <summary>
	/// <inheritdoc cref="Package.WattageTargetClass" path="/summary" />
	/// </summary>
	public Package.WattageTargetClass WattageTargetClass => _WattageTargetClass ?? (_WattageTargetClass = new Package.WattageTargetClass());

	private Package.AmperageDCClass _AmperageDCClass;
	/// <summary>
	/// <inheritdoc cref="Package.AmperageDCClass" path="/summary" />
	/// </summary>
	public Package.AmperageDCClass AmperageDCClass => _AmperageDCClass ?? (_AmperageDCClass = new Package.AmperageDCClass());

	private Package.AmperageDCActualClass _AmperageDCActualClass;
	/// <summary>
	/// <inheritdoc cref="Package.AmperageDCActualClass" path="/summary" />
	/// </summary>
	public Package.AmperageDCActualClass AmperageDCActualClass => _AmperageDCActualClass ?? (_AmperageDCActualClass = new Package.AmperageDCActualClass());

	private Package.AmperageDCCommandedClass _AmperageDCCommandedClass;
	/// <summary>
	/// <inheritdoc cref="Package.AmperageDCCommandedClass" path="/summary" />
	/// </summary>
	public Package.AmperageDCCommandedClass AmperageDCCommandedClass => _AmperageDCCommandedClass ?? (_AmperageDCCommandedClass = new Package.AmperageDCCommandedClass());

	private Package.AmperageDCProgrammedClass _AmperageDCProgrammedClass;
	/// <summary>
	/// <inheritdoc cref="Package.AmperageDCProgrammedClass" path="/summary" />
	/// </summary>
	public Package.AmperageDCProgrammedClass AmperageDCProgrammedClass => _AmperageDCProgrammedClass ?? (_AmperageDCProgrammedClass = new Package.AmperageDCProgrammedClass());

	private Package.AmperageACClass _AmperageACClass;
	/// <summary>
	/// <inheritdoc cref="Package.AmperageACClass" path="/summary" />
	/// </summary>
	public Package.AmperageACClass AmperageACClass => _AmperageACClass ?? (_AmperageACClass = new Package.AmperageACClass());

	private Package.AmperageACActualClass _AmperageACActualClass;
	/// <summary>
	/// <inheritdoc cref="Package.AmperageACActualClass" path="/summary" />
	/// </summary>
	public Package.AmperageACActualClass AmperageACActualClass => _AmperageACActualClass ?? (_AmperageACActualClass = new Package.AmperageACActualClass());

	private Package.AmperageACCommandedClass _AmperageACCommandedClass;
	/// <summary>
	/// <inheritdoc cref="Package.AmperageACCommandedClass" path="/summary" />
	/// </summary>
	public Package.AmperageACCommandedClass AmperageACCommandedClass => _AmperageACCommandedClass ?? (_AmperageACCommandedClass = new Package.AmperageACCommandedClass());

	private Package.AmperageACProgrammedClass _AmperageACProgrammedClass;
	/// <summary>
	/// <inheritdoc cref="Package.AmperageACProgrammedClass" path="/summary" />
	/// </summary>
	public Package.AmperageACProgrammedClass AmperageACProgrammedClass => _AmperageACProgrammedClass ?? (_AmperageACProgrammedClass = new Package.AmperageACProgrammedClass());

	private Package.VoltageACActualClass _VoltageACActualClass;
	/// <summary>
	/// <inheritdoc cref="Package.VoltageACActualClass" path="/summary" />
	/// </summary>
	public Package.VoltageACActualClass VoltageACActualClass => _VoltageACActualClass ?? (_VoltageACActualClass = new Package.VoltageACActualClass());

	private Package.VoltageACClass _VoltageACClass;
	/// <summary>
	/// <inheritdoc cref="Package.VoltageACClass" path="/summary" />
	/// </summary>
	public Package.VoltageACClass VoltageACClass => _VoltageACClass ?? (_VoltageACClass = new Package.VoltageACClass());

	private Package.VoltageACCommandedClass _VoltageACCommandedClass;
	/// <summary>
	/// <inheritdoc cref="Package.VoltageACCommandedClass" path="/summary" />
	/// </summary>
	public Package.VoltageACCommandedClass VoltageACCommandedClass => _VoltageACCommandedClass ?? (_VoltageACCommandedClass = new Package.VoltageACCommandedClass());

	private Package.VoltageACProgrammedClass _VoltageACProgrammedClass;
	/// <summary>
	/// <inheritdoc cref="Package.VoltageACProgrammedClass" path="/summary" />
	/// </summary>
	public Package.VoltageACProgrammedClass VoltageACProgrammedClass => _VoltageACProgrammedClass ?? (_VoltageACProgrammedClass = new Package.VoltageACProgrammedClass());

	private Package.VoltageDCActualClass _VoltageDCActualClass;
	/// <summary>
	/// <inheritdoc cref="Package.VoltageDCActualClass" path="/summary" />
	/// </summary>
	public Package.VoltageDCActualClass VoltageDCActualClass => _VoltageDCActualClass ?? (_VoltageDCActualClass = new Package.VoltageDCActualClass());

	private Package.VoltageDCCommandedClass _VoltageDCCommandedClass;
	/// <summary>
	/// <inheritdoc cref="Package.VoltageDCCommandedClass" path="/summary" />
	/// </summary>
	public Package.VoltageDCCommandedClass VoltageDCCommandedClass => _VoltageDCCommandedClass ?? (_VoltageDCCommandedClass = new Package.VoltageDCCommandedClass());

	private Package.VoltageDCProgrammedClass _VoltageDCProgrammedClass;
	/// <summary>
	/// <inheritdoc cref="Package.VoltageDCProgrammedClass" path="/summary" />
	/// </summary>
	public Package.VoltageDCProgrammedClass VoltageDCProgrammedClass => _VoltageDCProgrammedClass ?? (_VoltageDCProgrammedClass = new Package.VoltageDCProgrammedClass());

	private Package.VoltageDCClass _VoltageDCClass;
	/// <summary>
	/// <inheritdoc cref="Package.VoltageDCClass" path="/summary" />
	/// </summary>
	public Package.VoltageDCClass VoltageDCClass => _VoltageDCClass ?? (_VoltageDCClass = new Package.VoltageDCClass());

	private Package.XDimensionClass _XDimensionClass;
	/// <summary>
	/// <inheritdoc cref="Package.XDimensionClass" path="/summary" />
	/// </summary>
	public Package.XDimensionClass XDimensionClass => _XDimensionClass ?? (_XDimensionClass = new Package.XDimensionClass());

	private Package.YDimensionClass _YDimensionClass;
	/// <summary>
	/// <inheritdoc cref="Package.YDimensionClass" path="/summary" />
	/// </summary>
	public Package.YDimensionClass YDimensionClass => _YDimensionClass ?? (_YDimensionClass = new Package.YDimensionClass());

	private Package.ZDimensionClass _ZDimensionClass;
	/// <summary>
	/// <inheritdoc cref="Package.ZDimensionClass" path="/summary" />
	/// </summary>
	public Package.ZDimensionClass ZDimensionClass => _ZDimensionClass ?? (_ZDimensionClass = new Package.ZDimensionClass());

	private Package.DiameterClass _DiameterClass;
	/// <summary>
	/// <inheritdoc cref="Package.DiameterClass" path="/summary" />
	/// </summary>
	public Package.DiameterClass DiameterClass => _DiameterClass ?? (_DiameterClass = new Package.DiameterClass());

	private Package.OrientationActualClass _OrientationActualClass;
	/// <summary>
	/// <inheritdoc cref="Package.OrientationActualClass" path="/summary" />
	/// </summary>
	public Package.OrientationActualClass OrientationActualClass => _OrientationActualClass ?? (_OrientationActualClass = new Package.OrientationActualClass());

	private Package.OrientationClass _OrientationClass;
	/// <summary>
	/// <inheritdoc cref="Package.OrientationClass" path="/summary" />
	/// </summary>
	public Package.OrientationClass OrientationClass => _OrientationClass ?? (_OrientationClass = new Package.OrientationClass());

	private Package.OrientationCommandedClass _OrientationCommandedClass;
	/// <summary>
	/// <inheritdoc cref="Package.OrientationCommandedClass" path="/summary" />
	/// </summary>
	public Package.OrientationCommandedClass OrientationCommandedClass => _OrientationCommandedClass ?? (_OrientationCommandedClass = new Package.OrientationCommandedClass());

	private Package.HumidityRelativeClass _HumidityRelativeClass;
	/// <summary>
	/// <inheritdoc cref="Package.HumidityRelativeClass" path="/summary" />
	/// </summary>
	public Package.HumidityRelativeClass HumidityRelativeClass => _HumidityRelativeClass ?? (_HumidityRelativeClass = new Package.HumidityRelativeClass());

	private Package.HumidityRelativeCommandedClass _HumidityRelativeCommandedClass;
	/// <summary>
	/// <inheritdoc cref="Package.HumidityRelativeCommandedClass" path="/summary" />
	/// </summary>
	public Package.HumidityRelativeCommandedClass HumidityRelativeCommandedClass => _HumidityRelativeCommandedClass ?? (_HumidityRelativeCommandedClass = new Package.HumidityRelativeCommandedClass());

	private Package.HumidityRelativeActualClass _HumidityRelativeActualClass;
	/// <summary>
	/// <inheritdoc cref="Package.HumidityRelativeActualClass" path="/summary" />
	/// </summary>
	public Package.HumidityRelativeActualClass HumidityRelativeActualClass => _HumidityRelativeActualClass ?? (_HumidityRelativeActualClass = new Package.HumidityRelativeActualClass());

	private Package.HumidityAbsoluteClass _HumidityAbsoluteClass;
	/// <summary>
	/// <inheritdoc cref="Package.HumidityAbsoluteClass" path="/summary" />
	/// </summary>
	public Package.HumidityAbsoluteClass HumidityAbsoluteClass => _HumidityAbsoluteClass ?? (_HumidityAbsoluteClass = new Package.HumidityAbsoluteClass());

	private Package.HumidityAbsoluteActualClass _HumidityAbsoluteActualClass;
	/// <summary>
	/// <inheritdoc cref="Package.HumidityAbsoluteActualClass" path="/summary" />
	/// </summary>
	public Package.HumidityAbsoluteActualClass HumidityAbsoluteActualClass => _HumidityAbsoluteActualClass ?? (_HumidityAbsoluteActualClass = new Package.HumidityAbsoluteActualClass());

	private Package.HumidityAbsoluteCommandedClass _HumidityAbsoluteCommandedClass;
	/// <summary>
	/// <inheritdoc cref="Package.HumidityAbsoluteCommandedClass" path="/summary" />
	/// </summary>
	public Package.HumidityAbsoluteCommandedClass HumidityAbsoluteCommandedClass => _HumidityAbsoluteCommandedClass ?? (_HumidityAbsoluteCommandedClass = new Package.HumidityAbsoluteCommandedClass());

	private Package.HumiditySpecificClass _HumiditySpecificClass;
	/// <summary>
	/// <inheritdoc cref="Package.HumiditySpecificClass" path="/summary" />
	/// </summary>
	public Package.HumiditySpecificClass HumiditySpecificClass => _HumiditySpecificClass ?? (_HumiditySpecificClass = new Package.HumiditySpecificClass());

	private Package.HumiditySpecificActualClass _HumiditySpecificActualClass;
	/// <summary>
	/// <inheritdoc cref="Package.HumiditySpecificActualClass" path="/summary" />
	/// </summary>
	public Package.HumiditySpecificActualClass HumiditySpecificActualClass => _HumiditySpecificActualClass ?? (_HumiditySpecificActualClass = new Package.HumiditySpecificActualClass());

	private Package.HumiditySpecificCommandedClass _HumiditySpecificCommandedClass;
	/// <summary>
	/// <inheritdoc cref="Package.HumiditySpecificCommandedClass" path="/summary" />
	/// </summary>
	public Package.HumiditySpecificCommandedClass HumiditySpecificCommandedClass => _HumiditySpecificCommandedClass ?? (_HumiditySpecificCommandedClass = new Package.HumiditySpecificCommandedClass());

	private Package.AngularDecelerationActualClass _AngularDecelerationActualClass;
	/// <summary>
	/// <inheritdoc cref="Package.AngularDecelerationActualClass" path="/summary" />
	/// </summary>
	public Package.AngularDecelerationActualClass AngularDecelerationActualClass => _AngularDecelerationActualClass ?? (_AngularDecelerationActualClass = new Package.AngularDecelerationActualClass());

	private Package.DecelerationProgrammedClass _DecelerationProgrammedClass;
	/// <summary>
	/// <inheritdoc cref="Package.DecelerationProgrammedClass" path="/summary" />
	/// </summary>
	public Package.DecelerationProgrammedClass DecelerationProgrammedClass => _DecelerationProgrammedClass ?? (_DecelerationProgrammedClass = new Package.DecelerationProgrammedClass());

	private Package.AngularDecelerationProgrammedClass _AngularDecelerationProgrammedClass;
	/// <summary>
	/// <inheritdoc cref="Package.AngularDecelerationProgrammedClass" path="/summary" />
	/// </summary>
	public Package.AngularDecelerationProgrammedClass AngularDecelerationProgrammedClass => _AngularDecelerationProgrammedClass ?? (_AngularDecelerationProgrammedClass = new Package.AngularDecelerationProgrammedClass());

	private Package.PressurizationRateClass _PressurizationRateClass;
	/// <summary>
	/// <inheritdoc cref="Package.PressurizationRateClass" path="/summary" />
	/// </summary>
	public Package.PressurizationRateClass PressurizationRateClass => _PressurizationRateClass ?? (_PressurizationRateClass = new Package.PressurizationRateClass());

	private Package.AngularDecelerationCommandedClass _AngularDecelerationCommandedClass;
	/// <summary>
	/// <inheritdoc cref="Package.AngularDecelerationCommandedClass" path="/summary" />
	/// </summary>
	public Package.AngularDecelerationCommandedClass AngularDecelerationCommandedClass => _AngularDecelerationCommandedClass ?? (_AngularDecelerationCommandedClass = new Package.AngularDecelerationCommandedClass());

	private Package.DecelerationClass _DecelerationClass;
	/// <summary>
	/// <inheritdoc cref="Package.DecelerationClass" path="/summary" />
	/// </summary>
	public Package.DecelerationClass DecelerationClass => _DecelerationClass ?? (_DecelerationClass = new Package.DecelerationClass());

	private Package.AssetUpdateRateClass _AssetUpdateRateClass;
	/// <summary>
	/// <inheritdoc cref="Package.AssetUpdateRateClass" path="/summary" />
	/// </summary>
	public Package.AssetUpdateRateClass AssetUpdateRateClass => _AssetUpdateRateClass ?? (_AssetUpdateRateClass = new Package.AssetUpdateRateClass());

	private Package.AngularDecelerationClass _AngularDecelerationClass;
	/// <summary>
	/// <inheritdoc cref="Package.AngularDecelerationClass" path="/summary" />
	/// </summary>
	public Package.AngularDecelerationClass AngularDecelerationClass => _AngularDecelerationClass ?? (_AngularDecelerationClass = new Package.AngularDecelerationClass());

	private Package.ObservationUpdateRateClass _ObservationUpdateRateClass;
	/// <summary>
	/// <inheritdoc cref="Package.ObservationUpdateRateClass" path="/summary" />
	/// </summary>
	public Package.ObservationUpdateRateClass ObservationUpdateRateClass => _ObservationUpdateRateClass ?? (_ObservationUpdateRateClass = new Package.ObservationUpdateRateClass());

	private Package.DecelerationCommandedClass _DecelerationCommandedClass;
	/// <summary>
	/// <inheritdoc cref="Package.DecelerationCommandedClass" path="/summary" />
	/// </summary>
	public Package.DecelerationCommandedClass DecelerationCommandedClass => _DecelerationCommandedClass ?? (_DecelerationCommandedClass = new Package.DecelerationCommandedClass());

	private Package.DecelerationActualClass _DecelerationActualClass;
	/// <summary>
	/// <inheritdoc cref="Package.DecelerationActualClass" path="/summary" />
	/// </summary>
	public Package.DecelerationActualClass DecelerationActualClass => _DecelerationActualClass ?? (_DecelerationActualClass = new Package.DecelerationActualClass());

	private Package.PressureAbsoluteClass _PressureAbsoluteClass;
	/// <summary>
	/// <inheritdoc cref="Package.PressureAbsoluteClass" path="/summary" />
	/// </summary>
	public Package.PressureAbsoluteClass PressureAbsoluteClass => _PressureAbsoluteClass ?? (_PressureAbsoluteClass = new Package.PressureAbsoluteClass());

	private Package.AccelerationActualClass _AccelerationActualClass;
	/// <summary>
	/// <inheritdoc cref="Package.AccelerationActualClass" path="/summary" />
	/// </summary>
	public Package.AccelerationActualClass AccelerationActualClass => _AccelerationActualClass ?? (_AccelerationActualClass = new Package.AccelerationActualClass());

	private Package.VolumeFluidPartClass _VolumeFluidPartClass;
	/// <summary>
	/// <inheritdoc cref="Package.VolumeFluidPartClass" path="/summary" />
	/// </summary>
	public Package.VolumeFluidPartClass VolumeFluidPartClass => _VolumeFluidPartClass ?? (_VolumeFluidPartClass = new Package.VolumeFluidPartClass());

	private Package.AngularAccelerationProgrammedClass _AngularAccelerationProgrammedClass;
	/// <summary>
	/// <inheritdoc cref="Package.AngularAccelerationProgrammedClass" path="/summary" />
	/// </summary>
	public Package.AngularAccelerationProgrammedClass AngularAccelerationProgrammedClass => _AngularAccelerationProgrammedClass ?? (_AngularAccelerationProgrammedClass = new Package.AngularAccelerationProgrammedClass());

	private Package.PressurizationRateCommandedClass _PressurizationRateCommandedClass;
	/// <summary>
	/// <inheritdoc cref="Package.PressurizationRateCommandedClass" path="/summary" />
	/// </summary>
	public Package.PressurizationRateCommandedClass PressurizationRateCommandedClass => _PressurizationRateCommandedClass ?? (_PressurizationRateCommandedClass = new Package.PressurizationRateCommandedClass());

	private Package.AccelerationProgrammedClass _AccelerationProgrammedClass;
	/// <summary>
	/// <inheritdoc cref="Package.AccelerationProgrammedClass" path="/summary" />
	/// </summary>
	public Package.AccelerationProgrammedClass AccelerationProgrammedClass => _AccelerationProgrammedClass ?? (_AccelerationProgrammedClass = new Package.AccelerationProgrammedClass());

	private Package.AccelerationCommandedClass _AccelerationCommandedClass;
	/// <summary>
	/// <inheritdoc cref="Package.AccelerationCommandedClass" path="/summary" />
	/// </summary>
	public Package.AccelerationCommandedClass AccelerationCommandedClass => _AccelerationCommandedClass ?? (_AccelerationCommandedClass = new Package.AccelerationCommandedClass());

	private Package.VolumeFluidWasteClass _VolumeFluidWasteClass;
	/// <summary>
	/// <inheritdoc cref="Package.VolumeFluidWasteClass" path="/summary" />
	/// </summary>
	public Package.VolumeFluidWasteClass VolumeFluidWasteClass => _VolumeFluidWasteClass ?? (_VolumeFluidWasteClass = new Package.VolumeFluidWasteClass());

	private Package.VolumeSpatialPartClass _VolumeSpatialPartClass;
	/// <summary>
	/// <inheritdoc cref="Package.VolumeSpatialPartClass" path="/summary" />
	/// </summary>
	public Package.VolumeSpatialPartClass VolumeSpatialPartClass => _VolumeSpatialPartClass ?? (_VolumeSpatialPartClass = new Package.VolumeSpatialPartClass());

	private Package.VolumeFluidStartClass _VolumeFluidStartClass;
	/// <summary>
	/// <inheritdoc cref="Package.VolumeFluidStartClass" path="/summary" />
	/// </summary>
	public Package.VolumeFluidStartClass VolumeFluidStartClass => _VolumeFluidStartClass ?? (_VolumeFluidStartClass = new Package.VolumeFluidStartClass());

	private Package.AngularAccelerationActualClass _AngularAccelerationActualClass;
	/// <summary>
	/// <inheritdoc cref="Package.AngularAccelerationActualClass" path="/summary" />
	/// </summary>
	public Package.AngularAccelerationActualClass AngularAccelerationActualClass => _AngularAccelerationActualClass ?? (_AngularAccelerationActualClass = new Package.AngularAccelerationActualClass());

	private Package.VolumeSpatialWasteClass _VolumeSpatialWasteClass;
	/// <summary>
	/// <inheritdoc cref="Package.VolumeSpatialWasteClass" path="/summary" />
	/// </summary>
	public Package.VolumeSpatialWasteClass VolumeSpatialWasteClass => _VolumeSpatialWasteClass ?? (_VolumeSpatialWasteClass = new Package.VolumeSpatialWasteClass());

	private Package.PressurizationRateActualClass _PressurizationRateActualClass;
	/// <summary>
	/// <inheritdoc cref="Package.PressurizationRateActualClass" path="/summary" />
	/// </summary>
	public Package.PressurizationRateActualClass PressurizationRateActualClass => _PressurizationRateActualClass ?? (_PressurizationRateActualClass = new Package.PressurizationRateActualClass());

	private Package.VolumeSpatialEndedClass _VolumeSpatialEndedClass;
	/// <summary>
	/// <inheritdoc cref="Package.VolumeSpatialEndedClass" path="/summary" />
	/// </summary>
	public Package.VolumeSpatialEndedClass VolumeSpatialEndedClass => _VolumeSpatialEndedClass ?? (_VolumeSpatialEndedClass = new Package.VolumeSpatialEndedClass());

	private Package.AngularAccelerationCommandedClass _AngularAccelerationCommandedClass;
	/// <summary>
	/// <inheritdoc cref="Package.AngularAccelerationCommandedClass" path="/summary" />
	/// </summary>
	public Package.AngularAccelerationCommandedClass AngularAccelerationCommandedClass => _AngularAccelerationCommandedClass ?? (_AngularAccelerationCommandedClass = new Package.AngularAccelerationCommandedClass());

	private Package.PressurizationRateProgrammedClass _PressurizationRateProgrammedClass;
	/// <summary>
	/// <inheritdoc cref="Package.PressurizationRateProgrammedClass" path="/summary" />
	/// </summary>
	public Package.PressurizationRateProgrammedClass PressurizationRateProgrammedClass => _PressurizationRateProgrammedClass ?? (_PressurizationRateProgrammedClass = new Package.PressurizationRateProgrammedClass());

	private Package.VolumeSpatialStartClass _VolumeSpatialStartClass;
	/// <summary>
	/// <inheritdoc cref="Package.VolumeSpatialStartClass" path="/summary" />
	/// </summary>
	public Package.VolumeSpatialStartClass VolumeSpatialStartClass => _VolumeSpatialStartClass ?? (_VolumeSpatialStartClass = new Package.VolumeSpatialStartClass());

	private Package.VolumeFluidEndedClass _VolumeFluidEndedClass;
	/// <summary>
	/// <inheritdoc cref="Package.VolumeFluidEndedClass" path="/summary" />
	/// </summary>
	public Package.VolumeFluidEndedClass VolumeFluidEndedClass => _VolumeFluidEndedClass ?? (_VolumeFluidEndedClass = new Package.VolumeFluidEndedClass());

	private Package.OpennessClass _OpennessClass;
	/// <summary>
	/// <inheritdoc cref="Package.OpennessClass" path="/summary" />
	/// </summary>
	public Package.OpennessClass OpennessClass => _OpennessClass ?? (_OpennessClass = new Package.OpennessClass());

	private Package.GlobalPositionActualClass _GlobalPositionActualClass;
	/// <summary>
	/// <inheritdoc cref="Package.GlobalPositionActualClass" path="/summary" />
	/// </summary>
	public Package.GlobalPositionActualClass GlobalPositionActualClass => _GlobalPositionActualClass ?? (_GlobalPositionActualClass = new Package.GlobalPositionActualClass());

	private Package.GlobalPositionCommandedClass _GlobalPositionCommandedClass;
	/// <summary>
	/// <inheritdoc cref="Package.GlobalPositionCommandedClass" path="/summary" />
	/// </summary>
	public Package.GlobalPositionCommandedClass GlobalPositionCommandedClass => _GlobalPositionCommandedClass ?? (_GlobalPositionCommandedClass = new Package.GlobalPositionCommandedClass());

	private Package.DewPointClass _DewPointClass;
	/// <summary>
	/// <inheritdoc cref="Package.DewPointClass" path="/summary" />
	/// </summary>
	public Package.DewPointClass DewPointClass => _DewPointClass ?? (_DewPointClass = new Package.DewPointClass());

	private Package.GravitationalForceClass _GravitationalForceClass;
	/// <summary>
	/// <inheritdoc cref="Package.GravitationalForceClass" path="/summary" />
	/// </summary>
	public Package.GravitationalForceClass GravitationalForceClass => _GravitationalForceClass ?? (_GravitationalForceClass = new Package.GravitationalForceClass());

	private Package.GravitationalAccelerationClass _GravitationalAccelerationClass;
	/// <summary>
	/// <inheritdoc cref="Package.GravitationalAccelerationClass" path="/summary" />
	/// </summary>
	public Package.GravitationalAccelerationClass GravitationalAccelerationClass => _GravitationalAccelerationClass ?? (_GravitationalAccelerationClass = new Package.GravitationalAccelerationClass());

	private Package.BatteryCapacityClass _BatteryCapacityClass;
	/// <summary>
	/// <inheritdoc cref="Package.BatteryCapacityClass" path="/summary" />
	/// </summary>
	public Package.BatteryCapacityClass BatteryCapacityClass => _BatteryCapacityClass ?? (_BatteryCapacityClass = new Package.BatteryCapacityClass());

	private Package.BatteryCapacityActualClass _BatteryCapacityActualClass;
	/// <summary>
	/// <inheritdoc cref="Package.BatteryCapacityActualClass" path="/summary" />
	/// </summary>
	public Package.BatteryCapacityActualClass BatteryCapacityActualClass => _BatteryCapacityActualClass ?? (_BatteryCapacityActualClass = new Package.BatteryCapacityActualClass());

	private Package.BatteryCapacityTargetClass _BatteryCapacityTargetClass;
	/// <summary>
	/// <inheritdoc cref="Package.BatteryCapacityTargetClass" path="/summary" />
	/// </summary>
	public Package.BatteryCapacityTargetClass BatteryCapacityTargetClass => _BatteryCapacityTargetClass ?? (_BatteryCapacityTargetClass = new Package.BatteryCapacityTargetClass());

	private Package.DischargeRateClass _DischargeRateClass;
	/// <summary>
	/// <inheritdoc cref="Package.DischargeRateClass" path="/summary" />
	/// </summary>
	public Package.DischargeRateClass DischargeRateClass => _DischargeRateClass ?? (_DischargeRateClass = new Package.DischargeRateClass());

	private Package.DischargeRateActualClass _DischargeRateActualClass;
	/// <summary>
	/// <inheritdoc cref="Package.DischargeRateActualClass" path="/summary" />
	/// </summary>
	public Package.DischargeRateActualClass DischargeRateActualClass => _DischargeRateActualClass ?? (_DischargeRateActualClass = new Package.DischargeRateActualClass());

	private Package.DischargeRateTargetClass _DischargeRateTargetClass;
	/// <summary>
	/// <inheritdoc cref="Package.DischargeRateTargetClass" path="/summary" />
	/// </summary>
	public Package.DischargeRateTargetClass DischargeRateTargetClass => _DischargeRateTargetClass ?? (_DischargeRateTargetClass = new Package.DischargeRateTargetClass());

	private Package.ChargeRateClass _ChargeRateClass;
	/// <summary>
	/// <inheritdoc cref="Package.ChargeRateClass" path="/summary" />
	/// </summary>
	public Package.ChargeRateClass ChargeRateClass => _ChargeRateClass ?? (_ChargeRateClass = new Package.ChargeRateClass());

	private Package.ChargeRateActualClass _ChargeRateActualClass;
	/// <summary>
	/// <inheritdoc cref="Package.ChargeRateActualClass" path="/summary" />
	/// </summary>
	public Package.ChargeRateActualClass ChargeRateActualClass => _ChargeRateActualClass ?? (_ChargeRateActualClass = new Package.ChargeRateActualClass());

	private Package.ChargeRateTargetClass _ChargeRateTargetClass;
	/// <summary>
	/// <inheritdoc cref="Package.ChargeRateTargetClass" path="/summary" />
	/// </summary>
	public Package.ChargeRateTargetClass ChargeRateTargetClass => _ChargeRateTargetClass ?? (_ChargeRateTargetClass = new Package.ChargeRateTargetClass());

	private Package.BatteryChargeClass _BatteryChargeClass;
	/// <summary>
	/// <inheritdoc cref="Package.BatteryChargeClass" path="/summary" />
	/// </summary>
	public Package.BatteryChargeClass BatteryChargeClass => _BatteryChargeClass ?? (_BatteryChargeClass = new Package.BatteryChargeClass());

	private Package.BatteryChargeActualClass _BatteryChargeActualClass;
	/// <summary>
	/// <inheritdoc cref="Package.BatteryChargeActualClass" path="/summary" />
	/// </summary>
	public Package.BatteryChargeActualClass BatteryChargeActualClass => _BatteryChargeActualClass ?? (_BatteryChargeActualClass = new Package.BatteryChargeActualClass());

	private Package.BatteryChargeTargetClass _BatteryChargeTargetClass;
	/// <summary>
	/// <inheritdoc cref="Package.BatteryChargeTargetClass" path="/summary" />
	/// </summary>
	public Package.BatteryChargeTargetClass BatteryChargeTargetClass => _BatteryChargeTargetClass ?? (_BatteryChargeTargetClass = new Package.BatteryChargeTargetClass());

	private Package.SettlingErrorClass _SettlingErrorClass;
	/// <summary>
	/// <inheritdoc cref="Package.SettlingErrorClass" path="/summary" />
	/// </summary>
	public Package.SettlingErrorClass SettlingErrorClass => _SettlingErrorClass ?? (_SettlingErrorClass = new Package.SettlingErrorClass());

	private Package.SettlingErrorActualClass _SettlingErrorActualClass;
	/// <summary>
	/// <inheritdoc cref="Package.SettlingErrorActualClass" path="/summary" />
	/// </summary>
	public Package.SettlingErrorActualClass SettlingErrorActualClass => _SettlingErrorActualClass ?? (_SettlingErrorActualClass = new Package.SettlingErrorActualClass());

	private Package.SettlingErrorLinearClass _SettlingErrorLinearClass;
	/// <summary>
	/// <inheritdoc cref="Package.SettlingErrorLinearClass" path="/summary" />
	/// </summary>
	public Package.SettlingErrorLinearClass SettlingErrorLinearClass => _SettlingErrorLinearClass ?? (_SettlingErrorLinearClass = new Package.SettlingErrorLinearClass());

	private Package.SettlingErrorLinearActualClass _SettlingErrorLinearActualClass;
	/// <summary>
	/// <inheritdoc cref="Package.SettlingErrorLinearActualClass" path="/summary" />
	/// </summary>
	public Package.SettlingErrorLinearActualClass SettlingErrorLinearActualClass => _SettlingErrorLinearActualClass ?? (_SettlingErrorLinearActualClass = new Package.SettlingErrorLinearActualClass());

	private Package.SettlingErrorAngularClass _SettlingErrorAngularClass;
	/// <summary>
	/// <inheritdoc cref="Package.SettlingErrorAngularClass" path="/summary" />
	/// </summary>
	public Package.SettlingErrorAngularClass SettlingErrorAngularClass => _SettlingErrorAngularClass ?? (_SettlingErrorAngularClass = new Package.SettlingErrorAngularClass());

	private Package.SettlingErrorAngularActualClass _SettlingErrorAngularActualClass;
	/// <summary>
	/// <inheritdoc cref="Package.SettlingErrorAngularActualClass" path="/summary" />
	/// </summary>
	public Package.SettlingErrorAngularActualClass SettlingErrorAngularActualClass => _SettlingErrorAngularActualClass ?? (_SettlingErrorAngularActualClass = new Package.SettlingErrorAngularActualClass());

	private Package.FollowingErrorClass _FollowingErrorClass;
	/// <summary>
	/// <inheritdoc cref="Package.FollowingErrorClass" path="/summary" />
	/// </summary>
	public Package.FollowingErrorClass FollowingErrorClass => _FollowingErrorClass ?? (_FollowingErrorClass = new Package.FollowingErrorClass());

	private Package.FollowingErrorActualClass _FollowingErrorActualClass;
	/// <summary>
	/// <inheritdoc cref="Package.FollowingErrorActualClass" path="/summary" />
	/// </summary>
	public Package.FollowingErrorActualClass FollowingErrorActualClass => _FollowingErrorActualClass ?? (_FollowingErrorActualClass = new Package.FollowingErrorActualClass());

	private Package.FollowingErrorAngularClass _FollowingErrorAngularClass;
	/// <summary>
	/// <inheritdoc cref="Package.FollowingErrorAngularClass" path="/summary" />
	/// </summary>
	public Package.FollowingErrorAngularClass FollowingErrorAngularClass => _FollowingErrorAngularClass ?? (_FollowingErrorAngularClass = new Package.FollowingErrorAngularClass());

	private Package.FollowingErrorLinearClass _FollowingErrorLinearClass;
	/// <summary>
	/// <inheritdoc cref="Package.FollowingErrorLinearClass" path="/summary" />
	/// </summary>
	public Package.FollowingErrorLinearClass FollowingErrorLinearClass => _FollowingErrorLinearClass ?? (_FollowingErrorLinearClass = new Package.FollowingErrorLinearClass());

	private Package.FollowingErrorAngularActualClass _FollowingErrorAngularActualClass;
	/// <summary>
	/// <inheritdoc cref="Package.FollowingErrorAngularActualClass" path="/summary" />
	/// </summary>
	public Package.FollowingErrorAngularActualClass FollowingErrorAngularActualClass => _FollowingErrorAngularActualClass ?? (_FollowingErrorAngularActualClass = new Package.FollowingErrorAngularActualClass());

	private Package.FollowingErrorLinearActualClass _FollowingErrorLinearActualClass;
	/// <summary>
	/// <inheritdoc cref="Package.FollowingErrorLinearActualClass" path="/summary" />
	/// </summary>
	public Package.FollowingErrorLinearActualClass FollowingErrorLinearActualClass => _FollowingErrorLinearActualClass ?? (_FollowingErrorLinearActualClass = new Package.FollowingErrorLinearActualClass());

	private Package.DisplacementLinearClass _DisplacementLinearClass;
	/// <summary>
	/// <inheritdoc cref="Package.DisplacementLinearClass" path="/summary" />
	/// </summary>
	public Package.DisplacementLinearClass DisplacementLinearClass => _DisplacementLinearClass ?? (_DisplacementLinearClass = new Package.DisplacementLinearClass());

	private Package.DisplacementAngularClass _DisplacementAngularClass;
	/// <summary>
	/// <inheritdoc cref="Package.DisplacementAngularClass" path="/summary" />
	/// </summary>
	public Package.DisplacementAngularClass DisplacementAngularClass => _DisplacementAngularClass ?? (_DisplacementAngularClass = new Package.DisplacementAngularClass());

	private Package.PositionCartesianClass _PositionCartesianClass;
	/// <summary>
	/// <inheritdoc cref="Package.PositionCartesianClass" path="/summary" />
	/// </summary>
	public Package.PositionCartesianClass PositionCartesianClass => _PositionCartesianClass ?? (_PositionCartesianClass = new Package.PositionCartesianClass());

	#endregion
	}
}