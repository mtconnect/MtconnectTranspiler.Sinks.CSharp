#pragma warning disable 0618
#pragma warning disable 1574
using System;
using System.CodeDom.Compiler;

namespace Mtconnect.DataTypes
{
	/// <summary>
	/// View in the MTConnect Model browser <seealso href="https://model.mtconnect.org/#Enumeration__EAID_EF8EFACB_B3D8_4199_B5D5_84735797D463">model.mtconnect.org</seealso>
	/// </summary>
	/// <remarks>
	/// <list type="bullet">
	/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_">v</see></item>
	/// <item><b>Deprecated</b>: <see href="https://model.mtconnect.org/#_Version_">v</see></item>
	/// </list>
	/// </remarks>
	[Obsolete("Deprecated in v according to https://model.mtconnect.org/#_Version_")]
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "1.0.15.3")]
	public enum FilterEnum
	{
		/// <summary>
		/// new value <b>MUST NOT</b> be reported for a data item unless the measured value has changed from the last reported value by at least the delta given as the value of this element.  The value of <see cref="Filter">Filter</see> <b>MUST</b> be an absolute value using the same units as the reported data.
		/// </summary>
		MINIMUM_DELTA,
		/// <summary>
		/// data reported for a data item is provided on a periodic basis. The <c>PERIOD</c> for reporting data is defined in the value of the <see cref="Filter">Filter</see>.  The value of <see cref="Filter">Filter</see> <b>MUST</b> be an absolute value reported in seconds representing the time between reported samples of the value of the data item.
		/// </summary>
		PERIOD,
	}
}