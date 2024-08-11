using System;
using System.CodeDom.Compiler;using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;

namespace Mtconnect.DataTypes
{
	/// <summary>
	/// View in the MTConnect Model browser <seealso href="https://model.mtconnect.org/#Enumeration___19_0_3_91b028d_1579560813203_683279_6795">model.mtconnect.org</seealso>
	/// </summary>
	/// <remarks>
	/// <list type="bullet">
	/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
	/// </list>
	/// </remarks>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.3.0.0")]
	public enum ErrorCodeEnum
	{
		/// <summary>
		/// <i>request</i> for information specifies an <see cref="Asset">Asset</see> that is not recognized by the <i>agent</i>.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.2">v1.2</see></item>
		/// </list>
		/// </remarks>
		ASSET_NOT_FOUND,
		/// <summary>
		/// <i>agent</i> experienced an error while attempting to published the requested information.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>
		INTERNAL_ERROR,
		/// <summary>
		/// <i>request</i> contains information that was not recognized by the <i>agent</i>.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>
		INVALID_REQUEST,
		/// <summary>
		/// <i>URI</i> provided was incorrect.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>
		INVALID_URI,
		/// <summary>
		/// <i>XPath</i> identified in the <i>request</i> for information could not be parsed correctly by the <i>agent</i>.  This could be caused by an invalid syntax or the <i>XPath</i> did not match a valid identify for any information stored in the <i>agent</i>. 
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>
		INVALID_XPATH,
		/// <summary>
		/// identity of the <see cref="Device">Device</see> specified in the <i>request</i> for information is not associated with the <i>agent</i>.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>
		NO_DEVICE,
		/// <summary>
		/// <i>request</i> for information specifies <i>streaming data</i> that includes sequence number(s) for pieces of data that are beyond the end of the <i>buffer</i>.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>
		OUT_OF_RANGE,
		/// <summary>
		/// <i>agent</i> was unable to interpret the query.  The query parameters do not contain valid values or include an invalid parameter.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.4">v1.4</see></item>
		/// </list>
		/// </remarks>
		QUERY_ERROR,
		/// <summary>
		/// <c>count</c> parameter provided in the <i>request</i> for information requires either of the following:  * <i>streaming data</i> that includes more pieces of data than the <i>agent</i> is capable of organizing in an <i>MTConnectStreams Response Document</i>.   * <see cref="Assets">Assets</see> that include more <see cref="Asset">Asset</see> in an <i>MTConnectAssets Response Document</i> than the <i>agent</i> is capable of handling. 
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>
		TOO_MANY,
		/// <summary>
		/// <i>requester</i> does not have sufficient permissions to access the requested information.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>
		UNAUTHORIZED,
		/// <summary>
		/// valid <i>request</i> was provided, but the <i>agent</i> does not support the feature or type of <i>request</i>.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>
		UNSUPPORTED,
	}

	/// <summary>
	/// View in the MTConnect Model browser <seealso href="https://model.mtconnect.org/#Enumeration___19_0_3_91b028d_1579560813203_683279_6795">model.mtconnect.org</seealso>
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.3.0.0")]
	public sealed class ErrorCodeEnumMetaClass : IEnum
	{
		/// <inheritdoc />
		public string Name => "ErrorCodeEnum";
		
		/// <inheritdoc />
		public Type DataType => null;
		
		public Type Instance => typeof(ErrorCodeEnum);

		/// <inheritdoc />
		public string NormativeVersion => "1.0";
		
		/// <inheritdoc />
		public string DeprecatedVersion => "";
		
		/// <inheritdoc />
		public string Summary => @"";
		
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
		/// <summary>
		/// <i>request</i> for information specifies an <see cref="Asset">Asset</see> that is not recognized by the <i>agent</i>.
		/// </summary>
		public ASSET_NOT_FOUNDValue ASSET_NOT_FOUND => _ASSET_NOT_FOUND ?? (_ASSET_NOT_FOUND = new ASSET_NOT_FOUNDValue());

		/// <summary>
		/// <i>request</i> for information specifies an <see cref="Asset">Asset</see> that is not recognized by the <i>agent</i>.
		/// </summary>
		public sealed class ASSET_NOT_FOUNDValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "ASSET_NOT_FOUND";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.2";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// <i>request</i> for information specifies an <see cref=""Asset"">Asset</see> that is not recognized by the <i>agent</i>.";
		}
		private INTERNAL_ERRORValue _INTERNAL_ERROR;
		/// <summary>
		/// <i>agent</i> experienced an error while attempting to published the requested information.
		/// </summary>
		public INTERNAL_ERRORValue INTERNAL_ERROR => _INTERNAL_ERROR ?? (_INTERNAL_ERROR = new INTERNAL_ERRORValue());

		/// <summary>
		/// <i>agent</i> experienced an error while attempting to published the requested information.
		/// </summary>
		public sealed class INTERNAL_ERRORValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "INTERNAL_ERROR";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.0";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// <i>agent</i> experienced an error while attempting to published the requested information.";
		}
		private INVALID_REQUESTValue _INVALID_REQUEST;
		/// <summary>
		/// <i>request</i> contains information that was not recognized by the <i>agent</i>.
		/// </summary>
		public INVALID_REQUESTValue INVALID_REQUEST => _INVALID_REQUEST ?? (_INVALID_REQUEST = new INVALID_REQUESTValue());

		/// <summary>
		/// <i>request</i> contains information that was not recognized by the <i>agent</i>.
		/// </summary>
		public sealed class INVALID_REQUESTValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "INVALID_REQUEST";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.0";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// <i>request</i> contains information that was not recognized by the <i>agent</i>.";
		}
		private INVALID_URIValue _INVALID_URI;
		/// <summary>
		/// <i>URI</i> provided was incorrect.
		/// </summary>
		public INVALID_URIValue INVALID_URI => _INVALID_URI ?? (_INVALID_URI = new INVALID_URIValue());

		/// <summary>
		/// <i>URI</i> provided was incorrect.
		/// </summary>
		public sealed class INVALID_URIValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "INVALID_URI";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.0";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// <i>URI</i> provided was incorrect.";
		}
		private INVALID_XPATHValue _INVALID_XPATH;
		/// <summary>
		/// <i>XPath</i> identified in the <i>request</i> for information could not be parsed correctly by the <i>agent</i>.  This could be caused by an invalid syntax or the <i>XPath</i> did not match a valid identify for any information stored in the <i>agent</i>. 
		/// </summary>
		public INVALID_XPATHValue INVALID_XPATH => _INVALID_XPATH ?? (_INVALID_XPATH = new INVALID_XPATHValue());

		/// <summary>
		/// <i>XPath</i> identified in the <i>request</i> for information could not be parsed correctly by the <i>agent</i>.  This could be caused by an invalid syntax or the <i>XPath</i> did not match a valid identify for any information stored in the <i>agent</i>. 
		/// </summary>
		public sealed class INVALID_XPATHValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "INVALID_XPATH";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.0";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// <i>XPath</i> identified in the <i>request</i> for information could not be parsed correctly by the <i>agent</i>.  This could be caused by an invalid syntax or the <i>XPath</i> did not match a valid identify for any information stored in the <i>agent</i>. ";
		}
		private NO_DEVICEValue _NO_DEVICE;
		/// <summary>
		/// identity of the <see cref="Device">Device</see> specified in the <i>request</i> for information is not associated with the <i>agent</i>.
		/// </summary>
		public NO_DEVICEValue NO_DEVICE => _NO_DEVICE ?? (_NO_DEVICE = new NO_DEVICEValue());

		/// <summary>
		/// identity of the <see cref="Device">Device</see> specified in the <i>request</i> for information is not associated with the <i>agent</i>.
		/// </summary>
		public sealed class NO_DEVICEValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "NO_DEVICE";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.0";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// identity of the <see cref=""Device"">Device</see> specified in the <i>request</i> for information is not associated with the <i>agent</i>.";
		}
		private OUT_OF_RANGEValue _OUT_OF_RANGE;
		/// <summary>
		/// <i>request</i> for information specifies <i>streaming data</i> that includes sequence number(s) for pieces of data that are beyond the end of the <i>buffer</i>.
		/// </summary>
		public OUT_OF_RANGEValue OUT_OF_RANGE => _OUT_OF_RANGE ?? (_OUT_OF_RANGE = new OUT_OF_RANGEValue());

		/// <summary>
		/// <i>request</i> for information specifies <i>streaming data</i> that includes sequence number(s) for pieces of data that are beyond the end of the <i>buffer</i>.
		/// </summary>
		public sealed class OUT_OF_RANGEValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "OUT_OF_RANGE";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.0";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// <i>request</i> for information specifies <i>streaming data</i> that includes sequence number(s) for pieces of data that are beyond the end of the <i>buffer</i>.";
		}
		private QUERY_ERRORValue _QUERY_ERROR;
		/// <summary>
		/// <i>agent</i> was unable to interpret the query.  The query parameters do not contain valid values or include an invalid parameter.
		/// </summary>
		public QUERY_ERRORValue QUERY_ERROR => _QUERY_ERROR ?? (_QUERY_ERROR = new QUERY_ERRORValue());

		/// <summary>
		/// <i>agent</i> was unable to interpret the query.  The query parameters do not contain valid values or include an invalid parameter.
		/// </summary>
		public sealed class QUERY_ERRORValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "QUERY_ERROR";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.4";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// <i>agent</i> was unable to interpret the query.  The query parameters do not contain valid values or include an invalid parameter.";
		}
		private TOO_MANYValue _TOO_MANY;
		/// <summary>
		/// <c>count</c> parameter provided in the <i>request</i> for information requires either of the following:  * <i>streaming data</i> that includes more pieces of data than the <i>agent</i> is capable of organizing in an <i>MTConnectStreams Response Document</i>.   * <see cref="Assets">Assets</see> that include more <see cref="Asset">Asset</see> in an <i>MTConnectAssets Response Document</i> than the <i>agent</i> is capable of handling. 
		/// </summary>
		public TOO_MANYValue TOO_MANY => _TOO_MANY ?? (_TOO_MANY = new TOO_MANYValue());

		/// <summary>
		/// <c>count</c> parameter provided in the <i>request</i> for information requires either of the following:  * <i>streaming data</i> that includes more pieces of data than the <i>agent</i> is capable of organizing in an <i>MTConnectStreams Response Document</i>.   * <see cref="Assets">Assets</see> that include more <see cref="Asset">Asset</see> in an <i>MTConnectAssets Response Document</i> than the <i>agent</i> is capable of handling. 
		/// </summary>
		public sealed class TOO_MANYValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "TOO_MANY";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.0";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// <c>count</c> parameter provided in the <i>request</i> for information requires either of the following:  * <i>streaming data</i> that includes more pieces of data than the <i>agent</i> is capable of organizing in an <i>MTConnectStreams Response Document</i>.   * <see cref=""Assets"">Assets</see> that include more <see cref=""Asset"">Asset</see> in an <i>MTConnectAssets Response Document</i> than the <i>agent</i> is capable of handling. ";
		}
		private UNAUTHORIZEDValue _UNAUTHORIZED;
		/// <summary>
		/// <i>requester</i> does not have sufficient permissions to access the requested information.
		/// </summary>
		public UNAUTHORIZEDValue UNAUTHORIZED => _UNAUTHORIZED ?? (_UNAUTHORIZED = new UNAUTHORIZEDValue());

		/// <summary>
		/// <i>requester</i> does not have sufficient permissions to access the requested information.
		/// </summary>
		public sealed class UNAUTHORIZEDValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "UNAUTHORIZED";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.0";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// <i>requester</i> does not have sufficient permissions to access the requested information.";
		}
		private UNSUPPORTEDValue _UNSUPPORTED;
		/// <summary>
		/// valid <i>request</i> was provided, but the <i>agent</i> does not support the feature or type of <i>request</i>.
		/// </summary>
		public UNSUPPORTEDValue UNSUPPORTED => _UNSUPPORTED ?? (_UNSUPPORTED = new UNSUPPORTEDValue());

		/// <summary>
		/// valid <i>request</i> was provided, but the <i>agent</i> does not support the feature or type of <i>request</i>.
		/// </summary>
		public sealed class UNSUPPORTEDValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "UNSUPPORTED";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.0";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// valid <i>request</i> was provided, but the <i>agent</i> does not support the feature or type of <i>request</i>.";
		}
	}
}