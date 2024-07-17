#pragma warning disable 0618
#pragma warning disable 1574
using System;
using System.CodeDom.Compiler;

namespace Mtconnect.DataTypes
{
	/// <summary>
	/// View in the MTConnect Model browser <seealso href="https://model.mtconnect.org/#Enumeration___19_0_3_45f01b9_1580378417665_982246_2879">model.mtconnect.org</seealso>
	/// </summary>
	/// <remarks>
	/// <list type="bullet">
	/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_">v</see></item>
	/// <item><b>Deprecated</b>: <see href="https://model.mtconnect.org/#_Version_">v</see></item>
	/// </list>
	/// </remarks>
	[Obsolete("Deprecated in v according to https://model.mtconnect.org/#_Version_")]
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "1.0.15.3")]
	public enum FunctionalModeEnum
	{
		/// <summary>
		/// <see cref="Component">Component</see> is currently producing product, ready to produce product, or its current intended use is to be producing product.
		/// </summary>
		PRODUCTION,
		/// <summary>
		/// <see cref="Component">Component</see> is not currently producing product.   It is being prepared or modified to begin production of product.
		/// </summary>
		SETUP,
		/// <summary>
		/// <see cref="Component">Component</see> is not currently producing product.  Typically, it has completed the production of a product and is being modified or returned to a neutral state such that it may then be prepared to begin production of a different product.
		/// </summary>
		TEARDOWN,
		/// <summary>
		/// <see cref="Component">Component</see> is not currently producing product.  It is currently being repaired, waiting to be repaired, or has not yet been returned to a normal production status after maintenance has been performed.
		/// </summary>
		MAINTENANCE,
		/// <summary>
		/// <see cref="Component">Component</see> is being used to prove-out a new process, testing of equipment or processes, or any other active use that does not result in the production of product.
		/// </summary>
		PROCESS_DEVELOPMENT,
	}
}