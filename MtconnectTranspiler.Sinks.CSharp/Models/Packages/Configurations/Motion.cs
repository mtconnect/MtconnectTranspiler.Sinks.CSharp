using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;
using Package = Mtconnect.DeviceInformationModel.Configurations.Motion;
// using Mtconnect;

namespace Mtconnect.DeviceInformationModel.Configurations {
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "1.0.15.3")]
	public class MotionPackage : IPackage {
		public IPackage[] Packages => new IPackage[] {
		};

		public IClass[] Classes => new IClass[] {
			MotionClass,
			AxisClass,
		};

	private Package.MotionClass _MotionClass;
	public Package.MotionClass MotionClass => _MotionClass ?? (_MotionClass = new Package.MotionClass());
	private Package.AxisClass _AxisClass;
	public Package.AxisClass AxisClass => _AxisClass ?? (_AxisClass = new Package.AxisClass());
	}
}