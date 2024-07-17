using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;
// using Mtconnect.Glossary.MTConnectTerms;

namespace Mtconnect.Glossary.MTConnectTerms
{
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "1.0.15.3")]
	public sealed class DeviceClass : IClass
	{
		/// <inheritdoc />
		public string ReferenceId => "_19_0_3_68e0225_1623664375171_197977_2034";
		
		/// <inheritdoc />
		public string Name => "DeviceClass";
		
		/// <inheritdoc />
		public string AccessModifier => "public";
				
		/// <inheritdoc />
		public string Modifier => "";
				
		/// <inheritdoc />
		public string NormativeVersion => "";
				
		/// <inheritdoc />
		public string DeprecatedVersion => "";
		
		/// <inheritdoc />
		public string Generalization => "_19_0_3_45f01b9_1581734537697_742151_1119";

		/// <inheritdoc />
		public DeviceClassProperties Properties { get; } = new DeviceClassProperties();
        IPropertyList IClass.Properties => Properties;
		public sealed class DeviceClassProperties : IPropertyList
		{
			/// <inheritdoc />
			public IProperty[] Properties => new IProperty[] {
				HasAsset,
			};
			/// <remarks>Original Name: HasAsset</remarks>
			public HasAssetProperty HasAsset { get; } = new HasAssetProperty();
			public sealed class HasAssetProperty : IProperty
			{
				/// <summary>
				/// <inheritdoc />
				/// <remarks>
				/// <list type="bullet">
				/// <item>Original Type: _19_0_3_45f01b9_1581734255313_425984_984</item>
				/// <item>Type: AssetGeneralization</item>
				/// <item>Namespace: Mtconnect.Glossary.MTConnectTerms</item>
				/// </list>
				/// </remarks>
				/// </summary>
				public System.Type Type => typeof(Mtconnect.Glossary.MTConnectTerms.AssetGeneralization);
				
				/// <inheritdoc />
				public string Name => "HasAsset";
				
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
				public string Extension => "";
				
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