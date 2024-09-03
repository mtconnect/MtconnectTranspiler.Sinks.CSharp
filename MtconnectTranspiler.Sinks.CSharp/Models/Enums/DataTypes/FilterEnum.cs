#pragma warning disable CS1574 // XML comment has cref attribute that could not be resolved
#pragma warning disable CS1584 // XML comment has syntactically incorrect cref attribute
#pragma warning disable CS0618 // Type or member is obsolete
using System;
using System.CodeDom.Compiler;using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;

namespace Mtconnect.DataTypes
{
	/// <summary>﻿
	/// <br/> Visit <seealso href="https://model.mtconnect.org/#Enumeration__EAID_EF8EFACB_B3D8_4199_B5D5_84735797D463">model.mtconnect.org</seealso> for more information.
	/// </summary>
	/// <remarks>
	/// <list type="bullet">
	/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.3">v1.3</see></item>
	/// </list>
	/// </remarks>

	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public enum FilterEnum
	{
		/// <summary>﻿new value <b>MUST NOT</b> be reported for a data item unless the measured value has changed from the last reported value by at least the delta given as the value of this element.<br /><br />The value of <see cref="Filter">Filter</see> <b>MUST</b> be an absolute value using the same units as the reported data.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.3">v1.3</see></item>
		/// </list>
		/// </remarks>

		MINIMUM_DELTA,
		/// <summary>﻿data reported for a data item is provided on a periodic basis. The <c>PERIOD</c> for reporting data is defined in the value of the <see cref="Filter">Filter</see>.<br /><br />The value of <see cref="Filter">Filter</see> <b>MUST</b> be an absolute value reported in seconds representing the time between reported samples of the value of the data item.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.3">v1.3</see></item>
		/// </list>
		/// </remarks>

		PERIOD,
	}

	/// <summary>﻿
	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Enumeration__EAID_EF8EFACB_B3D8_4199_B5D5_84735797D463">model.mtconnect.org</seealso> for more information.
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public sealed class FilterEnumMetaClass : IEnum
	{
		/// <summary>Constant value for <see cref="FilterEnumMetaClass.ReferenceId" /></summary>
		public const string REFERENCE_ID = "EAID_EF8EFACB_B3D8_4199_B5D5_84735797D463";
		/// <summary>Constant value for <see cref="FilterEnumMetaClass.HelpUrl" /></summary>
		public const string HELP_URL = "https://model.mtconnect.org/#Enumeration__EAID_EF8EFACB_B3D8_4199_B5D5_84735797D463";
		/// <summary>Constant value for <see cref="FilterEnumMetaClass.Name" /></summary>
		public const string NAME = "FilterEnum";
		/// <summary>Constant value for <see cref="FilterEnumMetaClass.NormativeVersion" /></summary>
		public const string NORMATIVE_VERSION = "1.3";
		/// <summary>Constant value for <see cref="FilterEnumMetaClass.DeprecatedVersion" /></summary>
		public const string DEPRECATED_VERSION = "";
		/// <summary>Constant value for <see cref="FilterEnumMetaClass.Summary" /></summary>
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
		public Type Instance => typeof(FilterEnum);

		/// <inheritdoc />
		public string NormativeVersion => NORMATIVE_VERSION;
		
		/// <inheritdoc />
		public string DeprecatedVersion => DEPRECATED_VERSION;
		
		/// <inheritdoc />
		public string Summary => SUMMARY;
		
		/// <inheritdoc />
		public IEnumInstance[] Values => new IEnumInstance[] {
		MINIMUM_DELTA,
		PERIOD,
		};

		private MINIMUM_DELTAValue _MINIMUM_DELTA;
		/// <inheritdoc cref="MINIMUM_DELTAValue" path="/summary" />
		public MINIMUM_DELTAValue MINIMUM_DELTA => _MINIMUM_DELTA ?? (_MINIMUM_DELTA = new MINIMUM_DELTAValue());

		/// <summary>﻿new value <b>MUST NOT</b> be reported for a data item unless the measured value has changed from the last reported value by at least the delta given as the value of this element.<br /><br />The value of <see cref="Filter">Filter</see> <b>MUST</b> be an absolute value using the same units as the reported data.<br /><br /><br />
		/// Value for FilterEnum.<br/>
		/// <br/>See also <seealso cref="FilterEnum">FilterEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.3">v1.3</see></item>
		/// </list>
		/// </remarks>

		public sealed class MINIMUM_DELTAValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="MINIMUM_DELTAValue.Name" /></summary>
			public const string NAME = "MINIMUM_DELTA";
			/// <summary>Constant value for <see cref="MINIMUM_DELTAValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.3";
			/// <summary>Constant value for <see cref="MINIMUM_DELTAValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="MINIMUM_DELTAValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;new value **MUST NOT** be reported for a data item unless the measured value has changed from the last reported value by at least the delta given as the value of this element.

The value of {{block(Filter)}} **MUST** be an absolute value using the same units as the reported data.&#10;
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
		private PERIODValue _PERIOD;
		/// <inheritdoc cref="PERIODValue" path="/summary" />
		public PERIODValue PERIOD => _PERIOD ?? (_PERIOD = new PERIODValue());

		/// <summary>﻿data reported for a data item is provided on a periodic basis. The <c>PERIOD</c> for reporting data is defined in the value of the <see cref="Filter">Filter</see>.<br /><br />The value of <see cref="Filter">Filter</see> <b>MUST</b> be an absolute value reported in seconds representing the time between reported samples of the value of the data item.<br /><br /><br />
		/// Value for FilterEnum.<br/>
		/// <br/>See also <seealso cref="FilterEnum">FilterEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.3">v1.3</see></item>
		/// </list>
		/// </remarks>

		public sealed class PERIODValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="PERIODValue.Name" /></summary>
			public const string NAME = "PERIOD";
			/// <summary>Constant value for <see cref="PERIODValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.4";
			/// <summary>Constant value for <see cref="PERIODValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="PERIODValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;data reported for a data item is provided on a periodic basis. The `PERIOD` for reporting data is defined in the value of the {{block(Filter)}}.

The value of {{block(Filter)}} **MUST** be an absolute value reported in seconds representing the time between reported samples of the value of the data item.&#10;
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