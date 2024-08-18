#pragma warning disable CS0109 // Member does not hide an inherited member; new keyword is not required
#pragma warning disable CS1574 // XML comment has cref attribute that could not be resolved
#pragma warning disable CS1584 // XML comment has syntactically incorrect cref attribute
using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;
using System.Linq;

namespace Mtconnect.Glossary.XMLTerms
{
	/// <summary>﻿<i>element</i> of a data modeling structure that illustrates the relationship between itself and the lower-level <i>child element</i>.<br /><br /><br />
	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Structure___19_0_3_68e0225_1623664375178_894466_2058">model.mtconnect.org</seealso> for more information.
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public sealed class ParentElementGeneralization : IClass
	{
		/// <inheritdoc />
		public string ReferenceId => "_19_0_3_68e0225_1623664375178_894466_2058";
		
		/// <inheritdoc />
		public string Summary => @"&#10;&#10;&#10;{{term(element)}} of a data modeling structure that illustrates the relationship between itself and the lower-level {{term(child element)}}.&#10;
";

		/// <inheritdoc />
		public string Name => "parent element";
		
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
		/// Original Type: _19_0_3_68e0225_1623664375158_867680_1986
		/// </remarks>
		public Type Generalization => typeof(Mtconnect.Glossary.ElementClass);

		/// <inheritdoc />
		public new ParentElementGeneralizationProperties Properties { get; } = new ParentElementGeneralizationProperties();
        IPropertyList IClass.Properties => Properties;
		/// <summary>
		/// Property list for <see cref="ParentElementGeneralization" />.
		/// <br/><b>Note</b>, some properties (<see cref="IProperty" />) are inherited from <see cref="Mtconnect.Glossary.ElementClass.ElementClassProperties" />.
		/// </summary>
		public class ParentElementGeneralizationProperties : Mtconnect.Glossary.ElementClass.ElementClassProperties
		{
			/// <inheritdoc />
			public override IProperty[] Properties => new IProperty[] {
			}.Concat(base.Properties).ToArray();
		};

	}
}