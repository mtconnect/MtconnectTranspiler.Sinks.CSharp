using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;
using Package = Mtconnect.WIP_BestPracticesWithExamples.OtherExamples;

namespace Mtconnect.WIP_BestPracticesWithExamples
{
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.3.0.0")]
	public class OtherExamplesPackage : IPackage
	{
		/// <inheritdoc />
		public string ReferenceId => "_19_0_3_68e0225_1679315100755_628356_2764";
		
		/// <inheritdoc />
		public string Name => "Other Examples";

		/// <inheritdoc />
		public string Summary => @"";

		/// <inheritdoc />
		public IPackage[] Packages => new IPackage[] {
			PocketNCPackage,
			KinematicsSimulationPackage,
			MillW_PER_SmoothGPackage,
		};
		
		/// <inheritdoc />
		public IClass[] Classes => new IClass[] {
		};
		#region Packages
	private Package.PocketNCPackage _PocketNCPackage;
	/// <summary>
	/// <inheritdoc cref="Package.PocketNCPackage" path="/summary" />
	/// </summary>
	public Package.PocketNCPackage PocketNCPackage => _PocketNCPackage ?? (_PocketNCPackage = new Package.PocketNCPackage());

	private Package.KinematicsSimulationPackage _KinematicsSimulationPackage;
	/// <summary>
	/// <inheritdoc cref="Package.KinematicsSimulationPackage" path="/summary" />
	/// </summary>
	public Package.KinematicsSimulationPackage KinematicsSimulationPackage => _KinematicsSimulationPackage ?? (_KinematicsSimulationPackage = new Package.KinematicsSimulationPackage());

	private Package.MillW_PER_SmoothGPackage _MillW_PER_SmoothGPackage;
	/// <summary>
	/// <inheritdoc cref="Package.MillW_PER_SmoothGPackage" path="/summary" />
	/// </summary>
	public Package.MillW_PER_SmoothGPackage MillW_PER_SmoothGPackage => _MillW_PER_SmoothGPackage ?? (_MillW_PER_SmoothGPackage = new Package.MillW_PER_SmoothGPackage());

	#endregion

	#region Classes
	#endregion
	}
}