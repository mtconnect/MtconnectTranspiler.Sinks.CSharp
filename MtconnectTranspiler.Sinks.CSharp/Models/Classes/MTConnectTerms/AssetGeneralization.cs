#pragma warning disable CS0109 // Member does not hide an inherited member; new keyword is not required
#pragma warning disable CS1574 // XML comment has cref attribute that could not be resolved
#pragma warning disable CS1584 // XML comment has syntactically incorrect cref attribute
#pragma warning disable CS0618 // Type or member is obsolete
using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;
using System.Linq;

namespace Mtconnect.Glossary.MTConnectTerms
{
	/// <summary>﻿<i>asset</i> that is used by the manufacturing process to perform tasks.<br /><br />&gt; Note 1 to entry: An <i>Asset</i> relies upon an <i>Device</i> to provide <i>observation</i>s and information about itself and the <i>Device</i> revises the information to reflect changes to the <i>Asset</i> during their interaction. Examples of <i>Asset</i>s are cutting tools, Part Information, Manufacturing Processes, Fixtures, and Files.<br /><br />&gt; Note 2 to entry: A singular <see cref="Asset.assetId">assetId in Asset</see> uniquely identifies an <i>Asset</i> throughout its lifecycle and is used to track and relate the <i>Asset</i> to other <i>Device</i>s and entities.<br /><br />&gt; Note 3 to entry: <i>Asset</i>s are temporally associated with a device and can be removed from the device without damage or alteration to its primary functions.<br /><br /><br /><br /><br />
	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Structure___19_0_3_45f01b9_1581734255313_425984_984">model.mtconnect.org</seealso> for more information.
	/// </summary>
	
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public sealed class AssetGeneralization : IClass
	{
		/// <summary>Constant value for <see cref="AssetGeneralization.ReferenceId" /></summary>
		public const string REFERENCE_ID = "_19_0_3_45f01b9_1581734255313_425984_984";
		/// <summary>Constant value for <see cref="AssetGeneralization.HelpUrl" /></summary>
		public const string HELP_URL = "https://model.mtconnect.org/#Structure___19_0_3_45f01b9_1581734255313_425984_984";
		/// <summary>Constant value for <see cref="AssetGeneralization.Summary" /></summary>
		public const string SUMMARY = @"&#10;&#10;&#10;{{term(asset)}} that is used by the manufacturing process to perform tasks.

> Note 1 to entry: An {{term(Asset)}} relies upon an {{term(Device)}} to provide {{termplural(observation)}} and information about itself and the {{term(Device)}} revises the information to reflect changes to the {{term(Asset)}} during their interaction. Examples of {{termplural(Asset)}} are cutting tools, Part Information, Manufacturing Processes, Fixtures, and Files.

> Note 2 to entry: A singular {{property(Asset::assetId)}} uniquely identifies an {{term(Asset)}} throughout its lifecycle and is used to track and relate the {{term(Asset)}} to other {{termplural(Device)}} and entities.

> Note 3 to entry: {{termplural(Asset)}} are temporally associated with a device and can be removed from the device without damage or alteration to its primary functions.

&#10;
";
		/// <summary>Constant value for <see cref="AssetGeneralization.Name" /></summary>
		public const string NAME = "Asset";
		/// <summary>Constant value for <see cref="AssetGeneralization.AccessModifier" /></summary>
		public const string ACCESS_MODIFIER = "public";
		/// <summary>Constant value for <see cref="AssetGeneralization.Modifier" /></summary>
		public const string MODIFIER = "";
		/// <summary>Constant value for <see cref="AssetGeneralization.NormativeVersion" /></summary>
		public const string NORMATIVE_VERSION = "";
		/// <summary>Constant value for <see cref="AssetGeneralization.DeprecatedVersion" /></summary>
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
		/// Original Type: _19_0_3_45f01b9_1580561892811_529841_16867
		/// </remarks>
		public Type Generalization => typeof(Mtconnect.Glossary.IndustrialTerms.AssetClass);

		/// <inheritdoc />
		public new AssetGeneralizationProperties Properties { get; } = new AssetGeneralizationProperties();
        IPropertyList IClass.Properties => Properties;
		/// <summary>
		/// Property list for <see cref="AssetGeneralization" />.
		/// <br/><b>Note</b>, some properties (<see cref="IProperty" />) are inherited from <see cref="Mtconnect.Glossary.IndustrialTerms.AssetClass.AssetClassProperties" />.
		/// </summary>
		public class AssetGeneralizationProperties : Mtconnect.Glossary.IndustrialTerms.AssetClass.AssetClassProperties
		{
			/// <inheritdoc />
			public override IProperty[] Properties => new IProperty[] {
				BelongsTo,
			}.Concat(base.Properties).ToArray();
			/// <summary>
			/// <inheritdoc cref="BelongsToProperty" path="/summary" /><br/>
			/// <remarks>Original Name: BelongsTo</remarks>
			/// </summary>
			public new BelongsToProperty BelongsTo { get; } = new BelongsToProperty();
			
			/// <summary>﻿
			/// </summary>
			public new sealed class BelongsToProperty : IProperty
			{
				/// <summary>Constant value for <see cref="BelongsToProperty.Name" /></summary>
				public const string NAME = "belongs to";
				/// <summary>Constant value for <see cref="BelongsToProperty.Summary" /></summary>
				public const string SUMMARY = @"";
				/// <summary>Constant value for <see cref="BelongsToProperty.AccessModifier" /></summary>
				public const string ACCESS_MODIFIER = "private";
				/// <summary>Constant value for <see cref="BelongsToProperty.Modifier" /></summary>
				public const string MODIFIER = "";
				/// <summary>Constant value for <see cref="BelongsToProperty.NormativeVersion" /></summary>
				public const string NORMATIVE_VERSION = "";
				/// <summary>Constant value for <see cref="BelongsToProperty.DeprecatedVersion" /></summary>
				public const string DEPRECATED_VERSION = "";
				/// <summary>Constant value for <see cref="BelongsToProperty.Aggregation" /></summary>
				public const string AGGREGATION = "";
				/// <summary>Constant value for <see cref="BelongsToProperty.Extension" /></summary>
				public const string EXTENSION = "MagicDraw UML 2024x";
				/// <summary>Constant value for <see cref="BelongsToProperty.Association" /></summary>
				public const string ASSOCIATION = "";
				/// <summary>Constant value for <see cref="BelongsToProperty.DefaultValue" /></summary>
				public const string DEFAULT_VALUE = "";

				/// <summary>
				/// <inheritdoc />
				/// <remarks> Type: DeviceClass </remarks>
				/// </summary>
				public System.Type Type => typeof(Mtconnect.Glossary.MTConnectTerms.DeviceClass);
				
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