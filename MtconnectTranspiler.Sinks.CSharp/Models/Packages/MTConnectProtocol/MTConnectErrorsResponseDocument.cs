using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;
using Package = Mtconnect.Fundamentals.MTConnectProtocol.MTConnectErrorsResponseDocument;
// using Mtconnect;

namespace Mtconnect.Fundamentals.MTConnectProtocol {
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "1.0.15.3")]
	public class MTConnectErrorsResponseDocumentPackage : IPackage {
		public IPackage[] Packages => new IPackage[] {
		};

		public IClass[] Classes => new IClass[] {
			MTConnectErrorClass,
			HeaderClass,
			ErrorClass,
		};

	private Package.MTConnectErrorClass _MTConnectErrorClass;
	public Package.MTConnectErrorClass MTConnectErrorClass => _MTConnectErrorClass ?? (_MTConnectErrorClass = new Package.MTConnectErrorClass());
	private Package.HeaderClass _HeaderClass;
	public Package.HeaderClass HeaderClass => _HeaderClass ?? (_HeaderClass = new Package.HeaderClass());
	private Package.ErrorClass _ErrorClass;
	public Package.ErrorClass ErrorClass => _ErrorClass ?? (_ErrorClass = new Package.ErrorClass());
	}
}