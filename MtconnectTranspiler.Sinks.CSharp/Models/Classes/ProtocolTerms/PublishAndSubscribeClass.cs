using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;

namespace Mtconnect.Glossary.ProtocolTerms
{
	/// <summary>
	/// asynchronous communication method in which messages are exchanged between applications without knowing the identity of the sender or recipient.  > Note: In the MTConnect Standard, a communications messaging pattern that may be used to publish <i>streaming data</i> from an <i>agent</i>.   
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.3.0.0")]
	public sealed class PublishAndSubscribeClass : IClass
	{
		/// <inheritdoc />
		public string ReferenceId => "_19_0_3_68e0225_1623664375180_561625_2067";
		
		/// <inheritdoc />
		public string Summary => @"/// asynchronous communication method in which messages are exchanged between applications without knowing the identity of the sender or recipient.  > Note: In the MTConnect Standard, a communications messaging pattern that may be used to publish <i>streaming data</i> from an <i>agent</i>.   ";

		/// <inheritdoc />
		public string Name => "PublishAndSubscribeClass";
		
		/// <inheritdoc />
		public string AccessModifier => "public";
				
		/// <inheritdoc />
		public string Modifier => "";
				
		/// <inheritdoc />
		public string NormativeVersion => "";
				
		/// <inheritdoc />
		public string DeprecatedVersion => "";
		
		/// <inheritdoc />
		public string Generalization => "_19_0_3_68e0225_1623664375180_471026_2065";

		public IPropertyList Properties => null;

	}
}