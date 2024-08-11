using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;
using System.Linq;

namespace Mtconnect.ObservationInformationModel
{
	/// <summary>
	/// abstract entity that provides telemetry data for a <see cref="DataItem">DataItem</see> at a point in time./// Description
	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Structure___19_0_3_45f01b9_1579566531115_47734_25731">model.mtconnect.org</seealso> for more information.
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.3.0.0")]
	public sealed class ObservationGeneralization : IClass
	{
		/// <inheritdoc />
		public string ReferenceId => "_19_0_3_45f01b9_1579566531115_47734_25731";
		
		/// <inheritdoc />
		public string Summary => @"/// abstract entity that provides telemetry data for a <see cref=""DataItem"">DataItem</see> at a point in time./// Description";

		/// <inheritdoc />
		public string Name => "Observation";
		
		/// <inheritdoc />
		public string AccessModifier => "public";
				
		/// <inheritdoc />
		public string Modifier => "abstract";
				
		/// <inheritdoc />
		public string NormativeVersion => "1.0";
				
		/// <inheritdoc />
		public string DeprecatedVersion => "";
		
		/// <inheritdoc />
		/// <remarks>
		/// Original Type: _19_0_3_45f01b9_1581812901326_593856_4168
		/// </remarks>
		public Type Generalization => typeof(Mtconnect.Glossary.MTConnectTerms.ObservationClass);

		/// <inheritdoc />
		public ObservationGeneralizationProperties Properties { get; } = new ObservationGeneralizationProperties();
        IPropertyList IClass.Properties => Properties;
		public class ObservationGeneralizationProperties : Mtconnect.Glossary.MTConnectTerms.ObservationClass.ObservationClassProperties
		{
			/// <inheritdoc />
			public IProperty[] Properties => new IProperty[] {
				CompositionId,
				DataItemId,
				Name,
				Sequence,
				SubType,
				Timestamp,
				MadeByComponentPart,
				Type,
				Units,
				IsUnavailable,
				Result,
				MadeForDataItemPart,
			}.Concat(base.Properties).ToArray();
			/// <summary>
			/// <inheritdoc cref="CompositionIdProperty" path="/summary" /><br/>
			/// <remarks>Original Name: CompositionId</remarks>
			/// </summary>
			public CompositionIdProperty CompositionId { get; } = new CompositionIdProperty();
			/// <summary>
			/// identifier of the <see cref="Composition">Composition</see> entity defined in the <i>MTConnectDevices Response Document</i> associated with the data reported for the <see cref="Observation">Observation</see>.
			/// </summary>
			public sealed class CompositionIdProperty : IProperty
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
				public string Name => "compositionId";
				
				/// <inheritdoc />
				public string Summary => @"/// abstract entity that provides telemetry data for a <see cref=""DataItem"">DataItem</see> at a point in time./// Description";

				/// <inheritdoc />
				public string AccessModifier => "public";
				
				/// <inheritdoc />
				public string Modifier => "static";
				
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
			/// <inheritdoc cref="DataItemIdProperty" path="/summary" /><br/>
			/// <remarks>Original Name: DataItemId</remarks>
			/// </summary>
			public DataItemIdProperty DataItemId { get; } = new DataItemIdProperty();
			/// <summary>
			/// unique identifier of the <see cref="DataItem">DataItem</see> associated with this <see cref="Observation">Observation</see>.  <see cref="Observation::dataItemId" /> <b>MUST</b> match the associated <see cref="DataItem::id" /> defined in the <i>MTConnectDevices Response Document</i>.
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
				public string Summary => @"/// abstract entity that provides telemetry data for a <see cref=""DataItem"">DataItem</see> at a point in time./// Description";

				/// <inheritdoc />
				public string AccessModifier => "public";
				
				/// <inheritdoc />
				public string Modifier => "static";
				
				/// <inheritdoc />
				public string NormativeVersion => "1.0";
				
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
			/// name of the <see cref="DataItem">DataItem</see> associated with this <see cref="Observation">Observation</see>.  <see cref="Observation::name" /> <b>MUST</b> match the associated <see cref="DataItem::name" /> defined in the <i>MTConnectDevices Response Document</i>.
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
				public string Summary => @"/// abstract entity that provides telemetry data for a <see cref=""DataItem"">DataItem</see> at a point in time./// Description";

				/// <inheritdoc />
				public string AccessModifier => "public";
				
				/// <inheritdoc />
				public string Modifier => "static";
				
				/// <inheritdoc />
				public string NormativeVersion => "1.0";
				
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
			/// <inheritdoc cref="SequenceProperty" path="/summary" /><br/>
			/// <remarks>Original Name: Sequence</remarks>
			/// </summary>
			public SequenceProperty Sequence { get; } = new SequenceProperty();
			/// <summary>
			/// number representing the sequential position of an occurrence of an <i>observation</i> in the data buffer of an <i>agent</i>.  <see cref="Observation::sequence" /> <b>MUST</b> have a value represented as an unsigned 64-bit value from 1 to <i> 2^{64}-1 </i>s.
			/// </summary>
			public sealed class SequenceProperty : IProperty
			{
				/// <summary>
				/// <inheritdoc />
				/// <remarks>
				/// <list type="bullet">
				/// <item>Original Type: _19_0_3_91b028d_1579272271512_537408_674</item>
				/// <item>Type: Int32</item>
				/// <item>Namespace: </item>
				/// </list>
				/// </remarks>
				/// </summary>
				public System.Type Type => typeof(Int32);
				
				/// <inheritdoc />
				public string Name => "sequence";
				
				/// <inheritdoc />
				public string Summary => @"/// abstract entity that provides telemetry data for a <see cref=""DataItem"">DataItem</see> at a point in time./// Description";

				/// <inheritdoc />
				public string AccessModifier => "public";
				
				/// <inheritdoc />
				public string Modifier => "";
				
				/// <inheritdoc />
				public string NormativeVersion => "1.0";
				
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
			/// <inheritdoc cref="SubTypeProperty" path="/summary" /><br/>
			/// <remarks>Original Name: SubType</remarks>
			/// </summary>
			public SubTypeProperty SubType { get; } = new SubTypeProperty();
			/// <summary>
			/// subtype of the <see cref="DataItem">DataItem</see> associated with this <see cref="Observation">Observation</see>.  <see cref="Observation::subType" /> <b>MUST</b> match the associated <see cref="DataItem::subType" /> defined in the <i>MTConnectDevices Response Document</i>.
			/// </summary>
			public sealed class SubTypeProperty : IProperty
			{
				/// <summary>
				/// <inheritdoc />
				/// <remarks>
				/// <list type="bullet">
				/// <item>Original Type: _19_0_3_45f01b9_1579563592155_977172_22064</item>
				/// <item>Type: DataItemSubTypeEnumMetaClass</item>
				/// <item>Namespace: Mtconnect.DataTypes</item>
				/// </list>
				/// </remarks>
				/// </summary>
				public System.Type Type => typeof(Mtconnect.DataTypes.DataItemSubTypeEnumMetaClass);
				
				/// <inheritdoc />
				public string Name => "subType";
				
				/// <inheritdoc />
				public string Summary => @"/// abstract entity that provides telemetry data for a <see cref=""DataItem"">DataItem</see> at a point in time./// Description";

				/// <inheritdoc />
				public string AccessModifier => "public";
				
				/// <inheritdoc />
				public string Modifier => "static";
				
				/// <inheritdoc />
				public string NormativeVersion => "1.2";
				
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
			/// <inheritdoc cref="TimestampProperty" path="/summary" /><br/>
			/// <remarks>Original Name: Timestamp</remarks>
			/// </summary>
			public TimestampProperty Timestamp { get; } = new TimestampProperty();
			/// <summary>
			/// most accurate time available to a piece of equipment that represents the point in time that the data reported was measured.
			/// </summary>
			public sealed class TimestampProperty : IProperty
			{
				/// <summary>
				/// <inheritdoc />
				/// <remarks>
				/// <list type="bullet">
				/// <item>Original Type: _19_0_3_91b028d_1579272233011_597138_670</item>
				/// <item>Type: DateTime</item>
				/// <item>Namespace: </item>
				/// </list>
				/// </remarks>
				/// </summary>
				public System.Type Type => typeof(DateTime);
				
				/// <inheritdoc />
				public string Name => "timestamp";
				
				/// <inheritdoc />
				public string Summary => @"/// abstract entity that provides telemetry data for a <see cref=""DataItem"">DataItem</see> at a point in time./// Description";

				/// <inheritdoc />
				public string AccessModifier => "public";
				
				/// <inheritdoc />
				public string Modifier => "";
				
				/// <inheritdoc />
				public string NormativeVersion => "1.0";
				
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
			/// <inheritdoc cref="MadeByComponentPartProperty" path="/summary" /><br/>
			/// <remarks>Original Name: MadeByComponent</remarks>
			/// </summary>
			public MadeByComponentPartProperty MadeByComponentPart { get; } = new MadeByComponentPartProperty();
			public sealed class MadeByComponentPartProperty : IProperty
			{
				/// <summary>
				/// <inheritdoc />
				/// <remarks>
				/// <list type="bullet">
				/// <item>Original Type: EAID_8548C620_467A_4f50_9A22_58D84B7E8779</item>
				/// <item>Type: ComponentGeneralization</item>
				/// <item>Namespace: Mtconnect.DeviceInformationModel.Components</item>
				/// </list>
				/// </remarks>
				/// </summary>
				public System.Type Type => typeof(Mtconnect.DeviceInformationModel.Components.ComponentGeneralization);
				
				/// <inheritdoc />
				public string Name => "madeByComponent";
				
				/// <inheritdoc />
				public string Summary => @"/// abstract entity that provides telemetry data for a <see cref=""DataItem"">DataItem</see> at a point in time./// Description";

				/// <inheritdoc />
				public string AccessModifier => "private";
				
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
				public string Association => "Observations";

				// Note: DefaultValue.Name
				/// <inheritdoc />
				public string DefaultValue => "";
			}
			/// <summary>
			/// <inheritdoc cref="TypeProperty" path="/summary" /><br/>
			/// <remarks>Original Name: Type</remarks>
			/// </summary>
			public TypeProperty Type { get; } = new TypeProperty();
			/// <summary>
			/// type of the <see cref="DataItem">DataItem</see> associated with this <see cref="Observation">Observation</see>.  <see cref="Observation::type" /> <b>MUST</b> match the associated <see cref="DataItem::type" /> defined in the <i>MTConnectDevices Response Document</i>.
			/// </summary>
			public sealed class TypeProperty : IProperty
			{
				/// <summary>
				/// <inheritdoc />
				/// <remarks>
				/// <list type="bullet">
				/// <item>Original Type: _19_0_3_45f01b9_1579563576485_587701_22033</item>
				/// <item>Type: DataItemTypeEnumMetaClass</item>
				/// <item>Namespace: Mtconnect.DataTypes</item>
				/// </list>
				/// </remarks>
				/// </summary>
				public System.Type Type => typeof(Mtconnect.DataTypes.DataItemTypeEnumMetaClass);
				
				/// <inheritdoc />
				public string Name => "type";
				
				/// <inheritdoc />
				public string Summary => @"/// abstract entity that provides telemetry data for a <see cref=""DataItem"">DataItem</see> at a point in time./// Description";

				/// <inheritdoc />
				public string AccessModifier => "public";
				
				/// <inheritdoc />
				public string Modifier => "static";
				
				/// <inheritdoc />
				public string NormativeVersion => "1.0";
				
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
			/// <inheritdoc cref="UnitsProperty" path="/summary" /><br/>
			/// <remarks>Original Name: Units</remarks>
			/// </summary>
			public UnitsProperty Units { get; } = new UnitsProperty();
			/// <summary>
			/// units of the <see cref="DataItem">DataItem</see> associated with this <see cref="Observation">Observation</see>.  <see cref="Observation::units" /> <b>MUST</b> match the associated <see cref="DataItem::units" /> defined in the <i>MTConnectDevices Response Document</i>.
			/// </summary>
			public sealed class UnitsProperty : IProperty
			{
				/// <summary>
				/// <inheritdoc />
				/// <remarks>
				/// <list type="bullet">
				/// <item>Original Type: EAID_8FEC81E4_8E1F_4f45_820B_F9F25DD83F9A</item>
				/// <item>Type: UnitEnumMetaClass</item>
				/// <item>Namespace: Mtconnect.DataTypes</item>
				/// </list>
				/// </remarks>
				/// </summary>
				public System.Type Type => typeof(Mtconnect.DataTypes.UnitEnumMetaClass);
				
				/// <inheritdoc />
				public string Name => "units";
				
				/// <inheritdoc />
				public string Summary => @"/// abstract entity that provides telemetry data for a <see cref=""DataItem"">DataItem</see> at a point in time./// Description";

				/// <inheritdoc />
				public string AccessModifier => "public";
				
				/// <inheritdoc />
				public string Modifier => "static";
				
				/// <inheritdoc />
				public string NormativeVersion => "1.0";
				
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
			/// <inheritdoc cref="IsUnavailableProperty" path="/summary" /><br/>
			/// <remarks>Original Name: IsUnavailable</remarks>
			/// </summary>
			public IsUnavailableProperty IsUnavailable { get; } = new IsUnavailableProperty();
			/// <summary>
			/// when <c>true</c>, <see cref="Observation::result" /> is indeterminate.  > Note 1 to entry: In <i>XML</i>, when <c>isUnavailable</c> is <c>true</c>, the <i>XML</i> <c>CDATA</c> of the <c>Observation</c> <b>MUST</b> be <c>UNAVAILABLE</c>.  <c></c>`xml <Execution dataItemId="..." ...>UNAVAILABLE</Execution> <c></c>`  > Note 2 to entry: In <i>JSON</i>, when <c>isUnavailable</c> is <c>true</c>, the <i>JSON</i> <c>value</c> of the <c>Observation</c> <b>MUST</b> be <c>UNAVAILABLE</c>. <c></c>`json   "Execution" : [ { "dataItemId": "..." ..., "value": "UNAVAILABLE" } ] <c></c>`
			/// </summary>
			public sealed class IsUnavailableProperty : IProperty
			{
				/// <summary>
				/// <inheritdoc />
				/// <remarks>
				/// <list type="bullet">
				/// <item>Original Type: _19_0_3_91b028d_1579278876899_683310_3821</item>
				/// <item>Type: Boolean</item>
				/// <item>Namespace: </item>
				/// </list>
				/// </remarks>
				/// </summary>
				public System.Type Type => typeof(Boolean);
				
				/// <inheritdoc />
				public string Name => "isUnavailable";
				
				/// <inheritdoc />
				public string Summary => @"/// abstract entity that provides telemetry data for a <see cref=""DataItem"">DataItem</see> at a point in time./// Description";

				/// <inheritdoc />
				public string AccessModifier => "public";
				
				/// <inheritdoc />
				public string Modifier => "";
				
				/// <inheritdoc />
				public string NormativeVersion => "1.0";
				
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
			/// <inheritdoc cref="ResultProperty" path="/summary" /><br/>
			/// <remarks>Original Name: Result</remarks>
			/// </summary>
			public ResultProperty Result { get; } = new ResultProperty();
			/// <summary>
			/// <i>observation</i> of the <see cref="Observation">Observation</see> entity.  The default value type for <see cref="Observation::result" /> is <c>string</c>.  > Note 1 to entry: in <i>XML</i> the <see cref="Observation::result" /> is the <c>CDATA</c> of the Observation <i>element</i>.  ~~~~xml <Execution dataItemId="..." ...>READY</Execution> ~~~~  > Note 2 to entry: in <i>JSON</i> the <see cref="Observation::result" /> is the member <c>value</c> of the Observation object.  ~~~~json "Execution" : [ { "dataItemId": "..." ..., "value": "READY" } ] ~~~~
			/// </summary>
			public sealed class ResultProperty : IProperty
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
				public string Name => "result";
				
				/// <inheritdoc />
				public string Summary => @"/// abstract entity that provides telemetry data for a <see cref=""DataItem"">DataItem</see> at a point in time./// Description";

				/// <inheritdoc />
				public string AccessModifier => "public";
				
				/// <inheritdoc />
				public string Modifier => "";
				
				/// <inheritdoc />
				public string NormativeVersion => "1.0";
				
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
			/// <inheritdoc cref="MadeForDataItemPartProperty" path="/summary" /><br/>
			/// <remarks>Original Name: MadeForDataItem</remarks>
			/// </summary>
			public MadeForDataItemPartProperty MadeForDataItemPart { get; } = new MadeForDataItemPartProperty();
			public sealed class MadeForDataItemPartProperty : IProperty
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
				public string Name => "madeForDataItem";
				
				/// <inheritdoc />
				public string Summary => @"/// abstract entity that provides telemetry data for a <see cref=""DataItem"">DataItem</see> at a point in time./// Description";

				/// <inheritdoc />
				public string AccessModifier => "private";
				
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
				public string Association => "Observations";

				// Note: DefaultValue.Name
				/// <inheritdoc />
				public string DefaultValue => "";
			}
		};

	}
}