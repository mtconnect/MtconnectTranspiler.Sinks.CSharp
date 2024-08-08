#pragma warning disable 0618
#pragma warning disable 1574
using System;
using System.CodeDom.Compiler;

namespace Mtconnect.DataTypes
{
	/// <summary>
	/// View in the MTConnect Model browser <seealso href="https://model.mtconnect.org/#Enumeration___19_0_3_45f01b9_1580378417657_726565_2871">model.mtconnect.org</seealso>
	/// </summary>
	/// <remarks>
	/// <list type="bullet">
	/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_">v</see></item>
	/// <item><b>Deprecated</b>: <see href="https://model.mtconnect.org/#_Version_">v</see></item>
	/// </list>
	/// </remarks>
	[Obsolete("Deprecated in v according to https://model.mtconnect.org/#_Version_")]
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.3.0.0")]
	public enum AxisCouplingEnum
	{
		/// <summary>
		/// axes are physically connected to each other and operate as a single unit.
		/// </summary>
		TANDEM,
		/// <summary>
		/// axes are not physically connected to each other but are operating together in lockstep.
		/// </summary>
		SYNCHRONOUS,
		/// <summary>
		/// axis is the master of the <see cref="CoupledAxes">CoupledAxes</see>.
		/// </summary>
		MASTER,
		/// <summary>
		/// axis is a slave to the <see cref="CoupledAxes">CoupledAxes</see>.
		/// </summary>
		SLAVE,
	}
}