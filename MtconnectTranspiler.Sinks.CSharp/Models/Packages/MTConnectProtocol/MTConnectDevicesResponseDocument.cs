using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;
using Package = Mtconnect.Fundamentals.MTConnectProtocol.MTConnectDevicesResponseDocument;
// using Mtconnect;

namespace Mtconnect.Fundamentals.MTConnectProtocol {
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "1.0.15.3")]
	public class MTConnectDevicesResponseDocumentPackage : IPackage {
		public IPackage[] Packages => new IPackage[] {
		};

		public IClass[] Classes => new IClass[] {
			MTConnectDevicesClass,
			HeaderClass,
			AssetCountClass,
		};

	private Package.MTConnectDevicesClass _MTConnectDevicesClass;
	public Package.MTConnectDevicesClass MTConnectDevicesClass => _MTConnectDevicesClass ?? (_MTConnectDevicesClass = new Package.MTConnectDevicesClass());
	private Package.HeaderClass _HeaderClass;
	public Package.HeaderClass HeaderClass => _HeaderClass ?? (_HeaderClass = new Package.HeaderClass());
	private Package.AssetCountClass _AssetCountClass;
	public Package.AssetCountClass AssetCountClass => _AssetCountClass ?? (_AssetCountClass = new Package.AssetCountClass());
	}
}