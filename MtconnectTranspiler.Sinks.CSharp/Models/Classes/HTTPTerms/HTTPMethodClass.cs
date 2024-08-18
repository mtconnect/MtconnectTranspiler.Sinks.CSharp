#pragma warning disable CS0109 // Member does not hide an inherited member; new keyword is not required
#pragma warning disable CS1574 // XML comment has cref attribute that could not be resolved
#pragma warning disable CS1584 // XML comment has syntactically incorrect cref attribute
using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;

namespace Mtconnect.Glossary.HTTPTerms
{
	/// <summary>﻿portion of a command in an <i>HTTP Request</i> that indicates the desired action to be performed on the identified resource; often referred to as verbs. <seealso href="https://www.google.com/search?q=IETF:RFC-2616&btnI=I">IETF:RFC-2616</seealso><br /><br /><br /><br />
	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Structure___19_0_3_68e0225_1623664375162_93724_2003">model.mtconnect.org</seealso> for more information.
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public sealed class HTTPMethodClass : IClass
	{
		/// <inheritdoc />
		public string ReferenceId => "_19_0_3_68e0225_1623664375162_93724_2003";
		
		/// <inheritdoc />
		public string Summary => @"&#10;&#10;&#10;portion of a command in an {{term(HTTP Request)}} that indicates the desired action to be performed on the identified resource; often referred to as verbs. {{cite(IETF:RFC-2616)}}
&#10;
";

		/// <inheritdoc />
		public string Name => "HTTP Method";
		
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
		public new HTTPMethodClassProperties Properties { get; } = new HTTPMethodClassProperties();
        IPropertyList IClass.Properties => Properties;
		/// <summary>
		/// Property list for <see cref="HTTPMethodClass" />.
		/// </summary>
		public class HTTPMethodClassProperties : IPropertyList
		{
			/// <inheritdoc />
			public IProperty[] Properties => new IProperty[] {
			};
		};

	}
}