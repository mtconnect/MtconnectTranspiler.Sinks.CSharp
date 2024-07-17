#pragma warning disable 0618
#pragma warning disable 1574
using System;
using System.CodeDom.Compiler;

namespace Mtconnect.DataTypes
{
	/// <summary>
	/// View in the MTConnect Model browser <seealso href="https://model.mtconnect.org/#Enumeration___19_0_3_45f01b9_1580378417667_46066_2882">model.mtconnect.org</seealso>
	/// </summary>
	/// <remarks>
	/// <list type="bullet">
	/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_">v</see></item>
	/// <item><b>Deprecated</b>: <see href="https://model.mtconnect.org/#_Version_">v</see></item>
	/// </list>
	/// </remarks>
	[Obsolete("Deprecated in v according to https://model.mtconnect.org/#_Version_")]
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "1.0.15.3")]
	public enum ProgramEditEnum
	{
		/// <summary>
		/// <see cref="Controller">Controller</see> is in the program edit mode.
		/// </summary>
		ACTIVE,
		/// <summary>
		/// <see cref="Controller">Controller</see> is capable of entering the program edit mode and no function is inhibiting a change to that mode.
		/// </summary>
		READY,
		/// <summary>
		/// <see cref="Controller">Controller</see> is being inhibited by a function from entering the program edit mode.
		/// </summary>
		NOT_READY,
	}
}