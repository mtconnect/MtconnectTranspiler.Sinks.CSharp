
using System;
using System.CodeDom.Compiler;

using Mtconnect.ObservationInformationModel.ObservationTypes.EventTypes;

namespace Mtconnect.DeviceInformationModel.Components.ComponentTypes
{
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "1.0.15.3")]
	public sealed class FeatureOccurrenceClass
	{
		/// <inheritdoc cref="Class.ReferenceId" />
		public string ReferenceId => "_19_0_3_68e0225_1678029650656_503771_494";
		
		/// <inheritdoc cref="Class.Name" />
		public string Name => "FeatureOccurrence";
		
		/// <inheritdoc cref="Class.AccessModifier" />
		public string AccessModifier => "public";
				
		/// <inheritdoc cref="Class.Modifier" />
		public string Modifier => "";
				
		/// <inheritdoc cref="Class.NormativeVersion" />
		public string NormativeVersion => "MtconnectVersions.V_2_2_0";
				
		/// <inheritdoc cref="Class.DeprecatedVersion" />
		public string DeprecatedVersion => "";

		public string Generalization => "";

		public FeatureOccurrenceProperties Properties { get; } = new FeatureOccurrenceProperties();
		public sealed class FeatureOccurrenceProperties
		{
		
		
			/// <remarks>Original Name: ObservesFeaturePersisitentId</remarks>
			public ObservesFeaturePersisitentIdProperty ObservesFeaturePersisitentId { get; } = new ObservesFeaturePersisitentIdProperty();
			public sealed class ObservesFeaturePersisitentIdProperty
			{
				/// <inheritdoc cref="Property.Type" />
				/// Original Type: _19_0_3_68e0225_1677579833995_963806_528
				public Type Type => typeof(FeaturePersisitentIdClass);
				
				/// <inheritdoc cref="Property.Name" />
				public string Name => "ObservesFeaturePersisitentId";
				
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
		
		
			/// <remarks>Original Name: ObservesFeatureMeasurement</remarks>
			public ObservesFeatureMeasurementProperty ObservesFeatureMeasurement { get; } = new ObservesFeatureMeasurementProperty();
			public sealed class ObservesFeatureMeasurementProperty
			{
				/// <inheritdoc cref="Property.Type" />
				/// Original Type: _19_0_3_68e0225_1678194652938_418535_17145
				public Type Type => typeof(FeatureMeasurementClass);
				
				/// <inheritdoc cref="Property.Name" />
				public string Name => "ObservesFeatureMeasurement";
				
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
		
		
			/// <remarks>Original Name: ObservesMeasurementType</remarks>
			public ObservesMeasurementTypeProperty ObservesMeasurementType { get; } = new ObservesMeasurementTypeProperty();
			public sealed class ObservesMeasurementTypeProperty
			{
				/// <inheritdoc cref="Property.Type" />
				/// Original Type: _19_0_3_68e0225_1678250722376_138912_18550
				public Type Type => typeof(MeasurementTypeClass);
				
				/// <inheritdoc cref="Property.Name" />
				public string Name => "ObservesMeasurementType";
				
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
		
		
			/// <remarks>Original Name: ObservesCharacteristicPersistentId</remarks>
			public ObservesCharacteristicPersistentIdProperty ObservesCharacteristicPersistentId { get; } = new ObservesCharacteristicPersistentIdProperty();
			public sealed class ObservesCharacteristicPersistentIdProperty
			{
				/// <inheritdoc cref="Property.Type" />
				/// Original Type: _19_0_3_68e0225_1678250721451_170871_18540
				public Type Type => typeof(CharacteristicPersistentIdClass);
				
				/// <inheritdoc cref="Property.Name" />
				public string Name => "ObservesCharacteristicPersistentId";
				
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
		
		
			/// <remarks>Original Name: ObservesCharacteristicStatus</remarks>
			public ObservesCharacteristicStatusProperty ObservesCharacteristicStatus { get; } = new ObservesCharacteristicStatusProperty();
			public sealed class ObservesCharacteristicStatusProperty
			{
				/// <inheritdoc cref="Property.Type" />
				/// Original Type: _19_0_3_68e0225_1678250725500_734546_18580
				public Type Type => typeof(CharacteristicStatusClass);
				
				/// <inheritdoc cref="Property.Name" />
				public string Name => "ObservesCharacteristicStatus";
				
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
		
		
			/// <remarks>Original Name: ObservesUncertainty</remarks>
			public ObservesUncertaintyProperty ObservesUncertainty { get; } = new ObservesUncertaintyProperty();
			public sealed class ObservesUncertaintyProperty
			{
				/// <inheritdoc cref="Property.Type" />
				/// Original Type: _19_0_3_68e0225_1678250846052_368890_18600
				public Type Type => typeof(UncertaintyClass);
				
				/// <inheritdoc cref="Property.Name" />
				public string Name => "ObservesUncertainty";
				
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
		
		
			/// <remarks>Original Name: ObservesUncertaintyType</remarks>
			public ObservesUncertaintyTypeProperty ObservesUncertaintyType { get; } = new ObservesUncertaintyTypeProperty();
			public sealed class ObservesUncertaintyTypeProperty
			{
				/// <inheritdoc cref="Property.Type" />
				/// Original Type: _19_0_3_68e0225_1678250726400_859394_18590
				public Type Type => typeof(UncertaintyTypeClass);
				
				/// <inheritdoc cref="Property.Name" />
				public string Name => "ObservesUncertaintyType";
				
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
		
		
			/// <remarks>Original Name: ObservesMeasurementUnits</remarks>
			public ObservesMeasurementUnitsProperty ObservesMeasurementUnits { get; } = new ObservesMeasurementUnitsProperty();
			public sealed class ObservesMeasurementUnitsProperty
			{
				/// <inheritdoc cref="Property.Type" />
				/// Original Type: _19_0_3_68e0225_1678250724207_274165_18570
				public Type Type => typeof(MeasurementUnitsClass);
				
				/// <inheritdoc cref="Property.Name" />
				public string Name => "ObservesMeasurementUnits";
				
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
		
		
			/// <remarks>Original Name: ObservesMeasurementValue</remarks>
			public ObservesMeasurementValueProperty ObservesMeasurementValue { get; } = new ObservesMeasurementValueProperty();
			public sealed class ObservesMeasurementValueProperty
			{
				/// <inheritdoc cref="Property.Type" />
				/// Original Type: _19_0_3_68e0225_1678250723151_758937_18560
				public Type Type => typeof(MeasurementValueClass);
				
				/// <inheritdoc cref="Property.Name" />
				public string Name => "ObservesMeasurementValue";
				
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