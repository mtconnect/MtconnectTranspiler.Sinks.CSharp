#pragma warning disable 0618
#pragma warning disable 1574
using System;
using System.CodeDom.Compiler;

namespace Mtconnect.DataTypes
{
	/// <summary>
	/// View in the MTConnect Model browser <seealso href="https://model.mtconnect.org/#Enumeration___19_0_3_68e0225_1643968895333_107274_240">model.mtconnect.org</seealso>
	/// </summary>
	/// <remarks>
	/// <list type="bullet">
	/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_">v</see></item>
	/// <item><b>Deprecated</b>: <see href="https://model.mtconnect.org/#_Version_">v</see></item>
	/// </list>
	/// </remarks>
	[Obsolete("Deprecated in v according to https://model.mtconnect.org/#_Version_")]
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.3.0.0")]
	public enum AlarmCodeEnum
	{
		/// <summary>
		/// spindle crashed.
		/// </summary>
		CRASH,
		/// <summary>
		/// component jammed.
		/// </summary>
		JAM,
		/// <summary>
		/// component failed.
		/// </summary>
		FAILURE,
		/// <summary>
		/// fault occurred on the component.
		/// </summary>
		FAULT,
		/// <summary>
		/// component has stalled and cannot move.
		/// </summary>
		STALLED,
		/// <summary>
		/// component is overloaded.
		/// </summary>
		OVERLOAD,
		/// <summary>
		/// ESTOP button was pressed.
		/// </summary>
		ESTOP,
		/// <summary>
		/// problem with the material.
		/// </summary>
		MATERIAL,
		/// <summary>
		/// system message.
		/// </summary>
		MESSAGE,
		/// <summary>
		/// alarm is not in any of the above categories.
		/// </summary>
		OTHER,
	}
}