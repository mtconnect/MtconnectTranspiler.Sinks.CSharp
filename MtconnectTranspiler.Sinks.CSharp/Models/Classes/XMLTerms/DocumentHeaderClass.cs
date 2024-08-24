#pragma warning disable CS0109 // Member does not hide an inherited member; new keyword is not required
#pragma warning disable CS1574 // XML comment has cref attribute that could not be resolved
#pragma warning disable CS1584 // XML comment has syntactically incorrect cref attribute
#pragma warning disable CS0618 // Type or member is obsolete
using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;

namespace Mtconnect.Glossary.XMLTerms
{
	/// <summary>﻿portion of the content of an <i>MTConnect Response Document</i> that provides information from an <i>agent</i> defining version information, storage capacity, protocol, and other information associated with the management of the data stored in or retrieved from the <i>agent</i>.<br /><br /><br /><br />
	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Structure___19_0_3_68e0225_1623664375157_278948_1984">model.mtconnect.org</seealso> for more information.
	/// </summary>
	
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public sealed class DocumentHeaderClass : IClass
	{
		/// <summary>Constant value for <see cref="DocumentHeaderClass.ReferenceId" /></summary>
		public const string REFERENCE_ID = "_19_0_3_68e0225_1623664375157_278948_1984";
		/// <summary>Constant value for <see cref="DocumentHeaderClass.HelpUrl" /></summary>
		public const string HELP_URL = "https://model.mtconnect.org/#Structure___19_0_3_68e0225_1623664375157_278948_1984";
		/// <summary>Constant value for <see cref="DocumentHeaderClass.Summary" /></summary>
		public const string SUMMARY = @"&#10;&#10;&#10;portion of the content of an {{term(MTConnect Response Document)}} that provides information from an {{term(agent)}} defining version information, storage capacity, protocol, and other information associated with the management of the data stored in or retrieved from the {{term(agent)}}.
&#10;
";
		/// <summary>Constant value for <see cref="DocumentHeaderClass.Name" /></summary>
		public const string NAME = "document header";
		/// <summary>Constant value for <see cref="DocumentHeaderClass.AccessModifier" /></summary>
		public const string ACCESS_MODIFIER = "public";
		/// <summary>Constant value for <see cref="DocumentHeaderClass.Modifier" /></summary>
		public const string MODIFIER = "";
		/// <summary>Constant value for <see cref="DocumentHeaderClass.NormativeVersion" /></summary>
		public const string NORMATIVE_VERSION = "";
		/// <summary>Constant value for <see cref="DocumentHeaderClass.DeprecatedVersion" /></summary>
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
		public new DocumentHeaderClassProperties Properties { get; } = new DocumentHeaderClassProperties();
        IPropertyList IClass.Properties => Properties;
		/// <summary>
		/// Property list for <see cref="DocumentHeaderClass" />.
		/// </summary>
		public class DocumentHeaderClassProperties : IPropertyList
		{
			/// <inheritdoc />
			public virtual IProperty[] Properties => new IProperty[] {
			};
		};

	}
}