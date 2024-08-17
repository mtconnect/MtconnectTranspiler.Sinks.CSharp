#pragma warning disable CS0109 // Member does not hide an inherited member; new keyword is not required
#pragma warning disable CS1574 // XML comment has cref attribute that could not be resolved
#pragma warning disable CS1584 // XML comment has syntactically incorrect cref attribute
using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;

namespace Mtconnect.Glossary
{
	/// <summary>﻿<i>document</i> established by consensus that provides rules, guidelines, or characteristics for activities or their results.. <seealso href="https://www.google.com/search?q=ISO/IEC Guide 2:2004&btnI=I">ISO/IEC Guide 2:2004</seealso><br /><br /><br />
	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Structure___19_0_3_68e0225_1623664375187_860452_2093">model.mtconnect.org</seealso> for more information.
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public sealed class StandardClass : IClass
	{
		/// <inheritdoc />
		public string ReferenceId => "_19_0_3_68e0225_1623664375187_860452_2093";
		
		/// <inheritdoc />
		public string Summary => @"&#10;&#10;&#10;{{term(document)}} established by consensus that provides rules, guidelines, or characteristics for activities or their results.. {{cite(ISO/IEC Guide 2:2004)}}&#10;
";

		/// <inheritdoc />
		public string Name => "standard";
		
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
		public StandardClassProperties Properties { get; } = new StandardClassProperties();
        IPropertyList IClass.Properties => Properties;
		/// <summary>
		/// Property list for <see cref="StandardClass" />.
		/// </summary>
		public class StandardClassProperties : IPropertyList
		{
			/// <inheritdoc />
			public IProperty[] Properties => new IProperty[] {
			};
		};

	}
}