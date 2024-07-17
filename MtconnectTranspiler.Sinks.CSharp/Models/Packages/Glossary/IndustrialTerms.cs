using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;
using Package = Mtconnect.Glossary.IndustrialTerms;
// using Mtconnect;

namespace Mtconnect.Glossary {
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "1.0.15.3")]
	public class IndustrialTermsPackage : IPackage {
		public IPackage[] Packages => new IPackage[] {
		};

		public IClass[] Classes => new IClass[] {
			AssetClass,
			ConfigurationClass,
			EngineeredSystemClass,
			ObservationClass,
			ObservableClass,
			ObserveClass,
			EngineeringUnitsClass,
			EquipmentMetadataClass,
			EquipmentClass,
			RawMaterialClass,
			SensorClass,
			SensorConfigurationClass,
			SensorDataClass,
			SensorUnitClass,
			SensorElementClass,
			PhysicalConnectionClass,
			ControlLimitClass,
			ConditionClass,
			ConditionStateClass,
			ThingClass,
			ResourceClass,
		};

	private Package.AssetClass _AssetClass;
	public Package.AssetClass AssetClass => _AssetClass ?? (_AssetClass = new Package.AssetClass());
	private Package.ConfigurationClass _ConfigurationClass;
	public Package.ConfigurationClass ConfigurationClass => _ConfigurationClass ?? (_ConfigurationClass = new Package.ConfigurationClass());
	private Package.EngineeredSystemClass _EngineeredSystemClass;
	public Package.EngineeredSystemClass EngineeredSystemClass => _EngineeredSystemClass ?? (_EngineeredSystemClass = new Package.EngineeredSystemClass());
	private Package.ObservationClass _ObservationClass;
	public Package.ObservationClass ObservationClass => _ObservationClass ?? (_ObservationClass = new Package.ObservationClass());
	private Package.ObservableClass _ObservableClass;
	public Package.ObservableClass ObservableClass => _ObservableClass ?? (_ObservableClass = new Package.ObservableClass());
	private Package.ObserveClass _ObserveClass;
	public Package.ObserveClass ObserveClass => _ObserveClass ?? (_ObserveClass = new Package.ObserveClass());
	private Package.EngineeringUnitsClass _EngineeringUnitsClass;
	public Package.EngineeringUnitsClass EngineeringUnitsClass => _EngineeringUnitsClass ?? (_EngineeringUnitsClass = new Package.EngineeringUnitsClass());
	private Package.EquipmentMetadataClass _EquipmentMetadataClass;
	public Package.EquipmentMetadataClass EquipmentMetadataClass => _EquipmentMetadataClass ?? (_EquipmentMetadataClass = new Package.EquipmentMetadataClass());
	private Package.EquipmentClass _EquipmentClass;
	public Package.EquipmentClass EquipmentClass => _EquipmentClass ?? (_EquipmentClass = new Package.EquipmentClass());
	private Package.RawMaterialClass _RawMaterialClass;
	public Package.RawMaterialClass RawMaterialClass => _RawMaterialClass ?? (_RawMaterialClass = new Package.RawMaterialClass());
	private Package.SensorClass _SensorClass;
	public Package.SensorClass SensorClass => _SensorClass ?? (_SensorClass = new Package.SensorClass());
	private Package.SensorConfigurationClass _SensorConfigurationClass;
	public Package.SensorConfigurationClass SensorConfigurationClass => _SensorConfigurationClass ?? (_SensorConfigurationClass = new Package.SensorConfigurationClass());
	private Package.SensorDataClass _SensorDataClass;
	public Package.SensorDataClass SensorDataClass => _SensorDataClass ?? (_SensorDataClass = new Package.SensorDataClass());
	private Package.SensorUnitClass _SensorUnitClass;
	public Package.SensorUnitClass SensorUnitClass => _SensorUnitClass ?? (_SensorUnitClass = new Package.SensorUnitClass());
	private Package.SensorElementClass _SensorElementClass;
	public Package.SensorElementClass SensorElementClass => _SensorElementClass ?? (_SensorElementClass = new Package.SensorElementClass());
	private Package.PhysicalConnectionClass _PhysicalConnectionClass;
	public Package.PhysicalConnectionClass PhysicalConnectionClass => _PhysicalConnectionClass ?? (_PhysicalConnectionClass = new Package.PhysicalConnectionClass());
	private Package.ControlLimitClass _ControlLimitClass;
	public Package.ControlLimitClass ControlLimitClass => _ControlLimitClass ?? (_ControlLimitClass = new Package.ControlLimitClass());
	private Package.ConditionClass _ConditionClass;
	public Package.ConditionClass ConditionClass => _ConditionClass ?? (_ConditionClass = new Package.ConditionClass());
	private Package.ConditionStateClass _ConditionStateClass;
	public Package.ConditionStateClass ConditionStateClass => _ConditionStateClass ?? (_ConditionStateClass = new Package.ConditionStateClass());
	private Package.ThingClass _ThingClass;
	public Package.ThingClass ThingClass => _ThingClass ?? (_ThingClass = new Package.ThingClass());
	private Package.ResourceClass _ResourceClass;
	public Package.ResourceClass ResourceClass => _ResourceClass ?? (_ResourceClass = new Package.ResourceClass());
	}
}