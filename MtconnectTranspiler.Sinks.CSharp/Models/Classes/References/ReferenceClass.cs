using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;

namespace Mtconnect.DeviceInformationModel.References
{
	/// <summary>
	/// pointer to information that is associated with another entity defined elsewhere in the <see cref="MTConnectDevices">MTConnectDevices</see> entity for a piece of equipment./// Description
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.3.0.0")]
	public sealed class ReferenceClass : IClass
	{
		/// <inheritdoc />
		public string ReferenceId => "EAID_25A13743_B12C_4c6c_B1DA_8E2EFDD156EF";
		
		/// <inheritdoc />
		public string Summary => @"/// pointer to information that is associated with another entity defined elsewhere in the <see cref=""MTConnectDevices"">MTConnectDevices</see> entity for a piece of equipment./// Description";

		/// <inheritdoc />
		public string Name => "ReferenceClass";
		
		/// <inheritdoc />
		public string AccessModifier => "public";
				
		/// <inheritdoc />
		public string Modifier => "abstract";
				
		/// <inheritdoc />
		public string NormativeVersion => "1.3";
				
		/// <inheritdoc />
		public string DeprecatedVersion => "";
		
		/// <inheritdoc />
		public string Generalization => "";

		/// <inheritdoc />
		public ReferenceClassProperties Properties { get; } = new ReferenceClassProperties();
        IPropertyList IClass.Properties => Properties;
		public sealed class ReferenceClassProperties : IPropertyList
		{
			/// <inheritdoc />
			public IProperty[] Properties => new IProperty[] {
				IdRef,
				Name,
				DataItemId,
				RefDataItemId,
			};
			/// <summary>
			/// <inheritdoc cref="IdRefProperty" path="/summary" /><br/>
			/// <remarks>Original Name: IdRef</remarks>
			/// </summary>
			public IdRefProperty IdRef { get; } = new IdRefProperty();
			/// <summary>
			/// pointer to the <c>id</c> of an entity that contains the information to be associated with this entity.
			/// </summary>
			public sealed class IdRefProperty : IProperty
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
				public string Name => "IdRef";
				
				/// <inheritdoc />
				public string Summary => @"/// pointer to information that is associated with another entity defined elsewhere in the <see cref=""MTConnectDevices"">MTConnectDevices</see> entity for a piece of equipment./// Description";

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
			/// <inheritdoc cref="NameProperty" path="/summary" /><br/>
			/// <remarks>Original Name: Name</remarks>
			/// </summary>
			public NameProperty Name { get; } = new NameProperty();
			/// <summary>
			///  name of an element or a piece of equipment.
			/// </summary>
			public sealed class NameProperty : IProperty
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
				public string Name => "Name";
				
				/// <inheritdoc />
				public string Summary => @"/// pointer to information that is associated with another entity defined elsewhere in the <see cref=""MTConnectDevices"">MTConnectDevices</see> entity for a piece of equipment./// Description";

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
			/// <inheritdoc cref="DataItemIdProperty" path="/summary" /><br/>
			/// <remarks>Original Name: DataItemId</remarks>
			/// </summary>
			public DataItemIdProperty DataItemId { get; } = new DataItemIdProperty();
			/// <summary>
			/// pointer to the <see cref="DataItem::id" /> that contains the information to be associated with this entity.
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
				public string Summary => @"/// pointer to information that is associated with another entity defined elsewhere in the <see cref=""MTConnectDevices"">MTConnectDevices</see> entity for a piece of equipment./// Description";

				/// <inheritdoc />
				public string AccessModifier => "private";
				
				/// <inheritdoc />
				public string Modifier => "";
				
				/// <inheritdoc />
				public string NormativeVersion => "1.3";
				
				/// <inheritdoc />
				public string DeprecatedVersion => "1.4";
				
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
			/// <summary>
			/// <inheritdoc cref="RefDataItemIdProperty" path="/summary" /><br/>
			/// <remarks>Original Name: RefDataItemId</remarks>
			/// </summary>
			public RefDataItemIdProperty RefDataItemId { get; } = new RefDataItemIdProperty();
			/// <summary>
			/// pointer to the <see cref="DataItem::id" /> that contains the information to be associated with this entity.
			/// </summary>
			public sealed class RefDataItemIdProperty : IProperty
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
				public string Name => "RefDataItemId";
				
				/// <inheritdoc />
				public string Summary => @"/// pointer to information that is associated with another entity defined elsewhere in the <see cref=""MTConnectDevices"">MTConnectDevices</see> entity for a piece of equipment./// Description";

				/// <inheritdoc />
				public string AccessModifier => "private";
				
				/// <inheritdoc />
				public string Modifier => "";
				
				/// <inheritdoc />
				public string NormativeVersion => "1.3";
				
				/// <inheritdoc />
				public string DeprecatedVersion => "1.4";
				
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