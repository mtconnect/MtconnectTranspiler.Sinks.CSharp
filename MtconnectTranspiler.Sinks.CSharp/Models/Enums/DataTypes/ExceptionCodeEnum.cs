#pragma warning disable CS1574 // XML comment has cref attribute that could not be resolved
#pragma warning disable CS1584 // XML comment has syntactically incorrect cref attribute
#pragma warning disable CS0618 // Type or member is obsolete
using System;
using System.CodeDom.Compiler;using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;

namespace Mtconnect.DataTypes
{
	/// <summary>﻿
	/// <br/> Visit <seealso href="https://model.mtconnect.org/#Enumeration___2024x_68e0225_1744802385717_420523_23719">model.mtconnect.org</seealso> for more information.
	/// </summary>
	/// <remarks>
	/// <list type="bullet">
	/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_2.6">v2.6</see></item>
	/// </list>
	/// </remarks>

	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.6.0.0")]
	public enum ExceptionCodeEnum
	{
		/// <summary>﻿scope value type is mismatched.<br /><br />&gt; Note: For example, a <c>string</c> instead of an <c>Enumeration</c> value.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_2.6">v2.6</see></item>
		/// </list>
		/// </remarks>

		TYPE_MISMATCH,
		/// <summary>﻿scope is missing a property or a part.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_2.6">v2.6</see></item>
		/// </list>
		/// </remarks>

		NOT_FOUND,
		/// <summary>﻿scope has been deprecated.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_2.6">v2.6</see></item>
		/// </list>
		/// </remarks>

		DEPRECATED,
		/// <summary>﻿scope is considered an extension of the MTConnect Standard.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_2.6">v2.6</see></item>
		/// </list>
		/// </remarks>

		EXTENDED,
		/// <summary>﻿scope is not within the expected range.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_2.6">v2.6</see></item>
		/// </list>
		/// </remarks>

		OUT_OF_RANGE,
		/// <summary>﻿scope is a duplicate or has duplicate properties or parts.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_2.6">v2.6</see></item>
		/// </list>
		/// </remarks>

		DUPLICATE_ENTRY,
		/// <summary>﻿scope has either an invalid format or does not conform to the expected pattern.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_2.6">v2.6</see></item>
		/// </list>
		/// </remarks>

		INVALID_FORMAT,
	}

	/// <summary>﻿
	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Enumeration___2024x_68e0225_1744802385717_420523_23719">model.mtconnect.org</seealso> for more information.
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.6.0.0")]
	public sealed class ExceptionCodeEnumMetaClass : IEnum
	{
		/// <summary>Constant value for <see cref="ExceptionCodeEnumMetaClass.ReferenceId" /></summary>
		public const string REFERENCE_ID = "_2024x_68e0225_1744802385717_420523_23719";
		/// <summary>Constant value for <see cref="ExceptionCodeEnumMetaClass.HelpUrl" /></summary>
		public const string HELP_URL = "https://model.mtconnect.org/#Enumeration___2024x_68e0225_1744802385717_420523_23719";
		/// <summary>Constant value for <see cref="ExceptionCodeEnumMetaClass.Name" /></summary>
		public const string NAME = "ExceptionCodeEnum";
		/// <summary>Constant value for <see cref="ExceptionCodeEnumMetaClass.NormativeVersion" /></summary>
		public const string NORMATIVE_VERSION = "2.6";
		/// <summary>Constant value for <see cref="ExceptionCodeEnumMetaClass.DeprecatedVersion" /></summary>
		public const string DEPRECATED_VERSION = "";
		/// <summary>Constant value for <see cref="ExceptionCodeEnumMetaClass.Summary" /></summary>
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
		public Type Instance => typeof(ExceptionCodeEnum);

		/// <inheritdoc />
		public string NormativeVersion => NORMATIVE_VERSION;
		
		/// <inheritdoc />
		public string DeprecatedVersion => DEPRECATED_VERSION;
		
		/// <inheritdoc />
		public string Summary => SUMMARY;
		
		/// <inheritdoc />
		public IEnumInstance[] Values => new IEnumInstance[] {
		TYPE_MISMATCH,
		NOT_FOUND,
		DEPRECATED,
		EXTENDED,
		OUT_OF_RANGE,
		DUPLICATE_ENTRY,
		INVALID_FORMAT,
		};

		private TYPE_MISMATCHValue _TYPE_MISMATCH;
		/// <inheritdoc cref="TYPE_MISMATCHValue" path="/summary" />
		public TYPE_MISMATCHValue TYPE_MISMATCH => _TYPE_MISMATCH ?? (_TYPE_MISMATCH = new TYPE_MISMATCHValue());

		/// <summary>﻿scope value type is mismatched.<br /><br />&gt; Note: For example, a <c>string</c> instead of an <c>Enumeration</c> value.<br /><br /><br />
		/// Value for ExceptionCodeEnum.<br/>
		/// <br/>See also <seealso cref="ExceptionCodeEnum">ExceptionCodeEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_2.6">v2.6</see></item>
		/// </list>
		/// </remarks>

		public sealed class TYPE_MISMATCHValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="TYPE_MISMATCHValue.Name" /></summary>
			public const string NAME = "TYPE_MISMATCH";
			/// <summary>Constant value for <see cref="TYPE_MISMATCHValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "2.6";
			/// <summary>Constant value for <see cref="TYPE_MISMATCHValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="TYPE_MISMATCHValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;scope value type is mismatched.

> Note: For example, a `string` instead of an `Enumeration` value.&#10;
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
		private NOT_FOUNDValue _NOT_FOUND;
		/// <inheritdoc cref="NOT_FOUNDValue" path="/summary" />
		public NOT_FOUNDValue NOT_FOUND => _NOT_FOUND ?? (_NOT_FOUND = new NOT_FOUNDValue());

		/// <summary>﻿scope is missing a property or a part.<br /><br /><br />
		/// Value for ExceptionCodeEnum.<br/>
		/// <br/>See also <seealso cref="ExceptionCodeEnum">ExceptionCodeEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_2.6">v2.6</see></item>
		/// </list>
		/// </remarks>

		public sealed class NOT_FOUNDValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="NOT_FOUNDValue.Name" /></summary>
			public const string NAME = "NOT_FOUND";
			/// <summary>Constant value for <see cref="NOT_FOUNDValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "2.6";
			/// <summary>Constant value for <see cref="NOT_FOUNDValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="NOT_FOUNDValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;scope is missing a property or a part.&#10;
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
		private DEPRECATEDValue _DEPRECATED;
		/// <inheritdoc cref="DEPRECATEDValue" path="/summary" />
		public DEPRECATEDValue DEPRECATED => _DEPRECATED ?? (_DEPRECATED = new DEPRECATEDValue());

		/// <summary>﻿scope has been deprecated.<br /><br /><br />
		/// Value for ExceptionCodeEnum.<br/>
		/// <br/>See also <seealso cref="ExceptionCodeEnum">ExceptionCodeEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_2.6">v2.6</see></item>
		/// </list>
		/// </remarks>

		public sealed class DEPRECATEDValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="DEPRECATEDValue.Name" /></summary>
			public const string NAME = "DEPRECATED";
			/// <summary>Constant value for <see cref="DEPRECATEDValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "2.6";
			/// <summary>Constant value for <see cref="DEPRECATEDValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="DEPRECATEDValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;scope has been deprecated.&#10;
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
		private EXTENDEDValue _EXTENDED;
		/// <inheritdoc cref="EXTENDEDValue" path="/summary" />
		public EXTENDEDValue EXTENDED => _EXTENDED ?? (_EXTENDED = new EXTENDEDValue());

		/// <summary>﻿scope is considered an extension of the MTConnect Standard.<br /><br /><br />
		/// Value for ExceptionCodeEnum.<br/>
		/// <br/>See also <seealso cref="ExceptionCodeEnum">ExceptionCodeEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_2.6">v2.6</see></item>
		/// </list>
		/// </remarks>

		public sealed class EXTENDEDValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="EXTENDEDValue.Name" /></summary>
			public const string NAME = "EXTENDED";
			/// <summary>Constant value for <see cref="EXTENDEDValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "2.6";
			/// <summary>Constant value for <see cref="EXTENDEDValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="EXTENDEDValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;scope is considered an extension of the MTConnect Standard.&#10;
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
		private OUT_OF_RANGEValue _OUT_OF_RANGE;
		/// <inheritdoc cref="OUT_OF_RANGEValue" path="/summary" />
		public OUT_OF_RANGEValue OUT_OF_RANGE => _OUT_OF_RANGE ?? (_OUT_OF_RANGE = new OUT_OF_RANGEValue());

		/// <summary>﻿scope is not within the expected range.<br /><br /><br />
		/// Value for ExceptionCodeEnum.<br/>
		/// <br/>See also <seealso cref="ExceptionCodeEnum">ExceptionCodeEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_2.6">v2.6</see></item>
		/// </list>
		/// </remarks>

		public sealed class OUT_OF_RANGEValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="OUT_OF_RANGEValue.Name" /></summary>
			public const string NAME = "OUT_OF_RANGE";
			/// <summary>Constant value for <see cref="OUT_OF_RANGEValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "2.6";
			/// <summary>Constant value for <see cref="OUT_OF_RANGEValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="OUT_OF_RANGEValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;scope is not within the expected range.&#10;
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
		private DUPLICATE_ENTRYValue _DUPLICATE_ENTRY;
		/// <inheritdoc cref="DUPLICATE_ENTRYValue" path="/summary" />
		public DUPLICATE_ENTRYValue DUPLICATE_ENTRY => _DUPLICATE_ENTRY ?? (_DUPLICATE_ENTRY = new DUPLICATE_ENTRYValue());

		/// <summary>﻿scope is a duplicate or has duplicate properties or parts.<br /><br /><br />
		/// Value for ExceptionCodeEnum.<br/>
		/// <br/>See also <seealso cref="ExceptionCodeEnum">ExceptionCodeEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_2.6">v2.6</see></item>
		/// </list>
		/// </remarks>

		public sealed class DUPLICATE_ENTRYValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="DUPLICATE_ENTRYValue.Name" /></summary>
			public const string NAME = "DUPLICATE_ENTRY";
			/// <summary>Constant value for <see cref="DUPLICATE_ENTRYValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "2.6";
			/// <summary>Constant value for <see cref="DUPLICATE_ENTRYValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="DUPLICATE_ENTRYValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;scope is a duplicate or has duplicate properties or parts.&#10;
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
		private INVALID_FORMATValue _INVALID_FORMAT;
		/// <inheritdoc cref="INVALID_FORMATValue" path="/summary" />
		public INVALID_FORMATValue INVALID_FORMAT => _INVALID_FORMAT ?? (_INVALID_FORMAT = new INVALID_FORMATValue());

		/// <summary>﻿scope has either an invalid format or does not conform to the expected pattern.<br /><br /><br />
		/// Value for ExceptionCodeEnum.<br/>
		/// <br/>See also <seealso cref="ExceptionCodeEnum">ExceptionCodeEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_2.6">v2.6</see></item>
		/// </list>
		/// </remarks>

		public sealed class INVALID_FORMATValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="INVALID_FORMATValue.Name" /></summary>
			public const string NAME = "INVALID_FORMAT";
			/// <summary>Constant value for <see cref="INVALID_FORMATValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "2.6";
			/// <summary>Constant value for <see cref="INVALID_FORMATValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="INVALID_FORMATValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;scope has either an invalid format or does not conform to the expected pattern.&#10;
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