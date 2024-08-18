#pragma warning disable CS0109 // Member does not hide an inherited member; new keyword is not required
#pragma warning disable CS1574 // XML comment has cref attribute that could not be resolved
#pragma warning disable CS1584 // XML comment has syntactically incorrect cref attribute
using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;
using System.Linq;

namespace Mtconnect.AssetInformationModel.QIF
{
	/// <summary>﻿<see cref="Asset">Asset</see> that carries the QIF Document.<br /><br /><br />
	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Structure___19_0_3_68e0225_1622119541205_751450_1761">model.mtconnect.org</seealso> for more information.
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public sealed class QIFDocumentWrapperClass : IClass
	{
		/// <inheritdoc />
		public string ReferenceId => "_19_0_3_68e0225_1622119541205_751450_1761";
		
		/// <inheritdoc />
		public string Summary => @"&#10;&#10;&#10;{{block(Asset)}} that carries the QIF Document.&#10;
";

		/// <inheritdoc />
		public string Name => "QIFDocumentWrapper";
		
		/// <inheritdoc />
		public string AccessModifier => "public";
				
		/// <inheritdoc />
		public string Modifier => "";
				
		/// <inheritdoc />
		public string NormativeVersion => "1.8";
				
		/// <inheritdoc />
		public string DeprecatedVersion => "";
		
		/// <inheritdoc />
		/// <remarks>
		/// Original Type: EAID_C7D39183_23CB_416b_A62D_F60815E08B1A
		/// </remarks>
		public Type Generalization => typeof(Mtconnect.AssetInformationModel.AssetClass);

		/// <inheritdoc />
		public new QIFDocumentWrapperClassProperties Properties { get; } = new QIFDocumentWrapperClassProperties();
        IPropertyList IClass.Properties => Properties;
		/// <summary>
		/// Property list for <see cref="QIFDocumentWrapperClass" />.
		/// <br/><b>Note</b>, some properties (<see cref="IProperty" />) are inherited from <see cref="Mtconnect.AssetInformationModel.AssetClass.AssetClassProperties" />.
		/// </summary>
		public class QIFDocumentWrapperClassProperties : Mtconnect.AssetInformationModel.AssetClass.AssetClassProperties
		{
			/// <inheritdoc />
			public new IProperty[] Properties => new IProperty[] {
				QifDocumentType,
				HasQIFDocumentPart,
			}.Concat(base.Properties).ToArray();
			/// <summary>
			/// <inheritdoc cref="QifDocumentTypeProperty" path="/summary" /><br/>
			/// <remarks>Original Name: QifDocumentType</remarks>
			/// </summary>
			public new QifDocumentTypeProperty QifDocumentType { get; } = new QifDocumentTypeProperty();
			
			/// <summary>﻿contained QIF Document type as defined in the <i>QIF</i> Standard.<br /><br /><br />
			/// </summary>
			public new sealed class QifDocumentTypeProperty : IProperty
			{
				/// <summary>
				/// <inheritdoc />
				/// <remarks>
				/// <list type="bullet">
				/// <item>Original Type: _19_0_3_68e0225_1622119656767_412574_1812</item>
				/// <item>Type: QIFDocumentTypeEnumMetaClass</item>
				/// <item>Namespace: Mtconnect.DataTypes</item>
				/// </list>
				/// </remarks>
				/// </summary>
				public System.Type Type => typeof(Mtconnect.DataTypes.QIFDocumentTypeEnumMetaClass);
				
				/// <inheritdoc />
				public string Name => "qifDocumentType";
				
				/// <inheritdoc />
				public string Summary => @"&#10;&#10;&#10;contained QIF Document type as defined in the {{term(QIF)}} Standard.&#10;
";

				/// <inheritdoc />
				public string AccessModifier => "public";
				
				/// <inheritdoc />
				public string Modifier => "";
				
				/// <inheritdoc />
				public string NormativeVersion => "1.8";
				
				/// <inheritdoc />
				public string DeprecatedVersion => "";
				
				/// <inheritdoc />
				public string Aggregation => "composite";

				// Note: Extension.Extender
				/// <inheritdoc />
				public string Extension => "MagicDraw UML 19.0";
				
				/// <inheritdoc />
				public string Association => "";

				// Note: DefaultValue.Name
				/// <inheritdoc />
				public string DefaultValue => "";
			}
			/// <summary>
			/// <inheritdoc cref="HasQIFDocumentPartProperty" path="/summary" /><br/>
			/// <remarks>Original Name: HasQIFDocument</remarks>
			/// </summary>
			public new HasQIFDocumentPartProperty HasQIFDocumentPart { get; } = new HasQIFDocumentPartProperty();
			
			/// <summary>﻿
			/// </summary>
			public new sealed class HasQIFDocumentPartProperty : IProperty
			{
				/// <summary>
				/// <inheritdoc />
				/// <remarks>
				/// <list type="bullet">
				/// <item>Original Type: _19_0_3_68e0225_1622119794339_346750_1858</item>
				/// <item>Type: QIFDocumentClass</item>
				/// <item>Namespace: Mtconnect.AssetInformationModel.QIF</item>
				/// </list>
				/// </remarks>
				/// </summary>
				public System.Type Type => typeof(Mtconnect.AssetInformationModel.QIF.QIFDocumentClass);
				
				/// <inheritdoc />
				public string Name => "hasQIFDocument";
				
				/// <inheritdoc />
				public string Summary => @"";

				/// <inheritdoc />
				public string AccessModifier => "public";
				
				/// <inheritdoc />
				public string Modifier => "";
				
				/// <inheritdoc />
				public string NormativeVersion => "";
				
				/// <inheritdoc />
				public string DeprecatedVersion => "";
				
				/// <inheritdoc />
				public string Aggregation => "composite";

				// Note: Extension.Extender
				/// <inheritdoc />
				public string Extension => "MagicDraw UML 19.0";
				
				/// <inheritdoc />
				public string Association => "QIFDocument";

				// Note: DefaultValue.Name
				/// <inheritdoc />
				public string DefaultValue => "";
			}
		};

	}
}