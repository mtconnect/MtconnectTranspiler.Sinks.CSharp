#pragma warning disable CS0109 // Member does not hide an inherited member; new keyword is not required
#pragma warning disable CS1574 // XML comment has cref attribute that could not be resolved
#pragma warning disable CS1584 // XML comment has syntactically incorrect cref attribute
#pragma warning disable CS0618 // Type or member is obsolete
using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;

namespace Mtconnect.Glossary.IndustrialTerms
{
	/// <summary>﻿property holder.<br /><br />&gt; Note 1 to entry: Property holders are used to define properties that have no specific owner, or “top level” properties. These properties are generally referenced by other properties. <seealso href="https://www.google.com/search?q=https://www.omg.org/spec/NIEM-UML/1.0&amp;btnI=I">https://www.omg.org/spec/NIEM-UML/1.0</seealso><br /><br />&gt; Note 2 to entry: Property holder is equivalent to one topmost class of which all other classes are subclasses.<br /><br />!MTConnect Terms.png!<br /><br /><br />
	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Structure___19_0_3_45f01b9_1581733974550_623533_615">model.mtconnect.org</seealso> for more information.
	/// </summary>
	
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public sealed class ThingClass : IClass
	{
		/// <summary>Constant value for <see cref="ThingClass.ReferenceId" /></summary>
		public const string REFERENCE_ID = "_19_0_3_45f01b9_1581733974550_623533_615";
		/// <summary>Constant value for <see cref="ThingClass.HelpUrl" /></summary>
		public const string HELP_URL = "https://model.mtconnect.org/#Structure___19_0_3_45f01b9_1581733974550_623533_615";
		/// <summary>Constant value for <see cref="ThingClass.Summary" /></summary>
		public const string SUMMARY = @"&#10;&#10;&#10;property holder.

> Note 1 to entry: Property holders are used to define properties that have no specific owner, or “top level” properties. These properties are generally referenced by other properties. {{cite(https://www.omg.org/spec/NIEM-UML/1.0)}}

> Note 2 to entry: Property holder is equivalent to one topmost class of which all other classes are subclasses.

!MTConnect Terms.png!&#10;
";
		/// <summary>Constant value for <see cref="ThingClass.Name" /></summary>
		public const string NAME = "Thing";
		/// <summary>Constant value for <see cref="ThingClass.AccessModifier" /></summary>
		public const string ACCESS_MODIFIER = "public";
		/// <summary>Constant value for <see cref="ThingClass.Modifier" /></summary>
		public const string MODIFIER = "";
		/// <summary>Constant value for <see cref="ThingClass.NormativeVersion" /></summary>
		public const string NORMATIVE_VERSION = "";
		/// <summary>Constant value for <see cref="ThingClass.DeprecatedVersion" /></summary>
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
		public new ThingClassProperties Properties { get; } = new ThingClassProperties();
        IPropertyList IClass.Properties => Properties;
		/// <summary>
		/// Property list for <see cref="ThingClass" />.
		/// </summary>
		public class ThingClassProperties : IPropertyList
		{
			/// <inheritdoc />
			public virtual IProperty[] Properties => new IProperty[] {
			};
		};

	}
}