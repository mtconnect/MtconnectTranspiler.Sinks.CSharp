using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;
using Package = Mtconnect.InterfaceInteractionModel.OperationAndErrorRecovery;

namespace Mtconnect.InterfaceInteractionModel
{
	/// <summary>
	/// The <i>request and response</i> state model implemented for <i>interface</i>s may also be represented by a graphical model.  The scenario in {{figure(Success Scenario)}} demonstrates the state transitions that occur during a successful <i>request</i> for service and the resulting <i>response</i> to fulfill that service <i>request</i>.   ![Success Scenario](figures/Success%20Scenario.png "Success Scenario"){: width="0.8"}
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.3.0.0")]
	public class OperationAndErrorRecoveryPackage : IPackage
	{
		/// <inheritdoc />
		public string ReferenceId => "_19_0_3_68e0225_1623755007633_105506_1249";
		
		/// <inheritdoc />
		public string Name => "OperationAndErrorRecovery";

		/// <inheritdoc />
		public string Summary => @"/// The <i>request and response</i> state model implemented for <i>interface</i>s may also be represented by a graphical model.  The scenario in {{figure(Success Scenario)}} demonstrates the state transitions that occur during a successful <i>request</i> for service and the resulting <i>response</i> to fulfill that service <i>request</i>.   ![Success Scenario](figures/Success%20Scenario.png ""Success Scenario""){: width=""0.8""}";

		/// <inheritdoc />
		public IPackage[] Packages => new IPackage[] {
			RequestAndResponseFailureHandlingAndRecoveryPackage,
		};
		
		/// <inheritdoc />
		public IClass[] Classes => new IClass[] {
		};
		#region Packages
	private Package.RequestAndResponseFailureHandlingAndRecoveryPackage _RequestAndResponseFailureHandlingAndRecoveryPackage;
	/// <summary>
	/// <inheritdoc cref="Package.RequestAndResponseFailureHandlingAndRecoveryPackage" path="/summary" />
	/// </summary>
	public Package.RequestAndResponseFailureHandlingAndRecoveryPackage RequestAndResponseFailureHandlingAndRecoveryPackage => _RequestAndResponseFailureHandlingAndRecoveryPackage ?? (_RequestAndResponseFailureHandlingAndRecoveryPackage = new Package.RequestAndResponseFailureHandlingAndRecoveryPackage());

	#endregion

	#region Classes
	#endregion
	}
}