#pragma warning disable 0618
#pragma warning disable 1574
using System;
using System.CodeDom.Compiler;

namespace Mtconnect.DataTypes
{
	/// <summary>
	/// View in the MTConnect Model browser <seealso href="https://model.mtconnect.org/#Enumeration___19_0_3_45f01b9_1580378417661_25421_2875">model.mtconnect.org</seealso>
	/// </summary>
	/// <remarks>
	/// <list type="bullet">
	/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_">v</see></item>
	/// <item><b>Deprecated</b>: <see href="https://model.mtconnect.org/#_Version_">v</see></item>
	/// </list>
	/// </remarks>
	[Obsolete("Deprecated in v according to https://model.mtconnect.org/#_Version_")]
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "1.0.15.3")]
	public enum ControllerModeOverrideEnum
	{
		/// <summary>
		/// <see cref="ControllerModeOverride">ControllerModeOverride</see> is in the <c>ON</c> state and the mode override is active.
		/// </summary>
		ON,
		/// <summary>
		/// <see cref="ControllerModeOverride">ControllerModeOverride</see> is in the <c>OFF</c> state and the mode override is inactive.
		/// </summary>
		OFF,
	}
}