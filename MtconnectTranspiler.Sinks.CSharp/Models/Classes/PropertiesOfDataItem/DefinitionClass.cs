using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;
// using Mtconnect.DeviceInformationModel.DataItems.PropertiesOfDataItem.PropertiesOfDefinition;
// using Mtconnect.DeviceInformationModel.Components;

namespace Mtconnect.DeviceInformationModel.DataItems.PropertiesOfDataItem
{
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "1.0.15.3")]
	public sealed class DefinitionClass : IClass
	{
		/// <inheritdoc />
		public string ReferenceId => "_19_0_3_45f01b9_1581433165009_756087_158";
		
		/// <inheritdoc />
		public string Name => "DefinitionClass";
		
		/// <inheritdoc />
		public string AccessModifier => "public";
				
		/// <inheritdoc />
		public string Modifier => "";
				
		/// <inheritdoc />
		public string NormativeVersion => "1.6";
				
		/// <inheritdoc />
		public string DeprecatedVersion => "";
		
		/// <inheritdoc />
		public string Generalization => "";

		/// <inheritdoc />
		public DefinitionClassProperties Properties { get; } = new DefinitionClassProperties();
        IPropertyList IClass.Properties => Properties;
		public sealed class DefinitionClassProperties : IPropertyList
		{
			/// <inheritdoc />
			public IProperty[] Properties => new IProperty[] {
				HasCellDefinitionPart,
				HasDescriptionPart,
				HasEntryDefinitionPart,
			};
			/// <remarks>Original Name: HasCellDefinition</remarks>
			public HasCellDefinitionPartProperty HasCellDefinitionPart { get; } = new HasCellDefinitionPartProperty();
			public sealed class HasCellDefinitionPartProperty : IProperty
			{
				/// <summary>
				/// <inheritdoc />
				/// <remarks>
				/// <list type="bullet">
				/// <item>Original Type: _19_0_3_45f01b9_1581433195808_917937_222</item>
				/// <item>Type: CellDefinitionClass</item>
				/// <item>Namespace: Mtconnect.DeviceInformationModel.DataItems.PropertiesOfDataItem.PropertiesOfDefinition</item>
				/// </list>
				/// </remarks>
				/// </summary>
				public System.Type Type => typeof(Mtconnect.DeviceInformationModel.DataItems.PropertiesOfDataItem.PropertiesOfDefinition.CellDefinitionClass);
				
				/// <inheritdoc />
				public string Name => "HasCellDefinition";
				
				/// <inheritdoc />
				public string AccessModifier => "public";
				
				/// <inheritdoc />
				public string Modifier => "";
				
				/// <inheritdoc />
				public string NormativeVersion => "";
				
				/// <inheritdoc />
				public string DeprecatedVersion => "";
				
				/// <inheritdoc />
				public string Aggregation => "composite";

				// Note: Extension.Extender
				/// <inheritdoc />
				public string Extension => "";
				
				/// <inheritdoc />
				public string Association => "CellDefinitions";

				// Note: DefaultValue.Name
				/// <inheritdoc />
				public string DefaultValue => "";

				// TODO: Add Summary
			}
			/// <remarks>Original Name: HasDescription</remarks>
			public HasDescriptionPartProperty HasDescriptionPart { get; } = new HasDescriptionPartProperty();
			public sealed class HasDescriptionPartProperty : IProperty
			{
				/// <summary>
				/// <inheritdoc />
				/// <remarks>
				/// <list type="bullet">
				/// <item>Original Type: EAID_64352755_7251_46af_846D_937E5A1E3949</item>
				/// <item>Type: DescriptionClass</item>
				/// <item>Namespace: Mtconnect.DeviceInformationModel.Components</item>
				/// </list>
				/// </remarks>
				/// </summary>
				public System.Type Type => typeof(Mtconnect.DeviceInformationModel.Components.DescriptionClass);
				
				/// <inheritdoc />
				public string Name => "HasDescription";
				
				/// <inheritdoc />
				public string AccessModifier => "public";
				
				/// <inheritdoc />
				public string Modifier => "";
				
				/// <inheritdoc />
				public string NormativeVersion => "";
				
				/// <inheritdoc />
				public string DeprecatedVersion => "";
				
				/// <inheritdoc />
				public string Aggregation => "composite";

				// Note: Extension.Extender
				/// <inheritdoc />
				public string Extension => "MagicDraw UML 19.0";
				
				/// <inheritdoc />
				public string Association => "Description";

				// Note: DefaultValue.Name
				/// <inheritdoc />
				public string DefaultValue => "";

				// TODO: Add Summary
			}
			/// <remarks>Original Name: HasEntryDefinition</remarks>
			public HasEntryDefinitionPartProperty HasEntryDefinitionPart { get; } = new HasEntryDefinitionPartProperty();
			public sealed class HasEntryDefinitionPartProperty : IProperty
			{
				/// <summary>
				/// <inheritdoc />
				/// <remarks>
				/// <list type="bullet">
				/// <item>Original Type: _19_0_3_45f01b9_1582939685398_830533_4339</item>
				/// <item>Type: EntryDefinitionClass</item>
				/// <item>Namespace: Mtconnect.DeviceInformationModel.DataItems.PropertiesOfDataItem.PropertiesOfDefinition</item>
				/// </list>
				/// </remarks>
				/// </summary>
				public System.Type Type => typeof(Mtconnect.DeviceInformationModel.DataItems.PropertiesOfDataItem.PropertiesOfDefinition.EntryDefinitionClass);
				
				/// <inheritdoc />
				public string Name => "HasEntryDefinition";
				
				/// <inheritdoc />
				public string AccessModifier => "public";
				
				/// <inheritdoc />
				public string Modifier => "";
				
				/// <inheritdoc />
				public string NormativeVersion => "";
				
				/// <inheritdoc />
				public string DeprecatedVersion => "";
				
				/// <inheritdoc />
				public string Aggregation => "composite";

				// Note: Extension.Extender
				/// <inheritdoc />
				public string Extension => "";
				
				/// <inheritdoc />
				public string Association => "EntryDefinitions";

				// Note: DefaultValue.Name
				/// <inheritdoc />
				public string DefaultValue => "";

				// TODO: Add Summary
			}
		};

	}
}