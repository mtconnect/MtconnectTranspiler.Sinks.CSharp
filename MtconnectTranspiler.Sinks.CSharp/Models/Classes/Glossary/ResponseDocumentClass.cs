using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;
using System.Linq;

namespace Mtconnect.Glossary
{
	/// <summary>
	﻿/// electronic <i>document</i> published by an <i>MTConnect Agent</i> in response to a <i>probe request</i>, <i>current request</i>, <i>sample request</i> or <i>asset request</i>.<br/><br />

	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Structure___19_0_3_68e0225_1623664375183_185849_2077">model.mtconnect.org</seealso> for more information.
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public sealed class ResponseDocumentClass : IClass
	{
		/// <inheritdoc />
		public string ReferenceId => "_19_0_3_68e0225_1623664375183_185849_2077";
		
		/// <inheritdoc />
		public string Summary => @"&#10;&#10;&#10;electronic {{term(document)}} published by an {{term(MTConnect Agent)}} in response to a {{term(probe request)}}, {{term(current request)}}, {{term(sample request)}} or {{term(asset request)}}.&#10;
";

		/// <inheritdoc />
		public string Name => "response document";
		
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
		/// Original Type: _19_0_3_68e0225_1623664375173_527411_2040
		/// </remarks>
		public Type Generalization => typeof(Mtconnect.Glossary.ProtocolTerms.MTConnectResponseDocumentClass);

		/// <inheritdoc />
		public ResponseDocumentClassProperties Properties { get; } = new ResponseDocumentClassProperties();
        IPropertyList IClass.Properties => Properties;
		public class ResponseDocumentClassProperties : Mtconnect.Glossary.ProtocolTerms.MTConnectResponseDocumentClass.MTConnectResponseDocumentClassProperties
		{
			/// <inheritdoc />
			public IProperty[] Properties => new IProperty[] {
			}.Concat(base.Properties).ToArray();
		};

	}
}