#pragma warning disable 0618
#pragma warning disable 1574
using System;
using System.CodeDom.Compiler;

namespace Mtconnect.DataTypes
{
	/// <summary>
	/// View in the MTConnect Model browser <seealso href="https://model.mtconnect.org/#Enumeration___19_0_3_68e0225_1634824001211_966890_187">model.mtconnect.org</seealso>
	/// </summary>
	/// <remarks>
	/// <list type="bullet">
	/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_">v</see></item>
	/// <item><b>Deprecated</b>: <see href="https://model.mtconnect.org/#_Version_">v</see></item>
	/// </list>
	/// </remarks>
	[Obsolete("Deprecated in v according to https://model.mtconnect.org/#_Version_")]
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.3.0.0")]
	public enum ToolLifeEnum
	{
		/// <summary>
		/// tool life measured in minutes.   All units for minimum, maximum, and nominal <b>MUST</b> be provided in minutes.
		/// </summary>
		MINUTES,
		/// <summary>
		/// tool life measured in parts.   All units for minimum, maximum, and nominal <b>MUST</b> be provided as the number of parts.
		/// </summary>
		PART_COUNT,
		/// <summary>
		/// tool life measured in tool wear.   Wear <b>MUST</b> be provided in millimeters as an offset to nominal. All units for minimum, maximum, and nominal <b>MUST</b> be given as millimeter offsets as well. The standard will only consider dimensional wear at this time.
		/// </summary>
		WEAR,
	}
}