using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;
using Package = Mtconnect.DeviceInformationModel.Configurations.SolidModel;
// using Mtconnect;

namespace Mtconnect.DeviceInformationModel.Configurations {
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "1.0.15.3")]
	public class SolidModelPackage : IPackage {
		public IPackage[] Packages => new IPackage[] {
		};

		public IClass[] Classes => new IClass[] {
			SolidModelClass,
			ScaleClass,
		};

	private Package.SolidModelClass _SolidModelClass;
	public Package.SolidModelClass SolidModelClass => _SolidModelClass ?? (_SolidModelClass = new Package.SolidModelClass());
	private Package.ScaleClass _ScaleClass;
	public Package.ScaleClass ScaleClass => _ScaleClass ?? (_ScaleClass = new Package.ScaleClass());
	}
}