#pragma warning disable CS1574 // XML comment has cref attribute that could not be resolved
#pragma warning disable CS1584 // XML comment has syntactically incorrect cref attribute
#pragma warning disable CS0618 // Type or member is obsolete
using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;
using Package = Mtconnect.AssetInformationModel.Task.TaskArchetype;

namespace Mtconnect.AssetInformationModel.Task
{
	/// <summary>﻿This section provides semantic information for the <see cref="TaskArchetype">TaskArchetype</see> model.<br /><br /><br /><br />
	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Package___2024x_3_3870182_1764673009363_48126_1567">model.mtconnect.org</seealso> for more information.
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.6.0.0")]
	public class TaskArchetypePackage : IPackage
	{
		/// <summary>Constant value for <see cref="TaskArchetypePackage.ReferenceId" /></summary>
		public const string REFERENCE_ID = "_2024x_3_3870182_1764673009363_48126_1567";
		/// <summary>Constant value for <see cref="TaskArchetypePackage.HelpUrl" /></summary>
		public const string HELP_URL = "https://model.mtconnect.org/#Package___2024x_3_3870182_1764673009363_48126_1567";
		/// <summary>Constant value for <see cref="TaskArchetypePackage.Name" /></summary>
		public const string NAME = "Task Archetype";
		/// <summary>Constant value for <see cref="TaskArchetypePackage.Summary" /></summary>
		public const string SUMMARY = @"&#10;&#10;&#10;This section provides semantic information for the {{block(TaskArchetype)}} model.
&#10;
";

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
			CollaboratorClass,
			TaskArchetypeClass,
			SubTaskRefClass,
		};
		
		/// <inheritdoc />
		public IEnum[] Enums => new IEnum[] {
		};

		#region Packages
	#endregion

	#region Classes
	private Package.CollaboratorClass _CollaboratorClass;
	/// <summary>
	/// <inheritdoc cref="Package.CollaboratorClass" path="/summary" />
	/// </summary>
	public Package.CollaboratorClass CollaboratorClass => _CollaboratorClass ?? (_CollaboratorClass = new Package.CollaboratorClass());

	private Package.TaskArchetypeClass _TaskArchetypeClass;
	/// <summary>
	/// <inheritdoc cref="Package.TaskArchetypeClass" path="/summary" />
	/// </summary>
	public Package.TaskArchetypeClass TaskArchetypeClass => _TaskArchetypeClass ?? (_TaskArchetypeClass = new Package.TaskArchetypeClass());

	private Package.SubTaskRefClass _SubTaskRefClass;
	/// <summary>
	/// <inheritdoc cref="Package.SubTaskRefClass" path="/summary" />
	/// </summary>
	public Package.SubTaskRefClass SubTaskRefClass => _SubTaskRefClass ?? (_SubTaskRefClass = new Package.SubTaskRefClass());

	#endregion

	#region Enums
	#endregion
	}
}