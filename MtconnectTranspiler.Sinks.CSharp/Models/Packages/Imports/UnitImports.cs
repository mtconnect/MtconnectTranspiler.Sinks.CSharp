using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;
using Package = Mtconnect.Imports.UnitImports;

namespace Mtconnect.Imports {
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "1.0.15.3")]
	public class UnitImportsPackage : IPackage {
		public IPackage[] Packages => new IPackage[] {
			BasicUnitsPackage,
		};

		public IClass[] Classes => new IClass[] {
		};
	private Package.BasicUnitsPackage _BasicUnitsPackage;
	public Package.BasicUnitsPackage BasicUnitsPackage => _BasicUnitsPackage ?? (_BasicUnitsPackage = new Package.BasicUnitsPackage());

	}
}