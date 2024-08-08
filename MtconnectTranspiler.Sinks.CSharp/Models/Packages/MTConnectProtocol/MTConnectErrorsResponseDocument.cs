using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;
using Package = Mtconnect.Fundamentals.MTConnectProtocol.MTConnectErrorsResponseDocument;
// using Mtconnect;

namespace Mtconnect.Fundamentals.MTConnectProtocol
{
	/// <summary>
	/// This section provides semantic information for the <see cref="MTConnectErrors">MTConnectErrors</see> entity./// Error Information Model
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.3.0.0")]
	public class MTConnectErrorsResponseDocumentPackage : IPackage
	{
		/// <inheritdoc />
		public string ReferenceId => "_19_0_3_91b028d_1579560529522_593444_6515";
		
		/// <inheritdoc />
		public string Name => "MTConnectErrorsResponseDocument";

		/// <inheritdoc />
		public string Summary => @"/// This section provides semantic information for the <see cref=""MTConnectErrors"">MTConnectErrors</see> entity./// Error Information Model";

		/// <inheritdoc />
		public IPackage[] Packages => new IPackage[] {
		};
		
		/// <inheritdoc />
		public IClass[] Classes => new IClass[] {
			MTConnectErrorClass,
			HeaderClass,
			ErrorClass,
		};
		#region Packages
	#endregion

	#region Classes
	private Package.MTConnectErrorClass _MTConnectErrorClass;
	/// <summary>
	/// <inheritdoc cref="Package.MTConnectErrorClass" path="/summary" />
	/// </summary>
	public Package.MTConnectErrorClass MTConnectErrorClass => _MTConnectErrorClass ?? (_MTConnectErrorClass = new Package.MTConnectErrorClass());

	private Package.HeaderClass _HeaderClass;
	/// <summary>
	/// <inheritdoc cref="Package.HeaderClass" path="/summary" />
	/// </summary>
	public Package.HeaderClass HeaderClass => _HeaderClass ?? (_HeaderClass = new Package.HeaderClass());

	private Package.ErrorClass _ErrorClass;
	/// <summary>
	/// <inheritdoc cref="Package.ErrorClass" path="/summary" />
	/// </summary>
	public Package.ErrorClass ErrorClass => _ErrorClass ?? (_ErrorClass = new Package.ErrorClass());

	#endregion
	}
}