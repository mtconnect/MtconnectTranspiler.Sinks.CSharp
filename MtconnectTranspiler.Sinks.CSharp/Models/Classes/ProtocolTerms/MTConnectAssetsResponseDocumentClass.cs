using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;
using System.Linq;

namespace Mtconnect.Glossary.ProtocolTerms
{
	/// <summary>
	/// <i>response document</i> published by an <i>MTConnect Agent</i> in response to an <i>asset request</i>.
	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Structure___19_0_3_68e0225_1623664375173_758841_2043">model.mtconnect.org</seealso> for more information.
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.3.0.0")]
	public sealed class MTConnectAssetsResponseDocumentClass : IClass
	{
		/// <inheritdoc />
		public string ReferenceId => "_19_0_3_68e0225_1623664375173_758841_2043";
		
		/// <inheritdoc />
		public string Summary => @"/// <i>response document</i> published by an <i>MTConnect Agent</i> in response to an <i>asset request</i>.";

		/// <inheritdoc />
		public string Name => "MTConnectAssets Response Document";
		
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
		/// Original Type: _19_0_3_68e0225_1623664375173_527411_2040
		/// </remarks>
		public Type Generalization => typeof(Mtconnect.Glossary.ProtocolTerms.MTConnectResponseDocumentClass);

		/// <inheritdoc />
		public MTConnectAssetsResponseDocumentClassProperties Properties { get; } = new MTConnectAssetsResponseDocumentClassProperties();
        IPropertyList IClass.Properties => Properties;
		public class MTConnectAssetsResponseDocumentClassProperties : Mtconnect.Glossary.ProtocolTerms.MTConnectResponseDocumentClass.MTConnectResponseDocumentClassProperties
		{
			/// <inheritdoc />
			public IProperty[] Properties => new IProperty[] {
			}.Concat(base.Properties).ToArray();
		};

	}
}