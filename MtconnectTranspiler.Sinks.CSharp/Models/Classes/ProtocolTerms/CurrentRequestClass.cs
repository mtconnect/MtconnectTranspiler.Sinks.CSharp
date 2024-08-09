using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;
using System.Linq;

namespace Mtconnect.Glossary.ProtocolTerms
{
	/// <summary>
	/// <i>request</i> to an <i>agent</i> to produce an <i>MTConnectStreams Response Document</i> containing the <i>Observation Information Model</i> for a snapshot of the latest <i>observation</i>s at the moment of the <i>request</i> or at a given <i>sequence number</i>.
	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Structure___19_0_3_68e0225_1623664375151_897599_1970">model.mtconnect.org</seealso> for more information.
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.3.0.0")]
	public sealed class CurrentRequestClass : IClass
	{
		/// <inheritdoc />
		public string ReferenceId => "_19_0_3_68e0225_1623664375151_897599_1970";
		
		/// <inheritdoc />
		public string Summary => @"/// <i>request</i> to an <i>agent</i> to produce an <i>MTConnectStreams Response Document</i> containing the <i>Observation Information Model</i> for a snapshot of the latest <i>observation</i>s at the moment of the <i>request</i> or at a given <i>sequence number</i>.";

		/// <inheritdoc />
		public string Name => "current request";
		
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
		public CurrentRequestClassProperties Properties { get; } = new CurrentRequestClassProperties();
        IPropertyList IClass.Properties => Properties;
		public class CurrentRequestClassProperties : Mtconnect.Glossary.ProtocolTerms.MTConnectRequestGeneralization.MTConnectRequestGeneralizationProperties
		{
			/// <inheritdoc />
			public IProperty[] Properties => new IProperty[] {
			}.Concat(base.Properties).ToArray();
		};

	}
}