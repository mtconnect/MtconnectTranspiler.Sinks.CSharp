
using System;
using System.CodeDom.Compiler;

using Mtconnect.Glossary;

namespace Mtconnect.DeviceInformationModel.Configurations.Specifications
{
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "1.0.15.3")]
	public sealed class AlarmLimitsClass
	{
		/// <inheritdoc cref="Class.ReferenceId" />
		public string ReferenceId => "_19_0_3_68e0225_1605643893577_939623_1049";
		
		/// <inheritdoc cref="Class.Name" />
		public string Name => "AlarmLimits";
		
		/// <inheritdoc cref="Class.AccessModifier" />
		public string AccessModifier => "public";
				
		/// <inheritdoc cref="Class.Modifier" />
		public string Modifier => "";
				
		/// <inheritdoc cref="Class.NormativeVersion" />
		public string NormativeVersion => "MtconnectVersions.V_1_7_0";
				
		/// <inheritdoc cref="Class.DeprecatedVersion" />
		public string DeprecatedVersion => "";

		public string Generalization => "";

		public AlarmLimitsProperties Properties { get; } = new AlarmLimitsProperties();
		public sealed class AlarmLimitsProperties
		{
		
		
			/// <remarks>Original Name: UpperLimit</remarks>
			public UpperLimitPartProperty UpperLimitPart { get; } = new UpperLimitPartProperty();
			public sealed class UpperLimitPartProperty
			{
				/// <inheritdoc cref="Property.Type" />
				/// Original Type: _19_0_3_68e0225_1605643508394_491668_626
				public Type Type => typeof(UpperLimitClass);
				
				/// <inheritdoc cref="Property.Name" />
				public string Name => "UpperLimit";
				
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

				public string Association => "UpperLimit";

				// Note: DefaultValue.Name
				public string DefaultValue => "";

				// TODO: Add Summary
			}
		
		
			/// <remarks>Original Name: UpperWarning</remarks>
			public UpperWarningPartProperty UpperWarningPart { get; } = new UpperWarningPartProperty();
			public sealed class UpperWarningPartProperty
			{
				/// <inheritdoc cref="Property.Type" />
				/// Original Type: _19_0_3_68e0225_1605643515595_841451_671
				public Type Type => typeof(UpperWarningClass);
				
				/// <inheritdoc cref="Property.Name" />
				public string Name => "UpperWarning";
				
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

				public string Association => "UpperWarning";

				// Note: DefaultValue.Name
				public string DefaultValue => "";

				// TODO: Add Summary
			}
		
		
			/// <remarks>Original Name: LowerLimit</remarks>
			public LowerLimitPartProperty LowerLimitPart { get; } = new LowerLimitPartProperty();
			public sealed class LowerLimitPartProperty
			{
				/// <inheritdoc cref="Property.Type" />
				/// Original Type: _19_0_3_68e0225_1605643526040_637158_716
				public Type Type => typeof(LowerLimitClass);
				
				/// <inheritdoc cref="Property.Name" />
				public string Name => "LowerLimit";
				
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

				public string Association => "LowerLimit";

				// Note: DefaultValue.Name
				public string DefaultValue => "";

				// TODO: Add Summary
			}
		
		
			/// <remarks>Original Name: LowerWarning</remarks>
			public LowerWarningPartProperty LowerWarningPart { get; } = new LowerWarningPartProperty();
			public sealed class LowerWarningPartProperty
			{
				/// <inheritdoc cref="Property.Type" />
				/// Original Type: _19_0_3_68e0225_1605643531502_63450_761
				public Type Type => typeof(LowerWarningClass);
				
				/// <inheritdoc cref="Property.Name" />
				public string Name => "LowerWarning";
				
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

				public string Association => "LowerWarning";

				// Note: DefaultValue.Name
				public string DefaultValue => "";

				// TODO: Add Summary
			}
		};

	}
}