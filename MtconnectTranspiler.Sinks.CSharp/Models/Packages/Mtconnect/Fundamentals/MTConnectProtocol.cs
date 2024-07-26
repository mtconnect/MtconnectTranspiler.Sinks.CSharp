
using System;
using System.CodeDom.Compiler;
using Package = Mtconnect.Fundamentals.MTConnectProtocol;


namespace Mtconnect.Fundamentals {
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "1.0.15.3")]
	public class MTConnectProtocolPackage {

	private Package.MTConnectAssetsResponseDocumentPackage _MTConnectAssetsResponseDocumentPackage;
	public Package.MTConnectAssetsResponseDocumentPackage MTConnectAssetsResponseDocumentPackage => _MTConnectAssetsResponseDocumentPackage ?? (_MTConnectAssetsResponseDocumentPackage = new Package.MTConnectAssetsResponseDocumentPackage());

	private Package.MTConnectDevicesResponseDocumentPackage _MTConnectDevicesResponseDocumentPackage;
	public Package.MTConnectDevicesResponseDocumentPackage MTConnectDevicesResponseDocumentPackage => _MTConnectDevicesResponseDocumentPackage ?? (_MTConnectDevicesResponseDocumentPackage = new Package.MTConnectDevicesResponseDocumentPackage());

	private Package.MTConnectStreamsResponseDocumentPackage _MTConnectStreamsResponseDocumentPackage;
	public Package.MTConnectStreamsResponseDocumentPackage MTConnectStreamsResponseDocumentPackage => _MTConnectStreamsResponseDocumentPackage ?? (_MTConnectStreamsResponseDocumentPackage = new Package.MTConnectStreamsResponseDocumentPackage());

	private Package.MTConnectErrorsResponseDocumentPackage _MTConnectErrorsResponseDocumentPackage;
	public Package.MTConnectErrorsResponseDocumentPackage MTConnectErrorsResponseDocumentPackage => _MTConnectErrorsResponseDocumentPackage ?? (_MTConnectErrorsResponseDocumentPackage = new Package.MTConnectErrorsResponseDocumentPackage());

	private Package.RESTProtocolPackage _RESTProtocolPackage;
	public Package.RESTProtocolPackage RESTProtocolPackage => _RESTProtocolPackage ?? (_RESTProtocolPackage = new Package.RESTProtocolPackage());

	}
}