#pragma warning disable CS1574 // XML comment has cref attribute that could not be resolved
#pragma warning disable CS1584 // XML comment has syntactically incorrect cref attribute
#pragma warning disable CS0618 // Type or member is obsolete
using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;
using Package = Mtconnect.InterfaceInteractionModel.MultiDeviceInteractionModel.TasksInformationModel;

namespace Mtconnect.InterfaceInteractionModel.MultiDeviceInteractionModel
{
	/// <summary>﻿
	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Package___19_0_3_68e0225_1622718436806_684422_1202">model.mtconnect.org</seealso> for more information.
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public class TasksInformationModelPackage : IPackage
	{
		/// <summary>Constant value for <see cref="TasksInformationModelPackage.ReferenceId" /></summary>
		public const string REFERENCE_ID = "_19_0_3_68e0225_1622718436806_684422_1202";
		/// <summary>Constant value for <see cref="TasksInformationModelPackage.HelpUrl" /></summary>
		public const string HELP_URL = "https://model.mtconnect.org/#Package___19_0_3_68e0225_1622718436806_684422_1202";
		/// <summary>Constant value for <see cref="TasksInformationModelPackage.Name" /></summary>
		public const string NAME = "Tasks Information Model";
		/// <summary>Constant value for <see cref="TasksInformationModelPackage.Summary" /></summary>
		public const string SUMMARY = @"";

		/// <inheritdoc />
		public string ReferenceId => REFERENCE_ID;
		
		/// <inheritdoc />
		public string HelpUrl => HELP_URL;
		
		/// <inheritdoc />
		public string Name => NAME;

		/// <inheritdoc />
		public string Summary => SUMMARY;

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
		
		/// <inheritdoc />
		public IEnum[] Enums => new IEnum[] {
			TaskTypeEnum,
			TaskStateEnum,
			CollaboratorTypeEnum,
			CapabilityTypeEnum,
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

	#region Enums
	private Package.TaskTypeEnumMetaClass _TaskTypeEnum;
	/// <summary>
	/// <inheritdoc cref="Package.TaskTypeEnumMetaClass" path="/summary" />
	/// </summary>
	public Package.TaskTypeEnumMetaClass TaskTypeEnum => _TaskTypeEnum ?? (_TaskTypeEnum = new Package.TaskTypeEnumMetaClass());

	private Package.TaskStateEnumMetaClass _TaskStateEnum;
	/// <summary>
	/// <inheritdoc cref="Package.TaskStateEnumMetaClass" path="/summary" />
	/// </summary>
	public Package.TaskStateEnumMetaClass TaskStateEnum => _TaskStateEnum ?? (_TaskStateEnum = new Package.TaskStateEnumMetaClass());

	private Package.CollaboratorTypeEnumMetaClass _CollaboratorTypeEnum;
	/// <summary>
	/// <inheritdoc cref="Package.CollaboratorTypeEnumMetaClass" path="/summary" />
	/// </summary>
	public Package.CollaboratorTypeEnumMetaClass CollaboratorTypeEnum => _CollaboratorTypeEnum ?? (_CollaboratorTypeEnum = new Package.CollaboratorTypeEnumMetaClass());

	private Package.CapabilityTypeEnumMetaClass _CapabilityTypeEnum;
	/// <summary>
	/// <inheritdoc cref="Package.CapabilityTypeEnumMetaClass" path="/summary" />
	/// </summary>
	public Package.CapabilityTypeEnumMetaClass CapabilityTypeEnum => _CapabilityTypeEnum ?? (_CapabilityTypeEnum = new Package.CapabilityTypeEnumMetaClass());

	#endregion
	}
}