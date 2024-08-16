using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;
using System.Linq;

namespace Mtconnect.Glossary.XMLTerms
{
	/// <summary>
	﻿/// <i>schema</i> defining a specific document encoded in XML.<br /><br/><br />

	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Structure___19_0_3_68e0225_1623664375192_452303_2110">model.mtconnect.org</seealso> for more information.
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public sealed class XMLSchemaGeneralization : IClass
	{
		/// <inheritdoc />
		public string ReferenceId => "_19_0_3_68e0225_1623664375192_452303_2110";
		
		/// <inheritdoc />
		public string Summary => @"&#10;&#10;&#10;{{term(schema)}} defining a specific document encoded in XML.
&#10;
";

		/// <inheritdoc />
		public string Name => "XML Schema";
		
		/// <inheritdoc />
		public string AccessModifier => "public";
				
		/// <inheritdoc />
		public string Modifier => "";
				
		/// <inheritdoc />
		public string NormativeVersion => "";
				
		/// <inheritdoc />
		public string DeprecatedVersion => "";
		
		/// <inheritdoc />
		/// <remarks>
		/// Original Type: _19_0_3_68e0225_1623664375184_91838_2082
		/// </remarks>
		public Type Generalization => typeof(Mtconnect.Glossary.SchemaClass);

		/// <inheritdoc />
		public XMLSchemaGeneralizationProperties Properties { get; } = new XMLSchemaGeneralizationProperties();
        IPropertyList IClass.Properties => Properties;
		public class XMLSchemaGeneralizationProperties : Mtconnect.Glossary.SchemaClass.SchemaClassProperties
		{
			/// <inheritdoc />
			public IProperty[] Properties => new IProperty[] {
			}.Concat(base.Properties).ToArray();
		};

	}
}