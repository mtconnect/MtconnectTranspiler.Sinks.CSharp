#pragma warning disable CS0109 // Member does not hide an inherited member; new keyword is not required
#pragma warning disable CS1574 // XML comment has cref attribute that could not be resolved
#pragma warning disable CS1584 // XML comment has syntactically incorrect cref attribute
#pragma warning disable CS0618 // Type or member is obsolete
using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;
using System.Linq;

namespace Mtconnect.ObservationInformationModel
{
	/// <summary>﻿<see cref="Observation">Observation</see> that is continuously changing or analog data value.<br /><br /><br /><br />Description<br /><br /><br />It provides the information and data reported from a piece of equipment for those <see cref="DataItem">DataItem</see> entities defined with <see cref="DataItem.category">category in DataItem</see> as <c>SAMPLE</c> in the <i>MTConnectDevices Response Document</i>.<br /><br /><see cref="Sample">Sample</see> <b>MUST</b> always be reported in <c>float</c>.<br /><br />{{figure(Sample Example)}} shows <see cref="Sample">Sample</see> type examples. It also shows an example for when the <see cref="Observation.result">result in Observation</see> is not available (<c>dataItemId</c>=<c>cspeed</c>).<br /><br />![Sample Example](figures/Sample%20Example.png "Sample Example"){: width="0.8"}<br /><br />&gt; Note: See {{lst(sample-example)}} for the <i>XML</i> representation of the same example.<br /><br />The following <see cref="Value Properties of Sample">Value Properties of Sample</see> lists the additional and/or updated attributes for <see cref="Sample">Sample</see>.<br /><br /><br /><br /><br />
	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Structure___19_0_3_45f01b9_1579566531116_175117_25733">model.mtconnect.org</seealso> for more information.
	/// </summary>
	/// <remarks>
	/// <list type="bullet">
	/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
	/// </list>
	/// </remarks>

	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public sealed class SampleClass : IClass
	{
		/// <summary>Constant value for <see cref="SampleClass.ReferenceId" /></summary>
		public const string REFERENCE_ID = "_19_0_3_45f01b9_1579566531116_175117_25733";
		/// <summary>Constant value for <see cref="SampleClass.HelpUrl" /></summary>
		public const string HELP_URL = "https://model.mtconnect.org/#Structure___19_0_3_45f01b9_1579566531116_175117_25733";
		/// <summary>Constant value for <see cref="SampleClass.Summary" /></summary>
		public const string SUMMARY = @"&#10;&#10;&#10;{{block(Observation)}} that is continuously changing or analog data value.
&#10;
&#10;&#10;&#10;Description&#10;&#10;&#10;&#10;
It provides the information and data reported from a piece of equipment for those {{block(DataItem)}} entities defined with {{property(DataItem::category)}} as `SAMPLE` in the {{term(MTConnectDevices Response Document)}}.

{{block(Sample)}} **MUST** always be reported in `float`.

{{figure(Sample Example)}} shows {{block(Sample)}} type examples. It also shows an example for when the {{property(Observation::result)}} is not available (`dataItemId`=`cspeed`).

![Sample Example](figures/Sample%20Example.png ""Sample Example""){: width=""0.8""}

> Note: See {{lst(sample-example)}} for the {{term(XML)}} representation of the same example.

The following {{sect(Value Properties of Sample)}} lists the additional and/or updated attributes for {{block(Sample)}}.&#10;
";
		/// <summary>Constant value for <see cref="SampleClass.Name" /></summary>
		public const string NAME = "Sample";
		/// <summary>Constant value for <see cref="SampleClass.AccessModifier" /></summary>
		public const string ACCESS_MODIFIER = "public";
		/// <summary>Constant value for <see cref="SampleClass.Modifier" /></summary>
		public const string MODIFIER = "";
		/// <summary>Constant value for <see cref="SampleClass.NormativeVersion" /></summary>
		public const string NORMATIVE_VERSION = "1.0";
		/// <summary>Constant value for <see cref="SampleClass.DeprecatedVersion" /></summary>
		public const string DEPRECATED_VERSION = "";

		/// <inheritdoc />
		public string ReferenceId => REFERENCE_ID;
		
		/// <inheritdoc />
		public string HelpUrl => HELP_URL;

		/// <inheritdoc />
		public string Summary => SUMMARY;

		/// <inheritdoc />
		public string Name => NAME;
		
		/// <inheritdoc />
		public string AccessModifier => ACCESS_MODIFIER;
				
		/// <inheritdoc />
		public string Modifier => MODIFIER;
				
		/// <inheritdoc />
		public string NormativeVersion => NORMATIVE_VERSION;
				
		/// <inheritdoc />
		public string DeprecatedVersion => DEPRECATED_VERSION;
		
		/// <inheritdoc />
		/// <remarks>
		/// Original Type: _19_0_3_45f01b9_1579566531115_47734_25731
		/// </remarks>
		public Type Generalization => typeof(Mtconnect.ObservationInformationModel.ObservationGeneralization);

		/// <inheritdoc />
		public new SampleClassProperties Properties { get; } = new SampleClassProperties();
        IPropertyList IClass.Properties => Properties;
		/// <summary>
		/// Property list for <see cref="SampleClass" />.
		/// <br/><b>Note</b>, some properties (<see cref="IProperty" />) are inherited from <see cref="Mtconnect.ObservationInformationModel.ObservationGeneralization.ObservationGeneralizationProperties" />.
		/// </summary>
		public class SampleClassProperties : Mtconnect.ObservationInformationModel.ObservationGeneralization.ObservationGeneralizationProperties
		{
			/// <inheritdoc />
			public override IProperty[] Properties => new IProperty[] {
				Duration,
				ResetTriggered,
				SampleRate,
				Statistic,
				OrganizedByComponentStreamPart,
				Result,
				Units,
				Type,
			}.Concat(base.Properties).ToArray();
			/// <summary>
			/// <inheritdoc cref="DurationProperty" path="/summary" /><br/>
			/// <remarks>Original Name: Duration</remarks>
			/// </summary>
			public new DurationProperty Duration { get; } = new DurationProperty();
			
			/// <summary>﻿time-period over which the data was collected.<br /><br /><see cref="Sample.duration">duration in Sample</see> <b>MUST</b> be provided when the <see cref="DataItem.statistic">statistic in DataItem</see> is defined in the <i>MTConnectDevices Response Document</i>.<br /><br /><br />
			/// </summary>
			public new sealed class DurationProperty : IProperty
			{
				/// <summary>Constant value for <see cref="DurationProperty.Name" /></summary>
				public const string NAME = "duration";
				/// <summary>Constant value for <see cref="DurationProperty.Summary" /></summary>
				public const string SUMMARY = @"&#10;&#10;&#10;time-period over which the data was collected.

{{property(Sample::duration)}} **MUST** be provided when the {{property(DataItem::statistic)}} is defined in the {{term(MTConnectDevices Response Document)}}.&#10;
";
				/// <summary>Constant value for <see cref="DurationProperty.AccessModifier" /></summary>
				public const string ACCESS_MODIFIER = "public";
				/// <summary>Constant value for <see cref="DurationProperty.Modifier" /></summary>
				public const string MODIFIER = "";
				/// <summary>Constant value for <see cref="DurationProperty.NormativeVersion" /></summary>
				public const string NORMATIVE_VERSION = "1.2";
				/// <summary>Constant value for <see cref="DurationProperty.DeprecatedVersion" /></summary>
				public const string DEPRECATED_VERSION = "";
				/// <summary>Constant value for <see cref="DurationProperty.Aggregation" /></summary>
				public const string AGGREGATION = "";
				/// <summary>Constant value for <see cref="DurationProperty.Extension" /></summary>
				public const string EXTENSION = "MagicDraw UML 2024x";
				/// <summary>Constant value for <see cref="DurationProperty.Association" /></summary>
				public const string ASSOCIATION = "";
				/// <summary>Constant value for <see cref="DurationProperty.DefaultValue" /></summary>
				public const string DEFAULT_VALUE = "";

				/// <summary>
				/// <inheritdoc />
				/// <remarks> Type: Single </remarks>
				/// </summary>
				public System.Type Type => typeof(Single);
				
				/// <inheritdoc />
				public string Name => NAME;
				
				/// <inheritdoc />
				public string Summary => SUMMARY;

				/// <inheritdoc />
				public string AccessModifier => ACCESS_MODIFIER;
				
				/// <inheritdoc />
				public string Modifier => MODIFIER;
				
				/// <inheritdoc />
				public string NormativeVersion => NORMATIVE_VERSION;
				
				/// <inheritdoc />
				public string DeprecatedVersion => DEPRECATED_VERSION;
				
				/// <inheritdoc />
				public string Aggregation => AGGREGATION;

				// Note: Extension.Extender
				/// <inheritdoc />
				public string Extension => EXTENSION;
				
				/// <inheritdoc />
				public string Association => ASSOCIATION;

				// Note: DefaultValue.Name
				/// <inheritdoc />
				public string DefaultValue => DEFAULT_VALUE;
			}
			/// <summary>
			/// <inheritdoc cref="ResetTriggeredProperty" path="/summary" /><br/>
			/// <remarks>Original Name: ResetTriggered</remarks>
			/// </summary>
			public new ResetTriggeredProperty ResetTriggered { get; } = new ResetTriggeredProperty();
			
			/// <summary>﻿identifies when a reported value has been reset and what has caused that reset to occur for those <see cref="DataItem">DataItem</see> entities that may be periodically reset to an initial value.<br /><br /><c>resetTriggered</c> <b>MUST</b> only be provided for the specific occurrence of a <see cref="DataItem">DataItem</see> reported in the <i>MTConnectStreams Response Document</i> when the reset occurred.<br /><br /><br />
			/// </summary>
			public new sealed class ResetTriggeredProperty : IProperty
			{
				/// <summary>Constant value for <see cref="ResetTriggeredProperty.Name" /></summary>
				public const string NAME = "resetTriggered";
				/// <summary>Constant value for <see cref="ResetTriggeredProperty.Summary" /></summary>
				public const string SUMMARY = @"&#10;&#10;&#10;identifies when a reported value has been reset and what has caused that reset to occur for those {{block(DataItem)}} entities that may be periodically reset to an initial value.

`resetTriggered` **MUST** only be provided for the specific occurrence of a {{block(DataItem)}} reported in the {{term(MTConnectStreams Response Document)}} when the reset occurred.&#10;
";
				/// <summary>Constant value for <see cref="ResetTriggeredProperty.AccessModifier" /></summary>
				public const string ACCESS_MODIFIER = "public";
				/// <summary>Constant value for <see cref="ResetTriggeredProperty.Modifier" /></summary>
				public const string MODIFIER = "";
				/// <summary>Constant value for <see cref="ResetTriggeredProperty.NormativeVersion" /></summary>
				public const string NORMATIVE_VERSION = "1.4";
				/// <summary>Constant value for <see cref="ResetTriggeredProperty.DeprecatedVersion" /></summary>
				public const string DEPRECATED_VERSION = "";
				/// <summary>Constant value for <see cref="ResetTriggeredProperty.Aggregation" /></summary>
				public const string AGGREGATION = "";
				/// <summary>Constant value for <see cref="ResetTriggeredProperty.Extension" /></summary>
				public const string EXTENSION = "MagicDraw UML 2024x";
				/// <summary>Constant value for <see cref="ResetTriggeredProperty.Association" /></summary>
				public const string ASSOCIATION = "";
				/// <summary>Constant value for <see cref="ResetTriggeredProperty.DefaultValue" /></summary>
				public const string DEFAULT_VALUE = "";

				/// <summary>
				/// <inheritdoc />
				/// <remarks> Type: ResetTriggeredEnumMetaClass </remarks>
				/// </summary>
				public System.Type Type => typeof(Mtconnect.DataTypes.ResetTriggeredEnumMetaClass);
				
				/// <inheritdoc />
				public string Name => NAME;
				
				/// <inheritdoc />
				public string Summary => SUMMARY;

				/// <inheritdoc />
				public string AccessModifier => ACCESS_MODIFIER;
				
				/// <inheritdoc />
				public string Modifier => MODIFIER;
				
				/// <inheritdoc />
				public string NormativeVersion => NORMATIVE_VERSION;
				
				/// <inheritdoc />
				public string DeprecatedVersion => DEPRECATED_VERSION;
				
				/// <inheritdoc />
				public string Aggregation => AGGREGATION;

				// Note: Extension.Extender
				/// <inheritdoc />
				public string Extension => EXTENSION;
				
				/// <inheritdoc />
				public string Association => ASSOCIATION;

				// Note: DefaultValue.Name
				/// <inheritdoc />
				public string DefaultValue => DEFAULT_VALUE;
			}
			/// <summary>
			/// <inheritdoc cref="SampleRateProperty" path="/summary" /><br/>
			/// <remarks>Original Name: SampleRate</remarks>
			/// </summary>
			public new SampleRateProperty SampleRate { get; } = new SampleRateProperty();
			
			/// <summary>﻿rate at which successive samples of the value are recorded.<br /><br /><br /><br />Description<br /><br /><see cref="Sample.sampleRate">sampleRate in Sample</see> is expressed in terms of samples per second.<br /><br />If <see cref="Sample.sampleRate">sampleRate in Sample</see> is smaller than one, the number can be represented as a decimal type floating-point number. For example, a rate of 1 per 10 seconds would be 0.1 <see cref="Sample.sampleRate">sampleRate in Sample</see> <b>MUST</b> be provided when <see cref="DataItem.representation">representation in DataItem</see> defined in the <i>MTConnectDevices Response Document</i> is <c>TIME_SERIES</c>.<br /><br />When <see cref="DataItem.representation">representation in DataItem</see> is not <c>TIME_SERIES</c>, it <b>MUST</b> be assumed that the data reported is represented by a single value and <see cref="Sample.sampleRate">sampleRate in Sample</see> <b>MUST NOT</b> be reported in the <i>MTConnectStreams Response Document</i>.<br /><br /><br /><br /><br />
			/// </summary>
			public new sealed class SampleRateProperty : IProperty
			{
				/// <summary>Constant value for <see cref="SampleRateProperty.Name" /></summary>
				public const string NAME = "sampleRate";
				/// <summary>Constant value for <see cref="SampleRateProperty.Summary" /></summary>
				public const string SUMMARY = @"&#10;&#10;&#10;rate at which successive samples of the value are recorded.
&#10;
&#10;&#10;&#10;Description&#10;&#10;&#10;&#10;{{property(Sample::sampleRate)}} is expressed in terms of samples per second.

If {{property(Sample::sampleRate)}} is smaller than one, the number can be represented as a decimal type floating-point number. For example, a rate of 1 per 10 seconds would be 0.1 {{property(Sample::sampleRate)}} **MUST** be provided when {{property(DataItem::representation)}} defined in the {{term(MTConnectDevices Response Document)}} is `TIME_SERIES`.

When {{property(DataItem::representation)}} is not `TIME_SERIES`, it **MUST** be assumed that the data reported is represented by a single value and {{property(Sample::sampleRate)}} **MUST NOT** be reported in the {{term(MTConnectStreams Response Document)}}.&#10;
";
				/// <summary>Constant value for <see cref="SampleRateProperty.AccessModifier" /></summary>
				public const string ACCESS_MODIFIER = "public";
				/// <summary>Constant value for <see cref="SampleRateProperty.Modifier" /></summary>
				public const string MODIFIER = "";
				/// <summary>Constant value for <see cref="SampleRateProperty.NormativeVersion" /></summary>
				public const string NORMATIVE_VERSION = "1.2";
				/// <summary>Constant value for <see cref="SampleRateProperty.DeprecatedVersion" /></summary>
				public const string DEPRECATED_VERSION = "";
				/// <summary>Constant value for <see cref="SampleRateProperty.Aggregation" /></summary>
				public const string AGGREGATION = "";
				/// <summary>Constant value for <see cref="SampleRateProperty.Extension" /></summary>
				public const string EXTENSION = "MagicDraw UML 2024x";
				/// <summary>Constant value for <see cref="SampleRateProperty.Association" /></summary>
				public const string ASSOCIATION = "";
				/// <summary>Constant value for <see cref="SampleRateProperty.DefaultValue" /></summary>
				public const string DEFAULT_VALUE = "";

				/// <summary>
				/// <inheritdoc />
				/// <remarks> Type: Single </remarks>
				/// </summary>
				public System.Type Type => typeof(Single);
				
				/// <inheritdoc />
				public string Name => NAME;
				
				/// <inheritdoc />
				public string Summary => SUMMARY;

				/// <inheritdoc />
				public string AccessModifier => ACCESS_MODIFIER;
				
				/// <inheritdoc />
				public string Modifier => MODIFIER;
				
				/// <inheritdoc />
				public string NormativeVersion => NORMATIVE_VERSION;
				
				/// <inheritdoc />
				public string DeprecatedVersion => DEPRECATED_VERSION;
				
				/// <inheritdoc />
				public string Aggregation => AGGREGATION;

				// Note: Extension.Extender
				/// <inheritdoc />
				public string Extension => EXTENSION;
				
				/// <inheritdoc />
				public string Association => ASSOCIATION;

				// Note: DefaultValue.Name
				/// <inheritdoc />
				public string DefaultValue => DEFAULT_VALUE;
			}
			/// <summary>
			/// <inheritdoc cref="StatisticProperty" path="/summary" /><br/>
			/// <remarks>Original Name: Statistic</remarks>
			/// </summary>
			public new StatisticProperty Statistic { get; } = new StatisticProperty();
			
			/// <summary>﻿type of statistical calculation defined by the <see cref="DataItem.statistic">statistic in DataItem</see> defined in the <i>MTConnectDevices Response Document</i>.<br /><br /><br />
			/// </summary>
			public new sealed class StatisticProperty : IProperty
			{
				/// <summary>Constant value for <see cref="StatisticProperty.Name" /></summary>
				public const string NAME = "statistic";
				/// <summary>Constant value for <see cref="StatisticProperty.Summary" /></summary>
				public const string SUMMARY = @"&#10;&#10;&#10;type of statistical calculation defined by the {{property(DataItem::statistic)}} defined in the {{term(MTConnectDevices Response Document)}}.&#10;
";
				/// <summary>Constant value for <see cref="StatisticProperty.AccessModifier" /></summary>
				public const string ACCESS_MODIFIER = "public";
				/// <summary>Constant value for <see cref="StatisticProperty.Modifier" /></summary>
				public const string MODIFIER = "";
				/// <summary>Constant value for <see cref="StatisticProperty.NormativeVersion" /></summary>
				public const string NORMATIVE_VERSION = "1.2";
				/// <summary>Constant value for <see cref="StatisticProperty.DeprecatedVersion" /></summary>
				public const string DEPRECATED_VERSION = "";
				/// <summary>Constant value for <see cref="StatisticProperty.Aggregation" /></summary>
				public const string AGGREGATION = "";
				/// <summary>Constant value for <see cref="StatisticProperty.Extension" /></summary>
				public const string EXTENSION = "MagicDraw UML 2024x";
				/// <summary>Constant value for <see cref="StatisticProperty.Association" /></summary>
				public const string ASSOCIATION = "";
				/// <summary>Constant value for <see cref="StatisticProperty.DefaultValue" /></summary>
				public const string DEFAULT_VALUE = "";

				/// <summary>
				/// <inheritdoc />
				/// <remarks> Type: StatisticEnumMetaClass </remarks>
				/// </summary>
				public System.Type Type => typeof(Mtconnect.DataTypes.StatisticEnumMetaClass);
				
				/// <inheritdoc />
				public string Name => NAME;
				
				/// <inheritdoc />
				public string Summary => SUMMARY;

				/// <inheritdoc />
				public string AccessModifier => ACCESS_MODIFIER;
				
				/// <inheritdoc />
				public string Modifier => MODIFIER;
				
				/// <inheritdoc />
				public string NormativeVersion => NORMATIVE_VERSION;
				
				/// <inheritdoc />
				public string DeprecatedVersion => DEPRECATED_VERSION;
				
				/// <inheritdoc />
				public string Aggregation => AGGREGATION;

				// Note: Extension.Extender
				/// <inheritdoc />
				public string Extension => EXTENSION;
				
				/// <inheritdoc />
				public string Association => ASSOCIATION;

				// Note: DefaultValue.Name
				/// <inheritdoc />
				public string DefaultValue => DEFAULT_VALUE;
			}
			/// <summary>
			/// <inheritdoc cref="OrganizedByComponentStreamPartProperty" path="/summary" /><br/>
			/// <remarks>Original Name: OrganizedByComponentStream</remarks>
			/// </summary>
			public new OrganizedByComponentStreamPartProperty OrganizedByComponentStreamPart { get; } = new OrganizedByComponentStreamPartProperty();
			
			/// <summary>﻿
			/// </summary>
			public new sealed class OrganizedByComponentStreamPartProperty : IProperty
			{
				/// <summary>Constant value for <see cref="OrganizedByComponentStreamPartProperty.Name" /></summary>
				public const string NAME = "organizedByComponentStream";
				/// <summary>Constant value for <see cref="OrganizedByComponentStreamPartProperty.Summary" /></summary>
				public const string SUMMARY = @"";
				/// <summary>Constant value for <see cref="OrganizedByComponentStreamPartProperty.AccessModifier" /></summary>
				public const string ACCESS_MODIFIER = "private";
				/// <summary>Constant value for <see cref="OrganizedByComponentStreamPartProperty.Modifier" /></summary>
				public const string MODIFIER = "";
				/// <summary>Constant value for <see cref="OrganizedByComponentStreamPartProperty.NormativeVersion" /></summary>
				public const string NORMATIVE_VERSION = "";
				/// <summary>Constant value for <see cref="OrganizedByComponentStreamPartProperty.DeprecatedVersion" /></summary>
				public const string DEPRECATED_VERSION = "";
				/// <summary>Constant value for <see cref="OrganizedByComponentStreamPartProperty.Aggregation" /></summary>
				public const string AGGREGATION = "";
				/// <summary>Constant value for <see cref="OrganizedByComponentStreamPartProperty.Extension" /></summary>
				public const string EXTENSION = "";
				/// <summary>Constant value for <see cref="OrganizedByComponentStreamPartProperty.Association" /></summary>
				public const string ASSOCIATION = "Samples";
				/// <summary>Constant value for <see cref="OrganizedByComponentStreamPartProperty.DefaultValue" /></summary>
				public const string DEFAULT_VALUE = "";

				/// <summary>
				/// <inheritdoc />
				/// <remarks> Type: ComponentStreamClass </remarks>
				/// </summary>
				public System.Type Type => typeof(Mtconnect.ObservationInformationModel.ComponentStreamClass);
				
				/// <inheritdoc />
				public string Name => NAME;
				
				/// <inheritdoc />
				public string Summary => SUMMARY;

				/// <inheritdoc />
				public string AccessModifier => ACCESS_MODIFIER;
				
				/// <inheritdoc />
				public string Modifier => MODIFIER;
				
				/// <inheritdoc />
				public string NormativeVersion => NORMATIVE_VERSION;
				
				/// <inheritdoc />
				public string DeprecatedVersion => DEPRECATED_VERSION;
				
				/// <inheritdoc />
				public string Aggregation => AGGREGATION;

				// Note: Extension.Extender
				/// <inheritdoc />
				public string Extension => EXTENSION;
				
				/// <inheritdoc />
				public string Association => ASSOCIATION;

				// Note: DefaultValue.Name
				/// <inheritdoc />
				public string DefaultValue => DEFAULT_VALUE;
			}
			/// <summary>
			/// <inheritdoc cref="ResultProperty" path="/summary" /><br/>
			/// <remarks>Original Name: Result</remarks>
			/// </summary>
			public new ResultProperty Result { get; } = new ResultProperty();
			
			/// <summary>﻿
			/// </summary>
			public new sealed class ResultProperty : IProperty
			{
				/// <summary>Constant value for <see cref="ResultProperty.Name" /></summary>
				public const string NAME = "result";
				/// <summary>Constant value for <see cref="ResultProperty.Summary" /></summary>
				public const string SUMMARY = @"";
				/// <summary>Constant value for <see cref="ResultProperty.AccessModifier" /></summary>
				public const string ACCESS_MODIFIER = "public";
				/// <summary>Constant value for <see cref="ResultProperty.Modifier" /></summary>
				public const string MODIFIER = "";
				/// <summary>Constant value for <see cref="ResultProperty.NormativeVersion" /></summary>
				public const string NORMATIVE_VERSION = "1.0";
				/// <summary>Constant value for <see cref="ResultProperty.DeprecatedVersion" /></summary>
				public const string DEPRECATED_VERSION = "";
				/// <summary>Constant value for <see cref="ResultProperty.Aggregation" /></summary>
				public const string AGGREGATION = "composite";
				/// <summary>Constant value for <see cref="ResultProperty.Extension" /></summary>
				public const string EXTENSION = "MagicDraw UML 2024x";
				/// <summary>Constant value for <see cref="ResultProperty.Association" /></summary>
				public const string ASSOCIATION = "";
				/// <summary>Constant value for <see cref="ResultProperty.DefaultValue" /></summary>
				public const string DEFAULT_VALUE = "";

				/// <summary>
				/// <inheritdoc />
				/// <remarks> Type: Single </remarks>
				/// </summary>
				public System.Type Type => typeof(Single);
				
				/// <inheritdoc />
				public string Name => NAME;
				
				/// <inheritdoc />
				public string Summary => SUMMARY;

				/// <inheritdoc />
				public string AccessModifier => ACCESS_MODIFIER;
				
				/// <inheritdoc />
				public string Modifier => MODIFIER;
				
				/// <inheritdoc />
				public string NormativeVersion => NORMATIVE_VERSION;
				
				/// <inheritdoc />
				public string DeprecatedVersion => DEPRECATED_VERSION;
				
				/// <inheritdoc />
				public string Aggregation => AGGREGATION;

				// Note: Extension.Extender
				/// <inheritdoc />
				public string Extension => EXTENSION;
				
				/// <inheritdoc />
				public string Association => ASSOCIATION;

				// Note: DefaultValue.Name
				/// <inheritdoc />
				public string DefaultValue => DEFAULT_VALUE;
			}
			/// <summary>
			/// <inheritdoc cref="UnitsProperty" path="/summary" /><br/>
			/// <remarks>Original Name: Units</remarks>
			/// </summary>
			public new UnitsProperty Units { get; } = new UnitsProperty();
			
			/// <summary>﻿
			/// </summary>
			public new sealed class UnitsProperty : IProperty
			{
				/// <summary>Constant value for <see cref="UnitsProperty.Name" /></summary>
				public const string NAME = "units";
				/// <summary>Constant value for <see cref="UnitsProperty.Summary" /></summary>
				public const string SUMMARY = @"";
				/// <summary>Constant value for <see cref="UnitsProperty.AccessModifier" /></summary>
				public const string ACCESS_MODIFIER = "public";
				/// <summary>Constant value for <see cref="UnitsProperty.Modifier" /></summary>
				public const string MODIFIER = "static";
				/// <summary>Constant value for <see cref="UnitsProperty.NormativeVersion" /></summary>
				public const string NORMATIVE_VERSION = "1.0";
				/// <summary>Constant value for <see cref="UnitsProperty.DeprecatedVersion" /></summary>
				public const string DEPRECATED_VERSION = "";
				/// <summary>Constant value for <see cref="UnitsProperty.Aggregation" /></summary>
				public const string AGGREGATION = "composite";
				/// <summary>Constant value for <see cref="UnitsProperty.Extension" /></summary>
				public const string EXTENSION = "MagicDraw UML 2024x";
				/// <summary>Constant value for <see cref="UnitsProperty.Association" /></summary>
				public const string ASSOCIATION = "";
				/// <summary>Constant value for <see cref="UnitsProperty.DefaultValue" /></summary>
				public const string DEFAULT_VALUE = "";

				/// <summary>
				/// <inheritdoc />
				/// <remarks> Type: UnitEnumMetaClass </remarks>
				/// </summary>
				public System.Type Type => typeof(Mtconnect.DataTypes.UnitEnumMetaClass);
				
				/// <inheritdoc />
				public string Name => NAME;
				
				/// <inheritdoc />
				public string Summary => SUMMARY;

				/// <inheritdoc />
				public string AccessModifier => ACCESS_MODIFIER;
				
				/// <inheritdoc />
				public string Modifier => MODIFIER;
				
				/// <inheritdoc />
				public string NormativeVersion => NORMATIVE_VERSION;
				
				/// <inheritdoc />
				public string DeprecatedVersion => DEPRECATED_VERSION;
				
				/// <inheritdoc />
				public string Aggregation => AGGREGATION;

				// Note: Extension.Extender
				/// <inheritdoc />
				public string Extension => EXTENSION;
				
				/// <inheritdoc />
				public string Association => ASSOCIATION;

				// Note: DefaultValue.Name
				/// <inheritdoc />
				public string DefaultValue => DEFAULT_VALUE;
			}
			/// <summary>
			/// <inheritdoc cref="TypeProperty" path="/summary" /><br/>
			/// <remarks>Original Name: Type</remarks>
			/// </summary>
			public new TypeProperty Type { get; } = new TypeProperty();
			
			/// <summary>﻿
			/// </summary>
			public new sealed class TypeProperty : IProperty
			{
				/// <summary>Constant value for <see cref="TypeProperty.Name" /></summary>
				public const string NAME = "type";
				/// <summary>Constant value for <see cref="TypeProperty.Summary" /></summary>
				public const string SUMMARY = @"";
				/// <summary>Constant value for <see cref="TypeProperty.AccessModifier" /></summary>
				public const string ACCESS_MODIFIER = "public";
				/// <summary>Constant value for <see cref="TypeProperty.Modifier" /></summary>
				public const string MODIFIER = "static";
				/// <summary>Constant value for <see cref="TypeProperty.NormativeVersion" /></summary>
				public const string NORMATIVE_VERSION = "1.0";
				/// <summary>Constant value for <see cref="TypeProperty.DeprecatedVersion" /></summary>
				public const string DEPRECATED_VERSION = "";
				/// <summary>Constant value for <see cref="TypeProperty.Aggregation" /></summary>
				public const string AGGREGATION = "composite";
				/// <summary>Constant value for <see cref="TypeProperty.Extension" /></summary>
				public const string EXTENSION = "MagicDraw UML 2024x";
				/// <summary>Constant value for <see cref="TypeProperty.Association" /></summary>
				public const string ASSOCIATION = "";
				/// <summary>Constant value for <see cref="TypeProperty.DefaultValue" /></summary>
				public const string DEFAULT_VALUE = "";

				/// <summary>
				/// <inheritdoc />
				/// <remarks> Type: SampleEnumMetaClass </remarks>
				/// </summary>
				public System.Type Type => typeof(Mtconnect.DataTypes.SampleEnumMetaClass);
				
				/// <inheritdoc />
				public string Name => NAME;
				
				/// <inheritdoc />
				public string Summary => SUMMARY;

				/// <inheritdoc />
				public string AccessModifier => ACCESS_MODIFIER;
				
				/// <inheritdoc />
				public string Modifier => MODIFIER;
				
				/// <inheritdoc />
				public string NormativeVersion => NORMATIVE_VERSION;
				
				/// <inheritdoc />
				public string DeprecatedVersion => DEPRECATED_VERSION;
				
				/// <inheritdoc />
				public string Aggregation => AGGREGATION;

				// Note: Extension.Extender
				/// <inheritdoc />
				public string Extension => EXTENSION;
				
				/// <inheritdoc />
				public string Association => ASSOCIATION;

				// Note: DefaultValue.Name
				/// <inheritdoc />
				public string DefaultValue => DEFAULT_VALUE;
			}
		};

	}
}