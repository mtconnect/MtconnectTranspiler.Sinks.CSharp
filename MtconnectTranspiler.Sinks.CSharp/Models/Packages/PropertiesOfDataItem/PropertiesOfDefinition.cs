using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;
using Package = Mtconnect.DeviceInformationModel.DataItems.PropertiesOfDataItem.PropertiesOfDefinition;

namespace Mtconnect.DeviceInformationModel.DataItems.PropertiesOfDataItem
{
	/// <summary>
	/// This section provides semantic information for the elements of the <see cref="Definition">Definition</see> for a <see cref="DataItem">DataItem</see>.
	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Package___19_0_3_91b028d_1589399411687_610742_35">model.mtconnect.org</seealso> for more information.
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.3.0.0")]
	public class PropertiesOfDefinitionPackage : IPackage
	{
		/// <inheritdoc />
		public string ReferenceId => "_19_0_3_91b028d_1589399411687_610742_35";
		
		/// <inheritdoc />
		public string Name => "Properties of Definition";

		/// <inheritdoc />
		public string Summary => @"/// This section provides semantic information for the elements of the <see cref=""Definition"">Definition</see> for a <see cref=""DataItem"">DataItem</see>.";

		/// <inheritdoc />
		public IPackage[] Packages => new IPackage[] {
		};
		
		/// <inheritdoc />
		public IClass[] Classes => new IClass[] {
			CellDefinitionClass,
			EntryDefinitionClass,
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
	}
}