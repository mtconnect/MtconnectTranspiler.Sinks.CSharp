using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;
// using Mtconnect.ObservationInformationModel.ObservationTypes.EventTypes;
// using Mtconnect.ObservationInformationModel.ObservationTypes.SampleTypes;

namespace Mtconnect.DeviceInformationModel.Components.ComponentTypes
{
	/// <summary>
	/// <see cref="Component">Component</see> that organizes an independent operation or function within a <see cref="Controller">Controller</see>./// Description
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.3.0.0")]
	public sealed class PathClass : IClass
	{
		/// <inheritdoc />
		public string ReferenceId => "_19_0_3_45f01b9_1579572382004_482583_42267";
		
		/// <inheritdoc />
		public string Summary => @"/// <see cref=""Component"">Component</see> that organizes an independent operation or function within a <see cref=""Controller"">Controller</see>./// Description";

		/// <inheritdoc />
		public string Name => "PathClass";
		
		/// <inheritdoc />
		public string AccessModifier => "public";
				
		/// <inheritdoc />
		public string Modifier => "";
				
		/// <inheritdoc />
		public string NormativeVersion => "1.1";
				
		/// <inheritdoc />
		public string DeprecatedVersion => "";
		
		/// <inheritdoc />
		public string Generalization => "EAID_8548C620_467A_4f50_9A22_58D84B7E8779";

		/// <inheritdoc />
		public PathClassProperties Properties { get; } = new PathClassProperties();
        IPropertyList IClass.Properties => Properties;
		public sealed class PathClassProperties : IPropertyList
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
			};
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
				public string Name => "ObservesExecution";
				
				/// <inheritdoc />
				public string Summary => @"/// <see cref=""Component"">Component</see> that organizes an independent operation or function within a <see cref=""Controller"">Controller</see>./// Description";

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
				public string Name => "ObservesProgram";
				
				/// <inheritdoc />
				public string Summary => @"/// <see cref=""Component"">Component</see> that organizes an independent operation or function within a <see cref=""Controller"">Controller</see>./// Description";

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
				public string Name => "ObservesPathFeedrateOverrideProgrammed";
				
				/// <inheritdoc />
				public string Summary => @"/// <see cref=""Component"">Component</see> that organizes an independent operation or function within a <see cref=""Controller"">Controller</see>./// Description";

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
				public string Name => "ObservesPathFeedrateOverrideRapid";
				
				/// <inheritdoc />
				public string Summary => @"/// <see cref=""Component"">Component</see> that organizes an independent operation or function within a <see cref=""Controller"">Controller</see>./// Description";

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
				public string Name => "ObservesRotaryVelocityOverride";
				
				/// <inheritdoc />
				public string Summary => @"/// <see cref=""Component"">Component</see> that organizes an independent operation or function within a <see cref=""Controller"">Controller</see>./// Description";

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
				public string Name => "ObservesPathFeedrate";
				
				/// <inheritdoc />
				public string Summary => @"/// <see cref=""Component"">Component</see> that organizes an independent operation or function within a <see cref=""Controller"">Controller</see>./// Description";

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
				public string Name => "ObservesPartCount";
				
				/// <inheritdoc />
				public string Summary => @"/// <see cref=""Component"">Component</see> that organizes an independent operation or function within a <see cref=""Controller"">Controller</see>./// Description";

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