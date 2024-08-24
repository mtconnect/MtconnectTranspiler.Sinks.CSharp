#pragma warning disable CS1574 // XML comment has cref attribute that could not be resolved
#pragma warning disable CS1584 // XML comment has syntactically incorrect cref attribute
#pragma warning disable CS0618 // Type or member is obsolete
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
		/// <summary>Constant value for <see cref="MTConnectAssetsResponseDocumentPackage.ReferenceId" /></summary>
		public const string REFERENCE_ID = "EAPK_0BE79858_BF36_444b_9C61_811F8D81B62F";
		/// <summary>Constant value for <see cref="MTConnectAssetsResponseDocumentPackage.HelpUrl" /></summary>
		public const string HELP_URL = "https://model.mtconnect.org/#Package__EAPK_0BE79858_BF36_444b_9C61_811F8D81B62F";
		/// <summary>Constant value for <see cref="MTConnectAssetsResponseDocumentPackage.Name" /></summary>
		public const string NAME = "MTConnectAssets Response Document";
		/// <summary>Constant value for <see cref="MTConnectAssetsResponseDocumentPackage.Summary" /></summary>
		public const string SUMMARY = @"&#10;&#10;&#10;This section provides semantic information for the {{block(MTConnectAssets)}} entity.&#10;
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