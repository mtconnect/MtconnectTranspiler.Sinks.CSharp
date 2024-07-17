#pragma warning disable 0618
#pragma warning disable 1574
using System;
using System.CodeDom.Compiler;

namespace Mtconnect.DataTypes
{
	/// <summary>
	/// View in the MTConnect Model browser <seealso href="https://model.mtconnect.org/#Enumeration___19_0_3_68e0225_1623845125853_44708_2341">model.mtconnect.org</seealso>
	/// </summary>
	/// <remarks>
	/// <list type="bullet">
	/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_">v</see></item>
	/// <item><b>Deprecated</b>: <see href="https://model.mtconnect.org/#_Version_">v</see></item>
	/// </list>
	/// </remarks>
	[Obsolete("Deprecated in v according to https://model.mtconnect.org/#_Version_")]
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "1.0.15.3")]
	public enum RequestStateEnum
	{
		/// <summary>
		/// <i>requester</i> is not ready to make a <i>request</i>.
		/// </summary>
		NOT_READY,
		/// <summary>
		/// <i>requester</i> is prepared to make a <i>request</i>, but no <i>request</i> for service is required.
		/// </summary>
		READY,
		/// <summary>
		/// <i>requester</i> has initiated a <i>request</i> for a service and the service has not yet been completed by the <i>responder</i>.
		/// </summary>
		ACTIVE,
		/// <summary>
		/// <i>requester</i> has detected a failure condition.
		/// </summary>
		FAIL,
	}
}