#pragma warning disable CS1574 // XML comment has cref attribute that could not be resolved
#pragma warning disable CS1584 // XML comment has syntactically incorrect cref attribute
using System;
using System.CodeDom.Compiler;
using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;
using Package = Mtconnect.DeviceInformationModel;

namespace Mtconnect
{
	/// <summary>﻿The <i>Device Information Model</i> provides a representation of the physical and logical configuration for a piece of equipment used for a manufacturing process or for any other purpose.  It also provides the definition of data that may be reported by that equipment. <br /><br />Using information defined in the <i>Device Information Model</i>, a software application can determine the configuration and reporting capabilities of a piece of equipment.  To do this, the software application issues a <i>probe request</i> (defined in <see cref="Fundamentals">Fundamentals</see>) to an <i>agent</i> associated with a piece of equipment. An <i>agent</i> responds to the <i>probe request</i> with an <i>MTConnectDevices Response Document</i> that contains information describing both the physical and logical structure of the piece of equipment and a detailed description of each <i>Observation</i> that can be reported by the <i>agent</i> associated with the piece of equipment. This information allows the client software application to interpret the document and to extract the data with the same meaning, value, and context that it had at its original source.  <br /><br />The <i>MTConnectDevices Response Document</i> is comprised of two sections: <see cref="Header">Header</see> and <see cref="Devices">Devices</see>.<br /><br />The <see cref="Header">Header</see> section contains protocol related information as defined in <see cref="Fundamentals">Fundamentals</see>.<br /><br />The <see cref="Devices">Devices</see> section of the <i>MTConnectDevices Response Document</i> contains a <see cref="Device">Device</see> entity for each piece of equipment described in the document.  Each <see cref="Device">Device</see> is comprised of two primary types of entities - <i>Component</i>s and <i>DataItem</i>s.  <br /><br /><i>Component</i>s organize information that represents the physical and logical parts and sub-parts of a piece of equipment (See <see cref="Components">Components</see> for more details).  <br /><br /><i>DataItem</i>s describe data that can be reported by a piece of equipment.  In the <i>Device Information Model</i>, <i>DataItem</i>s are defined as <see cref="DataItem">DataItem</see> entities (See <see cref="DataItem Types">DataItem Types</see>).<br /><br />The <i>Component</i>s and <i>DataItem</i>s in the <i>MTConnectDevices Response Document</i> provide information representing the physical and logical structure for a piece of equipment and the types of data that the piece of equipment can report relative to that structure.   The <i>MTConnectDevices Response Document</i> does not contain values for the data types reported by the piece of equipment.  The <i>MTConnectStreams Response Document</i> defined in <see cref="Observation Information Model">Observation Information Model</see> provides the data values that are reported by the piece of equipment.<br /><br />&gt; Note:  The MTConnect Standard also defines the information model for <i>asset</i>s.  An <i>asset</i> is something that is used in the manufacturing process, but is not permanently associated with a single piece of equipment, can be removed from the piece of equipment without compromising its function, and can be associated with other pieces of equipment during its lifecycle.  See <see cref="Asset Information Model">Asset Information Model</see> for more details on <i>asset</i>s.<br /><br /><br /><br />Devices Appendix<br /><br />{{newpage()}} <br /><br />## XML Schema Diagrams<br /><br />See XML schemas for the MTConnect standard here: <see href="https://schemas.mtconnect.org/">https://schemas.mtconnect.org/</see>.<br /><br />### Components Schema Diagrams<br /><br />See <c>Components</c> element in <c>MTConnectDevices</c> schema.<br /><br />See <c>Description</c> element in <c>MTConnectDevices</c> schema.<br /><br />### DataItems Schema Diagrams<br /><br />See <c>DataItems</c> element in <c>MTConnectDevices</c> schema.<br /><br />See <c>Source</c> element in <c>MTConnectDevices</c> schema.<br /><br />See <c>Constraints</c> element in <c>MTConnectDevices</c> schema.<br /><br />See <c>Filter</c> element in <c>MTConnectDevices</c> schema.<br /><br />See <c>Definition</c> element in <c>MTConnectDevices</c> schema.<br /><br />### References Schema Diagrams<br /><br />See <c>References</c> element in <c>MTConnectDevices</c> schema.<br /><br />See <c>ComponentRef</c> element in <c>MTConnectDevices</c> schema.<br /><br />See <c>DataItemRef</c> element in <c>MTConnectDevices</c> schema.<br /><br />### Configuration Schema Diagrams<br /><br />See <c>Configuration</c> element in <c>MTConnectDevices</c> schema.<br /><br />See <c>CoordinateSystem</c> element in <c>MTConnectDevices</c> schema.<br /><br />See <c>Motion</c> element in <c>MTConnectDevices</c> schema.<br /><br />See <c>Relationships</c> element in <c>MTConnectDevices</c> schema.<br /><br />See <c>ComponentRelationship</c> element in <c>MTConnectDevices</c> schema.<br /><br />See <c>DeviceRelationship</c> element in <c>MTConnectDevices</c> schema.<br /><br />See <c>SensorConfiguration</c> element in <c>MTConnectDevices</c> schema.<br /><br />See <c>SolidModel</c> element in <c>MTConnectDevices</c> schema.<br /><br />See <c>Specifications</c> element in <c>MTConnectDevices</c> schema.<br /><br />See <c>ProcessSpecification</c> element in <c>MTConnectDevices</c> schema.<br /><br />## XML Examples<br /><br />### Device Entity Hierarchy Example<br /><br />~~~~xml<br />&lt;Devices&gt;<br />  &lt;Device id="d1" name="M12346" uuid="M80104K162N"&gt;<br />    &lt;Components&gt;<br />    &lt;Axes id="a" name="base"&gt;<br />    &lt;Components&gt;<br />      &lt;Linear id="x" name="X"/&gt;<br />      &lt;Linear id="y" name="Y"/&gt;<br />      &lt;Linear id="z" name="Z"/&gt;<br />      &lt;Rotary id="ar" name="B"/&gt;<br />      &lt;Linear id="w" name="Z3" nativeName="W"/&gt;<br />      &lt;Rotary id="c" name="C"/&gt;<br />    &lt;/Components&gt;<br />    &lt;/Axes&gt;<br />    &lt;Controller id="cont" name="controller"&gt;<br />    &lt;Components&gt;<br />      &lt;Path id="path1" name="path"/&gt;<br />    &lt;/Components&gt;<br />    &lt;/Controller&gt;<br />    &lt;Door id="door1" name="door"/&gt;<br />    &lt;Systems id="systems" name="systems"&gt;<br />    &lt;Components&gt;<br />      &lt;WorkEnvelope id="we1" name="workenv"&gt;<br />      &lt;Compositions&gt;<br />        &lt;Composition type="WORKPIECE" id="wp"/&gt;<br />        &lt;Composition type="TABLE" id="tbl"/&gt;<br />      &lt;/Compositions&gt;<br />      &lt;/WorkEnvelope&gt;<br />      &lt;Electric id="elec" name="electric"/&gt;<br />      &lt;Hydraulic id="hydraulic" name="hydraulic"/&gt;<br />      &lt;Coolant id="coolant" name="coolant"/&gt;<br />      &lt;Pneumatic id="pneumatic" name="pneumatic"/&gt;<br />      &lt;Lubrication id="lubrication" name="lubrication"/&gt;<br />    &lt;/Components&gt;<br />    &lt;/Systems&gt;<br />    &lt;Auxiliaries id="Aux" name="auxiliaries"&gt;<br />    &lt;Components&gt;<br />      &lt;Environmental id="room" name="environmental"/&gt;<br />    &lt;/Components&gt;<br />    &lt;/Auxiliaries&gt;<br />    &lt;Resources id="resources" name="resources"&gt;<br />    &lt;Components&gt;<br />      &lt;Personnel id="personnel" name="personnel"/&gt;<br />      &lt;Materials id="materials" name="materials"&gt;<br />      &lt;Components&gt;<br />        &lt;Stock id="procstock" name="stock"/&gt;<br />      &lt;/Components&gt;<br />      &lt;Materials/&gt;<br />    &lt;/Components&gt; <br />    &lt;/Resources&gt;<br />    &lt;/Components&gt;<br />  &lt;/Device&gt;<br />&lt;/Devices&gt;<br />~~~~<br />{: caption="Device Entity Hierarchy Example"}<br /><br />### Component Example<br /><br />~~~~xml<br />&lt;Devices&gt;<br />  &lt;Device id="d1" name="M12346" uuid="M80104K162N"&gt;<br />    &lt;Description manufacturer="Example_Corporation" <br />      serialNumber="272237"&gt; Mill w/SMooth-G<br />    &lt;/Description&gt;<br />  &lt;DataItems&gt;<br />    &lt;DataItem category="EVENT" id="avail" name="avail" type="AVAILABILITY"/&gt;<br />    &lt;DataItem category="EVENT" id="d1_asset_chg" name="asset_chg" type="ASSET_CHANGED"/&gt;<br />    &lt;DataItem category="EVENT" id="d1_asset_rem" name="asset_rem" type="ASSET_REMOVED"/&gt;<br />  &lt;/DataItems&gt;<br />    &lt;Components&gt;<br />    &lt;Controller id="cont" name="controller"&gt;<br />      &lt;DataItems&gt;<br />      &lt;DataItem category="EVENT" id="estop" name="estop" type="EMERGENCY_STOP"/&gt;<br />      &lt;DataItem category="CONDITION" id="logic_cond" type="LOGIC_PROGRAM"/&gt;<br />      &lt;DataItem category="CONDITION" id="cont_system" type="SYSTEM"/&gt;<br />      &lt;DataItem category="SAMPLE" id="cut_time" type="ACCUMULATED_TIME" units="SECOND"/&gt;<br />    &lt;/DataItems&gt;<br />    &lt;Components&gt;<br />      &lt;Path id="path1" name="path"&gt;<br />        &lt;DataItems&gt;<br />        &lt;DataItem category="EVENT" id="execution" name="execution" type="EXECUTION"/&gt;<br />        &lt;DataItem category="SAMPLE" id="cspeed" subType="ACTUAL" type="CUTTING_SPEED" units="MILLIMETER/SECOND"/&gt;<br />        &lt;DataItem category="CONDITION" id="path_system" type="SYSTEM"/&gt;<br />        &lt;DataItem category="EVENT" id="cvars" representation="DATA_SET" type="VARIABLE"/&gt;<br />        &lt;DataItem category="EVENT" id="woffset" representation="TABLE" type="WORK_OFFSET"/&gt;<br />      &lt;/DataItems&gt;<br />      &lt;/Path&gt;<br />    &lt;/Components&gt;<br />    &lt;/Controller&gt;<br />  &lt;/Components&gt;<br />  &lt;/Device&gt;<br />&lt;/Devices&gt;<br />~~~~<br />{: caption="Component Example"}<br /><br />### Component with Compositions Example<br /><br />In <i>XML</i>, <c>Composition</c> types are represented differently than <c>Component</c> types. For <c>Component</c> types, the element name is Pascal Case of the <c>Component</c> type name. Whereas, the element name for all <c>Composition</c>types is <c>Composition</c> and the type is defined by the <c>type</c> attribute of the element (see example below).<br /><br />~~~~xml<br />&lt;WorkEnvelope id="we1" name="workenv"&gt;<br />  &lt;DataItems&gt;<br />    &lt;DataItem category="CONDITION" id="hardware1" name="hardware1" type="HARDWARE"/&gt;<br />  &lt;/DataItems&gt;<br />  &lt;Compositions&gt;<br />  &lt;Composition type="WORKPIECE" id="wp"/&gt;<br />  &lt;Composition type="TABLE" id="tbl"/&gt;<br />  &lt;/Compositions&gt;<br />&lt;/WorkEnvelope&gt;<br />~~~~<br />{: caption="Component with Compositions Example"}<br /><br />### CoordinateSystem Example<br /><br />~~~~xml<br />&lt;Devices&gt;<br />  &lt;Device id="d1" name="M12346" uuid="M80104K162N"&gt;<br />    &lt;Description manufacturer="Example_Corporation" <br />      serialNumber="272237"&gt; Mill w/SMooth-G<br />    &lt;/Description&gt;<br />    &lt;DataItems&gt;<br />      &lt;DataItem id="avail" type="AVAILABILITY" category="EVENT"/&gt;<br />      &lt;DataItem category="EVENT" id="d1_asset_chg" name="asset_chg" type="ASSET_CHANGED"/&gt;<br />      &lt;DataItem category="EVENT" id="d1_asset_rem" name="asset_rem" type="ASSET_REMOVED"/&gt;<br />    &lt;/DataItems&gt;<br />    &lt;Configuration&gt;<br />      &lt;CoordinateSystems&gt;<br />        &lt;CoordinateSystem id="base" type="BASE"&gt;<br />          &lt;Origin&gt;0 0 0&lt;/Origin&gt;<br />        &lt;/CoordinateSystem&gt;<br />        &lt;CoordinateSystem id="machcoord" type="MACHINE" parentIdRef="base"&gt;<br />          &lt;Transformation&gt;<br />            &lt;Translation&gt;210 275 1430&lt;/Translation&gt;<br />            &lt;Rotation&gt;0 0 0&lt;/Rotation&gt;<br />          &lt;/Transformation&gt;<br />        &lt;/CoordinateSystem&gt;<br />        &lt;CoordinateSystem id="workcoord" type="OBJECT" parentIdRef="machcoord"&gt;<br />          &lt;Transformation&gt;<br />            &lt;Translation&gt;0 0 0&lt;/Translation&gt;<br />            &lt;Rotation&gt;0 0 0&lt;/Rotation&gt;<br />          &lt;/Transformation&gt;<br />        &lt;/CoordinateSystem&gt;<br />      &lt;/CoordinateSystems&gt;<br />    &lt;/Configuration&gt;<br />  &lt;/Device&gt;<br />&lt;/Devices&gt;<br />~~~~<br />{: caption="CoordinateSystem Example"}<br /><br />### Motion Example<br /><br />~~~~xml<br />&lt;Devices&gt;<br />  &lt;Device id="d1" name="M12346" uuid="M80104K162N"&gt;<br />    &lt;Description manufacturer="Example_Corporation" <br />      serialNumber="272237"&gt; Mill w/SMooth-G<br />    &lt;/Description&gt;<br />    &lt;DataItems&gt;<br />      &lt;DataItem id="avail" type="AVAILABILITY" category="EVENT"/&gt;<br />      &lt;DataItem category="EVENT" id="d1_asset_chg" name="asset_chg" type="ASSET_CHANGED"/&gt;<br />      &lt;DataItem category="EVENT" id="d1_asset_rem" name="asset_rem" type="ASSET_REMOVED"/&gt;<br />    &lt;/DataItems&gt;<br />    &lt;Configuration&gt;<br />      &lt;CoordinateSystems&gt;<br />        &lt;CoordinateSystem id="base" type="BASE"&gt;<br />          &lt;Origin&gt;0 0 0&lt;/Origin&gt;<br />        &lt;/CoordinateSystem&gt;<br />        &lt;CoordinateSystem id="machcoord" type="MACHINE" parentIdRef="base"&gt;<br />          &lt;Transformation&gt;<br />            &lt;Translation&gt;210 275 1430&lt;/Translation&gt;<br />            &lt;Rotation&gt;0 0 0&lt;/Rotation&gt;<br />          &lt;/Transformation&gt;<br />        &lt;/CoordinateSystem&gt;<br />        &lt;CoordinateSystem id="workcoord" type="OBJECT" parentIdRef="machcoord"&gt;<br />          &lt;Transformation&gt;<br />            &lt;Translation&gt;0 0 0&lt;/Translation&gt;<br />            &lt;Rotation&gt;0 0 0&lt;/Rotation&gt;<br />          &lt;/Transformation&gt;<br />        &lt;/CoordinateSystem&gt;<br />      &lt;/CoordinateSystems&gt;<br />    &lt;/Configuration&gt;<br />    &lt;Components&gt;<br />      &lt;Axes id="a" name="base"&gt;<br />        &lt;Components&gt;<br />          &lt;Linear id="x" name="X"&gt;<br />            &lt;Configuration&gt;<br />              &lt;Motion id="xmotion" coordinateSystemIdRef="machcoord" type="PRISMATIC" actuation="DIRECT"&gt;<br />                &lt;Transformation&gt;<br />                  &lt;Translaton&gt;300 915 590&lt;/Translaton&gt;<br />                  &lt;Rotation&gt;0 0 0&lt;/Rotation&gt;<br />                &lt;/Transformation&gt;<br />                &lt;Axis&gt;1.0 0 0&lt;/Axis&gt;<br />              &lt;/Motion&gt;<br />            &lt;/Configuration&gt;<br />          &lt;/Linear&gt;<br />          &lt;DataItems&gt;<br />            &lt;DataItem id="xtravel" type="SYSTEM" category="CONDITION"&gt;<br />          &lt;/DataItems&gt;<br />        &lt;/Components&gt;<br />      &lt;/Axes&gt;<br />    &lt;/Components&gt;<br />  &lt;/Device&gt;<br />&lt;/Devices&gt;<br />~~~~<br />{: caption="Motion Example"}<br /><br />### Relationship Example<br /><br />~~~~xml<br />&lt;Components&gt;<br />  &lt;Axes id="a" name="base"&gt;<br />    &lt;Components&gt;<br />      &lt;Linear id="x" name="X"&gt;<br />        &lt;Configuration&gt;        <br />          &lt;Relationships&gt;<br />            &lt;ComponentRelationship id="xpar" type="PARENT" idRef="we1"/&gt;<br />          &lt;/Relationships&gt;<br />        &lt;/Configuration&gt;<br />      &lt;/Linear&gt;<br />      &lt;DataItems&gt;<br />        &lt;DataItem id="xtravel" type="SYSTEM" category="CONDITION"&gt;<br />      &lt;/DataItems&gt;<br />    &lt;/Components&gt;<br />  &lt;/Axes&gt;<br />  &lt;Systems id="systems" name="systems"&gt;<br />    &lt;Components&gt;<br />      &lt;WorkEnvelope id="we1" name="workenv"&gt;<br />        &lt;Compositions&gt;<br />          &lt;Composition type="WORKPIECE" id="wp"/&gt;<br />          &lt;Composition type="TABLE" id="tbl"/&gt;<br />        &lt;/Compositions&gt;<br />        &lt;DataItems&gt;<br />          &lt;DataItem id="we1cond" type="SYSTEM" category="CONDITION"&gt;<br />        &lt;/DataItems&gt;<br />      &lt;/WorkEnvelope&gt;<br />    &lt;/Components&gt;<br />  &lt;/Systems&gt;<br />&lt;/Components&gt;<br />~~~~<br />{: caption="Relationship Example"}<br />      <br />### SolidModel Example<br /><br />~~~~xml<br />&lt;Devices&gt;<br />  &lt;Device id="d1" name="M12346" uuid="M80104K162N"&gt;<br />    &lt;Description manufacturer="Example_Corporation" <br />      serialNumber="272237"&gt; Mill w/SMooth-G<br />    &lt;/Description&gt;<br />    &lt;DataItems&gt;<br />      &lt;DataItem id="avail" type="AVAILABILITY" category="EVENT"/&gt;<br />      &lt;DataItem category="EVENT" id="d1_asset_chg" name="asset_chg" type="ASSET_CHANGED"/&gt;<br />      &lt;DataItem category="EVENT" id="d1_asset_rem" name="asset_rem" type="ASSET_REMOVED"/&gt;<br />    &lt;/DataItems&gt;<br />    &lt;Configuration&gt;<br />      &lt;CoordinateSystems&gt;<br />        &lt;CoordinateSystem id="base" type="BASE"&gt;<br />          &lt;Origin&gt;0 0 0&lt;/Origin&gt;<br />        &lt;/CoordinateSystem&gt;<br />        &lt;CoordinateSystem id="machcoord" type="MACHINE" parentIdRef="base"&gt;<br />          &lt;Transformation&gt;<br />            &lt;Translation&gt;210 275 1430&lt;/Translation&gt;<br />            &lt;Rotation&gt;0 0 0&lt;/Rotation&gt;<br />          &lt;/Transformation&gt;<br />        &lt;/CoordinateSystem&gt;<br />        &lt;CoordinateSystem id="workcoord" type="OBJECT" parentIdRef="machcoord"&gt;<br />          &lt;Transformation&gt;<br />            &lt;Translation&gt;0 0 0&lt;/Translation&gt;<br />            &lt;Rotation&gt;0 0 0&lt;/Rotation&gt;<br />          &lt;/Transformation&gt;<br />        &lt;/CoordinateSystem&gt;<br />      &lt;/CoordinateSystems&gt;<br />    &lt;/Configuration&gt;<br />    &lt;Components&gt;<br />      &lt;Structures id="struct"&gt;<br />        &lt;Configuration&gt;<br />          &lt;SolidModel id="model" mediaType="OBJ" href="/objs/mazak.obj" coordinateSystemIdRef="base"&gt;<br />            &lt;Transformation&gt;<br />              &lt;Translation&gt;0 860 0&lt;/Translation&gt;<br />              &lt;Rotation&gt;-90 0 0&lt;/Rotation&gt;<br />            &lt;/Transformation&gt;<br />            &lt;Scale&gt;0.001 0.001 0.001&lt;/Scale&gt;<br />          &lt;/SolidModel&gt;<br />        &lt;/Configuration&gt;<br />        &lt;Components&gt;<br />          &lt;Structure id="xaxis" name="X_AXIS"&gt;<br />            &lt;Configuration&gt;<br />              &lt;SolidModel id="x_model" mediaType="OBJ" itemRef="xaxis" solidModelIdRef="model" coordinateSystemIdRef="base"/&gt;<br />            &lt;/Configuration&gt;<br />            &lt;DataItems&gt;<br />              &lt;DataItem type="SYSTEM" category="CONDITION" id="struct_cond"/&gt;<br />            &lt;/DataItems&gt;<br />          &lt;/Structure&gt;<br />        &lt;/Components&gt;<br />      &lt;/Structures&gt;<br />    &lt;/Components&gt;<br />  &lt;/Device&gt;<br />&lt;/Devices&gt;<br />~~~~<br />{: caption="SolidModel Example"}<br /><br />### Specification Example<br /><br />~~~~xml<br />&lt;Components&gt;<br />  &lt;Axes id="a" name="base"&gt;<br />    &lt;Components&gt;<br />      &lt;Linear id="x" name="X"&gt;<br />        &lt;Configuration&gt;<br />          &lt;Specifications&gt;<br />            &lt;Specification id="spec001" type="LENGTH" units="MILLIMETER"&gt;<br />              &lt;Nominal&gt;650&lt;/Nominal&gt;<br />            &lt;/Specification&gt;<br />            &lt;Specification id="spec002" type="LINEAR_FORCE" units="NEWTON"&gt;<br />              &lt;Maximum&gt;5200&lt;/Maximum&gt;<br />              &lt;Minimum&gt;0&lt;/Minimum&gt;<br />            &lt;/Specification&gt;<br />          &lt;/Specifications&gt;<br />        &lt;/Configuration&gt;<br />        &lt;DataItems&gt;<br />          &lt;DataItem id="xtravel" type="SYSTEM" category="CONDITION"&gt;<br />        &lt;/DataItems&gt;<br />      &lt;/Linear&gt;<br />    &lt;/Components&gt;<br />  &lt;/Axes&gt;<br />&lt;/Components&gt;<br />~~~~<br />{: caption="Specification Example"}<br /><br />### Example of sensing element provided as data item associated with a Component<br /><br />~~~~xml<br />&lt;Components&gt;<br />  &lt;Axes id="a" name="base"<br />    &lt;Components&gt;<br />      &lt;Rotary id="c" name="C"&gt;<br />        &lt;DataItems&gt;<br />          &lt;DataItem type="TEMPERATURE" id="servotemp4"<br />            category="SAMPLE" nativeUnits="CELSIUS"<br />            compositionId="Bmotor" units="CELSIUS"/&gt;<br />          &lt;/DataItems&gt;<br />      &lt;/Rotary&gt;<br />    &lt;/Components&gt;<br />  &lt;/Axes&gt;<br />&lt;/Components&gt;<br />~~~~<br />{: caption="Example of sensing element provided as data item associated with a Component"}<br /><br />### Example of Sensor for rotary axis<br /><br />~~~~xml<br />&lt;Components&gt;<br />  &lt;Axes id="a" name="base"<br />    &lt;Components&gt;<br />      &lt;Rotary id="ar" name="B"&gt;<br />        &lt;Components&gt;<br />          &lt;Sensor id="spdlm" name="Spindlemonitor"&gt;<br />            &lt;DataItems&gt;<br />              &lt;DataItem type="DISPLACEMENT" id="cvib"<br />                category="SAMPLE" name="Svib" <br />                units="MILLIMETER"/&gt;<br />            &lt;/DataItems&gt;<br />          &lt;/Sensor &gt;<br />        &lt;Components&gt;<br />      &lt;/Rotary&gt;<br />    &lt;/Components&gt;<br />  &lt;/Axes&gt;<br />&lt;/Components&gt;<br />~~~~<br />{: caption="Example of Sensor for rotary axis"}<br /><br />### Example of sensor unit with sensing element<br /><br />~~~~xml<br />&lt;Axes id="a" name="base"<br />  &lt;Components&gt;<br />  &lt;Sensor id="sens1" name="Sensorunit"&gt;<br />    &lt;DataItems&gt;<br />    &lt;DataItem type="TEMPERATURE" id="sentemp"<br />      category="SAMPLE" name="Sensortemp" <br />      units="CELSIUS"/&gt; <br />    &lt;/DataItems&gt;<br />  &lt;/Sensor &gt;<br />  &lt;Linear id="x" name="X"&gt;<br />    &lt;DataItems&gt;<br />    &lt;DataItem type="DISPLACEMENT" id="xvib"<br />      category="SAMPLE" name="xvib" <br />      units="MILLIMETER"&gt;<br />      &lt;Source componentId="sens1"/&gt;<br />    &lt;/DataItem&gt;<br />    &lt;/DataItems&gt;<br />  &lt;/Rotary&gt;<br />  &lt;Linear id="y" name="Y"&gt;<br />    &lt;DataItems&gt;<br />    &lt;DataItem type="DISPLACEMENT" id="yvib" <br />      category="SAMPLE" name="yvib" <br />      units="MILLIMETER"&gt;<br />      &lt;Source componentId="sens1"/&gt;<br />    &lt;/DataItem&gt;<br />    &lt;/DataItems&gt;<br />  &lt;/Linear&gt;<br />  &lt;Components&gt;<br />&lt;/Axes&gt;<br />~~~~<br />{: caption="Example of sensor unit with sensing element"}<br /><br />### Example of configuration data for Sensor<br /><br />~~~~xml<br />&lt;Sensor id="sensor" name="sensor"&gt;<br />  &lt;Configuration&gt;<br />    &lt;SensorConfiguration&gt;<br />      &lt;FirmwareVersion&gt;2.02&lt;/FirmwareVersion&gt;<br />      &lt;CalibrationDate&gt;2010-05-16&lt;/CalibrationDate&gt;<br />      &lt;NextCalibrationDate&gt;2010-05-16&lt;/NextCalibrationDate&gt;<br />      &lt;CalibrationInitials&gt;WS&lt;/CalibrationInitials&gt;<br />      &lt;Channels&gt;<br />        &lt;Channel number="1" name="A/D:1"&gt;<br />          &lt;Description&gt;A/D With Thermister&lt;/Description&gt;<br />        &lt;/Channel&gt;<br />      &lt;/Channels&gt;<br />    &lt;/SensorConfiguration&gt;<br />  &lt;/Configuration&gt;<br />  &lt;DataItems&gt;<br />    &lt;DataItem category="CONDITION" id="sensorc" <br />      name="sensorc" type="SYSTEM" /&gt;<br />    &lt;DataItem category="SAMPLE" id="senv" name="sensorc"<br />      type="VOLTAGE_DC" units="VOLT" subType="ACTUAL" /&gt;<br />  &lt;/DataItems&gt;<br />&lt;/Sensor&gt;<br />~~~~<br />{: caption="Example of configuration data for Sensor"}  <br /><br /><br /><br /><br />
	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Package___19_0_3_68e0225_1642672857507_756619_19">model.mtconnect.org</seealso> for more information.
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public class DeviceInformationModelPackage : IPackage
	{
		/// <inheritdoc />
		public string ReferenceId => "_19_0_3_68e0225_1642672857507_756619_19";
		
		/// <inheritdoc />
		public string Name => "Device Information Model";

		/// <inheritdoc />
		public string Summary => @"&#10;&#10;&#10;The {{term(Device Information Model)}} provides a representation of the physical and logical configuration for a piece of equipment used for a manufacturing process or for any other purpose.  It also provides the definition of data that may be reported by that equipment. 

Using information defined in the {{term(Device Information Model)}}, a software application can determine the configuration and reporting capabilities of a piece of equipment.  To do this, the software application issues a {{term(probe request)}} (defined in {{package(Fundamentals)}}) to an {{term(agent)}} associated with a piece of equipment. An {{term(agent)}} responds to the {{term(probe request)}} with an {{term(MTConnectDevices Response Document)}} that contains information describing both the physical and logical structure of the piece of equipment and a detailed description of each {{term(Observation)}} that can be reported by the {{term(agent)}} associated with the piece of equipment. This information allows the client software application to interpret the document and to extract the data with the same meaning, value, and context that it had at its original source.  

The {{term(MTConnectDevices Response Document)}} is comprised of two sections: {{block(Header)}} and {{block(Devices)}}.

The {{block(Header)}} section contains protocol related information as defined in {{package(Fundamentals)}}.

The {{block(Devices)}} section of the {{term(MTConnectDevices Response Document)}} contains a {{block(Device)}} entity for each piece of equipment described in the document.  Each {{block(Device)}} is comprised of two primary types of entities - {{termplural(Component)}} and {{termplural(DataItem)}}.  

{{termplural(Component)}} organize information that represents the physical and logical parts and sub-parts of a piece of equipment (See {{package(Components)}} for more details).  

{{termplural(DataItem)}} describe data that can be reported by a piece of equipment.  In the {{term(Device Information Model)}}, {{termplural(DataItem)}} are defined as {{block(DataItem)}} entities (See {{package(DataItem Types)}}).

The {{termplural(Component)}} and {{termplural(DataItem)}} in the {{term(MTConnectDevices Response Document)}} provide information representing the physical and logical structure for a piece of equipment and the types of data that the piece of equipment can report relative to that structure.   The {{term(MTConnectDevices Response Document)}} does not contain values for the data types reported by the piece of equipment.  The {{term(MTConnectStreams Response Document)}} defined in {{package(Observation Information Model)}} provides the data values that are reported by the piece of equipment.

> Note:  The MTConnect Standard also defines the information model for {{termplural(asset)}}.  An {{term(asset)}} is something that is used in the manufacturing process, but is not permanently associated with a single piece of equipment, can be removed from the piece of equipment without compromising its function, and can be associated with other pieces of equipment during its lifecycle.  See {{package(Asset Information Model)}} for more details on {{termplural(asset)}}.
&#10;
&#10;&#10;&#10;Devices Appendix&#10;&#10;&#10;&#10;{{newpage()}} 

## XML Schema Diagrams

See XML schemas for the MTConnect standard here: {{url(https://schemas.mtconnect.org/)}}.

### Components Schema Diagrams

See `Components` element in `MTConnectDevices` schema.

See `Description` element in `MTConnectDevices` schema.

### DataItems Schema Diagrams

See `DataItems` element in `MTConnectDevices` schema.

See `Source` element in `MTConnectDevices` schema.

See `Constraints` element in `MTConnectDevices` schema.

See `Filter` element in `MTConnectDevices` schema.

See `Definition` element in `MTConnectDevices` schema.

### References Schema Diagrams

See `References` element in `MTConnectDevices` schema.

See `ComponentRef` element in `MTConnectDevices` schema.

See `DataItemRef` element in `MTConnectDevices` schema.

### Configuration Schema Diagrams

See `Configuration` element in `MTConnectDevices` schema.

See `CoordinateSystem` element in `MTConnectDevices` schema.

See `Motion` element in `MTConnectDevices` schema.

See `Relationships` element in `MTConnectDevices` schema.

See `ComponentRelationship` element in `MTConnectDevices` schema.

See `DeviceRelationship` element in `MTConnectDevices` schema.

See `SensorConfiguration` element in `MTConnectDevices` schema.

See `SolidModel` element in `MTConnectDevices` schema.

See `Specifications` element in `MTConnectDevices` schema.

See `ProcessSpecification` element in `MTConnectDevices` schema.

## XML Examples

### Device Entity Hierarchy Example

~~~~xml
<Devices>
  <Device id=""d1"" name=""M12346"" uuid=""M80104K162N"">
    <Components>
    <Axes id=""a"" name=""base"">
    <Components>
      <Linear id=""x"" name=""X""/>
      <Linear id=""y"" name=""Y""/>
      <Linear id=""z"" name=""Z""/>
      <Rotary id=""ar"" name=""B""/>
      <Linear id=""w"" name=""Z3"" nativeName=""W""/>
      <Rotary id=""c"" name=""C""/>
    </Components>
    </Axes>
    <Controller id=""cont"" name=""controller"">
    <Components>
      <Path id=""path1"" name=""path""/>
    </Components>
    </Controller>
    <Door id=""door1"" name=""door""/>
    <Systems id=""systems"" name=""systems"">
    <Components>
      <WorkEnvelope id=""we1"" name=""workenv"">
      <Compositions>
        <Composition type=""WORKPIECE"" id=""wp""/>
        <Composition type=""TABLE"" id=""tbl""/>
      </Compositions>
      </WorkEnvelope>
      <Electric id=""elec"" name=""electric""/>
      <Hydraulic id=""hydraulic"" name=""hydraulic""/>
      <Coolant id=""coolant"" name=""coolant""/>
      <Pneumatic id=""pneumatic"" name=""pneumatic""/>
      <Lubrication id=""lubrication"" name=""lubrication""/>
    </Components>
    </Systems>
    <Auxiliaries id=""Aux"" name=""auxiliaries"">
    <Components>
      <Environmental id=""room"" name=""environmental""/>
    </Components>
    </Auxiliaries>
    <Resources id=""resources"" name=""resources"">
    <Components>
      <Personnel id=""personnel"" name=""personnel""/>
      <Materials id=""materials"" name=""materials"">
      <Components>
        <Stock id=""procstock"" name=""stock""/>
      </Components>
      <Materials/>
    </Components> 
    </Resources>
    </Components>
  </Device>
</Devices>
~~~~
{: caption=""Device Entity Hierarchy Example""}

### Component Example

~~~~xml
<Devices>
  <Device id=""d1"" name=""M12346"" uuid=""M80104K162N"">
    <Description manufacturer=""Example_Corporation"" 
      serialNumber=""272237""> Mill w/SMooth-G
    </Description>
  <DataItems>
    <DataItem category=""EVENT"" id=""avail"" name=""avail"" type=""AVAILABILITY""/>
    <DataItem category=""EVENT"" id=""d1_asset_chg"" name=""asset_chg"" type=""ASSET_CHANGED""/>
    <DataItem category=""EVENT"" id=""d1_asset_rem"" name=""asset_rem"" type=""ASSET_REMOVED""/>
  </DataItems>
    <Components>
    <Controller id=""cont"" name=""controller"">
      <DataItems>
      <DataItem category=""EVENT"" id=""estop"" name=""estop"" type=""EMERGENCY_STOP""/>
      <DataItem category=""CONDITION"" id=""logic_cond"" type=""LOGIC_PROGRAM""/>
      <DataItem category=""CONDITION"" id=""cont_system"" type=""SYSTEM""/>
      <DataItem category=""SAMPLE"" id=""cut_time"" type=""ACCUMULATED_TIME"" units=""SECOND""/>
    </DataItems>
    <Components>
      <Path id=""path1"" name=""path"">
        <DataItems>
        <DataItem category=""EVENT"" id=""execution"" name=""execution"" type=""EXECUTION""/>
        <DataItem category=""SAMPLE"" id=""cspeed"" subType=""ACTUAL"" type=""CUTTING_SPEED"" units=""MILLIMETER/SECOND""/>
        <DataItem category=""CONDITION"" id=""path_system"" type=""SYSTEM""/>
        <DataItem category=""EVENT"" id=""cvars"" representation=""DATA_SET"" type=""VARIABLE""/>
        <DataItem category=""EVENT"" id=""woffset"" representation=""TABLE"" type=""WORK_OFFSET""/>
      </DataItems>
      </Path>
    </Components>
    </Controller>
  </Components>
  </Device>
</Devices>
~~~~
{: caption=""Component Example""}

### Component with Compositions Example

In {{term(XML)}}, `Composition` types are represented differently than `Component` types. For `Component` types, the element name is Pascal Case of the `Component` type name. Whereas, the element name for all `Composition`types is `Composition` and the type is defined by the `type` attribute of the element (see example below).

~~~~xml
<WorkEnvelope id=""we1"" name=""workenv"">
  <DataItems>
    <DataItem category=""CONDITION"" id=""hardware1"" name=""hardware1"" type=""HARDWARE""/>
  </DataItems>
  <Compositions>
  <Composition type=""WORKPIECE"" id=""wp""/>
  <Composition type=""TABLE"" id=""tbl""/>
  </Compositions>
</WorkEnvelope>
~~~~
{: caption=""Component with Compositions Example""}

### CoordinateSystem Example

~~~~xml
<Devices>
  <Device id=""d1"" name=""M12346"" uuid=""M80104K162N"">
    <Description manufacturer=""Example_Corporation"" 
      serialNumber=""272237""> Mill w/SMooth-G
    </Description>
    <DataItems>
      <DataItem id=""avail"" type=""AVAILABILITY"" category=""EVENT""/>
      <DataItem category=""EVENT"" id=""d1_asset_chg"" name=""asset_chg"" type=""ASSET_CHANGED""/>
      <DataItem category=""EVENT"" id=""d1_asset_rem"" name=""asset_rem"" type=""ASSET_REMOVED""/>
    </DataItems>
    <Configuration>
      <CoordinateSystems>
        <CoordinateSystem id=""base"" type=""BASE"">
          <Origin>0 0 0</Origin>
        </CoordinateSystem>
        <CoordinateSystem id=""machcoord"" type=""MACHINE"" parentIdRef=""base"">
          <Transformation>
            <Translation>210 275 1430</Translation>
            <Rotation>0 0 0</Rotation>
          </Transformation>
        </CoordinateSystem>
        <CoordinateSystem id=""workcoord"" type=""OBJECT"" parentIdRef=""machcoord"">
          <Transformation>
            <Translation>0 0 0</Translation>
            <Rotation>0 0 0</Rotation>
          </Transformation>
        </CoordinateSystem>
      </CoordinateSystems>
    </Configuration>
  </Device>
</Devices>
~~~~
{: caption=""CoordinateSystem Example""}

### Motion Example

~~~~xml
<Devices>
  <Device id=""d1"" name=""M12346"" uuid=""M80104K162N"">
    <Description manufacturer=""Example_Corporation"" 
      serialNumber=""272237""> Mill w/SMooth-G
    </Description>
    <DataItems>
      <DataItem id=""avail"" type=""AVAILABILITY"" category=""EVENT""/>
      <DataItem category=""EVENT"" id=""d1_asset_chg"" name=""asset_chg"" type=""ASSET_CHANGED""/>
      <DataItem category=""EVENT"" id=""d1_asset_rem"" name=""asset_rem"" type=""ASSET_REMOVED""/>
    </DataItems>
    <Configuration>
      <CoordinateSystems>
        <CoordinateSystem id=""base"" type=""BASE"">
          <Origin>0 0 0</Origin>
        </CoordinateSystem>
        <CoordinateSystem id=""machcoord"" type=""MACHINE"" parentIdRef=""base"">
          <Transformation>
            <Translation>210 275 1430</Translation>
            <Rotation>0 0 0</Rotation>
          </Transformation>
        </CoordinateSystem>
        <CoordinateSystem id=""workcoord"" type=""OBJECT"" parentIdRef=""machcoord"">
          <Transformation>
            <Translation>0 0 0</Translation>
            <Rotation>0 0 0</Rotation>
          </Transformation>
        </CoordinateSystem>
      </CoordinateSystems>
    </Configuration>
    <Components>
      <Axes id=""a"" name=""base"">
        <Components>
          <Linear id=""x"" name=""X"">
            <Configuration>
              <Motion id=""xmotion"" coordinateSystemIdRef=""machcoord"" type=""PRISMATIC"" actuation=""DIRECT"">
                <Transformation>
                  <Translaton>300 915 590</Translaton>
                  <Rotation>0 0 0</Rotation>
                </Transformation>
                <Axis>1.0 0 0</Axis>
              </Motion>
            </Configuration>
          </Linear>
          <DataItems>
            <DataItem id=""xtravel"" type=""SYSTEM"" category=""CONDITION"">
          </DataItems>
        </Components>
      </Axes>
    </Components>
  </Device>
</Devices>
~~~~
{: caption=""Motion Example""}

### Relationship Example

~~~~xml
<Components>
  <Axes id=""a"" name=""base"">
    <Components>
      <Linear id=""x"" name=""X"">
        <Configuration>        
          <Relationships>
            <ComponentRelationship id=""xpar"" type=""PARENT"" idRef=""we1""/>
          </Relationships>
        </Configuration>
      </Linear>
      <DataItems>
        <DataItem id=""xtravel"" type=""SYSTEM"" category=""CONDITION"">
      </DataItems>
    </Components>
  </Axes>
  <Systems id=""systems"" name=""systems"">
    <Components>
      <WorkEnvelope id=""we1"" name=""workenv"">
        <Compositions>
          <Composition type=""WORKPIECE"" id=""wp""/>
          <Composition type=""TABLE"" id=""tbl""/>
        </Compositions>
        <DataItems>
          <DataItem id=""we1cond"" type=""SYSTEM"" category=""CONDITION"">
        </DataItems>
      </WorkEnvelope>
    </Components>
  </Systems>
</Components>
~~~~
{: caption=""Relationship Example""}
      
### SolidModel Example

~~~~xml
<Devices>
  <Device id=""d1"" name=""M12346"" uuid=""M80104K162N"">
    <Description manufacturer=""Example_Corporation"" 
      serialNumber=""272237""> Mill w/SMooth-G
    </Description>
    <DataItems>
      <DataItem id=""avail"" type=""AVAILABILITY"" category=""EVENT""/>
      <DataItem category=""EVENT"" id=""d1_asset_chg"" name=""asset_chg"" type=""ASSET_CHANGED""/>
      <DataItem category=""EVENT"" id=""d1_asset_rem"" name=""asset_rem"" type=""ASSET_REMOVED""/>
    </DataItems>
    <Configuration>
      <CoordinateSystems>
        <CoordinateSystem id=""base"" type=""BASE"">
          <Origin>0 0 0</Origin>
        </CoordinateSystem>
        <CoordinateSystem id=""machcoord"" type=""MACHINE"" parentIdRef=""base"">
          <Transformation>
            <Translation>210 275 1430</Translation>
            <Rotation>0 0 0</Rotation>
          </Transformation>
        </CoordinateSystem>
        <CoordinateSystem id=""workcoord"" type=""OBJECT"" parentIdRef=""machcoord"">
          <Transformation>
            <Translation>0 0 0</Translation>
            <Rotation>0 0 0</Rotation>
          </Transformation>
        </CoordinateSystem>
      </CoordinateSystems>
    </Configuration>
    <Components>
      <Structures id=""struct"">
        <Configuration>
          <SolidModel id=""model"" mediaType=""OBJ"" href=""/objs/mazak.obj"" coordinateSystemIdRef=""base"">
            <Transformation>
              <Translation>0 860 0</Translation>
              <Rotation>-90 0 0</Rotation>
            </Transformation>
            <Scale>0.001 0.001 0.001</Scale>
          </SolidModel>
        </Configuration>
        <Components>
          <Structure id=""xaxis"" name=""X_AXIS"">
            <Configuration>
              <SolidModel id=""x_model"" mediaType=""OBJ"" itemRef=""xaxis"" solidModelIdRef=""model"" coordinateSystemIdRef=""base""/>
            </Configuration>
            <DataItems>
              <DataItem type=""SYSTEM"" category=""CONDITION"" id=""struct_cond""/>
            </DataItems>
          </Structure>
        </Components>
      </Structures>
    </Components>
  </Device>
</Devices>
~~~~
{: caption=""SolidModel Example""}

### Specification Example

~~~~xml
<Components>
  <Axes id=""a"" name=""base"">
    <Components>
      <Linear id=""x"" name=""X"">
        <Configuration>
          <Specifications>
            <Specification id=""spec001"" type=""LENGTH"" units=""MILLIMETER"">
              <Nominal>650</Nominal>
            </Specification>
            <Specification id=""spec002"" type=""LINEAR_FORCE"" units=""NEWTON"">
              <Maximum>5200</Maximum>
              <Minimum>0</Minimum>
            </Specification>
          </Specifications>
        </Configuration>
        <DataItems>
          <DataItem id=""xtravel"" type=""SYSTEM"" category=""CONDITION"">
        </DataItems>
      </Linear>
    </Components>
  </Axes>
</Components>
~~~~
{: caption=""Specification Example""}

### Example of sensing element provided as data item associated with a Component

~~~~xml
<Components>
  <Axes id=""a"" name=""base""
    <Components>
      <Rotary id=""c"" name=""C"">
        <DataItems>
          <DataItem type=""TEMPERATURE"" id=""servotemp4""
            category=""SAMPLE"" nativeUnits=""CELSIUS""
            compositionId=""Bmotor"" units=""CELSIUS""/>
          </DataItems>
      </Rotary>
    </Components>
  </Axes>
</Components>
~~~~
{: caption=""Example of sensing element provided as data item associated with a Component""}

### Example of Sensor for rotary axis

~~~~xml
<Components>
  <Axes id=""a"" name=""base""
    <Components>
      <Rotary id=""ar"" name=""B"">
        <Components>
          <Sensor id=""spdlm"" name=""Spindlemonitor"">
            <DataItems>
              <DataItem type=""DISPLACEMENT"" id=""cvib""
                category=""SAMPLE"" name=""Svib"" 
                units=""MILLIMETER""/>
            </DataItems>
          </Sensor >
        <Components>
      </Rotary>
    </Components>
  </Axes>
</Components>
~~~~
{: caption=""Example of Sensor for rotary axis""}

### Example of sensor unit with sensing element

~~~~xml
<Axes id=""a"" name=""base""
  <Components>
  <Sensor id=""sens1"" name=""Sensorunit"">
    <DataItems>
    <DataItem type=""TEMPERATURE"" id=""sentemp""
      category=""SAMPLE"" name=""Sensortemp"" 
      units=""CELSIUS""/> 
    </DataItems>
  </Sensor >
  <Linear id=""x"" name=""X"">
    <DataItems>
    <DataItem type=""DISPLACEMENT"" id=""xvib""
      category=""SAMPLE"" name=""xvib"" 
      units=""MILLIMETER"">
      <Source componentId=""sens1""/>
    </DataItem>
    </DataItems>
  </Rotary>
  <Linear id=""y"" name=""Y"">
    <DataItems>
    <DataItem type=""DISPLACEMENT"" id=""yvib"" 
      category=""SAMPLE"" name=""yvib"" 
      units=""MILLIMETER"">
      <Source componentId=""sens1""/>
    </DataItem>
    </DataItems>
  </Linear>
  <Components>
</Axes>
~~~~
{: caption=""Example of sensor unit with sensing element""}

### Example of configuration data for Sensor

~~~~xml
<Sensor id=""sensor"" name=""sensor"">
  <Configuration>
    <SensorConfiguration>
      <FirmwareVersion>2.02</FirmwareVersion>
      <CalibrationDate>2010-05-16</CalibrationDate>
      <NextCalibrationDate>2010-05-16</NextCalibrationDate>
      <CalibrationInitials>WS</CalibrationInitials>
      <Channels>
        <Channel number=""1"" name=""A/D:1"">
          <Description>A/D With Thermister</Description>
        </Channel>
      </Channels>
    </SensorConfiguration>
  </Configuration>
  <DataItems>
    <DataItem category=""CONDITION"" id=""sensorc"" 
      name=""sensorc"" type=""SYSTEM"" />
    <DataItem category=""SAMPLE"" id=""senv"" name=""sensorc""
      type=""VOLTAGE_DC"" units=""VOLT"" subType=""ACTUAL"" />
  </DataItems>
</Sensor>
~~~~
{: caption=""Example of configuration data for Sensor""}  &#10;
";

		/// <inheritdoc />
		public IPackage[] Packages => new IPackage[] {
			ComponentsPackage,
			CompositionsPackage,
			DataItemsPackage,
			ReferencesPackage,
			ConfigurationsPackage,
		};
		
		/// <inheritdoc />
		public IClass[] Classes => new IClass[] {
			DeviceClass,
		};
		
		/// <inheritdoc />
		public IEnum[] Enums => new IEnum[] {
		};

		#region Packages
	private Package.ComponentsPackage _ComponentsPackage;
	/// <summary>
	/// <inheritdoc cref="Package.ComponentsPackage" path="/summary" />
	/// </summary>
	public Package.ComponentsPackage ComponentsPackage => _ComponentsPackage ?? (_ComponentsPackage = new Package.ComponentsPackage());

	private Package.CompositionsPackage _CompositionsPackage;
	/// <summary>
	/// <inheritdoc cref="Package.CompositionsPackage" path="/summary" />
	/// </summary>
	public Package.CompositionsPackage CompositionsPackage => _CompositionsPackage ?? (_CompositionsPackage = new Package.CompositionsPackage());

	private Package.DataItemsPackage _DataItemsPackage;
	/// <summary>
	/// <inheritdoc cref="Package.DataItemsPackage" path="/summary" />
	/// </summary>
	public Package.DataItemsPackage DataItemsPackage => _DataItemsPackage ?? (_DataItemsPackage = new Package.DataItemsPackage());

	private Package.ReferencesPackage _ReferencesPackage;
	/// <summary>
	/// <inheritdoc cref="Package.ReferencesPackage" path="/summary" />
	/// </summary>
	public Package.ReferencesPackage ReferencesPackage => _ReferencesPackage ?? (_ReferencesPackage = new Package.ReferencesPackage());

	private Package.ConfigurationsPackage _ConfigurationsPackage;
	/// <summary>
	/// <inheritdoc cref="Package.ConfigurationsPackage" path="/summary" />
	/// </summary>
	public Package.ConfigurationsPackage ConfigurationsPackage => _ConfigurationsPackage ?? (_ConfigurationsPackage = new Package.ConfigurationsPackage());

	#endregion

	#region Classes
	private Package.DeviceClass _DeviceClass;
	/// <summary>
	/// <inheritdoc cref="Package.DeviceClass" path="/summary" />
	/// </summary>
	public Package.DeviceClass DeviceClass => _DeviceClass ?? (_DeviceClass = new Package.DeviceClass());

	#endregion

	#region Enums
	#endregion
	}
}