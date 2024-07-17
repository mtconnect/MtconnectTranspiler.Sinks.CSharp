using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;
using Package = Mtconnect.Imports.CSVImports;
// using Mtconnect;

namespace Mtconnect.Imports {
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "1.0.15.3")]
	public class CSVImportsPackage : IPackage {
		public IPackage[] Packages => new IPackage[] {
		};

		public IClass[] Classes => new IClass[] {
			PropertyMapClass,
			ImportDescriptorClass,
		};

	private Package.PropertyMapClass _PropertyMapClass;
	public Package.PropertyMapClass PropertyMapClass => _PropertyMapClass ?? (_PropertyMapClass = new Package.PropertyMapClass());
	private Package.ImportDescriptorClass _ImportDescriptorClass;
	public Package.ImportDescriptorClass ImportDescriptorClass => _ImportDescriptorClass ?? (_ImportDescriptorClass = new Package.ImportDescriptorClass());
	}
}