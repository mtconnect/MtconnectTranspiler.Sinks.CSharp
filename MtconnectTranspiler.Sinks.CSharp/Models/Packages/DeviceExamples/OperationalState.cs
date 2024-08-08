using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;
using Package = Mtconnect.WIP_BestPracticesWithExamples.MachineTool.DeviceExamples.OperationalState;
// using Mtconnect;

namespace Mtconnect.WIP_BestPracticesWithExamples.MachineTool.DeviceExamples
{
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.3.0.0")]
	public class OperationalStatePackage : IPackage
	{
		/// <inheritdoc />
		public string ReferenceId => "_19_0_3_68e0225_1679487781772_498154_152";
		
		/// <inheritdoc />
		public string Name => "OperationalState";

		/// <inheritdoc />
		public string Summary => @"";

		/// <inheritdoc />
		public IPackage[] Packages => new IPackage[] {
			UseCasesPackage,
			ActorsPackage,
		};
		
		/// <inheritdoc />
		public IClass[] Classes => new IClass[] {
			MTConnectDeviceWithOperationalStatesClass,
		};
		#region Packages
	private Package.UseCasesPackage _UseCasesPackage;
	/// <summary>
	/// <inheritdoc cref="Package.UseCasesPackage" path="/summary" />
	/// </summary>
	public Package.UseCasesPackage UseCasesPackage => _UseCasesPackage ?? (_UseCasesPackage = new Package.UseCasesPackage());

	private Package.ActorsPackage _ActorsPackage;
	/// <summary>
	/// <inheritdoc cref="Package.ActorsPackage" path="/summary" />
	/// </summary>
	public Package.ActorsPackage ActorsPackage => _ActorsPackage ?? (_ActorsPackage = new Package.ActorsPackage());

	#endregion

	#region Classes
	private Package.MTConnectDeviceWithOperationalStatesClass _MTConnectDeviceWithOperationalStatesClass;
	/// <summary>
	/// <inheritdoc cref="Package.MTConnectDeviceWithOperationalStatesClass" path="/summary" />
	/// </summary>
	public Package.MTConnectDeviceWithOperationalStatesClass MTConnectDeviceWithOperationalStatesClass => _MTConnectDeviceWithOperationalStatesClass ?? (_MTConnectDeviceWithOperationalStatesClass = new Package.MTConnectDeviceWithOperationalStatesClass());

	#endregion
	}
}