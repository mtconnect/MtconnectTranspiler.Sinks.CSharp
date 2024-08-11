using System;
using System.CodeDom.Compiler;using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;

namespace Mtconnect.DataTypes
{
	/// <summary>
	/// View in the MTConnect Model browser <seealso href="https://model.mtconnect.org/#Enumeration__EAID_67CD6E1B_53E3_45c1_B84F_B0732F79528D">model.mtconnect.org</seealso>
	/// </summary>
	/// <remarks>
	/// <list type="bullet">
	/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.2">v1.2</see></item>
	/// </list>
	/// </remarks>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.3.0.0")]
	public enum RepresentationEnum
	{
		/// <summary>
		/// series of sampled data.  The data is reported for a specified number of samples and each sample is reported with a fixed period.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.2">v1.2</see></item>
		/// </list>
		/// </remarks>
		TIME_SERIES,
		/// <summary>
		/// measured value of the sample data.  If no <see cref="DataItem::representation" /> is specified for a data item, the <see cref="DataItem::representation" /> <b>MUST</b> be determined to be <c>VALUE</c>.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.2">v1.2</see></item>
		/// </list>
		/// </remarks>
		VALUE,
		/// <summary>
		/// reported value(s) are represented as a set of <i>key-value pair</i>s.  Each reported value in the <i>data set</i> <b>MUST</b> have a unique key.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.5">v1.5</see></item>
		/// </list>
		/// </remarks>
		DATA_SET,
		/// <summary>
		/// <b>DEPRECATED</b> as <see cref="DataItem::representation" /> type in <i>MTConnect Version 1.5</i>s. Replaced by the <see cref="DataItem::discrete" />.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.3">v1.3</see></item>
		/// <item><b>Deprecated</b>: <see href="https://model.mtconnect.org/#_Version_1.5">v1.5</see></item>
		/// </list>
		/// </remarks>
		[Obsolete("Deprecated in v1.5 according to https://model.mtconnect.org/#_Version_1.5")]
		DISCRETE,
		/// <summary>
		/// two dimensional set of <i>key-value pair</i>s where the <see cref="Entry">Entry</see> represents a row, and the value is a set of <i>key-value pair</i> <see cref="Cell">Cell</see> elements.   A <i>table</i> follows the same behavior as the <i>data set</i> for change tracking, clearing, and history. When an <see cref="Entry">Entry</see> changes, all <see cref="Cell">Cell</see> elements update as a single unit following the behavior of a <i>data set</i>.  > Note: It is best to use <see cref="Variable">Variable</see> if the <see cref="Cell">Cell</see> entities represent multiple semantic types.  Each <see cref="Entry">Entry</see> in the <i>table</i> <b>MUST</b> have a unique key. Each <see cref="Cell">Cell</see> of each <see cref="Entry">Entry</see> in the <i>table</i> <b>MUST</b> have a unique key.  See <see cref="Representation">Representation</see> in <see cref="Observation Information Model">Observation Information Model</see>, for a description of <see cref="Entry">Entry</see> and <see cref="Cell">Cell</see> elements.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.6">v1.6</see></item>
		/// </list>
		/// </remarks>
		TABLE,
	}

	/// <summary>
	/// View in the MTConnect Model browser <seealso href="https://model.mtconnect.org/#Enumeration__EAID_67CD6E1B_53E3_45c1_B84F_B0732F79528D">model.mtconnect.org</seealso>
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.3.0.0")]
	public sealed class RepresentationEnumMetaClass : IEnum
	{
		/// <inheritdoc />
		public string Name => "RepresentationEnum";
		
		/// <inheritdoc />
		public Type DataType => null;
		
		public Type Instance => typeof(RepresentationEnum);

		/// <inheritdoc />
		public string NormativeVersion => "1.2";
		
		/// <inheritdoc />
		public string DeprecatedVersion => "";
		
		/// <inheritdoc />
		public string Summary => @"";
		
		/// <inheritdoc />
		public IEnumInstance[] Values => new IEnumInstance[] {
		TIME_SERIES,
		VALUE,
		DATA_SET,
		DISCRETE,
		TABLE,
		};

		private TIME_SERIESValue _TIME_SERIES;
		/// <summary>
		/// series of sampled data.  The data is reported for a specified number of samples and each sample is reported with a fixed period.
		/// </summary>
		public TIME_SERIESValue TIME_SERIES => _TIME_SERIES ?? (_TIME_SERIES = new TIME_SERIESValue());

		/// <summary>
		/// series of sampled data.  The data is reported for a specified number of samples and each sample is reported with a fixed period.
		/// </summary>
		public sealed class TIME_SERIESValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "TIME_SERIES";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.2";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// series of sampled data.  The data is reported for a specified number of samples and each sample is reported with a fixed period.";
		}
		private VALUEValue _VALUE;
		/// <summary>
		/// measured value of the sample data.  If no <see cref="DataItem::representation" /> is specified for a data item, the <see cref="DataItem::representation" /> <b>MUST</b> be determined to be <c>VALUE</c>.
		/// </summary>
		public VALUEValue VALUE => _VALUE ?? (_VALUE = new VALUEValue());

		/// <summary>
		/// measured value of the sample data.  If no <see cref="DataItem::representation" /> is specified for a data item, the <see cref="DataItem::representation" /> <b>MUST</b> be determined to be <c>VALUE</c>.
		/// </summary>
		public sealed class VALUEValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "VALUE";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.2";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// measured value of the sample data.  If no <see cref=""DataItem::representation"" /> is specified for a data item, the <see cref=""DataItem::representation"" /> <b>MUST</b> be determined to be <c>VALUE</c>.";
		}
		private DATA_SETValue _DATA_SET;
		/// <summary>
		/// reported value(s) are represented as a set of <i>key-value pair</i>s.  Each reported value in the <i>data set</i> <b>MUST</b> have a unique key.
		/// </summary>
		public DATA_SETValue DATA_SET => _DATA_SET ?? (_DATA_SET = new DATA_SETValue());

		/// <summary>
		/// reported value(s) are represented as a set of <i>key-value pair</i>s.  Each reported value in the <i>data set</i> <b>MUST</b> have a unique key.
		/// </summary>
		public sealed class DATA_SETValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "DATA_SET";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.5";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// reported value(s) are represented as a set of <i>key-value pair</i>s.  Each reported value in the <i>data set</i> <b>MUST</b> have a unique key.";
		}
		private DISCRETEValue _DISCRETE;
		/// <summary>
		/// <b>DEPRECATED</b> as <see cref="DataItem::representation" /> type in <i>MTConnect Version 1.5</i>s. Replaced by the <see cref="DataItem::discrete" />.
		/// </summary>
		public DISCRETEValue DISCRETE => _DISCRETE ?? (_DISCRETE = new DISCRETEValue());

		/// <summary>
		/// <b>DEPRECATED</b> as <see cref="DataItem::representation" /> type in <i>MTConnect Version 1.5</i>s. Replaced by the <see cref="DataItem::discrete" />.
		/// </summary>
		public sealed class DISCRETEValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "DISCRETE";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.3";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "1.5";
			
			/// <inheritdoc />
			public string Summary => @"/// <b>DEPRECATED</b> as <see cref=""DataItem::representation"" /> type in <i>MTConnect Version 1.5</i>s. Replaced by the <see cref=""DataItem::discrete"" />.";
		}
		private TABLEValue _TABLE;
		/// <summary>
		/// two dimensional set of <i>key-value pair</i>s where the <see cref="Entry">Entry</see> represents a row, and the value is a set of <i>key-value pair</i> <see cref="Cell">Cell</see> elements.   A <i>table</i> follows the same behavior as the <i>data set</i> for change tracking, clearing, and history. When an <see cref="Entry">Entry</see> changes, all <see cref="Cell">Cell</see> elements update as a single unit following the behavior of a <i>data set</i>.  > Note: It is best to use <see cref="Variable">Variable</see> if the <see cref="Cell">Cell</see> entities represent multiple semantic types.  Each <see cref="Entry">Entry</see> in the <i>table</i> <b>MUST</b> have a unique key. Each <see cref="Cell">Cell</see> of each <see cref="Entry">Entry</see> in the <i>table</i> <b>MUST</b> have a unique key.  See <see cref="Representation">Representation</see> in <see cref="Observation Information Model">Observation Information Model</see>, for a description of <see cref="Entry">Entry</see> and <see cref="Cell">Cell</see> elements.
		/// </summary>
		public TABLEValue TABLE => _TABLE ?? (_TABLE = new TABLEValue());

		/// <summary>
		/// two dimensional set of <i>key-value pair</i>s where the <see cref="Entry">Entry</see> represents a row, and the value is a set of <i>key-value pair</i> <see cref="Cell">Cell</see> elements.   A <i>table</i> follows the same behavior as the <i>data set</i> for change tracking, clearing, and history. When an <see cref="Entry">Entry</see> changes, all <see cref="Cell">Cell</see> elements update as a single unit following the behavior of a <i>data set</i>.  > Note: It is best to use <see cref="Variable">Variable</see> if the <see cref="Cell">Cell</see> entities represent multiple semantic types.  Each <see cref="Entry">Entry</see> in the <i>table</i> <b>MUST</b> have a unique key. Each <see cref="Cell">Cell</see> of each <see cref="Entry">Entry</see> in the <i>table</i> <b>MUST</b> have a unique key.  See <see cref="Representation">Representation</see> in <see cref="Observation Information Model">Observation Information Model</see>, for a description of <see cref="Entry">Entry</see> and <see cref="Cell">Cell</see> elements.
		/// </summary>
		public sealed class TABLEValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "TABLE";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.6";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// two dimensional set of <i>key-value pair</i>s where the <see cref=""Entry"">Entry</see> represents a row, and the value is a set of <i>key-value pair</i> <see cref=""Cell"">Cell</see> elements.   A <i>table</i> follows the same behavior as the <i>data set</i> for change tracking, clearing, and history. When an <see cref=""Entry"">Entry</see> changes, all <see cref=""Cell"">Cell</see> elements update as a single unit following the behavior of a <i>data set</i>.  > Note: It is best to use <see cref=""Variable"">Variable</see> if the <see cref=""Cell"">Cell</see> entities represent multiple semantic types.  Each <see cref=""Entry"">Entry</see> in the <i>table</i> <b>MUST</b> have a unique key. Each <see cref=""Cell"">Cell</see> of each <see cref=""Entry"">Entry</see> in the <i>table</i> <b>MUST</b> have a unique key.  See <see cref=""Representation"">Representation</see> in <see cref=""Observation Information Model"">Observation Information Model</see>, for a description of <see cref=""Entry"">Entry</see> and <see cref=""Cell"">Cell</see> elements.";
		}
	}
}