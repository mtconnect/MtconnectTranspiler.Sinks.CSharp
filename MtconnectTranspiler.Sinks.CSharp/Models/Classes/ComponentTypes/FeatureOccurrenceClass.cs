using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;
// using Mtconnect.ObservationInformationModel.ObservationTypes.EventTypes;

namespace Mtconnect.DeviceInformationModel.Components.ComponentTypes
{
	/// <summary>
	/// <see cref="Component">Component</see> that provides information related to an individual <i>feature</i>.
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.3.0.0")]
	public sealed class FeatureOccurrenceClass : IClass
	{
		/// <inheritdoc />
		public string ReferenceId => "_19_0_3_68e0225_1678029650656_503771_494";
		
		/// <inheritdoc />
		public string Summary => @"/// <see cref=""Component"">Component</see> that provides information related to an individual <i>feature</i>.";

		/// <inheritdoc />
		public string Name => "FeatureOccurrenceClass";
		
		/// <inheritdoc />
		public string AccessModifier => "public";
				
		/// <inheritdoc />
		public string Modifier => "";
				
		/// <inheritdoc />
		public string NormativeVersion => "2.2";
				
		/// <inheritdoc />
		public string DeprecatedVersion => "";
		
		/// <inheritdoc />
		public string Generalization => "_19_0_3_68e0225_1605547467172_656422_264";

		/// <inheritdoc />
		public FeatureOccurrenceClassProperties Properties { get; } = new FeatureOccurrenceClassProperties();
        IPropertyList IClass.Properties => Properties;
		public sealed class FeatureOccurrenceClassProperties : IPropertyList
		{
			/// <inheritdoc />
			public IProperty[] Properties => new IProperty[] {
				ObservesFeaturePersisitentId,
				ObservesFeatureMeasurement,
				ObservesMeasurementType,
				ObservesCharacteristicPersistentId,
				ObservesCharacteristicStatus,
				ObservesUncertainty,
				ObservesUncertaintyType,
				ObservesMeasurementUnits,
				ObservesMeasurementValue,
			};
			/// <summary>
			/// <inheritdoc cref="ObservesFeaturePersisitentIdProperty" path="/summary" /><br/>
			/// <remarks>Original Name: ObservesFeaturePersisitentId</remarks>
			/// </summary>
			public ObservesFeaturePersisitentIdProperty ObservesFeaturePersisitentId { get; } = new ObservesFeaturePersisitentIdProperty();
			public sealed class ObservesFeaturePersisitentIdProperty : IProperty
			{
				/// <summary>
				/// <inheritdoc />
				/// <remarks>
				/// <list type="bullet">
				/// <item>Original Type: _19_0_3_68e0225_1677579833995_963806_528</item>
				/// <item>Type: FeaturePersisitentIdClass</item>
				/// <item>Namespace: Mtconnect.ObservationInformationModel.ObservationTypes.EventTypes</item>
				/// </list>
				/// </remarks>
				/// </summary>
				public System.Type Type => typeof(Mtconnect.ObservationInformationModel.ObservationTypes.EventTypes.FeaturePersisitentIdClass);
				
				/// <inheritdoc />
				public string Name => "ObservesFeaturePersisitentId";
				
				/// <inheritdoc />
				public string Summary => @"/// <see cref=""Component"">Component</see> that provides information related to an individual <i>feature</i>.";

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
			/// <inheritdoc cref="ObservesFeatureMeasurementProperty" path="/summary" /><br/>
			/// <remarks>Original Name: ObservesFeatureMeasurement</remarks>
			/// </summary>
			public ObservesFeatureMeasurementProperty ObservesFeatureMeasurement { get; } = new ObservesFeatureMeasurementProperty();
			public sealed class ObservesFeatureMeasurementProperty : IProperty
			{
				/// <summary>
				/// <inheritdoc />
				/// <remarks>
				/// <list type="bullet">
				/// <item>Original Type: _19_0_3_68e0225_1678194652938_418535_17145</item>
				/// <item>Type: FeatureMeasurementClass</item>
				/// <item>Namespace: Mtconnect.ObservationInformationModel.ObservationTypes.EventTypes</item>
				/// </list>
				/// </remarks>
				/// </summary>
				public System.Type Type => typeof(Mtconnect.ObservationInformationModel.ObservationTypes.EventTypes.FeatureMeasurementClass);
				
				/// <inheritdoc />
				public string Name => "ObservesFeatureMeasurement";
				
				/// <inheritdoc />
				public string Summary => @"/// <see cref=""Component"">Component</see> that provides information related to an individual <i>feature</i>.";

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
			/// <inheritdoc cref="ObservesMeasurementTypeProperty" path="/summary" /><br/>
			/// <remarks>Original Name: ObservesMeasurementType</remarks>
			/// </summary>
			public ObservesMeasurementTypeProperty ObservesMeasurementType { get; } = new ObservesMeasurementTypeProperty();
			public sealed class ObservesMeasurementTypeProperty : IProperty
			{
				/// <summary>
				/// <inheritdoc />
				/// <remarks>
				/// <list type="bullet">
				/// <item>Original Type: _19_0_3_68e0225_1678250722376_138912_18550</item>
				/// <item>Type: MeasurementTypeClass</item>
				/// <item>Namespace: Mtconnect.ObservationInformationModel.ObservationTypes.EventTypes</item>
				/// </list>
				/// </remarks>
				/// </summary>
				public System.Type Type => typeof(Mtconnect.ObservationInformationModel.ObservationTypes.EventTypes.MeasurementTypeClass);
				
				/// <inheritdoc />
				public string Name => "ObservesMeasurementType";
				
				/// <inheritdoc />
				public string Summary => @"/// <see cref=""Component"">Component</see> that provides information related to an individual <i>feature</i>.";

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
			/// <inheritdoc cref="ObservesCharacteristicPersistentIdProperty" path="/summary" /><br/>
			/// <remarks>Original Name: ObservesCharacteristicPersistentId</remarks>
			/// </summary>
			public ObservesCharacteristicPersistentIdProperty ObservesCharacteristicPersistentId { get; } = new ObservesCharacteristicPersistentIdProperty();
			public sealed class ObservesCharacteristicPersistentIdProperty : IProperty
			{
				/// <summary>
				/// <inheritdoc />
				/// <remarks>
				/// <list type="bullet">
				/// <item>Original Type: _19_0_3_68e0225_1678250721451_170871_18540</item>
				/// <item>Type: CharacteristicPersistentIdClass</item>
				/// <item>Namespace: Mtconnect.ObservationInformationModel.ObservationTypes.EventTypes</item>
				/// </list>
				/// </remarks>
				/// </summary>
				public System.Type Type => typeof(Mtconnect.ObservationInformationModel.ObservationTypes.EventTypes.CharacteristicPersistentIdClass);
				
				/// <inheritdoc />
				public string Name => "ObservesCharacteristicPersistentId";
				
				/// <inheritdoc />
				public string Summary => @"/// <see cref=""Component"">Component</see> that provides information related to an individual <i>feature</i>.";

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
			/// <inheritdoc cref="ObservesCharacteristicStatusProperty" path="/summary" /><br/>
			/// <remarks>Original Name: ObservesCharacteristicStatus</remarks>
			/// </summary>
			public ObservesCharacteristicStatusProperty ObservesCharacteristicStatus { get; } = new ObservesCharacteristicStatusProperty();
			public sealed class ObservesCharacteristicStatusProperty : IProperty
			{
				/// <summary>
				/// <inheritdoc />
				/// <remarks>
				/// <list type="bullet">
				/// <item>Original Type: _19_0_3_68e0225_1678250725500_734546_18580</item>
				/// <item>Type: CharacteristicStatusClass</item>
				/// <item>Namespace: Mtconnect.ObservationInformationModel.ObservationTypes.EventTypes</item>
				/// </list>
				/// </remarks>
				/// </summary>
				public System.Type Type => typeof(Mtconnect.ObservationInformationModel.ObservationTypes.EventTypes.CharacteristicStatusClass);
				
				/// <inheritdoc />
				public string Name => "ObservesCharacteristicStatus";
				
				/// <inheritdoc />
				public string Summary => @"/// <see cref=""Component"">Component</see> that provides information related to an individual <i>feature</i>.";

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
			/// <inheritdoc cref="ObservesUncertaintyProperty" path="/summary" /><br/>
			/// <remarks>Original Name: ObservesUncertainty</remarks>
			/// </summary>
			public ObservesUncertaintyProperty ObservesUncertainty { get; } = new ObservesUncertaintyProperty();
			public sealed class ObservesUncertaintyProperty : IProperty
			{
				/// <summary>
				/// <inheritdoc />
				/// <remarks>
				/// <list type="bullet">
				/// <item>Original Type: _19_0_3_68e0225_1678250846052_368890_18600</item>
				/// <item>Type: UncertaintyClass</item>
				/// <item>Namespace: Mtconnect.ObservationInformationModel.ObservationTypes.EventTypes</item>
				/// </list>
				/// </remarks>
				/// </summary>
				public System.Type Type => typeof(Mtconnect.ObservationInformationModel.ObservationTypes.EventTypes.UncertaintyClass);
				
				/// <inheritdoc />
				public string Name => "ObservesUncertainty";
				
				/// <inheritdoc />
				public string Summary => @"/// <see cref=""Component"">Component</see> that provides information related to an individual <i>feature</i>.";

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
			/// <inheritdoc cref="ObservesUncertaintyTypeProperty" path="/summary" /><br/>
			/// <remarks>Original Name: ObservesUncertaintyType</remarks>
			/// </summary>
			public ObservesUncertaintyTypeProperty ObservesUncertaintyType { get; } = new ObservesUncertaintyTypeProperty();
			public sealed class ObservesUncertaintyTypeProperty : IProperty
			{
				/// <summary>
				/// <inheritdoc />
				/// <remarks>
				/// <list type="bullet">
				/// <item>Original Type: _19_0_3_68e0225_1678250726400_859394_18590</item>
				/// <item>Type: UncertaintyTypeClass</item>
				/// <item>Namespace: Mtconnect.ObservationInformationModel.ObservationTypes.EventTypes</item>
				/// </list>
				/// </remarks>
				/// </summary>
				public System.Type Type => typeof(Mtconnect.ObservationInformationModel.ObservationTypes.EventTypes.UncertaintyTypeClass);
				
				/// <inheritdoc />
				public string Name => "ObservesUncertaintyType";
				
				/// <inheritdoc />
				public string Summary => @"/// <see cref=""Component"">Component</see> that provides information related to an individual <i>feature</i>.";

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
			/// <inheritdoc cref="ObservesMeasurementUnitsProperty" path="/summary" /><br/>
			/// <remarks>Original Name: ObservesMeasurementUnits</remarks>
			/// </summary>
			public ObservesMeasurementUnitsProperty ObservesMeasurementUnits { get; } = new ObservesMeasurementUnitsProperty();
			public sealed class ObservesMeasurementUnitsProperty : IProperty
			{
				/// <summary>
				/// <inheritdoc />
				/// <remarks>
				/// <list type="bullet">
				/// <item>Original Type: _19_0_3_68e0225_1678250724207_274165_18570</item>
				/// <item>Type: MeasurementUnitsClass</item>
				/// <item>Namespace: Mtconnect.ObservationInformationModel.ObservationTypes.EventTypes</item>
				/// </list>
				/// </remarks>
				/// </summary>
				public System.Type Type => typeof(Mtconnect.ObservationInformationModel.ObservationTypes.EventTypes.MeasurementUnitsClass);
				
				/// <inheritdoc />
				public string Name => "ObservesMeasurementUnits";
				
				/// <inheritdoc />
				public string Summary => @"/// <see cref=""Component"">Component</see> that provides information related to an individual <i>feature</i>.";

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
			/// <inheritdoc cref="ObservesMeasurementValueProperty" path="/summary" /><br/>
			/// <remarks>Original Name: ObservesMeasurementValue</remarks>
			/// </summary>
			public ObservesMeasurementValueProperty ObservesMeasurementValue { get; } = new ObservesMeasurementValueProperty();
			public sealed class ObservesMeasurementValueProperty : IProperty
			{
				/// <summary>
				/// <inheritdoc />
				/// <remarks>
				/// <list type="bullet">
				/// <item>Original Type: _19_0_3_68e0225_1678250723151_758937_18560</item>
				/// <item>Type: MeasurementValueClass</item>
				/// <item>Namespace: Mtconnect.ObservationInformationModel.ObservationTypes.EventTypes</item>
				/// </list>
				/// </remarks>
				/// </summary>
				public System.Type Type => typeof(Mtconnect.ObservationInformationModel.ObservationTypes.EventTypes.MeasurementValueClass);
				
				/// <inheritdoc />
				public string Name => "ObservesMeasurementValue";
				
				/// <inheritdoc />
				public string Summary => @"/// <see cref=""Component"">Component</see> that provides information related to an individual <i>feature</i>.";

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