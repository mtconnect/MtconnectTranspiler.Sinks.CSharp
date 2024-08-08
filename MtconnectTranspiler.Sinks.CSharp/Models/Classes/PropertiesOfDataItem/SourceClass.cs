using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;

namespace Mtconnect.DeviceInformationModel.DataItems.PropertiesOfDataItem
{
	/// <summary>
	/// identifies the <see cref="Component">Component</see>, <see cref="DataItem">DataItem</see>, or <see cref="Composition">Composition</see> from which a measured value originates.
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.3.0.0")]
	public sealed class SourceClass : IClass
	{
		/// <inheritdoc />
		public string ReferenceId => "EAID_A2837EAA_7D27_45c0_B365_BC308844F978";
		
		/// <inheritdoc />
		public string Summary => @"/// identifies the <see cref=""Component"">Component</see>, <see cref=""DataItem"">DataItem</see>, or <see cref=""Composition"">Composition</see> from which a measured value originates.";

		/// <inheritdoc />
		public string Name => "SourceClass";
		
		/// <inheritdoc />
		public string AccessModifier => "public";
				
		/// <inheritdoc />
		public string Modifier => "";
				
		/// <inheritdoc />
		public string NormativeVersion => "1.0";
				
		/// <inheritdoc />
		public string DeprecatedVersion => "";
		
		/// <inheritdoc />
		public string Generalization => "";

		/// <inheritdoc />
		public SourceClassProperties Properties { get; } = new SourceClassProperties();
        IPropertyList IClass.Properties => Properties;
		public sealed class SourceClassProperties : IPropertyList
		{
			/// <inheritdoc />
			public IProperty[] Properties => new IProperty[] {
				ComponentId,
				CompositionId,
				DataItemId,
				Value,
			};
			/// <summary>
			/// <inheritdoc cref="ComponentIdProperty" path="/summary" /><br/>
			/// <remarks>Original Name: ComponentId</remarks>
			/// </summary>
			public ComponentIdProperty ComponentId { get; } = new ComponentIdProperty();
			/// <summary>
			/// identifier of the <see cref="Component">Component</see> that represents the physical part of a piece of equipment where the data represented by the <see cref="DataItem">DataItem</see> originated.
			/// </summary>
			public sealed class ComponentIdProperty : IProperty
			{
				/// <summary>
				/// <inheritdoc />
				/// <remarks>
				/// <list type="bullet">
				/// <item>Original Type: _19_0_3_91b028d_1579272245466_691733_672</item>
				/// <item>Type: String</item>
				/// <item>Namespace: </item>
				/// </list>
				/// </remarks>
				/// </summary>
				public System.Type Type => typeof(String);
				
				/// <inheritdoc />
				public string Name => "ComponentId";
				
				/// <inheritdoc />
				public string Summary => @"/// identifies the <see cref=""Component"">Component</see>, <see cref=""DataItem"">DataItem</see>, or <see cref=""Composition"">Composition</see> from which a measured value originates.";

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
				public string DefaultValue => "";
			}
			/// <summary>
			/// <inheritdoc cref="CompositionIdProperty" path="/summary" /><br/>
			/// <remarks>Original Name: CompositionId</remarks>
			/// </summary>
			public CompositionIdProperty CompositionId { get; } = new CompositionIdProperty();
			/// <summary>
			/// identifier of the <see cref="Composition">Composition</see> that represents the physical part of a piece of equipment where the data represented by the <see cref="DataItem">DataItem</see> originated.
			/// </summary>
			public sealed class CompositionIdProperty : IProperty
			{
				/// <summary>
				/// <inheritdoc />
				/// <remarks>
				/// <list type="bullet">
				/// <item>Original Type: _19_0_3_91b028d_1579272245466_691733_672</item>
				/// <item>Type: String</item>
				/// <item>Namespace: </item>
				/// </list>
				/// </remarks>
				/// </summary>
				public System.Type Type => typeof(String);
				
				/// <inheritdoc />
				public string Name => "CompositionId";
				
				/// <inheritdoc />
				public string Summary => @"/// identifies the <see cref=""Component"">Component</see>, <see cref=""DataItem"">DataItem</see>, or <see cref=""Composition"">Composition</see> from which a measured value originates.";

				/// <inheritdoc />
				public string AccessModifier => "public";
				
				/// <inheritdoc />
				public string Modifier => "";
				
				/// <inheritdoc />
				public string NormativeVersion => "1.4";
				
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
			/// <inheritdoc cref="DataItemIdProperty" path="/summary" /><br/>
			/// <remarks>Original Name: DataItemId</remarks>
			/// </summary>
			public DataItemIdProperty DataItemId { get; } = new DataItemIdProperty();
			/// <summary>
			/// identifier of the <see cref="DataItem">DataItem</see> that represents the originally measured value of the data referenced by this <see cref="DataItem">DataItem</see>.
			/// </summary>
			public sealed class DataItemIdProperty : IProperty
			{
				/// <summary>
				/// <inheritdoc />
				/// <remarks>
				/// <list type="bullet">
				/// <item>Original Type: _19_0_3_91b028d_1579272245466_691733_672</item>
				/// <item>Type: String</item>
				/// <item>Namespace: </item>
				/// </list>
				/// </remarks>
				/// </summary>
				public System.Type Type => typeof(String);
				
				/// <inheritdoc />
				public string Name => "DataItemId";
				
				/// <inheritdoc />
				public string Summary => @"/// identifies the <see cref=""Component"">Component</see>, <see cref=""DataItem"">DataItem</see>, or <see cref=""Composition"">Composition</see> from which a measured value originates.";

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
				public string DefaultValue => "";
			}
			/// <summary>
			/// <inheritdoc cref="ValueProperty" path="/summary" /><br/>
			/// <remarks>Original Name: Value</remarks>
			/// </summary>
			public ValueProperty Value { get; } = new ValueProperty();
			/// <summary>
			/// identifier of the source entity.
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
				public string Name => "Value";
				
				/// <inheritdoc />
				public string Summary => @"/// identifies the <see cref=""Component"">Component</see>, <see cref=""DataItem"">DataItem</see>, or <see cref=""Composition"">Composition</see> from which a measured value originates.";

				/// <inheritdoc />
				public string AccessModifier => "public";
				
				/// <inheritdoc />
				public string Modifier => "";
				
				/// <inheritdoc />
				public string NormativeVersion => "1.0";
				
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