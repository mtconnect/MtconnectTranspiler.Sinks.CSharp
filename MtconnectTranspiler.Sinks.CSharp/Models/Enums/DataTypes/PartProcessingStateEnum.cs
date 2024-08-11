using System;
using System.CodeDom.Compiler;using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;

namespace Mtconnect.DataTypes
{
	/// <summary>
	/// View in the MTConnect Model browser <seealso href="https://model.mtconnect.org/#Enumeration___19_0_3_68e0225_1622460092329_383445_1384">model.mtconnect.org</seealso>
	/// </summary>
	/// <remarks>
	/// <list type="bullet">
	/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.8">v1.8</see></item>
	/// </list>
	/// </remarks>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.3.0.0")]
	public enum PartProcessingStateEnum
	{
		/// <summary>
		/// part occurrence is not actively being processed, but the processing has not ended.   Processing requirements exist that have not yet been fulfilled. This is the default entry state when the part occurrence is originally received. In some cases, the part occurrence may return to this state while it waits for additional processing to be performed.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.8">v1.8</see></item>
		/// </list>
		/// </remarks>
		NEEDS_PROCESSING,
		/// <summary>
		/// part occurrence is actively being processed.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.8">v1.8</see></item>
		/// </list>
		/// </remarks>
		IN_PROCESS,
		/// <summary>
		/// part occurrence is no longer being processed.   A general state when the reason for termination is unknown.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.8">v1.8</see></item>
		/// </list>
		/// </remarks>
		PROCESSING_ENDED,
		/// <summary>
		/// part occurrence has completed processing successfully.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.8">v1.8</see></item>
		/// </list>
		/// </remarks>
		PROCESSING_ENDED_COMPLETE,
		/// <summary>
		/// process has been stopped during the processing.   The part occurrence will require special treatment.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.8">v1.8</see></item>
		/// </list>
		/// </remarks>
		PROCESSING_ENDED_STOPPED,
		/// <summary>
		/// processing of the part occurrence has come to a premature end.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.8">v1.8</see></item>
		/// </list>
		/// </remarks>
		PROCESSING_ENDED_ABORTED,
		/// <summary>
		/// terminal state when the part occurrence has been removed from the equipment by an external entity and it no longer exists at the equipment.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.8">v1.8</see></item>
		/// </list>
		/// </remarks>
		PROCESSING_ENDED_LOST,
		/// <summary>
		/// part occurrence has been skipped for processing on the piece of equipment.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.8">v1.8</see></item>
		/// </list>
		/// </remarks>
		PROCESSING_ENDED_SKIPPED,
		/// <summary>
		/// part occurrence has been processed completely. However, the processing may have a problem.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.8">v1.8</see></item>
		/// </list>
		/// </remarks>
		PROCESSING_ENDED_REJECTED,
		/// <summary>
		/// part occurrence is waiting for transit.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.8">v1.8</see></item>
		/// </list>
		/// </remarks>
		WAITING_FOR_TRANSIT,
		/// <summary>
		/// part occurrence is being transported to its destination.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.8">v1.8</see></item>
		/// </list>
		/// </remarks>
		IN_TRANSIT,
		/// <summary>
		/// part occurrence has been placed at its designated destination.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.8">v1.8</see></item>
		/// </list>
		/// </remarks>
		TRANSIT_COMPLETE,
	}

	/// <summary>
	/// View in the MTConnect Model browser <seealso href="https://model.mtconnect.org/#Enumeration___19_0_3_68e0225_1622460092329_383445_1384">model.mtconnect.org</seealso>
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.3.0.0")]
	public sealed class PartProcessingStateEnumMetaClass : IEnum
	{
		/// <inheritdoc />
		public string Name => "PartProcessingStateEnum";
		
		/// <inheritdoc />
		public Type DataType => null;
		
		public Type Instance => typeof(PartProcessingStateEnum);

		/// <inheritdoc />
		public string NormativeVersion => "1.8";
		
		/// <inheritdoc />
		public string DeprecatedVersion => "";
		
		/// <inheritdoc />
		public string Summary => @"";
		
		/// <inheritdoc />
		public IEnumInstance[] Values => new IEnumInstance[] {
		NEEDS_PROCESSING,
		IN_PROCESS,
		PROCESSING_ENDED,
		PROCESSING_ENDED_COMPLETE,
		PROCESSING_ENDED_STOPPED,
		PROCESSING_ENDED_ABORTED,
		PROCESSING_ENDED_LOST,
		PROCESSING_ENDED_SKIPPED,
		PROCESSING_ENDED_REJECTED,
		WAITING_FOR_TRANSIT,
		IN_TRANSIT,
		TRANSIT_COMPLETE,
		};

		private NEEDS_PROCESSINGValue _NEEDS_PROCESSING;
		/// <summary>
		/// part occurrence is not actively being processed, but the processing has not ended.   Processing requirements exist that have not yet been fulfilled. This is the default entry state when the part occurrence is originally received. In some cases, the part occurrence may return to this state while it waits for additional processing to be performed.
		/// </summary>
		public NEEDS_PROCESSINGValue NEEDS_PROCESSING => _NEEDS_PROCESSING ?? (_NEEDS_PROCESSING = new NEEDS_PROCESSINGValue());

		/// <summary>
		/// part occurrence is not actively being processed, but the processing has not ended.   Processing requirements exist that have not yet been fulfilled. This is the default entry state when the part occurrence is originally received. In some cases, the part occurrence may return to this state while it waits for additional processing to be performed.
		/// </summary>
		public sealed class NEEDS_PROCESSINGValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "NEEDS_PROCESSING";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.8";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// part occurrence is not actively being processed, but the processing has not ended.   Processing requirements exist that have not yet been fulfilled. This is the default entry state when the part occurrence is originally received. In some cases, the part occurrence may return to this state while it waits for additional processing to be performed.";
		}
		private IN_PROCESSValue _IN_PROCESS;
		/// <summary>
		/// part occurrence is actively being processed.
		/// </summary>
		public IN_PROCESSValue IN_PROCESS => _IN_PROCESS ?? (_IN_PROCESS = new IN_PROCESSValue());

		/// <summary>
		/// part occurrence is actively being processed.
		/// </summary>
		public sealed class IN_PROCESSValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "IN_PROCESS";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.8";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// part occurrence is actively being processed.";
		}
		private PROCESSING_ENDEDValue _PROCESSING_ENDED;
		/// <summary>
		/// part occurrence is no longer being processed.   A general state when the reason for termination is unknown.
		/// </summary>
		public PROCESSING_ENDEDValue PROCESSING_ENDED => _PROCESSING_ENDED ?? (_PROCESSING_ENDED = new PROCESSING_ENDEDValue());

		/// <summary>
		/// part occurrence is no longer being processed.   A general state when the reason for termination is unknown.
		/// </summary>
		public sealed class PROCESSING_ENDEDValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "PROCESSING_ENDED";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.8";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// part occurrence is no longer being processed.   A general state when the reason for termination is unknown.";
		}
		private PROCESSING_ENDED_COMPLETEValue _PROCESSING_ENDED_COMPLETE;
		/// <summary>
		/// part occurrence has completed processing successfully.
		/// </summary>
		public PROCESSING_ENDED_COMPLETEValue PROCESSING_ENDED_COMPLETE => _PROCESSING_ENDED_COMPLETE ?? (_PROCESSING_ENDED_COMPLETE = new PROCESSING_ENDED_COMPLETEValue());

		/// <summary>
		/// part occurrence has completed processing successfully.
		/// </summary>
		public sealed class PROCESSING_ENDED_COMPLETEValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "PROCESSING_ENDED_COMPLETE";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.8";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// part occurrence has completed processing successfully.";
		}
		private PROCESSING_ENDED_STOPPEDValue _PROCESSING_ENDED_STOPPED;
		/// <summary>
		/// process has been stopped during the processing.   The part occurrence will require special treatment.
		/// </summary>
		public PROCESSING_ENDED_STOPPEDValue PROCESSING_ENDED_STOPPED => _PROCESSING_ENDED_STOPPED ?? (_PROCESSING_ENDED_STOPPED = new PROCESSING_ENDED_STOPPEDValue());

		/// <summary>
		/// process has been stopped during the processing.   The part occurrence will require special treatment.
		/// </summary>
		public sealed class PROCESSING_ENDED_STOPPEDValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "PROCESSING_ENDED_STOPPED";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.8";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// process has been stopped during the processing.   The part occurrence will require special treatment.";
		}
		private PROCESSING_ENDED_ABORTEDValue _PROCESSING_ENDED_ABORTED;
		/// <summary>
		/// processing of the part occurrence has come to a premature end.
		/// </summary>
		public PROCESSING_ENDED_ABORTEDValue PROCESSING_ENDED_ABORTED => _PROCESSING_ENDED_ABORTED ?? (_PROCESSING_ENDED_ABORTED = new PROCESSING_ENDED_ABORTEDValue());

		/// <summary>
		/// processing of the part occurrence has come to a premature end.
		/// </summary>
		public sealed class PROCESSING_ENDED_ABORTEDValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "PROCESSING_ENDED_ABORTED";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.8";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// processing of the part occurrence has come to a premature end.";
		}
		private PROCESSING_ENDED_LOSTValue _PROCESSING_ENDED_LOST;
		/// <summary>
		/// terminal state when the part occurrence has been removed from the equipment by an external entity and it no longer exists at the equipment.
		/// </summary>
		public PROCESSING_ENDED_LOSTValue PROCESSING_ENDED_LOST => _PROCESSING_ENDED_LOST ?? (_PROCESSING_ENDED_LOST = new PROCESSING_ENDED_LOSTValue());

		/// <summary>
		/// terminal state when the part occurrence has been removed from the equipment by an external entity and it no longer exists at the equipment.
		/// </summary>
		public sealed class PROCESSING_ENDED_LOSTValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "PROCESSING_ENDED_LOST";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.8";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// terminal state when the part occurrence has been removed from the equipment by an external entity and it no longer exists at the equipment.";
		}
		private PROCESSING_ENDED_SKIPPEDValue _PROCESSING_ENDED_SKIPPED;
		/// <summary>
		/// part occurrence has been skipped for processing on the piece of equipment.
		/// </summary>
		public PROCESSING_ENDED_SKIPPEDValue PROCESSING_ENDED_SKIPPED => _PROCESSING_ENDED_SKIPPED ?? (_PROCESSING_ENDED_SKIPPED = new PROCESSING_ENDED_SKIPPEDValue());

		/// <summary>
		/// part occurrence has been skipped for processing on the piece of equipment.
		/// </summary>
		public sealed class PROCESSING_ENDED_SKIPPEDValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "PROCESSING_ENDED_SKIPPED";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.8";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// part occurrence has been skipped for processing on the piece of equipment.";
		}
		private PROCESSING_ENDED_REJECTEDValue _PROCESSING_ENDED_REJECTED;
		/// <summary>
		/// part occurrence has been processed completely. However, the processing may have a problem.
		/// </summary>
		public PROCESSING_ENDED_REJECTEDValue PROCESSING_ENDED_REJECTED => _PROCESSING_ENDED_REJECTED ?? (_PROCESSING_ENDED_REJECTED = new PROCESSING_ENDED_REJECTEDValue());

		/// <summary>
		/// part occurrence has been processed completely. However, the processing may have a problem.
		/// </summary>
		public sealed class PROCESSING_ENDED_REJECTEDValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "PROCESSING_ENDED_REJECTED";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.8";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// part occurrence has been processed completely. However, the processing may have a problem.";
		}
		private WAITING_FOR_TRANSITValue _WAITING_FOR_TRANSIT;
		/// <summary>
		/// part occurrence is waiting for transit.
		/// </summary>
		public WAITING_FOR_TRANSITValue WAITING_FOR_TRANSIT => _WAITING_FOR_TRANSIT ?? (_WAITING_FOR_TRANSIT = new WAITING_FOR_TRANSITValue());

		/// <summary>
		/// part occurrence is waiting for transit.
		/// </summary>
		public sealed class WAITING_FOR_TRANSITValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "WAITING_FOR_TRANSIT";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.8";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// part occurrence is waiting for transit.";
		}
		private IN_TRANSITValue _IN_TRANSIT;
		/// <summary>
		/// part occurrence is being transported to its destination.
		/// </summary>
		public IN_TRANSITValue IN_TRANSIT => _IN_TRANSIT ?? (_IN_TRANSIT = new IN_TRANSITValue());

		/// <summary>
		/// part occurrence is being transported to its destination.
		/// </summary>
		public sealed class IN_TRANSITValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "IN_TRANSIT";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.8";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// part occurrence is being transported to its destination.";
		}
		private TRANSIT_COMPLETEValue _TRANSIT_COMPLETE;
		/// <summary>
		/// part occurrence has been placed at its designated destination.
		/// </summary>
		public TRANSIT_COMPLETEValue TRANSIT_COMPLETE => _TRANSIT_COMPLETE ?? (_TRANSIT_COMPLETE = new TRANSIT_COMPLETEValue());

		/// <summary>
		/// part occurrence has been placed at its designated destination.
		/// </summary>
		public sealed class TRANSIT_COMPLETEValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "TRANSIT_COMPLETE";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.8";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// part occurrence has been placed at its designated destination.";
		}
	}
}