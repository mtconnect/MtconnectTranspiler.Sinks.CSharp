#pragma warning disable CS0109 // Member does not hide an inherited member; new keyword is not required
#pragma warning disable CS1574 // XML comment has cref attribute that could not be resolved
#pragma warning disable CS1584 // XML comment has syntactically incorrect cref attribute
using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;

namespace Mtconnect.DeviceInformationModel.DataItems.PropertiesOfDataItem.RelationshipTypesForDataItem
{
	/// <summary>﻿association between a <see cref="DataItem">DataItem</see> and another entity.<br /><br /><br />Description<br /><br /><see cref="AbstractDataItemRelationship">AbstractDataItemRelationship</see> is an abstract entity and hence will be realized by specific <see cref="AbstractDataItemRelationship">AbstractDataItemRelationship</see> types in an <see cref="MTConnectDevices">MTConnectDevices</see> entity. See <see cref="Relationship Types for DataItem">Relationship Types for DataItem</see>.<br /><br /><br /><br /><br />
	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Structure___19_0_3_68e0225_1658942187874_859516_1061">model.mtconnect.org</seealso> for more information.
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public sealed class AbstractDataItemRelationshipClass : IClass
	{
		/// <inheritdoc />
		public string ReferenceId => "_19_0_3_68e0225_1658942187874_859516_1061";
		
		/// <inheritdoc />
		public string Summary => @"&#10;&#10;&#10;association between a {{block(DataItem)}} and another entity.&#10;
&#10;&#10;&#10;Description&#10;&#10;&#10;&#10;{{block(AbstractDataItemRelationship)}} is an abstract entity and hence will be realized by specific {{block(AbstractDataItemRelationship)}} types in an {{block(MTConnectDevices)}} entity. See {{package(Relationship Types for DataItem)}}.&#10;
";

		/// <inheritdoc />
		public string Name => "AbstractDataItemRelationship";
		
		/// <inheritdoc />
		public string AccessModifier => "public";
				
		/// <inheritdoc />
		public string Modifier => "abstract";
				
		/// <inheritdoc />
		public string NormativeVersion => "1.5";
				
		/// <inheritdoc />
		public string DeprecatedVersion => "";
		
		/// <inheritdoc />
		public Type Generalization => null;

		/// <inheritdoc />
		public new AbstractDataItemRelationshipClassProperties Properties { get; } = new AbstractDataItemRelationshipClassProperties();
        IPropertyList IClass.Properties => Properties;
		/// <summary>
		/// Property list for <see cref="AbstractDataItemRelationshipClass" />.
		/// </summary>
		public class AbstractDataItemRelationshipClassProperties : IPropertyList
		{
			/// <inheritdoc />
			public IProperty[] Properties => new IProperty[] {
				IdRef,
				Name,
			};
			/// <summary>
			/// <inheritdoc cref="IdRefProperty" path="/summary" /><br/>
			/// <remarks>Original Name: IdRef</remarks>
			/// </summary>
			public IdRefProperty IdRef { get; } = new IdRefProperty();
			
			/// <summary>﻿reference to the related entity's <c>id</c>.<br /><br /><br /><br />
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
				public string Summary => @"&#10;&#10;&#10;reference to the related entity's `id`.&#10;
";

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
			/// <summary>
			/// <inheritdoc cref="NameProperty" path="/summary" /><br/>
			/// <remarks>Original Name: Name</remarks>
			/// </summary>
			public NameProperty Name { get; } = new NameProperty();
			
			/// <summary>﻿descriptive name associated with this <see cref="AbstractDataItemRelationship">AbstractDataItemRelationship</see>.<br /><br /><br />
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
				public string Summary => @"&#10;&#10;&#10;descriptive name associated with this {{block(AbstractDataItemRelationship)}}.&#10;
";

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