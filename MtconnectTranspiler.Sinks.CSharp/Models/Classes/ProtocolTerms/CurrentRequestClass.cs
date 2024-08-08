using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;

namespace Mtconnect.Glossary.ProtocolTerms
{
	/// <summary>
	/// <i>request</i> to an <i>agent</i> to produce an <i>MTConnectStreams Response Document</i> containing the <i>Observation Information Model</i> for a snapshot of the latest <i>observation</i>s at the moment of the <i>request</i> or at a given <i>sequence number</i>.
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.3.0.0")]
	public sealed class CurrentRequestClass : IClass
	{
		/// <inheritdoc />
		public string ReferenceId => "_19_0_3_68e0225_1623664375151_897599_1970";
		
		/// <inheritdoc />
		public string Summary => @"/// <i>request</i> to an <i>agent</i> to produce an <i>MTConnectStreams Response Document</i> containing the <i>Observation Information Model</i> for a snapshot of the latest <i>observation</i>s at the moment of the <i>request</i> or at a given <i>sequence number</i>.";

		/// <inheritdoc />
		public string Name => "CurrentRequestClass";
		
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