using System;
using System.CodeDom.Compiler;using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;

namespace Mtconnect.DataTypes
{
	/// <summary>
	/// View in the MTConnect Model browser <seealso href="https://model.mtconnect.org/#Enumeration__EAID_8616CF52_2918_4462_A494_9F4A3EEFD597">model.mtconnect.org</seealso>
	/// </summary>
	/// <remarks>
	/// <list type="bullet">
	/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.4">v1.4</see></item>
	/// </list>
	/// </remarks>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.3.0.0")]
	public enum ResetTriggerEnum
	{
		/// <summary>
		/// <i>observation</i> of the <see cref="DataItem">DataItem</see> that is measuring an action or operation is to be reset upon completion of that action or operation.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.4">v1.4</see></item>
		/// </list>
		/// </remarks>
		ACTION_COMPLETE,
		/// <summary>
		/// <i>observation</i> of the <see cref="DataItem">DataItem</see> is to be reset at the end of a 12-month period.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.4">v1.4</see></item>
		/// </list>
		/// </remarks>
		ANNUAL,
		/// <summary>
		/// <i>observation</i> of the <see cref="DataItem">DataItem</see> is to be reset at the end of a 24-hour period.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.4">v1.4</see></item>
		/// </list>
		/// </remarks>
		DAY,
		/// <summary>
		/// <i>observation</i> of the <see cref="DataItem">DataItem</see> is not reset and accumulates for the entire life of the piece of equipment.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.4">v1.4</see></item>
		/// </list>
		/// </remarks>
		LIFE,
		/// <summary>
		/// <i>observation</i> of the <see cref="DataItem">DataItem</see> is to be reset upon completion of a maintenance event.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.4">v1.4</see></item>
		/// </list>
		/// </remarks>
		MAINTENANCE,
		/// <summary>
		/// <i>observation</i> of the <see cref="DataItem">DataItem</see> is to be reset at the end of a monthly period.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.4">v1.4</see></item>
		/// </list>
		/// </remarks>
		MONTH,
		/// <summary>
		/// <i>observation</i> of the <see cref="DataItem">DataItem</see> is to be reset when power was applied to the piece of equipment after a planned or unplanned interruption of power has occurred.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.4">v1.4</see></item>
		/// </list>
		/// </remarks>
		POWER_ON,
		/// <summary>
		/// <i>observation</i> of the <see cref="DataItem">DataItem</see> is to be reset at the end of a work shift.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.4">v1.4</see></item>
		/// </list>
		/// </remarks>
		SHIFT,
		/// <summary>
		/// <i>observation</i> of the <see cref="DataItem">DataItem</see> is to be reset at the end of a 7-day period.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.4">v1.4</see></item>
		/// </list>
		/// </remarks>
		WEEK,
	}

	/// <summary>
	/// View in the MTConnect Model browser <seealso href="https://model.mtconnect.org/#Enumeration__EAID_8616CF52_2918_4462_A494_9F4A3EEFD597">model.mtconnect.org</seealso>
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.3.0.0")]
	public sealed class ResetTriggerEnumMetaClass : IEnum
	{
		/// <inheritdoc />
		public string Name => "ResetTriggerEnum";
		
		/// <inheritdoc />
		public Type DataType => null;
		
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
		/// <summary>
		/// <i>observation</i> of the <see cref="DataItem">DataItem</see> that is measuring an action or operation is to be reset upon completion of that action or operation.
		/// </summary>
		public ACTION_COMPLETEValue ACTION_COMPLETE => _ACTION_COMPLETE ?? (_ACTION_COMPLETE = new ACTION_COMPLETEValue());

		/// <summary>
		/// <i>observation</i> of the <see cref="DataItem">DataItem</see> that is measuring an action or operation is to be reset upon completion of that action or operation.
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
			public string Summary => @"/// <i>observation</i> of the <see cref=""DataItem"">DataItem</see> that is measuring an action or operation is to be reset upon completion of that action or operation.";
		}
		private ANNUALValue _ANNUAL;
		/// <summary>
		/// <i>observation</i> of the <see cref="DataItem">DataItem</see> is to be reset at the end of a 12-month period.
		/// </summary>
		public ANNUALValue ANNUAL => _ANNUAL ?? (_ANNUAL = new ANNUALValue());

		/// <summary>
		/// <i>observation</i> of the <see cref="DataItem">DataItem</see> is to be reset at the end of a 12-month period.
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
			public string Summary => @"/// <i>observation</i> of the <see cref=""DataItem"">DataItem</see> is to be reset at the end of a 12-month period.";
		}
		private DAYValue _DAY;
		/// <summary>
		/// <i>observation</i> of the <see cref="DataItem">DataItem</see> is to be reset at the end of a 24-hour period.
		/// </summary>
		public DAYValue DAY => _DAY ?? (_DAY = new DAYValue());

		/// <summary>
		/// <i>observation</i> of the <see cref="DataItem">DataItem</see> is to be reset at the end of a 24-hour period.
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
			public string Summary => @"/// <i>observation</i> of the <see cref=""DataItem"">DataItem</see> is to be reset at the end of a 24-hour period.";
		}
		private LIFEValue _LIFE;
		/// <summary>
		/// <i>observation</i> of the <see cref="DataItem">DataItem</see> is not reset and accumulates for the entire life of the piece of equipment.
		/// </summary>
		public LIFEValue LIFE => _LIFE ?? (_LIFE = new LIFEValue());

		/// <summary>
		/// <i>observation</i> of the <see cref="DataItem">DataItem</see> is not reset and accumulates for the entire life of the piece of equipment.
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
			public string Summary => @"/// <i>observation</i> of the <see cref=""DataItem"">DataItem</see> is not reset and accumulates for the entire life of the piece of equipment.";
		}
		private MAINTENANCEValue _MAINTENANCE;
		/// <summary>
		/// <i>observation</i> of the <see cref="DataItem">DataItem</see> is to be reset upon completion of a maintenance event.
		/// </summary>
		public MAINTENANCEValue MAINTENANCE => _MAINTENANCE ?? (_MAINTENANCE = new MAINTENANCEValue());

		/// <summary>
		/// <i>observation</i> of the <see cref="DataItem">DataItem</see> is to be reset upon completion of a maintenance event.
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
			public string Summary => @"/// <i>observation</i> of the <see cref=""DataItem"">DataItem</see> is to be reset upon completion of a maintenance event.";
		}
		private MONTHValue _MONTH;
		/// <summary>
		/// <i>observation</i> of the <see cref="DataItem">DataItem</see> is to be reset at the end of a monthly period.
		/// </summary>
		public MONTHValue MONTH => _MONTH ?? (_MONTH = new MONTHValue());

		/// <summary>
		/// <i>observation</i> of the <see cref="DataItem">DataItem</see> is to be reset at the end of a monthly period.
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
			public string Summary => @"/// <i>observation</i> of the <see cref=""DataItem"">DataItem</see> is to be reset at the end of a monthly period.";
		}
		private POWER_ONValue _POWER_ON;
		/// <summary>
		/// <i>observation</i> of the <see cref="DataItem">DataItem</see> is to be reset when power was applied to the piece of equipment after a planned or unplanned interruption of power has occurred.
		/// </summary>
		public POWER_ONValue POWER_ON => _POWER_ON ?? (_POWER_ON = new POWER_ONValue());

		/// <summary>
		/// <i>observation</i> of the <see cref="DataItem">DataItem</see> is to be reset when power was applied to the piece of equipment after a planned or unplanned interruption of power has occurred.
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
			public string Summary => @"/// <i>observation</i> of the <see cref=""DataItem"">DataItem</see> is to be reset when power was applied to the piece of equipment after a planned or unplanned interruption of power has occurred.";
		}
		private SHIFTValue _SHIFT;
		/// <summary>
		/// <i>observation</i> of the <see cref="DataItem">DataItem</see> is to be reset at the end of a work shift.
		/// </summary>
		public SHIFTValue SHIFT => _SHIFT ?? (_SHIFT = new SHIFTValue());

		/// <summary>
		/// <i>observation</i> of the <see cref="DataItem">DataItem</see> is to be reset at the end of a work shift.
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
			public string Summary => @"/// <i>observation</i> of the <see cref=""DataItem"">DataItem</see> is to be reset at the end of a work shift.";
		}
		private WEEKValue _WEEK;
		/// <summary>
		/// <i>observation</i> of the <see cref="DataItem">DataItem</see> is to be reset at the end of a 7-day period.
		/// </summary>
		public WEEKValue WEEK => _WEEK ?? (_WEEK = new WEEKValue());

		/// <summary>
		/// <i>observation</i> of the <see cref="DataItem">DataItem</see> is to be reset at the end of a 7-day period.
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
			public string Summary => @"/// <i>observation</i> of the <see cref=""DataItem"">DataItem</see> is to be reset at the end of a 7-day period.";
		}
	}
}