
using System;
using System.CodeDom.Compiler;
using Package = Mtconnect.AssetInformationModel.QIF;

using Mtconnect;

namespace Mtconnect.AssetInformationModel {
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "1.0.15.3")]
	public class QIFPackage {


	private Package.QIFDocumentClass _QIFDocument;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.QIFDocumentClass QIFDocument => _QIFDocument ?? (_QIFDocument = new Package.QIFDocumentClass());

	private Package.QIFDocumentWrapperClass _QIFDocumentWrapper;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.QIFDocumentWrapperClass QIFDocumentWrapper => _QIFDocumentWrapper ?? (_QIFDocumentWrapper = new Package.QIFDocumentWrapperClass());
	}
}