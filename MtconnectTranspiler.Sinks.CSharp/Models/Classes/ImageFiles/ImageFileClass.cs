#pragma warning disable CS0109 // Member does not hide an inherited member; new keyword is not required
#pragma warning disable CS1574 // XML comment has cref attribute that could not be resolved
#pragma warning disable CS1584 // XML comment has syntactically incorrect cref attribute
#pragma warning disable CS0618 // Type or member is obsolete
using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;

namespace Mtconnect.DeviceInformationModel.Configurations.ImageFiles
{
	/// <summary>﻿reference to a file containing an image of the <see cref="Component">Component</see>.<br /><br /><br />
	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Structure___19_0_3_68e0225_1677585025728_765757_660">model.mtconnect.org</seealso> for more information.
	/// </summary>
	/// <remarks>
	/// <list type="bullet">
	/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_2.2">v2.2</see></item>
	/// </list>
	/// </remarks>

	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public sealed class ImageFileClass : IClass
	{
		/// <summary>Constant value for <see cref="ImageFileClass.ReferenceId" /></summary>
		public const string REFERENCE_ID = "_19_0_3_68e0225_1677585025728_765757_660";
		/// <summary>Constant value for <see cref="ImageFileClass.HelpUrl" /></summary>
		public const string HELP_URL = "https://model.mtconnect.org/#Structure___19_0_3_68e0225_1677585025728_765757_660";
		/// <summary>Constant value for <see cref="ImageFileClass.Summary" /></summary>
		public const string SUMMARY = @"&#10;&#10;&#10;reference to a file containing an image of the {{block(Component)}}.&#10;
";
		/// <summary>Constant value for <see cref="ImageFileClass.Name" /></summary>
		public const string NAME = "ImageFile";
		/// <summary>Constant value for <see cref="ImageFileClass.AccessModifier" /></summary>
		public const string ACCESS_MODIFIER = "public";
		/// <summary>Constant value for <see cref="ImageFileClass.Modifier" /></summary>
		public const string MODIFIER = "";
		/// <summary>Constant value for <see cref="ImageFileClass.NormativeVersion" /></summary>
		public const string NORMATIVE_VERSION = "2.2";
		/// <summary>Constant value for <see cref="ImageFileClass.DeprecatedVersion" /></summary>
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
		public Type Generalization => null;

		/// <inheritdoc />
		public new ImageFileClassProperties Properties { get; } = new ImageFileClassProperties();
        IPropertyList IClass.Properties => Properties;
		/// <summary>
		/// Property list for <see cref="ImageFileClass" />.
		/// </summary>
		public class ImageFileClassProperties : IPropertyList
		{
			/// <inheritdoc />
			public virtual IProperty[] Properties => new IProperty[] {
				Id,
				Href,
				MediaType,
				Name,
			};
			/// <summary>
			/// <inheritdoc cref="IdProperty" path="/summary" /><br/>
			/// <remarks>Original Name: Id</remarks>
			/// </summary>
			public IdProperty Id { get; } = new IdProperty();
			
			/// <summary>﻿unique identifier of the image file.<br /><br /><br />
			/// </summary>
			public sealed class IdProperty : IProperty
			{
				/// <summary>Constant value for <see cref="IdProperty.Name" /></summary>
				public const string NAME = "id";
				/// <summary>Constant value for <see cref="IdProperty.Summary" /></summary>
				public const string SUMMARY = @"&#10;&#10;&#10;unique identifier of the image file.&#10;
";
				/// <summary>Constant value for <see cref="IdProperty.AccessModifier" /></summary>
				public const string ACCESS_MODIFIER = "public";
				/// <summary>Constant value for <see cref="IdProperty.Modifier" /></summary>
				public const string MODIFIER = "";
				/// <summary>Constant value for <see cref="IdProperty.NormativeVersion" /></summary>
				public const string NORMATIVE_VERSION = "2.2";
				/// <summary>Constant value for <see cref="IdProperty.DeprecatedVersion" /></summary>
				public const string DEPRECATED_VERSION = "";
				/// <summary>Constant value for <see cref="IdProperty.Aggregation" /></summary>
				public const string AGGREGATION = "composite";
				/// <summary>Constant value for <see cref="IdProperty.Extension" /></summary>
				public const string EXTENSION = "MagicDraw UML 2024x";
				/// <summary>Constant value for <see cref="IdProperty.Association" /></summary>
				public const string ASSOCIATION = "";
				/// <summary>Constant value for <see cref="IdProperty.DefaultValue" /></summary>
				public const string DEFAULT_VALUE = "";

				/// <summary>
				/// <inheritdoc />
				/// <remarks> Type: String </remarks>
				/// </summary>
				public System.Type Type => typeof(String);
				
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
			/// <inheritdoc cref="HrefProperty" path="/summary" /><br/>
			/// <remarks>Original Name: Href</remarks>
			/// </summary>
			public HrefProperty Href { get; } = new HrefProperty();
			
			/// <summary>﻿<i>URL</i> giving the location of the image file.<br /><br /><br />
			/// </summary>
			public sealed class HrefProperty : IProperty
			{
				/// <summary>Constant value for <see cref="HrefProperty.Name" /></summary>
				public const string NAME = "href";
				/// <summary>Constant value for <see cref="HrefProperty.Summary" /></summary>
				public const string SUMMARY = @"&#10;&#10;&#10;{{term(URL)}} giving the location of the image file.&#10;
";
				/// <summary>Constant value for <see cref="HrefProperty.AccessModifier" /></summary>
				public const string ACCESS_MODIFIER = "public";
				/// <summary>Constant value for <see cref="HrefProperty.Modifier" /></summary>
				public const string MODIFIER = "";
				/// <summary>Constant value for <see cref="HrefProperty.NormativeVersion" /></summary>
				public const string NORMATIVE_VERSION = "2.2";
				/// <summary>Constant value for <see cref="HrefProperty.DeprecatedVersion" /></summary>
				public const string DEPRECATED_VERSION = "";
				/// <summary>Constant value for <see cref="HrefProperty.Aggregation" /></summary>
				public const string AGGREGATION = "composite";
				/// <summary>Constant value for <see cref="HrefProperty.Extension" /></summary>
				public const string EXTENSION = "MagicDraw UML 2024x";
				/// <summary>Constant value for <see cref="HrefProperty.Association" /></summary>
				public const string ASSOCIATION = "";
				/// <summary>Constant value for <see cref="HrefProperty.DefaultValue" /></summary>
				public const string DEFAULT_VALUE = "";

				/// <summary>
				/// <inheritdoc />
				/// <remarks> Type: String </remarks>
				/// </summary>
				public System.Type Type => typeof(String);
				
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
			/// <inheritdoc cref="MediaTypeProperty" path="/summary" /><br/>
			/// <remarks>Original Name: MediaType</remarks>
			/// </summary>
			public MediaTypeProperty MediaType { get; } = new MediaTypeProperty();
			
			/// <summary>﻿mime type of the image file.<br /><br /><br /><br />
			/// </summary>
			public sealed class MediaTypeProperty : IProperty
			{
				/// <summary>Constant value for <see cref="MediaTypeProperty.Name" /></summary>
				public const string NAME = "mediaType";
				/// <summary>Constant value for <see cref="MediaTypeProperty.Summary" /></summary>
				public const string SUMMARY = @"&#10;&#10;&#10;mime type of the image file.&#10;
";
				/// <summary>Constant value for <see cref="MediaTypeProperty.AccessModifier" /></summary>
				public const string ACCESS_MODIFIER = "public";
				/// <summary>Constant value for <see cref="MediaTypeProperty.Modifier" /></summary>
				public const string MODIFIER = "";
				/// <summary>Constant value for <see cref="MediaTypeProperty.NormativeVersion" /></summary>
				public const string NORMATIVE_VERSION = "2.2";
				/// <summary>Constant value for <see cref="MediaTypeProperty.DeprecatedVersion" /></summary>
				public const string DEPRECATED_VERSION = "";
				/// <summary>Constant value for <see cref="MediaTypeProperty.Aggregation" /></summary>
				public const string AGGREGATION = "composite";
				/// <summary>Constant value for <see cref="MediaTypeProperty.Extension" /></summary>
				public const string EXTENSION = "MagicDraw UML 2024x";
				/// <summary>Constant value for <see cref="MediaTypeProperty.Association" /></summary>
				public const string ASSOCIATION = "";
				/// <summary>Constant value for <see cref="MediaTypeProperty.DefaultValue" /></summary>
				public const string DEFAULT_VALUE = "";

				/// <summary>
				/// <inheritdoc />
				/// <remarks> Type: String </remarks>
				/// </summary>
				public System.Type Type => typeof(String);
				
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
			/// <inheritdoc cref="NameProperty" path="/summary" /><br/>
			/// <remarks>Original Name: Name</remarks>
			/// </summary>
			public NameProperty Name { get; } = new NameProperty();
			
			/// <summary>﻿description of the image file.<br /><br /><br />
			/// </summary>
			public sealed class NameProperty : IProperty
			{
				/// <summary>Constant value for <see cref="NameProperty.Name" /></summary>
				public const string NAME = "name";
				/// <summary>Constant value for <see cref="NameProperty.Summary" /></summary>
				public const string SUMMARY = @"&#10;&#10;&#10;description of the image file.&#10;
";
				/// <summary>Constant value for <see cref="NameProperty.AccessModifier" /></summary>
				public const string ACCESS_MODIFIER = "public";
				/// <summary>Constant value for <see cref="NameProperty.Modifier" /></summary>
				public const string MODIFIER = "";
				/// <summary>Constant value for <see cref="NameProperty.NormativeVersion" /></summary>
				public const string NORMATIVE_VERSION = "";
				/// <summary>Constant value for <see cref="NameProperty.DeprecatedVersion" /></summary>
				public const string DEPRECATED_VERSION = "";
				/// <summary>Constant value for <see cref="NameProperty.Aggregation" /></summary>
				public const string AGGREGATION = "composite";
				/// <summary>Constant value for <see cref="NameProperty.Extension" /></summary>
				public const string EXTENSION = "MagicDraw UML 2024x";
				/// <summary>Constant value for <see cref="NameProperty.Association" /></summary>
				public const string ASSOCIATION = "";
				/// <summary>Constant value for <see cref="NameProperty.DefaultValue" /></summary>
				public const string DEFAULT_VALUE = "";

				/// <summary>
				/// <inheritdoc />
				/// <remarks> Type: String </remarks>
				/// </summary>
				public System.Type Type => typeof(String);
				
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