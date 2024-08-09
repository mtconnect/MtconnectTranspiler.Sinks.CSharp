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
	/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.3">v1.3</see></item>
	/// </list>
	/// </remarks>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.3.0.0")]
	public enum FilterEnum
	{
		/// <summary>
		/// new value <b>MUST NOT</b> be reported for a data item unless the measured value has changed from the last reported value by at least the delta given as the value of this element.  The value of <see cref="Filter">Filter</see> <b>MUST</b> be an absolute value using the same units as the reported data.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.3">v1.3</see></item>
		/// </list>
		/// </remarks>
		MINIMUM_DELTA,
		/// <summary>
		/// data reported for a data item is provided on a periodic basis. The <c>PERIOD</c> for reporting data is defined in the value of the <see cref="Filter">Filter</see>.  The value of <see cref="Filter">Filter</see> <b>MUST</b> be an absolute value reported in seconds representing the time between reported samples of the value of the data item.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.4">v1.4</see></item>
		/// </list>
		/// </remarks>
		PERIOD,
	}
}