#pragma warning disable CS1574 // XML comment has cref attribute that could not be resolved
#pragma warning disable CS1584 // XML comment has syntactically incorrect cref attribute
#pragma warning disable CS0618 // Type or member is obsolete
using System;
using System.CodeDom.Compiler;using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;

namespace Mtconnect.DataTypes
{
	/// <summary>﻿
	/// <br/> Visit <seealso href="https://model.mtconnect.org/#Enumeration___19_0_3_45f01b9_1579563592155_977172_22064">model.mtconnect.org</seealso> for more information.
	/// </summary>
	/// <remarks>
	/// <list type="bullet">
	/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
	/// </list>
	/// </remarks>

	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public enum DataItemSubTypeEnum
	{
		/// <summary>﻿relating to or derived in the simplest manner from the fundamental units or measurements.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		ABSOLUTE,
		/// <summary>﻿indication of the operating state of a mechanism.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		ACTION,
		/// <summary>﻿measured or reported value of an <i>observation</i>.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		ACTUAL,
		/// <summary>﻿all actions, items, or activities being counted independent of the outcome.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		ALL,
		/// <summary>﻿measurement of alternating voltage or current. If not specified further in statistic, defaults to RMS voltage. <br /><br /><b>DEPRECATED</b> in <i>Version 1.6</i>.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		ALTERNATING,
		/// <summary>﻿A-Scale weighting factor on the frequency scale.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		A_SCALE,
		/// <summary>﻿when multiple locations on a piece of bar stock being feed by a bar feeder are referenced as the indication of whether the end of that piece of bar stock has been reached.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		AUXILIARY,
		/// <summary>﻿actions, items, or activities being counted that do not conform to specification or expectation.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		BAD,
		/// <summary>﻿scale to measure the resistance to deformation of a surface.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		BRINELL,
		/// <summary>﻿B-Scale weighting factor on the frequency scale.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		B_SCALE,
		/// <summary>﻿directive value including adjustments such as an offset or overrides.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		COMMANDED,
		/// <summary>﻿amount of material consumed from an object or container during a manufacturing process.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		CONSUMED,
		/// <summary>﻿state of the enabling signal or control logic that enables or disables the function or operation of the entity.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		CONTROL,
		/// <summary>﻿C-Scale weighting factor on the frequency scale.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		C_SCALE,
		/// <summary>﻿elapsed time of a temporary halt of action.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		DELAY,
		/// <summary>﻿DC current or voltage.<br /><br /><b>DEPRECATED</b> in <i>Version 1.6</i>.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		DIRECT,
		/// <summary>﻿setting or operator selection used to execute a test mode to confirm the execution of machine functions.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		DRY_RUN,
		/// <summary>﻿D-Scale weighting factor on the frequency scale.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		D_SCALE,
		/// <summary>﻿relating to the expiration or end of useful life for a material or other physical item.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		EXPIRATION,
		/// <summary>﻿relating to the first use of a material or other physical item.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		FIRST_USE,
		/// <summary>﻿actions, items, or activities being counted that conform to specification or expectation.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		GOOD,
		/// <summary>﻿relating to or derived from the last <i>observation</i>.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		INCREMENTAL,
		/// <summary>﻿relating to momentary activation of a function or a movement.<br /><br /><b>DEPRECATION WARNING</b>: May be deprecated in the future.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		JOG,
		/// <summary>﻿indication of the position of a mechanism that may move in a lateral direction.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		LATERAL,
		/// <summary>﻿scale to measure the elasticity of a surface.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		LEEB,
		/// <summary>﻿reference to a length type tool offset variable.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		LENGTH,
		/// <summary>﻿state of the power source.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		LINE,
		/// <summary>﻿direction of motion of a linear motion.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		LINEAR,
		/// <summary>﻿indication that the subparts of a piece of equipment are under load.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		LOADED,
		/// <summary>﻿setting or operator selection that changes the behavior of the controller on a piece of equipment.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		MACHINE_AXIS_LOCK,
		/// <summary>﻿relating to the primary logic or motion program currently being executed.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		MAIN,
		/// <summary>﻿relating to maintenance on the piece of equipment.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		MAINTENANCE,
		/// <summary>﻿indication of the state of an operator controlled interlock that can inhibit the ability to initiate an unclamp action of an electronically controlled chuck.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		MANUAL_UNCLAMP,
		/// <summary>﻿related to the production of a material or other physical item.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		MANUFACTURE,
		/// <summary>﻿maximum value.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		MAXIMUM,
		/// <summary>﻿minimum value.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		MINIMUM,
		/// <summary>﻿scale to measure the resistance to scratching of a surface.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		MOHS,
		/// <summary>﻿indication of the open or closed state of a mechanism.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		MOTION,
		/// <summary>﻿no weighting factor on the frequency scale.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		NO_SCALE,
		/// <summary>﻿piece of equipment that is powered or performing any activity.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		OPERATING,
		/// <summary>﻿relating to the person currently responsible for operating the piece of equipment.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		OPERATOR,
		/// <summary>﻿setting or operator selection that changes the behavior of the controller on a piece of equipment. <br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		OPTIONAL_STOP,
		/// <summary>﻿overridden value.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		OVERRIDE,
		/// <summary>﻿piece of equipment is powered and functioning or <see cref="Component">Component</see> that are required to remain on are powered.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		POWERED,
		/// <summary>﻿main or most important.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		PRIMARY,
		/// <summary>﻿position provided by a measurement probe.<br /><br /><b>DEPRECATION WARNING</b>: May be deprecated in the future.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		PROBE,
		/// <summary>﻿relating to production of a part or product on a piece of equipment.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		PROCESS,
		/// <summary>﻿directive value without offsets and adjustments.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		PROGRAMMED,
		/// <summary>﻿reference to a radial type tool offset variable.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		RADIAL,
		/// <summary>﻿performing an operation faster or in less time than nominal rate.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		RAPID,
		/// <summary>﻿remaining measure or count of an action, object or activity.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		REMAINING,
		/// <summary>﻿scale to measure the resistance to deformation of a surface.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		ROCKWELL,
		/// <summary>﻿direction of a rotary motion using the right hand rule convention.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		ROTARY,
		/// <summary>﻿identity of a control program that is used to specify the order of execution of other programs.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		SCHEDULE,
		/// <summary>﻿relating to the preparation of a piece of equipment for production or restoring the piece of equipment to a neutral state after production.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		SET_UP,
		/// <summary>﻿scale to measure the resistance to deformation of a surface.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		SHORE,
		/// <summary>﻿setting or operator selection that changes the behavior of the controller on a piece of equipment. <br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		SINGLE_BLOCK,
		/// <summary>﻿standard measure of an object or an action.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		STANDARD,
		/// <summary>﻿boundary when an activity or an event commences.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		START,
		/// <summary>﻿indication of the activation state of a mechanism represented by a <see cref="Composition">Composition</see>.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		SWITCHED,
		/// <summary>﻿goal of the operation or process.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		TARGET,
		/// <summary>﻿relating to the end or completion of an activity or event.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		TARGET_COMPLETION,
		/// <summary>﻿setting or operator selection that changes the behavior of the controller on a piece of equipment.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		TOOL_CHANGE_STOP,
		/// <summary>﻿remaining usable measure of an object or action.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		USEABLE,
		/// <summary>﻿indication of the position of a mechanism that may move in a vertical direction.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		VERTICAL,
		/// <summary>﻿scale to measure the resistance to deformation of a surface.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		VICKERS,
		/// <summary>﻿piece of equipment performing any activity, the equipment is active and performing a function under load or not.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		WORKING,
		/// <summary>﻿IPV4 network address of the <see cref="Component">Component</see>.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		IPV4_ADDRESS,
		/// <summary>﻿IPV6 network address of the <see cref="Component">Component</see>.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		IPV6_ADDRESS,
		/// <summary>﻿Gateway for the <see cref="Component">Component</see> network.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		GATEWAY,
		/// <summary>﻿SubNet mask for the <see cref="Component">Component</see> network.<br /><br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		SUBNET_MASK,
		/// <summary>﻿layer2 Virtual Local Network (VLAN) ID for the <see cref="Component">Component</see> network.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		VLAN_ID,
		/// <summary>﻿Media Access Control Address. The unique physical address of the network hardware.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		MAC_ADDRESS,
		/// <summary>﻿identifies whether the connection type is wireless.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		WIRELESS,
		/// <summary>﻿license code to validate or activate the hardware or software.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		LICENSE,
		/// <summary>﻿version of the hardware or software.<br /><br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		VERSION,
		/// <summary>﻿date the hardware or software was released for general use.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		RELEASE_DATE,
		/// <summary>﻿date the hardware or software was installed.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		INSTALL_DATE,
		/// <summary>﻿corporate identity for the maker of the hardware or software.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		MANUFACTURER,
		/// <summary>﻿universally unique identifier as specified in ISO 11578 or RFC 4122.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		UUID,
		/// <summary>﻿serial number that uniquely identifies a specific part.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		SERIAL_NUMBER,
		/// <summary>﻿material that is used to produce parts.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		RAW_MATERIAL,
		/// <summary>﻿group of parts tracked as a lot.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		LOT,
		/// <summary>﻿group of parts produced in a batch.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		BATCH,
		/// <summary>﻿material heat number.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		HEAT_TREAT,
		/// <summary>﻿particular part design or model.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		PART_NUMBER,
		/// <summary>﻿group of parts having similarities in geometry, manufacturing process, and/or functions.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		PART_FAMILY,
		/// <summary>﻿word or set of words by which a part is known, addressed, or referred to.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		PART_NAME,
		/// <summary>﻿step in the process plan that this occurrence corresponds to. <br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		PROCESS_STEP,
		/// <summary>﻿process plan that a process occurrence belongs to.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		PROCESS_PLAN,
		/// <summary>﻿authorization of a process occurrence.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		ORDER_NUMBER,
		/// <summary>﻿word or set of words by which a process being executed (process occurrence) by the device is known, addressed, or referred to.<br /><br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		PROCESS_NAME,
		/// <summary>﻿reference to a ISO 10303 Executable.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		ISO_STEP_EXECUTABLE,
		/// <summary>﻿associated with the completion of an activity or event.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		COMPLETE,
		/// <summary>﻿relating to logic or motion program currently executing.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		ACTIVE,
		/// <summary>﻿actions or activities that were attempted , but failed to complete or resulted in an unexpected or unacceptable outcome.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		FAILED,
		/// <summary>﻿actions or activities that were attempted, but terminated before they could be completed.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		ABORTED,
		/// <summary>﻿boundary when an activity or an event terminates.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		ENDED,
		/// <summary>﻿amount discarded.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		WASTE,
		/// <summary>﻿amount included in the <i>part</i>.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		PART,
		/// <summary>﻿<i>request</i> by an <see cref="Interface">Interface</see> for a task.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		REQUEST,
		/// <summary>﻿<i>response</i> by an <see cref="Interface">Interface</see> to a <i>request</i> for a task.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		RESPONSE,
		/// <summary>﻿phase or segment of a recipe or program.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		ACTIVITY,
		/// <summary>﻿phase of a recipe process.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		SEGMENT,
		/// <summary>﻿process as part of product production; can be a subprocess of a larger process.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		RECIPE,
		/// <summary>﻿step of a discrete manufacturing process.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		OPERATION,
		/// <summary>﻿observed as a binary data type.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		BINARY,
		/// <summary>﻿observed as a boolean data type.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		BOOLEAN,
		/// <summary>﻿observed as a set containing a restricted number of discrete values where each discrete value is named and unique.<br /><seealso href="https://www.google.com/search?q=ISO 21961:2003, 013&amp;btnI=I">ISO 21961:2003, 013</seealso><br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		ENUMERATED,
		/// <summary>﻿indicated by the presence or existence of something.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		DETECT,
		/// <summary>﻿model info of the hardware or software.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		MODEL,
		/// <summary>﻿alternate or not primary.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		SECONDARY,
		/// <summary>﻿held near at hand and ready for use.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		STANDBY,
	}

	/// <summary>﻿
	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Enumeration___19_0_3_45f01b9_1579563592155_977172_22064">model.mtconnect.org</seealso> for more information.
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public sealed class DataItemSubTypeEnumMetaClass : IEnum
	{
		/// <summary>Constant value for <see cref="DataItemSubTypeEnumMetaClass.ReferenceId" /></summary>
		public const string REFERENCE_ID = "_19_0_3_45f01b9_1579563592155_977172_22064";
		/// <summary>Constant value for <see cref="DataItemSubTypeEnumMetaClass.HelpUrl" /></summary>
		public const string HELP_URL = "https://model.mtconnect.org/#Enumeration___19_0_3_45f01b9_1579563592155_977172_22064";
		/// <summary>Constant value for <see cref="DataItemSubTypeEnumMetaClass.Name" /></summary>
		public const string NAME = "DataItemSubTypeEnum";
		/// <summary>Constant value for <see cref="DataItemSubTypeEnumMetaClass.NormativeVersion" /></summary>
		public const string NORMATIVE_VERSION = "1.0";
		/// <summary>Constant value for <see cref="DataItemSubTypeEnumMetaClass.DeprecatedVersion" /></summary>
		public const string DEPRECATED_VERSION = "";
		/// <summary>Constant value for <see cref="DataItemSubTypeEnumMetaClass.Summary" /></summary>
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
		public Type Instance => typeof(DataItemSubTypeEnum);

		/// <inheritdoc />
		public string NormativeVersion => NORMATIVE_VERSION;
		
		/// <inheritdoc />
		public string DeprecatedVersion => DEPRECATED_VERSION;
		
		/// <inheritdoc />
		public string Summary => SUMMARY;
		
		/// <inheritdoc />
		public IEnumInstance[] Values => new IEnumInstance[] {
		ABSOLUTE,
		ACTION,
		ACTUAL,
		ALL,
		ALTERNATING,
		A_SCALE,
		AUXILIARY,
		BAD,
		BRINELL,
		B_SCALE,
		COMMANDED,
		CONSUMED,
		CONTROL,
		C_SCALE,
		DELAY,
		DIRECT,
		DRY_RUN,
		D_SCALE,
		EXPIRATION,
		FIRST_USE,
		GOOD,
		INCREMENTAL,
		JOG,
		LATERAL,
		LEEB,
		LENGTH,
		LINE,
		LINEAR,
		LOADED,
		MACHINE_AXIS_LOCK,
		MAIN,
		MAINTENANCE,
		MANUAL_UNCLAMP,
		MANUFACTURE,
		MAXIMUM,
		MINIMUM,
		MOHS,
		MOTION,
		NO_SCALE,
		OPERATING,
		OPERATOR,
		OPTIONAL_STOP,
		OVERRIDE,
		POWERED,
		PRIMARY,
		PROBE,
		PROCESS,
		PROGRAMMED,
		RADIAL,
		RAPID,
		REMAINING,
		ROCKWELL,
		ROTARY,
		SCHEDULE,
		SET_UP,
		SHORE,
		SINGLE_BLOCK,
		STANDARD,
		START,
		SWITCHED,
		TARGET,
		TARGET_COMPLETION,
		TOOL_CHANGE_STOP,
		USEABLE,
		VERTICAL,
		VICKERS,
		WORKING,
		IPV4_ADDRESS,
		IPV6_ADDRESS,
		GATEWAY,
		SUBNET_MASK,
		VLAN_ID,
		MAC_ADDRESS,
		WIRELESS,
		LICENSE,
		VERSION,
		RELEASE_DATE,
		INSTALL_DATE,
		MANUFACTURER,
		UUID,
		SERIAL_NUMBER,
		RAW_MATERIAL,
		LOT,
		BATCH,
		HEAT_TREAT,
		PART_NUMBER,
		PART_FAMILY,
		PART_NAME,
		PROCESS_STEP,
		PROCESS_PLAN,
		ORDER_NUMBER,
		PROCESS_NAME,
		ISO_STEP_EXECUTABLE,
		COMPLETE,
		ACTIVE,
		FAILED,
		ABORTED,
		ENDED,
		WASTE,
		PART,
		REQUEST,
		RESPONSE,
		ACTIVITY,
		SEGMENT,
		RECIPE,
		OPERATION,
		BINARY,
		BOOLEAN,
		ENUMERATED,
		DETECT,
		MODEL,
		SECONDARY,
		STANDBY,
		};

		private ABSOLUTEValue _ABSOLUTE;
		/// <inheritdoc cref="ABSOLUTEValue" path="/summary" />
		public ABSOLUTEValue ABSOLUTE => _ABSOLUTE ?? (_ABSOLUTE = new ABSOLUTEValue());

		/// <summary>﻿relating to or derived in the simplest manner from the fundamental units or measurements.<br /><br /><br />
		/// Value for DataItemSubTypeEnum.<br/>
		/// <br/>See also <seealso cref="DataItemSubTypeEnum">DataItemSubTypeEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		public sealed class ABSOLUTEValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="ABSOLUTEValue.Name" /></summary>
			public const string NAME = "ABSOLUTE";
			/// <summary>Constant value for <see cref="ABSOLUTEValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.4";
			/// <summary>Constant value for <see cref="ABSOLUTEValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="ABSOLUTEValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;relating to or derived in the simplest manner from the fundamental units or measurements.&#10;
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
		private ACTIONValue _ACTION;
		/// <inheritdoc cref="ACTIONValue" path="/summary" />
		public ACTIONValue ACTION => _ACTION ?? (_ACTION = new ACTIONValue());

		/// <summary>﻿indication of the operating state of a mechanism.<br /><br /><br />
		/// Value for DataItemSubTypeEnum.<br/>
		/// <br/>See also <seealso cref="DataItemSubTypeEnum">DataItemSubTypeEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		public sealed class ACTIONValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="ACTIONValue.Name" /></summary>
			public const string NAME = "ACTION";
			/// <summary>Constant value for <see cref="ACTIONValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.4";
			/// <summary>Constant value for <see cref="ACTIONValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="ACTIONValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;indication of the operating state of a mechanism.&#10;
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
		private ACTUALValue _ACTUAL;
		/// <inheritdoc cref="ACTUALValue" path="/summary" />
		public ACTUALValue ACTUAL => _ACTUAL ?? (_ACTUAL = new ACTUALValue());

		/// <summary>﻿measured or reported value of an <i>observation</i>.<br /><br /><br />
		/// Value for DataItemSubTypeEnum.<br/>
		/// <br/>See also <seealso cref="DataItemSubTypeEnum">DataItemSubTypeEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		public sealed class ACTUALValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="ACTUALValue.Name" /></summary>
			public const string NAME = "ACTUAL";
			/// <summary>Constant value for <see cref="ACTUALValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.0";
			/// <summary>Constant value for <see cref="ACTUALValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="ACTUALValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;measured or reported value of an {{term(observation)}}.&#10;
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
		private ALLValue _ALL;
		/// <inheritdoc cref="ALLValue" path="/summary" />
		public ALLValue ALL => _ALL ?? (_ALL = new ALLValue());

		/// <summary>﻿all actions, items, or activities being counted independent of the outcome.<br /><br /><br />
		/// Value for DataItemSubTypeEnum.<br/>
		/// <br/>See also <seealso cref="DataItemSubTypeEnum">DataItemSubTypeEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		public sealed class ALLValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="ALLValue.Name" /></summary>
			public const string NAME = "ALL";
			/// <summary>Constant value for <see cref="ALLValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.0";
			/// <summary>Constant value for <see cref="ALLValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="ALLValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;all actions, items, or activities being counted independent of the outcome.&#10;
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
		private ALTERNATINGValue _ALTERNATING;
		/// <inheritdoc cref="ALTERNATINGValue" path="/summary" />
		public ALTERNATINGValue ALTERNATING => _ALTERNATING ?? (_ALTERNATING = new ALTERNATINGValue());

		/// <summary>﻿measurement of alternating voltage or current. If not specified further in statistic, defaults to RMS voltage. <br /><br /><b>DEPRECATED</b> in <i>Version 1.6</i>.<br /><br /><br />
		/// Value for DataItemSubTypeEnum.<br/>
		/// <br/>See also <seealso cref="DataItemSubTypeEnum">DataItemSubTypeEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		public sealed class ALTERNATINGValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="ALTERNATINGValue.Name" /></summary>
			public const string NAME = "ALTERNATING";
			/// <summary>Constant value for <see cref="ALTERNATINGValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.2";
			/// <summary>Constant value for <see cref="ALTERNATINGValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "1.6";
			/// <summary>Constant value for <see cref="ALTERNATINGValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;measurement of alternating voltage or current. If not specified further in statistic, defaults to RMS voltage. 

**DEPRECATED** in *Version 1.6*.&#10;
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
		private A_SCALEValue _A_SCALE;
		/// <inheritdoc cref="A_SCALEValue" path="/summary" />
		public A_SCALEValue A_SCALE => _A_SCALE ?? (_A_SCALE = new A_SCALEValue());

		/// <summary>﻿A-Scale weighting factor on the frequency scale.<br /><br /><br />
		/// Value for DataItemSubTypeEnum.<br/>
		/// <br/>See also <seealso cref="DataItemSubTypeEnum">DataItemSubTypeEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		public sealed class A_SCALEValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="A_SCALEValue.Name" /></summary>
			public const string NAME = "A_SCALE";
			/// <summary>Constant value for <see cref="A_SCALEValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.2";
			/// <summary>Constant value for <see cref="A_SCALEValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="A_SCALEValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;A-Scale weighting factor on the frequency scale.&#10;
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
		private AUXILIARYValue _AUXILIARY;
		/// <inheritdoc cref="AUXILIARYValue" path="/summary" />
		public AUXILIARYValue AUXILIARY => _AUXILIARY ?? (_AUXILIARY = new AUXILIARYValue());

		/// <summary>﻿when multiple locations on a piece of bar stock being feed by a bar feeder are referenced as the indication of whether the end of that piece of bar stock has been reached.<br /><br /><br />
		/// Value for DataItemSubTypeEnum.<br/>
		/// <br/>See also <seealso cref="DataItemSubTypeEnum">DataItemSubTypeEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		public sealed class AUXILIARYValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="AUXILIARYValue.Name" /></summary>
			public const string NAME = "AUXILIARY";
			/// <summary>Constant value for <see cref="AUXILIARYValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.3";
			/// <summary>Constant value for <see cref="AUXILIARYValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="AUXILIARYValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;when multiple locations on a piece of bar stock being feed by a bar feeder are referenced as the indication of whether the end of that piece of bar stock has been reached.&#10;
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
		private BADValue _BAD;
		/// <inheritdoc cref="BADValue" path="/summary" />
		public BADValue BAD => _BAD ?? (_BAD = new BADValue());

		/// <summary>﻿actions, items, or activities being counted that do not conform to specification or expectation.<br /><br /><br />
		/// Value for DataItemSubTypeEnum.<br/>
		/// <br/>See also <seealso cref="DataItemSubTypeEnum">DataItemSubTypeEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		public sealed class BADValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="BADValue.Name" /></summary>
			public const string NAME = "BAD";
			/// <summary>Constant value for <see cref="BADValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.0";
			/// <summary>Constant value for <see cref="BADValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="BADValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;actions, items, or activities being counted that do not conform to specification or expectation.&#10;
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
		private BRINELLValue _BRINELL;
		/// <inheritdoc cref="BRINELLValue" path="/summary" />
		public BRINELLValue BRINELL => _BRINELL ?? (_BRINELL = new BRINELLValue());

		/// <summary>﻿scale to measure the resistance to deformation of a surface.<br /><br /><br />
		/// Value for DataItemSubTypeEnum.<br/>
		/// <br/>See also <seealso cref="DataItemSubTypeEnum">DataItemSubTypeEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		public sealed class BRINELLValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="BRINELLValue.Name" /></summary>
			public const string NAME = "BRINELL";
			/// <summary>Constant value for <see cref="BRINELLValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.4";
			/// <summary>Constant value for <see cref="BRINELLValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="BRINELLValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;scale to measure the resistance to deformation of a surface.&#10;
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
		private B_SCALEValue _B_SCALE;
		/// <inheritdoc cref="B_SCALEValue" path="/summary" />
		public B_SCALEValue B_SCALE => _B_SCALE ?? (_B_SCALE = new B_SCALEValue());

		/// <summary>﻿B-Scale weighting factor on the frequency scale.<br /><br /><br />
		/// Value for DataItemSubTypeEnum.<br/>
		/// <br/>See also <seealso cref="DataItemSubTypeEnum">DataItemSubTypeEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		public sealed class B_SCALEValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="B_SCALEValue.Name" /></summary>
			public const string NAME = "B_SCALE";
			/// <summary>Constant value for <see cref="B_SCALEValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.2";
			/// <summary>Constant value for <see cref="B_SCALEValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="B_SCALEValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;B-Scale weighting factor on the frequency scale.&#10;
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
		private COMMANDEDValue _COMMANDED;
		/// <inheritdoc cref="COMMANDEDValue" path="/summary" />
		public COMMANDEDValue COMMANDED => _COMMANDED ?? (_COMMANDED = new COMMANDEDValue());

		/// <summary>﻿directive value including adjustments such as an offset or overrides.<br /><br /><br />
		/// Value for DataItemSubTypeEnum.<br/>
		/// <br/>See also <seealso cref="DataItemSubTypeEnum">DataItemSubTypeEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		public sealed class COMMANDEDValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="COMMANDEDValue.Name" /></summary>
			public const string NAME = "COMMANDED";
			/// <summary>Constant value for <see cref="COMMANDEDValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.0";
			/// <summary>Constant value for <see cref="COMMANDEDValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="COMMANDEDValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;directive value including adjustments such as an offset or overrides.&#10;
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
		private CONSUMEDValue _CONSUMED;
		/// <inheritdoc cref="CONSUMEDValue" path="/summary" />
		public CONSUMEDValue CONSUMED => _CONSUMED ?? (_CONSUMED = new CONSUMEDValue());

		/// <summary>﻿amount of material consumed from an object or container during a manufacturing process.<br /><br /><br />
		/// Value for DataItemSubTypeEnum.<br/>
		/// <br/>See also <seealso cref="DataItemSubTypeEnum">DataItemSubTypeEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		public sealed class CONSUMEDValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="CONSUMEDValue.Name" /></summary>
			public const string NAME = "CONSUMED";
			/// <summary>Constant value for <see cref="CONSUMEDValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.5";
			/// <summary>Constant value for <see cref="CONSUMEDValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="CONSUMEDValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;amount of material consumed from an object or container during a manufacturing process.&#10;
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
		private CONTROLValue _CONTROL;
		/// <inheritdoc cref="CONTROLValue" path="/summary" />
		public CONTROLValue CONTROL => _CONTROL ?? (_CONTROL = new CONTROLValue());

		/// <summary>﻿state of the enabling signal or control logic that enables or disables the function or operation of the entity.<br /><br /><br />
		/// Value for DataItemSubTypeEnum.<br/>
		/// <br/>See also <seealso cref="DataItemSubTypeEnum">DataItemSubTypeEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		public sealed class CONTROLValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="CONTROLValue.Name" /></summary>
			public const string NAME = "CONTROL";
			/// <summary>Constant value for <see cref="CONTROLValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.1";
			/// <summary>Constant value for <see cref="CONTROLValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="CONTROLValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;state of the enabling signal or control logic that enables or disables the function or operation of the entity.&#10;
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
		private C_SCALEValue _C_SCALE;
		/// <inheritdoc cref="C_SCALEValue" path="/summary" />
		public C_SCALEValue C_SCALE => _C_SCALE ?? (_C_SCALE = new C_SCALEValue());

		/// <summary>﻿C-Scale weighting factor on the frequency scale.<br /><br /><br />
		/// Value for DataItemSubTypeEnum.<br/>
		/// <br/>See also <seealso cref="DataItemSubTypeEnum">DataItemSubTypeEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		public sealed class C_SCALEValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="C_SCALEValue.Name" /></summary>
			public const string NAME = "C_SCALE";
			/// <summary>Constant value for <see cref="C_SCALEValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.2";
			/// <summary>Constant value for <see cref="C_SCALEValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="C_SCALEValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;C-Scale weighting factor on the frequency scale.&#10;
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
		private DELAYValue _DELAY;
		/// <inheritdoc cref="DELAYValue" path="/summary" />
		public DELAYValue DELAY => _DELAY ?? (_DELAY = new DELAYValue());

		/// <summary>﻿elapsed time of a temporary halt of action.<br /><br /><br />
		/// Value for DataItemSubTypeEnum.<br/>
		/// <br/>See also <seealso cref="DataItemSubTypeEnum">DataItemSubTypeEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		public sealed class DELAYValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="DELAYValue.Name" /></summary>
			public const string NAME = "DELAY";
			/// <summary>Constant value for <see cref="DELAYValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.4";
			/// <summary>Constant value for <see cref="DELAYValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="DELAYValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;elapsed time of a temporary halt of action.&#10;
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
		private DIRECTValue _DIRECT;
		/// <inheritdoc cref="DIRECTValue" path="/summary" />
		public DIRECTValue DIRECT => _DIRECT ?? (_DIRECT = new DIRECTValue());

		/// <summary>﻿DC current or voltage.<br /><br /><b>DEPRECATED</b> in <i>Version 1.6</i>.<br /><br /><br />
		/// Value for DataItemSubTypeEnum.<br/>
		/// <br/>See also <seealso cref="DataItemSubTypeEnum">DataItemSubTypeEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		public sealed class DIRECTValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="DIRECTValue.Name" /></summary>
			public const string NAME = "DIRECT";
			/// <summary>Constant value for <see cref="DIRECTValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.2";
			/// <summary>Constant value for <see cref="DIRECTValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "1.6";
			/// <summary>Constant value for <see cref="DIRECTValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;DC current or voltage.

**DEPRECATED** in *Version 1.6*.&#10;
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
		private DRY_RUNValue _DRY_RUN;
		/// <inheritdoc cref="DRY_RUNValue" path="/summary" />
		public DRY_RUNValue DRY_RUN => _DRY_RUN ?? (_DRY_RUN = new DRY_RUNValue());

		/// <summary>﻿setting or operator selection used to execute a test mode to confirm the execution of machine functions.<br /><br /><br />
		/// Value for DataItemSubTypeEnum.<br/>
		/// <br/>See also <seealso cref="DataItemSubTypeEnum">DataItemSubTypeEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		public sealed class DRY_RUNValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="DRY_RUNValue.Name" /></summary>
			public const string NAME = "DRY_RUN";
			/// <summary>Constant value for <see cref="DRY_RUNValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.4";
			/// <summary>Constant value for <see cref="DRY_RUNValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="DRY_RUNValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;setting or operator selection used to execute a test mode to confirm the execution of machine functions.&#10;
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
		private D_SCALEValue _D_SCALE;
		/// <inheritdoc cref="D_SCALEValue" path="/summary" />
		public D_SCALEValue D_SCALE => _D_SCALE ?? (_D_SCALE = new D_SCALEValue());

		/// <summary>﻿D-Scale weighting factor on the frequency scale.<br /><br /><br />
		/// Value for DataItemSubTypeEnum.<br/>
		/// <br/>See also <seealso cref="DataItemSubTypeEnum">DataItemSubTypeEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		public sealed class D_SCALEValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="D_SCALEValue.Name" /></summary>
			public const string NAME = "D_SCALE";
			/// <summary>Constant value for <see cref="D_SCALEValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.2";
			/// <summary>Constant value for <see cref="D_SCALEValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="D_SCALEValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;D-Scale weighting factor on the frequency scale.&#10;
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
		private EXPIRATIONValue _EXPIRATION;
		/// <inheritdoc cref="EXPIRATIONValue" path="/summary" />
		public EXPIRATIONValue EXPIRATION => _EXPIRATION ?? (_EXPIRATION = new EXPIRATIONValue());

		/// <summary>﻿relating to the expiration or end of useful life for a material or other physical item.<br /><br /><br />
		/// Value for DataItemSubTypeEnum.<br/>
		/// <br/>See also <seealso cref="DataItemSubTypeEnum">DataItemSubTypeEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		public sealed class EXPIRATIONValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="EXPIRATIONValue.Name" /></summary>
			public const string NAME = "EXPIRATION";
			/// <summary>Constant value for <see cref="EXPIRATIONValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.5";
			/// <summary>Constant value for <see cref="EXPIRATIONValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="EXPIRATIONValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;relating to the expiration or end of useful life for a material or other physical item.&#10;
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
		private FIRST_USEValue _FIRST_USE;
		/// <inheritdoc cref="FIRST_USEValue" path="/summary" />
		public FIRST_USEValue FIRST_USE => _FIRST_USE ?? (_FIRST_USE = new FIRST_USEValue());

		/// <summary>﻿relating to the first use of a material or other physical item.<br /><br /><br />
		/// Value for DataItemSubTypeEnum.<br/>
		/// <br/>See also <seealso cref="DataItemSubTypeEnum">DataItemSubTypeEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		public sealed class FIRST_USEValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="FIRST_USEValue.Name" /></summary>
			public const string NAME = "FIRST_USE";
			/// <summary>Constant value for <see cref="FIRST_USEValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.5";
			/// <summary>Constant value for <see cref="FIRST_USEValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="FIRST_USEValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;relating to the first use of a material or other physical item.&#10;
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
		private GOODValue _GOOD;
		/// <inheritdoc cref="GOODValue" path="/summary" />
		public GOODValue GOOD => _GOOD ?? (_GOOD = new GOODValue());

		/// <summary>﻿actions, items, or activities being counted that conform to specification or expectation.<br /><br /><br />
		/// Value for DataItemSubTypeEnum.<br/>
		/// <br/>See also <seealso cref="DataItemSubTypeEnum">DataItemSubTypeEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		public sealed class GOODValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="GOODValue.Name" /></summary>
			public const string NAME = "GOOD";
			/// <summary>Constant value for <see cref="GOODValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.0";
			/// <summary>Constant value for <see cref="GOODValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="GOODValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;actions, items, or activities being counted that conform to specification or expectation.&#10;
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
		private INCREMENTALValue _INCREMENTAL;
		/// <inheritdoc cref="INCREMENTALValue" path="/summary" />
		public INCREMENTALValue INCREMENTAL => _INCREMENTAL ?? (_INCREMENTAL = new INCREMENTALValue());

		/// <summary>﻿relating to or derived from the last <i>observation</i>.<br /><br /><br />
		/// Value for DataItemSubTypeEnum.<br/>
		/// <br/>See also <seealso cref="DataItemSubTypeEnum">DataItemSubTypeEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		public sealed class INCREMENTALValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="INCREMENTALValue.Name" /></summary>
			public const string NAME = "INCREMENTAL";
			/// <summary>Constant value for <see cref="INCREMENTALValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.4";
			/// <summary>Constant value for <see cref="INCREMENTALValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="INCREMENTALValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;relating to or derived from the last {{term(observation)}}.&#10;
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
		private JOGValue _JOG;
		/// <inheritdoc cref="JOGValue" path="/summary" />
		public JOGValue JOG => _JOG ?? (_JOG = new JOGValue());

		/// <summary>﻿relating to momentary activation of a function or a movement.<br /><br /><b>DEPRECATION WARNING</b>: May be deprecated in the future.<br /><br /><br />
		/// Value for DataItemSubTypeEnum.<br/>
		/// <br/>See also <seealso cref="DataItemSubTypeEnum">DataItemSubTypeEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		public sealed class JOGValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="JOGValue.Name" /></summary>
			public const string NAME = "JOG";
			/// <summary>Constant value for <see cref="JOGValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.3";
			/// <summary>Constant value for <see cref="JOGValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="JOGValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;relating to momentary activation of a function or a movement.

**DEPRECATION WARNING**: May be deprecated in the future.&#10;
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
		private LATERALValue _LATERAL;
		/// <inheritdoc cref="LATERALValue" path="/summary" />
		public LATERALValue LATERAL => _LATERAL ?? (_LATERAL = new LATERALValue());

		/// <summary>﻿indication of the position of a mechanism that may move in a lateral direction.<br /><br /><br />
		/// Value for DataItemSubTypeEnum.<br/>
		/// <br/>See also <seealso cref="DataItemSubTypeEnum">DataItemSubTypeEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		public sealed class LATERALValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="LATERALValue.Name" /></summary>
			public const string NAME = "LATERAL";
			/// <summary>Constant value for <see cref="LATERALValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.4";
			/// <summary>Constant value for <see cref="LATERALValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="LATERALValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;indication of the position of a mechanism that may move in a lateral direction.&#10;
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
		private LEEBValue _LEEB;
		/// <inheritdoc cref="LEEBValue" path="/summary" />
		public LEEBValue LEEB => _LEEB ?? (_LEEB = new LEEBValue());

		/// <summary>﻿scale to measure the elasticity of a surface.<br /><br /><br />
		/// Value for DataItemSubTypeEnum.<br/>
		/// <br/>See also <seealso cref="DataItemSubTypeEnum">DataItemSubTypeEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		public sealed class LEEBValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="LEEBValue.Name" /></summary>
			public const string NAME = "LEEB";
			/// <summary>Constant value for <see cref="LEEBValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.4";
			/// <summary>Constant value for <see cref="LEEBValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="LEEBValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;scale to measure the elasticity of a surface.&#10;
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
		private LENGTHValue _LENGTH;
		/// <inheritdoc cref="LENGTHValue" path="/summary" />
		public LENGTHValue LENGTH => _LENGTH ?? (_LENGTH = new LENGTHValue());

		/// <summary>﻿reference to a length type tool offset variable.<br /><br /><br />
		/// Value for DataItemSubTypeEnum.<br/>
		/// <br/>See also <seealso cref="DataItemSubTypeEnum">DataItemSubTypeEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		public sealed class LENGTHValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="LENGTHValue.Name" /></summary>
			public const string NAME = "LENGTH";
			/// <summary>Constant value for <see cref="LENGTHValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.4";
			/// <summary>Constant value for <see cref="LENGTHValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="LENGTHValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;reference to a length type tool offset variable.&#10;
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

		/// <summary>﻿state of the power source.<br /><br /><br />
		/// Value for DataItemSubTypeEnum.<br/>
		/// <br/>See also <seealso cref="DataItemSubTypeEnum">DataItemSubTypeEnum</seealso>
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
			public const string NORMATIVE_VERSION = "1.1";
			/// <summary>Constant value for <see cref="LINEValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="LINEValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;state of the power source.&#10;
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
		private LINEARValue _LINEAR;
		/// <inheritdoc cref="LINEARValue" path="/summary" />
		public LINEARValue LINEAR => _LINEAR ?? (_LINEAR = new LINEARValue());

		/// <summary>﻿direction of motion of a linear motion.<br /><br /><br />
		/// Value for DataItemSubTypeEnum.<br/>
		/// <br/>See also <seealso cref="DataItemSubTypeEnum">DataItemSubTypeEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		public sealed class LINEARValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="LINEARValue.Name" /></summary>
			public const string NAME = "LINEAR";
			/// <summary>Constant value for <see cref="LINEARValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.2";
			/// <summary>Constant value for <see cref="LINEARValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="LINEARValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;direction of motion of a linear motion.&#10;
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
		private LOADEDValue _LOADED;
		/// <inheritdoc cref="LOADEDValue" path="/summary" />
		public LOADEDValue LOADED => _LOADED ?? (_LOADED = new LOADEDValue());

		/// <summary>﻿indication that the subparts of a piece of equipment are under load.<br /><br /><br />
		/// Value for DataItemSubTypeEnum.<br/>
		/// <br/>See also <seealso cref="DataItemSubTypeEnum">DataItemSubTypeEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		public sealed class LOADEDValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="LOADEDValue.Name" /></summary>
			public const string NAME = "LOADED";
			/// <summary>Constant value for <see cref="LOADEDValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.4";
			/// <summary>Constant value for <see cref="LOADEDValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="LOADEDValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;indication that the subparts of a piece of equipment are under load.&#10;
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
		private MACHINE_AXIS_LOCKValue _MACHINE_AXIS_LOCK;
		/// <inheritdoc cref="MACHINE_AXIS_LOCKValue" path="/summary" />
		public MACHINE_AXIS_LOCKValue MACHINE_AXIS_LOCK => _MACHINE_AXIS_LOCK ?? (_MACHINE_AXIS_LOCK = new MACHINE_AXIS_LOCKValue());

		/// <summary>﻿setting or operator selection that changes the behavior of the controller on a piece of equipment.<br /><br /><br />
		/// Value for DataItemSubTypeEnum.<br/>
		/// <br/>See also <seealso cref="DataItemSubTypeEnum">DataItemSubTypeEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		public sealed class MACHINE_AXIS_LOCKValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="MACHINE_AXIS_LOCKValue.Name" /></summary>
			public const string NAME = "MACHINE_AXIS_LOCK";
			/// <summary>Constant value for <see cref="MACHINE_AXIS_LOCKValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.4";
			/// <summary>Constant value for <see cref="MACHINE_AXIS_LOCKValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="MACHINE_AXIS_LOCKValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;setting or operator selection that changes the behavior of the controller on a piece of equipment.&#10;
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
		private MAINValue _MAIN;
		/// <inheritdoc cref="MAINValue" path="/summary" />
		public MAINValue MAIN => _MAIN ?? (_MAIN = new MAINValue());

		/// <summary>﻿relating to the primary logic or motion program currently being executed.<br /><br /><br />
		/// Value for DataItemSubTypeEnum.<br/>
		/// <br/>See also <seealso cref="DataItemSubTypeEnum">DataItemSubTypeEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		public sealed class MAINValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="MAINValue.Name" /></summary>
			public const string NAME = "MAIN";
			/// <summary>Constant value for <see cref="MAINValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.5";
			/// <summary>Constant value for <see cref="MAINValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="MAINValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;relating to the primary logic or motion program currently being executed.&#10;
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
		private MAINTENANCEValue _MAINTENANCE;
		/// <inheritdoc cref="MAINTENANCEValue" path="/summary" />
		public MAINTENANCEValue MAINTENANCE => _MAINTENANCE ?? (_MAINTENANCE = new MAINTENANCEValue());

		/// <summary>﻿relating to maintenance on the piece of equipment.<br /><br /><br />
		/// Value for DataItemSubTypeEnum.<br/>
		/// <br/>See also <seealso cref="DataItemSubTypeEnum">DataItemSubTypeEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		public sealed class MAINTENANCEValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="MAINTENANCEValue.Name" /></summary>
			public const string NAME = "MAINTENANCE";
			/// <summary>Constant value for <see cref="MAINTENANCEValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.4";
			/// <summary>Constant value for <see cref="MAINTENANCEValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="MAINTENANCEValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;relating to maintenance on the piece of equipment.&#10;
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
		private MANUAL_UNCLAMPValue _MANUAL_UNCLAMP;
		/// <inheritdoc cref="MANUAL_UNCLAMPValue" path="/summary" />
		public MANUAL_UNCLAMPValue MANUAL_UNCLAMP => _MANUAL_UNCLAMP ?? (_MANUAL_UNCLAMP = new MANUAL_UNCLAMPValue());

		/// <summary>﻿indication of the state of an operator controlled interlock that can inhibit the ability to initiate an unclamp action of an electronically controlled chuck.<br /><br /><br />
		/// Value for DataItemSubTypeEnum.<br/>
		/// <br/>See also <seealso cref="DataItemSubTypeEnum">DataItemSubTypeEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		public sealed class MANUAL_UNCLAMPValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="MANUAL_UNCLAMPValue.Name" /></summary>
			public const string NAME = "MANUAL_UNCLAMP";
			/// <summary>Constant value for <see cref="MANUAL_UNCLAMPValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.3";
			/// <summary>Constant value for <see cref="MANUAL_UNCLAMPValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="MANUAL_UNCLAMPValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;indication of the state of an operator controlled interlock that can inhibit the ability to initiate an unclamp action of an electronically controlled chuck.&#10;
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
		private MANUFACTUREValue _MANUFACTURE;
		/// <inheritdoc cref="MANUFACTUREValue" path="/summary" />
		public MANUFACTUREValue MANUFACTURE => _MANUFACTURE ?? (_MANUFACTURE = new MANUFACTUREValue());

		/// <summary>﻿related to the production of a material or other physical item.<br /><br /><br />
		/// Value for DataItemSubTypeEnum.<br/>
		/// <br/>See also <seealso cref="DataItemSubTypeEnum">DataItemSubTypeEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		public sealed class MANUFACTUREValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="MANUFACTUREValue.Name" /></summary>
			public const string NAME = "MANUFACTURE";
			/// <summary>Constant value for <see cref="MANUFACTUREValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.5";
			/// <summary>Constant value for <see cref="MANUFACTUREValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="MANUFACTUREValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;related to the production of a material or other physical item.&#10;
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
		private MAXIMUMValue _MAXIMUM;
		/// <inheritdoc cref="MAXIMUMValue" path="/summary" />
		public MAXIMUMValue MAXIMUM => _MAXIMUM ?? (_MAXIMUM = new MAXIMUMValue());

		/// <summary>﻿maximum value.<br /><br /><br />
		/// Value for DataItemSubTypeEnum.<br/>
		/// <br/>See also <seealso cref="DataItemSubTypeEnum">DataItemSubTypeEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		public sealed class MAXIMUMValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="MAXIMUMValue.Name" /></summary>
			public const string NAME = "MAXIMUM";
			/// <summary>Constant value for <see cref="MAXIMUMValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.1";
			/// <summary>Constant value for <see cref="MAXIMUMValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="MAXIMUMValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;maximum value.&#10;
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
		private MINIMUMValue _MINIMUM;
		/// <inheritdoc cref="MINIMUMValue" path="/summary" />
		public MINIMUMValue MINIMUM => _MINIMUM ?? (_MINIMUM = new MINIMUMValue());

		/// <summary>﻿minimum value.<br /><br /><br />
		/// Value for DataItemSubTypeEnum.<br/>
		/// <br/>See also <seealso cref="DataItemSubTypeEnum">DataItemSubTypeEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		public sealed class MINIMUMValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="MINIMUMValue.Name" /></summary>
			public const string NAME = "MINIMUM";
			/// <summary>Constant value for <see cref="MINIMUMValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.1";
			/// <summary>Constant value for <see cref="MINIMUMValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="MINIMUMValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;minimum value.&#10;
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
		private MOHSValue _MOHS;
		/// <inheritdoc cref="MOHSValue" path="/summary" />
		public MOHSValue MOHS => _MOHS ?? (_MOHS = new MOHSValue());

		/// <summary>﻿scale to measure the resistance to scratching of a surface.<br /><br /><br />
		/// Value for DataItemSubTypeEnum.<br/>
		/// <br/>See also <seealso cref="DataItemSubTypeEnum">DataItemSubTypeEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		public sealed class MOHSValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="MOHSValue.Name" /></summary>
			public const string NAME = "MOHS";
			/// <summary>Constant value for <see cref="MOHSValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.4";
			/// <summary>Constant value for <see cref="MOHSValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="MOHSValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;scale to measure the resistance to scratching of a surface.&#10;
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
		private MOTIONValue _MOTION;
		/// <inheritdoc cref="MOTIONValue" path="/summary" />
		public MOTIONValue MOTION => _MOTION ?? (_MOTION = new MOTIONValue());

		/// <summary>﻿indication of the open or closed state of a mechanism.<br /><br /><br />
		/// Value for DataItemSubTypeEnum.<br/>
		/// <br/>See also <seealso cref="DataItemSubTypeEnum">DataItemSubTypeEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		public sealed class MOTIONValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="MOTIONValue.Name" /></summary>
			public const string NAME = "MOTION";
			/// <summary>Constant value for <see cref="MOTIONValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.4";
			/// <summary>Constant value for <see cref="MOTIONValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="MOTIONValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;indication of the open or closed state of a mechanism.&#10;
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
		private NO_SCALEValue _NO_SCALE;
		/// <inheritdoc cref="NO_SCALEValue" path="/summary" />
		public NO_SCALEValue NO_SCALE => _NO_SCALE ?? (_NO_SCALE = new NO_SCALEValue());

		/// <summary>﻿no weighting factor on the frequency scale.<br /><br /><br />
		/// Value for DataItemSubTypeEnum.<br/>
		/// <br/>See also <seealso cref="DataItemSubTypeEnum">DataItemSubTypeEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		public sealed class NO_SCALEValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="NO_SCALEValue.Name" /></summary>
			public const string NAME = "NO_SCALE";
			/// <summary>Constant value for <see cref="NO_SCALEValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.2";
			/// <summary>Constant value for <see cref="NO_SCALEValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="NO_SCALEValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;no weighting factor on the frequency scale.&#10;
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
		private OPERATINGValue _OPERATING;
		/// <inheritdoc cref="OPERATINGValue" path="/summary" />
		public OPERATINGValue OPERATING => _OPERATING ?? (_OPERATING = new OPERATINGValue());

		/// <summary>﻿piece of equipment that is powered or performing any activity.<br /><br /><br />
		/// Value for DataItemSubTypeEnum.<br/>
		/// <br/>See also <seealso cref="DataItemSubTypeEnum">DataItemSubTypeEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		public sealed class OPERATINGValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="OPERATINGValue.Name" /></summary>
			public const string NAME = "OPERATING";
			/// <summary>Constant value for <see cref="OPERATINGValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.4";
			/// <summary>Constant value for <see cref="OPERATINGValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="OPERATINGValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;piece of equipment that is powered or performing any activity.&#10;
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
		private OPERATORValue _OPERATOR;
		/// <inheritdoc cref="OPERATORValue" path="/summary" />
		public OPERATORValue OPERATOR => _OPERATOR ?? (_OPERATOR = new OPERATORValue());

		/// <summary>﻿relating to the person currently responsible for operating the piece of equipment.<br /><br /><br />
		/// Value for DataItemSubTypeEnum.<br/>
		/// <br/>See also <seealso cref="DataItemSubTypeEnum">DataItemSubTypeEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		public sealed class OPERATORValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="OPERATORValue.Name" /></summary>
			public const string NAME = "OPERATOR";
			/// <summary>Constant value for <see cref="OPERATORValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.4";
			/// <summary>Constant value for <see cref="OPERATORValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="OPERATORValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;relating to the person currently responsible for operating the piece of equipment.&#10;
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
		private OPTIONAL_STOPValue _OPTIONAL_STOP;
		/// <inheritdoc cref="OPTIONAL_STOPValue" path="/summary" />
		public OPTIONAL_STOPValue OPTIONAL_STOP => _OPTIONAL_STOP ?? (_OPTIONAL_STOP = new OPTIONAL_STOPValue());

		/// <summary>﻿setting or operator selection that changes the behavior of the controller on a piece of equipment. <br /><br /><br />
		/// Value for DataItemSubTypeEnum.<br/>
		/// <br/>See also <seealso cref="DataItemSubTypeEnum">DataItemSubTypeEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		public sealed class OPTIONAL_STOPValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="OPTIONAL_STOPValue.Name" /></summary>
			public const string NAME = "OPTIONAL_STOP";
			/// <summary>Constant value for <see cref="OPTIONAL_STOPValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.4";
			/// <summary>Constant value for <see cref="OPTIONAL_STOPValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="OPTIONAL_STOPValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;setting or operator selection that changes the behavior of the controller on a piece of equipment. &#10;
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
		private OVERRIDEValue _OVERRIDE;
		/// <inheritdoc cref="OVERRIDEValue" path="/summary" />
		public OVERRIDEValue OVERRIDE => _OVERRIDE ?? (_OVERRIDE = new OVERRIDEValue());

		/// <summary>﻿overridden value.<br /><br /><br />
		/// Value for DataItemSubTypeEnum.<br/>
		/// <br/>See also <seealso cref="DataItemSubTypeEnum">DataItemSubTypeEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		public sealed class OVERRIDEValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="OVERRIDEValue.Name" /></summary>
			public const string NAME = "OVERRIDE";
			/// <summary>Constant value for <see cref="OVERRIDEValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.0";
			/// <summary>Constant value for <see cref="OVERRIDEValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="OVERRIDEValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;overridden value.&#10;
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
		private POWEREDValue _POWERED;
		/// <inheritdoc cref="POWEREDValue" path="/summary" />
		public POWEREDValue POWERED => _POWERED ?? (_POWERED = new POWEREDValue());

		/// <summary>﻿piece of equipment is powered and functioning or <see cref="Component">Component</see> that are required to remain on are powered.<br /><br /><br />
		/// Value for DataItemSubTypeEnum.<br/>
		/// <br/>See also <seealso cref="DataItemSubTypeEnum">DataItemSubTypeEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		public sealed class POWEREDValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="POWEREDValue.Name" /></summary>
			public const string NAME = "POWERED";
			/// <summary>Constant value for <see cref="POWEREDValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.4";
			/// <summary>Constant value for <see cref="POWEREDValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="POWEREDValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;piece of equipment is powered and functioning or {{block(Component)}} that are required to remain on are powered.&#10;
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
		private PRIMARYValue _PRIMARY;
		/// <inheritdoc cref="PRIMARYValue" path="/summary" />
		public PRIMARYValue PRIMARY => _PRIMARY ?? (_PRIMARY = new PRIMARYValue());

		/// <summary>﻿main or most important.<br /><br /><br />
		/// Value for DataItemSubTypeEnum.<br/>
		/// <br/>See also <seealso cref="DataItemSubTypeEnum">DataItemSubTypeEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		public sealed class PRIMARYValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="PRIMARYValue.Name" /></summary>
			public const string NAME = "PRIMARY";
			/// <summary>Constant value for <see cref="PRIMARYValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.3";
			/// <summary>Constant value for <see cref="PRIMARYValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="PRIMARYValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;main or most important.&#10;
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
		private PROBEValue _PROBE;
		/// <inheritdoc cref="PROBEValue" path="/summary" />
		public PROBEValue PROBE => _PROBE ?? (_PROBE = new PROBEValue());

		/// <summary>﻿position provided by a measurement probe.<br /><br /><b>DEPRECATION WARNING</b>: May be deprecated in the future.<br /><br /><br />
		/// Value for DataItemSubTypeEnum.<br/>
		/// <br/>See also <seealso cref="DataItemSubTypeEnum">DataItemSubTypeEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		public sealed class PROBEValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="PROBEValue.Name" /></summary>
			public const string NAME = "PROBE";
			/// <summary>Constant value for <see cref="PROBEValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.1";
			/// <summary>Constant value for <see cref="PROBEValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="PROBEValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;position provided by a measurement probe.

**DEPRECATION WARNING**: May be deprecated in the future.&#10;
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
		private PROCESSValue _PROCESS;
		/// <inheritdoc cref="PROCESSValue" path="/summary" />
		public PROCESSValue PROCESS => _PROCESS ?? (_PROCESS = new PROCESSValue());

		/// <summary>﻿relating to production of a part or product on a piece of equipment.<br /><br /><br />
		/// Value for DataItemSubTypeEnum.<br/>
		/// <br/>See also <seealso cref="DataItemSubTypeEnum">DataItemSubTypeEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		public sealed class PROCESSValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="PROCESSValue.Name" /></summary>
			public const string NAME = "PROCESS";
			/// <summary>Constant value for <see cref="PROCESSValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.4";
			/// <summary>Constant value for <see cref="PROCESSValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="PROCESSValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;relating to production of a part or product on a piece of equipment.&#10;
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
		private PROGRAMMEDValue _PROGRAMMED;
		/// <inheritdoc cref="PROGRAMMEDValue" path="/summary" />
		public PROGRAMMEDValue PROGRAMMED => _PROGRAMMED ?? (_PROGRAMMED = new PROGRAMMEDValue());

		/// <summary>﻿directive value without offsets and adjustments.<br /><br /><br />
		/// Value for DataItemSubTypeEnum.<br/>
		/// <br/>See also <seealso cref="DataItemSubTypeEnum">DataItemSubTypeEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		public sealed class PROGRAMMEDValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="PROGRAMMEDValue.Name" /></summary>
			public const string NAME = "PROGRAMMED";
			/// <summary>Constant value for <see cref="PROGRAMMEDValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.3";
			/// <summary>Constant value for <see cref="PROGRAMMEDValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="PROGRAMMEDValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;directive value without offsets and adjustments.&#10;
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
		private RADIALValue _RADIAL;
		/// <inheritdoc cref="RADIALValue" path="/summary" />
		public RADIALValue RADIAL => _RADIAL ?? (_RADIAL = new RADIALValue());

		/// <summary>﻿reference to a radial type tool offset variable.<br /><br /><br />
		/// Value for DataItemSubTypeEnum.<br/>
		/// <br/>See also <seealso cref="DataItemSubTypeEnum">DataItemSubTypeEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		public sealed class RADIALValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="RADIALValue.Name" /></summary>
			public const string NAME = "RADIAL";
			/// <summary>Constant value for <see cref="RADIALValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.4";
			/// <summary>Constant value for <see cref="RADIALValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="RADIALValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;reference to a radial type tool offset variable.&#10;
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
		private RAPIDValue _RAPID;
		/// <inheritdoc cref="RAPIDValue" path="/summary" />
		public RAPIDValue RAPID => _RAPID ?? (_RAPID = new RAPIDValue());

		/// <summary>﻿performing an operation faster or in less time than nominal rate.<br /><br /><br />
		/// Value for DataItemSubTypeEnum.<br/>
		/// <br/>See also <seealso cref="DataItemSubTypeEnum">DataItemSubTypeEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		public sealed class RAPIDValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="RAPIDValue.Name" /></summary>
			public const string NAME = "RAPID";
			/// <summary>Constant value for <see cref="RAPIDValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.3";
			/// <summary>Constant value for <see cref="RAPIDValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="RAPIDValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;performing an operation faster or in less time than nominal rate.&#10;
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
		private REMAININGValue _REMAINING;
		/// <inheritdoc cref="REMAININGValue" path="/summary" />
		public REMAININGValue REMAINING => _REMAINING ?? (_REMAINING = new REMAININGValue());

		/// <summary>﻿remaining measure or count of an action, object or activity.<br /><br /><br />
		/// Value for DataItemSubTypeEnum.<br/>
		/// <br/>See also <seealso cref="DataItemSubTypeEnum">DataItemSubTypeEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		public sealed class REMAININGValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="REMAININGValue.Name" /></summary>
			public const string NAME = "REMAINING";
			/// <summary>Constant value for <see cref="REMAININGValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.3";
			/// <summary>Constant value for <see cref="REMAININGValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="REMAININGValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;remaining measure or count of an action, object or activity.&#10;
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
		private ROCKWELLValue _ROCKWELL;
		/// <inheritdoc cref="ROCKWELLValue" path="/summary" />
		public ROCKWELLValue ROCKWELL => _ROCKWELL ?? (_ROCKWELL = new ROCKWELLValue());

		/// <summary>﻿scale to measure the resistance to deformation of a surface.<br /><br /><br />
		/// Value for DataItemSubTypeEnum.<br/>
		/// <br/>See also <seealso cref="DataItemSubTypeEnum">DataItemSubTypeEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		public sealed class ROCKWELLValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="ROCKWELLValue.Name" /></summary>
			public const string NAME = "ROCKWELL";
			/// <summary>Constant value for <see cref="ROCKWELLValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.4";
			/// <summary>Constant value for <see cref="ROCKWELLValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="ROCKWELLValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;scale to measure the resistance to deformation of a surface.&#10;
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
		private ROTARYValue _ROTARY;
		/// <inheritdoc cref="ROTARYValue" path="/summary" />
		public ROTARYValue ROTARY => _ROTARY ?? (_ROTARY = new ROTARYValue());

		/// <summary>﻿direction of a rotary motion using the right hand rule convention.<br /><br /><br />
		/// Value for DataItemSubTypeEnum.<br/>
		/// <br/>See also <seealso cref="DataItemSubTypeEnum">DataItemSubTypeEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		public sealed class ROTARYValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="ROTARYValue.Name" /></summary>
			public const string NAME = "ROTARY";
			/// <summary>Constant value for <see cref="ROTARYValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.2";
			/// <summary>Constant value for <see cref="ROTARYValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="ROTARYValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;direction of a rotary motion using the right hand rule convention.&#10;
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
		private SCHEDULEValue _SCHEDULE;
		/// <inheritdoc cref="SCHEDULEValue" path="/summary" />
		public SCHEDULEValue SCHEDULE => _SCHEDULE ?? (_SCHEDULE = new SCHEDULEValue());

		/// <summary>﻿identity of a control program that is used to specify the order of execution of other programs.<br /><br /><br />
		/// Value for DataItemSubTypeEnum.<br/>
		/// <br/>See also <seealso cref="DataItemSubTypeEnum">DataItemSubTypeEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		public sealed class SCHEDULEValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="SCHEDULEValue.Name" /></summary>
			public const string NAME = "SCHEDULE";
			/// <summary>Constant value for <see cref="SCHEDULEValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.5";
			/// <summary>Constant value for <see cref="SCHEDULEValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="SCHEDULEValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;identity of a control program that is used to specify the order of execution of other programs.&#10;
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
		private SET_UPValue _SET_UP;
		/// <inheritdoc cref="SET_UPValue" path="/summary" />
		public SET_UPValue SET_UP => _SET_UP ?? (_SET_UP = new SET_UPValue());

		/// <summary>﻿relating to the preparation of a piece of equipment for production or restoring the piece of equipment to a neutral state after production.<br /><br /><br />
		/// Value for DataItemSubTypeEnum.<br/>
		/// <br/>See also <seealso cref="DataItemSubTypeEnum">DataItemSubTypeEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		public sealed class SET_UPValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="SET_UPValue.Name" /></summary>
			public const string NAME = "SET_UP";
			/// <summary>Constant value for <see cref="SET_UPValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.4";
			/// <summary>Constant value for <see cref="SET_UPValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="SET_UPValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;relating to the preparation of a piece of equipment for production or restoring the piece of equipment to a neutral state after production.&#10;
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
		private SHOREValue _SHORE;
		/// <inheritdoc cref="SHOREValue" path="/summary" />
		public SHOREValue SHORE => _SHORE ?? (_SHORE = new SHOREValue());

		/// <summary>﻿scale to measure the resistance to deformation of a surface.<br /><br /><br />
		/// Value for DataItemSubTypeEnum.<br/>
		/// <br/>See also <seealso cref="DataItemSubTypeEnum">DataItemSubTypeEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		public sealed class SHOREValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="SHOREValue.Name" /></summary>
			public const string NAME = "SHORE";
			/// <summary>Constant value for <see cref="SHOREValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.4";
			/// <summary>Constant value for <see cref="SHOREValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="SHOREValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;scale to measure the resistance to deformation of a surface.&#10;
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
		private SINGLE_BLOCKValue _SINGLE_BLOCK;
		/// <inheritdoc cref="SINGLE_BLOCKValue" path="/summary" />
		public SINGLE_BLOCKValue SINGLE_BLOCK => _SINGLE_BLOCK ?? (_SINGLE_BLOCK = new SINGLE_BLOCKValue());

		/// <summary>﻿setting or operator selection that changes the behavior of the controller on a piece of equipment. <br /><br /><br />
		/// Value for DataItemSubTypeEnum.<br/>
		/// <br/>See also <seealso cref="DataItemSubTypeEnum">DataItemSubTypeEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		public sealed class SINGLE_BLOCKValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="SINGLE_BLOCKValue.Name" /></summary>
			public const string NAME = "SINGLE_BLOCK";
			/// <summary>Constant value for <see cref="SINGLE_BLOCKValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.4";
			/// <summary>Constant value for <see cref="SINGLE_BLOCKValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="SINGLE_BLOCKValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;setting or operator selection that changes the behavior of the controller on a piece of equipment. &#10;
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
		private STANDARDValue _STANDARD;
		/// <inheritdoc cref="STANDARDValue" path="/summary" />
		public STANDARDValue STANDARD => _STANDARD ?? (_STANDARD = new STANDARDValue());

		/// <summary>﻿standard measure of an object or an action.<br /><br /><br />
		/// Value for DataItemSubTypeEnum.<br/>
		/// <br/>See also <seealso cref="DataItemSubTypeEnum">DataItemSubTypeEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		public sealed class STANDARDValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="STANDARDValue.Name" /></summary>
			public const string NAME = "STANDARD";
			/// <summary>Constant value for <see cref="STANDARDValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.3";
			/// <summary>Constant value for <see cref="STANDARDValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="STANDARDValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;standard measure of an object or an action.&#10;
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
		private STARTValue _START;
		/// <inheritdoc cref="STARTValue" path="/summary" />
		public STARTValue START => _START ?? (_START = new STARTValue());

		/// <summary>﻿boundary when an activity or an event commences.<br /><br /><br />
		/// Value for DataItemSubTypeEnum.<br/>
		/// <br/>See also <seealso cref="DataItemSubTypeEnum">DataItemSubTypeEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		public sealed class STARTValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="STARTValue.Name" /></summary>
			public const string NAME = "START";
			/// <summary>Constant value for <see cref="STARTValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.5";
			/// <summary>Constant value for <see cref="STARTValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="STARTValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;boundary when an activity or an event commences.&#10;
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
		private SWITCHEDValue _SWITCHED;
		/// <inheritdoc cref="SWITCHEDValue" path="/summary" />
		public SWITCHEDValue SWITCHED => _SWITCHED ?? (_SWITCHED = new SWITCHEDValue());

		/// <summary>﻿indication of the activation state of a mechanism represented by a <see cref="Composition">Composition</see>.<br /><br /><br />
		/// Value for DataItemSubTypeEnum.<br/>
		/// <br/>See also <seealso cref="DataItemSubTypeEnum">DataItemSubTypeEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		public sealed class SWITCHEDValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="SWITCHEDValue.Name" /></summary>
			public const string NAME = "SWITCHED";
			/// <summary>Constant value for <see cref="SWITCHEDValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.4";
			/// <summary>Constant value for <see cref="SWITCHEDValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="SWITCHEDValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;indication of the activation state of a mechanism represented by a {{block(Composition)}}.&#10;
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
		private TARGETValue _TARGET;
		/// <inheritdoc cref="TARGETValue" path="/summary" />
		public TARGETValue TARGET => _TARGET ?? (_TARGET = new TARGETValue());

		/// <summary>﻿goal of the operation or process.<br /><br /><br />
		/// Value for DataItemSubTypeEnum.<br/>
		/// <br/>See also <seealso cref="DataItemSubTypeEnum">DataItemSubTypeEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		public sealed class TARGETValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="TARGETValue.Name" /></summary>
			public const string NAME = "TARGET";
			/// <summary>Constant value for <see cref="TARGETValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.1";
			/// <summary>Constant value for <see cref="TARGETValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="TARGETValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;goal of the operation or process.&#10;
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
		private TARGET_COMPLETIONValue _TARGET_COMPLETION;
		/// <inheritdoc cref="TARGET_COMPLETIONValue" path="/summary" />
		public TARGET_COMPLETIONValue TARGET_COMPLETION => _TARGET_COMPLETION ?? (_TARGET_COMPLETION = new TARGET_COMPLETIONValue());

		/// <summary>﻿relating to the end or completion of an activity or event.<br /><br /><br />
		/// Value for DataItemSubTypeEnum.<br/>
		/// <br/>See also <seealso cref="DataItemSubTypeEnum">DataItemSubTypeEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		public sealed class TARGET_COMPLETIONValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="TARGET_COMPLETIONValue.Name" /></summary>
			public const string NAME = "TARGET_COMPLETION";
			/// <summary>Constant value for <see cref="TARGET_COMPLETIONValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.5";
			/// <summary>Constant value for <see cref="TARGET_COMPLETIONValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="TARGET_COMPLETIONValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;relating to the end or completion of an activity or event.&#10;
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
		private TOOL_CHANGE_STOPValue _TOOL_CHANGE_STOP;
		/// <inheritdoc cref="TOOL_CHANGE_STOPValue" path="/summary" />
		public TOOL_CHANGE_STOPValue TOOL_CHANGE_STOP => _TOOL_CHANGE_STOP ?? (_TOOL_CHANGE_STOP = new TOOL_CHANGE_STOPValue());

		/// <summary>﻿setting or operator selection that changes the behavior of the controller on a piece of equipment.<br /><br /><br />
		/// Value for DataItemSubTypeEnum.<br/>
		/// <br/>See also <seealso cref="DataItemSubTypeEnum">DataItemSubTypeEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		public sealed class TOOL_CHANGE_STOPValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="TOOL_CHANGE_STOPValue.Name" /></summary>
			public const string NAME = "TOOL_CHANGE_STOP";
			/// <summary>Constant value for <see cref="TOOL_CHANGE_STOPValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.4";
			/// <summary>Constant value for <see cref="TOOL_CHANGE_STOPValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="TOOL_CHANGE_STOPValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;setting or operator selection that changes the behavior of the controller on a piece of equipment.&#10;
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
		private USEABLEValue _USEABLE;
		/// <inheritdoc cref="USEABLEValue" path="/summary" />
		public USEABLEValue USEABLE => _USEABLE ?? (_USEABLE = new USEABLEValue());

		/// <summary>﻿remaining usable measure of an object or action.<br /><br /><br />
		/// Value for DataItemSubTypeEnum.<br/>
		/// <br/>See also <seealso cref="DataItemSubTypeEnum">DataItemSubTypeEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		public sealed class USEABLEValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="USEABLEValue.Name" /></summary>
			public const string NAME = "USEABLE";
			/// <summary>Constant value for <see cref="USEABLEValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.3";
			/// <summary>Constant value for <see cref="USEABLEValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="USEABLEValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;remaining usable measure of an object or action.&#10;
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
		private VERTICALValue _VERTICAL;
		/// <inheritdoc cref="VERTICALValue" path="/summary" />
		public VERTICALValue VERTICAL => _VERTICAL ?? (_VERTICAL = new VERTICALValue());

		/// <summary>﻿indication of the position of a mechanism that may move in a vertical direction.<br /><br /><br />
		/// Value for DataItemSubTypeEnum.<br/>
		/// <br/>See also <seealso cref="DataItemSubTypeEnum">DataItemSubTypeEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		public sealed class VERTICALValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="VERTICALValue.Name" /></summary>
			public const string NAME = "VERTICAL";
			/// <summary>Constant value for <see cref="VERTICALValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.4";
			/// <summary>Constant value for <see cref="VERTICALValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="VERTICALValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;indication of the position of a mechanism that may move in a vertical direction.&#10;
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
		private VICKERSValue _VICKERS;
		/// <inheritdoc cref="VICKERSValue" path="/summary" />
		public VICKERSValue VICKERS => _VICKERS ?? (_VICKERS = new VICKERSValue());

		/// <summary>﻿scale to measure the resistance to deformation of a surface.<br /><br /><br />
		/// Value for DataItemSubTypeEnum.<br/>
		/// <br/>See also <seealso cref="DataItemSubTypeEnum">DataItemSubTypeEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		public sealed class VICKERSValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="VICKERSValue.Name" /></summary>
			public const string NAME = "VICKERS";
			/// <summary>Constant value for <see cref="VICKERSValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.4";
			/// <summary>Constant value for <see cref="VICKERSValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="VICKERSValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;scale to measure the resistance to deformation of a surface.&#10;
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
		private WORKINGValue _WORKING;
		/// <inheritdoc cref="WORKINGValue" path="/summary" />
		public WORKINGValue WORKING => _WORKING ?? (_WORKING = new WORKINGValue());

		/// <summary>﻿piece of equipment performing any activity, the equipment is active and performing a function under load or not.<br /><br /><br />
		/// Value for DataItemSubTypeEnum.<br/>
		/// <br/>See also <seealso cref="DataItemSubTypeEnum">DataItemSubTypeEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		public sealed class WORKINGValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="WORKINGValue.Name" /></summary>
			public const string NAME = "WORKING";
			/// <summary>Constant value for <see cref="WORKINGValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.4";
			/// <summary>Constant value for <see cref="WORKINGValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="WORKINGValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;piece of equipment performing any activity, the equipment is active and performing a function under load or not.&#10;
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
		private IPV4_ADDRESSValue _IPV4_ADDRESS;
		/// <inheritdoc cref="IPV4_ADDRESSValue" path="/summary" />
		public IPV4_ADDRESSValue IPV4_ADDRESS => _IPV4_ADDRESS ?? (_IPV4_ADDRESS = new IPV4_ADDRESSValue());

		/// <summary>﻿IPV4 network address of the <see cref="Component">Component</see>.<br /><br /><br />
		/// Value for DataItemSubTypeEnum.<br/>
		/// <br/>See also <seealso cref="DataItemSubTypeEnum">DataItemSubTypeEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		public sealed class IPV4_ADDRESSValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="IPV4_ADDRESSValue.Name" /></summary>
			public const string NAME = "IPV4_ADDRESS";
			/// <summary>Constant value for <see cref="IPV4_ADDRESSValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.6";
			/// <summary>Constant value for <see cref="IPV4_ADDRESSValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="IPV4_ADDRESSValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;IPV4 network address of the {{block(Component)}}.&#10;
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
		private IPV6_ADDRESSValue _IPV6_ADDRESS;
		/// <inheritdoc cref="IPV6_ADDRESSValue" path="/summary" />
		public IPV6_ADDRESSValue IPV6_ADDRESS => _IPV6_ADDRESS ?? (_IPV6_ADDRESS = new IPV6_ADDRESSValue());

		/// <summary>﻿IPV6 network address of the <see cref="Component">Component</see>.<br /><br /><br />
		/// Value for DataItemSubTypeEnum.<br/>
		/// <br/>See also <seealso cref="DataItemSubTypeEnum">DataItemSubTypeEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		public sealed class IPV6_ADDRESSValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="IPV6_ADDRESSValue.Name" /></summary>
			public const string NAME = "IPV6_ADDRESS";
			/// <summary>Constant value for <see cref="IPV6_ADDRESSValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.6";
			/// <summary>Constant value for <see cref="IPV6_ADDRESSValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="IPV6_ADDRESSValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;IPV6 network address of the {{block(Component)}}.&#10;
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
		private GATEWAYValue _GATEWAY;
		/// <inheritdoc cref="GATEWAYValue" path="/summary" />
		public GATEWAYValue GATEWAY => _GATEWAY ?? (_GATEWAY = new GATEWAYValue());

		/// <summary>﻿Gateway for the <see cref="Component">Component</see> network.<br /><br /><br />
		/// Value for DataItemSubTypeEnum.<br/>
		/// <br/>See also <seealso cref="DataItemSubTypeEnum">DataItemSubTypeEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		public sealed class GATEWAYValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="GATEWAYValue.Name" /></summary>
			public const string NAME = "GATEWAY";
			/// <summary>Constant value for <see cref="GATEWAYValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.6";
			/// <summary>Constant value for <see cref="GATEWAYValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="GATEWAYValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;Gateway for the {{block(Component)}} network.&#10;
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
		private SUBNET_MASKValue _SUBNET_MASK;
		/// <inheritdoc cref="SUBNET_MASKValue" path="/summary" />
		public SUBNET_MASKValue SUBNET_MASK => _SUBNET_MASK ?? (_SUBNET_MASK = new SUBNET_MASKValue());

		/// <summary>﻿SubNet mask for the <see cref="Component">Component</see> network.<br /><br /><br /><br />
		/// Value for DataItemSubTypeEnum.<br/>
		/// <br/>See also <seealso cref="DataItemSubTypeEnum">DataItemSubTypeEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		public sealed class SUBNET_MASKValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="SUBNET_MASKValue.Name" /></summary>
			public const string NAME = "SUBNET_MASK";
			/// <summary>Constant value for <see cref="SUBNET_MASKValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.6";
			/// <summary>Constant value for <see cref="SUBNET_MASKValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="SUBNET_MASKValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;SubNet mask for the {{block(Component)}} network.&#10;
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
		private VLAN_IDValue _VLAN_ID;
		/// <inheritdoc cref="VLAN_IDValue" path="/summary" />
		public VLAN_IDValue VLAN_ID => _VLAN_ID ?? (_VLAN_ID = new VLAN_IDValue());

		/// <summary>﻿layer2 Virtual Local Network (VLAN) ID for the <see cref="Component">Component</see> network.<br /><br /><br />
		/// Value for DataItemSubTypeEnum.<br/>
		/// <br/>See also <seealso cref="DataItemSubTypeEnum">DataItemSubTypeEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		public sealed class VLAN_IDValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="VLAN_IDValue.Name" /></summary>
			public const string NAME = "VLAN_ID";
			/// <summary>Constant value for <see cref="VLAN_IDValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.6";
			/// <summary>Constant value for <see cref="VLAN_IDValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="VLAN_IDValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;layer2 Virtual Local Network (VLAN) ID for the {{block(Component)}} network.&#10;
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
		private MAC_ADDRESSValue _MAC_ADDRESS;
		/// <inheritdoc cref="MAC_ADDRESSValue" path="/summary" />
		public MAC_ADDRESSValue MAC_ADDRESS => _MAC_ADDRESS ?? (_MAC_ADDRESS = new MAC_ADDRESSValue());

		/// <summary>﻿Media Access Control Address. The unique physical address of the network hardware.<br /><br /><br />
		/// Value for DataItemSubTypeEnum.<br/>
		/// <br/>See also <seealso cref="DataItemSubTypeEnum">DataItemSubTypeEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		public sealed class MAC_ADDRESSValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="MAC_ADDRESSValue.Name" /></summary>
			public const string NAME = "MAC_ADDRESS";
			/// <summary>Constant value for <see cref="MAC_ADDRESSValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.6";
			/// <summary>Constant value for <see cref="MAC_ADDRESSValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="MAC_ADDRESSValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;Media Access Control Address. The unique physical address of the network hardware.&#10;
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
		private WIRELESSValue _WIRELESS;
		/// <inheritdoc cref="WIRELESSValue" path="/summary" />
		public WIRELESSValue WIRELESS => _WIRELESS ?? (_WIRELESS = new WIRELESSValue());

		/// <summary>﻿identifies whether the connection type is wireless.<br /><br /><br />
		/// Value for DataItemSubTypeEnum.<br/>
		/// <br/>See also <seealso cref="DataItemSubTypeEnum">DataItemSubTypeEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		public sealed class WIRELESSValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="WIRELESSValue.Name" /></summary>
			public const string NAME = "WIRELESS";
			/// <summary>Constant value for <see cref="WIRELESSValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.6";
			/// <summary>Constant value for <see cref="WIRELESSValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="WIRELESSValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;identifies whether the connection type is wireless.&#10;
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
		private LICENSEValue _LICENSE;
		/// <inheritdoc cref="LICENSEValue" path="/summary" />
		public LICENSEValue LICENSE => _LICENSE ?? (_LICENSE = new LICENSEValue());

		/// <summary>﻿license code to validate or activate the hardware or software.<br /><br /><br />
		/// Value for DataItemSubTypeEnum.<br/>
		/// <br/>See also <seealso cref="DataItemSubTypeEnum">DataItemSubTypeEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		public sealed class LICENSEValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="LICENSEValue.Name" /></summary>
			public const string NAME = "LICENSE";
			/// <summary>Constant value for <see cref="LICENSEValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.6";
			/// <summary>Constant value for <see cref="LICENSEValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="LICENSEValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;license code to validate or activate the hardware or software.&#10;
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
		private VERSIONValue _VERSION;
		/// <inheritdoc cref="VERSIONValue" path="/summary" />
		public VERSIONValue VERSION => _VERSION ?? (_VERSION = new VERSIONValue());

		/// <summary>﻿version of the hardware or software.<br /><br /><br /><br />
		/// Value for DataItemSubTypeEnum.<br/>
		/// <br/>See also <seealso cref="DataItemSubTypeEnum">DataItemSubTypeEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		public sealed class VERSIONValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="VERSIONValue.Name" /></summary>
			public const string NAME = "VERSION";
			/// <summary>Constant value for <see cref="VERSIONValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.6";
			/// <summary>Constant value for <see cref="VERSIONValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="VERSIONValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;version of the hardware or software.&#10;
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
		private RELEASE_DATEValue _RELEASE_DATE;
		/// <inheritdoc cref="RELEASE_DATEValue" path="/summary" />
		public RELEASE_DATEValue RELEASE_DATE => _RELEASE_DATE ?? (_RELEASE_DATE = new RELEASE_DATEValue());

		/// <summary>﻿date the hardware or software was released for general use.<br /><br /><br />
		/// Value for DataItemSubTypeEnum.<br/>
		/// <br/>See also <seealso cref="DataItemSubTypeEnum">DataItemSubTypeEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		public sealed class RELEASE_DATEValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="RELEASE_DATEValue.Name" /></summary>
			public const string NAME = "RELEASE_DATE";
			/// <summary>Constant value for <see cref="RELEASE_DATEValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.6";
			/// <summary>Constant value for <see cref="RELEASE_DATEValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="RELEASE_DATEValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;date the hardware or software was released for general use.&#10;
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
		private INSTALL_DATEValue _INSTALL_DATE;
		/// <inheritdoc cref="INSTALL_DATEValue" path="/summary" />
		public INSTALL_DATEValue INSTALL_DATE => _INSTALL_DATE ?? (_INSTALL_DATE = new INSTALL_DATEValue());

		/// <summary>﻿date the hardware or software was installed.<br /><br /><br />
		/// Value for DataItemSubTypeEnum.<br/>
		/// <br/>See also <seealso cref="DataItemSubTypeEnum">DataItemSubTypeEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		public sealed class INSTALL_DATEValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="INSTALL_DATEValue.Name" /></summary>
			public const string NAME = "INSTALL_DATE";
			/// <summary>Constant value for <see cref="INSTALL_DATEValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.6";
			/// <summary>Constant value for <see cref="INSTALL_DATEValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="INSTALL_DATEValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;date the hardware or software was installed.&#10;
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
		private MANUFACTURERValue _MANUFACTURER;
		/// <inheritdoc cref="MANUFACTURERValue" path="/summary" />
		public MANUFACTURERValue MANUFACTURER => _MANUFACTURER ?? (_MANUFACTURER = new MANUFACTURERValue());

		/// <summary>﻿corporate identity for the maker of the hardware or software.<br /><br /><br />
		/// Value for DataItemSubTypeEnum.<br/>
		/// <br/>See also <seealso cref="DataItemSubTypeEnum">DataItemSubTypeEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		public sealed class MANUFACTURERValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="MANUFACTURERValue.Name" /></summary>
			public const string NAME = "MANUFACTURER";
			/// <summary>Constant value for <see cref="MANUFACTURERValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.6";
			/// <summary>Constant value for <see cref="MANUFACTURERValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="MANUFACTURERValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;corporate identity for the maker of the hardware or software.&#10;
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
		private UUIDValue _UUID;
		/// <inheritdoc cref="UUIDValue" path="/summary" />
		public UUIDValue UUID => _UUID ?? (_UUID = new UUIDValue());

		/// <summary>﻿universally unique identifier as specified in ISO 11578 or RFC 4122.<br /><br /><br />
		/// Value for DataItemSubTypeEnum.<br/>
		/// <br/>See also <seealso cref="DataItemSubTypeEnum">DataItemSubTypeEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		public sealed class UUIDValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="UUIDValue.Name" /></summary>
			public const string NAME = "UUID";
			/// <summary>Constant value for <see cref="UUIDValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.7";
			/// <summary>Constant value for <see cref="UUIDValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="UUIDValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;universally unique identifier as specified in ISO 11578 or RFC 4122.&#10;
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

		/// <summary>﻿serial number that uniquely identifies a specific part.<br /><br /><br />
		/// Value for DataItemSubTypeEnum.<br/>
		/// <br/>See also <seealso cref="DataItemSubTypeEnum">DataItemSubTypeEnum</seealso>
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
			public const string NORMATIVE_VERSION = "1.7";
			/// <summary>Constant value for <see cref="SERIAL_NUMBERValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="SERIAL_NUMBERValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;serial number that uniquely identifies a specific part.&#10;
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
		private RAW_MATERIALValue _RAW_MATERIAL;
		/// <inheritdoc cref="RAW_MATERIALValue" path="/summary" />
		public RAW_MATERIALValue RAW_MATERIAL => _RAW_MATERIAL ?? (_RAW_MATERIAL = new RAW_MATERIALValue());

		/// <summary>﻿material that is used to produce parts.<br /><br /><br />
		/// Value for DataItemSubTypeEnum.<br/>
		/// <br/>See also <seealso cref="DataItemSubTypeEnum">DataItemSubTypeEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		public sealed class RAW_MATERIALValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="RAW_MATERIALValue.Name" /></summary>
			public const string NAME = "RAW_MATERIAL";
			/// <summary>Constant value for <see cref="RAW_MATERIALValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.7";
			/// <summary>Constant value for <see cref="RAW_MATERIALValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="RAW_MATERIALValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;material that is used to produce parts.&#10;
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
		private LOTValue _LOT;
		/// <inheritdoc cref="LOTValue" path="/summary" />
		public LOTValue LOT => _LOT ?? (_LOT = new LOTValue());

		/// <summary>﻿group of parts tracked as a lot.<br /><br /><br />
		/// Value for DataItemSubTypeEnum.<br/>
		/// <br/>See also <seealso cref="DataItemSubTypeEnum">DataItemSubTypeEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		public sealed class LOTValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="LOTValue.Name" /></summary>
			public const string NAME = "LOT";
			/// <summary>Constant value for <see cref="LOTValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.7";
			/// <summary>Constant value for <see cref="LOTValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="LOTValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;group of parts tracked as a lot.&#10;
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
		private BATCHValue _BATCH;
		/// <inheritdoc cref="BATCHValue" path="/summary" />
		public BATCHValue BATCH => _BATCH ?? (_BATCH = new BATCHValue());

		/// <summary>﻿group of parts produced in a batch.<br /><br /><br />
		/// Value for DataItemSubTypeEnum.<br/>
		/// <br/>See also <seealso cref="DataItemSubTypeEnum">DataItemSubTypeEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		public sealed class BATCHValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="BATCHValue.Name" /></summary>
			public const string NAME = "BATCH";
			/// <summary>Constant value for <see cref="BATCHValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.7";
			/// <summary>Constant value for <see cref="BATCHValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="BATCHValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;group of parts produced in a batch.&#10;
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
		private HEAT_TREATValue _HEAT_TREAT;
		/// <inheritdoc cref="HEAT_TREATValue" path="/summary" />
		public HEAT_TREATValue HEAT_TREAT => _HEAT_TREAT ?? (_HEAT_TREAT = new HEAT_TREATValue());

		/// <summary>﻿material heat number.<br /><br /><br />
		/// Value for DataItemSubTypeEnum.<br/>
		/// <br/>See also <seealso cref="DataItemSubTypeEnum">DataItemSubTypeEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		public sealed class HEAT_TREATValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="HEAT_TREATValue.Name" /></summary>
			public const string NAME = "HEAT_TREAT";
			/// <summary>Constant value for <see cref="HEAT_TREATValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.7";
			/// <summary>Constant value for <see cref="HEAT_TREATValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="HEAT_TREATValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;material heat number.&#10;
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

		/// <summary>﻿particular part design or model.<br /><br /><br />
		/// Value for DataItemSubTypeEnum.<br/>
		/// <br/>See also <seealso cref="DataItemSubTypeEnum">DataItemSubTypeEnum</seealso>
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
			public const string NORMATIVE_VERSION = "1.7";
			/// <summary>Constant value for <see cref="PART_NUMBERValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="PART_NUMBERValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;particular part design or model.&#10;
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
		private PART_FAMILYValue _PART_FAMILY;
		/// <inheritdoc cref="PART_FAMILYValue" path="/summary" />
		public PART_FAMILYValue PART_FAMILY => _PART_FAMILY ?? (_PART_FAMILY = new PART_FAMILYValue());

		/// <summary>﻿group of parts having similarities in geometry, manufacturing process, and/or functions.<br /><br /><br />
		/// Value for DataItemSubTypeEnum.<br/>
		/// <br/>See also <seealso cref="DataItemSubTypeEnum">DataItemSubTypeEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		public sealed class PART_FAMILYValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="PART_FAMILYValue.Name" /></summary>
			public const string NAME = "PART_FAMILY";
			/// <summary>Constant value for <see cref="PART_FAMILYValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.7";
			/// <summary>Constant value for <see cref="PART_FAMILYValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="PART_FAMILYValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;group of parts having similarities in geometry, manufacturing process, and/or functions.&#10;
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
		private PART_NAMEValue _PART_NAME;
		/// <inheritdoc cref="PART_NAMEValue" path="/summary" />
		public PART_NAMEValue PART_NAME => _PART_NAME ?? (_PART_NAME = new PART_NAMEValue());

		/// <summary>﻿word or set of words by which a part is known, addressed, or referred to.<br /><br /><br />
		/// Value for DataItemSubTypeEnum.<br/>
		/// <br/>See also <seealso cref="DataItemSubTypeEnum">DataItemSubTypeEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		public sealed class PART_NAMEValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="PART_NAMEValue.Name" /></summary>
			public const string NAME = "PART_NAME";
			/// <summary>Constant value for <see cref="PART_NAMEValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.7";
			/// <summary>Constant value for <see cref="PART_NAMEValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="PART_NAMEValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;word or set of words by which a part is known, addressed, or referred to.&#10;
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
		private PROCESS_STEPValue _PROCESS_STEP;
		/// <inheritdoc cref="PROCESS_STEPValue" path="/summary" />
		public PROCESS_STEPValue PROCESS_STEP => _PROCESS_STEP ?? (_PROCESS_STEP = new PROCESS_STEPValue());

		/// <summary>﻿step in the process plan that this occurrence corresponds to. <br /><br /><br />
		/// Value for DataItemSubTypeEnum.<br/>
		/// <br/>See also <seealso cref="DataItemSubTypeEnum">DataItemSubTypeEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		public sealed class PROCESS_STEPValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="PROCESS_STEPValue.Name" /></summary>
			public const string NAME = "PROCESS_STEP";
			/// <summary>Constant value for <see cref="PROCESS_STEPValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.7";
			/// <summary>Constant value for <see cref="PROCESS_STEPValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="PROCESS_STEPValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;step in the process plan that this occurrence corresponds to. &#10;
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
		private PROCESS_PLANValue _PROCESS_PLAN;
		/// <inheritdoc cref="PROCESS_PLANValue" path="/summary" />
		public PROCESS_PLANValue PROCESS_PLAN => _PROCESS_PLAN ?? (_PROCESS_PLAN = new PROCESS_PLANValue());

		/// <summary>﻿process plan that a process occurrence belongs to.<br /><br /><br />
		/// Value for DataItemSubTypeEnum.<br/>
		/// <br/>See also <seealso cref="DataItemSubTypeEnum">DataItemSubTypeEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		public sealed class PROCESS_PLANValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="PROCESS_PLANValue.Name" /></summary>
			public const string NAME = "PROCESS_PLAN";
			/// <summary>Constant value for <see cref="PROCESS_PLANValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.7";
			/// <summary>Constant value for <see cref="PROCESS_PLANValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="PROCESS_PLANValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;process plan that a process occurrence belongs to.&#10;
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
		private ORDER_NUMBERValue _ORDER_NUMBER;
		/// <inheritdoc cref="ORDER_NUMBERValue" path="/summary" />
		public ORDER_NUMBERValue ORDER_NUMBER => _ORDER_NUMBER ?? (_ORDER_NUMBER = new ORDER_NUMBERValue());

		/// <summary>﻿authorization of a process occurrence.<br /><br /><br />
		/// Value for DataItemSubTypeEnum.<br/>
		/// <br/>See also <seealso cref="DataItemSubTypeEnum">DataItemSubTypeEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		public sealed class ORDER_NUMBERValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="ORDER_NUMBERValue.Name" /></summary>
			public const string NAME = "ORDER_NUMBER";
			/// <summary>Constant value for <see cref="ORDER_NUMBERValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.7";
			/// <summary>Constant value for <see cref="ORDER_NUMBERValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="ORDER_NUMBERValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;authorization of a process occurrence.&#10;
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
		private PROCESS_NAMEValue _PROCESS_NAME;
		/// <inheritdoc cref="PROCESS_NAMEValue" path="/summary" />
		public PROCESS_NAMEValue PROCESS_NAME => _PROCESS_NAME ?? (_PROCESS_NAME = new PROCESS_NAMEValue());

		/// <summary>﻿word or set of words by which a process being executed (process occurrence) by the device is known, addressed, or referred to.<br /><br /><br /><br />
		/// Value for DataItemSubTypeEnum.<br/>
		/// <br/>See also <seealso cref="DataItemSubTypeEnum">DataItemSubTypeEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		public sealed class PROCESS_NAMEValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="PROCESS_NAMEValue.Name" /></summary>
			public const string NAME = "PROCESS_NAME";
			/// <summary>Constant value for <see cref="PROCESS_NAMEValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.7";
			/// <summary>Constant value for <see cref="PROCESS_NAMEValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="PROCESS_NAMEValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;word or set of words by which a process being executed (process occurrence) by the device is known, addressed, or referred to.&#10;
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
		private ISO_STEP_EXECUTABLEValue _ISO_STEP_EXECUTABLE;
		/// <inheritdoc cref="ISO_STEP_EXECUTABLEValue" path="/summary" />
		public ISO_STEP_EXECUTABLEValue ISO_STEP_EXECUTABLE => _ISO_STEP_EXECUTABLE ?? (_ISO_STEP_EXECUTABLE = new ISO_STEP_EXECUTABLEValue());

		/// <summary>﻿reference to a ISO 10303 Executable.<br /><br /><br />
		/// Value for DataItemSubTypeEnum.<br/>
		/// <br/>See also <seealso cref="DataItemSubTypeEnum">DataItemSubTypeEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		public sealed class ISO_STEP_EXECUTABLEValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="ISO_STEP_EXECUTABLEValue.Name" /></summary>
			public const string NAME = "ISO_STEP_EXECUTABLE";
			/// <summary>Constant value for <see cref="ISO_STEP_EXECUTABLEValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.7";
			/// <summary>Constant value for <see cref="ISO_STEP_EXECUTABLEValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="ISO_STEP_EXECUTABLEValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;reference to a ISO 10303 Executable.&#10;
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
		private COMPLETEValue _COMPLETE;
		/// <inheritdoc cref="COMPLETEValue" path="/summary" />
		public COMPLETEValue COMPLETE => _COMPLETE ?? (_COMPLETE = new COMPLETEValue());

		/// <summary>﻿associated with the completion of an activity or event.<br /><br /><br />
		/// Value for DataItemSubTypeEnum.<br/>
		/// <br/>See also <seealso cref="DataItemSubTypeEnum">DataItemSubTypeEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		public sealed class COMPLETEValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="COMPLETEValue.Name" /></summary>
			public const string NAME = "COMPLETE";
			/// <summary>Constant value for <see cref="COMPLETEValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.5";
			/// <summary>Constant value for <see cref="COMPLETEValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="COMPLETEValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;associated with the completion of an activity or event.&#10;
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
		private ACTIVEValue _ACTIVE;
		/// <inheritdoc cref="ACTIVEValue" path="/summary" />
		public ACTIVEValue ACTIVE => _ACTIVE ?? (_ACTIVE = new ACTIVEValue());

		/// <summary>﻿relating to logic or motion program currently executing.<br /><br /><br />
		/// Value for DataItemSubTypeEnum.<br/>
		/// <br/>See also <seealso cref="DataItemSubTypeEnum">DataItemSubTypeEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		public sealed class ACTIVEValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="ACTIVEValue.Name" /></summary>
			public const string NAME = "ACTIVE";
			/// <summary>Constant value for <see cref="ACTIVEValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.5";
			/// <summary>Constant value for <see cref="ACTIVEValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="ACTIVEValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;relating to logic or motion program currently executing.&#10;
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
		private FAILEDValue _FAILED;
		/// <inheritdoc cref="FAILEDValue" path="/summary" />
		public FAILEDValue FAILED => _FAILED ?? (_FAILED = new FAILEDValue());

		/// <summary>﻿actions or activities that were attempted , but failed to complete or resulted in an unexpected or unacceptable outcome.<br /><br /><br />
		/// Value for DataItemSubTypeEnum.<br/>
		/// <br/>See also <seealso cref="DataItemSubTypeEnum">DataItemSubTypeEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		public sealed class FAILEDValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="FAILEDValue.Name" /></summary>
			public const string NAME = "FAILED";
			/// <summary>Constant value for <see cref="FAILEDValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.8";
			/// <summary>Constant value for <see cref="FAILEDValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="FAILEDValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;actions or activities that were attempted , but failed to complete or resulted in an unexpected or unacceptable outcome.&#10;
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
		private ABORTEDValue _ABORTED;
		/// <inheritdoc cref="ABORTEDValue" path="/summary" />
		public ABORTEDValue ABORTED => _ABORTED ?? (_ABORTED = new ABORTEDValue());

		/// <summary>﻿actions or activities that were attempted, but terminated before they could be completed.<br /><br /><br />
		/// Value for DataItemSubTypeEnum.<br/>
		/// <br/>See also <seealso cref="DataItemSubTypeEnum">DataItemSubTypeEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		public sealed class ABORTEDValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="ABORTEDValue.Name" /></summary>
			public const string NAME = "ABORTED";
			/// <summary>Constant value for <see cref="ABORTEDValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.8";
			/// <summary>Constant value for <see cref="ABORTEDValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="ABORTEDValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;actions or activities that were attempted, but terminated before they could be completed.&#10;
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
		private ENDEDValue _ENDED;
		/// <inheritdoc cref="ENDEDValue" path="/summary" />
		public ENDEDValue ENDED => _ENDED ?? (_ENDED = new ENDEDValue());

		/// <summary>﻿boundary when an activity or an event terminates.<br /><br /><br />
		/// Value for DataItemSubTypeEnum.<br/>
		/// <br/>See also <seealso cref="DataItemSubTypeEnum">DataItemSubTypeEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		public sealed class ENDEDValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="ENDEDValue.Name" /></summary>
			public const string NAME = "ENDED";
			/// <summary>Constant value for <see cref="ENDEDValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.8";
			/// <summary>Constant value for <see cref="ENDEDValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="ENDEDValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;boundary when an activity or an event terminates.&#10;
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
		private WASTEValue _WASTE;
		/// <inheritdoc cref="WASTEValue" path="/summary" />
		public WASTEValue WASTE => _WASTE ?? (_WASTE = new WASTEValue());

		/// <summary>﻿amount discarded.<br /><br /><br />
		/// Value for DataItemSubTypeEnum.<br/>
		/// <br/>See also <seealso cref="DataItemSubTypeEnum">DataItemSubTypeEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		public sealed class WASTEValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="WASTEValue.Name" /></summary>
			public const string NAME = "WASTE";
			/// <summary>Constant value for <see cref="WASTEValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.8";
			/// <summary>Constant value for <see cref="WASTEValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="WASTEValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;amount discarded.&#10;
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
		private PARTValue _PART;
		/// <inheritdoc cref="PARTValue" path="/summary" />
		public PARTValue PART => _PART ?? (_PART = new PARTValue());

		/// <summary>﻿amount included in the <i>part</i>.<br /><br /><br />
		/// Value for DataItemSubTypeEnum.<br/>
		/// <br/>See also <seealso cref="DataItemSubTypeEnum">DataItemSubTypeEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		public sealed class PARTValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="PARTValue.Name" /></summary>
			public const string NAME = "PART";
			/// <summary>Constant value for <see cref="PARTValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.8";
			/// <summary>Constant value for <see cref="PARTValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="PARTValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;amount included in the {{term(part)}}.&#10;
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
		private REQUESTValue _REQUEST;
		/// <inheritdoc cref="REQUESTValue" path="/summary" />
		public REQUESTValue REQUEST => _REQUEST ?? (_REQUEST = new REQUESTValue());

		/// <summary>﻿<i>request</i> by an <see cref="Interface">Interface</see> for a task.<br /><br /><br />
		/// Value for DataItemSubTypeEnum.<br/>
		/// <br/>See also <seealso cref="DataItemSubTypeEnum">DataItemSubTypeEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		public sealed class REQUESTValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="REQUESTValue.Name" /></summary>
			public const string NAME = "REQUEST";
			/// <summary>Constant value for <see cref="REQUESTValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.3";
			/// <summary>Constant value for <see cref="REQUESTValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="REQUESTValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;{{term(request)}} by an {{block(Interface)}} for a task.&#10;
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
		private RESPONSEValue _RESPONSE;
		/// <inheritdoc cref="RESPONSEValue" path="/summary" />
		public RESPONSEValue RESPONSE => _RESPONSE ?? (_RESPONSE = new RESPONSEValue());

		/// <summary>﻿<i>response</i> by an <see cref="Interface">Interface</see> to a <i>request</i> for a task.<br /><br /><br />
		/// Value for DataItemSubTypeEnum.<br/>
		/// <br/>See also <seealso cref="DataItemSubTypeEnum">DataItemSubTypeEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		public sealed class RESPONSEValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="RESPONSEValue.Name" /></summary>
			public const string NAME = "RESPONSE";
			/// <summary>Constant value for <see cref="RESPONSEValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.3";
			/// <summary>Constant value for <see cref="RESPONSEValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="RESPONSEValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;{{term(response)}} by an {{block(Interface)}} to a {{term(request)}} for a task.&#10;
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
		private ACTIVITYValue _ACTIVITY;
		/// <inheritdoc cref="ACTIVITYValue" path="/summary" />
		public ACTIVITYValue ACTIVITY => _ACTIVITY ?? (_ACTIVITY = new ACTIVITYValue());

		/// <summary>﻿phase or segment of a recipe or program.<br /><br /><br />
		/// Value for DataItemSubTypeEnum.<br/>
		/// <br/>See also <seealso cref="DataItemSubTypeEnum">DataItemSubTypeEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		public sealed class ACTIVITYValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="ACTIVITYValue.Name" /></summary>
			public const string NAME = "ACTIVITY";
			/// <summary>Constant value for <see cref="ACTIVITYValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "2.0";
			/// <summary>Constant value for <see cref="ACTIVITYValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="ACTIVITYValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;phase or segment of a recipe or program.&#10;
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
		private SEGMENTValue _SEGMENT;
		/// <inheritdoc cref="SEGMENTValue" path="/summary" />
		public SEGMENTValue SEGMENT => _SEGMENT ?? (_SEGMENT = new SEGMENTValue());

		/// <summary>﻿phase of a recipe process.<br /><br /><br />
		/// Value for DataItemSubTypeEnum.<br/>
		/// <br/>See also <seealso cref="DataItemSubTypeEnum">DataItemSubTypeEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		public sealed class SEGMENTValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="SEGMENTValue.Name" /></summary>
			public const string NAME = "SEGMENT";
			/// <summary>Constant value for <see cref="SEGMENTValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "2.0";
			/// <summary>Constant value for <see cref="SEGMENTValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="SEGMENTValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;phase of a recipe process.&#10;
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
		private RECIPEValue _RECIPE;
		/// <inheritdoc cref="RECIPEValue" path="/summary" />
		public RECIPEValue RECIPE => _RECIPE ?? (_RECIPE = new RECIPEValue());

		/// <summary>﻿process as part of product production; can be a subprocess of a larger process.<br /><br /><br />
		/// Value for DataItemSubTypeEnum.<br/>
		/// <br/>See also <seealso cref="DataItemSubTypeEnum">DataItemSubTypeEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		public sealed class RECIPEValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="RECIPEValue.Name" /></summary>
			public const string NAME = "RECIPE";
			/// <summary>Constant value for <see cref="RECIPEValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "2.0";
			/// <summary>Constant value for <see cref="RECIPEValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="RECIPEValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;process as part of product production; can be a subprocess of a larger process.&#10;
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
		private OPERATIONValue _OPERATION;
		/// <inheritdoc cref="OPERATIONValue" path="/summary" />
		public OPERATIONValue OPERATION => _OPERATION ?? (_OPERATION = new OPERATIONValue());

		/// <summary>﻿step of a discrete manufacturing process.<br /><br /><br />
		/// Value for DataItemSubTypeEnum.<br/>
		/// <br/>See also <seealso cref="DataItemSubTypeEnum">DataItemSubTypeEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		public sealed class OPERATIONValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="OPERATIONValue.Name" /></summary>
			public const string NAME = "OPERATION";
			/// <summary>Constant value for <see cref="OPERATIONValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "2.0";
			/// <summary>Constant value for <see cref="OPERATIONValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="OPERATIONValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;step of a discrete manufacturing process.&#10;
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
		private BINARYValue _BINARY;
		/// <inheritdoc cref="BINARYValue" path="/summary" />
		public BINARYValue BINARY => _BINARY ?? (_BINARY = new BINARYValue());

		/// <summary>﻿observed as a binary data type.<br /><br /><br />
		/// Value for DataItemSubTypeEnum.<br/>
		/// <br/>See also <seealso cref="DataItemSubTypeEnum">DataItemSubTypeEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		public sealed class BINARYValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="BINARYValue.Name" /></summary>
			public const string NAME = "BINARY";
			/// <summary>Constant value for <see cref="BINARYValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "2.2";
			/// <summary>Constant value for <see cref="BINARYValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="BINARYValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;observed as a binary data type.&#10;
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
		private BOOLEANValue _BOOLEAN;
		/// <inheritdoc cref="BOOLEANValue" path="/summary" />
		public BOOLEANValue BOOLEAN => _BOOLEAN ?? (_BOOLEAN = new BOOLEANValue());

		/// <summary>﻿observed as a boolean data type.<br /><br /><br />
		/// Value for DataItemSubTypeEnum.<br/>
		/// <br/>See also <seealso cref="DataItemSubTypeEnum">DataItemSubTypeEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		public sealed class BOOLEANValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="BOOLEANValue.Name" /></summary>
			public const string NAME = "BOOLEAN";
			/// <summary>Constant value for <see cref="BOOLEANValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "2.2";
			/// <summary>Constant value for <see cref="BOOLEANValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="BOOLEANValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;observed as a boolean data type.&#10;
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
		private ENUMERATEDValue _ENUMERATED;
		/// <inheritdoc cref="ENUMERATEDValue" path="/summary" />
		public ENUMERATEDValue ENUMERATED => _ENUMERATED ?? (_ENUMERATED = new ENUMERATEDValue());

		/// <summary>﻿observed as a set containing a restricted number of discrete values where each discrete value is named and unique.<br /><seealso href="https://www.google.com/search?q=ISO 21961:2003, 013&amp;btnI=I">ISO 21961:2003, 013</seealso><br /><br /><br />
		/// Value for DataItemSubTypeEnum.<br/>
		/// <br/>See also <seealso cref="DataItemSubTypeEnum">DataItemSubTypeEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		public sealed class ENUMERATEDValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="ENUMERATEDValue.Name" /></summary>
			public const string NAME = "ENUMERATED";
			/// <summary>Constant value for <see cref="ENUMERATEDValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "2.2";
			/// <summary>Constant value for <see cref="ENUMERATEDValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="ENUMERATEDValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;observed as a set containing a restricted number of discrete values where each discrete value is named and unique.
{{cite(ISO 21961:2003, 013)}}&#10;
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
		private DETECTValue _DETECT;
		/// <inheritdoc cref="DETECTValue" path="/summary" />
		public DETECTValue DETECT => _DETECT ?? (_DETECT = new DETECTValue());

		/// <summary>﻿indicated by the presence or existence of something.<br /><br /><br />
		/// Value for DataItemSubTypeEnum.<br/>
		/// <br/>See also <seealso cref="DataItemSubTypeEnum">DataItemSubTypeEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		public sealed class DETECTValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="DETECTValue.Name" /></summary>
			public const string NAME = "DETECT";
			/// <summary>Constant value for <see cref="DETECTValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "2.2";
			/// <summary>Constant value for <see cref="DETECTValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="DETECTValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;indicated by the presence or existence of something.&#10;
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
		private MODELValue _MODEL;
		/// <inheritdoc cref="MODELValue" path="/summary" />
		public MODELValue MODEL => _MODEL ?? (_MODEL = new MODELValue());

		/// <summary>﻿model info of the hardware or software.<br /><br /><br />
		/// Value for DataItemSubTypeEnum.<br/>
		/// <br/>See also <seealso cref="DataItemSubTypeEnum">DataItemSubTypeEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		public sealed class MODELValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="MODELValue.Name" /></summary>
			public const string NAME = "MODEL";
			/// <summary>Constant value for <see cref="MODELValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "2.3";
			/// <summary>Constant value for <see cref="MODELValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="MODELValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;model info of the hardware or software.&#10;
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
		private SECONDARYValue _SECONDARY;
		/// <inheritdoc cref="SECONDARYValue" path="/summary" />
		public SECONDARYValue SECONDARY => _SECONDARY ?? (_SECONDARY = new SECONDARYValue());

		/// <summary>﻿alternate or not primary.<br /><br /><br />
		/// Value for DataItemSubTypeEnum.<br/>
		/// <br/>See also <seealso cref="DataItemSubTypeEnum">DataItemSubTypeEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		public sealed class SECONDARYValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="SECONDARYValue.Name" /></summary>
			public const string NAME = "SECONDARY";
			/// <summary>Constant value for <see cref="SECONDARYValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "2.3";
			/// <summary>Constant value for <see cref="SECONDARYValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="SECONDARYValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;alternate or not primary.&#10;
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
		private STANDBYValue _STANDBY;
		/// <inheritdoc cref="STANDBYValue" path="/summary" />
		public STANDBYValue STANDBY => _STANDBY ?? (_STANDBY = new STANDBYValue());

		/// <summary>﻿held near at hand and ready for use.<br /><br /><br />
		/// Value for DataItemSubTypeEnum.<br/>
		/// <br/>See also <seealso cref="DataItemSubTypeEnum">DataItemSubTypeEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		public sealed class STANDBYValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="STANDBYValue.Name" /></summary>
			public const string NAME = "STANDBY";
			/// <summary>Constant value for <see cref="STANDBYValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "2.3";
			/// <summary>Constant value for <see cref="STANDBYValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="STANDBYValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;held near at hand and ready for use.&#10;
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