#pragma warning disable CS1574 // XML comment has cref attribute that could not be resolved
#pragma warning disable CS1584 // XML comment has syntactically incorrect cref attribute
#pragma warning disable CS0618 // Type or member is obsolete
using System;
using System.CodeDom.Compiler;using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;

namespace Mtconnect.DataTypes
{
	/// <summary>﻿
	/// <br/> Visit <seealso href="https://model.mtconnect.org/#Enumeration___19_0_3_68e0225_1637936591972_920420_100">model.mtconnect.org</seealso> for more information.
	/// </summary>
	/// <remarks>
	/// <list type="bullet">
	/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_2.0">v2.0</see></item>
	/// </list>
	/// </remarks>

	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public enum OperatingModeEnum
	{
		/// <summary>﻿automatically execute instructions from a recipe or program.<br /><br />&gt; Note: Setpoint comes from a recipe.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_2.0">v2.0</see></item>
		/// </list>
		/// </remarks>

		AUTOMATIC,
		/// <summary>﻿execute instructions from an external agent or person.<br /><br />&gt; Note 1 to entry: Valve or switch is manipulated by an agent/person.<br /><br />&gt; Note 2 to entry: Direct control of the PID output. % of the range: A user manually sets the % output, not the setpoint.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_2.0">v2.0</see></item>
		/// </list>
		/// </remarks>

		MANUAL,
		/// <summary>﻿executes a single instruction from a recipe or program.<br /><br />&gt; Note 1 to entry: Setpoint is entered and fixed, but the PID is controlling.<br /><br />&gt; Note 2 to entry: Still goes through the PID control system.<br /><br />&gt; Note 3 to entry: Manual fixed entry from a recipe.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_2.0">v2.0</see></item>
		/// </list>
		/// </remarks>

		SEMI_AUTOMATIC,
	}

	/// <summary>﻿
	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Enumeration___19_0_3_68e0225_1637936591972_920420_100">model.mtconnect.org</seealso> for more information.
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public sealed class OperatingModeEnumMetaClass : IEnum
	{
		/// <summary>Constant value for <see cref="OperatingModeEnumMetaClass.ReferenceId" /></summary>
		public const string REFERENCE_ID = "_19_0_3_68e0225_1637936591972_920420_100";
		/// <summary>Constant value for <see cref="OperatingModeEnumMetaClass.HelpUrl" /></summary>
		public const string HELP_URL = "https://model.mtconnect.org/#Enumeration___19_0_3_68e0225_1637936591972_920420_100";
		/// <summary>Constant value for <see cref="OperatingModeEnumMetaClass.Name" /></summary>
		public const string NAME = "OperatingModeEnum";
		/// <summary>Constant value for <see cref="OperatingModeEnumMetaClass.NormativeVersion" /></summary>
		public const string NORMATIVE_VERSION = "2.0";
		/// <summary>Constant value for <see cref="OperatingModeEnumMetaClass.DeprecatedVersion" /></summary>
		public const string DEPRECATED_VERSION = "";
		/// <summary>Constant value for <see cref="OperatingModeEnumMetaClass.Summary" /></summary>
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
		public Type Instance => typeof(OperatingModeEnum);

		/// <inheritdoc />
		public string NormativeVersion => NORMATIVE_VERSION;
		
		/// <inheritdoc />
		public string DeprecatedVersion => DEPRECATED_VERSION;
		
		/// <inheritdoc />
		public string Summary => SUMMARY;
		
		/// <inheritdoc />
		public IEnumInstance[] Values => new IEnumInstance[] {
		AUTOMATIC,
		MANUAL,
		SEMI_AUTOMATIC,
		};

		private AUTOMATICValue _AUTOMATIC;
		/// <inheritdoc cref="AUTOMATICValue" path="/summary" />
		public AUTOMATICValue AUTOMATIC => _AUTOMATIC ?? (_AUTOMATIC = new AUTOMATICValue());

		/// <summary>﻿automatically execute instructions from a recipe or program.<br /><br />&gt; Note: Setpoint comes from a recipe.<br /><br /><br />
		/// Value for OperatingModeEnum.<br/>
		/// <br/>See also <seealso cref="OperatingModeEnum">OperatingModeEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_2.0">v2.0</see></item>
		/// </list>
		/// </remarks>

		public sealed class AUTOMATICValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="AUTOMATICValue.Name" /></summary>
			public const string NAME = "AUTOMATIC";
			/// <summary>Constant value for <see cref="AUTOMATICValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "2.0";
			/// <summary>Constant value for <see cref="AUTOMATICValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="AUTOMATICValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;automatically execute instructions from a recipe or program.

> Note: Setpoint comes from a recipe.&#10;
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
		private MANUALValue _MANUAL;
		/// <inheritdoc cref="MANUALValue" path="/summary" />
		public MANUALValue MANUAL => _MANUAL ?? (_MANUAL = new MANUALValue());

		/// <summary>﻿execute instructions from an external agent or person.<br /><br />&gt; Note 1 to entry: Valve or switch is manipulated by an agent/person.<br /><br />&gt; Note 2 to entry: Direct control of the PID output. % of the range: A user manually sets the % output, not the setpoint.<br /><br /><br />
		/// Value for OperatingModeEnum.<br/>
		/// <br/>See also <seealso cref="OperatingModeEnum">OperatingModeEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_2.0">v2.0</see></item>
		/// </list>
		/// </remarks>

		public sealed class MANUALValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="MANUALValue.Name" /></summary>
			public const string NAME = "MANUAL";
			/// <summary>Constant value for <see cref="MANUALValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "2.0";
			/// <summary>Constant value for <see cref="MANUALValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="MANUALValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;execute instructions from an external agent or person.

> Note 1 to entry: Valve or switch is manipulated by an agent/person.

> Note 2 to entry: Direct control of the PID output. % of the range: A user manually sets the % output, not the setpoint.&#10;
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
		private SEMI_AUTOMATICValue _SEMI_AUTOMATIC;
		/// <inheritdoc cref="SEMI_AUTOMATICValue" path="/summary" />
		public SEMI_AUTOMATICValue SEMI_AUTOMATIC => _SEMI_AUTOMATIC ?? (_SEMI_AUTOMATIC = new SEMI_AUTOMATICValue());

		/// <summary>﻿executes a single instruction from a recipe or program.<br /><br />&gt; Note 1 to entry: Setpoint is entered and fixed, but the PID is controlling.<br /><br />&gt; Note 2 to entry: Still goes through the PID control system.<br /><br />&gt; Note 3 to entry: Manual fixed entry from a recipe.<br /><br /><br />
		/// Value for OperatingModeEnum.<br/>
		/// <br/>See also <seealso cref="OperatingModeEnum">OperatingModeEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_2.0">v2.0</see></item>
		/// </list>
		/// </remarks>

		public sealed class SEMI_AUTOMATICValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="SEMI_AUTOMATICValue.Name" /></summary>
			public const string NAME = "SEMI_AUTOMATIC";
			/// <summary>Constant value for <see cref="SEMI_AUTOMATICValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "2.0";
			/// <summary>Constant value for <see cref="SEMI_AUTOMATICValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="SEMI_AUTOMATICValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;executes a single instruction from a recipe or program.

> Note 1 to entry: Setpoint is entered and fixed, but the PID is controlling.

> Note 2 to entry: Still goes through the PID control system.

> Note 3 to entry: Manual fixed entry from a recipe.&#10;
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