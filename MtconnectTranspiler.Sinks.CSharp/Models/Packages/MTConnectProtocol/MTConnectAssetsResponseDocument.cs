#pragma warning disable CS1574 // XML comment has cref attribute that could not be resolved
#pragma warning disable CS1584 // XML comment has syntactically incorrect cref attribute
using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;
using Package = Mtconnect.Fundamentals.MTConnectProtocol.MTConnectAssetsResponseDocument;

namespace Mtconnect.Fundamentals.MTConnectProtocol
{
	/// <summary>﻿This section provides semantic information for the <see cref="MTConnectAssets">MTConnectAssets</see> entity.<br /><br /><br />
	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Package__EAPK_0BE79858_BF36_444b_9C61_811F8D81B62F">model.mtconnect.org</seealso> for more information.
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public class MTConnectAssetsResponseDocumentPackage : IPackage
	{
		/// <inheritdoc />
		public string ReferenceId => "EAPK_0BE79858_BF36_444b_9C61_811F8D81B62F";
		
		/// <inheritdoc />
		public string Name => "MTConnectAssets Response Document";

		/// <inheritdoc />
		public string Summary => @"&#10;&#10;&#10;This section provides semantic information for the {{block(MTConnectAssets)}} entity.&#10;
";

		/// <inheritdoc />
		public IPackage[] Packages => new IPackage[] {
		};
		
		/// <inheritdoc />
		public IClass[] Classes => new IClass[] {
			MTConnectAssetsClass,
			HeaderClass,
		};
		
		/// <inheritdoc />
		public IEnum[] Enums => new IEnum[] {
		};

		#region Packages
	#endregion

	#region Classes
	private Package.MTConnectAssetsClass _MTConnectAssetsClass;
	/// <summary>
	/// <inheritdoc cref="Package.MTConnectAssetsClass" path="/summary" />
	/// </summary>
	public Package.MTConnectAssetsClass MTConnectAssetsClass => _MTConnectAssetsClass ?? (_MTConnectAssetsClass = new Package.MTConnectAssetsClass());

	private Package.HeaderClass _HeaderClass;
	/// <summary>
	/// <inheritdoc cref="Package.HeaderClass" path="/summary" />
	/// </summary>
	public Package.HeaderClass HeaderClass => _HeaderClass ?? (_HeaderClass = new Package.HeaderClass());

	#endregion

	#region Enums
	#endregion
	}
}