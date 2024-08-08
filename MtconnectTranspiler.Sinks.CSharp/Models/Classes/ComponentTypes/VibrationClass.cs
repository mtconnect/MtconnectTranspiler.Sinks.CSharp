using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;

namespace Mtconnect.DeviceInformationModel.Components.ComponentTypes
{
	/// <summary>
	/// <see cref="Component">Component</see> composed of a sensor or an instrument that measures the amount and/or frequency of vibration within a system.  <see cref="Vibration">Vibration</see> was <b>DEPRECATED</b> in <i>MTConnect Version 1.2</i>s and was replaced by <see cref="Displacement">Displacement</see>, <see cref="Frequency">Frequency</see> etc.
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.3.0.0")]
	public sealed class VibrationClass : IClass
	{
		/// <inheritdoc />
		public string ReferenceId => "_19_0_4_45f01b9_1643678730400_947692_1640";
		
		/// <inheritdoc />
		public string Summary => @"/// <see cref=""Component"">Component</see> composed of a sensor or an instrument that measures the amount and/or frequency of vibration within a system.  <see cref=""Vibration"">Vibration</see> was <b>DEPRECATED</b> in <i>MTConnect Version 1.2</i>s and was replaced by <see cref=""Displacement"">Displacement</see>, <see cref=""Frequency"">Frequency</see> etc.";

		/// <inheritdoc />
		public string Name => "VibrationClass";
		
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