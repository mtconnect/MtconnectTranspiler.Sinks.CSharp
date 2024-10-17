#pragma warning disable CS1574 // XML comment has cref attribute that could not be resolved
#pragma warning disable CS1584 // XML comment has syntactically incorrect cref attribute
#pragma warning disable CS0618 // Type or member is obsolete
using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;
using Package = Mtconnect.ObservationInformationModel.ObservationTypes.EventTypes;

namespace Mtconnect.ObservationInformationModel.ObservationTypes
{
	/// <summary>﻿This section provides semantic information for <see cref="Event">Event</see> types.<br /><br /><br />
	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Package___19_0_3_45f01b9_1580309852285_621670_44358">model.mtconnect.org</seealso> for more information.
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public class EventTypesPackage : IPackage
	{
		/// <summary>Constant value for <see cref="EventTypesPackage.ReferenceId" /></summary>
		public const string REFERENCE_ID = "_19_0_3_45f01b9_1580309852285_621670_44358";
		/// <summary>Constant value for <see cref="EventTypesPackage.HelpUrl" /></summary>
		public const string HELP_URL = "https://model.mtconnect.org/#Package___19_0_3_45f01b9_1580309852285_621670_44358";
		/// <summary>Constant value for <see cref="EventTypesPackage.Name" /></summary>
		public const string NAME = "Event Types";
		/// <summary>Constant value for <see cref="EventTypesPackage.Summary" /></summary>
		public const string SUMMARY = @"&#10;&#10;&#10;This section provides semantic information for {{block(Event)}} types.&#10;
";

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
			ActiveAxesClass,
			ActuatorStateClass,
			AlarmClass,
			AssetChangedClass,
			AssetRemovedClass,
			AvailabilityClass,
			AxisCouplingClass,
			AxisFeedrateOverrideClass,
			AxisFeedrateOverrideJogClass,
			AxisFeedrateOverrideProgrammedClass,
			AxisFeedrateOverrideRapidClass,
			AxisInterlockClass,
			AxisStateClass,
			BlockClass,
			BlockCountClass,
			ChuckInterlockClass,
			ChuckInterlockManualUnclampClass,
			ChuckStateClass,
			CodeClass,
			CompositionStateClass,
			CompositionStateActionClass,
			CompositionStateLateralClass,
			CompositionStateMotionClass,
			CompositionStateSwitchedClass,
			CompositionStateVerticalClass,
			ControllerModeClass,
			ControllerModeOverrideClass,
			ControllerModeOverrideDryRunClass,
			ControllerModeOverrideSingleBlockClass,
			ControllerModeOverrideMachineAxisLockClass,
			ControllerModeOverrideOptionalStopClass,
			ControllerModeOverrideToolChangeStopClass,
			CoupledAxesClass,
			DateCodeClass,
			DateCodeManufactureClass,
			DateCodeExpirationClass,
			DateCodeFirstUseClass,
			DeviceUuidClass,
			DirectionClass,
			DirectionRotaryClass,
			DirectionLinearClass,
			DoorStateClass,
			EmergencyStopClass,
			EndOfBarClass,
			EndOfBarPrimaryClass,
			EndOfBarAuxiliaryClass,
			EquipmentModeClass,
			EquipmentModeLoadedClass,
			EquipmentModeWorkingClass,
			EquipmentModeOperatingClass,
			EquipmentModePoweredClass,
			EquipmentModeDelayClass,
			ExecutionClass,
			FunctionalModeClass,
			HardnessClass,
			HardnessRockwellClass,
			HardnessVickersClass,
			HardnessShoreClass,
			HardnessBrinellClass,
			HardnessLeebClass,
			HardnessMohsClass,
			LineClass,
			LineMaximumClass,
			LineMinimumClass,
			LineLabelClass,
			LineNumberClass,
			LineNumberAbsoluteClass,
			LineNumberIncrementalClass,
			MaterialClass,
			MaterialLayerClass,
			MaterialLayerActualClass,
			MaterialLayerTargetClass,
			MessageClass,
			OperatorIdClass,
			PalletIdClass,
			PartCountClass,
			PartCountAllClass,
			PartCountGoodClass,
			PartCountBadClass,
			PartCountTargetClass,
			PartCountRemainingClass,
			PartDetectClass,
			PartIdClass,
			PartNumberClass,
			PathFeedrateOverrideClass,
			PathFeedrateOverrideJogClass,
			PathFeedrateOverrideProgrammedClass,
			PathFeedrateOverrideRapidClass,
			PathModeClass,
			PowerStateClass,
			PowerStateLineClass,
			PowerStateControlClass,
			PowerStatusClass,
			ProcessTimeClass,
			ProcessTimeStartClass,
			ProcessTimeCompleteClass,
			ProcessTimeTargetCompletionClass,
			ProgramClass,
			ProgramCommentClass,
			ProgramEditClass,
			ProgramEditNameClass,
			ProgramHeaderClass,
			ProgramLocationClass,
			ProgramLocationScheduleClass,
			ProgramLocationMainClass,
			ProgramLocationActiveClass,
			ProgramLocationTypeClass,
			ProgramLocationTypeScheduleClass,
			ProgramLocationTypeMainClass,
			ProgramLocationTypeActiveClass,
			ProgramNestLevelClass,
			RotaryModeClass,
			RotaryVelocityOverrideClass,
			SerialNumberClass,
			SpindleInterlockClass,
			ToolAssetIdClass,
			ToolGroupClass,
			ToolIdClass,
			ToolNumberClass,
			ToolOffsetClass,
			ToolOffsetRadialClass,
			ToolOffsetLengthClass,
			UserClass,
			UserOperatorClass,
			UserMaintenanceClass,
			UserSetUpClass,
			VariableClass,
			WaitStateClass,
			WireClass,
			WorkholdingIdClass,
			WorkOffsetClass,
			ProgramHeaderMainClass,
			ProgramHeaderScheduleClass,
			ProgramHeaderActiveClass,
			OperatingSystemClass,
			OperatingSystemLicenseClass,
			OperatingSystemVersionClass,
			OperatingSystemReleaseDateClass,
			OperatingSystemInstallDateClass,
			OperatingSystemManufacturerClass,
			FirmwareVersionClass,
			FirmwareReleaseDateClass,
			FirmwareClass,
			FirmwareManufacturerClass,
			FirmwareLicenseClass,
			FirmwareInstallDateClass,
			ApplicationVersionClass,
			ApplicationReleaseDateClass,
			ApplicationClass,
			ApplicationManufacturerClass,
			ApplicationLicenseClass,
			ApplicationInstallDateClass,
			LibraryVersionClass,
			LibraryReleaseDateClass,
			LibraryClass,
			LibraryManufacturerClass,
			LibraryLicenseClass,
			LibraryInstallDateClass,
			HardwareVersionClass,
			HardwareReleaseDateClass,
			HardwareClass,
			HardwareManufacturerClass,
			HardwareLicenseClass,
			HardwareInstallDateClass,
			NetworkClass,
			NetworkIPv4AddressClass,
			NetworkIPv6AddressClass,
			NetworkGatewayClass,
			NetworkSubnetMaskClass,
			NetworkVLanIdClass,
			NetworkMacAddressClass,
			NetworkWirelessClass,
			RotationClass,
			TranslationClass,
			ProcessKindIdClass,
			PartStatusClass,
			AlarmLimitClass,
			ProcessAggregateIdClass,
			ProcessKindIdUuidClass,
			ProcessAggregateIdOrderNumberClass,
			ProcessKindIdISOStepExecutableClass,
			PartKindIdClass,
			ProcessKindIdProcessNameClass,
			AdapterURIClass,
			PartKindIdUuidClass,
			DeviceRemovedClass,
			DeviceChangedClass,
			SpecificationLimitClass,
			ConnectionStatusClass,
			PartKindIdPartFamilyClass,
			PartKindIdPartNameClass,
			AdapterSoftwareVersionClass,
			SensorAttachmentClass,
			PartKindIdPartNumberClass,
			PartGroupIdLotClass,
			PartGroupIdRawMaterialClass,
			PartGroupIdBatchClass,
			ControlLimitClass,
			DeviceAddedClass,
			ProcessAggregateIdProcessStepClass,
			MTConnectVersionClass,
			PartUniqueIdSerialNumberClass,
			PartUniqueIdRawMaterialClass,
			PartGroupIdUuidClass,
			ProcessOccurrenceIdClass,
			ProcessAggregateIdProcessPlanClass,
			PartUniqueIdUuidClass,
			PartGroupIdClass,
			PartGroupIdHeatTreatClass,
			PartUniqueIdClass,
			LoadCountRemainingClass,
			ActivationCountTargetClass,
			ActivationCountGoodClass,
			TransferCountGoodClass,
			CycleCountGoodClass,
			ActivationCountClass,
			UnloadCountAbortedClass,
			CycleCountRemainingClass,
			DeactivationCountBadClass,
			TransferCountAbortedClass,
			DeactivationCountClass,
			ActivationCountBadClass,
			UnloadCountBadClass,
			CycleCountCompleteClass,
			TransferCountClass,
			LoadCountBadClass,
			CycleCountAbortedClass,
			LoadCountClass,
			TransferCountFailedClass,
			DeactivationCountFailedClass,
			LoadCountFailedClass,
			PartProcessingStateClass,
			ActivationCountRemainingClass,
			TransferCountAllClass,
			UnloadCountFailedClass,
			ProcessStateClass,
			ActivationCountAbortedClass,
			PartCountCompleteClass,
			DeactivationCountTargetClass,
			TransferCountBadClass,
			ActivationCountFailedClass,
			TransferCountRemainingClass,
			DeactivationCountCompleteClass,
			LoadCountAbortedClass,
			UnloadCountGoodClass,
			DeactivationCountRemainingClass,
			CycleCountBadClass,
			TransferCountCompleteClass,
			UnloadCountCompleteClass,
			UnloadCountAllClass,
			ValveStateClass,
			CycleCountFailedClass,
			LoadCountAllClass,
			UnloadCountTargetClass,
			ValveStateActualClass,
			TransferCountTargetClass,
			CycleCountTargetClass,
			LockStateClass,
			UnloadCountClass,
			PartCountAbortedClass,
			ActivationCountCompleteClass,
			PartCountFailedClass,
			LoadCountGoodClass,
			CycleCountClass,
			CycleCountAllClass,
			LoadCountCompleteClass,
			ActivationCountAllClass,
			DeactivationCountAllClass,
			UnloadCountRemainingClass,
			DeactivationCountGoodClass,
			LoadCountTargetClass,
			ValveStateProgrammedClass,
			DeactivationCountAbortedClass,
			OperatingModeClass,
			AssetCountClass,
			MaintenanceListClass,
			FixtureIdClass,
			PartCountTypeClass,
			ProgramActivityClass,
			ProgramSegmentClass,
			ProgramRecipeClass,
			ProgramOperationClass,
			ProcessOccurrenceIdActivityClass,
			ProcessOccurrenceIdSegmentClass,
			ProcessOccurrenceIdRecipeClass,
			ProcessOccurrenceIdOperationClass,
			ProgramActiveClass,
			ProgramMainClass,
			ProgramScheduleClass,
			ClockTimeClass,
			ProgramCommentMainClass,
			ProgramCommentScheduleClass,
			ProgramCommentActiveClass,
			NetworkPortClass,
			HostNameClass,
			LeakDetectClass,
			BatteryStateClass,
			FeaturePersisitentIdClass,
			SensorStateClass,
			SensorStateBinaryClass,
			SensorStateBooleanClass,
			SensorStateEnumeratedClass,
			SensorStateDetectClass,
			ComponentDataClass,
			WorkOffsetsClass,
			ToolOffsetsClass,
			FeatureMeasurementClass,
			CharacteristicPersistentIdClass,
			MeasurementTypeClass,
			MeasurementValueClass,
			MeasurementUnitsClass,
			CharacteristicStatusClass,
			UncertaintyTypeClass,
			UncertaintyClass,
			AlarmLimitsClass,
			ControlLimitsClass,
			SpecificationLimitsClass,
			ToolCuttingItemClass,
			HardwareModelClass,
			LocationAddressClass,
			ActivePowerSourceClass,
			LocationNarrativeClass,
			ThicknessClass,
			ThicknessActualClass,
			ThicknessCommandedClass,
			ThicknessTargetClass,
			ThicknessProgrammedClass,
			LocationSpatialGeographicClass,
			PartIndexClass,
		};
		
		/// <inheritdoc />
		public IEnum[] Enums => new IEnum[] {
		};

		#region Packages
	#endregion

	#region Classes
	private Package.ActiveAxesClass _ActiveAxesClass;
	/// <summary>
	/// <inheritdoc cref="Package.ActiveAxesClass" path="/summary" />
	/// </summary>
	public Package.ActiveAxesClass ActiveAxesClass => _ActiveAxesClass ?? (_ActiveAxesClass = new Package.ActiveAxesClass());

	private Package.ActuatorStateClass _ActuatorStateClass;
	/// <summary>
	/// <inheritdoc cref="Package.ActuatorStateClass" path="/summary" />
	/// </summary>
	public Package.ActuatorStateClass ActuatorStateClass => _ActuatorStateClass ?? (_ActuatorStateClass = new Package.ActuatorStateClass());

	private Package.AlarmClass _AlarmClass;
	/// <summary>
	/// <inheritdoc cref="Package.AlarmClass" path="/summary" />
	/// </summary>
	public Package.AlarmClass AlarmClass => _AlarmClass ?? (_AlarmClass = new Package.AlarmClass());

	private Package.AssetChangedClass _AssetChangedClass;
	/// <summary>
	/// <inheritdoc cref="Package.AssetChangedClass" path="/summary" />
	/// </summary>
	public Package.AssetChangedClass AssetChangedClass => _AssetChangedClass ?? (_AssetChangedClass = new Package.AssetChangedClass());

	private Package.AssetRemovedClass _AssetRemovedClass;
	/// <summary>
	/// <inheritdoc cref="Package.AssetRemovedClass" path="/summary" />
	/// </summary>
	public Package.AssetRemovedClass AssetRemovedClass => _AssetRemovedClass ?? (_AssetRemovedClass = new Package.AssetRemovedClass());

	private Package.AvailabilityClass _AvailabilityClass;
	/// <summary>
	/// <inheritdoc cref="Package.AvailabilityClass" path="/summary" />
	/// </summary>
	public Package.AvailabilityClass AvailabilityClass => _AvailabilityClass ?? (_AvailabilityClass = new Package.AvailabilityClass());

	private Package.AxisCouplingClass _AxisCouplingClass;
	/// <summary>
	/// <inheritdoc cref="Package.AxisCouplingClass" path="/summary" />
	/// </summary>
	public Package.AxisCouplingClass AxisCouplingClass => _AxisCouplingClass ?? (_AxisCouplingClass = new Package.AxisCouplingClass());

	private Package.AxisFeedrateOverrideClass _AxisFeedrateOverrideClass;
	/// <summary>
	/// <inheritdoc cref="Package.AxisFeedrateOverrideClass" path="/summary" />
	/// </summary>
	public Package.AxisFeedrateOverrideClass AxisFeedrateOverrideClass => _AxisFeedrateOverrideClass ?? (_AxisFeedrateOverrideClass = new Package.AxisFeedrateOverrideClass());

	private Package.AxisFeedrateOverrideJogClass _AxisFeedrateOverrideJogClass;
	/// <summary>
	/// <inheritdoc cref="Package.AxisFeedrateOverrideJogClass" path="/summary" />
	/// </summary>
	public Package.AxisFeedrateOverrideJogClass AxisFeedrateOverrideJogClass => _AxisFeedrateOverrideJogClass ?? (_AxisFeedrateOverrideJogClass = new Package.AxisFeedrateOverrideJogClass());

	private Package.AxisFeedrateOverrideProgrammedClass _AxisFeedrateOverrideProgrammedClass;
	/// <summary>
	/// <inheritdoc cref="Package.AxisFeedrateOverrideProgrammedClass" path="/summary" />
	/// </summary>
	public Package.AxisFeedrateOverrideProgrammedClass AxisFeedrateOverrideProgrammedClass => _AxisFeedrateOverrideProgrammedClass ?? (_AxisFeedrateOverrideProgrammedClass = new Package.AxisFeedrateOverrideProgrammedClass());

	private Package.AxisFeedrateOverrideRapidClass _AxisFeedrateOverrideRapidClass;
	/// <summary>
	/// <inheritdoc cref="Package.AxisFeedrateOverrideRapidClass" path="/summary" />
	/// </summary>
	public Package.AxisFeedrateOverrideRapidClass AxisFeedrateOverrideRapidClass => _AxisFeedrateOverrideRapidClass ?? (_AxisFeedrateOverrideRapidClass = new Package.AxisFeedrateOverrideRapidClass());

	private Package.AxisInterlockClass _AxisInterlockClass;
	/// <summary>
	/// <inheritdoc cref="Package.AxisInterlockClass" path="/summary" />
	/// </summary>
	public Package.AxisInterlockClass AxisInterlockClass => _AxisInterlockClass ?? (_AxisInterlockClass = new Package.AxisInterlockClass());

	private Package.AxisStateClass _AxisStateClass;
	/// <summary>
	/// <inheritdoc cref="Package.AxisStateClass" path="/summary" />
	/// </summary>
	public Package.AxisStateClass AxisStateClass => _AxisStateClass ?? (_AxisStateClass = new Package.AxisStateClass());

	private Package.BlockClass _BlockClass;
	/// <summary>
	/// <inheritdoc cref="Package.BlockClass" path="/summary" />
	/// </summary>
	public Package.BlockClass BlockClass => _BlockClass ?? (_BlockClass = new Package.BlockClass());

	private Package.BlockCountClass _BlockCountClass;
	/// <summary>
	/// <inheritdoc cref="Package.BlockCountClass" path="/summary" />
	/// </summary>
	public Package.BlockCountClass BlockCountClass => _BlockCountClass ?? (_BlockCountClass = new Package.BlockCountClass());

	private Package.ChuckInterlockClass _ChuckInterlockClass;
	/// <summary>
	/// <inheritdoc cref="Package.ChuckInterlockClass" path="/summary" />
	/// </summary>
	public Package.ChuckInterlockClass ChuckInterlockClass => _ChuckInterlockClass ?? (_ChuckInterlockClass = new Package.ChuckInterlockClass());

	private Package.ChuckInterlockManualUnclampClass _ChuckInterlockManualUnclampClass;
	/// <summary>
	/// <inheritdoc cref="Package.ChuckInterlockManualUnclampClass" path="/summary" />
	/// </summary>
	public Package.ChuckInterlockManualUnclampClass ChuckInterlockManualUnclampClass => _ChuckInterlockManualUnclampClass ?? (_ChuckInterlockManualUnclampClass = new Package.ChuckInterlockManualUnclampClass());

	private Package.ChuckStateClass _ChuckStateClass;
	/// <summary>
	/// <inheritdoc cref="Package.ChuckStateClass" path="/summary" />
	/// </summary>
	public Package.ChuckStateClass ChuckStateClass => _ChuckStateClass ?? (_ChuckStateClass = new Package.ChuckStateClass());

	private Package.CodeClass _CodeClass;
	/// <summary>
	/// <inheritdoc cref="Package.CodeClass" path="/summary" />
	/// </summary>
	public Package.CodeClass CodeClass => _CodeClass ?? (_CodeClass = new Package.CodeClass());

	private Package.CompositionStateClass _CompositionStateClass;
	/// <summary>
	/// <inheritdoc cref="Package.CompositionStateClass" path="/summary" />
	/// </summary>
	public Package.CompositionStateClass CompositionStateClass => _CompositionStateClass ?? (_CompositionStateClass = new Package.CompositionStateClass());

	private Package.CompositionStateActionClass _CompositionStateActionClass;
	/// <summary>
	/// <inheritdoc cref="Package.CompositionStateActionClass" path="/summary" />
	/// </summary>
	public Package.CompositionStateActionClass CompositionStateActionClass => _CompositionStateActionClass ?? (_CompositionStateActionClass = new Package.CompositionStateActionClass());

	private Package.CompositionStateLateralClass _CompositionStateLateralClass;
	/// <summary>
	/// <inheritdoc cref="Package.CompositionStateLateralClass" path="/summary" />
	/// </summary>
	public Package.CompositionStateLateralClass CompositionStateLateralClass => _CompositionStateLateralClass ?? (_CompositionStateLateralClass = new Package.CompositionStateLateralClass());

	private Package.CompositionStateMotionClass _CompositionStateMotionClass;
	/// <summary>
	/// <inheritdoc cref="Package.CompositionStateMotionClass" path="/summary" />
	/// </summary>
	public Package.CompositionStateMotionClass CompositionStateMotionClass => _CompositionStateMotionClass ?? (_CompositionStateMotionClass = new Package.CompositionStateMotionClass());

	private Package.CompositionStateSwitchedClass _CompositionStateSwitchedClass;
	/// <summary>
	/// <inheritdoc cref="Package.CompositionStateSwitchedClass" path="/summary" />
	/// </summary>
	public Package.CompositionStateSwitchedClass CompositionStateSwitchedClass => _CompositionStateSwitchedClass ?? (_CompositionStateSwitchedClass = new Package.CompositionStateSwitchedClass());

	private Package.CompositionStateVerticalClass _CompositionStateVerticalClass;
	/// <summary>
	/// <inheritdoc cref="Package.CompositionStateVerticalClass" path="/summary" />
	/// </summary>
	public Package.CompositionStateVerticalClass CompositionStateVerticalClass => _CompositionStateVerticalClass ?? (_CompositionStateVerticalClass = new Package.CompositionStateVerticalClass());

	private Package.ControllerModeClass _ControllerModeClass;
	/// <summary>
	/// <inheritdoc cref="Package.ControllerModeClass" path="/summary" />
	/// </summary>
	public Package.ControllerModeClass ControllerModeClass => _ControllerModeClass ?? (_ControllerModeClass = new Package.ControllerModeClass());

	private Package.ControllerModeOverrideClass _ControllerModeOverrideClass;
	/// <summary>
	/// <inheritdoc cref="Package.ControllerModeOverrideClass" path="/summary" />
	/// </summary>
	public Package.ControllerModeOverrideClass ControllerModeOverrideClass => _ControllerModeOverrideClass ?? (_ControllerModeOverrideClass = new Package.ControllerModeOverrideClass());

	private Package.ControllerModeOverrideDryRunClass _ControllerModeOverrideDryRunClass;
	/// <summary>
	/// <inheritdoc cref="Package.ControllerModeOverrideDryRunClass" path="/summary" />
	/// </summary>
	public Package.ControllerModeOverrideDryRunClass ControllerModeOverrideDryRunClass => _ControllerModeOverrideDryRunClass ?? (_ControllerModeOverrideDryRunClass = new Package.ControllerModeOverrideDryRunClass());

	private Package.ControllerModeOverrideSingleBlockClass _ControllerModeOverrideSingleBlockClass;
	/// <summary>
	/// <inheritdoc cref="Package.ControllerModeOverrideSingleBlockClass" path="/summary" />
	/// </summary>
	public Package.ControllerModeOverrideSingleBlockClass ControllerModeOverrideSingleBlockClass => _ControllerModeOverrideSingleBlockClass ?? (_ControllerModeOverrideSingleBlockClass = new Package.ControllerModeOverrideSingleBlockClass());

	private Package.ControllerModeOverrideMachineAxisLockClass _ControllerModeOverrideMachineAxisLockClass;
	/// <summary>
	/// <inheritdoc cref="Package.ControllerModeOverrideMachineAxisLockClass" path="/summary" />
	/// </summary>
	public Package.ControllerModeOverrideMachineAxisLockClass ControllerModeOverrideMachineAxisLockClass => _ControllerModeOverrideMachineAxisLockClass ?? (_ControllerModeOverrideMachineAxisLockClass = new Package.ControllerModeOverrideMachineAxisLockClass());

	private Package.ControllerModeOverrideOptionalStopClass _ControllerModeOverrideOptionalStopClass;
	/// <summary>
	/// <inheritdoc cref="Package.ControllerModeOverrideOptionalStopClass" path="/summary" />
	/// </summary>
	public Package.ControllerModeOverrideOptionalStopClass ControllerModeOverrideOptionalStopClass => _ControllerModeOverrideOptionalStopClass ?? (_ControllerModeOverrideOptionalStopClass = new Package.ControllerModeOverrideOptionalStopClass());

	private Package.ControllerModeOverrideToolChangeStopClass _ControllerModeOverrideToolChangeStopClass;
	/// <summary>
	/// <inheritdoc cref="Package.ControllerModeOverrideToolChangeStopClass" path="/summary" />
	/// </summary>
	public Package.ControllerModeOverrideToolChangeStopClass ControllerModeOverrideToolChangeStopClass => _ControllerModeOverrideToolChangeStopClass ?? (_ControllerModeOverrideToolChangeStopClass = new Package.ControllerModeOverrideToolChangeStopClass());

	private Package.CoupledAxesClass _CoupledAxesClass;
	/// <summary>
	/// <inheritdoc cref="Package.CoupledAxesClass" path="/summary" />
	/// </summary>
	public Package.CoupledAxesClass CoupledAxesClass => _CoupledAxesClass ?? (_CoupledAxesClass = new Package.CoupledAxesClass());

	private Package.DateCodeClass _DateCodeClass;
	/// <summary>
	/// <inheritdoc cref="Package.DateCodeClass" path="/summary" />
	/// </summary>
	public Package.DateCodeClass DateCodeClass => _DateCodeClass ?? (_DateCodeClass = new Package.DateCodeClass());

	private Package.DateCodeManufactureClass _DateCodeManufactureClass;
	/// <summary>
	/// <inheritdoc cref="Package.DateCodeManufactureClass" path="/summary" />
	/// </summary>
	public Package.DateCodeManufactureClass DateCodeManufactureClass => _DateCodeManufactureClass ?? (_DateCodeManufactureClass = new Package.DateCodeManufactureClass());

	private Package.DateCodeExpirationClass _DateCodeExpirationClass;
	/// <summary>
	/// <inheritdoc cref="Package.DateCodeExpirationClass" path="/summary" />
	/// </summary>
	public Package.DateCodeExpirationClass DateCodeExpirationClass => _DateCodeExpirationClass ?? (_DateCodeExpirationClass = new Package.DateCodeExpirationClass());

	private Package.DateCodeFirstUseClass _DateCodeFirstUseClass;
	/// <summary>
	/// <inheritdoc cref="Package.DateCodeFirstUseClass" path="/summary" />
	/// </summary>
	public Package.DateCodeFirstUseClass DateCodeFirstUseClass => _DateCodeFirstUseClass ?? (_DateCodeFirstUseClass = new Package.DateCodeFirstUseClass());

	private Package.DeviceUuidClass _DeviceUuidClass;
	/// <summary>
	/// <inheritdoc cref="Package.DeviceUuidClass" path="/summary" />
	/// </summary>
	public Package.DeviceUuidClass DeviceUuidClass => _DeviceUuidClass ?? (_DeviceUuidClass = new Package.DeviceUuidClass());

	private Package.DirectionClass _DirectionClass;
	/// <summary>
	/// <inheritdoc cref="Package.DirectionClass" path="/summary" />
	/// </summary>
	public Package.DirectionClass DirectionClass => _DirectionClass ?? (_DirectionClass = new Package.DirectionClass());

	private Package.DirectionRotaryClass _DirectionRotaryClass;
	/// <summary>
	/// <inheritdoc cref="Package.DirectionRotaryClass" path="/summary" />
	/// </summary>
	public Package.DirectionRotaryClass DirectionRotaryClass => _DirectionRotaryClass ?? (_DirectionRotaryClass = new Package.DirectionRotaryClass());

	private Package.DirectionLinearClass _DirectionLinearClass;
	/// <summary>
	/// <inheritdoc cref="Package.DirectionLinearClass" path="/summary" />
	/// </summary>
	public Package.DirectionLinearClass DirectionLinearClass => _DirectionLinearClass ?? (_DirectionLinearClass = new Package.DirectionLinearClass());

	private Package.DoorStateClass _DoorStateClass;
	/// <summary>
	/// <inheritdoc cref="Package.DoorStateClass" path="/summary" />
	/// </summary>
	public Package.DoorStateClass DoorStateClass => _DoorStateClass ?? (_DoorStateClass = new Package.DoorStateClass());

	private Package.EmergencyStopClass _EmergencyStopClass;
	/// <summary>
	/// <inheritdoc cref="Package.EmergencyStopClass" path="/summary" />
	/// </summary>
	public Package.EmergencyStopClass EmergencyStopClass => _EmergencyStopClass ?? (_EmergencyStopClass = new Package.EmergencyStopClass());

	private Package.EndOfBarClass _EndOfBarClass;
	/// <summary>
	/// <inheritdoc cref="Package.EndOfBarClass" path="/summary" />
	/// </summary>
	public Package.EndOfBarClass EndOfBarClass => _EndOfBarClass ?? (_EndOfBarClass = new Package.EndOfBarClass());

	private Package.EndOfBarPrimaryClass _EndOfBarPrimaryClass;
	/// <summary>
	/// <inheritdoc cref="Package.EndOfBarPrimaryClass" path="/summary" />
	/// </summary>
	public Package.EndOfBarPrimaryClass EndOfBarPrimaryClass => _EndOfBarPrimaryClass ?? (_EndOfBarPrimaryClass = new Package.EndOfBarPrimaryClass());

	private Package.EndOfBarAuxiliaryClass _EndOfBarAuxiliaryClass;
	/// <summary>
	/// <inheritdoc cref="Package.EndOfBarAuxiliaryClass" path="/summary" />
	/// </summary>
	public Package.EndOfBarAuxiliaryClass EndOfBarAuxiliaryClass => _EndOfBarAuxiliaryClass ?? (_EndOfBarAuxiliaryClass = new Package.EndOfBarAuxiliaryClass());

	private Package.EquipmentModeClass _EquipmentModeClass;
	/// <summary>
	/// <inheritdoc cref="Package.EquipmentModeClass" path="/summary" />
	/// </summary>
	public Package.EquipmentModeClass EquipmentModeClass => _EquipmentModeClass ?? (_EquipmentModeClass = new Package.EquipmentModeClass());

	private Package.EquipmentModeLoadedClass _EquipmentModeLoadedClass;
	/// <summary>
	/// <inheritdoc cref="Package.EquipmentModeLoadedClass" path="/summary" />
	/// </summary>
	public Package.EquipmentModeLoadedClass EquipmentModeLoadedClass => _EquipmentModeLoadedClass ?? (_EquipmentModeLoadedClass = new Package.EquipmentModeLoadedClass());

	private Package.EquipmentModeWorkingClass _EquipmentModeWorkingClass;
	/// <summary>
	/// <inheritdoc cref="Package.EquipmentModeWorkingClass" path="/summary" />
	/// </summary>
	public Package.EquipmentModeWorkingClass EquipmentModeWorkingClass => _EquipmentModeWorkingClass ?? (_EquipmentModeWorkingClass = new Package.EquipmentModeWorkingClass());

	private Package.EquipmentModeOperatingClass _EquipmentModeOperatingClass;
	/// <summary>
	/// <inheritdoc cref="Package.EquipmentModeOperatingClass" path="/summary" />
	/// </summary>
	public Package.EquipmentModeOperatingClass EquipmentModeOperatingClass => _EquipmentModeOperatingClass ?? (_EquipmentModeOperatingClass = new Package.EquipmentModeOperatingClass());

	private Package.EquipmentModePoweredClass _EquipmentModePoweredClass;
	/// <summary>
	/// <inheritdoc cref="Package.EquipmentModePoweredClass" path="/summary" />
	/// </summary>
	public Package.EquipmentModePoweredClass EquipmentModePoweredClass => _EquipmentModePoweredClass ?? (_EquipmentModePoweredClass = new Package.EquipmentModePoweredClass());

	private Package.EquipmentModeDelayClass _EquipmentModeDelayClass;
	/// <summary>
	/// <inheritdoc cref="Package.EquipmentModeDelayClass" path="/summary" />
	/// </summary>
	public Package.EquipmentModeDelayClass EquipmentModeDelayClass => _EquipmentModeDelayClass ?? (_EquipmentModeDelayClass = new Package.EquipmentModeDelayClass());

	private Package.ExecutionClass _ExecutionClass;
	/// <summary>
	/// <inheritdoc cref="Package.ExecutionClass" path="/summary" />
	/// </summary>
	public Package.ExecutionClass ExecutionClass => _ExecutionClass ?? (_ExecutionClass = new Package.ExecutionClass());

	private Package.FunctionalModeClass _FunctionalModeClass;
	/// <summary>
	/// <inheritdoc cref="Package.FunctionalModeClass" path="/summary" />
	/// </summary>
	public Package.FunctionalModeClass FunctionalModeClass => _FunctionalModeClass ?? (_FunctionalModeClass = new Package.FunctionalModeClass());

	private Package.HardnessClass _HardnessClass;
	/// <summary>
	/// <inheritdoc cref="Package.HardnessClass" path="/summary" />
	/// </summary>
	public Package.HardnessClass HardnessClass => _HardnessClass ?? (_HardnessClass = new Package.HardnessClass());

	private Package.HardnessRockwellClass _HardnessRockwellClass;
	/// <summary>
	/// <inheritdoc cref="Package.HardnessRockwellClass" path="/summary" />
	/// </summary>
	public Package.HardnessRockwellClass HardnessRockwellClass => _HardnessRockwellClass ?? (_HardnessRockwellClass = new Package.HardnessRockwellClass());

	private Package.HardnessVickersClass _HardnessVickersClass;
	/// <summary>
	/// <inheritdoc cref="Package.HardnessVickersClass" path="/summary" />
	/// </summary>
	public Package.HardnessVickersClass HardnessVickersClass => _HardnessVickersClass ?? (_HardnessVickersClass = new Package.HardnessVickersClass());

	private Package.HardnessShoreClass _HardnessShoreClass;
	/// <summary>
	/// <inheritdoc cref="Package.HardnessShoreClass" path="/summary" />
	/// </summary>
	public Package.HardnessShoreClass HardnessShoreClass => _HardnessShoreClass ?? (_HardnessShoreClass = new Package.HardnessShoreClass());

	private Package.HardnessBrinellClass _HardnessBrinellClass;
	/// <summary>
	/// <inheritdoc cref="Package.HardnessBrinellClass" path="/summary" />
	/// </summary>
	public Package.HardnessBrinellClass HardnessBrinellClass => _HardnessBrinellClass ?? (_HardnessBrinellClass = new Package.HardnessBrinellClass());

	private Package.HardnessLeebClass _HardnessLeebClass;
	/// <summary>
	/// <inheritdoc cref="Package.HardnessLeebClass" path="/summary" />
	/// </summary>
	public Package.HardnessLeebClass HardnessLeebClass => _HardnessLeebClass ?? (_HardnessLeebClass = new Package.HardnessLeebClass());

	private Package.HardnessMohsClass _HardnessMohsClass;
	/// <summary>
	/// <inheritdoc cref="Package.HardnessMohsClass" path="/summary" />
	/// </summary>
	public Package.HardnessMohsClass HardnessMohsClass => _HardnessMohsClass ?? (_HardnessMohsClass = new Package.HardnessMohsClass());

	private Package.LineClass _LineClass;
	/// <summary>
	/// <inheritdoc cref="Package.LineClass" path="/summary" />
	/// </summary>
	public Package.LineClass LineClass => _LineClass ?? (_LineClass = new Package.LineClass());

	private Package.LineMaximumClass _LineMaximumClass;
	/// <summary>
	/// <inheritdoc cref="Package.LineMaximumClass" path="/summary" />
	/// </summary>
	public Package.LineMaximumClass LineMaximumClass => _LineMaximumClass ?? (_LineMaximumClass = new Package.LineMaximumClass());

	private Package.LineMinimumClass _LineMinimumClass;
	/// <summary>
	/// <inheritdoc cref="Package.LineMinimumClass" path="/summary" />
	/// </summary>
	public Package.LineMinimumClass LineMinimumClass => _LineMinimumClass ?? (_LineMinimumClass = new Package.LineMinimumClass());

	private Package.LineLabelClass _LineLabelClass;
	/// <summary>
	/// <inheritdoc cref="Package.LineLabelClass" path="/summary" />
	/// </summary>
	public Package.LineLabelClass LineLabelClass => _LineLabelClass ?? (_LineLabelClass = new Package.LineLabelClass());

	private Package.LineNumberClass _LineNumberClass;
	/// <summary>
	/// <inheritdoc cref="Package.LineNumberClass" path="/summary" />
	/// </summary>
	public Package.LineNumberClass LineNumberClass => _LineNumberClass ?? (_LineNumberClass = new Package.LineNumberClass());

	private Package.LineNumberAbsoluteClass _LineNumberAbsoluteClass;
	/// <summary>
	/// <inheritdoc cref="Package.LineNumberAbsoluteClass" path="/summary" />
	/// </summary>
	public Package.LineNumberAbsoluteClass LineNumberAbsoluteClass => _LineNumberAbsoluteClass ?? (_LineNumberAbsoluteClass = new Package.LineNumberAbsoluteClass());

	private Package.LineNumberIncrementalClass _LineNumberIncrementalClass;
	/// <summary>
	/// <inheritdoc cref="Package.LineNumberIncrementalClass" path="/summary" />
	/// </summary>
	public Package.LineNumberIncrementalClass LineNumberIncrementalClass => _LineNumberIncrementalClass ?? (_LineNumberIncrementalClass = new Package.LineNumberIncrementalClass());

	private Package.MaterialClass _MaterialClass;
	/// <summary>
	/// <inheritdoc cref="Package.MaterialClass" path="/summary" />
	/// </summary>
	public Package.MaterialClass MaterialClass => _MaterialClass ?? (_MaterialClass = new Package.MaterialClass());

	private Package.MaterialLayerClass _MaterialLayerClass;
	/// <summary>
	/// <inheritdoc cref="Package.MaterialLayerClass" path="/summary" />
	/// </summary>
	public Package.MaterialLayerClass MaterialLayerClass => _MaterialLayerClass ?? (_MaterialLayerClass = new Package.MaterialLayerClass());

	private Package.MaterialLayerActualClass _MaterialLayerActualClass;
	/// <summary>
	/// <inheritdoc cref="Package.MaterialLayerActualClass" path="/summary" />
	/// </summary>
	public Package.MaterialLayerActualClass MaterialLayerActualClass => _MaterialLayerActualClass ?? (_MaterialLayerActualClass = new Package.MaterialLayerActualClass());

	private Package.MaterialLayerTargetClass _MaterialLayerTargetClass;
	/// <summary>
	/// <inheritdoc cref="Package.MaterialLayerTargetClass" path="/summary" />
	/// </summary>
	public Package.MaterialLayerTargetClass MaterialLayerTargetClass => _MaterialLayerTargetClass ?? (_MaterialLayerTargetClass = new Package.MaterialLayerTargetClass());

	private Package.MessageClass _MessageClass;
	/// <summary>
	/// <inheritdoc cref="Package.MessageClass" path="/summary" />
	/// </summary>
	public Package.MessageClass MessageClass => _MessageClass ?? (_MessageClass = new Package.MessageClass());

	private Package.OperatorIdClass _OperatorIdClass;
	/// <summary>
	/// <inheritdoc cref="Package.OperatorIdClass" path="/summary" />
	/// </summary>
	public Package.OperatorIdClass OperatorIdClass => _OperatorIdClass ?? (_OperatorIdClass = new Package.OperatorIdClass());

	private Package.PalletIdClass _PalletIdClass;
	/// <summary>
	/// <inheritdoc cref="Package.PalletIdClass" path="/summary" />
	/// </summary>
	public Package.PalletIdClass PalletIdClass => _PalletIdClass ?? (_PalletIdClass = new Package.PalletIdClass());

	private Package.PartCountClass _PartCountClass;
	/// <summary>
	/// <inheritdoc cref="Package.PartCountClass" path="/summary" />
	/// </summary>
	public Package.PartCountClass PartCountClass => _PartCountClass ?? (_PartCountClass = new Package.PartCountClass());

	private Package.PartCountAllClass _PartCountAllClass;
	/// <summary>
	/// <inheritdoc cref="Package.PartCountAllClass" path="/summary" />
	/// </summary>
	public Package.PartCountAllClass PartCountAllClass => _PartCountAllClass ?? (_PartCountAllClass = new Package.PartCountAllClass());

	private Package.PartCountGoodClass _PartCountGoodClass;
	/// <summary>
	/// <inheritdoc cref="Package.PartCountGoodClass" path="/summary" />
	/// </summary>
	public Package.PartCountGoodClass PartCountGoodClass => _PartCountGoodClass ?? (_PartCountGoodClass = new Package.PartCountGoodClass());

	private Package.PartCountBadClass _PartCountBadClass;
	/// <summary>
	/// <inheritdoc cref="Package.PartCountBadClass" path="/summary" />
	/// </summary>
	public Package.PartCountBadClass PartCountBadClass => _PartCountBadClass ?? (_PartCountBadClass = new Package.PartCountBadClass());

	private Package.PartCountTargetClass _PartCountTargetClass;
	/// <summary>
	/// <inheritdoc cref="Package.PartCountTargetClass" path="/summary" />
	/// </summary>
	public Package.PartCountTargetClass PartCountTargetClass => _PartCountTargetClass ?? (_PartCountTargetClass = new Package.PartCountTargetClass());

	private Package.PartCountRemainingClass _PartCountRemainingClass;
	/// <summary>
	/// <inheritdoc cref="Package.PartCountRemainingClass" path="/summary" />
	/// </summary>
	public Package.PartCountRemainingClass PartCountRemainingClass => _PartCountRemainingClass ?? (_PartCountRemainingClass = new Package.PartCountRemainingClass());

	private Package.PartDetectClass _PartDetectClass;
	/// <summary>
	/// <inheritdoc cref="Package.PartDetectClass" path="/summary" />
	/// </summary>
	public Package.PartDetectClass PartDetectClass => _PartDetectClass ?? (_PartDetectClass = new Package.PartDetectClass());

	private Package.PartIdClass _PartIdClass;
	/// <summary>
	/// <inheritdoc cref="Package.PartIdClass" path="/summary" />
	/// </summary>
	public Package.PartIdClass PartIdClass => _PartIdClass ?? (_PartIdClass = new Package.PartIdClass());

	private Package.PartNumberClass _PartNumberClass;
	/// <summary>
	/// <inheritdoc cref="Package.PartNumberClass" path="/summary" />
	/// </summary>
	public Package.PartNumberClass PartNumberClass => _PartNumberClass ?? (_PartNumberClass = new Package.PartNumberClass());

	private Package.PathFeedrateOverrideClass _PathFeedrateOverrideClass;
	/// <summary>
	/// <inheritdoc cref="Package.PathFeedrateOverrideClass" path="/summary" />
	/// </summary>
	public Package.PathFeedrateOverrideClass PathFeedrateOverrideClass => _PathFeedrateOverrideClass ?? (_PathFeedrateOverrideClass = new Package.PathFeedrateOverrideClass());

	private Package.PathFeedrateOverrideJogClass _PathFeedrateOverrideJogClass;
	/// <summary>
	/// <inheritdoc cref="Package.PathFeedrateOverrideJogClass" path="/summary" />
	/// </summary>
	public Package.PathFeedrateOverrideJogClass PathFeedrateOverrideJogClass => _PathFeedrateOverrideJogClass ?? (_PathFeedrateOverrideJogClass = new Package.PathFeedrateOverrideJogClass());

	private Package.PathFeedrateOverrideProgrammedClass _PathFeedrateOverrideProgrammedClass;
	/// <summary>
	/// <inheritdoc cref="Package.PathFeedrateOverrideProgrammedClass" path="/summary" />
	/// </summary>
	public Package.PathFeedrateOverrideProgrammedClass PathFeedrateOverrideProgrammedClass => _PathFeedrateOverrideProgrammedClass ?? (_PathFeedrateOverrideProgrammedClass = new Package.PathFeedrateOverrideProgrammedClass());

	private Package.PathFeedrateOverrideRapidClass _PathFeedrateOverrideRapidClass;
	/// <summary>
	/// <inheritdoc cref="Package.PathFeedrateOverrideRapidClass" path="/summary" />
	/// </summary>
	public Package.PathFeedrateOverrideRapidClass PathFeedrateOverrideRapidClass => _PathFeedrateOverrideRapidClass ?? (_PathFeedrateOverrideRapidClass = new Package.PathFeedrateOverrideRapidClass());

	private Package.PathModeClass _PathModeClass;
	/// <summary>
	/// <inheritdoc cref="Package.PathModeClass" path="/summary" />
	/// </summary>
	public Package.PathModeClass PathModeClass => _PathModeClass ?? (_PathModeClass = new Package.PathModeClass());

	private Package.PowerStateClass _PowerStateClass;
	/// <summary>
	/// <inheritdoc cref="Package.PowerStateClass" path="/summary" />
	/// </summary>
	public Package.PowerStateClass PowerStateClass => _PowerStateClass ?? (_PowerStateClass = new Package.PowerStateClass());

	private Package.PowerStateLineClass _PowerStateLineClass;
	/// <summary>
	/// <inheritdoc cref="Package.PowerStateLineClass" path="/summary" />
	/// </summary>
	public Package.PowerStateLineClass PowerStateLineClass => _PowerStateLineClass ?? (_PowerStateLineClass = new Package.PowerStateLineClass());

	private Package.PowerStateControlClass _PowerStateControlClass;
	/// <summary>
	/// <inheritdoc cref="Package.PowerStateControlClass" path="/summary" />
	/// </summary>
	public Package.PowerStateControlClass PowerStateControlClass => _PowerStateControlClass ?? (_PowerStateControlClass = new Package.PowerStateControlClass());

	private Package.PowerStatusClass _PowerStatusClass;
	/// <summary>
	/// <inheritdoc cref="Package.PowerStatusClass" path="/summary" />
	/// </summary>
	public Package.PowerStatusClass PowerStatusClass => _PowerStatusClass ?? (_PowerStatusClass = new Package.PowerStatusClass());

	private Package.ProcessTimeClass _ProcessTimeClass;
	/// <summary>
	/// <inheritdoc cref="Package.ProcessTimeClass" path="/summary" />
	/// </summary>
	public Package.ProcessTimeClass ProcessTimeClass => _ProcessTimeClass ?? (_ProcessTimeClass = new Package.ProcessTimeClass());

	private Package.ProcessTimeStartClass _ProcessTimeStartClass;
	/// <summary>
	/// <inheritdoc cref="Package.ProcessTimeStartClass" path="/summary" />
	/// </summary>
	public Package.ProcessTimeStartClass ProcessTimeStartClass => _ProcessTimeStartClass ?? (_ProcessTimeStartClass = new Package.ProcessTimeStartClass());

	private Package.ProcessTimeCompleteClass _ProcessTimeCompleteClass;
	/// <summary>
	/// <inheritdoc cref="Package.ProcessTimeCompleteClass" path="/summary" />
	/// </summary>
	public Package.ProcessTimeCompleteClass ProcessTimeCompleteClass => _ProcessTimeCompleteClass ?? (_ProcessTimeCompleteClass = new Package.ProcessTimeCompleteClass());

	private Package.ProcessTimeTargetCompletionClass _ProcessTimeTargetCompletionClass;
	/// <summary>
	/// <inheritdoc cref="Package.ProcessTimeTargetCompletionClass" path="/summary" />
	/// </summary>
	public Package.ProcessTimeTargetCompletionClass ProcessTimeTargetCompletionClass => _ProcessTimeTargetCompletionClass ?? (_ProcessTimeTargetCompletionClass = new Package.ProcessTimeTargetCompletionClass());

	private Package.ProgramClass _ProgramClass;
	/// <summary>
	/// <inheritdoc cref="Package.ProgramClass" path="/summary" />
	/// </summary>
	public Package.ProgramClass ProgramClass => _ProgramClass ?? (_ProgramClass = new Package.ProgramClass());

	private Package.ProgramCommentClass _ProgramCommentClass;
	/// <summary>
	/// <inheritdoc cref="Package.ProgramCommentClass" path="/summary" />
	/// </summary>
	public Package.ProgramCommentClass ProgramCommentClass => _ProgramCommentClass ?? (_ProgramCommentClass = new Package.ProgramCommentClass());

	private Package.ProgramEditClass _ProgramEditClass;
	/// <summary>
	/// <inheritdoc cref="Package.ProgramEditClass" path="/summary" />
	/// </summary>
	public Package.ProgramEditClass ProgramEditClass => _ProgramEditClass ?? (_ProgramEditClass = new Package.ProgramEditClass());

	private Package.ProgramEditNameClass _ProgramEditNameClass;
	/// <summary>
	/// <inheritdoc cref="Package.ProgramEditNameClass" path="/summary" />
	/// </summary>
	public Package.ProgramEditNameClass ProgramEditNameClass => _ProgramEditNameClass ?? (_ProgramEditNameClass = new Package.ProgramEditNameClass());

	private Package.ProgramHeaderClass _ProgramHeaderClass;
	/// <summary>
	/// <inheritdoc cref="Package.ProgramHeaderClass" path="/summary" />
	/// </summary>
	public Package.ProgramHeaderClass ProgramHeaderClass => _ProgramHeaderClass ?? (_ProgramHeaderClass = new Package.ProgramHeaderClass());

	private Package.ProgramLocationClass _ProgramLocationClass;
	/// <summary>
	/// <inheritdoc cref="Package.ProgramLocationClass" path="/summary" />
	/// </summary>
	public Package.ProgramLocationClass ProgramLocationClass => _ProgramLocationClass ?? (_ProgramLocationClass = new Package.ProgramLocationClass());

	private Package.ProgramLocationScheduleClass _ProgramLocationScheduleClass;
	/// <summary>
	/// <inheritdoc cref="Package.ProgramLocationScheduleClass" path="/summary" />
	/// </summary>
	public Package.ProgramLocationScheduleClass ProgramLocationScheduleClass => _ProgramLocationScheduleClass ?? (_ProgramLocationScheduleClass = new Package.ProgramLocationScheduleClass());

	private Package.ProgramLocationMainClass _ProgramLocationMainClass;
	/// <summary>
	/// <inheritdoc cref="Package.ProgramLocationMainClass" path="/summary" />
	/// </summary>
	public Package.ProgramLocationMainClass ProgramLocationMainClass => _ProgramLocationMainClass ?? (_ProgramLocationMainClass = new Package.ProgramLocationMainClass());

	private Package.ProgramLocationActiveClass _ProgramLocationActiveClass;
	/// <summary>
	/// <inheritdoc cref="Package.ProgramLocationActiveClass" path="/summary" />
	/// </summary>
	public Package.ProgramLocationActiveClass ProgramLocationActiveClass => _ProgramLocationActiveClass ?? (_ProgramLocationActiveClass = new Package.ProgramLocationActiveClass());

	private Package.ProgramLocationTypeClass _ProgramLocationTypeClass;
	/// <summary>
	/// <inheritdoc cref="Package.ProgramLocationTypeClass" path="/summary" />
	/// </summary>
	public Package.ProgramLocationTypeClass ProgramLocationTypeClass => _ProgramLocationTypeClass ?? (_ProgramLocationTypeClass = new Package.ProgramLocationTypeClass());

	private Package.ProgramLocationTypeScheduleClass _ProgramLocationTypeScheduleClass;
	/// <summary>
	/// <inheritdoc cref="Package.ProgramLocationTypeScheduleClass" path="/summary" />
	/// </summary>
	public Package.ProgramLocationTypeScheduleClass ProgramLocationTypeScheduleClass => _ProgramLocationTypeScheduleClass ?? (_ProgramLocationTypeScheduleClass = new Package.ProgramLocationTypeScheduleClass());

	private Package.ProgramLocationTypeMainClass _ProgramLocationTypeMainClass;
	/// <summary>
	/// <inheritdoc cref="Package.ProgramLocationTypeMainClass" path="/summary" />
	/// </summary>
	public Package.ProgramLocationTypeMainClass ProgramLocationTypeMainClass => _ProgramLocationTypeMainClass ?? (_ProgramLocationTypeMainClass = new Package.ProgramLocationTypeMainClass());

	private Package.ProgramLocationTypeActiveClass _ProgramLocationTypeActiveClass;
	/// <summary>
	/// <inheritdoc cref="Package.ProgramLocationTypeActiveClass" path="/summary" />
	/// </summary>
	public Package.ProgramLocationTypeActiveClass ProgramLocationTypeActiveClass => _ProgramLocationTypeActiveClass ?? (_ProgramLocationTypeActiveClass = new Package.ProgramLocationTypeActiveClass());

	private Package.ProgramNestLevelClass _ProgramNestLevelClass;
	/// <summary>
	/// <inheritdoc cref="Package.ProgramNestLevelClass" path="/summary" />
	/// </summary>
	public Package.ProgramNestLevelClass ProgramNestLevelClass => _ProgramNestLevelClass ?? (_ProgramNestLevelClass = new Package.ProgramNestLevelClass());

	private Package.RotaryModeClass _RotaryModeClass;
	/// <summary>
	/// <inheritdoc cref="Package.RotaryModeClass" path="/summary" />
	/// </summary>
	public Package.RotaryModeClass RotaryModeClass => _RotaryModeClass ?? (_RotaryModeClass = new Package.RotaryModeClass());

	private Package.RotaryVelocityOverrideClass _RotaryVelocityOverrideClass;
	/// <summary>
	/// <inheritdoc cref="Package.RotaryVelocityOverrideClass" path="/summary" />
	/// </summary>
	public Package.RotaryVelocityOverrideClass RotaryVelocityOverrideClass => _RotaryVelocityOverrideClass ?? (_RotaryVelocityOverrideClass = new Package.RotaryVelocityOverrideClass());

	private Package.SerialNumberClass _SerialNumberClass;
	/// <summary>
	/// <inheritdoc cref="Package.SerialNumberClass" path="/summary" />
	/// </summary>
	public Package.SerialNumberClass SerialNumberClass => _SerialNumberClass ?? (_SerialNumberClass = new Package.SerialNumberClass());

	private Package.SpindleInterlockClass _SpindleInterlockClass;
	/// <summary>
	/// <inheritdoc cref="Package.SpindleInterlockClass" path="/summary" />
	/// </summary>
	public Package.SpindleInterlockClass SpindleInterlockClass => _SpindleInterlockClass ?? (_SpindleInterlockClass = new Package.SpindleInterlockClass());

	private Package.ToolAssetIdClass _ToolAssetIdClass;
	/// <summary>
	/// <inheritdoc cref="Package.ToolAssetIdClass" path="/summary" />
	/// </summary>
	public Package.ToolAssetIdClass ToolAssetIdClass => _ToolAssetIdClass ?? (_ToolAssetIdClass = new Package.ToolAssetIdClass());

	private Package.ToolGroupClass _ToolGroupClass;
	/// <summary>
	/// <inheritdoc cref="Package.ToolGroupClass" path="/summary" />
	/// </summary>
	public Package.ToolGroupClass ToolGroupClass => _ToolGroupClass ?? (_ToolGroupClass = new Package.ToolGroupClass());

	private Package.ToolIdClass _ToolIdClass;
	/// <summary>
	/// <inheritdoc cref="Package.ToolIdClass" path="/summary" />
	/// </summary>
	public Package.ToolIdClass ToolIdClass => _ToolIdClass ?? (_ToolIdClass = new Package.ToolIdClass());

	private Package.ToolNumberClass _ToolNumberClass;
	/// <summary>
	/// <inheritdoc cref="Package.ToolNumberClass" path="/summary" />
	/// </summary>
	public Package.ToolNumberClass ToolNumberClass => _ToolNumberClass ?? (_ToolNumberClass = new Package.ToolNumberClass());

	private Package.ToolOffsetClass _ToolOffsetClass;
	/// <summary>
	/// <inheritdoc cref="Package.ToolOffsetClass" path="/summary" />
	/// </summary>
	public Package.ToolOffsetClass ToolOffsetClass => _ToolOffsetClass ?? (_ToolOffsetClass = new Package.ToolOffsetClass());

	private Package.ToolOffsetRadialClass _ToolOffsetRadialClass;
	/// <summary>
	/// <inheritdoc cref="Package.ToolOffsetRadialClass" path="/summary" />
	/// </summary>
	public Package.ToolOffsetRadialClass ToolOffsetRadialClass => _ToolOffsetRadialClass ?? (_ToolOffsetRadialClass = new Package.ToolOffsetRadialClass());

	private Package.ToolOffsetLengthClass _ToolOffsetLengthClass;
	/// <summary>
	/// <inheritdoc cref="Package.ToolOffsetLengthClass" path="/summary" />
	/// </summary>
	public Package.ToolOffsetLengthClass ToolOffsetLengthClass => _ToolOffsetLengthClass ?? (_ToolOffsetLengthClass = new Package.ToolOffsetLengthClass());

	private Package.UserClass _UserClass;
	/// <summary>
	/// <inheritdoc cref="Package.UserClass" path="/summary" />
	/// </summary>
	public Package.UserClass UserClass => _UserClass ?? (_UserClass = new Package.UserClass());

	private Package.UserOperatorClass _UserOperatorClass;
	/// <summary>
	/// <inheritdoc cref="Package.UserOperatorClass" path="/summary" />
	/// </summary>
	public Package.UserOperatorClass UserOperatorClass => _UserOperatorClass ?? (_UserOperatorClass = new Package.UserOperatorClass());

	private Package.UserMaintenanceClass _UserMaintenanceClass;
	/// <summary>
	/// <inheritdoc cref="Package.UserMaintenanceClass" path="/summary" />
	/// </summary>
	public Package.UserMaintenanceClass UserMaintenanceClass => _UserMaintenanceClass ?? (_UserMaintenanceClass = new Package.UserMaintenanceClass());

	private Package.UserSetUpClass _UserSetUpClass;
	/// <summary>
	/// <inheritdoc cref="Package.UserSetUpClass" path="/summary" />
	/// </summary>
	public Package.UserSetUpClass UserSetUpClass => _UserSetUpClass ?? (_UserSetUpClass = new Package.UserSetUpClass());

	private Package.VariableClass _VariableClass;
	/// <summary>
	/// <inheritdoc cref="Package.VariableClass" path="/summary" />
	/// </summary>
	public Package.VariableClass VariableClass => _VariableClass ?? (_VariableClass = new Package.VariableClass());

	private Package.WaitStateClass _WaitStateClass;
	/// <summary>
	/// <inheritdoc cref="Package.WaitStateClass" path="/summary" />
	/// </summary>
	public Package.WaitStateClass WaitStateClass => _WaitStateClass ?? (_WaitStateClass = new Package.WaitStateClass());

	private Package.WireClass _WireClass;
	/// <summary>
	/// <inheritdoc cref="Package.WireClass" path="/summary" />
	/// </summary>
	public Package.WireClass WireClass => _WireClass ?? (_WireClass = new Package.WireClass());

	private Package.WorkholdingIdClass _WorkholdingIdClass;
	/// <summary>
	/// <inheritdoc cref="Package.WorkholdingIdClass" path="/summary" />
	/// </summary>
	public Package.WorkholdingIdClass WorkholdingIdClass => _WorkholdingIdClass ?? (_WorkholdingIdClass = new Package.WorkholdingIdClass());

	private Package.WorkOffsetClass _WorkOffsetClass;
	/// <summary>
	/// <inheritdoc cref="Package.WorkOffsetClass" path="/summary" />
	/// </summary>
	public Package.WorkOffsetClass WorkOffsetClass => _WorkOffsetClass ?? (_WorkOffsetClass = new Package.WorkOffsetClass());

	private Package.ProgramHeaderMainClass _ProgramHeaderMainClass;
	/// <summary>
	/// <inheritdoc cref="Package.ProgramHeaderMainClass" path="/summary" />
	/// </summary>
	public Package.ProgramHeaderMainClass ProgramHeaderMainClass => _ProgramHeaderMainClass ?? (_ProgramHeaderMainClass = new Package.ProgramHeaderMainClass());

	private Package.ProgramHeaderScheduleClass _ProgramHeaderScheduleClass;
	/// <summary>
	/// <inheritdoc cref="Package.ProgramHeaderScheduleClass" path="/summary" />
	/// </summary>
	public Package.ProgramHeaderScheduleClass ProgramHeaderScheduleClass => _ProgramHeaderScheduleClass ?? (_ProgramHeaderScheduleClass = new Package.ProgramHeaderScheduleClass());

	private Package.ProgramHeaderActiveClass _ProgramHeaderActiveClass;
	/// <summary>
	/// <inheritdoc cref="Package.ProgramHeaderActiveClass" path="/summary" />
	/// </summary>
	public Package.ProgramHeaderActiveClass ProgramHeaderActiveClass => _ProgramHeaderActiveClass ?? (_ProgramHeaderActiveClass = new Package.ProgramHeaderActiveClass());

	private Package.OperatingSystemClass _OperatingSystemClass;
	/// <summary>
	/// <inheritdoc cref="Package.OperatingSystemClass" path="/summary" />
	/// </summary>
	public Package.OperatingSystemClass OperatingSystemClass => _OperatingSystemClass ?? (_OperatingSystemClass = new Package.OperatingSystemClass());

	private Package.OperatingSystemLicenseClass _OperatingSystemLicenseClass;
	/// <summary>
	/// <inheritdoc cref="Package.OperatingSystemLicenseClass" path="/summary" />
	/// </summary>
	public Package.OperatingSystemLicenseClass OperatingSystemLicenseClass => _OperatingSystemLicenseClass ?? (_OperatingSystemLicenseClass = new Package.OperatingSystemLicenseClass());

	private Package.OperatingSystemVersionClass _OperatingSystemVersionClass;
	/// <summary>
	/// <inheritdoc cref="Package.OperatingSystemVersionClass" path="/summary" />
	/// </summary>
	public Package.OperatingSystemVersionClass OperatingSystemVersionClass => _OperatingSystemVersionClass ?? (_OperatingSystemVersionClass = new Package.OperatingSystemVersionClass());

	private Package.OperatingSystemReleaseDateClass _OperatingSystemReleaseDateClass;
	/// <summary>
	/// <inheritdoc cref="Package.OperatingSystemReleaseDateClass" path="/summary" />
	/// </summary>
	public Package.OperatingSystemReleaseDateClass OperatingSystemReleaseDateClass => _OperatingSystemReleaseDateClass ?? (_OperatingSystemReleaseDateClass = new Package.OperatingSystemReleaseDateClass());

	private Package.OperatingSystemInstallDateClass _OperatingSystemInstallDateClass;
	/// <summary>
	/// <inheritdoc cref="Package.OperatingSystemInstallDateClass" path="/summary" />
	/// </summary>
	public Package.OperatingSystemInstallDateClass OperatingSystemInstallDateClass => _OperatingSystemInstallDateClass ?? (_OperatingSystemInstallDateClass = new Package.OperatingSystemInstallDateClass());

	private Package.OperatingSystemManufacturerClass _OperatingSystemManufacturerClass;
	/// <summary>
	/// <inheritdoc cref="Package.OperatingSystemManufacturerClass" path="/summary" />
	/// </summary>
	public Package.OperatingSystemManufacturerClass OperatingSystemManufacturerClass => _OperatingSystemManufacturerClass ?? (_OperatingSystemManufacturerClass = new Package.OperatingSystemManufacturerClass());

	private Package.FirmwareVersionClass _FirmwareVersionClass;
	/// <summary>
	/// <inheritdoc cref="Package.FirmwareVersionClass" path="/summary" />
	/// </summary>
	public Package.FirmwareVersionClass FirmwareVersionClass => _FirmwareVersionClass ?? (_FirmwareVersionClass = new Package.FirmwareVersionClass());

	private Package.FirmwareReleaseDateClass _FirmwareReleaseDateClass;
	/// <summary>
	/// <inheritdoc cref="Package.FirmwareReleaseDateClass" path="/summary" />
	/// </summary>
	public Package.FirmwareReleaseDateClass FirmwareReleaseDateClass => _FirmwareReleaseDateClass ?? (_FirmwareReleaseDateClass = new Package.FirmwareReleaseDateClass());

	private Package.FirmwareClass _FirmwareClass;
	/// <summary>
	/// <inheritdoc cref="Package.FirmwareClass" path="/summary" />
	/// </summary>
	public Package.FirmwareClass FirmwareClass => _FirmwareClass ?? (_FirmwareClass = new Package.FirmwareClass());

	private Package.FirmwareManufacturerClass _FirmwareManufacturerClass;
	/// <summary>
	/// <inheritdoc cref="Package.FirmwareManufacturerClass" path="/summary" />
	/// </summary>
	public Package.FirmwareManufacturerClass FirmwareManufacturerClass => _FirmwareManufacturerClass ?? (_FirmwareManufacturerClass = new Package.FirmwareManufacturerClass());

	private Package.FirmwareLicenseClass _FirmwareLicenseClass;
	/// <summary>
	/// <inheritdoc cref="Package.FirmwareLicenseClass" path="/summary" />
	/// </summary>
	public Package.FirmwareLicenseClass FirmwareLicenseClass => _FirmwareLicenseClass ?? (_FirmwareLicenseClass = new Package.FirmwareLicenseClass());

	private Package.FirmwareInstallDateClass _FirmwareInstallDateClass;
	/// <summary>
	/// <inheritdoc cref="Package.FirmwareInstallDateClass" path="/summary" />
	/// </summary>
	public Package.FirmwareInstallDateClass FirmwareInstallDateClass => _FirmwareInstallDateClass ?? (_FirmwareInstallDateClass = new Package.FirmwareInstallDateClass());

	private Package.ApplicationVersionClass _ApplicationVersionClass;
	/// <summary>
	/// <inheritdoc cref="Package.ApplicationVersionClass" path="/summary" />
	/// </summary>
	public Package.ApplicationVersionClass ApplicationVersionClass => _ApplicationVersionClass ?? (_ApplicationVersionClass = new Package.ApplicationVersionClass());

	private Package.ApplicationReleaseDateClass _ApplicationReleaseDateClass;
	/// <summary>
	/// <inheritdoc cref="Package.ApplicationReleaseDateClass" path="/summary" />
	/// </summary>
	public Package.ApplicationReleaseDateClass ApplicationReleaseDateClass => _ApplicationReleaseDateClass ?? (_ApplicationReleaseDateClass = new Package.ApplicationReleaseDateClass());

	private Package.ApplicationClass _ApplicationClass;
	/// <summary>
	/// <inheritdoc cref="Package.ApplicationClass" path="/summary" />
	/// </summary>
	public Package.ApplicationClass ApplicationClass => _ApplicationClass ?? (_ApplicationClass = new Package.ApplicationClass());

	private Package.ApplicationManufacturerClass _ApplicationManufacturerClass;
	/// <summary>
	/// <inheritdoc cref="Package.ApplicationManufacturerClass" path="/summary" />
	/// </summary>
	public Package.ApplicationManufacturerClass ApplicationManufacturerClass => _ApplicationManufacturerClass ?? (_ApplicationManufacturerClass = new Package.ApplicationManufacturerClass());

	private Package.ApplicationLicenseClass _ApplicationLicenseClass;
	/// <summary>
	/// <inheritdoc cref="Package.ApplicationLicenseClass" path="/summary" />
	/// </summary>
	public Package.ApplicationLicenseClass ApplicationLicenseClass => _ApplicationLicenseClass ?? (_ApplicationLicenseClass = new Package.ApplicationLicenseClass());

	private Package.ApplicationInstallDateClass _ApplicationInstallDateClass;
	/// <summary>
	/// <inheritdoc cref="Package.ApplicationInstallDateClass" path="/summary" />
	/// </summary>
	public Package.ApplicationInstallDateClass ApplicationInstallDateClass => _ApplicationInstallDateClass ?? (_ApplicationInstallDateClass = new Package.ApplicationInstallDateClass());

	private Package.LibraryVersionClass _LibraryVersionClass;
	/// <summary>
	/// <inheritdoc cref="Package.LibraryVersionClass" path="/summary" />
	/// </summary>
	public Package.LibraryVersionClass LibraryVersionClass => _LibraryVersionClass ?? (_LibraryVersionClass = new Package.LibraryVersionClass());

	private Package.LibraryReleaseDateClass _LibraryReleaseDateClass;
	/// <summary>
	/// <inheritdoc cref="Package.LibraryReleaseDateClass" path="/summary" />
	/// </summary>
	public Package.LibraryReleaseDateClass LibraryReleaseDateClass => _LibraryReleaseDateClass ?? (_LibraryReleaseDateClass = new Package.LibraryReleaseDateClass());

	private Package.LibraryClass _LibraryClass;
	/// <summary>
	/// <inheritdoc cref="Package.LibraryClass" path="/summary" />
	/// </summary>
	public Package.LibraryClass LibraryClass => _LibraryClass ?? (_LibraryClass = new Package.LibraryClass());

	private Package.LibraryManufacturerClass _LibraryManufacturerClass;
	/// <summary>
	/// <inheritdoc cref="Package.LibraryManufacturerClass" path="/summary" />
	/// </summary>
	public Package.LibraryManufacturerClass LibraryManufacturerClass => _LibraryManufacturerClass ?? (_LibraryManufacturerClass = new Package.LibraryManufacturerClass());

	private Package.LibraryLicenseClass _LibraryLicenseClass;
	/// <summary>
	/// <inheritdoc cref="Package.LibraryLicenseClass" path="/summary" />
	/// </summary>
	public Package.LibraryLicenseClass LibraryLicenseClass => _LibraryLicenseClass ?? (_LibraryLicenseClass = new Package.LibraryLicenseClass());

	private Package.LibraryInstallDateClass _LibraryInstallDateClass;
	/// <summary>
	/// <inheritdoc cref="Package.LibraryInstallDateClass" path="/summary" />
	/// </summary>
	public Package.LibraryInstallDateClass LibraryInstallDateClass => _LibraryInstallDateClass ?? (_LibraryInstallDateClass = new Package.LibraryInstallDateClass());

	private Package.HardwareVersionClass _HardwareVersionClass;
	/// <summary>
	/// <inheritdoc cref="Package.HardwareVersionClass" path="/summary" />
	/// </summary>
	public Package.HardwareVersionClass HardwareVersionClass => _HardwareVersionClass ?? (_HardwareVersionClass = new Package.HardwareVersionClass());

	private Package.HardwareReleaseDateClass _HardwareReleaseDateClass;
	/// <summary>
	/// <inheritdoc cref="Package.HardwareReleaseDateClass" path="/summary" />
	/// </summary>
	public Package.HardwareReleaseDateClass HardwareReleaseDateClass => _HardwareReleaseDateClass ?? (_HardwareReleaseDateClass = new Package.HardwareReleaseDateClass());

	private Package.HardwareClass _HardwareClass;
	/// <summary>
	/// <inheritdoc cref="Package.HardwareClass" path="/summary" />
	/// </summary>
	public Package.HardwareClass HardwareClass => _HardwareClass ?? (_HardwareClass = new Package.HardwareClass());

	private Package.HardwareManufacturerClass _HardwareManufacturerClass;
	/// <summary>
	/// <inheritdoc cref="Package.HardwareManufacturerClass" path="/summary" />
	/// </summary>
	public Package.HardwareManufacturerClass HardwareManufacturerClass => _HardwareManufacturerClass ?? (_HardwareManufacturerClass = new Package.HardwareManufacturerClass());

	private Package.HardwareLicenseClass _HardwareLicenseClass;
	/// <summary>
	/// <inheritdoc cref="Package.HardwareLicenseClass" path="/summary" />
	/// </summary>
	public Package.HardwareLicenseClass HardwareLicenseClass => _HardwareLicenseClass ?? (_HardwareLicenseClass = new Package.HardwareLicenseClass());

	private Package.HardwareInstallDateClass _HardwareInstallDateClass;
	/// <summary>
	/// <inheritdoc cref="Package.HardwareInstallDateClass" path="/summary" />
	/// </summary>
	public Package.HardwareInstallDateClass HardwareInstallDateClass => _HardwareInstallDateClass ?? (_HardwareInstallDateClass = new Package.HardwareInstallDateClass());

	private Package.NetworkClass _NetworkClass;
	/// <summary>
	/// <inheritdoc cref="Package.NetworkClass" path="/summary" />
	/// </summary>
	public Package.NetworkClass NetworkClass => _NetworkClass ?? (_NetworkClass = new Package.NetworkClass());

	private Package.NetworkIPv4AddressClass _NetworkIPv4AddressClass;
	/// <summary>
	/// <inheritdoc cref="Package.NetworkIPv4AddressClass" path="/summary" />
	/// </summary>
	public Package.NetworkIPv4AddressClass NetworkIPv4AddressClass => _NetworkIPv4AddressClass ?? (_NetworkIPv4AddressClass = new Package.NetworkIPv4AddressClass());

	private Package.NetworkIPv6AddressClass _NetworkIPv6AddressClass;
	/// <summary>
	/// <inheritdoc cref="Package.NetworkIPv6AddressClass" path="/summary" />
	/// </summary>
	public Package.NetworkIPv6AddressClass NetworkIPv6AddressClass => _NetworkIPv6AddressClass ?? (_NetworkIPv6AddressClass = new Package.NetworkIPv6AddressClass());

	private Package.NetworkGatewayClass _NetworkGatewayClass;
	/// <summary>
	/// <inheritdoc cref="Package.NetworkGatewayClass" path="/summary" />
	/// </summary>
	public Package.NetworkGatewayClass NetworkGatewayClass => _NetworkGatewayClass ?? (_NetworkGatewayClass = new Package.NetworkGatewayClass());

	private Package.NetworkSubnetMaskClass _NetworkSubnetMaskClass;
	/// <summary>
	/// <inheritdoc cref="Package.NetworkSubnetMaskClass" path="/summary" />
	/// </summary>
	public Package.NetworkSubnetMaskClass NetworkSubnetMaskClass => _NetworkSubnetMaskClass ?? (_NetworkSubnetMaskClass = new Package.NetworkSubnetMaskClass());

	private Package.NetworkVLanIdClass _NetworkVLanIdClass;
	/// <summary>
	/// <inheritdoc cref="Package.NetworkVLanIdClass" path="/summary" />
	/// </summary>
	public Package.NetworkVLanIdClass NetworkVLanIdClass => _NetworkVLanIdClass ?? (_NetworkVLanIdClass = new Package.NetworkVLanIdClass());

	private Package.NetworkMacAddressClass _NetworkMacAddressClass;
	/// <summary>
	/// <inheritdoc cref="Package.NetworkMacAddressClass" path="/summary" />
	/// </summary>
	public Package.NetworkMacAddressClass NetworkMacAddressClass => _NetworkMacAddressClass ?? (_NetworkMacAddressClass = new Package.NetworkMacAddressClass());

	private Package.NetworkWirelessClass _NetworkWirelessClass;
	/// <summary>
	/// <inheritdoc cref="Package.NetworkWirelessClass" path="/summary" />
	/// </summary>
	public Package.NetworkWirelessClass NetworkWirelessClass => _NetworkWirelessClass ?? (_NetworkWirelessClass = new Package.NetworkWirelessClass());

	private Package.RotationClass _RotationClass;
	/// <summary>
	/// <inheritdoc cref="Package.RotationClass" path="/summary" />
	/// </summary>
	public Package.RotationClass RotationClass => _RotationClass ?? (_RotationClass = new Package.RotationClass());

	private Package.TranslationClass _TranslationClass;
	/// <summary>
	/// <inheritdoc cref="Package.TranslationClass" path="/summary" />
	/// </summary>
	public Package.TranslationClass TranslationClass => _TranslationClass ?? (_TranslationClass = new Package.TranslationClass());

	private Package.ProcessKindIdClass _ProcessKindIdClass;
	/// <summary>
	/// <inheritdoc cref="Package.ProcessKindIdClass" path="/summary" />
	/// </summary>
	public Package.ProcessKindIdClass ProcessKindIdClass => _ProcessKindIdClass ?? (_ProcessKindIdClass = new Package.ProcessKindIdClass());

	private Package.PartStatusClass _PartStatusClass;
	/// <summary>
	/// <inheritdoc cref="Package.PartStatusClass" path="/summary" />
	/// </summary>
	public Package.PartStatusClass PartStatusClass => _PartStatusClass ?? (_PartStatusClass = new Package.PartStatusClass());

	private Package.AlarmLimitClass _AlarmLimitClass;
	/// <summary>
	/// <inheritdoc cref="Package.AlarmLimitClass" path="/summary" />
	/// </summary>
	public Package.AlarmLimitClass AlarmLimitClass => _AlarmLimitClass ?? (_AlarmLimitClass = new Package.AlarmLimitClass());

	private Package.ProcessAggregateIdClass _ProcessAggregateIdClass;
	/// <summary>
	/// <inheritdoc cref="Package.ProcessAggregateIdClass" path="/summary" />
	/// </summary>
	public Package.ProcessAggregateIdClass ProcessAggregateIdClass => _ProcessAggregateIdClass ?? (_ProcessAggregateIdClass = new Package.ProcessAggregateIdClass());

	private Package.ProcessKindIdUuidClass _ProcessKindIdUuidClass;
	/// <summary>
	/// <inheritdoc cref="Package.ProcessKindIdUuidClass" path="/summary" />
	/// </summary>
	public Package.ProcessKindIdUuidClass ProcessKindIdUuidClass => _ProcessKindIdUuidClass ?? (_ProcessKindIdUuidClass = new Package.ProcessKindIdUuidClass());

	private Package.ProcessAggregateIdOrderNumberClass _ProcessAggregateIdOrderNumberClass;
	/// <summary>
	/// <inheritdoc cref="Package.ProcessAggregateIdOrderNumberClass" path="/summary" />
	/// </summary>
	public Package.ProcessAggregateIdOrderNumberClass ProcessAggregateIdOrderNumberClass => _ProcessAggregateIdOrderNumberClass ?? (_ProcessAggregateIdOrderNumberClass = new Package.ProcessAggregateIdOrderNumberClass());

	private Package.ProcessKindIdISOStepExecutableClass _ProcessKindIdISOStepExecutableClass;
	/// <summary>
	/// <inheritdoc cref="Package.ProcessKindIdISOStepExecutableClass" path="/summary" />
	/// </summary>
	public Package.ProcessKindIdISOStepExecutableClass ProcessKindIdISOStepExecutableClass => _ProcessKindIdISOStepExecutableClass ?? (_ProcessKindIdISOStepExecutableClass = new Package.ProcessKindIdISOStepExecutableClass());

	private Package.PartKindIdClass _PartKindIdClass;
	/// <summary>
	/// <inheritdoc cref="Package.PartKindIdClass" path="/summary" />
	/// </summary>
	public Package.PartKindIdClass PartKindIdClass => _PartKindIdClass ?? (_PartKindIdClass = new Package.PartKindIdClass());

	private Package.ProcessKindIdProcessNameClass _ProcessKindIdProcessNameClass;
	/// <summary>
	/// <inheritdoc cref="Package.ProcessKindIdProcessNameClass" path="/summary" />
	/// </summary>
	public Package.ProcessKindIdProcessNameClass ProcessKindIdProcessNameClass => _ProcessKindIdProcessNameClass ?? (_ProcessKindIdProcessNameClass = new Package.ProcessKindIdProcessNameClass());

	private Package.AdapterURIClass _AdapterURIClass;
	/// <summary>
	/// <inheritdoc cref="Package.AdapterURIClass" path="/summary" />
	/// </summary>
	public Package.AdapterURIClass AdapterURIClass => _AdapterURIClass ?? (_AdapterURIClass = new Package.AdapterURIClass());

	private Package.PartKindIdUuidClass _PartKindIdUuidClass;
	/// <summary>
	/// <inheritdoc cref="Package.PartKindIdUuidClass" path="/summary" />
	/// </summary>
	public Package.PartKindIdUuidClass PartKindIdUuidClass => _PartKindIdUuidClass ?? (_PartKindIdUuidClass = new Package.PartKindIdUuidClass());

	private Package.DeviceRemovedClass _DeviceRemovedClass;
	/// <summary>
	/// <inheritdoc cref="Package.DeviceRemovedClass" path="/summary" />
	/// </summary>
	public Package.DeviceRemovedClass DeviceRemovedClass => _DeviceRemovedClass ?? (_DeviceRemovedClass = new Package.DeviceRemovedClass());

	private Package.DeviceChangedClass _DeviceChangedClass;
	/// <summary>
	/// <inheritdoc cref="Package.DeviceChangedClass" path="/summary" />
	/// </summary>
	public Package.DeviceChangedClass DeviceChangedClass => _DeviceChangedClass ?? (_DeviceChangedClass = new Package.DeviceChangedClass());

	private Package.SpecificationLimitClass _SpecificationLimitClass;
	/// <summary>
	/// <inheritdoc cref="Package.SpecificationLimitClass" path="/summary" />
	/// </summary>
	public Package.SpecificationLimitClass SpecificationLimitClass => _SpecificationLimitClass ?? (_SpecificationLimitClass = new Package.SpecificationLimitClass());

	private Package.ConnectionStatusClass _ConnectionStatusClass;
	/// <summary>
	/// <inheritdoc cref="Package.ConnectionStatusClass" path="/summary" />
	/// </summary>
	public Package.ConnectionStatusClass ConnectionStatusClass => _ConnectionStatusClass ?? (_ConnectionStatusClass = new Package.ConnectionStatusClass());

	private Package.PartKindIdPartFamilyClass _PartKindIdPartFamilyClass;
	/// <summary>
	/// <inheritdoc cref="Package.PartKindIdPartFamilyClass" path="/summary" />
	/// </summary>
	public Package.PartKindIdPartFamilyClass PartKindIdPartFamilyClass => _PartKindIdPartFamilyClass ?? (_PartKindIdPartFamilyClass = new Package.PartKindIdPartFamilyClass());

	private Package.PartKindIdPartNameClass _PartKindIdPartNameClass;
	/// <summary>
	/// <inheritdoc cref="Package.PartKindIdPartNameClass" path="/summary" />
	/// </summary>
	public Package.PartKindIdPartNameClass PartKindIdPartNameClass => _PartKindIdPartNameClass ?? (_PartKindIdPartNameClass = new Package.PartKindIdPartNameClass());

	private Package.AdapterSoftwareVersionClass _AdapterSoftwareVersionClass;
	/// <summary>
	/// <inheritdoc cref="Package.AdapterSoftwareVersionClass" path="/summary" />
	/// </summary>
	public Package.AdapterSoftwareVersionClass AdapterSoftwareVersionClass => _AdapterSoftwareVersionClass ?? (_AdapterSoftwareVersionClass = new Package.AdapterSoftwareVersionClass());

	private Package.SensorAttachmentClass _SensorAttachmentClass;
	/// <summary>
	/// <inheritdoc cref="Package.SensorAttachmentClass" path="/summary" />
	/// </summary>
	public Package.SensorAttachmentClass SensorAttachmentClass => _SensorAttachmentClass ?? (_SensorAttachmentClass = new Package.SensorAttachmentClass());

	private Package.PartKindIdPartNumberClass _PartKindIdPartNumberClass;
	/// <summary>
	/// <inheritdoc cref="Package.PartKindIdPartNumberClass" path="/summary" />
	/// </summary>
	public Package.PartKindIdPartNumberClass PartKindIdPartNumberClass => _PartKindIdPartNumberClass ?? (_PartKindIdPartNumberClass = new Package.PartKindIdPartNumberClass());

	private Package.PartGroupIdLotClass _PartGroupIdLotClass;
	/// <summary>
	/// <inheritdoc cref="Package.PartGroupIdLotClass" path="/summary" />
	/// </summary>
	public Package.PartGroupIdLotClass PartGroupIdLotClass => _PartGroupIdLotClass ?? (_PartGroupIdLotClass = new Package.PartGroupIdLotClass());

	private Package.PartGroupIdRawMaterialClass _PartGroupIdRawMaterialClass;
	/// <summary>
	/// <inheritdoc cref="Package.PartGroupIdRawMaterialClass" path="/summary" />
	/// </summary>
	public Package.PartGroupIdRawMaterialClass PartGroupIdRawMaterialClass => _PartGroupIdRawMaterialClass ?? (_PartGroupIdRawMaterialClass = new Package.PartGroupIdRawMaterialClass());

	private Package.PartGroupIdBatchClass _PartGroupIdBatchClass;
	/// <summary>
	/// <inheritdoc cref="Package.PartGroupIdBatchClass" path="/summary" />
	/// </summary>
	public Package.PartGroupIdBatchClass PartGroupIdBatchClass => _PartGroupIdBatchClass ?? (_PartGroupIdBatchClass = new Package.PartGroupIdBatchClass());

	private Package.ControlLimitClass _ControlLimitClass;
	/// <summary>
	/// <inheritdoc cref="Package.ControlLimitClass" path="/summary" />
	/// </summary>
	public Package.ControlLimitClass ControlLimitClass => _ControlLimitClass ?? (_ControlLimitClass = new Package.ControlLimitClass());

	private Package.DeviceAddedClass _DeviceAddedClass;
	/// <summary>
	/// <inheritdoc cref="Package.DeviceAddedClass" path="/summary" />
	/// </summary>
	public Package.DeviceAddedClass DeviceAddedClass => _DeviceAddedClass ?? (_DeviceAddedClass = new Package.DeviceAddedClass());

	private Package.ProcessAggregateIdProcessStepClass _ProcessAggregateIdProcessStepClass;
	/// <summary>
	/// <inheritdoc cref="Package.ProcessAggregateIdProcessStepClass" path="/summary" />
	/// </summary>
	public Package.ProcessAggregateIdProcessStepClass ProcessAggregateIdProcessStepClass => _ProcessAggregateIdProcessStepClass ?? (_ProcessAggregateIdProcessStepClass = new Package.ProcessAggregateIdProcessStepClass());

	private Package.MTConnectVersionClass _MTConnectVersionClass;
	/// <summary>
	/// <inheritdoc cref="Package.MTConnectVersionClass" path="/summary" />
	/// </summary>
	public Package.MTConnectVersionClass MTConnectVersionClass => _MTConnectVersionClass ?? (_MTConnectVersionClass = new Package.MTConnectVersionClass());

	private Package.PartUniqueIdSerialNumberClass _PartUniqueIdSerialNumberClass;
	/// <summary>
	/// <inheritdoc cref="Package.PartUniqueIdSerialNumberClass" path="/summary" />
	/// </summary>
	public Package.PartUniqueIdSerialNumberClass PartUniqueIdSerialNumberClass => _PartUniqueIdSerialNumberClass ?? (_PartUniqueIdSerialNumberClass = new Package.PartUniqueIdSerialNumberClass());

	private Package.PartUniqueIdRawMaterialClass _PartUniqueIdRawMaterialClass;
	/// <summary>
	/// <inheritdoc cref="Package.PartUniqueIdRawMaterialClass" path="/summary" />
	/// </summary>
	public Package.PartUniqueIdRawMaterialClass PartUniqueIdRawMaterialClass => _PartUniqueIdRawMaterialClass ?? (_PartUniqueIdRawMaterialClass = new Package.PartUniqueIdRawMaterialClass());

	private Package.PartGroupIdUuidClass _PartGroupIdUuidClass;
	/// <summary>
	/// <inheritdoc cref="Package.PartGroupIdUuidClass" path="/summary" />
	/// </summary>
	public Package.PartGroupIdUuidClass PartGroupIdUuidClass => _PartGroupIdUuidClass ?? (_PartGroupIdUuidClass = new Package.PartGroupIdUuidClass());

	private Package.ProcessOccurrenceIdClass _ProcessOccurrenceIdClass;
	/// <summary>
	/// <inheritdoc cref="Package.ProcessOccurrenceIdClass" path="/summary" />
	/// </summary>
	public Package.ProcessOccurrenceIdClass ProcessOccurrenceIdClass => _ProcessOccurrenceIdClass ?? (_ProcessOccurrenceIdClass = new Package.ProcessOccurrenceIdClass());

	private Package.ProcessAggregateIdProcessPlanClass _ProcessAggregateIdProcessPlanClass;
	/// <summary>
	/// <inheritdoc cref="Package.ProcessAggregateIdProcessPlanClass" path="/summary" />
	/// </summary>
	public Package.ProcessAggregateIdProcessPlanClass ProcessAggregateIdProcessPlanClass => _ProcessAggregateIdProcessPlanClass ?? (_ProcessAggregateIdProcessPlanClass = new Package.ProcessAggregateIdProcessPlanClass());

	private Package.PartUniqueIdUuidClass _PartUniqueIdUuidClass;
	/// <summary>
	/// <inheritdoc cref="Package.PartUniqueIdUuidClass" path="/summary" />
	/// </summary>
	public Package.PartUniqueIdUuidClass PartUniqueIdUuidClass => _PartUniqueIdUuidClass ?? (_PartUniqueIdUuidClass = new Package.PartUniqueIdUuidClass());

	private Package.PartGroupIdClass _PartGroupIdClass;
	/// <summary>
	/// <inheritdoc cref="Package.PartGroupIdClass" path="/summary" />
	/// </summary>
	public Package.PartGroupIdClass PartGroupIdClass => _PartGroupIdClass ?? (_PartGroupIdClass = new Package.PartGroupIdClass());

	private Package.PartGroupIdHeatTreatClass _PartGroupIdHeatTreatClass;
	/// <summary>
	/// <inheritdoc cref="Package.PartGroupIdHeatTreatClass" path="/summary" />
	/// </summary>
	public Package.PartGroupIdHeatTreatClass PartGroupIdHeatTreatClass => _PartGroupIdHeatTreatClass ?? (_PartGroupIdHeatTreatClass = new Package.PartGroupIdHeatTreatClass());

	private Package.PartUniqueIdClass _PartUniqueIdClass;
	/// <summary>
	/// <inheritdoc cref="Package.PartUniqueIdClass" path="/summary" />
	/// </summary>
	public Package.PartUniqueIdClass PartUniqueIdClass => _PartUniqueIdClass ?? (_PartUniqueIdClass = new Package.PartUniqueIdClass());

	private Package.LoadCountRemainingClass _LoadCountRemainingClass;
	/// <summary>
	/// <inheritdoc cref="Package.LoadCountRemainingClass" path="/summary" />
	/// </summary>
	public Package.LoadCountRemainingClass LoadCountRemainingClass => _LoadCountRemainingClass ?? (_LoadCountRemainingClass = new Package.LoadCountRemainingClass());

	private Package.ActivationCountTargetClass _ActivationCountTargetClass;
	/// <summary>
	/// <inheritdoc cref="Package.ActivationCountTargetClass" path="/summary" />
	/// </summary>
	public Package.ActivationCountTargetClass ActivationCountTargetClass => _ActivationCountTargetClass ?? (_ActivationCountTargetClass = new Package.ActivationCountTargetClass());

	private Package.ActivationCountGoodClass _ActivationCountGoodClass;
	/// <summary>
	/// <inheritdoc cref="Package.ActivationCountGoodClass" path="/summary" />
	/// </summary>
	public Package.ActivationCountGoodClass ActivationCountGoodClass => _ActivationCountGoodClass ?? (_ActivationCountGoodClass = new Package.ActivationCountGoodClass());

	private Package.TransferCountGoodClass _TransferCountGoodClass;
	/// <summary>
	/// <inheritdoc cref="Package.TransferCountGoodClass" path="/summary" />
	/// </summary>
	public Package.TransferCountGoodClass TransferCountGoodClass => _TransferCountGoodClass ?? (_TransferCountGoodClass = new Package.TransferCountGoodClass());

	private Package.CycleCountGoodClass _CycleCountGoodClass;
	/// <summary>
	/// <inheritdoc cref="Package.CycleCountGoodClass" path="/summary" />
	/// </summary>
	public Package.CycleCountGoodClass CycleCountGoodClass => _CycleCountGoodClass ?? (_CycleCountGoodClass = new Package.CycleCountGoodClass());

	private Package.ActivationCountClass _ActivationCountClass;
	/// <summary>
	/// <inheritdoc cref="Package.ActivationCountClass" path="/summary" />
	/// </summary>
	public Package.ActivationCountClass ActivationCountClass => _ActivationCountClass ?? (_ActivationCountClass = new Package.ActivationCountClass());

	private Package.UnloadCountAbortedClass _UnloadCountAbortedClass;
	/// <summary>
	/// <inheritdoc cref="Package.UnloadCountAbortedClass" path="/summary" />
	/// </summary>
	public Package.UnloadCountAbortedClass UnloadCountAbortedClass => _UnloadCountAbortedClass ?? (_UnloadCountAbortedClass = new Package.UnloadCountAbortedClass());

	private Package.CycleCountRemainingClass _CycleCountRemainingClass;
	/// <summary>
	/// <inheritdoc cref="Package.CycleCountRemainingClass" path="/summary" />
	/// </summary>
	public Package.CycleCountRemainingClass CycleCountRemainingClass => _CycleCountRemainingClass ?? (_CycleCountRemainingClass = new Package.CycleCountRemainingClass());

	private Package.DeactivationCountBadClass _DeactivationCountBadClass;
	/// <summary>
	/// <inheritdoc cref="Package.DeactivationCountBadClass" path="/summary" />
	/// </summary>
	public Package.DeactivationCountBadClass DeactivationCountBadClass => _DeactivationCountBadClass ?? (_DeactivationCountBadClass = new Package.DeactivationCountBadClass());

	private Package.TransferCountAbortedClass _TransferCountAbortedClass;
	/// <summary>
	/// <inheritdoc cref="Package.TransferCountAbortedClass" path="/summary" />
	/// </summary>
	public Package.TransferCountAbortedClass TransferCountAbortedClass => _TransferCountAbortedClass ?? (_TransferCountAbortedClass = new Package.TransferCountAbortedClass());

	private Package.DeactivationCountClass _DeactivationCountClass;
	/// <summary>
	/// <inheritdoc cref="Package.DeactivationCountClass" path="/summary" />
	/// </summary>
	public Package.DeactivationCountClass DeactivationCountClass => _DeactivationCountClass ?? (_DeactivationCountClass = new Package.DeactivationCountClass());

	private Package.ActivationCountBadClass _ActivationCountBadClass;
	/// <summary>
	/// <inheritdoc cref="Package.ActivationCountBadClass" path="/summary" />
	/// </summary>
	public Package.ActivationCountBadClass ActivationCountBadClass => _ActivationCountBadClass ?? (_ActivationCountBadClass = new Package.ActivationCountBadClass());

	private Package.UnloadCountBadClass _UnloadCountBadClass;
	/// <summary>
	/// <inheritdoc cref="Package.UnloadCountBadClass" path="/summary" />
	/// </summary>
	public Package.UnloadCountBadClass UnloadCountBadClass => _UnloadCountBadClass ?? (_UnloadCountBadClass = new Package.UnloadCountBadClass());

	private Package.CycleCountCompleteClass _CycleCountCompleteClass;
	/// <summary>
	/// <inheritdoc cref="Package.CycleCountCompleteClass" path="/summary" />
	/// </summary>
	public Package.CycleCountCompleteClass CycleCountCompleteClass => _CycleCountCompleteClass ?? (_CycleCountCompleteClass = new Package.CycleCountCompleteClass());

	private Package.TransferCountClass _TransferCountClass;
	/// <summary>
	/// <inheritdoc cref="Package.TransferCountClass" path="/summary" />
	/// </summary>
	public Package.TransferCountClass TransferCountClass => _TransferCountClass ?? (_TransferCountClass = new Package.TransferCountClass());

	private Package.LoadCountBadClass _LoadCountBadClass;
	/// <summary>
	/// <inheritdoc cref="Package.LoadCountBadClass" path="/summary" />
	/// </summary>
	public Package.LoadCountBadClass LoadCountBadClass => _LoadCountBadClass ?? (_LoadCountBadClass = new Package.LoadCountBadClass());

	private Package.CycleCountAbortedClass _CycleCountAbortedClass;
	/// <summary>
	/// <inheritdoc cref="Package.CycleCountAbortedClass" path="/summary" />
	/// </summary>
	public Package.CycleCountAbortedClass CycleCountAbortedClass => _CycleCountAbortedClass ?? (_CycleCountAbortedClass = new Package.CycleCountAbortedClass());

	private Package.LoadCountClass _LoadCountClass;
	/// <summary>
	/// <inheritdoc cref="Package.LoadCountClass" path="/summary" />
	/// </summary>
	public Package.LoadCountClass LoadCountClass => _LoadCountClass ?? (_LoadCountClass = new Package.LoadCountClass());

	private Package.TransferCountFailedClass _TransferCountFailedClass;
	/// <summary>
	/// <inheritdoc cref="Package.TransferCountFailedClass" path="/summary" />
	/// </summary>
	public Package.TransferCountFailedClass TransferCountFailedClass => _TransferCountFailedClass ?? (_TransferCountFailedClass = new Package.TransferCountFailedClass());

	private Package.DeactivationCountFailedClass _DeactivationCountFailedClass;
	/// <summary>
	/// <inheritdoc cref="Package.DeactivationCountFailedClass" path="/summary" />
	/// </summary>
	public Package.DeactivationCountFailedClass DeactivationCountFailedClass => _DeactivationCountFailedClass ?? (_DeactivationCountFailedClass = new Package.DeactivationCountFailedClass());

	private Package.LoadCountFailedClass _LoadCountFailedClass;
	/// <summary>
	/// <inheritdoc cref="Package.LoadCountFailedClass" path="/summary" />
	/// </summary>
	public Package.LoadCountFailedClass LoadCountFailedClass => _LoadCountFailedClass ?? (_LoadCountFailedClass = new Package.LoadCountFailedClass());

	private Package.PartProcessingStateClass _PartProcessingStateClass;
	/// <summary>
	/// <inheritdoc cref="Package.PartProcessingStateClass" path="/summary" />
	/// </summary>
	public Package.PartProcessingStateClass PartProcessingStateClass => _PartProcessingStateClass ?? (_PartProcessingStateClass = new Package.PartProcessingStateClass());

	private Package.ActivationCountRemainingClass _ActivationCountRemainingClass;
	/// <summary>
	/// <inheritdoc cref="Package.ActivationCountRemainingClass" path="/summary" />
	/// </summary>
	public Package.ActivationCountRemainingClass ActivationCountRemainingClass => _ActivationCountRemainingClass ?? (_ActivationCountRemainingClass = new Package.ActivationCountRemainingClass());

	private Package.TransferCountAllClass _TransferCountAllClass;
	/// <summary>
	/// <inheritdoc cref="Package.TransferCountAllClass" path="/summary" />
	/// </summary>
	public Package.TransferCountAllClass TransferCountAllClass => _TransferCountAllClass ?? (_TransferCountAllClass = new Package.TransferCountAllClass());

	private Package.UnloadCountFailedClass _UnloadCountFailedClass;
	/// <summary>
	/// <inheritdoc cref="Package.UnloadCountFailedClass" path="/summary" />
	/// </summary>
	public Package.UnloadCountFailedClass UnloadCountFailedClass => _UnloadCountFailedClass ?? (_UnloadCountFailedClass = new Package.UnloadCountFailedClass());

	private Package.ProcessStateClass _ProcessStateClass;
	/// <summary>
	/// <inheritdoc cref="Package.ProcessStateClass" path="/summary" />
	/// </summary>
	public Package.ProcessStateClass ProcessStateClass => _ProcessStateClass ?? (_ProcessStateClass = new Package.ProcessStateClass());

	private Package.ActivationCountAbortedClass _ActivationCountAbortedClass;
	/// <summary>
	/// <inheritdoc cref="Package.ActivationCountAbortedClass" path="/summary" />
	/// </summary>
	public Package.ActivationCountAbortedClass ActivationCountAbortedClass => _ActivationCountAbortedClass ?? (_ActivationCountAbortedClass = new Package.ActivationCountAbortedClass());

	private Package.PartCountCompleteClass _PartCountCompleteClass;
	/// <summary>
	/// <inheritdoc cref="Package.PartCountCompleteClass" path="/summary" />
	/// </summary>
	public Package.PartCountCompleteClass PartCountCompleteClass => _PartCountCompleteClass ?? (_PartCountCompleteClass = new Package.PartCountCompleteClass());

	private Package.DeactivationCountTargetClass _DeactivationCountTargetClass;
	/// <summary>
	/// <inheritdoc cref="Package.DeactivationCountTargetClass" path="/summary" />
	/// </summary>
	public Package.DeactivationCountTargetClass DeactivationCountTargetClass => _DeactivationCountTargetClass ?? (_DeactivationCountTargetClass = new Package.DeactivationCountTargetClass());

	private Package.TransferCountBadClass _TransferCountBadClass;
	/// <summary>
	/// <inheritdoc cref="Package.TransferCountBadClass" path="/summary" />
	/// </summary>
	public Package.TransferCountBadClass TransferCountBadClass => _TransferCountBadClass ?? (_TransferCountBadClass = new Package.TransferCountBadClass());

	private Package.ActivationCountFailedClass _ActivationCountFailedClass;
	/// <summary>
	/// <inheritdoc cref="Package.ActivationCountFailedClass" path="/summary" />
	/// </summary>
	public Package.ActivationCountFailedClass ActivationCountFailedClass => _ActivationCountFailedClass ?? (_ActivationCountFailedClass = new Package.ActivationCountFailedClass());

	private Package.TransferCountRemainingClass _TransferCountRemainingClass;
	/// <summary>
	/// <inheritdoc cref="Package.TransferCountRemainingClass" path="/summary" />
	/// </summary>
	public Package.TransferCountRemainingClass TransferCountRemainingClass => _TransferCountRemainingClass ?? (_TransferCountRemainingClass = new Package.TransferCountRemainingClass());

	private Package.DeactivationCountCompleteClass _DeactivationCountCompleteClass;
	/// <summary>
	/// <inheritdoc cref="Package.DeactivationCountCompleteClass" path="/summary" />
	/// </summary>
	public Package.DeactivationCountCompleteClass DeactivationCountCompleteClass => _DeactivationCountCompleteClass ?? (_DeactivationCountCompleteClass = new Package.DeactivationCountCompleteClass());

	private Package.LoadCountAbortedClass _LoadCountAbortedClass;
	/// <summary>
	/// <inheritdoc cref="Package.LoadCountAbortedClass" path="/summary" />
	/// </summary>
	public Package.LoadCountAbortedClass LoadCountAbortedClass => _LoadCountAbortedClass ?? (_LoadCountAbortedClass = new Package.LoadCountAbortedClass());

	private Package.UnloadCountGoodClass _UnloadCountGoodClass;
	/// <summary>
	/// <inheritdoc cref="Package.UnloadCountGoodClass" path="/summary" />
	/// </summary>
	public Package.UnloadCountGoodClass UnloadCountGoodClass => _UnloadCountGoodClass ?? (_UnloadCountGoodClass = new Package.UnloadCountGoodClass());

	private Package.DeactivationCountRemainingClass _DeactivationCountRemainingClass;
	/// <summary>
	/// <inheritdoc cref="Package.DeactivationCountRemainingClass" path="/summary" />
	/// </summary>
	public Package.DeactivationCountRemainingClass DeactivationCountRemainingClass => _DeactivationCountRemainingClass ?? (_DeactivationCountRemainingClass = new Package.DeactivationCountRemainingClass());

	private Package.CycleCountBadClass _CycleCountBadClass;
	/// <summary>
	/// <inheritdoc cref="Package.CycleCountBadClass" path="/summary" />
	/// </summary>
	public Package.CycleCountBadClass CycleCountBadClass => _CycleCountBadClass ?? (_CycleCountBadClass = new Package.CycleCountBadClass());

	private Package.TransferCountCompleteClass _TransferCountCompleteClass;
	/// <summary>
	/// <inheritdoc cref="Package.TransferCountCompleteClass" path="/summary" />
	/// </summary>
	public Package.TransferCountCompleteClass TransferCountCompleteClass => _TransferCountCompleteClass ?? (_TransferCountCompleteClass = new Package.TransferCountCompleteClass());

	private Package.UnloadCountCompleteClass _UnloadCountCompleteClass;
	/// <summary>
	/// <inheritdoc cref="Package.UnloadCountCompleteClass" path="/summary" />
	/// </summary>
	public Package.UnloadCountCompleteClass UnloadCountCompleteClass => _UnloadCountCompleteClass ?? (_UnloadCountCompleteClass = new Package.UnloadCountCompleteClass());

	private Package.UnloadCountAllClass _UnloadCountAllClass;
	/// <summary>
	/// <inheritdoc cref="Package.UnloadCountAllClass" path="/summary" />
	/// </summary>
	public Package.UnloadCountAllClass UnloadCountAllClass => _UnloadCountAllClass ?? (_UnloadCountAllClass = new Package.UnloadCountAllClass());

	private Package.ValveStateClass _ValveStateClass;
	/// <summary>
	/// <inheritdoc cref="Package.ValveStateClass" path="/summary" />
	/// </summary>
	public Package.ValveStateClass ValveStateClass => _ValveStateClass ?? (_ValveStateClass = new Package.ValveStateClass());

	private Package.CycleCountFailedClass _CycleCountFailedClass;
	/// <summary>
	/// <inheritdoc cref="Package.CycleCountFailedClass" path="/summary" />
	/// </summary>
	public Package.CycleCountFailedClass CycleCountFailedClass => _CycleCountFailedClass ?? (_CycleCountFailedClass = new Package.CycleCountFailedClass());

	private Package.LoadCountAllClass _LoadCountAllClass;
	/// <summary>
	/// <inheritdoc cref="Package.LoadCountAllClass" path="/summary" />
	/// </summary>
	public Package.LoadCountAllClass LoadCountAllClass => _LoadCountAllClass ?? (_LoadCountAllClass = new Package.LoadCountAllClass());

	private Package.UnloadCountTargetClass _UnloadCountTargetClass;
	/// <summary>
	/// <inheritdoc cref="Package.UnloadCountTargetClass" path="/summary" />
	/// </summary>
	public Package.UnloadCountTargetClass UnloadCountTargetClass => _UnloadCountTargetClass ?? (_UnloadCountTargetClass = new Package.UnloadCountTargetClass());

	private Package.ValveStateActualClass _ValveStateActualClass;
	/// <summary>
	/// <inheritdoc cref="Package.ValveStateActualClass" path="/summary" />
	/// </summary>
	public Package.ValveStateActualClass ValveStateActualClass => _ValveStateActualClass ?? (_ValveStateActualClass = new Package.ValveStateActualClass());

	private Package.TransferCountTargetClass _TransferCountTargetClass;
	/// <summary>
	/// <inheritdoc cref="Package.TransferCountTargetClass" path="/summary" />
	/// </summary>
	public Package.TransferCountTargetClass TransferCountTargetClass => _TransferCountTargetClass ?? (_TransferCountTargetClass = new Package.TransferCountTargetClass());

	private Package.CycleCountTargetClass _CycleCountTargetClass;
	/// <summary>
	/// <inheritdoc cref="Package.CycleCountTargetClass" path="/summary" />
	/// </summary>
	public Package.CycleCountTargetClass CycleCountTargetClass => _CycleCountTargetClass ?? (_CycleCountTargetClass = new Package.CycleCountTargetClass());

	private Package.LockStateClass _LockStateClass;
	/// <summary>
	/// <inheritdoc cref="Package.LockStateClass" path="/summary" />
	/// </summary>
	public Package.LockStateClass LockStateClass => _LockStateClass ?? (_LockStateClass = new Package.LockStateClass());

	private Package.UnloadCountClass _UnloadCountClass;
	/// <summary>
	/// <inheritdoc cref="Package.UnloadCountClass" path="/summary" />
	/// </summary>
	public Package.UnloadCountClass UnloadCountClass => _UnloadCountClass ?? (_UnloadCountClass = new Package.UnloadCountClass());

	private Package.PartCountAbortedClass _PartCountAbortedClass;
	/// <summary>
	/// <inheritdoc cref="Package.PartCountAbortedClass" path="/summary" />
	/// </summary>
	public Package.PartCountAbortedClass PartCountAbortedClass => _PartCountAbortedClass ?? (_PartCountAbortedClass = new Package.PartCountAbortedClass());

	private Package.ActivationCountCompleteClass _ActivationCountCompleteClass;
	/// <summary>
	/// <inheritdoc cref="Package.ActivationCountCompleteClass" path="/summary" />
	/// </summary>
	public Package.ActivationCountCompleteClass ActivationCountCompleteClass => _ActivationCountCompleteClass ?? (_ActivationCountCompleteClass = new Package.ActivationCountCompleteClass());

	private Package.PartCountFailedClass _PartCountFailedClass;
	/// <summary>
	/// <inheritdoc cref="Package.PartCountFailedClass" path="/summary" />
	/// </summary>
	public Package.PartCountFailedClass PartCountFailedClass => _PartCountFailedClass ?? (_PartCountFailedClass = new Package.PartCountFailedClass());

	private Package.LoadCountGoodClass _LoadCountGoodClass;
	/// <summary>
	/// <inheritdoc cref="Package.LoadCountGoodClass" path="/summary" />
	/// </summary>
	public Package.LoadCountGoodClass LoadCountGoodClass => _LoadCountGoodClass ?? (_LoadCountGoodClass = new Package.LoadCountGoodClass());

	private Package.CycleCountClass _CycleCountClass;
	/// <summary>
	/// <inheritdoc cref="Package.CycleCountClass" path="/summary" />
	/// </summary>
	public Package.CycleCountClass CycleCountClass => _CycleCountClass ?? (_CycleCountClass = new Package.CycleCountClass());

	private Package.CycleCountAllClass _CycleCountAllClass;
	/// <summary>
	/// <inheritdoc cref="Package.CycleCountAllClass" path="/summary" />
	/// </summary>
	public Package.CycleCountAllClass CycleCountAllClass => _CycleCountAllClass ?? (_CycleCountAllClass = new Package.CycleCountAllClass());

	private Package.LoadCountCompleteClass _LoadCountCompleteClass;
	/// <summary>
	/// <inheritdoc cref="Package.LoadCountCompleteClass" path="/summary" />
	/// </summary>
	public Package.LoadCountCompleteClass LoadCountCompleteClass => _LoadCountCompleteClass ?? (_LoadCountCompleteClass = new Package.LoadCountCompleteClass());

	private Package.ActivationCountAllClass _ActivationCountAllClass;
	/// <summary>
	/// <inheritdoc cref="Package.ActivationCountAllClass" path="/summary" />
	/// </summary>
	public Package.ActivationCountAllClass ActivationCountAllClass => _ActivationCountAllClass ?? (_ActivationCountAllClass = new Package.ActivationCountAllClass());

	private Package.DeactivationCountAllClass _DeactivationCountAllClass;
	/// <summary>
	/// <inheritdoc cref="Package.DeactivationCountAllClass" path="/summary" />
	/// </summary>
	public Package.DeactivationCountAllClass DeactivationCountAllClass => _DeactivationCountAllClass ?? (_DeactivationCountAllClass = new Package.DeactivationCountAllClass());

	private Package.UnloadCountRemainingClass _UnloadCountRemainingClass;
	/// <summary>
	/// <inheritdoc cref="Package.UnloadCountRemainingClass" path="/summary" />
	/// </summary>
	public Package.UnloadCountRemainingClass UnloadCountRemainingClass => _UnloadCountRemainingClass ?? (_UnloadCountRemainingClass = new Package.UnloadCountRemainingClass());

	private Package.DeactivationCountGoodClass _DeactivationCountGoodClass;
	/// <summary>
	/// <inheritdoc cref="Package.DeactivationCountGoodClass" path="/summary" />
	/// </summary>
	public Package.DeactivationCountGoodClass DeactivationCountGoodClass => _DeactivationCountGoodClass ?? (_DeactivationCountGoodClass = new Package.DeactivationCountGoodClass());

	private Package.LoadCountTargetClass _LoadCountTargetClass;
	/// <summary>
	/// <inheritdoc cref="Package.LoadCountTargetClass" path="/summary" />
	/// </summary>
	public Package.LoadCountTargetClass LoadCountTargetClass => _LoadCountTargetClass ?? (_LoadCountTargetClass = new Package.LoadCountTargetClass());

	private Package.ValveStateProgrammedClass _ValveStateProgrammedClass;
	/// <summary>
	/// <inheritdoc cref="Package.ValveStateProgrammedClass" path="/summary" />
	/// </summary>
	public Package.ValveStateProgrammedClass ValveStateProgrammedClass => _ValveStateProgrammedClass ?? (_ValveStateProgrammedClass = new Package.ValveStateProgrammedClass());

	private Package.DeactivationCountAbortedClass _DeactivationCountAbortedClass;
	/// <summary>
	/// <inheritdoc cref="Package.DeactivationCountAbortedClass" path="/summary" />
	/// </summary>
	public Package.DeactivationCountAbortedClass DeactivationCountAbortedClass => _DeactivationCountAbortedClass ?? (_DeactivationCountAbortedClass = new Package.DeactivationCountAbortedClass());

	private Package.OperatingModeClass _OperatingModeClass;
	/// <summary>
	/// <inheritdoc cref="Package.OperatingModeClass" path="/summary" />
	/// </summary>
	public Package.OperatingModeClass OperatingModeClass => _OperatingModeClass ?? (_OperatingModeClass = new Package.OperatingModeClass());

	private Package.AssetCountClass _AssetCountClass;
	/// <summary>
	/// <inheritdoc cref="Package.AssetCountClass" path="/summary" />
	/// </summary>
	public Package.AssetCountClass AssetCountClass => _AssetCountClass ?? (_AssetCountClass = new Package.AssetCountClass());

	private Package.MaintenanceListClass _MaintenanceListClass;
	/// <summary>
	/// <inheritdoc cref="Package.MaintenanceListClass" path="/summary" />
	/// </summary>
	public Package.MaintenanceListClass MaintenanceListClass => _MaintenanceListClass ?? (_MaintenanceListClass = new Package.MaintenanceListClass());

	private Package.FixtureIdClass _FixtureIdClass;
	/// <summary>
	/// <inheritdoc cref="Package.FixtureIdClass" path="/summary" />
	/// </summary>
	public Package.FixtureIdClass FixtureIdClass => _FixtureIdClass ?? (_FixtureIdClass = new Package.FixtureIdClass());

	private Package.PartCountTypeClass _PartCountTypeClass;
	/// <summary>
	/// <inheritdoc cref="Package.PartCountTypeClass" path="/summary" />
	/// </summary>
	public Package.PartCountTypeClass PartCountTypeClass => _PartCountTypeClass ?? (_PartCountTypeClass = new Package.PartCountTypeClass());

	private Package.ProgramActivityClass _ProgramActivityClass;
	/// <summary>
	/// <inheritdoc cref="Package.ProgramActivityClass" path="/summary" />
	/// </summary>
	public Package.ProgramActivityClass ProgramActivityClass => _ProgramActivityClass ?? (_ProgramActivityClass = new Package.ProgramActivityClass());

	private Package.ProgramSegmentClass _ProgramSegmentClass;
	/// <summary>
	/// <inheritdoc cref="Package.ProgramSegmentClass" path="/summary" />
	/// </summary>
	public Package.ProgramSegmentClass ProgramSegmentClass => _ProgramSegmentClass ?? (_ProgramSegmentClass = new Package.ProgramSegmentClass());

	private Package.ProgramRecipeClass _ProgramRecipeClass;
	/// <summary>
	/// <inheritdoc cref="Package.ProgramRecipeClass" path="/summary" />
	/// </summary>
	public Package.ProgramRecipeClass ProgramRecipeClass => _ProgramRecipeClass ?? (_ProgramRecipeClass = new Package.ProgramRecipeClass());

	private Package.ProgramOperationClass _ProgramOperationClass;
	/// <summary>
	/// <inheritdoc cref="Package.ProgramOperationClass" path="/summary" />
	/// </summary>
	public Package.ProgramOperationClass ProgramOperationClass => _ProgramOperationClass ?? (_ProgramOperationClass = new Package.ProgramOperationClass());

	private Package.ProcessOccurrenceIdActivityClass _ProcessOccurrenceIdActivityClass;
	/// <summary>
	/// <inheritdoc cref="Package.ProcessOccurrenceIdActivityClass" path="/summary" />
	/// </summary>
	public Package.ProcessOccurrenceIdActivityClass ProcessOccurrenceIdActivityClass => _ProcessOccurrenceIdActivityClass ?? (_ProcessOccurrenceIdActivityClass = new Package.ProcessOccurrenceIdActivityClass());

	private Package.ProcessOccurrenceIdSegmentClass _ProcessOccurrenceIdSegmentClass;
	/// <summary>
	/// <inheritdoc cref="Package.ProcessOccurrenceIdSegmentClass" path="/summary" />
	/// </summary>
	public Package.ProcessOccurrenceIdSegmentClass ProcessOccurrenceIdSegmentClass => _ProcessOccurrenceIdSegmentClass ?? (_ProcessOccurrenceIdSegmentClass = new Package.ProcessOccurrenceIdSegmentClass());

	private Package.ProcessOccurrenceIdRecipeClass _ProcessOccurrenceIdRecipeClass;
	/// <summary>
	/// <inheritdoc cref="Package.ProcessOccurrenceIdRecipeClass" path="/summary" />
	/// </summary>
	public Package.ProcessOccurrenceIdRecipeClass ProcessOccurrenceIdRecipeClass => _ProcessOccurrenceIdRecipeClass ?? (_ProcessOccurrenceIdRecipeClass = new Package.ProcessOccurrenceIdRecipeClass());

	private Package.ProcessOccurrenceIdOperationClass _ProcessOccurrenceIdOperationClass;
	/// <summary>
	/// <inheritdoc cref="Package.ProcessOccurrenceIdOperationClass" path="/summary" />
	/// </summary>
	public Package.ProcessOccurrenceIdOperationClass ProcessOccurrenceIdOperationClass => _ProcessOccurrenceIdOperationClass ?? (_ProcessOccurrenceIdOperationClass = new Package.ProcessOccurrenceIdOperationClass());

	private Package.ProgramActiveClass _ProgramActiveClass;
	/// <summary>
	/// <inheritdoc cref="Package.ProgramActiveClass" path="/summary" />
	/// </summary>
	public Package.ProgramActiveClass ProgramActiveClass => _ProgramActiveClass ?? (_ProgramActiveClass = new Package.ProgramActiveClass());

	private Package.ProgramMainClass _ProgramMainClass;
	/// <summary>
	/// <inheritdoc cref="Package.ProgramMainClass" path="/summary" />
	/// </summary>
	public Package.ProgramMainClass ProgramMainClass => _ProgramMainClass ?? (_ProgramMainClass = new Package.ProgramMainClass());

	private Package.ProgramScheduleClass _ProgramScheduleClass;
	/// <summary>
	/// <inheritdoc cref="Package.ProgramScheduleClass" path="/summary" />
	/// </summary>
	public Package.ProgramScheduleClass ProgramScheduleClass => _ProgramScheduleClass ?? (_ProgramScheduleClass = new Package.ProgramScheduleClass());

	private Package.ClockTimeClass _ClockTimeClass;
	/// <summary>
	/// <inheritdoc cref="Package.ClockTimeClass" path="/summary" />
	/// </summary>
	public Package.ClockTimeClass ClockTimeClass => _ClockTimeClass ?? (_ClockTimeClass = new Package.ClockTimeClass());

	private Package.ProgramCommentMainClass _ProgramCommentMainClass;
	/// <summary>
	/// <inheritdoc cref="Package.ProgramCommentMainClass" path="/summary" />
	/// </summary>
	public Package.ProgramCommentMainClass ProgramCommentMainClass => _ProgramCommentMainClass ?? (_ProgramCommentMainClass = new Package.ProgramCommentMainClass());

	private Package.ProgramCommentScheduleClass _ProgramCommentScheduleClass;
	/// <summary>
	/// <inheritdoc cref="Package.ProgramCommentScheduleClass" path="/summary" />
	/// </summary>
	public Package.ProgramCommentScheduleClass ProgramCommentScheduleClass => _ProgramCommentScheduleClass ?? (_ProgramCommentScheduleClass = new Package.ProgramCommentScheduleClass());

	private Package.ProgramCommentActiveClass _ProgramCommentActiveClass;
	/// <summary>
	/// <inheritdoc cref="Package.ProgramCommentActiveClass" path="/summary" />
	/// </summary>
	public Package.ProgramCommentActiveClass ProgramCommentActiveClass => _ProgramCommentActiveClass ?? (_ProgramCommentActiveClass = new Package.ProgramCommentActiveClass());

	private Package.NetworkPortClass _NetworkPortClass;
	/// <summary>
	/// <inheritdoc cref="Package.NetworkPortClass" path="/summary" />
	/// </summary>
	public Package.NetworkPortClass NetworkPortClass => _NetworkPortClass ?? (_NetworkPortClass = new Package.NetworkPortClass());

	private Package.HostNameClass _HostNameClass;
	/// <summary>
	/// <inheritdoc cref="Package.HostNameClass" path="/summary" />
	/// </summary>
	public Package.HostNameClass HostNameClass => _HostNameClass ?? (_HostNameClass = new Package.HostNameClass());

	private Package.LeakDetectClass _LeakDetectClass;
	/// <summary>
	/// <inheritdoc cref="Package.LeakDetectClass" path="/summary" />
	/// </summary>
	public Package.LeakDetectClass LeakDetectClass => _LeakDetectClass ?? (_LeakDetectClass = new Package.LeakDetectClass());

	private Package.BatteryStateClass _BatteryStateClass;
	/// <summary>
	/// <inheritdoc cref="Package.BatteryStateClass" path="/summary" />
	/// </summary>
	public Package.BatteryStateClass BatteryStateClass => _BatteryStateClass ?? (_BatteryStateClass = new Package.BatteryStateClass());

	private Package.FeaturePersisitentIdClass _FeaturePersisitentIdClass;
	/// <summary>
	/// <inheritdoc cref="Package.FeaturePersisitentIdClass" path="/summary" />
	/// </summary>
	public Package.FeaturePersisitentIdClass FeaturePersisitentIdClass => _FeaturePersisitentIdClass ?? (_FeaturePersisitentIdClass = new Package.FeaturePersisitentIdClass());

	private Package.SensorStateClass _SensorStateClass;
	/// <summary>
	/// <inheritdoc cref="Package.SensorStateClass" path="/summary" />
	/// </summary>
	public Package.SensorStateClass SensorStateClass => _SensorStateClass ?? (_SensorStateClass = new Package.SensorStateClass());

	private Package.SensorStateBinaryClass _SensorStateBinaryClass;
	/// <summary>
	/// <inheritdoc cref="Package.SensorStateBinaryClass" path="/summary" />
	/// </summary>
	public Package.SensorStateBinaryClass SensorStateBinaryClass => _SensorStateBinaryClass ?? (_SensorStateBinaryClass = new Package.SensorStateBinaryClass());

	private Package.SensorStateBooleanClass _SensorStateBooleanClass;
	/// <summary>
	/// <inheritdoc cref="Package.SensorStateBooleanClass" path="/summary" />
	/// </summary>
	public Package.SensorStateBooleanClass SensorStateBooleanClass => _SensorStateBooleanClass ?? (_SensorStateBooleanClass = new Package.SensorStateBooleanClass());

	private Package.SensorStateEnumeratedClass _SensorStateEnumeratedClass;
	/// <summary>
	/// <inheritdoc cref="Package.SensorStateEnumeratedClass" path="/summary" />
	/// </summary>
	public Package.SensorStateEnumeratedClass SensorStateEnumeratedClass => _SensorStateEnumeratedClass ?? (_SensorStateEnumeratedClass = new Package.SensorStateEnumeratedClass());

	private Package.SensorStateDetectClass _SensorStateDetectClass;
	/// <summary>
	/// <inheritdoc cref="Package.SensorStateDetectClass" path="/summary" />
	/// </summary>
	public Package.SensorStateDetectClass SensorStateDetectClass => _SensorStateDetectClass ?? (_SensorStateDetectClass = new Package.SensorStateDetectClass());

	private Package.ComponentDataClass _ComponentDataClass;
	/// <summary>
	/// <inheritdoc cref="Package.ComponentDataClass" path="/summary" />
	/// </summary>
	public Package.ComponentDataClass ComponentDataClass => _ComponentDataClass ?? (_ComponentDataClass = new Package.ComponentDataClass());

	private Package.WorkOffsetsClass _WorkOffsetsClass;
	/// <summary>
	/// <inheritdoc cref="Package.WorkOffsetsClass" path="/summary" />
	/// </summary>
	public Package.WorkOffsetsClass WorkOffsetsClass => _WorkOffsetsClass ?? (_WorkOffsetsClass = new Package.WorkOffsetsClass());

	private Package.ToolOffsetsClass _ToolOffsetsClass;
	/// <summary>
	/// <inheritdoc cref="Package.ToolOffsetsClass" path="/summary" />
	/// </summary>
	public Package.ToolOffsetsClass ToolOffsetsClass => _ToolOffsetsClass ?? (_ToolOffsetsClass = new Package.ToolOffsetsClass());

	private Package.FeatureMeasurementClass _FeatureMeasurementClass;
	/// <summary>
	/// <inheritdoc cref="Package.FeatureMeasurementClass" path="/summary" />
	/// </summary>
	public Package.FeatureMeasurementClass FeatureMeasurementClass => _FeatureMeasurementClass ?? (_FeatureMeasurementClass = new Package.FeatureMeasurementClass());

	private Package.CharacteristicPersistentIdClass _CharacteristicPersistentIdClass;
	/// <summary>
	/// <inheritdoc cref="Package.CharacteristicPersistentIdClass" path="/summary" />
	/// </summary>
	public Package.CharacteristicPersistentIdClass CharacteristicPersistentIdClass => _CharacteristicPersistentIdClass ?? (_CharacteristicPersistentIdClass = new Package.CharacteristicPersistentIdClass());

	private Package.MeasurementTypeClass _MeasurementTypeClass;
	/// <summary>
	/// <inheritdoc cref="Package.MeasurementTypeClass" path="/summary" />
	/// </summary>
	public Package.MeasurementTypeClass MeasurementTypeClass => _MeasurementTypeClass ?? (_MeasurementTypeClass = new Package.MeasurementTypeClass());

	private Package.MeasurementValueClass _MeasurementValueClass;
	/// <summary>
	/// <inheritdoc cref="Package.MeasurementValueClass" path="/summary" />
	/// </summary>
	public Package.MeasurementValueClass MeasurementValueClass => _MeasurementValueClass ?? (_MeasurementValueClass = new Package.MeasurementValueClass());

	private Package.MeasurementUnitsClass _MeasurementUnitsClass;
	/// <summary>
	/// <inheritdoc cref="Package.MeasurementUnitsClass" path="/summary" />
	/// </summary>
	public Package.MeasurementUnitsClass MeasurementUnitsClass => _MeasurementUnitsClass ?? (_MeasurementUnitsClass = new Package.MeasurementUnitsClass());

	private Package.CharacteristicStatusClass _CharacteristicStatusClass;
	/// <summary>
	/// <inheritdoc cref="Package.CharacteristicStatusClass" path="/summary" />
	/// </summary>
	public Package.CharacteristicStatusClass CharacteristicStatusClass => _CharacteristicStatusClass ?? (_CharacteristicStatusClass = new Package.CharacteristicStatusClass());

	private Package.UncertaintyTypeClass _UncertaintyTypeClass;
	/// <summary>
	/// <inheritdoc cref="Package.UncertaintyTypeClass" path="/summary" />
	/// </summary>
	public Package.UncertaintyTypeClass UncertaintyTypeClass => _UncertaintyTypeClass ?? (_UncertaintyTypeClass = new Package.UncertaintyTypeClass());

	private Package.UncertaintyClass _UncertaintyClass;
	/// <summary>
	/// <inheritdoc cref="Package.UncertaintyClass" path="/summary" />
	/// </summary>
	public Package.UncertaintyClass UncertaintyClass => _UncertaintyClass ?? (_UncertaintyClass = new Package.UncertaintyClass());

	private Package.AlarmLimitsClass _AlarmLimitsClass;
	/// <summary>
	/// <inheritdoc cref="Package.AlarmLimitsClass" path="/summary" />
	/// </summary>
	public Package.AlarmLimitsClass AlarmLimitsClass => _AlarmLimitsClass ?? (_AlarmLimitsClass = new Package.AlarmLimitsClass());

	private Package.ControlLimitsClass _ControlLimitsClass;
	/// <summary>
	/// <inheritdoc cref="Package.ControlLimitsClass" path="/summary" />
	/// </summary>
	public Package.ControlLimitsClass ControlLimitsClass => _ControlLimitsClass ?? (_ControlLimitsClass = new Package.ControlLimitsClass());

	private Package.SpecificationLimitsClass _SpecificationLimitsClass;
	/// <summary>
	/// <inheritdoc cref="Package.SpecificationLimitsClass" path="/summary" />
	/// </summary>
	public Package.SpecificationLimitsClass SpecificationLimitsClass => _SpecificationLimitsClass ?? (_SpecificationLimitsClass = new Package.SpecificationLimitsClass());

	private Package.ToolCuttingItemClass _ToolCuttingItemClass;
	/// <summary>
	/// <inheritdoc cref="Package.ToolCuttingItemClass" path="/summary" />
	/// </summary>
	public Package.ToolCuttingItemClass ToolCuttingItemClass => _ToolCuttingItemClass ?? (_ToolCuttingItemClass = new Package.ToolCuttingItemClass());

	private Package.HardwareModelClass _HardwareModelClass;
	/// <summary>
	/// <inheritdoc cref="Package.HardwareModelClass" path="/summary" />
	/// </summary>
	public Package.HardwareModelClass HardwareModelClass => _HardwareModelClass ?? (_HardwareModelClass = new Package.HardwareModelClass());

	private Package.LocationAddressClass _LocationAddressClass;
	/// <summary>
	/// <inheritdoc cref="Package.LocationAddressClass" path="/summary" />
	/// </summary>
	public Package.LocationAddressClass LocationAddressClass => _LocationAddressClass ?? (_LocationAddressClass = new Package.LocationAddressClass());

	private Package.ActivePowerSourceClass _ActivePowerSourceClass;
	/// <summary>
	/// <inheritdoc cref="Package.ActivePowerSourceClass" path="/summary" />
	/// </summary>
	public Package.ActivePowerSourceClass ActivePowerSourceClass => _ActivePowerSourceClass ?? (_ActivePowerSourceClass = new Package.ActivePowerSourceClass());

	private Package.LocationNarrativeClass _LocationNarrativeClass;
	/// <summary>
	/// <inheritdoc cref="Package.LocationNarrativeClass" path="/summary" />
	/// </summary>
	public Package.LocationNarrativeClass LocationNarrativeClass => _LocationNarrativeClass ?? (_LocationNarrativeClass = new Package.LocationNarrativeClass());

	private Package.ThicknessClass _ThicknessClass;
	/// <summary>
	/// <inheritdoc cref="Package.ThicknessClass" path="/summary" />
	/// </summary>
	public Package.ThicknessClass ThicknessClass => _ThicknessClass ?? (_ThicknessClass = new Package.ThicknessClass());

	private Package.ThicknessActualClass _ThicknessActualClass;
	/// <summary>
	/// <inheritdoc cref="Package.ThicknessActualClass" path="/summary" />
	/// </summary>
	public Package.ThicknessActualClass ThicknessActualClass => _ThicknessActualClass ?? (_ThicknessActualClass = new Package.ThicknessActualClass());

	private Package.ThicknessCommandedClass _ThicknessCommandedClass;
	/// <summary>
	/// <inheritdoc cref="Package.ThicknessCommandedClass" path="/summary" />
	/// </summary>
	public Package.ThicknessCommandedClass ThicknessCommandedClass => _ThicknessCommandedClass ?? (_ThicknessCommandedClass = new Package.ThicknessCommandedClass());

	private Package.ThicknessTargetClass _ThicknessTargetClass;
	/// <summary>
	/// <inheritdoc cref="Package.ThicknessTargetClass" path="/summary" />
	/// </summary>
	public Package.ThicknessTargetClass ThicknessTargetClass => _ThicknessTargetClass ?? (_ThicknessTargetClass = new Package.ThicknessTargetClass());

	private Package.ThicknessProgrammedClass _ThicknessProgrammedClass;
	/// <summary>
	/// <inheritdoc cref="Package.ThicknessProgrammedClass" path="/summary" />
	/// </summary>
	public Package.ThicknessProgrammedClass ThicknessProgrammedClass => _ThicknessProgrammedClass ?? (_ThicknessProgrammedClass = new Package.ThicknessProgrammedClass());

	private Package.LocationSpatialGeographicClass _LocationSpatialGeographicClass;
	/// <summary>
	/// <inheritdoc cref="Package.LocationSpatialGeographicClass" path="/summary" />
	/// </summary>
	public Package.LocationSpatialGeographicClass LocationSpatialGeographicClass => _LocationSpatialGeographicClass ?? (_LocationSpatialGeographicClass = new Package.LocationSpatialGeographicClass());

	private Package.PartIndexClass _PartIndexClass;
	/// <summary>
	/// <inheritdoc cref="Package.PartIndexClass" path="/summary" />
	/// </summary>
	public Package.PartIndexClass PartIndexClass => _PartIndexClass ?? (_PartIndexClass = new Package.PartIndexClass());

	#endregion

	#region Enums
	#endregion
	}
}