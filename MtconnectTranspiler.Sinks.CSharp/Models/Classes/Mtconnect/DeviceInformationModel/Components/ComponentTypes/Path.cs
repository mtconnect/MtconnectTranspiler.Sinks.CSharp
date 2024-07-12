
using System;
using System.CodeDom.Compiler;

using Mtconnect.ObservationInformationModel.ObservationTypes.EventTypes;
using Mtconnect.ObservationInformationModel.ObservationTypes.SampleTypes;

namespace Mtconnect.DeviceInformationModel.Components.ComponentTypes
{
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "1.0.15.3")]
	public sealed class PathClass
	{
		/// <inheritdoc cref="Class.ReferenceId" />
		public string ReferenceId => "_19_0_3_45f01b9_1579572382004_482583_42267";
		
		/// <inheritdoc cref="Class.Name" />
		public string Name => "Path";
		
		/// <inheritdoc cref="Class.AccessModifier" />
		public string AccessModifier => "public";
				
		/// <inheritdoc cref="Class.Modifier" />
		public string Modifier => "";
				
		/// <inheritdoc cref="Class.NormativeVersion" />
		public string NormativeVersion => "MtconnectVersions.V_1_1_0";
				
		/// <inheritdoc cref="Class.DeprecatedVersion" />
		public string DeprecatedVersion => "";

		public string Generalization => "";

		public PathProperties Properties { get; } = new PathProperties();
		public sealed class PathProperties
		{
		
		
			/// <remarks>Original Name: ObservesExecution</remarks>
			public ObservesExecutionProperty ObservesExecution { get; } = new ObservesExecutionProperty();
			public sealed class ObservesExecutionProperty
			{
				/// <inheritdoc cref="Property.Type" />
				/// Original Type: _19_0_3_45f01b9_1580378218306_196644_1821
				public Type Type => typeof(ExecutionClass);
				
				/// <inheritdoc cref="Property.Name" />
				public string Name => "ObservesExecution";
				
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
		
		
			/// <remarks>Original Name: ObservesProgram</remarks>
			public ObservesProgramProperty ObservesProgram { get; } = new ObservesProgramProperty();
			public sealed class ObservesProgramProperty
			{
				/// <inheritdoc cref="Property.Type" />
				/// Original Type: _19_0_3_45f01b9_1580378218420_715490_2100
				public Type Type => typeof(ProgramClass);
				
				/// <inheritdoc cref="Property.Name" />
				public string Name => "ObservesProgram";
				
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
		
		
			/// <remarks>Original Name: ObservesPathFeedrateOverrideProgrammed</remarks>
			public ObservesPathFeedrateOverrideProgrammedProperty ObservesPathFeedrateOverrideProgrammed { get; } = new ObservesPathFeedrateOverrideProgrammedProperty();
			public sealed class ObservesPathFeedrateOverrideProgrammedProperty
			{
				/// <inheritdoc cref="Property.Type" />
				/// Original Type: _19_0_3_45f01b9_1580378218383_276168_2007
				public Type Type => typeof(PathFeedrateOverride.ProgrammedClass);
				
				/// <inheritdoc cref="Property.Name" />
				public string Name => "ObservesPathFeedrateOverrideProgrammed";
				
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
		
		
			/// <remarks>Original Name: ObservesPathFeedrateOverrideRapid</remarks>
			public ObservesPathFeedrateOverrideRapidProperty ObservesPathFeedrateOverrideRapid { get; } = new ObservesPathFeedrateOverrideRapidProperty();
			public sealed class ObservesPathFeedrateOverrideRapidProperty
			{
				/// <inheritdoc cref="Property.Type" />
				/// Original Type: _19_0_3_45f01b9_1580378218384_46527_2010
				public Type Type => typeof(PathFeedrateOverride.RapidClass);
				
				/// <inheritdoc cref="Property.Name" />
				public string Name => "ObservesPathFeedrateOverrideRapid";
				
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
		
		
			/// <remarks>Original Name: ObservesRotaryVelocityOverride</remarks>
			public ObservesRotaryVelocityOverrideProperty ObservesRotaryVelocityOverride { get; } = new ObservesRotaryVelocityOverrideProperty();
			public sealed class ObservesRotaryVelocityOverrideProperty
			{
				/// <inheritdoc cref="Property.Type" />
				/// Original Type: _19_0_3_45f01b9_1580378218440_585732_2163
				public Type Type => typeof(RotaryVelocityOverrideClass);
				
				/// <inheritdoc cref="Property.Name" />
				public string Name => "ObservesRotaryVelocityOverride";
				
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
		
		
			/// <remarks>Original Name: ObservesPathFeedrate</remarks>
			public ObservesPathFeedrateProperty ObservesPathFeedrate { get; } = new ObservesPathFeedrateProperty();
			public sealed class ObservesPathFeedrateProperty
			{
				/// <inheritdoc cref="Property.Type" />
				/// Original Type: _19_0_3_45f01b9_1580378218374_970818_1980
				public Type Type => typeof(PathFeedrateClass);
				
				/// <inheritdoc cref="Property.Name" />
				public string Name => "ObservesPathFeedrate";
				
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
		
		
			/// <remarks>Original Name: ObservesPartCount</remarks>
			public ObservesPartCountProperty ObservesPartCount { get; } = new ObservesPartCountProperty();
			public sealed class ObservesPartCountProperty
			{
				/// <inheritdoc cref="Property.Type" />
				/// Original Type: _19_0_3_45f01b9_1580378218363_437912_1953
				public Type Type => typeof(PartCountClass);
				
				/// <inheritdoc cref="Property.Name" />
				public string Name => "ObservesPartCount";
				
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