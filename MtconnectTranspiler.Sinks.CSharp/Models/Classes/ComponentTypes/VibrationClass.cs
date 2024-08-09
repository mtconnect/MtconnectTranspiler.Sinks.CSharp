using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;
using System.Linq;

namespace Mtconnect.DeviceInformationModel.Components.ComponentTypes
{
	/// <summary>
	/// <see cref="Component">Component</see> composed of a sensor or an instrument that measures the amount and/or frequency of vibration within a system.  <see cref="Vibration">Vibration</see> was <b>DEPRECATED</b> in <i>MTConnect Version 1.2</i>s and was replaced by <see cref="Displacement">Displacement</see>, <see cref="Frequency">Frequency</see> etc.
	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Structure___19_0_4_45f01b9_1643678730400_947692_1640">model.mtconnect.org</seealso> for more information.
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.3.0.0")]
	public sealed class VibrationClass : IClass
	{
		/// <inheritdoc />
		public string ReferenceId => "_19_0_4_45f01b9_1643678730400_947692_1640";
		
		/// <inheritdoc />
		public string Summary => @"/// <see cref=""Component"">Component</see> composed of a sensor or an instrument that measures the amount and/or frequency of vibration within a system.  <see cref=""Vibration"">Vibration</see> was <b>DEPRECATED</b> in <i>MTConnect Version 1.2</i>s and was replaced by <see cref=""Displacement"">Displacement</see>, <see cref=""Frequency"">Frequency</see> etc.";

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
		public VibrationClassProperties Properties { get; } = new VibrationClassProperties();
        IPropertyList IClass.Properties => Properties;
		public class VibrationClassProperties : Mtconnect.DeviceInformationModel.Components.ComponentTypes.SensorClass.SensorClassProperties
		{
			/// <inheritdoc />
			public IProperty[] Properties => new IProperty[] {
			}.Concat(base.Properties).ToArray();
		};

	}
}