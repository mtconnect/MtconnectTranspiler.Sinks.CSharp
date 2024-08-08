using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;

namespace Mtconnect.DeviceInformationModel.Components.ComponentTypes
{
	/// <summary>
	/// <see cref="Auxiliary">Auxiliary</see> that removes manufacturing byproducts from a piece of equipment.
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.3.0.0")]
	public sealed class WasteDisposalClass : IClass
	{
		/// <inheritdoc />
		public string ReferenceId => "_19_0_3_45f01b9_1579572382023_920799_42303";
		
		/// <inheritdoc />
		public string Summary => @"/// <see cref=""Auxiliary"">Auxiliary</see> that removes manufacturing byproducts from a piece of equipment.";

		/// <inheritdoc />
		public string Name => "WasteDisposalClass";
		
		/// <inheritdoc />
		public string AccessModifier => "public";
				
		/// <inheritdoc />
		public string Modifier => "";
				
		/// <inheritdoc />
		public string NormativeVersion => "1.4";
				
		/// <inheritdoc />
		public string DeprecatedVersion => "";
		
		/// <inheritdoc />
		public string Generalization => "_19_0_3_45f01b9_1579572381970_785259_42204";

		public IPropertyList Properties => null;

	}
}