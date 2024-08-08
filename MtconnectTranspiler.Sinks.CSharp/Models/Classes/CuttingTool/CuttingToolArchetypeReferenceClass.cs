using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;

namespace Mtconnect.AssetInformationModel.CuttingTool
{
	/// <summary>
	/// reference information about the <see cref="Asset::assetId" /> and/or the URL of the data source of <see cref="CuttingToolArchetype">CuttingToolArchetype</see>.
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.3.0.0")]
	public sealed class CuttingToolArchetypeReferenceClass : IClass
	{
		/// <inheritdoc />
		public string ReferenceId => "EAID_D4CAAB4A_DE00_489d_ACCA_F00FC7296F0C";
		
		/// <inheritdoc />
		public string Summary => @"/// reference information about the <see cref=""Asset::assetId"" /> and/or the URL of the data source of <see cref=""CuttingToolArchetype"">CuttingToolArchetype</see>.";

		/// <inheritdoc />
		public string Name => "CuttingToolArchetypeReferenceClass";
		
		/// <inheritdoc />
		public string AccessModifier => "public";
				
		/// <inheritdoc />
		public string Modifier => "";
				
		/// <inheritdoc />
		public string NormativeVersion => "1.3";
				
		/// <inheritdoc />
		public string DeprecatedVersion => "";
		
		/// <inheritdoc />
		public string Generalization => "";

		/// <inheritdoc />
		public CuttingToolArchetypeReferenceClassProperties Properties { get; } = new CuttingToolArchetypeReferenceClassProperties();
        IPropertyList IClass.Properties => Properties;
		public sealed class CuttingToolArchetypeReferenceClassProperties : IPropertyList
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
			/// <summary>
			/// <i>URL</i> of the <see cref="CuttingToolArchetype">CuttingToolArchetype</see> <i>information model</i>. 
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
				public string Name => "Source";
				
				/// <inheritdoc />
				public string Summary => @"/// reference information about the <see cref=""Asset::assetId"" /> and/or the URL of the data source of <see cref=""CuttingToolArchetype"">CuttingToolArchetype</see>.";

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
			/// <summary>
			/// <c>assetId</c> of the related <see cref="CuttingToolArchetype">CuttingToolArchetype</see>.
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
				public string Name => "Value";
				
				/// <inheritdoc />
				public string Summary => @"/// reference information about the <see cref=""Asset::assetId"" /> and/or the URL of the data source of <see cref=""CuttingToolArchetype"">CuttingToolArchetype</see>.";

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