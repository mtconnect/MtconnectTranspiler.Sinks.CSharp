#pragma warning disable CS0109 // Member does not hide an inherited member; new keyword is not required
#pragma warning disable CS1574 // XML comment has cref attribute that could not be resolved
#pragma warning disable CS1584 // XML comment has syntactically incorrect cref attribute
#pragma warning disable CS0618 // Type or member is obsolete
using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;
using System.Linq;

namespace Mtconnect.AssetInformationModel.Fixture
{
	/// <summary>﻿
	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Structure___2024x_68e0225_1727793125239_4425_23553">model.mtconnect.org</seealso> for more information.
	/// </summary>
	/// <remarks>
	/// <list type="bullet">
	/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_2.5">v2.5</see></item>
	/// </list>
	/// </remarks>

	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public sealed class FixtureClass : IClass
	{
		/// <summary>Constant value for <see cref="FixtureClass.ReferenceId" /></summary>
		public const string REFERENCE_ID = "_2024x_68e0225_1727793125239_4425_23553";
		/// <summary>Constant value for <see cref="FixtureClass.HelpUrl" /></summary>
		public const string HELP_URL = "https://model.mtconnect.org/#Structure___2024x_68e0225_1727793125239_4425_23553";
		/// <summary>Constant value for <see cref="FixtureClass.Summary" /></summary>
		public const string SUMMARY = @"";
		/// <summary>Constant value for <see cref="FixtureClass.Name" /></summary>
		public const string NAME = "Fixture";
		/// <summary>Constant value for <see cref="FixtureClass.AccessModifier" /></summary>
		public const string ACCESS_MODIFIER = "public";
		/// <summary>Constant value for <see cref="FixtureClass.Modifier" /></summary>
		public const string MODIFIER = "";
		/// <summary>Constant value for <see cref="FixtureClass.NormativeVersion" /></summary>
		public const string NORMATIVE_VERSION = "2.5";
		/// <summary>Constant value for <see cref="FixtureClass.DeprecatedVersion" /></summary>
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
		public new FixtureClassProperties Properties { get; } = new FixtureClassProperties();
        IPropertyList IClass.Properties => Properties;
		/// <summary>
		/// Property list for <see cref="FixtureClass" />.
		/// <br/><b>Note</b>, some properties (<see cref="IProperty" />) are inherited from <see cref="Mtconnect.AssetInformationModel.PhysicalAssetGeneralization.PhysicalAssetGeneralizationProperties" />.
		/// </summary>
		public class FixtureClassProperties : Mtconnect.AssetInformationModel.PhysicalAssetGeneralization.PhysicalAssetGeneralizationProperties
		{
			/// <inheritdoc />
			public override IProperty[] Properties => new IProperty[] {
				FixtureId,
				FixtureNumber,
				ClampingMethod,
				MountingMethod,
			}.Concat(base.Properties).ToArray();
			/// <summary>
			/// <inheritdoc cref="FixtureIdProperty" path="/summary" /><br/>
			/// <remarks>Original Name: FixtureId</remarks>
			/// </summary>
			public new FixtureIdProperty FixtureId { get; } = new FixtureIdProperty();
			
			/// <summary>﻿identifier of the <see cref="Pallet">Pallet</see>.<br /><br /><br />
			/// </summary>
			public new sealed class FixtureIdProperty : IProperty
			{
				/// <summary>Constant value for <see cref="FixtureIdProperty.Name" /></summary>
				public const string NAME = "FixtureId";
				/// <summary>Constant value for <see cref="FixtureIdProperty.Summary" /></summary>
				public const string SUMMARY = @"&#10;&#10;&#10;identifier of the {{block(Pallet)}}.&#10;
";
				/// <summary>Constant value for <see cref="FixtureIdProperty.AccessModifier" /></summary>
				public const string ACCESS_MODIFIER = "private";
				/// <summary>Constant value for <see cref="FixtureIdProperty.Modifier" /></summary>
				public const string MODIFIER = "";
				/// <summary>Constant value for <see cref="FixtureIdProperty.NormativeVersion" /></summary>
				public const string NORMATIVE_VERSION = "2.5";
				/// <summary>Constant value for <see cref="FixtureIdProperty.DeprecatedVersion" /></summary>
				public const string DEPRECATED_VERSION = "";
				/// <summary>Constant value for <see cref="FixtureIdProperty.Aggregation" /></summary>
				public const string AGGREGATION = "composite";
				/// <summary>Constant value for <see cref="FixtureIdProperty.Extension" /></summary>
				public const string EXTENSION = "MagicDraw UML 2024x";
				/// <summary>Constant value for <see cref="FixtureIdProperty.Association" /></summary>
				public const string ASSOCIATION = "";
				/// <summary>Constant value for <see cref="FixtureIdProperty.DefaultValue" /></summary>
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
			/// <inheritdoc cref="FixtureNumberProperty" path="/summary" /><br/>
			/// <remarks>Original Name: FixtureNumber</remarks>
			/// </summary>
			public new FixtureNumberProperty FixtureNumber { get; } = new FixtureNumberProperty();
			
			/// <summary>﻿number or sequence assigned to the <see cref="Fixture">Fixture</see> in a group of <see cref="Fixture">Fixture</see>s.<br /><br /><br />
			/// </summary>
			public new sealed class FixtureNumberProperty : IProperty
			{
				/// <summary>Constant value for <see cref="FixtureNumberProperty.Name" /></summary>
				public const string NAME = "FixtureNumber";
				/// <summary>Constant value for <see cref="FixtureNumberProperty.Summary" /></summary>
				public const string SUMMARY = @"&#10;&#10;&#10;number or sequence assigned to the {{block(Fixture)}} in a group of {{block(Fixture)}}s.&#10;
";
				/// <summary>Constant value for <see cref="FixtureNumberProperty.AccessModifier" /></summary>
				public const string ACCESS_MODIFIER = "private";
				/// <summary>Constant value for <see cref="FixtureNumberProperty.Modifier" /></summary>
				public const string MODIFIER = "";
				/// <summary>Constant value for <see cref="FixtureNumberProperty.NormativeVersion" /></summary>
				public const string NORMATIVE_VERSION = "2.5";
				/// <summary>Constant value for <see cref="FixtureNumberProperty.DeprecatedVersion" /></summary>
				public const string DEPRECATED_VERSION = "";
				/// <summary>Constant value for <see cref="FixtureNumberProperty.Aggregation" /></summary>
				public const string AGGREGATION = "composite";
				/// <summary>Constant value for <see cref="FixtureNumberProperty.Extension" /></summary>
				public const string EXTENSION = "MagicDraw UML 2024x";
				/// <summary>Constant value for <see cref="FixtureNumberProperty.Association" /></summary>
				public const string ASSOCIATION = "";
				/// <summary>Constant value for <see cref="FixtureNumberProperty.DefaultValue" /></summary>
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
			
			/// <summary>﻿actuation type of the <see cref="Fixture">Fixture</see>'s clamping mechanism.<br /><br /><br />
			/// </summary>
			public new sealed class ClampingMethodProperty : IProperty
			{
				/// <summary>Constant value for <see cref="ClampingMethodProperty.Name" /></summary>
				public const string NAME = "ClampingMethod";
				/// <summary>Constant value for <see cref="ClampingMethodProperty.Summary" /></summary>
				public const string SUMMARY = @"&#10;&#10;&#10;actuation type of the {{block(Fixture)}}'s clamping mechanism.&#10;
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
			
			/// <summary>﻿actuation type of the <see cref="Fixture">Fixture</see>'s mounting mechanism.<br /><br /><br />
			/// </summary>
			public new sealed class MountingMethodProperty : IProperty
			{
				/// <summary>Constant value for <see cref="MountingMethodProperty.Name" /></summary>
				public const string NAME = "MountingMethod";
				/// <summary>Constant value for <see cref="MountingMethodProperty.Summary" /></summary>
				public const string SUMMARY = @"&#10;&#10;&#10;actuation type of the {{block(Fixture)}}'s mounting mechanism.&#10;
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