
using System;
using System.CodeDom.Compiler;

using Mtconnect.ObservationInformationModel.ObservationTypes.EventTypes;

namespace Mtconnect.DeviceInformationModel.Configurations.Specifications
{
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "1.0.15.3")]
	public sealed class ProcessSpecificationClass
	{
		/// <inheritdoc cref="Class.ReferenceId" />
		public string ReferenceId => "_19_0_3_68e0225_1605643801279_773776_859";
		
		/// <inheritdoc cref="Class.Name" />
		public string Name => "ProcessSpecification";
		
		/// <inheritdoc cref="Class.AccessModifier" />
		public string AccessModifier => "public";
				
		/// <inheritdoc cref="Class.Modifier" />
		public string Modifier => "";
				
		/// <inheritdoc cref="Class.NormativeVersion" />
		public string NormativeVersion => "MtconnectVersions.V_1_7_0";
				
		/// <inheritdoc cref="Class.DeprecatedVersion" />
		public string DeprecatedVersion => "";

		public string Generalization => "";

		public ProcessSpecificationProperties Properties { get; } = new ProcessSpecificationProperties();
		public sealed class ProcessSpecificationProperties
		{
		
		
			/// <remarks>Original Name: HasSpecificationLimits</remarks>
			public HasSpecificationLimitsPartProperty HasSpecificationLimitsPart { get; } = new HasSpecificationLimitsPartProperty();
			public sealed class HasSpecificationLimitsPartProperty
			{
				/// <inheritdoc cref="Property.Type" />
				/// Original Type: _19_0_3_68e0225_1605643883082_895051_1004
				public Type Type => typeof(SpecificationLimitsClass);
				
				/// <inheritdoc cref="Property.Name" />
				public string Name => "HasSpecificationLimits";
				
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

				public string Association => "SpecificationLimits";

				// Note: DefaultValue.Name
				public string DefaultValue => "";

				// TODO: Add Summary
			}
		
		
			/// <remarks>Original Name: HasControlLimits</remarks>
			public HasControlLimitsPartProperty HasControlLimitsPart { get; } = new HasControlLimitsPartProperty();
			public sealed class HasControlLimitsPartProperty
			{
				/// <inheritdoc cref="Property.Type" />
				/// Original Type: _19_0_3_68e0225_1605643876416_54094_959
				public Type Type => typeof(ControlLimitsClass);
				
				/// <inheritdoc cref="Property.Name" />
				public string Name => "HasControlLimits";
				
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

				public string Association => "ControlLimits";

				// Note: DefaultValue.Name
				public string DefaultValue => "";

				// TODO: Add Summary
			}
		
		
			/// <remarks>Original Name: HasAlarmLimits</remarks>
			public HasAlarmLimitsPartProperty HasAlarmLimitsPart { get; } = new HasAlarmLimitsPartProperty();
			public sealed class HasAlarmLimitsPartProperty
			{
				/// <inheritdoc cref="Property.Type" />
				/// Original Type: _19_0_3_68e0225_1605643893577_939623_1049
				public Type Type => typeof(AlarmLimitsClass);
				
				/// <inheritdoc cref="Property.Name" />
				public string Name => "HasAlarmLimits";
				
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

				public string Association => "AlarmLimits";

				// Note: DefaultValue.Name
				public string DefaultValue => "";

				// TODO: Add Summary
			}
		};

	}
}