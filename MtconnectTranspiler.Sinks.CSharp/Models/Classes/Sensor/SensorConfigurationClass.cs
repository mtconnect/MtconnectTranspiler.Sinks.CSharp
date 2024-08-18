#pragma warning disable CS0109 // Member does not hide an inherited member; new keyword is not required
#pragma warning disable CS1574 // XML comment has cref attribute that could not be resolved
#pragma warning disable CS1584 // XML comment has syntactically incorrect cref attribute
using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;

namespace Mtconnect.DeviceInformationModel.Configurations.Sensor
{
	/// <summary>﻿configuration for a <see cref="Sensor">Sensor</see>.<br /><br /><br />Description<br /><br />![SensorConfiguration](figures/SensorConfiguration.png "SensorConfiguration"){: width="0.8"}<br /><br />&gt; Note: See <see cref="Configuration Schema Diagrams">Configuration Schema Diagrams</see> for XML schema.<br /><br /><br /><br /><br />
	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Structure__EAID_1DD02014_D949_43cc_A79F_FF2C0AF0DFBE">model.mtconnect.org</seealso> for more information.
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public sealed class SensorConfigurationClass : IClass
	{
		/// <inheritdoc />
		public string ReferenceId => "EAID_1DD02014_D949_43cc_A79F_FF2C0AF0DFBE";
		
		/// <inheritdoc />
		public string Summary => @"&#10;&#10;&#10;configuration for a {{block(Sensor)}}.&#10;
&#10;&#10;&#10;Description&#10;&#10;&#10;&#10;![SensorConfiguration](figures/SensorConfiguration.png ""SensorConfiguration""){: width=""0.8""}

> Note: See {{sect(Configuration Schema Diagrams)}} for XML schema.&#10;
";

		/// <inheritdoc />
		public string Name => "SensorConfiguration";
		
		/// <inheritdoc />
		public string AccessModifier => "public";
				
		/// <inheritdoc />
		public string Modifier => "";
				
		/// <inheritdoc />
		public string NormativeVersion => "1.2";
				
		/// <inheritdoc />
		public string DeprecatedVersion => "";
		
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
			public IProperty[] Properties => new IProperty[] {
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
				/// <summary>
				/// <inheritdoc />
				/// <remarks>
				/// <list type="bullet">
				/// <item>Original Type: _19_0_3_91b028d_1579272233011_597138_670</item>
				/// <item>Type: DateTime</item>
				/// <item>Namespace: </item>
				/// </list>
				/// </remarks>
				/// </summary>
				public System.Type Type => typeof(DateTime);
				
				/// <inheritdoc />
				public string Name => "CalibrationDate";
				
				/// <inheritdoc />
				public string Summary => @"&#10;&#10;&#10;Date upon which the {{term(sensor unit)}} was last calibrated.&#10;
";

				/// <inheritdoc />
				public string AccessModifier => "public";
				
				/// <inheritdoc />
				public string Modifier => "";
				
				/// <inheritdoc />
				public string NormativeVersion => "1.2";
				
				/// <inheritdoc />
				public string DeprecatedVersion => "";
				
				/// <inheritdoc />
				public string Aggregation => "";

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
			/// <inheritdoc cref="CalibrationInitialsProperty" path="/summary" /><br/>
			/// <remarks>Original Name: CalibrationInitials</remarks>
			/// </summary>
			public CalibrationInitialsProperty CalibrationInitials { get; } = new CalibrationInitialsProperty();
			
			/// <summary>﻿The initials of the person verifying the validity of the calibration data.<br /><br /><br />
			/// </summary>
			public sealed class CalibrationInitialsProperty : IProperty
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
				public string Name => "CalibrationInitials";
				
				/// <inheritdoc />
				public string Summary => @"&#10;&#10;&#10;The initials of the person verifying the validity of the calibration data.&#10;
";

				/// <inheritdoc />
				public string AccessModifier => "public";
				
				/// <inheritdoc />
				public string Modifier => "";
				
				/// <inheritdoc />
				public string NormativeVersion => "1.2";
				
				/// <inheritdoc />
				public string DeprecatedVersion => "";
				
				/// <inheritdoc />
				public string Aggregation => "";

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
			/// <inheritdoc cref="FirmwareVersionProperty" path="/summary" /><br/>
			/// <remarks>Original Name: FirmwareVersion</remarks>
			/// </summary>
			public FirmwareVersionProperty FirmwareVersion { get; } = new FirmwareVersionProperty();
			
			/// <summary>﻿Version number for the sensor unit as specified by the manufacturer.<br /><br /><br /><br />
			/// </summary>
			public sealed class FirmwareVersionProperty : IProperty
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
				public string Name => "FirmwareVersion";
				
				/// <inheritdoc />
				public string Summary => @"&#10;&#10;&#10;Version number for the sensor unit as specified by the manufacturer.&#10;
";

				/// <inheritdoc />
				public string AccessModifier => "public";
				
				/// <inheritdoc />
				public string Modifier => "";
				
				/// <inheritdoc />
				public string NormativeVersion => "1.2";
				
				/// <inheritdoc />
				public string DeprecatedVersion => "";
				
				/// <inheritdoc />
				public string Aggregation => "";

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
			/// <inheritdoc cref="NextCalibrationDateProperty" path="/summary" /><br/>
			/// <remarks>Original Name: NextCalibrationDate</remarks>
			/// </summary>
			public NextCalibrationDateProperty NextCalibrationDate { get; } = new NextCalibrationDateProperty();
			
			/// <summary>﻿Date upon which the <i>sensor unit</i> is next scheduled to be calibrated.<br /><br /><br />
			/// </summary>
			public sealed class NextCalibrationDateProperty : IProperty
			{
				/// <summary>
				/// <inheritdoc />
				/// <remarks>
				/// <list type="bullet">
				/// <item>Original Type: _19_0_3_91b028d_1579272233011_597138_670</item>
				/// <item>Type: DateTime</item>
				/// <item>Namespace: </item>
				/// </list>
				/// </remarks>
				/// </summary>
				public System.Type Type => typeof(DateTime);
				
				/// <inheritdoc />
				public string Name => "NextCalibrationDate";
				
				/// <inheritdoc />
				public string Summary => @"&#10;&#10;&#10;Date upon which the {{term(sensor unit)}} is next scheduled to be calibrated.&#10;
";

				/// <inheritdoc />
				public string AccessModifier => "public";
				
				/// <inheritdoc />
				public string Modifier => "";
				
				/// <inheritdoc />
				public string NormativeVersion => "1.2";
				
				/// <inheritdoc />
				public string DeprecatedVersion => "";
				
				/// <inheritdoc />
				public string Aggregation => "";

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
			/// <inheritdoc cref="HasChannelPartProperty" path="/summary" /><br/>
			/// <remarks>Original Name: HasChannel</remarks>
			/// </summary>
			public HasChannelPartProperty HasChannelPart { get; } = new HasChannelPartProperty();
			
			/// <summary>﻿
			/// </summary>
			public sealed class HasChannelPartProperty : IProperty
			{
				/// <summary>
				/// <inheritdoc />
				/// <remarks>
				/// <list type="bullet">
				/// <item>Original Type: EAID_82C852E8_47AD_4b8c_804D_F38FCA663918</item>
				/// <item>Type: ChannelClass</item>
				/// <item>Namespace: Mtconnect.DeviceInformationModel.Configurations.Sensor</item>
				/// </list>
				/// </remarks>
				/// </summary>
				public System.Type Type => typeof(Mtconnect.DeviceInformationModel.Configurations.Sensor.ChannelClass);
				
				/// <inheritdoc />
				public string Name => "hasChannel";
				
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
				public string Association => "Channels";

				// Note: DefaultValue.Name
				/// <inheritdoc />
				public string DefaultValue => "";
			}
		};

	}
}