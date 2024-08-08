using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;

namespace Mtconnect.Glossary.HTTPTerms
{
	/// <summary>
	/// after receiving and interpreting a request message, a server responds with an HTTP response message. <seealso href="https://www.google.com/search?q=IETF:RFC-2616&btnI=I">IETF:RFC-2616</seealso>  > Note: In MTConnect Standard, the information published from an <i>agent</i> in reply to an <i>HTTP Request</i>.   
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.3.0.0")]
	public sealed class HTTPResponseClass : IClass
	{
		/// <inheritdoc />
		public string ReferenceId => "_19_0_3_68e0225_1623664375164_626060_2009";
		
		/// <inheritdoc />
		public string Summary => @"/// after receiving and interpreting a request message, a server responds with an HTTP response message. <seealso href=""https://www.google.com/search?q=IETF:RFC-2616&btnI=I"">IETF:RFC-2616</seealso>  > Note: In MTConnect Standard, the information published from an <i>agent</i> in reply to an <i>HTTP Request</i>.   ";

		/// <inheritdoc />
		public string Name => "HTTPResponseClass";
		
		/// <inheritdoc />
		public string AccessModifier => "public";
				
		/// <inheritdoc />
		public string Modifier => "";
				
		/// <inheritdoc />
		public string NormativeVersion => "";
				
		/// <inheritdoc />
		public string DeprecatedVersion => "";
		
		/// <inheritdoc />
		public string Generalization => "";

		public IPropertyList Properties => null;

	}
}