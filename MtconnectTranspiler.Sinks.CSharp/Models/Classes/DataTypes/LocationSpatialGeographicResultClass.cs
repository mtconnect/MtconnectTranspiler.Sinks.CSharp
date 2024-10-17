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
	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Structure___19_0_3_68e0225_1712322166773_615724_510">model.mtconnect.org</seealso> for more information.
	/// </summary>
	/// <remarks>
	/// <list type="bullet">
	/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_2.4">v2.4</see></item>
	/// </list>
	/// </remarks>

	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public sealed class LocationSpatialGeographicResultClass : IClass
	{
		/// <summary>Constant value for <see cref="LocationSpatialGeographicResultClass.ReferenceId" /></summary>
		public const string REFERENCE_ID = "_19_0_3_68e0225_1712322166773_615724_510";
		/// <summary>Constant value for <see cref="LocationSpatialGeographicResultClass.HelpUrl" /></summary>
		public const string HELP_URL = "https://model.mtconnect.org/#Structure___19_0_3_68e0225_1712322166773_615724_510";
		/// <summary>Constant value for <see cref="LocationSpatialGeographicResultClass.Summary" /></summary>
		public const string SUMMARY = @"";
		/// <summary>Constant value for <see cref="LocationSpatialGeographicResultClass.Name" /></summary>
		public const string NAME = "LocationSpatialGeographicResult";
		/// <summary>Constant value for <see cref="LocationSpatialGeographicResultClass.AccessModifier" /></summary>
		public const string ACCESS_MODIFIER = "public";
		/// <summary>Constant value for <see cref="LocationSpatialGeographicResultClass.Modifier" /></summary>
		public const string MODIFIER = "";
		/// <summary>Constant value for <see cref="LocationSpatialGeographicResultClass.NormativeVersion" /></summary>
		public const string NORMATIVE_VERSION = "2.4";
		/// <summary>Constant value for <see cref="LocationSpatialGeographicResultClass.DeprecatedVersion" /></summary>
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
		public new LocationSpatialGeographicResultClassProperties Properties { get; } = new LocationSpatialGeographicResultClassProperties();
        IPropertyList IClass.Properties => Properties;
		/// <summary>
		/// Property list for <see cref="LocationSpatialGeographicResultClass" />.
		/// <br/><b>Note</b>, some properties (<see cref="IProperty" />) are inherited from <see cref="Mtconnect.ObservationInformationModel.Representations.DataSetClass.DataSetClassProperties" />.
		/// </summary>
		public class LocationSpatialGeographicResultClassProperties : Mtconnect.ObservationInformationModel.Representations.DataSetClass.DataSetClassProperties
		{
			/// <inheritdoc />
			public override IProperty[] Properties => new IProperty[] {
				Longitude,
				Latitude,
				Altitude,
			}.Concat(base.Properties).ToArray();
			/// <summary>
			/// <inheritdoc cref="LongitudeProperty" path="/summary" /><br/>
			/// <remarks>Original Name: Longitude</remarks>
			/// </summary>
			public new LongitudeProperty Longitude { get; } = new LongitudeProperty();
			
			/// <summary>﻿geographic longitude.<br /><br /><br />
			/// </summary>
			public new sealed class LongitudeProperty : IProperty
			{
				/// <summary>Constant value for <see cref="LongitudeProperty.Name" /></summary>
				public const string NAME = "Longitude";
				/// <summary>Constant value for <see cref="LongitudeProperty.Summary" /></summary>
				public const string SUMMARY = @"&#10;&#10;&#10;geographic longitude.&#10;
";
				/// <summary>Constant value for <see cref="LongitudeProperty.AccessModifier" /></summary>
				public const string ACCESS_MODIFIER = "public";
				/// <summary>Constant value for <see cref="LongitudeProperty.Modifier" /></summary>
				public const string MODIFIER = "";
				/// <summary>Constant value for <see cref="LongitudeProperty.NormativeVersion" /></summary>
				public const string NORMATIVE_VERSION = "2.4";
				/// <summary>Constant value for <see cref="LongitudeProperty.DeprecatedVersion" /></summary>
				public const string DEPRECATED_VERSION = "";
				/// <summary>Constant value for <see cref="LongitudeProperty.Aggregation" /></summary>
				public const string AGGREGATION = "composite";
				/// <summary>Constant value for <see cref="LongitudeProperty.Extension" /></summary>
				public const string EXTENSION = "MagicDraw UML 2024x";
				/// <summary>Constant value for <see cref="LongitudeProperty.Association" /></summary>
				public const string ASSOCIATION = "";
				/// <summary>Constant value for <see cref="LongitudeProperty.DefaultValue" /></summary>
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
			/// <inheritdoc cref="LatitudeProperty" path="/summary" /><br/>
			/// <remarks>Original Name: Latitude</remarks>
			/// </summary>
			public new LatitudeProperty Latitude { get; } = new LatitudeProperty();
			
			/// <summary>﻿geographic latitude.<br /><br /><br />
			/// </summary>
			public new sealed class LatitudeProperty : IProperty
			{
				/// <summary>Constant value for <see cref="LatitudeProperty.Name" /></summary>
				public const string NAME = "Latitude";
				/// <summary>Constant value for <see cref="LatitudeProperty.Summary" /></summary>
				public const string SUMMARY = @"&#10;&#10;&#10;geographic latitude.&#10;
";
				/// <summary>Constant value for <see cref="LatitudeProperty.AccessModifier" /></summary>
				public const string ACCESS_MODIFIER = "public";
				/// <summary>Constant value for <see cref="LatitudeProperty.Modifier" /></summary>
				public const string MODIFIER = "";
				/// <summary>Constant value for <see cref="LatitudeProperty.NormativeVersion" /></summary>
				public const string NORMATIVE_VERSION = "2.4";
				/// <summary>Constant value for <see cref="LatitudeProperty.DeprecatedVersion" /></summary>
				public const string DEPRECATED_VERSION = "";
				/// <summary>Constant value for <see cref="LatitudeProperty.Aggregation" /></summary>
				public const string AGGREGATION = "composite";
				/// <summary>Constant value for <see cref="LatitudeProperty.Extension" /></summary>
				public const string EXTENSION = "MagicDraw UML 2024x";
				/// <summary>Constant value for <see cref="LatitudeProperty.Association" /></summary>
				public const string ASSOCIATION = "";
				/// <summary>Constant value for <see cref="LatitudeProperty.DefaultValue" /></summary>
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
			/// <inheritdoc cref="AltitudeProperty" path="/summary" /><br/>
			/// <remarks>Original Name: Altitude</remarks>
			/// </summary>
			public new AltitudeProperty Altitude { get; } = new AltitudeProperty();
			
			/// <summary>﻿height relative to a reference.<br /><br /><br />
			/// </summary>
			public new sealed class AltitudeProperty : IProperty
			{
				/// <summary>Constant value for <see cref="AltitudeProperty.Name" /></summary>
				public const string NAME = "Altitude";
				/// <summary>Constant value for <see cref="AltitudeProperty.Summary" /></summary>
				public const string SUMMARY = @"&#10;&#10;&#10;height relative to a reference.&#10;
";
				/// <summary>Constant value for <see cref="AltitudeProperty.AccessModifier" /></summary>
				public const string ACCESS_MODIFIER = "public";
				/// <summary>Constant value for <see cref="AltitudeProperty.Modifier" /></summary>
				public const string MODIFIER = "";
				/// <summary>Constant value for <see cref="AltitudeProperty.NormativeVersion" /></summary>
				public const string NORMATIVE_VERSION = "2.4";
				/// <summary>Constant value for <see cref="AltitudeProperty.DeprecatedVersion" /></summary>
				public const string DEPRECATED_VERSION = "";
				/// <summary>Constant value for <see cref="AltitudeProperty.Aggregation" /></summary>
				public const string AGGREGATION = "composite";
				/// <summary>Constant value for <see cref="AltitudeProperty.Extension" /></summary>
				public const string EXTENSION = "MagicDraw UML 2024x";
				/// <summary>Constant value for <see cref="AltitudeProperty.Association" /></summary>
				public const string ASSOCIATION = "";
				/// <summary>Constant value for <see cref="AltitudeProperty.DefaultValue" /></summary>
				public const string DEFAULT_VALUE = "";

				/// <summary>
				/// <inheritdoc />
				/// <remarks> Type: Object </remarks>
				/// </summary>
				public System.Type Type => typeof(object);
				
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