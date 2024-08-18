#pragma warning disable CS0109 // Member does not hide an inherited member; new keyword is not required
#pragma warning disable CS1574 // XML comment has cref attribute that could not be resolved
#pragma warning disable CS1584 // XML comment has syntactically incorrect cref attribute
using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;

namespace Mtconnect.Glossary.HTTPTerms
{
	/// <summary>﻿portion of a request for information that more precisely defines the specific information to be published in response to the request. <seealso href="https://www.google.com/search?q=IETF:RFC-2616&btnI=I">IETF:RFC-2616</seealso><br /><br /><br />
	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Structure___19_0_3_68e0225_1623664375163_768611_2004">model.mtconnect.org</seealso> for more information.
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public sealed class HTTPQueryClass : IClass
	{
		/// <inheritdoc />
		public string ReferenceId => "_19_0_3_68e0225_1623664375163_768611_2004";
		
		/// <inheritdoc />
		public string Summary => @"&#10;&#10;&#10;portion of a request for information that more precisely defines the specific information to be published in response to the request. {{cite(IETF:RFC-2616)}}&#10;
";

		/// <inheritdoc />
		public string Name => "HTTP Query";
		
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
		public new HTTPQueryClassProperties Properties { get; } = new HTTPQueryClassProperties();
        IPropertyList IClass.Properties => Properties;
		/// <summary>
		/// Property list for <see cref="HTTPQueryClass" />.
		/// </summary>
		public class HTTPQueryClassProperties : IPropertyList
		{
			/// <inheritdoc />
			public IProperty[] Properties => new IProperty[] {
			};
		};

	}
}