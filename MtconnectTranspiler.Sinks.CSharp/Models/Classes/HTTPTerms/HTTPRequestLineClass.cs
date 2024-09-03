#pragma warning disable CS0109 // Member does not hide an inherited member; new keyword is not required
#pragma warning disable CS1574 // XML comment has cref attribute that could not be resolved
#pragma warning disable CS1584 // XML comment has syntactically incorrect cref attribute
#pragma warning disable CS0618 // Type or member is obsolete
using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;

namespace Mtconnect.Glossary.HTTPTerms
{
	/// <summary>﻿begins with a method token, followed by the Request-URI and the protocol version, and ending with CRLF. A CRLF is allowed in the definition of TEXT only as part of a header field continuation. <seealso href="https://www.google.com/search?q=IETF:RFC-2616&amp;btnI=I">IETF:RFC-2616</seealso><br /><br />&gt; Note: the first line of an <i>HTTP Request</i> describing a specific <i>response document</i> to be published by an <i>agent</i>.<br /><br /><br /><br /><br />
	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Structure___19_0_3_68e0225_1623664375163_189288_2006">model.mtconnect.org</seealso> for more information.
	/// </summary>
	
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public sealed class HTTPRequestLineClass : IClass
	{
		/// <summary>Constant value for <see cref="HTTPRequestLineClass.ReferenceId" /></summary>
		public const string REFERENCE_ID = "_19_0_3_68e0225_1623664375163_189288_2006";
		/// <summary>Constant value for <see cref="HTTPRequestLineClass.HelpUrl" /></summary>
		public const string HELP_URL = "https://model.mtconnect.org/#Structure___19_0_3_68e0225_1623664375163_189288_2006";
		/// <summary>Constant value for <see cref="HTTPRequestLineClass.Summary" /></summary>
		public const string SUMMARY = @"&#10;&#10;&#10;begins with a method token, followed by the Request-URI and the protocol version, and ending with CRLF. A CRLF is allowed in the definition of TEXT only as part of a header field continuation. {{cite(IETF:RFC-2616)}}

> Note: the first line of an {{term(HTTP Request)}} describing a specific {{term(response document)}} to be published by an {{term(agent)}}.

&#10;
";
		/// <summary>Constant value for <see cref="HTTPRequestLineClass.Name" /></summary>
		public const string NAME = "HTTP Request Line";
		/// <summary>Constant value for <see cref="HTTPRequestLineClass.AccessModifier" /></summary>
		public const string ACCESS_MODIFIER = "public";
		/// <summary>Constant value for <see cref="HTTPRequestLineClass.Modifier" /></summary>
		public const string MODIFIER = "";
		/// <summary>Constant value for <see cref="HTTPRequestLineClass.NormativeVersion" /></summary>
		public const string NORMATIVE_VERSION = "";
		/// <summary>Constant value for <see cref="HTTPRequestLineClass.DeprecatedVersion" /></summary>
		public const string DEPRECATED_VERSION = "";

		/// <inheritdoc />
		public string ReferenceId => REFERENCE_ID;
		
		/// <inheritdoc />
		public string HelpUrl => HELP_URL;

		/// <inheritdoc />
		public string Summary => SUMMARY;

		/// <inheritdoc />
		public string Name => NAME;
		
		/// <inheritdoc />
		public string AccessModifier => ACCESS_MODIFIER;
				
		/// <inheritdoc />
		public string Modifier => MODIFIER;
				
		/// <inheritdoc />
		public string NormativeVersion => NORMATIVE_VERSION;
				
		/// <inheritdoc />
		public string DeprecatedVersion => DEPRECATED_VERSION;
		
		/// <inheritdoc />
		public Type Generalization => null;

		/// <inheritdoc />
		public new HTTPRequestLineClassProperties Properties { get; } = new HTTPRequestLineClassProperties();
        IPropertyList IClass.Properties => Properties;
		/// <summary>
		/// Property list for <see cref="HTTPRequestLineClass" />.
		/// </summary>
		public class HTTPRequestLineClassProperties : IPropertyList
		{
			/// <inheritdoc />
			public virtual IProperty[] Properties => new IProperty[] {
			};
		};

	}
}