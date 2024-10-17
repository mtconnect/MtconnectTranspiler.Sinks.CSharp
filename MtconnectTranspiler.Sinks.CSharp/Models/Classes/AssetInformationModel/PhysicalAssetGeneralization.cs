#pragma warning disable CS0109 // Member does not hide an inherited member; new keyword is not required
#pragma warning disable CS1574 // XML comment has cref attribute that could not be resolved
#pragma warning disable CS1584 // XML comment has syntactically incorrect cref attribute
#pragma warning disable CS0618 // Type or member is obsolete
using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;
using System.Linq;

namespace Mtconnect.AssetInformationModel
{
	/// <summary>﻿abstract physical <see cref="Asset">Asset</see>.<br /><br /><br />
	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Structure___2024x_68e0225_1727791480187_194742_23509">model.mtconnect.org</seealso> for more information.
	/// </summary>
	/// <remarks>
	/// <list type="bullet">
	/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_2.5">v2.5</see></item>
	/// </list>
	/// </remarks>

	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public sealed class PhysicalAssetGeneralization : IClass
	{
		/// <summary>Constant value for <see cref="PhysicalAssetGeneralization.ReferenceId" /></summary>
		public const string REFERENCE_ID = "_2024x_68e0225_1727791480187_194742_23509";
		/// <summary>Constant value for <see cref="PhysicalAssetGeneralization.HelpUrl" /></summary>
		public const string HELP_URL = "https://model.mtconnect.org/#Structure___2024x_68e0225_1727791480187_194742_23509";
		/// <summary>Constant value for <see cref="PhysicalAssetGeneralization.Summary" /></summary>
		public const string SUMMARY = @"&#10;&#10;&#10;abstract physical {{block(Asset)}}.&#10;
";
		/// <summary>Constant value for <see cref="PhysicalAssetGeneralization.Name" /></summary>
		public const string NAME = "PhysicalAsset";
		/// <summary>Constant value for <see cref="PhysicalAssetGeneralization.AccessModifier" /></summary>
		public const string ACCESS_MODIFIER = "public";
		/// <summary>Constant value for <see cref="PhysicalAssetGeneralization.Modifier" /></summary>
		public const string MODIFIER = "abstract";
		/// <summary>Constant value for <see cref="PhysicalAssetGeneralization.NormativeVersion" /></summary>
		public const string NORMATIVE_VERSION = "2.5";
		/// <summary>Constant value for <see cref="PhysicalAssetGeneralization.DeprecatedVersion" /></summary>
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
		/// Original Type: EAID_C7D39183_23CB_416b_A62D_F60815E08B1A
		/// </remarks>
		public Type Generalization => typeof(Mtconnect.AssetInformationModel.AssetClass);

		/// <inheritdoc />
		public new PhysicalAssetGeneralizationProperties Properties { get; } = new PhysicalAssetGeneralizationProperties();
        IPropertyList IClass.Properties => Properties;
		/// <summary>
		/// Property list for <see cref="PhysicalAssetGeneralization" />.
		/// <br/><b>Note</b>, some properties (<see cref="IProperty" />) are inherited from <see cref="Mtconnect.AssetInformationModel.AssetClass.AssetClassProperties" />.
		/// </summary>
		public class PhysicalAssetGeneralizationProperties : Mtconnect.AssetInformationModel.AssetClass.AssetClassProperties
		{
			/// <inheritdoc />
			public override IProperty[] Properties => new IProperty[] {
				ManufactureDate,
				CalibrationDate,
				InspectionDate,
				NextInspectionDate,
				HasMeasurementPart,
			}.Concat(base.Properties).ToArray();
			/// <summary>
			/// <inheritdoc cref="ManufactureDateProperty" path="/summary" /><br/>
			/// <remarks>Original Name: ManufactureDate</remarks>
			/// </summary>
			public new ManufactureDateProperty ManufactureDate { get; } = new ManufactureDateProperty();
			
			/// <summary>﻿date of creation or built of the <see cref="Asset">Asset</see>.<br /><br /><br />
			/// </summary>
			public new sealed class ManufactureDateProperty : IProperty
			{
				/// <summary>Constant value for <see cref="ManufactureDateProperty.Name" /></summary>
				public const string NAME = "ManufactureDate";
				/// <summary>Constant value for <see cref="ManufactureDateProperty.Summary" /></summary>
				public const string SUMMARY = @"&#10;&#10;&#10;date of creation or built of the {{block(Asset)}}.&#10;
";
				/// <summary>Constant value for <see cref="ManufactureDateProperty.AccessModifier" /></summary>
				public const string ACCESS_MODIFIER = "private";
				/// <summary>Constant value for <see cref="ManufactureDateProperty.Modifier" /></summary>
				public const string MODIFIER = "";
				/// <summary>Constant value for <see cref="ManufactureDateProperty.NormativeVersion" /></summary>
				public const string NORMATIVE_VERSION = "2.5";
				/// <summary>Constant value for <see cref="ManufactureDateProperty.DeprecatedVersion" /></summary>
				public const string DEPRECATED_VERSION = "";
				/// <summary>Constant value for <see cref="ManufactureDateProperty.Aggregation" /></summary>
				public const string AGGREGATION = "composite";
				/// <summary>Constant value for <see cref="ManufactureDateProperty.Extension" /></summary>
				public const string EXTENSION = "MagicDraw UML 2024x";
				/// <summary>Constant value for <see cref="ManufactureDateProperty.Association" /></summary>
				public const string ASSOCIATION = "";
				/// <summary>Constant value for <see cref="ManufactureDateProperty.DefaultValue" /></summary>
				public const string DEFAULT_VALUE = "";

				/// <summary>
				/// <inheritdoc />
				/// <remarks> Type: DateTime </remarks>
				/// </summary>
				public System.Type Type => typeof(DateTime);
				
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
			/// <inheritdoc cref="CalibrationDateProperty" path="/summary" /><br/>
			/// <remarks>Original Name: CalibrationDate</remarks>
			/// </summary>
			public new CalibrationDateProperty CalibrationDate { get; } = new CalibrationDateProperty();
			
			/// <summary>﻿date of calibration of the <see cref="Asset">Asset</see>.<br /><br /><br />
			/// </summary>
			public new sealed class CalibrationDateProperty : IProperty
			{
				/// <summary>Constant value for <see cref="CalibrationDateProperty.Name" /></summary>
				public const string NAME = "CalibrationDate";
				/// <summary>Constant value for <see cref="CalibrationDateProperty.Summary" /></summary>
				public const string SUMMARY = @"&#10;&#10;&#10;date of calibration of the {{block(Asset)}}.&#10;
";
				/// <summary>Constant value for <see cref="CalibrationDateProperty.AccessModifier" /></summary>
				public const string ACCESS_MODIFIER = "private";
				/// <summary>Constant value for <see cref="CalibrationDateProperty.Modifier" /></summary>
				public const string MODIFIER = "";
				/// <summary>Constant value for <see cref="CalibrationDateProperty.NormativeVersion" /></summary>
				public const string NORMATIVE_VERSION = "2.5";
				/// <summary>Constant value for <see cref="CalibrationDateProperty.DeprecatedVersion" /></summary>
				public const string DEPRECATED_VERSION = "";
				/// <summary>Constant value for <see cref="CalibrationDateProperty.Aggregation" /></summary>
				public const string AGGREGATION = "composite";
				/// <summary>Constant value for <see cref="CalibrationDateProperty.Extension" /></summary>
				public const string EXTENSION = "MagicDraw UML 2024x";
				/// <summary>Constant value for <see cref="CalibrationDateProperty.Association" /></summary>
				public const string ASSOCIATION = "";
				/// <summary>Constant value for <see cref="CalibrationDateProperty.DefaultValue" /></summary>
				public const string DEFAULT_VALUE = "";

				/// <summary>
				/// <inheritdoc />
				/// <remarks> Type: DateTime </remarks>
				/// </summary>
				public System.Type Type => typeof(DateTime);
				
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
			/// <inheritdoc cref="InspectionDateProperty" path="/summary" /><br/>
			/// <remarks>Original Name: InspectionDate</remarks>
			/// </summary>
			public new InspectionDateProperty InspectionDate { get; } = new InspectionDateProperty();
			
			/// <summary>﻿date of last inspection of the <see cref="Asset">Asset</see>.<br /><br /><br />
			/// </summary>
			public new sealed class InspectionDateProperty : IProperty
			{
				/// <summary>Constant value for <see cref="InspectionDateProperty.Name" /></summary>
				public const string NAME = "InspectionDate";
				/// <summary>Constant value for <see cref="InspectionDateProperty.Summary" /></summary>
				public const string SUMMARY = @"&#10;&#10;&#10;date of last inspection of the {{block(Asset)}}.&#10;
";
				/// <summary>Constant value for <see cref="InspectionDateProperty.AccessModifier" /></summary>
				public const string ACCESS_MODIFIER = "private";
				/// <summary>Constant value for <see cref="InspectionDateProperty.Modifier" /></summary>
				public const string MODIFIER = "";
				/// <summary>Constant value for <see cref="InspectionDateProperty.NormativeVersion" /></summary>
				public const string NORMATIVE_VERSION = "2.5";
				/// <summary>Constant value for <see cref="InspectionDateProperty.DeprecatedVersion" /></summary>
				public const string DEPRECATED_VERSION = "";
				/// <summary>Constant value for <see cref="InspectionDateProperty.Aggregation" /></summary>
				public const string AGGREGATION = "composite";
				/// <summary>Constant value for <see cref="InspectionDateProperty.Extension" /></summary>
				public const string EXTENSION = "MagicDraw UML 2024x";
				/// <summary>Constant value for <see cref="InspectionDateProperty.Association" /></summary>
				public const string ASSOCIATION = "";
				/// <summary>Constant value for <see cref="InspectionDateProperty.DefaultValue" /></summary>
				public const string DEFAULT_VALUE = "";

				/// <summary>
				/// <inheritdoc />
				/// <remarks> Type: DateTime </remarks>
				/// </summary>
				public System.Type Type => typeof(DateTime);
				
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
			/// <inheritdoc cref="NextInspectionDateProperty" path="/summary" /><br/>
			/// <remarks>Original Name: NextInspectionDate</remarks>
			/// </summary>
			public new NextInspectionDateProperty NextInspectionDate { get; } = new NextInspectionDateProperty();
			
			/// <summary>﻿date of next inspection of the <see cref="Asset">Asset</see>.<br /><br /><br />
			/// </summary>
			public new sealed class NextInspectionDateProperty : IProperty
			{
				/// <summary>Constant value for <see cref="NextInspectionDateProperty.Name" /></summary>
				public const string NAME = "NextInspectionDate";
				/// <summary>Constant value for <see cref="NextInspectionDateProperty.Summary" /></summary>
				public const string SUMMARY = @"&#10;&#10;&#10;date of next inspection of the {{block(Asset)}}.&#10;
";
				/// <summary>Constant value for <see cref="NextInspectionDateProperty.AccessModifier" /></summary>
				public const string ACCESS_MODIFIER = "private";
				/// <summary>Constant value for <see cref="NextInspectionDateProperty.Modifier" /></summary>
				public const string MODIFIER = "";
				/// <summary>Constant value for <see cref="NextInspectionDateProperty.NormativeVersion" /></summary>
				public const string NORMATIVE_VERSION = "2.5";
				/// <summary>Constant value for <see cref="NextInspectionDateProperty.DeprecatedVersion" /></summary>
				public const string DEPRECATED_VERSION = "";
				/// <summary>Constant value for <see cref="NextInspectionDateProperty.Aggregation" /></summary>
				public const string AGGREGATION = "composite";
				/// <summary>Constant value for <see cref="NextInspectionDateProperty.Extension" /></summary>
				public const string EXTENSION = "MagicDraw UML 2024x";
				/// <summary>Constant value for <see cref="NextInspectionDateProperty.Association" /></summary>
				public const string ASSOCIATION = "";
				/// <summary>Constant value for <see cref="NextInspectionDateProperty.DefaultValue" /></summary>
				public const string DEFAULT_VALUE = "";

				/// <summary>
				/// <inheritdoc />
				/// <remarks> Type: DateTime </remarks>
				/// </summary>
				public System.Type Type => typeof(DateTime);
				
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
			/// <inheritdoc cref="HasMeasurementPartProperty" path="/summary" /><br/>
			/// <remarks>Original Name: HasMeasurement</remarks>
			/// </summary>
			public new HasMeasurementPartProperty HasMeasurementPart { get; } = new HasMeasurementPartProperty();
			
			/// <summary>﻿
			/// </summary>
			public new sealed class HasMeasurementPartProperty : IProperty
			{
				/// <summary>Constant value for <see cref="HasMeasurementPartProperty.Name" /></summary>
				public const string NAME = "hasMeasurement";
				/// <summary>Constant value for <see cref="HasMeasurementPartProperty.Summary" /></summary>
				public const string SUMMARY = @"";
				/// <summary>Constant value for <see cref="HasMeasurementPartProperty.AccessModifier" /></summary>
				public const string ACCESS_MODIFIER = "public";
				/// <summary>Constant value for <see cref="HasMeasurementPartProperty.Modifier" /></summary>
				public const string MODIFIER = "";
				/// <summary>Constant value for <see cref="HasMeasurementPartProperty.NormativeVersion" /></summary>
				public const string NORMATIVE_VERSION = "";
				/// <summary>Constant value for <see cref="HasMeasurementPartProperty.DeprecatedVersion" /></summary>
				public const string DEPRECATED_VERSION = "";
				/// <summary>Constant value for <see cref="HasMeasurementPartProperty.Aggregation" /></summary>
				public const string AGGREGATION = "composite";
				/// <summary>Constant value for <see cref="HasMeasurementPartProperty.Extension" /></summary>
				public const string EXTENSION = "";
				/// <summary>Constant value for <see cref="HasMeasurementPartProperty.Association" /></summary>
				public const string ASSOCIATION = "Measurements";
				/// <summary>Constant value for <see cref="HasMeasurementPartProperty.DefaultValue" /></summary>
				public const string DEFAULT_VALUE = "";

				/// <summary>
				/// <inheritdoc />
				/// <remarks> Type: MeasurementClass </remarks>
				/// </summary>
				public System.Type Type => typeof(Mtconnect.AssetInformationModel.Pallet.Measurements.MeasurementClass);
				
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