using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;
using System.Linq;

namespace Mtconnect.Glossary
{
	/// <summary>
	﻿/// nested element that is above a lower level element.<br/><br />

	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Structure___19_0_3_68e0225_1623664375161_354685_1996">model.mtconnect.org</seealso> for more information.
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public sealed class HigherLevelClass : IClass
	{
		/// <inheritdoc />
		public string ReferenceId => "_19_0_3_68e0225_1623664375161_354685_1996";
		
		/// <inheritdoc />
		public string Summary => @"&#10;&#10;&#10;nested element that is above a lower level element.&#10;
";

		/// <inheritdoc />
		public string Name => "higher level";
		
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
		/// Original Type: _19_0_3_68e0225_1623664375178_894466_2058
		/// </remarks>
		public Type Generalization => typeof(Mtconnect.Glossary.XMLTerms.ParentElementGeneralization);

		/// <inheritdoc />
		public HigherLevelClassProperties Properties { get; } = new HigherLevelClassProperties();
        IPropertyList IClass.Properties => Properties;
		public class HigherLevelClassProperties : Mtconnect.Glossary.XMLTerms.ParentElementGeneralization.ParentElementGeneralizationProperties
		{
			/// <inheritdoc />
			public IProperty[] Properties => new IProperty[] {
			}.Concat(base.Properties).ToArray();
		};

	}
}