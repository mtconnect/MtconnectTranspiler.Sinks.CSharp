#pragma warning disable CS1574 // XML comment has cref attribute that could not be resolved
#pragma warning disable CS1584 // XML comment has syntactically incorrect cref attribute
#pragma warning disable CS0618 // Type or member is obsolete
using System;
using System.CodeDom.Compiler;using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;

namespace Mtconnect.DataTypes
{
	/// <summary>﻿
	/// <br/> Visit <seealso href="https://model.mtconnect.org/#Enumeration__EAID_8616CF52_2918_4462_A494_9F4A3EEFD597">model.mtconnect.org</seealso> for more information.
	/// </summary>
	/// <remarks>
	/// <list type="bullet">
	/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.4">v1.4</see></item>
	/// </list>
	/// </remarks>

	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public enum ResetTriggerEnum
	{
		/// <summary>﻿<i>observation</i> of the <see cref="DataItem">DataItem</see> that is measuring an action or operation is to be reset upon completion of that action or operation.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.4">v1.4</see></item>
		/// </list>
		/// </remarks>

		ACTION_COMPLETE,
		/// <summary>﻿<i>observation</i> of the <see cref="DataItem">DataItem</see> is to be reset at the end of a 12-month period.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.4">v1.4</see></item>
		/// </list>
		/// </remarks>

		ANNUAL,
		/// <summary>﻿<i>observation</i> of the <see cref="DataItem">DataItem</see> is to be reset at the end of a 24-hour period.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.4">v1.4</see></item>
		/// </list>
		/// </remarks>

		DAY,
		/// <summary>﻿<i>observation</i> of the <see cref="DataItem">DataItem</see> is not reset and accumulates for the entire life of the piece of equipment.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.4">v1.4</see></item>
		/// </list>
		/// </remarks>

		LIFE,
		/// <summary>﻿<i>observation</i> of the <see cref="DataItem">DataItem</see> is to be reset upon completion of a maintenance event.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.4">v1.4</see></item>
		/// </list>
		/// </remarks>

		MAINTENANCE,
		/// <summary>﻿<i>observation</i> of the <see cref="DataItem">DataItem</see> is to be reset at the end of a monthly period.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.4">v1.4</see></item>
		/// </list>
		/// </remarks>

		MONTH,
		/// <summary>﻿<i>observation</i> of the <see cref="DataItem">DataItem</see> is to be reset when power was applied to the piece of equipment after a planned or unplanned interruption of power has occurred.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.4">v1.4</see></item>
		/// </list>
		/// </remarks>

		POWER_ON,
		/// <summary>﻿<i>observation</i> of the <see cref="DataItem">DataItem</see> is to be reset at the end of a work shift.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.4">v1.4</see></item>
		/// </list>
		/// </remarks>

		SHIFT,
		/// <summary>﻿<i>observation</i> of the <see cref="DataItem">DataItem</see> is to be reset at the end of a 7-day period.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.4">v1.4</see></item>
		/// </list>
		/// </remarks>

		WEEK,
	}

	/// <summary>﻿
	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Enumeration__EAID_8616CF52_2918_4462_A494_9F4A3EEFD597">model.mtconnect.org</seealso> for more information.
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public sealed class ResetTriggerEnumMetaClass : IEnum
	{
		/// <summary>Constant value for <see cref="ResetTriggerEnumMetaClass.ReferenceId" /></summary>
		public const string REFERENCE_ID = "EAID_8616CF52_2918_4462_A494_9F4A3EEFD597";
		/// <summary>Constant value for <see cref="ResetTriggerEnumMetaClass.HelpUrl" /></summary>
		public const string HELP_URL = "https://model.mtconnect.org/#Enumeration__EAID_8616CF52_2918_4462_A494_9F4A3EEFD597";
		/// <summary>Constant value for <see cref="ResetTriggerEnumMetaClass.Name" /></summary>
		public const string NAME = "ResetTriggerEnum";
		/// <summary>Constant value for <see cref="ResetTriggerEnumMetaClass.NormativeVersion" /></summary>
		public const string NORMATIVE_VERSION = "1.4";
		/// <summary>Constant value for <see cref="ResetTriggerEnumMetaClass.DeprecatedVersion" /></summary>
		public const string DEPRECATED_VERSION = "";
		/// <summary>Constant value for <see cref="ResetTriggerEnumMetaClass.Summary" /></summary>
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
		public Type Instance => typeof(ResetTriggerEnum);

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
		LIFE,
		MAINTENANCE,
		MONTH,
		POWER_ON,
		SHIFT,
		WEEK,
		};

		private ACTION_COMPLETEValue _ACTION_COMPLETE;
		/// <inheritdoc cref="ACTION_COMPLETEValue" path="/summary" />
		public ACTION_COMPLETEValue ACTION_COMPLETE => _ACTION_COMPLETE ?? (_ACTION_COMPLETE = new ACTION_COMPLETEValue());

		/// <summary>﻿<i>observation</i> of the <see cref="DataItem">DataItem</see> that is measuring an action or operation is to be reset upon completion of that action or operation.<br /><br /><br />
		/// Value for ResetTriggerEnum.<br/>
		/// <br/>See also <seealso cref="ResetTriggerEnum">ResetTriggerEnum</seealso>
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
			public const string SUMMARY = @"&#10;&#10;&#10;{{term(observation)}} of the {{block(DataItem)}} that is measuring an action or operation is to be reset upon completion of that action or operation.&#10;
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

		/// <summary>﻿<i>observation</i> of the <see cref="DataItem">DataItem</see> is to be reset at the end of a 12-month period.<br /><br /><br />
		/// Value for ResetTriggerEnum.<br/>
		/// <br/>See also <seealso cref="ResetTriggerEnum">ResetTriggerEnum</seealso>
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
			public const string SUMMARY = @"&#10;&#10;&#10;{{term(observation)}} of the {{block(DataItem)}} is to be reset at the end of a 12-month period.&#10;
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

		/// <summary>﻿<i>observation</i> of the <see cref="DataItem">DataItem</see> is to be reset at the end of a 24-hour period.<br /><br /><br />
		/// Value for ResetTriggerEnum.<br/>
		/// <br/>See also <seealso cref="ResetTriggerEnum">ResetTriggerEnum</seealso>
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
			public const string SUMMARY = @"&#10;&#10;&#10;{{term(observation)}} of the {{block(DataItem)}} is to be reset at the end of a 24-hour period.&#10;
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
		private LIFEValue _LIFE;
		/// <inheritdoc cref="LIFEValue" path="/summary" />
		public LIFEValue LIFE => _LIFE ?? (_LIFE = new LIFEValue());

		/// <summary>﻿<i>observation</i> of the <see cref="DataItem">DataItem</see> is not reset and accumulates for the entire life of the piece of equipment.<br /><br /><br />
		/// Value for ResetTriggerEnum.<br/>
		/// <br/>See also <seealso cref="ResetTriggerEnum">ResetTriggerEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.4">v1.4</see></item>
		/// </list>
		/// </remarks>

		public sealed class LIFEValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="LIFEValue.Name" /></summary>
			public const string NAME = "LIFE";
			/// <summary>Constant value for <see cref="LIFEValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.4";
			/// <summary>Constant value for <see cref="LIFEValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="LIFEValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;{{term(observation)}} of the {{block(DataItem)}} is not reset and accumulates for the entire life of the piece of equipment.&#10;
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

		/// <summary>﻿<i>observation</i> of the <see cref="DataItem">DataItem</see> is to be reset upon completion of a maintenance event.<br /><br /><br />
		/// Value for ResetTriggerEnum.<br/>
		/// <br/>See also <seealso cref="ResetTriggerEnum">ResetTriggerEnum</seealso>
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
			public const string SUMMARY = @"&#10;&#10;&#10;{{term(observation)}} of the {{block(DataItem)}} is to be reset upon completion of a maintenance event.&#10;
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

		/// <summary>﻿<i>observation</i> of the <see cref="DataItem">DataItem</see> is to be reset at the end of a monthly period.<br /><br /><br />
		/// Value for ResetTriggerEnum.<br/>
		/// <br/>See also <seealso cref="ResetTriggerEnum">ResetTriggerEnum</seealso>
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
			public const string SUMMARY = @"&#10;&#10;&#10;{{term(observation)}} of the {{block(DataItem)}} is to be reset at the end of a monthly period.&#10;
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

		/// <summary>﻿<i>observation</i> of the <see cref="DataItem">DataItem</see> is to be reset when power was applied to the piece of equipment after a planned or unplanned interruption of power has occurred.<br /><br /><br />
		/// Value for ResetTriggerEnum.<br/>
		/// <br/>See also <seealso cref="ResetTriggerEnum">ResetTriggerEnum</seealso>
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
			public const string SUMMARY = @"&#10;&#10;&#10;{{term(observation)}} of the {{block(DataItem)}} is to be reset when power was applied to the piece of equipment after a planned or unplanned interruption of power has occurred.&#10;
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

		/// <summary>﻿<i>observation</i> of the <see cref="DataItem">DataItem</see> is to be reset at the end of a work shift.<br /><br /><br />
		/// Value for ResetTriggerEnum.<br/>
		/// <br/>See also <seealso cref="ResetTriggerEnum">ResetTriggerEnum</seealso>
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
			public const string SUMMARY = @"&#10;&#10;&#10;{{term(observation)}} of the {{block(DataItem)}} is to be reset at the end of a work shift.&#10;
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

		/// <summary>﻿<i>observation</i> of the <see cref="DataItem">DataItem</see> is to be reset at the end of a 7-day period.<br /><br /><br />
		/// Value for ResetTriggerEnum.<br/>
		/// <br/>See also <seealso cref="ResetTriggerEnum">ResetTriggerEnum</seealso>
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
			public const string SUMMARY = @"&#10;&#10;&#10;{{term(observation)}} of the {{block(DataItem)}} is to be reset at the end of a 7-day period.&#10;
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