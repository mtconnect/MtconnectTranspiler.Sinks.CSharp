#pragma warning disable CS0109 // Member does not hide an inherited member; new keyword is not required
#pragma warning disable CS1574 // XML comment has cref attribute that could not be resolved
#pragma warning disable CS1584 // XML comment has syntactically incorrect cref attribute
using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;

namespace Mtconnect.Glossary.HTTPTerms
{
	/// <summary>﻿version of the HTTP protocol. <seealso href="https://www.google.com/search?q=IETF:RFC-2616&btnI=I">IETF:RFC-2616</seealso><br /><br /><br />
	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Structure___19_0_3_68e0225_1623664375165_642119_2012">model.mtconnect.org</seealso> for more information.
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public sealed class HTTPVersionClass : IClass
	{
		/// <inheritdoc />
		public string ReferenceId => "_19_0_3_68e0225_1623664375165_642119_2012";
		
		/// <inheritdoc />
		public string Summary => @"&#10;&#10;&#10;version of the HTTP protocol. {{cite(IETF:RFC-2616)}}&#10;
";

		/// <inheritdoc />
		public string Name => "HTTP Version";
		
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
		public new HTTPVersionClassProperties Properties { get; } = new HTTPVersionClassProperties();
        IPropertyList IClass.Properties => Properties;
		/// <summary>
		/// Property list for <see cref="HTTPVersionClass" />.
		/// </summary>
		public class HTTPVersionClassProperties : IPropertyList
		{
			/// <inheritdoc />
			public IProperty[] Properties => new IProperty[] {
			};
		};

	}
}