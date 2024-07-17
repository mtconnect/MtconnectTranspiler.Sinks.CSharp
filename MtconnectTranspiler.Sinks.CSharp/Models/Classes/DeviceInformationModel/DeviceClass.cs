using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;
// using Mtconnect.DeviceInformationModel.Components.ComponentTypes;
// using Mtconnect.Glossary;
// using Mtconnect.Glossary.IndustrialTerms;
// using Mtconnect.ObservationInformationModel.ObservationTypes.ConditionTypes;
// using Mtconnect.WIP_BestPracticesWithExamples.OtherExamples.KinematicsSimulation.XArm7Model;
// using Mtconnect.ObservationInformationModel.ObservationTypes.EventTypes;

namespace Mtconnect.DeviceInformationModel
{
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "1.0.15.3")]
	public sealed class DeviceClass : IClass
	{
		/// <inheritdoc />
		public string ReferenceId => "_19_0_3_68e0225_1620240839406_285612_1596";
		
		/// <inheritdoc />
		public string Name => "DeviceClass";
		
		/// <inheritdoc />
		public string AccessModifier => "public";
				
		/// <inheritdoc />
		public string Modifier => "";
				
		/// <inheritdoc />
		public string NormativeVersion => "1.0";
				
		/// <inheritdoc />
		public string DeprecatedVersion => "";
		
		/// <inheritdoc />
		public string Generalization => "EAID_8548C620_467A_4f50_9A22_58D84B7E8779";

		/// <inheritdoc />
		public DeviceClassProperties Properties { get; } = new DeviceClassProperties();
        IPropertyList IClass.Properties => Properties;
		public sealed class DeviceClassProperties : IPropertyList
		{
			/// <inheritdoc />
			public IProperty[] Properties => new IProperty[] {
				HasAuxiliaryPart,
				HasControllerPart,
				HasInterfacePart,
				HasResourcePart,
				HasStructurePart,
				Iso841Class,
				Uuid,
				MtconnectVersion,
				HasSystemPart,
				Name,
				HasPartPart,
				HasProcessPart,
				HasAxisPart,
				HasAdapterPart,
				ObservesAvailability,
				ObservesAssetChanged,
				ObservesAssetRemoved,
				Hash,
			};
			/// <remarks>Original Name: HasAuxiliary</remarks>
			public HasAuxiliaryPartProperty HasAuxiliaryPart { get; } = new HasAuxiliaryPartProperty();
			public sealed class HasAuxiliaryPartProperty : IProperty
			{
				/// <summary>
				/// <inheritdoc />
				/// <remarks>
				/// <list type="bullet">
				/// <item>Original Type: _19_0_3_45f01b9_1579572381970_785259_42204</item>
				/// <item>Type: AuxiliaryClass</item>
				/// <item>Namespace: Mtconnect.DeviceInformationModel.Components.ComponentTypes</item>
				/// </list>
				/// </remarks>
				/// </summary>
				public System.Type Type => typeof(Mtconnect.DeviceInformationModel.Components.ComponentTypes.AuxiliaryClass);
				
				/// <inheritdoc />
				public string Name => "HasAuxiliary";
				
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
				public string Association => "AuxiliariesClass";

				// Note: DefaultValue.Name
				/// <inheritdoc />
				public string DefaultValue => "";

				// TODO: Add Summary
			}
			/// <remarks>Original Name: HasController</remarks>
			public HasControllerPartProperty HasControllerPart { get; } = new HasControllerPartProperty();
			public sealed class HasControllerPartProperty : IProperty
			{
				/// <summary>
				/// <inheritdoc />
				/// <remarks>
				/// <list type="bullet">
				/// <item>Original Type: _19_0_3_45f01b9_1579572381977_283525_42216</item>
				/// <item>Type: ControllerClass</item>
				/// <item>Namespace: Mtconnect.DeviceInformationModel.Components.ComponentTypes</item>
				/// </list>
				/// </remarks>
				/// </summary>
				public System.Type Type => typeof(Mtconnect.DeviceInformationModel.Components.ComponentTypes.ControllerClass);
				
				/// <inheritdoc />
				public string Name => "HasController";
				
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
				public string Association => "ControllersClass";

				// Note: DefaultValue.Name
				/// <inheritdoc />
				public string DefaultValue => "";

				// TODO: Add Summary
			}
			/// <remarks>Original Name: HasInterface</remarks>
			public HasInterfacePartProperty HasInterfacePart { get; } = new HasInterfacePartProperty();
			public sealed class HasInterfacePartProperty : IProperty
			{
				/// <summary>
				/// <inheritdoc />
				/// <remarks>
				/// <list type="bullet">
				/// <item>Original Type: _19_0_3_45f01b9_1579572381996_964170_42252</item>
				/// <item>Type: InterfaceClass</item>
				/// <item>Namespace: Mtconnect.Glossary</item>
				/// </list>
				/// </remarks>
				/// </summary>
				public System.Type Type => typeof(Mtconnect.Glossary.InterfaceClass);
				
				/// <inheritdoc />
				public string Name => "HasInterface";
				
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
				public string Association => "InterfacesClass";

				// Note: DefaultValue.Name
				/// <inheritdoc />
				public string DefaultValue => "";

				// TODO: Add Summary
			}
			/// <remarks>Original Name: HasResource</remarks>
			public HasResourcePartProperty HasResourcePart { get; } = new HasResourcePartProperty();
			public sealed class HasResourcePartProperty : IProperty
			{
				/// <summary>
				/// <inheritdoc />
				/// <remarks>
				/// <list type="bullet">
				/// <item>Original Type: _19_0_3_45f01b9_1579572382014_307743_42285</item>
				/// <item>Type: ResourceClass</item>
				/// <item>Namespace: Mtconnect.Glossary.IndustrialTerms</item>
				/// </list>
				/// </remarks>
				/// </summary>
				public System.Type Type => typeof(Mtconnect.Glossary.IndustrialTerms.ResourceClass);
				
				/// <inheritdoc />
				public string Name => "HasResource";
				
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
				public string Association => "ResourcesClass";

				// Note: DefaultValue.Name
				/// <inheritdoc />
				public string DefaultValue => "";

				// TODO: Add Summary
			}
			/// <remarks>Original Name: HasStructure</remarks>
			public HasStructurePartProperty HasStructurePart { get; } = new HasStructurePartProperty();
			public sealed class HasStructurePartProperty : IProperty
			{
				/// <summary>
				/// <inheritdoc />
				/// <remarks>
				/// <list type="bullet">
				/// <item>Original Type: _19_0_3_45f01b9_1587597358521_716746_1028</item>
				/// <item>Type: StructureClass</item>
				/// <item>Namespace: Mtconnect.DeviceInformationModel.Components.ComponentTypes</item>
				/// </list>
				/// </remarks>
				/// </summary>
				public System.Type Type => typeof(Mtconnect.DeviceInformationModel.Components.ComponentTypes.StructureClass);
				
				/// <inheritdoc />
				public string Name => "HasStructure";
				
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
				public string Association => "StructuresClass";

				// Note: DefaultValue.Name
				/// <inheritdoc />
				public string DefaultValue => "";

				// TODO: Add Summary
			}
			/// <remarks>Original Name: Iso841Class</remarks>
			public Iso841ClassProperty Iso841Class { get; } = new Iso841ClassProperty();
			public sealed class Iso841ClassProperty : IProperty
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
				public string Name => "Iso841Class";
				
				/// <inheritdoc />
				public string AccessModifier => "public";
				
				/// <inheritdoc />
				public string Modifier => "";
				
				/// <inheritdoc />
				public string NormativeVersion => "1.0";
				
				/// <inheritdoc />
				public string DeprecatedVersion => "1.2";
				
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

				// TODO: Add Summary
			}
			/// <remarks>Original Name: Uuid</remarks>
			public UuidProperty Uuid { get; } = new UuidProperty();
			public sealed class UuidProperty : IProperty
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
				public string Name => "Uuid";
				
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

				// TODO: Add Summary
			}
			/// <remarks>Original Name: MtconnectVersion</remarks>
			public MtconnectVersionProperty MtconnectVersion { get; } = new MtconnectVersionProperty();
			public sealed class MtconnectVersionProperty : IProperty
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
				public string Name => "MtconnectVersion";
				
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

				// TODO: Add Summary
			}
			/// <remarks>Original Name: HasSystem</remarks>
			public HasSystemPartProperty HasSystemPart { get; } = new HasSystemPartProperty();
			public sealed class HasSystemPartProperty : IProperty
			{
				/// <summary>
				/// <inheritdoc />
				/// <remarks>
				/// <list type="bullet">
				/// <item>Original Type: _19_0_3_45f01b9_1579572382020_336298_42297</item>
				/// <item>Type: SystemClass</item>
				/// <item>Namespace: Mtconnect.ObservationInformationModel.ObservationTypes.ConditionTypes</item>
				/// </list>
				/// </remarks>
				/// </summary>
				public System.Type Type => typeof(Mtconnect.ObservationInformationModel.ObservationTypes.ConditionTypes.SystemClass);
				
				/// <inheritdoc />
				public string Name => "HasSystem";
				
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
				public string Association => "SystemsClass";

				// Note: DefaultValue.Name
				/// <inheritdoc />
				public string DefaultValue => "";

				// TODO: Add Summary
			}
			/// <remarks>Original Name: Name</remarks>
			public NameProperty Name { get; } = new NameProperty();
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

				// TODO: Add Summary
			}
			/// <remarks>Original Name: HasPart</remarks>
			public HasPartPartProperty HasPartPart { get; } = new HasPartPartProperty();
			public sealed class HasPartPartProperty : IProperty
			{
				/// <summary>
				/// <inheritdoc />
				/// <remarks>
				/// <list type="bullet">
				/// <item>Original Type: _19_0_3_68e0225_1622456766067_72580_282</item>
				/// <item>Type: PartClass</item>
				/// <item>Namespace: Mtconnect.Glossary</item>
				/// </list>
				/// </remarks>
				/// </summary>
				public System.Type Type => typeof(Mtconnect.Glossary.PartClass);
				
				/// <inheritdoc />
				public string Name => "HasPart";
				
				/// <inheritdoc />
				public string AccessModifier => "private";
				
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
				public string Association => "PartsClass";

				// Note: DefaultValue.Name
				/// <inheritdoc />
				public string DefaultValue => "";

				// TODO: Add Summary
			}
			/// <remarks>Original Name: HasProcess</remarks>
			public HasProcessPartProperty HasProcessPart { get; } = new HasProcessPartProperty();
			public sealed class HasProcessPartProperty : IProperty
			{
				/// <summary>
				/// <inheritdoc />
				/// <remarks>
				/// <list type="bullet">
				/// <item>Original Type: _19_0_3_68e0225_1605547261014_920934_161</item>
				/// <item>Type: ProcessClass</item>
				/// <item>Namespace: Mtconnect.DeviceInformationModel.Components.ComponentTypes</item>
				/// </list>
				/// </remarks>
				/// </summary>
				public System.Type Type => typeof(Mtconnect.DeviceInformationModel.Components.ComponentTypes.ProcessClass);
				
				/// <inheritdoc />
				public string Name => "HasProcess";
				
				/// <inheritdoc />
				public string AccessModifier => "private";
				
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
				public string Association => "ProcessesClass";

				// Note: DefaultValue.Name
				/// <inheritdoc />
				public string DefaultValue => "";

				// TODO: Add Summary
			}
			/// <remarks>Original Name: HasAxis</remarks>
			public HasAxisPartProperty HasAxisPart { get; } = new HasAxisPartProperty();
			public sealed class HasAxisPartProperty : IProperty
			{
				/// <summary>
				/// <inheritdoc />
				/// <remarks>
				/// <list type="bullet">
				/// <item>Original Type: _19_0_3_45f01b9_1579572381972_553005_42207</item>
				/// <item>Type: AxisClass</item>
				/// <item>Namespace: Mtconnect.WIP_BestPracticesWithExamples.OtherExamples.KinematicsSimulation.XArm7Model</item>
				/// </list>
				/// </remarks>
				/// </summary>
				public System.Type Type => typeof(Mtconnect.WIP_BestPracticesWithExamples.OtherExamples.KinematicsSimulation.XArm7Model.AxisClass);
				
				/// <inheritdoc />
				public string Name => "HasAxis";
				
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
				public string Association => "AxesClass";

				// Note: DefaultValue.Name
				/// <inheritdoc />
				public string DefaultValue => "";

				// TODO: Add Summary
			}
			/// <remarks>Original Name: HasAdapter</remarks>
			public HasAdapterPartProperty HasAdapterPart { get; } = new HasAdapterPartProperty();
			public sealed class HasAdapterPartProperty : IProperty
			{
				/// <summary>
				/// <inheritdoc />
				/// <remarks>
				/// <list type="bullet">
				/// <item>Original Type: _19_0_3_68e0225_1605101651646_782838_139</item>
				/// <item>Type: AdapterClass</item>
				/// <item>Namespace: Mtconnect.Glossary</item>
				/// </list>
				/// </remarks>
				/// </summary>
				public System.Type Type => typeof(Mtconnect.Glossary.AdapterClass);
				
				/// <inheritdoc />
				public string Name => "HasAdapter";
				
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
				public string Association => "AdaptersClass";

				// Note: DefaultValue.Name
				/// <inheritdoc />
				public string DefaultValue => "";

				// TODO: Add Summary
			}
			/// <remarks>Original Name: ObservesAvailability</remarks>
			public ObservesAvailabilityProperty ObservesAvailability { get; } = new ObservesAvailabilityProperty();
			public sealed class ObservesAvailabilityProperty : IProperty
			{
				/// <summary>
				/// <inheritdoc />
				/// <remarks>
				/// <list type="bullet">
				/// <item>Original Type: _19_0_3_45f01b9_1580378218181_310908_1554</item>
				/// <item>Type: AvailabilityClass</item>
				/// <item>Namespace: Mtconnect.ObservationInformationModel.ObservationTypes.EventTypes</item>
				/// </list>
				/// </remarks>
				/// </summary>
				public System.Type Type => typeof(Mtconnect.ObservationInformationModel.ObservationTypes.EventTypes.AvailabilityClass);
				
				/// <inheritdoc />
				public string Name => "ObservesAvailability";
				
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

				// TODO: Add Summary
			}
			/// <remarks>Original Name: ObservesAssetChanged</remarks>
			public ObservesAssetChangedProperty ObservesAssetChanged { get; } = new ObservesAssetChangedProperty();
			public sealed class ObservesAssetChangedProperty : IProperty
			{
				/// <summary>
				/// <inheritdoc />
				/// <remarks>
				/// <list type="bullet">
				/// <item>Original Type: _19_0_3_45f01b9_1580378218176_915013_1548</item>
				/// <item>Type: AssetChangedClass</item>
				/// <item>Namespace: Mtconnect.ObservationInformationModel.ObservationTypes.EventTypes</item>
				/// </list>
				/// </remarks>
				/// </summary>
				public System.Type Type => typeof(Mtconnect.ObservationInformationModel.ObservationTypes.EventTypes.AssetChangedClass);
				
				/// <inheritdoc />
				public string Name => "ObservesAssetChanged";
				
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

				// TODO: Add Summary
			}
			/// <remarks>Original Name: ObservesAssetRemoved</remarks>
			public ObservesAssetRemovedProperty ObservesAssetRemoved { get; } = new ObservesAssetRemovedProperty();
			public sealed class ObservesAssetRemovedProperty : IProperty
			{
				/// <summary>
				/// <inheritdoc />
				/// <remarks>
				/// <list type="bullet">
				/// <item>Original Type: _19_0_3_45f01b9_1580378218180_352606_1551</item>
				/// <item>Type: AssetRemovedClass</item>
				/// <item>Namespace: Mtconnect.ObservationInformationModel.ObservationTypes.EventTypes</item>
				/// </list>
				/// </remarks>
				/// </summary>
				public System.Type Type => typeof(Mtconnect.ObservationInformationModel.ObservationTypes.EventTypes.AssetRemovedClass);
				
				/// <inheritdoc />
				public string Name => "ObservesAssetRemoved";
				
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

				// TODO: Add Summary
			}
			/// <remarks>Original Name: Hash</remarks>
			public HashProperty Hash { get; } = new HashProperty();
			public sealed class HashProperty : IProperty
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
				public string Name => "Hash";
				
				/// <inheritdoc />
				public string AccessModifier => "public";
				
				/// <inheritdoc />
				public string Modifier => "";
				
				/// <inheritdoc />
				public string NormativeVersion => "2.2";
				
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

				// TODO: Add Summary
			}
		};

		# region Rules
		/// <summary>
		/// Device1
		/// </summary>
		/// <remarks>Specification Language: <c>Unspecified</c></remarks>
		/*
		Components::Devices::Device::allInstances()->iterate(device;devicecount:Real=0|
		if device.observes->size() >= 3
		then 
		    if device.observes->iterate(av;avail:Real=0|if av.oclAsType(DataItems::"DataItem Types"::Event).type = DataTypes::EventEnum::AVAILABILITY then avail+1 else avail+0 endif) = 1
		    then if device.observes->iterate(ac;assetc:Real=0|if ac.oclAsType(DataItems::"DataItem Types"::Event).type = DataTypes::EventEnum::ASSET_CHANGED then assetc+1 else assetc+0 endif) = 1
		        then if device.observes->iterate(ar;assetr:Real=0|if ar.oclAsType(DataItems::"DataItem Types"::Event).type = DataTypes::EventEnum::ASSET_REMOVED then assetr+1 else assetr+0 endif) = 1
		            then devicecount + 1
		            else devicecount + 0
		            endif
		        else devicecount + 0
		        endif
		    else devicecount + 0
		    endif
		else devicecount + 0
		endif) = hasDevice->size()
		*/
		/// <summary>
		/// Device2
		/// </summary>
		/// <remarks>Specification Language: <c>Unspecified</c></remarks>
		/*
		Components::Devices::Device::allInstances()->iterate(device;devicecount:Real=0|
		if device.id->size() = 1 and 
		    device.name->size() = 1 and
		    device.uuid->size() = 1 and
		    (device.observes->size() > 0 or device.hasReference->size() > 0 or device.hasComponent->size() > 0) 
		then
		    devicecount + 1
		else
		    devicecount + 0
		endif
		) = Components::Devices::Device::allInstances()->size()
		*/
		# endregion
	}
}