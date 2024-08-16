using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;
using System.Linq;

namespace Mtconnect.ObservationInformationModel.Representations
{
	/// <summary>
	﻿/// <see cref="Representation">Representation</see> for an <see cref="Observation">Observation</see> composed of two-dimensional sets of <i>key-value pair</i>s where the <see cref="Entry">Entry</see> represents rows containing sets of <i>key-value pair</i>s given by <see cref="Cell">Cell</see> entities. <br /><br/><br />Description<br/><see cref="Table">Table</see> for an <see cref="Observation">Observation</see> is defined by the associated <see cref="DataItem.representation">representation in DataItem</see> as <c>TABLE</c>.<br /><br /><see cref="DataItem.representation">representation in DataItem</see> as <c>TABLE</c> <b>MUST</b> have <see cref="DataItem.category">category in DataItem</see> as <c>SAMPLE</c> or <c>EVENT</c>.<br /><br />{{figure(WorkOffsetTable)}} shows the model for <see cref="WorkOffset">WorkOffset</see> (<see cref="Event">Event</see> type) with a <see cref="Representation">Representation</see> type of <see cref="Table">Table</see>. <br /><br />![WorkOffsetTable](figures/WorkOffsetTable.png "WorkOffsetTable"){: width="0.8"}<br /><br />> Note: See <see cref="Representation Schema Diagrams">Representation Schema Diagrams</see> for XML schema.<br /><br /><see cref="Table">Table</see> has the same behavior as the <see cref="DataSet">DataSet</see> for change tracking, clearing, and history. When an <see cref="Entry">Entry</see> changes, all <see cref="Cell">Cell</see> entities update at the same time; they are not tracked separately like <see cref="Entry">Entry</see>.<br /><br />The meaning of each <see cref="Entry">Entry</see> and <see cref="Cell">Cell</see> <b>MAY</b> be provided as the <see cref="DataItem">DataItem</see> <see cref="EntryDefinition">EntryDefinition</see> and <see cref="CellDefinition">CellDefinition</see>.<br /><br /><see cref="Entry.key">key in Entry</see>  <b>MUST</b> be the unique identity of the <see cref="Entry">Entry</see> within an <see cref="Observation">Observation</see>. <see cref="Cell.key">key in Cell</see> <b>MUST</b> be the unique identity of the <see cref="Cell">Cell</see> within an <see cref="Entry">Entry</see>.<br /><br />{{figure(Table Example)}} shows <see cref="Event">Event</see> <see cref="Observation">Observation</see> type <see cref="WorkOffset">WorkOffset</see> with a <see cref="Representation">Representation</see> type of <c>Table</c>.<br /><br />![Table Example](figures/Table%20Example.png "Table Example"){: width="0.8"}<br /><br />> Note: See {{lst(table-example)}} for the <i>XML</i> representation of the same example.<br /><br /><br/><br/><br />

	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Structure___19_0_3_45f01b9_1582846972437_483160_2181">model.mtconnect.org</seealso> for more information.
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public sealed class TableClass : IClass
	{
		/// <inheritdoc />
		public string ReferenceId => "_19_0_3_45f01b9_1582846972437_483160_2181";
		
		/// <inheritdoc />
		public string Summary => @"&#10;&#10;&#10;{{block(Representation)}} for an {{block(Observation)}} composed of two-dimensional sets of {{termplural(key-value pair)}} where the {{block(Entry)}} represents rows containing sets of {{termplural(key-value pair)}} given by {{block(Cell)}} entities. 
&#10;
&#10;&#10;&#10;Description&#10;&#10;&#10;&#10;{{block(Table)}} for an {{block(Observation)}} is defined by the associated {{property(DataItem::representation)}} as `TABLE`.

{{property(DataItem::representation)}} as `TABLE` **MUST** have {{property(DataItem::category)}} as `SAMPLE` or `EVENT`.

{{figure(WorkOffsetTable)}} shows the model for {{block(WorkOffset)}} ({{block(Event)}} type) with a {{block(Representation)}} type of {{block(Table)}}. 

![WorkOffsetTable](figures/WorkOffsetTable.png ""WorkOffsetTable""){: width=""0.8""}

> Note: See {{sect(Representation Schema Diagrams)}} for XML schema.

{{block(Table)}} has the same behavior as the {{block(DataSet)}} for change tracking, clearing, and history. When an {{block(Entry)}} changes, all {{block(Cell)}} entities update at the same time; they are not tracked separately like {{block(Entry)}}.

The meaning of each {{block(Entry)}} and {{block(Cell)}} **MAY** be provided as the {{block(DataItem)}} {{block(EntryDefinition)}} and {{block(CellDefinition)}}.

{{property(Entry::key)}}  **MUST** be the unique identity of the {{block(Entry)}} within an {{block(Observation)}}. {{property(Cell::key)}} **MUST** be the unique identity of the {{block(Cell)}} within an {{block(Entry)}}.

{{figure(Table Example)}} shows {{block(Event)}} {{block(Observation)}} type {{block(WorkOffset)}} with a {{block(Representation)}} type of `Table`.

![Table Example](figures/Table%20Example.png ""Table Example""){: width=""0.8""}

> Note: See {{lst(table-example)}} for the {{term(XML)}} representation of the same example.

&#10;
";

		/// <inheritdoc />
		public string Name => "Table";
		
		/// <inheritdoc />
		public string AccessModifier => "public";
				
		/// <inheritdoc />
		public string Modifier => "";
				
		/// <inheritdoc />
		public string NormativeVersion => "1.6";
				
		/// <inheritdoc />
		public string DeprecatedVersion => "";
		
		/// <inheritdoc />
		/// <remarks>
		/// Original Type: _19_0_3_68e0225_1633615188301_96457_1251
		/// </remarks>
		public Type Generalization => typeof(Mtconnect.ObservationInformationModel.Representations.RepresentationClass);

		/// <inheritdoc />
		public TableClassProperties Properties { get; } = new TableClassProperties();
        IPropertyList IClass.Properties => Properties;
		public class TableClassProperties : Mtconnect.ObservationInformationModel.Representations.RepresentationClass.RepresentationClassProperties
		{
			/// <inheritdoc />
			public IProperty[] Properties => new IProperty[] {
				ResultPart,
				Count,
			}.Concat(base.Properties).ToArray();
			/// <summary>
			/// <inheritdoc cref="ResultPartProperty" path="/summary" /><br/>
			/// <remarks>Original Name: Result</remarks>
			/// </summary>
			public ResultPartProperty ResultPart { get; } = new ResultPartProperty();
			public sealed class ResultPartProperty : IProperty
			{
				/// <summary>
				/// <inheritdoc />
				/// <remarks>
				/// <list type="bullet">
				/// <item>Original Type: _19_0_3_68e0225_1600164112807_45306_44</item>
				/// <item>Type: TableEntryClass</item>
				/// <item>Namespace: Mtconnect.ObservationInformationModel.Representations</item>
				/// </list>
				/// </remarks>
				/// </summary>
				public System.Type Type => typeof(Mtconnect.ObservationInformationModel.Representations.TableEntryClass);
				
				/// <inheritdoc />
				public string Name => "result";
				
				/// <inheritdoc />
				public string Summary => @"";

				/// <inheritdoc />
				public string AccessModifier => "public";
				
				/// <inheritdoc />
				public string Modifier => "";
				
				/// <inheritdoc />
				public string NormativeVersion => "1.6";
				
				/// <inheritdoc />
				public string DeprecatedVersion => "";
				
				/// <inheritdoc />
				public string Aggregation => "composite";

				// Note: Extension.Extender
				/// <inheritdoc />
				public string Extension => "";
				
				/// <inheritdoc />
				public string Association => "TableEntry";

				// Note: DefaultValue.Name
				/// <inheritdoc />
				public string DefaultValue => "";
			}
			/// <summary>
			/// <inheritdoc cref="CountProperty" path="/summary" /><br/>
			/// <remarks>Original Name: Count</remarks>
			/// </summary>
			public CountProperty Count { get; } = new CountProperty();
			/// <summary>
			﻿/// number of <i>key-value pair</i>s represented as <see cref="Entry">Entry</see> entities.<br/><br />

			/// </summary>
			public sealed class CountProperty : IProperty
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
				public string Name => "count";
				
				/// <inheritdoc />
				public string Summary => @"&#10;&#10;&#10;number of {{termplural(key-value pair)}} represented as {{block(Entry)}} entities.&#10;
";

				/// <inheritdoc />
				public string AccessModifier => "public";
				
				/// <inheritdoc />
				public string Modifier => "";
				
				/// <inheritdoc />
				public string NormativeVersion => "1.6";
				
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