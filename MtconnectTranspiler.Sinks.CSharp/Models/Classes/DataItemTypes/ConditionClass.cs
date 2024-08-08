using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;
// using Mtconnect.DataTypes;

namespace Mtconnect.DeviceInformationModel.DataItems.DataItemTypes
{
	/// <summary>
	/// abstract <see cref="DataItem">DataItem</see> that is about an entity's status regarding its ability to operate or it provides an indication whether the data reported for the entity is within an expected range./// Description
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.3.0.0")]
	public sealed class ConditionClass : IClass
	{
		/// <inheritdoc />
		public string ReferenceId => "EAID_3F5927FF_5B8D_4307_8D27_9654F724A657";
		
		/// <inheritdoc />
		public string Summary => @"/// abstract <see cref=""DataItem"">DataItem</see> that is about an entity's status regarding its ability to operate or it provides an indication whether the data reported for the entity is within an expected range./// Description";

		/// <inheritdoc />
		public string Name => "ConditionClass";
		
		/// <inheritdoc />
		public string AccessModifier => "public";
				
		/// <inheritdoc />
		public string Modifier => "abstract";
				
		/// <inheritdoc />
		public string NormativeVersion => "1.1";
				
		/// <inheritdoc />
		public string DeprecatedVersion => "";
		
		/// <inheritdoc />
		public string Generalization => "EAID_002C94B7_1257_49be_8EAA_CE7FCD7AFF8A";

		/// <inheritdoc />
		public ConditionClassProperties Properties { get; } = new ConditionClassProperties();
        IPropertyList IClass.Properties => Properties;
		public sealed class ConditionClassProperties : IPropertyList
		{
			/// <inheritdoc />
			public IProperty[] Properties => new IProperty[] {
				Category,
				Type,
			};
			/// <summary>
			/// <inheritdoc cref="CategoryProperty" path="/summary" /><br/>
			/// <remarks>Original Name: Category</remarks>
			/// </summary>
			public CategoryProperty Category { get; } = new CategoryProperty();
			public sealed class CategoryProperty : IProperty
			{
				/// <summary>
				/// <inheritdoc />
				/// <remarks>
				/// <list type="bullet">
				/// <item>Original Type: _19_0_3_91b028d_1579277872728_249968_3735</item>
				/// <item>Type: CategoryEnum</item>
				/// <item>Namespace: Mtconnect.DataTypes</item>
				/// </list>
				/// </remarks>
				/// </summary>
				public System.Type Type => typeof(Mtconnect.DataTypes.CategoryEnum);
				
				/// <inheritdoc />
				public string Name => "Category";
				
				/// <inheritdoc />
				public string Summary => @"/// abstract <see cref=""DataItem"">DataItem</see> that is about an entity's status regarding its ability to operate or it provides an indication whether the data reported for the entity is within an expected range./// Description";

				/// <inheritdoc />
				public string AccessModifier => "public";
				
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
				/// <item>Original Type: _19_0_3_45f01b9_1580398386435_855466_12827</item>
				/// <item>Type: ConditionEnum</item>
				/// <item>Namespace: Mtconnect.DataTypes</item>
				/// </list>
				/// </remarks>
				/// </summary>
				public System.Type Type => typeof(Mtconnect.DataTypes.ConditionEnum);
				
				/// <inheritdoc />
				public string Name => "Type";
				
				/// <inheritdoc />
				public string Summary => @"/// abstract <see cref=""DataItem"">DataItem</see> that is about an entity's status regarding its ability to operate or it provides an indication whether the data reported for the entity is within an expected range./// Description";

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
		};

	}
}