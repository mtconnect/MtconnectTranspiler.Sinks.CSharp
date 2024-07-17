using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;
using Package = Mtconnect.AssetInformationModel.QIF;
// using Mtconnect;

namespace Mtconnect.AssetInformationModel {
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "1.0.15.3")]
	public class QIFPackage : IPackage {
		public IPackage[] Packages => new IPackage[] {
		};

		public IClass[] Classes => new IClass[] {
			QIFDocumentClass,
			QIFDocumentWrapperClass,
		};

	private Package.QIFDocumentClass _QIFDocumentClass;
	public Package.QIFDocumentClass QIFDocumentClass => _QIFDocumentClass ?? (_QIFDocumentClass = new Package.QIFDocumentClass());
	private Package.QIFDocumentWrapperClass _QIFDocumentWrapperClass;
	public Package.QIFDocumentWrapperClass QIFDocumentWrapperClass => _QIFDocumentWrapperClass ?? (_QIFDocumentWrapperClass = new Package.QIFDocumentWrapperClass());
	}
}