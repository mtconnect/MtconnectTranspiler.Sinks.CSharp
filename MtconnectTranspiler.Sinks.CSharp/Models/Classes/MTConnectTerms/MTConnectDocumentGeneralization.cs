using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;
using System.Linq;

namespace Mtconnect.Glossary.MTConnectTerms
{
	/// <summary>
	/// <i>document</i> that represents a Part(s) of the MTConnect Standard.
	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Structure___19_0_3_68e0225_1623664375171_473670_2035">model.mtconnect.org</seealso> for more information.
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.3.0.0")]
	public sealed class MTConnectDocumentGeneralization : IClass
	{
		/// <inheritdoc />
		public string ReferenceId => "_19_0_3_68e0225_1623664375171_473670_2035";
		
		/// <inheritdoc />
		public string Summary => @"/// <i>document</i> that represents a Part(s) of the MTConnect Standard.";

		/// <inheritdoc />
		public string Name => "MTConnect Document";
		
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
		public MTConnectDocumentGeneralizationProperties Properties { get; } = new MTConnectDocumentGeneralizationProperties();
        IPropertyList IClass.Properties => Properties;
		public class MTConnectDocumentGeneralizationProperties : Mtconnect.Glossary.DocumentClass.DocumentClassProperties
		{
			/// <inheritdoc />
			public IProperty[] Properties => new IProperty[] {
			}.Concat(base.Properties).ToArray();
		};

	}
}