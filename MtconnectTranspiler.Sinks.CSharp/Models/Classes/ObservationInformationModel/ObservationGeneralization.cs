#pragma warning disable CS0109 // Member does not hide an inherited member; new keyword is not required
#pragma warning disable CS1574 // XML comment has cref attribute that could not be resolved
#pragma warning disable CS1584 // XML comment has syntactically incorrect cref attribute
#pragma warning disable CS0618 // Type or member is obsolete
using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;
using System.Linq;

namespace Mtconnect.ObservationInformationModel
{
	/// <summary>﻿abstract entity that provides telemetry data for a <see cref="DataItem">DataItem</see> at a point in time.<br /><br /><br />Description<br /><br />![Observations](figures/Observations.png "Observations"){: width="0.8"}<br /><br />&gt; Note: See <see cref="Observations Schema Diagrams">Observations Schema Diagrams</see> for XML schema. The XML schema also shows differences in XML representation of certain MTConnect entities.<br /><br />{{figure(DeviceStream Example)}} shows a complete example of <see cref="DeviceStream">DeviceStream</see> for the <see cref="Device">Device</see> shown in <see cref="Device Information Model">Device Information Model</see>.<br /><br />![DeviceStream Example](figures/DeviceStream%20Example.png "DeviceStream Example"){: width="0.8"}<br /><br />&gt; Note: See {{lst(devicestream-example)}} for the <i>XML</i> representation of the same example.<br /><br /><br />This section provides semantic information for the <see cref="Observation">Observation</see> model.<br /><br />&gt; Note: See <see cref="Observations Schema Diagrams">Observations Schema Diagrams</see> for XML schema of <see cref="Observation">Observation</see> types.<br /><br />#### Observations made for DataItem<br /><br /><see cref="Component">Component</see> <i>observe</i>s <see cref="DataItem">DataItem</see> entities and creates <see cref="Observation">Observation</see> entities for the <see cref="DataItem">DataItem</see> entities. See {{figure(Observations)}}.<br /><br /><see cref="Observation">Observation</see> entities made by a <see cref="Component">Component</see> are organized by a <see cref="ComponentStream">ComponentStream</see> which is specifically created for that <see cref="Component">Component</see>.<br /><br />![Observations made for DataItem Example](figures/Observations%20made%20for%20DataItem%20Example.png "Observations made for DataItem Example"){: width="0.8"}<br /><br />&gt; Note: See <see cref="Observations made for DataItem Example">Observations made for DataItem Example</see> for how XML representation of the same example is separated into <i>MTConnectDevices Response Document</i> and <i>MTConnectStreams Response Document</i>.<br /><br />{{figure(Observations made for DataItem Example)}} is a subset of {{figure(DeviceStream Example)}}. It shows an example of the association between a <see cref="DataItem">DataItem</see> <see cref="Event">Event</see> type (<c>EMERGENCY_STOP</c>) and an <see cref="Observation">Observation</see> <see cref="Event">Event</see> type (<c>EmergencyStop</c>). See <see cref="Naming Convention for Observation types">Naming Convention for Observation types</see>.<br /><br />{{figure(Observations made for DataItem Example)}} also shows example of the association between a <see cref="Component">Component</see> type (<c>Controller</c>) and related <see cref="ComponentStream">ComponentStream</see>.<br /><br />#### Naming Convention for Observation types<br /><br />The name of an <see cref="Observation">Observation</see> type <b>MUST</b> derive from the associated <see cref="DataItem.type">type in DataItem</see> converted to Pascal-Case by removing underscores (_ ) and capitalizing each word. The conversion <b>MUST NOT</b> apply to the following abbreviated words: <c>PH</c>, <c>AC</c>, <c>DC</c> and <c>URI</c>. <c>MTCONNECT</c> <b>MUST</b> be converted to <c>MTConnect</c>. See {{figure(Observations made for DataItem Example)}} for an example.<br /><br />The name of an <see cref="Observation">Observation</see> type reported in the <i>MTConnectStreams Response Document</i> is extended when the <see cref="DataItem.representation">representation in DataItem</see> is used to further describe that <see cref="DataItem">DataItem</see> in the <i>MTConnectDevices Response Document</i>. See <see cref="Representations">Representations</see> for more details.<br /><br /><br /><br /><br />
	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Structure___19_0_3_45f01b9_1579566531115_47734_25731">model.mtconnect.org</seealso> for more information.
	/// </summary>
	/// <remarks>
	/// <list type="bullet">
	/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
	/// </list>
	/// </remarks>

	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public sealed class ObservationGeneralization : IClass
	{
		/// <summary>Constant value for <see cref="ObservationGeneralization.ReferenceId" /></summary>
		public const string REFERENCE_ID = "_19_0_3_45f01b9_1579566531115_47734_25731";
		/// <summary>Constant value for <see cref="ObservationGeneralization.HelpUrl" /></summary>
		public const string HELP_URL = "https://model.mtconnect.org/#Structure___19_0_3_45f01b9_1579566531115_47734_25731";
		/// <summary>Constant value for <see cref="ObservationGeneralization.Summary" /></summary>
		public const string SUMMARY = @"&#10;&#10;&#10;abstract entity that provides telemetry data for a {{block(DataItem)}} at a point in time.&#10;
&#10;&#10;&#10;Description&#10;&#10;&#10;&#10;![Observations](figures/Observations.png ""Observations""){: width=""0.8""}

> Note: See {{sect(Observations Schema Diagrams)}} for XML schema. The XML schema also shows differences in XML representation of certain MTConnect entities.

{{figure(DeviceStream Example)}} shows a complete example of {{block(DeviceStream)}} for the {{block(Device)}} shown in {{package(Device Information Model)}}.

![DeviceStream Example](figures/DeviceStream%20Example.png ""DeviceStream Example""){: width=""0.8""}

> Note: See {{lst(devicestream-example)}} for the {{term(XML)}} representation of the same example.


This section provides semantic information for the {{block(Observation)}} model.

> Note: See {{sect(Observations Schema Diagrams)}} for XML schema of {{block(Observation)}} types.

#### Observations made for DataItem

{{block(Component)}} {{termplural(observe)}} {{block(DataItem)}} entities and creates {{block(Observation)}} entities for the {{block(DataItem)}} entities. See {{figure(Observations)}}.

{{block(Observation)}} entities made by a {{block(Component)}} are organized by a {{block(ComponentStream)}} which is specifically created for that {{block(Component)}}.

![Observations made for DataItem Example](figures/Observations%20made%20for%20DataItem%20Example.png ""Observations made for DataItem Example""){: width=""0.8""}

> Note: See {{sect(Observations made for DataItem Example)}} for how XML representation of the same example is separated into {{term(MTConnectDevices Response Document)}} and {{term(MTConnectStreams Response Document)}}.

{{figure(Observations made for DataItem Example)}} is a subset of {{figure(DeviceStream Example)}}. It shows an example of the association between a {{block(DataItem)}} {{block(Event)}} type (`EMERGENCY_STOP`) and an {{block(Observation)}} {{block(Event)}} type (`EmergencyStop`). See {{sect(Naming Convention for Observation types)}}.

{{figure(Observations made for DataItem Example)}} also shows example of the association between a {{block(Component)}} type (`Controller`) and related {{block(ComponentStream)}}.

#### Naming Convention for Observation types

The name of an {{block(Observation)}} type **MUST** derive from the associated {{property(DataItem::type)}} converted to Pascal-Case by removing underscores (_ ) and capitalizing each word. The conversion **MUST NOT** apply to the following abbreviated words: `PH`, `AC`, `DC` and `URI`. `MTCONNECT` **MUST** be converted to `MTConnect`. See {{figure(Observations made for DataItem Example)}} for an example.

The name of an {{block(Observation)}} type reported in the {{term(MTConnectStreams Response Document)}} is extended when the {{property(DataItem::representation)}} is used to further describe that {{block(DataItem)}} in the {{term(MTConnectDevices Response Document)}}. See {{package(Representations)}} for more details.&#10;
";
		/// <summary>Constant value for <see cref="ObservationGeneralization.Name" /></summary>
		public const string NAME = "Observation";
		/// <summary>Constant value for <see cref="ObservationGeneralization.AccessModifier" /></summary>
		public const string ACCESS_MODIFIER = "public";
		/// <summary>Constant value for <see cref="ObservationGeneralization.Modifier" /></summary>
		public const string MODIFIER = "abstract";
		/// <summary>Constant value for <see cref="ObservationGeneralization.NormativeVersion" /></summary>
		public const string NORMATIVE_VERSION = "1.0";
		/// <summary>Constant value for <see cref="ObservationGeneralization.DeprecatedVersion" /></summary>
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
		/// Original Type: _19_0_3_45f01b9_1581812901326_593856_4168
		/// </remarks>
		public Type Generalization => typeof(Mtconnect.Glossary.MTConnectTerms.ObservationClass);

		/// <inheritdoc />
		public new ObservationGeneralizationProperties Properties { get; } = new ObservationGeneralizationProperties();
        IPropertyList IClass.Properties => Properties;
		/// <summary>
		/// Property list for <see cref="ObservationGeneralization" />.
		/// <br/><b>Note</b>, some properties (<see cref="IProperty" />) are inherited from <see cref="Mtconnect.Glossary.MTConnectTerms.ObservationClass.ObservationClassProperties" />.
		/// </summary>
		public class ObservationGeneralizationProperties : Mtconnect.Glossary.MTConnectTerms.ObservationClass.ObservationClassProperties
		{
			/// <inheritdoc />
			public override IProperty[] Properties => new IProperty[] {
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
				Quality,
				Deprecated,
				Extended,
			}.Concat(base.Properties).ToArray();
			/// <summary>
			/// <inheritdoc cref="CompositionIdProperty" path="/summary" /><br/>
			/// <remarks>Original Name: CompositionId</remarks>
			/// </summary>
			public new CompositionIdProperty CompositionId { get; } = new CompositionIdProperty();
			
			/// <summary>﻿identifier of the <see cref="Composition">Composition</see> entity defined in the <i>MTConnectDevices Response Document</i> associated with the data reported for the <see cref="Observation">Observation</see>.<br /><br /><br />
			/// </summary>
			public new sealed class CompositionIdProperty : IProperty
			{
				/// <summary>Constant value for <see cref="CompositionIdProperty.Name" /></summary>
				public const string NAME = "compositionId";
				/// <summary>Constant value for <see cref="CompositionIdProperty.Summary" /></summary>
				public const string SUMMARY = @"&#10;&#10;&#10;identifier of the {{block(Composition)}} entity defined in the {{term(MTConnectDevices Response Document)}} associated with the data reported for the {{block(Observation)}}.&#10;
";
				/// <summary>Constant value for <see cref="CompositionIdProperty.AccessModifier" /></summary>
				public const string ACCESS_MODIFIER = "public";
				/// <summary>Constant value for <see cref="CompositionIdProperty.Modifier" /></summary>
				public const string MODIFIER = "static";
				/// <summary>Constant value for <see cref="CompositionIdProperty.NormativeVersion" /></summary>
				public const string NORMATIVE_VERSION = "1.4";
				/// <summary>Constant value for <see cref="CompositionIdProperty.DeprecatedVersion" /></summary>
				public const string DEPRECATED_VERSION = "";
				/// <summary>Constant value for <see cref="CompositionIdProperty.Aggregation" /></summary>
				public const string AGGREGATION = "";
				/// <summary>Constant value for <see cref="CompositionIdProperty.Extension" /></summary>
				public const string EXTENSION = "MagicDraw UML 2024x";
				/// <summary>Constant value for <see cref="CompositionIdProperty.Association" /></summary>
				public const string ASSOCIATION = "";
				/// <summary>Constant value for <see cref="CompositionIdProperty.DefaultValue" /></summary>
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
			/// <inheritdoc cref="DataItemIdProperty" path="/summary" /><br/>
			/// <remarks>Original Name: DataItemId</remarks>
			/// </summary>
			public new DataItemIdProperty DataItemId { get; } = new DataItemIdProperty();
			
			/// <summary>﻿unique identifier of the <see cref="DataItem">DataItem</see> associated with this <see cref="Observation">Observation</see>.<br /><br /><see cref="Observation.dataItemId">dataItemId in Observation</see> <b>MUST</b> match the associated <see cref="DataItem.id">id in DataItem</see> defined in the <i>MTConnectDevices Response Document</i>.<br /><br /><br />
			/// </summary>
			public new sealed class DataItemIdProperty : IProperty
			{
				/// <summary>Constant value for <see cref="DataItemIdProperty.Name" /></summary>
				public const string NAME = "dataItemId";
				/// <summary>Constant value for <see cref="DataItemIdProperty.Summary" /></summary>
				public const string SUMMARY = @"&#10;&#10;&#10;unique identifier of the {{block(DataItem)}} associated with this {{block(Observation)}}.

{{property(Observation::dataItemId)}} **MUST** match the associated {{property(DataItem::id)}} defined in the {{term(MTConnectDevices Response Document)}}.&#10;
";
				/// <summary>Constant value for <see cref="DataItemIdProperty.AccessModifier" /></summary>
				public const string ACCESS_MODIFIER = "public";
				/// <summary>Constant value for <see cref="DataItemIdProperty.Modifier" /></summary>
				public const string MODIFIER = "static";
				/// <summary>Constant value for <see cref="DataItemIdProperty.NormativeVersion" /></summary>
				public const string NORMATIVE_VERSION = "1.0";
				/// <summary>Constant value for <see cref="DataItemIdProperty.DeprecatedVersion" /></summary>
				public const string DEPRECATED_VERSION = "";
				/// <summary>Constant value for <see cref="DataItemIdProperty.Aggregation" /></summary>
				public const string AGGREGATION = "";
				/// <summary>Constant value for <see cref="DataItemIdProperty.Extension" /></summary>
				public const string EXTENSION = "MagicDraw UML 2024x";
				/// <summary>Constant value for <see cref="DataItemIdProperty.Association" /></summary>
				public const string ASSOCIATION = "";
				/// <summary>Constant value for <see cref="DataItemIdProperty.DefaultValue" /></summary>
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
			
			/// <summary>﻿name of the <see cref="DataItem">DataItem</see> associated with this <see cref="Observation">Observation</see>.<br /><br /><see cref="Observation.name">name in Observation</see> <b>MUST</b> match the associated <see cref="DataItem.name">name in DataItem</see> defined in the <i>MTConnectDevices Response Document</i>.<br /><br /><br />
			/// </summary>
			public new sealed class NameProperty : IProperty
			{
				/// <summary>Constant value for <see cref="NameProperty.Name" /></summary>
				public const string NAME = "name";
				/// <summary>Constant value for <see cref="NameProperty.Summary" /></summary>
				public const string SUMMARY = @"&#10;&#10;&#10;name of the {{block(DataItem)}} associated with this {{block(Observation)}}.

{{property(Observation::name)}} **MUST** match the associated {{property(DataItem::name)}} defined in the {{term(MTConnectDevices Response Document)}}.&#10;
";
				/// <summary>Constant value for <see cref="NameProperty.AccessModifier" /></summary>
				public const string ACCESS_MODIFIER = "public";
				/// <summary>Constant value for <see cref="NameProperty.Modifier" /></summary>
				public const string MODIFIER = "static";
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
			/// <inheritdoc cref="SequenceProperty" path="/summary" /><br/>
			/// <remarks>Original Name: Sequence</remarks>
			/// </summary>
			public new SequenceProperty Sequence { get; } = new SequenceProperty();
			
			/// <summary>﻿number representing the sequential position of an occurrence of an <i>observation</i> in the data buffer of an <i>agent</i>.<br /><br /><see cref="Observation.sequence">sequence in Observation</see> <b>MUST</b> have a value represented as an unsigned 64-bit value from 1 to <i> 2^{64}-1 </i>.<br /><br /><br />
			/// </summary>
			public new sealed class SequenceProperty : IProperty
			{
				/// <summary>Constant value for <see cref="SequenceProperty.Name" /></summary>
				public const string NAME = "sequence";
				/// <summary>Constant value for <see cref="SequenceProperty.Summary" /></summary>
				public const string SUMMARY = @"&#10;&#10;&#10;number representing the sequential position of an occurrence of an {{term(observation)}} in the data buffer of an {{term(agent)}}.

{{property(Observation::sequence)}} **MUST** have a value represented as an unsigned 64-bit value from 1 to $$ 2^{64}-1 $$.&#10;
";
				/// <summary>Constant value for <see cref="SequenceProperty.AccessModifier" /></summary>
				public const string ACCESS_MODIFIER = "public";
				/// <summary>Constant value for <see cref="SequenceProperty.Modifier" /></summary>
				public const string MODIFIER = "";
				/// <summary>Constant value for <see cref="SequenceProperty.NormativeVersion" /></summary>
				public const string NORMATIVE_VERSION = "1.0";
				/// <summary>Constant value for <see cref="SequenceProperty.DeprecatedVersion" /></summary>
				public const string DEPRECATED_VERSION = "";
				/// <summary>Constant value for <see cref="SequenceProperty.Aggregation" /></summary>
				public const string AGGREGATION = "";
				/// <summary>Constant value for <see cref="SequenceProperty.Extension" /></summary>
				public const string EXTENSION = "MagicDraw UML 2024x";
				/// <summary>Constant value for <see cref="SequenceProperty.Association" /></summary>
				public const string ASSOCIATION = "";
				/// <summary>Constant value for <see cref="SequenceProperty.DefaultValue" /></summary>
				public const string DEFAULT_VALUE = "";

				/// <summary>
				/// <inheritdoc />
				/// <remarks> Type: Int32 </remarks>
				/// </summary>
				public System.Type Type => typeof(Int32);
				
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
			/// <inheritdoc cref="SubTypeProperty" path="/summary" /><br/>
			/// <remarks>Original Name: SubType</remarks>
			/// </summary>
			public new SubTypeProperty SubType { get; } = new SubTypeProperty();
			
			/// <summary>﻿subtype of the <see cref="DataItem">DataItem</see> associated with this <see cref="Observation">Observation</see>.<br /><br /><see cref="Observation.subType">subType in Observation</see> <b>MUST</b> match the associated <see cref="DataItem.subType">subType in DataItem</see> defined in the <i>MTConnectDevices Response Document</i>.<br /><br /><br />
			/// </summary>
			public new sealed class SubTypeProperty : IProperty
			{
				/// <summary>Constant value for <see cref="SubTypeProperty.Name" /></summary>
				public const string NAME = "subType";
				/// <summary>Constant value for <see cref="SubTypeProperty.Summary" /></summary>
				public const string SUMMARY = @"&#10;&#10;&#10;subtype of the {{block(DataItem)}} associated with this {{block(Observation)}}.

{{property(Observation::subType)}} **MUST** match the associated {{property(DataItem::subType)}} defined in the {{term(MTConnectDevices Response Document)}}.&#10;
";
				/// <summary>Constant value for <see cref="SubTypeProperty.AccessModifier" /></summary>
				public const string ACCESS_MODIFIER = "public";
				/// <summary>Constant value for <see cref="SubTypeProperty.Modifier" /></summary>
				public const string MODIFIER = "static";
				/// <summary>Constant value for <see cref="SubTypeProperty.NormativeVersion" /></summary>
				public const string NORMATIVE_VERSION = "1.2";
				/// <summary>Constant value for <see cref="SubTypeProperty.DeprecatedVersion" /></summary>
				public const string DEPRECATED_VERSION = "";
				/// <summary>Constant value for <see cref="SubTypeProperty.Aggregation" /></summary>
				public const string AGGREGATION = "";
				/// <summary>Constant value for <see cref="SubTypeProperty.Extension" /></summary>
				public const string EXTENSION = "MagicDraw UML 2024x";
				/// <summary>Constant value for <see cref="SubTypeProperty.Association" /></summary>
				public const string ASSOCIATION = "";
				/// <summary>Constant value for <see cref="SubTypeProperty.DefaultValue" /></summary>
				public const string DEFAULT_VALUE = "";

				/// <summary>
				/// <inheritdoc />
				/// <remarks> Type: DataItemSubTypeEnumMetaClass </remarks>
				/// </summary>
				public System.Type Type => typeof(Mtconnect.DataTypes.DataItemSubTypeEnumMetaClass);
				
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
			/// <inheritdoc cref="TimestampProperty" path="/summary" /><br/>
			/// <remarks>Original Name: Timestamp</remarks>
			/// </summary>
			public new TimestampProperty Timestamp { get; } = new TimestampProperty();
			
			/// <summary>﻿most accurate time available to a piece of equipment that represents the point in time that the data reported was measured.<br /><br /><br />
			/// </summary>
			public new sealed class TimestampProperty : IProperty
			{
				/// <summary>Constant value for <see cref="TimestampProperty.Name" /></summary>
				public const string NAME = "timestamp";
				/// <summary>Constant value for <see cref="TimestampProperty.Summary" /></summary>
				public const string SUMMARY = @"&#10;&#10;&#10;most accurate time available to a piece of equipment that represents the point in time that the data reported was measured.&#10;
";
				/// <summary>Constant value for <see cref="TimestampProperty.AccessModifier" /></summary>
				public const string ACCESS_MODIFIER = "public";
				/// <summary>Constant value for <see cref="TimestampProperty.Modifier" /></summary>
				public const string MODIFIER = "";
				/// <summary>Constant value for <see cref="TimestampProperty.NormativeVersion" /></summary>
				public const string NORMATIVE_VERSION = "1.0";
				/// <summary>Constant value for <see cref="TimestampProperty.DeprecatedVersion" /></summary>
				public const string DEPRECATED_VERSION = "";
				/// <summary>Constant value for <see cref="TimestampProperty.Aggregation" /></summary>
				public const string AGGREGATION = "";
				/// <summary>Constant value for <see cref="TimestampProperty.Extension" /></summary>
				public const string EXTENSION = "MagicDraw UML 2024x";
				/// <summary>Constant value for <see cref="TimestampProperty.Association" /></summary>
				public const string ASSOCIATION = "";
				/// <summary>Constant value for <see cref="TimestampProperty.DefaultValue" /></summary>
				public const string DEFAULT_VALUE = "";

				/// <summary>
				/// <inheritdoc />
				/// <remarks> Type: DateTime </remarks>
				/// </summary>
				public System.Type Type => typeof(DateTime);
				
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
			/// <inheritdoc cref="MadeByComponentPartProperty" path="/summary" /><br/>
			/// <remarks>Original Name: MadeByComponent</remarks>
			/// </summary>
			public new MadeByComponentPartProperty MadeByComponentPart { get; } = new MadeByComponentPartProperty();
			
			/// <summary>﻿
			/// </summary>
			public new sealed class MadeByComponentPartProperty : IProperty
			{
				/// <summary>Constant value for <see cref="MadeByComponentPartProperty.Name" /></summary>
				public const string NAME = "madeByComponent";
				/// <summary>Constant value for <see cref="MadeByComponentPartProperty.Summary" /></summary>
				public const string SUMMARY = @"";
				/// <summary>Constant value for <see cref="MadeByComponentPartProperty.AccessModifier" /></summary>
				public const string ACCESS_MODIFIER = "private";
				/// <summary>Constant value for <see cref="MadeByComponentPartProperty.Modifier" /></summary>
				public const string MODIFIER = "";
				/// <summary>Constant value for <see cref="MadeByComponentPartProperty.NormativeVersion" /></summary>
				public const string NORMATIVE_VERSION = "";
				/// <summary>Constant value for <see cref="MadeByComponentPartProperty.DeprecatedVersion" /></summary>
				public const string DEPRECATED_VERSION = "";
				/// <summary>Constant value for <see cref="MadeByComponentPartProperty.Aggregation" /></summary>
				public const string AGGREGATION = "";
				/// <summary>Constant value for <see cref="MadeByComponentPartProperty.Extension" /></summary>
				public const string EXTENSION = "MagicDraw UML 2024x";
				/// <summary>Constant value for <see cref="MadeByComponentPartProperty.Association" /></summary>
				public const string ASSOCIATION = "Observations";
				/// <summary>Constant value for <see cref="MadeByComponentPartProperty.DefaultValue" /></summary>
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
			/// <inheritdoc cref="TypeProperty" path="/summary" /><br/>
			/// <remarks>Original Name: Type</remarks>
			/// </summary>
			public new TypeProperty Type { get; } = new TypeProperty();
			
			/// <summary>﻿type of the <see cref="DataItem">DataItem</see> associated with this <see cref="Observation">Observation</see>.<br /><br /><see cref="Observation.type">type in Observation</see> <b>MUST</b> match the associated <see cref="DataItem.type">type in DataItem</see> defined in the <i>MTConnectDevices Response Document</i>.<br /><br /><br />
			/// </summary>
			public new sealed class TypeProperty : IProperty
			{
				/// <summary>Constant value for <see cref="TypeProperty.Name" /></summary>
				public const string NAME = "type";
				/// <summary>Constant value for <see cref="TypeProperty.Summary" /></summary>
				public const string SUMMARY = @"&#10;&#10;&#10;type of the {{block(DataItem)}} associated with this {{block(Observation)}}.

{{property(Observation::type)}} **MUST** match the associated {{property(DataItem::type)}} defined in the {{term(MTConnectDevices Response Document)}}.&#10;
";
				/// <summary>Constant value for <see cref="TypeProperty.AccessModifier" /></summary>
				public const string ACCESS_MODIFIER = "public";
				/// <summary>Constant value for <see cref="TypeProperty.Modifier" /></summary>
				public const string MODIFIER = "static";
				/// <summary>Constant value for <see cref="TypeProperty.NormativeVersion" /></summary>
				public const string NORMATIVE_VERSION = "1.0";
				/// <summary>Constant value for <see cref="TypeProperty.DeprecatedVersion" /></summary>
				public const string DEPRECATED_VERSION = "";
				/// <summary>Constant value for <see cref="TypeProperty.Aggregation" /></summary>
				public const string AGGREGATION = "composite";
				/// <summary>Constant value for <see cref="TypeProperty.Extension" /></summary>
				public const string EXTENSION = "MagicDraw UML 2024x";
				/// <summary>Constant value for <see cref="TypeProperty.Association" /></summary>
				public const string ASSOCIATION = "";
				/// <summary>Constant value for <see cref="TypeProperty.DefaultValue" /></summary>
				public const string DEFAULT_VALUE = "";

				/// <summary>
				/// <inheritdoc />
				/// <remarks> Type: DataItemTypeEnumMetaClass </remarks>
				/// </summary>
				public System.Type Type => typeof(Mtconnect.DataTypes.DataItemTypeEnumMetaClass);
				
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
			/// <inheritdoc cref="UnitsProperty" path="/summary" /><br/>
			/// <remarks>Original Name: Units</remarks>
			/// </summary>
			public new UnitsProperty Units { get; } = new UnitsProperty();
			
			/// <summary>﻿units of the <see cref="DataItem">DataItem</see> associated with this <see cref="Observation">Observation</see>.<br /><br /><see cref="Observation.units">units in Observation</see> <b>MUST</b> match the associated <see cref="DataItem.units">units in DataItem</see> defined in the <i>MTConnectDevices Response Document</i>.<br /><br /><br />
			/// </summary>
			public new sealed class UnitsProperty : IProperty
			{
				/// <summary>Constant value for <see cref="UnitsProperty.Name" /></summary>
				public const string NAME = "units";
				/// <summary>Constant value for <see cref="UnitsProperty.Summary" /></summary>
				public const string SUMMARY = @"&#10;&#10;&#10;units of the {{block(DataItem)}} associated with this {{block(Observation)}}.

{{property(Observation::units)}} **MUST** match the associated {{property(DataItem::units)}} defined in the {{term(MTConnectDevices Response Document)}}.&#10;
";
				/// <summary>Constant value for <see cref="UnitsProperty.AccessModifier" /></summary>
				public const string ACCESS_MODIFIER = "public";
				/// <summary>Constant value for <see cref="UnitsProperty.Modifier" /></summary>
				public const string MODIFIER = "static";
				/// <summary>Constant value for <see cref="UnitsProperty.NormativeVersion" /></summary>
				public const string NORMATIVE_VERSION = "1.0";
				/// <summary>Constant value for <see cref="UnitsProperty.DeprecatedVersion" /></summary>
				public const string DEPRECATED_VERSION = "";
				/// <summary>Constant value for <see cref="UnitsProperty.Aggregation" /></summary>
				public const string AGGREGATION = "composite";
				/// <summary>Constant value for <see cref="UnitsProperty.Extension" /></summary>
				public const string EXTENSION = "MagicDraw UML 2024x";
				/// <summary>Constant value for <see cref="UnitsProperty.Association" /></summary>
				public const string ASSOCIATION = "";
				/// <summary>Constant value for <see cref="UnitsProperty.DefaultValue" /></summary>
				public const string DEFAULT_VALUE = "";

				/// <summary>
				/// <inheritdoc />
				/// <remarks> Type: UnitEnumMetaClass </remarks>
				/// </summary>
				public System.Type Type => typeof(Mtconnect.DataTypes.UnitEnumMetaClass);
				
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
			/// <inheritdoc cref="IsUnavailableProperty" path="/summary" /><br/>
			/// <remarks>Original Name: IsUnavailable</remarks>
			/// </summary>
			public new IsUnavailableProperty IsUnavailable { get; } = new IsUnavailableProperty();
			
			/// <summary>﻿when <c>true</c>, <see cref="Observation.result">result in Observation</see> is indeterminate.<br /><br />&gt; Note 1 to entry: In <i>XML</i>, when <c>isUnavailable</c> is <c>true</c>, the <i>XML</i> <c>CDATA</c> of the <c>Observation</c> <b>MUST</b> be <c>UNAVAILABLE</c>.<br /> <c></c>`xml<br />&lt;Execution dataItemId="..." ...&gt;UNAVAILABLE&lt;/Execution&gt;<br /><c></c>`<br /><br />&gt; Note 2 to entry: In <i>JSON</i>, when <c>isUnavailable</c> is <c>true</c>, the <i>JSON</i> <c>value</c> of the <c>Observation</c> <b>MUST</b> be <c>UNAVAILABLE</c>.<br /><c></c>`json<br />  "Execution" : [ { "dataItemId": "..." ..., "value": "UNAVAILABLE" } ]<br /><c></c>`<br /><br /><br />
			/// </summary>
			public new sealed class IsUnavailableProperty : IProperty
			{
				/// <summary>Constant value for <see cref="IsUnavailableProperty.Name" /></summary>
				public const string NAME = "isUnavailable";
				/// <summary>Constant value for <see cref="IsUnavailableProperty.Summary" /></summary>
				public const string SUMMARY = @"&#10;&#10;&#10;when `true`, {{property(Observation::result)}} is indeterminate.

> Note 1 to entry: In {{term(XML)}}, when `isUnavailable` is `true`, the {{term(XML)}} `CDATA` of the `Observation` **MUST** be `UNAVAILABLE`.
 ```xml
<Execution dataItemId=""..."" ...>UNAVAILABLE</Execution>
```

> Note 2 to entry: In {{term(JSON)}}, when `isUnavailable` is `true`, the {{term(JSON)}} `value` of the `Observation` **MUST** be `UNAVAILABLE`.
```json
  ""Execution"" : [ { ""dataItemId"": ""..."" ..., ""value"": ""UNAVAILABLE"" } ]
```&#10;
";
				/// <summary>Constant value for <see cref="IsUnavailableProperty.AccessModifier" /></summary>
				public const string ACCESS_MODIFIER = "public";
				/// <summary>Constant value for <see cref="IsUnavailableProperty.Modifier" /></summary>
				public const string MODIFIER = "";
				/// <summary>Constant value for <see cref="IsUnavailableProperty.NormativeVersion" /></summary>
				public const string NORMATIVE_VERSION = "1.0";
				/// <summary>Constant value for <see cref="IsUnavailableProperty.DeprecatedVersion" /></summary>
				public const string DEPRECATED_VERSION = "";
				/// <summary>Constant value for <see cref="IsUnavailableProperty.Aggregation" /></summary>
				public const string AGGREGATION = "composite";
				/// <summary>Constant value for <see cref="IsUnavailableProperty.Extension" /></summary>
				public const string EXTENSION = "MagicDraw UML 2024x";
				/// <summary>Constant value for <see cref="IsUnavailableProperty.Association" /></summary>
				public const string ASSOCIATION = "";
				/// <summary>Constant value for <see cref="IsUnavailableProperty.DefaultValue" /></summary>
				public const string DEFAULT_VALUE = "";

				/// <summary>
				/// <inheritdoc />
				/// <remarks> Type: Boolean </remarks>
				/// </summary>
				public System.Type Type => typeof(Boolean);
				
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
			/// <inheritdoc cref="ResultProperty" path="/summary" /><br/>
			/// <remarks>Original Name: Result</remarks>
			/// </summary>
			public new ResultProperty Result { get; } = new ResultProperty();
			
			/// <summary>﻿<i>observation</i> of the <see cref="Observation">Observation</see> entity.<br /><br />The default value type for <see cref="Observation.result">result in Observation</see> is <c>string</c>.<br /><br />&gt; Note 1 to entry: in <i>XML</i> the <see cref="Observation.result">result in Observation</see> is the <c>CDATA</c> of the Observation <i>element</i>.<br /><br />~~~~xml<br />&lt;Execution dataItemId="..." ...&gt;READY&lt;/Execution&gt;<br />~~~~<br /><br />&gt; Note 2 to entry: in <i>JSON</i> the <see cref="Observation.result">result in Observation</see> is the member <c>value</c> of the Observation object.<br /><br />~~~~json<br />"Execution" : [ { "dataItemId": "..." ..., "value": "READY" } ]<br />~~~~<br /><br /><br />
			/// </summary>
			public new sealed class ResultProperty : IProperty
			{
				/// <summary>Constant value for <see cref="ResultProperty.Name" /></summary>
				public const string NAME = "result";
				/// <summary>Constant value for <see cref="ResultProperty.Summary" /></summary>
				public const string SUMMARY = @"&#10;&#10;&#10;{{term(observation)}} of the {{block(Observation)}} entity.

The default value type for {{property(Observation::result)}} is `string`.

> Note 1 to entry: in {{term(XML)}} the {{property(Observation::result)}} is the `CDATA` of the Observation {{term(element)}}.

~~~~xml
<Execution dataItemId=""..."" ...>READY</Execution>
~~~~

> Note 2 to entry: in {{term(JSON)}} the {{property(Observation::result)}} is the member `value` of the Observation object.

~~~~json
""Execution"" : [ { ""dataItemId"": ""..."" ..., ""value"": ""READY"" } ]
~~~~&#10;
";
				/// <summary>Constant value for <see cref="ResultProperty.AccessModifier" /></summary>
				public const string ACCESS_MODIFIER = "public";
				/// <summary>Constant value for <see cref="ResultProperty.Modifier" /></summary>
				public const string MODIFIER = "";
				/// <summary>Constant value for <see cref="ResultProperty.NormativeVersion" /></summary>
				public const string NORMATIVE_VERSION = "1.0";
				/// <summary>Constant value for <see cref="ResultProperty.DeprecatedVersion" /></summary>
				public const string DEPRECATED_VERSION = "";
				/// <summary>Constant value for <see cref="ResultProperty.Aggregation" /></summary>
				public const string AGGREGATION = "composite";
				/// <summary>Constant value for <see cref="ResultProperty.Extension" /></summary>
				public const string EXTENSION = "MagicDraw UML 2024x";
				/// <summary>Constant value for <see cref="ResultProperty.Association" /></summary>
				public const string ASSOCIATION = "";
				/// <summary>Constant value for <see cref="ResultProperty.DefaultValue" /></summary>
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
			/// <inheritdoc cref="MadeForDataItemPartProperty" path="/summary" /><br/>
			/// <remarks>Original Name: MadeForDataItem</remarks>
			/// </summary>
			public new MadeForDataItemPartProperty MadeForDataItemPart { get; } = new MadeForDataItemPartProperty();
			
			/// <summary>﻿
			/// </summary>
			public new sealed class MadeForDataItemPartProperty : IProperty
			{
				/// <summary>Constant value for <see cref="MadeForDataItemPartProperty.Name" /></summary>
				public const string NAME = "madeForDataItem";
				/// <summary>Constant value for <see cref="MadeForDataItemPartProperty.Summary" /></summary>
				public const string SUMMARY = @"";
				/// <summary>Constant value for <see cref="MadeForDataItemPartProperty.AccessModifier" /></summary>
				public const string ACCESS_MODIFIER = "private";
				/// <summary>Constant value for <see cref="MadeForDataItemPartProperty.Modifier" /></summary>
				public const string MODIFIER = "";
				/// <summary>Constant value for <see cref="MadeForDataItemPartProperty.NormativeVersion" /></summary>
				public const string NORMATIVE_VERSION = "";
				/// <summary>Constant value for <see cref="MadeForDataItemPartProperty.DeprecatedVersion" /></summary>
				public const string DEPRECATED_VERSION = "";
				/// <summary>Constant value for <see cref="MadeForDataItemPartProperty.Aggregation" /></summary>
				public const string AGGREGATION = "";
				/// <summary>Constant value for <see cref="MadeForDataItemPartProperty.Extension" /></summary>
				public const string EXTENSION = "MagicDraw UML 2024x";
				/// <summary>Constant value for <see cref="MadeForDataItemPartProperty.Association" /></summary>
				public const string ASSOCIATION = "Observations";
				/// <summary>Constant value for <see cref="MadeForDataItemPartProperty.DefaultValue" /></summary>
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
			/// <inheritdoc cref="QualityProperty" path="/summary" /><br/>
			/// <remarks>Original Name: Quality</remarks>
			/// </summary>
			public new QualityProperty Quality { get; } = new QualityProperty();
			
			/// <summary>﻿indicates if the <see cref="Observation">Observation</see> is verifiable and is in accordance with the normative definitions within the MTConnect Standard.<br /><br /><br />
			/// </summary>
			public new sealed class QualityProperty : IProperty
			{
				/// <summary>Constant value for <see cref="QualityProperty.Name" /></summary>
				public const string NAME = "quality";
				/// <summary>Constant value for <see cref="QualityProperty.Summary" /></summary>
				public const string SUMMARY = @"&#10;&#10;&#10;indicates if the {{block(Observation)}} is verifiable and is in accordance with the normative definitions within the MTConnect Standard.&#10;
";
				/// <summary>Constant value for <see cref="QualityProperty.AccessModifier" /></summary>
				public const string ACCESS_MODIFIER = "private";
				/// <summary>Constant value for <see cref="QualityProperty.Modifier" /></summary>
				public const string MODIFIER = "";
				/// <summary>Constant value for <see cref="QualityProperty.NormativeVersion" /></summary>
				public const string NORMATIVE_VERSION = "2.5";
				/// <summary>Constant value for <see cref="QualityProperty.DeprecatedVersion" /></summary>
				public const string DEPRECATED_VERSION = "";
				/// <summary>Constant value for <see cref="QualityProperty.Aggregation" /></summary>
				public const string AGGREGATION = "composite";
				/// <summary>Constant value for <see cref="QualityProperty.Extension" /></summary>
				public const string EXTENSION = "MagicDraw UML 2024x";
				/// <summary>Constant value for <see cref="QualityProperty.Association" /></summary>
				public const string ASSOCIATION = "";
				/// <summary>Constant value for <see cref="QualityProperty.DefaultValue" /></summary>
				public const string DEFAULT_VALUE = "UNVERIFIABLE";

				/// <summary>
				/// <inheritdoc />
				/// <remarks> Type: QualityEnumMetaClass </remarks>
				/// </summary>
				public System.Type Type => typeof(Mtconnect.DataTypes.QualityEnumMetaClass);
				
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
			/// <inheritdoc cref="DeprecatedProperty" path="/summary" /><br/>
			/// <remarks>Original Name: Deprecated</remarks>
			/// </summary>
			public new DeprecatedProperty Deprecated { get; } = new DeprecatedProperty();
			
			/// <summary>﻿indicates if the <see cref="Observation">Observation</see> has any property or controlled vocabulary that has been deprecated in the MTConnect Standard.<br /><br /><br />
			/// </summary>
			public new sealed class DeprecatedProperty : IProperty
			{
				/// <summary>Constant value for <see cref="DeprecatedProperty.Name" /></summary>
				public const string NAME = "deprecated";
				/// <summary>Constant value for <see cref="DeprecatedProperty.Summary" /></summary>
				public const string SUMMARY = @"&#10;&#10;&#10;indicates if the {{block(Observation)}} has any property or controlled vocabulary that has been deprecated in the MTConnect Standard.&#10;
";
				/// <summary>Constant value for <see cref="DeprecatedProperty.AccessModifier" /></summary>
				public const string ACCESS_MODIFIER = "private";
				/// <summary>Constant value for <see cref="DeprecatedProperty.Modifier" /></summary>
				public const string MODIFIER = "";
				/// <summary>Constant value for <see cref="DeprecatedProperty.NormativeVersion" /></summary>
				public const string NORMATIVE_VERSION = "2.5";
				/// <summary>Constant value for <see cref="DeprecatedProperty.DeprecatedVersion" /></summary>
				public const string DEPRECATED_VERSION = "";
				/// <summary>Constant value for <see cref="DeprecatedProperty.Aggregation" /></summary>
				public const string AGGREGATION = "composite";
				/// <summary>Constant value for <see cref="DeprecatedProperty.Extension" /></summary>
				public const string EXTENSION = "MagicDraw UML 2024x";
				/// <summary>Constant value for <see cref="DeprecatedProperty.Association" /></summary>
				public const string ASSOCIATION = "";
				/// <summary>Constant value for <see cref="DeprecatedProperty.DefaultValue" /></summary>
				public const string DEFAULT_VALUE = "";

				/// <summary>
				/// <inheritdoc />
				/// <remarks> Type: Boolean </remarks>
				/// </summary>
				public System.Type Type => typeof(Boolean);
				
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
			/// <inheritdoc cref="ExtendedProperty" path="/summary" /><br/>
			/// <remarks>Original Name: Extended</remarks>
			/// </summary>
			public new ExtendedProperty Extended { get; } = new ExtendedProperty();
			
			/// <summary>﻿indicates if the <see cref="Observation">Observation</see> has any property or controlled vocabulary that has been extended and cannot be validated.<br /><br /><br />
			/// </summary>
			public new sealed class ExtendedProperty : IProperty
			{
				/// <summary>Constant value for <see cref="ExtendedProperty.Name" /></summary>
				public const string NAME = "extended";
				/// <summary>Constant value for <see cref="ExtendedProperty.Summary" /></summary>
				public const string SUMMARY = @"&#10;&#10;&#10;indicates if the {{block(Observation)}} has any property or controlled vocabulary that has been extended and cannot be validated.&#10;
";
				/// <summary>Constant value for <see cref="ExtendedProperty.AccessModifier" /></summary>
				public const string ACCESS_MODIFIER = "private";
				/// <summary>Constant value for <see cref="ExtendedProperty.Modifier" /></summary>
				public const string MODIFIER = "";
				/// <summary>Constant value for <see cref="ExtendedProperty.NormativeVersion" /></summary>
				public const string NORMATIVE_VERSION = "2.5";
				/// <summary>Constant value for <see cref="ExtendedProperty.DeprecatedVersion" /></summary>
				public const string DEPRECATED_VERSION = "";
				/// <summary>Constant value for <see cref="ExtendedProperty.Aggregation" /></summary>
				public const string AGGREGATION = "composite";
				/// <summary>Constant value for <see cref="ExtendedProperty.Extension" /></summary>
				public const string EXTENSION = "MagicDraw UML 2024x";
				/// <summary>Constant value for <see cref="ExtendedProperty.Association" /></summary>
				public const string ASSOCIATION = "";
				/// <summary>Constant value for <see cref="ExtendedProperty.DefaultValue" /></summary>
				public const string DEFAULT_VALUE = "";

				/// <summary>
				/// <inheritdoc />
				/// <remarks> Type: Boolean </remarks>
				/// </summary>
				public System.Type Type => typeof(Boolean);
				
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

	}
}