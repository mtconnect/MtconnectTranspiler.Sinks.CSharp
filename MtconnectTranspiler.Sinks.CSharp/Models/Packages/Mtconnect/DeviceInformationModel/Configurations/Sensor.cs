
using System;
using System.CodeDom.Compiler;
using Package = Mtconnect.DeviceInformationModel.Configurations.Sensor;

using Mtconnect;

namespace Mtconnect.DeviceInformationModel.Configurations {
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "1.0.15.3")]
	public class SensorPackage {


	private Package.SensorConfigurationClass _SensorConfiguration;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.SensorConfigurationClass SensorConfiguration => _SensorConfiguration ?? (_SensorConfiguration = new Package.SensorConfigurationClass());

	private Package.ChannelClass _Channel;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.ChannelClass Channel => _Channel ?? (_Channel = new Package.ChannelClass());
	}
}