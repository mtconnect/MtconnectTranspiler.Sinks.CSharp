#pragma warning disable CS1574 // XML comment has cref attribute that could not be resolved
#pragma warning disable CS1584 // XML comment has syntactically incorrect cref attribute
#pragma warning disable CS0618 // Type or member is obsolete
using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;
using Package = Mtconnect.Glossary.IndustrialTerms;

namespace Mtconnect.Glossary
{
	/// <summary>﻿
	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Package___19_0_4_45f01b9_1637105844205_327255_1120">model.mtconnect.org</seealso> for more information.
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public class IndustrialTermsPackage : IPackage
	{
		/// <summary>Constant value for <see cref="IndustrialTermsPackage.ReferenceId" /></summary>
		public const string REFERENCE_ID = "_19_0_4_45f01b9_1637105844205_327255_1120";
		/// <summary>Constant value for <see cref="IndustrialTermsPackage.HelpUrl" /></summary>
		public const string HELP_URL = "https://model.mtconnect.org/#Package___19_0_4_45f01b9_1637105844205_327255_1120";
		/// <summary>Constant value for <see cref="IndustrialTermsPackage.Name" /></summary>
		public const string NAME = "Industrial Terms";
		/// <summary>Constant value for <see cref="IndustrialTermsPackage.Summary" /></summary>
		public const string SUMMARY = @"";

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
		
		/// <inheritdoc />
		public IEnum[] Enums => new IEnum[] {
		};

		#region Packages
	#endregion

	#region Classes
	private Package.AssetClass _AssetClass;
	/// <summary>
	/// <inheritdoc cref="Package.AssetClass" path="/summary" />
	/// </summary>
	public Package.AssetClass AssetClass => _AssetClass ?? (_AssetClass = new Package.AssetClass());

	private Package.ConfigurationClass _ConfigurationClass;
	/// <summary>
	/// <inheritdoc cref="Package.ConfigurationClass" path="/summary" />
	/// </summary>
	public Package.ConfigurationClass ConfigurationClass => _ConfigurationClass ?? (_ConfigurationClass = new Package.ConfigurationClass());

	private Package.EngineeredSystemClass _EngineeredSystemClass;
	/// <summary>
	/// <inheritdoc cref="Package.EngineeredSystemClass" path="/summary" />
	/// </summary>
	public Package.EngineeredSystemClass EngineeredSystemClass => _EngineeredSystemClass ?? (_EngineeredSystemClass = new Package.EngineeredSystemClass());

	private Package.ObservationClass _ObservationClass;
	/// <summary>
	/// <inheritdoc cref="Package.ObservationClass" path="/summary" />
	/// </summary>
	public Package.ObservationClass ObservationClass => _ObservationClass ?? (_ObservationClass = new Package.ObservationClass());

	private Package.ObservableClass _ObservableClass;
	/// <summary>
	/// <inheritdoc cref="Package.ObservableClass" path="/summary" />
	/// </summary>
	public Package.ObservableClass ObservableClass => _ObservableClass ?? (_ObservableClass = new Package.ObservableClass());

	private Package.ObserveClass _ObserveClass;
	/// <summary>
	/// <inheritdoc cref="Package.ObserveClass" path="/summary" />
	/// </summary>
	public Package.ObserveClass ObserveClass => _ObserveClass ?? (_ObserveClass = new Package.ObserveClass());

	private Package.EngineeringUnitsClass _EngineeringUnitsClass;
	/// <summary>
	/// <inheritdoc cref="Package.EngineeringUnitsClass" path="/summary" />
	/// </summary>
	public Package.EngineeringUnitsClass EngineeringUnitsClass => _EngineeringUnitsClass ?? (_EngineeringUnitsClass = new Package.EngineeringUnitsClass());

	private Package.EquipmentMetadataClass _EquipmentMetadataClass;
	/// <summary>
	/// <inheritdoc cref="Package.EquipmentMetadataClass" path="/summary" />
	/// </summary>
	public Package.EquipmentMetadataClass EquipmentMetadataClass => _EquipmentMetadataClass ?? (_EquipmentMetadataClass = new Package.EquipmentMetadataClass());

	private Package.EquipmentClass _EquipmentClass;
	/// <summary>
	/// <inheritdoc cref="Package.EquipmentClass" path="/summary" />
	/// </summary>
	public Package.EquipmentClass EquipmentClass => _EquipmentClass ?? (_EquipmentClass = new Package.EquipmentClass());

	private Package.RawMaterialClass _RawMaterialClass;
	/// <summary>
	/// <inheritdoc cref="Package.RawMaterialClass" path="/summary" />
	/// </summary>
	public Package.RawMaterialClass RawMaterialClass => _RawMaterialClass ?? (_RawMaterialClass = new Package.RawMaterialClass());

	private Package.SensorClass _SensorClass;
	/// <summary>
	/// <inheritdoc cref="Package.SensorClass" path="/summary" />
	/// </summary>
	public Package.SensorClass SensorClass => _SensorClass ?? (_SensorClass = new Package.SensorClass());

	private Package.SensorConfigurationClass _SensorConfigurationClass;
	/// <summary>
	/// <inheritdoc cref="Package.SensorConfigurationClass" path="/summary" />
	/// </summary>
	public Package.SensorConfigurationClass SensorConfigurationClass => _SensorConfigurationClass ?? (_SensorConfigurationClass = new Package.SensorConfigurationClass());

	private Package.SensorDataClass _SensorDataClass;
	/// <summary>
	/// <inheritdoc cref="Package.SensorDataClass" path="/summary" />
	/// </summary>
	public Package.SensorDataClass SensorDataClass => _SensorDataClass ?? (_SensorDataClass = new Package.SensorDataClass());

	private Package.SensorUnitClass _SensorUnitClass;
	/// <summary>
	/// <inheritdoc cref="Package.SensorUnitClass" path="/summary" />
	/// </summary>
	public Package.SensorUnitClass SensorUnitClass => _SensorUnitClass ?? (_SensorUnitClass = new Package.SensorUnitClass());

	private Package.SensorElementClass _SensorElementClass;
	/// <summary>
	/// <inheritdoc cref="Package.SensorElementClass" path="/summary" />
	/// </summary>
	public Package.SensorElementClass SensorElementClass => _SensorElementClass ?? (_SensorElementClass = new Package.SensorElementClass());

	private Package.PhysicalConnectionClass _PhysicalConnectionClass;
	/// <summary>
	/// <inheritdoc cref="Package.PhysicalConnectionClass" path="/summary" />
	/// </summary>
	public Package.PhysicalConnectionClass PhysicalConnectionClass => _PhysicalConnectionClass ?? (_PhysicalConnectionClass = new Package.PhysicalConnectionClass());

	private Package.ControlLimitClass _ControlLimitClass;
	/// <summary>
	/// <inheritdoc cref="Package.ControlLimitClass" path="/summary" />
	/// </summary>
	public Package.ControlLimitClass ControlLimitClass => _ControlLimitClass ?? (_ControlLimitClass = new Package.ControlLimitClass());

	private Package.ConditionClass _ConditionClass;
	/// <summary>
	/// <inheritdoc cref="Package.ConditionClass" path="/summary" />
	/// </summary>
	public Package.ConditionClass ConditionClass => _ConditionClass ?? (_ConditionClass = new Package.ConditionClass());

	private Package.ConditionStateClass _ConditionStateClass;
	/// <summary>
	/// <inheritdoc cref="Package.ConditionStateClass" path="/summary" />
	/// </summary>
	public Package.ConditionStateClass ConditionStateClass => _ConditionStateClass ?? (_ConditionStateClass = new Package.ConditionStateClass());

	private Package.ThingClass _ThingClass;
	/// <summary>
	/// <inheritdoc cref="Package.ThingClass" path="/summary" />
	/// </summary>
	public Package.ThingClass ThingClass => _ThingClass ?? (_ThingClass = new Package.ThingClass());

	private Package.ResourceClass _ResourceClass;
	/// <summary>
	/// <inheritdoc cref="Package.ResourceClass" path="/summary" />
	/// </summary>
	public Package.ResourceClass ResourceClass => _ResourceClass ?? (_ResourceClass = new Package.ResourceClass());

	#endregion

	#region Enums
	#endregion
	}
}