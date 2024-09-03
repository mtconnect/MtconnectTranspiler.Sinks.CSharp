#pragma warning disable CS1574 // XML comment has cref attribute that could not be resolved
#pragma warning disable CS1584 // XML comment has syntactically incorrect cref attribute
#pragma warning disable CS0618 // Type or member is obsolete
using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;
using Package = Mtconnect.DeviceInformationModel.DataItems.PropertiesOfDataItem.PropertiesOfDefinition;

namespace Mtconnect.DeviceInformationModel.DataItems.PropertiesOfDataItem
{
	/// <summary>﻿This section provides semantic information for the elements of the <see cref="Definition">Definition</see> for a <see cref="DataItem">DataItem</see>.<br /><br /><br />
	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Package___19_0_3_91b028d_1589399411687_610742_35">model.mtconnect.org</seealso> for more information.
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public class PropertiesOfDefinitionPackage : IPackage
	{
		/// <summary>Constant value for <see cref="PropertiesOfDefinitionPackage.ReferenceId" /></summary>
		public const string REFERENCE_ID = "_19_0_3_91b028d_1589399411687_610742_35";
		/// <summary>Constant value for <see cref="PropertiesOfDefinitionPackage.HelpUrl" /></summary>
		public const string HELP_URL = "https://model.mtconnect.org/#Package___19_0_3_91b028d_1589399411687_610742_35";
		/// <summary>Constant value for <see cref="PropertiesOfDefinitionPackage.Name" /></summary>
		public const string NAME = "Properties of Definition";
		/// <summary>Constant value for <see cref="PropertiesOfDefinitionPackage.Summary" /></summary>
		public const string SUMMARY = @"&#10;&#10;&#10;This section provides semantic information for the elements of the {{block(Definition)}} for a {{block(DataItem)}}.&#10;
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
			CellDefinitionClass,
			EntryDefinitionClass,
		};
		
		/// <inheritdoc />
		public IEnum[] Enums => new IEnum[] {
		};

		#region Packages
	#endregion

	#region Classes
	private Package.CellDefinitionClass _CellDefinitionClass;
	/// <summary>
	/// <inheritdoc cref="Package.CellDefinitionClass" path="/summary" />
	/// </summary>
	public Package.CellDefinitionClass CellDefinitionClass => _CellDefinitionClass ?? (_CellDefinitionClass = new Package.CellDefinitionClass());

	private Package.EntryDefinitionClass _EntryDefinitionClass;
	/// <summary>
	/// <inheritdoc cref="Package.EntryDefinitionClass" path="/summary" />
	/// </summary>
	public Package.EntryDefinitionClass EntryDefinitionClass => _EntryDefinitionClass ?? (_EntryDefinitionClass = new Package.EntryDefinitionClass());

	#endregion

	#region Enums
	#endregion
	}
}