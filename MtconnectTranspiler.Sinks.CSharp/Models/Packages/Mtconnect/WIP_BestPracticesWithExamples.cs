using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;
using Package = Mtconnect.WIP_BestPracticesWithExamples;

namespace Mtconnect {
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "1.0.15.3")]
	public class WIP_BestPracticesWithExamplesPackage : IPackage {
		public IPackage[] Packages => new IPackage[] {
			MachineToolPackage,
			OtherExamplesPackage,
			ThermalPackage,
			RobotArmsPackage,
			AdditivePackage,
		};

		public IClass[] Classes => new IClass[] {
		};
	private Package.MachineToolPackage _MachineToolPackage;
	public Package.MachineToolPackage MachineToolPackage => _MachineToolPackage ?? (_MachineToolPackage = new Package.MachineToolPackage());
	private Package.OtherExamplesPackage _OtherExamplesPackage;
	public Package.OtherExamplesPackage OtherExamplesPackage => _OtherExamplesPackage ?? (_OtherExamplesPackage = new Package.OtherExamplesPackage());
	private Package.ThermalPackage _ThermalPackage;
	public Package.ThermalPackage ThermalPackage => _ThermalPackage ?? (_ThermalPackage = new Package.ThermalPackage());
	private Package.RobotArmsPackage _RobotArmsPackage;
	public Package.RobotArmsPackage RobotArmsPackage => _RobotArmsPackage ?? (_RobotArmsPackage = new Package.RobotArmsPackage());
	private Package.AdditivePackage _AdditivePackage;
	public Package.AdditivePackage AdditivePackage => _AdditivePackage ?? (_AdditivePackage = new Package.AdditivePackage());

	}
}