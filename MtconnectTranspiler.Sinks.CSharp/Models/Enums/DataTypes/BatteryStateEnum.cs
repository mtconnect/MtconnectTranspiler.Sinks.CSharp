#pragma warning disable 0618
#pragma warning disable 1574
using System;
using System.CodeDom.Compiler;

namespace Mtconnect.DataTypes
{
	/// <summary>
	/// View in the MTConnect Model browser <seealso href="https://model.mtconnect.org/#Enumeration___19_0_3_68e0225_1660318869483_263921_172">model.mtconnect.org</seealso>
	/// </summary>
	/// <remarks>
	/// <list type="bullet">
	/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_">v</see></item>
	/// <item><b>Deprecated</b>: <see href="https://model.mtconnect.org/#_Version_">v</see></item>
	/// </list>
	/// </remarks>
	[Obsolete("Deprecated in v according to https://model.mtconnect.org/#_Version_")]
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.3.0.0")]
	public enum BatteryStateEnum
	{
		/// <summary>
		/// <see cref="Component">Component</see> is at it's maximum rated charge level.
		/// </summary>
		CHARGED,
		/// <summary>
		/// <see cref="Component">Component</see>'s charge is increasing.
		/// </summary>
		CHARGING,
		/// <summary>
		/// <see cref="Component">Component</see>'s charge is decreasing.
		/// </summary>
		DISCHARGING,
		/// <summary>
		/// <see cref="Component">Component</see> is at it's minimum charge level.
		/// </summary>
		DISCHARGED,
	}
}