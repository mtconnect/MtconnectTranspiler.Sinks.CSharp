#pragma warning disable 0618
#pragma warning disable 1574
using System;
using System.CodeDom.Compiler;

namespace Mtconnect.DataTypes
{
	/// <summary>
	/// View in the MTConnect Model browser <seealso href="https://model.mtconnect.org/#Enumeration__EAID_51F1600E_2F14_4045_86C0_42B336850079">model.mtconnect.org</seealso>
	/// </summary>
	/// <remarks>
	/// <list type="bullet">
	/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_">v</see></item>
	/// <item><b>Deprecated</b>: <see href="https://model.mtconnect.org/#_Version_">v</see></item>
	/// </list>
	/// </remarks>
	[Obsolete("Deprecated in v according to https://model.mtconnect.org/#_Version_")]
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.3.0.0")]
	public enum StatisticEnum
	{
		/// <summary>
		/// mathematical average value calculated for the data item during the calculation period.
		/// </summary>
		AVERAGE,
		/// <summary>
		/// <b>DEPRECATED</b> in <i>Version 1.6</i>s. ~~A measure of the "peakedness" of a probability distribution; i.e., the shape of the distribution curve.~~
		/// </summary>
		KURTOSIS,
		/// <summary>
		/// maximum or peak value recorded for the data item during the calculation period.
		/// </summary>
		MAXIMUM,
		/// <summary>
		/// middle number of a series of numbers.
		/// </summary>
		MEDIAN,
		/// <summary>
		/// minimum value recorded for the data item during the calculation period.
		/// </summary>
		MINIMUM,
		/// <summary>
		/// number in a series of numbers that occurs most often.
		/// </summary>
		MODE,
		/// <summary>
		/// difference between the maximum and minimum value of a data item during the calculation period. Also represents Peak-to-Peak measurement in a waveform.
		/// </summary>
		RANGE,
		/// <summary>
		/// mathematical Root Mean Square (RMS) value calculated for the data item during the calculation period.
		/// </summary>
		ROOT_MEAN_SQUARE,
		/// <summary>
		/// statistical Standard Deviation value calculated for the data item during the calculation period.
		/// </summary>
		STANDARD_DEVIATION,
	}
}