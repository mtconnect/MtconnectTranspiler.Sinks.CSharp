using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;
using Package = Mtconnect.SupportingDocuments;

namespace Mtconnect {
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "1.0.15.3")]
	public class SupportingDocumentsPackage : IPackage {
		public IPackage[] Packages => new IPackage[] {
			CommonDocumentsPackage,
		};

		public IClass[] Classes => new IClass[] {
		};
	private Package.CommonDocumentsPackage _CommonDocumentsPackage;
	public Package.CommonDocumentsPackage CommonDocumentsPackage => _CommonDocumentsPackage ?? (_CommonDocumentsPackage = new Package.CommonDocumentsPackage());

	}
}