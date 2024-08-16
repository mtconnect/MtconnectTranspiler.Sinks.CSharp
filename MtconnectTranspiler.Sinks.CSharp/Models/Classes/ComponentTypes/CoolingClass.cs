using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;
using System.Linq;

namespace Mtconnect.DeviceInformationModel.Components.ComponentTypes
{
	/// <summary>
	﻿/// <see cref="System">System</see> that extracts controlled amounts of heat to achieve a target temperature at a specified cooling rate.<br/><br />Description<br/>> Note: As an example, Energy Extraction Method can be via cooling water pipes running through the chamber.<br/><br/><br />

	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Structure___19_0_3_68e0225_1605117088875_728711_1893">model.mtconnect.org</seealso> for more information.
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public sealed class CoolingClass : IClass
	{
		/// <inheritdoc />
		public string ReferenceId => "_19_0_3_68e0225_1605117088875_728711_1893";
		
		/// <inheritdoc />
		public string Summary => @"&#10;&#10;&#10;{{block(System)}} that extracts controlled amounts of heat to achieve a target temperature at a specified cooling rate.&#10;
&#10;&#10;&#10;Description&#10;&#10;&#10;&#10;> Note: As an example, Energy Extraction Method can be via cooling water pipes running through the chamber.&#10;
";

		/// <inheritdoc />
		public string Name => "Cooling";
		
		/// <inheritdoc />
		public string AccessModifier => "public";
				
		/// <inheritdoc />
		public string Modifier => "";
				
		/// <inheritdoc />
		public string NormativeVersion => "1.7";
				
		/// <inheritdoc />
		public string DeprecatedVersion => "";
		
		/// <inheritdoc />
		/// <remarks>
		/// Original Type: _19_0_3_45f01b9_1579572382020_336298_42297
		/// </remarks>
		public Type Generalization => typeof(Mtconnect.DeviceInformationModel.Components.ComponentTypes.SystemClass);

		/// <inheritdoc />
		public CoolingClassProperties Properties { get; } = new CoolingClassProperties();
        IPropertyList IClass.Properties => Properties;
		public class CoolingClassProperties : Mtconnect.DeviceInformationModel.Components.ComponentTypes.SystemClass.SystemClassProperties
		{
			/// <inheritdoc />
			public IProperty[] Properties => new IProperty[] {
			}.Concat(base.Properties).ToArray();
		};

	}
}