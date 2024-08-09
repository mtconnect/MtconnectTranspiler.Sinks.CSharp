using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;
using System.Linq;

namespace Mtconnect.Glossary.ProtocolTerms
{
	/// <summary>
	/// receiving messages in a <i>publish and subscribe</i> pattern.
	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Structure___19_0_3_68e0225_1623664375188_852098_2096">model.mtconnect.org</seealso> for more information.
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.3.0.0")]
	public sealed class SubscribeClass : IClass
	{
		/// <inheritdoc />
		public string ReferenceId => "_19_0_3_68e0225_1623664375188_852098_2096";
		
		/// <inheritdoc />
		public string Summary => @"/// receiving messages in a <i>publish and subscribe</i> pattern.";

		/// <inheritdoc />
		public string Name => "subscribe";
		
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
		/// Original Type: _19_0_3_68e0225_1623664375180_561625_2067
		/// </remarks>
		public Type Generalization => typeof(Mtconnect.Glossary.ProtocolTerms.PublishAndSubscribeClass);

		/// <inheritdoc />
		public SubscribeClassProperties Properties { get; } = new SubscribeClassProperties();
        IPropertyList IClass.Properties => Properties;
		public class SubscribeClassProperties : Mtconnect.Glossary.ProtocolTerms.PublishAndSubscribeClass.PublishAndSubscribeClassProperties
		{
			/// <inheritdoc />
			public IProperty[] Properties => new IProperty[] {
			}.Concat(base.Properties).ToArray();
		};

	}
}