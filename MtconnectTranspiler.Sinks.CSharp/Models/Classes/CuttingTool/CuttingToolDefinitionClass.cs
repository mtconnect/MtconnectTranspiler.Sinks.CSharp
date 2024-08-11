using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;

namespace Mtconnect.AssetInformationModel.CuttingTool
{
	/// <summary>
	/// detailed structure of the cutting tool which is static during its lifecycle. <seealso href="https://www.google.com/search?q=ISO 13399&btnI=I">ISO 13399</seealso>.
	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Structure__EAID_37B8CFD0_D728_4841_9A07_B6CF819EC895">model.mtconnect.org</seealso> for more information.
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.3.0.0")]
	public sealed class CuttingToolDefinitionClass : IClass
	{
		/// <inheritdoc />
		public string ReferenceId => "EAID_37B8CFD0_D728_4841_9A07_B6CF819EC895";
		
		/// <inheritdoc />
		public string Summary => @"/// detailed structure of the cutting tool which is static during its lifecycle. <seealso href=""https://www.google.com/search?q=ISO 13399&btnI=I"">ISO 13399</seealso>.";

		/// <inheritdoc />
		public string Name => "CuttingToolDefinition";
		
		/// <inheritdoc />
		public string AccessModifier => "public";
				
		/// <inheritdoc />
		public string Modifier => "";
				
		/// <inheritdoc />
		public string NormativeVersion => "1.2";
				
		/// <inheritdoc />
		public string DeprecatedVersion => "";
		
		/// <inheritdoc />
		public Type Generalization => null;

		/// <inheritdoc />
		public CuttingToolDefinitionClassProperties Properties { get; } = new CuttingToolDefinitionClassProperties();
        IPropertyList IClass.Properties => Properties;
		public class CuttingToolDefinitionClassProperties : IPropertyList
		{
			/// <inheritdoc />
			public IProperty[] Properties => new IProperty[] {
				Format,
				Value,
			};
			/// <summary>
			/// <inheritdoc cref="FormatProperty" path="/summary" /><br/>
			/// <remarks>Original Name: Format</remarks>
			/// </summary>
			public FormatProperty Format { get; } = new FormatProperty();
			/// <summary>
			/// identifies the expected representation of the enclosed data.
			/// </summary>
			public sealed class FormatProperty : IProperty
			{
				/// <summary>
				/// <inheritdoc />
				/// <remarks>
				/// <list type="bullet">
				/// <item>Original Type: _19_0_3_91b028d_1579537199908_332626_9197</item>
				/// <item>Type: FormatTypeEnum</item>
				/// <item>Namespace: Mtconnect.DataTypes</item>
				/// </list>
				/// </remarks>
				/// </summary>
				public System.Type Type => typeof(Mtconnect.DataTypes.FormatTypeEnum);
				
				/// <inheritdoc />
				public string Name => "format";
				
				/// <inheritdoc />
				public string Summary => @"/// detailed structure of the cutting tool which is static during its lifecycle. <seealso href=""https://www.google.com/search?q=ISO 13399&btnI=I"">ISO 13399</seealso>.";

				/// <inheritdoc />
				public string AccessModifier => "public";
				
				/// <inheritdoc />
				public string Modifier => "";
				
				/// <inheritdoc />
				public string NormativeVersion => "1.2";
				
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
				public string DefaultValue => "XML";
			}
			/// <summary>
			/// <inheritdoc cref="ValueProperty" path="/summary" /><br/>
			/// <remarks>Original Name: Value</remarks>
			/// </summary>
			public ValueProperty Value { get; } = new ValueProperty();
			/// <summary>
			/// text of the <see cref="CuttingToolDefinition">CuttingToolDefinition</see> in format defined by <see cref="CuttingToolDefinition::format" />.
			/// </summary>
			public sealed class ValueProperty : IProperty
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
				public string Name => "value";
				
				/// <inheritdoc />
				public string Summary => @"/// detailed structure of the cutting tool which is static during its lifecycle. <seealso href=""https://www.google.com/search?q=ISO 13399&btnI=I"">ISO 13399</seealso>.";

				/// <inheritdoc />
				public string AccessModifier => "public";
				
				/// <inheritdoc />
				public string Modifier => "";
				
				/// <inheritdoc />
				public string NormativeVersion => "1.2";
				
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