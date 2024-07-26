
using System;
using System.CodeDom.Compiler;
using Package = Mtconnect.InterfaceInteractionModel.OperationAndErrorRecovery;


namespace Mtconnect.InterfaceInteractionModel {
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "1.0.15.3")]
	public class OperationAndErrorRecoveryPackage {

	private Package.RequestAndResponseFailureHandlingAndRecoveryPackage _RequestAndResponseFailureHandlingAndRecoveryPackage;
	public Package.RequestAndResponseFailureHandlingAndRecoveryPackage RequestAndResponseFailureHandlingAndRecoveryPackage => _RequestAndResponseFailureHandlingAndRecoveryPackage ?? (_RequestAndResponseFailureHandlingAndRecoveryPackage = new Package.RequestAndResponseFailureHandlingAndRecoveryPackage());

	}
}