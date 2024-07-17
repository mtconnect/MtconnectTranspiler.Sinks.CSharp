using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;
using Package = Mtconnect.ObservationInformationModel.ObservationTypes.EventTypes;
// using Mtconnect;

namespace Mtconnect.ObservationInformationModel.ObservationTypes {
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "1.0.15.3")]
	public class EventTypesPackage : IPackage {
		public IPackage[] Packages => new IPackage[] {
		};

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
			PowerSourceClass,
			PowerSourceStandbyClass,
			PowerSourceSecondaryClass,
			PowerSourcePrimaryClass,
		};

	private Package.ActiveAxesClass _ActiveAxesClass;
	public Package.ActiveAxesClass ActiveAxesClass => _ActiveAxesClass ?? (_ActiveAxesClass = new Package.ActiveAxesClass());
	private Package.ActuatorStateClass _ActuatorStateClass;
	public Package.ActuatorStateClass ActuatorStateClass => _ActuatorStateClass ?? (_ActuatorStateClass = new Package.ActuatorStateClass());
	private Package.AlarmClass _AlarmClass;
	public Package.AlarmClass AlarmClass => _AlarmClass ?? (_AlarmClass = new Package.AlarmClass());
	private Package.AssetChangedClass _AssetChangedClass;
	public Package.AssetChangedClass AssetChangedClass => _AssetChangedClass ?? (_AssetChangedClass = new Package.AssetChangedClass());
	private Package.AssetRemovedClass _AssetRemovedClass;
	public Package.AssetRemovedClass AssetRemovedClass => _AssetRemovedClass ?? (_AssetRemovedClass = new Package.AssetRemovedClass());
	private Package.AvailabilityClass _AvailabilityClass;
	public Package.AvailabilityClass AvailabilityClass => _AvailabilityClass ?? (_AvailabilityClass = new Package.AvailabilityClass());
	private Package.AxisCouplingClass _AxisCouplingClass;
	public Package.AxisCouplingClass AxisCouplingClass => _AxisCouplingClass ?? (_AxisCouplingClass = new Package.AxisCouplingClass());
	private Package.AxisFeedrateOverrideClass _AxisFeedrateOverrideClass;
	public Package.AxisFeedrateOverrideClass AxisFeedrateOverrideClass => _AxisFeedrateOverrideClass ?? (_AxisFeedrateOverrideClass = new Package.AxisFeedrateOverrideClass());
	private Package.AxisFeedrateOverrideJogClass _AxisFeedrateOverrideJogClass;
	public Package.AxisFeedrateOverrideJogClass AxisFeedrateOverrideJogClass => _AxisFeedrateOverrideJogClass ?? (_AxisFeedrateOverrideJogClass = new Package.AxisFeedrateOverrideJogClass());
	private Package.AxisFeedrateOverrideProgrammedClass _AxisFeedrateOverrideProgrammedClass;
	public Package.AxisFeedrateOverrideProgrammedClass AxisFeedrateOverrideProgrammedClass => _AxisFeedrateOverrideProgrammedClass ?? (_AxisFeedrateOverrideProgrammedClass = new Package.AxisFeedrateOverrideProgrammedClass());
	private Package.AxisFeedrateOverrideRapidClass _AxisFeedrateOverrideRapidClass;
	public Package.AxisFeedrateOverrideRapidClass AxisFeedrateOverrideRapidClass => _AxisFeedrateOverrideRapidClass ?? (_AxisFeedrateOverrideRapidClass = new Package.AxisFeedrateOverrideRapidClass());
	private Package.AxisInterlockClass _AxisInterlockClass;
	public Package.AxisInterlockClass AxisInterlockClass => _AxisInterlockClass ?? (_AxisInterlockClass = new Package.AxisInterlockClass());
	private Package.AxisStateClass _AxisStateClass;
	public Package.AxisStateClass AxisStateClass => _AxisStateClass ?? (_AxisStateClass = new Package.AxisStateClass());
	private Package.BlockClass _BlockClass;
	public Package.BlockClass BlockClass => _BlockClass ?? (_BlockClass = new Package.BlockClass());
	private Package.BlockCountClass _BlockCountClass;
	public Package.BlockCountClass BlockCountClass => _BlockCountClass ?? (_BlockCountClass = new Package.BlockCountClass());
	private Package.ChuckInterlockClass _ChuckInterlockClass;
	public Package.ChuckInterlockClass ChuckInterlockClass => _ChuckInterlockClass ?? (_ChuckInterlockClass = new Package.ChuckInterlockClass());
	private Package.ChuckInterlockManualUnclampClass _ChuckInterlockManualUnclampClass;
	public Package.ChuckInterlockManualUnclampClass ChuckInterlockManualUnclampClass => _ChuckInterlockManualUnclampClass ?? (_ChuckInterlockManualUnclampClass = new Package.ChuckInterlockManualUnclampClass());
	private Package.ChuckStateClass _ChuckStateClass;
	public Package.ChuckStateClass ChuckStateClass => _ChuckStateClass ?? (_ChuckStateClass = new Package.ChuckStateClass());
	private Package.CodeClass _CodeClass;
	public Package.CodeClass CodeClass => _CodeClass ?? (_CodeClass = new Package.CodeClass());
	private Package.CompositionStateClass _CompositionStateClass;
	public Package.CompositionStateClass CompositionStateClass => _CompositionStateClass ?? (_CompositionStateClass = new Package.CompositionStateClass());
	private Package.CompositionStateActionClass _CompositionStateActionClass;
	public Package.CompositionStateActionClass CompositionStateActionClass => _CompositionStateActionClass ?? (_CompositionStateActionClass = new Package.CompositionStateActionClass());
	private Package.CompositionStateLateralClass _CompositionStateLateralClass;
	public Package.CompositionStateLateralClass CompositionStateLateralClass => _CompositionStateLateralClass ?? (_CompositionStateLateralClass = new Package.CompositionStateLateralClass());
	private Package.CompositionStateMotionClass _CompositionStateMotionClass;
	public Package.CompositionStateMotionClass CompositionStateMotionClass => _CompositionStateMotionClass ?? (_CompositionStateMotionClass = new Package.CompositionStateMotionClass());
	private Package.CompositionStateSwitchedClass _CompositionStateSwitchedClass;
	public Package.CompositionStateSwitchedClass CompositionStateSwitchedClass => _CompositionStateSwitchedClass ?? (_CompositionStateSwitchedClass = new Package.CompositionStateSwitchedClass());
	private Package.CompositionStateVerticalClass _CompositionStateVerticalClass;
	public Package.CompositionStateVerticalClass CompositionStateVerticalClass => _CompositionStateVerticalClass ?? (_CompositionStateVerticalClass = new Package.CompositionStateVerticalClass());
	private Package.ControllerModeClass _ControllerModeClass;
	public Package.ControllerModeClass ControllerModeClass => _ControllerModeClass ?? (_ControllerModeClass = new Package.ControllerModeClass());
	private Package.ControllerModeOverrideClass _ControllerModeOverrideClass;
	public Package.ControllerModeOverrideClass ControllerModeOverrideClass => _ControllerModeOverrideClass ?? (_ControllerModeOverrideClass = new Package.ControllerModeOverrideClass());
	private Package.ControllerModeOverrideDryRunClass _ControllerModeOverrideDryRunClass;
	public Package.ControllerModeOverrideDryRunClass ControllerModeOverrideDryRunClass => _ControllerModeOverrideDryRunClass ?? (_ControllerModeOverrideDryRunClass = new Package.ControllerModeOverrideDryRunClass());
	private Package.ControllerModeOverrideSingleBlockClass _ControllerModeOverrideSingleBlockClass;
	public Package.ControllerModeOverrideSingleBlockClass ControllerModeOverrideSingleBlockClass => _ControllerModeOverrideSingleBlockClass ?? (_ControllerModeOverrideSingleBlockClass = new Package.ControllerModeOverrideSingleBlockClass());
	private Package.ControllerModeOverrideMachineAxisLockClass _ControllerModeOverrideMachineAxisLockClass;
	public Package.ControllerModeOverrideMachineAxisLockClass ControllerModeOverrideMachineAxisLockClass => _ControllerModeOverrideMachineAxisLockClass ?? (_ControllerModeOverrideMachineAxisLockClass = new Package.ControllerModeOverrideMachineAxisLockClass());
	private Package.ControllerModeOverrideOptionalStopClass _ControllerModeOverrideOptionalStopClass;
	public Package.ControllerModeOverrideOptionalStopClass ControllerModeOverrideOptionalStopClass => _ControllerModeOverrideOptionalStopClass ?? (_ControllerModeOverrideOptionalStopClass = new Package.ControllerModeOverrideOptionalStopClass());
	private Package.ControllerModeOverrideToolChangeStopClass _ControllerModeOverrideToolChangeStopClass;
	public Package.ControllerModeOverrideToolChangeStopClass ControllerModeOverrideToolChangeStopClass => _ControllerModeOverrideToolChangeStopClass ?? (_ControllerModeOverrideToolChangeStopClass = new Package.ControllerModeOverrideToolChangeStopClass());
	private Package.CoupledAxesClass _CoupledAxesClass;
	public Package.CoupledAxesClass CoupledAxesClass => _CoupledAxesClass ?? (_CoupledAxesClass = new Package.CoupledAxesClass());
	private Package.DateCodeClass _DateCodeClass;
	public Package.DateCodeClass DateCodeClass => _DateCodeClass ?? (_DateCodeClass = new Package.DateCodeClass());
	private Package.DateCodeManufactureClass _DateCodeManufactureClass;
	public Package.DateCodeManufactureClass DateCodeManufactureClass => _DateCodeManufactureClass ?? (_DateCodeManufactureClass = new Package.DateCodeManufactureClass());
	private Package.DateCodeExpirationClass _DateCodeExpirationClass;
	public Package.DateCodeExpirationClass DateCodeExpirationClass => _DateCodeExpirationClass ?? (_DateCodeExpirationClass = new Package.DateCodeExpirationClass());
	private Package.DateCodeFirstUseClass _DateCodeFirstUseClass;
	public Package.DateCodeFirstUseClass DateCodeFirstUseClass => _DateCodeFirstUseClass ?? (_DateCodeFirstUseClass = new Package.DateCodeFirstUseClass());
	private Package.DeviceUuidClass _DeviceUuidClass;
	public Package.DeviceUuidClass DeviceUuidClass => _DeviceUuidClass ?? (_DeviceUuidClass = new Package.DeviceUuidClass());
	private Package.DirectionClass _DirectionClass;
	public Package.DirectionClass DirectionClass => _DirectionClass ?? (_DirectionClass = new Package.DirectionClass());
	private Package.DirectionRotaryClass _DirectionRotaryClass;
	public Package.DirectionRotaryClass DirectionRotaryClass => _DirectionRotaryClass ?? (_DirectionRotaryClass = new Package.DirectionRotaryClass());
	private Package.DirectionLinearClass _DirectionLinearClass;
	public Package.DirectionLinearClass DirectionLinearClass => _DirectionLinearClass ?? (_DirectionLinearClass = new Package.DirectionLinearClass());
	private Package.DoorStateClass _DoorStateClass;
	public Package.DoorStateClass DoorStateClass => _DoorStateClass ?? (_DoorStateClass = new Package.DoorStateClass());
	private Package.EmergencyStopClass _EmergencyStopClass;
	public Package.EmergencyStopClass EmergencyStopClass => _EmergencyStopClass ?? (_EmergencyStopClass = new Package.EmergencyStopClass());
	private Package.EndOfBarClass _EndOfBarClass;
	public Package.EndOfBarClass EndOfBarClass => _EndOfBarClass ?? (_EndOfBarClass = new Package.EndOfBarClass());
	private Package.EndOfBarPrimaryClass _EndOfBarPrimaryClass;
	public Package.EndOfBarPrimaryClass EndOfBarPrimaryClass => _EndOfBarPrimaryClass ?? (_EndOfBarPrimaryClass = new Package.EndOfBarPrimaryClass());
	private Package.EndOfBarAuxiliaryClass _EndOfBarAuxiliaryClass;
	public Package.EndOfBarAuxiliaryClass EndOfBarAuxiliaryClass => _EndOfBarAuxiliaryClass ?? (_EndOfBarAuxiliaryClass = new Package.EndOfBarAuxiliaryClass());
	private Package.EquipmentModeClass _EquipmentModeClass;
	public Package.EquipmentModeClass EquipmentModeClass => _EquipmentModeClass ?? (_EquipmentModeClass = new Package.EquipmentModeClass());
	private Package.EquipmentModeLoadedClass _EquipmentModeLoadedClass;
	public Package.EquipmentModeLoadedClass EquipmentModeLoadedClass => _EquipmentModeLoadedClass ?? (_EquipmentModeLoadedClass = new Package.EquipmentModeLoadedClass());
	private Package.EquipmentModeWorkingClass _EquipmentModeWorkingClass;
	public Package.EquipmentModeWorkingClass EquipmentModeWorkingClass => _EquipmentModeWorkingClass ?? (_EquipmentModeWorkingClass = new Package.EquipmentModeWorkingClass());
	private Package.EquipmentModeOperatingClass _EquipmentModeOperatingClass;
	public Package.EquipmentModeOperatingClass EquipmentModeOperatingClass => _EquipmentModeOperatingClass ?? (_EquipmentModeOperatingClass = new Package.EquipmentModeOperatingClass());
	private Package.EquipmentModePoweredClass _EquipmentModePoweredClass;
	public Package.EquipmentModePoweredClass EquipmentModePoweredClass => _EquipmentModePoweredClass ?? (_EquipmentModePoweredClass = new Package.EquipmentModePoweredClass());
	private Package.EquipmentModeDelayClass _EquipmentModeDelayClass;
	public Package.EquipmentModeDelayClass EquipmentModeDelayClass => _EquipmentModeDelayClass ?? (_EquipmentModeDelayClass = new Package.EquipmentModeDelayClass());
	private Package.ExecutionClass _ExecutionClass;
	public Package.ExecutionClass ExecutionClass => _ExecutionClass ?? (_ExecutionClass = new Package.ExecutionClass());
	private Package.FunctionalModeClass _FunctionalModeClass;
	public Package.FunctionalModeClass FunctionalModeClass => _FunctionalModeClass ?? (_FunctionalModeClass = new Package.FunctionalModeClass());
	private Package.HardnessClass _HardnessClass;
	public Package.HardnessClass HardnessClass => _HardnessClass ?? (_HardnessClass = new Package.HardnessClass());
	private Package.HardnessRockwellClass _HardnessRockwellClass;
	public Package.HardnessRockwellClass HardnessRockwellClass => _HardnessRockwellClass ?? (_HardnessRockwellClass = new Package.HardnessRockwellClass());
	private Package.HardnessVickersClass _HardnessVickersClass;
	public Package.HardnessVickersClass HardnessVickersClass => _HardnessVickersClass ?? (_HardnessVickersClass = new Package.HardnessVickersClass());
	private Package.HardnessShoreClass _HardnessShoreClass;
	public Package.HardnessShoreClass HardnessShoreClass => _HardnessShoreClass ?? (_HardnessShoreClass = new Package.HardnessShoreClass());
	private Package.HardnessBrinellClass _HardnessBrinellClass;
	public Package.HardnessBrinellClass HardnessBrinellClass => _HardnessBrinellClass ?? (_HardnessBrinellClass = new Package.HardnessBrinellClass());
	private Package.HardnessLeebClass _HardnessLeebClass;
	public Package.HardnessLeebClass HardnessLeebClass => _HardnessLeebClass ?? (_HardnessLeebClass = new Package.HardnessLeebClass());
	private Package.HardnessMohsClass _HardnessMohsClass;
	public Package.HardnessMohsClass HardnessMohsClass => _HardnessMohsClass ?? (_HardnessMohsClass = new Package.HardnessMohsClass());
	private Package.LineClass _LineClass;
	public Package.LineClass LineClass => _LineClass ?? (_LineClass = new Package.LineClass());
	private Package.LineMaximumClass _LineMaximumClass;
	public Package.LineMaximumClass LineMaximumClass => _LineMaximumClass ?? (_LineMaximumClass = new Package.LineMaximumClass());
	private Package.LineMinimumClass _LineMinimumClass;
	public Package.LineMinimumClass LineMinimumClass => _LineMinimumClass ?? (_LineMinimumClass = new Package.LineMinimumClass());
	private Package.LineLabelClass _LineLabelClass;
	public Package.LineLabelClass LineLabelClass => _LineLabelClass ?? (_LineLabelClass = new Package.LineLabelClass());
	private Package.LineNumberClass _LineNumberClass;
	public Package.LineNumberClass LineNumberClass => _LineNumberClass ?? (_LineNumberClass = new Package.LineNumberClass());
	private Package.LineNumberAbsoluteClass _LineNumberAbsoluteClass;
	public Package.LineNumberAbsoluteClass LineNumberAbsoluteClass => _LineNumberAbsoluteClass ?? (_LineNumberAbsoluteClass = new Package.LineNumberAbsoluteClass());
	private Package.LineNumberIncrementalClass _LineNumberIncrementalClass;
	public Package.LineNumberIncrementalClass LineNumberIncrementalClass => _LineNumberIncrementalClass ?? (_LineNumberIncrementalClass = new Package.LineNumberIncrementalClass());
	private Package.MaterialClass _MaterialClass;
	public Package.MaterialClass MaterialClass => _MaterialClass ?? (_MaterialClass = new Package.MaterialClass());
	private Package.MaterialLayerClass _MaterialLayerClass;
	public Package.MaterialLayerClass MaterialLayerClass => _MaterialLayerClass ?? (_MaterialLayerClass = new Package.MaterialLayerClass());
	private Package.MaterialLayerActualClass _MaterialLayerActualClass;
	public Package.MaterialLayerActualClass MaterialLayerActualClass => _MaterialLayerActualClass ?? (_MaterialLayerActualClass = new Package.MaterialLayerActualClass());
	private Package.MaterialLayerTargetClass _MaterialLayerTargetClass;
	public Package.MaterialLayerTargetClass MaterialLayerTargetClass => _MaterialLayerTargetClass ?? (_MaterialLayerTargetClass = new Package.MaterialLayerTargetClass());
	private Package.MessageClass _MessageClass;
	public Package.MessageClass MessageClass => _MessageClass ?? (_MessageClass = new Package.MessageClass());
	private Package.OperatorIdClass _OperatorIdClass;
	public Package.OperatorIdClass OperatorIdClass => _OperatorIdClass ?? (_OperatorIdClass = new Package.OperatorIdClass());
	private Package.PalletIdClass _PalletIdClass;
	public Package.PalletIdClass PalletIdClass => _PalletIdClass ?? (_PalletIdClass = new Package.PalletIdClass());
	private Package.PartCountClass _PartCountClass;
	public Package.PartCountClass PartCountClass => _PartCountClass ?? (_PartCountClass = new Package.PartCountClass());
	private Package.PartCountAllClass _PartCountAllClass;
	public Package.PartCountAllClass PartCountAllClass => _PartCountAllClass ?? (_PartCountAllClass = new Package.PartCountAllClass());
	private Package.PartCountGoodClass _PartCountGoodClass;
	public Package.PartCountGoodClass PartCountGoodClass => _PartCountGoodClass ?? (_PartCountGoodClass = new Package.PartCountGoodClass());
	private Package.PartCountBadClass _PartCountBadClass;
	public Package.PartCountBadClass PartCountBadClass => _PartCountBadClass ?? (_PartCountBadClass = new Package.PartCountBadClass());
	private Package.PartCountTargetClass _PartCountTargetClass;
	public Package.PartCountTargetClass PartCountTargetClass => _PartCountTargetClass ?? (_PartCountTargetClass = new Package.PartCountTargetClass());
	private Package.PartCountRemainingClass _PartCountRemainingClass;
	public Package.PartCountRemainingClass PartCountRemainingClass => _PartCountRemainingClass ?? (_PartCountRemainingClass = new Package.PartCountRemainingClass());
	private Package.PartDetectClass _PartDetectClass;
	public Package.PartDetectClass PartDetectClass => _PartDetectClass ?? (_PartDetectClass = new Package.PartDetectClass());
	private Package.PartIdClass _PartIdClass;
	public Package.PartIdClass PartIdClass => _PartIdClass ?? (_PartIdClass = new Package.PartIdClass());
	private Package.PartNumberClass _PartNumberClass;
	public Package.PartNumberClass PartNumberClass => _PartNumberClass ?? (_PartNumberClass = new Package.PartNumberClass());
	private Package.PathFeedrateOverrideClass _PathFeedrateOverrideClass;
	public Package.PathFeedrateOverrideClass PathFeedrateOverrideClass => _PathFeedrateOverrideClass ?? (_PathFeedrateOverrideClass = new Package.PathFeedrateOverrideClass());
	private Package.PathFeedrateOverrideJogClass _PathFeedrateOverrideJogClass;
	public Package.PathFeedrateOverrideJogClass PathFeedrateOverrideJogClass => _PathFeedrateOverrideJogClass ?? (_PathFeedrateOverrideJogClass = new Package.PathFeedrateOverrideJogClass());
	private Package.PathFeedrateOverrideProgrammedClass _PathFeedrateOverrideProgrammedClass;
	public Package.PathFeedrateOverrideProgrammedClass PathFeedrateOverrideProgrammedClass => _PathFeedrateOverrideProgrammedClass ?? (_PathFeedrateOverrideProgrammedClass = new Package.PathFeedrateOverrideProgrammedClass());
	private Package.PathFeedrateOverrideRapidClass _PathFeedrateOverrideRapidClass;
	public Package.PathFeedrateOverrideRapidClass PathFeedrateOverrideRapidClass => _PathFeedrateOverrideRapidClass ?? (_PathFeedrateOverrideRapidClass = new Package.PathFeedrateOverrideRapidClass());
	private Package.PathModeClass _PathModeClass;
	public Package.PathModeClass PathModeClass => _PathModeClass ?? (_PathModeClass = new Package.PathModeClass());
	private Package.PowerStateClass _PowerStateClass;
	public Package.PowerStateClass PowerStateClass => _PowerStateClass ?? (_PowerStateClass = new Package.PowerStateClass());
	private Package.PowerStateLineClass _PowerStateLineClass;
	public Package.PowerStateLineClass PowerStateLineClass => _PowerStateLineClass ?? (_PowerStateLineClass = new Package.PowerStateLineClass());
	private Package.PowerStateControlClass _PowerStateControlClass;
	public Package.PowerStateControlClass PowerStateControlClass => _PowerStateControlClass ?? (_PowerStateControlClass = new Package.PowerStateControlClass());
	private Package.PowerStatusClass _PowerStatusClass;
	public Package.PowerStatusClass PowerStatusClass => _PowerStatusClass ?? (_PowerStatusClass = new Package.PowerStatusClass());
	private Package.ProcessTimeClass _ProcessTimeClass;
	public Package.ProcessTimeClass ProcessTimeClass => _ProcessTimeClass ?? (_ProcessTimeClass = new Package.ProcessTimeClass());
	private Package.ProcessTimeStartClass _ProcessTimeStartClass;
	public Package.ProcessTimeStartClass ProcessTimeStartClass => _ProcessTimeStartClass ?? (_ProcessTimeStartClass = new Package.ProcessTimeStartClass());
	private Package.ProcessTimeCompleteClass _ProcessTimeCompleteClass;
	public Package.ProcessTimeCompleteClass ProcessTimeCompleteClass => _ProcessTimeCompleteClass ?? (_ProcessTimeCompleteClass = new Package.ProcessTimeCompleteClass());
	private Package.ProcessTimeTargetCompletionClass _ProcessTimeTargetCompletionClass;
	public Package.ProcessTimeTargetCompletionClass ProcessTimeTargetCompletionClass => _ProcessTimeTargetCompletionClass ?? (_ProcessTimeTargetCompletionClass = new Package.ProcessTimeTargetCompletionClass());
	private Package.ProgramClass _ProgramClass;
	public Package.ProgramClass ProgramClass => _ProgramClass ?? (_ProgramClass = new Package.ProgramClass());
	private Package.ProgramCommentClass _ProgramCommentClass;
	public Package.ProgramCommentClass ProgramCommentClass => _ProgramCommentClass ?? (_ProgramCommentClass = new Package.ProgramCommentClass());
	private Package.ProgramEditClass _ProgramEditClass;
	public Package.ProgramEditClass ProgramEditClass => _ProgramEditClass ?? (_ProgramEditClass = new Package.ProgramEditClass());
	private Package.ProgramEditNameClass _ProgramEditNameClass;
	public Package.ProgramEditNameClass ProgramEditNameClass => _ProgramEditNameClass ?? (_ProgramEditNameClass = new Package.ProgramEditNameClass());
	private Package.ProgramHeaderClass _ProgramHeaderClass;
	public Package.ProgramHeaderClass ProgramHeaderClass => _ProgramHeaderClass ?? (_ProgramHeaderClass = new Package.ProgramHeaderClass());
	private Package.ProgramLocationClass _ProgramLocationClass;
	public Package.ProgramLocationClass ProgramLocationClass => _ProgramLocationClass ?? (_ProgramLocationClass = new Package.ProgramLocationClass());
	private Package.ProgramLocationScheduleClass _ProgramLocationScheduleClass;
	public Package.ProgramLocationScheduleClass ProgramLocationScheduleClass => _ProgramLocationScheduleClass ?? (_ProgramLocationScheduleClass = new Package.ProgramLocationScheduleClass());
	private Package.ProgramLocationMainClass _ProgramLocationMainClass;
	public Package.ProgramLocationMainClass ProgramLocationMainClass => _ProgramLocationMainClass ?? (_ProgramLocationMainClass = new Package.ProgramLocationMainClass());
	private Package.ProgramLocationActiveClass _ProgramLocationActiveClass;
	public Package.ProgramLocationActiveClass ProgramLocationActiveClass => _ProgramLocationActiveClass ?? (_ProgramLocationActiveClass = new Package.ProgramLocationActiveClass());
	private Package.ProgramLocationTypeClass _ProgramLocationTypeClass;
	public Package.ProgramLocationTypeClass ProgramLocationTypeClass => _ProgramLocationTypeClass ?? (_ProgramLocationTypeClass = new Package.ProgramLocationTypeClass());
	private Package.ProgramLocationTypeScheduleClass _ProgramLocationTypeScheduleClass;
	public Package.ProgramLocationTypeScheduleClass ProgramLocationTypeScheduleClass => _ProgramLocationTypeScheduleClass ?? (_ProgramLocationTypeScheduleClass = new Package.ProgramLocationTypeScheduleClass());
	private Package.ProgramLocationTypeMainClass _ProgramLocationTypeMainClass;
	public Package.ProgramLocationTypeMainClass ProgramLocationTypeMainClass => _ProgramLocationTypeMainClass ?? (_ProgramLocationTypeMainClass = new Package.ProgramLocationTypeMainClass());
	private Package.ProgramLocationTypeActiveClass _ProgramLocationTypeActiveClass;
	public Package.ProgramLocationTypeActiveClass ProgramLocationTypeActiveClass => _ProgramLocationTypeActiveClass ?? (_ProgramLocationTypeActiveClass = new Package.ProgramLocationTypeActiveClass());
	private Package.ProgramNestLevelClass _ProgramNestLevelClass;
	public Package.ProgramNestLevelClass ProgramNestLevelClass => _ProgramNestLevelClass ?? (_ProgramNestLevelClass = new Package.ProgramNestLevelClass());
	private Package.RotaryModeClass _RotaryModeClass;
	public Package.RotaryModeClass RotaryModeClass => _RotaryModeClass ?? (_RotaryModeClass = new Package.RotaryModeClass());
	private Package.RotaryVelocityOverrideClass _RotaryVelocityOverrideClass;
	public Package.RotaryVelocityOverrideClass RotaryVelocityOverrideClass => _RotaryVelocityOverrideClass ?? (_RotaryVelocityOverrideClass = new Package.RotaryVelocityOverrideClass());
	private Package.SerialNumberClass _SerialNumberClass;
	public Package.SerialNumberClass SerialNumberClass => _SerialNumberClass ?? (_SerialNumberClass = new Package.SerialNumberClass());
	private Package.SpindleInterlockClass _SpindleInterlockClass;
	public Package.SpindleInterlockClass SpindleInterlockClass => _SpindleInterlockClass ?? (_SpindleInterlockClass = new Package.SpindleInterlockClass());
	private Package.ToolAssetIdClass _ToolAssetIdClass;
	public Package.ToolAssetIdClass ToolAssetIdClass => _ToolAssetIdClass ?? (_ToolAssetIdClass = new Package.ToolAssetIdClass());
	private Package.ToolGroupClass _ToolGroupClass;
	public Package.ToolGroupClass ToolGroupClass => _ToolGroupClass ?? (_ToolGroupClass = new Package.ToolGroupClass());
	private Package.ToolIdClass _ToolIdClass;
	public Package.ToolIdClass ToolIdClass => _ToolIdClass ?? (_ToolIdClass = new Package.ToolIdClass());
	private Package.ToolNumberClass _ToolNumberClass;
	public Package.ToolNumberClass ToolNumberClass => _ToolNumberClass ?? (_ToolNumberClass = new Package.ToolNumberClass());
	private Package.ToolOffsetClass _ToolOffsetClass;
	public Package.ToolOffsetClass ToolOffsetClass => _ToolOffsetClass ?? (_ToolOffsetClass = new Package.ToolOffsetClass());
	private Package.ToolOffsetRadialClass _ToolOffsetRadialClass;
	public Package.ToolOffsetRadialClass ToolOffsetRadialClass => _ToolOffsetRadialClass ?? (_ToolOffsetRadialClass = new Package.ToolOffsetRadialClass());
	private Package.ToolOffsetLengthClass _ToolOffsetLengthClass;
	public Package.ToolOffsetLengthClass ToolOffsetLengthClass => _ToolOffsetLengthClass ?? (_ToolOffsetLengthClass = new Package.ToolOffsetLengthClass());
	private Package.UserClass _UserClass;
	public Package.UserClass UserClass => _UserClass ?? (_UserClass = new Package.UserClass());
	private Package.UserOperatorClass _UserOperatorClass;
	public Package.UserOperatorClass UserOperatorClass => _UserOperatorClass ?? (_UserOperatorClass = new Package.UserOperatorClass());
	private Package.UserMaintenanceClass _UserMaintenanceClass;
	public Package.UserMaintenanceClass UserMaintenanceClass => _UserMaintenanceClass ?? (_UserMaintenanceClass = new Package.UserMaintenanceClass());
	private Package.UserSetUpClass _UserSetUpClass;
	public Package.UserSetUpClass UserSetUpClass => _UserSetUpClass ?? (_UserSetUpClass = new Package.UserSetUpClass());
	private Package.VariableClass _VariableClass;
	public Package.VariableClass VariableClass => _VariableClass ?? (_VariableClass = new Package.VariableClass());
	private Package.WaitStateClass _WaitStateClass;
	public Package.WaitStateClass WaitStateClass => _WaitStateClass ?? (_WaitStateClass = new Package.WaitStateClass());
	private Package.WireClass _WireClass;
	public Package.WireClass WireClass => _WireClass ?? (_WireClass = new Package.WireClass());
	private Package.WorkholdingIdClass _WorkholdingIdClass;
	public Package.WorkholdingIdClass WorkholdingIdClass => _WorkholdingIdClass ?? (_WorkholdingIdClass = new Package.WorkholdingIdClass());
	private Package.WorkOffsetClass _WorkOffsetClass;
	public Package.WorkOffsetClass WorkOffsetClass => _WorkOffsetClass ?? (_WorkOffsetClass = new Package.WorkOffsetClass());
	private Package.ProgramHeaderMainClass _ProgramHeaderMainClass;
	public Package.ProgramHeaderMainClass ProgramHeaderMainClass => _ProgramHeaderMainClass ?? (_ProgramHeaderMainClass = new Package.ProgramHeaderMainClass());
	private Package.ProgramHeaderScheduleClass _ProgramHeaderScheduleClass;
	public Package.ProgramHeaderScheduleClass ProgramHeaderScheduleClass => _ProgramHeaderScheduleClass ?? (_ProgramHeaderScheduleClass = new Package.ProgramHeaderScheduleClass());
	private Package.ProgramHeaderActiveClass _ProgramHeaderActiveClass;
	public Package.ProgramHeaderActiveClass ProgramHeaderActiveClass => _ProgramHeaderActiveClass ?? (_ProgramHeaderActiveClass = new Package.ProgramHeaderActiveClass());
	private Package.OperatingSystemClass _OperatingSystemClass;
	public Package.OperatingSystemClass OperatingSystemClass => _OperatingSystemClass ?? (_OperatingSystemClass = new Package.OperatingSystemClass());
	private Package.OperatingSystemLicenseClass _OperatingSystemLicenseClass;
	public Package.OperatingSystemLicenseClass OperatingSystemLicenseClass => _OperatingSystemLicenseClass ?? (_OperatingSystemLicenseClass = new Package.OperatingSystemLicenseClass());
	private Package.OperatingSystemVersionClass _OperatingSystemVersionClass;
	public Package.OperatingSystemVersionClass OperatingSystemVersionClass => _OperatingSystemVersionClass ?? (_OperatingSystemVersionClass = new Package.OperatingSystemVersionClass());
	private Package.OperatingSystemReleaseDateClass _OperatingSystemReleaseDateClass;
	public Package.OperatingSystemReleaseDateClass OperatingSystemReleaseDateClass => _OperatingSystemReleaseDateClass ?? (_OperatingSystemReleaseDateClass = new Package.OperatingSystemReleaseDateClass());
	private Package.OperatingSystemInstallDateClass _OperatingSystemInstallDateClass;
	public Package.OperatingSystemInstallDateClass OperatingSystemInstallDateClass => _OperatingSystemInstallDateClass ?? (_OperatingSystemInstallDateClass = new Package.OperatingSystemInstallDateClass());
	private Package.OperatingSystemManufacturerClass _OperatingSystemManufacturerClass;
	public Package.OperatingSystemManufacturerClass OperatingSystemManufacturerClass => _OperatingSystemManufacturerClass ?? (_OperatingSystemManufacturerClass = new Package.OperatingSystemManufacturerClass());
	private Package.FirmwareVersionClass _FirmwareVersionClass;
	public Package.FirmwareVersionClass FirmwareVersionClass => _FirmwareVersionClass ?? (_FirmwareVersionClass = new Package.FirmwareVersionClass());
	private Package.FirmwareReleaseDateClass _FirmwareReleaseDateClass;
	public Package.FirmwareReleaseDateClass FirmwareReleaseDateClass => _FirmwareReleaseDateClass ?? (_FirmwareReleaseDateClass = new Package.FirmwareReleaseDateClass());
	private Package.FirmwareClass _FirmwareClass;
	public Package.FirmwareClass FirmwareClass => _FirmwareClass ?? (_FirmwareClass = new Package.FirmwareClass());
	private Package.FirmwareManufacturerClass _FirmwareManufacturerClass;
	public Package.FirmwareManufacturerClass FirmwareManufacturerClass => _FirmwareManufacturerClass ?? (_FirmwareManufacturerClass = new Package.FirmwareManufacturerClass());
	private Package.FirmwareLicenseClass _FirmwareLicenseClass;
	public Package.FirmwareLicenseClass FirmwareLicenseClass => _FirmwareLicenseClass ?? (_FirmwareLicenseClass = new Package.FirmwareLicenseClass());
	private Package.FirmwareInstallDateClass _FirmwareInstallDateClass;
	public Package.FirmwareInstallDateClass FirmwareInstallDateClass => _FirmwareInstallDateClass ?? (_FirmwareInstallDateClass = new Package.FirmwareInstallDateClass());
	private Package.ApplicationVersionClass _ApplicationVersionClass;
	public Package.ApplicationVersionClass ApplicationVersionClass => _ApplicationVersionClass ?? (_ApplicationVersionClass = new Package.ApplicationVersionClass());
	private Package.ApplicationReleaseDateClass _ApplicationReleaseDateClass;
	public Package.ApplicationReleaseDateClass ApplicationReleaseDateClass => _ApplicationReleaseDateClass ?? (_ApplicationReleaseDateClass = new Package.ApplicationReleaseDateClass());
	private Package.ApplicationClass _ApplicationClass;
	public Package.ApplicationClass ApplicationClass => _ApplicationClass ?? (_ApplicationClass = new Package.ApplicationClass());
	private Package.ApplicationManufacturerClass _ApplicationManufacturerClass;
	public Package.ApplicationManufacturerClass ApplicationManufacturerClass => _ApplicationManufacturerClass ?? (_ApplicationManufacturerClass = new Package.ApplicationManufacturerClass());
	private Package.ApplicationLicenseClass _ApplicationLicenseClass;
	public Package.ApplicationLicenseClass ApplicationLicenseClass => _ApplicationLicenseClass ?? (_ApplicationLicenseClass = new Package.ApplicationLicenseClass());
	private Package.ApplicationInstallDateClass _ApplicationInstallDateClass;
	public Package.ApplicationInstallDateClass ApplicationInstallDateClass => _ApplicationInstallDateClass ?? (_ApplicationInstallDateClass = new Package.ApplicationInstallDateClass());
	private Package.LibraryVersionClass _LibraryVersionClass;
	public Package.LibraryVersionClass LibraryVersionClass => _LibraryVersionClass ?? (_LibraryVersionClass = new Package.LibraryVersionClass());
	private Package.LibraryReleaseDateClass _LibraryReleaseDateClass;
	public Package.LibraryReleaseDateClass LibraryReleaseDateClass => _LibraryReleaseDateClass ?? (_LibraryReleaseDateClass = new Package.LibraryReleaseDateClass());
	private Package.LibraryClass _LibraryClass;
	public Package.LibraryClass LibraryClass => _LibraryClass ?? (_LibraryClass = new Package.LibraryClass());
	private Package.LibraryManufacturerClass _LibraryManufacturerClass;
	public Package.LibraryManufacturerClass LibraryManufacturerClass => _LibraryManufacturerClass ?? (_LibraryManufacturerClass = new Package.LibraryManufacturerClass());
	private Package.LibraryLicenseClass _LibraryLicenseClass;
	public Package.LibraryLicenseClass LibraryLicenseClass => _LibraryLicenseClass ?? (_LibraryLicenseClass = new Package.LibraryLicenseClass());
	private Package.LibraryInstallDateClass _LibraryInstallDateClass;
	public Package.LibraryInstallDateClass LibraryInstallDateClass => _LibraryInstallDateClass ?? (_LibraryInstallDateClass = new Package.LibraryInstallDateClass());
	private Package.HardwareVersionClass _HardwareVersionClass;
	public Package.HardwareVersionClass HardwareVersionClass => _HardwareVersionClass ?? (_HardwareVersionClass = new Package.HardwareVersionClass());
	private Package.HardwareReleaseDateClass _HardwareReleaseDateClass;
	public Package.HardwareReleaseDateClass HardwareReleaseDateClass => _HardwareReleaseDateClass ?? (_HardwareReleaseDateClass = new Package.HardwareReleaseDateClass());
	private Package.HardwareClass _HardwareClass;
	public Package.HardwareClass HardwareClass => _HardwareClass ?? (_HardwareClass = new Package.HardwareClass());
	private Package.HardwareManufacturerClass _HardwareManufacturerClass;
	public Package.HardwareManufacturerClass HardwareManufacturerClass => _HardwareManufacturerClass ?? (_HardwareManufacturerClass = new Package.HardwareManufacturerClass());
	private Package.HardwareLicenseClass _HardwareLicenseClass;
	public Package.HardwareLicenseClass HardwareLicenseClass => _HardwareLicenseClass ?? (_HardwareLicenseClass = new Package.HardwareLicenseClass());
	private Package.HardwareInstallDateClass _HardwareInstallDateClass;
	public Package.HardwareInstallDateClass HardwareInstallDateClass => _HardwareInstallDateClass ?? (_HardwareInstallDateClass = new Package.HardwareInstallDateClass());
	private Package.NetworkClass _NetworkClass;
	public Package.NetworkClass NetworkClass => _NetworkClass ?? (_NetworkClass = new Package.NetworkClass());
	private Package.NetworkIPv4AddressClass _NetworkIPv4AddressClass;
	public Package.NetworkIPv4AddressClass NetworkIPv4AddressClass => _NetworkIPv4AddressClass ?? (_NetworkIPv4AddressClass = new Package.NetworkIPv4AddressClass());
	private Package.NetworkIPv6AddressClass _NetworkIPv6AddressClass;
	public Package.NetworkIPv6AddressClass NetworkIPv6AddressClass => _NetworkIPv6AddressClass ?? (_NetworkIPv6AddressClass = new Package.NetworkIPv6AddressClass());
	private Package.NetworkGatewayClass _NetworkGatewayClass;
	public Package.NetworkGatewayClass NetworkGatewayClass => _NetworkGatewayClass ?? (_NetworkGatewayClass = new Package.NetworkGatewayClass());
	private Package.NetworkSubnetMaskClass _NetworkSubnetMaskClass;
	public Package.NetworkSubnetMaskClass NetworkSubnetMaskClass => _NetworkSubnetMaskClass ?? (_NetworkSubnetMaskClass = new Package.NetworkSubnetMaskClass());
	private Package.NetworkVLanIdClass _NetworkVLanIdClass;
	public Package.NetworkVLanIdClass NetworkVLanIdClass => _NetworkVLanIdClass ?? (_NetworkVLanIdClass = new Package.NetworkVLanIdClass());
	private Package.NetworkMacAddressClass _NetworkMacAddressClass;
	public Package.NetworkMacAddressClass NetworkMacAddressClass => _NetworkMacAddressClass ?? (_NetworkMacAddressClass = new Package.NetworkMacAddressClass());
	private Package.NetworkWirelessClass _NetworkWirelessClass;
	public Package.NetworkWirelessClass NetworkWirelessClass => _NetworkWirelessClass ?? (_NetworkWirelessClass = new Package.NetworkWirelessClass());
	private Package.RotationClass _RotationClass;
	public Package.RotationClass RotationClass => _RotationClass ?? (_RotationClass = new Package.RotationClass());
	private Package.TranslationClass _TranslationClass;
	public Package.TranslationClass TranslationClass => _TranslationClass ?? (_TranslationClass = new Package.TranslationClass());
	private Package.ProcessKindIdClass _ProcessKindIdClass;
	public Package.ProcessKindIdClass ProcessKindIdClass => _ProcessKindIdClass ?? (_ProcessKindIdClass = new Package.ProcessKindIdClass());
	private Package.PartStatusClass _PartStatusClass;
	public Package.PartStatusClass PartStatusClass => _PartStatusClass ?? (_PartStatusClass = new Package.PartStatusClass());
	private Package.AlarmLimitClass _AlarmLimitClass;
	public Package.AlarmLimitClass AlarmLimitClass => _AlarmLimitClass ?? (_AlarmLimitClass = new Package.AlarmLimitClass());
	private Package.ProcessAggregateIdClass _ProcessAggregateIdClass;
	public Package.ProcessAggregateIdClass ProcessAggregateIdClass => _ProcessAggregateIdClass ?? (_ProcessAggregateIdClass = new Package.ProcessAggregateIdClass());
	private Package.ProcessKindIdUuidClass _ProcessKindIdUuidClass;
	public Package.ProcessKindIdUuidClass ProcessKindIdUuidClass => _ProcessKindIdUuidClass ?? (_ProcessKindIdUuidClass = new Package.ProcessKindIdUuidClass());
	private Package.ProcessAggregateIdOrderNumberClass _ProcessAggregateIdOrderNumberClass;
	public Package.ProcessAggregateIdOrderNumberClass ProcessAggregateIdOrderNumberClass => _ProcessAggregateIdOrderNumberClass ?? (_ProcessAggregateIdOrderNumberClass = new Package.ProcessAggregateIdOrderNumberClass());
	private Package.ProcessKindIdISOStepExecutableClass _ProcessKindIdISOStepExecutableClass;
	public Package.ProcessKindIdISOStepExecutableClass ProcessKindIdISOStepExecutableClass => _ProcessKindIdISOStepExecutableClass ?? (_ProcessKindIdISOStepExecutableClass = new Package.ProcessKindIdISOStepExecutableClass());
	private Package.PartKindIdClass _PartKindIdClass;
	public Package.PartKindIdClass PartKindIdClass => _PartKindIdClass ?? (_PartKindIdClass = new Package.PartKindIdClass());
	private Package.ProcessKindIdProcessNameClass _ProcessKindIdProcessNameClass;
	public Package.ProcessKindIdProcessNameClass ProcessKindIdProcessNameClass => _ProcessKindIdProcessNameClass ?? (_ProcessKindIdProcessNameClass = new Package.ProcessKindIdProcessNameClass());
	private Package.AdapterURIClass _AdapterURIClass;
	public Package.AdapterURIClass AdapterURIClass => _AdapterURIClass ?? (_AdapterURIClass = new Package.AdapterURIClass());
	private Package.PartKindIdUuidClass _PartKindIdUuidClass;
	public Package.PartKindIdUuidClass PartKindIdUuidClass => _PartKindIdUuidClass ?? (_PartKindIdUuidClass = new Package.PartKindIdUuidClass());
	private Package.DeviceRemovedClass _DeviceRemovedClass;
	public Package.DeviceRemovedClass DeviceRemovedClass => _DeviceRemovedClass ?? (_DeviceRemovedClass = new Package.DeviceRemovedClass());
	private Package.DeviceChangedClass _DeviceChangedClass;
	public Package.DeviceChangedClass DeviceChangedClass => _DeviceChangedClass ?? (_DeviceChangedClass = new Package.DeviceChangedClass());
	private Package.SpecificationLimitClass _SpecificationLimitClass;
	public Package.SpecificationLimitClass SpecificationLimitClass => _SpecificationLimitClass ?? (_SpecificationLimitClass = new Package.SpecificationLimitClass());
	private Package.ConnectionStatusClass _ConnectionStatusClass;
	public Package.ConnectionStatusClass ConnectionStatusClass => _ConnectionStatusClass ?? (_ConnectionStatusClass = new Package.ConnectionStatusClass());
	private Package.PartKindIdPartFamilyClass _PartKindIdPartFamilyClass;
	public Package.PartKindIdPartFamilyClass PartKindIdPartFamilyClass => _PartKindIdPartFamilyClass ?? (_PartKindIdPartFamilyClass = new Package.PartKindIdPartFamilyClass());
	private Package.PartKindIdPartNameClass _PartKindIdPartNameClass;
	public Package.PartKindIdPartNameClass PartKindIdPartNameClass => _PartKindIdPartNameClass ?? (_PartKindIdPartNameClass = new Package.PartKindIdPartNameClass());
	private Package.AdapterSoftwareVersionClass _AdapterSoftwareVersionClass;
	public Package.AdapterSoftwareVersionClass AdapterSoftwareVersionClass => _AdapterSoftwareVersionClass ?? (_AdapterSoftwareVersionClass = new Package.AdapterSoftwareVersionClass());
	private Package.SensorAttachmentClass _SensorAttachmentClass;
	public Package.SensorAttachmentClass SensorAttachmentClass => _SensorAttachmentClass ?? (_SensorAttachmentClass = new Package.SensorAttachmentClass());
	private Package.PartKindIdPartNumberClass _PartKindIdPartNumberClass;
	public Package.PartKindIdPartNumberClass PartKindIdPartNumberClass => _PartKindIdPartNumberClass ?? (_PartKindIdPartNumberClass = new Package.PartKindIdPartNumberClass());
	private Package.PartGroupIdLotClass _PartGroupIdLotClass;
	public Package.PartGroupIdLotClass PartGroupIdLotClass => _PartGroupIdLotClass ?? (_PartGroupIdLotClass = new Package.PartGroupIdLotClass());
	private Package.PartGroupIdRawMaterialClass _PartGroupIdRawMaterialClass;
	public Package.PartGroupIdRawMaterialClass PartGroupIdRawMaterialClass => _PartGroupIdRawMaterialClass ?? (_PartGroupIdRawMaterialClass = new Package.PartGroupIdRawMaterialClass());
	private Package.PartGroupIdBatchClass _PartGroupIdBatchClass;
	public Package.PartGroupIdBatchClass PartGroupIdBatchClass => _PartGroupIdBatchClass ?? (_PartGroupIdBatchClass = new Package.PartGroupIdBatchClass());
	private Package.ControlLimitClass _ControlLimitClass;
	public Package.ControlLimitClass ControlLimitClass => _ControlLimitClass ?? (_ControlLimitClass = new Package.ControlLimitClass());
	private Package.DeviceAddedClass _DeviceAddedClass;
	public Package.DeviceAddedClass DeviceAddedClass => _DeviceAddedClass ?? (_DeviceAddedClass = new Package.DeviceAddedClass());
	private Package.ProcessAggregateIdProcessStepClass _ProcessAggregateIdProcessStepClass;
	public Package.ProcessAggregateIdProcessStepClass ProcessAggregateIdProcessStepClass => _ProcessAggregateIdProcessStepClass ?? (_ProcessAggregateIdProcessStepClass = new Package.ProcessAggregateIdProcessStepClass());
	private Package.MTConnectVersionClass _MTConnectVersionClass;
	public Package.MTConnectVersionClass MTConnectVersionClass => _MTConnectVersionClass ?? (_MTConnectVersionClass = new Package.MTConnectVersionClass());
	private Package.PartUniqueIdSerialNumberClass _PartUniqueIdSerialNumberClass;
	public Package.PartUniqueIdSerialNumberClass PartUniqueIdSerialNumberClass => _PartUniqueIdSerialNumberClass ?? (_PartUniqueIdSerialNumberClass = new Package.PartUniqueIdSerialNumberClass());
	private Package.PartUniqueIdRawMaterialClass _PartUniqueIdRawMaterialClass;
	public Package.PartUniqueIdRawMaterialClass PartUniqueIdRawMaterialClass => _PartUniqueIdRawMaterialClass ?? (_PartUniqueIdRawMaterialClass = new Package.PartUniqueIdRawMaterialClass());
	private Package.PartGroupIdUuidClass _PartGroupIdUuidClass;
	public Package.PartGroupIdUuidClass PartGroupIdUuidClass => _PartGroupIdUuidClass ?? (_PartGroupIdUuidClass = new Package.PartGroupIdUuidClass());
	private Package.ProcessOccurrenceIdClass _ProcessOccurrenceIdClass;
	public Package.ProcessOccurrenceIdClass ProcessOccurrenceIdClass => _ProcessOccurrenceIdClass ?? (_ProcessOccurrenceIdClass = new Package.ProcessOccurrenceIdClass());
	private Package.ProcessAggregateIdProcessPlanClass _ProcessAggregateIdProcessPlanClass;
	public Package.ProcessAggregateIdProcessPlanClass ProcessAggregateIdProcessPlanClass => _ProcessAggregateIdProcessPlanClass ?? (_ProcessAggregateIdProcessPlanClass = new Package.ProcessAggregateIdProcessPlanClass());
	private Package.PartUniqueIdUuidClass _PartUniqueIdUuidClass;
	public Package.PartUniqueIdUuidClass PartUniqueIdUuidClass => _PartUniqueIdUuidClass ?? (_PartUniqueIdUuidClass = new Package.PartUniqueIdUuidClass());
	private Package.PartGroupIdClass _PartGroupIdClass;
	public Package.PartGroupIdClass PartGroupIdClass => _PartGroupIdClass ?? (_PartGroupIdClass = new Package.PartGroupIdClass());
	private Package.PartGroupIdHeatTreatClass _PartGroupIdHeatTreatClass;
	public Package.PartGroupIdHeatTreatClass PartGroupIdHeatTreatClass => _PartGroupIdHeatTreatClass ?? (_PartGroupIdHeatTreatClass = new Package.PartGroupIdHeatTreatClass());
	private Package.PartUniqueIdClass _PartUniqueIdClass;
	public Package.PartUniqueIdClass PartUniqueIdClass => _PartUniqueIdClass ?? (_PartUniqueIdClass = new Package.PartUniqueIdClass());
	private Package.LoadCountRemainingClass _LoadCountRemainingClass;
	public Package.LoadCountRemainingClass LoadCountRemainingClass => _LoadCountRemainingClass ?? (_LoadCountRemainingClass = new Package.LoadCountRemainingClass());
	private Package.ActivationCountTargetClass _ActivationCountTargetClass;
	public Package.ActivationCountTargetClass ActivationCountTargetClass => _ActivationCountTargetClass ?? (_ActivationCountTargetClass = new Package.ActivationCountTargetClass());
	private Package.ActivationCountGoodClass _ActivationCountGoodClass;
	public Package.ActivationCountGoodClass ActivationCountGoodClass => _ActivationCountGoodClass ?? (_ActivationCountGoodClass = new Package.ActivationCountGoodClass());
	private Package.TransferCountGoodClass _TransferCountGoodClass;
	public Package.TransferCountGoodClass TransferCountGoodClass => _TransferCountGoodClass ?? (_TransferCountGoodClass = new Package.TransferCountGoodClass());
	private Package.CycleCountGoodClass _CycleCountGoodClass;
	public Package.CycleCountGoodClass CycleCountGoodClass => _CycleCountGoodClass ?? (_CycleCountGoodClass = new Package.CycleCountGoodClass());
	private Package.ActivationCountClass _ActivationCountClass;
	public Package.ActivationCountClass ActivationCountClass => _ActivationCountClass ?? (_ActivationCountClass = new Package.ActivationCountClass());
	private Package.UnloadCountAbortedClass _UnloadCountAbortedClass;
	public Package.UnloadCountAbortedClass UnloadCountAbortedClass => _UnloadCountAbortedClass ?? (_UnloadCountAbortedClass = new Package.UnloadCountAbortedClass());
	private Package.CycleCountRemainingClass _CycleCountRemainingClass;
	public Package.CycleCountRemainingClass CycleCountRemainingClass => _CycleCountRemainingClass ?? (_CycleCountRemainingClass = new Package.CycleCountRemainingClass());
	private Package.DeactivationCountBadClass _DeactivationCountBadClass;
	public Package.DeactivationCountBadClass DeactivationCountBadClass => _DeactivationCountBadClass ?? (_DeactivationCountBadClass = new Package.DeactivationCountBadClass());
	private Package.TransferCountAbortedClass _TransferCountAbortedClass;
	public Package.TransferCountAbortedClass TransferCountAbortedClass => _TransferCountAbortedClass ?? (_TransferCountAbortedClass = new Package.TransferCountAbortedClass());
	private Package.DeactivationCountClass _DeactivationCountClass;
	public Package.DeactivationCountClass DeactivationCountClass => _DeactivationCountClass ?? (_DeactivationCountClass = new Package.DeactivationCountClass());
	private Package.ActivationCountBadClass _ActivationCountBadClass;
	public Package.ActivationCountBadClass ActivationCountBadClass => _ActivationCountBadClass ?? (_ActivationCountBadClass = new Package.ActivationCountBadClass());
	private Package.UnloadCountBadClass _UnloadCountBadClass;
	public Package.UnloadCountBadClass UnloadCountBadClass => _UnloadCountBadClass ?? (_UnloadCountBadClass = new Package.UnloadCountBadClass());
	private Package.CycleCountCompleteClass _CycleCountCompleteClass;
	public Package.CycleCountCompleteClass CycleCountCompleteClass => _CycleCountCompleteClass ?? (_CycleCountCompleteClass = new Package.CycleCountCompleteClass());
	private Package.TransferCountClass _TransferCountClass;
	public Package.TransferCountClass TransferCountClass => _TransferCountClass ?? (_TransferCountClass = new Package.TransferCountClass());
	private Package.LoadCountBadClass _LoadCountBadClass;
	public Package.LoadCountBadClass LoadCountBadClass => _LoadCountBadClass ?? (_LoadCountBadClass = new Package.LoadCountBadClass());
	private Package.CycleCountAbortedClass _CycleCountAbortedClass;
	public Package.CycleCountAbortedClass CycleCountAbortedClass => _CycleCountAbortedClass ?? (_CycleCountAbortedClass = new Package.CycleCountAbortedClass());
	private Package.LoadCountClass _LoadCountClass;
	public Package.LoadCountClass LoadCountClass => _LoadCountClass ?? (_LoadCountClass = new Package.LoadCountClass());
	private Package.TransferCountFailedClass _TransferCountFailedClass;
	public Package.TransferCountFailedClass TransferCountFailedClass => _TransferCountFailedClass ?? (_TransferCountFailedClass = new Package.TransferCountFailedClass());
	private Package.DeactivationCountFailedClass _DeactivationCountFailedClass;
	public Package.DeactivationCountFailedClass DeactivationCountFailedClass => _DeactivationCountFailedClass ?? (_DeactivationCountFailedClass = new Package.DeactivationCountFailedClass());
	private Package.LoadCountFailedClass _LoadCountFailedClass;
	public Package.LoadCountFailedClass LoadCountFailedClass => _LoadCountFailedClass ?? (_LoadCountFailedClass = new Package.LoadCountFailedClass());
	private Package.PartProcessingStateClass _PartProcessingStateClass;
	public Package.PartProcessingStateClass PartProcessingStateClass => _PartProcessingStateClass ?? (_PartProcessingStateClass = new Package.PartProcessingStateClass());
	private Package.ActivationCountRemainingClass _ActivationCountRemainingClass;
	public Package.ActivationCountRemainingClass ActivationCountRemainingClass => _ActivationCountRemainingClass ?? (_ActivationCountRemainingClass = new Package.ActivationCountRemainingClass());
	private Package.TransferCountAllClass _TransferCountAllClass;
	public Package.TransferCountAllClass TransferCountAllClass => _TransferCountAllClass ?? (_TransferCountAllClass = new Package.TransferCountAllClass());
	private Package.UnloadCountFailedClass _UnloadCountFailedClass;
	public Package.UnloadCountFailedClass UnloadCountFailedClass => _UnloadCountFailedClass ?? (_UnloadCountFailedClass = new Package.UnloadCountFailedClass());
	private Package.ProcessStateClass _ProcessStateClass;
	public Package.ProcessStateClass ProcessStateClass => _ProcessStateClass ?? (_ProcessStateClass = new Package.ProcessStateClass());
	private Package.ActivationCountAbortedClass _ActivationCountAbortedClass;
	public Package.ActivationCountAbortedClass ActivationCountAbortedClass => _ActivationCountAbortedClass ?? (_ActivationCountAbortedClass = new Package.ActivationCountAbortedClass());
	private Package.PartCountCompleteClass _PartCountCompleteClass;
	public Package.PartCountCompleteClass PartCountCompleteClass => _PartCountCompleteClass ?? (_PartCountCompleteClass = new Package.PartCountCompleteClass());
	private Package.DeactivationCountTargetClass _DeactivationCountTargetClass;
	public Package.DeactivationCountTargetClass DeactivationCountTargetClass => _DeactivationCountTargetClass ?? (_DeactivationCountTargetClass = new Package.DeactivationCountTargetClass());
	private Package.TransferCountBadClass _TransferCountBadClass;
	public Package.TransferCountBadClass TransferCountBadClass => _TransferCountBadClass ?? (_TransferCountBadClass = new Package.TransferCountBadClass());
	private Package.ActivationCountFailedClass _ActivationCountFailedClass;
	public Package.ActivationCountFailedClass ActivationCountFailedClass => _ActivationCountFailedClass ?? (_ActivationCountFailedClass = new Package.ActivationCountFailedClass());
	private Package.TransferCountRemainingClass _TransferCountRemainingClass;
	public Package.TransferCountRemainingClass TransferCountRemainingClass => _TransferCountRemainingClass ?? (_TransferCountRemainingClass = new Package.TransferCountRemainingClass());
	private Package.DeactivationCountCompleteClass _DeactivationCountCompleteClass;
	public Package.DeactivationCountCompleteClass DeactivationCountCompleteClass => _DeactivationCountCompleteClass ?? (_DeactivationCountCompleteClass = new Package.DeactivationCountCompleteClass());
	private Package.LoadCountAbortedClass _LoadCountAbortedClass;
	public Package.LoadCountAbortedClass LoadCountAbortedClass => _LoadCountAbortedClass ?? (_LoadCountAbortedClass = new Package.LoadCountAbortedClass());
	private Package.UnloadCountGoodClass _UnloadCountGoodClass;
	public Package.UnloadCountGoodClass UnloadCountGoodClass => _UnloadCountGoodClass ?? (_UnloadCountGoodClass = new Package.UnloadCountGoodClass());
	private Package.DeactivationCountRemainingClass _DeactivationCountRemainingClass;
	public Package.DeactivationCountRemainingClass DeactivationCountRemainingClass => _DeactivationCountRemainingClass ?? (_DeactivationCountRemainingClass = new Package.DeactivationCountRemainingClass());
	private Package.CycleCountBadClass _CycleCountBadClass;
	public Package.CycleCountBadClass CycleCountBadClass => _CycleCountBadClass ?? (_CycleCountBadClass = new Package.CycleCountBadClass());
	private Package.TransferCountCompleteClass _TransferCountCompleteClass;
	public Package.TransferCountCompleteClass TransferCountCompleteClass => _TransferCountCompleteClass ?? (_TransferCountCompleteClass = new Package.TransferCountCompleteClass());
	private Package.UnloadCountCompleteClass _UnloadCountCompleteClass;
	public Package.UnloadCountCompleteClass UnloadCountCompleteClass => _UnloadCountCompleteClass ?? (_UnloadCountCompleteClass = new Package.UnloadCountCompleteClass());
	private Package.UnloadCountAllClass _UnloadCountAllClass;
	public Package.UnloadCountAllClass UnloadCountAllClass => _UnloadCountAllClass ?? (_UnloadCountAllClass = new Package.UnloadCountAllClass());
	private Package.ValveStateClass _ValveStateClass;
	public Package.ValveStateClass ValveStateClass => _ValveStateClass ?? (_ValveStateClass = new Package.ValveStateClass());
	private Package.CycleCountFailedClass _CycleCountFailedClass;
	public Package.CycleCountFailedClass CycleCountFailedClass => _CycleCountFailedClass ?? (_CycleCountFailedClass = new Package.CycleCountFailedClass());
	private Package.LoadCountAllClass _LoadCountAllClass;
	public Package.LoadCountAllClass LoadCountAllClass => _LoadCountAllClass ?? (_LoadCountAllClass = new Package.LoadCountAllClass());
	private Package.UnloadCountTargetClass _UnloadCountTargetClass;
	public Package.UnloadCountTargetClass UnloadCountTargetClass => _UnloadCountTargetClass ?? (_UnloadCountTargetClass = new Package.UnloadCountTargetClass());
	private Package.ValveStateActualClass _ValveStateActualClass;
	public Package.ValveStateActualClass ValveStateActualClass => _ValveStateActualClass ?? (_ValveStateActualClass = new Package.ValveStateActualClass());
	private Package.TransferCountTargetClass _TransferCountTargetClass;
	public Package.TransferCountTargetClass TransferCountTargetClass => _TransferCountTargetClass ?? (_TransferCountTargetClass = new Package.TransferCountTargetClass());
	private Package.CycleCountTargetClass _CycleCountTargetClass;
	public Package.CycleCountTargetClass CycleCountTargetClass => _CycleCountTargetClass ?? (_CycleCountTargetClass = new Package.CycleCountTargetClass());
	private Package.LockStateClass _LockStateClass;
	public Package.LockStateClass LockStateClass => _LockStateClass ?? (_LockStateClass = new Package.LockStateClass());
	private Package.UnloadCountClass _UnloadCountClass;
	public Package.UnloadCountClass UnloadCountClass => _UnloadCountClass ?? (_UnloadCountClass = new Package.UnloadCountClass());
	private Package.PartCountAbortedClass _PartCountAbortedClass;
	public Package.PartCountAbortedClass PartCountAbortedClass => _PartCountAbortedClass ?? (_PartCountAbortedClass = new Package.PartCountAbortedClass());
	private Package.ActivationCountCompleteClass _ActivationCountCompleteClass;
	public Package.ActivationCountCompleteClass ActivationCountCompleteClass => _ActivationCountCompleteClass ?? (_ActivationCountCompleteClass = new Package.ActivationCountCompleteClass());
	private Package.PartCountFailedClass _PartCountFailedClass;
	public Package.PartCountFailedClass PartCountFailedClass => _PartCountFailedClass ?? (_PartCountFailedClass = new Package.PartCountFailedClass());
	private Package.LoadCountGoodClass _LoadCountGoodClass;
	public Package.LoadCountGoodClass LoadCountGoodClass => _LoadCountGoodClass ?? (_LoadCountGoodClass = new Package.LoadCountGoodClass());
	private Package.CycleCountClass _CycleCountClass;
	public Package.CycleCountClass CycleCountClass => _CycleCountClass ?? (_CycleCountClass = new Package.CycleCountClass());
	private Package.CycleCountAllClass _CycleCountAllClass;
	public Package.CycleCountAllClass CycleCountAllClass => _CycleCountAllClass ?? (_CycleCountAllClass = new Package.CycleCountAllClass());
	private Package.LoadCountCompleteClass _LoadCountCompleteClass;
	public Package.LoadCountCompleteClass LoadCountCompleteClass => _LoadCountCompleteClass ?? (_LoadCountCompleteClass = new Package.LoadCountCompleteClass());
	private Package.ActivationCountAllClass _ActivationCountAllClass;
	public Package.ActivationCountAllClass ActivationCountAllClass => _ActivationCountAllClass ?? (_ActivationCountAllClass = new Package.ActivationCountAllClass());
	private Package.DeactivationCountAllClass _DeactivationCountAllClass;
	public Package.DeactivationCountAllClass DeactivationCountAllClass => _DeactivationCountAllClass ?? (_DeactivationCountAllClass = new Package.DeactivationCountAllClass());
	private Package.UnloadCountRemainingClass _UnloadCountRemainingClass;
	public Package.UnloadCountRemainingClass UnloadCountRemainingClass => _UnloadCountRemainingClass ?? (_UnloadCountRemainingClass = new Package.UnloadCountRemainingClass());
	private Package.DeactivationCountGoodClass _DeactivationCountGoodClass;
	public Package.DeactivationCountGoodClass DeactivationCountGoodClass => _DeactivationCountGoodClass ?? (_DeactivationCountGoodClass = new Package.DeactivationCountGoodClass());
	private Package.LoadCountTargetClass _LoadCountTargetClass;
	public Package.LoadCountTargetClass LoadCountTargetClass => _LoadCountTargetClass ?? (_LoadCountTargetClass = new Package.LoadCountTargetClass());
	private Package.ValveStateProgrammedClass _ValveStateProgrammedClass;
	public Package.ValveStateProgrammedClass ValveStateProgrammedClass => _ValveStateProgrammedClass ?? (_ValveStateProgrammedClass = new Package.ValveStateProgrammedClass());
	private Package.DeactivationCountAbortedClass _DeactivationCountAbortedClass;
	public Package.DeactivationCountAbortedClass DeactivationCountAbortedClass => _DeactivationCountAbortedClass ?? (_DeactivationCountAbortedClass = new Package.DeactivationCountAbortedClass());
	private Package.OperatingModeClass _OperatingModeClass;
	public Package.OperatingModeClass OperatingModeClass => _OperatingModeClass ?? (_OperatingModeClass = new Package.OperatingModeClass());
	private Package.AssetCountClass _AssetCountClass;
	public Package.AssetCountClass AssetCountClass => _AssetCountClass ?? (_AssetCountClass = new Package.AssetCountClass());
	private Package.MaintenanceListClass _MaintenanceListClass;
	public Package.MaintenanceListClass MaintenanceListClass => _MaintenanceListClass ?? (_MaintenanceListClass = new Package.MaintenanceListClass());
	private Package.FixtureIdClass _FixtureIdClass;
	public Package.FixtureIdClass FixtureIdClass => _FixtureIdClass ?? (_FixtureIdClass = new Package.FixtureIdClass());
	private Package.PartCountTypeClass _PartCountTypeClass;
	public Package.PartCountTypeClass PartCountTypeClass => _PartCountTypeClass ?? (_PartCountTypeClass = new Package.PartCountTypeClass());
	private Package.ProgramActivityClass _ProgramActivityClass;
	public Package.ProgramActivityClass ProgramActivityClass => _ProgramActivityClass ?? (_ProgramActivityClass = new Package.ProgramActivityClass());
	private Package.ProgramSegmentClass _ProgramSegmentClass;
	public Package.ProgramSegmentClass ProgramSegmentClass => _ProgramSegmentClass ?? (_ProgramSegmentClass = new Package.ProgramSegmentClass());
	private Package.ProgramRecipeClass _ProgramRecipeClass;
	public Package.ProgramRecipeClass ProgramRecipeClass => _ProgramRecipeClass ?? (_ProgramRecipeClass = new Package.ProgramRecipeClass());
	private Package.ProgramOperationClass _ProgramOperationClass;
	public Package.ProgramOperationClass ProgramOperationClass => _ProgramOperationClass ?? (_ProgramOperationClass = new Package.ProgramOperationClass());
	private Package.ProcessOccurrenceIdActivityClass _ProcessOccurrenceIdActivityClass;
	public Package.ProcessOccurrenceIdActivityClass ProcessOccurrenceIdActivityClass => _ProcessOccurrenceIdActivityClass ?? (_ProcessOccurrenceIdActivityClass = new Package.ProcessOccurrenceIdActivityClass());
	private Package.ProcessOccurrenceIdSegmentClass _ProcessOccurrenceIdSegmentClass;
	public Package.ProcessOccurrenceIdSegmentClass ProcessOccurrenceIdSegmentClass => _ProcessOccurrenceIdSegmentClass ?? (_ProcessOccurrenceIdSegmentClass = new Package.ProcessOccurrenceIdSegmentClass());
	private Package.ProcessOccurrenceIdRecipeClass _ProcessOccurrenceIdRecipeClass;
	public Package.ProcessOccurrenceIdRecipeClass ProcessOccurrenceIdRecipeClass => _ProcessOccurrenceIdRecipeClass ?? (_ProcessOccurrenceIdRecipeClass = new Package.ProcessOccurrenceIdRecipeClass());
	private Package.ProcessOccurrenceIdOperationClass _ProcessOccurrenceIdOperationClass;
	public Package.ProcessOccurrenceIdOperationClass ProcessOccurrenceIdOperationClass => _ProcessOccurrenceIdOperationClass ?? (_ProcessOccurrenceIdOperationClass = new Package.ProcessOccurrenceIdOperationClass());
	private Package.ProgramActiveClass _ProgramActiveClass;
	public Package.ProgramActiveClass ProgramActiveClass => _ProgramActiveClass ?? (_ProgramActiveClass = new Package.ProgramActiveClass());
	private Package.ProgramMainClass _ProgramMainClass;
	public Package.ProgramMainClass ProgramMainClass => _ProgramMainClass ?? (_ProgramMainClass = new Package.ProgramMainClass());
	private Package.ProgramScheduleClass _ProgramScheduleClass;
	public Package.ProgramScheduleClass ProgramScheduleClass => _ProgramScheduleClass ?? (_ProgramScheduleClass = new Package.ProgramScheduleClass());
	private Package.ClockTimeClass _ClockTimeClass;
	public Package.ClockTimeClass ClockTimeClass => _ClockTimeClass ?? (_ClockTimeClass = new Package.ClockTimeClass());
	private Package.ProgramCommentMainClass _ProgramCommentMainClass;
	public Package.ProgramCommentMainClass ProgramCommentMainClass => _ProgramCommentMainClass ?? (_ProgramCommentMainClass = new Package.ProgramCommentMainClass());
	private Package.ProgramCommentScheduleClass _ProgramCommentScheduleClass;
	public Package.ProgramCommentScheduleClass ProgramCommentScheduleClass => _ProgramCommentScheduleClass ?? (_ProgramCommentScheduleClass = new Package.ProgramCommentScheduleClass());
	private Package.ProgramCommentActiveClass _ProgramCommentActiveClass;
	public Package.ProgramCommentActiveClass ProgramCommentActiveClass => _ProgramCommentActiveClass ?? (_ProgramCommentActiveClass = new Package.ProgramCommentActiveClass());
	private Package.NetworkPortClass _NetworkPortClass;
	public Package.NetworkPortClass NetworkPortClass => _NetworkPortClass ?? (_NetworkPortClass = new Package.NetworkPortClass());
	private Package.HostNameClass _HostNameClass;
	public Package.HostNameClass HostNameClass => _HostNameClass ?? (_HostNameClass = new Package.HostNameClass());
	private Package.LeakDetectClass _LeakDetectClass;
	public Package.LeakDetectClass LeakDetectClass => _LeakDetectClass ?? (_LeakDetectClass = new Package.LeakDetectClass());
	private Package.BatteryStateClass _BatteryStateClass;
	public Package.BatteryStateClass BatteryStateClass => _BatteryStateClass ?? (_BatteryStateClass = new Package.BatteryStateClass());
	private Package.FeaturePersisitentIdClass _FeaturePersisitentIdClass;
	public Package.FeaturePersisitentIdClass FeaturePersisitentIdClass => _FeaturePersisitentIdClass ?? (_FeaturePersisitentIdClass = new Package.FeaturePersisitentIdClass());
	private Package.SensorStateClass _SensorStateClass;
	public Package.SensorStateClass SensorStateClass => _SensorStateClass ?? (_SensorStateClass = new Package.SensorStateClass());
	private Package.SensorStateBinaryClass _SensorStateBinaryClass;
	public Package.SensorStateBinaryClass SensorStateBinaryClass => _SensorStateBinaryClass ?? (_SensorStateBinaryClass = new Package.SensorStateBinaryClass());
	private Package.SensorStateBooleanClass _SensorStateBooleanClass;
	public Package.SensorStateBooleanClass SensorStateBooleanClass => _SensorStateBooleanClass ?? (_SensorStateBooleanClass = new Package.SensorStateBooleanClass());
	private Package.SensorStateEnumeratedClass _SensorStateEnumeratedClass;
	public Package.SensorStateEnumeratedClass SensorStateEnumeratedClass => _SensorStateEnumeratedClass ?? (_SensorStateEnumeratedClass = new Package.SensorStateEnumeratedClass());
	private Package.SensorStateDetectClass _SensorStateDetectClass;
	public Package.SensorStateDetectClass SensorStateDetectClass => _SensorStateDetectClass ?? (_SensorStateDetectClass = new Package.SensorStateDetectClass());
	private Package.ComponentDataClass _ComponentDataClass;
	public Package.ComponentDataClass ComponentDataClass => _ComponentDataClass ?? (_ComponentDataClass = new Package.ComponentDataClass());
	private Package.WorkOffsetsClass _WorkOffsetsClass;
	public Package.WorkOffsetsClass WorkOffsetsClass => _WorkOffsetsClass ?? (_WorkOffsetsClass = new Package.WorkOffsetsClass());
	private Package.ToolOffsetsClass _ToolOffsetsClass;
	public Package.ToolOffsetsClass ToolOffsetsClass => _ToolOffsetsClass ?? (_ToolOffsetsClass = new Package.ToolOffsetsClass());
	private Package.FeatureMeasurementClass _FeatureMeasurementClass;
	public Package.FeatureMeasurementClass FeatureMeasurementClass => _FeatureMeasurementClass ?? (_FeatureMeasurementClass = new Package.FeatureMeasurementClass());
	private Package.CharacteristicPersistentIdClass _CharacteristicPersistentIdClass;
	public Package.CharacteristicPersistentIdClass CharacteristicPersistentIdClass => _CharacteristicPersistentIdClass ?? (_CharacteristicPersistentIdClass = new Package.CharacteristicPersistentIdClass());
	private Package.MeasurementTypeClass _MeasurementTypeClass;
	public Package.MeasurementTypeClass MeasurementTypeClass => _MeasurementTypeClass ?? (_MeasurementTypeClass = new Package.MeasurementTypeClass());
	private Package.MeasurementValueClass _MeasurementValueClass;
	public Package.MeasurementValueClass MeasurementValueClass => _MeasurementValueClass ?? (_MeasurementValueClass = new Package.MeasurementValueClass());
	private Package.MeasurementUnitsClass _MeasurementUnitsClass;
	public Package.MeasurementUnitsClass MeasurementUnitsClass => _MeasurementUnitsClass ?? (_MeasurementUnitsClass = new Package.MeasurementUnitsClass());
	private Package.CharacteristicStatusClass _CharacteristicStatusClass;
	public Package.CharacteristicStatusClass CharacteristicStatusClass => _CharacteristicStatusClass ?? (_CharacteristicStatusClass = new Package.CharacteristicStatusClass());
	private Package.UncertaintyTypeClass _UncertaintyTypeClass;
	public Package.UncertaintyTypeClass UncertaintyTypeClass => _UncertaintyTypeClass ?? (_UncertaintyTypeClass = new Package.UncertaintyTypeClass());
	private Package.UncertaintyClass _UncertaintyClass;
	public Package.UncertaintyClass UncertaintyClass => _UncertaintyClass ?? (_UncertaintyClass = new Package.UncertaintyClass());
	private Package.AlarmLimitsClass _AlarmLimitsClass;
	public Package.AlarmLimitsClass AlarmLimitsClass => _AlarmLimitsClass ?? (_AlarmLimitsClass = new Package.AlarmLimitsClass());
	private Package.ControlLimitsClass _ControlLimitsClass;
	public Package.ControlLimitsClass ControlLimitsClass => _ControlLimitsClass ?? (_ControlLimitsClass = new Package.ControlLimitsClass());
	private Package.SpecificationLimitsClass _SpecificationLimitsClass;
	public Package.SpecificationLimitsClass SpecificationLimitsClass => _SpecificationLimitsClass ?? (_SpecificationLimitsClass = new Package.SpecificationLimitsClass());
	private Package.ToolCuttingItemClass _ToolCuttingItemClass;
	public Package.ToolCuttingItemClass ToolCuttingItemClass => _ToolCuttingItemClass ?? (_ToolCuttingItemClass = new Package.ToolCuttingItemClass());
	private Package.HardwareModelClass _HardwareModelClass;
	public Package.HardwareModelClass HardwareModelClass => _HardwareModelClass ?? (_HardwareModelClass = new Package.HardwareModelClass());
	private Package.LocationAddressClass _LocationAddressClass;
	public Package.LocationAddressClass LocationAddressClass => _LocationAddressClass ?? (_LocationAddressClass = new Package.LocationAddressClass());
	private Package.PowerSourceClass _PowerSourceClass;
	public Package.PowerSourceClass PowerSourceClass => _PowerSourceClass ?? (_PowerSourceClass = new Package.PowerSourceClass());
	private Package.PowerSourceStandbyClass _PowerSourceStandbyClass;
	public Package.PowerSourceStandbyClass PowerSourceStandbyClass => _PowerSourceStandbyClass ?? (_PowerSourceStandbyClass = new Package.PowerSourceStandbyClass());
	private Package.PowerSourceSecondaryClass _PowerSourceSecondaryClass;
	public Package.PowerSourceSecondaryClass PowerSourceSecondaryClass => _PowerSourceSecondaryClass ?? (_PowerSourceSecondaryClass = new Package.PowerSourceSecondaryClass());
	private Package.PowerSourcePrimaryClass _PowerSourcePrimaryClass;
	public Package.PowerSourcePrimaryClass PowerSourcePrimaryClass => _PowerSourcePrimaryClass ?? (_PowerSourcePrimaryClass = new Package.PowerSourcePrimaryClass());
	}
}