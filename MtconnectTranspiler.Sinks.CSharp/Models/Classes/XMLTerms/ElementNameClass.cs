#pragma warning disable CS0109 // Member does not hide an inherited member; new keyword is not required
#pragma warning disable CS1574 // XML comment has cref attribute that could not be resolved
#pragma warning disable CS1584 // XML comment has syntactically incorrect cref attribute
#pragma warning disable CS0618 // Type or member is obsolete
using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;

namespace Mtconnect.Glossary.XMLTerms
{
	/// <summary>﻿descriptive identifier contained in both the <c>start-tag</c> and <c>end-tag</c> of an XML element that provides the name of the element.<br /><br /><br />
	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Structure___19_0_3_68e0225_1638439875096_861809_26">model.mtconnect.org</seealso> for more information.
	/// </summary>
	
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public sealed class ElementNameClass : IClass
	{
		/// <summary>Constant value for <see cref="ElementNameClass.ReferenceId" /></summary>
		public const string REFERENCE_ID = "_19_0_3_68e0225_1638439875096_861809_26";
		/// <summary>Constant value for <see cref="ElementNameClass.HelpUrl" /></summary>
		public const string HELP_URL = "https://model.mtconnect.org/#Structure___19_0_3_68e0225_1638439875096_861809_26";
		/// <summary>Constant value for <see cref="ElementNameClass.Summary" /></summary>
		public const string SUMMARY = @"&#10;&#10;&#10;descriptive identifier contained in both the `start-tag` and `end-tag` of an XML element that provides the name of the element.&#10;
";
		/// <summary>Constant value for <see cref="ElementNameClass.Name" /></summary>
		public const string NAME = "element name";
		/// <summary>Constant value for <see cref="ElementNameClass.AccessModifier" /></summary>
		public const string ACCESS_MODIFIER = "public";
		/// <summary>Constant value for <see cref="ElementNameClass.Modifier" /></summary>
		public const string MODIFIER = "";
		/// <summary>Constant value for <see cref="ElementNameClass.NormativeVersion" /></summary>
		public const string NORMATIVE_VERSION = "";
		/// <summary>Constant value for <see cref="ElementNameClass.DeprecatedVersion" /></summary>
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
		public new ElementNameClassProperties Properties { get; } = new ElementNameClassProperties();
        IPropertyList IClass.Properties => Properties;
		/// <summary>
		/// Property list for <see cref="ElementNameClass" />.
		/// </summary>
		public class ElementNameClassProperties : IPropertyList
		{
			/// <inheritdoc />
			public virtual IProperty[] Properties => new IProperty[] {
			};
		};

	}
}