using System;
using System.CodeDom.Compiler;using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;

namespace Mtconnect.DataTypes
{
	/// <summary>
	/// View in the MTConnect Model browser <seealso href="https://model.mtconnect.org/#Enumeration___19_0_3_45f01b9_1579566531118_10952_25736">model.mtconnect.org</seealso>
	/// </summary>
	/// <remarks>
	/// <list type="bullet">
	/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.4">v1.4</see></item>
	/// </list>
	/// </remarks>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.3.0.0")]
	public enum ResetTriggeredEnum
	{
		/// <summary>
		/// <see cref="Observation::result" /> is measuring an action or operation was reset upon completion of that action or operation.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.4">v1.4</see></item>
		/// </list>
		/// </remarks>
		ACTION_COMPLETE,
		/// <summary>
		/// <see cref="Observation::result" /> was reset at the end of a 12-month period.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.4">v1.4</see></item>
		/// </list>
		/// </remarks>
		ANNUAL,
		/// <summary>
		/// <see cref="Observation::result" /> was reset at the end of a 24-hour period.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.4">v1.4</see></item>
		/// </list>
		/// </remarks>
		DAY,
		/// <summary>
		/// <see cref="Observation::result" /> was reset upon completion of a maintenance event.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.4">v1.4</see></item>
		/// </list>
		/// </remarks>
		MAINTENANCE,
		/// <summary>
		/// <see cref="Observation::result" /> was reset based on a physical reset action.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.4">v1.4</see></item>
		/// </list>
		/// </remarks>
		MANUAL,
		/// <summary>
		/// <see cref="Observation::result" /> was reset at the end of a monthly period.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.4">v1.4</see></item>
		/// </list>
		/// </remarks>
		MONTH,
		/// <summary>
		/// <see cref="Observation::result" /> was reset when power was applied to the piece of equipment after a planned or unplanned interruption of power has occurred.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.4">v1.4</see></item>
		/// </list>
		/// </remarks>
		POWER_ON,
		/// <summary>
		/// <see cref="Observation::result" /> was reset at the end of a work shift.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.4">v1.4</see></item>
		/// </list>
		/// </remarks>
		SHIFT,
		/// <summary>
		/// <see cref="Observation::result" /> was reset at the end of a 7-day period.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.4">v1.4</see></item>
		/// </list>
		/// </remarks>
		WEEK,
	}

	/// <summary>
	/// View in the MTConnect Model browser <seealso href="https://model.mtconnect.org/#Enumeration___19_0_3_45f01b9_1579566531118_10952_25736">model.mtconnect.org</seealso>
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.3.0.0")]
	public sealed class ResetTriggeredEnumMetaClass : IEnum
	{
		/// <inheritdoc />
		public string Name => "ResetTriggeredEnum";
		
		/// <inheritdoc />
		public Type DataType => null;
		
		public Type Instance => typeof(ResetTriggeredEnum);

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
		MAINTENANCE,
		MANUAL,
		MONTH,
		POWER_ON,
		SHIFT,
		WEEK,
		};

		private ACTION_COMPLETEValue _ACTION_COMPLETE;
		/// <summary>
		/// <see cref="Observation::result" /> is measuring an action or operation was reset upon completion of that action or operation.
		/// </summary>
		public ACTION_COMPLETEValue ACTION_COMPLETE => _ACTION_COMPLETE ?? (_ACTION_COMPLETE = new ACTION_COMPLETEValue());

		/// <summary>
		/// <see cref="Observation::result" /> is measuring an action or operation was reset upon completion of that action or operation.
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
			public string Summary => @"/// <see cref=""Observation::result"" /> is measuring an action or operation was reset upon completion of that action or operation.";
		}
		private ANNUALValue _ANNUAL;
		/// <summary>
		/// <see cref="Observation::result" /> was reset at the end of a 12-month period.
		/// </summary>
		public ANNUALValue ANNUAL => _ANNUAL ?? (_ANNUAL = new ANNUALValue());

		/// <summary>
		/// <see cref="Observation::result" /> was reset at the end of a 12-month period.
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
			public string Summary => @"/// <see cref=""Observation::result"" /> was reset at the end of a 12-month period.";
		}
		private DAYValue _DAY;
		/// <summary>
		/// <see cref="Observation::result" /> was reset at the end of a 24-hour period.
		/// </summary>
		public DAYValue DAY => _DAY ?? (_DAY = new DAYValue());

		/// <summary>
		/// <see cref="Observation::result" /> was reset at the end of a 24-hour period.
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
			public string Summary => @"/// <see cref=""Observation::result"" /> was reset at the end of a 24-hour period.";
		}
		private MAINTENANCEValue _MAINTENANCE;
		/// <summary>
		/// <see cref="Observation::result" /> was reset upon completion of a maintenance event.
		/// </summary>
		public MAINTENANCEValue MAINTENANCE => _MAINTENANCE ?? (_MAINTENANCE = new MAINTENANCEValue());

		/// <summary>
		/// <see cref="Observation::result" /> was reset upon completion of a maintenance event.
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
			public string Summary => @"/// <see cref=""Observation::result"" /> was reset upon completion of a maintenance event.";
		}
		private MANUALValue _MANUAL;
		/// <summary>
		/// <see cref="Observation::result" /> was reset based on a physical reset action.
		/// </summary>
		public MANUALValue MANUAL => _MANUAL ?? (_MANUAL = new MANUALValue());

		/// <summary>
		/// <see cref="Observation::result" /> was reset based on a physical reset action.
		/// </summary>
		public sealed class MANUALValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "MANUAL";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.4";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// <see cref=""Observation::result"" /> was reset based on a physical reset action.";
		}
		private MONTHValue _MONTH;
		/// <summary>
		/// <see cref="Observation::result" /> was reset at the end of a monthly period.
		/// </summary>
		public MONTHValue MONTH => _MONTH ?? (_MONTH = new MONTHValue());

		/// <summary>
		/// <see cref="Observation::result" /> was reset at the end of a monthly period.
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
			public string Summary => @"/// <see cref=""Observation::result"" /> was reset at the end of a monthly period.";
		}
		private POWER_ONValue _POWER_ON;
		/// <summary>
		/// <see cref="Observation::result" /> was reset when power was applied to the piece of equipment after a planned or unplanned interruption of power has occurred.
		/// </summary>
		public POWER_ONValue POWER_ON => _POWER_ON ?? (_POWER_ON = new POWER_ONValue());

		/// <summary>
		/// <see cref="Observation::result" /> was reset when power was applied to the piece of equipment after a planned or unplanned interruption of power has occurred.
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
			public string Summary => @"/// <see cref=""Observation::result"" /> was reset when power was applied to the piece of equipment after a planned or unplanned interruption of power has occurred.";
		}
		private SHIFTValue _SHIFT;
		/// <summary>
		/// <see cref="Observation::result" /> was reset at the end of a work shift.
		/// </summary>
		public SHIFTValue SHIFT => _SHIFT ?? (_SHIFT = new SHIFTValue());

		/// <summary>
		/// <see cref="Observation::result" /> was reset at the end of a work shift.
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
			public string Summary => @"/// <see cref=""Observation::result"" /> was reset at the end of a work shift.";
		}
		private WEEKValue _WEEK;
		/// <summary>
		/// <see cref="Observation::result" /> was reset at the end of a 7-day period.
		/// </summary>
		public WEEKValue WEEK => _WEEK ?? (_WEEK = new WEEKValue());

		/// <summary>
		/// <see cref="Observation::result" /> was reset at the end of a 7-day period.
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
			public string Summary => @"/// <see cref=""Observation::result"" /> was reset at the end of a 7-day period.";
		}
	}
}