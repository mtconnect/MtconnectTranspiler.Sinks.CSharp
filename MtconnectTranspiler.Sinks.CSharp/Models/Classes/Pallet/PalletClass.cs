#pragma warning disable CS0109 // Member does not hide an inherited member; new keyword is not required
#pragma warning disable CS1574 // XML comment has cref attribute that could not be resolved
#pragma warning disable CS1584 // XML comment has syntactically incorrect cref attribute
#pragma warning disable CS0618 // Type or member is obsolete
using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;
using System.Linq;

namespace Mtconnect.AssetInformationModel.Pallet
{
	/// <summary>﻿<see cref="PhysicalAsset">PhysicalAsset</see> that has a portable platform for handling, storing, or moving materials, parts, blanks etc.<br /><br /><br />
	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Structure___2024x_68e0225_1727793137466_630771_23584">model.mtconnect.org</seealso> for more information.
	/// </summary>
	/// <remarks>
	/// <list type="bullet">
	/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_2.5">v2.5</see></item>
	/// </list>
	/// </remarks>

	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public sealed class PalletClass : IClass
	{
		/// <summary>Constant value for <see cref="PalletClass.ReferenceId" /></summary>
		public const string REFERENCE_ID = "_2024x_68e0225_1727793137466_630771_23584";
		/// <summary>Constant value for <see cref="PalletClass.HelpUrl" /></summary>
		public const string HELP_URL = "https://model.mtconnect.org/#Structure___2024x_68e0225_1727793137466_630771_23584";
		/// <summary>Constant value for <see cref="PalletClass.Summary" /></summary>
		public const string SUMMARY = @"&#10;&#10;&#10;{{block(PhysicalAsset)}} that has a portable platform for handling, storing, or moving materials, parts, blanks etc.&#10;
";
		/// <summary>Constant value for <see cref="PalletClass.Name" /></summary>
		public const string NAME = "Pallet";
		/// <summary>Constant value for <see cref="PalletClass.AccessModifier" /></summary>
		public const string ACCESS_MODIFIER = "public";
		/// <summary>Constant value for <see cref="PalletClass.Modifier" /></summary>
		public const string MODIFIER = "";
		/// <summary>Constant value for <see cref="PalletClass.NormativeVersion" /></summary>
		public const string NORMATIVE_VERSION = "2.5";
		/// <summary>Constant value for <see cref="PalletClass.DeprecatedVersion" /></summary>
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
		/// Original Type: _2024x_68e0225_1727791480187_194742_23509
		/// </remarks>
		public Type Generalization => typeof(Mtconnect.AssetInformationModel.PhysicalAssetGeneralization);

		/// <inheritdoc />
		public new PalletClassProperties Properties { get; } = new PalletClassProperties();
        IPropertyList IClass.Properties => Properties;
		/// <summary>
		/// Property list for <see cref="PalletClass" />.
		/// <br/><b>Note</b>, some properties (<see cref="IProperty" />) are inherited from <see cref="Mtconnect.AssetInformationModel.PhysicalAssetGeneralization.PhysicalAssetGeneralizationProperties" />.
		/// </summary>
		public class PalletClassProperties : Mtconnect.AssetInformationModel.PhysicalAssetGeneralization.PhysicalAssetGeneralizationProperties
		{
			/// <inheritdoc />
			public override IProperty[] Properties => new IProperty[] {
				Type,
				PalletId,
				PalletNumber,
				ClampingMethod,
				MountingMethod,
			}.Concat(base.Properties).ToArray();
			/// <summary>
			/// <inheritdoc cref="TypeProperty" path="/summary" /><br/>
			/// <remarks>Original Name: Type</remarks>
			/// </summary>
			public new TypeProperty Type { get; } = new TypeProperty();
			
			/// <summary>﻿type of <see cref="Pallet">Pallet</see>. <br /><br />Common types of pallet include: Process, Warehouse, Shipping, Fixture and Machine.<br /><br /><br />
			/// </summary>
			public new sealed class TypeProperty : IProperty
			{
				/// <summary>Constant value for <see cref="TypeProperty.Name" /></summary>
				public const string NAME = "Type";
				/// <summary>Constant value for <see cref="TypeProperty.Summary" /></summary>
				public const string SUMMARY = @"&#10;&#10;&#10;type of {{block(Pallet)}}. 

Common types of pallet include: Process, Warehouse, Shipping, Fixture and Machine.&#10;
";
				/// <summary>Constant value for <see cref="TypeProperty.AccessModifier" /></summary>
				public const string ACCESS_MODIFIER = "private";
				/// <summary>Constant value for <see cref="TypeProperty.Modifier" /></summary>
				public const string MODIFIER = "";
				/// <summary>Constant value for <see cref="TypeProperty.NormativeVersion" /></summary>
				public const string NORMATIVE_VERSION = "2.5";
				/// <summary>Constant value for <see cref="TypeProperty.DeprecatedVersion" /></summary>
				public const string DEPRECATED_VERSION = "";
				/// <summary>Constant value for <see cref="TypeProperty.Aggregation" /></summary>
				public const string AGGREGATION = "composite";
				/// <summary>Constant value for <see cref="TypeProperty.Extension" /></summary>
				public const string EXTENSION = "MagicDraw UML 2024x";
				/// <summary>Constant value for <see cref="TypeProperty.Association" /></summary>
				public const string ASSOCIATION = "";
				/// <summary>Constant value for <see cref="TypeProperty.DefaultValue" /></summary>
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
			/// <inheritdoc cref="PalletIdProperty" path="/summary" /><br/>
			/// <remarks>Original Name: PalletId</remarks>
			/// </summary>
			public new PalletIdProperty PalletId { get; } = new PalletIdProperty();
			
			/// <summary>﻿identifier of the <see cref="Pallet">Pallet</see>.<br /><br /><br />
			/// </summary>
			public new sealed class PalletIdProperty : IProperty
			{
				/// <summary>Constant value for <see cref="PalletIdProperty.Name" /></summary>
				public const string NAME = "PalletId";
				/// <summary>Constant value for <see cref="PalletIdProperty.Summary" /></summary>
				public const string SUMMARY = @"&#10;&#10;&#10;identifier of the {{block(Pallet)}}.&#10;
";
				/// <summary>Constant value for <see cref="PalletIdProperty.AccessModifier" /></summary>
				public const string ACCESS_MODIFIER = "private";
				/// <summary>Constant value for <see cref="PalletIdProperty.Modifier" /></summary>
				public const string MODIFIER = "";
				/// <summary>Constant value for <see cref="PalletIdProperty.NormativeVersion" /></summary>
				public const string NORMATIVE_VERSION = "2.5";
				/// <summary>Constant value for <see cref="PalletIdProperty.DeprecatedVersion" /></summary>
				public const string DEPRECATED_VERSION = "";
				/// <summary>Constant value for <see cref="PalletIdProperty.Aggregation" /></summary>
				public const string AGGREGATION = "composite";
				/// <summary>Constant value for <see cref="PalletIdProperty.Extension" /></summary>
				public const string EXTENSION = "MagicDraw UML 2024x";
				/// <summary>Constant value for <see cref="PalletIdProperty.Association" /></summary>
				public const string ASSOCIATION = "";
				/// <summary>Constant value for <see cref="PalletIdProperty.DefaultValue" /></summary>
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
			/// <inheritdoc cref="PalletNumberProperty" path="/summary" /><br/>
			/// <remarks>Original Name: PalletNumber</remarks>
			/// </summary>
			public new PalletNumberProperty PalletNumber { get; } = new PalletNumberProperty();
			
			/// <summary>﻿number or sequence assigned to the <see cref="Pallet">Pallet</see> in a group of <see cref="Pallet">Pallet</see>s.<br /><br /><br />
			/// </summary>
			public new sealed class PalletNumberProperty : IProperty
			{
				/// <summary>Constant value for <see cref="PalletNumberProperty.Name" /></summary>
				public const string NAME = "PalletNumber";
				/// <summary>Constant value for <see cref="PalletNumberProperty.Summary" /></summary>
				public const string SUMMARY = @"&#10;&#10;&#10;number or sequence assigned to the {{block(Pallet)}} in a group of {{block(Pallet)}}s.&#10;
";
				/// <summary>Constant value for <see cref="PalletNumberProperty.AccessModifier" /></summary>
				public const string ACCESS_MODIFIER = "private";
				/// <summary>Constant value for <see cref="PalletNumberProperty.Modifier" /></summary>
				public const string MODIFIER = "";
				/// <summary>Constant value for <see cref="PalletNumberProperty.NormativeVersion" /></summary>
				public const string NORMATIVE_VERSION = "2.5";
				/// <summary>Constant value for <see cref="PalletNumberProperty.DeprecatedVersion" /></summary>
				public const string DEPRECATED_VERSION = "";
				/// <summary>Constant value for <see cref="PalletNumberProperty.Aggregation" /></summary>
				public const string AGGREGATION = "composite";
				/// <summary>Constant value for <see cref="PalletNumberProperty.Extension" /></summary>
				public const string EXTENSION = "MagicDraw UML 2024x";
				/// <summary>Constant value for <see cref="PalletNumberProperty.Association" /></summary>
				public const string ASSOCIATION = "";
				/// <summary>Constant value for <see cref="PalletNumberProperty.DefaultValue" /></summary>
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
			/// <inheritdoc cref="ClampingMethodProperty" path="/summary" /><br/>
			/// <remarks>Original Name: ClampingMethod</remarks>
			/// </summary>
			public new ClampingMethodProperty ClampingMethod { get; } = new ClampingMethodProperty();
			
			/// <summary>﻿actuation type of the <see cref="Pallet">Pallet</see>'s clamping mechanism.<br /><br /><br />
			/// </summary>
			public new sealed class ClampingMethodProperty : IProperty
			{
				/// <summary>Constant value for <see cref="ClampingMethodProperty.Name" /></summary>
				public const string NAME = "ClampingMethod";
				/// <summary>Constant value for <see cref="ClampingMethodProperty.Summary" /></summary>
				public const string SUMMARY = @"&#10;&#10;&#10;actuation type of the {{block(Pallet)}}'s clamping mechanism.&#10;
";
				/// <summary>Constant value for <see cref="ClampingMethodProperty.AccessModifier" /></summary>
				public const string ACCESS_MODIFIER = "private";
				/// <summary>Constant value for <see cref="ClampingMethodProperty.Modifier" /></summary>
				public const string MODIFIER = "";
				/// <summary>Constant value for <see cref="ClampingMethodProperty.NormativeVersion" /></summary>
				public const string NORMATIVE_VERSION = "2.5";
				/// <summary>Constant value for <see cref="ClampingMethodProperty.DeprecatedVersion" /></summary>
				public const string DEPRECATED_VERSION = "";
				/// <summary>Constant value for <see cref="ClampingMethodProperty.Aggregation" /></summary>
				public const string AGGREGATION = "composite";
				/// <summary>Constant value for <see cref="ClampingMethodProperty.Extension" /></summary>
				public const string EXTENSION = "MagicDraw UML 2024x";
				/// <summary>Constant value for <see cref="ClampingMethodProperty.Association" /></summary>
				public const string ASSOCIATION = "";
				/// <summary>Constant value for <see cref="ClampingMethodProperty.DefaultValue" /></summary>
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
			/// <inheritdoc cref="MountingMethodProperty" path="/summary" /><br/>
			/// <remarks>Original Name: MountingMethod</remarks>
			/// </summary>
			public new MountingMethodProperty MountingMethod { get; } = new MountingMethodProperty();
			
			/// <summary>﻿actuation type of the <see cref="Pallet">Pallet</see>'s mounting mechanism.<br /><br /><br />
			/// </summary>
			public new sealed class MountingMethodProperty : IProperty
			{
				/// <summary>Constant value for <see cref="MountingMethodProperty.Name" /></summary>
				public const string NAME = "MountingMethod";
				/// <summary>Constant value for <see cref="MountingMethodProperty.Summary" /></summary>
				public const string SUMMARY = @"&#10;&#10;&#10;actuation type of the {{block(Pallet)}}'s mounting mechanism.&#10;
";
				/// <summary>Constant value for <see cref="MountingMethodProperty.AccessModifier" /></summary>
				public const string ACCESS_MODIFIER = "private";
				/// <summary>Constant value for <see cref="MountingMethodProperty.Modifier" /></summary>
				public const string MODIFIER = "";
				/// <summary>Constant value for <see cref="MountingMethodProperty.NormativeVersion" /></summary>
				public const string NORMATIVE_VERSION = "2.5";
				/// <summary>Constant value for <see cref="MountingMethodProperty.DeprecatedVersion" /></summary>
				public const string DEPRECATED_VERSION = "";
				/// <summary>Constant value for <see cref="MountingMethodProperty.Aggregation" /></summary>
				public const string AGGREGATION = "composite";
				/// <summary>Constant value for <see cref="MountingMethodProperty.Extension" /></summary>
				public const string EXTENSION = "MagicDraw UML 2024x";
				/// <summary>Constant value for <see cref="MountingMethodProperty.Association" /></summary>
				public const string ASSOCIATION = "";
				/// <summary>Constant value for <see cref="MountingMethodProperty.DefaultValue" /></summary>
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
		};

	}
}