using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;

namespace Mtconnect.Glossary.IndustrialTerms
{
	/// <summary>
	﻿/// represents anything that can publish information and is used in the operations of a manufacturing facility shop floor.  <br /><br />> Note: Examples include machine tools, ovens, sensor units, workstations, software applications, and bar feeders.<br /><br /><br/><br />

	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Structure___19_0_3_68e0225_1623664375158_659038_1988">model.mtconnect.org</seealso> for more information.
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public sealed class EquipmentClass : IClass
	{
		/// <inheritdoc />
		public string ReferenceId => "_19_0_3_68e0225_1623664375158_659038_1988";
		
		/// <inheritdoc />
		public string Summary => @"&#10;&#10;&#10;represents anything that can publish information and is used in the operations of a manufacturing facility shop floor.  

> Note: Examples include machine tools, ovens, sensor units, workstations, software applications, and bar feeders.

&#10;
";

		/// <inheritdoc />
		public string Name => "equipment";
		
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
		public EquipmentClassProperties Properties { get; } = new EquipmentClassProperties();
        IPropertyList IClass.Properties => Properties;
		public class EquipmentClassProperties : IPropertyList
		{
			/// <inheritdoc />
			public IProperty[] Properties => new IProperty[] {
			};
		};

	}
}