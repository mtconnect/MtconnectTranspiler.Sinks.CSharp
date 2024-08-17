#pragma warning disable CS1574 // XML comment has cref attribute that could not be resolved
#pragma warning disable CS1584 // XML comment has syntactically incorrect cref attribute
using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;
using Package = Mtconnect.ObservationInformationModel;

namespace Mtconnect
{
	/// <summary>﻿The <i>Observation Information Model</i> provides a representation of the data reported by a piece of equipment used for a manufacturing process, or used for any other purpose.  Additional descriptive information associated with the reported data is defined by the <see cref="MTConnectDevices">MTConnectDevices</see> entity, which is described in <see cref="Device Information Model">Device Information Model</see>.<br /><br />Information defined in the <i>Observation Information Model</i> allows a software application to (1) determine the <i>Observation</i>s for <i>DataItem</i>s returned from a piece of equipment and (2) interpret the data associated with those <i>Observation</i>s with the same meaning, value, and context that it had at its original source.  To do this, the software application issues one of two HTTP requests to an <i>agent</i> associated with a piece of equipment.  They are:<br /><br />* <c>sample</c>:  Returns a designated number of time stamped <i>Observation</i>s from an <i>agent</i> associated with a piece of equipment; subject to any HTTP filtering associated with the request.  See <see cref="Agent">Agent</see> in <see cref="Fundamentals">Fundamentals</see> for details on the <c>sample</c> HTTP request.<br /><br />* <c>current</c>:  Returns a snapshot of either the most recent values or the values at a given sequence number for all <i>Observation</i>s associated with a piece of equipment from an <i>agent</i>; subject to any HTTP filtering associated with the request.  See <see cref="Agent">Agent</see> in <see cref="Fundamentals">Fundamentals</see> for details on the <c>current</c> HTTP request.<br /><br /><br />An <i>agent</i> responds to either the <c>sample</c> or <c>current</c> HTTP request with an <i>MTConnectStreams Response Document</i>.  This document contains information describing <i>Observation</i>s reported by an <i>agent</i> associated with a piece of equipment.   A client software application may correlate the information provided in the <i>MTConnectStreams Response Document</i> with the physical and logical structure for that piece of equipment defined in the <see cref="MTConnectDevices">MTConnectDevices</see> entity to form a clear and unambiguous understanding of the information provided.  (See details on the structure for a piece of equipment described in <see cref="Device Information Model">Device Information Model</see>).<br /><br /><see cref="Streams">Streams</see> for an <see cref="MTConnectStreams">MTConnectStreams</see> entity contains a <see cref="DeviceStream">DeviceStream</see> entity for each piece of equipment represented in the document.  Each <see cref="DeviceStream">DeviceStream</see> is comprised of two primary types of entities – <i>Component</i>s and <i>Observation</i>s.  The contents of the <see cref="DeviceStream">DeviceStream</see> container are described in detail in this document, <see cref="Observation Information Model">Observation Information Model</see> of the MTConnect Standard.<br /><br /><i>Component</i>s are defined for both the <see cref="MTConnectDevices">MTConnectDevices</see> and the <see cref="MTConnectStreams">MTConnectStreams</see> entities.  These <i>Component</i>s are used to provide a logical organization of the information provided in each entity.  <br /><br />* For an <see cref="MTConnectDevices">MTConnectDevices</see> entity: <i>Component</i>s organize information that represents the physical and logical parts and sub-parts of a piece of equipment.  (See <see cref="Component">Component</see> in <see cref="Device Information Model">Device Information Model</see> for more details on <i>Component</i>s used in the <see cref="MTConnectDevices">MTConnectDevices</see> entity).  <br /><br />* For an <see cref="MTConnectStreams">MTConnectStreams</see> entity: <i>Component</i>s provide the structure to organize the data returned from a piece of equipment and establishes the proper context for that data.  The <i>Component</i>s specifically defined for <see cref="MTConnectStreams">MTConnectStreams</see> are <see cref="DeviceStream">DeviceStream</see> (see <see cref="DeviceStream">DeviceStream</see>) and <see cref="ComponentStream">ComponentStream</see> (see <see cref="ComponentStream">ComponentStream</see>).   <br /><br /><see cref="DeviceStream">DeviceStream</see> and <see cref="ComponentStream">ComponentStream</see> entities have a direct correlation to each of the <i>Component</i> defined in the <see cref="MTConnectDevices">MTConnectDevices</see> entity.<br /><br />Within each <see cref="ComponentStream">ComponentStream</see> entity in the <see cref="MTConnectStreams">MTConnectStreams</see> entity, <i>Observation</i>s are modeled as <see cref="Observation">Observation</see> entities. The three types of <see cref="Observation">Observation</see> entity are <see cref="Sample">Sample</see>, <see cref="Event">Event</see>, and <see cref="Condition">Condition</see>.  (See <see cref="Observation Types">Observation Types</see> for more information on these entities.)<br /><br /><br /><br />Observations Appendix<br /><br />{{newpage()}} <br /><br />## XML Schema Diagrams<br /><br />### Observations Schema Diagrams<br /><br />See <c>Streams</c> element in <c>MTConnectStreams</c> schema.<br /><br />See <c>DeviceStream</c> element in <c>MTConnectStreams</c> schema.<br /><br />See <c>ComponentStream</c> element in <c>MTConnectStreams</c> schema.<br /><br />See <c>Sample</c> element in <c>MTConnectStreams</c> schema.<br /><br />See <c>Event</c> element in <c>MTConnectStreams</c> schema.<br /><br />See <c>Condition</c> element in <c>MTConnectStreams</c> schema.<br /><br />### Representation Schema Diagrams<br /><br />See <c>AbsTimeSeries</c> element in <c>MTConnectStreams</c> schema.<br /><br />See <c>PartCountDiscrete</c> element in <c>MTConnectStreams</c> schema.<br /><br />See <c>VariableDataSet</c> element in <c>MTConnectStreams</c> schema.<br /><br />See <c>Entry</c> element in <c>MTConnectStreams</c> schema.<br /><br />See <c>WorkOffsetTable</c> element in <c>MTConnectStreams</c> schema.<br /><br />## XML Examples<br /><br />### DeviceStream Example<br /><br />~~~~xml<br />&lt;Streams&gt;<br />  &lt;DeviceStream name="M12346" uuid="M8010W4194N"&gt;<br />    &lt;ComponentStream component="Device" name="M12346" componentId="d1"&gt;<br />      &lt;Events&gt;<br />        &lt;Availability dataItemId="avail" sequence="156" timestamp="2021-10-01T14:26:38.668505Z"&gt;AVAILABLE&lt;/Availability&gt;<br />        &lt;AssetChanged assetType="CuttingTool" dataItemId="d1_asset_chg" sequence="75570" timestamp="2021-10-07T05:08:53.870206Z"&gt;M8010W4194N1.120&lt;/AssetChanged&gt;<br />        &lt;AssetRemoved assetType="CuttingTool" dataItemId="d1_asset_rem" sequence="140" timestamp="2021-10-01T11:40:08.101461Z"&gt;UNAVAILABLE&lt;/AssetRemoved&gt;<br />      &lt;/Events&gt;<br />    &lt;/ComponentStream&gt;<br />    &lt;ComponentStream component="Controller" name="controller" componentId="cont"&gt;<br />      &lt;Events&gt;<br />        &lt;EmergencyStop dataItemId="estop" sequence="159" timestamp="2021-10-01T14:26:38.66869Z"&gt;ARMED&lt;/EmergencyStop&gt;<br />      &lt;/Events&gt;<br />      &lt;Samples&gt;<br />        &lt;AccumulatedTime dataItemId="cut_time" sequence="75437" timestamp="2021-10-07T05:08:28.221704Z"&gt;1763070.0&lt;/AccumulatedTime&gt;<br />      &lt;/Samples&gt;<br />      &lt;Condition&gt;<br />        &lt;Unavailable dataItemId="cont_system" sequence="72" timestamp="2021-10-11T21:04:03.251999Z" type="SYSTEM"/&gt;<br />        &lt;Warning dataItemId="cont_system" nativecode="313" nativeSeverity="50" sequence="75573" timestamp="2021-10-07T05:08:58.518317Z" type="LOGIC_PROGRAM"&gt;PALLET ARM DOWN RS. MALF.&lt;/Warning&gt;<br />      &lt;/Condition&gt;<br />    &lt;/ComponentStream&gt;<br />    &lt;ComponentStream component="Path" name="path" componentId="path1"&gt;<br />      &lt;Events&gt;<br />        &lt;Execution dataItemId="execution" name="execution" sequence="222623" timestamp="2021-10-12T06:04:32.761198Z"&gt;INTERRUPTED&lt;/Execution&gt;<br />        &lt;VariableDataSet count="2" dataItemId="cvars" sequence="126513" timestamp="2021-10-12T03:57:31.106559Z"&gt;<br />          &lt;Entry key="100"&gt;66.3314&lt;/Entry&gt;<br />          &lt;Entry key="101"&gt;167.2&lt;/Entry&gt;<br />        &lt;/VariableDataSet&gt;<br />        &lt;WorkOffsetTable count="2" dataItemId="woffset" sequence="222101" timestamp="2021-10-12T06:04:11.990531Z"&gt;<br />          &lt;Entry key="G53.1"&gt;<br />            &lt;Cell key="X"&gt;1&lt;/Cell&gt;<br />            &lt;Cell key="Y"&gt;2&lt;/Cell&gt;<br />            &lt;Cell key="Z"&gt;3&lt;/Cell&gt;<br />          &lt;/Entry&gt;<br />          &lt;Entry key="G53.2"&gt;<br />            &lt;Cell key="X"&gt;4&lt;/Cell&gt;<br />            &lt;Cell key="Y"&gt;5&lt;/Cell&gt;<br />            &lt;Cell key="Z"&gt;6&lt;/Cell&gt;<br />          &lt;/Entry&gt;<br />        &lt;/WorkOffsetTable&gt;<br />      &lt;/Events&gt;<br />      &lt;Samples&gt;<br />        &lt;CuttingSpeed dataItemId="cspeed" sequence="112" timestamp="2021-10-07T05:08:28.221704Z" subType="ACTUAL"&gt;UNAVAILABLE&lt;/CuttingSpeed&gt;<br />      &lt;/Samples&gt;<br />      &lt;Condition&gt;<br />        &lt;Normal dataItemId="path_system" sequence="153" timestamp="2021-10-11T21:04:03.262845Z" type="SYSTEM"/&gt;<br />      &lt;/Condition&gt;<br />    &lt;/ComponentStream&gt;<br />  &lt;/DeviceStream&gt;<br />&lt;/Streams&gt;<br />~~~~<br />{: caption="DeviceStream Example"}<br /><br />### Observations made for DataItem Example<br /><br />~~~~xml<br />&lt;Components&gt;<br />  &lt;Controller id="cont" name="controller"&gt;<br />      &lt;DataItems&gt;<br />      &lt;DataItem category="EVENT" id="estop" name="estop" type="EMERGENCY_STOP"/&gt;<br />    &lt;/DataItems&gt;<br />  &lt;/Controller&gt;<br />&lt;/Components&gt;<br />~~~~<br />{: caption="MTConnectDevices Response Document"}<br /><br />~~~~xml<br />&lt;ComponentStream component="Controller" name="controller" componentId="cont"&gt;<br />  &lt;Events&gt;<br />    &lt;EmergencyStop dataItemId="estop" sequence="159" timestamp="2021-10-01T14:26:38.66869Z"&gt;ARMED&lt;/EmergencyStop&gt;<br />  &lt;/Events&gt;<br />&lt;/ComponentStream&gt;<br />~~~~<br />{: caption="MTConnectStreams Response Document"}<br /><br />### Sample Example<br /><br />~~~~xml<br />&lt;Samples&gt;<br />  &lt;AccumulatedTime dataItemId="cut_time" sequence="75437" timestamp="2021-10-07T05:08:28.221704Z"&gt;1763070.0&lt;/AccumulatedTime&gt;<br />  &lt;CuttingSpeed dataItemId="cspeed" sequence="112" timestamp="2021-10-07T05:08:28.221704Z" subType="ACTUAL"&gt;UNAVAILABLE&lt;/CuttingSpeed&gt;<br />&lt;/Samples&gt;<br />~~~~<br />{: caption="Sample Example"}<br /><br />### Event Example<br /><br />~~~~xml<br />&lt;Events&gt;<br />  &lt;Availability dataItemId="avail" sequence="156" timestamp="2021-10-01T14:26:38.668505Z"&gt;AVAILABLE&lt;/Availability&gt;<br />  &lt;AssetRemoved assetType="CuttingTool" dataItemId="d1_asset_rem" sequence="140" timestamp="2021-10-01T11:40:08.101461Z"&gt;UNAVAILABLE&lt;/AssetRemoved&gt;<br />&lt;/Events&gt;<br />~~~~<br />{: caption="Event Example"}<br /><br />### Condition Example<br /><br /><see cref="Condition">Condition</see> types are represented differently in <i>XML</i> when compared to <see cref="Sample">Sample</see> and <see cref="Event">Event</see> types. The element name is the <i>condition state</i> of the <see cref="Condition">Condition</see> type in Pascal Case. The name of the <see cref="Condition">Condition</see> type is represented by the attribute <c>type</c>.<br /><br />If the <i>condition state</i> is unavailable then the element name is represented by <c>Unavailable</c>.<br /><br />~~~~xml<br />&lt;Condition&gt;<br />  &lt;Unavailable dataItemId="cont_system" sequence="72" timestamp="2021-10-11T21:04:03.251999Z" type="SYSTEM"/&gt;<br />  &lt;Normal dataItemId="path_system" sequence="153" timestamp="2021-10-11T21:04:03.262845Z" type="SYSTEM"/&gt;<br />  &lt;Warning dataItemId="cont_system" nativecode="313" nativeSeverity="50" sequence="75573" timestamp="2021-10-07T05:08:58.518317Z" type="LOGIC_PROGRAM"&gt;PALLET ARM DOWN RS. MALF.&lt;/Warning&gt;<br />&lt;/Condition&gt;<br />~~~~<br />{: caption="Condition Example"}<br /><br />### DataSet Example<br /><br />~~~~xml<br />&lt;Events&gt;<br />  &lt;VariableDataSet count="2" dataItemId="cvars" sequence="126513" timestamp="2021-10-12T03:57:31.106559Z"&gt;<br />    &lt;Entry key="100"&gt;66.3314&lt;/Entry&gt;<br />    &lt;Entry key="101"&gt;167.2&lt;/Entry&gt;<br />  &lt;/VariableDataSet&gt;<br />&lt;/Events&gt;<br />~~~~<br />{: caption="DataSet Example"}<br /><br />### Table Example<br /><br />~~~~xml<br />&lt;Events&gt;<br />  &lt;WorkOffsetTable count="2" dataItemId="woffset" sequence="222101" timestamp="2021-10-12T06:04:11.990531Z"&gt;<br />    &lt;Entry key="G53.1"&gt;<br />      &lt;Cell key="X"&gt;1&lt;/Cell&gt;<br />      &lt;Cell key="Y"&gt;2&lt;/Cell&gt;<br />      &lt;Cell key="Z"&gt;3&lt;/Cell&gt;<br />    &lt;/Entry&gt;<br />    &lt;Entry key="G53.2"&gt;<br />      &lt;Cell key="X"&gt;4&lt;/Cell&gt;<br />      &lt;Cell key="Y"&gt;5&lt;/Cell&gt;<br />      &lt;Cell key="Z"&gt;6&lt;/Cell&gt;<br />    &lt;/Entry&gt;<br />  &lt;/WorkOffsetTable&gt;<br />&lt;/Events&gt;<br />~~~~<br />{: caption="Table Example"}<br /><br /><br /><br /><br />
	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Package___19_0_3_45f01b9_1579566288489_320279_24855">model.mtconnect.org</seealso> for more information.
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public class ObservationInformationModelPackage : IPackage
	{
		/// <inheritdoc />
		public string ReferenceId => "_19_0_3_45f01b9_1579566288489_320279_24855";
		
		/// <inheritdoc />
		public string Name => "Observation Information Model";

		/// <inheritdoc />
		public string Summary => @"&#10;&#10;&#10;The {{term(Observation Information Model)}} provides a representation of the data reported by a piece of equipment used for a manufacturing process, or used for any other purpose.  Additional descriptive information associated with the reported data is defined by the {{block(MTConnectDevices)}} entity, which is described in {{package(Device Information Model)}}.

Information defined in the {{term(Observation Information Model)}} allows a software application to (1) determine the {{termplural(Observation)}} for {{termplural(DataItem)}} returned from a piece of equipment and (2) interpret the data associated with those {{termplural(Observation)}} with the same meaning, value, and context that it had at its original source.  To do this, the software application issues one of two HTTP requests to an {{term(agent)}} associated with a piece of equipment.  They are:

* `sample`:  Returns a designated number of time stamped {{termplural(Observation)}} from an {{term(agent)}} associated with a piece of equipment; subject to any HTTP filtering associated with the request.  See {{block(Agent)}} in {{package(Fundamentals)}} for details on the `sample` HTTP request.

* `current`:  Returns a snapshot of either the most recent values or the values at a given sequence number for all {{termplural(Observation)}} associated with a piece of equipment from an {{term(agent)}}; subject to any HTTP filtering associated with the request.  See {{block(Agent)}} in {{package(Fundamentals)}} for details on the `current` HTTP request.


An {{term(agent)}} responds to either the `sample` or `current` HTTP request with an {{term(MTConnectStreams Response Document)}}.  This document contains information describing {{termplural(Observation)}} reported by an {{term(agent)}} associated with a piece of equipment.   A client software application may correlate the information provided in the {{term(MTConnectStreams Response Document)}} with the physical and logical structure for that piece of equipment defined in the {{block(MTConnectDevices)}} entity to form a clear and unambiguous understanding of the information provided.  (See details on the structure for a piece of equipment described in {{package(Device Information Model)}}).

{{block(Streams)}} for an {{block(MTConnectStreams)}} entity contains a {{block(DeviceStream)}} entity for each piece of equipment represented in the document.  Each {{block(DeviceStream)}} is comprised of two primary types of entities – {{termplural(Component)}} and {{termplural(Observation)}}.  The contents of the {{block(DeviceStream)}} container are described in detail in this document, {{package(Observation Information Model)}} of the MTConnect Standard.

{{termplural(Component)}} are defined for both the {{block(MTConnectDevices)}} and the {{block(MTConnectStreams)}} entities.  These {{termplural(Component)}} are used to provide a logical organization of the information provided in each entity.  

* For an {{block(MTConnectDevices)}} entity: {{termplural(Component)}} organize information that represents the physical and logical parts and sub-parts of a piece of equipment.  (See {{block(Component)}} in {{package(Device Information Model)}} for more details on {{termplural(Component)}} used in the {{block(MTConnectDevices)}} entity).  

* For an {{block(MTConnectStreams)}} entity: {{termplural(Component)}} provide the structure to organize the data returned from a piece of equipment and establishes the proper context for that data.  The {{termplural(Component)}} specifically defined for {{block(MTConnectStreams)}} are {{block(DeviceStream)}} (see {{sect(DeviceStream)}}) and {{block(ComponentStream)}} (see {{sect(ComponentStream)}}).   

{{block(DeviceStream)}} and {{block(ComponentStream)}} entities have a direct correlation to each of the {{term(Component)}} defined in the {{block(MTConnectDevices)}} entity.

Within each {{block(ComponentStream)}} entity in the {{block(MTConnectStreams)}} entity, {{termplural(Observation)}} are modeled as {{block(Observation)}} entities. The three types of {{block(Observation)}} entity are {{block(Sample)}}, {{block(Event)}}, and {{block(Condition)}}.  (See {{sect(Observation Types)}} for more information on these entities.)
&#10;
&#10;&#10;&#10;Observations Appendix&#10;&#10;&#10;&#10;{{newpage()}} 

## XML Schema Diagrams

### Observations Schema Diagrams

See `Streams` element in `MTConnectStreams` schema.

See `DeviceStream` element in `MTConnectStreams` schema.

See `ComponentStream` element in `MTConnectStreams` schema.

See `Sample` element in `MTConnectStreams` schema.

See `Event` element in `MTConnectStreams` schema.

See `Condition` element in `MTConnectStreams` schema.

### Representation Schema Diagrams

See `AbsTimeSeries` element in `MTConnectStreams` schema.

See `PartCountDiscrete` element in `MTConnectStreams` schema.

See `VariableDataSet` element in `MTConnectStreams` schema.

See `Entry` element in `MTConnectStreams` schema.

See `WorkOffsetTable` element in `MTConnectStreams` schema.

## XML Examples

### DeviceStream Example

~~~~xml
<Streams>
  <DeviceStream name=""M12346"" uuid=""M8010W4194N"">
    <ComponentStream component=""Device"" name=""M12346"" componentId=""d1"">
      <Events>
        <Availability dataItemId=""avail"" sequence=""156"" timestamp=""2021-10-01T14:26:38.668505Z"">AVAILABLE</Availability>
        <AssetChanged assetType=""CuttingTool"" dataItemId=""d1_asset_chg"" sequence=""75570"" timestamp=""2021-10-07T05:08:53.870206Z"">M8010W4194N1.120</AssetChanged>
        <AssetRemoved assetType=""CuttingTool"" dataItemId=""d1_asset_rem"" sequence=""140"" timestamp=""2021-10-01T11:40:08.101461Z"">UNAVAILABLE</AssetRemoved>
      </Events>
    </ComponentStream>
    <ComponentStream component=""Controller"" name=""controller"" componentId=""cont"">
      <Events>
        <EmergencyStop dataItemId=""estop"" sequence=""159"" timestamp=""2021-10-01T14:26:38.66869Z"">ARMED</EmergencyStop>
      </Events>
      <Samples>
        <AccumulatedTime dataItemId=""cut_time"" sequence=""75437"" timestamp=""2021-10-07T05:08:28.221704Z"">1763070.0</AccumulatedTime>
      </Samples>
      <Condition>
        <Unavailable dataItemId=""cont_system"" sequence=""72"" timestamp=""2021-10-11T21:04:03.251999Z"" type=""SYSTEM""/>
        <Warning dataItemId=""cont_system"" nativecode=""313"" nativeSeverity=""50"" sequence=""75573"" timestamp=""2021-10-07T05:08:58.518317Z"" type=""LOGIC_PROGRAM"">PALLET ARM DOWN RS. MALF.</Warning>
      </Condition>
    </ComponentStream>
    <ComponentStream component=""Path"" name=""path"" componentId=""path1"">
      <Events>
        <Execution dataItemId=""execution"" name=""execution"" sequence=""222623"" timestamp=""2021-10-12T06:04:32.761198Z"">INTERRUPTED</Execution>
        <VariableDataSet count=""2"" dataItemId=""cvars"" sequence=""126513"" timestamp=""2021-10-12T03:57:31.106559Z"">
          <Entry key=""100"">66.3314</Entry>
          <Entry key=""101"">167.2</Entry>
        </VariableDataSet>
        <WorkOffsetTable count=""2"" dataItemId=""woffset"" sequence=""222101"" timestamp=""2021-10-12T06:04:11.990531Z"">
          <Entry key=""G53.1"">
            <Cell key=""X"">1</Cell>
            <Cell key=""Y"">2</Cell>
            <Cell key=""Z"">3</Cell>
          </Entry>
          <Entry key=""G53.2"">
            <Cell key=""X"">4</Cell>
            <Cell key=""Y"">5</Cell>
            <Cell key=""Z"">6</Cell>
          </Entry>
        </WorkOffsetTable>
      </Events>
      <Samples>
        <CuttingSpeed dataItemId=""cspeed"" sequence=""112"" timestamp=""2021-10-07T05:08:28.221704Z"" subType=""ACTUAL"">UNAVAILABLE</CuttingSpeed>
      </Samples>
      <Condition>
        <Normal dataItemId=""path_system"" sequence=""153"" timestamp=""2021-10-11T21:04:03.262845Z"" type=""SYSTEM""/>
      </Condition>
    </ComponentStream>
  </DeviceStream>
</Streams>
~~~~
{: caption=""DeviceStream Example""}

### Observations made for DataItem Example

~~~~xml
<Components>
  <Controller id=""cont"" name=""controller"">
      <DataItems>
      <DataItem category=""EVENT"" id=""estop"" name=""estop"" type=""EMERGENCY_STOP""/>
    </DataItems>
  </Controller>
</Components>
~~~~
{: caption=""MTConnectDevices Response Document""}

~~~~xml
<ComponentStream component=""Controller"" name=""controller"" componentId=""cont"">
  <Events>
    <EmergencyStop dataItemId=""estop"" sequence=""159"" timestamp=""2021-10-01T14:26:38.66869Z"">ARMED</EmergencyStop>
  </Events>
</ComponentStream>
~~~~
{: caption=""MTConnectStreams Response Document""}

### Sample Example

~~~~xml
<Samples>
  <AccumulatedTime dataItemId=""cut_time"" sequence=""75437"" timestamp=""2021-10-07T05:08:28.221704Z"">1763070.0</AccumulatedTime>
  <CuttingSpeed dataItemId=""cspeed"" sequence=""112"" timestamp=""2021-10-07T05:08:28.221704Z"" subType=""ACTUAL"">UNAVAILABLE</CuttingSpeed>
</Samples>
~~~~
{: caption=""Sample Example""}

### Event Example

~~~~xml
<Events>
  <Availability dataItemId=""avail"" sequence=""156"" timestamp=""2021-10-01T14:26:38.668505Z"">AVAILABLE</Availability>
  <AssetRemoved assetType=""CuttingTool"" dataItemId=""d1_asset_rem"" sequence=""140"" timestamp=""2021-10-01T11:40:08.101461Z"">UNAVAILABLE</AssetRemoved>
</Events>
~~~~
{: caption=""Event Example""}

### Condition Example

{{block(Condition)}} types are represented differently in {{term(XML)}} when compared to {{block(Sample)}} and {{block(Event)}} types. The element name is the {{term(condition state)}} of the {{block(Condition)}} type in Pascal Case. The name of the {{block(Condition)}} type is represented by the attribute `type`.

If the {{term(condition state)}} is unavailable then the element name is represented by `Unavailable`.

~~~~xml
<Condition>
  <Unavailable dataItemId=""cont_system"" sequence=""72"" timestamp=""2021-10-11T21:04:03.251999Z"" type=""SYSTEM""/>
  <Normal dataItemId=""path_system"" sequence=""153"" timestamp=""2021-10-11T21:04:03.262845Z"" type=""SYSTEM""/>
  <Warning dataItemId=""cont_system"" nativecode=""313"" nativeSeverity=""50"" sequence=""75573"" timestamp=""2021-10-07T05:08:58.518317Z"" type=""LOGIC_PROGRAM"">PALLET ARM DOWN RS. MALF.</Warning>
</Condition>
~~~~
{: caption=""Condition Example""}

### DataSet Example

~~~~xml
<Events>
  <VariableDataSet count=""2"" dataItemId=""cvars"" sequence=""126513"" timestamp=""2021-10-12T03:57:31.106559Z"">
    <Entry key=""100"">66.3314</Entry>
    <Entry key=""101"">167.2</Entry>
  </VariableDataSet>
</Events>
~~~~
{: caption=""DataSet Example""}

### Table Example

~~~~xml
<Events>
  <WorkOffsetTable count=""2"" dataItemId=""woffset"" sequence=""222101"" timestamp=""2021-10-12T06:04:11.990531Z"">
    <Entry key=""G53.1"">
      <Cell key=""X"">1</Cell>
      <Cell key=""Y"">2</Cell>
      <Cell key=""Z"">3</Cell>
    </Entry>
    <Entry key=""G53.2"">
      <Cell key=""X"">4</Cell>
      <Cell key=""Y"">5</Cell>
      <Cell key=""Z"">6</Cell>
    </Entry>
  </WorkOffsetTable>
</Events>
~~~~
{: caption=""Table Example""}&#10;
";

		/// <inheritdoc />
		public IPackage[] Packages => new IPackage[] {
			RepresentationsPackage,
			ObservationTypesPackage,
		};
		
		/// <inheritdoc />
		public IClass[] Classes => new IClass[] {
			DeviceStreamClass,
			ComponentStreamClass,
			ObservationGeneralization,
			SampleClass,
			EventClass,
			ConditionClass,
		};
		
		/// <inheritdoc />
		public IEnum[] Enums => new IEnum[] {
		};

		#region Packages
	private Package.RepresentationsPackage _RepresentationsPackage;
	/// <summary>
	/// <inheritdoc cref="Package.RepresentationsPackage" path="/summary" />
	/// </summary>
	public Package.RepresentationsPackage RepresentationsPackage => _RepresentationsPackage ?? (_RepresentationsPackage = new Package.RepresentationsPackage());

	private Package.ObservationTypesPackage _ObservationTypesPackage;
	/// <summary>
	/// <inheritdoc cref="Package.ObservationTypesPackage" path="/summary" />
	/// </summary>
	public Package.ObservationTypesPackage ObservationTypesPackage => _ObservationTypesPackage ?? (_ObservationTypesPackage = new Package.ObservationTypesPackage());

	#endregion

	#region Classes
	private Package.DeviceStreamClass _DeviceStreamClass;
	/// <summary>
	/// <inheritdoc cref="Package.DeviceStreamClass" path="/summary" />
	/// </summary>
	public Package.DeviceStreamClass DeviceStreamClass => _DeviceStreamClass ?? (_DeviceStreamClass = new Package.DeviceStreamClass());

	private Package.ComponentStreamClass _ComponentStreamClass;
	/// <summary>
	/// <inheritdoc cref="Package.ComponentStreamClass" path="/summary" />
	/// </summary>
	public Package.ComponentStreamClass ComponentStreamClass => _ComponentStreamClass ?? (_ComponentStreamClass = new Package.ComponentStreamClass());

	private Package.ObservationGeneralization _ObservationGeneralization;
	/// <summary>
	/// <inheritdoc cref="Package.ObservationGeneralization" path="/summary" />
	/// </summary>
	public Package.ObservationGeneralization ObservationGeneralization => _ObservationGeneralization ?? (_ObservationGeneralization = new Package.ObservationGeneralization());

	private Package.SampleClass _SampleClass;
	/// <summary>
	/// <inheritdoc cref="Package.SampleClass" path="/summary" />
	/// </summary>
	public Package.SampleClass SampleClass => _SampleClass ?? (_SampleClass = new Package.SampleClass());

	private Package.EventClass _EventClass;
	/// <summary>
	/// <inheritdoc cref="Package.EventClass" path="/summary" />
	/// </summary>
	public Package.EventClass EventClass => _EventClass ?? (_EventClass = new Package.EventClass());

	private Package.ConditionClass _ConditionClass;
	/// <summary>
	/// <inheritdoc cref="Package.ConditionClass" path="/summary" />
	/// </summary>
	public Package.ConditionClass ConditionClass => _ConditionClass ?? (_ConditionClass = new Package.ConditionClass());

	#endregion

	#region Enums
	#endregion
	}
}