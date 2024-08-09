using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;
using System.Linq;

namespace Mtconnect.Glossary.ProtocolTerms
{
	/// <summary>
	/// <i>HTTP Request</i> to the <i>agent</i> regarding <i>Asset</i>s.
	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Structure___19_0_3_68e0225_1623664375143_188436_1955">model.mtconnect.org</seealso> for more information.
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.3.0.0")]
	public sealed class AssetRequestClass : IClass
	{
		/// <inheritdoc />
		public string ReferenceId => "_19_0_3_68e0225_1623664375143_188436_1955";
		
		/// <inheritdoc />
		public string Summary => @"/// <i>HTTP Request</i> to the <i>agent</i> regarding <i>Asset</i>s.";

		/// <inheritdoc />
		public string Name => "asset request";
		
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
		/// Original Type: _19_0_3_68e0225_1623664375172_946031_2039
		/// </remarks>
		public Type Generalization => typeof(Mtconnect.Glossary.ProtocolTerms.MTConnectRequestGeneralization);

		/// <inheritdoc />
		public AssetRequestClassProperties Properties { get; } = new AssetRequestClassProperties();
        IPropertyList IClass.Properties => Properties;
		public class AssetRequestClassProperties : Mtconnect.Glossary.ProtocolTerms.MTConnectRequestGeneralization.MTConnectRequestGeneralizationProperties
		{
			/// <inheritdoc />
			public IProperty[] Properties => new IProperty[] {
			}.Concat(base.Properties).ToArray();
		};

	}
}