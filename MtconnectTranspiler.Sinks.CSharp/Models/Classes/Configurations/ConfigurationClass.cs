using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;
using System.Linq;

namespace Mtconnect.DeviceInformationModel.Configurations
{
	/// <summary>
	﻿/// technical information about an entity describing its physical layout, functional characteristics, and relationships with other entities.<br/><br />

	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Structure__EAID_C04DCC77_16E8_4cef_92D4_B777AFC52570">model.mtconnect.org</seealso> for more information.
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public sealed class ConfigurationClass : IClass
	{
		/// <inheritdoc />
		public string ReferenceId => "EAID_C04DCC77_16E8_4cef_92D4_B777AFC52570";
		
		/// <inheritdoc />
		public string Summary => @"&#10;&#10;&#10;technical information about an entity describing its physical layout, functional characteristics, and relationships with other entities.&#10;
";

		/// <inheritdoc />
		public string Name => "Configuration";
		
		/// <inheritdoc />
		public string AccessModifier => "public";
				
		/// <inheritdoc />
		public string Modifier => "";
				
		/// <inheritdoc />
		public string NormativeVersion => "1.2";
				
		/// <inheritdoc />
		public string DeprecatedVersion => "";
		
		/// <inheritdoc />
		/// <remarks>
		/// Original Type: _19_0_3_68e0225_1635251403887_914466_345
		/// </remarks>
		public Type Generalization => typeof(Mtconnect.Glossary.MTConnectTerms.ConfigurationGeneralization);

		/// <inheritdoc />
		public ConfigurationClassProperties Properties { get; } = new ConfigurationClassProperties();
        IPropertyList IClass.Properties => Properties;
		public class ConfigurationClassProperties : Mtconnect.Glossary.MTConnectTerms.ConfigurationGeneralization.ConfigurationGeneralizationProperties
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
			}.Concat(base.Properties).ToArray();
			/// <summary>
			/// <inheritdoc cref="IsConfigurationForPartProperty" path="/summary" /><br/>
			/// <remarks>Original Name: IsConfigurationFor</remarks>
			/// </summary>
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
				public string Name => "isConfigurationFor";
				
				/// <inheritdoc />
				public string Summary => @"";

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
			}
			/// <summary>
			/// <inheritdoc cref="HasSolidModelPartProperty" path="/summary" /><br/>
			/// <remarks>Original Name: HasSolidModel</remarks>
			/// </summary>
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
				public string Name => "hasSolidModel";
				
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
				public string Association => "SolidModel";

				// Note: DefaultValue.Name
				/// <inheritdoc />
				public string DefaultValue => "";
			}
			/// <summary>
			/// <inheritdoc cref="HasSensorConfigurationPartProperty" path="/summary" /><br/>
			/// <remarks>Original Name: HasSensorConfiguration</remarks>
			/// </summary>
			public HasSensorConfigurationPartProperty HasSensorConfigurationPart { get; } = new HasSensorConfigurationPartProperty();
			public sealed class HasSensorConfigurationPartProperty : IProperty
			{
				/// <summary>
				/// <inheritdoc />
				/// <remarks>
				/// <list type="bullet">
				/// <item>Original Type: EAID_1DD02014_D949_43cc_A79F_FF2C0AF0DFBE</item>
				/// <item>Type: SensorConfigurationClass</item>
				/// <item>Namespace: Mtconnect.DeviceInformationModel.Configurations.Sensor</item>
				/// </list>
				/// </remarks>
				/// </summary>
				public System.Type Type => typeof(Mtconnect.DeviceInformationModel.Configurations.Sensor.SensorConfigurationClass);
				
				/// <inheritdoc />
				public string Name => "hasSensorConfiguration";
				
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
				public string Association => "SensorConfiguration";

				// Note: DefaultValue.Name
				/// <inheritdoc />
				public string DefaultValue => "";
			}
			/// <summary>
			/// <inheritdoc cref="HasMotionPartProperty" path="/summary" /><br/>
			/// <remarks>Original Name: HasMotion</remarks>
			/// </summary>
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
				public string Name => "hasMotion";
				
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
				public string Association => "Motion";

				// Note: DefaultValue.Name
				/// <inheritdoc />
				public string DefaultValue => "";
			}
			/// <summary>
			/// <inheritdoc cref="HasRelationshipPartProperty" path="/summary" /><br/>
			/// <remarks>Original Name: HasRelationship</remarks>
			/// </summary>
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
				public string Name => "hasRelationship";
				
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
				public string Extension => "";
				
				/// <inheritdoc />
				public string Association => "Relationships";

				// Note: DefaultValue.Name
				/// <inheritdoc />
				public string DefaultValue => "";
			}
			/// <summary>
			/// <inheritdoc cref="HasCoordinateSystemPartProperty" path="/summary" /><br/>
			/// <remarks>Original Name: HasCoordinateSystem</remarks>
			/// </summary>
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
				public string Name => "hasCoordinateSystem";
				
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
				public string Extension => "";
				
				/// <inheritdoc />
				public string Association => "CoordinateSystems";

				// Note: DefaultValue.Name
				/// <inheritdoc />
				public string DefaultValue => "";
			}
			/// <summary>
			/// <inheritdoc cref="HasSpecificationPartProperty" path="/summary" /><br/>
			/// <remarks>Original Name: HasSpecification</remarks>
			/// </summary>
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
				public string Name => "hasSpecification";
				
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
				public string Extension => "";
				
				/// <inheritdoc />
				public string Association => "Specifications";

				// Note: DefaultValue.Name
				/// <inheritdoc />
				public string DefaultValue => "";
			}
			/// <summary>
			/// <inheritdoc cref="IsConfigurationForCompositionPartProperty" path="/summary" /><br/>
			/// <remarks>Original Name: IsConfigurationForComposition</remarks>
			/// </summary>
			public IsConfigurationForCompositionPartProperty IsConfigurationForCompositionPart { get; } = new IsConfigurationForCompositionPartProperty();
			public sealed class IsConfigurationForCompositionPartProperty : IProperty
			{
				/// <summary>
				/// <inheritdoc />
				/// <remarks>
				/// <list type="bullet">
				/// <item>Original Type: _19_0_3_68e0225_1658936424016_561586_139</item>
				/// <item>Type: CompositionClass</item>
				/// <item>Namespace: Mtconnect.DeviceInformationModel.Compositions</item>
				/// </list>
				/// </remarks>
				/// </summary>
				public System.Type Type => typeof(Mtconnect.DeviceInformationModel.Compositions.CompositionClass);
				
				/// <inheritdoc />
				public string Name => "isConfigurationFor";
				
				/// <inheritdoc />
				public string Summary => @"";

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
			}
			/// <summary>
			/// <inheritdoc cref="HasImageFilePartProperty" path="/summary" /><br/>
			/// <remarks>Original Name: HasImageFile</remarks>
			/// </summary>
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
				public string Name => "hasImageFile";
				
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
				public string Extension => "";
				
				/// <inheritdoc />
				public string Association => "ImageFiles";

				// Note: DefaultValue.Name
				/// <inheritdoc />
				public string DefaultValue => "";
			}
			/// <summary>
			/// <inheritdoc cref="HasPowerSourcePartProperty" path="/summary" /><br/>
			/// <remarks>Original Name: HasPowerSource</remarks>
			/// </summary>
			public HasPowerSourcePartProperty HasPowerSourcePart { get; } = new HasPowerSourcePartProperty();
			public sealed class HasPowerSourcePartProperty : IProperty
			{
				/// <summary>
				/// <inheritdoc />
				/// <remarks>
				/// <list type="bullet">
				/// <item>Original Type: _19_0_3_68e0225_1696870815347_556704_3251</item>
				/// <item>Type: PowerSourceClass</item>
				/// <item>Namespace: Mtconnect.DeviceInformationModel.Configurations.PowerSource</item>
				/// </list>
				/// </remarks>
				/// </summary>
				public System.Type Type => typeof(Mtconnect.DeviceInformationModel.Configurations.PowerSource.PowerSourceClass);
				
				/// <inheritdoc />
				public string Name => "hasPowerSource";
				
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
				public string Association => "PowerSource";

				// Note: DefaultValue.Name
				/// <inheritdoc />
				public string DefaultValue => "";
			}
		};

	}
}