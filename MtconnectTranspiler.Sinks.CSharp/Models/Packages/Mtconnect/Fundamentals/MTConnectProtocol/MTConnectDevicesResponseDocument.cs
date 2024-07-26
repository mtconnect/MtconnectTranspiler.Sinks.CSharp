
using System;
using System.CodeDom.Compiler;
using Package = Mtconnect.Fundamentals.MTConnectProtocol.MTConnectDevicesResponseDocument;

using Mtconnect;

namespace Mtconnect.Fundamentals.MTConnectProtocol {
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "1.0.15.3")]
	public class MTConnectDevicesResponseDocumentPackage {


	private Package.MTConnectDevicesClass _MTConnectDevices;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.MTConnectDevicesClass MTConnectDevices => _MTConnectDevices ?? (_MTConnectDevices = new Package.MTConnectDevicesClass());

	private Package.HeaderClass _Header;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.HeaderClass Header => _Header ?? (_Header = new Package.HeaderClass());

	private Package.AssetCountClass _AssetCount;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.AssetCountClass AssetCount => _AssetCount ?? (_AssetCount = new Package.AssetCountClass());
	}
}