using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;

namespace Mtconnect.DeviceInformationModel.DataItems
{
	/// <summary>
	/// information reported about a piece of equipment.
	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Structure__EAID_002C94B7_1257_49be_8EAA_CE7FCD7AFF8A">model.mtconnect.org</seealso> for more information.
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.3.0.0")]
	public sealed class DataItemClass : IClass
	{
		/// <inheritdoc />
		public string ReferenceId => "EAID_002C94B7_1257_49be_8EAA_CE7FCD7AFF8A";
		
		/// <inheritdoc />
		public string Summary => @"/// information reported about a piece of equipment.";

		/// <inheritdoc />
		public string Name => "DataItem";
		
		/// <inheritdoc />
		public string AccessModifier => "public";
				
		/// <inheritdoc />
		public string Modifier => "";
				
		/// <inheritdoc />
		public string NormativeVersion => "1.0";
				
		/// <inheritdoc />
		public string DeprecatedVersion => "";
		
		/// <inheritdoc />
		public Type Generalization => null;

		/// <inheritdoc />
		public DataItemClassProperties Properties { get; } = new DataItemClassProperties();
        IPropertyList IClass.Properties => Properties;
		public class DataItemClassProperties : IPropertyList
		{
			/// <inheritdoc />
			public IProperty[] Properties => new IProperty[] {
				Category,
				CompositionId,
				CoordinateSystem,
				Discrete,
				Id,
				Name,
				NativeScale,
				NativeUnits,
				SampleRate,
				SignificantDigits,
				Statistic,
				SubType,
				Type,
				Units,
				IsObservedByPart,
				Representation,
				HasSourcePart,
				HasConstraintPart,
				HasFilterPart,
				HasInitialValuePart,
				HasResetTriggerPart,
				HasObservationPart,
				HasDefinitionPart,
				CoordinateSystemIdRef,
				HasRelationshipPart,
			};
			/// <summary>
			/// <inheritdoc cref="CategoryProperty" path="/summary" /><br/>
			/// <remarks>Original Name: Category</remarks>
			/// </summary>
			public CategoryProperty Category { get; } = new CategoryProperty();
			/// <summary>
			/// specifies the kind of information provided by a data item.
			/// </summary>
			public sealed class CategoryProperty : IProperty
			{
				/// <summary>
				/// <inheritdoc />
				/// <remarks>
				/// <list type="bullet">
				/// <item>Original Type: _19_0_3_91b028d_1579277872728_249968_3735</item>
				/// <item>Type: CategoryEnumMetaClass</item>
				/// <item>Namespace: Mtconnect.DataTypes</item>
				/// </list>
				/// </remarks>
				/// </summary>
				public System.Type Type => typeof(Mtconnect.DataTypes.CategoryEnumMetaClass);
				
				/// <inheritdoc />
				public string Name => "category";
				
				/// <inheritdoc />
				public string Summary => @"/// information reported about a piece of equipment.";

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
			/// <inheritdoc cref="CompositionIdProperty" path="/summary" /><br/>
			/// <remarks>Original Name: CompositionId</remarks>
			/// </summary>
			public CompositionIdProperty CompositionId { get; } = new CompositionIdProperty();
			/// <summary>
			/// identifier attribute of the <see cref="Composition">Composition</see> that the reported data is most closely associated.
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
				public string Summary => @"/// information reported about a piece of equipment.";

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
			/// <inheritdoc cref="CoordinateSystemProperty" path="/summary" /><br/>
			/// <remarks>Original Name: CoordinateSystem</remarks>
			/// </summary>
			public CoordinateSystemProperty CoordinateSystem { get; } = new CoordinateSystemProperty();
			/// <summary>
			/// for measured values relative to a coordinate system like <see cref="Position">Position</see>, the coordinate system used may be reported.  <b>DEPRECATED</b> in <i>Version 2.0</i>s. Replaced by <see cref="Component::coordinateSystemIdRef" />. 
			/// </summary>
			public sealed class CoordinateSystemProperty : IProperty
			{
				/// <summary>
				/// <inheritdoc />
				/// <remarks>
				/// <list type="bullet">
				/// <item>Original Type: EAID_6B22B6F6_7073_4fa7_961B_B05AD4C7EF81</item>
				/// <item>Type: CoordinateSystemEnumMetaClass</item>
				/// <item>Namespace: Mtconnect.DataTypes</item>
				/// </list>
				/// </remarks>
				/// </summary>
				public System.Type Type => typeof(Mtconnect.DataTypes.CoordinateSystemEnumMetaClass);
				
				/// <inheritdoc />
				public string Name => "coordinateSystem";
				
				/// <inheritdoc />
				public string Summary => @"/// information reported about a piece of equipment.";

				/// <inheritdoc />
				public string AccessModifier => "public";
				
				/// <inheritdoc />
				public string Modifier => "";
				
				/// <inheritdoc />
				public string NormativeVersion => "1.0";
				
				/// <inheritdoc />
				public string DeprecatedVersion => "2.0";
				
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
			/// <inheritdoc cref="DiscreteProperty" path="/summary" /><br/>
			/// <remarks>Original Name: Discrete</remarks>
			/// </summary>
			public DiscreteProperty Discrete { get; } = new DiscreteProperty();
			/// <summary>
			/// indication signifying whether each value reported for the <i>Observation</i> is significant and whether duplicate values are to be suppressed.  If a value is not defined for <see cref="DataItem::discrete" />, the default value <b>MUST</b> be <c>false</c>.
			/// </summary>
			public sealed class DiscreteProperty : IProperty
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
				public string Name => "discrete";
				
				/// <inheritdoc />
				public string Summary => @"/// information reported about a piece of equipment.";

				/// <inheritdoc />
				public string AccessModifier => "public";
				
				/// <inheritdoc />
				public string Modifier => "";
				
				/// <inheritdoc />
				public string NormativeVersion => "1.5";
				
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
			/// <inheritdoc cref="IdProperty" path="/summary" /><br/>
			/// <remarks>Original Name: Id</remarks>
			/// </summary>
			public IdProperty Id { get; } = new IdProperty();
			/// <summary>
			/// unique identifier for this data item.
			/// </summary>
			public sealed class IdProperty : IProperty
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
				public string Name => "id";
				
				/// <inheritdoc />
				public string Summary => @"/// information reported about a piece of equipment.";

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
			/// <inheritdoc cref="NameProperty" path="/summary" /><br/>
			/// <remarks>Original Name: Name</remarks>
			/// </summary>
			public NameProperty Name { get; } = new NameProperty();
			/// <summary>
			/// name of the data item.
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
				public string Summary => @"/// information reported about a piece of equipment.";

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
			/// <inheritdoc cref="NativeScaleProperty" path="/summary" /><br/>
			/// <remarks>Original Name: NativeScale</remarks>
			/// </summary>
			public NativeScaleProperty NativeScale { get; } = new NativeScaleProperty();
			/// <summary>
			/// used to convert the reported value to represent the original measured value.
			/// </summary>
			public sealed class NativeScaleProperty : IProperty
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
				public string Name => "nativeScale";
				
				/// <inheritdoc />
				public string Summary => @"/// information reported about a piece of equipment.";

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
			/// <inheritdoc cref="NativeUnitsProperty" path="/summary" /><br/>
			/// <remarks>Original Name: NativeUnits</remarks>
			/// </summary>
			public NativeUnitsProperty NativeUnits { get; } = new NativeUnitsProperty();
			/// <summary>
			/// native units of measurement for the reported value of the data item.
			/// </summary>
			public sealed class NativeUnitsProperty : IProperty
			{
				/// <summary>
				/// <inheritdoc />
				/// <remarks>
				/// <list type="bullet">
				/// <item>Original Type: EAID_678122A4_E8FD_4243_8427_6B7E0E78D5F5</item>
				/// <item>Type: NativeUnitEnumMetaClass</item>
				/// <item>Namespace: Mtconnect.DataTypes</item>
				/// </list>
				/// </remarks>
				/// </summary>
				public System.Type Type => typeof(Mtconnect.DataTypes.NativeUnitEnumMetaClass);
				
				/// <inheritdoc />
				public string Name => "nativeUnits";
				
				/// <inheritdoc />
				public string Summary => @"/// information reported about a piece of equipment.";

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
			/// <inheritdoc cref="SampleRateProperty" path="/summary" /><br/>
			/// <remarks>Original Name: SampleRate</remarks>
			/// </summary>
			public SampleRateProperty SampleRate { get; } = new SampleRateProperty();
			/// <summary>
			/// rate at which successive samples of a data item are recorded by a piece of equipment.
			/// </summary>
			public sealed class SampleRateProperty : IProperty
			{
				/// <summary>
				/// <inheritdoc />
				/// <remarks>
				/// <list type="bullet">
				/// <item>Original Type: _19_0_3_91b028d_1579272506322_914606_702</item>
				/// <item>Type: Single</item>
				/// <item>Namespace: </item>
				/// </list>
				/// </remarks>
				/// </summary>
				public System.Type Type => typeof(Single);
				
				/// <inheritdoc />
				public string Name => "sampleRate";
				
				/// <inheritdoc />
				public string Summary => @"/// information reported about a piece of equipment.";

				/// <inheritdoc />
				public string AccessModifier => "public";
				
				/// <inheritdoc />
				public string Modifier => "";
				
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
			/// <inheritdoc cref="SignificantDigitsProperty" path="/summary" /><br/>
			/// <remarks>Original Name: SignificantDigits</remarks>
			/// </summary>
			public SignificantDigitsProperty SignificantDigits { get; } = new SignificantDigitsProperty();
			/// <summary>
			/// number of significant digits in the reported value.
			/// </summary>
			public sealed class SignificantDigitsProperty : IProperty
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
				public string Name => "significantDigits";
				
				/// <inheritdoc />
				public string Summary => @"/// information reported about a piece of equipment.";

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
			/// <inheritdoc cref="StatisticProperty" path="/summary" /><br/>
			/// <remarks>Original Name: Statistic</remarks>
			/// </summary>
			public StatisticProperty Statistic { get; } = new StatisticProperty();
			/// <summary>
			/// type of statistical calculation performed on a series of data samples to provide the reported data value.
			/// </summary>
			public sealed class StatisticProperty : IProperty
			{
				/// <summary>
				/// <inheritdoc />
				/// <remarks>
				/// <list type="bullet">
				/// <item>Original Type: EAID_51F1600E_2F14_4045_86C0_42B336850079</item>
				/// <item>Type: StatisticEnumMetaClass</item>
				/// <item>Namespace: Mtconnect.DataTypes</item>
				/// </list>
				/// </remarks>
				/// </summary>
				public System.Type Type => typeof(Mtconnect.DataTypes.StatisticEnumMetaClass);
				
				/// <inheritdoc />
				public string Name => "statistic";
				
				/// <inheritdoc />
				public string Summary => @"/// information reported about a piece of equipment.";

				/// <inheritdoc />
				public string AccessModifier => "public";
				
				/// <inheritdoc />
				public string Modifier => "";
				
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
			/// <inheritdoc cref="SubTypeProperty" path="/summary" /><br/>
			/// <remarks>Original Name: SubType</remarks>
			/// </summary>
			public SubTypeProperty SubType { get; } = new SubTypeProperty();
			/// <summary>
			/// sub-categorization of the <see cref="DataItem::type" />.
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
				public string Summary => @"/// information reported about a piece of equipment.";

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
			/// <inheritdoc cref="TypeProperty" path="/summary" /><br/>
			/// <remarks>Original Name: Type</remarks>
			/// </summary>
			public TypeProperty Type { get; } = new TypeProperty();
			/// <summary>
			/// type of data being measured. See <see cref="DataItem Types">DataItem Types</see>.
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
				public string Summary => @"/// information reported about a piece of equipment.";

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
			/// <inheritdoc cref="UnitsProperty" path="/summary" /><br/>
			/// <remarks>Original Name: Units</remarks>
			/// </summary>
			public UnitsProperty Units { get; } = new UnitsProperty();
			/// <summary>
			/// unit of measurement for the reported value of the data item.
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
				public string Summary => @"/// information reported about a piece of equipment.";

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
			/// <inheritdoc cref="IsObservedByPartProperty" path="/summary" /><br/>
			/// <remarks>Original Name: IsObservedBy</remarks>
			/// </summary>
			public IsObservedByPartProperty IsObservedByPart { get; } = new IsObservedByPartProperty();
			public sealed class IsObservedByPartProperty : IProperty
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
				public string Name => "isObservedBy";
				
				/// <inheritdoc />
				public string Summary => @"/// information reported about a piece of equipment.";

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
				public string Association => "DataItems";

				// Note: DefaultValue.Name
				/// <inheritdoc />
				public string DefaultValue => "";
			}
			/// <summary>
			/// <inheritdoc cref="RepresentationProperty" path="/summary" /><br/>
			/// <remarks>Original Name: Representation</remarks>
			/// </summary>
			public RepresentationProperty Representation { get; } = new RepresentationProperty();
			/// <summary>
			/// description of a means to interpret data consisting of multiple data points or samples reported as a single value.    If <see cref="DataItem::representation" /> is not specified, it <b>MUST</b> be determined to be <c>VALUE</c>. 
			/// </summary>
			public sealed class RepresentationProperty : IProperty
			{
				/// <summary>
				/// <inheritdoc />
				/// <remarks>
				/// <list type="bullet">
				/// <item>Original Type: EAID_67CD6E1B_53E3_45c1_B84F_B0732F79528D</item>
				/// <item>Type: RepresentationEnumMetaClass</item>
				/// <item>Namespace: Mtconnect.DataTypes</item>
				/// </list>
				/// </remarks>
				/// </summary>
				public System.Type Type => typeof(Mtconnect.DataTypes.RepresentationEnumMetaClass);
				
				/// <inheritdoc />
				public string Name => "representation";
				
				/// <inheritdoc />
				public string Summary => @"/// information reported about a piece of equipment.";

				/// <inheritdoc />
				public string AccessModifier => "public";
				
				/// <inheritdoc />
				public string Modifier => "";
				
				/// <inheritdoc />
				public string NormativeVersion => "1.2";
				
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
			/// <inheritdoc cref="HasSourcePartProperty" path="/summary" /><br/>
			/// <remarks>Original Name: HasSource</remarks>
			/// </summary>
			public HasSourcePartProperty HasSourcePart { get; } = new HasSourcePartProperty();
			public sealed class HasSourcePartProperty : IProperty
			{
				/// <summary>
				/// <inheritdoc />
				/// <remarks>
				/// <list type="bullet">
				/// <item>Original Type: EAID_A2837EAA_7D27_45c0_B365_BC308844F978</item>
				/// <item>Type: SourceClass</item>
				/// <item>Namespace: Mtconnect.DeviceInformationModel.DataItems.PropertiesOfDataItem</item>
				/// </list>
				/// </remarks>
				/// </summary>
				public System.Type Type => typeof(Mtconnect.DeviceInformationModel.DataItems.PropertiesOfDataItem.SourceClass);
				
				/// <inheritdoc />
				public string Name => "hasSource";
				
				/// <inheritdoc />
				public string Summary => @"/// information reported about a piece of equipment.";

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
				public string Association => "Source";

				// Note: DefaultValue.Name
				/// <inheritdoc />
				public string DefaultValue => "";
			}
			/// <summary>
			/// <inheritdoc cref="HasConstraintPartProperty" path="/summary" /><br/>
			/// <remarks>Original Name: HasConstraint</remarks>
			/// </summary>
			public HasConstraintPartProperty HasConstraintPart { get; } = new HasConstraintPartProperty();
			public sealed class HasConstraintPartProperty : IProperty
			{
				/// <summary>
				/// <inheritdoc />
				/// <remarks>
				/// <list type="bullet">
				/// <item>Original Type: EAID_E6F955EB_46CA_4c72_B547_8F4465A9620A</item>
				/// <item>Type: ConstraintsClass</item>
				/// <item>Namespace: Mtconnect.DeviceInformationModel.DataItems.PropertiesOfDataItem</item>
				/// </list>
				/// </remarks>
				/// </summary>
				public System.Type Type => typeof(Mtconnect.DeviceInformationModel.DataItems.PropertiesOfDataItem.ConstraintsClass);
				
				/// <inheritdoc />
				public string Name => "hasConstraint";
				
				/// <inheritdoc />
				public string Summary => @"/// information reported about a piece of equipment.";

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
				public string Association => "Constraints";

				// Note: DefaultValue.Name
				/// <inheritdoc />
				public string DefaultValue => "";
			}
			/// <summary>
			/// <inheritdoc cref="HasFilterPartProperty" path="/summary" /><br/>
			/// <remarks>Original Name: HasFilter</remarks>
			/// </summary>
			public HasFilterPartProperty HasFilterPart { get; } = new HasFilterPartProperty();
			public sealed class HasFilterPartProperty : IProperty
			{
				/// <summary>
				/// <inheritdoc />
				/// <remarks>
				/// <list type="bullet">
				/// <item>Original Type: EAID_8A5219C3_747D_4904_A58A_A312D13DAEE9</item>
				/// <item>Type: FilterClass</item>
				/// <item>Namespace: Mtconnect.DeviceInformationModel.DataItems.PropertiesOfDataItem</item>
				/// </list>
				/// </remarks>
				/// </summary>
				public System.Type Type => typeof(Mtconnect.DeviceInformationModel.DataItems.PropertiesOfDataItem.FilterClass);
				
				/// <inheritdoc />
				public string Name => "hasFilter";
				
				/// <inheritdoc />
				public string Summary => @"/// information reported about a piece of equipment.";

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
				public string Extension => "";
				
				/// <inheritdoc />
				public string Association => "Filters";

				// Note: DefaultValue.Name
				/// <inheritdoc />
				public string DefaultValue => "";
			}
			/// <summary>
			/// <inheritdoc cref="HasInitialValuePartProperty" path="/summary" /><br/>
			/// <remarks>Original Name: HasInitialValue</remarks>
			/// </summary>
			public HasInitialValuePartProperty HasInitialValuePart { get; } = new HasInitialValuePartProperty();
			public sealed class HasInitialValuePartProperty : IProperty
			{
				/// <summary>
				/// <inheritdoc />
				/// <remarks>
				/// <list type="bullet">
				/// <item>Original Type: EAID_3F705CFA_0BDC_4dc1_91C8_0A38B91DD3E6</item>
				/// <item>Type: InitialValueClass</item>
				/// <item>Namespace: Mtconnect.DeviceInformationModel.DataItems.PropertiesOfDataItem</item>
				/// </list>
				/// </remarks>
				/// </summary>
				public System.Type Type => typeof(Mtconnect.DeviceInformationModel.DataItems.PropertiesOfDataItem.InitialValueClass);
				
				/// <inheritdoc />
				public string Name => "hasInitialValue";
				
				/// <inheritdoc />
				public string Summary => @"/// information reported about a piece of equipment.";

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
				public string Association => "InitialValue";

				// Note: DefaultValue.Name
				/// <inheritdoc />
				public string DefaultValue => "";
			}
			/// <summary>
			/// <inheritdoc cref="HasResetTriggerPartProperty" path="/summary" /><br/>
			/// <remarks>Original Name: HasResetTrigger</remarks>
			/// </summary>
			public HasResetTriggerPartProperty HasResetTriggerPart { get; } = new HasResetTriggerPartProperty();
			public sealed class HasResetTriggerPartProperty : IProperty
			{
				/// <summary>
				/// <inheritdoc />
				/// <remarks>
				/// <list type="bullet">
				/// <item>Original Type: EAID_3F56D161_E1BD_4fa1_8D7A_1C9C2E15D303</item>
				/// <item>Type: ResetTriggerClass</item>
				/// <item>Namespace: Mtconnect.DeviceInformationModel.DataItems.PropertiesOfDataItem</item>
				/// </list>
				/// </remarks>
				/// </summary>
				public System.Type Type => typeof(Mtconnect.DeviceInformationModel.DataItems.PropertiesOfDataItem.ResetTriggerClass);
				
				/// <inheritdoc />
				public string Name => "hasResetTrigger";
				
				/// <inheritdoc />
				public string Summary => @"/// information reported about a piece of equipment.";

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
				public string Association => "ResetTrigger";

				// Note: DefaultValue.Name
				/// <inheritdoc />
				public string DefaultValue => "";
			}
			/// <summary>
			/// <inheritdoc cref="HasObservationPartProperty" path="/summary" /><br/>
			/// <remarks>Original Name: HasObservation</remarks>
			/// </summary>
			public HasObservationPartProperty HasObservationPart { get; } = new HasObservationPartProperty();
			public sealed class HasObservationPartProperty : IProperty
			{
				/// <summary>
				/// <inheritdoc />
				/// <remarks>
				/// <list type="bullet">
				/// <item>Original Type: _19_0_3_45f01b9_1579566531115_47734_25731</item>
				/// <item>Type: ObservationGeneralization</item>
				/// <item>Namespace: Mtconnect.ObservationInformationModel</item>
				/// </list>
				/// </remarks>
				/// </summary>
				public System.Type Type => typeof(Mtconnect.ObservationInformationModel.ObservationGeneralization);
				
				/// <inheritdoc />
				public string Name => "hasObservation";
				
				/// <inheritdoc />
				public string Summary => @"/// information reported about a piece of equipment.";

				/// <inheritdoc />
				public string AccessModifier => "public";
				
				/// <inheritdoc />
				public string Modifier => "";
				
				/// <inheritdoc />
				public string NormativeVersion => "";
				
				/// <inheritdoc />
				public string DeprecatedVersion => "";
				
				/// <inheritdoc />
				public string Aggregation => "shared";

				// Note: Extension.Extender
				/// <inheritdoc />
				public string Extension => "";
				
				/// <inheritdoc />
				public string Association => "Observations";

				// Note: DefaultValue.Name
				/// <inheritdoc />
				public string DefaultValue => "";
			}
			/// <summary>
			/// <inheritdoc cref="HasDefinitionPartProperty" path="/summary" /><br/>
			/// <remarks>Original Name: HasDefinition</remarks>
			/// </summary>
			public HasDefinitionPartProperty HasDefinitionPart { get; } = new HasDefinitionPartProperty();
			public sealed class HasDefinitionPartProperty : IProperty
			{
				/// <summary>
				/// <inheritdoc />
				/// <remarks>
				/// <list type="bullet">
				/// <item>Original Type: _19_0_3_45f01b9_1581433165009_756087_158</item>
				/// <item>Type: DefinitionClass</item>
				/// <item>Namespace: Mtconnect.DeviceInformationModel.DataItems.PropertiesOfDataItem</item>
				/// </list>
				/// </remarks>
				/// </summary>
				public System.Type Type => typeof(Mtconnect.DeviceInformationModel.DataItems.PropertiesOfDataItem.DefinitionClass);
				
				/// <inheritdoc />
				public string Name => "hasDefinition";
				
				/// <inheritdoc />
				public string Summary => @"/// information reported about a piece of equipment.";

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
				public string Association => "Definition";

				// Note: DefaultValue.Name
				/// <inheritdoc />
				public string DefaultValue => "";
			}
			/// <summary>
			/// <inheritdoc cref="CoordinateSystemIdRefProperty" path="/summary" /><br/>
			/// <remarks>Original Name: CoordinateSystemIdRef</remarks>
			/// </summary>
			public CoordinateSystemIdRefProperty CoordinateSystemIdRef { get; } = new CoordinateSystemIdRefProperty();
			/// <summary>
			/// associated <see cref="CoordinateSystem">CoordinateSystem</see> context for the <see cref="DataItem">DataItem</see>.
			/// </summary>
			public sealed class CoordinateSystemIdRefProperty : IProperty
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
				public string Name => "coordinateSystemIdRef";
				
				/// <inheritdoc />
				public string Summary => @"/// information reported about a piece of equipment.";

				/// <inheritdoc />
				public string AccessModifier => "public";
				
				/// <inheritdoc />
				public string Modifier => "";
				
				/// <inheritdoc />
				public string NormativeVersion => "1.5";
				
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
			/// <inheritdoc cref="HasRelationshipPartProperty" path="/summary" /><br/>
			/// <remarks>Original Name: HasRelationship</remarks>
			/// </summary>
			public HasRelationshipPartProperty HasRelationshipPart { get; } = new HasRelationshipPartProperty();
			public sealed class HasRelationshipPartProperty : IProperty
			{
				/// <summary>
				/// <inheritdoc />
				/// <remarks>
				/// <list type="bullet">
				/// <item>Original Type: _19_0_3_68e0225_1658942187874_859516_1061</item>
				/// <item>Type: AbstractDataItemRelationshipClass</item>
				/// <item>Namespace: Mtconnect.DeviceInformationModel.DataItems.PropertiesOfDataItem.RelationshipTypesForDataItem</item>
				/// </list>
				/// </remarks>
				/// </summary>
				public System.Type Type => typeof(Mtconnect.DeviceInformationModel.DataItems.PropertiesOfDataItem.RelationshipTypesForDataItem.AbstractDataItemRelationshipClass);
				
				/// <inheritdoc />
				public string Name => "hasRelationship";
				
				/// <inheritdoc />
				public string Summary => @"/// information reported about a piece of equipment.";

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
				public string Extension => "";
				
				/// <inheritdoc />
				public string Association => "Relationships";

				// Note: DefaultValue.Name
				/// <inheritdoc />
				public string DefaultValue => "";
			}
		};

		# region Rules
		/// <summary>
		/// Dataitem1
		/// </summary>
		/// <remarks>Specification Language: <c>Unspecified</c></remarks>
		public string Dataitem1 => @"id->size() = 1 and
(self.oclAsType(DataItems::""DataItem Types""::Event).type->size() = 1 or
self.oclAsType(DataItems::""DataItem Types""::Sample).type->size() = 1 or
self.oclAsType(DataItems::""DataItem Types""::Condition).type->size() = 1
) and
(self.oclAsType(DataItems::""DataItem Types""::Event).category->size() = 1 or
self.oclAsType(DataItems::""DataItem Types""::Sample).category->size() = 1 or
self.oclAsType(DataItems::""DataItem Types""::Condition).category->size() = 1
)";
		/*
		id->size() = 1 and
		(self.oclAsType(DataItems::"DataItem Types"::Event).type->size() = 1 or
		self.oclAsType(DataItems::"DataItem Types"::Sample).type->size() = 1 or
		self.oclAsType(DataItems::"DataItem Types"::Condition).type->size() = 1
		) and
		(self.oclAsType(DataItems::"DataItem Types"::Event).category->size() = 1 or
		self.oclAsType(DataItems::"DataItem Types"::Sample).category->size() = 1 or
		self.oclAsType(DataItems::"DataItem Types"::Condition).category->size() = 1
		)
		*/
		/// <summary>
		/// Dataitem2
		/// </summary>
		/// <remarks>Specification Language: <c>Unspecified</c></remarks>
		public string Dataitem2 => @"self.oclAsType(DataItems::""DataItem Types""::Event).category = DataTypes::CategoryEnum::EVENT or 
self.oclAsType(DataItems::""DataItem Types""::Sample).category =  DataTypes::CategoryEnum::SAMPLE or
self.oclAsType(DataItems::""DataItem Types""::Condition).category =  DataTypes::CategoryEnum::CONDITION";
		/*
		self.oclAsType(DataItems::"DataItem Types"::Event).category = DataTypes::CategoryEnum::EVENT or 
		self.oclAsType(DataItems::"DataItem Types"::Sample).category =  DataTypes::CategoryEnum::SAMPLE or
		self.oclAsType(DataItems::"DataItem Types"::Condition).category =  DataTypes::CategoryEnum::CONDITION
		*/
		# endregion
	}
}