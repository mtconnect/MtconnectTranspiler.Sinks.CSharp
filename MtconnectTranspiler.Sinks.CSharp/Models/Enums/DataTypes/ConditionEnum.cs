#pragma warning disable CS1574 // XML comment has cref attribute that could not be resolved
#pragma warning disable CS1584 // XML comment has syntactically incorrect cref attribute
#pragma warning disable CS0618 // Type or member is obsolete
using System;
using System.CodeDom.Compiler;using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;

namespace Mtconnect.DataTypes
{
	/// <summary>﻿
	/// <br/> Visit <seealso href="https://model.mtconnect.org/#Enumeration___19_0_3_45f01b9_1580398386435_855466_12827">model.mtconnect.org</seealso> for more information.
	/// </summary>
	/// <remarks>
	/// <list type="bullet">
	/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.1">v1.1</see></item>
	/// </list>
	/// </remarks>

	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public enum ConditionEnum
	{
		/// <summary>﻿indication that the piece of equipment has experienced a communications failure.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.1">v1.1</see></item>
		/// </list>
		/// </remarks>

		COMMUNICATIONS,
		/// <summary>﻿indication that the value of the data associated with a measured value or a calculation is outside of an expected range.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.1">v1.1</see></item>
		/// </list>
		/// </remarks>

		DATA_RANGE,
		/// <summary>﻿indication that an error occurred in the logic program or programmable logic controller (PLC) associated with a piece of equipment.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.1">v1.1</see></item>
		/// </list>
		/// </remarks>

		LOGIC_PROGRAM,
		/// <summary>﻿indication that an error occurred in the motion program associated with a piece of equipment.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.1">v1.1</see></item>
		/// </list>
		/// </remarks>

		MOTION_PROGRAM,
		/// <summary>﻿general purpose indication associated with an electronic component of a piece of equipment or a controller that represents a fault that is not associated with the operator, program, or hardware.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.1">v1.1</see></item>
		/// </list>
		/// </remarks>

		SYSTEM,
		/// <summary>﻿indication of a fault associated with an actuator.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.1">v1.1</see></item>
		/// </list>
		/// </remarks>

		ACTUATOR,
	}

	/// <summary>﻿
	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Enumeration___19_0_3_45f01b9_1580398386435_855466_12827">model.mtconnect.org</seealso> for more information.
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public sealed class ConditionEnumMetaClass : IEnum
	{
		/// <summary>Constant value for <see cref="ConditionEnumMetaClass.ReferenceId" /></summary>
		public const string REFERENCE_ID = "_19_0_3_45f01b9_1580398386435_855466_12827";
		/// <summary>Constant value for <see cref="ConditionEnumMetaClass.HelpUrl" /></summary>
		public const string HELP_URL = "https://model.mtconnect.org/#Enumeration___19_0_3_45f01b9_1580398386435_855466_12827";
		/// <summary>Constant value for <see cref="ConditionEnumMetaClass.Name" /></summary>
		public const string NAME = "ConditionEnum";
		/// <summary>Constant value for <see cref="ConditionEnumMetaClass.NormativeVersion" /></summary>
		public const string NORMATIVE_VERSION = "1.1";
		/// <summary>Constant value for <see cref="ConditionEnumMetaClass.DeprecatedVersion" /></summary>
		public const string DEPRECATED_VERSION = "";
		/// <summary>Constant value for <see cref="ConditionEnumMetaClass.Summary" /></summary>
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
		public Type Instance => typeof(ConditionEnum);

		/// <inheritdoc />
		public string NormativeVersion => NORMATIVE_VERSION;
		
		/// <inheritdoc />
		public string DeprecatedVersion => DEPRECATED_VERSION;
		
		/// <inheritdoc />
		public string Summary => SUMMARY;
		
		/// <inheritdoc />
		public IEnumInstance[] Values => new IEnumInstance[] {
		COMMUNICATIONS,
		DATA_RANGE,
		LOGIC_PROGRAM,
		MOTION_PROGRAM,
		SYSTEM,
		ACTUATOR,
		};

		private COMMUNICATIONSValue _COMMUNICATIONS;
		/// <inheritdoc cref="COMMUNICATIONSValue" path="/summary" />
		public COMMUNICATIONSValue COMMUNICATIONS => _COMMUNICATIONS ?? (_COMMUNICATIONS = new COMMUNICATIONSValue());

		/// <summary>﻿indication that the piece of equipment has experienced a communications failure.<br /><br /><br />
		/// Value for ConditionEnum.<br/>
		/// <br/>See also <seealso cref="ConditionEnum">ConditionEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.1">v1.1</see></item>
		/// </list>
		/// </remarks>

		public sealed class COMMUNICATIONSValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="COMMUNICATIONSValue.Name" /></summary>
			public const string NAME = "COMMUNICATIONS";
			/// <summary>Constant value for <see cref="COMMUNICATIONSValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.1";
			/// <summary>Constant value for <see cref="COMMUNICATIONSValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="COMMUNICATIONSValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;indication that the piece of equipment has experienced a communications failure.&#10;
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
		private DATA_RANGEValue _DATA_RANGE;
		/// <inheritdoc cref="DATA_RANGEValue" path="/summary" />
		public DATA_RANGEValue DATA_RANGE => _DATA_RANGE ?? (_DATA_RANGE = new DATA_RANGEValue());

		/// <summary>﻿indication that the value of the data associated with a measured value or a calculation is outside of an expected range.<br /><br /><br />
		/// Value for ConditionEnum.<br/>
		/// <br/>See also <seealso cref="ConditionEnum">ConditionEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.1">v1.1</see></item>
		/// </list>
		/// </remarks>

		public sealed class DATA_RANGEValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="DATA_RANGEValue.Name" /></summary>
			public const string NAME = "DATA_RANGE";
			/// <summary>Constant value for <see cref="DATA_RANGEValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.2";
			/// <summary>Constant value for <see cref="DATA_RANGEValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="DATA_RANGEValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;indication that the value of the data associated with a measured value or a calculation is outside of an expected range.&#10;
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
		private LOGIC_PROGRAMValue _LOGIC_PROGRAM;
		/// <inheritdoc cref="LOGIC_PROGRAMValue" path="/summary" />
		public LOGIC_PROGRAMValue LOGIC_PROGRAM => _LOGIC_PROGRAM ?? (_LOGIC_PROGRAM = new LOGIC_PROGRAMValue());

		/// <summary>﻿indication that an error occurred in the logic program or programmable logic controller (PLC) associated with a piece of equipment.<br /><br /><br />
		/// Value for ConditionEnum.<br/>
		/// <br/>See also <seealso cref="ConditionEnum">ConditionEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.1">v1.1</see></item>
		/// </list>
		/// </remarks>

		public sealed class LOGIC_PROGRAMValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="LOGIC_PROGRAMValue.Name" /></summary>
			public const string NAME = "LOGIC_PROGRAM";
			/// <summary>Constant value for <see cref="LOGIC_PROGRAMValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.1";
			/// <summary>Constant value for <see cref="LOGIC_PROGRAMValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="LOGIC_PROGRAMValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;indication that an error occurred in the logic program or programmable logic controller (PLC) associated with a piece of equipment.&#10;
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
		private MOTION_PROGRAMValue _MOTION_PROGRAM;
		/// <inheritdoc cref="MOTION_PROGRAMValue" path="/summary" />
		public MOTION_PROGRAMValue MOTION_PROGRAM => _MOTION_PROGRAM ?? (_MOTION_PROGRAM = new MOTION_PROGRAMValue());

		/// <summary>﻿indication that an error occurred in the motion program associated with a piece of equipment.<br /><br /><br />
		/// Value for ConditionEnum.<br/>
		/// <br/>See also <seealso cref="ConditionEnum">ConditionEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.1">v1.1</see></item>
		/// </list>
		/// </remarks>

		public sealed class MOTION_PROGRAMValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="MOTION_PROGRAMValue.Name" /></summary>
			public const string NAME = "MOTION_PROGRAM";
			/// <summary>Constant value for <see cref="MOTION_PROGRAMValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.1";
			/// <summary>Constant value for <see cref="MOTION_PROGRAMValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="MOTION_PROGRAMValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;indication that an error occurred in the motion program associated with a piece of equipment.&#10;
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
		private SYSTEMValue _SYSTEM;
		/// <inheritdoc cref="SYSTEMValue" path="/summary" />
		public SYSTEMValue SYSTEM => _SYSTEM ?? (_SYSTEM = new SYSTEMValue());

		/// <summary>﻿general purpose indication associated with an electronic component of a piece of equipment or a controller that represents a fault that is not associated with the operator, program, or hardware.<br /><br /><br />
		/// Value for ConditionEnum.<br/>
		/// <br/>See also <seealso cref="ConditionEnum">ConditionEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.1">v1.1</see></item>
		/// </list>
		/// </remarks>

		public sealed class SYSTEMValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="SYSTEMValue.Name" /></summary>
			public const string NAME = "SYSTEM";
			/// <summary>Constant value for <see cref="SYSTEMValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.1";
			/// <summary>Constant value for <see cref="SYSTEMValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="SYSTEMValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;general purpose indication associated with an electronic component of a piece of equipment or a controller that represents a fault that is not associated with the operator, program, or hardware.&#10;
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
		private ACTUATORValue _ACTUATOR;
		/// <inheritdoc cref="ACTUATORValue" path="/summary" />
		public ACTUATORValue ACTUATOR => _ACTUATOR ?? (_ACTUATOR = new ACTUATORValue());

		/// <summary>﻿indication of a fault associated with an actuator.<br /><br /><br />
		/// Value for ConditionEnum.<br/>
		/// <br/>See also <seealso cref="ConditionEnum">ConditionEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.1">v1.1</see></item>
		/// </list>
		/// </remarks>

		public sealed class ACTUATORValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="ACTUATORValue.Name" /></summary>
			public const string NAME = "ACTUATOR";
			/// <summary>Constant value for <see cref="ACTUATORValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.1";
			/// <summary>Constant value for <see cref="ACTUATORValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="ACTUATORValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;indication of a fault associated with an actuator.&#10;
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