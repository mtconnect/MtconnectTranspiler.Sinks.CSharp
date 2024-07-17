using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;
using Package = Mtconnect.DeviceInformationModel.Components.ComponentTypes;
// using Mtconnect;

namespace Mtconnect.DeviceInformationModel.Components {
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "1.0.15.3")]
	public class ComponentTypesPackage : IPackage {
		public IPackage[] Packages => new IPackage[] {
			ComponentOrganizerTypesPackage,
		};

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
	private Package.ComponentOrganizerTypesPackage _ComponentOrganizerTypesPackage;
	public Package.ComponentOrganizerTypesPackage ComponentOrganizerTypesPackage => _ComponentOrganizerTypesPackage ?? (_ComponentOrganizerTypesPackage = new Package.ComponentOrganizerTypesPackage());

	private Package.ActuatorClass _ActuatorClass;
	public Package.ActuatorClass ActuatorClass => _ActuatorClass ?? (_ActuatorClass = new Package.ActuatorClass());
	private Package.AuxiliaryClass _AuxiliaryClass;
	public Package.AuxiliaryClass AuxiliaryClass => _AuxiliaryClass ?? (_AuxiliaryClass = new Package.AuxiliaryClass());
	private Package.AxisClass _AxisClass;
	public Package.AxisClass AxisClass => _AxisClass ?? (_AxisClass = new Package.AxisClass());
	private Package.BarFeederClass _BarFeederClass;
	public Package.BarFeederClass BarFeederClass => _BarFeederClass ?? (_BarFeederClass = new Package.BarFeederClass());
	private Package.ControllerClass _ControllerClass;
	public Package.ControllerClass ControllerClass => _ControllerClass ?? (_ControllerClass = new Package.ControllerClass());
	private Package.CoolantClass _CoolantClass;
	public Package.CoolantClass CoolantClass => _CoolantClass ?? (_CoolantClass = new Package.CoolantClass());
	private Package.DepositionClass _DepositionClass;
	public Package.DepositionClass DepositionClass => _DepositionClass ?? (_DepositionClass = new Package.DepositionClass());
	private Package.DielectricClass _DielectricClass;
	public Package.DielectricClass DielectricClass => _DielectricClass ?? (_DielectricClass = new Package.DielectricClass());
	private Package.DoorClass _DoorClass;
	public Package.DoorClass DoorClass => _DoorClass ?? (_DoorClass = new Package.DoorClass());
	private Package.ElectricClass _ElectricClass;
	public Package.ElectricClass ElectricClass => _ElectricClass ?? (_ElectricClass = new Package.ElectricClass());
	private Package.EnclosureClass _EnclosureClass;
	public Package.EnclosureClass EnclosureClass => _EnclosureClass ?? (_EnclosureClass = new Package.EnclosureClass());
	private Package.EndEffectorClass _EndEffectorClass;
	public Package.EndEffectorClass EndEffectorClass => _EndEffectorClass ?? (_EndEffectorClass = new Package.EndEffectorClass());
	private Package.EnvironmentalClass _EnvironmentalClass;
	public Package.EnvironmentalClass EnvironmentalClass => _EnvironmentalClass ?? (_EnvironmentalClass = new Package.EnvironmentalClass());
	private Package.FeederClass _FeederClass;
	public Package.FeederClass FeederClass => _FeederClass ?? (_FeederClass = new Package.FeederClass());
	private Package.HydraulicClass _HydraulicClass;
	public Package.HydraulicClass HydraulicClass => _HydraulicClass ?? (_HydraulicClass = new Package.HydraulicClass());
	private Package.LinearClass _LinearClass;
	public Package.LinearClass LinearClass => _LinearClass ?? (_LinearClass = new Package.LinearClass());
	private Package.LoaderClass _LoaderClass;
	public Package.LoaderClass LoaderClass => _LoaderClass ?? (_LoaderClass = new Package.LoaderClass());
	private Package.LubricationClass _LubricationClass;
	public Package.LubricationClass LubricationClass => _LubricationClass ?? (_LubricationClass = new Package.LubricationClass());
	private Package.MaterialClass _MaterialClass;
	public Package.MaterialClass MaterialClass => _MaterialClass ?? (_MaterialClass = new Package.MaterialClass());
	private Package.PathClass _PathClass;
	public Package.PathClass PathClass => _PathClass ?? (_PathClass = new Package.PathClass());
	private Package.PersonnelClass _PersonnelClass;
	public Package.PersonnelClass PersonnelClass => _PersonnelClass ?? (_PersonnelClass = new Package.PersonnelClass());
	private Package.PneumaticClass _PneumaticClass;
	public Package.PneumaticClass PneumaticClass => _PneumaticClass ?? (_PneumaticClass = new Package.PneumaticClass());
	private Package.PowerClass _PowerClass;
	public Package.PowerClass PowerClass => _PowerClass ?? (_PowerClass = new Package.PowerClass());
	private Package.ProcessPowerClass _ProcessPowerClass;
	public Package.ProcessPowerClass ProcessPowerClass => _ProcessPowerClass ?? (_ProcessPowerClass = new Package.ProcessPowerClass());
	private Package.ProtectiveClass _ProtectiveClass;
	public Package.ProtectiveClass ProtectiveClass => _ProtectiveClass ?? (_ProtectiveClass = new Package.ProtectiveClass());
	private Package.ResourceClass _ResourceClass;
	public Package.ResourceClass ResourceClass => _ResourceClass ?? (_ResourceClass = new Package.ResourceClass());
	private Package.RotaryClass _RotaryClass;
	public Package.RotaryClass RotaryClass => _RotaryClass ?? (_RotaryClass = new Package.RotaryClass());
	private Package.SensorClass _SensorClass;
	public Package.SensorClass SensorClass => _SensorClass ?? (_SensorClass = new Package.SensorClass());
	private Package.StockClass _StockClass;
	public Package.StockClass StockClass => _StockClass ?? (_StockClass = new Package.StockClass());
	private Package.SystemClass _SystemClass;
	public Package.SystemClass SystemClass => _SystemClass ?? (_SystemClass = new Package.SystemClass());
	private Package.ToolingDeliveryClass _ToolingDeliveryClass;
	public Package.ToolingDeliveryClass ToolingDeliveryClass => _ToolingDeliveryClass ?? (_ToolingDeliveryClass = new Package.ToolingDeliveryClass());
	private Package.WasteDisposalClass _WasteDisposalClass;
	public Package.WasteDisposalClass WasteDisposalClass => _WasteDisposalClass ?? (_WasteDisposalClass = new Package.WasteDisposalClass());
	private Package.StructureClass _StructureClass;
	public Package.StructureClass StructureClass => _StructureClass ?? (_StructureClass = new Package.StructureClass());
	private Package.LinkClass _LinkClass;
	public Package.LinkClass LinkClass => _LinkClass ?? (_LinkClass = new Package.LinkClass());
	private Package.GangToolBarClass _GangToolBarClass;
	public Package.GangToolBarClass GangToolBarClass => _GangToolBarClass ?? (_GangToolBarClass = new Package.GangToolBarClass());
	private Package.HeatingClass _HeatingClass;
	public Package.HeatingClass HeatingClass => _HeatingClass ?? (_HeatingClass = new Package.HeatingClass());
	private Package.AutomaticToolChangerClass _AutomaticToolChangerClass;
	public Package.AutomaticToolChangerClass AutomaticToolChangerClass => _AutomaticToolChangerClass ?? (_AutomaticToolChangerClass = new Package.AutomaticToolChangerClass());
	private Package.ProcessClass _ProcessClass;
	public Package.ProcessClass ProcessClass => _ProcessClass ?? (_ProcessClass = new Package.ProcessClass());
	private Package.ToolMagazineClass _ToolMagazineClass;
	public Package.ToolMagazineClass ToolMagazineClass => _ToolMagazineClass ?? (_ToolMagazineClass = new Package.ToolMagazineClass());
	private Package.PartOccurrenceClass _PartOccurrenceClass;
	public Package.PartOccurrenceClass PartOccurrenceClass => _PartOccurrenceClass ?? (_PartOccurrenceClass = new Package.PartOccurrenceClass());
	private Package.AdapterClass _AdapterClass;
	public Package.AdapterClass AdapterClass => _AdapterClass ?? (_AdapterClass = new Package.AdapterClass());
	private Package.ToolRackClass _ToolRackClass;
	public Package.ToolRackClass ToolRackClass => _ToolRackClass ?? (_ToolRackClass = new Package.ToolRackClass());
	private Package.TurretClass _TurretClass;
	public Package.TurretClass TurretClass => _TurretClass ?? (_TurretClass = new Package.TurretClass());
	private Package.VacuumClass _VacuumClass;
	public Package.VacuumClass VacuumClass => _VacuumClass ?? (_VacuumClass = new Package.VacuumClass());
	private Package.CoolingClass _CoolingClass;
	public Package.CoolingClass CoolingClass => _CoolingClass ?? (_CoolingClass = new Package.CoolingClass());
	private Package.ProcessOccurrenceClass _ProcessOccurrenceClass;
	public Package.ProcessOccurrenceClass ProcessOccurrenceClass => _ProcessOccurrenceClass ?? (_ProcessOccurrenceClass = new Package.ProcessOccurrenceClass());
	private Package.PressureClass _PressureClass;
	public Package.PressureClass PressureClass => _PressureClass ?? (_PressureClass = new Package.PressureClass());
	private Package.PartClass _PartClass;
	public Package.PartClass PartClass => _PartClass ?? (_PartClass = new Package.PartClass());
	private Package.LockClass _LockClass;
	public Package.LockClass LockClass => _LockClass ?? (_LockClass = new Package.LockClass());
	private Package.SpindleClass _SpindleClass;
	public Package.SpindleClass SpindleClass => _SpindleClass ?? (_SpindleClass = new Package.SpindleClass());
	private Package.ThermostatClass _ThermostatClass;
	public Package.ThermostatClass ThermostatClass => _ThermostatClass ?? (_ThermostatClass = new Package.ThermostatClass());
	private Package.VibrationClass _VibrationClass;
	public Package.VibrationClass VibrationClass => _VibrationClass ?? (_VibrationClass = new Package.VibrationClass());
	private Package.ChuckClass _ChuckClass;
	public Package.ChuckClass ChuckClass => _ChuckClass ?? (_ChuckClass = new Package.ChuckClass());
	private Package.FanClass _FanClass;
	public Package.FanClass FanClass => _FanClass ?? (_FanClass = new Package.FanClass());
	private Package.SpreaderClass _SpreaderClass;
	public Package.SpreaderClass SpreaderClass => _SpreaderClass ?? (_SpreaderClass = new Package.SpreaderClass());
	private Package.PulleyClass _PulleyClass;
	public Package.PulleyClass PulleyClass => _PulleyClass ?? (_PulleyClass = new Package.PulleyClass());
	private Package.TransferPotClass _TransferPotClass;
	public Package.TransferPotClass TransferPotClass => _TransferPotClass ?? (_TransferPotClass = new Package.TransferPotClass());
	private Package.PowerSupplyClass _PowerSupplyClass;
	public Package.PowerSupplyClass PowerSupplyClass => _PowerSupplyClass ?? (_PowerSupplyClass = new Package.PowerSupplyClass());
	private Package.DrainClass _DrainClass;
	public Package.DrainClass DrainClass => _DrainClass ?? (_DrainClass = new Package.DrainClass());
	private Package.BallscrewClass _BallscrewClass;
	public Package.BallscrewClass BallscrewClass => _BallscrewClass ?? (_BallscrewClass = new Package.BallscrewClass());
	private Package.CompressorClass _CompressorClass;
	public Package.CompressorClass CompressorClass => _CompressorClass ?? (_CompressorClass = new Package.CompressorClass());
	private Package.ChuteClass _ChuteClass;
	public Package.ChuteClass ChuteClass => _ChuteClass ?? (_ChuteClass = new Package.ChuteClass());
	private Package.SwitchClass _SwitchClass;
	public Package.SwitchClass SwitchClass => _SwitchClass ?? (_SwitchClass = new Package.SwitchClass());
	private Package.TensionerClass _TensionerClass;
	public Package.TensionerClass TensionerClass => _TensionerClass ?? (_TensionerClass = new Package.TensionerClass());
	private Package.WaterClass _WaterClass;
	public Package.WaterClass WaterClass => _WaterClass ?? (_WaterClass = new Package.WaterClass());
	private Package.WireClass _WireClass;
	public Package.WireClass WireClass => _WireClass ?? (_WireClass = new Package.WireClass());
	private Package.SensingElementClass _SensingElementClass;
	public Package.SensingElementClass SensingElementClass => _SensingElementClass ?? (_SensingElementClass = new Package.SensingElementClass());
	private Package.CoolingTowerClass _CoolingTowerClass;
	public Package.CoolingTowerClass CoolingTowerClass => _CoolingTowerClass ?? (_CoolingTowerClass = new Package.CoolingTowerClass());
	private Package.RemovalPotClass _RemovalPotClass;
	public Package.RemovalPotClass RemovalPotClass => _RemovalPotClass ?? (_RemovalPotClass = new Package.RemovalPotClass());
	private Package.GripperClass _GripperClass;
	public Package.GripperClass GripperClass => _GripperClass ?? (_GripperClass = new Package.GripperClass());
	private Package.StagingPotClass _StagingPotClass;
	public Package.StagingPotClass StagingPotClass => _StagingPotClass ?? (_StagingPotClass = new Package.StagingPotClass());
	private Package.BrakeClass _BrakeClass;
	public Package.BrakeClass BrakeClass => _BrakeClass ?? (_BrakeClass = new Package.BrakeClass());
	private Package.StationClass _StationClass;
	public Package.StationClass StationClass => _StationClass ?? (_StationClass = new Package.StationClass());
	private Package.HopperClass _HopperClass;
	public Package.HopperClass HopperClass => _HopperClass ?? (_HopperClass = new Package.HopperClass());
	private Package.BeltClass _BeltClass;
	public Package.BeltClass BeltClass => _BeltClass ?? (_BeltClass = new Package.BeltClass());
	private Package.TransferArmClass _TransferArmClass;
	public Package.TransferArmClass TransferArmClass => _TransferArmClass ?? (_TransferArmClass = new Package.TransferArmClass());
	private Package.ReelClass _ReelClass;
	public Package.ReelClass ReelClass => _ReelClass ?? (_ReelClass = new Package.ReelClass());
	private Package.FilterClass _FilterClass;
	public Package.FilterClass FilterClass => _FilterClass ?? (_FilterClass = new Package.FilterClass());
	private Package.ReturnPotClass _ReturnPotClass;
	public Package.ReturnPotClass ReturnPotClass => _ReturnPotClass ?? (_ReturnPotClass = new Package.ReturnPotClass());
	private Package.ChainClass _ChainClass;
	public Package.ChainClass ChainClass => _ChainClass ?? (_ChainClass = new Package.ChainClass());
	private Package.AmplifierClass _AmplifierClass;
	public Package.AmplifierClass AmplifierClass => _AmplifierClass ?? (_AmplifierClass = new Package.AmplifierClass());
	private Package.VatClass _VatClass;
	public Package.VatClass VatClass => _VatClass ?? (_VatClass = new Package.VatClass());
	private Package.ExpiredPotClass _ExpiredPotClass;
	public Package.ExpiredPotClass ExpiredPotClass => _ExpiredPotClass ?? (_ExpiredPotClass = new Package.ExpiredPotClass());
	private Package.OilClass _OilClass;
	public Package.OilClass OilClass => _OilClass ?? (_OilClass = new Package.OilClass());
	private Package.TableClass _TableClass;
	public Package.TableClass TableClass => _TableClass ?? (_TableClass = new Package.TableClass());
	private Package.ChopperClass _ChopperClass;
	public Package.ChopperClass ChopperClass => _ChopperClass ?? (_ChopperClass = new Package.ChopperClass());
	private Package.ValveClass _ValveClass;
	public Package.ValveClass ValveClass => _ValveClass ?? (_ValveClass = new Package.ValveClass());
	private Package.PotClass _PotClass;
	public Package.PotClass PotClass => _PotClass ?? (_PotClass = new Package.PotClass());
	private Package.TransformerClass _TransformerClass;
	public Package.TransformerClass TransformerClass => _TransformerClass ?? (_TransformerClass = new Package.TransformerClass());
	private Package.ExposureUnitClass _ExposureUnitClass;
	public Package.ExposureUnitClass ExposureUnitClass => _ExposureUnitClass ?? (_ExposureUnitClass = new Package.ExposureUnitClass());
	private Package.TankClass _TankClass;
	public Package.TankClass TankClass => _TankClass ?? (_TankClass = new Package.TankClass());
	private Package.EncoderClass _EncoderClass;
	public Package.EncoderClass EncoderClass => _EncoderClass ?? (_EncoderClass = new Package.EncoderClass());
	private Package.StorageBatteryClass _StorageBatteryClass;
	public Package.StorageBatteryClass StorageBatteryClass => _StorageBatteryClass ?? (_StorageBatteryClass = new Package.StorageBatteryClass());
	private Package.CircuitBreakerClass _CircuitBreakerClass;
	public Package.CircuitBreakerClass CircuitBreakerClass => _CircuitBreakerClass ?? (_CircuitBreakerClass = new Package.CircuitBreakerClass());
	private Package.MotorClass _MotorClass;
	public Package.MotorClass MotorClass => _MotorClass ?? (_MotorClass = new Package.MotorClass());
	private Package.ExtrusionUnitClass _ExtrusionUnitClass;
	public Package.ExtrusionUnitClass ExtrusionUnitClass => _ExtrusionUnitClass ?? (_ExtrusionUnitClass = new Package.ExtrusionUnitClass());
	private Package.GalvanomotorClass _GalvanomotorClass;
	public Package.GalvanomotorClass GalvanomotorClass => _GalvanomotorClass ?? (_GalvanomotorClass = new Package.GalvanomotorClass());
	private Package.PumpClass _PumpClass;
	public Package.PumpClass PumpClass => _PumpClass ?? (_PumpClass = new Package.PumpClass());
	private Package.ClampClass _ClampClass;
	public Package.ClampClass ClampClass => _ClampClass ?? (_ClampClass = new Package.ClampClass());
	private Package.LinearPositionFeedbackClass _LinearPositionFeedbackClass;
	public Package.LinearPositionFeedbackClass LinearPositionFeedbackClass => _LinearPositionFeedbackClass ?? (_LinearPositionFeedbackClass = new Package.LinearPositionFeedbackClass());
	private Package.WorkpieceClass _WorkpieceClass;
	public Package.WorkpieceClass WorkpieceClass => _WorkpieceClass ?? (_WorkpieceClass = new Package.WorkpieceClass());
	private Package.WorkEnvelopeClass _WorkEnvelopeClass;
	public Package.WorkEnvelopeClass WorkEnvelopeClass => _WorkEnvelopeClass ?? (_WorkEnvelopeClass = new Package.WorkEnvelopeClass());
	private Package.FeatureOccurrenceClass _FeatureOccurrenceClass;
	public Package.FeatureOccurrenceClass FeatureOccurrenceClass => _FeatureOccurrenceClass ?? (_FeatureOccurrenceClass = new Package.FeatureOccurrenceClass());
	private Package.AirHandlerClass _AirHandlerClass;
	public Package.AirHandlerClass AirHandlerClass => _AirHandlerClass ?? (_AirHandlerClass = new Package.AirHandlerClass());
	}
}