#pragma warning disable CS1574 // XML comment has cref attribute that could not be resolved
#pragma warning disable CS1584 // XML comment has syntactically incorrect cref attribute
using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;
using Package = Mtconnect.Fundamentals.MTConnectProtocol.MTConnectErrorsResponseDocument;

namespace Mtconnect.Fundamentals.MTConnectProtocol
{
	/// <summary>﻿This section provides semantic information for the <see cref="MTConnectErrors">MTConnectErrors</see> entity.<br /><br /><br />Error Information Model<br /><br />The <i>Error Information Model</i> establishes the rules and terminology that describes the <i>response document</i> returned by an <i>agent</i> when it encounters an error while interpreting a <i>request</i> for information from a client software application or when an <i>agent</i> experiences an error while publishing the <i>response</i> to a <i>request</i> for information.      <br /><br />An <i>agent</i> provides the information regarding errors encountered when processing a <i>request</i> for information by publishing an <i>MTConnectErrors Response Document</i> to the client software application that made the <i>request</i> for information.<br /><br /><br /><br /><br />
	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Package___19_0_3_91b028d_1579560529522_593444_6515">model.mtconnect.org</seealso> for more information.
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public class MTConnectErrorsResponseDocumentPackage : IPackage
	{
		/// <inheritdoc />
		public string ReferenceId => "_19_0_3_91b028d_1579560529522_593444_6515";
		
		/// <inheritdoc />
		public string Name => "MTConnectErrors Response Document";

		/// <inheritdoc />
		public string Summary => @"&#10;&#10;&#10;This section provides semantic information for the {{block(MTConnectErrors)}} entity.&#10;
&#10;&#10;&#10;Error Information Model&#10;&#10;&#10;&#10;The {{term(Error Information Model)}} establishes the rules and terminology that describes the {{term(response document)}} returned by an {{term(agent)}} when it encounters an error while interpreting a {{term(request)}} for information from a client software application or when an {{term(agent)}} experiences an error while publishing the {{term(response)}} to a {{term(request)}} for information.      

An {{term(agent)}} provides the information regarding errors encountered when processing a {{term(request)}} for information by publishing an {{term(MTConnectErrors Response Document)}} to the client software application that made the {{term(request)}} for information.&#10;
";

		/// <inheritdoc />
		public IPackage[] Packages => new IPackage[] {
		};
		
		/// <inheritdoc />
		public IClass[] Classes => new IClass[] {
			MTConnectErrorClass,
			HeaderClass,
			ErrorClass,
		};
		
		/// <inheritdoc />
		public IEnum[] Enums => new IEnum[] {
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

	#region Enums
	#endregion
	}
}