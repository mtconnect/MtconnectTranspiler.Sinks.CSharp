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
	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Structure___19_0_3_68e0225_1696869014788_515272_2985">model.mtconnect.org</seealso> for more information.
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public sealed class LocationAddressResultClass : IClass
	{
		/// <inheritdoc />
		public string ReferenceId => "_19_0_3_68e0225_1696869014788_515272_2985";
		
		/// <inheritdoc />
		public string Summary => @"";

		/// <inheritdoc />
		public string Name => "LocationAddressResult";
		
		/// <inheritdoc />
		public string AccessModifier => "public";
				
		/// <inheritdoc />
		public string Modifier => "";
				
		/// <inheritdoc />
		public string NormativeVersion => "2.3";
				
		/// <inheritdoc />
		public string DeprecatedVersion => "";
		
		/// <inheritdoc />
		/// <remarks>
		/// Original Type: _19_0_3_45f01b9_1579566531114_503405_25727
		/// </remarks>
		public Type Generalization => typeof(Mtconnect.ObservationInformationModel.Representations.DataSetClass);

		/// <inheritdoc />
		public LocationAddressResultClassProperties Properties { get; } = new LocationAddressResultClassProperties();
        IPropertyList IClass.Properties => Properties;
		/// <summary>
		/// Property list for <see cref="LocationAddressResultClass" />.
		/// <br/><b>Note</b>, some properties (<see cref="IProperty" />) are inherited from <see cref="Mtconnect.ObservationInformationModel.Representations.DataSetClass.DataSetClassProperties" />.
		/// </summary>
		public class LocationAddressResultClassProperties : Mtconnect.ObservationInformationModel.Representations.DataSetClass.DataSetClassProperties
		{
			/// <inheritdoc />
			public new IProperty[] Properties => new IProperty[] {
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
				public string Name => "GivenName";
				
				/// <inheritdoc />
				public string Summary => @"&#10;&#10;&#10;element specifying the name used to distinguish between persons having the same surname(s) and who may have access to a particular delivery point.&#10;
";

				/// <inheritdoc />
				public string AccessModifier => "public";
				
				/// <inheritdoc />
				public string Modifier => "";
				
				/// <inheritdoc />
				public string NormativeVersion => "2.3";
				
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
			/// <inheritdoc cref="SurnameProperty" path="/summary" /><br/>
			/// <remarks>Original Name: Surname</remarks>
			/// </summary>
			public new SurnameProperty Surname { get; } = new SurnameProperty();
			
			/// <summary>﻿element which identifies the family or parentage of an individual.<br /><br /><br />
			/// </summary>
			public new sealed class SurnameProperty : IProperty
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
				public string Name => "Surname";
				
				/// <inheritdoc />
				public string Summary => @"&#10;&#10;&#10;element which identifies the family or parentage of an individual.&#10;
";

				/// <inheritdoc />
				public string AccessModifier => "public";
				
				/// <inheritdoc />
				public string Modifier => "";
				
				/// <inheritdoc />
				public string NormativeVersion => "2.3";
				
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
			/// <inheritdoc cref="QualificationProperty" path="/summary" /><br/>
			/// <remarks>Original Name: Qualification</remarks>
			/// </summary>
			public new QualificationProperty Qualification { get; } = new QualificationProperty();
			
			/// <summary>﻿element indicating an individual’s professional or academic qualification or rank in a professional group or society (e.g. PhD, Fellow of the Royal Society, FRS, Barrister at Law).<br /><br /><br />
			/// </summary>
			public new sealed class QualificationProperty : IProperty
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
				public string Name => "Qualification";
				
				/// <inheritdoc />
				public string Summary => @"&#10;&#10;&#10;element indicating an individual’s professional or academic qualification or rank in a professional group or society (e.g. PhD, Fellow of the Royal Society, FRS, Barrister at Law).&#10;
";

				/// <inheritdoc />
				public string AccessModifier => "public";
				
				/// <inheritdoc />
				public string Modifier => "";
				
				/// <inheritdoc />
				public string NormativeVersion => "2.3";
				
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
			/// <inheritdoc cref="NameQualifierProperty" path="/summary" /><br/>
			/// <remarks>Original Name: NameQualifier</remarks>
			/// </summary>
			public new NameQualifierProperty NameQualifier { get; } = new NameQualifierProperty();
			
			/// <summary>﻿element used in some countries to distinguish between persons with the same surname(s) who have similar given names or initials (e.g.III, Senior, the Third.).<br /><br /><br />
			/// </summary>
			public new sealed class NameQualifierProperty : IProperty
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
				public string Name => "NameQualifier";
				
				/// <inheritdoc />
				public string Summary => @"&#10;&#10;&#10;element used in some countries to distinguish between persons with the same surname(s) who have similar given names or initials (e.g.III, Senior, the Third.).&#10;
";

				/// <inheritdoc />
				public string AccessModifier => "public";
				
				/// <inheritdoc />
				public string Modifier => "";
				
				/// <inheritdoc />
				public string NormativeVersion => "2.3";
				
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
			/// <inheritdoc cref="OrganizationNameProperty" path="/summary" /><br/>
			/// <remarks>Original Name: OrganizationName</remarks>
			/// </summary>
			public new OrganizationNameProperty OrganizationName { get; } = new OrganizationNameProperty();
			
			/// <summary>﻿element giving the official name, the registered business name or other official designation of an organization.<br /><br /><br />
			/// </summary>
			public new sealed class OrganizationNameProperty : IProperty
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
				public string Name => "OrganizationName";
				
				/// <inheritdoc />
				public string Summary => @"&#10;&#10;&#10;element giving the official name, the registered business name or other official designation of an organization.&#10;
";

				/// <inheritdoc />
				public string AccessModifier => "public";
				
				/// <inheritdoc />
				public string Modifier => "";
				
				/// <inheritdoc />
				public string NormativeVersion => "2.3";
				
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
			/// <inheritdoc cref="LegalStatusProperty" path="/summary" /><br/>
			/// <remarks>Original Name: LegalStatus</remarks>
			/// </summary>
			public new LegalStatusProperty LegalStatus { get; } = new LegalStatusProperty();
			
			/// <summary>﻿element indicating the formal registration of an organization (e.g. GmbH, Inc., Ltd.).<br /><br /><br />
			/// </summary>
			public new sealed class LegalStatusProperty : IProperty
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
				public string Name => "LegalStatus";
				
				/// <inheritdoc />
				public string Summary => @"&#10;&#10;&#10;element indicating the formal registration of an organization (e.g. GmbH, Inc., Ltd.).&#10;
";

				/// <inheritdoc />
				public string AccessModifier => "public";
				
				/// <inheritdoc />
				public string Modifier => "";
				
				/// <inheritdoc />
				public string NormativeVersion => "2.3";
				
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
			/// <inheritdoc cref="OrganizationUnitProperty" path="/summary" /><br/>
			/// <remarks>Original Name: OrganizationUnit</remarks>
			/// </summary>
			public new OrganizationUnitProperty OrganizationUnit { get; } = new OrganizationUnitProperty();
			
			/// <summary>﻿element identifying a subdivision of an organization.<br /><br /><br />
			/// </summary>
			public new sealed class OrganizationUnitProperty : IProperty
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
				public string Name => "OrganizationUnit";
				
				/// <inheritdoc />
				public string Summary => @"&#10;&#10;&#10;element identifying a subdivision of an organization.&#10;
";

				/// <inheritdoc />
				public string AccessModifier => "public";
				
				/// <inheritdoc />
				public string Modifier => "";
				
				/// <inheritdoc />
				public string NormativeVersion => "2.3";
				
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
			/// <inheritdoc cref="BuildingProperty" path="/summary" /><br/>
			/// <remarks>Original Name: Building</remarks>
			/// </summary>
			public new BuildingProperty Building { get; } = new BuildingProperty();
			
			/// <summary>﻿element identifying the number or name and type of the edifice or construction in or adjacent to which a delivery point is located.<br /><br /><br />
			/// </summary>
			public new sealed class BuildingProperty : IProperty
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
				public string Name => "Building";
				
				/// <inheritdoc />
				public string Summary => @"&#10;&#10;&#10;element identifying the number or name and type of the edifice or construction in or adjacent to which a delivery point is located.&#10;
";

				/// <inheritdoc />
				public string AccessModifier => "public";
				
				/// <inheritdoc />
				public string Modifier => "";
				
				/// <inheritdoc />
				public string NormativeVersion => "2.3";
				
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
			/// <inheritdoc cref="FloorProperty" path="/summary" /><br/>
			/// <remarks>Original Name: Floor</remarks>
			/// </summary>
			public new FloorProperty Floor { get; } = new FloorProperty();
			
			/// <summary>﻿element indicating the floor or level on which a delivery point is located in a multi-story building.<br /><br /><br />
			/// </summary>
			public new sealed class FloorProperty : IProperty
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
				public string Name => "Floor";
				
				/// <inheritdoc />
				public string Summary => @"&#10;&#10;&#10;element indicating the floor or level on which a delivery point is located in a multi-story building.&#10;
";

				/// <inheritdoc />
				public string AccessModifier => "public";
				
				/// <inheritdoc />
				public string Modifier => "";
				
				/// <inheritdoc />
				public string NormativeVersion => "2.3";
				
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
			/// <inheritdoc cref="DoorProperty" path="/summary" /><br/>
			/// <remarks>Original Name: Door</remarks>
			/// </summary>
			public new DoorProperty Door { get; } = new DoorProperty();
			
			/// <summary>﻿element indicating the apartment, room or office in, at or adjacent to which a delivery point, situated within a building, is located.<br /><br /><br />
			/// </summary>
			public new sealed class DoorProperty : IProperty
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
				public string Name => "Door";
				
				/// <inheritdoc />
				public string Summary => @"&#10;&#10;&#10;element indicating the apartment, room or office in, at or adjacent to which a delivery point, situated within a building, is located.&#10;
";

				/// <inheritdoc />
				public string AccessModifier => "public";
				
				/// <inheritdoc />
				public string Modifier => "";
				
				/// <inheritdoc />
				public string NormativeVersion => "2.3";
				
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
			/// <inheritdoc cref="ThoroughfareProperty" path="/summary" /><br/>
			/// <remarks>Original Name: Thoroughfare</remarks>
			/// </summary>
			public new ThoroughfareProperty Thoroughfare { get; } = new ThoroughfareProperty();
			
			/// <summary>﻿element which identifies the road or part of a road or other access route along which a delivery point can be accessed, either directly or via a secondary or tertiary road or access route.<br /><br /><br />
			/// </summary>
			public new sealed class ThoroughfareProperty : IProperty
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
				public string Name => "Thoroughfare";
				
				/// <inheritdoc />
				public string Summary => @"&#10;&#10;&#10;element which identifies the road or part of a road or other access route along which a delivery point can be accessed, either directly or via a secondary or tertiary road or access route.&#10;
";

				/// <inheritdoc />
				public string AccessModifier => "public";
				
				/// <inheritdoc />
				public string Modifier => "";
				
				/// <inheritdoc />
				public string NormativeVersion => "2.3";
				
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
			/// <inheritdoc cref="PremiseIdentifierProperty" path="/summary" /><br/>
			/// <remarks>Original Name: PremiseIdentifier</remarks>
			/// </summary>
			public new PremiseIdentifierProperty PremiseIdentifier { get; } = new PremiseIdentifierProperty();
			
			/// <summary>﻿element designating the area or the object on an area, adjacent to thoroughfare, in which the delivery point or delivery point access is located.<br /><br /><br />
			/// </summary>
			public new sealed class PremiseIdentifierProperty : IProperty
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
				public string Name => "PremiseIdentifier";
				
				/// <inheritdoc />
				public string Summary => @"&#10;&#10;&#10;element designating the area or the object on an area, adjacent to thoroughfare, in which the delivery point or delivery point access is located.&#10;
";

				/// <inheritdoc />
				public string AccessModifier => "public";
				
				/// <inheritdoc />
				public string Modifier => "";
				
				/// <inheritdoc />
				public string NormativeVersion => "2.3";
				
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
			/// <inheritdoc cref="TownProperty" path="/summary" /><br/>
			/// <remarks>Original Name: Town</remarks>
			/// </summary>
			public new TownProperty Town { get; } = new TownProperty();
			
			/// <summary>﻿element indicating the name of the populated place in which a delivery point is located, or the populated.<br /><br /><br />
			/// </summary>
			public new sealed class TownProperty : IProperty
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
				public string Name => "Town";
				
				/// <inheritdoc />
				public string Summary => @"&#10;&#10;&#10;element indicating the name of the populated place in which a delivery point is located, or the populated.&#10;
";

				/// <inheritdoc />
				public string AccessModifier => "public";
				
				/// <inheritdoc />
				public string Modifier => "";
				
				/// <inheritdoc />
				public string NormativeVersion => "2.3";
				
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
			/// <inheritdoc cref="RegionProperty" path="/summary" /><br/>
			/// <remarks>Original Name: Region</remarks>
			/// </summary>
			public new RegionProperty Region { get; } = new RegionProperty();
			
			/// <summary>﻿element specifying the geographic or administrative area of the country in which the town is situated.<br /><br /><br />
			/// </summary>
			public new sealed class RegionProperty : IProperty
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
				public string Name => "Region";
				
				/// <inheritdoc />
				public string Summary => @"&#10;&#10;&#10;element specifying the geographic or administrative area of the country in which the town is situated.&#10;
";

				/// <inheritdoc />
				public string AccessModifier => "public";
				
				/// <inheritdoc />
				public string Modifier => "";
				
				/// <inheritdoc />
				public string NormativeVersion => "2.3";
				
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
			/// <inheritdoc cref="DistrictProperty" path="/summary" /><br/>
			/// <remarks>Original Name: District</remarks>
			/// </summary>
			public new DistrictProperty District { get; } = new DistrictProperty();
			
			/// <summary>﻿element indicating the name of the area within or adjacent to the town in which a delivery point is located, or via which it is accessed.<br /><br /><br />
			/// </summary>
			public new sealed class DistrictProperty : IProperty
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
				public string Name => "District";
				
				/// <inheritdoc />
				public string Summary => @"&#10;&#10;&#10;element indicating the name of the area within or adjacent to the town in which a delivery point is located, or via which it is accessed.&#10;
";

				/// <inheritdoc />
				public string AccessModifier => "public";
				
				/// <inheritdoc />
				public string Modifier => "";
				
				/// <inheritdoc />
				public string NormativeVersion => "2.3";
				
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
			/// <inheritdoc cref="CountryNameProperty" path="/summary" /><br/>
			/// <remarks>Original Name: CountryName</remarks>
			/// </summary>
			public new CountryNameProperty CountryName { get; } = new CountryNameProperty();
			
			/// <summary>﻿element designating the country, dependency or area of geopolitical interest, in which a delivery point is located or via which the delivery point is accessed.<br /><br /><br />
			/// </summary>
			public new sealed class CountryNameProperty : IProperty
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
				public string Name => "CountryName";
				
				/// <inheritdoc />
				public string Summary => @"&#10;&#10;&#10;element designating the country, dependency or area of geopolitical interest, in which a delivery point is located or via which the delivery point is accessed.&#10;
";

				/// <inheritdoc />
				public string AccessModifier => "public";
				
				/// <inheritdoc />
				public string Modifier => "";
				
				/// <inheritdoc />
				public string NormativeVersion => "2.3";
				
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
			/// <inheritdoc cref="CountryCodeProperty" path="/summary" /><br/>
			/// <remarks>Original Name: CountryCode</remarks>
			/// </summary>
			public new CountryCodeProperty CountryCode { get; } = new CountryCodeProperty();
			
			/// <summary>﻿interest, in which a delivery point is located or via which the delivery point is accessed.<br /><br /><br />
			/// </summary>
			public new sealed class CountryCodeProperty : IProperty
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
				public string Name => "CountryCode";
				
				/// <inheritdoc />
				public string Summary => @"&#10;&#10;&#10;interest, in which a delivery point is located or via which the delivery point is accessed.&#10;
";

				/// <inheritdoc />
				public string AccessModifier => "public";
				
				/// <inheritdoc />
				public string Modifier => "";
				
				/// <inheritdoc />
				public string NormativeVersion => "2.3";
				
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
			/// <inheritdoc cref="PostCodeProperty" path="/summary" /><br/>
			/// <remarks>Original Name: PostCode</remarks>
			/// </summary>
			public new PostCodeProperty PostCode { get; } = new PostCodeProperty();
			
			/// <summary>﻿element designating the code used for the sorting of mail.<br /><br /><br />
			/// </summary>
			public new sealed class PostCodeProperty : IProperty
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
				public string Name => "PostCode";
				
				/// <inheritdoc />
				public string Summary => @"&#10;&#10;&#10;element designating the code used for the sorting of mail.&#10;
";

				/// <inheritdoc />
				public string AccessModifier => "public";
				
				/// <inheritdoc />
				public string Modifier => "";
				
				/// <inheritdoc />
				public string NormativeVersion => "2.3";
				
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