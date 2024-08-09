using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;
using System.Linq;

namespace Mtconnect.DeviceInformationModel
{
	/// <summary>
	/// <see cref="Component">Component</see> composed of a piece of equipment that produces <i>observation</i>s about itself./// Description
	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Structure___19_0_3_68e0225_1620240839406_285612_1596">model.mtconnect.org</seealso> for more information.
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.3.0.0")]
	public sealed class DeviceClass : IClass
	{
		/// <inheritdoc />
		public string ReferenceId => "_19_0_3_68e0225_1620240839406_285612_1596";
		
		/// <inheritdoc />
		public string Summary => @"/// <see cref=""Component"">Component</see> composed of a piece of equipment that produces <i>observation</i>s about itself./// Description";

		/// <inheritdoc />
		public string Name => "Device";
		
		/// <inheritdoc />
		public string AccessModifier => "public";
				
		/// <inheritdoc />
		public string Modifier => "";
				
		/// <inheritdoc />
		public string NormativeVersion => "1.0";
				
		/// <inheritdoc />
		public string DeprecatedVersion => "";
		
		/// <inheritdoc />
		/// <remarks>
		/// Original Type: EAID_8548C620_467A_4f50_9A22_58D84B7E8779
		/// </remarks>
		public Type Generalization => typeof(Mtconnect.DeviceInformationModel.Components.ComponentGeneralization);

		/// <inheritdoc />
		public DeviceClassProperties Properties { get; } = new DeviceClassProperties();
        IPropertyList IClass.Properties => Properties;
		public class DeviceClassProperties : Mtconnect.DeviceInformationModel.Components.ComponentGeneralization.ComponentGeneralizationProperties
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
			}.Concat(base.Properties).ToArray();
			/// <summary>
			/// <inheritdoc cref="HasAuxiliaryPartProperty" path="/summary" /><br/>
			/// <remarks>Original Name: HasAuxiliary</remarks>
			/// </summary>
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
				public string Name => "hasAuxiliary";
				
				/// <inheritdoc />
				public string Summary => @"/// <see cref=""Component"">Component</see> composed of a piece of equipment that produces <i>observation</i>s about itself./// Description";

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
			}
			/// <summary>
			/// <inheritdoc cref="HasControllerPartProperty" path="/summary" /><br/>
			/// <remarks>Original Name: HasController</remarks>
			/// </summary>
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
				public string Name => "hasController";
				
				/// <inheritdoc />
				public string Summary => @"/// <see cref=""Component"">Component</see> composed of a piece of equipment that produces <i>observation</i>s about itself./// Description";

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
			}
			/// <summary>
			/// <inheritdoc cref="HasInterfacePartProperty" path="/summary" /><br/>
			/// <remarks>Original Name: HasInterface</remarks>
			/// </summary>
			public HasInterfacePartProperty HasInterfacePart { get; } = new HasInterfacePartProperty();
			public sealed class HasInterfacePartProperty : IProperty
			{
				/// <summary>
				/// <inheritdoc />
				/// <remarks>
				/// <list type="bullet">
				/// <item>Original Type: _19_0_3_45f01b9_1579572381996_964170_42252</item>
				/// <item>Type: InterfaceClass</item>
				/// <item>Namespace: Mtconnect.InterfaceInteractionModel</item>
				/// </list>
				/// </remarks>
				/// </summary>
				public System.Type Type => typeof(Mtconnect.InterfaceInteractionModel.InterfaceClass);
				
				/// <inheritdoc />
				public string Name => "hasInterface";
				
				/// <inheritdoc />
				public string Summary => @"/// <see cref=""Component"">Component</see> composed of a piece of equipment that produces <i>observation</i>s about itself./// Description";

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
			}
			/// <summary>
			/// <inheritdoc cref="HasResourcePartProperty" path="/summary" /><br/>
			/// <remarks>Original Name: HasResource</remarks>
			/// </summary>
			public HasResourcePartProperty HasResourcePart { get; } = new HasResourcePartProperty();
			public sealed class HasResourcePartProperty : IProperty
			{
				/// <summary>
				/// <inheritdoc />
				/// <remarks>
				/// <list type="bullet">
				/// <item>Original Type: _19_0_3_45f01b9_1579572382014_307743_42285</item>
				/// <item>Type: ResourceClass</item>
				/// <item>Namespace: Mtconnect.DeviceInformationModel.Components.ComponentTypes</item>
				/// </list>
				/// </remarks>
				/// </summary>
				public System.Type Type => typeof(Mtconnect.DeviceInformationModel.Components.ComponentTypes.ResourceClass);
				
				/// <inheritdoc />
				public string Name => "hasResource";
				
				/// <inheritdoc />
				public string Summary => @"/// <see cref=""Component"">Component</see> composed of a piece of equipment that produces <i>observation</i>s about itself./// Description";

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
			}
			/// <summary>
			/// <inheritdoc cref="HasStructurePartProperty" path="/summary" /><br/>
			/// <remarks>Original Name: HasStructure</remarks>
			/// </summary>
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
				public string Name => "hasStructure";
				
				/// <inheritdoc />
				public string Summary => @"/// <see cref=""Component"">Component</see> composed of a piece of equipment that produces <i>observation</i>s about itself./// Description";

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
			}
			/// <summary>
			/// <inheritdoc cref="Iso841ClassProperty" path="/summary" /><br/>
			/// <remarks>Original Name: Iso841Class</remarks>
			/// </summary>
			public Iso841ClassProperty Iso841Class { get; } = new Iso841ClassProperty();
			/// <summary>
			/// <b>DEPRECATED</b> in <i>MTConnect Version 1.2</i>s.
			/// </summary>
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
				public string Name => "iso841Class";
				
				/// <inheritdoc />
				public string Summary => @"/// <see cref=""Component"">Component</see> composed of a piece of equipment that produces <i>observation</i>s about itself./// Description";

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
			}
			/// <summary>
			/// <inheritdoc cref="UuidProperty" path="/summary" /><br/>
			/// <remarks>Original Name: Uuid</remarks>
			/// </summary>
			public UuidProperty Uuid { get; } = new UuidProperty();
			/// <summary>
			/// universally unique identifier for the element.
			/// </summary>
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
				public string Name => "uuid";
				
				/// <inheritdoc />
				public string Summary => @"/// <see cref=""Component"">Component</see> composed of a piece of equipment that produces <i>observation</i>s about itself./// Description";

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
			/// <inheritdoc cref="MtconnectVersionProperty" path="/summary" /><br/>
			/// <remarks>Original Name: MtconnectVersion</remarks>
			/// </summary>
			public MtconnectVersionProperty MtconnectVersion { get; } = new MtconnectVersionProperty();
			/// <summary>
			/// MTConnect version of the <i>Device Information Model</i> used to configure the information to be published for a piece of equipment in an <i>MTConnect Response Document</i>.
			/// </summary>
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
				public string Name => "mtconnectVersion";
				
				/// <inheritdoc />
				public string Summary => @"/// <see cref=""Component"">Component</see> composed of a piece of equipment that produces <i>observation</i>s about itself./// Description";

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
			/// <inheritdoc cref="HasSystemPartProperty" path="/summary" /><br/>
			/// <remarks>Original Name: HasSystem</remarks>
			/// </summary>
			public HasSystemPartProperty HasSystemPart { get; } = new HasSystemPartProperty();
			public sealed class HasSystemPartProperty : IProperty
			{
				/// <summary>
				/// <inheritdoc />
				/// <remarks>
				/// <list type="bullet">
				/// <item>Original Type: _19_0_3_45f01b9_1579572382020_336298_42297</item>
				/// <item>Type: SystemClass</item>
				/// <item>Namespace: Mtconnect.DeviceInformationModel.Components.ComponentTypes</item>
				/// </list>
				/// </remarks>
				/// </summary>
				public System.Type Type => typeof(Mtconnect.DeviceInformationModel.Components.ComponentTypes.SystemClass);
				
				/// <inheritdoc />
				public string Name => "hasSystem";
				
				/// <inheritdoc />
				public string Summary => @"/// <see cref=""Component"">Component</see> composed of a piece of equipment that produces <i>observation</i>s about itself./// Description";

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
			}
			/// <summary>
			/// <inheritdoc cref="NameProperty" path="/summary" /><br/>
			/// <remarks>Original Name: Name</remarks>
			/// </summary>
			public NameProperty Name { get; } = new NameProperty();
			/// <summary>
			/// name of an element or a piece of equipment.
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
				public string Summary => @"/// <see cref=""Component"">Component</see> composed of a piece of equipment that produces <i>observation</i>s about itself./// Description";

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
			/// <inheritdoc cref="HasPartPartProperty" path="/summary" /><br/>
			/// <remarks>Original Name: HasPart</remarks>
			/// </summary>
			public HasPartPartProperty HasPartPart { get; } = new HasPartPartProperty();
			public sealed class HasPartPartProperty : IProperty
			{
				/// <summary>
				/// <inheritdoc />
				/// <remarks>
				/// <list type="bullet">
				/// <item>Original Type: _19_0_3_68e0225_1622456766067_72580_282</item>
				/// <item>Type: PartClass</item>
				/// <item>Namespace: Mtconnect.DeviceInformationModel.Components.ComponentTypes</item>
				/// </list>
				/// </remarks>
				/// </summary>
				public System.Type Type => typeof(Mtconnect.DeviceInformationModel.Components.ComponentTypes.PartClass);
				
				/// <inheritdoc />
				public string Name => "hasPart";
				
				/// <inheritdoc />
				public string Summary => @"/// <see cref=""Component"">Component</see> composed of a piece of equipment that produces <i>observation</i>s about itself./// Description";

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
			}
			/// <summary>
			/// <inheritdoc cref="HasProcessPartProperty" path="/summary" /><br/>
			/// <remarks>Original Name: HasProcess</remarks>
			/// </summary>
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
				public string Name => "hasProcess";
				
				/// <inheritdoc />
				public string Summary => @"/// <see cref=""Component"">Component</see> composed of a piece of equipment that produces <i>observation</i>s about itself./// Description";

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
			}
			/// <summary>
			/// <inheritdoc cref="HasAxisPartProperty" path="/summary" /><br/>
			/// <remarks>Original Name: HasAxis</remarks>
			/// </summary>
			public HasAxisPartProperty HasAxisPart { get; } = new HasAxisPartProperty();
			public sealed class HasAxisPartProperty : IProperty
			{
				/// <summary>
				/// <inheritdoc />
				/// <remarks>
				/// <list type="bullet">
				/// <item>Original Type: _19_0_3_45f01b9_1579572381972_553005_42207</item>
				/// <item>Type: AxisClass</item>
				/// <item>Namespace: Mtconnect.DeviceInformationModel.Components.ComponentTypes</item>
				/// </list>
				/// </remarks>
				/// </summary>
				public System.Type Type => typeof(Mtconnect.DeviceInformationModel.Components.ComponentTypes.AxisClass);
				
				/// <inheritdoc />
				public string Name => "hasAxis";
				
				/// <inheritdoc />
				public string Summary => @"/// <see cref=""Component"">Component</see> composed of a piece of equipment that produces <i>observation</i>s about itself./// Description";

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
			}
			/// <summary>
			/// <inheritdoc cref="HasAdapterPartProperty" path="/summary" /><br/>
			/// <remarks>Original Name: HasAdapter</remarks>
			/// </summary>
			public HasAdapterPartProperty HasAdapterPart { get; } = new HasAdapterPartProperty();
			public sealed class HasAdapterPartProperty : IProperty
			{
				/// <summary>
				/// <inheritdoc />
				/// <remarks>
				/// <list type="bullet">
				/// <item>Original Type: _19_0_3_68e0225_1605101651646_782838_139</item>
				/// <item>Type: AdapterClass</item>
				/// <item>Namespace: Mtconnect.DeviceInformationModel.Components.ComponentTypes</item>
				/// </list>
				/// </remarks>
				/// </summary>
				public System.Type Type => typeof(Mtconnect.DeviceInformationModel.Components.ComponentTypes.AdapterClass);
				
				/// <inheritdoc />
				public string Name => "hasAdapter";
				
				/// <inheritdoc />
				public string Summary => @"/// <see cref=""Component"">Component</see> composed of a piece of equipment that produces <i>observation</i>s about itself./// Description";

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
			}
			/// <summary>
			/// <inheritdoc cref="ObservesAvailabilityProperty" path="/summary" /><br/>
			/// <remarks>Original Name: ObservesAvailability</remarks>
			/// </summary>
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
				public string Name => "observesAvailability";
				
				/// <inheritdoc />
				public string Summary => @"/// <see cref=""Component"">Component</see> composed of a piece of equipment that produces <i>observation</i>s about itself./// Description";

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
			/// <summary>
			/// <inheritdoc cref="ObservesAssetChangedProperty" path="/summary" /><br/>
			/// <remarks>Original Name: ObservesAssetChanged</remarks>
			/// </summary>
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
				public string Name => "observesAssetChanged";
				
				/// <inheritdoc />
				public string Summary => @"/// <see cref=""Component"">Component</see> composed of a piece of equipment that produces <i>observation</i>s about itself./// Description";

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
			/// <summary>
			/// <inheritdoc cref="ObservesAssetRemovedProperty" path="/summary" /><br/>
			/// <remarks>Original Name: ObservesAssetRemoved</remarks>
			/// </summary>
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
				public string Name => "observesAssetRemoved";
				
				/// <inheritdoc />
				public string Summary => @"/// <see cref=""Component"">Component</see> composed of a piece of equipment that produces <i>observation</i>s about itself./// Description";

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
			/// <summary>
			/// <inheritdoc cref="HashProperty" path="/summary" /><br/>
			/// <remarks>Original Name: Hash</remarks>
			/// </summary>
			public HashProperty Hash { get; } = new HashProperty();
			/// <summary>
			/// condensed message digest from a secure one-way hash function. <seealso href="https://www.google.com/search?q=FIPS PUB 180-4&btnI=I">FIPS PUB 180-4</seealso>
			/// </summary>
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
				public string Name => "hash";
				
				/// <inheritdoc />
				public string Summary => @"/// <see cref=""Component"">Component</see> composed of a piece of equipment that produces <i>observation</i>s about itself./// Description";

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
			}
		};

		# region Rules
		/// <summary>
		/// Device1
		/// </summary>
		/// <remarks>Specification Language: <c>Unspecified</c></remarks>
		public string Device1 => @"Components::Devices::Device::allInstances()->iterate(device;devicecount:Real=0|
if device.observes->size() >= 3
then 
    if device.observes->iterate(av;avail:Real=0|if av.oclAsType(DataItems::""DataItem Types""::Event).type = DataTypes::EventEnum::AVAILABILITY then avail+1 else avail+0 endif) = 1
    then if device.observes->iterate(ac;assetc:Real=0|if ac.oclAsType(DataItems::""DataItem Types""::Event).type = DataTypes::EventEnum::ASSET_CHANGED then assetc+1 else assetc+0 endif) = 1
        then if device.observes->iterate(ar;assetr:Real=0|if ar.oclAsType(DataItems::""DataItem Types""::Event).type = DataTypes::EventEnum::ASSET_REMOVED then assetr+1 else assetr+0 endif) = 1
            then devicecount + 1
            else devicecount + 0
            endif
        else devicecount + 0
        endif
    else devicecount + 0
    endif
else devicecount + 0
endif) = hasDevice->size()";
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
		public string Device2 => @"Components::Devices::Device::allInstances()->iterate(device;devicecount:Real=0|
if device.id->size() = 1 and 
    device.name->size() = 1 and
    device.uuid->size() = 1 and
    (device.observes->size() > 0 or device.hasReference->size() > 0 or device.hasComponent->size() > 0) 
then
    devicecount + 1
else
    devicecount + 0
endif
) = Components::Devices::Device::allInstances()->size()";
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