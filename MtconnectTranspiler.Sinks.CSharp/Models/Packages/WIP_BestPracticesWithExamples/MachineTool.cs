using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;
using Package = Mtconnect.WIP_BestPracticesWithExamples.MachineTool;

namespace Mtconnect.WIP_BestPracticesWithExamples
{
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public class MachineToolPackage : IPackage
	{
		/// <inheritdoc />
		public string ReferenceId => "_19_0_3_68e0225_1679314832353_767937_2737";
		
		/// <inheritdoc />
		public string Name => "Machine Tool";

		/// <inheritdoc />
		public string Summary => @"";

		/// <inheritdoc />
		public IPackage[] Packages => new IPackage[] {
			DeviceExamplesPackage,
		};
		
		/// <inheritdoc />
		public IClass[] Classes => new IClass[] {
		};
		#region Packages
	private Package.DeviceExamplesPackage _DeviceExamplesPackage;
	/// <summary>
	/// <inheritdoc cref="Package.DeviceExamplesPackage" path="/summary" />
	/// </summary>
	public Package.DeviceExamplesPackage DeviceExamplesPackage => _DeviceExamplesPackage ?? (_DeviceExamplesPackage = new Package.DeviceExamplesPackage());

	#endregion

	#region Classes
	#endregion
	}
}