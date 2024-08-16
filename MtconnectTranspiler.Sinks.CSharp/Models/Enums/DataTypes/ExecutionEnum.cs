using System;
using System.CodeDom.Compiler;using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;

namespace Mtconnect.DataTypes
{
	/// <summary>
	/// View in the MTConnect Model browser <seealso href="https://model.mtconnect.org/#Enumeration___19_0_3_45f01b9_1580378417664_592980_2878">model.mtconnect.org</seealso>
	﻿
	/// </summary>
	/// <remarks>
	/// <list type="bullet">
	/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
	/// </list>
	/// </remarks>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public enum ExecutionEnum
	{
		/// <summary>
		﻿/// <see cref="Component">Component</see> is ready to execute instructions.<br /><br />It is currently idle.<br/><br />

		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>
		READY,
		/// <summary>
		﻿/// <see cref="Component">Component</see> is actively executing an instruction.<br/><br />

		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>
		ACTIVE,
		/// <summary>
		﻿/// <see cref="Component">Component</see> suspends the execution of the program due to an external signal.<br /><br />Action is required to resume execution.<br/><br />

		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>
		INTERRUPTED,
		/// <summary>
		﻿/// motion of the active axes are commanded to stop at their current position.<br/><br />

		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.3">v1.3</see></item>
		/// </list>
		/// </remarks>
		FEED_HOLD,
		/// <summary>
		﻿/// <see cref="Component">Component</see> program is not <c>READY</c> to execute.<br/><br />

		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>
		STOPPED,
		/// <summary>
		﻿/// command from the program has intentionally interrupted execution.<br /><br />The <see cref="Component">Component</see> <b>MAY</b> have another state that indicates if the execution is interrupted or the execution ignores the interrupt instruction.<br/><br />

		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.4">v1.4</see></item>
		/// </list>
		/// </remarks>
		OPTIONAL_STOP,
		/// <summary>
		﻿/// command from the program has intentionally interrupted execution.<br /><br />Action is required to resume execution.<br/><br />

		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.3">v1.3</see></item>
		/// </list>
		/// </remarks>
		PROGRAM_STOPPED,
		/// <summary>
		﻿/// program completed execution.<br/><br />

		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.3">v1.3</see></item>
		/// </list>
		/// </remarks>
		PROGRAM_COMPLETED,
		/// <summary>
		﻿/// <see cref="Component">Component</see> suspends execution while a secondary operation executes.<br /><br />Execution resumes automatically once the secondary operation completes.<br/><br />

		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.5">v1.5</see></item>
		/// </list>
		/// </remarks>
		WAIT,
		/// <summary>
		﻿/// program has been intentionally optionally stopped using an M01 or similar code.<br /><br /><b>DEPRECATED</b> in <i>version 1.4</i> and replaced with <c>OPTIONAL_STOP</c>.<br/><br />

		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.3">v1.3</see></item>
		/// <item><b>Deprecated</b>: <see href="https://model.mtconnect.org/#_Version_1.4">v1.4</see></item>
		/// </list>
		/// </remarks>
		[Obsolete("Deprecated in v1.4 according to https://model.mtconnect.org/#_Version_1.4")]
		PROGRAM_OPTIONAL_STOP,
	}

	/// <summary>
	/// View in the MTConnect Model browser <seealso href="https://model.mtconnect.org/#Enumeration___19_0_3_45f01b9_1580378417664_592980_2878">model.mtconnect.org</seealso>
	﻿
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public sealed class ExecutionEnumMetaClass : IEnum
	{
		/// <inheritdoc />
		public string Name => "ExecutionEnum";
		
		/// <inheritdoc />
		public Type DataType => null;
		
		public Type Instance => typeof(ExecutionEnum);

		/// <inheritdoc />
		public string NormativeVersion => "1.0";
		
		/// <inheritdoc />
		public string DeprecatedVersion => "";
		
		/// <inheritdoc />
		public string Summary => @"";
		
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
		/// <summary>
		﻿/// <see cref="Component">Component</see> is ready to execute instructions.<br /><br />It is currently idle.<br/><br />

		/// </summary>
		public READYValue READY => _READY ?? (_READY = new READYValue());

		/// <summary>
		﻿/// <see cref="Component">Component</see> is ready to execute instructions.<br /><br />It is currently idle.<br/><br />

		/// </summary>
		public sealed class READYValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "READY";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.0";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"&#10;&#10;&#10;{{block(Component)}} is ready to execute instructions.

It is currently idle.&#10;
";
		}
		private ACTIVEValue _ACTIVE;
		/// <summary>
		﻿/// <see cref="Component">Component</see> is actively executing an instruction.<br/><br />

		/// </summary>
		public ACTIVEValue ACTIVE => _ACTIVE ?? (_ACTIVE = new ACTIVEValue());

		/// <summary>
		﻿/// <see cref="Component">Component</see> is actively executing an instruction.<br/><br />

		/// </summary>
		public sealed class ACTIVEValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "ACTIVE";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.0";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"&#10;&#10;&#10;{{block(Component)}} is actively executing an instruction.&#10;
";
		}
		private INTERRUPTEDValue _INTERRUPTED;
		/// <summary>
		﻿/// <see cref="Component">Component</see> suspends the execution of the program due to an external signal.<br /><br />Action is required to resume execution.<br/><br />

		/// </summary>
		public INTERRUPTEDValue INTERRUPTED => _INTERRUPTED ?? (_INTERRUPTED = new INTERRUPTEDValue());

		/// <summary>
		﻿/// <see cref="Component">Component</see> suspends the execution of the program due to an external signal.<br /><br />Action is required to resume execution.<br/><br />

		/// </summary>
		public sealed class INTERRUPTEDValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "INTERRUPTED";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.0";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"&#10;&#10;&#10;{{block(Component)}} suspends the execution of the program due to an external signal.

Action is required to resume execution.&#10;
";
		}
		private FEED_HOLDValue _FEED_HOLD;
		/// <summary>
		﻿/// motion of the active axes are commanded to stop at their current position.<br/><br />

		/// </summary>
		public FEED_HOLDValue FEED_HOLD => _FEED_HOLD ?? (_FEED_HOLD = new FEED_HOLDValue());

		/// <summary>
		﻿/// motion of the active axes are commanded to stop at their current position.<br/><br />

		/// </summary>
		public sealed class FEED_HOLDValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "FEED_HOLD";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.3";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"&#10;&#10;&#10;motion of the active axes are commanded to stop at their current position.&#10;
";
		}
		private STOPPEDValue _STOPPED;
		/// <summary>
		﻿/// <see cref="Component">Component</see> program is not <c>READY</c> to execute.<br/><br />

		/// </summary>
		public STOPPEDValue STOPPED => _STOPPED ?? (_STOPPED = new STOPPEDValue());

		/// <summary>
		﻿/// <see cref="Component">Component</see> program is not <c>READY</c> to execute.<br/><br />

		/// </summary>
		public sealed class STOPPEDValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "STOPPED";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.0";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"&#10;&#10;&#10;{{block(Component)}} program is not `READY` to execute.&#10;
";
		}
		private OPTIONAL_STOPValue _OPTIONAL_STOP;
		/// <summary>
		﻿/// command from the program has intentionally interrupted execution.<br /><br />The <see cref="Component">Component</see> <b>MAY</b> have another state that indicates if the execution is interrupted or the execution ignores the interrupt instruction.<br/><br />

		/// </summary>
		public OPTIONAL_STOPValue OPTIONAL_STOP => _OPTIONAL_STOP ?? (_OPTIONAL_STOP = new OPTIONAL_STOPValue());

		/// <summary>
		﻿/// command from the program has intentionally interrupted execution.<br /><br />The <see cref="Component">Component</see> <b>MAY</b> have another state that indicates if the execution is interrupted or the execution ignores the interrupt instruction.<br/><br />

		/// </summary>
		public sealed class OPTIONAL_STOPValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "OPTIONAL_STOP";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.4";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"&#10;&#10;&#10;command from the program has intentionally interrupted execution.

The {{block(Component)}} **MAY** have another state that indicates if the execution is interrupted or the execution ignores the interrupt instruction.&#10;
";
		}
		private PROGRAM_STOPPEDValue _PROGRAM_STOPPED;
		/// <summary>
		﻿/// command from the program has intentionally interrupted execution.<br /><br />Action is required to resume execution.<br/><br />

		/// </summary>
		public PROGRAM_STOPPEDValue PROGRAM_STOPPED => _PROGRAM_STOPPED ?? (_PROGRAM_STOPPED = new PROGRAM_STOPPEDValue());

		/// <summary>
		﻿/// command from the program has intentionally interrupted execution.<br /><br />Action is required to resume execution.<br/><br />

		/// </summary>
		public sealed class PROGRAM_STOPPEDValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "PROGRAM_STOPPED";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.3";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"&#10;&#10;&#10;command from the program has intentionally interrupted execution.

Action is required to resume execution.&#10;
";
		}
		private PROGRAM_COMPLETEDValue _PROGRAM_COMPLETED;
		/// <summary>
		﻿/// program completed execution.<br/><br />

		/// </summary>
		public PROGRAM_COMPLETEDValue PROGRAM_COMPLETED => _PROGRAM_COMPLETED ?? (_PROGRAM_COMPLETED = new PROGRAM_COMPLETEDValue());

		/// <summary>
		﻿/// program completed execution.<br/><br />

		/// </summary>
		public sealed class PROGRAM_COMPLETEDValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "PROGRAM_COMPLETED";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.3";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"&#10;&#10;&#10;program completed execution.&#10;
";
		}
		private WAITValue _WAIT;
		/// <summary>
		﻿/// <see cref="Component">Component</see> suspends execution while a secondary operation executes.<br /><br />Execution resumes automatically once the secondary operation completes.<br/><br />

		/// </summary>
		public WAITValue WAIT => _WAIT ?? (_WAIT = new WAITValue());

		/// <summary>
		﻿/// <see cref="Component">Component</see> suspends execution while a secondary operation executes.<br /><br />Execution resumes automatically once the secondary operation completes.<br/><br />

		/// </summary>
		public sealed class WAITValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "WAIT";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.5";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"&#10;&#10;&#10;{{block(Component)}} suspends execution while a secondary operation executes.

Execution resumes automatically once the secondary operation completes.&#10;
";
		}
		private PROGRAM_OPTIONAL_STOPValue _PROGRAM_OPTIONAL_STOP;
		/// <summary>
		﻿/// program has been intentionally optionally stopped using an M01 or similar code.<br /><br /><b>DEPRECATED</b> in <i>version 1.4</i> and replaced with <c>OPTIONAL_STOP</c>.<br/><br />

		/// </summary>
		public PROGRAM_OPTIONAL_STOPValue PROGRAM_OPTIONAL_STOP => _PROGRAM_OPTIONAL_STOP ?? (_PROGRAM_OPTIONAL_STOP = new PROGRAM_OPTIONAL_STOPValue());

		/// <summary>
		﻿/// program has been intentionally optionally stopped using an M01 or similar code.<br /><br /><b>DEPRECATED</b> in <i>version 1.4</i> and replaced with <c>OPTIONAL_STOP</c>.<br/><br />

		/// </summary>
		public sealed class PROGRAM_OPTIONAL_STOPValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "PROGRAM_OPTIONAL_STOP";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.3";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "1.4";
			
			/// <inheritdoc />
			public string Summary => @"&#10;&#10;&#10;program has been intentionally optionally stopped using an M01 or similar code.

**DEPRECATED** in *version 1.4* and replaced with `OPTIONAL_STOP`.&#10;
";
		}
	}
}