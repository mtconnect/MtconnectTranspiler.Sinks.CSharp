using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;
using Package = Mtconnect.DeviceInformationModel.DataItems.DataItemTypes;
// using Mtconnect;

namespace Mtconnect.DeviceInformationModel.DataItems
{
	/// <summary>
	/// This section provides semantic information for the types of a <see cref="DataItem">DataItem</see>.  In the MTConnect Standard, <see cref="DataItem">DataItem</see> are defined and organized based upon the <see cref="DataItem::category" /> and <see cref="DataItem::type" />.  The <see cref="DataItem::category" /> provides a high level grouping for <see cref="DataItem">DataItem</see>s based on the kind of information that is reported by the data item.  These categories are:  * <c>SAMPLE</c>: A <c>SAMPLE</c> reports a continuously variable or analog data value.   * <c>EVENT</c>: An <c>EVENT</c> reports information representing a functional state, with two or more discrete values, associated with a component or it contains a message.  The data provided may be a numeric value or text.  * <c>CONDITION</c>: A <c>CONDITION</c> reports information about the health of a piece of equipment and its ability to function.  The <see cref="DataItem::type" /> specifies the specific kind of data that is reported.   For some types of data items, a <see cref="DataItem::subType" /> may also be used to differentiate between multiple data items of the same <see cref="DataItem::type" /> where the information reported by the data item has a different, but related, meaning.  Many types of data items provide two forms of data: a value (reported as either a <c>SAMPLE</c> or <c>EVENT</c>) and a health status (reported as a <c>CONDITION</c>).  These <see cref="DataItem">DataItem</see> types <b>MAY</b> be defined in more than one <see cref="DataItem::category" /> based on the data that they report. 
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.3.0.0")]
	public class DataItemTypesPackage : IPackage
	{
		/// <inheritdoc />
		public string ReferenceId => "EAPK_3CC32EA3_C0E8_4cbe_8239_C706EC74F116";
		
		/// <inheritdoc />
		public string Name => "DataItemTypes";

		/// <inheritdoc />
		public string Summary => @"/// This section provides semantic information for the types of a <see cref=""DataItem"">DataItem</see>.  In the MTConnect Standard, <see cref=""DataItem"">DataItem</see> are defined and organized based upon the <see cref=""DataItem::category"" /> and <see cref=""DataItem::type"" />.  The <see cref=""DataItem::category"" /> provides a high level grouping for <see cref=""DataItem"">DataItem</see>s based on the kind of information that is reported by the data item.  These categories are:  * <c>SAMPLE</c>: A <c>SAMPLE</c> reports a continuously variable or analog data value.   * <c>EVENT</c>: An <c>EVENT</c> reports information representing a functional state, with two or more discrete values, associated with a component or it contains a message.  The data provided may be a numeric value or text.  * <c>CONDITION</c>: A <c>CONDITION</c> reports information about the health of a piece of equipment and its ability to function.  The <see cref=""DataItem::type"" /> specifies the specific kind of data that is reported.   For some types of data items, a <see cref=""DataItem::subType"" /> may also be used to differentiate between multiple data items of the same <see cref=""DataItem::type"" /> where the information reported by the data item has a different, but related, meaning.  Many types of data items provide two forms of data: a value (reported as either a <c>SAMPLE</c> or <c>EVENT</c>) and a health status (reported as a <c>CONDITION</c>).  These <see cref=""DataItem"">DataItem</see> types <b>MAY</b> be defined in more than one <see cref=""DataItem::category"" /> based on the data that they report. ";

		/// <inheritdoc />
		public IPackage[] Packages => new IPackage[] {
		};
		
		/// <inheritdoc />
		public IClass[] Classes => new IClass[] {
			EventClass,
			SampleClass,
			ConditionClass,
		};
		#region Packages
	#endregion

	#region Classes
	private Package.EventClass _EventClass;
	/// <summary>
	/// <inheritdoc cref="Package.EventClass" path="/summary" />
	/// </summary>
	public Package.EventClass EventClass => _EventClass ?? (_EventClass = new Package.EventClass());

	private Package.SampleClass _SampleClass;
	/// <summary>
	/// <inheritdoc cref="Package.SampleClass" path="/summary" />
	/// </summary>
	public Package.SampleClass SampleClass => _SampleClass ?? (_SampleClass = new Package.SampleClass());

	private Package.ConditionClass _ConditionClass;
	/// <summary>
	/// <inheritdoc cref="Package.ConditionClass" path="/summary" />
	/// </summary>
	public Package.ConditionClass ConditionClass => _ConditionClass ?? (_ConditionClass = new Package.ConditionClass());

	#endregion
	}
}