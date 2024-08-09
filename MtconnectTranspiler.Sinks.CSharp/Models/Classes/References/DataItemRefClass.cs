using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;
using System.Linq;

namespace Mtconnect.DeviceInformationModel.References
{
	/// <summary>
	/// <see cref="Reference">Reference</see> that is a pointer to a <see cref="DataItem">DataItem</see> associated with another entity defined for a piece of equipment./// Description
	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Structure___19_0_3_45f01b9_1581212127193_199949_213">model.mtconnect.org</seealso> for more information.
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.3.0.0")]
	public sealed class DataItemRefClass : IClass
	{
		/// <inheritdoc />
		public string ReferenceId => "_19_0_3_45f01b9_1581212127193_199949_213";
		
		/// <inheritdoc />
		public string Summary => @"/// <see cref=""Reference"">Reference</see> that is a pointer to a <see cref=""DataItem"">DataItem</see> associated with another entity defined for a piece of equipment./// Description";

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
		public class DataItemRefClassProperties : Mtconnect.DeviceInformationModel.References.ReferenceClass.ReferenceClassProperties
		{
			/// <inheritdoc />
			public IProperty[] Properties => new IProperty[] {
				IdRef,
			}.Concat(base.Properties).ToArray();
			/// <summary>
			/// <inheritdoc cref="IdRefProperty" path="/summary" /><br/>
			/// <remarks>Original Name: IdRef</remarks>
			/// </summary>
			public IdRefProperty IdRef { get; } = new IdRefProperty();
			/// <summary>
			/// pointer to the <see cref="DataItem::id" /> that contains the information to be associated with this entity.
			/// </summary>
			public sealed class IdRefProperty : IProperty
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
				public string Summary => @"/// <see cref=""Reference"">Reference</see> that is a pointer to a <see cref=""DataItem"">DataItem</see> associated with another entity defined for a piece of equipment./// Description";

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