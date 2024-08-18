#pragma warning disable CS0109 // Member does not hide an inherited member; new keyword is not required
#pragma warning disable CS1574 // XML comment has cref attribute that could not be resolved
#pragma warning disable CS1584 // XML comment has syntactically incorrect cref attribute
using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;

namespace Mtconnect.Glossary.HTTPTerms
{
	/// <summary>﻿response provided by an <i>agent</i> indicating that an <i>HTTP Request</i> is incorrectly formatted or identifies that the requested data is not available from the <i>agent</i>.  <seealso href="https://www.google.com/search?q=IETF:RFC-2616&btnI=I">IETF:RFC-2616</seealso><br /><br /><br />
	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Structure___19_0_3_68e0225_1623664375161_349547_1998">model.mtconnect.org</seealso> for more information.
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public sealed class HTTPErrorMessageClass : IClass
	{
		/// <inheritdoc />
		public string ReferenceId => "_19_0_3_68e0225_1623664375161_349547_1998";
		
		/// <inheritdoc />
		public string Summary => @"&#10;&#10;&#10;response provided by an {{term(agent)}} indicating that an {{term(HTTP Request)}} is incorrectly formatted or identifies that the requested data is not available from the {{term(agent)}}.  {{cite(IETF:RFC-2616)}}&#10;
";

		/// <inheritdoc />
		public string Name => "HTTP Error Message";
		
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
		public new HTTPErrorMessageClassProperties Properties { get; } = new HTTPErrorMessageClassProperties();
        IPropertyList IClass.Properties => Properties;
		/// <summary>
		/// Property list for <see cref="HTTPErrorMessageClass" />.
		/// </summary>
		public class HTTPErrorMessageClassProperties : IPropertyList
		{
			/// <inheritdoc />
			public IProperty[] Properties => new IProperty[] {
			};
		};

	}
}