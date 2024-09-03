#pragma warning disable CS0109 // Member does not hide an inherited member; new keyword is not required
#pragma warning disable CS1574 // XML comment has cref attribute that could not be resolved
#pragma warning disable CS1584 // XML comment has syntactically incorrect cref attribute
#pragma warning disable CS0618 // Type or member is obsolete
using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;

namespace Mtconnect.Glossary.HTTPTerms
{
	/// <summary>﻿portion of a command in an <i>HTTP Request</i> that indicates the desired action to be performed on the identified resource; often referred to as verbs. <seealso href="https://www.google.com/search?q=IETF:RFC-2616&amp;btnI=I">IETF:RFC-2616</seealso><br /><br /><br /><br />
	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Structure___19_0_3_68e0225_1623664375162_93724_2003">model.mtconnect.org</seealso> for more information.
	/// </summary>
	
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public sealed class HTTPMethodClass : IClass
	{
		/// <summary>Constant value for <see cref="HTTPMethodClass.ReferenceId" /></summary>
		public const string REFERENCE_ID = "_19_0_3_68e0225_1623664375162_93724_2003";
		/// <summary>Constant value for <see cref="HTTPMethodClass.HelpUrl" /></summary>
		public const string HELP_URL = "https://model.mtconnect.org/#Structure___19_0_3_68e0225_1623664375162_93724_2003";
		/// <summary>Constant value for <see cref="HTTPMethodClass.Summary" /></summary>
		public const string SUMMARY = @"&#10;&#10;&#10;portion of a command in an {{term(HTTP Request)}} that indicates the desired action to be performed on the identified resource; often referred to as verbs. {{cite(IETF:RFC-2616)}}
&#10;
";
		/// <summary>Constant value for <see cref="HTTPMethodClass.Name" /></summary>
		public const string NAME = "HTTP Method";
		/// <summary>Constant value for <see cref="HTTPMethodClass.AccessModifier" /></summary>
		public const string ACCESS_MODIFIER = "public";
		/// <summary>Constant value for <see cref="HTTPMethodClass.Modifier" /></summary>
		public const string MODIFIER = "";
		/// <summary>Constant value for <see cref="HTTPMethodClass.NormativeVersion" /></summary>
		public const string NORMATIVE_VERSION = "";
		/// <summary>Constant value for <see cref="HTTPMethodClass.DeprecatedVersion" /></summary>
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
		public new HTTPMethodClassProperties Properties { get; } = new HTTPMethodClassProperties();
        IPropertyList IClass.Properties => Properties;
		/// <summary>
		/// Property list for <see cref="HTTPMethodClass" />.
		/// </summary>
		public class HTTPMethodClassProperties : IPropertyList
		{
			/// <inheritdoc />
			public virtual IProperty[] Properties => new IProperty[] {
			};
		};

	}
}