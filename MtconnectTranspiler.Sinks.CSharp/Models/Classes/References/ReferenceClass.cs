#pragma warning disable CS0109 // Member does not hide an inherited member; new keyword is not required
#pragma warning disable CS1574 // XML comment has cref attribute that could not be resolved
#pragma warning disable CS1584 // XML comment has syntactically incorrect cref attribute
using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;

namespace Mtconnect.DeviceInformationModel.References
{
	/// <summary>﻿pointer to information that is associated with another entity defined elsewhere in the <see cref="MTConnectDevices">MTConnectDevices</see> entity for a piece of equipment.<br /><br /><br />Description<br /><br /><see cref="Reference">Reference</see> is an abstract entity and will be realized by a specific <see cref="Reference">Reference</see> type for an <see cref="MTConnectDevices">MTConnectDevices</see> entity. See <see cref="ComponentRef">ComponentRef</see> and <see cref="DataItemRef">DataItemRef</see>.<br /><br /><br /><br /><br />
	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Structure__EAID_25A13743_B12C_4c6c_B1DA_8E2EFDD156EF">model.mtconnect.org</seealso> for more information.
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public sealed class ReferenceClass : IClass
	{
		/// <inheritdoc />
		public string ReferenceId => "EAID_25A13743_B12C_4c6c_B1DA_8E2EFDD156EF";
		
		/// <inheritdoc />
		public string Summary => @"&#10;&#10;&#10;pointer to information that is associated with another entity defined elsewhere in the {{block(MTConnectDevices)}} entity for a piece of equipment.&#10;
&#10;&#10;&#10;Description&#10;&#10;&#10;&#10;{{block(Reference)}} is an abstract entity and will be realized by a specific {{block(Reference)}} type for an {{block(MTConnectDevices)}} entity. See {{sect(ComponentRef)}} and {{sect(DataItemRef)}}.&#10;
";

		/// <inheritdoc />
		public string Name => "Reference";
		
		/// <inheritdoc />
		public string AccessModifier => "public";
				
		/// <inheritdoc />
		public string Modifier => "abstract";
				
		/// <inheritdoc />
		public string NormativeVersion => "1.3";
				
		/// <inheritdoc />
		public string DeprecatedVersion => "";
		
		/// <inheritdoc />
		public Type Generalization => null;

		/// <inheritdoc />
		public new ReferenceClassProperties Properties { get; } = new ReferenceClassProperties();
        IPropertyList IClass.Properties => Properties;
		/// <summary>
		/// Property list for <see cref="ReferenceClass" />.
		/// </summary>
		public class ReferenceClassProperties : IPropertyList
		{
			/// <inheritdoc />
			public virtual IProperty[] Properties => new IProperty[] {
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
			
			/// <summary>﻿pointer to the <c>id</c> of an entity that contains the information to be associated with this entity.<br /><br /><br />
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
				public string Name => "idRef";
				
				/// <inheritdoc />
				public string Summary => @"&#10;&#10;&#10;pointer to the `id` of an entity that contains the information to be associated with this entity.&#10;
";

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
			
			/// <summary>﻿ name of an element or a piece of equipment.<br /><br /><br />
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
				public string Name => "name";
				
				/// <inheritdoc />
				public string Summary => @"&#10;&#10;&#10; name of an element or a piece of equipment.&#10;
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
			/// <inheritdoc cref="DataItemIdProperty" path="/summary" /><br/>
			/// <remarks>Original Name: DataItemId</remarks>
			/// </summary>
			public DataItemIdProperty DataItemId { get; } = new DataItemIdProperty();
			
			/// <summary>﻿pointer to the <see cref="DataItem.id">id in DataItem</see> that contains the information to be associated with this entity.<br /><br /><br />
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
				public string Name => "dataItemId";
				
				/// <inheritdoc />
				public string Summary => @"&#10;&#10;&#10;pointer to the {{property(DataItem::id)}} that contains the information to be associated with this entity.&#10;
";

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
			
			/// <summary>﻿pointer to the <see cref="DataItem.id">id in DataItem</see> that contains the information to be associated with this entity.<br /><br /><br />
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
				public string Name => "refDataItemId";
				
				/// <inheritdoc />
				public string Summary => @"&#10;&#10;&#10;pointer to the {{property(DataItem::id)}} that contains the information to be associated with this entity.&#10;
";

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