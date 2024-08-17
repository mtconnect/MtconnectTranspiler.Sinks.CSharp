#pragma warning disable CS0109 // Member does not hide an inherited member; new keyword is not required
#pragma warning disable CS1574 // XML comment has cref attribute that could not be resolved
#pragma warning disable CS1584 // XML comment has syntactically incorrect cref attribute
using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;
using System.Linq;

namespace Mtconnect.ObservationInformationModel.Representations
{
	/// <summary>﻿<see cref="Representation">Representation</see> for an <see cref="Observation">Observation</see> composed of a series of sampled data.<br /><br /><br /><br />Description<br /><br /><br /><see cref="TimeSeries">TimeSeries</see> for an <see cref="Observation">Observation</see> is defined by the associated <see cref="DataItem.representation">representation in DataItem</see> as <c>TIME_SERIES</c>.<br /><br /><see cref="DataItem.representation">representation in DataItem</see> as <c>TIME_SERIES</c> <b>MUST</b> have <see cref="DataItem.category">category in DataItem</see> of <c>SAMPLE</c>.<br /><br />{{figure(TemperatureTimeSeries)}} shows the model for <see cref="Temperature">Temperature</see> (<see cref="Sample">Sample</see> type) with a <see cref="Representation">Representation</see> type of <see cref="TimeSeries">TimeSeries</see>. <br /><br />![TemperatureTimeSeries](figures/TemperatureTimeSeries.png "TemperatureTimeSeries"){: width="0.8"}<br /><br />&gt; Note: See <see cref="Representation Schema Diagrams">Representation Schema Diagrams</see> for XML schema.<br /><br /><see cref="TimeSeries">TimeSeries</see> <b>MUST</b> report multiple values at fixed intervals in a single <see cref="Observation">Observation</see>. At minimum, one of <see cref="DataItem.sampleRate">sampleRate in DataItem</see> or <see cref="Sample.sampleRate">sampleRate in Sample</see> <b>MUST</b> be specified. When both are specified, the <see cref="Sample.sampleRate">sampleRate in Sample</see> supersedes the <see cref="DataItem.sampleRate">sampleRate in DataItem</see>.<br /><br /><see cref="Observation.timestamp">timestamp in Observation</see> <b>MUST</b> be set to the time the last value was observed. The <see cref="Sample.duration">duration in Sample</see> <b>MAY</b> indicate the time interval from the first to the last value in the series.<br /><br /><see cref="Value Properties of TimeSeries">Value Properties of TimeSeries</see> defines additional attributes for an <see cref="Observation">Observation</see> with <see cref="TimeSeries">TimeSeries</see> <see cref="Representation">Representation</see> type.<br /><br /><br /><br /><br />
	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Structure___19_0_3_45f01b9_1579566531117_257703_25734">model.mtconnect.org</seealso> for more information.
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public sealed class TimeSeriesClass : IClass
	{
		/// <inheritdoc />
		public string ReferenceId => "_19_0_3_45f01b9_1579566531117_257703_25734";
		
		/// <inheritdoc />
		public string Summary => @"&#10;&#10;&#10;{{block(Representation)}} for an {{block(Observation)}} composed of a series of sampled data.
&#10;
&#10;&#10;&#10;Description&#10;&#10;&#10;&#10;
{{block(TimeSeries)}} for an {{block(Observation)}} is defined by the associated {{property(DataItem::representation)}} as `TIME_SERIES`.

{{property(DataItem::representation)}} as `TIME_SERIES` **MUST** have {{property(DataItem::category)}} of `SAMPLE`.

{{figure(TemperatureTimeSeries)}} shows the model for {{block(Temperature)}} ({{block(Sample)}} type) with a {{block(Representation)}} type of {{block(TimeSeries)}}. 

![TemperatureTimeSeries](figures/TemperatureTimeSeries.png ""TemperatureTimeSeries""){: width=""0.8""}

> Note: See {{sect(Representation Schema Diagrams)}} for XML schema.

{{block(TimeSeries)}} **MUST** report multiple values at fixed intervals in a single {{block(Observation)}}. At minimum, one of {{property(DataItem::sampleRate)}} or {{property(Sample::sampleRate)}} **MUST** be specified. When both are specified, the {{property(Sample::sampleRate)}} supersedes the {{property(DataItem::sampleRate)}}.

{{property(Observation::timestamp)}} **MUST** be set to the time the last value was observed. The {{property(Sample::duration)}} **MAY** indicate the time interval from the first to the last value in the series.

{{sect(Value Properties of TimeSeries)}} defines additional attributes for an {{block(Observation)}} with {{block(TimeSeries)}} {{block(Representation)}} type.&#10;
";

		/// <inheritdoc />
		public string Name => "TimeSeries";
		
		/// <inheritdoc />
		public string AccessModifier => "public";
				
		/// <inheritdoc />
		public string Modifier => "";
				
		/// <inheritdoc />
		public string NormativeVersion => "1.2";
				
		/// <inheritdoc />
		public string DeprecatedVersion => "";
		
		/// <inheritdoc />
		/// <remarks>
		/// Original Type: _19_0_3_68e0225_1633615188301_96457_1251
		/// </remarks>
		public Type Generalization => typeof(Mtconnect.ObservationInformationModel.Representations.RepresentationClass);

		/// <inheritdoc />
		public TimeSeriesClassProperties Properties { get; } = new TimeSeriesClassProperties();
        IPropertyList IClass.Properties => Properties;
		/// <summary>
		/// Property list for <see cref="TimeSeriesClass" />.
		/// <br/><b>Note</b>, some properties (<see cref="IProperty" />) are inherited from <see cref="Mtconnect.ObservationInformationModel.Representations.RepresentationClass.RepresentationClassProperties" />.
		/// </summary>
		public class TimeSeriesClassProperties : Mtconnect.ObservationInformationModel.Representations.RepresentationClass.RepresentationClassProperties
		{
			/// <inheritdoc />
			public new IProperty[] Properties => new IProperty[] {
				SampleCount,
				Result,
			}.Concat(base.Properties).ToArray();
			/// <summary>
			/// <inheritdoc cref="SampleCountProperty" path="/summary" /><br/>
			/// <remarks>Original Name: SampleCount</remarks>
			/// </summary>
			public new SampleCountProperty SampleCount { get; } = new SampleCountProperty();
			
			/// <summary>﻿number of values given for the <see cref="Observation">Observation</see>.<br /><br /><br />
			/// </summary>
			public new sealed class SampleCountProperty : IProperty
			{
				/// <summary>
				/// <inheritdoc />
				/// <remarks>
				/// <list type="bullet">
				/// <item>Original Type: _19_0_3_91b028d_1579272271512_537408_674</item>
				/// <item>Type: Int32</item>
				/// <item>Namespace: </item>
				/// </list>
				/// </remarks>
				/// </summary>
				public System.Type Type => typeof(Int32);
				
				/// <inheritdoc />
				public string Name => "sampleCount";
				
				/// <inheritdoc />
				public string Summary => @"&#10;&#10;&#10;number of values given for the {{block(Observation)}}.&#10;
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
		};

	}
}