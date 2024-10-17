#pragma warning disable CS0109 // Member does not hide an inherited member; new keyword is not required
#pragma warning disable CS1574 // XML comment has cref attribute that could not be resolved
#pragma warning disable CS1584 // XML comment has syntactically incorrect cref attribute
#pragma warning disable CS0618 // Type or member is obsolete
using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;
using System.Linq;

namespace Mtconnect.AssetInformationModel.QIF
{
	/// <summary>﻿<see cref="Asset">Asset</see> that carries the QIF Document.<br /><br /><br />
	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Structure___19_0_3_68e0225_1622119541205_751450_1761">model.mtconnect.org</seealso> for more information.
	/// </summary>
	/// <remarks>
	/// <list type="bullet">
	/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.8">v1.8</see></item>
	/// </list>
	/// </remarks>

	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public sealed class QIFDocumentWrapperClass : IClass
	{
		/// <summary>Constant value for <see cref="QIFDocumentWrapperClass.ReferenceId" /></summary>
		public const string REFERENCE_ID = "_19_0_3_68e0225_1622119541205_751450_1761";
		/// <summary>Constant value for <see cref="QIFDocumentWrapperClass.HelpUrl" /></summary>
		public const string HELP_URL = "https://model.mtconnect.org/#Structure___19_0_3_68e0225_1622119541205_751450_1761";
		/// <summary>Constant value for <see cref="QIFDocumentWrapperClass.Summary" /></summary>
		public const string SUMMARY = @"&#10;&#10;&#10;{{block(Asset)}} that carries the QIF Document.&#10;
";
		/// <summary>Constant value for <see cref="QIFDocumentWrapperClass.Name" /></summary>
		public const string NAME = "QIFDocumentWrapper";
		/// <summary>Constant value for <see cref="QIFDocumentWrapperClass.AccessModifier" /></summary>
		public const string ACCESS_MODIFIER = "public";
		/// <summary>Constant value for <see cref="QIFDocumentWrapperClass.Modifier" /></summary>
		public const string MODIFIER = "";
		/// <summary>Constant value for <see cref="QIFDocumentWrapperClass.NormativeVersion" /></summary>
		public const string NORMATIVE_VERSION = "1.8";
		/// <summary>Constant value for <see cref="QIFDocumentWrapperClass.DeprecatedVersion" /></summary>
		public const string DEPRECATED_VERSION = "";

		/// <inheritdoc />
		public string ReferenceId => REFERENCE_ID;
		
		/// <inheritdoc />
		public string HelpUrl => HELP_URL;

		/// <inheritdoc />
		public string Summary => SUMMARY;

		/// <inheritdoc />
		public string Name => NAME;
		
		/// <inheritdoc />
		public string AccessModifier => ACCESS_MODIFIER;
				
		/// <inheritdoc />
		public string Modifier => MODIFIER;
				
		/// <inheritdoc />
		public string NormativeVersion => NORMATIVE_VERSION;
				
		/// <inheritdoc />
		public string DeprecatedVersion => DEPRECATED_VERSION;
		
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
			public override IProperty[] Properties => new IProperty[] {
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
				/// <summary>Constant value for <see cref="QifDocumentTypeProperty.Name" /></summary>
				public const string NAME = "qifDocumentType";
				/// <summary>Constant value for <see cref="QifDocumentTypeProperty.Summary" /></summary>
				public const string SUMMARY = @"&#10;&#10;&#10;contained QIF Document type as defined in the {{term(QIF)}} Standard.&#10;
";
				/// <summary>Constant value for <see cref="QifDocumentTypeProperty.AccessModifier" /></summary>
				public const string ACCESS_MODIFIER = "public";
				/// <summary>Constant value for <see cref="QifDocumentTypeProperty.Modifier" /></summary>
				public const string MODIFIER = "";
				/// <summary>Constant value for <see cref="QifDocumentTypeProperty.NormativeVersion" /></summary>
				public const string NORMATIVE_VERSION = "1.8";
				/// <summary>Constant value for <see cref="QifDocumentTypeProperty.DeprecatedVersion" /></summary>
				public const string DEPRECATED_VERSION = "";
				/// <summary>Constant value for <see cref="QifDocumentTypeProperty.Aggregation" /></summary>
				public const string AGGREGATION = "composite";
				/// <summary>Constant value for <see cref="QifDocumentTypeProperty.Extension" /></summary>
				public const string EXTENSION = "MagicDraw UML 2024x";
				/// <summary>Constant value for <see cref="QifDocumentTypeProperty.Association" /></summary>
				public const string ASSOCIATION = "";
				/// <summary>Constant value for <see cref="QifDocumentTypeProperty.DefaultValue" /></summary>
				public const string DEFAULT_VALUE = "";

				/// <summary>
				/// <inheritdoc />
				/// <remarks> Type: QIFDocumentTypeEnumMetaClass </remarks>
				/// </summary>
				public System.Type Type => typeof(Mtconnect.DataTypes.QIFDocumentTypeEnumMetaClass);
				
				/// <inheritdoc />
				public string Name => NAME;
				
				/// <inheritdoc />
				public string Summary => SUMMARY;

				/// <inheritdoc />
				public string AccessModifier => ACCESS_MODIFIER;
				
				/// <inheritdoc />
				public string Modifier => MODIFIER;
				
				/// <inheritdoc />
				public string NormativeVersion => NORMATIVE_VERSION;
				
				/// <inheritdoc />
				public string DeprecatedVersion => DEPRECATED_VERSION;
				
				/// <inheritdoc />
				public string Aggregation => AGGREGATION;

				// Note: Extension.Extender
				/// <inheritdoc />
				public string Extension => EXTENSION;
				
				/// <inheritdoc />
				public string Association => ASSOCIATION;

				// Note: DefaultValue.Name
				/// <inheritdoc />
				public string DefaultValue => DEFAULT_VALUE;
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
				/// <summary>Constant value for <see cref="HasQIFDocumentPartProperty.Name" /></summary>
				public const string NAME = "hasQIFDocument";
				/// <summary>Constant value for <see cref="HasQIFDocumentPartProperty.Summary" /></summary>
				public const string SUMMARY = @"";
				/// <summary>Constant value for <see cref="HasQIFDocumentPartProperty.AccessModifier" /></summary>
				public const string ACCESS_MODIFIER = "public";
				/// <summary>Constant value for <see cref="HasQIFDocumentPartProperty.Modifier" /></summary>
				public const string MODIFIER = "";
				/// <summary>Constant value for <see cref="HasQIFDocumentPartProperty.NormativeVersion" /></summary>
				public const string NORMATIVE_VERSION = "";
				/// <summary>Constant value for <see cref="HasQIFDocumentPartProperty.DeprecatedVersion" /></summary>
				public const string DEPRECATED_VERSION = "";
				/// <summary>Constant value for <see cref="HasQIFDocumentPartProperty.Aggregation" /></summary>
				public const string AGGREGATION = "composite";
				/// <summary>Constant value for <see cref="HasQIFDocumentPartProperty.Extension" /></summary>
				public const string EXTENSION = "MagicDraw UML 2024x";
				/// <summary>Constant value for <see cref="HasQIFDocumentPartProperty.Association" /></summary>
				public const string ASSOCIATION = "QIFDocument";
				/// <summary>Constant value for <see cref="HasQIFDocumentPartProperty.DefaultValue" /></summary>
				public const string DEFAULT_VALUE = "";

				/// <summary>
				/// <inheritdoc />
				/// <remarks> Type: QIFDocumentClass </remarks>
				/// </summary>
				public System.Type Type => typeof(Mtconnect.AssetInformationModel.QIF.QIFDocumentClass);
				
				/// <inheritdoc />
				public string Name => NAME;
				
				/// <inheritdoc />
				public string Summary => SUMMARY;

				/// <inheritdoc />
				public string AccessModifier => ACCESS_MODIFIER;
				
				/// <inheritdoc />
				public string Modifier => MODIFIER;
				
				/// <inheritdoc />
				public string NormativeVersion => NORMATIVE_VERSION;
				
				/// <inheritdoc />
				public string DeprecatedVersion => DEPRECATED_VERSION;
				
				/// <inheritdoc />
				public string Aggregation => AGGREGATION;

				// Note: Extension.Extender
				/// <inheritdoc />
				public string Extension => EXTENSION;
				
				/// <inheritdoc />
				public string Association => ASSOCIATION;

				// Note: DefaultValue.Name
				/// <inheritdoc />
				public string DefaultValue => DEFAULT_VALUE;
			}
		};

	}
}