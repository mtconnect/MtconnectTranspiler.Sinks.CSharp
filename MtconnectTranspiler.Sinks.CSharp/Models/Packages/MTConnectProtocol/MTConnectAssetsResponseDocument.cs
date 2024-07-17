using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;
using Package = Mtconnect.Fundamentals.MTConnectProtocol.MTConnectAssetsResponseDocument;
// using Mtconnect;

namespace Mtconnect.Fundamentals.MTConnectProtocol {
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "1.0.15.3")]
	public class MTConnectAssetsResponseDocumentPackage : IPackage {
		public IPackage[] Packages => new IPackage[] {
		};

		public IClass[] Classes => new IClass[] {
			MTConnectAssetsClass,
			HeaderClass,
		};

	private Package.MTConnectAssetsClass _MTConnectAssetsClass;
	public Package.MTConnectAssetsClass MTConnectAssetsClass => _MTConnectAssetsClass ?? (_MTConnectAssetsClass = new Package.MTConnectAssetsClass());
	private Package.HeaderClass _HeaderClass;
	public Package.HeaderClass HeaderClass => _HeaderClass ?? (_HeaderClass = new Package.HeaderClass());
	}
}