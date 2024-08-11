using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;

namespace Mtconnect.Glossary
{
	/// <summary>
	/// subdivision of a <i>table</i> containing a set of <i>key-value pair</i>s representing <i>table cell</i>s.
	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Structure___19_0_3_68e0225_1623664375189_248272_2100">model.mtconnect.org</seealso> for more information.
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.3.0.0")]
	public sealed class TableEntryClass : IClass
	{
		/// <inheritdoc />
		public string ReferenceId => "_19_0_3_68e0225_1623664375189_248272_2100";
		
		/// <inheritdoc />
		public string Summary => @"/// subdivision of a <i>table</i> containing a set of <i>key-value pair</i>s representing <i>table cell</i>s.";

		/// <inheritdoc />
		public string Name => "table entry";
		
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
		public TableEntryClassProperties Properties { get; } = new TableEntryClassProperties();
        IPropertyList IClass.Properties => Properties;
		public class TableEntryClassProperties : IPropertyList
		{
			/// <inheritdoc />
			public IProperty[] Properties => new IProperty[] {
			};
		};

	}
}