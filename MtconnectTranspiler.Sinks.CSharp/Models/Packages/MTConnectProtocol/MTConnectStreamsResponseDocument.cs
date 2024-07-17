using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;
using Package = Mtconnect.Fundamentals.MTConnectProtocol.MTConnectStreamsResponseDocument;
// using Mtconnect;

namespace Mtconnect.Fundamentals.MTConnectProtocol {
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "1.0.15.3")]
	public class MTConnectStreamsResponseDocumentPackage : IPackage {
		public IPackage[] Packages => new IPackage[] {
		};

		public IClass[] Classes => new IClass[] {
			MTConnectStreamsClass,
			HeaderClass,
		};

	private Package.MTConnectStreamsClass _MTConnectStreamsClass;
	public Package.MTConnectStreamsClass MTConnectStreamsClass => _MTConnectStreamsClass ?? (_MTConnectStreamsClass = new Package.MTConnectStreamsClass());
	private Package.HeaderClass _HeaderClass;
	public Package.HeaderClass HeaderClass => _HeaderClass ?? (_HeaderClass = new Package.HeaderClass());
	}
}