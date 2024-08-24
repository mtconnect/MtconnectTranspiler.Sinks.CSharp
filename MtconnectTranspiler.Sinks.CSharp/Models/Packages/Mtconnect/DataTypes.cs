#pragma warning disable CS1574 // XML comment has cref attribute that could not be resolved
#pragma warning disable CS1584 // XML comment has syntactically incorrect cref attribute
#pragma warning disable CS0618 // Type or member is obsolete
using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;
using Package = Mtconnect.DataTypes;

namespace Mtconnect
{
	/// <summary>﻿<br /><br /><br />
	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Package___19_0_3_45f01b9_1579567325331_179717_33552">model.mtconnect.org</seealso> for more information.
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public class DataTypesPackage : IPackage
	{
		/// <summary>Constant value for <see cref="DataTypesPackage.ReferenceId" /></summary>
		public const string REFERENCE_ID = "_19_0_3_45f01b9_1579567325331_179717_33552";
		/// <summary>Constant value for <see cref="DataTypesPackage.HelpUrl" /></summary>
		public const string HELP_URL = "https://model.mtconnect.org/#Package___19_0_3_45f01b9_1579567325331_179717_33552";
		/// <summary>Constant value for <see cref="DataTypesPackage.Name" /></summary>
		public const string NAME = "DataTypes";
		/// <summary>Constant value for <see cref="DataTypesPackage.Summary" /></summary>
		public const string SUMMARY = @"&#10;&#10;&#10;&#10;
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
			ControlLimitResultClass,
			SpecificationLimitResultClass,
			AlarmLimitResultClass,
			SensorAttachmentResultClass,
			MaintenanceListResultClass,
			FeatureMeasurementResultClass,
			LocationAddressResultClass,
		};
		
		/// <inheritdoc />
		public IEnum[] Enums => new IEnum[] {
			CoordinateSystemEnum,
			ResetTriggerEnum,
			StatisticEnum,
			UnitEnum,
			DataItemTypeEnum,
			CategoryEnum,
			DataItemSubTypeEnum,
			NativeUnitEnum,
			FilterEnum,
			RepresentationEnum,
			ResetTriggeredEnum,
			QualifierEnum,
			SampleEnum,
			EventEnum,
			ConditionEnum,
			MotionActuationTypeEnum,
			MotionTypeEnum,
			CoordinateSystemTypeEnum,
			DataItemRelationshipTypeEnum,
			SpecificationRelationshipTypeEnum,
			MediaTypeEnum,
			OriginatorEnum,
			QIFDocumentTypeEnum,
			ProcessStateEnum,
			AssetTypeEnum,
			ChuckStateEnum,
			AxisCouplingEnum,
			PartStatusEnum,
			DirectionRotaryEnum,
			FileStateEnum,
			CriticalityTypeEnum,
			CompositionStateMotionEnum,
			ActuatorStateEnum,
			ConnectionStatusEnum,
			RoleTypeEnum,
			PathModeEnum,
			CompositionStateActionEnum,
			PartProcessingStateEnum,
			ControllerModeEnum,
			DirectionLinearEnum,
			EndOfBarEnum,
			LocationTypeEnum,
			ValveStateEnum,
			CodeEnum,
			ApplicationCategoryEnum,
			CutterStatusTypeEnum,
			CompositionStateLateralEnum,
			PartDetectEnum,
			ExecutionEnum,
			AvailabilityEnum,
			ProgramEditEnum,
			ControllerModeOverrideEnum,
			FunctionalModeEnum,
			WaitStateEnum,
			RotaryModeEnum,
			CompositionStateSwitchedEnum,
			EmergencyStopEnum,
			LockStateEnum,
			AxisStateEnum,
			InterfaceStateEnum,
			RelationshipTypeEnum,
			FormatTypeEnum,
			CompositionTypeEnum,
			CountDirectionTypeEnum,
			ApplicationTypeEnum,
			FormEnum,
			CompositionStateVerticalEnum,
			RequestStateEnum,
			ResponseStateEnum,
			SpindleInterlockEnum,
			AxisInterlockEnum,
			ChuckInterlockEnum,
			DoorStateEnum,
			EquipmentModeEnum,
			PowerStateEnum,
			ConditionStateEnum,
			ToolLifeEnum,
			OperatingModeEnum,
			ErrorCodeEnum,
			MaintenanceListDirectionEnum,
			MaintenanceListIntervalEnum,
			PartCountTypeEnum,
			AlarmSeverityEnum,
			AlarmStateEnum,
			AlarmCodeEnum,
			DirectionEnum,
			PowerStatusEnum,
			NetworkWirelessEnum,
			ProgramLocationTypeEnum,
			InterfaceEventEnum,
			LeakDetectEnum,
			BatteryStateEnum,
			SensorStateDetectEnum,
			CharacteristicStatusEnum,
			UncertaintyTypeEnum,
			PowerSourceTypeEnum,
		};

		#region Packages
	#endregion

	#region Classes
	private Package.ControlLimitResultClass _ControlLimitResultClass;
	/// <summary>
	/// <inheritdoc cref="Package.ControlLimitResultClass" path="/summary" />
	/// </summary>
	public Package.ControlLimitResultClass ControlLimitResultClass => _ControlLimitResultClass ?? (_ControlLimitResultClass = new Package.ControlLimitResultClass());

	private Package.SpecificationLimitResultClass _SpecificationLimitResultClass;
	/// <summary>
	/// <inheritdoc cref="Package.SpecificationLimitResultClass" path="/summary" />
	/// </summary>
	public Package.SpecificationLimitResultClass SpecificationLimitResultClass => _SpecificationLimitResultClass ?? (_SpecificationLimitResultClass = new Package.SpecificationLimitResultClass());

	private Package.AlarmLimitResultClass _AlarmLimitResultClass;
	/// <summary>
	/// <inheritdoc cref="Package.AlarmLimitResultClass" path="/summary" />
	/// </summary>
	public Package.AlarmLimitResultClass AlarmLimitResultClass => _AlarmLimitResultClass ?? (_AlarmLimitResultClass = new Package.AlarmLimitResultClass());

	private Package.SensorAttachmentResultClass _SensorAttachmentResultClass;
	/// <summary>
	/// <inheritdoc cref="Package.SensorAttachmentResultClass" path="/summary" />
	/// </summary>
	public Package.SensorAttachmentResultClass SensorAttachmentResultClass => _SensorAttachmentResultClass ?? (_SensorAttachmentResultClass = new Package.SensorAttachmentResultClass());

	private Package.MaintenanceListResultClass _MaintenanceListResultClass;
	/// <summary>
	/// <inheritdoc cref="Package.MaintenanceListResultClass" path="/summary" />
	/// </summary>
	public Package.MaintenanceListResultClass MaintenanceListResultClass => _MaintenanceListResultClass ?? (_MaintenanceListResultClass = new Package.MaintenanceListResultClass());

	private Package.FeatureMeasurementResultClass _FeatureMeasurementResultClass;
	/// <summary>
	/// <inheritdoc cref="Package.FeatureMeasurementResultClass" path="/summary" />
	/// </summary>
	public Package.FeatureMeasurementResultClass FeatureMeasurementResultClass => _FeatureMeasurementResultClass ?? (_FeatureMeasurementResultClass = new Package.FeatureMeasurementResultClass());

	private Package.LocationAddressResultClass _LocationAddressResultClass;
	/// <summary>
	/// <inheritdoc cref="Package.LocationAddressResultClass" path="/summary" />
	/// </summary>
	public Package.LocationAddressResultClass LocationAddressResultClass => _LocationAddressResultClass ?? (_LocationAddressResultClass = new Package.LocationAddressResultClass());

	#endregion

	#region Enums
	private Package.CoordinateSystemEnumMetaClass _CoordinateSystemEnum;
	/// <summary>
	/// <inheritdoc cref="Package.CoordinateSystemEnumMetaClass" path="/summary" />
	/// </summary>
	public Package.CoordinateSystemEnumMetaClass CoordinateSystemEnum => _CoordinateSystemEnum ?? (_CoordinateSystemEnum = new Package.CoordinateSystemEnumMetaClass());

	private Package.ResetTriggerEnumMetaClass _ResetTriggerEnum;
	/// <summary>
	/// <inheritdoc cref="Package.ResetTriggerEnumMetaClass" path="/summary" />
	/// </summary>
	public Package.ResetTriggerEnumMetaClass ResetTriggerEnum => _ResetTriggerEnum ?? (_ResetTriggerEnum = new Package.ResetTriggerEnumMetaClass());

	private Package.StatisticEnumMetaClass _StatisticEnum;
	/// <summary>
	/// <inheritdoc cref="Package.StatisticEnumMetaClass" path="/summary" />
	/// </summary>
	public Package.StatisticEnumMetaClass StatisticEnum => _StatisticEnum ?? (_StatisticEnum = new Package.StatisticEnumMetaClass());

	private Package.UnitEnumMetaClass _UnitEnum;
	/// <summary>
	/// <inheritdoc cref="Package.UnitEnumMetaClass" path="/summary" />
	/// </summary>
	public Package.UnitEnumMetaClass UnitEnum => _UnitEnum ?? (_UnitEnum = new Package.UnitEnumMetaClass());

	private Package.DataItemTypeEnumMetaClass _DataItemTypeEnum;
	/// <summary>
	/// <inheritdoc cref="Package.DataItemTypeEnumMetaClass" path="/summary" />
	/// </summary>
	public Package.DataItemTypeEnumMetaClass DataItemTypeEnum => _DataItemTypeEnum ?? (_DataItemTypeEnum = new Package.DataItemTypeEnumMetaClass());

	private Package.CategoryEnumMetaClass _CategoryEnum;
	/// <summary>
	/// <inheritdoc cref="Package.CategoryEnumMetaClass" path="/summary" />
	/// </summary>
	public Package.CategoryEnumMetaClass CategoryEnum => _CategoryEnum ?? (_CategoryEnum = new Package.CategoryEnumMetaClass());

	private Package.DataItemSubTypeEnumMetaClass _DataItemSubTypeEnum;
	/// <summary>
	/// <inheritdoc cref="Package.DataItemSubTypeEnumMetaClass" path="/summary" />
	/// </summary>
	public Package.DataItemSubTypeEnumMetaClass DataItemSubTypeEnum => _DataItemSubTypeEnum ?? (_DataItemSubTypeEnum = new Package.DataItemSubTypeEnumMetaClass());

	private Package.NativeUnitEnumMetaClass _NativeUnitEnum;
	/// <summary>
	/// <inheritdoc cref="Package.NativeUnitEnumMetaClass" path="/summary" />
	/// </summary>
	public Package.NativeUnitEnumMetaClass NativeUnitEnum => _NativeUnitEnum ?? (_NativeUnitEnum = new Package.NativeUnitEnumMetaClass());

	private Package.FilterEnumMetaClass _FilterEnum;
	/// <summary>
	/// <inheritdoc cref="Package.FilterEnumMetaClass" path="/summary" />
	/// </summary>
	public Package.FilterEnumMetaClass FilterEnum => _FilterEnum ?? (_FilterEnum = new Package.FilterEnumMetaClass());

	private Package.RepresentationEnumMetaClass _RepresentationEnum;
	/// <summary>
	/// <inheritdoc cref="Package.RepresentationEnumMetaClass" path="/summary" />
	/// </summary>
	public Package.RepresentationEnumMetaClass RepresentationEnum => _RepresentationEnum ?? (_RepresentationEnum = new Package.RepresentationEnumMetaClass());

	private Package.ResetTriggeredEnumMetaClass _ResetTriggeredEnum;
	/// <summary>
	/// <inheritdoc cref="Package.ResetTriggeredEnumMetaClass" path="/summary" />
	/// </summary>
	public Package.ResetTriggeredEnumMetaClass ResetTriggeredEnum => _ResetTriggeredEnum ?? (_ResetTriggeredEnum = new Package.ResetTriggeredEnumMetaClass());

	private Package.QualifierEnumMetaClass _QualifierEnum;
	/// <summary>
	/// <inheritdoc cref="Package.QualifierEnumMetaClass" path="/summary" />
	/// </summary>
	public Package.QualifierEnumMetaClass QualifierEnum => _QualifierEnum ?? (_QualifierEnum = new Package.QualifierEnumMetaClass());

	private Package.SampleEnumMetaClass _SampleEnum;
	/// <summary>
	/// <inheritdoc cref="Package.SampleEnumMetaClass" path="/summary" />
	/// </summary>
	public Package.SampleEnumMetaClass SampleEnum => _SampleEnum ?? (_SampleEnum = new Package.SampleEnumMetaClass());

	private Package.EventEnumMetaClass _EventEnum;
	/// <summary>
	/// <inheritdoc cref="Package.EventEnumMetaClass" path="/summary" />
	/// </summary>
	public Package.EventEnumMetaClass EventEnum => _EventEnum ?? (_EventEnum = new Package.EventEnumMetaClass());

	private Package.ConditionEnumMetaClass _ConditionEnum;
	/// <summary>
	/// <inheritdoc cref="Package.ConditionEnumMetaClass" path="/summary" />
	/// </summary>
	public Package.ConditionEnumMetaClass ConditionEnum => _ConditionEnum ?? (_ConditionEnum = new Package.ConditionEnumMetaClass());

	private Package.MotionActuationTypeEnumMetaClass _MotionActuationTypeEnum;
	/// <summary>
	/// <inheritdoc cref="Package.MotionActuationTypeEnumMetaClass" path="/summary" />
	/// </summary>
	public Package.MotionActuationTypeEnumMetaClass MotionActuationTypeEnum => _MotionActuationTypeEnum ?? (_MotionActuationTypeEnum = new Package.MotionActuationTypeEnumMetaClass());

	private Package.MotionTypeEnumMetaClass _MotionTypeEnum;
	/// <summary>
	/// <inheritdoc cref="Package.MotionTypeEnumMetaClass" path="/summary" />
	/// </summary>
	public Package.MotionTypeEnumMetaClass MotionTypeEnum => _MotionTypeEnum ?? (_MotionTypeEnum = new Package.MotionTypeEnumMetaClass());

	private Package.CoordinateSystemTypeEnumMetaClass _CoordinateSystemTypeEnum;
	/// <summary>
	/// <inheritdoc cref="Package.CoordinateSystemTypeEnumMetaClass" path="/summary" />
	/// </summary>
	public Package.CoordinateSystemTypeEnumMetaClass CoordinateSystemTypeEnum => _CoordinateSystemTypeEnum ?? (_CoordinateSystemTypeEnum = new Package.CoordinateSystemTypeEnumMetaClass());

	private Package.DataItemRelationshipTypeEnumMetaClass _DataItemRelationshipTypeEnum;
	/// <summary>
	/// <inheritdoc cref="Package.DataItemRelationshipTypeEnumMetaClass" path="/summary" />
	/// </summary>
	public Package.DataItemRelationshipTypeEnumMetaClass DataItemRelationshipTypeEnum => _DataItemRelationshipTypeEnum ?? (_DataItemRelationshipTypeEnum = new Package.DataItemRelationshipTypeEnumMetaClass());

	private Package.SpecificationRelationshipTypeEnumMetaClass _SpecificationRelationshipTypeEnum;
	/// <summary>
	/// <inheritdoc cref="Package.SpecificationRelationshipTypeEnumMetaClass" path="/summary" />
	/// </summary>
	public Package.SpecificationRelationshipTypeEnumMetaClass SpecificationRelationshipTypeEnum => _SpecificationRelationshipTypeEnum ?? (_SpecificationRelationshipTypeEnum = new Package.SpecificationRelationshipTypeEnumMetaClass());

	private Package.MediaTypeEnumMetaClass _MediaTypeEnum;
	/// <summary>
	/// <inheritdoc cref="Package.MediaTypeEnumMetaClass" path="/summary" />
	/// </summary>
	public Package.MediaTypeEnumMetaClass MediaTypeEnum => _MediaTypeEnum ?? (_MediaTypeEnum = new Package.MediaTypeEnumMetaClass());

	private Package.OriginatorEnumMetaClass _OriginatorEnum;
	/// <summary>
	/// <inheritdoc cref="Package.OriginatorEnumMetaClass" path="/summary" />
	/// </summary>
	public Package.OriginatorEnumMetaClass OriginatorEnum => _OriginatorEnum ?? (_OriginatorEnum = new Package.OriginatorEnumMetaClass());

	private Package.QIFDocumentTypeEnumMetaClass _QIFDocumentTypeEnum;
	/// <summary>
	/// <inheritdoc cref="Package.QIFDocumentTypeEnumMetaClass" path="/summary" />
	/// </summary>
	public Package.QIFDocumentTypeEnumMetaClass QIFDocumentTypeEnum => _QIFDocumentTypeEnum ?? (_QIFDocumentTypeEnum = new Package.QIFDocumentTypeEnumMetaClass());

	private Package.ProcessStateEnumMetaClass _ProcessStateEnum;
	/// <summary>
	/// <inheritdoc cref="Package.ProcessStateEnumMetaClass" path="/summary" />
	/// </summary>
	public Package.ProcessStateEnumMetaClass ProcessStateEnum => _ProcessStateEnum ?? (_ProcessStateEnum = new Package.ProcessStateEnumMetaClass());

	private Package.AssetTypeEnumMetaClass _AssetTypeEnum;
	/// <summary>
	/// <inheritdoc cref="Package.AssetTypeEnumMetaClass" path="/summary" />
	/// </summary>
	public Package.AssetTypeEnumMetaClass AssetTypeEnum => _AssetTypeEnum ?? (_AssetTypeEnum = new Package.AssetTypeEnumMetaClass());

	private Package.ChuckStateEnumMetaClass _ChuckStateEnum;
	/// <summary>
	/// <inheritdoc cref="Package.ChuckStateEnumMetaClass" path="/summary" />
	/// </summary>
	public Package.ChuckStateEnumMetaClass ChuckStateEnum => _ChuckStateEnum ?? (_ChuckStateEnum = new Package.ChuckStateEnumMetaClass());

	private Package.AxisCouplingEnumMetaClass _AxisCouplingEnum;
	/// <summary>
	/// <inheritdoc cref="Package.AxisCouplingEnumMetaClass" path="/summary" />
	/// </summary>
	public Package.AxisCouplingEnumMetaClass AxisCouplingEnum => _AxisCouplingEnum ?? (_AxisCouplingEnum = new Package.AxisCouplingEnumMetaClass());

	private Package.PartStatusEnumMetaClass _PartStatusEnum;
	/// <summary>
	/// <inheritdoc cref="Package.PartStatusEnumMetaClass" path="/summary" />
	/// </summary>
	public Package.PartStatusEnumMetaClass PartStatusEnum => _PartStatusEnum ?? (_PartStatusEnum = new Package.PartStatusEnumMetaClass());

	private Package.DirectionRotaryEnumMetaClass _DirectionRotaryEnum;
	/// <summary>
	/// <inheritdoc cref="Package.DirectionRotaryEnumMetaClass" path="/summary" />
	/// </summary>
	public Package.DirectionRotaryEnumMetaClass DirectionRotaryEnum => _DirectionRotaryEnum ?? (_DirectionRotaryEnum = new Package.DirectionRotaryEnumMetaClass());

	private Package.FileStateEnumMetaClass _FileStateEnum;
	/// <summary>
	/// <inheritdoc cref="Package.FileStateEnumMetaClass" path="/summary" />
	/// </summary>
	public Package.FileStateEnumMetaClass FileStateEnum => _FileStateEnum ?? (_FileStateEnum = new Package.FileStateEnumMetaClass());

	private Package.CriticalityTypeEnumMetaClass _CriticalityTypeEnum;
	/// <summary>
	/// <inheritdoc cref="Package.CriticalityTypeEnumMetaClass" path="/summary" />
	/// </summary>
	public Package.CriticalityTypeEnumMetaClass CriticalityTypeEnum => _CriticalityTypeEnum ?? (_CriticalityTypeEnum = new Package.CriticalityTypeEnumMetaClass());

	private Package.CompositionStateMotionEnumMetaClass _CompositionStateMotionEnum;
	/// <summary>
	/// <inheritdoc cref="Package.CompositionStateMotionEnumMetaClass" path="/summary" />
	/// </summary>
	public Package.CompositionStateMotionEnumMetaClass CompositionStateMotionEnum => _CompositionStateMotionEnum ?? (_CompositionStateMotionEnum = new Package.CompositionStateMotionEnumMetaClass());

	private Package.ActuatorStateEnumMetaClass _ActuatorStateEnum;
	/// <summary>
	/// <inheritdoc cref="Package.ActuatorStateEnumMetaClass" path="/summary" />
	/// </summary>
	public Package.ActuatorStateEnumMetaClass ActuatorStateEnum => _ActuatorStateEnum ?? (_ActuatorStateEnum = new Package.ActuatorStateEnumMetaClass());

	private Package.ConnectionStatusEnumMetaClass _ConnectionStatusEnum;
	/// <summary>
	/// <inheritdoc cref="Package.ConnectionStatusEnumMetaClass" path="/summary" />
	/// </summary>
	public Package.ConnectionStatusEnumMetaClass ConnectionStatusEnum => _ConnectionStatusEnum ?? (_ConnectionStatusEnum = new Package.ConnectionStatusEnumMetaClass());

	private Package.RoleTypeEnumMetaClass _RoleTypeEnum;
	/// <summary>
	/// <inheritdoc cref="Package.RoleTypeEnumMetaClass" path="/summary" />
	/// </summary>
	public Package.RoleTypeEnumMetaClass RoleTypeEnum => _RoleTypeEnum ?? (_RoleTypeEnum = new Package.RoleTypeEnumMetaClass());

	private Package.PathModeEnumMetaClass _PathModeEnum;
	/// <summary>
	/// <inheritdoc cref="Package.PathModeEnumMetaClass" path="/summary" />
	/// </summary>
	public Package.PathModeEnumMetaClass PathModeEnum => _PathModeEnum ?? (_PathModeEnum = new Package.PathModeEnumMetaClass());

	private Package.CompositionStateActionEnumMetaClass _CompositionStateActionEnum;
	/// <summary>
	/// <inheritdoc cref="Package.CompositionStateActionEnumMetaClass" path="/summary" />
	/// </summary>
	public Package.CompositionStateActionEnumMetaClass CompositionStateActionEnum => _CompositionStateActionEnum ?? (_CompositionStateActionEnum = new Package.CompositionStateActionEnumMetaClass());

	private Package.PartProcessingStateEnumMetaClass _PartProcessingStateEnum;
	/// <summary>
	/// <inheritdoc cref="Package.PartProcessingStateEnumMetaClass" path="/summary" />
	/// </summary>
	public Package.PartProcessingStateEnumMetaClass PartProcessingStateEnum => _PartProcessingStateEnum ?? (_PartProcessingStateEnum = new Package.PartProcessingStateEnumMetaClass());

	private Package.ControllerModeEnumMetaClass _ControllerModeEnum;
	/// <summary>
	/// <inheritdoc cref="Package.ControllerModeEnumMetaClass" path="/summary" />
	/// </summary>
	public Package.ControllerModeEnumMetaClass ControllerModeEnum => _ControllerModeEnum ?? (_ControllerModeEnum = new Package.ControllerModeEnumMetaClass());

	private Package.DirectionLinearEnumMetaClass _DirectionLinearEnum;
	/// <summary>
	/// <inheritdoc cref="Package.DirectionLinearEnumMetaClass" path="/summary" />
	/// </summary>
	public Package.DirectionLinearEnumMetaClass DirectionLinearEnum => _DirectionLinearEnum ?? (_DirectionLinearEnum = new Package.DirectionLinearEnumMetaClass());

	private Package.EndOfBarEnumMetaClass _EndOfBarEnum;
	/// <summary>
	/// <inheritdoc cref="Package.EndOfBarEnumMetaClass" path="/summary" />
	/// </summary>
	public Package.EndOfBarEnumMetaClass EndOfBarEnum => _EndOfBarEnum ?? (_EndOfBarEnum = new Package.EndOfBarEnumMetaClass());

	private Package.LocationTypeEnumMetaClass _LocationTypeEnum;
	/// <summary>
	/// <inheritdoc cref="Package.LocationTypeEnumMetaClass" path="/summary" />
	/// </summary>
	public Package.LocationTypeEnumMetaClass LocationTypeEnum => _LocationTypeEnum ?? (_LocationTypeEnum = new Package.LocationTypeEnumMetaClass());

	private Package.ValveStateEnumMetaClass _ValveStateEnum;
	/// <summary>
	/// <inheritdoc cref="Package.ValveStateEnumMetaClass" path="/summary" />
	/// </summary>
	public Package.ValveStateEnumMetaClass ValveStateEnum => _ValveStateEnum ?? (_ValveStateEnum = new Package.ValveStateEnumMetaClass());

	private Package.CodeEnumMetaClass _CodeEnum;
	/// <summary>
	/// <inheritdoc cref="Package.CodeEnumMetaClass" path="/summary" />
	/// </summary>
	public Package.CodeEnumMetaClass CodeEnum => _CodeEnum ?? (_CodeEnum = new Package.CodeEnumMetaClass());

	private Package.ApplicationCategoryEnumMetaClass _ApplicationCategoryEnum;
	/// <summary>
	/// <inheritdoc cref="Package.ApplicationCategoryEnumMetaClass" path="/summary" />
	/// </summary>
	public Package.ApplicationCategoryEnumMetaClass ApplicationCategoryEnum => _ApplicationCategoryEnum ?? (_ApplicationCategoryEnum = new Package.ApplicationCategoryEnumMetaClass());

	private Package.CutterStatusTypeEnumMetaClass _CutterStatusTypeEnum;
	/// <summary>
	/// <inheritdoc cref="Package.CutterStatusTypeEnumMetaClass" path="/summary" />
	/// </summary>
	public Package.CutterStatusTypeEnumMetaClass CutterStatusTypeEnum => _CutterStatusTypeEnum ?? (_CutterStatusTypeEnum = new Package.CutterStatusTypeEnumMetaClass());

	private Package.CompositionStateLateralEnumMetaClass _CompositionStateLateralEnum;
	/// <summary>
	/// <inheritdoc cref="Package.CompositionStateLateralEnumMetaClass" path="/summary" />
	/// </summary>
	public Package.CompositionStateLateralEnumMetaClass CompositionStateLateralEnum => _CompositionStateLateralEnum ?? (_CompositionStateLateralEnum = new Package.CompositionStateLateralEnumMetaClass());

	private Package.PartDetectEnumMetaClass _PartDetectEnum;
	/// <summary>
	/// <inheritdoc cref="Package.PartDetectEnumMetaClass" path="/summary" />
	/// </summary>
	public Package.PartDetectEnumMetaClass PartDetectEnum => _PartDetectEnum ?? (_PartDetectEnum = new Package.PartDetectEnumMetaClass());

	private Package.ExecutionEnumMetaClass _ExecutionEnum;
	/// <summary>
	/// <inheritdoc cref="Package.ExecutionEnumMetaClass" path="/summary" />
	/// </summary>
	public Package.ExecutionEnumMetaClass ExecutionEnum => _ExecutionEnum ?? (_ExecutionEnum = new Package.ExecutionEnumMetaClass());

	private Package.AvailabilityEnumMetaClass _AvailabilityEnum;
	/// <summary>
	/// <inheritdoc cref="Package.AvailabilityEnumMetaClass" path="/summary" />
	/// </summary>
	public Package.AvailabilityEnumMetaClass AvailabilityEnum => _AvailabilityEnum ?? (_AvailabilityEnum = new Package.AvailabilityEnumMetaClass());

	private Package.ProgramEditEnumMetaClass _ProgramEditEnum;
	/// <summary>
	/// <inheritdoc cref="Package.ProgramEditEnumMetaClass" path="/summary" />
	/// </summary>
	public Package.ProgramEditEnumMetaClass ProgramEditEnum => _ProgramEditEnum ?? (_ProgramEditEnum = new Package.ProgramEditEnumMetaClass());

	private Package.ControllerModeOverrideEnumMetaClass _ControllerModeOverrideEnum;
	/// <summary>
	/// <inheritdoc cref="Package.ControllerModeOverrideEnumMetaClass" path="/summary" />
	/// </summary>
	public Package.ControllerModeOverrideEnumMetaClass ControllerModeOverrideEnum => _ControllerModeOverrideEnum ?? (_ControllerModeOverrideEnum = new Package.ControllerModeOverrideEnumMetaClass());

	private Package.FunctionalModeEnumMetaClass _FunctionalModeEnum;
	/// <summary>
	/// <inheritdoc cref="Package.FunctionalModeEnumMetaClass" path="/summary" />
	/// </summary>
	public Package.FunctionalModeEnumMetaClass FunctionalModeEnum => _FunctionalModeEnum ?? (_FunctionalModeEnum = new Package.FunctionalModeEnumMetaClass());

	private Package.WaitStateEnumMetaClass _WaitStateEnum;
	/// <summary>
	/// <inheritdoc cref="Package.WaitStateEnumMetaClass" path="/summary" />
	/// </summary>
	public Package.WaitStateEnumMetaClass WaitStateEnum => _WaitStateEnum ?? (_WaitStateEnum = new Package.WaitStateEnumMetaClass());

	private Package.RotaryModeEnumMetaClass _RotaryModeEnum;
	/// <summary>
	/// <inheritdoc cref="Package.RotaryModeEnumMetaClass" path="/summary" />
	/// </summary>
	public Package.RotaryModeEnumMetaClass RotaryModeEnum => _RotaryModeEnum ?? (_RotaryModeEnum = new Package.RotaryModeEnumMetaClass());

	private Package.CompositionStateSwitchedEnumMetaClass _CompositionStateSwitchedEnum;
	/// <summary>
	/// <inheritdoc cref="Package.CompositionStateSwitchedEnumMetaClass" path="/summary" />
	/// </summary>
	public Package.CompositionStateSwitchedEnumMetaClass CompositionStateSwitchedEnum => _CompositionStateSwitchedEnum ?? (_CompositionStateSwitchedEnum = new Package.CompositionStateSwitchedEnumMetaClass());

	private Package.EmergencyStopEnumMetaClass _EmergencyStopEnum;
	/// <summary>
	/// <inheritdoc cref="Package.EmergencyStopEnumMetaClass" path="/summary" />
	/// </summary>
	public Package.EmergencyStopEnumMetaClass EmergencyStopEnum => _EmergencyStopEnum ?? (_EmergencyStopEnum = new Package.EmergencyStopEnumMetaClass());

	private Package.LockStateEnumMetaClass _LockStateEnum;
	/// <summary>
	/// <inheritdoc cref="Package.LockStateEnumMetaClass" path="/summary" />
	/// </summary>
	public Package.LockStateEnumMetaClass LockStateEnum => _LockStateEnum ?? (_LockStateEnum = new Package.LockStateEnumMetaClass());

	private Package.AxisStateEnumMetaClass _AxisStateEnum;
	/// <summary>
	/// <inheritdoc cref="Package.AxisStateEnumMetaClass" path="/summary" />
	/// </summary>
	public Package.AxisStateEnumMetaClass AxisStateEnum => _AxisStateEnum ?? (_AxisStateEnum = new Package.AxisStateEnumMetaClass());

	private Package.InterfaceStateEnumMetaClass _InterfaceStateEnum;
	/// <summary>
	/// <inheritdoc cref="Package.InterfaceStateEnumMetaClass" path="/summary" />
	/// </summary>
	public Package.InterfaceStateEnumMetaClass InterfaceStateEnum => _InterfaceStateEnum ?? (_InterfaceStateEnum = new Package.InterfaceStateEnumMetaClass());

	private Package.RelationshipTypeEnumMetaClass _RelationshipTypeEnum;
	/// <summary>
	/// <inheritdoc cref="Package.RelationshipTypeEnumMetaClass" path="/summary" />
	/// </summary>
	public Package.RelationshipTypeEnumMetaClass RelationshipTypeEnum => _RelationshipTypeEnum ?? (_RelationshipTypeEnum = new Package.RelationshipTypeEnumMetaClass());

	private Package.FormatTypeEnumMetaClass _FormatTypeEnum;
	/// <summary>
	/// <inheritdoc cref="Package.FormatTypeEnumMetaClass" path="/summary" />
	/// </summary>
	public Package.FormatTypeEnumMetaClass FormatTypeEnum => _FormatTypeEnum ?? (_FormatTypeEnum = new Package.FormatTypeEnumMetaClass());

	private Package.CompositionTypeEnumMetaClass _CompositionTypeEnum;
	/// <summary>
	/// <inheritdoc cref="Package.CompositionTypeEnumMetaClass" path="/summary" />
	/// </summary>
	public Package.CompositionTypeEnumMetaClass CompositionTypeEnum => _CompositionTypeEnum ?? (_CompositionTypeEnum = new Package.CompositionTypeEnumMetaClass());

	private Package.CountDirectionTypeEnumMetaClass _CountDirectionTypeEnum;
	/// <summary>
	/// <inheritdoc cref="Package.CountDirectionTypeEnumMetaClass" path="/summary" />
	/// </summary>
	public Package.CountDirectionTypeEnumMetaClass CountDirectionTypeEnum => _CountDirectionTypeEnum ?? (_CountDirectionTypeEnum = new Package.CountDirectionTypeEnumMetaClass());

	private Package.ApplicationTypeEnumMetaClass _ApplicationTypeEnum;
	/// <summary>
	/// <inheritdoc cref="Package.ApplicationTypeEnumMetaClass" path="/summary" />
	/// </summary>
	public Package.ApplicationTypeEnumMetaClass ApplicationTypeEnum => _ApplicationTypeEnum ?? (_ApplicationTypeEnum = new Package.ApplicationTypeEnumMetaClass());

	private Package.FormEnumMetaClass _FormEnum;
	/// <summary>
	/// <inheritdoc cref="Package.FormEnumMetaClass" path="/summary" />
	/// </summary>
	public Package.FormEnumMetaClass FormEnum => _FormEnum ?? (_FormEnum = new Package.FormEnumMetaClass());

	private Package.CompositionStateVerticalEnumMetaClass _CompositionStateVerticalEnum;
	/// <summary>
	/// <inheritdoc cref="Package.CompositionStateVerticalEnumMetaClass" path="/summary" />
	/// </summary>
	public Package.CompositionStateVerticalEnumMetaClass CompositionStateVerticalEnum => _CompositionStateVerticalEnum ?? (_CompositionStateVerticalEnum = new Package.CompositionStateVerticalEnumMetaClass());

	private Package.RequestStateEnumMetaClass _RequestStateEnum;
	/// <summary>
	/// <inheritdoc cref="Package.RequestStateEnumMetaClass" path="/summary" />
	/// </summary>
	public Package.RequestStateEnumMetaClass RequestStateEnum => _RequestStateEnum ?? (_RequestStateEnum = new Package.RequestStateEnumMetaClass());

	private Package.ResponseStateEnumMetaClass _ResponseStateEnum;
	/// <summary>
	/// <inheritdoc cref="Package.ResponseStateEnumMetaClass" path="/summary" />
	/// </summary>
	public Package.ResponseStateEnumMetaClass ResponseStateEnum => _ResponseStateEnum ?? (_ResponseStateEnum = new Package.ResponseStateEnumMetaClass());

	private Package.SpindleInterlockEnumMetaClass _SpindleInterlockEnum;
	/// <summary>
	/// <inheritdoc cref="Package.SpindleInterlockEnumMetaClass" path="/summary" />
	/// </summary>
	public Package.SpindleInterlockEnumMetaClass SpindleInterlockEnum => _SpindleInterlockEnum ?? (_SpindleInterlockEnum = new Package.SpindleInterlockEnumMetaClass());

	private Package.AxisInterlockEnumMetaClass _AxisInterlockEnum;
	/// <summary>
	/// <inheritdoc cref="Package.AxisInterlockEnumMetaClass" path="/summary" />
	/// </summary>
	public Package.AxisInterlockEnumMetaClass AxisInterlockEnum => _AxisInterlockEnum ?? (_AxisInterlockEnum = new Package.AxisInterlockEnumMetaClass());

	private Package.ChuckInterlockEnumMetaClass _ChuckInterlockEnum;
	/// <summary>
	/// <inheritdoc cref="Package.ChuckInterlockEnumMetaClass" path="/summary" />
	/// </summary>
	public Package.ChuckInterlockEnumMetaClass ChuckInterlockEnum => _ChuckInterlockEnum ?? (_ChuckInterlockEnum = new Package.ChuckInterlockEnumMetaClass());

	private Package.DoorStateEnumMetaClass _DoorStateEnum;
	/// <summary>
	/// <inheritdoc cref="Package.DoorStateEnumMetaClass" path="/summary" />
	/// </summary>
	public Package.DoorStateEnumMetaClass DoorStateEnum => _DoorStateEnum ?? (_DoorStateEnum = new Package.DoorStateEnumMetaClass());

	private Package.EquipmentModeEnumMetaClass _EquipmentModeEnum;
	/// <summary>
	/// <inheritdoc cref="Package.EquipmentModeEnumMetaClass" path="/summary" />
	/// </summary>
	public Package.EquipmentModeEnumMetaClass EquipmentModeEnum => _EquipmentModeEnum ?? (_EquipmentModeEnum = new Package.EquipmentModeEnumMetaClass());

	private Package.PowerStateEnumMetaClass _PowerStateEnum;
	/// <summary>
	/// <inheritdoc cref="Package.PowerStateEnumMetaClass" path="/summary" />
	/// </summary>
	public Package.PowerStateEnumMetaClass PowerStateEnum => _PowerStateEnum ?? (_PowerStateEnum = new Package.PowerStateEnumMetaClass());

	private Package.ConditionStateEnumMetaClass _ConditionStateEnum;
	/// <summary>
	/// <inheritdoc cref="Package.ConditionStateEnumMetaClass" path="/summary" />
	/// </summary>
	public Package.ConditionStateEnumMetaClass ConditionStateEnum => _ConditionStateEnum ?? (_ConditionStateEnum = new Package.ConditionStateEnumMetaClass());

	private Package.ToolLifeEnumMetaClass _ToolLifeEnum;
	/// <summary>
	/// <inheritdoc cref="Package.ToolLifeEnumMetaClass" path="/summary" />
	/// </summary>
	public Package.ToolLifeEnumMetaClass ToolLifeEnum => _ToolLifeEnum ?? (_ToolLifeEnum = new Package.ToolLifeEnumMetaClass());

	private Package.OperatingModeEnumMetaClass _OperatingModeEnum;
	/// <summary>
	/// <inheritdoc cref="Package.OperatingModeEnumMetaClass" path="/summary" />
	/// </summary>
	public Package.OperatingModeEnumMetaClass OperatingModeEnum => _OperatingModeEnum ?? (_OperatingModeEnum = new Package.OperatingModeEnumMetaClass());

	private Package.ErrorCodeEnumMetaClass _ErrorCodeEnum;
	/// <summary>
	/// <inheritdoc cref="Package.ErrorCodeEnumMetaClass" path="/summary" />
	/// </summary>
	public Package.ErrorCodeEnumMetaClass ErrorCodeEnum => _ErrorCodeEnum ?? (_ErrorCodeEnum = new Package.ErrorCodeEnumMetaClass());

	private Package.MaintenanceListDirectionEnumMetaClass _MaintenanceListDirectionEnum;
	/// <summary>
	/// <inheritdoc cref="Package.MaintenanceListDirectionEnumMetaClass" path="/summary" />
	/// </summary>
	public Package.MaintenanceListDirectionEnumMetaClass MaintenanceListDirectionEnum => _MaintenanceListDirectionEnum ?? (_MaintenanceListDirectionEnum = new Package.MaintenanceListDirectionEnumMetaClass());

	private Package.MaintenanceListIntervalEnumMetaClass _MaintenanceListIntervalEnum;
	/// <summary>
	/// <inheritdoc cref="Package.MaintenanceListIntervalEnumMetaClass" path="/summary" />
	/// </summary>
	public Package.MaintenanceListIntervalEnumMetaClass MaintenanceListIntervalEnum => _MaintenanceListIntervalEnum ?? (_MaintenanceListIntervalEnum = new Package.MaintenanceListIntervalEnumMetaClass());

	private Package.PartCountTypeEnumMetaClass _PartCountTypeEnum;
	/// <summary>
	/// <inheritdoc cref="Package.PartCountTypeEnumMetaClass" path="/summary" />
	/// </summary>
	public Package.PartCountTypeEnumMetaClass PartCountTypeEnum => _PartCountTypeEnum ?? (_PartCountTypeEnum = new Package.PartCountTypeEnumMetaClass());

	private Package.AlarmSeverityEnumMetaClass _AlarmSeverityEnum;
	/// <summary>
	/// <inheritdoc cref="Package.AlarmSeverityEnumMetaClass" path="/summary" />
	/// </summary>
	public Package.AlarmSeverityEnumMetaClass AlarmSeverityEnum => _AlarmSeverityEnum ?? (_AlarmSeverityEnum = new Package.AlarmSeverityEnumMetaClass());

	private Package.AlarmStateEnumMetaClass _AlarmStateEnum;
	/// <summary>
	/// <inheritdoc cref="Package.AlarmStateEnumMetaClass" path="/summary" />
	/// </summary>
	public Package.AlarmStateEnumMetaClass AlarmStateEnum => _AlarmStateEnum ?? (_AlarmStateEnum = new Package.AlarmStateEnumMetaClass());

	private Package.AlarmCodeEnumMetaClass _AlarmCodeEnum;
	/// <summary>
	/// <inheritdoc cref="Package.AlarmCodeEnumMetaClass" path="/summary" />
	/// </summary>
	public Package.AlarmCodeEnumMetaClass AlarmCodeEnum => _AlarmCodeEnum ?? (_AlarmCodeEnum = new Package.AlarmCodeEnumMetaClass());

	private Package.DirectionEnumMetaClass _DirectionEnum;
	/// <summary>
	/// <inheritdoc cref="Package.DirectionEnumMetaClass" path="/summary" />
	/// </summary>
	public Package.DirectionEnumMetaClass DirectionEnum => _DirectionEnum ?? (_DirectionEnum = new Package.DirectionEnumMetaClass());

	private Package.PowerStatusEnumMetaClass _PowerStatusEnum;
	/// <summary>
	/// <inheritdoc cref="Package.PowerStatusEnumMetaClass" path="/summary" />
	/// </summary>
	public Package.PowerStatusEnumMetaClass PowerStatusEnum => _PowerStatusEnum ?? (_PowerStatusEnum = new Package.PowerStatusEnumMetaClass());

	private Package.NetworkWirelessEnumMetaClass _NetworkWirelessEnum;
	/// <summary>
	/// <inheritdoc cref="Package.NetworkWirelessEnumMetaClass" path="/summary" />
	/// </summary>
	public Package.NetworkWirelessEnumMetaClass NetworkWirelessEnum => _NetworkWirelessEnum ?? (_NetworkWirelessEnum = new Package.NetworkWirelessEnumMetaClass());

	private Package.ProgramLocationTypeEnumMetaClass _ProgramLocationTypeEnum;
	/// <summary>
	/// <inheritdoc cref="Package.ProgramLocationTypeEnumMetaClass" path="/summary" />
	/// </summary>
	public Package.ProgramLocationTypeEnumMetaClass ProgramLocationTypeEnum => _ProgramLocationTypeEnum ?? (_ProgramLocationTypeEnum = new Package.ProgramLocationTypeEnumMetaClass());

	private Package.InterfaceEventEnumMetaClass _InterfaceEventEnum;
	/// <summary>
	/// <inheritdoc cref="Package.InterfaceEventEnumMetaClass" path="/summary" />
	/// </summary>
	public Package.InterfaceEventEnumMetaClass InterfaceEventEnum => _InterfaceEventEnum ?? (_InterfaceEventEnum = new Package.InterfaceEventEnumMetaClass());

	private Package.LeakDetectEnumMetaClass _LeakDetectEnum;
	/// <summary>
	/// <inheritdoc cref="Package.LeakDetectEnumMetaClass" path="/summary" />
	/// </summary>
	public Package.LeakDetectEnumMetaClass LeakDetectEnum => _LeakDetectEnum ?? (_LeakDetectEnum = new Package.LeakDetectEnumMetaClass());

	private Package.BatteryStateEnumMetaClass _BatteryStateEnum;
	/// <summary>
	/// <inheritdoc cref="Package.BatteryStateEnumMetaClass" path="/summary" />
	/// </summary>
	public Package.BatteryStateEnumMetaClass BatteryStateEnum => _BatteryStateEnum ?? (_BatteryStateEnum = new Package.BatteryStateEnumMetaClass());

	private Package.SensorStateDetectEnumMetaClass _SensorStateDetectEnum;
	/// <summary>
	/// <inheritdoc cref="Package.SensorStateDetectEnumMetaClass" path="/summary" />
	/// </summary>
	public Package.SensorStateDetectEnumMetaClass SensorStateDetectEnum => _SensorStateDetectEnum ?? (_SensorStateDetectEnum = new Package.SensorStateDetectEnumMetaClass());

	private Package.CharacteristicStatusEnumMetaClass _CharacteristicStatusEnum;
	/// <summary>
	/// <inheritdoc cref="Package.CharacteristicStatusEnumMetaClass" path="/summary" />
	/// </summary>
	public Package.CharacteristicStatusEnumMetaClass CharacteristicStatusEnum => _CharacteristicStatusEnum ?? (_CharacteristicStatusEnum = new Package.CharacteristicStatusEnumMetaClass());

	private Package.UncertaintyTypeEnumMetaClass _UncertaintyTypeEnum;
	/// <summary>
	/// <inheritdoc cref="Package.UncertaintyTypeEnumMetaClass" path="/summary" />
	/// </summary>
	public Package.UncertaintyTypeEnumMetaClass UncertaintyTypeEnum => _UncertaintyTypeEnum ?? (_UncertaintyTypeEnum = new Package.UncertaintyTypeEnumMetaClass());

	private Package.PowerSourceTypeEnumMetaClass _PowerSourceTypeEnum;
	/// <summary>
	/// <inheritdoc cref="Package.PowerSourceTypeEnumMetaClass" path="/summary" />
	/// </summary>
	public Package.PowerSourceTypeEnumMetaClass PowerSourceTypeEnum => _PowerSourceTypeEnum ?? (_PowerSourceTypeEnum = new Package.PowerSourceTypeEnumMetaClass());

	#endregion
	}
}