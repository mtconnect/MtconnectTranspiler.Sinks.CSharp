#pragma warning disable CS1574 // XML comment has cref attribute that could not be resolved
#pragma warning disable CS1584 // XML comment has syntactically incorrect cref attribute
#pragma warning disable CS0618 // Type or member is obsolete
using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;
using Package = Mtconnect.AssetInformationModel.Fixture;

namespace Mtconnect.AssetInformationModel
{
	/// <summary>﻿This section provides semantic information for the <see cref="Fixture">Fixture</see> model.<br /><br />![Fixture](figures/Fixture.png "Files"){: width="0.8"}<br /><br /><br />
	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Package___2024x_68e0225_1727795800350_745933_24127">model.mtconnect.org</seealso> for more information.
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public class FixturePackage : IPackage
	{
		/// <summary>Constant value for <see cref="FixturePackage.ReferenceId" /></summary>
		public const string REFERENCE_ID = "_2024x_68e0225_1727795800350_745933_24127";
		/// <summary>Constant value for <see cref="FixturePackage.HelpUrl" /></summary>
		public const string HELP_URL = "https://model.mtconnect.org/#Package___2024x_68e0225_1727795800350_745933_24127";
		/// <summary>Constant value for <see cref="FixturePackage.Name" /></summary>
		public const string NAME = "Fixture";
		/// <summary>Constant value for <see cref="FixturePackage.Summary" /></summary>
		public const string SUMMARY = @"&#10;&#10;&#10;This section provides semantic information for the {{block(Fixture)}} model.

![Fixture](figures/Fixture.png ""Files""){: width=""0.8""}&#10;
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
			FixtureClass,
		};
		
		/// <inheritdoc />
		public IEnum[] Enums => new IEnum[] {
		};

		#region Packages
	#endregion

	#region Classes
	private Package.FixtureClass _FixtureClass;
	/// <summary>
	/// <inheritdoc cref="Package.FixtureClass" path="/summary" />
	/// </summary>
	public Package.FixtureClass FixtureClass => _FixtureClass ?? (_FixtureClass = new Package.FixtureClass());

	#endregion

	#region Enums
	#endregion
	}
}