using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;
using Package = Mtconnect.ObservationInformationModel.ObservationTypes.ConditionTypes;
// using Mtconnect;

namespace Mtconnect.ObservationInformationModel.ObservationTypes
{
	/// <summary>
	/// This section provides semantic information for <see cref="Condition">Condition</see> types.  <see cref="Condition">Condition</see> types are reported differently from other <see cref="Observation">Observation</see> types. They are reported based on the <i>condition state</i> for each <see cref="Condition">Condition</see>.  The <see cref="DataItem::type" /> and <see cref="DataItem::subType" /> (where applicable) for a <see cref="Condition">Condition</see> <b>MAY</b> be any of the <see cref="DataItem::type" /> and <see cref="DataItem::subType" /> defined for <see cref="DataItem">DataItem</see>s with <see cref="DataItem::category" /> as <c>SAMPLE</c> or <see cref="DataItem::category" /> as <c>EVENT</c> listed in the <i>Device Information Model</i>.  This section lists additional <see cref="Condition">Condition</see> types that have been defined to represent the health and fault status of <i>Component</i>s.
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.3.0.0")]
	public class ConditionTypesPackage : IPackage
	{
		/// <inheritdoc />
		public string ReferenceId => "_19_0_3_45f01b9_1580309879217_713704_44360";
		
		/// <inheritdoc />
		public string Name => "ConditionTypes";

		/// <inheritdoc />
		public string Summary => @"/// This section provides semantic information for <see cref=""Condition"">Condition</see> types.  <see cref=""Condition"">Condition</see> types are reported differently from other <see cref=""Observation"">Observation</see> types. They are reported based on the <i>condition state</i> for each <see cref=""Condition"">Condition</see>.  The <see cref=""DataItem::type"" /> and <see cref=""DataItem::subType"" /> (where applicable) for a <see cref=""Condition"">Condition</see> <b>MAY</b> be any of the <see cref=""DataItem::type"" /> and <see cref=""DataItem::subType"" /> defined for <see cref=""DataItem"">DataItem</see>s with <see cref=""DataItem::category"" /> as <c>SAMPLE</c> or <see cref=""DataItem::category"" /> as <c>EVENT</c> listed in the <i>Device Information Model</i>.  This section lists additional <see cref=""Condition"">Condition</see> types that have been defined to represent the health and fault status of <i>Component</i>s.";

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
	}
}