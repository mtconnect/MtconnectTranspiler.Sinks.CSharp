#pragma warning disable CS0109 // Member does not hide an inherited member; new keyword is not required
#pragma warning disable CS1574 // XML comment has cref attribute that could not be resolved
#pragma warning disable CS1584 // XML comment has syntactically incorrect cref attribute
#pragma warning disable CS0618 // Type or member is obsolete
using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;

namespace Mtconnect.AssetInformationModel.CuttingTool
{
	/// <summary>﻿detailed structure of the cutting tool which is static during its lifecycle. <seealso href="https://www.google.com/search?q=ISO 13399&amp;btnI=I">ISO 13399</seealso>.<br /><br /><br />
	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Structure__EAID_37B8CFD0_D728_4841_9A07_B6CF819EC895">model.mtconnect.org</seealso> for more information.
	/// </summary>
	/// <remarks>
	/// <list type="bullet">
	/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.2">v1.2</see></item>
	/// </list>
	/// </remarks>

	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public sealed class CuttingToolDefinitionClass : IClass
	{
		/// <summary>Constant value for <see cref="CuttingToolDefinitionClass.ReferenceId" /></summary>
		public const string REFERENCE_ID = "EAID_37B8CFD0_D728_4841_9A07_B6CF819EC895";
		/// <summary>Constant value for <see cref="CuttingToolDefinitionClass.HelpUrl" /></summary>
		public const string HELP_URL = "https://model.mtconnect.org/#Structure__EAID_37B8CFD0_D728_4841_9A07_B6CF819EC895";
		/// <summary>Constant value for <see cref="CuttingToolDefinitionClass.Summary" /></summary>
		public const string SUMMARY = @"&#10;&#10;&#10;detailed structure of the cutting tool which is static during its lifecycle. {{cite(ISO 13399)}}.&#10;
";
		/// <summary>Constant value for <see cref="CuttingToolDefinitionClass.Name" /></summary>
		public const string NAME = "CuttingToolDefinition";
		/// <summary>Constant value for <see cref="CuttingToolDefinitionClass.AccessModifier" /></summary>
		public const string ACCESS_MODIFIER = "public";
		/// <summary>Constant value for <see cref="CuttingToolDefinitionClass.Modifier" /></summary>
		public const string MODIFIER = "";
		/// <summary>Constant value for <see cref="CuttingToolDefinitionClass.NormativeVersion" /></summary>
		public const string NORMATIVE_VERSION = "1.2";
		/// <summary>Constant value for <see cref="CuttingToolDefinitionClass.DeprecatedVersion" /></summary>
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
		public new CuttingToolDefinitionClassProperties Properties { get; } = new CuttingToolDefinitionClassProperties();
        IPropertyList IClass.Properties => Properties;
		/// <summary>
		/// Property list for <see cref="CuttingToolDefinitionClass" />.
		/// </summary>
		public class CuttingToolDefinitionClassProperties : IPropertyList
		{
			/// <inheritdoc />
			public virtual IProperty[] Properties => new IProperty[] {
				Format,
				Value,
			};
			/// <summary>
			/// <inheritdoc cref="FormatProperty" path="/summary" /><br/>
			/// <remarks>Original Name: Format</remarks>
			/// </summary>
			public FormatProperty Format { get; } = new FormatProperty();
			
			/// <summary>﻿identifies the expected representation of the enclosed data.<br /><br /><br />
			/// </summary>
			public sealed class FormatProperty : IProperty
			{
				/// <summary>Constant value for <see cref="FormatProperty.Name" /></summary>
				public const string NAME = "format";
				/// <summary>Constant value for <see cref="FormatProperty.Summary" /></summary>
				public const string SUMMARY = @"&#10;&#10;&#10;identifies the expected representation of the enclosed data.&#10;
";
				/// <summary>Constant value for <see cref="FormatProperty.AccessModifier" /></summary>
				public const string ACCESS_MODIFIER = "public";
				/// <summary>Constant value for <see cref="FormatProperty.Modifier" /></summary>
				public const string MODIFIER = "";
				/// <summary>Constant value for <see cref="FormatProperty.NormativeVersion" /></summary>
				public const string NORMATIVE_VERSION = "1.2";
				/// <summary>Constant value for <see cref="FormatProperty.DeprecatedVersion" /></summary>
				public const string DEPRECATED_VERSION = "";
				/// <summary>Constant value for <see cref="FormatProperty.Aggregation" /></summary>
				public const string AGGREGATION = "";
				/// <summary>Constant value for <see cref="FormatProperty.Extension" /></summary>
				public const string EXTENSION = "MagicDraw UML 2024x";
				/// <summary>Constant value for <see cref="FormatProperty.Association" /></summary>
				public const string ASSOCIATION = "";
				/// <summary>Constant value for <see cref="FormatProperty.DefaultValue" /></summary>
				public const string DEFAULT_VALUE = "XML";

				/// <summary>
				/// <inheritdoc />
				/// <remarks> Type: FormatTypeEnumMetaClass </remarks>
				/// </summary>
				public System.Type Type => typeof(Mtconnect.DataTypes.FormatTypeEnumMetaClass);
				
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
			/// <inheritdoc cref="ValueProperty" path="/summary" /><br/>
			/// <remarks>Original Name: Value</remarks>
			/// </summary>
			public ValueProperty Value { get; } = new ValueProperty();
			
			/// <summary>﻿text of the <see cref="CuttingToolDefinition">CuttingToolDefinition</see> in format defined by <see cref="CuttingToolDefinition.format">format in CuttingToolDefinition</see>.<br /><br /><br />
			/// </summary>
			public sealed class ValueProperty : IProperty
			{
				/// <summary>Constant value for <see cref="ValueProperty.Name" /></summary>
				public const string NAME = "value";
				/// <summary>Constant value for <see cref="ValueProperty.Summary" /></summary>
				public const string SUMMARY = @"&#10;&#10;&#10;text of the {{block(CuttingToolDefinition)}} in format defined by {{property(CuttingToolDefinition::format)}}.&#10;
";
				/// <summary>Constant value for <see cref="ValueProperty.AccessModifier" /></summary>
				public const string ACCESS_MODIFIER = "public";
				/// <summary>Constant value for <see cref="ValueProperty.Modifier" /></summary>
				public const string MODIFIER = "";
				/// <summary>Constant value for <see cref="ValueProperty.NormativeVersion" /></summary>
				public const string NORMATIVE_VERSION = "1.2";
				/// <summary>Constant value for <see cref="ValueProperty.DeprecatedVersion" /></summary>
				public const string DEPRECATED_VERSION = "";
				/// <summary>Constant value for <see cref="ValueProperty.Aggregation" /></summary>
				public const string AGGREGATION = "";
				/// <summary>Constant value for <see cref="ValueProperty.Extension" /></summary>
				public const string EXTENSION = "";
				/// <summary>Constant value for <see cref="ValueProperty.Association" /></summary>
				public const string ASSOCIATION = "";
				/// <summary>Constant value for <see cref="ValueProperty.DefaultValue" /></summary>
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