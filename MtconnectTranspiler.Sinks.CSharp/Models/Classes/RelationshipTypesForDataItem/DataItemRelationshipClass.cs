using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;
// using Mtconnect.DataTypes;

namespace Mtconnect.DeviceInformationModel.DataItems.PropertiesOfDataItem.RelationshipTypesForDataItem
{
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "1.0.15.3")]
	public sealed class DataItemRelationshipClass : IClass
	{
		/// <inheritdoc />
		public string ReferenceId => "_19_0_3_68e0225_1605645474430_802116_2875";
		
		/// <inheritdoc />
		public string Name => "DataItemRelationshipClass";
		
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
		public DataItemRelationshipClassProperties Properties { get; } = new DataItemRelationshipClassProperties();
        IPropertyList IClass.Properties => Properties;
		public sealed class DataItemRelationshipClassProperties : IPropertyList
		{
			/// <inheritdoc />
			public IProperty[] Properties => new IProperty[] {
				Type,
			};
			/// <remarks>Original Name: Type</remarks>
			public TypeProperty Type { get; } = new TypeProperty();
			public sealed class TypeProperty : IProperty
			{
				/// <summary>
				/// <inheritdoc />
				/// <remarks>
				/// <list type="bullet">
				/// <item>Original Type: _19_0_3_68e0225_1605645712659_8263_2990</item>
				/// <item>Type: DataItemRelationshipTypeEnum</item>
				/// <item>Namespace: Mtconnect.DataTypes</item>
				/// </list>
				/// </remarks>
				/// </summary>
				public System.Type Type => typeof(Mtconnect.DataTypes.DataItemRelationshipTypeEnum);
				
				/// <inheritdoc />
				public string Name => "Type";
				
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

				// TODO: Add Summary
			}
		};

	}
}