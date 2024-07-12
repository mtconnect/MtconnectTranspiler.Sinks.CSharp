
using System;
using System.CodeDom.Compiler;

using Mtconnect.DeviceInformationModel.Components;
using Mtconnect.Glossary.MTConnectTerms;
using Mtconnect.ObservationInformationModel;
using Mtconnect.AgentArchitecture.InformationModel;

namespace Mtconnect.DeviceInformationModel.Components
{
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "1.0.15.3")]
	public sealed class ComponentClass
	{
		/// <inheritdoc cref="Class.ReferenceId" />
		public string ReferenceId => "EAID_8548C620_467A_4f50_9A22_58D84B7E8779";
		
		/// <inheritdoc cref="Class.Name" />
		public string Name => "Component";
		
		/// <inheritdoc cref="Class.AccessModifier" />
		public string AccessModifier => "public";
				
		/// <inheritdoc cref="Class.Modifier" />
		public string Modifier => "abstract";
				
		/// <inheritdoc cref="Class.NormativeVersion" />
		public string NormativeVersion => "MtconnectVersions.V_1_0_1";
				
		/// <inheritdoc cref="Class.DeprecatedVersion" />
		public string DeprecatedVersion => "";

		public string Generalization => "";

		public ComponentProperties Properties { get; } = new ComponentProperties();
		public sealed class ComponentProperties
		{
		
		
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
		
		
			/// <remarks>Original Name: NativeName</remarks>
			public NativeNameProperty NativeName { get; } = new NativeNameProperty();
			public sealed class NativeNameProperty
			{
				/// <inheritdoc cref="Property.Type" />
				/// Original Type: _19_0_3_91b028d_1579272360416_763325_681
				public Type Type => typeof(String);
				
				/// <inheritdoc cref="Property.Name" />
				public string Name => "NativeName";
				
				/// <inheritdoc cref="Property.AccessModifier" />
				public string AccessModifier => "public";
				
				/// <inheritdoc cref="Property.Modifier" />
				public string Modifier => "";
				
				/// <inheritdoc cref="Property.NormativeVersion" />
				public string NormativeVersion => "MtconnectVersions.V_1_1_0";
				
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
		
		
			/// <remarks>Original Name: SampleInterval</remarks>
			public SampleIntervalProperty SampleInterval { get; } = new SampleIntervalProperty();
			public sealed class SampleIntervalProperty
			{
				/// <inheritdoc cref="Property.Type" />
				/// Original Type: _19_0_3_91b028d_1579272506322_914606_702
				public Type Type => typeof(Single);
				
				/// <inheritdoc cref="Property.Name" />
				public string Name => "SampleInterval";
				
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
				public string NormativeVersion => "MtconnectVersions.V_1_0_1";
				
				/// <inheritdoc cref="Property.DeprecatedVersion" />
				public string DeprecatedVersion => "MtconnectVersions.V_1_2_0";
				
				public string Aggregation => "";

				// Note: Extension.Extender
				public string Extension => "MagicDraw UML 19.0";

				public string Association => "";

				// Note: DefaultValue.Name
				public string DefaultValue => "";

				// TODO: Add Summary
			}
		
		
			/// <remarks>Original Name: Uuid</remarks>
			public UuidProperty Uuid { get; } = new UuidProperty();
			public sealed class UuidProperty
			{
				/// <inheritdoc cref="Property.Type" />
				/// Original Type: _19_0_3_91b028d_1579272245466_691733_672
				public Type Type => typeof(String);
				
				/// <inheritdoc cref="Property.Name" />
				public string Name => "Uuid";
				
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
		
		
			/// <remarks>Original Name: HasDescription</remarks>
			public HasDescriptionPartProperty HasDescriptionPart { get; } = new HasDescriptionPartProperty();
			public sealed class HasDescriptionPartProperty
			{
				/// <inheritdoc cref="Property.Type" />
				/// Original Type: EAID_64352755_7251_46af_846D_937E5A1E3949
				public Type Type => typeof(DescriptionClass);
				
				/// <inheritdoc cref="Property.Name" />
				public string Name => "HasDescription";
				
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

				public string Association => "Description";

				// Note: DefaultValue.Name
				public string DefaultValue => "";

				// TODO: Add Summary
			}
		
		
			/// <remarks>Original Name: HasComposition</remarks>
			public HasCompositionPartProperty HasCompositionPart { get; } = new HasCompositionPartProperty();
			public sealed class HasCompositionPartProperty
			{
				/// <inheritdoc cref="Property.Type" />
				/// Original Type: _19_0_3_68e0225_1658936424016_561586_139
				public Type Type => typeof(CompositionClass);
				
				/// <inheritdoc cref="Property.Name" />
				public string Name => "HasComposition";
				
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

				public string Association => "Compositions";

				// Note: DefaultValue.Name
				public string DefaultValue => "";

				// TODO: Add Summary
			}
		
		
			/// <remarks>Original Name: HasComponent</remarks>
			public HasComponentPartProperty HasComponentPart { get; } = new HasComponentPartProperty();
			public sealed class HasComponentPartProperty
			{
				/// <inheritdoc cref="Property.Type" />
				/// Original Type: EAID_8548C620_467A_4f50_9A22_58D84B7E8779
				public Type Type => typeof(ComponentClass);
				
				/// <inheritdoc cref="Property.Name" />
				public string Name => "HasComponent";
				
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

				public string Association => "Components";

				// Note: DefaultValue.Name
				public string DefaultValue => "";

				// TODO: Add Summary
			}
		
		
			/// <remarks>Original Name: HasConfiguration</remarks>
			public HasConfigurationPartProperty HasConfigurationPart { get; } = new HasConfigurationPartProperty();
			public sealed class HasConfigurationPartProperty
			{
				/// <inheritdoc cref="Property.Type" />
				/// Original Type: EAID_C04DCC77_16E8_4cef_92D4_B777AFC52570
				public Type Type => typeof(ConfigurationClass);
				
				/// <inheritdoc cref="Property.Name" />
				public string Name => "HasConfiguration";
				
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

				public string Association => "Configuration";

				// Note: DefaultValue.Name
				public string DefaultValue => "";

				// TODO: Add Summary
			}
		
		
			/// <remarks>Original Name: IsComponentOf</remarks>
			public IsComponentOfPartProperty IsComponentOfPart { get; } = new IsComponentOfPartProperty();
			public sealed class IsComponentOfPartProperty
			{
				/// <inheritdoc cref="Property.Type" />
				/// Original Type: EAID_8548C620_467A_4f50_9A22_58D84B7E8779
				public Type Type => typeof(ComponentClass);
				
				/// <inheritdoc cref="Property.Name" />
				public string Name => "IsComponentOf";
				
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

				public string Association => "Components";

				// Note: DefaultValue.Name
				public string DefaultValue => "";

				// TODO: Add Summary
			}
		
		
			/// <remarks>Original Name: Observes</remarks>
			public ObservesPartProperty ObservesPart { get; } = new ObservesPartProperty();
			public sealed class ObservesPartProperty
			{
				/// <inheritdoc cref="Property.Type" />
				/// Original Type: EAID_002C94B7_1257_49be_8EAA_CE7FCD7AFF8A
				public Type Type => typeof(DataItemClass);
				
				/// <inheritdoc cref="Property.Name" />
				public string Name => "Observes";
				
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

				public string Association => "DataItems";

				// Note: DefaultValue.Name
				public string DefaultValue => "";

				// TODO: Add Summary
			}
		
		
			/// <remarks>Original Name: MadeObservation</remarks>
			public MadeObservationPartProperty MadeObservationPart { get; } = new MadeObservationPartProperty();
			public sealed class MadeObservationPartProperty
			{
				/// <inheritdoc cref="Property.Type" />
				/// Original Type: _19_0_3_45f01b9_1579566531115_47734_25731
				public Type Type => typeof(ObservationClass);
				
				/// <inheritdoc cref="Property.Name" />
				public string Name => "MadeObservation";
				
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

				public string Association => "Observations";

				// Note: DefaultValue.Name
				public string DefaultValue => "";

				// TODO: Add Summary
			}
		
		
			/// <remarks>Original Name: HasReference</remarks>
			public HasReferencePartProperty HasReferencePart { get; } = new HasReferencePartProperty();
			public sealed class HasReferencePartProperty
			{
				/// <inheritdoc cref="Property.Type" />
				/// Original Type: EAID_25A13743_B12C_4c6c_B1DA_8E2EFDD156EF
				public Type Type => typeof(ReferenceClass);
				
				/// <inheritdoc cref="Property.Name" />
				public string Name => "HasReference";
				
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

				public string Association => "References";

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
				public string NormativeVersion => "MtconnectVersions.V_1_8_0";
				
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
		
		
			/// <remarks>Original Name: HasComponentStream</remarks>
			public HasComponentStreamPartProperty HasComponentStreamPart { get; } = new HasComponentStreamPartProperty();
			public sealed class HasComponentStreamPartProperty
			{
				/// <inheritdoc cref="Property.Type" />
				/// Original Type: EAID_9057AAF9_4687_42be_BD2B_E2F18DF049DC
				public Type Type => typeof(ComponentStreamClass);
				
				/// <inheritdoc cref="Property.Name" />
				public string Name => "HasComponentStream";
				
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
				public string Extension => "MagicDraw UML 19.0";

				public string Association => "ComponentStream";

				// Note: DefaultValue.Name
				public string DefaultValue => "";

				// TODO: Add Summary
			}
		};

		# region Rules
		/// <summary>
		/// Component1
		/// </summary>
		/// <remarks>Specification Language: <c>Unspecified</c></remarks>
		/*
		Components::Component::allInstances()->iterate(comp;compcount:Real=0|
		if comp.id->size() = 1 and
		    (comp.observes->size() <> 0 or comp.hasReference->size() <> 0 or comp.hasComponent->size() <> 0 or comp.oclAsType(Components::"Component Types"::Organizer)->size() <> 0) 
		then
		    compcount + 1
		else
		    compcount + 0                                
		endif
		) = Components::Component::allInstances()->size()
		*/
		# endregion
	}
}