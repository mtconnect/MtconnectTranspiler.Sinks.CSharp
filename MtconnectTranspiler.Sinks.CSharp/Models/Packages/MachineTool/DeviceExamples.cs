#pragma warning disable CS1574 // XML comment has cref attribute that could not be resolved
#pragma warning disable CS1584 // XML comment has syntactically incorrect cref attribute
#pragma warning disable CS0618 // Type or member is obsolete
using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;
using Package = Mtconnect.WIP_BestPracticesWithExamples.MachineTool.DeviceExamples;

namespace Mtconnect.WIP_BestPracticesWithExamples.MachineTool
{
	/// <summary>﻿
	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Package___19_0_3_68e0225_1679333422461_846833_2966">model.mtconnect.org</seealso> for more information.
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public class DeviceExamplesPackage : IPackage
	{
		/// <summary>Constant value for <see cref="DeviceExamplesPackage.ReferenceId" /></summary>
		public const string REFERENCE_ID = "_19_0_3_68e0225_1679333422461_846833_2966";
		/// <summary>Constant value for <see cref="DeviceExamplesPackage.HelpUrl" /></summary>
		public const string HELP_URL = "https://model.mtconnect.org/#Package___19_0_3_68e0225_1679333422461_846833_2966";
		/// <summary>Constant value for <see cref="DeviceExamplesPackage.Name" /></summary>
		public const string NAME = "Device Examples";
		/// <summary>Constant value for <see cref="DeviceExamplesPackage.Summary" /></summary>
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
			OperationalStatePackage,
		};
		
		/// <inheritdoc />
		public IClass[] Classes => new IClass[] {
		};
		
		/// <inheritdoc />
		public IEnum[] Enums => new IEnum[] {
		};

		#region Packages
	private Package.OperationalStatePackage _OperationalStatePackage;
	/// <summary>
	/// <inheritdoc cref="Package.OperationalStatePackage" path="/summary" />
	/// </summary>
	public Package.OperationalStatePackage OperationalStatePackage => _OperationalStatePackage ?? (_OperationalStatePackage = new Package.OperationalStatePackage());

	#endregion

	#region Classes
	#endregion

	#region Enums
	#endregion
	}
}