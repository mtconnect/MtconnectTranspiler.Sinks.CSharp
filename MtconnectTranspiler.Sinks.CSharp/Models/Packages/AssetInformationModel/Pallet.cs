#pragma warning disable CS1574 // XML comment has cref attribute that could not be resolved
#pragma warning disable CS1584 // XML comment has syntactically incorrect cref attribute
#pragma warning disable CS0618 // Type or member is obsolete
using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;
using Package = Mtconnect.AssetInformationModel.Pallet;

namespace Mtconnect.AssetInformationModel
{
	/// <summary>﻿This section provides semantic information for the <see cref="Pallet">Pallet</see> model.<br /><br />![Pallet](figures/Pallet.png "Files"){: width="0.8"}<br /><br /><br />
	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Package___2024x_68e0225_1727809448331_145268_25199">model.mtconnect.org</seealso> for more information.
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public class PalletPackage : IPackage
	{
		/// <summary>Constant value for <see cref="PalletPackage.ReferenceId" /></summary>
		public const string REFERENCE_ID = "_2024x_68e0225_1727809448331_145268_25199";
		/// <summary>Constant value for <see cref="PalletPackage.HelpUrl" /></summary>
		public const string HELP_URL = "https://model.mtconnect.org/#Package___2024x_68e0225_1727809448331_145268_25199";
		/// <summary>Constant value for <see cref="PalletPackage.Name" /></summary>
		public const string NAME = "Pallet";
		/// <summary>Constant value for <see cref="PalletPackage.Summary" /></summary>
		public const string SUMMARY = @"&#10;&#10;&#10;This section provides semantic information for the {{block(Pallet)}} model.

![Pallet](figures/Pallet.png ""Files""){: width=""0.8""}&#10;
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
			MeasurementsPackage,
		};
		
		/// <inheritdoc />
		public IClass[] Classes => new IClass[] {
			PalletClass,
		};
		
		/// <inheritdoc />
		public IEnum[] Enums => new IEnum[] {
		};

		#region Packages
	private Package.MeasurementsPackage _MeasurementsPackage;
	/// <summary>
	/// <inheritdoc cref="Package.MeasurementsPackage" path="/summary" />
	/// </summary>
	public Package.MeasurementsPackage MeasurementsPackage => _MeasurementsPackage ?? (_MeasurementsPackage = new Package.MeasurementsPackage());

	#endregion

	#region Classes
	private Package.PalletClass _PalletClass;
	/// <summary>
	/// <inheritdoc cref="Package.PalletClass" path="/summary" />
	/// </summary>
	public Package.PalletClass PalletClass => _PalletClass ?? (_PalletClass = new Package.PalletClass());

	#endregion

	#region Enums
	#endregion
	}
}