using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;
// using Mtconnect.DeviceInformationModel.Components.ComponentTypes;
// using Mtconnect.Glossary.MTConnectTerms;
// using Mtconnect.ObservationInformationModel.ObservationTypes.EventTypes;
// using Mtconnect.ObservationInformationModel.ObservationTypes.ConditionTypes;

namespace Mtconnect.DeviceInformationModel.Components.ComponentTypes
{
	/// <summary>
	/// <see cref="System">System</see> that provides regulation or management of a system or component. <seealso href="https://www.google.com/search?q=ISO 16484-5:2017&btnI=I">ISO 16484-5:2017</seealso>/// Description
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.3.0.0")]
	public sealed class ControllerClass : IClass
	{
		/// <inheritdoc />
		public string ReferenceId => "_19_0_3_45f01b9_1579572381977_283525_42216";
		
		/// <inheritdoc />
		public string Summary => @"/// <see cref=""System"">System</see> that provides regulation or management of a system or component. <seealso href=""https://www.google.com/search?q=ISO 16484-5:2017&btnI=I"">ISO 16484-5:2017</seealso>/// Description";

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
			/// <summary>
			/// <inheritdoc cref="HasPathPartProperty" path="/summary" /><br/>
			/// <remarks>Original Name: HasPath</remarks>
			/// </summary>
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
				public string Summary => @"/// <see cref=""System"">System</see> that provides regulation or management of a system or component. <seealso href=""https://www.google.com/search?q=ISO 16484-5:2017&btnI=I"">ISO 16484-5:2017</seealso>/// Description";

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
			}
			/// <summary>
			/// <inheritdoc cref="IsControllerOfPartProperty" path="/summary" /><br/>
			/// <remarks>Original Name: IsControllerOf</remarks>
			/// </summary>
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
				public string Summary => @"/// <see cref=""System"">System</see> that provides regulation or management of a system or component. <seealso href=""https://www.google.com/search?q=ISO 16484-5:2017&btnI=I"">ISO 16484-5:2017</seealso>/// Description";

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
			}
			/// <summary>
			/// <inheritdoc cref="ObservesEmergencyStopProperty" path="/summary" /><br/>
			/// <remarks>Original Name: ObservesEmergencyStop</remarks>
			/// </summary>
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
				public string Summary => @"/// <see cref=""System"">System</see> that provides regulation or management of a system or component. <seealso href=""https://www.google.com/search?q=ISO 16484-5:2017&btnI=I"">ISO 16484-5:2017</seealso>/// Description";

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
			}
			/// <summary>
			/// <inheritdoc cref="ObservesSystemConditionProperty" path="/summary" /><br/>
			/// <remarks>Original Name: ObservesSystemCondition</remarks>
			/// </summary>
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
				public string Summary => @"/// <see cref=""System"">System</see> that provides regulation or management of a system or component. <seealso href=""https://www.google.com/search?q=ISO 16484-5:2017&btnI=I"">ISO 16484-5:2017</seealso>/// Description";

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
			}
			/// <summary>
			/// <inheritdoc cref="ObservesControllerModeProperty" path="/summary" /><br/>
			/// <remarks>Original Name: ObservesControllerMode</remarks>
			/// </summary>
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
				public string Summary => @"/// <see cref=""System"">System</see> that provides regulation or management of a system or component. <seealso href=""https://www.google.com/search?q=ISO 16484-5:2017&btnI=I"">ISO 16484-5:2017</seealso>/// Description";

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
			}
			/// <summary>
			/// <inheritdoc cref="ObservesCommunicationsConditionProperty" path="/summary" /><br/>
			/// <remarks>Original Name: ObservesCommunicationsCondition</remarks>
			/// </summary>
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
				public string Summary => @"/// <see cref=""System"">System</see> that provides regulation or management of a system or component. <seealso href=""https://www.google.com/search?q=ISO 16484-5:2017&btnI=I"">ISO 16484-5:2017</seealso>/// Description";

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
			}
			/// <summary>
			/// <inheritdoc cref="ObservesLogicProgramConditionProperty" path="/summary" /><br/>
			/// <remarks>Original Name: ObservesLogicProgramCondition</remarks>
			/// </summary>
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
				public string Summary => @"/// <see cref=""System"">System</see> that provides regulation or management of a system or component. <seealso href=""https://www.google.com/search?q=ISO 16484-5:2017&btnI=I"">ISO 16484-5:2017</seealso>/// Description";

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
			}
		};

	}
}