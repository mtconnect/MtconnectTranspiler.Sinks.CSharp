using System;
using System.CodeDom.Compiler;using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;

namespace Mtconnect.DataTypes
{
	/// <summary>
	/// View in the MTConnect Model browser <seealso href="https://model.mtconnect.org/#Enumeration___19_0_3_45f01b9_1580398386435_855466_12827">model.mtconnect.org</seealso>
	﻿
	/// </summary>
	/// <remarks>
	/// <list type="bullet">
	/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.1">v1.1</see></item>
	/// </list>
	/// </remarks>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public enum ConditionEnum
	{
		/// <summary>
		﻿/// indication that the piece of equipment has experienced a communications failure.<br/><br />

		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.1">v1.1</see></item>
		/// </list>
		/// </remarks>
		COMMUNICATIONS,
		/// <summary>
		﻿/// indication that the value of the data associated with a measured value or a calculation is outside of an expected range.<br/><br />

		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.2">v1.2</see></item>
		/// </list>
		/// </remarks>
		DATA_RANGE,
		/// <summary>
		﻿/// indication that an error occurred in the logic program or programmable logic controller (PLC) associated with a piece of equipment.<br/><br />

		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.1">v1.1</see></item>
		/// </list>
		/// </remarks>
		LOGIC_PROGRAM,
		/// <summary>
		﻿/// indication that an error occurred in the motion program associated with a piece of equipment.<br/><br />

		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.1">v1.1</see></item>
		/// </list>
		/// </remarks>
		MOTION_PROGRAM,
		/// <summary>
		﻿/// general purpose indication associated with an electronic component of a piece of equipment or a controller that represents a fault that is not associated with the operator, program, or hardware.<br/><br />

		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.1">v1.1</see></item>
		/// </list>
		/// </remarks>
		SYSTEM,
		/// <summary>
		﻿/// indication of a fault associated with an actuator.<br/><br />

		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.1">v1.1</see></item>
		/// </list>
		/// </remarks>
		ACTUATOR,
	}

	/// <summary>
	/// View in the MTConnect Model browser <seealso href="https://model.mtconnect.org/#Enumeration___19_0_3_45f01b9_1580398386435_855466_12827">model.mtconnect.org</seealso>
	﻿
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public sealed class ConditionEnumMetaClass : IEnum
	{
		/// <inheritdoc />
		public string Name => "ConditionEnum";
		
		/// <inheritdoc />
		public Type DataType => null;
		
		public Type Instance => typeof(ConditionEnum);

		/// <inheritdoc />
		public string NormativeVersion => "1.1";
		
		/// <inheritdoc />
		public string DeprecatedVersion => "";
		
		/// <inheritdoc />
		public string Summary => @"";
		
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
		/// <summary>
		﻿/// indication that the piece of equipment has experienced a communications failure.<br/><br />

		/// </summary>
		public COMMUNICATIONSValue COMMUNICATIONS => _COMMUNICATIONS ?? (_COMMUNICATIONS = new COMMUNICATIONSValue());

		/// <summary>
		﻿/// indication that the piece of equipment has experienced a communications failure.<br/><br />

		/// </summary>
		public sealed class COMMUNICATIONSValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "COMMUNICATIONS";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.1";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"&#10;&#10;&#10;indication that the piece of equipment has experienced a communications failure.&#10;
";
		}
		private DATA_RANGEValue _DATA_RANGE;
		/// <summary>
		﻿/// indication that the value of the data associated with a measured value or a calculation is outside of an expected range.<br/><br />

		/// </summary>
		public DATA_RANGEValue DATA_RANGE => _DATA_RANGE ?? (_DATA_RANGE = new DATA_RANGEValue());

		/// <summary>
		﻿/// indication that the value of the data associated with a measured value or a calculation is outside of an expected range.<br/><br />

		/// </summary>
		public sealed class DATA_RANGEValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "DATA_RANGE";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.2";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"&#10;&#10;&#10;indication that the value of the data associated with a measured value or a calculation is outside of an expected range.&#10;
";
		}
		private LOGIC_PROGRAMValue _LOGIC_PROGRAM;
		/// <summary>
		﻿/// indication that an error occurred in the logic program or programmable logic controller (PLC) associated with a piece of equipment.<br/><br />

		/// </summary>
		public LOGIC_PROGRAMValue LOGIC_PROGRAM => _LOGIC_PROGRAM ?? (_LOGIC_PROGRAM = new LOGIC_PROGRAMValue());

		/// <summary>
		﻿/// indication that an error occurred in the logic program or programmable logic controller (PLC) associated with a piece of equipment.<br/><br />

		/// </summary>
		public sealed class LOGIC_PROGRAMValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "LOGIC_PROGRAM";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.1";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"&#10;&#10;&#10;indication that an error occurred in the logic program or programmable logic controller (PLC) associated with a piece of equipment.&#10;
";
		}
		private MOTION_PROGRAMValue _MOTION_PROGRAM;
		/// <summary>
		﻿/// indication that an error occurred in the motion program associated with a piece of equipment.<br/><br />

		/// </summary>
		public MOTION_PROGRAMValue MOTION_PROGRAM => _MOTION_PROGRAM ?? (_MOTION_PROGRAM = new MOTION_PROGRAMValue());

		/// <summary>
		﻿/// indication that an error occurred in the motion program associated with a piece of equipment.<br/><br />

		/// </summary>
		public sealed class MOTION_PROGRAMValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "MOTION_PROGRAM";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.1";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"&#10;&#10;&#10;indication that an error occurred in the motion program associated with a piece of equipment.&#10;
";
		}
		private SYSTEMValue _SYSTEM;
		/// <summary>
		﻿/// general purpose indication associated with an electronic component of a piece of equipment or a controller that represents a fault that is not associated with the operator, program, or hardware.<br/><br />

		/// </summary>
		public SYSTEMValue SYSTEM => _SYSTEM ?? (_SYSTEM = new SYSTEMValue());

		/// <summary>
		﻿/// general purpose indication associated with an electronic component of a piece of equipment or a controller that represents a fault that is not associated with the operator, program, or hardware.<br/><br />

		/// </summary>
		public sealed class SYSTEMValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "SYSTEM";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.1";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"&#10;&#10;&#10;general purpose indication associated with an electronic component of a piece of equipment or a controller that represents a fault that is not associated with the operator, program, or hardware.&#10;
";
		}
		private ACTUATORValue _ACTUATOR;
		/// <summary>
		﻿/// indication of a fault associated with an actuator.<br/><br />

		/// </summary>
		public ACTUATORValue ACTUATOR => _ACTUATOR ?? (_ACTUATOR = new ACTUATORValue());

		/// <summary>
		﻿/// indication of a fault associated with an actuator.<br/><br />

		/// </summary>
		public sealed class ACTUATORValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "ACTUATOR";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.1";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"&#10;&#10;&#10;indication of a fault associated with an actuator.&#10;
";
		}
	}
}