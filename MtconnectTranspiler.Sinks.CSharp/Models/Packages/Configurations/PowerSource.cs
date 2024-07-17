using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;
using Package = Mtconnect.DeviceInformationModel.Configurations.PowerSource;
// using Mtconnect;

namespace Mtconnect.DeviceInformationModel.Configurations {
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "1.0.15.3")]
	public class PowerSourcePackage : IPackage {
		public IPackage[] Packages => new IPackage[] {
		};

		public IClass[] Classes => new IClass[] {
			PowerSourceClass,
		};

	private Package.PowerSourceClass _PowerSourceClass;
	public Package.PowerSourceClass PowerSourceClass => _PowerSourceClass ?? (_PowerSourceClass = new Package.PowerSourceClass());
	}
}