using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;
using Package = Mtconnect.Fundamentals.MTConnectProtocol;

namespace Mtconnect.Fundamentals
{
	/// <summary>
	/// The <i>agent</i> <b>MUST</b> support the <see cref="REST Protocol">REST Protocol</see> and produce <i>XML</i> representations of the information models.   All other protocols and representations are optional. 
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.3.0.0")]
	public class MTConnectProtocolPackage : IPackage
	{
		/// <inheritdoc />
		public string ReferenceId => "EAPK_50B7711E_30AA_4a94_9F73_C74061BA099D";
		
		/// <inheritdoc />
		public string Name => "MTConnectProtocol";

		/// <inheritdoc />
		public string Summary => @"/// The <i>agent</i> <b>MUST</b> support the <see cref=""REST Protocol"">REST Protocol</see> and produce <i>XML</i> representations of the information models.   All other protocols and representations are optional. ";

		/// <inheritdoc />
		public IPackage[] Packages => new IPackage[] {
			MTConnectAssetsResponseDocumentPackage,
			MTConnectDevicesResponseDocumentPackage,
			MTConnectStreamsResponseDocumentPackage,
			MTConnectErrorsResponseDocumentPackage,
			RESTProtocolPackage,
		};
		
		/// <inheritdoc />
		public IClass[] Classes => new IClass[] {
		};
		#region Packages
	private Package.MTConnectAssetsResponseDocumentPackage _MTConnectAssetsResponseDocumentPackage;
	/// <summary>
	/// <inheritdoc cref="Package.MTConnectAssetsResponseDocumentPackage" path="/summary" />
	/// </summary>
	public Package.MTConnectAssetsResponseDocumentPackage MTConnectAssetsResponseDocumentPackage => _MTConnectAssetsResponseDocumentPackage ?? (_MTConnectAssetsResponseDocumentPackage = new Package.MTConnectAssetsResponseDocumentPackage());

	private Package.MTConnectDevicesResponseDocumentPackage _MTConnectDevicesResponseDocumentPackage;
	/// <summary>
	/// <inheritdoc cref="Package.MTConnectDevicesResponseDocumentPackage" path="/summary" />
	/// </summary>
	public Package.MTConnectDevicesResponseDocumentPackage MTConnectDevicesResponseDocumentPackage => _MTConnectDevicesResponseDocumentPackage ?? (_MTConnectDevicesResponseDocumentPackage = new Package.MTConnectDevicesResponseDocumentPackage());

	private Package.MTConnectStreamsResponseDocumentPackage _MTConnectStreamsResponseDocumentPackage;
	/// <summary>
	/// <inheritdoc cref="Package.MTConnectStreamsResponseDocumentPackage" path="/summary" />
	/// </summary>
	public Package.MTConnectStreamsResponseDocumentPackage MTConnectStreamsResponseDocumentPackage => _MTConnectStreamsResponseDocumentPackage ?? (_MTConnectStreamsResponseDocumentPackage = new Package.MTConnectStreamsResponseDocumentPackage());

	private Package.MTConnectErrorsResponseDocumentPackage _MTConnectErrorsResponseDocumentPackage;
	/// <summary>
	/// <inheritdoc cref="Package.MTConnectErrorsResponseDocumentPackage" path="/summary" />
	/// </summary>
	public Package.MTConnectErrorsResponseDocumentPackage MTConnectErrorsResponseDocumentPackage => _MTConnectErrorsResponseDocumentPackage ?? (_MTConnectErrorsResponseDocumentPackage = new Package.MTConnectErrorsResponseDocumentPackage());

	private Package.RESTProtocolPackage _RESTProtocolPackage;
	/// <summary>
	/// <inheritdoc cref="Package.RESTProtocolPackage" path="/summary" />
	/// </summary>
	public Package.RESTProtocolPackage RESTProtocolPackage => _RESTProtocolPackage ?? (_RESTProtocolPackage = new Package.RESTProtocolPackage());

	#endregion

	#region Classes
	#endregion
	}
}