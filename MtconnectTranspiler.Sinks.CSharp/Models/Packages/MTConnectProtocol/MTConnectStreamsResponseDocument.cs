#pragma warning disable CS1574 // XML comment has cref attribute that could not be resolved
#pragma warning disable CS1584 // XML comment has syntactically incorrect cref attribute
#pragma warning disable CS0618 // Type or member is obsolete
using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;
using Package = Mtconnect.Fundamentals.MTConnectProtocol.MTConnectStreamsResponseDocument;

namespace Mtconnect.Fundamentals.MTConnectProtocol
{
	/// <summary>﻿This section provides semantic information for the <see cref="MTConnectStreams">MTConnectStreams</see> entity.<br /><br /><br />
	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Package__EAPK_E058AC1A_865D_4b99_BBEC_8CC65D67EDEB">model.mtconnect.org</seealso> for more information.
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public class MTConnectStreamsResponseDocumentPackage : IPackage
	{
		/// <summary>Constant value for <see cref="MTConnectStreamsResponseDocumentPackage.ReferenceId" /></summary>
		public const string REFERENCE_ID = "EAPK_E058AC1A_865D_4b99_BBEC_8CC65D67EDEB";
		/// <summary>Constant value for <see cref="MTConnectStreamsResponseDocumentPackage.HelpUrl" /></summary>
		public const string HELP_URL = "https://model.mtconnect.org/#Package__EAPK_E058AC1A_865D_4b99_BBEC_8CC65D67EDEB";
		/// <summary>Constant value for <see cref="MTConnectStreamsResponseDocumentPackage.Name" /></summary>
		public const string NAME = "MTConnectStreams Response Document";
		/// <summary>Constant value for <see cref="MTConnectStreamsResponseDocumentPackage.Summary" /></summary>
		public const string SUMMARY = @"&#10;&#10;&#10;This section provides semantic information for the {{block(MTConnectStreams)}} entity.&#10;
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
			MTConnectStreamsClass,
			HeaderClass,
		};
		
		/// <inheritdoc />
		public IEnum[] Enums => new IEnum[] {
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

	#region Enums
	#endregion
	}
}