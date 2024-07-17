using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;
using Package = Mtconnect.InterfaceInteractionModel.MultiDeviceInteractionModel;

namespace Mtconnect.InterfaceInteractionModel {
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "1.0.15.3")]
	public class MultiDeviceInteractionModelPackage : IPackage {
		public IPackage[] Packages => new IPackage[] {
			TasksInformationModelPackage,
		};

		public IClass[] Classes => new IClass[] {
		};
	private Package.TasksInformationModelPackage _TasksInformationModelPackage;
	public Package.TasksInformationModelPackage TasksInformationModelPackage => _TasksInformationModelPackage ?? (_TasksInformationModelPackage = new Package.TasksInformationModelPackage());

	}
}