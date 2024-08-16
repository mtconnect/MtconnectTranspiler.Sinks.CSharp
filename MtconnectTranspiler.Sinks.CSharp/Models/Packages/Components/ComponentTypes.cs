using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;
using Package = Mtconnect.DeviceInformationModel.Components.ComponentTypes;

namespace Mtconnect.DeviceInformationModel.Components
{
	/// <summary>
	﻿/// This section provides semantic information for the types of <see cref="Component">Component</see>. <br /><br />> Note: In the <i>XML</i> representation, <see cref="Component">Component</see> entities are defined into two major categories:<br /><br />> * <i>top level</i> <see cref="Component">Component</see> entities that <i>organize</i>s the most significant physical or logical functions of a piece of equipment (see <see cref="Part Properties of Device">Part Properties of Device</see>).  They <b>MAY</b> also be used as <i>lower level</i> <see cref="Component">Component</see> entities; as required. See <see cref="Component Organizer Types">Component Organizer Types</see>.<br /><br />> * <i>lower level</i> <see cref="Component">Component</see> entities composed of the sub-parts of the parent <see cref="Component">Component</see> to provide more clarity and granularity to the physical or logical structure of the <i>top level</i> <see cref="Component">Component</see> entities.<br /><br />This section provides guidance for the most common relationships between <see cref="Component">Component</see> types.  However, all <see cref="Component">Component</see> types <b>MAY</b> be used in any configuration, as required, to fully describe a piece of equipment.<br /><br />As described in <see cref="Components">Components</see>, <see cref="Component">Component</see> is an abstract entity and will be always realized by a specific <see cref="Component">Component</see> type.<br/><br />

	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Package__EAPK_6BEE6977_1698_498c_87A6_34B5E656F773">model.mtconnect.org</seealso> for more information.
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public class ComponentTypesPackage : IPackage
	{
		/// <inheritdoc />
		public string ReferenceId => "EAPK_6BEE6977_1698_498c_87A6_34B5E656F773";
		
		/// <inheritdoc />
		public string Name => "Component Types";

		/// <inheritdoc />
		public string Summary => @"&#10;&#10;&#10;This section provides semantic information for the types of {{block(Component)}}. 

> Note: In the {{term(XML)}} representation, {{block(Component)}} entities are defined into two major categories:

> * {{term(top level)}} {{block(Component)}} entities that {{termplural(organize)}} the most significant physical or logical functions of a piece of equipment (see {{sect(Part Properties of Device)}}).  They **MAY** also be used as {{term(lower level)}} {{block(Component)}} entities; as required. See {{package(Component Organizer Types)}}.

> * {{term(lower level)}} {{block(Component)}} entities composed of the sub-parts of the parent {{block(Component)}} to provide more clarity and granularity to the physical or logical structure of the {{term(top level)}} {{block(Component)}} entities.

This section provides guidance for the most common relationships between {{block(Component)}} types.  However, all {{block(Component)}} types **MAY** be used in any configuration, as required, to fully describe a piece of equipment.

As described in {{package(Components)}}, {{block(Component)}} is an abstract entity and will be always realized by a specific {{block(Component)}} type.&#10;
";

		/// <inheritdoc />
		public IPackage[] Packages => new IPackage[] {
			ComponentOrganizerTypesPackage,
		};
		
		/// <inheritdoc />
		public IClass[] Classes => new IClass[] {
			ActuatorClass,
			AuxiliaryClass,
			AxisClass,
			BarFeederClass,
			ControllerClass,
			CoolantClass,
			DepositionClass,
			DielectricClass,
			DoorClass,
			ElectricClass,
			EnclosureClass,
			EndEffectorClass,
			EnvironmentalClass,
			FeederClass,
			HydraulicClass,
			LinearClass,
			LoaderClass,
			LubricationClass,
			MaterialClass,
			PathClass,
			PersonnelClass,
			PneumaticClass,
			PowerClass,
			ProcessPowerClass,
			ProtectiveClass,
			ResourceClass,
			RotaryClass,
			SensorClass,
			StockClass,
			SystemClass,
			ToolingDeliveryClass,
			WasteDisposalClass,
			StructureClass,
			LinkClass,
			GangToolBarClass,
			HeatingClass,
			AutomaticToolChangerClass,
			ProcessClass,
			ToolMagazineClass,
			PartOccurrenceClass,
			AdapterClass,
			ToolRackClass,
			TurretClass,
			VacuumClass,
			CoolingClass,
			ProcessOccurrenceClass,
			PressureClass,
			PartClass,
			LockClass,
			SpindleClass,
			ThermostatClass,
			VibrationClass,
			ChuckClass,
			FanClass,
			SpreaderClass,
			PulleyClass,
			TransferPotClass,
			PowerSupplyClass,
			DrainClass,
			BallscrewClass,
			CompressorClass,
			ChuteClass,
			SwitchClass,
			TensionerClass,
			WaterClass,
			WireClass,
			SensingElementClass,
			CoolingTowerClass,
			RemovalPotClass,
			GripperClass,
			StagingPotClass,
			BrakeClass,
			StationClass,
			HopperClass,
			BeltClass,
			TransferArmClass,
			ReelClass,
			FilterClass,
			ReturnPotClass,
			ChainClass,
			AmplifierClass,
			VatClass,
			ExpiredPotClass,
			OilClass,
			TableClass,
			ChopperClass,
			ValveClass,
			PotClass,
			TransformerClass,
			ExposureUnitClass,
			TankClass,
			EncoderClass,
			StorageBatteryClass,
			CircuitBreakerClass,
			MotorClass,
			ExtrusionUnitClass,
			GalvanomotorClass,
			PumpClass,
			ClampClass,
			LinearPositionFeedbackClass,
			WorkpieceClass,
			WorkEnvelopeClass,
			FeatureOccurrenceClass,
			AirHandlerClass,
		};
		#region Packages
	private Package.ComponentOrganizerTypesPackage _ComponentOrganizerTypesPackage;
	/// <summary>
	/// <inheritdoc cref="Package.ComponentOrganizerTypesPackage" path="/summary" />
	/// </summary>
	public Package.ComponentOrganizerTypesPackage ComponentOrganizerTypesPackage => _ComponentOrganizerTypesPackage ?? (_ComponentOrganizerTypesPackage = new Package.ComponentOrganizerTypesPackage());

	#endregion

	#region Classes
	private Package.ActuatorClass _ActuatorClass;
	/// <summary>
	/// <inheritdoc cref="Package.ActuatorClass" path="/summary" />
	/// </summary>
	public Package.ActuatorClass ActuatorClass => _ActuatorClass ?? (_ActuatorClass = new Package.ActuatorClass());

	private Package.AuxiliaryClass _AuxiliaryClass;
	/// <summary>
	/// <inheritdoc cref="Package.AuxiliaryClass" path="/summary" />
	/// </summary>
	public Package.AuxiliaryClass AuxiliaryClass => _AuxiliaryClass ?? (_AuxiliaryClass = new Package.AuxiliaryClass());

	private Package.AxisClass _AxisClass;
	/// <summary>
	/// <inheritdoc cref="Package.AxisClass" path="/summary" />
	/// </summary>
	public Package.AxisClass AxisClass => _AxisClass ?? (_AxisClass = new Package.AxisClass());

	private Package.BarFeederClass _BarFeederClass;
	/// <summary>
	/// <inheritdoc cref="Package.BarFeederClass" path="/summary" />
	/// </summary>
	public Package.BarFeederClass BarFeederClass => _BarFeederClass ?? (_BarFeederClass = new Package.BarFeederClass());

	private Package.ControllerClass _ControllerClass;
	/// <summary>
	/// <inheritdoc cref="Package.ControllerClass" path="/summary" />
	/// </summary>
	public Package.ControllerClass ControllerClass => _ControllerClass ?? (_ControllerClass = new Package.ControllerClass());

	private Package.CoolantClass _CoolantClass;
	/// <summary>
	/// <inheritdoc cref="Package.CoolantClass" path="/summary" />
	/// </summary>
	public Package.CoolantClass CoolantClass => _CoolantClass ?? (_CoolantClass = new Package.CoolantClass());

	private Package.DepositionClass _DepositionClass;
	/// <summary>
	/// <inheritdoc cref="Package.DepositionClass" path="/summary" />
	/// </summary>
	public Package.DepositionClass DepositionClass => _DepositionClass ?? (_DepositionClass = new Package.DepositionClass());

	private Package.DielectricClass _DielectricClass;
	/// <summary>
	/// <inheritdoc cref="Package.DielectricClass" path="/summary" />
	/// </summary>
	public Package.DielectricClass DielectricClass => _DielectricClass ?? (_DielectricClass = new Package.DielectricClass());

	private Package.DoorClass _DoorClass;
	/// <summary>
	/// <inheritdoc cref="Package.DoorClass" path="/summary" />
	/// </summary>
	public Package.DoorClass DoorClass => _DoorClass ?? (_DoorClass = new Package.DoorClass());

	private Package.ElectricClass _ElectricClass;
	/// <summary>
	/// <inheritdoc cref="Package.ElectricClass" path="/summary" />
	/// </summary>
	public Package.ElectricClass ElectricClass => _ElectricClass ?? (_ElectricClass = new Package.ElectricClass());

	private Package.EnclosureClass _EnclosureClass;
	/// <summary>
	/// <inheritdoc cref="Package.EnclosureClass" path="/summary" />
	/// </summary>
	public Package.EnclosureClass EnclosureClass => _EnclosureClass ?? (_EnclosureClass = new Package.EnclosureClass());

	private Package.EndEffectorClass _EndEffectorClass;
	/// <summary>
	/// <inheritdoc cref="Package.EndEffectorClass" path="/summary" />
	/// </summary>
	public Package.EndEffectorClass EndEffectorClass => _EndEffectorClass ?? (_EndEffectorClass = new Package.EndEffectorClass());

	private Package.EnvironmentalClass _EnvironmentalClass;
	/// <summary>
	/// <inheritdoc cref="Package.EnvironmentalClass" path="/summary" />
	/// </summary>
	public Package.EnvironmentalClass EnvironmentalClass => _EnvironmentalClass ?? (_EnvironmentalClass = new Package.EnvironmentalClass());

	private Package.FeederClass _FeederClass;
	/// <summary>
	/// <inheritdoc cref="Package.FeederClass" path="/summary" />
	/// </summary>
	public Package.FeederClass FeederClass => _FeederClass ?? (_FeederClass = new Package.FeederClass());

	private Package.HydraulicClass _HydraulicClass;
	/// <summary>
	/// <inheritdoc cref="Package.HydraulicClass" path="/summary" />
	/// </summary>
	public Package.HydraulicClass HydraulicClass => _HydraulicClass ?? (_HydraulicClass = new Package.HydraulicClass());

	private Package.LinearClass _LinearClass;
	/// <summary>
	/// <inheritdoc cref="Package.LinearClass" path="/summary" />
	/// </summary>
	public Package.LinearClass LinearClass => _LinearClass ?? (_LinearClass = new Package.LinearClass());

	private Package.LoaderClass _LoaderClass;
	/// <summary>
	/// <inheritdoc cref="Package.LoaderClass" path="/summary" />
	/// </summary>
	public Package.LoaderClass LoaderClass => _LoaderClass ?? (_LoaderClass = new Package.LoaderClass());

	private Package.LubricationClass _LubricationClass;
	/// <summary>
	/// <inheritdoc cref="Package.LubricationClass" path="/summary" />
	/// </summary>
	public Package.LubricationClass LubricationClass => _LubricationClass ?? (_LubricationClass = new Package.LubricationClass());

	private Package.MaterialClass _MaterialClass;
	/// <summary>
	/// <inheritdoc cref="Package.MaterialClass" path="/summary" />
	/// </summary>
	public Package.MaterialClass MaterialClass => _MaterialClass ?? (_MaterialClass = new Package.MaterialClass());

	private Package.PathClass _PathClass;
	/// <summary>
	/// <inheritdoc cref="Package.PathClass" path="/summary" />
	/// </summary>
	public Package.PathClass PathClass => _PathClass ?? (_PathClass = new Package.PathClass());

	private Package.PersonnelClass _PersonnelClass;
	/// <summary>
	/// <inheritdoc cref="Package.PersonnelClass" path="/summary" />
	/// </summary>
	public Package.PersonnelClass PersonnelClass => _PersonnelClass ?? (_PersonnelClass = new Package.PersonnelClass());

	private Package.PneumaticClass _PneumaticClass;
	/// <summary>
	/// <inheritdoc cref="Package.PneumaticClass" path="/summary" />
	/// </summary>
	public Package.PneumaticClass PneumaticClass => _PneumaticClass ?? (_PneumaticClass = new Package.PneumaticClass());

	private Package.PowerClass _PowerClass;
	/// <summary>
	/// <inheritdoc cref="Package.PowerClass" path="/summary" />
	/// </summary>
	public Package.PowerClass PowerClass => _PowerClass ?? (_PowerClass = new Package.PowerClass());

	private Package.ProcessPowerClass _ProcessPowerClass;
	/// <summary>
	/// <inheritdoc cref="Package.ProcessPowerClass" path="/summary" />
	/// </summary>
	public Package.ProcessPowerClass ProcessPowerClass => _ProcessPowerClass ?? (_ProcessPowerClass = new Package.ProcessPowerClass());

	private Package.ProtectiveClass _ProtectiveClass;
	/// <summary>
	/// <inheritdoc cref="Package.ProtectiveClass" path="/summary" />
	/// </summary>
	public Package.ProtectiveClass ProtectiveClass => _ProtectiveClass ?? (_ProtectiveClass = new Package.ProtectiveClass());

	private Package.ResourceClass _ResourceClass;
	/// <summary>
	/// <inheritdoc cref="Package.ResourceClass" path="/summary" />
	/// </summary>
	public Package.ResourceClass ResourceClass => _ResourceClass ?? (_ResourceClass = new Package.ResourceClass());

	private Package.RotaryClass _RotaryClass;
	/// <summary>
	/// <inheritdoc cref="Package.RotaryClass" path="/summary" />
	/// </summary>
	public Package.RotaryClass RotaryClass => _RotaryClass ?? (_RotaryClass = new Package.RotaryClass());

	private Package.SensorClass _SensorClass;
	/// <summary>
	/// <inheritdoc cref="Package.SensorClass" path="/summary" />
	/// </summary>
	public Package.SensorClass SensorClass => _SensorClass ?? (_SensorClass = new Package.SensorClass());

	private Package.StockClass _StockClass;
	/// <summary>
	/// <inheritdoc cref="Package.StockClass" path="/summary" />
	/// </summary>
	public Package.StockClass StockClass => _StockClass ?? (_StockClass = new Package.StockClass());

	private Package.SystemClass _SystemClass;
	/// <summary>
	/// <inheritdoc cref="Package.SystemClass" path="/summary" />
	/// </summary>
	public Package.SystemClass SystemClass => _SystemClass ?? (_SystemClass = new Package.SystemClass());

	private Package.ToolingDeliveryClass _ToolingDeliveryClass;
	/// <summary>
	/// <inheritdoc cref="Package.ToolingDeliveryClass" path="/summary" />
	/// </summary>
	public Package.ToolingDeliveryClass ToolingDeliveryClass => _ToolingDeliveryClass ?? (_ToolingDeliveryClass = new Package.ToolingDeliveryClass());

	private Package.WasteDisposalClass _WasteDisposalClass;
	/// <summary>
	/// <inheritdoc cref="Package.WasteDisposalClass" path="/summary" />
	/// </summary>
	public Package.WasteDisposalClass WasteDisposalClass => _WasteDisposalClass ?? (_WasteDisposalClass = new Package.WasteDisposalClass());

	private Package.StructureClass _StructureClass;
	/// <summary>
	/// <inheritdoc cref="Package.StructureClass" path="/summary" />
	/// </summary>
	public Package.StructureClass StructureClass => _StructureClass ?? (_StructureClass = new Package.StructureClass());

	private Package.LinkClass _LinkClass;
	/// <summary>
	/// <inheritdoc cref="Package.LinkClass" path="/summary" />
	/// </summary>
	public Package.LinkClass LinkClass => _LinkClass ?? (_LinkClass = new Package.LinkClass());

	private Package.GangToolBarClass _GangToolBarClass;
	/// <summary>
	/// <inheritdoc cref="Package.GangToolBarClass" path="/summary" />
	/// </summary>
	public Package.GangToolBarClass GangToolBarClass => _GangToolBarClass ?? (_GangToolBarClass = new Package.GangToolBarClass());

	private Package.HeatingClass _HeatingClass;
	/// <summary>
	/// <inheritdoc cref="Package.HeatingClass" path="/summary" />
	/// </summary>
	public Package.HeatingClass HeatingClass => _HeatingClass ?? (_HeatingClass = new Package.HeatingClass());

	private Package.AutomaticToolChangerClass _AutomaticToolChangerClass;
	/// <summary>
	/// <inheritdoc cref="Package.AutomaticToolChangerClass" path="/summary" />
	/// </summary>
	public Package.AutomaticToolChangerClass AutomaticToolChangerClass => _AutomaticToolChangerClass ?? (_AutomaticToolChangerClass = new Package.AutomaticToolChangerClass());

	private Package.ProcessClass _ProcessClass;
	/// <summary>
	/// <inheritdoc cref="Package.ProcessClass" path="/summary" />
	/// </summary>
	public Package.ProcessClass ProcessClass => _ProcessClass ?? (_ProcessClass = new Package.ProcessClass());

	private Package.ToolMagazineClass _ToolMagazineClass;
	/// <summary>
	/// <inheritdoc cref="Package.ToolMagazineClass" path="/summary" />
	/// </summary>
	public Package.ToolMagazineClass ToolMagazineClass => _ToolMagazineClass ?? (_ToolMagazineClass = new Package.ToolMagazineClass());

	private Package.PartOccurrenceClass _PartOccurrenceClass;
	/// <summary>
	/// <inheritdoc cref="Package.PartOccurrenceClass" path="/summary" />
	/// </summary>
	public Package.PartOccurrenceClass PartOccurrenceClass => _PartOccurrenceClass ?? (_PartOccurrenceClass = new Package.PartOccurrenceClass());

	private Package.AdapterClass _AdapterClass;
	/// <summary>
	/// <inheritdoc cref="Package.AdapterClass" path="/summary" />
	/// </summary>
	public Package.AdapterClass AdapterClass => _AdapterClass ?? (_AdapterClass = new Package.AdapterClass());

	private Package.ToolRackClass _ToolRackClass;
	/// <summary>
	/// <inheritdoc cref="Package.ToolRackClass" path="/summary" />
	/// </summary>
	public Package.ToolRackClass ToolRackClass => _ToolRackClass ?? (_ToolRackClass = new Package.ToolRackClass());

	private Package.TurretClass _TurretClass;
	/// <summary>
	/// <inheritdoc cref="Package.TurretClass" path="/summary" />
	/// </summary>
	public Package.TurretClass TurretClass => _TurretClass ?? (_TurretClass = new Package.TurretClass());

	private Package.VacuumClass _VacuumClass;
	/// <summary>
	/// <inheritdoc cref="Package.VacuumClass" path="/summary" />
	/// </summary>
	public Package.VacuumClass VacuumClass => _VacuumClass ?? (_VacuumClass = new Package.VacuumClass());

	private Package.CoolingClass _CoolingClass;
	/// <summary>
	/// <inheritdoc cref="Package.CoolingClass" path="/summary" />
	/// </summary>
	public Package.CoolingClass CoolingClass => _CoolingClass ?? (_CoolingClass = new Package.CoolingClass());

	private Package.ProcessOccurrenceClass _ProcessOccurrenceClass;
	/// <summary>
	/// <inheritdoc cref="Package.ProcessOccurrenceClass" path="/summary" />
	/// </summary>
	public Package.ProcessOccurrenceClass ProcessOccurrenceClass => _ProcessOccurrenceClass ?? (_ProcessOccurrenceClass = new Package.ProcessOccurrenceClass());

	private Package.PressureClass _PressureClass;
	/// <summary>
	/// <inheritdoc cref="Package.PressureClass" path="/summary" />
	/// </summary>
	public Package.PressureClass PressureClass => _PressureClass ?? (_PressureClass = new Package.PressureClass());

	private Package.PartClass _PartClass;
	/// <summary>
	/// <inheritdoc cref="Package.PartClass" path="/summary" />
	/// </summary>
	public Package.PartClass PartClass => _PartClass ?? (_PartClass = new Package.PartClass());

	private Package.LockClass _LockClass;
	/// <summary>
	/// <inheritdoc cref="Package.LockClass" path="/summary" />
	/// </summary>
	public Package.LockClass LockClass => _LockClass ?? (_LockClass = new Package.LockClass());

	private Package.SpindleClass _SpindleClass;
	/// <summary>
	/// <inheritdoc cref="Package.SpindleClass" path="/summary" />
	/// </summary>
	public Package.SpindleClass SpindleClass => _SpindleClass ?? (_SpindleClass = new Package.SpindleClass());

	private Package.ThermostatClass _ThermostatClass;
	/// <summary>
	/// <inheritdoc cref="Package.ThermostatClass" path="/summary" />
	/// </summary>
	public Package.ThermostatClass ThermostatClass => _ThermostatClass ?? (_ThermostatClass = new Package.ThermostatClass());

	private Package.VibrationClass _VibrationClass;
	/// <summary>
	/// <inheritdoc cref="Package.VibrationClass" path="/summary" />
	/// </summary>
	public Package.VibrationClass VibrationClass => _VibrationClass ?? (_VibrationClass = new Package.VibrationClass());

	private Package.ChuckClass _ChuckClass;
	/// <summary>
	/// <inheritdoc cref="Package.ChuckClass" path="/summary" />
	/// </summary>
	public Package.ChuckClass ChuckClass => _ChuckClass ?? (_ChuckClass = new Package.ChuckClass());

	private Package.FanClass _FanClass;
	/// <summary>
	/// <inheritdoc cref="Package.FanClass" path="/summary" />
	/// </summary>
	public Package.FanClass FanClass => _FanClass ?? (_FanClass = new Package.FanClass());

	private Package.SpreaderClass _SpreaderClass;
	/// <summary>
	/// <inheritdoc cref="Package.SpreaderClass" path="/summary" />
	/// </summary>
	public Package.SpreaderClass SpreaderClass => _SpreaderClass ?? (_SpreaderClass = new Package.SpreaderClass());

	private Package.PulleyClass _PulleyClass;
	/// <summary>
	/// <inheritdoc cref="Package.PulleyClass" path="/summary" />
	/// </summary>
	public Package.PulleyClass PulleyClass => _PulleyClass ?? (_PulleyClass = new Package.PulleyClass());

	private Package.TransferPotClass _TransferPotClass;
	/// <summary>
	/// <inheritdoc cref="Package.TransferPotClass" path="/summary" />
	/// </summary>
	public Package.TransferPotClass TransferPotClass => _TransferPotClass ?? (_TransferPotClass = new Package.TransferPotClass());

	private Package.PowerSupplyClass _PowerSupplyClass;
	/// <summary>
	/// <inheritdoc cref="Package.PowerSupplyClass" path="/summary" />
	/// </summary>
	public Package.PowerSupplyClass PowerSupplyClass => _PowerSupplyClass ?? (_PowerSupplyClass = new Package.PowerSupplyClass());

	private Package.DrainClass _DrainClass;
	/// <summary>
	/// <inheritdoc cref="Package.DrainClass" path="/summary" />
	/// </summary>
	public Package.DrainClass DrainClass => _DrainClass ?? (_DrainClass = new Package.DrainClass());

	private Package.BallscrewClass _BallscrewClass;
	/// <summary>
	/// <inheritdoc cref="Package.BallscrewClass" path="/summary" />
	/// </summary>
	public Package.BallscrewClass BallscrewClass => _BallscrewClass ?? (_BallscrewClass = new Package.BallscrewClass());

	private Package.CompressorClass _CompressorClass;
	/// <summary>
	/// <inheritdoc cref="Package.CompressorClass" path="/summary" />
	/// </summary>
	public Package.CompressorClass CompressorClass => _CompressorClass ?? (_CompressorClass = new Package.CompressorClass());

	private Package.ChuteClass _ChuteClass;
	/// <summary>
	/// <inheritdoc cref="Package.ChuteClass" path="/summary" />
	/// </summary>
	public Package.ChuteClass ChuteClass => _ChuteClass ?? (_ChuteClass = new Package.ChuteClass());

	private Package.SwitchClass _SwitchClass;
	/// <summary>
	/// <inheritdoc cref="Package.SwitchClass" path="/summary" />
	/// </summary>
	public Package.SwitchClass SwitchClass => _SwitchClass ?? (_SwitchClass = new Package.SwitchClass());

	private Package.TensionerClass _TensionerClass;
	/// <summary>
	/// <inheritdoc cref="Package.TensionerClass" path="/summary" />
	/// </summary>
	public Package.TensionerClass TensionerClass => _TensionerClass ?? (_TensionerClass = new Package.TensionerClass());

	private Package.WaterClass _WaterClass;
	/// <summary>
	/// <inheritdoc cref="Package.WaterClass" path="/summary" />
	/// </summary>
	public Package.WaterClass WaterClass => _WaterClass ?? (_WaterClass = new Package.WaterClass());

	private Package.WireClass _WireClass;
	/// <summary>
	/// <inheritdoc cref="Package.WireClass" path="/summary" />
	/// </summary>
	public Package.WireClass WireClass => _WireClass ?? (_WireClass = new Package.WireClass());

	private Package.SensingElementClass _SensingElementClass;
	/// <summary>
	/// <inheritdoc cref="Package.SensingElementClass" path="/summary" />
	/// </summary>
	public Package.SensingElementClass SensingElementClass => _SensingElementClass ?? (_SensingElementClass = new Package.SensingElementClass());

	private Package.CoolingTowerClass _CoolingTowerClass;
	/// <summary>
	/// <inheritdoc cref="Package.CoolingTowerClass" path="/summary" />
	/// </summary>
	public Package.CoolingTowerClass CoolingTowerClass => _CoolingTowerClass ?? (_CoolingTowerClass = new Package.CoolingTowerClass());

	private Package.RemovalPotClass _RemovalPotClass;
	/// <summary>
	/// <inheritdoc cref="Package.RemovalPotClass" path="/summary" />
	/// </summary>
	public Package.RemovalPotClass RemovalPotClass => _RemovalPotClass ?? (_RemovalPotClass = new Package.RemovalPotClass());

	private Package.GripperClass _GripperClass;
	/// <summary>
	/// <inheritdoc cref="Package.GripperClass" path="/summary" />
	/// </summary>
	public Package.GripperClass GripperClass => _GripperClass ?? (_GripperClass = new Package.GripperClass());

	private Package.StagingPotClass _StagingPotClass;
	/// <summary>
	/// <inheritdoc cref="Package.StagingPotClass" path="/summary" />
	/// </summary>
	public Package.StagingPotClass StagingPotClass => _StagingPotClass ?? (_StagingPotClass = new Package.StagingPotClass());

	private Package.BrakeClass _BrakeClass;
	/// <summary>
	/// <inheritdoc cref="Package.BrakeClass" path="/summary" />
	/// </summary>
	public Package.BrakeClass BrakeClass => _BrakeClass ?? (_BrakeClass = new Package.BrakeClass());

	private Package.StationClass _StationClass;
	/// <summary>
	/// <inheritdoc cref="Package.StationClass" path="/summary" />
	/// </summary>
	public Package.StationClass StationClass => _StationClass ?? (_StationClass = new Package.StationClass());

	private Package.HopperClass _HopperClass;
	/// <summary>
	/// <inheritdoc cref="Package.HopperClass" path="/summary" />
	/// </summary>
	public Package.HopperClass HopperClass => _HopperClass ?? (_HopperClass = new Package.HopperClass());

	private Package.BeltClass _BeltClass;
	/// <summary>
	/// <inheritdoc cref="Package.BeltClass" path="/summary" />
	/// </summary>
	public Package.BeltClass BeltClass => _BeltClass ?? (_BeltClass = new Package.BeltClass());

	private Package.TransferArmClass _TransferArmClass;
	/// <summary>
	/// <inheritdoc cref="Package.TransferArmClass" path="/summary" />
	/// </summary>
	public Package.TransferArmClass TransferArmClass => _TransferArmClass ?? (_TransferArmClass = new Package.TransferArmClass());

	private Package.ReelClass _ReelClass;
	/// <summary>
	/// <inheritdoc cref="Package.ReelClass" path="/summary" />
	/// </summary>
	public Package.ReelClass ReelClass => _ReelClass ?? (_ReelClass = new Package.ReelClass());

	private Package.FilterClass _FilterClass;
	/// <summary>
	/// <inheritdoc cref="Package.FilterClass" path="/summary" />
	/// </summary>
	public Package.FilterClass FilterClass => _FilterClass ?? (_FilterClass = new Package.FilterClass());

	private Package.ReturnPotClass _ReturnPotClass;
	/// <summary>
	/// <inheritdoc cref="Package.ReturnPotClass" path="/summary" />
	/// </summary>
	public Package.ReturnPotClass ReturnPotClass => _ReturnPotClass ?? (_ReturnPotClass = new Package.ReturnPotClass());

	private Package.ChainClass _ChainClass;
	/// <summary>
	/// <inheritdoc cref="Package.ChainClass" path="/summary" />
	/// </summary>
	public Package.ChainClass ChainClass => _ChainClass ?? (_ChainClass = new Package.ChainClass());

	private Package.AmplifierClass _AmplifierClass;
	/// <summary>
	/// <inheritdoc cref="Package.AmplifierClass" path="/summary" />
	/// </summary>
	public Package.AmplifierClass AmplifierClass => _AmplifierClass ?? (_AmplifierClass = new Package.AmplifierClass());

	private Package.VatClass _VatClass;
	/// <summary>
	/// <inheritdoc cref="Package.VatClass" path="/summary" />
	/// </summary>
	public Package.VatClass VatClass => _VatClass ?? (_VatClass = new Package.VatClass());

	private Package.ExpiredPotClass _ExpiredPotClass;
	/// <summary>
	/// <inheritdoc cref="Package.ExpiredPotClass" path="/summary" />
	/// </summary>
	public Package.ExpiredPotClass ExpiredPotClass => _ExpiredPotClass ?? (_ExpiredPotClass = new Package.ExpiredPotClass());

	private Package.OilClass _OilClass;
	/// <summary>
	/// <inheritdoc cref="Package.OilClass" path="/summary" />
	/// </summary>
	public Package.OilClass OilClass => _OilClass ?? (_OilClass = new Package.OilClass());

	private Package.TableClass _TableClass;
	/// <summary>
	/// <inheritdoc cref="Package.TableClass" path="/summary" />
	/// </summary>
	public Package.TableClass TableClass => _TableClass ?? (_TableClass = new Package.TableClass());

	private Package.ChopperClass _ChopperClass;
	/// <summary>
	/// <inheritdoc cref="Package.ChopperClass" path="/summary" />
	/// </summary>
	public Package.ChopperClass ChopperClass => _ChopperClass ?? (_ChopperClass = new Package.ChopperClass());

	private Package.ValveClass _ValveClass;
	/// <summary>
	/// <inheritdoc cref="Package.ValveClass" path="/summary" />
	/// </summary>
	public Package.ValveClass ValveClass => _ValveClass ?? (_ValveClass = new Package.ValveClass());

	private Package.PotClass _PotClass;
	/// <summary>
	/// <inheritdoc cref="Package.PotClass" path="/summary" />
	/// </summary>
	public Package.PotClass PotClass => _PotClass ?? (_PotClass = new Package.PotClass());

	private Package.TransformerClass _TransformerClass;
	/// <summary>
	/// <inheritdoc cref="Package.TransformerClass" path="/summary" />
	/// </summary>
	public Package.TransformerClass TransformerClass => _TransformerClass ?? (_TransformerClass = new Package.TransformerClass());

	private Package.ExposureUnitClass _ExposureUnitClass;
	/// <summary>
	/// <inheritdoc cref="Package.ExposureUnitClass" path="/summary" />
	/// </summary>
	public Package.ExposureUnitClass ExposureUnitClass => _ExposureUnitClass ?? (_ExposureUnitClass = new Package.ExposureUnitClass());

	private Package.TankClass _TankClass;
	/// <summary>
	/// <inheritdoc cref="Package.TankClass" path="/summary" />
	/// </summary>
	public Package.TankClass TankClass => _TankClass ?? (_TankClass = new Package.TankClass());

	private Package.EncoderClass _EncoderClass;
	/// <summary>
	/// <inheritdoc cref="Package.EncoderClass" path="/summary" />
	/// </summary>
	public Package.EncoderClass EncoderClass => _EncoderClass ?? (_EncoderClass = new Package.EncoderClass());

	private Package.StorageBatteryClass _StorageBatteryClass;
	/// <summary>
	/// <inheritdoc cref="Package.StorageBatteryClass" path="/summary" />
	/// </summary>
	public Package.StorageBatteryClass StorageBatteryClass => _StorageBatteryClass ?? (_StorageBatteryClass = new Package.StorageBatteryClass());

	private Package.CircuitBreakerClass _CircuitBreakerClass;
	/// <summary>
	/// <inheritdoc cref="Package.CircuitBreakerClass" path="/summary" />
	/// </summary>
	public Package.CircuitBreakerClass CircuitBreakerClass => _CircuitBreakerClass ?? (_CircuitBreakerClass = new Package.CircuitBreakerClass());

	private Package.MotorClass _MotorClass;
	/// <summary>
	/// <inheritdoc cref="Package.MotorClass" path="/summary" />
	/// </summary>
	public Package.MotorClass MotorClass => _MotorClass ?? (_MotorClass = new Package.MotorClass());

	private Package.ExtrusionUnitClass _ExtrusionUnitClass;
	/// <summary>
	/// <inheritdoc cref="Package.ExtrusionUnitClass" path="/summary" />
	/// </summary>
	public Package.ExtrusionUnitClass ExtrusionUnitClass => _ExtrusionUnitClass ?? (_ExtrusionUnitClass = new Package.ExtrusionUnitClass());

	private Package.GalvanomotorClass _GalvanomotorClass;
	/// <summary>
	/// <inheritdoc cref="Package.GalvanomotorClass" path="/summary" />
	/// </summary>
	public Package.GalvanomotorClass GalvanomotorClass => _GalvanomotorClass ?? (_GalvanomotorClass = new Package.GalvanomotorClass());

	private Package.PumpClass _PumpClass;
	/// <summary>
	/// <inheritdoc cref="Package.PumpClass" path="/summary" />
	/// </summary>
	public Package.PumpClass PumpClass => _PumpClass ?? (_PumpClass = new Package.PumpClass());

	private Package.ClampClass _ClampClass;
	/// <summary>
	/// <inheritdoc cref="Package.ClampClass" path="/summary" />
	/// </summary>
	public Package.ClampClass ClampClass => _ClampClass ?? (_ClampClass = new Package.ClampClass());

	private Package.LinearPositionFeedbackClass _LinearPositionFeedbackClass;
	/// <summary>
	/// <inheritdoc cref="Package.LinearPositionFeedbackClass" path="/summary" />
	/// </summary>
	public Package.LinearPositionFeedbackClass LinearPositionFeedbackClass => _LinearPositionFeedbackClass ?? (_LinearPositionFeedbackClass = new Package.LinearPositionFeedbackClass());

	private Package.WorkpieceClass _WorkpieceClass;
	/// <summary>
	/// <inheritdoc cref="Package.WorkpieceClass" path="/summary" />
	/// </summary>
	public Package.WorkpieceClass WorkpieceClass => _WorkpieceClass ?? (_WorkpieceClass = new Package.WorkpieceClass());

	private Package.WorkEnvelopeClass _WorkEnvelopeClass;
	/// <summary>
	/// <inheritdoc cref="Package.WorkEnvelopeClass" path="/summary" />
	/// </summary>
	public Package.WorkEnvelopeClass WorkEnvelopeClass => _WorkEnvelopeClass ?? (_WorkEnvelopeClass = new Package.WorkEnvelopeClass());

	private Package.FeatureOccurrenceClass _FeatureOccurrenceClass;
	/// <summary>
	/// <inheritdoc cref="Package.FeatureOccurrenceClass" path="/summary" />
	/// </summary>
	public Package.FeatureOccurrenceClass FeatureOccurrenceClass => _FeatureOccurrenceClass ?? (_FeatureOccurrenceClass = new Package.FeatureOccurrenceClass());

	private Package.AirHandlerClass _AirHandlerClass;
	/// <summary>
	/// <inheritdoc cref="Package.AirHandlerClass" path="/summary" />
	/// </summary>
	public Package.AirHandlerClass AirHandlerClass => _AirHandlerClass ?? (_AirHandlerClass = new Package.AirHandlerClass());

	#endregion
	}
}