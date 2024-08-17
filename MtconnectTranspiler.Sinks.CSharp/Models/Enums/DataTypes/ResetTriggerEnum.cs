#pragma warning disable CS1574 // XML comment has cref attribute that could not be resolved
#pragma warning disable CS1584 // XML comment has syntactically incorrect cref attribute
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
		/// <inheritdoc />
		public string Name => "ResetTriggerEnum";
		
		/// <inheritdoc />
		public Type DataType => null;
		
		/// <inheritdoc />
		public Type Instance => typeof(ResetTriggerEnum);

		/// <inheritdoc />
		public string NormativeVersion => "1.4";
		
		/// <inheritdoc />
		public string DeprecatedVersion => "";
		
		/// <inheritdoc />
		public string Summary => @"";
		
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
		public sealed class ACTION_COMPLETEValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "ACTION_COMPLETE";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.4";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"&#10;&#10;&#10;{{term(observation)}} of the {{block(DataItem)}} that is measuring an action or operation is to be reset upon completion of that action or operation.&#10;
";
		}
		private ANNUALValue _ANNUAL;
		/// <inheritdoc cref="ANNUALValue" path="/summary" />
		public ANNUALValue ANNUAL => _ANNUAL ?? (_ANNUAL = new ANNUALValue());

		/// <summary>﻿<i>observation</i> of the <see cref="DataItem">DataItem</see> is to be reset at the end of a 12-month period.<br /><br /><br />
		/// Value for ResetTriggerEnum.<br/>
		/// <br/>See also <seealso cref="ResetTriggerEnum">ResetTriggerEnum</seealso>
		/// </summary>
		public sealed class ANNUALValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "ANNUAL";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.4";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"&#10;&#10;&#10;{{term(observation)}} of the {{block(DataItem)}} is to be reset at the end of a 12-month period.&#10;
";
		}
		private DAYValue _DAY;
		/// <inheritdoc cref="DAYValue" path="/summary" />
		public DAYValue DAY => _DAY ?? (_DAY = new DAYValue());

		/// <summary>﻿<i>observation</i> of the <see cref="DataItem">DataItem</see> is to be reset at the end of a 24-hour period.<br /><br /><br />
		/// Value for ResetTriggerEnum.<br/>
		/// <br/>See also <seealso cref="ResetTriggerEnum">ResetTriggerEnum</seealso>
		/// </summary>
		public sealed class DAYValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "DAY";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.4";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"&#10;&#10;&#10;{{term(observation)}} of the {{block(DataItem)}} is to be reset at the end of a 24-hour period.&#10;
";
		}
		private LIFEValue _LIFE;
		/// <inheritdoc cref="LIFEValue" path="/summary" />
		public LIFEValue LIFE => _LIFE ?? (_LIFE = new LIFEValue());

		/// <summary>﻿<i>observation</i> of the <see cref="DataItem">DataItem</see> is not reset and accumulates for the entire life of the piece of equipment.<br /><br /><br />
		/// Value for ResetTriggerEnum.<br/>
		/// <br/>See also <seealso cref="ResetTriggerEnum">ResetTriggerEnum</seealso>
		/// </summary>
		public sealed class LIFEValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "LIFE";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.4";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"&#10;&#10;&#10;{{term(observation)}} of the {{block(DataItem)}} is not reset and accumulates for the entire life of the piece of equipment.&#10;
";
		}
		private MAINTENANCEValue _MAINTENANCE;
		/// <inheritdoc cref="MAINTENANCEValue" path="/summary" />
		public MAINTENANCEValue MAINTENANCE => _MAINTENANCE ?? (_MAINTENANCE = new MAINTENANCEValue());

		/// <summary>﻿<i>observation</i> of the <see cref="DataItem">DataItem</see> is to be reset upon completion of a maintenance event.<br /><br /><br />
		/// Value for ResetTriggerEnum.<br/>
		/// <br/>See also <seealso cref="ResetTriggerEnum">ResetTriggerEnum</seealso>
		/// </summary>
		public sealed class MAINTENANCEValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "MAINTENANCE";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.4";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"&#10;&#10;&#10;{{term(observation)}} of the {{block(DataItem)}} is to be reset upon completion of a maintenance event.&#10;
";
		}
		private MONTHValue _MONTH;
		/// <inheritdoc cref="MONTHValue" path="/summary" />
		public MONTHValue MONTH => _MONTH ?? (_MONTH = new MONTHValue());

		/// <summary>﻿<i>observation</i> of the <see cref="DataItem">DataItem</see> is to be reset at the end of a monthly period.<br /><br /><br />
		/// Value for ResetTriggerEnum.<br/>
		/// <br/>See also <seealso cref="ResetTriggerEnum">ResetTriggerEnum</seealso>
		/// </summary>
		public sealed class MONTHValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "MONTH";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.4";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"&#10;&#10;&#10;{{term(observation)}} of the {{block(DataItem)}} is to be reset at the end of a monthly period.&#10;
";
		}
		private POWER_ONValue _POWER_ON;
		/// <inheritdoc cref="POWER_ONValue" path="/summary" />
		public POWER_ONValue POWER_ON => _POWER_ON ?? (_POWER_ON = new POWER_ONValue());

		/// <summary>﻿<i>observation</i> of the <see cref="DataItem">DataItem</see> is to be reset when power was applied to the piece of equipment after a planned or unplanned interruption of power has occurred.<br /><br /><br />
		/// Value for ResetTriggerEnum.<br/>
		/// <br/>See also <seealso cref="ResetTriggerEnum">ResetTriggerEnum</seealso>
		/// </summary>
		public sealed class POWER_ONValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "POWER_ON";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.4";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"&#10;&#10;&#10;{{term(observation)}} of the {{block(DataItem)}} is to be reset when power was applied to the piece of equipment after a planned or unplanned interruption of power has occurred.&#10;
";
		}
		private SHIFTValue _SHIFT;
		/// <inheritdoc cref="SHIFTValue" path="/summary" />
		public SHIFTValue SHIFT => _SHIFT ?? (_SHIFT = new SHIFTValue());

		/// <summary>﻿<i>observation</i> of the <see cref="DataItem">DataItem</see> is to be reset at the end of a work shift.<br /><br /><br />
		/// Value for ResetTriggerEnum.<br/>
		/// <br/>See also <seealso cref="ResetTriggerEnum">ResetTriggerEnum</seealso>
		/// </summary>
		public sealed class SHIFTValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "SHIFT";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.4";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"&#10;&#10;&#10;{{term(observation)}} of the {{block(DataItem)}} is to be reset at the end of a work shift.&#10;
";
		}
		private WEEKValue _WEEK;
		/// <inheritdoc cref="WEEKValue" path="/summary" />
		public WEEKValue WEEK => _WEEK ?? (_WEEK = new WEEKValue());

		/// <summary>﻿<i>observation</i> of the <see cref="DataItem">DataItem</see> is to be reset at the end of a 7-day period.<br /><br /><br />
		/// Value for ResetTriggerEnum.<br/>
		/// <br/>See also <seealso cref="ResetTriggerEnum">ResetTriggerEnum</seealso>
		/// </summary>
		public sealed class WEEKValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "WEEK";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.4";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"&#10;&#10;&#10;{{term(observation)}} of the {{block(DataItem)}} is to be reset at the end of a 7-day period.&#10;
";
		}
	}
}