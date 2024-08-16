using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;

namespace Mtconnect.Glossary.MTConnectTerms
{
	/// <summary>
	﻿/// <i>interaction model</i> for interoperability between pieces of equipment.<br/><br />

	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Structure___19_0_3_68e0225_1623664375172_338577_2038">model.mtconnect.org</seealso> for more information.
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public sealed class MTConnectInterfaceClass : IClass
	{
		/// <inheritdoc />
		public string ReferenceId => "_19_0_3_68e0225_1623664375172_338577_2038";
		
		/// <inheritdoc />
		public string Summary => @"&#10;&#10;&#10;{{term(interaction model)}} for interoperability between pieces of equipment.&#10;
";

		/// <inheritdoc />
		public string Name => "MTConnect Interface";
		
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
		public MTConnectInterfaceClassProperties Properties { get; } = new MTConnectInterfaceClassProperties();
        IPropertyList IClass.Properties => Properties;
		public class MTConnectInterfaceClassProperties : IPropertyList
		{
			/// <inheritdoc />
			public IProperty[] Properties => new IProperty[] {
			};
		};

	}
}