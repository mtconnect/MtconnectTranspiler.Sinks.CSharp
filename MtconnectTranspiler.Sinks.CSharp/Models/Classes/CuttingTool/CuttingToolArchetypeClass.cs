using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;
// using Mtconnect.AssetInformationModel.CuttingTool;
// using Mtconnect.AssetInformationModel.CuttingTool.CuttingToolLifeCycle;

namespace Mtconnect.AssetInformationModel.CuttingTool
{
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "1.0.15.3")]
	public sealed class CuttingToolArchetypeClass : IClass
	{
		/// <inheritdoc />
		public string ReferenceId => "EAID_8D60D3F8_AB1A_490b_923B_B978248EF331";
		
		/// <inheritdoc />
		public string Name => "CuttingToolArchetypeClass";
		
		/// <inheritdoc />
		public string AccessModifier => "public";
				
		/// <inheritdoc />
		public string Modifier => "";
				
		/// <inheritdoc />
		public string NormativeVersion => "1.3";
				
		/// <inheritdoc />
		public string DeprecatedVersion => "";
		
		/// <inheritdoc />
		public string Generalization => "EAID_C7D39183_23CB_416b_A62D_F60815E08B1A";

		/// <inheritdoc />
		public CuttingToolArchetypeClassProperties Properties { get; } = new CuttingToolArchetypeClassProperties();
        IPropertyList IClass.Properties => Properties;
		public sealed class CuttingToolArchetypeClassProperties : IPropertyList
		{
			/// <inheritdoc />
			public IProperty[] Properties => new IProperty[] {
				Manufacturers,
				SerialNumber,
				ToolId,
				HasCuttingToolDefinitionPart,
				HasCuttingToolLifeCyclePart,
			};
			/// <remarks>Original Name: Manufacturers</remarks>
			public ManufacturersProperty Manufacturers { get; } = new ManufacturersProperty();
			public sealed class ManufacturersProperty : IProperty
			{
				/// <summary>
				/// <inheritdoc />
				/// <remarks>
				/// <list type="bullet">
				/// <item>Original Type: _19_0_3_91b028d_1579272360416_763325_681</item>
				/// <item>Type: String</item>
				/// <item>Namespace: </item>
				/// </list>
				/// </remarks>
				/// </summary>
				public System.Type Type => typeof(String);
				
				/// <inheritdoc />
				public string Name => "Manufacturers";
				
				/// <inheritdoc />
				public string AccessModifier => "public";
				
				/// <inheritdoc />
				public string Modifier => "";
				
				/// <inheritdoc />
				public string NormativeVersion => "1.3";
				
				/// <inheritdoc />
				public string DeprecatedVersion => "";
				
				/// <inheritdoc />
				public string Aggregation => "";

				// Note: Extension.Extender
				/// <inheritdoc />
				public string Extension => "";
				
				/// <inheritdoc />
				public string Association => "";

				// Note: DefaultValue.Name
				/// <inheritdoc />
				public string DefaultValue => "";

				// TODO: Add Summary
			}
			/// <remarks>Original Name: SerialNumber</remarks>
			public SerialNumberProperty SerialNumber { get; } = new SerialNumberProperty();
			public sealed class SerialNumberProperty : IProperty
			{
				/// <summary>
				/// <inheritdoc />
				/// <remarks>
				/// <list type="bullet">
				/// <item>Original Type: _19_0_3_91b028d_1579272360416_763325_681</item>
				/// <item>Type: String</item>
				/// <item>Namespace: </item>
				/// </list>
				/// </remarks>
				/// </summary>
				public System.Type Type => typeof(String);
				
				/// <inheritdoc />
				public string Name => "SerialNumber";
				
				/// <inheritdoc />
				public string AccessModifier => "public";
				
				/// <inheritdoc />
				public string Modifier => "";
				
				/// <inheritdoc />
				public string NormativeVersion => "1.3";
				
				/// <inheritdoc />
				public string DeprecatedVersion => "";
				
				/// <inheritdoc />
				public string Aggregation => "";

				// Note: Extension.Extender
				/// <inheritdoc />
				public string Extension => "MagicDraw UML 19.0";
				
				/// <inheritdoc />
				public string Association => "";

				// Note: DefaultValue.Name
				/// <inheritdoc />
				public string DefaultValue => "";

				// TODO: Add Summary
			}
			/// <remarks>Original Name: ToolId</remarks>
			public ToolIdProperty ToolId { get; } = new ToolIdProperty();
			public sealed class ToolIdProperty : IProperty
			{
				/// <summary>
				/// <inheritdoc />
				/// <remarks>
				/// <list type="bullet">
				/// <item>Original Type: _19_0_3_91b028d_1579272360416_763325_681</item>
				/// <item>Type: String</item>
				/// <item>Namespace: </item>
				/// </list>
				/// </remarks>
				/// </summary>
				public System.Type Type => typeof(String);
				
				/// <inheritdoc />
				public string Name => "ToolId";
				
				/// <inheritdoc />
				public string AccessModifier => "public";
				
				/// <inheritdoc />
				public string Modifier => "";
				
				/// <inheritdoc />
				public string NormativeVersion => "1.3";
				
				/// <inheritdoc />
				public string DeprecatedVersion => "";
				
				/// <inheritdoc />
				public string Aggregation => "";

				// Note: Extension.Extender
				/// <inheritdoc />
				public string Extension => "MagicDraw UML 19.0";
				
				/// <inheritdoc />
				public string Association => "";

				// Note: DefaultValue.Name
				/// <inheritdoc />
				public string DefaultValue => "";

				// TODO: Add Summary
			}
			/// <remarks>Original Name: HasCuttingToolDefinition</remarks>
			public HasCuttingToolDefinitionPartProperty HasCuttingToolDefinitionPart { get; } = new HasCuttingToolDefinitionPartProperty();
			public sealed class HasCuttingToolDefinitionPartProperty : IProperty
			{
				/// <summary>
				/// <inheritdoc />
				/// <remarks>
				/// <list type="bullet">
				/// <item>Original Type: EAID_37B8CFD0_D728_4841_9A07_B6CF819EC895</item>
				/// <item>Type: CuttingToolDefinitionClass</item>
				/// <item>Namespace: Mtconnect.AssetInformationModel.CuttingTool</item>
				/// </list>
				/// </remarks>
				/// </summary>
				public System.Type Type => typeof(Mtconnect.AssetInformationModel.CuttingTool.CuttingToolDefinitionClass);
				
				/// <inheritdoc />
				public string Name => "HasCuttingToolDefinition";
				
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
				public string Association => "CuttingToolDefinition";

				// Note: DefaultValue.Name
				/// <inheritdoc />
				public string DefaultValue => "";

				// TODO: Add Summary
			}
			/// <remarks>Original Name: HasCuttingToolLifeCycle</remarks>
			public HasCuttingToolLifeCyclePartProperty HasCuttingToolLifeCyclePart { get; } = new HasCuttingToolLifeCyclePartProperty();
			public sealed class HasCuttingToolLifeCyclePartProperty : IProperty
			{
				/// <summary>
				/// <inheritdoc />
				/// <remarks>
				/// <list type="bullet">
				/// <item>Original Type: EAID_D1C82EBD_D828_4e5f_9F46_3337710837FE</item>
				/// <item>Type: CuttingToolLifeCycleClass</item>
				/// <item>Namespace: Mtconnect.AssetInformationModel.CuttingTool.CuttingToolLifeCycle</item>
				/// </list>
				/// </remarks>
				/// </summary>
				public System.Type Type => typeof(Mtconnect.AssetInformationModel.CuttingTool.CuttingToolLifeCycle.CuttingToolLifeCycleClass);
				
				/// <inheritdoc />
				public string Name => "HasCuttingToolLifeCycle";
				
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
				public string Association => "CuttingToolLifeCycle";

				// Note: DefaultValue.Name
				/// <inheritdoc />
				public string DefaultValue => "";

				// TODO: Add Summary
			}
		};

	}
}