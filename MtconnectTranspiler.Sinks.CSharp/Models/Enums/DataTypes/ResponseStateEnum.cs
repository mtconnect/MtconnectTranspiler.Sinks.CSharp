#pragma warning disable 0618
#pragma warning disable 1574
using System;
using System.CodeDom.Compiler;

namespace Mtconnect.DataTypes
{
	/// <summary>
	/// View in the MTConnect Model browser <seealso href="https://model.mtconnect.org/#Enumeration___19_0_3_68e0225_1623845159692_780642_2366">model.mtconnect.org</seealso>
	/// </summary>
	/// <remarks>
	/// <list type="bullet">
	/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_">v</see></item>
	/// <item><b>Deprecated</b>: <see href="https://model.mtconnect.org/#_Version_">v</see></item>
	/// </list>
	/// </remarks>
	[Obsolete("Deprecated in v according to https://model.mtconnect.org/#_Version_")]
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.3.0.0")]
	public enum ResponseStateEnum
	{
		/// <summary>
		/// <i>responder</i> is not ready to perform a service.
		/// </summary>
		NOT_READY,
		/// <summary>
		/// <i>responder</i> is prepared to react to a <i>request</i>, but no <i>request</i> for service has been detected.
		/// </summary>
		READY,
		/// <summary>
		/// <i>responder</i> has detected and accepted a <i>request</i> for a service and is in the process of performing the service, but the service has not yet been completed.
		/// </summary>
		ACTIVE,
		/// <summary>
		/// <i>responder</i> has completed the actions required to perform the service.
		/// </summary>
		COMPLETE,
		/// <summary>
		/// <i>responder</i> has detected a failure condition.
		/// </summary>
		FAIL,
	}
}