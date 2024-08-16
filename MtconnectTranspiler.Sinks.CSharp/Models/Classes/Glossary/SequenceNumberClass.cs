using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;

namespace Mtconnect.Glossary
{
	/// <summary>
	﻿/// primary key identifier used to manage and locate a specific piece of <i>streaming data</i> in an <i>agent</i>.<br/><br />

	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Structure___19_0_3_68e0225_1623664375186_193728_2090">model.mtconnect.org</seealso> for more information.
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public sealed class SequenceNumberClass : IClass
	{
		/// <inheritdoc />
		public string ReferenceId => "_19_0_3_68e0225_1623664375186_193728_2090";
		
		/// <inheritdoc />
		public string Summary => @"&#10;&#10;&#10;primary key identifier used to manage and locate a specific piece of {{term(streaming data)}} in an {{term(agent)}}.&#10;
";

		/// <inheritdoc />
		public string Name => "sequence number";
		
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
		public SequenceNumberClassProperties Properties { get; } = new SequenceNumberClassProperties();
        IPropertyList IClass.Properties => Properties;
		public class SequenceNumberClassProperties : IPropertyList
		{
			/// <inheritdoc />
			public IProperty[] Properties => new IProperty[] {
			};
		};

	}
}