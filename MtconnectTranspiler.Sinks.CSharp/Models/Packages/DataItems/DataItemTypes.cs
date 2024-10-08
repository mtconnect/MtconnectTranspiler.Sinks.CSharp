#pragma warning disable CS1574 // XML comment has cref attribute that could not be resolved
#pragma warning disable CS1584 // XML comment has syntactically incorrect cref attribute
#pragma warning disable CS0618 // Type or member is obsolete
using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;
using Package = Mtconnect.DeviceInformationModel.DataItems.DataItemTypes;

namespace Mtconnect.DeviceInformationModel.DataItems
{
	/// <summary>﻿This section provides semantic information for the types of a <see cref="DataItem">DataItem</see>.<br /><br />In the MTConnect Standard, <see cref="DataItem">DataItem</see> are defined and organized based upon the <see cref="DataItem.category">category in DataItem</see> and <see cref="DataItem.type">type in DataItem</see>.  The <see cref="DataItem.category">category in DataItem</see> provides a high level grouping for <see cref="DataItem">DataItem</see>s based on the kind of information that is reported by the data item.<br /><br />These categories are:<br /><br />* <c>SAMPLE</c>: A <c>SAMPLE</c> reports a continuously variable or analog data value. <br /><br />* <c>EVENT</c>: An <c>EVENT</c> reports information representing a functional state, with two or more discrete values, associated with a component or it contains a message.  The data provided may be a numeric value or text.<br /><br />* <c>CONDITION</c>: A <c>CONDITION</c> reports information about the health of a piece of equipment and its ability to function.<br /><br />The <see cref="DataItem.type">type in DataItem</see> specifies the specific kind of data that is reported.   For some types of data items, a <see cref="DataItem.subType">subType in DataItem</see> may also be used to differentiate between multiple data items of the same <see cref="DataItem.type">type in DataItem</see> where the information reported by the data item has a different, but related, meaning.<br /><br />Many types of data items provide two forms of data: a value (reported as either a <c>SAMPLE</c> or <c>EVENT</c>) and a health status (reported as a <c>CONDITION</c>).  These <see cref="DataItem">DataItem</see> types <b>MAY</b> be defined in more than one <see cref="DataItem.category">category in DataItem</see> based on the data that they report.<br /><br /><br /><br />
	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Package__EAPK_3CC32EA3_C0E8_4cbe_8239_C706EC74F116">model.mtconnect.org</seealso> for more information.
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public class DataItemTypesPackage : IPackage
	{
		/// <summary>Constant value for <see cref="DataItemTypesPackage.ReferenceId" /></summary>
		public const string REFERENCE_ID = "EAPK_3CC32EA3_C0E8_4cbe_8239_C706EC74F116";
		/// <summary>Constant value for <see cref="DataItemTypesPackage.HelpUrl" /></summary>
		public const string HELP_URL = "https://model.mtconnect.org/#Package__EAPK_3CC32EA3_C0E8_4cbe_8239_C706EC74F116";
		/// <summary>Constant value for <see cref="DataItemTypesPackage.Name" /></summary>
		public const string NAME = "DataItem Types";
		/// <summary>Constant value for <see cref="DataItemTypesPackage.Summary" /></summary>
		public const string SUMMARY = @"&#10;&#10;&#10;This section provides semantic information for the types of a {{block(DataItem)}}.

In the MTConnect Standard, {{block(DataItem)}} are defined and organized based upon the {{property(DataItem::category)}} and {{property(DataItem::type)}}.  The {{property(DataItem::category)}} provides a high level grouping for {{block(DataItem)}}s based on the kind of information that is reported by the data item.

These categories are:

* `SAMPLE`: A `SAMPLE` reports a continuously variable or analog data value. 

* `EVENT`: An `EVENT` reports information representing a functional state, with two or more discrete values, associated with a component or it contains a message.  The data provided may be a numeric value or text.

* `CONDITION`: A `CONDITION` reports information about the health of a piece of equipment and its ability to function.

The {{property(DataItem::type)}} specifies the specific kind of data that is reported.   For some types of data items, a {{property(DataItem::subType)}} may also be used to differentiate between multiple data items of the same {{property(DataItem::type)}} where the information reported by the data item has a different, but related, meaning.

Many types of data items provide two forms of data: a value (reported as either a `SAMPLE` or `EVENT`) and a health status (reported as a `CONDITION`).  These {{block(DataItem)}} types **MAY** be defined in more than one {{property(DataItem::category)}} based on the data that they report.
&#10;
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
		};
		
		/// <inheritdoc />
		public IClass[] Classes => new IClass[] {
			EventClass,
			SampleClass,
			ConditionClass,
		};
		
		/// <inheritdoc />
		public IEnum[] Enums => new IEnum[] {
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

	#region Enums
	#endregion
	}
}