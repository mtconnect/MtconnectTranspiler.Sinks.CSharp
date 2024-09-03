#pragma warning disable CS1574 // XML comment has cref attribute that could not be resolved
#pragma warning disable CS1584 // XML comment has syntactically incorrect cref attribute
#pragma warning disable CS0618 // Type or member is obsolete
using System;
using System.CodeDom.Compiler;using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;

namespace Mtconnect.DataTypes
{
	/// <summary>﻿
	/// <br/> Visit <seealso href="https://model.mtconnect.org/#Enumeration___19_0_3_68e0225_1622460092329_383445_1384">model.mtconnect.org</seealso> for more information.
	/// </summary>
	/// <remarks>
	/// <list type="bullet">
	/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.8">v1.8</see></item>
	/// </list>
	/// </remarks>

	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public enum PartProcessingStateEnum
	{
		/// <summary>﻿part occurrence is not actively being processed, but the processing has not ended. <br /><br />Processing requirements exist that have not yet been fulfilled. This is the default entry state when the part occurrence is originally received. In some cases, the part occurrence may return to this state while it waits for additional processing to be performed.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.8">v1.8</see></item>
		/// </list>
		/// </remarks>

		NEEDS_PROCESSING,
		/// <summary>﻿part occurrence is actively being processed.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.8">v1.8</see></item>
		/// </list>
		/// </remarks>

		IN_PROCESS,
		/// <summary>﻿part occurrence is no longer being processed. <br /><br />A general state when the reason for termination is unknown.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.8">v1.8</see></item>
		/// </list>
		/// </remarks>

		PROCESSING_ENDED,
		/// <summary>﻿part occurrence has completed processing successfully.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.8">v1.8</see></item>
		/// </list>
		/// </remarks>

		PROCESSING_ENDED_COMPLETE,
		/// <summary>﻿process has been stopped during the processing. <br /><br />The part occurrence will require special treatment.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.8">v1.8</see></item>
		/// </list>
		/// </remarks>

		PROCESSING_ENDED_STOPPED,
		/// <summary>﻿processing of the part occurrence has come to a premature end.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.8">v1.8</see></item>
		/// </list>
		/// </remarks>

		PROCESSING_ENDED_ABORTED,
		/// <summary>﻿terminal state when the part occurrence has been removed from the equipment by an external entity and it no longer exists at the equipment.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.8">v1.8</see></item>
		/// </list>
		/// </remarks>

		PROCESSING_ENDED_LOST,
		/// <summary>﻿part occurrence has been skipped for processing on the piece of equipment.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.8">v1.8</see></item>
		/// </list>
		/// </remarks>

		PROCESSING_ENDED_SKIPPED,
		/// <summary>﻿part occurrence has been processed completely. However, the processing may have a problem.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.8">v1.8</see></item>
		/// </list>
		/// </remarks>

		PROCESSING_ENDED_REJECTED,
		/// <summary>﻿part occurrence is waiting for transit.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.8">v1.8</see></item>
		/// </list>
		/// </remarks>

		WAITING_FOR_TRANSIT,
		/// <summary>﻿part occurrence is being transported to its destination.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.8">v1.8</see></item>
		/// </list>
		/// </remarks>

		IN_TRANSIT,
		/// <summary>﻿part occurrence has been placed at its designated destination.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.8">v1.8</see></item>
		/// </list>
		/// </remarks>

		TRANSIT_COMPLETE,
	}

	/// <summary>﻿
	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Enumeration___19_0_3_68e0225_1622460092329_383445_1384">model.mtconnect.org</seealso> for more information.
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public sealed class PartProcessingStateEnumMetaClass : IEnum
	{
		/// <summary>Constant value for <see cref="PartProcessingStateEnumMetaClass.ReferenceId" /></summary>
		public const string REFERENCE_ID = "_19_0_3_68e0225_1622460092329_383445_1384";
		/// <summary>Constant value for <see cref="PartProcessingStateEnumMetaClass.HelpUrl" /></summary>
		public const string HELP_URL = "https://model.mtconnect.org/#Enumeration___19_0_3_68e0225_1622460092329_383445_1384";
		/// <summary>Constant value for <see cref="PartProcessingStateEnumMetaClass.Name" /></summary>
		public const string NAME = "PartProcessingStateEnum";
		/// <summary>Constant value for <see cref="PartProcessingStateEnumMetaClass.NormativeVersion" /></summary>
		public const string NORMATIVE_VERSION = "1.8";
		/// <summary>Constant value for <see cref="PartProcessingStateEnumMetaClass.DeprecatedVersion" /></summary>
		public const string DEPRECATED_VERSION = "";
		/// <summary>Constant value for <see cref="PartProcessingStateEnumMetaClass.Summary" /></summary>
		public const string SUMMARY = @"";

		/// <inheritdoc />
		public string ReferenceId => REFERENCE_ID;
		
		/// <inheritdoc />
		public string HelpUrl => HELP_URL;

		/// <inheritdoc />
		public string Name => NAME;
		
		/// <inheritdoc />
		public Type DataType => null;
		
		/// <inheritdoc />
		public Type Instance => typeof(PartProcessingStateEnum);

		/// <inheritdoc />
		public string NormativeVersion => NORMATIVE_VERSION;
		
		/// <inheritdoc />
		public string DeprecatedVersion => DEPRECATED_VERSION;
		
		/// <inheritdoc />
		public string Summary => SUMMARY;
		
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
		/// <inheritdoc cref="NEEDS_PROCESSINGValue" path="/summary" />
		public NEEDS_PROCESSINGValue NEEDS_PROCESSING => _NEEDS_PROCESSING ?? (_NEEDS_PROCESSING = new NEEDS_PROCESSINGValue());

		/// <summary>﻿part occurrence is not actively being processed, but the processing has not ended. <br /><br />Processing requirements exist that have not yet been fulfilled. This is the default entry state when the part occurrence is originally received. In some cases, the part occurrence may return to this state while it waits for additional processing to be performed.<br /><br /><br />
		/// Value for PartProcessingStateEnum.<br/>
		/// <br/>See also <seealso cref="PartProcessingStateEnum">PartProcessingStateEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.8">v1.8</see></item>
		/// </list>
		/// </remarks>

		public sealed class NEEDS_PROCESSINGValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="NEEDS_PROCESSINGValue.Name" /></summary>
			public const string NAME = "NEEDS_PROCESSING";
			/// <summary>Constant value for <see cref="NEEDS_PROCESSINGValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.8";
			/// <summary>Constant value for <see cref="NEEDS_PROCESSINGValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="NEEDS_PROCESSINGValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;part occurrence is not actively being processed, but the processing has not ended. 

Processing requirements exist that have not yet been fulfilled. This is the default entry state when the part occurrence is originally received. In some cases, the part occurrence may return to this state while it waits for additional processing to be performed.&#10;
";

			/// <inheritdoc />
			public string Name => NAME;
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => NORMATIVE_VERSION;
			
			/// <inheritdoc />
			public string DeprecatedVersion => DEPRECATED_VERSION;
			
			/// <inheritdoc />
			public string Summary => SUMMARY;
		}
		private IN_PROCESSValue _IN_PROCESS;
		/// <inheritdoc cref="IN_PROCESSValue" path="/summary" />
		public IN_PROCESSValue IN_PROCESS => _IN_PROCESS ?? (_IN_PROCESS = new IN_PROCESSValue());

		/// <summary>﻿part occurrence is actively being processed.<br /><br /><br />
		/// Value for PartProcessingStateEnum.<br/>
		/// <br/>See also <seealso cref="PartProcessingStateEnum">PartProcessingStateEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.8">v1.8</see></item>
		/// </list>
		/// </remarks>

		public sealed class IN_PROCESSValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="IN_PROCESSValue.Name" /></summary>
			public const string NAME = "IN_PROCESS";
			/// <summary>Constant value for <see cref="IN_PROCESSValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.8";
			/// <summary>Constant value for <see cref="IN_PROCESSValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="IN_PROCESSValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;part occurrence is actively being processed.&#10;
";

			/// <inheritdoc />
			public string Name => NAME;
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => NORMATIVE_VERSION;
			
			/// <inheritdoc />
			public string DeprecatedVersion => DEPRECATED_VERSION;
			
			/// <inheritdoc />
			public string Summary => SUMMARY;
		}
		private PROCESSING_ENDEDValue _PROCESSING_ENDED;
		/// <inheritdoc cref="PROCESSING_ENDEDValue" path="/summary" />
		public PROCESSING_ENDEDValue PROCESSING_ENDED => _PROCESSING_ENDED ?? (_PROCESSING_ENDED = new PROCESSING_ENDEDValue());

		/// <summary>﻿part occurrence is no longer being processed. <br /><br />A general state when the reason for termination is unknown.<br /><br /><br />
		/// Value for PartProcessingStateEnum.<br/>
		/// <br/>See also <seealso cref="PartProcessingStateEnum">PartProcessingStateEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.8">v1.8</see></item>
		/// </list>
		/// </remarks>

		public sealed class PROCESSING_ENDEDValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="PROCESSING_ENDEDValue.Name" /></summary>
			public const string NAME = "PROCESSING_ENDED";
			/// <summary>Constant value for <see cref="PROCESSING_ENDEDValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.8";
			/// <summary>Constant value for <see cref="PROCESSING_ENDEDValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="PROCESSING_ENDEDValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;part occurrence is no longer being processed. 

A general state when the reason for termination is unknown.&#10;
";

			/// <inheritdoc />
			public string Name => NAME;
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => NORMATIVE_VERSION;
			
			/// <inheritdoc />
			public string DeprecatedVersion => DEPRECATED_VERSION;
			
			/// <inheritdoc />
			public string Summary => SUMMARY;
		}
		private PROCESSING_ENDED_COMPLETEValue _PROCESSING_ENDED_COMPLETE;
		/// <inheritdoc cref="PROCESSING_ENDED_COMPLETEValue" path="/summary" />
		public PROCESSING_ENDED_COMPLETEValue PROCESSING_ENDED_COMPLETE => _PROCESSING_ENDED_COMPLETE ?? (_PROCESSING_ENDED_COMPLETE = new PROCESSING_ENDED_COMPLETEValue());

		/// <summary>﻿part occurrence has completed processing successfully.<br /><br /><br />
		/// Value for PartProcessingStateEnum.<br/>
		/// <br/>See also <seealso cref="PartProcessingStateEnum">PartProcessingStateEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.8">v1.8</see></item>
		/// </list>
		/// </remarks>

		public sealed class PROCESSING_ENDED_COMPLETEValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="PROCESSING_ENDED_COMPLETEValue.Name" /></summary>
			public const string NAME = "PROCESSING_ENDED_COMPLETE";
			/// <summary>Constant value for <see cref="PROCESSING_ENDED_COMPLETEValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.8";
			/// <summary>Constant value for <see cref="PROCESSING_ENDED_COMPLETEValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="PROCESSING_ENDED_COMPLETEValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;part occurrence has completed processing successfully.&#10;
";

			/// <inheritdoc />
			public string Name => NAME;
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => NORMATIVE_VERSION;
			
			/// <inheritdoc />
			public string DeprecatedVersion => DEPRECATED_VERSION;
			
			/// <inheritdoc />
			public string Summary => SUMMARY;
		}
		private PROCESSING_ENDED_STOPPEDValue _PROCESSING_ENDED_STOPPED;
		/// <inheritdoc cref="PROCESSING_ENDED_STOPPEDValue" path="/summary" />
		public PROCESSING_ENDED_STOPPEDValue PROCESSING_ENDED_STOPPED => _PROCESSING_ENDED_STOPPED ?? (_PROCESSING_ENDED_STOPPED = new PROCESSING_ENDED_STOPPEDValue());

		/// <summary>﻿process has been stopped during the processing. <br /><br />The part occurrence will require special treatment.<br /><br /><br />
		/// Value for PartProcessingStateEnum.<br/>
		/// <br/>See also <seealso cref="PartProcessingStateEnum">PartProcessingStateEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.8">v1.8</see></item>
		/// </list>
		/// </remarks>

		public sealed class PROCESSING_ENDED_STOPPEDValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="PROCESSING_ENDED_STOPPEDValue.Name" /></summary>
			public const string NAME = "PROCESSING_ENDED_STOPPED";
			/// <summary>Constant value for <see cref="PROCESSING_ENDED_STOPPEDValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.8";
			/// <summary>Constant value for <see cref="PROCESSING_ENDED_STOPPEDValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="PROCESSING_ENDED_STOPPEDValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;process has been stopped during the processing. 

The part occurrence will require special treatment.&#10;
";

			/// <inheritdoc />
			public string Name => NAME;
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => NORMATIVE_VERSION;
			
			/// <inheritdoc />
			public string DeprecatedVersion => DEPRECATED_VERSION;
			
			/// <inheritdoc />
			public string Summary => SUMMARY;
		}
		private PROCESSING_ENDED_ABORTEDValue _PROCESSING_ENDED_ABORTED;
		/// <inheritdoc cref="PROCESSING_ENDED_ABORTEDValue" path="/summary" />
		public PROCESSING_ENDED_ABORTEDValue PROCESSING_ENDED_ABORTED => _PROCESSING_ENDED_ABORTED ?? (_PROCESSING_ENDED_ABORTED = new PROCESSING_ENDED_ABORTEDValue());

		/// <summary>﻿processing of the part occurrence has come to a premature end.<br /><br /><br />
		/// Value for PartProcessingStateEnum.<br/>
		/// <br/>See also <seealso cref="PartProcessingStateEnum">PartProcessingStateEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.8">v1.8</see></item>
		/// </list>
		/// </remarks>

		public sealed class PROCESSING_ENDED_ABORTEDValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="PROCESSING_ENDED_ABORTEDValue.Name" /></summary>
			public const string NAME = "PROCESSING_ENDED_ABORTED";
			/// <summary>Constant value for <see cref="PROCESSING_ENDED_ABORTEDValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.8";
			/// <summary>Constant value for <see cref="PROCESSING_ENDED_ABORTEDValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="PROCESSING_ENDED_ABORTEDValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;processing of the part occurrence has come to a premature end.&#10;
";

			/// <inheritdoc />
			public string Name => NAME;
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => NORMATIVE_VERSION;
			
			/// <inheritdoc />
			public string DeprecatedVersion => DEPRECATED_VERSION;
			
			/// <inheritdoc />
			public string Summary => SUMMARY;
		}
		private PROCESSING_ENDED_LOSTValue _PROCESSING_ENDED_LOST;
		/// <inheritdoc cref="PROCESSING_ENDED_LOSTValue" path="/summary" />
		public PROCESSING_ENDED_LOSTValue PROCESSING_ENDED_LOST => _PROCESSING_ENDED_LOST ?? (_PROCESSING_ENDED_LOST = new PROCESSING_ENDED_LOSTValue());

		/// <summary>﻿terminal state when the part occurrence has been removed from the equipment by an external entity and it no longer exists at the equipment.<br /><br /><br />
		/// Value for PartProcessingStateEnum.<br/>
		/// <br/>See also <seealso cref="PartProcessingStateEnum">PartProcessingStateEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.8">v1.8</see></item>
		/// </list>
		/// </remarks>

		public sealed class PROCESSING_ENDED_LOSTValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="PROCESSING_ENDED_LOSTValue.Name" /></summary>
			public const string NAME = "PROCESSING_ENDED_LOST";
			/// <summary>Constant value for <see cref="PROCESSING_ENDED_LOSTValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.8";
			/// <summary>Constant value for <see cref="PROCESSING_ENDED_LOSTValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="PROCESSING_ENDED_LOSTValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;terminal state when the part occurrence has been removed from the equipment by an external entity and it no longer exists at the equipment.&#10;
";

			/// <inheritdoc />
			public string Name => NAME;
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => NORMATIVE_VERSION;
			
			/// <inheritdoc />
			public string DeprecatedVersion => DEPRECATED_VERSION;
			
			/// <inheritdoc />
			public string Summary => SUMMARY;
		}
		private PROCESSING_ENDED_SKIPPEDValue _PROCESSING_ENDED_SKIPPED;
		/// <inheritdoc cref="PROCESSING_ENDED_SKIPPEDValue" path="/summary" />
		public PROCESSING_ENDED_SKIPPEDValue PROCESSING_ENDED_SKIPPED => _PROCESSING_ENDED_SKIPPED ?? (_PROCESSING_ENDED_SKIPPED = new PROCESSING_ENDED_SKIPPEDValue());

		/// <summary>﻿part occurrence has been skipped for processing on the piece of equipment.<br /><br /><br />
		/// Value for PartProcessingStateEnum.<br/>
		/// <br/>See also <seealso cref="PartProcessingStateEnum">PartProcessingStateEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.8">v1.8</see></item>
		/// </list>
		/// </remarks>

		public sealed class PROCESSING_ENDED_SKIPPEDValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="PROCESSING_ENDED_SKIPPEDValue.Name" /></summary>
			public const string NAME = "PROCESSING_ENDED_SKIPPED";
			/// <summary>Constant value for <see cref="PROCESSING_ENDED_SKIPPEDValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.8";
			/// <summary>Constant value for <see cref="PROCESSING_ENDED_SKIPPEDValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="PROCESSING_ENDED_SKIPPEDValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;part occurrence has been skipped for processing on the piece of equipment.&#10;
";

			/// <inheritdoc />
			public string Name => NAME;
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => NORMATIVE_VERSION;
			
			/// <inheritdoc />
			public string DeprecatedVersion => DEPRECATED_VERSION;
			
			/// <inheritdoc />
			public string Summary => SUMMARY;
		}
		private PROCESSING_ENDED_REJECTEDValue _PROCESSING_ENDED_REJECTED;
		/// <inheritdoc cref="PROCESSING_ENDED_REJECTEDValue" path="/summary" />
		public PROCESSING_ENDED_REJECTEDValue PROCESSING_ENDED_REJECTED => _PROCESSING_ENDED_REJECTED ?? (_PROCESSING_ENDED_REJECTED = new PROCESSING_ENDED_REJECTEDValue());

		/// <summary>﻿part occurrence has been processed completely. However, the processing may have a problem.<br /><br /><br />
		/// Value for PartProcessingStateEnum.<br/>
		/// <br/>See also <seealso cref="PartProcessingStateEnum">PartProcessingStateEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.8">v1.8</see></item>
		/// </list>
		/// </remarks>

		public sealed class PROCESSING_ENDED_REJECTEDValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="PROCESSING_ENDED_REJECTEDValue.Name" /></summary>
			public const string NAME = "PROCESSING_ENDED_REJECTED";
			/// <summary>Constant value for <see cref="PROCESSING_ENDED_REJECTEDValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.8";
			/// <summary>Constant value for <see cref="PROCESSING_ENDED_REJECTEDValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="PROCESSING_ENDED_REJECTEDValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;part occurrence has been processed completely. However, the processing may have a problem.&#10;
";

			/// <inheritdoc />
			public string Name => NAME;
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => NORMATIVE_VERSION;
			
			/// <inheritdoc />
			public string DeprecatedVersion => DEPRECATED_VERSION;
			
			/// <inheritdoc />
			public string Summary => SUMMARY;
		}
		private WAITING_FOR_TRANSITValue _WAITING_FOR_TRANSIT;
		/// <inheritdoc cref="WAITING_FOR_TRANSITValue" path="/summary" />
		public WAITING_FOR_TRANSITValue WAITING_FOR_TRANSIT => _WAITING_FOR_TRANSIT ?? (_WAITING_FOR_TRANSIT = new WAITING_FOR_TRANSITValue());

		/// <summary>﻿part occurrence is waiting for transit.<br /><br /><br />
		/// Value for PartProcessingStateEnum.<br/>
		/// <br/>See also <seealso cref="PartProcessingStateEnum">PartProcessingStateEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.8">v1.8</see></item>
		/// </list>
		/// </remarks>

		public sealed class WAITING_FOR_TRANSITValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="WAITING_FOR_TRANSITValue.Name" /></summary>
			public const string NAME = "WAITING_FOR_TRANSIT";
			/// <summary>Constant value for <see cref="WAITING_FOR_TRANSITValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.8";
			/// <summary>Constant value for <see cref="WAITING_FOR_TRANSITValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="WAITING_FOR_TRANSITValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;part occurrence is waiting for transit.&#10;
";

			/// <inheritdoc />
			public string Name => NAME;
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => NORMATIVE_VERSION;
			
			/// <inheritdoc />
			public string DeprecatedVersion => DEPRECATED_VERSION;
			
			/// <inheritdoc />
			public string Summary => SUMMARY;
		}
		private IN_TRANSITValue _IN_TRANSIT;
		/// <inheritdoc cref="IN_TRANSITValue" path="/summary" />
		public IN_TRANSITValue IN_TRANSIT => _IN_TRANSIT ?? (_IN_TRANSIT = new IN_TRANSITValue());

		/// <summary>﻿part occurrence is being transported to its destination.<br /><br /><br />
		/// Value for PartProcessingStateEnum.<br/>
		/// <br/>See also <seealso cref="PartProcessingStateEnum">PartProcessingStateEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.8">v1.8</see></item>
		/// </list>
		/// </remarks>

		public sealed class IN_TRANSITValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="IN_TRANSITValue.Name" /></summary>
			public const string NAME = "IN_TRANSIT";
			/// <summary>Constant value for <see cref="IN_TRANSITValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.8";
			/// <summary>Constant value for <see cref="IN_TRANSITValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="IN_TRANSITValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;part occurrence is being transported to its destination.&#10;
";

			/// <inheritdoc />
			public string Name => NAME;
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => NORMATIVE_VERSION;
			
			/// <inheritdoc />
			public string DeprecatedVersion => DEPRECATED_VERSION;
			
			/// <inheritdoc />
			public string Summary => SUMMARY;
		}
		private TRANSIT_COMPLETEValue _TRANSIT_COMPLETE;
		/// <inheritdoc cref="TRANSIT_COMPLETEValue" path="/summary" />
		public TRANSIT_COMPLETEValue TRANSIT_COMPLETE => _TRANSIT_COMPLETE ?? (_TRANSIT_COMPLETE = new TRANSIT_COMPLETEValue());

		/// <summary>﻿part occurrence has been placed at its designated destination.<br /><br /><br />
		/// Value for PartProcessingStateEnum.<br/>
		/// <br/>See also <seealso cref="PartProcessingStateEnum">PartProcessingStateEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.8">v1.8</see></item>
		/// </list>
		/// </remarks>

		public sealed class TRANSIT_COMPLETEValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="TRANSIT_COMPLETEValue.Name" /></summary>
			public const string NAME = "TRANSIT_COMPLETE";
			/// <summary>Constant value for <see cref="TRANSIT_COMPLETEValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.8";
			/// <summary>Constant value for <see cref="TRANSIT_COMPLETEValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="TRANSIT_COMPLETEValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;part occurrence has been placed at its designated destination.&#10;
";

			/// <inheritdoc />
			public string Name => NAME;
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => NORMATIVE_VERSION;
			
			/// <inheritdoc />
			public string DeprecatedVersion => DEPRECATED_VERSION;
			
			/// <inheritdoc />
			public string Summary => SUMMARY;
		}
	}
}