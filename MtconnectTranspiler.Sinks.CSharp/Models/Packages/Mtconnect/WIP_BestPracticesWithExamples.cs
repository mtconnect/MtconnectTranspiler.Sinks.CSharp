using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;
using Package = Mtconnect.WIP_BestPracticesWithExamples;

namespace Mtconnect
{
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.3.0.0")]
	public class WIP_BestPracticesWithExamplesPackage : IPackage
	{
		/// <inheritdoc />
		public string ReferenceId => "_19_0_3_68e0225_1620229279383_649426_1067";
		
		/// <inheritdoc />
		public string Name => "WIP: Best Practices with Examples";

		/// <inheritdoc />
		public string Summary => @"";

		/// <inheritdoc />
		public IPackage[] Packages => new IPackage[] {
			MachineToolPackage,
			OtherExamplesPackage,
			ThermalPackage,
			RobotArmsPackage,
			AdditivePackage,
		};
		
		/// <inheritdoc />
		public IClass[] Classes => new IClass[] {
		};
		#region Packages
	private Package.MachineToolPackage _MachineToolPackage;
	/// <summary>
	/// <inheritdoc cref="Package.MachineToolPackage" path="/summary" />
	/// </summary>
	public Package.MachineToolPackage MachineToolPackage => _MachineToolPackage ?? (_MachineToolPackage = new Package.MachineToolPackage());

	private Package.OtherExamplesPackage _OtherExamplesPackage;
	/// <summary>
	/// <inheritdoc cref="Package.OtherExamplesPackage" path="/summary" />
	/// </summary>
	public Package.OtherExamplesPackage OtherExamplesPackage => _OtherExamplesPackage ?? (_OtherExamplesPackage = new Package.OtherExamplesPackage());

	private Package.ThermalPackage _ThermalPackage;
	/// <summary>
	/// <inheritdoc cref="Package.ThermalPackage" path="/summary" />
	/// </summary>
	public Package.ThermalPackage ThermalPackage => _ThermalPackage ?? (_ThermalPackage = new Package.ThermalPackage());

	private Package.RobotArmsPackage _RobotArmsPackage;
	/// <summary>
	/// <inheritdoc cref="Package.RobotArmsPackage" path="/summary" />
	/// </summary>
	public Package.RobotArmsPackage RobotArmsPackage => _RobotArmsPackage ?? (_RobotArmsPackage = new Package.RobotArmsPackage());

	private Package.AdditivePackage _AdditivePackage;
	/// <summary>
	/// <inheritdoc cref="Package.AdditivePackage" path="/summary" />
	/// </summary>
	public Package.AdditivePackage AdditivePackage => _AdditivePackage ?? (_AdditivePackage = new Package.AdditivePackage());

	#endregion

	#region Classes
	#endregion
	}
}