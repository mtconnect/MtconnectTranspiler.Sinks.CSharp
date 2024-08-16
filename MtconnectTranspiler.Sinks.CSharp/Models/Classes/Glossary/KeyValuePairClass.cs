using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;

namespace Mtconnect.Glossary
{
	/// <summary>
	﻿/// association between an identifier referred to as the <i>key</i> and a value which taken together create a <i>key-value pair</i>. <br/><br />

	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Structure___19_0_3_68e0225_1623664375168_30138_2020">model.mtconnect.org</seealso> for more information.
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public sealed class KeyValuePairClass : IClass
	{
		/// <inheritdoc />
		public string ReferenceId => "_19_0_3_68e0225_1623664375168_30138_2020";
		
		/// <inheritdoc />
		public string Summary => @"&#10;&#10;&#10;association between an identifier referred to as the {{term(key)}} and a value which taken together create a {{term(key-value pair)}}. &#10;
";

		/// <inheritdoc />
		public string Name => "key-value pair";
		
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
		public KeyValuePairClassProperties Properties { get; } = new KeyValuePairClassProperties();
        IPropertyList IClass.Properties => Properties;
		public class KeyValuePairClassProperties : IPropertyList
		{
			/// <inheritdoc />
			public IProperty[] Properties => new IProperty[] {
			};
		};

	}
}