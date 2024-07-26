
using System;
using System.CodeDom.Compiler;
using Package = Mtconnect.InterfaceInteractionModel.MultiDeviceInteractionModel.TasksInformationModel;

using Mtconnect;

namespace Mtconnect.InterfaceInteractionModel.MultiDeviceInteractionModel {
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "1.0.15.3")]
	public class TasksInformationModelPackage {


	private Package.TaskArchetypeClass _TaskArchetype;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.TaskArchetypeClass TaskArchetype => _TaskArchetype ?? (_TaskArchetype = new Package.TaskArchetypeClass());

	private Package.CollaboratorClass _Collaborator;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.CollaboratorClass Collaborator => _Collaborator ?? (_Collaborator = new Package.CollaboratorClass());

	private Package.TaskClass _Task;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.TaskClass Task => _Task ?? (_Task = new Package.TaskClass());

	private Package.PriorityClass _Priority;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.PriorityClass Priority => _Priority ?? (_Priority = new Package.PriorityClass());

	private Package.CapabilityClass _Capability;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.CapabilityClass Capability => _Capability ?? (_Capability = new Package.CapabilityClass());
	}
}