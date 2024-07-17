using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;
using Package = Mtconnect.Imports;

namespace Mtconnect {
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "1.0.15.3")]
	public class ImportsPackage : IPackage {
		public IPackage[] Packages => new IPackage[] {
			CSVImportsPackage,
			UnitImportsPackage,
		};

		public IClass[] Classes => new IClass[] {
		};
	private Package.CSVImportsPackage _CSVImportsPackage;
	public Package.CSVImportsPackage CSVImportsPackage => _CSVImportsPackage ?? (_CSVImportsPackage = new Package.CSVImportsPackage());
	private Package.UnitImportsPackage _UnitImportsPackage;
	public Package.UnitImportsPackage UnitImportsPackage => _UnitImportsPackage ?? (_UnitImportsPackage = new Package.UnitImportsPackage());

	}
}