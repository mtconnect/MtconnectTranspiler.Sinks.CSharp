using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;

namespace Mtconnect.Glossary
{
	/// <summary>
	﻿/// ability for an implementer to extend <i>MTConnect Information Model</i> by adding content not currently addressed in the MTConnect Standard.<br /><br/><br />

	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Structure___19_0_3_68e0225_1623664375160_631627_1992">model.mtconnect.org</seealso> for more information.
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public sealed class ExtensibleClass : IClass
	{
		/// <inheritdoc />
		public string ReferenceId => "_19_0_3_68e0225_1623664375160_631627_1992";
		
		/// <inheritdoc />
		public string Summary => @"&#10;&#10;&#10;ability for an implementer to extend {{term(MTConnect Information Model)}} by adding content not currently addressed in the MTConnect Standard.
&#10;
";

		/// <inheritdoc />
		public string Name => "extensible";
		
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
		public ExtensibleClassProperties Properties { get; } = new ExtensibleClassProperties();
        IPropertyList IClass.Properties => Properties;
		public class ExtensibleClassProperties : IPropertyList
		{
			/// <inheritdoc />
			public IProperty[] Properties => new IProperty[] {
			};
		};

	}
}