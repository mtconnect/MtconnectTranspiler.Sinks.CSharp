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
	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Structure___19_0_3_68e0225_1696869014788_515272_2985">model.mtconnect.org</seealso> for more information.
	/// </summary>
	/// <remarks>
	/// <list type="bullet">
	/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_2.3">v2.3</see></item>
	/// </list>
	/// </remarks>

	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public sealed class LocationAddressResultClass : IClass
	{
		/// <summary>Constant value for <see cref="LocationAddressResultClass.ReferenceId" /></summary>
		public const string REFERENCE_ID = "_19_0_3_68e0225_1696869014788_515272_2985";
		/// <summary>Constant value for <see cref="LocationAddressResultClass.HelpUrl" /></summary>
		public const string HELP_URL = "https://model.mtconnect.org/#Structure___19_0_3_68e0225_1696869014788_515272_2985";
		/// <summary>Constant value for <see cref="LocationAddressResultClass.Summary" /></summary>
		public const string SUMMARY = @"";
		/// <summary>Constant value for <see cref="LocationAddressResultClass.Name" /></summary>
		public const string NAME = "LocationAddressResult";
		/// <summary>Constant value for <see cref="LocationAddressResultClass.AccessModifier" /></summary>
		public const string ACCESS_MODIFIER = "public";
		/// <summary>Constant value for <see cref="LocationAddressResultClass.Modifier" /></summary>
		public const string MODIFIER = "";
		/// <summary>Constant value for <see cref="LocationAddressResultClass.NormativeVersion" /></summary>
		public const string NORMATIVE_VERSION = "2.3";
		/// <summary>Constant value for <see cref="LocationAddressResultClass.DeprecatedVersion" /></summary>
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
		/// Original Type: _19_0_3_45f01b9_1579566531114_503405_25727
		/// </remarks>
		public Type Generalization => typeof(Mtconnect.ObservationInformationModel.Representations.DataSetClass);

		/// <inheritdoc />
		public new LocationAddressResultClassProperties Properties { get; } = new LocationAddressResultClassProperties();
        IPropertyList IClass.Properties => Properties;
		/// <summary>
		/// Property list for <see cref="LocationAddressResultClass" />.
		/// <br/><b>Note</b>, some properties (<see cref="IProperty" />) are inherited from <see cref="Mtconnect.ObservationInformationModel.Representations.DataSetClass.DataSetClassProperties" />.
		/// </summary>
		public class LocationAddressResultClassProperties : Mtconnect.ObservationInformationModel.Representations.DataSetClass.DataSetClassProperties
		{
			/// <inheritdoc />
			public override IProperty[] Properties => new IProperty[] {
				GivenName,
				Surname,
				Qualification,
				NameQualifier,
				OrganizationName,
				LegalStatus,
				OrganizationUnit,
				Building,
				Floor,
				Door,
				Thoroughfare,
				PremiseIdentifier,
				Town,
				Region,
				District,
				CountryName,
				CountryCode,
				PostCode,
			}.Concat(base.Properties).ToArray();
			/// <summary>
			/// <inheritdoc cref="GivenNameProperty" path="/summary" /><br/>
			/// <remarks>Original Name: GivenName</remarks>
			/// </summary>
			public new GivenNameProperty GivenName { get; } = new GivenNameProperty();
			
			/// <summary>﻿element specifying the name used to distinguish between persons having the same surname(s) and who may have access to a particular delivery point.<br /><br /><br />
			/// </summary>
			public new sealed class GivenNameProperty : IProperty
			{
				/// <summary>Constant value for <see cref="GivenNameProperty.Name" /></summary>
				public const string NAME = "GivenName";
				/// <summary>Constant value for <see cref="GivenNameProperty.Summary" /></summary>
				public const string SUMMARY = @"&#10;&#10;&#10;element specifying the name used to distinguish between persons having the same surname(s) and who may have access to a particular delivery point.&#10;
";
				/// <summary>Constant value for <see cref="GivenNameProperty.AccessModifier" /></summary>
				public const string ACCESS_MODIFIER = "public";
				/// <summary>Constant value for <see cref="GivenNameProperty.Modifier" /></summary>
				public const string MODIFIER = "";
				/// <summary>Constant value for <see cref="GivenNameProperty.NormativeVersion" /></summary>
				public const string NORMATIVE_VERSION = "2.3";
				/// <summary>Constant value for <see cref="GivenNameProperty.DeprecatedVersion" /></summary>
				public const string DEPRECATED_VERSION = "";
				/// <summary>Constant value for <see cref="GivenNameProperty.Aggregation" /></summary>
				public const string AGGREGATION = "composite";
				/// <summary>Constant value for <see cref="GivenNameProperty.Extension" /></summary>
				public const string EXTENSION = "MagicDraw UML 2024x";
				/// <summary>Constant value for <see cref="GivenNameProperty.Association" /></summary>
				public const string ASSOCIATION = "";
				/// <summary>Constant value for <see cref="GivenNameProperty.DefaultValue" /></summary>
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
			/// <inheritdoc cref="SurnameProperty" path="/summary" /><br/>
			/// <remarks>Original Name: Surname</remarks>
			/// </summary>
			public new SurnameProperty Surname { get; } = new SurnameProperty();
			
			/// <summary>﻿element which identifies the family or parentage of an individual.<br /><br /><br />
			/// </summary>
			public new sealed class SurnameProperty : IProperty
			{
				/// <summary>Constant value for <see cref="SurnameProperty.Name" /></summary>
				public const string NAME = "Surname";
				/// <summary>Constant value for <see cref="SurnameProperty.Summary" /></summary>
				public const string SUMMARY = @"&#10;&#10;&#10;element which identifies the family or parentage of an individual.&#10;
";
				/// <summary>Constant value for <see cref="SurnameProperty.AccessModifier" /></summary>
				public const string ACCESS_MODIFIER = "public";
				/// <summary>Constant value for <see cref="SurnameProperty.Modifier" /></summary>
				public const string MODIFIER = "";
				/// <summary>Constant value for <see cref="SurnameProperty.NormativeVersion" /></summary>
				public const string NORMATIVE_VERSION = "2.3";
				/// <summary>Constant value for <see cref="SurnameProperty.DeprecatedVersion" /></summary>
				public const string DEPRECATED_VERSION = "";
				/// <summary>Constant value for <see cref="SurnameProperty.Aggregation" /></summary>
				public const string AGGREGATION = "composite";
				/// <summary>Constant value for <see cref="SurnameProperty.Extension" /></summary>
				public const string EXTENSION = "MagicDraw UML 2024x";
				/// <summary>Constant value for <see cref="SurnameProperty.Association" /></summary>
				public const string ASSOCIATION = "";
				/// <summary>Constant value for <see cref="SurnameProperty.DefaultValue" /></summary>
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
			/// <inheritdoc cref="QualificationProperty" path="/summary" /><br/>
			/// <remarks>Original Name: Qualification</remarks>
			/// </summary>
			public new QualificationProperty Qualification { get; } = new QualificationProperty();
			
			/// <summary>﻿element indicating an individual’s professional or academic qualification or rank in a professional group or society (e.g. PhD, Fellow of the Royal Society, FRS, Barrister at Law).<br /><br /><br />
			/// </summary>
			public new sealed class QualificationProperty : IProperty
			{
				/// <summary>Constant value for <see cref="QualificationProperty.Name" /></summary>
				public const string NAME = "Qualification";
				/// <summary>Constant value for <see cref="QualificationProperty.Summary" /></summary>
				public const string SUMMARY = @"&#10;&#10;&#10;element indicating an individual’s professional or academic qualification or rank in a professional group or society (e.g. PhD, Fellow of the Royal Society, FRS, Barrister at Law).&#10;
";
				/// <summary>Constant value for <see cref="QualificationProperty.AccessModifier" /></summary>
				public const string ACCESS_MODIFIER = "public";
				/// <summary>Constant value for <see cref="QualificationProperty.Modifier" /></summary>
				public const string MODIFIER = "";
				/// <summary>Constant value for <see cref="QualificationProperty.NormativeVersion" /></summary>
				public const string NORMATIVE_VERSION = "2.3";
				/// <summary>Constant value for <see cref="QualificationProperty.DeprecatedVersion" /></summary>
				public const string DEPRECATED_VERSION = "";
				/// <summary>Constant value for <see cref="QualificationProperty.Aggregation" /></summary>
				public const string AGGREGATION = "composite";
				/// <summary>Constant value for <see cref="QualificationProperty.Extension" /></summary>
				public const string EXTENSION = "MagicDraw UML 2024x";
				/// <summary>Constant value for <see cref="QualificationProperty.Association" /></summary>
				public const string ASSOCIATION = "";
				/// <summary>Constant value for <see cref="QualificationProperty.DefaultValue" /></summary>
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
			/// <inheritdoc cref="NameQualifierProperty" path="/summary" /><br/>
			/// <remarks>Original Name: NameQualifier</remarks>
			/// </summary>
			public new NameQualifierProperty NameQualifier { get; } = new NameQualifierProperty();
			
			/// <summary>﻿element used in some countries to distinguish between persons with the same surname(s) who have similar given names or initials (e.g.III, Senior, the Third.).<br /><br /><br />
			/// </summary>
			public new sealed class NameQualifierProperty : IProperty
			{
				/// <summary>Constant value for <see cref="NameQualifierProperty.Name" /></summary>
				public const string NAME = "NameQualifier";
				/// <summary>Constant value for <see cref="NameQualifierProperty.Summary" /></summary>
				public const string SUMMARY = @"&#10;&#10;&#10;element used in some countries to distinguish between persons with the same surname(s) who have similar given names or initials (e.g.III, Senior, the Third.).&#10;
";
				/// <summary>Constant value for <see cref="NameQualifierProperty.AccessModifier" /></summary>
				public const string ACCESS_MODIFIER = "public";
				/// <summary>Constant value for <see cref="NameQualifierProperty.Modifier" /></summary>
				public const string MODIFIER = "";
				/// <summary>Constant value for <see cref="NameQualifierProperty.NormativeVersion" /></summary>
				public const string NORMATIVE_VERSION = "2.3";
				/// <summary>Constant value for <see cref="NameQualifierProperty.DeprecatedVersion" /></summary>
				public const string DEPRECATED_VERSION = "";
				/// <summary>Constant value for <see cref="NameQualifierProperty.Aggregation" /></summary>
				public const string AGGREGATION = "composite";
				/// <summary>Constant value for <see cref="NameQualifierProperty.Extension" /></summary>
				public const string EXTENSION = "MagicDraw UML 2024x";
				/// <summary>Constant value for <see cref="NameQualifierProperty.Association" /></summary>
				public const string ASSOCIATION = "";
				/// <summary>Constant value for <see cref="NameQualifierProperty.DefaultValue" /></summary>
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
			/// <inheritdoc cref="OrganizationNameProperty" path="/summary" /><br/>
			/// <remarks>Original Name: OrganizationName</remarks>
			/// </summary>
			public new OrganizationNameProperty OrganizationName { get; } = new OrganizationNameProperty();
			
			/// <summary>﻿element giving the official name, the registered business name or other official designation of an organization.<br /><br /><br />
			/// </summary>
			public new sealed class OrganizationNameProperty : IProperty
			{
				/// <summary>Constant value for <see cref="OrganizationNameProperty.Name" /></summary>
				public const string NAME = "OrganizationName";
				/// <summary>Constant value for <see cref="OrganizationNameProperty.Summary" /></summary>
				public const string SUMMARY = @"&#10;&#10;&#10;element giving the official name, the registered business name or other official designation of an organization.&#10;
";
				/// <summary>Constant value for <see cref="OrganizationNameProperty.AccessModifier" /></summary>
				public const string ACCESS_MODIFIER = "public";
				/// <summary>Constant value for <see cref="OrganizationNameProperty.Modifier" /></summary>
				public const string MODIFIER = "";
				/// <summary>Constant value for <see cref="OrganizationNameProperty.NormativeVersion" /></summary>
				public const string NORMATIVE_VERSION = "2.3";
				/// <summary>Constant value for <see cref="OrganizationNameProperty.DeprecatedVersion" /></summary>
				public const string DEPRECATED_VERSION = "";
				/// <summary>Constant value for <see cref="OrganizationNameProperty.Aggregation" /></summary>
				public const string AGGREGATION = "composite";
				/// <summary>Constant value for <see cref="OrganizationNameProperty.Extension" /></summary>
				public const string EXTENSION = "MagicDraw UML 2024x";
				/// <summary>Constant value for <see cref="OrganizationNameProperty.Association" /></summary>
				public const string ASSOCIATION = "";
				/// <summary>Constant value for <see cref="OrganizationNameProperty.DefaultValue" /></summary>
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
			/// <inheritdoc cref="LegalStatusProperty" path="/summary" /><br/>
			/// <remarks>Original Name: LegalStatus</remarks>
			/// </summary>
			public new LegalStatusProperty LegalStatus { get; } = new LegalStatusProperty();
			
			/// <summary>﻿element indicating the formal registration of an organization (e.g. GmbH, Inc., Ltd.).<br /><br /><br />
			/// </summary>
			public new sealed class LegalStatusProperty : IProperty
			{
				/// <summary>Constant value for <see cref="LegalStatusProperty.Name" /></summary>
				public const string NAME = "LegalStatus";
				/// <summary>Constant value for <see cref="LegalStatusProperty.Summary" /></summary>
				public const string SUMMARY = @"&#10;&#10;&#10;element indicating the formal registration of an organization (e.g. GmbH, Inc., Ltd.).&#10;
";
				/// <summary>Constant value for <see cref="LegalStatusProperty.AccessModifier" /></summary>
				public const string ACCESS_MODIFIER = "public";
				/// <summary>Constant value for <see cref="LegalStatusProperty.Modifier" /></summary>
				public const string MODIFIER = "";
				/// <summary>Constant value for <see cref="LegalStatusProperty.NormativeVersion" /></summary>
				public const string NORMATIVE_VERSION = "2.3";
				/// <summary>Constant value for <see cref="LegalStatusProperty.DeprecatedVersion" /></summary>
				public const string DEPRECATED_VERSION = "";
				/// <summary>Constant value for <see cref="LegalStatusProperty.Aggregation" /></summary>
				public const string AGGREGATION = "composite";
				/// <summary>Constant value for <see cref="LegalStatusProperty.Extension" /></summary>
				public const string EXTENSION = "MagicDraw UML 2024x";
				/// <summary>Constant value for <see cref="LegalStatusProperty.Association" /></summary>
				public const string ASSOCIATION = "";
				/// <summary>Constant value for <see cref="LegalStatusProperty.DefaultValue" /></summary>
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
			/// <inheritdoc cref="OrganizationUnitProperty" path="/summary" /><br/>
			/// <remarks>Original Name: OrganizationUnit</remarks>
			/// </summary>
			public new OrganizationUnitProperty OrganizationUnit { get; } = new OrganizationUnitProperty();
			
			/// <summary>﻿element identifying a subdivision of an organization.<br /><br /><br />
			/// </summary>
			public new sealed class OrganizationUnitProperty : IProperty
			{
				/// <summary>Constant value for <see cref="OrganizationUnitProperty.Name" /></summary>
				public const string NAME = "OrganizationUnit";
				/// <summary>Constant value for <see cref="OrganizationUnitProperty.Summary" /></summary>
				public const string SUMMARY = @"&#10;&#10;&#10;element identifying a subdivision of an organization.&#10;
";
				/// <summary>Constant value for <see cref="OrganizationUnitProperty.AccessModifier" /></summary>
				public const string ACCESS_MODIFIER = "public";
				/// <summary>Constant value for <see cref="OrganizationUnitProperty.Modifier" /></summary>
				public const string MODIFIER = "";
				/// <summary>Constant value for <see cref="OrganizationUnitProperty.NormativeVersion" /></summary>
				public const string NORMATIVE_VERSION = "2.3";
				/// <summary>Constant value for <see cref="OrganizationUnitProperty.DeprecatedVersion" /></summary>
				public const string DEPRECATED_VERSION = "";
				/// <summary>Constant value for <see cref="OrganizationUnitProperty.Aggregation" /></summary>
				public const string AGGREGATION = "composite";
				/// <summary>Constant value for <see cref="OrganizationUnitProperty.Extension" /></summary>
				public const string EXTENSION = "MagicDraw UML 2024x";
				/// <summary>Constant value for <see cref="OrganizationUnitProperty.Association" /></summary>
				public const string ASSOCIATION = "";
				/// <summary>Constant value for <see cref="OrganizationUnitProperty.DefaultValue" /></summary>
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
			/// <inheritdoc cref="BuildingProperty" path="/summary" /><br/>
			/// <remarks>Original Name: Building</remarks>
			/// </summary>
			public new BuildingProperty Building { get; } = new BuildingProperty();
			
			/// <summary>﻿element identifying the number or name and type of the edifice or construction in or adjacent to which a delivery point is located.<br /><br /><br />
			/// </summary>
			public new sealed class BuildingProperty : IProperty
			{
				/// <summary>Constant value for <see cref="BuildingProperty.Name" /></summary>
				public const string NAME = "Building";
				/// <summary>Constant value for <see cref="BuildingProperty.Summary" /></summary>
				public const string SUMMARY = @"&#10;&#10;&#10;element identifying the number or name and type of the edifice or construction in or adjacent to which a delivery point is located.&#10;
";
				/// <summary>Constant value for <see cref="BuildingProperty.AccessModifier" /></summary>
				public const string ACCESS_MODIFIER = "public";
				/// <summary>Constant value for <see cref="BuildingProperty.Modifier" /></summary>
				public const string MODIFIER = "";
				/// <summary>Constant value for <see cref="BuildingProperty.NormativeVersion" /></summary>
				public const string NORMATIVE_VERSION = "2.3";
				/// <summary>Constant value for <see cref="BuildingProperty.DeprecatedVersion" /></summary>
				public const string DEPRECATED_VERSION = "";
				/// <summary>Constant value for <see cref="BuildingProperty.Aggregation" /></summary>
				public const string AGGREGATION = "composite";
				/// <summary>Constant value for <see cref="BuildingProperty.Extension" /></summary>
				public const string EXTENSION = "MagicDraw UML 2024x";
				/// <summary>Constant value for <see cref="BuildingProperty.Association" /></summary>
				public const string ASSOCIATION = "";
				/// <summary>Constant value for <see cref="BuildingProperty.DefaultValue" /></summary>
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
			/// <inheritdoc cref="FloorProperty" path="/summary" /><br/>
			/// <remarks>Original Name: Floor</remarks>
			/// </summary>
			public new FloorProperty Floor { get; } = new FloorProperty();
			
			/// <summary>﻿element indicating the floor or level on which a delivery point is located in a multi-story building.<br /><br /><br />
			/// </summary>
			public new sealed class FloorProperty : IProperty
			{
				/// <summary>Constant value for <see cref="FloorProperty.Name" /></summary>
				public const string NAME = "Floor";
				/// <summary>Constant value for <see cref="FloorProperty.Summary" /></summary>
				public const string SUMMARY = @"&#10;&#10;&#10;element indicating the floor or level on which a delivery point is located in a multi-story building.&#10;
";
				/// <summary>Constant value for <see cref="FloorProperty.AccessModifier" /></summary>
				public const string ACCESS_MODIFIER = "public";
				/// <summary>Constant value for <see cref="FloorProperty.Modifier" /></summary>
				public const string MODIFIER = "";
				/// <summary>Constant value for <see cref="FloorProperty.NormativeVersion" /></summary>
				public const string NORMATIVE_VERSION = "2.3";
				/// <summary>Constant value for <see cref="FloorProperty.DeprecatedVersion" /></summary>
				public const string DEPRECATED_VERSION = "";
				/// <summary>Constant value for <see cref="FloorProperty.Aggregation" /></summary>
				public const string AGGREGATION = "composite";
				/// <summary>Constant value for <see cref="FloorProperty.Extension" /></summary>
				public const string EXTENSION = "MagicDraw UML 2024x";
				/// <summary>Constant value for <see cref="FloorProperty.Association" /></summary>
				public const string ASSOCIATION = "";
				/// <summary>Constant value for <see cref="FloorProperty.DefaultValue" /></summary>
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
			/// <inheritdoc cref="DoorProperty" path="/summary" /><br/>
			/// <remarks>Original Name: Door</remarks>
			/// </summary>
			public new DoorProperty Door { get; } = new DoorProperty();
			
			/// <summary>﻿element indicating the apartment, room or office in, at or adjacent to which a delivery point, situated within a building, is located.<br /><br /><br />
			/// </summary>
			public new sealed class DoorProperty : IProperty
			{
				/// <summary>Constant value for <see cref="DoorProperty.Name" /></summary>
				public const string NAME = "Door";
				/// <summary>Constant value for <see cref="DoorProperty.Summary" /></summary>
				public const string SUMMARY = @"&#10;&#10;&#10;element indicating the apartment, room or office in, at or adjacent to which a delivery point, situated within a building, is located.&#10;
";
				/// <summary>Constant value for <see cref="DoorProperty.AccessModifier" /></summary>
				public const string ACCESS_MODIFIER = "public";
				/// <summary>Constant value for <see cref="DoorProperty.Modifier" /></summary>
				public const string MODIFIER = "";
				/// <summary>Constant value for <see cref="DoorProperty.NormativeVersion" /></summary>
				public const string NORMATIVE_VERSION = "2.3";
				/// <summary>Constant value for <see cref="DoorProperty.DeprecatedVersion" /></summary>
				public const string DEPRECATED_VERSION = "";
				/// <summary>Constant value for <see cref="DoorProperty.Aggregation" /></summary>
				public const string AGGREGATION = "composite";
				/// <summary>Constant value for <see cref="DoorProperty.Extension" /></summary>
				public const string EXTENSION = "MagicDraw UML 2024x";
				/// <summary>Constant value for <see cref="DoorProperty.Association" /></summary>
				public const string ASSOCIATION = "";
				/// <summary>Constant value for <see cref="DoorProperty.DefaultValue" /></summary>
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
			/// <inheritdoc cref="ThoroughfareProperty" path="/summary" /><br/>
			/// <remarks>Original Name: Thoroughfare</remarks>
			/// </summary>
			public new ThoroughfareProperty Thoroughfare { get; } = new ThoroughfareProperty();
			
			/// <summary>﻿element which identifies the road or part of a road or other access route along which a delivery point can be accessed, either directly or via a secondary or tertiary road or access route.<br /><br /><br />
			/// </summary>
			public new sealed class ThoroughfareProperty : IProperty
			{
				/// <summary>Constant value for <see cref="ThoroughfareProperty.Name" /></summary>
				public const string NAME = "Thoroughfare";
				/// <summary>Constant value for <see cref="ThoroughfareProperty.Summary" /></summary>
				public const string SUMMARY = @"&#10;&#10;&#10;element which identifies the road or part of a road or other access route along which a delivery point can be accessed, either directly or via a secondary or tertiary road or access route.&#10;
";
				/// <summary>Constant value for <see cref="ThoroughfareProperty.AccessModifier" /></summary>
				public const string ACCESS_MODIFIER = "public";
				/// <summary>Constant value for <see cref="ThoroughfareProperty.Modifier" /></summary>
				public const string MODIFIER = "";
				/// <summary>Constant value for <see cref="ThoroughfareProperty.NormativeVersion" /></summary>
				public const string NORMATIVE_VERSION = "2.3";
				/// <summary>Constant value for <see cref="ThoroughfareProperty.DeprecatedVersion" /></summary>
				public const string DEPRECATED_VERSION = "";
				/// <summary>Constant value for <see cref="ThoroughfareProperty.Aggregation" /></summary>
				public const string AGGREGATION = "composite";
				/// <summary>Constant value for <see cref="ThoroughfareProperty.Extension" /></summary>
				public const string EXTENSION = "MagicDraw UML 2024x";
				/// <summary>Constant value for <see cref="ThoroughfareProperty.Association" /></summary>
				public const string ASSOCIATION = "";
				/// <summary>Constant value for <see cref="ThoroughfareProperty.DefaultValue" /></summary>
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
			/// <inheritdoc cref="PremiseIdentifierProperty" path="/summary" /><br/>
			/// <remarks>Original Name: PremiseIdentifier</remarks>
			/// </summary>
			public new PremiseIdentifierProperty PremiseIdentifier { get; } = new PremiseIdentifierProperty();
			
			/// <summary>﻿element designating the area or the object on an area, adjacent to thoroughfare, in which the delivery point or delivery point access is located.<br /><br /><br />
			/// </summary>
			public new sealed class PremiseIdentifierProperty : IProperty
			{
				/// <summary>Constant value for <see cref="PremiseIdentifierProperty.Name" /></summary>
				public const string NAME = "PremiseIdentifier";
				/// <summary>Constant value for <see cref="PremiseIdentifierProperty.Summary" /></summary>
				public const string SUMMARY = @"&#10;&#10;&#10;element designating the area or the object on an area, adjacent to thoroughfare, in which the delivery point or delivery point access is located.&#10;
";
				/// <summary>Constant value for <see cref="PremiseIdentifierProperty.AccessModifier" /></summary>
				public const string ACCESS_MODIFIER = "public";
				/// <summary>Constant value for <see cref="PremiseIdentifierProperty.Modifier" /></summary>
				public const string MODIFIER = "";
				/// <summary>Constant value for <see cref="PremiseIdentifierProperty.NormativeVersion" /></summary>
				public const string NORMATIVE_VERSION = "2.3";
				/// <summary>Constant value for <see cref="PremiseIdentifierProperty.DeprecatedVersion" /></summary>
				public const string DEPRECATED_VERSION = "";
				/// <summary>Constant value for <see cref="PremiseIdentifierProperty.Aggregation" /></summary>
				public const string AGGREGATION = "composite";
				/// <summary>Constant value for <see cref="PremiseIdentifierProperty.Extension" /></summary>
				public const string EXTENSION = "MagicDraw UML 2024x";
				/// <summary>Constant value for <see cref="PremiseIdentifierProperty.Association" /></summary>
				public const string ASSOCIATION = "";
				/// <summary>Constant value for <see cref="PremiseIdentifierProperty.DefaultValue" /></summary>
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
			/// <inheritdoc cref="TownProperty" path="/summary" /><br/>
			/// <remarks>Original Name: Town</remarks>
			/// </summary>
			public new TownProperty Town { get; } = new TownProperty();
			
			/// <summary>﻿element indicating the name of the populated place in which a delivery point is located, or the populated.<br /><br /><br />
			/// </summary>
			public new sealed class TownProperty : IProperty
			{
				/// <summary>Constant value for <see cref="TownProperty.Name" /></summary>
				public const string NAME = "Town";
				/// <summary>Constant value for <see cref="TownProperty.Summary" /></summary>
				public const string SUMMARY = @"&#10;&#10;&#10;element indicating the name of the populated place in which a delivery point is located, or the populated.&#10;
";
				/// <summary>Constant value for <see cref="TownProperty.AccessModifier" /></summary>
				public const string ACCESS_MODIFIER = "public";
				/// <summary>Constant value for <see cref="TownProperty.Modifier" /></summary>
				public const string MODIFIER = "";
				/// <summary>Constant value for <see cref="TownProperty.NormativeVersion" /></summary>
				public const string NORMATIVE_VERSION = "2.3";
				/// <summary>Constant value for <see cref="TownProperty.DeprecatedVersion" /></summary>
				public const string DEPRECATED_VERSION = "";
				/// <summary>Constant value for <see cref="TownProperty.Aggregation" /></summary>
				public const string AGGREGATION = "composite";
				/// <summary>Constant value for <see cref="TownProperty.Extension" /></summary>
				public const string EXTENSION = "MagicDraw UML 2024x";
				/// <summary>Constant value for <see cref="TownProperty.Association" /></summary>
				public const string ASSOCIATION = "";
				/// <summary>Constant value for <see cref="TownProperty.DefaultValue" /></summary>
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
			/// <inheritdoc cref="RegionProperty" path="/summary" /><br/>
			/// <remarks>Original Name: Region</remarks>
			/// </summary>
			public new RegionProperty Region { get; } = new RegionProperty();
			
			/// <summary>﻿element specifying the geographic or administrative area of the country in which the town is situated.<br /><br /><br />
			/// </summary>
			public new sealed class RegionProperty : IProperty
			{
				/// <summary>Constant value for <see cref="RegionProperty.Name" /></summary>
				public const string NAME = "Region";
				/// <summary>Constant value for <see cref="RegionProperty.Summary" /></summary>
				public const string SUMMARY = @"&#10;&#10;&#10;element specifying the geographic or administrative area of the country in which the town is situated.&#10;
";
				/// <summary>Constant value for <see cref="RegionProperty.AccessModifier" /></summary>
				public const string ACCESS_MODIFIER = "public";
				/// <summary>Constant value for <see cref="RegionProperty.Modifier" /></summary>
				public const string MODIFIER = "";
				/// <summary>Constant value for <see cref="RegionProperty.NormativeVersion" /></summary>
				public const string NORMATIVE_VERSION = "2.3";
				/// <summary>Constant value for <see cref="RegionProperty.DeprecatedVersion" /></summary>
				public const string DEPRECATED_VERSION = "";
				/// <summary>Constant value for <see cref="RegionProperty.Aggregation" /></summary>
				public const string AGGREGATION = "composite";
				/// <summary>Constant value for <see cref="RegionProperty.Extension" /></summary>
				public const string EXTENSION = "MagicDraw UML 2024x";
				/// <summary>Constant value for <see cref="RegionProperty.Association" /></summary>
				public const string ASSOCIATION = "";
				/// <summary>Constant value for <see cref="RegionProperty.DefaultValue" /></summary>
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
			/// <inheritdoc cref="DistrictProperty" path="/summary" /><br/>
			/// <remarks>Original Name: District</remarks>
			/// </summary>
			public new DistrictProperty District { get; } = new DistrictProperty();
			
			/// <summary>﻿element indicating the name of the area within or adjacent to the town in which a delivery point is located, or via which it is accessed.<br /><br /><br />
			/// </summary>
			public new sealed class DistrictProperty : IProperty
			{
				/// <summary>Constant value for <see cref="DistrictProperty.Name" /></summary>
				public const string NAME = "District";
				/// <summary>Constant value for <see cref="DistrictProperty.Summary" /></summary>
				public const string SUMMARY = @"&#10;&#10;&#10;element indicating the name of the area within or adjacent to the town in which a delivery point is located, or via which it is accessed.&#10;
";
				/// <summary>Constant value for <see cref="DistrictProperty.AccessModifier" /></summary>
				public const string ACCESS_MODIFIER = "public";
				/// <summary>Constant value for <see cref="DistrictProperty.Modifier" /></summary>
				public const string MODIFIER = "";
				/// <summary>Constant value for <see cref="DistrictProperty.NormativeVersion" /></summary>
				public const string NORMATIVE_VERSION = "2.3";
				/// <summary>Constant value for <see cref="DistrictProperty.DeprecatedVersion" /></summary>
				public const string DEPRECATED_VERSION = "";
				/// <summary>Constant value for <see cref="DistrictProperty.Aggregation" /></summary>
				public const string AGGREGATION = "composite";
				/// <summary>Constant value for <see cref="DistrictProperty.Extension" /></summary>
				public const string EXTENSION = "MagicDraw UML 2024x";
				/// <summary>Constant value for <see cref="DistrictProperty.Association" /></summary>
				public const string ASSOCIATION = "";
				/// <summary>Constant value for <see cref="DistrictProperty.DefaultValue" /></summary>
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
			/// <inheritdoc cref="CountryNameProperty" path="/summary" /><br/>
			/// <remarks>Original Name: CountryName</remarks>
			/// </summary>
			public new CountryNameProperty CountryName { get; } = new CountryNameProperty();
			
			/// <summary>﻿element designating the country, dependency or area of geopolitical interest, in which a delivery point is located or via which the delivery point is accessed.<br /><br /><br />
			/// </summary>
			public new sealed class CountryNameProperty : IProperty
			{
				/// <summary>Constant value for <see cref="CountryNameProperty.Name" /></summary>
				public const string NAME = "CountryName";
				/// <summary>Constant value for <see cref="CountryNameProperty.Summary" /></summary>
				public const string SUMMARY = @"&#10;&#10;&#10;element designating the country, dependency or area of geopolitical interest, in which a delivery point is located or via which the delivery point is accessed.&#10;
";
				/// <summary>Constant value for <see cref="CountryNameProperty.AccessModifier" /></summary>
				public const string ACCESS_MODIFIER = "public";
				/// <summary>Constant value for <see cref="CountryNameProperty.Modifier" /></summary>
				public const string MODIFIER = "";
				/// <summary>Constant value for <see cref="CountryNameProperty.NormativeVersion" /></summary>
				public const string NORMATIVE_VERSION = "2.3";
				/// <summary>Constant value for <see cref="CountryNameProperty.DeprecatedVersion" /></summary>
				public const string DEPRECATED_VERSION = "";
				/// <summary>Constant value for <see cref="CountryNameProperty.Aggregation" /></summary>
				public const string AGGREGATION = "composite";
				/// <summary>Constant value for <see cref="CountryNameProperty.Extension" /></summary>
				public const string EXTENSION = "MagicDraw UML 2024x";
				/// <summary>Constant value for <see cref="CountryNameProperty.Association" /></summary>
				public const string ASSOCIATION = "";
				/// <summary>Constant value for <see cref="CountryNameProperty.DefaultValue" /></summary>
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
			/// <inheritdoc cref="CountryCodeProperty" path="/summary" /><br/>
			/// <remarks>Original Name: CountryCode</remarks>
			/// </summary>
			public new CountryCodeProperty CountryCode { get; } = new CountryCodeProperty();
			
			/// <summary>﻿interest, in which a delivery point is located or via which the delivery point is accessed.<br /><br /><br />
			/// </summary>
			public new sealed class CountryCodeProperty : IProperty
			{
				/// <summary>Constant value for <see cref="CountryCodeProperty.Name" /></summary>
				public const string NAME = "CountryCode";
				/// <summary>Constant value for <see cref="CountryCodeProperty.Summary" /></summary>
				public const string SUMMARY = @"&#10;&#10;&#10;interest, in which a delivery point is located or via which the delivery point is accessed.&#10;
";
				/// <summary>Constant value for <see cref="CountryCodeProperty.AccessModifier" /></summary>
				public const string ACCESS_MODIFIER = "public";
				/// <summary>Constant value for <see cref="CountryCodeProperty.Modifier" /></summary>
				public const string MODIFIER = "";
				/// <summary>Constant value for <see cref="CountryCodeProperty.NormativeVersion" /></summary>
				public const string NORMATIVE_VERSION = "2.3";
				/// <summary>Constant value for <see cref="CountryCodeProperty.DeprecatedVersion" /></summary>
				public const string DEPRECATED_VERSION = "";
				/// <summary>Constant value for <see cref="CountryCodeProperty.Aggregation" /></summary>
				public const string AGGREGATION = "composite";
				/// <summary>Constant value for <see cref="CountryCodeProperty.Extension" /></summary>
				public const string EXTENSION = "MagicDraw UML 2024x";
				/// <summary>Constant value for <see cref="CountryCodeProperty.Association" /></summary>
				public const string ASSOCIATION = "";
				/// <summary>Constant value for <see cref="CountryCodeProperty.DefaultValue" /></summary>
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
			/// <inheritdoc cref="PostCodeProperty" path="/summary" /><br/>
			/// <remarks>Original Name: PostCode</remarks>
			/// </summary>
			public new PostCodeProperty PostCode { get; } = new PostCodeProperty();
			
			/// <summary>﻿element designating the code used for the sorting of mail.<br /><br /><br />
			/// </summary>
			public new sealed class PostCodeProperty : IProperty
			{
				/// <summary>Constant value for <see cref="PostCodeProperty.Name" /></summary>
				public const string NAME = "PostCode";
				/// <summary>Constant value for <see cref="PostCodeProperty.Summary" /></summary>
				public const string SUMMARY = @"&#10;&#10;&#10;element designating the code used for the sorting of mail.&#10;
";
				/// <summary>Constant value for <see cref="PostCodeProperty.AccessModifier" /></summary>
				public const string ACCESS_MODIFIER = "public";
				/// <summary>Constant value for <see cref="PostCodeProperty.Modifier" /></summary>
				public const string MODIFIER = "";
				/// <summary>Constant value for <see cref="PostCodeProperty.NormativeVersion" /></summary>
				public const string NORMATIVE_VERSION = "2.3";
				/// <summary>Constant value for <see cref="PostCodeProperty.DeprecatedVersion" /></summary>
				public const string DEPRECATED_VERSION = "";
				/// <summary>Constant value for <see cref="PostCodeProperty.Aggregation" /></summary>
				public const string AGGREGATION = "composite";
				/// <summary>Constant value for <see cref="PostCodeProperty.Extension" /></summary>
				public const string EXTENSION = "MagicDraw UML 2024x";
				/// <summary>Constant value for <see cref="PostCodeProperty.Association" /></summary>
				public const string ASSOCIATION = "";
				/// <summary>Constant value for <see cref="PostCodeProperty.DefaultValue" /></summary>
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