using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;

namespace Mtconnect.DeviceInformationModel.Components.ComponentTypes
{
	/// <summary>
	/// <see cref="Power">Power</see> was <b>DEPRECATED</b> in <i>MTConnect Version 1.1</i>s and was replaced by <see cref="Availability">Availability</see> data item type.
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.3.0.0")]
	public sealed class PowerClass : IClass
	{
		/// <inheritdoc />
		public string ReferenceId => "_19_0_3_45f01b9_1579572382010_841174_42276";
		
		/// <inheritdoc />
		public string Summary => @"/// <see cref=""Power"">Power</see> was <b>DEPRECATED</b> in <i>MTConnect Version 1.1</i>s and was replaced by <see cref=""Availability"">Availability</see> data item type.";

		/// <inheritdoc />
		public string Name => "PowerClass";
		
		/// <inheritdoc />
		public string AccessModifier => "public";
				
		/// <inheritdoc />
		public string Modifier => "";
				
		/// <inheritdoc />
		public string NormativeVersion => "1.0";
				
		/// <inheritdoc />
		public string DeprecatedVersion => "1.1";
		
		/// <inheritdoc />
		public string Generalization => "EAID_8548C620_467A_4f50_9A22_58D84B7E8779";

		public IPropertyList Properties => null;

	}
}