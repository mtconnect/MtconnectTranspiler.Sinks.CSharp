using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;
using Package = Mtconnect.InterfaceInteractionModel;
// using Mtconnect;

namespace Mtconnect {
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "1.0.15.3")]
	public class InterfaceInteractionModelPackage : IPackage {
		public IPackage[] Packages => new IPackage[] {
			SignalsPackage,
			InterfaceTypesPackage,
			MultiDeviceInteractionModelPackage,
			OperationAndErrorRecoveryPackage,
			DataItemTypesForInterfacePackage,
			DataForInterfacePackage,
		};

		public IClass[] Classes => new IClass[] {
			InterfaceClass,
			RequesterClass,
			ResponderClass,
		};
	private Package.SignalsPackage _SignalsPackage;
	public Package.SignalsPackage SignalsPackage => _SignalsPackage ?? (_SignalsPackage = new Package.SignalsPackage());
	private Package.InterfaceTypesPackage _InterfaceTypesPackage;
	public Package.InterfaceTypesPackage InterfaceTypesPackage => _InterfaceTypesPackage ?? (_InterfaceTypesPackage = new Package.InterfaceTypesPackage());
	private Package.MultiDeviceInteractionModelPackage _MultiDeviceInteractionModelPackage;
	public Package.MultiDeviceInteractionModelPackage MultiDeviceInteractionModelPackage => _MultiDeviceInteractionModelPackage ?? (_MultiDeviceInteractionModelPackage = new Package.MultiDeviceInteractionModelPackage());
	private Package.OperationAndErrorRecoveryPackage _OperationAndErrorRecoveryPackage;
	public Package.OperationAndErrorRecoveryPackage OperationAndErrorRecoveryPackage => _OperationAndErrorRecoveryPackage ?? (_OperationAndErrorRecoveryPackage = new Package.OperationAndErrorRecoveryPackage());
	private Package.DataItemTypesForInterfacePackage _DataItemTypesForInterfacePackage;
	public Package.DataItemTypesForInterfacePackage DataItemTypesForInterfacePackage => _DataItemTypesForInterfacePackage ?? (_DataItemTypesForInterfacePackage = new Package.DataItemTypesForInterfacePackage());
	private Package.DataForInterfacePackage _DataForInterfacePackage;
	public Package.DataForInterfacePackage DataForInterfacePackage => _DataForInterfacePackage ?? (_DataForInterfacePackage = new Package.DataForInterfacePackage());

	private Package.InterfaceClass _InterfaceClass;
	public Package.InterfaceClass InterfaceClass => _InterfaceClass ?? (_InterfaceClass = new Package.InterfaceClass());
	private Package.RequesterClass _RequesterClass;
	public Package.RequesterClass RequesterClass => _RequesterClass ?? (_RequesterClass = new Package.RequesterClass());
	private Package.ResponderClass _ResponderClass;
	public Package.ResponderClass ResponderClass => _ResponderClass ?? (_ResponderClass = new Package.ResponderClass());
	}
}