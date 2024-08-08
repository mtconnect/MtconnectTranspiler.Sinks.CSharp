using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;

namespace Mtconnect.Glossary.HTTPTerms
{
	/// <summary>
	/// data bytes transmitted in an HTTP transaction message immediately following the headers. <seealso href="https://www.google.com/search?q=IETF:RFC-2616&btnI=I">IETF:RFC-2616</seealso>
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.3.0.0")]
	public sealed class HTTPBodyClass : IClass
	{
		/// <inheritdoc />
		public string ReferenceId => "_19_0_3_68e0225_1623664375161_905436_1997";
		
		/// <inheritdoc />
		public string Summary => @"/// data bytes transmitted in an HTTP transaction message immediately following the headers. <seealso href=""https://www.google.com/search?q=IETF:RFC-2616&btnI=I"">IETF:RFC-2616</seealso>";

		/// <inheritdoc />
		public string Name => "HTTPBodyClass";
		
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