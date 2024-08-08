#pragma warning disable 0618
#pragma warning disable 1574
using System;
using System.CodeDom.Compiler;

namespace Mtconnect.DataTypes
{
	/// <summary>
	/// View in the MTConnect Model browser <seealso href="https://model.mtconnect.org/#Enumeration___19_0_3_91b028d_1587753036369_787594_4254">model.mtconnect.org</seealso>
	/// </summary>
	/// <remarks>
	/// <list type="bullet">
	/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_">v</see></item>
	/// <item><b>Deprecated</b>: <see href="https://model.mtconnect.org/#_Version_">v</see></item>
	/// </list>
	/// </remarks>
	[Obsolete("Deprecated in v according to https://model.mtconnect.org/#_Version_")]
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.3.0.0")]
	public enum DirectionRotaryEnum
	{
		/// <summary>
		/// clockwise rotation using the right-hand rule.
		/// </summary>
		CLOCKWISE,
		/// <summary>
		/// counter-clockwise rotation using the right-hand rule.
		/// </summary>
		COUNTER_CLOCKWISE,
		/// <summary>
		/// no direction.
		/// </summary>
		NONE,
	}
}