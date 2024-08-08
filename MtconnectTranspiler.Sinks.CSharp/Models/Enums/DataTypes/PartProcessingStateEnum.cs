#pragma warning disable 0618
#pragma warning disable 1574
using System;
using System.CodeDom.Compiler;

namespace Mtconnect.DataTypes
{
	/// <summary>
	/// View in the MTConnect Model browser <seealso href="https://model.mtconnect.org/#Enumeration___19_0_3_68e0225_1622460092329_383445_1384">model.mtconnect.org</seealso>
	/// </summary>
	/// <remarks>
	/// <list type="bullet">
	/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_">v</see></item>
	/// <item><b>Deprecated</b>: <see href="https://model.mtconnect.org/#_Version_">v</see></item>
	/// </list>
	/// </remarks>
	[Obsolete("Deprecated in v according to https://model.mtconnect.org/#_Version_")]
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.3.0.0")]
	public enum PartProcessingStateEnum
	{
		/// <summary>
		/// part occurrence is not actively being processed, but the processing has not ended.   Processing requirements exist that have not yet been fulfilled. This is the default entry state when the part occurrence is originally received. In some cases, the part occurrence may return to this state while it waits for additional processing to be performed.
		/// </summary>
		NEEDS_PROCESSING,
		/// <summary>
		/// part occurrence is actively being processed.
		/// </summary>
		IN_PROCESS,
		/// <summary>
		/// part occurrence is no longer being processed.   A general state when the reason for termination is unknown.
		/// </summary>
		PROCESSING_ENDED,
		/// <summary>
		/// part occurrence has completed processing successfully.
		/// </summary>
		PROCESSING_ENDED_COMPLETE,
		/// <summary>
		/// process has been stopped during the processing.   The part occurrence will require special treatment.
		/// </summary>
		PROCESSING_ENDED_STOPPED,
		/// <summary>
		/// processing of the part occurrence has come to a premature end.
		/// </summary>
		PROCESSING_ENDED_ABORTED,
		/// <summary>
		/// terminal state when the part occurrence has been removed from the equipment by an external entity and it no longer exists at the equipment.
		/// </summary>
		PROCESSING_ENDED_LOST,
		/// <summary>
		/// part occurrence has been skipped for processing on the piece of equipment.
		/// </summary>
		PROCESSING_ENDED_SKIPPED,
		/// <summary>
		/// part occurrence has been processed completely. However, the processing may have a problem.
		/// </summary>
		PROCESSING_ENDED_REJECTED,
		/// <summary>
		/// part occurrence is waiting for transit.
		/// </summary>
		WAITING_FOR_TRANSIT,
		/// <summary>
		/// part occurrence is being transported to its destination.
		/// </summary>
		IN_TRANSIT,
		/// <summary>
		/// part occurrence has been placed at its designated destination.
		/// </summary>
		TRANSIT_COMPLETE,
	}
}