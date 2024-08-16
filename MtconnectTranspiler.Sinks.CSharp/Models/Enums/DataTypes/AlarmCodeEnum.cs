using System;
using System.CodeDom.Compiler;using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;

namespace Mtconnect.DataTypes
{
	/// <summary>
	/// View in the MTConnect Model browser <seealso href="https://model.mtconnect.org/#Enumeration___19_0_3_68e0225_1643968895333_107274_240">model.mtconnect.org</seealso>
	﻿
	/// </summary>
	/// <remarks>
	/// <list type="bullet">
	/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
	/// <item><b>Deprecated</b>: <see href="https://model.mtconnect.org/#_Version_1.1">v1.1</see></item>
	/// </list>
	/// </remarks>
	[Obsolete("Deprecated in v1.1 according to https://model.mtconnect.org/#_Version_1.1")]
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public enum AlarmCodeEnum
	{
		/// <summary>
		﻿/// spindle crashed.<br/><br />

		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// <item><b>Deprecated</b>: <see href="https://model.mtconnect.org/#_Version_1.1">v1.1</see></item>
		/// </list>
		/// </remarks>
		[Obsolete("Deprecated in v1.1 according to https://model.mtconnect.org/#_Version_1.1")]
		CRASH,
		/// <summary>
		﻿/// component jammed.<br/><br />

		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// <item><b>Deprecated</b>: <see href="https://model.mtconnect.org/#_Version_1.1">v1.1</see></item>
		/// </list>
		/// </remarks>
		[Obsolete("Deprecated in v1.1 according to https://model.mtconnect.org/#_Version_1.1")]
		JAM,
		/// <summary>
		﻿/// component failed.<br/><br />

		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// <item><b>Deprecated</b>: <see href="https://model.mtconnect.org/#_Version_1.1">v1.1</see></item>
		/// </list>
		/// </remarks>
		[Obsolete("Deprecated in v1.1 according to https://model.mtconnect.org/#_Version_1.1")]
		FAILURE,
		/// <summary>
		﻿/// fault occurred on the component.<br/><br />

		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// <item><b>Deprecated</b>: <see href="https://model.mtconnect.org/#_Version_1.1">v1.1</see></item>
		/// </list>
		/// </remarks>
		[Obsolete("Deprecated in v1.1 according to https://model.mtconnect.org/#_Version_1.1")]
		FAULT,
		/// <summary>
		﻿/// component has stalled and cannot move.<br/><br />

		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// <item><b>Deprecated</b>: <see href="https://model.mtconnect.org/#_Version_1.1">v1.1</see></item>
		/// </list>
		/// </remarks>
		[Obsolete("Deprecated in v1.1 according to https://model.mtconnect.org/#_Version_1.1")]
		STALLED,
		/// <summary>
		﻿/// component is overloaded.<br/><br />

		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// <item><b>Deprecated</b>: <see href="https://model.mtconnect.org/#_Version_1.1">v1.1</see></item>
		/// </list>
		/// </remarks>
		[Obsolete("Deprecated in v1.1 according to https://model.mtconnect.org/#_Version_1.1")]
		OVERLOAD,
		/// <summary>
		﻿/// ESTOP button was pressed.<br/><br />

		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// <item><b>Deprecated</b>: <see href="https://model.mtconnect.org/#_Version_1.1">v1.1</see></item>
		/// </list>
		/// </remarks>
		[Obsolete("Deprecated in v1.1 according to https://model.mtconnect.org/#_Version_1.1")]
		ESTOP,
		/// <summary>
		﻿/// problem with the material.<br/><br />

		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// <item><b>Deprecated</b>: <see href="https://model.mtconnect.org/#_Version_1.1">v1.1</see></item>
		/// </list>
		/// </remarks>
		[Obsolete("Deprecated in v1.1 according to https://model.mtconnect.org/#_Version_1.1")]
		MATERIAL,
		/// <summary>
		﻿/// system message.<br/><br />

		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// <item><b>Deprecated</b>: <see href="https://model.mtconnect.org/#_Version_1.1">v1.1</see></item>
		/// </list>
		/// </remarks>
		[Obsolete("Deprecated in v1.1 according to https://model.mtconnect.org/#_Version_1.1")]
		MESSAGE,
		/// <summary>
		﻿/// alarm is not in any of the above categories.<br/><br />

		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// <item><b>Deprecated</b>: <see href="https://model.mtconnect.org/#_Version_1.1">v1.1</see></item>
		/// </list>
		/// </remarks>
		[Obsolete("Deprecated in v1.1 according to https://model.mtconnect.org/#_Version_1.1")]
		OTHER,
	}

	/// <summary>
	/// View in the MTConnect Model browser <seealso href="https://model.mtconnect.org/#Enumeration___19_0_3_68e0225_1643968895333_107274_240">model.mtconnect.org</seealso>
	﻿
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public sealed class AlarmCodeEnumMetaClass : IEnum
	{
		/// <inheritdoc />
		public string Name => "AlarmCodeEnum";
		
		/// <inheritdoc />
		public Type DataType => null;
		
		public Type Instance => typeof(AlarmCodeEnum);

		/// <inheritdoc />
		public string NormativeVersion => "1.0";
		
		/// <inheritdoc />
		public string DeprecatedVersion => "1.1";
		
		/// <inheritdoc />
		public string Summary => @"";
		
		/// <inheritdoc />
		public IEnumInstance[] Values => new IEnumInstance[] {
		CRASH,
		JAM,
		FAILURE,
		FAULT,
		STALLED,
		OVERLOAD,
		ESTOP,
		MATERIAL,
		MESSAGE,
		OTHER,
		};

		private CRASHValue _CRASH;
		/// <summary>
		﻿/// spindle crashed.<br/><br />

		/// </summary>
		public CRASHValue CRASH => _CRASH ?? (_CRASH = new CRASHValue());

		/// <summary>
		﻿/// spindle crashed.<br/><br />

		/// </summary>
		public sealed class CRASHValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "CRASH";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.0";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "1.1";
			
			/// <inheritdoc />
			public string Summary => @"&#10;&#10;&#10;spindle crashed.&#10;
";
		}
		private JAMValue _JAM;
		/// <summary>
		﻿/// component jammed.<br/><br />

		/// </summary>
		public JAMValue JAM => _JAM ?? (_JAM = new JAMValue());

		/// <summary>
		﻿/// component jammed.<br/><br />

		/// </summary>
		public sealed class JAMValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "JAM";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.0";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "1.1";
			
			/// <inheritdoc />
			public string Summary => @"&#10;&#10;&#10;component jammed.&#10;
";
		}
		private FAILUREValue _FAILURE;
		/// <summary>
		﻿/// component failed.<br/><br />

		/// </summary>
		public FAILUREValue FAILURE => _FAILURE ?? (_FAILURE = new FAILUREValue());

		/// <summary>
		﻿/// component failed.<br/><br />

		/// </summary>
		public sealed class FAILUREValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "FAILURE";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.0";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "1.1";
			
			/// <inheritdoc />
			public string Summary => @"&#10;&#10;&#10;component failed.&#10;
";
		}
		private FAULTValue _FAULT;
		/// <summary>
		﻿/// fault occurred on the component.<br/><br />

		/// </summary>
		public FAULTValue FAULT => _FAULT ?? (_FAULT = new FAULTValue());

		/// <summary>
		﻿/// fault occurred on the component.<br/><br />

		/// </summary>
		public sealed class FAULTValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "FAULT";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.0";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "1.1";
			
			/// <inheritdoc />
			public string Summary => @"&#10;&#10;&#10;fault occurred on the component.&#10;
";
		}
		private STALLEDValue _STALLED;
		/// <summary>
		﻿/// component has stalled and cannot move.<br/><br />

		/// </summary>
		public STALLEDValue STALLED => _STALLED ?? (_STALLED = new STALLEDValue());

		/// <summary>
		﻿/// component has stalled and cannot move.<br/><br />

		/// </summary>
		public sealed class STALLEDValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "STALLED";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.0";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "1.1";
			
			/// <inheritdoc />
			public string Summary => @"&#10;&#10;&#10;component has stalled and cannot move.&#10;
";
		}
		private OVERLOADValue _OVERLOAD;
		/// <summary>
		﻿/// component is overloaded.<br/><br />

		/// </summary>
		public OVERLOADValue OVERLOAD => _OVERLOAD ?? (_OVERLOAD = new OVERLOADValue());

		/// <summary>
		﻿/// component is overloaded.<br/><br />

		/// </summary>
		public sealed class OVERLOADValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "OVERLOAD";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.0";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "1.1";
			
			/// <inheritdoc />
			public string Summary => @"&#10;&#10;&#10;component is overloaded.&#10;
";
		}
		private ESTOPValue _ESTOP;
		/// <summary>
		﻿/// ESTOP button was pressed.<br/><br />

		/// </summary>
		public ESTOPValue ESTOP => _ESTOP ?? (_ESTOP = new ESTOPValue());

		/// <summary>
		﻿/// ESTOP button was pressed.<br/><br />

		/// </summary>
		public sealed class ESTOPValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "ESTOP";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.0";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "1.1";
			
			/// <inheritdoc />
			public string Summary => @"&#10;&#10;&#10;ESTOP button was pressed.&#10;
";
		}
		private MATERIALValue _MATERIAL;
		/// <summary>
		﻿/// problem with the material.<br/><br />

		/// </summary>
		public MATERIALValue MATERIAL => _MATERIAL ?? (_MATERIAL = new MATERIALValue());

		/// <summary>
		﻿/// problem with the material.<br/><br />

		/// </summary>
		public sealed class MATERIALValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "MATERIAL";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.0";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "1.1";
			
			/// <inheritdoc />
			public string Summary => @"&#10;&#10;&#10;problem with the material.&#10;
";
		}
		private MESSAGEValue _MESSAGE;
		/// <summary>
		﻿/// system message.<br/><br />

		/// </summary>
		public MESSAGEValue MESSAGE => _MESSAGE ?? (_MESSAGE = new MESSAGEValue());

		/// <summary>
		﻿/// system message.<br/><br />

		/// </summary>
		public sealed class MESSAGEValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "MESSAGE";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.0";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "1.1";
			
			/// <inheritdoc />
			public string Summary => @"&#10;&#10;&#10;system message.&#10;
";
		}
		private OTHERValue _OTHER;
		/// <summary>
		﻿/// alarm is not in any of the above categories.<br/><br />

		/// </summary>
		public OTHERValue OTHER => _OTHER ?? (_OTHER = new OTHERValue());

		/// <summary>
		﻿/// alarm is not in any of the above categories.<br/><br />

		/// </summary>
		public sealed class OTHERValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "OTHER";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.0";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "1.1";
			
			/// <inheritdoc />
			public string Summary => @"&#10;&#10;&#10;alarm is not in any of the above categories.&#10;
";
		}
	}
}