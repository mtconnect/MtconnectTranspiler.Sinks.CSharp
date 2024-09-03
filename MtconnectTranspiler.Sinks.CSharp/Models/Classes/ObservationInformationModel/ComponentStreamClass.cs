#pragma warning disable CS0109 // Member does not hide an inherited member; new keyword is not required
#pragma warning disable CS1574 // XML comment has cref attribute that could not be resolved
#pragma warning disable CS1584 // XML comment has syntactically incorrect cref attribute
#pragma warning disable CS0618 // Type or member is obsolete
using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;

namespace Mtconnect.ObservationInformationModel
{
	/// <summary>﻿organizes the data associated with each <see cref="Component">Component</see> entity defined for a <see cref="Device">Device</see> in the associated <i>MTConnectDevices Response Document</i>.<br /><br /><br />Description<br /><br />At least one of <see cref="Sample">Sample</see>, <see cref="Event">Event</see>, or <see cref="Condition">Condition</see> <b>MUST</b> be organized by a <see cref="ComponentStream">ComponentStream</see> entity.<br /><br /><br /><br /><br />
	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Structure__EAID_9057AAF9_4687_42be_BD2B_E2F18DF049DC">model.mtconnect.org</seealso> for more information.
	/// </summary>
	/// <remarks>
	/// <list type="bullet">
	/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
	/// </list>
	/// </remarks>

	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public sealed class ComponentStreamClass : IClass
	{
		/// <summary>Constant value for <see cref="ComponentStreamClass.ReferenceId" /></summary>
		public const string REFERENCE_ID = "EAID_9057AAF9_4687_42be_BD2B_E2F18DF049DC";
		/// <summary>Constant value for <see cref="ComponentStreamClass.HelpUrl" /></summary>
		public const string HELP_URL = "https://model.mtconnect.org/#Structure__EAID_9057AAF9_4687_42be_BD2B_E2F18DF049DC";
		/// <summary>Constant value for <see cref="ComponentStreamClass.Summary" /></summary>
		public const string SUMMARY = @"&#10;&#10;&#10;organizes the data associated with each {{block(Component)}} entity defined for a {{block(Device)}} in the associated {{term(MTConnectDevices Response Document)}}.&#10;
&#10;&#10;&#10;Description&#10;&#10;&#10;&#10;At least one of {{block(Sample)}}, {{block(Event)}}, or {{block(Condition)}} **MUST** be organized by a {{block(ComponentStream)}} entity.&#10;
";
		/// <summary>Constant value for <see cref="ComponentStreamClass.Name" /></summary>
		public const string NAME = "ComponentStream";
		/// <summary>Constant value for <see cref="ComponentStreamClass.AccessModifier" /></summary>
		public const string ACCESS_MODIFIER = "public";
		/// <summary>Constant value for <see cref="ComponentStreamClass.Modifier" /></summary>
		public const string MODIFIER = "";
		/// <summary>Constant value for <see cref="ComponentStreamClass.NormativeVersion" /></summary>
		public const string NORMATIVE_VERSION = "1.0";
		/// <summary>Constant value for <see cref="ComponentStreamClass.DeprecatedVersion" /></summary>
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
		public Type Generalization => null;

		/// <inheritdoc />
		public new ComponentStreamClassProperties Properties { get; } = new ComponentStreamClassProperties();
        IPropertyList IClass.Properties => Properties;
		/// <summary>
		/// Property list for <see cref="ComponentStreamClass" />.
		/// </summary>
		public class ComponentStreamClassProperties : IPropertyList
		{
			/// <inheritdoc />
			public virtual IProperty[] Properties => new IProperty[] {
				Component,
				ComponentId,
				Name,
				NativeName,
				Uuid,
				OrganizesEventPart,
				OrganizesSamplePart,
				OrganizesConditionPart,
				IsOrganizerForPart,
			};
			/// <summary>
			/// <inheritdoc cref="ComponentProperty" path="/summary" /><br/>
			/// <remarks>Original Name: Component</remarks>
			/// </summary>
			public ComponentProperty Component { get; } = new ComponentProperty();
			
			/// <summary>﻿identifies the <see cref="Component">Component</see> type associated with the <see cref="ComponentStream">ComponentStream</see>.<br /><br />Examples of <see cref="ComponentStream.component">component in ComponentStream</see> are <see cref="Device">Device</see>, <see cref="Controller">Controller</see>, <see cref="Linear">Linear</see> and <see cref="Loader">Loader</see>.<br /><br /><br />
			/// </summary>
			public sealed class ComponentProperty : IProperty
			{
				/// <summary>Constant value for <see cref="ComponentProperty.Name" /></summary>
				public const string NAME = "component";
				/// <summary>Constant value for <see cref="ComponentProperty.Summary" /></summary>
				public const string SUMMARY = @"&#10;&#10;&#10;identifies the {{block(Component)}} type associated with the {{block(ComponentStream)}}.

Examples of {{property(ComponentStream::component)}} are {{block(Device)}}, {{block(Controller)}}, {{block(Linear)}} and {{block(Loader)}}.&#10;
";
				/// <summary>Constant value for <see cref="ComponentProperty.AccessModifier" /></summary>
				public const string ACCESS_MODIFIER = "public";
				/// <summary>Constant value for <see cref="ComponentProperty.Modifier" /></summary>
				public const string MODIFIER = "";
				/// <summary>Constant value for <see cref="ComponentProperty.NormativeVersion" /></summary>
				public const string NORMATIVE_VERSION = "1.0";
				/// <summary>Constant value for <see cref="ComponentProperty.DeprecatedVersion" /></summary>
				public const string DEPRECATED_VERSION = "";
				/// <summary>Constant value for <see cref="ComponentProperty.Aggregation" /></summary>
				public const string AGGREGATION = "";
				/// <summary>Constant value for <see cref="ComponentProperty.Extension" /></summary>
				public const string EXTENSION = "MagicDraw UML 19.0";
				/// <summary>Constant value for <see cref="ComponentProperty.Association" /></summary>
				public const string ASSOCIATION = "";
				/// <summary>Constant value for <see cref="ComponentProperty.DefaultValue" /></summary>
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
			/// <inheritdoc cref="ComponentIdProperty" path="/summary" /><br/>
			/// <remarks>Original Name: ComponentId</remarks>
			/// </summary>
			public ComponentIdProperty ComponentId { get; } = new ComponentIdProperty();
			
			/// <summary>﻿identifier of the <see cref="Component">Component</see> as defined by the <see cref="Component.id">id in Component</see> in the <i>MTConnectDevices Response Document</i>.<br /><br /><br />
			/// </summary>
			public sealed class ComponentIdProperty : IProperty
			{
				/// <summary>Constant value for <see cref="ComponentIdProperty.Name" /></summary>
				public const string NAME = "componentId";
				/// <summary>Constant value for <see cref="ComponentIdProperty.Summary" /></summary>
				public const string SUMMARY = @"&#10;&#10;&#10;identifier of the {{block(Component)}} as defined by the {{property(Component::id)}} in the {{term(MTConnectDevices Response Document)}}.&#10;
";
				/// <summary>Constant value for <see cref="ComponentIdProperty.AccessModifier" /></summary>
				public const string ACCESS_MODIFIER = "public";
				/// <summary>Constant value for <see cref="ComponentIdProperty.Modifier" /></summary>
				public const string MODIFIER = "";
				/// <summary>Constant value for <see cref="ComponentIdProperty.NormativeVersion" /></summary>
				public const string NORMATIVE_VERSION = "1.0";
				/// <summary>Constant value for <see cref="ComponentIdProperty.DeprecatedVersion" /></summary>
				public const string DEPRECATED_VERSION = "";
				/// <summary>Constant value for <see cref="ComponentIdProperty.Aggregation" /></summary>
				public const string AGGREGATION = "";
				/// <summary>Constant value for <see cref="ComponentIdProperty.Extension" /></summary>
				public const string EXTENSION = "MagicDraw UML 19.0";
				/// <summary>Constant value for <see cref="ComponentIdProperty.Association" /></summary>
				public const string ASSOCIATION = "";
				/// <summary>Constant value for <see cref="ComponentIdProperty.DefaultValue" /></summary>
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
			/// <inheritdoc cref="NameProperty" path="/summary" /><br/>
			/// <remarks>Original Name: Name</remarks>
			/// </summary>
			public NameProperty Name { get; } = new NameProperty();
			
			/// <summary>﻿name of the <see cref="Component">Component</see> associated with the <see cref="ComponentStream">ComponentStream</see>.<br /><br /><br />
			/// </summary>
			public sealed class NameProperty : IProperty
			{
				/// <summary>Constant value for <see cref="NameProperty.Name" /></summary>
				public const string NAME = "name";
				/// <summary>Constant value for <see cref="NameProperty.Summary" /></summary>
				public const string SUMMARY = @"&#10;&#10;&#10;name of the {{block(Component)}} associated with the {{block(ComponentStream)}}.&#10;
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
				public const string EXTENSION = "MagicDraw UML 19.0";
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
			/// <inheritdoc cref="NativeNameProperty" path="/summary" /><br/>
			/// <remarks>Original Name: NativeName</remarks>
			/// </summary>
			public NativeNameProperty NativeName { get; } = new NativeNameProperty();
			
			/// <summary>﻿common name of the <see cref="Component">Component</see> associated with the <see cref="ComponentStream">ComponentStream</see>.<br /><br /><br />
			/// </summary>
			public sealed class NativeNameProperty : IProperty
			{
				/// <summary>Constant value for <see cref="NativeNameProperty.Name" /></summary>
				public const string NAME = "nativeName";
				/// <summary>Constant value for <see cref="NativeNameProperty.Summary" /></summary>
				public const string SUMMARY = @"&#10;&#10;&#10;common name of the {{block(Component)}} associated with the {{block(ComponentStream)}}.&#10;
";
				/// <summary>Constant value for <see cref="NativeNameProperty.AccessModifier" /></summary>
				public const string ACCESS_MODIFIER = "public";
				/// <summary>Constant value for <see cref="NativeNameProperty.Modifier" /></summary>
				public const string MODIFIER = "";
				/// <summary>Constant value for <see cref="NativeNameProperty.NormativeVersion" /></summary>
				public const string NORMATIVE_VERSION = "1.1";
				/// <summary>Constant value for <see cref="NativeNameProperty.DeprecatedVersion" /></summary>
				public const string DEPRECATED_VERSION = "";
				/// <summary>Constant value for <see cref="NativeNameProperty.Aggregation" /></summary>
				public const string AGGREGATION = "";
				/// <summary>Constant value for <see cref="NativeNameProperty.Extension" /></summary>
				public const string EXTENSION = "MagicDraw UML 19.0";
				/// <summary>Constant value for <see cref="NativeNameProperty.Association" /></summary>
				public const string ASSOCIATION = "";
				/// <summary>Constant value for <see cref="NativeNameProperty.DefaultValue" /></summary>
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
			public UuidProperty Uuid { get; } = new UuidProperty();
			
			/// <summary>﻿uuid of the <see cref="Component">Component</see> associated with the <see cref="ComponentStream">ComponentStream</see>.<br /><br /><br />
			/// </summary>
			public sealed class UuidProperty : IProperty
			{
				/// <summary>Constant value for <see cref="UuidProperty.Name" /></summary>
				public const string NAME = "uuid";
				/// <summary>Constant value for <see cref="UuidProperty.Summary" /></summary>
				public const string SUMMARY = @"&#10;&#10;&#10;uuid of the {{block(Component)}} associated with the {{block(ComponentStream)}}.&#10;
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
				public const string EXTENSION = "MagicDraw UML 19.0";
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
			/// <inheritdoc cref="OrganizesEventPartProperty" path="/summary" /><br/>
			/// <remarks>Original Name: OrganizesEvent</remarks>
			/// </summary>
			public OrganizesEventPartProperty OrganizesEventPart { get; } = new OrganizesEventPartProperty();
			
			/// <summary>﻿
			/// </summary>
			public sealed class OrganizesEventPartProperty : IProperty
			{
				/// <summary>Constant value for <see cref="OrganizesEventPartProperty.Name" /></summary>
				public const string NAME = "organizesEvent";
				/// <summary>Constant value for <see cref="OrganizesEventPartProperty.Summary" /></summary>
				public const string SUMMARY = @"";
				/// <summary>Constant value for <see cref="OrganizesEventPartProperty.AccessModifier" /></summary>
				public const string ACCESS_MODIFIER = "public";
				/// <summary>Constant value for <see cref="OrganizesEventPartProperty.Modifier" /></summary>
				public const string MODIFIER = "";
				/// <summary>Constant value for <see cref="OrganizesEventPartProperty.NormativeVersion" /></summary>
				public const string NORMATIVE_VERSION = "";
				/// <summary>Constant value for <see cref="OrganizesEventPartProperty.DeprecatedVersion" /></summary>
				public const string DEPRECATED_VERSION = "";
				/// <summary>Constant value for <see cref="OrganizesEventPartProperty.Aggregation" /></summary>
				public const string AGGREGATION = "shared";
				/// <summary>Constant value for <see cref="OrganizesEventPartProperty.Extension" /></summary>
				public const string EXTENSION = "";
				/// <summary>Constant value for <see cref="OrganizesEventPartProperty.Association" /></summary>
				public const string ASSOCIATION = "Events";
				/// <summary>Constant value for <see cref="OrganizesEventPartProperty.DefaultValue" /></summary>
				public const string DEFAULT_VALUE = "";

				/// <summary>
				/// <inheritdoc />
				/// <remarks> Type: EventClass </remarks>
				/// </summary>
				public System.Type Type => typeof(Mtconnect.ObservationInformationModel.EventClass);
				
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
			/// <inheritdoc cref="OrganizesSamplePartProperty" path="/summary" /><br/>
			/// <remarks>Original Name: OrganizesSample</remarks>
			/// </summary>
			public OrganizesSamplePartProperty OrganizesSamplePart { get; } = new OrganizesSamplePartProperty();
			
			/// <summary>﻿
			/// </summary>
			public sealed class OrganizesSamplePartProperty : IProperty
			{
				/// <summary>Constant value for <see cref="OrganizesSamplePartProperty.Name" /></summary>
				public const string NAME = "organizesSample";
				/// <summary>Constant value for <see cref="OrganizesSamplePartProperty.Summary" /></summary>
				public const string SUMMARY = @"";
				/// <summary>Constant value for <see cref="OrganizesSamplePartProperty.AccessModifier" /></summary>
				public const string ACCESS_MODIFIER = "public";
				/// <summary>Constant value for <see cref="OrganizesSamplePartProperty.Modifier" /></summary>
				public const string MODIFIER = "";
				/// <summary>Constant value for <see cref="OrganizesSamplePartProperty.NormativeVersion" /></summary>
				public const string NORMATIVE_VERSION = "";
				/// <summary>Constant value for <see cref="OrganizesSamplePartProperty.DeprecatedVersion" /></summary>
				public const string DEPRECATED_VERSION = "";
				/// <summary>Constant value for <see cref="OrganizesSamplePartProperty.Aggregation" /></summary>
				public const string AGGREGATION = "shared";
				/// <summary>Constant value for <see cref="OrganizesSamplePartProperty.Extension" /></summary>
				public const string EXTENSION = "";
				/// <summary>Constant value for <see cref="OrganizesSamplePartProperty.Association" /></summary>
				public const string ASSOCIATION = "Samples";
				/// <summary>Constant value for <see cref="OrganizesSamplePartProperty.DefaultValue" /></summary>
				public const string DEFAULT_VALUE = "";

				/// <summary>
				/// <inheritdoc />
				/// <remarks> Type: SampleClass </remarks>
				/// </summary>
				public System.Type Type => typeof(Mtconnect.ObservationInformationModel.SampleClass);
				
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
			/// <inheritdoc cref="OrganizesConditionPartProperty" path="/summary" /><br/>
			/// <remarks>Original Name: OrganizesCondition</remarks>
			/// </summary>
			public OrganizesConditionPartProperty OrganizesConditionPart { get; } = new OrganizesConditionPartProperty();
			
			/// <summary>﻿
			/// </summary>
			public sealed class OrganizesConditionPartProperty : IProperty
			{
				/// <summary>Constant value for <see cref="OrganizesConditionPartProperty.Name" /></summary>
				public const string NAME = "organizesCondition";
				/// <summary>Constant value for <see cref="OrganizesConditionPartProperty.Summary" /></summary>
				public const string SUMMARY = @"";
				/// <summary>Constant value for <see cref="OrganizesConditionPartProperty.AccessModifier" /></summary>
				public const string ACCESS_MODIFIER = "public";
				/// <summary>Constant value for <see cref="OrganizesConditionPartProperty.Modifier" /></summary>
				public const string MODIFIER = "";
				/// <summary>Constant value for <see cref="OrganizesConditionPartProperty.NormativeVersion" /></summary>
				public const string NORMATIVE_VERSION = "";
				/// <summary>Constant value for <see cref="OrganizesConditionPartProperty.DeprecatedVersion" /></summary>
				public const string DEPRECATED_VERSION = "";
				/// <summary>Constant value for <see cref="OrganizesConditionPartProperty.Aggregation" /></summary>
				public const string AGGREGATION = "shared";
				/// <summary>Constant value for <see cref="OrganizesConditionPartProperty.Extension" /></summary>
				public const string EXTENSION = "";
				/// <summary>Constant value for <see cref="OrganizesConditionPartProperty.Association" /></summary>
				public const string ASSOCIATION = "Conditions";
				/// <summary>Constant value for <see cref="OrganizesConditionPartProperty.DefaultValue" /></summary>
				public const string DEFAULT_VALUE = "";

				/// <summary>
				/// <inheritdoc />
				/// <remarks> Type: ConditionClass </remarks>
				/// </summary>
				public System.Type Type => typeof(Mtconnect.ObservationInformationModel.ConditionClass);
				
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
			/// <inheritdoc cref="IsOrganizerForPartProperty" path="/summary" /><br/>
			/// <remarks>Original Name: IsOrganizerFor</remarks>
			/// </summary>
			public IsOrganizerForPartProperty IsOrganizerForPart { get; } = new IsOrganizerForPartProperty();
			
			/// <summary>﻿
			/// </summary>
			public sealed class IsOrganizerForPartProperty : IProperty
			{
				/// <summary>Constant value for <see cref="IsOrganizerForPartProperty.Name" /></summary>
				public const string NAME = "isOrganizerFor";
				/// <summary>Constant value for <see cref="IsOrganizerForPartProperty.Summary" /></summary>
				public const string SUMMARY = @"";
				/// <summary>Constant value for <see cref="IsOrganizerForPartProperty.AccessModifier" /></summary>
				public const string ACCESS_MODIFIER = "private";
				/// <summary>Constant value for <see cref="IsOrganizerForPartProperty.Modifier" /></summary>
				public const string MODIFIER = "";
				/// <summary>Constant value for <see cref="IsOrganizerForPartProperty.NormativeVersion" /></summary>
				public const string NORMATIVE_VERSION = "";
				/// <summary>Constant value for <see cref="IsOrganizerForPartProperty.DeprecatedVersion" /></summary>
				public const string DEPRECATED_VERSION = "";
				/// <summary>Constant value for <see cref="IsOrganizerForPartProperty.Aggregation" /></summary>
				public const string AGGREGATION = "";
				/// <summary>Constant value for <see cref="IsOrganizerForPartProperty.Extension" /></summary>
				public const string EXTENSION = "MagicDraw UML 19.0";
				/// <summary>Constant value for <see cref="IsOrganizerForPartProperty.Association" /></summary>
				public const string ASSOCIATION = "ComponentStream";
				/// <summary>Constant value for <see cref="IsOrganizerForPartProperty.DefaultValue" /></summary>
				public const string DEFAULT_VALUE = "";

				/// <summary>
				/// <inheritdoc />
				/// <remarks> Type: ComponentGeneralization </remarks>
				/// </summary>
				public System.Type Type => typeof(Mtconnect.DeviceInformationModel.Components.ComponentGeneralization);
				
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
		/// ComponentStream1
		/// </summary>
		/// <remarks>Specification Language: <c>Unspecified</c></remarks>
		public string ComponentStream1 => @"self.organizesEvent->size() <> 0 or self.organizesSample->size() <> 0 or self.organizesCondition->size() <> 0";
		/*
		self.organizesEvent->size() <> 0 or self.organizesSample->size() <> 0 or self.organizesCondition->size() <> 0
		*/
		# endregion
	}
}