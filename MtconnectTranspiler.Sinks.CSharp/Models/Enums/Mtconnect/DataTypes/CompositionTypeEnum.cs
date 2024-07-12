#pragma warning disable 0618
#pragma warning disable 1574
using System;
using System.CodeDom.Compiler;

namespace Mtconnect.DataTypes
{
	/// <summary>
	/// View in the MTConnect Model browser <seealso href="https://model.mtconnect.org/#Enumeration___19_0_3_45f01b9_1580312281115_595828_44604">model.mtconnect.org</seealso>
	/// </summary>
	/// <remarks>
	/// <list type="bullet">
	/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_">v</see></item>
	/// <item><b>Deprecated</b>: <see href="https://model.mtconnect.org/#_Version_">v</see></item>
	/// </list>
	/// </remarks>
	[Obsolete("Deprecated in v according to https://model.mtconnect.org/#_Version_")]
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "1.0.15.3")]
	public enum CompositionTypeEnum
	{
		/// <summary>
		/// <see cref="Composition">Composition</see> composed of a mechanism that moves or controls a mechanical part of a piece of equipment.  It takes energy usually provided by air, electric current, or liquid and converts the energy into some kind of motion. 
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.4">v1.4</see></item>
		/// </list>
		/// </remarks>
		ACTUATOR,
		/// <summary>
		/// <see cref="Composition">Composition</see> composed of an electronic component or circuit that amplifies power, electric current, or voltage.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.4">v1.4</see></item>
		/// </list>
		/// </remarks>
		AMPLIFIER,
		/// <summary>
		/// <see cref="Composition">Composition</see> composed of a mechanical structure that transforms rotary motion into linear motion.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.4">v1.4</see></item>
		/// </list>
		/// </remarks>
		BALLSCREW,
		/// <summary>
		/// <see cref="Composition">Composition</see> composed of an endless flexible band that transmits motion for a piece of equipment or conveys materials and objects.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.4">v1.4</see></item>
		/// </list>
		/// </remarks>
		BELT,
		/// <summary>
		/// <see cref="Composition">Composition</see> composed of a mechanism that slows down or stops a moving object by the absorption or transfer of the energy of momentum, usually by means of friction, electrical force, or magnetic force.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.4">v1.4</see></item>
		/// </list>
		/// </remarks>
		BRAKE,
		/// <summary>
		/// <see cref="Composition">Composition</see> composed of an interconnected series of objects that band together and transmit motion for a piece of equipment or to convey materials and objects.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.4">v1.4</see></item>
		/// </list>
		/// </remarks>
		CHAIN,
		/// <summary>
		/// <see cref="Composition">Composition</see> composed of a mechanism that breaks material into smaller pieces.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.4">v1.4</see></item>
		/// </list>
		/// </remarks>
		CHOPPER,
		/// <summary>
		/// <see cref="Composition">Composition</see> composed of a mechanism that holds a part, stock material, or any other item in place.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.4">v1.4</see></item>
		/// </list>
		/// </remarks>
		CHUCK,
		/// <summary>
		/// <see cref="Composition">Composition</see> composed of an inclined channel that conveys material.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.4">v1.4</see></item>
		/// </list>
		/// </remarks>
		CHUTE,
		/// <summary>
		/// <see cref="Composition">Composition</see> composed of a mechanism that interrupts an electric circuit.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.4">v1.4</see></item>
		/// </list>
		/// </remarks>
		CIRCUIT_BREAKER,
		/// <summary>
		/// <see cref="Composition">Composition</see> composed of a mechanism that strengthens, supports, or fastens objects in place.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.4">v1.4</see></item>
		/// </list>
		/// </remarks>
		CLAMP,
		/// <summary>
		/// <see cref="Composition">Composition</see> composed of a pump or other mechanism that reduces volume and increases pressure of gases in order to condense the gases to drive pneumatically powered pieces of equipment.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.4">v1.4</see></item>
		/// </list>
		/// </remarks>
		COMPRESSOR,
		/// <summary>
		/// <see cref="Composition">Composition</see> composed of a mechanical mechanism or closure that covers a physical access portal into a piece of equipment allowing or restricting access to other parts of the equipment.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.4">v1.4</see></item>
		/// </list>
		/// </remarks>
		DOOR,
		/// <summary>
		/// <see cref="Composition">Composition</see> composed of a mechanism that allows material to flow for the purpose of drainage from, for example, a vessel or tank.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.4">v1.4</see></item>
		/// </list>
		/// </remarks>
		DRAIN,
		/// <summary>
		/// <see cref="Composition">Composition</see> composed of a mechanism that measures rotary position.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.4">v1.4</see></item>
		/// </list>
		/// </remarks>
		ENCODER,
		/// <summary>
		/// <see cref="Composition">Composition</see> composed of a mechanism that emits a type of radiation.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.5">v1.5</see></item>
		/// </list>
		/// </remarks>
		EXPOSURE_UNIT,
		/// <summary>
		/// <see cref="Composition">Composition</see> composed of a mechanism that dispenses liquid or powered materials.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.5">v1.5</see></item>
		/// </list>
		/// </remarks>
		EXTRUSION_UNIT,
		/// <summary>
		/// <see cref="Composition">Composition</see> composed of a mechanism that produces a current of air.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.4">v1.4</see></item>
		/// </list>
		/// </remarks>
		FAN,
		/// <summary>
		/// <see cref="Composition">Composition</see> composed of a substance or structure that allows liquids or gases to pass through to remove suspended impurities or to recover solids.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.4">v1.4</see></item>
		/// </list>
		/// </remarks>
		FILTER,
		/// <summary>
		/// <see cref="Composition">Composition</see> composed of an electromechanical actuator that produces deflection of a beam of light or energy in response to electric current through its coil in a magnetic field.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.5">v1.5</see></item>
		/// </list>
		/// </remarks>
		GALVANOMOTOR,
		/// <summary>
		/// <see cref="Composition">Composition</see> composed of a mechanism that holds a part, stock material, or any other item in place.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.4">v1.4</see></item>
		/// </list>
		/// </remarks>
		GRIPPER,
		/// <summary>
		/// <see cref="Composition">Composition</see> composed of a chamber or bin that stores materials temporarily, typically being filled through the top and dispensed through the bottom.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.4">v1.4</see></item>
		/// </list>
		/// </remarks>
		HOPPER,
		/// <summary>
		/// <see cref="Composition">Composition</see> composed of a mechanism that measures linear motion or position.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.4">v1.4</see></item>
		/// </list>
		/// </remarks>
		LINEAR_POSITION_FEEDBACK,
		/// <summary>
		/// <see cref="Composition">Composition</see> composed of a mechanism that converts electrical, pneumatic, or hydraulic energy into mechanical energy.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.4">v1.4</see></item>
		/// </list>
		/// </remarks>
		MOTOR,
		/// <summary>
		/// <see cref="Composition">Composition</see> composed of a viscous liquid.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.4">v1.4</see></item>
		/// </list>
		/// </remarks>
		OIL,
		/// <summary>
		/// <see cref="Composition">Composition</see> composed of a unit that provides power to electric mechanisms.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.4">v1.4</see></item>
		/// </list>
		/// </remarks>
		POWER_SUPPLY,
		/// <summary>
		/// <see cref="Composition">Composition</see> composed of a mechanism or wheel that turns in a frame or block and serves to change the direction of or to transmit force.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.4">v1.4</see></item>
		/// </list>
		/// </remarks>
		PULLEY,
		/// <summary>
		/// <see cref="Composition">Composition</see> composed of an apparatus that raises, drives, exhausts, or compresses fluids or gases by means of a piston, plunger, or set of rotating vanes.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.4">v1.4</see></item>
		/// </list>
		/// </remarks>
		PUMP,
		/// <summary>
		/// <see cref="Composition">Composition</see> composed of a rotary storage unit for material.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.5">v1.5</see></item>
		/// </list>
		/// </remarks>
		REEL,
		/// <summary>
		/// <see cref="Composition">Composition</see> composed of a mechanism that provides a signal or measured value.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.4">v1.4</see></item>
		/// </list>
		/// </remarks>
		SENSING_ELEMENT,
		/// <summary>
		/// <see cref="Composition">Composition</see> composed of a mechanism that flattens or spreads materials.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.5">v1.5</see></item>
		/// </list>
		/// </remarks>
		SPREADER,
		/// <summary>
		/// <see cref="Composition">Composition</see> composed of one or more cells that converts chemical energy to electricity and serves as a source of power. 
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.4">v1.4</see></item>
		/// </list>
		/// </remarks>
		STORAGE_BATTERY,
		/// <summary>
		/// <see cref="Composition">Composition</see> composed of a mechanism that turns on or off an electric current or makes or breaks a circuit.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.4">v1.4</see></item>
		/// </list>
		/// </remarks>
		SWITCH,
		/// <summary>
		/// <see cref="Composition">Composition</see> composed of a surface that holds an object or material.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.5">v1.5</see></item>
		/// </list>
		/// </remarks>
		TABLE,
		/// <summary>
		/// <see cref="Composition">Composition</see> composed of a receptacle or container that holds material.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.4">v1.4</see></item>
		/// </list>
		/// </remarks>
		TANK,
		/// <summary>
		/// <see cref="Composition">Composition</see> composed of a mechanism that provides or applies a stretch or strain to another mechanism.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.4">v1.4</see></item>
		/// </list>
		/// </remarks>
		TENSIONER,
		/// <summary>
		/// <see cref="Composition">Composition</see> composed of a mechanism that transforms electric energy from a source to a secondary circuit.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.5">v1.5</see></item>
		/// </list>
		/// </remarks>
		TRANSFORMER,
		/// <summary>
		/// <see cref="Composition">Composition</see> composed of a mechanism that halts or controls the flow of a liquid, gas, or other material through a passage, pipe, inlet, or outlet.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.4">v1.4</see></item>
		/// </list>
		/// </remarks>
		VALVE,
		/// <summary>
		/// <see cref="Composition">Composition</see> composed of a container for liquid or powdered materials.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.5">v1.5</see></item>
		/// </list>
		/// </remarks>
		VAT,
		/// <summary>
		/// <see cref="Composition">Composition</see> composed of a fluid.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.4">v1.4</see></item>
		/// </list>
		/// </remarks>
		WATER,
		/// <summary>
		/// <see cref="Composition">Composition</see> composed of a string like piece or filament of relatively rigid or flexible material provided in a variety of diameters.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.4">v1.4</see></item>
		/// </list>
		/// </remarks>
		WIRE,
		/// <summary>
		/// <see cref="Composition">Composition</see> composed of an object or material on which a form of work is performed.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.6">v1.6</see></item>
		/// </list>
		/// </remarks>
		WORKPIECE,
		/// <summary>
		/// <see cref="Composition">Composition</see> composed of a heat exchange system that uses a fluid to transfer heat to the atmosphere.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.7">v1.7</see></item>
		/// </list>
		/// </remarks>
		COOLING_TOWER,
		/// <summary>
		/// <see cref="Composition">Composition</see> composed of a tool storage location associated with a <see cref="ToolMagazine">ToolMagazine</see> or <see cref="AutomaticToolChanger">AutomaticToolChanger</see>.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.7">v1.7</see></item>
		/// </list>
		/// </remarks>
		POT,
		/// <summary>
		/// <see cref="Composition">Composition</see> composed of a storage or mounting location for a tool associated with a <see cref="Turret">Turret</see>, <see cref="GangToolBar">GangToolBar</see>, or <see cref="ToolRack">ToolRack</see>.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.7">v1.7</see></item>
		/// </list>
		/// </remarks>
		STATION,
		/// <summary>
		/// <see cref="Composition">Composition</see> composed of a mechanism that physically moves a tool from one location to another.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.7">v1.7</see></item>
		/// </list>
		/// </remarks>
		TRANSFER_ARM,
		/// <summary>
		/// <see cref="Pot">Pot</see> for a tool awaiting transfer from a <see cref="ToolMagazine">ToolMagazine</see> to <i>spindle</i> or <see cref="Turret">Turret</see>.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.7">v1.7</see></item>
		/// </list>
		/// </remarks>
		TRANSFER_POT,
		/// <summary>
		/// <see cref="Pot">Pot</see> for a tool removed from <i>spindle</i> or <see cref="Turret">Turret</see> and awaiting for return to a <see cref="ToolMagazine">ToolMagazine</see>.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.7">v1.7</see></item>
		/// </list>
		/// </remarks>
		RETURN_POT,
		/// <summary>
		/// <see cref="Pot">Pot</see> for a tool awaiting transfer to a <see cref="ToolMagazine">ToolMagazine</see> or <see cref="Turret">Turret</see> from outside of the piece of equipment.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.7">v1.7</see></item>
		/// </list>
		/// </remarks>
		STAGING_POT,
		/// <summary>
		/// <see cref="Pot">Pot</see> for a tool to be removed from a <see cref="ToolMagazine">ToolMagazine</see> or <see cref="Turret">Turret</see> to a location outside of the piece of equipment.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.7">v1.7</see></item>
		/// </list>
		/// </remarks>
		REMOVAL_POT,
		/// <summary>
		/// <see cref="Pot">Pot</see> for a tool that is no longer usable for removal from a <see cref="ToolMagazine">ToolMagazine</see> or <see cref="Turret">Turret</see>.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.7">v1.7</see></item>
		/// </list>
		/// </remarks>
		EXPIRED_POT,
	}
}