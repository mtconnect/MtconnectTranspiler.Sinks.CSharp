#pragma warning disable CS0109 // Member does not hide an inherited member; new keyword is not required
#pragma warning disable CS1574 // XML comment has cref attribute that could not be resolved
#pragma warning disable CS1584 // XML comment has syntactically incorrect cref attribute
using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;
using System.Linq;

namespace Mtconnect.DeviceInformationModel.Components.ComponentTypes
{
	/// <summary>﻿<see cref="Component">Component</see> composed of a sensor or an instrument that measures the amount and/or frequency of vibration within a system.<br /><br /><see cref="Vibration">Vibration</see> was <b>DEPRECATED</b> in <i>MTConnect Version 1.2</i> and was replaced by <see cref="Displacement">Displacement</see>, <see cref="Frequency">Frequency</see> etc.<br /><br /><br />
	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Structure___19_0_4_45f01b9_1643678730400_947692_1640">model.mtconnect.org</seealso> for more information.
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public sealed class VibrationClass : IClass
	{
		/// <inheritdoc />
		public string ReferenceId => "_19_0_4_45f01b9_1643678730400_947692_1640";
		
		/// <inheritdoc />
		public string Summary => @"&#10;&#10;&#10;{{block(Component)}} composed of a sensor or an instrument that measures the amount and/or frequency of vibration within a system.

{{block(Vibration)}} was **DEPRECATED** in *MTConnect Version 1.2* and was replaced by {{block(Displacement)}}, {{block(Frequency)}} etc.&#10;
";

		/// <inheritdoc />
		public string Name => "Vibration";
		
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
		public new VibrationClassProperties Properties { get; } = new VibrationClassProperties();
        IPropertyList IClass.Properties => Properties;
		/// <summary>
		/// Property list for <see cref="VibrationClass" />.
		/// <br/><b>Note</b>, some properties (<see cref="IProperty" />) are inherited from <see cref="Mtconnect.DeviceInformationModel.Components.ComponentTypes.SensorClass.SensorClassProperties" />.
		/// </summary>
		public class VibrationClassProperties : Mtconnect.DeviceInformationModel.Components.ComponentTypes.SensorClass.SensorClassProperties
		{
			/// <inheritdoc />
			public override IProperty[] Properties => new IProperty[] {
			}.Concat(base.Properties).ToArray();
		};

	}
}