#pragma warning disable CS0109 // Member does not hide an inherited member; new keyword is not required
#pragma warning disable CS1574 // XML comment has cref attribute that could not be resolved
#pragma warning disable CS1584 // XML comment has syntactically incorrect cref attribute
using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;
using System.Linq;

namespace Mtconnect.DeviceInformationModel.References
{
	/// <summary>﻿<see cref="Reference">Reference</see> that is a pointer to a <see cref="DataItem">DataItem</see> associated with another entity defined for a piece of equipment.<br /><br /><br />Description<br /><br /><see cref="DataItemRef">DataItemRef</see> allows the data associated with a <see cref="DataItem">DataItem</see> defined in another entity to be directly associated with this entity.<br /><br /><br /><br /><br />
	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Structure___19_0_3_45f01b9_1581212127193_199949_213">model.mtconnect.org</seealso> for more information.
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public sealed class DataItemRefClass : IClass
	{
		/// <inheritdoc />
		public string ReferenceId => "_19_0_3_45f01b9_1581212127193_199949_213";
		
		/// <inheritdoc />
		public string Summary => @"&#10;&#10;&#10;{{block(Reference)}} that is a pointer to a {{block(DataItem)}} associated with another entity defined for a piece of equipment.&#10;
&#10;&#10;&#10;Description&#10;&#10;&#10;&#10;{{block(DataItemRef)}} allows the data associated with a {{block(DataItem)}} defined in another entity to be directly associated with this entity.&#10;
";

		/// <inheritdoc />
		public string Name => "DataItemRef";
		
		/// <inheritdoc />
		public string AccessModifier => "public";
				
		/// <inheritdoc />
		public string Modifier => "";
				
		/// <inheritdoc />
		public string NormativeVersion => "1.4";
				
		/// <inheritdoc />
		public string DeprecatedVersion => "";
		
		/// <inheritdoc />
		/// <remarks>
		/// Original Type: EAID_25A13743_B12C_4c6c_B1DA_8E2EFDD156EF
		/// </remarks>
		public Type Generalization => typeof(Mtconnect.DeviceInformationModel.References.ReferenceClass);

		/// <inheritdoc />
		public DataItemRefClassProperties Properties { get; } = new DataItemRefClassProperties();
        IPropertyList IClass.Properties => Properties;
		/// <summary>
		/// Property list for <see cref="DataItemRefClass" />.
		/// <br/><b>Note</b>, some properties (<see cref="IProperty" />) are inherited from <see cref="Mtconnect.DeviceInformationModel.References.ReferenceClass.ReferenceClassProperties" />.
		/// </summary>
		public class DataItemRefClassProperties : Mtconnect.DeviceInformationModel.References.ReferenceClass.ReferenceClassProperties
		{
			/// <inheritdoc />
			public new IProperty[] Properties => new IProperty[] {
				IdRef,
			}.Concat(base.Properties).ToArray();
			/// <summary>
			/// <inheritdoc cref="IdRefProperty" path="/summary" /><br/>
			/// <remarks>Original Name: IdRef</remarks>
			/// </summary>
			public new IdRefProperty IdRef { get; } = new IdRefProperty();
			
			/// <summary>﻿pointer to the <see cref="DataItem.id">id in DataItem</see> that contains the information to be associated with this entity.<br /><br /><br />
			/// </summary>
			public new sealed class IdRefProperty : IProperty
			{
				/// <summary>
				/// <inheritdoc />
				/// <remarks>
				/// <list type="bullet">
				/// <item>Original Type: EAID_002C94B7_1257_49be_8EAA_CE7FCD7AFF8A</item>
				/// <item>Type: DataItemClass</item>
				/// <item>Namespace: Mtconnect.DeviceInformationModel.DataItems</item>
				/// </list>
				/// </remarks>
				/// </summary>
				public System.Type Type => typeof(Mtconnect.DeviceInformationModel.DataItems.DataItemClass);
				
				/// <inheritdoc />
				public string Name => "idRef";
				
				/// <inheritdoc />
				public string Summary => @"&#10;&#10;&#10;pointer to the {{property(DataItem::id)}} that contains the information to be associated with this entity.&#10;
";

				/// <inheritdoc />
				public string AccessModifier => "private";
				
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
		};

	}
}