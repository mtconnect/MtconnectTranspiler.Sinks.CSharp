#pragma warning disable CS0109 // Member does not hide an inherited member; new keyword is not required
#pragma warning disable CS1574 // XML comment has cref attribute that could not be resolved
#pragma warning disable CS1584 // XML comment has syntactically incorrect cref attribute
#pragma warning disable CS0618 // Type or member is obsolete
using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;

namespace Mtconnect.AssetInformationModel.Files
{
	/// <summary>﻿<i>URL</i> reference to the file location. <br /><br /><br />
	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Structure___19_0_3_68e0225_1605277122154_664309_406">model.mtconnect.org</seealso> for more information.
	/// </summary>
	/// <remarks>
	/// <list type="bullet">
	/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.7">v1.7</see></item>
	/// </list>
	/// </remarks>

	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public sealed class FileLocationClass : IClass
	{
		/// <summary>Constant value for <see cref="FileLocationClass.ReferenceId" /></summary>
		public const string REFERENCE_ID = "_19_0_3_68e0225_1605277122154_664309_406";
		/// <summary>Constant value for <see cref="FileLocationClass.HelpUrl" /></summary>
		public const string HELP_URL = "https://model.mtconnect.org/#Structure___19_0_3_68e0225_1605277122154_664309_406";
		/// <summary>Constant value for <see cref="FileLocationClass.Summary" /></summary>
		public const string SUMMARY = @"&#10;&#10;&#10;{{term(URL)}} reference to the file location. &#10;
";
		/// <summary>Constant value for <see cref="FileLocationClass.Name" /></summary>
		public const string NAME = "FileLocation";
		/// <summary>Constant value for <see cref="FileLocationClass.AccessModifier" /></summary>
		public const string ACCESS_MODIFIER = "public";
		/// <summary>Constant value for <see cref="FileLocationClass.Modifier" /></summary>
		public const string MODIFIER = "";
		/// <summary>Constant value for <see cref="FileLocationClass.NormativeVersion" /></summary>
		public const string NORMATIVE_VERSION = "1.7";
		/// <summary>Constant value for <see cref="FileLocationClass.DeprecatedVersion" /></summary>
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
		public new FileLocationClassProperties Properties { get; } = new FileLocationClassProperties();
        IPropertyList IClass.Properties => Properties;
		/// <summary>
		/// Property list for <see cref="FileLocationClass" />.
		/// </summary>
		public class FileLocationClassProperties : IPropertyList
		{
			/// <inheritdoc />
			public virtual IProperty[] Properties => new IProperty[] {
				Href,
				Xlink_Type,
			};
			/// <summary>
			/// <inheritdoc cref="HrefProperty" path="/summary" /><br/>
			/// <remarks>Original Name: Href</remarks>
			/// </summary>
			public HrefProperty Href { get; } = new HrefProperty();
			
			/// <summary>﻿<i>URL</i> reference to the file.<br /><br /><c>href</c> is of type <c>xlink:href</c> from the W3C XLink specification.<br /><br /><br /><br />
			/// </summary>
			public sealed class HrefProperty : IProperty
			{
				/// <summary>Constant value for <see cref="HrefProperty.Name" /></summary>
				public const string NAME = "href";
				/// <summary>Constant value for <see cref="HrefProperty.Summary" /></summary>
				public const string SUMMARY = @"&#10;&#10;&#10;{{term(URL)}} reference to the file.

`href` is of type `xlink:href` from the W3C XLink specification.&#10;
";
				/// <summary>Constant value for <see cref="HrefProperty.AccessModifier" /></summary>
				public const string ACCESS_MODIFIER = "public";
				/// <summary>Constant value for <see cref="HrefProperty.Modifier" /></summary>
				public const string MODIFIER = "";
				/// <summary>Constant value for <see cref="HrefProperty.NormativeVersion" /></summary>
				public const string NORMATIVE_VERSION = "1.7";
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
			/// <inheritdoc cref="Xlink_TypeProperty" path="/summary" /><br/>
			/// <remarks>Original Name: Xlink:Type</remarks>
			/// </summary>
			public Xlink_TypeProperty Xlink_Type { get; } = new Xlink_TypeProperty();
			
			/// <summary>﻿type of href for the xlink href type. <br /><br /><b>MUST</b> be <c>locator</c> referring to a <i>URL</i><br />.<br /><br /><br />
			/// </summary>
			public sealed class Xlink_TypeProperty : IProperty
			{
				/// <summary>Constant value for <see cref="Xlink_TypeProperty.Name" /></summary>
				public const string NAME = "xlink:type";
				/// <summary>Constant value for <see cref="Xlink_TypeProperty.Summary" /></summary>
				public const string SUMMARY = @"&#10;&#10;&#10;type of href for the xlink href type. 

**MUST** be `locator` referring to a {{term(URL)}}.&#10;
";
				/// <summary>Constant value for <see cref="Xlink_TypeProperty.AccessModifier" /></summary>
				public const string ACCESS_MODIFIER = "public";
				/// <summary>Constant value for <see cref="Xlink_TypeProperty.Modifier" /></summary>
				public const string MODIFIER = "";
				/// <summary>Constant value for <see cref="Xlink_TypeProperty.NormativeVersion" /></summary>
				public const string NORMATIVE_VERSION = "1.7";
				/// <summary>Constant value for <see cref="Xlink_TypeProperty.DeprecatedVersion" /></summary>
				public const string DEPRECATED_VERSION = "";
				/// <summary>Constant value for <see cref="Xlink_TypeProperty.Aggregation" /></summary>
				public const string AGGREGATION = "composite";
				/// <summary>Constant value for <see cref="Xlink_TypeProperty.Extension" /></summary>
				public const string EXTENSION = "MagicDraw UML 2024x";
				/// <summary>Constant value for <see cref="Xlink_TypeProperty.Association" /></summary>
				public const string ASSOCIATION = "";
				/// <summary>Constant value for <see cref="Xlink_TypeProperty.DefaultValue" /></summary>
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