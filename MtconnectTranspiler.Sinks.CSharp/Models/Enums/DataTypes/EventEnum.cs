#pragma warning disable 0618
#pragma warning disable 1574
using System;
using System.CodeDom.Compiler;

namespace Mtconnect.DataTypes
{
	/// <summary>
	/// View in the MTConnect Model browser <seealso href="https://model.mtconnect.org/#Enumeration___19_0_3_45f01b9_1580398379726_606068_12802">model.mtconnect.org</seealso>
	/// </summary>
	/// <remarks>
	/// <list type="bullet">
	/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_">v</see></item>
	/// <item><b>Deprecated</b>: <see href="https://model.mtconnect.org/#_Version_">v</see></item>
	/// </list>
	/// </remarks>
	[Obsolete("Deprecated in v according to https://model.mtconnect.org/#_Version_")]
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "1.0.15.3")]
	public enum EventEnum
	{
		/// <summary>
		/// set of axes currently associated with a <see cref="Path">Path</see> or <see cref="Controller">Controller</see>.
		/// </summary>
		ACTIVE_AXES,
		/// <summary>
		/// operational state of an apparatus for moving or controlling a mechanism or system.
		/// </summary>
		ACTUATOR_STATE,
		/// <summary>
		/// <b>DEPRECATED:</b> Replaced with <c>CONDITION</c> category data items in Version 1.1.0.
		/// </summary>
		ALARM,
		/// <summary>
		/// <see cref="assetId">assetId</see> of the <i>Asset</i> that has been added or changed.
		/// </summary>
		ASSET_CHANGED,
		/// <summary>
		/// <see cref="assetId">assetId</see> of the <i>Asset</i> that has been removed.
		/// </summary>
		ASSET_REMOVED,
		/// <summary>
		/// <i>agent</i>'s ability to communicate with the data source.
		/// </summary>
		AVAILABILITY,
		/// <summary>
		/// describes the way the axes will be associated to each other.     This is used in conjunction with <c>COUPLED_AXES</c> to indicate the way they are interacting.
		/// </summary>
		AXIS_COUPLING,
		/// <summary>
		/// value of a signal or calculation issued to adjust the feedrate of an individual linear type axis.
		/// </summary>
		AXIS_FEEDRATE_OVERRIDE,
		/// <summary>
		/// state of the axis lockout function when power has been removed and the axis is allowed to move freely.
		/// </summary>
		AXIS_INTERLOCK,
		/// <summary>
		/// state of a <see cref="Linear">Linear</see> or <see cref="Rotary">Rotary</see> component representing an axis.
		/// </summary>
		AXIS_STATE,
		/// <summary>
		/// line of code or command being executed by a <see cref="Controller">Controller</see> entity.
		/// </summary>
		BLOCK,
		/// <summary>
		/// total count of the number of blocks of program code that have been executed since execution started.
		/// </summary>
		BLOCK_COUNT,
		/// <summary>
		/// state of an interlock function or control logic state intended to prevent the associated <see cref="Chuck">Chuck</see> component from being operated.
		/// </summary>
		CHUCK_INTERLOCK,
		/// <summary>
		/// operating state of a mechanism that holds a part or stock material during a manufacturing process.   It may also represent a mechanism that holds any other mechanism in place within a piece of equipment.
		/// </summary>
		CHUCK_STATE,
		/// <summary>
		/// programmatic code being executed.  <b>DEPRECATED</b> in <i>Version 1.1</i>s.
		/// </summary>
		CODE,
		/// <summary>
		/// operating state of a mechanism represented by a <see cref="Composition">Composition</see> entity.
		/// </summary>
		COMPOSITION_STATE,
		/// <summary>
		/// current mode of the <see cref="Controller">Controller</see> component.
		/// </summary>
		CONTROLLER_MODE,
		/// <summary>
		/// setting or operator selection that changes the behavior of a piece of equipment.
		/// </summary>
		CONTROLLER_MODE_OVERRIDE,
		/// <summary>
		/// set of associated axes.
		/// </summary>
		COUPLED_AXES,
		/// <summary>
		/// time and date code associated with a material or other physical item.
		/// </summary>
		DATE_CODE,
		/// <summary>
		/// identifier of another piece of equipment that is temporarily associated with a component of this piece of equipment to perform a particular function.
		/// </summary>
		DEVICE_UUID,
		/// <summary>
		/// direction of motion.
		/// </summary>
		DIRECTION,
		/// <summary>
		/// operational state of a <see cref="Door">Door</see> component or composition element.
		/// </summary>
		DOOR_STATE,
		/// <summary>
		/// state of the emergency stop signal for a piece of equipment, controller path, or any other component or subsystem of a piece of equipment.
		/// </summary>
		EMERGENCY_STOP,
		/// <summary>
		/// indication of whether the end of a piece of bar stock being feed by a bar feeder has been reached.
		/// </summary>
		END_OF_BAR,
		/// <summary>
		/// indication that a piece of equipment, or a sub-part of a piece of equipment, is performing specific types of activities.
		/// </summary>
		EQUIPMENT_MODE,
		/// <summary>
		/// operating state of a <see cref="Component">Component</see>.
		/// </summary>
		EXECUTION,
		/// <summary>
		/// current intended production status of the <see cref="Component">Component</see>.
		/// </summary>
		FUNCTIONAL_MODE,
		/// <summary>
		/// hardness of a material.
		/// </summary>
		HARDNESS,
		/// <summary>
		/// current line of code being executed.  <b>DEPRECATED</b> in <i>Version 1.4.0</i>s.
		/// </summary>
		LINE,
		/// <summary>
		/// identifier for a <see cref="Block">Block</see> of code in a <see cref="Program">Program</see>.
		/// </summary>
		LINE_LABEL,
		/// <summary>
		/// position of a block of program code within a control program.
		/// </summary>
		LINE_NUMBER,
		/// <summary>
		/// identifier of a material used or consumed in the manufacturing process.
		/// </summary>
		MATERIAL,
		/// <summary>
		/// identifies the layers of material applied to a part or product as part of an additive manufacturing process.
		/// </summary>
		MATERIAL_LAYER,
		/// <summary>
		/// information to be transferred from a piece of equipment to a client software application.
		/// </summary>
		MESSAGE,
		/// <summary>
		/// identifier of the person currently responsible for operating the piece of equipment.
		/// </summary>
		OPERATOR_ID,
		/// <summary>
		/// identifier for a pallet.
		/// </summary>
		PALLET_ID,
		/// <summary>
		/// aggregate count of parts.
		/// </summary>
		PART_COUNT,
		/// <summary>
		/// indication designating whether a part or work piece has been detected or is present.
		/// </summary>
		PART_DETECT,
		/// <summary>
		/// identifier of a part in a manufacturing operation.
		/// </summary>
		PART_ID,
		/// <summary>
		/// identifier of a part or product moving through the manufacturing process.  <b>DEPRECATED</b> in <i>Version 1.7</i>s. <c>PART_NUMBER</c> is now a <c>subType</c> of <c>PART_KIND_ID</c>.
		/// </summary>
		PART_NUMBER,
		/// <summary>
		/// value of a signal or calculation issued to adjust the feedrate for the axes associated with a <see cref="Path">Path</see> component that may represent a single axis or the coordinated movement of multiple axes.
		/// </summary>
		PATH_FEEDRATE_OVERRIDE,
		/// <summary>
		/// describes the operational relationship between a <see cref="Path">Path</see> entity and another <see cref="Path">Path</see> entity for pieces of equipment comprised of multiple logical groupings of controlled axes or other logical operations.
		/// </summary>
		PATH_MODE,
		/// <summary>
		/// indication of the status of the source of energy for an entity to allow it to perform its intended function or the state of an enabling signal providing permission for the entity to perform its functions.
		/// </summary>
		POWER_STATE,
		/// <summary>
		/// status of the <see cref="Component">Component</see>.  <b>DEPRECATED</b> in <i>Version 1.1.0</i>s.
		/// </summary>
		POWER_STATUS,
		/// <summary>
		/// time and date associated with an activity or event.
		/// </summary>
		PROCESS_TIME,
		/// <summary>
		/// name of the logic or motion program being executed by the <see cref="Controller">Controller</see> component.
		/// </summary>
		PROGRAM,
		/// <summary>
		/// comment or non-executable statement in the control program.
		/// </summary>
		PROGRAM_COMMENT,
		/// <summary>
		/// indication of the status of the <see cref="Controller">Controller</see> components program editing mode.  A program may be edited while another is executed.
		/// </summary>
		PROGRAM_EDIT,
		/// <summary>
		/// name of the program being edited.   This is used in conjunction with <see cref="ProgramEdit">ProgramEdit</see> when in <c>ACTIVE</c> state. 
		/// </summary>
		PROGRAM_EDIT_NAME,
		/// <summary>
		/// non-executable header section of the control program.
		/// </summary>
		PROGRAM_HEADER,
		/// <summary>
		/// <i>URI</i> for the source file associated with <see cref="Program">Program</see>.
		/// </summary>
		PROGRAM_LOCATION,
		/// <summary>
		/// defines whether the logic or motion program defined by <see cref="Program">Program</see> is being executed from the local memory of the controller or from an outside source.
		/// </summary>
		PROGRAM_LOCATION_TYPE,
		/// <summary>
		/// indication of the nesting level within a control program that is associated with the code or instructions that is currently being executed.
		/// </summary>
		PROGRAM_NEST_LEVEL,
		/// <summary>
		/// current operating mode for a <see cref="Rotary">Rotary</see> type axis.
		/// </summary>
		ROTARY_MODE,
		/// <summary>
		/// percentage change to the velocity of the programmed velocity for a <see cref="Rotary">Rotary</see> axis.
		/// </summary>
		ROTARY_VELOCITY_OVERRIDE,
		/// <summary>
		/// serial number associated with a <see cref="Component">Component</see>, <see cref="Asset">Asset</see>, or <see cref="Device">Device</see>.
		/// </summary>
		SERIAL_NUMBER,
		/// <summary>
		/// indication of the status of the spindle for a piece of equipment when power has been removed and it is free to rotate.
		/// </summary>
		SPINDLE_INTERLOCK,
		/// <summary>
		/// identifier of an individual tool asset.
		/// </summary>
		TOOL_ASSET_ID,
		/// <summary>
		/// identifier for the tool group associated with a specific tool. Commonly used to designate spare tools.
		/// </summary>
		TOOL_GROUP,
		/// <summary>
		/// identifier of the tool currently in use for a given <c>Path</c>.  <b>DEPRECATED</b> in <i>Version 1.2.0</i>s.   See <c>TOOL_ASSET_ID</c>.
		/// </summary>
		TOOL_ID,
		/// <summary>
		/// identifier assigned by the <see cref="Controller">Controller</see> component to a cutting tool when in use by a piece of equipment.
		/// </summary>
		TOOL_NUMBER,
		/// <summary>
		/// reference to the tool offset variables applied to the active cutting tool.
		/// </summary>
		TOOL_OFFSET,
		/// <summary>
		/// identifier of the person currently responsible for operating the piece of equipment.
		/// </summary>
		USER,
		/// <summary>
		/// data whose meaning may change over time due to changes in the operation of a piece of equipment or the process being executed on that piece of equipment.
		/// </summary>
		VARIABLE,
		/// <summary>
		/// indication of the reason that <see cref="Execution">Execution</see> is reporting a value of <c>WAIT</c>.
		/// </summary>
		WAIT_STATE,
		/// <summary>
		/// identifier for the type of wire used as the cutting mechanism in Electrical Discharge Machining or similar processes.
		/// </summary>
		WIRE,
		/// <summary>
		/// identifier for the current workholding or part clamp in use by a piece of equipment.  <b>DEPRECATION WARNING</b>: Recommend using <c>FIXTURE_ID</c> instead.
		/// </summary>
		WORKHOLDING_ID,
		/// <summary>
		/// reference to offset variables for a work piece or part.
		/// </summary>
		WORK_OFFSET,
		/// <summary>
		/// Operating System (OS) of a <see cref="Component">Component</see>.
		/// </summary>
		OPERATING_SYSTEM,
		/// <summary>
		/// embedded software of a <see cref="Component">Component</see> .
		/// </summary>
		FIRMWARE,
		/// <summary>
		/// application on a <see cref="Component">Component</see>.
		/// </summary>
		APPLICATION,
		/// <summary>
		/// software library on a <see cref="Component">Component</see>
		/// </summary>
		LIBRARY,
		/// <summary>
		/// hardware of a <see cref="Component">Component</see>.
		/// </summary>
		HARDWARE,
		/// <summary>
		/// network details of a <see cref="Component">Component</see>.
		/// </summary>
		NETWORK,
		/// <summary>
		/// three space angular displacement of an object or coordinate system relative to a <i>cartesian coordinate system</i>.
		/// </summary>
		ROTATION,
		/// <summary>
		/// three space linear displacement of an object or coordinate system relative to a <i>cartesian coordinate system</i>.
		/// </summary>
		TRANSLATION,
		/// <summary>
		/// <i>UUID</i> of new device added to an <i>MTConnect Agent</i>.
		/// </summary>
		DEVICE_ADDED,
		/// <summary>
		/// <i>UUID</i> of a device removed from an <i>MTConnect Agent</i>.
		/// </summary>
		DEVICE_REMOVED,
		/// <summary>
		/// <i>UUID</i> of the device whose <i>metadata</i> has changed.
		/// </summary>
		DEVICE_CHANGED,
		/// <summary>
		/// status of the connection between an <i>adapter</i> and an <i>agent</i>.
		/// </summary>
		CONNECTION_STATUS,
		/// <summary>
		/// originator’s software version of the <i>adapter</i>.
		/// </summary>
		ADAPTER_SOFTWARE_VERSION,
		/// <summary>
		/// <i>URI</i> of the <i>adapter</i>.
		/// </summary>
		ADAPTER_URI,
		/// <summary>
		/// reference version of the MTConnect Standard supported by the <i>adapter</i>.
		/// </summary>
		MTCONNECT_VERSION,
		/// <summary>
		/// <i>attachment</i> between a sensor and an entity.
		/// </summary>
		SENSOR_ATTACHMENT,
		/// <summary>
		/// state or condition of a part.
		/// </summary>
		PART_STATUS,
		/// <summary>
		/// identifier of a process being executed by the device.
		/// </summary>
		PROCESS_OCCURRENCE_ID,
		/// <summary>
		/// identifier given to link the individual occurrence to a group of related occurrences, such as a process step in a process plan.
		/// </summary>
		PROCESS_AGGREGATE_ID,
		/// <summary>
		/// identifier given to link the individual occurrence to a class of processes or process definition. 
		/// </summary>
		PROCESS_KIND_ID,
		/// <summary>
		/// identifier given to a collection of individual parts. 
		/// </summary>
		PART_GROUP_ID,
		/// <summary>
		/// identifier given to link the individual occurrence to a class of parts, typically distinguished by a particular part design.
		/// </summary>
		PART_KIND_ID,
		/// <summary>
		/// identifier given to a distinguishable, individual part. 
		/// </summary>
		PART_UNIQUE_ID,
		/// <summary>
		/// set of limits used to indicate whether a process variable is stable and in control.  <b>DEPRECATION WARNING</b>. Recommend using <c>CONTROL_LIMITS</c>.
		/// </summary>
		CONTROL_LIMIT,
		/// <summary>
		/// set of limits defining a range of values designating acceptable performance for a variable.  <b>DEPRECATION WARNING</b>. Recommend using <c>SPECIFICATION_LIMITS</c>.
		/// </summary>
		SPECIFICATION_LIMIT,
		/// <summary>
		/// set of limits used to trigger warning or alarm indicators.  <b>DEPRECATION WARNING</b>. Recommend using <c>ALARM_LIMITS</c>.
		/// </summary>
		ALARM_LIMIT,
		/// <summary>
		/// accumulation of the number of times an operation has attempted to, or is planned to attempt to, load materials, parts, or other items.
		/// </summary>
		LOAD_COUNT,
		/// <summary>
		/// accumulation of the number of times an operation has attempted to, or is planned to attempt to, unload materials, parts, or other items.
		/// </summary>
		UNLOAD_COUNT,
		/// <summary>
		/// accumulation of the number of times an operation has attempted to, or is planned to attempt to, transfer materials, parts, or other items from one location to another.
		/// </summary>
		TRANSFER_COUNT,
		/// <summary>
		/// accumulation of the number of times a function has attempted to, or is planned to attempt to, activate or be performed.
		/// </summary>
		ACTIVATION_COUNT,
		/// <summary>
		/// accumulation of the number of times a function has attempted to, or is planned to attempt to, deactivate or cease.
		/// </summary>
		DEACTIVATION_COUNT,
		/// <summary>
		/// accumulation of the number of times a cyclic function has attempted to, or is planned to attempt to execute.
		/// </summary>
		CYCLE_COUNT,
		/// <summary>
		/// state of a valve is one of open, closed, or transitioning between the states.
		/// </summary>
		VALVE_STATE,
		/// <summary>
		/// state or operating mode of a <see cref="Lock">Lock</see>.
		/// </summary>
		LOCK_STATE,
		/// <summary>
		/// particular condition of the process occurrence at a specific time.
		/// </summary>
		PROCESS_STATE,
		/// <summary>
		/// particular condition of the part occurrence at a specific time.
		/// </summary>
		PART_PROCESSING_STATE,
		/// <summary>
		/// state of <see cref="Component">Component</see> or <see cref="Composition">Composition</see> that describes the automatic or manual operation of the entity.
		/// </summary>
		OPERATING_MODE,
		/// <summary>
		/// <i>data set</i> of the number of <i>Asset</i>s of a given type for a <i>Device</i>.
		/// </summary>
		ASSET_COUNT,
		/// <summary>
		/// actions or activities to be performed in support of a piece of equipment.
		/// </summary>
		MAINTENANCE_LIST,
		/// <summary>
		/// identifier for the current workholding or part clamp in use by a piece of equipment.
		/// </summary>
		FIXTURE_ID,
		/// <summary>
		/// interpretation of <c>PART_COUNT</c>.
		/// </summary>
		PART_COUNT_TYPE,
		/// <summary>
		/// time provided by a timing device at a specific point in time.
		/// </summary>
		CLOCK_TIME,
		/// <summary>
		/// name of the host computer supplying data.
		/// </summary>
		HOST_NAME,
		/// <summary>
		/// number of the TCP/IP or UDP/IP port for the connection endpoint.
		/// </summary>
		NETWORK_PORT,
		/// <summary>
		/// indication designating whether a leak has been detected.
		/// </summary>
		LEAK_DETECT,
		/// <summary>
		/// present status of the battery.
		/// </summary>
		BATTERY_STATE,
		/// <summary>
		/// <i>UUID</i> of a <i>feature</i>. <seealso href="https://www.google.com/search?q=ISO 10303 AP 242/239&btnI=I">ISO 10303 AP 242/239</seealso>.
		/// </summary>
		FEATURE_PERSISTENT_ID,
		/// <summary>
		/// detection result of a sensor.
		/// </summary>
		SENSOR_STATE,
		/// <summary>
		/// <see cref="Event">Event</see> that represents a <see cref="Component">Component</see> where the <see cref="EntryDefinition">EntryDefinition</see> identifies the <see cref="Component">Component</see> and the <see cref="CellDefinition">CellDefinition</see>s define the <see cref="Component">Component</see>'s observed <see cref="DataItem">DataItem</see>s.
		/// </summary>
		COMPONENT_DATA,
		/// <summary>
		/// properties of each addressable work offset.
		/// </summary>
		WORK_OFFSETS,
		/// <summary>
		/// properties of each addressable tool offset.
		/// </summary>
		TOOL_OFFSETS,
		/// <summary>
		/// assessing elements of a <i>feature</i>.
		/// </summary>
		FEATURE_MEASUREMENT,
		/// <summary>
		/// <i>UUID</i> of the <i>characteristic</i>.
		/// </summary>
		CHARACTERISTIC_PERSISTENT_ID,
		/// <summary>
		/// class of measurement being performed. <seealso href="https://www.google.com/search?q=QIF 3:2018 Section 6.3&btnI=I">QIF 3:2018 Section 6.3</seealso>
		/// </summary>
		MEASUREMENT_TYPE,
		/// <summary>
		/// measurement based on the measurement type.
		/// </summary>
		MEASUREMENT_VALUE,
		/// <summary>
		/// engineering units of the measurement.
		/// </summary>
		MEASUREMENT_UNITS,
		/// <summary>
		/// pass/fail result of the measurement.
		/// </summary>
		CHARACTERISTIC_STATUS,
		/// <summary>
		/// method used to compute <i>standard uncertainty</i>.
		/// </summary>
		UNCERTAINTY_TYPE,
		/// <summary>
		/// <i>uncertainty</i> specified by <see cref="UncertaintyType">UncertaintyType</see>.
		/// </summary>
		UNCERTAINTY,
		/// <summary>
		/// set of limits defining a range of values designating acceptable performance for a variable.
		/// </summary>
		SPECIFICATION_LIMITS,
		/// <summary>
		/// set of limits used to indicate whether a process variable is stable and in control.
		/// </summary>
		CONTROL_LIMITS,
		/// <summary>
		/// set of limits used to trigger warning or alarm indicators.
		/// </summary>
		ALARM_LIMITS,
		/// <summary>
		/// references the <see cref="CuttingToolLifeCycle">CuttingToolLifeCycle</see> <see cref="CuttingItem">CuttingItem</see> index related to the <see cref="CuttingItem::indices" /> of the currently active cutting tool edge.
		/// </summary>
		TOOL_CUTTING_ITEM,
		/// <summary>
		/// structured information that allows the unambiguous determination of an object for purposes of identification and location. <seealso href="https://www.google.com/search?q=ISO 19160-4:2017&btnI=I">ISO 19160-4:2017</seealso>
		/// </summary>
		LOCATION_ADDRESS,
		/// <summary>
		/// active energy source for the <see cref="Component">Component</see>.
		/// </summary>
		POWER_SOURCE,
	}
}