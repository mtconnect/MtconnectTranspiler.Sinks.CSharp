using System;
using System.CodeDom.Compiler;using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;

namespace Mtconnect.DataTypes
{
	/// <summary>
	/// View in the MTConnect Model browser <seealso href="https://model.mtconnect.org/#Enumeration___19_0_3_45f01b9_1580312281115_595828_44604">model.mtconnect.org</seealso>
	/// </summary>
	/// <remarks>
	/// <list type="bullet">
	/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.4">v1.4</see></item>
	/// </list>
	/// </remarks>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.3.0.0")]
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

	/// <summary>
	/// View in the MTConnect Model browser <seealso href="https://model.mtconnect.org/#Enumeration___19_0_3_45f01b9_1580312281115_595828_44604">model.mtconnect.org</seealso>
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.3.0.0")]
	public sealed class CompositionTypeEnumMetaClass : IEnum
	{
		/// <inheritdoc />
		public string Name => "CompositionTypeEnum";
		
		/// <inheritdoc />
		public Type DataType => null;
		
		public Type Instance => typeof(CompositionTypeEnum);

		/// <inheritdoc />
		public string NormativeVersion => "1.4";
		
		/// <inheritdoc />
		public string DeprecatedVersion => "";
		
		/// <inheritdoc />
		public string Summary => @"";
		
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
		/// <summary>
		/// <see cref="Composition">Composition</see> composed of a mechanism that moves or controls a mechanical part of a piece of equipment.  It takes energy usually provided by air, electric current, or liquid and converts the energy into some kind of motion. 
		/// </summary>
		public ACTUATORValue ACTUATOR => _ACTUATOR ?? (_ACTUATOR = new ACTUATORValue());

		/// <summary>
		/// <see cref="Composition">Composition</see> composed of a mechanism that moves or controls a mechanical part of a piece of equipment.  It takes energy usually provided by air, electric current, or liquid and converts the energy into some kind of motion. 
		/// </summary>
		public sealed class ACTUATORValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "ACTUATOR";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.4";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// <see cref=""Composition"">Composition</see> composed of a mechanism that moves or controls a mechanical part of a piece of equipment.  It takes energy usually provided by air, electric current, or liquid and converts the energy into some kind of motion. ";
		}
		private AMPLIFIERValue _AMPLIFIER;
		/// <summary>
		/// <see cref="Composition">Composition</see> composed of an electronic component or circuit that amplifies power, electric current, or voltage.
		/// </summary>
		public AMPLIFIERValue AMPLIFIER => _AMPLIFIER ?? (_AMPLIFIER = new AMPLIFIERValue());

		/// <summary>
		/// <see cref="Composition">Composition</see> composed of an electronic component or circuit that amplifies power, electric current, or voltage.
		/// </summary>
		public sealed class AMPLIFIERValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "AMPLIFIER";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.4";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// <see cref=""Composition"">Composition</see> composed of an electronic component or circuit that amplifies power, electric current, or voltage.";
		}
		private BALLSCREWValue _BALLSCREW;
		/// <summary>
		/// <see cref="Composition">Composition</see> composed of a mechanical structure that transforms rotary motion into linear motion.
		/// </summary>
		public BALLSCREWValue BALLSCREW => _BALLSCREW ?? (_BALLSCREW = new BALLSCREWValue());

		/// <summary>
		/// <see cref="Composition">Composition</see> composed of a mechanical structure that transforms rotary motion into linear motion.
		/// </summary>
		public sealed class BALLSCREWValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "BALLSCREW";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.4";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// <see cref=""Composition"">Composition</see> composed of a mechanical structure that transforms rotary motion into linear motion.";
		}
		private BELTValue _BELT;
		/// <summary>
		/// <see cref="Composition">Composition</see> composed of an endless flexible band that transmits motion for a piece of equipment or conveys materials and objects.
		/// </summary>
		public BELTValue BELT => _BELT ?? (_BELT = new BELTValue());

		/// <summary>
		/// <see cref="Composition">Composition</see> composed of an endless flexible band that transmits motion for a piece of equipment or conveys materials and objects.
		/// </summary>
		public sealed class BELTValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "BELT";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.4";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// <see cref=""Composition"">Composition</see> composed of an endless flexible band that transmits motion for a piece of equipment or conveys materials and objects.";
		}
		private BRAKEValue _BRAKE;
		/// <summary>
		/// <see cref="Composition">Composition</see> composed of a mechanism that slows down or stops a moving object by the absorption or transfer of the energy of momentum, usually by means of friction, electrical force, or magnetic force.
		/// </summary>
		public BRAKEValue BRAKE => _BRAKE ?? (_BRAKE = new BRAKEValue());

		/// <summary>
		/// <see cref="Composition">Composition</see> composed of a mechanism that slows down or stops a moving object by the absorption or transfer of the energy of momentum, usually by means of friction, electrical force, or magnetic force.
		/// </summary>
		public sealed class BRAKEValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "BRAKE";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.4";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// <see cref=""Composition"">Composition</see> composed of a mechanism that slows down or stops a moving object by the absorption or transfer of the energy of momentum, usually by means of friction, electrical force, or magnetic force.";
		}
		private CHAINValue _CHAIN;
		/// <summary>
		/// <see cref="Composition">Composition</see> composed of an interconnected series of objects that band together and transmit motion for a piece of equipment or to convey materials and objects.
		/// </summary>
		public CHAINValue CHAIN => _CHAIN ?? (_CHAIN = new CHAINValue());

		/// <summary>
		/// <see cref="Composition">Composition</see> composed of an interconnected series of objects that band together and transmit motion for a piece of equipment or to convey materials and objects.
		/// </summary>
		public sealed class CHAINValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "CHAIN";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.4";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// <see cref=""Composition"">Composition</see> composed of an interconnected series of objects that band together and transmit motion for a piece of equipment or to convey materials and objects.";
		}
		private CHOPPERValue _CHOPPER;
		/// <summary>
		/// <see cref="Composition">Composition</see> composed of a mechanism that breaks material into smaller pieces.
		/// </summary>
		public CHOPPERValue CHOPPER => _CHOPPER ?? (_CHOPPER = new CHOPPERValue());

		/// <summary>
		/// <see cref="Composition">Composition</see> composed of a mechanism that breaks material into smaller pieces.
		/// </summary>
		public sealed class CHOPPERValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "CHOPPER";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.4";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// <see cref=""Composition"">Composition</see> composed of a mechanism that breaks material into smaller pieces.";
		}
		private CHUCKValue _CHUCK;
		/// <summary>
		/// <see cref="Composition">Composition</see> composed of a mechanism that holds a part, stock material, or any other item in place.
		/// </summary>
		public CHUCKValue CHUCK => _CHUCK ?? (_CHUCK = new CHUCKValue());

		/// <summary>
		/// <see cref="Composition">Composition</see> composed of a mechanism that holds a part, stock material, or any other item in place.
		/// </summary>
		public sealed class CHUCKValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "CHUCK";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.4";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// <see cref=""Composition"">Composition</see> composed of a mechanism that holds a part, stock material, or any other item in place.";
		}
		private CHUTEValue _CHUTE;
		/// <summary>
		/// <see cref="Composition">Composition</see> composed of an inclined channel that conveys material.
		/// </summary>
		public CHUTEValue CHUTE => _CHUTE ?? (_CHUTE = new CHUTEValue());

		/// <summary>
		/// <see cref="Composition">Composition</see> composed of an inclined channel that conveys material.
		/// </summary>
		public sealed class CHUTEValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "CHUTE";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.4";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// <see cref=""Composition"">Composition</see> composed of an inclined channel that conveys material.";
		}
		private CIRCUIT_BREAKERValue _CIRCUIT_BREAKER;
		/// <summary>
		/// <see cref="Composition">Composition</see> composed of a mechanism that interrupts an electric circuit.
		/// </summary>
		public CIRCUIT_BREAKERValue CIRCUIT_BREAKER => _CIRCUIT_BREAKER ?? (_CIRCUIT_BREAKER = new CIRCUIT_BREAKERValue());

		/// <summary>
		/// <see cref="Composition">Composition</see> composed of a mechanism that interrupts an electric circuit.
		/// </summary>
		public sealed class CIRCUIT_BREAKERValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "CIRCUIT_BREAKER";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.4";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// <see cref=""Composition"">Composition</see> composed of a mechanism that interrupts an electric circuit.";
		}
		private CLAMPValue _CLAMP;
		/// <summary>
		/// <see cref="Composition">Composition</see> composed of a mechanism that strengthens, supports, or fastens objects in place.
		/// </summary>
		public CLAMPValue CLAMP => _CLAMP ?? (_CLAMP = new CLAMPValue());

		/// <summary>
		/// <see cref="Composition">Composition</see> composed of a mechanism that strengthens, supports, or fastens objects in place.
		/// </summary>
		public sealed class CLAMPValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "CLAMP";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.4";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// <see cref=""Composition"">Composition</see> composed of a mechanism that strengthens, supports, or fastens objects in place.";
		}
		private COMPRESSORValue _COMPRESSOR;
		/// <summary>
		/// <see cref="Composition">Composition</see> composed of a pump or other mechanism that reduces volume and increases pressure of gases in order to condense the gases to drive pneumatically powered pieces of equipment.
		/// </summary>
		public COMPRESSORValue COMPRESSOR => _COMPRESSOR ?? (_COMPRESSOR = new COMPRESSORValue());

		/// <summary>
		/// <see cref="Composition">Composition</see> composed of a pump or other mechanism that reduces volume and increases pressure of gases in order to condense the gases to drive pneumatically powered pieces of equipment.
		/// </summary>
		public sealed class COMPRESSORValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "COMPRESSOR";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.4";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// <see cref=""Composition"">Composition</see> composed of a pump or other mechanism that reduces volume and increases pressure of gases in order to condense the gases to drive pneumatically powered pieces of equipment.";
		}
		private DOORValue _DOOR;
		/// <summary>
		/// <see cref="Composition">Composition</see> composed of a mechanical mechanism or closure that covers a physical access portal into a piece of equipment allowing or restricting access to other parts of the equipment.
		/// </summary>
		public DOORValue DOOR => _DOOR ?? (_DOOR = new DOORValue());

		/// <summary>
		/// <see cref="Composition">Composition</see> composed of a mechanical mechanism or closure that covers a physical access portal into a piece of equipment allowing or restricting access to other parts of the equipment.
		/// </summary>
		public sealed class DOORValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "DOOR";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.4";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// <see cref=""Composition"">Composition</see> composed of a mechanical mechanism or closure that covers a physical access portal into a piece of equipment allowing or restricting access to other parts of the equipment.";
		}
		private DRAINValue _DRAIN;
		/// <summary>
		/// <see cref="Composition">Composition</see> composed of a mechanism that allows material to flow for the purpose of drainage from, for example, a vessel or tank.
		/// </summary>
		public DRAINValue DRAIN => _DRAIN ?? (_DRAIN = new DRAINValue());

		/// <summary>
		/// <see cref="Composition">Composition</see> composed of a mechanism that allows material to flow for the purpose of drainage from, for example, a vessel or tank.
		/// </summary>
		public sealed class DRAINValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "DRAIN";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.4";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// <see cref=""Composition"">Composition</see> composed of a mechanism that allows material to flow for the purpose of drainage from, for example, a vessel or tank.";
		}
		private ENCODERValue _ENCODER;
		/// <summary>
		/// <see cref="Composition">Composition</see> composed of a mechanism that measures rotary position.
		/// </summary>
		public ENCODERValue ENCODER => _ENCODER ?? (_ENCODER = new ENCODERValue());

		/// <summary>
		/// <see cref="Composition">Composition</see> composed of a mechanism that measures rotary position.
		/// </summary>
		public sealed class ENCODERValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "ENCODER";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.4";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// <see cref=""Composition"">Composition</see> composed of a mechanism that measures rotary position.";
		}
		private EXPOSURE_UNITValue _EXPOSURE_UNIT;
		/// <summary>
		/// <see cref="Composition">Composition</see> composed of a mechanism that emits a type of radiation.
		/// </summary>
		public EXPOSURE_UNITValue EXPOSURE_UNIT => _EXPOSURE_UNIT ?? (_EXPOSURE_UNIT = new EXPOSURE_UNITValue());

		/// <summary>
		/// <see cref="Composition">Composition</see> composed of a mechanism that emits a type of radiation.
		/// </summary>
		public sealed class EXPOSURE_UNITValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "EXPOSURE_UNIT";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.5";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// <see cref=""Composition"">Composition</see> composed of a mechanism that emits a type of radiation.";
		}
		private EXTRUSION_UNITValue _EXTRUSION_UNIT;
		/// <summary>
		/// <see cref="Composition">Composition</see> composed of a mechanism that dispenses liquid or powered materials.
		/// </summary>
		public EXTRUSION_UNITValue EXTRUSION_UNIT => _EXTRUSION_UNIT ?? (_EXTRUSION_UNIT = new EXTRUSION_UNITValue());

		/// <summary>
		/// <see cref="Composition">Composition</see> composed of a mechanism that dispenses liquid or powered materials.
		/// </summary>
		public sealed class EXTRUSION_UNITValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "EXTRUSION_UNIT";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.5";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// <see cref=""Composition"">Composition</see> composed of a mechanism that dispenses liquid or powered materials.";
		}
		private FANValue _FAN;
		/// <summary>
		/// <see cref="Composition">Composition</see> composed of a mechanism that produces a current of air.
		/// </summary>
		public FANValue FAN => _FAN ?? (_FAN = new FANValue());

		/// <summary>
		/// <see cref="Composition">Composition</see> composed of a mechanism that produces a current of air.
		/// </summary>
		public sealed class FANValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "FAN";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.4";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// <see cref=""Composition"">Composition</see> composed of a mechanism that produces a current of air.";
		}
		private FILTERValue _FILTER;
		/// <summary>
		/// <see cref="Composition">Composition</see> composed of a substance or structure that allows liquids or gases to pass through to remove suspended impurities or to recover solids.
		/// </summary>
		public FILTERValue FILTER => _FILTER ?? (_FILTER = new FILTERValue());

		/// <summary>
		/// <see cref="Composition">Composition</see> composed of a substance or structure that allows liquids or gases to pass through to remove suspended impurities or to recover solids.
		/// </summary>
		public sealed class FILTERValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "FILTER";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.4";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// <see cref=""Composition"">Composition</see> composed of a substance or structure that allows liquids or gases to pass through to remove suspended impurities or to recover solids.";
		}
		private GALVANOMOTORValue _GALVANOMOTOR;
		/// <summary>
		/// <see cref="Composition">Composition</see> composed of an electromechanical actuator that produces deflection of a beam of light or energy in response to electric current through its coil in a magnetic field.
		/// </summary>
		public GALVANOMOTORValue GALVANOMOTOR => _GALVANOMOTOR ?? (_GALVANOMOTOR = new GALVANOMOTORValue());

		/// <summary>
		/// <see cref="Composition">Composition</see> composed of an electromechanical actuator that produces deflection of a beam of light or energy in response to electric current through its coil in a magnetic field.
		/// </summary>
		public sealed class GALVANOMOTORValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "GALVANOMOTOR";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.5";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// <see cref=""Composition"">Composition</see> composed of an electromechanical actuator that produces deflection of a beam of light or energy in response to electric current through its coil in a magnetic field.";
		}
		private GRIPPERValue _GRIPPER;
		/// <summary>
		/// <see cref="Composition">Composition</see> composed of a mechanism that holds a part, stock material, or any other item in place.
		/// </summary>
		public GRIPPERValue GRIPPER => _GRIPPER ?? (_GRIPPER = new GRIPPERValue());

		/// <summary>
		/// <see cref="Composition">Composition</see> composed of a mechanism that holds a part, stock material, or any other item in place.
		/// </summary>
		public sealed class GRIPPERValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "GRIPPER";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.4";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// <see cref=""Composition"">Composition</see> composed of a mechanism that holds a part, stock material, or any other item in place.";
		}
		private HOPPERValue _HOPPER;
		/// <summary>
		/// <see cref="Composition">Composition</see> composed of a chamber or bin that stores materials temporarily, typically being filled through the top and dispensed through the bottom.
		/// </summary>
		public HOPPERValue HOPPER => _HOPPER ?? (_HOPPER = new HOPPERValue());

		/// <summary>
		/// <see cref="Composition">Composition</see> composed of a chamber or bin that stores materials temporarily, typically being filled through the top and dispensed through the bottom.
		/// </summary>
		public sealed class HOPPERValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "HOPPER";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.4";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// <see cref=""Composition"">Composition</see> composed of a chamber or bin that stores materials temporarily, typically being filled through the top and dispensed through the bottom.";
		}
		private LINEAR_POSITION_FEEDBACKValue _LINEAR_POSITION_FEEDBACK;
		/// <summary>
		/// <see cref="Composition">Composition</see> composed of a mechanism that measures linear motion or position.
		/// </summary>
		public LINEAR_POSITION_FEEDBACKValue LINEAR_POSITION_FEEDBACK => _LINEAR_POSITION_FEEDBACK ?? (_LINEAR_POSITION_FEEDBACK = new LINEAR_POSITION_FEEDBACKValue());

		/// <summary>
		/// <see cref="Composition">Composition</see> composed of a mechanism that measures linear motion or position.
		/// </summary>
		public sealed class LINEAR_POSITION_FEEDBACKValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "LINEAR_POSITION_FEEDBACK";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.4";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// <see cref=""Composition"">Composition</see> composed of a mechanism that measures linear motion or position.";
		}
		private MOTORValue _MOTOR;
		/// <summary>
		/// <see cref="Composition">Composition</see> composed of a mechanism that converts electrical, pneumatic, or hydraulic energy into mechanical energy.
		/// </summary>
		public MOTORValue MOTOR => _MOTOR ?? (_MOTOR = new MOTORValue());

		/// <summary>
		/// <see cref="Composition">Composition</see> composed of a mechanism that converts electrical, pneumatic, or hydraulic energy into mechanical energy.
		/// </summary>
		public sealed class MOTORValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "MOTOR";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.4";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// <see cref=""Composition"">Composition</see> composed of a mechanism that converts electrical, pneumatic, or hydraulic energy into mechanical energy.";
		}
		private OILValue _OIL;
		/// <summary>
		/// <see cref="Composition">Composition</see> composed of a viscous liquid.
		/// </summary>
		public OILValue OIL => _OIL ?? (_OIL = new OILValue());

		/// <summary>
		/// <see cref="Composition">Composition</see> composed of a viscous liquid.
		/// </summary>
		public sealed class OILValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "OIL";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.4";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// <see cref=""Composition"">Composition</see> composed of a viscous liquid.";
		}
		private POWER_SUPPLYValue _POWER_SUPPLY;
		/// <summary>
		/// <see cref="Composition">Composition</see> composed of a unit that provides power to electric mechanisms.
		/// </summary>
		public POWER_SUPPLYValue POWER_SUPPLY => _POWER_SUPPLY ?? (_POWER_SUPPLY = new POWER_SUPPLYValue());

		/// <summary>
		/// <see cref="Composition">Composition</see> composed of a unit that provides power to electric mechanisms.
		/// </summary>
		public sealed class POWER_SUPPLYValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "POWER_SUPPLY";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.4";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// <see cref=""Composition"">Composition</see> composed of a unit that provides power to electric mechanisms.";
		}
		private PULLEYValue _PULLEY;
		/// <summary>
		/// <see cref="Composition">Composition</see> composed of a mechanism or wheel that turns in a frame or block and serves to change the direction of or to transmit force.
		/// </summary>
		public PULLEYValue PULLEY => _PULLEY ?? (_PULLEY = new PULLEYValue());

		/// <summary>
		/// <see cref="Composition">Composition</see> composed of a mechanism or wheel that turns in a frame or block and serves to change the direction of or to transmit force.
		/// </summary>
		public sealed class PULLEYValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "PULLEY";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.4";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// <see cref=""Composition"">Composition</see> composed of a mechanism or wheel that turns in a frame or block and serves to change the direction of or to transmit force.";
		}
		private PUMPValue _PUMP;
		/// <summary>
		/// <see cref="Composition">Composition</see> composed of an apparatus that raises, drives, exhausts, or compresses fluids or gases by means of a piston, plunger, or set of rotating vanes.
		/// </summary>
		public PUMPValue PUMP => _PUMP ?? (_PUMP = new PUMPValue());

		/// <summary>
		/// <see cref="Composition">Composition</see> composed of an apparatus that raises, drives, exhausts, or compresses fluids or gases by means of a piston, plunger, or set of rotating vanes.
		/// </summary>
		public sealed class PUMPValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "PUMP";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.4";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// <see cref=""Composition"">Composition</see> composed of an apparatus that raises, drives, exhausts, or compresses fluids or gases by means of a piston, plunger, or set of rotating vanes.";
		}
		private REELValue _REEL;
		/// <summary>
		/// <see cref="Composition">Composition</see> composed of a rotary storage unit for material.
		/// </summary>
		public REELValue REEL => _REEL ?? (_REEL = new REELValue());

		/// <summary>
		/// <see cref="Composition">Composition</see> composed of a rotary storage unit for material.
		/// </summary>
		public sealed class REELValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "REEL";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.5";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// <see cref=""Composition"">Composition</see> composed of a rotary storage unit for material.";
		}
		private SENSING_ELEMENTValue _SENSING_ELEMENT;
		/// <summary>
		/// <see cref="Composition">Composition</see> composed of a mechanism that provides a signal or measured value.
		/// </summary>
		public SENSING_ELEMENTValue SENSING_ELEMENT => _SENSING_ELEMENT ?? (_SENSING_ELEMENT = new SENSING_ELEMENTValue());

		/// <summary>
		/// <see cref="Composition">Composition</see> composed of a mechanism that provides a signal or measured value.
		/// </summary>
		public sealed class SENSING_ELEMENTValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "SENSING_ELEMENT";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.4";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// <see cref=""Composition"">Composition</see> composed of a mechanism that provides a signal or measured value.";
		}
		private SPREADERValue _SPREADER;
		/// <summary>
		/// <see cref="Composition">Composition</see> composed of a mechanism that flattens or spreads materials.
		/// </summary>
		public SPREADERValue SPREADER => _SPREADER ?? (_SPREADER = new SPREADERValue());

		/// <summary>
		/// <see cref="Composition">Composition</see> composed of a mechanism that flattens or spreads materials.
		/// </summary>
		public sealed class SPREADERValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "SPREADER";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.5";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// <see cref=""Composition"">Composition</see> composed of a mechanism that flattens or spreads materials.";
		}
		private STORAGE_BATTERYValue _STORAGE_BATTERY;
		/// <summary>
		/// <see cref="Composition">Composition</see> composed of one or more cells that converts chemical energy to electricity and serves as a source of power. 
		/// </summary>
		public STORAGE_BATTERYValue STORAGE_BATTERY => _STORAGE_BATTERY ?? (_STORAGE_BATTERY = new STORAGE_BATTERYValue());

		/// <summary>
		/// <see cref="Composition">Composition</see> composed of one or more cells that converts chemical energy to electricity and serves as a source of power. 
		/// </summary>
		public sealed class STORAGE_BATTERYValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "STORAGE_BATTERY";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.4";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// <see cref=""Composition"">Composition</see> composed of one or more cells that converts chemical energy to electricity and serves as a source of power. ";
		}
		private SWITCHValue _SWITCH;
		/// <summary>
		/// <see cref="Composition">Composition</see> composed of a mechanism that turns on or off an electric current or makes or breaks a circuit.
		/// </summary>
		public SWITCHValue SWITCH => _SWITCH ?? (_SWITCH = new SWITCHValue());

		/// <summary>
		/// <see cref="Composition">Composition</see> composed of a mechanism that turns on or off an electric current or makes or breaks a circuit.
		/// </summary>
		public sealed class SWITCHValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "SWITCH";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.4";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// <see cref=""Composition"">Composition</see> composed of a mechanism that turns on or off an electric current or makes or breaks a circuit.";
		}
		private TABLEValue _TABLE;
		/// <summary>
		/// <see cref="Composition">Composition</see> composed of a surface that holds an object or material.
		/// </summary>
		public TABLEValue TABLE => _TABLE ?? (_TABLE = new TABLEValue());

		/// <summary>
		/// <see cref="Composition">Composition</see> composed of a surface that holds an object or material.
		/// </summary>
		public sealed class TABLEValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "TABLE";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.5";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// <see cref=""Composition"">Composition</see> composed of a surface that holds an object or material.";
		}
		private TANKValue _TANK;
		/// <summary>
		/// <see cref="Composition">Composition</see> composed of a receptacle or container that holds material.
		/// </summary>
		public TANKValue TANK => _TANK ?? (_TANK = new TANKValue());

		/// <summary>
		/// <see cref="Composition">Composition</see> composed of a receptacle or container that holds material.
		/// </summary>
		public sealed class TANKValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "TANK";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.4";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// <see cref=""Composition"">Composition</see> composed of a receptacle or container that holds material.";
		}
		private TENSIONERValue _TENSIONER;
		/// <summary>
		/// <see cref="Composition">Composition</see> composed of a mechanism that provides or applies a stretch or strain to another mechanism.
		/// </summary>
		public TENSIONERValue TENSIONER => _TENSIONER ?? (_TENSIONER = new TENSIONERValue());

		/// <summary>
		/// <see cref="Composition">Composition</see> composed of a mechanism that provides or applies a stretch or strain to another mechanism.
		/// </summary>
		public sealed class TENSIONERValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "TENSIONER";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.4";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// <see cref=""Composition"">Composition</see> composed of a mechanism that provides or applies a stretch or strain to another mechanism.";
		}
		private TRANSFORMERValue _TRANSFORMER;
		/// <summary>
		/// <see cref="Composition">Composition</see> composed of a mechanism that transforms electric energy from a source to a secondary circuit.
		/// </summary>
		public TRANSFORMERValue TRANSFORMER => _TRANSFORMER ?? (_TRANSFORMER = new TRANSFORMERValue());

		/// <summary>
		/// <see cref="Composition">Composition</see> composed of a mechanism that transforms electric energy from a source to a secondary circuit.
		/// </summary>
		public sealed class TRANSFORMERValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "TRANSFORMER";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.5";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// <see cref=""Composition"">Composition</see> composed of a mechanism that transforms electric energy from a source to a secondary circuit.";
		}
		private VALVEValue _VALVE;
		/// <summary>
		/// <see cref="Composition">Composition</see> composed of a mechanism that halts or controls the flow of a liquid, gas, or other material through a passage, pipe, inlet, or outlet.
		/// </summary>
		public VALVEValue VALVE => _VALVE ?? (_VALVE = new VALVEValue());

		/// <summary>
		/// <see cref="Composition">Composition</see> composed of a mechanism that halts or controls the flow of a liquid, gas, or other material through a passage, pipe, inlet, or outlet.
		/// </summary>
		public sealed class VALVEValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "VALVE";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.4";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// <see cref=""Composition"">Composition</see> composed of a mechanism that halts or controls the flow of a liquid, gas, or other material through a passage, pipe, inlet, or outlet.";
		}
		private VATValue _VAT;
		/// <summary>
		/// <see cref="Composition">Composition</see> composed of a container for liquid or powdered materials.
		/// </summary>
		public VATValue VAT => _VAT ?? (_VAT = new VATValue());

		/// <summary>
		/// <see cref="Composition">Composition</see> composed of a container for liquid or powdered materials.
		/// </summary>
		public sealed class VATValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "VAT";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.5";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// <see cref=""Composition"">Composition</see> composed of a container for liquid or powdered materials.";
		}
		private WATERValue _WATER;
		/// <summary>
		/// <see cref="Composition">Composition</see> composed of a fluid.
		/// </summary>
		public WATERValue WATER => _WATER ?? (_WATER = new WATERValue());

		/// <summary>
		/// <see cref="Composition">Composition</see> composed of a fluid.
		/// </summary>
		public sealed class WATERValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "WATER";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.4";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// <see cref=""Composition"">Composition</see> composed of a fluid.";
		}
		private WIREValue _WIRE;
		/// <summary>
		/// <see cref="Composition">Composition</see> composed of a string like piece or filament of relatively rigid or flexible material provided in a variety of diameters.
		/// </summary>
		public WIREValue WIRE => _WIRE ?? (_WIRE = new WIREValue());

		/// <summary>
		/// <see cref="Composition">Composition</see> composed of a string like piece or filament of relatively rigid or flexible material provided in a variety of diameters.
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
			public string Summary => @"/// <see cref=""Composition"">Composition</see> composed of a string like piece or filament of relatively rigid or flexible material provided in a variety of diameters.";
		}
		private WORKPIECEValue _WORKPIECE;
		/// <summary>
		/// <see cref="Composition">Composition</see> composed of an object or material on which a form of work is performed.
		/// </summary>
		public WORKPIECEValue WORKPIECE => _WORKPIECE ?? (_WORKPIECE = new WORKPIECEValue());

		/// <summary>
		/// <see cref="Composition">Composition</see> composed of an object or material on which a form of work is performed.
		/// </summary>
		public sealed class WORKPIECEValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "WORKPIECE";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.6";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// <see cref=""Composition"">Composition</see> composed of an object or material on which a form of work is performed.";
		}
		private COOLING_TOWERValue _COOLING_TOWER;
		/// <summary>
		/// <see cref="Composition">Composition</see> composed of a heat exchange system that uses a fluid to transfer heat to the atmosphere.
		/// </summary>
		public COOLING_TOWERValue COOLING_TOWER => _COOLING_TOWER ?? (_COOLING_TOWER = new COOLING_TOWERValue());

		/// <summary>
		/// <see cref="Composition">Composition</see> composed of a heat exchange system that uses a fluid to transfer heat to the atmosphere.
		/// </summary>
		public sealed class COOLING_TOWERValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "COOLING_TOWER";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.7";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// <see cref=""Composition"">Composition</see> composed of a heat exchange system that uses a fluid to transfer heat to the atmosphere.";
		}
		private POTValue _POT;
		/// <summary>
		/// <see cref="Composition">Composition</see> composed of a tool storage location associated with a <see cref="ToolMagazine">ToolMagazine</see> or <see cref="AutomaticToolChanger">AutomaticToolChanger</see>.
		/// </summary>
		public POTValue POT => _POT ?? (_POT = new POTValue());

		/// <summary>
		/// <see cref="Composition">Composition</see> composed of a tool storage location associated with a <see cref="ToolMagazine">ToolMagazine</see> or <see cref="AutomaticToolChanger">AutomaticToolChanger</see>.
		/// </summary>
		public sealed class POTValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "POT";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.7";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// <see cref=""Composition"">Composition</see> composed of a tool storage location associated with a <see cref=""ToolMagazine"">ToolMagazine</see> or <see cref=""AutomaticToolChanger"">AutomaticToolChanger</see>.";
		}
		private STATIONValue _STATION;
		/// <summary>
		/// <see cref="Composition">Composition</see> composed of a storage or mounting location for a tool associated with a <see cref="Turret">Turret</see>, <see cref="GangToolBar">GangToolBar</see>, or <see cref="ToolRack">ToolRack</see>.
		/// </summary>
		public STATIONValue STATION => _STATION ?? (_STATION = new STATIONValue());

		/// <summary>
		/// <see cref="Composition">Composition</see> composed of a storage or mounting location for a tool associated with a <see cref="Turret">Turret</see>, <see cref="GangToolBar">GangToolBar</see>, or <see cref="ToolRack">ToolRack</see>.
		/// </summary>
		public sealed class STATIONValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "STATION";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.7";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// <see cref=""Composition"">Composition</see> composed of a storage or mounting location for a tool associated with a <see cref=""Turret"">Turret</see>, <see cref=""GangToolBar"">GangToolBar</see>, or <see cref=""ToolRack"">ToolRack</see>.";
		}
		private TRANSFER_ARMValue _TRANSFER_ARM;
		/// <summary>
		/// <see cref="Composition">Composition</see> composed of a mechanism that physically moves a tool from one location to another.
		/// </summary>
		public TRANSFER_ARMValue TRANSFER_ARM => _TRANSFER_ARM ?? (_TRANSFER_ARM = new TRANSFER_ARMValue());

		/// <summary>
		/// <see cref="Composition">Composition</see> composed of a mechanism that physically moves a tool from one location to another.
		/// </summary>
		public sealed class TRANSFER_ARMValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "TRANSFER_ARM";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.7";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// <see cref=""Composition"">Composition</see> composed of a mechanism that physically moves a tool from one location to another.";
		}
		private TRANSFER_POTValue _TRANSFER_POT;
		/// <summary>
		/// <see cref="Pot">Pot</see> for a tool awaiting transfer from a <see cref="ToolMagazine">ToolMagazine</see> to <i>spindle</i> or <see cref="Turret">Turret</see>.
		/// </summary>
		public TRANSFER_POTValue TRANSFER_POT => _TRANSFER_POT ?? (_TRANSFER_POT = new TRANSFER_POTValue());

		/// <summary>
		/// <see cref="Pot">Pot</see> for a tool awaiting transfer from a <see cref="ToolMagazine">ToolMagazine</see> to <i>spindle</i> or <see cref="Turret">Turret</see>.
		/// </summary>
		public sealed class TRANSFER_POTValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "TRANSFER_POT";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.7";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// <see cref=""Pot"">Pot</see> for a tool awaiting transfer from a <see cref=""ToolMagazine"">ToolMagazine</see> to <i>spindle</i> or <see cref=""Turret"">Turret</see>.";
		}
		private RETURN_POTValue _RETURN_POT;
		/// <summary>
		/// <see cref="Pot">Pot</see> for a tool removed from <i>spindle</i> or <see cref="Turret">Turret</see> and awaiting for return to a <see cref="ToolMagazine">ToolMagazine</see>.
		/// </summary>
		public RETURN_POTValue RETURN_POT => _RETURN_POT ?? (_RETURN_POT = new RETURN_POTValue());

		/// <summary>
		/// <see cref="Pot">Pot</see> for a tool removed from <i>spindle</i> or <see cref="Turret">Turret</see> and awaiting for return to a <see cref="ToolMagazine">ToolMagazine</see>.
		/// </summary>
		public sealed class RETURN_POTValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "RETURN_POT";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.7";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// <see cref=""Pot"">Pot</see> for a tool removed from <i>spindle</i> or <see cref=""Turret"">Turret</see> and awaiting for return to a <see cref=""ToolMagazine"">ToolMagazine</see>.";
		}
		private STAGING_POTValue _STAGING_POT;
		/// <summary>
		/// <see cref="Pot">Pot</see> for a tool awaiting transfer to a <see cref="ToolMagazine">ToolMagazine</see> or <see cref="Turret">Turret</see> from outside of the piece of equipment.
		/// </summary>
		public STAGING_POTValue STAGING_POT => _STAGING_POT ?? (_STAGING_POT = new STAGING_POTValue());

		/// <summary>
		/// <see cref="Pot">Pot</see> for a tool awaiting transfer to a <see cref="ToolMagazine">ToolMagazine</see> or <see cref="Turret">Turret</see> from outside of the piece of equipment.
		/// </summary>
		public sealed class STAGING_POTValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "STAGING_POT";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.7";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// <see cref=""Pot"">Pot</see> for a tool awaiting transfer to a <see cref=""ToolMagazine"">ToolMagazine</see> or <see cref=""Turret"">Turret</see> from outside of the piece of equipment.";
		}
		private REMOVAL_POTValue _REMOVAL_POT;
		/// <summary>
		/// <see cref="Pot">Pot</see> for a tool to be removed from a <see cref="ToolMagazine">ToolMagazine</see> or <see cref="Turret">Turret</see> to a location outside of the piece of equipment.
		/// </summary>
		public REMOVAL_POTValue REMOVAL_POT => _REMOVAL_POT ?? (_REMOVAL_POT = new REMOVAL_POTValue());

		/// <summary>
		/// <see cref="Pot">Pot</see> for a tool to be removed from a <see cref="ToolMagazine">ToolMagazine</see> or <see cref="Turret">Turret</see> to a location outside of the piece of equipment.
		/// </summary>
		public sealed class REMOVAL_POTValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "REMOVAL_POT";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.7";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// <see cref=""Pot"">Pot</see> for a tool to be removed from a <see cref=""ToolMagazine"">ToolMagazine</see> or <see cref=""Turret"">Turret</see> to a location outside of the piece of equipment.";
		}
		private EXPIRED_POTValue _EXPIRED_POT;
		/// <summary>
		/// <see cref="Pot">Pot</see> for a tool that is no longer usable for removal from a <see cref="ToolMagazine">ToolMagazine</see> or <see cref="Turret">Turret</see>.
		/// </summary>
		public EXPIRED_POTValue EXPIRED_POT => _EXPIRED_POT ?? (_EXPIRED_POT = new EXPIRED_POTValue());

		/// <summary>
		/// <see cref="Pot">Pot</see> for a tool that is no longer usable for removal from a <see cref="ToolMagazine">ToolMagazine</see> or <see cref="Turret">Turret</see>.
		/// </summary>
		public sealed class EXPIRED_POTValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "EXPIRED_POT";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.7";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// <see cref=""Pot"">Pot</see> for a tool that is no longer usable for removal from a <see cref=""ToolMagazine"">ToolMagazine</see> or <see cref=""Turret"">Turret</see>.";
		}
	}
}