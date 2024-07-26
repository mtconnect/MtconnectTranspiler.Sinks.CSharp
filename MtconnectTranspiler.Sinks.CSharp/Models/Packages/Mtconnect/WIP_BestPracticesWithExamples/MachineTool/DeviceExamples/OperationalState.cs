
using System;
using System.CodeDom.Compiler;
using Package = Mtconnect.WIP_BestPracticesWithExamples.MachineTool.DeviceExamples.OperationalState;

using Mtconnect;

namespace Mtconnect.WIP_BestPracticesWithExamples.MachineTool.DeviceExamples {
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "1.0.15.3")]
	public class OperationalStatePackage {

	private Package.UseCasesPackage _UseCasesPackage;
	public Package.UseCasesPackage UseCasesPackage => _UseCasesPackage ?? (_UseCasesPackage = new Package.UseCasesPackage());

	private Package.ActorsPackage _ActorsPackage;
	public Package.ActorsPackage ActorsPackage => _ActorsPackage ?? (_ActorsPackage = new Package.ActorsPackage());


	private Package.MTConnectDeviceWithOperationalStatesClass _MTConnectDeviceWithOperationalStates;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.MTConnectDeviceWithOperationalStatesClass MTConnectDeviceWithOperationalStates => _MTConnectDeviceWithOperationalStates ?? (_MTConnectDeviceWithOperationalStates = new Package.MTConnectDeviceWithOperationalStatesClass());
	}
}