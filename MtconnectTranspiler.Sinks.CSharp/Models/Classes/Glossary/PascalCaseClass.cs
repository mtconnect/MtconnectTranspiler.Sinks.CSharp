using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;

namespace Mtconnect.Glossary
{
	/// <summary>
	﻿/// first letter of each word is capitalized and the remaining letters are in lowercase. All space is removed between letters<br/><br />

	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Structure___19_0_3_68e0225_1623664375178_26853_2060">model.mtconnect.org</seealso> for more information.
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public sealed class PascalCaseClass : IClass
	{
		/// <inheritdoc />
		public string ReferenceId => "_19_0_3_68e0225_1623664375178_26853_2060";
		
		/// <inheritdoc />
		public string Summary => @"&#10;&#10;&#10;first letter of each word is capitalized and the remaining letters are in lowercase. All space is removed between letters&#10;
";

		/// <inheritdoc />
		public string Name => "pascal case";
		
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
		public PascalCaseClassProperties Properties { get; } = new PascalCaseClassProperties();
        IPropertyList IClass.Properties => Properties;
		public class PascalCaseClassProperties : IPropertyList
		{
			/// <inheritdoc />
			public IProperty[] Properties => new IProperty[] {
			};
		};

	}
}