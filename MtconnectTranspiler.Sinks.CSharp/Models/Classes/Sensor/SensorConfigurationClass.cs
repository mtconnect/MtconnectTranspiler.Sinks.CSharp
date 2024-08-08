using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;
// using Mtconnect.DeviceInformationModel.Configurations.Sensor;

namespace Mtconnect.DeviceInformationModel.Configurations.Sensor
{
	/// <summary>
	/// configuration for a <see cref="Sensor">Sensor</see>./// Description
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.3.0.0")]
	public sealed class SensorConfigurationClass : IClass
	{
		/// <inheritdoc />
		public string ReferenceId => "EAID_1DD02014_D949_43cc_A79F_FF2C0AF0DFBE";
		
		/// <inheritdoc />
		public string Summary => @"/// configuration for a <see cref=""Sensor"">Sensor</see>./// Description";

		/// <inheritdoc />
		public string Name => "SensorConfigurationClass";
		
		/// <inheritdoc />
		public string AccessModifier => "public";
				
		/// <inheritdoc />
		public string Modifier => "";
				
		/// <inheritdoc />
		public string NormativeVersion => "1.2";
				
		/// <inheritdoc />
		public string DeprecatedVersion => "";
		
		/// <inheritdoc />
		public string Generalization => "";

		/// <inheritdoc />
		public SensorConfigurationClassProperties Properties { get; } = new SensorConfigurationClassProperties();
        IPropertyList IClass.Properties => Properties;
		public sealed class SensorConfigurationClassProperties : IPropertyList
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
			/// <summary>
			/// Date upon which the <i>sensor unit</i> was last calibrated.
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
				public string Summary => @"/// configuration for a <see cref=""Sensor"">Sensor</see>./// Description";

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
			/// <summary>
			/// The initials of the person verifying the validity of the calibration data.
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
				public string Summary => @"/// configuration for a <see cref=""Sensor"">Sensor</see>./// Description";

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
			/// <summary>
			/// Version number for the sensor unit as specified by the manufacturer. 
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
				public string Summary => @"/// configuration for a <see cref=""Sensor"">Sensor</see>./// Description";

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
			/// <summary>
			/// Date upon which the <i>sensor unit</i> is next scheduled to be calibrated.
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
				public string Summary => @"/// configuration for a <see cref=""Sensor"">Sensor</see>./// Description";

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
				public string Name => "HasChannel";
				
				/// <inheritdoc />
				public string Summary => @"/// configuration for a <see cref=""Sensor"">Sensor</see>./// Description";

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