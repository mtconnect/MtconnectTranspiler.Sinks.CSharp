
using System;
using System.CodeDom.Compiler;
using Package = Mtconnect.DeviceInformationModel.Configurations.SolidModel;

using Mtconnect;

namespace Mtconnect.DeviceInformationModel.Configurations {
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "1.0.15.3")]
	public class SolidModelPackage {


	private Package.SolidModelClass _SolidModel;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.SolidModelClass SolidModel => _SolidModel ?? (_SolidModel = new Package.SolidModelClass());

	private Package.ScaleClass _Scale;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.ScaleClass Scale => _Scale ?? (_Scale = new Package.ScaleClass());
	}
}