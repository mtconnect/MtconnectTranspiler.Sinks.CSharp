using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;
using System.Linq;

namespace Mtconnect.Glossary.ProtocolTerms
{
	/// <summary>
	/// <i>request</i> to an <i>agent</i> to produce an <i>MTConnectStreams Response Document</i> containing the <i>Observation Information Model</i> for a set of timestamped <i>observation</i>s made by <i>Component</i>s.
	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Structure___19_0_3_68e0225_1623664375184_107893_2081">model.mtconnect.org</seealso> for more information.
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.3.0.0")]
	public sealed class SampleRequestClass : IClass
	{
		/// <inheritdoc />
		public string ReferenceId => "_19_0_3_68e0225_1623664375184_107893_2081";
		
		/// <inheritdoc />
		public string Summary => @"/// <i>request</i> to an <i>agent</i> to produce an <i>MTConnectStreams Response Document</i> containing the <i>Observation Information Model</i> for a set of timestamped <i>observation</i>s made by <i>Component</i>s.";

		/// <inheritdoc />
		public string Name => "sample request";
		
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
		public SampleRequestClassProperties Properties { get; } = new SampleRequestClassProperties();
        IPropertyList IClass.Properties => Properties;
		public class SampleRequestClassProperties : Mtconnect.Glossary.ProtocolTerms.MTConnectRequestGeneralization.MTConnectRequestGeneralizationProperties
		{
			/// <inheritdoc />
			public IProperty[] Properties => new IProperty[] {
			}.Concat(base.Properties).ToArray();
		};

	}
}