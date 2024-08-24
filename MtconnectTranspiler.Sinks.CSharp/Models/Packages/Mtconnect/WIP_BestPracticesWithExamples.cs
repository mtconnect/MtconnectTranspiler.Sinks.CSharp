#pragma warning disable CS1574 // XML comment has cref attribute that could not be resolved
#pragma warning disable CS1584 // XML comment has syntactically incorrect cref attribute
#pragma warning disable CS0618 // Type or member is obsolete
using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;
using Package = Mtconnect.WIP_BestPracticesWithExamples;

namespace Mtconnect
{
	/// <summary>﻿
	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Package___19_0_3_68e0225_1620229279383_649426_1067">model.mtconnect.org</seealso> for more information.
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public class WIP_BestPracticesWithExamplesPackage : IPackage
	{
		/// <summary>Constant value for <see cref="WIP_BestPracticesWithExamplesPackage.ReferenceId" /></summary>
		public const string REFERENCE_ID = "_19_0_3_68e0225_1620229279383_649426_1067";
		/// <summary>Constant value for <see cref="WIP_BestPracticesWithExamplesPackage.HelpUrl" /></summary>
		public const string HELP_URL = "https://model.mtconnect.org/#Package___19_0_3_68e0225_1620229279383_649426_1067";
		/// <summary>Constant value for <see cref="WIP_BestPracticesWithExamplesPackage.Name" /></summary>
		public const string NAME = "WIP: Best Practices with Examples";
		/// <summary>Constant value for <see cref="WIP_BestPracticesWithExamplesPackage.Summary" /></summary>
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
			MachineToolPackage,
			OtherExamplesPackage,
			ThermalPackage,
			RobotArmsPackage,
			AdditivePackage,
		};
		
		/// <inheritdoc />
		public IClass[] Classes => new IClass[] {
		};
		
		/// <inheritdoc />
		public IEnum[] Enums => new IEnum[] {
		};

		#region Packages
	private Package.MachineToolPackage _MachineToolPackage;
	/// <summary>
	/// <inheritdoc cref="Package.MachineToolPackage" path="/summary" />
	/// </summary>
	public Package.MachineToolPackage MachineToolPackage => _MachineToolPackage ?? (_MachineToolPackage = new Package.MachineToolPackage());

	private Package.OtherExamplesPackage _OtherExamplesPackage;
	/// <summary>
	/// <inheritdoc cref="Package.OtherExamplesPackage" path="/summary" />
	/// </summary>
	public Package.OtherExamplesPackage OtherExamplesPackage => _OtherExamplesPackage ?? (_OtherExamplesPackage = new Package.OtherExamplesPackage());

	private Package.ThermalPackage _ThermalPackage;
	/// <summary>
	/// <inheritdoc cref="Package.ThermalPackage" path="/summary" />
	/// </summary>
	public Package.ThermalPackage ThermalPackage => _ThermalPackage ?? (_ThermalPackage = new Package.ThermalPackage());

	private Package.RobotArmsPackage _RobotArmsPackage;
	/// <summary>
	/// <inheritdoc cref="Package.RobotArmsPackage" path="/summary" />
	/// </summary>
	public Package.RobotArmsPackage RobotArmsPackage => _RobotArmsPackage ?? (_RobotArmsPackage = new Package.RobotArmsPackage());

	private Package.AdditivePackage _AdditivePackage;
	/// <summary>
	/// <inheritdoc cref="Package.AdditivePackage" path="/summary" />
	/// </summary>
	public Package.AdditivePackage AdditivePackage => _AdditivePackage ?? (_AdditivePackage = new Package.AdditivePackage());

	#endregion

	#region Classes
	#endregion

	#region Enums
	#endregion
	}
}