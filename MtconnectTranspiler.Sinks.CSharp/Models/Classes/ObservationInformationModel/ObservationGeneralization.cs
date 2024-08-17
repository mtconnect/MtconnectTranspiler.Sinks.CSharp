#pragma warning disable CS0109 // Member does not hide an inherited member; new keyword is not required
#pragma warning disable CS1574 // XML comment has cref attribute that could not be resolved
#pragma warning disable CS1584 // XML comment has syntactically incorrect cref attribute
using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;
using System.Linq;

namespace Mtconnect.ObservationInformationModel
{
	/// <summary>﻿abstract entity that provides telemetry data for a <see cref="DataItem">DataItem</see> at a point in time.<br /><br /><br />Description<br /><br />![Observations](figures/Observations.png "Observations"){: width="0.8"}<br /><br />&gt; Note: See <see cref="Observations Schema Diagrams">Observations Schema Diagrams</see> for XML schema. The XML schema also shows differences in XML representation of certain MTConnect entities.<br /><br />{{figure(DeviceStream Example)}} shows a complete example of <see cref="DeviceStream">DeviceStream</see> for the <see cref="Device">Device</see> shown in <see cref="Device Information Model">Device Information Model</see>.<br /><br />![DeviceStream Example](figures/DeviceStream%20Example.png "DeviceStream Example"){: width="0.8"}<br /><br />&gt; Note: See {{lst(devicestream-example)}} for the <i>XML</i> representation of the same example.<br /><br /><br />This section provides semantic information for the <see cref="Observation">Observation</see> model.<br /><br />&gt; Note: See <see cref="Observations Schema Diagrams">Observations Schema Diagrams</see> for XML schema of <see cref="Observation">Observation</see> types.<br /><br />#### Observations made for DataItem<br /><br /><see cref="Component">Component</see> <i>observe</i>s <see cref="DataItem">DataItem</see> entities and creates <see cref="Observation">Observation</see> entities for the <see cref="DataItem">DataItem</see> entities. See {{figure(Observations)}}.<br /><br /><see cref="Observation">Observation</see> entities made by a <see cref="Component">Component</see> are organized by a <see cref="ComponentStream">ComponentStream</see> which is specifically created for that <see cref="Component">Component</see>.<br /><br />![Observations made for DataItem Example](figures/Observations%20made%20for%20DataItem%20Example.png "Observations made for DataItem Example"){: width="0.8"}<br /><br />&gt; Note: See <see cref="Observations made for DataItem Example">Observations made for DataItem Example</see> for how XML representation of the same example is separated into <i>MTConnectDevices Response Document</i> and <i>MTConnectStreams Response Document</i>.<br /><br />{{figure(Observations made for DataItem Example)}} is a subset of {{figure(DeviceStream Example)}}. It shows an example of the association between a <see cref="DataItem">DataItem</see> <see cref="Event">Event</see> type (<c>EMERGENCY_STOP</c>) and an <see cref="Observation">Observation</see> <see cref="Event">Event</see> type (<c>EmergencyStop</c>). See <see cref="Naming Convention for Observation types">Naming Convention for Observation types</see>.<br /><br />{{figure(Observations made for DataItem Example)}} also shows example of the association between a <see cref="Component">Component</see> type (<c>Controller</c>) and related <see cref="ComponentStream">ComponentStream</see>.<br /><br />#### Naming Convention for Observation types<br /><br />The name of an <see cref="Observation">Observation</see> type <b>MUST</b> derive from the associated <see cref="DataItem.type">type in DataItem</see> converted to Pascal-Case by removing underscores (_ ) and capitalizing each word. The conversion <b>MUST NOT</b> apply to the following abbreviated words: <c>PH</c>, <c>AC</c>, <c>DC</c> and <c>URI</c>. <c>MTCONNECT</c> <b>MUST</b> be converted to <c>MTConnect</c>. See {{figure(Observations made for DataItem Example)}} for an example.<br /><br />The name of an <see cref="Observation">Observation</see> type reported in the <i>MTConnectStreams Response Document</i> is extended when the <see cref="DataItem.representation">representation in DataItem</see> is used to further describe that <see cref="DataItem">DataItem</see> in the <i>MTConnectDevices Response Document</i>. See <see cref="Representations">Representations</see> for more details.<br /><br /><br /><br /><br />
	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Structure___19_0_3_45f01b9_1579566531115_47734_25731">model.mtconnect.org</seealso> for more information.
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public sealed class ObservationGeneralization : IClass
	{
		/// <inheritdoc />
		public string ReferenceId => "_19_0_3_45f01b9_1579566531115_47734_25731";
		
		/// <inheritdoc />
		public string Summary => @"&#10;&#10;&#10;abstract entity that provides telemetry data for a {{block(DataItem)}} at a point in time.&#10;
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
		/// <summary>
		/// Property list for <see cref="ObservationGeneralization" />.
		/// <br/><b>Note</b>, some properties (<see cref="IProperty" />) are inherited from <see cref="Mtconnect.Glossary.MTConnectTerms.ObservationClass.ObservationClassProperties" />.
		/// </summary>
		public class ObservationGeneralizationProperties : Mtconnect.Glossary.MTConnectTerms.ObservationClass.ObservationClassProperties
		{
			/// <inheritdoc />
			public new IProperty[] Properties => new IProperty[] {
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
			public new CompositionIdProperty CompositionId { get; } = new CompositionIdProperty();
			
			/// <summary>﻿identifier of the <see cref="Composition">Composition</see> entity defined in the <i>MTConnectDevices Response Document</i> associated with the data reported for the <see cref="Observation">Observation</see>.<br /><br /><br />
			/// </summary>
			public new sealed class CompositionIdProperty : IProperty
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
				public string Summary => @"&#10;&#10;&#10;identifier of the {{block(Composition)}} entity defined in the {{term(MTConnectDevices Response Document)}} associated with the data reported for the {{block(Observation)}}.&#10;
";

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
			public new DataItemIdProperty DataItemId { get; } = new DataItemIdProperty();
			
			/// <summary>﻿unique identifier of the <see cref="DataItem">DataItem</see> associated with this <see cref="Observation">Observation</see>.<br /><br /><see cref="Observation.dataItemId">dataItemId in Observation</see> <b>MUST</b> match the associated <see cref="DataItem.id">id in DataItem</see> defined in the <i>MTConnectDevices Response Document</i>.<br /><br /><br />
			/// </summary>
			public new sealed class DataItemIdProperty : IProperty
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
				public string Summary => @"&#10;&#10;&#10;unique identifier of the {{block(DataItem)}} associated with this {{block(Observation)}}.

{{property(Observation::dataItemId)}} **MUST** match the associated {{property(DataItem::id)}} defined in the {{term(MTConnectDevices Response Document)}}.&#10;
";

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
			public new NameProperty Name { get; } = new NameProperty();
			
			/// <summary>﻿name of the <see cref="DataItem">DataItem</see> associated with this <see cref="Observation">Observation</see>.<br /><br /><see cref="Observation.name">name in Observation</see> <b>MUST</b> match the associated <see cref="DataItem.name">name in DataItem</see> defined in the <i>MTConnectDevices Response Document</i>.<br /><br /><br />
			/// </summary>
			public new sealed class NameProperty : IProperty
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
				public string Summary => @"&#10;&#10;&#10;name of the {{block(DataItem)}} associated with this {{block(Observation)}}.

{{property(Observation::name)}} **MUST** match the associated {{property(DataItem::name)}} defined in the {{term(MTConnectDevices Response Document)}}.&#10;
";

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
			public new SequenceProperty Sequence { get; } = new SequenceProperty();
			
			/// <summary>﻿number representing the sequential position of an occurrence of an <i>observation</i> in the data buffer of an <i>agent</i>.<br /><br /><see cref="Observation.sequence">sequence in Observation</see> <b>MUST</b> have a value represented as an unsigned 64-bit value from 1 to <i> 2^{64}-1 </i>.<br /><br /><br />
			/// </summary>
			public new sealed class SequenceProperty : IProperty
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
				public string Summary => @"&#10;&#10;&#10;number representing the sequential position of an occurrence of an {{term(observation)}} in the data buffer of an {{term(agent)}}.

{{property(Observation::sequence)}} **MUST** have a value represented as an unsigned 64-bit value from 1 to $$ 2^{64}-1 $$.&#10;
";

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
			public new SubTypeProperty SubType { get; } = new SubTypeProperty();
			
			/// <summary>﻿subtype of the <see cref="DataItem">DataItem</see> associated with this <see cref="Observation">Observation</see>.<br /><br /><see cref="Observation.subType">subType in Observation</see> <b>MUST</b> match the associated <see cref="DataItem.subType">subType in DataItem</see> defined in the <i>MTConnectDevices Response Document</i>.<br /><br /><br />
			/// </summary>
			public new sealed class SubTypeProperty : IProperty
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
				public string Summary => @"&#10;&#10;&#10;subtype of the {{block(DataItem)}} associated with this {{block(Observation)}}.

{{property(Observation::subType)}} **MUST** match the associated {{property(DataItem::subType)}} defined in the {{term(MTConnectDevices Response Document)}}.&#10;
";

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
			public new TimestampProperty Timestamp { get; } = new TimestampProperty();
			
			/// <summary>﻿most accurate time available to a piece of equipment that represents the point in time that the data reported was measured.<br /><br /><br />
			/// </summary>
			public new sealed class TimestampProperty : IProperty
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
				public string Summary => @"&#10;&#10;&#10;most accurate time available to a piece of equipment that represents the point in time that the data reported was measured.&#10;
";

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
			public new MadeByComponentPartProperty MadeByComponentPart { get; } = new MadeByComponentPartProperty();
			
			/// <summary>﻿
			/// </summary>
			public new sealed class MadeByComponentPartProperty : IProperty
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
				public string Summary => @"";

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
			public new TypeProperty Type { get; } = new TypeProperty();
			
			/// <summary>﻿type of the <see cref="DataItem">DataItem</see> associated with this <see cref="Observation">Observation</see>.<br /><br /><see cref="Observation.type">type in Observation</see> <b>MUST</b> match the associated <see cref="DataItem.type">type in DataItem</see> defined in the <i>MTConnectDevices Response Document</i>.<br /><br /><br />
			/// </summary>
			public new sealed class TypeProperty : IProperty
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
				public string Summary => @"&#10;&#10;&#10;type of the {{block(DataItem)}} associated with this {{block(Observation)}}.

{{property(Observation::type)}} **MUST** match the associated {{property(DataItem::type)}} defined in the {{term(MTConnectDevices Response Document)}}.&#10;
";

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
			public new UnitsProperty Units { get; } = new UnitsProperty();
			
			/// <summary>﻿units of the <see cref="DataItem">DataItem</see> associated with this <see cref="Observation">Observation</see>.<br /><br /><see cref="Observation.units">units in Observation</see> <b>MUST</b> match the associated <see cref="DataItem.units">units in DataItem</see> defined in the <i>MTConnectDevices Response Document</i>.<br /><br /><br />
			/// </summary>
			public new sealed class UnitsProperty : IProperty
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
				public string Summary => @"&#10;&#10;&#10;units of the {{block(DataItem)}} associated with this {{block(Observation)}}.

{{property(Observation::units)}} **MUST** match the associated {{property(DataItem::units)}} defined in the {{term(MTConnectDevices Response Document)}}.&#10;
";

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
			public new IsUnavailableProperty IsUnavailable { get; } = new IsUnavailableProperty();
			
			/// <summary>﻿when <c>true</c>, <see cref="Observation.result">result in Observation</see> is indeterminate.<br /><br />&gt; Note 1 to entry: In <i>XML</i>, when <c>isUnavailable</c> is <c>true</c>, the <i>XML</i> <c>CDATA</c> of the <c>Observation</c> <b>MUST</b> be <c>UNAVAILABLE</c>.<br /> <c></c>`xml<br />&lt;Execution dataItemId="..." ...&gt;UNAVAILABLE&lt;/Execution&gt;<br /><c></c>`<br /><br />&gt; Note 2 to entry: In <i>JSON</i>, when <c>isUnavailable</c> is <c>true</c>, the <i>JSON</i> <c>value</c> of the <c>Observation</c> <b>MUST</b> be <c>UNAVAILABLE</c>.<br /><c></c>`json<br />  "Execution" : [ { "dataItemId": "..." ..., "value": "UNAVAILABLE" } ]<br /><c></c>`<br /><br /><br />
			/// </summary>
			public new sealed class IsUnavailableProperty : IProperty
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
				public string Summary => @"&#10;&#10;&#10;when `true`, {{property(Observation::result)}} is indeterminate.

> Note 1 to entry: In {{term(XML)}}, when `isUnavailable` is `true`, the {{term(XML)}} `CDATA` of the `Observation` **MUST** be `UNAVAILABLE`.
 ```xml
<Execution dataItemId=""..."" ...>UNAVAILABLE</Execution>
```

> Note 2 to entry: In {{term(JSON)}}, when `isUnavailable` is `true`, the {{term(JSON)}} `value` of the `Observation` **MUST** be `UNAVAILABLE`.
```json
  ""Execution"" : [ { ""dataItemId"": ""..."" ..., ""value"": ""UNAVAILABLE"" } ]
```&#10;
";

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
			public new ResultProperty Result { get; } = new ResultProperty();
			
			/// <summary>﻿<i>observation</i> of the <see cref="Observation">Observation</see> entity.<br /><br />The default value type for <see cref="Observation.result">result in Observation</see> is <c>string</c>.<br /><br />&gt; Note 1 to entry: in <i>XML</i> the <see cref="Observation.result">result in Observation</see> is the <c>CDATA</c> of the Observation <i>element</i>.<br /><br />~~~~xml<br />&lt;Execution dataItemId="..." ...&gt;READY&lt;/Execution&gt;<br />~~~~<br /><br />&gt; Note 2 to entry: in <i>JSON</i> the <see cref="Observation.result">result in Observation</see> is the member <c>value</c> of the Observation object.<br /><br />~~~~json<br />"Execution" : [ { "dataItemId": "..." ..., "value": "READY" } ]<br />~~~~<br /><br /><br />
			/// </summary>
			public new sealed class ResultProperty : IProperty
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
				public string Summary => @"&#10;&#10;&#10;{{term(observation)}} of the {{block(Observation)}} entity.

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
			public new MadeForDataItemPartProperty MadeForDataItemPart { get; } = new MadeForDataItemPartProperty();
			
			/// <summary>﻿
			/// </summary>
			public new sealed class MadeForDataItemPartProperty : IProperty
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
				public string Summary => @"";

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