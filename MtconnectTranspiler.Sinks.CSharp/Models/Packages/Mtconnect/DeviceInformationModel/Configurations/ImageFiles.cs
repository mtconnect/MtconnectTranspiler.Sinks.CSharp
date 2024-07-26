
using System;
using System.CodeDom.Compiler;
using Package = Mtconnect.DeviceInformationModel.Configurations.ImageFiles;

using Mtconnect;

namespace Mtconnect.DeviceInformationModel.Configurations {
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "1.0.15.3")]
	public class ImageFilesPackage {


	private Package.ImageFileClass _ImageFile;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.ImageFileClass ImageFile => _ImageFile ?? (_ImageFile = new Package.ImageFileClass());
	}
}