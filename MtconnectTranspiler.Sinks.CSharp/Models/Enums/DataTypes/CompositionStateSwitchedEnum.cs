#pragma warning disable 0618
#pragma warning disable 1574
using System;
using System.CodeDom.Compiler;

namespace Mtconnect.DataTypes
{
	/// <summary>
	/// View in the MTConnect Model browser <seealso href="https://model.mtconnect.org/#Enumeration___19_0_3_68e0225_1612550781451_530503_112">model.mtconnect.org</seealso>
	/// </summary>
	/// <remarks>
	/// <list type="bullet">
	/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_">v</see></item>
	/// <item><b>Deprecated</b>: <see href="https://model.mtconnect.org/#_Version_">v</see></item>
	/// </list>
	/// </remarks>
	[Obsolete("Deprecated in v according to https://model.mtconnect.org/#_Version_")]
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.3.0.0")]
	public enum CompositionStateSwitchedEnum
	{
		/// <summary>
		/// activation state of the <see cref="Composition">Composition</see> is in an <c>ON</c> condition, it is operating, or it is powered.
		/// </summary>
		ON,
		/// <summary>
		/// activation state of the <see cref="Composition">Composition</see> is in an <c>OFF</c> condition, it is not operating, or it is not powered.
		/// </summary>
		OFF,
	}
}