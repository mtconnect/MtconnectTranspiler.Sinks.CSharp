#pragma warning disable CS1574 // XML comment has cref attribute that could not be resolved
#pragma warning disable CS1584 // XML comment has syntactically incorrect cref attribute
#pragma warning disable CS0618 // Type or member is obsolete
using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;
using Package = Mtconnect.Fundamentals.MTConnectProtocol.MTConnectDevicesResponseDocument;

namespace Mtconnect.Fundamentals.MTConnectProtocol
{
	/// <summary>﻿This section provides semantic information for the <see cref="MTConnectDevices">MTConnectDevices</see> entity.<br /><br /><br />
	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Package__EAPK_1812F5DC_90C0_47d9_B731_2E752A6D72A0">model.mtconnect.org</seealso> for more information.
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public class MTConnectDevicesResponseDocumentPackage : IPackage
	{
		/// <summary>Constant value for <see cref="MTConnectDevicesResponseDocumentPackage.ReferenceId" /></summary>
		public const string REFERENCE_ID = "EAPK_1812F5DC_90C0_47d9_B731_2E752A6D72A0";
		/// <summary>Constant value for <see cref="MTConnectDevicesResponseDocumentPackage.HelpUrl" /></summary>
		public const string HELP_URL = "https://model.mtconnect.org/#Package__EAPK_1812F5DC_90C0_47d9_B731_2E752A6D72A0";
		/// <summary>Constant value for <see cref="MTConnectDevicesResponseDocumentPackage.Name" /></summary>
		public const string NAME = "MTConnectDevices Response Document";
		/// <summary>Constant value for <see cref="MTConnectDevicesResponseDocumentPackage.Summary" /></summary>
		public const string SUMMARY = @"&#10;&#10;&#10;This section provides semantic information for the {{block(MTConnectDevices)}} entity.&#10;
";

		/// <inheritdoc />
		public string ReferenceId => REFERENCE_ID;
		
		/// <inheritdoc />
		public string HelpUrl => HELP_URL;
		
		/// <inheritdoc />
		public string Name => NAME;

		/// <inheritdoc />
		public string Summary => SUMMARY;

		/// <inheritdoc />
		public IPackage[] Packages => new IPackage[] {
		};
		
		/// <inheritdoc />
		public IClass[] Classes => new IClass[] {
			MTConnectDevicesClass,
			HeaderClass,
			AssetCountClass,
		};
		
		/// <inheritdoc />
		public IEnum[] Enums => new IEnum[] {
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

	#region Enums
	#endregion
	}
}