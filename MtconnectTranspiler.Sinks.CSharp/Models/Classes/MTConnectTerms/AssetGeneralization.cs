using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;
// using Mtconnect.Glossary.MTConnectTerms;

namespace Mtconnect.Glossary.MTConnectTerms
{
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "1.0.15.3")]
	public sealed class AssetGeneralization : IClass
	{
		/// <inheritdoc />
		public string ReferenceId => "_19_0_3_45f01b9_1581734255313_425984_984";
		
		/// <inheritdoc />
		public string Name => "AssetGeneralization";
		
		/// <inheritdoc />
		public string AccessModifier => "public";
				
		/// <inheritdoc />
		public string Modifier => "";
				
		/// <inheritdoc />
		public string NormativeVersion => "";
				
		/// <inheritdoc />
		public string DeprecatedVersion => "";
		
		/// <inheritdoc />
		public string Generalization => "_19_0_3_45f01b9_1580561892811_529841_16867";

		/// <inheritdoc />
		public AssetGeneralizationProperties Properties { get; } = new AssetGeneralizationProperties();
        IPropertyList IClass.Properties => Properties;
		public sealed class AssetGeneralizationProperties : IPropertyList
		{
			/// <inheritdoc />
			public IProperty[] Properties => new IProperty[] {
				BelongsTo,
			};
			/// <remarks>Original Name: BelongsTo</remarks>
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
				public string Name => "BelongsTo";
				
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

				// TODO: Add Summary
			}
		};

	}
}