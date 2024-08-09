using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;
using Package = Mtconnect.DataTypes;

namespace Mtconnect
{
	/// <summary>
	/// 
	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Package___19_0_3_45f01b9_1579567325331_179717_33552">model.mtconnect.org</seealso> for more information.
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.3.0.0")]
	public class DataTypesPackage : IPackage
	{
		/// <inheritdoc />
		public string ReferenceId => "_19_0_3_45f01b9_1579567325331_179717_33552";
		
		/// <inheritdoc />
		public string Name => "DataTypes";

		/// <inheritdoc />
		public string Summary => @"/// ";

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
	}
}