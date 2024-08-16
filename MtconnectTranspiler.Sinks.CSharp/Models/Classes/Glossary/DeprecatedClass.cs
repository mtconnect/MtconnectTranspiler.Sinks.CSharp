using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;

namespace Mtconnect.Glossary
{
	/// <summary>
	﻿/// indication that specific content in an <i>MTConnect Document</i> is currently usable but is regarded as being obsolete or superseded. <br/><br />

	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Structure___19_0_3_68e0225_1623664375155_885919_1978">model.mtconnect.org</seealso> for more information.
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public sealed class DeprecatedClass : IClass
	{
		/// <inheritdoc />
		public string ReferenceId => "_19_0_3_68e0225_1623664375155_885919_1978";
		
		/// <inheritdoc />
		public string Summary => @"&#10;&#10;&#10;indication that specific content in an {{term(MTConnect Document)}} is currently usable but is regarded as being obsolete or superseded. &#10;
";

		/// <inheritdoc />
		public string Name => "deprecated";
		
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
		public DeprecatedClassProperties Properties { get; } = new DeprecatedClassProperties();
        IPropertyList IClass.Properties => Properties;
		public class DeprecatedClassProperties : IPropertyList
		{
			/// <inheritdoc />
			public IProperty[] Properties => new IProperty[] {
			};
		};

	}
}