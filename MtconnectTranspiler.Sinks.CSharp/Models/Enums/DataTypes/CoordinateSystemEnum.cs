#pragma warning disable 0618
#pragma warning disable 1574
using System;
using System.CodeDom.Compiler;

namespace Mtconnect.DataTypes
{
	/// <summary>
	/// View in the MTConnect Model browser <seealso href="https://model.mtconnect.org/#Enumeration__EAID_6B22B6F6_7073_4fa7_961B_B05AD4C7EF81">model.mtconnect.org</seealso>
	/// </summary>
	/// <remarks>
	/// <list type="bullet">
	/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_">v</see></item>
	/// <item><b>Deprecated</b>: <see href="https://model.mtconnect.org/#_Version_">v</see></item>
	/// </list>
	/// </remarks>
	[Obsolete("Deprecated in v according to https://model.mtconnect.org/#_Version_")]
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.3.0.0")]
	public enum CoordinateSystemEnum
	{
		/// <summary>
		/// unchangeable coordinate system that has machine zero as its origin.
		/// </summary>
		MACHINE,
		/// <summary>
		/// coordinate system that represents the working area for a particular workpiece whose origin is shifted within the <c>MACHINE</c> coordinate system.  If the <c>WORK</c> coordinates are not currently defined in the piece of equipment, the <c>MACHINE</c> coordinates will be used.
		/// </summary>
		WORK,
	}
}