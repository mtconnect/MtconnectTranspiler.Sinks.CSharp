#pragma warning disable CS1574 // XML comment has cref attribute that could not be resolved
#pragma warning disable CS1584 // XML comment has syntactically incorrect cref attribute
using System;
using System.CodeDom.Compiler;using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;

namespace Mtconnect.DataTypes
{
	/// <summary>﻿
	/// <br/> Visit <seealso href="https://model.mtconnect.org/#Enumeration__EAID_51F1600E_2F14_4045_86C0_42B336850079">model.mtconnect.org</seealso> for more information.
	/// </summary>
	/// <remarks>
	/// <list type="bullet">
	/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.2">v1.2</see></item>
	/// </list>
	/// </remarks>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public enum StatisticEnum
	{
		/// <summary>﻿mathematical average value calculated for the data item during the calculation period.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.2">v1.2</see></item>
		/// </list>
		/// </remarks>
		AVERAGE,
		/// <summary>﻿<b>DEPRECATED</b> in <i>Version 1.6</i>. ~~A measure of the "peakedness" of a probability distribution; i.e., the shape of the distribution curve.~~<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.2">v1.2</see></item>
		/// <item><b>Deprecated</b>: <see href="https://model.mtconnect.org/#_Version_1.6">v1.6</see></item>
		/// </list>
		/// </remarks>
		[Obsolete("Deprecated in v1.6 according to https://model.mtconnect.org/#_Version_1.6")]
		KURTOSIS,
		/// <summary>﻿maximum or peak value recorded for the data item during the calculation period.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.2">v1.2</see></item>
		/// </list>
		/// </remarks>
		MAXIMUM,
		/// <summary>﻿middle number of a series of numbers.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.2">v1.2</see></item>
		/// </list>
		/// </remarks>
		MEDIAN,
		/// <summary>﻿minimum value recorded for the data item during the calculation period.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.2">v1.2</see></item>
		/// </list>
		/// </remarks>
		MINIMUM,
		/// <summary>﻿number in a series of numbers that occurs most often.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.2">v1.2</see></item>
		/// </list>
		/// </remarks>
		MODE,
		/// <summary>﻿difference between the maximum and minimum value of a data item during the calculation period. Also represents Peak-to-Peak measurement in a waveform.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.2">v1.2</see></item>
		/// </list>
		/// </remarks>
		RANGE,
		/// <summary>﻿mathematical Root Mean Square (RMS) value calculated for the data item during the calculation period.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.2">v1.2</see></item>
		/// </list>
		/// </remarks>
		ROOT_MEAN_SQUARE,
		/// <summary>﻿statistical Standard Deviation value calculated for the data item during the calculation period.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.2">v1.2</see></item>
		/// </list>
		/// </remarks>
		STANDARD_DEVIATION,
	}

	/// <summary>﻿
	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Enumeration__EAID_51F1600E_2F14_4045_86C0_42B336850079">model.mtconnect.org</seealso> for more information.
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public sealed class StatisticEnumMetaClass : IEnum
	{
		/// <inheritdoc />
		public string Name => "StatisticEnum";
		
		/// <inheritdoc />
		public Type DataType => null;
		
		/// <inheritdoc />
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
		/// <inheritdoc cref="AVERAGEValue" path="/summary" />
		public AVERAGEValue AVERAGE => _AVERAGE ?? (_AVERAGE = new AVERAGEValue());

		/// <summary>﻿mathematical average value calculated for the data item during the calculation period.<br /><br /><br />
		/// Value for StatisticEnum.<br/>
		/// <br/>See also <seealso cref="StatisticEnum">StatisticEnum</seealso>
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
			public string Summary => @"&#10;&#10;&#10;mathematical average value calculated for the data item during the calculation period.&#10;
";
		}
		private KURTOSISValue _KURTOSIS;
		/// <inheritdoc cref="KURTOSISValue" path="/summary" />
		public KURTOSISValue KURTOSIS => _KURTOSIS ?? (_KURTOSIS = new KURTOSISValue());

		/// <summary>﻿<b>DEPRECATED</b> in <i>Version 1.6</i>. ~~A measure of the "peakedness" of a probability distribution; i.e., the shape of the distribution curve.~~<br /><br /><br />
		/// Value for StatisticEnum.<br/>
		/// <br/>See also <seealso cref="StatisticEnum">StatisticEnum</seealso>
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
			public string Summary => @"&#10;&#10;&#10;**DEPRECATED** in *Version 1.6*. ~~A measure of the ""peakedness"" of a probability distribution; i.e., the shape of the distribution curve.~~&#10;
";
		}
		private MAXIMUMValue _MAXIMUM;
		/// <inheritdoc cref="MAXIMUMValue" path="/summary" />
		public MAXIMUMValue MAXIMUM => _MAXIMUM ?? (_MAXIMUM = new MAXIMUMValue());

		/// <summary>﻿maximum or peak value recorded for the data item during the calculation period.<br /><br /><br />
		/// Value for StatisticEnum.<br/>
		/// <br/>See also <seealso cref="StatisticEnum">StatisticEnum</seealso>
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
			public string Summary => @"&#10;&#10;&#10;maximum or peak value recorded for the data item during the calculation period.&#10;
";
		}
		private MEDIANValue _MEDIAN;
		/// <inheritdoc cref="MEDIANValue" path="/summary" />
		public MEDIANValue MEDIAN => _MEDIAN ?? (_MEDIAN = new MEDIANValue());

		/// <summary>﻿middle number of a series of numbers.<br /><br /><br />
		/// Value for StatisticEnum.<br/>
		/// <br/>See also <seealso cref="StatisticEnum">StatisticEnum</seealso>
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
			public string Summary => @"&#10;&#10;&#10;middle number of a series of numbers.&#10;
";
		}
		private MINIMUMValue _MINIMUM;
		/// <inheritdoc cref="MINIMUMValue" path="/summary" />
		public MINIMUMValue MINIMUM => _MINIMUM ?? (_MINIMUM = new MINIMUMValue());

		/// <summary>﻿minimum value recorded for the data item during the calculation period.<br /><br /><br />
		/// Value for StatisticEnum.<br/>
		/// <br/>See also <seealso cref="StatisticEnum">StatisticEnum</seealso>
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
			public string Summary => @"&#10;&#10;&#10;minimum value recorded for the data item during the calculation period.&#10;
";
		}
		private MODEValue _MODE;
		/// <inheritdoc cref="MODEValue" path="/summary" />
		public MODEValue MODE => _MODE ?? (_MODE = new MODEValue());

		/// <summary>﻿number in a series of numbers that occurs most often.<br /><br /><br />
		/// Value for StatisticEnum.<br/>
		/// <br/>See also <seealso cref="StatisticEnum">StatisticEnum</seealso>
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
			public string Summary => @"&#10;&#10;&#10;number in a series of numbers that occurs most often.&#10;
";
		}
		private RANGEValue _RANGE;
		/// <inheritdoc cref="RANGEValue" path="/summary" />
		public RANGEValue RANGE => _RANGE ?? (_RANGE = new RANGEValue());

		/// <summary>﻿difference between the maximum and minimum value of a data item during the calculation period. Also represents Peak-to-Peak measurement in a waveform.<br /><br /><br />
		/// Value for StatisticEnum.<br/>
		/// <br/>See also <seealso cref="StatisticEnum">StatisticEnum</seealso>
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
			public string Summary => @"&#10;&#10;&#10;difference between the maximum and minimum value of a data item during the calculation period. Also represents Peak-to-Peak measurement in a waveform.&#10;
";
		}
		private ROOT_MEAN_SQUAREValue _ROOT_MEAN_SQUARE;
		/// <inheritdoc cref="ROOT_MEAN_SQUAREValue" path="/summary" />
		public ROOT_MEAN_SQUAREValue ROOT_MEAN_SQUARE => _ROOT_MEAN_SQUARE ?? (_ROOT_MEAN_SQUARE = new ROOT_MEAN_SQUAREValue());

		/// <summary>﻿mathematical Root Mean Square (RMS) value calculated for the data item during the calculation period.<br /><br /><br />
		/// Value for StatisticEnum.<br/>
		/// <br/>See also <seealso cref="StatisticEnum">StatisticEnum</seealso>
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
			public string Summary => @"&#10;&#10;&#10;mathematical Root Mean Square (RMS) value calculated for the data item during the calculation period.&#10;
";
		}
		private STANDARD_DEVIATIONValue _STANDARD_DEVIATION;
		/// <inheritdoc cref="STANDARD_DEVIATIONValue" path="/summary" />
		public STANDARD_DEVIATIONValue STANDARD_DEVIATION => _STANDARD_DEVIATION ?? (_STANDARD_DEVIATION = new STANDARD_DEVIATIONValue());

		/// <summary>﻿statistical Standard Deviation value calculated for the data item during the calculation period.<br /><br /><br />
		/// Value for StatisticEnum.<br/>
		/// <br/>See also <seealso cref="StatisticEnum">StatisticEnum</seealso>
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
			public string Summary => @"&#10;&#10;&#10;statistical Standard Deviation value calculated for the data item during the calculation period.&#10;
";
		}
	}
}