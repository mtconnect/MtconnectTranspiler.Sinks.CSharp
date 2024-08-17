#pragma warning disable CS1574 // XML comment has cref attribute that could not be resolved
#pragma warning disable CS1584 // XML comment has syntactically incorrect cref attribute
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
		/// <inheritdoc />
		public string ReferenceId => "_19_0_3_68e0225_1679333422461_846833_2966";
		
		/// <inheritdoc />
		public string Name => "Device Examples";

		/// <inheritdoc />
		public string Summary => @"";

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