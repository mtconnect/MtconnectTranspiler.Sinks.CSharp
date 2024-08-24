#pragma warning disable CS0109 // Member does not hide an inherited member; new keyword is not required
#pragma warning disable CS1574 // XML comment has cref attribute that could not be resolved
#pragma warning disable CS1584 // XML comment has syntactically incorrect cref attribute
#pragma warning disable CS0618 // Type or member is obsolete
using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;
using System.Linq;

namespace Mtconnect.ObservationInformationModel.Representations
{
	/// <summary>﻿<see cref="Representation">Representation</see> for an <see cref="Observation">Observation</see> composed of value(s) represented as a set of <i>key-value pair</i>s.<br /><br /><br /><br />Description<br /><br /><br /><see cref="DataSet">DataSet</see> for an <see cref="Observation">Observation</see> is defined by the associated <see cref="DataItem.representation">representation in DataItem</see> as <c>DATA_SET</c>.<br /><br /><see cref="DataItem.representation">representation in DataItem</see> as <c>DATA_SET</c> <b>MUST</b> have <see cref="DataItem.category">category in DataItem</see> as <c>SAMPLE</c> or <c>EVENT</c>.<br /><br />{{figure(VariableDataSet)}} shows the model for <see cref="Variable">Variable</see> (<see cref="Event">Event</see> type) with a <see cref="Representation">Representation</see> type of <see cref="DataSet">DataSet</see>. <br /><br />![VariableDataSet](figures/VariableDataSet.png "VariableDataSet"){: width="0.8"}<br /><br />&gt; Note: See {{figure(DataSet Schema)}} for XML schema.<br /><br /><see cref="DataSet">DataSet</see> reports multiple values as a set of <i>key-value pair</i> where each <i>key</i> <b>MUST</b> be unique. The representation of the <i>key-value pair</i> is an <see cref="Entry">Entry</see>. The value of each <see cref="Entry">Entry</see> <b>MUST</b> have the same constraints and format as the <see cref="Observation">Observation</see> defined for <see cref="DataItem.representation">representation in DataItem</see> as <c>VALUE</c> for the <see cref="DataItem">DataItem</see> type. (See <see cref="Value">Value</see>). <br /><br />The meaning of each <see cref="Entry">Entry</see> <b>MAY</b> be provided as the <see cref="DataItem">DataItem</see> <see cref="EntryDefinition">EntryDefinition</see>.<br /><br />{{figure(DataSet Example)}} shows <see cref="Event">Event</see> <see cref="Observation">Observation</see> type <see cref="Variable">Variable</see> with a <see cref="Representation">Representation</see> type of <c>DataSet</c>.<br /><br />![DataSet Example](figures/DataSet%20Example.png "DataSet Example"){: width="0.8"}<br /><br />&gt; Note: See {{lst(dataset-example)}} for the <i>XML</i> representation of the same example.<br /><br />#### Management of Data Set Observations<br /><br />An <i>agent</i> <b>MUST</b> maintain the current state of the <see cref="DataSet">DataSet</see> as described in <see cref="Fundamentals">Fundamentals</see>.<br /><br />One or more <i>key-value pair</i>s <b>MAY</b> be added, removed, or changed in an <see cref="Observation">Observation</see>. An <i>agent</i> <b>MUST</b> publish the changes to one or more <i>key-value pair</i>s as a single <see cref="Observation">Observation</see>. An <i>agent</i> <b>MUST</b> indicate the removal of a <i>key-value pair</i> from a <see cref="DataSet">DataSet</see> using the <see cref="Entry.removed">removed in Entry</see> as <c>true</c>.<br /><br />When the <see cref="DataItem.discrete">discrete in DataItem</see> is <c>false</c> or is not present, an <i>agent</i> in response to a <i>sample request</i> <b>MUST</b> only publish the changed <i>key-value pair</i> since the previous state of the <see cref="DataSet">DataSet</see>.<br /><br />When the <see cref="DataItem.discrete">discrete in DataItem</see> attribute is <c>true</c>, an <i>agent</i>, in response to a <i>sample request</i>, <b>MUST</b> report all <i>key-value pair</i>s ignoring the state of the <see cref="DataSet">DataSet</see>.<br /><br />When an <i>agent</i> responds to a <i>current request</i>, the <i>response document</i> <b>MUST</b> include the full set of <i>key-value pair</i>s. If the <i>current request</i> includes an <c>at</c> query parameter, the <i>agent</i> <b>MUST</b> provide the set of <i>key-value pair</i>s at the  <i>sequence number</i>.<br /><br />When an <see cref="Observation">Observation</see> <i>reset</i> occurs, the <see cref="DataSet">DataSet</see> <b>MUST</b> remove all <i>key-value pair</i>s making the set empty. The <see cref="Observation">Observation</see> <b>MAY</b> simultaneously populate the <see cref="DataSet">DataSet</see> with new <i>key-value pair</i>s. The previous entries <b>MUST NOT</b> be included and <b>MUST NOT</b> have <see cref="Entry.removed">removed in Entry</see> as <c>true</c>.<br /><br />When the <see cref="Observation">Observation</see>  is <c>UNAVAILABLE</c> the <see cref="DataSet">DataSet</see> <b>MUST</b> remove all <i>key-value pair</i>s making the set empty.<br /><br /><br /><br /><br />
	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Structure___19_0_3_45f01b9_1579566531114_503405_25727">model.mtconnect.org</seealso> for more information.
	/// </summary>
	/// <remarks>
	/// <list type="bullet">
	/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.5">v1.5</see></item>
	/// </list>
	/// </remarks>

	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public sealed class DataSetClass : IClass
	{
		/// <summary>Constant value for <see cref="DataSetClass.ReferenceId" /></summary>
		public const string REFERENCE_ID = "_19_0_3_45f01b9_1579566531114_503405_25727";
		/// <summary>Constant value for <see cref="DataSetClass.HelpUrl" /></summary>
		public const string HELP_URL = "https://model.mtconnect.org/#Structure___19_0_3_45f01b9_1579566531114_503405_25727";
		/// <summary>Constant value for <see cref="DataSetClass.Summary" /></summary>
		public const string SUMMARY = @"&#10;&#10;&#10;{{block(Representation)}} for an {{block(Observation)}} composed of value(s) represented as a set of {{termplural(key-value pair)}}.
&#10;
&#10;&#10;&#10;Description&#10;&#10;&#10;&#10;
{{block(DataSet)}} for an {{block(Observation)}} is defined by the associated {{property(DataItem::representation)}} as `DATA_SET`.

{{property(DataItem::representation)}} as `DATA_SET` **MUST** have {{property(DataItem::category)}} as `SAMPLE` or `EVENT`.

{{figure(VariableDataSet)}} shows the model for {{block(Variable)}} ({{block(Event)}} type) with a {{block(Representation)}} type of {{block(DataSet)}}. 

![VariableDataSet](figures/VariableDataSet.png ""VariableDataSet""){: width=""0.8""}

> Note: See {{figure(DataSet Schema)}} for XML schema.

{{block(DataSet)}} reports multiple values as a set of {{term(key-value pair)}} where each {{term(key)}} **MUST** be unique. The representation of the {{term(key-value pair)}} is an {{block(Entry)}}. The value of each {{block(Entry)}} **MUST** have the same constraints and format as the {{block(Observation)}} defined for {{property(DataItem::representation)}} as `VALUE` for the {{block(DataItem)}} type. (See {{block(Value)}}). 

The meaning of each {{block(Entry)}} **MAY** be provided as the {{block(DataItem)}} {{block(EntryDefinition)}}.

{{figure(DataSet Example)}} shows {{block(Event)}} {{block(Observation)}} type {{block(Variable)}} with a {{block(Representation)}} type of `DataSet`.

![DataSet Example](figures/DataSet%20Example.png ""DataSet Example""){: width=""0.8""}

> Note: See {{lst(dataset-example)}} for the {{term(XML)}} representation of the same example.

#### Management of Data Set Observations

An {{term(agent)}} **MUST** maintain the current state of the {{block(DataSet)}} as described in {{package(Fundamentals)}}.

One or more {{termplural(key-value pair)}} **MAY** be added, removed, or changed in an {{block(Observation)}}. An {{term(agent)}} **MUST** publish the changes to one or more {{termplural(key-value pair)}} as a single {{block(Observation)}}. An {{term(agent)}} **MUST** indicate the removal of a {{term(key-value pair)}} from a {{block(DataSet)}} using the {{property(Entry::removed)}} as `true`.

When the {{property(DataItem::discrete)}} is `false` or is not present, an {{term(agent)}} in response to a {{term(sample request)}} **MUST** only publish the changed {{term(key-value pair)}} since the previous state of the {{block(DataSet)}}.

When the {{property(DataItem::discrete)}} attribute is `true`, an {{term(agent)}}, in response to a {{term(sample request)}}, **MUST** report all {{termplural(key-value pair)}} ignoring the state of the {{block(DataSet)}}.

When an {{term(agent)}} responds to a {{term(current request)}}, the {{term(response document)}} **MUST** include the full set of {{termplural(key-value pair)}}. If the {{term(current request)}} includes an `at` query parameter, the {{term(agent)}} **MUST** provide the set of {{termplural(key-value pair)}} at the  {{term(sequence number)}}.

When an {{block(Observation)}} {{term(reset)}} occurs, the {{block(DataSet)}} **MUST** remove all {{termplural(key-value pair)}} making the set empty. The {{block(Observation)}} **MAY** simultaneously populate the {{block(DataSet)}} with new {{termplural(key-value pair)}}. The previous entries **MUST NOT** be included and **MUST NOT** have {{property(Entry::removed)}} as `true`.

When the {{block(Observation)}}  is `UNAVAILABLE` the {{block(DataSet)}} **MUST** remove all {{termplural(key-value pair)}} making the set empty.&#10;
";
		/// <summary>Constant value for <see cref="DataSetClass.Name" /></summary>
		public const string NAME = "DataSet";
		/// <summary>Constant value for <see cref="DataSetClass.AccessModifier" /></summary>
		public const string ACCESS_MODIFIER = "public";
		/// <summary>Constant value for <see cref="DataSetClass.Modifier" /></summary>
		public const string MODIFIER = "";
		/// <summary>Constant value for <see cref="DataSetClass.NormativeVersion" /></summary>
		public const string NORMATIVE_VERSION = "1.5";
		/// <summary>Constant value for <see cref="DataSetClass.DeprecatedVersion" /></summary>
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
		/// Original Type: _19_0_3_68e0225_1633615188301_96457_1251
		/// </remarks>
		public Type Generalization => typeof(Mtconnect.ObservationInformationModel.Representations.RepresentationClass);

		/// <inheritdoc />
		public new DataSetClassProperties Properties { get; } = new DataSetClassProperties();
        IPropertyList IClass.Properties => Properties;
		/// <summary>
		/// Property list for <see cref="DataSetClass" />.
		/// <br/><b>Note</b>, some properties (<see cref="IProperty" />) are inherited from <see cref="Mtconnect.ObservationInformationModel.Representations.RepresentationClass.RepresentationClassProperties" />.
		/// </summary>
		public class DataSetClassProperties : Mtconnect.ObservationInformationModel.Representations.RepresentationClass.RepresentationClassProperties
		{
			/// <inheritdoc />
			public override IProperty[] Properties => new IProperty[] {
				Count,
				ResultPart,
			}.Concat(base.Properties).ToArray();
			/// <summary>
			/// <inheritdoc cref="CountProperty" path="/summary" /><br/>
			/// <remarks>Original Name: Count</remarks>
			/// </summary>
			public new CountProperty Count { get; } = new CountProperty();
			
			/// <summary>﻿number of <see cref="Entry">Entry</see> elements for the <see cref="Observation">Observation</see>.<br /><br /><br />
			/// </summary>
			public new sealed class CountProperty : IProperty
			{
				/// <summary>Constant value for <see cref="CountProperty.Name" /></summary>
				public const string NAME = "count";
				/// <summary>Constant value for <see cref="CountProperty.Summary" /></summary>
				public const string SUMMARY = @"&#10;&#10;&#10;number of {{block(Entry)}} elements for the {{block(Observation)}}.&#10;
";
				/// <summary>Constant value for <see cref="CountProperty.AccessModifier" /></summary>
				public const string ACCESS_MODIFIER = "public";
				/// <summary>Constant value for <see cref="CountProperty.Modifier" /></summary>
				public const string MODIFIER = "";
				/// <summary>Constant value for <see cref="CountProperty.NormativeVersion" /></summary>
				public const string NORMATIVE_VERSION = "1.5";
				/// <summary>Constant value for <see cref="CountProperty.DeprecatedVersion" /></summary>
				public const string DEPRECATED_VERSION = "";
				/// <summary>Constant value for <see cref="CountProperty.Aggregation" /></summary>
				public const string AGGREGATION = "";
				/// <summary>Constant value for <see cref="CountProperty.Extension" /></summary>
				public const string EXTENSION = "MagicDraw UML 19.0";
				/// <summary>Constant value for <see cref="CountProperty.Association" /></summary>
				public const string ASSOCIATION = "";
				/// <summary>Constant value for <see cref="CountProperty.DefaultValue" /></summary>
				public const string DEFAULT_VALUE = "";

				/// <summary>
				/// <inheritdoc />
				/// <remarks> Type: Int32 </remarks>
				/// </summary>
				public System.Type Type => typeof(Int32);
				
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
			/// <inheritdoc cref="ResultPartProperty" path="/summary" /><br/>
			/// <remarks>Original Name: Result</remarks>
			/// </summary>
			public new ResultPartProperty ResultPart { get; } = new ResultPartProperty();
			
			/// <summary>﻿
			/// </summary>
			public new sealed class ResultPartProperty : IProperty
			{
				/// <summary>Constant value for <see cref="ResultPartProperty.Name" /></summary>
				public const string NAME = "result";
				/// <summary>Constant value for <see cref="ResultPartProperty.Summary" /></summary>
				public const string SUMMARY = @"";
				/// <summary>Constant value for <see cref="ResultPartProperty.AccessModifier" /></summary>
				public const string ACCESS_MODIFIER = "public";
				/// <summary>Constant value for <see cref="ResultPartProperty.Modifier" /></summary>
				public const string MODIFIER = "";
				/// <summary>Constant value for <see cref="ResultPartProperty.NormativeVersion" /></summary>
				public const string NORMATIVE_VERSION = "1.5";
				/// <summary>Constant value for <see cref="ResultPartProperty.DeprecatedVersion" /></summary>
				public const string DEPRECATED_VERSION = "";
				/// <summary>Constant value for <see cref="ResultPartProperty.Aggregation" /></summary>
				public const string AGGREGATION = "composite";
				/// <summary>Constant value for <see cref="ResultPartProperty.Extension" /></summary>
				public const string EXTENSION = "";
				/// <summary>Constant value for <see cref="ResultPartProperty.Association" /></summary>
				public const string ASSOCIATION = "Entry";
				/// <summary>Constant value for <see cref="ResultPartProperty.DefaultValue" /></summary>
				public const string DEFAULT_VALUE = "";

				/// <summary>
				/// <inheritdoc />
				/// <remarks> Type: EntryClass </remarks>
				/// </summary>
				public System.Type Type => typeof(Mtconnect.ObservationInformationModel.Representations.EntryClass);
				
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