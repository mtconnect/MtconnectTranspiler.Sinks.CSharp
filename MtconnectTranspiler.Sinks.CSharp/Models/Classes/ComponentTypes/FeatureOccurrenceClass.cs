#pragma warning disable CS0109 // Member does not hide an inherited member; new keyword is not required
#pragma warning disable CS1574 // XML comment has cref attribute that could not be resolved
#pragma warning disable CS1584 // XML comment has syntactically incorrect cref attribute
using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;
using System.Linq;

namespace Mtconnect.DeviceInformationModel.Components.ComponentTypes
{
	/// <summary>﻿<see cref="Component">Component</see> that provides information related to an individual <i>feature</i>.<br /><br /><br />
	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Structure___19_0_3_68e0225_1678029650656_503771_494">model.mtconnect.org</seealso> for more information.
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public sealed class FeatureOccurrenceClass : IClass
	{
		/// <inheritdoc />
		public string ReferenceId => "_19_0_3_68e0225_1678029650656_503771_494";
		
		/// <inheritdoc />
		public string Summary => @"&#10;&#10;&#10;{{block(Component)}} that provides information related to an individual {{term(feature)}}.&#10;
";

		/// <inheritdoc />
		public string Name => "FeatureOccurrence";
		
		/// <inheritdoc />
		public string AccessModifier => "public";
				
		/// <inheritdoc />
		public string Modifier => "";
				
		/// <inheritdoc />
		public string NormativeVersion => "2.2";
				
		/// <inheritdoc />
		public string DeprecatedVersion => "";
		
		/// <inheritdoc />
		/// <remarks>
		/// Original Type: _19_0_3_68e0225_1605547467172_656422_264
		/// </remarks>
		public Type Generalization => typeof(Mtconnect.DeviceInformationModel.Components.ComponentTypes.PartOccurrenceClass);

		/// <inheritdoc />
		public new FeatureOccurrenceClassProperties Properties { get; } = new FeatureOccurrenceClassProperties();
        IPropertyList IClass.Properties => Properties;
		/// <summary>
		/// Property list for <see cref="FeatureOccurrenceClass" />.
		/// <br/><b>Note</b>, some properties (<see cref="IProperty" />) are inherited from <see cref="Mtconnect.DeviceInformationModel.Components.ComponentTypes.PartOccurrenceClass.PartOccurrenceClassProperties" />.
		/// </summary>
		public class FeatureOccurrenceClassProperties : Mtconnect.DeviceInformationModel.Components.ComponentTypes.PartOccurrenceClass.PartOccurrenceClassProperties
		{
			/// <inheritdoc />
			public override IProperty[] Properties => new IProperty[] {
				ObservesFeaturePersisitentId,
				ObservesFeatureMeasurement,
				ObservesMeasurementType,
				ObservesCharacteristicPersistentId,
				ObservesCharacteristicStatus,
				ObservesUncertainty,
				ObservesUncertaintyType,
				ObservesMeasurementUnits,
				ObservesMeasurementValue,
			}.Concat(base.Properties).ToArray();
			/// <summary>
			/// <inheritdoc cref="ObservesFeaturePersisitentIdProperty" path="/summary" /><br/>
			/// <remarks>Original Name: ObservesFeaturePersisitentId</remarks>
			/// </summary>
			public new ObservesFeaturePersisitentIdProperty ObservesFeaturePersisitentId { get; } = new ObservesFeaturePersisitentIdProperty();
			
			/// <summary>﻿
			/// </summary>
			public new sealed class ObservesFeaturePersisitentIdProperty : IProperty
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
				public string Name => "observesFeaturePersisitentId";
				
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
			/// <inheritdoc cref="ObservesFeatureMeasurementProperty" path="/summary" /><br/>
			/// <remarks>Original Name: ObservesFeatureMeasurement</remarks>
			/// </summary>
			public new ObservesFeatureMeasurementProperty ObservesFeatureMeasurement { get; } = new ObservesFeatureMeasurementProperty();
			
			/// <summary>﻿
			/// </summary>
			public new sealed class ObservesFeatureMeasurementProperty : IProperty
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
				public string Name => "observesFeatureMeasurement";
				
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
			/// <inheritdoc cref="ObservesMeasurementTypeProperty" path="/summary" /><br/>
			/// <remarks>Original Name: ObservesMeasurementType</remarks>
			/// </summary>
			public new ObservesMeasurementTypeProperty ObservesMeasurementType { get; } = new ObservesMeasurementTypeProperty();
			
			/// <summary>﻿
			/// </summary>
			public new sealed class ObservesMeasurementTypeProperty : IProperty
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
				public string Name => "observesMeasurementType";
				
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
			/// <inheritdoc cref="ObservesCharacteristicPersistentIdProperty" path="/summary" /><br/>
			/// <remarks>Original Name: ObservesCharacteristicPersistentId</remarks>
			/// </summary>
			public new ObservesCharacteristicPersistentIdProperty ObservesCharacteristicPersistentId { get; } = new ObservesCharacteristicPersistentIdProperty();
			
			/// <summary>﻿
			/// </summary>
			public new sealed class ObservesCharacteristicPersistentIdProperty : IProperty
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
				public string Name => "observesCharacteristicPersistentId";
				
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
			/// <inheritdoc cref="ObservesCharacteristicStatusProperty" path="/summary" /><br/>
			/// <remarks>Original Name: ObservesCharacteristicStatus</remarks>
			/// </summary>
			public new ObservesCharacteristicStatusProperty ObservesCharacteristicStatus { get; } = new ObservesCharacteristicStatusProperty();
			
			/// <summary>﻿
			/// </summary>
			public new sealed class ObservesCharacteristicStatusProperty : IProperty
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
				public string Name => "observesCharacteristicStatus";
				
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
			/// <inheritdoc cref="ObservesUncertaintyProperty" path="/summary" /><br/>
			/// <remarks>Original Name: ObservesUncertainty</remarks>
			/// </summary>
			public new ObservesUncertaintyProperty ObservesUncertainty { get; } = new ObservesUncertaintyProperty();
			
			/// <summary>﻿
			/// </summary>
			public new sealed class ObservesUncertaintyProperty : IProperty
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
				public string Name => "observesUncertainty";
				
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
			/// <inheritdoc cref="ObservesUncertaintyTypeProperty" path="/summary" /><br/>
			/// <remarks>Original Name: ObservesUncertaintyType</remarks>
			/// </summary>
			public new ObservesUncertaintyTypeProperty ObservesUncertaintyType { get; } = new ObservesUncertaintyTypeProperty();
			
			/// <summary>﻿
			/// </summary>
			public new sealed class ObservesUncertaintyTypeProperty : IProperty
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
				public string Name => "observesUncertaintyType";
				
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
			/// <inheritdoc cref="ObservesMeasurementUnitsProperty" path="/summary" /><br/>
			/// <remarks>Original Name: ObservesMeasurementUnits</remarks>
			/// </summary>
			public new ObservesMeasurementUnitsProperty ObservesMeasurementUnits { get; } = new ObservesMeasurementUnitsProperty();
			
			/// <summary>﻿
			/// </summary>
			public new sealed class ObservesMeasurementUnitsProperty : IProperty
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
				public string Name => "observesMeasurementUnits";
				
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
			/// <inheritdoc cref="ObservesMeasurementValueProperty" path="/summary" /><br/>
			/// <remarks>Original Name: ObservesMeasurementValue</remarks>
			/// </summary>
			public new ObservesMeasurementValueProperty ObservesMeasurementValue { get; } = new ObservesMeasurementValueProperty();
			
			/// <summary>﻿
			/// </summary>
			public new sealed class ObservesMeasurementValueProperty : IProperty
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
				public string Name => "observesMeasurementValue";
				
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