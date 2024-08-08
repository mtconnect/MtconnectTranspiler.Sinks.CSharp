#pragma warning disable 0618
#pragma warning disable 1574
using System;
using System.CodeDom.Compiler;

namespace Mtconnect.DataTypes
{
	/// <summary>
	/// View in the MTConnect Model browser <seealso href="https://model.mtconnect.org/#Enumeration___19_0_3_68e0225_1678195723846_572772_17405">model.mtconnect.org</seealso>
	/// </summary>
	/// <remarks>
	/// <list type="bullet">
	/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_">v</see></item>
	/// <item><b>Deprecated</b>: <see href="https://model.mtconnect.org/#_Version_">v</see></item>
	/// </list>
	/// </remarks>
	[Obsolete("Deprecated in v according to https://model.mtconnect.org/#_Version_")]
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.3.0.0")]
	public enum CharacteristicStatusEnum
	{
		/// <summary>
		/// measurement is within acceptable tolerances.
		/// </summary>
		PASS,
		/// <summary>
		/// measurement is not within acceptable tolerances.
		/// </summary>
		FAIL,
		/// <summary>
		/// failed, but acceptable constraints achievable by utilizing additional manufacturing processes.
		/// </summary>
		REWORK,
		/// <summary>
		/// measurement is indeterminate due to an equipment failure.
		/// </summary>
		SYSTEM_ERROR,
		/// <summary>
		/// measurement cannot be determined.
		/// </summary>
		INDETERMINATE,
		/// <summary>
		/// measurement cannot be evaluated.
		/// </summary>
		NOT_ANALYZED,
		/// <summary>
		/// nominal provided without tolerance limits. <seealso href="https://www.google.com/search?q=QIF 3:2018 5.10.2.6&btnI=I">QIF 3:2018 5.10.2.6</seealso>
		/// </summary>
		BASIC_OR_THEORETIC_EXACT_DIMENSION,
		/// <summary>
		/// status of measurement cannot be determined.
		/// </summary>
		UNDEFINED,
	}
}