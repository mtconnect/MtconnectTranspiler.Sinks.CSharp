using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;
// using Mtconnect.Glossary.MTConnectTerms;

namespace Mtconnect.Glossary.MTConnectTerms
{
	/// <summary>
	/// <i>asset</i> that is used by the manufacturing process to perform tasks.  > Note 1 to entry: An <i>Asset</i> relies upon an <i>Device</i> to provide <i>observation</i>s and information about itself and the <i>Device</i> revises the information to reflect changes to the <i>Asset</i> during their interaction. Examples of <i>Asset</i>s are cutting tools, Part Information, Manufacturing Processes, Fixtures, and Files.  > Note 2 to entry: A singular <see cref="Asset::assetId" /> uniquely identifies an <i>Asset</i> throughout its lifecycle and is used to track and relate the <i>Asset</i> to other <i>Device</i>s and entities.  > Note 3 to entry: <i>Asset</i>s are temporally associated with a device and can be removed from the device without damage or alteration to its primary functions.  
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.3.0.0")]
	public sealed class AssetGeneralization : IClass
	{
		/// <inheritdoc />
		public string ReferenceId => "_19_0_3_45f01b9_1581734255313_425984_984";
		
		/// <inheritdoc />
		public string Summary => @"/// <i>asset</i> that is used by the manufacturing process to perform tasks.  > Note 1 to entry: An <i>Asset</i> relies upon an <i>Device</i> to provide <i>observation</i>s and information about itself and the <i>Device</i> revises the information to reflect changes to the <i>Asset</i> during their interaction. Examples of <i>Asset</i>s are cutting tools, Part Information, Manufacturing Processes, Fixtures, and Files.  > Note 2 to entry: A singular <see cref=""Asset::assetId"" /> uniquely identifies an <i>Asset</i> throughout its lifecycle and is used to track and relate the <i>Asset</i> to other <i>Device</i>s and entities.  > Note 3 to entry: <i>Asset</i>s are temporally associated with a device and can be removed from the device without damage or alteration to its primary functions.  ";

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
				public string Name => "BelongsTo";
				
				/// <inheritdoc />
				public string Summary => @"/// <i>asset</i> that is used by the manufacturing process to perform tasks.  > Note 1 to entry: An <i>Asset</i> relies upon an <i>Device</i> to provide <i>observation</i>s and information about itself and the <i>Device</i> revises the information to reflect changes to the <i>Asset</i> during their interaction. Examples of <i>Asset</i>s are cutting tools, Part Information, Manufacturing Processes, Fixtures, and Files.  > Note 2 to entry: A singular <see cref=""Asset::assetId"" /> uniquely identifies an <i>Asset</i> throughout its lifecycle and is used to track and relate the <i>Asset</i> to other <i>Device</i>s and entities.  > Note 3 to entry: <i>Asset</i>s are temporally associated with a device and can be removed from the device without damage or alteration to its primary functions.  ";

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