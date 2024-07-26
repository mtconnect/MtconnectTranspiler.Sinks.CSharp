
using System;
using System.CodeDom.Compiler;
using Package = Mtconnect.InterfaceInteractionModel.MultiDeviceInteractionModel;


namespace Mtconnect.InterfaceInteractionModel {
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "1.0.15.3")]
	public class MultiDeviceInteractionModelPackage {

	private Package.TasksInformationModelPackage _TasksInformationModelPackage;
	public Package.TasksInformationModelPackage TasksInformationModelPackage => _TasksInformationModelPackage ?? (_TasksInformationModelPackage = new Package.TasksInformationModelPackage());

	}
}