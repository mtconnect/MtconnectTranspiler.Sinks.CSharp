
using System;
using System.CodeDom.Compiler;

using Mtconnect.Glossary.MTConnectTerms;
using Mtconnect.DeviceInformationModel.Configurations.SolidModel;
using Mtconnect.Glossary.IndustrialTerms;
using Mtconnect.DeviceInformationModel.Configurations.Motion;
using Mtconnect.DeviceInformationModel.Configurations.Relationships;
using Mtconnect.DeviceInformationModel.Configurations.CoordinateSystems;
using Mtconnect.DeviceInformationModel.Configurations.Specifications;
using Mtconnect.DeviceInformationModel.Configurations.ImageFiles;
using Mtconnect.ObservationInformationModel.ObservationTypes.EventTypes;

namespace Mtconnect.DeviceInformationModel.Configurations
{
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "1.0.15.3")]
	public sealed class ConfigurationClass
	{
		/// <inheritdoc cref="Class.ReferenceId" />
		public string ReferenceId => "EAID_C04DCC77_16E8_4cef_92D4_B777AFC52570";
		
		/// <inheritdoc cref="Class.Name" />
		public string Name => "Configuration";
		
		/// <inheritdoc cref="Class.AccessModifier" />
		public string AccessModifier => "public";
				
		/// <inheritdoc cref="Class.Modifier" />
		public string Modifier => "";
				
		/// <inheritdoc cref="Class.NormativeVersion" />
		public string NormativeVersion => "MtconnectVersions.V_1_2_0";
				
		/// <inheritdoc cref="Class.DeprecatedVersion" />
		public string DeprecatedVersion => "";

		public string Generalization => "";

		public ConfigurationProperties Properties { get; } = new ConfigurationProperties();
		public sealed class ConfigurationProperties
		{
		
		
			/// <remarks>Original Name: IsConfigurationFor</remarks>
			public IsConfigurationForPartProperty IsConfigurationForPart { get; } = new IsConfigurationForPartProperty();
			public sealed class IsConfigurationForPartProperty
			{
				/// <inheritdoc cref="Property.Type" />
				/// Original Type: EAID_8548C620_467A_4f50_9A22_58D84B7E8779
				public Type Type => typeof(ComponentClass);
				
				/// <inheritdoc cref="Property.Name" />
				public string Name => "IsConfigurationFor";
				
				/// <inheritdoc cref="Property.AccessModifier" />
				public string AccessModifier => "private";
				
				/// <inheritdoc cref="Property.Modifier" />
				public string Modifier => "";
				
				/// <inheritdoc cref="Property.NormativeVersion" />
				public string NormativeVersion => "";
				
				/// <inheritdoc cref="Property.DeprecatedVersion" />
				public string DeprecatedVersion => "";
				
				public string Aggregation => "";

				// Note: Extension.Extender
				public string Extension => "";

				public string Association => "Configuration";

				// Note: DefaultValue.Name
				public string DefaultValue => "";

				// TODO: Add Summary
			}
		
		
			/// <remarks>Original Name: HasSolidModel</remarks>
			public HasSolidModelPartProperty HasSolidModelPart { get; } = new HasSolidModelPartProperty();
			public sealed class HasSolidModelPartProperty
			{
				/// <inheritdoc cref="Property.Type" />
				/// Original Type: _19_0_3_45f01b9_1587596157073_106480_480
				public Type Type => typeof(SolidModelClass);
				
				/// <inheritdoc cref="Property.Name" />
				public string Name => "HasSolidModel";
				
				/// <inheritdoc cref="Property.AccessModifier" />
				public string AccessModifier => "public";
				
				/// <inheritdoc cref="Property.Modifier" />
				public string Modifier => "";
				
				/// <inheritdoc cref="Property.NormativeVersion" />
				public string NormativeVersion => "";
				
				/// <inheritdoc cref="Property.DeprecatedVersion" />
				public string DeprecatedVersion => "";
				
				public string Aggregation => "composite";

				// Note: Extension.Extender
				public string Extension => "MagicDraw UML 19.0";

				public string Association => "SolidModel";

				// Note: DefaultValue.Name
				public string DefaultValue => "";

				// TODO: Add Summary
			}
		
		
			/// <remarks>Original Name: HasSensorConfiguration</remarks>
			public HasSensorConfigurationPartProperty HasSensorConfigurationPart { get; } = new HasSensorConfigurationPartProperty();
			public sealed class HasSensorConfigurationPartProperty
			{
				/// <inheritdoc cref="Property.Type" />
				/// Original Type: EAID_1DD02014_D949_43cc_A79F_FF2C0AF0DFBE
				public Type Type => typeof(SensorConfigurationClass);
				
				/// <inheritdoc cref="Property.Name" />
				public string Name => "HasSensorConfiguration";
				
				/// <inheritdoc cref="Property.AccessModifier" />
				public string AccessModifier => "public";
				
				/// <inheritdoc cref="Property.Modifier" />
				public string Modifier => "";
				
				/// <inheritdoc cref="Property.NormativeVersion" />
				public string NormativeVersion => "";
				
				/// <inheritdoc cref="Property.DeprecatedVersion" />
				public string DeprecatedVersion => "";
				
				public string Aggregation => "composite";

				// Note: Extension.Extender
				public string Extension => "MagicDraw UML 19.0";

				public string Association => "SensorConfiguration";

				// Note: DefaultValue.Name
				public string DefaultValue => "";

				// TODO: Add Summary
			}
		
		
			/// <remarks>Original Name: HasMotion</remarks>
			public HasMotionPartProperty HasMotionPart { get; } = new HasMotionPartProperty();
			public sealed class HasMotionPartProperty
			{
				/// <inheritdoc cref="Property.Type" />
				/// Original Type: EAID_1F084FBF_2AC7_41f6_8485_C356E6D7A9C1
				public Type Type => typeof(MotionClass);
				
				/// <inheritdoc cref="Property.Name" />
				public string Name => "HasMotion";
				
				/// <inheritdoc cref="Property.AccessModifier" />
				public string AccessModifier => "public";
				
				/// <inheritdoc cref="Property.Modifier" />
				public string Modifier => "";
				
				/// <inheritdoc cref="Property.NormativeVersion" />
				public string NormativeVersion => "";
				
				/// <inheritdoc cref="Property.DeprecatedVersion" />
				public string DeprecatedVersion => "";
				
				public string Aggregation => "composite";

				// Note: Extension.Extender
				public string Extension => "MagicDraw UML 19.0";

				public string Association => "Motion";

				// Note: DefaultValue.Name
				public string DefaultValue => "";

				// TODO: Add Summary
			}
		
		
			/// <remarks>Original Name: HasRelationship</remarks>
			public HasRelationshipPartProperty HasRelationshipPart { get; } = new HasRelationshipPartProperty();
			public sealed class HasRelationshipPartProperty
			{
				/// <inheritdoc cref="Property.Type" />
				/// Original Type: EAID_28132294_DF39_4e8e_8AE5_B79565F991A2
				public Type Type => typeof(ConfigurationRelationshipClass);
				
				/// <inheritdoc cref="Property.Name" />
				public string Name => "HasRelationship";
				
				/// <inheritdoc cref="Property.AccessModifier" />
				public string AccessModifier => "public";
				
				/// <inheritdoc cref="Property.Modifier" />
				public string Modifier => "";
				
				/// <inheritdoc cref="Property.NormativeVersion" />
				public string NormativeVersion => "";
				
				/// <inheritdoc cref="Property.DeprecatedVersion" />
				public string DeprecatedVersion => "";
				
				public string Aggregation => "composite";

				// Note: Extension.Extender
				public string Extension => "";

				public string Association => "Relationships";

				// Note: DefaultValue.Name
				public string DefaultValue => "";

				// TODO: Add Summary
			}
		
		
			/// <remarks>Original Name: HasCoordinateSystem</remarks>
			public HasCoordinateSystemPartProperty HasCoordinateSystemPart { get; } = new HasCoordinateSystemPartProperty();
			public sealed class HasCoordinateSystemPartProperty
			{
				/// <inheritdoc cref="Property.Type" />
				/// Original Type: _19_0_3_45f01b9_1579100679936_1279_16310
				public Type Type => typeof(CoordinateSystemClass);
				
				/// <inheritdoc cref="Property.Name" />
				public string Name => "HasCoordinateSystem";
				
				/// <inheritdoc cref="Property.AccessModifier" />
				public string AccessModifier => "public";
				
				/// <inheritdoc cref="Property.Modifier" />
				public string Modifier => "";
				
				/// <inheritdoc cref="Property.NormativeVersion" />
				public string NormativeVersion => "";
				
				/// <inheritdoc cref="Property.DeprecatedVersion" />
				public string DeprecatedVersion => "";
				
				public string Aggregation => "composite";

				// Note: Extension.Extender
				public string Extension => "";

				public string Association => "CoordinateSystems";

				// Note: DefaultValue.Name
				public string DefaultValue => "";

				// TODO: Add Summary
			}
		
		
			/// <remarks>Original Name: HasSpecification</remarks>
			public HasSpecificationPartProperty HasSpecificationPart { get; } = new HasSpecificationPartProperty();
			public sealed class HasSpecificationPartProperty
			{
				/// <inheritdoc cref="Property.Type" />
				/// Original Type: _19_0_3_45f01b9_1580315898400_607214_47155
				public Type Type => typeof(SpecificationClass);
				
				/// <inheritdoc cref="Property.Name" />
				public string Name => "HasSpecification";
				
				/// <inheritdoc cref="Property.AccessModifier" />
				public string AccessModifier => "public";
				
				/// <inheritdoc cref="Property.Modifier" />
				public string Modifier => "";
				
				/// <inheritdoc cref="Property.NormativeVersion" />
				public string NormativeVersion => "";
				
				/// <inheritdoc cref="Property.DeprecatedVersion" />
				public string DeprecatedVersion => "";
				
				public string Aggregation => "composite";

				// Note: Extension.Extender
				public string Extension => "";

				public string Association => "Specifications";

				// Note: DefaultValue.Name
				public string DefaultValue => "";

				// TODO: Add Summary
			}
		
		
			/// <remarks>Original Name: IsConfigurationFor</remarks>
			public IsConfigurationForPartProperty IsConfigurationForPart { get; } = new IsConfigurationForPartProperty();
			public sealed class IsConfigurationForPartProperty
			{
				/// <inheritdoc cref="Property.Type" />
				/// Original Type: _19_0_3_68e0225_1658936424016_561586_139
				public Type Type => typeof(CompositionClass);
				
				/// <inheritdoc cref="Property.Name" />
				public string Name => "IsConfigurationFor";
				
				/// <inheritdoc cref="Property.AccessModifier" />
				public string AccessModifier => "private";
				
				/// <inheritdoc cref="Property.Modifier" />
				public string Modifier => "";
				
				/// <inheritdoc cref="Property.NormativeVersion" />
				public string NormativeVersion => "";
				
				/// <inheritdoc cref="Property.DeprecatedVersion" />
				public string DeprecatedVersion => "";
				
				public string Aggregation => "";

				// Note: Extension.Extender
				public string Extension => "";

				public string Association => "Configuration";

				// Note: DefaultValue.Name
				public string DefaultValue => "";

				// TODO: Add Summary
			}
		
		
			/// <remarks>Original Name: HasImageFile</remarks>
			public HasImageFilePartProperty HasImageFilePart { get; } = new HasImageFilePartProperty();
			public sealed class HasImageFilePartProperty
			{
				/// <inheritdoc cref="Property.Type" />
				/// Original Type: _19_0_3_68e0225_1677585025728_765757_660
				public Type Type => typeof(ImageFileClass);
				
				/// <inheritdoc cref="Property.Name" />
				public string Name => "HasImageFile";
				
				/// <inheritdoc cref="Property.AccessModifier" />
				public string AccessModifier => "public";
				
				/// <inheritdoc cref="Property.Modifier" />
				public string Modifier => "";
				
				/// <inheritdoc cref="Property.NormativeVersion" />
				public string NormativeVersion => "";
				
				/// <inheritdoc cref="Property.DeprecatedVersion" />
				public string DeprecatedVersion => "";
				
				public string Aggregation => "composite";

				// Note: Extension.Extender
				public string Extension => "";

				public string Association => "ImageFiles";

				// Note: DefaultValue.Name
				public string DefaultValue => "";

				// TODO: Add Summary
			}
		
		
			/// <remarks>Original Name: HasPowerSource</remarks>
			public HasPowerSourcePartProperty HasPowerSourcePart { get; } = new HasPowerSourcePartProperty();
			public sealed class HasPowerSourcePartProperty
			{
				/// <inheritdoc cref="Property.Type" />
				/// Original Type: _19_0_3_68e0225_1696870815347_556704_3251
				public Type Type => typeof(PowerSourceClass);
				
				/// <inheritdoc cref="Property.Name" />
				public string Name => "HasPowerSource";
				
				/// <inheritdoc cref="Property.AccessModifier" />
				public string AccessModifier => "public";
				
				/// <inheritdoc cref="Property.Modifier" />
				public string Modifier => "";
				
				/// <inheritdoc cref="Property.NormativeVersion" />
				public string NormativeVersion => "";
				
				/// <inheritdoc cref="Property.DeprecatedVersion" />
				public string DeprecatedVersion => "";
				
				public string Aggregation => "composite";

				// Note: Extension.Extender
				public string Extension => "MagicDraw UML 19.0";

				public string Association => "PowerSource";

				// Note: DefaultValue.Name
				public string DefaultValue => "";

				// TODO: Add Summary
			}
		};

	}
}