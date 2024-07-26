
using System;
using System.CodeDom.Compiler;
using Package = Mtconnect.DeviceInformationModel.Configurations.PowerSource;

using Mtconnect;

namespace Mtconnect.DeviceInformationModel.Configurations {
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "1.0.15.3")]
	public class PowerSourcePackage {


	private Package.PowerSourceClass _PowerSource;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.PowerSourceClass PowerSource => _PowerSource ?? (_PowerSource = new Package.PowerSourceClass());
	}
}