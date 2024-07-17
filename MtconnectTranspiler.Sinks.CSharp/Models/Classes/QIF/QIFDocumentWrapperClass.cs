using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;
// using Mtconnect.DataTypes;
// using Mtconnect.AssetInformationModel.QIF;

namespace Mtconnect.AssetInformationModel.QIF
{
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "1.0.15.3")]
	public sealed class QIFDocumentWrapperClass : IClass
	{
		/// <inheritdoc />
		public string ReferenceId => "_19_0_3_68e0225_1622119541205_751450_1761";
		
		/// <inheritdoc />
		public string Name => "QIFDocumentWrapperClass";
		
		/// <inheritdoc />
		public string AccessModifier => "public";
				
		/// <inheritdoc />
		public string Modifier => "";
				
		/// <inheritdoc />
		public string NormativeVersion => "1.8";
				
		/// <inheritdoc />
		public string DeprecatedVersion => "";
		
		/// <inheritdoc />
		public string Generalization => "EAID_C7D39183_23CB_416b_A62D_F60815E08B1A";

		/// <inheritdoc />
		public QIFDocumentWrapperClassProperties Properties { get; } = new QIFDocumentWrapperClassProperties();
        IPropertyList IClass.Properties => Properties;
		public sealed class QIFDocumentWrapperClassProperties : IPropertyList
		{
			/// <inheritdoc />
			public IProperty[] Properties => new IProperty[] {
				QifDocumentType,
				HasQIFDocumentPart,
			};
			/// <remarks>Original Name: QifDocumentType</remarks>
			public QifDocumentTypeProperty QifDocumentType { get; } = new QifDocumentTypeProperty();
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
				public string Name => "QifDocumentType";
				
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

				// TODO: Add Summary
			}
			/// <remarks>Original Name: HasQIFDocument</remarks>
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
				public string Name => "HasQIFDocument";
				
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

				// TODO: Add Summary
			}
		};

	}
}