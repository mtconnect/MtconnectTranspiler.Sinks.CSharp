using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;
using Package = Mtconnect.DeviceInformationModel.Configurations.Sensor;
// using Mtconnect;

namespace Mtconnect.DeviceInformationModel.Configurations {
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "1.0.15.3")]
	public class SensorPackage : IPackage {
		public IPackage[] Packages => new IPackage[] {
		};

		public IClass[] Classes => new IClass[] {
			SensorConfigurationClass,
			ChannelClass,
		};

	private Package.SensorConfigurationClass _SensorConfigurationClass;
	public Package.SensorConfigurationClass SensorConfigurationClass => _SensorConfigurationClass ?? (_SensorConfigurationClass = new Package.SensorConfigurationClass());
	private Package.ChannelClass _ChannelClass;
	public Package.ChannelClass ChannelClass => _ChannelClass ?? (_ChannelClass = new Package.ChannelClass());
	}
}