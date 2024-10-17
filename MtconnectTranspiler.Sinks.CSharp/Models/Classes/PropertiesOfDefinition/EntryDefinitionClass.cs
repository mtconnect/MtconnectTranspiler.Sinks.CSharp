#pragma warning disable CS0109 // Member does not hide an inherited member; new keyword is not required
#pragma warning disable CS1574 // XML comment has cref attribute that could not be resolved
#pragma warning disable CS1584 // XML comment has syntactically incorrect cref attribute
#pragma warning disable CS0618 // Type or member is obsolete
using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;

namespace Mtconnect.DeviceInformationModel.DataItems.PropertiesOfDataItem.PropertiesOfDefinition
{
	/// <summary>﻿semantic definition of an <see cref="Entry">Entry</see>.<br /><br /><br />
	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Structure___19_0_3_45f01b9_1582939685398_830533_4339">model.mtconnect.org</seealso> for more information.
	/// </summary>
	/// <remarks>
	/// <list type="bullet">
	/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.6">v1.6</see></item>
	/// </list>
	/// </remarks>

	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public sealed class EntryDefinitionClass : IClass
	{
		/// <summary>Constant value for <see cref="EntryDefinitionClass.ReferenceId" /></summary>
		public const string REFERENCE_ID = "_19_0_3_45f01b9_1582939685398_830533_4339";
		/// <summary>Constant value for <see cref="EntryDefinitionClass.HelpUrl" /></summary>
		public const string HELP_URL = "https://model.mtconnect.org/#Structure___19_0_3_45f01b9_1582939685398_830533_4339";
		/// <summary>Constant value for <see cref="EntryDefinitionClass.Summary" /></summary>
		public const string SUMMARY = @"&#10;&#10;&#10;semantic definition of an {{block(Entry)}}.&#10;
";
		/// <summary>Constant value for <see cref="EntryDefinitionClass.Name" /></summary>
		public const string NAME = "EntryDefinition";
		/// <summary>Constant value for <see cref="EntryDefinitionClass.AccessModifier" /></summary>
		public const string ACCESS_MODIFIER = "public";
		/// <summary>Constant value for <see cref="EntryDefinitionClass.Modifier" /></summary>
		public const string MODIFIER = "";
		/// <summary>Constant value for <see cref="EntryDefinitionClass.NormativeVersion" /></summary>
		public const string NORMATIVE_VERSION = "1.6";
		/// <summary>Constant value for <see cref="EntryDefinitionClass.DeprecatedVersion" /></summary>
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
		public new EntryDefinitionClassProperties Properties { get; } = new EntryDefinitionClassProperties();
        IPropertyList IClass.Properties => Properties;
		/// <summary>
		/// Property list for <see cref="EntryDefinitionClass" />.
		/// </summary>
		public class EntryDefinitionClassProperties : IPropertyList
		{
			/// <inheritdoc />
			public virtual IProperty[] Properties => new IProperty[] {
				Key,
				Units,
				HasCellDefinitionPart,
				Type,
				SubType,
				KeyType,
				Description,
			};
			/// <summary>
			/// <inheritdoc cref="KeyProperty" path="/summary" /><br/>
			/// <remarks>Original Name: Key</remarks>
			/// </summary>
			public KeyProperty Key { get; } = new KeyProperty();
			
			/// <summary>﻿unique identification of the <see cref="Entry">Entry</see> in the <see cref="Definition">Definition</see>. <br /><br />The description applies to all <see cref="Entry">Entry</see> <i>observation</i>s having this <see cref="EntryDefinition.key">key in EntryDefinition</see>.<br /><br /><br />
			/// </summary>
			public sealed class KeyProperty : IProperty
			{
				/// <summary>Constant value for <see cref="KeyProperty.Name" /></summary>
				public const string NAME = "key";
				/// <summary>Constant value for <see cref="KeyProperty.Summary" /></summary>
				public const string SUMMARY = @"&#10;&#10;&#10;unique identification of the {{block(Entry)}} in the {{block(Definition)}}. 

The description applies to all {{block(Entry)}} {{termplural(observation)}} having this {{property(EntryDefinition::key)}}.&#10;
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
				public const string AGGREGATION = "composite";
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
			/// <inheritdoc cref="UnitsProperty" path="/summary" /><br/>
			/// <remarks>Original Name: Units</remarks>
			/// </summary>
			public UnitsProperty Units { get; } = new UnitsProperty();
			
			/// <summary>﻿same as <see cref="DataItem.units">units in DataItem</see>. See <see cref="Value Properties of DataItem">Value Properties of DataItem</see>.<br /><br /><br />
			/// </summary>
			public sealed class UnitsProperty : IProperty
			{
				/// <summary>Constant value for <see cref="UnitsProperty.Name" /></summary>
				public const string NAME = "units";
				/// <summary>Constant value for <see cref="UnitsProperty.Summary" /></summary>
				public const string SUMMARY = @"&#10;&#10;&#10;same as {{property(DataItem::units)}}. See {{sect(Value Properties of DataItem)}}.&#10;
";
				/// <summary>Constant value for <see cref="UnitsProperty.AccessModifier" /></summary>
				public const string ACCESS_MODIFIER = "public";
				/// <summary>Constant value for <see cref="UnitsProperty.Modifier" /></summary>
				public const string MODIFIER = "";
				/// <summary>Constant value for <see cref="UnitsProperty.NormativeVersion" /></summary>
				public const string NORMATIVE_VERSION = "1.6";
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
			/// <inheritdoc cref="TypeProperty" path="/summary" /><br/>
			/// <remarks>Original Name: Type</remarks>
			/// </summary>
			public TypeProperty Type { get; } = new TypeProperty();
			
			/// <summary>﻿same as <see cref="DataItem.type">type in DataItem</see>. See <see cref="DataItem Types">DataItem Types</see>.<br /><br /><br />
			/// </summary>
			public sealed class TypeProperty : IProperty
			{
				/// <summary>Constant value for <see cref="TypeProperty.Name" /></summary>
				public const string NAME = "type";
				/// <summary>Constant value for <see cref="TypeProperty.Summary" /></summary>
				public const string SUMMARY = @"&#10;&#10;&#10;same as {{property(DataItem::type)}}. See {{package(DataItem Types)}}.&#10;
";
				/// <summary>Constant value for <see cref="TypeProperty.AccessModifier" /></summary>
				public const string ACCESS_MODIFIER = "public";
				/// <summary>Constant value for <see cref="TypeProperty.Modifier" /></summary>
				public const string MODIFIER = "";
				/// <summary>Constant value for <see cref="TypeProperty.NormativeVersion" /></summary>
				public const string NORMATIVE_VERSION = "1.6";
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
				/// <remarks> Type: DataItemTypeEnumMetaClass </remarks>
				/// </summary>
				public System.Type Type => typeof(Mtconnect.DataTypes.DataItemTypeEnumMetaClass);
				
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
			/// <inheritdoc cref="SubTypeProperty" path="/summary" /><br/>
			/// <remarks>Original Name: SubType</remarks>
			/// </summary>
			public SubTypeProperty SubType { get; } = new SubTypeProperty();
			
			/// <summary>﻿same as <see cref="DataItem.subType">subType in DataItem</see>. See <see cref="DataItem">DataItem</see>.<br /><br /><br />
			/// </summary>
			public sealed class SubTypeProperty : IProperty
			{
				/// <summary>Constant value for <see cref="SubTypeProperty.Name" /></summary>
				public const string NAME = "subType";
				/// <summary>Constant value for <see cref="SubTypeProperty.Summary" /></summary>
				public const string SUMMARY = @"&#10;&#10;&#10;same as {{property(DataItem::subType)}}. See {{sect(DataItem)}}.&#10;
";
				/// <summary>Constant value for <see cref="SubTypeProperty.AccessModifier" /></summary>
				public const string ACCESS_MODIFIER = "public";
				/// <summary>Constant value for <see cref="SubTypeProperty.Modifier" /></summary>
				public const string MODIFIER = "";
				/// <summary>Constant value for <see cref="SubTypeProperty.NormativeVersion" /></summary>
				public const string NORMATIVE_VERSION = "1.7";
				/// <summary>Constant value for <see cref="SubTypeProperty.DeprecatedVersion" /></summary>
				public const string DEPRECATED_VERSION = "";
				/// <summary>Constant value for <see cref="SubTypeProperty.Aggregation" /></summary>
				public const string AGGREGATION = "composite";
				/// <summary>Constant value for <see cref="SubTypeProperty.Extension" /></summary>
				public const string EXTENSION = "MagicDraw UML 2024x";
				/// <summary>Constant value for <see cref="SubTypeProperty.Association" /></summary>
				public const string ASSOCIATION = "";
				/// <summary>Constant value for <see cref="SubTypeProperty.DefaultValue" /></summary>
				public const string DEFAULT_VALUE = "";

				/// <summary>
				/// <inheritdoc />
				/// <remarks> Type: DataItemSubTypeEnumMetaClass </remarks>
				/// </summary>
				public System.Type Type => typeof(Mtconnect.DataTypes.DataItemSubTypeEnumMetaClass);
				
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
			/// <inheritdoc cref="KeyTypeProperty" path="/summary" /><br/>
			/// <remarks>Original Name: KeyType</remarks>
			/// </summary>
			public KeyTypeProperty KeyType { get; } = new KeyTypeProperty();
			
			/// <summary>﻿<see cref="DataItem.type">type in DataItem</see> that defines the meaning of <see cref="EntryDefinition.key">key in EntryDefinition</see>.<br /><br /><br />
			/// </summary>
			public sealed class KeyTypeProperty : IProperty
			{
				/// <summary>Constant value for <see cref="KeyTypeProperty.Name" /></summary>
				public const string NAME = "keyType";
				/// <summary>Constant value for <see cref="KeyTypeProperty.Summary" /></summary>
				public const string SUMMARY = @"&#10;&#10;&#10;{{property(DataItem::type)}} that defines the meaning of {{property(EntryDefinition::key)}}.&#10;
";
				/// <summary>Constant value for <see cref="KeyTypeProperty.AccessModifier" /></summary>
				public const string ACCESS_MODIFIER = "public";
				/// <summary>Constant value for <see cref="KeyTypeProperty.Modifier" /></summary>
				public const string MODIFIER = "";
				/// <summary>Constant value for <see cref="KeyTypeProperty.NormativeVersion" /></summary>
				public const string NORMATIVE_VERSION = "1.7";
				/// <summary>Constant value for <see cref="KeyTypeProperty.DeprecatedVersion" /></summary>
				public const string DEPRECATED_VERSION = "";
				/// <summary>Constant value for <see cref="KeyTypeProperty.Aggregation" /></summary>
				public const string AGGREGATION = "composite";
				/// <summary>Constant value for <see cref="KeyTypeProperty.Extension" /></summary>
				public const string EXTENSION = "MagicDraw UML 2024x";
				/// <summary>Constant value for <see cref="KeyTypeProperty.Association" /></summary>
				public const string ASSOCIATION = "";
				/// <summary>Constant value for <see cref="KeyTypeProperty.DefaultValue" /></summary>
				public const string DEFAULT_VALUE = "";

				/// <summary>
				/// <inheritdoc />
				/// <remarks> Type: DataItemTypeEnumMetaClass </remarks>
				/// </summary>
				public System.Type Type => typeof(Mtconnect.DataTypes.DataItemTypeEnumMetaClass);
				
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
			
			/// <summary>﻿textual description for <see cref="EntryDefinition">EntryDefinition</see>.<br /><br /><br />
			/// </summary>
			public sealed class DescriptionProperty : IProperty
			{
				/// <summary>Constant value for <see cref="DescriptionProperty.Name" /></summary>
				public const string NAME = "Description";
				/// <summary>Constant value for <see cref="DescriptionProperty.Summary" /></summary>
				public const string SUMMARY = @"&#10;&#10;&#10;textual description for {{block(EntryDefinition)}}.&#10;
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