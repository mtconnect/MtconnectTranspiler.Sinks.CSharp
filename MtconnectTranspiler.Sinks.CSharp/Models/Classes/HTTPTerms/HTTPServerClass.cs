#pragma warning disable CS0109 // Member does not hide an inherited member; new keyword is not required
#pragma warning disable CS1574 // XML comment has cref attribute that could not be resolved
#pragma warning disable CS1584 // XML comment has syntactically incorrect cref attribute
#pragma warning disable CS0618 // Type or member is obsolete
using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;

namespace Mtconnect.Glossary.HTTPTerms
{
	/// <summary>﻿server that accepts <i>HTTP Request</i> from <i>client</i> and publishes <i>HTTP Response</i> as a reply to those <i>HTTP Request</i>. <seealso href="https://www.google.com/search?q=IETF:RFC-2616&amp;btnI=I">IETF:RFC-2616</seealso><br /><br /><br />
	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Structure___19_0_3_68e0225_1623664375164_923890_2010">model.mtconnect.org</seealso> for more information.
	/// </summary>
	
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public sealed class HTTPServerClass : IClass
	{
		/// <summary>Constant value for <see cref="HTTPServerClass.ReferenceId" /></summary>
		public const string REFERENCE_ID = "_19_0_3_68e0225_1623664375164_923890_2010";
		/// <summary>Constant value for <see cref="HTTPServerClass.HelpUrl" /></summary>
		public const string HELP_URL = "https://model.mtconnect.org/#Structure___19_0_3_68e0225_1623664375164_923890_2010";
		/// <summary>Constant value for <see cref="HTTPServerClass.Summary" /></summary>
		public const string SUMMARY = @"&#10;&#10;&#10;server that accepts {{term(HTTP Request)}} from {{term(client)}} and publishes {{term(HTTP Response)}} as a reply to those {{term(HTTP Request)}}. {{cite(IETF:RFC-2616)}}&#10;
";
		/// <summary>Constant value for <see cref="HTTPServerClass.Name" /></summary>
		public const string NAME = "HTTP Server";
		/// <summary>Constant value for <see cref="HTTPServerClass.AccessModifier" /></summary>
		public const string ACCESS_MODIFIER = "public";
		/// <summary>Constant value for <see cref="HTTPServerClass.Modifier" /></summary>
		public const string MODIFIER = "";
		/// <summary>Constant value for <see cref="HTTPServerClass.NormativeVersion" /></summary>
		public const string NORMATIVE_VERSION = "";
		/// <summary>Constant value for <see cref="HTTPServerClass.DeprecatedVersion" /></summary>
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
		public new HTTPServerClassProperties Properties { get; } = new HTTPServerClassProperties();
        IPropertyList IClass.Properties => Properties;
		/// <summary>
		/// Property list for <see cref="HTTPServerClass" />.
		/// </summary>
		public class HTTPServerClassProperties : IPropertyList
		{
			/// <inheritdoc />
			public virtual IProperty[] Properties => new IProperty[] {
			};
		};

	}
}