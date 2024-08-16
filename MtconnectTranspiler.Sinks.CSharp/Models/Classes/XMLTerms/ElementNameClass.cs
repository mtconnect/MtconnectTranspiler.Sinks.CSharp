using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;

namespace Mtconnect.Glossary.XMLTerms
{
	/// <summary>
	﻿/// descriptive identifier contained in both the <c>start-tag</c> and <c>end-tag</c> of an XML element that provides the name of the element.<br/><br />

	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Structure___19_0_3_68e0225_1638439875096_861809_26">model.mtconnect.org</seealso> for more information.
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public sealed class ElementNameClass : IClass
	{
		/// <inheritdoc />
		public string ReferenceId => "_19_0_3_68e0225_1638439875096_861809_26";
		
		/// <inheritdoc />
		public string Summary => @"&#10;&#10;&#10;descriptive identifier contained in both the `start-tag` and `end-tag` of an XML element that provides the name of the element.&#10;
";

		/// <inheritdoc />
		public string Name => "element name";
		
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
		public ElementNameClassProperties Properties { get; } = new ElementNameClassProperties();
        IPropertyList IClass.Properties => Properties;
		public class ElementNameClassProperties : IPropertyList
		{
			/// <inheritdoc />
			public IProperty[] Properties => new IProperty[] {
			};
		};

	}
}