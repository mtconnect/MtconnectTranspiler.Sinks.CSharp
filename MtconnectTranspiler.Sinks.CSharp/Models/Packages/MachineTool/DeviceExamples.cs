using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;
using Package = Mtconnect.WIP_BestPracticesWithExamples.MachineTool.DeviceExamples;

namespace Mtconnect.WIP_BestPracticesWithExamples.MachineTool
{
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.3.0.0")]
	public class DeviceExamplesPackage : IPackage
	{
		/// <inheritdoc />
		public string ReferenceId => "_19_0_3_68e0225_1679333422461_846833_2966";
		
		/// <inheritdoc />
		public string Name => "Device Examples";

		/// <inheritdoc />
		public string Summary => @"";

		/// <inheritdoc />
		public IPackage[] Packages => new IPackage[] {
			OperationalStatePackage,
		};
		
		/// <inheritdoc />
		public IClass[] Classes => new IClass[] {
		};
		#region Packages
	private Package.OperationalStatePackage _OperationalStatePackage;
	/// <summary>
	/// <inheritdoc cref="Package.OperationalStatePackage" path="/summary" />
	/// </summary>
	public Package.OperationalStatePackage OperationalStatePackage => _OperationalStatePackage ?? (_OperationalStatePackage = new Package.OperationalStatePackage());

	#endregion

	#region Classes
	#endregion
	}
}