#pragma warning disable CS1574 // XML comment has cref attribute that could not be resolved
#pragma warning disable CS1584 // XML comment has syntactically incorrect cref attribute
#pragma warning disable CS0618 // Type or member is obsolete
using System;
using System.CodeDom.Compiler;using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;

namespace Mtconnect.DataTypes
{
	/// <summary>﻿
	/// <br/> Visit <seealso href="https://model.mtconnect.org/#Enumeration___19_0_3_45f01b9_1580398379726_606068_12802">model.mtconnect.org</seealso> for more information.
	/// </summary>
	/// <remarks>
	/// <list type="bullet">
	/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
	/// </list>
	/// </remarks>

	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public enum EventEnum
	{
		/// <summary>﻿set of axes currently associated with a <see cref="Path">Path</see> or <see cref="Controller">Controller</see>.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		ACTIVE_AXES,
		/// <summary>﻿operational state of an apparatus for moving or controlling a mechanism or system.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		ACTUATOR_STATE,
		/// <summary>﻿<b>DEPRECATED:</b> Replaced with <c>CONDITION</c> category data items in Version 1.1.0.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		ALARM,
		/// <summary>﻿<see cref="assetId">assetId</see> of the <i>Asset</i> that has been added or changed.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		ASSET_CHANGED,
		/// <summary>﻿<see cref="assetId">assetId</see> of the <i>Asset</i> that has been removed.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		ASSET_REMOVED,
		/// <summary>﻿<i>agent</i>'s ability to communicate with the data source.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		AVAILABILITY,
		/// <summary>﻿describes the way the axes will be associated to each other. <br />  <br />This is used in conjunction with <c>COUPLED_AXES</c> to indicate the way they are interacting.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		AXIS_COUPLING,
		/// <summary>﻿value of a signal or calculation issued to adjust the feedrate of an individual linear type axis.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		AXIS_FEEDRATE_OVERRIDE,
		/// <summary>﻿state of the axis lockout function when power has been removed and the axis is allowed to move freely.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		AXIS_INTERLOCK,
		/// <summary>﻿state of a <see cref="Linear">Linear</see> or <see cref="Rotary">Rotary</see> component representing an axis.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		AXIS_STATE,
		/// <summary>﻿line of code or command being executed by a <see cref="Controller">Controller</see> entity.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		BLOCK,
		/// <summary>﻿total count of the number of blocks of program code that have been executed since execution started.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		BLOCK_COUNT,
		/// <summary>﻿state of an interlock function or control logic state intended to prevent the associated <see cref="Chuck">Chuck</see> component from being operated.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		CHUCK_INTERLOCK,
		/// <summary>﻿operating state of a mechanism that holds a part or stock material during a manufacturing process. <br /><br />It may also represent a mechanism that holds any other mechanism in place within a piece of equipment.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		CHUCK_STATE,
		/// <summary>﻿programmatic code being executed.<br /><br /><b>DEPRECATED</b> in <i>Version 1.1</i>.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		CODE,
		/// <summary>﻿operating state of a mechanism represented by a <see cref="Composition">Composition</see> entity.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		COMPOSITION_STATE,
		/// <summary>﻿current mode of the <see cref="Controller">Controller</see> component.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		CONTROLLER_MODE,
		/// <summary>﻿setting or operator selection that changes the behavior of a piece of equipment.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		CONTROLLER_MODE_OVERRIDE,
		/// <summary>﻿set of associated axes.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		COUPLED_AXES,
		/// <summary>﻿time and date code associated with a material or other physical item.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		DATE_CODE,
		/// <summary>﻿identifier of another piece of equipment that is temporarily associated with a component of this piece of equipment to perform a particular function.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		DEVICE_UUID,
		/// <summary>﻿direction of motion.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		DIRECTION,
		/// <summary>﻿operational state of a <see cref="Door">Door</see> component or composition element.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		DOOR_STATE,
		/// <summary>﻿state of the emergency stop signal for a piece of equipment, controller path, or any other component or subsystem of a piece of equipment.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		EMERGENCY_STOP,
		/// <summary>﻿indication of whether the end of a piece of bar stock being feed by a bar feeder has been reached.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		END_OF_BAR,
		/// <summary>﻿indication that a piece of equipment, or a sub-part of a piece of equipment, is performing specific types of activities.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		EQUIPMENT_MODE,
		/// <summary>﻿operating state of a <see cref="Component">Component</see>.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		EXECUTION,
		/// <summary>﻿current intended production status of the <see cref="Component">Component</see>.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		FUNCTIONAL_MODE,
		/// <summary>﻿hardness of a material.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		HARDNESS,
		/// <summary>﻿current line of code being executed.<br /><br /><b>DEPRECATED</b> in <i>Version 1.4.0</i>.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		LINE,
		/// <summary>﻿identifier for a <see cref="Block">Block</see> of code in a <see cref="Program">Program</see>.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		LINE_LABEL,
		/// <summary>﻿position of a block of program code within a control program.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		LINE_NUMBER,
		/// <summary>﻿identifier of a material used or consumed in the manufacturing process.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		MATERIAL,
		/// <summary>﻿identifies the layers of material applied to a part or product as part of an additive manufacturing process.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		MATERIAL_LAYER,
		/// <summary>﻿information to be transferred from a piece of equipment to a client software application.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		MESSAGE,
		/// <summary>﻿identifier of the person currently responsible for operating the piece of equipment.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		OPERATOR_ID,
		/// <summary>﻿identifier for a pallet.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		PALLET_ID,
		/// <summary>﻿aggregate count of parts.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		PART_COUNT,
		/// <summary>﻿indication designating whether a part or work piece has been detected or is present.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		PART_DETECT,
		/// <summary>﻿identifier of a part in a manufacturing operation.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		PART_ID,
		/// <summary>﻿identifier of a part or product moving through the manufacturing process.<br /><br /><b>DEPRECATED</b> in <i>Version 1.7</i>. <c>PART_NUMBER</c> is now a <c>subType</c> of <c>PART_KIND_ID</c>.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		PART_NUMBER,
		/// <summary>﻿value of a signal or calculation issued to adjust the feedrate for the axes associated with a <see cref="Path">Path</see> component that may represent a single axis or the coordinated movement of multiple axes.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		PATH_FEEDRATE_OVERRIDE,
		/// <summary>﻿describes the operational relationship between a <see cref="Path">Path</see> entity and another <see cref="Path">Path</see> entity for pieces of equipment comprised of multiple logical groupings of controlled axes or other logical operations.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		PATH_MODE,
		/// <summary>﻿indication of the status of the source of energy for an entity to allow it to perform its intended function or the state of an enabling signal providing permission for the entity to perform its functions.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		POWER_STATE,
		/// <summary>﻿status of the <see cref="Component">Component</see>.<br /><br /><b>DEPRECATED</b> in <i>Version 1.1.0</i>.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		POWER_STATUS,
		/// <summary>﻿time and date associated with an activity or event.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		PROCESS_TIME,
		/// <summary>﻿name of the logic or motion program being executed by the <see cref="Controller">Controller</see> component.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		PROGRAM,
		/// <summary>﻿comment or non-executable statement in the control program.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		PROGRAM_COMMENT,
		/// <summary>﻿indication of the status of the <see cref="Controller">Controller</see> components program editing mode.<br /><br />A program may be edited while another is executed.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		PROGRAM_EDIT,
		/// <summary>﻿name of the program being edited. <br /><br />This is used in conjunction with <see cref="ProgramEdit">ProgramEdit</see> when in <c>ACTIVE</c> state. <br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		PROGRAM_EDIT_NAME,
		/// <summary>﻿non-executable header section of the control program.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		PROGRAM_HEADER,
		/// <summary>﻿<i>URI</i> for the source file associated with <see cref="Program">Program</see>.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		PROGRAM_LOCATION,
		/// <summary>﻿defines whether the logic or motion program defined by <see cref="Program">Program</see> is being executed from the local memory of the controller or from an outside source.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		PROGRAM_LOCATION_TYPE,
		/// <summary>﻿indication of the nesting level within a control program that is associated with the code or instructions that is currently being executed.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		PROGRAM_NEST_LEVEL,
		/// <summary>﻿current operating mode for a <see cref="Rotary">Rotary</see> type axis.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		ROTARY_MODE,
		/// <summary>﻿percentage change to the velocity of the programmed velocity for a <see cref="Rotary">Rotary</see> axis.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		ROTARY_VELOCITY_OVERRIDE,
		/// <summary>﻿serial number associated with a <see cref="Component">Component</see>, <see cref="Asset">Asset</see>, or <see cref="Device">Device</see>.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		SERIAL_NUMBER,
		/// <summary>﻿indication of the status of the spindle for a piece of equipment when power has been removed and it is free to rotate.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		SPINDLE_INTERLOCK,
		/// <summary>﻿identifier of an individual tool asset.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		TOOL_ASSET_ID,
		/// <summary>﻿identifier for the tool group associated with a specific tool. Commonly used to designate spare tools.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		TOOL_GROUP,
		/// <summary>﻿identifier of the tool currently in use for a given <c>Path</c>.<br /><br /><b>DEPRECATED</b> in <i>Version 1.2.0</i>.   See <c>TOOL_ASSET_ID</c>.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		TOOL_ID,
		/// <summary>﻿identifier assigned by the <see cref="Controller">Controller</see> component to a cutting tool when in use by a piece of equipment.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		TOOL_NUMBER,
		/// <summary>﻿reference to the tool offset variables applied to the active cutting tool.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		TOOL_OFFSET,
		/// <summary>﻿identifier of the person currently responsible for operating the piece of equipment.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		USER,
		/// <summary>﻿data whose meaning may change over time due to changes in the operation of a piece of equipment or the process being executed on that piece of equipment.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		VARIABLE,
		/// <summary>﻿indication of the reason that <see cref="Execution">Execution</see> is reporting a value of <c>WAIT</c>.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		WAIT_STATE,
		/// <summary>﻿identifier for the type of wire used as the cutting mechanism in Electrical Discharge Machining or similar processes.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		WIRE,
		/// <summary>﻿identifier for the current workholding or part clamp in use by a piece of equipment.<br /><br /><b>DEPRECATION WARNING</b>: Recommend using <c>FIXTURE_ID</c> instead.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		WORKHOLDING_ID,
		/// <summary>﻿reference to offset variables for a work piece or part.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		WORK_OFFSET,
		/// <summary>﻿Operating System (OS) of a <see cref="Component">Component</see>.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		OPERATING_SYSTEM,
		/// <summary>﻿embedded software of a <see cref="Component">Component</see><br />.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		FIRMWARE,
		/// <summary>﻿application on a <see cref="Component">Component</see>.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		APPLICATION,
		/// <summary>﻿software library on a <see cref="Component">Component</see><br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		LIBRARY,
		/// <summary>﻿hardware of a <see cref="Component">Component</see>.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		HARDWARE,
		/// <summary>﻿network details of a <see cref="Component">Component</see>.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		NETWORK,
		/// <summary>﻿three space angular displacement of an object or coordinate system relative to a <i>cartesian coordinate system</i>.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		ROTATION,
		/// <summary>﻿three space linear displacement of an object or coordinate system relative to a <i>cartesian coordinate system</i>.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		TRANSLATION,
		/// <summary>﻿<i>UUID</i> of new device added to an <i>MTConnect Agent</i>.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		DEVICE_ADDED,
		/// <summary>﻿<i>UUID</i> of a device removed from an <i>MTConnect Agent</i>.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		DEVICE_REMOVED,
		/// <summary>﻿<i>UUID</i> of the device whose <i>metadata</i> has changed.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		DEVICE_CHANGED,
		/// <summary>﻿status of the connection between an <i>adapter</i> and an <i>agent</i>.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		CONNECTION_STATUS,
		/// <summary>﻿originator’s software version of the <i>adapter</i>.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		ADAPTER_SOFTWARE_VERSION,
		/// <summary>﻿<i>URI</i> of the <i>adapter</i>.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		ADAPTER_URI,
		/// <summary>﻿reference version of the MTConnect Standard supported by the <i>adapter</i>.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		MTCONNECT_VERSION,
		/// <summary>﻿<i>attachment</i> between a sensor and an entity.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		SENSOR_ATTACHMENT,
		/// <summary>﻿state or condition of a part.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		PART_STATUS,
		/// <summary>﻿identifier of a process being executed by the device.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		PROCESS_OCCURRENCE_ID,
		/// <summary>﻿identifier given to link the individual occurrence to a group of related occurrences, such as a process step in a process plan.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		PROCESS_AGGREGATE_ID,
		/// <summary>﻿identifier given to link the individual occurrence to a class of processes or process definition.<br /><br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		PROCESS_KIND_ID,
		/// <summary>﻿identifier given to a collection of individual parts. <br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		PART_GROUP_ID,
		/// <summary>﻿identifier given to link the individual occurrence to a class of parts, typically distinguished by a particular part design.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		PART_KIND_ID,
		/// <summary>﻿identifier given to a distinguishable, individual part. <br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		PART_UNIQUE_ID,
		/// <summary>﻿set of limits used to indicate whether a process variable is stable and in control.<br /><br /><b>DEPRECATION WARNING</b>. Recommend using <c>CONTROL_LIMITS</c>.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		CONTROL_LIMIT,
		/// <summary>﻿set of limits defining a range of values designating acceptable performance for a variable.<br /><br /><b>DEPRECATION WARNING</b>. Recommend using <c>SPECIFICATION_LIMITS</c>.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		SPECIFICATION_LIMIT,
		/// <summary>﻿set of limits used to trigger warning or alarm indicators.<br /><br /><b>DEPRECATION WARNING</b>. Recommend using <c>ALARM_LIMITS</c>.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		ALARM_LIMIT,
		/// <summary>﻿accumulation of the number of times an operation has attempted to, or is planned to attempt to, load materials, parts, or other items.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		LOAD_COUNT,
		/// <summary>﻿accumulation of the number of times an operation has attempted to, or is planned to attempt to, unload materials, parts, or other items.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		UNLOAD_COUNT,
		/// <summary>﻿accumulation of the number of times an operation has attempted to, or is planned to attempt to, transfer materials, parts, or other items from one location to another.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		TRANSFER_COUNT,
		/// <summary>﻿accumulation of the number of times a function has attempted to, or is planned to attempt to, activate or be performed.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		ACTIVATION_COUNT,
		/// <summary>﻿accumulation of the number of times a function has attempted to, or is planned to attempt to, deactivate or cease.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		DEACTIVATION_COUNT,
		/// <summary>﻿accumulation of the number of times a cyclic function has attempted to, or is planned to attempt to execute.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		CYCLE_COUNT,
		/// <summary>﻿state of a valve is one of open, closed, or transitioning between the states.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		VALVE_STATE,
		/// <summary>﻿state or operating mode of a <see cref="Lock">Lock</see>.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		LOCK_STATE,
		/// <summary>﻿particular condition of the process occurrence at a specific time.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		PROCESS_STATE,
		/// <summary>﻿particular condition of the part occurrence at a specific time.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		PART_PROCESSING_STATE,
		/// <summary>﻿state of <see cref="Component">Component</see> or <see cref="Composition">Composition</see> that describes the automatic or manual operation of the entity.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		OPERATING_MODE,
		/// <summary>﻿<i>data set</i> of the number of <i>Asset</i>s of a given type for a <i>Device</i>.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		ASSET_COUNT,
		/// <summary>﻿actions or activities to be performed in support of a piece of equipment.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		MAINTENANCE_LIST,
		/// <summary>﻿identifier for the current workholding or part clamp in use by a piece of equipment.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		FIXTURE_ID,
		/// <summary>﻿interpretation of <c>PART_COUNT</c>.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		PART_COUNT_TYPE,
		/// <summary>﻿time provided by a timing device at a specific point in time.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		CLOCK_TIME,
		/// <summary>﻿name of the host computer supplying data.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		HOST_NAME,
		/// <summary>﻿number of the TCP/IP or UDP/IP port for the connection endpoint.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		NETWORK_PORT,
		/// <summary>﻿indication designating whether a leak has been detected.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		LEAK_DETECT,
		/// <summary>﻿present status of the battery.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		BATTERY_STATE,
		/// <summary>﻿<i>UUID</i> of a <i>feature</i>. <seealso href="https://www.google.com/search?q=ISO 10303 AP 242/239&amp;btnI=I">ISO 10303 AP 242/239</seealso>.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		FEATURE_PERSISTENT_ID,
		/// <summary>﻿detection result of a sensor.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		SENSOR_STATE,
		/// <summary>﻿<see cref="Event">Event</see> that represents a <see cref="Component">Component</see> where the <see cref="EntryDefinition">EntryDefinition</see> identifies the <see cref="Component">Component</see> and the <see cref="CellDefinition">CellDefinition</see>s define the <see cref="Component">Component</see>'s observed <see cref="DataItem">DataItem</see>s.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		COMPONENT_DATA,
		/// <summary>﻿properties of each addressable work offset.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		WORK_OFFSETS,
		/// <summary>﻿properties of each addressable tool offset.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		TOOL_OFFSETS,
		/// <summary>﻿assessing elements of a <i>feature</i>.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		FEATURE_MEASUREMENT,
		/// <summary>﻿<i>UUID</i> of the <i>characteristic</i>.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		CHARACTERISTIC_PERSISTENT_ID,
		/// <summary>﻿class of measurement being performed. <seealso href="https://www.google.com/search?q=QIF 3:2018 Section 6.3&amp;btnI=I">QIF 3:2018 Section 6.3</seealso><br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		MEASUREMENT_TYPE,
		/// <summary>﻿measurement based on the measurement type.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		MEASUREMENT_VALUE,
		/// <summary>﻿engineering units of the measurement.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		MEASUREMENT_UNITS,
		/// <summary>﻿pass/fail result of the measurement.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		CHARACTERISTIC_STATUS,
		/// <summary>﻿method used to compute <i>standard uncertainty</i>.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		UNCERTAINTY_TYPE,
		/// <summary>﻿<i>uncertainty</i> specified by <see cref="UncertaintyType">UncertaintyType</see>.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		UNCERTAINTY,
		/// <summary>﻿set of limits defining a range of values designating acceptable performance for a variable.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		SPECIFICATION_LIMITS,
		/// <summary>﻿set of limits used to indicate whether a process variable is stable and in control.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		CONTROL_LIMITS,
		/// <summary>﻿set of limits used to trigger warning or alarm indicators.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		ALARM_LIMITS,
		/// <summary>﻿references the <see cref="CuttingToolLifeCycle">CuttingToolLifeCycle</see> <see cref="CuttingItem">CuttingItem</see> index related to the <see cref="CuttingItem.indices">indices in CuttingItem</see> of the currently active cutting tool edge.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		TOOL_CUTTING_ITEM,
		/// <summary>﻿structured information that allows the unambiguous determination of an object for purposes of identification and location. <seealso href="https://www.google.com/search?q=ISO 19160-4:2017&amp;btnI=I">ISO 19160-4:2017</seealso><br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		LOCATION_ADDRESS,
		/// <summary>﻿active energy source for the <see cref="Component">Component</see>.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		POWER_SOURCE,
	}

	/// <summary>﻿
	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Enumeration___19_0_3_45f01b9_1580398379726_606068_12802">model.mtconnect.org</seealso> for more information.
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public sealed class EventEnumMetaClass : IEnum
	{
		/// <summary>Constant value for <see cref="EventEnumMetaClass.ReferenceId" /></summary>
		public const string REFERENCE_ID = "_19_0_3_45f01b9_1580398379726_606068_12802";
		/// <summary>Constant value for <see cref="EventEnumMetaClass.HelpUrl" /></summary>
		public const string HELP_URL = "https://model.mtconnect.org/#Enumeration___19_0_3_45f01b9_1580398379726_606068_12802";
		/// <summary>Constant value for <see cref="EventEnumMetaClass.Name" /></summary>
		public const string NAME = "EventEnum";
		/// <summary>Constant value for <see cref="EventEnumMetaClass.NormativeVersion" /></summary>
		public const string NORMATIVE_VERSION = "1.0";
		/// <summary>Constant value for <see cref="EventEnumMetaClass.DeprecatedVersion" /></summary>
		public const string DEPRECATED_VERSION = "";
		/// <summary>Constant value for <see cref="EventEnumMetaClass.Summary" /></summary>
		public const string SUMMARY = @"";

		/// <inheritdoc />
		public string ReferenceId => REFERENCE_ID;
		
		/// <inheritdoc />
		public string HelpUrl => HELP_URL;

		/// <inheritdoc />
		public string Name => NAME;
		
		/// <inheritdoc />
		public Type DataType => null;
		
		/// <inheritdoc />
		public Type Instance => typeof(EventEnum);

		/// <inheritdoc />
		public string NormativeVersion => NORMATIVE_VERSION;
		
		/// <inheritdoc />
		public string DeprecatedVersion => DEPRECATED_VERSION;
		
		/// <inheritdoc />
		public string Summary => SUMMARY;
		
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
		/// <inheritdoc cref="ACTIVE_AXESValue" path="/summary" />
		public ACTIVE_AXESValue ACTIVE_AXES => _ACTIVE_AXES ?? (_ACTIVE_AXES = new ACTIVE_AXESValue());

		/// <summary>﻿set of axes currently associated with a <see cref="Path">Path</see> or <see cref="Controller">Controller</see>.<br /><br /><br />
		/// Value for EventEnum.<br/>
		/// <br/>See also <seealso cref="EventEnum">EventEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		public sealed class ACTIVE_AXESValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="ACTIVE_AXESValue.Name" /></summary>
			public const string NAME = "ACTIVE_AXES";
			/// <summary>Constant value for <see cref="ACTIVE_AXESValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.1";
			/// <summary>Constant value for <see cref="ACTIVE_AXESValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="ACTIVE_AXESValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;set of axes currently associated with a {{block(Path)}} or {{block(Controller)}}.&#10;
";

			/// <inheritdoc />
			public string Name => NAME;
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => NORMATIVE_VERSION;
			
			/// <inheritdoc />
			public string DeprecatedVersion => DEPRECATED_VERSION;
			
			/// <inheritdoc />
			public string Summary => SUMMARY;
		}
		private ACTUATOR_STATEValue _ACTUATOR_STATE;
		/// <inheritdoc cref="ACTUATOR_STATEValue" path="/summary" />
		public ACTUATOR_STATEValue ACTUATOR_STATE => _ACTUATOR_STATE ?? (_ACTUATOR_STATE = new ACTUATOR_STATEValue());

		/// <summary>﻿operational state of an apparatus for moving or controlling a mechanism or system.<br /><br /><br />
		/// Value for EventEnum.<br/>
		/// <br/>See also <seealso cref="EventEnum">EventEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		public sealed class ACTUATOR_STATEValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="ACTUATOR_STATEValue.Name" /></summary>
			public const string NAME = "ACTUATOR_STATE";
			/// <summary>Constant value for <see cref="ACTUATOR_STATEValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.2";
			/// <summary>Constant value for <see cref="ACTUATOR_STATEValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="ACTUATOR_STATEValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;operational state of an apparatus for moving or controlling a mechanism or system.&#10;
";

			/// <inheritdoc />
			public string Name => NAME;
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => NORMATIVE_VERSION;
			
			/// <inheritdoc />
			public string DeprecatedVersion => DEPRECATED_VERSION;
			
			/// <inheritdoc />
			public string Summary => SUMMARY;
		}
		private ALARMValue _ALARM;
		/// <inheritdoc cref="ALARMValue" path="/summary" />
		public ALARMValue ALARM => _ALARM ?? (_ALARM = new ALARMValue());

		/// <summary>﻿<b>DEPRECATED:</b> Replaced with <c>CONDITION</c> category data items in Version 1.1.0.<br /><br /><br />
		/// Value for EventEnum.<br/>
		/// <br/>See also <seealso cref="EventEnum">EventEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		public sealed class ALARMValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="ALARMValue.Name" /></summary>
			public const string NAME = "ALARM";
			/// <summary>Constant value for <see cref="ALARMValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.0";
			/// <summary>Constant value for <see cref="ALARMValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "1.1";
			/// <summary>Constant value for <see cref="ALARMValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;**DEPRECATED:** Replaced with `CONDITION` category data items in Version 1.1.0.&#10;
";

			/// <inheritdoc />
			public string Name => NAME;
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => NORMATIVE_VERSION;
			
			/// <inheritdoc />
			public string DeprecatedVersion => DEPRECATED_VERSION;
			
			/// <inheritdoc />
			public string Summary => SUMMARY;
		}
		private ASSET_CHANGEDValue _ASSET_CHANGED;
		/// <inheritdoc cref="ASSET_CHANGEDValue" path="/summary" />
		public ASSET_CHANGEDValue ASSET_CHANGED => _ASSET_CHANGED ?? (_ASSET_CHANGED = new ASSET_CHANGEDValue());

		/// <summary>﻿<see cref="assetId">assetId</see> of the <i>Asset</i> that has been added or changed.<br /><br /><br />
		/// Value for EventEnum.<br/>
		/// <br/>See also <seealso cref="EventEnum">EventEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		public sealed class ASSET_CHANGEDValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="ASSET_CHANGEDValue.Name" /></summary>
			public const string NAME = "ASSET_CHANGED";
			/// <summary>Constant value for <see cref="ASSET_CHANGEDValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.2";
			/// <summary>Constant value for <see cref="ASSET_CHANGEDValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="ASSET_CHANGEDValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;{{block(assetId)}} of the {{term(Asset)}} that has been added or changed.&#10;
";

			/// <inheritdoc />
			public string Name => NAME;
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => NORMATIVE_VERSION;
			
			/// <inheritdoc />
			public string DeprecatedVersion => DEPRECATED_VERSION;
			
			/// <inheritdoc />
			public string Summary => SUMMARY;
		}
		private ASSET_REMOVEDValue _ASSET_REMOVED;
		/// <inheritdoc cref="ASSET_REMOVEDValue" path="/summary" />
		public ASSET_REMOVEDValue ASSET_REMOVED => _ASSET_REMOVED ?? (_ASSET_REMOVED = new ASSET_REMOVEDValue());

		/// <summary>﻿<see cref="assetId">assetId</see> of the <i>Asset</i> that has been removed.<br /><br /><br />
		/// Value for EventEnum.<br/>
		/// <br/>See also <seealso cref="EventEnum">EventEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		public sealed class ASSET_REMOVEDValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="ASSET_REMOVEDValue.Name" /></summary>
			public const string NAME = "ASSET_REMOVED";
			/// <summary>Constant value for <see cref="ASSET_REMOVEDValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.3";
			/// <summary>Constant value for <see cref="ASSET_REMOVEDValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="ASSET_REMOVEDValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;{{block(assetId)}} of the {{term(Asset)}} that has been removed.&#10;
";

			/// <inheritdoc />
			public string Name => NAME;
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => NORMATIVE_VERSION;
			
			/// <inheritdoc />
			public string DeprecatedVersion => DEPRECATED_VERSION;
			
			/// <inheritdoc />
			public string Summary => SUMMARY;
		}
		private AVAILABILITYValue _AVAILABILITY;
		/// <inheritdoc cref="AVAILABILITYValue" path="/summary" />
		public AVAILABILITYValue AVAILABILITY => _AVAILABILITY ?? (_AVAILABILITY = new AVAILABILITYValue());

		/// <summary>﻿<i>agent</i>'s ability to communicate with the data source.<br /><br /><br />
		/// Value for EventEnum.<br/>
		/// <br/>See also <seealso cref="EventEnum">EventEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		public sealed class AVAILABILITYValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="AVAILABILITYValue.Name" /></summary>
			public const string NAME = "AVAILABILITY";
			/// <summary>Constant value for <see cref="AVAILABILITYValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.1";
			/// <summary>Constant value for <see cref="AVAILABILITYValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="AVAILABILITYValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;{{term(agent)}}'s ability to communicate with the data source.&#10;
";

			/// <inheritdoc />
			public string Name => NAME;
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => NORMATIVE_VERSION;
			
			/// <inheritdoc />
			public string DeprecatedVersion => DEPRECATED_VERSION;
			
			/// <inheritdoc />
			public string Summary => SUMMARY;
		}
		private AXIS_COUPLINGValue _AXIS_COUPLING;
		/// <inheritdoc cref="AXIS_COUPLINGValue" path="/summary" />
		public AXIS_COUPLINGValue AXIS_COUPLING => _AXIS_COUPLING ?? (_AXIS_COUPLING = new AXIS_COUPLINGValue());

		/// <summary>﻿describes the way the axes will be associated to each other. <br />  <br />This is used in conjunction with <c>COUPLED_AXES</c> to indicate the way they are interacting.<br /><br /><br />
		/// Value for EventEnum.<br/>
		/// <br/>See also <seealso cref="EventEnum">EventEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		public sealed class AXIS_COUPLINGValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="AXIS_COUPLINGValue.Name" /></summary>
			public const string NAME = "AXIS_COUPLING";
			/// <summary>Constant value for <see cref="AXIS_COUPLINGValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.1";
			/// <summary>Constant value for <see cref="AXIS_COUPLINGValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="AXIS_COUPLINGValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;describes the way the axes will be associated to each other. 
  
This is used in conjunction with `COUPLED_AXES` to indicate the way they are interacting.&#10;
";

			/// <inheritdoc />
			public string Name => NAME;
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => NORMATIVE_VERSION;
			
			/// <inheritdoc />
			public string DeprecatedVersion => DEPRECATED_VERSION;
			
			/// <inheritdoc />
			public string Summary => SUMMARY;
		}
		private AXIS_FEEDRATE_OVERRIDEValue _AXIS_FEEDRATE_OVERRIDE;
		/// <inheritdoc cref="AXIS_FEEDRATE_OVERRIDEValue" path="/summary" />
		public AXIS_FEEDRATE_OVERRIDEValue AXIS_FEEDRATE_OVERRIDE => _AXIS_FEEDRATE_OVERRIDE ?? (_AXIS_FEEDRATE_OVERRIDE = new AXIS_FEEDRATE_OVERRIDEValue());

		/// <summary>﻿value of a signal or calculation issued to adjust the feedrate of an individual linear type axis.<br /><br /><br />
		/// Value for EventEnum.<br/>
		/// <br/>See also <seealso cref="EventEnum">EventEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		public sealed class AXIS_FEEDRATE_OVERRIDEValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="AXIS_FEEDRATE_OVERRIDEValue.Name" /></summary>
			public const string NAME = "AXIS_FEEDRATE_OVERRIDE";
			/// <summary>Constant value for <see cref="AXIS_FEEDRATE_OVERRIDEValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.3";
			/// <summary>Constant value for <see cref="AXIS_FEEDRATE_OVERRIDEValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="AXIS_FEEDRATE_OVERRIDEValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;value of a signal or calculation issued to adjust the feedrate of an individual linear type axis.&#10;
";

			/// <inheritdoc />
			public string Name => NAME;
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => NORMATIVE_VERSION;
			
			/// <inheritdoc />
			public string DeprecatedVersion => DEPRECATED_VERSION;
			
			/// <inheritdoc />
			public string Summary => SUMMARY;
		}
		private AXIS_INTERLOCKValue _AXIS_INTERLOCK;
		/// <inheritdoc cref="AXIS_INTERLOCKValue" path="/summary" />
		public AXIS_INTERLOCKValue AXIS_INTERLOCK => _AXIS_INTERLOCK ?? (_AXIS_INTERLOCK = new AXIS_INTERLOCKValue());

		/// <summary>﻿state of the axis lockout function when power has been removed and the axis is allowed to move freely.<br /><br /><br />
		/// Value for EventEnum.<br/>
		/// <br/>See also <seealso cref="EventEnum">EventEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		public sealed class AXIS_INTERLOCKValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="AXIS_INTERLOCKValue.Name" /></summary>
			public const string NAME = "AXIS_INTERLOCK";
			/// <summary>Constant value for <see cref="AXIS_INTERLOCKValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.3";
			/// <summary>Constant value for <see cref="AXIS_INTERLOCKValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="AXIS_INTERLOCKValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;state of the axis lockout function when power has been removed and the axis is allowed to move freely.&#10;
";

			/// <inheritdoc />
			public string Name => NAME;
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => NORMATIVE_VERSION;
			
			/// <inheritdoc />
			public string DeprecatedVersion => DEPRECATED_VERSION;
			
			/// <inheritdoc />
			public string Summary => SUMMARY;
		}
		private AXIS_STATEValue _AXIS_STATE;
		/// <inheritdoc cref="AXIS_STATEValue" path="/summary" />
		public AXIS_STATEValue AXIS_STATE => _AXIS_STATE ?? (_AXIS_STATE = new AXIS_STATEValue());

		/// <summary>﻿state of a <see cref="Linear">Linear</see> or <see cref="Rotary">Rotary</see> component representing an axis.<br /><br /><br />
		/// Value for EventEnum.<br/>
		/// <br/>See also <seealso cref="EventEnum">EventEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		public sealed class AXIS_STATEValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="AXIS_STATEValue.Name" /></summary>
			public const string NAME = "AXIS_STATE";
			/// <summary>Constant value for <see cref="AXIS_STATEValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.3";
			/// <summary>Constant value for <see cref="AXIS_STATEValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="AXIS_STATEValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;state of a {{block(Linear)}} or {{block(Rotary)}} component representing an axis.&#10;
";

			/// <inheritdoc />
			public string Name => NAME;
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => NORMATIVE_VERSION;
			
			/// <inheritdoc />
			public string DeprecatedVersion => DEPRECATED_VERSION;
			
			/// <inheritdoc />
			public string Summary => SUMMARY;
		}
		private BLOCKValue _BLOCK;
		/// <inheritdoc cref="BLOCKValue" path="/summary" />
		public BLOCKValue BLOCK => _BLOCK ?? (_BLOCK = new BLOCKValue());

		/// <summary>﻿line of code or command being executed by a <see cref="Controller">Controller</see> entity.<br /><br /><br />
		/// Value for EventEnum.<br/>
		/// <br/>See also <seealso cref="EventEnum">EventEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		public sealed class BLOCKValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="BLOCKValue.Name" /></summary>
			public const string NAME = "BLOCK";
			/// <summary>Constant value for <see cref="BLOCKValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.0";
			/// <summary>Constant value for <see cref="BLOCKValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="BLOCKValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;line of code or command being executed by a {{block(Controller)}} entity.&#10;
";

			/// <inheritdoc />
			public string Name => NAME;
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => NORMATIVE_VERSION;
			
			/// <inheritdoc />
			public string DeprecatedVersion => DEPRECATED_VERSION;
			
			/// <inheritdoc />
			public string Summary => SUMMARY;
		}
		private BLOCK_COUNTValue _BLOCK_COUNT;
		/// <inheritdoc cref="BLOCK_COUNTValue" path="/summary" />
		public BLOCK_COUNTValue BLOCK_COUNT => _BLOCK_COUNT ?? (_BLOCK_COUNT = new BLOCK_COUNTValue());

		/// <summary>﻿total count of the number of blocks of program code that have been executed since execution started.<br /><br /><br />
		/// Value for EventEnum.<br/>
		/// <br/>See also <seealso cref="EventEnum">EventEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		public sealed class BLOCK_COUNTValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="BLOCK_COUNTValue.Name" /></summary>
			public const string NAME = "BLOCK_COUNT";
			/// <summary>Constant value for <see cref="BLOCK_COUNTValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.4";
			/// <summary>Constant value for <see cref="BLOCK_COUNTValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="BLOCK_COUNTValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;total count of the number of blocks of program code that have been executed since execution started.&#10;
";

			/// <inheritdoc />
			public string Name => NAME;
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => NORMATIVE_VERSION;
			
			/// <inheritdoc />
			public string DeprecatedVersion => DEPRECATED_VERSION;
			
			/// <inheritdoc />
			public string Summary => SUMMARY;
		}
		private CHUCK_INTERLOCKValue _CHUCK_INTERLOCK;
		/// <inheritdoc cref="CHUCK_INTERLOCKValue" path="/summary" />
		public CHUCK_INTERLOCKValue CHUCK_INTERLOCK => _CHUCK_INTERLOCK ?? (_CHUCK_INTERLOCK = new CHUCK_INTERLOCKValue());

		/// <summary>﻿state of an interlock function or control logic state intended to prevent the associated <see cref="Chuck">Chuck</see> component from being operated.<br /><br /><br />
		/// Value for EventEnum.<br/>
		/// <br/>See also <seealso cref="EventEnum">EventEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		public sealed class CHUCK_INTERLOCKValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="CHUCK_INTERLOCKValue.Name" /></summary>
			public const string NAME = "CHUCK_INTERLOCK";
			/// <summary>Constant value for <see cref="CHUCK_INTERLOCKValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.3";
			/// <summary>Constant value for <see cref="CHUCK_INTERLOCKValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="CHUCK_INTERLOCKValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;state of an interlock function or control logic state intended to prevent the associated {{block(Chuck)}} component from being operated.&#10;
";

			/// <inheritdoc />
			public string Name => NAME;
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => NORMATIVE_VERSION;
			
			/// <inheritdoc />
			public string DeprecatedVersion => DEPRECATED_VERSION;
			
			/// <inheritdoc />
			public string Summary => SUMMARY;
		}
		private CHUCK_STATEValue _CHUCK_STATE;
		/// <inheritdoc cref="CHUCK_STATEValue" path="/summary" />
		public CHUCK_STATEValue CHUCK_STATE => _CHUCK_STATE ?? (_CHUCK_STATE = new CHUCK_STATEValue());

		/// <summary>﻿operating state of a mechanism that holds a part or stock material during a manufacturing process. <br /><br />It may also represent a mechanism that holds any other mechanism in place within a piece of equipment.<br /><br /><br />
		/// Value for EventEnum.<br/>
		/// <br/>See also <seealso cref="EventEnum">EventEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		public sealed class CHUCK_STATEValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="CHUCK_STATEValue.Name" /></summary>
			public const string NAME = "CHUCK_STATE";
			/// <summary>Constant value for <see cref="CHUCK_STATEValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.3";
			/// <summary>Constant value for <see cref="CHUCK_STATEValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="CHUCK_STATEValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;operating state of a mechanism that holds a part or stock material during a manufacturing process. 

It may also represent a mechanism that holds any other mechanism in place within a piece of equipment.&#10;
";

			/// <inheritdoc />
			public string Name => NAME;
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => NORMATIVE_VERSION;
			
			/// <inheritdoc />
			public string DeprecatedVersion => DEPRECATED_VERSION;
			
			/// <inheritdoc />
			public string Summary => SUMMARY;
		}
		private CODEValue _CODE;
		/// <inheritdoc cref="CODEValue" path="/summary" />
		public CODEValue CODE => _CODE ?? (_CODE = new CODEValue());

		/// <summary>﻿programmatic code being executed.<br /><br /><b>DEPRECATED</b> in <i>Version 1.1</i>.<br /><br /><br />
		/// Value for EventEnum.<br/>
		/// <br/>See also <seealso cref="EventEnum">EventEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		public sealed class CODEValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="CODEValue.Name" /></summary>
			public const string NAME = "CODE";
			/// <summary>Constant value for <see cref="CODEValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.0";
			/// <summary>Constant value for <see cref="CODEValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "1.1";
			/// <summary>Constant value for <see cref="CODEValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;programmatic code being executed.

**DEPRECATED** in *Version 1.1*.&#10;
";

			/// <inheritdoc />
			public string Name => NAME;
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => NORMATIVE_VERSION;
			
			/// <inheritdoc />
			public string DeprecatedVersion => DEPRECATED_VERSION;
			
			/// <inheritdoc />
			public string Summary => SUMMARY;
		}
		private COMPOSITION_STATEValue _COMPOSITION_STATE;
		/// <inheritdoc cref="COMPOSITION_STATEValue" path="/summary" />
		public COMPOSITION_STATEValue COMPOSITION_STATE => _COMPOSITION_STATE ?? (_COMPOSITION_STATE = new COMPOSITION_STATEValue());

		/// <summary>﻿operating state of a mechanism represented by a <see cref="Composition">Composition</see> entity.<br /><br /><br />
		/// Value for EventEnum.<br/>
		/// <br/>See also <seealso cref="EventEnum">EventEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		public sealed class COMPOSITION_STATEValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="COMPOSITION_STATEValue.Name" /></summary>
			public const string NAME = "COMPOSITION_STATE";
			/// <summary>Constant value for <see cref="COMPOSITION_STATEValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.4";
			/// <summary>Constant value for <see cref="COMPOSITION_STATEValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="COMPOSITION_STATEValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;operating state of a mechanism represented by a {{block(Composition)}} entity.&#10;
";

			/// <inheritdoc />
			public string Name => NAME;
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => NORMATIVE_VERSION;
			
			/// <inheritdoc />
			public string DeprecatedVersion => DEPRECATED_VERSION;
			
			/// <inheritdoc />
			public string Summary => SUMMARY;
		}
		private CONTROLLER_MODEValue _CONTROLLER_MODE;
		/// <inheritdoc cref="CONTROLLER_MODEValue" path="/summary" />
		public CONTROLLER_MODEValue CONTROLLER_MODE => _CONTROLLER_MODE ?? (_CONTROLLER_MODE = new CONTROLLER_MODEValue());

		/// <summary>﻿current mode of the <see cref="Controller">Controller</see> component.<br /><br /><br />
		/// Value for EventEnum.<br/>
		/// <br/>See also <seealso cref="EventEnum">EventEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		public sealed class CONTROLLER_MODEValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="CONTROLLER_MODEValue.Name" /></summary>
			public const string NAME = "CONTROLLER_MODE";
			/// <summary>Constant value for <see cref="CONTROLLER_MODEValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.0";
			/// <summary>Constant value for <see cref="CONTROLLER_MODEValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="CONTROLLER_MODEValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;current mode of the {{block(Controller)}} component.&#10;
";

			/// <inheritdoc />
			public string Name => NAME;
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => NORMATIVE_VERSION;
			
			/// <inheritdoc />
			public string DeprecatedVersion => DEPRECATED_VERSION;
			
			/// <inheritdoc />
			public string Summary => SUMMARY;
		}
		private CONTROLLER_MODE_OVERRIDEValue _CONTROLLER_MODE_OVERRIDE;
		/// <inheritdoc cref="CONTROLLER_MODE_OVERRIDEValue" path="/summary" />
		public CONTROLLER_MODE_OVERRIDEValue CONTROLLER_MODE_OVERRIDE => _CONTROLLER_MODE_OVERRIDE ?? (_CONTROLLER_MODE_OVERRIDE = new CONTROLLER_MODE_OVERRIDEValue());

		/// <summary>﻿setting or operator selection that changes the behavior of a piece of equipment.<br /><br /><br />
		/// Value for EventEnum.<br/>
		/// <br/>See also <seealso cref="EventEnum">EventEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		public sealed class CONTROLLER_MODE_OVERRIDEValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="CONTROLLER_MODE_OVERRIDEValue.Name" /></summary>
			public const string NAME = "CONTROLLER_MODE_OVERRIDE";
			/// <summary>Constant value for <see cref="CONTROLLER_MODE_OVERRIDEValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.4";
			/// <summary>Constant value for <see cref="CONTROLLER_MODE_OVERRIDEValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="CONTROLLER_MODE_OVERRIDEValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;setting or operator selection that changes the behavior of a piece of equipment.&#10;
";

			/// <inheritdoc />
			public string Name => NAME;
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => NORMATIVE_VERSION;
			
			/// <inheritdoc />
			public string DeprecatedVersion => DEPRECATED_VERSION;
			
			/// <inheritdoc />
			public string Summary => SUMMARY;
		}
		private COUPLED_AXESValue _COUPLED_AXES;
		/// <inheritdoc cref="COUPLED_AXESValue" path="/summary" />
		public COUPLED_AXESValue COUPLED_AXES => _COUPLED_AXES ?? (_COUPLED_AXES = new COUPLED_AXESValue());

		/// <summary>﻿set of associated axes.<br /><br /><br />
		/// Value for EventEnum.<br/>
		/// <br/>See also <seealso cref="EventEnum">EventEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		public sealed class COUPLED_AXESValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="COUPLED_AXESValue.Name" /></summary>
			public const string NAME = "COUPLED_AXES";
			/// <summary>Constant value for <see cref="COUPLED_AXESValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.2";
			/// <summary>Constant value for <see cref="COUPLED_AXESValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="COUPLED_AXESValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;set of associated axes.&#10;
";

			/// <inheritdoc />
			public string Name => NAME;
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => NORMATIVE_VERSION;
			
			/// <inheritdoc />
			public string DeprecatedVersion => DEPRECATED_VERSION;
			
			/// <inheritdoc />
			public string Summary => SUMMARY;
		}
		private DATE_CODEValue _DATE_CODE;
		/// <inheritdoc cref="DATE_CODEValue" path="/summary" />
		public DATE_CODEValue DATE_CODE => _DATE_CODE ?? (_DATE_CODE = new DATE_CODEValue());

		/// <summary>﻿time and date code associated with a material or other physical item.<br /><br /><br />
		/// Value for EventEnum.<br/>
		/// <br/>See also <seealso cref="EventEnum">EventEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		public sealed class DATE_CODEValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="DATE_CODEValue.Name" /></summary>
			public const string NAME = "DATE_CODE";
			/// <summary>Constant value for <see cref="DATE_CODEValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.5";
			/// <summary>Constant value for <see cref="DATE_CODEValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="DATE_CODEValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;time and date code associated with a material or other physical item.&#10;
";

			/// <inheritdoc />
			public string Name => NAME;
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => NORMATIVE_VERSION;
			
			/// <inheritdoc />
			public string DeprecatedVersion => DEPRECATED_VERSION;
			
			/// <inheritdoc />
			public string Summary => SUMMARY;
		}
		private DEVICE_UUIDValue _DEVICE_UUID;
		/// <inheritdoc cref="DEVICE_UUIDValue" path="/summary" />
		public DEVICE_UUIDValue DEVICE_UUID => _DEVICE_UUID ?? (_DEVICE_UUID = new DEVICE_UUIDValue());

		/// <summary>﻿identifier of another piece of equipment that is temporarily associated with a component of this piece of equipment to perform a particular function.<br /><br /><br />
		/// Value for EventEnum.<br/>
		/// <br/>See also <seealso cref="EventEnum">EventEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		public sealed class DEVICE_UUIDValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="DEVICE_UUIDValue.Name" /></summary>
			public const string NAME = "DEVICE_UUID";
			/// <summary>Constant value for <see cref="DEVICE_UUIDValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.5";
			/// <summary>Constant value for <see cref="DEVICE_UUIDValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="DEVICE_UUIDValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;identifier of another piece of equipment that is temporarily associated with a component of this piece of equipment to perform a particular function.&#10;
";

			/// <inheritdoc />
			public string Name => NAME;
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => NORMATIVE_VERSION;
			
			/// <inheritdoc />
			public string DeprecatedVersion => DEPRECATED_VERSION;
			
			/// <inheritdoc />
			public string Summary => SUMMARY;
		}
		private DIRECTIONValue _DIRECTION;
		/// <inheritdoc cref="DIRECTIONValue" path="/summary" />
		public DIRECTIONValue DIRECTION => _DIRECTION ?? (_DIRECTION = new DIRECTIONValue());

		/// <summary>﻿direction of motion.<br /><br /><br />
		/// Value for EventEnum.<br/>
		/// <br/>See also <seealso cref="EventEnum">EventEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		public sealed class DIRECTIONValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="DIRECTIONValue.Name" /></summary>
			public const string NAME = "DIRECTION";
			/// <summary>Constant value for <see cref="DIRECTIONValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.0";
			/// <summary>Constant value for <see cref="DIRECTIONValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="DIRECTIONValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;direction of motion.&#10;
";

			/// <inheritdoc />
			public string Name => NAME;
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => NORMATIVE_VERSION;
			
			/// <inheritdoc />
			public string DeprecatedVersion => DEPRECATED_VERSION;
			
			/// <inheritdoc />
			public string Summary => SUMMARY;
		}
		private DOOR_STATEValue _DOOR_STATE;
		/// <inheritdoc cref="DOOR_STATEValue" path="/summary" />
		public DOOR_STATEValue DOOR_STATE => _DOOR_STATE ?? (_DOOR_STATE = new DOOR_STATEValue());

		/// <summary>﻿operational state of a <see cref="Door">Door</see> component or composition element.<br /><br /><br />
		/// Value for EventEnum.<br/>
		/// <br/>See also <seealso cref="EventEnum">EventEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		public sealed class DOOR_STATEValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="DOOR_STATEValue.Name" /></summary>
			public const string NAME = "DOOR_STATE";
			/// <summary>Constant value for <see cref="DOOR_STATEValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.1";
			/// <summary>Constant value for <see cref="DOOR_STATEValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="DOOR_STATEValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;operational state of a {{block(Door)}} component or composition element.&#10;
";

			/// <inheritdoc />
			public string Name => NAME;
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => NORMATIVE_VERSION;
			
			/// <inheritdoc />
			public string DeprecatedVersion => DEPRECATED_VERSION;
			
			/// <inheritdoc />
			public string Summary => SUMMARY;
		}
		private EMERGENCY_STOPValue _EMERGENCY_STOP;
		/// <inheritdoc cref="EMERGENCY_STOPValue" path="/summary" />
		public EMERGENCY_STOPValue EMERGENCY_STOP => _EMERGENCY_STOP ?? (_EMERGENCY_STOP = new EMERGENCY_STOPValue());

		/// <summary>﻿state of the emergency stop signal for a piece of equipment, controller path, or any other component or subsystem of a piece of equipment.<br /><br /><br />
		/// Value for EventEnum.<br/>
		/// <br/>See also <seealso cref="EventEnum">EventEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		public sealed class EMERGENCY_STOPValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="EMERGENCY_STOPValue.Name" /></summary>
			public const string NAME = "EMERGENCY_STOP";
			/// <summary>Constant value for <see cref="EMERGENCY_STOPValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.1";
			/// <summary>Constant value for <see cref="EMERGENCY_STOPValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="EMERGENCY_STOPValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;state of the emergency stop signal for a piece of equipment, controller path, or any other component or subsystem of a piece of equipment.&#10;
";

			/// <inheritdoc />
			public string Name => NAME;
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => NORMATIVE_VERSION;
			
			/// <inheritdoc />
			public string DeprecatedVersion => DEPRECATED_VERSION;
			
			/// <inheritdoc />
			public string Summary => SUMMARY;
		}
		private END_OF_BARValue _END_OF_BAR;
		/// <inheritdoc cref="END_OF_BARValue" path="/summary" />
		public END_OF_BARValue END_OF_BAR => _END_OF_BAR ?? (_END_OF_BAR = new END_OF_BARValue());

		/// <summary>﻿indication of whether the end of a piece of bar stock being feed by a bar feeder has been reached.<br /><br /><br />
		/// Value for EventEnum.<br/>
		/// <br/>See also <seealso cref="EventEnum">EventEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		public sealed class END_OF_BARValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="END_OF_BARValue.Name" /></summary>
			public const string NAME = "END_OF_BAR";
			/// <summary>Constant value for <see cref="END_OF_BARValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.3";
			/// <summary>Constant value for <see cref="END_OF_BARValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="END_OF_BARValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;indication of whether the end of a piece of bar stock being feed by a bar feeder has been reached.&#10;
";

			/// <inheritdoc />
			public string Name => NAME;
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => NORMATIVE_VERSION;
			
			/// <inheritdoc />
			public string DeprecatedVersion => DEPRECATED_VERSION;
			
			/// <inheritdoc />
			public string Summary => SUMMARY;
		}
		private EQUIPMENT_MODEValue _EQUIPMENT_MODE;
		/// <inheritdoc cref="EQUIPMENT_MODEValue" path="/summary" />
		public EQUIPMENT_MODEValue EQUIPMENT_MODE => _EQUIPMENT_MODE ?? (_EQUIPMENT_MODE = new EQUIPMENT_MODEValue());

		/// <summary>﻿indication that a piece of equipment, or a sub-part of a piece of equipment, is performing specific types of activities.<br /><br /><br />
		/// Value for EventEnum.<br/>
		/// <br/>See also <seealso cref="EventEnum">EventEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		public sealed class EQUIPMENT_MODEValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="EQUIPMENT_MODEValue.Name" /></summary>
			public const string NAME = "EQUIPMENT_MODE";
			/// <summary>Constant value for <see cref="EQUIPMENT_MODEValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.4";
			/// <summary>Constant value for <see cref="EQUIPMENT_MODEValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="EQUIPMENT_MODEValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;indication that a piece of equipment, or a sub-part of a piece of equipment, is performing specific types of activities.&#10;
";

			/// <inheritdoc />
			public string Name => NAME;
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => NORMATIVE_VERSION;
			
			/// <inheritdoc />
			public string DeprecatedVersion => DEPRECATED_VERSION;
			
			/// <inheritdoc />
			public string Summary => SUMMARY;
		}
		private EXECUTIONValue _EXECUTION;
		/// <inheritdoc cref="EXECUTIONValue" path="/summary" />
		public EXECUTIONValue EXECUTION => _EXECUTION ?? (_EXECUTION = new EXECUTIONValue());

		/// <summary>﻿operating state of a <see cref="Component">Component</see>.<br /><br /><br />
		/// Value for EventEnum.<br/>
		/// <br/>See also <seealso cref="EventEnum">EventEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		public sealed class EXECUTIONValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="EXECUTIONValue.Name" /></summary>
			public const string NAME = "EXECUTION";
			/// <summary>Constant value for <see cref="EXECUTIONValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.0";
			/// <summary>Constant value for <see cref="EXECUTIONValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="EXECUTIONValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;operating state of a {{block(Component)}}.&#10;
";

			/// <inheritdoc />
			public string Name => NAME;
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => NORMATIVE_VERSION;
			
			/// <inheritdoc />
			public string DeprecatedVersion => DEPRECATED_VERSION;
			
			/// <inheritdoc />
			public string Summary => SUMMARY;
		}
		private FUNCTIONAL_MODEValue _FUNCTIONAL_MODE;
		/// <inheritdoc cref="FUNCTIONAL_MODEValue" path="/summary" />
		public FUNCTIONAL_MODEValue FUNCTIONAL_MODE => _FUNCTIONAL_MODE ?? (_FUNCTIONAL_MODE = new FUNCTIONAL_MODEValue());

		/// <summary>﻿current intended production status of the <see cref="Component">Component</see>.<br /><br /><br />
		/// Value for EventEnum.<br/>
		/// <br/>See also <seealso cref="EventEnum">EventEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		public sealed class FUNCTIONAL_MODEValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="FUNCTIONAL_MODEValue.Name" /></summary>
			public const string NAME = "FUNCTIONAL_MODE";
			/// <summary>Constant value for <see cref="FUNCTIONAL_MODEValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.3";
			/// <summary>Constant value for <see cref="FUNCTIONAL_MODEValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="FUNCTIONAL_MODEValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;current intended production status of the {{block(Component)}}.&#10;
";

			/// <inheritdoc />
			public string Name => NAME;
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => NORMATIVE_VERSION;
			
			/// <inheritdoc />
			public string DeprecatedVersion => DEPRECATED_VERSION;
			
			/// <inheritdoc />
			public string Summary => SUMMARY;
		}
		private HARDNESSValue _HARDNESS;
		/// <inheritdoc cref="HARDNESSValue" path="/summary" />
		public HARDNESSValue HARDNESS => _HARDNESS ?? (_HARDNESS = new HARDNESSValue());

		/// <summary>﻿hardness of a material.<br /><br /><br />
		/// Value for EventEnum.<br/>
		/// <br/>See also <seealso cref="EventEnum">EventEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		public sealed class HARDNESSValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="HARDNESSValue.Name" /></summary>
			public const string NAME = "HARDNESS";
			/// <summary>Constant value for <see cref="HARDNESSValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.4";
			/// <summary>Constant value for <see cref="HARDNESSValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="HARDNESSValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;hardness of a material.&#10;
";

			/// <inheritdoc />
			public string Name => NAME;
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => NORMATIVE_VERSION;
			
			/// <inheritdoc />
			public string DeprecatedVersion => DEPRECATED_VERSION;
			
			/// <inheritdoc />
			public string Summary => SUMMARY;
		}
		private LINEValue _LINE;
		/// <inheritdoc cref="LINEValue" path="/summary" />
		public LINEValue LINE => _LINE ?? (_LINE = new LINEValue());

		/// <summary>﻿current line of code being executed.<br /><br /><b>DEPRECATED</b> in <i>Version 1.4.0</i>.<br /><br /><br />
		/// Value for EventEnum.<br/>
		/// <br/>See also <seealso cref="EventEnum">EventEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		public sealed class LINEValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="LINEValue.Name" /></summary>
			public const string NAME = "LINE";
			/// <summary>Constant value for <see cref="LINEValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.0";
			/// <summary>Constant value for <see cref="LINEValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "1.4";
			/// <summary>Constant value for <see cref="LINEValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;current line of code being executed.

**DEPRECATED** in *Version 1.4.0*.&#10;
";

			/// <inheritdoc />
			public string Name => NAME;
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => NORMATIVE_VERSION;
			
			/// <inheritdoc />
			public string DeprecatedVersion => DEPRECATED_VERSION;
			
			/// <inheritdoc />
			public string Summary => SUMMARY;
		}
		private LINE_LABELValue _LINE_LABEL;
		/// <inheritdoc cref="LINE_LABELValue" path="/summary" />
		public LINE_LABELValue LINE_LABEL => _LINE_LABEL ?? (_LINE_LABEL = new LINE_LABELValue());

		/// <summary>﻿identifier for a <see cref="Block">Block</see> of code in a <see cref="Program">Program</see>.<br /><br /><br />
		/// Value for EventEnum.<br/>
		/// <br/>See also <seealso cref="EventEnum">EventEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		public sealed class LINE_LABELValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="LINE_LABELValue.Name" /></summary>
			public const string NAME = "LINE_LABEL";
			/// <summary>Constant value for <see cref="LINE_LABELValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.4";
			/// <summary>Constant value for <see cref="LINE_LABELValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="LINE_LABELValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;identifier for a {{block(Block)}} of code in a {{block(Program)}}.&#10;
";

			/// <inheritdoc />
			public string Name => NAME;
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => NORMATIVE_VERSION;
			
			/// <inheritdoc />
			public string DeprecatedVersion => DEPRECATED_VERSION;
			
			/// <inheritdoc />
			public string Summary => SUMMARY;
		}
		private LINE_NUMBERValue _LINE_NUMBER;
		/// <inheritdoc cref="LINE_NUMBERValue" path="/summary" />
		public LINE_NUMBERValue LINE_NUMBER => _LINE_NUMBER ?? (_LINE_NUMBER = new LINE_NUMBERValue());

		/// <summary>﻿position of a block of program code within a control program.<br /><br /><br />
		/// Value for EventEnum.<br/>
		/// <br/>See also <seealso cref="EventEnum">EventEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		public sealed class LINE_NUMBERValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="LINE_NUMBERValue.Name" /></summary>
			public const string NAME = "LINE_NUMBER";
			/// <summary>Constant value for <see cref="LINE_NUMBERValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.4";
			/// <summary>Constant value for <see cref="LINE_NUMBERValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="LINE_NUMBERValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;position of a block of program code within a control program.&#10;
";

			/// <inheritdoc />
			public string Name => NAME;
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => NORMATIVE_VERSION;
			
			/// <inheritdoc />
			public string DeprecatedVersion => DEPRECATED_VERSION;
			
			/// <inheritdoc />
			public string Summary => SUMMARY;
		}
		private MATERIALValue _MATERIAL;
		/// <inheritdoc cref="MATERIALValue" path="/summary" />
		public MATERIALValue MATERIAL => _MATERIAL ?? (_MATERIAL = new MATERIALValue());

		/// <summary>﻿identifier of a material used or consumed in the manufacturing process.<br /><br /><br />
		/// Value for EventEnum.<br/>
		/// <br/>See also <seealso cref="EventEnum">EventEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		public sealed class MATERIALValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="MATERIALValue.Name" /></summary>
			public const string NAME = "MATERIAL";
			/// <summary>Constant value for <see cref="MATERIALValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.4";
			/// <summary>Constant value for <see cref="MATERIALValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="MATERIALValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;identifier of a material used or consumed in the manufacturing process.&#10;
";

			/// <inheritdoc />
			public string Name => NAME;
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => NORMATIVE_VERSION;
			
			/// <inheritdoc />
			public string DeprecatedVersion => DEPRECATED_VERSION;
			
			/// <inheritdoc />
			public string Summary => SUMMARY;
		}
		private MATERIAL_LAYERValue _MATERIAL_LAYER;
		/// <inheritdoc cref="MATERIAL_LAYERValue" path="/summary" />
		public MATERIAL_LAYERValue MATERIAL_LAYER => _MATERIAL_LAYER ?? (_MATERIAL_LAYER = new MATERIAL_LAYERValue());

		/// <summary>﻿identifies the layers of material applied to a part or product as part of an additive manufacturing process.<br /><br /><br />
		/// Value for EventEnum.<br/>
		/// <br/>See also <seealso cref="EventEnum">EventEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		public sealed class MATERIAL_LAYERValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="MATERIAL_LAYERValue.Name" /></summary>
			public const string NAME = "MATERIAL_LAYER";
			/// <summary>Constant value for <see cref="MATERIAL_LAYERValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.5";
			/// <summary>Constant value for <see cref="MATERIAL_LAYERValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="MATERIAL_LAYERValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;identifies the layers of material applied to a part or product as part of an additive manufacturing process.&#10;
";

			/// <inheritdoc />
			public string Name => NAME;
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => NORMATIVE_VERSION;
			
			/// <inheritdoc />
			public string DeprecatedVersion => DEPRECATED_VERSION;
			
			/// <inheritdoc />
			public string Summary => SUMMARY;
		}
		private MESSAGEValue _MESSAGE;
		/// <inheritdoc cref="MESSAGEValue" path="/summary" />
		public MESSAGEValue MESSAGE => _MESSAGE ?? (_MESSAGE = new MESSAGEValue());

		/// <summary>﻿information to be transferred from a piece of equipment to a client software application.<br /><br /><br />
		/// Value for EventEnum.<br/>
		/// <br/>See also <seealso cref="EventEnum">EventEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		public sealed class MESSAGEValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="MESSAGEValue.Name" /></summary>
			public const string NAME = "MESSAGE";
			/// <summary>Constant value for <see cref="MESSAGEValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.1";
			/// <summary>Constant value for <see cref="MESSAGEValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="MESSAGEValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;information to be transferred from a piece of equipment to a client software application.&#10;
";

			/// <inheritdoc />
			public string Name => NAME;
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => NORMATIVE_VERSION;
			
			/// <inheritdoc />
			public string DeprecatedVersion => DEPRECATED_VERSION;
			
			/// <inheritdoc />
			public string Summary => SUMMARY;
		}
		private OPERATOR_IDValue _OPERATOR_ID;
		/// <inheritdoc cref="OPERATOR_IDValue" path="/summary" />
		public OPERATOR_IDValue OPERATOR_ID => _OPERATOR_ID ?? (_OPERATOR_ID = new OPERATOR_IDValue());

		/// <summary>﻿identifier of the person currently responsible for operating the piece of equipment.<br /><br /><br />
		/// Value for EventEnum.<br/>
		/// <br/>See also <seealso cref="EventEnum">EventEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		public sealed class OPERATOR_IDValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="OPERATOR_IDValue.Name" /></summary>
			public const string NAME = "OPERATOR_ID";
			/// <summary>Constant value for <see cref="OPERATOR_IDValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.3";
			/// <summary>Constant value for <see cref="OPERATOR_IDValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="OPERATOR_IDValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;identifier of the person currently responsible for operating the piece of equipment.&#10;
";

			/// <inheritdoc />
			public string Name => NAME;
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => NORMATIVE_VERSION;
			
			/// <inheritdoc />
			public string DeprecatedVersion => DEPRECATED_VERSION;
			
			/// <inheritdoc />
			public string Summary => SUMMARY;
		}
		private PALLET_IDValue _PALLET_ID;
		/// <inheritdoc cref="PALLET_IDValue" path="/summary" />
		public PALLET_IDValue PALLET_ID => _PALLET_ID ?? (_PALLET_ID = new PALLET_IDValue());

		/// <summary>﻿identifier for a pallet.<br /><br /><br />
		/// Value for EventEnum.<br/>
		/// <br/>See also <seealso cref="EventEnum">EventEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		public sealed class PALLET_IDValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="PALLET_IDValue.Name" /></summary>
			public const string NAME = "PALLET_ID";
			/// <summary>Constant value for <see cref="PALLET_IDValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.2";
			/// <summary>Constant value for <see cref="PALLET_IDValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="PALLET_IDValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;identifier for a pallet.&#10;
";

			/// <inheritdoc />
			public string Name => NAME;
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => NORMATIVE_VERSION;
			
			/// <inheritdoc />
			public string DeprecatedVersion => DEPRECATED_VERSION;
			
			/// <inheritdoc />
			public string Summary => SUMMARY;
		}
		private PART_COUNTValue _PART_COUNT;
		/// <inheritdoc cref="PART_COUNTValue" path="/summary" />
		public PART_COUNTValue PART_COUNT => _PART_COUNT ?? (_PART_COUNT = new PART_COUNTValue());

		/// <summary>﻿aggregate count of parts.<br /><br /><br />
		/// Value for EventEnum.<br/>
		/// <br/>See also <seealso cref="EventEnum">EventEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		public sealed class PART_COUNTValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="PART_COUNTValue.Name" /></summary>
			public const string NAME = "PART_COUNT";
			/// <summary>Constant value for <see cref="PART_COUNTValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.0";
			/// <summary>Constant value for <see cref="PART_COUNTValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="PART_COUNTValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;aggregate count of parts.&#10;
";

			/// <inheritdoc />
			public string Name => NAME;
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => NORMATIVE_VERSION;
			
			/// <inheritdoc />
			public string DeprecatedVersion => DEPRECATED_VERSION;
			
			/// <inheritdoc />
			public string Summary => SUMMARY;
		}
		private PART_DETECTValue _PART_DETECT;
		/// <inheritdoc cref="PART_DETECTValue" path="/summary" />
		public PART_DETECTValue PART_DETECT => _PART_DETECT ?? (_PART_DETECT = new PART_DETECTValue());

		/// <summary>﻿indication designating whether a part or work piece has been detected or is present.<br /><br /><br />
		/// Value for EventEnum.<br/>
		/// <br/>See also <seealso cref="EventEnum">EventEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		public sealed class PART_DETECTValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="PART_DETECTValue.Name" /></summary>
			public const string NAME = "PART_DETECT";
			/// <summary>Constant value for <see cref="PART_DETECTValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.5";
			/// <summary>Constant value for <see cref="PART_DETECTValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="PART_DETECTValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;indication designating whether a part or work piece has been detected or is present.&#10;
";

			/// <inheritdoc />
			public string Name => NAME;
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => NORMATIVE_VERSION;
			
			/// <inheritdoc />
			public string DeprecatedVersion => DEPRECATED_VERSION;
			
			/// <inheritdoc />
			public string Summary => SUMMARY;
		}
		private PART_IDValue _PART_ID;
		/// <inheritdoc cref="PART_IDValue" path="/summary" />
		public PART_IDValue PART_ID => _PART_ID ?? (_PART_ID = new PART_IDValue());

		/// <summary>﻿identifier of a part in a manufacturing operation.<br /><br /><br />
		/// Value for EventEnum.<br/>
		/// <br/>See also <seealso cref="EventEnum">EventEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		public sealed class PART_IDValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="PART_IDValue.Name" /></summary>
			public const string NAME = "PART_ID";
			/// <summary>Constant value for <see cref="PART_IDValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.1";
			/// <summary>Constant value for <see cref="PART_IDValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="PART_IDValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;identifier of a part in a manufacturing operation.&#10;
";

			/// <inheritdoc />
			public string Name => NAME;
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => NORMATIVE_VERSION;
			
			/// <inheritdoc />
			public string DeprecatedVersion => DEPRECATED_VERSION;
			
			/// <inheritdoc />
			public string Summary => SUMMARY;
		}
		private PART_NUMBERValue _PART_NUMBER;
		/// <inheritdoc cref="PART_NUMBERValue" path="/summary" />
		public PART_NUMBERValue PART_NUMBER => _PART_NUMBER ?? (_PART_NUMBER = new PART_NUMBERValue());

		/// <summary>﻿identifier of a part or product moving through the manufacturing process.<br /><br /><b>DEPRECATED</b> in <i>Version 1.7</i>. <c>PART_NUMBER</c> is now a <c>subType</c> of <c>PART_KIND_ID</c>.<br /><br /><br />
		/// Value for EventEnum.<br/>
		/// <br/>See also <seealso cref="EventEnum">EventEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		public sealed class PART_NUMBERValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="PART_NUMBERValue.Name" /></summary>
			public const string NAME = "PART_NUMBER";
			/// <summary>Constant value for <see cref="PART_NUMBERValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.4";
			/// <summary>Constant value for <see cref="PART_NUMBERValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "1.7";
			/// <summary>Constant value for <see cref="PART_NUMBERValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;identifier of a part or product moving through the manufacturing process.

**DEPRECATED** in *Version 1.7*. `PART_NUMBER` is now a `subType` of `PART_KIND_ID`.&#10;
";

			/// <inheritdoc />
			public string Name => NAME;
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => NORMATIVE_VERSION;
			
			/// <inheritdoc />
			public string DeprecatedVersion => DEPRECATED_VERSION;
			
			/// <inheritdoc />
			public string Summary => SUMMARY;
		}
		private PATH_FEEDRATE_OVERRIDEValue _PATH_FEEDRATE_OVERRIDE;
		/// <inheritdoc cref="PATH_FEEDRATE_OVERRIDEValue" path="/summary" />
		public PATH_FEEDRATE_OVERRIDEValue PATH_FEEDRATE_OVERRIDE => _PATH_FEEDRATE_OVERRIDE ?? (_PATH_FEEDRATE_OVERRIDE = new PATH_FEEDRATE_OVERRIDEValue());

		/// <summary>﻿value of a signal or calculation issued to adjust the feedrate for the axes associated with a <see cref="Path">Path</see> component that may represent a single axis or the coordinated movement of multiple axes.<br /><br /><br />
		/// Value for EventEnum.<br/>
		/// <br/>See also <seealso cref="EventEnum">EventEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		public sealed class PATH_FEEDRATE_OVERRIDEValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="PATH_FEEDRATE_OVERRIDEValue.Name" /></summary>
			public const string NAME = "PATH_FEEDRATE_OVERRIDE";
			/// <summary>Constant value for <see cref="PATH_FEEDRATE_OVERRIDEValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.3";
			/// <summary>Constant value for <see cref="PATH_FEEDRATE_OVERRIDEValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="PATH_FEEDRATE_OVERRIDEValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;value of a signal or calculation issued to adjust the feedrate for the axes associated with a {{block(Path)}} component that may represent a single axis or the coordinated movement of multiple axes.&#10;
";

			/// <inheritdoc />
			public string Name => NAME;
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => NORMATIVE_VERSION;
			
			/// <inheritdoc />
			public string DeprecatedVersion => DEPRECATED_VERSION;
			
			/// <inheritdoc />
			public string Summary => SUMMARY;
		}
		private PATH_MODEValue _PATH_MODE;
		/// <inheritdoc cref="PATH_MODEValue" path="/summary" />
		public PATH_MODEValue PATH_MODE => _PATH_MODE ?? (_PATH_MODE = new PATH_MODEValue());

		/// <summary>﻿describes the operational relationship between a <see cref="Path">Path</see> entity and another <see cref="Path">Path</see> entity for pieces of equipment comprised of multiple logical groupings of controlled axes or other logical operations.<br /><br /><br />
		/// Value for EventEnum.<br/>
		/// <br/>See also <seealso cref="EventEnum">EventEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		public sealed class PATH_MODEValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="PATH_MODEValue.Name" /></summary>
			public const string NAME = "PATH_MODE";
			/// <summary>Constant value for <see cref="PATH_MODEValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.1";
			/// <summary>Constant value for <see cref="PATH_MODEValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="PATH_MODEValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;describes the operational relationship between a {{block(Path)}} entity and another {{block(Path)}} entity for pieces of equipment comprised of multiple logical groupings of controlled axes or other logical operations.&#10;
";

			/// <inheritdoc />
			public string Name => NAME;
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => NORMATIVE_VERSION;
			
			/// <inheritdoc />
			public string DeprecatedVersion => DEPRECATED_VERSION;
			
			/// <inheritdoc />
			public string Summary => SUMMARY;
		}
		private POWER_STATEValue _POWER_STATE;
		/// <inheritdoc cref="POWER_STATEValue" path="/summary" />
		public POWER_STATEValue POWER_STATE => _POWER_STATE ?? (_POWER_STATE = new POWER_STATEValue());

		/// <summary>﻿indication of the status of the source of energy for an entity to allow it to perform its intended function or the state of an enabling signal providing permission for the entity to perform its functions.<br /><br /><br />
		/// Value for EventEnum.<br/>
		/// <br/>See also <seealso cref="EventEnum">EventEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		public sealed class POWER_STATEValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="POWER_STATEValue.Name" /></summary>
			public const string NAME = "POWER_STATE";
			/// <summary>Constant value for <see cref="POWER_STATEValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.1";
			/// <summary>Constant value for <see cref="POWER_STATEValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="POWER_STATEValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;indication of the status of the source of energy for an entity to allow it to perform its intended function or the state of an enabling signal providing permission for the entity to perform its functions.&#10;
";

			/// <inheritdoc />
			public string Name => NAME;
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => NORMATIVE_VERSION;
			
			/// <inheritdoc />
			public string DeprecatedVersion => DEPRECATED_VERSION;
			
			/// <inheritdoc />
			public string Summary => SUMMARY;
		}
		private POWER_STATUSValue _POWER_STATUS;
		/// <inheritdoc cref="POWER_STATUSValue" path="/summary" />
		public POWER_STATUSValue POWER_STATUS => _POWER_STATUS ?? (_POWER_STATUS = new POWER_STATUSValue());

		/// <summary>﻿status of the <see cref="Component">Component</see>.<br /><br /><b>DEPRECATED</b> in <i>Version 1.1.0</i>.<br /><br /><br />
		/// Value for EventEnum.<br/>
		/// <br/>See also <seealso cref="EventEnum">EventEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		public sealed class POWER_STATUSValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="POWER_STATUSValue.Name" /></summary>
			public const string NAME = "POWER_STATUS";
			/// <summary>Constant value for <see cref="POWER_STATUSValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.0";
			/// <summary>Constant value for <see cref="POWER_STATUSValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "1.1";
			/// <summary>Constant value for <see cref="POWER_STATUSValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;status of the {{block(Component)}}.

**DEPRECATED** in *Version 1.1.0*.&#10;
";

			/// <inheritdoc />
			public string Name => NAME;
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => NORMATIVE_VERSION;
			
			/// <inheritdoc />
			public string DeprecatedVersion => DEPRECATED_VERSION;
			
			/// <inheritdoc />
			public string Summary => SUMMARY;
		}
		private PROCESS_TIMEValue _PROCESS_TIME;
		/// <inheritdoc cref="PROCESS_TIMEValue" path="/summary" />
		public PROCESS_TIMEValue PROCESS_TIME => _PROCESS_TIME ?? (_PROCESS_TIME = new PROCESS_TIMEValue());

		/// <summary>﻿time and date associated with an activity or event.<br /><br /><br />
		/// Value for EventEnum.<br/>
		/// <br/>See also <seealso cref="EventEnum">EventEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		public sealed class PROCESS_TIMEValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="PROCESS_TIMEValue.Name" /></summary>
			public const string NAME = "PROCESS_TIME";
			/// <summary>Constant value for <see cref="PROCESS_TIMEValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.5";
			/// <summary>Constant value for <see cref="PROCESS_TIMEValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="PROCESS_TIMEValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;time and date associated with an activity or event.&#10;
";

			/// <inheritdoc />
			public string Name => NAME;
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => NORMATIVE_VERSION;
			
			/// <inheritdoc />
			public string DeprecatedVersion => DEPRECATED_VERSION;
			
			/// <inheritdoc />
			public string Summary => SUMMARY;
		}
		private PROGRAMValue _PROGRAM;
		/// <inheritdoc cref="PROGRAMValue" path="/summary" />
		public PROGRAMValue PROGRAM => _PROGRAM ?? (_PROGRAM = new PROGRAMValue());

		/// <summary>﻿name of the logic or motion program being executed by the <see cref="Controller">Controller</see> component.<br /><br /><br />
		/// Value for EventEnum.<br/>
		/// <br/>See also <seealso cref="EventEnum">EventEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		public sealed class PROGRAMValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="PROGRAMValue.Name" /></summary>
			public const string NAME = "PROGRAM";
			/// <summary>Constant value for <see cref="PROGRAMValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.0";
			/// <summary>Constant value for <see cref="PROGRAMValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="PROGRAMValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;name of the logic or motion program being executed by the {{block(Controller)}} component.&#10;
";

			/// <inheritdoc />
			public string Name => NAME;
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => NORMATIVE_VERSION;
			
			/// <inheritdoc />
			public string DeprecatedVersion => DEPRECATED_VERSION;
			
			/// <inheritdoc />
			public string Summary => SUMMARY;
		}
		private PROGRAM_COMMENTValue _PROGRAM_COMMENT;
		/// <inheritdoc cref="PROGRAM_COMMENTValue" path="/summary" />
		public PROGRAM_COMMENTValue PROGRAM_COMMENT => _PROGRAM_COMMENT ?? (_PROGRAM_COMMENT = new PROGRAM_COMMENTValue());

		/// <summary>﻿comment or non-executable statement in the control program.<br /><br /><br />
		/// Value for EventEnum.<br/>
		/// <br/>See also <seealso cref="EventEnum">EventEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		public sealed class PROGRAM_COMMENTValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="PROGRAM_COMMENTValue.Name" /></summary>
			public const string NAME = "PROGRAM_COMMENT";
			/// <summary>Constant value for <see cref="PROGRAM_COMMENTValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.3";
			/// <summary>Constant value for <see cref="PROGRAM_COMMENTValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="PROGRAM_COMMENTValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;comment or non-executable statement in the control program.&#10;
";

			/// <inheritdoc />
			public string Name => NAME;
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => NORMATIVE_VERSION;
			
			/// <inheritdoc />
			public string DeprecatedVersion => DEPRECATED_VERSION;
			
			/// <inheritdoc />
			public string Summary => SUMMARY;
		}
		private PROGRAM_EDITValue _PROGRAM_EDIT;
		/// <inheritdoc cref="PROGRAM_EDITValue" path="/summary" />
		public PROGRAM_EDITValue PROGRAM_EDIT => _PROGRAM_EDIT ?? (_PROGRAM_EDIT = new PROGRAM_EDITValue());

		/// <summary>﻿indication of the status of the <see cref="Controller">Controller</see> components program editing mode.<br /><br />A program may be edited while another is executed.<br /><br /><br />
		/// Value for EventEnum.<br/>
		/// <br/>See also <seealso cref="EventEnum">EventEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		public sealed class PROGRAM_EDITValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="PROGRAM_EDITValue.Name" /></summary>
			public const string NAME = "PROGRAM_EDIT";
			/// <summary>Constant value for <see cref="PROGRAM_EDITValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.3";
			/// <summary>Constant value for <see cref="PROGRAM_EDITValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="PROGRAM_EDITValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;indication of the status of the {{block(Controller)}} components program editing mode.

A program may be edited while another is executed.&#10;
";

			/// <inheritdoc />
			public string Name => NAME;
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => NORMATIVE_VERSION;
			
			/// <inheritdoc />
			public string DeprecatedVersion => DEPRECATED_VERSION;
			
			/// <inheritdoc />
			public string Summary => SUMMARY;
		}
		private PROGRAM_EDIT_NAMEValue _PROGRAM_EDIT_NAME;
		/// <inheritdoc cref="PROGRAM_EDIT_NAMEValue" path="/summary" />
		public PROGRAM_EDIT_NAMEValue PROGRAM_EDIT_NAME => _PROGRAM_EDIT_NAME ?? (_PROGRAM_EDIT_NAME = new PROGRAM_EDIT_NAMEValue());

		/// <summary>﻿name of the program being edited. <br /><br />This is used in conjunction with <see cref="ProgramEdit">ProgramEdit</see> when in <c>ACTIVE</c> state. <br /><br /><br />
		/// Value for EventEnum.<br/>
		/// <br/>See also <seealso cref="EventEnum">EventEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		public sealed class PROGRAM_EDIT_NAMEValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="PROGRAM_EDIT_NAMEValue.Name" /></summary>
			public const string NAME = "PROGRAM_EDIT_NAME";
			/// <summary>Constant value for <see cref="PROGRAM_EDIT_NAMEValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.3";
			/// <summary>Constant value for <see cref="PROGRAM_EDIT_NAMEValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="PROGRAM_EDIT_NAMEValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;name of the program being edited. 

This is used in conjunction with {{block(ProgramEdit)}} when in `ACTIVE` state. &#10;
";

			/// <inheritdoc />
			public string Name => NAME;
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => NORMATIVE_VERSION;
			
			/// <inheritdoc />
			public string DeprecatedVersion => DEPRECATED_VERSION;
			
			/// <inheritdoc />
			public string Summary => SUMMARY;
		}
		private PROGRAM_HEADERValue _PROGRAM_HEADER;
		/// <inheritdoc cref="PROGRAM_HEADERValue" path="/summary" />
		public PROGRAM_HEADERValue PROGRAM_HEADER => _PROGRAM_HEADER ?? (_PROGRAM_HEADER = new PROGRAM_HEADERValue());

		/// <summary>﻿non-executable header section of the control program.<br /><br /><br />
		/// Value for EventEnum.<br/>
		/// <br/>See also <seealso cref="EventEnum">EventEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		public sealed class PROGRAM_HEADERValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="PROGRAM_HEADERValue.Name" /></summary>
			public const string NAME = "PROGRAM_HEADER";
			/// <summary>Constant value for <see cref="PROGRAM_HEADERValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.3";
			/// <summary>Constant value for <see cref="PROGRAM_HEADERValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="PROGRAM_HEADERValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;non-executable header section of the control program.&#10;
";

			/// <inheritdoc />
			public string Name => NAME;
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => NORMATIVE_VERSION;
			
			/// <inheritdoc />
			public string DeprecatedVersion => DEPRECATED_VERSION;
			
			/// <inheritdoc />
			public string Summary => SUMMARY;
		}
		private PROGRAM_LOCATIONValue _PROGRAM_LOCATION;
		/// <inheritdoc cref="PROGRAM_LOCATIONValue" path="/summary" />
		public PROGRAM_LOCATIONValue PROGRAM_LOCATION => _PROGRAM_LOCATION ?? (_PROGRAM_LOCATION = new PROGRAM_LOCATIONValue());

		/// <summary>﻿<i>URI</i> for the source file associated with <see cref="Program">Program</see>.<br /><br /><br />
		/// Value for EventEnum.<br/>
		/// <br/>See also <seealso cref="EventEnum">EventEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		public sealed class PROGRAM_LOCATIONValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="PROGRAM_LOCATIONValue.Name" /></summary>
			public const string NAME = "PROGRAM_LOCATION";
			/// <summary>Constant value for <see cref="PROGRAM_LOCATIONValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.5";
			/// <summary>Constant value for <see cref="PROGRAM_LOCATIONValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="PROGRAM_LOCATIONValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;{{term(URI)}} for the source file associated with {{block(Program)}}.&#10;
";

			/// <inheritdoc />
			public string Name => NAME;
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => NORMATIVE_VERSION;
			
			/// <inheritdoc />
			public string DeprecatedVersion => DEPRECATED_VERSION;
			
			/// <inheritdoc />
			public string Summary => SUMMARY;
		}
		private PROGRAM_LOCATION_TYPEValue _PROGRAM_LOCATION_TYPE;
		/// <inheritdoc cref="PROGRAM_LOCATION_TYPEValue" path="/summary" />
		public PROGRAM_LOCATION_TYPEValue PROGRAM_LOCATION_TYPE => _PROGRAM_LOCATION_TYPE ?? (_PROGRAM_LOCATION_TYPE = new PROGRAM_LOCATION_TYPEValue());

		/// <summary>﻿defines whether the logic or motion program defined by <see cref="Program">Program</see> is being executed from the local memory of the controller or from an outside source.<br /><br /><br />
		/// Value for EventEnum.<br/>
		/// <br/>See also <seealso cref="EventEnum">EventEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		public sealed class PROGRAM_LOCATION_TYPEValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="PROGRAM_LOCATION_TYPEValue.Name" /></summary>
			public const string NAME = "PROGRAM_LOCATION_TYPE";
			/// <summary>Constant value for <see cref="PROGRAM_LOCATION_TYPEValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.5";
			/// <summary>Constant value for <see cref="PROGRAM_LOCATION_TYPEValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="PROGRAM_LOCATION_TYPEValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;defines whether the logic or motion program defined by {{block(Program)}} is being executed from the local memory of the controller or from an outside source.&#10;
";

			/// <inheritdoc />
			public string Name => NAME;
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => NORMATIVE_VERSION;
			
			/// <inheritdoc />
			public string DeprecatedVersion => DEPRECATED_VERSION;
			
			/// <inheritdoc />
			public string Summary => SUMMARY;
		}
		private PROGRAM_NEST_LEVELValue _PROGRAM_NEST_LEVEL;
		/// <inheritdoc cref="PROGRAM_NEST_LEVELValue" path="/summary" />
		public PROGRAM_NEST_LEVELValue PROGRAM_NEST_LEVEL => _PROGRAM_NEST_LEVEL ?? (_PROGRAM_NEST_LEVEL = new PROGRAM_NEST_LEVELValue());

		/// <summary>﻿indication of the nesting level within a control program that is associated with the code or instructions that is currently being executed.<br /><br /><br />
		/// Value for EventEnum.<br/>
		/// <br/>See also <seealso cref="EventEnum">EventEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		public sealed class PROGRAM_NEST_LEVELValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="PROGRAM_NEST_LEVELValue.Name" /></summary>
			public const string NAME = "PROGRAM_NEST_LEVEL";
			/// <summary>Constant value for <see cref="PROGRAM_NEST_LEVELValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.5";
			/// <summary>Constant value for <see cref="PROGRAM_NEST_LEVELValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="PROGRAM_NEST_LEVELValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;indication of the nesting level within a control program that is associated with the code or instructions that is currently being executed.&#10;
";

			/// <inheritdoc />
			public string Name => NAME;
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => NORMATIVE_VERSION;
			
			/// <inheritdoc />
			public string DeprecatedVersion => DEPRECATED_VERSION;
			
			/// <inheritdoc />
			public string Summary => SUMMARY;
		}
		private ROTARY_MODEValue _ROTARY_MODE;
		/// <inheritdoc cref="ROTARY_MODEValue" path="/summary" />
		public ROTARY_MODEValue ROTARY_MODE => _ROTARY_MODE ?? (_ROTARY_MODE = new ROTARY_MODEValue());

		/// <summary>﻿current operating mode for a <see cref="Rotary">Rotary</see> type axis.<br /><br /><br />
		/// Value for EventEnum.<br/>
		/// <br/>See also <seealso cref="EventEnum">EventEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		public sealed class ROTARY_MODEValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="ROTARY_MODEValue.Name" /></summary>
			public const string NAME = "ROTARY_MODE";
			/// <summary>Constant value for <see cref="ROTARY_MODEValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.1";
			/// <summary>Constant value for <see cref="ROTARY_MODEValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="ROTARY_MODEValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;current operating mode for a {{block(Rotary)}} type axis.&#10;
";

			/// <inheritdoc />
			public string Name => NAME;
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => NORMATIVE_VERSION;
			
			/// <inheritdoc />
			public string DeprecatedVersion => DEPRECATED_VERSION;
			
			/// <inheritdoc />
			public string Summary => SUMMARY;
		}
		private ROTARY_VELOCITY_OVERRIDEValue _ROTARY_VELOCITY_OVERRIDE;
		/// <inheritdoc cref="ROTARY_VELOCITY_OVERRIDEValue" path="/summary" />
		public ROTARY_VELOCITY_OVERRIDEValue ROTARY_VELOCITY_OVERRIDE => _ROTARY_VELOCITY_OVERRIDE ?? (_ROTARY_VELOCITY_OVERRIDE = new ROTARY_VELOCITY_OVERRIDEValue());

		/// <summary>﻿percentage change to the velocity of the programmed velocity for a <see cref="Rotary">Rotary</see> axis.<br /><br /><br />
		/// Value for EventEnum.<br/>
		/// <br/>See also <seealso cref="EventEnum">EventEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		public sealed class ROTARY_VELOCITY_OVERRIDEValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="ROTARY_VELOCITY_OVERRIDEValue.Name" /></summary>
			public const string NAME = "ROTARY_VELOCITY_OVERRIDE";
			/// <summary>Constant value for <see cref="ROTARY_VELOCITY_OVERRIDEValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.3";
			/// <summary>Constant value for <see cref="ROTARY_VELOCITY_OVERRIDEValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="ROTARY_VELOCITY_OVERRIDEValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;percentage change to the velocity of the programmed velocity for a {{block(Rotary)}} axis.&#10;
";

			/// <inheritdoc />
			public string Name => NAME;
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => NORMATIVE_VERSION;
			
			/// <inheritdoc />
			public string DeprecatedVersion => DEPRECATED_VERSION;
			
			/// <inheritdoc />
			public string Summary => SUMMARY;
		}
		private SERIAL_NUMBERValue _SERIAL_NUMBER;
		/// <inheritdoc cref="SERIAL_NUMBERValue" path="/summary" />
		public SERIAL_NUMBERValue SERIAL_NUMBER => _SERIAL_NUMBER ?? (_SERIAL_NUMBER = new SERIAL_NUMBERValue());

		/// <summary>﻿serial number associated with a <see cref="Component">Component</see>, <see cref="Asset">Asset</see>, or <see cref="Device">Device</see>.<br /><br /><br />
		/// Value for EventEnum.<br/>
		/// <br/>See also <seealso cref="EventEnum">EventEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		public sealed class SERIAL_NUMBERValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="SERIAL_NUMBERValue.Name" /></summary>
			public const string NAME = "SERIAL_NUMBER";
			/// <summary>Constant value for <see cref="SERIAL_NUMBERValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.4";
			/// <summary>Constant value for <see cref="SERIAL_NUMBERValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="SERIAL_NUMBERValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;serial number associated with a {{block(Component)}}, {{block(Asset)}}, or {{block(Device)}}.&#10;
";

			/// <inheritdoc />
			public string Name => NAME;
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => NORMATIVE_VERSION;
			
			/// <inheritdoc />
			public string DeprecatedVersion => DEPRECATED_VERSION;
			
			/// <inheritdoc />
			public string Summary => SUMMARY;
		}
		private SPINDLE_INTERLOCKValue _SPINDLE_INTERLOCK;
		/// <inheritdoc cref="SPINDLE_INTERLOCKValue" path="/summary" />
		public SPINDLE_INTERLOCKValue SPINDLE_INTERLOCK => _SPINDLE_INTERLOCK ?? (_SPINDLE_INTERLOCK = new SPINDLE_INTERLOCKValue());

		/// <summary>﻿indication of the status of the spindle for a piece of equipment when power has been removed and it is free to rotate.<br /><br /><br />
		/// Value for EventEnum.<br/>
		/// <br/>See also <seealso cref="EventEnum">EventEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		public sealed class SPINDLE_INTERLOCKValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="SPINDLE_INTERLOCKValue.Name" /></summary>
			public const string NAME = "SPINDLE_INTERLOCK";
			/// <summary>Constant value for <see cref="SPINDLE_INTERLOCKValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.3";
			/// <summary>Constant value for <see cref="SPINDLE_INTERLOCKValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="SPINDLE_INTERLOCKValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;indication of the status of the spindle for a piece of equipment when power has been removed and it is free to rotate.&#10;
";

			/// <inheritdoc />
			public string Name => NAME;
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => NORMATIVE_VERSION;
			
			/// <inheritdoc />
			public string DeprecatedVersion => DEPRECATED_VERSION;
			
			/// <inheritdoc />
			public string Summary => SUMMARY;
		}
		private TOOL_ASSET_IDValue _TOOL_ASSET_ID;
		/// <inheritdoc cref="TOOL_ASSET_IDValue" path="/summary" />
		public TOOL_ASSET_IDValue TOOL_ASSET_ID => _TOOL_ASSET_ID ?? (_TOOL_ASSET_ID = new TOOL_ASSET_IDValue());

		/// <summary>﻿identifier of an individual tool asset.<br /><br /><br />
		/// Value for EventEnum.<br/>
		/// <br/>See also <seealso cref="EventEnum">EventEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		public sealed class TOOL_ASSET_IDValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="TOOL_ASSET_IDValue.Name" /></summary>
			public const string NAME = "TOOL_ASSET_ID";
			/// <summary>Constant value for <see cref="TOOL_ASSET_IDValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.2";
			/// <summary>Constant value for <see cref="TOOL_ASSET_IDValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="TOOL_ASSET_IDValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;identifier of an individual tool asset.&#10;
";

			/// <inheritdoc />
			public string Name => NAME;
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => NORMATIVE_VERSION;
			
			/// <inheritdoc />
			public string DeprecatedVersion => DEPRECATED_VERSION;
			
			/// <inheritdoc />
			public string Summary => SUMMARY;
		}
		private TOOL_GROUPValue _TOOL_GROUP;
		/// <inheritdoc cref="TOOL_GROUPValue" path="/summary" />
		public TOOL_GROUPValue TOOL_GROUP => _TOOL_GROUP ?? (_TOOL_GROUP = new TOOL_GROUPValue());

		/// <summary>﻿identifier for the tool group associated with a specific tool. Commonly used to designate spare tools.<br /><br /><br />
		/// Value for EventEnum.<br/>
		/// <br/>See also <seealso cref="EventEnum">EventEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		public sealed class TOOL_GROUPValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="TOOL_GROUPValue.Name" /></summary>
			public const string NAME = "TOOL_GROUP";
			/// <summary>Constant value for <see cref="TOOL_GROUPValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.5";
			/// <summary>Constant value for <see cref="TOOL_GROUPValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="TOOL_GROUPValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;identifier for the tool group associated with a specific tool. Commonly used to designate spare tools.&#10;
";

			/// <inheritdoc />
			public string Name => NAME;
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => NORMATIVE_VERSION;
			
			/// <inheritdoc />
			public string DeprecatedVersion => DEPRECATED_VERSION;
			
			/// <inheritdoc />
			public string Summary => SUMMARY;
		}
		private TOOL_IDValue _TOOL_ID;
		/// <inheritdoc cref="TOOL_IDValue" path="/summary" />
		public TOOL_IDValue TOOL_ID => _TOOL_ID ?? (_TOOL_ID = new TOOL_IDValue());

		/// <summary>﻿identifier of the tool currently in use for a given <c>Path</c>.<br /><br /><b>DEPRECATED</b> in <i>Version 1.2.0</i>.   See <c>TOOL_ASSET_ID</c>.<br /><br /><br />
		/// Value for EventEnum.<br/>
		/// <br/>See also <seealso cref="EventEnum">EventEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		public sealed class TOOL_IDValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="TOOL_IDValue.Name" /></summary>
			public const string NAME = "TOOL_ID";
			/// <summary>Constant value for <see cref="TOOL_IDValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.1";
			/// <summary>Constant value for <see cref="TOOL_IDValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "1.2";
			/// <summary>Constant value for <see cref="TOOL_IDValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;identifier of the tool currently in use for a given `Path`.

**DEPRECATED** in *Version 1.2.0*.   See `TOOL_ASSET_ID`.&#10;
";

			/// <inheritdoc />
			public string Name => NAME;
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => NORMATIVE_VERSION;
			
			/// <inheritdoc />
			public string DeprecatedVersion => DEPRECATED_VERSION;
			
			/// <inheritdoc />
			public string Summary => SUMMARY;
		}
		private TOOL_NUMBERValue _TOOL_NUMBER;
		/// <inheritdoc cref="TOOL_NUMBERValue" path="/summary" />
		public TOOL_NUMBERValue TOOL_NUMBER => _TOOL_NUMBER ?? (_TOOL_NUMBER = new TOOL_NUMBERValue());

		/// <summary>﻿identifier assigned by the <see cref="Controller">Controller</see> component to a cutting tool when in use by a piece of equipment.<br /><br /><br />
		/// Value for EventEnum.<br/>
		/// <br/>See also <seealso cref="EventEnum">EventEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		public sealed class TOOL_NUMBERValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="TOOL_NUMBERValue.Name" /></summary>
			public const string NAME = "TOOL_NUMBER";
			/// <summary>Constant value for <see cref="TOOL_NUMBERValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.2";
			/// <summary>Constant value for <see cref="TOOL_NUMBERValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="TOOL_NUMBERValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;identifier assigned by the {{block(Controller)}} component to a cutting tool when in use by a piece of equipment.&#10;
";

			/// <inheritdoc />
			public string Name => NAME;
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => NORMATIVE_VERSION;
			
			/// <inheritdoc />
			public string DeprecatedVersion => DEPRECATED_VERSION;
			
			/// <inheritdoc />
			public string Summary => SUMMARY;
		}
		private TOOL_OFFSETValue _TOOL_OFFSET;
		/// <inheritdoc cref="TOOL_OFFSETValue" path="/summary" />
		public TOOL_OFFSETValue TOOL_OFFSET => _TOOL_OFFSET ?? (_TOOL_OFFSET = new TOOL_OFFSETValue());

		/// <summary>﻿reference to the tool offset variables applied to the active cutting tool.<br /><br /><br />
		/// Value for EventEnum.<br/>
		/// <br/>See also <seealso cref="EventEnum">EventEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		public sealed class TOOL_OFFSETValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="TOOL_OFFSETValue.Name" /></summary>
			public const string NAME = "TOOL_OFFSET";
			/// <summary>Constant value for <see cref="TOOL_OFFSETValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.4";
			/// <summary>Constant value for <see cref="TOOL_OFFSETValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="TOOL_OFFSETValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;reference to the tool offset variables applied to the active cutting tool.&#10;
";

			/// <inheritdoc />
			public string Name => NAME;
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => NORMATIVE_VERSION;
			
			/// <inheritdoc />
			public string DeprecatedVersion => DEPRECATED_VERSION;
			
			/// <inheritdoc />
			public string Summary => SUMMARY;
		}
		private USERValue _USER;
		/// <inheritdoc cref="USERValue" path="/summary" />
		public USERValue USER => _USER ?? (_USER = new USERValue());

		/// <summary>﻿identifier of the person currently responsible for operating the piece of equipment.<br /><br /><br />
		/// Value for EventEnum.<br/>
		/// <br/>See also <seealso cref="EventEnum">EventEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		public sealed class USERValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="USERValue.Name" /></summary>
			public const string NAME = "USER";
			/// <summary>Constant value for <see cref="USERValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.4";
			/// <summary>Constant value for <see cref="USERValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="USERValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;identifier of the person currently responsible for operating the piece of equipment.&#10;
";

			/// <inheritdoc />
			public string Name => NAME;
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => NORMATIVE_VERSION;
			
			/// <inheritdoc />
			public string DeprecatedVersion => DEPRECATED_VERSION;
			
			/// <inheritdoc />
			public string Summary => SUMMARY;
		}
		private VARIABLEValue _VARIABLE;
		/// <inheritdoc cref="VARIABLEValue" path="/summary" />
		public VARIABLEValue VARIABLE => _VARIABLE ?? (_VARIABLE = new VARIABLEValue());

		/// <summary>﻿data whose meaning may change over time due to changes in the operation of a piece of equipment or the process being executed on that piece of equipment.<br /><br /><br />
		/// Value for EventEnum.<br/>
		/// <br/>See also <seealso cref="EventEnum">EventEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		public sealed class VARIABLEValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="VARIABLEValue.Name" /></summary>
			public const string NAME = "VARIABLE";
			/// <summary>Constant value for <see cref="VARIABLEValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.5";
			/// <summary>Constant value for <see cref="VARIABLEValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="VARIABLEValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;data whose meaning may change over time due to changes in the operation of a piece of equipment or the process being executed on that piece of equipment.&#10;
";

			/// <inheritdoc />
			public string Name => NAME;
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => NORMATIVE_VERSION;
			
			/// <inheritdoc />
			public string DeprecatedVersion => DEPRECATED_VERSION;
			
			/// <inheritdoc />
			public string Summary => SUMMARY;
		}
		private WAIT_STATEValue _WAIT_STATE;
		/// <inheritdoc cref="WAIT_STATEValue" path="/summary" />
		public WAIT_STATEValue WAIT_STATE => _WAIT_STATE ?? (_WAIT_STATE = new WAIT_STATEValue());

		/// <summary>﻿indication of the reason that <see cref="Execution">Execution</see> is reporting a value of <c>WAIT</c>.<br /><br /><br />
		/// Value for EventEnum.<br/>
		/// <br/>See also <seealso cref="EventEnum">EventEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		public sealed class WAIT_STATEValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="WAIT_STATEValue.Name" /></summary>
			public const string NAME = "WAIT_STATE";
			/// <summary>Constant value for <see cref="WAIT_STATEValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.5";
			/// <summary>Constant value for <see cref="WAIT_STATEValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="WAIT_STATEValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;indication of the reason that {{block(Execution)}} is reporting a value of `WAIT`.&#10;
";

			/// <inheritdoc />
			public string Name => NAME;
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => NORMATIVE_VERSION;
			
			/// <inheritdoc />
			public string DeprecatedVersion => DEPRECATED_VERSION;
			
			/// <inheritdoc />
			public string Summary => SUMMARY;
		}
		private WIREValue _WIRE;
		/// <inheritdoc cref="WIREValue" path="/summary" />
		public WIREValue WIRE => _WIRE ?? (_WIRE = new WIREValue());

		/// <summary>﻿identifier for the type of wire used as the cutting mechanism in Electrical Discharge Machining or similar processes.<br /><br /><br />
		/// Value for EventEnum.<br/>
		/// <br/>See also <seealso cref="EventEnum">EventEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		public sealed class WIREValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="WIREValue.Name" /></summary>
			public const string NAME = "WIRE";
			/// <summary>Constant value for <see cref="WIREValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.4";
			/// <summary>Constant value for <see cref="WIREValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="WIREValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;identifier for the type of wire used as the cutting mechanism in Electrical Discharge Machining or similar processes.&#10;
";

			/// <inheritdoc />
			public string Name => NAME;
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => NORMATIVE_VERSION;
			
			/// <inheritdoc />
			public string DeprecatedVersion => DEPRECATED_VERSION;
			
			/// <inheritdoc />
			public string Summary => SUMMARY;
		}
		private WORKHOLDING_IDValue _WORKHOLDING_ID;
		/// <inheritdoc cref="WORKHOLDING_IDValue" path="/summary" />
		public WORKHOLDING_IDValue WORKHOLDING_ID => _WORKHOLDING_ID ?? (_WORKHOLDING_ID = new WORKHOLDING_IDValue());

		/// <summary>﻿identifier for the current workholding or part clamp in use by a piece of equipment.<br /><br /><b>DEPRECATION WARNING</b>: Recommend using <c>FIXTURE_ID</c> instead.<br /><br /><br />
		/// Value for EventEnum.<br/>
		/// <br/>See also <seealso cref="EventEnum">EventEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		public sealed class WORKHOLDING_IDValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="WORKHOLDING_IDValue.Name" /></summary>
			public const string NAME = "WORKHOLDING_ID";
			/// <summary>Constant value for <see cref="WORKHOLDING_IDValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.1";
			/// <summary>Constant value for <see cref="WORKHOLDING_IDValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="WORKHOLDING_IDValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;identifier for the current workholding or part clamp in use by a piece of equipment.

**DEPRECATION WARNING**: Recommend using `FIXTURE_ID` instead.&#10;
";

			/// <inheritdoc />
			public string Name => NAME;
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => NORMATIVE_VERSION;
			
			/// <inheritdoc />
			public string DeprecatedVersion => DEPRECATED_VERSION;
			
			/// <inheritdoc />
			public string Summary => SUMMARY;
		}
		private WORK_OFFSETValue _WORK_OFFSET;
		/// <inheritdoc cref="WORK_OFFSETValue" path="/summary" />
		public WORK_OFFSETValue WORK_OFFSET => _WORK_OFFSET ?? (_WORK_OFFSET = new WORK_OFFSETValue());

		/// <summary>﻿reference to offset variables for a work piece or part.<br /><br /><br />
		/// Value for EventEnum.<br/>
		/// <br/>See also <seealso cref="EventEnum">EventEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		public sealed class WORK_OFFSETValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="WORK_OFFSETValue.Name" /></summary>
			public const string NAME = "WORK_OFFSET";
			/// <summary>Constant value for <see cref="WORK_OFFSETValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.4";
			/// <summary>Constant value for <see cref="WORK_OFFSETValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="WORK_OFFSETValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;reference to offset variables for a work piece or part.&#10;
";

			/// <inheritdoc />
			public string Name => NAME;
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => NORMATIVE_VERSION;
			
			/// <inheritdoc />
			public string DeprecatedVersion => DEPRECATED_VERSION;
			
			/// <inheritdoc />
			public string Summary => SUMMARY;
		}
		private OPERATING_SYSTEMValue _OPERATING_SYSTEM;
		/// <inheritdoc cref="OPERATING_SYSTEMValue" path="/summary" />
		public OPERATING_SYSTEMValue OPERATING_SYSTEM => _OPERATING_SYSTEM ?? (_OPERATING_SYSTEM = new OPERATING_SYSTEMValue());

		/// <summary>﻿Operating System (OS) of a <see cref="Component">Component</see>.<br /><br /><br />
		/// Value for EventEnum.<br/>
		/// <br/>See also <seealso cref="EventEnum">EventEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		public sealed class OPERATING_SYSTEMValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="OPERATING_SYSTEMValue.Name" /></summary>
			public const string NAME = "OPERATING_SYSTEM";
			/// <summary>Constant value for <see cref="OPERATING_SYSTEMValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.6";
			/// <summary>Constant value for <see cref="OPERATING_SYSTEMValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="OPERATING_SYSTEMValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;Operating System (OS) of a {{block(Component)}}.&#10;
";

			/// <inheritdoc />
			public string Name => NAME;
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => NORMATIVE_VERSION;
			
			/// <inheritdoc />
			public string DeprecatedVersion => DEPRECATED_VERSION;
			
			/// <inheritdoc />
			public string Summary => SUMMARY;
		}
		private FIRMWAREValue _FIRMWARE;
		/// <inheritdoc cref="FIRMWAREValue" path="/summary" />
		public FIRMWAREValue FIRMWARE => _FIRMWARE ?? (_FIRMWARE = new FIRMWAREValue());

		/// <summary>﻿embedded software of a <see cref="Component">Component</see><br />.<br /><br /><br />
		/// Value for EventEnum.<br/>
		/// <br/>See also <seealso cref="EventEnum">EventEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		public sealed class FIRMWAREValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="FIRMWAREValue.Name" /></summary>
			public const string NAME = "FIRMWARE";
			/// <summary>Constant value for <see cref="FIRMWAREValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.6";
			/// <summary>Constant value for <see cref="FIRMWAREValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="FIRMWAREValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;embedded software of a {{block(Component)}}.&#10;
";

			/// <inheritdoc />
			public string Name => NAME;
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => NORMATIVE_VERSION;
			
			/// <inheritdoc />
			public string DeprecatedVersion => DEPRECATED_VERSION;
			
			/// <inheritdoc />
			public string Summary => SUMMARY;
		}
		private APPLICATIONValue _APPLICATION;
		/// <inheritdoc cref="APPLICATIONValue" path="/summary" />
		public APPLICATIONValue APPLICATION => _APPLICATION ?? (_APPLICATION = new APPLICATIONValue());

		/// <summary>﻿application on a <see cref="Component">Component</see>.<br /><br /><br />
		/// Value for EventEnum.<br/>
		/// <br/>See also <seealso cref="EventEnum">EventEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		public sealed class APPLICATIONValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="APPLICATIONValue.Name" /></summary>
			public const string NAME = "APPLICATION";
			/// <summary>Constant value for <see cref="APPLICATIONValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.6";
			/// <summary>Constant value for <see cref="APPLICATIONValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="APPLICATIONValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;application on a {{block(Component)}}.&#10;
";

			/// <inheritdoc />
			public string Name => NAME;
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => NORMATIVE_VERSION;
			
			/// <inheritdoc />
			public string DeprecatedVersion => DEPRECATED_VERSION;
			
			/// <inheritdoc />
			public string Summary => SUMMARY;
		}
		private LIBRARYValue _LIBRARY;
		/// <inheritdoc cref="LIBRARYValue" path="/summary" />
		public LIBRARYValue LIBRARY => _LIBRARY ?? (_LIBRARY = new LIBRARYValue());

		/// <summary>﻿software library on a <see cref="Component">Component</see><br /><br /><br />
		/// Value for EventEnum.<br/>
		/// <br/>See also <seealso cref="EventEnum">EventEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		public sealed class LIBRARYValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="LIBRARYValue.Name" /></summary>
			public const string NAME = "LIBRARY";
			/// <summary>Constant value for <see cref="LIBRARYValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.6";
			/// <summary>Constant value for <see cref="LIBRARYValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="LIBRARYValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;software library on a {{block(Component)}}&#10;
";

			/// <inheritdoc />
			public string Name => NAME;
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => NORMATIVE_VERSION;
			
			/// <inheritdoc />
			public string DeprecatedVersion => DEPRECATED_VERSION;
			
			/// <inheritdoc />
			public string Summary => SUMMARY;
		}
		private HARDWAREValue _HARDWARE;
		/// <inheritdoc cref="HARDWAREValue" path="/summary" />
		public HARDWAREValue HARDWARE => _HARDWARE ?? (_HARDWARE = new HARDWAREValue());

		/// <summary>﻿hardware of a <see cref="Component">Component</see>.<br /><br /><br />
		/// Value for EventEnum.<br/>
		/// <br/>See also <seealso cref="EventEnum">EventEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		public sealed class HARDWAREValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="HARDWAREValue.Name" /></summary>
			public const string NAME = "HARDWARE";
			/// <summary>Constant value for <see cref="HARDWAREValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.6";
			/// <summary>Constant value for <see cref="HARDWAREValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="HARDWAREValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;hardware of a {{block(Component)}}.&#10;
";

			/// <inheritdoc />
			public string Name => NAME;
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => NORMATIVE_VERSION;
			
			/// <inheritdoc />
			public string DeprecatedVersion => DEPRECATED_VERSION;
			
			/// <inheritdoc />
			public string Summary => SUMMARY;
		}
		private NETWORKValue _NETWORK;
		/// <inheritdoc cref="NETWORKValue" path="/summary" />
		public NETWORKValue NETWORK => _NETWORK ?? (_NETWORK = new NETWORKValue());

		/// <summary>﻿network details of a <see cref="Component">Component</see>.<br /><br /><br />
		/// Value for EventEnum.<br/>
		/// <br/>See also <seealso cref="EventEnum">EventEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		public sealed class NETWORKValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="NETWORKValue.Name" /></summary>
			public const string NAME = "NETWORK";
			/// <summary>Constant value for <see cref="NETWORKValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.6";
			/// <summary>Constant value for <see cref="NETWORKValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="NETWORKValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;network details of a {{block(Component)}}.&#10;
";

			/// <inheritdoc />
			public string Name => NAME;
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => NORMATIVE_VERSION;
			
			/// <inheritdoc />
			public string DeprecatedVersion => DEPRECATED_VERSION;
			
			/// <inheritdoc />
			public string Summary => SUMMARY;
		}
		private ROTATIONValue _ROTATION;
		/// <inheritdoc cref="ROTATIONValue" path="/summary" />
		public ROTATIONValue ROTATION => _ROTATION ?? (_ROTATION = new ROTATIONValue());

		/// <summary>﻿three space angular displacement of an object or coordinate system relative to a <i>cartesian coordinate system</i>.<br /><br /><br />
		/// Value for EventEnum.<br/>
		/// <br/>See also <seealso cref="EventEnum">EventEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		public sealed class ROTATIONValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="ROTATIONValue.Name" /></summary>
			public const string NAME = "ROTATION";
			/// <summary>Constant value for <see cref="ROTATIONValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.6";
			/// <summary>Constant value for <see cref="ROTATIONValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="ROTATIONValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;three space angular displacement of an object or coordinate system relative to a {{term(cartesian coordinate system)}}.&#10;
";

			/// <inheritdoc />
			public string Name => NAME;
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => NORMATIVE_VERSION;
			
			/// <inheritdoc />
			public string DeprecatedVersion => DEPRECATED_VERSION;
			
			/// <inheritdoc />
			public string Summary => SUMMARY;
		}
		private TRANSLATIONValue _TRANSLATION;
		/// <inheritdoc cref="TRANSLATIONValue" path="/summary" />
		public TRANSLATIONValue TRANSLATION => _TRANSLATION ?? (_TRANSLATION = new TRANSLATIONValue());

		/// <summary>﻿three space linear displacement of an object or coordinate system relative to a <i>cartesian coordinate system</i>.<br /><br /><br />
		/// Value for EventEnum.<br/>
		/// <br/>See also <seealso cref="EventEnum">EventEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		public sealed class TRANSLATIONValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="TRANSLATIONValue.Name" /></summary>
			public const string NAME = "TRANSLATION";
			/// <summary>Constant value for <see cref="TRANSLATIONValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.6";
			/// <summary>Constant value for <see cref="TRANSLATIONValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="TRANSLATIONValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;three space linear displacement of an object or coordinate system relative to a {{term(cartesian coordinate system)}}.&#10;
";

			/// <inheritdoc />
			public string Name => NAME;
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => NORMATIVE_VERSION;
			
			/// <inheritdoc />
			public string DeprecatedVersion => DEPRECATED_VERSION;
			
			/// <inheritdoc />
			public string Summary => SUMMARY;
		}
		private DEVICE_ADDEDValue _DEVICE_ADDED;
		/// <inheritdoc cref="DEVICE_ADDEDValue" path="/summary" />
		public DEVICE_ADDEDValue DEVICE_ADDED => _DEVICE_ADDED ?? (_DEVICE_ADDED = new DEVICE_ADDEDValue());

		/// <summary>﻿<i>UUID</i> of new device added to an <i>MTConnect Agent</i>.<br /><br /><br />
		/// Value for EventEnum.<br/>
		/// <br/>See also <seealso cref="EventEnum">EventEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		public sealed class DEVICE_ADDEDValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="DEVICE_ADDEDValue.Name" /></summary>
			public const string NAME = "DEVICE_ADDED";
			/// <summary>Constant value for <see cref="DEVICE_ADDEDValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.7";
			/// <summary>Constant value for <see cref="DEVICE_ADDEDValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="DEVICE_ADDEDValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;{{term(UUID)}} of new device added to an {{term(MTConnect Agent)}}.&#10;
";

			/// <inheritdoc />
			public string Name => NAME;
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => NORMATIVE_VERSION;
			
			/// <inheritdoc />
			public string DeprecatedVersion => DEPRECATED_VERSION;
			
			/// <inheritdoc />
			public string Summary => SUMMARY;
		}
		private DEVICE_REMOVEDValue _DEVICE_REMOVED;
		/// <inheritdoc cref="DEVICE_REMOVEDValue" path="/summary" />
		public DEVICE_REMOVEDValue DEVICE_REMOVED => _DEVICE_REMOVED ?? (_DEVICE_REMOVED = new DEVICE_REMOVEDValue());

		/// <summary>﻿<i>UUID</i> of a device removed from an <i>MTConnect Agent</i>.<br /><br /><br />
		/// Value for EventEnum.<br/>
		/// <br/>See also <seealso cref="EventEnum">EventEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		public sealed class DEVICE_REMOVEDValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="DEVICE_REMOVEDValue.Name" /></summary>
			public const string NAME = "DEVICE_REMOVED";
			/// <summary>Constant value for <see cref="DEVICE_REMOVEDValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.7";
			/// <summary>Constant value for <see cref="DEVICE_REMOVEDValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="DEVICE_REMOVEDValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;{{term(UUID)}} of a device removed from an {{term(MTConnect Agent)}}.&#10;
";

			/// <inheritdoc />
			public string Name => NAME;
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => NORMATIVE_VERSION;
			
			/// <inheritdoc />
			public string DeprecatedVersion => DEPRECATED_VERSION;
			
			/// <inheritdoc />
			public string Summary => SUMMARY;
		}
		private DEVICE_CHANGEDValue _DEVICE_CHANGED;
		/// <inheritdoc cref="DEVICE_CHANGEDValue" path="/summary" />
		public DEVICE_CHANGEDValue DEVICE_CHANGED => _DEVICE_CHANGED ?? (_DEVICE_CHANGED = new DEVICE_CHANGEDValue());

		/// <summary>﻿<i>UUID</i> of the device whose <i>metadata</i> has changed.<br /><br /><br />
		/// Value for EventEnum.<br/>
		/// <br/>See also <seealso cref="EventEnum">EventEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		public sealed class DEVICE_CHANGEDValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="DEVICE_CHANGEDValue.Name" /></summary>
			public const string NAME = "DEVICE_CHANGED";
			/// <summary>Constant value for <see cref="DEVICE_CHANGEDValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.7";
			/// <summary>Constant value for <see cref="DEVICE_CHANGEDValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="DEVICE_CHANGEDValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;{{term(UUID)}} of the device whose {{term(metadata)}} has changed.&#10;
";

			/// <inheritdoc />
			public string Name => NAME;
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => NORMATIVE_VERSION;
			
			/// <inheritdoc />
			public string DeprecatedVersion => DEPRECATED_VERSION;
			
			/// <inheritdoc />
			public string Summary => SUMMARY;
		}
		private CONNECTION_STATUSValue _CONNECTION_STATUS;
		/// <inheritdoc cref="CONNECTION_STATUSValue" path="/summary" />
		public CONNECTION_STATUSValue CONNECTION_STATUS => _CONNECTION_STATUS ?? (_CONNECTION_STATUS = new CONNECTION_STATUSValue());

		/// <summary>﻿status of the connection between an <i>adapter</i> and an <i>agent</i>.<br /><br /><br />
		/// Value for EventEnum.<br/>
		/// <br/>See also <seealso cref="EventEnum">EventEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		public sealed class CONNECTION_STATUSValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="CONNECTION_STATUSValue.Name" /></summary>
			public const string NAME = "CONNECTION_STATUS";
			/// <summary>Constant value for <see cref="CONNECTION_STATUSValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.7";
			/// <summary>Constant value for <see cref="CONNECTION_STATUSValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="CONNECTION_STATUSValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;status of the connection between an {{term(adapter)}} and an {{term(agent)}}.&#10;
";

			/// <inheritdoc />
			public string Name => NAME;
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => NORMATIVE_VERSION;
			
			/// <inheritdoc />
			public string DeprecatedVersion => DEPRECATED_VERSION;
			
			/// <inheritdoc />
			public string Summary => SUMMARY;
		}
		private ADAPTER_SOFTWARE_VERSIONValue _ADAPTER_SOFTWARE_VERSION;
		/// <inheritdoc cref="ADAPTER_SOFTWARE_VERSIONValue" path="/summary" />
		public ADAPTER_SOFTWARE_VERSIONValue ADAPTER_SOFTWARE_VERSION => _ADAPTER_SOFTWARE_VERSION ?? (_ADAPTER_SOFTWARE_VERSION = new ADAPTER_SOFTWARE_VERSIONValue());

		/// <summary>﻿originator’s software version of the <i>adapter</i>.<br /><br /><br />
		/// Value for EventEnum.<br/>
		/// <br/>See also <seealso cref="EventEnum">EventEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		public sealed class ADAPTER_SOFTWARE_VERSIONValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="ADAPTER_SOFTWARE_VERSIONValue.Name" /></summary>
			public const string NAME = "ADAPTER_SOFTWARE_VERSION";
			/// <summary>Constant value for <see cref="ADAPTER_SOFTWARE_VERSIONValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.7";
			/// <summary>Constant value for <see cref="ADAPTER_SOFTWARE_VERSIONValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="ADAPTER_SOFTWARE_VERSIONValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;originator’s software version of the {{term(adapter)}}.&#10;
";

			/// <inheritdoc />
			public string Name => NAME;
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => NORMATIVE_VERSION;
			
			/// <inheritdoc />
			public string DeprecatedVersion => DEPRECATED_VERSION;
			
			/// <inheritdoc />
			public string Summary => SUMMARY;
		}
		private ADAPTER_URIValue _ADAPTER_URI;
		/// <inheritdoc cref="ADAPTER_URIValue" path="/summary" />
		public ADAPTER_URIValue ADAPTER_URI => _ADAPTER_URI ?? (_ADAPTER_URI = new ADAPTER_URIValue());

		/// <summary>﻿<i>URI</i> of the <i>adapter</i>.<br /><br /><br />
		/// Value for EventEnum.<br/>
		/// <br/>See also <seealso cref="EventEnum">EventEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		public sealed class ADAPTER_URIValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="ADAPTER_URIValue.Name" /></summary>
			public const string NAME = "ADAPTER_URI";
			/// <summary>Constant value for <see cref="ADAPTER_URIValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.7";
			/// <summary>Constant value for <see cref="ADAPTER_URIValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="ADAPTER_URIValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;{{term(URI)}} of the {{term(adapter)}}.&#10;
";

			/// <inheritdoc />
			public string Name => NAME;
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => NORMATIVE_VERSION;
			
			/// <inheritdoc />
			public string DeprecatedVersion => DEPRECATED_VERSION;
			
			/// <inheritdoc />
			public string Summary => SUMMARY;
		}
		private MTCONNECT_VERSIONValue _MTCONNECT_VERSION;
		/// <inheritdoc cref="MTCONNECT_VERSIONValue" path="/summary" />
		public MTCONNECT_VERSIONValue MTCONNECT_VERSION => _MTCONNECT_VERSION ?? (_MTCONNECT_VERSION = new MTCONNECT_VERSIONValue());

		/// <summary>﻿reference version of the MTConnect Standard supported by the <i>adapter</i>.<br /><br /><br />
		/// Value for EventEnum.<br/>
		/// <br/>See also <seealso cref="EventEnum">EventEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		public sealed class MTCONNECT_VERSIONValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="MTCONNECT_VERSIONValue.Name" /></summary>
			public const string NAME = "MTCONNECT_VERSION";
			/// <summary>Constant value for <see cref="MTCONNECT_VERSIONValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.7";
			/// <summary>Constant value for <see cref="MTCONNECT_VERSIONValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="MTCONNECT_VERSIONValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;reference version of the MTConnect Standard supported by the {{term(adapter)}}.&#10;
";

			/// <inheritdoc />
			public string Name => NAME;
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => NORMATIVE_VERSION;
			
			/// <inheritdoc />
			public string DeprecatedVersion => DEPRECATED_VERSION;
			
			/// <inheritdoc />
			public string Summary => SUMMARY;
		}
		private SENSOR_ATTACHMENTValue _SENSOR_ATTACHMENT;
		/// <inheritdoc cref="SENSOR_ATTACHMENTValue" path="/summary" />
		public SENSOR_ATTACHMENTValue SENSOR_ATTACHMENT => _SENSOR_ATTACHMENT ?? (_SENSOR_ATTACHMENT = new SENSOR_ATTACHMENTValue());

		/// <summary>﻿<i>attachment</i> between a sensor and an entity.<br /><br /><br />
		/// Value for EventEnum.<br/>
		/// <br/>See also <seealso cref="EventEnum">EventEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		public sealed class SENSOR_ATTACHMENTValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="SENSOR_ATTACHMENTValue.Name" /></summary>
			public const string NAME = "SENSOR_ATTACHMENT";
			/// <summary>Constant value for <see cref="SENSOR_ATTACHMENTValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.7";
			/// <summary>Constant value for <see cref="SENSOR_ATTACHMENTValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="SENSOR_ATTACHMENTValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;{{term(attachment)}} between a sensor and an entity.&#10;
";

			/// <inheritdoc />
			public string Name => NAME;
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => NORMATIVE_VERSION;
			
			/// <inheritdoc />
			public string DeprecatedVersion => DEPRECATED_VERSION;
			
			/// <inheritdoc />
			public string Summary => SUMMARY;
		}
		private PART_STATUSValue _PART_STATUS;
		/// <inheritdoc cref="PART_STATUSValue" path="/summary" />
		public PART_STATUSValue PART_STATUS => _PART_STATUS ?? (_PART_STATUS = new PART_STATUSValue());

		/// <summary>﻿state or condition of a part.<br /><br /><br />
		/// Value for EventEnum.<br/>
		/// <br/>See also <seealso cref="EventEnum">EventEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		public sealed class PART_STATUSValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="PART_STATUSValue.Name" /></summary>
			public const string NAME = "PART_STATUS";
			/// <summary>Constant value for <see cref="PART_STATUSValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.7";
			/// <summary>Constant value for <see cref="PART_STATUSValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="PART_STATUSValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;state or condition of a part.&#10;
";

			/// <inheritdoc />
			public string Name => NAME;
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => NORMATIVE_VERSION;
			
			/// <inheritdoc />
			public string DeprecatedVersion => DEPRECATED_VERSION;
			
			/// <inheritdoc />
			public string Summary => SUMMARY;
		}
		private PROCESS_OCCURRENCE_IDValue _PROCESS_OCCURRENCE_ID;
		/// <inheritdoc cref="PROCESS_OCCURRENCE_IDValue" path="/summary" />
		public PROCESS_OCCURRENCE_IDValue PROCESS_OCCURRENCE_ID => _PROCESS_OCCURRENCE_ID ?? (_PROCESS_OCCURRENCE_ID = new PROCESS_OCCURRENCE_IDValue());

		/// <summary>﻿identifier of a process being executed by the device.<br /><br /><br />
		/// Value for EventEnum.<br/>
		/// <br/>See also <seealso cref="EventEnum">EventEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		public sealed class PROCESS_OCCURRENCE_IDValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="PROCESS_OCCURRENCE_IDValue.Name" /></summary>
			public const string NAME = "PROCESS_OCCURRENCE_ID";
			/// <summary>Constant value for <see cref="PROCESS_OCCURRENCE_IDValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.7";
			/// <summary>Constant value for <see cref="PROCESS_OCCURRENCE_IDValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="PROCESS_OCCURRENCE_IDValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;identifier of a process being executed by the device.&#10;
";

			/// <inheritdoc />
			public string Name => NAME;
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => NORMATIVE_VERSION;
			
			/// <inheritdoc />
			public string DeprecatedVersion => DEPRECATED_VERSION;
			
			/// <inheritdoc />
			public string Summary => SUMMARY;
		}
		private PROCESS_AGGREGATE_IDValue _PROCESS_AGGREGATE_ID;
		/// <inheritdoc cref="PROCESS_AGGREGATE_IDValue" path="/summary" />
		public PROCESS_AGGREGATE_IDValue PROCESS_AGGREGATE_ID => _PROCESS_AGGREGATE_ID ?? (_PROCESS_AGGREGATE_ID = new PROCESS_AGGREGATE_IDValue());

		/// <summary>﻿identifier given to link the individual occurrence to a group of related occurrences, such as a process step in a process plan.<br /><br /><br />
		/// Value for EventEnum.<br/>
		/// <br/>See also <seealso cref="EventEnum">EventEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		public sealed class PROCESS_AGGREGATE_IDValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="PROCESS_AGGREGATE_IDValue.Name" /></summary>
			public const string NAME = "PROCESS_AGGREGATE_ID";
			/// <summary>Constant value for <see cref="PROCESS_AGGREGATE_IDValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.7";
			/// <summary>Constant value for <see cref="PROCESS_AGGREGATE_IDValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="PROCESS_AGGREGATE_IDValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;identifier given to link the individual occurrence to a group of related occurrences, such as a process step in a process plan.&#10;
";

			/// <inheritdoc />
			public string Name => NAME;
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => NORMATIVE_VERSION;
			
			/// <inheritdoc />
			public string DeprecatedVersion => DEPRECATED_VERSION;
			
			/// <inheritdoc />
			public string Summary => SUMMARY;
		}
		private PROCESS_KIND_IDValue _PROCESS_KIND_ID;
		/// <inheritdoc cref="PROCESS_KIND_IDValue" path="/summary" />
		public PROCESS_KIND_IDValue PROCESS_KIND_ID => _PROCESS_KIND_ID ?? (_PROCESS_KIND_ID = new PROCESS_KIND_IDValue());

		/// <summary>﻿identifier given to link the individual occurrence to a class of processes or process definition.<br /><br /><br /><br />
		/// Value for EventEnum.<br/>
		/// <br/>See also <seealso cref="EventEnum">EventEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		public sealed class PROCESS_KIND_IDValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="PROCESS_KIND_IDValue.Name" /></summary>
			public const string NAME = "PROCESS_KIND_ID";
			/// <summary>Constant value for <see cref="PROCESS_KIND_IDValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.7";
			/// <summary>Constant value for <see cref="PROCESS_KIND_IDValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="PROCESS_KIND_IDValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;identifier given to link the individual occurrence to a class of processes or process definition.&#10;
";

			/// <inheritdoc />
			public string Name => NAME;
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => NORMATIVE_VERSION;
			
			/// <inheritdoc />
			public string DeprecatedVersion => DEPRECATED_VERSION;
			
			/// <inheritdoc />
			public string Summary => SUMMARY;
		}
		private PART_GROUP_IDValue _PART_GROUP_ID;
		/// <inheritdoc cref="PART_GROUP_IDValue" path="/summary" />
		public PART_GROUP_IDValue PART_GROUP_ID => _PART_GROUP_ID ?? (_PART_GROUP_ID = new PART_GROUP_IDValue());

		/// <summary>﻿identifier given to a collection of individual parts. <br /><br /><br />
		/// Value for EventEnum.<br/>
		/// <br/>See also <seealso cref="EventEnum">EventEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		public sealed class PART_GROUP_IDValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="PART_GROUP_IDValue.Name" /></summary>
			public const string NAME = "PART_GROUP_ID";
			/// <summary>Constant value for <see cref="PART_GROUP_IDValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.7";
			/// <summary>Constant value for <see cref="PART_GROUP_IDValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="PART_GROUP_IDValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;identifier given to a collection of individual parts. &#10;
";

			/// <inheritdoc />
			public string Name => NAME;
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => NORMATIVE_VERSION;
			
			/// <inheritdoc />
			public string DeprecatedVersion => DEPRECATED_VERSION;
			
			/// <inheritdoc />
			public string Summary => SUMMARY;
		}
		private PART_KIND_IDValue _PART_KIND_ID;
		/// <inheritdoc cref="PART_KIND_IDValue" path="/summary" />
		public PART_KIND_IDValue PART_KIND_ID => _PART_KIND_ID ?? (_PART_KIND_ID = new PART_KIND_IDValue());

		/// <summary>﻿identifier given to link the individual occurrence to a class of parts, typically distinguished by a particular part design.<br /><br /><br />
		/// Value for EventEnum.<br/>
		/// <br/>See also <seealso cref="EventEnum">EventEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		public sealed class PART_KIND_IDValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="PART_KIND_IDValue.Name" /></summary>
			public const string NAME = "PART_KIND_ID";
			/// <summary>Constant value for <see cref="PART_KIND_IDValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.7";
			/// <summary>Constant value for <see cref="PART_KIND_IDValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="PART_KIND_IDValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;identifier given to link the individual occurrence to a class of parts, typically distinguished by a particular part design.&#10;
";

			/// <inheritdoc />
			public string Name => NAME;
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => NORMATIVE_VERSION;
			
			/// <inheritdoc />
			public string DeprecatedVersion => DEPRECATED_VERSION;
			
			/// <inheritdoc />
			public string Summary => SUMMARY;
		}
		private PART_UNIQUE_IDValue _PART_UNIQUE_ID;
		/// <inheritdoc cref="PART_UNIQUE_IDValue" path="/summary" />
		public PART_UNIQUE_IDValue PART_UNIQUE_ID => _PART_UNIQUE_ID ?? (_PART_UNIQUE_ID = new PART_UNIQUE_IDValue());

		/// <summary>﻿identifier given to a distinguishable, individual part. <br /><br /><br />
		/// Value for EventEnum.<br/>
		/// <br/>See also <seealso cref="EventEnum">EventEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		public sealed class PART_UNIQUE_IDValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="PART_UNIQUE_IDValue.Name" /></summary>
			public const string NAME = "PART_UNIQUE_ID";
			/// <summary>Constant value for <see cref="PART_UNIQUE_IDValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.7";
			/// <summary>Constant value for <see cref="PART_UNIQUE_IDValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="PART_UNIQUE_IDValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;identifier given to a distinguishable, individual part. &#10;
";

			/// <inheritdoc />
			public string Name => NAME;
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => NORMATIVE_VERSION;
			
			/// <inheritdoc />
			public string DeprecatedVersion => DEPRECATED_VERSION;
			
			/// <inheritdoc />
			public string Summary => SUMMARY;
		}
		private CONTROL_LIMITValue _CONTROL_LIMIT;
		/// <inheritdoc cref="CONTROL_LIMITValue" path="/summary" />
		public CONTROL_LIMITValue CONTROL_LIMIT => _CONTROL_LIMIT ?? (_CONTROL_LIMIT = new CONTROL_LIMITValue());

		/// <summary>﻿set of limits used to indicate whether a process variable is stable and in control.<br /><br /><b>DEPRECATION WARNING</b>. Recommend using <c>CONTROL_LIMITS</c>.<br /><br /><br />
		/// Value for EventEnum.<br/>
		/// <br/>See also <seealso cref="EventEnum">EventEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		public sealed class CONTROL_LIMITValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="CONTROL_LIMITValue.Name" /></summary>
			public const string NAME = "CONTROL_LIMIT";
			/// <summary>Constant value for <see cref="CONTROL_LIMITValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.7";
			/// <summary>Constant value for <see cref="CONTROL_LIMITValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="CONTROL_LIMITValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;set of limits used to indicate whether a process variable is stable and in control.

**DEPRECATION WARNING**. Recommend using `CONTROL_LIMITS`.&#10;
";

			/// <inheritdoc />
			public string Name => NAME;
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => NORMATIVE_VERSION;
			
			/// <inheritdoc />
			public string DeprecatedVersion => DEPRECATED_VERSION;
			
			/// <inheritdoc />
			public string Summary => SUMMARY;
		}
		private SPECIFICATION_LIMITValue _SPECIFICATION_LIMIT;
		/// <inheritdoc cref="SPECIFICATION_LIMITValue" path="/summary" />
		public SPECIFICATION_LIMITValue SPECIFICATION_LIMIT => _SPECIFICATION_LIMIT ?? (_SPECIFICATION_LIMIT = new SPECIFICATION_LIMITValue());

		/// <summary>﻿set of limits defining a range of values designating acceptable performance for a variable.<br /><br /><b>DEPRECATION WARNING</b>. Recommend using <c>SPECIFICATION_LIMITS</c>.<br /><br /><br />
		/// Value for EventEnum.<br/>
		/// <br/>See also <seealso cref="EventEnum">EventEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		public sealed class SPECIFICATION_LIMITValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="SPECIFICATION_LIMITValue.Name" /></summary>
			public const string NAME = "SPECIFICATION_LIMIT";
			/// <summary>Constant value for <see cref="SPECIFICATION_LIMITValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.7";
			/// <summary>Constant value for <see cref="SPECIFICATION_LIMITValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="SPECIFICATION_LIMITValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;set of limits defining a range of values designating acceptable performance for a variable.

**DEPRECATION WARNING**. Recommend using `SPECIFICATION_LIMITS`.&#10;
";

			/// <inheritdoc />
			public string Name => NAME;
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => NORMATIVE_VERSION;
			
			/// <inheritdoc />
			public string DeprecatedVersion => DEPRECATED_VERSION;
			
			/// <inheritdoc />
			public string Summary => SUMMARY;
		}
		private ALARM_LIMITValue _ALARM_LIMIT;
		/// <inheritdoc cref="ALARM_LIMITValue" path="/summary" />
		public ALARM_LIMITValue ALARM_LIMIT => _ALARM_LIMIT ?? (_ALARM_LIMIT = new ALARM_LIMITValue());

		/// <summary>﻿set of limits used to trigger warning or alarm indicators.<br /><br /><b>DEPRECATION WARNING</b>. Recommend using <c>ALARM_LIMITS</c>.<br /><br /><br />
		/// Value for EventEnum.<br/>
		/// <br/>See also <seealso cref="EventEnum">EventEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		public sealed class ALARM_LIMITValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="ALARM_LIMITValue.Name" /></summary>
			public const string NAME = "ALARM_LIMIT";
			/// <summary>Constant value for <see cref="ALARM_LIMITValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.7";
			/// <summary>Constant value for <see cref="ALARM_LIMITValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="ALARM_LIMITValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;set of limits used to trigger warning or alarm indicators.

**DEPRECATION WARNING**. Recommend using `ALARM_LIMITS`.&#10;
";

			/// <inheritdoc />
			public string Name => NAME;
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => NORMATIVE_VERSION;
			
			/// <inheritdoc />
			public string DeprecatedVersion => DEPRECATED_VERSION;
			
			/// <inheritdoc />
			public string Summary => SUMMARY;
		}
		private LOAD_COUNTValue _LOAD_COUNT;
		/// <inheritdoc cref="LOAD_COUNTValue" path="/summary" />
		public LOAD_COUNTValue LOAD_COUNT => _LOAD_COUNT ?? (_LOAD_COUNT = new LOAD_COUNTValue());

		/// <summary>﻿accumulation of the number of times an operation has attempted to, or is planned to attempt to, load materials, parts, or other items.<br /><br /><br />
		/// Value for EventEnum.<br/>
		/// <br/>See also <seealso cref="EventEnum">EventEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		public sealed class LOAD_COUNTValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="LOAD_COUNTValue.Name" /></summary>
			public const string NAME = "LOAD_COUNT";
			/// <summary>Constant value for <see cref="LOAD_COUNTValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.8";
			/// <summary>Constant value for <see cref="LOAD_COUNTValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="LOAD_COUNTValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;accumulation of the number of times an operation has attempted to, or is planned to attempt to, load materials, parts, or other items.&#10;
";

			/// <inheritdoc />
			public string Name => NAME;
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => NORMATIVE_VERSION;
			
			/// <inheritdoc />
			public string DeprecatedVersion => DEPRECATED_VERSION;
			
			/// <inheritdoc />
			public string Summary => SUMMARY;
		}
		private UNLOAD_COUNTValue _UNLOAD_COUNT;
		/// <inheritdoc cref="UNLOAD_COUNTValue" path="/summary" />
		public UNLOAD_COUNTValue UNLOAD_COUNT => _UNLOAD_COUNT ?? (_UNLOAD_COUNT = new UNLOAD_COUNTValue());

		/// <summary>﻿accumulation of the number of times an operation has attempted to, or is planned to attempt to, unload materials, parts, or other items.<br /><br /><br />
		/// Value for EventEnum.<br/>
		/// <br/>See also <seealso cref="EventEnum">EventEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		public sealed class UNLOAD_COUNTValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="UNLOAD_COUNTValue.Name" /></summary>
			public const string NAME = "UNLOAD_COUNT";
			/// <summary>Constant value for <see cref="UNLOAD_COUNTValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.8";
			/// <summary>Constant value for <see cref="UNLOAD_COUNTValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="UNLOAD_COUNTValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;accumulation of the number of times an operation has attempted to, or is planned to attempt to, unload materials, parts, or other items.&#10;
";

			/// <inheritdoc />
			public string Name => NAME;
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => NORMATIVE_VERSION;
			
			/// <inheritdoc />
			public string DeprecatedVersion => DEPRECATED_VERSION;
			
			/// <inheritdoc />
			public string Summary => SUMMARY;
		}
		private TRANSFER_COUNTValue _TRANSFER_COUNT;
		/// <inheritdoc cref="TRANSFER_COUNTValue" path="/summary" />
		public TRANSFER_COUNTValue TRANSFER_COUNT => _TRANSFER_COUNT ?? (_TRANSFER_COUNT = new TRANSFER_COUNTValue());

		/// <summary>﻿accumulation of the number of times an operation has attempted to, or is planned to attempt to, transfer materials, parts, or other items from one location to another.<br /><br /><br />
		/// Value for EventEnum.<br/>
		/// <br/>See also <seealso cref="EventEnum">EventEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		public sealed class TRANSFER_COUNTValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="TRANSFER_COUNTValue.Name" /></summary>
			public const string NAME = "TRANSFER_COUNT";
			/// <summary>Constant value for <see cref="TRANSFER_COUNTValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.8";
			/// <summary>Constant value for <see cref="TRANSFER_COUNTValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="TRANSFER_COUNTValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;accumulation of the number of times an operation has attempted to, or is planned to attempt to, transfer materials, parts, or other items from one location to another.&#10;
";

			/// <inheritdoc />
			public string Name => NAME;
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => NORMATIVE_VERSION;
			
			/// <inheritdoc />
			public string DeprecatedVersion => DEPRECATED_VERSION;
			
			/// <inheritdoc />
			public string Summary => SUMMARY;
		}
		private ACTIVATION_COUNTValue _ACTIVATION_COUNT;
		/// <inheritdoc cref="ACTIVATION_COUNTValue" path="/summary" />
		public ACTIVATION_COUNTValue ACTIVATION_COUNT => _ACTIVATION_COUNT ?? (_ACTIVATION_COUNT = new ACTIVATION_COUNTValue());

		/// <summary>﻿accumulation of the number of times a function has attempted to, or is planned to attempt to, activate or be performed.<br /><br /><br />
		/// Value for EventEnum.<br/>
		/// <br/>See also <seealso cref="EventEnum">EventEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		public sealed class ACTIVATION_COUNTValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="ACTIVATION_COUNTValue.Name" /></summary>
			public const string NAME = "ACTIVATION_COUNT";
			/// <summary>Constant value for <see cref="ACTIVATION_COUNTValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.8";
			/// <summary>Constant value for <see cref="ACTIVATION_COUNTValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="ACTIVATION_COUNTValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;accumulation of the number of times a function has attempted to, or is planned to attempt to, activate or be performed.&#10;
";

			/// <inheritdoc />
			public string Name => NAME;
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => NORMATIVE_VERSION;
			
			/// <inheritdoc />
			public string DeprecatedVersion => DEPRECATED_VERSION;
			
			/// <inheritdoc />
			public string Summary => SUMMARY;
		}
		private DEACTIVATION_COUNTValue _DEACTIVATION_COUNT;
		/// <inheritdoc cref="DEACTIVATION_COUNTValue" path="/summary" />
		public DEACTIVATION_COUNTValue DEACTIVATION_COUNT => _DEACTIVATION_COUNT ?? (_DEACTIVATION_COUNT = new DEACTIVATION_COUNTValue());

		/// <summary>﻿accumulation of the number of times a function has attempted to, or is planned to attempt to, deactivate or cease.<br /><br /><br />
		/// Value for EventEnum.<br/>
		/// <br/>See also <seealso cref="EventEnum">EventEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		public sealed class DEACTIVATION_COUNTValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="DEACTIVATION_COUNTValue.Name" /></summary>
			public const string NAME = "DEACTIVATION_COUNT";
			/// <summary>Constant value for <see cref="DEACTIVATION_COUNTValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.8";
			/// <summary>Constant value for <see cref="DEACTIVATION_COUNTValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="DEACTIVATION_COUNTValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;accumulation of the number of times a function has attempted to, or is planned to attempt to, deactivate or cease.&#10;
";

			/// <inheritdoc />
			public string Name => NAME;
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => NORMATIVE_VERSION;
			
			/// <inheritdoc />
			public string DeprecatedVersion => DEPRECATED_VERSION;
			
			/// <inheritdoc />
			public string Summary => SUMMARY;
		}
		private CYCLE_COUNTValue _CYCLE_COUNT;
		/// <inheritdoc cref="CYCLE_COUNTValue" path="/summary" />
		public CYCLE_COUNTValue CYCLE_COUNT => _CYCLE_COUNT ?? (_CYCLE_COUNT = new CYCLE_COUNTValue());

		/// <summary>﻿accumulation of the number of times a cyclic function has attempted to, or is planned to attempt to execute.<br /><br /><br />
		/// Value for EventEnum.<br/>
		/// <br/>See also <seealso cref="EventEnum">EventEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		public sealed class CYCLE_COUNTValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="CYCLE_COUNTValue.Name" /></summary>
			public const string NAME = "CYCLE_COUNT";
			/// <summary>Constant value for <see cref="CYCLE_COUNTValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.8";
			/// <summary>Constant value for <see cref="CYCLE_COUNTValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="CYCLE_COUNTValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;accumulation of the number of times a cyclic function has attempted to, or is planned to attempt to execute.&#10;
";

			/// <inheritdoc />
			public string Name => NAME;
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => NORMATIVE_VERSION;
			
			/// <inheritdoc />
			public string DeprecatedVersion => DEPRECATED_VERSION;
			
			/// <inheritdoc />
			public string Summary => SUMMARY;
		}
		private VALVE_STATEValue _VALVE_STATE;
		/// <inheritdoc cref="VALVE_STATEValue" path="/summary" />
		public VALVE_STATEValue VALVE_STATE => _VALVE_STATE ?? (_VALVE_STATE = new VALVE_STATEValue());

		/// <summary>﻿state of a valve is one of open, closed, or transitioning between the states.<br /><br /><br />
		/// Value for EventEnum.<br/>
		/// <br/>See also <seealso cref="EventEnum">EventEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		public sealed class VALVE_STATEValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="VALVE_STATEValue.Name" /></summary>
			public const string NAME = "VALVE_STATE";
			/// <summary>Constant value for <see cref="VALVE_STATEValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.8";
			/// <summary>Constant value for <see cref="VALVE_STATEValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="VALVE_STATEValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;state of a valve is one of open, closed, or transitioning between the states.&#10;
";

			/// <inheritdoc />
			public string Name => NAME;
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => NORMATIVE_VERSION;
			
			/// <inheritdoc />
			public string DeprecatedVersion => DEPRECATED_VERSION;
			
			/// <inheritdoc />
			public string Summary => SUMMARY;
		}
		private LOCK_STATEValue _LOCK_STATE;
		/// <inheritdoc cref="LOCK_STATEValue" path="/summary" />
		public LOCK_STATEValue LOCK_STATE => _LOCK_STATE ?? (_LOCK_STATE = new LOCK_STATEValue());

		/// <summary>﻿state or operating mode of a <see cref="Lock">Lock</see>.<br /><br /><br />
		/// Value for EventEnum.<br/>
		/// <br/>See also <seealso cref="EventEnum">EventEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		public sealed class LOCK_STATEValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="LOCK_STATEValue.Name" /></summary>
			public const string NAME = "LOCK_STATE";
			/// <summary>Constant value for <see cref="LOCK_STATEValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.8";
			/// <summary>Constant value for <see cref="LOCK_STATEValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="LOCK_STATEValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;state or operating mode of a {{block(Lock)}}.&#10;
";

			/// <inheritdoc />
			public string Name => NAME;
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => NORMATIVE_VERSION;
			
			/// <inheritdoc />
			public string DeprecatedVersion => DEPRECATED_VERSION;
			
			/// <inheritdoc />
			public string Summary => SUMMARY;
		}
		private PROCESS_STATEValue _PROCESS_STATE;
		/// <inheritdoc cref="PROCESS_STATEValue" path="/summary" />
		public PROCESS_STATEValue PROCESS_STATE => _PROCESS_STATE ?? (_PROCESS_STATE = new PROCESS_STATEValue());

		/// <summary>﻿particular condition of the process occurrence at a specific time.<br /><br /><br />
		/// Value for EventEnum.<br/>
		/// <br/>See also <seealso cref="EventEnum">EventEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		public sealed class PROCESS_STATEValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="PROCESS_STATEValue.Name" /></summary>
			public const string NAME = "PROCESS_STATE";
			/// <summary>Constant value for <see cref="PROCESS_STATEValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.8";
			/// <summary>Constant value for <see cref="PROCESS_STATEValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="PROCESS_STATEValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;particular condition of the process occurrence at a specific time.&#10;
";

			/// <inheritdoc />
			public string Name => NAME;
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => NORMATIVE_VERSION;
			
			/// <inheritdoc />
			public string DeprecatedVersion => DEPRECATED_VERSION;
			
			/// <inheritdoc />
			public string Summary => SUMMARY;
		}
		private PART_PROCESSING_STATEValue _PART_PROCESSING_STATE;
		/// <inheritdoc cref="PART_PROCESSING_STATEValue" path="/summary" />
		public PART_PROCESSING_STATEValue PART_PROCESSING_STATE => _PART_PROCESSING_STATE ?? (_PART_PROCESSING_STATE = new PART_PROCESSING_STATEValue());

		/// <summary>﻿particular condition of the part occurrence at a specific time.<br /><br /><br />
		/// Value for EventEnum.<br/>
		/// <br/>See also <seealso cref="EventEnum">EventEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		public sealed class PART_PROCESSING_STATEValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="PART_PROCESSING_STATEValue.Name" /></summary>
			public const string NAME = "PART_PROCESSING_STATE";
			/// <summary>Constant value for <see cref="PART_PROCESSING_STATEValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.8";
			/// <summary>Constant value for <see cref="PART_PROCESSING_STATEValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="PART_PROCESSING_STATEValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;particular condition of the part occurrence at a specific time.&#10;
";

			/// <inheritdoc />
			public string Name => NAME;
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => NORMATIVE_VERSION;
			
			/// <inheritdoc />
			public string DeprecatedVersion => DEPRECATED_VERSION;
			
			/// <inheritdoc />
			public string Summary => SUMMARY;
		}
		private OPERATING_MODEValue _OPERATING_MODE;
		/// <inheritdoc cref="OPERATING_MODEValue" path="/summary" />
		public OPERATING_MODEValue OPERATING_MODE => _OPERATING_MODE ?? (_OPERATING_MODE = new OPERATING_MODEValue());

		/// <summary>﻿state of <see cref="Component">Component</see> or <see cref="Composition">Composition</see> that describes the automatic or manual operation of the entity.<br /><br /><br />
		/// Value for EventEnum.<br/>
		/// <br/>See also <seealso cref="EventEnum">EventEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		public sealed class OPERATING_MODEValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="OPERATING_MODEValue.Name" /></summary>
			public const string NAME = "OPERATING_MODE";
			/// <summary>Constant value for <see cref="OPERATING_MODEValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "2.0";
			/// <summary>Constant value for <see cref="OPERATING_MODEValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="OPERATING_MODEValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;state of {{block(Component)}} or {{block(Composition)}} that describes the automatic or manual operation of the entity.&#10;
";

			/// <inheritdoc />
			public string Name => NAME;
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => NORMATIVE_VERSION;
			
			/// <inheritdoc />
			public string DeprecatedVersion => DEPRECATED_VERSION;
			
			/// <inheritdoc />
			public string Summary => SUMMARY;
		}
		private ASSET_COUNTValue _ASSET_COUNT;
		/// <inheritdoc cref="ASSET_COUNTValue" path="/summary" />
		public ASSET_COUNTValue ASSET_COUNT => _ASSET_COUNT ?? (_ASSET_COUNT = new ASSET_COUNTValue());

		/// <summary>﻿<i>data set</i> of the number of <i>Asset</i>s of a given type for a <i>Device</i>.<br /><br /><br />
		/// Value for EventEnum.<br/>
		/// <br/>See also <seealso cref="EventEnum">EventEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		public sealed class ASSET_COUNTValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="ASSET_COUNTValue.Name" /></summary>
			public const string NAME = "ASSET_COUNT";
			/// <summary>Constant value for <see cref="ASSET_COUNTValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "2.0";
			/// <summary>Constant value for <see cref="ASSET_COUNTValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="ASSET_COUNTValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;{{term(data set)}} of the number of {{termplural(Asset)}} of a given type for a {{term(Device)}}.&#10;
";

			/// <inheritdoc />
			public string Name => NAME;
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => NORMATIVE_VERSION;
			
			/// <inheritdoc />
			public string DeprecatedVersion => DEPRECATED_VERSION;
			
			/// <inheritdoc />
			public string Summary => SUMMARY;
		}
		private MAINTENANCE_LISTValue _MAINTENANCE_LIST;
		/// <inheritdoc cref="MAINTENANCE_LISTValue" path="/summary" />
		public MAINTENANCE_LISTValue MAINTENANCE_LIST => _MAINTENANCE_LIST ?? (_MAINTENANCE_LIST = new MAINTENANCE_LISTValue());

		/// <summary>﻿actions or activities to be performed in support of a piece of equipment.<br /><br /><br />
		/// Value for EventEnum.<br/>
		/// <br/>See also <seealso cref="EventEnum">EventEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		public sealed class MAINTENANCE_LISTValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="MAINTENANCE_LISTValue.Name" /></summary>
			public const string NAME = "MAINTENANCE_LIST";
			/// <summary>Constant value for <see cref="MAINTENANCE_LISTValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "2.0";
			/// <summary>Constant value for <see cref="MAINTENANCE_LISTValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="MAINTENANCE_LISTValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;actions or activities to be performed in support of a piece of equipment.&#10;
";

			/// <inheritdoc />
			public string Name => NAME;
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => NORMATIVE_VERSION;
			
			/// <inheritdoc />
			public string DeprecatedVersion => DEPRECATED_VERSION;
			
			/// <inheritdoc />
			public string Summary => SUMMARY;
		}
		private FIXTURE_IDValue _FIXTURE_ID;
		/// <inheritdoc cref="FIXTURE_IDValue" path="/summary" />
		public FIXTURE_IDValue FIXTURE_ID => _FIXTURE_ID ?? (_FIXTURE_ID = new FIXTURE_IDValue());

		/// <summary>﻿identifier for the current workholding or part clamp in use by a piece of equipment.<br /><br /><br />
		/// Value for EventEnum.<br/>
		/// <br/>See also <seealso cref="EventEnum">EventEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		public sealed class FIXTURE_IDValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="FIXTURE_IDValue.Name" /></summary>
			public const string NAME = "FIXTURE_ID";
			/// <summary>Constant value for <see cref="FIXTURE_IDValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "2.0";
			/// <summary>Constant value for <see cref="FIXTURE_IDValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="FIXTURE_IDValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;identifier for the current workholding or part clamp in use by a piece of equipment.&#10;
";

			/// <inheritdoc />
			public string Name => NAME;
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => NORMATIVE_VERSION;
			
			/// <inheritdoc />
			public string DeprecatedVersion => DEPRECATED_VERSION;
			
			/// <inheritdoc />
			public string Summary => SUMMARY;
		}
		private PART_COUNT_TYPEValue _PART_COUNT_TYPE;
		/// <inheritdoc cref="PART_COUNT_TYPEValue" path="/summary" />
		public PART_COUNT_TYPEValue PART_COUNT_TYPE => _PART_COUNT_TYPE ?? (_PART_COUNT_TYPE = new PART_COUNT_TYPEValue());

		/// <summary>﻿interpretation of <c>PART_COUNT</c>.<br /><br /><br />
		/// Value for EventEnum.<br/>
		/// <br/>See also <seealso cref="EventEnum">EventEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		public sealed class PART_COUNT_TYPEValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="PART_COUNT_TYPEValue.Name" /></summary>
			public const string NAME = "PART_COUNT_TYPE";
			/// <summary>Constant value for <see cref="PART_COUNT_TYPEValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "2.0";
			/// <summary>Constant value for <see cref="PART_COUNT_TYPEValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="PART_COUNT_TYPEValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;interpretation of `PART_COUNT`.&#10;
";

			/// <inheritdoc />
			public string Name => NAME;
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => NORMATIVE_VERSION;
			
			/// <inheritdoc />
			public string DeprecatedVersion => DEPRECATED_VERSION;
			
			/// <inheritdoc />
			public string Summary => SUMMARY;
		}
		private CLOCK_TIMEValue _CLOCK_TIME;
		/// <inheritdoc cref="CLOCK_TIMEValue" path="/summary" />
		public CLOCK_TIMEValue CLOCK_TIME => _CLOCK_TIME ?? (_CLOCK_TIME = new CLOCK_TIMEValue());

		/// <summary>﻿time provided by a timing device at a specific point in time.<br /><br /><br />
		/// Value for EventEnum.<br/>
		/// <br/>See also <seealso cref="EventEnum">EventEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		public sealed class CLOCK_TIMEValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="CLOCK_TIMEValue.Name" /></summary>
			public const string NAME = "CLOCK_TIME";
			/// <summary>Constant value for <see cref="CLOCK_TIMEValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.2";
			/// <summary>Constant value for <see cref="CLOCK_TIMEValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="CLOCK_TIMEValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;time provided by a timing device at a specific point in time.&#10;
";

			/// <inheritdoc />
			public string Name => NAME;
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => NORMATIVE_VERSION;
			
			/// <inheritdoc />
			public string DeprecatedVersion => DEPRECATED_VERSION;
			
			/// <inheritdoc />
			public string Summary => SUMMARY;
		}
		private HOST_NAMEValue _HOST_NAME;
		/// <inheritdoc cref="HOST_NAMEValue" path="/summary" />
		public HOST_NAMEValue HOST_NAME => _HOST_NAME ?? (_HOST_NAME = new HOST_NAMEValue());

		/// <summary>﻿name of the host computer supplying data.<br /><br /><br />
		/// Value for EventEnum.<br/>
		/// <br/>See also <seealso cref="EventEnum">EventEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		public sealed class HOST_NAMEValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="HOST_NAMEValue.Name" /></summary>
			public const string NAME = "HOST_NAME";
			/// <summary>Constant value for <see cref="HOST_NAMEValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "2.1";
			/// <summary>Constant value for <see cref="HOST_NAMEValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="HOST_NAMEValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;name of the host computer supplying data.&#10;
";

			/// <inheritdoc />
			public string Name => NAME;
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => NORMATIVE_VERSION;
			
			/// <inheritdoc />
			public string DeprecatedVersion => DEPRECATED_VERSION;
			
			/// <inheritdoc />
			public string Summary => SUMMARY;
		}
		private NETWORK_PORTValue _NETWORK_PORT;
		/// <inheritdoc cref="NETWORK_PORTValue" path="/summary" />
		public NETWORK_PORTValue NETWORK_PORT => _NETWORK_PORT ?? (_NETWORK_PORT = new NETWORK_PORTValue());

		/// <summary>﻿number of the TCP/IP or UDP/IP port for the connection endpoint.<br /><br /><br />
		/// Value for EventEnum.<br/>
		/// <br/>See also <seealso cref="EventEnum">EventEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		public sealed class NETWORK_PORTValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="NETWORK_PORTValue.Name" /></summary>
			public const string NAME = "NETWORK_PORT";
			/// <summary>Constant value for <see cref="NETWORK_PORTValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "2.1";
			/// <summary>Constant value for <see cref="NETWORK_PORTValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="NETWORK_PORTValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;number of the TCP/IP or UDP/IP port for the connection endpoint.&#10;
";

			/// <inheritdoc />
			public string Name => NAME;
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => NORMATIVE_VERSION;
			
			/// <inheritdoc />
			public string DeprecatedVersion => DEPRECATED_VERSION;
			
			/// <inheritdoc />
			public string Summary => SUMMARY;
		}
		private LEAK_DETECTValue _LEAK_DETECT;
		/// <inheritdoc cref="LEAK_DETECTValue" path="/summary" />
		public LEAK_DETECTValue LEAK_DETECT => _LEAK_DETECT ?? (_LEAK_DETECT = new LEAK_DETECTValue());

		/// <summary>﻿indication designating whether a leak has been detected.<br /><br /><br />
		/// Value for EventEnum.<br/>
		/// <br/>See also <seealso cref="EventEnum">EventEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		public sealed class LEAK_DETECTValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="LEAK_DETECTValue.Name" /></summary>
			public const string NAME = "LEAK_DETECT";
			/// <summary>Constant value for <see cref="LEAK_DETECTValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "2.1";
			/// <summary>Constant value for <see cref="LEAK_DETECTValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="LEAK_DETECTValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;indication designating whether a leak has been detected.&#10;
";

			/// <inheritdoc />
			public string Name => NAME;
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => NORMATIVE_VERSION;
			
			/// <inheritdoc />
			public string DeprecatedVersion => DEPRECATED_VERSION;
			
			/// <inheritdoc />
			public string Summary => SUMMARY;
		}
		private BATTERY_STATEValue _BATTERY_STATE;
		/// <inheritdoc cref="BATTERY_STATEValue" path="/summary" />
		public BATTERY_STATEValue BATTERY_STATE => _BATTERY_STATE ?? (_BATTERY_STATE = new BATTERY_STATEValue());

		/// <summary>﻿present status of the battery.<br /><br /><br />
		/// Value for EventEnum.<br/>
		/// <br/>See also <seealso cref="EventEnum">EventEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		public sealed class BATTERY_STATEValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="BATTERY_STATEValue.Name" /></summary>
			public const string NAME = "BATTERY_STATE";
			/// <summary>Constant value for <see cref="BATTERY_STATEValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "2.1";
			/// <summary>Constant value for <see cref="BATTERY_STATEValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="BATTERY_STATEValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;present status of the battery.&#10;
";

			/// <inheritdoc />
			public string Name => NAME;
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => NORMATIVE_VERSION;
			
			/// <inheritdoc />
			public string DeprecatedVersion => DEPRECATED_VERSION;
			
			/// <inheritdoc />
			public string Summary => SUMMARY;
		}
		private FEATURE_PERSISTENT_IDValue _FEATURE_PERSISTENT_ID;
		/// <inheritdoc cref="FEATURE_PERSISTENT_IDValue" path="/summary" />
		public FEATURE_PERSISTENT_IDValue FEATURE_PERSISTENT_ID => _FEATURE_PERSISTENT_ID ?? (_FEATURE_PERSISTENT_ID = new FEATURE_PERSISTENT_IDValue());

		/// <summary>﻿<i>UUID</i> of a <i>feature</i>. <seealso href="https://www.google.com/search?q=ISO 10303 AP 242/239&amp;btnI=I">ISO 10303 AP 242/239</seealso>.<br /><br /><br />
		/// Value for EventEnum.<br/>
		/// <br/>See also <seealso cref="EventEnum">EventEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		public sealed class FEATURE_PERSISTENT_IDValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="FEATURE_PERSISTENT_IDValue.Name" /></summary>
			public const string NAME = "FEATURE_PERSISTENT_ID";
			/// <summary>Constant value for <see cref="FEATURE_PERSISTENT_IDValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "2.2";
			/// <summary>Constant value for <see cref="FEATURE_PERSISTENT_IDValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="FEATURE_PERSISTENT_IDValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;{{term(UUID)}} of a {{term(feature)}}. {{cite(ISO 10303 AP 242/239)}}.&#10;
";

			/// <inheritdoc />
			public string Name => NAME;
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => NORMATIVE_VERSION;
			
			/// <inheritdoc />
			public string DeprecatedVersion => DEPRECATED_VERSION;
			
			/// <inheritdoc />
			public string Summary => SUMMARY;
		}
		private SENSOR_STATEValue _SENSOR_STATE;
		/// <inheritdoc cref="SENSOR_STATEValue" path="/summary" />
		public SENSOR_STATEValue SENSOR_STATE => _SENSOR_STATE ?? (_SENSOR_STATE = new SENSOR_STATEValue());

		/// <summary>﻿detection result of a sensor.<br /><br /><br />
		/// Value for EventEnum.<br/>
		/// <br/>See also <seealso cref="EventEnum">EventEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		public sealed class SENSOR_STATEValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="SENSOR_STATEValue.Name" /></summary>
			public const string NAME = "SENSOR_STATE";
			/// <summary>Constant value for <see cref="SENSOR_STATEValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "2.2";
			/// <summary>Constant value for <see cref="SENSOR_STATEValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="SENSOR_STATEValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;detection result of a sensor.&#10;
";

			/// <inheritdoc />
			public string Name => NAME;
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => NORMATIVE_VERSION;
			
			/// <inheritdoc />
			public string DeprecatedVersion => DEPRECATED_VERSION;
			
			/// <inheritdoc />
			public string Summary => SUMMARY;
		}
		private COMPONENT_DATAValue _COMPONENT_DATA;
		/// <inheritdoc cref="COMPONENT_DATAValue" path="/summary" />
		public COMPONENT_DATAValue COMPONENT_DATA => _COMPONENT_DATA ?? (_COMPONENT_DATA = new COMPONENT_DATAValue());

		/// <summary>﻿<see cref="Event">Event</see> that represents a <see cref="Component">Component</see> where the <see cref="EntryDefinition">EntryDefinition</see> identifies the <see cref="Component">Component</see> and the <see cref="CellDefinition">CellDefinition</see>s define the <see cref="Component">Component</see>'s observed <see cref="DataItem">DataItem</see>s.<br /><br /><br />
		/// Value for EventEnum.<br/>
		/// <br/>See also <seealso cref="EventEnum">EventEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		public sealed class COMPONENT_DATAValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="COMPONENT_DATAValue.Name" /></summary>
			public const string NAME = "COMPONENT_DATA";
			/// <summary>Constant value for <see cref="COMPONENT_DATAValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "2.2";
			/// <summary>Constant value for <see cref="COMPONENT_DATAValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="COMPONENT_DATAValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;{{block(Event)}} that represents a {{block(Component)}} where the {{block(EntryDefinition)}} identifies the {{block(Component)}} and the {{block(CellDefinition)}}s define the {{block(Component)}}'s observed {{block(DataItem)}}s.&#10;
";

			/// <inheritdoc />
			public string Name => NAME;
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => NORMATIVE_VERSION;
			
			/// <inheritdoc />
			public string DeprecatedVersion => DEPRECATED_VERSION;
			
			/// <inheritdoc />
			public string Summary => SUMMARY;
		}
		private WORK_OFFSETSValue _WORK_OFFSETS;
		/// <inheritdoc cref="WORK_OFFSETSValue" path="/summary" />
		public WORK_OFFSETSValue WORK_OFFSETS => _WORK_OFFSETS ?? (_WORK_OFFSETS = new WORK_OFFSETSValue());

		/// <summary>﻿properties of each addressable work offset.<br /><br /><br />
		/// Value for EventEnum.<br/>
		/// <br/>See also <seealso cref="EventEnum">EventEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		public sealed class WORK_OFFSETSValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="WORK_OFFSETSValue.Name" /></summary>
			public const string NAME = "WORK_OFFSETS";
			/// <summary>Constant value for <see cref="WORK_OFFSETSValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "2.2";
			/// <summary>Constant value for <see cref="WORK_OFFSETSValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="WORK_OFFSETSValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;properties of each addressable work offset.&#10;
";

			/// <inheritdoc />
			public string Name => NAME;
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => NORMATIVE_VERSION;
			
			/// <inheritdoc />
			public string DeprecatedVersion => DEPRECATED_VERSION;
			
			/// <inheritdoc />
			public string Summary => SUMMARY;
		}
		private TOOL_OFFSETSValue _TOOL_OFFSETS;
		/// <inheritdoc cref="TOOL_OFFSETSValue" path="/summary" />
		public TOOL_OFFSETSValue TOOL_OFFSETS => _TOOL_OFFSETS ?? (_TOOL_OFFSETS = new TOOL_OFFSETSValue());

		/// <summary>﻿properties of each addressable tool offset.<br /><br /><br />
		/// Value for EventEnum.<br/>
		/// <br/>See also <seealso cref="EventEnum">EventEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		public sealed class TOOL_OFFSETSValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="TOOL_OFFSETSValue.Name" /></summary>
			public const string NAME = "TOOL_OFFSETS";
			/// <summary>Constant value for <see cref="TOOL_OFFSETSValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "2.2";
			/// <summary>Constant value for <see cref="TOOL_OFFSETSValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="TOOL_OFFSETSValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;properties of each addressable tool offset.&#10;
";

			/// <inheritdoc />
			public string Name => NAME;
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => NORMATIVE_VERSION;
			
			/// <inheritdoc />
			public string DeprecatedVersion => DEPRECATED_VERSION;
			
			/// <inheritdoc />
			public string Summary => SUMMARY;
		}
		private FEATURE_MEASUREMENTValue _FEATURE_MEASUREMENT;
		/// <inheritdoc cref="FEATURE_MEASUREMENTValue" path="/summary" />
		public FEATURE_MEASUREMENTValue FEATURE_MEASUREMENT => _FEATURE_MEASUREMENT ?? (_FEATURE_MEASUREMENT = new FEATURE_MEASUREMENTValue());

		/// <summary>﻿assessing elements of a <i>feature</i>.<br /><br /><br />
		/// Value for EventEnum.<br/>
		/// <br/>See also <seealso cref="EventEnum">EventEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		public sealed class FEATURE_MEASUREMENTValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="FEATURE_MEASUREMENTValue.Name" /></summary>
			public const string NAME = "FEATURE_MEASUREMENT";
			/// <summary>Constant value for <see cref="FEATURE_MEASUREMENTValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "2.2";
			/// <summary>Constant value for <see cref="FEATURE_MEASUREMENTValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="FEATURE_MEASUREMENTValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;assessing elements of a {{term(feature)}}.&#10;
";

			/// <inheritdoc />
			public string Name => NAME;
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => NORMATIVE_VERSION;
			
			/// <inheritdoc />
			public string DeprecatedVersion => DEPRECATED_VERSION;
			
			/// <inheritdoc />
			public string Summary => SUMMARY;
		}
		private CHARACTERISTIC_PERSISTENT_IDValue _CHARACTERISTIC_PERSISTENT_ID;
		/// <inheritdoc cref="CHARACTERISTIC_PERSISTENT_IDValue" path="/summary" />
		public CHARACTERISTIC_PERSISTENT_IDValue CHARACTERISTIC_PERSISTENT_ID => _CHARACTERISTIC_PERSISTENT_ID ?? (_CHARACTERISTIC_PERSISTENT_ID = new CHARACTERISTIC_PERSISTENT_IDValue());

		/// <summary>﻿<i>UUID</i> of the <i>characteristic</i>.<br /><br /><br />
		/// Value for EventEnum.<br/>
		/// <br/>See also <seealso cref="EventEnum">EventEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		public sealed class CHARACTERISTIC_PERSISTENT_IDValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="CHARACTERISTIC_PERSISTENT_IDValue.Name" /></summary>
			public const string NAME = "CHARACTERISTIC_PERSISTENT_ID";
			/// <summary>Constant value for <see cref="CHARACTERISTIC_PERSISTENT_IDValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "2.2";
			/// <summary>Constant value for <see cref="CHARACTERISTIC_PERSISTENT_IDValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="CHARACTERISTIC_PERSISTENT_IDValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;{{term(UUID)}} of the {{term(characteristic)}}.&#10;
";

			/// <inheritdoc />
			public string Name => NAME;
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => NORMATIVE_VERSION;
			
			/// <inheritdoc />
			public string DeprecatedVersion => DEPRECATED_VERSION;
			
			/// <inheritdoc />
			public string Summary => SUMMARY;
		}
		private MEASUREMENT_TYPEValue _MEASUREMENT_TYPE;
		/// <inheritdoc cref="MEASUREMENT_TYPEValue" path="/summary" />
		public MEASUREMENT_TYPEValue MEASUREMENT_TYPE => _MEASUREMENT_TYPE ?? (_MEASUREMENT_TYPE = new MEASUREMENT_TYPEValue());

		/// <summary>﻿class of measurement being performed. <seealso href="https://www.google.com/search?q=QIF 3:2018 Section 6.3&amp;btnI=I">QIF 3:2018 Section 6.3</seealso><br /><br /><br />
		/// Value for EventEnum.<br/>
		/// <br/>See also <seealso cref="EventEnum">EventEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		public sealed class MEASUREMENT_TYPEValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="MEASUREMENT_TYPEValue.Name" /></summary>
			public const string NAME = "MEASUREMENT_TYPE";
			/// <summary>Constant value for <see cref="MEASUREMENT_TYPEValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "2.2";
			/// <summary>Constant value for <see cref="MEASUREMENT_TYPEValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="MEASUREMENT_TYPEValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;class of measurement being performed. {{cite(QIF 3:2018 Section 6.3)}}&#10;
";

			/// <inheritdoc />
			public string Name => NAME;
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => NORMATIVE_VERSION;
			
			/// <inheritdoc />
			public string DeprecatedVersion => DEPRECATED_VERSION;
			
			/// <inheritdoc />
			public string Summary => SUMMARY;
		}
		private MEASUREMENT_VALUEValue _MEASUREMENT_VALUE;
		/// <inheritdoc cref="MEASUREMENT_VALUEValue" path="/summary" />
		public MEASUREMENT_VALUEValue MEASUREMENT_VALUE => _MEASUREMENT_VALUE ?? (_MEASUREMENT_VALUE = new MEASUREMENT_VALUEValue());

		/// <summary>﻿measurement based on the measurement type.<br /><br /><br />
		/// Value for EventEnum.<br/>
		/// <br/>See also <seealso cref="EventEnum">EventEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		public sealed class MEASUREMENT_VALUEValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="MEASUREMENT_VALUEValue.Name" /></summary>
			public const string NAME = "MEASUREMENT_VALUE";
			/// <summary>Constant value for <see cref="MEASUREMENT_VALUEValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "2.2";
			/// <summary>Constant value for <see cref="MEASUREMENT_VALUEValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="MEASUREMENT_VALUEValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;measurement based on the measurement type.&#10;
";

			/// <inheritdoc />
			public string Name => NAME;
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => NORMATIVE_VERSION;
			
			/// <inheritdoc />
			public string DeprecatedVersion => DEPRECATED_VERSION;
			
			/// <inheritdoc />
			public string Summary => SUMMARY;
		}
		private MEASUREMENT_UNITSValue _MEASUREMENT_UNITS;
		/// <inheritdoc cref="MEASUREMENT_UNITSValue" path="/summary" />
		public MEASUREMENT_UNITSValue MEASUREMENT_UNITS => _MEASUREMENT_UNITS ?? (_MEASUREMENT_UNITS = new MEASUREMENT_UNITSValue());

		/// <summary>﻿engineering units of the measurement.<br /><br /><br />
		/// Value for EventEnum.<br/>
		/// <br/>See also <seealso cref="EventEnum">EventEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		public sealed class MEASUREMENT_UNITSValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="MEASUREMENT_UNITSValue.Name" /></summary>
			public const string NAME = "MEASUREMENT_UNITS";
			/// <summary>Constant value for <see cref="MEASUREMENT_UNITSValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "2.2";
			/// <summary>Constant value for <see cref="MEASUREMENT_UNITSValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="MEASUREMENT_UNITSValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;engineering units of the measurement.&#10;
";

			/// <inheritdoc />
			public string Name => NAME;
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => NORMATIVE_VERSION;
			
			/// <inheritdoc />
			public string DeprecatedVersion => DEPRECATED_VERSION;
			
			/// <inheritdoc />
			public string Summary => SUMMARY;
		}
		private CHARACTERISTIC_STATUSValue _CHARACTERISTIC_STATUS;
		/// <inheritdoc cref="CHARACTERISTIC_STATUSValue" path="/summary" />
		public CHARACTERISTIC_STATUSValue CHARACTERISTIC_STATUS => _CHARACTERISTIC_STATUS ?? (_CHARACTERISTIC_STATUS = new CHARACTERISTIC_STATUSValue());

		/// <summary>﻿pass/fail result of the measurement.<br /><br /><br />
		/// Value for EventEnum.<br/>
		/// <br/>See also <seealso cref="EventEnum">EventEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		public sealed class CHARACTERISTIC_STATUSValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="CHARACTERISTIC_STATUSValue.Name" /></summary>
			public const string NAME = "CHARACTERISTIC_STATUS";
			/// <summary>Constant value for <see cref="CHARACTERISTIC_STATUSValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "2.2";
			/// <summary>Constant value for <see cref="CHARACTERISTIC_STATUSValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="CHARACTERISTIC_STATUSValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;pass/fail result of the measurement.&#10;
";

			/// <inheritdoc />
			public string Name => NAME;
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => NORMATIVE_VERSION;
			
			/// <inheritdoc />
			public string DeprecatedVersion => DEPRECATED_VERSION;
			
			/// <inheritdoc />
			public string Summary => SUMMARY;
		}
		private UNCERTAINTY_TYPEValue _UNCERTAINTY_TYPE;
		/// <inheritdoc cref="UNCERTAINTY_TYPEValue" path="/summary" />
		public UNCERTAINTY_TYPEValue UNCERTAINTY_TYPE => _UNCERTAINTY_TYPE ?? (_UNCERTAINTY_TYPE = new UNCERTAINTY_TYPEValue());

		/// <summary>﻿method used to compute <i>standard uncertainty</i>.<br /><br /><br />
		/// Value for EventEnum.<br/>
		/// <br/>See also <seealso cref="EventEnum">EventEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		public sealed class UNCERTAINTY_TYPEValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="UNCERTAINTY_TYPEValue.Name" /></summary>
			public const string NAME = "UNCERTAINTY_TYPE";
			/// <summary>Constant value for <see cref="UNCERTAINTY_TYPEValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "2.2";
			/// <summary>Constant value for <see cref="UNCERTAINTY_TYPEValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="UNCERTAINTY_TYPEValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;method used to compute {{term(standard uncertainty)}}.&#10;
";

			/// <inheritdoc />
			public string Name => NAME;
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => NORMATIVE_VERSION;
			
			/// <inheritdoc />
			public string DeprecatedVersion => DEPRECATED_VERSION;
			
			/// <inheritdoc />
			public string Summary => SUMMARY;
		}
		private UNCERTAINTYValue _UNCERTAINTY;
		/// <inheritdoc cref="UNCERTAINTYValue" path="/summary" />
		public UNCERTAINTYValue UNCERTAINTY => _UNCERTAINTY ?? (_UNCERTAINTY = new UNCERTAINTYValue());

		/// <summary>﻿<i>uncertainty</i> specified by <see cref="UncertaintyType">UncertaintyType</see>.<br /><br /><br />
		/// Value for EventEnum.<br/>
		/// <br/>See also <seealso cref="EventEnum">EventEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		public sealed class UNCERTAINTYValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="UNCERTAINTYValue.Name" /></summary>
			public const string NAME = "UNCERTAINTY";
			/// <summary>Constant value for <see cref="UNCERTAINTYValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "2.2";
			/// <summary>Constant value for <see cref="UNCERTAINTYValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="UNCERTAINTYValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;{{term(uncertainty)}} specified by {{block(UncertaintyType)}}.&#10;
";

			/// <inheritdoc />
			public string Name => NAME;
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => NORMATIVE_VERSION;
			
			/// <inheritdoc />
			public string DeprecatedVersion => DEPRECATED_VERSION;
			
			/// <inheritdoc />
			public string Summary => SUMMARY;
		}
		private SPECIFICATION_LIMITSValue _SPECIFICATION_LIMITS;
		/// <inheritdoc cref="SPECIFICATION_LIMITSValue" path="/summary" />
		public SPECIFICATION_LIMITSValue SPECIFICATION_LIMITS => _SPECIFICATION_LIMITS ?? (_SPECIFICATION_LIMITS = new SPECIFICATION_LIMITSValue());

		/// <summary>﻿set of limits defining a range of values designating acceptable performance for a variable.<br /><br /><br />
		/// Value for EventEnum.<br/>
		/// <br/>See also <seealso cref="EventEnum">EventEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		public sealed class SPECIFICATION_LIMITSValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="SPECIFICATION_LIMITSValue.Name" /></summary>
			public const string NAME = "SPECIFICATION_LIMITS";
			/// <summary>Constant value for <see cref="SPECIFICATION_LIMITSValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "2.3";
			/// <summary>Constant value for <see cref="SPECIFICATION_LIMITSValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="SPECIFICATION_LIMITSValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;set of limits defining a range of values designating acceptable performance for a variable.&#10;
";

			/// <inheritdoc />
			public string Name => NAME;
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => NORMATIVE_VERSION;
			
			/// <inheritdoc />
			public string DeprecatedVersion => DEPRECATED_VERSION;
			
			/// <inheritdoc />
			public string Summary => SUMMARY;
		}
		private CONTROL_LIMITSValue _CONTROL_LIMITS;
		/// <inheritdoc cref="CONTROL_LIMITSValue" path="/summary" />
		public CONTROL_LIMITSValue CONTROL_LIMITS => _CONTROL_LIMITS ?? (_CONTROL_LIMITS = new CONTROL_LIMITSValue());

		/// <summary>﻿set of limits used to indicate whether a process variable is stable and in control.<br /><br /><br />
		/// Value for EventEnum.<br/>
		/// <br/>See also <seealso cref="EventEnum">EventEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		public sealed class CONTROL_LIMITSValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="CONTROL_LIMITSValue.Name" /></summary>
			public const string NAME = "CONTROL_LIMITS";
			/// <summary>Constant value for <see cref="CONTROL_LIMITSValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "2.3";
			/// <summary>Constant value for <see cref="CONTROL_LIMITSValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="CONTROL_LIMITSValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;set of limits used to indicate whether a process variable is stable and in control.&#10;
";

			/// <inheritdoc />
			public string Name => NAME;
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => NORMATIVE_VERSION;
			
			/// <inheritdoc />
			public string DeprecatedVersion => DEPRECATED_VERSION;
			
			/// <inheritdoc />
			public string Summary => SUMMARY;
		}
		private ALARM_LIMITSValue _ALARM_LIMITS;
		/// <inheritdoc cref="ALARM_LIMITSValue" path="/summary" />
		public ALARM_LIMITSValue ALARM_LIMITS => _ALARM_LIMITS ?? (_ALARM_LIMITS = new ALARM_LIMITSValue());

		/// <summary>﻿set of limits used to trigger warning or alarm indicators.<br /><br /><br />
		/// Value for EventEnum.<br/>
		/// <br/>See also <seealso cref="EventEnum">EventEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		public sealed class ALARM_LIMITSValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="ALARM_LIMITSValue.Name" /></summary>
			public const string NAME = "ALARM_LIMITS";
			/// <summary>Constant value for <see cref="ALARM_LIMITSValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "2.3";
			/// <summary>Constant value for <see cref="ALARM_LIMITSValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="ALARM_LIMITSValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;set of limits used to trigger warning or alarm indicators.&#10;
";

			/// <inheritdoc />
			public string Name => NAME;
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => NORMATIVE_VERSION;
			
			/// <inheritdoc />
			public string DeprecatedVersion => DEPRECATED_VERSION;
			
			/// <inheritdoc />
			public string Summary => SUMMARY;
		}
		private TOOL_CUTTING_ITEMValue _TOOL_CUTTING_ITEM;
		/// <inheritdoc cref="TOOL_CUTTING_ITEMValue" path="/summary" />
		public TOOL_CUTTING_ITEMValue TOOL_CUTTING_ITEM => _TOOL_CUTTING_ITEM ?? (_TOOL_CUTTING_ITEM = new TOOL_CUTTING_ITEMValue());

		/// <summary>﻿references the <see cref="CuttingToolLifeCycle">CuttingToolLifeCycle</see> <see cref="CuttingItem">CuttingItem</see> index related to the <see cref="CuttingItem.indices">indices in CuttingItem</see> of the currently active cutting tool edge.<br /><br /><br />
		/// Value for EventEnum.<br/>
		/// <br/>See also <seealso cref="EventEnum">EventEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		public sealed class TOOL_CUTTING_ITEMValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="TOOL_CUTTING_ITEMValue.Name" /></summary>
			public const string NAME = "TOOL_CUTTING_ITEM";
			/// <summary>Constant value for <see cref="TOOL_CUTTING_ITEMValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "2.3";
			/// <summary>Constant value for <see cref="TOOL_CUTTING_ITEMValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="TOOL_CUTTING_ITEMValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;references the {{block(CuttingToolLifeCycle)}} {{block(CuttingItem)}} index related to the {{property(CuttingItem::indices)}} of the currently active cutting tool edge.&#10;
";

			/// <inheritdoc />
			public string Name => NAME;
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => NORMATIVE_VERSION;
			
			/// <inheritdoc />
			public string DeprecatedVersion => DEPRECATED_VERSION;
			
			/// <inheritdoc />
			public string Summary => SUMMARY;
		}
		private LOCATION_ADDRESSValue _LOCATION_ADDRESS;
		/// <inheritdoc cref="LOCATION_ADDRESSValue" path="/summary" />
		public LOCATION_ADDRESSValue LOCATION_ADDRESS => _LOCATION_ADDRESS ?? (_LOCATION_ADDRESS = new LOCATION_ADDRESSValue());

		/// <summary>﻿structured information that allows the unambiguous determination of an object for purposes of identification and location. <seealso href="https://www.google.com/search?q=ISO 19160-4:2017&amp;btnI=I">ISO 19160-4:2017</seealso><br /><br /><br />
		/// Value for EventEnum.<br/>
		/// <br/>See also <seealso cref="EventEnum">EventEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		public sealed class LOCATION_ADDRESSValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="LOCATION_ADDRESSValue.Name" /></summary>
			public const string NAME = "LOCATION_ADDRESS";
			/// <summary>Constant value for <see cref="LOCATION_ADDRESSValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "2.3";
			/// <summary>Constant value for <see cref="LOCATION_ADDRESSValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="LOCATION_ADDRESSValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;structured information that allows the unambiguous determination of an object for purposes of identification and location. {{cite(ISO 19160-4:2017)}}&#10;
";

			/// <inheritdoc />
			public string Name => NAME;
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => NORMATIVE_VERSION;
			
			/// <inheritdoc />
			public string DeprecatedVersion => DEPRECATED_VERSION;
			
			/// <inheritdoc />
			public string Summary => SUMMARY;
		}
		private POWER_SOURCEValue _POWER_SOURCE;
		/// <inheritdoc cref="POWER_SOURCEValue" path="/summary" />
		public POWER_SOURCEValue POWER_SOURCE => _POWER_SOURCE ?? (_POWER_SOURCE = new POWER_SOURCEValue());

		/// <summary>﻿active energy source for the <see cref="Component">Component</see>.<br /><br /><br />
		/// Value for EventEnum.<br/>
		/// <br/>See also <seealso cref="EventEnum">EventEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		public sealed class POWER_SOURCEValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="POWER_SOURCEValue.Name" /></summary>
			public const string NAME = "POWER_SOURCE";
			/// <summary>Constant value for <see cref="POWER_SOURCEValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "2.3";
			/// <summary>Constant value for <see cref="POWER_SOURCEValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="POWER_SOURCEValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;active energy source for the {{block(Component)}}.&#10;
";

			/// <inheritdoc />
			public string Name => NAME;
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => NORMATIVE_VERSION;
			
			/// <inheritdoc />
			public string DeprecatedVersion => DEPRECATED_VERSION;
			
			/// <inheritdoc />
			public string Summary => SUMMARY;
		}
	}
}