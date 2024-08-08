using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;

namespace Mtconnect.InterfaceInteractionModel.InterfaceTypes
{
	/// <summary>
	/// <see cref="Interface">Interface</see> that coordinates the operations between two pieces of equipment, one of which controls the operation of a door.  The piece of equipment that is controlling the door <b>MUST</b> provide data item <see cref="DoorState">DoorState</see> as part of the set of information provided.
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.3.0.0")]
	public sealed class DoorInterfaceGeneralization : IClass
	{
		/// <inheritdoc />
		public string ReferenceId => "_19_0_3_68e0225_1622717425705_537671_1027";
		
		/// <inheritdoc />
		public string Summary => @"/// <see cref=""Interface"">Interface</see> that coordinates the operations between two pieces of equipment, one of which controls the operation of a door.  The piece of equipment that is controlling the door <b>MUST</b> provide data item <see cref=""DoorState"">DoorState</see> as part of the set of information provided.";

		/// <inheritdoc />
		public string Name => "DoorInterfaceGeneralization";
		
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