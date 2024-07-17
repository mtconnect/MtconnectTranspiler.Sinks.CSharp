using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;
// using Mtconnect.DeviceInformationModel.Components.ComponentTypes;
// using Mtconnect.Glossary.MTConnectTerms;
// using Mtconnect.ObservationInformationModel.ObservationTypes.EventTypes;
// using Mtconnect.ObservationInformationModel.ObservationTypes.ConditionTypes;

namespace Mtconnect.DeviceInformationModel.Components.ComponentTypes
{
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "1.0.15.3")]
	public sealed class ControllerClass : IClass
	{
		/// <inheritdoc />
		public string ReferenceId => "_19_0_3_45f01b9_1579572381977_283525_42216";
		
		/// <inheritdoc />
		public string Name => "ControllerClass";
		
		/// <inheritdoc />
		public string AccessModifier => "public";
				
		/// <inheritdoc />
		public string Modifier => "";
				
		/// <inheritdoc />
		public string NormativeVersion => "1.0";
				
		/// <inheritdoc />
		public string DeprecatedVersion => "";
		
		/// <inheritdoc />
		public string Generalization => "_19_0_3_45f01b9_1579572382020_336298_42297";

		/// <inheritdoc />
		public ControllerClassProperties Properties { get; } = new ControllerClassProperties();
        IPropertyList IClass.Properties => Properties;
		public sealed class ControllerClassProperties : IPropertyList
		{
			/// <inheritdoc />
			public IProperty[] Properties => new IProperty[] {
				HasPathPart,
				IsControllerOfPart,
				ObservesEmergencyStop,
				ObservesSystemCondition,
				ObservesControllerMode,
				ObservesCommunicationsCondition,
				ObservesLogicProgramCondition,
			};
			/// <remarks>Original Name: HasPath</remarks>
			public HasPathPartProperty HasPathPart { get; } = new HasPathPartProperty();
			public sealed class HasPathPartProperty : IProperty
			{
				/// <summary>
				/// <inheritdoc />
				/// <remarks>
				/// <list type="bullet">
				/// <item>Original Type: _19_0_3_45f01b9_1579572382004_482583_42267</item>
				/// <item>Type: PathClass</item>
				/// <item>Namespace: Mtconnect.DeviceInformationModel.Components.ComponentTypes</item>
				/// </list>
				/// </remarks>
				/// </summary>
				public System.Type Type => typeof(Mtconnect.DeviceInformationModel.Components.ComponentTypes.PathClass);
				
				/// <inheritdoc />
				public string Name => "HasPath";
				
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
				public string Association => "Path";

				// Note: DefaultValue.Name
				/// <inheritdoc />
				public string DefaultValue => "";

				// TODO: Add Summary
			}
			/// <remarks>Original Name: IsControllerOf</remarks>
			public IsControllerOfPartProperty IsControllerOfPart { get; } = new IsControllerOfPartProperty();
			public sealed class IsControllerOfPartProperty : IProperty
			{
				/// <summary>
				/// <inheritdoc />
				/// <remarks>
				/// <list type="bullet">
				/// <item>Original Type: _19_0_3_68e0225_1620240839406_285612_1596</item>
				/// <item>Type: DeviceClass</item>
				/// <item>Namespace: Mtconnect.Glossary.MTConnectTerms</item>
				/// </list>
				/// </remarks>
				/// </summary>
				public System.Type Type => typeof(Mtconnect.Glossary.MTConnectTerms.DeviceClass);
				
				/// <inheritdoc />
				public string Name => "IsControllerOf";
				
				/// <inheritdoc />
				public string AccessModifier => "private";
				
				/// <inheritdoc />
				public string Modifier => "";
				
				/// <inheritdoc />
				public string NormativeVersion => "";
				
				/// <inheritdoc />
				public string DeprecatedVersion => "";
				
				/// <inheritdoc />
				public string Aggregation => "";

				// Note: Extension.Extender
				/// <inheritdoc />
				public string Extension => "MagicDraw UML 19.0";
				
				/// <inheritdoc />
				public string Association => "ControllersClass";

				// Note: DefaultValue.Name
				/// <inheritdoc />
				public string DefaultValue => "";

				// TODO: Add Summary
			}
			/// <remarks>Original Name: ObservesEmergencyStop</remarks>
			public ObservesEmergencyStopProperty ObservesEmergencyStop { get; } = new ObservesEmergencyStopProperty();
			public sealed class ObservesEmergencyStopProperty : IProperty
			{
				/// <summary>
				/// <inheritdoc />
				/// <remarks>
				/// <list type="bullet">
				/// <item>Original Type: _19_0_3_45f01b9_1580378218286_842979_1773</item>
				/// <item>Type: EmergencyStopClass</item>
				/// <item>Namespace: Mtconnect.ObservationInformationModel.ObservationTypes.EventTypes</item>
				/// </list>
				/// </remarks>
				/// </summary>
				public System.Type Type => typeof(Mtconnect.ObservationInformationModel.ObservationTypes.EventTypes.EmergencyStopClass);
				
				/// <inheritdoc />
				public string Name => "ObservesEmergencyStop";
				
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
				public string Association => "";

				// Note: DefaultValue.Name
				/// <inheritdoc />
				public string DefaultValue => "";

				// TODO: Add Summary
			}
			/// <remarks>Original Name: ObservesSystemCondition</remarks>
			public ObservesSystemConditionProperty ObservesSystemCondition { get; } = new ObservesSystemConditionProperty();
			public sealed class ObservesSystemConditionProperty : IProperty
			{
				/// <summary>
				/// <inheritdoc />
				/// <remarks>
				/// <list type="bullet">
				/// <item>Original Type: _19_0_3_68e0225_1598552920231_95319_608</item>
				/// <item>Type: SystemClass</item>
				/// <item>Namespace: Mtconnect.ObservationInformationModel.ObservationTypes.ConditionTypes</item>
				/// </list>
				/// </remarks>
				/// </summary>
				public System.Type Type => typeof(Mtconnect.ObservationInformationModel.ObservationTypes.ConditionTypes.SystemClass);
				
				/// <inheritdoc />
				public string Name => "ObservesSystemCondition";
				
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
				public string Association => "";

				// Note: DefaultValue.Name
				/// <inheritdoc />
				public string DefaultValue => "";

				// TODO: Add Summary
			}
			/// <remarks>Original Name: ObservesControllerMode</remarks>
			public ObservesControllerModeProperty ObservesControllerMode { get; } = new ObservesControllerModeProperty();
			public sealed class ObservesControllerModeProperty : IProperty
			{
				/// <summary>
				/// <inheritdoc />
				/// <remarks>
				/// <list type="bullet">
				/// <item>Original Type: _19_0_3_45f01b9_1580378218235_737319_1656</item>
				/// <item>Type: ControllerModeClass</item>
				/// <item>Namespace: Mtconnect.ObservationInformationModel.ObservationTypes.EventTypes</item>
				/// </list>
				/// </remarks>
				/// </summary>
				public System.Type Type => typeof(Mtconnect.ObservationInformationModel.ObservationTypes.EventTypes.ControllerModeClass);
				
				/// <inheritdoc />
				public string Name => "ObservesControllerMode";
				
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
				public string Association => "";

				// Note: DefaultValue.Name
				/// <inheritdoc />
				public string DefaultValue => "";

				// TODO: Add Summary
			}
			/// <remarks>Original Name: ObservesCommunicationsCondition</remarks>
			public ObservesCommunicationsConditionProperty ObservesCommunicationsCondition { get; } = new ObservesCommunicationsConditionProperty();
			public sealed class ObservesCommunicationsConditionProperty : IProperty
			{
				/// <summary>
				/// <inheritdoc />
				/// <remarks>
				/// <list type="bullet">
				/// <item>Original Type: _19_0_3_68e0225_1598552901976_410405_544</item>
				/// <item>Type: CommunicationsClass</item>
				/// <item>Namespace: Mtconnect.ObservationInformationModel.ObservationTypes.ConditionTypes</item>
				/// </list>
				/// </remarks>
				/// </summary>
				public System.Type Type => typeof(Mtconnect.ObservationInformationModel.ObservationTypes.ConditionTypes.CommunicationsClass);
				
				/// <inheritdoc />
				public string Name => "ObservesCommunicationsCondition";
				
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
				public string Association => "";

				// Note: DefaultValue.Name
				/// <inheritdoc />
				public string DefaultValue => "";

				// TODO: Add Summary
			}
			/// <remarks>Original Name: ObservesLogicProgramCondition</remarks>
			public ObservesLogicProgramConditionProperty ObservesLogicProgramCondition { get; } = new ObservesLogicProgramConditionProperty();
			public sealed class ObservesLogicProgramConditionProperty : IProperty
			{
				/// <summary>
				/// <inheritdoc />
				/// <remarks>
				/// <list type="bullet">
				/// <item>Original Type: _19_0_3_68e0225_1598552904415_200781_584</item>
				/// <item>Type: LogicProgramClass</item>
				/// <item>Namespace: Mtconnect.ObservationInformationModel.ObservationTypes.ConditionTypes</item>
				/// </list>
				/// </remarks>
				/// </summary>
				public System.Type Type => typeof(Mtconnect.ObservationInformationModel.ObservationTypes.ConditionTypes.LogicProgramClass);
				
				/// <inheritdoc />
				public string Name => "ObservesLogicProgramCondition";
				
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
				public string Association => "";

				// Note: DefaultValue.Name
				/// <inheritdoc />
				public string DefaultValue => "";

				// TODO: Add Summary
			}
		};

	}
}