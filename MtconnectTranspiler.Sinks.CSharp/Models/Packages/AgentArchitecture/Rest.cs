using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;
using Package = Mtconnect.AgentArchitecture.Rest;

namespace Mtconnect.AgentArchitecture {
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "1.0.15.3")]
	public class RestPackage : IPackage {
		public IPackage[] Packages => new IPackage[] {
			StoragePackage,
		};

		public IClass[] Classes => new IClass[] {
		};
	private Package.StoragePackage _StoragePackage;
	public Package.StoragePackage StoragePackage => _StoragePackage ?? (_StoragePackage = new Package.StoragePackage());

	}
}