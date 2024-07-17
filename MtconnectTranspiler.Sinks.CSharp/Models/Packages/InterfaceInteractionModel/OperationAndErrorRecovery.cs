using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;
using Package = Mtconnect.InterfaceInteractionModel.OperationAndErrorRecovery;

namespace Mtconnect.InterfaceInteractionModel {
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "1.0.15.3")]
	public class OperationAndErrorRecoveryPackage : IPackage {
		public IPackage[] Packages => new IPackage[] {
			RequestAndResponseFailureHandlingAndRecoveryPackage,
		};

		public IClass[] Classes => new IClass[] {
		};
	private Package.RequestAndResponseFailureHandlingAndRecoveryPackage _RequestAndResponseFailureHandlingAndRecoveryPackage;
	public Package.RequestAndResponseFailureHandlingAndRecoveryPackage RequestAndResponseFailureHandlingAndRecoveryPackage => _RequestAndResponseFailureHandlingAndRecoveryPackage ?? (_RequestAndResponseFailureHandlingAndRecoveryPackage = new Package.RequestAndResponseFailureHandlingAndRecoveryPackage());

	}
}