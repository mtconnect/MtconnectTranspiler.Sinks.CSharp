#pragma warning disable CS1574 // XML comment has cref attribute that could not be resolved
#pragma warning disable CS1584 // XML comment has syntactically incorrect cref attribute
#pragma warning disable CS0618 // Type or member is obsolete
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
		/// </list>
		/// </remarks>

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
		/// <summary>Constant value for <see cref="StatisticEnumMetaClass.ReferenceId" /></summary>
		public const string REFERENCE_ID = "EAID_51F1600E_2F14_4045_86C0_42B336850079";
		/// <summary>Constant value for <see cref="StatisticEnumMetaClass.HelpUrl" /></summary>
		public const string HELP_URL = "https://model.mtconnect.org/#Enumeration__EAID_51F1600E_2F14_4045_86C0_42B336850079";
		/// <summary>Constant value for <see cref="StatisticEnumMetaClass.Name" /></summary>
		public const string NAME = "StatisticEnum";
		/// <summary>Constant value for <see cref="StatisticEnumMetaClass.NormativeVersion" /></summary>
		public const string NORMATIVE_VERSION = "1.2";
		/// <summary>Constant value for <see cref="StatisticEnumMetaClass.DeprecatedVersion" /></summary>
		public const string DEPRECATED_VERSION = "";
		/// <summary>Constant value for <see cref="StatisticEnumMetaClass.Summary" /></summary>
		public const string SUMMARY = @"";

		/// <inheritdoc />
		public string ReferenceId => REFERENCE_ID;
		
		/// <inheritdoc />
		public string HelpUrl => HELP_URL;

		/// <inheritdoc />
		public string Name => NAME;
		
		/// <inheritdoc />
		public Type DataType => null;
		
		/// <inheritdoc />
		public Type Instance => typeof(StatisticEnum);

		/// <inheritdoc />
		public string NormativeVersion => NORMATIVE_VERSION;
		
		/// <inheritdoc />
		public string DeprecatedVersion => DEPRECATED_VERSION;
		
		/// <inheritdoc />
		public string Summary => SUMMARY;
		
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
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.2">v1.2</see></item>
		/// </list>
		/// </remarks>

		public sealed class AVERAGEValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="AVERAGEValue.Name" /></summary>
			public const string NAME = "AVERAGE";
			/// <summary>Constant value for <see cref="AVERAGEValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.2";
			/// <summary>Constant value for <see cref="AVERAGEValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="AVERAGEValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;mathematical average value calculated for the data item during the calculation period.&#10;
";

			/// <inheritdoc />
			public string Name => NAME;
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => NORMATIVE_VERSION;
			
			/// <inheritdoc />
			public string DeprecatedVersion => DEPRECATED_VERSION;
			
			/// <inheritdoc />
			public string Summary => SUMMARY;
		}
		private KURTOSISValue _KURTOSIS;
		/// <inheritdoc cref="KURTOSISValue" path="/summary" />
		public KURTOSISValue KURTOSIS => _KURTOSIS ?? (_KURTOSIS = new KURTOSISValue());

		/// <summary>﻿<b>DEPRECATED</b> in <i>Version 1.6</i>. ~~A measure of the "peakedness" of a probability distribution; i.e., the shape of the distribution curve.~~<br /><br /><br />
		/// Value for StatisticEnum.<br/>
		/// <br/>See also <seealso cref="StatisticEnum">StatisticEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.2">v1.2</see></item>
		/// </list>
		/// </remarks>

		public sealed class KURTOSISValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="KURTOSISValue.Name" /></summary>
			public const string NAME = "KURTOSIS";
			/// <summary>Constant value for <see cref="KURTOSISValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.2";
			/// <summary>Constant value for <see cref="KURTOSISValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "1.6";
			/// <summary>Constant value for <see cref="KURTOSISValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;**DEPRECATED** in *Version 1.6*. ~~A measure of the ""peakedness"" of a probability distribution; i.e., the shape of the distribution curve.~~&#10;
";

			/// <inheritdoc />
			public string Name => NAME;
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => NORMATIVE_VERSION;
			
			/// <inheritdoc />
			public string DeprecatedVersion => DEPRECATED_VERSION;
			
			/// <inheritdoc />
			public string Summary => SUMMARY;
		}
		private MAXIMUMValue _MAXIMUM;
		/// <inheritdoc cref="MAXIMUMValue" path="/summary" />
		public MAXIMUMValue MAXIMUM => _MAXIMUM ?? (_MAXIMUM = new MAXIMUMValue());

		/// <summary>﻿maximum or peak value recorded for the data item during the calculation period.<br /><br /><br />
		/// Value for StatisticEnum.<br/>
		/// <br/>See also <seealso cref="StatisticEnum">StatisticEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.2">v1.2</see></item>
		/// </list>
		/// </remarks>

		public sealed class MAXIMUMValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="MAXIMUMValue.Name" /></summary>
			public const string NAME = "MAXIMUM";
			/// <summary>Constant value for <see cref="MAXIMUMValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.2";
			/// <summary>Constant value for <see cref="MAXIMUMValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="MAXIMUMValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;maximum or peak value recorded for the data item during the calculation period.&#10;
";

			/// <inheritdoc />
			public string Name => NAME;
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => NORMATIVE_VERSION;
			
			/// <inheritdoc />
			public string DeprecatedVersion => DEPRECATED_VERSION;
			
			/// <inheritdoc />
			public string Summary => SUMMARY;
		}
		private MEDIANValue _MEDIAN;
		/// <inheritdoc cref="MEDIANValue" path="/summary" />
		public MEDIANValue MEDIAN => _MEDIAN ?? (_MEDIAN = new MEDIANValue());

		/// <summary>﻿middle number of a series of numbers.<br /><br /><br />
		/// Value for StatisticEnum.<br/>
		/// <br/>See also <seealso cref="StatisticEnum">StatisticEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.2">v1.2</see></item>
		/// </list>
		/// </remarks>

		public sealed class MEDIANValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="MEDIANValue.Name" /></summary>
			public const string NAME = "MEDIAN";
			/// <summary>Constant value for <see cref="MEDIANValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.2";
			/// <summary>Constant value for <see cref="MEDIANValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="MEDIANValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;middle number of a series of numbers.&#10;
";

			/// <inheritdoc />
			public string Name => NAME;
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => NORMATIVE_VERSION;
			
			/// <inheritdoc />
			public string DeprecatedVersion => DEPRECATED_VERSION;
			
			/// <inheritdoc />
			public string Summary => SUMMARY;
		}
		private MINIMUMValue _MINIMUM;
		/// <inheritdoc cref="MINIMUMValue" path="/summary" />
		public MINIMUMValue MINIMUM => _MINIMUM ?? (_MINIMUM = new MINIMUMValue());

		/// <summary>﻿minimum value recorded for the data item during the calculation period.<br /><br /><br />
		/// Value for StatisticEnum.<br/>
		/// <br/>See also <seealso cref="StatisticEnum">StatisticEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.2">v1.2</see></item>
		/// </list>
		/// </remarks>

		public sealed class MINIMUMValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="MINIMUMValue.Name" /></summary>
			public const string NAME = "MINIMUM";
			/// <summary>Constant value for <see cref="MINIMUMValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.2";
			/// <summary>Constant value for <see cref="MINIMUMValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="MINIMUMValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;minimum value recorded for the data item during the calculation period.&#10;
";

			/// <inheritdoc />
			public string Name => NAME;
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => NORMATIVE_VERSION;
			
			/// <inheritdoc />
			public string DeprecatedVersion => DEPRECATED_VERSION;
			
			/// <inheritdoc />
			public string Summary => SUMMARY;
		}
		private MODEValue _MODE;
		/// <inheritdoc cref="MODEValue" path="/summary" />
		public MODEValue MODE => _MODE ?? (_MODE = new MODEValue());

		/// <summary>﻿number in a series of numbers that occurs most often.<br /><br /><br />
		/// Value for StatisticEnum.<br/>
		/// <br/>See also <seealso cref="StatisticEnum">StatisticEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.2">v1.2</see></item>
		/// </list>
		/// </remarks>

		public sealed class MODEValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="MODEValue.Name" /></summary>
			public const string NAME = "MODE";
			/// <summary>Constant value for <see cref="MODEValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.2";
			/// <summary>Constant value for <see cref="MODEValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="MODEValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;number in a series of numbers that occurs most often.&#10;
";

			/// <inheritdoc />
			public string Name => NAME;
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => NORMATIVE_VERSION;
			
			/// <inheritdoc />
			public string DeprecatedVersion => DEPRECATED_VERSION;
			
			/// <inheritdoc />
			public string Summary => SUMMARY;
		}
		private RANGEValue _RANGE;
		/// <inheritdoc cref="RANGEValue" path="/summary" />
		public RANGEValue RANGE => _RANGE ?? (_RANGE = new RANGEValue());

		/// <summary>﻿difference between the maximum and minimum value of a data item during the calculation period. Also represents Peak-to-Peak measurement in a waveform.<br /><br /><br />
		/// Value for StatisticEnum.<br/>
		/// <br/>See also <seealso cref="StatisticEnum">StatisticEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.2">v1.2</see></item>
		/// </list>
		/// </remarks>

		public sealed class RANGEValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="RANGEValue.Name" /></summary>
			public const string NAME = "RANGE";
			/// <summary>Constant value for <see cref="RANGEValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.2";
			/// <summary>Constant value for <see cref="RANGEValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="RANGEValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;difference between the maximum and minimum value of a data item during the calculation period. Also represents Peak-to-Peak measurement in a waveform.&#10;
";

			/// <inheritdoc />
			public string Name => NAME;
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => NORMATIVE_VERSION;
			
			/// <inheritdoc />
			public string DeprecatedVersion => DEPRECATED_VERSION;
			
			/// <inheritdoc />
			public string Summary => SUMMARY;
		}
		private ROOT_MEAN_SQUAREValue _ROOT_MEAN_SQUARE;
		/// <inheritdoc cref="ROOT_MEAN_SQUAREValue" path="/summary" />
		public ROOT_MEAN_SQUAREValue ROOT_MEAN_SQUARE => _ROOT_MEAN_SQUARE ?? (_ROOT_MEAN_SQUARE = new ROOT_MEAN_SQUAREValue());

		/// <summary>﻿mathematical Root Mean Square (RMS) value calculated for the data item during the calculation period.<br /><br /><br />
		/// Value for StatisticEnum.<br/>
		/// <br/>See also <seealso cref="StatisticEnum">StatisticEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.2">v1.2</see></item>
		/// </list>
		/// </remarks>

		public sealed class ROOT_MEAN_SQUAREValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="ROOT_MEAN_SQUAREValue.Name" /></summary>
			public const string NAME = "ROOT_MEAN_SQUARE";
			/// <summary>Constant value for <see cref="ROOT_MEAN_SQUAREValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.2";
			/// <summary>Constant value for <see cref="ROOT_MEAN_SQUAREValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="ROOT_MEAN_SQUAREValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;mathematical Root Mean Square (RMS) value calculated for the data item during the calculation period.&#10;
";

			/// <inheritdoc />
			public string Name => NAME;
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => NORMATIVE_VERSION;
			
			/// <inheritdoc />
			public string DeprecatedVersion => DEPRECATED_VERSION;
			
			/// <inheritdoc />
			public string Summary => SUMMARY;
		}
		private STANDARD_DEVIATIONValue _STANDARD_DEVIATION;
		/// <inheritdoc cref="STANDARD_DEVIATIONValue" path="/summary" />
		public STANDARD_DEVIATIONValue STANDARD_DEVIATION => _STANDARD_DEVIATION ?? (_STANDARD_DEVIATION = new STANDARD_DEVIATIONValue());

		/// <summary>﻿statistical Standard Deviation value calculated for the data item during the calculation period.<br /><br /><br />
		/// Value for StatisticEnum.<br/>
		/// <br/>See also <seealso cref="StatisticEnum">StatisticEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.2">v1.2</see></item>
		/// </list>
		/// </remarks>

		public sealed class STANDARD_DEVIATIONValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="STANDARD_DEVIATIONValue.Name" /></summary>
			public const string NAME = "STANDARD_DEVIATION";
			/// <summary>Constant value for <see cref="STANDARD_DEVIATIONValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.2";
			/// <summary>Constant value for <see cref="STANDARD_DEVIATIONValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="STANDARD_DEVIATIONValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;statistical Standard Deviation value calculated for the data item during the calculation period.&#10;
";

			/// <inheritdoc />
			public string Name => NAME;
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => NORMATIVE_VERSION;
			
			/// <inheritdoc />
			public string DeprecatedVersion => DEPRECATED_VERSION;
			
			/// <inheritdoc />
			public string Summary => SUMMARY;
		}
	}
}