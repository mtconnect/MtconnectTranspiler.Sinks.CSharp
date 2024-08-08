using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;
// using Mtconnect.AssetInformationModel.CuttingTool.CuttingToolLifeCycle;
// using Mtconnect.AssetInformationModel.CuttingTool;

namespace Mtconnect.AssetInformationModel.CuttingTool
{
	/// <summary>
	/// <see cref="Asset">Asset</see> that physically removes the material from the workpiece by shear deformation.
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.3.0.0")]
	public sealed class CuttingToolClass : IClass
	{
		/// <inheritdoc />
		public string ReferenceId => "EAID_614061EF_1D50_4989_A935_02492044833A";
		
		/// <inheritdoc />
		public string Summary => @"/// <see cref=""Asset"">Asset</see> that physically removes the material from the workpiece by shear deformation.";

		/// <inheritdoc />
		public string Name => "CuttingToolClass";
		
		/// <inheritdoc />
		public string AccessModifier => "public";
				
		/// <inheritdoc />
		public string Modifier => "";
				
		/// <inheritdoc />
		public string NormativeVersion => "1.2";
				
		/// <inheritdoc />
		public string DeprecatedVersion => "";
		
		/// <inheritdoc />
		public string Generalization => "EAID_C7D39183_23CB_416b_A62D_F60815E08B1A";

		/// <inheritdoc />
		public CuttingToolClassProperties Properties { get; } = new CuttingToolClassProperties();
        IPropertyList IClass.Properties => Properties;
		public sealed class CuttingToolClassProperties : IPropertyList
		{
			/// <inheritdoc />
			public IProperty[] Properties => new IProperty[] {
				Manufacturers,
				SerialNumber,
				ToolId,
				HasCuttingToolLifeCyclePart,
				HasCuttingToolArchetypeReferencePart,
				HasCuttingToolDefinitionPart,
			};
			/// <summary>
			/// <inheritdoc cref="ManufacturersProperty" path="/summary" /><br/>
			/// <remarks>Original Name: Manufacturers</remarks>
			/// </summary>
			public ManufacturersProperty Manufacturers { get; } = new ManufacturersProperty();
			/// <summary>
			/// manufacturers of the cutting tool.  This will reference the tool item and adaptive items specifically. The cutting items manufacturers’ will be a property of <see cref="CuttingItem">CuttingItem</see>.  > Note: In <i>XML</i>, the representation <b>MUST</b> be a comma(,) delimited list of manufacturer names. See <see cref="CuttingTool Schema Diagrams">CuttingTool Schema Diagrams</see>.
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
				public string Name => "Manufacturers";
				
				/// <inheritdoc />
				public string Summary => @"/// <see cref=""Asset"">Asset</see> that physically removes the material from the workpiece by shear deformation.";

				/// <inheritdoc />
				public string AccessModifier => "public";
				
				/// <inheritdoc />
				public string Modifier => "";
				
				/// <inheritdoc />
				public string NormativeVersion => "1.2";
				
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
				public string Name => "SerialNumber";
				
				/// <inheritdoc />
				public string Summary => @"/// <see cref=""Asset"">Asset</see> that physically removes the material from the workpiece by shear deformation.";

				/// <inheritdoc />
				public string AccessModifier => "public";
				
				/// <inheritdoc />
				public string Modifier => "";
				
				/// <inheritdoc />
				public string NormativeVersion => "1.2";
				
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
				public string Name => "ToolId";
				
				/// <inheritdoc />
				public string Summary => @"/// <see cref=""Asset"">Asset</see> that physically removes the material from the workpiece by shear deformation.";

				/// <inheritdoc />
				public string AccessModifier => "public";
				
				/// <inheritdoc />
				public string Modifier => "";
				
				/// <inheritdoc />
				public string NormativeVersion => "1.2";
				
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
				public string Name => "HasCuttingToolLifeCycle";
				
				/// <inheritdoc />
				public string Summary => @"/// <see cref=""Asset"">Asset</see> that physically removes the material from the workpiece by shear deformation.";

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
			/// <summary>
			/// <inheritdoc cref="HasCuttingToolArchetypeReferencePartProperty" path="/summary" /><br/>
			/// <remarks>Original Name: HasCuttingToolArchetypeReference</remarks>
			/// </summary>
			public HasCuttingToolArchetypeReferencePartProperty HasCuttingToolArchetypeReferencePart { get; } = new HasCuttingToolArchetypeReferencePartProperty();
			public sealed class HasCuttingToolArchetypeReferencePartProperty : IProperty
			{
				/// <summary>
				/// <inheritdoc />
				/// <remarks>
				/// <list type="bullet">
				/// <item>Original Type: EAID_D4CAAB4A_DE00_489d_ACCA_F00FC7296F0C</item>
				/// <item>Type: CuttingToolArchetypeReferenceClass</item>
				/// <item>Namespace: Mtconnect.AssetInformationModel.CuttingTool</item>
				/// </list>
				/// </remarks>
				/// </summary>
				public System.Type Type => typeof(Mtconnect.AssetInformationModel.CuttingTool.CuttingToolArchetypeReferenceClass);
				
				/// <inheritdoc />
				public string Name => "HasCuttingToolArchetypeReference";
				
				/// <inheritdoc />
				public string Summary => @"/// <see cref=""Asset"">Asset</see> that physically removes the material from the workpiece by shear deformation.";

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
				public string Association => "CuttingToolArchetypeReference";

				// Note: DefaultValue.Name
				/// <inheritdoc />
				public string DefaultValue => "";
			}
			/// <summary>
			/// <inheritdoc cref="HasCuttingToolDefinitionPartProperty" path="/summary" /><br/>
			/// <remarks>Original Name: HasCuttingToolDefinition</remarks>
			/// </summary>
			public HasCuttingToolDefinitionPartProperty HasCuttingToolDefinitionPart { get; } = new HasCuttingToolDefinitionPartProperty();
			/// <summary>
			/// 
			/// </summary>
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
				public string Summary => @"/// <see cref=""Asset"">Asset</see> that physically removes the material from the workpiece by shear deformation.";

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
		};

	}
}