using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;
using Package = Mtconnect.DataTypes;
// using Mtconnect;

namespace Mtconnect {
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "1.0.15.3")]
	public class DataTypesPackage : IPackage {
		public IPackage[] Packages => new IPackage[] {
		};

		public IClass[] Classes => new IClass[] {
			ControlLimitResultClass,
			SpecificationLimitResultClass,
			AlarmLimitResultClass,
			SensorAttachmentResultClass,
			MaintenanceListResultClass,
			FeatureMeasurementResultClass,
			LocationAddressResultClass,
		};

	private Package.ControlLimitResultClass _ControlLimitResultClass;
	public Package.ControlLimitResultClass ControlLimitResultClass => _ControlLimitResultClass ?? (_ControlLimitResultClass = new Package.ControlLimitResultClass());
	private Package.SpecificationLimitResultClass _SpecificationLimitResultClass;
	public Package.SpecificationLimitResultClass SpecificationLimitResultClass => _SpecificationLimitResultClass ?? (_SpecificationLimitResultClass = new Package.SpecificationLimitResultClass());
	private Package.AlarmLimitResultClass _AlarmLimitResultClass;
	public Package.AlarmLimitResultClass AlarmLimitResultClass => _AlarmLimitResultClass ?? (_AlarmLimitResultClass = new Package.AlarmLimitResultClass());
	private Package.SensorAttachmentResultClass _SensorAttachmentResultClass;
	public Package.SensorAttachmentResultClass SensorAttachmentResultClass => _SensorAttachmentResultClass ?? (_SensorAttachmentResultClass = new Package.SensorAttachmentResultClass());
	private Package.MaintenanceListResultClass _MaintenanceListResultClass;
	public Package.MaintenanceListResultClass MaintenanceListResultClass => _MaintenanceListResultClass ?? (_MaintenanceListResultClass = new Package.MaintenanceListResultClass());
	private Package.FeatureMeasurementResultClass _FeatureMeasurementResultClass;
	public Package.FeatureMeasurementResultClass FeatureMeasurementResultClass => _FeatureMeasurementResultClass ?? (_FeatureMeasurementResultClass = new Package.FeatureMeasurementResultClass());
	private Package.LocationAddressResultClass _LocationAddressResultClass;
	public Package.LocationAddressResultClass LocationAddressResultClass => _LocationAddressResultClass ?? (_LocationAddressResultClass = new Package.LocationAddressResultClass());
	}
}