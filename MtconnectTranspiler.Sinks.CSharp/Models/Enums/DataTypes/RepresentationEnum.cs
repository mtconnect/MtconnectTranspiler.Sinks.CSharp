#pragma warning disable 0618
#pragma warning disable 1574
using System;
using System.CodeDom.Compiler;

namespace Mtconnect.DataTypes
{
	/// <summary>
	/// View in the MTConnect Model browser <seealso href="https://model.mtconnect.org/#Enumeration__EAID_67CD6E1B_53E3_45c1_B84F_B0732F79528D">model.mtconnect.org</seealso>
	/// </summary>
	/// <remarks>
	/// <list type="bullet">
	/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_">v</see></item>
	/// <item><b>Deprecated</b>: <see href="https://model.mtconnect.org/#_Version_">v</see></item>
	/// </list>
	/// </remarks>
	[Obsolete("Deprecated in v according to https://model.mtconnect.org/#_Version_")]
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "1.0.15.3")]
	public enum RepresentationEnum
	{
		/// <summary>
		/// series of sampled data.  The data is reported for a specified number of samples and each sample is reported with a fixed period.
		/// </summary>
		TIME_SERIES,
		/// <summary>
		/// measured value of the sample data.  If no <see cref="DataItem::representation" /> is specified for a data item, the <see cref="DataItem::representation" /> <b>MUST</b> be determined to be <c>VALUE</c>.
		/// </summary>
		VALUE,
		/// <summary>
		/// reported value(s) are represented as a set of <i>key-value pair</i>s.  Each reported value in the <i>data set</i> <b>MUST</b> have a unique key.
		/// </summary>
		DATA_SET,
		/// <summary>
		/// <b>DEPRECATED</b> as <see cref="DataItem::representation" /> type in <i>MTConnect Version 1.5</i>s. Replaced by the <see cref="DataItem::discrete" />.
		/// </summary>
		DISCRETE,
		/// <summary>
		/// two dimensional set of <i>key-value pair</i>s where the <see cref="Entry">Entry</see> represents a row, and the value is a set of <i>key-value pair</i> <see cref="Cell">Cell</see> elements.   A <i>table</i> follows the same behavior as the <i>data set</i> for change tracking, clearing, and history. When an <see cref="Entry">Entry</see> changes, all <see cref="Cell">Cell</see> elements update as a single unit following the behavior of a <i>data set</i>.  > Note: It is best to use <see cref="Variable">Variable</see> if the <see cref="Cell">Cell</see> entities represent multiple semantic types.  Each <see cref="Entry">Entry</see> in the <i>table</i> <b>MUST</b> have a unique key. Each <see cref="Cell">Cell</see> of each <see cref="Entry">Entry</see> in the <i>table</i> <b>MUST</b> have a unique key.  See <see cref="Representation">Representation</see> in <see cref="Observation Information Model">Observation Information Model</see>, for a description of <see cref="Entry">Entry</see> and <see cref="Cell">Cell</see> elements.
		/// </summary>
		TABLE,
	}
}