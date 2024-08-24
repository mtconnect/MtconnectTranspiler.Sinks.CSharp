#pragma warning disable CS0109 // Member does not hide an inherited member; new keyword is not required
#pragma warning disable CS1574 // XML comment has cref attribute that could not be resolved
#pragma warning disable CS1584 // XML comment has syntactically incorrect cref attribute
#pragma warning disable CS0618 // Type or member is obsolete
using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;

namespace Mtconnect.Glossary
{
	/// <summary>﻿control placed on an element of a <i>feature</i> such as its size, location, or form, which may be a specification limit, a nominal with tolerance, or some other numerical or non-numerical control. <seealso href="https://www.google.com/search?q=QIF 3.0 3.4.29&amp;btnI=I">QIF 3.0 3.4.29</seealso>. <seealso href="https://www.google.com/search?q=AS9102-B&amp;btnI=I">AS9102-B</seealso>.<br /><br /><br />
	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Structure___19_0_3_68e0225_1677579209252_492424_316">model.mtconnect.org</seealso> for more information.
	/// </summary>
	/// <remarks>
	/// <list type="bullet">
	/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_2.2">v2.2</see></item>
	/// </list>
	/// </remarks>

	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public sealed class CharacteristicClass : IClass
	{
		/// <summary>Constant value for <see cref="CharacteristicClass.ReferenceId" /></summary>
		public const string REFERENCE_ID = "_19_0_3_68e0225_1677579209252_492424_316";
		/// <summary>Constant value for <see cref="CharacteristicClass.HelpUrl" /></summary>
		public const string HELP_URL = "https://model.mtconnect.org/#Structure___19_0_3_68e0225_1677579209252_492424_316";
		/// <summary>Constant value for <see cref="CharacteristicClass.Summary" /></summary>
		public const string SUMMARY = @"&#10;&#10;&#10;control placed on an element of a {{term(feature)}} such as its size, location, or form, which may be a specification limit, a nominal with tolerance, or some other numerical or non-numerical control. {{cite(QIF 3.0 3.4.29)}}. {{cite(AS9102-B)}}.&#10;
";
		/// <summary>Constant value for <see cref="CharacteristicClass.Name" /></summary>
		public const string NAME = "characteristic";
		/// <summary>Constant value for <see cref="CharacteristicClass.AccessModifier" /></summary>
		public const string ACCESS_MODIFIER = "public";
		/// <summary>Constant value for <see cref="CharacteristicClass.Modifier" /></summary>
		public const string MODIFIER = "";
		/// <summary>Constant value for <see cref="CharacteristicClass.NormativeVersion" /></summary>
		public const string NORMATIVE_VERSION = "2.2";
		/// <summary>Constant value for <see cref="CharacteristicClass.DeprecatedVersion" /></summary>
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
		public new CharacteristicClassProperties Properties { get; } = new CharacteristicClassProperties();
        IPropertyList IClass.Properties => Properties;
		/// <summary>
		/// Property list for <see cref="CharacteristicClass" />.
		/// </summary>
		public class CharacteristicClassProperties : IPropertyList
		{
			/// <inheritdoc />
			public virtual IProperty[] Properties => new IProperty[] {
			};
		};

	}
}