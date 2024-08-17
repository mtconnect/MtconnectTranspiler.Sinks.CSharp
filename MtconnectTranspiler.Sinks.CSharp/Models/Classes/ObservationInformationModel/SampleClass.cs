#pragma warning disable CS0109 // Member does not hide an inherited member; new keyword is not required
#pragma warning disable CS1574 // XML comment has cref attribute that could not be resolved
#pragma warning disable CS1584 // XML comment has syntactically incorrect cref attribute
using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;
using System.Linq;

namespace Mtconnect.ObservationInformationModel
{
	/// <summary>﻿<see cref="Observation">Observation</see> that is continuously changing or analog data value.<br /><br /><br /><br />Description<br /><br /><br />It provides the information and data reported from a piece of equipment for those <see cref="DataItem">DataItem</see> entities defined with <see cref="DataItem.category">category in DataItem</see> as <c>SAMPLE</c> in the <i>MTConnectDevices Response Document</i>.<br /><br /><see cref="Sample">Sample</see> <b>MUST</b> always be reported in <c>float</c>.<br /><br />{{figure(Sample Example)}} shows <see cref="Sample">Sample</see> type examples. It also shows an example for when the <see cref="Observation.result">result in Observation</see> is not available (<c>dataItemId</c>=<c>cspeed</c>).<br /><br />![Sample Example](figures/Sample%20Example.png "Sample Example"){: width="0.8"}<br /><br />&gt; Note: See {{lst(sample-example)}} for the <i>XML</i> representation of the same example.<br /><br />The following <see cref="Value Properties of Sample">Value Properties of Sample</see> lists the additional and/or updated attributes for <see cref="Sample">Sample</see>.<br /><br /><br /><br /><br />
	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Structure___19_0_3_45f01b9_1579566531116_175117_25733">model.mtconnect.org</seealso> for more information.
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public sealed class SampleClass : IClass
	{
		/// <inheritdoc />
		public string ReferenceId => "_19_0_3_45f01b9_1579566531116_175117_25733";
		
		/// <inheritdoc />
		public string Summary => @"&#10;&#10;&#10;{{block(Observation)}} that is continuously changing or analog data value.
&#10;
&#10;&#10;&#10;Description&#10;&#10;&#10;&#10;
It provides the information and data reported from a piece of equipment for those {{block(DataItem)}} entities defined with {{property(DataItem::category)}} as `SAMPLE` in the {{term(MTConnectDevices Response Document)}}.

{{block(Sample)}} **MUST** always be reported in `float`.

{{figure(Sample Example)}} shows {{block(Sample)}} type examples. It also shows an example for when the {{property(Observation::result)}} is not available (`dataItemId`=`cspeed`).

![Sample Example](figures/Sample%20Example.png ""Sample Example""){: width=""0.8""}

> Note: See {{lst(sample-example)}} for the {{term(XML)}} representation of the same example.

The following {{sect(Value Properties of Sample)}} lists the additional and/or updated attributes for {{block(Sample)}}.&#10;
";

		/// <inheritdoc />
		public string Name => "Sample";
		
		/// <inheritdoc />
		public string AccessModifier => "public";
				
		/// <inheritdoc />
		public string Modifier => "";
				
		/// <inheritdoc />
		public string NormativeVersion => "1.0";
				
		/// <inheritdoc />
		public string DeprecatedVersion => "";
		
		/// <inheritdoc />
		/// <remarks>
		/// Original Type: _19_0_3_45f01b9_1579566531115_47734_25731
		/// </remarks>
		public Type Generalization => typeof(Mtconnect.ObservationInformationModel.ObservationGeneralization);

		/// <inheritdoc />
		public SampleClassProperties Properties { get; } = new SampleClassProperties();
        IPropertyList IClass.Properties => Properties;
		/// <summary>
		/// Property list for <see cref="SampleClass" />.
		/// <br/><b>Note</b>, some properties (<see cref="IProperty" />) are inherited from <see cref="Mtconnect.ObservationInformationModel.ObservationGeneralization.ObservationGeneralizationProperties" />.
		/// </summary>
		public class SampleClassProperties : Mtconnect.ObservationInformationModel.ObservationGeneralization.ObservationGeneralizationProperties
		{
			/// <inheritdoc />
			public new IProperty[] Properties => new IProperty[] {
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
				/// <summary>
				/// <inheritdoc />
				/// <remarks>
				/// <list type="bullet">
				/// <item>Original Type: _19_0_3_91b028d_1579559644428_616727_5836</item>
				/// <item>Type: Single</item>
				/// <item>Namespace: </item>
				/// </list>
				/// </remarks>
				/// </summary>
				public System.Type Type => typeof(Single);
				
				/// <inheritdoc />
				public string Name => "duration";
				
				/// <inheritdoc />
				public string Summary => @"&#10;&#10;&#10;time-period over which the data was collected.

{{property(Sample::duration)}} **MUST** be provided when the {{property(DataItem::statistic)}} is defined in the {{term(MTConnectDevices Response Document)}}.&#10;
";

				/// <inheritdoc />
				public string AccessModifier => "public";
				
				/// <inheritdoc />
				public string Modifier => "";
				
				/// <inheritdoc />
				public string NormativeVersion => "1.2";
				
				/// <inheritdoc />
				public string DeprecatedVersion => "";
				
				/// <inheritdoc />
				public string Aggregation => "";

				// Note: Extension.Extender
				/// <inheritdoc />
				public string Extension => "MagicDraw UML 19.0";
				
				/// <inheritdoc />
				public string Association => "";

				// Note: DefaultValue.Name
				/// <inheritdoc />
				public string DefaultValue => "";
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
				/// <summary>
				/// <inheritdoc />
				/// <remarks>
				/// <list type="bullet">
				/// <item>Original Type: _19_0_3_45f01b9_1579566531118_10952_25736</item>
				/// <item>Type: ResetTriggeredEnumMetaClass</item>
				/// <item>Namespace: Mtconnect.DataTypes</item>
				/// </list>
				/// </remarks>
				/// </summary>
				public System.Type Type => typeof(Mtconnect.DataTypes.ResetTriggeredEnumMetaClass);
				
				/// <inheritdoc />
				public string Name => "resetTriggered";
				
				/// <inheritdoc />
				public string Summary => @"&#10;&#10;&#10;identifies when a reported value has been reset and what has caused that reset to occur for those {{block(DataItem)}} entities that may be periodically reset to an initial value.

`resetTriggered` **MUST** only be provided for the specific occurrence of a {{block(DataItem)}} reported in the {{term(MTConnectStreams Response Document)}} when the reset occurred.&#10;
";

				/// <inheritdoc />
				public string AccessModifier => "public";
				
				/// <inheritdoc />
				public string Modifier => "";
				
				/// <inheritdoc />
				public string NormativeVersion => "1.4";
				
				/// <inheritdoc />
				public string DeprecatedVersion => "";
				
				/// <inheritdoc />
				public string Aggregation => "";

				// Note: Extension.Extender
				/// <inheritdoc />
				public string Extension => "MagicDraw UML 19.0";
				
				/// <inheritdoc />
				public string Association => "";

				// Note: DefaultValue.Name
				/// <inheritdoc />
				public string DefaultValue => "";
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
				/// <summary>
				/// <inheritdoc />
				/// <remarks>
				/// <list type="bullet">
				/// <item>Original Type: _19_0_3_91b028d_1579272506322_914606_702</item>
				/// <item>Type: Single</item>
				/// <item>Namespace: </item>
				/// </list>
				/// </remarks>
				/// </summary>
				public System.Type Type => typeof(Single);
				
				/// <inheritdoc />
				public string Name => "sampleRate";
				
				/// <inheritdoc />
				public string Summary => @"&#10;&#10;&#10;rate at which successive samples of the value are recorded.
&#10;
&#10;&#10;&#10;Description&#10;&#10;&#10;&#10;{{property(Sample::sampleRate)}} is expressed in terms of samples per second.

If {{property(Sample::sampleRate)}} is smaller than one, the number can be represented as a decimal type floating-point number. For example, a rate of 1 per 10 seconds would be 0.1 {{property(Sample::sampleRate)}} **MUST** be provided when {{property(DataItem::representation)}} defined in the {{term(MTConnectDevices Response Document)}} is `TIME_SERIES`.

When {{property(DataItem::representation)}} is not `TIME_SERIES`, it **MUST** be assumed that the data reported is represented by a single value and {{property(Sample::sampleRate)}} **MUST NOT** be reported in the {{term(MTConnectStreams Response Document)}}.&#10;
";

				/// <inheritdoc />
				public string AccessModifier => "public";
				
				/// <inheritdoc />
				public string Modifier => "";
				
				/// <inheritdoc />
				public string NormativeVersion => "1.2";
				
				/// <inheritdoc />
				public string DeprecatedVersion => "";
				
				/// <inheritdoc />
				public string Aggregation => "";

				// Note: Extension.Extender
				/// <inheritdoc />
				public string Extension => "MagicDraw UML 19.0";
				
				/// <inheritdoc />
				public string Association => "";

				// Note: DefaultValue.Name
				/// <inheritdoc />
				public string DefaultValue => "";
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
				/// <summary>
				/// <inheritdoc />
				/// <remarks>
				/// <list type="bullet">
				/// <item>Original Type: EAID_51F1600E_2F14_4045_86C0_42B336850079</item>
				/// <item>Type: StatisticEnumMetaClass</item>
				/// <item>Namespace: Mtconnect.DataTypes</item>
				/// </list>
				/// </remarks>
				/// </summary>
				public System.Type Type => typeof(Mtconnect.DataTypes.StatisticEnumMetaClass);
				
				/// <inheritdoc />
				public string Name => "statistic";
				
				/// <inheritdoc />
				public string Summary => @"&#10;&#10;&#10;type of statistical calculation defined by the {{property(DataItem::statistic)}} defined in the {{term(MTConnectDevices Response Document)}}.&#10;
";

				/// <inheritdoc />
				public string AccessModifier => "public";
				
				/// <inheritdoc />
				public string Modifier => "";
				
				/// <inheritdoc />
				public string NormativeVersion => "1.2";
				
				/// <inheritdoc />
				public string DeprecatedVersion => "";
				
				/// <inheritdoc />
				public string Aggregation => "";

				// Note: Extension.Extender
				/// <inheritdoc />
				public string Extension => "MagicDraw UML 19.0";
				
				/// <inheritdoc />
				public string Association => "";

				// Note: DefaultValue.Name
				/// <inheritdoc />
				public string DefaultValue => "";
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
				/// <summary>
				/// <inheritdoc />
				/// <remarks>
				/// <list type="bullet">
				/// <item>Original Type: EAID_9057AAF9_4687_42be_BD2B_E2F18DF049DC</item>
				/// <item>Type: ComponentStreamClass</item>
				/// <item>Namespace: Mtconnect.ObservationInformationModel</item>
				/// </list>
				/// </remarks>
				/// </summary>
				public System.Type Type => typeof(Mtconnect.ObservationInformationModel.ComponentStreamClass);
				
				/// <inheritdoc />
				public string Name => "organizedByComponentStream";
				
				/// <inheritdoc />
				public string Summary => @"";

				/// <inheritdoc />
				public string AccessModifier => "private";
				
				/// <inheritdoc />
				public string Modifier => "";
				
				/// <inheritdoc />
				public string NormativeVersion => "";
				
				/// <inheritdoc />
				public string DeprecatedVersion => "";
				
				/// <inheritdoc />
				public string Aggregation => "";

				// Note: Extension.Extender
				/// <inheritdoc />
				public string Extension => "";
				
				/// <inheritdoc />
				public string Association => "Samples";

				// Note: DefaultValue.Name
				/// <inheritdoc />
				public string DefaultValue => "";
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
				/// <summary>
				/// <inheritdoc />
				/// <remarks>
				/// <list type="bullet">
				/// <item>Original Type: _19_0_3_91b028d_1579272506322_914606_702</item>
				/// <item>Type: Single</item>
				/// <item>Namespace: </item>
				/// </list>
				/// </remarks>
				/// </summary>
				public System.Type Type => typeof(Single);
				
				/// <inheritdoc />
				public string Name => "result";
				
				/// <inheritdoc />
				public string Summary => @"";

				/// <inheritdoc />
				public string AccessModifier => "public";
				
				/// <inheritdoc />
				public string Modifier => "";
				
				/// <inheritdoc />
				public string NormativeVersion => "1.0";
				
				/// <inheritdoc />
				public string DeprecatedVersion => "";
				
				/// <inheritdoc />
				public string Aggregation => "composite";

				// Note: Extension.Extender
				/// <inheritdoc />
				public string Extension => "MagicDraw UML 19.0";
				
				/// <inheritdoc />
				public string Association => "";

				// Note: DefaultValue.Name
				/// <inheritdoc />
				public string DefaultValue => "";
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
				/// <summary>
				/// <inheritdoc />
				/// <remarks>
				/// <list type="bullet">
				/// <item>Original Type: EAID_8FEC81E4_8E1F_4f45_820B_F9F25DD83F9A</item>
				/// <item>Type: UnitEnumMetaClass</item>
				/// <item>Namespace: Mtconnect.DataTypes</item>
				/// </list>
				/// </remarks>
				/// </summary>
				public System.Type Type => typeof(Mtconnect.DataTypes.UnitEnumMetaClass);
				
				/// <inheritdoc />
				public string Name => "units";
				
				/// <inheritdoc />
				public string Summary => @"";

				/// <inheritdoc />
				public string AccessModifier => "public";
				
				/// <inheritdoc />
				public string Modifier => "static";
				
				/// <inheritdoc />
				public string NormativeVersion => "1.0";
				
				/// <inheritdoc />
				public string DeprecatedVersion => "";
				
				/// <inheritdoc />
				public string Aggregation => "composite";

				// Note: Extension.Extender
				/// <inheritdoc />
				public string Extension => "MagicDraw UML 19.0";
				
				/// <inheritdoc />
				public string Association => "";

				// Note: DefaultValue.Name
				/// <inheritdoc />
				public string DefaultValue => "";
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
				/// <summary>
				/// <inheritdoc />
				/// <remarks>
				/// <list type="bullet">
				/// <item>Original Type: _19_0_3_45f01b9_1580398370126_672808_12777</item>
				/// <item>Type: SampleEnumMetaClass</item>
				/// <item>Namespace: Mtconnect.DataTypes</item>
				/// </list>
				/// </remarks>
				/// </summary>
				public System.Type Type => typeof(Mtconnect.DataTypes.SampleEnumMetaClass);
				
				/// <inheritdoc />
				public string Name => "type";
				
				/// <inheritdoc />
				public string Summary => @"";

				/// <inheritdoc />
				public string AccessModifier => "public";
				
				/// <inheritdoc />
				public string Modifier => "static";
				
				/// <inheritdoc />
				public string NormativeVersion => "1.0";
				
				/// <inheritdoc />
				public string DeprecatedVersion => "";
				
				/// <inheritdoc />
				public string Aggregation => "composite";

				// Note: Extension.Extender
				/// <inheritdoc />
				public string Extension => "MagicDraw UML 19.0";
				
				/// <inheritdoc />
				public string Association => "";

				// Note: DefaultValue.Name
				/// <inheritdoc />
				public string DefaultValue => "";
			}
		};

	}
}