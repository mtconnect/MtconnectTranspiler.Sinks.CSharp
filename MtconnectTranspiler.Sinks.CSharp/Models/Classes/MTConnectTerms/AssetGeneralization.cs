using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;
using System.Linq;

namespace Mtconnect.Glossary.MTConnectTerms
{
	/// <summary>
	﻿/// <i>asset</i> that is used by the manufacturing process to perform tasks.<br /><br />> Note 1 to entry: An <i>Asset</i> relies upon an <i>Device</i> to provide <i>observation</i>s and information about itself and the <i>Device</i> revises the information to reflect changes to the <i>Asset</i> during their interaction. Examples of <i>Asset</i>s are cutting tools, Part Information, Manufacturing Processes, Fixtures, and Files.<br /><br />> Note 2 to entry: A singular <see cref="Asset.assetId">assetId in Asset</see> uniquely identifies an <i>Asset</i> throughout its lifecycle and is used to track and relate the <i>Asset</i> to other <i>Device</i>s and entities.<br /><br />> Note 3 to entry: <i>Asset</i>s are temporally associated with a device and can be removed from the device without damage or alteration to its primary functions.<br /><br /><br/><br />

	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Structure___19_0_3_45f01b9_1581734255313_425984_984">model.mtconnect.org</seealso> for more information.
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public sealed class AssetGeneralization : IClass
	{
		/// <inheritdoc />
		public string ReferenceId => "_19_0_3_45f01b9_1581734255313_425984_984";
		
		/// <inheritdoc />
		public string Summary => @"&#10;&#10;&#10;{{term(asset)}} that is used by the manufacturing process to perform tasks.

> Note 1 to entry: An {{term(Asset)}} relies upon an {{term(Device)}} to provide {{termplural(observation)}} and information about itself and the {{term(Device)}} revises the information to reflect changes to the {{term(Asset)}} during their interaction. Examples of {{termplural(Asset)}} are cutting tools, Part Information, Manufacturing Processes, Fixtures, and Files.

> Note 2 to entry: A singular {{property(Asset::assetId)}} uniquely identifies an {{term(Asset)}} throughout its lifecycle and is used to track and relate the {{term(Asset)}} to other {{termplural(Device)}} and entities.

> Note 3 to entry: {{termplural(Asset)}} are temporally associated with a device and can be removed from the device without damage or alteration to its primary functions.

&#10;
";

		/// <inheritdoc />
		public string Name => "Asset";
		
		/// <inheritdoc />
		public string AccessModifier => "public";
				
		/// <inheritdoc />
		public string Modifier => "";
				
		/// <inheritdoc />
		public string NormativeVersion => "";
				
		/// <inheritdoc />
		public string DeprecatedVersion => "";
		
		/// <inheritdoc />
		/// <remarks>
		/// Original Type: _19_0_3_45f01b9_1580561892811_529841_16867
		/// </remarks>
		public Type Generalization => typeof(Mtconnect.Glossary.IndustrialTerms.AssetClass);

		/// <inheritdoc />
		public AssetGeneralizationProperties Properties { get; } = new AssetGeneralizationProperties();
        IPropertyList IClass.Properties => Properties;
		public class AssetGeneralizationProperties : Mtconnect.Glossary.IndustrialTerms.AssetClass.AssetClassProperties
		{
			/// <inheritdoc />
			public IProperty[] Properties => new IProperty[] {
				BelongsTo,
			}.Concat(base.Properties).ToArray();
			/// <summary>
			/// <inheritdoc cref="BelongsToProperty" path="/summary" /><br/>
			/// <remarks>Original Name: BelongsTo</remarks>
			/// </summary>
			public BelongsToProperty BelongsTo { get; } = new BelongsToProperty();
			public sealed class BelongsToProperty : IProperty
			{
				/// <summary>
				/// <inheritdoc />
				/// <remarks>
				/// <list type="bullet">
				/// <item>Original Type: _19_0_3_68e0225_1623664375171_197977_2034</item>
				/// <item>Type: DeviceClass</item>
				/// <item>Namespace: Mtconnect.Glossary.MTConnectTerms</item>
				/// </list>
				/// </remarks>
				/// </summary>
				public System.Type Type => typeof(Mtconnect.Glossary.MTConnectTerms.DeviceClass);
				
				/// <inheritdoc />
				public string Name => "belongs to";
				
				/// <inheritdoc />
				public string Summary => @"";

				/// <inheritdoc />
				public string AccessModifier => "private";
				
				/// <inheritdoc />
				public string Modifier => "";
				
				/// <inheritdoc />
				public string NormativeVersion => "";
				
				/// <inheritdoc />
				public string DeprecatedVersion => "";
				
				/// <inheritdoc />
				public string Aggregation => "";

				// Note: Extension.Extender
				/// <inheritdoc />
				public string Extension => "MagicDraw UML 19.0";
				
				/// <inheritdoc />
				public string Association => "";

				// Note: DefaultValue.Name
				/// <inheritdoc />
				public string DefaultValue => "";
			}
		};

	}
}