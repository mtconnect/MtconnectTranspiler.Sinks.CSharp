#pragma warning disable CS0109 // Member does not hide an inherited member; new keyword is not required
#pragma warning disable CS1574 // XML comment has cref attribute that could not be resolved
#pragma warning disable CS1584 // XML comment has syntactically incorrect cref attribute
#pragma warning disable CS0618 // Type or member is obsolete
using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;
using System.Linq;

namespace Mtconnect.AssetInformationModel.CuttingTool
{
	/// <summary>﻿<see cref="Asset">Asset</see> that describes the static cutting tool geometries and nominal values as one would expect from a tool catalog.<br /><br /><br />
	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Structure__EAID_8D60D3F8_AB1A_490b_923B_B978248EF331">model.mtconnect.org</seealso> for more information.
	/// </summary>
	/// <remarks>
	/// <list type="bullet">
	/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.3">v1.3</see></item>
	/// </list>
	/// </remarks>

	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public sealed class CuttingToolArchetypeClass : IClass
	{
		/// <summary>Constant value for <see cref="CuttingToolArchetypeClass.ReferenceId" /></summary>
		public const string REFERENCE_ID = "EAID_8D60D3F8_AB1A_490b_923B_B978248EF331";
		/// <summary>Constant value for <see cref="CuttingToolArchetypeClass.HelpUrl" /></summary>
		public const string HELP_URL = "https://model.mtconnect.org/#Structure__EAID_8D60D3F8_AB1A_490b_923B_B978248EF331";
		/// <summary>Constant value for <see cref="CuttingToolArchetypeClass.Summary" /></summary>
		public const string SUMMARY = @"&#10;&#10;&#10;{{block(Asset)}} that describes the static cutting tool geometries and nominal values as one would expect from a tool catalog.&#10;
";
		/// <summary>Constant value for <see cref="CuttingToolArchetypeClass.Name" /></summary>
		public const string NAME = "CuttingToolArchetype";
		/// <summary>Constant value for <see cref="CuttingToolArchetypeClass.AccessModifier" /></summary>
		public const string ACCESS_MODIFIER = "public";
		/// <summary>Constant value for <see cref="CuttingToolArchetypeClass.Modifier" /></summary>
		public const string MODIFIER = "";
		/// <summary>Constant value for <see cref="CuttingToolArchetypeClass.NormativeVersion" /></summary>
		public const string NORMATIVE_VERSION = "1.3";
		/// <summary>Constant value for <see cref="CuttingToolArchetypeClass.DeprecatedVersion" /></summary>
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
		/// Original Type: EAID_C7D39183_23CB_416b_A62D_F60815E08B1A
		/// </remarks>
		public Type Generalization => typeof(Mtconnect.AssetInformationModel.AssetClass);

		/// <inheritdoc />
		public new CuttingToolArchetypeClassProperties Properties { get; } = new CuttingToolArchetypeClassProperties();
        IPropertyList IClass.Properties => Properties;
		/// <summary>
		/// Property list for <see cref="CuttingToolArchetypeClass" />.
		/// <br/><b>Note</b>, some properties (<see cref="IProperty" />) are inherited from <see cref="Mtconnect.AssetInformationModel.AssetClass.AssetClassProperties" />.
		/// </summary>
		public class CuttingToolArchetypeClassProperties : Mtconnect.AssetInformationModel.AssetClass.AssetClassProperties
		{
			/// <inheritdoc />
			public override IProperty[] Properties => new IProperty[] {
				SerialNumber,
				ToolId,
				HasCuttingToolDefinitionPart,
				HasCuttingToolLifeCyclePart,
			}.Concat(base.Properties).ToArray();
			/// <summary>
			/// <inheritdoc cref="SerialNumberProperty" path="/summary" /><br/>
			/// <remarks>Original Name: SerialNumber</remarks>
			/// </summary>
			public new SerialNumberProperty SerialNumber { get; } = new SerialNumberProperty();
			
			/// <summary>﻿unique identifier for this assembly.<br /><br /><br />
			/// </summary>
			public new sealed class SerialNumberProperty : IProperty
			{
				/// <summary>Constant value for <see cref="SerialNumberProperty.Name" /></summary>
				public const string NAME = "serialNumber";
				/// <summary>Constant value for <see cref="SerialNumberProperty.Summary" /></summary>
				public const string SUMMARY = @"&#10;&#10;&#10;unique identifier for this assembly.&#10;
";
				/// <summary>Constant value for <see cref="SerialNumberProperty.AccessModifier" /></summary>
				public const string ACCESS_MODIFIER = "public";
				/// <summary>Constant value for <see cref="SerialNumberProperty.Modifier" /></summary>
				public const string MODIFIER = "";
				/// <summary>Constant value for <see cref="SerialNumberProperty.NormativeVersion" /></summary>
				public const string NORMATIVE_VERSION = "1.3";
				/// <summary>Constant value for <see cref="SerialNumberProperty.DeprecatedVersion" /></summary>
				public const string DEPRECATED_VERSION = "";
				/// <summary>Constant value for <see cref="SerialNumberProperty.Aggregation" /></summary>
				public const string AGGREGATION = "";
				/// <summary>Constant value for <see cref="SerialNumberProperty.Extension" /></summary>
				public const string EXTENSION = "MagicDraw UML 2024x";
				/// <summary>Constant value for <see cref="SerialNumberProperty.Association" /></summary>
				public const string ASSOCIATION = "";
				/// <summary>Constant value for <see cref="SerialNumberProperty.DefaultValue" /></summary>
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
			/// <inheritdoc cref="ToolIdProperty" path="/summary" /><br/>
			/// <remarks>Original Name: ToolId</remarks>
			/// </summary>
			public new ToolIdProperty ToolId { get; } = new ToolIdProperty();
			
			/// <summary>﻿identifier for a class of cutting tools.<br /><br /><br />
			/// </summary>
			public new sealed class ToolIdProperty : IProperty
			{
				/// <summary>Constant value for <see cref="ToolIdProperty.Name" /></summary>
				public const string NAME = "toolId";
				/// <summary>Constant value for <see cref="ToolIdProperty.Summary" /></summary>
				public const string SUMMARY = @"&#10;&#10;&#10;identifier for a class of cutting tools.&#10;
";
				/// <summary>Constant value for <see cref="ToolIdProperty.AccessModifier" /></summary>
				public const string ACCESS_MODIFIER = "public";
				/// <summary>Constant value for <see cref="ToolIdProperty.Modifier" /></summary>
				public const string MODIFIER = "";
				/// <summary>Constant value for <see cref="ToolIdProperty.NormativeVersion" /></summary>
				public const string NORMATIVE_VERSION = "1.3";
				/// <summary>Constant value for <see cref="ToolIdProperty.DeprecatedVersion" /></summary>
				public const string DEPRECATED_VERSION = "";
				/// <summary>Constant value for <see cref="ToolIdProperty.Aggregation" /></summary>
				public const string AGGREGATION = "";
				/// <summary>Constant value for <see cref="ToolIdProperty.Extension" /></summary>
				public const string EXTENSION = "MagicDraw UML 2024x";
				/// <summary>Constant value for <see cref="ToolIdProperty.Association" /></summary>
				public const string ASSOCIATION = "";
				/// <summary>Constant value for <see cref="ToolIdProperty.DefaultValue" /></summary>
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
			/// <inheritdoc cref="HasCuttingToolDefinitionPartProperty" path="/summary" /><br/>
			/// <remarks>Original Name: HasCuttingToolDefinition</remarks>
			/// </summary>
			public new HasCuttingToolDefinitionPartProperty HasCuttingToolDefinitionPart { get; } = new HasCuttingToolDefinitionPartProperty();
			
			/// <summary>﻿
			/// </summary>
			public new sealed class HasCuttingToolDefinitionPartProperty : IProperty
			{
				/// <summary>Constant value for <see cref="HasCuttingToolDefinitionPartProperty.Name" /></summary>
				public const string NAME = "hasCuttingToolDefinition";
				/// <summary>Constant value for <see cref="HasCuttingToolDefinitionPartProperty.Summary" /></summary>
				public const string SUMMARY = @"";
				/// <summary>Constant value for <see cref="HasCuttingToolDefinitionPartProperty.AccessModifier" /></summary>
				public const string ACCESS_MODIFIER = "public";
				/// <summary>Constant value for <see cref="HasCuttingToolDefinitionPartProperty.Modifier" /></summary>
				public const string MODIFIER = "";
				/// <summary>Constant value for <see cref="HasCuttingToolDefinitionPartProperty.NormativeVersion" /></summary>
				public const string NORMATIVE_VERSION = "";
				/// <summary>Constant value for <see cref="HasCuttingToolDefinitionPartProperty.DeprecatedVersion" /></summary>
				public const string DEPRECATED_VERSION = "";
				/// <summary>Constant value for <see cref="HasCuttingToolDefinitionPartProperty.Aggregation" /></summary>
				public const string AGGREGATION = "composite";
				/// <summary>Constant value for <see cref="HasCuttingToolDefinitionPartProperty.Extension" /></summary>
				public const string EXTENSION = "MagicDraw UML 2024x";
				/// <summary>Constant value for <see cref="HasCuttingToolDefinitionPartProperty.Association" /></summary>
				public const string ASSOCIATION = "CuttingToolDefinition";
				/// <summary>Constant value for <see cref="HasCuttingToolDefinitionPartProperty.DefaultValue" /></summary>
				public const string DEFAULT_VALUE = "";

				/// <summary>
				/// <inheritdoc />
				/// <remarks> Type: CuttingToolDefinitionClass </remarks>
				/// </summary>
				public System.Type Type => typeof(Mtconnect.AssetInformationModel.CuttingTool.CuttingToolDefinitionClass);
				
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
			/// <inheritdoc cref="HasCuttingToolLifeCyclePartProperty" path="/summary" /><br/>
			/// <remarks>Original Name: HasCuttingToolLifeCycle</remarks>
			/// </summary>
			public new HasCuttingToolLifeCyclePartProperty HasCuttingToolLifeCyclePart { get; } = new HasCuttingToolLifeCyclePartProperty();
			
			/// <summary>﻿
			/// </summary>
			public new sealed class HasCuttingToolLifeCyclePartProperty : IProperty
			{
				/// <summary>Constant value for <see cref="HasCuttingToolLifeCyclePartProperty.Name" /></summary>
				public const string NAME = "hasCuttingToolLifeCycle";
				/// <summary>Constant value for <see cref="HasCuttingToolLifeCyclePartProperty.Summary" /></summary>
				public const string SUMMARY = @"";
				/// <summary>Constant value for <see cref="HasCuttingToolLifeCyclePartProperty.AccessModifier" /></summary>
				public const string ACCESS_MODIFIER = "public";
				/// <summary>Constant value for <see cref="HasCuttingToolLifeCyclePartProperty.Modifier" /></summary>
				public const string MODIFIER = "";
				/// <summary>Constant value for <see cref="HasCuttingToolLifeCyclePartProperty.NormativeVersion" /></summary>
				public const string NORMATIVE_VERSION = "";
				/// <summary>Constant value for <see cref="HasCuttingToolLifeCyclePartProperty.DeprecatedVersion" /></summary>
				public const string DEPRECATED_VERSION = "";
				/// <summary>Constant value for <see cref="HasCuttingToolLifeCyclePartProperty.Aggregation" /></summary>
				public const string AGGREGATION = "composite";
				/// <summary>Constant value for <see cref="HasCuttingToolLifeCyclePartProperty.Extension" /></summary>
				public const string EXTENSION = "MagicDraw UML 2024x";
				/// <summary>Constant value for <see cref="HasCuttingToolLifeCyclePartProperty.Association" /></summary>
				public const string ASSOCIATION = "CuttingToolLifeCycle";
				/// <summary>Constant value for <see cref="HasCuttingToolLifeCyclePartProperty.DefaultValue" /></summary>
				public const string DEFAULT_VALUE = "";

				/// <summary>
				/// <inheritdoc />
				/// <remarks> Type: CuttingToolLifeCycleClass </remarks>
				/// </summary>
				public System.Type Type => typeof(Mtconnect.AssetInformationModel.CuttingTool.CuttingToolLifeCycle.CuttingToolLifeCycleClass);
				
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