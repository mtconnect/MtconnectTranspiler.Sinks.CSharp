using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;
using Package = Mtconnect.DeviceInformationModel.Components;
// using Mtconnect;

namespace Mtconnect.DeviceInformationModel {
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "1.0.15.3")]
	public class ComponentsPackage : IPackage {
		public IPackage[] Packages => new IPackage[] {
			ComponentTypesPackage,
			DevicesPackage,
		};

		public IClass[] Classes => new IClass[] {
			ComponentGeneralization,
			DescriptionClass,
		};
	private Package.ComponentTypesPackage _ComponentTypesPackage;
	public Package.ComponentTypesPackage ComponentTypesPackage => _ComponentTypesPackage ?? (_ComponentTypesPackage = new Package.ComponentTypesPackage());
	private Package.DevicesPackage _DevicesPackage;
	public Package.DevicesPackage DevicesPackage => _DevicesPackage ?? (_DevicesPackage = new Package.DevicesPackage());

	private Package.ComponentGeneralization _ComponentGeneralization;
	public Package.ComponentGeneralization ComponentGeneralization => _ComponentGeneralization ?? (_ComponentGeneralization = new Package.ComponentGeneralization());
	private Package.DescriptionClass _DescriptionClass;
	public Package.DescriptionClass DescriptionClass => _DescriptionClass ?? (_DescriptionClass = new Package.DescriptionClass());
	}
}