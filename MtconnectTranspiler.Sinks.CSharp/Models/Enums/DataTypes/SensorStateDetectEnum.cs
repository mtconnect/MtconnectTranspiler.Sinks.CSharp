#pragma warning disable 0618
#pragma warning disable 1574
using System;
using System.CodeDom.Compiler;

namespace Mtconnect.DataTypes
{
	/// <summary>
	/// View in the MTConnect Model browser <seealso href="https://model.mtconnect.org/#Enumeration___19_0_3_68e0225_1677589978293_52377_922">model.mtconnect.org</seealso>
	/// </summary>
	/// <remarks>
	/// <list type="bullet">
	/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_">v</see></item>
	/// <item><b>Deprecated</b>: <see href="https://model.mtconnect.org/#_Version_">v</see></item>
	/// </list>
	/// </remarks>
	[Obsolete("Deprecated in v according to https://model.mtconnect.org/#_Version_")]
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "1.0.15.3")]
	public enum SensorStateDetectEnum
	{
		/// <summary>
		/// sensor is active and the threshold has been met.
		/// </summary>
		DETECTED,
		/// <summary>
		/// sensor is active and ready but the threshold has not been met.
		/// </summary>
		NOT_DETECTED,
		/// <summary>
		/// sensor is active, but the state cannot be determined.  > Note: unknown covers situations where the sensor reading is unstable.
		/// </summary>
		UNKNOWN,
	}
}