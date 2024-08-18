#pragma warning disable CS0109 // Member does not hide an inherited member; new keyword is not required
#pragma warning disable CS1574 // XML comment has cref attribute that could not be resolved
#pragma warning disable CS1584 // XML comment has syntactically incorrect cref attribute
using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;
using System.Linq;

namespace Mtconnect.AssetInformationModel.CuttingTool
{
	/// <summary>﻿<see cref="Asset">Asset</see> that physically removes the material from the workpiece by shear deformation.<br /><br /><br />
	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Structure__EAID_614061EF_1D50_4989_A935_02492044833A">model.mtconnect.org</seealso> for more information.
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public sealed class CuttingToolClass : IClass
	{
		/// <inheritdoc />
		public string ReferenceId => "EAID_614061EF_1D50_4989_A935_02492044833A";
		
		/// <inheritdoc />
		public string Summary => @"&#10;&#10;&#10;{{block(Asset)}} that physically removes the material from the workpiece by shear deformation.&#10;
";

		/// <inheritdoc />
		public string Name => "CuttingTool";
		
		/// <inheritdoc />
		public string AccessModifier => "public";
				
		/// <inheritdoc />
		public string Modifier => "";
				
		/// <inheritdoc />
		public string NormativeVersion => "1.2";
				
		/// <inheritdoc />
		public string DeprecatedVersion => "";
		
		/// <inheritdoc />
		/// <remarks>
		/// Original Type: EAID_C7D39183_23CB_416b_A62D_F60815E08B1A
		/// </remarks>
		public Type Generalization => typeof(Mtconnect.AssetInformationModel.AssetClass);

		/// <inheritdoc />
		public new CuttingToolClassProperties Properties { get; } = new CuttingToolClassProperties();
        IPropertyList IClass.Properties => Properties;
		/// <summary>
		/// Property list for <see cref="CuttingToolClass" />.
		/// <br/><b>Note</b>, some properties (<see cref="IProperty" />) are inherited from <see cref="Mtconnect.AssetInformationModel.AssetClass.AssetClassProperties" />.
		/// </summary>
		public class CuttingToolClassProperties : Mtconnect.AssetInformationModel.AssetClass.AssetClassProperties
		{
			/// <inheritdoc />
			public override IProperty[] Properties => new IProperty[] {
				Manufacturers,
				SerialNumber,
				ToolId,
				HasCuttingToolLifeCyclePart,
				HasCuttingToolArchetypeReferencePart,
				HasCuttingToolDefinitionPart,
			}.Concat(base.Properties).ToArray();
			/// <summary>
			/// <inheritdoc cref="ManufacturersProperty" path="/summary" /><br/>
			/// <remarks>Original Name: Manufacturers</remarks>
			/// </summary>
			public new ManufacturersProperty Manufacturers { get; } = new ManufacturersProperty();
			
			/// <summary>﻿manufacturers of the cutting tool.<br /><br />This will reference the tool item and adaptive items specifically. The cutting items<br />manufacturers’ will be a property of <see cref="CuttingItem">CuttingItem</see>.<br /><br />&gt; Note: In <i>XML</i>, the representation <b>MUST</b> be a comma(,) delimited list of manufacturer names. See <see cref="CuttingTool Schema Diagrams">CuttingTool Schema Diagrams</see>.<br /><br /><br />
			/// </summary>
			public new sealed class ManufacturersProperty : IProperty
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
				public string Summary => @"&#10;&#10;&#10;manufacturers of the cutting tool.

This will reference the tool item and adaptive items specifically. The cutting items
manufacturers’ will be a property of {{block(CuttingItem)}}.

> Note: In {{term(XML)}}, the representation **MUST** be a comma(,) delimited list of manufacturer names. See {{sect(CuttingTool Schema Diagrams)}}.&#10;
";

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
			public new SerialNumberProperty SerialNumber { get; } = new SerialNumberProperty();
			
			/// <summary>﻿unique identifier for this assembly.<br /><br /><br />
			/// </summary>
			public new sealed class SerialNumberProperty : IProperty
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
				public string Summary => @"&#10;&#10;&#10;unique identifier for this assembly.&#10;
";

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
			public new ToolIdProperty ToolId { get; } = new ToolIdProperty();
			
			/// <summary>﻿identifier for a class of cutting tools.<br /><br /><br />
			/// </summary>
			public new sealed class ToolIdProperty : IProperty
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
				public string Summary => @"&#10;&#10;&#10;identifier for a class of cutting tools.&#10;
";

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
			public new HasCuttingToolLifeCyclePartProperty HasCuttingToolLifeCyclePart { get; } = new HasCuttingToolLifeCyclePartProperty();
			
			/// <summary>﻿
			/// </summary>
			public new sealed class HasCuttingToolLifeCyclePartProperty : IProperty
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
				public string Summary => @"";

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
			public new HasCuttingToolArchetypeReferencePartProperty HasCuttingToolArchetypeReferencePart { get; } = new HasCuttingToolArchetypeReferencePartProperty();
			
			/// <summary>﻿
			/// </summary>
			public new sealed class HasCuttingToolArchetypeReferencePartProperty : IProperty
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
				public string Name => "hasCuttingToolArchetypeReference";
				
				/// <inheritdoc />
				public string Summary => @"";

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
			public new HasCuttingToolDefinitionPartProperty HasCuttingToolDefinitionPart { get; } = new HasCuttingToolDefinitionPartProperty();
			
			/// <summary>﻿<br /><br /><br />
			/// </summary>
			public new sealed class HasCuttingToolDefinitionPartProperty : IProperty
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
				public string Summary => @"&#10;&#10;&#10;&#10;
";

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