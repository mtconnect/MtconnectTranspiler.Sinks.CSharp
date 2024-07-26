
using System;
using System.CodeDom.Compiler;
using Package = Mtconnect.DeviceInformationModel.Configurations.Motion;

using Mtconnect;

namespace Mtconnect.DeviceInformationModel.Configurations {
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "1.0.15.3")]
	public class MotionPackage {


	private Package.MotionClass _Motion;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.MotionClass Motion => _Motion ?? (_Motion = new Package.MotionClass());

	private Package.AxisClass _Axis;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.AxisClass Axis => _Axis ?? (_Axis = new Package.AxisClass());
	}
}