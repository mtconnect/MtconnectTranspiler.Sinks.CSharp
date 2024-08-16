using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;
using System.Linq;

namespace Mtconnect.Glossary.ProtocolTerms
{
	/// <summary>
	﻿/// response <i>interface</i> which responds to a <i>request</i>.<br/><br />

	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Structure___19_0_3_68e0225_1623664375183_158651_2076">model.mtconnect.org</seealso> for more information.
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public sealed class ResponseClass : IClass
	{
		/// <inheritdoc />
		public string ReferenceId => "_19_0_3_68e0225_1623664375183_158651_2076";
		
		/// <inheritdoc />
		public string Summary => @"&#10;&#10;&#10;response {{term(interface)}} which responds to a {{term(request)}}.&#10;
";

		/// <inheritdoc />
		public string Name => "response";
		
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
		/// Original Type: _19_0_3_68e0225_1623664375180_471026_2065
		/// </remarks>
		public Type Generalization => typeof(Mtconnect.Glossary.ProtocolTerms.ProtocolClass);

		/// <inheritdoc />
		public ResponseClassProperties Properties { get; } = new ResponseClassProperties();
        IPropertyList IClass.Properties => Properties;
		public class ResponseClassProperties : Mtconnect.Glossary.ProtocolTerms.ProtocolClass.ProtocolClassProperties
		{
			/// <inheritdoc />
			public IProperty[] Properties => new IProperty[] {
			}.Concat(base.Properties).ToArray();
		};

	}
}