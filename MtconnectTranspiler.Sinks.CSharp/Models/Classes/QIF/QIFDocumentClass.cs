using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;

namespace Mtconnect.AssetInformationModel.QIF
{
	/// <summary>
	﻿/// QIF Document as given by the <i>QIF</i> standard.<br/><br />

	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Structure___19_0_3_68e0225_1622119794339_346750_1858">model.mtconnect.org</seealso> for more information.
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public sealed class QIFDocumentClass : IClass
	{
		/// <inheritdoc />
		public string ReferenceId => "_19_0_3_68e0225_1622119794339_346750_1858";
		
		/// <inheritdoc />
		public string Summary => @"&#10;&#10;&#10;QIF Document as given by the {{term(QIF)}} standard.&#10;
";

		/// <inheritdoc />
		public string Name => "QIFDocument";
		
		/// <inheritdoc />
		public string AccessModifier => "public";
				
		/// <inheritdoc />
		public string Modifier => "";
				
		/// <inheritdoc />
		public string NormativeVersion => "1.8";
				
		/// <inheritdoc />
		public string DeprecatedVersion => "";
		
		/// <inheritdoc />
		public Type Generalization => null;

		/// <inheritdoc />
		public QIFDocumentClassProperties Properties { get; } = new QIFDocumentClassProperties();
        IPropertyList IClass.Properties => Properties;
		public class QIFDocumentClassProperties : IPropertyList
		{
			/// <inheritdoc />
			public IProperty[] Properties => new IProperty[] {
			};
		};

	}
}