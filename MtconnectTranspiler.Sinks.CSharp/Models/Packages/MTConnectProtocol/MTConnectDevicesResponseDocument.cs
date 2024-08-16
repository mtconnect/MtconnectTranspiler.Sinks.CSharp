using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;
using Package = Mtconnect.Fundamentals.MTConnectProtocol.MTConnectDevicesResponseDocument;

namespace Mtconnect.Fundamentals.MTConnectProtocol
{
	/// <summary>
	﻿/// This section provides semantic information for the <see cref="MTConnectDevices">MTConnectDevices</see> entity.<br/><br />

	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Package__EAPK_1812F5DC_90C0_47d9_B731_2E752A6D72A0">model.mtconnect.org</seealso> for more information.
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public class MTConnectDevicesResponseDocumentPackage : IPackage
	{
		/// <inheritdoc />
		public string ReferenceId => "EAPK_1812F5DC_90C0_47d9_B731_2E752A6D72A0";
		
		/// <inheritdoc />
		public string Name => "MTConnectDevices Response Document";

		/// <inheritdoc />
		public string Summary => @"&#10;&#10;&#10;This section provides semantic information for the {{block(MTConnectDevices)}} entity.&#10;
";

		/// <inheritdoc />
		public IPackage[] Packages => new IPackage[] {
		};
		
		/// <inheritdoc />
		public IClass[] Classes => new IClass[] {
			MTConnectDevicesClass,
			HeaderClass,
			AssetCountClass,
		};
		#region Packages
	#endregion

	#region Classes
	private Package.MTConnectDevicesClass _MTConnectDevicesClass;
	/// <summary>
	/// <inheritdoc cref="Package.MTConnectDevicesClass" path="/summary" />
	/// </summary>
	public Package.MTConnectDevicesClass MTConnectDevicesClass => _MTConnectDevicesClass ?? (_MTConnectDevicesClass = new Package.MTConnectDevicesClass());

	private Package.HeaderClass _HeaderClass;
	/// <summary>
	/// <inheritdoc cref="Package.HeaderClass" path="/summary" />
	/// </summary>
	public Package.HeaderClass HeaderClass => _HeaderClass ?? (_HeaderClass = new Package.HeaderClass());

	private Package.AssetCountClass _AssetCountClass;
	/// <summary>
	/// <inheritdoc cref="Package.AssetCountClass" path="/summary" />
	/// </summary>
	public Package.AssetCountClass AssetCountClass => _AssetCountClass ?? (_AssetCountClass = new Package.AssetCountClass());

	#endregion
	}
}