#pragma warning disable CS1574 // XML comment has cref attribute that could not be resolved
#pragma warning disable CS1584 // XML comment has syntactically incorrect cref attribute
#pragma warning disable CS0618 // Type or member is obsolete
using System;
using System.CodeDom.Compiler;using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;

namespace Mtconnect.DataTypes
{
	/// <summary>﻿
	/// <br/> Visit <seealso href="https://model.mtconnect.org/#Enumeration___19_0_3_45f01b9_1580312281115_595828_44604">model.mtconnect.org</seealso> for more information.
	/// </summary>
	/// <remarks>
	/// <list type="bullet">
	/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.4">v1.4</see></item>
	/// </list>
	/// </remarks>

	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public enum CompositionTypeEnum
	{
		/// <summary>﻿<see cref="Composition">Composition</see> composed of a mechanism that moves or controls a mechanical part of a piece of equipment.<br /><br />It takes energy usually provided by air, electric current, or liquid and converts the energy into some kind of motion. <br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.4">v1.4</see></item>
		/// </list>
		/// </remarks>

		ACTUATOR,
		/// <summary>﻿<see cref="Composition">Composition</see> composed of an electronic component or circuit that amplifies power, electric current, or voltage.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.4">v1.4</see></item>
		/// </list>
		/// </remarks>

		AMPLIFIER,
		/// <summary>﻿<see cref="Composition">Composition</see> composed of a mechanical structure that transforms rotary motion into linear motion.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.4">v1.4</see></item>
		/// </list>
		/// </remarks>

		BALLSCREW,
		/// <summary>﻿<see cref="Composition">Composition</see> composed of an endless flexible band that transmits motion for a piece of equipment or conveys materials and objects.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.4">v1.4</see></item>
		/// </list>
		/// </remarks>

		BELT,
		/// <summary>﻿<see cref="Composition">Composition</see> composed of a mechanism that slows down or stops a moving object by the absorption or transfer of the energy of momentum, usually by means of friction, electrical force, or magnetic force.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.4">v1.4</see></item>
		/// </list>
		/// </remarks>

		BRAKE,
		/// <summary>﻿<see cref="Composition">Composition</see> composed of an interconnected series of objects that band together and transmit motion for a piece of equipment or to convey materials and objects.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.4">v1.4</see></item>
		/// </list>
		/// </remarks>

		CHAIN,
		/// <summary>﻿<see cref="Composition">Composition</see> composed of a mechanism that breaks material into smaller pieces.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.4">v1.4</see></item>
		/// </list>
		/// </remarks>

		CHOPPER,
		/// <summary>﻿<see cref="Composition">Composition</see> composed of a mechanism that holds a part, stock material, or any other item in place.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.4">v1.4</see></item>
		/// </list>
		/// </remarks>

		CHUCK,
		/// <summary>﻿<see cref="Composition">Composition</see> composed of an inclined channel that conveys material.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.4">v1.4</see></item>
		/// </list>
		/// </remarks>

		CHUTE,
		/// <summary>﻿<see cref="Composition">Composition</see> composed of a mechanism that interrupts an electric circuit.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.4">v1.4</see></item>
		/// </list>
		/// </remarks>

		CIRCUIT_BREAKER,
		/// <summary>﻿<see cref="Composition">Composition</see> composed of a mechanism that strengthens, supports, or fastens objects in place.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.4">v1.4</see></item>
		/// </list>
		/// </remarks>

		CLAMP,
		/// <summary>﻿<see cref="Composition">Composition</see> composed of a pump or other mechanism that reduces volume and increases pressure of gases in order to condense the gases to drive pneumatically powered pieces of equipment.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.4">v1.4</see></item>
		/// </list>
		/// </remarks>

		COMPRESSOR,
		/// <summary>﻿<see cref="Composition">Composition</see> composed of a mechanical mechanism or closure that covers a physical access portal into a piece of equipment allowing or restricting access to other parts of the equipment.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.4">v1.4</see></item>
		/// </list>
		/// </remarks>

		DOOR,
		/// <summary>﻿<see cref="Composition">Composition</see> composed of a mechanism that allows material to flow for the purpose of drainage from, for example, a vessel or tank.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.4">v1.4</see></item>
		/// </list>
		/// </remarks>

		DRAIN,
		/// <summary>﻿<see cref="Composition">Composition</see> composed of a mechanism that measures rotary position.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.4">v1.4</see></item>
		/// </list>
		/// </remarks>

		ENCODER,
		/// <summary>﻿<see cref="Composition">Composition</see> composed of a mechanism that emits a type of radiation.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.4">v1.4</see></item>
		/// </list>
		/// </remarks>

		EXPOSURE_UNIT,
		/// <summary>﻿<see cref="Composition">Composition</see> composed of a mechanism that dispenses liquid or powered materials.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.4">v1.4</see></item>
		/// </list>
		/// </remarks>

		EXTRUSION_UNIT,
		/// <summary>﻿<see cref="Composition">Composition</see> composed of a mechanism that produces a current of air.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.4">v1.4</see></item>
		/// </list>
		/// </remarks>

		FAN,
		/// <summary>﻿<see cref="Composition">Composition</see> composed of a substance or structure that allows liquids or gases to pass through to remove suspended impurities or to recover solids.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.4">v1.4</see></item>
		/// </list>
		/// </remarks>

		FILTER,
		/// <summary>﻿<see cref="Composition">Composition</see> composed of an electromechanical actuator that produces deflection of a beam of light or energy in response to electric current through its coil in a magnetic field.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.4">v1.4</see></item>
		/// </list>
		/// </remarks>

		GALVANOMOTOR,
		/// <summary>﻿<see cref="Composition">Composition</see> composed of a mechanism that holds a part, stock material, or any other item in place.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.4">v1.4</see></item>
		/// </list>
		/// </remarks>

		GRIPPER,
		/// <summary>﻿<see cref="Composition">Composition</see> composed of a chamber or bin that stores materials temporarily, typically being filled through the top and dispensed through the bottom.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.4">v1.4</see></item>
		/// </list>
		/// </remarks>

		HOPPER,
		/// <summary>﻿<see cref="Composition">Composition</see> composed of a mechanism that measures linear motion or position.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.4">v1.4</see></item>
		/// </list>
		/// </remarks>

		LINEAR_POSITION_FEEDBACK,
		/// <summary>﻿<see cref="Composition">Composition</see> composed of a mechanism that converts electrical, pneumatic, or hydraulic energy into mechanical energy.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.4">v1.4</see></item>
		/// </list>
		/// </remarks>

		MOTOR,
		/// <summary>﻿<see cref="Composition">Composition</see> composed of a viscous liquid.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.4">v1.4</see></item>
		/// </list>
		/// </remarks>

		OIL,
		/// <summary>﻿<see cref="Composition">Composition</see> composed of a unit that provides power to electric mechanisms.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.4">v1.4</see></item>
		/// </list>
		/// </remarks>

		POWER_SUPPLY,
		/// <summary>﻿<see cref="Composition">Composition</see> composed of a mechanism or wheel that turns in a frame or block and serves to change the direction of or to transmit force.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.4">v1.4</see></item>
		/// </list>
		/// </remarks>

		PULLEY,
		/// <summary>﻿<see cref="Composition">Composition</see> composed of an apparatus that raises, drives, exhausts, or compresses fluids or gases by means of a piston, plunger, or set of rotating vanes.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.4">v1.4</see></item>
		/// </list>
		/// </remarks>

		PUMP,
		/// <summary>﻿<see cref="Composition">Composition</see> composed of a rotary storage unit for material.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.4">v1.4</see></item>
		/// </list>
		/// </remarks>

		REEL,
		/// <summary>﻿<see cref="Composition">Composition</see> composed of a mechanism that provides a signal or measured value.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.4">v1.4</see></item>
		/// </list>
		/// </remarks>

		SENSING_ELEMENT,
		/// <summary>﻿<see cref="Composition">Composition</see> composed of a mechanism that flattens or spreads materials.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.4">v1.4</see></item>
		/// </list>
		/// </remarks>

		SPREADER,
		/// <summary>﻿<see cref="Composition">Composition</see> composed of one or more cells that converts chemical energy to electricity and serves as a source of power. <br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.4">v1.4</see></item>
		/// </list>
		/// </remarks>

		STORAGE_BATTERY,
		/// <summary>﻿<see cref="Composition">Composition</see> composed of a mechanism that turns on or off an electric current or makes or breaks a circuit.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.4">v1.4</see></item>
		/// </list>
		/// </remarks>

		SWITCH,
		/// <summary>﻿<see cref="Composition">Composition</see> composed of a surface that holds an object or material.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.4">v1.4</see></item>
		/// </list>
		/// </remarks>

		TABLE,
		/// <summary>﻿<see cref="Composition">Composition</see> composed of a receptacle or container that holds material.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.4">v1.4</see></item>
		/// </list>
		/// </remarks>

		TANK,
		/// <summary>﻿<see cref="Composition">Composition</see> composed of a mechanism that provides or applies a stretch or strain to another mechanism.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.4">v1.4</see></item>
		/// </list>
		/// </remarks>

		TENSIONER,
		/// <summary>﻿<see cref="Composition">Composition</see> composed of a mechanism that transforms electric energy from a source to a secondary circuit.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.4">v1.4</see></item>
		/// </list>
		/// </remarks>

		TRANSFORMER,
		/// <summary>﻿<see cref="Composition">Composition</see> composed of a mechanism that halts or controls the flow of a liquid, gas, or other material through a passage, pipe, inlet, or outlet.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.4">v1.4</see></item>
		/// </list>
		/// </remarks>

		VALVE,
		/// <summary>﻿<see cref="Composition">Composition</see> composed of a container for liquid or powdered materials.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.4">v1.4</see></item>
		/// </list>
		/// </remarks>

		VAT,
		/// <summary>﻿<see cref="Composition">Composition</see> composed of a fluid.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.4">v1.4</see></item>
		/// </list>
		/// </remarks>

		WATER,
		/// <summary>﻿<see cref="Composition">Composition</see> composed of a string like piece or filament of relatively rigid or flexible material provided in a variety of diameters.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.4">v1.4</see></item>
		/// </list>
		/// </remarks>

		WIRE,
		/// <summary>﻿<see cref="Composition">Composition</see> composed of an object or material on which a form of work is performed.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.4">v1.4</see></item>
		/// </list>
		/// </remarks>

		WORKPIECE,
		/// <summary>﻿<see cref="Composition">Composition</see> composed of a heat exchange system that uses a fluid to transfer heat to the atmosphere.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.4">v1.4</see></item>
		/// </list>
		/// </remarks>

		COOLING_TOWER,
		/// <summary>﻿<see cref="Composition">Composition</see> composed of a tool storage location associated with a <see cref="ToolMagazine">ToolMagazine</see> or <see cref="AutomaticToolChanger">AutomaticToolChanger</see>.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.4">v1.4</see></item>
		/// </list>
		/// </remarks>

		POT,
		/// <summary>﻿<see cref="Composition">Composition</see> composed of a storage or mounting location for a tool associated with a <see cref="Turret">Turret</see>, <see cref="GangToolBar">GangToolBar</see>, or <see cref="ToolRack">ToolRack</see>.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.4">v1.4</see></item>
		/// </list>
		/// </remarks>

		STATION,
		/// <summary>﻿<see cref="Composition">Composition</see> composed of a mechanism that physically moves a tool from one location to another.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.4">v1.4</see></item>
		/// </list>
		/// </remarks>

		TRANSFER_ARM,
		/// <summary>﻿<see cref="Pot">Pot</see> for a tool awaiting transfer from a <see cref="ToolMagazine">ToolMagazine</see> to <i>spindle</i> or <see cref="Turret">Turret</see>.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.4">v1.4</see></item>
		/// </list>
		/// </remarks>

		TRANSFER_POT,
		/// <summary>﻿<see cref="Pot">Pot</see> for a tool removed from <i>spindle</i> or <see cref="Turret">Turret</see> and awaiting for return to a <see cref="ToolMagazine">ToolMagazine</see>.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.4">v1.4</see></item>
		/// </list>
		/// </remarks>

		RETURN_POT,
		/// <summary>﻿<see cref="Pot">Pot</see> for a tool awaiting transfer to a <see cref="ToolMagazine">ToolMagazine</see> or <see cref="Turret">Turret</see> from outside of the piece of equipment.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.4">v1.4</see></item>
		/// </list>
		/// </remarks>

		STAGING_POT,
		/// <summary>﻿<see cref="Pot">Pot</see> for a tool to be removed from a <see cref="ToolMagazine">ToolMagazine</see> or <see cref="Turret">Turret</see> to a location outside of the piece of equipment.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.4">v1.4</see></item>
		/// </list>
		/// </remarks>

		REMOVAL_POT,
		/// <summary>﻿<see cref="Pot">Pot</see> for a tool that is no longer usable for removal from a <see cref="ToolMagazine">ToolMagazine</see> or <see cref="Turret">Turret</see>.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.4">v1.4</see></item>
		/// </list>
		/// </remarks>

		EXPIRED_POT,
	}

	/// <summary>﻿
	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Enumeration___19_0_3_45f01b9_1580312281115_595828_44604">model.mtconnect.org</seealso> for more information.
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public sealed class CompositionTypeEnumMetaClass : IEnum
	{
		/// <summary>Constant value for <see cref="CompositionTypeEnumMetaClass.ReferenceId" /></summary>
		public const string REFERENCE_ID = "_19_0_3_45f01b9_1580312281115_595828_44604";
		/// <summary>Constant value for <see cref="CompositionTypeEnumMetaClass.HelpUrl" /></summary>
		public const string HELP_URL = "https://model.mtconnect.org/#Enumeration___19_0_3_45f01b9_1580312281115_595828_44604";
		/// <summary>Constant value for <see cref="CompositionTypeEnumMetaClass.Name" /></summary>
		public const string NAME = "CompositionTypeEnum";
		/// <summary>Constant value for <see cref="CompositionTypeEnumMetaClass.NormativeVersion" /></summary>
		public const string NORMATIVE_VERSION = "1.4";
		/// <summary>Constant value for <see cref="CompositionTypeEnumMetaClass.DeprecatedVersion" /></summary>
		public const string DEPRECATED_VERSION = "";
		/// <summary>Constant value for <see cref="CompositionTypeEnumMetaClass.Summary" /></summary>
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
		public Type Instance => typeof(CompositionTypeEnum);

		/// <inheritdoc />
		public string NormativeVersion => NORMATIVE_VERSION;
		
		/// <inheritdoc />
		public string DeprecatedVersion => DEPRECATED_VERSION;
		
		/// <inheritdoc />
		public string Summary => SUMMARY;
		
		/// <inheritdoc />
		public IEnumInstance[] Values => new IEnumInstance[] {
		ACTUATOR,
		AMPLIFIER,
		BALLSCREW,
		BELT,
		BRAKE,
		CHAIN,
		CHOPPER,
		CHUCK,
		CHUTE,
		CIRCUIT_BREAKER,
		CLAMP,
		COMPRESSOR,
		DOOR,
		DRAIN,
		ENCODER,
		EXPOSURE_UNIT,
		EXTRUSION_UNIT,
		FAN,
		FILTER,
		GALVANOMOTOR,
		GRIPPER,
		HOPPER,
		LINEAR_POSITION_FEEDBACK,
		MOTOR,
		OIL,
		POWER_SUPPLY,
		PULLEY,
		PUMP,
		REEL,
		SENSING_ELEMENT,
		SPREADER,
		STORAGE_BATTERY,
		SWITCH,
		TABLE,
		TANK,
		TENSIONER,
		TRANSFORMER,
		VALVE,
		VAT,
		WATER,
		WIRE,
		WORKPIECE,
		COOLING_TOWER,
		POT,
		STATION,
		TRANSFER_ARM,
		TRANSFER_POT,
		RETURN_POT,
		STAGING_POT,
		REMOVAL_POT,
		EXPIRED_POT,
		};

		private ACTUATORValue _ACTUATOR;
		/// <inheritdoc cref="ACTUATORValue" path="/summary" />
		public ACTUATORValue ACTUATOR => _ACTUATOR ?? (_ACTUATOR = new ACTUATORValue());

		/// <summary>﻿<see cref="Composition">Composition</see> composed of a mechanism that moves or controls a mechanical part of a piece of equipment.<br /><br />It takes energy usually provided by air, electric current, or liquid and converts the energy into some kind of motion. <br /><br /><br />
		/// Value for CompositionTypeEnum.<br/>
		/// <br/>See also <seealso cref="CompositionTypeEnum">CompositionTypeEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.4">v1.4</see></item>
		/// </list>
		/// </remarks>

		public sealed class ACTUATORValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="ACTUATORValue.Name" /></summary>
			public const string NAME = "ACTUATOR";
			/// <summary>Constant value for <see cref="ACTUATORValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.4";
			/// <summary>Constant value for <see cref="ACTUATORValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="ACTUATORValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;{{block(Composition)}} composed of a mechanism that moves or controls a mechanical part of a piece of equipment.

It takes energy usually provided by air, electric current, or liquid and converts the energy into some kind of motion. &#10;
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
		private AMPLIFIERValue _AMPLIFIER;
		/// <inheritdoc cref="AMPLIFIERValue" path="/summary" />
		public AMPLIFIERValue AMPLIFIER => _AMPLIFIER ?? (_AMPLIFIER = new AMPLIFIERValue());

		/// <summary>﻿<see cref="Composition">Composition</see> composed of an electronic component or circuit that amplifies power, electric current, or voltage.<br /><br /><br />
		/// Value for CompositionTypeEnum.<br/>
		/// <br/>See also <seealso cref="CompositionTypeEnum">CompositionTypeEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.4">v1.4</see></item>
		/// </list>
		/// </remarks>

		public sealed class AMPLIFIERValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="AMPLIFIERValue.Name" /></summary>
			public const string NAME = "AMPLIFIER";
			/// <summary>Constant value for <see cref="AMPLIFIERValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.4";
			/// <summary>Constant value for <see cref="AMPLIFIERValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="AMPLIFIERValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;{{block(Composition)}} composed of an electronic component or circuit that amplifies power, electric current, or voltage.&#10;
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
		private BALLSCREWValue _BALLSCREW;
		/// <inheritdoc cref="BALLSCREWValue" path="/summary" />
		public BALLSCREWValue BALLSCREW => _BALLSCREW ?? (_BALLSCREW = new BALLSCREWValue());

		/// <summary>﻿<see cref="Composition">Composition</see> composed of a mechanical structure that transforms rotary motion into linear motion.<br /><br /><br />
		/// Value for CompositionTypeEnum.<br/>
		/// <br/>See also <seealso cref="CompositionTypeEnum">CompositionTypeEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.4">v1.4</see></item>
		/// </list>
		/// </remarks>

		public sealed class BALLSCREWValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="BALLSCREWValue.Name" /></summary>
			public const string NAME = "BALLSCREW";
			/// <summary>Constant value for <see cref="BALLSCREWValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.4";
			/// <summary>Constant value for <see cref="BALLSCREWValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="BALLSCREWValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;{{block(Composition)}} composed of a mechanical structure that transforms rotary motion into linear motion.&#10;
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
		private BELTValue _BELT;
		/// <inheritdoc cref="BELTValue" path="/summary" />
		public BELTValue BELT => _BELT ?? (_BELT = new BELTValue());

		/// <summary>﻿<see cref="Composition">Composition</see> composed of an endless flexible band that transmits motion for a piece of equipment or conveys materials and objects.<br /><br /><br />
		/// Value for CompositionTypeEnum.<br/>
		/// <br/>See also <seealso cref="CompositionTypeEnum">CompositionTypeEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.4">v1.4</see></item>
		/// </list>
		/// </remarks>

		public sealed class BELTValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="BELTValue.Name" /></summary>
			public const string NAME = "BELT";
			/// <summary>Constant value for <see cref="BELTValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.4";
			/// <summary>Constant value for <see cref="BELTValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="BELTValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;{{block(Composition)}} composed of an endless flexible band that transmits motion for a piece of equipment or conveys materials and objects.&#10;
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
		private BRAKEValue _BRAKE;
		/// <inheritdoc cref="BRAKEValue" path="/summary" />
		public BRAKEValue BRAKE => _BRAKE ?? (_BRAKE = new BRAKEValue());

		/// <summary>﻿<see cref="Composition">Composition</see> composed of a mechanism that slows down or stops a moving object by the absorption or transfer of the energy of momentum, usually by means of friction, electrical force, or magnetic force.<br /><br /><br />
		/// Value for CompositionTypeEnum.<br/>
		/// <br/>See also <seealso cref="CompositionTypeEnum">CompositionTypeEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.4">v1.4</see></item>
		/// </list>
		/// </remarks>

		public sealed class BRAKEValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="BRAKEValue.Name" /></summary>
			public const string NAME = "BRAKE";
			/// <summary>Constant value for <see cref="BRAKEValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.4";
			/// <summary>Constant value for <see cref="BRAKEValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="BRAKEValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;{{block(Composition)}} composed of a mechanism that slows down or stops a moving object by the absorption or transfer of the energy of momentum, usually by means of friction, electrical force, or magnetic force.&#10;
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
		private CHAINValue _CHAIN;
		/// <inheritdoc cref="CHAINValue" path="/summary" />
		public CHAINValue CHAIN => _CHAIN ?? (_CHAIN = new CHAINValue());

		/// <summary>﻿<see cref="Composition">Composition</see> composed of an interconnected series of objects that band together and transmit motion for a piece of equipment or to convey materials and objects.<br /><br /><br />
		/// Value for CompositionTypeEnum.<br/>
		/// <br/>See also <seealso cref="CompositionTypeEnum">CompositionTypeEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.4">v1.4</see></item>
		/// </list>
		/// </remarks>

		public sealed class CHAINValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="CHAINValue.Name" /></summary>
			public const string NAME = "CHAIN";
			/// <summary>Constant value for <see cref="CHAINValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.4";
			/// <summary>Constant value for <see cref="CHAINValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="CHAINValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;{{block(Composition)}} composed of an interconnected series of objects that band together and transmit motion for a piece of equipment or to convey materials and objects.&#10;
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
		private CHOPPERValue _CHOPPER;
		/// <inheritdoc cref="CHOPPERValue" path="/summary" />
		public CHOPPERValue CHOPPER => _CHOPPER ?? (_CHOPPER = new CHOPPERValue());

		/// <summary>﻿<see cref="Composition">Composition</see> composed of a mechanism that breaks material into smaller pieces.<br /><br /><br />
		/// Value for CompositionTypeEnum.<br/>
		/// <br/>See also <seealso cref="CompositionTypeEnum">CompositionTypeEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.4">v1.4</see></item>
		/// </list>
		/// </remarks>

		public sealed class CHOPPERValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="CHOPPERValue.Name" /></summary>
			public const string NAME = "CHOPPER";
			/// <summary>Constant value for <see cref="CHOPPERValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.4";
			/// <summary>Constant value for <see cref="CHOPPERValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="CHOPPERValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;{{block(Composition)}} composed of a mechanism that breaks material into smaller pieces.&#10;
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
		private CHUCKValue _CHUCK;
		/// <inheritdoc cref="CHUCKValue" path="/summary" />
		public CHUCKValue CHUCK => _CHUCK ?? (_CHUCK = new CHUCKValue());

		/// <summary>﻿<see cref="Composition">Composition</see> composed of a mechanism that holds a part, stock material, or any other item in place.<br /><br /><br />
		/// Value for CompositionTypeEnum.<br/>
		/// <br/>See also <seealso cref="CompositionTypeEnum">CompositionTypeEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.4">v1.4</see></item>
		/// </list>
		/// </remarks>

		public sealed class CHUCKValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="CHUCKValue.Name" /></summary>
			public const string NAME = "CHUCK";
			/// <summary>Constant value for <see cref="CHUCKValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.4";
			/// <summary>Constant value for <see cref="CHUCKValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="CHUCKValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;{{block(Composition)}} composed of a mechanism that holds a part, stock material, or any other item in place.&#10;
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
		private CHUTEValue _CHUTE;
		/// <inheritdoc cref="CHUTEValue" path="/summary" />
		public CHUTEValue CHUTE => _CHUTE ?? (_CHUTE = new CHUTEValue());

		/// <summary>﻿<see cref="Composition">Composition</see> composed of an inclined channel that conveys material.<br /><br /><br />
		/// Value for CompositionTypeEnum.<br/>
		/// <br/>See also <seealso cref="CompositionTypeEnum">CompositionTypeEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.4">v1.4</see></item>
		/// </list>
		/// </remarks>

		public sealed class CHUTEValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="CHUTEValue.Name" /></summary>
			public const string NAME = "CHUTE";
			/// <summary>Constant value for <see cref="CHUTEValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.4";
			/// <summary>Constant value for <see cref="CHUTEValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="CHUTEValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;{{block(Composition)}} composed of an inclined channel that conveys material.&#10;
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
		private CIRCUIT_BREAKERValue _CIRCUIT_BREAKER;
		/// <inheritdoc cref="CIRCUIT_BREAKERValue" path="/summary" />
		public CIRCUIT_BREAKERValue CIRCUIT_BREAKER => _CIRCUIT_BREAKER ?? (_CIRCUIT_BREAKER = new CIRCUIT_BREAKERValue());

		/// <summary>﻿<see cref="Composition">Composition</see> composed of a mechanism that interrupts an electric circuit.<br /><br /><br />
		/// Value for CompositionTypeEnum.<br/>
		/// <br/>See also <seealso cref="CompositionTypeEnum">CompositionTypeEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.4">v1.4</see></item>
		/// </list>
		/// </remarks>

		public sealed class CIRCUIT_BREAKERValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="CIRCUIT_BREAKERValue.Name" /></summary>
			public const string NAME = "CIRCUIT_BREAKER";
			/// <summary>Constant value for <see cref="CIRCUIT_BREAKERValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.4";
			/// <summary>Constant value for <see cref="CIRCUIT_BREAKERValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="CIRCUIT_BREAKERValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;{{block(Composition)}} composed of a mechanism that interrupts an electric circuit.&#10;
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
		private CLAMPValue _CLAMP;
		/// <inheritdoc cref="CLAMPValue" path="/summary" />
		public CLAMPValue CLAMP => _CLAMP ?? (_CLAMP = new CLAMPValue());

		/// <summary>﻿<see cref="Composition">Composition</see> composed of a mechanism that strengthens, supports, or fastens objects in place.<br /><br /><br />
		/// Value for CompositionTypeEnum.<br/>
		/// <br/>See also <seealso cref="CompositionTypeEnum">CompositionTypeEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.4">v1.4</see></item>
		/// </list>
		/// </remarks>

		public sealed class CLAMPValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="CLAMPValue.Name" /></summary>
			public const string NAME = "CLAMP";
			/// <summary>Constant value for <see cref="CLAMPValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.4";
			/// <summary>Constant value for <see cref="CLAMPValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="CLAMPValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;{{block(Composition)}} composed of a mechanism that strengthens, supports, or fastens objects in place.&#10;
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
		private COMPRESSORValue _COMPRESSOR;
		/// <inheritdoc cref="COMPRESSORValue" path="/summary" />
		public COMPRESSORValue COMPRESSOR => _COMPRESSOR ?? (_COMPRESSOR = new COMPRESSORValue());

		/// <summary>﻿<see cref="Composition">Composition</see> composed of a pump or other mechanism that reduces volume and increases pressure of gases in order to condense the gases to drive pneumatically powered pieces of equipment.<br /><br /><br />
		/// Value for CompositionTypeEnum.<br/>
		/// <br/>See also <seealso cref="CompositionTypeEnum">CompositionTypeEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.4">v1.4</see></item>
		/// </list>
		/// </remarks>

		public sealed class COMPRESSORValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="COMPRESSORValue.Name" /></summary>
			public const string NAME = "COMPRESSOR";
			/// <summary>Constant value for <see cref="COMPRESSORValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.4";
			/// <summary>Constant value for <see cref="COMPRESSORValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="COMPRESSORValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;{{block(Composition)}} composed of a pump or other mechanism that reduces volume and increases pressure of gases in order to condense the gases to drive pneumatically powered pieces of equipment.&#10;
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
		private DOORValue _DOOR;
		/// <inheritdoc cref="DOORValue" path="/summary" />
		public DOORValue DOOR => _DOOR ?? (_DOOR = new DOORValue());

		/// <summary>﻿<see cref="Composition">Composition</see> composed of a mechanical mechanism or closure that covers a physical access portal into a piece of equipment allowing or restricting access to other parts of the equipment.<br /><br /><br />
		/// Value for CompositionTypeEnum.<br/>
		/// <br/>See also <seealso cref="CompositionTypeEnum">CompositionTypeEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.4">v1.4</see></item>
		/// </list>
		/// </remarks>

		public sealed class DOORValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="DOORValue.Name" /></summary>
			public const string NAME = "DOOR";
			/// <summary>Constant value for <see cref="DOORValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.4";
			/// <summary>Constant value for <see cref="DOORValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="DOORValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;{{block(Composition)}} composed of a mechanical mechanism or closure that covers a physical access portal into a piece of equipment allowing or restricting access to other parts of the equipment.&#10;
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
		private DRAINValue _DRAIN;
		/// <inheritdoc cref="DRAINValue" path="/summary" />
		public DRAINValue DRAIN => _DRAIN ?? (_DRAIN = new DRAINValue());

		/// <summary>﻿<see cref="Composition">Composition</see> composed of a mechanism that allows material to flow for the purpose of drainage from, for example, a vessel or tank.<br /><br /><br />
		/// Value for CompositionTypeEnum.<br/>
		/// <br/>See also <seealso cref="CompositionTypeEnum">CompositionTypeEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.4">v1.4</see></item>
		/// </list>
		/// </remarks>

		public sealed class DRAINValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="DRAINValue.Name" /></summary>
			public const string NAME = "DRAIN";
			/// <summary>Constant value for <see cref="DRAINValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.4";
			/// <summary>Constant value for <see cref="DRAINValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="DRAINValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;{{block(Composition)}} composed of a mechanism that allows material to flow for the purpose of drainage from, for example, a vessel or tank.&#10;
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
		private ENCODERValue _ENCODER;
		/// <inheritdoc cref="ENCODERValue" path="/summary" />
		public ENCODERValue ENCODER => _ENCODER ?? (_ENCODER = new ENCODERValue());

		/// <summary>﻿<see cref="Composition">Composition</see> composed of a mechanism that measures rotary position.<br /><br /><br />
		/// Value for CompositionTypeEnum.<br/>
		/// <br/>See also <seealso cref="CompositionTypeEnum">CompositionTypeEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.4">v1.4</see></item>
		/// </list>
		/// </remarks>

		public sealed class ENCODERValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="ENCODERValue.Name" /></summary>
			public const string NAME = "ENCODER";
			/// <summary>Constant value for <see cref="ENCODERValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.4";
			/// <summary>Constant value for <see cref="ENCODERValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="ENCODERValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;{{block(Composition)}} composed of a mechanism that measures rotary position.&#10;
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
		private EXPOSURE_UNITValue _EXPOSURE_UNIT;
		/// <inheritdoc cref="EXPOSURE_UNITValue" path="/summary" />
		public EXPOSURE_UNITValue EXPOSURE_UNIT => _EXPOSURE_UNIT ?? (_EXPOSURE_UNIT = new EXPOSURE_UNITValue());

		/// <summary>﻿<see cref="Composition">Composition</see> composed of a mechanism that emits a type of radiation.<br /><br /><br />
		/// Value for CompositionTypeEnum.<br/>
		/// <br/>See also <seealso cref="CompositionTypeEnum">CompositionTypeEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.4">v1.4</see></item>
		/// </list>
		/// </remarks>

		public sealed class EXPOSURE_UNITValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="EXPOSURE_UNITValue.Name" /></summary>
			public const string NAME = "EXPOSURE_UNIT";
			/// <summary>Constant value for <see cref="EXPOSURE_UNITValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.5";
			/// <summary>Constant value for <see cref="EXPOSURE_UNITValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="EXPOSURE_UNITValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;{{block(Composition)}} composed of a mechanism that emits a type of radiation.&#10;
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
		private EXTRUSION_UNITValue _EXTRUSION_UNIT;
		/// <inheritdoc cref="EXTRUSION_UNITValue" path="/summary" />
		public EXTRUSION_UNITValue EXTRUSION_UNIT => _EXTRUSION_UNIT ?? (_EXTRUSION_UNIT = new EXTRUSION_UNITValue());

		/// <summary>﻿<see cref="Composition">Composition</see> composed of a mechanism that dispenses liquid or powered materials.<br /><br /><br />
		/// Value for CompositionTypeEnum.<br/>
		/// <br/>See also <seealso cref="CompositionTypeEnum">CompositionTypeEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.4">v1.4</see></item>
		/// </list>
		/// </remarks>

		public sealed class EXTRUSION_UNITValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="EXTRUSION_UNITValue.Name" /></summary>
			public const string NAME = "EXTRUSION_UNIT";
			/// <summary>Constant value for <see cref="EXTRUSION_UNITValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.5";
			/// <summary>Constant value for <see cref="EXTRUSION_UNITValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="EXTRUSION_UNITValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;{{block(Composition)}} composed of a mechanism that dispenses liquid or powered materials.&#10;
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
		private FANValue _FAN;
		/// <inheritdoc cref="FANValue" path="/summary" />
		public FANValue FAN => _FAN ?? (_FAN = new FANValue());

		/// <summary>﻿<see cref="Composition">Composition</see> composed of a mechanism that produces a current of air.<br /><br /><br />
		/// Value for CompositionTypeEnum.<br/>
		/// <br/>See also <seealso cref="CompositionTypeEnum">CompositionTypeEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.4">v1.4</see></item>
		/// </list>
		/// </remarks>

		public sealed class FANValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="FANValue.Name" /></summary>
			public const string NAME = "FAN";
			/// <summary>Constant value for <see cref="FANValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.4";
			/// <summary>Constant value for <see cref="FANValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="FANValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;{{block(Composition)}} composed of a mechanism that produces a current of air.&#10;
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
		private FILTERValue _FILTER;
		/// <inheritdoc cref="FILTERValue" path="/summary" />
		public FILTERValue FILTER => _FILTER ?? (_FILTER = new FILTERValue());

		/// <summary>﻿<see cref="Composition">Composition</see> composed of a substance or structure that allows liquids or gases to pass through to remove suspended impurities or to recover solids.<br /><br /><br />
		/// Value for CompositionTypeEnum.<br/>
		/// <br/>See also <seealso cref="CompositionTypeEnum">CompositionTypeEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.4">v1.4</see></item>
		/// </list>
		/// </remarks>

		public sealed class FILTERValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="FILTERValue.Name" /></summary>
			public const string NAME = "FILTER";
			/// <summary>Constant value for <see cref="FILTERValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.4";
			/// <summary>Constant value for <see cref="FILTERValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="FILTERValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;{{block(Composition)}} composed of a substance or structure that allows liquids or gases to pass through to remove suspended impurities or to recover solids.&#10;
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
		private GALVANOMOTORValue _GALVANOMOTOR;
		/// <inheritdoc cref="GALVANOMOTORValue" path="/summary" />
		public GALVANOMOTORValue GALVANOMOTOR => _GALVANOMOTOR ?? (_GALVANOMOTOR = new GALVANOMOTORValue());

		/// <summary>﻿<see cref="Composition">Composition</see> composed of an electromechanical actuator that produces deflection of a beam of light or energy in response to electric current through its coil in a magnetic field.<br /><br /><br />
		/// Value for CompositionTypeEnum.<br/>
		/// <br/>See also <seealso cref="CompositionTypeEnum">CompositionTypeEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.4">v1.4</see></item>
		/// </list>
		/// </remarks>

		public sealed class GALVANOMOTORValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="GALVANOMOTORValue.Name" /></summary>
			public const string NAME = "GALVANOMOTOR";
			/// <summary>Constant value for <see cref="GALVANOMOTORValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.5";
			/// <summary>Constant value for <see cref="GALVANOMOTORValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="GALVANOMOTORValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;{{block(Composition)}} composed of an electromechanical actuator that produces deflection of a beam of light or energy in response to electric current through its coil in a magnetic field.&#10;
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
		private GRIPPERValue _GRIPPER;
		/// <inheritdoc cref="GRIPPERValue" path="/summary" />
		public GRIPPERValue GRIPPER => _GRIPPER ?? (_GRIPPER = new GRIPPERValue());

		/// <summary>﻿<see cref="Composition">Composition</see> composed of a mechanism that holds a part, stock material, or any other item in place.<br /><br /><br />
		/// Value for CompositionTypeEnum.<br/>
		/// <br/>See also <seealso cref="CompositionTypeEnum">CompositionTypeEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.4">v1.4</see></item>
		/// </list>
		/// </remarks>

		public sealed class GRIPPERValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="GRIPPERValue.Name" /></summary>
			public const string NAME = "GRIPPER";
			/// <summary>Constant value for <see cref="GRIPPERValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.4";
			/// <summary>Constant value for <see cref="GRIPPERValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="GRIPPERValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;{{block(Composition)}} composed of a mechanism that holds a part, stock material, or any other item in place.&#10;
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
		private HOPPERValue _HOPPER;
		/// <inheritdoc cref="HOPPERValue" path="/summary" />
		public HOPPERValue HOPPER => _HOPPER ?? (_HOPPER = new HOPPERValue());

		/// <summary>﻿<see cref="Composition">Composition</see> composed of a chamber or bin that stores materials temporarily, typically being filled through the top and dispensed through the bottom.<br /><br /><br />
		/// Value for CompositionTypeEnum.<br/>
		/// <br/>See also <seealso cref="CompositionTypeEnum">CompositionTypeEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.4">v1.4</see></item>
		/// </list>
		/// </remarks>

		public sealed class HOPPERValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="HOPPERValue.Name" /></summary>
			public const string NAME = "HOPPER";
			/// <summary>Constant value for <see cref="HOPPERValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.4";
			/// <summary>Constant value for <see cref="HOPPERValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="HOPPERValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;{{block(Composition)}} composed of a chamber or bin that stores materials temporarily, typically being filled through the top and dispensed through the bottom.&#10;
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
		private LINEAR_POSITION_FEEDBACKValue _LINEAR_POSITION_FEEDBACK;
		/// <inheritdoc cref="LINEAR_POSITION_FEEDBACKValue" path="/summary" />
		public LINEAR_POSITION_FEEDBACKValue LINEAR_POSITION_FEEDBACK => _LINEAR_POSITION_FEEDBACK ?? (_LINEAR_POSITION_FEEDBACK = new LINEAR_POSITION_FEEDBACKValue());

		/// <summary>﻿<see cref="Composition">Composition</see> composed of a mechanism that measures linear motion or position.<br /><br /><br />
		/// Value for CompositionTypeEnum.<br/>
		/// <br/>See also <seealso cref="CompositionTypeEnum">CompositionTypeEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.4">v1.4</see></item>
		/// </list>
		/// </remarks>

		public sealed class LINEAR_POSITION_FEEDBACKValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="LINEAR_POSITION_FEEDBACKValue.Name" /></summary>
			public const string NAME = "LINEAR_POSITION_FEEDBACK";
			/// <summary>Constant value for <see cref="LINEAR_POSITION_FEEDBACKValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.4";
			/// <summary>Constant value for <see cref="LINEAR_POSITION_FEEDBACKValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="LINEAR_POSITION_FEEDBACKValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;{{block(Composition)}} composed of a mechanism that measures linear motion or position.&#10;
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
		private MOTORValue _MOTOR;
		/// <inheritdoc cref="MOTORValue" path="/summary" />
		public MOTORValue MOTOR => _MOTOR ?? (_MOTOR = new MOTORValue());

		/// <summary>﻿<see cref="Composition">Composition</see> composed of a mechanism that converts electrical, pneumatic, or hydraulic energy into mechanical energy.<br /><br /><br />
		/// Value for CompositionTypeEnum.<br/>
		/// <br/>See also <seealso cref="CompositionTypeEnum">CompositionTypeEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.4">v1.4</see></item>
		/// </list>
		/// </remarks>

		public sealed class MOTORValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="MOTORValue.Name" /></summary>
			public const string NAME = "MOTOR";
			/// <summary>Constant value for <see cref="MOTORValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.4";
			/// <summary>Constant value for <see cref="MOTORValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="MOTORValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;{{block(Composition)}} composed of a mechanism that converts electrical, pneumatic, or hydraulic energy into mechanical energy.&#10;
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
		private OILValue _OIL;
		/// <inheritdoc cref="OILValue" path="/summary" />
		public OILValue OIL => _OIL ?? (_OIL = new OILValue());

		/// <summary>﻿<see cref="Composition">Composition</see> composed of a viscous liquid.<br /><br /><br />
		/// Value for CompositionTypeEnum.<br/>
		/// <br/>See also <seealso cref="CompositionTypeEnum">CompositionTypeEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.4">v1.4</see></item>
		/// </list>
		/// </remarks>

		public sealed class OILValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="OILValue.Name" /></summary>
			public const string NAME = "OIL";
			/// <summary>Constant value for <see cref="OILValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.4";
			/// <summary>Constant value for <see cref="OILValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="OILValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;{{block(Composition)}} composed of a viscous liquid.&#10;
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
		private POWER_SUPPLYValue _POWER_SUPPLY;
		/// <inheritdoc cref="POWER_SUPPLYValue" path="/summary" />
		public POWER_SUPPLYValue POWER_SUPPLY => _POWER_SUPPLY ?? (_POWER_SUPPLY = new POWER_SUPPLYValue());

		/// <summary>﻿<see cref="Composition">Composition</see> composed of a unit that provides power to electric mechanisms.<br /><br /><br />
		/// Value for CompositionTypeEnum.<br/>
		/// <br/>See also <seealso cref="CompositionTypeEnum">CompositionTypeEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.4">v1.4</see></item>
		/// </list>
		/// </remarks>

		public sealed class POWER_SUPPLYValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="POWER_SUPPLYValue.Name" /></summary>
			public const string NAME = "POWER_SUPPLY";
			/// <summary>Constant value for <see cref="POWER_SUPPLYValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.4";
			/// <summary>Constant value for <see cref="POWER_SUPPLYValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="POWER_SUPPLYValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;{{block(Composition)}} composed of a unit that provides power to electric mechanisms.&#10;
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
		private PULLEYValue _PULLEY;
		/// <inheritdoc cref="PULLEYValue" path="/summary" />
		public PULLEYValue PULLEY => _PULLEY ?? (_PULLEY = new PULLEYValue());

		/// <summary>﻿<see cref="Composition">Composition</see> composed of a mechanism or wheel that turns in a frame or block and serves to change the direction of or to transmit force.<br /><br /><br />
		/// Value for CompositionTypeEnum.<br/>
		/// <br/>See also <seealso cref="CompositionTypeEnum">CompositionTypeEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.4">v1.4</see></item>
		/// </list>
		/// </remarks>

		public sealed class PULLEYValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="PULLEYValue.Name" /></summary>
			public const string NAME = "PULLEY";
			/// <summary>Constant value for <see cref="PULLEYValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.4";
			/// <summary>Constant value for <see cref="PULLEYValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="PULLEYValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;{{block(Composition)}} composed of a mechanism or wheel that turns in a frame or block and serves to change the direction of or to transmit force.&#10;
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
		private PUMPValue _PUMP;
		/// <inheritdoc cref="PUMPValue" path="/summary" />
		public PUMPValue PUMP => _PUMP ?? (_PUMP = new PUMPValue());

		/// <summary>﻿<see cref="Composition">Composition</see> composed of an apparatus that raises, drives, exhausts, or compresses fluids or gases by means of a piston, plunger, or set of rotating vanes.<br /><br /><br />
		/// Value for CompositionTypeEnum.<br/>
		/// <br/>See also <seealso cref="CompositionTypeEnum">CompositionTypeEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.4">v1.4</see></item>
		/// </list>
		/// </remarks>

		public sealed class PUMPValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="PUMPValue.Name" /></summary>
			public const string NAME = "PUMP";
			/// <summary>Constant value for <see cref="PUMPValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.4";
			/// <summary>Constant value for <see cref="PUMPValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="PUMPValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;{{block(Composition)}} composed of an apparatus that raises, drives, exhausts, or compresses fluids or gases by means of a piston, plunger, or set of rotating vanes.&#10;
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
		private REELValue _REEL;
		/// <inheritdoc cref="REELValue" path="/summary" />
		public REELValue REEL => _REEL ?? (_REEL = new REELValue());

		/// <summary>﻿<see cref="Composition">Composition</see> composed of a rotary storage unit for material.<br /><br /><br />
		/// Value for CompositionTypeEnum.<br/>
		/// <br/>See also <seealso cref="CompositionTypeEnum">CompositionTypeEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.4">v1.4</see></item>
		/// </list>
		/// </remarks>

		public sealed class REELValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="REELValue.Name" /></summary>
			public const string NAME = "REEL";
			/// <summary>Constant value for <see cref="REELValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.5";
			/// <summary>Constant value for <see cref="REELValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="REELValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;{{block(Composition)}} composed of a rotary storage unit for material.&#10;
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
		private SENSING_ELEMENTValue _SENSING_ELEMENT;
		/// <inheritdoc cref="SENSING_ELEMENTValue" path="/summary" />
		public SENSING_ELEMENTValue SENSING_ELEMENT => _SENSING_ELEMENT ?? (_SENSING_ELEMENT = new SENSING_ELEMENTValue());

		/// <summary>﻿<see cref="Composition">Composition</see> composed of a mechanism that provides a signal or measured value.<br /><br /><br />
		/// Value for CompositionTypeEnum.<br/>
		/// <br/>See also <seealso cref="CompositionTypeEnum">CompositionTypeEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.4">v1.4</see></item>
		/// </list>
		/// </remarks>

		public sealed class SENSING_ELEMENTValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="SENSING_ELEMENTValue.Name" /></summary>
			public const string NAME = "SENSING_ELEMENT";
			/// <summary>Constant value for <see cref="SENSING_ELEMENTValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.4";
			/// <summary>Constant value for <see cref="SENSING_ELEMENTValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="SENSING_ELEMENTValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;{{block(Composition)}} composed of a mechanism that provides a signal or measured value.&#10;
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
		private SPREADERValue _SPREADER;
		/// <inheritdoc cref="SPREADERValue" path="/summary" />
		public SPREADERValue SPREADER => _SPREADER ?? (_SPREADER = new SPREADERValue());

		/// <summary>﻿<see cref="Composition">Composition</see> composed of a mechanism that flattens or spreads materials.<br /><br /><br />
		/// Value for CompositionTypeEnum.<br/>
		/// <br/>See also <seealso cref="CompositionTypeEnum">CompositionTypeEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.4">v1.4</see></item>
		/// </list>
		/// </remarks>

		public sealed class SPREADERValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="SPREADERValue.Name" /></summary>
			public const string NAME = "SPREADER";
			/// <summary>Constant value for <see cref="SPREADERValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.5";
			/// <summary>Constant value for <see cref="SPREADERValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="SPREADERValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;{{block(Composition)}} composed of a mechanism that flattens or spreads materials.&#10;
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
		private STORAGE_BATTERYValue _STORAGE_BATTERY;
		/// <inheritdoc cref="STORAGE_BATTERYValue" path="/summary" />
		public STORAGE_BATTERYValue STORAGE_BATTERY => _STORAGE_BATTERY ?? (_STORAGE_BATTERY = new STORAGE_BATTERYValue());

		/// <summary>﻿<see cref="Composition">Composition</see> composed of one or more cells that converts chemical energy to electricity and serves as a source of power. <br /><br /><br />
		/// Value for CompositionTypeEnum.<br/>
		/// <br/>See also <seealso cref="CompositionTypeEnum">CompositionTypeEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.4">v1.4</see></item>
		/// </list>
		/// </remarks>

		public sealed class STORAGE_BATTERYValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="STORAGE_BATTERYValue.Name" /></summary>
			public const string NAME = "STORAGE_BATTERY";
			/// <summary>Constant value for <see cref="STORAGE_BATTERYValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.4";
			/// <summary>Constant value for <see cref="STORAGE_BATTERYValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="STORAGE_BATTERYValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;{{block(Composition)}} composed of one or more cells that converts chemical energy to electricity and serves as a source of power. &#10;
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
		private SWITCHValue _SWITCH;
		/// <inheritdoc cref="SWITCHValue" path="/summary" />
		public SWITCHValue SWITCH => _SWITCH ?? (_SWITCH = new SWITCHValue());

		/// <summary>﻿<see cref="Composition">Composition</see> composed of a mechanism that turns on or off an electric current or makes or breaks a circuit.<br /><br /><br />
		/// Value for CompositionTypeEnum.<br/>
		/// <br/>See also <seealso cref="CompositionTypeEnum">CompositionTypeEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.4">v1.4</see></item>
		/// </list>
		/// </remarks>

		public sealed class SWITCHValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="SWITCHValue.Name" /></summary>
			public const string NAME = "SWITCH";
			/// <summary>Constant value for <see cref="SWITCHValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.4";
			/// <summary>Constant value for <see cref="SWITCHValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="SWITCHValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;{{block(Composition)}} composed of a mechanism that turns on or off an electric current or makes or breaks a circuit.&#10;
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
		private TABLEValue _TABLE;
		/// <inheritdoc cref="TABLEValue" path="/summary" />
		public TABLEValue TABLE => _TABLE ?? (_TABLE = new TABLEValue());

		/// <summary>﻿<see cref="Composition">Composition</see> composed of a surface that holds an object or material.<br /><br /><br />
		/// Value for CompositionTypeEnum.<br/>
		/// <br/>See also <seealso cref="CompositionTypeEnum">CompositionTypeEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.4">v1.4</see></item>
		/// </list>
		/// </remarks>

		public sealed class TABLEValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="TABLEValue.Name" /></summary>
			public const string NAME = "TABLE";
			/// <summary>Constant value for <see cref="TABLEValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.5";
			/// <summary>Constant value for <see cref="TABLEValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="TABLEValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;{{block(Composition)}} composed of a surface that holds an object or material.&#10;
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
		private TANKValue _TANK;
		/// <inheritdoc cref="TANKValue" path="/summary" />
		public TANKValue TANK => _TANK ?? (_TANK = new TANKValue());

		/// <summary>﻿<see cref="Composition">Composition</see> composed of a receptacle or container that holds material.<br /><br /><br />
		/// Value for CompositionTypeEnum.<br/>
		/// <br/>See also <seealso cref="CompositionTypeEnum">CompositionTypeEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.4">v1.4</see></item>
		/// </list>
		/// </remarks>

		public sealed class TANKValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="TANKValue.Name" /></summary>
			public const string NAME = "TANK";
			/// <summary>Constant value for <see cref="TANKValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.4";
			/// <summary>Constant value for <see cref="TANKValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="TANKValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;{{block(Composition)}} composed of a receptacle or container that holds material.&#10;
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
		private TENSIONERValue _TENSIONER;
		/// <inheritdoc cref="TENSIONERValue" path="/summary" />
		public TENSIONERValue TENSIONER => _TENSIONER ?? (_TENSIONER = new TENSIONERValue());

		/// <summary>﻿<see cref="Composition">Composition</see> composed of a mechanism that provides or applies a stretch or strain to another mechanism.<br /><br /><br />
		/// Value for CompositionTypeEnum.<br/>
		/// <br/>See also <seealso cref="CompositionTypeEnum">CompositionTypeEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.4">v1.4</see></item>
		/// </list>
		/// </remarks>

		public sealed class TENSIONERValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="TENSIONERValue.Name" /></summary>
			public const string NAME = "TENSIONER";
			/// <summary>Constant value for <see cref="TENSIONERValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.4";
			/// <summary>Constant value for <see cref="TENSIONERValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="TENSIONERValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;{{block(Composition)}} composed of a mechanism that provides or applies a stretch or strain to another mechanism.&#10;
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
		private TRANSFORMERValue _TRANSFORMER;
		/// <inheritdoc cref="TRANSFORMERValue" path="/summary" />
		public TRANSFORMERValue TRANSFORMER => _TRANSFORMER ?? (_TRANSFORMER = new TRANSFORMERValue());

		/// <summary>﻿<see cref="Composition">Composition</see> composed of a mechanism that transforms electric energy from a source to a secondary circuit.<br /><br /><br />
		/// Value for CompositionTypeEnum.<br/>
		/// <br/>See also <seealso cref="CompositionTypeEnum">CompositionTypeEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.4">v1.4</see></item>
		/// </list>
		/// </remarks>

		public sealed class TRANSFORMERValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="TRANSFORMERValue.Name" /></summary>
			public const string NAME = "TRANSFORMER";
			/// <summary>Constant value for <see cref="TRANSFORMERValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.5";
			/// <summary>Constant value for <see cref="TRANSFORMERValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="TRANSFORMERValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;{{block(Composition)}} composed of a mechanism that transforms electric energy from a source to a secondary circuit.&#10;
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
		private VALVEValue _VALVE;
		/// <inheritdoc cref="VALVEValue" path="/summary" />
		public VALVEValue VALVE => _VALVE ?? (_VALVE = new VALVEValue());

		/// <summary>﻿<see cref="Composition">Composition</see> composed of a mechanism that halts or controls the flow of a liquid, gas, or other material through a passage, pipe, inlet, or outlet.<br /><br /><br />
		/// Value for CompositionTypeEnum.<br/>
		/// <br/>See also <seealso cref="CompositionTypeEnum">CompositionTypeEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.4">v1.4</see></item>
		/// </list>
		/// </remarks>

		public sealed class VALVEValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="VALVEValue.Name" /></summary>
			public const string NAME = "VALVE";
			/// <summary>Constant value for <see cref="VALVEValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.4";
			/// <summary>Constant value for <see cref="VALVEValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="VALVEValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;{{block(Composition)}} composed of a mechanism that halts or controls the flow of a liquid, gas, or other material through a passage, pipe, inlet, or outlet.&#10;
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
		private VATValue _VAT;
		/// <inheritdoc cref="VATValue" path="/summary" />
		public VATValue VAT => _VAT ?? (_VAT = new VATValue());

		/// <summary>﻿<see cref="Composition">Composition</see> composed of a container for liquid or powdered materials.<br /><br /><br />
		/// Value for CompositionTypeEnum.<br/>
		/// <br/>See also <seealso cref="CompositionTypeEnum">CompositionTypeEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.4">v1.4</see></item>
		/// </list>
		/// </remarks>

		public sealed class VATValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="VATValue.Name" /></summary>
			public const string NAME = "VAT";
			/// <summary>Constant value for <see cref="VATValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.5";
			/// <summary>Constant value for <see cref="VATValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="VATValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;{{block(Composition)}} composed of a container for liquid or powdered materials.&#10;
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
		private WATERValue _WATER;
		/// <inheritdoc cref="WATERValue" path="/summary" />
		public WATERValue WATER => _WATER ?? (_WATER = new WATERValue());

		/// <summary>﻿<see cref="Composition">Composition</see> composed of a fluid.<br /><br /><br />
		/// Value for CompositionTypeEnum.<br/>
		/// <br/>See also <seealso cref="CompositionTypeEnum">CompositionTypeEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.4">v1.4</see></item>
		/// </list>
		/// </remarks>

		public sealed class WATERValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="WATERValue.Name" /></summary>
			public const string NAME = "WATER";
			/// <summary>Constant value for <see cref="WATERValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.4";
			/// <summary>Constant value for <see cref="WATERValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="WATERValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;{{block(Composition)}} composed of a fluid.&#10;
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

		/// <summary>﻿<see cref="Composition">Composition</see> composed of a string like piece or filament of relatively rigid or flexible material provided in a variety of diameters.<br /><br /><br />
		/// Value for CompositionTypeEnum.<br/>
		/// <br/>See also <seealso cref="CompositionTypeEnum">CompositionTypeEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.4">v1.4</see></item>
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
			public const string SUMMARY = @"&#10;&#10;&#10;{{block(Composition)}} composed of a string like piece or filament of relatively rigid or flexible material provided in a variety of diameters.&#10;
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
		private WORKPIECEValue _WORKPIECE;
		/// <inheritdoc cref="WORKPIECEValue" path="/summary" />
		public WORKPIECEValue WORKPIECE => _WORKPIECE ?? (_WORKPIECE = new WORKPIECEValue());

		/// <summary>﻿<see cref="Composition">Composition</see> composed of an object or material on which a form of work is performed.<br /><br /><br />
		/// Value for CompositionTypeEnum.<br/>
		/// <br/>See also <seealso cref="CompositionTypeEnum">CompositionTypeEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.4">v1.4</see></item>
		/// </list>
		/// </remarks>

		public sealed class WORKPIECEValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="WORKPIECEValue.Name" /></summary>
			public const string NAME = "WORKPIECE";
			/// <summary>Constant value for <see cref="WORKPIECEValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.6";
			/// <summary>Constant value for <see cref="WORKPIECEValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="WORKPIECEValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;{{block(Composition)}} composed of an object or material on which a form of work is performed.&#10;
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
		private COOLING_TOWERValue _COOLING_TOWER;
		/// <inheritdoc cref="COOLING_TOWERValue" path="/summary" />
		public COOLING_TOWERValue COOLING_TOWER => _COOLING_TOWER ?? (_COOLING_TOWER = new COOLING_TOWERValue());

		/// <summary>﻿<see cref="Composition">Composition</see> composed of a heat exchange system that uses a fluid to transfer heat to the atmosphere.<br /><br /><br />
		/// Value for CompositionTypeEnum.<br/>
		/// <br/>See also <seealso cref="CompositionTypeEnum">CompositionTypeEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.4">v1.4</see></item>
		/// </list>
		/// </remarks>

		public sealed class COOLING_TOWERValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="COOLING_TOWERValue.Name" /></summary>
			public const string NAME = "COOLING_TOWER";
			/// <summary>Constant value for <see cref="COOLING_TOWERValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.7";
			/// <summary>Constant value for <see cref="COOLING_TOWERValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="COOLING_TOWERValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;{{block(Composition)}} composed of a heat exchange system that uses a fluid to transfer heat to the atmosphere.&#10;
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
		private POTValue _POT;
		/// <inheritdoc cref="POTValue" path="/summary" />
		public POTValue POT => _POT ?? (_POT = new POTValue());

		/// <summary>﻿<see cref="Composition">Composition</see> composed of a tool storage location associated with a <see cref="ToolMagazine">ToolMagazine</see> or <see cref="AutomaticToolChanger">AutomaticToolChanger</see>.<br /><br /><br />
		/// Value for CompositionTypeEnum.<br/>
		/// <br/>See also <seealso cref="CompositionTypeEnum">CompositionTypeEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.4">v1.4</see></item>
		/// </list>
		/// </remarks>

		public sealed class POTValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="POTValue.Name" /></summary>
			public const string NAME = "POT";
			/// <summary>Constant value for <see cref="POTValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.7";
			/// <summary>Constant value for <see cref="POTValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="POTValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;{{block(Composition)}} composed of a tool storage location associated with a {{block(ToolMagazine)}} or {{block(AutomaticToolChanger)}}.&#10;
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
		private STATIONValue _STATION;
		/// <inheritdoc cref="STATIONValue" path="/summary" />
		public STATIONValue STATION => _STATION ?? (_STATION = new STATIONValue());

		/// <summary>﻿<see cref="Composition">Composition</see> composed of a storage or mounting location for a tool associated with a <see cref="Turret">Turret</see>, <see cref="GangToolBar">GangToolBar</see>, or <see cref="ToolRack">ToolRack</see>.<br /><br /><br />
		/// Value for CompositionTypeEnum.<br/>
		/// <br/>See also <seealso cref="CompositionTypeEnum">CompositionTypeEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.4">v1.4</see></item>
		/// </list>
		/// </remarks>

		public sealed class STATIONValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="STATIONValue.Name" /></summary>
			public const string NAME = "STATION";
			/// <summary>Constant value for <see cref="STATIONValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.7";
			/// <summary>Constant value for <see cref="STATIONValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="STATIONValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;{{block(Composition)}} composed of a storage or mounting location for a tool associated with a {{block(Turret)}}, {{block(GangToolBar)}}, or {{block(ToolRack)}}.&#10;
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
		private TRANSFER_ARMValue _TRANSFER_ARM;
		/// <inheritdoc cref="TRANSFER_ARMValue" path="/summary" />
		public TRANSFER_ARMValue TRANSFER_ARM => _TRANSFER_ARM ?? (_TRANSFER_ARM = new TRANSFER_ARMValue());

		/// <summary>﻿<see cref="Composition">Composition</see> composed of a mechanism that physically moves a tool from one location to another.<br /><br /><br />
		/// Value for CompositionTypeEnum.<br/>
		/// <br/>See also <seealso cref="CompositionTypeEnum">CompositionTypeEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.4">v1.4</see></item>
		/// </list>
		/// </remarks>

		public sealed class TRANSFER_ARMValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="TRANSFER_ARMValue.Name" /></summary>
			public const string NAME = "TRANSFER_ARM";
			/// <summary>Constant value for <see cref="TRANSFER_ARMValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.7";
			/// <summary>Constant value for <see cref="TRANSFER_ARMValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="TRANSFER_ARMValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;{{block(Composition)}} composed of a mechanism that physically moves a tool from one location to another.&#10;
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
		private TRANSFER_POTValue _TRANSFER_POT;
		/// <inheritdoc cref="TRANSFER_POTValue" path="/summary" />
		public TRANSFER_POTValue TRANSFER_POT => _TRANSFER_POT ?? (_TRANSFER_POT = new TRANSFER_POTValue());

		/// <summary>﻿<see cref="Pot">Pot</see> for a tool awaiting transfer from a <see cref="ToolMagazine">ToolMagazine</see> to <i>spindle</i> or <see cref="Turret">Turret</see>.<br /><br /><br />
		/// Value for CompositionTypeEnum.<br/>
		/// <br/>See also <seealso cref="CompositionTypeEnum">CompositionTypeEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.4">v1.4</see></item>
		/// </list>
		/// </remarks>

		public sealed class TRANSFER_POTValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="TRANSFER_POTValue.Name" /></summary>
			public const string NAME = "TRANSFER_POT";
			/// <summary>Constant value for <see cref="TRANSFER_POTValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.7";
			/// <summary>Constant value for <see cref="TRANSFER_POTValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="TRANSFER_POTValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;{{block(Pot)}} for a tool awaiting transfer from a {{block(ToolMagazine)}} to {{term(spindle)}} or {{block(Turret)}}.&#10;
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
		private RETURN_POTValue _RETURN_POT;
		/// <inheritdoc cref="RETURN_POTValue" path="/summary" />
		public RETURN_POTValue RETURN_POT => _RETURN_POT ?? (_RETURN_POT = new RETURN_POTValue());

		/// <summary>﻿<see cref="Pot">Pot</see> for a tool removed from <i>spindle</i> or <see cref="Turret">Turret</see> and awaiting for return to a <see cref="ToolMagazine">ToolMagazine</see>.<br /><br /><br />
		/// Value for CompositionTypeEnum.<br/>
		/// <br/>See also <seealso cref="CompositionTypeEnum">CompositionTypeEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.4">v1.4</see></item>
		/// </list>
		/// </remarks>

		public sealed class RETURN_POTValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="RETURN_POTValue.Name" /></summary>
			public const string NAME = "RETURN_POT";
			/// <summary>Constant value for <see cref="RETURN_POTValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.7";
			/// <summary>Constant value for <see cref="RETURN_POTValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="RETURN_POTValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;{{block(Pot)}} for a tool removed from {{term(spindle)}} or {{block(Turret)}} and awaiting for return to a {{block(ToolMagazine)}}.&#10;
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
		private STAGING_POTValue _STAGING_POT;
		/// <inheritdoc cref="STAGING_POTValue" path="/summary" />
		public STAGING_POTValue STAGING_POT => _STAGING_POT ?? (_STAGING_POT = new STAGING_POTValue());

		/// <summary>﻿<see cref="Pot">Pot</see> for a tool awaiting transfer to a <see cref="ToolMagazine">ToolMagazine</see> or <see cref="Turret">Turret</see> from outside of the piece of equipment.<br /><br /><br />
		/// Value for CompositionTypeEnum.<br/>
		/// <br/>See also <seealso cref="CompositionTypeEnum">CompositionTypeEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.4">v1.4</see></item>
		/// </list>
		/// </remarks>

		public sealed class STAGING_POTValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="STAGING_POTValue.Name" /></summary>
			public const string NAME = "STAGING_POT";
			/// <summary>Constant value for <see cref="STAGING_POTValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.7";
			/// <summary>Constant value for <see cref="STAGING_POTValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="STAGING_POTValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;{{block(Pot)}} for a tool awaiting transfer to a {{block(ToolMagazine)}} or {{block(Turret)}} from outside of the piece of equipment.&#10;
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
		private REMOVAL_POTValue _REMOVAL_POT;
		/// <inheritdoc cref="REMOVAL_POTValue" path="/summary" />
		public REMOVAL_POTValue REMOVAL_POT => _REMOVAL_POT ?? (_REMOVAL_POT = new REMOVAL_POTValue());

		/// <summary>﻿<see cref="Pot">Pot</see> for a tool to be removed from a <see cref="ToolMagazine">ToolMagazine</see> or <see cref="Turret">Turret</see> to a location outside of the piece of equipment.<br /><br /><br />
		/// Value for CompositionTypeEnum.<br/>
		/// <br/>See also <seealso cref="CompositionTypeEnum">CompositionTypeEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.4">v1.4</see></item>
		/// </list>
		/// </remarks>

		public sealed class REMOVAL_POTValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="REMOVAL_POTValue.Name" /></summary>
			public const string NAME = "REMOVAL_POT";
			/// <summary>Constant value for <see cref="REMOVAL_POTValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.7";
			/// <summary>Constant value for <see cref="REMOVAL_POTValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="REMOVAL_POTValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;{{block(Pot)}} for a tool to be removed from a {{block(ToolMagazine)}} or {{block(Turret)}} to a location outside of the piece of equipment.&#10;
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
		private EXPIRED_POTValue _EXPIRED_POT;
		/// <inheritdoc cref="EXPIRED_POTValue" path="/summary" />
		public EXPIRED_POTValue EXPIRED_POT => _EXPIRED_POT ?? (_EXPIRED_POT = new EXPIRED_POTValue());

		/// <summary>﻿<see cref="Pot">Pot</see> for a tool that is no longer usable for removal from a <see cref="ToolMagazine">ToolMagazine</see> or <see cref="Turret">Turret</see>.<br /><br /><br />
		/// Value for CompositionTypeEnum.<br/>
		/// <br/>See also <seealso cref="CompositionTypeEnum">CompositionTypeEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.4">v1.4</see></item>
		/// </list>
		/// </remarks>

		public sealed class EXPIRED_POTValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="EXPIRED_POTValue.Name" /></summary>
			public const string NAME = "EXPIRED_POT";
			/// <summary>Constant value for <see cref="EXPIRED_POTValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.7";
			/// <summary>Constant value for <see cref="EXPIRED_POTValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="EXPIRED_POTValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;{{block(Pot)}} for a tool that is no longer usable for removal from a {{block(ToolMagazine)}} or {{block(Turret)}}.&#10;
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