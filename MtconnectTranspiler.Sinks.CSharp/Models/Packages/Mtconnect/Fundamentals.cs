using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;
using Package = Mtconnect.Fundamentals;

namespace Mtconnect {
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "1.0.15.3")]
	public class FundamentalsPackage : IPackage {
		public IPackage[] Packages => new IPackage[] {
			MTConnectProtocolPackage,
		};

		public IClass[] Classes => new IClass[] {
		};
	private Package.MTConnectProtocolPackage _MTConnectProtocolPackage;
	public Package.MTConnectProtocolPackage MTConnectProtocolPackage => _MTConnectProtocolPackage ?? (_MTConnectProtocolPackage = new Package.MTConnectProtocolPackage());

	}
}