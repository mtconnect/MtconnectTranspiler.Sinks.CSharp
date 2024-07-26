
using System;
using System.CodeDom.Compiler;
using Package = Mtconnect.DeviceInformationModel.DataItems.PropertiesOfDataItem.PropertiesOfDefinition;

using Mtconnect;

namespace Mtconnect.DeviceInformationModel.DataItems.PropertiesOfDataItem {
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "1.0.15.3")]
	public class PropertiesOfDefinitionPackage {


	private Package.CellDefinitionClass _CellDefinition;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.CellDefinitionClass CellDefinition => _CellDefinition ?? (_CellDefinition = new Package.CellDefinitionClass());

	private Package.EntryDefinitionClass _EntryDefinition;
	/// <summary>
	/// Id: 
	/// </summary>
	public Package.EntryDefinitionClass EntryDefinition => _EntryDefinition ?? (_EntryDefinition = new Package.EntryDefinitionClass());
	}
}