using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;
// using Mtconnect.AssetInformationModel.CuttingTool.CuttingToolLifeCycle;
// using Mtconnect.AssetInformationModel.CuttingTool.CuttingItem;

namespace Mtconnect.AssetInformationModel.CuttingTool.CuttingItem
{
	/// <summary>
	/// part of of the tool that physically removes the material from the workpiece by shear deformation.
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.3.0.0")]
	public sealed class CuttingItemClass : IClass
	{
		/// <inheritdoc />
		public string ReferenceId => "EAID_99183806_F570_4387_BA6D_34929C20F954";
		
		/// <inheritdoc />
		public string Summary => @"/// part of of the tool that physically removes the material from the workpiece by shear deformation.";

		/// <inheritdoc />
		public string Name => "CuttingItemClass";
		
		/// <inheritdoc />
		public string AccessModifier => "public";
				
		/// <inheritdoc />
		public string Modifier => "";
				
		/// <inheritdoc />
		public string NormativeVersion => "1.2";
				
		/// <inheritdoc />
		public string DeprecatedVersion => "";
		
		/// <inheritdoc />
		public string Generalization => "";

		/// <inheritdoc />
		public CuttingItemClassProperties Properties { get; } = new CuttingItemClassProperties();
        IPropertyList IClass.Properties => Properties;
		public sealed class CuttingItemClassProperties : IPropertyList
		{
			/// <inheritdoc />
			public IProperty[] Properties => new IProperty[] {
				Description,
				Grade,
				Indices,
				ItemId,
				Locus,
				Manufacturers,
				ProgramToolGroup,
				HasCutterStatusPart,
				HasItemLifePart,
				HasMeasurementPart,
			};
			/// <summary>
			/// <inheritdoc cref="DescriptionProperty" path="/summary" /><br/>
			/// <remarks>Original Name: Description</remarks>
			/// </summary>
			public DescriptionProperty Description { get; } = new DescriptionProperty();
			/// <summary>
			/// free-form description of the cutting item.
			/// </summary>
			public sealed class DescriptionProperty : IProperty
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
				public string Name => "Description";
				
				/// <inheritdoc />
				public string Summary => @"/// part of of the tool that physically removes the material from the workpiece by shear deformation.";

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
			/// <inheritdoc cref="GradeProperty" path="/summary" /><br/>
			/// <remarks>Original Name: Grade</remarks>
			/// </summary>
			public GradeProperty Grade { get; } = new GradeProperty();
			/// <summary>
			/// material composition for this cutting item. 
			/// </summary>
			public sealed class GradeProperty : IProperty
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
				public string Name => "Grade";
				
				/// <inheritdoc />
				public string Summary => @"/// part of of the tool that physically removes the material from the workpiece by shear deformation.";

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
			/// <inheritdoc cref="IndicesProperty" path="/summary" /><br/>
			/// <remarks>Original Name: Indices</remarks>
			/// </summary>
			public IndicesProperty Indices { get; } = new IndicesProperty();
			/// <summary>
			/// number or numbers representing the individual cutting item or items on the tool.  Indices <b>SHOULD</b> start numbering with the inserts or <see cref="CuttingItem">CuttingItem</see> furthest from the gauge line and increasing in value as the items get closer to the gauge line. Items at the same distance <b>MAY</b> be arbitrarily numbered.  > Note: In <i>XML</i>, the representation <b>MUST</b> be a single number ("1") or a comma separated set of individual elements ("1,2,3,4"), or as a inclusive range of values as in ("1-10") or any combination of ranges and numbers as in "1-4,6-10,22". There <b>MUST NOT</b> be spaces or non-integer values in the text representation.
			/// </summary>
			public sealed class IndicesProperty : IProperty
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
				public string Name => "Indices";
				
				/// <inheritdoc />
				public string Summary => @"/// part of of the tool that physically removes the material from the workpiece by shear deformation.";

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
			/// <inheritdoc cref="ItemIdProperty" path="/summary" /><br/>
			/// <remarks>Original Name: ItemId</remarks>
			/// </summary>
			public ItemIdProperty ItemId { get; } = new ItemIdProperty();
			/// <summary>
			/// manufacturer identifier of this cutting item.
			/// </summary>
			public sealed class ItemIdProperty : IProperty
			{
				/// <summary>
				/// <inheritdoc />
				/// <remarks>
				/// <list type="bullet">
				/// <item>Original Type: _19_0_3_91b028d_1579272245466_691733_672</item>
				/// <item>Type: String</item>
				/// <item>Namespace: </item>
				/// </list>
				/// </remarks>
				/// </summary>
				public System.Type Type => typeof(String);
				
				/// <inheritdoc />
				public string Name => "ItemId";
				
				/// <inheritdoc />
				public string Summary => @"/// part of of the tool that physically removes the material from the workpiece by shear deformation.";

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
			/// <inheritdoc cref="LocusProperty" path="/summary" /><br/>
			/// <remarks>Original Name: Locus</remarks>
			/// </summary>
			public LocusProperty Locus { get; } = new LocusProperty();
			/// <summary>
			/// free form description of the location on the cutting tool.  For clarity, the words <c>FLUTE</c>, <c>INSERT</c>, and <c>CARTRIDGE</c> <b>SHOULD</b> be used to assist in noting the location of a <see cref="CuttingItem">CuttingItem</see>. <see cref="CuttingItem::Locus" /> <b>MAY</b> be any free form string, but <b>SHOULD</b> adhere to the following rules:  * The location numbering <b>SHOULD</b> start at the furthest <see cref="CuttingItem">CuttingItem</see> and work it’s way back to the <see cref="CuttingItem">CuttingItem</see> closest to the gauge line.  * Flutes <b>SHOULD</b> be identified as such using the word <c>FLUTE</c>:. For example: <c>FLUTE</c>: 1, <c>INSERT</c>: 2 - would indicate the first flute and the second furthest insert from the end of the tool on that flute.  * Other designations such as <c>CARTRIDGE</c> <b>MAY</b> be included, but should be identified using upper case and followed by a colon (:).
			/// </summary>
			public sealed class LocusProperty : IProperty
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
				public string Name => "Locus";
				
				/// <inheritdoc />
				public string Summary => @"/// part of of the tool that physically removes the material from the workpiece by shear deformation.";

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
			/// <inheritdoc cref="ManufacturersProperty" path="/summary" /><br/>
			/// <remarks>Original Name: Manufacturers</remarks>
			/// </summary>
			public ManufacturersProperty Manufacturers { get; } = new ManufacturersProperty();
			/// <summary>
			/// manufacturers of the cutting item.  This will reference the tool item and adaptive items specifically. The cutting items manufacturers’ will be a property of <see cref="CuttingItem">CuttingItem</see>.  > Note: In <i>XML</i>, the representation <b>MUST</b> be a comma(,) delimited list of manufacturer names. See <see cref="CuttingItem Schema Diagrams">CuttingItem Schema Diagrams</see>.
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
				public string Summary => @"/// part of of the tool that physically removes the material from the workpiece by shear deformation.";

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
			/// <inheritdoc cref="ProgramToolGroupProperty" path="/summary" /><br/>
			/// <remarks>Original Name: ProgramToolGroup</remarks>
			/// </summary>
			public ProgramToolGroupProperty ProgramToolGroup { get; } = new ProgramToolGroupProperty();
			/// <summary>
			/// tool group this item is assigned in the part program.
			/// </summary>
			public sealed class ProgramToolGroupProperty : IProperty
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
				public string Name => "ProgramToolGroup";
				
				/// <inheritdoc />
				public string Summary => @"/// part of of the tool that physically removes the material from the workpiece by shear deformation.";

				/// <inheritdoc />
				public string AccessModifier => "public";
				
				/// <inheritdoc />
				public string Modifier => "";
				
				/// <inheritdoc />
				public string NormativeVersion => "1.4";
				
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
			/// <inheritdoc cref="HasCutterStatusPartProperty" path="/summary" /><br/>
			/// <remarks>Original Name: HasCutterStatus</remarks>
			/// </summary>
			public HasCutterStatusPartProperty HasCutterStatusPart { get; } = new HasCutterStatusPartProperty();
			public sealed class HasCutterStatusPartProperty : IProperty
			{
				/// <summary>
				/// <inheritdoc />
				/// <remarks>
				/// <list type="bullet">
				/// <item>Original Type: EAID_2F5EC70A_8269_4c6a_AAB3_7F17B8F22C82</item>
				/// <item>Type: StatusClass</item>
				/// <item>Namespace: Mtconnect.AssetInformationModel.CuttingTool.CuttingToolLifeCycle</item>
				/// </list>
				/// </remarks>
				/// </summary>
				public System.Type Type => typeof(Mtconnect.AssetInformationModel.CuttingTool.CuttingToolLifeCycle.StatusClass);
				
				/// <inheritdoc />
				public string Name => "HasCutterStatus";
				
				/// <inheritdoc />
				public string Summary => @"/// part of of the tool that physically removes the material from the workpiece by shear deformation.";

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
				public string Association => "CutterStatus";

				// Note: DefaultValue.Name
				/// <inheritdoc />
				public string DefaultValue => "";
			}
			/// <summary>
			/// <inheritdoc cref="HasItemLifePartProperty" path="/summary" /><br/>
			/// <remarks>Original Name: HasItemLife</remarks>
			/// </summary>
			public HasItemLifePartProperty HasItemLifePart { get; } = new HasItemLifePartProperty();
			/// <summary>
			/// The tool life measured in tool wear.
			/// </summary>
			public sealed class HasItemLifePartProperty : IProperty
			{
				/// <summary>
				/// <inheritdoc />
				/// <remarks>
				/// <list type="bullet">
				/// <item>Original Type: EAID_CC4F8633_BAAC_47e8_9EFB_2BFC62215FC8</item>
				/// <item>Type: ItemLifeClass</item>
				/// <item>Namespace: Mtconnect.AssetInformationModel.CuttingTool.CuttingItem</item>
				/// </list>
				/// </remarks>
				/// </summary>
				public System.Type Type => typeof(Mtconnect.AssetInformationModel.CuttingTool.CuttingItem.ItemLifeClass);
				
				/// <inheritdoc />
				public string Name => "HasItemLife";
				
				/// <inheritdoc />
				public string Summary => @"/// part of of the tool that physically removes the material from the workpiece by shear deformation.";

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
				public string Association => "ItemLife";

				// Note: DefaultValue.Name
				/// <inheritdoc />
				public string DefaultValue => "";
			}
			/// <summary>
			/// <inheritdoc cref="HasMeasurementPartProperty" path="/summary" /><br/>
			/// <remarks>Original Name: HasMeasurement</remarks>
			/// </summary>
			public HasMeasurementPartProperty HasMeasurementPart { get; } = new HasMeasurementPartProperty();
			/// <summary>
			/// A collection of measurements relating to this cutting item.
			/// </summary>
			public sealed class HasMeasurementPartProperty : IProperty
			{
				/// <summary>
				/// <inheritdoc />
				/// <remarks>
				/// <list type="bullet">
				/// <item>Original Type: EAID_C09F377D_8946_421b_B746_E23C01D97EAC</item>
				/// <item>Type: MeasurementClass</item>
				/// <item>Namespace: Mtconnect.AssetInformationModel.CuttingTool.CuttingToolLifeCycle</item>
				/// </list>
				/// </remarks>
				/// </summary>
				public System.Type Type => typeof(Mtconnect.AssetInformationModel.CuttingTool.CuttingToolLifeCycle.MeasurementClass);
				
				/// <inheritdoc />
				public string Name => "HasMeasurement";
				
				/// <inheritdoc />
				public string Summary => @"/// part of of the tool that physically removes the material from the workpiece by shear deformation.";

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
				public string Association => "Measurements";

				// Note: DefaultValue.Name
				/// <inheritdoc />
				public string DefaultValue => "";
			}
		};

	}
}