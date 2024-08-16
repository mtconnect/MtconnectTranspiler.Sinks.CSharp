using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;
using System.Linq;

namespace Mtconnect.AssetInformationModel.RawMaterial
{
	/// <summary>
	﻿/// <see cref="Asset">Asset</see> that represents <i>raw material</i>.<br/><br />

	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Structure___19_0_3_68e0225_1618829902716_470188_214">model.mtconnect.org</seealso> for more information.
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public sealed class RawMaterialClass : IClass
	{
		/// <inheritdoc />
		public string ReferenceId => "_19_0_3_68e0225_1618829902716_470188_214";
		
		/// <inheritdoc />
		public string Summary => @"&#10;&#10;&#10;{{block(Asset)}} that represents {{term(raw material)}}.&#10;
";

		/// <inheritdoc />
		public string Name => "RawMaterial";
		
		/// <inheritdoc />
		public string AccessModifier => "public";
				
		/// <inheritdoc />
		public string Modifier => "";
				
		/// <inheritdoc />
		public string NormativeVersion => "1.8";
				
		/// <inheritdoc />
		public string DeprecatedVersion => "";
		
		/// <inheritdoc />
		/// <remarks>
		/// Original Type: EAID_C7D39183_23CB_416b_A62D_F60815E08B1A
		/// </remarks>
		public Type Generalization => typeof(Mtconnect.AssetInformationModel.AssetClass);

		/// <inheritdoc />
		public RawMaterialClassProperties Properties { get; } = new RawMaterialClassProperties();
        IPropertyList IClass.Properties => Properties;
		public class RawMaterialClassProperties : Mtconnect.AssetInformationModel.AssetClass.AssetClassProperties
		{
			/// <inheritdoc />
			public IProperty[] Properties => new IProperty[] {
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
			public NameProperty Name { get; } = new NameProperty();
			/// <summary>
			﻿/// name of the <i>raw material</i>.<br /><br />Examples: <c>Container1</c> and <c>AcrylicContainer</c>.<br/><br />

			/// </summary>
			public sealed class NameProperty : IProperty
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
				public string Name => "name";
				
				/// <inheritdoc />
				public string Summary => @"&#10;&#10;&#10;name of the {{term(raw material)}}.

Examples: `Container1` and `AcrylicContainer`.&#10;
";

				/// <inheritdoc />
				public string AccessModifier => "public";
				
				/// <inheritdoc />
				public string Modifier => "";
				
				/// <inheritdoc />
				public string NormativeVersion => "1.8";
				
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
			/// <inheritdoc cref="ContainerTypeProperty" path="/summary" /><br/>
			/// <remarks>Original Name: ContainerType</remarks>
			/// </summary>
			public ContainerTypeProperty ContainerType { get; } = new ContainerTypeProperty();
			/// <summary>
			﻿/// type of container holding the <i>raw material</i>. <br /><br />Examples: <c>Pallet</c>, <c>Canister</c>, <c>Cartridge</c>, <c>Tank</c>, <c>Bin</c>, <c>Roll</c>, and <c>Spool</c>.<br/><br />

			/// </summary>
			public sealed class ContainerTypeProperty : IProperty
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
				public string Name => "containerType";
				
				/// <inheritdoc />
				public string Summary => @"&#10;&#10;&#10;type of container holding the {{term(raw material)}}. 

Examples: `Pallet`, `Canister`, `Cartridge`, `Tank`, `Bin`, `Roll`, and `Spool`.&#10;
";

				/// <inheritdoc />
				public string AccessModifier => "public";
				
				/// <inheritdoc />
				public string Modifier => "";
				
				/// <inheritdoc />
				public string NormativeVersion => "1.8";
				
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
			/// <inheritdoc cref="ProcessKindProperty" path="/summary" /><br/>
			/// <remarks>Original Name: ProcessKind</remarks>
			/// </summary>
			public ProcessKindProperty ProcessKind { get; } = new ProcessKindProperty();
			/// <summary>
			﻿/// ISO process type supported by this <i>raw material</i>. <br /><br />Examples include: <c>VAT_POLYMERIZATION</c>, <c>BINDER_JETTING</c>, <c>MATERIAL_EXTRUSION</c>, <c>MATERIAL_JETTING</c>, <c>SHEET_LAMINATION</c>, <c>POWDER_BED_FUSION</c> and <c>DIRECTED_ENERGY_DEPOSITION</c>.<br/><br />

			/// </summary>
			public sealed class ProcessKindProperty : IProperty
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
				public string Name => "processKind";
				
				/// <inheritdoc />
				public string Summary => @"&#10;&#10;&#10;ISO process type supported by this {{term(raw material)}}. 

Examples include: `VAT_POLYMERIZATION`, `BINDER_JETTING`, `MATERIAL_EXTRUSION`, `MATERIAL_JETTING`, `SHEET_LAMINATION`, `POWDER_BED_FUSION` and `DIRECTED_ENERGY_DEPOSITION`.&#10;
";

				/// <inheritdoc />
				public string AccessModifier => "public";
				
				/// <inheritdoc />
				public string Modifier => "";
				
				/// <inheritdoc />
				public string NormativeVersion => "1.8";
				
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
			/// <inheritdoc cref="SerialNumberProperty" path="/summary" /><br/>
			/// <remarks>Original Name: SerialNumber</remarks>
			/// </summary>
			public SerialNumberProperty SerialNumber { get; } = new SerialNumberProperty();
			/// <summary>
			﻿/// serial number of the <i>raw material</i>.<br/><br />

			/// </summary>
			public sealed class SerialNumberProperty : IProperty
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
				public string Name => "serialNumber";
				
				/// <inheritdoc />
				public string Summary => @"&#10;&#10;&#10;serial number of the {{term(raw material)}}.&#10;
";

				/// <inheritdoc />
				public string AccessModifier => "public";
				
				/// <inheritdoc />
				public string Modifier => "";
				
				/// <inheritdoc />
				public string NormativeVersion => "1.8";
				
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
			/// <inheritdoc cref="HasMaterialProperty" path="/summary" /><br/>
			/// <remarks>Original Name: HasMaterial</remarks>
			/// </summary>
			public HasMaterialProperty HasMaterial { get; } = new HasMaterialProperty();
			/// <summary>
			﻿/// <see cref="Material">Material</see> has existing usable volume.<br/><br />

			/// </summary>
			public sealed class HasMaterialProperty : IProperty
			{
				/// <summary>
				/// <inheritdoc />
				/// <remarks>
				/// <list type="bullet">
				/// <item>Original Type: _19_0_3_91b028d_1579278876899_683310_3821</item>
				/// <item>Type: Boolean</item>
				/// <item>Namespace: </item>
				/// </list>
				/// </remarks>
				/// </summary>
				public System.Type Type => typeof(Boolean);
				
				/// <inheritdoc />
				public string Name => "HasMaterial";
				
				/// <inheritdoc />
				public string Summary => @"&#10;&#10;&#10;{{block(Material)}} has existing usable volume.&#10;
";

				/// <inheritdoc />
				public string AccessModifier => "public";
				
				/// <inheritdoc />
				public string Modifier => "";
				
				/// <inheritdoc />
				public string NormativeVersion => "1.8";
				
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
			/// <inheritdoc cref="HasMaterialPartProperty" path="/summary" /><br/>
			/// <remarks>Original Name: HasMaterial</remarks>
			/// </summary>
			public HasMaterialPartProperty HasMaterialPart { get; } = new HasMaterialPartProperty();
			public sealed class HasMaterialPartProperty : IProperty
			{
				/// <summary>
				/// <inheritdoc />
				/// <remarks>
				/// <list type="bullet">
				/// <item>Original Type: _19_0_3_68e0225_1618831557881_852871_420</item>
				/// <item>Type: MaterialClass</item>
				/// <item>Namespace: Mtconnect.AssetInformationModel.RawMaterial</item>
				/// </list>
				/// </remarks>
				/// </summary>
				public System.Type Type => typeof(Mtconnect.AssetInformationModel.RawMaterial.MaterialClass);
				
				/// <inheritdoc />
				public string Name => "hasMaterial";
				
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
				public string Association => "Material";

				// Note: DefaultValue.Name
				/// <inheritdoc />
				public string DefaultValue => "";
			}
			/// <summary>
			/// <inheritdoc cref="FormProperty" path="/summary" /><br/>
			/// <remarks>Original Name: Form</remarks>
			/// </summary>
			public FormProperty Form { get; } = new FormProperty();
			/// <summary>
			﻿/// form of the <i>raw material</i>.<br/><br />

			/// </summary>
			public sealed class FormProperty : IProperty
			{
				/// <summary>
				/// <inheritdoc />
				/// <remarks>
				/// <list type="bullet">
				/// <item>Original Type: _19_0_3_68e0225_1618830616283_5956_278</item>
				/// <item>Type: FormEnumMetaClass</item>
				/// <item>Namespace: Mtconnect.DataTypes</item>
				/// </list>
				/// </remarks>
				/// </summary>
				public System.Type Type => typeof(Mtconnect.DataTypes.FormEnumMetaClass);
				
				/// <inheritdoc />
				public string Name => "Form";
				
				/// <inheritdoc />
				public string Summary => @"&#10;&#10;&#10;form of the {{term(raw material)}}.&#10;
";

				/// <inheritdoc />
				public string AccessModifier => "public";
				
				/// <inheritdoc />
				public string Modifier => "";
				
				/// <inheritdoc />
				public string NormativeVersion => "1.8";
				
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
			/// <inheritdoc cref="ManufacturingDateProperty" path="/summary" /><br/>
			/// <remarks>Original Name: ManufacturingDate</remarks>
			/// </summary>
			public ManufacturingDateProperty ManufacturingDate { get; } = new ManufacturingDateProperty();
			/// <summary>
			﻿/// date the <i>raw material</i> was created.<br/><br />

			/// </summary>
			public sealed class ManufacturingDateProperty : IProperty
			{
				/// <summary>
				/// <inheritdoc />
				/// <remarks>
				/// <list type="bullet">
				/// <item>Original Type: _19_0_3_91b028d_1579272233011_597138_670</item>
				/// <item>Type: DateTime</item>
				/// <item>Namespace: </item>
				/// </list>
				/// </remarks>
				/// </summary>
				public System.Type Type => typeof(DateTime);
				
				/// <inheritdoc />
				public string Name => "ManufacturingDate";
				
				/// <inheritdoc />
				public string Summary => @"&#10;&#10;&#10;date the {{term(raw material)}} was created.&#10;
";

				/// <inheritdoc />
				public string AccessModifier => "public";
				
				/// <inheritdoc />
				public string Modifier => "";
				
				/// <inheritdoc />
				public string NormativeVersion => "1.8";
				
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
			/// <inheritdoc cref="FirstUseDateProperty" path="/summary" /><br/>
			/// <remarks>Original Name: FirstUseDate</remarks>
			/// </summary>
			public FirstUseDateProperty FirstUseDate { get; } = new FirstUseDateProperty();
			/// <summary>
			﻿/// date <i>raw material</i> was first used.<br/><br />

			/// </summary>
			public sealed class FirstUseDateProperty : IProperty
			{
				/// <summary>
				/// <inheritdoc />
				/// <remarks>
				/// <list type="bullet">
				/// <item>Original Type: _19_0_3_91b028d_1579272233011_597138_670</item>
				/// <item>Type: DateTime</item>
				/// <item>Namespace: </item>
				/// </list>
				/// </remarks>
				/// </summary>
				public System.Type Type => typeof(DateTime);
				
				/// <inheritdoc />
				public string Name => "FirstUseDate";
				
				/// <inheritdoc />
				public string Summary => @"&#10;&#10;&#10;date {{term(raw material)}} was first used.&#10;
";

				/// <inheritdoc />
				public string AccessModifier => "public";
				
				/// <inheritdoc />
				public string Modifier => "";
				
				/// <inheritdoc />
				public string NormativeVersion => "1.8";
				
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
			/// <inheritdoc cref="LastUseDateProperty" path="/summary" /><br/>
			/// <remarks>Original Name: LastUseDate</remarks>
			/// </summary>
			public LastUseDateProperty LastUseDate { get; } = new LastUseDateProperty();
			/// <summary>
			﻿/// date <i>raw material</i> was last used.<br/><br />

			/// </summary>
			public sealed class LastUseDateProperty : IProperty
			{
				/// <summary>
				/// <inheritdoc />
				/// <remarks>
				/// <list type="bullet">
				/// <item>Original Type: _19_0_3_91b028d_1579272233011_597138_670</item>
				/// <item>Type: DateTime</item>
				/// <item>Namespace: </item>
				/// </list>
				/// </remarks>
				/// </summary>
				public System.Type Type => typeof(DateTime);
				
				/// <inheritdoc />
				public string Name => "LastUseDate";
				
				/// <inheritdoc />
				public string Summary => @"&#10;&#10;&#10;date {{term(raw material)}} was last used.&#10;
";

				/// <inheritdoc />
				public string AccessModifier => "public";
				
				/// <inheritdoc />
				public string Modifier => "";
				
				/// <inheritdoc />
				public string NormativeVersion => "1.8";
				
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
			/// <inheritdoc cref="InitialVolumeProperty" path="/summary" /><br/>
			/// <remarks>Original Name: InitialVolume</remarks>
			/// </summary>
			public InitialVolumeProperty InitialVolume { get; } = new InitialVolumeProperty();
			/// <summary>
			﻿/// amount of material initially placed in <i>raw material</i> when manufactured.<br/><br />

			/// </summary>
			public sealed class InitialVolumeProperty : IProperty
			{
				/// <summary>
				/// <inheritdoc />
				/// <remarks>
				/// <list type="bullet">
				/// <item>Original Type: _19_0_3_68e0225_1636369375198_732959_178</item>
				/// <item>Type: Single</item>
				/// <item>Namespace: </item>
				/// </list>
				/// </remarks>
				/// </summary>
				public System.Type Type => typeof(Single);
				
				/// <inheritdoc />
				public string Name => "InitialVolume";
				
				/// <inheritdoc />
				public string Summary => @"&#10;&#10;&#10;amount of material initially placed in {{term(raw material)}} when manufactured.&#10;
";

				/// <inheritdoc />
				public string AccessModifier => "public";
				
				/// <inheritdoc />
				public string Modifier => "";
				
				/// <inheritdoc />
				public string NormativeVersion => "1.8";
				
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
			/// <inheritdoc cref="InitialDimensionProperty" path="/summary" /><br/>
			/// <remarks>Original Name: InitialDimension</remarks>
			/// </summary>
			public InitialDimensionProperty InitialDimension { get; } = new InitialDimensionProperty();
			/// <summary>
			﻿/// dimension of material initially placed in <i>raw material</i> when manufactured.<br/><br />

			/// </summary>
			public sealed class InitialDimensionProperty : IProperty
			{
				/// <summary>
				/// <inheritdoc />
				/// <remarks>
				/// <list type="bullet">
				/// <item>Original Type: _19_0_3_68e0225_1620212518801_972048_162</item>
				/// <item>Type: Single</item>
				/// <item>Namespace: </item>
				/// </list>
				/// </remarks>
				/// </summary>
				public System.Type Type => typeof(Single);
				
				/// <inheritdoc />
				public string Name => "InitialDimension";
				
				/// <inheritdoc />
				public string Summary => @"&#10;&#10;&#10;dimension of material initially placed in {{term(raw material)}} when manufactured.&#10;
";

				/// <inheritdoc />
				public string AccessModifier => "public";
				
				/// <inheritdoc />
				public string Modifier => "";
				
				/// <inheritdoc />
				public string NormativeVersion => "1.8";
				
				/// <inheritdoc />
				public string DeprecatedVersion => "";
				
				/// <inheritdoc />
				public string Aggregation => "composite";

				// Note: Extension.Extender
				/// <inheritdoc />
				public string Extension => "";
				
				/// <inheritdoc />
				public string Association => "";

				// Note: DefaultValue.Name
				/// <inheritdoc />
				public string DefaultValue => "";
			}
			/// <summary>
			/// <inheritdoc cref="InitialQuantityProperty" path="/summary" /><br/>
			/// <remarks>Original Name: InitialQuantity</remarks>
			/// </summary>
			public InitialQuantityProperty InitialQuantity { get; } = new InitialQuantityProperty();
			/// <summary>
			﻿/// quantity of material initially placed in <i>raw material</i> when manufactured.<br/><br />

			/// </summary>
			public sealed class InitialQuantityProperty : IProperty
			{
				/// <summary>
				/// <inheritdoc />
				/// <remarks>
				/// <list type="bullet">
				/// <item>Original Type: _19_0_3_91b028d_1579272271512_537408_674</item>
				/// <item>Type: Int32</item>
				/// <item>Namespace: </item>
				/// </list>
				/// </remarks>
				/// </summary>
				public System.Type Type => typeof(Int32);
				
				/// <inheritdoc />
				public string Name => "InitialQuantity";
				
				/// <inheritdoc />
				public string Summary => @"&#10;&#10;&#10;quantity of material initially placed in {{term(raw material)}} when manufactured.&#10;
";

				/// <inheritdoc />
				public string AccessModifier => "public";
				
				/// <inheritdoc />
				public string Modifier => "";
				
				/// <inheritdoc />
				public string NormativeVersion => "1.8";
				
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
			/// <inheritdoc cref="CurrentVolumeProperty" path="/summary" /><br/>
			/// <remarks>Original Name: CurrentVolume</remarks>
			/// </summary>
			public CurrentVolumeProperty CurrentVolume { get; } = new CurrentVolumeProperty();
			/// <summary>
			﻿/// amount of material currently in <i>raw material</i>.<br/><br />

			/// </summary>
			public sealed class CurrentVolumeProperty : IProperty
			{
				/// <summary>
				/// <inheritdoc />
				/// <remarks>
				/// <list type="bullet">
				/// <item>Original Type: _19_0_3_68e0225_1636369375198_732959_178</item>
				/// <item>Type: Single</item>
				/// <item>Namespace: </item>
				/// </list>
				/// </remarks>
				/// </summary>
				public System.Type Type => typeof(Single);
				
				/// <inheritdoc />
				public string Name => "CurrentVolume";
				
				/// <inheritdoc />
				public string Summary => @"&#10;&#10;&#10;amount of material currently in {{term(raw material)}}.&#10;
";

				/// <inheritdoc />
				public string AccessModifier => "public";
				
				/// <inheritdoc />
				public string Modifier => "";
				
				/// <inheritdoc />
				public string NormativeVersion => "1.8";
				
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
			/// <inheritdoc cref="CurrentDimensionProperty" path="/summary" /><br/>
			/// <remarks>Original Name: CurrentDimension</remarks>
			/// </summary>
			public CurrentDimensionProperty CurrentDimension { get; } = new CurrentDimensionProperty();
			/// <summary>
			﻿/// dimension of material currently in <i>raw material</i>.<br/><br />

			/// </summary>
			public sealed class CurrentDimensionProperty : IProperty
			{
				/// <summary>
				/// <inheritdoc />
				/// <remarks>
				/// <list type="bullet">
				/// <item>Original Type: _19_0_3_68e0225_1620212518801_972048_162</item>
				/// <item>Type: Single</item>
				/// <item>Namespace: </item>
				/// </list>
				/// </remarks>
				/// </summary>
				public System.Type Type => typeof(Single);
				
				/// <inheritdoc />
				public string Name => "CurrentDimension";
				
				/// <inheritdoc />
				public string Summary => @"&#10;&#10;&#10;dimension of material currently in {{term(raw material)}}.&#10;
";

				/// <inheritdoc />
				public string AccessModifier => "public";
				
				/// <inheritdoc />
				public string Modifier => "";
				
				/// <inheritdoc />
				public string NormativeVersion => "1.8";
				
				/// <inheritdoc />
				public string DeprecatedVersion => "";
				
				/// <inheritdoc />
				public string Aggregation => "composite";

				// Note: Extension.Extender
				/// <inheritdoc />
				public string Extension => "";
				
				/// <inheritdoc />
				public string Association => "";

				// Note: DefaultValue.Name
				/// <inheritdoc />
				public string DefaultValue => "";
			}
			/// <summary>
			/// <inheritdoc cref="CurrentQuantityProperty" path="/summary" /><br/>
			/// <remarks>Original Name: CurrentQuantity</remarks>
			/// </summary>
			public CurrentQuantityProperty CurrentQuantity { get; } = new CurrentQuantityProperty();
			/// <summary>
			﻿/// quantity of material currently in <i>raw material</i>.<br/><br />

			/// </summary>
			public sealed class CurrentQuantityProperty : IProperty
			{
				/// <summary>
				/// <inheritdoc />
				/// <remarks>
				/// <list type="bullet">
				/// <item>Original Type: _19_0_3_91b028d_1579272271512_537408_674</item>
				/// <item>Type: Int32</item>
				/// <item>Namespace: </item>
				/// </list>
				/// </remarks>
				/// </summary>
				public System.Type Type => typeof(Int32);
				
				/// <inheritdoc />
				public string Name => "CurrentQuantity";
				
				/// <inheritdoc />
				public string Summary => @"&#10;&#10;&#10;quantity of material currently in {{term(raw material)}}.&#10;
";

				/// <inheritdoc />
				public string AccessModifier => "public";
				
				/// <inheritdoc />
				public string Modifier => "";
				
				/// <inheritdoc />
				public string NormativeVersion => "1.8";
				
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