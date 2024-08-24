#pragma warning disable CS1574 // XML comment has cref attribute that could not be resolved
#pragma warning disable CS1584 // XML comment has syntactically incorrect cref attribute
#pragma warning disable CS0618 // Type or member is obsolete
using System;
using System.CodeDom.Compiler;using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;

namespace Mtconnect.DataTypes
{
	/// <summary>﻿
	/// <br/> Visit <seealso href="https://model.mtconnect.org/#Enumeration___19_0_3_45f01b9_1579566531118_10952_25736">model.mtconnect.org</seealso> for more information.
	/// </summary>
	/// <remarks>
	/// <list type="bullet">
	/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.4">v1.4</see></item>
	/// </list>
	/// </remarks>

	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public enum ResetTriggeredEnum
	{
		/// <summary>﻿<see cref="Observation.result">result in Observation</see> is measuring an action or operation was reset upon completion of that action or operation.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.4">v1.4</see></item>
		/// </list>
		/// </remarks>

		ACTION_COMPLETE,
		/// <summary>﻿<see cref="Observation.result">result in Observation</see> was reset at the end of a 12-month period.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.4">v1.4</see></item>
		/// </list>
		/// </remarks>

		ANNUAL,
		/// <summary>﻿<see cref="Observation.result">result in Observation</see> was reset at the end of a 24-hour period.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.4">v1.4</see></item>
		/// </list>
		/// </remarks>

		DAY,
		/// <summary>﻿<see cref="Observation.result">result in Observation</see> was reset upon completion of a maintenance event.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.4">v1.4</see></item>
		/// </list>
		/// </remarks>

		MAINTENANCE,
		/// <summary>﻿<see cref="Observation.result">result in Observation</see> was reset based on a physical reset action.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.4">v1.4</see></item>
		/// </list>
		/// </remarks>

		MANUAL,
		/// <summary>﻿<see cref="Observation.result">result in Observation</see> was reset at the end of a monthly period.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.4">v1.4</see></item>
		/// </list>
		/// </remarks>

		MONTH,
		/// <summary>﻿<see cref="Observation.result">result in Observation</see> was reset when power was applied to the piece of equipment after a planned or unplanned interruption of power has occurred.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.4">v1.4</see></item>
		/// </list>
		/// </remarks>

		POWER_ON,
		/// <summary>﻿<see cref="Observation.result">result in Observation</see> was reset at the end of a work shift.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.4">v1.4</see></item>
		/// </list>
		/// </remarks>

		SHIFT,
		/// <summary>﻿<see cref="Observation.result">result in Observation</see> was reset at the end of a 7-day period.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.4">v1.4</see></item>
		/// </list>
		/// </remarks>

		WEEK,
	}

	/// <summary>﻿
	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Enumeration___19_0_3_45f01b9_1579566531118_10952_25736">model.mtconnect.org</seealso> for more information.
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public sealed class ResetTriggeredEnumMetaClass : IEnum
	{
		/// <summary>Constant value for <see cref="ResetTriggeredEnumMetaClass.ReferenceId" /></summary>
		public const string REFERENCE_ID = "_19_0_3_45f01b9_1579566531118_10952_25736";
		/// <summary>Constant value for <see cref="ResetTriggeredEnumMetaClass.HelpUrl" /></summary>
		public const string HELP_URL = "https://model.mtconnect.org/#Enumeration___19_0_3_45f01b9_1579566531118_10952_25736";
		/// <summary>Constant value for <see cref="ResetTriggeredEnumMetaClass.Name" /></summary>
		public const string NAME = "ResetTriggeredEnum";
		/// <summary>Constant value for <see cref="ResetTriggeredEnumMetaClass.NormativeVersion" /></summary>
		public const string NORMATIVE_VERSION = "1.4";
		/// <summary>Constant value for <see cref="ResetTriggeredEnumMetaClass.DeprecatedVersion" /></summary>
		public const string DEPRECATED_VERSION = "";
		/// <summary>Constant value for <see cref="ResetTriggeredEnumMetaClass.Summary" /></summary>
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
		public Type Instance => typeof(ResetTriggeredEnum);

		/// <inheritdoc />
		public string NormativeVersion => NORMATIVE_VERSION;
		
		/// <inheritdoc />
		public string DeprecatedVersion => DEPRECATED_VERSION;
		
		/// <inheritdoc />
		public string Summary => SUMMARY;
		
		/// <inheritdoc />
		public IEnumInstance[] Values => new IEnumInstance[] {
		ACTION_COMPLETE,
		ANNUAL,
		DAY,
		MAINTENANCE,
		MANUAL,
		MONTH,
		POWER_ON,
		SHIFT,
		WEEK,
		};

		private ACTION_COMPLETEValue _ACTION_COMPLETE;
		/// <inheritdoc cref="ACTION_COMPLETEValue" path="/summary" />
		public ACTION_COMPLETEValue ACTION_COMPLETE => _ACTION_COMPLETE ?? (_ACTION_COMPLETE = new ACTION_COMPLETEValue());

		/// <summary>﻿<see cref="Observation.result">result in Observation</see> is measuring an action or operation was reset upon completion of that action or operation.<br /><br /><br />
		/// Value for ResetTriggeredEnum.<br/>
		/// <br/>See also <seealso cref="ResetTriggeredEnum">ResetTriggeredEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.4">v1.4</see></item>
		/// </list>
		/// </remarks>

		public sealed class ACTION_COMPLETEValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="ACTION_COMPLETEValue.Name" /></summary>
			public const string NAME = "ACTION_COMPLETE";
			/// <summary>Constant value for <see cref="ACTION_COMPLETEValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.4";
			/// <summary>Constant value for <see cref="ACTION_COMPLETEValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="ACTION_COMPLETEValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;{{property(Observation::result)}} is measuring an action or operation was reset upon completion of that action or operation.&#10;
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
		private ANNUALValue _ANNUAL;
		/// <inheritdoc cref="ANNUALValue" path="/summary" />
		public ANNUALValue ANNUAL => _ANNUAL ?? (_ANNUAL = new ANNUALValue());

		/// <summary>﻿<see cref="Observation.result">result in Observation</see> was reset at the end of a 12-month period.<br /><br /><br />
		/// Value for ResetTriggeredEnum.<br/>
		/// <br/>See also <seealso cref="ResetTriggeredEnum">ResetTriggeredEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.4">v1.4</see></item>
		/// </list>
		/// </remarks>

		public sealed class ANNUALValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="ANNUALValue.Name" /></summary>
			public const string NAME = "ANNUAL";
			/// <summary>Constant value for <see cref="ANNUALValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.4";
			/// <summary>Constant value for <see cref="ANNUALValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="ANNUALValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;{{property(Observation::result)}} was reset at the end of a 12-month period.&#10;
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
		private DAYValue _DAY;
		/// <inheritdoc cref="DAYValue" path="/summary" />
		public DAYValue DAY => _DAY ?? (_DAY = new DAYValue());

		/// <summary>﻿<see cref="Observation.result">result in Observation</see> was reset at the end of a 24-hour period.<br /><br /><br />
		/// Value for ResetTriggeredEnum.<br/>
		/// <br/>See also <seealso cref="ResetTriggeredEnum">ResetTriggeredEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.4">v1.4</see></item>
		/// </list>
		/// </remarks>

		public sealed class DAYValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="DAYValue.Name" /></summary>
			public const string NAME = "DAY";
			/// <summary>Constant value for <see cref="DAYValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.4";
			/// <summary>Constant value for <see cref="DAYValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="DAYValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;{{property(Observation::result)}} was reset at the end of a 24-hour period.&#10;
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
		private MAINTENANCEValue _MAINTENANCE;
		/// <inheritdoc cref="MAINTENANCEValue" path="/summary" />
		public MAINTENANCEValue MAINTENANCE => _MAINTENANCE ?? (_MAINTENANCE = new MAINTENANCEValue());

		/// <summary>﻿<see cref="Observation.result">result in Observation</see> was reset upon completion of a maintenance event.<br /><br /><br />
		/// Value for ResetTriggeredEnum.<br/>
		/// <br/>See also <seealso cref="ResetTriggeredEnum">ResetTriggeredEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.4">v1.4</see></item>
		/// </list>
		/// </remarks>

		public sealed class MAINTENANCEValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="MAINTENANCEValue.Name" /></summary>
			public const string NAME = "MAINTENANCE";
			/// <summary>Constant value for <see cref="MAINTENANCEValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.4";
			/// <summary>Constant value for <see cref="MAINTENANCEValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="MAINTENANCEValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;{{property(Observation::result)}} was reset upon completion of a maintenance event.&#10;
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

		/// <summary>﻿<see cref="Observation.result">result in Observation</see> was reset based on a physical reset action.<br /><br /><br />
		/// Value for ResetTriggeredEnum.<br/>
		/// <br/>See also <seealso cref="ResetTriggeredEnum">ResetTriggeredEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.4">v1.4</see></item>
		/// </list>
		/// </remarks>

		public sealed class MANUALValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="MANUALValue.Name" /></summary>
			public const string NAME = "MANUAL";
			/// <summary>Constant value for <see cref="MANUALValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.4";
			/// <summary>Constant value for <see cref="MANUALValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="MANUALValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;{{property(Observation::result)}} was reset based on a physical reset action.&#10;
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
		private MONTHValue _MONTH;
		/// <inheritdoc cref="MONTHValue" path="/summary" />
		public MONTHValue MONTH => _MONTH ?? (_MONTH = new MONTHValue());

		/// <summary>﻿<see cref="Observation.result">result in Observation</see> was reset at the end of a monthly period.<br /><br /><br />
		/// Value for ResetTriggeredEnum.<br/>
		/// <br/>See also <seealso cref="ResetTriggeredEnum">ResetTriggeredEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.4">v1.4</see></item>
		/// </list>
		/// </remarks>

		public sealed class MONTHValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="MONTHValue.Name" /></summary>
			public const string NAME = "MONTH";
			/// <summary>Constant value for <see cref="MONTHValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.4";
			/// <summary>Constant value for <see cref="MONTHValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="MONTHValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;{{property(Observation::result)}} was reset at the end of a monthly period.&#10;
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
		private POWER_ONValue _POWER_ON;
		/// <inheritdoc cref="POWER_ONValue" path="/summary" />
		public POWER_ONValue POWER_ON => _POWER_ON ?? (_POWER_ON = new POWER_ONValue());

		/// <summary>﻿<see cref="Observation.result">result in Observation</see> was reset when power was applied to the piece of equipment after a planned or unplanned interruption of power has occurred.<br /><br /><br />
		/// Value for ResetTriggeredEnum.<br/>
		/// <br/>See also <seealso cref="ResetTriggeredEnum">ResetTriggeredEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.4">v1.4</see></item>
		/// </list>
		/// </remarks>

		public sealed class POWER_ONValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="POWER_ONValue.Name" /></summary>
			public const string NAME = "POWER_ON";
			/// <summary>Constant value for <see cref="POWER_ONValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.4";
			/// <summary>Constant value for <see cref="POWER_ONValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="POWER_ONValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;{{property(Observation::result)}} was reset when power was applied to the piece of equipment after a planned or unplanned interruption of power has occurred.&#10;
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
		private SHIFTValue _SHIFT;
		/// <inheritdoc cref="SHIFTValue" path="/summary" />
		public SHIFTValue SHIFT => _SHIFT ?? (_SHIFT = new SHIFTValue());

		/// <summary>﻿<see cref="Observation.result">result in Observation</see> was reset at the end of a work shift.<br /><br /><br />
		/// Value for ResetTriggeredEnum.<br/>
		/// <br/>See also <seealso cref="ResetTriggeredEnum">ResetTriggeredEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.4">v1.4</see></item>
		/// </list>
		/// </remarks>

		public sealed class SHIFTValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="SHIFTValue.Name" /></summary>
			public const string NAME = "SHIFT";
			/// <summary>Constant value for <see cref="SHIFTValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.4";
			/// <summary>Constant value for <see cref="SHIFTValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="SHIFTValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;{{property(Observation::result)}} was reset at the end of a work shift.&#10;
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
		private WEEKValue _WEEK;
		/// <inheritdoc cref="WEEKValue" path="/summary" />
		public WEEKValue WEEK => _WEEK ?? (_WEEK = new WEEKValue());

		/// <summary>﻿<see cref="Observation.result">result in Observation</see> was reset at the end of a 7-day period.<br /><br /><br />
		/// Value for ResetTriggeredEnum.<br/>
		/// <br/>See also <seealso cref="ResetTriggeredEnum">ResetTriggeredEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.4">v1.4</see></item>
		/// </list>
		/// </remarks>

		public sealed class WEEKValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="WEEKValue.Name" /></summary>
			public const string NAME = "WEEK";
			/// <summary>Constant value for <see cref="WEEKValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.4";
			/// <summary>Constant value for <see cref="WEEKValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="WEEKValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;{{property(Observation::result)}} was reset at the end of a 7-day period.&#10;
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