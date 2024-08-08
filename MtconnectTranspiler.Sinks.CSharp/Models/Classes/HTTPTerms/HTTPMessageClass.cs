using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;

namespace Mtconnect.Glossary.HTTPTerms
{
	/// <summary>
	/// consist of requests from client to server and responses from server to client. <seealso href="https://www.google.com/search?q=IETF:RFC-2616&btnI=I">IETF:RFC-2616</seealso>  > Note: In MTConnect Standard, it describes the information that is exchanged between an <i>agent</i> and a <i>client</i>.  
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.3.0.0")]
	public sealed class HTTPMessageClass : IClass
	{
		/// <inheritdoc />
		public string ReferenceId => "_19_0_3_68e0225_1623664375162_687247_2001";
		
		/// <inheritdoc />
		public string Summary => @"/// consist of requests from client to server and responses from server to client. <seealso href=""https://www.google.com/search?q=IETF:RFC-2616&btnI=I"">IETF:RFC-2616</seealso>  > Note: In MTConnect Standard, it describes the information that is exchanged between an <i>agent</i> and a <i>client</i>.  ";

		/// <inheritdoc />
		public string Name => "HTTPMessageClass";
		
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