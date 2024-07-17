#pragma warning disable 0618
#pragma warning disable 1574
using System;
using System.CodeDom.Compiler;

namespace Mtconnect.DataTypes
{
	/// <summary>
	/// View in the MTConnect Model browser <seealso href="https://model.mtconnect.org/#Enumeration__EAID_782BD14C_FE49_4276_B7D0_7B42DA63B37F">model.mtconnect.org</seealso>
	/// </summary>
	/// <remarks>
	/// <list type="bullet">
	/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_">v</see></item>
	/// <item><b>Deprecated</b>: <see href="https://model.mtconnect.org/#_Version_">v</see></item>
	/// </list>
	/// </remarks>
	[Obsolete("Deprecated in v according to https://model.mtconnect.org/#_Version_")]
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "1.0.15.3")]
	public enum CutterStatusTypeEnum
	{
		/// <summary>
		/// new tool that has not been used or first use.   Marks the start of the tool history.
		/// </summary>
		NEW,
		/// <summary>
		/// tool is available for use.   If this is not present, the tool is currently not ready to be used.
		/// </summary>
		AVAILABLE,
		/// <summary>
		/// tool is unavailable for use in metal removal. 
		/// </summary>
		UNAVAILABLE,
		/// <summary>
		/// tool is has been committed to a piece of equipment for use and is not available for use in any other piece of equipment.
		/// </summary>
		ALLOCATED,
		/// <summary>
		/// tool has not been committed to a process and can be allocated.
		/// </summary>
		UNALLOCATED,
		/// <summary>
		/// tool has been measured. 
		/// </summary>
		MEASURED,
		/// <summary>
		/// tool has been reconditioned.
		/// </summary>
		RECONDITIONED,
		/// <summary>
		/// tool is in process and has remaining tool life.
		/// </summary>
		USED,
		/// <summary>
		/// tool has reached the end of its useful life.
		/// </summary>
		EXPIRED,
		/// <summary>
		/// premature tool failure.
		/// </summary>
		BROKEN,
		/// <summary>
		/// tool cannot be used until it is entered into the system.
		/// </summary>
		NOT_REGISTERED,
		/// <summary>
		/// tool is an indeterminate state. This is the default value.
		/// </summary>
		UNKNOWN,
	}
}