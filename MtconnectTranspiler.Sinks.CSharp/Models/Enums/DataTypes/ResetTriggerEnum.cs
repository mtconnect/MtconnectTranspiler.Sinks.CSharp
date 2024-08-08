#pragma warning disable 0618
#pragma warning disable 1574
using System;
using System.CodeDom.Compiler;

namespace Mtconnect.DataTypes
{
	/// <summary>
	/// View in the MTConnect Model browser <seealso href="https://model.mtconnect.org/#Enumeration__EAID_8616CF52_2918_4462_A494_9F4A3EEFD597">model.mtconnect.org</seealso>
	/// </summary>
	/// <remarks>
	/// <list type="bullet">
	/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_">v</see></item>
	/// <item><b>Deprecated</b>: <see href="https://model.mtconnect.org/#_Version_">v</see></item>
	/// </list>
	/// </remarks>
	[Obsolete("Deprecated in v according to https://model.mtconnect.org/#_Version_")]
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.3.0.0")]
	public enum ResetTriggerEnum
	{
		/// <summary>
		/// <i>observation</i> of the <see cref="DataItem">DataItem</see> that is measuring an action or operation is to be reset upon completion of that action or operation.
		/// </summary>
		ACTION_COMPLETE,
		/// <summary>
		/// <i>observation</i> of the <see cref="DataItem">DataItem</see> is to be reset at the end of a 12-month period.
		/// </summary>
		ANNUAL,
		/// <summary>
		/// <i>observation</i> of the <see cref="DataItem">DataItem</see> is to be reset at the end of a 24-hour period.
		/// </summary>
		DAY,
		/// <summary>
		/// <i>observation</i> of the <see cref="DataItem">DataItem</see> is not reset and accumulates for the entire life of the piece of equipment.
		/// </summary>
		LIFE,
		/// <summary>
		/// <i>observation</i> of the <see cref="DataItem">DataItem</see> is to be reset upon completion of a maintenance event.
		/// </summary>
		MAINTENANCE,
		/// <summary>
		/// <i>observation</i> of the <see cref="DataItem">DataItem</see> is to be reset at the end of a monthly period.
		/// </summary>
		MONTH,
		/// <summary>
		/// <i>observation</i> of the <see cref="DataItem">DataItem</see> is to be reset when power was applied to the piece of equipment after a planned or unplanned interruption of power has occurred.
		/// </summary>
		POWER_ON,
		/// <summary>
		/// <i>observation</i> of the <see cref="DataItem">DataItem</see> is to be reset at the end of a work shift.
		/// </summary>
		SHIFT,
		/// <summary>
		/// <i>observation</i> of the <see cref="DataItem">DataItem</see> is to be reset at the end of a 7-day period.
		/// </summary>
		WEEK,
	}
}