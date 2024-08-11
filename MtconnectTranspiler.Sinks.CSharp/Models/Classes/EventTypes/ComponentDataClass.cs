using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;
using System.Linq;

namespace Mtconnect.ObservationInformationModel.ObservationTypes.EventTypes
{
	/// <summary>
	/// tabular <see cref="EventEnum::COMPONENT_DATA">EventEnum::COMPONENT_DATA</see>  If the <see cref="Component">Component</see> multiplicity can be determined, the device model <b>MUST</b> use a fixed set of <see cref="Component">Component</see>s.  <see cref="ComponentData">ComponentData</see> <b>MUST</b> provide a <see cref="DataItem">DataItem</see> <see cref="Definition">Definition</see>.
	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Structure___19_0_3_68e0225_1678101504782_455626_16476">model.mtconnect.org</seealso> for more information.
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.3.0.0")]
	public sealed class ComponentDataClass : IClass
	{
		/// <inheritdoc />
		public string ReferenceId => "_19_0_3_68e0225_1678101504782_455626_16476";
		
		/// <inheritdoc />
		public string Summary => @"/// tabular <see cref=""EventEnum::COMPONENT_DATA"">EventEnum::COMPONENT_DATA</see>  If the <see cref=""Component"">Component</see> multiplicity can be determined, the device model <b>MUST</b> use a fixed set of <see cref=""Component"">Component</see>s.  <see cref=""ComponentData"">ComponentData</see> <b>MUST</b> provide a <see cref=""DataItem"">DataItem</see> <see cref=""Definition"">Definition</see>.";

		/// <inheritdoc />
		public string Name => "ComponentData";
		
		/// <inheritdoc />
		public string AccessModifier => "public";
				
		/// <inheritdoc />
		public string Modifier => "";
				
		/// <inheritdoc />
		public string NormativeVersion => "2.2";
				
		/// <inheritdoc />
		public string DeprecatedVersion => "";
		
		/// <inheritdoc />
		/// <remarks>
		/// Original Type: _19_0_3_45f01b9_1579566531115_47447_25730
		/// </remarks>
		public Type Generalization => typeof(Mtconnect.ObservationInformationModel.EventClass);

		/// <inheritdoc />
		public ComponentDataClassProperties Properties { get; } = new ComponentDataClassProperties();
        IPropertyList IClass.Properties => Properties;
		public class ComponentDataClassProperties : Mtconnect.ObservationInformationModel.EventClass.EventClassProperties
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
			public sealed class TypeProperty : IProperty
			{
				/// <summary>
				/// <inheritdoc />
				/// <remarks>
				/// <list type="bullet">
				/// <item>Original Type: _19_0_3_45f01b9_1580398379726_606068_12802</item>
				/// <item>Type: EventEnumMetaClass</item>
				/// <item>Namespace: Mtconnect.DataTypes</item>
				/// </list>
				/// </remarks>
				/// </summary>
				public System.Type Type => typeof(Mtconnect.DataTypes.EventEnumMetaClass);
				
				/// <inheritdoc />
				public string Name => "type";
				
				/// <inheritdoc />
				public string Summary => @"/// tabular <see cref=""EventEnum::COMPONENT_DATA"">EventEnum::COMPONENT_DATA</see>  If the <see cref=""Component"">Component</see> multiplicity can be determined, the device model <b>MUST</b> use a fixed set of <see cref=""Component"">Component</see>s.  <see cref=""ComponentData"">ComponentData</see> <b>MUST</b> provide a <see cref=""DataItem"">DataItem</see> <see cref=""Definition"">Definition</see>.";

				/// <inheritdoc />
				public string AccessModifier => "public";
				
				/// <inheritdoc />
				public string Modifier => "static";
				
				/// <inheritdoc />
				public string NormativeVersion => "";
				
				/// <inheritdoc />
				public string DeprecatedVersion => "";
				
				/// <inheritdoc />
				public string Aggregation => "composite";

				// Note: Extension.Extender
				/// <inheritdoc />
				public string Extension => "";
				
				/// <inheritdoc />
				public string Association => "";

				// Note: DefaultValue.Name
				/// <inheritdoc />
				public string DefaultValue => "COMPONENT_DATA";
			}
		};

	}
}