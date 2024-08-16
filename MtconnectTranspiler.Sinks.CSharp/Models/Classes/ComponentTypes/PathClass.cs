using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;
using System.Linq;

namespace Mtconnect.DeviceInformationModel.Components.ComponentTypes
{
	/// <summary>
	﻿/// <see cref="Component">Component</see> that organizes an independent operation or function within a <see cref="Controller">Controller</see>.<br/><br />Description<br/>For many types of equipment, <see cref="Path">Path</see> organizes a set of <see cref="Axes">Axes</see>, one or more Program elements, and the data associated with the motion of a control point as it moves through space. However, it <b>MAY</b> also represent any independent function within a <see cref="Controller">Controller</see> that has unique data associated with that function.<br /> <br /><see cref="Path">Path</see> <b>SHOULD</b> provide an <see cref="Execution">Execution</see> data item to define the operational state of the <see cref="Controller">Controller</see> of the piece of equipment.<br /><br />If the <see cref="Controller">Controller</see> is capable of performing more than one independent operation or function simultaneously, a separate <see cref="Path">Path</see> <b>MUST</b> be used to organize the data associated with each independent operation or function.<br/><br/><br />

	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Structure___19_0_3_45f01b9_1579572382004_482583_42267">model.mtconnect.org</seealso> for more information.
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public sealed class PathClass : IClass
	{
		/// <inheritdoc />
		public string ReferenceId => "_19_0_3_45f01b9_1579572382004_482583_42267";
		
		/// <inheritdoc />
		public string Summary => @"&#10;&#10;&#10;{{block(Component)}} that organizes an independent operation or function within a {{block(Controller)}}.&#10;
&#10;&#10;&#10;Description&#10;&#10;&#10;&#10;For many types of equipment, {{block(Path)}} organizes a set of {{block(Axes)}}, one or more Program elements, and the data associated with the motion of a control point as it moves through space. However, it **MAY** also represent any independent function within a {{block(Controller)}} that has unique data associated with that function.
 
{{block(Path)}} **SHOULD** provide an {{block(Execution)}} data item to define the operational state of the {{block(Controller)}} of the piece of equipment.

If the {{block(Controller)}} is capable of performing more than one independent operation or function simultaneously, a separate {{block(Path)}} **MUST** be used to organize the data associated with each independent operation or function.&#10;
";

		/// <inheritdoc />
		public string Name => "Path";
		
		/// <inheritdoc />
		public string AccessModifier => "public";
				
		/// <inheritdoc />
		public string Modifier => "";
				
		/// <inheritdoc />
		public string NormativeVersion => "1.1";
				
		/// <inheritdoc />
		public string DeprecatedVersion => "";
		
		/// <inheritdoc />
		/// <remarks>
		/// Original Type: EAID_8548C620_467A_4f50_9A22_58D84B7E8779
		/// </remarks>
		public Type Generalization => typeof(Mtconnect.DeviceInformationModel.Components.ComponentGeneralization);

		/// <inheritdoc />
		public PathClassProperties Properties { get; } = new PathClassProperties();
        IPropertyList IClass.Properties => Properties;
		public class PathClassProperties : Mtconnect.DeviceInformationModel.Components.ComponentGeneralization.ComponentGeneralizationProperties
		{
			/// <inheritdoc />
			public IProperty[] Properties => new IProperty[] {
				ObservesExecution,
				ObservesProgram,
				ObservesPathFeedrateOverrideProgrammed,
				ObservesPathFeedrateOverrideRapid,
				ObservesRotaryVelocityOverride,
				ObservesPathFeedrate,
				ObservesPartCount,
			}.Concat(base.Properties).ToArray();
			/// <summary>
			/// <inheritdoc cref="ObservesExecutionProperty" path="/summary" /><br/>
			/// <remarks>Original Name: ObservesExecution</remarks>
			/// </summary>
			public ObservesExecutionProperty ObservesExecution { get; } = new ObservesExecutionProperty();
			public sealed class ObservesExecutionProperty : IProperty
			{
				/// <summary>
				/// <inheritdoc />
				/// <remarks>
				/// <list type="bullet">
				/// <item>Original Type: _19_0_3_45f01b9_1580378218306_196644_1821</item>
				/// <item>Type: ExecutionClass</item>
				/// <item>Namespace: Mtconnect.ObservationInformationModel.ObservationTypes.EventTypes</item>
				/// </list>
				/// </remarks>
				/// </summary>
				public System.Type Type => typeof(Mtconnect.ObservationInformationModel.ObservationTypes.EventTypes.ExecutionClass);
				
				/// <inheritdoc />
				public string Name => "observesExecution";
				
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
			/// <inheritdoc cref="ObservesProgramProperty" path="/summary" /><br/>
			/// <remarks>Original Name: ObservesProgram</remarks>
			/// </summary>
			public ObservesProgramProperty ObservesProgram { get; } = new ObservesProgramProperty();
			public sealed class ObservesProgramProperty : IProperty
			{
				/// <summary>
				/// <inheritdoc />
				/// <remarks>
				/// <list type="bullet">
				/// <item>Original Type: _19_0_3_45f01b9_1580378218420_715490_2100</item>
				/// <item>Type: ProgramClass</item>
				/// <item>Namespace: Mtconnect.ObservationInformationModel.ObservationTypes.EventTypes</item>
				/// </list>
				/// </remarks>
				/// </summary>
				public System.Type Type => typeof(Mtconnect.ObservationInformationModel.ObservationTypes.EventTypes.ProgramClass);
				
				/// <inheritdoc />
				public string Name => "observesProgram";
				
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
			/// <inheritdoc cref="ObservesPathFeedrateOverrideProgrammedProperty" path="/summary" /><br/>
			/// <remarks>Original Name: ObservesPathFeedrateOverrideProgrammed</remarks>
			/// </summary>
			public ObservesPathFeedrateOverrideProgrammedProperty ObservesPathFeedrateOverrideProgrammed { get; } = new ObservesPathFeedrateOverrideProgrammedProperty();
			public sealed class ObservesPathFeedrateOverrideProgrammedProperty : IProperty
			{
				/// <summary>
				/// <inheritdoc />
				/// <remarks>
				/// <list type="bullet">
				/// <item>Original Type: _19_0_3_45f01b9_1580378218383_276168_2007</item>
				/// <item>Type: PathFeedrateOverride.ProgrammedClass</item>
				/// <item>Namespace: Mtconnect.ObservationInformationModel.ObservationTypes.EventTypes</item>
				/// </list>
				/// </remarks>
				/// </summary>
				public System.Type Type => typeof(Mtconnect.ObservationInformationModel.ObservationTypes.EventTypes.PathFeedrateOverrideProgrammedClass);
				
				/// <inheritdoc />
				public string Name => "observesPathFeedrateOverrideProgrammed";
				
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
			/// <inheritdoc cref="ObservesPathFeedrateOverrideRapidProperty" path="/summary" /><br/>
			/// <remarks>Original Name: ObservesPathFeedrateOverrideRapid</remarks>
			/// </summary>
			public ObservesPathFeedrateOverrideRapidProperty ObservesPathFeedrateOverrideRapid { get; } = new ObservesPathFeedrateOverrideRapidProperty();
			public sealed class ObservesPathFeedrateOverrideRapidProperty : IProperty
			{
				/// <summary>
				/// <inheritdoc />
				/// <remarks>
				/// <list type="bullet">
				/// <item>Original Type: _19_0_3_45f01b9_1580378218384_46527_2010</item>
				/// <item>Type: PathFeedrateOverride.RapidClass</item>
				/// <item>Namespace: Mtconnect.ObservationInformationModel.ObservationTypes.EventTypes</item>
				/// </list>
				/// </remarks>
				/// </summary>
				public System.Type Type => typeof(Mtconnect.ObservationInformationModel.ObservationTypes.EventTypes.PathFeedrateOverrideRapidClass);
				
				/// <inheritdoc />
				public string Name => "observesPathFeedrateOverrideRapid";
				
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
			/// <inheritdoc cref="ObservesRotaryVelocityOverrideProperty" path="/summary" /><br/>
			/// <remarks>Original Name: ObservesRotaryVelocityOverride</remarks>
			/// </summary>
			public ObservesRotaryVelocityOverrideProperty ObservesRotaryVelocityOverride { get; } = new ObservesRotaryVelocityOverrideProperty();
			public sealed class ObservesRotaryVelocityOverrideProperty : IProperty
			{
				/// <summary>
				/// <inheritdoc />
				/// <remarks>
				/// <list type="bullet">
				/// <item>Original Type: _19_0_3_45f01b9_1580378218440_585732_2163</item>
				/// <item>Type: RotaryVelocityOverrideClass</item>
				/// <item>Namespace: Mtconnect.ObservationInformationModel.ObservationTypes.EventTypes</item>
				/// </list>
				/// </remarks>
				/// </summary>
				public System.Type Type => typeof(Mtconnect.ObservationInformationModel.ObservationTypes.EventTypes.RotaryVelocityOverrideClass);
				
				/// <inheritdoc />
				public string Name => "observesRotaryVelocityOverride";
				
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
			/// <inheritdoc cref="ObservesPathFeedrateProperty" path="/summary" /><br/>
			/// <remarks>Original Name: ObservesPathFeedrate</remarks>
			/// </summary>
			public ObservesPathFeedrateProperty ObservesPathFeedrate { get; } = new ObservesPathFeedrateProperty();
			public sealed class ObservesPathFeedrateProperty : IProperty
			{
				/// <summary>
				/// <inheritdoc />
				/// <remarks>
				/// <list type="bullet">
				/// <item>Original Type: _19_0_3_45f01b9_1580378218374_970818_1980</item>
				/// <item>Type: PathFeedrateClass</item>
				/// <item>Namespace: Mtconnect.ObservationInformationModel.ObservationTypes.SampleTypes</item>
				/// </list>
				/// </remarks>
				/// </summary>
				public System.Type Type => typeof(Mtconnect.ObservationInformationModel.ObservationTypes.SampleTypes.PathFeedrateClass);
				
				/// <inheritdoc />
				public string Name => "observesPathFeedrate";
				
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
			/// <inheritdoc cref="ObservesPartCountProperty" path="/summary" /><br/>
			/// <remarks>Original Name: ObservesPartCount</remarks>
			/// </summary>
			public ObservesPartCountProperty ObservesPartCount { get; } = new ObservesPartCountProperty();
			public sealed class ObservesPartCountProperty : IProperty
			{
				/// <summary>
				/// <inheritdoc />
				/// <remarks>
				/// <list type="bullet">
				/// <item>Original Type: _19_0_3_45f01b9_1580378218363_437912_1953</item>
				/// <item>Type: PartCountClass</item>
				/// <item>Namespace: Mtconnect.ObservationInformationModel.ObservationTypes.EventTypes</item>
				/// </list>
				/// </remarks>
				/// </summary>
				public System.Type Type => typeof(Mtconnect.ObservationInformationModel.ObservationTypes.EventTypes.PartCountClass);
				
				/// <inheritdoc />
				public string Name => "observesPartCount";
				
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