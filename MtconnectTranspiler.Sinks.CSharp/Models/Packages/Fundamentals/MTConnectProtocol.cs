#pragma warning disable CS1574 // XML comment has cref attribute that could not be resolved
#pragma warning disable CS1584 // XML comment has syntactically incorrect cref attribute
#pragma warning disable CS0618 // Type or member is obsolete
using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;
using Package = Mtconnect.Fundamentals.MTConnectProtocol;

namespace Mtconnect.Fundamentals
{
	/// <summary>﻿The <i>agent</i> <b>MUST</b> support the <see cref="REST Protocol">REST Protocol</see> and produce <i>XML</i> representations of the information models. <br /><br />All other protocols and representations are optional.<br /><br /><br /><br />
	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Package__EAPK_50B7711E_30AA_4a94_9F73_C74061BA099D">model.mtconnect.org</seealso> for more information.
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public class MTConnectProtocolPackage : IPackage
	{
		/// <summary>Constant value for <see cref="MTConnectProtocolPackage.ReferenceId" /></summary>
		public const string REFERENCE_ID = "EAPK_50B7711E_30AA_4a94_9F73_C74061BA099D";
		/// <summary>Constant value for <see cref="MTConnectProtocolPackage.HelpUrl" /></summary>
		public const string HELP_URL = "https://model.mtconnect.org/#Package__EAPK_50B7711E_30AA_4a94_9F73_C74061BA099D";
		/// <summary>Constant value for <see cref="MTConnectProtocolPackage.Name" /></summary>
		public const string NAME = "MTConnect Protocol";
		/// <summary>Constant value for <see cref="MTConnectProtocolPackage.Summary" /></summary>
		public const string SUMMARY = @"&#10;&#10;&#10;The {{term(agent)}} **MUST** support the {{package(REST Protocol)}} and produce {{term(XML)}} representations of the information models. 

All other protocols and representations are optional.
&#10;
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
			MTConnectAssetsResponseDocumentPackage,
			MTConnectDevicesResponseDocumentPackage,
			MTConnectStreamsResponseDocumentPackage,
			MTConnectErrorsResponseDocumentPackage,
			RESTProtocolPackage,
		};
		
		/// <inheritdoc />
		public IClass[] Classes => new IClass[] {
		};
		
		/// <inheritdoc />
		public IEnum[] Enums => new IEnum[] {
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

	#region Enums
	#endregion
	}
}