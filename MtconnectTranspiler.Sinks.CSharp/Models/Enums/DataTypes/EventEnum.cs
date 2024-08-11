using System;
using System.CodeDom.Compiler;using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;

namespace Mtconnect.DataTypes
{
	/// <summary>
	/// View in the MTConnect Model browser <seealso href="https://model.mtconnect.org/#Enumeration___19_0_3_45f01b9_1580398379726_606068_12802">model.mtconnect.org</seealso>
	/// </summary>
	/// <remarks>
	/// <list type="bullet">
	/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
	/// </list>
	/// </remarks>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.3.0.0")]
	public enum EventEnum
	{
		/// <summary>
		/// set of axes currently associated with a <see cref="Path">Path</see> or <see cref="Controller">Controller</see>.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.1">v1.1</see></item>
		/// </list>
		/// </remarks>
		ACTIVE_AXES,
		/// <summary>
		/// operational state of an apparatus for moving or controlling a mechanism or system.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.2">v1.2</see></item>
		/// </list>
		/// </remarks>
		ACTUATOR_STATE,
		/// <summary>
		/// <b>DEPRECATED:</b> Replaced with <c>CONDITION</c> category data items in Version 1.1.0.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// <item><b>Deprecated</b>: <see href="https://model.mtconnect.org/#_Version_1.1">v1.1</see></item>
		/// </list>
		/// </remarks>
		[Obsolete("Deprecated in v1.1 according to https://model.mtconnect.org/#_Version_1.1")]
		ALARM,
		/// <summary>
		/// <see cref="assetId">assetId</see> of the <i>Asset</i> that has been added or changed.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.2">v1.2</see></item>
		/// </list>
		/// </remarks>
		ASSET_CHANGED,
		/// <summary>
		/// <see cref="assetId">assetId</see> of the <i>Asset</i> that has been removed.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.3">v1.3</see></item>
		/// </list>
		/// </remarks>
		ASSET_REMOVED,
		/// <summary>
		/// <i>agent</i>'s ability to communicate with the data source.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.1">v1.1</see></item>
		/// </list>
		/// </remarks>
		AVAILABILITY,
		/// <summary>
		/// describes the way the axes will be associated to each other.     This is used in conjunction with <c>COUPLED_AXES</c> to indicate the way they are interacting.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.1">v1.1</see></item>
		/// </list>
		/// </remarks>
		AXIS_COUPLING,
		/// <summary>
		/// value of a signal or calculation issued to adjust the feedrate of an individual linear type axis.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.3">v1.3</see></item>
		/// </list>
		/// </remarks>
		AXIS_FEEDRATE_OVERRIDE,
		/// <summary>
		/// state of the axis lockout function when power has been removed and the axis is allowed to move freely.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.3">v1.3</see></item>
		/// </list>
		/// </remarks>
		AXIS_INTERLOCK,
		/// <summary>
		/// state of a <see cref="Linear">Linear</see> or <see cref="Rotary">Rotary</see> component representing an axis.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.3">v1.3</see></item>
		/// </list>
		/// </remarks>
		AXIS_STATE,
		/// <summary>
		/// line of code or command being executed by a <see cref="Controller">Controller</see> entity.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>
		BLOCK,
		/// <summary>
		/// total count of the number of blocks of program code that have been executed since execution started.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.4">v1.4</see></item>
		/// </list>
		/// </remarks>
		BLOCK_COUNT,
		/// <summary>
		/// state of an interlock function or control logic state intended to prevent the associated <see cref="Chuck">Chuck</see> component from being operated.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.3">v1.3</see></item>
		/// </list>
		/// </remarks>
		CHUCK_INTERLOCK,
		/// <summary>
		/// operating state of a mechanism that holds a part or stock material during a manufacturing process.   It may also represent a mechanism that holds any other mechanism in place within a piece of equipment.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.3">v1.3</see></item>
		/// </list>
		/// </remarks>
		CHUCK_STATE,
		/// <summary>
		/// programmatic code being executed.  <b>DEPRECATED</b> in <i>Version 1.1</i>s.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// <item><b>Deprecated</b>: <see href="https://model.mtconnect.org/#_Version_1.1">v1.1</see></item>
		/// </list>
		/// </remarks>
		[Obsolete("Deprecated in v1.1 according to https://model.mtconnect.org/#_Version_1.1")]
		CODE,
		/// <summary>
		/// operating state of a mechanism represented by a <see cref="Composition">Composition</see> entity.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.4">v1.4</see></item>
		/// </list>
		/// </remarks>
		COMPOSITION_STATE,
		/// <summary>
		/// current mode of the <see cref="Controller">Controller</see> component.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>
		CONTROLLER_MODE,
		/// <summary>
		/// setting or operator selection that changes the behavior of a piece of equipment.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.4">v1.4</see></item>
		/// </list>
		/// </remarks>
		CONTROLLER_MODE_OVERRIDE,
		/// <summary>
		/// set of associated axes.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.2">v1.2</see></item>
		/// </list>
		/// </remarks>
		COUPLED_AXES,
		/// <summary>
		/// time and date code associated with a material or other physical item.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.5">v1.5</see></item>
		/// </list>
		/// </remarks>
		DATE_CODE,
		/// <summary>
		/// identifier of another piece of equipment that is temporarily associated with a component of this piece of equipment to perform a particular function.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.5">v1.5</see></item>
		/// </list>
		/// </remarks>
		DEVICE_UUID,
		/// <summary>
		/// direction of motion.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>
		DIRECTION,
		/// <summary>
		/// operational state of a <see cref="Door">Door</see> component or composition element.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.1">v1.1</see></item>
		/// </list>
		/// </remarks>
		DOOR_STATE,
		/// <summary>
		/// state of the emergency stop signal for a piece of equipment, controller path, or any other component or subsystem of a piece of equipment.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.1">v1.1</see></item>
		/// </list>
		/// </remarks>
		EMERGENCY_STOP,
		/// <summary>
		/// indication of whether the end of a piece of bar stock being feed by a bar feeder has been reached.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.3">v1.3</see></item>
		/// </list>
		/// </remarks>
		END_OF_BAR,
		/// <summary>
		/// indication that a piece of equipment, or a sub-part of a piece of equipment, is performing specific types of activities.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.4">v1.4</see></item>
		/// </list>
		/// </remarks>
		EQUIPMENT_MODE,
		/// <summary>
		/// operating state of a <see cref="Component">Component</see>.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>
		EXECUTION,
		/// <summary>
		/// current intended production status of the <see cref="Component">Component</see>.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.3">v1.3</see></item>
		/// </list>
		/// </remarks>
		FUNCTIONAL_MODE,
		/// <summary>
		/// hardness of a material.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.4">v1.4</see></item>
		/// </list>
		/// </remarks>
		HARDNESS,
		/// <summary>
		/// current line of code being executed.  <b>DEPRECATED</b> in <i>Version 1.4.0</i>s.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// <item><b>Deprecated</b>: <see href="https://model.mtconnect.org/#_Version_1.4">v1.4</see></item>
		/// </list>
		/// </remarks>
		[Obsolete("Deprecated in v1.4 according to https://model.mtconnect.org/#_Version_1.4")]
		LINE,
		/// <summary>
		/// identifier for a <see cref="Block">Block</see> of code in a <see cref="Program">Program</see>.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.4">v1.4</see></item>
		/// </list>
		/// </remarks>
		LINE_LABEL,
		/// <summary>
		/// position of a block of program code within a control program.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.4">v1.4</see></item>
		/// </list>
		/// </remarks>
		LINE_NUMBER,
		/// <summary>
		/// identifier of a material used or consumed in the manufacturing process.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.4">v1.4</see></item>
		/// </list>
		/// </remarks>
		MATERIAL,
		/// <summary>
		/// identifies the layers of material applied to a part or product as part of an additive manufacturing process.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.5">v1.5</see></item>
		/// </list>
		/// </remarks>
		MATERIAL_LAYER,
		/// <summary>
		/// information to be transferred from a piece of equipment to a client software application.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.1">v1.1</see></item>
		/// </list>
		/// </remarks>
		MESSAGE,
		/// <summary>
		/// identifier of the person currently responsible for operating the piece of equipment.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.3">v1.3</see></item>
		/// </list>
		/// </remarks>
		OPERATOR_ID,
		/// <summary>
		/// identifier for a pallet.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.2">v1.2</see></item>
		/// </list>
		/// </remarks>
		PALLET_ID,
		/// <summary>
		/// aggregate count of parts.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>
		PART_COUNT,
		/// <summary>
		/// indication designating whether a part or work piece has been detected or is present.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.5">v1.5</see></item>
		/// </list>
		/// </remarks>
		PART_DETECT,
		/// <summary>
		/// identifier of a part in a manufacturing operation.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.1">v1.1</see></item>
		/// </list>
		/// </remarks>
		PART_ID,
		/// <summary>
		/// identifier of a part or product moving through the manufacturing process.  <b>DEPRECATED</b> in <i>Version 1.7</i>s. <c>PART_NUMBER</c> is now a <c>subType</c> of <c>PART_KIND_ID</c>.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.4">v1.4</see></item>
		/// <item><b>Deprecated</b>: <see href="https://model.mtconnect.org/#_Version_1.7">v1.7</see></item>
		/// </list>
		/// </remarks>
		[Obsolete("Deprecated in v1.7 according to https://model.mtconnect.org/#_Version_1.7")]
		PART_NUMBER,
		/// <summary>
		/// value of a signal or calculation issued to adjust the feedrate for the axes associated with a <see cref="Path">Path</see> component that may represent a single axis or the coordinated movement of multiple axes.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.3">v1.3</see></item>
		/// </list>
		/// </remarks>
		PATH_FEEDRATE_OVERRIDE,
		/// <summary>
		/// describes the operational relationship between a <see cref="Path">Path</see> entity and another <see cref="Path">Path</see> entity for pieces of equipment comprised of multiple logical groupings of controlled axes or other logical operations.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.1">v1.1</see></item>
		/// </list>
		/// </remarks>
		PATH_MODE,
		/// <summary>
		/// indication of the status of the source of energy for an entity to allow it to perform its intended function or the state of an enabling signal providing permission for the entity to perform its functions.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.1">v1.1</see></item>
		/// </list>
		/// </remarks>
		POWER_STATE,
		/// <summary>
		/// status of the <see cref="Component">Component</see>.  <b>DEPRECATED</b> in <i>Version 1.1.0</i>s.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// <item><b>Deprecated</b>: <see href="https://model.mtconnect.org/#_Version_1.1">v1.1</see></item>
		/// </list>
		/// </remarks>
		[Obsolete("Deprecated in v1.1 according to https://model.mtconnect.org/#_Version_1.1")]
		POWER_STATUS,
		/// <summary>
		/// time and date associated with an activity or event.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.5">v1.5</see></item>
		/// </list>
		/// </remarks>
		PROCESS_TIME,
		/// <summary>
		/// name of the logic or motion program being executed by the <see cref="Controller">Controller</see> component.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>
		PROGRAM,
		/// <summary>
		/// comment or non-executable statement in the control program.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.3">v1.3</see></item>
		/// </list>
		/// </remarks>
		PROGRAM_COMMENT,
		/// <summary>
		/// indication of the status of the <see cref="Controller">Controller</see> components program editing mode.  A program may be edited while another is executed.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.3">v1.3</see></item>
		/// </list>
		/// </remarks>
		PROGRAM_EDIT,
		/// <summary>
		/// name of the program being edited.   This is used in conjunction with <see cref="ProgramEdit">ProgramEdit</see> when in <c>ACTIVE</c> state. 
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.3">v1.3</see></item>
		/// </list>
		/// </remarks>
		PROGRAM_EDIT_NAME,
		/// <summary>
		/// non-executable header section of the control program.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.3">v1.3</see></item>
		/// </list>
		/// </remarks>
		PROGRAM_HEADER,
		/// <summary>
		/// <i>URI</i> for the source file associated with <see cref="Program">Program</see>.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.5">v1.5</see></item>
		/// </list>
		/// </remarks>
		PROGRAM_LOCATION,
		/// <summary>
		/// defines whether the logic or motion program defined by <see cref="Program">Program</see> is being executed from the local memory of the controller or from an outside source.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.5">v1.5</see></item>
		/// </list>
		/// </remarks>
		PROGRAM_LOCATION_TYPE,
		/// <summary>
		/// indication of the nesting level within a control program that is associated with the code or instructions that is currently being executed.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.5">v1.5</see></item>
		/// </list>
		/// </remarks>
		PROGRAM_NEST_LEVEL,
		/// <summary>
		/// current operating mode for a <see cref="Rotary">Rotary</see> type axis.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.1">v1.1</see></item>
		/// </list>
		/// </remarks>
		ROTARY_MODE,
		/// <summary>
		/// percentage change to the velocity of the programmed velocity for a <see cref="Rotary">Rotary</see> axis.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.3">v1.3</see></item>
		/// </list>
		/// </remarks>
		ROTARY_VELOCITY_OVERRIDE,
		/// <summary>
		/// serial number associated with a <see cref="Component">Component</see>, <see cref="Asset">Asset</see>, or <see cref="Device">Device</see>.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.4">v1.4</see></item>
		/// </list>
		/// </remarks>
		SERIAL_NUMBER,
		/// <summary>
		/// indication of the status of the spindle for a piece of equipment when power has been removed and it is free to rotate.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.3">v1.3</see></item>
		/// </list>
		/// </remarks>
		SPINDLE_INTERLOCK,
		/// <summary>
		/// identifier of an individual tool asset.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.2">v1.2</see></item>
		/// </list>
		/// </remarks>
		TOOL_ASSET_ID,
		/// <summary>
		/// identifier for the tool group associated with a specific tool. Commonly used to designate spare tools.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.5">v1.5</see></item>
		/// </list>
		/// </remarks>
		TOOL_GROUP,
		/// <summary>
		/// identifier of the tool currently in use for a given <c>Path</c>.  <b>DEPRECATED</b> in <i>Version 1.2.0</i>s.   See <c>TOOL_ASSET_ID</c>.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.1">v1.1</see></item>
		/// <item><b>Deprecated</b>: <see href="https://model.mtconnect.org/#_Version_1.2">v1.2</see></item>
		/// </list>
		/// </remarks>
		[Obsolete("Deprecated in v1.2 according to https://model.mtconnect.org/#_Version_1.2")]
		TOOL_ID,
		/// <summary>
		/// identifier assigned by the <see cref="Controller">Controller</see> component to a cutting tool when in use by a piece of equipment.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.2">v1.2</see></item>
		/// </list>
		/// </remarks>
		TOOL_NUMBER,
		/// <summary>
		/// reference to the tool offset variables applied to the active cutting tool.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.4">v1.4</see></item>
		/// </list>
		/// </remarks>
		TOOL_OFFSET,
		/// <summary>
		/// identifier of the person currently responsible for operating the piece of equipment.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.4">v1.4</see></item>
		/// </list>
		/// </remarks>
		USER,
		/// <summary>
		/// data whose meaning may change over time due to changes in the operation of a piece of equipment or the process being executed on that piece of equipment.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.5">v1.5</see></item>
		/// </list>
		/// </remarks>
		VARIABLE,
		/// <summary>
		/// indication of the reason that <see cref="Execution">Execution</see> is reporting a value of <c>WAIT</c>.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.5">v1.5</see></item>
		/// </list>
		/// </remarks>
		WAIT_STATE,
		/// <summary>
		/// identifier for the type of wire used as the cutting mechanism in Electrical Discharge Machining or similar processes.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.4">v1.4</see></item>
		/// </list>
		/// </remarks>
		WIRE,
		/// <summary>
		/// identifier for the current workholding or part clamp in use by a piece of equipment.  <b>DEPRECATION WARNING</b>: Recommend using <c>FIXTURE_ID</c> instead.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.1">v1.1</see></item>
		/// </list>
		/// </remarks>
		WORKHOLDING_ID,
		/// <summary>
		/// reference to offset variables for a work piece or part.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.4">v1.4</see></item>
		/// </list>
		/// </remarks>
		WORK_OFFSET,
		/// <summary>
		/// Operating System (OS) of a <see cref="Component">Component</see>.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.6">v1.6</see></item>
		/// </list>
		/// </remarks>
		OPERATING_SYSTEM,
		/// <summary>
		/// embedded software of a <see cref="Component">Component</see> .
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.6">v1.6</see></item>
		/// </list>
		/// </remarks>
		FIRMWARE,
		/// <summary>
		/// application on a <see cref="Component">Component</see>.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.6">v1.6</see></item>
		/// </list>
		/// </remarks>
		APPLICATION,
		/// <summary>
		/// software library on a <see cref="Component">Component</see>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.6">v1.6</see></item>
		/// </list>
		/// </remarks>
		LIBRARY,
		/// <summary>
		/// hardware of a <see cref="Component">Component</see>.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.6">v1.6</see></item>
		/// </list>
		/// </remarks>
		HARDWARE,
		/// <summary>
		/// network details of a <see cref="Component">Component</see>.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.6">v1.6</see></item>
		/// </list>
		/// </remarks>
		NETWORK,
		/// <summary>
		/// three space angular displacement of an object or coordinate system relative to a <i>cartesian coordinate system</i>.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.6">v1.6</see></item>
		/// </list>
		/// </remarks>
		ROTATION,
		/// <summary>
		/// three space linear displacement of an object or coordinate system relative to a <i>cartesian coordinate system</i>.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.6">v1.6</see></item>
		/// </list>
		/// </remarks>
		TRANSLATION,
		/// <summary>
		/// <i>UUID</i> of new device added to an <i>MTConnect Agent</i>.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.7">v1.7</see></item>
		/// </list>
		/// </remarks>
		DEVICE_ADDED,
		/// <summary>
		/// <i>UUID</i> of a device removed from an <i>MTConnect Agent</i>.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.7">v1.7</see></item>
		/// </list>
		/// </remarks>
		DEVICE_REMOVED,
		/// <summary>
		/// <i>UUID</i> of the device whose <i>metadata</i> has changed.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.7">v1.7</see></item>
		/// </list>
		/// </remarks>
		DEVICE_CHANGED,
		/// <summary>
		/// status of the connection between an <i>adapter</i> and an <i>agent</i>.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.7">v1.7</see></item>
		/// </list>
		/// </remarks>
		CONNECTION_STATUS,
		/// <summary>
		/// originator’s software version of the <i>adapter</i>.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.7">v1.7</see></item>
		/// </list>
		/// </remarks>
		ADAPTER_SOFTWARE_VERSION,
		/// <summary>
		/// <i>URI</i> of the <i>adapter</i>.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.7">v1.7</see></item>
		/// </list>
		/// </remarks>
		ADAPTER_URI,
		/// <summary>
		/// reference version of the MTConnect Standard supported by the <i>adapter</i>.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.7">v1.7</see></item>
		/// </list>
		/// </remarks>
		MTCONNECT_VERSION,
		/// <summary>
		/// <i>attachment</i> between a sensor and an entity.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.7">v1.7</see></item>
		/// </list>
		/// </remarks>
		SENSOR_ATTACHMENT,
		/// <summary>
		/// state or condition of a part.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.7">v1.7</see></item>
		/// </list>
		/// </remarks>
		PART_STATUS,
		/// <summary>
		/// identifier of a process being executed by the device.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.7">v1.7</see></item>
		/// </list>
		/// </remarks>
		PROCESS_OCCURRENCE_ID,
		/// <summary>
		/// identifier given to link the individual occurrence to a group of related occurrences, such as a process step in a process plan.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.7">v1.7</see></item>
		/// </list>
		/// </remarks>
		PROCESS_AGGREGATE_ID,
		/// <summary>
		/// identifier given to link the individual occurrence to a class of processes or process definition. 
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.7">v1.7</see></item>
		/// </list>
		/// </remarks>
		PROCESS_KIND_ID,
		/// <summary>
		/// identifier given to a collection of individual parts. 
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.7">v1.7</see></item>
		/// </list>
		/// </remarks>
		PART_GROUP_ID,
		/// <summary>
		/// identifier given to link the individual occurrence to a class of parts, typically distinguished by a particular part design.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.7">v1.7</see></item>
		/// </list>
		/// </remarks>
		PART_KIND_ID,
		/// <summary>
		/// identifier given to a distinguishable, individual part. 
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.7">v1.7</see></item>
		/// </list>
		/// </remarks>
		PART_UNIQUE_ID,
		/// <summary>
		/// set of limits used to indicate whether a process variable is stable and in control.  <b>DEPRECATION WARNING</b>. Recommend using <c>CONTROL_LIMITS</c>.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.7">v1.7</see></item>
		/// </list>
		/// </remarks>
		CONTROL_LIMIT,
		/// <summary>
		/// set of limits defining a range of values designating acceptable performance for a variable.  <b>DEPRECATION WARNING</b>. Recommend using <c>SPECIFICATION_LIMITS</c>.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.7">v1.7</see></item>
		/// </list>
		/// </remarks>
		SPECIFICATION_LIMIT,
		/// <summary>
		/// set of limits used to trigger warning or alarm indicators.  <b>DEPRECATION WARNING</b>. Recommend using <c>ALARM_LIMITS</c>.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.7">v1.7</see></item>
		/// </list>
		/// </remarks>
		ALARM_LIMIT,
		/// <summary>
		/// accumulation of the number of times an operation has attempted to, or is planned to attempt to, load materials, parts, or other items.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.8">v1.8</see></item>
		/// </list>
		/// </remarks>
		LOAD_COUNT,
		/// <summary>
		/// accumulation of the number of times an operation has attempted to, or is planned to attempt to, unload materials, parts, or other items.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.8">v1.8</see></item>
		/// </list>
		/// </remarks>
		UNLOAD_COUNT,
		/// <summary>
		/// accumulation of the number of times an operation has attempted to, or is planned to attempt to, transfer materials, parts, or other items from one location to another.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.8">v1.8</see></item>
		/// </list>
		/// </remarks>
		TRANSFER_COUNT,
		/// <summary>
		/// accumulation of the number of times a function has attempted to, or is planned to attempt to, activate or be performed.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.8">v1.8</see></item>
		/// </list>
		/// </remarks>
		ACTIVATION_COUNT,
		/// <summary>
		/// accumulation of the number of times a function has attempted to, or is planned to attempt to, deactivate or cease.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.8">v1.8</see></item>
		/// </list>
		/// </remarks>
		DEACTIVATION_COUNT,
		/// <summary>
		/// accumulation of the number of times a cyclic function has attempted to, or is planned to attempt to execute.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.8">v1.8</see></item>
		/// </list>
		/// </remarks>
		CYCLE_COUNT,
		/// <summary>
		/// state of a valve is one of open, closed, or transitioning between the states.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.8">v1.8</see></item>
		/// </list>
		/// </remarks>
		VALVE_STATE,
		/// <summary>
		/// state or operating mode of a <see cref="Lock">Lock</see>.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.8">v1.8</see></item>
		/// </list>
		/// </remarks>
		LOCK_STATE,
		/// <summary>
		/// particular condition of the process occurrence at a specific time.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.8">v1.8</see></item>
		/// </list>
		/// </remarks>
		PROCESS_STATE,
		/// <summary>
		/// particular condition of the part occurrence at a specific time.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.8">v1.8</see></item>
		/// </list>
		/// </remarks>
		PART_PROCESSING_STATE,
		/// <summary>
		/// state of <see cref="Component">Component</see> or <see cref="Composition">Composition</see> that describes the automatic or manual operation of the entity.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_2.0">v2.0</see></item>
		/// </list>
		/// </remarks>
		OPERATING_MODE,
		/// <summary>
		/// <i>data set</i> of the number of <i>Asset</i>s of a given type for a <i>Device</i>.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_2.0">v2.0</see></item>
		/// </list>
		/// </remarks>
		ASSET_COUNT,
		/// <summary>
		/// actions or activities to be performed in support of a piece of equipment.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_2.0">v2.0</see></item>
		/// </list>
		/// </remarks>
		MAINTENANCE_LIST,
		/// <summary>
		/// identifier for the current workholding or part clamp in use by a piece of equipment.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_2.0">v2.0</see></item>
		/// </list>
		/// </remarks>
		FIXTURE_ID,
		/// <summary>
		/// interpretation of <c>PART_COUNT</c>.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_2.0">v2.0</see></item>
		/// </list>
		/// </remarks>
		PART_COUNT_TYPE,
		/// <summary>
		/// time provided by a timing device at a specific point in time.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.2">v1.2</see></item>
		/// </list>
		/// </remarks>
		CLOCK_TIME,
		/// <summary>
		/// name of the host computer supplying data.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_2.1">v2.1</see></item>
		/// </list>
		/// </remarks>
		HOST_NAME,
		/// <summary>
		/// number of the TCP/IP or UDP/IP port for the connection endpoint.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_2.1">v2.1</see></item>
		/// </list>
		/// </remarks>
		NETWORK_PORT,
		/// <summary>
		/// indication designating whether a leak has been detected.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_2.1">v2.1</see></item>
		/// </list>
		/// </remarks>
		LEAK_DETECT,
		/// <summary>
		/// present status of the battery.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_2.1">v2.1</see></item>
		/// </list>
		/// </remarks>
		BATTERY_STATE,
		/// <summary>
		/// <i>UUID</i> of a <i>feature</i>. <seealso href="https://www.google.com/search?q=ISO 10303 AP 242/239&btnI=I">ISO 10303 AP 242/239</seealso>.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_2.2">v2.2</see></item>
		/// </list>
		/// </remarks>
		FEATURE_PERSISTENT_ID,
		/// <summary>
		/// detection result of a sensor.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_2.2">v2.2</see></item>
		/// </list>
		/// </remarks>
		SENSOR_STATE,
		/// <summary>
		/// <see cref="Event">Event</see> that represents a <see cref="Component">Component</see> where the <see cref="EntryDefinition">EntryDefinition</see> identifies the <see cref="Component">Component</see> and the <see cref="CellDefinition">CellDefinition</see>s define the <see cref="Component">Component</see>'s observed <see cref="DataItem">DataItem</see>s.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_2.2">v2.2</see></item>
		/// </list>
		/// </remarks>
		COMPONENT_DATA,
		/// <summary>
		/// properties of each addressable work offset.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_2.2">v2.2</see></item>
		/// </list>
		/// </remarks>
		WORK_OFFSETS,
		/// <summary>
		/// properties of each addressable tool offset.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_2.2">v2.2</see></item>
		/// </list>
		/// </remarks>
		TOOL_OFFSETS,
		/// <summary>
		/// assessing elements of a <i>feature</i>.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_2.2">v2.2</see></item>
		/// </list>
		/// </remarks>
		FEATURE_MEASUREMENT,
		/// <summary>
		/// <i>UUID</i> of the <i>characteristic</i>.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_2.2">v2.2</see></item>
		/// </list>
		/// </remarks>
		CHARACTERISTIC_PERSISTENT_ID,
		/// <summary>
		/// class of measurement being performed. <seealso href="https://www.google.com/search?q=QIF 3:2018 Section 6.3&btnI=I">QIF 3:2018 Section 6.3</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_2.2">v2.2</see></item>
		/// </list>
		/// </remarks>
		MEASUREMENT_TYPE,
		/// <summary>
		/// measurement based on the measurement type.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_2.2">v2.2</see></item>
		/// </list>
		/// </remarks>
		MEASUREMENT_VALUE,
		/// <summary>
		/// engineering units of the measurement.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_2.2">v2.2</see></item>
		/// </list>
		/// </remarks>
		MEASUREMENT_UNITS,
		/// <summary>
		/// pass/fail result of the measurement.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_2.2">v2.2</see></item>
		/// </list>
		/// </remarks>
		CHARACTERISTIC_STATUS,
		/// <summary>
		/// method used to compute <i>standard uncertainty</i>.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_2.2">v2.2</see></item>
		/// </list>
		/// </remarks>
		UNCERTAINTY_TYPE,
		/// <summary>
		/// <i>uncertainty</i> specified by <see cref="UncertaintyType">UncertaintyType</see>.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_2.2">v2.2</see></item>
		/// </list>
		/// </remarks>
		UNCERTAINTY,
		/// <summary>
		/// set of limits defining a range of values designating acceptable performance for a variable.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_2.3">v2.3</see></item>
		/// </list>
		/// </remarks>
		SPECIFICATION_LIMITS,
		/// <summary>
		/// set of limits used to indicate whether a process variable is stable and in control.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_2.3">v2.3</see></item>
		/// </list>
		/// </remarks>
		CONTROL_LIMITS,
		/// <summary>
		/// set of limits used to trigger warning or alarm indicators.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_2.3">v2.3</see></item>
		/// </list>
		/// </remarks>
		ALARM_LIMITS,
		/// <summary>
		/// references the <see cref="CuttingToolLifeCycle">CuttingToolLifeCycle</see> <see cref="CuttingItem">CuttingItem</see> index related to the <see cref="CuttingItem::indices" /> of the currently active cutting tool edge.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_2.3">v2.3</see></item>
		/// </list>
		/// </remarks>
		TOOL_CUTTING_ITEM,
		/// <summary>
		/// structured information that allows the unambiguous determination of an object for purposes of identification and location. <seealso href="https://www.google.com/search?q=ISO 19160-4:2017&btnI=I">ISO 19160-4:2017</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_2.3">v2.3</see></item>
		/// </list>
		/// </remarks>
		LOCATION_ADDRESS,
		/// <summary>
		/// active energy source for the <see cref="Component">Component</see>.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_2.3">v2.3</see></item>
		/// </list>
		/// </remarks>
		POWER_SOURCE,
	}

	/// <summary>
	/// View in the MTConnect Model browser <seealso href="https://model.mtconnect.org/#Enumeration___19_0_3_45f01b9_1580398379726_606068_12802">model.mtconnect.org</seealso>
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.3.0.0")]
	public sealed class EventEnumMetaClass : IEnum
	{
		/// <inheritdoc />
		public string Name => "EventEnum";
		
		/// <inheritdoc />
		public Type DataType => null;
		
		public Type Instance => typeof(EventEnum);

		/// <inheritdoc />
		public string NormativeVersion => "1.0";
		
		/// <inheritdoc />
		public string DeprecatedVersion => "";
		
		/// <inheritdoc />
		public string Summary => @"";
		
		/// <inheritdoc />
		public IEnumInstance[] Values => new IEnumInstance[] {
		ACTIVE_AXES,
		ACTUATOR_STATE,
		ALARM,
		ASSET_CHANGED,
		ASSET_REMOVED,
		AVAILABILITY,
		AXIS_COUPLING,
		AXIS_FEEDRATE_OVERRIDE,
		AXIS_INTERLOCK,
		AXIS_STATE,
		BLOCK,
		BLOCK_COUNT,
		CHUCK_INTERLOCK,
		CHUCK_STATE,
		CODE,
		COMPOSITION_STATE,
		CONTROLLER_MODE,
		CONTROLLER_MODE_OVERRIDE,
		COUPLED_AXES,
		DATE_CODE,
		DEVICE_UUID,
		DIRECTION,
		DOOR_STATE,
		EMERGENCY_STOP,
		END_OF_BAR,
		EQUIPMENT_MODE,
		EXECUTION,
		FUNCTIONAL_MODE,
		HARDNESS,
		LINE,
		LINE_LABEL,
		LINE_NUMBER,
		MATERIAL,
		MATERIAL_LAYER,
		MESSAGE,
		OPERATOR_ID,
		PALLET_ID,
		PART_COUNT,
		PART_DETECT,
		PART_ID,
		PART_NUMBER,
		PATH_FEEDRATE_OVERRIDE,
		PATH_MODE,
		POWER_STATE,
		POWER_STATUS,
		PROCESS_TIME,
		PROGRAM,
		PROGRAM_COMMENT,
		PROGRAM_EDIT,
		PROGRAM_EDIT_NAME,
		PROGRAM_HEADER,
		PROGRAM_LOCATION,
		PROGRAM_LOCATION_TYPE,
		PROGRAM_NEST_LEVEL,
		ROTARY_MODE,
		ROTARY_VELOCITY_OVERRIDE,
		SERIAL_NUMBER,
		SPINDLE_INTERLOCK,
		TOOL_ASSET_ID,
		TOOL_GROUP,
		TOOL_ID,
		TOOL_NUMBER,
		TOOL_OFFSET,
		USER,
		VARIABLE,
		WAIT_STATE,
		WIRE,
		WORKHOLDING_ID,
		WORK_OFFSET,
		OPERATING_SYSTEM,
		FIRMWARE,
		APPLICATION,
		LIBRARY,
		HARDWARE,
		NETWORK,
		ROTATION,
		TRANSLATION,
		DEVICE_ADDED,
		DEVICE_REMOVED,
		DEVICE_CHANGED,
		CONNECTION_STATUS,
		ADAPTER_SOFTWARE_VERSION,
		ADAPTER_URI,
		MTCONNECT_VERSION,
		SENSOR_ATTACHMENT,
		PART_STATUS,
		PROCESS_OCCURRENCE_ID,
		PROCESS_AGGREGATE_ID,
		PROCESS_KIND_ID,
		PART_GROUP_ID,
		PART_KIND_ID,
		PART_UNIQUE_ID,
		CONTROL_LIMIT,
		SPECIFICATION_LIMIT,
		ALARM_LIMIT,
		LOAD_COUNT,
		UNLOAD_COUNT,
		TRANSFER_COUNT,
		ACTIVATION_COUNT,
		DEACTIVATION_COUNT,
		CYCLE_COUNT,
		VALVE_STATE,
		LOCK_STATE,
		PROCESS_STATE,
		PART_PROCESSING_STATE,
		OPERATING_MODE,
		ASSET_COUNT,
		MAINTENANCE_LIST,
		FIXTURE_ID,
		PART_COUNT_TYPE,
		CLOCK_TIME,
		HOST_NAME,
		NETWORK_PORT,
		LEAK_DETECT,
		BATTERY_STATE,
		FEATURE_PERSISTENT_ID,
		SENSOR_STATE,
		COMPONENT_DATA,
		WORK_OFFSETS,
		TOOL_OFFSETS,
		FEATURE_MEASUREMENT,
		CHARACTERISTIC_PERSISTENT_ID,
		MEASUREMENT_TYPE,
		MEASUREMENT_VALUE,
		MEASUREMENT_UNITS,
		CHARACTERISTIC_STATUS,
		UNCERTAINTY_TYPE,
		UNCERTAINTY,
		SPECIFICATION_LIMITS,
		CONTROL_LIMITS,
		ALARM_LIMITS,
		TOOL_CUTTING_ITEM,
		LOCATION_ADDRESS,
		POWER_SOURCE,
		};

		private ACTIVE_AXESValue _ACTIVE_AXES;
		/// <summary>
		/// set of axes currently associated with a <see cref="Path">Path</see> or <see cref="Controller">Controller</see>.
		/// </summary>
		public ACTIVE_AXESValue ACTIVE_AXES => _ACTIVE_AXES ?? (_ACTIVE_AXES = new ACTIVE_AXESValue());

		/// <summary>
		/// set of axes currently associated with a <see cref="Path">Path</see> or <see cref="Controller">Controller</see>.
		/// </summary>
		public sealed class ACTIVE_AXESValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "ACTIVE_AXES";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.1";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// set of axes currently associated with a <see cref=""Path"">Path</see> or <see cref=""Controller"">Controller</see>.";
		}
		private ACTUATOR_STATEValue _ACTUATOR_STATE;
		/// <summary>
		/// operational state of an apparatus for moving or controlling a mechanism or system.
		/// </summary>
		public ACTUATOR_STATEValue ACTUATOR_STATE => _ACTUATOR_STATE ?? (_ACTUATOR_STATE = new ACTUATOR_STATEValue());

		/// <summary>
		/// operational state of an apparatus for moving or controlling a mechanism or system.
		/// </summary>
		public sealed class ACTUATOR_STATEValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "ACTUATOR_STATE";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.2";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// operational state of an apparatus for moving or controlling a mechanism or system.";
		}
		private ALARMValue _ALARM;
		/// <summary>
		/// <b>DEPRECATED:</b> Replaced with <c>CONDITION</c> category data items in Version 1.1.0.
		/// </summary>
		public ALARMValue ALARM => _ALARM ?? (_ALARM = new ALARMValue());

		/// <summary>
		/// <b>DEPRECATED:</b> Replaced with <c>CONDITION</c> category data items in Version 1.1.0.
		/// </summary>
		public sealed class ALARMValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "ALARM";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.0";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "1.1";
			
			/// <inheritdoc />
			public string Summary => @"/// <b>DEPRECATED:</b> Replaced with <c>CONDITION</c> category data items in Version 1.1.0.";
		}
		private ASSET_CHANGEDValue _ASSET_CHANGED;
		/// <summary>
		/// <see cref="assetId">assetId</see> of the <i>Asset</i> that has been added or changed.
		/// </summary>
		public ASSET_CHANGEDValue ASSET_CHANGED => _ASSET_CHANGED ?? (_ASSET_CHANGED = new ASSET_CHANGEDValue());

		/// <summary>
		/// <see cref="assetId">assetId</see> of the <i>Asset</i> that has been added or changed.
		/// </summary>
		public sealed class ASSET_CHANGEDValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "ASSET_CHANGED";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.2";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// <see cref=""assetId"">assetId</see> of the <i>Asset</i> that has been added or changed.";
		}
		private ASSET_REMOVEDValue _ASSET_REMOVED;
		/// <summary>
		/// <see cref="assetId">assetId</see> of the <i>Asset</i> that has been removed.
		/// </summary>
		public ASSET_REMOVEDValue ASSET_REMOVED => _ASSET_REMOVED ?? (_ASSET_REMOVED = new ASSET_REMOVEDValue());

		/// <summary>
		/// <see cref="assetId">assetId</see> of the <i>Asset</i> that has been removed.
		/// </summary>
		public sealed class ASSET_REMOVEDValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "ASSET_REMOVED";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.3";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// <see cref=""assetId"">assetId</see> of the <i>Asset</i> that has been removed.";
		}
		private AVAILABILITYValue _AVAILABILITY;
		/// <summary>
		/// <i>agent</i>'s ability to communicate with the data source.
		/// </summary>
		public AVAILABILITYValue AVAILABILITY => _AVAILABILITY ?? (_AVAILABILITY = new AVAILABILITYValue());

		/// <summary>
		/// <i>agent</i>'s ability to communicate with the data source.
		/// </summary>
		public sealed class AVAILABILITYValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "AVAILABILITY";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.1";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// <i>agent</i>'s ability to communicate with the data source.";
		}
		private AXIS_COUPLINGValue _AXIS_COUPLING;
		/// <summary>
		/// describes the way the axes will be associated to each other.     This is used in conjunction with <c>COUPLED_AXES</c> to indicate the way they are interacting.
		/// </summary>
		public AXIS_COUPLINGValue AXIS_COUPLING => _AXIS_COUPLING ?? (_AXIS_COUPLING = new AXIS_COUPLINGValue());

		/// <summary>
		/// describes the way the axes will be associated to each other.     This is used in conjunction with <c>COUPLED_AXES</c> to indicate the way they are interacting.
		/// </summary>
		public sealed class AXIS_COUPLINGValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "AXIS_COUPLING";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.1";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// describes the way the axes will be associated to each other.     This is used in conjunction with <c>COUPLED_AXES</c> to indicate the way they are interacting.";
		}
		private AXIS_FEEDRATE_OVERRIDEValue _AXIS_FEEDRATE_OVERRIDE;
		/// <summary>
		/// value of a signal or calculation issued to adjust the feedrate of an individual linear type axis.
		/// </summary>
		public AXIS_FEEDRATE_OVERRIDEValue AXIS_FEEDRATE_OVERRIDE => _AXIS_FEEDRATE_OVERRIDE ?? (_AXIS_FEEDRATE_OVERRIDE = new AXIS_FEEDRATE_OVERRIDEValue());

		/// <summary>
		/// value of a signal or calculation issued to adjust the feedrate of an individual linear type axis.
		/// </summary>
		public sealed class AXIS_FEEDRATE_OVERRIDEValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "AXIS_FEEDRATE_OVERRIDE";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.3";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// value of a signal or calculation issued to adjust the feedrate of an individual linear type axis.";
		}
		private AXIS_INTERLOCKValue _AXIS_INTERLOCK;
		/// <summary>
		/// state of the axis lockout function when power has been removed and the axis is allowed to move freely.
		/// </summary>
		public AXIS_INTERLOCKValue AXIS_INTERLOCK => _AXIS_INTERLOCK ?? (_AXIS_INTERLOCK = new AXIS_INTERLOCKValue());

		/// <summary>
		/// state of the axis lockout function when power has been removed and the axis is allowed to move freely.
		/// </summary>
		public sealed class AXIS_INTERLOCKValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "AXIS_INTERLOCK";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.3";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// state of the axis lockout function when power has been removed and the axis is allowed to move freely.";
		}
		private AXIS_STATEValue _AXIS_STATE;
		/// <summary>
		/// state of a <see cref="Linear">Linear</see> or <see cref="Rotary">Rotary</see> component representing an axis.
		/// </summary>
		public AXIS_STATEValue AXIS_STATE => _AXIS_STATE ?? (_AXIS_STATE = new AXIS_STATEValue());

		/// <summary>
		/// state of a <see cref="Linear">Linear</see> or <see cref="Rotary">Rotary</see> component representing an axis.
		/// </summary>
		public sealed class AXIS_STATEValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "AXIS_STATE";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.3";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// state of a <see cref=""Linear"">Linear</see> or <see cref=""Rotary"">Rotary</see> component representing an axis.";
		}
		private BLOCKValue _BLOCK;
		/// <summary>
		/// line of code or command being executed by a <see cref="Controller">Controller</see> entity.
		/// </summary>
		public BLOCKValue BLOCK => _BLOCK ?? (_BLOCK = new BLOCKValue());

		/// <summary>
		/// line of code or command being executed by a <see cref="Controller">Controller</see> entity.
		/// </summary>
		public sealed class BLOCKValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "BLOCK";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.0";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// line of code or command being executed by a <see cref=""Controller"">Controller</see> entity.";
		}
		private BLOCK_COUNTValue _BLOCK_COUNT;
		/// <summary>
		/// total count of the number of blocks of program code that have been executed since execution started.
		/// </summary>
		public BLOCK_COUNTValue BLOCK_COUNT => _BLOCK_COUNT ?? (_BLOCK_COUNT = new BLOCK_COUNTValue());

		/// <summary>
		/// total count of the number of blocks of program code that have been executed since execution started.
		/// </summary>
		public sealed class BLOCK_COUNTValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "BLOCK_COUNT";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.4";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// total count of the number of blocks of program code that have been executed since execution started.";
		}
		private CHUCK_INTERLOCKValue _CHUCK_INTERLOCK;
		/// <summary>
		/// state of an interlock function or control logic state intended to prevent the associated <see cref="Chuck">Chuck</see> component from being operated.
		/// </summary>
		public CHUCK_INTERLOCKValue CHUCK_INTERLOCK => _CHUCK_INTERLOCK ?? (_CHUCK_INTERLOCK = new CHUCK_INTERLOCKValue());

		/// <summary>
		/// state of an interlock function or control logic state intended to prevent the associated <see cref="Chuck">Chuck</see> component from being operated.
		/// </summary>
		public sealed class CHUCK_INTERLOCKValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "CHUCK_INTERLOCK";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.3";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// state of an interlock function or control logic state intended to prevent the associated <see cref=""Chuck"">Chuck</see> component from being operated.";
		}
		private CHUCK_STATEValue _CHUCK_STATE;
		/// <summary>
		/// operating state of a mechanism that holds a part or stock material during a manufacturing process.   It may also represent a mechanism that holds any other mechanism in place within a piece of equipment.
		/// </summary>
		public CHUCK_STATEValue CHUCK_STATE => _CHUCK_STATE ?? (_CHUCK_STATE = new CHUCK_STATEValue());

		/// <summary>
		/// operating state of a mechanism that holds a part or stock material during a manufacturing process.   It may also represent a mechanism that holds any other mechanism in place within a piece of equipment.
		/// </summary>
		public sealed class CHUCK_STATEValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "CHUCK_STATE";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.3";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// operating state of a mechanism that holds a part or stock material during a manufacturing process.   It may also represent a mechanism that holds any other mechanism in place within a piece of equipment.";
		}
		private CODEValue _CODE;
		/// <summary>
		/// programmatic code being executed.  <b>DEPRECATED</b> in <i>Version 1.1</i>s.
		/// </summary>
		public CODEValue CODE => _CODE ?? (_CODE = new CODEValue());

		/// <summary>
		/// programmatic code being executed.  <b>DEPRECATED</b> in <i>Version 1.1</i>s.
		/// </summary>
		public sealed class CODEValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "CODE";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.0";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "1.1";
			
			/// <inheritdoc />
			public string Summary => @"/// programmatic code being executed.  <b>DEPRECATED</b> in <i>Version 1.1</i>s.";
		}
		private COMPOSITION_STATEValue _COMPOSITION_STATE;
		/// <summary>
		/// operating state of a mechanism represented by a <see cref="Composition">Composition</see> entity.
		/// </summary>
		public COMPOSITION_STATEValue COMPOSITION_STATE => _COMPOSITION_STATE ?? (_COMPOSITION_STATE = new COMPOSITION_STATEValue());

		/// <summary>
		/// operating state of a mechanism represented by a <see cref="Composition">Composition</see> entity.
		/// </summary>
		public sealed class COMPOSITION_STATEValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "COMPOSITION_STATE";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.4";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// operating state of a mechanism represented by a <see cref=""Composition"">Composition</see> entity.";
		}
		private CONTROLLER_MODEValue _CONTROLLER_MODE;
		/// <summary>
		/// current mode of the <see cref="Controller">Controller</see> component.
		/// </summary>
		public CONTROLLER_MODEValue CONTROLLER_MODE => _CONTROLLER_MODE ?? (_CONTROLLER_MODE = new CONTROLLER_MODEValue());

		/// <summary>
		/// current mode of the <see cref="Controller">Controller</see> component.
		/// </summary>
		public sealed class CONTROLLER_MODEValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "CONTROLLER_MODE";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.0";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// current mode of the <see cref=""Controller"">Controller</see> component.";
		}
		private CONTROLLER_MODE_OVERRIDEValue _CONTROLLER_MODE_OVERRIDE;
		/// <summary>
		/// setting or operator selection that changes the behavior of a piece of equipment.
		/// </summary>
		public CONTROLLER_MODE_OVERRIDEValue CONTROLLER_MODE_OVERRIDE => _CONTROLLER_MODE_OVERRIDE ?? (_CONTROLLER_MODE_OVERRIDE = new CONTROLLER_MODE_OVERRIDEValue());

		/// <summary>
		/// setting or operator selection that changes the behavior of a piece of equipment.
		/// </summary>
		public sealed class CONTROLLER_MODE_OVERRIDEValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "CONTROLLER_MODE_OVERRIDE";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.4";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// setting or operator selection that changes the behavior of a piece of equipment.";
		}
		private COUPLED_AXESValue _COUPLED_AXES;
		/// <summary>
		/// set of associated axes.
		/// </summary>
		public COUPLED_AXESValue COUPLED_AXES => _COUPLED_AXES ?? (_COUPLED_AXES = new COUPLED_AXESValue());

		/// <summary>
		/// set of associated axes.
		/// </summary>
		public sealed class COUPLED_AXESValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "COUPLED_AXES";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.2";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// set of associated axes.";
		}
		private DATE_CODEValue _DATE_CODE;
		/// <summary>
		/// time and date code associated with a material or other physical item.
		/// </summary>
		public DATE_CODEValue DATE_CODE => _DATE_CODE ?? (_DATE_CODE = new DATE_CODEValue());

		/// <summary>
		/// time and date code associated with a material or other physical item.
		/// </summary>
		public sealed class DATE_CODEValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "DATE_CODE";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.5";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// time and date code associated with a material or other physical item.";
		}
		private DEVICE_UUIDValue _DEVICE_UUID;
		/// <summary>
		/// identifier of another piece of equipment that is temporarily associated with a component of this piece of equipment to perform a particular function.
		/// </summary>
		public DEVICE_UUIDValue DEVICE_UUID => _DEVICE_UUID ?? (_DEVICE_UUID = new DEVICE_UUIDValue());

		/// <summary>
		/// identifier of another piece of equipment that is temporarily associated with a component of this piece of equipment to perform a particular function.
		/// </summary>
		public sealed class DEVICE_UUIDValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "DEVICE_UUID";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.5";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// identifier of another piece of equipment that is temporarily associated with a component of this piece of equipment to perform a particular function.";
		}
		private DIRECTIONValue _DIRECTION;
		/// <summary>
		/// direction of motion.
		/// </summary>
		public DIRECTIONValue DIRECTION => _DIRECTION ?? (_DIRECTION = new DIRECTIONValue());

		/// <summary>
		/// direction of motion.
		/// </summary>
		public sealed class DIRECTIONValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "DIRECTION";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.0";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// direction of motion.";
		}
		private DOOR_STATEValue _DOOR_STATE;
		/// <summary>
		/// operational state of a <see cref="Door">Door</see> component or composition element.
		/// </summary>
		public DOOR_STATEValue DOOR_STATE => _DOOR_STATE ?? (_DOOR_STATE = new DOOR_STATEValue());

		/// <summary>
		/// operational state of a <see cref="Door">Door</see> component or composition element.
		/// </summary>
		public sealed class DOOR_STATEValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "DOOR_STATE";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.1";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// operational state of a <see cref=""Door"">Door</see> component or composition element.";
		}
		private EMERGENCY_STOPValue _EMERGENCY_STOP;
		/// <summary>
		/// state of the emergency stop signal for a piece of equipment, controller path, or any other component or subsystem of a piece of equipment.
		/// </summary>
		public EMERGENCY_STOPValue EMERGENCY_STOP => _EMERGENCY_STOP ?? (_EMERGENCY_STOP = new EMERGENCY_STOPValue());

		/// <summary>
		/// state of the emergency stop signal for a piece of equipment, controller path, or any other component or subsystem of a piece of equipment.
		/// </summary>
		public sealed class EMERGENCY_STOPValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "EMERGENCY_STOP";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.1";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// state of the emergency stop signal for a piece of equipment, controller path, or any other component or subsystem of a piece of equipment.";
		}
		private END_OF_BARValue _END_OF_BAR;
		/// <summary>
		/// indication of whether the end of a piece of bar stock being feed by a bar feeder has been reached.
		/// </summary>
		public END_OF_BARValue END_OF_BAR => _END_OF_BAR ?? (_END_OF_BAR = new END_OF_BARValue());

		/// <summary>
		/// indication of whether the end of a piece of bar stock being feed by a bar feeder has been reached.
		/// </summary>
		public sealed class END_OF_BARValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "END_OF_BAR";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.3";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// indication of whether the end of a piece of bar stock being feed by a bar feeder has been reached.";
		}
		private EQUIPMENT_MODEValue _EQUIPMENT_MODE;
		/// <summary>
		/// indication that a piece of equipment, or a sub-part of a piece of equipment, is performing specific types of activities.
		/// </summary>
		public EQUIPMENT_MODEValue EQUIPMENT_MODE => _EQUIPMENT_MODE ?? (_EQUIPMENT_MODE = new EQUIPMENT_MODEValue());

		/// <summary>
		/// indication that a piece of equipment, or a sub-part of a piece of equipment, is performing specific types of activities.
		/// </summary>
		public sealed class EQUIPMENT_MODEValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "EQUIPMENT_MODE";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.4";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// indication that a piece of equipment, or a sub-part of a piece of equipment, is performing specific types of activities.";
		}
		private EXECUTIONValue _EXECUTION;
		/// <summary>
		/// operating state of a <see cref="Component">Component</see>.
		/// </summary>
		public EXECUTIONValue EXECUTION => _EXECUTION ?? (_EXECUTION = new EXECUTIONValue());

		/// <summary>
		/// operating state of a <see cref="Component">Component</see>.
		/// </summary>
		public sealed class EXECUTIONValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "EXECUTION";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.0";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// operating state of a <see cref=""Component"">Component</see>.";
		}
		private FUNCTIONAL_MODEValue _FUNCTIONAL_MODE;
		/// <summary>
		/// current intended production status of the <see cref="Component">Component</see>.
		/// </summary>
		public FUNCTIONAL_MODEValue FUNCTIONAL_MODE => _FUNCTIONAL_MODE ?? (_FUNCTIONAL_MODE = new FUNCTIONAL_MODEValue());

		/// <summary>
		/// current intended production status of the <see cref="Component">Component</see>.
		/// </summary>
		public sealed class FUNCTIONAL_MODEValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "FUNCTIONAL_MODE";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.3";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// current intended production status of the <see cref=""Component"">Component</see>.";
		}
		private HARDNESSValue _HARDNESS;
		/// <summary>
		/// hardness of a material.
		/// </summary>
		public HARDNESSValue HARDNESS => _HARDNESS ?? (_HARDNESS = new HARDNESSValue());

		/// <summary>
		/// hardness of a material.
		/// </summary>
		public sealed class HARDNESSValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "HARDNESS";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.4";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// hardness of a material.";
		}
		private LINEValue _LINE;
		/// <summary>
		/// current line of code being executed.  <b>DEPRECATED</b> in <i>Version 1.4.0</i>s.
		/// </summary>
		public LINEValue LINE => _LINE ?? (_LINE = new LINEValue());

		/// <summary>
		/// current line of code being executed.  <b>DEPRECATED</b> in <i>Version 1.4.0</i>s.
		/// </summary>
		public sealed class LINEValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "LINE";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.0";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "1.4";
			
			/// <inheritdoc />
			public string Summary => @"/// current line of code being executed.  <b>DEPRECATED</b> in <i>Version 1.4.0</i>s.";
		}
		private LINE_LABELValue _LINE_LABEL;
		/// <summary>
		/// identifier for a <see cref="Block">Block</see> of code in a <see cref="Program">Program</see>.
		/// </summary>
		public LINE_LABELValue LINE_LABEL => _LINE_LABEL ?? (_LINE_LABEL = new LINE_LABELValue());

		/// <summary>
		/// identifier for a <see cref="Block">Block</see> of code in a <see cref="Program">Program</see>.
		/// </summary>
		public sealed class LINE_LABELValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "LINE_LABEL";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.4";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// identifier for a <see cref=""Block"">Block</see> of code in a <see cref=""Program"">Program</see>.";
		}
		private LINE_NUMBERValue _LINE_NUMBER;
		/// <summary>
		/// position of a block of program code within a control program.
		/// </summary>
		public LINE_NUMBERValue LINE_NUMBER => _LINE_NUMBER ?? (_LINE_NUMBER = new LINE_NUMBERValue());

		/// <summary>
		/// position of a block of program code within a control program.
		/// </summary>
		public sealed class LINE_NUMBERValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "LINE_NUMBER";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.4";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// position of a block of program code within a control program.";
		}
		private MATERIALValue _MATERIAL;
		/// <summary>
		/// identifier of a material used or consumed in the manufacturing process.
		/// </summary>
		public MATERIALValue MATERIAL => _MATERIAL ?? (_MATERIAL = new MATERIALValue());

		/// <summary>
		/// identifier of a material used or consumed in the manufacturing process.
		/// </summary>
		public sealed class MATERIALValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "MATERIAL";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.4";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// identifier of a material used or consumed in the manufacturing process.";
		}
		private MATERIAL_LAYERValue _MATERIAL_LAYER;
		/// <summary>
		/// identifies the layers of material applied to a part or product as part of an additive manufacturing process.
		/// </summary>
		public MATERIAL_LAYERValue MATERIAL_LAYER => _MATERIAL_LAYER ?? (_MATERIAL_LAYER = new MATERIAL_LAYERValue());

		/// <summary>
		/// identifies the layers of material applied to a part or product as part of an additive manufacturing process.
		/// </summary>
		public sealed class MATERIAL_LAYERValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "MATERIAL_LAYER";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.5";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// identifies the layers of material applied to a part or product as part of an additive manufacturing process.";
		}
		private MESSAGEValue _MESSAGE;
		/// <summary>
		/// information to be transferred from a piece of equipment to a client software application.
		/// </summary>
		public MESSAGEValue MESSAGE => _MESSAGE ?? (_MESSAGE = new MESSAGEValue());

		/// <summary>
		/// information to be transferred from a piece of equipment to a client software application.
		/// </summary>
		public sealed class MESSAGEValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "MESSAGE";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.1";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// information to be transferred from a piece of equipment to a client software application.";
		}
		private OPERATOR_IDValue _OPERATOR_ID;
		/// <summary>
		/// identifier of the person currently responsible for operating the piece of equipment.
		/// </summary>
		public OPERATOR_IDValue OPERATOR_ID => _OPERATOR_ID ?? (_OPERATOR_ID = new OPERATOR_IDValue());

		/// <summary>
		/// identifier of the person currently responsible for operating the piece of equipment.
		/// </summary>
		public sealed class OPERATOR_IDValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "OPERATOR_ID";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.3";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// identifier of the person currently responsible for operating the piece of equipment.";
		}
		private PALLET_IDValue _PALLET_ID;
		/// <summary>
		/// identifier for a pallet.
		/// </summary>
		public PALLET_IDValue PALLET_ID => _PALLET_ID ?? (_PALLET_ID = new PALLET_IDValue());

		/// <summary>
		/// identifier for a pallet.
		/// </summary>
		public sealed class PALLET_IDValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "PALLET_ID";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.2";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// identifier for a pallet.";
		}
		private PART_COUNTValue _PART_COUNT;
		/// <summary>
		/// aggregate count of parts.
		/// </summary>
		public PART_COUNTValue PART_COUNT => _PART_COUNT ?? (_PART_COUNT = new PART_COUNTValue());

		/// <summary>
		/// aggregate count of parts.
		/// </summary>
		public sealed class PART_COUNTValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "PART_COUNT";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.0";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// aggregate count of parts.";
		}
		private PART_DETECTValue _PART_DETECT;
		/// <summary>
		/// indication designating whether a part or work piece has been detected or is present.
		/// </summary>
		public PART_DETECTValue PART_DETECT => _PART_DETECT ?? (_PART_DETECT = new PART_DETECTValue());

		/// <summary>
		/// indication designating whether a part or work piece has been detected or is present.
		/// </summary>
		public sealed class PART_DETECTValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "PART_DETECT";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.5";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// indication designating whether a part or work piece has been detected or is present.";
		}
		private PART_IDValue _PART_ID;
		/// <summary>
		/// identifier of a part in a manufacturing operation.
		/// </summary>
		public PART_IDValue PART_ID => _PART_ID ?? (_PART_ID = new PART_IDValue());

		/// <summary>
		/// identifier of a part in a manufacturing operation.
		/// </summary>
		public sealed class PART_IDValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "PART_ID";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.1";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// identifier of a part in a manufacturing operation.";
		}
		private PART_NUMBERValue _PART_NUMBER;
		/// <summary>
		/// identifier of a part or product moving through the manufacturing process.  <b>DEPRECATED</b> in <i>Version 1.7</i>s. <c>PART_NUMBER</c> is now a <c>subType</c> of <c>PART_KIND_ID</c>.
		/// </summary>
		public PART_NUMBERValue PART_NUMBER => _PART_NUMBER ?? (_PART_NUMBER = new PART_NUMBERValue());

		/// <summary>
		/// identifier of a part or product moving through the manufacturing process.  <b>DEPRECATED</b> in <i>Version 1.7</i>s. <c>PART_NUMBER</c> is now a <c>subType</c> of <c>PART_KIND_ID</c>.
		/// </summary>
		public sealed class PART_NUMBERValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "PART_NUMBER";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.4";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "1.7";
			
			/// <inheritdoc />
			public string Summary => @"/// identifier of a part or product moving through the manufacturing process.  <b>DEPRECATED</b> in <i>Version 1.7</i>s. <c>PART_NUMBER</c> is now a <c>subType</c> of <c>PART_KIND_ID</c>.";
		}
		private PATH_FEEDRATE_OVERRIDEValue _PATH_FEEDRATE_OVERRIDE;
		/// <summary>
		/// value of a signal or calculation issued to adjust the feedrate for the axes associated with a <see cref="Path">Path</see> component that may represent a single axis or the coordinated movement of multiple axes.
		/// </summary>
		public PATH_FEEDRATE_OVERRIDEValue PATH_FEEDRATE_OVERRIDE => _PATH_FEEDRATE_OVERRIDE ?? (_PATH_FEEDRATE_OVERRIDE = new PATH_FEEDRATE_OVERRIDEValue());

		/// <summary>
		/// value of a signal or calculation issued to adjust the feedrate for the axes associated with a <see cref="Path">Path</see> component that may represent a single axis or the coordinated movement of multiple axes.
		/// </summary>
		public sealed class PATH_FEEDRATE_OVERRIDEValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "PATH_FEEDRATE_OVERRIDE";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.3";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// value of a signal or calculation issued to adjust the feedrate for the axes associated with a <see cref=""Path"">Path</see> component that may represent a single axis or the coordinated movement of multiple axes.";
		}
		private PATH_MODEValue _PATH_MODE;
		/// <summary>
		/// describes the operational relationship between a <see cref="Path">Path</see> entity and another <see cref="Path">Path</see> entity for pieces of equipment comprised of multiple logical groupings of controlled axes or other logical operations.
		/// </summary>
		public PATH_MODEValue PATH_MODE => _PATH_MODE ?? (_PATH_MODE = new PATH_MODEValue());

		/// <summary>
		/// describes the operational relationship between a <see cref="Path">Path</see> entity and another <see cref="Path">Path</see> entity for pieces of equipment comprised of multiple logical groupings of controlled axes or other logical operations.
		/// </summary>
		public sealed class PATH_MODEValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "PATH_MODE";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.1";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// describes the operational relationship between a <see cref=""Path"">Path</see> entity and another <see cref=""Path"">Path</see> entity for pieces of equipment comprised of multiple logical groupings of controlled axes or other logical operations.";
		}
		private POWER_STATEValue _POWER_STATE;
		/// <summary>
		/// indication of the status of the source of energy for an entity to allow it to perform its intended function or the state of an enabling signal providing permission for the entity to perform its functions.
		/// </summary>
		public POWER_STATEValue POWER_STATE => _POWER_STATE ?? (_POWER_STATE = new POWER_STATEValue());

		/// <summary>
		/// indication of the status of the source of energy for an entity to allow it to perform its intended function or the state of an enabling signal providing permission for the entity to perform its functions.
		/// </summary>
		public sealed class POWER_STATEValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "POWER_STATE";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.1";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// indication of the status of the source of energy for an entity to allow it to perform its intended function or the state of an enabling signal providing permission for the entity to perform its functions.";
		}
		private POWER_STATUSValue _POWER_STATUS;
		/// <summary>
		/// status of the <see cref="Component">Component</see>.  <b>DEPRECATED</b> in <i>Version 1.1.0</i>s.
		/// </summary>
		public POWER_STATUSValue POWER_STATUS => _POWER_STATUS ?? (_POWER_STATUS = new POWER_STATUSValue());

		/// <summary>
		/// status of the <see cref="Component">Component</see>.  <b>DEPRECATED</b> in <i>Version 1.1.0</i>s.
		/// </summary>
		public sealed class POWER_STATUSValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "POWER_STATUS";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.0";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "1.1";
			
			/// <inheritdoc />
			public string Summary => @"/// status of the <see cref=""Component"">Component</see>.  <b>DEPRECATED</b> in <i>Version 1.1.0</i>s.";
		}
		private PROCESS_TIMEValue _PROCESS_TIME;
		/// <summary>
		/// time and date associated with an activity or event.
		/// </summary>
		public PROCESS_TIMEValue PROCESS_TIME => _PROCESS_TIME ?? (_PROCESS_TIME = new PROCESS_TIMEValue());

		/// <summary>
		/// time and date associated with an activity or event.
		/// </summary>
		public sealed class PROCESS_TIMEValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "PROCESS_TIME";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.5";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// time and date associated with an activity or event.";
		}
		private PROGRAMValue _PROGRAM;
		/// <summary>
		/// name of the logic or motion program being executed by the <see cref="Controller">Controller</see> component.
		/// </summary>
		public PROGRAMValue PROGRAM => _PROGRAM ?? (_PROGRAM = new PROGRAMValue());

		/// <summary>
		/// name of the logic or motion program being executed by the <see cref="Controller">Controller</see> component.
		/// </summary>
		public sealed class PROGRAMValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "PROGRAM";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.0";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// name of the logic or motion program being executed by the <see cref=""Controller"">Controller</see> component.";
		}
		private PROGRAM_COMMENTValue _PROGRAM_COMMENT;
		/// <summary>
		/// comment or non-executable statement in the control program.
		/// </summary>
		public PROGRAM_COMMENTValue PROGRAM_COMMENT => _PROGRAM_COMMENT ?? (_PROGRAM_COMMENT = new PROGRAM_COMMENTValue());

		/// <summary>
		/// comment or non-executable statement in the control program.
		/// </summary>
		public sealed class PROGRAM_COMMENTValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "PROGRAM_COMMENT";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.3";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// comment or non-executable statement in the control program.";
		}
		private PROGRAM_EDITValue _PROGRAM_EDIT;
		/// <summary>
		/// indication of the status of the <see cref="Controller">Controller</see> components program editing mode.  A program may be edited while another is executed.
		/// </summary>
		public PROGRAM_EDITValue PROGRAM_EDIT => _PROGRAM_EDIT ?? (_PROGRAM_EDIT = new PROGRAM_EDITValue());

		/// <summary>
		/// indication of the status of the <see cref="Controller">Controller</see> components program editing mode.  A program may be edited while another is executed.
		/// </summary>
		public sealed class PROGRAM_EDITValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "PROGRAM_EDIT";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.3";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// indication of the status of the <see cref=""Controller"">Controller</see> components program editing mode.  A program may be edited while another is executed.";
		}
		private PROGRAM_EDIT_NAMEValue _PROGRAM_EDIT_NAME;
		/// <summary>
		/// name of the program being edited.   This is used in conjunction with <see cref="ProgramEdit">ProgramEdit</see> when in <c>ACTIVE</c> state. 
		/// </summary>
		public PROGRAM_EDIT_NAMEValue PROGRAM_EDIT_NAME => _PROGRAM_EDIT_NAME ?? (_PROGRAM_EDIT_NAME = new PROGRAM_EDIT_NAMEValue());

		/// <summary>
		/// name of the program being edited.   This is used in conjunction with <see cref="ProgramEdit">ProgramEdit</see> when in <c>ACTIVE</c> state. 
		/// </summary>
		public sealed class PROGRAM_EDIT_NAMEValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "PROGRAM_EDIT_NAME";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.3";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// name of the program being edited.   This is used in conjunction with <see cref=""ProgramEdit"">ProgramEdit</see> when in <c>ACTIVE</c> state. ";
		}
		private PROGRAM_HEADERValue _PROGRAM_HEADER;
		/// <summary>
		/// non-executable header section of the control program.
		/// </summary>
		public PROGRAM_HEADERValue PROGRAM_HEADER => _PROGRAM_HEADER ?? (_PROGRAM_HEADER = new PROGRAM_HEADERValue());

		/// <summary>
		/// non-executable header section of the control program.
		/// </summary>
		public sealed class PROGRAM_HEADERValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "PROGRAM_HEADER";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.3";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// non-executable header section of the control program.";
		}
		private PROGRAM_LOCATIONValue _PROGRAM_LOCATION;
		/// <summary>
		/// <i>URI</i> for the source file associated with <see cref="Program">Program</see>.
		/// </summary>
		public PROGRAM_LOCATIONValue PROGRAM_LOCATION => _PROGRAM_LOCATION ?? (_PROGRAM_LOCATION = new PROGRAM_LOCATIONValue());

		/// <summary>
		/// <i>URI</i> for the source file associated with <see cref="Program">Program</see>.
		/// </summary>
		public sealed class PROGRAM_LOCATIONValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "PROGRAM_LOCATION";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.5";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// <i>URI</i> for the source file associated with <see cref=""Program"">Program</see>.";
		}
		private PROGRAM_LOCATION_TYPEValue _PROGRAM_LOCATION_TYPE;
		/// <summary>
		/// defines whether the logic or motion program defined by <see cref="Program">Program</see> is being executed from the local memory of the controller or from an outside source.
		/// </summary>
		public PROGRAM_LOCATION_TYPEValue PROGRAM_LOCATION_TYPE => _PROGRAM_LOCATION_TYPE ?? (_PROGRAM_LOCATION_TYPE = new PROGRAM_LOCATION_TYPEValue());

		/// <summary>
		/// defines whether the logic or motion program defined by <see cref="Program">Program</see> is being executed from the local memory of the controller or from an outside source.
		/// </summary>
		public sealed class PROGRAM_LOCATION_TYPEValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "PROGRAM_LOCATION_TYPE";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.5";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// defines whether the logic or motion program defined by <see cref=""Program"">Program</see> is being executed from the local memory of the controller or from an outside source.";
		}
		private PROGRAM_NEST_LEVELValue _PROGRAM_NEST_LEVEL;
		/// <summary>
		/// indication of the nesting level within a control program that is associated with the code or instructions that is currently being executed.
		/// </summary>
		public PROGRAM_NEST_LEVELValue PROGRAM_NEST_LEVEL => _PROGRAM_NEST_LEVEL ?? (_PROGRAM_NEST_LEVEL = new PROGRAM_NEST_LEVELValue());

		/// <summary>
		/// indication of the nesting level within a control program that is associated with the code or instructions that is currently being executed.
		/// </summary>
		public sealed class PROGRAM_NEST_LEVELValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "PROGRAM_NEST_LEVEL";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.5";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// indication of the nesting level within a control program that is associated with the code or instructions that is currently being executed.";
		}
		private ROTARY_MODEValue _ROTARY_MODE;
		/// <summary>
		/// current operating mode for a <see cref="Rotary">Rotary</see> type axis.
		/// </summary>
		public ROTARY_MODEValue ROTARY_MODE => _ROTARY_MODE ?? (_ROTARY_MODE = new ROTARY_MODEValue());

		/// <summary>
		/// current operating mode for a <see cref="Rotary">Rotary</see> type axis.
		/// </summary>
		public sealed class ROTARY_MODEValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "ROTARY_MODE";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.1";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// current operating mode for a <see cref=""Rotary"">Rotary</see> type axis.";
		}
		private ROTARY_VELOCITY_OVERRIDEValue _ROTARY_VELOCITY_OVERRIDE;
		/// <summary>
		/// percentage change to the velocity of the programmed velocity for a <see cref="Rotary">Rotary</see> axis.
		/// </summary>
		public ROTARY_VELOCITY_OVERRIDEValue ROTARY_VELOCITY_OVERRIDE => _ROTARY_VELOCITY_OVERRIDE ?? (_ROTARY_VELOCITY_OVERRIDE = new ROTARY_VELOCITY_OVERRIDEValue());

		/// <summary>
		/// percentage change to the velocity of the programmed velocity for a <see cref="Rotary">Rotary</see> axis.
		/// </summary>
		public sealed class ROTARY_VELOCITY_OVERRIDEValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "ROTARY_VELOCITY_OVERRIDE";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.3";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// percentage change to the velocity of the programmed velocity for a <see cref=""Rotary"">Rotary</see> axis.";
		}
		private SERIAL_NUMBERValue _SERIAL_NUMBER;
		/// <summary>
		/// serial number associated with a <see cref="Component">Component</see>, <see cref="Asset">Asset</see>, or <see cref="Device">Device</see>.
		/// </summary>
		public SERIAL_NUMBERValue SERIAL_NUMBER => _SERIAL_NUMBER ?? (_SERIAL_NUMBER = new SERIAL_NUMBERValue());

		/// <summary>
		/// serial number associated with a <see cref="Component">Component</see>, <see cref="Asset">Asset</see>, or <see cref="Device">Device</see>.
		/// </summary>
		public sealed class SERIAL_NUMBERValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "SERIAL_NUMBER";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.4";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// serial number associated with a <see cref=""Component"">Component</see>, <see cref=""Asset"">Asset</see>, or <see cref=""Device"">Device</see>.";
		}
		private SPINDLE_INTERLOCKValue _SPINDLE_INTERLOCK;
		/// <summary>
		/// indication of the status of the spindle for a piece of equipment when power has been removed and it is free to rotate.
		/// </summary>
		public SPINDLE_INTERLOCKValue SPINDLE_INTERLOCK => _SPINDLE_INTERLOCK ?? (_SPINDLE_INTERLOCK = new SPINDLE_INTERLOCKValue());

		/// <summary>
		/// indication of the status of the spindle for a piece of equipment when power has been removed and it is free to rotate.
		/// </summary>
		public sealed class SPINDLE_INTERLOCKValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "SPINDLE_INTERLOCK";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.3";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// indication of the status of the spindle for a piece of equipment when power has been removed and it is free to rotate.";
		}
		private TOOL_ASSET_IDValue _TOOL_ASSET_ID;
		/// <summary>
		/// identifier of an individual tool asset.
		/// </summary>
		public TOOL_ASSET_IDValue TOOL_ASSET_ID => _TOOL_ASSET_ID ?? (_TOOL_ASSET_ID = new TOOL_ASSET_IDValue());

		/// <summary>
		/// identifier of an individual tool asset.
		/// </summary>
		public sealed class TOOL_ASSET_IDValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "TOOL_ASSET_ID";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.2";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// identifier of an individual tool asset.";
		}
		private TOOL_GROUPValue _TOOL_GROUP;
		/// <summary>
		/// identifier for the tool group associated with a specific tool. Commonly used to designate spare tools.
		/// </summary>
		public TOOL_GROUPValue TOOL_GROUP => _TOOL_GROUP ?? (_TOOL_GROUP = new TOOL_GROUPValue());

		/// <summary>
		/// identifier for the tool group associated with a specific tool. Commonly used to designate spare tools.
		/// </summary>
		public sealed class TOOL_GROUPValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "TOOL_GROUP";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.5";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// identifier for the tool group associated with a specific tool. Commonly used to designate spare tools.";
		}
		private TOOL_IDValue _TOOL_ID;
		/// <summary>
		/// identifier of the tool currently in use for a given <c>Path</c>.  <b>DEPRECATED</b> in <i>Version 1.2.0</i>s.   See <c>TOOL_ASSET_ID</c>.
		/// </summary>
		public TOOL_IDValue TOOL_ID => _TOOL_ID ?? (_TOOL_ID = new TOOL_IDValue());

		/// <summary>
		/// identifier of the tool currently in use for a given <c>Path</c>.  <b>DEPRECATED</b> in <i>Version 1.2.0</i>s.   See <c>TOOL_ASSET_ID</c>.
		/// </summary>
		public sealed class TOOL_IDValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "TOOL_ID";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.1";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "1.2";
			
			/// <inheritdoc />
			public string Summary => @"/// identifier of the tool currently in use for a given <c>Path</c>.  <b>DEPRECATED</b> in <i>Version 1.2.0</i>s.   See <c>TOOL_ASSET_ID</c>.";
		}
		private TOOL_NUMBERValue _TOOL_NUMBER;
		/// <summary>
		/// identifier assigned by the <see cref="Controller">Controller</see> component to a cutting tool when in use by a piece of equipment.
		/// </summary>
		public TOOL_NUMBERValue TOOL_NUMBER => _TOOL_NUMBER ?? (_TOOL_NUMBER = new TOOL_NUMBERValue());

		/// <summary>
		/// identifier assigned by the <see cref="Controller">Controller</see> component to a cutting tool when in use by a piece of equipment.
		/// </summary>
		public sealed class TOOL_NUMBERValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "TOOL_NUMBER";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.2";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// identifier assigned by the <see cref=""Controller"">Controller</see> component to a cutting tool when in use by a piece of equipment.";
		}
		private TOOL_OFFSETValue _TOOL_OFFSET;
		/// <summary>
		/// reference to the tool offset variables applied to the active cutting tool.
		/// </summary>
		public TOOL_OFFSETValue TOOL_OFFSET => _TOOL_OFFSET ?? (_TOOL_OFFSET = new TOOL_OFFSETValue());

		/// <summary>
		/// reference to the tool offset variables applied to the active cutting tool.
		/// </summary>
		public sealed class TOOL_OFFSETValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "TOOL_OFFSET";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.4";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// reference to the tool offset variables applied to the active cutting tool.";
		}
		private USERValue _USER;
		/// <summary>
		/// identifier of the person currently responsible for operating the piece of equipment.
		/// </summary>
		public USERValue USER => _USER ?? (_USER = new USERValue());

		/// <summary>
		/// identifier of the person currently responsible for operating the piece of equipment.
		/// </summary>
		public sealed class USERValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "USER";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.4";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// identifier of the person currently responsible for operating the piece of equipment.";
		}
		private VARIABLEValue _VARIABLE;
		/// <summary>
		/// data whose meaning may change over time due to changes in the operation of a piece of equipment or the process being executed on that piece of equipment.
		/// </summary>
		public VARIABLEValue VARIABLE => _VARIABLE ?? (_VARIABLE = new VARIABLEValue());

		/// <summary>
		/// data whose meaning may change over time due to changes in the operation of a piece of equipment or the process being executed on that piece of equipment.
		/// </summary>
		public sealed class VARIABLEValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "VARIABLE";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.5";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// data whose meaning may change over time due to changes in the operation of a piece of equipment or the process being executed on that piece of equipment.";
		}
		private WAIT_STATEValue _WAIT_STATE;
		/// <summary>
		/// indication of the reason that <see cref="Execution">Execution</see> is reporting a value of <c>WAIT</c>.
		/// </summary>
		public WAIT_STATEValue WAIT_STATE => _WAIT_STATE ?? (_WAIT_STATE = new WAIT_STATEValue());

		/// <summary>
		/// indication of the reason that <see cref="Execution">Execution</see> is reporting a value of <c>WAIT</c>.
		/// </summary>
		public sealed class WAIT_STATEValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "WAIT_STATE";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.5";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// indication of the reason that <see cref=""Execution"">Execution</see> is reporting a value of <c>WAIT</c>.";
		}
		private WIREValue _WIRE;
		/// <summary>
		/// identifier for the type of wire used as the cutting mechanism in Electrical Discharge Machining or similar processes.
		/// </summary>
		public WIREValue WIRE => _WIRE ?? (_WIRE = new WIREValue());

		/// <summary>
		/// identifier for the type of wire used as the cutting mechanism in Electrical Discharge Machining or similar processes.
		/// </summary>
		public sealed class WIREValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "WIRE";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.4";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// identifier for the type of wire used as the cutting mechanism in Electrical Discharge Machining or similar processes.";
		}
		private WORKHOLDING_IDValue _WORKHOLDING_ID;
		/// <summary>
		/// identifier for the current workholding or part clamp in use by a piece of equipment.  <b>DEPRECATION WARNING</b>: Recommend using <c>FIXTURE_ID</c> instead.
		/// </summary>
		public WORKHOLDING_IDValue WORKHOLDING_ID => _WORKHOLDING_ID ?? (_WORKHOLDING_ID = new WORKHOLDING_IDValue());

		/// <summary>
		/// identifier for the current workholding or part clamp in use by a piece of equipment.  <b>DEPRECATION WARNING</b>: Recommend using <c>FIXTURE_ID</c> instead.
		/// </summary>
		public sealed class WORKHOLDING_IDValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "WORKHOLDING_ID";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.1";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// identifier for the current workholding or part clamp in use by a piece of equipment.  <b>DEPRECATION WARNING</b>: Recommend using <c>FIXTURE_ID</c> instead.";
		}
		private WORK_OFFSETValue _WORK_OFFSET;
		/// <summary>
		/// reference to offset variables for a work piece or part.
		/// </summary>
		public WORK_OFFSETValue WORK_OFFSET => _WORK_OFFSET ?? (_WORK_OFFSET = new WORK_OFFSETValue());

		/// <summary>
		/// reference to offset variables for a work piece or part.
		/// </summary>
		public sealed class WORK_OFFSETValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "WORK_OFFSET";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.4";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// reference to offset variables for a work piece or part.";
		}
		private OPERATING_SYSTEMValue _OPERATING_SYSTEM;
		/// <summary>
		/// Operating System (OS) of a <see cref="Component">Component</see>.
		/// </summary>
		public OPERATING_SYSTEMValue OPERATING_SYSTEM => _OPERATING_SYSTEM ?? (_OPERATING_SYSTEM = new OPERATING_SYSTEMValue());

		/// <summary>
		/// Operating System (OS) of a <see cref="Component">Component</see>.
		/// </summary>
		public sealed class OPERATING_SYSTEMValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "OPERATING_SYSTEM";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.6";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// Operating System (OS) of a <see cref=""Component"">Component</see>.";
		}
		private FIRMWAREValue _FIRMWARE;
		/// <summary>
		/// embedded software of a <see cref="Component">Component</see> .
		/// </summary>
		public FIRMWAREValue FIRMWARE => _FIRMWARE ?? (_FIRMWARE = new FIRMWAREValue());

		/// <summary>
		/// embedded software of a <see cref="Component">Component</see> .
		/// </summary>
		public sealed class FIRMWAREValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "FIRMWARE";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.6";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// embedded software of a <see cref=""Component"">Component</see> .";
		}
		private APPLICATIONValue _APPLICATION;
		/// <summary>
		/// application on a <see cref="Component">Component</see>.
		/// </summary>
		public APPLICATIONValue APPLICATION => _APPLICATION ?? (_APPLICATION = new APPLICATIONValue());

		/// <summary>
		/// application on a <see cref="Component">Component</see>.
		/// </summary>
		public sealed class APPLICATIONValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "APPLICATION";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.6";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// application on a <see cref=""Component"">Component</see>.";
		}
		private LIBRARYValue _LIBRARY;
		/// <summary>
		/// software library on a <see cref="Component">Component</see>
		/// </summary>
		public LIBRARYValue LIBRARY => _LIBRARY ?? (_LIBRARY = new LIBRARYValue());

		/// <summary>
		/// software library on a <see cref="Component">Component</see>
		/// </summary>
		public sealed class LIBRARYValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "LIBRARY";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.6";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// software library on a <see cref=""Component"">Component</see>";
		}
		private HARDWAREValue _HARDWARE;
		/// <summary>
		/// hardware of a <see cref="Component">Component</see>.
		/// </summary>
		public HARDWAREValue HARDWARE => _HARDWARE ?? (_HARDWARE = new HARDWAREValue());

		/// <summary>
		/// hardware of a <see cref="Component">Component</see>.
		/// </summary>
		public sealed class HARDWAREValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "HARDWARE";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.6";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// hardware of a <see cref=""Component"">Component</see>.";
		}
		private NETWORKValue _NETWORK;
		/// <summary>
		/// network details of a <see cref="Component">Component</see>.
		/// </summary>
		public NETWORKValue NETWORK => _NETWORK ?? (_NETWORK = new NETWORKValue());

		/// <summary>
		/// network details of a <see cref="Component">Component</see>.
		/// </summary>
		public sealed class NETWORKValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "NETWORK";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.6";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// network details of a <see cref=""Component"">Component</see>.";
		}
		private ROTATIONValue _ROTATION;
		/// <summary>
		/// three space angular displacement of an object or coordinate system relative to a <i>cartesian coordinate system</i>.
		/// </summary>
		public ROTATIONValue ROTATION => _ROTATION ?? (_ROTATION = new ROTATIONValue());

		/// <summary>
		/// three space angular displacement of an object or coordinate system relative to a <i>cartesian coordinate system</i>.
		/// </summary>
		public sealed class ROTATIONValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "ROTATION";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.6";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// three space angular displacement of an object or coordinate system relative to a <i>cartesian coordinate system</i>.";
		}
		private TRANSLATIONValue _TRANSLATION;
		/// <summary>
		/// three space linear displacement of an object or coordinate system relative to a <i>cartesian coordinate system</i>.
		/// </summary>
		public TRANSLATIONValue TRANSLATION => _TRANSLATION ?? (_TRANSLATION = new TRANSLATIONValue());

		/// <summary>
		/// three space linear displacement of an object or coordinate system relative to a <i>cartesian coordinate system</i>.
		/// </summary>
		public sealed class TRANSLATIONValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "TRANSLATION";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.6";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// three space linear displacement of an object or coordinate system relative to a <i>cartesian coordinate system</i>.";
		}
		private DEVICE_ADDEDValue _DEVICE_ADDED;
		/// <summary>
		/// <i>UUID</i> of new device added to an <i>MTConnect Agent</i>.
		/// </summary>
		public DEVICE_ADDEDValue DEVICE_ADDED => _DEVICE_ADDED ?? (_DEVICE_ADDED = new DEVICE_ADDEDValue());

		/// <summary>
		/// <i>UUID</i> of new device added to an <i>MTConnect Agent</i>.
		/// </summary>
		public sealed class DEVICE_ADDEDValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "DEVICE_ADDED";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.7";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// <i>UUID</i> of new device added to an <i>MTConnect Agent</i>.";
		}
		private DEVICE_REMOVEDValue _DEVICE_REMOVED;
		/// <summary>
		/// <i>UUID</i> of a device removed from an <i>MTConnect Agent</i>.
		/// </summary>
		public DEVICE_REMOVEDValue DEVICE_REMOVED => _DEVICE_REMOVED ?? (_DEVICE_REMOVED = new DEVICE_REMOVEDValue());

		/// <summary>
		/// <i>UUID</i> of a device removed from an <i>MTConnect Agent</i>.
		/// </summary>
		public sealed class DEVICE_REMOVEDValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "DEVICE_REMOVED";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.7";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// <i>UUID</i> of a device removed from an <i>MTConnect Agent</i>.";
		}
		private DEVICE_CHANGEDValue _DEVICE_CHANGED;
		/// <summary>
		/// <i>UUID</i> of the device whose <i>metadata</i> has changed.
		/// </summary>
		public DEVICE_CHANGEDValue DEVICE_CHANGED => _DEVICE_CHANGED ?? (_DEVICE_CHANGED = new DEVICE_CHANGEDValue());

		/// <summary>
		/// <i>UUID</i> of the device whose <i>metadata</i> has changed.
		/// </summary>
		public sealed class DEVICE_CHANGEDValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "DEVICE_CHANGED";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.7";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// <i>UUID</i> of the device whose <i>metadata</i> has changed.";
		}
		private CONNECTION_STATUSValue _CONNECTION_STATUS;
		/// <summary>
		/// status of the connection between an <i>adapter</i> and an <i>agent</i>.
		/// </summary>
		public CONNECTION_STATUSValue CONNECTION_STATUS => _CONNECTION_STATUS ?? (_CONNECTION_STATUS = new CONNECTION_STATUSValue());

		/// <summary>
		/// status of the connection between an <i>adapter</i> and an <i>agent</i>.
		/// </summary>
		public sealed class CONNECTION_STATUSValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "CONNECTION_STATUS";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.7";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// status of the connection between an <i>adapter</i> and an <i>agent</i>.";
		}
		private ADAPTER_SOFTWARE_VERSIONValue _ADAPTER_SOFTWARE_VERSION;
		/// <summary>
		/// originator’s software version of the <i>adapter</i>.
		/// </summary>
		public ADAPTER_SOFTWARE_VERSIONValue ADAPTER_SOFTWARE_VERSION => _ADAPTER_SOFTWARE_VERSION ?? (_ADAPTER_SOFTWARE_VERSION = new ADAPTER_SOFTWARE_VERSIONValue());

		/// <summary>
		/// originator’s software version of the <i>adapter</i>.
		/// </summary>
		public sealed class ADAPTER_SOFTWARE_VERSIONValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "ADAPTER_SOFTWARE_VERSION";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.7";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// originator’s software version of the <i>adapter</i>.";
		}
		private ADAPTER_URIValue _ADAPTER_URI;
		/// <summary>
		/// <i>URI</i> of the <i>adapter</i>.
		/// </summary>
		public ADAPTER_URIValue ADAPTER_URI => _ADAPTER_URI ?? (_ADAPTER_URI = new ADAPTER_URIValue());

		/// <summary>
		/// <i>URI</i> of the <i>adapter</i>.
		/// </summary>
		public sealed class ADAPTER_URIValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "ADAPTER_URI";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.7";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// <i>URI</i> of the <i>adapter</i>.";
		}
		private MTCONNECT_VERSIONValue _MTCONNECT_VERSION;
		/// <summary>
		/// reference version of the MTConnect Standard supported by the <i>adapter</i>.
		/// </summary>
		public MTCONNECT_VERSIONValue MTCONNECT_VERSION => _MTCONNECT_VERSION ?? (_MTCONNECT_VERSION = new MTCONNECT_VERSIONValue());

		/// <summary>
		/// reference version of the MTConnect Standard supported by the <i>adapter</i>.
		/// </summary>
		public sealed class MTCONNECT_VERSIONValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "MTCONNECT_VERSION";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.7";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// reference version of the MTConnect Standard supported by the <i>adapter</i>.";
		}
		private SENSOR_ATTACHMENTValue _SENSOR_ATTACHMENT;
		/// <summary>
		/// <i>attachment</i> between a sensor and an entity.
		/// </summary>
		public SENSOR_ATTACHMENTValue SENSOR_ATTACHMENT => _SENSOR_ATTACHMENT ?? (_SENSOR_ATTACHMENT = new SENSOR_ATTACHMENTValue());

		/// <summary>
		/// <i>attachment</i> between a sensor and an entity.
		/// </summary>
		public sealed class SENSOR_ATTACHMENTValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "SENSOR_ATTACHMENT";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.7";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// <i>attachment</i> between a sensor and an entity.";
		}
		private PART_STATUSValue _PART_STATUS;
		/// <summary>
		/// state or condition of a part.
		/// </summary>
		public PART_STATUSValue PART_STATUS => _PART_STATUS ?? (_PART_STATUS = new PART_STATUSValue());

		/// <summary>
		/// state or condition of a part.
		/// </summary>
		public sealed class PART_STATUSValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "PART_STATUS";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.7";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// state or condition of a part.";
		}
		private PROCESS_OCCURRENCE_IDValue _PROCESS_OCCURRENCE_ID;
		/// <summary>
		/// identifier of a process being executed by the device.
		/// </summary>
		public PROCESS_OCCURRENCE_IDValue PROCESS_OCCURRENCE_ID => _PROCESS_OCCURRENCE_ID ?? (_PROCESS_OCCURRENCE_ID = new PROCESS_OCCURRENCE_IDValue());

		/// <summary>
		/// identifier of a process being executed by the device.
		/// </summary>
		public sealed class PROCESS_OCCURRENCE_IDValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "PROCESS_OCCURRENCE_ID";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.7";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// identifier of a process being executed by the device.";
		}
		private PROCESS_AGGREGATE_IDValue _PROCESS_AGGREGATE_ID;
		/// <summary>
		/// identifier given to link the individual occurrence to a group of related occurrences, such as a process step in a process plan.
		/// </summary>
		public PROCESS_AGGREGATE_IDValue PROCESS_AGGREGATE_ID => _PROCESS_AGGREGATE_ID ?? (_PROCESS_AGGREGATE_ID = new PROCESS_AGGREGATE_IDValue());

		/// <summary>
		/// identifier given to link the individual occurrence to a group of related occurrences, such as a process step in a process plan.
		/// </summary>
		public sealed class PROCESS_AGGREGATE_IDValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "PROCESS_AGGREGATE_ID";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.7";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// identifier given to link the individual occurrence to a group of related occurrences, such as a process step in a process plan.";
		}
		private PROCESS_KIND_IDValue _PROCESS_KIND_ID;
		/// <summary>
		/// identifier given to link the individual occurrence to a class of processes or process definition. 
		/// </summary>
		public PROCESS_KIND_IDValue PROCESS_KIND_ID => _PROCESS_KIND_ID ?? (_PROCESS_KIND_ID = new PROCESS_KIND_IDValue());

		/// <summary>
		/// identifier given to link the individual occurrence to a class of processes or process definition. 
		/// </summary>
		public sealed class PROCESS_KIND_IDValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "PROCESS_KIND_ID";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.7";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// identifier given to link the individual occurrence to a class of processes or process definition. ";
		}
		private PART_GROUP_IDValue _PART_GROUP_ID;
		/// <summary>
		/// identifier given to a collection of individual parts. 
		/// </summary>
		public PART_GROUP_IDValue PART_GROUP_ID => _PART_GROUP_ID ?? (_PART_GROUP_ID = new PART_GROUP_IDValue());

		/// <summary>
		/// identifier given to a collection of individual parts. 
		/// </summary>
		public sealed class PART_GROUP_IDValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "PART_GROUP_ID";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.7";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// identifier given to a collection of individual parts. ";
		}
		private PART_KIND_IDValue _PART_KIND_ID;
		/// <summary>
		/// identifier given to link the individual occurrence to a class of parts, typically distinguished by a particular part design.
		/// </summary>
		public PART_KIND_IDValue PART_KIND_ID => _PART_KIND_ID ?? (_PART_KIND_ID = new PART_KIND_IDValue());

		/// <summary>
		/// identifier given to link the individual occurrence to a class of parts, typically distinguished by a particular part design.
		/// </summary>
		public sealed class PART_KIND_IDValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "PART_KIND_ID";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.7";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// identifier given to link the individual occurrence to a class of parts, typically distinguished by a particular part design.";
		}
		private PART_UNIQUE_IDValue _PART_UNIQUE_ID;
		/// <summary>
		/// identifier given to a distinguishable, individual part. 
		/// </summary>
		public PART_UNIQUE_IDValue PART_UNIQUE_ID => _PART_UNIQUE_ID ?? (_PART_UNIQUE_ID = new PART_UNIQUE_IDValue());

		/// <summary>
		/// identifier given to a distinguishable, individual part. 
		/// </summary>
		public sealed class PART_UNIQUE_IDValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "PART_UNIQUE_ID";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.7";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// identifier given to a distinguishable, individual part. ";
		}
		private CONTROL_LIMITValue _CONTROL_LIMIT;
		/// <summary>
		/// set of limits used to indicate whether a process variable is stable and in control.  <b>DEPRECATION WARNING</b>. Recommend using <c>CONTROL_LIMITS</c>.
		/// </summary>
		public CONTROL_LIMITValue CONTROL_LIMIT => _CONTROL_LIMIT ?? (_CONTROL_LIMIT = new CONTROL_LIMITValue());

		/// <summary>
		/// set of limits used to indicate whether a process variable is stable and in control.  <b>DEPRECATION WARNING</b>. Recommend using <c>CONTROL_LIMITS</c>.
		/// </summary>
		public sealed class CONTROL_LIMITValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "CONTROL_LIMIT";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.7";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// set of limits used to indicate whether a process variable is stable and in control.  <b>DEPRECATION WARNING</b>. Recommend using <c>CONTROL_LIMITS</c>.";
		}
		private SPECIFICATION_LIMITValue _SPECIFICATION_LIMIT;
		/// <summary>
		/// set of limits defining a range of values designating acceptable performance for a variable.  <b>DEPRECATION WARNING</b>. Recommend using <c>SPECIFICATION_LIMITS</c>.
		/// </summary>
		public SPECIFICATION_LIMITValue SPECIFICATION_LIMIT => _SPECIFICATION_LIMIT ?? (_SPECIFICATION_LIMIT = new SPECIFICATION_LIMITValue());

		/// <summary>
		/// set of limits defining a range of values designating acceptable performance for a variable.  <b>DEPRECATION WARNING</b>. Recommend using <c>SPECIFICATION_LIMITS</c>.
		/// </summary>
		public sealed class SPECIFICATION_LIMITValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "SPECIFICATION_LIMIT";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.7";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// set of limits defining a range of values designating acceptable performance for a variable.  <b>DEPRECATION WARNING</b>. Recommend using <c>SPECIFICATION_LIMITS</c>.";
		}
		private ALARM_LIMITValue _ALARM_LIMIT;
		/// <summary>
		/// set of limits used to trigger warning or alarm indicators.  <b>DEPRECATION WARNING</b>. Recommend using <c>ALARM_LIMITS</c>.
		/// </summary>
		public ALARM_LIMITValue ALARM_LIMIT => _ALARM_LIMIT ?? (_ALARM_LIMIT = new ALARM_LIMITValue());

		/// <summary>
		/// set of limits used to trigger warning or alarm indicators.  <b>DEPRECATION WARNING</b>. Recommend using <c>ALARM_LIMITS</c>.
		/// </summary>
		public sealed class ALARM_LIMITValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "ALARM_LIMIT";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.7";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// set of limits used to trigger warning or alarm indicators.  <b>DEPRECATION WARNING</b>. Recommend using <c>ALARM_LIMITS</c>.";
		}
		private LOAD_COUNTValue _LOAD_COUNT;
		/// <summary>
		/// accumulation of the number of times an operation has attempted to, or is planned to attempt to, load materials, parts, or other items.
		/// </summary>
		public LOAD_COUNTValue LOAD_COUNT => _LOAD_COUNT ?? (_LOAD_COUNT = new LOAD_COUNTValue());

		/// <summary>
		/// accumulation of the number of times an operation has attempted to, or is planned to attempt to, load materials, parts, or other items.
		/// </summary>
		public sealed class LOAD_COUNTValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "LOAD_COUNT";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.8";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// accumulation of the number of times an operation has attempted to, or is planned to attempt to, load materials, parts, or other items.";
		}
		private UNLOAD_COUNTValue _UNLOAD_COUNT;
		/// <summary>
		/// accumulation of the number of times an operation has attempted to, or is planned to attempt to, unload materials, parts, or other items.
		/// </summary>
		public UNLOAD_COUNTValue UNLOAD_COUNT => _UNLOAD_COUNT ?? (_UNLOAD_COUNT = new UNLOAD_COUNTValue());

		/// <summary>
		/// accumulation of the number of times an operation has attempted to, or is planned to attempt to, unload materials, parts, or other items.
		/// </summary>
		public sealed class UNLOAD_COUNTValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "UNLOAD_COUNT";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.8";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// accumulation of the number of times an operation has attempted to, or is planned to attempt to, unload materials, parts, or other items.";
		}
		private TRANSFER_COUNTValue _TRANSFER_COUNT;
		/// <summary>
		/// accumulation of the number of times an operation has attempted to, or is planned to attempt to, transfer materials, parts, or other items from one location to another.
		/// </summary>
		public TRANSFER_COUNTValue TRANSFER_COUNT => _TRANSFER_COUNT ?? (_TRANSFER_COUNT = new TRANSFER_COUNTValue());

		/// <summary>
		/// accumulation of the number of times an operation has attempted to, or is planned to attempt to, transfer materials, parts, or other items from one location to another.
		/// </summary>
		public sealed class TRANSFER_COUNTValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "TRANSFER_COUNT";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.8";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// accumulation of the number of times an operation has attempted to, or is planned to attempt to, transfer materials, parts, or other items from one location to another.";
		}
		private ACTIVATION_COUNTValue _ACTIVATION_COUNT;
		/// <summary>
		/// accumulation of the number of times a function has attempted to, or is planned to attempt to, activate or be performed.
		/// </summary>
		public ACTIVATION_COUNTValue ACTIVATION_COUNT => _ACTIVATION_COUNT ?? (_ACTIVATION_COUNT = new ACTIVATION_COUNTValue());

		/// <summary>
		/// accumulation of the number of times a function has attempted to, or is planned to attempt to, activate or be performed.
		/// </summary>
		public sealed class ACTIVATION_COUNTValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "ACTIVATION_COUNT";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.8";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// accumulation of the number of times a function has attempted to, or is planned to attempt to, activate or be performed.";
		}
		private DEACTIVATION_COUNTValue _DEACTIVATION_COUNT;
		/// <summary>
		/// accumulation of the number of times a function has attempted to, or is planned to attempt to, deactivate or cease.
		/// </summary>
		public DEACTIVATION_COUNTValue DEACTIVATION_COUNT => _DEACTIVATION_COUNT ?? (_DEACTIVATION_COUNT = new DEACTIVATION_COUNTValue());

		/// <summary>
		/// accumulation of the number of times a function has attempted to, or is planned to attempt to, deactivate or cease.
		/// </summary>
		public sealed class DEACTIVATION_COUNTValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "DEACTIVATION_COUNT";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.8";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// accumulation of the number of times a function has attempted to, or is planned to attempt to, deactivate or cease.";
		}
		private CYCLE_COUNTValue _CYCLE_COUNT;
		/// <summary>
		/// accumulation of the number of times a cyclic function has attempted to, or is planned to attempt to execute.
		/// </summary>
		public CYCLE_COUNTValue CYCLE_COUNT => _CYCLE_COUNT ?? (_CYCLE_COUNT = new CYCLE_COUNTValue());

		/// <summary>
		/// accumulation of the number of times a cyclic function has attempted to, or is planned to attempt to execute.
		/// </summary>
		public sealed class CYCLE_COUNTValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "CYCLE_COUNT";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.8";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// accumulation of the number of times a cyclic function has attempted to, or is planned to attempt to execute.";
		}
		private VALVE_STATEValue _VALVE_STATE;
		/// <summary>
		/// state of a valve is one of open, closed, or transitioning between the states.
		/// </summary>
		public VALVE_STATEValue VALVE_STATE => _VALVE_STATE ?? (_VALVE_STATE = new VALVE_STATEValue());

		/// <summary>
		/// state of a valve is one of open, closed, or transitioning between the states.
		/// </summary>
		public sealed class VALVE_STATEValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "VALVE_STATE";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.8";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// state of a valve is one of open, closed, or transitioning between the states.";
		}
		private LOCK_STATEValue _LOCK_STATE;
		/// <summary>
		/// state or operating mode of a <see cref="Lock">Lock</see>.
		/// </summary>
		public LOCK_STATEValue LOCK_STATE => _LOCK_STATE ?? (_LOCK_STATE = new LOCK_STATEValue());

		/// <summary>
		/// state or operating mode of a <see cref="Lock">Lock</see>.
		/// </summary>
		public sealed class LOCK_STATEValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "LOCK_STATE";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.8";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// state or operating mode of a <see cref=""Lock"">Lock</see>.";
		}
		private PROCESS_STATEValue _PROCESS_STATE;
		/// <summary>
		/// particular condition of the process occurrence at a specific time.
		/// </summary>
		public PROCESS_STATEValue PROCESS_STATE => _PROCESS_STATE ?? (_PROCESS_STATE = new PROCESS_STATEValue());

		/// <summary>
		/// particular condition of the process occurrence at a specific time.
		/// </summary>
		public sealed class PROCESS_STATEValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "PROCESS_STATE";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.8";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// particular condition of the process occurrence at a specific time.";
		}
		private PART_PROCESSING_STATEValue _PART_PROCESSING_STATE;
		/// <summary>
		/// particular condition of the part occurrence at a specific time.
		/// </summary>
		public PART_PROCESSING_STATEValue PART_PROCESSING_STATE => _PART_PROCESSING_STATE ?? (_PART_PROCESSING_STATE = new PART_PROCESSING_STATEValue());

		/// <summary>
		/// particular condition of the part occurrence at a specific time.
		/// </summary>
		public sealed class PART_PROCESSING_STATEValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "PART_PROCESSING_STATE";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.8";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// particular condition of the part occurrence at a specific time.";
		}
		private OPERATING_MODEValue _OPERATING_MODE;
		/// <summary>
		/// state of <see cref="Component">Component</see> or <see cref="Composition">Composition</see> that describes the automatic or manual operation of the entity.
		/// </summary>
		public OPERATING_MODEValue OPERATING_MODE => _OPERATING_MODE ?? (_OPERATING_MODE = new OPERATING_MODEValue());

		/// <summary>
		/// state of <see cref="Component">Component</see> or <see cref="Composition">Composition</see> that describes the automatic or manual operation of the entity.
		/// </summary>
		public sealed class OPERATING_MODEValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "OPERATING_MODE";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "2.0";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// state of <see cref=""Component"">Component</see> or <see cref=""Composition"">Composition</see> that describes the automatic or manual operation of the entity.";
		}
		private ASSET_COUNTValue _ASSET_COUNT;
		/// <summary>
		/// <i>data set</i> of the number of <i>Asset</i>s of a given type for a <i>Device</i>.
		/// </summary>
		public ASSET_COUNTValue ASSET_COUNT => _ASSET_COUNT ?? (_ASSET_COUNT = new ASSET_COUNTValue());

		/// <summary>
		/// <i>data set</i> of the number of <i>Asset</i>s of a given type for a <i>Device</i>.
		/// </summary>
		public sealed class ASSET_COUNTValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "ASSET_COUNT";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "2.0";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// <i>data set</i> of the number of <i>Asset</i>s of a given type for a <i>Device</i>.";
		}
		private MAINTENANCE_LISTValue _MAINTENANCE_LIST;
		/// <summary>
		/// actions or activities to be performed in support of a piece of equipment.
		/// </summary>
		public MAINTENANCE_LISTValue MAINTENANCE_LIST => _MAINTENANCE_LIST ?? (_MAINTENANCE_LIST = new MAINTENANCE_LISTValue());

		/// <summary>
		/// actions or activities to be performed in support of a piece of equipment.
		/// </summary>
		public sealed class MAINTENANCE_LISTValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "MAINTENANCE_LIST";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "2.0";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// actions or activities to be performed in support of a piece of equipment.";
		}
		private FIXTURE_IDValue _FIXTURE_ID;
		/// <summary>
		/// identifier for the current workholding or part clamp in use by a piece of equipment.
		/// </summary>
		public FIXTURE_IDValue FIXTURE_ID => _FIXTURE_ID ?? (_FIXTURE_ID = new FIXTURE_IDValue());

		/// <summary>
		/// identifier for the current workholding or part clamp in use by a piece of equipment.
		/// </summary>
		public sealed class FIXTURE_IDValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "FIXTURE_ID";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "2.0";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// identifier for the current workholding or part clamp in use by a piece of equipment.";
		}
		private PART_COUNT_TYPEValue _PART_COUNT_TYPE;
		/// <summary>
		/// interpretation of <c>PART_COUNT</c>.
		/// </summary>
		public PART_COUNT_TYPEValue PART_COUNT_TYPE => _PART_COUNT_TYPE ?? (_PART_COUNT_TYPE = new PART_COUNT_TYPEValue());

		/// <summary>
		/// interpretation of <c>PART_COUNT</c>.
		/// </summary>
		public sealed class PART_COUNT_TYPEValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "PART_COUNT_TYPE";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "2.0";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// interpretation of <c>PART_COUNT</c>.";
		}
		private CLOCK_TIMEValue _CLOCK_TIME;
		/// <summary>
		/// time provided by a timing device at a specific point in time.
		/// </summary>
		public CLOCK_TIMEValue CLOCK_TIME => _CLOCK_TIME ?? (_CLOCK_TIME = new CLOCK_TIMEValue());

		/// <summary>
		/// time provided by a timing device at a specific point in time.
		/// </summary>
		public sealed class CLOCK_TIMEValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "CLOCK_TIME";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.2";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// time provided by a timing device at a specific point in time.";
		}
		private HOST_NAMEValue _HOST_NAME;
		/// <summary>
		/// name of the host computer supplying data.
		/// </summary>
		public HOST_NAMEValue HOST_NAME => _HOST_NAME ?? (_HOST_NAME = new HOST_NAMEValue());

		/// <summary>
		/// name of the host computer supplying data.
		/// </summary>
		public sealed class HOST_NAMEValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "HOST_NAME";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "2.1";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// name of the host computer supplying data.";
		}
		private NETWORK_PORTValue _NETWORK_PORT;
		/// <summary>
		/// number of the TCP/IP or UDP/IP port for the connection endpoint.
		/// </summary>
		public NETWORK_PORTValue NETWORK_PORT => _NETWORK_PORT ?? (_NETWORK_PORT = new NETWORK_PORTValue());

		/// <summary>
		/// number of the TCP/IP or UDP/IP port for the connection endpoint.
		/// </summary>
		public sealed class NETWORK_PORTValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "NETWORK_PORT";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "2.1";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// number of the TCP/IP or UDP/IP port for the connection endpoint.";
		}
		private LEAK_DETECTValue _LEAK_DETECT;
		/// <summary>
		/// indication designating whether a leak has been detected.
		/// </summary>
		public LEAK_DETECTValue LEAK_DETECT => _LEAK_DETECT ?? (_LEAK_DETECT = new LEAK_DETECTValue());

		/// <summary>
		/// indication designating whether a leak has been detected.
		/// </summary>
		public sealed class LEAK_DETECTValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "LEAK_DETECT";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "2.1";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// indication designating whether a leak has been detected.";
		}
		private BATTERY_STATEValue _BATTERY_STATE;
		/// <summary>
		/// present status of the battery.
		/// </summary>
		public BATTERY_STATEValue BATTERY_STATE => _BATTERY_STATE ?? (_BATTERY_STATE = new BATTERY_STATEValue());

		/// <summary>
		/// present status of the battery.
		/// </summary>
		public sealed class BATTERY_STATEValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "BATTERY_STATE";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "2.1";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// present status of the battery.";
		}
		private FEATURE_PERSISTENT_IDValue _FEATURE_PERSISTENT_ID;
		/// <summary>
		/// <i>UUID</i> of a <i>feature</i>. <seealso href="https://www.google.com/search?q=ISO 10303 AP 242/239&btnI=I">ISO 10303 AP 242/239</seealso>.
		/// </summary>
		public FEATURE_PERSISTENT_IDValue FEATURE_PERSISTENT_ID => _FEATURE_PERSISTENT_ID ?? (_FEATURE_PERSISTENT_ID = new FEATURE_PERSISTENT_IDValue());

		/// <summary>
		/// <i>UUID</i> of a <i>feature</i>. <seealso href="https://www.google.com/search?q=ISO 10303 AP 242/239&btnI=I">ISO 10303 AP 242/239</seealso>.
		/// </summary>
		public sealed class FEATURE_PERSISTENT_IDValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "FEATURE_PERSISTENT_ID";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "2.2";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// <i>UUID</i> of a <i>feature</i>. <seealso href=""https://www.google.com/search?q=ISO 10303 AP 242/239&btnI=I"">ISO 10303 AP 242/239</seealso>.";
		}
		private SENSOR_STATEValue _SENSOR_STATE;
		/// <summary>
		/// detection result of a sensor.
		/// </summary>
		public SENSOR_STATEValue SENSOR_STATE => _SENSOR_STATE ?? (_SENSOR_STATE = new SENSOR_STATEValue());

		/// <summary>
		/// detection result of a sensor.
		/// </summary>
		public sealed class SENSOR_STATEValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "SENSOR_STATE";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "2.2";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// detection result of a sensor.";
		}
		private COMPONENT_DATAValue _COMPONENT_DATA;
		/// <summary>
		/// <see cref="Event">Event</see> that represents a <see cref="Component">Component</see> where the <see cref="EntryDefinition">EntryDefinition</see> identifies the <see cref="Component">Component</see> and the <see cref="CellDefinition">CellDefinition</see>s define the <see cref="Component">Component</see>'s observed <see cref="DataItem">DataItem</see>s.
		/// </summary>
		public COMPONENT_DATAValue COMPONENT_DATA => _COMPONENT_DATA ?? (_COMPONENT_DATA = new COMPONENT_DATAValue());

		/// <summary>
		/// <see cref="Event">Event</see> that represents a <see cref="Component">Component</see> where the <see cref="EntryDefinition">EntryDefinition</see> identifies the <see cref="Component">Component</see> and the <see cref="CellDefinition">CellDefinition</see>s define the <see cref="Component">Component</see>'s observed <see cref="DataItem">DataItem</see>s.
		/// </summary>
		public sealed class COMPONENT_DATAValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "COMPONENT_DATA";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "2.2";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// <see cref=""Event"">Event</see> that represents a <see cref=""Component"">Component</see> where the <see cref=""EntryDefinition"">EntryDefinition</see> identifies the <see cref=""Component"">Component</see> and the <see cref=""CellDefinition"">CellDefinition</see>s define the <see cref=""Component"">Component</see>'s observed <see cref=""DataItem"">DataItem</see>s.";
		}
		private WORK_OFFSETSValue _WORK_OFFSETS;
		/// <summary>
		/// properties of each addressable work offset.
		/// </summary>
		public WORK_OFFSETSValue WORK_OFFSETS => _WORK_OFFSETS ?? (_WORK_OFFSETS = new WORK_OFFSETSValue());

		/// <summary>
		/// properties of each addressable work offset.
		/// </summary>
		public sealed class WORK_OFFSETSValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "WORK_OFFSETS";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "2.2";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// properties of each addressable work offset.";
		}
		private TOOL_OFFSETSValue _TOOL_OFFSETS;
		/// <summary>
		/// properties of each addressable tool offset.
		/// </summary>
		public TOOL_OFFSETSValue TOOL_OFFSETS => _TOOL_OFFSETS ?? (_TOOL_OFFSETS = new TOOL_OFFSETSValue());

		/// <summary>
		/// properties of each addressable tool offset.
		/// </summary>
		public sealed class TOOL_OFFSETSValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "TOOL_OFFSETS";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "2.2";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// properties of each addressable tool offset.";
		}
		private FEATURE_MEASUREMENTValue _FEATURE_MEASUREMENT;
		/// <summary>
		/// assessing elements of a <i>feature</i>.
		/// </summary>
		public FEATURE_MEASUREMENTValue FEATURE_MEASUREMENT => _FEATURE_MEASUREMENT ?? (_FEATURE_MEASUREMENT = new FEATURE_MEASUREMENTValue());

		/// <summary>
		/// assessing elements of a <i>feature</i>.
		/// </summary>
		public sealed class FEATURE_MEASUREMENTValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "FEATURE_MEASUREMENT";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "2.2";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// assessing elements of a <i>feature</i>.";
		}
		private CHARACTERISTIC_PERSISTENT_IDValue _CHARACTERISTIC_PERSISTENT_ID;
		/// <summary>
		/// <i>UUID</i> of the <i>characteristic</i>.
		/// </summary>
		public CHARACTERISTIC_PERSISTENT_IDValue CHARACTERISTIC_PERSISTENT_ID => _CHARACTERISTIC_PERSISTENT_ID ?? (_CHARACTERISTIC_PERSISTENT_ID = new CHARACTERISTIC_PERSISTENT_IDValue());

		/// <summary>
		/// <i>UUID</i> of the <i>characteristic</i>.
		/// </summary>
		public sealed class CHARACTERISTIC_PERSISTENT_IDValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "CHARACTERISTIC_PERSISTENT_ID";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "2.2";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// <i>UUID</i> of the <i>characteristic</i>.";
		}
		private MEASUREMENT_TYPEValue _MEASUREMENT_TYPE;
		/// <summary>
		/// class of measurement being performed. <seealso href="https://www.google.com/search?q=QIF 3:2018 Section 6.3&btnI=I">QIF 3:2018 Section 6.3</seealso>
		/// </summary>
		public MEASUREMENT_TYPEValue MEASUREMENT_TYPE => _MEASUREMENT_TYPE ?? (_MEASUREMENT_TYPE = new MEASUREMENT_TYPEValue());

		/// <summary>
		/// class of measurement being performed. <seealso href="https://www.google.com/search?q=QIF 3:2018 Section 6.3&btnI=I">QIF 3:2018 Section 6.3</seealso>
		/// </summary>
		public sealed class MEASUREMENT_TYPEValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "MEASUREMENT_TYPE";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "2.2";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// class of measurement being performed. <seealso href=""https://www.google.com/search?q=QIF 3:2018 Section 6.3&btnI=I"">QIF 3:2018 Section 6.3</seealso>";
		}
		private MEASUREMENT_VALUEValue _MEASUREMENT_VALUE;
		/// <summary>
		/// measurement based on the measurement type.
		/// </summary>
		public MEASUREMENT_VALUEValue MEASUREMENT_VALUE => _MEASUREMENT_VALUE ?? (_MEASUREMENT_VALUE = new MEASUREMENT_VALUEValue());

		/// <summary>
		/// measurement based on the measurement type.
		/// </summary>
		public sealed class MEASUREMENT_VALUEValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "MEASUREMENT_VALUE";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "2.2";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// measurement based on the measurement type.";
		}
		private MEASUREMENT_UNITSValue _MEASUREMENT_UNITS;
		/// <summary>
		/// engineering units of the measurement.
		/// </summary>
		public MEASUREMENT_UNITSValue MEASUREMENT_UNITS => _MEASUREMENT_UNITS ?? (_MEASUREMENT_UNITS = new MEASUREMENT_UNITSValue());

		/// <summary>
		/// engineering units of the measurement.
		/// </summary>
		public sealed class MEASUREMENT_UNITSValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "MEASUREMENT_UNITS";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "2.2";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// engineering units of the measurement.";
		}
		private CHARACTERISTIC_STATUSValue _CHARACTERISTIC_STATUS;
		/// <summary>
		/// pass/fail result of the measurement.
		/// </summary>
		public CHARACTERISTIC_STATUSValue CHARACTERISTIC_STATUS => _CHARACTERISTIC_STATUS ?? (_CHARACTERISTIC_STATUS = new CHARACTERISTIC_STATUSValue());

		/// <summary>
		/// pass/fail result of the measurement.
		/// </summary>
		public sealed class CHARACTERISTIC_STATUSValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "CHARACTERISTIC_STATUS";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "2.2";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// pass/fail result of the measurement.";
		}
		private UNCERTAINTY_TYPEValue _UNCERTAINTY_TYPE;
		/// <summary>
		/// method used to compute <i>standard uncertainty</i>.
		/// </summary>
		public UNCERTAINTY_TYPEValue UNCERTAINTY_TYPE => _UNCERTAINTY_TYPE ?? (_UNCERTAINTY_TYPE = new UNCERTAINTY_TYPEValue());

		/// <summary>
		/// method used to compute <i>standard uncertainty</i>.
		/// </summary>
		public sealed class UNCERTAINTY_TYPEValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "UNCERTAINTY_TYPE";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "2.2";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// method used to compute <i>standard uncertainty</i>.";
		}
		private UNCERTAINTYValue _UNCERTAINTY;
		/// <summary>
		/// <i>uncertainty</i> specified by <see cref="UncertaintyType">UncertaintyType</see>.
		/// </summary>
		public UNCERTAINTYValue UNCERTAINTY => _UNCERTAINTY ?? (_UNCERTAINTY = new UNCERTAINTYValue());

		/// <summary>
		/// <i>uncertainty</i> specified by <see cref="UncertaintyType">UncertaintyType</see>.
		/// </summary>
		public sealed class UNCERTAINTYValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "UNCERTAINTY";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "2.2";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// <i>uncertainty</i> specified by <see cref=""UncertaintyType"">UncertaintyType</see>.";
		}
		private SPECIFICATION_LIMITSValue _SPECIFICATION_LIMITS;
		/// <summary>
		/// set of limits defining a range of values designating acceptable performance for a variable.
		/// </summary>
		public SPECIFICATION_LIMITSValue SPECIFICATION_LIMITS => _SPECIFICATION_LIMITS ?? (_SPECIFICATION_LIMITS = new SPECIFICATION_LIMITSValue());

		/// <summary>
		/// set of limits defining a range of values designating acceptable performance for a variable.
		/// </summary>
		public sealed class SPECIFICATION_LIMITSValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "SPECIFICATION_LIMITS";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "2.3";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// set of limits defining a range of values designating acceptable performance for a variable.";
		}
		private CONTROL_LIMITSValue _CONTROL_LIMITS;
		/// <summary>
		/// set of limits used to indicate whether a process variable is stable and in control.
		/// </summary>
		public CONTROL_LIMITSValue CONTROL_LIMITS => _CONTROL_LIMITS ?? (_CONTROL_LIMITS = new CONTROL_LIMITSValue());

		/// <summary>
		/// set of limits used to indicate whether a process variable is stable and in control.
		/// </summary>
		public sealed class CONTROL_LIMITSValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "CONTROL_LIMITS";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "2.3";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// set of limits used to indicate whether a process variable is stable and in control.";
		}
		private ALARM_LIMITSValue _ALARM_LIMITS;
		/// <summary>
		/// set of limits used to trigger warning or alarm indicators.
		/// </summary>
		public ALARM_LIMITSValue ALARM_LIMITS => _ALARM_LIMITS ?? (_ALARM_LIMITS = new ALARM_LIMITSValue());

		/// <summary>
		/// set of limits used to trigger warning or alarm indicators.
		/// </summary>
		public sealed class ALARM_LIMITSValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "ALARM_LIMITS";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "2.3";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// set of limits used to trigger warning or alarm indicators.";
		}
		private TOOL_CUTTING_ITEMValue _TOOL_CUTTING_ITEM;
		/// <summary>
		/// references the <see cref="CuttingToolLifeCycle">CuttingToolLifeCycle</see> <see cref="CuttingItem">CuttingItem</see> index related to the <see cref="CuttingItem::indices" /> of the currently active cutting tool edge.
		/// </summary>
		public TOOL_CUTTING_ITEMValue TOOL_CUTTING_ITEM => _TOOL_CUTTING_ITEM ?? (_TOOL_CUTTING_ITEM = new TOOL_CUTTING_ITEMValue());

		/// <summary>
		/// references the <see cref="CuttingToolLifeCycle">CuttingToolLifeCycle</see> <see cref="CuttingItem">CuttingItem</see> index related to the <see cref="CuttingItem::indices" /> of the currently active cutting tool edge.
		/// </summary>
		public sealed class TOOL_CUTTING_ITEMValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "TOOL_CUTTING_ITEM";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "2.3";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// references the <see cref=""CuttingToolLifeCycle"">CuttingToolLifeCycle</see> <see cref=""CuttingItem"">CuttingItem</see> index related to the <see cref=""CuttingItem::indices"" /> of the currently active cutting tool edge.";
		}
		private LOCATION_ADDRESSValue _LOCATION_ADDRESS;
		/// <summary>
		/// structured information that allows the unambiguous determination of an object for purposes of identification and location. <seealso href="https://www.google.com/search?q=ISO 19160-4:2017&btnI=I">ISO 19160-4:2017</seealso>
		/// </summary>
		public LOCATION_ADDRESSValue LOCATION_ADDRESS => _LOCATION_ADDRESS ?? (_LOCATION_ADDRESS = new LOCATION_ADDRESSValue());

		/// <summary>
		/// structured information that allows the unambiguous determination of an object for purposes of identification and location. <seealso href="https://www.google.com/search?q=ISO 19160-4:2017&btnI=I">ISO 19160-4:2017</seealso>
		/// </summary>
		public sealed class LOCATION_ADDRESSValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "LOCATION_ADDRESS";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "2.3";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// structured information that allows the unambiguous determination of an object for purposes of identification and location. <seealso href=""https://www.google.com/search?q=ISO 19160-4:2017&btnI=I"">ISO 19160-4:2017</seealso>";
		}
		private POWER_SOURCEValue _POWER_SOURCE;
		/// <summary>
		/// active energy source for the <see cref="Component">Component</see>.
		/// </summary>
		public POWER_SOURCEValue POWER_SOURCE => _POWER_SOURCE ?? (_POWER_SOURCE = new POWER_SOURCEValue());

		/// <summary>
		/// active energy source for the <see cref="Component">Component</see>.
		/// </summary>
		public sealed class POWER_SOURCEValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "POWER_SOURCE";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "2.3";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// active energy source for the <see cref=""Component"">Component</see>.";
		}
	}
}