#pragma warning disable 0618
#pragma warning disable 1574
using System;
using System.CodeDom.Compiler;

namespace Mtconnect.DataTypes
{
	/// <summary>
	/// View in the MTConnect Model browser <seealso href="https://model.mtconnect.org/#Enumeration___19_0_3_91b028d_1579560813203_683279_6795">model.mtconnect.org</seealso>
	/// </summary>
	/// <remarks>
	/// <list type="bullet">
	/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_">v</see></item>
	/// <item><b>Deprecated</b>: <see href="https://model.mtconnect.org/#_Version_">v</see></item>
	/// </list>
	/// </remarks>
	[Obsolete("Deprecated in v according to https://model.mtconnect.org/#_Version_")]
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "1.0.15.3")]
	public enum ErrorCodeEnum
	{
		/// <summary>
		/// <i>request</i> for information specifies an <see cref="Asset">Asset</see> that is not recognized by the <i>agent</i>.
		/// </summary>
		ASSET_NOT_FOUND,
		/// <summary>
		/// <i>agent</i> experienced an error while attempting to published the requested information.
		/// </summary>
		INTERNAL_ERROR,
		/// <summary>
		/// <i>request</i> contains information that was not recognized by the <i>agent</i>.
		/// </summary>
		INVALID_REQUEST,
		/// <summary>
		/// <i>URI</i> provided was incorrect.
		/// </summary>
		INVALID_URI,
		/// <summary>
		/// <i>XPath</i> identified in the <i>request</i> for information could not be parsed correctly by the <i>agent</i>.  This could be caused by an invalid syntax or the <i>XPath</i> did not match a valid identify for any information stored in the <i>agent</i>. 
		/// </summary>
		INVALID_XPATH,
		/// <summary>
		/// identity of the <see cref="Device">Device</see> specified in the <i>request</i> for information is not associated with the <i>agent</i>.
		/// </summary>
		NO_DEVICE,
		/// <summary>
		/// <i>request</i> for information specifies <i>streaming data</i> that includes sequence number(s) for pieces of data that are beyond the end of the <i>buffer</i>.
		/// </summary>
		OUT_OF_RANGE,
		/// <summary>
		/// <i>agent</i> was unable to interpret the query.  The query parameters do not contain valid values or include an invalid parameter.
		/// </summary>
		QUERY_ERROR,
		/// <summary>
		/// <c>count</c> parameter provided in the <i>request</i> for information requires either of the following:  * <i>streaming data</i> that includes more pieces of data than the <i>agent</i> is capable of organizing in an <i>MTConnectStreams Response Document</i>.   * <see cref="Assets">Assets</see> that include more <see cref="Asset">Asset</see> in an <i>MTConnectAssets Response Document</i> than the <i>agent</i> is capable of handling. 
		/// </summary>
		TOO_MANY,
		/// <summary>
		/// <i>requester</i> does not have sufficient permissions to access the requested information.
		/// </summary>
		UNAUTHORIZED,
		/// <summary>
		/// valid <i>request</i> was provided, but the <i>agent</i> does not support the feature or type of <i>request</i>.
		/// </summary>
		UNSUPPORTED,
	}
}