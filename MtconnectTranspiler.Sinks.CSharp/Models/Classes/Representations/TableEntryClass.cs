#pragma warning disable CS0109 // Member does not hide an inherited member; new keyword is not required
#pragma warning disable CS1574 // XML comment has cref attribute that could not be resolved
#pragma warning disable CS1584 // XML comment has syntactically incorrect cref attribute
#pragma warning disable CS0618 // Type or member is obsolete
using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;

namespace Mtconnect.ObservationInformationModel.Representations
{
	/// <summary>﻿<i>key-value pair</i> published as part of a <see cref="Table">Table</see>.<br /><br />&gt; Note: In the <i>XML</i> representation, <see cref="TableEntry">TableEntry</see> <b>MUST</b> appear as <see cref="Entry">Entry</see>.<br /><br /><br /><br /><br />
	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Structure___19_0_3_68e0225_1600164112807_45306_44">model.mtconnect.org</seealso> for more information.
	/// </summary>
	/// <remarks>
	/// <list type="bullet">
	/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.6">v1.6</see></item>
	/// </list>
	/// </remarks>

	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public sealed class TableEntryClass : IClass
	{
		/// <summary>Constant value for <see cref="TableEntryClass.ReferenceId" /></summary>
		public const string REFERENCE_ID = "_19_0_3_68e0225_1600164112807_45306_44";
		/// <summary>Constant value for <see cref="TableEntryClass.HelpUrl" /></summary>
		public const string HELP_URL = "https://model.mtconnect.org/#Structure___19_0_3_68e0225_1600164112807_45306_44";
		/// <summary>Constant value for <see cref="TableEntryClass.Summary" /></summary>
		public const string SUMMARY = @"&#10;&#10;&#10;{{term(key-value pair)}} published as part of a {{block(Table)}}.

> Note: In the {{term(XML)}} representation, {{block(TableEntry)}} **MUST** appear as {{block(Entry)}}.

&#10;
";
		/// <summary>Constant value for <see cref="TableEntryClass.Name" /></summary>
		public const string NAME = "TableEntry";
		/// <summary>Constant value for <see cref="TableEntryClass.AccessModifier" /></summary>
		public const string ACCESS_MODIFIER = "public";
		/// <summary>Constant value for <see cref="TableEntryClass.Modifier" /></summary>
		public const string MODIFIER = "";
		/// <summary>Constant value for <see cref="TableEntryClass.NormativeVersion" /></summary>
		public const string NORMATIVE_VERSION = "1.6";
		/// <summary>Constant value for <see cref="TableEntryClass.DeprecatedVersion" /></summary>
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
		public Type Generalization => null;

		/// <inheritdoc />
		public new TableEntryClassProperties Properties { get; } = new TableEntryClassProperties();
        IPropertyList IClass.Properties => Properties;
		/// <summary>
		/// Property list for <see cref="TableEntryClass" />.
		/// </summary>
		public class TableEntryClassProperties : IPropertyList
		{
			/// <inheritdoc />
			public virtual IProperty[] Properties => new IProperty[] {
				Key,
				Removed,
				ResultPart,
				IsEntryForPart,
			};
			/// <summary>
			/// <inheritdoc cref="KeyProperty" path="/summary" /><br/>
			/// <remarks>Original Name: Key</remarks>
			/// </summary>
			public KeyProperty Key { get; } = new KeyProperty();
			
			/// <summary>﻿unique identifier for each <i>key-value pair</i>.<br /><br /><br />
			/// </summary>
			public sealed class KeyProperty : IProperty
			{
				/// <summary>Constant value for <see cref="KeyProperty.Name" /></summary>
				public const string NAME = "key";
				/// <summary>Constant value for <see cref="KeyProperty.Summary" /></summary>
				public const string SUMMARY = @"&#10;&#10;&#10;unique identifier for each {{term(key-value pair)}}.&#10;
";
				/// <summary>Constant value for <see cref="KeyProperty.AccessModifier" /></summary>
				public const string ACCESS_MODIFIER = "public";
				/// <summary>Constant value for <see cref="KeyProperty.Modifier" /></summary>
				public const string MODIFIER = "";
				/// <summary>Constant value for <see cref="KeyProperty.NormativeVersion" /></summary>
				public const string NORMATIVE_VERSION = "1.6";
				/// <summary>Constant value for <see cref="KeyProperty.DeprecatedVersion" /></summary>
				public const string DEPRECATED_VERSION = "";
				/// <summary>Constant value for <see cref="KeyProperty.Aggregation" /></summary>
				public const string AGGREGATION = "";
				/// <summary>Constant value for <see cref="KeyProperty.Extension" /></summary>
				public const string EXTENSION = "MagicDraw UML 2024x";
				/// <summary>Constant value for <see cref="KeyProperty.Association" /></summary>
				public const string ASSOCIATION = "";
				/// <summary>Constant value for <see cref="KeyProperty.DefaultValue" /></summary>
				public const string DEFAULT_VALUE = "";

				/// <summary>
				/// <inheritdoc />
				/// <remarks> Type: String </remarks>
				/// </summary>
				public System.Type Type => typeof(String);
				
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
			/// <inheritdoc cref="RemovedProperty" path="/summary" /><br/>
			/// <remarks>Original Name: Removed</remarks>
			/// </summary>
			public RemovedProperty Removed { get; } = new RemovedProperty();
			
			/// <summary>﻿removal indicator of a <i>key-value pair</i>.<br /><br /><br />
			/// </summary>
			public sealed class RemovedProperty : IProperty
			{
				/// <summary>Constant value for <see cref="RemovedProperty.Name" /></summary>
				public const string NAME = "removed";
				/// <summary>Constant value for <see cref="RemovedProperty.Summary" /></summary>
				public const string SUMMARY = @"&#10;&#10;&#10;removal indicator of a {{term(key-value pair)}}.&#10;
";
				/// <summary>Constant value for <see cref="RemovedProperty.AccessModifier" /></summary>
				public const string ACCESS_MODIFIER = "public";
				/// <summary>Constant value for <see cref="RemovedProperty.Modifier" /></summary>
				public const string MODIFIER = "";
				/// <summary>Constant value for <see cref="RemovedProperty.NormativeVersion" /></summary>
				public const string NORMATIVE_VERSION = "1.6";
				/// <summary>Constant value for <see cref="RemovedProperty.DeprecatedVersion" /></summary>
				public const string DEPRECATED_VERSION = "";
				/// <summary>Constant value for <see cref="RemovedProperty.Aggregation" /></summary>
				public const string AGGREGATION = "";
				/// <summary>Constant value for <see cref="RemovedProperty.Extension" /></summary>
				public const string EXTENSION = "MagicDraw UML 2024x";
				/// <summary>Constant value for <see cref="RemovedProperty.Association" /></summary>
				public const string ASSOCIATION = "";
				/// <summary>Constant value for <see cref="RemovedProperty.DefaultValue" /></summary>
				public const string DEFAULT_VALUE = "";

				/// <summary>
				/// <inheritdoc />
				/// <remarks> Type: Boolean </remarks>
				/// </summary>
				public System.Type Type => typeof(Boolean);
				
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
			public ResultPartProperty ResultPart { get; } = new ResultPartProperty();
			
			/// <summary>﻿
			/// </summary>
			public sealed class ResultPartProperty : IProperty
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
				public const string ASSOCIATION = "Cell";
				/// <summary>Constant value for <see cref="ResultPartProperty.DefaultValue" /></summary>
				public const string DEFAULT_VALUE = "";

				/// <summary>
				/// <inheritdoc />
				/// <remarks> Type: CellClass </remarks>
				/// </summary>
				public System.Type Type => typeof(Mtconnect.ObservationInformationModel.Representations.CellClass);
				
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
			/// <inheritdoc cref="IsEntryForPartProperty" path="/summary" /><br/>
			/// <remarks>Original Name: IsEntryFor</remarks>
			/// </summary>
			public IsEntryForPartProperty IsEntryForPart { get; } = new IsEntryForPartProperty();
			
			/// <summary>﻿
			/// </summary>
			public sealed class IsEntryForPartProperty : IProperty
			{
				/// <summary>Constant value for <see cref="IsEntryForPartProperty.Name" /></summary>
				public const string NAME = "isEntryFor";
				/// <summary>Constant value for <see cref="IsEntryForPartProperty.Summary" /></summary>
				public const string SUMMARY = @"";
				/// <summary>Constant value for <see cref="IsEntryForPartProperty.AccessModifier" /></summary>
				public const string ACCESS_MODIFIER = "private";
				/// <summary>Constant value for <see cref="IsEntryForPartProperty.Modifier" /></summary>
				public const string MODIFIER = "";
				/// <summary>Constant value for <see cref="IsEntryForPartProperty.NormativeVersion" /></summary>
				public const string NORMATIVE_VERSION = "";
				/// <summary>Constant value for <see cref="IsEntryForPartProperty.DeprecatedVersion" /></summary>
				public const string DEPRECATED_VERSION = "";
				/// <summary>Constant value for <see cref="IsEntryForPartProperty.Aggregation" /></summary>
				public const string AGGREGATION = "";
				/// <summary>Constant value for <see cref="IsEntryForPartProperty.Extension" /></summary>
				public const string EXTENSION = "MagicDraw UML 2024x";
				/// <summary>Constant value for <see cref="IsEntryForPartProperty.Association" /></summary>
				public const string ASSOCIATION = "TableEntry";
				/// <summary>Constant value for <see cref="IsEntryForPartProperty.DefaultValue" /></summary>
				public const string DEFAULT_VALUE = "";

				/// <summary>
				/// <inheritdoc />
				/// <remarks> Type: TableClass </remarks>
				/// </summary>
				public System.Type Type => typeof(Mtconnect.ObservationInformationModel.Representations.TableClass);
				
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