using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;
using Package = Mtconnect.InterfaceInteractionModel.MultiDeviceInteractionModel.TasksInformationModel;

namespace Mtconnect.InterfaceInteractionModel.MultiDeviceInteractionModel
{
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public class TasksInformationModelPackage : IPackage
	{
		/// <inheritdoc />
		public string ReferenceId => "_19_0_3_68e0225_1622718436806_684422_1202";
		
		/// <inheritdoc />
		public string Name => "Tasks Information Model";

		/// <inheritdoc />
		public string Summary => @"";

		/// <inheritdoc />
		public IPackage[] Packages => new IPackage[] {
		};
		
		/// <inheritdoc />
		public IClass[] Classes => new IClass[] {
			TaskArchetypeClass,
			CollaboratorClass,
			TaskClass,
			PriorityClass,
			CapabilityClass,
		};
		#region Packages
	#endregion

	#region Classes
	private Package.TaskArchetypeClass _TaskArchetypeClass;
	/// <summary>
	/// <inheritdoc cref="Package.TaskArchetypeClass" path="/summary" />
	/// </summary>
	public Package.TaskArchetypeClass TaskArchetypeClass => _TaskArchetypeClass ?? (_TaskArchetypeClass = new Package.TaskArchetypeClass());

	private Package.CollaboratorClass _CollaboratorClass;
	/// <summary>
	/// <inheritdoc cref="Package.CollaboratorClass" path="/summary" />
	/// </summary>
	public Package.CollaboratorClass CollaboratorClass => _CollaboratorClass ?? (_CollaboratorClass = new Package.CollaboratorClass());

	private Package.TaskClass _TaskClass;
	/// <summary>
	/// <inheritdoc cref="Package.TaskClass" path="/summary" />
	/// </summary>
	public Package.TaskClass TaskClass => _TaskClass ?? (_TaskClass = new Package.TaskClass());

	private Package.PriorityClass _PriorityClass;
	/// <summary>
	/// <inheritdoc cref="Package.PriorityClass" path="/summary" />
	/// </summary>
	public Package.PriorityClass PriorityClass => _PriorityClass ?? (_PriorityClass = new Package.PriorityClass());

	private Package.CapabilityClass _CapabilityClass;
	/// <summary>
	/// <inheritdoc cref="Package.CapabilityClass" path="/summary" />
	/// </summary>
	public Package.CapabilityClass CapabilityClass => _CapabilityClass ?? (_CapabilityClass = new Package.CapabilityClass());

	#endregion
	}
}