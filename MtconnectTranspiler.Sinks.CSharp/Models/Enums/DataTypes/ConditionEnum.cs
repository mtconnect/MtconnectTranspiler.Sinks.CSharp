#pragma warning disable 0618
#pragma warning disable 1574
using System;
using System.CodeDom.Compiler;

namespace Mtconnect.DataTypes
{
	/// <summary>
	/// View in the MTConnect Model browser <seealso href="https://model.mtconnect.org/#Enumeration___19_0_3_45f01b9_1580398386435_855466_12827">model.mtconnect.org</seealso>
	/// </summary>
	/// <remarks>
	/// <list type="bullet">
	/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_">v</see></item>
	/// <item><b>Deprecated</b>: <see href="https://model.mtconnect.org/#_Version_">v</see></item>
	/// </list>
	/// </remarks>
	[Obsolete("Deprecated in v according to https://model.mtconnect.org/#_Version_")]
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.3.0.0")]
	public enum ConditionEnum
	{
		/// <summary>
		/// indication that the piece of equipment has experienced a communications failure.
		/// </summary>
		COMMUNICATIONS,
		/// <summary>
		/// indication that the value of the data associated with a measured value or a calculation is outside of an expected range.
		/// </summary>
		DATA_RANGE,
		/// <summary>
		/// indication that an error occurred in the logic program or programmable logic controller (PLC) associated with a piece of equipment.
		/// </summary>
		LOGIC_PROGRAM,
		/// <summary>
		/// indication that an error occurred in the motion program associated with a piece of equipment.
		/// </summary>
		MOTION_PROGRAM,
		/// <summary>
		/// general purpose indication associated with an electronic component of a piece of equipment or a controller that represents a fault that is not associated with the operator, program, or hardware.
		/// </summary>
		SYSTEM,
		/// <summary>
		/// indication of a fault associated with an actuator.
		/// </summary>
		ACTUATOR,
	}
}