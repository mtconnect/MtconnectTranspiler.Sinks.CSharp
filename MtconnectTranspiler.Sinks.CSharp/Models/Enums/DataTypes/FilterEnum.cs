using System;
using System.CodeDom.Compiler;using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;

namespace Mtconnect.DataTypes
{
	/// <summary>
	/// View in the MTConnect Model browser <seealso href="https://model.mtconnect.org/#Enumeration__EAID_EF8EFACB_B3D8_4199_B5D5_84735797D463">model.mtconnect.org</seealso>
	﻿
	/// </summary>
	/// <remarks>
	/// <list type="bullet">
	/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.3">v1.3</see></item>
	/// </list>
	/// </remarks>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public enum FilterEnum
	{
		/// <summary>
		﻿/// new value <b>MUST NOT</b> be reported for a data item unless the measured value has changed from the last reported value by at least the delta given as the value of this element.<br /><br />The value of <see cref="Filter">Filter</see> <b>MUST</b> be an absolute value using the same units as the reported data.<br/><br />

		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.3">v1.3</see></item>
		/// </list>
		/// </remarks>
		MINIMUM_DELTA,
		/// <summary>
		﻿/// data reported for a data item is provided on a periodic basis. The <c>PERIOD</c> for reporting data is defined in the value of the <see cref="Filter">Filter</see>.<br /><br />The value of <see cref="Filter">Filter</see> <b>MUST</b> be an absolute value reported in seconds representing the time between reported samples of the value of the data item.<br/><br />

		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.4">v1.4</see></item>
		/// </list>
		/// </remarks>
		PERIOD,
	}

	/// <summary>
	/// View in the MTConnect Model browser <seealso href="https://model.mtconnect.org/#Enumeration__EAID_EF8EFACB_B3D8_4199_B5D5_84735797D463">model.mtconnect.org</seealso>
	﻿
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public sealed class FilterEnumMetaClass : IEnum
	{
		/// <inheritdoc />
		public string Name => "FilterEnum";
		
		/// <inheritdoc />
		public Type DataType => null;
		
		public Type Instance => typeof(FilterEnum);

		/// <inheritdoc />
		public string NormativeVersion => "1.3";
		
		/// <inheritdoc />
		public string DeprecatedVersion => "";
		
		/// <inheritdoc />
		public string Summary => @"";
		
		/// <inheritdoc />
		public IEnumInstance[] Values => new IEnumInstance[] {
		MINIMUM_DELTA,
		PERIOD,
		};

		private MINIMUM_DELTAValue _MINIMUM_DELTA;
		/// <summary>
		﻿/// new value <b>MUST NOT</b> be reported for a data item unless the measured value has changed from the last reported value by at least the delta given as the value of this element.<br /><br />The value of <see cref="Filter">Filter</see> <b>MUST</b> be an absolute value using the same units as the reported data.<br/><br />

		/// </summary>
		public MINIMUM_DELTAValue MINIMUM_DELTA => _MINIMUM_DELTA ?? (_MINIMUM_DELTA = new MINIMUM_DELTAValue());

		/// <summary>
		﻿/// new value <b>MUST NOT</b> be reported for a data item unless the measured value has changed from the last reported value by at least the delta given as the value of this element.<br /><br />The value of <see cref="Filter">Filter</see> <b>MUST</b> be an absolute value using the same units as the reported data.<br/><br />

		/// </summary>
		public sealed class MINIMUM_DELTAValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "MINIMUM_DELTA";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.3";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"&#10;&#10;&#10;new value **MUST NOT** be reported for a data item unless the measured value has changed from the last reported value by at least the delta given as the value of this element.

The value of {{block(Filter)}} **MUST** be an absolute value using the same units as the reported data.&#10;
";
		}
		private PERIODValue _PERIOD;
		/// <summary>
		﻿/// data reported for a data item is provided on a periodic basis. The <c>PERIOD</c> for reporting data is defined in the value of the <see cref="Filter">Filter</see>.<br /><br />The value of <see cref="Filter">Filter</see> <b>MUST</b> be an absolute value reported in seconds representing the time between reported samples of the value of the data item.<br/><br />

		/// </summary>
		public PERIODValue PERIOD => _PERIOD ?? (_PERIOD = new PERIODValue());

		/// <summary>
		﻿/// data reported for a data item is provided on a periodic basis. The <c>PERIOD</c> for reporting data is defined in the value of the <see cref="Filter">Filter</see>.<br /><br />The value of <see cref="Filter">Filter</see> <b>MUST</b> be an absolute value reported in seconds representing the time between reported samples of the value of the data item.<br/><br />

		/// </summary>
		public sealed class PERIODValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "PERIOD";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.4";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"&#10;&#10;&#10;data reported for a data item is provided on a periodic basis. The `PERIOD` for reporting data is defined in the value of the {{block(Filter)}}.

The value of {{block(Filter)}} **MUST** be an absolute value reported in seconds representing the time between reported samples of the value of the data item.&#10;
";
		}
	}
}