
using System;
using System.CodeDom.Compiler;
using Package = Mtconnect.Fundamentals.MTConnectProtocol.MTConnectStreamsResponseDocument;

using Mtconnect;

namespace Mtconnect.Fundamentals.MTConnectProtocol {
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "1.0.15.3")]
	public class MTConnectStreamsResponseDocumentPackage {


	private Package.MTConnectStreamsClass _MTConnectStreams;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.MTConnectStreamsClass MTConnectStreams => _MTConnectStreams ?? (_MTConnectStreams = new Package.MTConnectStreamsClass());

	private Package.HeaderClass _Header;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.HeaderClass Header => _Header ?? (_Header = new Package.HeaderClass());
	}
}