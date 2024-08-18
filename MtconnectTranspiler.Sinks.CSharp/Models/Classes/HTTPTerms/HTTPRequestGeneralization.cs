#pragma warning disable CS0109 // Member does not hide an inherited member; new keyword is not required
#pragma warning disable CS1574 // XML comment has cref attribute that could not be resolved
#pragma warning disable CS1584 // XML comment has syntactically incorrect cref attribute
using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;
using System.Linq;

namespace Mtconnect.Glossary.HTTPTerms
{
	/// <summary>﻿request message from a client to a server includes, within the first line of that message, the method to be applied to the resource, the identifier of the resource, and the protocol version in use. <seealso href="https://www.google.com/search?q=IETF:RFC-2616&btnI=I">IETF:RFC-2616</seealso><br /><br />&gt; Note: In MTConnect Standard, a request issued by a <i>client</i> to an <i>agent</i> requesting information defined in the <i>HTTP Request Line</i>.<br /><br /><br /><br /><br />
	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Structure___19_0_3_68e0225_1623664375163_559390_2005">model.mtconnect.org</seealso> for more information.
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public sealed class HTTPRequestGeneralization : IClass
	{
		/// <inheritdoc />
		public string ReferenceId => "_19_0_3_68e0225_1623664375163_559390_2005";
		
		/// <inheritdoc />
		public string Summary => @"&#10;&#10;&#10;request message from a client to a server includes, within the first line of that message, the method to be applied to the resource, the identifier of the resource, and the protocol version in use. {{cite(IETF:RFC-2616)}}

> Note: In MTConnect Standard, a request issued by a {{term(client)}} to an {{term(agent)}} requesting information defined in the {{term(HTTP Request Line)}}.

&#10;
";

		/// <inheritdoc />
		public string Name => "HTTP Request";
		
		/// <inheritdoc />
		public string AccessModifier => "public";
				
		/// <inheritdoc />
		public string Modifier => "";
				
		/// <inheritdoc />
		public string NormativeVersion => "";
				
		/// <inheritdoc />
		public string DeprecatedVersion => "";
		
		/// <inheritdoc />
		/// <remarks>
		/// Original Type: _19_0_3_68e0225_1623664375181_991321_2071
		/// </remarks>
		public Type Generalization => typeof(Mtconnect.Glossary.ProtocolTerms.RequestClass);

		/// <inheritdoc />
		public new HTTPRequestGeneralizationProperties Properties { get; } = new HTTPRequestGeneralizationProperties();
        IPropertyList IClass.Properties => Properties;
		/// <summary>
		/// Property list for <see cref="HTTPRequestGeneralization" />.
		/// <br/><b>Note</b>, some properties (<see cref="IProperty" />) are inherited from <see cref="Mtconnect.Glossary.ProtocolTerms.RequestClass.RequestClassProperties" />.
		/// </summary>
		public class HTTPRequestGeneralizationProperties : Mtconnect.Glossary.ProtocolTerms.RequestClass.RequestClassProperties
		{
			/// <inheritdoc />
			public new IProperty[] Properties => new IProperty[] {
			}.Concat(base.Properties).ToArray();
		};

	}
}