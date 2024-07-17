using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;
using Package = Mtconnect.DeviceInformationModel.Compositions;
// using Mtconnect;

namespace Mtconnect.DeviceInformationModel {
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "1.0.15.3")]
	public class CompositionsPackage : IPackage {
		public IPackage[] Packages => new IPackage[] {
		};

		public IClass[] Classes => new IClass[] {
			CompositionClass,
		};

	private Package.CompositionClass _CompositionClass;
	public Package.CompositionClass CompositionClass => _CompositionClass ?? (_CompositionClass = new Package.CompositionClass());
	}
}