using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;

namespace Mtconnect.AssetInformationModel.CuttingTool.CuttingToolLifeCycle
{
	/// <summary>
	/// data regarding the application or use of the tool.  This data is provided by various pieces of equipment (i.e. machine tool, presetter) and statistical process control applications. Life cycle data will not remain static, but will change periodically when a tool is used or measured.
	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Structure__EAID_D1C82EBD_D828_4e5f_9F46_3337710837FE">model.mtconnect.org</seealso> for more information.
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.3.0.0")]
	public sealed class CuttingToolLifeCycleClass : IClass
	{
		/// <inheritdoc />
		public string ReferenceId => "EAID_D1C82EBD_D828_4e5f_9F46_3337710837FE";
		
		/// <inheritdoc />
		public string Summary => @"/// data regarding the application or use of the tool.  This data is provided by various pieces of equipment (i.e. machine tool, presetter) and statistical process control applications. Life cycle data will not remain static, but will change periodically when a tool is used or measured.";

		/// <inheritdoc />
		public string Name => "CuttingToolLifeCycle";
		
		/// <inheritdoc />
		public string AccessModifier => "public";
				
		/// <inheritdoc />
		public string Modifier => "";
				
		/// <inheritdoc />
		public string NormativeVersion => "1.2";
				
		/// <inheritdoc />
		public string DeprecatedVersion => "";
		
		/// <inheritdoc />
		public Type Generalization => null;

		/// <inheritdoc />
		public CuttingToolLifeCycleClassProperties Properties { get; } = new CuttingToolLifeCycleClassProperties();
        IPropertyList IClass.Properties => Properties;
		public class CuttingToolLifeCycleClassProperties : IPropertyList
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
			/// <summary>
			/// <inheritdoc cref="ConnectionCodeMachineSideProperty" path="/summary" /><br/>
			/// <remarks>Original Name: ConnectionCodeMachineSide</remarks>
			/// </summary>
			public ConnectionCodeMachineSideProperty ConnectionCodeMachineSide { get; } = new ConnectionCodeMachineSideProperty();
			/// <summary>
			/// identifier for the capability to connect any component of the cutting tool together, except Assembly Items, on the machine side. Code: <c>CCMS</c>
			/// </summary>
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
				public string Summary => @"/// data regarding the application or use of the tool.  This data is provided by various pieces of equipment (i.e. machine tool, presetter) and statistical process control applications. Life cycle data will not remain static, but will change periodically when a tool is used or measured.";

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
			/// <inheritdoc cref="ProgramToolGroupProperty" path="/summary" /><br/>
			/// <remarks>Original Name: ProgramToolGroup</remarks>
			/// </summary>
			public ProgramToolGroupProperty ProgramToolGroup { get; } = new ProgramToolGroupProperty();
			/// <summary>
			/// tool group this tool is assigned in the part program.
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
				public string Summary => @"/// data regarding the application or use of the tool.  This data is provided by various pieces of equipment (i.e. machine tool, presetter) and statistical process control applications. Life cycle data will not remain static, but will change periodically when a tool is used or measured.";

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
			/// <inheritdoc cref="ProgramToolNumberProperty" path="/summary" /><br/>
			/// <remarks>Original Name: ProgramToolNumber</remarks>
			/// </summary>
			public ProgramToolNumberProperty ProgramToolNumber { get; } = new ProgramToolNumberProperty();
			/// <summary>
			/// number of the tool as referenced in the part program.
			/// </summary>
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
				public string Summary => @"/// data regarding the application or use of the tool.  This data is provided by various pieces of equipment (i.e. machine tool, presetter) and statistical process control applications. Life cycle data will not remain static, but will change periodically when a tool is used or measured.";

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
			/// <inheritdoc cref="HasProcessFeedRatePartProperty" path="/summary" /><br/>
			/// <remarks>Original Name: HasProcessFeedRate</remarks>
			/// </summary>
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
				public string Name => "hasProcessFeedRate";
				
				/// <inheritdoc />
				public string Summary => @"/// data regarding the application or use of the tool.  This data is provided by various pieces of equipment (i.e. machine tool, presetter) and statistical process control applications. Life cycle data will not remain static, but will change periodically when a tool is used or measured.";

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
			}
			/// <summary>
			/// <inheritdoc cref="HasToolLifePartProperty" path="/summary" /><br/>
			/// <remarks>Original Name: HasToolLife</remarks>
			/// </summary>
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
				public string Name => "hasToolLife";
				
				/// <inheritdoc />
				public string Summary => @"/// data regarding the application or use of the tool.  This data is provided by various pieces of equipment (i.e. machine tool, presetter) and statistical process control applications. Life cycle data will not remain static, but will change periodically when a tool is used or measured.";

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
			}
			/// <summary>
			/// <inheritdoc cref="HasProcessSpindleSpeedPartProperty" path="/summary" /><br/>
			/// <remarks>Original Name: HasProcessSpindleSpeed</remarks>
			/// </summary>
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
				public string Name => "hasProcessSpindleSpeed";
				
				/// <inheritdoc />
				public string Summary => @"/// data regarding the application or use of the tool.  This data is provided by various pieces of equipment (i.e. machine tool, presetter) and statistical process control applications. Life cycle data will not remain static, but will change periodically when a tool is used or measured.";

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
				public string Name => "hasCutterStatus";
				
				/// <inheritdoc />
				public string Summary => @"/// data regarding the application or use of the tool.  This data is provided by various pieces of equipment (i.e. machine tool, presetter) and statistical process control applications. Life cycle data will not remain static, but will change periodically when a tool is used or measured.";

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
			/// <inheritdoc cref="HasCuttingItemPartProperty" path="/summary" /><br/>
			/// <remarks>Original Name: HasCuttingItem</remarks>
			/// </summary>
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
				public string Name => "hasCuttingItem";
				
				/// <inheritdoc />
				public string Summary => @"/// data regarding the application or use of the tool.  This data is provided by various pieces of equipment (i.e. machine tool, presetter) and statistical process control applications. Life cycle data will not remain static, but will change periodically when a tool is used or measured.";

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
			}
			/// <summary>
			/// <inheritdoc cref="HasMeasurementPartProperty" path="/summary" /><br/>
			/// <remarks>Original Name: HasMeasurement</remarks>
			/// </summary>
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
				public string Name => "hasMeasurement";
				
				/// <inheritdoc />
				public string Summary => @"/// data regarding the application or use of the tool.  This data is provided by various pieces of equipment (i.e. machine tool, presetter) and statistical process control applications. Life cycle data will not remain static, but will change periodically when a tool is used or measured.";

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
			/// <summary>
			/// <inheritdoc cref="HasReconditionCountPartProperty" path="/summary" /><br/>
			/// <remarks>Original Name: HasReconditionCount</remarks>
			/// </summary>
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
				public string Name => "hasReconditionCount";
				
				/// <inheritdoc />
				public string Summary => @"/// data regarding the application or use of the tool.  This data is provided by various pieces of equipment (i.e. machine tool, presetter) and statistical process control applications. Life cycle data will not remain static, but will change periodically when a tool is used or measured.";

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
			}
			/// <summary>
			/// <inheritdoc cref="HasLocationPartProperty" path="/summary" /><br/>
			/// <remarks>Original Name: HasLocation</remarks>
			/// </summary>
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
				public string Name => "hasLocation";
				
				/// <inheritdoc />
				public string Summary => @"/// data regarding the application or use of the tool.  This data is provided by various pieces of equipment (i.e. machine tool, presetter) and statistical process control applications. Life cycle data will not remain static, but will change periodically when a tool is used or measured.";

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
			}
		};

	}
}