
using System;
using System.CodeDom.Compiler;

using Mtconnect.DataTypes;
using Mtconnect.Glossary.MTConnectTerms;
using Mtconnect.AgentArchitecture;
using Mtconnect.DeviceInformationModel.DataItems.PropertiesOfDataItem;
using Mtconnect.DeviceInformationModel.Components.ComponentTypes;
using Mtconnect.ObservationInformationModel;
using Mtconnect.DeviceInformationModel.DataItems.PropertiesOfDataItem.RelationshipTypesForDataItem;

namespace Mtconnect.DeviceInformationModel.DataItems
{
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "1.0.15.3")]
	public sealed class DataItemClass
	{
		/// <inheritdoc cref="Class.ReferenceId" />
		public string ReferenceId => "EAID_002C94B7_1257_49be_8EAA_CE7FCD7AFF8A";
		
		/// <inheritdoc cref="Class.Name" />
		public string Name => "DataItem";
		
		/// <inheritdoc cref="Class.AccessModifier" />
		public string AccessModifier => "public";
				
		/// <inheritdoc cref="Class.Modifier" />
		public string Modifier => "";
				
		/// <inheritdoc cref="Class.NormativeVersion" />
		public string NormativeVersion => "MtconnectVersions.V_1_0_1";
				
		/// <inheritdoc cref="Class.DeprecatedVersion" />
		public string DeprecatedVersion => "";

		public string Generalization => "";

		public DataItemProperties Properties { get; } = new DataItemProperties();
		public sealed class DataItemProperties
		{
		
		
			/// <remarks>Original Name: Category</remarks>
			public CategoryProperty Category { get; } = new CategoryProperty();
			public sealed class CategoryProperty
			{
				/// <inheritdoc cref="Property.Type" />
				/// Original Type: _19_0_3_91b028d_1579277872728_249968_3735
				public Type Type => typeof(CategoryEnum);
				
				/// <inheritdoc cref="Property.Name" />
				public string Name => "Category";
				
				/// <inheritdoc cref="Property.AccessModifier" />
				public string AccessModifier => "public";
				
				/// <inheritdoc cref="Property.Modifier" />
				public string Modifier => "";
				
				/// <inheritdoc cref="Property.NormativeVersion" />
				public string NormativeVersion => "MtconnectVersions.V_1_0_1";
				
				/// <inheritdoc cref="Property.DeprecatedVersion" />
				public string DeprecatedVersion => "";
				
				public string Aggregation => "";

				// Note: Extension.Extender
				public string Extension => "MagicDraw UML 19.0";

				public string Association => "";

				// Note: DefaultValue.Name
				public string DefaultValue => "";

				// TODO: Add Summary
			}
		
		
			/// <remarks>Original Name: CompositionId</remarks>
			public CompositionIdProperty CompositionId { get; } = new CompositionIdProperty();
			public sealed class CompositionIdProperty
			{
				/// <inheritdoc cref="Property.Type" />
				/// Original Type: _19_0_3_91b028d_1579272245466_691733_672
				public Type Type => typeof(String);
				
				/// <inheritdoc cref="Property.Name" />
				public string Name => "CompositionId";
				
				/// <inheritdoc cref="Property.AccessModifier" />
				public string AccessModifier => "public";
				
				/// <inheritdoc cref="Property.Modifier" />
				public string Modifier => "";
				
				/// <inheritdoc cref="Property.NormativeVersion" />
				public string NormativeVersion => "MtconnectVersions.V_1_4_0";
				
				/// <inheritdoc cref="Property.DeprecatedVersion" />
				public string DeprecatedVersion => "";
				
				public string Aggregation => "";

				// Note: Extension.Extender
				public string Extension => "MagicDraw UML 19.0";

				public string Association => "";

				// Note: DefaultValue.Name
				public string DefaultValue => "";

				// TODO: Add Summary
			}
		
		
			/// <remarks>Original Name: CoordinateSystem</remarks>
			public CoordinateSystemProperty CoordinateSystem { get; } = new CoordinateSystemProperty();
			public sealed class CoordinateSystemProperty
			{
				/// <inheritdoc cref="Property.Type" />
				/// Original Type: EAID_6B22B6F6_7073_4fa7_961B_B05AD4C7EF81
				public Type Type => typeof(CoordinateSystemEnum);
				
				/// <inheritdoc cref="Property.Name" />
				public string Name => "CoordinateSystem";
				
				/// <inheritdoc cref="Property.AccessModifier" />
				public string AccessModifier => "public";
				
				/// <inheritdoc cref="Property.Modifier" />
				public string Modifier => "";
				
				/// <inheritdoc cref="Property.NormativeVersion" />
				public string NormativeVersion => "MtconnectVersions.V_1_0_1";
				
				/// <inheritdoc cref="Property.DeprecatedVersion" />
				public string DeprecatedVersion => "MtconnectVersions.V_2_0_0";
				
				public string Aggregation => "";

				// Note: Extension.Extender
				public string Extension => "MagicDraw UML 19.0";

				public string Association => "";

				// Note: DefaultValue.Name
				public string DefaultValue => "";

				// TODO: Add Summary
			}
		
		
			/// <remarks>Original Name: Discrete</remarks>
			public DiscreteProperty Discrete { get; } = new DiscreteProperty();
			public sealed class DiscreteProperty
			{
				/// <inheritdoc cref="Property.Type" />
				/// Original Type: _19_0_3_91b028d_1579278876899_683310_3821
				public Type Type => typeof(Boolean);
				
				/// <inheritdoc cref="Property.Name" />
				public string Name => "Discrete";
				
				/// <inheritdoc cref="Property.AccessModifier" />
				public string AccessModifier => "public";
				
				/// <inheritdoc cref="Property.Modifier" />
				public string Modifier => "";
				
				/// <inheritdoc cref="Property.NormativeVersion" />
				public string NormativeVersion => "MtconnectVersions.V_1_5_0";
				
				/// <inheritdoc cref="Property.DeprecatedVersion" />
				public string DeprecatedVersion => "";
				
				public string Aggregation => "";

				// Note: Extension.Extender
				public string Extension => "MagicDraw UML 19.0";

				public string Association => "";

				// Note: DefaultValue.Name
				public string DefaultValue => "";

				// TODO: Add Summary
			}
		
		
			/// <remarks>Original Name: Id</remarks>
			public IdProperty Id { get; } = new IdProperty();
			public sealed class IdProperty
			{
				/// <inheritdoc cref="Property.Type" />
				/// Original Type: _19_0_3_91b028d_1579272245466_691733_672
				public Type Type => typeof(String);
				
				/// <inheritdoc cref="Property.Name" />
				public string Name => "Id";
				
				/// <inheritdoc cref="Property.AccessModifier" />
				public string AccessModifier => "public";
				
				/// <inheritdoc cref="Property.Modifier" />
				public string Modifier => "";
				
				/// <inheritdoc cref="Property.NormativeVersion" />
				public string NormativeVersion => "MtconnectVersions.V_1_0_1";
				
				/// <inheritdoc cref="Property.DeprecatedVersion" />
				public string DeprecatedVersion => "";
				
				public string Aggregation => "";

				// Note: Extension.Extender
				public string Extension => "MagicDraw UML 19.0";

				public string Association => "";

				// Note: DefaultValue.Name
				public string DefaultValue => "";

				// TODO: Add Summary
			}
		
		
			/// <remarks>Original Name: Name</remarks>
			public NameProperty Name { get; } = new NameProperty();
			public sealed class NameProperty
			{
				/// <inheritdoc cref="Property.Type" />
				/// Original Type: _19_0_3_91b028d_1579272360416_763325_681
				public Type Type => typeof(String);
				
				/// <inheritdoc cref="Property.Name" />
				public string Name => "Name";
				
				/// <inheritdoc cref="Property.AccessModifier" />
				public string AccessModifier => "public";
				
				/// <inheritdoc cref="Property.Modifier" />
				public string Modifier => "";
				
				/// <inheritdoc cref="Property.NormativeVersion" />
				public string NormativeVersion => "MtconnectVersions.V_1_0_1";
				
				/// <inheritdoc cref="Property.DeprecatedVersion" />
				public string DeprecatedVersion => "";
				
				public string Aggregation => "";

				// Note: Extension.Extender
				public string Extension => "MagicDraw UML 19.0";

				public string Association => "";

				// Note: DefaultValue.Name
				public string DefaultValue => "";

				// TODO: Add Summary
			}
		
		
			/// <remarks>Original Name: NativeScale</remarks>
			public NativeScaleProperty NativeScale { get; } = new NativeScaleProperty();
			public sealed class NativeScaleProperty
			{
				/// <inheritdoc cref="Property.Type" />
				/// Original Type: _19_0_3_91b028d_1579272271512_537408_674
				public Type Type => typeof(Int32);
				
				/// <inheritdoc cref="Property.Name" />
				public string Name => "NativeScale";
				
				/// <inheritdoc cref="Property.AccessModifier" />
				public string AccessModifier => "public";
				
				/// <inheritdoc cref="Property.Modifier" />
				public string Modifier => "";
				
				/// <inheritdoc cref="Property.NormativeVersion" />
				public string NormativeVersion => "MtconnectVersions.V_1_0_1";
				
				/// <inheritdoc cref="Property.DeprecatedVersion" />
				public string DeprecatedVersion => "";
				
				public string Aggregation => "";

				// Note: Extension.Extender
				public string Extension => "MagicDraw UML 19.0";

				public string Association => "";

				// Note: DefaultValue.Name
				public string DefaultValue => "";

				// TODO: Add Summary
			}
		
		
			/// <remarks>Original Name: NativeUnits</remarks>
			public NativeUnitsProperty NativeUnits { get; } = new NativeUnitsProperty();
			public sealed class NativeUnitsProperty
			{
				/// <inheritdoc cref="Property.Type" />
				/// Original Type: EAID_678122A4_E8FD_4243_8427_6B7E0E78D5F5
				public Type Type => typeof(NativeUnitEnum);
				
				/// <inheritdoc cref="Property.Name" />
				public string Name => "NativeUnits";
				
				/// <inheritdoc cref="Property.AccessModifier" />
				public string AccessModifier => "public";
				
				/// <inheritdoc cref="Property.Modifier" />
				public string Modifier => "";
				
				/// <inheritdoc cref="Property.NormativeVersion" />
				public string NormativeVersion => "MtconnectVersions.V_1_0_1";
				
				/// <inheritdoc cref="Property.DeprecatedVersion" />
				public string DeprecatedVersion => "";
				
				public string Aggregation => "";

				// Note: Extension.Extender
				public string Extension => "MagicDraw UML 19.0";

				public string Association => "";

				// Note: DefaultValue.Name
				public string DefaultValue => "";

				// TODO: Add Summary
			}
		
		
			/// <remarks>Original Name: SampleRate</remarks>
			public SampleRateProperty SampleRate { get; } = new SampleRateProperty();
			public sealed class SampleRateProperty
			{
				/// <inheritdoc cref="Property.Type" />
				/// Original Type: _19_0_3_91b028d_1579272506322_914606_702
				public Type Type => typeof(Single);
				
				/// <inheritdoc cref="Property.Name" />
				public string Name => "SampleRate";
				
				/// <inheritdoc cref="Property.AccessModifier" />
				public string AccessModifier => "public";
				
				/// <inheritdoc cref="Property.Modifier" />
				public string Modifier => "";
				
				/// <inheritdoc cref="Property.NormativeVersion" />
				public string NormativeVersion => "MtconnectVersions.V_1_2_0";
				
				/// <inheritdoc cref="Property.DeprecatedVersion" />
				public string DeprecatedVersion => "";
				
				public string Aggregation => "";

				// Note: Extension.Extender
				public string Extension => "MagicDraw UML 19.0";

				public string Association => "";

				// Note: DefaultValue.Name
				public string DefaultValue => "";

				// TODO: Add Summary
			}
		
		
			/// <remarks>Original Name: SignificantDigits</remarks>
			public SignificantDigitsProperty SignificantDigits { get; } = new SignificantDigitsProperty();
			public sealed class SignificantDigitsProperty
			{
				/// <inheritdoc cref="Property.Type" />
				/// Original Type: _19_0_3_91b028d_1579272271512_537408_674
				public Type Type => typeof(Int32);
				
				/// <inheritdoc cref="Property.Name" />
				public string Name => "SignificantDigits";
				
				/// <inheritdoc cref="Property.AccessModifier" />
				public string AccessModifier => "public";
				
				/// <inheritdoc cref="Property.Modifier" />
				public string Modifier => "";
				
				/// <inheritdoc cref="Property.NormativeVersion" />
				public string NormativeVersion => "MtconnectVersions.V_1_0_1";
				
				/// <inheritdoc cref="Property.DeprecatedVersion" />
				public string DeprecatedVersion => "";
				
				public string Aggregation => "";

				// Note: Extension.Extender
				public string Extension => "MagicDraw UML 19.0";

				public string Association => "";

				// Note: DefaultValue.Name
				public string DefaultValue => "";

				// TODO: Add Summary
			}
		
		
			/// <remarks>Original Name: Statistic</remarks>
			public StatisticProperty Statistic { get; } = new StatisticProperty();
			public sealed class StatisticProperty
			{
				/// <inheritdoc cref="Property.Type" />
				/// Original Type: EAID_51F1600E_2F14_4045_86C0_42B336850079
				public Type Type => typeof(StatisticEnum);
				
				/// <inheritdoc cref="Property.Name" />
				public string Name => "Statistic";
				
				/// <inheritdoc cref="Property.AccessModifier" />
				public string AccessModifier => "public";
				
				/// <inheritdoc cref="Property.Modifier" />
				public string Modifier => "";
				
				/// <inheritdoc cref="Property.NormativeVersion" />
				public string NormativeVersion => "MtconnectVersions.V_1_2_0";
				
				/// <inheritdoc cref="Property.DeprecatedVersion" />
				public string DeprecatedVersion => "";
				
				public string Aggregation => "";

				// Note: Extension.Extender
				public string Extension => "MagicDraw UML 19.0";

				public string Association => "";

				// Note: DefaultValue.Name
				public string DefaultValue => "";

				// TODO: Add Summary
			}
		
		
			/// <remarks>Original Name: SubType</remarks>
			public SubTypeProperty SubType { get; } = new SubTypeProperty();
			public sealed class SubTypeProperty
			{
				/// <inheritdoc cref="Property.Type" />
				/// Original Type: _19_0_3_45f01b9_1579563592155_977172_22064
				public Type Type => typeof(DataItemSubTypeEnum);
				
				/// <inheritdoc cref="Property.Name" />
				public string Name => "SubType";
				
				/// <inheritdoc cref="Property.AccessModifier" />
				public string AccessModifier => "public";
				
				/// <inheritdoc cref="Property.Modifier" />
				public string Modifier => "";
				
				/// <inheritdoc cref="Property.NormativeVersion" />
				public string NormativeVersion => "MtconnectVersions.V_1_0_1";
				
				/// <inheritdoc cref="Property.DeprecatedVersion" />
				public string DeprecatedVersion => "";
				
				public string Aggregation => "";

				// Note: Extension.Extender
				public string Extension => "MagicDraw UML 19.0";

				public string Association => "";

				// Note: DefaultValue.Name
				public string DefaultValue => "";

				// TODO: Add Summary
			}
		
		
			/// <remarks>Original Name: Type</remarks>
			public TypeProperty Type { get; } = new TypeProperty();
			public sealed class TypeProperty
			{
				/// <inheritdoc cref="Property.Type" />
				/// Original Type: _19_0_3_45f01b9_1579563576485_587701_22033
				public Type Type => typeof(DataItemTypeEnum);
				
				/// <inheritdoc cref="Property.Name" />
				public string Name => "Type";
				
				/// <inheritdoc cref="Property.AccessModifier" />
				public string AccessModifier => "public";
				
				/// <inheritdoc cref="Property.Modifier" />
				public string Modifier => "";
				
				/// <inheritdoc cref="Property.NormativeVersion" />
				public string NormativeVersion => "MtconnectVersions.V_1_0_1";
				
				/// <inheritdoc cref="Property.DeprecatedVersion" />
				public string DeprecatedVersion => "";
				
				public string Aggregation => "";

				// Note: Extension.Extender
				public string Extension => "MagicDraw UML 19.0";

				public string Association => "";

				// Note: DefaultValue.Name
				public string DefaultValue => "";

				// TODO: Add Summary
			}
		
		
			/// <remarks>Original Name: Units</remarks>
			public UnitsProperty Units { get; } = new UnitsProperty();
			public sealed class UnitsProperty
			{
				/// <inheritdoc cref="Property.Type" />
				/// Original Type: EAID_8FEC81E4_8E1F_4f45_820B_F9F25DD83F9A
				public Type Type => typeof(UnitEnum);
				
				/// <inheritdoc cref="Property.Name" />
				public string Name => "Units";
				
				/// <inheritdoc cref="Property.AccessModifier" />
				public string AccessModifier => "public";
				
				/// <inheritdoc cref="Property.Modifier" />
				public string Modifier => "";
				
				/// <inheritdoc cref="Property.NormativeVersion" />
				public string NormativeVersion => "MtconnectVersions.V_1_0_1";
				
				/// <inheritdoc cref="Property.DeprecatedVersion" />
				public string DeprecatedVersion => "";
				
				public string Aggregation => "";

				// Note: Extension.Extender
				public string Extension => "MagicDraw UML 19.0";

				public string Association => "";

				// Note: DefaultValue.Name
				public string DefaultValue => "";

				// TODO: Add Summary
			}
		
		
			/// <remarks>Original Name: IsObservedBy</remarks>
			public IsObservedByPartProperty IsObservedByPart { get; } = new IsObservedByPartProperty();
			public sealed class IsObservedByPartProperty
			{
				/// <inheritdoc cref="Property.Type" />
				/// Original Type: EAID_8548C620_467A_4f50_9A22_58D84B7E8779
				public Type Type => typeof(ComponentClass);
				
				/// <inheritdoc cref="Property.Name" />
				public string Name => "IsObservedBy";
				
				/// <inheritdoc cref="Property.AccessModifier" />
				public string AccessModifier => "private";
				
				/// <inheritdoc cref="Property.Modifier" />
				public string Modifier => "";
				
				/// <inheritdoc cref="Property.NormativeVersion" />
				public string NormativeVersion => "";
				
				/// <inheritdoc cref="Property.DeprecatedVersion" />
				public string DeprecatedVersion => "";
				
				public string Aggregation => "";

				// Note: Extension.Extender
				public string Extension => "MagicDraw UML 19.0";

				public string Association => "DataItems";

				// Note: DefaultValue.Name
				public string DefaultValue => "";

				// TODO: Add Summary
			}
		
		
			/// <remarks>Original Name: Representation</remarks>
			public RepresentationProperty Representation { get; } = new RepresentationProperty();
			public sealed class RepresentationProperty
			{
				/// <inheritdoc cref="Property.Type" />
				/// Original Type: EAID_67CD6E1B_53E3_45c1_B84F_B0732F79528D
				public Type Type => typeof(RepresentationEnum);
				
				/// <inheritdoc cref="Property.Name" />
				public string Name => "Representation";
				
				/// <inheritdoc cref="Property.AccessModifier" />
				public string AccessModifier => "public";
				
				/// <inheritdoc cref="Property.Modifier" />
				public string Modifier => "";
				
				/// <inheritdoc cref="Property.NormativeVersion" />
				public string NormativeVersion => "MtconnectVersions.V_1_2_0";
				
				/// <inheritdoc cref="Property.DeprecatedVersion" />
				public string DeprecatedVersion => "";
				
				public string Aggregation => "composite";

				// Note: Extension.Extender
				public string Extension => "MagicDraw UML 19.0";

				public string Association => "";

				// Note: DefaultValue.Name
				public string DefaultValue => "";

				// TODO: Add Summary
			}
		
		
			/// <remarks>Original Name: HasSource</remarks>
			public HasSourcePartProperty HasSourcePart { get; } = new HasSourcePartProperty();
			public sealed class HasSourcePartProperty
			{
				/// <inheritdoc cref="Property.Type" />
				/// Original Type: EAID_A2837EAA_7D27_45c0_B365_BC308844F978
				public Type Type => typeof(SourceClass);
				
				/// <inheritdoc cref="Property.Name" />
				public string Name => "HasSource";
				
				/// <inheritdoc cref="Property.AccessModifier" />
				public string AccessModifier => "public";
				
				/// <inheritdoc cref="Property.Modifier" />
				public string Modifier => "";
				
				/// <inheritdoc cref="Property.NormativeVersion" />
				public string NormativeVersion => "";
				
				/// <inheritdoc cref="Property.DeprecatedVersion" />
				public string DeprecatedVersion => "";
				
				public string Aggregation => "composite";

				// Note: Extension.Extender
				public string Extension => "MagicDraw UML 19.0";

				public string Association => "Source";

				// Note: DefaultValue.Name
				public string DefaultValue => "";

				// TODO: Add Summary
			}
		
		
			/// <remarks>Original Name: HasConstraint</remarks>
			public HasConstraintPartProperty HasConstraintPart { get; } = new HasConstraintPartProperty();
			public sealed class HasConstraintPartProperty
			{
				/// <inheritdoc cref="Property.Type" />
				/// Original Type: EAID_E6F955EB_46CA_4c72_B547_8F4465A9620A
				public Type Type => typeof(ConstraintsClass);
				
				/// <inheritdoc cref="Property.Name" />
				public string Name => "HasConstraint";
				
				/// <inheritdoc cref="Property.AccessModifier" />
				public string AccessModifier => "public";
				
				/// <inheritdoc cref="Property.Modifier" />
				public string Modifier => "";
				
				/// <inheritdoc cref="Property.NormativeVersion" />
				public string NormativeVersion => "";
				
				/// <inheritdoc cref="Property.DeprecatedVersion" />
				public string DeprecatedVersion => "";
				
				public string Aggregation => "composite";

				// Note: Extension.Extender
				public string Extension => "MagicDraw UML 19.0";

				public string Association => "Constraints";

				// Note: DefaultValue.Name
				public string DefaultValue => "";

				// TODO: Add Summary
			}
		
		
			/// <remarks>Original Name: HasFilter</remarks>
			public HasFilterPartProperty HasFilterPart { get; } = new HasFilterPartProperty();
			public sealed class HasFilterPartProperty
			{
				/// <inheritdoc cref="Property.Type" />
				/// Original Type: EAID_8A5219C3_747D_4904_A58A_A312D13DAEE9
				public Type Type => typeof(FilterClass);
				
				/// <inheritdoc cref="Property.Name" />
				public string Name => "HasFilter";
				
				/// <inheritdoc cref="Property.AccessModifier" />
				public string AccessModifier => "public";
				
				/// <inheritdoc cref="Property.Modifier" />
				public string Modifier => "";
				
				/// <inheritdoc cref="Property.NormativeVersion" />
				public string NormativeVersion => "";
				
				/// <inheritdoc cref="Property.DeprecatedVersion" />
				public string DeprecatedVersion => "";
				
				public string Aggregation => "composite";

				// Note: Extension.Extender
				public string Extension => "";

				public string Association => "Filters";

				// Note: DefaultValue.Name
				public string DefaultValue => "";

				// TODO: Add Summary
			}
		
		
			/// <remarks>Original Name: HasInitialValue</remarks>
			public HasInitialValuePartProperty HasInitialValuePart { get; } = new HasInitialValuePartProperty();
			public sealed class HasInitialValuePartProperty
			{
				/// <inheritdoc cref="Property.Type" />
				/// Original Type: EAID_3F705CFA_0BDC_4dc1_91C8_0A38B91DD3E6
				public Type Type => typeof(InitialValueClass);
				
				/// <inheritdoc cref="Property.Name" />
				public string Name => "HasInitialValue";
				
				/// <inheritdoc cref="Property.AccessModifier" />
				public string AccessModifier => "public";
				
				/// <inheritdoc cref="Property.Modifier" />
				public string Modifier => "";
				
				/// <inheritdoc cref="Property.NormativeVersion" />
				public string NormativeVersion => "";
				
				/// <inheritdoc cref="Property.DeprecatedVersion" />
				public string DeprecatedVersion => "";
				
				public string Aggregation => "composite";

				// Note: Extension.Extender
				public string Extension => "MagicDraw UML 19.0";

				public string Association => "InitialValue";

				// Note: DefaultValue.Name
				public string DefaultValue => "";

				// TODO: Add Summary
			}
		
		
			/// <remarks>Original Name: HasResetTrigger</remarks>
			public HasResetTriggerPartProperty HasResetTriggerPart { get; } = new HasResetTriggerPartProperty();
			public sealed class HasResetTriggerPartProperty
			{
				/// <inheritdoc cref="Property.Type" />
				/// Original Type: EAID_3F56D161_E1BD_4fa1_8D7A_1C9C2E15D303
				public Type Type => typeof(ResetTriggerClass);
				
				/// <inheritdoc cref="Property.Name" />
				public string Name => "HasResetTrigger";
				
				/// <inheritdoc cref="Property.AccessModifier" />
				public string AccessModifier => "public";
				
				/// <inheritdoc cref="Property.Modifier" />
				public string Modifier => "";
				
				/// <inheritdoc cref="Property.NormativeVersion" />
				public string NormativeVersion => "";
				
				/// <inheritdoc cref="Property.DeprecatedVersion" />
				public string DeprecatedVersion => "";
				
				public string Aggregation => "composite";

				// Note: Extension.Extender
				public string Extension => "MagicDraw UML 19.0";

				public string Association => "ResetTrigger";

				// Note: DefaultValue.Name
				public string DefaultValue => "";

				// TODO: Add Summary
			}
		
		
			/// <remarks>Original Name: HasObservation</remarks>
			public HasObservationPartProperty HasObservationPart { get; } = new HasObservationPartProperty();
			public sealed class HasObservationPartProperty
			{
				/// <inheritdoc cref="Property.Type" />
				/// Original Type: _19_0_3_45f01b9_1579566531115_47734_25731
				public Type Type => typeof(ObservationClass);
				
				/// <inheritdoc cref="Property.Name" />
				public string Name => "HasObservation";
				
				/// <inheritdoc cref="Property.AccessModifier" />
				public string AccessModifier => "public";
				
				/// <inheritdoc cref="Property.Modifier" />
				public string Modifier => "";
				
				/// <inheritdoc cref="Property.NormativeVersion" />
				public string NormativeVersion => "";
				
				/// <inheritdoc cref="Property.DeprecatedVersion" />
				public string DeprecatedVersion => "";
				
				public string Aggregation => "shared";

				// Note: Extension.Extender
				public string Extension => "";

				public string Association => "Observations";

				// Note: DefaultValue.Name
				public string DefaultValue => "";

				// TODO: Add Summary
			}
		
		
			/// <remarks>Original Name: HasDefinition</remarks>
			public HasDefinitionPartProperty HasDefinitionPart { get; } = new HasDefinitionPartProperty();
			public sealed class HasDefinitionPartProperty
			{
				/// <inheritdoc cref="Property.Type" />
				/// Original Type: _19_0_3_45f01b9_1581433165009_756087_158
				public Type Type => typeof(DefinitionClass);
				
				/// <inheritdoc cref="Property.Name" />
				public string Name => "HasDefinition";
				
				/// <inheritdoc cref="Property.AccessModifier" />
				public string AccessModifier => "public";
				
				/// <inheritdoc cref="Property.Modifier" />
				public string Modifier => "";
				
				/// <inheritdoc cref="Property.NormativeVersion" />
				public string NormativeVersion => "";
				
				/// <inheritdoc cref="Property.DeprecatedVersion" />
				public string DeprecatedVersion => "";
				
				public string Aggregation => "composite";

				// Note: Extension.Extender
				public string Extension => "MagicDraw UML 19.0";

				public string Association => "Definition";

				// Note: DefaultValue.Name
				public string DefaultValue => "";

				// TODO: Add Summary
			}
		
		
			/// <remarks>Original Name: CoordinateSystemIdRef</remarks>
			public CoordinateSystemIdRefProperty CoordinateSystemIdRef { get; } = new CoordinateSystemIdRefProperty();
			public sealed class CoordinateSystemIdRefProperty
			{
				/// <inheritdoc cref="Property.Type" />
				/// Original Type: _19_0_3_91b028d_1579272245466_691733_672
				public Type Type => typeof(String);
				
				/// <inheritdoc cref="Property.Name" />
				public string Name => "CoordinateSystemIdRef";
				
				/// <inheritdoc cref="Property.AccessModifier" />
				public string AccessModifier => "public";
				
				/// <inheritdoc cref="Property.Modifier" />
				public string Modifier => "";
				
				/// <inheritdoc cref="Property.NormativeVersion" />
				public string NormativeVersion => "MtconnectVersions.V_1_5_0";
				
				/// <inheritdoc cref="Property.DeprecatedVersion" />
				public string DeprecatedVersion => "";
				
				public string Aggregation => "composite";

				// Note: Extension.Extender
				public string Extension => "MagicDraw UML 19.0";

				public string Association => "";

				// Note: DefaultValue.Name
				public string DefaultValue => "";

				// TODO: Add Summary
			}
		
		
			/// <remarks>Original Name: HasRelationship</remarks>
			public HasRelationshipPartProperty HasRelationshipPart { get; } = new HasRelationshipPartProperty();
			public sealed class HasRelationshipPartProperty
			{
				/// <inheritdoc cref="Property.Type" />
				/// Original Type: _19_0_3_68e0225_1658942187874_859516_1061
				public Type Type => typeof(AbstractDataItemRelationshipClass);
				
				/// <inheritdoc cref="Property.Name" />
				public string Name => "HasRelationship";
				
				/// <inheritdoc cref="Property.AccessModifier" />
				public string AccessModifier => "public";
				
				/// <inheritdoc cref="Property.Modifier" />
				public string Modifier => "";
				
				/// <inheritdoc cref="Property.NormativeVersion" />
				public string NormativeVersion => "";
				
				/// <inheritdoc cref="Property.DeprecatedVersion" />
				public string DeprecatedVersion => "";
				
				public string Aggregation => "composite";

				// Note: Extension.Extender
				public string Extension => "";

				public string Association => "Relationships";

				// Note: DefaultValue.Name
				public string DefaultValue => "";

				// TODO: Add Summary
			}
		};

		# region Rules
		/// <summary>
		/// Dataitem1
		/// </summary>
		/// <remarks>Specification Language: <c>Unspecified</c></remarks>
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
		/*
		self.oclAsType(DataItems::"DataItem Types"::Event).category = DataTypes::CategoryEnum::EVENT or 
		self.oclAsType(DataItems::"DataItem Types"::Sample).category =  DataTypes::CategoryEnum::SAMPLE or
		self.oclAsType(DataItems::"DataItem Types"::Condition).category =  DataTypes::CategoryEnum::CONDITION
		*/
		# endregion
	}
}