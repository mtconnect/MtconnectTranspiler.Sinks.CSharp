using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;
// using Mtconnect.AssetInformationModel.CuttingTool.CuttingToolLifeCycle;
// using Mtconnect.AssetInformationModel.CuttingTool.CuttingItem;

namespace Mtconnect.AssetInformationModel.CuttingTool.CuttingToolLifeCycle
{
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "1.0.15.3")]
	public sealed class CuttingToolLifeCycleClass : IClass
	{
		/// <inheritdoc />
		public string ReferenceId => "EAID_D1C82EBD_D828_4e5f_9F46_3337710837FE";
		
		/// <inheritdoc />
		public string Name => "CuttingToolLifeCycleClass";
		
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
		public CuttingToolLifeCycleClassProperties Properties { get; } = new CuttingToolLifeCycleClassProperties();
        IPropertyList IClass.Properties => Properties;
		public sealed class CuttingToolLifeCycleClassProperties : IPropertyList
		{
			/// <inheritdoc />
			public IProperty[] Properties => new IProperty[] {
				ConnectionCodeMachineSide,
				ProgramToolGroup,
				ProgramToolNumber,
				HasProcessFeedRatePart,
				HasToolLifePart,
				HasProcessSpindleSpeedPart,
				HasCutterStatusPart,
				HasCuttingItemPart,
				HasMeasurementPart,
				HasReconditionCountPart,
				HasLocationPart,
			};
			/// <remarks>Original Name: ConnectionCodeMachineSide</remarks>
			public ConnectionCodeMachineSideProperty ConnectionCodeMachineSide { get; } = new ConnectionCodeMachineSideProperty();
			public sealed class ConnectionCodeMachineSideProperty : IProperty
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
				public string Name => "ConnectionCodeMachineSide";
				
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

				// TODO: Add Summary
			}
			/// <remarks>Original Name: ProgramToolGroup</remarks>
			public ProgramToolGroupProperty ProgramToolGroup { get; } = new ProgramToolGroupProperty();
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

				// TODO: Add Summary
			}
			/// <remarks>Original Name: ProgramToolNumber</remarks>
			public ProgramToolNumberProperty ProgramToolNumber { get; } = new ProgramToolNumberProperty();
			public sealed class ProgramToolNumberProperty : IProperty
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
				public string Name => "ProgramToolNumber";
				
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

				// TODO: Add Summary
			}
			/// <remarks>Original Name: HasProcessFeedRate</remarks>
			public HasProcessFeedRatePartProperty HasProcessFeedRatePart { get; } = new HasProcessFeedRatePartProperty();
			public sealed class HasProcessFeedRatePartProperty : IProperty
			{
				/// <summary>
				/// <inheritdoc />
				/// <remarks>
				/// <list type="bullet">
				/// <item>Original Type: EAID_07E81F95_CE0D_4404_9384_30E428006C48</item>
				/// <item>Type: ProcessFeedRateClass</item>
				/// <item>Namespace: Mtconnect.AssetInformationModel.CuttingTool.CuttingToolLifeCycle</item>
				/// </list>
				/// </remarks>
				/// </summary>
				public System.Type Type => typeof(Mtconnect.AssetInformationModel.CuttingTool.CuttingToolLifeCycle.ProcessFeedRateClass);
				
				/// <inheritdoc />
				public string Name => "HasProcessFeedRate";
				
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
				public string Association => "ProcessFeedRate";

				// Note: DefaultValue.Name
				/// <inheritdoc />
				public string DefaultValue => "";

				// TODO: Add Summary
			}
			/// <remarks>Original Name: HasToolLife</remarks>
			public HasToolLifePartProperty HasToolLifePart { get; } = new HasToolLifePartProperty();
			public sealed class HasToolLifePartProperty : IProperty
			{
				/// <summary>
				/// <inheritdoc />
				/// <remarks>
				/// <list type="bullet">
				/// <item>Original Type: EAID_37DECE45_091E_4f0c_AD72_EB481C0C1919</item>
				/// <item>Type: ToolLifeClass</item>
				/// <item>Namespace: Mtconnect.AssetInformationModel.CuttingTool.CuttingToolLifeCycle</item>
				/// </list>
				/// </remarks>
				/// </summary>
				public System.Type Type => typeof(Mtconnect.AssetInformationModel.CuttingTool.CuttingToolLifeCycle.ToolLifeClass);
				
				/// <inheritdoc />
				public string Name => "HasToolLife";
				
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
				public string Association => "ToolLife";

				// Note: DefaultValue.Name
				/// <inheritdoc />
				public string DefaultValue => "";

				// TODO: Add Summary
			}
			/// <remarks>Original Name: HasProcessSpindleSpeed</remarks>
			public HasProcessSpindleSpeedPartProperty HasProcessSpindleSpeedPart { get; } = new HasProcessSpindleSpeedPartProperty();
			public sealed class HasProcessSpindleSpeedPartProperty : IProperty
			{
				/// <summary>
				/// <inheritdoc />
				/// <remarks>
				/// <list type="bullet">
				/// <item>Original Type: EAID_3B2E47CE_BBF6_4b7a_A0C6_146B2BE8331A</item>
				/// <item>Type: ProcessSpindleSpeedClass</item>
				/// <item>Namespace: Mtconnect.AssetInformationModel.CuttingTool.CuttingToolLifeCycle</item>
				/// </list>
				/// </remarks>
				/// </summary>
				public System.Type Type => typeof(Mtconnect.AssetInformationModel.CuttingTool.CuttingToolLifeCycle.ProcessSpindleSpeedClass);
				
				/// <inheritdoc />
				public string Name => "HasProcessSpindleSpeed";
				
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
				public string Association => "ProcessSpindleSpeed";

				// Note: DefaultValue.Name
				/// <inheritdoc />
				public string DefaultValue => "";

				// TODO: Add Summary
			}
			/// <remarks>Original Name: HasCutterStatus</remarks>
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

				// TODO: Add Summary
			}
			/// <remarks>Original Name: HasCuttingItem</remarks>
			public HasCuttingItemPartProperty HasCuttingItemPart { get; } = new HasCuttingItemPartProperty();
			public sealed class HasCuttingItemPartProperty : IProperty
			{
				/// <summary>
				/// <inheritdoc />
				/// <remarks>
				/// <list type="bullet">
				/// <item>Original Type: EAID_99183806_F570_4387_BA6D_34929C20F954</item>
				/// <item>Type: CuttingItemClass</item>
				/// <item>Namespace: Mtconnect.AssetInformationModel.CuttingTool.CuttingItem</item>
				/// </list>
				/// </remarks>
				/// </summary>
				public System.Type Type => typeof(Mtconnect.AssetInformationModel.CuttingTool.CuttingItem.CuttingItemClass);
				
				/// <inheritdoc />
				public string Name => "HasCuttingItem";
				
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
				public string Association => "CuttingItemsClass";

				// Note: DefaultValue.Name
				/// <inheritdoc />
				public string DefaultValue => "";

				// TODO: Add Summary
			}
			/// <remarks>Original Name: HasMeasurement</remarks>
			public HasMeasurementPartProperty HasMeasurementPart { get; } = new HasMeasurementPartProperty();
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

				// TODO: Add Summary
			}
			/// <remarks>Original Name: HasReconditionCount</remarks>
			public HasReconditionCountPartProperty HasReconditionCountPart { get; } = new HasReconditionCountPartProperty();
			public sealed class HasReconditionCountPartProperty : IProperty
			{
				/// <summary>
				/// <inheritdoc />
				/// <remarks>
				/// <list type="bullet">
				/// <item>Original Type: EAID_AB33F1B2_493B_4f60_9394_4A69B30576F9</item>
				/// <item>Type: ReconditionCountClass</item>
				/// <item>Namespace: Mtconnect.AssetInformationModel.CuttingTool.CuttingToolLifeCycle</item>
				/// </list>
				/// </remarks>
				/// </summary>
				public System.Type Type => typeof(Mtconnect.AssetInformationModel.CuttingTool.CuttingToolLifeCycle.ReconditionCountClass);
				
				/// <inheritdoc />
				public string Name => "HasReconditionCount";
				
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
				public string Association => "ReconditionCount";

				// Note: DefaultValue.Name
				/// <inheritdoc />
				public string DefaultValue => "";

				// TODO: Add Summary
			}
			/// <remarks>Original Name: HasLocation</remarks>
			public HasLocationPartProperty HasLocationPart { get; } = new HasLocationPartProperty();
			public sealed class HasLocationPartProperty : IProperty
			{
				/// <summary>
				/// <inheritdoc />
				/// <remarks>
				/// <list type="bullet">
				/// <item>Original Type: EAID_A012A42B_DBEC_4334_891D_5B45D7A7E340</item>
				/// <item>Type: LocationClass</item>
				/// <item>Namespace: Mtconnect.AssetInformationModel.CuttingTool.CuttingToolLifeCycle</item>
				/// </list>
				/// </remarks>
				/// </summary>
				public System.Type Type => typeof(Mtconnect.AssetInformationModel.CuttingTool.CuttingToolLifeCycle.LocationClass);
				
				/// <inheritdoc />
				public string Name => "HasLocation";
				
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
				public string Association => "Location";

				// Note: DefaultValue.Name
				/// <inheritdoc />
				public string DefaultValue => "";

				// TODO: Add Summary
			}
		};

	}
}