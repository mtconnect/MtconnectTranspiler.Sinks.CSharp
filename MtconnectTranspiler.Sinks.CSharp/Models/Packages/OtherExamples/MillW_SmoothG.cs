using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;
using Package = Mtconnect.WIP_BestPracticesWithExamples.OtherExamples.MillW_PER_SmoothG;

namespace Mtconnect.WIP_BestPracticesWithExamples.OtherExamples {
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "1.0.15.3")]
	public class MillW_PER_SmoothGPackage : IPackage {
		public IPackage[] Packages => new IPackage[] {
			RepresentationPackage,
		};

		public IClass[] Classes => new IClass[] {
		};
	private Package.RepresentationPackage _RepresentationPackage;
	public Package.RepresentationPackage RepresentationPackage => _RepresentationPackage ?? (_RepresentationPackage = new Package.RepresentationPackage());

	}
}