#pragma warning disable CS0109 // Member does not hide an inherited member; new keyword is not required
#pragma warning disable CS1574 // XML comment has cref attribute that could not be resolved
#pragma warning disable CS1584 // XML comment has syntactically incorrect cref attribute
#pragma warning disable CS0618 // Type or member is obsolete
using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;
using System.Linq;

namespace Mtconnect.ObservationInformationModel.ObservationTypes.EventTypes
{
	/// <summary>﻿<see cref="EventEnum.DEVICE_ADDED">EventEnum.DEVICE_ADDED</see><br /><br /><br />
	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Structure___19_0_3_68e0225_1605103593648_589050_423">model.mtconnect.org</seealso> for more information.
	/// </summary>
	/// <remarks>
	/// <list type="bullet">
	/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.7">v1.7</see></item>
	/// </list>
	/// </remarks>

	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public sealed class DeviceAddedClass : IClass
	{
		/// <summary>Constant value for <see cref="DeviceAddedClass.ReferenceId" /></summary>
		public const string REFERENCE_ID = "_19_0_3_68e0225_1605103593648_589050_423";
		/// <summary>Constant value for <see cref="DeviceAddedClass.HelpUrl" /></summary>
		public const string HELP_URL = "https://model.mtconnect.org/#Structure___19_0_3_68e0225_1605103593648_589050_423";
		/// <summary>Constant value for <see cref="DeviceAddedClass.Summary" /></summary>
		public const string SUMMARY = @"&#10;&#10;&#10;{{def(EventEnum::DEVICE_ADDED)}}&#10;
";
		/// <summary>Constant value for <see cref="DeviceAddedClass.Name" /></summary>
		public const string NAME = "DeviceAdded";
		/// <summary>Constant value for <see cref="DeviceAddedClass.AccessModifier" /></summary>
		public const string ACCESS_MODIFIER = "public";
		/// <summary>Constant value for <see cref="DeviceAddedClass.Modifier" /></summary>
		public const string MODIFIER = "";
		/// <summary>Constant value for <see cref="DeviceAddedClass.NormativeVersion" /></summary>
		public const string NORMATIVE_VERSION = "1.7";
		/// <summary>Constant value for <see cref="DeviceAddedClass.DeprecatedVersion" /></summary>
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
		/// Original Type: _19_0_3_45f01b9_1579566531115_47447_25730
		/// </remarks>
		public Type Generalization => typeof(Mtconnect.ObservationInformationModel.EventClass);

		/// <inheritdoc />
		public new DeviceAddedClassProperties Properties { get; } = new DeviceAddedClassProperties();
        IPropertyList IClass.Properties => Properties;
		/// <summary>
		/// Property list for <see cref="DeviceAddedClass" />.
		/// <br/><b>Note</b>, some properties (<see cref="IProperty" />) are inherited from <see cref="Mtconnect.ObservationInformationModel.EventClass.EventClassProperties" />.
		/// </summary>
		public class DeviceAddedClassProperties : Mtconnect.ObservationInformationModel.EventClass.EventClassProperties
		{
			/// <inheritdoc />
			public override IProperty[] Properties => new IProperty[] {
				Type,
				Hash,
			}.Concat(base.Properties).ToArray();
			/// <summary>
			/// <inheritdoc cref="TypeProperty" path="/summary" /><br/>
			/// <remarks>Original Name: Type</remarks>
			/// </summary>
			public new TypeProperty Type { get; } = new TypeProperty();
			
			/// <summary>﻿
			/// </summary>
			public new sealed class TypeProperty : IProperty
			{
				/// <summary>Constant value for <see cref="TypeProperty.Name" /></summary>
				public const string NAME = "type";
				/// <summary>Constant value for <see cref="TypeProperty.Summary" /></summary>
				public const string SUMMARY = @"";
				/// <summary>Constant value for <see cref="TypeProperty.AccessModifier" /></summary>
				public const string ACCESS_MODIFIER = "public";
				/// <summary>Constant value for <see cref="TypeProperty.Modifier" /></summary>
				public const string MODIFIER = "static";
				/// <summary>Constant value for <see cref="TypeProperty.NormativeVersion" /></summary>
				public const string NORMATIVE_VERSION = "";
				/// <summary>Constant value for <see cref="TypeProperty.DeprecatedVersion" /></summary>
				public const string DEPRECATED_VERSION = "";
				/// <summary>Constant value for <see cref="TypeProperty.Aggregation" /></summary>
				public const string AGGREGATION = "composite";
				/// <summary>Constant value for <see cref="TypeProperty.Extension" /></summary>
				public const string EXTENSION = "";
				/// <summary>Constant value for <see cref="TypeProperty.Association" /></summary>
				public const string ASSOCIATION = "";
				/// <summary>Constant value for <see cref="TypeProperty.DefaultValue" /></summary>
				public const string DEFAULT_VALUE = "DEVICE_ADDED";

				/// <summary>
				/// <inheritdoc />
				/// <remarks> Type: EventEnumMetaClass </remarks>
				/// </summary>
				public System.Type Type => typeof(Mtconnect.DataTypes.EventEnumMetaClass);
				
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
			/// <inheritdoc cref="HashProperty" path="/summary" /><br/>
			/// <remarks>Original Name: Hash</remarks>
			/// </summary>
			public new HashProperty Hash { get; } = new HashProperty();
			
			/// <summary>﻿condensed message digest from a secure one-way hash function. <seealso href="https://www.google.com/search?q=FIPS PUB 180-4&amp;btnI=I">FIPS PUB 180-4</seealso><br /><br /><br />
			/// </summary>
			public new sealed class HashProperty : IProperty
			{
				/// <summary>Constant value for <see cref="HashProperty.Name" /></summary>
				public const string NAME = "hash";
				/// <summary>Constant value for <see cref="HashProperty.Summary" /></summary>
				public const string SUMMARY = @"&#10;&#10;&#10;condensed message digest from a secure one-way hash function. {{cite(FIPS PUB 180-4)}}&#10;
";
				/// <summary>Constant value for <see cref="HashProperty.AccessModifier" /></summary>
				public const string ACCESS_MODIFIER = "public";
				/// <summary>Constant value for <see cref="HashProperty.Modifier" /></summary>
				public const string MODIFIER = "";
				/// <summary>Constant value for <see cref="HashProperty.NormativeVersion" /></summary>
				public const string NORMATIVE_VERSION = "2.2";
				/// <summary>Constant value for <see cref="HashProperty.DeprecatedVersion" /></summary>
				public const string DEPRECATED_VERSION = "";
				/// <summary>Constant value for <see cref="HashProperty.Aggregation" /></summary>
				public const string AGGREGATION = "composite";
				/// <summary>Constant value for <see cref="HashProperty.Extension" /></summary>
				public const string EXTENSION = "MagicDraw UML 2024x";
				/// <summary>Constant value for <see cref="HashProperty.Association" /></summary>
				public const string ASSOCIATION = "";
				/// <summary>Constant value for <see cref="HashProperty.DefaultValue" /></summary>
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