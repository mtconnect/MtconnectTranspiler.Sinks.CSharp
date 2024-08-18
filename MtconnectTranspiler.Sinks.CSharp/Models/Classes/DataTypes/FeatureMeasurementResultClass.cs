#pragma warning disable CS0109 // Member does not hide an inherited member; new keyword is not required
#pragma warning disable CS1574 // XML comment has cref attribute that could not be resolved
#pragma warning disable CS1584 // XML comment has syntactically incorrect cref attribute
using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;
using System.Linq;

namespace Mtconnect.DataTypes
{
	/// <summary>﻿
	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Structure___19_0_3_68e0225_1678194789732_239714_17210">model.mtconnect.org</seealso> for more information.
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public sealed class FeatureMeasurementResultClass : IClass
	{
		/// <inheritdoc />
		public string ReferenceId => "_19_0_3_68e0225_1678194789732_239714_17210";
		
		/// <inheritdoc />
		public string Summary => @"";

		/// <inheritdoc />
		public string Name => "FeatureMeasurementResult";
		
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
		/// Original Type: _19_0_3_45f01b9_1582846972437_483160_2181
		/// </remarks>
		public Type Generalization => typeof(Mtconnect.ObservationInformationModel.Representations.TableClass);

		/// <inheritdoc />
		public new FeatureMeasurementResultClassProperties Properties { get; } = new FeatureMeasurementResultClassProperties();
        IPropertyList IClass.Properties => Properties;
		/// <summary>
		/// Property list for <see cref="FeatureMeasurementResultClass" />.
		/// <br/><b>Note</b>, some properties (<see cref="IProperty" />) are inherited from <see cref="Mtconnect.ObservationInformationModel.Representations.TableClass.TableClassProperties" />.
		/// </summary>
		public class FeatureMeasurementResultClassProperties : Mtconnect.ObservationInformationModel.Representations.TableClass.TableClassProperties
		{
			/// <inheritdoc />
			public override IProperty[] Properties => new IProperty[] {
				MeasurementId,
				FeaturePersistentId,
				CharacteristicPersistentId,
				MeasurementType,
				MeasurementValue,
				MeasurementUnits,
				CharacteristicStatus,
				UncertaintyType,
				Uncertainty,
			}.Concat(base.Properties).ToArray();
			/// <summary>
			/// <inheritdoc cref="MeasurementIdProperty" path="/summary" /><br/>
			/// <remarks>Original Name: MeasurementId</remarks>
			/// </summary>
			public new MeasurementIdProperty MeasurementId { get; } = new MeasurementIdProperty();
			
			/// <summary>﻿identifier of this measurement.<br /><br /><br />
			/// </summary>
			public new sealed class MeasurementIdProperty : IProperty
			{
				/// <summary>
				/// <inheritdoc />
				/// <remarks>
				/// <list type="bullet">
				/// <item>Original Type: _19_0_3_91b028d_1579272245466_691733_672</item>
				/// <item>Type: String</item>
				/// <item>Namespace: </item>
				/// </list>
				/// </remarks>
				/// </summary>
				public System.Type Type => typeof(String);
				
				/// <inheritdoc />
				public string Name => "MeasurementId";
				
				/// <inheritdoc />
				public string Summary => @"&#10;&#10;&#10;identifier of this measurement.&#10;
";

				/// <inheritdoc />
				public string AccessModifier => "private";
				
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
			/// <inheritdoc cref="FeaturePersistentIdProperty" path="/summary" /><br/>
			/// <remarks>Original Name: FeaturePersistentId</remarks>
			/// </summary>
			public new FeaturePersistentIdProperty FeaturePersistentId { get; } = new FeaturePersistentIdProperty();
			
			/// <summary>﻿<i>UUID</i> of the feature.<br /><br /><br />
			/// </summary>
			public new sealed class FeaturePersistentIdProperty : IProperty
			{
				/// <summary>
				/// <inheritdoc />
				/// <remarks>
				/// <list type="bullet">
				/// <item>Original Type: _19_0_3_91b028d_1579272245466_691733_672</item>
				/// <item>Type: String</item>
				/// <item>Namespace: </item>
				/// </list>
				/// </remarks>
				/// </summary>
				public System.Type Type => typeof(String);
				
				/// <inheritdoc />
				public string Name => "FeaturePersistentId";
				
				/// <inheritdoc />
				public string Summary => @"&#10;&#10;&#10;{{term(UUID)}} of the feature.&#10;
";

				/// <inheritdoc />
				public string AccessModifier => "public";
				
				/// <inheritdoc />
				public string Modifier => "";
				
				/// <inheritdoc />
				public string NormativeVersion => "2.2";
				
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
			/// <inheritdoc cref="CharacteristicPersistentIdProperty" path="/summary" /><br/>
			/// <remarks>Original Name: CharacteristicPersistentId</remarks>
			/// </summary>
			public new CharacteristicPersistentIdProperty CharacteristicPersistentId { get; } = new CharacteristicPersistentIdProperty();
			
			/// <summary>﻿<i>UUID</i> of the characteristic.<br /><br /><br />
			/// </summary>
			public new sealed class CharacteristicPersistentIdProperty : IProperty
			{
				/// <summary>
				/// <inheritdoc />
				/// <remarks>
				/// <list type="bullet">
				/// <item>Original Type: _19_0_3_91b028d_1579272245466_691733_672</item>
				/// <item>Type: String</item>
				/// <item>Namespace: </item>
				/// </list>
				/// </remarks>
				/// </summary>
				public System.Type Type => typeof(String);
				
				/// <inheritdoc />
				public string Name => "CharacteristicPersistentId";
				
				/// <inheritdoc />
				public string Summary => @"&#10;&#10;&#10;{{term(UUID)}} of the characteristic.&#10;
";

				/// <inheritdoc />
				public string AccessModifier => "public";
				
				/// <inheritdoc />
				public string Modifier => "";
				
				/// <inheritdoc />
				public string NormativeVersion => "2.2";
				
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
			/// <inheritdoc cref="MeasurementTypeProperty" path="/summary" /><br/>
			/// <remarks>Original Name: MeasurementType</remarks>
			/// </summary>
			public new MeasurementTypeProperty MeasurementType { get; } = new MeasurementTypeProperty();
			
			/// <summary>﻿class of measurement being performed. <seealso href="https://www.google.com/search?q=QIF 3:2018 Section 6.3&btnI=I">QIF 3:2018 Section 6.3</seealso><br /><br />Examples: <c>POINT</c>, <c>RADIUS</c>, <c>ANGLE</c>, <c>LENGTH</c>, etc.<br /><br /><br />
			/// </summary>
			public new sealed class MeasurementTypeProperty : IProperty
			{
				/// <summary>
				/// <inheritdoc />
				/// <remarks>
				/// <list type="bullet">
				/// <item>Original Type: _19_0_3_91b028d_1579272360416_763325_681</item>
				/// <item>Type: String</item>
				/// <item>Namespace: </item>
				/// </list>
				/// </remarks>
				/// </summary>
				public System.Type Type => typeof(String);
				
				/// <inheritdoc />
				public string Name => "MeasurementType";
				
				/// <inheritdoc />
				public string Summary => @"&#10;&#10;&#10;class of measurement being performed. {{cite(QIF 3:2018 Section 6.3)}}

Examples: `POINT`, `RADIUS`, `ANGLE`, `LENGTH`, etc.&#10;
";

				/// <inheritdoc />
				public string AccessModifier => "public";
				
				/// <inheritdoc />
				public string Modifier => "";
				
				/// <inheritdoc />
				public string NormativeVersion => "2.2";
				
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
			/// <inheritdoc cref="MeasurementValueProperty" path="/summary" /><br/>
			/// <remarks>Original Name: MeasurementValue</remarks>
			/// </summary>
			public new MeasurementValueProperty MeasurementValue { get; } = new MeasurementValueProperty();
			
			/// <summary>﻿measurement based on the measurement type.<br /><br /><br />
			/// </summary>
			public new sealed class MeasurementValueProperty : IProperty
			{
				/// <summary>
				/// <inheritdoc />
				/// <remarks>
				/// <list type="bullet">
				/// <item>Original Type: _19_0_3_91b028d_1579272506322_914606_702</item>
				/// <item>Type: Single</item>
				/// <item>Namespace: </item>
				/// </list>
				/// </remarks>
				/// </summary>
				public System.Type Type => typeof(Single);
				
				/// <inheritdoc />
				public string Name => "MeasurementValue";
				
				/// <inheritdoc />
				public string Summary => @"&#10;&#10;&#10;measurement based on the measurement type.&#10;
";

				/// <inheritdoc />
				public string AccessModifier => "public";
				
				/// <inheritdoc />
				public string Modifier => "";
				
				/// <inheritdoc />
				public string NormativeVersion => "2.2";
				
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
			/// <inheritdoc cref="MeasurementUnitsProperty" path="/summary" /><br/>
			/// <remarks>Original Name: MeasurementUnits</remarks>
			/// </summary>
			public new MeasurementUnitsProperty MeasurementUnits { get; } = new MeasurementUnitsProperty();
			
			/// <summary>﻿engineering units of the measurement.<br /><br /><br />
			/// </summary>
			public new sealed class MeasurementUnitsProperty : IProperty
			{
				/// <summary>
				/// <inheritdoc />
				/// <remarks>
				/// <list type="bullet">
				/// <item>Original Type: _19_0_3_91b028d_1579272360416_763325_681</item>
				/// <item>Type: String</item>
				/// <item>Namespace: </item>
				/// </list>
				/// </remarks>
				/// </summary>
				public System.Type Type => typeof(String);
				
				/// <inheritdoc />
				public string Name => "MeasurementUnits";
				
				/// <inheritdoc />
				public string Summary => @"&#10;&#10;&#10;engineering units of the measurement.&#10;
";

				/// <inheritdoc />
				public string AccessModifier => "public";
				
				/// <inheritdoc />
				public string Modifier => "";
				
				/// <inheritdoc />
				public string NormativeVersion => "2.2";
				
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
			/// <inheritdoc cref="CharacteristicStatusProperty" path="/summary" /><br/>
			/// <remarks>Original Name: CharacteristicStatus</remarks>
			/// </summary>
			public new CharacteristicStatusProperty CharacteristicStatus { get; } = new CharacteristicStatusProperty();
			
			/// <summary>﻿pass/fail result of the measurement.<br /><br /><br />
			/// </summary>
			public new sealed class CharacteristicStatusProperty : IProperty
			{
				/// <summary>
				/// <inheritdoc />
				/// <remarks>
				/// <list type="bullet">
				/// <item>Original Type: _19_0_3_68e0225_1678195723846_572772_17405</item>
				/// <item>Type: CharacteristicStatusEnumMetaClass</item>
				/// <item>Namespace: Mtconnect.DataTypes</item>
				/// </list>
				/// </remarks>
				/// </summary>
				public System.Type Type => typeof(Mtconnect.DataTypes.CharacteristicStatusEnumMetaClass);
				
				/// <inheritdoc />
				public string Name => "CharacteristicStatus";
				
				/// <inheritdoc />
				public string Summary => @"&#10;&#10;&#10;pass/fail result of the measurement.&#10;
";

				/// <inheritdoc />
				public string AccessModifier => "public";
				
				/// <inheritdoc />
				public string Modifier => "";
				
				/// <inheritdoc />
				public string NormativeVersion => "2.2";
				
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
			/// <inheritdoc cref="UncertaintyTypeProperty" path="/summary" /><br/>
			/// <remarks>Original Name: UncertaintyType</remarks>
			/// </summary>
			public new UncertaintyTypeProperty UncertaintyType { get; } = new UncertaintyTypeProperty();
			
			/// <summary>﻿method used to compute <i>standard uncertainty</i>.<br /><br /><br />
			/// </summary>
			public new sealed class UncertaintyTypeProperty : IProperty
			{
				/// <summary>
				/// <inheritdoc />
				/// <remarks>
				/// <list type="bullet">
				/// <item>Original Type: _19_0_3_68e0225_1678195766304_380006_17434</item>
				/// <item>Type: UncertaintyTypeEnumMetaClass</item>
				/// <item>Namespace: Mtconnect.DataTypes</item>
				/// </list>
				/// </remarks>
				/// </summary>
				public System.Type Type => typeof(Mtconnect.DataTypes.UncertaintyTypeEnumMetaClass);
				
				/// <inheritdoc />
				public string Name => "UncertaintyType";
				
				/// <inheritdoc />
				public string Summary => @"&#10;&#10;&#10;method used to compute {{term(standard uncertainty)}}.&#10;
";

				/// <inheritdoc />
				public string AccessModifier => "public";
				
				/// <inheritdoc />
				public string Modifier => "";
				
				/// <inheritdoc />
				public string NormativeVersion => "2.2";
				
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
			/// <inheritdoc cref="UncertaintyProperty" path="/summary" /><br/>
			/// <remarks>Original Name: Uncertainty</remarks>
			/// </summary>
			public new UncertaintyProperty Uncertainty { get; } = new UncertaintyProperty();
			
			/// <summary>﻿<i>uncertainty</i> specified by <c>UNCERTAINTY_TYPE</c>.<br /><br /><br />
			/// </summary>
			public new sealed class UncertaintyProperty : IProperty
			{
				/// <summary>
				/// <inheritdoc />
				/// <remarks>
				/// <list type="bullet">
				/// <item>Original Type: _19_0_3_91b028d_1579272506322_914606_702</item>
				/// <item>Type: Single</item>
				/// <item>Namespace: </item>
				/// </list>
				/// </remarks>
				/// </summary>
				public System.Type Type => typeof(Single);
				
				/// <inheritdoc />
				public string Name => "Uncertainty";
				
				/// <inheritdoc />
				public string Summary => @"&#10;&#10;&#10;{{term(uncertainty)}} specified by `UNCERTAINTY_TYPE`.&#10;
";

				/// <inheritdoc />
				public string AccessModifier => "public";
				
				/// <inheritdoc />
				public string Modifier => "";
				
				/// <inheritdoc />
				public string NormativeVersion => "2.2";
				
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