#pragma warning disable CS0109 // Member does not hide an inherited member; new keyword is not required
#pragma warning disable CS1574 // XML comment has cref attribute that could not be resolved
#pragma warning disable CS1584 // XML comment has syntactically incorrect cref attribute
#pragma warning disable CS0618 // Type or member is obsolete
using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;
using System.Linq;

namespace Mtconnect.DeviceInformationModel.Components
{
	/// <summary>﻿logical or physical entity that provides a capability.<br /><br /><br />Description<br /><br /><see cref="Component">Component</see> is an abstract entity and will be realized by specific <see cref="Component">Component</see> types for an <see cref="MTConnectDevices">MTConnectDevices</see> entity. See <see cref="Component Types">Component Types</see> for more details on the <see cref="Component">Component</see> types.<br /><br /><see cref="Component">Component</see> also provides structure for describing the <i>lower level</i> entities associated with it.<br /><br />At least one of <see cref="Component">Component</see>, <see cref="DataItem">DataItem</see>, or <see cref="Reference">Reference</see> entities <b>MUST</b> be provided for a <see cref="Component">Component</see>.<br /><br />![Component Example](figures/Component%20Example.png "Component Example"){: width="0.8"}<br /><br />&gt; Note: See {{lst(component-example)}} for the <i>XML</i> representation of the same example.<br /><br /><br /><br /><br />
	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Structure__EAID_8548C620_467A_4f50_9A22_58D84B7E8779">model.mtconnect.org</seealso> for more information.
	/// </summary>
	/// <remarks>
	/// <list type="bullet">
	/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
	/// </list>
	/// </remarks>

	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public sealed class ComponentGeneralization : IClass
	{
		/// <summary>Constant value for <see cref="ComponentGeneralization.ReferenceId" /></summary>
		public const string REFERENCE_ID = "EAID_8548C620_467A_4f50_9A22_58D84B7E8779";
		/// <summary>Constant value for <see cref="ComponentGeneralization.HelpUrl" /></summary>
		public const string HELP_URL = "https://model.mtconnect.org/#Structure__EAID_8548C620_467A_4f50_9A22_58D84B7E8779";
		/// <summary>Constant value for <see cref="ComponentGeneralization.Summary" /></summary>
		public const string SUMMARY = @"&#10;&#10;&#10;logical or physical entity that provides a capability.&#10;
&#10;&#10;&#10;Description&#10;&#10;&#10;&#10;{{block(Component)}} is an abstract entity and will be realized by specific {{block(Component)}} types for an {{block(MTConnectDevices)}} entity. See {{package(Component Types)}} for more details on the {{block(Component)}} types.

{{block(Component)}} also provides structure for describing the {{term(lower level)}} entities associated with it.

At least one of {{block(Component)}}, {{block(DataItem)}}, or {{block(Reference)}} entities **MUST** be provided for a {{block(Component)}}.

![Component Example](figures/Component%20Example.png ""Component Example""){: width=""0.8""}

> Note: See {{lst(component-example)}} for the {{term(XML)}} representation of the same example.&#10;
";
		/// <summary>Constant value for <see cref="ComponentGeneralization.Name" /></summary>
		public const string NAME = "Component";
		/// <summary>Constant value for <see cref="ComponentGeneralization.AccessModifier" /></summary>
		public const string ACCESS_MODIFIER = "public";
		/// <summary>Constant value for <see cref="ComponentGeneralization.Modifier" /></summary>
		public const string MODIFIER = "abstract";
		/// <summary>Constant value for <see cref="ComponentGeneralization.NormativeVersion" /></summary>
		public const string NORMATIVE_VERSION = "1.0";
		/// <summary>Constant value for <see cref="ComponentGeneralization.DeprecatedVersion" /></summary>
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
		/// Original Type: _19_0_3_45f01b9_1581734537697_742151_1119
		/// </remarks>
		public Type Generalization => typeof(Mtconnect.Glossary.MTConnectTerms.ComponentClass);

		/// <inheritdoc />
		public new ComponentGeneralizationProperties Properties { get; } = new ComponentGeneralizationProperties();
        IPropertyList IClass.Properties => Properties;
		/// <summary>
		/// Property list for <see cref="ComponentGeneralization" />.
		/// <br/><b>Note</b>, some properties (<see cref="IProperty" />) are inherited from <see cref="Mtconnect.Glossary.MTConnectTerms.ComponentClass.ComponentClassProperties" />.
		/// </summary>
		public class ComponentGeneralizationProperties : Mtconnect.Glossary.MTConnectTerms.ComponentClass.ComponentClassProperties
		{
			/// <inheritdoc />
			public override IProperty[] Properties => new IProperty[] {
				Id,
				Name,
				NativeName,
				SampleInterval,
				SampleRate,
				Uuid,
				HasDescriptionPart,
				HasCompositionPart,
				HasComponentPart,
				HasConfigurationPart,
				IsComponentOfPart,
				ObservesPart,
				MadeObservationPart,
				HasReferencePart,
				CoordinateSystemIdRef,
				HasComponentStreamPart,
			}.Concat(base.Properties).ToArray();
			/// <summary>
			/// <inheritdoc cref="IdProperty" path="/summary" /><br/>
			/// <remarks>Original Name: Id</remarks>
			/// </summary>
			public new IdProperty Id { get; } = new IdProperty();
			
			/// <summary>﻿unique identifier for the <see cref="Component">Component</see>.<br /><br /><br />
			/// </summary>
			public new sealed class IdProperty : IProperty
			{
				/// <summary>Constant value for <see cref="IdProperty.Name" /></summary>
				public const string NAME = "id";
				/// <summary>Constant value for <see cref="IdProperty.Summary" /></summary>
				public const string SUMMARY = @"&#10;&#10;&#10;unique identifier for the {{block(Component)}}.&#10;
";
				/// <summary>Constant value for <see cref="IdProperty.AccessModifier" /></summary>
				public const string ACCESS_MODIFIER = "public";
				/// <summary>Constant value for <see cref="IdProperty.Modifier" /></summary>
				public const string MODIFIER = "";
				/// <summary>Constant value for <see cref="IdProperty.NormativeVersion" /></summary>
				public const string NORMATIVE_VERSION = "1.0";
				/// <summary>Constant value for <see cref="IdProperty.DeprecatedVersion" /></summary>
				public const string DEPRECATED_VERSION = "";
				/// <summary>Constant value for <see cref="IdProperty.Aggregation" /></summary>
				public const string AGGREGATION = "";
				/// <summary>Constant value for <see cref="IdProperty.Extension" /></summary>
				public const string EXTENSION = "MagicDraw UML 19.0";
				/// <summary>Constant value for <see cref="IdProperty.Association" /></summary>
				public const string ASSOCIATION = "";
				/// <summary>Constant value for <see cref="IdProperty.DefaultValue" /></summary>
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
			public new NameProperty Name { get; } = new NameProperty();
			
			/// <summary>﻿name of the <see cref="Component">Component</see>.<br /><br />When provided, <see cref="Component.name">name in Component</see> <b>MUST</b> be unique for all child <see cref="Component">Component</see> entities of a parent <see cref="Component">Component</see>.<br /><br /><br />
			/// </summary>
			public new sealed class NameProperty : IProperty
			{
				/// <summary>Constant value for <see cref="NameProperty.Name" /></summary>
				public const string NAME = "name";
				/// <summary>Constant value for <see cref="NameProperty.Summary" /></summary>
				public const string SUMMARY = @"&#10;&#10;&#10;name of the {{block(Component)}}.

When provided, {{property(Component::name)}} **MUST** be unique for all child {{block(Component)}} entities of a parent {{block(Component)}}.&#10;
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
			public new NativeNameProperty NativeName { get; } = new NativeNameProperty();
			
			/// <summary>﻿common name associated with <see cref="Component">Component</see>.<br /><br /><br />
			/// </summary>
			public new sealed class NativeNameProperty : IProperty
			{
				/// <summary>Constant value for <see cref="NativeNameProperty.Name" /></summary>
				public const string NAME = "nativeName";
				/// <summary>Constant value for <see cref="NativeNameProperty.Summary" /></summary>
				public const string SUMMARY = @"&#10;&#10;&#10;common name associated with {{block(Component)}}.&#10;
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
			/// <inheritdoc cref="SampleIntervalProperty" path="/summary" /><br/>
			/// <remarks>Original Name: SampleInterval</remarks>
			/// </summary>
			public new SampleIntervalProperty SampleInterval { get; } = new SampleIntervalProperty();
			
			/// <summary>﻿interval in milliseconds between the completion of the reading of the data associated with the <see cref="Component">Component</see> until the beginning of the next sampling of that data.<br /><br />This information may be used by client software applications to understand how often information from a <see cref="Component">Component</see> is expected to be refreshed.<br /><br />The refresh rate for data from all child <see cref="Component">Component</see> entities will be the<br />same as for the parent <see cref="Component">Component</see> element unless specifically overridden by another <see cref="Component.sampleInterval">sampleInterval in Component</see> provided for the child <see cref="Component">Component</see>.<br /><br /><br />
			/// </summary>
			public new sealed class SampleIntervalProperty : IProperty
			{
				/// <summary>Constant value for <see cref="SampleIntervalProperty.Name" /></summary>
				public const string NAME = "sampleInterval";
				/// <summary>Constant value for <see cref="SampleIntervalProperty.Summary" /></summary>
				public const string SUMMARY = @"&#10;&#10;&#10;interval in milliseconds between the completion of the reading of the data associated with the {{block(Component)}} until the beginning of the next sampling of that data.

This information may be used by client software applications to understand how often information from a {{block(Component)}} is expected to be refreshed.

The refresh rate for data from all child {{block(Component)}} entities will be the
same as for the parent {{block(Component)}} element unless specifically overridden by another {{property(Component::sampleInterval)}} provided for the child {{block(Component)}}.&#10;
";
				/// <summary>Constant value for <see cref="SampleIntervalProperty.AccessModifier" /></summary>
				public const string ACCESS_MODIFIER = "public";
				/// <summary>Constant value for <see cref="SampleIntervalProperty.Modifier" /></summary>
				public const string MODIFIER = "";
				/// <summary>Constant value for <see cref="SampleIntervalProperty.NormativeVersion" /></summary>
				public const string NORMATIVE_VERSION = "1.2";
				/// <summary>Constant value for <see cref="SampleIntervalProperty.DeprecatedVersion" /></summary>
				public const string DEPRECATED_VERSION = "";
				/// <summary>Constant value for <see cref="SampleIntervalProperty.Aggregation" /></summary>
				public const string AGGREGATION = "";
				/// <summary>Constant value for <see cref="SampleIntervalProperty.Extension" /></summary>
				public const string EXTENSION = "MagicDraw UML 19.0";
				/// <summary>Constant value for <see cref="SampleIntervalProperty.Association" /></summary>
				public const string ASSOCIATION = "";
				/// <summary>Constant value for <see cref="SampleIntervalProperty.DefaultValue" /></summary>
				public const string DEFAULT_VALUE = "";

				/// <summary>
				/// <inheritdoc />
				/// <remarks> Type: Single </remarks>
				/// </summary>
				public System.Type Type => typeof(Single);
				
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
			/// <inheritdoc cref="SampleRateProperty" path="/summary" /><br/>
			/// <remarks>Original Name: SampleRate</remarks>
			/// </summary>
			public new SampleRateProperty SampleRate { get; } = new SampleRateProperty();
			
			/// <summary>﻿<b>DEPRECATED</b> in <i>MTConnect Version 1.2</i>. Replaced by <see cref="Component.sampleInterval">sampleInterval in Component</see>.<br /><br /><br />
			/// </summary>
			public new sealed class SampleRateProperty : IProperty
			{
				/// <summary>Constant value for <see cref="SampleRateProperty.Name" /></summary>
				public const string NAME = "sampleRate";
				/// <summary>Constant value for <see cref="SampleRateProperty.Summary" /></summary>
				public const string SUMMARY = @"&#10;&#10;&#10;**DEPRECATED** in *MTConnect Version 1.2*. Replaced by {{property(Component::sampleInterval)}}.&#10;
";
				/// <summary>Constant value for <see cref="SampleRateProperty.AccessModifier" /></summary>
				public const string ACCESS_MODIFIER = "public";
				/// <summary>Constant value for <see cref="SampleRateProperty.Modifier" /></summary>
				public const string MODIFIER = "";
				/// <summary>Constant value for <see cref="SampleRateProperty.NormativeVersion" /></summary>
				public const string NORMATIVE_VERSION = "1.0";
				/// <summary>Constant value for <see cref="SampleRateProperty.DeprecatedVersion" /></summary>
				public const string DEPRECATED_VERSION = "1.2";
				/// <summary>Constant value for <see cref="SampleRateProperty.Aggregation" /></summary>
				public const string AGGREGATION = "";
				/// <summary>Constant value for <see cref="SampleRateProperty.Extension" /></summary>
				public const string EXTENSION = "MagicDraw UML 19.0";
				/// <summary>Constant value for <see cref="SampleRateProperty.Association" /></summary>
				public const string ASSOCIATION = "";
				/// <summary>Constant value for <see cref="SampleRateProperty.DefaultValue" /></summary>
				public const string DEFAULT_VALUE = "";

				/// <summary>
				/// <inheritdoc />
				/// <remarks> Type: Single </remarks>
				/// </summary>
				public System.Type Type => typeof(Single);
				
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
			
			/// <summary>﻿universally unique identifier for the <see cref="Component">Component</see>.<br /><br /><br />
			/// </summary>
			public new sealed class UuidProperty : IProperty
			{
				/// <summary>Constant value for <see cref="UuidProperty.Name" /></summary>
				public const string NAME = "uuid";
				/// <summary>Constant value for <see cref="UuidProperty.Summary" /></summary>
				public const string SUMMARY = @"&#10;&#10;&#10;universally unique identifier for the {{block(Component)}}.&#10;
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
			/// <inheritdoc cref="HasDescriptionPartProperty" path="/summary" /><br/>
			/// <remarks>Original Name: HasDescription</remarks>
			/// </summary>
			public new HasDescriptionPartProperty HasDescriptionPart { get; } = new HasDescriptionPartProperty();
			
			/// <summary>﻿
			/// </summary>
			public new sealed class HasDescriptionPartProperty : IProperty
			{
				/// <summary>Constant value for <see cref="HasDescriptionPartProperty.Name" /></summary>
				public const string NAME = "hasDescription";
				/// <summary>Constant value for <see cref="HasDescriptionPartProperty.Summary" /></summary>
				public const string SUMMARY = @"";
				/// <summary>Constant value for <see cref="HasDescriptionPartProperty.AccessModifier" /></summary>
				public const string ACCESS_MODIFIER = "public";
				/// <summary>Constant value for <see cref="HasDescriptionPartProperty.Modifier" /></summary>
				public const string MODIFIER = "";
				/// <summary>Constant value for <see cref="HasDescriptionPartProperty.NormativeVersion" /></summary>
				public const string NORMATIVE_VERSION = "";
				/// <summary>Constant value for <see cref="HasDescriptionPartProperty.DeprecatedVersion" /></summary>
				public const string DEPRECATED_VERSION = "";
				/// <summary>Constant value for <see cref="HasDescriptionPartProperty.Aggregation" /></summary>
				public const string AGGREGATION = "composite";
				/// <summary>Constant value for <see cref="HasDescriptionPartProperty.Extension" /></summary>
				public const string EXTENSION = "MagicDraw UML 19.0";
				/// <summary>Constant value for <see cref="HasDescriptionPartProperty.Association" /></summary>
				public const string ASSOCIATION = "Description";
				/// <summary>Constant value for <see cref="HasDescriptionPartProperty.DefaultValue" /></summary>
				public const string DEFAULT_VALUE = "";

				/// <summary>
				/// <inheritdoc />
				/// <remarks> Type: DescriptionClass </remarks>
				/// </summary>
				public System.Type Type => typeof(Mtconnect.DeviceInformationModel.Components.DescriptionClass);
				
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
			/// <inheritdoc cref="HasCompositionPartProperty" path="/summary" /><br/>
			/// <remarks>Original Name: HasComposition</remarks>
			/// </summary>
			public new HasCompositionPartProperty HasCompositionPart { get; } = new HasCompositionPartProperty();
			
			/// <summary>﻿
			/// </summary>
			public new sealed class HasCompositionPartProperty : IProperty
			{
				/// <summary>Constant value for <see cref="HasCompositionPartProperty.Name" /></summary>
				public const string NAME = "hasComposition";
				/// <summary>Constant value for <see cref="HasCompositionPartProperty.Summary" /></summary>
				public const string SUMMARY = @"";
				/// <summary>Constant value for <see cref="HasCompositionPartProperty.AccessModifier" /></summary>
				public const string ACCESS_MODIFIER = "public";
				/// <summary>Constant value for <see cref="HasCompositionPartProperty.Modifier" /></summary>
				public const string MODIFIER = "";
				/// <summary>Constant value for <see cref="HasCompositionPartProperty.NormativeVersion" /></summary>
				public const string NORMATIVE_VERSION = "";
				/// <summary>Constant value for <see cref="HasCompositionPartProperty.DeprecatedVersion" /></summary>
				public const string DEPRECATED_VERSION = "";
				/// <summary>Constant value for <see cref="HasCompositionPartProperty.Aggregation" /></summary>
				public const string AGGREGATION = "composite";
				/// <summary>Constant value for <see cref="HasCompositionPartProperty.Extension" /></summary>
				public const string EXTENSION = "";
				/// <summary>Constant value for <see cref="HasCompositionPartProperty.Association" /></summary>
				public const string ASSOCIATION = "Compositions";
				/// <summary>Constant value for <see cref="HasCompositionPartProperty.DefaultValue" /></summary>
				public const string DEFAULT_VALUE = "";

				/// <summary>
				/// <inheritdoc />
				/// <remarks> Type: CompositionClass </remarks>
				/// </summary>
				public System.Type Type => typeof(Mtconnect.DeviceInformationModel.Compositions.CompositionClass);
				
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
			/// <inheritdoc cref="HasComponentPartProperty" path="/summary" /><br/>
			/// <remarks>Original Name: HasComponent</remarks>
			/// </summary>
			public new HasComponentPartProperty HasComponentPart { get; } = new HasComponentPartProperty();
			
			/// <summary>﻿
			/// </summary>
			public new sealed class HasComponentPartProperty : IProperty
			{
				/// <summary>Constant value for <see cref="HasComponentPartProperty.Name" /></summary>
				public const string NAME = "hasComponent";
				/// <summary>Constant value for <see cref="HasComponentPartProperty.Summary" /></summary>
				public const string SUMMARY = @"";
				/// <summary>Constant value for <see cref="HasComponentPartProperty.AccessModifier" /></summary>
				public const string ACCESS_MODIFIER = "public";
				/// <summary>Constant value for <see cref="HasComponentPartProperty.Modifier" /></summary>
				public const string MODIFIER = "";
				/// <summary>Constant value for <see cref="HasComponentPartProperty.NormativeVersion" /></summary>
				public const string NORMATIVE_VERSION = "";
				/// <summary>Constant value for <see cref="HasComponentPartProperty.DeprecatedVersion" /></summary>
				public const string DEPRECATED_VERSION = "";
				/// <summary>Constant value for <see cref="HasComponentPartProperty.Aggregation" /></summary>
				public const string AGGREGATION = "composite";
				/// <summary>Constant value for <see cref="HasComponentPartProperty.Extension" /></summary>
				public const string EXTENSION = "";
				/// <summary>Constant value for <see cref="HasComponentPartProperty.Association" /></summary>
				public const string ASSOCIATION = "Components";
				/// <summary>Constant value for <see cref="HasComponentPartProperty.DefaultValue" /></summary>
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
			/// <summary>
			/// <inheritdoc cref="HasConfigurationPartProperty" path="/summary" /><br/>
			/// <remarks>Original Name: HasConfiguration</remarks>
			/// </summary>
			public new HasConfigurationPartProperty HasConfigurationPart { get; } = new HasConfigurationPartProperty();
			
			/// <summary>﻿
			/// </summary>
			public new sealed class HasConfigurationPartProperty : IProperty
			{
				/// <summary>Constant value for <see cref="HasConfigurationPartProperty.Name" /></summary>
				public const string NAME = "hasConfiguration";
				/// <summary>Constant value for <see cref="HasConfigurationPartProperty.Summary" /></summary>
				public const string SUMMARY = @"";
				/// <summary>Constant value for <see cref="HasConfigurationPartProperty.AccessModifier" /></summary>
				public const string ACCESS_MODIFIER = "public";
				/// <summary>Constant value for <see cref="HasConfigurationPartProperty.Modifier" /></summary>
				public const string MODIFIER = "";
				/// <summary>Constant value for <see cref="HasConfigurationPartProperty.NormativeVersion" /></summary>
				public const string NORMATIVE_VERSION = "";
				/// <summary>Constant value for <see cref="HasConfigurationPartProperty.DeprecatedVersion" /></summary>
				public const string DEPRECATED_VERSION = "";
				/// <summary>Constant value for <see cref="HasConfigurationPartProperty.Aggregation" /></summary>
				public const string AGGREGATION = "composite";
				/// <summary>Constant value for <see cref="HasConfigurationPartProperty.Extension" /></summary>
				public const string EXTENSION = "MagicDraw UML 19.0";
				/// <summary>Constant value for <see cref="HasConfigurationPartProperty.Association" /></summary>
				public const string ASSOCIATION = "Configuration";
				/// <summary>Constant value for <see cref="HasConfigurationPartProperty.DefaultValue" /></summary>
				public const string DEFAULT_VALUE = "";

				/// <summary>
				/// <inheritdoc />
				/// <remarks> Type: ConfigurationClass </remarks>
				/// </summary>
				public System.Type Type => typeof(Mtconnect.DeviceInformationModel.Configurations.ConfigurationClass);
				
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
			/// <inheritdoc cref="IsComponentOfPartProperty" path="/summary" /><br/>
			/// <remarks>Original Name: IsComponentOf</remarks>
			/// </summary>
			public new IsComponentOfPartProperty IsComponentOfPart { get; } = new IsComponentOfPartProperty();
			
			/// <summary>﻿
			/// </summary>
			public new sealed class IsComponentOfPartProperty : IProperty
			{
				/// <summary>Constant value for <see cref="IsComponentOfPartProperty.Name" /></summary>
				public const string NAME = "isComponentOf";
				/// <summary>Constant value for <see cref="IsComponentOfPartProperty.Summary" /></summary>
				public const string SUMMARY = @"";
				/// <summary>Constant value for <see cref="IsComponentOfPartProperty.AccessModifier" /></summary>
				public const string ACCESS_MODIFIER = "private";
				/// <summary>Constant value for <see cref="IsComponentOfPartProperty.Modifier" /></summary>
				public const string MODIFIER = "";
				/// <summary>Constant value for <see cref="IsComponentOfPartProperty.NormativeVersion" /></summary>
				public const string NORMATIVE_VERSION = "";
				/// <summary>Constant value for <see cref="IsComponentOfPartProperty.DeprecatedVersion" /></summary>
				public const string DEPRECATED_VERSION = "";
				/// <summary>Constant value for <see cref="IsComponentOfPartProperty.Aggregation" /></summary>
				public const string AGGREGATION = "";
				/// <summary>Constant value for <see cref="IsComponentOfPartProperty.Extension" /></summary>
				public const string EXTENSION = "MagicDraw UML 19.0";
				/// <summary>Constant value for <see cref="IsComponentOfPartProperty.Association" /></summary>
				public const string ASSOCIATION = "Components";
				/// <summary>Constant value for <see cref="IsComponentOfPartProperty.DefaultValue" /></summary>
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
			/// <summary>
			/// <inheritdoc cref="ObservesPartProperty" path="/summary" /><br/>
			/// <remarks>Original Name: Observes</remarks>
			/// </summary>
			public new ObservesPartProperty ObservesPart { get; } = new ObservesPartProperty();
			
			/// <summary>﻿
			/// </summary>
			public new sealed class ObservesPartProperty : IProperty
			{
				/// <summary>Constant value for <see cref="ObservesPartProperty.Name" /></summary>
				public const string NAME = "observes";
				/// <summary>Constant value for <see cref="ObservesPartProperty.Summary" /></summary>
				public const string SUMMARY = @"";
				/// <summary>Constant value for <see cref="ObservesPartProperty.AccessModifier" /></summary>
				public const string ACCESS_MODIFIER = "public";
				/// <summary>Constant value for <see cref="ObservesPartProperty.Modifier" /></summary>
				public const string MODIFIER = "";
				/// <summary>Constant value for <see cref="ObservesPartProperty.NormativeVersion" /></summary>
				public const string NORMATIVE_VERSION = "";
				/// <summary>Constant value for <see cref="ObservesPartProperty.DeprecatedVersion" /></summary>
				public const string DEPRECATED_VERSION = "";
				/// <summary>Constant value for <see cref="ObservesPartProperty.Aggregation" /></summary>
				public const string AGGREGATION = "composite";
				/// <summary>Constant value for <see cref="ObservesPartProperty.Extension" /></summary>
				public const string EXTENSION = "";
				/// <summary>Constant value for <see cref="ObservesPartProperty.Association" /></summary>
				public const string ASSOCIATION = "DataItems";
				/// <summary>Constant value for <see cref="ObservesPartProperty.DefaultValue" /></summary>
				public const string DEFAULT_VALUE = "";

				/// <summary>
				/// <inheritdoc />
				/// <remarks> Type: DataItemClass </remarks>
				/// </summary>
				public System.Type Type => typeof(Mtconnect.DeviceInformationModel.DataItems.DataItemClass);
				
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
			/// <inheritdoc cref="MadeObservationPartProperty" path="/summary" /><br/>
			/// <remarks>Original Name: MadeObservation</remarks>
			/// </summary>
			public new MadeObservationPartProperty MadeObservationPart { get; } = new MadeObservationPartProperty();
			
			/// <summary>﻿
			/// </summary>
			public new sealed class MadeObservationPartProperty : IProperty
			{
				/// <summary>Constant value for <see cref="MadeObservationPartProperty.Name" /></summary>
				public const string NAME = "madeObservation";
				/// <summary>Constant value for <see cref="MadeObservationPartProperty.Summary" /></summary>
				public const string SUMMARY = @"";
				/// <summary>Constant value for <see cref="MadeObservationPartProperty.AccessModifier" /></summary>
				public const string ACCESS_MODIFIER = "public";
				/// <summary>Constant value for <see cref="MadeObservationPartProperty.Modifier" /></summary>
				public const string MODIFIER = "";
				/// <summary>Constant value for <see cref="MadeObservationPartProperty.NormativeVersion" /></summary>
				public const string NORMATIVE_VERSION = "";
				/// <summary>Constant value for <see cref="MadeObservationPartProperty.DeprecatedVersion" /></summary>
				public const string DEPRECATED_VERSION = "";
				/// <summary>Constant value for <see cref="MadeObservationPartProperty.Aggregation" /></summary>
				public const string AGGREGATION = "composite";
				/// <summary>Constant value for <see cref="MadeObservationPartProperty.Extension" /></summary>
				public const string EXTENSION = "";
				/// <summary>Constant value for <see cref="MadeObservationPartProperty.Association" /></summary>
				public const string ASSOCIATION = "Observations";
				/// <summary>Constant value for <see cref="MadeObservationPartProperty.DefaultValue" /></summary>
				public const string DEFAULT_VALUE = "";

				/// <summary>
				/// <inheritdoc />
				/// <remarks> Type: ObservationGeneralization </remarks>
				/// </summary>
				public System.Type Type => typeof(Mtconnect.ObservationInformationModel.ObservationGeneralization);
				
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
			/// <inheritdoc cref="HasReferencePartProperty" path="/summary" /><br/>
			/// <remarks>Original Name: HasReference</remarks>
			/// </summary>
			public new HasReferencePartProperty HasReferencePart { get; } = new HasReferencePartProperty();
			
			/// <summary>﻿
			/// </summary>
			public new sealed class HasReferencePartProperty : IProperty
			{
				/// <summary>Constant value for <see cref="HasReferencePartProperty.Name" /></summary>
				public const string NAME = "hasReference";
				/// <summary>Constant value for <see cref="HasReferencePartProperty.Summary" /></summary>
				public const string SUMMARY = @"";
				/// <summary>Constant value for <see cref="HasReferencePartProperty.AccessModifier" /></summary>
				public const string ACCESS_MODIFIER = "public";
				/// <summary>Constant value for <see cref="HasReferencePartProperty.Modifier" /></summary>
				public const string MODIFIER = "";
				/// <summary>Constant value for <see cref="HasReferencePartProperty.NormativeVersion" /></summary>
				public const string NORMATIVE_VERSION = "";
				/// <summary>Constant value for <see cref="HasReferencePartProperty.DeprecatedVersion" /></summary>
				public const string DEPRECATED_VERSION = "";
				/// <summary>Constant value for <see cref="HasReferencePartProperty.Aggregation" /></summary>
				public const string AGGREGATION = "composite";
				/// <summary>Constant value for <see cref="HasReferencePartProperty.Extension" /></summary>
				public const string EXTENSION = "";
				/// <summary>Constant value for <see cref="HasReferencePartProperty.Association" /></summary>
				public const string ASSOCIATION = "References";
				/// <summary>Constant value for <see cref="HasReferencePartProperty.DefaultValue" /></summary>
				public const string DEFAULT_VALUE = "";

				/// <summary>
				/// <inheritdoc />
				/// <remarks> Type: ReferenceClass </remarks>
				/// </summary>
				public System.Type Type => typeof(Mtconnect.DeviceInformationModel.References.ReferenceClass);
				
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
			/// <inheritdoc cref="CoordinateSystemIdRefProperty" path="/summary" /><br/>
			/// <remarks>Original Name: CoordinateSystemIdRef</remarks>
			/// </summary>
			public new CoordinateSystemIdRefProperty CoordinateSystemIdRef { get; } = new CoordinateSystemIdRefProperty();
			
			/// <summary>﻿specifies the <see cref="CoordinateSystem">CoordinateSystem</see> for this <see cref="Component">Component</see> and its children.<br /><br /><br />
			/// </summary>
			public new sealed class CoordinateSystemIdRefProperty : IProperty
			{
				/// <summary>Constant value for <see cref="CoordinateSystemIdRefProperty.Name" /></summary>
				public const string NAME = "coordinateSystemIdRef";
				/// <summary>Constant value for <see cref="CoordinateSystemIdRefProperty.Summary" /></summary>
				public const string SUMMARY = @"&#10;&#10;&#10;specifies the {{block(CoordinateSystem)}} for this {{block(Component)}} and its children.&#10;
";
				/// <summary>Constant value for <see cref="CoordinateSystemIdRefProperty.AccessModifier" /></summary>
				public const string ACCESS_MODIFIER = "public";
				/// <summary>Constant value for <see cref="CoordinateSystemIdRefProperty.Modifier" /></summary>
				public const string MODIFIER = "";
				/// <summary>Constant value for <see cref="CoordinateSystemIdRefProperty.NormativeVersion" /></summary>
				public const string NORMATIVE_VERSION = "1.8";
				/// <summary>Constant value for <see cref="CoordinateSystemIdRefProperty.DeprecatedVersion" /></summary>
				public const string DEPRECATED_VERSION = "";
				/// <summary>Constant value for <see cref="CoordinateSystemIdRefProperty.Aggregation" /></summary>
				public const string AGGREGATION = "";
				/// <summary>Constant value for <see cref="CoordinateSystemIdRefProperty.Extension" /></summary>
				public const string EXTENSION = "MagicDraw UML 19.0";
				/// <summary>Constant value for <see cref="CoordinateSystemIdRefProperty.Association" /></summary>
				public const string ASSOCIATION = "";
				/// <summary>Constant value for <see cref="CoordinateSystemIdRefProperty.DefaultValue" /></summary>
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
			/// <inheritdoc cref="HasComponentStreamPartProperty" path="/summary" /><br/>
			/// <remarks>Original Name: HasComponentStream</remarks>
			/// </summary>
			public new HasComponentStreamPartProperty HasComponentStreamPart { get; } = new HasComponentStreamPartProperty();
			
			/// <summary>﻿
			/// </summary>
			public new sealed class HasComponentStreamPartProperty : IProperty
			{
				/// <summary>Constant value for <see cref="HasComponentStreamPartProperty.Name" /></summary>
				public const string NAME = "hasComponentStream";
				/// <summary>Constant value for <see cref="HasComponentStreamPartProperty.Summary" /></summary>
				public const string SUMMARY = @"";
				/// <summary>Constant value for <see cref="HasComponentStreamPartProperty.AccessModifier" /></summary>
				public const string ACCESS_MODIFIER = "public";
				/// <summary>Constant value for <see cref="HasComponentStreamPartProperty.Modifier" /></summary>
				public const string MODIFIER = "";
				/// <summary>Constant value for <see cref="HasComponentStreamPartProperty.NormativeVersion" /></summary>
				public const string NORMATIVE_VERSION = "";
				/// <summary>Constant value for <see cref="HasComponentStreamPartProperty.DeprecatedVersion" /></summary>
				public const string DEPRECATED_VERSION = "";
				/// <summary>Constant value for <see cref="HasComponentStreamPartProperty.Aggregation" /></summary>
				public const string AGGREGATION = "shared";
				/// <summary>Constant value for <see cref="HasComponentStreamPartProperty.Extension" /></summary>
				public const string EXTENSION = "MagicDraw UML 19.0";
				/// <summary>Constant value for <see cref="HasComponentStreamPartProperty.Association" /></summary>
				public const string ASSOCIATION = "ComponentStream";
				/// <summary>Constant value for <see cref="HasComponentStreamPartProperty.DefaultValue" /></summary>
				public const string DEFAULT_VALUE = "";

				/// <summary>
				/// <inheritdoc />
				/// <remarks> Type: ComponentStreamClass </remarks>
				/// </summary>
				public System.Type Type => typeof(Mtconnect.ObservationInformationModel.ComponentStreamClass);
				
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
		/// Component1
		/// </summary>
		/// <remarks>Specification Language: <c>Unspecified</c></remarks>
		public string Component1 => @"Components::Component::allInstances()->iterate(comp;compcount:Real=0|
if comp.id->size() = 1 and
    (comp.observes->size() <> 0 or comp.hasReference->size() <> 0 or comp.hasComponent->size() <> 0 or comp.oclAsType(Components::""Component Types""::Organizer)->size() <> 0) 
then
    compcount + 1
else
    compcount + 0                                
endif
) = Components::Component::allInstances()->size()";
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