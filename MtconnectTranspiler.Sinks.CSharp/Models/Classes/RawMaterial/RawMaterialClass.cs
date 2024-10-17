#pragma warning disable CS0109 // Member does not hide an inherited member; new keyword is not required
#pragma warning disable CS1574 // XML comment has cref attribute that could not be resolved
#pragma warning disable CS1584 // XML comment has syntactically incorrect cref attribute
#pragma warning disable CS0618 // Type or member is obsolete
using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;
using System.Linq;

namespace Mtconnect.AssetInformationModel.RawMaterial
{
	/// <summary>﻿<see cref="Asset">Asset</see> that represents <i>raw material</i>.<br /><br /><br />
	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Structure___19_0_3_68e0225_1618829902716_470188_214">model.mtconnect.org</seealso> for more information.
	/// </summary>
	/// <remarks>
	/// <list type="bullet">
	/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.8">v1.8</see></item>
	/// </list>
	/// </remarks>

	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public sealed class RawMaterialClass : IClass
	{
		/// <summary>Constant value for <see cref="RawMaterialClass.ReferenceId" /></summary>
		public const string REFERENCE_ID = "_19_0_3_68e0225_1618829902716_470188_214";
		/// <summary>Constant value for <see cref="RawMaterialClass.HelpUrl" /></summary>
		public const string HELP_URL = "https://model.mtconnect.org/#Structure___19_0_3_68e0225_1618829902716_470188_214";
		/// <summary>Constant value for <see cref="RawMaterialClass.Summary" /></summary>
		public const string SUMMARY = @"&#10;&#10;&#10;{{block(Asset)}} that represents {{term(raw material)}}.&#10;
";
		/// <summary>Constant value for <see cref="RawMaterialClass.Name" /></summary>
		public const string NAME = "RawMaterial";
		/// <summary>Constant value for <see cref="RawMaterialClass.AccessModifier" /></summary>
		public const string ACCESS_MODIFIER = "public";
		/// <summary>Constant value for <see cref="RawMaterialClass.Modifier" /></summary>
		public const string MODIFIER = "";
		/// <summary>Constant value for <see cref="RawMaterialClass.NormativeVersion" /></summary>
		public const string NORMATIVE_VERSION = "1.8";
		/// <summary>Constant value for <see cref="RawMaterialClass.DeprecatedVersion" /></summary>
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
		public new RawMaterialClassProperties Properties { get; } = new RawMaterialClassProperties();
        IPropertyList IClass.Properties => Properties;
		/// <summary>
		/// Property list for <see cref="RawMaterialClass" />.
		/// <br/><b>Note</b>, some properties (<see cref="IProperty" />) are inherited from <see cref="Mtconnect.AssetInformationModel.AssetClass.AssetClassProperties" />.
		/// </summary>
		public class RawMaterialClassProperties : Mtconnect.AssetInformationModel.AssetClass.AssetClassProperties
		{
			/// <inheritdoc />
			public override IProperty[] Properties => new IProperty[] {
				Name,
				ContainerType,
				ProcessKind,
				SerialNumber,
				HasMaterial,
				HasMaterialPart,
				Form,
				ManufacturingDate,
				FirstUseDate,
				LastUseDate,
				InitialVolume,
				InitialDimension,
				InitialQuantity,
				CurrentVolume,
				CurrentDimension,
				CurrentQuantity,
			}.Concat(base.Properties).ToArray();
			/// <summary>
			/// <inheritdoc cref="NameProperty" path="/summary" /><br/>
			/// <remarks>Original Name: Name</remarks>
			/// </summary>
			public new NameProperty Name { get; } = new NameProperty();
			
			/// <summary>﻿name of the <i>raw material</i>.<br /><br />Examples: <c>Container1</c> and <c>AcrylicContainer</c>.<br /><br /><br />
			/// </summary>
			public new sealed class NameProperty : IProperty
			{
				/// <summary>Constant value for <see cref="NameProperty.Name" /></summary>
				public const string NAME = "name";
				/// <summary>Constant value for <see cref="NameProperty.Summary" /></summary>
				public const string SUMMARY = @"&#10;&#10;&#10;name of the {{term(raw material)}}.

Examples: `Container1` and `AcrylicContainer`.&#10;
";
				/// <summary>Constant value for <see cref="NameProperty.AccessModifier" /></summary>
				public const string ACCESS_MODIFIER = "public";
				/// <summary>Constant value for <see cref="NameProperty.Modifier" /></summary>
				public const string MODIFIER = "";
				/// <summary>Constant value for <see cref="NameProperty.NormativeVersion" /></summary>
				public const string NORMATIVE_VERSION = "1.8";
				/// <summary>Constant value for <see cref="NameProperty.DeprecatedVersion" /></summary>
				public const string DEPRECATED_VERSION = "";
				/// <summary>Constant value for <see cref="NameProperty.Aggregation" /></summary>
				public const string AGGREGATION = "composite";
				/// <summary>Constant value for <see cref="NameProperty.Extension" /></summary>
				public const string EXTENSION = "MagicDraw UML 2024x";
				/// <summary>Constant value for <see cref="NameProperty.Association" /></summary>
				public const string ASSOCIATION = "";
				/// <summary>Constant value for <see cref="NameProperty.DefaultValue" /></summary>
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
			/// <inheritdoc cref="ContainerTypeProperty" path="/summary" /><br/>
			/// <remarks>Original Name: ContainerType</remarks>
			/// </summary>
			public new ContainerTypeProperty ContainerType { get; } = new ContainerTypeProperty();
			
			/// <summary>﻿type of container holding the <i>raw material</i>. <br /><br />Examples: <c>Pallet</c>, <c>Canister</c>, <c>Cartridge</c>, <c>Tank</c>, <c>Bin</c>, <c>Roll</c>, and <c>Spool</c>.<br /><br /><br />
			/// </summary>
			public new sealed class ContainerTypeProperty : IProperty
			{
				/// <summary>Constant value for <see cref="ContainerTypeProperty.Name" /></summary>
				public const string NAME = "containerType";
				/// <summary>Constant value for <see cref="ContainerTypeProperty.Summary" /></summary>
				public const string SUMMARY = @"&#10;&#10;&#10;type of container holding the {{term(raw material)}}. 

Examples: `Pallet`, `Canister`, `Cartridge`, `Tank`, `Bin`, `Roll`, and `Spool`.&#10;
";
				/// <summary>Constant value for <see cref="ContainerTypeProperty.AccessModifier" /></summary>
				public const string ACCESS_MODIFIER = "public";
				/// <summary>Constant value for <see cref="ContainerTypeProperty.Modifier" /></summary>
				public const string MODIFIER = "";
				/// <summary>Constant value for <see cref="ContainerTypeProperty.NormativeVersion" /></summary>
				public const string NORMATIVE_VERSION = "1.8";
				/// <summary>Constant value for <see cref="ContainerTypeProperty.DeprecatedVersion" /></summary>
				public const string DEPRECATED_VERSION = "";
				/// <summary>Constant value for <see cref="ContainerTypeProperty.Aggregation" /></summary>
				public const string AGGREGATION = "composite";
				/// <summary>Constant value for <see cref="ContainerTypeProperty.Extension" /></summary>
				public const string EXTENSION = "MagicDraw UML 2024x";
				/// <summary>Constant value for <see cref="ContainerTypeProperty.Association" /></summary>
				public const string ASSOCIATION = "";
				/// <summary>Constant value for <see cref="ContainerTypeProperty.DefaultValue" /></summary>
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
			/// <inheritdoc cref="ProcessKindProperty" path="/summary" /><br/>
			/// <remarks>Original Name: ProcessKind</remarks>
			/// </summary>
			public new ProcessKindProperty ProcessKind { get; } = new ProcessKindProperty();
			
			/// <summary>﻿ISO process type supported by this <i>raw material</i>. <br /><br />Examples include: <c>VAT_POLYMERIZATION</c>, <c>BINDER_JETTING</c>, <c>MATERIAL_EXTRUSION</c>, <c>MATERIAL_JETTING</c>, <c>SHEET_LAMINATION</c>, <c>POWDER_BED_FUSION</c> and <c>DIRECTED_ENERGY_DEPOSITION</c>.<br /><br /><br />
			/// </summary>
			public new sealed class ProcessKindProperty : IProperty
			{
				/// <summary>Constant value for <see cref="ProcessKindProperty.Name" /></summary>
				public const string NAME = "processKind";
				/// <summary>Constant value for <see cref="ProcessKindProperty.Summary" /></summary>
				public const string SUMMARY = @"&#10;&#10;&#10;ISO process type supported by this {{term(raw material)}}. 

Examples include: `VAT_POLYMERIZATION`, `BINDER_JETTING`, `MATERIAL_EXTRUSION`, `MATERIAL_JETTING`, `SHEET_LAMINATION`, `POWDER_BED_FUSION` and `DIRECTED_ENERGY_DEPOSITION`.&#10;
";
				/// <summary>Constant value for <see cref="ProcessKindProperty.AccessModifier" /></summary>
				public const string ACCESS_MODIFIER = "public";
				/// <summary>Constant value for <see cref="ProcessKindProperty.Modifier" /></summary>
				public const string MODIFIER = "";
				/// <summary>Constant value for <see cref="ProcessKindProperty.NormativeVersion" /></summary>
				public const string NORMATIVE_VERSION = "1.8";
				/// <summary>Constant value for <see cref="ProcessKindProperty.DeprecatedVersion" /></summary>
				public const string DEPRECATED_VERSION = "";
				/// <summary>Constant value for <see cref="ProcessKindProperty.Aggregation" /></summary>
				public const string AGGREGATION = "composite";
				/// <summary>Constant value for <see cref="ProcessKindProperty.Extension" /></summary>
				public const string EXTENSION = "MagicDraw UML 2024x";
				/// <summary>Constant value for <see cref="ProcessKindProperty.Association" /></summary>
				public const string ASSOCIATION = "";
				/// <summary>Constant value for <see cref="ProcessKindProperty.DefaultValue" /></summary>
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
			/// <inheritdoc cref="SerialNumberProperty" path="/summary" /><br/>
			/// <remarks>Original Name: SerialNumber</remarks>
			/// </summary>
			public new SerialNumberProperty SerialNumber { get; } = new SerialNumberProperty();
			
			/// <summary>﻿serial number of the <i>raw material</i>.<br /><br /><br />
			/// </summary>
			public new sealed class SerialNumberProperty : IProperty
			{
				/// <summary>Constant value for <see cref="SerialNumberProperty.Name" /></summary>
				public const string NAME = "serialNumber";
				/// <summary>Constant value for <see cref="SerialNumberProperty.Summary" /></summary>
				public const string SUMMARY = @"&#10;&#10;&#10;serial number of the {{term(raw material)}}.&#10;
";
				/// <summary>Constant value for <see cref="SerialNumberProperty.AccessModifier" /></summary>
				public const string ACCESS_MODIFIER = "public";
				/// <summary>Constant value for <see cref="SerialNumberProperty.Modifier" /></summary>
				public const string MODIFIER = "";
				/// <summary>Constant value for <see cref="SerialNumberProperty.NormativeVersion" /></summary>
				public const string NORMATIVE_VERSION = "1.8";
				/// <summary>Constant value for <see cref="SerialNumberProperty.DeprecatedVersion" /></summary>
				public const string DEPRECATED_VERSION = "";
				/// <summary>Constant value for <see cref="SerialNumberProperty.Aggregation" /></summary>
				public const string AGGREGATION = "composite";
				/// <summary>Constant value for <see cref="SerialNumberProperty.Extension" /></summary>
				public const string EXTENSION = "MagicDraw UML 2024x";
				/// <summary>Constant value for <see cref="SerialNumberProperty.Association" /></summary>
				public const string ASSOCIATION = "";
				/// <summary>Constant value for <see cref="SerialNumberProperty.DefaultValue" /></summary>
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
			/// <inheritdoc cref="HasMaterialProperty" path="/summary" /><br/>
			/// <remarks>Original Name: HasMaterial</remarks>
			/// </summary>
			public new HasMaterialProperty HasMaterial { get; } = new HasMaterialProperty();
			
			/// <summary>﻿<see cref="Material">Material</see> has existing usable volume.<br /><br /><br />
			/// </summary>
			public new sealed class HasMaterialProperty : IProperty
			{
				/// <summary>Constant value for <see cref="HasMaterialProperty.Name" /></summary>
				public const string NAME = "HasMaterial";
				/// <summary>Constant value for <see cref="HasMaterialProperty.Summary" /></summary>
				public const string SUMMARY = @"&#10;&#10;&#10;{{block(Material)}} has existing usable volume.&#10;
";
				/// <summary>Constant value for <see cref="HasMaterialProperty.AccessModifier" /></summary>
				public const string ACCESS_MODIFIER = "public";
				/// <summary>Constant value for <see cref="HasMaterialProperty.Modifier" /></summary>
				public const string MODIFIER = "";
				/// <summary>Constant value for <see cref="HasMaterialProperty.NormativeVersion" /></summary>
				public const string NORMATIVE_VERSION = "1.8";
				/// <summary>Constant value for <see cref="HasMaterialProperty.DeprecatedVersion" /></summary>
				public const string DEPRECATED_VERSION = "";
				/// <summary>Constant value for <see cref="HasMaterialProperty.Aggregation" /></summary>
				public const string AGGREGATION = "composite";
				/// <summary>Constant value for <see cref="HasMaterialProperty.Extension" /></summary>
				public const string EXTENSION = "MagicDraw UML 2024x";
				/// <summary>Constant value for <see cref="HasMaterialProperty.Association" /></summary>
				public const string ASSOCIATION = "";
				/// <summary>Constant value for <see cref="HasMaterialProperty.DefaultValue" /></summary>
				public const string DEFAULT_VALUE = "";

				/// <summary>
				/// <inheritdoc />
				/// <remarks> Type: Boolean </remarks>
				/// </summary>
				public System.Type Type => typeof(Boolean);
				
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
			/// <inheritdoc cref="HasMaterialPartProperty" path="/summary" /><br/>
			/// <remarks>Original Name: HasMaterial</remarks>
			/// </summary>
			public new HasMaterialPartProperty HasMaterialPart { get; } = new HasMaterialPartProperty();
			
			/// <summary>﻿
			/// </summary>
			public new sealed class HasMaterialPartProperty : IProperty
			{
				/// <summary>Constant value for <see cref="HasMaterialPartProperty.Name" /></summary>
				public const string NAME = "hasMaterial";
				/// <summary>Constant value for <see cref="HasMaterialPartProperty.Summary" /></summary>
				public const string SUMMARY = @"";
				/// <summary>Constant value for <see cref="HasMaterialPartProperty.AccessModifier" /></summary>
				public const string ACCESS_MODIFIER = "public";
				/// <summary>Constant value for <see cref="HasMaterialPartProperty.Modifier" /></summary>
				public const string MODIFIER = "";
				/// <summary>Constant value for <see cref="HasMaterialPartProperty.NormativeVersion" /></summary>
				public const string NORMATIVE_VERSION = "";
				/// <summary>Constant value for <see cref="HasMaterialPartProperty.DeprecatedVersion" /></summary>
				public const string DEPRECATED_VERSION = "";
				/// <summary>Constant value for <see cref="HasMaterialPartProperty.Aggregation" /></summary>
				public const string AGGREGATION = "composite";
				/// <summary>Constant value for <see cref="HasMaterialPartProperty.Extension" /></summary>
				public const string EXTENSION = "MagicDraw UML 2024x";
				/// <summary>Constant value for <see cref="HasMaterialPartProperty.Association" /></summary>
				public const string ASSOCIATION = "Material";
				/// <summary>Constant value for <see cref="HasMaterialPartProperty.DefaultValue" /></summary>
				public const string DEFAULT_VALUE = "";

				/// <summary>
				/// <inheritdoc />
				/// <remarks> Type: MaterialClass </remarks>
				/// </summary>
				public System.Type Type => typeof(Mtconnect.AssetInformationModel.RawMaterial.MaterialClass);
				
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
			/// <inheritdoc cref="FormProperty" path="/summary" /><br/>
			/// <remarks>Original Name: Form</remarks>
			/// </summary>
			public new FormProperty Form { get; } = new FormProperty();
			
			/// <summary>﻿form of the <i>raw material</i>.<br /><br /><br />
			/// </summary>
			public new sealed class FormProperty : IProperty
			{
				/// <summary>Constant value for <see cref="FormProperty.Name" /></summary>
				public const string NAME = "Form";
				/// <summary>Constant value for <see cref="FormProperty.Summary" /></summary>
				public const string SUMMARY = @"&#10;&#10;&#10;form of the {{term(raw material)}}.&#10;
";
				/// <summary>Constant value for <see cref="FormProperty.AccessModifier" /></summary>
				public const string ACCESS_MODIFIER = "public";
				/// <summary>Constant value for <see cref="FormProperty.Modifier" /></summary>
				public const string MODIFIER = "";
				/// <summary>Constant value for <see cref="FormProperty.NormativeVersion" /></summary>
				public const string NORMATIVE_VERSION = "1.8";
				/// <summary>Constant value for <see cref="FormProperty.DeprecatedVersion" /></summary>
				public const string DEPRECATED_VERSION = "";
				/// <summary>Constant value for <see cref="FormProperty.Aggregation" /></summary>
				public const string AGGREGATION = "composite";
				/// <summary>Constant value for <see cref="FormProperty.Extension" /></summary>
				public const string EXTENSION = "MagicDraw UML 2024x";
				/// <summary>Constant value for <see cref="FormProperty.Association" /></summary>
				public const string ASSOCIATION = "";
				/// <summary>Constant value for <see cref="FormProperty.DefaultValue" /></summary>
				public const string DEFAULT_VALUE = "";

				/// <summary>
				/// <inheritdoc />
				/// <remarks> Type: FormEnumMetaClass </remarks>
				/// </summary>
				public System.Type Type => typeof(Mtconnect.DataTypes.FormEnumMetaClass);
				
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
			/// <inheritdoc cref="ManufacturingDateProperty" path="/summary" /><br/>
			/// <remarks>Original Name: ManufacturingDate</remarks>
			/// </summary>
			public new ManufacturingDateProperty ManufacturingDate { get; } = new ManufacturingDateProperty();
			
			/// <summary>﻿date the <i>raw material</i> was created.<br /><br /><br />
			/// </summary>
			public new sealed class ManufacturingDateProperty : IProperty
			{
				/// <summary>Constant value for <see cref="ManufacturingDateProperty.Name" /></summary>
				public const string NAME = "ManufacturingDate";
				/// <summary>Constant value for <see cref="ManufacturingDateProperty.Summary" /></summary>
				public const string SUMMARY = @"&#10;&#10;&#10;date the {{term(raw material)}} was created.&#10;
";
				/// <summary>Constant value for <see cref="ManufacturingDateProperty.AccessModifier" /></summary>
				public const string ACCESS_MODIFIER = "public";
				/// <summary>Constant value for <see cref="ManufacturingDateProperty.Modifier" /></summary>
				public const string MODIFIER = "";
				/// <summary>Constant value for <see cref="ManufacturingDateProperty.NormativeVersion" /></summary>
				public const string NORMATIVE_VERSION = "1.8";
				/// <summary>Constant value for <see cref="ManufacturingDateProperty.DeprecatedVersion" /></summary>
				public const string DEPRECATED_VERSION = "";
				/// <summary>Constant value for <see cref="ManufacturingDateProperty.Aggregation" /></summary>
				public const string AGGREGATION = "composite";
				/// <summary>Constant value for <see cref="ManufacturingDateProperty.Extension" /></summary>
				public const string EXTENSION = "MagicDraw UML 2024x";
				/// <summary>Constant value for <see cref="ManufacturingDateProperty.Association" /></summary>
				public const string ASSOCIATION = "";
				/// <summary>Constant value for <see cref="ManufacturingDateProperty.DefaultValue" /></summary>
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
			/// <inheritdoc cref="FirstUseDateProperty" path="/summary" /><br/>
			/// <remarks>Original Name: FirstUseDate</remarks>
			/// </summary>
			public new FirstUseDateProperty FirstUseDate { get; } = new FirstUseDateProperty();
			
			/// <summary>﻿date <i>raw material</i> was first used.<br /><br /><br />
			/// </summary>
			public new sealed class FirstUseDateProperty : IProperty
			{
				/// <summary>Constant value for <see cref="FirstUseDateProperty.Name" /></summary>
				public const string NAME = "FirstUseDate";
				/// <summary>Constant value for <see cref="FirstUseDateProperty.Summary" /></summary>
				public const string SUMMARY = @"&#10;&#10;&#10;date {{term(raw material)}} was first used.&#10;
";
				/// <summary>Constant value for <see cref="FirstUseDateProperty.AccessModifier" /></summary>
				public const string ACCESS_MODIFIER = "public";
				/// <summary>Constant value for <see cref="FirstUseDateProperty.Modifier" /></summary>
				public const string MODIFIER = "";
				/// <summary>Constant value for <see cref="FirstUseDateProperty.NormativeVersion" /></summary>
				public const string NORMATIVE_VERSION = "1.8";
				/// <summary>Constant value for <see cref="FirstUseDateProperty.DeprecatedVersion" /></summary>
				public const string DEPRECATED_VERSION = "";
				/// <summary>Constant value for <see cref="FirstUseDateProperty.Aggregation" /></summary>
				public const string AGGREGATION = "composite";
				/// <summary>Constant value for <see cref="FirstUseDateProperty.Extension" /></summary>
				public const string EXTENSION = "MagicDraw UML 2024x";
				/// <summary>Constant value for <see cref="FirstUseDateProperty.Association" /></summary>
				public const string ASSOCIATION = "";
				/// <summary>Constant value for <see cref="FirstUseDateProperty.DefaultValue" /></summary>
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
			/// <inheritdoc cref="LastUseDateProperty" path="/summary" /><br/>
			/// <remarks>Original Name: LastUseDate</remarks>
			/// </summary>
			public new LastUseDateProperty LastUseDate { get; } = new LastUseDateProperty();
			
			/// <summary>﻿date <i>raw material</i> was last used.<br /><br /><br />
			/// </summary>
			public new sealed class LastUseDateProperty : IProperty
			{
				/// <summary>Constant value for <see cref="LastUseDateProperty.Name" /></summary>
				public const string NAME = "LastUseDate";
				/// <summary>Constant value for <see cref="LastUseDateProperty.Summary" /></summary>
				public const string SUMMARY = @"&#10;&#10;&#10;date {{term(raw material)}} was last used.&#10;
";
				/// <summary>Constant value for <see cref="LastUseDateProperty.AccessModifier" /></summary>
				public const string ACCESS_MODIFIER = "public";
				/// <summary>Constant value for <see cref="LastUseDateProperty.Modifier" /></summary>
				public const string MODIFIER = "";
				/// <summary>Constant value for <see cref="LastUseDateProperty.NormativeVersion" /></summary>
				public const string NORMATIVE_VERSION = "1.8";
				/// <summary>Constant value for <see cref="LastUseDateProperty.DeprecatedVersion" /></summary>
				public const string DEPRECATED_VERSION = "";
				/// <summary>Constant value for <see cref="LastUseDateProperty.Aggregation" /></summary>
				public const string AGGREGATION = "composite";
				/// <summary>Constant value for <see cref="LastUseDateProperty.Extension" /></summary>
				public const string EXTENSION = "MagicDraw UML 2024x";
				/// <summary>Constant value for <see cref="LastUseDateProperty.Association" /></summary>
				public const string ASSOCIATION = "";
				/// <summary>Constant value for <see cref="LastUseDateProperty.DefaultValue" /></summary>
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
			/// <inheritdoc cref="InitialVolumeProperty" path="/summary" /><br/>
			/// <remarks>Original Name: InitialVolume</remarks>
			/// </summary>
			public new InitialVolumeProperty InitialVolume { get; } = new InitialVolumeProperty();
			
			/// <summary>﻿amount of material initially placed in <i>raw material</i> when manufactured.<br /><br /><br />
			/// </summary>
			public new sealed class InitialVolumeProperty : IProperty
			{
				/// <summary>Constant value for <see cref="InitialVolumeProperty.Name" /></summary>
				public const string NAME = "InitialVolume";
				/// <summary>Constant value for <see cref="InitialVolumeProperty.Summary" /></summary>
				public const string SUMMARY = @"&#10;&#10;&#10;amount of material initially placed in {{term(raw material)}} when manufactured.&#10;
";
				/// <summary>Constant value for <see cref="InitialVolumeProperty.AccessModifier" /></summary>
				public const string ACCESS_MODIFIER = "public";
				/// <summary>Constant value for <see cref="InitialVolumeProperty.Modifier" /></summary>
				public const string MODIFIER = "";
				/// <summary>Constant value for <see cref="InitialVolumeProperty.NormativeVersion" /></summary>
				public const string NORMATIVE_VERSION = "1.8";
				/// <summary>Constant value for <see cref="InitialVolumeProperty.DeprecatedVersion" /></summary>
				public const string DEPRECATED_VERSION = "";
				/// <summary>Constant value for <see cref="InitialVolumeProperty.Aggregation" /></summary>
				public const string AGGREGATION = "composite";
				/// <summary>Constant value for <see cref="InitialVolumeProperty.Extension" /></summary>
				public const string EXTENSION = "MagicDraw UML 2024x";
				/// <summary>Constant value for <see cref="InitialVolumeProperty.Association" /></summary>
				public const string ASSOCIATION = "";
				/// <summary>Constant value for <see cref="InitialVolumeProperty.DefaultValue" /></summary>
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
			/// <inheritdoc cref="InitialDimensionProperty" path="/summary" /><br/>
			/// <remarks>Original Name: InitialDimension</remarks>
			/// </summary>
			public new InitialDimensionProperty InitialDimension { get; } = new InitialDimensionProperty();
			
			/// <summary>﻿dimension of material initially placed in <i>raw material</i> when manufactured.<br /><br /><br />
			/// </summary>
			public new sealed class InitialDimensionProperty : IProperty
			{
				/// <summary>Constant value for <see cref="InitialDimensionProperty.Name" /></summary>
				public const string NAME = "InitialDimension";
				/// <summary>Constant value for <see cref="InitialDimensionProperty.Summary" /></summary>
				public const string SUMMARY = @"&#10;&#10;&#10;dimension of material initially placed in {{term(raw material)}} when manufactured.&#10;
";
				/// <summary>Constant value for <see cref="InitialDimensionProperty.AccessModifier" /></summary>
				public const string ACCESS_MODIFIER = "public";
				/// <summary>Constant value for <see cref="InitialDimensionProperty.Modifier" /></summary>
				public const string MODIFIER = "";
				/// <summary>Constant value for <see cref="InitialDimensionProperty.NormativeVersion" /></summary>
				public const string NORMATIVE_VERSION = "1.8";
				/// <summary>Constant value for <see cref="InitialDimensionProperty.DeprecatedVersion" /></summary>
				public const string DEPRECATED_VERSION = "";
				/// <summary>Constant value for <see cref="InitialDimensionProperty.Aggregation" /></summary>
				public const string AGGREGATION = "composite";
				/// <summary>Constant value for <see cref="InitialDimensionProperty.Extension" /></summary>
				public const string EXTENSION = "";
				/// <summary>Constant value for <see cref="InitialDimensionProperty.Association" /></summary>
				public const string ASSOCIATION = "";
				/// <summary>Constant value for <see cref="InitialDimensionProperty.DefaultValue" /></summary>
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
			/// <inheritdoc cref="InitialQuantityProperty" path="/summary" /><br/>
			/// <remarks>Original Name: InitialQuantity</remarks>
			/// </summary>
			public new InitialQuantityProperty InitialQuantity { get; } = new InitialQuantityProperty();
			
			/// <summary>﻿quantity of material initially placed in <i>raw material</i> when manufactured.<br /><br /><br />
			/// </summary>
			public new sealed class InitialQuantityProperty : IProperty
			{
				/// <summary>Constant value for <see cref="InitialQuantityProperty.Name" /></summary>
				public const string NAME = "InitialQuantity";
				/// <summary>Constant value for <see cref="InitialQuantityProperty.Summary" /></summary>
				public const string SUMMARY = @"&#10;&#10;&#10;quantity of material initially placed in {{term(raw material)}} when manufactured.&#10;
";
				/// <summary>Constant value for <see cref="InitialQuantityProperty.AccessModifier" /></summary>
				public const string ACCESS_MODIFIER = "public";
				/// <summary>Constant value for <see cref="InitialQuantityProperty.Modifier" /></summary>
				public const string MODIFIER = "";
				/// <summary>Constant value for <see cref="InitialQuantityProperty.NormativeVersion" /></summary>
				public const string NORMATIVE_VERSION = "1.8";
				/// <summary>Constant value for <see cref="InitialQuantityProperty.DeprecatedVersion" /></summary>
				public const string DEPRECATED_VERSION = "";
				/// <summary>Constant value for <see cref="InitialQuantityProperty.Aggregation" /></summary>
				public const string AGGREGATION = "composite";
				/// <summary>Constant value for <see cref="InitialQuantityProperty.Extension" /></summary>
				public const string EXTENSION = "MagicDraw UML 2024x";
				/// <summary>Constant value for <see cref="InitialQuantityProperty.Association" /></summary>
				public const string ASSOCIATION = "";
				/// <summary>Constant value for <see cref="InitialQuantityProperty.DefaultValue" /></summary>
				public const string DEFAULT_VALUE = "";

				/// <summary>
				/// <inheritdoc />
				/// <remarks> Type: Int32 </remarks>
				/// </summary>
				public System.Type Type => typeof(Int32);
				
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
			/// <inheritdoc cref="CurrentVolumeProperty" path="/summary" /><br/>
			/// <remarks>Original Name: CurrentVolume</remarks>
			/// </summary>
			public new CurrentVolumeProperty CurrentVolume { get; } = new CurrentVolumeProperty();
			
			/// <summary>﻿amount of material currently in <i>raw material</i>.<br /><br /><br />
			/// </summary>
			public new sealed class CurrentVolumeProperty : IProperty
			{
				/// <summary>Constant value for <see cref="CurrentVolumeProperty.Name" /></summary>
				public const string NAME = "CurrentVolume";
				/// <summary>Constant value for <see cref="CurrentVolumeProperty.Summary" /></summary>
				public const string SUMMARY = @"&#10;&#10;&#10;amount of material currently in {{term(raw material)}}.&#10;
";
				/// <summary>Constant value for <see cref="CurrentVolumeProperty.AccessModifier" /></summary>
				public const string ACCESS_MODIFIER = "public";
				/// <summary>Constant value for <see cref="CurrentVolumeProperty.Modifier" /></summary>
				public const string MODIFIER = "";
				/// <summary>Constant value for <see cref="CurrentVolumeProperty.NormativeVersion" /></summary>
				public const string NORMATIVE_VERSION = "1.8";
				/// <summary>Constant value for <see cref="CurrentVolumeProperty.DeprecatedVersion" /></summary>
				public const string DEPRECATED_VERSION = "";
				/// <summary>Constant value for <see cref="CurrentVolumeProperty.Aggregation" /></summary>
				public const string AGGREGATION = "composite";
				/// <summary>Constant value for <see cref="CurrentVolumeProperty.Extension" /></summary>
				public const string EXTENSION = "MagicDraw UML 2024x";
				/// <summary>Constant value for <see cref="CurrentVolumeProperty.Association" /></summary>
				public const string ASSOCIATION = "";
				/// <summary>Constant value for <see cref="CurrentVolumeProperty.DefaultValue" /></summary>
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
			/// <inheritdoc cref="CurrentDimensionProperty" path="/summary" /><br/>
			/// <remarks>Original Name: CurrentDimension</remarks>
			/// </summary>
			public new CurrentDimensionProperty CurrentDimension { get; } = new CurrentDimensionProperty();
			
			/// <summary>﻿dimension of material currently in <i>raw material</i>.<br /><br /><br />
			/// </summary>
			public new sealed class CurrentDimensionProperty : IProperty
			{
				/// <summary>Constant value for <see cref="CurrentDimensionProperty.Name" /></summary>
				public const string NAME = "CurrentDimension";
				/// <summary>Constant value for <see cref="CurrentDimensionProperty.Summary" /></summary>
				public const string SUMMARY = @"&#10;&#10;&#10;dimension of material currently in {{term(raw material)}}.&#10;
";
				/// <summary>Constant value for <see cref="CurrentDimensionProperty.AccessModifier" /></summary>
				public const string ACCESS_MODIFIER = "public";
				/// <summary>Constant value for <see cref="CurrentDimensionProperty.Modifier" /></summary>
				public const string MODIFIER = "";
				/// <summary>Constant value for <see cref="CurrentDimensionProperty.NormativeVersion" /></summary>
				public const string NORMATIVE_VERSION = "1.8";
				/// <summary>Constant value for <see cref="CurrentDimensionProperty.DeprecatedVersion" /></summary>
				public const string DEPRECATED_VERSION = "";
				/// <summary>Constant value for <see cref="CurrentDimensionProperty.Aggregation" /></summary>
				public const string AGGREGATION = "composite";
				/// <summary>Constant value for <see cref="CurrentDimensionProperty.Extension" /></summary>
				public const string EXTENSION = "";
				/// <summary>Constant value for <see cref="CurrentDimensionProperty.Association" /></summary>
				public const string ASSOCIATION = "";
				/// <summary>Constant value for <see cref="CurrentDimensionProperty.DefaultValue" /></summary>
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
			/// <inheritdoc cref="CurrentQuantityProperty" path="/summary" /><br/>
			/// <remarks>Original Name: CurrentQuantity</remarks>
			/// </summary>
			public new CurrentQuantityProperty CurrentQuantity { get; } = new CurrentQuantityProperty();
			
			/// <summary>﻿quantity of material currently in <i>raw material</i>.<br /><br /><br />
			/// </summary>
			public new sealed class CurrentQuantityProperty : IProperty
			{
				/// <summary>Constant value for <see cref="CurrentQuantityProperty.Name" /></summary>
				public const string NAME = "CurrentQuantity";
				/// <summary>Constant value for <see cref="CurrentQuantityProperty.Summary" /></summary>
				public const string SUMMARY = @"&#10;&#10;&#10;quantity of material currently in {{term(raw material)}}.&#10;
";
				/// <summary>Constant value for <see cref="CurrentQuantityProperty.AccessModifier" /></summary>
				public const string ACCESS_MODIFIER = "public";
				/// <summary>Constant value for <see cref="CurrentQuantityProperty.Modifier" /></summary>
				public const string MODIFIER = "";
				/// <summary>Constant value for <see cref="CurrentQuantityProperty.NormativeVersion" /></summary>
				public const string NORMATIVE_VERSION = "1.8";
				/// <summary>Constant value for <see cref="CurrentQuantityProperty.DeprecatedVersion" /></summary>
				public const string DEPRECATED_VERSION = "";
				/// <summary>Constant value for <see cref="CurrentQuantityProperty.Aggregation" /></summary>
				public const string AGGREGATION = "composite";
				/// <summary>Constant value for <see cref="CurrentQuantityProperty.Extension" /></summary>
				public const string EXTENSION = "MagicDraw UML 2024x";
				/// <summary>Constant value for <see cref="CurrentQuantityProperty.Association" /></summary>
				public const string ASSOCIATION = "";
				/// <summary>Constant value for <see cref="CurrentQuantityProperty.DefaultValue" /></summary>
				public const string DEFAULT_VALUE = "";

				/// <summary>
				/// <inheritdoc />
				/// <remarks> Type: Int32 </remarks>
				/// </summary>
				public System.Type Type => typeof(Int32);
				
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