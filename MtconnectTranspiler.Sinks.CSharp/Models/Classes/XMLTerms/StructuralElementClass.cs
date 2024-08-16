using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;

namespace Mtconnect.Glossary.XMLTerms
{
	/// <summary>
	﻿/// <i>element</i> that organizes information that represents the physical and logical parts and sub-parts of a piece of equipment.<br/><br />

	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Structure___19_0_3_68e0225_1623664375187_474833_2095">model.mtconnect.org</seealso> for more information.
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public sealed class StructuralElementClass : IClass
	{
		/// <inheritdoc />
		public string ReferenceId => "_19_0_3_68e0225_1623664375187_474833_2095";
		
		/// <inheritdoc />
		public string Summary => @"&#10;&#10;&#10;{{term(element)}} that organizes information that represents the physical and logical parts and sub-parts of a piece of equipment.&#10;
";

		/// <inheritdoc />
		public string Name => "structural element";
		
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
		public StructuralElementClassProperties Properties { get; } = new StructuralElementClassProperties();
        IPropertyList IClass.Properties => Properties;
		public class StructuralElementClassProperties : IPropertyList
		{
			/// <inheritdoc />
			public IProperty[] Properties => new IProperty[] {
			};
		};

	}
}