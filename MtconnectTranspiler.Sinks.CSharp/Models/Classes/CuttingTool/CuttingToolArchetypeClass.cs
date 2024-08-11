using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;
using System.Linq;

namespace Mtconnect.AssetInformationModel.CuttingTool
{
	/// <summary>
	/// <see cref="Asset">Asset</see> that describes the static cutting tool geometries and nominal values as one would expect from a tool catalog.
	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Structure__EAID_8D60D3F8_AB1A_490b_923B_B978248EF331">model.mtconnect.org</seealso> for more information.
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.3.0.0")]
	public sealed class CuttingToolArchetypeClass : IClass
	{
		/// <inheritdoc />
		public string ReferenceId => "EAID_8D60D3F8_AB1A_490b_923B_B978248EF331";
		
		/// <inheritdoc />
		public string Summary => @"/// <see cref=""Asset"">Asset</see> that describes the static cutting tool geometries and nominal values as one would expect from a tool catalog.";

		/// <inheritdoc />
		public string Name => "CuttingToolArchetype";
		
		/// <inheritdoc />
		public string AccessModifier => "public";
				
		/// <inheritdoc />
		public string Modifier => "";
				
		/// <inheritdoc />
		public string NormativeVersion => "1.3";
				
		/// <inheritdoc />
		public string DeprecatedVersion => "";
		
		/// <inheritdoc />
		/// <remarks>
		/// Original Type: EAID_C7D39183_23CB_416b_A62D_F60815E08B1A
		/// </remarks>
		public Type Generalization => typeof(Mtconnect.AssetInformationModel.AssetClass);

		/// <inheritdoc />
		public CuttingToolArchetypeClassProperties Properties { get; } = new CuttingToolArchetypeClassProperties();
        IPropertyList IClass.Properties => Properties;
		public class CuttingToolArchetypeClassProperties : Mtconnect.AssetInformationModel.AssetClass.AssetClassProperties
		{
			/// <inheritdoc />
			public IProperty[] Properties => new IProperty[] {
				Manufacturers,
				SerialNumber,
				ToolId,
				HasCuttingToolDefinitionPart,
				HasCuttingToolLifeCyclePart,
			}.Concat(base.Properties).ToArray();
			/// <summary>
			/// <inheritdoc cref="ManufacturersProperty" path="/summary" /><br/>
			/// <remarks>Original Name: Manufacturers</remarks>
			/// </summary>
			public ManufacturersProperty Manufacturers { get; } = new ManufacturersProperty();
			/// <summary>
			/// manufacturers of the cutting tool.  This will reference the tool item and adaptive items specifically. The cutting items manufacturers’ will be a property of <see cref="CuttingItem">CuttingItem</see>.  > Note: In <i>XML</i>, the representation will be a comma(,) delimited list of manufacturer names. See <see cref="CuttingTool Schema Diagrams">CuttingTool Schema Diagrams</see>.
			/// </summary>
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
				public string Name => "manufacturers";
				
				/// <inheritdoc />
				public string Summary => @"/// <see cref=""Asset"">Asset</see> that describes the static cutting tool geometries and nominal values as one would expect from a tool catalog.";

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
			}
			/// <summary>
			/// <inheritdoc cref="SerialNumberProperty" path="/summary" /><br/>
			/// <remarks>Original Name: SerialNumber</remarks>
			/// </summary>
			public SerialNumberProperty SerialNumber { get; } = new SerialNumberProperty();
			/// <summary>
			/// unique identifier for this assembly.
			/// </summary>
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
				public string Name => "serialNumber";
				
				/// <inheritdoc />
				public string Summary => @"/// <see cref=""Asset"">Asset</see> that describes the static cutting tool geometries and nominal values as one would expect from a tool catalog.";

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
			}
			/// <summary>
			/// <inheritdoc cref="ToolIdProperty" path="/summary" /><br/>
			/// <remarks>Original Name: ToolId</remarks>
			/// </summary>
			public ToolIdProperty ToolId { get; } = new ToolIdProperty();
			/// <summary>
			/// identifier for a class of cutting tools.
			/// </summary>
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
				public string Name => "toolId";
				
				/// <inheritdoc />
				public string Summary => @"/// <see cref=""Asset"">Asset</see> that describes the static cutting tool geometries and nominal values as one would expect from a tool catalog.";

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
			}
			/// <summary>
			/// <inheritdoc cref="HasCuttingToolDefinitionPartProperty" path="/summary" /><br/>
			/// <remarks>Original Name: HasCuttingToolDefinition</remarks>
			/// </summary>
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
				public string Name => "hasCuttingToolDefinition";
				
				/// <inheritdoc />
				public string Summary => @"/// <see cref=""Asset"">Asset</see> that describes the static cutting tool geometries and nominal values as one would expect from a tool catalog.";

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
			}
			/// <summary>
			/// <inheritdoc cref="HasCuttingToolLifeCyclePartProperty" path="/summary" /><br/>
			/// <remarks>Original Name: HasCuttingToolLifeCycle</remarks>
			/// </summary>
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
				public string Name => "hasCuttingToolLifeCycle";
				
				/// <inheritdoc />
				public string Summary => @"/// <see cref=""Asset"">Asset</see> that describes the static cutting tool geometries and nominal values as one would expect from a tool catalog.";

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
			}
		};

	}
}