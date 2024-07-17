#pragma warning disable 0618
#pragma warning disable 1574
using System;
using System.CodeDom.Compiler;

namespace Mtconnect.DataTypes
{
	/// <summary>
	/// View in the MTConnect Model browser <seealso href="https://model.mtconnect.org/#Enumeration___19_0_3_68e0225_1622456100008_63209_110">model.mtconnect.org</seealso>
	/// </summary>
	/// <remarks>
	/// <list type="bullet">
	/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_">v</see></item>
	/// <item><b>Deprecated</b>: <see href="https://model.mtconnect.org/#_Version_">v</see></item>
	/// </list>
	/// </remarks>
	[Obsolete("Deprecated in v according to https://model.mtconnect.org/#_Version_")]
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "1.0.15.3")]
	public enum ValveStateEnum
	{
		/// <summary>
		/// <see cref="ValveState">ValveState</see> where flow is allowed and the aperture is static.  > Note: For a binary value, <c>OPEN</c> indicates the valve has the maximum possible aperture.
		/// </summary>
		OPEN,
		/// <summary>
		/// valve is transitioning from a <c>CLOSED</c> state to an <c>OPEN</c> state.
		/// </summary>
		OPENING,
		/// <summary>
		/// <see cref="ValveState">ValveState</see> where flow is not possible, the aperture is static, and the valve is completely shut.
		/// </summary>
		CLOSED,
		/// <summary>
		/// valve is transitioning from an <c>OPEN</c> state to a <c>CLOSED</c> state.
		/// </summary>
		CLOSING,
	}
}