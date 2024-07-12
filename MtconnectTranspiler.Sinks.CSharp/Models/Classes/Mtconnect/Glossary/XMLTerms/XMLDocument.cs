
using System;
using System.CodeDom.Compiler;


namespace Mtconnect.Glossary.XMLTerms
{
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "1.0.15.3")]
	public sealed class XMLDocumentClass
	{
		/// <inheritdoc cref="Class.ReferenceId" />
		public string ReferenceId => "_19_0_3_68e0225_1623669632303_353398_16887";
		
		/// <inheritdoc cref="Class.Name" />
		public string Name => "XMLDocument";
		
		/// <inheritdoc cref="Class.AccessModifier" />
		public string AccessModifier => "public";
				
		/// <inheritdoc cref="Class.Modifier" />
		public string Modifier => "";
				
		/// <inheritdoc cref="Class.NormativeVersion" />
		public string NormativeVersion => "";
				
		/// <inheritdoc cref="Class.DeprecatedVersion" />
		public string DeprecatedVersion => "";

		public string Generalization => "";

		public XMLDocumentProperties Properties { get; } = new XMLDocumentProperties();
		public sealed class XMLDocumentProperties
		{
		
		
			/// <remarks>Original Name: HasDocumentHeader</remarks>
			public HasDocumentHeaderProperty HasDocumentHeader { get; } = new HasDocumentHeaderProperty();
			public sealed class HasDocumentHeaderProperty
			{
				/// <inheritdoc cref="Property.Type" />
				/// Original Type: _19_0_3_68e0225_1623664375157_278948_1984
				public Type Type => typeof(DocumentHeaderClass);
				
				/// <inheritdoc cref="Property.Name" />
				public string Name => "HasDocumentHeader";
				
				/// <inheritdoc cref="Property.AccessModifier" />
				public string AccessModifier => "private";
				
				/// <inheritdoc cref="Property.Modifier" />
				public string Modifier => "";
				
				/// <inheritdoc cref="Property.NormativeVersion" />
				public string NormativeVersion => "";
				
				/// <inheritdoc cref="Property.DeprecatedVersion" />
				public string DeprecatedVersion => "";
				
				public string Aggregation => "";

				// Note: Extension.Extender
				public string Extension => "MagicDraw UML 19.0";

				public string Association => "";

				// Note: DefaultValue.Name
				public string DefaultValue => "";

				// TODO: Add Summary
			}
		
		
			/// <remarks>Original Name: HasDocumentBody</remarks>
			public HasDocumentBodyProperty HasDocumentBody { get; } = new HasDocumentBodyProperty();
			public sealed class HasDocumentBodyProperty
			{
				/// <inheritdoc cref="Property.Type" />
				/// Original Type: _19_0_3_68e0225_1623664375156_434194_1983
				public Type Type => typeof(DocumentBodyClass);
				
				/// <inheritdoc cref="Property.Name" />
				public string Name => "HasDocumentBody";
				
				/// <inheritdoc cref="Property.AccessModifier" />
				public string AccessModifier => "private";
				
				/// <inheritdoc cref="Property.Modifier" />
				public string Modifier => "";
				
				/// <inheritdoc cref="Property.NormativeVersion" />
				public string NormativeVersion => "";
				
				/// <inheritdoc cref="Property.DeprecatedVersion" />
				public string DeprecatedVersion => "";
				
				public string Aggregation => "";

				// Note: Extension.Extender
				public string Extension => "MagicDraw UML 19.0";

				public string Association => "";

				// Note: DefaultValue.Name
				public string DefaultValue => "";

				// TODO: Add Summary
			}
		
		
			/// <remarks>Original Name: HasNamespace</remarks>
			public HasNamespaceProperty HasNamespace { get; } = new HasNamespaceProperty();
			public sealed class HasNamespaceProperty
			{
				/// <inheritdoc cref="Property.Type" />
				/// Original Type: _19_0_3_68e0225_1623664375175_916630_2047
				public Type Type => typeof(NamespaceClass);
				
				/// <inheritdoc cref="Property.Name" />
				public string Name => "HasNamespace";
				
				/// <inheritdoc cref="Property.AccessModifier" />
				public string AccessModifier => "private";
				
				/// <inheritdoc cref="Property.Modifier" />
				public string Modifier => "";
				
				/// <inheritdoc cref="Property.NormativeVersion" />
				public string NormativeVersion => "";
				
				/// <inheritdoc cref="Property.DeprecatedVersion" />
				public string DeprecatedVersion => "";
				
				public string Aggregation => "";

				// Note: Extension.Extender
				public string Extension => "MagicDraw UML 19.0";

				public string Association => "";

				// Note: DefaultValue.Name
				public string DefaultValue => "";

				// TODO: Add Summary
			}
		
		
			/// <remarks>Original Name: HasXmlSchema</remarks>
			public HasXmlSchemaProperty HasXmlSchema { get; } = new HasXmlSchemaProperty();
			public sealed class HasXmlSchemaProperty
			{
				/// <inheritdoc cref="Property.Type" />
				/// Original Type: _19_0_3_68e0225_1623664375192_452303_2110
				public Type Type => typeof(XMLSchemaClass);
				
				/// <inheritdoc cref="Property.Name" />
				public string Name => "HasXmlSchema";
				
				/// <inheritdoc cref="Property.AccessModifier" />
				public string AccessModifier => "private";
				
				/// <inheritdoc cref="Property.Modifier" />
				public string Modifier => "";
				
				/// <inheritdoc cref="Property.NormativeVersion" />
				public string NormativeVersion => "";
				
				/// <inheritdoc cref="Property.DeprecatedVersion" />
				public string DeprecatedVersion => "";
				
				public string Aggregation => "";

				// Note: Extension.Extender
				public string Extension => "MagicDraw UML 19.0";

				public string Association => "";

				// Note: DefaultValue.Name
				public string DefaultValue => "";

				// TODO: Add Summary
			}
		};

	}
}