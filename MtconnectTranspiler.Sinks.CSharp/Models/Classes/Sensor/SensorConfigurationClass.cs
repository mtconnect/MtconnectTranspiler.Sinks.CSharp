#pragma warning disable CS0109 // Member does not hide an inherited member; new keyword is not required
#pragma warning disable CS1574 // XML comment has cref attribute that could not be resolved
#pragma warning disable CS1584 // XML comment has syntactically incorrect cref attribute
#pragma warning disable CS0618 // Type or member is obsolete
using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;

namespace Mtconnect.DeviceInformationModel.Configurations.Sensor
{
	/// <summary>﻿configuration for a <see cref="Sensor">Sensor</see>.<br /><br /><br />Description<br /><br />![SensorConfiguration](figures/SensorConfiguration.png "SensorConfiguration"){: width="0.8"}<br /><br />&gt; Note: See <see cref="Configuration Schema Diagrams">Configuration Schema Diagrams</see> for XML schema.<br /><br /><br /><br /><br />
	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Structure__EAID_1DD02014_D949_43cc_A79F_FF2C0AF0DFBE">model.mtconnect.org</seealso> for more information.
	/// </summary>
	/// <remarks>
	/// <list type="bullet">
	/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.2">v1.2</see></item>
	/// </list>
	/// </remarks>

	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public sealed class SensorConfigurationClass : IClass
	{
		/// <summary>Constant value for <see cref="SensorConfigurationClass.ReferenceId" /></summary>
		public const string REFERENCE_ID = "EAID_1DD02014_D949_43cc_A79F_FF2C0AF0DFBE";
		/// <summary>Constant value for <see cref="SensorConfigurationClass.HelpUrl" /></summary>
		public const string HELP_URL = "https://model.mtconnect.org/#Structure__EAID_1DD02014_D949_43cc_A79F_FF2C0AF0DFBE";
		/// <summary>Constant value for <see cref="SensorConfigurationClass.Summary" /></summary>
		public const string SUMMARY = @"&#10;&#10;&#10;configuration for a {{block(Sensor)}}.&#10;
&#10;&#10;&#10;Description&#10;&#10;&#10;&#10;![SensorConfiguration](figures/SensorConfiguration.png ""SensorConfiguration""){: width=""0.8""}

> Note: See {{sect(Configuration Schema Diagrams)}} for XML schema.&#10;
";
		/// <summary>Constant value for <see cref="SensorConfigurationClass.Name" /></summary>
		public const string NAME = "SensorConfiguration";
		/// <summary>Constant value for <see cref="SensorConfigurationClass.AccessModifier" /></summary>
		public const string ACCESS_MODIFIER = "public";
		/// <summary>Constant value for <see cref="SensorConfigurationClass.Modifier" /></summary>
		public const string MODIFIER = "";
		/// <summary>Constant value for <see cref="SensorConfigurationClass.NormativeVersion" /></summary>
		public const string NORMATIVE_VERSION = "1.2";
		/// <summary>Constant value for <see cref="SensorConfigurationClass.DeprecatedVersion" /></summary>
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
		public Type Generalization => null;

		/// <inheritdoc />
		public new SensorConfigurationClassProperties Properties { get; } = new SensorConfigurationClassProperties();
        IPropertyList IClass.Properties => Properties;
		/// <summary>
		/// Property list for <see cref="SensorConfigurationClass" />.
		/// </summary>
		public class SensorConfigurationClassProperties : IPropertyList
		{
			/// <inheritdoc />
			public virtual IProperty[] Properties => new IProperty[] {
				CalibrationDate,
				CalibrationInitials,
				FirmwareVersion,
				NextCalibrationDate,
				HasChannelPart,
			};
			/// <summary>
			/// <inheritdoc cref="CalibrationDateProperty" path="/summary" /><br/>
			/// <remarks>Original Name: CalibrationDate</remarks>
			/// </summary>
			public CalibrationDateProperty CalibrationDate { get; } = new CalibrationDateProperty();
			
			/// <summary>﻿Date upon which the <i>sensor unit</i> was last calibrated.<br /><br /><br />
			/// </summary>
			public sealed class CalibrationDateProperty : IProperty
			{
				/// <summary>Constant value for <see cref="CalibrationDateProperty.Name" /></summary>
				public const string NAME = "CalibrationDate";
				/// <summary>Constant value for <see cref="CalibrationDateProperty.Summary" /></summary>
				public const string SUMMARY = @"&#10;&#10;&#10;Date upon which the {{term(sensor unit)}} was last calibrated.&#10;
";
				/// <summary>Constant value for <see cref="CalibrationDateProperty.AccessModifier" /></summary>
				public const string ACCESS_MODIFIER = "public";
				/// <summary>Constant value for <see cref="CalibrationDateProperty.Modifier" /></summary>
				public const string MODIFIER = "";
				/// <summary>Constant value for <see cref="CalibrationDateProperty.NormativeVersion" /></summary>
				public const string NORMATIVE_VERSION = "1.2";
				/// <summary>Constant value for <see cref="CalibrationDateProperty.DeprecatedVersion" /></summary>
				public const string DEPRECATED_VERSION = "";
				/// <summary>Constant value for <see cref="CalibrationDateProperty.Aggregation" /></summary>
				public const string AGGREGATION = "";
				/// <summary>Constant value for <see cref="CalibrationDateProperty.Extension" /></summary>
				public const string EXTENSION = "MagicDraw UML 19.0";
				/// <summary>Constant value for <see cref="CalibrationDateProperty.Association" /></summary>
				public const string ASSOCIATION = "";
				/// <summary>Constant value for <see cref="CalibrationDateProperty.DefaultValue" /></summary>
				public const string DEFAULT_VALUE = "";

				/// <summary>
				/// <inheritdoc />
				/// <remarks> Type: DateTime </remarks>
				/// </summary>
				public System.Type Type => typeof(DateTime);
				
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
			/// <inheritdoc cref="CalibrationInitialsProperty" path="/summary" /><br/>
			/// <remarks>Original Name: CalibrationInitials</remarks>
			/// </summary>
			public CalibrationInitialsProperty CalibrationInitials { get; } = new CalibrationInitialsProperty();
			
			/// <summary>﻿The initials of the person verifying the validity of the calibration data.<br /><br /><br />
			/// </summary>
			public sealed class CalibrationInitialsProperty : IProperty
			{
				/// <summary>Constant value for <see cref="CalibrationInitialsProperty.Name" /></summary>
				public const string NAME = "CalibrationInitials";
				/// <summary>Constant value for <see cref="CalibrationInitialsProperty.Summary" /></summary>
				public const string SUMMARY = @"&#10;&#10;&#10;The initials of the person verifying the validity of the calibration data.&#10;
";
				/// <summary>Constant value for <see cref="CalibrationInitialsProperty.AccessModifier" /></summary>
				public const string ACCESS_MODIFIER = "public";
				/// <summary>Constant value for <see cref="CalibrationInitialsProperty.Modifier" /></summary>
				public const string MODIFIER = "";
				/// <summary>Constant value for <see cref="CalibrationInitialsProperty.NormativeVersion" /></summary>
				public const string NORMATIVE_VERSION = "1.2";
				/// <summary>Constant value for <see cref="CalibrationInitialsProperty.DeprecatedVersion" /></summary>
				public const string DEPRECATED_VERSION = "";
				/// <summary>Constant value for <see cref="CalibrationInitialsProperty.Aggregation" /></summary>
				public const string AGGREGATION = "";
				/// <summary>Constant value for <see cref="CalibrationInitialsProperty.Extension" /></summary>
				public const string EXTENSION = "MagicDraw UML 19.0";
				/// <summary>Constant value for <see cref="CalibrationInitialsProperty.Association" /></summary>
				public const string ASSOCIATION = "";
				/// <summary>Constant value for <see cref="CalibrationInitialsProperty.DefaultValue" /></summary>
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
			/// <inheritdoc cref="FirmwareVersionProperty" path="/summary" /><br/>
			/// <remarks>Original Name: FirmwareVersion</remarks>
			/// </summary>
			public FirmwareVersionProperty FirmwareVersion { get; } = new FirmwareVersionProperty();
			
			/// <summary>﻿Version number for the sensor unit as specified by the manufacturer.<br /><br /><br /><br />
			/// </summary>
			public sealed class FirmwareVersionProperty : IProperty
			{
				/// <summary>Constant value for <see cref="FirmwareVersionProperty.Name" /></summary>
				public const string NAME = "FirmwareVersion";
				/// <summary>Constant value for <see cref="FirmwareVersionProperty.Summary" /></summary>
				public const string SUMMARY = @"&#10;&#10;&#10;Version number for the sensor unit as specified by the manufacturer.&#10;
";
				/// <summary>Constant value for <see cref="FirmwareVersionProperty.AccessModifier" /></summary>
				public const string ACCESS_MODIFIER = "public";
				/// <summary>Constant value for <see cref="FirmwareVersionProperty.Modifier" /></summary>
				public const string MODIFIER = "";
				/// <summary>Constant value for <see cref="FirmwareVersionProperty.NormativeVersion" /></summary>
				public const string NORMATIVE_VERSION = "1.2";
				/// <summary>Constant value for <see cref="FirmwareVersionProperty.DeprecatedVersion" /></summary>
				public const string DEPRECATED_VERSION = "";
				/// <summary>Constant value for <see cref="FirmwareVersionProperty.Aggregation" /></summary>
				public const string AGGREGATION = "";
				/// <summary>Constant value for <see cref="FirmwareVersionProperty.Extension" /></summary>
				public const string EXTENSION = "MagicDraw UML 19.0";
				/// <summary>Constant value for <see cref="FirmwareVersionProperty.Association" /></summary>
				public const string ASSOCIATION = "";
				/// <summary>Constant value for <see cref="FirmwareVersionProperty.DefaultValue" /></summary>
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
			/// <inheritdoc cref="NextCalibrationDateProperty" path="/summary" /><br/>
			/// <remarks>Original Name: NextCalibrationDate</remarks>
			/// </summary>
			public NextCalibrationDateProperty NextCalibrationDate { get; } = new NextCalibrationDateProperty();
			
			/// <summary>﻿Date upon which the <i>sensor unit</i> is next scheduled to be calibrated.<br /><br /><br />
			/// </summary>
			public sealed class NextCalibrationDateProperty : IProperty
			{
				/// <summary>Constant value for <see cref="NextCalibrationDateProperty.Name" /></summary>
				public const string NAME = "NextCalibrationDate";
				/// <summary>Constant value for <see cref="NextCalibrationDateProperty.Summary" /></summary>
				public const string SUMMARY = @"&#10;&#10;&#10;Date upon which the {{term(sensor unit)}} is next scheduled to be calibrated.&#10;
";
				/// <summary>Constant value for <see cref="NextCalibrationDateProperty.AccessModifier" /></summary>
				public const string ACCESS_MODIFIER = "public";
				/// <summary>Constant value for <see cref="NextCalibrationDateProperty.Modifier" /></summary>
				public const string MODIFIER = "";
				/// <summary>Constant value for <see cref="NextCalibrationDateProperty.NormativeVersion" /></summary>
				public const string NORMATIVE_VERSION = "1.2";
				/// <summary>Constant value for <see cref="NextCalibrationDateProperty.DeprecatedVersion" /></summary>
				public const string DEPRECATED_VERSION = "";
				/// <summary>Constant value for <see cref="NextCalibrationDateProperty.Aggregation" /></summary>
				public const string AGGREGATION = "";
				/// <summary>Constant value for <see cref="NextCalibrationDateProperty.Extension" /></summary>
				public const string EXTENSION = "MagicDraw UML 19.0";
				/// <summary>Constant value for <see cref="NextCalibrationDateProperty.Association" /></summary>
				public const string ASSOCIATION = "";
				/// <summary>Constant value for <see cref="NextCalibrationDateProperty.DefaultValue" /></summary>
				public const string DEFAULT_VALUE = "";

				/// <summary>
				/// <inheritdoc />
				/// <remarks> Type: DateTime </remarks>
				/// </summary>
				public System.Type Type => typeof(DateTime);
				
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
			/// <inheritdoc cref="HasChannelPartProperty" path="/summary" /><br/>
			/// <remarks>Original Name: HasChannel</remarks>
			/// </summary>
			public HasChannelPartProperty HasChannelPart { get; } = new HasChannelPartProperty();
			
			/// <summary>﻿
			/// </summary>
			public sealed class HasChannelPartProperty : IProperty
			{
				/// <summary>Constant value for <see cref="HasChannelPartProperty.Name" /></summary>
				public const string NAME = "hasChannel";
				/// <summary>Constant value for <see cref="HasChannelPartProperty.Summary" /></summary>
				public const string SUMMARY = @"";
				/// <summary>Constant value for <see cref="HasChannelPartProperty.AccessModifier" /></summary>
				public const string ACCESS_MODIFIER = "public";
				/// <summary>Constant value for <see cref="HasChannelPartProperty.Modifier" /></summary>
				public const string MODIFIER = "";
				/// <summary>Constant value for <see cref="HasChannelPartProperty.NormativeVersion" /></summary>
				public const string NORMATIVE_VERSION = "";
				/// <summary>Constant value for <see cref="HasChannelPartProperty.DeprecatedVersion" /></summary>
				public const string DEPRECATED_VERSION = "";
				/// <summary>Constant value for <see cref="HasChannelPartProperty.Aggregation" /></summary>
				public const string AGGREGATION = "composite";
				/// <summary>Constant value for <see cref="HasChannelPartProperty.Extension" /></summary>
				public const string EXTENSION = "";
				/// <summary>Constant value for <see cref="HasChannelPartProperty.Association" /></summary>
				public const string ASSOCIATION = "Channels";
				/// <summary>Constant value for <see cref="HasChannelPartProperty.DefaultValue" /></summary>
				public const string DEFAULT_VALUE = "";

				/// <summary>
				/// <inheritdoc />
				/// <remarks> Type: ChannelClass </remarks>
				/// </summary>
				public System.Type Type => typeof(Mtconnect.DeviceInformationModel.Configurations.Sensor.ChannelClass);
				
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