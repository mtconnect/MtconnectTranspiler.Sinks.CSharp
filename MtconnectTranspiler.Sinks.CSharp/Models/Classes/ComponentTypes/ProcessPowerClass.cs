using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;

namespace Mtconnect.DeviceInformationModel.Components.ComponentTypes
{
	/// <summary>
	/// <see cref="System">System</see> composed of a power source associated with a piece of equipment that supplies energy to the manufacturing process separate from the <see cref="Electric">Electric</see> system./// Description
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.3.0.0")]
	public sealed class ProcessPowerClass : IClass
	{
		/// <inheritdoc />
		public string ReferenceId => "_19_0_3_45f01b9_1579572382012_290973_42279";
		
		/// <inheritdoc />
		public string Summary => @"/// <see cref=""System"">System</see> composed of a power source associated with a piece of equipment that supplies energy to the manufacturing process separate from the <see cref=""Electric"">Electric</see> system./// Description";

		/// <inheritdoc />
		public string Name => "ProcessPowerClass";
		
		/// <inheritdoc />
		public string AccessModifier => "public";
				
		/// <inheritdoc />
		public string Modifier => "";
				
		/// <inheritdoc />
		public string NormativeVersion => "1.4";
				
		/// <inheritdoc />
		public string DeprecatedVersion => "";
		
		/// <inheritdoc />
		public string Generalization => "_19_0_3_45f01b9_1579572382020_336298_42297";

		public IPropertyList Properties => null;

	}
}