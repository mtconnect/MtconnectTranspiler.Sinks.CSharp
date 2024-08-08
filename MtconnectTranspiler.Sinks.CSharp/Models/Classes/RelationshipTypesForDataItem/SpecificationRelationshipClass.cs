using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;
// using Mtconnect.DataTypes;

namespace Mtconnect.DeviceInformationModel.DataItems.PropertiesOfDataItem.RelationshipTypesForDataItem
{
	/// <summary>
	/// <see cref="AbstractDataItemRelationship">AbstractDataItemRelationship</see> that provides a semantic reference to another <see cref="Specification">Specification</see> described by <see cref="SpecificationRelationship::type" /> and <see cref="SpecificationRelationship::idRef" />.
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.3.0.0")]
	public sealed class SpecificationRelationshipClass : IClass
	{
		/// <inheritdoc />
		public string ReferenceId => "_19_0_3_68e0225_1605645496116_206752_2923";
		
		/// <inheritdoc />
		public string Summary => @"/// <see cref=""AbstractDataItemRelationship"">AbstractDataItemRelationship</see> that provides a semantic reference to another <see cref=""Specification"">Specification</see> described by <see cref=""SpecificationRelationship::type"" /> and <see cref=""SpecificationRelationship::idRef"" />.";

		/// <inheritdoc />
		public string Name => "SpecificationRelationshipClass";
		
		/// <inheritdoc />
		public string AccessModifier => "public";
				
		/// <inheritdoc />
		public string Modifier => "";
				
		/// <inheritdoc />
		public string NormativeVersion => "1.7";
				
		/// <inheritdoc />
		public string DeprecatedVersion => "";
		
		/// <inheritdoc />
		public string Generalization => "_19_0_3_68e0225_1658942187874_859516_1061";

		/// <inheritdoc />
		public SpecificationRelationshipClassProperties Properties { get; } = new SpecificationRelationshipClassProperties();
        IPropertyList IClass.Properties => Properties;
		public sealed class SpecificationRelationshipClassProperties : IPropertyList
		{
			/// <inheritdoc />
			public IProperty[] Properties => new IProperty[] {
				Type,
			};
			/// <summary>
			/// <inheritdoc cref="TypeProperty" path="/summary" /><br/>
			/// <remarks>Original Name: Type</remarks>
			/// </summary>
			public TypeProperty Type { get; } = new TypeProperty();
			/// <summary>
			/// specifies how the <see cref="Specification">Specification</see> is related.
			/// </summary>
			public sealed class TypeProperty : IProperty
			{
				/// <summary>
				/// <inheritdoc />
				/// <remarks>
				/// <list type="bullet">
				/// <item>Original Type: _19_0_3_68e0225_1605646000929_248969_3052</item>
				/// <item>Type: SpecificationRelationshipTypeEnum</item>
				/// <item>Namespace: Mtconnect.DataTypes</item>
				/// </list>
				/// </remarks>
				/// </summary>
				public System.Type Type => typeof(Mtconnect.DataTypes.SpecificationRelationshipTypeEnum);
				
				/// <inheritdoc />
				public string Name => "Type";
				
				/// <inheritdoc />
				public string Summary => @"/// <see cref=""AbstractDataItemRelationship"">AbstractDataItemRelationship</see> that provides a semantic reference to another <see cref=""Specification"">Specification</see> described by <see cref=""SpecificationRelationship::type"" /> and <see cref=""SpecificationRelationship::idRef"" />.";

				/// <inheritdoc />
				public string AccessModifier => "public";
				
				/// <inheritdoc />
				public string Modifier => "";
				
				/// <inheritdoc />
				public string NormativeVersion => "1.7";
				
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