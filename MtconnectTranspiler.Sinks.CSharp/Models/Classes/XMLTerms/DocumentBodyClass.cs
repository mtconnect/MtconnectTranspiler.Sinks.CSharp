#pragma warning disable CS0109 // Member does not hide an inherited member; new keyword is not required
#pragma warning disable CS1574 // XML comment has cref attribute that could not be resolved
#pragma warning disable CS1584 // XML comment has syntactically incorrect cref attribute
#pragma warning disable CS0618 // Type or member is obsolete
using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;

namespace Mtconnect.Glossary.XMLTerms
{
	/// <summary>﻿portion of the content of an <i>MTConnect Response Document</i> that is defined by the relative <i>MTConnect Information Model</i>. The <i>document body</i> contains the <i>structural element</i>s and <i>Observation</i>s or <i>DataItem</i>s reported in a <i>response document</i>.<br /><br /><br /><br />
	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Structure___19_0_3_68e0225_1623664375156_434194_1983">model.mtconnect.org</seealso> for more information.
	/// </summary>
	
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public sealed class DocumentBodyClass : IClass
	{
		/// <summary>Constant value for <see cref="DocumentBodyClass.ReferenceId" /></summary>
		public const string REFERENCE_ID = "_19_0_3_68e0225_1623664375156_434194_1983";
		/// <summary>Constant value for <see cref="DocumentBodyClass.HelpUrl" /></summary>
		public const string HELP_URL = "https://model.mtconnect.org/#Structure___19_0_3_68e0225_1623664375156_434194_1983";
		/// <summary>Constant value for <see cref="DocumentBodyClass.Summary" /></summary>
		public const string SUMMARY = @"&#10;&#10;&#10;portion of the content of an {{term(MTConnect Response Document)}} that is defined by the relative {{term(MTConnect Information Model)}}. The {{term(document body)}} contains the {{termplural(structural element)}} and {{termplural(Observation)}} or {{termplural(DataItem)}} reported in a {{term(response document)}}.
&#10;
";
		/// <summary>Constant value for <see cref="DocumentBodyClass.Name" /></summary>
		public const string NAME = "document body";
		/// <summary>Constant value for <see cref="DocumentBodyClass.AccessModifier" /></summary>
		public const string ACCESS_MODIFIER = "public";
		/// <summary>Constant value for <see cref="DocumentBodyClass.Modifier" /></summary>
		public const string MODIFIER = "";
		/// <summary>Constant value for <see cref="DocumentBodyClass.NormativeVersion" /></summary>
		public const string NORMATIVE_VERSION = "";
		/// <summary>Constant value for <see cref="DocumentBodyClass.DeprecatedVersion" /></summary>
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
		public new DocumentBodyClassProperties Properties { get; } = new DocumentBodyClassProperties();
        IPropertyList IClass.Properties => Properties;
		/// <summary>
		/// Property list for <see cref="DocumentBodyClass" />.
		/// </summary>
		public class DocumentBodyClassProperties : IPropertyList
		{
			/// <inheritdoc />
			public virtual IProperty[] Properties => new IProperty[] {
			};
		};

	}
}