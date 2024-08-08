using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;

namespace Mtconnect.Fundamentals.MTConnectProtocol.MTConnectDevicesResponseDocument
{
	/// <summary>
	/// count of each asset type currently in the <i>agent</i>.
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.3.0.0")]
	public sealed class AssetCountClass : IClass
	{
		/// <inheritdoc />
		public string ReferenceId => "_19_0_3_68e0225_1643803275261_762583_709";
		
		/// <inheritdoc />
		public string Summary => @"/// count of each asset type currently in the <i>agent</i>.";

		/// <inheritdoc />
		public string Name => "AssetCountClass";
		
		/// <inheritdoc />
		public string AccessModifier => "public";
				
		/// <inheritdoc />
		public string Modifier => "";
				
		/// <inheritdoc />
		public string NormativeVersion => "1.2";
				
		/// <inheritdoc />
		public string DeprecatedVersion => "1.4";
		
		/// <inheritdoc />
		public string Generalization => "";

		/// <inheritdoc />
		public AssetCountClassProperties Properties { get; } = new AssetCountClassProperties();
        IPropertyList IClass.Properties => Properties;
		public sealed class AssetCountClassProperties : IPropertyList
		{
			/// <inheritdoc />
			public IProperty[] Properties => new IProperty[] {
				AssetType,
			};
			/// <summary>
			/// <inheritdoc cref="AssetTypeProperty" path="/summary" /><br/>
			/// <remarks>Original Name: AssetType</remarks>
			/// </summary>
			public AssetTypeProperty AssetType { get; } = new AssetTypeProperty();
			/// <summary>
			/// type of <i>Asset</i>.
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
				public string Summary => @"/// count of each asset type currently in the <i>agent</i>.";

				/// <inheritdoc />
				public string AccessModifier => "public";
				
				/// <inheritdoc />
				public string Modifier => "";
				
				/// <inheritdoc />
				public string NormativeVersion => "1.2";
				
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