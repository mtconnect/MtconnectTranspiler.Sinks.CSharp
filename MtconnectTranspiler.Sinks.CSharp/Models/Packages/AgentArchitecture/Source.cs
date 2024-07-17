using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;
using Package = Mtconnect.AgentArchitecture.Source;
// using Mtconnect;

namespace Mtconnect.AgentArchitecture {
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "1.0.15.3")]
	public class SourcePackage : IPackage {
		public IPackage[] Packages => new IPackage[] {
		};

		public IClass[] Classes => new IClass[] {
			MQTTDataSourceGeneralization,
			AdapterDataSourceGeneralization,
		};

	private Package.MQTTDataSourceGeneralization _MQTTDataSourceGeneralization;
	public Package.MQTTDataSourceGeneralization MQTTDataSourceGeneralization => _MQTTDataSourceGeneralization ?? (_MQTTDataSourceGeneralization = new Package.MQTTDataSourceGeneralization());
	private Package.AdapterDataSourceGeneralization _AdapterDataSourceGeneralization;
	public Package.AdapterDataSourceGeneralization AdapterDataSourceGeneralization => _AdapterDataSourceGeneralization ?? (_AdapterDataSourceGeneralization = new Package.AdapterDataSourceGeneralization());
	}
}