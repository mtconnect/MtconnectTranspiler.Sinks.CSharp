using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;
using Package = Mtconnect.AgentArchitecture.Rest.Storage;
// using Mtconnect;

namespace Mtconnect.AgentArchitecture.Rest {
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "1.0.15.3")]
	public class StoragePackage : IPackage {
		public IPackage[] Packages => new IPackage[] {
		};

		public IClass[] Classes => new IClass[] {
			CircularBuffferClass,
		};

	private Package.CircularBuffferClass _CircularBuffferClass;
	public Package.CircularBuffferClass CircularBuffferClass => _CircularBuffferClass ?? (_CircularBuffferClass = new Package.CircularBuffferClass());
	}
}