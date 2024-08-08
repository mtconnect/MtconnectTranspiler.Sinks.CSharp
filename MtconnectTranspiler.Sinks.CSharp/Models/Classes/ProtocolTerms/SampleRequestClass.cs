using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;

namespace Mtconnect.Glossary.ProtocolTerms
{
	/// <summary>
	/// <i>request</i> to an <i>agent</i> to produce an <i>MTConnectStreams Response Document</i> containing the <i>Observation Information Model</i> for a set of timestamped <i>observation</i>s made by <i>Component</i>s.
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.3.0.0")]
	public sealed class SampleRequestClass : IClass
	{
		/// <inheritdoc />
		public string ReferenceId => "_19_0_3_68e0225_1623664375184_107893_2081";
		
		/// <inheritdoc />
		public string Summary => @"/// <i>request</i> to an <i>agent</i> to produce an <i>MTConnectStreams Response Document</i> containing the <i>Observation Information Model</i> for a set of timestamped <i>observation</i>s made by <i>Component</i>s.";

		/// <inheritdoc />
		public string Name => "SampleRequestClass";
		
		/// <inheritdoc />
		public string AccessModifier => "public";
				
		/// <inheritdoc />
		public string Modifier => "";
				
		/// <inheritdoc />
		public string NormativeVersion => "";
				
		/// <inheritdoc />
		public string DeprecatedVersion => "";
		
		/// <inheritdoc />
		public string Generalization => "_19_0_3_68e0225_1623664375172_946031_2039";

		public IPropertyList Properties => null;

	}
}