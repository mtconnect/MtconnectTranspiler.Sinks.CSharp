#pragma warning disable 0618
#pragma warning disable 1574
using System;
using System.CodeDom.Compiler;

namespace Mtconnect.DataTypes
{
	/// <summary>
	/// View in the MTConnect Model browser <seealso href="https://model.mtconnect.org/#Enumeration___19_0_3_91b028d_1579537199908_332626_9197">model.mtconnect.org</seealso>
	/// </summary>
	/// <remarks>
	/// <list type="bullet">
	/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_">v</see></item>
	/// <item><b>Deprecated</b>: <see href="https://model.mtconnect.org/#_Version_">v</see></item>
	/// </list>
	/// </remarks>
	[Obsolete("Deprecated in v according to https://model.mtconnect.org/#_Version_")]
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.3.0.0")]
	public enum FormatTypeEnum
	{
		/// <summary>
		/// document will confirm to the ISO 10303 Part 21 standard. 
		/// </summary>
		EXPRESS,
		/// <summary>
		/// document will be a text representation of the tool data. 
		/// </summary>
		TEXT,
		/// <summary>
		/// document will be provided in an undefined format.
		/// </summary>
		UNDEFINED,
		/// <summary>
		/// default value for the definition. The content will be an <i>XML</i> document.
		/// </summary>
		XML,
	}
}