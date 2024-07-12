
using System;
using System.CodeDom.Compiler;

using Mtconnect.DeviceInformationModel.Components.ComponentTypes;
using Mtconnect.Glossary.MTConnectTerms;
using Mtconnect.ObservationInformationModel.ObservationTypes.EventTypes;
using Mtconnect.ObservationInformationModel.ObservationTypes.ConditionTypes;

namespace Mtconnect.DeviceInformationModel.Components.ComponentTypes
{
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "1.0.15.3")]
	public sealed class ControllerClass
	{
		/// <inheritdoc cref="Class.ReferenceId" />
		public string ReferenceId => "_19_0_3_45f01b9_1579572381977_283525_42216";
		
		/// <inheritdoc cref="Class.Name" />
		public string Name => "Controller";
		
		/// <inheritdoc cref="Class.AccessModifier" />
		public string AccessModifier => "public";
				
		/// <inheritdoc cref="Class.Modifier" />
		public string Modifier => "";
				
		/// <inheritdoc cref="Class.NormativeVersion" />
		public string NormativeVersion => "MtconnectVersions.V_1_0_1";
				
		/// <inheritdoc cref="Class.DeprecatedVersion" />
		public string DeprecatedVersion => "";

		public string Generalization => "";

		public ControllerProperties Properties { get; } = new ControllerProperties();
		public sealed class ControllerProperties
		{
		
		
			/// <remarks>Original Name: HasPath</remarks>
			public HasPathPartProperty HasPathPart { get; } = new HasPathPartProperty();
			public sealed class HasPathPartProperty
			{
				/// <inheritdoc cref="Property.Type" />
				/// Original Type: _19_0_3_45f01b9_1579572382004_482583_42267
				public Type Type => typeof(PathClass);
				
				/// <inheritdoc cref="Property.Name" />
				public string Name => "HasPath";
				
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

				public string Association => "Path";

				// Note: DefaultValue.Name
				public string DefaultValue => "";

				// TODO: Add Summary
			}
		
		
			/// <remarks>Original Name: IsControllerOf</remarks>
			public IsControllerOfPartProperty IsControllerOfPart { get; } = new IsControllerOfPartProperty();
			public sealed class IsControllerOfPartProperty
			{
				/// <inheritdoc cref="Property.Type" />
				/// Original Type: _19_0_3_68e0225_1620240839406_285612_1596
				public Type Type => typeof(DeviceClass);
				
				/// <inheritdoc cref="Property.Name" />
				public string Name => "IsControllerOf";
				
				/// <inheritdoc cref="Property.AccessModifier" />
				public string AccessModifier => "private";
				
				/// <inheritdoc cref="Property.Modifier" />
				public string Modifier => "";
				
				/// <inheritdoc cref="Property.NormativeVersion" />
				public string NormativeVersion => "";
				
				/// <inheritdoc cref="Property.DeprecatedVersion" />
				public string DeprecatedVersion => "";
				
				public string Aggregation => "";

				// Note: Extension.Extender
				public string Extension => "MagicDraw UML 19.0";

				public string Association => "ControllersClass";

				// Note: DefaultValue.Name
				public string DefaultValue => "";

				// TODO: Add Summary
			}
		
		
			/// <remarks>Original Name: ObservesEmergencyStop</remarks>
			public ObservesEmergencyStopProperty ObservesEmergencyStop { get; } = new ObservesEmergencyStopProperty();
			public sealed class ObservesEmergencyStopProperty
			{
				/// <inheritdoc cref="Property.Type" />
				/// Original Type: _19_0_3_45f01b9_1580378218286_842979_1773
				public Type Type => typeof(EmergencyStopClass);
				
				/// <inheritdoc cref="Property.Name" />
				public string Name => "ObservesEmergencyStop";
				
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

				public string Association => "";

				// Note: DefaultValue.Name
				public string DefaultValue => "";

				// TODO: Add Summary
			}
		
		
			/// <remarks>Original Name: ObservesSystemCondition</remarks>
			public ObservesSystemConditionProperty ObservesSystemCondition { get; } = new ObservesSystemConditionProperty();
			public sealed class ObservesSystemConditionProperty
			{
				/// <inheritdoc cref="Property.Type" />
				/// Original Type: _19_0_3_68e0225_1598552920231_95319_608
				public Type Type => typeof(SystemClass);
				
				/// <inheritdoc cref="Property.Name" />
				public string Name => "ObservesSystemCondition";
				
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

				public string Association => "";

				// Note: DefaultValue.Name
				public string DefaultValue => "";

				// TODO: Add Summary
			}
		
		
			/// <remarks>Original Name: ObservesControllerMode</remarks>
			public ObservesControllerModeProperty ObservesControllerMode { get; } = new ObservesControllerModeProperty();
			public sealed class ObservesControllerModeProperty
			{
				/// <inheritdoc cref="Property.Type" />
				/// Original Type: _19_0_3_45f01b9_1580378218235_737319_1656
				public Type Type => typeof(ControllerModeClass);
				
				/// <inheritdoc cref="Property.Name" />
				public string Name => "ObservesControllerMode";
				
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

				public string Association => "";

				// Note: DefaultValue.Name
				public string DefaultValue => "";

				// TODO: Add Summary
			}
		
		
			/// <remarks>Original Name: ObservesCommunicationsCondition</remarks>
			public ObservesCommunicationsConditionProperty ObservesCommunicationsCondition { get; } = new ObservesCommunicationsConditionProperty();
			public sealed class ObservesCommunicationsConditionProperty
			{
				/// <inheritdoc cref="Property.Type" />
				/// Original Type: _19_0_3_68e0225_1598552901976_410405_544
				public Type Type => typeof(CommunicationsClass);
				
				/// <inheritdoc cref="Property.Name" />
				public string Name => "ObservesCommunicationsCondition";
				
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

				public string Association => "";

				// Note: DefaultValue.Name
				public string DefaultValue => "";

				// TODO: Add Summary
			}
		
		
			/// <remarks>Original Name: ObservesLogicProgramCondition</remarks>
			public ObservesLogicProgramConditionProperty ObservesLogicProgramCondition { get; } = new ObservesLogicProgramConditionProperty();
			public sealed class ObservesLogicProgramConditionProperty
			{
				/// <inheritdoc cref="Property.Type" />
				/// Original Type: _19_0_3_68e0225_1598552904415_200781_584
				public Type Type => typeof(LogicProgramClass);
				
				/// <inheritdoc cref="Property.Name" />
				public string Name => "ObservesLogicProgramCondition";
				
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

				public string Association => "";

				// Note: DefaultValue.Name
				public string DefaultValue => "";

				// TODO: Add Summary
			}
		};

	}
}