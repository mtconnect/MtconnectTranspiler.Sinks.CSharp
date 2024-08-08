using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;

namespace Mtconnect.DeviceInformationModel.Components.ComponentTypes
{
	/// <summary>
	/// <see cref="Auxiliary">Auxiliary</see> that manages the addition of material or state change of material being performed in an additive manufacturing process./// Description
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.3.0.0")]
	public sealed class DepositionClass : IClass
	{
		/// <inheritdoc />
		public string ReferenceId => "_19_0_3_45f01b9_1579572381981_362854_42222";
		
		/// <inheritdoc />
		public string Summary => @"/// <see cref=""Auxiliary"">Auxiliary</see> that manages the addition of material or state change of material being performed in an additive manufacturing process./// Description";

		/// <inheritdoc />
		public string Name => "DepositionClass";
		
		/// <inheritdoc />
		public string AccessModifier => "public";
				
		/// <inheritdoc />
		public string Modifier => "";
				
		/// <inheritdoc />
		public string NormativeVersion => "1.5";
				
		/// <inheritdoc />
		public string DeprecatedVersion => "";
		
		/// <inheritdoc />
		public string Generalization => "_19_0_3_45f01b9_1579572381970_785259_42204";

		public IPropertyList Properties => null;

	}
}