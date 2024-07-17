using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;
using Package = Mtconnect.DeviceInformationModel.DataItems.PropertiesOfDataItem.PropertiesOfDefinition;
// using Mtconnect;

namespace Mtconnect.DeviceInformationModel.DataItems.PropertiesOfDataItem {
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "1.0.15.3")]
	public class PropertiesOfDefinitionPackage : IPackage {
		public IPackage[] Packages => new IPackage[] {
		};

		public IClass[] Classes => new IClass[] {
			CellDefinitionClass,
			EntryDefinitionClass,
		};

	private Package.CellDefinitionClass _CellDefinitionClass;
	public Package.CellDefinitionClass CellDefinitionClass => _CellDefinitionClass ?? (_CellDefinitionClass = new Package.CellDefinitionClass());
	private Package.EntryDefinitionClass _EntryDefinitionClass;
	public Package.EntryDefinitionClass EntryDefinitionClass => _EntryDefinitionClass ?? (_EntryDefinitionClass = new Package.EntryDefinitionClass());
	}
}