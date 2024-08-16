using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;

namespace Mtconnect.Glossary.IndustrialTerms
{
	/// <summary>
	﻿/// data in the <i>MTConnectDevices Response Document</i> that provides the information required for maintenance and support of the <i>sensor unit</i>.<br/><br />

	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Structure___19_0_3_68e0225_1623664375185_148978_2086">model.mtconnect.org</seealso> for more information.
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public sealed class SensorConfigurationClass : IClass
	{
		/// <inheritdoc />
		public string ReferenceId => "_19_0_3_68e0225_1623664375185_148978_2086";
		
		/// <inheritdoc />
		public string Summary => @"&#10;&#10;&#10;data in the {{term(MTConnectDevices Response Document)}} that provides the information required for maintenance and support of the {{term(sensor unit)}}.&#10;
";

		/// <inheritdoc />
		public string Name => "sensor configuration";
		
		/// <inheritdoc />
		public string AccessModifier => "public";
				
		/// <inheritdoc />
		public string Modifier => "";
				
		/// <inheritdoc />
		public string NormativeVersion => "";
				
		/// <inheritdoc />
		public string DeprecatedVersion => "";
		
		/// <inheritdoc />
		public Type Generalization => null;

		/// <inheritdoc />
		public SensorConfigurationClassProperties Properties { get; } = new SensorConfigurationClassProperties();
        IPropertyList IClass.Properties => Properties;
		public class SensorConfigurationClassProperties : IPropertyList
		{
			/// <inheritdoc />
			public IProperty[] Properties => new IProperty[] {
			};
		};

	}
}