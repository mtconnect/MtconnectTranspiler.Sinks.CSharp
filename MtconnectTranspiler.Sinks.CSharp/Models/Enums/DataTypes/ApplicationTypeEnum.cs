#pragma warning disable 0618
#pragma warning disable 1574
using System;
using System.CodeDom.Compiler;

namespace Mtconnect.DataTypes
{
	/// <summary>
	/// View in the MTConnect Model browser <seealso href="https://model.mtconnect.org/#Enumeration___19_0_3_45f01b9_1589825656758_905757_799">model.mtconnect.org</seealso>
	/// </summary>
	/// <remarks>
	/// <list type="bullet">
	/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_">v</see></item>
	/// <item><b>Deprecated</b>: <see href="https://model.mtconnect.org/#_Version_">v</see></item>
	/// </list>
	/// </remarks>
	[Obsolete("Deprecated in v according to https://model.mtconnect.org/#_Version_")]
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "1.0.15.3")]
	public enum ApplicationTypeEnum
	{
		/// <summary>
		/// computer aided design files or drawings. 
		/// </summary>
		DESIGN,
		/// <summary>
		/// generic data.
		/// </summary>
		DATA,
		/// <summary>
		/// documentation regarding a category of file.
		/// </summary>
		DOCUMENTATION,
		/// <summary>
		/// user instructions regarding the execution of a task. 
		/// </summary>
		INSTRUCTIONS,
		/// <summary>
		/// data related to the history of a machine or process.
		/// </summary>
		LOG,
		/// <summary>
		/// machine instructions to perform a process. 
		/// </summary>
		PRODUCTION_PROGRAM,
	}
}