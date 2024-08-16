using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;
using System.Linq;

namespace Mtconnect.DeviceInformationModel.Components.ComponentTypes
{
	/// <summary>
	﻿/// <see cref="System">System</see> composed of a power source associated with a piece of equipment that supplies energy to the manufacturing process separate from the <see cref="Electric">Electric</see> system.<br/><br />Description<br/>For example, this could be the power source for an EDM machining process, an electroplating line, or a welding system.<br/><br/><br />

	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Structure___19_0_3_45f01b9_1579572382012_290973_42279">model.mtconnect.org</seealso> for more information.
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public sealed class ProcessPowerClass : IClass
	{
		/// <inheritdoc />
		public string ReferenceId => "_19_0_3_45f01b9_1579572382012_290973_42279";
		
		/// <inheritdoc />
		public string Summary => @"&#10;&#10;&#10;{{block(System)}} composed of a power source associated with a piece of equipment that supplies energy to the manufacturing process separate from the {{block(Electric)}} system.&#10;
&#10;&#10;&#10;Description&#10;&#10;&#10;&#10;For example, this could be the power source for an EDM machining process, an electroplating line, or a welding system.&#10;
";

		/// <inheritdoc />
		public string Name => "ProcessPower";
		
		/// <inheritdoc />
		public string AccessModifier => "public";
				
		/// <inheritdoc />
		public string Modifier => "";
				
		/// <inheritdoc />
		public string NormativeVersion => "1.4";
				
		/// <inheritdoc />
		public string DeprecatedVersion => "";
		
		/// <inheritdoc />
		/// <remarks>
		/// Original Type: _19_0_3_45f01b9_1579572382020_336298_42297
		/// </remarks>
		public Type Generalization => typeof(Mtconnect.DeviceInformationModel.Components.ComponentTypes.SystemClass);

		/// <inheritdoc />
		public ProcessPowerClassProperties Properties { get; } = new ProcessPowerClassProperties();
        IPropertyList IClass.Properties => Properties;
		public class ProcessPowerClassProperties : Mtconnect.DeviceInformationModel.Components.ComponentTypes.SystemClass.SystemClassProperties
		{
			/// <inheritdoc />
			public IProperty[] Properties => new IProperty[] {
			}.Concat(base.Properties).ToArray();
		};

	}
}