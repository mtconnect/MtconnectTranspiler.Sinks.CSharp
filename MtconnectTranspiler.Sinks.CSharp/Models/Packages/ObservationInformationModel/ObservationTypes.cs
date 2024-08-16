using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;
using Package = Mtconnect.ObservationInformationModel.ObservationTypes;

namespace Mtconnect.ObservationInformationModel
{
	/// <summary>
	﻿/// This section provides semantic information for the <see cref="Observation">Observation</see> types.<br /><br /><see cref="Observation">Observation</see> entities are instantiated as <see cref="Sample">Sample</see>, <see cref="Event">Event</see> or <see cref="Condition">Condition</see> entities based upon the <see cref="DataItem.category">category in DataItem</see> and <see cref="DataItem.type">type in DataItem</see> defined for the corresponding <see cref="DataItem">DataItem</see>.<br /><br />See {{figure(DeviceStream Example)}} for examples on how the <see cref="Observation">Observation</see> types are organized within <see cref="ComponentStream">ComponentStream</see>.<br/><br />

	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Package___19_0_3_91b028d_1589897764829_678664_48">model.mtconnect.org</seealso> for more information.
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public class ObservationTypesPackage : IPackage
	{
		/// <inheritdoc />
		public string ReferenceId => "_19_0_3_91b028d_1589897764829_678664_48";
		
		/// <inheritdoc />
		public string Name => "Observation Types";

		/// <inheritdoc />
		public string Summary => @"&#10;&#10;&#10;This section provides semantic information for the {{block(Observation)}} types.

{{block(Observation)}} entities are instantiated as {{block(Sample)}}, {{block(Event)}} or {{block(Condition)}} entities based upon the {{property(DataItem::category)}} and {{property(DataItem::type)}} defined for the corresponding {{block(DataItem)}}.

See {{figure(DeviceStream Example)}} for examples on how the {{block(Observation)}} types are organized within {{block(ComponentStream)}}.&#10;
";

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