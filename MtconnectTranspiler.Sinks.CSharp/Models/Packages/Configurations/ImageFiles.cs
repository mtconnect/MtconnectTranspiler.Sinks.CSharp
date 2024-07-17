using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;
using Package = Mtconnect.DeviceInformationModel.Configurations.ImageFiles;
// using Mtconnect;

namespace Mtconnect.DeviceInformationModel.Configurations {
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "1.0.15.3")]
	public class ImageFilesPackage : IPackage {
		public IPackage[] Packages => new IPackage[] {
		};

		public IClass[] Classes => new IClass[] {
			ImageFileClass,
		};

	private Package.ImageFileClass _ImageFileClass;
	public Package.ImageFileClass ImageFileClass => _ImageFileClass ?? (_ImageFileClass = new Package.ImageFileClass());
	}
}