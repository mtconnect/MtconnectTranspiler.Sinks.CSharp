using System;
using System.CodeDom.Compiler;using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;

namespace Mtconnect.DataTypes
{
	/// <summary>
	/// View in the MTConnect Model browser <seealso href="https://model.mtconnect.org/#Enumeration__EAID_51F1600E_2F14_4045_86C0_42B336850079">model.mtconnect.org</seealso>
	/// </summary>
	/// <remarks>
	/// <list type="bullet">
	/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.2">v1.2</see></item>
	/// </list>
	/// </remarks>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.3.0.0")]
	public enum StatisticEnum
	{
		/// <summary>
		/// mathematical average value calculated for the data item during the calculation period.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.2">v1.2</see></item>
		/// </list>
		/// </remarks>
		AVERAGE,
		/// <summary>
		/// <b>DEPRECATED</b> in <i>Version 1.6</i>s. ~~A measure of the "peakedness" of a probability distribution; i.e., the shape of the distribution curve.~~
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.2">v1.2</see></item>
		/// <item><b>Deprecated</b>: <see href="https://model.mtconnect.org/#_Version_1.6">v1.6</see></item>
		/// </list>
		/// </remarks>
		[Obsolete("Deprecated in v1.6 according to https://model.mtconnect.org/#_Version_1.6")]
		KURTOSIS,
		/// <summary>
		/// maximum or peak value recorded for the data item during the calculation period.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.2">v1.2</see></item>
		/// </list>
		/// </remarks>
		MAXIMUM,
		/// <summary>
		/// middle number of a series of numbers.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.2">v1.2</see></item>
		/// </list>
		/// </remarks>
		MEDIAN,
		/// <summary>
		/// minimum value recorded for the data item during the calculation period.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.2">v1.2</see></item>
		/// </list>
		/// </remarks>
		MINIMUM,
		/// <summary>
		/// number in a series of numbers that occurs most often.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.2">v1.2</see></item>
		/// </list>
		/// </remarks>
		MODE,
		/// <summary>
		/// difference between the maximum and minimum value of a data item during the calculation period. Also represents Peak-to-Peak measurement in a waveform.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.2">v1.2</see></item>
		/// </list>
		/// </remarks>
		RANGE,
		/// <summary>
		/// mathematical Root Mean Square (RMS) value calculated for the data item during the calculation period.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.2">v1.2</see></item>
		/// </list>
		/// </remarks>
		ROOT_MEAN_SQUARE,
		/// <summary>
		/// statistical Standard Deviation value calculated for the data item during the calculation period.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.2">v1.2</see></item>
		/// </list>
		/// </remarks>
		STANDARD_DEVIATION,
	}

	/// <summary>
	/// View in the MTConnect Model browser <seealso href="https://model.mtconnect.org/#Enumeration__EAID_51F1600E_2F14_4045_86C0_42B336850079">model.mtconnect.org</seealso>
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.3.0.0")]
	public sealed class StatisticEnumMetaClass : IEnum
	{
		/// <inheritdoc />
		public string Name => "StatisticEnum";
		
		/// <inheritdoc />
		public Type DataType => null;
		
		public Type Instance => typeof(StatisticEnum);

		/// <inheritdoc />
		public string NormativeVersion => "1.2";
		
		/// <inheritdoc />
		public string DeprecatedVersion => "";
		
		/// <inheritdoc />
		public string Summary => @"";
		
		/// <inheritdoc />
		public IEnumInstance[] Values => new IEnumInstance[] {
		AVERAGE,
		KURTOSIS,
		MAXIMUM,
		MEDIAN,
		MINIMUM,
		MODE,
		RANGE,
		ROOT_MEAN_SQUARE,
		STANDARD_DEVIATION,
		};

		private AVERAGEValue _AVERAGE;
		/// <summary>
		/// mathematical average value calculated for the data item during the calculation period.
		/// </summary>
		public AVERAGEValue AVERAGE => _AVERAGE ?? (_AVERAGE = new AVERAGEValue());

		/// <summary>
		/// mathematical average value calculated for the data item during the calculation period.
		/// </summary>
		public sealed class AVERAGEValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "AVERAGE";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.2";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// mathematical average value calculated for the data item during the calculation period.";
		}
		private KURTOSISValue _KURTOSIS;
		/// <summary>
		/// <b>DEPRECATED</b> in <i>Version 1.6</i>s. ~~A measure of the "peakedness" of a probability distribution; i.e., the shape of the distribution curve.~~
		/// </summary>
		public KURTOSISValue KURTOSIS => _KURTOSIS ?? (_KURTOSIS = new KURTOSISValue());

		/// <summary>
		/// <b>DEPRECATED</b> in <i>Version 1.6</i>s. ~~A measure of the "peakedness" of a probability distribution; i.e., the shape of the distribution curve.~~
		/// </summary>
		public sealed class KURTOSISValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "KURTOSIS";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.2";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "1.6";
			
			/// <inheritdoc />
			public string Summary => @"/// <b>DEPRECATED</b> in <i>Version 1.6</i>s. ~~A measure of the ""peakedness"" of a probability distribution; i.e., the shape of the distribution curve.~~";
		}
		private MAXIMUMValue _MAXIMUM;
		/// <summary>
		/// maximum or peak value recorded for the data item during the calculation period.
		/// </summary>
		public MAXIMUMValue MAXIMUM => _MAXIMUM ?? (_MAXIMUM = new MAXIMUMValue());

		/// <summary>
		/// maximum or peak value recorded for the data item during the calculation period.
		/// </summary>
		public sealed class MAXIMUMValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "MAXIMUM";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.2";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// maximum or peak value recorded for the data item during the calculation period.";
		}
		private MEDIANValue _MEDIAN;
		/// <summary>
		/// middle number of a series of numbers.
		/// </summary>
		public MEDIANValue MEDIAN => _MEDIAN ?? (_MEDIAN = new MEDIANValue());

		/// <summary>
		/// middle number of a series of numbers.
		/// </summary>
		public sealed class MEDIANValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "MEDIAN";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.2";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// middle number of a series of numbers.";
		}
		private MINIMUMValue _MINIMUM;
		/// <summary>
		/// minimum value recorded for the data item during the calculation period.
		/// </summary>
		public MINIMUMValue MINIMUM => _MINIMUM ?? (_MINIMUM = new MINIMUMValue());

		/// <summary>
		/// minimum value recorded for the data item during the calculation period.
		/// </summary>
		public sealed class MINIMUMValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "MINIMUM";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.2";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// minimum value recorded for the data item during the calculation period.";
		}
		private MODEValue _MODE;
		/// <summary>
		/// number in a series of numbers that occurs most often.
		/// </summary>
		public MODEValue MODE => _MODE ?? (_MODE = new MODEValue());

		/// <summary>
		/// number in a series of numbers that occurs most often.
		/// </summary>
		public sealed class MODEValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "MODE";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.2";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// number in a series of numbers that occurs most often.";
		}
		private RANGEValue _RANGE;
		/// <summary>
		/// difference between the maximum and minimum value of a data item during the calculation period. Also represents Peak-to-Peak measurement in a waveform.
		/// </summary>
		public RANGEValue RANGE => _RANGE ?? (_RANGE = new RANGEValue());

		/// <summary>
		/// difference between the maximum and minimum value of a data item during the calculation period. Also represents Peak-to-Peak measurement in a waveform.
		/// </summary>
		public sealed class RANGEValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "RANGE";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.2";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// difference between the maximum and minimum value of a data item during the calculation period. Also represents Peak-to-Peak measurement in a waveform.";
		}
		private ROOT_MEAN_SQUAREValue _ROOT_MEAN_SQUARE;
		/// <summary>
		/// mathematical Root Mean Square (RMS) value calculated for the data item during the calculation period.
		/// </summary>
		public ROOT_MEAN_SQUAREValue ROOT_MEAN_SQUARE => _ROOT_MEAN_SQUARE ?? (_ROOT_MEAN_SQUARE = new ROOT_MEAN_SQUAREValue());

		/// <summary>
		/// mathematical Root Mean Square (RMS) value calculated for the data item during the calculation period.
		/// </summary>
		public sealed class ROOT_MEAN_SQUAREValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "ROOT_MEAN_SQUARE";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.2";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// mathematical Root Mean Square (RMS) value calculated for the data item during the calculation period.";
		}
		private STANDARD_DEVIATIONValue _STANDARD_DEVIATION;
		/// <summary>
		/// statistical Standard Deviation value calculated for the data item during the calculation period.
		/// </summary>
		public STANDARD_DEVIATIONValue STANDARD_DEVIATION => _STANDARD_DEVIATION ?? (_STANDARD_DEVIATION = new STANDARD_DEVIATIONValue());

		/// <summary>
		/// statistical Standard Deviation value calculated for the data item during the calculation period.
		/// </summary>
		public sealed class STANDARD_DEVIATIONValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "STANDARD_DEVIATION";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.2";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// statistical Standard Deviation value calculated for the data item during the calculation period.";
		}
	}
}