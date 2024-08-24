#pragma warning disable CS1574 // XML comment has cref attribute that could not be resolved
#pragma warning disable CS1584 // XML comment has syntactically incorrect cref attribute
#pragma warning disable CS0618 // Type or member is obsolete
using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;
using Package = Mtconnect.Imports;

namespace Mtconnect
{
	/// <summary>﻿
	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Package___19_0_3_68e0225_1642674055604_161919_102">model.mtconnect.org</seealso> for more information.
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public class ImportsPackage : IPackage
	{
		/// <summary>Constant value for <see cref="ImportsPackage.ReferenceId" /></summary>
		public const string REFERENCE_ID = "_19_0_3_68e0225_1642674055604_161919_102";
		/// <summary>Constant value for <see cref="ImportsPackage.HelpUrl" /></summary>
		public const string HELP_URL = "https://model.mtconnect.org/#Package___19_0_3_68e0225_1642674055604_161919_102";
		/// <summary>Constant value for <see cref="ImportsPackage.Name" /></summary>
		public const string NAME = "Imports";
		/// <summary>Constant value for <see cref="ImportsPackage.Summary" /></summary>
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
			CSVImportsPackage,
			UnitImportsPackage,
		};
		
		/// <inheritdoc />
		public IClass[] Classes => new IClass[] {
		};
		
		/// <inheritdoc />
		public IEnum[] Enums => new IEnum[] {
		};

		#region Packages
	private Package.CSVImportsPackage _CSVImportsPackage;
	/// <summary>
	/// <inheritdoc cref="Package.CSVImportsPackage" path="/summary" />
	/// </summary>
	public Package.CSVImportsPackage CSVImportsPackage => _CSVImportsPackage ?? (_CSVImportsPackage = new Package.CSVImportsPackage());

	private Package.UnitImportsPackage _UnitImportsPackage;
	/// <summary>
	/// <inheritdoc cref="Package.UnitImportsPackage" path="/summary" />
	/// </summary>
	public Package.UnitImportsPackage UnitImportsPackage => _UnitImportsPackage ?? (_UnitImportsPackage = new Package.UnitImportsPackage());

	#endregion

	#region Classes
	#endregion

	#region Enums
	#endregion
	}
}