#pragma warning disable CS0109 // Member does not hide an inherited member; new keyword is not required
#pragma warning disable CS1574 // XML comment has cref attribute that could not be resolved
#pragma warning disable CS1584 // XML comment has syntactically incorrect cref attribute
using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;

namespace Mtconnect.AssetInformationModel.CuttingTool
{
	/// <summary>﻿reference information about the <see cref="Asset.assetId">assetId in Asset</see> and/or the URL of the data source of <see cref="CuttingToolArchetype">CuttingToolArchetype</see>.<br /><br /><br />
	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Structure__EAID_D4CAAB4A_DE00_489d_ACCA_F00FC7296F0C">model.mtconnect.org</seealso> for more information.
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public sealed class CuttingToolArchetypeReferenceClass : IClass
	{
		/// <inheritdoc />
		public string ReferenceId => "EAID_D4CAAB4A_DE00_489d_ACCA_F00FC7296F0C";
		
		/// <inheritdoc />
		public string Summary => @"&#10;&#10;&#10;reference information about the {{property(Asset::assetId)}} and/or the URL of the data source of {{block(CuttingToolArchetype)}}.&#10;
";

		/// <inheritdoc />
		public string Name => "CuttingToolArchetypeReference";
		
		/// <inheritdoc />
		public string AccessModifier => "public";
				
		/// <inheritdoc />
		public string Modifier => "";
				
		/// <inheritdoc />
		public string NormativeVersion => "1.3";
				
		/// <inheritdoc />
		public string DeprecatedVersion => "";
		
		/// <inheritdoc />
		public Type Generalization => null;

		/// <inheritdoc />
		public new CuttingToolArchetypeReferenceClassProperties Properties { get; } = new CuttingToolArchetypeReferenceClassProperties();
        IPropertyList IClass.Properties => Properties;
		/// <summary>
		/// Property list for <see cref="CuttingToolArchetypeReferenceClass" />.
		/// </summary>
		public class CuttingToolArchetypeReferenceClassProperties : IPropertyList
		{
			/// <inheritdoc />
			public IProperty[] Properties => new IProperty[] {
				Source,
				Value,
			};
			/// <summary>
			/// <inheritdoc cref="SourceProperty" path="/summary" /><br/>
			/// <remarks>Original Name: Source</remarks>
			/// </summary>
			public SourceProperty Source { get; } = new SourceProperty();
			
			/// <summary>﻿<i>URL</i> of the <see cref="CuttingToolArchetype">CuttingToolArchetype</see> <i>information model</i>.<br /><br /><br /><br />
			/// </summary>
			public sealed class SourceProperty : IProperty
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
				public string Name => "source";
				
				/// <inheritdoc />
				public string Summary => @"&#10;&#10;&#10;{{term(URL)}} of the {{block(CuttingToolArchetype)}} {{term(information model)}}.&#10;
";

				/// <inheritdoc />
				public string AccessModifier => "public";
				
				/// <inheritdoc />
				public string Modifier => "";
				
				/// <inheritdoc />
				public string NormativeVersion => "1.3";
				
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
			/// <summary>
			/// <inheritdoc cref="ValueProperty" path="/summary" /><br/>
			/// <remarks>Original Name: Value</remarks>
			/// </summary>
			public ValueProperty Value { get; } = new ValueProperty();
			
			/// <summary>﻿<c>assetId</c> of the related <see cref="CuttingToolArchetype">CuttingToolArchetype</see>.<br /><br /><br />
			/// </summary>
			public sealed class ValueProperty : IProperty
			{
				/// <summary>
				/// <inheritdoc />
				/// <remarks>
				/// <list type="bullet">
				/// <item>Original Type: _19_0_3_45f01b9_1579116116375_425412_164774</item>
				/// <item>Type: String</item>
				/// <item>Namespace: </item>
				/// </list>
				/// </remarks>
				/// </summary>
				public System.Type Type => typeof(String);
				
				/// <inheritdoc />
				public string Name => "value";
				
				/// <inheritdoc />
				public string Summary => @"&#10;&#10;&#10;`assetId` of the related {{block(CuttingToolArchetype)}}.&#10;
";

				/// <inheritdoc />
				public string AccessModifier => "public";
				
				/// <inheritdoc />
				public string Modifier => "";
				
				/// <inheritdoc />
				public string NormativeVersion => "1.3";
				
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