#pragma warning disable CS1574 // XML comment has cref attribute that could not be resolved
#pragma warning disable CS1584 // XML comment has syntactically incorrect cref attribute
#pragma warning disable CS0618 // Type or member is obsolete
using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;
using Package = Mtconnect.WIP_BestPracticesWithExamples.MachineTool;

namespace Mtconnect.WIP_BestPracticesWithExamples
{
	/// <summary>﻿
	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Package___19_0_3_68e0225_1679314832353_767937_2737">model.mtconnect.org</seealso> for more information.
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public class MachineToolPackage : IPackage
	{
		/// <summary>Constant value for <see cref="MachineToolPackage.ReferenceId" /></summary>
		public const string REFERENCE_ID = "_19_0_3_68e0225_1679314832353_767937_2737";
		/// <summary>Constant value for <see cref="MachineToolPackage.HelpUrl" /></summary>
		public const string HELP_URL = "https://model.mtconnect.org/#Package___19_0_3_68e0225_1679314832353_767937_2737";
		/// <summary>Constant value for <see cref="MachineToolPackage.Name" /></summary>
		public const string NAME = "Machine Tool";
		/// <summary>Constant value for <see cref="MachineToolPackage.Summary" /></summary>
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
			DeviceExamplesPackage,
		};
		
		/// <inheritdoc />
		public IClass[] Classes => new IClass[] {
		};
		
		/// <inheritdoc />
		public IEnum[] Enums => new IEnum[] {
		};

		#region Packages
	private Package.DeviceExamplesPackage _DeviceExamplesPackage;
	/// <summary>
	/// <inheritdoc cref="Package.DeviceExamplesPackage" path="/summary" />
	/// </summary>
	public Package.DeviceExamplesPackage DeviceExamplesPackage => _DeviceExamplesPackage ?? (_DeviceExamplesPackage = new Package.DeviceExamplesPackage());

	#endregion

	#region Classes
	#endregion

	#region Enums
	#endregion
	}
}