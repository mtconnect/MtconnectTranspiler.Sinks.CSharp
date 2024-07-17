using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;
using Package = Mtconnect.DeviceInformationModel.References;
// using Mtconnect;

namespace Mtconnect.DeviceInformationModel {
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "1.0.15.3")]
	public class ReferencesPackage : IPackage {
		public IPackage[] Packages => new IPackage[] {
		};

		public IClass[] Classes => new IClass[] {
			ReferenceClass,
			DataItemRefClass,
			ComponentRefClass,
		};

	private Package.ReferenceClass _ReferenceClass;
	public Package.ReferenceClass ReferenceClass => _ReferenceClass ?? (_ReferenceClass = new Package.ReferenceClass());
	private Package.DataItemRefClass _DataItemRefClass;
	public Package.DataItemRefClass DataItemRefClass => _DataItemRefClass ?? (_DataItemRefClass = new Package.DataItemRefClass());
	private Package.ComponentRefClass _ComponentRefClass;
	public Package.ComponentRefClass ComponentRefClass => _ComponentRefClass ?? (_ComponentRefClass = new Package.ComponentRefClass());
	}
}