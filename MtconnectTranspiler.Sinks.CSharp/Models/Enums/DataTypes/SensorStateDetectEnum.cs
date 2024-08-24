#pragma warning disable CS1574 // XML comment has cref attribute that could not be resolved
#pragma warning disable CS1584 // XML comment has syntactically incorrect cref attribute
#pragma warning disable CS0618 // Type or member is obsolete
using System;
using System.CodeDom.Compiler;using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;

namespace Mtconnect.DataTypes
{
	/// <summary>﻿
	/// <br/> Visit <seealso href="https://model.mtconnect.org/#Enumeration___19_0_3_68e0225_1677589978293_52377_922">model.mtconnect.org</seealso> for more information.
	/// </summary>
	/// <remarks>
	/// <list type="bullet">
	/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_2.2">v2.2</see></item>
	/// </list>
	/// </remarks>

	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public enum SensorStateDetectEnum
	{
		/// <summary>﻿sensor is active and the threshold has been met.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_2.2">v2.2</see></item>
		/// </list>
		/// </remarks>

		DETECTED,
		/// <summary>﻿sensor is active and ready but the threshold has not been met.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_2.2">v2.2</see></item>
		/// </list>
		/// </remarks>

		NOT_DETECTED,
		/// <summary>﻿sensor is active, but the state cannot be determined.<br /><br />&gt; Note: unknown covers situations where the sensor reading is unstable.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_2.2">v2.2</see></item>
		/// </list>
		/// </remarks>

		UNKNOWN,
	}

	/// <summary>﻿
	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Enumeration___19_0_3_68e0225_1677589978293_52377_922">model.mtconnect.org</seealso> for more information.
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public sealed class SensorStateDetectEnumMetaClass : IEnum
	{
		/// <summary>Constant value for <see cref="SensorStateDetectEnumMetaClass.ReferenceId" /></summary>
		public const string REFERENCE_ID = "_19_0_3_68e0225_1677589978293_52377_922";
		/// <summary>Constant value for <see cref="SensorStateDetectEnumMetaClass.HelpUrl" /></summary>
		public const string HELP_URL = "https://model.mtconnect.org/#Enumeration___19_0_3_68e0225_1677589978293_52377_922";
		/// <summary>Constant value for <see cref="SensorStateDetectEnumMetaClass.Name" /></summary>
		public const string NAME = "SensorStateDetectEnum";
		/// <summary>Constant value for <see cref="SensorStateDetectEnumMetaClass.NormativeVersion" /></summary>
		public const string NORMATIVE_VERSION = "2.2";
		/// <summary>Constant value for <see cref="SensorStateDetectEnumMetaClass.DeprecatedVersion" /></summary>
		public const string DEPRECATED_VERSION = "";
		/// <summary>Constant value for <see cref="SensorStateDetectEnumMetaClass.Summary" /></summary>
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
		public Type Instance => typeof(SensorStateDetectEnum);

		/// <inheritdoc />
		public string NormativeVersion => NORMATIVE_VERSION;
		
		/// <inheritdoc />
		public string DeprecatedVersion => DEPRECATED_VERSION;
		
		/// <inheritdoc />
		public string Summary => SUMMARY;
		
		/// <inheritdoc />
		public IEnumInstance[] Values => new IEnumInstance[] {
		DETECTED,
		NOT_DETECTED,
		UNKNOWN,
		};

		private DETECTEDValue _DETECTED;
		/// <inheritdoc cref="DETECTEDValue" path="/summary" />
		public DETECTEDValue DETECTED => _DETECTED ?? (_DETECTED = new DETECTEDValue());

		/// <summary>﻿sensor is active and the threshold has been met.<br /><br /><br />
		/// Value for SensorStateDetectEnum.<br/>
		/// <br/>See also <seealso cref="SensorStateDetectEnum">SensorStateDetectEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_2.2">v2.2</see></item>
		/// </list>
		/// </remarks>

		public sealed class DETECTEDValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="DETECTEDValue.Name" /></summary>
			public const string NAME = "DETECTED";
			/// <summary>Constant value for <see cref="DETECTEDValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "2.2";
			/// <summary>Constant value for <see cref="DETECTEDValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="DETECTEDValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;sensor is active and the threshold has been met.&#10;
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
		private NOT_DETECTEDValue _NOT_DETECTED;
		/// <inheritdoc cref="NOT_DETECTEDValue" path="/summary" />
		public NOT_DETECTEDValue NOT_DETECTED => _NOT_DETECTED ?? (_NOT_DETECTED = new NOT_DETECTEDValue());

		/// <summary>﻿sensor is active and ready but the threshold has not been met.<br /><br /><br />
		/// Value for SensorStateDetectEnum.<br/>
		/// <br/>See also <seealso cref="SensorStateDetectEnum">SensorStateDetectEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_2.2">v2.2</see></item>
		/// </list>
		/// </remarks>

		public sealed class NOT_DETECTEDValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="NOT_DETECTEDValue.Name" /></summary>
			public const string NAME = "NOT_DETECTED";
			/// <summary>Constant value for <see cref="NOT_DETECTEDValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "2.2";
			/// <summary>Constant value for <see cref="NOT_DETECTEDValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="NOT_DETECTEDValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;sensor is active and ready but the threshold has not been met.&#10;
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
		private UNKNOWNValue _UNKNOWN;
		/// <inheritdoc cref="UNKNOWNValue" path="/summary" />
		public UNKNOWNValue UNKNOWN => _UNKNOWN ?? (_UNKNOWN = new UNKNOWNValue());

		/// <summary>﻿sensor is active, but the state cannot be determined.<br /><br />&gt; Note: unknown covers situations where the sensor reading is unstable.<br /><br /><br />
		/// Value for SensorStateDetectEnum.<br/>
		/// <br/>See also <seealso cref="SensorStateDetectEnum">SensorStateDetectEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_2.2">v2.2</see></item>
		/// </list>
		/// </remarks>

		public sealed class UNKNOWNValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="UNKNOWNValue.Name" /></summary>
			public const string NAME = "UNKNOWN";
			/// <summary>Constant value for <see cref="UNKNOWNValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "2.2";
			/// <summary>Constant value for <see cref="UNKNOWNValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="UNKNOWNValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;sensor is active, but the state cannot be determined.

> Note: unknown covers situations where the sensor reading is unstable.&#10;
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