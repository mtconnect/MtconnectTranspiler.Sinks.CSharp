#pragma warning disable CS1574 // XML comment has cref attribute that could not be resolved
#pragma warning disable CS1584 // XML comment has syntactically incorrect cref attribute
#pragma warning disable CS0618 // Type or member is obsolete
using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;
using Package = Mtconnect.WIP_UseCases.PowerSource.Requirements;

namespace Mtconnect.WIP_UseCases.PowerSource
{
	/// <summary>﻿
	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Package___19_0_3_68e0225_1702477786447_952941_927">model.mtconnect.org</seealso> for more information.
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public class RequirementsPackage : IPackage
	{
		/// <summary>Constant value for <see cref="RequirementsPackage.ReferenceId" /></summary>
		public const string REFERENCE_ID = "_19_0_3_68e0225_1702477786447_952941_927";
		/// <summary>Constant value for <see cref="RequirementsPackage.HelpUrl" /></summary>
		public const string HELP_URL = "https://model.mtconnect.org/#Package___19_0_3_68e0225_1702477786447_952941_927";
		/// <summary>Constant value for <see cref="RequirementsPackage.Name" /></summary>
		public const string NAME = "Requirements";
		/// <summary>Constant value for <see cref="RequirementsPackage.Summary" /></summary>
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
			DeviceConfigurationClass,
		};
		
		/// <inheritdoc />
		public IEnum[] Enums => new IEnum[] {
		};

		#region Packages
	#endregion

	#region Classes
	private Package.DeviceConfigurationClass _DeviceConfigurationClass;
	/// <summary>
	/// <inheritdoc cref="Package.DeviceConfigurationClass" path="/summary" />
	/// </summary>
	public Package.DeviceConfigurationClass DeviceConfigurationClass => _DeviceConfigurationClass ?? (_DeviceConfigurationClass = new Package.DeviceConfigurationClass());

	#endregion

	#region Enums
	#endregion
	}
}