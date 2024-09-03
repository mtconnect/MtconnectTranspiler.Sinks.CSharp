#pragma warning disable CS0109 // Member does not hide an inherited member; new keyword is not required
#pragma warning disable CS1574 // XML comment has cref attribute that could not be resolved
#pragma warning disable CS1584 // XML comment has syntactically incorrect cref attribute
#pragma warning disable CS0618 // Type or member is obsolete
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
		/// <summary>Constant value for <see cref="ClientClass.ReferenceId" /></summary>
		public const string REFERENCE_ID = "_19_0_3_68e0225_1623664375146_487077_1962";
		/// <summary>Constant value for <see cref="ClientClass.HelpUrl" /></summary>
		public const string HELP_URL = "https://model.mtconnect.org/#Structure___19_0_3_68e0225_1623664375146_487077_1962";
		/// <summary>Constant value for <see cref="ClientClass.Summary" /></summary>
		public const string SUMMARY = @"&#10;&#10;&#10;{{term(application)}} that sends {{term(request)}} for information to an {{term(agent)}}.

> Note: Examples include software applications or a function that implements the {{term(request)}} portion of an {{term(interface)}} {{term(interaction model)}}.

&#10;
";
		/// <summary>Constant value for <see cref="ClientClass.Name" /></summary>
		public const string NAME = "client";
		/// <summary>Constant value for <see cref="ClientClass.AccessModifier" /></summary>
		public const string ACCESS_MODIFIER = "public";
		/// <summary>Constant value for <see cref="ClientClass.Modifier" /></summary>
		public const string MODIFIER = "";
		/// <summary>Constant value for <see cref="ClientClass.NormativeVersion" /></summary>
		public const string NORMATIVE_VERSION = "";
		/// <summary>Constant value for <see cref="ClientClass.DeprecatedVersion" /></summary>
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
		/// <remarks>
		/// Original Type: _19_0_3_68e0225_1623664375141_18140_1949
		/// </remarks>
		public Type Generalization => typeof(Mtconnect.Glossary.ApplicationClass);

		/// <inheritdoc />
		public new ClientClassProperties Properties { get; } = new ClientClassProperties();
        IPropertyList IClass.Properties => Properties;
		/// <summary>
		/// Property list for <see cref="ClientClass" />.
		/// <br/><b>Note</b>, some properties (<see cref="IProperty" />) are inherited from <see cref="Mtconnect.Glossary.ApplicationClass.ApplicationClassProperties" />.
		/// </summary>
		public class ClientClassProperties : Mtconnect.Glossary.ApplicationClass.ApplicationClassProperties
		{
			/// <inheritdoc />
			public override IProperty[] Properties => new IProperty[] {
			}.Concat(base.Properties).ToArray();
		};

	}
}