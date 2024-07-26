
using System;
using System.CodeDom.Compiler;
using Package = Mtconnect.Fundamentals.MTConnectProtocol.MTConnectErrorsResponseDocument;

using Mtconnect;

namespace Mtconnect.Fundamentals.MTConnectProtocol {
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "1.0.15.3")]
	public class MTConnectErrorsResponseDocumentPackage {


	private Package.MTConnectErrorClass _MTConnectError;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.MTConnectErrorClass MTConnectError => _MTConnectError ?? (_MTConnectError = new Package.MTConnectErrorClass());

	private Package.HeaderClass _Header;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.HeaderClass Header => _Header ?? (_Header = new Package.HeaderClass());

	private Package.ErrorClass _Error;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.ErrorClass Error => _Error ?? (_Error = new Package.ErrorClass());
	}
}