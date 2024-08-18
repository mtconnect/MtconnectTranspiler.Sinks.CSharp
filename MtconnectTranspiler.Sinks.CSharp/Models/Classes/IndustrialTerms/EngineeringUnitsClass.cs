#pragma warning disable CS0109 // Member does not hide an inherited member; new keyword is not required
#pragma warning disable CS1574 // XML comment has cref attribute that could not be resolved
#pragma warning disable CS1584 // XML comment has syntactically incorrect cref attribute
using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;

namespace Mtconnect.Glossary.IndustrialTerms
{
	/// <summary>﻿quantity, dimension, or magnitude used in engineering adopted as a standard in terms of which the magnitude of other quantities of the same kind can be expressed or calculated.<br /><br /><br />
	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Structure___19_0_3_68e0225_1623664375158_68411_1987">model.mtconnect.org</seealso> for more information.
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public sealed class EngineeringUnitsClass : IClass
	{
		/// <inheritdoc />
		public string ReferenceId => "_19_0_3_68e0225_1623664375158_68411_1987";
		
		/// <inheritdoc />
		public string Summary => @"&#10;&#10;&#10;quantity, dimension, or magnitude used in engineering adopted as a standard in terms of which the magnitude of other quantities of the same kind can be expressed or calculated.&#10;
";

		/// <inheritdoc />
		public string Name => "engineering units";
		
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
		public new EngineeringUnitsClassProperties Properties { get; } = new EngineeringUnitsClassProperties();
        IPropertyList IClass.Properties => Properties;
		/// <summary>
		/// Property list for <see cref="EngineeringUnitsClass" />.
		/// </summary>
		public class EngineeringUnitsClassProperties : IPropertyList
		{
			/// <inheritdoc />
			public IProperty[] Properties => new IProperty[] {
			};
		};

	}
}