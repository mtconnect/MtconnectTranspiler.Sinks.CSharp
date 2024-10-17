#pragma warning disable CS0109 // Member does not hide an inherited member; new keyword is not required
#pragma warning disable CS1574 // XML comment has cref attribute that could not be resolved
#pragma warning disable CS1584 // XML comment has syntactically incorrect cref attribute
#pragma warning disable CS0618 // Type or member is obsolete
using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;

namespace Mtconnect.DeviceInformationModel.DataItems.PropertiesOfDataItem
{
	/// <summary>﻿defines the meaning of <see cref="Entry">Entry</see> and <see cref="Cell">Cell</see> entities when the associated <see cref="DataItem.representation">representation in DataItem</see> is either <c>DATA_SET</c> or <c>TABLE</c>.<br /><br /><br />
	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Structure___19_0_3_45f01b9_1581433165009_756087_158">model.mtconnect.org</seealso> for more information.
	/// </summary>
	/// <remarks>
	/// <list type="bullet">
	/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.6">v1.6</see></item>
	/// </list>
	/// </remarks>

	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public sealed class DefinitionClass : IClass
	{
		/// <summary>Constant value for <see cref="DefinitionClass.ReferenceId" /></summary>
		public const string REFERENCE_ID = "_19_0_3_45f01b9_1581433165009_756087_158";
		/// <summary>Constant value for <see cref="DefinitionClass.HelpUrl" /></summary>
		public const string HELP_URL = "https://model.mtconnect.org/#Structure___19_0_3_45f01b9_1581433165009_756087_158";
		/// <summary>Constant value for <see cref="DefinitionClass.Summary" /></summary>
		public const string SUMMARY = @"&#10;&#10;&#10;defines the meaning of {{block(Entry)}} and {{block(Cell)}} entities when the associated {{property(DataItem::representation)}} is either `DATA_SET` or `TABLE`.&#10;
";
		/// <summary>Constant value for <see cref="DefinitionClass.Name" /></summary>
		public const string NAME = "Definition";
		/// <summary>Constant value for <see cref="DefinitionClass.AccessModifier" /></summary>
		public const string ACCESS_MODIFIER = "public";
		/// <summary>Constant value for <see cref="DefinitionClass.Modifier" /></summary>
		public const string MODIFIER = "";
		/// <summary>Constant value for <see cref="DefinitionClass.NormativeVersion" /></summary>
		public const string NORMATIVE_VERSION = "1.6";
		/// <summary>Constant value for <see cref="DefinitionClass.DeprecatedVersion" /></summary>
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
		public new DefinitionClassProperties Properties { get; } = new DefinitionClassProperties();
        IPropertyList IClass.Properties => Properties;
		/// <summary>
		/// Property list for <see cref="DefinitionClass" />.
		/// </summary>
		public class DefinitionClassProperties : IPropertyList
		{
			/// <inheritdoc />
			public virtual IProperty[] Properties => new IProperty[] {
				HasCellDefinitionPart,
				HasEntryDefinitionPart,
				Description,
			};
			/// <summary>
			/// <inheritdoc cref="HasCellDefinitionPartProperty" path="/summary" /><br/>
			/// <remarks>Original Name: HasCellDefinition</remarks>
			/// </summary>
			public HasCellDefinitionPartProperty HasCellDefinitionPart { get; } = new HasCellDefinitionPartProperty();
			
			/// <summary>﻿
			/// </summary>
			public sealed class HasCellDefinitionPartProperty : IProperty
			{
				/// <summary>Constant value for <see cref="HasCellDefinitionPartProperty.Name" /></summary>
				public const string NAME = "hasCellDefinition";
				/// <summary>Constant value for <see cref="HasCellDefinitionPartProperty.Summary" /></summary>
				public const string SUMMARY = @"";
				/// <summary>Constant value for <see cref="HasCellDefinitionPartProperty.AccessModifier" /></summary>
				public const string ACCESS_MODIFIER = "public";
				/// <summary>Constant value for <see cref="HasCellDefinitionPartProperty.Modifier" /></summary>
				public const string MODIFIER = "";
				/// <summary>Constant value for <see cref="HasCellDefinitionPartProperty.NormativeVersion" /></summary>
				public const string NORMATIVE_VERSION = "";
				/// <summary>Constant value for <see cref="HasCellDefinitionPartProperty.DeprecatedVersion" /></summary>
				public const string DEPRECATED_VERSION = "";
				/// <summary>Constant value for <see cref="HasCellDefinitionPartProperty.Aggregation" /></summary>
				public const string AGGREGATION = "composite";
				/// <summary>Constant value for <see cref="HasCellDefinitionPartProperty.Extension" /></summary>
				public const string EXTENSION = "";
				/// <summary>Constant value for <see cref="HasCellDefinitionPartProperty.Association" /></summary>
				public const string ASSOCIATION = "CellDefinitions";
				/// <summary>Constant value for <see cref="HasCellDefinitionPartProperty.DefaultValue" /></summary>
				public const string DEFAULT_VALUE = "";

				/// <summary>
				/// <inheritdoc />
				/// <remarks> Type: CellDefinitionClass </remarks>
				/// </summary>
				public System.Type Type => typeof(Mtconnect.DeviceInformationModel.DataItems.PropertiesOfDataItem.PropertiesOfDefinition.CellDefinitionClass);
				
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
			/// <inheritdoc cref="HasEntryDefinitionPartProperty" path="/summary" /><br/>
			/// <remarks>Original Name: HasEntryDefinition</remarks>
			/// </summary>
			public HasEntryDefinitionPartProperty HasEntryDefinitionPart { get; } = new HasEntryDefinitionPartProperty();
			
			/// <summary>﻿
			/// </summary>
			public sealed class HasEntryDefinitionPartProperty : IProperty
			{
				/// <summary>Constant value for <see cref="HasEntryDefinitionPartProperty.Name" /></summary>
				public const string NAME = "hasEntryDefinition";
				/// <summary>Constant value for <see cref="HasEntryDefinitionPartProperty.Summary" /></summary>
				public const string SUMMARY = @"";
				/// <summary>Constant value for <see cref="HasEntryDefinitionPartProperty.AccessModifier" /></summary>
				public const string ACCESS_MODIFIER = "public";
				/// <summary>Constant value for <see cref="HasEntryDefinitionPartProperty.Modifier" /></summary>
				public const string MODIFIER = "";
				/// <summary>Constant value for <see cref="HasEntryDefinitionPartProperty.NormativeVersion" /></summary>
				public const string NORMATIVE_VERSION = "";
				/// <summary>Constant value for <see cref="HasEntryDefinitionPartProperty.DeprecatedVersion" /></summary>
				public const string DEPRECATED_VERSION = "";
				/// <summary>Constant value for <see cref="HasEntryDefinitionPartProperty.Aggregation" /></summary>
				public const string AGGREGATION = "composite";
				/// <summary>Constant value for <see cref="HasEntryDefinitionPartProperty.Extension" /></summary>
				public const string EXTENSION = "";
				/// <summary>Constant value for <see cref="HasEntryDefinitionPartProperty.Association" /></summary>
				public const string ASSOCIATION = "EntryDefinitions";
				/// <summary>Constant value for <see cref="HasEntryDefinitionPartProperty.DefaultValue" /></summary>
				public const string DEFAULT_VALUE = "";

				/// <summary>
				/// <inheritdoc />
				/// <remarks> Type: EntryDefinitionClass </remarks>
				/// </summary>
				public System.Type Type => typeof(Mtconnect.DeviceInformationModel.DataItems.PropertiesOfDataItem.PropertiesOfDefinition.EntryDefinitionClass);
				
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
			/// <inheritdoc cref="DescriptionProperty" path="/summary" /><br/>
			/// <remarks>Original Name: Description</remarks>
			/// </summary>
			public DescriptionProperty Description { get; } = new DescriptionProperty();
			
			/// <summary>﻿textual description for <see cref="Definition">Definition</see>.<br /><br /><br />
			/// </summary>
			public sealed class DescriptionProperty : IProperty
			{
				/// <summary>Constant value for <see cref="DescriptionProperty.Name" /></summary>
				public const string NAME = "Description";
				/// <summary>Constant value for <see cref="DescriptionProperty.Summary" /></summary>
				public const string SUMMARY = @"&#10;&#10;&#10;textual description for {{block(Definition)}}.&#10;
";
				/// <summary>Constant value for <see cref="DescriptionProperty.AccessModifier" /></summary>
				public const string ACCESS_MODIFIER = "private";
				/// <summary>Constant value for <see cref="DescriptionProperty.Modifier" /></summary>
				public const string MODIFIER = "";
				/// <summary>Constant value for <see cref="DescriptionProperty.NormativeVersion" /></summary>
				public const string NORMATIVE_VERSION = "1.6";
				/// <summary>Constant value for <see cref="DescriptionProperty.DeprecatedVersion" /></summary>
				public const string DEPRECATED_VERSION = "";
				/// <summary>Constant value for <see cref="DescriptionProperty.Aggregation" /></summary>
				public const string AGGREGATION = "composite";
				/// <summary>Constant value for <see cref="DescriptionProperty.Extension" /></summary>
				public const string EXTENSION = "MagicDraw UML 2024x";
				/// <summary>Constant value for <see cref="DescriptionProperty.Association" /></summary>
				public const string ASSOCIATION = "";
				/// <summary>Constant value for <see cref="DescriptionProperty.DefaultValue" /></summary>
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
		};

	}
}