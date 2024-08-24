#pragma warning disable CS1574 // XML comment has cref attribute that could not be resolved
#pragma warning disable CS1584 // XML comment has syntactically incorrect cref attribute
#pragma warning disable CS0618 // Type or member is obsolete
using System;
using System.CodeDom.Compiler;using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;

namespace Mtconnect.DataTypes
{
	/// <summary>﻿
	/// <br/> Visit <seealso href="https://model.mtconnect.org/#Enumeration__EAID_67CD6E1B_53E3_45c1_B84F_B0732F79528D">model.mtconnect.org</seealso> for more information.
	/// </summary>
	/// <remarks>
	/// <list type="bullet">
	/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.2">v1.2</see></item>
	/// </list>
	/// </remarks>

	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public enum RepresentationEnum
	{
		/// <summary>﻿series of sampled data.<br /><br />The data is reported for a specified number of samples and each sample is reported with a fixed period.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.2">v1.2</see></item>
		/// </list>
		/// </remarks>

		TIME_SERIES,
		/// <summary>﻿measured value of the sample data.<br /><br />If no <see cref="DataItem.representation">representation in DataItem</see> is specified for a data item, the <see cref="DataItem.representation">representation in DataItem</see> <b>MUST</b> be determined to be <c>VALUE</c>.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.2">v1.2</see></item>
		/// </list>
		/// </remarks>

		VALUE,
		/// <summary>﻿reported value(s) are represented as a set of <i>key-value pair</i>s.<br /><br />Each reported value in the <i>data set</i> <b>MUST</b> have a unique key.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.2">v1.2</see></item>
		/// </list>
		/// </remarks>

		DATA_SET,
		/// <summary>﻿<b>DEPRECATED</b> as <see cref="DataItem.representation">representation in DataItem</see> type in <i>MTConnect Version 1.5</i>. Replaced by the <see cref="DataItem.discrete">discrete in DataItem</see>.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.2">v1.2</see></item>
		/// </list>
		/// </remarks>

		DISCRETE,
		/// <summary>﻿two dimensional set of <i>key-value pair</i>s where the <see cref="Entry">Entry</see> represents a row, and the value is a set of <i>key-value pair</i> <see cref="Cell">Cell</see> elements. <br /><br />A <i>table</i> follows the same behavior as the <i>data set</i> for change tracking, clearing, and history. When an <see cref="Entry">Entry</see> changes, all <see cref="Cell">Cell</see> elements update as a single unit following the behavior of a <i>data set</i>.<br /><br />&gt; Note: It is best to use <see cref="Variable">Variable</see> if the <see cref="Cell">Cell</see> entities represent multiple semantic types.<br /><br />Each <see cref="Entry">Entry</see> in the <i>table</i> <b>MUST</b> have a unique key. Each <see cref="Cell">Cell</see> of each <see cref="Entry">Entry</see> in the <i>table</i> <b>MUST</b> have a unique key.<br /><br />See <see cref="Representation">Representation</see> in <see cref="Observation Information Model">Observation Information Model</see>, for a description of <see cref="Entry">Entry</see> and <see cref="Cell">Cell</see> elements.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.2">v1.2</see></item>
		/// </list>
		/// </remarks>

		TABLE,
	}

	/// <summary>﻿
	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Enumeration__EAID_67CD6E1B_53E3_45c1_B84F_B0732F79528D">model.mtconnect.org</seealso> for more information.
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public sealed class RepresentationEnumMetaClass : IEnum
	{
		/// <summary>Constant value for <see cref="RepresentationEnumMetaClass.ReferenceId" /></summary>
		public const string REFERENCE_ID = "EAID_67CD6E1B_53E3_45c1_B84F_B0732F79528D";
		/// <summary>Constant value for <see cref="RepresentationEnumMetaClass.HelpUrl" /></summary>
		public const string HELP_URL = "https://model.mtconnect.org/#Enumeration__EAID_67CD6E1B_53E3_45c1_B84F_B0732F79528D";
		/// <summary>Constant value for <see cref="RepresentationEnumMetaClass.Name" /></summary>
		public const string NAME = "RepresentationEnum";
		/// <summary>Constant value for <see cref="RepresentationEnumMetaClass.NormativeVersion" /></summary>
		public const string NORMATIVE_VERSION = "1.2";
		/// <summary>Constant value for <see cref="RepresentationEnumMetaClass.DeprecatedVersion" /></summary>
		public const string DEPRECATED_VERSION = "";
		/// <summary>Constant value for <see cref="RepresentationEnumMetaClass.Summary" /></summary>
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
		public Type Instance => typeof(RepresentationEnum);

		/// <inheritdoc />
		public string NormativeVersion => NORMATIVE_VERSION;
		
		/// <inheritdoc />
		public string DeprecatedVersion => DEPRECATED_VERSION;
		
		/// <inheritdoc />
		public string Summary => SUMMARY;
		
		/// <inheritdoc />
		public IEnumInstance[] Values => new IEnumInstance[] {
		TIME_SERIES,
		VALUE,
		DATA_SET,
		DISCRETE,
		TABLE,
		};

		private TIME_SERIESValue _TIME_SERIES;
		/// <inheritdoc cref="TIME_SERIESValue" path="/summary" />
		public TIME_SERIESValue TIME_SERIES => _TIME_SERIES ?? (_TIME_SERIES = new TIME_SERIESValue());

		/// <summary>﻿series of sampled data.<br /><br />The data is reported for a specified number of samples and each sample is reported with a fixed period.<br /><br /><br />
		/// Value for RepresentationEnum.<br/>
		/// <br/>See also <seealso cref="RepresentationEnum">RepresentationEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.2">v1.2</see></item>
		/// </list>
		/// </remarks>

		public sealed class TIME_SERIESValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="TIME_SERIESValue.Name" /></summary>
			public const string NAME = "TIME_SERIES";
			/// <summary>Constant value for <see cref="TIME_SERIESValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.2";
			/// <summary>Constant value for <see cref="TIME_SERIESValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="TIME_SERIESValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;series of sampled data.

The data is reported for a specified number of samples and each sample is reported with a fixed period.&#10;
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
		private VALUEValue _VALUE;
		/// <inheritdoc cref="VALUEValue" path="/summary" />
		public VALUEValue VALUE => _VALUE ?? (_VALUE = new VALUEValue());

		/// <summary>﻿measured value of the sample data.<br /><br />If no <see cref="DataItem.representation">representation in DataItem</see> is specified for a data item, the <see cref="DataItem.representation">representation in DataItem</see> <b>MUST</b> be determined to be <c>VALUE</c>.<br /><br /><br />
		/// Value for RepresentationEnum.<br/>
		/// <br/>See also <seealso cref="RepresentationEnum">RepresentationEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.2">v1.2</see></item>
		/// </list>
		/// </remarks>

		public sealed class VALUEValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="VALUEValue.Name" /></summary>
			public const string NAME = "VALUE";
			/// <summary>Constant value for <see cref="VALUEValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.2";
			/// <summary>Constant value for <see cref="VALUEValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="VALUEValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;measured value of the sample data.

If no {{property(DataItem::representation)}} is specified for a data item, the {{property(DataItem::representation)}} **MUST** be determined to be `VALUE`.&#10;
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
		private DATA_SETValue _DATA_SET;
		/// <inheritdoc cref="DATA_SETValue" path="/summary" />
		public DATA_SETValue DATA_SET => _DATA_SET ?? (_DATA_SET = new DATA_SETValue());

		/// <summary>﻿reported value(s) are represented as a set of <i>key-value pair</i>s.<br /><br />Each reported value in the <i>data set</i> <b>MUST</b> have a unique key.<br /><br /><br />
		/// Value for RepresentationEnum.<br/>
		/// <br/>See also <seealso cref="RepresentationEnum">RepresentationEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.2">v1.2</see></item>
		/// </list>
		/// </remarks>

		public sealed class DATA_SETValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="DATA_SETValue.Name" /></summary>
			public const string NAME = "DATA_SET";
			/// <summary>Constant value for <see cref="DATA_SETValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.5";
			/// <summary>Constant value for <see cref="DATA_SETValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="DATA_SETValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;reported value(s) are represented as a set of {{termplural(key-value pair)}}.

Each reported value in the {{term(data set)}} **MUST** have a unique key.&#10;
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
		private DISCRETEValue _DISCRETE;
		/// <inheritdoc cref="DISCRETEValue" path="/summary" />
		public DISCRETEValue DISCRETE => _DISCRETE ?? (_DISCRETE = new DISCRETEValue());

		/// <summary>﻿<b>DEPRECATED</b> as <see cref="DataItem.representation">representation in DataItem</see> type in <i>MTConnect Version 1.5</i>. Replaced by the <see cref="DataItem.discrete">discrete in DataItem</see>.<br /><br /><br />
		/// Value for RepresentationEnum.<br/>
		/// <br/>See also <seealso cref="RepresentationEnum">RepresentationEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.2">v1.2</see></item>
		/// </list>
		/// </remarks>

		public sealed class DISCRETEValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="DISCRETEValue.Name" /></summary>
			public const string NAME = "DISCRETE";
			/// <summary>Constant value for <see cref="DISCRETEValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.3";
			/// <summary>Constant value for <see cref="DISCRETEValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "1.5";
			/// <summary>Constant value for <see cref="DISCRETEValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;**DEPRECATED** as {{property(DataItem::representation)}} type in *MTConnect Version 1.5*. Replaced by the {{property(DataItem::discrete)}}.&#10;
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
		private TABLEValue _TABLE;
		/// <inheritdoc cref="TABLEValue" path="/summary" />
		public TABLEValue TABLE => _TABLE ?? (_TABLE = new TABLEValue());

		/// <summary>﻿two dimensional set of <i>key-value pair</i>s where the <see cref="Entry">Entry</see> represents a row, and the value is a set of <i>key-value pair</i> <see cref="Cell">Cell</see> elements. <br /><br />A <i>table</i> follows the same behavior as the <i>data set</i> for change tracking, clearing, and history. When an <see cref="Entry">Entry</see> changes, all <see cref="Cell">Cell</see> elements update as a single unit following the behavior of a <i>data set</i>.<br /><br />&gt; Note: It is best to use <see cref="Variable">Variable</see> if the <see cref="Cell">Cell</see> entities represent multiple semantic types.<br /><br />Each <see cref="Entry">Entry</see> in the <i>table</i> <b>MUST</b> have a unique key. Each <see cref="Cell">Cell</see> of each <see cref="Entry">Entry</see> in the <i>table</i> <b>MUST</b> have a unique key.<br /><br />See <see cref="Representation">Representation</see> in <see cref="Observation Information Model">Observation Information Model</see>, for a description of <see cref="Entry">Entry</see> and <see cref="Cell">Cell</see> elements.<br /><br /><br />
		/// Value for RepresentationEnum.<br/>
		/// <br/>See also <seealso cref="RepresentationEnum">RepresentationEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.2">v1.2</see></item>
		/// </list>
		/// </remarks>

		public sealed class TABLEValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="TABLEValue.Name" /></summary>
			public const string NAME = "TABLE";
			/// <summary>Constant value for <see cref="TABLEValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.6";
			/// <summary>Constant value for <see cref="TABLEValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="TABLEValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;two dimensional set of {{termplural(key-value pair)}} where the {{block(Entry)}} represents a row, and the value is a set of {{term(key-value pair)}} {{block(Cell)}} elements. 

A {{term(table)}} follows the same behavior as the {{term(data set)}} for change tracking, clearing, and history. When an {{block(Entry)}} changes, all {{block(Cell)}} elements update as a single unit following the behavior of a {{term(data set)}}.

> Note: It is best to use {{block(Variable)}} if the {{block(Cell)}} entities represent multiple semantic types.

Each {{block(Entry)}} in the {{term(table)}} **MUST** have a unique key. Each {{block(Cell)}} of each {{block(Entry)}} in the {{term(table)}} **MUST** have a unique key.

See {{block(Representation)}} in {{package(Observation Information Model)}}, for a description of {{block(Entry)}} and {{block(Cell)}} elements.&#10;
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