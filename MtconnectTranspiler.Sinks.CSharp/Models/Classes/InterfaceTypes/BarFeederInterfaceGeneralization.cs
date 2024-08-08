using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;

namespace Mtconnect.InterfaceInteractionModel.InterfaceTypes
{
	/// <summary>
	/// <see cref="Interface">Interface</see> that coordinates the operations between a bar feeder and another piece of equipment.  Bar feeder is a piece of equipment that pushes bar stock (i.e., long pieces of material of various shapes) into an associated piece of equipment – most typically a lathe or turning center.
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.3.0.0")]
	public sealed class BarFeederInterfaceGeneralization : IClass
	{
		/// <inheritdoc />
		public string ReferenceId => "_19_0_3_68e0225_1622717386025_755435_931";
		
		/// <inheritdoc />
		public string Summary => @"/// <see cref=""Interface"">Interface</see> that coordinates the operations between a bar feeder and another piece of equipment.  Bar feeder is a piece of equipment that pushes bar stock (i.e., long pieces of material of various shapes) into an associated piece of equipment – most typically a lathe or turning center.";

		/// <inheritdoc />
		public string Name => "BarFeederInterfaceGeneralization";
		
		/// <inheritdoc />
		public string AccessModifier => "public";
				
		/// <inheritdoc />
		public string Modifier => "";
				
		/// <inheritdoc />
		public string NormativeVersion => "1.3";
				
		/// <inheritdoc />
		public string DeprecatedVersion => "";
		
		/// <inheritdoc />
		public string Generalization => "_19_0_3_45f01b9_1579572381996_964170_42252";

		public IPropertyList Properties => null;

	}
}