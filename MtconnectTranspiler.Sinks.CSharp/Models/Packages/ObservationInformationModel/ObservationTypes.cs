using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;
using Package = Mtconnect.ObservationInformationModel.ObservationTypes;

namespace Mtconnect.ObservationInformationModel
{
	/// <summary>
	/// This section provides semantic information for the <see cref="Observation">Observation</see> types.  <see cref="Observation">Observation</see> entities are instantiated as <see cref="Sample">Sample</see>, <see cref="Event">Event</see> or <see cref="Condition">Condition</see> entities based upon the <see cref="DataItem::category" /> and <see cref="DataItem::type" /> defined for the corresponding <see cref="DataItem">DataItem</see>.  See {{figure(DeviceStream Example)}} for examples on how the <see cref="Observation">Observation</see> types are organized within <see cref="ComponentStream">ComponentStream</see>.
	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Package___19_0_3_91b028d_1589897764829_678664_48">model.mtconnect.org</seealso> for more information.
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.3.0.0")]
	public class ObservationTypesPackage : IPackage
	{
		/// <inheritdoc />
		public string ReferenceId => "_19_0_3_91b028d_1589897764829_678664_48";
		
		/// <inheritdoc />
		public string Name => "Observation Types";

		/// <inheritdoc />
		public string Summary => @"/// This section provides semantic information for the <see cref=""Observation"">Observation</see> types.  <see cref=""Observation"">Observation</see> entities are instantiated as <see cref=""Sample"">Sample</see>, <see cref=""Event"">Event</see> or <see cref=""Condition"">Condition</see> entities based upon the <see cref=""DataItem::category"" /> and <see cref=""DataItem::type"" /> defined for the corresponding <see cref=""DataItem"">DataItem</see>.  See {{figure(DeviceStream Example)}} for examples on how the <see cref=""Observation"">Observation</see> types are organized within <see cref=""ComponentStream"">ComponentStream</see>.";

		/// <inheritdoc />
		public IPackage[] Packages => new IPackage[] {
			SampleTypesPackage,
			EventTypesPackage,
			ConditionTypesPackage,
		};
		
		/// <inheritdoc />
		public IClass[] Classes => new IClass[] {
		};
		#region Packages
	private Package.SampleTypesPackage _SampleTypesPackage;
	/// <summary>
	/// <inheritdoc cref="Package.SampleTypesPackage" path="/summary" />
	/// </summary>
	public Package.SampleTypesPackage SampleTypesPackage => _SampleTypesPackage ?? (_SampleTypesPackage = new Package.SampleTypesPackage());

	private Package.EventTypesPackage _EventTypesPackage;
	/// <summary>
	/// <inheritdoc cref="Package.EventTypesPackage" path="/summary" />
	/// </summary>
	public Package.EventTypesPackage EventTypesPackage => _EventTypesPackage ?? (_EventTypesPackage = new Package.EventTypesPackage());

	private Package.ConditionTypesPackage _ConditionTypesPackage;
	/// <summary>
	/// <inheritdoc cref="Package.ConditionTypesPackage" path="/summary" />
	/// </summary>
	public Package.ConditionTypesPackage ConditionTypesPackage => _ConditionTypesPackage ?? (_ConditionTypesPackage = new Package.ConditionTypesPackage());

	#endregion

	#region Classes
	#endregion
	}
}