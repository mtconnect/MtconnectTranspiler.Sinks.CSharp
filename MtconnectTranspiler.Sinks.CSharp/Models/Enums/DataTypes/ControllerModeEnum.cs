#pragma warning disable CS1574 // XML comment has cref attribute that could not be resolved
#pragma warning disable CS1584 // XML comment has syntactically incorrect cref attribute
#pragma warning disable CS0618 // Type or member is obsolete
using System;
using System.CodeDom.Compiler;using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;

namespace Mtconnect.DataTypes
{
	/// <summary>﻿
	/// <br/> Visit <seealso href="https://model.mtconnect.org/#Enumeration___19_0_3_45f01b9_1580378417660_348819_2874">model.mtconnect.org</seealso> for more information.
	/// </summary>
	/// <remarks>
	/// <list type="bullet">
	/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
	/// </list>
	/// </remarks>

	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public enum ControllerModeEnum
	{
		/// <summary>﻿<see cref="Controller">Controller</see> is configured to automatically execute a program.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		AUTOMATIC,
		/// <summary>﻿<see cref="Controller">Controller</see> is not executing an active program. <br /><br />It is capable of receiving instructions from an external source – typically an operator. The <see cref="Controller">Controller</see> executes operations based on the instructions received from the external source.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		MANUAL,
		/// <summary>﻿operator can enter a series of operations for the <see cref="Controller">Controller</see> to perform.<br /><br />The <see cref="Controller">Controller</see> will execute this specific series of operations and then stop.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		MANUAL_DATA_INPUT,
		/// <summary>﻿<see cref="Controller">Controller</see> is operating in a mode that restricts the active program from processing its next process step without operator intervention.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		SEMI_AUTOMATIC,
		/// <summary>﻿<see cref="Controller">Controller</see> is currently functioning as a programming device and is not capable of executing an active program.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		EDIT,
		/// <summary>﻿axes of the device are commanded to stop, but the spindle continues to function.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		FEED_HOLD,
	}

	/// <summary>﻿
	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Enumeration___19_0_3_45f01b9_1580378417660_348819_2874">model.mtconnect.org</seealso> for more information.
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public sealed class ControllerModeEnumMetaClass : IEnum
	{
		/// <summary>Constant value for <see cref="ControllerModeEnumMetaClass.ReferenceId" /></summary>
		public const string REFERENCE_ID = "_19_0_3_45f01b9_1580378417660_348819_2874";
		/// <summary>Constant value for <see cref="ControllerModeEnumMetaClass.HelpUrl" /></summary>
		public const string HELP_URL = "https://model.mtconnect.org/#Enumeration___19_0_3_45f01b9_1580378417660_348819_2874";
		/// <summary>Constant value for <see cref="ControllerModeEnumMetaClass.Name" /></summary>
		public const string NAME = "ControllerModeEnum";
		/// <summary>Constant value for <see cref="ControllerModeEnumMetaClass.NormativeVersion" /></summary>
		public const string NORMATIVE_VERSION = "1.0";
		/// <summary>Constant value for <see cref="ControllerModeEnumMetaClass.DeprecatedVersion" /></summary>
		public const string DEPRECATED_VERSION = "";
		/// <summary>Constant value for <see cref="ControllerModeEnumMetaClass.Summary" /></summary>
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
		public Type Instance => typeof(ControllerModeEnum);

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
		MANUAL_DATA_INPUT,
		SEMI_AUTOMATIC,
		EDIT,
		FEED_HOLD,
		};

		private AUTOMATICValue _AUTOMATIC;
		/// <inheritdoc cref="AUTOMATICValue" path="/summary" />
		public AUTOMATICValue AUTOMATIC => _AUTOMATIC ?? (_AUTOMATIC = new AUTOMATICValue());

		/// <summary>﻿<see cref="Controller">Controller</see> is configured to automatically execute a program.<br /><br /><br />
		/// Value for ControllerModeEnum.<br/>
		/// <br/>See also <seealso cref="ControllerModeEnum">ControllerModeEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		public sealed class AUTOMATICValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="AUTOMATICValue.Name" /></summary>
			public const string NAME = "AUTOMATIC";
			/// <summary>Constant value for <see cref="AUTOMATICValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.0";
			/// <summary>Constant value for <see cref="AUTOMATICValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="AUTOMATICValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;{{block(Controller)}} is configured to automatically execute a program.&#10;
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

		/// <summary>﻿<see cref="Controller">Controller</see> is not executing an active program. <br /><br />It is capable of receiving instructions from an external source – typically an operator. The <see cref="Controller">Controller</see> executes operations based on the instructions received from the external source.<br /><br /><br />
		/// Value for ControllerModeEnum.<br/>
		/// <br/>See also <seealso cref="ControllerModeEnum">ControllerModeEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		public sealed class MANUALValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="MANUALValue.Name" /></summary>
			public const string NAME = "MANUAL";
			/// <summary>Constant value for <see cref="MANUALValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.0";
			/// <summary>Constant value for <see cref="MANUALValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="MANUALValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;{{block(Controller)}} is not executing an active program. 

It is capable of receiving instructions from an external source – typically an operator. The {{block(Controller)}} executes operations based on the instructions received from the external source.&#10;
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
		private MANUAL_DATA_INPUTValue _MANUAL_DATA_INPUT;
		/// <inheritdoc cref="MANUAL_DATA_INPUTValue" path="/summary" />
		public MANUAL_DATA_INPUTValue MANUAL_DATA_INPUT => _MANUAL_DATA_INPUT ?? (_MANUAL_DATA_INPUT = new MANUAL_DATA_INPUTValue());

		/// <summary>﻿operator can enter a series of operations for the <see cref="Controller">Controller</see> to perform.<br /><br />The <see cref="Controller">Controller</see> will execute this specific series of operations and then stop.<br /><br /><br />
		/// Value for ControllerModeEnum.<br/>
		/// <br/>See also <seealso cref="ControllerModeEnum">ControllerModeEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		public sealed class MANUAL_DATA_INPUTValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="MANUAL_DATA_INPUTValue.Name" /></summary>
			public const string NAME = "MANUAL_DATA_INPUT";
			/// <summary>Constant value for <see cref="MANUAL_DATA_INPUTValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.0";
			/// <summary>Constant value for <see cref="MANUAL_DATA_INPUTValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="MANUAL_DATA_INPUTValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;operator can enter a series of operations for the {{block(Controller)}} to perform.

The {{block(Controller)}} will execute this specific series of operations and then stop.&#10;
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

		/// <summary>﻿<see cref="Controller">Controller</see> is operating in a mode that restricts the active program from processing its next process step without operator intervention.<br /><br /><br />
		/// Value for ControllerModeEnum.<br/>
		/// <br/>See also <seealso cref="ControllerModeEnum">ControllerModeEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		public sealed class SEMI_AUTOMATICValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="SEMI_AUTOMATICValue.Name" /></summary>
			public const string NAME = "SEMI_AUTOMATIC";
			/// <summary>Constant value for <see cref="SEMI_AUTOMATICValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.1";
			/// <summary>Constant value for <see cref="SEMI_AUTOMATICValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="SEMI_AUTOMATICValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;{{block(Controller)}} is operating in a mode that restricts the active program from processing its next process step without operator intervention.&#10;
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
		private EDITValue _EDIT;
		/// <inheritdoc cref="EDITValue" path="/summary" />
		public EDITValue EDIT => _EDIT ?? (_EDIT = new EDITValue());

		/// <summary>﻿<see cref="Controller">Controller</see> is currently functioning as a programming device and is not capable of executing an active program.<br /><br /><br />
		/// Value for ControllerModeEnum.<br/>
		/// <br/>See also <seealso cref="ControllerModeEnum">ControllerModeEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		public sealed class EDITValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="EDITValue.Name" /></summary>
			public const string NAME = "EDIT";
			/// <summary>Constant value for <see cref="EDITValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.3";
			/// <summary>Constant value for <see cref="EDITValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="EDITValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;{{block(Controller)}} is currently functioning as a programming device and is not capable of executing an active program.&#10;
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

		/// <summary>﻿axes of the device are commanded to stop, but the spindle continues to function.<br /><br /><br />
		/// Value for ControllerModeEnum.<br/>
		/// <br/>See also <seealso cref="ControllerModeEnum">ControllerModeEnum</seealso>
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
			public const string NORMATIVE_VERSION = "1.2";
			/// <summary>Constant value for <see cref="FEED_HOLDValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "1.3";
			/// <summary>Constant value for <see cref="FEED_HOLDValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;axes of the device are commanded to stop, but the spindle continues to function.&#10;
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