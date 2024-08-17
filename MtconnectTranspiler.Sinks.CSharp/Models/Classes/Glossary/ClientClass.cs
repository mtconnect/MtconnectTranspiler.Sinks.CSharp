#pragma warning disable CS0109 // Member does not hide an inherited member; new keyword is not required
#pragma warning disable CS1574 // XML comment has cref attribute that could not be resolved
#pragma warning disable CS1584 // XML comment has syntactically incorrect cref attribute
using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;
using System.Linq;

namespace Mtconnect.Glossary
{
	/// <summary>﻿<i>application</i> that sends <i>request</i> for information to an <i>agent</i>.<br /><br />&gt; Note: Examples include software applications or a function that implements the <i>request</i> portion of an <i>interface</i> <i>interaction model</i>.<br /><br /><br /><br /><br />
	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Structure___19_0_3_68e0225_1623664375146_487077_1962">model.mtconnect.org</seealso> for more information.
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public sealed class ClientClass : IClass
	{
		/// <inheritdoc />
		public string ReferenceId => "_19_0_3_68e0225_1623664375146_487077_1962";
		
		/// <inheritdoc />
		public string Summary => @"&#10;&#10;&#10;{{term(application)}} that sends {{term(request)}} for information to an {{term(agent)}}.

> Note: Examples include software applications or a function that implements the {{term(request)}} portion of an {{term(interface)}} {{term(interaction model)}}.

&#10;
";

		/// <inheritdoc />
		public string Name => "client";
		
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
		/// Original Type: _19_0_3_68e0225_1623664375141_18140_1949
		/// </remarks>
		public Type Generalization => typeof(Mtconnect.Glossary.ApplicationClass);

		/// <inheritdoc />
		public ClientClassProperties Properties { get; } = new ClientClassProperties();
        IPropertyList IClass.Properties => Properties;
		/// <summary>
		/// Property list for <see cref="ClientClass" />.
		/// <br/><b>Note</b>, some properties (<see cref="IProperty" />) are inherited from <see cref="Mtconnect.Glossary.ApplicationClass.ApplicationClassProperties" />.
		/// </summary>
		public class ClientClassProperties : Mtconnect.Glossary.ApplicationClass.ApplicationClassProperties
		{
			/// <inheritdoc />
			public new IProperty[] Properties => new IProperty[] {
			}.Concat(base.Properties).ToArray();
		};

	}
}