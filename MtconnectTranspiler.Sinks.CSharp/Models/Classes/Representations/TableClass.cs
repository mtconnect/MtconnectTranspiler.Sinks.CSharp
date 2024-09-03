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
	/// <summary>﻿<see cref="Representation">Representation</see> for an <see cref="Observation">Observation</see> composed of two-dimensional sets of <i>key-value pair</i>s where the <see cref="Entry">Entry</see> represents rows containing sets of <i>key-value pair</i>s given by <see cref="Cell">Cell</see> entities. <br /><br /><br /><br />Description<br /><br /><see cref="Table">Table</see> for an <see cref="Observation">Observation</see> is defined by the associated <see cref="DataItem.representation">representation in DataItem</see> as <c>TABLE</c>.<br /><br /><see cref="DataItem.representation">representation in DataItem</see> as <c>TABLE</c> <b>MUST</b> have <see cref="DataItem.category">category in DataItem</see> as <c>SAMPLE</c> or <c>EVENT</c>.<br /><br />{{figure(WorkOffsetTable)}} shows the model for <see cref="WorkOffset">WorkOffset</see> (<see cref="Event">Event</see> type) with a <see cref="Representation">Representation</see> type of <see cref="Table">Table</see>. <br /><br />![WorkOffsetTable](figures/WorkOffsetTable.png "WorkOffsetTable"){: width="0.8"}<br /><br />&gt; Note: See <see cref="Representation Schema Diagrams">Representation Schema Diagrams</see> for XML schema.<br /><br /><see cref="Table">Table</see> has the same behavior as the <see cref="DataSet">DataSet</see> for change tracking, clearing, and history. When an <see cref="Entry">Entry</see> changes, all <see cref="Cell">Cell</see> entities update at the same time; they are not tracked separately like <see cref="Entry">Entry</see>.<br /><br />The meaning of each <see cref="Entry">Entry</see> and <see cref="Cell">Cell</see> <b>MAY</b> be provided as the <see cref="DataItem">DataItem</see> <see cref="EntryDefinition">EntryDefinition</see> and <see cref="CellDefinition">CellDefinition</see>.<br /><br /><see cref="Entry.key">key in Entry</see>  <b>MUST</b> be the unique identity of the <see cref="Entry">Entry</see> within an <see cref="Observation">Observation</see>. <see cref="Cell.key">key in Cell</see> <b>MUST</b> be the unique identity of the <see cref="Cell">Cell</see> within an <see cref="Entry">Entry</see>.<br /><br />{{figure(Table Example)}} shows <see cref="Event">Event</see> <see cref="Observation">Observation</see> type <see cref="WorkOffset">WorkOffset</see> with a <see cref="Representation">Representation</see> type of <c>Table</c>.<br /><br />![Table Example](figures/Table%20Example.png "Table Example"){: width="0.8"}<br /><br />&gt; Note: See {{lst(table-example)}} for the <i>XML</i> representation of the same example.<br /><br /><br /><br /><br /><br /><br />
	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Structure___19_0_3_45f01b9_1582846972437_483160_2181">model.mtconnect.org</seealso> for more information.
	/// </summary>
	/// <remarks>
	/// <list type="bullet">
	/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.6">v1.6</see></item>
	/// </list>
	/// </remarks>

	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public sealed class TableClass : IClass
	{
		/// <summary>Constant value for <see cref="TableClass.ReferenceId" /></summary>
		public const string REFERENCE_ID = "_19_0_3_45f01b9_1582846972437_483160_2181";
		/// <summary>Constant value for <see cref="TableClass.HelpUrl" /></summary>
		public const string HELP_URL = "https://model.mtconnect.org/#Structure___19_0_3_45f01b9_1582846972437_483160_2181";
		/// <summary>Constant value for <see cref="TableClass.Summary" /></summary>
		public const string SUMMARY = @"&#10;&#10;&#10;{{block(Representation)}} for an {{block(Observation)}} composed of two-dimensional sets of {{termplural(key-value pair)}} where the {{block(Entry)}} represents rows containing sets of {{termplural(key-value pair)}} given by {{block(Cell)}} entities. 
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
		/// <summary>Constant value for <see cref="TableClass.Name" /></summary>
		public const string NAME = "Table";
		/// <summary>Constant value for <see cref="TableClass.AccessModifier" /></summary>
		public const string ACCESS_MODIFIER = "public";
		/// <summary>Constant value for <see cref="TableClass.Modifier" /></summary>
		public const string MODIFIER = "";
		/// <summary>Constant value for <see cref="TableClass.NormativeVersion" /></summary>
		public const string NORMATIVE_VERSION = "1.6";
		/// <summary>Constant value for <see cref="TableClass.DeprecatedVersion" /></summary>
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
		public new TableClassProperties Properties { get; } = new TableClassProperties();
        IPropertyList IClass.Properties => Properties;
		/// <summary>
		/// Property list for <see cref="TableClass" />.
		/// <br/><b>Note</b>, some properties (<see cref="IProperty" />) are inherited from <see cref="Mtconnect.ObservationInformationModel.Representations.RepresentationClass.RepresentationClassProperties" />.
		/// </summary>
		public class TableClassProperties : Mtconnect.ObservationInformationModel.Representations.RepresentationClass.RepresentationClassProperties
		{
			/// <inheritdoc />
			public override IProperty[] Properties => new IProperty[] {
				ResultPart,
				Count,
			}.Concat(base.Properties).ToArray();
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
				public const string NORMATIVE_VERSION = "1.6";
				/// <summary>Constant value for <see cref="ResultPartProperty.DeprecatedVersion" /></summary>
				public const string DEPRECATED_VERSION = "";
				/// <summary>Constant value for <see cref="ResultPartProperty.Aggregation" /></summary>
				public const string AGGREGATION = "composite";
				/// <summary>Constant value for <see cref="ResultPartProperty.Extension" /></summary>
				public const string EXTENSION = "";
				/// <summary>Constant value for <see cref="ResultPartProperty.Association" /></summary>
				public const string ASSOCIATION = "TableEntry";
				/// <summary>Constant value for <see cref="ResultPartProperty.DefaultValue" /></summary>
				public const string DEFAULT_VALUE = "";

				/// <summary>
				/// <inheritdoc />
				/// <remarks> Type: TableEntryClass </remarks>
				/// </summary>
				public System.Type Type => typeof(Mtconnect.ObservationInformationModel.Representations.TableEntryClass);
				
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
			/// <inheritdoc cref="CountProperty" path="/summary" /><br/>
			/// <remarks>Original Name: Count</remarks>
			/// </summary>
			public new CountProperty Count { get; } = new CountProperty();
			
			/// <summary>﻿number of <i>key-value pair</i>s represented as <see cref="Entry">Entry</see> entities.<br /><br /><br />
			/// </summary>
			public new sealed class CountProperty : IProperty
			{
				/// <summary>Constant value for <see cref="CountProperty.Name" /></summary>
				public const string NAME = "count";
				/// <summary>Constant value for <see cref="CountProperty.Summary" /></summary>
				public const string SUMMARY = @"&#10;&#10;&#10;number of {{termplural(key-value pair)}} represented as {{block(Entry)}} entities.&#10;
";
				/// <summary>Constant value for <see cref="CountProperty.AccessModifier" /></summary>
				public const string ACCESS_MODIFIER = "public";
				/// <summary>Constant value for <see cref="CountProperty.Modifier" /></summary>
				public const string MODIFIER = "";
				/// <summary>Constant value for <see cref="CountProperty.NormativeVersion" /></summary>
				public const string NORMATIVE_VERSION = "1.6";
				/// <summary>Constant value for <see cref="CountProperty.DeprecatedVersion" /></summary>
				public const string DEPRECATED_VERSION = "";
				/// <summary>Constant value for <see cref="CountProperty.Aggregation" /></summary>
				public const string AGGREGATION = "composite";
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
		};

	}
}