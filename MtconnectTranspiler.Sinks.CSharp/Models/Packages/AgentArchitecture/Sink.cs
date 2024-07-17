using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;
using Package = Mtconnect.AgentArchitecture.Sink;
// using Mtconnect;

namespace Mtconnect.AgentArchitecture {
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "1.0.15.3")]
	public class SinkPackage : IPackage {
		public IPackage[] Packages => new IPackage[] {
		};

		public IClass[] Classes => new IClass[] {
			RestSinkGeneralization,
		};

	private Package.RestSinkGeneralization _RestSinkGeneralization;
	public Package.RestSinkGeneralization RestSinkGeneralization => _RestSinkGeneralization ?? (_RestSinkGeneralization = new Package.RestSinkGeneralization());
	}
}