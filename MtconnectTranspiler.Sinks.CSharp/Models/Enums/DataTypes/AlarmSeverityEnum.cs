#pragma warning disable CS1574 // XML comment has cref attribute that could not be resolved
#pragma warning disable CS1584 // XML comment has syntactically incorrect cref attribute
#pragma warning disable CS0618 // Type or member is obsolete
using System;
using System.CodeDom.Compiler;using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;

namespace Mtconnect.DataTypes
{
	/// <summary>﻿
	/// <br/> Visit <seealso href="https://model.mtconnect.org/#Enumeration___19_0_3_68e0225_1643968830721_843713_164">model.mtconnect.org</seealso> for more information.
	/// </summary>
	/// <remarks>
	/// <list type="bullet">
	/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
	/// <item><b>Deprecated</b>: <see href="https://model.mtconnect.org/#_Version_1.1">v1.1</see></item>
	/// </list>
	/// </remarks>
	[Obsolete("Deprecated in v1.1 according to https://model.mtconnect.org/#_Version_1.1")]

	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public enum AlarmSeverityEnum
	{
		/// <summary>﻿
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// <item><b>Deprecated</b>: <see href="https://model.mtconnect.org/#_Version_1.1">v1.1</see></item>
		/// </list>
		/// </remarks>
		[Obsolete("Deprecated in v1.1 according to https://model.mtconnect.org/#_Version_1.1")]

		CRITICAL,
		/// <summary>﻿
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// <item><b>Deprecated</b>: <see href="https://model.mtconnect.org/#_Version_1.1">v1.1</see></item>
		/// </list>
		/// </remarks>
		[Obsolete("Deprecated in v1.1 according to https://model.mtconnect.org/#_Version_1.1")]

		ERROR,
		/// <summary>﻿
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// <item><b>Deprecated</b>: <see href="https://model.mtconnect.org/#_Version_1.1">v1.1</see></item>
		/// </list>
		/// </remarks>
		[Obsolete("Deprecated in v1.1 according to https://model.mtconnect.org/#_Version_1.1")]

		WARNING,
		/// <summary>﻿
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// <item><b>Deprecated</b>: <see href="https://model.mtconnect.org/#_Version_1.1">v1.1</see></item>
		/// </list>
		/// </remarks>
		[Obsolete("Deprecated in v1.1 according to https://model.mtconnect.org/#_Version_1.1")]

		INFORMATION,
	}

	/// <summary>﻿
	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Enumeration___19_0_3_68e0225_1643968830721_843713_164">model.mtconnect.org</seealso> for more information.
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public sealed class AlarmSeverityEnumMetaClass : IEnum
	{
		/// <summary>Constant value for <see cref="AlarmSeverityEnumMetaClass.ReferenceId" /></summary>
		public const string REFERENCE_ID = "_19_0_3_68e0225_1643968830721_843713_164";
		/// <summary>Constant value for <see cref="AlarmSeverityEnumMetaClass.HelpUrl" /></summary>
		public const string HELP_URL = "https://model.mtconnect.org/#Enumeration___19_0_3_68e0225_1643968830721_843713_164";
		/// <summary>Constant value for <see cref="AlarmSeverityEnumMetaClass.Name" /></summary>
		public const string NAME = "AlarmSeverityEnum";
		/// <summary>Constant value for <see cref="AlarmSeverityEnumMetaClass.NormativeVersion" /></summary>
		public const string NORMATIVE_VERSION = "1.0";
		/// <summary>Constant value for <see cref="AlarmSeverityEnumMetaClass.DeprecatedVersion" /></summary>
		public const string DEPRECATED_VERSION = "1.1";
		/// <summary>Constant value for <see cref="AlarmSeverityEnumMetaClass.Summary" /></summary>
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
		public Type Instance => typeof(AlarmSeverityEnum);

		/// <inheritdoc />
		public string NormativeVersion => NORMATIVE_VERSION;
		
		/// <inheritdoc />
		public string DeprecatedVersion => DEPRECATED_VERSION;
		
		/// <inheritdoc />
		public string Summary => SUMMARY;
		
		/// <inheritdoc />
		public IEnumInstance[] Values => new IEnumInstance[] {
		CRITICAL,
		ERROR,
		WARNING,
		INFORMATION,
		};

		private CRITICALValue _CRITICAL;
		/// <inheritdoc cref="CRITICALValue" path="/summary" />
		public CRITICALValue CRITICAL => _CRITICAL ?? (_CRITICAL = new CRITICALValue());

		/// <summary>﻿
		/// Value for AlarmSeverityEnum.<br/>
		/// <br/>See also <seealso cref="AlarmSeverityEnum">AlarmSeverityEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// <item><b>Deprecated</b>: <see href="https://model.mtconnect.org/#_Version_1.1">v1.1</see></item>
		/// </list>
		/// </remarks>
		[Obsolete("Deprecated in v1.1 according to https://model.mtconnect.org/#_Version_1.1")]

		public sealed class CRITICALValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="CRITICALValue.Name" /></summary>
			public const string NAME = "CRITICAL";
			/// <summary>Constant value for <see cref="CRITICALValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.0";
			/// <summary>Constant value for <see cref="CRITICALValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "1.1";
			/// <summary>Constant value for <see cref="CRITICALValue.Summary" /></summary>
			public const string SUMMARY = @"";

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
		private ERRORValue _ERROR;
		/// <inheritdoc cref="ERRORValue" path="/summary" />
		public ERRORValue ERROR => _ERROR ?? (_ERROR = new ERRORValue());

		/// <summary>﻿
		/// Value for AlarmSeverityEnum.<br/>
		/// <br/>See also <seealso cref="AlarmSeverityEnum">AlarmSeverityEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// <item><b>Deprecated</b>: <see href="https://model.mtconnect.org/#_Version_1.1">v1.1</see></item>
		/// </list>
		/// </remarks>
		[Obsolete("Deprecated in v1.1 according to https://model.mtconnect.org/#_Version_1.1")]

		public sealed class ERRORValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="ERRORValue.Name" /></summary>
			public const string NAME = "ERROR";
			/// <summary>Constant value for <see cref="ERRORValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.0";
			/// <summary>Constant value for <see cref="ERRORValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "1.1";
			/// <summary>Constant value for <see cref="ERRORValue.Summary" /></summary>
			public const string SUMMARY = @"";

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
		private WARNINGValue _WARNING;
		/// <inheritdoc cref="WARNINGValue" path="/summary" />
		public WARNINGValue WARNING => _WARNING ?? (_WARNING = new WARNINGValue());

		/// <summary>﻿
		/// Value for AlarmSeverityEnum.<br/>
		/// <br/>See also <seealso cref="AlarmSeverityEnum">AlarmSeverityEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// <item><b>Deprecated</b>: <see href="https://model.mtconnect.org/#_Version_1.1">v1.1</see></item>
		/// </list>
		/// </remarks>
		[Obsolete("Deprecated in v1.1 according to https://model.mtconnect.org/#_Version_1.1")]

		public sealed class WARNINGValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="WARNINGValue.Name" /></summary>
			public const string NAME = "WARNING";
			/// <summary>Constant value for <see cref="WARNINGValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.0";
			/// <summary>Constant value for <see cref="WARNINGValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "1.1";
			/// <summary>Constant value for <see cref="WARNINGValue.Summary" /></summary>
			public const string SUMMARY = @"";

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
		private INFORMATIONValue _INFORMATION;
		/// <inheritdoc cref="INFORMATIONValue" path="/summary" />
		public INFORMATIONValue INFORMATION => _INFORMATION ?? (_INFORMATION = new INFORMATIONValue());

		/// <summary>﻿
		/// Value for AlarmSeverityEnum.<br/>
		/// <br/>See also <seealso cref="AlarmSeverityEnum">AlarmSeverityEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// <item><b>Deprecated</b>: <see href="https://model.mtconnect.org/#_Version_1.1">v1.1</see></item>
		/// </list>
		/// </remarks>
		[Obsolete("Deprecated in v1.1 according to https://model.mtconnect.org/#_Version_1.1")]

		public sealed class INFORMATIONValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="INFORMATIONValue.Name" /></summary>
			public const string NAME = "INFORMATION";
			/// <summary>Constant value for <see cref="INFORMATIONValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.0";
			/// <summary>Constant value for <see cref="INFORMATIONValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "1.1";
			/// <summary>Constant value for <see cref="INFORMATIONValue.Summary" /></summary>
			public const string SUMMARY = @"";

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