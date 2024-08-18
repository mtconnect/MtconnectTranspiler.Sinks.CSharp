#pragma warning disable CS0109 // Member does not hide an inherited member; new keyword is not required
#pragma warning disable CS1574 // XML comment has cref attribute that could not be resolved
#pragma warning disable CS1584 // XML comment has syntactically incorrect cref attribute
using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;
using System.Linq;

namespace Mtconnect.Glossary.ProtocolTerms
{
	/// <summary>﻿communications method where a <i>client</i> transmits a message to an <i>agent</i>.  That message instructs the <i>agent</i> to respond with specific information.<br /><br /><br />
	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Structure___19_0_3_68e0225_1623664375181_991321_2071">model.mtconnect.org</seealso> for more information.
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public sealed class RequestClass : IClass
	{
		/// <inheritdoc />
		public string ReferenceId => "_19_0_3_68e0225_1623664375181_991321_2071";
		
		/// <inheritdoc />
		public string Summary => @"&#10;&#10;&#10;communications method where a {{term(client)}} transmits a message to an {{term(agent)}}.  That message instructs the {{term(agent)}} to respond with specific information.&#10;
";

		/// <inheritdoc />
		public string Name => "request";
		
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
		/// Original Type: _19_0_3_68e0225_1623664375180_471026_2065
		/// </remarks>
		public Type Generalization => typeof(Mtconnect.Glossary.ProtocolTerms.ProtocolClass);

		/// <inheritdoc />
		public new RequestClassProperties Properties { get; } = new RequestClassProperties();
        IPropertyList IClass.Properties => Properties;
		/// <summary>
		/// Property list for <see cref="RequestClass" />.
		/// <br/><b>Note</b>, some properties (<see cref="IProperty" />) are inherited from <see cref="Mtconnect.Glossary.ProtocolTerms.ProtocolClass.ProtocolClassProperties" />.
		/// </summary>
		public class RequestClassProperties : Mtconnect.Glossary.ProtocolTerms.ProtocolClass.ProtocolClassProperties
		{
			/// <inheritdoc />
			public new IProperty[] Properties => new IProperty[] {
			}.Concat(base.Properties).ToArray();
		};

	}
}