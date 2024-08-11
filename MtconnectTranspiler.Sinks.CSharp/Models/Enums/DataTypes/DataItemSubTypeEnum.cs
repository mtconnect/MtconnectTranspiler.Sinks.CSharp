using System;
using System.CodeDom.Compiler;using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;

namespace Mtconnect.DataTypes
{
	/// <summary>
	/// View in the MTConnect Model browser <seealso href="https://model.mtconnect.org/#Enumeration___19_0_3_45f01b9_1579563592155_977172_22064">model.mtconnect.org</seealso>
	/// </summary>
	/// <remarks>
	/// <list type="bullet">
	/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
	/// </list>
	/// </remarks>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.3.0.0")]
	public enum DataItemSubTypeEnum
	{
		/// <summary>
		/// relating to or derived in the simplest manner from the fundamental units or measurements.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.4">v1.4</see></item>
		/// </list>
		/// </remarks>
		ABSOLUTE,
		/// <summary>
		/// indication of the operating state of a mechanism.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.4">v1.4</see></item>
		/// </list>
		/// </remarks>
		ACTION,
		/// <summary>
		/// measured or reported value of an <i>observation</i>.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>
		ACTUAL,
		/// <summary>
		/// all actions, items, or activities being counted independent of the outcome.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>
		ALL,
		/// <summary>
		/// measurement of alternating voltage or current. If not specified further in statistic, defaults to RMS voltage.   <b>DEPRECATED</b> in <i>Version 1.6</i>s.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.2">v1.2</see></item>
		/// <item><b>Deprecated</b>: <see href="https://model.mtconnect.org/#_Version_1.6">v1.6</see></item>
		/// </list>
		/// </remarks>
		[Obsolete("Deprecated in v1.6 according to https://model.mtconnect.org/#_Version_1.6")]
		ALTERNATING,
		/// <summary>
		/// A-Scale weighting factor on the frequency scale.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.2">v1.2</see></item>
		/// </list>
		/// </remarks>
		A_SCALE,
		/// <summary>
		/// when multiple locations on a piece of bar stock being feed by a bar feeder are referenced as the indication of whether the end of that piece of bar stock has been reached.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.3">v1.3</see></item>
		/// </list>
		/// </remarks>
		AUXILIARY,
		/// <summary>
		/// actions, items, or activities being counted that do not conform to specification or expectation.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>
		BAD,
		/// <summary>
		/// scale to measure the resistance to deformation of a surface.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.4">v1.4</see></item>
		/// </list>
		/// </remarks>
		BRINELL,
		/// <summary>
		/// B-Scale weighting factor on the frequency scale.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.2">v1.2</see></item>
		/// </list>
		/// </remarks>
		B_SCALE,
		/// <summary>
		/// directive value including adjustments such as an offset or overrides.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>
		COMMANDED,
		/// <summary>
		/// amount of material consumed from an object or container during a manufacturing process.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.5">v1.5</see></item>
		/// </list>
		/// </remarks>
		CONSUMED,
		/// <summary>
		/// state of the enabling signal or control logic that enables or disables the function or operation of the entity.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.1">v1.1</see></item>
		/// </list>
		/// </remarks>
		CONTROL,
		/// <summary>
		/// C-Scale weighting factor on the frequency scale.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.2">v1.2</see></item>
		/// </list>
		/// </remarks>
		C_SCALE,
		/// <summary>
		/// elapsed time of a temporary halt of action.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.4">v1.4</see></item>
		/// </list>
		/// </remarks>
		DELAY,
		/// <summary>
		/// DC current or voltage.  <b>DEPRECATED</b> in <i>Version 1.6</i>s.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.2">v1.2</see></item>
		/// <item><b>Deprecated</b>: <see href="https://model.mtconnect.org/#_Version_1.6">v1.6</see></item>
		/// </list>
		/// </remarks>
		[Obsolete("Deprecated in v1.6 according to https://model.mtconnect.org/#_Version_1.6")]
		DIRECT,
		/// <summary>
		/// setting or operator selection used to execute a test mode to confirm the execution of machine functions.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.4">v1.4</see></item>
		/// </list>
		/// </remarks>
		DRY_RUN,
		/// <summary>
		/// D-Scale weighting factor on the frequency scale.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.2">v1.2</see></item>
		/// </list>
		/// </remarks>
		D_SCALE,
		/// <summary>
		/// relating to the expiration or end of useful life for a material or other physical item.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.5">v1.5</see></item>
		/// </list>
		/// </remarks>
		EXPIRATION,
		/// <summary>
		/// relating to the first use of a material or other physical item.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.5">v1.5</see></item>
		/// </list>
		/// </remarks>
		FIRST_USE,
		/// <summary>
		/// actions, items, or activities being counted that conform to specification or expectation.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>
		GOOD,
		/// <summary>
		/// relating to or derived from the last <i>observation</i>.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.4">v1.4</see></item>
		/// </list>
		/// </remarks>
		INCREMENTAL,
		/// <summary>
		/// relating to momentary activation of a function or a movement.  <b>DEPRECATION WARNING</b>: May be deprecated in the future.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.3">v1.3</see></item>
		/// </list>
		/// </remarks>
		JOG,
		/// <summary>
		/// indication of the position of a mechanism that may move in a lateral direction.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.4">v1.4</see></item>
		/// </list>
		/// </remarks>
		LATERAL,
		/// <summary>
		/// scale to measure the elasticity of a surface.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.4">v1.4</see></item>
		/// </list>
		/// </remarks>
		LEEB,
		/// <summary>
		/// reference to a length type tool offset variable.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.4">v1.4</see></item>
		/// </list>
		/// </remarks>
		LENGTH,
		/// <summary>
		/// state of the power source.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.1">v1.1</see></item>
		/// </list>
		/// </remarks>
		LINE,
		/// <summary>
		/// direction of motion of a linear motion.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.2">v1.2</see></item>
		/// </list>
		/// </remarks>
		LINEAR,
		/// <summary>
		/// indication that the subparts of a piece of equipment are under load.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.4">v1.4</see></item>
		/// </list>
		/// </remarks>
		LOADED,
		/// <summary>
		/// setting or operator selection that changes the behavior of the controller on a piece of equipment.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.4">v1.4</see></item>
		/// </list>
		/// </remarks>
		MACHINE_AXIS_LOCK,
		/// <summary>
		/// relating to the primary logic or motion program currently being executed.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.5">v1.5</see></item>
		/// </list>
		/// </remarks>
		MAIN,
		/// <summary>
		/// relating to maintenance on the piece of equipment.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.4">v1.4</see></item>
		/// </list>
		/// </remarks>
		MAINTENANCE,
		/// <summary>
		/// indication of the state of an operator controlled interlock that can inhibit the ability to initiate an unclamp action of an electronically controlled chuck.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.3">v1.3</see></item>
		/// </list>
		/// </remarks>
		MANUAL_UNCLAMP,
		/// <summary>
		/// related to the production of a material or other physical item.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.5">v1.5</see></item>
		/// </list>
		/// </remarks>
		MANUFACTURE,
		/// <summary>
		/// maximum value.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.1">v1.1</see></item>
		/// </list>
		/// </remarks>
		MAXIMUM,
		/// <summary>
		/// minimum value.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.1">v1.1</see></item>
		/// </list>
		/// </remarks>
		MINIMUM,
		/// <summary>
		/// scale to measure the resistance to scratching of a surface.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.4">v1.4</see></item>
		/// </list>
		/// </remarks>
		MOHS,
		/// <summary>
		/// indication of the open or closed state of a mechanism.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.4">v1.4</see></item>
		/// </list>
		/// </remarks>
		MOTION,
		/// <summary>
		/// no weighting factor on the frequency scale.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.2">v1.2</see></item>
		/// </list>
		/// </remarks>
		NO_SCALE,
		/// <summary>
		/// piece of equipment that is powered or performing any activity.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.4">v1.4</see></item>
		/// </list>
		/// </remarks>
		OPERATING,
		/// <summary>
		/// relating to the person currently responsible for operating the piece of equipment.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.4">v1.4</see></item>
		/// </list>
		/// </remarks>
		OPERATOR,
		/// <summary>
		/// setting or operator selection that changes the behavior of the controller on a piece of equipment. 
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.4">v1.4</see></item>
		/// </list>
		/// </remarks>
		OPTIONAL_STOP,
		/// <summary>
		/// overridden value.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>
		OVERRIDE,
		/// <summary>
		/// piece of equipment is powered and functioning or <see cref="Component">Component</see> that are required to remain on are powered.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.4">v1.4</see></item>
		/// </list>
		/// </remarks>
		POWERED,
		/// <summary>
		/// main or most important.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.3">v1.3</see></item>
		/// </list>
		/// </remarks>
		PRIMARY,
		/// <summary>
		/// position provided by a measurement probe.  <b>DEPRECATION WARNING</b>: May be deprecated in the future.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.1">v1.1</see></item>
		/// </list>
		/// </remarks>
		PROBE,
		/// <summary>
		/// relating to production of a part or product on a piece of equipment.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.4">v1.4</see></item>
		/// </list>
		/// </remarks>
		PROCESS,
		/// <summary>
		/// directive value without offsets and adjustments.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.3">v1.3</see></item>
		/// </list>
		/// </remarks>
		PROGRAMMED,
		/// <summary>
		/// reference to a radial type tool offset variable.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.4">v1.4</see></item>
		/// </list>
		/// </remarks>
		RADIAL,
		/// <summary>
		/// performing an operation faster or in less time than nominal rate.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.3">v1.3</see></item>
		/// </list>
		/// </remarks>
		RAPID,
		/// <summary>
		/// remaining measure or count of an action, object or activity.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.3">v1.3</see></item>
		/// </list>
		/// </remarks>
		REMAINING,
		/// <summary>
		/// scale to measure the resistance to deformation of a surface.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.4">v1.4</see></item>
		/// </list>
		/// </remarks>
		ROCKWELL,
		/// <summary>
		/// direction of a rotary motion using the right hand rule convention.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.2">v1.2</see></item>
		/// </list>
		/// </remarks>
		ROTARY,
		/// <summary>
		/// identity of a control program that is used to specify the order of execution of other programs.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.5">v1.5</see></item>
		/// </list>
		/// </remarks>
		SCHEDULE,
		/// <summary>
		/// relating to the preparation of a piece of equipment for production or restoring the piece of equipment to a neutral state after production.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.4">v1.4</see></item>
		/// </list>
		/// </remarks>
		SET_UP,
		/// <summary>
		/// scale to measure the resistance to deformation of a surface.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.4">v1.4</see></item>
		/// </list>
		/// </remarks>
		SHORE,
		/// <summary>
		/// setting or operator selection that changes the behavior of the controller on a piece of equipment. 
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.4">v1.4</see></item>
		/// </list>
		/// </remarks>
		SINGLE_BLOCK,
		/// <summary>
		/// standard measure of an object or an action.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.3">v1.3</see></item>
		/// </list>
		/// </remarks>
		STANDARD,
		/// <summary>
		/// boundary when an activity or an event commences.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.5">v1.5</see></item>
		/// </list>
		/// </remarks>
		START,
		/// <summary>
		/// indication of the activation state of a mechanism represented by a <see cref="Composition">Composition</see>.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.4">v1.4</see></item>
		/// </list>
		/// </remarks>
		SWITCHED,
		/// <summary>
		/// goal of the operation or process.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.1">v1.1</see></item>
		/// </list>
		/// </remarks>
		TARGET,
		/// <summary>
		/// relating to the end or completion of an activity or event.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.5">v1.5</see></item>
		/// </list>
		/// </remarks>
		TARGET_COMPLETION,
		/// <summary>
		/// setting or operator selection that changes the behavior of the controller on a piece of equipment.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.4">v1.4</see></item>
		/// </list>
		/// </remarks>
		TOOL_CHANGE_STOP,
		/// <summary>
		/// remaining usable measure of an object or action.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.3">v1.3</see></item>
		/// </list>
		/// </remarks>
		USEABLE,
		/// <summary>
		/// indication of the position of a mechanism that may move in a vertical direction.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.4">v1.4</see></item>
		/// </list>
		/// </remarks>
		VERTICAL,
		/// <summary>
		/// scale to measure the resistance to deformation of a surface.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.4">v1.4</see></item>
		/// </list>
		/// </remarks>
		VICKERS,
		/// <summary>
		/// piece of equipment performing any activity, the equipment is active and performing a function under load or not.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.4">v1.4</see></item>
		/// </list>
		/// </remarks>
		WORKING,
		/// <summary>
		/// IPV4 network address of the <see cref="Component">Component</see>.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.6">v1.6</see></item>
		/// </list>
		/// </remarks>
		IPV4_ADDRESS,
		/// <summary>
		/// IPV6 network address of the <see cref="Component">Component</see>.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.6">v1.6</see></item>
		/// </list>
		/// </remarks>
		IPV6_ADDRESS,
		/// <summary>
		/// Gateway for the <see cref="Component">Component</see> network.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.6">v1.6</see></item>
		/// </list>
		/// </remarks>
		GATEWAY,
		/// <summary>
		/// SubNet mask for the <see cref="Component">Component</see> network. 
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.6">v1.6</see></item>
		/// </list>
		/// </remarks>
		SUBNET_MASK,
		/// <summary>
		/// layer2 Virtual Local Network (VLAN) ID for the <see cref="Component">Component</see> network.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.6">v1.6</see></item>
		/// </list>
		/// </remarks>
		VLAN_ID,
		/// <summary>
		/// Media Access Control Address. The unique physical address of the network hardware.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.6">v1.6</see></item>
		/// </list>
		/// </remarks>
		MAC_ADDRESS,
		/// <summary>
		/// identifies whether the connection type is wireless.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.6">v1.6</see></item>
		/// </list>
		/// </remarks>
		WIRELESS,
		/// <summary>
		/// license code to validate or activate the hardware or software.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.6">v1.6</see></item>
		/// </list>
		/// </remarks>
		LICENSE,
		/// <summary>
		/// version of the hardware or software. 
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.6">v1.6</see></item>
		/// </list>
		/// </remarks>
		VERSION,
		/// <summary>
		/// date the hardware or software was released for general use.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.6">v1.6</see></item>
		/// </list>
		/// </remarks>
		RELEASE_DATE,
		/// <summary>
		/// date the hardware or software was installed.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.6">v1.6</see></item>
		/// </list>
		/// </remarks>
		INSTALL_DATE,
		/// <summary>
		/// corporate identity for the maker of the hardware or software.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.6">v1.6</see></item>
		/// </list>
		/// </remarks>
		MANUFACTURER,
		/// <summary>
		/// universally unique identifier as specified in ISO 11578 or RFC 4122.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.7">v1.7</see></item>
		/// </list>
		/// </remarks>
		UUID,
		/// <summary>
		/// serial number that uniquely identifies a specific part.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.7">v1.7</see></item>
		/// </list>
		/// </remarks>
		SERIAL_NUMBER,
		/// <summary>
		/// material that is used to produce parts.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.7">v1.7</see></item>
		/// </list>
		/// </remarks>
		RAW_MATERIAL,
		/// <summary>
		/// group of parts tracked as a lot.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.7">v1.7</see></item>
		/// </list>
		/// </remarks>
		LOT,
		/// <summary>
		/// group of parts produced in a batch.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.7">v1.7</see></item>
		/// </list>
		/// </remarks>
		BATCH,
		/// <summary>
		/// material heat number.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.7">v1.7</see></item>
		/// </list>
		/// </remarks>
		HEAT_TREAT,
		/// <summary>
		/// particular part design or model.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.7">v1.7</see></item>
		/// </list>
		/// </remarks>
		PART_NUMBER,
		/// <summary>
		/// group of parts having similarities in geometry, manufacturing process, and/or functions.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.7">v1.7</see></item>
		/// </list>
		/// </remarks>
		PART_FAMILY,
		/// <summary>
		/// word or set of words by which a part is known, addressed, or referred to.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.7">v1.7</see></item>
		/// </list>
		/// </remarks>
		PART_NAME,
		/// <summary>
		/// step in the process plan that this occurrence corresponds to. 
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.7">v1.7</see></item>
		/// </list>
		/// </remarks>
		PROCESS_STEP,
		/// <summary>
		/// process plan that a process occurrence belongs to.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.7">v1.7</see></item>
		/// </list>
		/// </remarks>
		PROCESS_PLAN,
		/// <summary>
		/// authorization of a process occurrence.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.7">v1.7</see></item>
		/// </list>
		/// </remarks>
		ORDER_NUMBER,
		/// <summary>
		/// word or set of words by which a process being executed (process occurrence) by the device is known, addressed, or referred to. 
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.7">v1.7</see></item>
		/// </list>
		/// </remarks>
		PROCESS_NAME,
		/// <summary>
		/// reference to a ISO 10303 Executable.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.7">v1.7</see></item>
		/// </list>
		/// </remarks>
		ISO_STEP_EXECUTABLE,
		/// <summary>
		/// associated with the completion of an activity or event.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.5">v1.5</see></item>
		/// </list>
		/// </remarks>
		COMPLETE,
		/// <summary>
		/// relating to logic or motion program currently executing.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.5">v1.5</see></item>
		/// </list>
		/// </remarks>
		ACTIVE,
		/// <summary>
		/// actions or activities that were attempted , but failed to complete or resulted in an unexpected or unacceptable outcome.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.8">v1.8</see></item>
		/// </list>
		/// </remarks>
		FAILED,
		/// <summary>
		/// actions or activities that were attempted, but terminated before they could be completed.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.8">v1.8</see></item>
		/// </list>
		/// </remarks>
		ABORTED,
		/// <summary>
		/// boundary when an activity or an event terminates.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.8">v1.8</see></item>
		/// </list>
		/// </remarks>
		ENDED,
		/// <summary>
		/// amount discarded.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.8">v1.8</see></item>
		/// </list>
		/// </remarks>
		WASTE,
		/// <summary>
		/// amount included in the <i>part</i>.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.8">v1.8</see></item>
		/// </list>
		/// </remarks>
		PART,
		/// <summary>
		/// <i>request</i> by an <see cref="Interface">Interface</see> for a task.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.3">v1.3</see></item>
		/// </list>
		/// </remarks>
		REQUEST,
		/// <summary>
		/// <i>response</i> by an <see cref="Interface">Interface</see> to a <i>request</i> for a task.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.3">v1.3</see></item>
		/// </list>
		/// </remarks>
		RESPONSE,
		/// <summary>
		/// phase or segment of a recipe or program.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_2.0">v2.0</see></item>
		/// </list>
		/// </remarks>
		ACTIVITY,
		/// <summary>
		/// phase of a recipe process.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_2.0">v2.0</see></item>
		/// </list>
		/// </remarks>
		SEGMENT,
		/// <summary>
		/// process as part of product production; can be a subprocess of a larger process.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_2.0">v2.0</see></item>
		/// </list>
		/// </remarks>
		RECIPE,
		/// <summary>
		/// step of a discrete manufacturing process.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_2.0">v2.0</see></item>
		/// </list>
		/// </remarks>
		OPERATION,
		/// <summary>
		/// observed as a binary data type.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_2.2">v2.2</see></item>
		/// </list>
		/// </remarks>
		BINARY,
		/// <summary>
		/// observed as a boolean data type.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_2.2">v2.2</see></item>
		/// </list>
		/// </remarks>
		BOOLEAN,
		/// <summary>
		/// observed as a set containing a restricted number of discrete values where each discrete value is named and unique. <seealso href="https://www.google.com/search?q=ISO 21961:2003, 013&btnI=I">ISO 21961:2003, 013</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_2.2">v2.2</see></item>
		/// </list>
		/// </remarks>
		ENUMERATED,
		/// <summary>
		/// indicated by the presence or existence of something.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_2.2">v2.2</see></item>
		/// </list>
		/// </remarks>
		DETECT,
		/// <summary>
		/// model info of the hardware or software.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_2.3">v2.3</see></item>
		/// </list>
		/// </remarks>
		MODEL,
		/// <summary>
		/// alternate or not primary.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_2.3">v2.3</see></item>
		/// </list>
		/// </remarks>
		SECONDARY,
		/// <summary>
		/// held near at hand and ready for use.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_2.3">v2.3</see></item>
		/// </list>
		/// </remarks>
		STANDBY,
	}

	/// <summary>
	/// View in the MTConnect Model browser <seealso href="https://model.mtconnect.org/#Enumeration___19_0_3_45f01b9_1579563592155_977172_22064">model.mtconnect.org</seealso>
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.3.0.0")]
	public sealed class DataItemSubTypeEnumMetaClass : IEnum
	{
		/// <inheritdoc />
		public string Name => "DataItemSubTypeEnum";
		
		/// <inheritdoc />
		public Type DataType => null;
		
		public Type Instance => typeof(DataItemSubTypeEnum);

		/// <inheritdoc />
		public string NormativeVersion => "1.0";
		
		/// <inheritdoc />
		public string DeprecatedVersion => "";
		
		/// <inheritdoc />
		public string Summary => @"";
		
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
		/// <summary>
		/// relating to or derived in the simplest manner from the fundamental units or measurements.
		/// </summary>
		public ABSOLUTEValue ABSOLUTE => _ABSOLUTE ?? (_ABSOLUTE = new ABSOLUTEValue());

		/// <summary>
		/// relating to or derived in the simplest manner from the fundamental units or measurements.
		/// </summary>
		public sealed class ABSOLUTEValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "ABSOLUTE";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.4";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// relating to or derived in the simplest manner from the fundamental units or measurements.";
		}
		private ACTIONValue _ACTION;
		/// <summary>
		/// indication of the operating state of a mechanism.
		/// </summary>
		public ACTIONValue ACTION => _ACTION ?? (_ACTION = new ACTIONValue());

		/// <summary>
		/// indication of the operating state of a mechanism.
		/// </summary>
		public sealed class ACTIONValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "ACTION";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.4";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// indication of the operating state of a mechanism.";
		}
		private ACTUALValue _ACTUAL;
		/// <summary>
		/// measured or reported value of an <i>observation</i>.
		/// </summary>
		public ACTUALValue ACTUAL => _ACTUAL ?? (_ACTUAL = new ACTUALValue());

		/// <summary>
		/// measured or reported value of an <i>observation</i>.
		/// </summary>
		public sealed class ACTUALValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "ACTUAL";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.0";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// measured or reported value of an <i>observation</i>.";
		}
		private ALLValue _ALL;
		/// <summary>
		/// all actions, items, or activities being counted independent of the outcome.
		/// </summary>
		public ALLValue ALL => _ALL ?? (_ALL = new ALLValue());

		/// <summary>
		/// all actions, items, or activities being counted independent of the outcome.
		/// </summary>
		public sealed class ALLValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "ALL";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.0";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// all actions, items, or activities being counted independent of the outcome.";
		}
		private ALTERNATINGValue _ALTERNATING;
		/// <summary>
		/// measurement of alternating voltage or current. If not specified further in statistic, defaults to RMS voltage.   <b>DEPRECATED</b> in <i>Version 1.6</i>s.
		/// </summary>
		public ALTERNATINGValue ALTERNATING => _ALTERNATING ?? (_ALTERNATING = new ALTERNATINGValue());

		/// <summary>
		/// measurement of alternating voltage or current. If not specified further in statistic, defaults to RMS voltage.   <b>DEPRECATED</b> in <i>Version 1.6</i>s.
		/// </summary>
		public sealed class ALTERNATINGValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "ALTERNATING";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.2";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "1.6";
			
			/// <inheritdoc />
			public string Summary => @"/// measurement of alternating voltage or current. If not specified further in statistic, defaults to RMS voltage.   <b>DEPRECATED</b> in <i>Version 1.6</i>s.";
		}
		private A_SCALEValue _A_SCALE;
		/// <summary>
		/// A-Scale weighting factor on the frequency scale.
		/// </summary>
		public A_SCALEValue A_SCALE => _A_SCALE ?? (_A_SCALE = new A_SCALEValue());

		/// <summary>
		/// A-Scale weighting factor on the frequency scale.
		/// </summary>
		public sealed class A_SCALEValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "A_SCALE";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.2";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// A-Scale weighting factor on the frequency scale.";
		}
		private AUXILIARYValue _AUXILIARY;
		/// <summary>
		/// when multiple locations on a piece of bar stock being feed by a bar feeder are referenced as the indication of whether the end of that piece of bar stock has been reached.
		/// </summary>
		public AUXILIARYValue AUXILIARY => _AUXILIARY ?? (_AUXILIARY = new AUXILIARYValue());

		/// <summary>
		/// when multiple locations on a piece of bar stock being feed by a bar feeder are referenced as the indication of whether the end of that piece of bar stock has been reached.
		/// </summary>
		public sealed class AUXILIARYValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "AUXILIARY";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.3";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// when multiple locations on a piece of bar stock being feed by a bar feeder are referenced as the indication of whether the end of that piece of bar stock has been reached.";
		}
		private BADValue _BAD;
		/// <summary>
		/// actions, items, or activities being counted that do not conform to specification or expectation.
		/// </summary>
		public BADValue BAD => _BAD ?? (_BAD = new BADValue());

		/// <summary>
		/// actions, items, or activities being counted that do not conform to specification or expectation.
		/// </summary>
		public sealed class BADValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "BAD";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.0";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// actions, items, or activities being counted that do not conform to specification or expectation.";
		}
		private BRINELLValue _BRINELL;
		/// <summary>
		/// scale to measure the resistance to deformation of a surface.
		/// </summary>
		public BRINELLValue BRINELL => _BRINELL ?? (_BRINELL = new BRINELLValue());

		/// <summary>
		/// scale to measure the resistance to deformation of a surface.
		/// </summary>
		public sealed class BRINELLValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "BRINELL";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.4";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// scale to measure the resistance to deformation of a surface.";
		}
		private B_SCALEValue _B_SCALE;
		/// <summary>
		/// B-Scale weighting factor on the frequency scale.
		/// </summary>
		public B_SCALEValue B_SCALE => _B_SCALE ?? (_B_SCALE = new B_SCALEValue());

		/// <summary>
		/// B-Scale weighting factor on the frequency scale.
		/// </summary>
		public sealed class B_SCALEValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "B_SCALE";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.2";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// B-Scale weighting factor on the frequency scale.";
		}
		private COMMANDEDValue _COMMANDED;
		/// <summary>
		/// directive value including adjustments such as an offset or overrides.
		/// </summary>
		public COMMANDEDValue COMMANDED => _COMMANDED ?? (_COMMANDED = new COMMANDEDValue());

		/// <summary>
		/// directive value including adjustments such as an offset or overrides.
		/// </summary>
		public sealed class COMMANDEDValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "COMMANDED";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.0";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// directive value including adjustments such as an offset or overrides.";
		}
		private CONSUMEDValue _CONSUMED;
		/// <summary>
		/// amount of material consumed from an object or container during a manufacturing process.
		/// </summary>
		public CONSUMEDValue CONSUMED => _CONSUMED ?? (_CONSUMED = new CONSUMEDValue());

		/// <summary>
		/// amount of material consumed from an object or container during a manufacturing process.
		/// </summary>
		public sealed class CONSUMEDValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "CONSUMED";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.5";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// amount of material consumed from an object or container during a manufacturing process.";
		}
		private CONTROLValue _CONTROL;
		/// <summary>
		/// state of the enabling signal or control logic that enables or disables the function or operation of the entity.
		/// </summary>
		public CONTROLValue CONTROL => _CONTROL ?? (_CONTROL = new CONTROLValue());

		/// <summary>
		/// state of the enabling signal or control logic that enables or disables the function or operation of the entity.
		/// </summary>
		public sealed class CONTROLValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "CONTROL";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.1";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// state of the enabling signal or control logic that enables or disables the function or operation of the entity.";
		}
		private C_SCALEValue _C_SCALE;
		/// <summary>
		/// C-Scale weighting factor on the frequency scale.
		/// </summary>
		public C_SCALEValue C_SCALE => _C_SCALE ?? (_C_SCALE = new C_SCALEValue());

		/// <summary>
		/// C-Scale weighting factor on the frequency scale.
		/// </summary>
		public sealed class C_SCALEValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "C_SCALE";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.2";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// C-Scale weighting factor on the frequency scale.";
		}
		private DELAYValue _DELAY;
		/// <summary>
		/// elapsed time of a temporary halt of action.
		/// </summary>
		public DELAYValue DELAY => _DELAY ?? (_DELAY = new DELAYValue());

		/// <summary>
		/// elapsed time of a temporary halt of action.
		/// </summary>
		public sealed class DELAYValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "DELAY";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.4";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// elapsed time of a temporary halt of action.";
		}
		private DIRECTValue _DIRECT;
		/// <summary>
		/// DC current or voltage.  <b>DEPRECATED</b> in <i>Version 1.6</i>s.
		/// </summary>
		public DIRECTValue DIRECT => _DIRECT ?? (_DIRECT = new DIRECTValue());

		/// <summary>
		/// DC current or voltage.  <b>DEPRECATED</b> in <i>Version 1.6</i>s.
		/// </summary>
		public sealed class DIRECTValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "DIRECT";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.2";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "1.6";
			
			/// <inheritdoc />
			public string Summary => @"/// DC current or voltage.  <b>DEPRECATED</b> in <i>Version 1.6</i>s.";
		}
		private DRY_RUNValue _DRY_RUN;
		/// <summary>
		/// setting or operator selection used to execute a test mode to confirm the execution of machine functions.
		/// </summary>
		public DRY_RUNValue DRY_RUN => _DRY_RUN ?? (_DRY_RUN = new DRY_RUNValue());

		/// <summary>
		/// setting or operator selection used to execute a test mode to confirm the execution of machine functions.
		/// </summary>
		public sealed class DRY_RUNValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "DRY_RUN";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.4";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// setting or operator selection used to execute a test mode to confirm the execution of machine functions.";
		}
		private D_SCALEValue _D_SCALE;
		/// <summary>
		/// D-Scale weighting factor on the frequency scale.
		/// </summary>
		public D_SCALEValue D_SCALE => _D_SCALE ?? (_D_SCALE = new D_SCALEValue());

		/// <summary>
		/// D-Scale weighting factor on the frequency scale.
		/// </summary>
		public sealed class D_SCALEValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "D_SCALE";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.2";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// D-Scale weighting factor on the frequency scale.";
		}
		private EXPIRATIONValue _EXPIRATION;
		/// <summary>
		/// relating to the expiration or end of useful life for a material or other physical item.
		/// </summary>
		public EXPIRATIONValue EXPIRATION => _EXPIRATION ?? (_EXPIRATION = new EXPIRATIONValue());

		/// <summary>
		/// relating to the expiration or end of useful life for a material or other physical item.
		/// </summary>
		public sealed class EXPIRATIONValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "EXPIRATION";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.5";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// relating to the expiration or end of useful life for a material or other physical item.";
		}
		private FIRST_USEValue _FIRST_USE;
		/// <summary>
		/// relating to the first use of a material or other physical item.
		/// </summary>
		public FIRST_USEValue FIRST_USE => _FIRST_USE ?? (_FIRST_USE = new FIRST_USEValue());

		/// <summary>
		/// relating to the first use of a material or other physical item.
		/// </summary>
		public sealed class FIRST_USEValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "FIRST_USE";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.5";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// relating to the first use of a material or other physical item.";
		}
		private GOODValue _GOOD;
		/// <summary>
		/// actions, items, or activities being counted that conform to specification or expectation.
		/// </summary>
		public GOODValue GOOD => _GOOD ?? (_GOOD = new GOODValue());

		/// <summary>
		/// actions, items, or activities being counted that conform to specification or expectation.
		/// </summary>
		public sealed class GOODValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "GOOD";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.0";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// actions, items, or activities being counted that conform to specification or expectation.";
		}
		private INCREMENTALValue _INCREMENTAL;
		/// <summary>
		/// relating to or derived from the last <i>observation</i>.
		/// </summary>
		public INCREMENTALValue INCREMENTAL => _INCREMENTAL ?? (_INCREMENTAL = new INCREMENTALValue());

		/// <summary>
		/// relating to or derived from the last <i>observation</i>.
		/// </summary>
		public sealed class INCREMENTALValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "INCREMENTAL";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.4";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// relating to or derived from the last <i>observation</i>.";
		}
		private JOGValue _JOG;
		/// <summary>
		/// relating to momentary activation of a function or a movement.  <b>DEPRECATION WARNING</b>: May be deprecated in the future.
		/// </summary>
		public JOGValue JOG => _JOG ?? (_JOG = new JOGValue());

		/// <summary>
		/// relating to momentary activation of a function or a movement.  <b>DEPRECATION WARNING</b>: May be deprecated in the future.
		/// </summary>
		public sealed class JOGValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "JOG";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.3";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// relating to momentary activation of a function or a movement.  <b>DEPRECATION WARNING</b>: May be deprecated in the future.";
		}
		private LATERALValue _LATERAL;
		/// <summary>
		/// indication of the position of a mechanism that may move in a lateral direction.
		/// </summary>
		public LATERALValue LATERAL => _LATERAL ?? (_LATERAL = new LATERALValue());

		/// <summary>
		/// indication of the position of a mechanism that may move in a lateral direction.
		/// </summary>
		public sealed class LATERALValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "LATERAL";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.4";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// indication of the position of a mechanism that may move in a lateral direction.";
		}
		private LEEBValue _LEEB;
		/// <summary>
		/// scale to measure the elasticity of a surface.
		/// </summary>
		public LEEBValue LEEB => _LEEB ?? (_LEEB = new LEEBValue());

		/// <summary>
		/// scale to measure the elasticity of a surface.
		/// </summary>
		public sealed class LEEBValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "LEEB";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.4";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// scale to measure the elasticity of a surface.";
		}
		private LENGTHValue _LENGTH;
		/// <summary>
		/// reference to a length type tool offset variable.
		/// </summary>
		public LENGTHValue LENGTH => _LENGTH ?? (_LENGTH = new LENGTHValue());

		/// <summary>
		/// reference to a length type tool offset variable.
		/// </summary>
		public sealed class LENGTHValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "LENGTH";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.4";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// reference to a length type tool offset variable.";
		}
		private LINEValue _LINE;
		/// <summary>
		/// state of the power source.
		/// </summary>
		public LINEValue LINE => _LINE ?? (_LINE = new LINEValue());

		/// <summary>
		/// state of the power source.
		/// </summary>
		public sealed class LINEValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "LINE";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.1";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// state of the power source.";
		}
		private LINEARValue _LINEAR;
		/// <summary>
		/// direction of motion of a linear motion.
		/// </summary>
		public LINEARValue LINEAR => _LINEAR ?? (_LINEAR = new LINEARValue());

		/// <summary>
		/// direction of motion of a linear motion.
		/// </summary>
		public sealed class LINEARValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "LINEAR";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.2";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// direction of motion of a linear motion.";
		}
		private LOADEDValue _LOADED;
		/// <summary>
		/// indication that the subparts of a piece of equipment are under load.
		/// </summary>
		public LOADEDValue LOADED => _LOADED ?? (_LOADED = new LOADEDValue());

		/// <summary>
		/// indication that the subparts of a piece of equipment are under load.
		/// </summary>
		public sealed class LOADEDValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "LOADED";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.4";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// indication that the subparts of a piece of equipment are under load.";
		}
		private MACHINE_AXIS_LOCKValue _MACHINE_AXIS_LOCK;
		/// <summary>
		/// setting or operator selection that changes the behavior of the controller on a piece of equipment.
		/// </summary>
		public MACHINE_AXIS_LOCKValue MACHINE_AXIS_LOCK => _MACHINE_AXIS_LOCK ?? (_MACHINE_AXIS_LOCK = new MACHINE_AXIS_LOCKValue());

		/// <summary>
		/// setting or operator selection that changes the behavior of the controller on a piece of equipment.
		/// </summary>
		public sealed class MACHINE_AXIS_LOCKValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "MACHINE_AXIS_LOCK";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.4";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// setting or operator selection that changes the behavior of the controller on a piece of equipment.";
		}
		private MAINValue _MAIN;
		/// <summary>
		/// relating to the primary logic or motion program currently being executed.
		/// </summary>
		public MAINValue MAIN => _MAIN ?? (_MAIN = new MAINValue());

		/// <summary>
		/// relating to the primary logic or motion program currently being executed.
		/// </summary>
		public sealed class MAINValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "MAIN";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.5";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// relating to the primary logic or motion program currently being executed.";
		}
		private MAINTENANCEValue _MAINTENANCE;
		/// <summary>
		/// relating to maintenance on the piece of equipment.
		/// </summary>
		public MAINTENANCEValue MAINTENANCE => _MAINTENANCE ?? (_MAINTENANCE = new MAINTENANCEValue());

		/// <summary>
		/// relating to maintenance on the piece of equipment.
		/// </summary>
		public sealed class MAINTENANCEValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "MAINTENANCE";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.4";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// relating to maintenance on the piece of equipment.";
		}
		private MANUAL_UNCLAMPValue _MANUAL_UNCLAMP;
		/// <summary>
		/// indication of the state of an operator controlled interlock that can inhibit the ability to initiate an unclamp action of an electronically controlled chuck.
		/// </summary>
		public MANUAL_UNCLAMPValue MANUAL_UNCLAMP => _MANUAL_UNCLAMP ?? (_MANUAL_UNCLAMP = new MANUAL_UNCLAMPValue());

		/// <summary>
		/// indication of the state of an operator controlled interlock that can inhibit the ability to initiate an unclamp action of an electronically controlled chuck.
		/// </summary>
		public sealed class MANUAL_UNCLAMPValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "MANUAL_UNCLAMP";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.3";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// indication of the state of an operator controlled interlock that can inhibit the ability to initiate an unclamp action of an electronically controlled chuck.";
		}
		private MANUFACTUREValue _MANUFACTURE;
		/// <summary>
		/// related to the production of a material or other physical item.
		/// </summary>
		public MANUFACTUREValue MANUFACTURE => _MANUFACTURE ?? (_MANUFACTURE = new MANUFACTUREValue());

		/// <summary>
		/// related to the production of a material or other physical item.
		/// </summary>
		public sealed class MANUFACTUREValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "MANUFACTURE";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.5";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// related to the production of a material or other physical item.";
		}
		private MAXIMUMValue _MAXIMUM;
		/// <summary>
		/// maximum value.
		/// </summary>
		public MAXIMUMValue MAXIMUM => _MAXIMUM ?? (_MAXIMUM = new MAXIMUMValue());

		/// <summary>
		/// maximum value.
		/// </summary>
		public sealed class MAXIMUMValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "MAXIMUM";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.1";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// maximum value.";
		}
		private MINIMUMValue _MINIMUM;
		/// <summary>
		/// minimum value.
		/// </summary>
		public MINIMUMValue MINIMUM => _MINIMUM ?? (_MINIMUM = new MINIMUMValue());

		/// <summary>
		/// minimum value.
		/// </summary>
		public sealed class MINIMUMValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "MINIMUM";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.1";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// minimum value.";
		}
		private MOHSValue _MOHS;
		/// <summary>
		/// scale to measure the resistance to scratching of a surface.
		/// </summary>
		public MOHSValue MOHS => _MOHS ?? (_MOHS = new MOHSValue());

		/// <summary>
		/// scale to measure the resistance to scratching of a surface.
		/// </summary>
		public sealed class MOHSValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "MOHS";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.4";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// scale to measure the resistance to scratching of a surface.";
		}
		private MOTIONValue _MOTION;
		/// <summary>
		/// indication of the open or closed state of a mechanism.
		/// </summary>
		public MOTIONValue MOTION => _MOTION ?? (_MOTION = new MOTIONValue());

		/// <summary>
		/// indication of the open or closed state of a mechanism.
		/// </summary>
		public sealed class MOTIONValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "MOTION";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.4";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// indication of the open or closed state of a mechanism.";
		}
		private NO_SCALEValue _NO_SCALE;
		/// <summary>
		/// no weighting factor on the frequency scale.
		/// </summary>
		public NO_SCALEValue NO_SCALE => _NO_SCALE ?? (_NO_SCALE = new NO_SCALEValue());

		/// <summary>
		/// no weighting factor on the frequency scale.
		/// </summary>
		public sealed class NO_SCALEValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "NO_SCALE";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.2";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// no weighting factor on the frequency scale.";
		}
		private OPERATINGValue _OPERATING;
		/// <summary>
		/// piece of equipment that is powered or performing any activity.
		/// </summary>
		public OPERATINGValue OPERATING => _OPERATING ?? (_OPERATING = new OPERATINGValue());

		/// <summary>
		/// piece of equipment that is powered or performing any activity.
		/// </summary>
		public sealed class OPERATINGValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "OPERATING";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.4";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// piece of equipment that is powered or performing any activity.";
		}
		private OPERATORValue _OPERATOR;
		/// <summary>
		/// relating to the person currently responsible for operating the piece of equipment.
		/// </summary>
		public OPERATORValue OPERATOR => _OPERATOR ?? (_OPERATOR = new OPERATORValue());

		/// <summary>
		/// relating to the person currently responsible for operating the piece of equipment.
		/// </summary>
		public sealed class OPERATORValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "OPERATOR";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.4";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// relating to the person currently responsible for operating the piece of equipment.";
		}
		private OPTIONAL_STOPValue _OPTIONAL_STOP;
		/// <summary>
		/// setting or operator selection that changes the behavior of the controller on a piece of equipment. 
		/// </summary>
		public OPTIONAL_STOPValue OPTIONAL_STOP => _OPTIONAL_STOP ?? (_OPTIONAL_STOP = new OPTIONAL_STOPValue());

		/// <summary>
		/// setting or operator selection that changes the behavior of the controller on a piece of equipment. 
		/// </summary>
		public sealed class OPTIONAL_STOPValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "OPTIONAL_STOP";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.4";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// setting or operator selection that changes the behavior of the controller on a piece of equipment. ";
		}
		private OVERRIDEValue _OVERRIDE;
		/// <summary>
		/// overridden value.
		/// </summary>
		public OVERRIDEValue OVERRIDE => _OVERRIDE ?? (_OVERRIDE = new OVERRIDEValue());

		/// <summary>
		/// overridden value.
		/// </summary>
		public sealed class OVERRIDEValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "OVERRIDE";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.0";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// overridden value.";
		}
		private POWEREDValue _POWERED;
		/// <summary>
		/// piece of equipment is powered and functioning or <see cref="Component">Component</see> that are required to remain on are powered.
		/// </summary>
		public POWEREDValue POWERED => _POWERED ?? (_POWERED = new POWEREDValue());

		/// <summary>
		/// piece of equipment is powered and functioning or <see cref="Component">Component</see> that are required to remain on are powered.
		/// </summary>
		public sealed class POWEREDValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "POWERED";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.4";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// piece of equipment is powered and functioning or <see cref=""Component"">Component</see> that are required to remain on are powered.";
		}
		private PRIMARYValue _PRIMARY;
		/// <summary>
		/// main or most important.
		/// </summary>
		public PRIMARYValue PRIMARY => _PRIMARY ?? (_PRIMARY = new PRIMARYValue());

		/// <summary>
		/// main or most important.
		/// </summary>
		public sealed class PRIMARYValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "PRIMARY";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.3";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// main or most important.";
		}
		private PROBEValue _PROBE;
		/// <summary>
		/// position provided by a measurement probe.  <b>DEPRECATION WARNING</b>: May be deprecated in the future.
		/// </summary>
		public PROBEValue PROBE => _PROBE ?? (_PROBE = new PROBEValue());

		/// <summary>
		/// position provided by a measurement probe.  <b>DEPRECATION WARNING</b>: May be deprecated in the future.
		/// </summary>
		public sealed class PROBEValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "PROBE";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.1";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// position provided by a measurement probe.  <b>DEPRECATION WARNING</b>: May be deprecated in the future.";
		}
		private PROCESSValue _PROCESS;
		/// <summary>
		/// relating to production of a part or product on a piece of equipment.
		/// </summary>
		public PROCESSValue PROCESS => _PROCESS ?? (_PROCESS = new PROCESSValue());

		/// <summary>
		/// relating to production of a part or product on a piece of equipment.
		/// </summary>
		public sealed class PROCESSValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "PROCESS";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.4";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// relating to production of a part or product on a piece of equipment.";
		}
		private PROGRAMMEDValue _PROGRAMMED;
		/// <summary>
		/// directive value without offsets and adjustments.
		/// </summary>
		public PROGRAMMEDValue PROGRAMMED => _PROGRAMMED ?? (_PROGRAMMED = new PROGRAMMEDValue());

		/// <summary>
		/// directive value without offsets and adjustments.
		/// </summary>
		public sealed class PROGRAMMEDValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "PROGRAMMED";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.3";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// directive value without offsets and adjustments.";
		}
		private RADIALValue _RADIAL;
		/// <summary>
		/// reference to a radial type tool offset variable.
		/// </summary>
		public RADIALValue RADIAL => _RADIAL ?? (_RADIAL = new RADIALValue());

		/// <summary>
		/// reference to a radial type tool offset variable.
		/// </summary>
		public sealed class RADIALValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "RADIAL";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.4";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// reference to a radial type tool offset variable.";
		}
		private RAPIDValue _RAPID;
		/// <summary>
		/// performing an operation faster or in less time than nominal rate.
		/// </summary>
		public RAPIDValue RAPID => _RAPID ?? (_RAPID = new RAPIDValue());

		/// <summary>
		/// performing an operation faster or in less time than nominal rate.
		/// </summary>
		public sealed class RAPIDValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "RAPID";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.3";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// performing an operation faster or in less time than nominal rate.";
		}
		private REMAININGValue _REMAINING;
		/// <summary>
		/// remaining measure or count of an action, object or activity.
		/// </summary>
		public REMAININGValue REMAINING => _REMAINING ?? (_REMAINING = new REMAININGValue());

		/// <summary>
		/// remaining measure or count of an action, object or activity.
		/// </summary>
		public sealed class REMAININGValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "REMAINING";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.3";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// remaining measure or count of an action, object or activity.";
		}
		private ROCKWELLValue _ROCKWELL;
		/// <summary>
		/// scale to measure the resistance to deformation of a surface.
		/// </summary>
		public ROCKWELLValue ROCKWELL => _ROCKWELL ?? (_ROCKWELL = new ROCKWELLValue());

		/// <summary>
		/// scale to measure the resistance to deformation of a surface.
		/// </summary>
		public sealed class ROCKWELLValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "ROCKWELL";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.4";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// scale to measure the resistance to deformation of a surface.";
		}
		private ROTARYValue _ROTARY;
		/// <summary>
		/// direction of a rotary motion using the right hand rule convention.
		/// </summary>
		public ROTARYValue ROTARY => _ROTARY ?? (_ROTARY = new ROTARYValue());

		/// <summary>
		/// direction of a rotary motion using the right hand rule convention.
		/// </summary>
		public sealed class ROTARYValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "ROTARY";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.2";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// direction of a rotary motion using the right hand rule convention.";
		}
		private SCHEDULEValue _SCHEDULE;
		/// <summary>
		/// identity of a control program that is used to specify the order of execution of other programs.
		/// </summary>
		public SCHEDULEValue SCHEDULE => _SCHEDULE ?? (_SCHEDULE = new SCHEDULEValue());

		/// <summary>
		/// identity of a control program that is used to specify the order of execution of other programs.
		/// </summary>
		public sealed class SCHEDULEValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "SCHEDULE";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.5";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// identity of a control program that is used to specify the order of execution of other programs.";
		}
		private SET_UPValue _SET_UP;
		/// <summary>
		/// relating to the preparation of a piece of equipment for production or restoring the piece of equipment to a neutral state after production.
		/// </summary>
		public SET_UPValue SET_UP => _SET_UP ?? (_SET_UP = new SET_UPValue());

		/// <summary>
		/// relating to the preparation of a piece of equipment for production or restoring the piece of equipment to a neutral state after production.
		/// </summary>
		public sealed class SET_UPValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "SET_UP";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.4";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// relating to the preparation of a piece of equipment for production or restoring the piece of equipment to a neutral state after production.";
		}
		private SHOREValue _SHORE;
		/// <summary>
		/// scale to measure the resistance to deformation of a surface.
		/// </summary>
		public SHOREValue SHORE => _SHORE ?? (_SHORE = new SHOREValue());

		/// <summary>
		/// scale to measure the resistance to deformation of a surface.
		/// </summary>
		public sealed class SHOREValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "SHORE";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.4";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// scale to measure the resistance to deformation of a surface.";
		}
		private SINGLE_BLOCKValue _SINGLE_BLOCK;
		/// <summary>
		/// setting or operator selection that changes the behavior of the controller on a piece of equipment. 
		/// </summary>
		public SINGLE_BLOCKValue SINGLE_BLOCK => _SINGLE_BLOCK ?? (_SINGLE_BLOCK = new SINGLE_BLOCKValue());

		/// <summary>
		/// setting or operator selection that changes the behavior of the controller on a piece of equipment. 
		/// </summary>
		public sealed class SINGLE_BLOCKValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "SINGLE_BLOCK";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.4";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// setting or operator selection that changes the behavior of the controller on a piece of equipment. ";
		}
		private STANDARDValue _STANDARD;
		/// <summary>
		/// standard measure of an object or an action.
		/// </summary>
		public STANDARDValue STANDARD => _STANDARD ?? (_STANDARD = new STANDARDValue());

		/// <summary>
		/// standard measure of an object or an action.
		/// </summary>
		public sealed class STANDARDValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "STANDARD";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.3";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// standard measure of an object or an action.";
		}
		private STARTValue _START;
		/// <summary>
		/// boundary when an activity or an event commences.
		/// </summary>
		public STARTValue START => _START ?? (_START = new STARTValue());

		/// <summary>
		/// boundary when an activity or an event commences.
		/// </summary>
		public sealed class STARTValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "START";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.5";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// boundary when an activity or an event commences.";
		}
		private SWITCHEDValue _SWITCHED;
		/// <summary>
		/// indication of the activation state of a mechanism represented by a <see cref="Composition">Composition</see>.
		/// </summary>
		public SWITCHEDValue SWITCHED => _SWITCHED ?? (_SWITCHED = new SWITCHEDValue());

		/// <summary>
		/// indication of the activation state of a mechanism represented by a <see cref="Composition">Composition</see>.
		/// </summary>
		public sealed class SWITCHEDValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "SWITCHED";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.4";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// indication of the activation state of a mechanism represented by a <see cref=""Composition"">Composition</see>.";
		}
		private TARGETValue _TARGET;
		/// <summary>
		/// goal of the operation or process.
		/// </summary>
		public TARGETValue TARGET => _TARGET ?? (_TARGET = new TARGETValue());

		/// <summary>
		/// goal of the operation or process.
		/// </summary>
		public sealed class TARGETValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "TARGET";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.1";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// goal of the operation or process.";
		}
		private TARGET_COMPLETIONValue _TARGET_COMPLETION;
		/// <summary>
		/// relating to the end or completion of an activity or event.
		/// </summary>
		public TARGET_COMPLETIONValue TARGET_COMPLETION => _TARGET_COMPLETION ?? (_TARGET_COMPLETION = new TARGET_COMPLETIONValue());

		/// <summary>
		/// relating to the end or completion of an activity or event.
		/// </summary>
		public sealed class TARGET_COMPLETIONValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "TARGET_COMPLETION";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.5";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// relating to the end or completion of an activity or event.";
		}
		private TOOL_CHANGE_STOPValue _TOOL_CHANGE_STOP;
		/// <summary>
		/// setting or operator selection that changes the behavior of the controller on a piece of equipment.
		/// </summary>
		public TOOL_CHANGE_STOPValue TOOL_CHANGE_STOP => _TOOL_CHANGE_STOP ?? (_TOOL_CHANGE_STOP = new TOOL_CHANGE_STOPValue());

		/// <summary>
		/// setting or operator selection that changes the behavior of the controller on a piece of equipment.
		/// </summary>
		public sealed class TOOL_CHANGE_STOPValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "TOOL_CHANGE_STOP";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.4";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// setting or operator selection that changes the behavior of the controller on a piece of equipment.";
		}
		private USEABLEValue _USEABLE;
		/// <summary>
		/// remaining usable measure of an object or action.
		/// </summary>
		public USEABLEValue USEABLE => _USEABLE ?? (_USEABLE = new USEABLEValue());

		/// <summary>
		/// remaining usable measure of an object or action.
		/// </summary>
		public sealed class USEABLEValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "USEABLE";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.3";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// remaining usable measure of an object or action.";
		}
		private VERTICALValue _VERTICAL;
		/// <summary>
		/// indication of the position of a mechanism that may move in a vertical direction.
		/// </summary>
		public VERTICALValue VERTICAL => _VERTICAL ?? (_VERTICAL = new VERTICALValue());

		/// <summary>
		/// indication of the position of a mechanism that may move in a vertical direction.
		/// </summary>
		public sealed class VERTICALValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "VERTICAL";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.4";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// indication of the position of a mechanism that may move in a vertical direction.";
		}
		private VICKERSValue _VICKERS;
		/// <summary>
		/// scale to measure the resistance to deformation of a surface.
		/// </summary>
		public VICKERSValue VICKERS => _VICKERS ?? (_VICKERS = new VICKERSValue());

		/// <summary>
		/// scale to measure the resistance to deformation of a surface.
		/// </summary>
		public sealed class VICKERSValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "VICKERS";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.4";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// scale to measure the resistance to deformation of a surface.";
		}
		private WORKINGValue _WORKING;
		/// <summary>
		/// piece of equipment performing any activity, the equipment is active and performing a function under load or not.
		/// </summary>
		public WORKINGValue WORKING => _WORKING ?? (_WORKING = new WORKINGValue());

		/// <summary>
		/// piece of equipment performing any activity, the equipment is active and performing a function under load or not.
		/// </summary>
		public sealed class WORKINGValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "WORKING";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.4";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// piece of equipment performing any activity, the equipment is active and performing a function under load or not.";
		}
		private IPV4_ADDRESSValue _IPV4_ADDRESS;
		/// <summary>
		/// IPV4 network address of the <see cref="Component">Component</see>.
		/// </summary>
		public IPV4_ADDRESSValue IPV4_ADDRESS => _IPV4_ADDRESS ?? (_IPV4_ADDRESS = new IPV4_ADDRESSValue());

		/// <summary>
		/// IPV4 network address of the <see cref="Component">Component</see>.
		/// </summary>
		public sealed class IPV4_ADDRESSValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "IPV4_ADDRESS";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.6";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// IPV4 network address of the <see cref=""Component"">Component</see>.";
		}
		private IPV6_ADDRESSValue _IPV6_ADDRESS;
		/// <summary>
		/// IPV6 network address of the <see cref="Component">Component</see>.
		/// </summary>
		public IPV6_ADDRESSValue IPV6_ADDRESS => _IPV6_ADDRESS ?? (_IPV6_ADDRESS = new IPV6_ADDRESSValue());

		/// <summary>
		/// IPV6 network address of the <see cref="Component">Component</see>.
		/// </summary>
		public sealed class IPV6_ADDRESSValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "IPV6_ADDRESS";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.6";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// IPV6 network address of the <see cref=""Component"">Component</see>.";
		}
		private GATEWAYValue _GATEWAY;
		/// <summary>
		/// Gateway for the <see cref="Component">Component</see> network.
		/// </summary>
		public GATEWAYValue GATEWAY => _GATEWAY ?? (_GATEWAY = new GATEWAYValue());

		/// <summary>
		/// Gateway for the <see cref="Component">Component</see> network.
		/// </summary>
		public sealed class GATEWAYValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "GATEWAY";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.6";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// Gateway for the <see cref=""Component"">Component</see> network.";
		}
		private SUBNET_MASKValue _SUBNET_MASK;
		/// <summary>
		/// SubNet mask for the <see cref="Component">Component</see> network. 
		/// </summary>
		public SUBNET_MASKValue SUBNET_MASK => _SUBNET_MASK ?? (_SUBNET_MASK = new SUBNET_MASKValue());

		/// <summary>
		/// SubNet mask for the <see cref="Component">Component</see> network. 
		/// </summary>
		public sealed class SUBNET_MASKValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "SUBNET_MASK";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.6";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// SubNet mask for the <see cref=""Component"">Component</see> network. ";
		}
		private VLAN_IDValue _VLAN_ID;
		/// <summary>
		/// layer2 Virtual Local Network (VLAN) ID for the <see cref="Component">Component</see> network.
		/// </summary>
		public VLAN_IDValue VLAN_ID => _VLAN_ID ?? (_VLAN_ID = new VLAN_IDValue());

		/// <summary>
		/// layer2 Virtual Local Network (VLAN) ID for the <see cref="Component">Component</see> network.
		/// </summary>
		public sealed class VLAN_IDValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "VLAN_ID";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.6";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// layer2 Virtual Local Network (VLAN) ID for the <see cref=""Component"">Component</see> network.";
		}
		private MAC_ADDRESSValue _MAC_ADDRESS;
		/// <summary>
		/// Media Access Control Address. The unique physical address of the network hardware.
		/// </summary>
		public MAC_ADDRESSValue MAC_ADDRESS => _MAC_ADDRESS ?? (_MAC_ADDRESS = new MAC_ADDRESSValue());

		/// <summary>
		/// Media Access Control Address. The unique physical address of the network hardware.
		/// </summary>
		public sealed class MAC_ADDRESSValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "MAC_ADDRESS";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.6";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// Media Access Control Address. The unique physical address of the network hardware.";
		}
		private WIRELESSValue _WIRELESS;
		/// <summary>
		/// identifies whether the connection type is wireless.
		/// </summary>
		public WIRELESSValue WIRELESS => _WIRELESS ?? (_WIRELESS = new WIRELESSValue());

		/// <summary>
		/// identifies whether the connection type is wireless.
		/// </summary>
		public sealed class WIRELESSValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "WIRELESS";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.6";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// identifies whether the connection type is wireless.";
		}
		private LICENSEValue _LICENSE;
		/// <summary>
		/// license code to validate or activate the hardware or software.
		/// </summary>
		public LICENSEValue LICENSE => _LICENSE ?? (_LICENSE = new LICENSEValue());

		/// <summary>
		/// license code to validate or activate the hardware or software.
		/// </summary>
		public sealed class LICENSEValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "LICENSE";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.6";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// license code to validate or activate the hardware or software.";
		}
		private VERSIONValue _VERSION;
		/// <summary>
		/// version of the hardware or software. 
		/// </summary>
		public VERSIONValue VERSION => _VERSION ?? (_VERSION = new VERSIONValue());

		/// <summary>
		/// version of the hardware or software. 
		/// </summary>
		public sealed class VERSIONValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "VERSION";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.6";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// version of the hardware or software. ";
		}
		private RELEASE_DATEValue _RELEASE_DATE;
		/// <summary>
		/// date the hardware or software was released for general use.
		/// </summary>
		public RELEASE_DATEValue RELEASE_DATE => _RELEASE_DATE ?? (_RELEASE_DATE = new RELEASE_DATEValue());

		/// <summary>
		/// date the hardware or software was released for general use.
		/// </summary>
		public sealed class RELEASE_DATEValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "RELEASE_DATE";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.6";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// date the hardware or software was released for general use.";
		}
		private INSTALL_DATEValue _INSTALL_DATE;
		/// <summary>
		/// date the hardware or software was installed.
		/// </summary>
		public INSTALL_DATEValue INSTALL_DATE => _INSTALL_DATE ?? (_INSTALL_DATE = new INSTALL_DATEValue());

		/// <summary>
		/// date the hardware or software was installed.
		/// </summary>
		public sealed class INSTALL_DATEValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "INSTALL_DATE";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.6";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// date the hardware or software was installed.";
		}
		private MANUFACTURERValue _MANUFACTURER;
		/// <summary>
		/// corporate identity for the maker of the hardware or software.
		/// </summary>
		public MANUFACTURERValue MANUFACTURER => _MANUFACTURER ?? (_MANUFACTURER = new MANUFACTURERValue());

		/// <summary>
		/// corporate identity for the maker of the hardware or software.
		/// </summary>
		public sealed class MANUFACTURERValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "MANUFACTURER";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.6";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// corporate identity for the maker of the hardware or software.";
		}
		private UUIDValue _UUID;
		/// <summary>
		/// universally unique identifier as specified in ISO 11578 or RFC 4122.
		/// </summary>
		public UUIDValue UUID => _UUID ?? (_UUID = new UUIDValue());

		/// <summary>
		/// universally unique identifier as specified in ISO 11578 or RFC 4122.
		/// </summary>
		public sealed class UUIDValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "UUID";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.7";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// universally unique identifier as specified in ISO 11578 or RFC 4122.";
		}
		private SERIAL_NUMBERValue _SERIAL_NUMBER;
		/// <summary>
		/// serial number that uniquely identifies a specific part.
		/// </summary>
		public SERIAL_NUMBERValue SERIAL_NUMBER => _SERIAL_NUMBER ?? (_SERIAL_NUMBER = new SERIAL_NUMBERValue());

		/// <summary>
		/// serial number that uniquely identifies a specific part.
		/// </summary>
		public sealed class SERIAL_NUMBERValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "SERIAL_NUMBER";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.7";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// serial number that uniquely identifies a specific part.";
		}
		private RAW_MATERIALValue _RAW_MATERIAL;
		/// <summary>
		/// material that is used to produce parts.
		/// </summary>
		public RAW_MATERIALValue RAW_MATERIAL => _RAW_MATERIAL ?? (_RAW_MATERIAL = new RAW_MATERIALValue());

		/// <summary>
		/// material that is used to produce parts.
		/// </summary>
		public sealed class RAW_MATERIALValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "RAW_MATERIAL";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.7";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// material that is used to produce parts.";
		}
		private LOTValue _LOT;
		/// <summary>
		/// group of parts tracked as a lot.
		/// </summary>
		public LOTValue LOT => _LOT ?? (_LOT = new LOTValue());

		/// <summary>
		/// group of parts tracked as a lot.
		/// </summary>
		public sealed class LOTValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "LOT";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.7";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// group of parts tracked as a lot.";
		}
		private BATCHValue _BATCH;
		/// <summary>
		/// group of parts produced in a batch.
		/// </summary>
		public BATCHValue BATCH => _BATCH ?? (_BATCH = new BATCHValue());

		/// <summary>
		/// group of parts produced in a batch.
		/// </summary>
		public sealed class BATCHValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "BATCH";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.7";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// group of parts produced in a batch.";
		}
		private HEAT_TREATValue _HEAT_TREAT;
		/// <summary>
		/// material heat number.
		/// </summary>
		public HEAT_TREATValue HEAT_TREAT => _HEAT_TREAT ?? (_HEAT_TREAT = new HEAT_TREATValue());

		/// <summary>
		/// material heat number.
		/// </summary>
		public sealed class HEAT_TREATValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "HEAT_TREAT";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.7";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// material heat number.";
		}
		private PART_NUMBERValue _PART_NUMBER;
		/// <summary>
		/// particular part design or model.
		/// </summary>
		public PART_NUMBERValue PART_NUMBER => _PART_NUMBER ?? (_PART_NUMBER = new PART_NUMBERValue());

		/// <summary>
		/// particular part design or model.
		/// </summary>
		public sealed class PART_NUMBERValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "PART_NUMBER";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.7";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// particular part design or model.";
		}
		private PART_FAMILYValue _PART_FAMILY;
		/// <summary>
		/// group of parts having similarities in geometry, manufacturing process, and/or functions.
		/// </summary>
		public PART_FAMILYValue PART_FAMILY => _PART_FAMILY ?? (_PART_FAMILY = new PART_FAMILYValue());

		/// <summary>
		/// group of parts having similarities in geometry, manufacturing process, and/or functions.
		/// </summary>
		public sealed class PART_FAMILYValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "PART_FAMILY";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.7";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// group of parts having similarities in geometry, manufacturing process, and/or functions.";
		}
		private PART_NAMEValue _PART_NAME;
		/// <summary>
		/// word or set of words by which a part is known, addressed, or referred to.
		/// </summary>
		public PART_NAMEValue PART_NAME => _PART_NAME ?? (_PART_NAME = new PART_NAMEValue());

		/// <summary>
		/// word or set of words by which a part is known, addressed, or referred to.
		/// </summary>
		public sealed class PART_NAMEValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "PART_NAME";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.7";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// word or set of words by which a part is known, addressed, or referred to.";
		}
		private PROCESS_STEPValue _PROCESS_STEP;
		/// <summary>
		/// step in the process plan that this occurrence corresponds to. 
		/// </summary>
		public PROCESS_STEPValue PROCESS_STEP => _PROCESS_STEP ?? (_PROCESS_STEP = new PROCESS_STEPValue());

		/// <summary>
		/// step in the process plan that this occurrence corresponds to. 
		/// </summary>
		public sealed class PROCESS_STEPValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "PROCESS_STEP";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.7";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// step in the process plan that this occurrence corresponds to. ";
		}
		private PROCESS_PLANValue _PROCESS_PLAN;
		/// <summary>
		/// process plan that a process occurrence belongs to.
		/// </summary>
		public PROCESS_PLANValue PROCESS_PLAN => _PROCESS_PLAN ?? (_PROCESS_PLAN = new PROCESS_PLANValue());

		/// <summary>
		/// process plan that a process occurrence belongs to.
		/// </summary>
		public sealed class PROCESS_PLANValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "PROCESS_PLAN";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.7";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// process plan that a process occurrence belongs to.";
		}
		private ORDER_NUMBERValue _ORDER_NUMBER;
		/// <summary>
		/// authorization of a process occurrence.
		/// </summary>
		public ORDER_NUMBERValue ORDER_NUMBER => _ORDER_NUMBER ?? (_ORDER_NUMBER = new ORDER_NUMBERValue());

		/// <summary>
		/// authorization of a process occurrence.
		/// </summary>
		public sealed class ORDER_NUMBERValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "ORDER_NUMBER";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.7";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// authorization of a process occurrence.";
		}
		private PROCESS_NAMEValue _PROCESS_NAME;
		/// <summary>
		/// word or set of words by which a process being executed (process occurrence) by the device is known, addressed, or referred to. 
		/// </summary>
		public PROCESS_NAMEValue PROCESS_NAME => _PROCESS_NAME ?? (_PROCESS_NAME = new PROCESS_NAMEValue());

		/// <summary>
		/// word or set of words by which a process being executed (process occurrence) by the device is known, addressed, or referred to. 
		/// </summary>
		public sealed class PROCESS_NAMEValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "PROCESS_NAME";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.7";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// word or set of words by which a process being executed (process occurrence) by the device is known, addressed, or referred to. ";
		}
		private ISO_STEP_EXECUTABLEValue _ISO_STEP_EXECUTABLE;
		/// <summary>
		/// reference to a ISO 10303 Executable.
		/// </summary>
		public ISO_STEP_EXECUTABLEValue ISO_STEP_EXECUTABLE => _ISO_STEP_EXECUTABLE ?? (_ISO_STEP_EXECUTABLE = new ISO_STEP_EXECUTABLEValue());

		/// <summary>
		/// reference to a ISO 10303 Executable.
		/// </summary>
		public sealed class ISO_STEP_EXECUTABLEValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "ISO_STEP_EXECUTABLE";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.7";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// reference to a ISO 10303 Executable.";
		}
		private COMPLETEValue _COMPLETE;
		/// <summary>
		/// associated with the completion of an activity or event.
		/// </summary>
		public COMPLETEValue COMPLETE => _COMPLETE ?? (_COMPLETE = new COMPLETEValue());

		/// <summary>
		/// associated with the completion of an activity or event.
		/// </summary>
		public sealed class COMPLETEValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "COMPLETE";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.5";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// associated with the completion of an activity or event.";
		}
		private ACTIVEValue _ACTIVE;
		/// <summary>
		/// relating to logic or motion program currently executing.
		/// </summary>
		public ACTIVEValue ACTIVE => _ACTIVE ?? (_ACTIVE = new ACTIVEValue());

		/// <summary>
		/// relating to logic or motion program currently executing.
		/// </summary>
		public sealed class ACTIVEValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "ACTIVE";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.5";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// relating to logic or motion program currently executing.";
		}
		private FAILEDValue _FAILED;
		/// <summary>
		/// actions or activities that were attempted , but failed to complete or resulted in an unexpected or unacceptable outcome.
		/// </summary>
		public FAILEDValue FAILED => _FAILED ?? (_FAILED = new FAILEDValue());

		/// <summary>
		/// actions or activities that were attempted , but failed to complete or resulted in an unexpected or unacceptable outcome.
		/// </summary>
		public sealed class FAILEDValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "FAILED";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.8";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// actions or activities that were attempted , but failed to complete or resulted in an unexpected or unacceptable outcome.";
		}
		private ABORTEDValue _ABORTED;
		/// <summary>
		/// actions or activities that were attempted, but terminated before they could be completed.
		/// </summary>
		public ABORTEDValue ABORTED => _ABORTED ?? (_ABORTED = new ABORTEDValue());

		/// <summary>
		/// actions or activities that were attempted, but terminated before they could be completed.
		/// </summary>
		public sealed class ABORTEDValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "ABORTED";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.8";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// actions or activities that were attempted, but terminated before they could be completed.";
		}
		private ENDEDValue _ENDED;
		/// <summary>
		/// boundary when an activity or an event terminates.
		/// </summary>
		public ENDEDValue ENDED => _ENDED ?? (_ENDED = new ENDEDValue());

		/// <summary>
		/// boundary when an activity or an event terminates.
		/// </summary>
		public sealed class ENDEDValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "ENDED";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.8";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// boundary when an activity or an event terminates.";
		}
		private WASTEValue _WASTE;
		/// <summary>
		/// amount discarded.
		/// </summary>
		public WASTEValue WASTE => _WASTE ?? (_WASTE = new WASTEValue());

		/// <summary>
		/// amount discarded.
		/// </summary>
		public sealed class WASTEValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "WASTE";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.8";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// amount discarded.";
		}
		private PARTValue _PART;
		/// <summary>
		/// amount included in the <i>part</i>.
		/// </summary>
		public PARTValue PART => _PART ?? (_PART = new PARTValue());

		/// <summary>
		/// amount included in the <i>part</i>.
		/// </summary>
		public sealed class PARTValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "PART";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.8";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// amount included in the <i>part</i>.";
		}
		private REQUESTValue _REQUEST;
		/// <summary>
		/// <i>request</i> by an <see cref="Interface">Interface</see> for a task.
		/// </summary>
		public REQUESTValue REQUEST => _REQUEST ?? (_REQUEST = new REQUESTValue());

		/// <summary>
		/// <i>request</i> by an <see cref="Interface">Interface</see> for a task.
		/// </summary>
		public sealed class REQUESTValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "REQUEST";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.3";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// <i>request</i> by an <see cref=""Interface"">Interface</see> for a task.";
		}
		private RESPONSEValue _RESPONSE;
		/// <summary>
		/// <i>response</i> by an <see cref="Interface">Interface</see> to a <i>request</i> for a task.
		/// </summary>
		public RESPONSEValue RESPONSE => _RESPONSE ?? (_RESPONSE = new RESPONSEValue());

		/// <summary>
		/// <i>response</i> by an <see cref="Interface">Interface</see> to a <i>request</i> for a task.
		/// </summary>
		public sealed class RESPONSEValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "RESPONSE";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.3";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// <i>response</i> by an <see cref=""Interface"">Interface</see> to a <i>request</i> for a task.";
		}
		private ACTIVITYValue _ACTIVITY;
		/// <summary>
		/// phase or segment of a recipe or program.
		/// </summary>
		public ACTIVITYValue ACTIVITY => _ACTIVITY ?? (_ACTIVITY = new ACTIVITYValue());

		/// <summary>
		/// phase or segment of a recipe or program.
		/// </summary>
		public sealed class ACTIVITYValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "ACTIVITY";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "2.0";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// phase or segment of a recipe or program.";
		}
		private SEGMENTValue _SEGMENT;
		/// <summary>
		/// phase of a recipe process.
		/// </summary>
		public SEGMENTValue SEGMENT => _SEGMENT ?? (_SEGMENT = new SEGMENTValue());

		/// <summary>
		/// phase of a recipe process.
		/// </summary>
		public sealed class SEGMENTValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "SEGMENT";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "2.0";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// phase of a recipe process.";
		}
		private RECIPEValue _RECIPE;
		/// <summary>
		/// process as part of product production; can be a subprocess of a larger process.
		/// </summary>
		public RECIPEValue RECIPE => _RECIPE ?? (_RECIPE = new RECIPEValue());

		/// <summary>
		/// process as part of product production; can be a subprocess of a larger process.
		/// </summary>
		public sealed class RECIPEValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "RECIPE";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "2.0";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// process as part of product production; can be a subprocess of a larger process.";
		}
		private OPERATIONValue _OPERATION;
		/// <summary>
		/// step of a discrete manufacturing process.
		/// </summary>
		public OPERATIONValue OPERATION => _OPERATION ?? (_OPERATION = new OPERATIONValue());

		/// <summary>
		/// step of a discrete manufacturing process.
		/// </summary>
		public sealed class OPERATIONValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "OPERATION";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "2.0";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// step of a discrete manufacturing process.";
		}
		private BINARYValue _BINARY;
		/// <summary>
		/// observed as a binary data type.
		/// </summary>
		public BINARYValue BINARY => _BINARY ?? (_BINARY = new BINARYValue());

		/// <summary>
		/// observed as a binary data type.
		/// </summary>
		public sealed class BINARYValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "BINARY";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "2.2";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// observed as a binary data type.";
		}
		private BOOLEANValue _BOOLEAN;
		/// <summary>
		/// observed as a boolean data type.
		/// </summary>
		public BOOLEANValue BOOLEAN => _BOOLEAN ?? (_BOOLEAN = new BOOLEANValue());

		/// <summary>
		/// observed as a boolean data type.
		/// </summary>
		public sealed class BOOLEANValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "BOOLEAN";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "2.2";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// observed as a boolean data type.";
		}
		private ENUMERATEDValue _ENUMERATED;
		/// <summary>
		/// observed as a set containing a restricted number of discrete values where each discrete value is named and unique. <seealso href="https://www.google.com/search?q=ISO 21961:2003, 013&btnI=I">ISO 21961:2003, 013</seealso>
		/// </summary>
		public ENUMERATEDValue ENUMERATED => _ENUMERATED ?? (_ENUMERATED = new ENUMERATEDValue());

		/// <summary>
		/// observed as a set containing a restricted number of discrete values where each discrete value is named and unique. <seealso href="https://www.google.com/search?q=ISO 21961:2003, 013&btnI=I">ISO 21961:2003, 013</seealso>
		/// </summary>
		public sealed class ENUMERATEDValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "ENUMERATED";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "2.2";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// observed as a set containing a restricted number of discrete values where each discrete value is named and unique. <seealso href=""https://www.google.com/search?q=ISO 21961:2003, 013&btnI=I"">ISO 21961:2003, 013</seealso>";
		}
		private DETECTValue _DETECT;
		/// <summary>
		/// indicated by the presence or existence of something.
		/// </summary>
		public DETECTValue DETECT => _DETECT ?? (_DETECT = new DETECTValue());

		/// <summary>
		/// indicated by the presence or existence of something.
		/// </summary>
		public sealed class DETECTValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "DETECT";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "2.2";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// indicated by the presence or existence of something.";
		}
		private MODELValue _MODEL;
		/// <summary>
		/// model info of the hardware or software.
		/// </summary>
		public MODELValue MODEL => _MODEL ?? (_MODEL = new MODELValue());

		/// <summary>
		/// model info of the hardware or software.
		/// </summary>
		public sealed class MODELValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "MODEL";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "2.3";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// model info of the hardware or software.";
		}
		private SECONDARYValue _SECONDARY;
		/// <summary>
		/// alternate or not primary.
		/// </summary>
		public SECONDARYValue SECONDARY => _SECONDARY ?? (_SECONDARY = new SECONDARYValue());

		/// <summary>
		/// alternate or not primary.
		/// </summary>
		public sealed class SECONDARYValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "SECONDARY";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "2.3";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// alternate or not primary.";
		}
		private STANDBYValue _STANDBY;
		/// <summary>
		/// held near at hand and ready for use.
		/// </summary>
		public STANDBYValue STANDBY => _STANDBY ?? (_STANDBY = new STANDBYValue());

		/// <summary>
		/// held near at hand and ready for use.
		/// </summary>
		public sealed class STANDBYValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "STANDBY";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "2.3";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// held near at hand and ready for use.";
		}
	}
}