using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;
// using Mtconnect.DataTypes;

namespace Mtconnect.ObservationInformationModel.ObservationTypes.EventTypes
{
	/// <summary>
	/// <see cref="EventEnum::ASSET_REMOVED">EventEnum::ASSET_REMOVED</see>
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.3.0.0")]
	public sealed class AssetRemovedClass : IClass
	{
		/// <inheritdoc />
		public string ReferenceId => "_19_0_3_45f01b9_1580378218180_352606_1551";
		
		/// <inheritdoc />
		public string Summary => @"/// <see cref=""EventEnum::ASSET_REMOVED"">EventEnum::ASSET_REMOVED</see>";

		/// <inheritdoc />
		public string Name => "AssetRemovedClass";
		
		/// <inheritdoc />
		public string AccessModifier => "public";
				
		/// <inheritdoc />
		public string Modifier => "";
				
		/// <inheritdoc />
		public string NormativeVersion => "1.3";
				
		/// <inheritdoc />
		public string DeprecatedVersion => "";
		
		/// <inheritdoc />
		public string Generalization => "_19_0_3_45f01b9_1579566531115_47447_25730";

		/// <inheritdoc />
		public AssetRemovedClassProperties Properties { get; } = new AssetRemovedClassProperties();
        IPropertyList IClass.Properties => Properties;
		public sealed class AssetRemovedClassProperties : IPropertyList
		{
			/// <inheritdoc />
			public IProperty[] Properties => new IProperty[] {
				AssetType,
				Type,
				Hash,
			};
			/// <summary>
			/// <inheritdoc cref="AssetTypeProperty" path="/summary" /><br/>
			/// <remarks>Original Name: AssetType</remarks>
			/// </summary>
			public AssetTypeProperty AssetType { get; } = new AssetTypeProperty();
			/// <summary>
			/// type of <see cref="Asset">Asset</see> removed. See <see cref="Asset Information Model">Asset Information Model</see> for details on the <see cref="Asset">Asset</see> model.
			/// </summary>
			public sealed class AssetTypeProperty : IProperty
			{
				/// <summary>
				/// <inheritdoc />
				/// <remarks>
				/// <list type="bullet">
				/// <item>Original Type: _19_0_3_91b028d_1579272360416_763325_681</item>
				/// <item>Type: String</item>
				/// <item>Namespace: </item>
				/// </list>
				/// </remarks>
				/// </summary>
				public System.Type Type => typeof(String);
				
				/// <inheritdoc />
				public string Name => "AssetType";
				
				/// <inheritdoc />
				public string Summary => @"/// <see cref=""EventEnum::ASSET_REMOVED"">EventEnum::ASSET_REMOVED</see>";

				/// <inheritdoc />
				public string AccessModifier => "public";
				
				/// <inheritdoc />
				public string Modifier => "";
				
				/// <inheritdoc />
				public string NormativeVersion => "";
				
				/// <inheritdoc />
				public string DeprecatedVersion => "";
				
				/// <inheritdoc />
				public string Aggregation => "composite";

				// Note: Extension.Extender
				/// <inheritdoc />
				public string Extension => "MagicDraw UML 19.0";
				
				/// <inheritdoc />
				public string Association => "";

				// Note: DefaultValue.Name
				/// <inheritdoc />
				public string DefaultValue => "";
			}
			/// <summary>
			/// <inheritdoc cref="TypeProperty" path="/summary" /><br/>
			/// <remarks>Original Name: Type</remarks>
			/// </summary>
			public TypeProperty Type { get; } = new TypeProperty();
			public sealed class TypeProperty : IProperty
			{
				/// <summary>
				/// <inheritdoc />
				/// <remarks>
				/// <list type="bullet">
				/// <item>Original Type: _19_0_3_45f01b9_1580398379726_606068_12802</item>
				/// <item>Type: EventEnum</item>
				/// <item>Namespace: Mtconnect.DataTypes</item>
				/// </list>
				/// </remarks>
				/// </summary>
				public System.Type Type => typeof(Mtconnect.DataTypes.EventEnum);
				
				/// <inheritdoc />
				public string Name => "Type";
				
				/// <inheritdoc />
				public string Summary => @"/// <see cref=""EventEnum::ASSET_REMOVED"">EventEnum::ASSET_REMOVED</see>";

				/// <inheritdoc />
				public string AccessModifier => "public";
				
				/// <inheritdoc />
				public string Modifier => "static";
				
				/// <inheritdoc />
				public string NormativeVersion => "";
				
				/// <inheritdoc />
				public string DeprecatedVersion => "";
				
				/// <inheritdoc />
				public string Aggregation => "composite";

				// Note: Extension.Extender
				/// <inheritdoc />
				public string Extension => "";
				
				/// <inheritdoc />
				public string Association => "";

				// Note: DefaultValue.Name
				/// <inheritdoc />
				public string DefaultValue => "";
			}
			/// <summary>
			/// <inheritdoc cref="HashProperty" path="/summary" /><br/>
			/// <remarks>Original Name: Hash</remarks>
			/// </summary>
			public HashProperty Hash { get; } = new HashProperty();
			/// <summary>
			/// condensed message digest from a secure one-way hash function. <seealso href="https://www.google.com/search?q=FIPS PUB 180-4&btnI=I">FIPS PUB 180-4</seealso>
			/// </summary>
			public sealed class HashProperty : IProperty
			{
				/// <summary>
				/// <inheritdoc />
				/// <remarks>
				/// <list type="bullet">
				/// <item>Original Type: _19_0_3_91b028d_1579272360416_763325_681</item>
				/// <item>Type: String</item>
				/// <item>Namespace: </item>
				/// </list>
				/// </remarks>
				/// </summary>
				public System.Type Type => typeof(String);
				
				/// <inheritdoc />
				public string Name => "Hash";
				
				/// <inheritdoc />
				public string Summary => @"/// <see cref=""EventEnum::ASSET_REMOVED"">EventEnum::ASSET_REMOVED</see>";

				/// <inheritdoc />
				public string AccessModifier => "public";
				
				/// <inheritdoc />
				public string Modifier => "";
				
				/// <inheritdoc />
				public string NormativeVersion => "2.2";
				
				/// <inheritdoc />
				public string DeprecatedVersion => "";
				
				/// <inheritdoc />
				public string Aggregation => "composite";

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