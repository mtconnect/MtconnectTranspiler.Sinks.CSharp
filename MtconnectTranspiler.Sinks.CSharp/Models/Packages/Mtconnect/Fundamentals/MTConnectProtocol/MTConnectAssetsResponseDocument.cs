
using System;
using System.CodeDom.Compiler;
using Package = Mtconnect.Fundamentals.MTConnectProtocol.MTConnectAssetsResponseDocument;

using Mtconnect;

namespace Mtconnect.Fundamentals.MTConnectProtocol {
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "1.0.15.3")]
	public class MTConnectAssetsResponseDocumentPackage {


	private Package.MTConnectAssetsClass _MTConnectAssets;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.MTConnectAssetsClass MTConnectAssets => _MTConnectAssets ?? (_MTConnectAssets = new Package.MTConnectAssetsClass());

	private Package.HeaderClass _Header;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.HeaderClass Header => _Header ?? (_Header = new Package.HeaderClass());
	}
}