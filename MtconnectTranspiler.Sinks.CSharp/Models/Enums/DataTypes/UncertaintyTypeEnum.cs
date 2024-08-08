#pragma warning disable 0618
#pragma warning disable 1574
using System;
using System.CodeDom.Compiler;

namespace Mtconnect.DataTypes
{
	/// <summary>
	/// View in the MTConnect Model browser <seealso href="https://model.mtconnect.org/#Enumeration___19_0_3_68e0225_1678195766304_380006_17434">model.mtconnect.org</seealso>
	/// </summary>
	/// <remarks>
	/// <list type="bullet">
	/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_">v</see></item>
	/// <item><b>Deprecated</b>: <see href="https://model.mtconnect.org/#_Version_">v</see></item>
	/// </list>
	/// </remarks>
	[Obsolete("Deprecated in v according to https://model.mtconnect.org/#_Version_")]
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.3.0.0")]
	public enum UncertaintyTypeEnum
	{
		/// <summary>
		/// <i>combined standard uncertainty</i>.
		/// </summary>
		COMBINED,
		/// <summary>
		/// <i>standard uncertainty</i> using arithmetic mean or average the observations. <seealso href="https://www.google.com/search?q=JCGM 100:2008 4.2&btnI=I">JCGM 100:2008 4.2</seealso>
		/// </summary>
		MEAN,
	}
}