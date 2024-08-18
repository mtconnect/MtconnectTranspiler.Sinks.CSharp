#pragma warning disable CS0109 // Member does not hide an inherited member; new keyword is not required
#pragma warning disable CS1574 // XML comment has cref attribute that could not be resolved
#pragma warning disable CS1584 // XML comment has syntactically incorrect cref attribute
using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;
using System.Linq;

namespace Mtconnect.DeviceInformationModel.Components.ComponentTypes
{
	/// <summary>﻿<see cref="System">System</see> that provides regulation or management of a system or component. <seealso href="https://www.google.com/search?q=ISO 16484-5:2017&btnI=I">ISO 16484-5:2017</seealso><br /><br /><br />Description<br /><br />Typical types of controllers for a piece of equipment include CNC (Computer Numerical Control), PAC (Programmable Automation Control), IPC (Industrialized Computer), or IC (Imbedded Computer).<br /><br />&gt; Note: In <i>XML</i> representation, <see cref="Controller">Controller</see> is a <i>top level</i> element.<br /><br /><br /><br /><br />
	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Structure___19_0_3_45f01b9_1579572381977_283525_42216">model.mtconnect.org</seealso> for more information.
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public sealed class ControllerClass : IClass
	{
		/// <inheritdoc />
		public string ReferenceId => "_19_0_3_45f01b9_1579572381977_283525_42216";
		
		/// <inheritdoc />
		public string Summary => @"&#10;&#10;&#10;{{block(System)}} that provides regulation or management of a system or component. {{cite(ISO 16484-5:2017)}}&#10;
&#10;&#10;&#10;Description&#10;&#10;&#10;&#10;Typical types of controllers for a piece of equipment include CNC (Computer Numerical Control), PAC (Programmable Automation Control), IPC (Industrialized Computer), or IC (Imbedded Computer).

> Note: In {{term(XML)}} representation, {{block(Controller)}} is a {{term(top level)}} element.&#10;
";

		/// <inheritdoc />
		public string Name => "Controller";
		
		/// <inheritdoc />
		public string AccessModifier => "public";
				
		/// <inheritdoc />
		public string Modifier => "";
				
		/// <inheritdoc />
		public string NormativeVersion => "1.0";
				
		/// <inheritdoc />
		public string DeprecatedVersion => "";
		
		/// <inheritdoc />
		/// <remarks>
		/// Original Type: _19_0_3_45f01b9_1579572382020_336298_42297
		/// </remarks>
		public Type Generalization => typeof(Mtconnect.DeviceInformationModel.Components.ComponentTypes.SystemClass);

		/// <inheritdoc />
		public new ControllerClassProperties Properties { get; } = new ControllerClassProperties();
        IPropertyList IClass.Properties => Properties;
		/// <summary>
		/// Property list for <see cref="ControllerClass" />.
		/// <br/><b>Note</b>, some properties (<see cref="IProperty" />) are inherited from <see cref="Mtconnect.DeviceInformationModel.Components.ComponentTypes.SystemClass.SystemClassProperties" />.
		/// </summary>
		public class ControllerClassProperties : Mtconnect.DeviceInformationModel.Components.ComponentTypes.SystemClass.SystemClassProperties
		{
			/// <inheritdoc />
			public new IProperty[] Properties => new IProperty[] {
				HasPathPart,
				IsControllerOfPart,
				ObservesEmergencyStop,
				ObservesSystemCondition,
				ObservesControllerMode,
				ObservesCommunicationsCondition,
				ObservesLogicProgramCondition,
			}.Concat(base.Properties).ToArray();
			/// <summary>
			/// <inheritdoc cref="HasPathPartProperty" path="/summary" /><br/>
			/// <remarks>Original Name: HasPath</remarks>
			/// </summary>
			public new HasPathPartProperty HasPathPart { get; } = new HasPathPartProperty();
			
			/// <summary>﻿
			/// </summary>
			public new sealed class HasPathPartProperty : IProperty
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
				public string Name => "hasPath";
				
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
			public new IsControllerOfPartProperty IsControllerOfPart { get; } = new IsControllerOfPartProperty();
			
			/// <summary>﻿
			/// </summary>
			public new sealed class IsControllerOfPartProperty : IProperty
			{
				/// <summary>
				/// <inheritdoc />
				/// <remarks>
				/// <list type="bullet">
				/// <item>Original Type: _19_0_3_68e0225_1620240839406_285612_1596</item>
				/// <item>Type: DeviceClass</item>
				/// <item>Namespace: Mtconnect.DeviceInformationModel</item>
				/// </list>
				/// </remarks>
				/// </summary>
				public System.Type Type => typeof(Mtconnect.DeviceInformationModel.DeviceClass);
				
				/// <inheritdoc />
				public string Name => "isControllerOf";
				
				/// <inheritdoc />
				public string Summary => @"";

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
			public new ObservesEmergencyStopProperty ObservesEmergencyStop { get; } = new ObservesEmergencyStopProperty();
			
			/// <summary>﻿
			/// </summary>
			public new sealed class ObservesEmergencyStopProperty : IProperty
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
				public string Name => "observesEmergencyStop";
				
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
				public string Association => "";

				// Note: DefaultValue.Name
				/// <inheritdoc />
				public string DefaultValue => "";
			}
			/// <summary>
			/// <inheritdoc cref="ObservesSystemConditionProperty" path="/summary" /><br/>
			/// <remarks>Original Name: ObservesSystemCondition</remarks>
			/// </summary>
			public new ObservesSystemConditionProperty ObservesSystemCondition { get; } = new ObservesSystemConditionProperty();
			
			/// <summary>﻿
			/// </summary>
			public new sealed class ObservesSystemConditionProperty : IProperty
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
				public string Name => "observesSystemCondition";
				
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
				public string Association => "";

				// Note: DefaultValue.Name
				/// <inheritdoc />
				public string DefaultValue => "";
			}
			/// <summary>
			/// <inheritdoc cref="ObservesControllerModeProperty" path="/summary" /><br/>
			/// <remarks>Original Name: ObservesControllerMode</remarks>
			/// </summary>
			public new ObservesControllerModeProperty ObservesControllerMode { get; } = new ObservesControllerModeProperty();
			
			/// <summary>﻿
			/// </summary>
			public new sealed class ObservesControllerModeProperty : IProperty
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
				public string Name => "observesControllerMode";
				
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
				public string Association => "";

				// Note: DefaultValue.Name
				/// <inheritdoc />
				public string DefaultValue => "";
			}
			/// <summary>
			/// <inheritdoc cref="ObservesCommunicationsConditionProperty" path="/summary" /><br/>
			/// <remarks>Original Name: ObservesCommunicationsCondition</remarks>
			/// </summary>
			public new ObservesCommunicationsConditionProperty ObservesCommunicationsCondition { get; } = new ObservesCommunicationsConditionProperty();
			
			/// <summary>﻿
			/// </summary>
			public new sealed class ObservesCommunicationsConditionProperty : IProperty
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
				public string Name => "observesCommunicationsCondition";
				
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
				public string Association => "";

				// Note: DefaultValue.Name
				/// <inheritdoc />
				public string DefaultValue => "";
			}
			/// <summary>
			/// <inheritdoc cref="ObservesLogicProgramConditionProperty" path="/summary" /><br/>
			/// <remarks>Original Name: ObservesLogicProgramCondition</remarks>
			/// </summary>
			public new ObservesLogicProgramConditionProperty ObservesLogicProgramCondition { get; } = new ObservesLogicProgramConditionProperty();
			
			/// <summary>﻿
			/// </summary>
			public new sealed class ObservesLogicProgramConditionProperty : IProperty
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
				public string Name => "observesLogicProgramCondition";
				
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
				public string Association => "";

				// Note: DefaultValue.Name
				/// <inheritdoc />
				public string DefaultValue => "";
			}
		};

	}
}