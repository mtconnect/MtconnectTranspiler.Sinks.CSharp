#pragma warning disable CS0109 // Member does not hide an inherited member; new keyword is not required
#pragma warning disable CS1574 // XML comment has cref attribute that could not be resolved
#pragma warning disable CS1584 // XML comment has syntactically incorrect cref attribute
using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;
using System.Linq;

namespace Mtconnect.Glossary.XMLTerms
{
	/// <summary>﻿structured text file encoded using <i>XML</i>.<br /><br /><br />
	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Structure___19_0_3_68e0225_1623669632303_353398_16887">model.mtconnect.org</seealso> for more information.
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public sealed class XMLDocumentGeneralization : IClass
	{
		/// <inheritdoc />
		public string ReferenceId => "_19_0_3_68e0225_1623669632303_353398_16887";
		
		/// <inheritdoc />
		public string Summary => @"&#10;&#10;&#10;structured text file encoded using {{term(XML)}}.&#10;
";

		/// <inheritdoc />
		public string Name => "XML Document";
		
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
		/// Original Type: _19_0_3_68e0225_1623664375156_660396_1982
		/// </remarks>
		public Type Generalization => typeof(Mtconnect.Glossary.DocumentClass);

		/// <inheritdoc />
		public new XMLDocumentGeneralizationProperties Properties { get; } = new XMLDocumentGeneralizationProperties();
        IPropertyList IClass.Properties => Properties;
		/// <summary>
		/// Property list for <see cref="XMLDocumentGeneralization" />.
		/// <br/><b>Note</b>, some properties (<see cref="IProperty" />) are inherited from <see cref="Mtconnect.Glossary.DocumentClass.DocumentClassProperties" />.
		/// </summary>
		public class XMLDocumentGeneralizationProperties : Mtconnect.Glossary.DocumentClass.DocumentClassProperties
		{
			/// <inheritdoc />
			public override IProperty[] Properties => new IProperty[] {
				HasDocumentHeader,
				HasDocumentBody,
				HasNamespace,
				HasXmlSchema,
			}.Concat(base.Properties).ToArray();
			/// <summary>
			/// <inheritdoc cref="HasDocumentHeaderProperty" path="/summary" /><br/>
			/// <remarks>Original Name: HasDocumentHeader</remarks>
			/// </summary>
			public new HasDocumentHeaderProperty HasDocumentHeader { get; } = new HasDocumentHeaderProperty();
			
			/// <summary>﻿
			/// </summary>
			public new sealed class HasDocumentHeaderProperty : IProperty
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
				public string Name => "has document header";
				
				/// <inheritdoc />
				public string Summary => @"";

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
			}
			/// <summary>
			/// <inheritdoc cref="HasDocumentBodyProperty" path="/summary" /><br/>
			/// <remarks>Original Name: HasDocumentBody</remarks>
			/// </summary>
			public new HasDocumentBodyProperty HasDocumentBody { get; } = new HasDocumentBodyProperty();
			
			/// <summary>﻿
			/// </summary>
			public new sealed class HasDocumentBodyProperty : IProperty
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
				public string Name => "has document body";
				
				/// <inheritdoc />
				public string Summary => @"";

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
			}
			/// <summary>
			/// <inheritdoc cref="HasNamespaceProperty" path="/summary" /><br/>
			/// <remarks>Original Name: HasNamespace</remarks>
			/// </summary>
			public new HasNamespaceProperty HasNamespace { get; } = new HasNamespaceProperty();
			
			/// <summary>﻿
			/// </summary>
			public new sealed class HasNamespaceProperty : IProperty
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
				public string Name => "has namespace";
				
				/// <inheritdoc />
				public string Summary => @"";

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
			}
			/// <summary>
			/// <inheritdoc cref="HasXmlSchemaProperty" path="/summary" /><br/>
			/// <remarks>Original Name: HasXmlSchema</remarks>
			/// </summary>
			public new HasXmlSchemaProperty HasXmlSchema { get; } = new HasXmlSchemaProperty();
			
			/// <summary>﻿
			/// </summary>
			public new sealed class HasXmlSchemaProperty : IProperty
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
				public string Name => "has xml schema";
				
				/// <inheritdoc />
				public string Summary => @"";

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
			}
		};

	}
}