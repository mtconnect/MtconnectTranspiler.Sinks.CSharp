#pragma warning disable CS0109 // Member does not hide an inherited member; new keyword is not required
#pragma warning disable CS1574 // XML comment has cref attribute that could not be resolved
#pragma warning disable CS1584 // XML comment has syntactically incorrect cref attribute
#pragma warning disable CS0618 // Type or member is obsolete
using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;
using System.Linq;

namespace Mtconnect.DeviceInformationModel.Components.ComponentTypes
{
	/// <summary>﻿<see cref="Component">Component</see> that organizes an independent operation or function within a <see cref="Controller">Controller</see>.<br /><br /><br />Description<br /><br />For many types of equipment, <see cref="Path">Path</see> organizes a set of <see cref="Axes">Axes</see>, one or more Program elements, and the data associated with the motion of a control point as it moves through space. However, it <b>MAY</b> also represent any independent function within a <see cref="Controller">Controller</see> that has unique data associated with that function.<br /> <br /><see cref="Path">Path</see> <b>SHOULD</b> provide an <see cref="Execution">Execution</see> data item to define the operational state of the <see cref="Controller">Controller</see> of the piece of equipment.<br /><br />If the <see cref="Controller">Controller</see> is capable of performing more than one independent operation or function simultaneously, a separate <see cref="Path">Path</see> <b>MUST</b> be used to organize the data associated with each independent operation or function.<br /><br /><br /><br /><br />
	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Structure___19_0_3_45f01b9_1579572382004_482583_42267">model.mtconnect.org</seealso> for more information.
	/// </summary>
	/// <remarks>
	/// <list type="bullet">
	/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.1">v1.1</see></item>
	/// </list>
	/// </remarks>

	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public sealed class PathClass : IClass
	{
		/// <summary>Constant value for <see cref="PathClass.ReferenceId" /></summary>
		public const string REFERENCE_ID = "_19_0_3_45f01b9_1579572382004_482583_42267";
		/// <summary>Constant value for <see cref="PathClass.HelpUrl" /></summary>
		public const string HELP_URL = "https://model.mtconnect.org/#Structure___19_0_3_45f01b9_1579572382004_482583_42267";
		/// <summary>Constant value for <see cref="PathClass.Summary" /></summary>
		public const string SUMMARY = @"&#10;&#10;&#10;{{block(Component)}} that organizes an independent operation or function within a {{block(Controller)}}.&#10;
&#10;&#10;&#10;Description&#10;&#10;&#10;&#10;For many types of equipment, {{block(Path)}} organizes a set of {{block(Axes)}}, one or more Program elements, and the data associated with the motion of a control point as it moves through space. However, it **MAY** also represent any independent function within a {{block(Controller)}} that has unique data associated with that function.
 
{{block(Path)}} **SHOULD** provide an {{block(Execution)}} data item to define the operational state of the {{block(Controller)}} of the piece of equipment.

If the {{block(Controller)}} is capable of performing more than one independent operation or function simultaneously, a separate {{block(Path)}} **MUST** be used to organize the data associated with each independent operation or function.&#10;
";
		/// <summary>Constant value for <see cref="PathClass.Name" /></summary>
		public const string NAME = "Path";
		/// <summary>Constant value for <see cref="PathClass.AccessModifier" /></summary>
		public const string ACCESS_MODIFIER = "public";
		/// <summary>Constant value for <see cref="PathClass.Modifier" /></summary>
		public const string MODIFIER = "";
		/// <summary>Constant value for <see cref="PathClass.NormativeVersion" /></summary>
		public const string NORMATIVE_VERSION = "1.1";
		/// <summary>Constant value for <see cref="PathClass.DeprecatedVersion" /></summary>
		public const string DEPRECATED_VERSION = "";

		/// <inheritdoc />
		public string ReferenceId => REFERENCE_ID;
		
		/// <inheritdoc />
		public string HelpUrl => HELP_URL;

		/// <inheritdoc />
		public string Summary => SUMMARY;

		/// <inheritdoc />
		public string Name => NAME;
		
		/// <inheritdoc />
		public string AccessModifier => ACCESS_MODIFIER;
				
		/// <inheritdoc />
		public string Modifier => MODIFIER;
				
		/// <inheritdoc />
		public string NormativeVersion => NORMATIVE_VERSION;
				
		/// <inheritdoc />
		public string DeprecatedVersion => DEPRECATED_VERSION;
		
		/// <inheritdoc />
		/// <remarks>
		/// Original Type: EAID_8548C620_467A_4f50_9A22_58D84B7E8779
		/// </remarks>
		public Type Generalization => typeof(Mtconnect.DeviceInformationModel.Components.ComponentGeneralization);

		/// <inheritdoc />
		public new PathClassProperties Properties { get; } = new PathClassProperties();
        IPropertyList IClass.Properties => Properties;
		/// <summary>
		/// Property list for <see cref="PathClass" />.
		/// <br/><b>Note</b>, some properties (<see cref="IProperty" />) are inherited from <see cref="Mtconnect.DeviceInformationModel.Components.ComponentGeneralization.ComponentGeneralizationProperties" />.
		/// </summary>
		public class PathClassProperties : Mtconnect.DeviceInformationModel.Components.ComponentGeneralization.ComponentGeneralizationProperties
		{
			/// <inheritdoc />
			public override IProperty[] Properties => new IProperty[] {
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
			public new ObservesExecutionProperty ObservesExecution { get; } = new ObservesExecutionProperty();
			
			/// <summary>﻿
			/// </summary>
			public new sealed class ObservesExecutionProperty : IProperty
			{
				/// <summary>Constant value for <see cref="ObservesExecutionProperty.Name" /></summary>
				public const string NAME = "observesExecution";
				/// <summary>Constant value for <see cref="ObservesExecutionProperty.Summary" /></summary>
				public const string SUMMARY = @"";
				/// <summary>Constant value for <see cref="ObservesExecutionProperty.AccessModifier" /></summary>
				public const string ACCESS_MODIFIER = "public";
				/// <summary>Constant value for <see cref="ObservesExecutionProperty.Modifier" /></summary>
				public const string MODIFIER = "";
				/// <summary>Constant value for <see cref="ObservesExecutionProperty.NormativeVersion" /></summary>
				public const string NORMATIVE_VERSION = "";
				/// <summary>Constant value for <see cref="ObservesExecutionProperty.DeprecatedVersion" /></summary>
				public const string DEPRECATED_VERSION = "";
				/// <summary>Constant value for <see cref="ObservesExecutionProperty.Aggregation" /></summary>
				public const string AGGREGATION = "composite";
				/// <summary>Constant value for <see cref="ObservesExecutionProperty.Extension" /></summary>
				public const string EXTENSION = "MagicDraw UML 2024x";
				/// <summary>Constant value for <see cref="ObservesExecutionProperty.Association" /></summary>
				public const string ASSOCIATION = "";
				/// <summary>Constant value for <see cref="ObservesExecutionProperty.DefaultValue" /></summary>
				public const string DEFAULT_VALUE = "";

				/// <summary>
				/// <inheritdoc />
				/// <remarks> Type: ExecutionClass </remarks>
				/// </summary>
				public System.Type Type => typeof(Mtconnect.ObservationInformationModel.ObservationTypes.EventTypes.ExecutionClass);
				
				/// <inheritdoc />
				public string Name => NAME;
				
				/// <inheritdoc />
				public string Summary => SUMMARY;

				/// <inheritdoc />
				public string AccessModifier => ACCESS_MODIFIER;
				
				/// <inheritdoc />
				public string Modifier => MODIFIER;
				
				/// <inheritdoc />
				public string NormativeVersion => NORMATIVE_VERSION;
				
				/// <inheritdoc />
				public string DeprecatedVersion => DEPRECATED_VERSION;
				
				/// <inheritdoc />
				public string Aggregation => AGGREGATION;

				// Note: Extension.Extender
				/// <inheritdoc />
				public string Extension => EXTENSION;
				
				/// <inheritdoc />
				public string Association => ASSOCIATION;

				// Note: DefaultValue.Name
				/// <inheritdoc />
				public string DefaultValue => DEFAULT_VALUE;
			}
			/// <summary>
			/// <inheritdoc cref="ObservesProgramProperty" path="/summary" /><br/>
			/// <remarks>Original Name: ObservesProgram</remarks>
			/// </summary>
			public new ObservesProgramProperty ObservesProgram { get; } = new ObservesProgramProperty();
			
			/// <summary>﻿
			/// </summary>
			public new sealed class ObservesProgramProperty : IProperty
			{
				/// <summary>Constant value for <see cref="ObservesProgramProperty.Name" /></summary>
				public const string NAME = "observesProgram";
				/// <summary>Constant value for <see cref="ObservesProgramProperty.Summary" /></summary>
				public const string SUMMARY = @"";
				/// <summary>Constant value for <see cref="ObservesProgramProperty.AccessModifier" /></summary>
				public const string ACCESS_MODIFIER = "public";
				/// <summary>Constant value for <see cref="ObservesProgramProperty.Modifier" /></summary>
				public const string MODIFIER = "";
				/// <summary>Constant value for <see cref="ObservesProgramProperty.NormativeVersion" /></summary>
				public const string NORMATIVE_VERSION = "";
				/// <summary>Constant value for <see cref="ObservesProgramProperty.DeprecatedVersion" /></summary>
				public const string DEPRECATED_VERSION = "";
				/// <summary>Constant value for <see cref="ObservesProgramProperty.Aggregation" /></summary>
				public const string AGGREGATION = "composite";
				/// <summary>Constant value for <see cref="ObservesProgramProperty.Extension" /></summary>
				public const string EXTENSION = "MagicDraw UML 2024x";
				/// <summary>Constant value for <see cref="ObservesProgramProperty.Association" /></summary>
				public const string ASSOCIATION = "";
				/// <summary>Constant value for <see cref="ObservesProgramProperty.DefaultValue" /></summary>
				public const string DEFAULT_VALUE = "";

				/// <summary>
				/// <inheritdoc />
				/// <remarks> Type: ProgramClass </remarks>
				/// </summary>
				public System.Type Type => typeof(Mtconnect.ObservationInformationModel.ObservationTypes.EventTypes.ProgramClass);
				
				/// <inheritdoc />
				public string Name => NAME;
				
				/// <inheritdoc />
				public string Summary => SUMMARY;

				/// <inheritdoc />
				public string AccessModifier => ACCESS_MODIFIER;
				
				/// <inheritdoc />
				public string Modifier => MODIFIER;
				
				/// <inheritdoc />
				public string NormativeVersion => NORMATIVE_VERSION;
				
				/// <inheritdoc />
				public string DeprecatedVersion => DEPRECATED_VERSION;
				
				/// <inheritdoc />
				public string Aggregation => AGGREGATION;

				// Note: Extension.Extender
				/// <inheritdoc />
				public string Extension => EXTENSION;
				
				/// <inheritdoc />
				public string Association => ASSOCIATION;

				// Note: DefaultValue.Name
				/// <inheritdoc />
				public string DefaultValue => DEFAULT_VALUE;
			}
			/// <summary>
			/// <inheritdoc cref="ObservesPathFeedrateOverrideProgrammedProperty" path="/summary" /><br/>
			/// <remarks>Original Name: ObservesPathFeedrateOverrideProgrammed</remarks>
			/// </summary>
			public new ObservesPathFeedrateOverrideProgrammedProperty ObservesPathFeedrateOverrideProgrammed { get; } = new ObservesPathFeedrateOverrideProgrammedProperty();
			
			/// <summary>﻿
			/// </summary>
			public new sealed class ObservesPathFeedrateOverrideProgrammedProperty : IProperty
			{
				/// <summary>Constant value for <see cref="ObservesPathFeedrateOverrideProgrammedProperty.Name" /></summary>
				public const string NAME = "observesPathFeedrateOverrideProgrammed";
				/// <summary>Constant value for <see cref="ObservesPathFeedrateOverrideProgrammedProperty.Summary" /></summary>
				public const string SUMMARY = @"";
				/// <summary>Constant value for <see cref="ObservesPathFeedrateOverrideProgrammedProperty.AccessModifier" /></summary>
				public const string ACCESS_MODIFIER = "public";
				/// <summary>Constant value for <see cref="ObservesPathFeedrateOverrideProgrammedProperty.Modifier" /></summary>
				public const string MODIFIER = "";
				/// <summary>Constant value for <see cref="ObservesPathFeedrateOverrideProgrammedProperty.NormativeVersion" /></summary>
				public const string NORMATIVE_VERSION = "";
				/// <summary>Constant value for <see cref="ObservesPathFeedrateOverrideProgrammedProperty.DeprecatedVersion" /></summary>
				public const string DEPRECATED_VERSION = "";
				/// <summary>Constant value for <see cref="ObservesPathFeedrateOverrideProgrammedProperty.Aggregation" /></summary>
				public const string AGGREGATION = "composite";
				/// <summary>Constant value for <see cref="ObservesPathFeedrateOverrideProgrammedProperty.Extension" /></summary>
				public const string EXTENSION = "MagicDraw UML 2024x";
				/// <summary>Constant value for <see cref="ObservesPathFeedrateOverrideProgrammedProperty.Association" /></summary>
				public const string ASSOCIATION = "";
				/// <summary>Constant value for <see cref="ObservesPathFeedrateOverrideProgrammedProperty.DefaultValue" /></summary>
				public const string DEFAULT_VALUE = "";

				/// <summary>
				/// <inheritdoc />
				/// <remarks> Type: PathFeedrateOverride.ProgrammedClass </remarks>
				/// </summary>
				public System.Type Type => typeof(Mtconnect.ObservationInformationModel.ObservationTypes.EventTypes.PathFeedrateOverrideProgrammedClass);
				
				/// <inheritdoc />
				public string Name => NAME;
				
				/// <inheritdoc />
				public string Summary => SUMMARY;

				/// <inheritdoc />
				public string AccessModifier => ACCESS_MODIFIER;
				
				/// <inheritdoc />
				public string Modifier => MODIFIER;
				
				/// <inheritdoc />
				public string NormativeVersion => NORMATIVE_VERSION;
				
				/// <inheritdoc />
				public string DeprecatedVersion => DEPRECATED_VERSION;
				
				/// <inheritdoc />
				public string Aggregation => AGGREGATION;

				// Note: Extension.Extender
				/// <inheritdoc />
				public string Extension => EXTENSION;
				
				/// <inheritdoc />
				public string Association => ASSOCIATION;

				// Note: DefaultValue.Name
				/// <inheritdoc />
				public string DefaultValue => DEFAULT_VALUE;
			}
			/// <summary>
			/// <inheritdoc cref="ObservesPathFeedrateOverrideRapidProperty" path="/summary" /><br/>
			/// <remarks>Original Name: ObservesPathFeedrateOverrideRapid</remarks>
			/// </summary>
			public new ObservesPathFeedrateOverrideRapidProperty ObservesPathFeedrateOverrideRapid { get; } = new ObservesPathFeedrateOverrideRapidProperty();
			
			/// <summary>﻿
			/// </summary>
			public new sealed class ObservesPathFeedrateOverrideRapidProperty : IProperty
			{
				/// <summary>Constant value for <see cref="ObservesPathFeedrateOverrideRapidProperty.Name" /></summary>
				public const string NAME = "observesPathFeedrateOverrideRapid";
				/// <summary>Constant value for <see cref="ObservesPathFeedrateOverrideRapidProperty.Summary" /></summary>
				public const string SUMMARY = @"";
				/// <summary>Constant value for <see cref="ObservesPathFeedrateOverrideRapidProperty.AccessModifier" /></summary>
				public const string ACCESS_MODIFIER = "public";
				/// <summary>Constant value for <see cref="ObservesPathFeedrateOverrideRapidProperty.Modifier" /></summary>
				public const string MODIFIER = "";
				/// <summary>Constant value for <see cref="ObservesPathFeedrateOverrideRapidProperty.NormativeVersion" /></summary>
				public const string NORMATIVE_VERSION = "";
				/// <summary>Constant value for <see cref="ObservesPathFeedrateOverrideRapidProperty.DeprecatedVersion" /></summary>
				public const string DEPRECATED_VERSION = "";
				/// <summary>Constant value for <see cref="ObservesPathFeedrateOverrideRapidProperty.Aggregation" /></summary>
				public const string AGGREGATION = "composite";
				/// <summary>Constant value for <see cref="ObservesPathFeedrateOverrideRapidProperty.Extension" /></summary>
				public const string EXTENSION = "MagicDraw UML 2024x";
				/// <summary>Constant value for <see cref="ObservesPathFeedrateOverrideRapidProperty.Association" /></summary>
				public const string ASSOCIATION = "";
				/// <summary>Constant value for <see cref="ObservesPathFeedrateOverrideRapidProperty.DefaultValue" /></summary>
				public const string DEFAULT_VALUE = "";

				/// <summary>
				/// <inheritdoc />
				/// <remarks> Type: PathFeedrateOverride.RapidClass </remarks>
				/// </summary>
				public System.Type Type => typeof(Mtconnect.ObservationInformationModel.ObservationTypes.EventTypes.PathFeedrateOverrideRapidClass);
				
				/// <inheritdoc />
				public string Name => NAME;
				
				/// <inheritdoc />
				public string Summary => SUMMARY;

				/// <inheritdoc />
				public string AccessModifier => ACCESS_MODIFIER;
				
				/// <inheritdoc />
				public string Modifier => MODIFIER;
				
				/// <inheritdoc />
				public string NormativeVersion => NORMATIVE_VERSION;
				
				/// <inheritdoc />
				public string DeprecatedVersion => DEPRECATED_VERSION;
				
				/// <inheritdoc />
				public string Aggregation => AGGREGATION;

				// Note: Extension.Extender
				/// <inheritdoc />
				public string Extension => EXTENSION;
				
				/// <inheritdoc />
				public string Association => ASSOCIATION;

				// Note: DefaultValue.Name
				/// <inheritdoc />
				public string DefaultValue => DEFAULT_VALUE;
			}
			/// <summary>
			/// <inheritdoc cref="ObservesRotaryVelocityOverrideProperty" path="/summary" /><br/>
			/// <remarks>Original Name: ObservesRotaryVelocityOverride</remarks>
			/// </summary>
			public new ObservesRotaryVelocityOverrideProperty ObservesRotaryVelocityOverride { get; } = new ObservesRotaryVelocityOverrideProperty();
			
			/// <summary>﻿
			/// </summary>
			public new sealed class ObservesRotaryVelocityOverrideProperty : IProperty
			{
				/// <summary>Constant value for <see cref="ObservesRotaryVelocityOverrideProperty.Name" /></summary>
				public const string NAME = "observesRotaryVelocityOverride";
				/// <summary>Constant value for <see cref="ObservesRotaryVelocityOverrideProperty.Summary" /></summary>
				public const string SUMMARY = @"";
				/// <summary>Constant value for <see cref="ObservesRotaryVelocityOverrideProperty.AccessModifier" /></summary>
				public const string ACCESS_MODIFIER = "public";
				/// <summary>Constant value for <see cref="ObservesRotaryVelocityOverrideProperty.Modifier" /></summary>
				public const string MODIFIER = "";
				/// <summary>Constant value for <see cref="ObservesRotaryVelocityOverrideProperty.NormativeVersion" /></summary>
				public const string NORMATIVE_VERSION = "";
				/// <summary>Constant value for <see cref="ObservesRotaryVelocityOverrideProperty.DeprecatedVersion" /></summary>
				public const string DEPRECATED_VERSION = "";
				/// <summary>Constant value for <see cref="ObservesRotaryVelocityOverrideProperty.Aggregation" /></summary>
				public const string AGGREGATION = "composite";
				/// <summary>Constant value for <see cref="ObservesRotaryVelocityOverrideProperty.Extension" /></summary>
				public const string EXTENSION = "MagicDraw UML 2024x";
				/// <summary>Constant value for <see cref="ObservesRotaryVelocityOverrideProperty.Association" /></summary>
				public const string ASSOCIATION = "";
				/// <summary>Constant value for <see cref="ObservesRotaryVelocityOverrideProperty.DefaultValue" /></summary>
				public const string DEFAULT_VALUE = "";

				/// <summary>
				/// <inheritdoc />
				/// <remarks> Type: RotaryVelocityOverrideClass </remarks>
				/// </summary>
				public System.Type Type => typeof(Mtconnect.ObservationInformationModel.ObservationTypes.EventTypes.RotaryVelocityOverrideClass);
				
				/// <inheritdoc />
				public string Name => NAME;
				
				/// <inheritdoc />
				public string Summary => SUMMARY;

				/// <inheritdoc />
				public string AccessModifier => ACCESS_MODIFIER;
				
				/// <inheritdoc />
				public string Modifier => MODIFIER;
				
				/// <inheritdoc />
				public string NormativeVersion => NORMATIVE_VERSION;
				
				/// <inheritdoc />
				public string DeprecatedVersion => DEPRECATED_VERSION;
				
				/// <inheritdoc />
				public string Aggregation => AGGREGATION;

				// Note: Extension.Extender
				/// <inheritdoc />
				public string Extension => EXTENSION;
				
				/// <inheritdoc />
				public string Association => ASSOCIATION;

				// Note: DefaultValue.Name
				/// <inheritdoc />
				public string DefaultValue => DEFAULT_VALUE;
			}
			/// <summary>
			/// <inheritdoc cref="ObservesPathFeedrateProperty" path="/summary" /><br/>
			/// <remarks>Original Name: ObservesPathFeedrate</remarks>
			/// </summary>
			public new ObservesPathFeedrateProperty ObservesPathFeedrate { get; } = new ObservesPathFeedrateProperty();
			
			/// <summary>﻿
			/// </summary>
			public new sealed class ObservesPathFeedrateProperty : IProperty
			{
				/// <summary>Constant value for <see cref="ObservesPathFeedrateProperty.Name" /></summary>
				public const string NAME = "observesPathFeedrate";
				/// <summary>Constant value for <see cref="ObservesPathFeedrateProperty.Summary" /></summary>
				public const string SUMMARY = @"";
				/// <summary>Constant value for <see cref="ObservesPathFeedrateProperty.AccessModifier" /></summary>
				public const string ACCESS_MODIFIER = "public";
				/// <summary>Constant value for <see cref="ObservesPathFeedrateProperty.Modifier" /></summary>
				public const string MODIFIER = "";
				/// <summary>Constant value for <see cref="ObservesPathFeedrateProperty.NormativeVersion" /></summary>
				public const string NORMATIVE_VERSION = "";
				/// <summary>Constant value for <see cref="ObservesPathFeedrateProperty.DeprecatedVersion" /></summary>
				public const string DEPRECATED_VERSION = "";
				/// <summary>Constant value for <see cref="ObservesPathFeedrateProperty.Aggregation" /></summary>
				public const string AGGREGATION = "composite";
				/// <summary>Constant value for <see cref="ObservesPathFeedrateProperty.Extension" /></summary>
				public const string EXTENSION = "MagicDraw UML 2024x";
				/// <summary>Constant value for <see cref="ObservesPathFeedrateProperty.Association" /></summary>
				public const string ASSOCIATION = "";
				/// <summary>Constant value for <see cref="ObservesPathFeedrateProperty.DefaultValue" /></summary>
				public const string DEFAULT_VALUE = "";

				/// <summary>
				/// <inheritdoc />
				/// <remarks> Type: PathFeedrateClass </remarks>
				/// </summary>
				public System.Type Type => typeof(Mtconnect.ObservationInformationModel.ObservationTypes.SampleTypes.PathFeedrateClass);
				
				/// <inheritdoc />
				public string Name => NAME;
				
				/// <inheritdoc />
				public string Summary => SUMMARY;

				/// <inheritdoc />
				public string AccessModifier => ACCESS_MODIFIER;
				
				/// <inheritdoc />
				public string Modifier => MODIFIER;
				
				/// <inheritdoc />
				public string NormativeVersion => NORMATIVE_VERSION;
				
				/// <inheritdoc />
				public string DeprecatedVersion => DEPRECATED_VERSION;
				
				/// <inheritdoc />
				public string Aggregation => AGGREGATION;

				// Note: Extension.Extender
				/// <inheritdoc />
				public string Extension => EXTENSION;
				
				/// <inheritdoc />
				public string Association => ASSOCIATION;

				// Note: DefaultValue.Name
				/// <inheritdoc />
				public string DefaultValue => DEFAULT_VALUE;
			}
			/// <summary>
			/// <inheritdoc cref="ObservesPartCountProperty" path="/summary" /><br/>
			/// <remarks>Original Name: ObservesPartCount</remarks>
			/// </summary>
			public new ObservesPartCountProperty ObservesPartCount { get; } = new ObservesPartCountProperty();
			
			/// <summary>﻿
			/// </summary>
			public new sealed class ObservesPartCountProperty : IProperty
			{
				/// <summary>Constant value for <see cref="ObservesPartCountProperty.Name" /></summary>
				public const string NAME = "observesPartCount";
				/// <summary>Constant value for <see cref="ObservesPartCountProperty.Summary" /></summary>
				public const string SUMMARY = @"";
				/// <summary>Constant value for <see cref="ObservesPartCountProperty.AccessModifier" /></summary>
				public const string ACCESS_MODIFIER = "public";
				/// <summary>Constant value for <see cref="ObservesPartCountProperty.Modifier" /></summary>
				public const string MODIFIER = "";
				/// <summary>Constant value for <see cref="ObservesPartCountProperty.NormativeVersion" /></summary>
				public const string NORMATIVE_VERSION = "";
				/// <summary>Constant value for <see cref="ObservesPartCountProperty.DeprecatedVersion" /></summary>
				public const string DEPRECATED_VERSION = "";
				/// <summary>Constant value for <see cref="ObservesPartCountProperty.Aggregation" /></summary>
				public const string AGGREGATION = "composite";
				/// <summary>Constant value for <see cref="ObservesPartCountProperty.Extension" /></summary>
				public const string EXTENSION = "MagicDraw UML 2024x";
				/// <summary>Constant value for <see cref="ObservesPartCountProperty.Association" /></summary>
				public const string ASSOCIATION = "";
				/// <summary>Constant value for <see cref="ObservesPartCountProperty.DefaultValue" /></summary>
				public const string DEFAULT_VALUE = "";

				/// <summary>
				/// <inheritdoc />
				/// <remarks> Type: PartCountClass </remarks>
				/// </summary>
				public System.Type Type => typeof(Mtconnect.ObservationInformationModel.ObservationTypes.EventTypes.PartCountClass);
				
				/// <inheritdoc />
				public string Name => NAME;
				
				/// <inheritdoc />
				public string Summary => SUMMARY;

				/// <inheritdoc />
				public string AccessModifier => ACCESS_MODIFIER;
				
				/// <inheritdoc />
				public string Modifier => MODIFIER;
				
				/// <inheritdoc />
				public string NormativeVersion => NORMATIVE_VERSION;
				
				/// <inheritdoc />
				public string DeprecatedVersion => DEPRECATED_VERSION;
				
				/// <inheritdoc />
				public string Aggregation => AGGREGATION;

				// Note: Extension.Extender
				/// <inheritdoc />
				public string Extension => EXTENSION;
				
				/// <inheritdoc />
				public string Association => ASSOCIATION;

				// Note: DefaultValue.Name
				/// <inheritdoc />
				public string DefaultValue => DEFAULT_VALUE;
			}
		};

	}
}