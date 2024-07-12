
using System;
using System.CodeDom.Compiler;

using Mtconnect.AssetInformationModel.CuttingTool.CuttingToolLifeCycle;
using Mtconnect.AssetInformationModel.CuttingTool.CuttingItem;

namespace Mtconnect.AssetInformationModel.CuttingTool.CuttingToolLifeCycle
{
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "1.0.15.3")]
	public sealed class CuttingToolLifeCycleClass
	{
		/// <inheritdoc cref="Class.ReferenceId" />
		public string ReferenceId => "EAID_D1C82EBD_D828_4e5f_9F46_3337710837FE";
		
		/// <inheritdoc cref="Class.Name" />
		public string Name => "CuttingToolLifeCycle";
		
		/// <inheritdoc cref="Class.AccessModifier" />
		public string AccessModifier => "public";
				
		/// <inheritdoc cref="Class.Modifier" />
		public string Modifier => "";
				
		/// <inheritdoc cref="Class.NormativeVersion" />
		public string NormativeVersion => "MtconnectVersions.V_1_2_0";
				
		/// <inheritdoc cref="Class.DeprecatedVersion" />
		public string DeprecatedVersion => "";

		public string Generalization => "";

		public CuttingToolLifeCycleProperties Properties { get; } = new CuttingToolLifeCycleProperties();
		public sealed class CuttingToolLifeCycleProperties
		{
		
		
			/// <remarks>Original Name: ConnectionCodeMachineSide</remarks>
			public ConnectionCodeMachineSideProperty ConnectionCodeMachineSide { get; } = new ConnectionCodeMachineSideProperty();
			public sealed class ConnectionCodeMachineSideProperty
			{
				/// <inheritdoc cref="Property.Type" />
				/// Original Type: _19_0_3_91b028d_1579272360416_763325_681
				public Type Type => typeof(String);
				
				/// <inheritdoc cref="Property.Name" />
				public string Name => "ConnectionCodeMachineSide";
				
				/// <inheritdoc cref="Property.AccessModifier" />
				public string AccessModifier => "public";
				
				/// <inheritdoc cref="Property.Modifier" />
				public string Modifier => "";
				
				/// <inheritdoc cref="Property.NormativeVersion" />
				public string NormativeVersion => "MtconnectVersions.V_1_2_0";
				
				/// <inheritdoc cref="Property.DeprecatedVersion" />
				public string DeprecatedVersion => "";
				
				public string Aggregation => "";

				// Note: Extension.Extender
				public string Extension => "MagicDraw UML 19.0";

				public string Association => "";

				// Note: DefaultValue.Name
				public string DefaultValue => "";

				// TODO: Add Summary
			}
		
		
			/// <remarks>Original Name: ProgramToolGroup</remarks>
			public ProgramToolGroupProperty ProgramToolGroup { get; } = new ProgramToolGroupProperty();
			public sealed class ProgramToolGroupProperty
			{
				/// <inheritdoc cref="Property.Type" />
				/// Original Type: _19_0_3_91b028d_1579272360416_763325_681
				public Type Type => typeof(String);
				
				/// <inheritdoc cref="Property.Name" />
				public string Name => "ProgramToolGroup";
				
				/// <inheritdoc cref="Property.AccessModifier" />
				public string AccessModifier => "public";
				
				/// <inheritdoc cref="Property.Modifier" />
				public string Modifier => "";
				
				/// <inheritdoc cref="Property.NormativeVersion" />
				public string NormativeVersion => "MtconnectVersions.V_1_2_0";
				
				/// <inheritdoc cref="Property.DeprecatedVersion" />
				public string DeprecatedVersion => "";
				
				public string Aggregation => "";

				// Note: Extension.Extender
				public string Extension => "MagicDraw UML 19.0";

				public string Association => "";

				// Note: DefaultValue.Name
				public string DefaultValue => "";

				// TODO: Add Summary
			}
		
		
			/// <remarks>Original Name: ProgramToolNumber</remarks>
			public ProgramToolNumberProperty ProgramToolNumber { get; } = new ProgramToolNumberProperty();
			public sealed class ProgramToolNumberProperty
			{
				/// <inheritdoc cref="Property.Type" />
				/// Original Type: _19_0_3_91b028d_1579272360416_763325_681
				public Type Type => typeof(String);
				
				/// <inheritdoc cref="Property.Name" />
				public string Name => "ProgramToolNumber";
				
				/// <inheritdoc cref="Property.AccessModifier" />
				public string AccessModifier => "public";
				
				/// <inheritdoc cref="Property.Modifier" />
				public string Modifier => "";
				
				/// <inheritdoc cref="Property.NormativeVersion" />
				public string NormativeVersion => "MtconnectVersions.V_1_2_0";
				
				/// <inheritdoc cref="Property.DeprecatedVersion" />
				public string DeprecatedVersion => "";
				
				public string Aggregation => "";

				// Note: Extension.Extender
				public string Extension => "MagicDraw UML 19.0";

				public string Association => "";

				// Note: DefaultValue.Name
				public string DefaultValue => "";

				// TODO: Add Summary
			}
		
		
			/// <remarks>Original Name: HasProcessFeedRate</remarks>
			public HasProcessFeedRatePartProperty HasProcessFeedRatePart { get; } = new HasProcessFeedRatePartProperty();
			public sealed class HasProcessFeedRatePartProperty
			{
				/// <inheritdoc cref="Property.Type" />
				/// Original Type: EAID_07E81F95_CE0D_4404_9384_30E428006C48
				public Type Type => typeof(ProcessFeedRateClass);
				
				/// <inheritdoc cref="Property.Name" />
				public string Name => "HasProcessFeedRate";
				
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

				public string Association => "ProcessFeedRate";

				// Note: DefaultValue.Name
				public string DefaultValue => "";

				// TODO: Add Summary
			}
		
		
			/// <remarks>Original Name: HasToolLife</remarks>
			public HasToolLifePartProperty HasToolLifePart { get; } = new HasToolLifePartProperty();
			public sealed class HasToolLifePartProperty
			{
				/// <inheritdoc cref="Property.Type" />
				/// Original Type: EAID_37DECE45_091E_4f0c_AD72_EB481C0C1919
				public Type Type => typeof(ToolLifeClass);
				
				/// <inheritdoc cref="Property.Name" />
				public string Name => "HasToolLife";
				
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

				public string Association => "ToolLife";

				// Note: DefaultValue.Name
				public string DefaultValue => "";

				// TODO: Add Summary
			}
		
		
			/// <remarks>Original Name: HasProcessSpindleSpeed</remarks>
			public HasProcessSpindleSpeedPartProperty HasProcessSpindleSpeedPart { get; } = new HasProcessSpindleSpeedPartProperty();
			public sealed class HasProcessSpindleSpeedPartProperty
			{
				/// <inheritdoc cref="Property.Type" />
				/// Original Type: EAID_3B2E47CE_BBF6_4b7a_A0C6_146B2BE8331A
				public Type Type => typeof(ProcessSpindleSpeedClass);
				
				/// <inheritdoc cref="Property.Name" />
				public string Name => "HasProcessSpindleSpeed";
				
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

				public string Association => "ProcessSpindleSpeed";

				// Note: DefaultValue.Name
				public string DefaultValue => "";

				// TODO: Add Summary
			}
		
		
			/// <remarks>Original Name: HasCutterStatus</remarks>
			public HasCutterStatusPartProperty HasCutterStatusPart { get; } = new HasCutterStatusPartProperty();
			public sealed class HasCutterStatusPartProperty
			{
				/// <inheritdoc cref="Property.Type" />
				/// Original Type: EAID_2F5EC70A_8269_4c6a_AAB3_7F17B8F22C82
				public Type Type => typeof(StatusClass);
				
				/// <inheritdoc cref="Property.Name" />
				public string Name => "HasCutterStatus";
				
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

				public string Association => "CutterStatus";

				// Note: DefaultValue.Name
				public string DefaultValue => "";

				// TODO: Add Summary
			}
		
		
			/// <remarks>Original Name: HasCuttingItem</remarks>
			public HasCuttingItemPartProperty HasCuttingItemPart { get; } = new HasCuttingItemPartProperty();
			public sealed class HasCuttingItemPartProperty
			{
				/// <inheritdoc cref="Property.Type" />
				/// Original Type: EAID_99183806_F570_4387_BA6D_34929C20F954
				public Type Type => typeof(CuttingItemClass);
				
				/// <inheritdoc cref="Property.Name" />
				public string Name => "HasCuttingItem";
				
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

				public string Association => "CuttingItemsClass";

				// Note: DefaultValue.Name
				public string DefaultValue => "";

				// TODO: Add Summary
			}
		
		
			/// <remarks>Original Name: HasMeasurement</remarks>
			public HasMeasurementPartProperty HasMeasurementPart { get; } = new HasMeasurementPartProperty();
			public sealed class HasMeasurementPartProperty
			{
				/// <inheritdoc cref="Property.Type" />
				/// Original Type: EAID_C09F377D_8946_421b_B746_E23C01D97EAC
				public Type Type => typeof(MeasurementClass);
				
				/// <inheritdoc cref="Property.Name" />
				public string Name => "HasMeasurement";
				
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

				public string Association => "Measurements";

				// Note: DefaultValue.Name
				public string DefaultValue => "";

				// TODO: Add Summary
			}
		
		
			/// <remarks>Original Name: HasReconditionCount</remarks>
			public HasReconditionCountPartProperty HasReconditionCountPart { get; } = new HasReconditionCountPartProperty();
			public sealed class HasReconditionCountPartProperty
			{
				/// <inheritdoc cref="Property.Type" />
				/// Original Type: EAID_AB33F1B2_493B_4f60_9394_4A69B30576F9
				public Type Type => typeof(ReconditionCountClass);
				
				/// <inheritdoc cref="Property.Name" />
				public string Name => "HasReconditionCount";
				
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

				public string Association => "ReconditionCount";

				// Note: DefaultValue.Name
				public string DefaultValue => "";

				// TODO: Add Summary
			}
		
		
			/// <remarks>Original Name: HasLocation</remarks>
			public HasLocationPartProperty HasLocationPart { get; } = new HasLocationPartProperty();
			public sealed class HasLocationPartProperty
			{
				/// <inheritdoc cref="Property.Type" />
				/// Original Type: EAID_A012A42B_DBEC_4334_891D_5B45D7A7E340
				public Type Type => typeof(LocationClass);
				
				/// <inheritdoc cref="Property.Name" />
				public string Name => "HasLocation";
				
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

				public string Association => "Location";

				// Note: DefaultValue.Name
				public string DefaultValue => "";

				// TODO: Add Summary
			}
		};

	}
}