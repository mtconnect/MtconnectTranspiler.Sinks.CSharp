#pragma warning disable CS0109 // Member does not hide an inherited member; new keyword is not required
#pragma warning disable CS1574 // XML comment has cref attribute that could not be resolved
#pragma warning disable CS1584 // XML comment has syntactically incorrect cref attribute
#pragma warning disable CS0618 // Type or member is obsolete
using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;
using System.Linq;

namespace Mtconnect.DeviceInformationModel
{
	/// <summary>﻿<see cref="Component">Component</see> composed of a piece of equipment that produces <i>observation</i>s about itself.<br /><br /><br />Description<br /><br />A <see cref="Device">Device</see> <i>organize</i>s its parts as <see cref="Component">Component</see> entities.<br /><br />A <see cref="Device">Device</see> <b>MUST</b> have a <see cref="Device.name">name in Device</see> and <see cref="Device.uuid">uuid in Device</see> to identify itself. <br /><br />A <see cref="Device">Device</see> <b>MUST</b> have the following <see cref="DataItems">DataItems</see>: <see cref="Availability">Availability</see>, <see cref="AssetChanged">AssetChanged</see>, and <see cref="AssetRemoved">AssetRemoved</see>.<br /><br />See <see cref="Components">Components</see> for more details on the properties of <see cref="Device">Device</see>.<br /><br />&gt; See <see cref="Part Properties of Device">Part Properties of Device</see> for a list of <i>top level</i> <see cref="Component">Component</see> types for a <see cref="Device">Device</see>.<br /><br /><br /><br /><br /><br />
	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Structure___19_0_3_68e0225_1620240839406_285612_1596">model.mtconnect.org</seealso> for more information.
	/// </summary>
	/// <remarks>
	/// <list type="bullet">
	/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
	/// </list>
	/// </remarks>

	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public sealed class DeviceClass : IClass
	{
		/// <summary>Constant value for <see cref="DeviceClass.ReferenceId" /></summary>
		public const string REFERENCE_ID = "_19_0_3_68e0225_1620240839406_285612_1596";
		/// <summary>Constant value for <see cref="DeviceClass.HelpUrl" /></summary>
		public const string HELP_URL = "https://model.mtconnect.org/#Structure___19_0_3_68e0225_1620240839406_285612_1596";
		/// <summary>Constant value for <see cref="DeviceClass.Summary" /></summary>
		public const string SUMMARY = @"&#10;&#10;&#10;{{block(Component)}} composed of a piece of equipment that produces {{termplural(observation)}} about itself.&#10;
&#10;&#10;&#10;Description&#10;&#10;&#10;&#10;A {{block(Device)}} {{termplural(organize)}} its parts as {{block(Component)}} entities.

A {{block(Device)}} **MUST** have a {{property(Device::name)}} and {{property(Device::uuid)}} to identify itself. 

A {{block(Device)}} **MUST** have the following {{block(DataItems)}}: {{block(Availability)}}, {{block(AssetChanged)}}, and {{block(AssetRemoved)}}.

See {{package(Components)}} for more details on the properties of {{block(Device)}}.

> See {{sect(Part Properties of Device)}} for a list of {{term(top level)}} {{block(Component)}} types for a {{block(Device)}}.
&#10;
";
		/// <summary>Constant value for <see cref="DeviceClass.Name" /></summary>
		public const string NAME = "Device";
		/// <summary>Constant value for <see cref="DeviceClass.AccessModifier" /></summary>
		public const string ACCESS_MODIFIER = "public";
		/// <summary>Constant value for <see cref="DeviceClass.Modifier" /></summary>
		public const string MODIFIER = "";
		/// <summary>Constant value for <see cref="DeviceClass.NormativeVersion" /></summary>
		public const string NORMATIVE_VERSION = "1.0";
		/// <summary>Constant value for <see cref="DeviceClass.DeprecatedVersion" /></summary>
		public const string DEPRECATED_VERSION = "";

		/// <inheritdoc />
		public string ReferenceId => REFERENCE_ID;
		
		/// <inheritdoc />
		public string HelpUrl => HELP_URL;

		/// <inheritdoc />
		public string Summary => SUMMARY;

		/// <inheritdoc />
		public string Name => NAME;
		
		/// <inheritdoc />
		public string AccessModifier => ACCESS_MODIFIER;
				
		/// <inheritdoc />
		public string Modifier => MODIFIER;
				
		/// <inheritdoc />
		public string NormativeVersion => NORMATIVE_VERSION;
				
		/// <inheritdoc />
		public string DeprecatedVersion => DEPRECATED_VERSION;
		
		/// <inheritdoc />
		/// <remarks>
		/// Original Type: EAID_8548C620_467A_4f50_9A22_58D84B7E8779
		/// </remarks>
		public Type Generalization => typeof(Mtconnect.DeviceInformationModel.Components.ComponentGeneralization);

		/// <inheritdoc />
		public new DeviceClassProperties Properties { get; } = new DeviceClassProperties();
        IPropertyList IClass.Properties => Properties;
		/// <summary>
		/// Property list for <see cref="DeviceClass" />.
		/// <br/><b>Note</b>, some properties (<see cref="IProperty" />) are inherited from <see cref="Mtconnect.DeviceInformationModel.Components.ComponentGeneralization.ComponentGeneralizationProperties" />.
		/// </summary>
		public class DeviceClassProperties : Mtconnect.DeviceInformationModel.Components.ComponentGeneralization.ComponentGeneralizationProperties
		{
			/// <inheritdoc />
			public override IProperty[] Properties => new IProperty[] {
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
			public new HasAuxiliaryPartProperty HasAuxiliaryPart { get; } = new HasAuxiliaryPartProperty();
			
			/// <summary>﻿
			/// </summary>
			public new sealed class HasAuxiliaryPartProperty : IProperty
			{
				/// <summary>Constant value for <see cref="HasAuxiliaryPartProperty.Name" /></summary>
				public const string NAME = "hasAuxiliary";
				/// <summary>Constant value for <see cref="HasAuxiliaryPartProperty.Summary" /></summary>
				public const string SUMMARY = @"";
				/// <summary>Constant value for <see cref="HasAuxiliaryPartProperty.AccessModifier" /></summary>
				public const string ACCESS_MODIFIER = "public";
				/// <summary>Constant value for <see cref="HasAuxiliaryPartProperty.Modifier" /></summary>
				public const string MODIFIER = "";
				/// <summary>Constant value for <see cref="HasAuxiliaryPartProperty.NormativeVersion" /></summary>
				public const string NORMATIVE_VERSION = "";
				/// <summary>Constant value for <see cref="HasAuxiliaryPartProperty.DeprecatedVersion" /></summary>
				public const string DEPRECATED_VERSION = "";
				/// <summary>Constant value for <see cref="HasAuxiliaryPartProperty.Aggregation" /></summary>
				public const string AGGREGATION = "composite";
				/// <summary>Constant value for <see cref="HasAuxiliaryPartProperty.Extension" /></summary>
				public const string EXTENSION = "";
				/// <summary>Constant value for <see cref="HasAuxiliaryPartProperty.Association" /></summary>
				public const string ASSOCIATION = "AuxiliariesClass";
				/// <summary>Constant value for <see cref="HasAuxiliaryPartProperty.DefaultValue" /></summary>
				public const string DEFAULT_VALUE = "";

				/// <summary>
				/// <inheritdoc />
				/// <remarks> Type: AuxiliaryClass </remarks>
				/// </summary>
				public System.Type Type => typeof(Mtconnect.DeviceInformationModel.Components.ComponentTypes.AuxiliaryClass);
				
				/// <inheritdoc />
				public string Name => NAME;
				
				/// <inheritdoc />
				public string Summary => SUMMARY;

				/// <inheritdoc />
				public string AccessModifier => ACCESS_MODIFIER;
				
				/// <inheritdoc />
				public string Modifier => MODIFIER;
				
				/// <inheritdoc />
				public string NormativeVersion => NORMATIVE_VERSION;
				
				/// <inheritdoc />
				public string DeprecatedVersion => DEPRECATED_VERSION;
				
				/// <inheritdoc />
				public string Aggregation => AGGREGATION;

				// Note: Extension.Extender
				/// <inheritdoc />
				public string Extension => EXTENSION;
				
				/// <inheritdoc />
				public string Association => ASSOCIATION;

				// Note: DefaultValue.Name
				/// <inheritdoc />
				public string DefaultValue => DEFAULT_VALUE;
			}
			/// <summary>
			/// <inheritdoc cref="HasControllerPartProperty" path="/summary" /><br/>
			/// <remarks>Original Name: HasController</remarks>
			/// </summary>
			public new HasControllerPartProperty HasControllerPart { get; } = new HasControllerPartProperty();
			
			/// <summary>﻿
			/// </summary>
			public new sealed class HasControllerPartProperty : IProperty
			{
				/// <summary>Constant value for <see cref="HasControllerPartProperty.Name" /></summary>
				public const string NAME = "hasController";
				/// <summary>Constant value for <see cref="HasControllerPartProperty.Summary" /></summary>
				public const string SUMMARY = @"";
				/// <summary>Constant value for <see cref="HasControllerPartProperty.AccessModifier" /></summary>
				public const string ACCESS_MODIFIER = "public";
				/// <summary>Constant value for <see cref="HasControllerPartProperty.Modifier" /></summary>
				public const string MODIFIER = "";
				/// <summary>Constant value for <see cref="HasControllerPartProperty.NormativeVersion" /></summary>
				public const string NORMATIVE_VERSION = "";
				/// <summary>Constant value for <see cref="HasControllerPartProperty.DeprecatedVersion" /></summary>
				public const string DEPRECATED_VERSION = "";
				/// <summary>Constant value for <see cref="HasControllerPartProperty.Aggregation" /></summary>
				public const string AGGREGATION = "composite";
				/// <summary>Constant value for <see cref="HasControllerPartProperty.Extension" /></summary>
				public const string EXTENSION = "";
				/// <summary>Constant value for <see cref="HasControllerPartProperty.Association" /></summary>
				public const string ASSOCIATION = "ControllersClass";
				/// <summary>Constant value for <see cref="HasControllerPartProperty.DefaultValue" /></summary>
				public const string DEFAULT_VALUE = "";

				/// <summary>
				/// <inheritdoc />
				/// <remarks> Type: ControllerClass </remarks>
				/// </summary>
				public System.Type Type => typeof(Mtconnect.DeviceInformationModel.Components.ComponentTypes.ControllerClass);
				
				/// <inheritdoc />
				public string Name => NAME;
				
				/// <inheritdoc />
				public string Summary => SUMMARY;

				/// <inheritdoc />
				public string AccessModifier => ACCESS_MODIFIER;
				
				/// <inheritdoc />
				public string Modifier => MODIFIER;
				
				/// <inheritdoc />
				public string NormativeVersion => NORMATIVE_VERSION;
				
				/// <inheritdoc />
				public string DeprecatedVersion => DEPRECATED_VERSION;
				
				/// <inheritdoc />
				public string Aggregation => AGGREGATION;

				// Note: Extension.Extender
				/// <inheritdoc />
				public string Extension => EXTENSION;
				
				/// <inheritdoc />
				public string Association => ASSOCIATION;

				// Note: DefaultValue.Name
				/// <inheritdoc />
				public string DefaultValue => DEFAULT_VALUE;
			}
			/// <summary>
			/// <inheritdoc cref="HasInterfacePartProperty" path="/summary" /><br/>
			/// <remarks>Original Name: HasInterface</remarks>
			/// </summary>
			public new HasInterfacePartProperty HasInterfacePart { get; } = new HasInterfacePartProperty();
			
			/// <summary>﻿
			/// </summary>
			public new sealed class HasInterfacePartProperty : IProperty
			{
				/// <summary>Constant value for <see cref="HasInterfacePartProperty.Name" /></summary>
				public const string NAME = "hasInterface";
				/// <summary>Constant value for <see cref="HasInterfacePartProperty.Summary" /></summary>
				public const string SUMMARY = @"";
				/// <summary>Constant value for <see cref="HasInterfacePartProperty.AccessModifier" /></summary>
				public const string ACCESS_MODIFIER = "public";
				/// <summary>Constant value for <see cref="HasInterfacePartProperty.Modifier" /></summary>
				public const string MODIFIER = "";
				/// <summary>Constant value for <see cref="HasInterfacePartProperty.NormativeVersion" /></summary>
				public const string NORMATIVE_VERSION = "";
				/// <summary>Constant value for <see cref="HasInterfacePartProperty.DeprecatedVersion" /></summary>
				public const string DEPRECATED_VERSION = "";
				/// <summary>Constant value for <see cref="HasInterfacePartProperty.Aggregation" /></summary>
				public const string AGGREGATION = "composite";
				/// <summary>Constant value for <see cref="HasInterfacePartProperty.Extension" /></summary>
				public const string EXTENSION = "";
				/// <summary>Constant value for <see cref="HasInterfacePartProperty.Association" /></summary>
				public const string ASSOCIATION = "InterfacesClass";
				/// <summary>Constant value for <see cref="HasInterfacePartProperty.DefaultValue" /></summary>
				public const string DEFAULT_VALUE = "";

				/// <summary>
				/// <inheritdoc />
				/// <remarks> Type: InterfaceClass </remarks>
				/// </summary>
				public System.Type Type => typeof(Mtconnect.InterfaceInteractionModel.InterfaceClass);
				
				/// <inheritdoc />
				public string Name => NAME;
				
				/// <inheritdoc />
				public string Summary => SUMMARY;

				/// <inheritdoc />
				public string AccessModifier => ACCESS_MODIFIER;
				
				/// <inheritdoc />
				public string Modifier => MODIFIER;
				
				/// <inheritdoc />
				public string NormativeVersion => NORMATIVE_VERSION;
				
				/// <inheritdoc />
				public string DeprecatedVersion => DEPRECATED_VERSION;
				
				/// <inheritdoc />
				public string Aggregation => AGGREGATION;

				// Note: Extension.Extender
				/// <inheritdoc />
				public string Extension => EXTENSION;
				
				/// <inheritdoc />
				public string Association => ASSOCIATION;

				// Note: DefaultValue.Name
				/// <inheritdoc />
				public string DefaultValue => DEFAULT_VALUE;
			}
			/// <summary>
			/// <inheritdoc cref="HasResourcePartProperty" path="/summary" /><br/>
			/// <remarks>Original Name: HasResource</remarks>
			/// </summary>
			public new HasResourcePartProperty HasResourcePart { get; } = new HasResourcePartProperty();
			
			/// <summary>﻿
			/// </summary>
			public new sealed class HasResourcePartProperty : IProperty
			{
				/// <summary>Constant value for <see cref="HasResourcePartProperty.Name" /></summary>
				public const string NAME = "hasResource";
				/// <summary>Constant value for <see cref="HasResourcePartProperty.Summary" /></summary>
				public const string SUMMARY = @"";
				/// <summary>Constant value for <see cref="HasResourcePartProperty.AccessModifier" /></summary>
				public const string ACCESS_MODIFIER = "public";
				/// <summary>Constant value for <see cref="HasResourcePartProperty.Modifier" /></summary>
				public const string MODIFIER = "";
				/// <summary>Constant value for <see cref="HasResourcePartProperty.NormativeVersion" /></summary>
				public const string NORMATIVE_VERSION = "";
				/// <summary>Constant value for <see cref="HasResourcePartProperty.DeprecatedVersion" /></summary>
				public const string DEPRECATED_VERSION = "";
				/// <summary>Constant value for <see cref="HasResourcePartProperty.Aggregation" /></summary>
				public const string AGGREGATION = "composite";
				/// <summary>Constant value for <see cref="HasResourcePartProperty.Extension" /></summary>
				public const string EXTENSION = "";
				/// <summary>Constant value for <see cref="HasResourcePartProperty.Association" /></summary>
				public const string ASSOCIATION = "ResourcesClass";
				/// <summary>Constant value for <see cref="HasResourcePartProperty.DefaultValue" /></summary>
				public const string DEFAULT_VALUE = "";

				/// <summary>
				/// <inheritdoc />
				/// <remarks> Type: ResourceClass </remarks>
				/// </summary>
				public System.Type Type => typeof(Mtconnect.DeviceInformationModel.Components.ComponentTypes.ResourceClass);
				
				/// <inheritdoc />
				public string Name => NAME;
				
				/// <inheritdoc />
				public string Summary => SUMMARY;

				/// <inheritdoc />
				public string AccessModifier => ACCESS_MODIFIER;
				
				/// <inheritdoc />
				public string Modifier => MODIFIER;
				
				/// <inheritdoc />
				public string NormativeVersion => NORMATIVE_VERSION;
				
				/// <inheritdoc />
				public string DeprecatedVersion => DEPRECATED_VERSION;
				
				/// <inheritdoc />
				public string Aggregation => AGGREGATION;

				// Note: Extension.Extender
				/// <inheritdoc />
				public string Extension => EXTENSION;
				
				/// <inheritdoc />
				public string Association => ASSOCIATION;

				// Note: DefaultValue.Name
				/// <inheritdoc />
				public string DefaultValue => DEFAULT_VALUE;
			}
			/// <summary>
			/// <inheritdoc cref="HasStructurePartProperty" path="/summary" /><br/>
			/// <remarks>Original Name: HasStructure</remarks>
			/// </summary>
			public new HasStructurePartProperty HasStructurePart { get; } = new HasStructurePartProperty();
			
			/// <summary>﻿
			/// </summary>
			public new sealed class HasStructurePartProperty : IProperty
			{
				/// <summary>Constant value for <see cref="HasStructurePartProperty.Name" /></summary>
				public const string NAME = "hasStructure";
				/// <summary>Constant value for <see cref="HasStructurePartProperty.Summary" /></summary>
				public const string SUMMARY = @"";
				/// <summary>Constant value for <see cref="HasStructurePartProperty.AccessModifier" /></summary>
				public const string ACCESS_MODIFIER = "public";
				/// <summary>Constant value for <see cref="HasStructurePartProperty.Modifier" /></summary>
				public const string MODIFIER = "";
				/// <summary>Constant value for <see cref="HasStructurePartProperty.NormativeVersion" /></summary>
				public const string NORMATIVE_VERSION = "";
				/// <summary>Constant value for <see cref="HasStructurePartProperty.DeprecatedVersion" /></summary>
				public const string DEPRECATED_VERSION = "";
				/// <summary>Constant value for <see cref="HasStructurePartProperty.Aggregation" /></summary>
				public const string AGGREGATION = "composite";
				/// <summary>Constant value for <see cref="HasStructurePartProperty.Extension" /></summary>
				public const string EXTENSION = "";
				/// <summary>Constant value for <see cref="HasStructurePartProperty.Association" /></summary>
				public const string ASSOCIATION = "StructuresClass";
				/// <summary>Constant value for <see cref="HasStructurePartProperty.DefaultValue" /></summary>
				public const string DEFAULT_VALUE = "";

				/// <summary>
				/// <inheritdoc />
				/// <remarks> Type: StructureClass </remarks>
				/// </summary>
				public System.Type Type => typeof(Mtconnect.DeviceInformationModel.Components.ComponentTypes.StructureClass);
				
				/// <inheritdoc />
				public string Name => NAME;
				
				/// <inheritdoc />
				public string Summary => SUMMARY;

				/// <inheritdoc />
				public string AccessModifier => ACCESS_MODIFIER;
				
				/// <inheritdoc />
				public string Modifier => MODIFIER;
				
				/// <inheritdoc />
				public string NormativeVersion => NORMATIVE_VERSION;
				
				/// <inheritdoc />
				public string DeprecatedVersion => DEPRECATED_VERSION;
				
				/// <inheritdoc />
				public string Aggregation => AGGREGATION;

				// Note: Extension.Extender
				/// <inheritdoc />
				public string Extension => EXTENSION;
				
				/// <inheritdoc />
				public string Association => ASSOCIATION;

				// Note: DefaultValue.Name
				/// <inheritdoc />
				public string DefaultValue => DEFAULT_VALUE;
			}
			/// <summary>
			/// <inheritdoc cref="Iso841ClassProperty" path="/summary" /><br/>
			/// <remarks>Original Name: Iso841Class</remarks>
			/// </summary>
			public new Iso841ClassProperty Iso841Class { get; } = new Iso841ClassProperty();
			
			/// <summary>﻿<b>DEPRECATED</b> in <i>MTConnect Version 1.2</i>.<br /><br /><br />
			/// </summary>
			public new sealed class Iso841ClassProperty : IProperty
			{
				/// <summary>Constant value for <see cref="Iso841ClassProperty.Name" /></summary>
				public const string NAME = "iso841Class";
				/// <summary>Constant value for <see cref="Iso841ClassProperty.Summary" /></summary>
				public const string SUMMARY = @"&#10;&#10;&#10;**DEPRECATED** in *MTConnect Version 1.2*.&#10;
";
				/// <summary>Constant value for <see cref="Iso841ClassProperty.AccessModifier" /></summary>
				public const string ACCESS_MODIFIER = "public";
				/// <summary>Constant value for <see cref="Iso841ClassProperty.Modifier" /></summary>
				public const string MODIFIER = "";
				/// <summary>Constant value for <see cref="Iso841ClassProperty.NormativeVersion" /></summary>
				public const string NORMATIVE_VERSION = "1.0";
				/// <summary>Constant value for <see cref="Iso841ClassProperty.DeprecatedVersion" /></summary>
				public const string DEPRECATED_VERSION = "1.2";
				/// <summary>Constant value for <see cref="Iso841ClassProperty.Aggregation" /></summary>
				public const string AGGREGATION = "";
				/// <summary>Constant value for <see cref="Iso841ClassProperty.Extension" /></summary>
				public const string EXTENSION = "MagicDraw UML 2024x";
				/// <summary>Constant value for <see cref="Iso841ClassProperty.Association" /></summary>
				public const string ASSOCIATION = "";
				/// <summary>Constant value for <see cref="Iso841ClassProperty.DefaultValue" /></summary>
				public const string DEFAULT_VALUE = "";

				/// <summary>
				/// <inheritdoc />
				/// <remarks> Type: String </remarks>
				/// </summary>
				public System.Type Type => typeof(String);
				
				/// <inheritdoc />
				public string Name => NAME;
				
				/// <inheritdoc />
				public string Summary => SUMMARY;

				/// <inheritdoc />
				public string AccessModifier => ACCESS_MODIFIER;
				
				/// <inheritdoc />
				public string Modifier => MODIFIER;
				
				/// <inheritdoc />
				public string NormativeVersion => NORMATIVE_VERSION;
				
				/// <inheritdoc />
				public string DeprecatedVersion => DEPRECATED_VERSION;
				
				/// <inheritdoc />
				public string Aggregation => AGGREGATION;

				// Note: Extension.Extender
				/// <inheritdoc />
				public string Extension => EXTENSION;
				
				/// <inheritdoc />
				public string Association => ASSOCIATION;

				// Note: DefaultValue.Name
				/// <inheritdoc />
				public string DefaultValue => DEFAULT_VALUE;
			}
			/// <summary>
			/// <inheritdoc cref="UuidProperty" path="/summary" /><br/>
			/// <remarks>Original Name: Uuid</remarks>
			/// </summary>
			public new UuidProperty Uuid { get; } = new UuidProperty();
			
			/// <summary>﻿universally unique identifier for the element.<br /><br /><br />
			/// </summary>
			public new sealed class UuidProperty : IProperty
			{
				/// <summary>Constant value for <see cref="UuidProperty.Name" /></summary>
				public const string NAME = "uuid";
				/// <summary>Constant value for <see cref="UuidProperty.Summary" /></summary>
				public const string SUMMARY = @"&#10;&#10;&#10;universally unique identifier for the element.&#10;
";
				/// <summary>Constant value for <see cref="UuidProperty.AccessModifier" /></summary>
				public const string ACCESS_MODIFIER = "public";
				/// <summary>Constant value for <see cref="UuidProperty.Modifier" /></summary>
				public const string MODIFIER = "";
				/// <summary>Constant value for <see cref="UuidProperty.NormativeVersion" /></summary>
				public const string NORMATIVE_VERSION = "1.0";
				/// <summary>Constant value for <see cref="UuidProperty.DeprecatedVersion" /></summary>
				public const string DEPRECATED_VERSION = "";
				/// <summary>Constant value for <see cref="UuidProperty.Aggregation" /></summary>
				public const string AGGREGATION = "";
				/// <summary>Constant value for <see cref="UuidProperty.Extension" /></summary>
				public const string EXTENSION = "MagicDraw UML 2024x";
				/// <summary>Constant value for <see cref="UuidProperty.Association" /></summary>
				public const string ASSOCIATION = "";
				/// <summary>Constant value for <see cref="UuidProperty.DefaultValue" /></summary>
				public const string DEFAULT_VALUE = "";

				/// <summary>
				/// <inheritdoc />
				/// <remarks> Type: Object </remarks>
				/// </summary>
				public System.Type Type => typeof(object);
				
				/// <inheritdoc />
				public string Name => NAME;
				
				/// <inheritdoc />
				public string Summary => SUMMARY;

				/// <inheritdoc />
				public string AccessModifier => ACCESS_MODIFIER;
				
				/// <inheritdoc />
				public string Modifier => MODIFIER;
				
				/// <inheritdoc />
				public string NormativeVersion => NORMATIVE_VERSION;
				
				/// <inheritdoc />
				public string DeprecatedVersion => DEPRECATED_VERSION;
				
				/// <inheritdoc />
				public string Aggregation => AGGREGATION;

				// Note: Extension.Extender
				/// <inheritdoc />
				public string Extension => EXTENSION;
				
				/// <inheritdoc />
				public string Association => ASSOCIATION;

				// Note: DefaultValue.Name
				/// <inheritdoc />
				public string DefaultValue => DEFAULT_VALUE;
			}
			/// <summary>
			/// <inheritdoc cref="MtconnectVersionProperty" path="/summary" /><br/>
			/// <remarks>Original Name: MtconnectVersion</remarks>
			/// </summary>
			public new MtconnectVersionProperty MtconnectVersion { get; } = new MtconnectVersionProperty();
			
			/// <summary>﻿MTConnect version of the <i>Device Information Model</i> used to configure the information to be published for a piece of equipment in an <i>MTConnect Response Document</i>.<br /><br /><br />
			/// </summary>
			public new sealed class MtconnectVersionProperty : IProperty
			{
				/// <summary>Constant value for <see cref="MtconnectVersionProperty.Name" /></summary>
				public const string NAME = "mtconnectVersion";
				/// <summary>Constant value for <see cref="MtconnectVersionProperty.Summary" /></summary>
				public const string SUMMARY = @"&#10;&#10;&#10;MTConnect version of the {{term(Device Information Model)}} used to configure the information to be published for a piece of equipment in an {{term(MTConnect Response Document)}}.&#10;
";
				/// <summary>Constant value for <see cref="MtconnectVersionProperty.AccessModifier" /></summary>
				public const string ACCESS_MODIFIER = "public";
				/// <summary>Constant value for <see cref="MtconnectVersionProperty.Modifier" /></summary>
				public const string MODIFIER = "";
				/// <summary>Constant value for <see cref="MtconnectVersionProperty.NormativeVersion" /></summary>
				public const string NORMATIVE_VERSION = "1.7";
				/// <summary>Constant value for <see cref="MtconnectVersionProperty.DeprecatedVersion" /></summary>
				public const string DEPRECATED_VERSION = "";
				/// <summary>Constant value for <see cref="MtconnectVersionProperty.Aggregation" /></summary>
				public const string AGGREGATION = "composite";
				/// <summary>Constant value for <see cref="MtconnectVersionProperty.Extension" /></summary>
				public const string EXTENSION = "MagicDraw UML 2024x";
				/// <summary>Constant value for <see cref="MtconnectVersionProperty.Association" /></summary>
				public const string ASSOCIATION = "";
				/// <summary>Constant value for <see cref="MtconnectVersionProperty.DefaultValue" /></summary>
				public const string DEFAULT_VALUE = "";

				/// <summary>
				/// <inheritdoc />
				/// <remarks> Type: String </remarks>
				/// </summary>
				public System.Type Type => typeof(String);
				
				/// <inheritdoc />
				public string Name => NAME;
				
				/// <inheritdoc />
				public string Summary => SUMMARY;

				/// <inheritdoc />
				public string AccessModifier => ACCESS_MODIFIER;
				
				/// <inheritdoc />
				public string Modifier => MODIFIER;
				
				/// <inheritdoc />
				public string NormativeVersion => NORMATIVE_VERSION;
				
				/// <inheritdoc />
				public string DeprecatedVersion => DEPRECATED_VERSION;
				
				/// <inheritdoc />
				public string Aggregation => AGGREGATION;

				// Note: Extension.Extender
				/// <inheritdoc />
				public string Extension => EXTENSION;
				
				/// <inheritdoc />
				public string Association => ASSOCIATION;

				// Note: DefaultValue.Name
				/// <inheritdoc />
				public string DefaultValue => DEFAULT_VALUE;
			}
			/// <summary>
			/// <inheritdoc cref="HasSystemPartProperty" path="/summary" /><br/>
			/// <remarks>Original Name: HasSystem</remarks>
			/// </summary>
			public new HasSystemPartProperty HasSystemPart { get; } = new HasSystemPartProperty();
			
			/// <summary>﻿
			/// </summary>
			public new sealed class HasSystemPartProperty : IProperty
			{
				/// <summary>Constant value for <see cref="HasSystemPartProperty.Name" /></summary>
				public const string NAME = "hasSystem";
				/// <summary>Constant value for <see cref="HasSystemPartProperty.Summary" /></summary>
				public const string SUMMARY = @"";
				/// <summary>Constant value for <see cref="HasSystemPartProperty.AccessModifier" /></summary>
				public const string ACCESS_MODIFIER = "public";
				/// <summary>Constant value for <see cref="HasSystemPartProperty.Modifier" /></summary>
				public const string MODIFIER = "";
				/// <summary>Constant value for <see cref="HasSystemPartProperty.NormativeVersion" /></summary>
				public const string NORMATIVE_VERSION = "";
				/// <summary>Constant value for <see cref="HasSystemPartProperty.DeprecatedVersion" /></summary>
				public const string DEPRECATED_VERSION = "";
				/// <summary>Constant value for <see cref="HasSystemPartProperty.Aggregation" /></summary>
				public const string AGGREGATION = "composite";
				/// <summary>Constant value for <see cref="HasSystemPartProperty.Extension" /></summary>
				public const string EXTENSION = "";
				/// <summary>Constant value for <see cref="HasSystemPartProperty.Association" /></summary>
				public const string ASSOCIATION = "SystemsClass";
				/// <summary>Constant value for <see cref="HasSystemPartProperty.DefaultValue" /></summary>
				public const string DEFAULT_VALUE = "";

				/// <summary>
				/// <inheritdoc />
				/// <remarks> Type: SystemClass </remarks>
				/// </summary>
				public System.Type Type => typeof(Mtconnect.DeviceInformationModel.Components.ComponentTypes.SystemClass);
				
				/// <inheritdoc />
				public string Name => NAME;
				
				/// <inheritdoc />
				public string Summary => SUMMARY;

				/// <inheritdoc />
				public string AccessModifier => ACCESS_MODIFIER;
				
				/// <inheritdoc />
				public string Modifier => MODIFIER;
				
				/// <inheritdoc />
				public string NormativeVersion => NORMATIVE_VERSION;
				
				/// <inheritdoc />
				public string DeprecatedVersion => DEPRECATED_VERSION;
				
				/// <inheritdoc />
				public string Aggregation => AGGREGATION;

				// Note: Extension.Extender
				/// <inheritdoc />
				public string Extension => EXTENSION;
				
				/// <inheritdoc />
				public string Association => ASSOCIATION;

				// Note: DefaultValue.Name
				/// <inheritdoc />
				public string DefaultValue => DEFAULT_VALUE;
			}
			/// <summary>
			/// <inheritdoc cref="NameProperty" path="/summary" /><br/>
			/// <remarks>Original Name: Name</remarks>
			/// </summary>
			public new NameProperty Name { get; } = new NameProperty();
			
			/// <summary>﻿name of an element or a piece of equipment.<br /><br /><br />
			/// </summary>
			public new sealed class NameProperty : IProperty
			{
				/// <summary>Constant value for <see cref="NameProperty.Name" /></summary>
				public const string NAME = "name";
				/// <summary>Constant value for <see cref="NameProperty.Summary" /></summary>
				public const string SUMMARY = @"&#10;&#10;&#10;name of an element or a piece of equipment.&#10;
";
				/// <summary>Constant value for <see cref="NameProperty.AccessModifier" /></summary>
				public const string ACCESS_MODIFIER = "public";
				/// <summary>Constant value for <see cref="NameProperty.Modifier" /></summary>
				public const string MODIFIER = "";
				/// <summary>Constant value for <see cref="NameProperty.NormativeVersion" /></summary>
				public const string NORMATIVE_VERSION = "1.0";
				/// <summary>Constant value for <see cref="NameProperty.DeprecatedVersion" /></summary>
				public const string DEPRECATED_VERSION = "";
				/// <summary>Constant value for <see cref="NameProperty.Aggregation" /></summary>
				public const string AGGREGATION = "";
				/// <summary>Constant value for <see cref="NameProperty.Extension" /></summary>
				public const string EXTENSION = "MagicDraw UML 2024x";
				/// <summary>Constant value for <see cref="NameProperty.Association" /></summary>
				public const string ASSOCIATION = "";
				/// <summary>Constant value for <see cref="NameProperty.DefaultValue" /></summary>
				public const string DEFAULT_VALUE = "";

				/// <summary>
				/// <inheritdoc />
				/// <remarks> Type: String </remarks>
				/// </summary>
				public System.Type Type => typeof(String);
				
				/// <inheritdoc />
				public string Name => NAME;
				
				/// <inheritdoc />
				public string Summary => SUMMARY;

				/// <inheritdoc />
				public string AccessModifier => ACCESS_MODIFIER;
				
				/// <inheritdoc />
				public string Modifier => MODIFIER;
				
				/// <inheritdoc />
				public string NormativeVersion => NORMATIVE_VERSION;
				
				/// <inheritdoc />
				public string DeprecatedVersion => DEPRECATED_VERSION;
				
				/// <inheritdoc />
				public string Aggregation => AGGREGATION;

				// Note: Extension.Extender
				/// <inheritdoc />
				public string Extension => EXTENSION;
				
				/// <inheritdoc />
				public string Association => ASSOCIATION;

				// Note: DefaultValue.Name
				/// <inheritdoc />
				public string DefaultValue => DEFAULT_VALUE;
			}
			/// <summary>
			/// <inheritdoc cref="HasPartPartProperty" path="/summary" /><br/>
			/// <remarks>Original Name: HasPart</remarks>
			/// </summary>
			public new HasPartPartProperty HasPartPart { get; } = new HasPartPartProperty();
			
			/// <summary>﻿
			/// </summary>
			public new sealed class HasPartPartProperty : IProperty
			{
				/// <summary>Constant value for <see cref="HasPartPartProperty.Name" /></summary>
				public const string NAME = "hasPart";
				/// <summary>Constant value for <see cref="HasPartPartProperty.Summary" /></summary>
				public const string SUMMARY = @"";
				/// <summary>Constant value for <see cref="HasPartPartProperty.AccessModifier" /></summary>
				public const string ACCESS_MODIFIER = "private";
				/// <summary>Constant value for <see cref="HasPartPartProperty.Modifier" /></summary>
				public const string MODIFIER = "";
				/// <summary>Constant value for <see cref="HasPartPartProperty.NormativeVersion" /></summary>
				public const string NORMATIVE_VERSION = "";
				/// <summary>Constant value for <see cref="HasPartPartProperty.DeprecatedVersion" /></summary>
				public const string DEPRECATED_VERSION = "";
				/// <summary>Constant value for <see cref="HasPartPartProperty.Aggregation" /></summary>
				public const string AGGREGATION = "composite";
				/// <summary>Constant value for <see cref="HasPartPartProperty.Extension" /></summary>
				public const string EXTENSION = "";
				/// <summary>Constant value for <see cref="HasPartPartProperty.Association" /></summary>
				public const string ASSOCIATION = "PartsClass";
				/// <summary>Constant value for <see cref="HasPartPartProperty.DefaultValue" /></summary>
				public const string DEFAULT_VALUE = "";

				/// <summary>
				/// <inheritdoc />
				/// <remarks> Type: PartClass </remarks>
				/// </summary>
				public System.Type Type => typeof(Mtconnect.DeviceInformationModel.Components.ComponentTypes.PartClass);
				
				/// <inheritdoc />
				public string Name => NAME;
				
				/// <inheritdoc />
				public string Summary => SUMMARY;

				/// <inheritdoc />
				public string AccessModifier => ACCESS_MODIFIER;
				
				/// <inheritdoc />
				public string Modifier => MODIFIER;
				
				/// <inheritdoc />
				public string NormativeVersion => NORMATIVE_VERSION;
				
				/// <inheritdoc />
				public string DeprecatedVersion => DEPRECATED_VERSION;
				
				/// <inheritdoc />
				public string Aggregation => AGGREGATION;

				// Note: Extension.Extender
				/// <inheritdoc />
				public string Extension => EXTENSION;
				
				/// <inheritdoc />
				public string Association => ASSOCIATION;

				// Note: DefaultValue.Name
				/// <inheritdoc />
				public string DefaultValue => DEFAULT_VALUE;
			}
			/// <summary>
			/// <inheritdoc cref="HasProcessPartProperty" path="/summary" /><br/>
			/// <remarks>Original Name: HasProcess</remarks>
			/// </summary>
			public new HasProcessPartProperty HasProcessPart { get; } = new HasProcessPartProperty();
			
			/// <summary>﻿
			/// </summary>
			public new sealed class HasProcessPartProperty : IProperty
			{
				/// <summary>Constant value for <see cref="HasProcessPartProperty.Name" /></summary>
				public const string NAME = "hasProcess";
				/// <summary>Constant value for <see cref="HasProcessPartProperty.Summary" /></summary>
				public const string SUMMARY = @"";
				/// <summary>Constant value for <see cref="HasProcessPartProperty.AccessModifier" /></summary>
				public const string ACCESS_MODIFIER = "private";
				/// <summary>Constant value for <see cref="HasProcessPartProperty.Modifier" /></summary>
				public const string MODIFIER = "";
				/// <summary>Constant value for <see cref="HasProcessPartProperty.NormativeVersion" /></summary>
				public const string NORMATIVE_VERSION = "";
				/// <summary>Constant value for <see cref="HasProcessPartProperty.DeprecatedVersion" /></summary>
				public const string DEPRECATED_VERSION = "";
				/// <summary>Constant value for <see cref="HasProcessPartProperty.Aggregation" /></summary>
				public const string AGGREGATION = "composite";
				/// <summary>Constant value for <see cref="HasProcessPartProperty.Extension" /></summary>
				public const string EXTENSION = "";
				/// <summary>Constant value for <see cref="HasProcessPartProperty.Association" /></summary>
				public const string ASSOCIATION = "ProcessesClass";
				/// <summary>Constant value for <see cref="HasProcessPartProperty.DefaultValue" /></summary>
				public const string DEFAULT_VALUE = "";

				/// <summary>
				/// <inheritdoc />
				/// <remarks> Type: ProcessClass </remarks>
				/// </summary>
				public System.Type Type => typeof(Mtconnect.DeviceInformationModel.Components.ComponentTypes.ProcessClass);
				
				/// <inheritdoc />
				public string Name => NAME;
				
				/// <inheritdoc />
				public string Summary => SUMMARY;

				/// <inheritdoc />
				public string AccessModifier => ACCESS_MODIFIER;
				
				/// <inheritdoc />
				public string Modifier => MODIFIER;
				
				/// <inheritdoc />
				public string NormativeVersion => NORMATIVE_VERSION;
				
				/// <inheritdoc />
				public string DeprecatedVersion => DEPRECATED_VERSION;
				
				/// <inheritdoc />
				public string Aggregation => AGGREGATION;

				// Note: Extension.Extender
				/// <inheritdoc />
				public string Extension => EXTENSION;
				
				/// <inheritdoc />
				public string Association => ASSOCIATION;

				// Note: DefaultValue.Name
				/// <inheritdoc />
				public string DefaultValue => DEFAULT_VALUE;
			}
			/// <summary>
			/// <inheritdoc cref="HasAxisPartProperty" path="/summary" /><br/>
			/// <remarks>Original Name: HasAxis</remarks>
			/// </summary>
			public new HasAxisPartProperty HasAxisPart { get; } = new HasAxisPartProperty();
			
			/// <summary>﻿
			/// </summary>
			public new sealed class HasAxisPartProperty : IProperty
			{
				/// <summary>Constant value for <see cref="HasAxisPartProperty.Name" /></summary>
				public const string NAME = "hasAxis";
				/// <summary>Constant value for <see cref="HasAxisPartProperty.Summary" /></summary>
				public const string SUMMARY = @"";
				/// <summary>Constant value for <see cref="HasAxisPartProperty.AccessModifier" /></summary>
				public const string ACCESS_MODIFIER = "public";
				/// <summary>Constant value for <see cref="HasAxisPartProperty.Modifier" /></summary>
				public const string MODIFIER = "";
				/// <summary>Constant value for <see cref="HasAxisPartProperty.NormativeVersion" /></summary>
				public const string NORMATIVE_VERSION = "";
				/// <summary>Constant value for <see cref="HasAxisPartProperty.DeprecatedVersion" /></summary>
				public const string DEPRECATED_VERSION = "";
				/// <summary>Constant value for <see cref="HasAxisPartProperty.Aggregation" /></summary>
				public const string AGGREGATION = "composite";
				/// <summary>Constant value for <see cref="HasAxisPartProperty.Extension" /></summary>
				public const string EXTENSION = "";
				/// <summary>Constant value for <see cref="HasAxisPartProperty.Association" /></summary>
				public const string ASSOCIATION = "AxesClass";
				/// <summary>Constant value for <see cref="HasAxisPartProperty.DefaultValue" /></summary>
				public const string DEFAULT_VALUE = "";

				/// <summary>
				/// <inheritdoc />
				/// <remarks> Type: AxisClass </remarks>
				/// </summary>
				public System.Type Type => typeof(Mtconnect.DeviceInformationModel.Components.ComponentTypes.AxisClass);
				
				/// <inheritdoc />
				public string Name => NAME;
				
				/// <inheritdoc />
				public string Summary => SUMMARY;

				/// <inheritdoc />
				public string AccessModifier => ACCESS_MODIFIER;
				
				/// <inheritdoc />
				public string Modifier => MODIFIER;
				
				/// <inheritdoc />
				public string NormativeVersion => NORMATIVE_VERSION;
				
				/// <inheritdoc />
				public string DeprecatedVersion => DEPRECATED_VERSION;
				
				/// <inheritdoc />
				public string Aggregation => AGGREGATION;

				// Note: Extension.Extender
				/// <inheritdoc />
				public string Extension => EXTENSION;
				
				/// <inheritdoc />
				public string Association => ASSOCIATION;

				// Note: DefaultValue.Name
				/// <inheritdoc />
				public string DefaultValue => DEFAULT_VALUE;
			}
			/// <summary>
			/// <inheritdoc cref="HasAdapterPartProperty" path="/summary" /><br/>
			/// <remarks>Original Name: HasAdapter</remarks>
			/// </summary>
			public new HasAdapterPartProperty HasAdapterPart { get; } = new HasAdapterPartProperty();
			
			/// <summary>﻿
			/// </summary>
			public new sealed class HasAdapterPartProperty : IProperty
			{
				/// <summary>Constant value for <see cref="HasAdapterPartProperty.Name" /></summary>
				public const string NAME = "hasAdapter";
				/// <summary>Constant value for <see cref="HasAdapterPartProperty.Summary" /></summary>
				public const string SUMMARY = @"";
				/// <summary>Constant value for <see cref="HasAdapterPartProperty.AccessModifier" /></summary>
				public const string ACCESS_MODIFIER = "public";
				/// <summary>Constant value for <see cref="HasAdapterPartProperty.Modifier" /></summary>
				public const string MODIFIER = "";
				/// <summary>Constant value for <see cref="HasAdapterPartProperty.NormativeVersion" /></summary>
				public const string NORMATIVE_VERSION = "";
				/// <summary>Constant value for <see cref="HasAdapterPartProperty.DeprecatedVersion" /></summary>
				public const string DEPRECATED_VERSION = "";
				/// <summary>Constant value for <see cref="HasAdapterPartProperty.Aggregation" /></summary>
				public const string AGGREGATION = "composite";
				/// <summary>Constant value for <see cref="HasAdapterPartProperty.Extension" /></summary>
				public const string EXTENSION = "";
				/// <summary>Constant value for <see cref="HasAdapterPartProperty.Association" /></summary>
				public const string ASSOCIATION = "AdaptersClass";
				/// <summary>Constant value for <see cref="HasAdapterPartProperty.DefaultValue" /></summary>
				public const string DEFAULT_VALUE = "";

				/// <summary>
				/// <inheritdoc />
				/// <remarks> Type: AdapterClass </remarks>
				/// </summary>
				public System.Type Type => typeof(Mtconnect.DeviceInformationModel.Components.ComponentTypes.AdapterClass);
				
				/// <inheritdoc />
				public string Name => NAME;
				
				/// <inheritdoc />
				public string Summary => SUMMARY;

				/// <inheritdoc />
				public string AccessModifier => ACCESS_MODIFIER;
				
				/// <inheritdoc />
				public string Modifier => MODIFIER;
				
				/// <inheritdoc />
				public string NormativeVersion => NORMATIVE_VERSION;
				
				/// <inheritdoc />
				public string DeprecatedVersion => DEPRECATED_VERSION;
				
				/// <inheritdoc />
				public string Aggregation => AGGREGATION;

				// Note: Extension.Extender
				/// <inheritdoc />
				public string Extension => EXTENSION;
				
				/// <inheritdoc />
				public string Association => ASSOCIATION;

				// Note: DefaultValue.Name
				/// <inheritdoc />
				public string DefaultValue => DEFAULT_VALUE;
			}
			/// <summary>
			/// <inheritdoc cref="ObservesAvailabilityProperty" path="/summary" /><br/>
			/// <remarks>Original Name: ObservesAvailability</remarks>
			/// </summary>
			public new ObservesAvailabilityProperty ObservesAvailability { get; } = new ObservesAvailabilityProperty();
			
			/// <summary>﻿
			/// </summary>
			public new sealed class ObservesAvailabilityProperty : IProperty
			{
				/// <summary>Constant value for <see cref="ObservesAvailabilityProperty.Name" /></summary>
				public const string NAME = "observesAvailability";
				/// <summary>Constant value for <see cref="ObservesAvailabilityProperty.Summary" /></summary>
				public const string SUMMARY = @"";
				/// <summary>Constant value for <see cref="ObservesAvailabilityProperty.AccessModifier" /></summary>
				public const string ACCESS_MODIFIER = "public";
				/// <summary>Constant value for <see cref="ObservesAvailabilityProperty.Modifier" /></summary>
				public const string MODIFIER = "";
				/// <summary>Constant value for <see cref="ObservesAvailabilityProperty.NormativeVersion" /></summary>
				public const string NORMATIVE_VERSION = "";
				/// <summary>Constant value for <see cref="ObservesAvailabilityProperty.DeprecatedVersion" /></summary>
				public const string DEPRECATED_VERSION = "";
				/// <summary>Constant value for <see cref="ObservesAvailabilityProperty.Aggregation" /></summary>
				public const string AGGREGATION = "composite";
				/// <summary>Constant value for <see cref="ObservesAvailabilityProperty.Extension" /></summary>
				public const string EXTENSION = "MagicDraw UML 2024x";
				/// <summary>Constant value for <see cref="ObservesAvailabilityProperty.Association" /></summary>
				public const string ASSOCIATION = "";
				/// <summary>Constant value for <see cref="ObservesAvailabilityProperty.DefaultValue" /></summary>
				public const string DEFAULT_VALUE = "";

				/// <summary>
				/// <inheritdoc />
				/// <remarks> Type: AvailabilityClass </remarks>
				/// </summary>
				public System.Type Type => typeof(Mtconnect.ObservationInformationModel.ObservationTypes.EventTypes.AvailabilityClass);
				
				/// <inheritdoc />
				public string Name => NAME;
				
				/// <inheritdoc />
				public string Summary => SUMMARY;

				/// <inheritdoc />
				public string AccessModifier => ACCESS_MODIFIER;
				
				/// <inheritdoc />
				public string Modifier => MODIFIER;
				
				/// <inheritdoc />
				public string NormativeVersion => NORMATIVE_VERSION;
				
				/// <inheritdoc />
				public string DeprecatedVersion => DEPRECATED_VERSION;
				
				/// <inheritdoc />
				public string Aggregation => AGGREGATION;

				// Note: Extension.Extender
				/// <inheritdoc />
				public string Extension => EXTENSION;
				
				/// <inheritdoc />
				public string Association => ASSOCIATION;

				// Note: DefaultValue.Name
				/// <inheritdoc />
				public string DefaultValue => DEFAULT_VALUE;
			}
			/// <summary>
			/// <inheritdoc cref="ObservesAssetChangedProperty" path="/summary" /><br/>
			/// <remarks>Original Name: ObservesAssetChanged</remarks>
			/// </summary>
			public new ObservesAssetChangedProperty ObservesAssetChanged { get; } = new ObservesAssetChangedProperty();
			
			/// <summary>﻿
			/// </summary>
			public new sealed class ObservesAssetChangedProperty : IProperty
			{
				/// <summary>Constant value for <see cref="ObservesAssetChangedProperty.Name" /></summary>
				public const string NAME = "observesAssetChanged";
				/// <summary>Constant value for <see cref="ObservesAssetChangedProperty.Summary" /></summary>
				public const string SUMMARY = @"";
				/// <summary>Constant value for <see cref="ObservesAssetChangedProperty.AccessModifier" /></summary>
				public const string ACCESS_MODIFIER = "public";
				/// <summary>Constant value for <see cref="ObservesAssetChangedProperty.Modifier" /></summary>
				public const string MODIFIER = "";
				/// <summary>Constant value for <see cref="ObservesAssetChangedProperty.NormativeVersion" /></summary>
				public const string NORMATIVE_VERSION = "";
				/// <summary>Constant value for <see cref="ObservesAssetChangedProperty.DeprecatedVersion" /></summary>
				public const string DEPRECATED_VERSION = "";
				/// <summary>Constant value for <see cref="ObservesAssetChangedProperty.Aggregation" /></summary>
				public const string AGGREGATION = "composite";
				/// <summary>Constant value for <see cref="ObservesAssetChangedProperty.Extension" /></summary>
				public const string EXTENSION = "MagicDraw UML 2024x";
				/// <summary>Constant value for <see cref="ObservesAssetChangedProperty.Association" /></summary>
				public const string ASSOCIATION = "";
				/// <summary>Constant value for <see cref="ObservesAssetChangedProperty.DefaultValue" /></summary>
				public const string DEFAULT_VALUE = "";

				/// <summary>
				/// <inheritdoc />
				/// <remarks> Type: AssetChangedClass </remarks>
				/// </summary>
				public System.Type Type => typeof(Mtconnect.ObservationInformationModel.ObservationTypes.EventTypes.AssetChangedClass);
				
				/// <inheritdoc />
				public string Name => NAME;
				
				/// <inheritdoc />
				public string Summary => SUMMARY;

				/// <inheritdoc />
				public string AccessModifier => ACCESS_MODIFIER;
				
				/// <inheritdoc />
				public string Modifier => MODIFIER;
				
				/// <inheritdoc />
				public string NormativeVersion => NORMATIVE_VERSION;
				
				/// <inheritdoc />
				public string DeprecatedVersion => DEPRECATED_VERSION;
				
				/// <inheritdoc />
				public string Aggregation => AGGREGATION;

				// Note: Extension.Extender
				/// <inheritdoc />
				public string Extension => EXTENSION;
				
				/// <inheritdoc />
				public string Association => ASSOCIATION;

				// Note: DefaultValue.Name
				/// <inheritdoc />
				public string DefaultValue => DEFAULT_VALUE;
			}
			/// <summary>
			/// <inheritdoc cref="ObservesAssetRemovedProperty" path="/summary" /><br/>
			/// <remarks>Original Name: ObservesAssetRemoved</remarks>
			/// </summary>
			public new ObservesAssetRemovedProperty ObservesAssetRemoved { get; } = new ObservesAssetRemovedProperty();
			
			/// <summary>﻿
			/// </summary>
			public new sealed class ObservesAssetRemovedProperty : IProperty
			{
				/// <summary>Constant value for <see cref="ObservesAssetRemovedProperty.Name" /></summary>
				public const string NAME = "observesAssetRemoved";
				/// <summary>Constant value for <see cref="ObservesAssetRemovedProperty.Summary" /></summary>
				public const string SUMMARY = @"";
				/// <summary>Constant value for <see cref="ObservesAssetRemovedProperty.AccessModifier" /></summary>
				public const string ACCESS_MODIFIER = "public";
				/// <summary>Constant value for <see cref="ObservesAssetRemovedProperty.Modifier" /></summary>
				public const string MODIFIER = "";
				/// <summary>Constant value for <see cref="ObservesAssetRemovedProperty.NormativeVersion" /></summary>
				public const string NORMATIVE_VERSION = "";
				/// <summary>Constant value for <see cref="ObservesAssetRemovedProperty.DeprecatedVersion" /></summary>
				public const string DEPRECATED_VERSION = "";
				/// <summary>Constant value for <see cref="ObservesAssetRemovedProperty.Aggregation" /></summary>
				public const string AGGREGATION = "composite";
				/// <summary>Constant value for <see cref="ObservesAssetRemovedProperty.Extension" /></summary>
				public const string EXTENSION = "MagicDraw UML 2024x";
				/// <summary>Constant value for <see cref="ObservesAssetRemovedProperty.Association" /></summary>
				public const string ASSOCIATION = "";
				/// <summary>Constant value for <see cref="ObservesAssetRemovedProperty.DefaultValue" /></summary>
				public const string DEFAULT_VALUE = "";

				/// <summary>
				/// <inheritdoc />
				/// <remarks> Type: AssetRemovedClass </remarks>
				/// </summary>
				public System.Type Type => typeof(Mtconnect.ObservationInformationModel.ObservationTypes.EventTypes.AssetRemovedClass);
				
				/// <inheritdoc />
				public string Name => NAME;
				
				/// <inheritdoc />
				public string Summary => SUMMARY;

				/// <inheritdoc />
				public string AccessModifier => ACCESS_MODIFIER;
				
				/// <inheritdoc />
				public string Modifier => MODIFIER;
				
				/// <inheritdoc />
				public string NormativeVersion => NORMATIVE_VERSION;
				
				/// <inheritdoc />
				public string DeprecatedVersion => DEPRECATED_VERSION;
				
				/// <inheritdoc />
				public string Aggregation => AGGREGATION;

				// Note: Extension.Extender
				/// <inheritdoc />
				public string Extension => EXTENSION;
				
				/// <inheritdoc />
				public string Association => ASSOCIATION;

				// Note: DefaultValue.Name
				/// <inheritdoc />
				public string DefaultValue => DEFAULT_VALUE;
			}
			/// <summary>
			/// <inheritdoc cref="HashProperty" path="/summary" /><br/>
			/// <remarks>Original Name: Hash</remarks>
			/// </summary>
			public new HashProperty Hash { get; } = new HashProperty();
			
			/// <summary>﻿condensed message digest from a secure one-way hash function. <seealso href="https://www.google.com/search?q=FIPS PUB 180-4&amp;btnI=I">FIPS PUB 180-4</seealso><br /><br /><br />
			/// </summary>
			public new sealed class HashProperty : IProperty
			{
				/// <summary>Constant value for <see cref="HashProperty.Name" /></summary>
				public const string NAME = "hash";
				/// <summary>Constant value for <see cref="HashProperty.Summary" /></summary>
				public const string SUMMARY = @"&#10;&#10;&#10;condensed message digest from a secure one-way hash function. {{cite(FIPS PUB 180-4)}}&#10;
";
				/// <summary>Constant value for <see cref="HashProperty.AccessModifier" /></summary>
				public const string ACCESS_MODIFIER = "public";
				/// <summary>Constant value for <see cref="HashProperty.Modifier" /></summary>
				public const string MODIFIER = "";
				/// <summary>Constant value for <see cref="HashProperty.NormativeVersion" /></summary>
				public const string NORMATIVE_VERSION = "2.2";
				/// <summary>Constant value for <see cref="HashProperty.DeprecatedVersion" /></summary>
				public const string DEPRECATED_VERSION = "";
				/// <summary>Constant value for <see cref="HashProperty.Aggregation" /></summary>
				public const string AGGREGATION = "composite";
				/// <summary>Constant value for <see cref="HashProperty.Extension" /></summary>
				public const string EXTENSION = "MagicDraw UML 2024x";
				/// <summary>Constant value for <see cref="HashProperty.Association" /></summary>
				public const string ASSOCIATION = "";
				/// <summary>Constant value for <see cref="HashProperty.DefaultValue" /></summary>
				public const string DEFAULT_VALUE = "";

				/// <summary>
				/// <inheritdoc />
				/// <remarks> Type: String </remarks>
				/// </summary>
				public System.Type Type => typeof(String);
				
				/// <inheritdoc />
				public string Name => NAME;
				
				/// <inheritdoc />
				public string Summary => SUMMARY;

				/// <inheritdoc />
				public string AccessModifier => ACCESS_MODIFIER;
				
				/// <inheritdoc />
				public string Modifier => MODIFIER;
				
				/// <inheritdoc />
				public string NormativeVersion => NORMATIVE_VERSION;
				
				/// <inheritdoc />
				public string DeprecatedVersion => DEPRECATED_VERSION;
				
				/// <inheritdoc />
				public string Aggregation => AGGREGATION;

				// Note: Extension.Extender
				/// <inheritdoc />
				public string Extension => EXTENSION;
				
				/// <inheritdoc />
				public string Association => ASSOCIATION;

				// Note: DefaultValue.Name
				/// <inheritdoc />
				public string DefaultValue => DEFAULT_VALUE;
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