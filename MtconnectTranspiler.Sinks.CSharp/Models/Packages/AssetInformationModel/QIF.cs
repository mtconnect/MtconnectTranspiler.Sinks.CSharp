using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;
using Package = Mtconnect.AssetInformationModel.QIF;

namespace Mtconnect.AssetInformationModel
{
	/// <summary>
	﻿/// This section provides semantic information for the <see cref="QIFDocumentWrapper">QIFDocumentWrapper</see> model.<br /><br />![QIFDocumentWrapper](figures/QIFDocumentWrapper.png "QIFDocumentWrapper"){: width="0.8"}<br /><br />> Note: See <see cref="QIFDocumentWrapper Schema Diagrams">QIFDocumentWrapper Schema Diagrams</see> for XML schema.<br/><br />QIF Asset Information Model<br/>The <i>QIF</i> is an American National Standards Institute (ANSI) accredited standard developed by the Digital Metrology Standards Consortium (DMSC) standards development organization. The DMSC is an A-liaison to the International Standards Organization (ISO) Technical Committee (TC) 184. <i>QIF</i> addresses the needs of the metrology community to have a semantic information model for the exchange of metrology data throughout the verification lifecycle from product design to execution, analysis, and reporting.<br /><br />The MTConnect <i>QIF</i> <i>Asset Information Model</i> provides a wrapper around a <i>QIF</i> document (i.e., a dataset conforming to the QIF Information model) in its native XML representation. The MTConnect standard does not alter or extend the <i>QIF</i> standard and regards the <i>QIF</i> standard as a passthrough.<br /><br />Information about the <i>QIF</i> standards is at the following location: https://qifstandards.org<br/><br/><br />

	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Package___19_0_3_68e0225_1622119427718_488449_1678">model.mtconnect.org</seealso> for more information.
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public class QIFPackage : IPackage
	{
		/// <inheritdoc />
		public string ReferenceId => "_19_0_3_68e0225_1622119427718_488449_1678";
		
		/// <inheritdoc />
		public string Name => "QIF";

		/// <inheritdoc />
		public string Summary => @"&#10;&#10;&#10;This section provides semantic information for the {{block(QIFDocumentWrapper)}} model.

![QIFDocumentWrapper](figures/QIFDocumentWrapper.png ""QIFDocumentWrapper""){: width=""0.8""}

> Note: See {{sect(QIFDocumentWrapper Schema Diagrams)}} for XML schema.&#10;
&#10;&#10;&#10;QIF Asset Information Model&#10;&#10;&#10;&#10;The {{term(QIF)}} is an American National Standards Institute (ANSI) accredited standard developed by the Digital Metrology Standards Consortium (DMSC) standards development organization. The DMSC is an A-liaison to the International Standards Organization (ISO) Technical Committee (TC) 184. {{term(QIF)}} addresses the needs of the metrology community to have a semantic information model for the exchange of metrology data throughout the verification lifecycle from product design to execution, analysis, and reporting.

The MTConnect {{term(QIF)}} {{term(Asset Information Model)}} provides a wrapper around a {{term(QIF)}} document (i.e., a dataset conforming to the QIF Information model) in its native XML representation. The MTConnect standard does not alter or extend the {{term(QIF)}} standard and regards the {{term(QIF)}} standard as a passthrough.

Information about the {{term(QIF)}} standards is at the following location: https://qifstandards.org&#10;
";

		/// <inheritdoc />
		public IPackage[] Packages => new IPackage[] {
		};
		
		/// <inheritdoc />
		public IClass[] Classes => new IClass[] {
			QIFDocumentClass,
			QIFDocumentWrapperClass,
		};
		#region Packages
	#endregion

	#region Classes
	private Package.QIFDocumentClass _QIFDocumentClass;
	/// <summary>
	/// <inheritdoc cref="Package.QIFDocumentClass" path="/summary" />
	/// </summary>
	public Package.QIFDocumentClass QIFDocumentClass => _QIFDocumentClass ?? (_QIFDocumentClass = new Package.QIFDocumentClass());

	private Package.QIFDocumentWrapperClass _QIFDocumentWrapperClass;
	/// <summary>
	/// <inheritdoc cref="Package.QIFDocumentWrapperClass" path="/summary" />
	/// </summary>
	public Package.QIFDocumentWrapperClass QIFDocumentWrapperClass => _QIFDocumentWrapperClass ?? (_QIFDocumentWrapperClass = new Package.QIFDocumentWrapperClass());

	#endregion
	}
}