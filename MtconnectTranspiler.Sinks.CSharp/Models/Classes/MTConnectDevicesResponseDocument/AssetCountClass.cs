#pragma warning disable CS0109 // Member does not hide an inherited member; new keyword is not required
#pragma warning disable CS1574 // XML comment has cref attribute that could not be resolved
#pragma warning disable CS1584 // XML comment has syntactically incorrect cref attribute
#pragma warning disable CS0618 // Type or member is obsolete
using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;

namespace Mtconnect.Fundamentals.MTConnectProtocol.MTConnectDevicesResponseDocument
{
	/// <summary>﻿count of each asset type currently in the <i>agent</i>.<br /><br /><br />
	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Structure___19_0_3_68e0225_1643803275261_762583_709">model.mtconnect.org</seealso> for more information.
	/// </summary>
	/// <remarks>
	/// <list type="bullet">
	/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.2">v1.2</see></item>
	/// <item><b>Deprecated</b>: <see href="https://model.mtconnect.org/#_Version_1.4">v1.4</see></item>
	/// </list>
	/// </remarks>
	[Obsolete("Deprecated in v1.4 according to https://model.mtconnect.org/#_Version_1.4")]

	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public sealed class AssetCountClass : IClass
	{
		/// <summary>Constant value for <see cref="AssetCountClass.ReferenceId" /></summary>
		public const string REFERENCE_ID = "_19_0_3_68e0225_1643803275261_762583_709";
		/// <summary>Constant value for <see cref="AssetCountClass.HelpUrl" /></summary>
		public const string HELP_URL = "https://model.mtconnect.org/#Structure___19_0_3_68e0225_1643803275261_762583_709";
		/// <summary>Constant value for <see cref="AssetCountClass.Summary" /></summary>
		public const string SUMMARY = @"&#10;&#10;&#10;count of each asset type currently in the {{term(agent)}}.&#10;
";
		/// <summary>Constant value for <see cref="AssetCountClass.Name" /></summary>
		public const string NAME = "AssetCount";
		/// <summary>Constant value for <see cref="AssetCountClass.AccessModifier" /></summary>
		public const string ACCESS_MODIFIER = "public";
		/// <summary>Constant value for <see cref="AssetCountClass.Modifier" /></summary>
		public const string MODIFIER = "";
		/// <summary>Constant value for <see cref="AssetCountClass.NormativeVersion" /></summary>
		public const string NORMATIVE_VERSION = "1.2";
		/// <summary>Constant value for <see cref="AssetCountClass.DeprecatedVersion" /></summary>
		public const string DEPRECATED_VERSION = "1.4";

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
		public new AssetCountClassProperties Properties { get; } = new AssetCountClassProperties();
        IPropertyList IClass.Properties => Properties;
		/// <summary>
		/// Property list for <see cref="AssetCountClass" />.
		/// </summary>
		public class AssetCountClassProperties : IPropertyList
		{
			/// <inheritdoc />
			public virtual IProperty[] Properties => new IProperty[] {
				AssetType,
			};
			/// <summary>
			/// <inheritdoc cref="AssetTypeProperty" path="/summary" /><br/>
			/// <remarks>Original Name: AssetType</remarks>
			/// </summary>
			public AssetTypeProperty AssetType { get; } = new AssetTypeProperty();
			
			/// <summary>﻿type of <i>Asset</i>.<br /><br /><br />
			/// </summary>
			public sealed class AssetTypeProperty : IProperty
			{
				/// <summary>Constant value for <see cref="AssetTypeProperty.Name" /></summary>
				public const string NAME = "assetType";
				/// <summary>Constant value for <see cref="AssetTypeProperty.Summary" /></summary>
				public const string SUMMARY = @"&#10;&#10;&#10;type of {{term(Asset)}}.&#10;
";
				/// <summary>Constant value for <see cref="AssetTypeProperty.AccessModifier" /></summary>
				public const string ACCESS_MODIFIER = "public";
				/// <summary>Constant value for <see cref="AssetTypeProperty.Modifier" /></summary>
				public const string MODIFIER = "";
				/// <summary>Constant value for <see cref="AssetTypeProperty.NormativeVersion" /></summary>
				public const string NORMATIVE_VERSION = "1.2";
				/// <summary>Constant value for <see cref="AssetTypeProperty.DeprecatedVersion" /></summary>
				public const string DEPRECATED_VERSION = "";
				/// <summary>Constant value for <see cref="AssetTypeProperty.Aggregation" /></summary>
				public const string AGGREGATION = "composite";
				/// <summary>Constant value for <see cref="AssetTypeProperty.Extension" /></summary>
				public const string EXTENSION = "MagicDraw UML 2024x";
				/// <summary>Constant value for <see cref="AssetTypeProperty.Association" /></summary>
				public const string ASSOCIATION = "";
				/// <summary>Constant value for <see cref="AssetTypeProperty.DefaultValue" /></summary>
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