#pragma warning disable CS1574 // XML comment has cref attribute that could not be resolved
#pragma warning disable CS1584 // XML comment has syntactically incorrect cref attribute
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
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.1">v1.1</see></item>
		/// </list>
		/// </remarks>
		ACTIVE_AXES,
		/// <summary>﻿operational state of an apparatus for moving or controlling a mechanism or system.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.2">v1.2</see></item>
		/// </list>
		/// </remarks>
		ACTUATOR_STATE,
		/// <summary>﻿<b>DEPRECATED:</b> Replaced with <c>CONDITION</c> category data items in Version 1.1.0.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// <item><b>Deprecated</b>: <see href="https://model.mtconnect.org/#_Version_1.1">v1.1</see></item>
		/// </list>
		/// </remarks>
		[Obsolete("Deprecated in v1.1 according to https://model.mtconnect.org/#_Version_1.1")]
		ALARM,
		/// <summary>﻿<see cref="assetId">assetId</see> of the <i>Asset</i> that has been added or changed.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.2">v1.2</see></item>
		/// </list>
		/// </remarks>
		ASSET_CHANGED,
		/// <summary>﻿<see cref="assetId">assetId</see> of the <i>Asset</i> that has been removed.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.3">v1.3</see></item>
		/// </list>
		/// </remarks>
		ASSET_REMOVED,
		/// <summary>﻿<i>agent</i>'s ability to communicate with the data source.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.1">v1.1</see></item>
		/// </list>
		/// </remarks>
		AVAILABILITY,
		/// <summary>﻿describes the way the axes will be associated to each other. <br />  <br />This is used in conjunction with <c>COUPLED_AXES</c> to indicate the way they are interacting.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.1">v1.1</see></item>
		/// </list>
		/// </remarks>
		AXIS_COUPLING,
		/// <summary>﻿value of a signal or calculation issued to adjust the feedrate of an individual linear type axis.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.3">v1.3</see></item>
		/// </list>
		/// </remarks>
		AXIS_FEEDRATE_OVERRIDE,
		/// <summary>﻿state of the axis lockout function when power has been removed and the axis is allowed to move freely.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.3">v1.3</see></item>
		/// </list>
		/// </remarks>
		AXIS_INTERLOCK,
		/// <summary>﻿state of a <see cref="Linear">Linear</see> or <see cref="Rotary">Rotary</see> component representing an axis.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.3">v1.3</see></item>
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
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.4">v1.4</see></item>
		/// </list>
		/// </remarks>
		BLOCK_COUNT,
		/// <summary>﻿state of an interlock function or control logic state intended to prevent the associated <see cref="Chuck">Chuck</see> component from being operated.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.3">v1.3</see></item>
		/// </list>
		/// </remarks>
		CHUCK_INTERLOCK,
		/// <summary>﻿operating state of a mechanism that holds a part or stock material during a manufacturing process. <br /><br />It may also represent a mechanism that holds any other mechanism in place within a piece of equipment.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.3">v1.3</see></item>
		/// </list>
		/// </remarks>
		CHUCK_STATE,
		/// <summary>﻿programmatic code being executed.<br /><br /><b>DEPRECATED</b> in <i>Version 1.1</i>.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// <item><b>Deprecated</b>: <see href="https://model.mtconnect.org/#_Version_1.1">v1.1</see></item>
		/// </list>
		/// </remarks>
		[Obsolete("Deprecated in v1.1 according to https://model.mtconnect.org/#_Version_1.1")]
		CODE,
		/// <summary>﻿operating state of a mechanism represented by a <see cref="Composition">Composition</see> entity.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.4">v1.4</see></item>
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
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.4">v1.4</see></item>
		/// </list>
		/// </remarks>
		CONTROLLER_MODE_OVERRIDE,
		/// <summary>﻿set of associated axes.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.2">v1.2</see></item>
		/// </list>
		/// </remarks>
		COUPLED_AXES,
		/// <summary>﻿time and date code associated with a material or other physical item.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.5">v1.5</see></item>
		/// </list>
		/// </remarks>
		DATE_CODE,
		/// <summary>﻿identifier of another piece of equipment that is temporarily associated with a component of this piece of equipment to perform a particular function.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.5">v1.5</see></item>
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
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.1">v1.1</see></item>
		/// </list>
		/// </remarks>
		DOOR_STATE,
		/// <summary>﻿state of the emergency stop signal for a piece of equipment, controller path, or any other component or subsystem of a piece of equipment.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.1">v1.1</see></item>
		/// </list>
		/// </remarks>
		EMERGENCY_STOP,
		/// <summary>﻿indication of whether the end of a piece of bar stock being feed by a bar feeder has been reached.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.3">v1.3</see></item>
		/// </list>
		/// </remarks>
		END_OF_BAR,
		/// <summary>﻿indication that a piece of equipment, or a sub-part of a piece of equipment, is performing specific types of activities.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.4">v1.4</see></item>
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
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.3">v1.3</see></item>
		/// </list>
		/// </remarks>
		FUNCTIONAL_MODE,
		/// <summary>﻿hardness of a material.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.4">v1.4</see></item>
		/// </list>
		/// </remarks>
		HARDNESS,
		/// <summary>﻿current line of code being executed.<br /><br /><b>DEPRECATED</b> in <i>Version 1.4.0</i>.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// <item><b>Deprecated</b>: <see href="https://model.mtconnect.org/#_Version_1.4">v1.4</see></item>
		/// </list>
		/// </remarks>
		[Obsolete("Deprecated in v1.4 according to https://model.mtconnect.org/#_Version_1.4")]
		LINE,
		/// <summary>﻿identifier for a <see cref="Block">Block</see> of code in a <see cref="Program">Program</see>.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.4">v1.4</see></item>
		/// </list>
		/// </remarks>
		LINE_LABEL,
		/// <summary>﻿position of a block of program code within a control program.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.4">v1.4</see></item>
		/// </list>
		/// </remarks>
		LINE_NUMBER,
		/// <summary>﻿identifier of a material used or consumed in the manufacturing process.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.4">v1.4</see></item>
		/// </list>
		/// </remarks>
		MATERIAL,
		/// <summary>﻿identifies the layers of material applied to a part or product as part of an additive manufacturing process.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.5">v1.5</see></item>
		/// </list>
		/// </remarks>
		MATERIAL_LAYER,
		/// <summary>﻿information to be transferred from a piece of equipment to a client software application.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.1">v1.1</see></item>
		/// </list>
		/// </remarks>
		MESSAGE,
		/// <summary>﻿identifier of the person currently responsible for operating the piece of equipment.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.3">v1.3</see></item>
		/// </list>
		/// </remarks>
		OPERATOR_ID,
		/// <summary>﻿identifier for a pallet.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.2">v1.2</see></item>
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
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.5">v1.5</see></item>
		/// </list>
		/// </remarks>
		PART_DETECT,
		/// <summary>﻿identifier of a part in a manufacturing operation.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.1">v1.1</see></item>
		/// </list>
		/// </remarks>
		PART_ID,
		/// <summary>﻿identifier of a part or product moving through the manufacturing process.<br /><br /><b>DEPRECATED</b> in <i>Version 1.7</i>. <c>PART_NUMBER</c> is now a <c>subType</c> of <c>PART_KIND_ID</c>.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.4">v1.4</see></item>
		/// <item><b>Deprecated</b>: <see href="https://model.mtconnect.org/#_Version_1.7">v1.7</see></item>
		/// </list>
		/// </remarks>
		[Obsolete("Deprecated in v1.7 according to https://model.mtconnect.org/#_Version_1.7")]
		PART_NUMBER,
		/// <summary>﻿value of a signal or calculation issued to adjust the feedrate for the axes associated with a <see cref="Path">Path</see> component that may represent a single axis or the coordinated movement of multiple axes.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.3">v1.3</see></item>
		/// </list>
		/// </remarks>
		PATH_FEEDRATE_OVERRIDE,
		/// <summary>﻿describes the operational relationship between a <see cref="Path">Path</see> entity and another <see cref="Path">Path</see> entity for pieces of equipment comprised of multiple logical groupings of controlled axes or other logical operations.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.1">v1.1</see></item>
		/// </list>
		/// </remarks>
		PATH_MODE,
		/// <summary>﻿indication of the status of the source of energy for an entity to allow it to perform its intended function or the state of an enabling signal providing permission for the entity to perform its functions.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.1">v1.1</see></item>
		/// </list>
		/// </remarks>
		POWER_STATE,
		/// <summary>﻿status of the <see cref="Component">Component</see>.<br /><br /><b>DEPRECATED</b> in <i>Version 1.1.0</i>.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// <item><b>Deprecated</b>: <see href="https://model.mtconnect.org/#_Version_1.1">v1.1</see></item>
		/// </list>
		/// </remarks>
		[Obsolete("Deprecated in v1.1 according to https://model.mtconnect.org/#_Version_1.1")]
		POWER_STATUS,
		/// <summary>﻿time and date associated with an activity or event.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.5">v1.5</see></item>
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
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.3">v1.3</see></item>
		/// </list>
		/// </remarks>
		PROGRAM_COMMENT,
		/// <summary>﻿indication of the status of the <see cref="Controller">Controller</see> components program editing mode.<br /><br />A program may be edited while another is executed.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.3">v1.3</see></item>
		/// </list>
		/// </remarks>
		PROGRAM_EDIT,
		/// <summary>﻿name of the program being edited. <br /><br />This is used in conjunction with <see cref="ProgramEdit">ProgramEdit</see> when in <c>ACTIVE</c> state. <br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.3">v1.3</see></item>
		/// </list>
		/// </remarks>
		PROGRAM_EDIT_NAME,
		/// <summary>﻿non-executable header section of the control program.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.3">v1.3</see></item>
		/// </list>
		/// </remarks>
		PROGRAM_HEADER,
		/// <summary>﻿<i>URI</i> for the source file associated with <see cref="Program">Program</see>.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.5">v1.5</see></item>
		/// </list>
		/// </remarks>
		PROGRAM_LOCATION,
		/// <summary>﻿defines whether the logic or motion program defined by <see cref="Program">Program</see> is being executed from the local memory of the controller or from an outside source.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.5">v1.5</see></item>
		/// </list>
		/// </remarks>
		PROGRAM_LOCATION_TYPE,
		/// <summary>﻿indication of the nesting level within a control program that is associated with the code or instructions that is currently being executed.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.5">v1.5</see></item>
		/// </list>
		/// </remarks>
		PROGRAM_NEST_LEVEL,
		/// <summary>﻿current operating mode for a <see cref="Rotary">Rotary</see> type axis.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.1">v1.1</see></item>
		/// </list>
		/// </remarks>
		ROTARY_MODE,
		/// <summary>﻿percentage change to the velocity of the programmed velocity for a <see cref="Rotary">Rotary</see> axis.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.3">v1.3</see></item>
		/// </list>
		/// </remarks>
		ROTARY_VELOCITY_OVERRIDE,
		/// <summary>﻿serial number associated with a <see cref="Component">Component</see>, <see cref="Asset">Asset</see>, or <see cref="Device">Device</see>.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.4">v1.4</see></item>
		/// </list>
		/// </remarks>
		SERIAL_NUMBER,
		/// <summary>﻿indication of the status of the spindle for a piece of equipment when power has been removed and it is free to rotate.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.3">v1.3</see></item>
		/// </list>
		/// </remarks>
		SPINDLE_INTERLOCK,
		/// <summary>﻿identifier of an individual tool asset.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.2">v1.2</see></item>
		/// </list>
		/// </remarks>
		TOOL_ASSET_ID,
		/// <summary>﻿identifier for the tool group associated with a specific tool. Commonly used to designate spare tools.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.5">v1.5</see></item>
		/// </list>
		/// </remarks>
		TOOL_GROUP,
		/// <summary>﻿identifier of the tool currently in use for a given <c>Path</c>.<br /><br /><b>DEPRECATED</b> in <i>Version 1.2.0</i>.   See <c>TOOL_ASSET_ID</c>.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.1">v1.1</see></item>
		/// <item><b>Deprecated</b>: <see href="https://model.mtconnect.org/#_Version_1.2">v1.2</see></item>
		/// </list>
		/// </remarks>
		[Obsolete("Deprecated in v1.2 according to https://model.mtconnect.org/#_Version_1.2")]
		TOOL_ID,
		/// <summary>﻿identifier assigned by the <see cref="Controller">Controller</see> component to a cutting tool when in use by a piece of equipment.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.2">v1.2</see></item>
		/// </list>
		/// </remarks>
		TOOL_NUMBER,
		/// <summary>﻿reference to the tool offset variables applied to the active cutting tool.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.4">v1.4</see></item>
		/// </list>
		/// </remarks>
		TOOL_OFFSET,
		/// <summary>﻿identifier of the person currently responsible for operating the piece of equipment.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.4">v1.4</see></item>
		/// </list>
		/// </remarks>
		USER,
		/// <summary>﻿data whose meaning may change over time due to changes in the operation of a piece of equipment or the process being executed on that piece of equipment.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.5">v1.5</see></item>
		/// </list>
		/// </remarks>
		VARIABLE,
		/// <summary>﻿indication of the reason that <see cref="Execution">Execution</see> is reporting a value of <c>WAIT</c>.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.5">v1.5</see></item>
		/// </list>
		/// </remarks>
		WAIT_STATE,
		/// <summary>﻿identifier for the type of wire used as the cutting mechanism in Electrical Discharge Machining or similar processes.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.4">v1.4</see></item>
		/// </list>
		/// </remarks>
		WIRE,
		/// <summary>﻿identifier for the current workholding or part clamp in use by a piece of equipment.<br /><br /><b>DEPRECATION WARNING</b>: Recommend using <c>FIXTURE_ID</c> instead.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.1">v1.1</see></item>
		/// </list>
		/// </remarks>
		WORKHOLDING_ID,
		/// <summary>﻿reference to offset variables for a work piece or part.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.4">v1.4</see></item>
		/// </list>
		/// </remarks>
		WORK_OFFSET,
		/// <summary>﻿Operating System (OS) of a <see cref="Component">Component</see>.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.6">v1.6</see></item>
		/// </list>
		/// </remarks>
		OPERATING_SYSTEM,
		/// <summary>﻿embedded software of a <see cref="Component">Component</see><br />.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.6">v1.6</see></item>
		/// </list>
		/// </remarks>
		FIRMWARE,
		/// <summary>﻿application on a <see cref="Component">Component</see>.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.6">v1.6</see></item>
		/// </list>
		/// </remarks>
		APPLICATION,
		/// <summary>﻿software library on a <see cref="Component">Component</see><br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.6">v1.6</see></item>
		/// </list>
		/// </remarks>
		LIBRARY,
		/// <summary>﻿hardware of a <see cref="Component">Component</see>.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.6">v1.6</see></item>
		/// </list>
		/// </remarks>
		HARDWARE,
		/// <summary>﻿network details of a <see cref="Component">Component</see>.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.6">v1.6</see></item>
		/// </list>
		/// </remarks>
		NETWORK,
		/// <summary>﻿three space angular displacement of an object or coordinate system relative to a <i>cartesian coordinate system</i>.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.6">v1.6</see></item>
		/// </list>
		/// </remarks>
		ROTATION,
		/// <summary>﻿three space linear displacement of an object or coordinate system relative to a <i>cartesian coordinate system</i>.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.6">v1.6</see></item>
		/// </list>
		/// </remarks>
		TRANSLATION,
		/// <summary>﻿<i>UUID</i> of new device added to an <i>MTConnect Agent</i>.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.7">v1.7</see></item>
		/// </list>
		/// </remarks>
		DEVICE_ADDED,
		/// <summary>﻿<i>UUID</i> of a device removed from an <i>MTConnect Agent</i>.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.7">v1.7</see></item>
		/// </list>
		/// </remarks>
		DEVICE_REMOVED,
		/// <summary>﻿<i>UUID</i> of the device whose <i>metadata</i> has changed.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.7">v1.7</see></item>
		/// </list>
		/// </remarks>
		DEVICE_CHANGED,
		/// <summary>﻿status of the connection between an <i>adapter</i> and an <i>agent</i>.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.7">v1.7</see></item>
		/// </list>
		/// </remarks>
		CONNECTION_STATUS,
		/// <summary>﻿originator’s software version of the <i>adapter</i>.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.7">v1.7</see></item>
		/// </list>
		/// </remarks>
		ADAPTER_SOFTWARE_VERSION,
		/// <summary>﻿<i>URI</i> of the <i>adapter</i>.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.7">v1.7</see></item>
		/// </list>
		/// </remarks>
		ADAPTER_URI,
		/// <summary>﻿reference version of the MTConnect Standard supported by the <i>adapter</i>.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.7">v1.7</see></item>
		/// </list>
		/// </remarks>
		MTCONNECT_VERSION,
		/// <summary>﻿<i>attachment</i> between a sensor and an entity.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.7">v1.7</see></item>
		/// </list>
		/// </remarks>
		SENSOR_ATTACHMENT,
		/// <summary>﻿state or condition of a part.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.7">v1.7</see></item>
		/// </list>
		/// </remarks>
		PART_STATUS,
		/// <summary>﻿identifier of a process being executed by the device.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.7">v1.7</see></item>
		/// </list>
		/// </remarks>
		PROCESS_OCCURRENCE_ID,
		/// <summary>﻿identifier given to link the individual occurrence to a group of related occurrences, such as a process step in a process plan.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.7">v1.7</see></item>
		/// </list>
		/// </remarks>
		PROCESS_AGGREGATE_ID,
		/// <summary>﻿identifier given to link the individual occurrence to a class of processes or process definition.<br /><br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.7">v1.7</see></item>
		/// </list>
		/// </remarks>
		PROCESS_KIND_ID,
		/// <summary>﻿identifier given to a collection of individual parts. <br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.7">v1.7</see></item>
		/// </list>
		/// </remarks>
		PART_GROUP_ID,
		/// <summary>﻿identifier given to link the individual occurrence to a class of parts, typically distinguished by a particular part design.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.7">v1.7</see></item>
		/// </list>
		/// </remarks>
		PART_KIND_ID,
		/// <summary>﻿identifier given to a distinguishable, individual part. <br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.7">v1.7</see></item>
		/// </list>
		/// </remarks>
		PART_UNIQUE_ID,
		/// <summary>﻿set of limits used to indicate whether a process variable is stable and in control.<br /><br /><b>DEPRECATION WARNING</b>. Recommend using <c>CONTROL_LIMITS</c>.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.7">v1.7</see></item>
		/// </list>
		/// </remarks>
		CONTROL_LIMIT,
		/// <summary>﻿set of limits defining a range of values designating acceptable performance for a variable.<br /><br /><b>DEPRECATION WARNING</b>. Recommend using <c>SPECIFICATION_LIMITS</c>.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.7">v1.7</see></item>
		/// </list>
		/// </remarks>
		SPECIFICATION_LIMIT,
		/// <summary>﻿set of limits used to trigger warning or alarm indicators.<br /><br /><b>DEPRECATION WARNING</b>. Recommend using <c>ALARM_LIMITS</c>.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.7">v1.7</see></item>
		/// </list>
		/// </remarks>
		ALARM_LIMIT,
		/// <summary>﻿accumulation of the number of times an operation has attempted to, or is planned to attempt to, load materials, parts, or other items.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.8">v1.8</see></item>
		/// </list>
		/// </remarks>
		LOAD_COUNT,
		/// <summary>﻿accumulation of the number of times an operation has attempted to, or is planned to attempt to, unload materials, parts, or other items.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.8">v1.8</see></item>
		/// </list>
		/// </remarks>
		UNLOAD_COUNT,
		/// <summary>﻿accumulation of the number of times an operation has attempted to, or is planned to attempt to, transfer materials, parts, or other items from one location to another.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.8">v1.8</see></item>
		/// </list>
		/// </remarks>
		TRANSFER_COUNT,
		/// <summary>﻿accumulation of the number of times a function has attempted to, or is planned to attempt to, activate or be performed.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.8">v1.8</see></item>
		/// </list>
		/// </remarks>
		ACTIVATION_COUNT,
		/// <summary>﻿accumulation of the number of times a function has attempted to, or is planned to attempt to, deactivate or cease.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.8">v1.8</see></item>
		/// </list>
		/// </remarks>
		DEACTIVATION_COUNT,
		/// <summary>﻿accumulation of the number of times a cyclic function has attempted to, or is planned to attempt to execute.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.8">v1.8</see></item>
		/// </list>
		/// </remarks>
		CYCLE_COUNT,
		/// <summary>﻿state of a valve is one of open, closed, or transitioning between the states.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.8">v1.8</see></item>
		/// </list>
		/// </remarks>
		VALVE_STATE,
		/// <summary>﻿state or operating mode of a <see cref="Lock">Lock</see>.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.8">v1.8</see></item>
		/// </list>
		/// </remarks>
		LOCK_STATE,
		/// <summary>﻿particular condition of the process occurrence at a specific time.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.8">v1.8</see></item>
		/// </list>
		/// </remarks>
		PROCESS_STATE,
		/// <summary>﻿particular condition of the part occurrence at a specific time.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.8">v1.8</see></item>
		/// </list>
		/// </remarks>
		PART_PROCESSING_STATE,
		/// <summary>﻿state of <see cref="Component">Component</see> or <see cref="Composition">Composition</see> that describes the automatic or manual operation of the entity.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_2.0">v2.0</see></item>
		/// </list>
		/// </remarks>
		OPERATING_MODE,
		/// <summary>﻿<i>data set</i> of the number of <i>Asset</i>s of a given type for a <i>Device</i>.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_2.0">v2.0</see></item>
		/// </list>
		/// </remarks>
		ASSET_COUNT,
		/// <summary>﻿actions or activities to be performed in support of a piece of equipment.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_2.0">v2.0</see></item>
		/// </list>
		/// </remarks>
		MAINTENANCE_LIST,
		/// <summary>﻿identifier for the current workholding or part clamp in use by a piece of equipment.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_2.0">v2.0</see></item>
		/// </list>
		/// </remarks>
		FIXTURE_ID,
		/// <summary>﻿interpretation of <c>PART_COUNT</c>.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_2.0">v2.0</see></item>
		/// </list>
		/// </remarks>
		PART_COUNT_TYPE,
		/// <summary>﻿time provided by a timing device at a specific point in time.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.2">v1.2</see></item>
		/// </list>
		/// </remarks>
		CLOCK_TIME,
		/// <summary>﻿name of the host computer supplying data.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_2.1">v2.1</see></item>
		/// </list>
		/// </remarks>
		HOST_NAME,
		/// <summary>﻿number of the TCP/IP or UDP/IP port for the connection endpoint.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_2.1">v2.1</see></item>
		/// </list>
		/// </remarks>
		NETWORK_PORT,
		/// <summary>﻿indication designating whether a leak has been detected.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_2.1">v2.1</see></item>
		/// </list>
		/// </remarks>
		LEAK_DETECT,
		/// <summary>﻿present status of the battery.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_2.1">v2.1</see></item>
		/// </list>
		/// </remarks>
		BATTERY_STATE,
		/// <summary>﻿<i>UUID</i> of a <i>feature</i>. <seealso href="https://www.google.com/search?q=ISO 10303 AP 242/239&btnI=I">ISO 10303 AP 242/239</seealso>.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_2.2">v2.2</see></item>
		/// </list>
		/// </remarks>
		FEATURE_PERSISTENT_ID,
		/// <summary>﻿detection result of a sensor.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_2.2">v2.2</see></item>
		/// </list>
		/// </remarks>
		SENSOR_STATE,
		/// <summary>﻿<see cref="Event">Event</see> that represents a <see cref="Component">Component</see> where the <see cref="EntryDefinition">EntryDefinition</see> identifies the <see cref="Component">Component</see> and the <see cref="CellDefinition">CellDefinition</see>s define the <see cref="Component">Component</see>'s observed <see cref="DataItem">DataItem</see>s.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_2.2">v2.2</see></item>
		/// </list>
		/// </remarks>
		COMPONENT_DATA,
		/// <summary>﻿properties of each addressable work offset.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_2.2">v2.2</see></item>
		/// </list>
		/// </remarks>
		WORK_OFFSETS,
		/// <summary>﻿properties of each addressable tool offset.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_2.2">v2.2</see></item>
		/// </list>
		/// </remarks>
		TOOL_OFFSETS,
		/// <summary>﻿assessing elements of a <i>feature</i>.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_2.2">v2.2</see></item>
		/// </list>
		/// </remarks>
		FEATURE_MEASUREMENT,
		/// <summary>﻿<i>UUID</i> of the <i>characteristic</i>.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_2.2">v2.2</see></item>
		/// </list>
		/// </remarks>
		CHARACTERISTIC_PERSISTENT_ID,
		/// <summary>﻿class of measurement being performed. <seealso href="https://www.google.com/search?q=QIF 3:2018 Section 6.3&btnI=I">QIF 3:2018 Section 6.3</seealso><br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_2.2">v2.2</see></item>
		/// </list>
		/// </remarks>
		MEASUREMENT_TYPE,
		/// <summary>﻿measurement based on the measurement type.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_2.2">v2.2</see></item>
		/// </list>
		/// </remarks>
		MEASUREMENT_VALUE,
		/// <summary>﻿engineering units of the measurement.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_2.2">v2.2</see></item>
		/// </list>
		/// </remarks>
		MEASUREMENT_UNITS,
		/// <summary>﻿pass/fail result of the measurement.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_2.2">v2.2</see></item>
		/// </list>
		/// </remarks>
		CHARACTERISTIC_STATUS,
		/// <summary>﻿method used to compute <i>standard uncertainty</i>.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_2.2">v2.2</see></item>
		/// </list>
		/// </remarks>
		UNCERTAINTY_TYPE,
		/// <summary>﻿<i>uncertainty</i> specified by <see cref="UncertaintyType">UncertaintyType</see>.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_2.2">v2.2</see></item>
		/// </list>
		/// </remarks>
		UNCERTAINTY,
		/// <summary>﻿set of limits defining a range of values designating acceptable performance for a variable.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_2.3">v2.3</see></item>
		/// </list>
		/// </remarks>
		SPECIFICATION_LIMITS,
		/// <summary>﻿set of limits used to indicate whether a process variable is stable and in control.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_2.3">v2.3</see></item>
		/// </list>
		/// </remarks>
		CONTROL_LIMITS,
		/// <summary>﻿set of limits used to trigger warning or alarm indicators.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_2.3">v2.3</see></item>
		/// </list>
		/// </remarks>
		ALARM_LIMITS,
		/// <summary>﻿references the <see cref="CuttingToolLifeCycle">CuttingToolLifeCycle</see> <see cref="CuttingItem">CuttingItem</see> index related to the <see cref="CuttingItem.indices">indices in CuttingItem</see> of the currently active cutting tool edge.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_2.3">v2.3</see></item>
		/// </list>
		/// </remarks>
		TOOL_CUTTING_ITEM,
		/// <summary>﻿structured information that allows the unambiguous determination of an object for purposes of identification and location. <seealso href="https://www.google.com/search?q=ISO 19160-4:2017&btnI=I">ISO 19160-4:2017</seealso><br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_2.3">v2.3</see></item>
		/// </list>
		/// </remarks>
		LOCATION_ADDRESS,
		/// <summary>﻿active energy source for the <see cref="Component">Component</see>.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_2.3">v2.3</see></item>
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
		/// <inheritdoc />
		public string Name => "EventEnum";
		
		/// <inheritdoc />
		public Type DataType => null;
		
		/// <inheritdoc />
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
		/// <inheritdoc cref="ACTIVE_AXESValue" path="/summary" />
		public ACTIVE_AXESValue ACTIVE_AXES => _ACTIVE_AXES ?? (_ACTIVE_AXES = new ACTIVE_AXESValue());

		/// <summary>﻿set of axes currently associated with a <see cref="Path">Path</see> or <see cref="Controller">Controller</see>.<br /><br /><br />
		/// Value for EventEnum.<br/>
		/// <br/>See also <seealso cref="EventEnum">EventEnum</seealso>
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
			public string Summary => @"&#10;&#10;&#10;set of axes currently associated with a {{block(Path)}} or {{block(Controller)}}.&#10;
";
		}
		private ACTUATOR_STATEValue _ACTUATOR_STATE;
		/// <inheritdoc cref="ACTUATOR_STATEValue" path="/summary" />
		public ACTUATOR_STATEValue ACTUATOR_STATE => _ACTUATOR_STATE ?? (_ACTUATOR_STATE = new ACTUATOR_STATEValue());

		/// <summary>﻿operational state of an apparatus for moving or controlling a mechanism or system.<br /><br /><br />
		/// Value for EventEnum.<br/>
		/// <br/>See also <seealso cref="EventEnum">EventEnum</seealso>
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
			public string Summary => @"&#10;&#10;&#10;operational state of an apparatus for moving or controlling a mechanism or system.&#10;
";
		}
		private ALARMValue _ALARM;
		/// <inheritdoc cref="ALARMValue" path="/summary" />
		public ALARMValue ALARM => _ALARM ?? (_ALARM = new ALARMValue());

		/// <summary>﻿<b>DEPRECATED:</b> Replaced with <c>CONDITION</c> category data items in Version 1.1.0.<br /><br /><br />
		/// Value for EventEnum.<br/>
		/// <br/>See also <seealso cref="EventEnum">EventEnum</seealso>
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
			public string Summary => @"&#10;&#10;&#10;**DEPRECATED:** Replaced with `CONDITION` category data items in Version 1.1.0.&#10;
";
		}
		private ASSET_CHANGEDValue _ASSET_CHANGED;
		/// <inheritdoc cref="ASSET_CHANGEDValue" path="/summary" />
		public ASSET_CHANGEDValue ASSET_CHANGED => _ASSET_CHANGED ?? (_ASSET_CHANGED = new ASSET_CHANGEDValue());

		/// <summary>﻿<see cref="assetId">assetId</see> of the <i>Asset</i> that has been added or changed.<br /><br /><br />
		/// Value for EventEnum.<br/>
		/// <br/>See also <seealso cref="EventEnum">EventEnum</seealso>
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
			public string Summary => @"&#10;&#10;&#10;{{block(assetId)}} of the {{term(Asset)}} that has been added or changed.&#10;
";
		}
		private ASSET_REMOVEDValue _ASSET_REMOVED;
		/// <inheritdoc cref="ASSET_REMOVEDValue" path="/summary" />
		public ASSET_REMOVEDValue ASSET_REMOVED => _ASSET_REMOVED ?? (_ASSET_REMOVED = new ASSET_REMOVEDValue());

		/// <summary>﻿<see cref="assetId">assetId</see> of the <i>Asset</i> that has been removed.<br /><br /><br />
		/// Value for EventEnum.<br/>
		/// <br/>See also <seealso cref="EventEnum">EventEnum</seealso>
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
			public string Summary => @"&#10;&#10;&#10;{{block(assetId)}} of the {{term(Asset)}} that has been removed.&#10;
";
		}
		private AVAILABILITYValue _AVAILABILITY;
		/// <inheritdoc cref="AVAILABILITYValue" path="/summary" />
		public AVAILABILITYValue AVAILABILITY => _AVAILABILITY ?? (_AVAILABILITY = new AVAILABILITYValue());

		/// <summary>﻿<i>agent</i>'s ability to communicate with the data source.<br /><br /><br />
		/// Value for EventEnum.<br/>
		/// <br/>See also <seealso cref="EventEnum">EventEnum</seealso>
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
			public string Summary => @"&#10;&#10;&#10;{{term(agent)}}'s ability to communicate with the data source.&#10;
";
		}
		private AXIS_COUPLINGValue _AXIS_COUPLING;
		/// <inheritdoc cref="AXIS_COUPLINGValue" path="/summary" />
		public AXIS_COUPLINGValue AXIS_COUPLING => _AXIS_COUPLING ?? (_AXIS_COUPLING = new AXIS_COUPLINGValue());

		/// <summary>﻿describes the way the axes will be associated to each other. <br />  <br />This is used in conjunction with <c>COUPLED_AXES</c> to indicate the way they are interacting.<br /><br /><br />
		/// Value for EventEnum.<br/>
		/// <br/>See also <seealso cref="EventEnum">EventEnum</seealso>
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
			public string Summary => @"&#10;&#10;&#10;describes the way the axes will be associated to each other. 
  
This is used in conjunction with `COUPLED_AXES` to indicate the way they are interacting.&#10;
";
		}
		private AXIS_FEEDRATE_OVERRIDEValue _AXIS_FEEDRATE_OVERRIDE;
		/// <inheritdoc cref="AXIS_FEEDRATE_OVERRIDEValue" path="/summary" />
		public AXIS_FEEDRATE_OVERRIDEValue AXIS_FEEDRATE_OVERRIDE => _AXIS_FEEDRATE_OVERRIDE ?? (_AXIS_FEEDRATE_OVERRIDE = new AXIS_FEEDRATE_OVERRIDEValue());

		/// <summary>﻿value of a signal or calculation issued to adjust the feedrate of an individual linear type axis.<br /><br /><br />
		/// Value for EventEnum.<br/>
		/// <br/>See also <seealso cref="EventEnum">EventEnum</seealso>
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
			public string Summary => @"&#10;&#10;&#10;value of a signal or calculation issued to adjust the feedrate of an individual linear type axis.&#10;
";
		}
		private AXIS_INTERLOCKValue _AXIS_INTERLOCK;
		/// <inheritdoc cref="AXIS_INTERLOCKValue" path="/summary" />
		public AXIS_INTERLOCKValue AXIS_INTERLOCK => _AXIS_INTERLOCK ?? (_AXIS_INTERLOCK = new AXIS_INTERLOCKValue());

		/// <summary>﻿state of the axis lockout function when power has been removed and the axis is allowed to move freely.<br /><br /><br />
		/// Value for EventEnum.<br/>
		/// <br/>See also <seealso cref="EventEnum">EventEnum</seealso>
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
			public string Summary => @"&#10;&#10;&#10;state of the axis lockout function when power has been removed and the axis is allowed to move freely.&#10;
";
		}
		private AXIS_STATEValue _AXIS_STATE;
		/// <inheritdoc cref="AXIS_STATEValue" path="/summary" />
		public AXIS_STATEValue AXIS_STATE => _AXIS_STATE ?? (_AXIS_STATE = new AXIS_STATEValue());

		/// <summary>﻿state of a <see cref="Linear">Linear</see> or <see cref="Rotary">Rotary</see> component representing an axis.<br /><br /><br />
		/// Value for EventEnum.<br/>
		/// <br/>See also <seealso cref="EventEnum">EventEnum</seealso>
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
			public string Summary => @"&#10;&#10;&#10;state of a {{block(Linear)}} or {{block(Rotary)}} component representing an axis.&#10;
";
		}
		private BLOCKValue _BLOCK;
		/// <inheritdoc cref="BLOCKValue" path="/summary" />
		public BLOCKValue BLOCK => _BLOCK ?? (_BLOCK = new BLOCKValue());

		/// <summary>﻿line of code or command being executed by a <see cref="Controller">Controller</see> entity.<br /><br /><br />
		/// Value for EventEnum.<br/>
		/// <br/>See also <seealso cref="EventEnum">EventEnum</seealso>
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
			public string Summary => @"&#10;&#10;&#10;line of code or command being executed by a {{block(Controller)}} entity.&#10;
";
		}
		private BLOCK_COUNTValue _BLOCK_COUNT;
		/// <inheritdoc cref="BLOCK_COUNTValue" path="/summary" />
		public BLOCK_COUNTValue BLOCK_COUNT => _BLOCK_COUNT ?? (_BLOCK_COUNT = new BLOCK_COUNTValue());

		/// <summary>﻿total count of the number of blocks of program code that have been executed since execution started.<br /><br /><br />
		/// Value for EventEnum.<br/>
		/// <br/>See also <seealso cref="EventEnum">EventEnum</seealso>
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
			public string Summary => @"&#10;&#10;&#10;total count of the number of blocks of program code that have been executed since execution started.&#10;
";
		}
		private CHUCK_INTERLOCKValue _CHUCK_INTERLOCK;
		/// <inheritdoc cref="CHUCK_INTERLOCKValue" path="/summary" />
		public CHUCK_INTERLOCKValue CHUCK_INTERLOCK => _CHUCK_INTERLOCK ?? (_CHUCK_INTERLOCK = new CHUCK_INTERLOCKValue());

		/// <summary>﻿state of an interlock function or control logic state intended to prevent the associated <see cref="Chuck">Chuck</see> component from being operated.<br /><br /><br />
		/// Value for EventEnum.<br/>
		/// <br/>See also <seealso cref="EventEnum">EventEnum</seealso>
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
			public string Summary => @"&#10;&#10;&#10;state of an interlock function or control logic state intended to prevent the associated {{block(Chuck)}} component from being operated.&#10;
";
		}
		private CHUCK_STATEValue _CHUCK_STATE;
		/// <inheritdoc cref="CHUCK_STATEValue" path="/summary" />
		public CHUCK_STATEValue CHUCK_STATE => _CHUCK_STATE ?? (_CHUCK_STATE = new CHUCK_STATEValue());

		/// <summary>﻿operating state of a mechanism that holds a part or stock material during a manufacturing process. <br /><br />It may also represent a mechanism that holds any other mechanism in place within a piece of equipment.<br /><br /><br />
		/// Value for EventEnum.<br/>
		/// <br/>See also <seealso cref="EventEnum">EventEnum</seealso>
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
			public string Summary => @"&#10;&#10;&#10;operating state of a mechanism that holds a part or stock material during a manufacturing process. 

It may also represent a mechanism that holds any other mechanism in place within a piece of equipment.&#10;
";
		}
		private CODEValue _CODE;
		/// <inheritdoc cref="CODEValue" path="/summary" />
		public CODEValue CODE => _CODE ?? (_CODE = new CODEValue());

		/// <summary>﻿programmatic code being executed.<br /><br /><b>DEPRECATED</b> in <i>Version 1.1</i>.<br /><br /><br />
		/// Value for EventEnum.<br/>
		/// <br/>See also <seealso cref="EventEnum">EventEnum</seealso>
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
			public string Summary => @"&#10;&#10;&#10;programmatic code being executed.

**DEPRECATED** in *Version 1.1*.&#10;
";
		}
		private COMPOSITION_STATEValue _COMPOSITION_STATE;
		/// <inheritdoc cref="COMPOSITION_STATEValue" path="/summary" />
		public COMPOSITION_STATEValue COMPOSITION_STATE => _COMPOSITION_STATE ?? (_COMPOSITION_STATE = new COMPOSITION_STATEValue());

		/// <summary>﻿operating state of a mechanism represented by a <see cref="Composition">Composition</see> entity.<br /><br /><br />
		/// Value for EventEnum.<br/>
		/// <br/>See also <seealso cref="EventEnum">EventEnum</seealso>
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
			public string Summary => @"&#10;&#10;&#10;operating state of a mechanism represented by a {{block(Composition)}} entity.&#10;
";
		}
		private CONTROLLER_MODEValue _CONTROLLER_MODE;
		/// <inheritdoc cref="CONTROLLER_MODEValue" path="/summary" />
		public CONTROLLER_MODEValue CONTROLLER_MODE => _CONTROLLER_MODE ?? (_CONTROLLER_MODE = new CONTROLLER_MODEValue());

		/// <summary>﻿current mode of the <see cref="Controller">Controller</see> component.<br /><br /><br />
		/// Value for EventEnum.<br/>
		/// <br/>See also <seealso cref="EventEnum">EventEnum</seealso>
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
			public string Summary => @"&#10;&#10;&#10;current mode of the {{block(Controller)}} component.&#10;
";
		}
		private CONTROLLER_MODE_OVERRIDEValue _CONTROLLER_MODE_OVERRIDE;
		/// <inheritdoc cref="CONTROLLER_MODE_OVERRIDEValue" path="/summary" />
		public CONTROLLER_MODE_OVERRIDEValue CONTROLLER_MODE_OVERRIDE => _CONTROLLER_MODE_OVERRIDE ?? (_CONTROLLER_MODE_OVERRIDE = new CONTROLLER_MODE_OVERRIDEValue());

		/// <summary>﻿setting or operator selection that changes the behavior of a piece of equipment.<br /><br /><br />
		/// Value for EventEnum.<br/>
		/// <br/>See also <seealso cref="EventEnum">EventEnum</seealso>
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
			public string Summary => @"&#10;&#10;&#10;setting or operator selection that changes the behavior of a piece of equipment.&#10;
";
		}
		private COUPLED_AXESValue _COUPLED_AXES;
		/// <inheritdoc cref="COUPLED_AXESValue" path="/summary" />
		public COUPLED_AXESValue COUPLED_AXES => _COUPLED_AXES ?? (_COUPLED_AXES = new COUPLED_AXESValue());

		/// <summary>﻿set of associated axes.<br /><br /><br />
		/// Value for EventEnum.<br/>
		/// <br/>See also <seealso cref="EventEnum">EventEnum</seealso>
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
			public string Summary => @"&#10;&#10;&#10;set of associated axes.&#10;
";
		}
		private DATE_CODEValue _DATE_CODE;
		/// <inheritdoc cref="DATE_CODEValue" path="/summary" />
		public DATE_CODEValue DATE_CODE => _DATE_CODE ?? (_DATE_CODE = new DATE_CODEValue());

		/// <summary>﻿time and date code associated with a material or other physical item.<br /><br /><br />
		/// Value for EventEnum.<br/>
		/// <br/>See also <seealso cref="EventEnum">EventEnum</seealso>
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
			public string Summary => @"&#10;&#10;&#10;time and date code associated with a material or other physical item.&#10;
";
		}
		private DEVICE_UUIDValue _DEVICE_UUID;
		/// <inheritdoc cref="DEVICE_UUIDValue" path="/summary" />
		public DEVICE_UUIDValue DEVICE_UUID => _DEVICE_UUID ?? (_DEVICE_UUID = new DEVICE_UUIDValue());

		/// <summary>﻿identifier of another piece of equipment that is temporarily associated with a component of this piece of equipment to perform a particular function.<br /><br /><br />
		/// Value for EventEnum.<br/>
		/// <br/>See also <seealso cref="EventEnum">EventEnum</seealso>
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
			public string Summary => @"&#10;&#10;&#10;identifier of another piece of equipment that is temporarily associated with a component of this piece of equipment to perform a particular function.&#10;
";
		}
		private DIRECTIONValue _DIRECTION;
		/// <inheritdoc cref="DIRECTIONValue" path="/summary" />
		public DIRECTIONValue DIRECTION => _DIRECTION ?? (_DIRECTION = new DIRECTIONValue());

		/// <summary>﻿direction of motion.<br /><br /><br />
		/// Value for EventEnum.<br/>
		/// <br/>See also <seealso cref="EventEnum">EventEnum</seealso>
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
			public string Summary => @"&#10;&#10;&#10;direction of motion.&#10;
";
		}
		private DOOR_STATEValue _DOOR_STATE;
		/// <inheritdoc cref="DOOR_STATEValue" path="/summary" />
		public DOOR_STATEValue DOOR_STATE => _DOOR_STATE ?? (_DOOR_STATE = new DOOR_STATEValue());

		/// <summary>﻿operational state of a <see cref="Door">Door</see> component or composition element.<br /><br /><br />
		/// Value for EventEnum.<br/>
		/// <br/>See also <seealso cref="EventEnum">EventEnum</seealso>
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
			public string Summary => @"&#10;&#10;&#10;operational state of a {{block(Door)}} component or composition element.&#10;
";
		}
		private EMERGENCY_STOPValue _EMERGENCY_STOP;
		/// <inheritdoc cref="EMERGENCY_STOPValue" path="/summary" />
		public EMERGENCY_STOPValue EMERGENCY_STOP => _EMERGENCY_STOP ?? (_EMERGENCY_STOP = new EMERGENCY_STOPValue());

		/// <summary>﻿state of the emergency stop signal for a piece of equipment, controller path, or any other component or subsystem of a piece of equipment.<br /><br /><br />
		/// Value for EventEnum.<br/>
		/// <br/>See also <seealso cref="EventEnum">EventEnum</seealso>
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
			public string Summary => @"&#10;&#10;&#10;state of the emergency stop signal for a piece of equipment, controller path, or any other component or subsystem of a piece of equipment.&#10;
";
		}
		private END_OF_BARValue _END_OF_BAR;
		/// <inheritdoc cref="END_OF_BARValue" path="/summary" />
		public END_OF_BARValue END_OF_BAR => _END_OF_BAR ?? (_END_OF_BAR = new END_OF_BARValue());

		/// <summary>﻿indication of whether the end of a piece of bar stock being feed by a bar feeder has been reached.<br /><br /><br />
		/// Value for EventEnum.<br/>
		/// <br/>See also <seealso cref="EventEnum">EventEnum</seealso>
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
			public string Summary => @"&#10;&#10;&#10;indication of whether the end of a piece of bar stock being feed by a bar feeder has been reached.&#10;
";
		}
		private EQUIPMENT_MODEValue _EQUIPMENT_MODE;
		/// <inheritdoc cref="EQUIPMENT_MODEValue" path="/summary" />
		public EQUIPMENT_MODEValue EQUIPMENT_MODE => _EQUIPMENT_MODE ?? (_EQUIPMENT_MODE = new EQUIPMENT_MODEValue());

		/// <summary>﻿indication that a piece of equipment, or a sub-part of a piece of equipment, is performing specific types of activities.<br /><br /><br />
		/// Value for EventEnum.<br/>
		/// <br/>See also <seealso cref="EventEnum">EventEnum</seealso>
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
			public string Summary => @"&#10;&#10;&#10;indication that a piece of equipment, or a sub-part of a piece of equipment, is performing specific types of activities.&#10;
";
		}
		private EXECUTIONValue _EXECUTION;
		/// <inheritdoc cref="EXECUTIONValue" path="/summary" />
		public EXECUTIONValue EXECUTION => _EXECUTION ?? (_EXECUTION = new EXECUTIONValue());

		/// <summary>﻿operating state of a <see cref="Component">Component</see>.<br /><br /><br />
		/// Value for EventEnum.<br/>
		/// <br/>See also <seealso cref="EventEnum">EventEnum</seealso>
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
			public string Summary => @"&#10;&#10;&#10;operating state of a {{block(Component)}}.&#10;
";
		}
		private FUNCTIONAL_MODEValue _FUNCTIONAL_MODE;
		/// <inheritdoc cref="FUNCTIONAL_MODEValue" path="/summary" />
		public FUNCTIONAL_MODEValue FUNCTIONAL_MODE => _FUNCTIONAL_MODE ?? (_FUNCTIONAL_MODE = new FUNCTIONAL_MODEValue());

		/// <summary>﻿current intended production status of the <see cref="Component">Component</see>.<br /><br /><br />
		/// Value for EventEnum.<br/>
		/// <br/>See also <seealso cref="EventEnum">EventEnum</seealso>
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
			public string Summary => @"&#10;&#10;&#10;current intended production status of the {{block(Component)}}.&#10;
";
		}
		private HARDNESSValue _HARDNESS;
		/// <inheritdoc cref="HARDNESSValue" path="/summary" />
		public HARDNESSValue HARDNESS => _HARDNESS ?? (_HARDNESS = new HARDNESSValue());

		/// <summary>﻿hardness of a material.<br /><br /><br />
		/// Value for EventEnum.<br/>
		/// <br/>See also <seealso cref="EventEnum">EventEnum</seealso>
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
			public string Summary => @"&#10;&#10;&#10;hardness of a material.&#10;
";
		}
		private LINEValue _LINE;
		/// <inheritdoc cref="LINEValue" path="/summary" />
		public LINEValue LINE => _LINE ?? (_LINE = new LINEValue());

		/// <summary>﻿current line of code being executed.<br /><br /><b>DEPRECATED</b> in <i>Version 1.4.0</i>.<br /><br /><br />
		/// Value for EventEnum.<br/>
		/// <br/>See also <seealso cref="EventEnum">EventEnum</seealso>
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
			public string Summary => @"&#10;&#10;&#10;current line of code being executed.

**DEPRECATED** in *Version 1.4.0*.&#10;
";
		}
		private LINE_LABELValue _LINE_LABEL;
		/// <inheritdoc cref="LINE_LABELValue" path="/summary" />
		public LINE_LABELValue LINE_LABEL => _LINE_LABEL ?? (_LINE_LABEL = new LINE_LABELValue());

		/// <summary>﻿identifier for a <see cref="Block">Block</see> of code in a <see cref="Program">Program</see>.<br /><br /><br />
		/// Value for EventEnum.<br/>
		/// <br/>See also <seealso cref="EventEnum">EventEnum</seealso>
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
			public string Summary => @"&#10;&#10;&#10;identifier for a {{block(Block)}} of code in a {{block(Program)}}.&#10;
";
		}
		private LINE_NUMBERValue _LINE_NUMBER;
		/// <inheritdoc cref="LINE_NUMBERValue" path="/summary" />
		public LINE_NUMBERValue LINE_NUMBER => _LINE_NUMBER ?? (_LINE_NUMBER = new LINE_NUMBERValue());

		/// <summary>﻿position of a block of program code within a control program.<br /><br /><br />
		/// Value for EventEnum.<br/>
		/// <br/>See also <seealso cref="EventEnum">EventEnum</seealso>
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
			public string Summary => @"&#10;&#10;&#10;position of a block of program code within a control program.&#10;
";
		}
		private MATERIALValue _MATERIAL;
		/// <inheritdoc cref="MATERIALValue" path="/summary" />
		public MATERIALValue MATERIAL => _MATERIAL ?? (_MATERIAL = new MATERIALValue());

		/// <summary>﻿identifier of a material used or consumed in the manufacturing process.<br /><br /><br />
		/// Value for EventEnum.<br/>
		/// <br/>See also <seealso cref="EventEnum">EventEnum</seealso>
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
			public string Summary => @"&#10;&#10;&#10;identifier of a material used or consumed in the manufacturing process.&#10;
";
		}
		private MATERIAL_LAYERValue _MATERIAL_LAYER;
		/// <inheritdoc cref="MATERIAL_LAYERValue" path="/summary" />
		public MATERIAL_LAYERValue MATERIAL_LAYER => _MATERIAL_LAYER ?? (_MATERIAL_LAYER = new MATERIAL_LAYERValue());

		/// <summary>﻿identifies the layers of material applied to a part or product as part of an additive manufacturing process.<br /><br /><br />
		/// Value for EventEnum.<br/>
		/// <br/>See also <seealso cref="EventEnum">EventEnum</seealso>
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
			public string Summary => @"&#10;&#10;&#10;identifies the layers of material applied to a part or product as part of an additive manufacturing process.&#10;
";
		}
		private MESSAGEValue _MESSAGE;
		/// <inheritdoc cref="MESSAGEValue" path="/summary" />
		public MESSAGEValue MESSAGE => _MESSAGE ?? (_MESSAGE = new MESSAGEValue());

		/// <summary>﻿information to be transferred from a piece of equipment to a client software application.<br /><br /><br />
		/// Value for EventEnum.<br/>
		/// <br/>See also <seealso cref="EventEnum">EventEnum</seealso>
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
			public string Summary => @"&#10;&#10;&#10;information to be transferred from a piece of equipment to a client software application.&#10;
";
		}
		private OPERATOR_IDValue _OPERATOR_ID;
		/// <inheritdoc cref="OPERATOR_IDValue" path="/summary" />
		public OPERATOR_IDValue OPERATOR_ID => _OPERATOR_ID ?? (_OPERATOR_ID = new OPERATOR_IDValue());

		/// <summary>﻿identifier of the person currently responsible for operating the piece of equipment.<br /><br /><br />
		/// Value for EventEnum.<br/>
		/// <br/>See also <seealso cref="EventEnum">EventEnum</seealso>
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
			public string Summary => @"&#10;&#10;&#10;identifier of the person currently responsible for operating the piece of equipment.&#10;
";
		}
		private PALLET_IDValue _PALLET_ID;
		/// <inheritdoc cref="PALLET_IDValue" path="/summary" />
		public PALLET_IDValue PALLET_ID => _PALLET_ID ?? (_PALLET_ID = new PALLET_IDValue());

		/// <summary>﻿identifier for a pallet.<br /><br /><br />
		/// Value for EventEnum.<br/>
		/// <br/>See also <seealso cref="EventEnum">EventEnum</seealso>
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
			public string Summary => @"&#10;&#10;&#10;identifier for a pallet.&#10;
";
		}
		private PART_COUNTValue _PART_COUNT;
		/// <inheritdoc cref="PART_COUNTValue" path="/summary" />
		public PART_COUNTValue PART_COUNT => _PART_COUNT ?? (_PART_COUNT = new PART_COUNTValue());

		/// <summary>﻿aggregate count of parts.<br /><br /><br />
		/// Value for EventEnum.<br/>
		/// <br/>See also <seealso cref="EventEnum">EventEnum</seealso>
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
			public string Summary => @"&#10;&#10;&#10;aggregate count of parts.&#10;
";
		}
		private PART_DETECTValue _PART_DETECT;
		/// <inheritdoc cref="PART_DETECTValue" path="/summary" />
		public PART_DETECTValue PART_DETECT => _PART_DETECT ?? (_PART_DETECT = new PART_DETECTValue());

		/// <summary>﻿indication designating whether a part or work piece has been detected or is present.<br /><br /><br />
		/// Value for EventEnum.<br/>
		/// <br/>See also <seealso cref="EventEnum">EventEnum</seealso>
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
			public string Summary => @"&#10;&#10;&#10;indication designating whether a part or work piece has been detected or is present.&#10;
";
		}
		private PART_IDValue _PART_ID;
		/// <inheritdoc cref="PART_IDValue" path="/summary" />
		public PART_IDValue PART_ID => _PART_ID ?? (_PART_ID = new PART_IDValue());

		/// <summary>﻿identifier of a part in a manufacturing operation.<br /><br /><br />
		/// Value for EventEnum.<br/>
		/// <br/>See also <seealso cref="EventEnum">EventEnum</seealso>
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
			public string Summary => @"&#10;&#10;&#10;identifier of a part in a manufacturing operation.&#10;
";
		}
		private PART_NUMBERValue _PART_NUMBER;
		/// <inheritdoc cref="PART_NUMBERValue" path="/summary" />
		public PART_NUMBERValue PART_NUMBER => _PART_NUMBER ?? (_PART_NUMBER = new PART_NUMBERValue());

		/// <summary>﻿identifier of a part or product moving through the manufacturing process.<br /><br /><b>DEPRECATED</b> in <i>Version 1.7</i>. <c>PART_NUMBER</c> is now a <c>subType</c> of <c>PART_KIND_ID</c>.<br /><br /><br />
		/// Value for EventEnum.<br/>
		/// <br/>See also <seealso cref="EventEnum">EventEnum</seealso>
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
			public string Summary => @"&#10;&#10;&#10;identifier of a part or product moving through the manufacturing process.

**DEPRECATED** in *Version 1.7*. `PART_NUMBER` is now a `subType` of `PART_KIND_ID`.&#10;
";
		}
		private PATH_FEEDRATE_OVERRIDEValue _PATH_FEEDRATE_OVERRIDE;
		/// <inheritdoc cref="PATH_FEEDRATE_OVERRIDEValue" path="/summary" />
		public PATH_FEEDRATE_OVERRIDEValue PATH_FEEDRATE_OVERRIDE => _PATH_FEEDRATE_OVERRIDE ?? (_PATH_FEEDRATE_OVERRIDE = new PATH_FEEDRATE_OVERRIDEValue());

		/// <summary>﻿value of a signal or calculation issued to adjust the feedrate for the axes associated with a <see cref="Path">Path</see> component that may represent a single axis or the coordinated movement of multiple axes.<br /><br /><br />
		/// Value for EventEnum.<br/>
		/// <br/>See also <seealso cref="EventEnum">EventEnum</seealso>
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
			public string Summary => @"&#10;&#10;&#10;value of a signal or calculation issued to adjust the feedrate for the axes associated with a {{block(Path)}} component that may represent a single axis or the coordinated movement of multiple axes.&#10;
";
		}
		private PATH_MODEValue _PATH_MODE;
		/// <inheritdoc cref="PATH_MODEValue" path="/summary" />
		public PATH_MODEValue PATH_MODE => _PATH_MODE ?? (_PATH_MODE = new PATH_MODEValue());

		/// <summary>﻿describes the operational relationship between a <see cref="Path">Path</see> entity and another <see cref="Path">Path</see> entity for pieces of equipment comprised of multiple logical groupings of controlled axes or other logical operations.<br /><br /><br />
		/// Value for EventEnum.<br/>
		/// <br/>See also <seealso cref="EventEnum">EventEnum</seealso>
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
			public string Summary => @"&#10;&#10;&#10;describes the operational relationship between a {{block(Path)}} entity and another {{block(Path)}} entity for pieces of equipment comprised of multiple logical groupings of controlled axes or other logical operations.&#10;
";
		}
		private POWER_STATEValue _POWER_STATE;
		/// <inheritdoc cref="POWER_STATEValue" path="/summary" />
		public POWER_STATEValue POWER_STATE => _POWER_STATE ?? (_POWER_STATE = new POWER_STATEValue());

		/// <summary>﻿indication of the status of the source of energy for an entity to allow it to perform its intended function or the state of an enabling signal providing permission for the entity to perform its functions.<br /><br /><br />
		/// Value for EventEnum.<br/>
		/// <br/>See also <seealso cref="EventEnum">EventEnum</seealso>
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
			public string Summary => @"&#10;&#10;&#10;indication of the status of the source of energy for an entity to allow it to perform its intended function or the state of an enabling signal providing permission for the entity to perform its functions.&#10;
";
		}
		private POWER_STATUSValue _POWER_STATUS;
		/// <inheritdoc cref="POWER_STATUSValue" path="/summary" />
		public POWER_STATUSValue POWER_STATUS => _POWER_STATUS ?? (_POWER_STATUS = new POWER_STATUSValue());

		/// <summary>﻿status of the <see cref="Component">Component</see>.<br /><br /><b>DEPRECATED</b> in <i>Version 1.1.0</i>.<br /><br /><br />
		/// Value for EventEnum.<br/>
		/// <br/>See also <seealso cref="EventEnum">EventEnum</seealso>
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
			public string Summary => @"&#10;&#10;&#10;status of the {{block(Component)}}.

**DEPRECATED** in *Version 1.1.0*.&#10;
";
		}
		private PROCESS_TIMEValue _PROCESS_TIME;
		/// <inheritdoc cref="PROCESS_TIMEValue" path="/summary" />
		public PROCESS_TIMEValue PROCESS_TIME => _PROCESS_TIME ?? (_PROCESS_TIME = new PROCESS_TIMEValue());

		/// <summary>﻿time and date associated with an activity or event.<br /><br /><br />
		/// Value for EventEnum.<br/>
		/// <br/>See also <seealso cref="EventEnum">EventEnum</seealso>
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
			public string Summary => @"&#10;&#10;&#10;time and date associated with an activity or event.&#10;
";
		}
		private PROGRAMValue _PROGRAM;
		/// <inheritdoc cref="PROGRAMValue" path="/summary" />
		public PROGRAMValue PROGRAM => _PROGRAM ?? (_PROGRAM = new PROGRAMValue());

		/// <summary>﻿name of the logic or motion program being executed by the <see cref="Controller">Controller</see> component.<br /><br /><br />
		/// Value for EventEnum.<br/>
		/// <br/>See also <seealso cref="EventEnum">EventEnum</seealso>
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
			public string Summary => @"&#10;&#10;&#10;name of the logic or motion program being executed by the {{block(Controller)}} component.&#10;
";
		}
		private PROGRAM_COMMENTValue _PROGRAM_COMMENT;
		/// <inheritdoc cref="PROGRAM_COMMENTValue" path="/summary" />
		public PROGRAM_COMMENTValue PROGRAM_COMMENT => _PROGRAM_COMMENT ?? (_PROGRAM_COMMENT = new PROGRAM_COMMENTValue());

		/// <summary>﻿comment or non-executable statement in the control program.<br /><br /><br />
		/// Value for EventEnum.<br/>
		/// <br/>See also <seealso cref="EventEnum">EventEnum</seealso>
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
			public string Summary => @"&#10;&#10;&#10;comment or non-executable statement in the control program.&#10;
";
		}
		private PROGRAM_EDITValue _PROGRAM_EDIT;
		/// <inheritdoc cref="PROGRAM_EDITValue" path="/summary" />
		public PROGRAM_EDITValue PROGRAM_EDIT => _PROGRAM_EDIT ?? (_PROGRAM_EDIT = new PROGRAM_EDITValue());

		/// <summary>﻿indication of the status of the <see cref="Controller">Controller</see> components program editing mode.<br /><br />A program may be edited while another is executed.<br /><br /><br />
		/// Value for EventEnum.<br/>
		/// <br/>See also <seealso cref="EventEnum">EventEnum</seealso>
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
			public string Summary => @"&#10;&#10;&#10;indication of the status of the {{block(Controller)}} components program editing mode.

A program may be edited while another is executed.&#10;
";
		}
		private PROGRAM_EDIT_NAMEValue _PROGRAM_EDIT_NAME;
		/// <inheritdoc cref="PROGRAM_EDIT_NAMEValue" path="/summary" />
		public PROGRAM_EDIT_NAMEValue PROGRAM_EDIT_NAME => _PROGRAM_EDIT_NAME ?? (_PROGRAM_EDIT_NAME = new PROGRAM_EDIT_NAMEValue());

		/// <summary>﻿name of the program being edited. <br /><br />This is used in conjunction with <see cref="ProgramEdit">ProgramEdit</see> when in <c>ACTIVE</c> state. <br /><br /><br />
		/// Value for EventEnum.<br/>
		/// <br/>See also <seealso cref="EventEnum">EventEnum</seealso>
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
			public string Summary => @"&#10;&#10;&#10;name of the program being edited. 

This is used in conjunction with {{block(ProgramEdit)}} when in `ACTIVE` state. &#10;
";
		}
		private PROGRAM_HEADERValue _PROGRAM_HEADER;
		/// <inheritdoc cref="PROGRAM_HEADERValue" path="/summary" />
		public PROGRAM_HEADERValue PROGRAM_HEADER => _PROGRAM_HEADER ?? (_PROGRAM_HEADER = new PROGRAM_HEADERValue());

		/// <summary>﻿non-executable header section of the control program.<br /><br /><br />
		/// Value for EventEnum.<br/>
		/// <br/>See also <seealso cref="EventEnum">EventEnum</seealso>
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
			public string Summary => @"&#10;&#10;&#10;non-executable header section of the control program.&#10;
";
		}
		private PROGRAM_LOCATIONValue _PROGRAM_LOCATION;
		/// <inheritdoc cref="PROGRAM_LOCATIONValue" path="/summary" />
		public PROGRAM_LOCATIONValue PROGRAM_LOCATION => _PROGRAM_LOCATION ?? (_PROGRAM_LOCATION = new PROGRAM_LOCATIONValue());

		/// <summary>﻿<i>URI</i> for the source file associated with <see cref="Program">Program</see>.<br /><br /><br />
		/// Value for EventEnum.<br/>
		/// <br/>See also <seealso cref="EventEnum">EventEnum</seealso>
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
			public string Summary => @"&#10;&#10;&#10;{{term(URI)}} for the source file associated with {{block(Program)}}.&#10;
";
		}
		private PROGRAM_LOCATION_TYPEValue _PROGRAM_LOCATION_TYPE;
		/// <inheritdoc cref="PROGRAM_LOCATION_TYPEValue" path="/summary" />
		public PROGRAM_LOCATION_TYPEValue PROGRAM_LOCATION_TYPE => _PROGRAM_LOCATION_TYPE ?? (_PROGRAM_LOCATION_TYPE = new PROGRAM_LOCATION_TYPEValue());

		/// <summary>﻿defines whether the logic or motion program defined by <see cref="Program">Program</see> is being executed from the local memory of the controller or from an outside source.<br /><br /><br />
		/// Value for EventEnum.<br/>
		/// <br/>See also <seealso cref="EventEnum">EventEnum</seealso>
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
			public string Summary => @"&#10;&#10;&#10;defines whether the logic or motion program defined by {{block(Program)}} is being executed from the local memory of the controller or from an outside source.&#10;
";
		}
		private PROGRAM_NEST_LEVELValue _PROGRAM_NEST_LEVEL;
		/// <inheritdoc cref="PROGRAM_NEST_LEVELValue" path="/summary" />
		public PROGRAM_NEST_LEVELValue PROGRAM_NEST_LEVEL => _PROGRAM_NEST_LEVEL ?? (_PROGRAM_NEST_LEVEL = new PROGRAM_NEST_LEVELValue());

		/// <summary>﻿indication of the nesting level within a control program that is associated with the code or instructions that is currently being executed.<br /><br /><br />
		/// Value for EventEnum.<br/>
		/// <br/>See also <seealso cref="EventEnum">EventEnum</seealso>
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
			public string Summary => @"&#10;&#10;&#10;indication of the nesting level within a control program that is associated with the code or instructions that is currently being executed.&#10;
";
		}
		private ROTARY_MODEValue _ROTARY_MODE;
		/// <inheritdoc cref="ROTARY_MODEValue" path="/summary" />
		public ROTARY_MODEValue ROTARY_MODE => _ROTARY_MODE ?? (_ROTARY_MODE = new ROTARY_MODEValue());

		/// <summary>﻿current operating mode for a <see cref="Rotary">Rotary</see> type axis.<br /><br /><br />
		/// Value for EventEnum.<br/>
		/// <br/>See also <seealso cref="EventEnum">EventEnum</seealso>
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
			public string Summary => @"&#10;&#10;&#10;current operating mode for a {{block(Rotary)}} type axis.&#10;
";
		}
		private ROTARY_VELOCITY_OVERRIDEValue _ROTARY_VELOCITY_OVERRIDE;
		/// <inheritdoc cref="ROTARY_VELOCITY_OVERRIDEValue" path="/summary" />
		public ROTARY_VELOCITY_OVERRIDEValue ROTARY_VELOCITY_OVERRIDE => _ROTARY_VELOCITY_OVERRIDE ?? (_ROTARY_VELOCITY_OVERRIDE = new ROTARY_VELOCITY_OVERRIDEValue());

		/// <summary>﻿percentage change to the velocity of the programmed velocity for a <see cref="Rotary">Rotary</see> axis.<br /><br /><br />
		/// Value for EventEnum.<br/>
		/// <br/>See also <seealso cref="EventEnum">EventEnum</seealso>
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
			public string Summary => @"&#10;&#10;&#10;percentage change to the velocity of the programmed velocity for a {{block(Rotary)}} axis.&#10;
";
		}
		private SERIAL_NUMBERValue _SERIAL_NUMBER;
		/// <inheritdoc cref="SERIAL_NUMBERValue" path="/summary" />
		public SERIAL_NUMBERValue SERIAL_NUMBER => _SERIAL_NUMBER ?? (_SERIAL_NUMBER = new SERIAL_NUMBERValue());

		/// <summary>﻿serial number associated with a <see cref="Component">Component</see>, <see cref="Asset">Asset</see>, or <see cref="Device">Device</see>.<br /><br /><br />
		/// Value for EventEnum.<br/>
		/// <br/>See also <seealso cref="EventEnum">EventEnum</seealso>
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
			public string Summary => @"&#10;&#10;&#10;serial number associated with a {{block(Component)}}, {{block(Asset)}}, or {{block(Device)}}.&#10;
";
		}
		private SPINDLE_INTERLOCKValue _SPINDLE_INTERLOCK;
		/// <inheritdoc cref="SPINDLE_INTERLOCKValue" path="/summary" />
		public SPINDLE_INTERLOCKValue SPINDLE_INTERLOCK => _SPINDLE_INTERLOCK ?? (_SPINDLE_INTERLOCK = new SPINDLE_INTERLOCKValue());

		/// <summary>﻿indication of the status of the spindle for a piece of equipment when power has been removed and it is free to rotate.<br /><br /><br />
		/// Value for EventEnum.<br/>
		/// <br/>See also <seealso cref="EventEnum">EventEnum</seealso>
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
			public string Summary => @"&#10;&#10;&#10;indication of the status of the spindle for a piece of equipment when power has been removed and it is free to rotate.&#10;
";
		}
		private TOOL_ASSET_IDValue _TOOL_ASSET_ID;
		/// <inheritdoc cref="TOOL_ASSET_IDValue" path="/summary" />
		public TOOL_ASSET_IDValue TOOL_ASSET_ID => _TOOL_ASSET_ID ?? (_TOOL_ASSET_ID = new TOOL_ASSET_IDValue());

		/// <summary>﻿identifier of an individual tool asset.<br /><br /><br />
		/// Value for EventEnum.<br/>
		/// <br/>See also <seealso cref="EventEnum">EventEnum</seealso>
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
			public string Summary => @"&#10;&#10;&#10;identifier of an individual tool asset.&#10;
";
		}
		private TOOL_GROUPValue _TOOL_GROUP;
		/// <inheritdoc cref="TOOL_GROUPValue" path="/summary" />
		public TOOL_GROUPValue TOOL_GROUP => _TOOL_GROUP ?? (_TOOL_GROUP = new TOOL_GROUPValue());

		/// <summary>﻿identifier for the tool group associated with a specific tool. Commonly used to designate spare tools.<br /><br /><br />
		/// Value for EventEnum.<br/>
		/// <br/>See also <seealso cref="EventEnum">EventEnum</seealso>
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
			public string Summary => @"&#10;&#10;&#10;identifier for the tool group associated with a specific tool. Commonly used to designate spare tools.&#10;
";
		}
		private TOOL_IDValue _TOOL_ID;
		/// <inheritdoc cref="TOOL_IDValue" path="/summary" />
		public TOOL_IDValue TOOL_ID => _TOOL_ID ?? (_TOOL_ID = new TOOL_IDValue());

		/// <summary>﻿identifier of the tool currently in use for a given <c>Path</c>.<br /><br /><b>DEPRECATED</b> in <i>Version 1.2.0</i>.   See <c>TOOL_ASSET_ID</c>.<br /><br /><br />
		/// Value for EventEnum.<br/>
		/// <br/>See also <seealso cref="EventEnum">EventEnum</seealso>
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
			public string Summary => @"&#10;&#10;&#10;identifier of the tool currently in use for a given `Path`.

**DEPRECATED** in *Version 1.2.0*.   See `TOOL_ASSET_ID`.&#10;
";
		}
		private TOOL_NUMBERValue _TOOL_NUMBER;
		/// <inheritdoc cref="TOOL_NUMBERValue" path="/summary" />
		public TOOL_NUMBERValue TOOL_NUMBER => _TOOL_NUMBER ?? (_TOOL_NUMBER = new TOOL_NUMBERValue());

		/// <summary>﻿identifier assigned by the <see cref="Controller">Controller</see> component to a cutting tool when in use by a piece of equipment.<br /><br /><br />
		/// Value for EventEnum.<br/>
		/// <br/>See also <seealso cref="EventEnum">EventEnum</seealso>
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
			public string Summary => @"&#10;&#10;&#10;identifier assigned by the {{block(Controller)}} component to a cutting tool when in use by a piece of equipment.&#10;
";
		}
		private TOOL_OFFSETValue _TOOL_OFFSET;
		/// <inheritdoc cref="TOOL_OFFSETValue" path="/summary" />
		public TOOL_OFFSETValue TOOL_OFFSET => _TOOL_OFFSET ?? (_TOOL_OFFSET = new TOOL_OFFSETValue());

		/// <summary>﻿reference to the tool offset variables applied to the active cutting tool.<br /><br /><br />
		/// Value for EventEnum.<br/>
		/// <br/>See also <seealso cref="EventEnum">EventEnum</seealso>
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
			public string Summary => @"&#10;&#10;&#10;reference to the tool offset variables applied to the active cutting tool.&#10;
";
		}
		private USERValue _USER;
		/// <inheritdoc cref="USERValue" path="/summary" />
		public USERValue USER => _USER ?? (_USER = new USERValue());

		/// <summary>﻿identifier of the person currently responsible for operating the piece of equipment.<br /><br /><br />
		/// Value for EventEnum.<br/>
		/// <br/>See also <seealso cref="EventEnum">EventEnum</seealso>
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
			public string Summary => @"&#10;&#10;&#10;identifier of the person currently responsible for operating the piece of equipment.&#10;
";
		}
		private VARIABLEValue _VARIABLE;
		/// <inheritdoc cref="VARIABLEValue" path="/summary" />
		public VARIABLEValue VARIABLE => _VARIABLE ?? (_VARIABLE = new VARIABLEValue());

		/// <summary>﻿data whose meaning may change over time due to changes in the operation of a piece of equipment or the process being executed on that piece of equipment.<br /><br /><br />
		/// Value for EventEnum.<br/>
		/// <br/>See also <seealso cref="EventEnum">EventEnum</seealso>
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
			public string Summary => @"&#10;&#10;&#10;data whose meaning may change over time due to changes in the operation of a piece of equipment or the process being executed on that piece of equipment.&#10;
";
		}
		private WAIT_STATEValue _WAIT_STATE;
		/// <inheritdoc cref="WAIT_STATEValue" path="/summary" />
		public WAIT_STATEValue WAIT_STATE => _WAIT_STATE ?? (_WAIT_STATE = new WAIT_STATEValue());

		/// <summary>﻿indication of the reason that <see cref="Execution">Execution</see> is reporting a value of <c>WAIT</c>.<br /><br /><br />
		/// Value for EventEnum.<br/>
		/// <br/>See also <seealso cref="EventEnum">EventEnum</seealso>
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
			public string Summary => @"&#10;&#10;&#10;indication of the reason that {{block(Execution)}} is reporting a value of `WAIT`.&#10;
";
		}
		private WIREValue _WIRE;
		/// <inheritdoc cref="WIREValue" path="/summary" />
		public WIREValue WIRE => _WIRE ?? (_WIRE = new WIREValue());

		/// <summary>﻿identifier for the type of wire used as the cutting mechanism in Electrical Discharge Machining or similar processes.<br /><br /><br />
		/// Value for EventEnum.<br/>
		/// <br/>See also <seealso cref="EventEnum">EventEnum</seealso>
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
			public string Summary => @"&#10;&#10;&#10;identifier for the type of wire used as the cutting mechanism in Electrical Discharge Machining or similar processes.&#10;
";
		}
		private WORKHOLDING_IDValue _WORKHOLDING_ID;
		/// <inheritdoc cref="WORKHOLDING_IDValue" path="/summary" />
		public WORKHOLDING_IDValue WORKHOLDING_ID => _WORKHOLDING_ID ?? (_WORKHOLDING_ID = new WORKHOLDING_IDValue());

		/// <summary>﻿identifier for the current workholding or part clamp in use by a piece of equipment.<br /><br /><b>DEPRECATION WARNING</b>: Recommend using <c>FIXTURE_ID</c> instead.<br /><br /><br />
		/// Value for EventEnum.<br/>
		/// <br/>See also <seealso cref="EventEnum">EventEnum</seealso>
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
			public string Summary => @"&#10;&#10;&#10;identifier for the current workholding or part clamp in use by a piece of equipment.

**DEPRECATION WARNING**: Recommend using `FIXTURE_ID` instead.&#10;
";
		}
		private WORK_OFFSETValue _WORK_OFFSET;
		/// <inheritdoc cref="WORK_OFFSETValue" path="/summary" />
		public WORK_OFFSETValue WORK_OFFSET => _WORK_OFFSET ?? (_WORK_OFFSET = new WORK_OFFSETValue());

		/// <summary>﻿reference to offset variables for a work piece or part.<br /><br /><br />
		/// Value for EventEnum.<br/>
		/// <br/>See also <seealso cref="EventEnum">EventEnum</seealso>
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
			public string Summary => @"&#10;&#10;&#10;reference to offset variables for a work piece or part.&#10;
";
		}
		private OPERATING_SYSTEMValue _OPERATING_SYSTEM;
		/// <inheritdoc cref="OPERATING_SYSTEMValue" path="/summary" />
		public OPERATING_SYSTEMValue OPERATING_SYSTEM => _OPERATING_SYSTEM ?? (_OPERATING_SYSTEM = new OPERATING_SYSTEMValue());

		/// <summary>﻿Operating System (OS) of a <see cref="Component">Component</see>.<br /><br /><br />
		/// Value for EventEnum.<br/>
		/// <br/>See also <seealso cref="EventEnum">EventEnum</seealso>
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
			public string Summary => @"&#10;&#10;&#10;Operating System (OS) of a {{block(Component)}}.&#10;
";
		}
		private FIRMWAREValue _FIRMWARE;
		/// <inheritdoc cref="FIRMWAREValue" path="/summary" />
		public FIRMWAREValue FIRMWARE => _FIRMWARE ?? (_FIRMWARE = new FIRMWAREValue());

		/// <summary>﻿embedded software of a <see cref="Component">Component</see><br />.<br /><br /><br />
		/// Value for EventEnum.<br/>
		/// <br/>See also <seealso cref="EventEnum">EventEnum</seealso>
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
			public string Summary => @"&#10;&#10;&#10;embedded software of a {{block(Component)}}.&#10;
";
		}
		private APPLICATIONValue _APPLICATION;
		/// <inheritdoc cref="APPLICATIONValue" path="/summary" />
		public APPLICATIONValue APPLICATION => _APPLICATION ?? (_APPLICATION = new APPLICATIONValue());

		/// <summary>﻿application on a <see cref="Component">Component</see>.<br /><br /><br />
		/// Value for EventEnum.<br/>
		/// <br/>See also <seealso cref="EventEnum">EventEnum</seealso>
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
			public string Summary => @"&#10;&#10;&#10;application on a {{block(Component)}}.&#10;
";
		}
		private LIBRARYValue _LIBRARY;
		/// <inheritdoc cref="LIBRARYValue" path="/summary" />
		public LIBRARYValue LIBRARY => _LIBRARY ?? (_LIBRARY = new LIBRARYValue());

		/// <summary>﻿software library on a <see cref="Component">Component</see><br /><br /><br />
		/// Value for EventEnum.<br/>
		/// <br/>See also <seealso cref="EventEnum">EventEnum</seealso>
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
			public string Summary => @"&#10;&#10;&#10;software library on a {{block(Component)}}&#10;
";
		}
		private HARDWAREValue _HARDWARE;
		/// <inheritdoc cref="HARDWAREValue" path="/summary" />
		public HARDWAREValue HARDWARE => _HARDWARE ?? (_HARDWARE = new HARDWAREValue());

		/// <summary>﻿hardware of a <see cref="Component">Component</see>.<br /><br /><br />
		/// Value for EventEnum.<br/>
		/// <br/>See also <seealso cref="EventEnum">EventEnum</seealso>
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
			public string Summary => @"&#10;&#10;&#10;hardware of a {{block(Component)}}.&#10;
";
		}
		private NETWORKValue _NETWORK;
		/// <inheritdoc cref="NETWORKValue" path="/summary" />
		public NETWORKValue NETWORK => _NETWORK ?? (_NETWORK = new NETWORKValue());

		/// <summary>﻿network details of a <see cref="Component">Component</see>.<br /><br /><br />
		/// Value for EventEnum.<br/>
		/// <br/>See also <seealso cref="EventEnum">EventEnum</seealso>
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
			public string Summary => @"&#10;&#10;&#10;network details of a {{block(Component)}}.&#10;
";
		}
		private ROTATIONValue _ROTATION;
		/// <inheritdoc cref="ROTATIONValue" path="/summary" />
		public ROTATIONValue ROTATION => _ROTATION ?? (_ROTATION = new ROTATIONValue());

		/// <summary>﻿three space angular displacement of an object or coordinate system relative to a <i>cartesian coordinate system</i>.<br /><br /><br />
		/// Value for EventEnum.<br/>
		/// <br/>See also <seealso cref="EventEnum">EventEnum</seealso>
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
			public string Summary => @"&#10;&#10;&#10;three space angular displacement of an object or coordinate system relative to a {{term(cartesian coordinate system)}}.&#10;
";
		}
		private TRANSLATIONValue _TRANSLATION;
		/// <inheritdoc cref="TRANSLATIONValue" path="/summary" />
		public TRANSLATIONValue TRANSLATION => _TRANSLATION ?? (_TRANSLATION = new TRANSLATIONValue());

		/// <summary>﻿three space linear displacement of an object or coordinate system relative to a <i>cartesian coordinate system</i>.<br /><br /><br />
		/// Value for EventEnum.<br/>
		/// <br/>See also <seealso cref="EventEnum">EventEnum</seealso>
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
			public string Summary => @"&#10;&#10;&#10;three space linear displacement of an object or coordinate system relative to a {{term(cartesian coordinate system)}}.&#10;
";
		}
		private DEVICE_ADDEDValue _DEVICE_ADDED;
		/// <inheritdoc cref="DEVICE_ADDEDValue" path="/summary" />
		public DEVICE_ADDEDValue DEVICE_ADDED => _DEVICE_ADDED ?? (_DEVICE_ADDED = new DEVICE_ADDEDValue());

		/// <summary>﻿<i>UUID</i> of new device added to an <i>MTConnect Agent</i>.<br /><br /><br />
		/// Value for EventEnum.<br/>
		/// <br/>See also <seealso cref="EventEnum">EventEnum</seealso>
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
			public string Summary => @"&#10;&#10;&#10;{{term(UUID)}} of new device added to an {{term(MTConnect Agent)}}.&#10;
";
		}
		private DEVICE_REMOVEDValue _DEVICE_REMOVED;
		/// <inheritdoc cref="DEVICE_REMOVEDValue" path="/summary" />
		public DEVICE_REMOVEDValue DEVICE_REMOVED => _DEVICE_REMOVED ?? (_DEVICE_REMOVED = new DEVICE_REMOVEDValue());

		/// <summary>﻿<i>UUID</i> of a device removed from an <i>MTConnect Agent</i>.<br /><br /><br />
		/// Value for EventEnum.<br/>
		/// <br/>See also <seealso cref="EventEnum">EventEnum</seealso>
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
			public string Summary => @"&#10;&#10;&#10;{{term(UUID)}} of a device removed from an {{term(MTConnect Agent)}}.&#10;
";
		}
		private DEVICE_CHANGEDValue _DEVICE_CHANGED;
		/// <inheritdoc cref="DEVICE_CHANGEDValue" path="/summary" />
		public DEVICE_CHANGEDValue DEVICE_CHANGED => _DEVICE_CHANGED ?? (_DEVICE_CHANGED = new DEVICE_CHANGEDValue());

		/// <summary>﻿<i>UUID</i> of the device whose <i>metadata</i> has changed.<br /><br /><br />
		/// Value for EventEnum.<br/>
		/// <br/>See also <seealso cref="EventEnum">EventEnum</seealso>
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
			public string Summary => @"&#10;&#10;&#10;{{term(UUID)}} of the device whose {{term(metadata)}} has changed.&#10;
";
		}
		private CONNECTION_STATUSValue _CONNECTION_STATUS;
		/// <inheritdoc cref="CONNECTION_STATUSValue" path="/summary" />
		public CONNECTION_STATUSValue CONNECTION_STATUS => _CONNECTION_STATUS ?? (_CONNECTION_STATUS = new CONNECTION_STATUSValue());

		/// <summary>﻿status of the connection between an <i>adapter</i> and an <i>agent</i>.<br /><br /><br />
		/// Value for EventEnum.<br/>
		/// <br/>See also <seealso cref="EventEnum">EventEnum</seealso>
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
			public string Summary => @"&#10;&#10;&#10;status of the connection between an {{term(adapter)}} and an {{term(agent)}}.&#10;
";
		}
		private ADAPTER_SOFTWARE_VERSIONValue _ADAPTER_SOFTWARE_VERSION;
		/// <inheritdoc cref="ADAPTER_SOFTWARE_VERSIONValue" path="/summary" />
		public ADAPTER_SOFTWARE_VERSIONValue ADAPTER_SOFTWARE_VERSION => _ADAPTER_SOFTWARE_VERSION ?? (_ADAPTER_SOFTWARE_VERSION = new ADAPTER_SOFTWARE_VERSIONValue());

		/// <summary>﻿originator’s software version of the <i>adapter</i>.<br /><br /><br />
		/// Value for EventEnum.<br/>
		/// <br/>See also <seealso cref="EventEnum">EventEnum</seealso>
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
			public string Summary => @"&#10;&#10;&#10;originator’s software version of the {{term(adapter)}}.&#10;
";
		}
		private ADAPTER_URIValue _ADAPTER_URI;
		/// <inheritdoc cref="ADAPTER_URIValue" path="/summary" />
		public ADAPTER_URIValue ADAPTER_URI => _ADAPTER_URI ?? (_ADAPTER_URI = new ADAPTER_URIValue());

		/// <summary>﻿<i>URI</i> of the <i>adapter</i>.<br /><br /><br />
		/// Value for EventEnum.<br/>
		/// <br/>See also <seealso cref="EventEnum">EventEnum</seealso>
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
			public string Summary => @"&#10;&#10;&#10;{{term(URI)}} of the {{term(adapter)}}.&#10;
";
		}
		private MTCONNECT_VERSIONValue _MTCONNECT_VERSION;
		/// <inheritdoc cref="MTCONNECT_VERSIONValue" path="/summary" />
		public MTCONNECT_VERSIONValue MTCONNECT_VERSION => _MTCONNECT_VERSION ?? (_MTCONNECT_VERSION = new MTCONNECT_VERSIONValue());

		/// <summary>﻿reference version of the MTConnect Standard supported by the <i>adapter</i>.<br /><br /><br />
		/// Value for EventEnum.<br/>
		/// <br/>See also <seealso cref="EventEnum">EventEnum</seealso>
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
			public string Summary => @"&#10;&#10;&#10;reference version of the MTConnect Standard supported by the {{term(adapter)}}.&#10;
";
		}
		private SENSOR_ATTACHMENTValue _SENSOR_ATTACHMENT;
		/// <inheritdoc cref="SENSOR_ATTACHMENTValue" path="/summary" />
		public SENSOR_ATTACHMENTValue SENSOR_ATTACHMENT => _SENSOR_ATTACHMENT ?? (_SENSOR_ATTACHMENT = new SENSOR_ATTACHMENTValue());

		/// <summary>﻿<i>attachment</i> between a sensor and an entity.<br /><br /><br />
		/// Value for EventEnum.<br/>
		/// <br/>See also <seealso cref="EventEnum">EventEnum</seealso>
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
			public string Summary => @"&#10;&#10;&#10;{{term(attachment)}} between a sensor and an entity.&#10;
";
		}
		private PART_STATUSValue _PART_STATUS;
		/// <inheritdoc cref="PART_STATUSValue" path="/summary" />
		public PART_STATUSValue PART_STATUS => _PART_STATUS ?? (_PART_STATUS = new PART_STATUSValue());

		/// <summary>﻿state or condition of a part.<br /><br /><br />
		/// Value for EventEnum.<br/>
		/// <br/>See also <seealso cref="EventEnum">EventEnum</seealso>
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
			public string Summary => @"&#10;&#10;&#10;state or condition of a part.&#10;
";
		}
		private PROCESS_OCCURRENCE_IDValue _PROCESS_OCCURRENCE_ID;
		/// <inheritdoc cref="PROCESS_OCCURRENCE_IDValue" path="/summary" />
		public PROCESS_OCCURRENCE_IDValue PROCESS_OCCURRENCE_ID => _PROCESS_OCCURRENCE_ID ?? (_PROCESS_OCCURRENCE_ID = new PROCESS_OCCURRENCE_IDValue());

		/// <summary>﻿identifier of a process being executed by the device.<br /><br /><br />
		/// Value for EventEnum.<br/>
		/// <br/>See also <seealso cref="EventEnum">EventEnum</seealso>
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
			public string Summary => @"&#10;&#10;&#10;identifier of a process being executed by the device.&#10;
";
		}
		private PROCESS_AGGREGATE_IDValue _PROCESS_AGGREGATE_ID;
		/// <inheritdoc cref="PROCESS_AGGREGATE_IDValue" path="/summary" />
		public PROCESS_AGGREGATE_IDValue PROCESS_AGGREGATE_ID => _PROCESS_AGGREGATE_ID ?? (_PROCESS_AGGREGATE_ID = new PROCESS_AGGREGATE_IDValue());

		/// <summary>﻿identifier given to link the individual occurrence to a group of related occurrences, such as a process step in a process plan.<br /><br /><br />
		/// Value for EventEnum.<br/>
		/// <br/>See also <seealso cref="EventEnum">EventEnum</seealso>
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
			public string Summary => @"&#10;&#10;&#10;identifier given to link the individual occurrence to a group of related occurrences, such as a process step in a process plan.&#10;
";
		}
		private PROCESS_KIND_IDValue _PROCESS_KIND_ID;
		/// <inheritdoc cref="PROCESS_KIND_IDValue" path="/summary" />
		public PROCESS_KIND_IDValue PROCESS_KIND_ID => _PROCESS_KIND_ID ?? (_PROCESS_KIND_ID = new PROCESS_KIND_IDValue());

		/// <summary>﻿identifier given to link the individual occurrence to a class of processes or process definition.<br /><br /><br /><br />
		/// Value for EventEnum.<br/>
		/// <br/>See also <seealso cref="EventEnum">EventEnum</seealso>
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
			public string Summary => @"&#10;&#10;&#10;identifier given to link the individual occurrence to a class of processes or process definition.&#10;
";
		}
		private PART_GROUP_IDValue _PART_GROUP_ID;
		/// <inheritdoc cref="PART_GROUP_IDValue" path="/summary" />
		public PART_GROUP_IDValue PART_GROUP_ID => _PART_GROUP_ID ?? (_PART_GROUP_ID = new PART_GROUP_IDValue());

		/// <summary>﻿identifier given to a collection of individual parts. <br /><br /><br />
		/// Value for EventEnum.<br/>
		/// <br/>See also <seealso cref="EventEnum">EventEnum</seealso>
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
			public string Summary => @"&#10;&#10;&#10;identifier given to a collection of individual parts. &#10;
";
		}
		private PART_KIND_IDValue _PART_KIND_ID;
		/// <inheritdoc cref="PART_KIND_IDValue" path="/summary" />
		public PART_KIND_IDValue PART_KIND_ID => _PART_KIND_ID ?? (_PART_KIND_ID = new PART_KIND_IDValue());

		/// <summary>﻿identifier given to link the individual occurrence to a class of parts, typically distinguished by a particular part design.<br /><br /><br />
		/// Value for EventEnum.<br/>
		/// <br/>See also <seealso cref="EventEnum">EventEnum</seealso>
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
			public string Summary => @"&#10;&#10;&#10;identifier given to link the individual occurrence to a class of parts, typically distinguished by a particular part design.&#10;
";
		}
		private PART_UNIQUE_IDValue _PART_UNIQUE_ID;
		/// <inheritdoc cref="PART_UNIQUE_IDValue" path="/summary" />
		public PART_UNIQUE_IDValue PART_UNIQUE_ID => _PART_UNIQUE_ID ?? (_PART_UNIQUE_ID = new PART_UNIQUE_IDValue());

		/// <summary>﻿identifier given to a distinguishable, individual part. <br /><br /><br />
		/// Value for EventEnum.<br/>
		/// <br/>See also <seealso cref="EventEnum">EventEnum</seealso>
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
			public string Summary => @"&#10;&#10;&#10;identifier given to a distinguishable, individual part. &#10;
";
		}
		private CONTROL_LIMITValue _CONTROL_LIMIT;
		/// <inheritdoc cref="CONTROL_LIMITValue" path="/summary" />
		public CONTROL_LIMITValue CONTROL_LIMIT => _CONTROL_LIMIT ?? (_CONTROL_LIMIT = new CONTROL_LIMITValue());

		/// <summary>﻿set of limits used to indicate whether a process variable is stable and in control.<br /><br /><b>DEPRECATION WARNING</b>. Recommend using <c>CONTROL_LIMITS</c>.<br /><br /><br />
		/// Value for EventEnum.<br/>
		/// <br/>See also <seealso cref="EventEnum">EventEnum</seealso>
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
			public string Summary => @"&#10;&#10;&#10;set of limits used to indicate whether a process variable is stable and in control.

**DEPRECATION WARNING**. Recommend using `CONTROL_LIMITS`.&#10;
";
		}
		private SPECIFICATION_LIMITValue _SPECIFICATION_LIMIT;
		/// <inheritdoc cref="SPECIFICATION_LIMITValue" path="/summary" />
		public SPECIFICATION_LIMITValue SPECIFICATION_LIMIT => _SPECIFICATION_LIMIT ?? (_SPECIFICATION_LIMIT = new SPECIFICATION_LIMITValue());

		/// <summary>﻿set of limits defining a range of values designating acceptable performance for a variable.<br /><br /><b>DEPRECATION WARNING</b>. Recommend using <c>SPECIFICATION_LIMITS</c>.<br /><br /><br />
		/// Value for EventEnum.<br/>
		/// <br/>See also <seealso cref="EventEnum">EventEnum</seealso>
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
			public string Summary => @"&#10;&#10;&#10;set of limits defining a range of values designating acceptable performance for a variable.

**DEPRECATION WARNING**. Recommend using `SPECIFICATION_LIMITS`.&#10;
";
		}
		private ALARM_LIMITValue _ALARM_LIMIT;
		/// <inheritdoc cref="ALARM_LIMITValue" path="/summary" />
		public ALARM_LIMITValue ALARM_LIMIT => _ALARM_LIMIT ?? (_ALARM_LIMIT = new ALARM_LIMITValue());

		/// <summary>﻿set of limits used to trigger warning or alarm indicators.<br /><br /><b>DEPRECATION WARNING</b>. Recommend using <c>ALARM_LIMITS</c>.<br /><br /><br />
		/// Value for EventEnum.<br/>
		/// <br/>See also <seealso cref="EventEnum">EventEnum</seealso>
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
			public string Summary => @"&#10;&#10;&#10;set of limits used to trigger warning or alarm indicators.

**DEPRECATION WARNING**. Recommend using `ALARM_LIMITS`.&#10;
";
		}
		private LOAD_COUNTValue _LOAD_COUNT;
		/// <inheritdoc cref="LOAD_COUNTValue" path="/summary" />
		public LOAD_COUNTValue LOAD_COUNT => _LOAD_COUNT ?? (_LOAD_COUNT = new LOAD_COUNTValue());

		/// <summary>﻿accumulation of the number of times an operation has attempted to, or is planned to attempt to, load materials, parts, or other items.<br /><br /><br />
		/// Value for EventEnum.<br/>
		/// <br/>See also <seealso cref="EventEnum">EventEnum</seealso>
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
			public string Summary => @"&#10;&#10;&#10;accumulation of the number of times an operation has attempted to, or is planned to attempt to, load materials, parts, or other items.&#10;
";
		}
		private UNLOAD_COUNTValue _UNLOAD_COUNT;
		/// <inheritdoc cref="UNLOAD_COUNTValue" path="/summary" />
		public UNLOAD_COUNTValue UNLOAD_COUNT => _UNLOAD_COUNT ?? (_UNLOAD_COUNT = new UNLOAD_COUNTValue());

		/// <summary>﻿accumulation of the number of times an operation has attempted to, or is planned to attempt to, unload materials, parts, or other items.<br /><br /><br />
		/// Value for EventEnum.<br/>
		/// <br/>See also <seealso cref="EventEnum">EventEnum</seealso>
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
			public string Summary => @"&#10;&#10;&#10;accumulation of the number of times an operation has attempted to, or is planned to attempt to, unload materials, parts, or other items.&#10;
";
		}
		private TRANSFER_COUNTValue _TRANSFER_COUNT;
		/// <inheritdoc cref="TRANSFER_COUNTValue" path="/summary" />
		public TRANSFER_COUNTValue TRANSFER_COUNT => _TRANSFER_COUNT ?? (_TRANSFER_COUNT = new TRANSFER_COUNTValue());

		/// <summary>﻿accumulation of the number of times an operation has attempted to, or is planned to attempt to, transfer materials, parts, or other items from one location to another.<br /><br /><br />
		/// Value for EventEnum.<br/>
		/// <br/>See also <seealso cref="EventEnum">EventEnum</seealso>
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
			public string Summary => @"&#10;&#10;&#10;accumulation of the number of times an operation has attempted to, or is planned to attempt to, transfer materials, parts, or other items from one location to another.&#10;
";
		}
		private ACTIVATION_COUNTValue _ACTIVATION_COUNT;
		/// <inheritdoc cref="ACTIVATION_COUNTValue" path="/summary" />
		public ACTIVATION_COUNTValue ACTIVATION_COUNT => _ACTIVATION_COUNT ?? (_ACTIVATION_COUNT = new ACTIVATION_COUNTValue());

		/// <summary>﻿accumulation of the number of times a function has attempted to, or is planned to attempt to, activate or be performed.<br /><br /><br />
		/// Value for EventEnum.<br/>
		/// <br/>See also <seealso cref="EventEnum">EventEnum</seealso>
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
			public string Summary => @"&#10;&#10;&#10;accumulation of the number of times a function has attempted to, or is planned to attempt to, activate or be performed.&#10;
";
		}
		private DEACTIVATION_COUNTValue _DEACTIVATION_COUNT;
		/// <inheritdoc cref="DEACTIVATION_COUNTValue" path="/summary" />
		public DEACTIVATION_COUNTValue DEACTIVATION_COUNT => _DEACTIVATION_COUNT ?? (_DEACTIVATION_COUNT = new DEACTIVATION_COUNTValue());

		/// <summary>﻿accumulation of the number of times a function has attempted to, or is planned to attempt to, deactivate or cease.<br /><br /><br />
		/// Value for EventEnum.<br/>
		/// <br/>See also <seealso cref="EventEnum">EventEnum</seealso>
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
			public string Summary => @"&#10;&#10;&#10;accumulation of the number of times a function has attempted to, or is planned to attempt to, deactivate or cease.&#10;
";
		}
		private CYCLE_COUNTValue _CYCLE_COUNT;
		/// <inheritdoc cref="CYCLE_COUNTValue" path="/summary" />
		public CYCLE_COUNTValue CYCLE_COUNT => _CYCLE_COUNT ?? (_CYCLE_COUNT = new CYCLE_COUNTValue());

		/// <summary>﻿accumulation of the number of times a cyclic function has attempted to, or is planned to attempt to execute.<br /><br /><br />
		/// Value for EventEnum.<br/>
		/// <br/>See also <seealso cref="EventEnum">EventEnum</seealso>
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
			public string Summary => @"&#10;&#10;&#10;accumulation of the number of times a cyclic function has attempted to, or is planned to attempt to execute.&#10;
";
		}
		private VALVE_STATEValue _VALVE_STATE;
		/// <inheritdoc cref="VALVE_STATEValue" path="/summary" />
		public VALVE_STATEValue VALVE_STATE => _VALVE_STATE ?? (_VALVE_STATE = new VALVE_STATEValue());

		/// <summary>﻿state of a valve is one of open, closed, or transitioning between the states.<br /><br /><br />
		/// Value for EventEnum.<br/>
		/// <br/>See also <seealso cref="EventEnum">EventEnum</seealso>
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
			public string Summary => @"&#10;&#10;&#10;state of a valve is one of open, closed, or transitioning between the states.&#10;
";
		}
		private LOCK_STATEValue _LOCK_STATE;
		/// <inheritdoc cref="LOCK_STATEValue" path="/summary" />
		public LOCK_STATEValue LOCK_STATE => _LOCK_STATE ?? (_LOCK_STATE = new LOCK_STATEValue());

		/// <summary>﻿state or operating mode of a <see cref="Lock">Lock</see>.<br /><br /><br />
		/// Value for EventEnum.<br/>
		/// <br/>See also <seealso cref="EventEnum">EventEnum</seealso>
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
			public string Summary => @"&#10;&#10;&#10;state or operating mode of a {{block(Lock)}}.&#10;
";
		}
		private PROCESS_STATEValue _PROCESS_STATE;
		/// <inheritdoc cref="PROCESS_STATEValue" path="/summary" />
		public PROCESS_STATEValue PROCESS_STATE => _PROCESS_STATE ?? (_PROCESS_STATE = new PROCESS_STATEValue());

		/// <summary>﻿particular condition of the process occurrence at a specific time.<br /><br /><br />
		/// Value for EventEnum.<br/>
		/// <br/>See also <seealso cref="EventEnum">EventEnum</seealso>
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
			public string Summary => @"&#10;&#10;&#10;particular condition of the process occurrence at a specific time.&#10;
";
		}
		private PART_PROCESSING_STATEValue _PART_PROCESSING_STATE;
		/// <inheritdoc cref="PART_PROCESSING_STATEValue" path="/summary" />
		public PART_PROCESSING_STATEValue PART_PROCESSING_STATE => _PART_PROCESSING_STATE ?? (_PART_PROCESSING_STATE = new PART_PROCESSING_STATEValue());

		/// <summary>﻿particular condition of the part occurrence at a specific time.<br /><br /><br />
		/// Value for EventEnum.<br/>
		/// <br/>See also <seealso cref="EventEnum">EventEnum</seealso>
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
			public string Summary => @"&#10;&#10;&#10;particular condition of the part occurrence at a specific time.&#10;
";
		}
		private OPERATING_MODEValue _OPERATING_MODE;
		/// <inheritdoc cref="OPERATING_MODEValue" path="/summary" />
		public OPERATING_MODEValue OPERATING_MODE => _OPERATING_MODE ?? (_OPERATING_MODE = new OPERATING_MODEValue());

		/// <summary>﻿state of <see cref="Component">Component</see> or <see cref="Composition">Composition</see> that describes the automatic or manual operation of the entity.<br /><br /><br />
		/// Value for EventEnum.<br/>
		/// <br/>See also <seealso cref="EventEnum">EventEnum</seealso>
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
			public string Summary => @"&#10;&#10;&#10;state of {{block(Component)}} or {{block(Composition)}} that describes the automatic or manual operation of the entity.&#10;
";
		}
		private ASSET_COUNTValue _ASSET_COUNT;
		/// <inheritdoc cref="ASSET_COUNTValue" path="/summary" />
		public ASSET_COUNTValue ASSET_COUNT => _ASSET_COUNT ?? (_ASSET_COUNT = new ASSET_COUNTValue());

		/// <summary>﻿<i>data set</i> of the number of <i>Asset</i>s of a given type for a <i>Device</i>.<br /><br /><br />
		/// Value for EventEnum.<br/>
		/// <br/>See also <seealso cref="EventEnum">EventEnum</seealso>
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
			public string Summary => @"&#10;&#10;&#10;{{term(data set)}} of the number of {{termplural(Asset)}} of a given type for a {{term(Device)}}.&#10;
";
		}
		private MAINTENANCE_LISTValue _MAINTENANCE_LIST;
		/// <inheritdoc cref="MAINTENANCE_LISTValue" path="/summary" />
		public MAINTENANCE_LISTValue MAINTENANCE_LIST => _MAINTENANCE_LIST ?? (_MAINTENANCE_LIST = new MAINTENANCE_LISTValue());

		/// <summary>﻿actions or activities to be performed in support of a piece of equipment.<br /><br /><br />
		/// Value for EventEnum.<br/>
		/// <br/>See also <seealso cref="EventEnum">EventEnum</seealso>
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
			public string Summary => @"&#10;&#10;&#10;actions or activities to be performed in support of a piece of equipment.&#10;
";
		}
		private FIXTURE_IDValue _FIXTURE_ID;
		/// <inheritdoc cref="FIXTURE_IDValue" path="/summary" />
		public FIXTURE_IDValue FIXTURE_ID => _FIXTURE_ID ?? (_FIXTURE_ID = new FIXTURE_IDValue());

		/// <summary>﻿identifier for the current workholding or part clamp in use by a piece of equipment.<br /><br /><br />
		/// Value for EventEnum.<br/>
		/// <br/>See also <seealso cref="EventEnum">EventEnum</seealso>
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
			public string Summary => @"&#10;&#10;&#10;identifier for the current workholding or part clamp in use by a piece of equipment.&#10;
";
		}
		private PART_COUNT_TYPEValue _PART_COUNT_TYPE;
		/// <inheritdoc cref="PART_COUNT_TYPEValue" path="/summary" />
		public PART_COUNT_TYPEValue PART_COUNT_TYPE => _PART_COUNT_TYPE ?? (_PART_COUNT_TYPE = new PART_COUNT_TYPEValue());

		/// <summary>﻿interpretation of <c>PART_COUNT</c>.<br /><br /><br />
		/// Value for EventEnum.<br/>
		/// <br/>See also <seealso cref="EventEnum">EventEnum</seealso>
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
			public string Summary => @"&#10;&#10;&#10;interpretation of `PART_COUNT`.&#10;
";
		}
		private CLOCK_TIMEValue _CLOCK_TIME;
		/// <inheritdoc cref="CLOCK_TIMEValue" path="/summary" />
		public CLOCK_TIMEValue CLOCK_TIME => _CLOCK_TIME ?? (_CLOCK_TIME = new CLOCK_TIMEValue());

		/// <summary>﻿time provided by a timing device at a specific point in time.<br /><br /><br />
		/// Value for EventEnum.<br/>
		/// <br/>See also <seealso cref="EventEnum">EventEnum</seealso>
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
			public string Summary => @"&#10;&#10;&#10;time provided by a timing device at a specific point in time.&#10;
";
		}
		private HOST_NAMEValue _HOST_NAME;
		/// <inheritdoc cref="HOST_NAMEValue" path="/summary" />
		public HOST_NAMEValue HOST_NAME => _HOST_NAME ?? (_HOST_NAME = new HOST_NAMEValue());

		/// <summary>﻿name of the host computer supplying data.<br /><br /><br />
		/// Value for EventEnum.<br/>
		/// <br/>See also <seealso cref="EventEnum">EventEnum</seealso>
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
			public string Summary => @"&#10;&#10;&#10;name of the host computer supplying data.&#10;
";
		}
		private NETWORK_PORTValue _NETWORK_PORT;
		/// <inheritdoc cref="NETWORK_PORTValue" path="/summary" />
		public NETWORK_PORTValue NETWORK_PORT => _NETWORK_PORT ?? (_NETWORK_PORT = new NETWORK_PORTValue());

		/// <summary>﻿number of the TCP/IP or UDP/IP port for the connection endpoint.<br /><br /><br />
		/// Value for EventEnum.<br/>
		/// <br/>See also <seealso cref="EventEnum">EventEnum</seealso>
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
			public string Summary => @"&#10;&#10;&#10;number of the TCP/IP or UDP/IP port for the connection endpoint.&#10;
";
		}
		private LEAK_DETECTValue _LEAK_DETECT;
		/// <inheritdoc cref="LEAK_DETECTValue" path="/summary" />
		public LEAK_DETECTValue LEAK_DETECT => _LEAK_DETECT ?? (_LEAK_DETECT = new LEAK_DETECTValue());

		/// <summary>﻿indication designating whether a leak has been detected.<br /><br /><br />
		/// Value for EventEnum.<br/>
		/// <br/>See also <seealso cref="EventEnum">EventEnum</seealso>
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
			public string Summary => @"&#10;&#10;&#10;indication designating whether a leak has been detected.&#10;
";
		}
		private BATTERY_STATEValue _BATTERY_STATE;
		/// <inheritdoc cref="BATTERY_STATEValue" path="/summary" />
		public BATTERY_STATEValue BATTERY_STATE => _BATTERY_STATE ?? (_BATTERY_STATE = new BATTERY_STATEValue());

		/// <summary>﻿present status of the battery.<br /><br /><br />
		/// Value for EventEnum.<br/>
		/// <br/>See also <seealso cref="EventEnum">EventEnum</seealso>
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
			public string Summary => @"&#10;&#10;&#10;present status of the battery.&#10;
";
		}
		private FEATURE_PERSISTENT_IDValue _FEATURE_PERSISTENT_ID;
		/// <inheritdoc cref="FEATURE_PERSISTENT_IDValue" path="/summary" />
		public FEATURE_PERSISTENT_IDValue FEATURE_PERSISTENT_ID => _FEATURE_PERSISTENT_ID ?? (_FEATURE_PERSISTENT_ID = new FEATURE_PERSISTENT_IDValue());

		/// <summary>﻿<i>UUID</i> of a <i>feature</i>. <seealso href="https://www.google.com/search?q=ISO 10303 AP 242/239&btnI=I">ISO 10303 AP 242/239</seealso>.<br /><br /><br />
		/// Value for EventEnum.<br/>
		/// <br/>See also <seealso cref="EventEnum">EventEnum</seealso>
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
			public string Summary => @"&#10;&#10;&#10;{{term(UUID)}} of a {{term(feature)}}. {{cite(ISO 10303 AP 242/239)}}.&#10;
";
		}
		private SENSOR_STATEValue _SENSOR_STATE;
		/// <inheritdoc cref="SENSOR_STATEValue" path="/summary" />
		public SENSOR_STATEValue SENSOR_STATE => _SENSOR_STATE ?? (_SENSOR_STATE = new SENSOR_STATEValue());

		/// <summary>﻿detection result of a sensor.<br /><br /><br />
		/// Value for EventEnum.<br/>
		/// <br/>See also <seealso cref="EventEnum">EventEnum</seealso>
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
			public string Summary => @"&#10;&#10;&#10;detection result of a sensor.&#10;
";
		}
		private COMPONENT_DATAValue _COMPONENT_DATA;
		/// <inheritdoc cref="COMPONENT_DATAValue" path="/summary" />
		public COMPONENT_DATAValue COMPONENT_DATA => _COMPONENT_DATA ?? (_COMPONENT_DATA = new COMPONENT_DATAValue());

		/// <summary>﻿<see cref="Event">Event</see> that represents a <see cref="Component">Component</see> where the <see cref="EntryDefinition">EntryDefinition</see> identifies the <see cref="Component">Component</see> and the <see cref="CellDefinition">CellDefinition</see>s define the <see cref="Component">Component</see>'s observed <see cref="DataItem">DataItem</see>s.<br /><br /><br />
		/// Value for EventEnum.<br/>
		/// <br/>See also <seealso cref="EventEnum">EventEnum</seealso>
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
			public string Summary => @"&#10;&#10;&#10;{{block(Event)}} that represents a {{block(Component)}} where the {{block(EntryDefinition)}} identifies the {{block(Component)}} and the {{block(CellDefinition)}}s define the {{block(Component)}}'s observed {{block(DataItem)}}s.&#10;
";
		}
		private WORK_OFFSETSValue _WORK_OFFSETS;
		/// <inheritdoc cref="WORK_OFFSETSValue" path="/summary" />
		public WORK_OFFSETSValue WORK_OFFSETS => _WORK_OFFSETS ?? (_WORK_OFFSETS = new WORK_OFFSETSValue());

		/// <summary>﻿properties of each addressable work offset.<br /><br /><br />
		/// Value for EventEnum.<br/>
		/// <br/>See also <seealso cref="EventEnum">EventEnum</seealso>
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
			public string Summary => @"&#10;&#10;&#10;properties of each addressable work offset.&#10;
";
		}
		private TOOL_OFFSETSValue _TOOL_OFFSETS;
		/// <inheritdoc cref="TOOL_OFFSETSValue" path="/summary" />
		public TOOL_OFFSETSValue TOOL_OFFSETS => _TOOL_OFFSETS ?? (_TOOL_OFFSETS = new TOOL_OFFSETSValue());

		/// <summary>﻿properties of each addressable tool offset.<br /><br /><br />
		/// Value for EventEnum.<br/>
		/// <br/>See also <seealso cref="EventEnum">EventEnum</seealso>
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
			public string Summary => @"&#10;&#10;&#10;properties of each addressable tool offset.&#10;
";
		}
		private FEATURE_MEASUREMENTValue _FEATURE_MEASUREMENT;
		/// <inheritdoc cref="FEATURE_MEASUREMENTValue" path="/summary" />
		public FEATURE_MEASUREMENTValue FEATURE_MEASUREMENT => _FEATURE_MEASUREMENT ?? (_FEATURE_MEASUREMENT = new FEATURE_MEASUREMENTValue());

		/// <summary>﻿assessing elements of a <i>feature</i>.<br /><br /><br />
		/// Value for EventEnum.<br/>
		/// <br/>See also <seealso cref="EventEnum">EventEnum</seealso>
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
			public string Summary => @"&#10;&#10;&#10;assessing elements of a {{term(feature)}}.&#10;
";
		}
		private CHARACTERISTIC_PERSISTENT_IDValue _CHARACTERISTIC_PERSISTENT_ID;
		/// <inheritdoc cref="CHARACTERISTIC_PERSISTENT_IDValue" path="/summary" />
		public CHARACTERISTIC_PERSISTENT_IDValue CHARACTERISTIC_PERSISTENT_ID => _CHARACTERISTIC_PERSISTENT_ID ?? (_CHARACTERISTIC_PERSISTENT_ID = new CHARACTERISTIC_PERSISTENT_IDValue());

		/// <summary>﻿<i>UUID</i> of the <i>characteristic</i>.<br /><br /><br />
		/// Value for EventEnum.<br/>
		/// <br/>See also <seealso cref="EventEnum">EventEnum</seealso>
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
			public string Summary => @"&#10;&#10;&#10;{{term(UUID)}} of the {{term(characteristic)}}.&#10;
";
		}
		private MEASUREMENT_TYPEValue _MEASUREMENT_TYPE;
		/// <inheritdoc cref="MEASUREMENT_TYPEValue" path="/summary" />
		public MEASUREMENT_TYPEValue MEASUREMENT_TYPE => _MEASUREMENT_TYPE ?? (_MEASUREMENT_TYPE = new MEASUREMENT_TYPEValue());

		/// <summary>﻿class of measurement being performed. <seealso href="https://www.google.com/search?q=QIF 3:2018 Section 6.3&btnI=I">QIF 3:2018 Section 6.3</seealso><br /><br /><br />
		/// Value for EventEnum.<br/>
		/// <br/>See also <seealso cref="EventEnum">EventEnum</seealso>
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
			public string Summary => @"&#10;&#10;&#10;class of measurement being performed. {{cite(QIF 3:2018 Section 6.3)}}&#10;
";
		}
		private MEASUREMENT_VALUEValue _MEASUREMENT_VALUE;
		/// <inheritdoc cref="MEASUREMENT_VALUEValue" path="/summary" />
		public MEASUREMENT_VALUEValue MEASUREMENT_VALUE => _MEASUREMENT_VALUE ?? (_MEASUREMENT_VALUE = new MEASUREMENT_VALUEValue());

		/// <summary>﻿measurement based on the measurement type.<br /><br /><br />
		/// Value for EventEnum.<br/>
		/// <br/>See also <seealso cref="EventEnum">EventEnum</seealso>
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
			public string Summary => @"&#10;&#10;&#10;measurement based on the measurement type.&#10;
";
		}
		private MEASUREMENT_UNITSValue _MEASUREMENT_UNITS;
		/// <inheritdoc cref="MEASUREMENT_UNITSValue" path="/summary" />
		public MEASUREMENT_UNITSValue MEASUREMENT_UNITS => _MEASUREMENT_UNITS ?? (_MEASUREMENT_UNITS = new MEASUREMENT_UNITSValue());

		/// <summary>﻿engineering units of the measurement.<br /><br /><br />
		/// Value for EventEnum.<br/>
		/// <br/>See also <seealso cref="EventEnum">EventEnum</seealso>
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
			public string Summary => @"&#10;&#10;&#10;engineering units of the measurement.&#10;
";
		}
		private CHARACTERISTIC_STATUSValue _CHARACTERISTIC_STATUS;
		/// <inheritdoc cref="CHARACTERISTIC_STATUSValue" path="/summary" />
		public CHARACTERISTIC_STATUSValue CHARACTERISTIC_STATUS => _CHARACTERISTIC_STATUS ?? (_CHARACTERISTIC_STATUS = new CHARACTERISTIC_STATUSValue());

		/// <summary>﻿pass/fail result of the measurement.<br /><br /><br />
		/// Value for EventEnum.<br/>
		/// <br/>See also <seealso cref="EventEnum">EventEnum</seealso>
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
			public string Summary => @"&#10;&#10;&#10;pass/fail result of the measurement.&#10;
";
		}
		private UNCERTAINTY_TYPEValue _UNCERTAINTY_TYPE;
		/// <inheritdoc cref="UNCERTAINTY_TYPEValue" path="/summary" />
		public UNCERTAINTY_TYPEValue UNCERTAINTY_TYPE => _UNCERTAINTY_TYPE ?? (_UNCERTAINTY_TYPE = new UNCERTAINTY_TYPEValue());

		/// <summary>﻿method used to compute <i>standard uncertainty</i>.<br /><br /><br />
		/// Value for EventEnum.<br/>
		/// <br/>See also <seealso cref="EventEnum">EventEnum</seealso>
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
			public string Summary => @"&#10;&#10;&#10;method used to compute {{term(standard uncertainty)}}.&#10;
";
		}
		private UNCERTAINTYValue _UNCERTAINTY;
		/// <inheritdoc cref="UNCERTAINTYValue" path="/summary" />
		public UNCERTAINTYValue UNCERTAINTY => _UNCERTAINTY ?? (_UNCERTAINTY = new UNCERTAINTYValue());

		/// <summary>﻿<i>uncertainty</i> specified by <see cref="UncertaintyType">UncertaintyType</see>.<br /><br /><br />
		/// Value for EventEnum.<br/>
		/// <br/>See also <seealso cref="EventEnum">EventEnum</seealso>
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
			public string Summary => @"&#10;&#10;&#10;{{term(uncertainty)}} specified by {{block(UncertaintyType)}}.&#10;
";
		}
		private SPECIFICATION_LIMITSValue _SPECIFICATION_LIMITS;
		/// <inheritdoc cref="SPECIFICATION_LIMITSValue" path="/summary" />
		public SPECIFICATION_LIMITSValue SPECIFICATION_LIMITS => _SPECIFICATION_LIMITS ?? (_SPECIFICATION_LIMITS = new SPECIFICATION_LIMITSValue());

		/// <summary>﻿set of limits defining a range of values designating acceptable performance for a variable.<br /><br /><br />
		/// Value for EventEnum.<br/>
		/// <br/>See also <seealso cref="EventEnum">EventEnum</seealso>
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
			public string Summary => @"&#10;&#10;&#10;set of limits defining a range of values designating acceptable performance for a variable.&#10;
";
		}
		private CONTROL_LIMITSValue _CONTROL_LIMITS;
		/// <inheritdoc cref="CONTROL_LIMITSValue" path="/summary" />
		public CONTROL_LIMITSValue CONTROL_LIMITS => _CONTROL_LIMITS ?? (_CONTROL_LIMITS = new CONTROL_LIMITSValue());

		/// <summary>﻿set of limits used to indicate whether a process variable is stable and in control.<br /><br /><br />
		/// Value for EventEnum.<br/>
		/// <br/>See also <seealso cref="EventEnum">EventEnum</seealso>
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
			public string Summary => @"&#10;&#10;&#10;set of limits used to indicate whether a process variable is stable and in control.&#10;
";
		}
		private ALARM_LIMITSValue _ALARM_LIMITS;
		/// <inheritdoc cref="ALARM_LIMITSValue" path="/summary" />
		public ALARM_LIMITSValue ALARM_LIMITS => _ALARM_LIMITS ?? (_ALARM_LIMITS = new ALARM_LIMITSValue());

		/// <summary>﻿set of limits used to trigger warning or alarm indicators.<br /><br /><br />
		/// Value for EventEnum.<br/>
		/// <br/>See also <seealso cref="EventEnum">EventEnum</seealso>
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
			public string Summary => @"&#10;&#10;&#10;set of limits used to trigger warning or alarm indicators.&#10;
";
		}
		private TOOL_CUTTING_ITEMValue _TOOL_CUTTING_ITEM;
		/// <inheritdoc cref="TOOL_CUTTING_ITEMValue" path="/summary" />
		public TOOL_CUTTING_ITEMValue TOOL_CUTTING_ITEM => _TOOL_CUTTING_ITEM ?? (_TOOL_CUTTING_ITEM = new TOOL_CUTTING_ITEMValue());

		/// <summary>﻿references the <see cref="CuttingToolLifeCycle">CuttingToolLifeCycle</see> <see cref="CuttingItem">CuttingItem</see> index related to the <see cref="CuttingItem.indices">indices in CuttingItem</see> of the currently active cutting tool edge.<br /><br /><br />
		/// Value for EventEnum.<br/>
		/// <br/>See also <seealso cref="EventEnum">EventEnum</seealso>
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
			public string Summary => @"&#10;&#10;&#10;references the {{block(CuttingToolLifeCycle)}} {{block(CuttingItem)}} index related to the {{property(CuttingItem::indices)}} of the currently active cutting tool edge.&#10;
";
		}
		private LOCATION_ADDRESSValue _LOCATION_ADDRESS;
		/// <inheritdoc cref="LOCATION_ADDRESSValue" path="/summary" />
		public LOCATION_ADDRESSValue LOCATION_ADDRESS => _LOCATION_ADDRESS ?? (_LOCATION_ADDRESS = new LOCATION_ADDRESSValue());

		/// <summary>﻿structured information that allows the unambiguous determination of an object for purposes of identification and location. <seealso href="https://www.google.com/search?q=ISO 19160-4:2017&btnI=I">ISO 19160-4:2017</seealso><br /><br /><br />
		/// Value for EventEnum.<br/>
		/// <br/>See also <seealso cref="EventEnum">EventEnum</seealso>
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
			public string Summary => @"&#10;&#10;&#10;structured information that allows the unambiguous determination of an object for purposes of identification and location. {{cite(ISO 19160-4:2017)}}&#10;
";
		}
		private POWER_SOURCEValue _POWER_SOURCE;
		/// <inheritdoc cref="POWER_SOURCEValue" path="/summary" />
		public POWER_SOURCEValue POWER_SOURCE => _POWER_SOURCE ?? (_POWER_SOURCE = new POWER_SOURCEValue());

		/// <summary>﻿active energy source for the <see cref="Component">Component</see>.<br /><br /><br />
		/// Value for EventEnum.<br/>
		/// <br/>See also <seealso cref="EventEnum">EventEnum</seealso>
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
			public string Summary => @"&#10;&#10;&#10;active energy source for the {{block(Component)}}.&#10;
";
		}
	}
}