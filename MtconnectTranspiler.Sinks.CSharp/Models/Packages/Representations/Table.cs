#pragma warning disable CS1574 // XML comment has cref attribute that could not be resolved
#pragma warning disable CS1584 // XML comment has syntactically incorrect cref attribute
#pragma warning disable CS0618 // Type or member is obsolete
using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;
using Package = Mtconnect.ObservationInformationModel.Representations.Table;

namespace Mtconnect.ObservationInformationModel.Representations
{
	/// <summary>﻿This section provides semantic information for the <see cref="Representation">Representation</see> type <see cref="Table">Table</see>.<br /><br /><br />
	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Package___2024x_68e0225_1759817482958_638823_2781">model.mtconnect.org</seealso> for more information.
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.8.0.0")]
	public class TablePackage : IPackage
	{
		/// <summary>Constant value for <see cref="TablePackage.ReferenceId" /></summary>
		public const string REFERENCE_ID = "_2024x_68e0225_1759817482958_638823_2781";
		/// <summary>Constant value for <see cref="TablePackage.HelpUrl" /></summary>
		public const string HELP_URL = "https://model.mtconnect.org/#Package___2024x_68e0225_1759817482958_638823_2781";
		/// <summary>Constant value for <see cref="TablePackage.Name" /></summary>
		public const string NAME = "Table";
		/// <summary>Constant value for <see cref="TablePackage.Summary" /></summary>
		public const string SUMMARY = @"&#10;&#10;&#10;This section provides semantic information for the {{block(Representation)}} type {{block(Table)}}.&#10;
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
			TableClass,
			EntryClass,
			CellClass,
		};
		
		/// <inheritdoc />
		public IEnum[] Enums => new IEnum[] {
		};

		#region Packages
	#endregion

	#region Classes
	private Package.TableClass _TableClass;
	/// <summary>
	/// <inheritdoc cref="Package.TableClass" path="/summary" />
	/// </summary>
	public Package.TableClass TableClass => _TableClass ?? (_TableClass = new Package.TableClass());

	private Package.EntryClass _EntryClass;
	/// <summary>
	/// <inheritdoc cref="Package.EntryClass" path="/summary" />
	/// </summary>
	public Package.EntryClass EntryClass => _EntryClass ?? (_EntryClass = new Package.EntryClass());

	private Package.CellClass _CellClass;
	/// <summary>
	/// <inheritdoc cref="Package.CellClass" path="/summary" />
	/// </summary>
	public Package.CellClass CellClass => _CellClass ?? (_CellClass = new Package.CellClass());

	#endregion

	#region Enums
	#endregion
	}
}
