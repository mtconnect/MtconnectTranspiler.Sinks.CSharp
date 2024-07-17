#pragma warning disable 0618
#pragma warning disable 1574
using System;
using System.CodeDom.Compiler;

namespace Mtconnect.DataTypes
{
	/// <summary>
	/// View in the MTConnect Model browser <seealso href="https://model.mtconnect.org/#Enumeration___19_0_3_68e0225_1605550283222_680737_1925">model.mtconnect.org</seealso>
	/// </summary>
	/// <remarks>
	/// <list type="bullet">
	/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_">v</see></item>
	/// <item><b>Deprecated</b>: <see href="https://model.mtconnect.org/#_Version_">v</see></item>
	/// </list>
	/// </remarks>
	[Obsolete("Deprecated in v according to https://model.mtconnect.org/#_Version_")]
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "1.0.15.3")]
	public enum ProcessStateEnum
	{
		/// <summary>
		/// device is preparing to execute the process occurrence.
		/// </summary>
		INITIALIZING,
		/// <summary>
		/// process occurrence is ready to be executed.
		/// </summary>
		READY,
		/// <summary>
		/// process occurrence is actively executing.
		/// </summary>
		ACTIVE,
		/// <summary>
		/// process occurrence is now finished.
		/// </summary>
		COMPLETE,
		/// <summary>
		/// process occurrence has been stopped and may be resumed.
		/// </summary>
		INTERRUPTED,
		/// <summary>
		/// process occurrence has come to a premature end and cannot be resumed.
		/// </summary>
		ABORTED,
	}
}