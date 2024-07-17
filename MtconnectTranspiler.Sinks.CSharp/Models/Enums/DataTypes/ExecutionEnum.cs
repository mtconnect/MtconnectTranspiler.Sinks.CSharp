#pragma warning disable 0618
#pragma warning disable 1574
using System;
using System.CodeDom.Compiler;

namespace Mtconnect.DataTypes
{
	/// <summary>
	/// View in the MTConnect Model browser <seealso href="https://model.mtconnect.org/#Enumeration___19_0_3_45f01b9_1580378417664_592980_2878">model.mtconnect.org</seealso>
	/// </summary>
	/// <remarks>
	/// <list type="bullet">
	/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_">v</see></item>
	/// <item><b>Deprecated</b>: <see href="https://model.mtconnect.org/#_Version_">v</see></item>
	/// </list>
	/// </remarks>
	[Obsolete("Deprecated in v according to https://model.mtconnect.org/#_Version_")]
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "1.0.15.3")]
	public enum ExecutionEnum
	{
		/// <summary>
		/// <see cref="Component">Component</see> is ready to execute instructions.  It is currently idle.
		/// </summary>
		READY,
		/// <summary>
		/// <see cref="Component">Component</see> is actively executing an instruction.
		/// </summary>
		ACTIVE,
		/// <summary>
		/// <see cref="Component">Component</see> suspends the execution of the program due to an external signal.  Action is required to resume execution.
		/// </summary>
		INTERRUPTED,
		/// <summary>
		/// motion of the active axes are commanded to stop at their current position.
		/// </summary>
		FEED_HOLD,
		/// <summary>
		/// <see cref="Component">Component</see> program is not <c>READY</c> to execute.
		/// </summary>
		STOPPED,
		/// <summary>
		/// command from the program has intentionally interrupted execution.  The <see cref="Component">Component</see> <b>MAY</b> have another state that indicates if the execution is interrupted or the execution ignores the interrupt instruction.
		/// </summary>
		OPTIONAL_STOP,
		/// <summary>
		/// command from the program has intentionally interrupted execution.  Action is required to resume execution.
		/// </summary>
		PROGRAM_STOPPED,
		/// <summary>
		/// program completed execution.
		/// </summary>
		PROGRAM_COMPLETED,
		/// <summary>
		/// <see cref="Component">Component</see> suspends execution while a secondary operation executes.  Execution resumes automatically once the secondary operation completes.
		/// </summary>
		WAIT,
		/// <summary>
		/// program has been intentionally optionally stopped using an M01 or similar code.  <b>DEPRECATED</b> in <i>version 1.4</i>s and replaced with <c>OPTIONAL_STOP</c>.
		/// </summary>
		PROGRAM_OPTIONAL_STOP,
	}
}