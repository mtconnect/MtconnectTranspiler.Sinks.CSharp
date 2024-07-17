using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;
using Package = Mtconnect.DeviceInformationModel.Components.Devices;
// using Mtconnect;

namespace Mtconnect.DeviceInformationModel.Components {
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "1.0.15.3")]
	public class DevicesPackage : IPackage {
		public IPackage[] Packages => new IPackage[] {
		};

		public IClass[] Classes => new IClass[] {
			AgentClass,
		};

	private Package.AgentClass _AgentClass;
	public Package.AgentClass AgentClass => _AgentClass ?? (_AgentClass = new Package.AgentClass());
	}
}