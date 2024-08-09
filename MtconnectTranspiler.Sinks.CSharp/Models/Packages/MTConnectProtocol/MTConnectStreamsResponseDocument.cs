using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;
using Package = Mtconnect.Fundamentals.MTConnectProtocol.MTConnectStreamsResponseDocument;

namespace Mtconnect.Fundamentals.MTConnectProtocol
{
	/// <summary>
	/// This section provides semantic information for the <see cref="MTConnectStreams">MTConnectStreams</see> entity.
	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Package__EAPK_E058AC1A_865D_4b99_BBEC_8CC65D67EDEB">model.mtconnect.org</seealso> for more information.
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.3.0.0")]
	public class MTConnectStreamsResponseDocumentPackage : IPackage
	{
		/// <inheritdoc />
		public string ReferenceId => "EAPK_E058AC1A_865D_4b99_BBEC_8CC65D67EDEB";
		
		/// <inheritdoc />
		public string Name => "MTConnectStreams Response Document";

		/// <inheritdoc />
		public string Summary => @"/// This section provides semantic information for the <see cref=""MTConnectStreams"">MTConnectStreams</see> entity.";

		/// <inheritdoc />
		public IPackage[] Packages => new IPackage[] {
		};
		
		/// <inheritdoc />
		public IClass[] Classes => new IClass[] {
			MTConnectStreamsClass,
			HeaderClass,
		};
		#region Packages
	#endregion

	#region Classes
	private Package.MTConnectStreamsClass _MTConnectStreamsClass;
	/// <summary>
	/// <inheritdoc cref="Package.MTConnectStreamsClass" path="/summary" />
	/// </summary>
	public Package.MTConnectStreamsClass MTConnectStreamsClass => _MTConnectStreamsClass ?? (_MTConnectStreamsClass = new Package.MTConnectStreamsClass());

	private Package.HeaderClass _HeaderClass;
	/// <summary>
	/// <inheritdoc cref="Package.HeaderClass" path="/summary" />
	/// </summary>
	public Package.HeaderClass HeaderClass => _HeaderClass ?? (_HeaderClass = new Package.HeaderClass());

	#endregion
	}
}