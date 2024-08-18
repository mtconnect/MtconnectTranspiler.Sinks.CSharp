#pragma warning disable CS0109 // Member does not hide an inherited member; new keyword is not required
#pragma warning disable CS1574 // XML comment has cref attribute that could not be resolved
#pragma warning disable CS1584 // XML comment has syntactically incorrect cref attribute
using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;

namespace Mtconnect.Glossary.HTTPTerms
{
	/// <summary>﻿after receiving and interpreting a request message, a server responds with an HTTP response message. <seealso href="https://www.google.com/search?q=IETF:RFC-2616&btnI=I">IETF:RFC-2616</seealso><br /><br />&gt; Note: In MTConnect Standard, the information published from an <i>agent</i> in reply to an <i>HTTP Request</i>. <br /><br /><br /><br /><br />
	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Structure___19_0_3_68e0225_1623664375164_626060_2009">model.mtconnect.org</seealso> for more information.
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public sealed class HTTPResponseClass : IClass
	{
		/// <inheritdoc />
		public string ReferenceId => "_19_0_3_68e0225_1623664375164_626060_2009";
		
		/// <inheritdoc />
		public string Summary => @"&#10;&#10;&#10;after receiving and interpreting a request message, a server responds with an HTTP response message. {{cite(IETF:RFC-2616)}}

> Note: In MTConnect Standard, the information published from an {{term(agent)}} in reply to an {{term(HTTP Request)}}. 

&#10;
";

		/// <inheritdoc />
		public string Name => "HTTP Response";
		
		/// <inheritdoc />
		public string AccessModifier => "public";
				
		/// <inheritdoc />
		public string Modifier => "";
				
		/// <inheritdoc />
		public string NormativeVersion => "";
				
		/// <inheritdoc />
		public string DeprecatedVersion => "";
		
		/// <inheritdoc />
		public Type Generalization => null;

		/// <inheritdoc />
		public new HTTPResponseClassProperties Properties { get; } = new HTTPResponseClassProperties();
        IPropertyList IClass.Properties => Properties;
		/// <summary>
		/// Property list for <see cref="HTTPResponseClass" />.
		/// </summary>
		public class HTTPResponseClassProperties : IPropertyList
		{
			/// <inheritdoc />
			public IProperty[] Properties => new IProperty[] {
			};
		};

	}
}