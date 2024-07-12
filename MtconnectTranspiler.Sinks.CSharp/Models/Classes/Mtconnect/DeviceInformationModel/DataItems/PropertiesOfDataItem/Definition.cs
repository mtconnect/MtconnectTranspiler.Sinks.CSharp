
using System;
using System.CodeDom.Compiler;

using Mtconnect.DeviceInformationModel.DataItems.PropertiesOfDataItem.PropertiesOfDefinition;
using Mtconnect.DeviceInformationModel.Components;

namespace Mtconnect.DeviceInformationModel.DataItems.PropertiesOfDataItem
{
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "1.0.15.3")]
	public sealed class DefinitionClass
	{
		/// <inheritdoc cref="Class.ReferenceId" />
		public string ReferenceId => "_19_0_3_45f01b9_1581433165009_756087_158";
		
		/// <inheritdoc cref="Class.Name" />
		public string Name => "Definition";
		
		/// <inheritdoc cref="Class.AccessModifier" />
		public string AccessModifier => "public";
				
		/// <inheritdoc cref="Class.Modifier" />
		public string Modifier => "";
				
		/// <inheritdoc cref="Class.NormativeVersion" />
		public string NormativeVersion => "MtconnectVersions.V_1_6_0";
				
		/// <inheritdoc cref="Class.DeprecatedVersion" />
		public string DeprecatedVersion => "";

		public string Generalization => "";

		public DefinitionProperties Properties { get; } = new DefinitionProperties();
		public sealed class DefinitionProperties
		{
		
		
			/// <remarks>Original Name: HasCellDefinition</remarks>
			public HasCellDefinitionPartProperty HasCellDefinitionPart { get; } = new HasCellDefinitionPartProperty();
			public sealed class HasCellDefinitionPartProperty
			{
				/// <inheritdoc cref="Property.Type" />
				/// Original Type: _19_0_3_45f01b9_1581433195808_917937_222
				public Type Type => typeof(CellDefinitionClass);
				
				/// <inheritdoc cref="Property.Name" />
				public string Name => "HasCellDefinition";
				
				/// <inheritdoc cref="Property.AccessModifier" />
				public string AccessModifier => "public";
				
				/// <inheritdoc cref="Property.Modifier" />
				public string Modifier => "";
				
				/// <inheritdoc cref="Property.NormativeVersion" />
				public string NormativeVersion => "";
				
				/// <inheritdoc cref="Property.DeprecatedVersion" />
				public string DeprecatedVersion => "";
				
				public string Aggregation => "composite";

				// Note: Extension.Extender
				public string Extension => "";

				public string Association => "CellDefinitions";

				// Note: DefaultValue.Name
				public string DefaultValue => "";

				// TODO: Add Summary
			}
		
		
			/// <remarks>Original Name: HasDescription</remarks>
			public HasDescriptionPartProperty HasDescriptionPart { get; } = new HasDescriptionPartProperty();
			public sealed class HasDescriptionPartProperty
			{
				/// <inheritdoc cref="Property.Type" />
				/// Original Type: EAID_64352755_7251_46af_846D_937E5A1E3949
				public Type Type => typeof(DescriptionClass);
				
				/// <inheritdoc cref="Property.Name" />
				public string Name => "HasDescription";
				
				/// <inheritdoc cref="Property.AccessModifier" />
				public string AccessModifier => "public";
				
				/// <inheritdoc cref="Property.Modifier" />
				public string Modifier => "";
				
				/// <inheritdoc cref="Property.NormativeVersion" />
				public string NormativeVersion => "";
				
				/// <inheritdoc cref="Property.DeprecatedVersion" />
				public string DeprecatedVersion => "";
				
				public string Aggregation => "composite";

				// Note: Extension.Extender
				public string Extension => "MagicDraw UML 19.0";

				public string Association => "Description";

				// Note: DefaultValue.Name
				public string DefaultValue => "";

				// TODO: Add Summary
			}
		
		
			/// <remarks>Original Name: HasEntryDefinition</remarks>
			public HasEntryDefinitionPartProperty HasEntryDefinitionPart { get; } = new HasEntryDefinitionPartProperty();
			public sealed class HasEntryDefinitionPartProperty
			{
				/// <inheritdoc cref="Property.Type" />
				/// Original Type: _19_0_3_45f01b9_1582939685398_830533_4339
				public Type Type => typeof(EntryDefinitionClass);
				
				/// <inheritdoc cref="Property.Name" />
				public string Name => "HasEntryDefinition";
				
				/// <inheritdoc cref="Property.AccessModifier" />
				public string AccessModifier => "public";
				
				/// <inheritdoc cref="Property.Modifier" />
				public string Modifier => "";
				
				/// <inheritdoc cref="Property.NormativeVersion" />
				public string NormativeVersion => "";
				
				/// <inheritdoc cref="Property.DeprecatedVersion" />
				public string DeprecatedVersion => "";
				
				public string Aggregation => "composite";

				// Note: Extension.Extender
				public string Extension => "";

				public string Association => "EntryDefinitions";

				// Note: DefaultValue.Name
				public string DefaultValue => "";

				// TODO: Add Summary
			}
		};

	}
}