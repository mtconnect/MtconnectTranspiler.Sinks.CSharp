#pragma warning disable 0618
#pragma warning disable 1574
using System;
using System.CodeDom.Compiler;

namespace Mtconnect.DataTypes
{
	/// <summary>
	/// View in the MTConnect Model browser <seealso href="https://model.mtconnect.org/#Enumeration___19_0_3_45f01b9_1579566531118_10952_25736">model.mtconnect.org</seealso>
	/// </summary>
	/// <remarks>
	/// <list type="bullet">
	/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_">v</see></item>
	/// <item><b>Deprecated</b>: <see href="https://model.mtconnect.org/#_Version_">v</see></item>
	/// </list>
	/// </remarks>
	[Obsolete("Deprecated in v according to https://model.mtconnect.org/#_Version_")]
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "1.0.15.3")]
	public enum ResetTriggeredEnum
	{
		/// <summary>
		/// <see cref="Observation::result" /> is measuring an action or operation was reset upon completion of that action or operation.
		/// </summary>
		ACTION_COMPLETE,
		/// <summary>
		/// <see cref="Observation::result" /> was reset at the end of a 12-month period.
		/// </summary>
		ANNUAL,
		/// <summary>
		/// <see cref="Observation::result" /> was reset at the end of a 24-hour period.
		/// </summary>
		DAY,
		/// <summary>
		/// <see cref="Observation::result" /> was reset upon completion of a maintenance event.
		/// </summary>
		MAINTENANCE,
		/// <summary>
		/// <see cref="Observation::result" /> was reset based on a physical reset action.
		/// </summary>
		MANUAL,
		/// <summary>
		/// <see cref="Observation::result" /> was reset at the end of a monthly period.
		/// </summary>
		MONTH,
		/// <summary>
		/// <see cref="Observation::result" /> was reset when power was applied to the piece of equipment after a planned or unplanned interruption of power has occurred.
		/// </summary>
		POWER_ON,
		/// <summary>
		/// <see cref="Observation::result" /> was reset at the end of a work shift.
		/// </summary>
		SHIFT,
		/// <summary>
		/// <see cref="Observation::result" /> was reset at the end of a 7-day period.
		/// </summary>
		WEEK,
	}
}