
using System;
using System.CodeDom.Compiler;
using Package = Mtconnect.DeviceInformationModel.Components.Devices;

using Mtconnect;

namespace Mtconnect.DeviceInformationModel.Components {
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "1.0.15.3")]
	public class DevicesPackage {


	private Package.AgentClass _Agent;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.AgentClass Agent => _Agent ?? (_Agent = new Package.AgentClass());
	}
}