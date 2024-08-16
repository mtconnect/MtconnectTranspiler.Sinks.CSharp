using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;
using System.Linq;

namespace Mtconnect.DeviceInformationModel.Components.ComponentTypes
{
	/// <summary>
	﻿/// <see cref="Component">Component</see> composed of a sensor or an instrument that measures temperature.<br /><br /><see cref="Thermostat">Thermostat</see> was <b>DEPRECATED</b> in <i>MTConnect Version 1.2</i> and was replaced by <see cref="Temperature">Temperature</see>.<br/><br />

	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Structure___19_0_4_45f01b9_1643678703742_369144_1539">model.mtconnect.org</seealso> for more information.
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public sealed class ThermostatClass : IClass
	{
		/// <inheritdoc />
		public string ReferenceId => "_19_0_4_45f01b9_1643678703742_369144_1539";
		
		/// <inheritdoc />
		public string Summary => @"&#10;&#10;&#10;{{block(Component)}} composed of a sensor or an instrument that measures temperature.

{{block(Thermostat)}} was **DEPRECATED** in *MTConnect Version 1.2* and was replaced by {{block(Temperature)}}.&#10;
";

		/// <inheritdoc />
		public string Name => "Thermostat";
		
		/// <inheritdoc />
		public string AccessModifier => "public";
				
		/// <inheritdoc />
		public string Modifier => "";
				
		/// <inheritdoc />
		public string NormativeVersion => "1.0";
				
		/// <inheritdoc />
		public string DeprecatedVersion => "1.2";
		
		/// <inheritdoc />
		/// <remarks>
		/// Original Type: _19_0_3_45f01b9_1579572382017_874684_42291
		/// </remarks>
		public Type Generalization => typeof(Mtconnect.DeviceInformationModel.Components.ComponentTypes.SensorClass);

		/// <inheritdoc />
		public ThermostatClassProperties Properties { get; } = new ThermostatClassProperties();
        IPropertyList IClass.Properties => Properties;
		public class ThermostatClassProperties : Mtconnect.DeviceInformationModel.Components.ComponentTypes.SensorClass.SensorClassProperties
		{
			/// <inheritdoc />
			public IProperty[] Properties => new IProperty[] {
			}.Concat(base.Properties).ToArray();
		};

	}
}