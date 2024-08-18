#pragma warning disable CS0109 // Member does not hide an inherited member; new keyword is not required
#pragma warning disable CS1574 // XML comment has cref attribute that could not be resolved
#pragma warning disable CS1584 // XML comment has syntactically incorrect cref attribute
using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;
using System.Linq;

namespace Mtconnect.Glossary.MTConnectTerms
{
	/// <summary>﻿<i>Component</i> not belonging to any <i>Component</i> that may have <i>asset</i>s<br /><br /><br />
	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Structure___19_0_3_68e0225_1623664375171_197977_2034">model.mtconnect.org</seealso> for more information.
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public sealed class DeviceClass : IClass
	{
		/// <inheritdoc />
		public string ReferenceId => "_19_0_3_68e0225_1623664375171_197977_2034";
		
		/// <inheritdoc />
		public string Summary => @"&#10;&#10;&#10;{{term(Component)}} not belonging to any {{term(Component)}} that may have {{termplural(asset)}}&#10;
";

		/// <inheritdoc />
		public string Name => "Device";
		
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
		/// Original Type: _19_0_3_45f01b9_1581734537697_742151_1119
		/// </remarks>
		public Type Generalization => typeof(Mtconnect.Glossary.MTConnectTerms.ComponentClass);

		/// <inheritdoc />
		public new DeviceClassProperties Properties { get; } = new DeviceClassProperties();
        IPropertyList IClass.Properties => Properties;
		/// <summary>
		/// Property list for <see cref="DeviceClass" />.
		/// <br/><b>Note</b>, some properties (<see cref="IProperty" />) are inherited from <see cref="Mtconnect.Glossary.MTConnectTerms.ComponentClass.ComponentClassProperties" />.
		/// </summary>
		public class DeviceClassProperties : Mtconnect.Glossary.MTConnectTerms.ComponentClass.ComponentClassProperties
		{
			/// <inheritdoc />
			public new IProperty[] Properties => new IProperty[] {
				HasAsset,
			}.Concat(base.Properties).ToArray();
			/// <summary>
			/// <inheritdoc cref="HasAssetProperty" path="/summary" /><br/>
			/// <remarks>Original Name: HasAsset</remarks>
			/// </summary>
			public new HasAssetProperty HasAsset { get; } = new HasAssetProperty();
			
			/// <summary>﻿
			/// </summary>
			public new sealed class HasAssetProperty : IProperty
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
				public string Name => "has asset";
				
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
				public string Extension => "";
				
				/// <inheritdoc />
				public string Association => "";

				// Note: DefaultValue.Name
				/// <inheritdoc />
				public string DefaultValue => "";
			}
		};

	}
}