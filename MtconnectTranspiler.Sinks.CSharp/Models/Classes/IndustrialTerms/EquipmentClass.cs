using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;

namespace Mtconnect.Glossary.IndustrialTerms
{
	/// <summary>
	/// represents anything that can publish information and is used in the operations of a manufacturing facility shop floor.    > Note: Examples include machine tools, ovens, sensor units, workstations, software applications, and bar feeders.  
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.3.0.0")]
	public sealed class EquipmentClass : IClass
	{
		/// <inheritdoc />
		public string ReferenceId => "_19_0_3_68e0225_1623664375158_659038_1988";
		
		/// <inheritdoc />
		public string Summary => @"/// represents anything that can publish information and is used in the operations of a manufacturing facility shop floor.    > Note: Examples include machine tools, ovens, sensor units, workstations, software applications, and bar feeders.  ";

		/// <inheritdoc />
		public string Name => "EquipmentClass";
		
		/// <inheritdoc />
		public string AccessModifier => "public";
				
		/// <inheritdoc />
		public string Modifier => "";
				
		/// <inheritdoc />
		public string NormativeVersion => "";
				
		/// <inheritdoc />
		public string DeprecatedVersion => "";
		
		/// <inheritdoc />
		public string Generalization => "";

		public IPropertyList Properties => null;

	}
}