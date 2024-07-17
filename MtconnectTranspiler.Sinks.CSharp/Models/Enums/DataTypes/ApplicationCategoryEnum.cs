#pragma warning disable 0618
#pragma warning disable 1574
using System;
using System.CodeDom.Compiler;

namespace Mtconnect.DataTypes
{
	/// <summary>
	/// View in the MTConnect Model browser <seealso href="https://model.mtconnect.org/#Enumeration___19_0_3_45f01b9_1589825603246_243967_772">model.mtconnect.org</seealso>
	/// </summary>
	/// <remarks>
	/// <list type="bullet">
	/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_">v</see></item>
	/// <item><b>Deprecated</b>: <see href="https://model.mtconnect.org/#_Version_">v</see></item>
	/// </list>
	/// </remarks>
	[Obsolete("Deprecated in v according to https://model.mtconnect.org/#_Version_")]
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "1.0.15.3")]
	public enum ApplicationCategoryEnum
	{
		/// <summary>
		/// files regarding the fully assembled product.
		/// </summary>
		ASSEMBLY,
		/// <summary>
		/// device related files.
		/// </summary>
		DEVICE,
		/// <summary>
		/// files relating to the handling of material.
		/// </summary>
		HANDLING,
		/// <summary>
		/// files relating to equipment maintenance.
		/// </summary>
		MAINTENANCE,
		/// <summary>
		/// files relating to a part. 
		/// </summary>
		PART,
		/// <summary>
		/// files related to the manufacturing process.
		/// </summary>
		PROCESS,
		/// <summary>
		/// files related to the quality inspection.
		/// </summary>
		INSPECTION,
		/// <summary>
		/// files related to the setup of a process.
		/// </summary>
		SETUP,
	}
}