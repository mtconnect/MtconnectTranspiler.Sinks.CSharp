
using System;
using System.CodeDom.Compiler;

using Mtconnect.DataTypes;
using Mtconnect.AssetInformationModel.QIF;

namespace Mtconnect.AssetInformationModel.QIF
{
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "1.0.15.3")]
	public sealed class QIFDocumentWrapperClass
	{
		/// <inheritdoc cref="Class.ReferenceId" />
		public string ReferenceId => "_19_0_3_68e0225_1622119541205_751450_1761";
		
		/// <inheritdoc cref="Class.Name" />
		public string Name => "QIFDocumentWrapper";
		
		/// <inheritdoc cref="Class.AccessModifier" />
		public string AccessModifier => "public";
				
		/// <inheritdoc cref="Class.Modifier" />
		public string Modifier => "";
				
		/// <inheritdoc cref="Class.NormativeVersion" />
		public string NormativeVersion => "MtconnectVersions.V_1_8_0";
				
		/// <inheritdoc cref="Class.DeprecatedVersion" />
		public string DeprecatedVersion => "";

		public string Generalization => "";

		public QIFDocumentWrapperProperties Properties { get; } = new QIFDocumentWrapperProperties();
		public sealed class QIFDocumentWrapperProperties
		{
		
		
			/// <remarks>Original Name: QifDocumentType</remarks>
			public QifDocumentTypeProperty QifDocumentType { get; } = new QifDocumentTypeProperty();
			public sealed class QifDocumentTypeProperty
			{
				/// <inheritdoc cref="Property.Type" />
				/// Original Type: _19_0_3_68e0225_1622119656767_412574_1812
				public Type Type => typeof(QIFDocumentTypeEnum);
				
				/// <inheritdoc cref="Property.Name" />
				public string Name => "QifDocumentType";
				
				/// <inheritdoc cref="Property.AccessModifier" />
				public string AccessModifier => "public";
				
				/// <inheritdoc cref="Property.Modifier" />
				public string Modifier => "";
				
				/// <inheritdoc cref="Property.NormativeVersion" />
				public string NormativeVersion => "MtconnectVersions.V_1_8_0";
				
				/// <inheritdoc cref="Property.DeprecatedVersion" />
				public string DeprecatedVersion => "";
				
				public string Aggregation => "composite";

				// Note: Extension.Extender
				public string Extension => "MagicDraw UML 19.0";

				public string Association => "";

				// Note: DefaultValue.Name
				public string DefaultValue => "";

				// TODO: Add Summary
			}
		
		
			/// <remarks>Original Name: HasQIFDocument</remarks>
			public HasQIFDocumentPartProperty HasQIFDocumentPart { get; } = new HasQIFDocumentPartProperty();
			public sealed class HasQIFDocumentPartProperty
			{
				/// <inheritdoc cref="Property.Type" />
				/// Original Type: _19_0_3_68e0225_1622119794339_346750_1858
				public Type Type => typeof(QIFDocumentClass);
				
				/// <inheritdoc cref="Property.Name" />
				public string Name => "HasQIFDocument";
				
				/// <inheritdoc cref="Property.AccessModifier" />
				public string AccessModifier => "public";
				
				/// <inheritdoc cref="Property.Modifier" />
				public string Modifier => "";
				
				/// <inheritdoc cref="Property.NormativeVersion" />
				public string NormativeVersion => "";
				
				/// <inheritdoc cref="Property.DeprecatedVersion" />
				public string DeprecatedVersion => "";
				
				public string Aggregation => "composite";

				// Note: Extension.Extender
				public string Extension => "MagicDraw UML 19.0";

				public string Association => "QIFDocument";

				// Note: DefaultValue.Name
				public string DefaultValue => "";

				// TODO: Add Summary
			}
		};

	}
}