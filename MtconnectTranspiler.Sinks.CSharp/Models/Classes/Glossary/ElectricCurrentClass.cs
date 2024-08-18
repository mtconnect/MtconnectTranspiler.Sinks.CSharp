#pragma warning disable CS0109 // Member does not hide an inherited member; new keyword is not required
#pragma warning disable CS1574 // XML comment has cref attribute that could not be resolved
#pragma warning disable CS1584 // XML comment has syntactically incorrect cref attribute
using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;

namespace Mtconnect.Glossary
{
	/// <summary>﻿rate of flow of electric charge.<br /><br /><br />
	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Structure___19_0_3_68e0225_1623664375158_221113_1985">model.mtconnect.org</seealso> for more information.
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public sealed class ElectricCurrentClass : IClass
	{
		/// <inheritdoc />
		public string ReferenceId => "_19_0_3_68e0225_1623664375158_221113_1985";
		
		/// <inheritdoc />
		public string Summary => @"&#10;&#10;&#10;rate of flow of electric charge.&#10;
";

		/// <inheritdoc />
		public string Name => "electric current";
		
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
		public new ElectricCurrentClassProperties Properties { get; } = new ElectricCurrentClassProperties();
        IPropertyList IClass.Properties => Properties;
		/// <summary>
		/// Property list for <see cref="ElectricCurrentClass" />.
		/// </summary>
		public class ElectricCurrentClassProperties : IPropertyList
		{
			/// <inheritdoc />
			public IProperty[] Properties => new IProperty[] {
			};
		};

	}
}