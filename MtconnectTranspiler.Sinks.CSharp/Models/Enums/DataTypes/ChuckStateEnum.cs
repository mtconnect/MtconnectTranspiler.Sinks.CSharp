#pragma warning disable 0618
#pragma warning disable 1574
using System;
using System.CodeDom.Compiler;

namespace Mtconnect.DataTypes
{
	/// <summary>
	/// View in the MTConnect Model browser <seealso href="https://model.mtconnect.org/#Enumeration___19_0_3_45f01b9_1580378417659_742691_2873">model.mtconnect.org</seealso>
	/// </summary>
	/// <remarks>
	/// <list type="bullet">
	/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_">v</see></item>
	/// <item><b>Deprecated</b>: <see href="https://model.mtconnect.org/#_Version_">v</see></item>
	/// </list>
	/// </remarks>
	[Obsolete("Deprecated in v according to https://model.mtconnect.org/#_Version_")]
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "1.0.15.3")]
	public enum ChuckStateEnum
	{
		/// <summary>
		/// <see cref="Chuck">Chuck</see> is open to the point of a positive confirmation.
		/// </summary>
		OPEN,
		/// <summary>
		/// <see cref="Chuck">Chuck</see> is closed to the point of a positive confirmation.
		/// </summary>
		CLOSED,
		/// <summary>
		/// <see cref="Chuck">Chuck</see> is not closed to the point of a positive confirmation and not open to the point of a positive confirmation.   It is in an intermediate position.
		/// </summary>
		UNLATCHED,
	}
}