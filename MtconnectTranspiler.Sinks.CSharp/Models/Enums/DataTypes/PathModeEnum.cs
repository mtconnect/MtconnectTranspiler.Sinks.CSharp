#pragma warning disable 0618
#pragma warning disable 1574
using System;
using System.CodeDom.Compiler;

namespace Mtconnect.DataTypes
{
	/// <summary>
	/// View in the MTConnect Model browser <seealso href="https://model.mtconnect.org/#Enumeration___19_0_3_45f01b9_1580378417667_174664_2881">model.mtconnect.org</seealso>
	/// </summary>
	/// <remarks>
	/// <list type="bullet">
	/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_">v</see></item>
	/// <item><b>Deprecated</b>: <see href="https://model.mtconnect.org/#_Version_">v</see></item>
	/// </list>
	/// </remarks>
	[Obsolete("Deprecated in v according to https://model.mtconnect.org/#_Version_")]
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "1.0.15.3")]
	public enum PathModeEnum
	{
		/// <summary>
		/// path is operating independently and without the influence of another path.
		/// </summary>
		INDEPENDENT,
		/// <summary>
		/// path provides information or state values that influences the operation of other <see cref="DataItem">DataItem</see> of similar type.
		/// </summary>
		MASTER,
		/// <summary>
		/// physical or logical parts which are not physically connected to each other but are operating together.
		/// </summary>
		SYNCHRONOUS,
		/// <summary>
		/// axes associated with the path are mirroring the motion of the <c>MASTER</c> path.
		/// </summary>
		MIRROR,
	}
}