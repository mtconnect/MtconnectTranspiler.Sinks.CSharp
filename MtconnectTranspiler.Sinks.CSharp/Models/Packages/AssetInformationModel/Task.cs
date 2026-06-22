#pragma warning disable CS1574 // XML comment has cref attribute that could not be resolved
#pragma warning disable CS1584 // XML comment has syntactically incorrect cref attribute
#pragma warning disable CS0618 // Type or member is obsolete
using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;
using Package = Mtconnect.AssetInformationModel.Task;

namespace Mtconnect.AssetInformationModel
{
	/// <summary>﻿This section provides semantic information for the <see cref="Task">Task</see> model.<br /><br /><br /><br />
	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Package___2024x_68e0225_1759816184963_464115_637">model.mtconnect.org</seealso> for more information.
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.8.0.0")]
	public class TaskPackage : IPackage
	{
		/// <summary>Constant value for <see cref="TaskPackage.ReferenceId" /></summary>
		public const string REFERENCE_ID = "_2024x_68e0225_1759816184963_464115_637";
		/// <summary>Constant value for <see cref="TaskPackage.HelpUrl" /></summary>
		public const string HELP_URL = "https://model.mtconnect.org/#Package___2024x_68e0225_1759816184963_464115_637";
		/// <summary>Constant value for <see cref="TaskPackage.Name" /></summary>
		public const string NAME = "Task";
		/// <summary>Constant value for <see cref="TaskPackage.Summary" /></summary>
		public const string SUMMARY = @"&#10;&#10;&#10;This section provides semantic information for the {{block(Task)}} model.
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
			TaskArchetypePackage,
		};
		
		/// <inheritdoc />
		public IClass[] Classes => new IClass[] {
			TaskClass,
			CollaboratorClass,
		};
		
		/// <inheritdoc />
		public IEnum[] Enums => new IEnum[] {
		};

		#region Packages
	private Package.TaskArchetypePackage _TaskArchetypePackage;
	/// <summary>
	/// <inheritdoc cref="Package.TaskArchetypePackage" path="/summary" />
	/// </summary>
	public Package.TaskArchetypePackage TaskArchetypePackage => _TaskArchetypePackage ?? (_TaskArchetypePackage = new Package.TaskArchetypePackage());

	#endregion

	#region Classes
	private Package.TaskClass _TaskClass;
	/// <summary>
	/// <inheritdoc cref="Package.TaskClass" path="/summary" />
	/// </summary>
	public Package.TaskClass TaskClass => _TaskClass ?? (_TaskClass = new Package.TaskClass());

	private Package.CollaboratorClass _CollaboratorClass;
	/// <summary>
	/// <inheritdoc cref="Package.CollaboratorClass" path="/summary" />
	/// </summary>
	public Package.CollaboratorClass CollaboratorClass => _CollaboratorClass ?? (_CollaboratorClass = new Package.CollaboratorClass());

	#endregion

	#region Enums
	#endregion
	}
}
