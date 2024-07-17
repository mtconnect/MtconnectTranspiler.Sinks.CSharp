using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;
// using Mtconnect.DeviceInformationModel.Components;
// using Mtconnect.DeviceInformationModel.Configurations.SolidModel;
// using Mtconnect.Glossary.IndustrialTerms;
// using Mtconnect.DeviceInformationModel.Configurations.Motion;
// using Mtconnect.DeviceInformationModel.Configurations.Relationships;
// using Mtconnect.DeviceInformationModel.Configurations.CoordinateSystems;
// using Mtconnect.DeviceInformationModel.Configurations.Specifications;
// using Mtconnect.Glossary.MTConnectTerms;
// using Mtconnect.DeviceInformationModel.Configurations.ImageFiles;
// using Mtconnect.ObservationInformationModel.ObservationTypes.EventTypes;

namespace Mtconnect.DeviceInformationModel.Configurations
{
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "1.0.15.3")]
	public sealed class ConfigurationClass : IClass
	{
		/// <inheritdoc />
		public string ReferenceId => "EAID_C04DCC77_16E8_4cef_92D4_B777AFC52570";
		
		/// <inheritdoc />
		public string Name => "ConfigurationClass";
		
		/// <inheritdoc />
		public string AccessModifier => "public";
				
		/// <inheritdoc />
		public string Modifier => "";
				
		/// <inheritdoc />
		public string NormativeVersion => "1.2";
				
		/// <inheritdoc />
		public string DeprecatedVersion => "";
		
		/// <inheritdoc />
		public string Generalization => "_19_0_3_68e0225_1635251403887_914466_345";

		/// <inheritdoc />
		public ConfigurationClassProperties Properties { get; } = new ConfigurationClassProperties();
        IPropertyList IClass.Properties => Properties;
		public sealed class ConfigurationClassProperties : IPropertyList
		{
			/// <inheritdoc />
			public IProperty[] Properties => new IProperty[] {
				IsConfigurationForPart,
				HasSolidModelPart,
				HasSensorConfigurationPart,
				HasMotionPart,
				HasRelationshipPart,
				HasCoordinateSystemPart,
				HasSpecificationPart,
				IsConfigurationForCompositionPart,
				HasImageFilePart,
				HasPowerSourcePart,
			};
			/// <remarks>Original Name: IsConfigurationFor</remarks>
			public IsConfigurationForPartProperty IsConfigurationForPart { get; } = new IsConfigurationForPartProperty();
			public sealed class IsConfigurationForPartProperty : IProperty
			{
				/// <summary>
				/// <inheritdoc />
				/// <remarks>
				/// <list type="bullet">
				/// <item>Original Type: EAID_8548C620_467A_4f50_9A22_58D84B7E8779</item>
				/// <item>Type: ComponentGeneralization</item>
				/// <item>Namespace: Mtconnect.DeviceInformationModel.Components</item>
				/// </list>
				/// </remarks>
				/// </summary>
				public System.Type Type => typeof(Mtconnect.DeviceInformationModel.Components.ComponentGeneralization);
				
				/// <inheritdoc />
				public string Name => "IsConfigurationFor";
				
				/// <inheritdoc />
				public string AccessModifier => "private";
				
				/// <inheritdoc />
				public string Modifier => "";
				
				/// <inheritdoc />
				public string NormativeVersion => "";
				
				/// <inheritdoc />
				public string DeprecatedVersion => "";
				
				/// <inheritdoc />
				public string Aggregation => "";

				// Note: Extension.Extender
				/// <inheritdoc />
				public string Extension => "";
				
				/// <inheritdoc />
				public string Association => "Configuration";

				// Note: DefaultValue.Name
				/// <inheritdoc />
				public string DefaultValue => "";

				// TODO: Add Summary
			}
			/// <remarks>Original Name: HasSolidModel</remarks>
			public HasSolidModelPartProperty HasSolidModelPart { get; } = new HasSolidModelPartProperty();
			public sealed class HasSolidModelPartProperty : IProperty
			{
				/// <summary>
				/// <inheritdoc />
				/// <remarks>
				/// <list type="bullet">
				/// <item>Original Type: _19_0_3_45f01b9_1587596157073_106480_480</item>
				/// <item>Type: SolidModelClass</item>
				/// <item>Namespace: Mtconnect.DeviceInformationModel.Configurations.SolidModel</item>
				/// </list>
				/// </remarks>
				/// </summary>
				public System.Type Type => typeof(Mtconnect.DeviceInformationModel.Configurations.SolidModel.SolidModelClass);
				
				/// <inheritdoc />
				public string Name => "HasSolidModel";
				
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
				public string Association => "SolidModel";

				// Note: DefaultValue.Name
				/// <inheritdoc />
				public string DefaultValue => "";

				// TODO: Add Summary
			}
			/// <remarks>Original Name: HasSensorConfiguration</remarks>
			public HasSensorConfigurationPartProperty HasSensorConfigurationPart { get; } = new HasSensorConfigurationPartProperty();
			public sealed class HasSensorConfigurationPartProperty : IProperty
			{
				/// <summary>
				/// <inheritdoc />
				/// <remarks>
				/// <list type="bullet">
				/// <item>Original Type: EAID_1DD02014_D949_43cc_A79F_FF2C0AF0DFBE</item>
				/// <item>Type: SensorConfigurationClass</item>
				/// <item>Namespace: Mtconnect.Glossary.IndustrialTerms</item>
				/// </list>
				/// </remarks>
				/// </summary>
				public System.Type Type => typeof(Mtconnect.Glossary.IndustrialTerms.SensorConfigurationClass);
				
				/// <inheritdoc />
				public string Name => "HasSensorConfiguration";
				
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
				public string Association => "SensorConfiguration";

				// Note: DefaultValue.Name
				/// <inheritdoc />
				public string DefaultValue => "";

				// TODO: Add Summary
			}
			/// <remarks>Original Name: HasMotion</remarks>
			public HasMotionPartProperty HasMotionPart { get; } = new HasMotionPartProperty();
			public sealed class HasMotionPartProperty : IProperty
			{
				/// <summary>
				/// <inheritdoc />
				/// <remarks>
				/// <list type="bullet">
				/// <item>Original Type: EAID_1F084FBF_2AC7_41f6_8485_C356E6D7A9C1</item>
				/// <item>Type: MotionClass</item>
				/// <item>Namespace: Mtconnect.DeviceInformationModel.Configurations.Motion</item>
				/// </list>
				/// </remarks>
				/// </summary>
				public System.Type Type => typeof(Mtconnect.DeviceInformationModel.Configurations.Motion.MotionClass);
				
				/// <inheritdoc />
				public string Name => "HasMotion";
				
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
				public string Association => "Motion";

				// Note: DefaultValue.Name
				/// <inheritdoc />
				public string DefaultValue => "";

				// TODO: Add Summary
			}
			/// <remarks>Original Name: HasRelationship</remarks>
			public HasRelationshipPartProperty HasRelationshipPart { get; } = new HasRelationshipPartProperty();
			public sealed class HasRelationshipPartProperty : IProperty
			{
				/// <summary>
				/// <inheritdoc />
				/// <remarks>
				/// <list type="bullet">
				/// <item>Original Type: EAID_28132294_DF39_4e8e_8AE5_B79565F991A2</item>
				/// <item>Type: ConfigurationRelationshipClass</item>
				/// <item>Namespace: Mtconnect.DeviceInformationModel.Configurations.Relationships</item>
				/// </list>
				/// </remarks>
				/// </summary>
				public System.Type Type => typeof(Mtconnect.DeviceInformationModel.Configurations.Relationships.ConfigurationRelationshipClass);
				
				/// <inheritdoc />
				public string Name => "HasRelationship";
				
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
				public string Extension => "";
				
				/// <inheritdoc />
				public string Association => "Relationships";

				// Note: DefaultValue.Name
				/// <inheritdoc />
				public string DefaultValue => "";

				// TODO: Add Summary
			}
			/// <remarks>Original Name: HasCoordinateSystem</remarks>
			public HasCoordinateSystemPartProperty HasCoordinateSystemPart { get; } = new HasCoordinateSystemPartProperty();
			public sealed class HasCoordinateSystemPartProperty : IProperty
			{
				/// <summary>
				/// <inheritdoc />
				/// <remarks>
				/// <list type="bullet">
				/// <item>Original Type: _19_0_3_45f01b9_1579100679936_1279_16310</item>
				/// <item>Type: CoordinateSystemClass</item>
				/// <item>Namespace: Mtconnect.DeviceInformationModel.Configurations.CoordinateSystems</item>
				/// </list>
				/// </remarks>
				/// </summary>
				public System.Type Type => typeof(Mtconnect.DeviceInformationModel.Configurations.CoordinateSystems.CoordinateSystemClass);
				
				/// <inheritdoc />
				public string Name => "HasCoordinateSystem";
				
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
				public string Extension => "";
				
				/// <inheritdoc />
				public string Association => "CoordinateSystems";

				// Note: DefaultValue.Name
				/// <inheritdoc />
				public string DefaultValue => "";

				// TODO: Add Summary
			}
			/// <remarks>Original Name: HasSpecification</remarks>
			public HasSpecificationPartProperty HasSpecificationPart { get; } = new HasSpecificationPartProperty();
			public sealed class HasSpecificationPartProperty : IProperty
			{
				/// <summary>
				/// <inheritdoc />
				/// <remarks>
				/// <list type="bullet">
				/// <item>Original Type: _19_0_3_45f01b9_1580315898400_607214_47155</item>
				/// <item>Type: SpecificationClass</item>
				/// <item>Namespace: Mtconnect.DeviceInformationModel.Configurations.Specifications</item>
				/// </list>
				/// </remarks>
				/// </summary>
				public System.Type Type => typeof(Mtconnect.DeviceInformationModel.Configurations.Specifications.SpecificationClass);
				
				/// <inheritdoc />
				public string Name => "HasSpecification";
				
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
				public string Extension => "";
				
				/// <inheritdoc />
				public string Association => "Specifications";

				// Note: DefaultValue.Name
				/// <inheritdoc />
				public string DefaultValue => "";

				// TODO: Add Summary
			}
			/// <remarks>Original Name: IsConfigurationForComposition</remarks>
			public IsConfigurationForCompositionPartProperty IsConfigurationForCompositionPart { get; } = new IsConfigurationForCompositionPartProperty();
			public sealed class IsConfigurationForCompositionPartProperty : IProperty
			{
				/// <summary>
				/// <inheritdoc />
				/// <remarks>
				/// <list type="bullet">
				/// <item>Original Type: _19_0_3_68e0225_1658936424016_561586_139</item>
				/// <item>Type: CompositionClass</item>
				/// <item>Namespace: Mtconnect.Glossary.MTConnectTerms</item>
				/// </list>
				/// </remarks>
				/// </summary>
				public System.Type Type => typeof(Mtconnect.Glossary.MTConnectTerms.CompositionClass);
				
				/// <inheritdoc />
				public string Name => "IsConfigurationForComposition";
				
				/// <inheritdoc />
				public string AccessModifier => "private";
				
				/// <inheritdoc />
				public string Modifier => "";
				
				/// <inheritdoc />
				public string NormativeVersion => "";
				
				/// <inheritdoc />
				public string DeprecatedVersion => "";
				
				/// <inheritdoc />
				public string Aggregation => "";

				// Note: Extension.Extender
				/// <inheritdoc />
				public string Extension => "";
				
				/// <inheritdoc />
				public string Association => "Configuration";

				// Note: DefaultValue.Name
				/// <inheritdoc />
				public string DefaultValue => "";

				// TODO: Add Summary
			}
			/// <remarks>Original Name: HasImageFile</remarks>
			public HasImageFilePartProperty HasImageFilePart { get; } = new HasImageFilePartProperty();
			public sealed class HasImageFilePartProperty : IProperty
			{
				/// <summary>
				/// <inheritdoc />
				/// <remarks>
				/// <list type="bullet">
				/// <item>Original Type: _19_0_3_68e0225_1677585025728_765757_660</item>
				/// <item>Type: ImageFileClass</item>
				/// <item>Namespace: Mtconnect.DeviceInformationModel.Configurations.ImageFiles</item>
				/// </list>
				/// </remarks>
				/// </summary>
				public System.Type Type => typeof(Mtconnect.DeviceInformationModel.Configurations.ImageFiles.ImageFileClass);
				
				/// <inheritdoc />
				public string Name => "HasImageFile";
				
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
				public string Extension => "";
				
				/// <inheritdoc />
				public string Association => "ImageFiles";

				// Note: DefaultValue.Name
				/// <inheritdoc />
				public string DefaultValue => "";

				// TODO: Add Summary
			}
			/// <remarks>Original Name: HasPowerSource</remarks>
			public HasPowerSourcePartProperty HasPowerSourcePart { get; } = new HasPowerSourcePartProperty();
			public sealed class HasPowerSourcePartProperty : IProperty
			{
				/// <summary>
				/// <inheritdoc />
				/// <remarks>
				/// <list type="bullet">
				/// <item>Original Type: _19_0_3_68e0225_1696870815347_556704_3251</item>
				/// <item>Type: PowerSourceClass</item>
				/// <item>Namespace: Mtconnect.ObservationInformationModel.ObservationTypes.EventTypes</item>
				/// </list>
				/// </remarks>
				/// </summary>
				public System.Type Type => typeof(Mtconnect.ObservationInformationModel.ObservationTypes.EventTypes.PowerSourceClass);
				
				/// <inheritdoc />
				public string Name => "HasPowerSource";
				
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
				public string Association => "PowerSource";

				// Note: DefaultValue.Name
				/// <inheritdoc />
				public string DefaultValue => "";

				// TODO: Add Summary
			}
		};

	}
}