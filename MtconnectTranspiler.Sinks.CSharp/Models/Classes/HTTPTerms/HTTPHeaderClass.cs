using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;

namespace Mtconnect.Glossary.HTTPTerms
{
	/// <summary>
	/// header of either an <i>HTTP Request</i> from a <i>client</i> or an <i>HTTP Response</i> from an <i>agent</i>. <seealso href="https://www.google.com/search?q=IETF:RFC-2616&btnI=I">IETF:RFC-2616</seealso>
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.3.0.0")]
	public sealed class HTTPHeaderClass : IClass
	{
		/// <inheritdoc />
		public string ReferenceId => "_19_0_3_68e0225_1623664375161_66442_1999";
		
		/// <inheritdoc />
		public string Summary => @"/// header of either an <i>HTTP Request</i> from a <i>client</i> or an <i>HTTP Response</i> from an <i>agent</i>. <seealso href=""https://www.google.com/search?q=IETF:RFC-2616&btnI=I"">IETF:RFC-2616</seealso>";

		/// <inheritdoc />
		public string Name => "HTTPHeaderClass";
		
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