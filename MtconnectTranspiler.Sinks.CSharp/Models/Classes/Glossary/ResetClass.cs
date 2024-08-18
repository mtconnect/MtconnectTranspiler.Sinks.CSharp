#pragma warning disable CS0109 // Member does not hide an inherited member; new keyword is not required
#pragma warning disable CS1574 // XML comment has cref attribute that could not be resolved
#pragma warning disable CS1584 // XML comment has syntactically incorrect cref attribute
using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;

namespace Mtconnect.Glossary
{
	/// <summary>﻿act of reverting back the accumulated value or statistic to their initial value.<br /><br />&gt; Note: An <i>Observation</i> with a <i>data set</i> representation removes all <i>key-value pair</i>s, setting the <i>data set</i> to an empty set.<br /><br /><br /><br /><br />
	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Structure___19_0_3_68e0225_1623664375182_524550_2074">model.mtconnect.org</seealso> for more information.
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public sealed class ResetClass : IClass
	{
		/// <inheritdoc />
		public string ReferenceId => "_19_0_3_68e0225_1623664375182_524550_2074";
		
		/// <inheritdoc />
		public string Summary => @"&#10;&#10;&#10;act of reverting back the accumulated value or statistic to their initial value.

> Note: An {{term(Observation)}} with a {{term(data set)}} representation removes all {{termplural(key-value pair)}}, setting the {{term(data set)}} to an empty set.

&#10;
";

		/// <inheritdoc />
		public string Name => "reset";
		
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
		public new ResetClassProperties Properties { get; } = new ResetClassProperties();
        IPropertyList IClass.Properties => Properties;
		/// <summary>
		/// Property list for <see cref="ResetClass" />.
		/// </summary>
		public class ResetClassProperties : IPropertyList
		{
			/// <inheritdoc />
			public virtual IProperty[] Properties => new IProperty[] {
			};
		};

	}
}