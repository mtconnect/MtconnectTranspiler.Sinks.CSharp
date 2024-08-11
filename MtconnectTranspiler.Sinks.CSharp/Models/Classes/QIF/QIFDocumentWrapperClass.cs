using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;
using System.Linq;

namespace Mtconnect.AssetInformationModel.QIF
{
	/// <summary>
	/// <see cref="Asset">Asset</see> that carries the QIF Document.
	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Structure___19_0_3_68e0225_1622119541205_751450_1761">model.mtconnect.org</seealso> for more information.
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.3.0.0")]
	public sealed class QIFDocumentWrapperClass : IClass
	{
		/// <inheritdoc />
		public string ReferenceId => "_19_0_3_68e0225_1622119541205_751450_1761";
		
		/// <inheritdoc />
		public string Summary => @"/// <see cref=""Asset"">Asset</see> that carries the QIF Document.";

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
		public QIFDocumentWrapperClassProperties Properties { get; } = new QIFDocumentWrapperClassProperties();
        IPropertyList IClass.Properties => Properties;
		public class QIFDocumentWrapperClassProperties : Mtconnect.AssetInformationModel.AssetClass.AssetClassProperties
		{
			/// <inheritdoc />
			public IProperty[] Properties => new IProperty[] {
				QifDocumentType,
				HasQIFDocumentPart,
			}.Concat(base.Properties).ToArray();
			/// <summary>
			/// <inheritdoc cref="QifDocumentTypeProperty" path="/summary" /><br/>
			/// <remarks>Original Name: QifDocumentType</remarks>
			/// </summary>
			public QifDocumentTypeProperty QifDocumentType { get; } = new QifDocumentTypeProperty();
			/// <summary>
			/// contained QIF Document type as defined in the <i>QIF</i> Standard.
			/// </summary>
			public sealed class QifDocumentTypeProperty : IProperty
			{
				/// <summary>
				/// <inheritdoc />
				/// <remarks>
				/// <list type="bullet">
				/// <item>Original Type: _19_0_3_68e0225_1622119656767_412574_1812</item>
				/// <item>Type: QIFDocumentTypeEnum</item>
				/// <item>Namespace: Mtconnect.DataTypes</item>
				/// </list>
				/// </remarks>
				/// </summary>
				public System.Type Type => typeof(Mtconnect.DataTypes.QIFDocumentTypeEnum);
				
				/// <inheritdoc />
				public string Name => "qifDocumentType";
				
				/// <inheritdoc />
				public string Summary => @"/// <see cref=""Asset"">Asset</see> that carries the QIF Document.";

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
			public HasQIFDocumentPartProperty HasQIFDocumentPart { get; } = new HasQIFDocumentPartProperty();
			public sealed class HasQIFDocumentPartProperty : IProperty
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
				public string Summary => @"/// <see cref=""Asset"">Asset</see> that carries the QIF Document.";

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