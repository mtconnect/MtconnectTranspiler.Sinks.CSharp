using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;

namespace Mtconnect.Glossary.XMLTerms
{
	/// <summary>
	/// portion of the content of an <i>MTConnect Response Document</i> that is defined by the relative <i>MTConnect Information Model</i>. The <i>document body</i> contains the <i>structural element</i>s and <i>Observation</i>s or <i>DataItem</i>s reported in a <i>response document</i>. 
	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Structure___19_0_3_68e0225_1623664375156_434194_1983">model.mtconnect.org</seealso> for more information.
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.3.0.0")]
	public sealed class DocumentBodyClass : IClass
	{
		/// <inheritdoc />
		public string ReferenceId => "_19_0_3_68e0225_1623664375156_434194_1983";
		
		/// <inheritdoc />
		public string Summary => @"/// portion of the content of an <i>MTConnect Response Document</i> that is defined by the relative <i>MTConnect Information Model</i>. The <i>document body</i> contains the <i>structural element</i>s and <i>Observation</i>s or <i>DataItem</i>s reported in a <i>response document</i>. ";

		/// <inheritdoc />
		public string Name => "document body";
		
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
		public DocumentBodyClassProperties Properties { get; } = new DocumentBodyClassProperties();
        IPropertyList IClass.Properties => Properties;
		public class DocumentBodyClassProperties : IPropertyList
		{
			/// <inheritdoc />
			public IProperty[] Properties => new IProperty[] {
			};
		};

	}
}