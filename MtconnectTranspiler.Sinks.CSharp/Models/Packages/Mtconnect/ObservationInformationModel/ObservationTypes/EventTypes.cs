
using System;
using System.CodeDom.Compiler;
using Package = Mtconnect.ObservationInformationModel.ObservationTypes.EventTypes;

using Mtconnect;

namespace Mtconnect.ObservationInformationModel.ObservationTypes {
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "1.0.15.3")]
	public class EventTypesPackage {


	private Package.ActiveAxesClass _ActiveAxes;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.ActiveAxesClass ActiveAxes => _ActiveAxes ?? (_ActiveAxes = new Package.ActiveAxesClass());

	private Package.ActuatorStateClass _ActuatorState;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.ActuatorStateClass ActuatorState => _ActuatorState ?? (_ActuatorState = new Package.ActuatorStateClass());

	private Package.AlarmClass _Alarm;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.AlarmClass Alarm => _Alarm ?? (_Alarm = new Package.AlarmClass());

	private Package.AssetChangedClass _AssetChanged;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.AssetChangedClass AssetChanged => _AssetChanged ?? (_AssetChanged = new Package.AssetChangedClass());

	private Package.AssetRemovedClass _AssetRemoved;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.AssetRemovedClass AssetRemoved => _AssetRemoved ?? (_AssetRemoved = new Package.AssetRemovedClass());

	private Package.AvailabilityClass _Availability;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.AvailabilityClass Availability => _Availability ?? (_Availability = new Package.AvailabilityClass());

	private Package.AxisCouplingClass _AxisCoupling;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.AxisCouplingClass AxisCoupling => _AxisCoupling ?? (_AxisCoupling = new Package.AxisCouplingClass());

	private Package.AxisFeedrateOverrideClass _AxisFeedrateOverride;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.AxisFeedrateOverrideClass AxisFeedrateOverride => _AxisFeedrateOverride ?? (_AxisFeedrateOverride = new Package.AxisFeedrateOverrideClass());

	private Package.AxisFeedrateOverrideJogClass _AxisFeedrateOverrideJog;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.AxisFeedrateOverrideJogClass AxisFeedrateOverrideJog => _AxisFeedrateOverrideJog ?? (_AxisFeedrateOverrideJog = new Package.AxisFeedrateOverrideJogClass());

	private Package.AxisFeedrateOverrideProgrammedClass _AxisFeedrateOverrideProgrammed;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.AxisFeedrateOverrideProgrammedClass AxisFeedrateOverrideProgrammed => _AxisFeedrateOverrideProgrammed ?? (_AxisFeedrateOverrideProgrammed = new Package.AxisFeedrateOverrideProgrammedClass());

	private Package.AxisFeedrateOverrideRapidClass _AxisFeedrateOverrideRapid;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.AxisFeedrateOverrideRapidClass AxisFeedrateOverrideRapid => _AxisFeedrateOverrideRapid ?? (_AxisFeedrateOverrideRapid = new Package.AxisFeedrateOverrideRapidClass());

	private Package.AxisInterlockClass _AxisInterlock;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.AxisInterlockClass AxisInterlock => _AxisInterlock ?? (_AxisInterlock = new Package.AxisInterlockClass());

	private Package.AxisStateClass _AxisState;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.AxisStateClass AxisState => _AxisState ?? (_AxisState = new Package.AxisStateClass());

	private Package.BlockClass _Block;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.BlockClass Block => _Block ?? (_Block = new Package.BlockClass());

	private Package.BlockCountClass _BlockCount;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.BlockCountClass BlockCount => _BlockCount ?? (_BlockCount = new Package.BlockCountClass());

	private Package.ChuckInterlockClass _ChuckInterlock;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.ChuckInterlockClass ChuckInterlock => _ChuckInterlock ?? (_ChuckInterlock = new Package.ChuckInterlockClass());

	private Package.ChuckInterlockManualUnclampClass _ChuckInterlockManualUnclamp;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.ChuckInterlockManualUnclampClass ChuckInterlockManualUnclamp => _ChuckInterlockManualUnclamp ?? (_ChuckInterlockManualUnclamp = new Package.ChuckInterlockManualUnclampClass());

	private Package.ChuckStateClass _ChuckState;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.ChuckStateClass ChuckState => _ChuckState ?? (_ChuckState = new Package.ChuckStateClass());

	private Package.CodeClass _Code;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.CodeClass Code => _Code ?? (_Code = new Package.CodeClass());

	private Package.CompositionStateClass _CompositionState;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.CompositionStateClass CompositionState => _CompositionState ?? (_CompositionState = new Package.CompositionStateClass());

	private Package.CompositionStateActionClass _CompositionStateAction;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.CompositionStateActionClass CompositionStateAction => _CompositionStateAction ?? (_CompositionStateAction = new Package.CompositionStateActionClass());

	private Package.CompositionStateLateralClass _CompositionStateLateral;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.CompositionStateLateralClass CompositionStateLateral => _CompositionStateLateral ?? (_CompositionStateLateral = new Package.CompositionStateLateralClass());

	private Package.CompositionStateMotionClass _CompositionStateMotion;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.CompositionStateMotionClass CompositionStateMotion => _CompositionStateMotion ?? (_CompositionStateMotion = new Package.CompositionStateMotionClass());

	private Package.CompositionStateSwitchedClass _CompositionStateSwitched;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.CompositionStateSwitchedClass CompositionStateSwitched => _CompositionStateSwitched ?? (_CompositionStateSwitched = new Package.CompositionStateSwitchedClass());

	private Package.CompositionStateVerticalClass _CompositionStateVertical;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.CompositionStateVerticalClass CompositionStateVertical => _CompositionStateVertical ?? (_CompositionStateVertical = new Package.CompositionStateVerticalClass());

	private Package.ControllerModeClass _ControllerMode;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.ControllerModeClass ControllerMode => _ControllerMode ?? (_ControllerMode = new Package.ControllerModeClass());

	private Package.ControllerModeOverrideClass _ControllerModeOverride;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.ControllerModeOverrideClass ControllerModeOverride => _ControllerModeOverride ?? (_ControllerModeOverride = new Package.ControllerModeOverrideClass());

	private Package.ControllerModeOverrideDryRunClass _ControllerModeOverrideDryRun;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.ControllerModeOverrideDryRunClass ControllerModeOverrideDryRun => _ControllerModeOverrideDryRun ?? (_ControllerModeOverrideDryRun = new Package.ControllerModeOverrideDryRunClass());

	private Package.ControllerModeOverrideSingleBlockClass _ControllerModeOverrideSingleBlock;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.ControllerModeOverrideSingleBlockClass ControllerModeOverrideSingleBlock => _ControllerModeOverrideSingleBlock ?? (_ControllerModeOverrideSingleBlock = new Package.ControllerModeOverrideSingleBlockClass());

	private Package.ControllerModeOverrideMachineAxisLockClass _ControllerModeOverrideMachineAxisLock;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.ControllerModeOverrideMachineAxisLockClass ControllerModeOverrideMachineAxisLock => _ControllerModeOverrideMachineAxisLock ?? (_ControllerModeOverrideMachineAxisLock = new Package.ControllerModeOverrideMachineAxisLockClass());

	private Package.ControllerModeOverrideOptionalStopClass _ControllerModeOverrideOptionalStop;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.ControllerModeOverrideOptionalStopClass ControllerModeOverrideOptionalStop => _ControllerModeOverrideOptionalStop ?? (_ControllerModeOverrideOptionalStop = new Package.ControllerModeOverrideOptionalStopClass());

	private Package.ControllerModeOverrideToolChangeStopClass _ControllerModeOverrideToolChangeStop;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.ControllerModeOverrideToolChangeStopClass ControllerModeOverrideToolChangeStop => _ControllerModeOverrideToolChangeStop ?? (_ControllerModeOverrideToolChangeStop = new Package.ControllerModeOverrideToolChangeStopClass());

	private Package.CoupledAxesClass _CoupledAxes;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.CoupledAxesClass CoupledAxes => _CoupledAxes ?? (_CoupledAxes = new Package.CoupledAxesClass());

	private Package.DateCodeClass _DateCode;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.DateCodeClass DateCode => _DateCode ?? (_DateCode = new Package.DateCodeClass());

	private Package.DateCodeManufactureClass _DateCodeManufacture;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.DateCodeManufactureClass DateCodeManufacture => _DateCodeManufacture ?? (_DateCodeManufacture = new Package.DateCodeManufactureClass());

	private Package.DateCodeExpirationClass _DateCodeExpiration;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.DateCodeExpirationClass DateCodeExpiration => _DateCodeExpiration ?? (_DateCodeExpiration = new Package.DateCodeExpirationClass());

	private Package.DateCodeFirstUseClass _DateCodeFirstUse;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.DateCodeFirstUseClass DateCodeFirstUse => _DateCodeFirstUse ?? (_DateCodeFirstUse = new Package.DateCodeFirstUseClass());

	private Package.DeviceUuidClass _DeviceUuid;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.DeviceUuidClass DeviceUuid => _DeviceUuid ?? (_DeviceUuid = new Package.DeviceUuidClass());

	private Package.DirectionClass _Direction;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.DirectionClass Direction => _Direction ?? (_Direction = new Package.DirectionClass());

	private Package.DirectionRotaryClass _DirectionRotary;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.DirectionRotaryClass DirectionRotary => _DirectionRotary ?? (_DirectionRotary = new Package.DirectionRotaryClass());

	private Package.DirectionLinearClass _DirectionLinear;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.DirectionLinearClass DirectionLinear => _DirectionLinear ?? (_DirectionLinear = new Package.DirectionLinearClass());

	private Package.DoorStateClass _DoorState;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.DoorStateClass DoorState => _DoorState ?? (_DoorState = new Package.DoorStateClass());

	private Package.EmergencyStopClass _EmergencyStop;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.EmergencyStopClass EmergencyStop => _EmergencyStop ?? (_EmergencyStop = new Package.EmergencyStopClass());

	private Package.EndOfBarClass _EndOfBar;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.EndOfBarClass EndOfBar => _EndOfBar ?? (_EndOfBar = new Package.EndOfBarClass());

	private Package.EndOfBarPrimaryClass _EndOfBarPrimary;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.EndOfBarPrimaryClass EndOfBarPrimary => _EndOfBarPrimary ?? (_EndOfBarPrimary = new Package.EndOfBarPrimaryClass());

	private Package.EndOfBarAuxiliaryClass _EndOfBarAuxiliary;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.EndOfBarAuxiliaryClass EndOfBarAuxiliary => _EndOfBarAuxiliary ?? (_EndOfBarAuxiliary = new Package.EndOfBarAuxiliaryClass());

	private Package.EquipmentModeClass _EquipmentMode;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.EquipmentModeClass EquipmentMode => _EquipmentMode ?? (_EquipmentMode = new Package.EquipmentModeClass());

	private Package.EquipmentModeLoadedClass _EquipmentModeLoaded;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.EquipmentModeLoadedClass EquipmentModeLoaded => _EquipmentModeLoaded ?? (_EquipmentModeLoaded = new Package.EquipmentModeLoadedClass());

	private Package.EquipmentModeWorkingClass _EquipmentModeWorking;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.EquipmentModeWorkingClass EquipmentModeWorking => _EquipmentModeWorking ?? (_EquipmentModeWorking = new Package.EquipmentModeWorkingClass());

	private Package.EquipmentModeOperatingClass _EquipmentModeOperating;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.EquipmentModeOperatingClass EquipmentModeOperating => _EquipmentModeOperating ?? (_EquipmentModeOperating = new Package.EquipmentModeOperatingClass());

	private Package.EquipmentModePoweredClass _EquipmentModePowered;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.EquipmentModePoweredClass EquipmentModePowered => _EquipmentModePowered ?? (_EquipmentModePowered = new Package.EquipmentModePoweredClass());

	private Package.EquipmentModeDelayClass _EquipmentModeDelay;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.EquipmentModeDelayClass EquipmentModeDelay => _EquipmentModeDelay ?? (_EquipmentModeDelay = new Package.EquipmentModeDelayClass());

	private Package.ExecutionClass _Execution;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.ExecutionClass Execution => _Execution ?? (_Execution = new Package.ExecutionClass());

	private Package.FunctionalModeClass _FunctionalMode;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.FunctionalModeClass FunctionalMode => _FunctionalMode ?? (_FunctionalMode = new Package.FunctionalModeClass());

	private Package.HardnessClass _Hardness;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.HardnessClass Hardness => _Hardness ?? (_Hardness = new Package.HardnessClass());

	private Package.HardnessRockwellClass _HardnessRockwell;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.HardnessRockwellClass HardnessRockwell => _HardnessRockwell ?? (_HardnessRockwell = new Package.HardnessRockwellClass());

	private Package.HardnessVickersClass _HardnessVickers;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.HardnessVickersClass HardnessVickers => _HardnessVickers ?? (_HardnessVickers = new Package.HardnessVickersClass());

	private Package.HardnessShoreClass _HardnessShore;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.HardnessShoreClass HardnessShore => _HardnessShore ?? (_HardnessShore = new Package.HardnessShoreClass());

	private Package.HardnessBrinellClass _HardnessBrinell;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.HardnessBrinellClass HardnessBrinell => _HardnessBrinell ?? (_HardnessBrinell = new Package.HardnessBrinellClass());

	private Package.HardnessLeebClass _HardnessLeeb;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.HardnessLeebClass HardnessLeeb => _HardnessLeeb ?? (_HardnessLeeb = new Package.HardnessLeebClass());

	private Package.HardnessMohsClass _HardnessMohs;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.HardnessMohsClass HardnessMohs => _HardnessMohs ?? (_HardnessMohs = new Package.HardnessMohsClass());

	private Package.LineClass _Line;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.LineClass Line => _Line ?? (_Line = new Package.LineClass());

	private Package.LineMaximumClass _LineMaximum;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.LineMaximumClass LineMaximum => _LineMaximum ?? (_LineMaximum = new Package.LineMaximumClass());

	private Package.LineMinimumClass _LineMinimum;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.LineMinimumClass LineMinimum => _LineMinimum ?? (_LineMinimum = new Package.LineMinimumClass());

	private Package.LineLabelClass _LineLabel;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.LineLabelClass LineLabel => _LineLabel ?? (_LineLabel = new Package.LineLabelClass());

	private Package.LineNumberClass _LineNumber;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.LineNumberClass LineNumber => _LineNumber ?? (_LineNumber = new Package.LineNumberClass());

	private Package.LineNumberAbsoluteClass _LineNumberAbsolute;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.LineNumberAbsoluteClass LineNumberAbsolute => _LineNumberAbsolute ?? (_LineNumberAbsolute = new Package.LineNumberAbsoluteClass());

	private Package.LineNumberIncrementalClass _LineNumberIncremental;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.LineNumberIncrementalClass LineNumberIncremental => _LineNumberIncremental ?? (_LineNumberIncremental = new Package.LineNumberIncrementalClass());

	private Package.MaterialClass _Material;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.MaterialClass Material => _Material ?? (_Material = new Package.MaterialClass());

	private Package.MaterialLayerClass _MaterialLayer;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.MaterialLayerClass MaterialLayer => _MaterialLayer ?? (_MaterialLayer = new Package.MaterialLayerClass());

	private Package.MaterialLayerActualClass _MaterialLayerActual;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.MaterialLayerActualClass MaterialLayerActual => _MaterialLayerActual ?? (_MaterialLayerActual = new Package.MaterialLayerActualClass());

	private Package.MaterialLayerTargetClass _MaterialLayerTarget;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.MaterialLayerTargetClass MaterialLayerTarget => _MaterialLayerTarget ?? (_MaterialLayerTarget = new Package.MaterialLayerTargetClass());

	private Package.MessageClass _Message;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.MessageClass Message => _Message ?? (_Message = new Package.MessageClass());

	private Package.OperatorIdClass _OperatorId;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.OperatorIdClass OperatorId => _OperatorId ?? (_OperatorId = new Package.OperatorIdClass());

	private Package.PalletIdClass _PalletId;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.PalletIdClass PalletId => _PalletId ?? (_PalletId = new Package.PalletIdClass());

	private Package.PartCountClass _PartCount;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.PartCountClass PartCount => _PartCount ?? (_PartCount = new Package.PartCountClass());

	private Package.PartCountAllClass _PartCountAll;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.PartCountAllClass PartCountAll => _PartCountAll ?? (_PartCountAll = new Package.PartCountAllClass());

	private Package.PartCountGoodClass _PartCountGood;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.PartCountGoodClass PartCountGood => _PartCountGood ?? (_PartCountGood = new Package.PartCountGoodClass());

	private Package.PartCountBadClass _PartCountBad;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.PartCountBadClass PartCountBad => _PartCountBad ?? (_PartCountBad = new Package.PartCountBadClass());

	private Package.PartCountTargetClass _PartCountTarget;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.PartCountTargetClass PartCountTarget => _PartCountTarget ?? (_PartCountTarget = new Package.PartCountTargetClass());

	private Package.PartCountRemainingClass _PartCountRemaining;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.PartCountRemainingClass PartCountRemaining => _PartCountRemaining ?? (_PartCountRemaining = new Package.PartCountRemainingClass());

	private Package.PartDetectClass _PartDetect;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.PartDetectClass PartDetect => _PartDetect ?? (_PartDetect = new Package.PartDetectClass());

	private Package.PartIdClass _PartId;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.PartIdClass PartId => _PartId ?? (_PartId = new Package.PartIdClass());

	private Package.PartNumberClass _PartNumber;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.PartNumberClass PartNumber => _PartNumber ?? (_PartNumber = new Package.PartNumberClass());

	private Package.PathFeedrateOverrideClass _PathFeedrateOverride;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.PathFeedrateOverrideClass PathFeedrateOverride => _PathFeedrateOverride ?? (_PathFeedrateOverride = new Package.PathFeedrateOverrideClass());

	private Package.PathFeedrateOverrideJogClass _PathFeedrateOverrideJog;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.PathFeedrateOverrideJogClass PathFeedrateOverrideJog => _PathFeedrateOverrideJog ?? (_PathFeedrateOverrideJog = new Package.PathFeedrateOverrideJogClass());

	private Package.PathFeedrateOverrideProgrammedClass _PathFeedrateOverrideProgrammed;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.PathFeedrateOverrideProgrammedClass PathFeedrateOverrideProgrammed => _PathFeedrateOverrideProgrammed ?? (_PathFeedrateOverrideProgrammed = new Package.PathFeedrateOverrideProgrammedClass());

	private Package.PathFeedrateOverrideRapidClass _PathFeedrateOverrideRapid;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.PathFeedrateOverrideRapidClass PathFeedrateOverrideRapid => _PathFeedrateOverrideRapid ?? (_PathFeedrateOverrideRapid = new Package.PathFeedrateOverrideRapidClass());

	private Package.PathModeClass _PathMode;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.PathModeClass PathMode => _PathMode ?? (_PathMode = new Package.PathModeClass());

	private Package.PowerStateClass _PowerState;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.PowerStateClass PowerState => _PowerState ?? (_PowerState = new Package.PowerStateClass());

	private Package.PowerStateLineClass _PowerStateLine;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.PowerStateLineClass PowerStateLine => _PowerStateLine ?? (_PowerStateLine = new Package.PowerStateLineClass());

	private Package.PowerStateControlClass _PowerStateControl;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.PowerStateControlClass PowerStateControl => _PowerStateControl ?? (_PowerStateControl = new Package.PowerStateControlClass());

	private Package.PowerStatusClass _PowerStatus;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.PowerStatusClass PowerStatus => _PowerStatus ?? (_PowerStatus = new Package.PowerStatusClass());

	private Package.ProcessTimeClass _ProcessTime;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.ProcessTimeClass ProcessTime => _ProcessTime ?? (_ProcessTime = new Package.ProcessTimeClass());

	private Package.ProcessTimeStartClass _ProcessTimeStart;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.ProcessTimeStartClass ProcessTimeStart => _ProcessTimeStart ?? (_ProcessTimeStart = new Package.ProcessTimeStartClass());

	private Package.ProcessTimeCompleteClass _ProcessTimeComplete;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.ProcessTimeCompleteClass ProcessTimeComplete => _ProcessTimeComplete ?? (_ProcessTimeComplete = new Package.ProcessTimeCompleteClass());

	private Package.ProcessTimeTargetCompletionClass _ProcessTimeTargetCompletion;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.ProcessTimeTargetCompletionClass ProcessTimeTargetCompletion => _ProcessTimeTargetCompletion ?? (_ProcessTimeTargetCompletion = new Package.ProcessTimeTargetCompletionClass());

	private Package.ProgramClass _Program;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.ProgramClass Program => _Program ?? (_Program = new Package.ProgramClass());

	private Package.ProgramCommentClass _ProgramComment;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.ProgramCommentClass ProgramComment => _ProgramComment ?? (_ProgramComment = new Package.ProgramCommentClass());

	private Package.ProgramEditClass _ProgramEdit;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.ProgramEditClass ProgramEdit => _ProgramEdit ?? (_ProgramEdit = new Package.ProgramEditClass());

	private Package.ProgramEditNameClass _ProgramEditName;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.ProgramEditNameClass ProgramEditName => _ProgramEditName ?? (_ProgramEditName = new Package.ProgramEditNameClass());

	private Package.ProgramHeaderClass _ProgramHeader;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.ProgramHeaderClass ProgramHeader => _ProgramHeader ?? (_ProgramHeader = new Package.ProgramHeaderClass());

	private Package.ProgramLocationClass _ProgramLocation;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.ProgramLocationClass ProgramLocation => _ProgramLocation ?? (_ProgramLocation = new Package.ProgramLocationClass());

	private Package.ProgramLocationScheduleClass _ProgramLocationSchedule;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.ProgramLocationScheduleClass ProgramLocationSchedule => _ProgramLocationSchedule ?? (_ProgramLocationSchedule = new Package.ProgramLocationScheduleClass());

	private Package.ProgramLocationMainClass _ProgramLocationMain;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.ProgramLocationMainClass ProgramLocationMain => _ProgramLocationMain ?? (_ProgramLocationMain = new Package.ProgramLocationMainClass());

	private Package.ProgramLocationActiveClass _ProgramLocationActive;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.ProgramLocationActiveClass ProgramLocationActive => _ProgramLocationActive ?? (_ProgramLocationActive = new Package.ProgramLocationActiveClass());

	private Package.ProgramLocationTypeClass _ProgramLocationType;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.ProgramLocationTypeClass ProgramLocationType => _ProgramLocationType ?? (_ProgramLocationType = new Package.ProgramLocationTypeClass());

	private Package.ProgramLocationTypeScheduleClass _ProgramLocationTypeSchedule;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.ProgramLocationTypeScheduleClass ProgramLocationTypeSchedule => _ProgramLocationTypeSchedule ?? (_ProgramLocationTypeSchedule = new Package.ProgramLocationTypeScheduleClass());

	private Package.ProgramLocationTypeMainClass _ProgramLocationTypeMain;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.ProgramLocationTypeMainClass ProgramLocationTypeMain => _ProgramLocationTypeMain ?? (_ProgramLocationTypeMain = new Package.ProgramLocationTypeMainClass());

	private Package.ProgramLocationTypeActiveClass _ProgramLocationTypeActive;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.ProgramLocationTypeActiveClass ProgramLocationTypeActive => _ProgramLocationTypeActive ?? (_ProgramLocationTypeActive = new Package.ProgramLocationTypeActiveClass());

	private Package.ProgramNestLevelClass _ProgramNestLevel;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.ProgramNestLevelClass ProgramNestLevel => _ProgramNestLevel ?? (_ProgramNestLevel = new Package.ProgramNestLevelClass());

	private Package.RotaryModeClass _RotaryMode;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.RotaryModeClass RotaryMode => _RotaryMode ?? (_RotaryMode = new Package.RotaryModeClass());

	private Package.RotaryVelocityOverrideClass _RotaryVelocityOverride;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.RotaryVelocityOverrideClass RotaryVelocityOverride => _RotaryVelocityOverride ?? (_RotaryVelocityOverride = new Package.RotaryVelocityOverrideClass());

	private Package.SerialNumberClass _SerialNumber;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.SerialNumberClass SerialNumber => _SerialNumber ?? (_SerialNumber = new Package.SerialNumberClass());

	private Package.SpindleInterlockClass _SpindleInterlock;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.SpindleInterlockClass SpindleInterlock => _SpindleInterlock ?? (_SpindleInterlock = new Package.SpindleInterlockClass());

	private Package.ToolAssetIdClass _ToolAssetId;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.ToolAssetIdClass ToolAssetId => _ToolAssetId ?? (_ToolAssetId = new Package.ToolAssetIdClass());

	private Package.ToolGroupClass _ToolGroup;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.ToolGroupClass ToolGroup => _ToolGroup ?? (_ToolGroup = new Package.ToolGroupClass());

	private Package.ToolIdClass _ToolId;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.ToolIdClass ToolId => _ToolId ?? (_ToolId = new Package.ToolIdClass());

	private Package.ToolNumberClass _ToolNumber;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.ToolNumberClass ToolNumber => _ToolNumber ?? (_ToolNumber = new Package.ToolNumberClass());

	private Package.ToolOffsetClass _ToolOffset;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.ToolOffsetClass ToolOffset => _ToolOffset ?? (_ToolOffset = new Package.ToolOffsetClass());

	private Package.ToolOffsetRadialClass _ToolOffsetRadial;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.ToolOffsetRadialClass ToolOffsetRadial => _ToolOffsetRadial ?? (_ToolOffsetRadial = new Package.ToolOffsetRadialClass());

	private Package.ToolOffsetLengthClass _ToolOffsetLength;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.ToolOffsetLengthClass ToolOffsetLength => _ToolOffsetLength ?? (_ToolOffsetLength = new Package.ToolOffsetLengthClass());

	private Package.UserClass _User;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.UserClass User => _User ?? (_User = new Package.UserClass());

	private Package.UserOperatorClass _UserOperator;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.UserOperatorClass UserOperator => _UserOperator ?? (_UserOperator = new Package.UserOperatorClass());

	private Package.UserMaintenanceClass _UserMaintenance;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.UserMaintenanceClass UserMaintenance => _UserMaintenance ?? (_UserMaintenance = new Package.UserMaintenanceClass());

	private Package.UserSetUpClass _UserSetUp;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.UserSetUpClass UserSetUp => _UserSetUp ?? (_UserSetUp = new Package.UserSetUpClass());

	private Package.VariableClass _Variable;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.VariableClass Variable => _Variable ?? (_Variable = new Package.VariableClass());

	private Package.WaitStateClass _WaitState;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.WaitStateClass WaitState => _WaitState ?? (_WaitState = new Package.WaitStateClass());

	private Package.WireClass _Wire;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.WireClass Wire => _Wire ?? (_Wire = new Package.WireClass());

	private Package.WorkholdingIdClass _WorkholdingId;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.WorkholdingIdClass WorkholdingId => _WorkholdingId ?? (_WorkholdingId = new Package.WorkholdingIdClass());

	private Package.WorkOffsetClass _WorkOffset;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.WorkOffsetClass WorkOffset => _WorkOffset ?? (_WorkOffset = new Package.WorkOffsetClass());

	private Package.ProgramHeaderMainClass _ProgramHeaderMain;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.ProgramHeaderMainClass ProgramHeaderMain => _ProgramHeaderMain ?? (_ProgramHeaderMain = new Package.ProgramHeaderMainClass());

	private Package.ProgramHeaderScheduleClass _ProgramHeaderSchedule;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.ProgramHeaderScheduleClass ProgramHeaderSchedule => _ProgramHeaderSchedule ?? (_ProgramHeaderSchedule = new Package.ProgramHeaderScheduleClass());

	private Package.ProgramHeaderActiveClass _ProgramHeaderActive;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.ProgramHeaderActiveClass ProgramHeaderActive => _ProgramHeaderActive ?? (_ProgramHeaderActive = new Package.ProgramHeaderActiveClass());

	private Package.OperatingSystemClass _OperatingSystem;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.OperatingSystemClass OperatingSystem => _OperatingSystem ?? (_OperatingSystem = new Package.OperatingSystemClass());

	private Package.OperatingSystemLicenseClass _OperatingSystemLicense;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.OperatingSystemLicenseClass OperatingSystemLicense => _OperatingSystemLicense ?? (_OperatingSystemLicense = new Package.OperatingSystemLicenseClass());

	private Package.OperatingSystemVersionClass _OperatingSystemVersion;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.OperatingSystemVersionClass OperatingSystemVersion => _OperatingSystemVersion ?? (_OperatingSystemVersion = new Package.OperatingSystemVersionClass());

	private Package.OperatingSystemReleaseDateClass _OperatingSystemReleaseDate;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.OperatingSystemReleaseDateClass OperatingSystemReleaseDate => _OperatingSystemReleaseDate ?? (_OperatingSystemReleaseDate = new Package.OperatingSystemReleaseDateClass());

	private Package.OperatingSystemInstallDateClass _OperatingSystemInstallDate;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.OperatingSystemInstallDateClass OperatingSystemInstallDate => _OperatingSystemInstallDate ?? (_OperatingSystemInstallDate = new Package.OperatingSystemInstallDateClass());

	private Package.OperatingSystemManufacturerClass _OperatingSystemManufacturer;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.OperatingSystemManufacturerClass OperatingSystemManufacturer => _OperatingSystemManufacturer ?? (_OperatingSystemManufacturer = new Package.OperatingSystemManufacturerClass());

	private Package.FirmwareVersionClass _FirmwareVersion;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.FirmwareVersionClass FirmwareVersion => _FirmwareVersion ?? (_FirmwareVersion = new Package.FirmwareVersionClass());

	private Package.FirmwareReleaseDateClass _FirmwareReleaseDate;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.FirmwareReleaseDateClass FirmwareReleaseDate => _FirmwareReleaseDate ?? (_FirmwareReleaseDate = new Package.FirmwareReleaseDateClass());

	private Package.FirmwareClass _Firmware;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.FirmwareClass Firmware => _Firmware ?? (_Firmware = new Package.FirmwareClass());

	private Package.FirmwareManufacturerClass _FirmwareManufacturer;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.FirmwareManufacturerClass FirmwareManufacturer => _FirmwareManufacturer ?? (_FirmwareManufacturer = new Package.FirmwareManufacturerClass());

	private Package.FirmwareLicenseClass _FirmwareLicense;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.FirmwareLicenseClass FirmwareLicense => _FirmwareLicense ?? (_FirmwareLicense = new Package.FirmwareLicenseClass());

	private Package.FirmwareInstallDateClass _FirmwareInstallDate;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.FirmwareInstallDateClass FirmwareInstallDate => _FirmwareInstallDate ?? (_FirmwareInstallDate = new Package.FirmwareInstallDateClass());

	private Package.ApplicationVersionClass _ApplicationVersion;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.ApplicationVersionClass ApplicationVersion => _ApplicationVersion ?? (_ApplicationVersion = new Package.ApplicationVersionClass());

	private Package.ApplicationReleaseDateClass _ApplicationReleaseDate;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.ApplicationReleaseDateClass ApplicationReleaseDate => _ApplicationReleaseDate ?? (_ApplicationReleaseDate = new Package.ApplicationReleaseDateClass());

	private Package.ApplicationClass _Application;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.ApplicationClass Application => _Application ?? (_Application = new Package.ApplicationClass());

	private Package.ApplicationManufacturerClass _ApplicationManufacturer;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.ApplicationManufacturerClass ApplicationManufacturer => _ApplicationManufacturer ?? (_ApplicationManufacturer = new Package.ApplicationManufacturerClass());

	private Package.ApplicationLicenseClass _ApplicationLicense;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.ApplicationLicenseClass ApplicationLicense => _ApplicationLicense ?? (_ApplicationLicense = new Package.ApplicationLicenseClass());

	private Package.ApplicationInstallDateClass _ApplicationInstallDate;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.ApplicationInstallDateClass ApplicationInstallDate => _ApplicationInstallDate ?? (_ApplicationInstallDate = new Package.ApplicationInstallDateClass());

	private Package.LibraryVersionClass _LibraryVersion;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.LibraryVersionClass LibraryVersion => _LibraryVersion ?? (_LibraryVersion = new Package.LibraryVersionClass());

	private Package.LibraryReleaseDateClass _LibraryReleaseDate;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.LibraryReleaseDateClass LibraryReleaseDate => _LibraryReleaseDate ?? (_LibraryReleaseDate = new Package.LibraryReleaseDateClass());

	private Package.LibraryClass _Library;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.LibraryClass Library => _Library ?? (_Library = new Package.LibraryClass());

	private Package.LibraryManufacturerClass _LibraryManufacturer;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.LibraryManufacturerClass LibraryManufacturer => _LibraryManufacturer ?? (_LibraryManufacturer = new Package.LibraryManufacturerClass());

	private Package.LibraryLicenseClass _LibraryLicense;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.LibraryLicenseClass LibraryLicense => _LibraryLicense ?? (_LibraryLicense = new Package.LibraryLicenseClass());

	private Package.LibraryInstallDateClass _LibraryInstallDate;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.LibraryInstallDateClass LibraryInstallDate => _LibraryInstallDate ?? (_LibraryInstallDate = new Package.LibraryInstallDateClass());

	private Package.HardwareVersionClass _HardwareVersion;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.HardwareVersionClass HardwareVersion => _HardwareVersion ?? (_HardwareVersion = new Package.HardwareVersionClass());

	private Package.HardwareReleaseDateClass _HardwareReleaseDate;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.HardwareReleaseDateClass HardwareReleaseDate => _HardwareReleaseDate ?? (_HardwareReleaseDate = new Package.HardwareReleaseDateClass());

	private Package.HardwareClass _Hardware;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.HardwareClass Hardware => _Hardware ?? (_Hardware = new Package.HardwareClass());

	private Package.HardwareManufacturerClass _HardwareManufacturer;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.HardwareManufacturerClass HardwareManufacturer => _HardwareManufacturer ?? (_HardwareManufacturer = new Package.HardwareManufacturerClass());

	private Package.HardwareLicenseClass _HardwareLicense;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.HardwareLicenseClass HardwareLicense => _HardwareLicense ?? (_HardwareLicense = new Package.HardwareLicenseClass());

	private Package.HardwareInstallDateClass _HardwareInstallDate;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.HardwareInstallDateClass HardwareInstallDate => _HardwareInstallDate ?? (_HardwareInstallDate = new Package.HardwareInstallDateClass());

	private Package.NetworkClass _Network;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.NetworkClass Network => _Network ?? (_Network = new Package.NetworkClass());

	private Package.NetworkIPv4AddressClass _NetworkIPv4Address;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.NetworkIPv4AddressClass NetworkIPv4Address => _NetworkIPv4Address ?? (_NetworkIPv4Address = new Package.NetworkIPv4AddressClass());

	private Package.NetworkIPv6AddressClass _NetworkIPv6Address;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.NetworkIPv6AddressClass NetworkIPv6Address => _NetworkIPv6Address ?? (_NetworkIPv6Address = new Package.NetworkIPv6AddressClass());

	private Package.NetworkGatewayClass _NetworkGateway;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.NetworkGatewayClass NetworkGateway => _NetworkGateway ?? (_NetworkGateway = new Package.NetworkGatewayClass());

	private Package.NetworkSubnetMaskClass _NetworkSubnetMask;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.NetworkSubnetMaskClass NetworkSubnetMask => _NetworkSubnetMask ?? (_NetworkSubnetMask = new Package.NetworkSubnetMaskClass());

	private Package.NetworkVLanIdClass _NetworkVLanId;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.NetworkVLanIdClass NetworkVLanId => _NetworkVLanId ?? (_NetworkVLanId = new Package.NetworkVLanIdClass());

	private Package.NetworkMacAddressClass _NetworkMacAddress;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.NetworkMacAddressClass NetworkMacAddress => _NetworkMacAddress ?? (_NetworkMacAddress = new Package.NetworkMacAddressClass());

	private Package.NetworkWirelessClass _NetworkWireless;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.NetworkWirelessClass NetworkWireless => _NetworkWireless ?? (_NetworkWireless = new Package.NetworkWirelessClass());

	private Package.RotationClass _Rotation;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.RotationClass Rotation => _Rotation ?? (_Rotation = new Package.RotationClass());

	private Package.TranslationClass _Translation;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.TranslationClass Translation => _Translation ?? (_Translation = new Package.TranslationClass());

	private Package.ProcessKindIdClass _ProcessKindId;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.ProcessKindIdClass ProcessKindId => _ProcessKindId ?? (_ProcessKindId = new Package.ProcessKindIdClass());

	private Package.PartStatusClass _PartStatus;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.PartStatusClass PartStatus => _PartStatus ?? (_PartStatus = new Package.PartStatusClass());

	private Package.AlarmLimitClass _AlarmLimit;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.AlarmLimitClass AlarmLimit => _AlarmLimit ?? (_AlarmLimit = new Package.AlarmLimitClass());

	private Package.ProcessAggregateIdClass _ProcessAggregateId;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.ProcessAggregateIdClass ProcessAggregateId => _ProcessAggregateId ?? (_ProcessAggregateId = new Package.ProcessAggregateIdClass());

	private Package.ProcessKindIdUuidClass _ProcessKindIdUuid;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.ProcessKindIdUuidClass ProcessKindIdUuid => _ProcessKindIdUuid ?? (_ProcessKindIdUuid = new Package.ProcessKindIdUuidClass());

	private Package.ProcessAggregateIdOrderNumberClass _ProcessAggregateIdOrderNumber;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.ProcessAggregateIdOrderNumberClass ProcessAggregateIdOrderNumber => _ProcessAggregateIdOrderNumber ?? (_ProcessAggregateIdOrderNumber = new Package.ProcessAggregateIdOrderNumberClass());

	private Package.ProcessKindIdISOStepExecutableClass _ProcessKindIdISOStepExecutable;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.ProcessKindIdISOStepExecutableClass ProcessKindIdISOStepExecutable => _ProcessKindIdISOStepExecutable ?? (_ProcessKindIdISOStepExecutable = new Package.ProcessKindIdISOStepExecutableClass());

	private Package.PartKindIdClass _PartKindId;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.PartKindIdClass PartKindId => _PartKindId ?? (_PartKindId = new Package.PartKindIdClass());

	private Package.ProcessKindIdProcessNameClass _ProcessKindIdProcessName;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.ProcessKindIdProcessNameClass ProcessKindIdProcessName => _ProcessKindIdProcessName ?? (_ProcessKindIdProcessName = new Package.ProcessKindIdProcessNameClass());

	private Package.AdapterURIClass _AdapterURI;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.AdapterURIClass AdapterURI => _AdapterURI ?? (_AdapterURI = new Package.AdapterURIClass());

	private Package.PartKindIdUuidClass _PartKindIdUuid;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.PartKindIdUuidClass PartKindIdUuid => _PartKindIdUuid ?? (_PartKindIdUuid = new Package.PartKindIdUuidClass());

	private Package.DeviceRemovedClass _DeviceRemoved;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.DeviceRemovedClass DeviceRemoved => _DeviceRemoved ?? (_DeviceRemoved = new Package.DeviceRemovedClass());

	private Package.DeviceChangedClass _DeviceChanged;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.DeviceChangedClass DeviceChanged => _DeviceChanged ?? (_DeviceChanged = new Package.DeviceChangedClass());

	private Package.SpecificationLimitClass _SpecificationLimit;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.SpecificationLimitClass SpecificationLimit => _SpecificationLimit ?? (_SpecificationLimit = new Package.SpecificationLimitClass());

	private Package.ConnectionStatusClass _ConnectionStatus;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.ConnectionStatusClass ConnectionStatus => _ConnectionStatus ?? (_ConnectionStatus = new Package.ConnectionStatusClass());

	private Package.PartKindIdPartFamilyClass _PartKindIdPartFamily;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.PartKindIdPartFamilyClass PartKindIdPartFamily => _PartKindIdPartFamily ?? (_PartKindIdPartFamily = new Package.PartKindIdPartFamilyClass());

	private Package.PartKindIdPartNameClass _PartKindIdPartName;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.PartKindIdPartNameClass PartKindIdPartName => _PartKindIdPartName ?? (_PartKindIdPartName = new Package.PartKindIdPartNameClass());

	private Package.AdapterSoftwareVersionClass _AdapterSoftwareVersion;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.AdapterSoftwareVersionClass AdapterSoftwareVersion => _AdapterSoftwareVersion ?? (_AdapterSoftwareVersion = new Package.AdapterSoftwareVersionClass());

	private Package.SensorAttachmentClass _SensorAttachment;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.SensorAttachmentClass SensorAttachment => _SensorAttachment ?? (_SensorAttachment = new Package.SensorAttachmentClass());

	private Package.PartKindIdPartNumberClass _PartKindIdPartNumber;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.PartKindIdPartNumberClass PartKindIdPartNumber => _PartKindIdPartNumber ?? (_PartKindIdPartNumber = new Package.PartKindIdPartNumberClass());

	private Package.PartGroupIdLotClass _PartGroupIdLot;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.PartGroupIdLotClass PartGroupIdLot => _PartGroupIdLot ?? (_PartGroupIdLot = new Package.PartGroupIdLotClass());

	private Package.PartGroupIdRawMaterialClass _PartGroupIdRawMaterial;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.PartGroupIdRawMaterialClass PartGroupIdRawMaterial => _PartGroupIdRawMaterial ?? (_PartGroupIdRawMaterial = new Package.PartGroupIdRawMaterialClass());

	private Package.PartGroupIdBatchClass _PartGroupIdBatch;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.PartGroupIdBatchClass PartGroupIdBatch => _PartGroupIdBatch ?? (_PartGroupIdBatch = new Package.PartGroupIdBatchClass());

	private Package.ControlLimitClass _ControlLimit;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.ControlLimitClass ControlLimit => _ControlLimit ?? (_ControlLimit = new Package.ControlLimitClass());

	private Package.DeviceAddedClass _DeviceAdded;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.DeviceAddedClass DeviceAdded => _DeviceAdded ?? (_DeviceAdded = new Package.DeviceAddedClass());

	private Package.ProcessAggregateIdProcessStepClass _ProcessAggregateIdProcessStep;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.ProcessAggregateIdProcessStepClass ProcessAggregateIdProcessStep => _ProcessAggregateIdProcessStep ?? (_ProcessAggregateIdProcessStep = new Package.ProcessAggregateIdProcessStepClass());

	private Package.MTConnectVersionClass _MTConnectVersion;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.MTConnectVersionClass MTConnectVersion => _MTConnectVersion ?? (_MTConnectVersion = new Package.MTConnectVersionClass());

	private Package.PartUniqueIdSerialNumberClass _PartUniqueIdSerialNumber;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.PartUniqueIdSerialNumberClass PartUniqueIdSerialNumber => _PartUniqueIdSerialNumber ?? (_PartUniqueIdSerialNumber = new Package.PartUniqueIdSerialNumberClass());

	private Package.PartUniqueIdRawMaterialClass _PartUniqueIdRawMaterial;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.PartUniqueIdRawMaterialClass PartUniqueIdRawMaterial => _PartUniqueIdRawMaterial ?? (_PartUniqueIdRawMaterial = new Package.PartUniqueIdRawMaterialClass());

	private Package.PartGroupIdUuidClass _PartGroupIdUuid;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.PartGroupIdUuidClass PartGroupIdUuid => _PartGroupIdUuid ?? (_PartGroupIdUuid = new Package.PartGroupIdUuidClass());

	private Package.ProcessOccurrenceIdClass _ProcessOccurrenceId;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.ProcessOccurrenceIdClass ProcessOccurrenceId => _ProcessOccurrenceId ?? (_ProcessOccurrenceId = new Package.ProcessOccurrenceIdClass());

	private Package.ProcessAggregateIdProcessPlanClass _ProcessAggregateIdProcessPlan;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.ProcessAggregateIdProcessPlanClass ProcessAggregateIdProcessPlan => _ProcessAggregateIdProcessPlan ?? (_ProcessAggregateIdProcessPlan = new Package.ProcessAggregateIdProcessPlanClass());

	private Package.PartUniqueIdUuidClass _PartUniqueIdUuid;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.PartUniqueIdUuidClass PartUniqueIdUuid => _PartUniqueIdUuid ?? (_PartUniqueIdUuid = new Package.PartUniqueIdUuidClass());

	private Package.PartGroupIdClass _PartGroupId;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.PartGroupIdClass PartGroupId => _PartGroupId ?? (_PartGroupId = new Package.PartGroupIdClass());

	private Package.PartGroupIdHeatTreatClass _PartGroupIdHeatTreat;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.PartGroupIdHeatTreatClass PartGroupIdHeatTreat => _PartGroupIdHeatTreat ?? (_PartGroupIdHeatTreat = new Package.PartGroupIdHeatTreatClass());

	private Package.PartUniqueIdClass _PartUniqueId;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.PartUniqueIdClass PartUniqueId => _PartUniqueId ?? (_PartUniqueId = new Package.PartUniqueIdClass());

	private Package.LoadCountRemainingClass _LoadCountRemaining;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.LoadCountRemainingClass LoadCountRemaining => _LoadCountRemaining ?? (_LoadCountRemaining = new Package.LoadCountRemainingClass());

	private Package.ActivationCountTargetClass _ActivationCountTarget;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.ActivationCountTargetClass ActivationCountTarget => _ActivationCountTarget ?? (_ActivationCountTarget = new Package.ActivationCountTargetClass());

	private Package.ActivationCountGoodClass _ActivationCountGood;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.ActivationCountGoodClass ActivationCountGood => _ActivationCountGood ?? (_ActivationCountGood = new Package.ActivationCountGoodClass());

	private Package.TransferCountGoodClass _TransferCountGood;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.TransferCountGoodClass TransferCountGood => _TransferCountGood ?? (_TransferCountGood = new Package.TransferCountGoodClass());

	private Package.CycleCountGoodClass _CycleCountGood;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.CycleCountGoodClass CycleCountGood => _CycleCountGood ?? (_CycleCountGood = new Package.CycleCountGoodClass());

	private Package.ActivationCountClass _ActivationCount;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.ActivationCountClass ActivationCount => _ActivationCount ?? (_ActivationCount = new Package.ActivationCountClass());

	private Package.UnloadCountAbortedClass _UnloadCountAborted;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.UnloadCountAbortedClass UnloadCountAborted => _UnloadCountAborted ?? (_UnloadCountAborted = new Package.UnloadCountAbortedClass());

	private Package.CycleCountRemainingClass _CycleCountRemaining;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.CycleCountRemainingClass CycleCountRemaining => _CycleCountRemaining ?? (_CycleCountRemaining = new Package.CycleCountRemainingClass());

	private Package.DeactivationCountBadClass _DeactivationCountBad;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.DeactivationCountBadClass DeactivationCountBad => _DeactivationCountBad ?? (_DeactivationCountBad = new Package.DeactivationCountBadClass());

	private Package.TransferCountAbortedClass _TransferCountAborted;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.TransferCountAbortedClass TransferCountAborted => _TransferCountAborted ?? (_TransferCountAborted = new Package.TransferCountAbortedClass());

	private Package.DeactivationCountClass _DeactivationCount;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.DeactivationCountClass DeactivationCount => _DeactivationCount ?? (_DeactivationCount = new Package.DeactivationCountClass());

	private Package.ActivationCountBadClass _ActivationCountBad;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.ActivationCountBadClass ActivationCountBad => _ActivationCountBad ?? (_ActivationCountBad = new Package.ActivationCountBadClass());

	private Package.UnloadCountBadClass _UnloadCountBad;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.UnloadCountBadClass UnloadCountBad => _UnloadCountBad ?? (_UnloadCountBad = new Package.UnloadCountBadClass());

	private Package.CycleCountCompleteClass _CycleCountComplete;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.CycleCountCompleteClass CycleCountComplete => _CycleCountComplete ?? (_CycleCountComplete = new Package.CycleCountCompleteClass());

	private Package.TransferCountClass _TransferCount;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.TransferCountClass TransferCount => _TransferCount ?? (_TransferCount = new Package.TransferCountClass());

	private Package.LoadCountBadClass _LoadCountBad;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.LoadCountBadClass LoadCountBad => _LoadCountBad ?? (_LoadCountBad = new Package.LoadCountBadClass());

	private Package.CycleCountAbortedClass _CycleCountAborted;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.CycleCountAbortedClass CycleCountAborted => _CycleCountAborted ?? (_CycleCountAborted = new Package.CycleCountAbortedClass());

	private Package.LoadCountClass _LoadCount;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.LoadCountClass LoadCount => _LoadCount ?? (_LoadCount = new Package.LoadCountClass());

	private Package.TransferCountFailedClass _TransferCountFailed;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.TransferCountFailedClass TransferCountFailed => _TransferCountFailed ?? (_TransferCountFailed = new Package.TransferCountFailedClass());

	private Package.DeactivationCountFailedClass _DeactivationCountFailed;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.DeactivationCountFailedClass DeactivationCountFailed => _DeactivationCountFailed ?? (_DeactivationCountFailed = new Package.DeactivationCountFailedClass());

	private Package.LoadCountFailedClass _LoadCountFailed;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.LoadCountFailedClass LoadCountFailed => _LoadCountFailed ?? (_LoadCountFailed = new Package.LoadCountFailedClass());

	private Package.PartProcessingStateClass _PartProcessingState;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.PartProcessingStateClass PartProcessingState => _PartProcessingState ?? (_PartProcessingState = new Package.PartProcessingStateClass());

	private Package.ActivationCountRemainingClass _ActivationCountRemaining;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.ActivationCountRemainingClass ActivationCountRemaining => _ActivationCountRemaining ?? (_ActivationCountRemaining = new Package.ActivationCountRemainingClass());

	private Package.TransferCountAllClass _TransferCountAll;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.TransferCountAllClass TransferCountAll => _TransferCountAll ?? (_TransferCountAll = new Package.TransferCountAllClass());

	private Package.UnloadCountFailedClass _UnloadCountFailed;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.UnloadCountFailedClass UnloadCountFailed => _UnloadCountFailed ?? (_UnloadCountFailed = new Package.UnloadCountFailedClass());

	private Package.ProcessStateClass _ProcessState;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.ProcessStateClass ProcessState => _ProcessState ?? (_ProcessState = new Package.ProcessStateClass());

	private Package.ActivationCountAbortedClass _ActivationCountAborted;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.ActivationCountAbortedClass ActivationCountAborted => _ActivationCountAborted ?? (_ActivationCountAborted = new Package.ActivationCountAbortedClass());

	private Package.PartCountCompleteClass _PartCountComplete;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.PartCountCompleteClass PartCountComplete => _PartCountComplete ?? (_PartCountComplete = new Package.PartCountCompleteClass());

	private Package.DeactivationCountTargetClass _DeactivationCountTarget;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.DeactivationCountTargetClass DeactivationCountTarget => _DeactivationCountTarget ?? (_DeactivationCountTarget = new Package.DeactivationCountTargetClass());

	private Package.TransferCountBadClass _TransferCountBad;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.TransferCountBadClass TransferCountBad => _TransferCountBad ?? (_TransferCountBad = new Package.TransferCountBadClass());

	private Package.ActivationCountFailedClass _ActivationCountFailed;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.ActivationCountFailedClass ActivationCountFailed => _ActivationCountFailed ?? (_ActivationCountFailed = new Package.ActivationCountFailedClass());

	private Package.TransferCountRemainingClass _TransferCountRemaining;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.TransferCountRemainingClass TransferCountRemaining => _TransferCountRemaining ?? (_TransferCountRemaining = new Package.TransferCountRemainingClass());

	private Package.DeactivationCountCompleteClass _DeactivationCountComplete;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.DeactivationCountCompleteClass DeactivationCountComplete => _DeactivationCountComplete ?? (_DeactivationCountComplete = new Package.DeactivationCountCompleteClass());

	private Package.LoadCountAbortedClass _LoadCountAborted;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.LoadCountAbortedClass LoadCountAborted => _LoadCountAborted ?? (_LoadCountAborted = new Package.LoadCountAbortedClass());

	private Package.UnloadCountGoodClass _UnloadCountGood;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.UnloadCountGoodClass UnloadCountGood => _UnloadCountGood ?? (_UnloadCountGood = new Package.UnloadCountGoodClass());

	private Package.DeactivationCountRemainingClass _DeactivationCountRemaining;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.DeactivationCountRemainingClass DeactivationCountRemaining => _DeactivationCountRemaining ?? (_DeactivationCountRemaining = new Package.DeactivationCountRemainingClass());

	private Package.CycleCountBadClass _CycleCountBad;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.CycleCountBadClass CycleCountBad => _CycleCountBad ?? (_CycleCountBad = new Package.CycleCountBadClass());

	private Package.TransferCountCompleteClass _TransferCountComplete;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.TransferCountCompleteClass TransferCountComplete => _TransferCountComplete ?? (_TransferCountComplete = new Package.TransferCountCompleteClass());

	private Package.UnloadCountCompleteClass _UnloadCountComplete;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.UnloadCountCompleteClass UnloadCountComplete => _UnloadCountComplete ?? (_UnloadCountComplete = new Package.UnloadCountCompleteClass());

	private Package.UnloadCountAllClass _UnloadCountAll;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.UnloadCountAllClass UnloadCountAll => _UnloadCountAll ?? (_UnloadCountAll = new Package.UnloadCountAllClass());

	private Package.ValveStateClass _ValveState;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.ValveStateClass ValveState => _ValveState ?? (_ValveState = new Package.ValveStateClass());

	private Package.CycleCountFailedClass _CycleCountFailed;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.CycleCountFailedClass CycleCountFailed => _CycleCountFailed ?? (_CycleCountFailed = new Package.CycleCountFailedClass());

	private Package.LoadCountAllClass _LoadCountAll;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.LoadCountAllClass LoadCountAll => _LoadCountAll ?? (_LoadCountAll = new Package.LoadCountAllClass());

	private Package.UnloadCountTargetClass _UnloadCountTarget;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.UnloadCountTargetClass UnloadCountTarget => _UnloadCountTarget ?? (_UnloadCountTarget = new Package.UnloadCountTargetClass());

	private Package.ValveStateActualClass _ValveStateActual;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.ValveStateActualClass ValveStateActual => _ValveStateActual ?? (_ValveStateActual = new Package.ValveStateActualClass());

	private Package.TransferCountTargetClass _TransferCountTarget;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.TransferCountTargetClass TransferCountTarget => _TransferCountTarget ?? (_TransferCountTarget = new Package.TransferCountTargetClass());

	private Package.CycleCountTargetClass _CycleCountTarget;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.CycleCountTargetClass CycleCountTarget => _CycleCountTarget ?? (_CycleCountTarget = new Package.CycleCountTargetClass());

	private Package.LockStateClass _LockState;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.LockStateClass LockState => _LockState ?? (_LockState = new Package.LockStateClass());

	private Package.UnloadCountClass _UnloadCount;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.UnloadCountClass UnloadCount => _UnloadCount ?? (_UnloadCount = new Package.UnloadCountClass());

	private Package.PartCountAbortedClass _PartCountAborted;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.PartCountAbortedClass PartCountAborted => _PartCountAborted ?? (_PartCountAborted = new Package.PartCountAbortedClass());

	private Package.ActivationCountCompleteClass _ActivationCountComplete;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.ActivationCountCompleteClass ActivationCountComplete => _ActivationCountComplete ?? (_ActivationCountComplete = new Package.ActivationCountCompleteClass());

	private Package.PartCountFailedClass _PartCountFailed;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.PartCountFailedClass PartCountFailed => _PartCountFailed ?? (_PartCountFailed = new Package.PartCountFailedClass());

	private Package.LoadCountGoodClass _LoadCountGood;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.LoadCountGoodClass LoadCountGood => _LoadCountGood ?? (_LoadCountGood = new Package.LoadCountGoodClass());

	private Package.CycleCountClass _CycleCount;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.CycleCountClass CycleCount => _CycleCount ?? (_CycleCount = new Package.CycleCountClass());

	private Package.CycleCountAllClass _CycleCountAll;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.CycleCountAllClass CycleCountAll => _CycleCountAll ?? (_CycleCountAll = new Package.CycleCountAllClass());

	private Package.LoadCountCompleteClass _LoadCountComplete;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.LoadCountCompleteClass LoadCountComplete => _LoadCountComplete ?? (_LoadCountComplete = new Package.LoadCountCompleteClass());

	private Package.ActivationCountAllClass _ActivationCountAll;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.ActivationCountAllClass ActivationCountAll => _ActivationCountAll ?? (_ActivationCountAll = new Package.ActivationCountAllClass());

	private Package.DeactivationCountAllClass _DeactivationCountAll;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.DeactivationCountAllClass DeactivationCountAll => _DeactivationCountAll ?? (_DeactivationCountAll = new Package.DeactivationCountAllClass());

	private Package.UnloadCountRemainingClass _UnloadCountRemaining;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.UnloadCountRemainingClass UnloadCountRemaining => _UnloadCountRemaining ?? (_UnloadCountRemaining = new Package.UnloadCountRemainingClass());

	private Package.DeactivationCountGoodClass _DeactivationCountGood;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.DeactivationCountGoodClass DeactivationCountGood => _DeactivationCountGood ?? (_DeactivationCountGood = new Package.DeactivationCountGoodClass());

	private Package.LoadCountTargetClass _LoadCountTarget;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.LoadCountTargetClass LoadCountTarget => _LoadCountTarget ?? (_LoadCountTarget = new Package.LoadCountTargetClass());

	private Package.ValveStateProgrammedClass _ValveStateProgrammed;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.ValveStateProgrammedClass ValveStateProgrammed => _ValveStateProgrammed ?? (_ValveStateProgrammed = new Package.ValveStateProgrammedClass());

	private Package.DeactivationCountAbortedClass _DeactivationCountAborted;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.DeactivationCountAbortedClass DeactivationCountAborted => _DeactivationCountAborted ?? (_DeactivationCountAborted = new Package.DeactivationCountAbortedClass());

	private Package.OperatingModeClass _OperatingMode;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.OperatingModeClass OperatingMode => _OperatingMode ?? (_OperatingMode = new Package.OperatingModeClass());

	private Package.AssetCountClass _AssetCount;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.AssetCountClass AssetCount => _AssetCount ?? (_AssetCount = new Package.AssetCountClass());

	private Package.MaintenanceListClass _MaintenanceList;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.MaintenanceListClass MaintenanceList => _MaintenanceList ?? (_MaintenanceList = new Package.MaintenanceListClass());

	private Package.FixtureIdClass _FixtureId;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.FixtureIdClass FixtureId => _FixtureId ?? (_FixtureId = new Package.FixtureIdClass());

	private Package.PartCountTypeClass _PartCountType;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.PartCountTypeClass PartCountType => _PartCountType ?? (_PartCountType = new Package.PartCountTypeClass());

	private Package.ProgramActivityClass _ProgramActivity;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.ProgramActivityClass ProgramActivity => _ProgramActivity ?? (_ProgramActivity = new Package.ProgramActivityClass());

	private Package.ProgramSegmentClass _ProgramSegment;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.ProgramSegmentClass ProgramSegment => _ProgramSegment ?? (_ProgramSegment = new Package.ProgramSegmentClass());

	private Package.ProgramRecipeClass _ProgramRecipe;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.ProgramRecipeClass ProgramRecipe => _ProgramRecipe ?? (_ProgramRecipe = new Package.ProgramRecipeClass());

	private Package.ProgramOperationClass _ProgramOperation;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.ProgramOperationClass ProgramOperation => _ProgramOperation ?? (_ProgramOperation = new Package.ProgramOperationClass());

	private Package.ProcessOccurrenceIdActivityClass _ProcessOccurrenceIdActivity;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.ProcessOccurrenceIdActivityClass ProcessOccurrenceIdActivity => _ProcessOccurrenceIdActivity ?? (_ProcessOccurrenceIdActivity = new Package.ProcessOccurrenceIdActivityClass());

	private Package.ProcessOccurrenceIdSegmentClass _ProcessOccurrenceIdSegment;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.ProcessOccurrenceIdSegmentClass ProcessOccurrenceIdSegment => _ProcessOccurrenceIdSegment ?? (_ProcessOccurrenceIdSegment = new Package.ProcessOccurrenceIdSegmentClass());

	private Package.ProcessOccurrenceIdRecipeClass _ProcessOccurrenceIdRecipe;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.ProcessOccurrenceIdRecipeClass ProcessOccurrenceIdRecipe => _ProcessOccurrenceIdRecipe ?? (_ProcessOccurrenceIdRecipe = new Package.ProcessOccurrenceIdRecipeClass());

	private Package.ProcessOccurrenceIdOperationClass _ProcessOccurrenceIdOperation;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.ProcessOccurrenceIdOperationClass ProcessOccurrenceIdOperation => _ProcessOccurrenceIdOperation ?? (_ProcessOccurrenceIdOperation = new Package.ProcessOccurrenceIdOperationClass());

	private Package.ProgramActiveClass _ProgramActive;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.ProgramActiveClass ProgramActive => _ProgramActive ?? (_ProgramActive = new Package.ProgramActiveClass());

	private Package.ProgramMainClass _ProgramMain;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.ProgramMainClass ProgramMain => _ProgramMain ?? (_ProgramMain = new Package.ProgramMainClass());

	private Package.ProgramScheduleClass _ProgramSchedule;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.ProgramScheduleClass ProgramSchedule => _ProgramSchedule ?? (_ProgramSchedule = new Package.ProgramScheduleClass());

	private Package.ClockTimeClass _ClockTime;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.ClockTimeClass ClockTime => _ClockTime ?? (_ClockTime = new Package.ClockTimeClass());

	private Package.ProgramCommentMainClass _ProgramCommentMain;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.ProgramCommentMainClass ProgramCommentMain => _ProgramCommentMain ?? (_ProgramCommentMain = new Package.ProgramCommentMainClass());

	private Package.ProgramCommentScheduleClass _ProgramCommentSchedule;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.ProgramCommentScheduleClass ProgramCommentSchedule => _ProgramCommentSchedule ?? (_ProgramCommentSchedule = new Package.ProgramCommentScheduleClass());

	private Package.ProgramCommentActiveClass _ProgramCommentActive;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.ProgramCommentActiveClass ProgramCommentActive => _ProgramCommentActive ?? (_ProgramCommentActive = new Package.ProgramCommentActiveClass());

	private Package.NetworkPortClass _NetworkPort;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.NetworkPortClass NetworkPort => _NetworkPort ?? (_NetworkPort = new Package.NetworkPortClass());

	private Package.HostNameClass _HostName;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.HostNameClass HostName => _HostName ?? (_HostName = new Package.HostNameClass());

	private Package.LeakDetectClass _LeakDetect;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.LeakDetectClass LeakDetect => _LeakDetect ?? (_LeakDetect = new Package.LeakDetectClass());

	private Package.BatteryStateClass _BatteryState;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.BatteryStateClass BatteryState => _BatteryState ?? (_BatteryState = new Package.BatteryStateClass());

	private Package.FeaturePersisitentIdClass _FeaturePersisitentId;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.FeaturePersisitentIdClass FeaturePersisitentId => _FeaturePersisitentId ?? (_FeaturePersisitentId = new Package.FeaturePersisitentIdClass());

	private Package.SensorStateClass _SensorState;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.SensorStateClass SensorState => _SensorState ?? (_SensorState = new Package.SensorStateClass());

	private Package.SensorStateBinaryClass _SensorStateBinary;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.SensorStateBinaryClass SensorStateBinary => _SensorStateBinary ?? (_SensorStateBinary = new Package.SensorStateBinaryClass());

	private Package.SensorStateBooleanClass _SensorStateBoolean;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.SensorStateBooleanClass SensorStateBoolean => _SensorStateBoolean ?? (_SensorStateBoolean = new Package.SensorStateBooleanClass());

	private Package.SensorStateEnumeratedClass _SensorStateEnumerated;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.SensorStateEnumeratedClass SensorStateEnumerated => _SensorStateEnumerated ?? (_SensorStateEnumerated = new Package.SensorStateEnumeratedClass());

	private Package.SensorStateDetectClass _SensorStateDetect;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.SensorStateDetectClass SensorStateDetect => _SensorStateDetect ?? (_SensorStateDetect = new Package.SensorStateDetectClass());

	private Package.ComponentDataClass _ComponentData;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.ComponentDataClass ComponentData => _ComponentData ?? (_ComponentData = new Package.ComponentDataClass());

	private Package.WorkOffsetsClass _WorkOffsets;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.WorkOffsetsClass WorkOffsets => _WorkOffsets ?? (_WorkOffsets = new Package.WorkOffsetsClass());

	private Package.ToolOffsetsClass _ToolOffsets;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.ToolOffsetsClass ToolOffsets => _ToolOffsets ?? (_ToolOffsets = new Package.ToolOffsetsClass());

	private Package.FeatureMeasurementClass _FeatureMeasurement;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.FeatureMeasurementClass FeatureMeasurement => _FeatureMeasurement ?? (_FeatureMeasurement = new Package.FeatureMeasurementClass());

	private Package.CharacteristicPersistentIdClass _CharacteristicPersistentId;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.CharacteristicPersistentIdClass CharacteristicPersistentId => _CharacteristicPersistentId ?? (_CharacteristicPersistentId = new Package.CharacteristicPersistentIdClass());

	private Package.MeasurementTypeClass _MeasurementType;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.MeasurementTypeClass MeasurementType => _MeasurementType ?? (_MeasurementType = new Package.MeasurementTypeClass());

	private Package.MeasurementValueClass _MeasurementValue;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.MeasurementValueClass MeasurementValue => _MeasurementValue ?? (_MeasurementValue = new Package.MeasurementValueClass());

	private Package.MeasurementUnitsClass _MeasurementUnits;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.MeasurementUnitsClass MeasurementUnits => _MeasurementUnits ?? (_MeasurementUnits = new Package.MeasurementUnitsClass());

	private Package.CharacteristicStatusClass _CharacteristicStatus;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.CharacteristicStatusClass CharacteristicStatus => _CharacteristicStatus ?? (_CharacteristicStatus = new Package.CharacteristicStatusClass());

	private Package.UncertaintyTypeClass _UncertaintyType;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.UncertaintyTypeClass UncertaintyType => _UncertaintyType ?? (_UncertaintyType = new Package.UncertaintyTypeClass());

	private Package.UncertaintyClass _Uncertainty;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.UncertaintyClass Uncertainty => _Uncertainty ?? (_Uncertainty = new Package.UncertaintyClass());

	private Package.AlarmLimitsClass _AlarmLimits;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.AlarmLimitsClass AlarmLimits => _AlarmLimits ?? (_AlarmLimits = new Package.AlarmLimitsClass());

	private Package.ControlLimitsClass _ControlLimits;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.ControlLimitsClass ControlLimits => _ControlLimits ?? (_ControlLimits = new Package.ControlLimitsClass());

	private Package.SpecificationLimitsClass _SpecificationLimits;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.SpecificationLimitsClass SpecificationLimits => _SpecificationLimits ?? (_SpecificationLimits = new Package.SpecificationLimitsClass());

	private Package.ToolCuttingItemClass _ToolCuttingItem;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.ToolCuttingItemClass ToolCuttingItem => _ToolCuttingItem ?? (_ToolCuttingItem = new Package.ToolCuttingItemClass());

	private Package.HardwareModelClass _HardwareModel;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.HardwareModelClass HardwareModel => _HardwareModel ?? (_HardwareModel = new Package.HardwareModelClass());

	private Package.LocationAddressClass _LocationAddress;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.LocationAddressClass LocationAddress => _LocationAddress ?? (_LocationAddress = new Package.LocationAddressClass());

	private Package.PowerSourceClass _PowerSource;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.PowerSourceClass PowerSource => _PowerSource ?? (_PowerSource = new Package.PowerSourceClass());

	private Package.PowerSourceStandbyClass _PowerSourceStandby;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.PowerSourceStandbyClass PowerSourceStandby => _PowerSourceStandby ?? (_PowerSourceStandby = new Package.PowerSourceStandbyClass());

	private Package.PowerSourceSecondaryClass _PowerSourceSecondary;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.PowerSourceSecondaryClass PowerSourceSecondary => _PowerSourceSecondary ?? (_PowerSourceSecondary = new Package.PowerSourceSecondaryClass());

	private Package.PowerSourcePrimaryClass _PowerSourcePrimary;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.PowerSourcePrimaryClass PowerSourcePrimary => _PowerSourcePrimary ?? (_PowerSourcePrimary = new Package.PowerSourcePrimaryClass());
	}
}