#pragma warning disable 0618
#pragma warning disable 1574
using System;
using System.CodeDom.Compiler;

namespace Mtconnect.DataTypes
{
	/// <summary>
	/// View in the MTConnect Model browser <seealso href="https://model.mtconnect.org/#Enumeration___19_0_3_91b028d_1579277872728_249968_3735">model.mtconnect.org</seealso>
	/// </summary>
	/// <remarks>
	/// <list type="bullet">
	/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_">v</see></item>
	/// <item><b>Deprecated</b>: <see href="https://model.mtconnect.org/#_Version_">v</see></item>
	/// </list>
	/// </remarks>
	[Obsolete("Deprecated in v according to https://model.mtconnect.org/#_Version_")]
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "1.0.15.3")]
	public enum CategoryEnum
	{
		/// <summary>
		/// continuously variable or analog data value.   A continuous value can be measured at any point-in-time and will always produce a result.
		/// </summary>
		SAMPLE,
		/// <summary>
		/// discrete piece of information from the piece of equipment.
		/// </summary>
		EVENT,
		/// <summary>
		/// information about the health of a piece of equipment and its ability to function.
		/// </summary>
		CONDITION,
	}
}