using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;

namespace Mtconnect.DeviceInformationModel.Components.ComponentTypes
{
	/// <summary>
	/// <see cref="Component">Component</see> composed of a sensor or an instrument that measures temperature.  <see cref="Thermostat">Thermostat</see> was <b>DEPRECATED</b> in <i>MTConnect Version 1.2</i>s and was replaced by <see cref="Temperature">Temperature</see>.
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.3.0.0")]
	public sealed class ThermostatClass : IClass
	{
		/// <inheritdoc />
		public string ReferenceId => "_19_0_4_45f01b9_1643678703742_369144_1539";
		
		/// <inheritdoc />
		public string Summary => @"/// <see cref=""Component"">Component</see> composed of a sensor or an instrument that measures temperature.  <see cref=""Thermostat"">Thermostat</see> was <b>DEPRECATED</b> in <i>MTConnect Version 1.2</i>s and was replaced by <see cref=""Temperature"">Temperature</see>.";

		/// <inheritdoc />
		public string Name => "ThermostatClass";
		
		/// <inheritdoc />
		public string AccessModifier => "public";
				
		/// <inheritdoc />
		public string Modifier => "";
				
		/// <inheritdoc />
		public string NormativeVersion => "1.0";
				
		/// <inheritdoc />
		public string DeprecatedVersion => "1.2";
		
		/// <inheritdoc />
		public string Generalization => "_19_0_3_45f01b9_1579572382017_874684_42291";

		public IPropertyList Properties => null;

	}
}