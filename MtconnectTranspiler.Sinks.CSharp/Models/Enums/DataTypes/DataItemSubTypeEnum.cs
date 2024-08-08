#pragma warning disable 0618
#pragma warning disable 1574
using System;
using System.CodeDom.Compiler;

namespace Mtconnect.DataTypes
{
	/// <summary>
	/// View in the MTConnect Model browser <seealso href="https://model.mtconnect.org/#Enumeration___19_0_3_45f01b9_1579563592155_977172_22064">model.mtconnect.org</seealso>
	/// </summary>
	/// <remarks>
	/// <list type="bullet">
	/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_">v</see></item>
	/// <item><b>Deprecated</b>: <see href="https://model.mtconnect.org/#_Version_">v</see></item>
	/// </list>
	/// </remarks>
	[Obsolete("Deprecated in v according to https://model.mtconnect.org/#_Version_")]
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.3.0.0")]
	public enum DataItemSubTypeEnum
	{
		/// <summary>
		/// relating to or derived in the simplest manner from the fundamental units or measurements.
		/// </summary>
		ABSOLUTE,
		/// <summary>
		/// indication of the operating state of a mechanism.
		/// </summary>
		ACTION,
		/// <summary>
		/// measured or reported value of an <i>observation</i>.
		/// </summary>
		ACTUAL,
		/// <summary>
		/// all actions, items, or activities being counted independent of the outcome.
		/// </summary>
		ALL,
		/// <summary>
		/// measurement of alternating voltage or current. If not specified further in statistic, defaults to RMS voltage.   <b>DEPRECATED</b> in <i>Version 1.6</i>s.
		/// </summary>
		ALTERNATING,
		/// <summary>
		/// A-Scale weighting factor on the frequency scale.
		/// </summary>
		A_SCALE,
		/// <summary>
		/// when multiple locations on a piece of bar stock being feed by a bar feeder are referenced as the indication of whether the end of that piece of bar stock has been reached.
		/// </summary>
		AUXILIARY,
		/// <summary>
		/// actions, items, or activities being counted that do not conform to specification or expectation.
		/// </summary>
		BAD,
		/// <summary>
		/// scale to measure the resistance to deformation of a surface.
		/// </summary>
		BRINELL,
		/// <summary>
		/// B-Scale weighting factor on the frequency scale.
		/// </summary>
		B_SCALE,
		/// <summary>
		/// directive value including adjustments such as an offset or overrides.
		/// </summary>
		COMMANDED,
		/// <summary>
		/// amount of material consumed from an object or container during a manufacturing process.
		/// </summary>
		CONSUMED,
		/// <summary>
		/// state of the enabling signal or control logic that enables or disables the function or operation of the entity.
		/// </summary>
		CONTROL,
		/// <summary>
		/// C-Scale weighting factor on the frequency scale.
		/// </summary>
		C_SCALE,
		/// <summary>
		/// elapsed time of a temporary halt of action.
		/// </summary>
		DELAY,
		/// <summary>
		/// DC current or voltage.  <b>DEPRECATED</b> in <i>Version 1.6</i>s.
		/// </summary>
		DIRECT,
		/// <summary>
		/// setting or operator selection used to execute a test mode to confirm the execution of machine functions.
		/// </summary>
		DRY_RUN,
		/// <summary>
		/// D-Scale weighting factor on the frequency scale.
		/// </summary>
		D_SCALE,
		/// <summary>
		/// relating to the expiration or end of useful life for a material or other physical item.
		/// </summary>
		EXPIRATION,
		/// <summary>
		/// relating to the first use of a material or other physical item.
		/// </summary>
		FIRST_USE,
		/// <summary>
		/// actions, items, or activities being counted that conform to specification or expectation.
		/// </summary>
		GOOD,
		/// <summary>
		/// relating to or derived from the last <i>observation</i>.
		/// </summary>
		INCREMENTAL,
		/// <summary>
		/// relating to momentary activation of a function or a movement.  <b>DEPRECATION WARNING</b>: May be deprecated in the future.
		/// </summary>
		JOG,
		/// <summary>
		/// indication of the position of a mechanism that may move in a lateral direction.
		/// </summary>
		LATERAL,
		/// <summary>
		/// scale to measure the elasticity of a surface.
		/// </summary>
		LEEB,
		/// <summary>
		/// reference to a length type tool offset variable.
		/// </summary>
		LENGTH,
		/// <summary>
		/// state of the power source.
		/// </summary>
		LINE,
		/// <summary>
		/// direction of motion of a linear motion.
		/// </summary>
		LINEAR,
		/// <summary>
		/// indication that the subparts of a piece of equipment are under load.
		/// </summary>
		LOADED,
		/// <summary>
		/// setting or operator selection that changes the behavior of the controller on a piece of equipment.
		/// </summary>
		MACHINE_AXIS_LOCK,
		/// <summary>
		/// relating to the primary logic or motion program currently being executed.
		/// </summary>
		MAIN,
		/// <summary>
		/// relating to maintenance on the piece of equipment.
		/// </summary>
		MAINTENANCE,
		/// <summary>
		/// indication of the state of an operator controlled interlock that can inhibit the ability to initiate an unclamp action of an electronically controlled chuck.
		/// </summary>
		MANUAL_UNCLAMP,
		/// <summary>
		/// related to the production of a material or other physical item.
		/// </summary>
		MANUFACTURE,
		/// <summary>
		/// maximum value.
		/// </summary>
		MAXIMUM,
		/// <summary>
		/// minimum value.
		/// </summary>
		MINIMUM,
		/// <summary>
		/// scale to measure the resistance to scratching of a surface.
		/// </summary>
		MOHS,
		/// <summary>
		/// indication of the open or closed state of a mechanism.
		/// </summary>
		MOTION,
		/// <summary>
		/// no weighting factor on the frequency scale.
		/// </summary>
		NO_SCALE,
		/// <summary>
		/// piece of equipment that is powered or performing any activity.
		/// </summary>
		OPERATING,
		/// <summary>
		/// relating to the person currently responsible for operating the piece of equipment.
		/// </summary>
		OPERATOR,
		/// <summary>
		/// setting or operator selection that changes the behavior of the controller on a piece of equipment. 
		/// </summary>
		OPTIONAL_STOP,
		/// <summary>
		/// overridden value.
		/// </summary>
		OVERRIDE,
		/// <summary>
		/// piece of equipment is powered and functioning or <see cref="Component">Component</see> that are required to remain on are powered.
		/// </summary>
		POWERED,
		/// <summary>
		/// main or most important.
		/// </summary>
		PRIMARY,
		/// <summary>
		/// position provided by a measurement probe.  <b>DEPRECATION WARNING</b>: May be deprecated in the future.
		/// </summary>
		PROBE,
		/// <summary>
		/// relating to production of a part or product on a piece of equipment.
		/// </summary>
		PROCESS,
		/// <summary>
		/// directive value without offsets and adjustments.
		/// </summary>
		PROGRAMMED,
		/// <summary>
		/// reference to a radial type tool offset variable.
		/// </summary>
		RADIAL,
		/// <summary>
		/// performing an operation faster or in less time than nominal rate.
		/// </summary>
		RAPID,
		/// <summary>
		/// remaining measure or count of an action, object or activity.
		/// </summary>
		REMAINING,
		/// <summary>
		/// scale to measure the resistance to deformation of a surface.
		/// </summary>
		ROCKWELL,
		/// <summary>
		/// direction of a rotary motion using the right hand rule convention.
		/// </summary>
		ROTARY,
		/// <summary>
		/// identity of a control program that is used to specify the order of execution of other programs.
		/// </summary>
		SCHEDULE,
		/// <summary>
		/// relating to the preparation of a piece of equipment for production or restoring the piece of equipment to a neutral state after production.
		/// </summary>
		SET_UP,
		/// <summary>
		/// scale to measure the resistance to deformation of a surface.
		/// </summary>
		SHORE,
		/// <summary>
		/// setting or operator selection that changes the behavior of the controller on a piece of equipment. 
		/// </summary>
		SINGLE_BLOCK,
		/// <summary>
		/// standard measure of an object or an action.
		/// </summary>
		STANDARD,
		/// <summary>
		/// boundary when an activity or an event commences.
		/// </summary>
		START,
		/// <summary>
		/// indication of the activation state of a mechanism represented by a <see cref="Composition">Composition</see>.
		/// </summary>
		SWITCHED,
		/// <summary>
		/// goal of the operation or process.
		/// </summary>
		TARGET,
		/// <summary>
		/// relating to the end or completion of an activity or event.
		/// </summary>
		TARGET_COMPLETION,
		/// <summary>
		/// setting or operator selection that changes the behavior of the controller on a piece of equipment.
		/// </summary>
		TOOL_CHANGE_STOP,
		/// <summary>
		/// remaining usable measure of an object or action.
		/// </summary>
		USEABLE,
		/// <summary>
		/// indication of the position of a mechanism that may move in a vertical direction.
		/// </summary>
		VERTICAL,
		/// <summary>
		/// scale to measure the resistance to deformation of a surface.
		/// </summary>
		VICKERS,
		/// <summary>
		/// piece of equipment performing any activity, the equipment is active and performing a function under load or not.
		/// </summary>
		WORKING,
		/// <summary>
		/// IPV4 network address of the <see cref="Component">Component</see>.
		/// </summary>
		IPV4_ADDRESS,
		/// <summary>
		/// IPV6 network address of the <see cref="Component">Component</see>.
		/// </summary>
		IPV6_ADDRESS,
		/// <summary>
		/// Gateway for the <see cref="Component">Component</see> network.
		/// </summary>
		GATEWAY,
		/// <summary>
		/// SubNet mask for the <see cref="Component">Component</see> network. 
		/// </summary>
		SUBNET_MASK,
		/// <summary>
		/// layer2 Virtual Local Network (VLAN) ID for the <see cref="Component">Component</see> network.
		/// </summary>
		VLAN_ID,
		/// <summary>
		/// Media Access Control Address. The unique physical address of the network hardware.
		/// </summary>
		MAC_ADDRESS,
		/// <summary>
		/// identifies whether the connection type is wireless.
		/// </summary>
		WIRELESS,
		/// <summary>
		/// license code to validate or activate the hardware or software.
		/// </summary>
		LICENSE,
		/// <summary>
		/// version of the hardware or software. 
		/// </summary>
		VERSION,
		/// <summary>
		/// date the hardware or software was released for general use.
		/// </summary>
		RELEASE_DATE,
		/// <summary>
		/// date the hardware or software was installed.
		/// </summary>
		INSTALL_DATE,
		/// <summary>
		/// corporate identity for the maker of the hardware or software.
		/// </summary>
		MANUFACTURER,
		/// <summary>
		/// universally unique identifier as specified in ISO 11578 or RFC 4122.
		/// </summary>
		UUID,
		/// <summary>
		/// serial number that uniquely identifies a specific part.
		/// </summary>
		SERIAL_NUMBER,
		/// <summary>
		/// material that is used to produce parts.
		/// </summary>
		RAW_MATERIAL,
		/// <summary>
		/// group of parts tracked as a lot.
		/// </summary>
		LOT,
		/// <summary>
		/// group of parts produced in a batch.
		/// </summary>
		BATCH,
		/// <summary>
		/// material heat number.
		/// </summary>
		HEAT_TREAT,
		/// <summary>
		/// particular part design or model.
		/// </summary>
		PART_NUMBER,
		/// <summary>
		/// group of parts having similarities in geometry, manufacturing process, and/or functions.
		/// </summary>
		PART_FAMILY,
		/// <summary>
		/// word or set of words by which a part is known, addressed, or referred to.
		/// </summary>
		PART_NAME,
		/// <summary>
		/// step in the process plan that this occurrence corresponds to. 
		/// </summary>
		PROCESS_STEP,
		/// <summary>
		/// process plan that a process occurrence belongs to.
		/// </summary>
		PROCESS_PLAN,
		/// <summary>
		/// authorization of a process occurrence.
		/// </summary>
		ORDER_NUMBER,
		/// <summary>
		/// word or set of words by which a process being executed (process occurrence) by the device is known, addressed, or referred to. 
		/// </summary>
		PROCESS_NAME,
		/// <summary>
		/// reference to a ISO 10303 Executable.
		/// </summary>
		ISO_STEP_EXECUTABLE,
		/// <summary>
		/// associated with the completion of an activity or event.
		/// </summary>
		COMPLETE,
		/// <summary>
		/// relating to logic or motion program currently executing.
		/// </summary>
		ACTIVE,
		/// <summary>
		/// actions or activities that were attempted , but failed to complete or resulted in an unexpected or unacceptable outcome.
		/// </summary>
		FAILED,
		/// <summary>
		/// actions or activities that were attempted, but terminated before they could be completed.
		/// </summary>
		ABORTED,
		/// <summary>
		/// boundary when an activity or an event terminates.
		/// </summary>
		ENDED,
		/// <summary>
		/// amount discarded.
		/// </summary>
		WASTE,
		/// <summary>
		/// amount included in the <i>part</i>.
		/// </summary>
		PART,
		/// <summary>
		/// <i>request</i> by an <see cref="Interface">Interface</see> for a task.
		/// </summary>
		REQUEST,
		/// <summary>
		/// <i>response</i> by an <see cref="Interface">Interface</see> to a <i>request</i> for a task.
		/// </summary>
		RESPONSE,
		/// <summary>
		/// phase or segment of a recipe or program.
		/// </summary>
		ACTIVITY,
		/// <summary>
		/// phase of a recipe process.
		/// </summary>
		SEGMENT,
		/// <summary>
		/// process as part of product production; can be a subprocess of a larger process.
		/// </summary>
		RECIPE,
		/// <summary>
		/// step of a discrete manufacturing process.
		/// </summary>
		OPERATION,
		/// <summary>
		/// observed as a binary data type.
		/// </summary>
		BINARY,
		/// <summary>
		/// observed as a boolean data type.
		/// </summary>
		BOOLEAN,
		/// <summary>
		/// observed as a set containing a restricted number of discrete values where each discrete value is named and unique. <seealso href="https://www.google.com/search?q=ISO 21961:2003, 013&btnI=I">ISO 21961:2003, 013</seealso>
		/// </summary>
		ENUMERATED,
		/// <summary>
		/// indicated by the presence or existence of something.
		/// </summary>
		DETECT,
		/// <summary>
		/// model info of the hardware or software.
		/// </summary>
		MODEL,
		/// <summary>
		/// alternate or not primary.
		/// </summary>
		SECONDARY,
		/// <summary>
		/// held near at hand and ready for use.
		/// </summary>
		STANDBY,
	}
}