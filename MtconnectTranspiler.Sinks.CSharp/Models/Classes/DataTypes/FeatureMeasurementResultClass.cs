#pragma warning disable CS0109 // Member does not hide an inherited member; new keyword is not required
#pragma warning disable CS1574 // XML comment has cref attribute that could not be resolved
#pragma warning disable CS1584 // XML comment has syntactically incorrect cref attribute
#pragma warning disable CS0618 // Type or member is obsolete
using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;
using System.Linq;

namespace Mtconnect.DataTypes
{
	/// <summary>﻿
	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Structure___19_0_3_68e0225_1678194789732_239714_17210">model.mtconnect.org</seealso> for more information.
	/// </summary>
	/// <remarks>
	/// <list type="bullet">
	/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_2.2">v2.2</see></item>
	/// </list>
	/// </remarks>

	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public sealed class FeatureMeasurementResultClass : IClass
	{
		/// <summary>Constant value for <see cref="FeatureMeasurementResultClass.ReferenceId" /></summary>
		public const string REFERENCE_ID = "_19_0_3_68e0225_1678194789732_239714_17210";
		/// <summary>Constant value for <see cref="FeatureMeasurementResultClass.HelpUrl" /></summary>
		public const string HELP_URL = "https://model.mtconnect.org/#Structure___19_0_3_68e0225_1678194789732_239714_17210";
		/// <summary>Constant value for <see cref="FeatureMeasurementResultClass.Summary" /></summary>
		public const string SUMMARY = @"";
		/// <summary>Constant value for <see cref="FeatureMeasurementResultClass.Name" /></summary>
		public const string NAME = "FeatureMeasurementResult";
		/// <summary>Constant value for <see cref="FeatureMeasurementResultClass.AccessModifier" /></summary>
		public const string ACCESS_MODIFIER = "public";
		/// <summary>Constant value for <see cref="FeatureMeasurementResultClass.Modifier" /></summary>
		public const string MODIFIER = "";
		/// <summary>Constant value for <see cref="FeatureMeasurementResultClass.NormativeVersion" /></summary>
		public const string NORMATIVE_VERSION = "2.2";
		/// <summary>Constant value for <see cref="FeatureMeasurementResultClass.DeprecatedVersion" /></summary>
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
				/// <summary>Constant value for <see cref="MeasurementIdProperty.Name" /></summary>
				public const string NAME = "MeasurementId";
				/// <summary>Constant value for <see cref="MeasurementIdProperty.Summary" /></summary>
				public const string SUMMARY = @"&#10;&#10;&#10;identifier of this measurement.&#10;
";
				/// <summary>Constant value for <see cref="MeasurementIdProperty.AccessModifier" /></summary>
				public const string ACCESS_MODIFIER = "private";
				/// <summary>Constant value for <see cref="MeasurementIdProperty.Modifier" /></summary>
				public const string MODIFIER = "";
				/// <summary>Constant value for <see cref="MeasurementIdProperty.NormativeVersion" /></summary>
				public const string NORMATIVE_VERSION = "";
				/// <summary>Constant value for <see cref="MeasurementIdProperty.DeprecatedVersion" /></summary>
				public const string DEPRECATED_VERSION = "";
				/// <summary>Constant value for <see cref="MeasurementIdProperty.Aggregation" /></summary>
				public const string AGGREGATION = "composite";
				/// <summary>Constant value for <see cref="MeasurementIdProperty.Extension" /></summary>
				public const string EXTENSION = "MagicDraw UML 2024x";
				/// <summary>Constant value for <see cref="MeasurementIdProperty.Association" /></summary>
				public const string ASSOCIATION = "";
				/// <summary>Constant value for <see cref="MeasurementIdProperty.DefaultValue" /></summary>
				public const string DEFAULT_VALUE = "";

				/// <summary>
				/// <inheritdoc />
				/// <remarks> Type: String </remarks>
				/// </summary>
				public System.Type Type => typeof(String);
				
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
			/// <inheritdoc cref="FeaturePersistentIdProperty" path="/summary" /><br/>
			/// <remarks>Original Name: FeaturePersistentId</remarks>
			/// </summary>
			public new FeaturePersistentIdProperty FeaturePersistentId { get; } = new FeaturePersistentIdProperty();
			
			/// <summary>﻿<i>UUID</i> of the feature.<br /><br /><br />
			/// </summary>
			public new sealed class FeaturePersistentIdProperty : IProperty
			{
				/// <summary>Constant value for <see cref="FeaturePersistentIdProperty.Name" /></summary>
				public const string NAME = "FeaturePersistentId";
				/// <summary>Constant value for <see cref="FeaturePersistentIdProperty.Summary" /></summary>
				public const string SUMMARY = @"&#10;&#10;&#10;{{term(UUID)}} of the feature.&#10;
";
				/// <summary>Constant value for <see cref="FeaturePersistentIdProperty.AccessModifier" /></summary>
				public const string ACCESS_MODIFIER = "public";
				/// <summary>Constant value for <see cref="FeaturePersistentIdProperty.Modifier" /></summary>
				public const string MODIFIER = "";
				/// <summary>Constant value for <see cref="FeaturePersistentIdProperty.NormativeVersion" /></summary>
				public const string NORMATIVE_VERSION = "2.2";
				/// <summary>Constant value for <see cref="FeaturePersistentIdProperty.DeprecatedVersion" /></summary>
				public const string DEPRECATED_VERSION = "";
				/// <summary>Constant value for <see cref="FeaturePersistentIdProperty.Aggregation" /></summary>
				public const string AGGREGATION = "composite";
				/// <summary>Constant value for <see cref="FeaturePersistentIdProperty.Extension" /></summary>
				public const string EXTENSION = "MagicDraw UML 2024x";
				/// <summary>Constant value for <see cref="FeaturePersistentIdProperty.Association" /></summary>
				public const string ASSOCIATION = "";
				/// <summary>Constant value for <see cref="FeaturePersistentIdProperty.DefaultValue" /></summary>
				public const string DEFAULT_VALUE = "";

				/// <summary>
				/// <inheritdoc />
				/// <remarks> Type: String </remarks>
				/// </summary>
				public System.Type Type => typeof(String);
				
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
			/// <inheritdoc cref="CharacteristicPersistentIdProperty" path="/summary" /><br/>
			/// <remarks>Original Name: CharacteristicPersistentId</remarks>
			/// </summary>
			public new CharacteristicPersistentIdProperty CharacteristicPersistentId { get; } = new CharacteristicPersistentIdProperty();
			
			/// <summary>﻿<i>UUID</i> of the characteristic.<br /><br /><br />
			/// </summary>
			public new sealed class CharacteristicPersistentIdProperty : IProperty
			{
				/// <summary>Constant value for <see cref="CharacteristicPersistentIdProperty.Name" /></summary>
				public const string NAME = "CharacteristicPersistentId";
				/// <summary>Constant value for <see cref="CharacteristicPersistentIdProperty.Summary" /></summary>
				public const string SUMMARY = @"&#10;&#10;&#10;{{term(UUID)}} of the characteristic.&#10;
";
				/// <summary>Constant value for <see cref="CharacteristicPersistentIdProperty.AccessModifier" /></summary>
				public const string ACCESS_MODIFIER = "public";
				/// <summary>Constant value for <see cref="CharacteristicPersistentIdProperty.Modifier" /></summary>
				public const string MODIFIER = "";
				/// <summary>Constant value for <see cref="CharacteristicPersistentIdProperty.NormativeVersion" /></summary>
				public const string NORMATIVE_VERSION = "2.2";
				/// <summary>Constant value for <see cref="CharacteristicPersistentIdProperty.DeprecatedVersion" /></summary>
				public const string DEPRECATED_VERSION = "";
				/// <summary>Constant value for <see cref="CharacteristicPersistentIdProperty.Aggregation" /></summary>
				public const string AGGREGATION = "composite";
				/// <summary>Constant value for <see cref="CharacteristicPersistentIdProperty.Extension" /></summary>
				public const string EXTENSION = "MagicDraw UML 2024x";
				/// <summary>Constant value for <see cref="CharacteristicPersistentIdProperty.Association" /></summary>
				public const string ASSOCIATION = "";
				/// <summary>Constant value for <see cref="CharacteristicPersistentIdProperty.DefaultValue" /></summary>
				public const string DEFAULT_VALUE = "";

				/// <summary>
				/// <inheritdoc />
				/// <remarks> Type: String </remarks>
				/// </summary>
				public System.Type Type => typeof(String);
				
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
			/// <inheritdoc cref="MeasurementTypeProperty" path="/summary" /><br/>
			/// <remarks>Original Name: MeasurementType</remarks>
			/// </summary>
			public new MeasurementTypeProperty MeasurementType { get; } = new MeasurementTypeProperty();
			
			/// <summary>﻿class of measurement being performed. <seealso href="https://www.google.com/search?q=QIF 3:2018 Section 6.3&amp;btnI=I">QIF 3:2018 Section 6.3</seealso><br /><br />Examples: <c>POINT</c>, <c>RADIUS</c>, <c>ANGLE</c>, <c>LENGTH</c>, etc.<br /><br /><br />
			/// </summary>
			public new sealed class MeasurementTypeProperty : IProperty
			{
				/// <summary>Constant value for <see cref="MeasurementTypeProperty.Name" /></summary>
				public const string NAME = "MeasurementType";
				/// <summary>Constant value for <see cref="MeasurementTypeProperty.Summary" /></summary>
				public const string SUMMARY = @"&#10;&#10;&#10;class of measurement being performed. {{cite(QIF 3:2018 Section 6.3)}}

Examples: `POINT`, `RADIUS`, `ANGLE`, `LENGTH`, etc.&#10;
";
				/// <summary>Constant value for <see cref="MeasurementTypeProperty.AccessModifier" /></summary>
				public const string ACCESS_MODIFIER = "public";
				/// <summary>Constant value for <see cref="MeasurementTypeProperty.Modifier" /></summary>
				public const string MODIFIER = "";
				/// <summary>Constant value for <see cref="MeasurementTypeProperty.NormativeVersion" /></summary>
				public const string NORMATIVE_VERSION = "2.2";
				/// <summary>Constant value for <see cref="MeasurementTypeProperty.DeprecatedVersion" /></summary>
				public const string DEPRECATED_VERSION = "";
				/// <summary>Constant value for <see cref="MeasurementTypeProperty.Aggregation" /></summary>
				public const string AGGREGATION = "composite";
				/// <summary>Constant value for <see cref="MeasurementTypeProperty.Extension" /></summary>
				public const string EXTENSION = "MagicDraw UML 2024x";
				/// <summary>Constant value for <see cref="MeasurementTypeProperty.Association" /></summary>
				public const string ASSOCIATION = "";
				/// <summary>Constant value for <see cref="MeasurementTypeProperty.DefaultValue" /></summary>
				public const string DEFAULT_VALUE = "";

				/// <summary>
				/// <inheritdoc />
				/// <remarks> Type: String </remarks>
				/// </summary>
				public System.Type Type => typeof(String);
				
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
			/// <inheritdoc cref="MeasurementValueProperty" path="/summary" /><br/>
			/// <remarks>Original Name: MeasurementValue</remarks>
			/// </summary>
			public new MeasurementValueProperty MeasurementValue { get; } = new MeasurementValueProperty();
			
			/// <summary>﻿measurement based on the measurement type.<br /><br /><br />
			/// </summary>
			public new sealed class MeasurementValueProperty : IProperty
			{
				/// <summary>Constant value for <see cref="MeasurementValueProperty.Name" /></summary>
				public const string NAME = "MeasurementValue";
				/// <summary>Constant value for <see cref="MeasurementValueProperty.Summary" /></summary>
				public const string SUMMARY = @"&#10;&#10;&#10;measurement based on the measurement type.&#10;
";
				/// <summary>Constant value for <see cref="MeasurementValueProperty.AccessModifier" /></summary>
				public const string ACCESS_MODIFIER = "public";
				/// <summary>Constant value for <see cref="MeasurementValueProperty.Modifier" /></summary>
				public const string MODIFIER = "";
				/// <summary>Constant value for <see cref="MeasurementValueProperty.NormativeVersion" /></summary>
				public const string NORMATIVE_VERSION = "2.2";
				/// <summary>Constant value for <see cref="MeasurementValueProperty.DeprecatedVersion" /></summary>
				public const string DEPRECATED_VERSION = "";
				/// <summary>Constant value for <see cref="MeasurementValueProperty.Aggregation" /></summary>
				public const string AGGREGATION = "composite";
				/// <summary>Constant value for <see cref="MeasurementValueProperty.Extension" /></summary>
				public const string EXTENSION = "MagicDraw UML 2024x";
				/// <summary>Constant value for <see cref="MeasurementValueProperty.Association" /></summary>
				public const string ASSOCIATION = "";
				/// <summary>Constant value for <see cref="MeasurementValueProperty.DefaultValue" /></summary>
				public const string DEFAULT_VALUE = "";

				/// <summary>
				/// <inheritdoc />
				/// <remarks> Type: Single </remarks>
				/// </summary>
				public System.Type Type => typeof(Single);
				
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
			/// <inheritdoc cref="MeasurementUnitsProperty" path="/summary" /><br/>
			/// <remarks>Original Name: MeasurementUnits</remarks>
			/// </summary>
			public new MeasurementUnitsProperty MeasurementUnits { get; } = new MeasurementUnitsProperty();
			
			/// <summary>﻿engineering units of the measurement.<br /><br /><br />
			/// </summary>
			public new sealed class MeasurementUnitsProperty : IProperty
			{
				/// <summary>Constant value for <see cref="MeasurementUnitsProperty.Name" /></summary>
				public const string NAME = "MeasurementUnits";
				/// <summary>Constant value for <see cref="MeasurementUnitsProperty.Summary" /></summary>
				public const string SUMMARY = @"&#10;&#10;&#10;engineering units of the measurement.&#10;
";
				/// <summary>Constant value for <see cref="MeasurementUnitsProperty.AccessModifier" /></summary>
				public const string ACCESS_MODIFIER = "public";
				/// <summary>Constant value for <see cref="MeasurementUnitsProperty.Modifier" /></summary>
				public const string MODIFIER = "";
				/// <summary>Constant value for <see cref="MeasurementUnitsProperty.NormativeVersion" /></summary>
				public const string NORMATIVE_VERSION = "2.2";
				/// <summary>Constant value for <see cref="MeasurementUnitsProperty.DeprecatedVersion" /></summary>
				public const string DEPRECATED_VERSION = "";
				/// <summary>Constant value for <see cref="MeasurementUnitsProperty.Aggregation" /></summary>
				public const string AGGREGATION = "composite";
				/// <summary>Constant value for <see cref="MeasurementUnitsProperty.Extension" /></summary>
				public const string EXTENSION = "MagicDraw UML 2024x";
				/// <summary>Constant value for <see cref="MeasurementUnitsProperty.Association" /></summary>
				public const string ASSOCIATION = "";
				/// <summary>Constant value for <see cref="MeasurementUnitsProperty.DefaultValue" /></summary>
				public const string DEFAULT_VALUE = "";

				/// <summary>
				/// <inheritdoc />
				/// <remarks> Type: String </remarks>
				/// </summary>
				public System.Type Type => typeof(String);
				
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
			/// <inheritdoc cref="CharacteristicStatusProperty" path="/summary" /><br/>
			/// <remarks>Original Name: CharacteristicStatus</remarks>
			/// </summary>
			public new CharacteristicStatusProperty CharacteristicStatus { get; } = new CharacteristicStatusProperty();
			
			/// <summary>﻿pass/fail result of the measurement.<br /><br /><br />
			/// </summary>
			public new sealed class CharacteristicStatusProperty : IProperty
			{
				/// <summary>Constant value for <see cref="CharacteristicStatusProperty.Name" /></summary>
				public const string NAME = "CharacteristicStatus";
				/// <summary>Constant value for <see cref="CharacteristicStatusProperty.Summary" /></summary>
				public const string SUMMARY = @"&#10;&#10;&#10;pass/fail result of the measurement.&#10;
";
				/// <summary>Constant value for <see cref="CharacteristicStatusProperty.AccessModifier" /></summary>
				public const string ACCESS_MODIFIER = "public";
				/// <summary>Constant value for <see cref="CharacteristicStatusProperty.Modifier" /></summary>
				public const string MODIFIER = "";
				/// <summary>Constant value for <see cref="CharacteristicStatusProperty.NormativeVersion" /></summary>
				public const string NORMATIVE_VERSION = "2.2";
				/// <summary>Constant value for <see cref="CharacteristicStatusProperty.DeprecatedVersion" /></summary>
				public const string DEPRECATED_VERSION = "";
				/// <summary>Constant value for <see cref="CharacteristicStatusProperty.Aggregation" /></summary>
				public const string AGGREGATION = "composite";
				/// <summary>Constant value for <see cref="CharacteristicStatusProperty.Extension" /></summary>
				public const string EXTENSION = "MagicDraw UML 2024x";
				/// <summary>Constant value for <see cref="CharacteristicStatusProperty.Association" /></summary>
				public const string ASSOCIATION = "";
				/// <summary>Constant value for <see cref="CharacteristicStatusProperty.DefaultValue" /></summary>
				public const string DEFAULT_VALUE = "";

				/// <summary>
				/// <inheritdoc />
				/// <remarks> Type: CharacteristicStatusEnumMetaClass </remarks>
				/// </summary>
				public System.Type Type => typeof(Mtconnect.DataTypes.CharacteristicStatusEnumMetaClass);
				
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
			/// <inheritdoc cref="UncertaintyTypeProperty" path="/summary" /><br/>
			/// <remarks>Original Name: UncertaintyType</remarks>
			/// </summary>
			public new UncertaintyTypeProperty UncertaintyType { get; } = new UncertaintyTypeProperty();
			
			/// <summary>﻿method used to compute <i>standard uncertainty</i>.<br /><br /><br />
			/// </summary>
			public new sealed class UncertaintyTypeProperty : IProperty
			{
				/// <summary>Constant value for <see cref="UncertaintyTypeProperty.Name" /></summary>
				public const string NAME = "UncertaintyType";
				/// <summary>Constant value for <see cref="UncertaintyTypeProperty.Summary" /></summary>
				public const string SUMMARY = @"&#10;&#10;&#10;method used to compute {{term(standard uncertainty)}}.&#10;
";
				/// <summary>Constant value for <see cref="UncertaintyTypeProperty.AccessModifier" /></summary>
				public const string ACCESS_MODIFIER = "public";
				/// <summary>Constant value for <see cref="UncertaintyTypeProperty.Modifier" /></summary>
				public const string MODIFIER = "";
				/// <summary>Constant value for <see cref="UncertaintyTypeProperty.NormativeVersion" /></summary>
				public const string NORMATIVE_VERSION = "2.2";
				/// <summary>Constant value for <see cref="UncertaintyTypeProperty.DeprecatedVersion" /></summary>
				public const string DEPRECATED_VERSION = "";
				/// <summary>Constant value for <see cref="UncertaintyTypeProperty.Aggregation" /></summary>
				public const string AGGREGATION = "composite";
				/// <summary>Constant value for <see cref="UncertaintyTypeProperty.Extension" /></summary>
				public const string EXTENSION = "MagicDraw UML 2024x";
				/// <summary>Constant value for <see cref="UncertaintyTypeProperty.Association" /></summary>
				public const string ASSOCIATION = "";
				/// <summary>Constant value for <see cref="UncertaintyTypeProperty.DefaultValue" /></summary>
				public const string DEFAULT_VALUE = "";

				/// <summary>
				/// <inheritdoc />
				/// <remarks> Type: UncertaintyTypeEnumMetaClass </remarks>
				/// </summary>
				public System.Type Type => typeof(Mtconnect.DataTypes.UncertaintyTypeEnumMetaClass);
				
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
			/// <inheritdoc cref="UncertaintyProperty" path="/summary" /><br/>
			/// <remarks>Original Name: Uncertainty</remarks>
			/// </summary>
			public new UncertaintyProperty Uncertainty { get; } = new UncertaintyProperty();
			
			/// <summary>﻿<i>uncertainty</i> specified by <c>UNCERTAINTY_TYPE</c>.<br /><br /><br />
			/// </summary>
			public new sealed class UncertaintyProperty : IProperty
			{
				/// <summary>Constant value for <see cref="UncertaintyProperty.Name" /></summary>
				public const string NAME = "Uncertainty";
				/// <summary>Constant value for <see cref="UncertaintyProperty.Summary" /></summary>
				public const string SUMMARY = @"&#10;&#10;&#10;{{term(uncertainty)}} specified by `UNCERTAINTY_TYPE`.&#10;
";
				/// <summary>Constant value for <see cref="UncertaintyProperty.AccessModifier" /></summary>
				public const string ACCESS_MODIFIER = "public";
				/// <summary>Constant value for <see cref="UncertaintyProperty.Modifier" /></summary>
				public const string MODIFIER = "";
				/// <summary>Constant value for <see cref="UncertaintyProperty.NormativeVersion" /></summary>
				public const string NORMATIVE_VERSION = "2.2";
				/// <summary>Constant value for <see cref="UncertaintyProperty.DeprecatedVersion" /></summary>
				public const string DEPRECATED_VERSION = "";
				/// <summary>Constant value for <see cref="UncertaintyProperty.Aggregation" /></summary>
				public const string AGGREGATION = "composite";
				/// <summary>Constant value for <see cref="UncertaintyProperty.Extension" /></summary>
				public const string EXTENSION = "MagicDraw UML 2024x";
				/// <summary>Constant value for <see cref="UncertaintyProperty.Association" /></summary>
				public const string ASSOCIATION = "";
				/// <summary>Constant value for <see cref="UncertaintyProperty.DefaultValue" /></summary>
				public const string DEFAULT_VALUE = "";

				/// <summary>
				/// <inheritdoc />
				/// <remarks> Type: Single </remarks>
				/// </summary>
				public System.Type Type => typeof(Single);
				
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