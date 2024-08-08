#pragma warning disable 0618
#pragma warning disable 1574
using System;
using System.CodeDom.Compiler;

namespace Mtconnect.DataTypes
{
	/// <summary>
	/// View in the MTConnect Model browser <seealso href="https://model.mtconnect.org/#Enumeration___19_0_3_45f01b9_1580378417660_348819_2874">model.mtconnect.org</seealso>
	/// </summary>
	/// <remarks>
	/// <list type="bullet">
	/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_">v</see></item>
	/// <item><b>Deprecated</b>: <see href="https://model.mtconnect.org/#_Version_">v</see></item>
	/// </list>
	/// </remarks>
	[Obsolete("Deprecated in v according to https://model.mtconnect.org/#_Version_")]
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.3.0.0")]
	public enum ControllerModeEnum
	{
		/// <summary>
		/// <see cref="Controller">Controller</see> is configured to automatically execute a program.
		/// </summary>
		AUTOMATIC,
		/// <summary>
		/// <see cref="Controller">Controller</see> is not executing an active program.   It is capable of receiving instructions from an external source – typically an operator. The <see cref="Controller">Controller</see> executes operations based on the instructions received from the external source.
		/// </summary>
		MANUAL,
		/// <summary>
		/// operator can enter a series of operations for the <see cref="Controller">Controller</see> to perform.  The <see cref="Controller">Controller</see> will execute this specific series of operations and then stop.
		/// </summary>
		MANUAL_DATA_INPUT,
		/// <summary>
		/// <see cref="Controller">Controller</see> is operating in a mode that restricts the active program from processing its next process step without operator intervention.
		/// </summary>
		SEMI_AUTOMATIC,
		/// <summary>
		/// <see cref="Controller">Controller</see> is currently functioning as a programming device and is not capable of executing an active program.
		/// </summary>
		EDIT,
		/// <summary>
		/// axes of the device are commanded to stop, but the spindle continues to function.
		/// </summary>
		FEED_HOLD,
	}
}