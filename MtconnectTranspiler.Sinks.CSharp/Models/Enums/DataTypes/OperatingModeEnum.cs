using System;
using System.CodeDom.Compiler;using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;

namespace Mtconnect.DataTypes
{
	/// <summary>
	/// View in the MTConnect Model browser <seealso href="https://model.mtconnect.org/#Enumeration___19_0_3_68e0225_1637936591972_920420_100">model.mtconnect.org</seealso>
	﻿
	/// </summary>
	/// <remarks>
	/// <list type="bullet">
	/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_2.0">v2.0</see></item>
	/// </list>
	/// </remarks>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public enum OperatingModeEnum
	{
		/// <summary>
		﻿/// automatically execute instructions from a recipe or program.<br /><br />> Note: Setpoint comes from a recipe.<br/><br />

		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_2.0">v2.0</see></item>
		/// </list>
		/// </remarks>
		AUTOMATIC,
		/// <summary>
		﻿/// execute instructions from an external agent or person.<br /><br />> Note 1 to entry: Valve or switch is manipulated by an agent/person.<br /><br />> Note 2 to entry: Direct control of the PID output. % of the range: A user manually sets the % output, not the setpoint.<br/><br />

		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_2.0">v2.0</see></item>
		/// </list>
		/// </remarks>
		MANUAL,
		/// <summary>
		﻿/// executes a single instruction from a recipe or program.<br /><br />> Note 1 to entry: Setpoint is entered and fixed, but the PID is controlling.<br /><br />> Note 2 to entry: Still goes through the PID control system.<br /><br />> Note 3 to entry: Manual fixed entry from a recipe.<br/><br />

		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_2.0">v2.0</see></item>
		/// </list>
		/// </remarks>
		SEMI_AUTOMATIC,
	}

	/// <summary>
	/// View in the MTConnect Model browser <seealso href="https://model.mtconnect.org/#Enumeration___19_0_3_68e0225_1637936591972_920420_100">model.mtconnect.org</seealso>
	﻿
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public sealed class OperatingModeEnumMetaClass : IEnum
	{
		/// <inheritdoc />
		public string Name => "OperatingModeEnum";
		
		/// <inheritdoc />
		public Type DataType => null;
		
		public Type Instance => typeof(OperatingModeEnum);

		/// <inheritdoc />
		public string NormativeVersion => "2.0";
		
		/// <inheritdoc />
		public string DeprecatedVersion => "";
		
		/// <inheritdoc />
		public string Summary => @"";
		
		/// <inheritdoc />
		public IEnumInstance[] Values => new IEnumInstance[] {
		AUTOMATIC,
		MANUAL,
		SEMI_AUTOMATIC,
		};

		private AUTOMATICValue _AUTOMATIC;
		/// <summary>
		﻿/// automatically execute instructions from a recipe or program.<br /><br />> Note: Setpoint comes from a recipe.<br/><br />

		/// </summary>
		public AUTOMATICValue AUTOMATIC => _AUTOMATIC ?? (_AUTOMATIC = new AUTOMATICValue());

		/// <summary>
		﻿/// automatically execute instructions from a recipe or program.<br /><br />> Note: Setpoint comes from a recipe.<br/><br />

		/// </summary>
		public sealed class AUTOMATICValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "AUTOMATIC";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "2.0";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"&#10;&#10;&#10;automatically execute instructions from a recipe or program.

> Note: Setpoint comes from a recipe.&#10;
";
		}
		private MANUALValue _MANUAL;
		/// <summary>
		﻿/// execute instructions from an external agent or person.<br /><br />> Note 1 to entry: Valve or switch is manipulated by an agent/person.<br /><br />> Note 2 to entry: Direct control of the PID output. % of the range: A user manually sets the % output, not the setpoint.<br/><br />

		/// </summary>
		public MANUALValue MANUAL => _MANUAL ?? (_MANUAL = new MANUALValue());

		/// <summary>
		﻿/// execute instructions from an external agent or person.<br /><br />> Note 1 to entry: Valve or switch is manipulated by an agent/person.<br /><br />> Note 2 to entry: Direct control of the PID output. % of the range: A user manually sets the % output, not the setpoint.<br/><br />

		/// </summary>
		public sealed class MANUALValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "MANUAL";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "2.0";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"&#10;&#10;&#10;execute instructions from an external agent or person.

> Note 1 to entry: Valve or switch is manipulated by an agent/person.

> Note 2 to entry: Direct control of the PID output. % of the range: A user manually sets the % output, not the setpoint.&#10;
";
		}
		private SEMI_AUTOMATICValue _SEMI_AUTOMATIC;
		/// <summary>
		﻿/// executes a single instruction from a recipe or program.<br /><br />> Note 1 to entry: Setpoint is entered and fixed, but the PID is controlling.<br /><br />> Note 2 to entry: Still goes through the PID control system.<br /><br />> Note 3 to entry: Manual fixed entry from a recipe.<br/><br />

		/// </summary>
		public SEMI_AUTOMATICValue SEMI_AUTOMATIC => _SEMI_AUTOMATIC ?? (_SEMI_AUTOMATIC = new SEMI_AUTOMATICValue());

		/// <summary>
		﻿/// executes a single instruction from a recipe or program.<br /><br />> Note 1 to entry: Setpoint is entered and fixed, but the PID is controlling.<br /><br />> Note 2 to entry: Still goes through the PID control system.<br /><br />> Note 3 to entry: Manual fixed entry from a recipe.<br/><br />

		/// </summary>
		public sealed class SEMI_AUTOMATICValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "SEMI_AUTOMATIC";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "2.0";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"&#10;&#10;&#10;executes a single instruction from a recipe or program.

> Note 1 to entry: Setpoint is entered and fixed, but the PID is controlling.

> Note 2 to entry: Still goes through the PID control system.

> Note 3 to entry: Manual fixed entry from a recipe.&#10;
";
		}
	}
}