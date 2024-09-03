#pragma warning disable CS1574 // XML comment has cref attribute that could not be resolved
#pragma warning disable CS1584 // XML comment has syntactically incorrect cref attribute
#pragma warning disable CS0618 // Type or member is obsolete
using System;
using System.CodeDom.Compiler;using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;

namespace Mtconnect.DataTypes
{
	/// <summary>﻿
	/// <br/> Visit <seealso href="https://model.mtconnect.org/#Enumeration___19_0_3_68e0225_1643968895333_107274_240">model.mtconnect.org</seealso> for more information.
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
		/// <summary>﻿spindle crashed.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// <item><b>Deprecated</b>: <see href="https://model.mtconnect.org/#_Version_1.1">v1.1</see></item>
		/// </list>
		/// </remarks>
		[Obsolete("Deprecated in v1.1 according to https://model.mtconnect.org/#_Version_1.1")]

		CRASH,
		/// <summary>﻿component jammed.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// <item><b>Deprecated</b>: <see href="https://model.mtconnect.org/#_Version_1.1">v1.1</see></item>
		/// </list>
		/// </remarks>
		[Obsolete("Deprecated in v1.1 according to https://model.mtconnect.org/#_Version_1.1")]

		JAM,
		/// <summary>﻿component failed.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// <item><b>Deprecated</b>: <see href="https://model.mtconnect.org/#_Version_1.1">v1.1</see></item>
		/// </list>
		/// </remarks>
		[Obsolete("Deprecated in v1.1 according to https://model.mtconnect.org/#_Version_1.1")]

		FAILURE,
		/// <summary>﻿fault occurred on the component.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// <item><b>Deprecated</b>: <see href="https://model.mtconnect.org/#_Version_1.1">v1.1</see></item>
		/// </list>
		/// </remarks>
		[Obsolete("Deprecated in v1.1 according to https://model.mtconnect.org/#_Version_1.1")]

		FAULT,
		/// <summary>﻿component has stalled and cannot move.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// <item><b>Deprecated</b>: <see href="https://model.mtconnect.org/#_Version_1.1">v1.1</see></item>
		/// </list>
		/// </remarks>
		[Obsolete("Deprecated in v1.1 according to https://model.mtconnect.org/#_Version_1.1")]

		STALLED,
		/// <summary>﻿component is overloaded.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// <item><b>Deprecated</b>: <see href="https://model.mtconnect.org/#_Version_1.1">v1.1</see></item>
		/// </list>
		/// </remarks>
		[Obsolete("Deprecated in v1.1 according to https://model.mtconnect.org/#_Version_1.1")]

		OVERLOAD,
		/// <summary>﻿ESTOP button was pressed.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// <item><b>Deprecated</b>: <see href="https://model.mtconnect.org/#_Version_1.1">v1.1</see></item>
		/// </list>
		/// </remarks>
		[Obsolete("Deprecated in v1.1 according to https://model.mtconnect.org/#_Version_1.1")]

		ESTOP,
		/// <summary>﻿problem with the material.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// <item><b>Deprecated</b>: <see href="https://model.mtconnect.org/#_Version_1.1">v1.1</see></item>
		/// </list>
		/// </remarks>
		[Obsolete("Deprecated in v1.1 according to https://model.mtconnect.org/#_Version_1.1")]

		MATERIAL,
		/// <summary>﻿system message.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// <item><b>Deprecated</b>: <see href="https://model.mtconnect.org/#_Version_1.1">v1.1</see></item>
		/// </list>
		/// </remarks>
		[Obsolete("Deprecated in v1.1 according to https://model.mtconnect.org/#_Version_1.1")]

		MESSAGE,
		/// <summary>﻿alarm is not in any of the above categories.<br /><br /><br />
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

	/// <summary>﻿
	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Enumeration___19_0_3_68e0225_1643968895333_107274_240">model.mtconnect.org</seealso> for more information.
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public sealed class AlarmCodeEnumMetaClass : IEnum
	{
		/// <summary>Constant value for <see cref="AlarmCodeEnumMetaClass.ReferenceId" /></summary>
		public const string REFERENCE_ID = "_19_0_3_68e0225_1643968895333_107274_240";
		/// <summary>Constant value for <see cref="AlarmCodeEnumMetaClass.HelpUrl" /></summary>
		public const string HELP_URL = "https://model.mtconnect.org/#Enumeration___19_0_3_68e0225_1643968895333_107274_240";
		/// <summary>Constant value for <see cref="AlarmCodeEnumMetaClass.Name" /></summary>
		public const string NAME = "AlarmCodeEnum";
		/// <summary>Constant value for <see cref="AlarmCodeEnumMetaClass.NormativeVersion" /></summary>
		public const string NORMATIVE_VERSION = "1.0";
		/// <summary>Constant value for <see cref="AlarmCodeEnumMetaClass.DeprecatedVersion" /></summary>
		public const string DEPRECATED_VERSION = "1.1";
		/// <summary>Constant value for <see cref="AlarmCodeEnumMetaClass.Summary" /></summary>
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
		public Type Instance => typeof(AlarmCodeEnum);

		/// <inheritdoc />
		public string NormativeVersion => NORMATIVE_VERSION;
		
		/// <inheritdoc />
		public string DeprecatedVersion => DEPRECATED_VERSION;
		
		/// <inheritdoc />
		public string Summary => SUMMARY;
		
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
		/// <inheritdoc cref="CRASHValue" path="/summary" />
		public CRASHValue CRASH => _CRASH ?? (_CRASH = new CRASHValue());

		/// <summary>﻿spindle crashed.<br /><br /><br />
		/// Value for AlarmCodeEnum.<br/>
		/// <br/>See also <seealso cref="AlarmCodeEnum">AlarmCodeEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// <item><b>Deprecated</b>: <see href="https://model.mtconnect.org/#_Version_1.1">v1.1</see></item>
		/// </list>
		/// </remarks>
		[Obsolete("Deprecated in v1.1 according to https://model.mtconnect.org/#_Version_1.1")]

		public sealed class CRASHValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="CRASHValue.Name" /></summary>
			public const string NAME = "CRASH";
			/// <summary>Constant value for <see cref="CRASHValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.0";
			/// <summary>Constant value for <see cref="CRASHValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "1.1";
			/// <summary>Constant value for <see cref="CRASHValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;spindle crashed.&#10;
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
		private JAMValue _JAM;
		/// <inheritdoc cref="JAMValue" path="/summary" />
		public JAMValue JAM => _JAM ?? (_JAM = new JAMValue());

		/// <summary>﻿component jammed.<br /><br /><br />
		/// Value for AlarmCodeEnum.<br/>
		/// <br/>See also <seealso cref="AlarmCodeEnum">AlarmCodeEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// <item><b>Deprecated</b>: <see href="https://model.mtconnect.org/#_Version_1.1">v1.1</see></item>
		/// </list>
		/// </remarks>
		[Obsolete("Deprecated in v1.1 according to https://model.mtconnect.org/#_Version_1.1")]

		public sealed class JAMValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="JAMValue.Name" /></summary>
			public const string NAME = "JAM";
			/// <summary>Constant value for <see cref="JAMValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.0";
			/// <summary>Constant value for <see cref="JAMValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "1.1";
			/// <summary>Constant value for <see cref="JAMValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;component jammed.&#10;
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
		private FAILUREValue _FAILURE;
		/// <inheritdoc cref="FAILUREValue" path="/summary" />
		public FAILUREValue FAILURE => _FAILURE ?? (_FAILURE = new FAILUREValue());

		/// <summary>﻿component failed.<br /><br /><br />
		/// Value for AlarmCodeEnum.<br/>
		/// <br/>See also <seealso cref="AlarmCodeEnum">AlarmCodeEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// <item><b>Deprecated</b>: <see href="https://model.mtconnect.org/#_Version_1.1">v1.1</see></item>
		/// </list>
		/// </remarks>
		[Obsolete("Deprecated in v1.1 according to https://model.mtconnect.org/#_Version_1.1")]

		public sealed class FAILUREValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="FAILUREValue.Name" /></summary>
			public const string NAME = "FAILURE";
			/// <summary>Constant value for <see cref="FAILUREValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.0";
			/// <summary>Constant value for <see cref="FAILUREValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "1.1";
			/// <summary>Constant value for <see cref="FAILUREValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;component failed.&#10;
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
		private FAULTValue _FAULT;
		/// <inheritdoc cref="FAULTValue" path="/summary" />
		public FAULTValue FAULT => _FAULT ?? (_FAULT = new FAULTValue());

		/// <summary>﻿fault occurred on the component.<br /><br /><br />
		/// Value for AlarmCodeEnum.<br/>
		/// <br/>See also <seealso cref="AlarmCodeEnum">AlarmCodeEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// <item><b>Deprecated</b>: <see href="https://model.mtconnect.org/#_Version_1.1">v1.1</see></item>
		/// </list>
		/// </remarks>
		[Obsolete("Deprecated in v1.1 according to https://model.mtconnect.org/#_Version_1.1")]

		public sealed class FAULTValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="FAULTValue.Name" /></summary>
			public const string NAME = "FAULT";
			/// <summary>Constant value for <see cref="FAULTValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.0";
			/// <summary>Constant value for <see cref="FAULTValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "1.1";
			/// <summary>Constant value for <see cref="FAULTValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;fault occurred on the component.&#10;
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
		private STALLEDValue _STALLED;
		/// <inheritdoc cref="STALLEDValue" path="/summary" />
		public STALLEDValue STALLED => _STALLED ?? (_STALLED = new STALLEDValue());

		/// <summary>﻿component has stalled and cannot move.<br /><br /><br />
		/// Value for AlarmCodeEnum.<br/>
		/// <br/>See also <seealso cref="AlarmCodeEnum">AlarmCodeEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// <item><b>Deprecated</b>: <see href="https://model.mtconnect.org/#_Version_1.1">v1.1</see></item>
		/// </list>
		/// </remarks>
		[Obsolete("Deprecated in v1.1 according to https://model.mtconnect.org/#_Version_1.1")]

		public sealed class STALLEDValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="STALLEDValue.Name" /></summary>
			public const string NAME = "STALLED";
			/// <summary>Constant value for <see cref="STALLEDValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.0";
			/// <summary>Constant value for <see cref="STALLEDValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "1.1";
			/// <summary>Constant value for <see cref="STALLEDValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;component has stalled and cannot move.&#10;
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
		private OVERLOADValue _OVERLOAD;
		/// <inheritdoc cref="OVERLOADValue" path="/summary" />
		public OVERLOADValue OVERLOAD => _OVERLOAD ?? (_OVERLOAD = new OVERLOADValue());

		/// <summary>﻿component is overloaded.<br /><br /><br />
		/// Value for AlarmCodeEnum.<br/>
		/// <br/>See also <seealso cref="AlarmCodeEnum">AlarmCodeEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// <item><b>Deprecated</b>: <see href="https://model.mtconnect.org/#_Version_1.1">v1.1</see></item>
		/// </list>
		/// </remarks>
		[Obsolete("Deprecated in v1.1 according to https://model.mtconnect.org/#_Version_1.1")]

		public sealed class OVERLOADValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="OVERLOADValue.Name" /></summary>
			public const string NAME = "OVERLOAD";
			/// <summary>Constant value for <see cref="OVERLOADValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.0";
			/// <summary>Constant value for <see cref="OVERLOADValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "1.1";
			/// <summary>Constant value for <see cref="OVERLOADValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;component is overloaded.&#10;
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
		private ESTOPValue _ESTOP;
		/// <inheritdoc cref="ESTOPValue" path="/summary" />
		public ESTOPValue ESTOP => _ESTOP ?? (_ESTOP = new ESTOPValue());

		/// <summary>﻿ESTOP button was pressed.<br /><br /><br />
		/// Value for AlarmCodeEnum.<br/>
		/// <br/>See also <seealso cref="AlarmCodeEnum">AlarmCodeEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// <item><b>Deprecated</b>: <see href="https://model.mtconnect.org/#_Version_1.1">v1.1</see></item>
		/// </list>
		/// </remarks>
		[Obsolete("Deprecated in v1.1 according to https://model.mtconnect.org/#_Version_1.1")]

		public sealed class ESTOPValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="ESTOPValue.Name" /></summary>
			public const string NAME = "ESTOP";
			/// <summary>Constant value for <see cref="ESTOPValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.0";
			/// <summary>Constant value for <see cref="ESTOPValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "1.1";
			/// <summary>Constant value for <see cref="ESTOPValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;ESTOP button was pressed.&#10;
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
		private MATERIALValue _MATERIAL;
		/// <inheritdoc cref="MATERIALValue" path="/summary" />
		public MATERIALValue MATERIAL => _MATERIAL ?? (_MATERIAL = new MATERIALValue());

		/// <summary>﻿problem with the material.<br /><br /><br />
		/// Value for AlarmCodeEnum.<br/>
		/// <br/>See also <seealso cref="AlarmCodeEnum">AlarmCodeEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// <item><b>Deprecated</b>: <see href="https://model.mtconnect.org/#_Version_1.1">v1.1</see></item>
		/// </list>
		/// </remarks>
		[Obsolete("Deprecated in v1.1 according to https://model.mtconnect.org/#_Version_1.1")]

		public sealed class MATERIALValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="MATERIALValue.Name" /></summary>
			public const string NAME = "MATERIAL";
			/// <summary>Constant value for <see cref="MATERIALValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.0";
			/// <summary>Constant value for <see cref="MATERIALValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "1.1";
			/// <summary>Constant value for <see cref="MATERIALValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;problem with the material.&#10;
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
		private MESSAGEValue _MESSAGE;
		/// <inheritdoc cref="MESSAGEValue" path="/summary" />
		public MESSAGEValue MESSAGE => _MESSAGE ?? (_MESSAGE = new MESSAGEValue());

		/// <summary>﻿system message.<br /><br /><br />
		/// Value for AlarmCodeEnum.<br/>
		/// <br/>See also <seealso cref="AlarmCodeEnum">AlarmCodeEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// <item><b>Deprecated</b>: <see href="https://model.mtconnect.org/#_Version_1.1">v1.1</see></item>
		/// </list>
		/// </remarks>
		[Obsolete("Deprecated in v1.1 according to https://model.mtconnect.org/#_Version_1.1")]

		public sealed class MESSAGEValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="MESSAGEValue.Name" /></summary>
			public const string NAME = "MESSAGE";
			/// <summary>Constant value for <see cref="MESSAGEValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.0";
			/// <summary>Constant value for <see cref="MESSAGEValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "1.1";
			/// <summary>Constant value for <see cref="MESSAGEValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;system message.&#10;
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
		private OTHERValue _OTHER;
		/// <inheritdoc cref="OTHERValue" path="/summary" />
		public OTHERValue OTHER => _OTHER ?? (_OTHER = new OTHERValue());

		/// <summary>﻿alarm is not in any of the above categories.<br /><br /><br />
		/// Value for AlarmCodeEnum.<br/>
		/// <br/>See also <seealso cref="AlarmCodeEnum">AlarmCodeEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// <item><b>Deprecated</b>: <see href="https://model.mtconnect.org/#_Version_1.1">v1.1</see></item>
		/// </list>
		/// </remarks>
		[Obsolete("Deprecated in v1.1 according to https://model.mtconnect.org/#_Version_1.1")]

		public sealed class OTHERValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="OTHERValue.Name" /></summary>
			public const string NAME = "OTHER";
			/// <summary>Constant value for <see cref="OTHERValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.0";
			/// <summary>Constant value for <see cref="OTHERValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "1.1";
			/// <summary>Constant value for <see cref="OTHERValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;alarm is not in any of the above categories.&#10;
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