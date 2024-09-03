#pragma warning disable CS1574 // XML comment has cref attribute that could not be resolved
#pragma warning disable CS1584 // XML comment has syntactically incorrect cref attribute
#pragma warning disable CS0618 // Type or member is obsolete
using System;
using System.CodeDom.Compiler;using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;

namespace Mtconnect.DataTypes
{
	/// <summary>﻿
	/// <br/> Visit <seealso href="https://model.mtconnect.org/#Enumeration___19_0_3_91b028d_1579560813203_683279_6795">model.mtconnect.org</seealso> for more information.
	/// </summary>
	/// <remarks>
	/// <list type="bullet">
	/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
	/// </list>
	/// </remarks>

	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public enum ErrorCodeEnum
	{
		/// <summary>﻿<i>request</i> for information specifies an <see cref="Asset">Asset</see> that is not recognized by the <i>agent</i>.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		ASSET_NOT_FOUND,
		/// <summary>﻿<i>agent</i> experienced an error while attempting to published the requested information.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		INTERNAL_ERROR,
		/// <summary>﻿<i>request</i> contains information that was not recognized by the <i>agent</i>.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		INVALID_REQUEST,
		/// <summary>﻿<i>URI</i> provided was incorrect.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		INVALID_URI,
		/// <summary>﻿<i>XPath</i> identified in the <i>request</i> for information could not be parsed correctly by the <i>agent</i>.<br /><br />This could be caused by an invalid syntax or the <i>XPath</i> did not match a valid identify for any information stored in the <i>agent</i>. <br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		INVALID_XPATH,
		/// <summary>﻿identity of the <see cref="Device">Device</see> specified in the <i>request</i> for information is not associated with the <i>agent</i>.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		NO_DEVICE,
		/// <summary>﻿<i>request</i> for information specifies <i>streaming data</i> that includes sequence number(s) for pieces of data that are beyond the end of the <i>buffer</i>.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		OUT_OF_RANGE,
		/// <summary>﻿<i>agent</i> was unable to interpret the query.<br /><br />The query parameters do not contain valid values or include an invalid parameter.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		QUERY_ERROR,
		/// <summary>﻿<c>count</c> parameter provided in the <i>request</i> for information requires either of the following:<br /><br />* <i>streaming data</i> that includes more pieces of data than the <i>agent</i> is capable of organizing in an <i>MTConnectStreams Response Document</i>. <br /><br />* <see cref="Assets">Assets</see> that include more <see cref="Asset">Asset</see> in an <i>MTConnectAssets Response Document</i> than the <i>agent</i> is capable of handling. <br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		TOO_MANY,
		/// <summary>﻿<i>requester</i> does not have sufficient permissions to access the requested information.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		UNAUTHORIZED,
		/// <summary>﻿valid <i>request</i> was provided, but the <i>agent</i> does not support the feature or type of <i>request</i>.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		UNSUPPORTED,
	}

	/// <summary>﻿
	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Enumeration___19_0_3_91b028d_1579560813203_683279_6795">model.mtconnect.org</seealso> for more information.
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public sealed class ErrorCodeEnumMetaClass : IEnum
	{
		/// <summary>Constant value for <see cref="ErrorCodeEnumMetaClass.ReferenceId" /></summary>
		public const string REFERENCE_ID = "_19_0_3_91b028d_1579560813203_683279_6795";
		/// <summary>Constant value for <see cref="ErrorCodeEnumMetaClass.HelpUrl" /></summary>
		public const string HELP_URL = "https://model.mtconnect.org/#Enumeration___19_0_3_91b028d_1579560813203_683279_6795";
		/// <summary>Constant value for <see cref="ErrorCodeEnumMetaClass.Name" /></summary>
		public const string NAME = "ErrorCodeEnum";
		/// <summary>Constant value for <see cref="ErrorCodeEnumMetaClass.NormativeVersion" /></summary>
		public const string NORMATIVE_VERSION = "1.0";
		/// <summary>Constant value for <see cref="ErrorCodeEnumMetaClass.DeprecatedVersion" /></summary>
		public const string DEPRECATED_VERSION = "";
		/// <summary>Constant value for <see cref="ErrorCodeEnumMetaClass.Summary" /></summary>
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
		public Type Instance => typeof(ErrorCodeEnum);

		/// <inheritdoc />
		public string NormativeVersion => NORMATIVE_VERSION;
		
		/// <inheritdoc />
		public string DeprecatedVersion => DEPRECATED_VERSION;
		
		/// <inheritdoc />
		public string Summary => SUMMARY;
		
		/// <inheritdoc />
		public IEnumInstance[] Values => new IEnumInstance[] {
		ASSET_NOT_FOUND,
		INTERNAL_ERROR,
		INVALID_REQUEST,
		INVALID_URI,
		INVALID_XPATH,
		NO_DEVICE,
		OUT_OF_RANGE,
		QUERY_ERROR,
		TOO_MANY,
		UNAUTHORIZED,
		UNSUPPORTED,
		};

		private ASSET_NOT_FOUNDValue _ASSET_NOT_FOUND;
		/// <inheritdoc cref="ASSET_NOT_FOUNDValue" path="/summary" />
		public ASSET_NOT_FOUNDValue ASSET_NOT_FOUND => _ASSET_NOT_FOUND ?? (_ASSET_NOT_FOUND = new ASSET_NOT_FOUNDValue());

		/// <summary>﻿<i>request</i> for information specifies an <see cref="Asset">Asset</see> that is not recognized by the <i>agent</i>.<br /><br /><br />
		/// Value for ErrorCodeEnum.<br/>
		/// <br/>See also <seealso cref="ErrorCodeEnum">ErrorCodeEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		public sealed class ASSET_NOT_FOUNDValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="ASSET_NOT_FOUNDValue.Name" /></summary>
			public const string NAME = "ASSET_NOT_FOUND";
			/// <summary>Constant value for <see cref="ASSET_NOT_FOUNDValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.2";
			/// <summary>Constant value for <see cref="ASSET_NOT_FOUNDValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="ASSET_NOT_FOUNDValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;{{term(request)}} for information specifies an {{block(Asset)}} that is not recognized by the {{term(agent)}}.&#10;
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
		private INTERNAL_ERRORValue _INTERNAL_ERROR;
		/// <inheritdoc cref="INTERNAL_ERRORValue" path="/summary" />
		public INTERNAL_ERRORValue INTERNAL_ERROR => _INTERNAL_ERROR ?? (_INTERNAL_ERROR = new INTERNAL_ERRORValue());

		/// <summary>﻿<i>agent</i> experienced an error while attempting to published the requested information.<br /><br /><br />
		/// Value for ErrorCodeEnum.<br/>
		/// <br/>See also <seealso cref="ErrorCodeEnum">ErrorCodeEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		public sealed class INTERNAL_ERRORValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="INTERNAL_ERRORValue.Name" /></summary>
			public const string NAME = "INTERNAL_ERROR";
			/// <summary>Constant value for <see cref="INTERNAL_ERRORValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.0";
			/// <summary>Constant value for <see cref="INTERNAL_ERRORValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="INTERNAL_ERRORValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;{{term(agent)}} experienced an error while attempting to published the requested information.&#10;
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
		private INVALID_REQUESTValue _INVALID_REQUEST;
		/// <inheritdoc cref="INVALID_REQUESTValue" path="/summary" />
		public INVALID_REQUESTValue INVALID_REQUEST => _INVALID_REQUEST ?? (_INVALID_REQUEST = new INVALID_REQUESTValue());

		/// <summary>﻿<i>request</i> contains information that was not recognized by the <i>agent</i>.<br /><br /><br />
		/// Value for ErrorCodeEnum.<br/>
		/// <br/>See also <seealso cref="ErrorCodeEnum">ErrorCodeEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		public sealed class INVALID_REQUESTValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="INVALID_REQUESTValue.Name" /></summary>
			public const string NAME = "INVALID_REQUEST";
			/// <summary>Constant value for <see cref="INVALID_REQUESTValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.0";
			/// <summary>Constant value for <see cref="INVALID_REQUESTValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="INVALID_REQUESTValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;{{term(request)}} contains information that was not recognized by the {{term(agent)}}.&#10;
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
		private INVALID_URIValue _INVALID_URI;
		/// <inheritdoc cref="INVALID_URIValue" path="/summary" />
		public INVALID_URIValue INVALID_URI => _INVALID_URI ?? (_INVALID_URI = new INVALID_URIValue());

		/// <summary>﻿<i>URI</i> provided was incorrect.<br /><br /><br />
		/// Value for ErrorCodeEnum.<br/>
		/// <br/>See also <seealso cref="ErrorCodeEnum">ErrorCodeEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		public sealed class INVALID_URIValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="INVALID_URIValue.Name" /></summary>
			public const string NAME = "INVALID_URI";
			/// <summary>Constant value for <see cref="INVALID_URIValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.0";
			/// <summary>Constant value for <see cref="INVALID_URIValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="INVALID_URIValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;{{term(URI)}} provided was incorrect.&#10;
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
		private INVALID_XPATHValue _INVALID_XPATH;
		/// <inheritdoc cref="INVALID_XPATHValue" path="/summary" />
		public INVALID_XPATHValue INVALID_XPATH => _INVALID_XPATH ?? (_INVALID_XPATH = new INVALID_XPATHValue());

		/// <summary>﻿<i>XPath</i> identified in the <i>request</i> for information could not be parsed correctly by the <i>agent</i>.<br /><br />This could be caused by an invalid syntax or the <i>XPath</i> did not match a valid identify for any information stored in the <i>agent</i>. <br /><br /><br />
		/// Value for ErrorCodeEnum.<br/>
		/// <br/>See also <seealso cref="ErrorCodeEnum">ErrorCodeEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		public sealed class INVALID_XPATHValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="INVALID_XPATHValue.Name" /></summary>
			public const string NAME = "INVALID_XPATH";
			/// <summary>Constant value for <see cref="INVALID_XPATHValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.0";
			/// <summary>Constant value for <see cref="INVALID_XPATHValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="INVALID_XPATHValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;{{term(XPath)}} identified in the {{term(request)}} for information could not be parsed correctly by the {{term(agent)}}.

This could be caused by an invalid syntax or the {{term(XPath)}} did not match a valid identify for any information stored in the {{term(agent)}}. &#10;
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
		private NO_DEVICEValue _NO_DEVICE;
		/// <inheritdoc cref="NO_DEVICEValue" path="/summary" />
		public NO_DEVICEValue NO_DEVICE => _NO_DEVICE ?? (_NO_DEVICE = new NO_DEVICEValue());

		/// <summary>﻿identity of the <see cref="Device">Device</see> specified in the <i>request</i> for information is not associated with the <i>agent</i>.<br /><br /><br />
		/// Value for ErrorCodeEnum.<br/>
		/// <br/>See also <seealso cref="ErrorCodeEnum">ErrorCodeEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		public sealed class NO_DEVICEValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="NO_DEVICEValue.Name" /></summary>
			public const string NAME = "NO_DEVICE";
			/// <summary>Constant value for <see cref="NO_DEVICEValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.0";
			/// <summary>Constant value for <see cref="NO_DEVICEValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="NO_DEVICEValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;identity of the {{block(Device)}} specified in the {{term(request)}} for information is not associated with the {{term(agent)}}.&#10;
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

		/// <summary>﻿<i>request</i> for information specifies <i>streaming data</i> that includes sequence number(s) for pieces of data that are beyond the end of the <i>buffer</i>.<br /><br /><br />
		/// Value for ErrorCodeEnum.<br/>
		/// <br/>See also <seealso cref="ErrorCodeEnum">ErrorCodeEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		public sealed class OUT_OF_RANGEValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="OUT_OF_RANGEValue.Name" /></summary>
			public const string NAME = "OUT_OF_RANGE";
			/// <summary>Constant value for <see cref="OUT_OF_RANGEValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.0";
			/// <summary>Constant value for <see cref="OUT_OF_RANGEValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="OUT_OF_RANGEValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;{{term(request)}} for information specifies {{term(streaming data)}} that includes sequence number(s) for pieces of data that are beyond the end of the {{term(buffer)}}.&#10;
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
		private QUERY_ERRORValue _QUERY_ERROR;
		/// <inheritdoc cref="QUERY_ERRORValue" path="/summary" />
		public QUERY_ERRORValue QUERY_ERROR => _QUERY_ERROR ?? (_QUERY_ERROR = new QUERY_ERRORValue());

		/// <summary>﻿<i>agent</i> was unable to interpret the query.<br /><br />The query parameters do not contain valid values or include an invalid parameter.<br /><br /><br />
		/// Value for ErrorCodeEnum.<br/>
		/// <br/>See also <seealso cref="ErrorCodeEnum">ErrorCodeEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		public sealed class QUERY_ERRORValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="QUERY_ERRORValue.Name" /></summary>
			public const string NAME = "QUERY_ERROR";
			/// <summary>Constant value for <see cref="QUERY_ERRORValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.4";
			/// <summary>Constant value for <see cref="QUERY_ERRORValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="QUERY_ERRORValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;{{term(agent)}} was unable to interpret the query.

The query parameters do not contain valid values or include an invalid parameter.&#10;
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
		private TOO_MANYValue _TOO_MANY;
		/// <inheritdoc cref="TOO_MANYValue" path="/summary" />
		public TOO_MANYValue TOO_MANY => _TOO_MANY ?? (_TOO_MANY = new TOO_MANYValue());

		/// <summary>﻿<c>count</c> parameter provided in the <i>request</i> for information requires either of the following:<br /><br />* <i>streaming data</i> that includes more pieces of data than the <i>agent</i> is capable of organizing in an <i>MTConnectStreams Response Document</i>. <br /><br />* <see cref="Assets">Assets</see> that include more <see cref="Asset">Asset</see> in an <i>MTConnectAssets Response Document</i> than the <i>agent</i> is capable of handling. <br /><br /><br />
		/// Value for ErrorCodeEnum.<br/>
		/// <br/>See also <seealso cref="ErrorCodeEnum">ErrorCodeEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		public sealed class TOO_MANYValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="TOO_MANYValue.Name" /></summary>
			public const string NAME = "TOO_MANY";
			/// <summary>Constant value for <see cref="TOO_MANYValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.0";
			/// <summary>Constant value for <see cref="TOO_MANYValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="TOO_MANYValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;`count` parameter provided in the {{term(request)}} for information requires either of the following:

* {{term(streaming data)}} that includes more pieces of data than the {{term(agent)}} is capable of organizing in an {{term(MTConnectStreams Response Document)}}. 

* {{block(Assets)}} that include more {{block(Asset)}} in an {{term(MTConnectAssets Response Document)}} than the {{term(agent)}} is capable of handling. &#10;
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
		private UNAUTHORIZEDValue _UNAUTHORIZED;
		/// <inheritdoc cref="UNAUTHORIZEDValue" path="/summary" />
		public UNAUTHORIZEDValue UNAUTHORIZED => _UNAUTHORIZED ?? (_UNAUTHORIZED = new UNAUTHORIZEDValue());

		/// <summary>﻿<i>requester</i> does not have sufficient permissions to access the requested information.<br /><br /><br />
		/// Value for ErrorCodeEnum.<br/>
		/// <br/>See also <seealso cref="ErrorCodeEnum">ErrorCodeEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		public sealed class UNAUTHORIZEDValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="UNAUTHORIZEDValue.Name" /></summary>
			public const string NAME = "UNAUTHORIZED";
			/// <summary>Constant value for <see cref="UNAUTHORIZEDValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.0";
			/// <summary>Constant value for <see cref="UNAUTHORIZEDValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="UNAUTHORIZEDValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;{{term(requester)}} does not have sufficient permissions to access the requested information.&#10;
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
		private UNSUPPORTEDValue _UNSUPPORTED;
		/// <inheritdoc cref="UNSUPPORTEDValue" path="/summary" />
		public UNSUPPORTEDValue UNSUPPORTED => _UNSUPPORTED ?? (_UNSUPPORTED = new UNSUPPORTEDValue());

		/// <summary>﻿valid <i>request</i> was provided, but the <i>agent</i> does not support the feature or type of <i>request</i>.<br /><br /><br />
		/// Value for ErrorCodeEnum.<br/>
		/// <br/>See also <seealso cref="ErrorCodeEnum">ErrorCodeEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		public sealed class UNSUPPORTEDValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="UNSUPPORTEDValue.Name" /></summary>
			public const string NAME = "UNSUPPORTED";
			/// <summary>Constant value for <see cref="UNSUPPORTEDValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.0";
			/// <summary>Constant value for <see cref="UNSUPPORTEDValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="UNSUPPORTEDValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;valid {{term(request)}} was provided, but the {{term(agent)}} does not support the feature or type of {{term(request)}}.&#10;
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