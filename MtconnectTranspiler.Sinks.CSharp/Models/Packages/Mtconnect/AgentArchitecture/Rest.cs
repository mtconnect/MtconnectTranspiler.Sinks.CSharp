
using System;
using System.CodeDom.Compiler;
using Package = Mtconnect.AgentArchitecture.Rest;


namespace Mtconnect.AgentArchitecture {
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "1.0.15.3")]
	public class RestPackage {

	private Package.StoragePackage _StoragePackage;
	public Package.StoragePackage StoragePackage => _StoragePackage ?? (_StoragePackage = new Package.StoragePackage());

	}
}