using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;
using System.Linq;

namespace Mtconnect.DeviceInformationModel.DataItems.PropertiesOfDataItem.RelationshipTypesForDataItem
{
	/// <summary>
	/// <see cref="AbstractDataItemRelationship">AbstractDataItemRelationship</see> that provides a semantic reference to another <see cref="DataItem">DataItem</see> described by <see cref="DataItemRelationship::type" />.
	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Structure___19_0_3_68e0225_1605645474430_802116_2875">model.mtconnect.org</seealso> for more information.
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.3.0.0")]
	public sealed class DataItemRelationshipClass : IClass
	{
		/// <inheritdoc />
		public string ReferenceId => "_19_0_3_68e0225_1605645474430_802116_2875";
		
		/// <inheritdoc />
		public string Summary => @"/// <see cref=""AbstractDataItemRelationship"">AbstractDataItemRelationship</see> that provides a semantic reference to another <see cref=""DataItem"">DataItem</see> described by <see cref=""DataItemRelationship::type"" />.";

		/// <inheritdoc />
		public string Name => "DataItemRelationship";
		
		/// <inheritdoc />
		public string AccessModifier => "public";
				
		/// <inheritdoc />
		public string Modifier => "";
				
		/// <inheritdoc />
		public string NormativeVersion => "1.7";
				
		/// <inheritdoc />
		public string DeprecatedVersion => "";
		
		/// <inheritdoc />
		/// <remarks>
		/// Original Type: _19_0_3_68e0225_1658942187874_859516_1061
		/// </remarks>
		public Type Generalization => typeof(Mtconnect.DeviceInformationModel.DataItems.PropertiesOfDataItem.RelationshipTypesForDataItem.AbstractDataItemRelationshipClass);

		/// <inheritdoc />
		public DataItemRelationshipClassProperties Properties { get; } = new DataItemRelationshipClassProperties();
        IPropertyList IClass.Properties => Properties;
		public class DataItemRelationshipClassProperties : Mtconnect.DeviceInformationModel.DataItems.PropertiesOfDataItem.RelationshipTypesForDataItem.AbstractDataItemRelationshipClass.AbstractDataItemRelationshipClassProperties
		{
			/// <inheritdoc />
			public IProperty[] Properties => new IProperty[] {
				Type,
			}.Concat(base.Properties).ToArray();
			/// <summary>
			/// <inheritdoc cref="TypeProperty" path="/summary" /><br/>
			/// <remarks>Original Name: Type</remarks>
			/// </summary>
			public TypeProperty Type { get; } = new TypeProperty();
			/// <summary>
			/// specifies how the <see cref="DataItem">DataItem</see> is related.
			/// </summary>
			public sealed class TypeProperty : IProperty
			{
				/// <summary>
				/// <inheritdoc />
				/// <remarks>
				/// <list type="bullet">
				/// <item>Original Type: _19_0_3_68e0225_1605645712659_8263_2990</item>
				/// <item>Type: DataItemRelationshipTypeEnumMetaClass</item>
				/// <item>Namespace: Mtconnect.DataTypes</item>
				/// </list>
				/// </remarks>
				/// </summary>
				public System.Type Type => typeof(Mtconnect.DataTypes.DataItemRelationshipTypeEnumMetaClass);
				
				/// <inheritdoc />
				public string Name => "type";
				
				/// <inheritdoc />
				public string Summary => @"/// <see cref=""AbstractDataItemRelationship"">AbstractDataItemRelationship</see> that provides a semantic reference to another <see cref=""DataItem"">DataItem</see> described by <see cref=""DataItemRelationship::type"" />.";

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