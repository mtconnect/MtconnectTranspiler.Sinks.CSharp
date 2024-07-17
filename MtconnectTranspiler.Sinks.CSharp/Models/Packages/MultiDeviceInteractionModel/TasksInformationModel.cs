using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;
using Package = Mtconnect.InterfaceInteractionModel.MultiDeviceInteractionModel.TasksInformationModel;
// using Mtconnect;

namespace Mtconnect.InterfaceInteractionModel.MultiDeviceInteractionModel {
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "1.0.15.3")]
	public class TasksInformationModelPackage : IPackage {
		public IPackage[] Packages => new IPackage[] {
		};

		public IClass[] Classes => new IClass[] {
			TaskArchetypeClass,
			CollaboratorClass,
			TaskClass,
			PriorityClass,
			CapabilityClass,
		};

	private Package.TaskArchetypeClass _TaskArchetypeClass;
	public Package.TaskArchetypeClass TaskArchetypeClass => _TaskArchetypeClass ?? (_TaskArchetypeClass = new Package.TaskArchetypeClass());
	private Package.CollaboratorClass _CollaboratorClass;
	public Package.CollaboratorClass CollaboratorClass => _CollaboratorClass ?? (_CollaboratorClass = new Package.CollaboratorClass());
	private Package.TaskClass _TaskClass;
	public Package.TaskClass TaskClass => _TaskClass ?? (_TaskClass = new Package.TaskClass());
	private Package.PriorityClass _PriorityClass;
	public Package.PriorityClass PriorityClass => _PriorityClass ?? (_PriorityClass = new Package.PriorityClass());
	private Package.CapabilityClass _CapabilityClass;
	public Package.CapabilityClass CapabilityClass => _CapabilityClass ?? (_CapabilityClass = new Package.CapabilityClass());
	}
}