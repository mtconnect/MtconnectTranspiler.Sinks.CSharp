#pragma warning disable CS1574 // XML comment has cref attribute that could not be resolved
#pragma warning disable CS1584 // XML comment has syntactically incorrect cref attribute
using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;
using Package = Mtconnect.ObservationInformationModel.ObservationTypes.ConditionTypes;

namespace Mtconnect.ObservationInformationModel.ObservationTypes
{
	/// <summary>﻿This section provides semantic information for <see cref="Condition">Condition</see> types.<br /><br /><see cref="Condition">Condition</see> types are reported differently from other <see cref="Observation">Observation</see> types. They are reported based on the <i>condition state</i> for each <see cref="Condition">Condition</see>.<br /><br />The <see cref="DataItem.type">type in DataItem</see> and <see cref="DataItem.subType">subType in DataItem</see> (where applicable) for a <see cref="Condition">Condition</see> <b>MAY</b> be any of the <see cref="DataItem.type">type in DataItem</see> and <see cref="DataItem.subType">subType in DataItem</see> defined for <see cref="DataItem">DataItem</see>s with <see cref="DataItem.category">category in DataItem</see> as <c>SAMPLE</c> or <see cref="DataItem.category">category in DataItem</see> as <c>EVENT</c> listed in the <i>Device Information Model</i>.<br /><br />This section lists additional <see cref="Condition">Condition</see> types that have been defined to represent the health and fault status of <i>Component</i>s.<br /><br /><br />
	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Package___19_0_3_45f01b9_1580309879217_713704_44360">model.mtconnect.org</seealso> for more information.
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public class ConditionTypesPackage : IPackage
	{
		/// <inheritdoc />
		public string ReferenceId => "_19_0_3_45f01b9_1580309879217_713704_44360";
		
		/// <inheritdoc />
		public string Name => "Condition Types";

		/// <inheritdoc />
		public string Summary => @"&#10;&#10;&#10;This section provides semantic information for {{block(Condition)}} types.

{{block(Condition)}} types are reported differently from other {{block(Observation)}} types. They are reported based on the {{term(condition state)}} for each {{block(Condition)}}.

The {{property(DataItem::type)}} and {{property(DataItem::subType)}} (where applicable) for a {{block(Condition)}} **MAY** be any of the {{property(DataItem::type)}} and {{property(DataItem::subType)}} defined for {{block(DataItem)}}s with {{property(DataItem::category)}} as `SAMPLE` or {{property(DataItem::category)}} as `EVENT` listed in the {{term(Device Information Model)}}.

This section lists additional {{block(Condition)}} types that have been defined to represent the health and fault status of {{termplural(Component)}}.&#10;
";

		/// <inheritdoc />
		public IPackage[] Packages => new IPackage[] {
		};
		
		/// <inheritdoc />
		public IClass[] Classes => new IClass[] {
			ActuatorClass,
			CommunicationsClass,
			DataRangeClass,
			LogicProgramClass,
			MotionProgramClass,
			SystemClass,
		};
		
		/// <inheritdoc />
		public IEnum[] Enums => new IEnum[] {
		};

		#region Packages
	#endregion

	#region Classes
	private Package.ActuatorClass _ActuatorClass;
	/// <summary>
	/// <inheritdoc cref="Package.ActuatorClass" path="/summary" />
	/// </summary>
	public Package.ActuatorClass ActuatorClass => _ActuatorClass ?? (_ActuatorClass = new Package.ActuatorClass());

	private Package.CommunicationsClass _CommunicationsClass;
	/// <summary>
	/// <inheritdoc cref="Package.CommunicationsClass" path="/summary" />
	/// </summary>
	public Package.CommunicationsClass CommunicationsClass => _CommunicationsClass ?? (_CommunicationsClass = new Package.CommunicationsClass());

	private Package.DataRangeClass _DataRangeClass;
	/// <summary>
	/// <inheritdoc cref="Package.DataRangeClass" path="/summary" />
	/// </summary>
	public Package.DataRangeClass DataRangeClass => _DataRangeClass ?? (_DataRangeClass = new Package.DataRangeClass());

	private Package.LogicProgramClass _LogicProgramClass;
	/// <summary>
	/// <inheritdoc cref="Package.LogicProgramClass" path="/summary" />
	/// </summary>
	public Package.LogicProgramClass LogicProgramClass => _LogicProgramClass ?? (_LogicProgramClass = new Package.LogicProgramClass());

	private Package.MotionProgramClass _MotionProgramClass;
	/// <summary>
	/// <inheritdoc cref="Package.MotionProgramClass" path="/summary" />
	/// </summary>
	public Package.MotionProgramClass MotionProgramClass => _MotionProgramClass ?? (_MotionProgramClass = new Package.MotionProgramClass());

	private Package.SystemClass _SystemClass;
	/// <summary>
	/// <inheritdoc cref="Package.SystemClass" path="/summary" />
	/// </summary>
	public Package.SystemClass SystemClass => _SystemClass ?? (_SystemClass = new Package.SystemClass());

	#endregion

	#region Enums
	#endregion
	}
}