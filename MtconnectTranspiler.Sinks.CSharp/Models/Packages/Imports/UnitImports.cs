#pragma warning disable CS1574 // XML comment has cref attribute that could not be resolved
#pragma warning disable CS1584 // XML comment has syntactically incorrect cref attribute
#pragma warning disable CS0618 // Type or member is obsolete
using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;
using Package = Mtconnect.Imports.UnitImports;

namespace Mtconnect.Imports
{
	/// <summary>﻿
	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Package___19_0_3_45f01b9_1579105790694_260747_162771">model.mtconnect.org</seealso> for more information.
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public class UnitImportsPackage : IPackage
	{
		/// <summary>Constant value for <see cref="UnitImportsPackage.ReferenceId" /></summary>
		public const string REFERENCE_ID = "_19_0_3_45f01b9_1579105790694_260747_162771";
		/// <summary>Constant value for <see cref="UnitImportsPackage.HelpUrl" /></summary>
		public const string HELP_URL = "https://model.mtconnect.org/#Package___19_0_3_45f01b9_1579105790694_260747_162771";
		/// <summary>Constant value for <see cref="UnitImportsPackage.Name" /></summary>
		public const string NAME = "Unit Imports";
		/// <summary>Constant value for <see cref="UnitImportsPackage.Summary" /></summary>
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
			BasicUnitsPackage,
		};
		
		/// <inheritdoc />
		public IClass[] Classes => new IClass[] {
		};
		
		/// <inheritdoc />
		public IEnum[] Enums => new IEnum[] {
		};

		#region Packages
	private Package.BasicUnitsPackage _BasicUnitsPackage;
	/// <summary>
	/// <inheritdoc cref="Package.BasicUnitsPackage" path="/summary" />
	/// </summary>
	public Package.BasicUnitsPackage BasicUnitsPackage => _BasicUnitsPackage ?? (_BasicUnitsPackage = new Package.BasicUnitsPackage());

	#endregion

	#region Classes
	#endregion

	#region Enums
	#endregion
	}
}