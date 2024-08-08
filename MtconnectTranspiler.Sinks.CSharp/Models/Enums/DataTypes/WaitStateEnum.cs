#pragma warning disable 0618
#pragma warning disable 1574
using System;
using System.CodeDom.Compiler;

namespace Mtconnect.DataTypes
{
	/// <summary>
	/// View in the MTConnect Model browser <seealso href="https://model.mtconnect.org/#Enumeration___19_0_3_45f01b9_1581143980612_724749_76">model.mtconnect.org</seealso>
	/// </summary>
	/// <remarks>
	/// <list type="bullet">
	/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_">v</see></item>
	/// <item><b>Deprecated</b>: <see href="https://model.mtconnect.org/#_Version_">v</see></item>
	/// </list>
	/// </remarks>
	[Obsolete("Deprecated in v according to https://model.mtconnect.org/#_Version_")]
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.3.0.0")]
	public enum WaitStateEnum
	{
		/// <summary>
		/// execution is waiting while the equipment is powering up and is not currently available to begin producing parts or products.
		/// </summary>
		POWERING_UP,
		/// <summary>
		/// execution is waiting while the equipment is powering down but has not fully reached a stopped state.
		/// </summary>
		POWERING_DOWN,
		/// <summary>
		/// execution is waiting while one or more discrete workpieces are being loaded.
		/// </summary>
		PART_LOAD,
		/// <summary>
		/// execution is waiting while one or more discrete workpieces are being unloaded.
		/// </summary>
		PART_UNLOAD,
		/// <summary>
		/// execution is waiting while a tool or tooling is being loaded.
		/// </summary>
		TOOL_LOAD,
		/// <summary>
		/// execution is waiting while a tool or tooling is being unloaded.
		/// </summary>
		TOOL_UNLOAD,
		/// <summary>
		/// execution is waiting while material is being loaded.
		/// </summary>
		MATERIAL_LOAD,
		/// <summary>
		/// execution is waiting while material is being unloaded.
		/// </summary>
		MATERIAL_UNLOAD,
		/// <summary>
		/// execution is waiting while another process is completed before the execution can resume.
		/// </summary>
		SECONDARY_PROCESS,
		/// <summary>
		/// execution is waiting while the equipment is pausing but the piece of equipment has not yet reached a fully paused state.
		/// </summary>
		PAUSING,
		/// <summary>
		/// execution is waiting while the equipment is resuming the production cycle but has not yet resumed execution.
		/// </summary>
		RESUMING,
	}
}