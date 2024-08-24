#pragma warning disable CS1574 // XML comment has cref attribute that could not be resolved
#pragma warning disable CS1584 // XML comment has syntactically incorrect cref attribute
#pragma warning disable CS0618 // Type or member is obsolete
using System;
using System.CodeDom.Compiler;using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;

namespace Mtconnect.DataTypes
{
	/// <summary>﻿
	/// <br/> Visit <seealso href="https://model.mtconnect.org/#Enumeration___19_0_3_45f01b9_1580378417664_592980_2878">model.mtconnect.org</seealso> for more information.
	/// </summary>
	/// <remarks>
	/// <list type="bullet">
	/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
	/// </list>
	/// </remarks>

	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public enum ExecutionEnum
	{
		/// <summary>﻿<see cref="Component">Component</see> is ready to execute instructions.<br /><br />It is currently idle.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		READY,
		/// <summary>﻿<see cref="Component">Component</see> is actively executing an instruction.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		ACTIVE,
		/// <summary>﻿<see cref="Component">Component</see> suspends the execution of the program due to an external signal.<br /><br />Action is required to resume execution.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		INTERRUPTED,
		/// <summary>﻿motion of the active axes are commanded to stop at their current position.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		FEED_HOLD,
		/// <summary>﻿<see cref="Component">Component</see> program is not <c>READY</c> to execute.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		STOPPED,
		/// <summary>﻿command from the program has intentionally interrupted execution.<br /><br />The <see cref="Component">Component</see> <b>MAY</b> have another state that indicates if the execution is interrupted or the execution ignores the interrupt instruction.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		OPTIONAL_STOP,
		/// <summary>﻿command from the program has intentionally interrupted execution.<br /><br />Action is required to resume execution.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		PROGRAM_STOPPED,
		/// <summary>﻿program completed execution.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		PROGRAM_COMPLETED,
		/// <summary>﻿<see cref="Component">Component</see> suspends execution while a secondary operation executes.<br /><br />Execution resumes automatically once the secondary operation completes.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		WAIT,
		/// <summary>﻿program has been intentionally optionally stopped using an M01 or similar code.<br /><br /><b>DEPRECATED</b> in <i>version 1.4</i> and replaced with <c>OPTIONAL_STOP</c>.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		PROGRAM_OPTIONAL_STOP,
	}

	/// <summary>﻿
	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Enumeration___19_0_3_45f01b9_1580378417664_592980_2878">model.mtconnect.org</seealso> for more information.
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public sealed class ExecutionEnumMetaClass : IEnum
	{
		/// <summary>Constant value for <see cref="ExecutionEnumMetaClass.ReferenceId" /></summary>
		public const string REFERENCE_ID = "_19_0_3_45f01b9_1580378417664_592980_2878";
		/// <summary>Constant value for <see cref="ExecutionEnumMetaClass.HelpUrl" /></summary>
		public const string HELP_URL = "https://model.mtconnect.org/#Enumeration___19_0_3_45f01b9_1580378417664_592980_2878";
		/// <summary>Constant value for <see cref="ExecutionEnumMetaClass.Name" /></summary>
		public const string NAME = "ExecutionEnum";
		/// <summary>Constant value for <see cref="ExecutionEnumMetaClass.NormativeVersion" /></summary>
		public const string NORMATIVE_VERSION = "1.0";
		/// <summary>Constant value for <see cref="ExecutionEnumMetaClass.DeprecatedVersion" /></summary>
		public const string DEPRECATED_VERSION = "";
		/// <summary>Constant value for <see cref="ExecutionEnumMetaClass.Summary" /></summary>
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
		public Type Instance => typeof(ExecutionEnum);

		/// <inheritdoc />
		public string NormativeVersion => NORMATIVE_VERSION;
		
		/// <inheritdoc />
		public string DeprecatedVersion => DEPRECATED_VERSION;
		
		/// <inheritdoc />
		public string Summary => SUMMARY;
		
		/// <inheritdoc />
		public IEnumInstance[] Values => new IEnumInstance[] {
		READY,
		ACTIVE,
		INTERRUPTED,
		FEED_HOLD,
		STOPPED,
		OPTIONAL_STOP,
		PROGRAM_STOPPED,
		PROGRAM_COMPLETED,
		WAIT,
		PROGRAM_OPTIONAL_STOP,
		};

		private READYValue _READY;
		/// <inheritdoc cref="READYValue" path="/summary" />
		public READYValue READY => _READY ?? (_READY = new READYValue());

		/// <summary>﻿<see cref="Component">Component</see> is ready to execute instructions.<br /><br />It is currently idle.<br /><br /><br />
		/// Value for ExecutionEnum.<br/>
		/// <br/>See also <seealso cref="ExecutionEnum">ExecutionEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		public sealed class READYValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="READYValue.Name" /></summary>
			public const string NAME = "READY";
			/// <summary>Constant value for <see cref="READYValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.0";
			/// <summary>Constant value for <see cref="READYValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="READYValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;{{block(Component)}} is ready to execute instructions.

It is currently idle.&#10;
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
		private ACTIVEValue _ACTIVE;
		/// <inheritdoc cref="ACTIVEValue" path="/summary" />
		public ACTIVEValue ACTIVE => _ACTIVE ?? (_ACTIVE = new ACTIVEValue());

		/// <summary>﻿<see cref="Component">Component</see> is actively executing an instruction.<br /><br /><br />
		/// Value for ExecutionEnum.<br/>
		/// <br/>See also <seealso cref="ExecutionEnum">ExecutionEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		public sealed class ACTIVEValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="ACTIVEValue.Name" /></summary>
			public const string NAME = "ACTIVE";
			/// <summary>Constant value for <see cref="ACTIVEValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.0";
			/// <summary>Constant value for <see cref="ACTIVEValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="ACTIVEValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;{{block(Component)}} is actively executing an instruction.&#10;
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
		private INTERRUPTEDValue _INTERRUPTED;
		/// <inheritdoc cref="INTERRUPTEDValue" path="/summary" />
		public INTERRUPTEDValue INTERRUPTED => _INTERRUPTED ?? (_INTERRUPTED = new INTERRUPTEDValue());

		/// <summary>﻿<see cref="Component">Component</see> suspends the execution of the program due to an external signal.<br /><br />Action is required to resume execution.<br /><br /><br />
		/// Value for ExecutionEnum.<br/>
		/// <br/>See also <seealso cref="ExecutionEnum">ExecutionEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		public sealed class INTERRUPTEDValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="INTERRUPTEDValue.Name" /></summary>
			public const string NAME = "INTERRUPTED";
			/// <summary>Constant value for <see cref="INTERRUPTEDValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.0";
			/// <summary>Constant value for <see cref="INTERRUPTEDValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="INTERRUPTEDValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;{{block(Component)}} suspends the execution of the program due to an external signal.

Action is required to resume execution.&#10;
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
		private FEED_HOLDValue _FEED_HOLD;
		/// <inheritdoc cref="FEED_HOLDValue" path="/summary" />
		public FEED_HOLDValue FEED_HOLD => _FEED_HOLD ?? (_FEED_HOLD = new FEED_HOLDValue());

		/// <summary>﻿motion of the active axes are commanded to stop at their current position.<br /><br /><br />
		/// Value for ExecutionEnum.<br/>
		/// <br/>See also <seealso cref="ExecutionEnum">ExecutionEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		public sealed class FEED_HOLDValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="FEED_HOLDValue.Name" /></summary>
			public const string NAME = "FEED_HOLD";
			/// <summary>Constant value for <see cref="FEED_HOLDValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.3";
			/// <summary>Constant value for <see cref="FEED_HOLDValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="FEED_HOLDValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;motion of the active axes are commanded to stop at their current position.&#10;
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
		private STOPPEDValue _STOPPED;
		/// <inheritdoc cref="STOPPEDValue" path="/summary" />
		public STOPPEDValue STOPPED => _STOPPED ?? (_STOPPED = new STOPPEDValue());

		/// <summary>﻿<see cref="Component">Component</see> program is not <c>READY</c> to execute.<br /><br /><br />
		/// Value for ExecutionEnum.<br/>
		/// <br/>See also <seealso cref="ExecutionEnum">ExecutionEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		public sealed class STOPPEDValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="STOPPEDValue.Name" /></summary>
			public const string NAME = "STOPPED";
			/// <summary>Constant value for <see cref="STOPPEDValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.0";
			/// <summary>Constant value for <see cref="STOPPEDValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="STOPPEDValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;{{block(Component)}} program is not `READY` to execute.&#10;
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
		private OPTIONAL_STOPValue _OPTIONAL_STOP;
		/// <inheritdoc cref="OPTIONAL_STOPValue" path="/summary" />
		public OPTIONAL_STOPValue OPTIONAL_STOP => _OPTIONAL_STOP ?? (_OPTIONAL_STOP = new OPTIONAL_STOPValue());

		/// <summary>﻿command from the program has intentionally interrupted execution.<br /><br />The <see cref="Component">Component</see> <b>MAY</b> have another state that indicates if the execution is interrupted or the execution ignores the interrupt instruction.<br /><br /><br />
		/// Value for ExecutionEnum.<br/>
		/// <br/>See also <seealso cref="ExecutionEnum">ExecutionEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		public sealed class OPTIONAL_STOPValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="OPTIONAL_STOPValue.Name" /></summary>
			public const string NAME = "OPTIONAL_STOP";
			/// <summary>Constant value for <see cref="OPTIONAL_STOPValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.4";
			/// <summary>Constant value for <see cref="OPTIONAL_STOPValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="OPTIONAL_STOPValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;command from the program has intentionally interrupted execution.

The {{block(Component)}} **MAY** have another state that indicates if the execution is interrupted or the execution ignores the interrupt instruction.&#10;
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
		private PROGRAM_STOPPEDValue _PROGRAM_STOPPED;
		/// <inheritdoc cref="PROGRAM_STOPPEDValue" path="/summary" />
		public PROGRAM_STOPPEDValue PROGRAM_STOPPED => _PROGRAM_STOPPED ?? (_PROGRAM_STOPPED = new PROGRAM_STOPPEDValue());

		/// <summary>﻿command from the program has intentionally interrupted execution.<br /><br />Action is required to resume execution.<br /><br /><br />
		/// Value for ExecutionEnum.<br/>
		/// <br/>See also <seealso cref="ExecutionEnum">ExecutionEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		public sealed class PROGRAM_STOPPEDValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="PROGRAM_STOPPEDValue.Name" /></summary>
			public const string NAME = "PROGRAM_STOPPED";
			/// <summary>Constant value for <see cref="PROGRAM_STOPPEDValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.3";
			/// <summary>Constant value for <see cref="PROGRAM_STOPPEDValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="PROGRAM_STOPPEDValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;command from the program has intentionally interrupted execution.

Action is required to resume execution.&#10;
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
		private PROGRAM_COMPLETEDValue _PROGRAM_COMPLETED;
		/// <inheritdoc cref="PROGRAM_COMPLETEDValue" path="/summary" />
		public PROGRAM_COMPLETEDValue PROGRAM_COMPLETED => _PROGRAM_COMPLETED ?? (_PROGRAM_COMPLETED = new PROGRAM_COMPLETEDValue());

		/// <summary>﻿program completed execution.<br /><br /><br />
		/// Value for ExecutionEnum.<br/>
		/// <br/>See also <seealso cref="ExecutionEnum">ExecutionEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		public sealed class PROGRAM_COMPLETEDValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="PROGRAM_COMPLETEDValue.Name" /></summary>
			public const string NAME = "PROGRAM_COMPLETED";
			/// <summary>Constant value for <see cref="PROGRAM_COMPLETEDValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.3";
			/// <summary>Constant value for <see cref="PROGRAM_COMPLETEDValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="PROGRAM_COMPLETEDValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;program completed execution.&#10;
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
		private WAITValue _WAIT;
		/// <inheritdoc cref="WAITValue" path="/summary" />
		public WAITValue WAIT => _WAIT ?? (_WAIT = new WAITValue());

		/// <summary>﻿<see cref="Component">Component</see> suspends execution while a secondary operation executes.<br /><br />Execution resumes automatically once the secondary operation completes.<br /><br /><br />
		/// Value for ExecutionEnum.<br/>
		/// <br/>See also <seealso cref="ExecutionEnum">ExecutionEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		public sealed class WAITValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="WAITValue.Name" /></summary>
			public const string NAME = "WAIT";
			/// <summary>Constant value for <see cref="WAITValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.5";
			/// <summary>Constant value for <see cref="WAITValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="WAITValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;{{block(Component)}} suspends execution while a secondary operation executes.

Execution resumes automatically once the secondary operation completes.&#10;
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
		private PROGRAM_OPTIONAL_STOPValue _PROGRAM_OPTIONAL_STOP;
		/// <inheritdoc cref="PROGRAM_OPTIONAL_STOPValue" path="/summary" />
		public PROGRAM_OPTIONAL_STOPValue PROGRAM_OPTIONAL_STOP => _PROGRAM_OPTIONAL_STOP ?? (_PROGRAM_OPTIONAL_STOP = new PROGRAM_OPTIONAL_STOPValue());

		/// <summary>﻿program has been intentionally optionally stopped using an M01 or similar code.<br /><br /><b>DEPRECATED</b> in <i>version 1.4</i> and replaced with <c>OPTIONAL_STOP</c>.<br /><br /><br />
		/// Value for ExecutionEnum.<br/>
		/// <br/>See also <seealso cref="ExecutionEnum">ExecutionEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		public sealed class PROGRAM_OPTIONAL_STOPValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="PROGRAM_OPTIONAL_STOPValue.Name" /></summary>
			public const string NAME = "PROGRAM_OPTIONAL_STOP";
			/// <summary>Constant value for <see cref="PROGRAM_OPTIONAL_STOPValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.3";
			/// <summary>Constant value for <see cref="PROGRAM_OPTIONAL_STOPValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "1.4";
			/// <summary>Constant value for <see cref="PROGRAM_OPTIONAL_STOPValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;program has been intentionally optionally stopped using an M01 or similar code.

**DEPRECATED** in *version 1.4* and replaced with `OPTIONAL_STOP`.&#10;
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