
using System;
using System.CodeDom.Compiler;

using Mtconnect.ObservationInformationModel.ObservationTypes.SampleTypes;

namespace Mtconnect.DeviceInformationModel.Components.ComponentTypes
{
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "1.0.15.3")]
	public sealed class RotaryClass
	{
		/// <inheritdoc cref="Class.ReferenceId" />
		public string ReferenceId => "_19_0_3_45f01b9_1579572382015_53595_42288";
		
		/// <inheritdoc cref="Class.Name" />
		public string Name => "Rotary";
		
		/// <inheritdoc cref="Class.AccessModifier" />
		public string AccessModifier => "public";
				
		/// <inheritdoc cref="Class.Modifier" />
		public string Modifier => "";
				
		/// <inheritdoc cref="Class.NormativeVersion" />
		public string NormativeVersion => "MtconnectVersions.V_1_0_1";
				
		/// <inheritdoc cref="Class.DeprecatedVersion" />
		public string DeprecatedVersion => "";

		public string Generalization => "";

		public RotaryProperties Properties { get; } = new RotaryProperties();
		public sealed class RotaryProperties
		{
		
		
			/// <remarks>Original Name: ObservesLoad</remarks>
			public ObservesLoadProperty ObservesLoad { get; } = new ObservesLoadProperty();
			public sealed class ObservesLoadProperty
			{
				/// <inheritdoc cref="Property.Type" />
				/// Original Type: _19_0_3_45f01b9_1580378218342_32796_1902
				public Type Type => typeof(LoadClass);
				
				/// <inheritdoc cref="Property.Name" />
				public string Name => "ObservesLoad";
				
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
		
		
			/// <remarks>Original Name: ObservesTemperature</remarks>
			public ObservesTemperatureProperty ObservesTemperature { get; } = new ObservesTemperatureProperty();
			public sealed class ObservesTemperatureProperty
			{
				/// <inheritdoc cref="Property.Type" />
				/// Original Type: _19_0_3_45f01b9_1580378218451_953222_2205
				public Type Type => typeof(TemperatureClass);
				
				/// <inheritdoc cref="Property.Name" />
				public string Name => "ObservesTemperature";
				
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
		
		
			/// <remarks>Original Name: ObservesRotaryVelocity</remarks>
			public ObservesRotaryVelocityProperty ObservesRotaryVelocity { get; } = new ObservesRotaryVelocityProperty();
			public sealed class ObservesRotaryVelocityProperty
			{
				/// <inheritdoc cref="Property.Type" />
				/// Original Type: _19_0_3_45f01b9_1580378218436_532649_2148
				public Type Type => typeof(RotaryVelocityClass);
				
				/// <inheritdoc cref="Property.Name" />
				public string Name => "ObservesRotaryVelocity";
				
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
		
		
			/// <remarks>Original Name: ObservesAxisFeedrate</remarks>
			public ObservesAxisFeedrateProperty ObservesAxisFeedrate { get; } = new ObservesAxisFeedrateProperty();
			public sealed class ObservesAxisFeedrateProperty
			{
				/// <inheritdoc cref="Property.Type" />
				/// Original Type: _19_0_3_45f01b9_1580378218186_884374_1560
				public Type Type => typeof(AxisFeedrateClass);
				
				/// <inheritdoc cref="Property.Name" />
				public string Name => "ObservesAxisFeedrate";
				
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