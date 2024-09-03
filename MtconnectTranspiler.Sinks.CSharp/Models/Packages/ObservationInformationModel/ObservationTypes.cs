#pragma warning disable CS1574 // XML comment has cref attribute that could not be resolved
#pragma warning disable CS1584 // XML comment has syntactically incorrect cref attribute
#pragma warning disable CS0618 // Type or member is obsolete
using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;
using Package = Mtconnect.ObservationInformationModel.ObservationTypes;

namespace Mtconnect.ObservationInformationModel
{
	/// <summary>﻿This section provides semantic information for the <see cref="Observation">Observation</see> types.<br /><br /><see cref="Observation">Observation</see> entities are instantiated as <see cref="Sample">Sample</see>, <see cref="Event">Event</see> or <see cref="Condition">Condition</see> entities based upon the <see cref="DataItem.category">category in DataItem</see> and <see cref="DataItem.type">type in DataItem</see> defined for the corresponding <see cref="DataItem">DataItem</see>.<br /><br />See {{figure(DeviceStream Example)}} for examples on how the <see cref="Observation">Observation</see> types are organized within <see cref="ComponentStream">ComponentStream</see>.<br /><br /><br />
	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Package___19_0_3_91b028d_1589897764829_678664_48">model.mtconnect.org</seealso> for more information.
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public class ObservationTypesPackage : IPackage
	{
		/// <summary>Constant value for <see cref="ObservationTypesPackage.ReferenceId" /></summary>
		public const string REFERENCE_ID = "_19_0_3_91b028d_1589897764829_678664_48";
		/// <summary>Constant value for <see cref="ObservationTypesPackage.HelpUrl" /></summary>
		public const string HELP_URL = "https://model.mtconnect.org/#Package___19_0_3_91b028d_1589897764829_678664_48";
		/// <summary>Constant value for <see cref="ObservationTypesPackage.Name" /></summary>
		public const string NAME = "Observation Types";
		/// <summary>Constant value for <see cref="ObservationTypesPackage.Summary" /></summary>
		public const string SUMMARY = @"&#10;&#10;&#10;This section provides semantic information for the {{block(Observation)}} types.

{{block(Observation)}} entities are instantiated as {{block(Sample)}}, {{block(Event)}} or {{block(Condition)}} entities based upon the {{property(DataItem::category)}} and {{property(DataItem::type)}} defined for the corresponding {{block(DataItem)}}.

See {{figure(DeviceStream Example)}} for examples on how the {{block(Observation)}} types are organized within {{block(ComponentStream)}}.&#10;
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
			SampleTypesPackage,
			EventTypesPackage,
			ConditionTypesPackage,
		};
		
		/// <inheritdoc />
		public IClass[] Classes => new IClass[] {
		};
		
		/// <inheritdoc />
		public IEnum[] Enums => new IEnum[] {
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

	#region Enums
	#endregion
	}
}