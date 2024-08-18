#pragma warning disable CS0109 // Member does not hide an inherited member; new keyword is not required
#pragma warning disable CS1574 // XML comment has cref attribute that could not be resolved
#pragma warning disable CS1584 // XML comment has syntactically incorrect cref attribute
using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;

namespace Mtconnect.Glossary.IndustrialTerms
{
	/// <summary>﻿property holder.<br /><br />&gt; Note 1 to entry: Property holders are used to define properties that have no specific owner, or “top level” properties. These properties are generally referenced by other properties. <seealso href="https://www.google.com/search?q=https://www.omg.org/spec/NIEM-UML/1.0&btnI=I">https://www.omg.org/spec/NIEM-UML/1.0</seealso><br /><br />&gt; Note 2 to entry: Property holder is equivalent to one topmost class of which all other classes are subclasses.<br /><br />!MTConnect Terms.png!<br /><br /><br />
	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Structure___19_0_3_45f01b9_1581733974550_623533_615">model.mtconnect.org</seealso> for more information.
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public sealed class ThingClass : IClass
	{
		/// <inheritdoc />
		public string ReferenceId => "_19_0_3_45f01b9_1581733974550_623533_615";
		
		/// <inheritdoc />
		public string Summary => @"&#10;&#10;&#10;property holder.

> Note 1 to entry: Property holders are used to define properties that have no specific owner, or “top level” properties. These properties are generally referenced by other properties. {{cite(https://www.omg.org/spec/NIEM-UML/1.0)}}

> Note 2 to entry: Property holder is equivalent to one topmost class of which all other classes are subclasses.

!MTConnect Terms.png!&#10;
";

		/// <inheritdoc />
		public string Name => "Thing";
		
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