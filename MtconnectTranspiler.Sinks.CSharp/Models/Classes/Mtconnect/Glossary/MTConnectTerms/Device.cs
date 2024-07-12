
using System;
using System.CodeDom.Compiler;

using Mtconnect.AssetInformationModel;

namespace Mtconnect.Glossary.MTConnectTerms
{
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "1.0.15.3")]
	public sealed class DeviceClass
	{
		/// <inheritdoc cref="Class.ReferenceId" />
		public string ReferenceId => "_19_0_3_68e0225_1623664375171_197977_2034";
		
		/// <inheritdoc cref="Class.Name" />
		public string Name => "Device";
		
		/// <inheritdoc cref="Class.AccessModifier" />
		public string AccessModifier => "public";
				
		/// <inheritdoc cref="Class.Modifier" />
		public string Modifier => "";
				
		/// <inheritdoc cref="Class.NormativeVersion" />
		public string NormativeVersion => "";
				
		/// <inheritdoc cref="Class.DeprecatedVersion" />
		public string DeprecatedVersion => "";

		public string Generalization => "";

		public DeviceProperties Properties { get; } = new DeviceProperties();
		public sealed class DeviceProperties
		{
		
		
			/// <remarks>Original Name: HasAsset</remarks>
			public HasAssetProperty HasAsset { get; } = new HasAssetProperty();
			public sealed class HasAssetProperty
			{
				/// <inheritdoc cref="Property.Type" />
				/// Original Type: _19_0_3_45f01b9_1581734255313_425984_984
				public Type Type => typeof(AssetClass);
				
				/// <inheritdoc cref="Property.Name" />
				public string Name => "HasAsset";
				
				/// <inheritdoc cref="Property.AccessModifier" />
				public string AccessModifier => "private";
				
				/// <inheritdoc cref="Property.Modifier" />
				public string Modifier => "";
				
				/// <inheritdoc cref="Property.NormativeVersion" />
				public string NormativeVersion => "";
				
				/// <inheritdoc cref="Property.DeprecatedVersion" />
				public string DeprecatedVersion => "";
				
				public string Aggregation => "";

				// Note: Extension.Extender
				public string Extension => "";

				public string Association => "";

				// Note: DefaultValue.Name
				public string DefaultValue => "";

				// TODO: Add Summary
			}
		};

	}
}