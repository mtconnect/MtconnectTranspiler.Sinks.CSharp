using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;
// using Mtconnect.Glossary.XMLTerms;

namespace Mtconnect.Glossary.XMLTerms
{
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "1.0.15.3")]
	public sealed class XMLDocumentGeneralization : IClass
	{
		/// <inheritdoc />
		public string ReferenceId => "_19_0_3_68e0225_1623669632303_353398_16887";
		
		/// <inheritdoc />
		public string Name => "XMLDocumentGeneralization";
		
		/// <inheritdoc />
		public string AccessModifier => "public";
				
		/// <inheritdoc />
		public string Modifier => "";
				
		/// <inheritdoc />
		public string NormativeVersion => "";
				
		/// <inheritdoc />
		public string DeprecatedVersion => "";
		
		/// <inheritdoc />
		public string Generalization => "_19_0_3_68e0225_1623664375156_660396_1982";

		/// <inheritdoc />
		public XMLDocumentGeneralizationProperties Properties { get; } = new XMLDocumentGeneralizationProperties();
        IPropertyList IClass.Properties => Properties;
		public sealed class XMLDocumentGeneralizationProperties : IPropertyList
		{
			/// <inheritdoc />
			public IProperty[] Properties => new IProperty[] {
				HasDocumentHeader,
				HasDocumentBody,
				HasNamespace,
				HasXmlSchema,
			};
			/// <remarks>Original Name: HasDocumentHeader</remarks>
			public HasDocumentHeaderProperty HasDocumentHeader { get; } = new HasDocumentHeaderProperty();
			public sealed class HasDocumentHeaderProperty : IProperty
			{
				/// <summary>
				/// <inheritdoc />
				/// <remarks>
				/// <list type="bullet">
				/// <item>Original Type: _19_0_3_68e0225_1623664375157_278948_1984</item>
				/// <item>Type: DocumentHeaderClass</item>
				/// <item>Namespace: Mtconnect.Glossary.XMLTerms</item>
				/// </list>
				/// </remarks>
				/// </summary>
				public System.Type Type => typeof(Mtconnect.Glossary.XMLTerms.DocumentHeaderClass);
				
				/// <inheritdoc />
				public string Name => "HasDocumentHeader";
				
				/// <inheritdoc />
				public string AccessModifier => "private";
				
				/// <inheritdoc />
				public string Modifier => "";
				
				/// <inheritdoc />
				public string NormativeVersion => "";
				
				/// <inheritdoc />
				public string DeprecatedVersion => "";
				
				/// <inheritdoc />
				public string Aggregation => "";

				// Note: Extension.Extender
				/// <inheritdoc />
				public string Extension => "MagicDraw UML 19.0";
				
				/// <inheritdoc />
				public string Association => "";

				// Note: DefaultValue.Name
				/// <inheritdoc />
				public string DefaultValue => "";

				// TODO: Add Summary
			}
			/// <remarks>Original Name: HasDocumentBody</remarks>
			public HasDocumentBodyProperty HasDocumentBody { get; } = new HasDocumentBodyProperty();
			public sealed class HasDocumentBodyProperty : IProperty
			{
				/// <summary>
				/// <inheritdoc />
				/// <remarks>
				/// <list type="bullet">
				/// <item>Original Type: _19_0_3_68e0225_1623664375156_434194_1983</item>
				/// <item>Type: DocumentBodyClass</item>
				/// <item>Namespace: Mtconnect.Glossary.XMLTerms</item>
				/// </list>
				/// </remarks>
				/// </summary>
				public System.Type Type => typeof(Mtconnect.Glossary.XMLTerms.DocumentBodyClass);
				
				/// <inheritdoc />
				public string Name => "HasDocumentBody";
				
				/// <inheritdoc />
				public string AccessModifier => "private";
				
				/// <inheritdoc />
				public string Modifier => "";
				
				/// <inheritdoc />
				public string NormativeVersion => "";
				
				/// <inheritdoc />
				public string DeprecatedVersion => "";
				
				/// <inheritdoc />
				public string Aggregation => "";

				// Note: Extension.Extender
				/// <inheritdoc />
				public string Extension => "MagicDraw UML 19.0";
				
				/// <inheritdoc />
				public string Association => "";

				// Note: DefaultValue.Name
				/// <inheritdoc />
				public string DefaultValue => "";

				// TODO: Add Summary
			}
			/// <remarks>Original Name: HasNamespace</remarks>
			public HasNamespaceProperty HasNamespace { get; } = new HasNamespaceProperty();
			public sealed class HasNamespaceProperty : IProperty
			{
				/// <summary>
				/// <inheritdoc />
				/// <remarks>
				/// <list type="bullet">
				/// <item>Original Type: _19_0_3_68e0225_1623664375175_916630_2047</item>
				/// <item>Type: NamespaceClass</item>
				/// <item>Namespace: Mtconnect.Glossary.XMLTerms</item>
				/// </list>
				/// </remarks>
				/// </summary>
				public System.Type Type => typeof(Mtconnect.Glossary.XMLTerms.NamespaceClass);
				
				/// <inheritdoc />
				public string Name => "HasNamespace";
				
				/// <inheritdoc />
				public string AccessModifier => "private";
				
				/// <inheritdoc />
				public string Modifier => "";
				
				/// <inheritdoc />
				public string NormativeVersion => "";
				
				/// <inheritdoc />
				public string DeprecatedVersion => "";
				
				/// <inheritdoc />
				public string Aggregation => "";

				// Note: Extension.Extender
				/// <inheritdoc />
				public string Extension => "MagicDraw UML 19.0";
				
				/// <inheritdoc />
				public string Association => "";

				// Note: DefaultValue.Name
				/// <inheritdoc />
				public string DefaultValue => "";

				// TODO: Add Summary
			}
			/// <remarks>Original Name: HasXmlSchema</remarks>
			public HasXmlSchemaProperty HasXmlSchema { get; } = new HasXmlSchemaProperty();
			public sealed class HasXmlSchemaProperty : IProperty
			{
				/// <summary>
				/// <inheritdoc />
				/// <remarks>
				/// <list type="bullet">
				/// <item>Original Type: _19_0_3_68e0225_1623664375192_452303_2110</item>
				/// <item>Type: XMLSchemaGeneralization</item>
				/// <item>Namespace: Mtconnect.Glossary.XMLTerms</item>
				/// </list>
				/// </remarks>
				/// </summary>
				public System.Type Type => typeof(Mtconnect.Glossary.XMLTerms.XMLSchemaGeneralization);
				
				/// <inheritdoc />
				public string Name => "HasXmlSchema";
				
				/// <inheritdoc />
				public string AccessModifier => "private";
				
				/// <inheritdoc />
				public string Modifier => "";
				
				/// <inheritdoc />
				public string NormativeVersion => "";
				
				/// <inheritdoc />
				public string DeprecatedVersion => "";
				
				/// <inheritdoc />
				public string Aggregation => "";

				// Note: Extension.Extender
				/// <inheritdoc />
				public string Extension => "MagicDraw UML 19.0";
				
				/// <inheritdoc />
				public string Association => "";

				// Note: DefaultValue.Name
				/// <inheritdoc />
				public string DefaultValue => "";

				// TODO: Add Summary
			}
		};

	}
}