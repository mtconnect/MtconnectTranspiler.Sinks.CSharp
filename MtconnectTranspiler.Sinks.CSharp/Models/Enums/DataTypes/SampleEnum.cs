using System;
using System.CodeDom.Compiler;using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;

namespace Mtconnect.DataTypes
{
	/// <summary>
	/// View in the MTConnect Model browser <seealso href="https://model.mtconnect.org/#Enumeration___19_0_3_45f01b9_1580398370126_672808_12777">model.mtconnect.org</seealso>
	/// </summary>
	/// <remarks>
	/// <list type="bullet">
	/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
	/// </list>
	/// </remarks>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.3.0.0")]
	public enum SampleEnum
	{
		/// <summary>
		/// positive rate of change of velocity.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>
		ACCELERATION,
		/// <summary>
		/// accumulated time for an activity or event.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.2">v1.2</see></item>
		/// </list>
		/// </remarks>
		ACCUMULATED_TIME,
		/// <summary>
		/// strength of electrical current.  <b>DEPRECATED</b> in <i>Version 1.6</i>s. Replaced by <c>AMPERAGE_AC</c> and <c>AMPERAGE_DC</c>.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// <item><b>Deprecated</b>: <see href="https://model.mtconnect.org/#_Version_1.6">v1.6</see></item>
		/// </list>
		/// </remarks>
		[Obsolete("Deprecated in v1.6 according to https://model.mtconnect.org/#_Version_1.6")]
		AMPERAGE,
		/// <summary>
		/// angular position.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>
		ANGLE,
		/// <summary>
		/// positive rate of change of angular velocity.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>
		ANGULAR_ACCELERATION,
		/// <summary>
		/// rate of change of angular position.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>
		ANGULAR_VELOCITY,
		/// <summary>
		/// feedrate of a linear axis.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>
		AXIS_FEEDRATE,
		/// <summary>
		/// fluid capacity of an object or container.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.5">v1.5</see></item>
		/// </list>
		/// </remarks>
		CAPACITY_FLUID,
		/// <summary>
		/// geometric capacity of an object or container.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.5">v1.5</see></item>
		/// </list>
		/// </remarks>
		CAPACITY_SPATIAL,
		/// <summary>
		/// percentage of one component within a mixture of components.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.2">v1.2</see></item>
		/// </list>
		/// </remarks>
		CONCENTRATION,
		/// <summary>
		/// ability of a material to conduct electricity.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.2">v1.2</see></item>
		/// </list>
		/// </remarks>
		CONDUCTIVITY,
		/// <summary>
		/// speed difference (relative velocity) between the cutting mechanism and the surface of the workpiece it is operating on.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.5">v1.5</see></item>
		/// </list>
		/// </remarks>
		CUTTING_SPEED,
		/// <summary>
		/// volumetric mass of a material per unit volume of that material.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.5">v1.5</see></item>
		/// </list>
		/// </remarks>
		DENSITY,
		/// <summary>
		/// rate of change in spatial volume of material deposited in an additive manufacturing process.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.5">v1.5</see></item>
		/// </list>
		/// </remarks>
		DEPOSITION_ACCELERATION_VOLUMETRIC,
		/// <summary>
		/// density of the material deposited in an additive manufacturing process per unit of volume.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.5">v1.5</see></item>
		/// </list>
		/// </remarks>
		DEPOSITION_DENSITY,
		/// <summary>
		/// mass of the material deposited in an additive manufacturing process.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.5">v1.5</see></item>
		/// </list>
		/// </remarks>
		DEPOSITION_MASS,
		/// <summary>
		/// rate at which a spatial volume of material is deposited in an additive manufacturing process.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.5">v1.5</see></item>
		/// </list>
		/// </remarks>
		DEPOSITION_RATE_VOLUMETRIC,
		/// <summary>
		/// spatial volume of material to be deposited in an additive manufacturing process.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.5">v1.5</see></item>
		/// </list>
		/// </remarks>
		DEPOSITION_VOLUME,
		/// <summary>
		/// change in position of an object.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>
		DISPLACEMENT,
		/// <summary>
		/// <see cref="Wattage">Wattage</see> used or generated by a component over an interval of time.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.2">v1.2</see></item>
		/// </list>
		/// </remarks>
		ELECTRICAL_ENERGY,
		/// <summary>
		/// amount of time a piece of equipment or a sub-part of a piece of equipment has performed specific activities.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.4">v1.4</see></item>
		/// </list>
		/// </remarks>
		EQUIPMENT_TIMER,
		/// <summary>
		/// amount of a substance remaining compared to the planned maximum amount of that substance.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.2">v1.2</see></item>
		/// </list>
		/// </remarks>
		FILL_LEVEL,
		/// <summary>
		/// rate of flow of a fluid.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.2">v1.2</see></item>
		/// </list>
		/// </remarks>
		FLOW,
		/// <summary>
		/// number of occurrences of a repeating event per unit time.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>
		FREQUENCY,
		/// <summary>
		/// position in three-dimensional space.  <b>DEPRECATED</b> in Version 1.1.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// <item><b>Deprecated</b>: <see href="https://model.mtconnect.org/#_Version_1.1">v1.1</see></item>
		/// </list>
		/// </remarks>
		[Obsolete("Deprecated in v1.1 according to https://model.mtconnect.org/#_Version_1.1")]
		GLOBAL_POSITION,
		/// <summary>
		/// length of an object.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.3">v1.3</see></item>
		/// </list>
		/// </remarks>
		LENGTH,
		/// <summary>
		/// level of a resource.  <b>DEPRECATED</b> in <i>Version 1.2</i>s.  See <c>FILL_LEVEL</c>.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.1">v1.1</see></item>
		/// <item><b>Deprecated</b>: <see href="https://model.mtconnect.org/#_Version_1.2">v1.2</see></item>
		/// </list>
		/// </remarks>
		[Obsolete("Deprecated in v1.2 according to https://model.mtconnect.org/#_Version_1.2")]
		LEVEL,
		/// <summary>
		/// <i>force</i> applied to a mass in one direction only.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.2">v1.2</see></item>
		/// </list>
		/// </remarks>
		LINEAR_FORCE,
		/// <summary>
		/// actual versus the standard rating of a piece of equipment.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>
		LOAD,
		/// <summary>
		/// mass of an object(s) or an amount of material.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.2">v1.2</see></item>
		/// </list>
		/// </remarks>
		MASS,
		/// <summary>
		/// feedrate for the axes, or a single axis, associated with a <see cref="Path">Path</see> component.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>
		PATH_FEEDRATE,
		/// <summary>
		/// feedrate for the axes, or a single axis.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.5">v1.5</see></item>
		/// </list>
		/// </remarks>
		PATH_FEEDRATE_PER_REVOLUTION,
		/// <summary>
		/// position of a control point associated with a <see cref="Controller">Controller</see> or a <see cref="Path">Path</see>.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.1">v1.1</see></item>
		/// </list>
		/// </remarks>
		PATH_POSITION,
		/// <summary>
		/// acidity or alkalinity of a solution.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.1">v1.1</see></item>
		/// </list>
		/// </remarks>
		PH,
		/// <summary>
		/// point along an axis in a <i>cartesian coordinate system</i>.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>
		POSITION,
		/// <summary>
		/// ratio of real power flowing to a load to the apparent power in that AC circuit.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.2">v1.2</see></item>
		/// </list>
		/// </remarks>
		POWER_FACTOR,
		/// <summary>
		/// force per unit area measured relative to atmospheric pressure.   Commonly referred to as gauge pressure.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>
		PRESSURE,
		/// <summary>
		/// amount of time a piece of equipment has performed different types of activities associated with the process being performed at that piece of equipment.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.4">v1.4</see></item>
		/// </list>
		/// </remarks>
		PROCESS_TIMER,
		/// <summary>
		/// degree to which a substance opposes the passage of an electric current.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.2">v1.2</see></item>
		/// </list>
		/// </remarks>
		RESISTANCE,
		/// <summary>
		/// rotational speed of a rotary axis.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.2">v1.2</see></item>
		/// </list>
		/// </remarks>
		ROTARY_VELOCITY,
		/// <summary>
		/// sound level or sound pressure level relative to atmospheric pressure.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.2">v1.2</see></item>
		/// </list>
		/// </remarks>
		SOUND_LEVEL,
		/// <summary>
		/// rotational speed of the rotary axis.  <b>DEPRECATED</b> in <i>Version 1.2</i>s.  Replaced by <c>ROTARY_VELOCITY</c>.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// <item><b>Deprecated</b>: <see href="https://model.mtconnect.org/#_Version_1.2">v1.2</see></item>
		/// </list>
		/// </remarks>
		[Obsolete("Deprecated in v1.2 according to https://model.mtconnect.org/#_Version_1.2")]
		SPINDLE_SPEED,
		/// <summary>
		/// amount of deformation per unit length of an object when a load is applied.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.2">v1.2</see></item>
		/// </list>
		/// </remarks>
		STRAIN,
		/// <summary>
		/// degree of hotness or coldness measured on a definite scale.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>
		TEMPERATURE,
		/// <summary>
		/// force that stretches or elongates an object.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.4">v1.4</see></item>
		/// </list>
		/// </remarks>
		TENSION,
		/// <summary>
		/// angular displacement.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.2">v1.2</see></item>
		/// </list>
		/// </remarks>
		TILT,
		/// <summary>
		/// turning force exerted on an object or by an object.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>
		TORQUE,
		/// <summary>
		/// rate of change of position of a <see cref="Component">Component</see>.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>
		VELOCITY,
		/// <summary>
		/// fluid's resistance to flow.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.2">v1.2</see></item>
		/// </list>
		/// </remarks>
		VISCOSITY,
		/// <summary>
		/// electrical potential between two points.  <b>DEPRECATED</b> in <i>Version 1.6</i>s. Replaced by <c>VOLTAGE_AC</c> and <c>VOLTAGE_DC</c>.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// <item><b>Deprecated</b>: <see href="https://model.mtconnect.org/#_Version_1.6">v1.6</see></item>
		/// </list>
		/// </remarks>
		[Obsolete("Deprecated in v1.6 according to https://model.mtconnect.org/#_Version_1.6")]
		VOLTAGE,
		/// <summary>
		/// apparent power in an electrical circuit, equal to the product of root-mean-square (RMS) voltage and RMS current (commonly referred to as VA).
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.2">v1.2</see></item>
		/// </list>
		/// </remarks>
		VOLT_AMPERE,
		/// <summary>
		/// reactive power in an AC electrical circuit (commonly referred to as VAR).
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.2">v1.2</see></item>
		/// </list>
		/// </remarks>
		VOLT_AMPERE_REACTIVE,
		/// <summary>
		/// fluid volume of an object or container.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.5">v1.5</see></item>
		/// </list>
		/// </remarks>
		VOLUME_FLUID,
		/// <summary>
		/// geometric volume of an object or container.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.5">v1.5</see></item>
		/// </list>
		/// </remarks>
		VOLUME_SPATIAL,
		/// <summary>
		/// power flowing through or dissipated by an electrical circuit or piece of equipment.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>
		WATTAGE,
		/// <summary>
		/// electrical current that reverses direction at regular short intervals.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.6">v1.6</see></item>
		/// </list>
		/// </remarks>
		AMPERAGE_AC,
		/// <summary>
		/// electric current flowing in one direction only.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.6">v1.6</see></item>
		/// </list>
		/// </remarks>
		AMPERAGE_DC,
		/// <summary>
		/// electrical potential between two points in an electrical circuit in which the current periodically reverses direction.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.6">v1.6</see></item>
		/// </list>
		/// </remarks>
		VOLTAGE_AC,
		/// <summary>
		/// electrical potential between two points in an electrical circuit in which the current is unidirectional.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.6">v1.6</see></item>
		/// </list>
		/// </remarks>
		VOLTAGE_DC,
		/// <summary>
		/// dimension of an entity relative to the X direction of the referenced coordinate system. 
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.6">v1.6</see></item>
		/// </list>
		/// </remarks>
		X_DIMENSION,
		/// <summary>
		/// dimension of an entity relative to the Y direction of the referenced coordinate system.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.6">v1.6</see></item>
		/// </list>
		/// </remarks>
		Y_DIMENSION,
		/// <summary>
		/// dimension of an entity relative to the Z direction of the referenced coordinate system.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.6">v1.6</see></item>
		/// </list>
		/// </remarks>
		Z_DIMENSION,
		/// <summary>
		/// dimension of a diameter.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.6">v1.6</see></item>
		/// </list>
		/// </remarks>
		DIAMETER,
		/// <summary>
		/// angular position of a plane or vector relative to a <i>cartesian coordinate system</i>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.6">v1.6</see></item>
		/// </list>
		/// </remarks>
		ORIENTATION,
		/// <summary>
		/// amount of water vapor present expressed as a percent to reach saturation at the same temperature.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.6">v1.6</see></item>
		/// </list>
		/// </remarks>
		HUMIDITY_RELATIVE,
		/// <summary>
		/// amount of water vapor expressed in grams per cubic meter.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.6">v1.6</see></item>
		/// </list>
		/// </remarks>
		HUMIDITY_ABSOLUTE,
		/// <summary>
		/// ratio of the water vapor present over the total weight of the water vapor and air present expressed as a percent.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.6">v1.6</see></item>
		/// </list>
		/// </remarks>
		HUMIDITY_SPECIFIC,
		/// <summary>
		/// average rate of change of values for data items in the MTConnect streams. The average is computed over a rolling window defined by the implementation.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.7">v1.7</see></item>
		/// </list>
		/// </remarks>
		OBSERVATION_UPDATE_RATE,
		/// <summary>
		/// average rate of change of values for assets in the MTConnect streams.   The average is computed over a rolling window defined by the implementation.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.7">v1.7</see></item>
		/// </list>
		/// </remarks>
		ASSET_UPDATE_RATE,
		/// <summary>
		/// change of pressure per unit time.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.7">v1.7</see></item>
		/// </list>
		/// </remarks>
		PRESSURIZATION_RATE,
		/// <summary>
		/// negative rate of change of velocity.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.7">v1.7</see></item>
		/// </list>
		/// </remarks>
		DECELERATION,
		/// <summary>
		/// negative rate of change of angular velocity.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.7">v1.7</see></item>
		/// </list>
		/// </remarks>
		ANGULAR_DECELERATION,
		/// <summary>
		/// force per unit area measured relative to a vacuum.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.7">v1.7</see></item>
		/// </list>
		/// </remarks>
		PRESSURE_ABSOLUTE,
		/// <summary>
		/// percentage open where 100% is fully open and 0% is fully closed.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_2.0">v2.0</see></item>
		/// </list>
		/// </remarks>
		OPENNESS,
		/// <summary>
		/// temperature at which moisture begins to condense, corresponding to saturation for a given absolute humidity.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_2.1">v2.1</see></item>
		/// </list>
		/// </remarks>
		DEW_POINT,
		/// <summary>
		/// force relative to earth's gravity.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_2.1">v2.1</see></item>
		/// </list>
		/// </remarks>
		GRAVITATIONAL_FORCE,
		/// <summary>
		/// acceleration relative to Earth's gravity of 9.80665 <c>METER/SECOND^2</c>.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_2.1">v2.1</see></item>
		/// </list>
		/// </remarks>
		GRAVITATIONAL_ACCELERATION,
		/// <summary>
		/// maximum rated charge a battery is capable of maintaining based on the battery discharging at a specified current over a specified time period.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_2.1">v2.1</see></item>
		/// </list>
		/// </remarks>
		BATTERY_CAPACITY,
		/// <summary>
		/// value of current being drawn from the <see cref="Component">Component</see>.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_2.1">v2.1</see></item>
		/// </list>
		/// </remarks>
		DISCHARGE_RATE,
		/// <summary>
		/// value of the current being supplied to the <see cref="Component">Component</see> for the purpose of charging.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_2.1">v2.1</see></item>
		/// </list>
		/// </remarks>
		CHARGE_RATE,
		/// <summary>
		/// value of the battery's present capacity expressed as a percentage of the battery's maximum rated capacity.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_2.1">v2.1</see></item>
		/// </list>
		/// </remarks>
		BATTERY_CHARGE,
		/// <summary>
		/// difference between actual and commanded position at the end of a motion.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_2.1">v2.1</see></item>
		/// </list>
		/// </remarks>
		SETTLING_ERROR,
		/// <summary>
		/// difference between actual and commanded position at any specific point in time during a motion.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_2.1">v2.1</see></item>
		/// </list>
		/// </remarks>
		FOLLOWING_ERROR,
		/// <summary>
		/// difference between the commanded encoder/resolver position, and the actual encoder/resolver position when motion is complete.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_2.1">v2.1</see></item>
		/// </list>
		/// </remarks>
		SETTLING_ERROR_LINEAR,
		/// <summary>
		/// angular difference between the commanded encoder/resolver position, and the actual encoder/resolver position when motion is complete.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_2.1">v2.1</see></item>
		/// </list>
		/// </remarks>
		SETTLING_ERROR_ANGULAR,
		/// <summary>
		/// difference between the commanded encoder/resolver position and the actual encoder/resolver position at any specified point in time during a motion.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_2.1">v2.1</see></item>
		/// </list>
		/// </remarks>
		FOLLOWING_ERROR_LINEAR,
		/// <summary>
		/// angular difference between the commanded encoder/resolver position and the actual encoder/resolver position at any specified point in time during a motion.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_2.1">v2.1</see></item>
		/// </list>
		/// </remarks>
		FOLLOWING_ERROR_ANGULAR,
		/// <summary>
		/// absolute value of the change in position along a vector.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_2.1">v2.1</see></item>
		/// </list>
		/// </remarks>
		DISPLACEMENT_LINEAR,
		/// <summary>
		/// absolute value of the change in angular position around a vector
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_2.1">v2.1</see></item>
		/// </list>
		/// </remarks>
		DISPLACEMENT_ANGULAR,
		/// <summary>
		/// point in a <i>cartesian coordinate system</i>.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_2.1">v2.1</see></item>
		/// </list>
		/// </remarks>
		POSITION_CARTESIAN,
	}

	/// <summary>
	/// View in the MTConnect Model browser <seealso href="https://model.mtconnect.org/#Enumeration___19_0_3_45f01b9_1580398370126_672808_12777">model.mtconnect.org</seealso>
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.3.0.0")]
	public sealed class SampleEnumMetaClass : IEnum
	{
		/// <inheritdoc />
		public string Name => "SampleEnum";
		
		/// <inheritdoc />
		public Type DataType => null;
		
		public Type Instance => typeof(SampleEnum);

		/// <inheritdoc />
		public string NormativeVersion => "1.0";
		
		/// <inheritdoc />
		public string DeprecatedVersion => "";
		
		/// <inheritdoc />
		public string Summary => @"";
		
		/// <inheritdoc />
		public IEnumInstance[] Values => new IEnumInstance[] {
		ACCELERATION,
		ACCUMULATED_TIME,
		AMPERAGE,
		ANGLE,
		ANGULAR_ACCELERATION,
		ANGULAR_VELOCITY,
		AXIS_FEEDRATE,
		CAPACITY_FLUID,
		CAPACITY_SPATIAL,
		CONCENTRATION,
		CONDUCTIVITY,
		CUTTING_SPEED,
		DENSITY,
		DEPOSITION_ACCELERATION_VOLUMETRIC,
		DEPOSITION_DENSITY,
		DEPOSITION_MASS,
		DEPOSITION_RATE_VOLUMETRIC,
		DEPOSITION_VOLUME,
		DISPLACEMENT,
		ELECTRICAL_ENERGY,
		EQUIPMENT_TIMER,
		FILL_LEVEL,
		FLOW,
		FREQUENCY,
		GLOBAL_POSITION,
		LENGTH,
		LEVEL,
		LINEAR_FORCE,
		LOAD,
		MASS,
		PATH_FEEDRATE,
		PATH_FEEDRATE_PER_REVOLUTION,
		PATH_POSITION,
		PH,
		POSITION,
		POWER_FACTOR,
		PRESSURE,
		PROCESS_TIMER,
		RESISTANCE,
		ROTARY_VELOCITY,
		SOUND_LEVEL,
		SPINDLE_SPEED,
		STRAIN,
		TEMPERATURE,
		TENSION,
		TILT,
		TORQUE,
		VELOCITY,
		VISCOSITY,
		VOLTAGE,
		VOLT_AMPERE,
		VOLT_AMPERE_REACTIVE,
		VOLUME_FLUID,
		VOLUME_SPATIAL,
		WATTAGE,
		AMPERAGE_AC,
		AMPERAGE_DC,
		VOLTAGE_AC,
		VOLTAGE_DC,
		X_DIMENSION,
		Y_DIMENSION,
		Z_DIMENSION,
		DIAMETER,
		ORIENTATION,
		HUMIDITY_RELATIVE,
		HUMIDITY_ABSOLUTE,
		HUMIDITY_SPECIFIC,
		OBSERVATION_UPDATE_RATE,
		ASSET_UPDATE_RATE,
		PRESSURIZATION_RATE,
		DECELERATION,
		ANGULAR_DECELERATION,
		PRESSURE_ABSOLUTE,
		OPENNESS,
		DEW_POINT,
		GRAVITATIONAL_FORCE,
		GRAVITATIONAL_ACCELERATION,
		BATTERY_CAPACITY,
		DISCHARGE_RATE,
		CHARGE_RATE,
		BATTERY_CHARGE,
		SETTLING_ERROR,
		FOLLOWING_ERROR,
		SETTLING_ERROR_LINEAR,
		SETTLING_ERROR_ANGULAR,
		FOLLOWING_ERROR_LINEAR,
		FOLLOWING_ERROR_ANGULAR,
		DISPLACEMENT_LINEAR,
		DISPLACEMENT_ANGULAR,
		POSITION_CARTESIAN,
		};

		private ACCELERATIONValue _ACCELERATION;
		/// <summary>
		/// positive rate of change of velocity.
		/// </summary>
		public ACCELERATIONValue ACCELERATION => _ACCELERATION ?? (_ACCELERATION = new ACCELERATIONValue());

		/// <summary>
		/// positive rate of change of velocity.
		/// </summary>
		public sealed class ACCELERATIONValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "ACCELERATION";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.0";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// positive rate of change of velocity.";
		}
		private ACCUMULATED_TIMEValue _ACCUMULATED_TIME;
		/// <summary>
		/// accumulated time for an activity or event.
		/// </summary>
		public ACCUMULATED_TIMEValue ACCUMULATED_TIME => _ACCUMULATED_TIME ?? (_ACCUMULATED_TIME = new ACCUMULATED_TIMEValue());

		/// <summary>
		/// accumulated time for an activity or event.
		/// </summary>
		public sealed class ACCUMULATED_TIMEValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "ACCUMULATED_TIME";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.2";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// accumulated time for an activity or event.";
		}
		private AMPERAGEValue _AMPERAGE;
		/// <summary>
		/// strength of electrical current.  <b>DEPRECATED</b> in <i>Version 1.6</i>s. Replaced by <c>AMPERAGE_AC</c> and <c>AMPERAGE_DC</c>.
		/// </summary>
		public AMPERAGEValue AMPERAGE => _AMPERAGE ?? (_AMPERAGE = new AMPERAGEValue());

		/// <summary>
		/// strength of electrical current.  <b>DEPRECATED</b> in <i>Version 1.6</i>s. Replaced by <c>AMPERAGE_AC</c> and <c>AMPERAGE_DC</c>.
		/// </summary>
		public sealed class AMPERAGEValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "AMPERAGE";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.0";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "1.6";
			
			/// <inheritdoc />
			public string Summary => @"/// strength of electrical current.  <b>DEPRECATED</b> in <i>Version 1.6</i>s. Replaced by <c>AMPERAGE_AC</c> and <c>AMPERAGE_DC</c>.";
		}
		private ANGLEValue _ANGLE;
		/// <summary>
		/// angular position.
		/// </summary>
		public ANGLEValue ANGLE => _ANGLE ?? (_ANGLE = new ANGLEValue());

		/// <summary>
		/// angular position.
		/// </summary>
		public sealed class ANGLEValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "ANGLE";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.0";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// angular position.";
		}
		private ANGULAR_ACCELERATIONValue _ANGULAR_ACCELERATION;
		/// <summary>
		/// positive rate of change of angular velocity.
		/// </summary>
		public ANGULAR_ACCELERATIONValue ANGULAR_ACCELERATION => _ANGULAR_ACCELERATION ?? (_ANGULAR_ACCELERATION = new ANGULAR_ACCELERATIONValue());

		/// <summary>
		/// positive rate of change of angular velocity.
		/// </summary>
		public sealed class ANGULAR_ACCELERATIONValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "ANGULAR_ACCELERATION";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.0";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// positive rate of change of angular velocity.";
		}
		private ANGULAR_VELOCITYValue _ANGULAR_VELOCITY;
		/// <summary>
		/// rate of change of angular position.
		/// </summary>
		public ANGULAR_VELOCITYValue ANGULAR_VELOCITY => _ANGULAR_VELOCITY ?? (_ANGULAR_VELOCITY = new ANGULAR_VELOCITYValue());

		/// <summary>
		/// rate of change of angular position.
		/// </summary>
		public sealed class ANGULAR_VELOCITYValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "ANGULAR_VELOCITY";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.0";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// rate of change of angular position.";
		}
		private AXIS_FEEDRATEValue _AXIS_FEEDRATE;
		/// <summary>
		/// feedrate of a linear axis.
		/// </summary>
		public AXIS_FEEDRATEValue AXIS_FEEDRATE => _AXIS_FEEDRATE ?? (_AXIS_FEEDRATE = new AXIS_FEEDRATEValue());

		/// <summary>
		/// feedrate of a linear axis.
		/// </summary>
		public sealed class AXIS_FEEDRATEValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "AXIS_FEEDRATE";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.0";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// feedrate of a linear axis.";
		}
		private CAPACITY_FLUIDValue _CAPACITY_FLUID;
		/// <summary>
		/// fluid capacity of an object or container.
		/// </summary>
		public CAPACITY_FLUIDValue CAPACITY_FLUID => _CAPACITY_FLUID ?? (_CAPACITY_FLUID = new CAPACITY_FLUIDValue());

		/// <summary>
		/// fluid capacity of an object or container.
		/// </summary>
		public sealed class CAPACITY_FLUIDValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "CAPACITY_FLUID";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.5";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// fluid capacity of an object or container.";
		}
		private CAPACITY_SPATIALValue _CAPACITY_SPATIAL;
		/// <summary>
		/// geometric capacity of an object or container.
		/// </summary>
		public CAPACITY_SPATIALValue CAPACITY_SPATIAL => _CAPACITY_SPATIAL ?? (_CAPACITY_SPATIAL = new CAPACITY_SPATIALValue());

		/// <summary>
		/// geometric capacity of an object or container.
		/// </summary>
		public sealed class CAPACITY_SPATIALValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "CAPACITY_SPATIAL";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.5";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// geometric capacity of an object or container.";
		}
		private CONCENTRATIONValue _CONCENTRATION;
		/// <summary>
		/// percentage of one component within a mixture of components.
		/// </summary>
		public CONCENTRATIONValue CONCENTRATION => _CONCENTRATION ?? (_CONCENTRATION = new CONCENTRATIONValue());

		/// <summary>
		/// percentage of one component within a mixture of components.
		/// </summary>
		public sealed class CONCENTRATIONValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "CONCENTRATION";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.2";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// percentage of one component within a mixture of components.";
		}
		private CONDUCTIVITYValue _CONDUCTIVITY;
		/// <summary>
		/// ability of a material to conduct electricity.
		/// </summary>
		public CONDUCTIVITYValue CONDUCTIVITY => _CONDUCTIVITY ?? (_CONDUCTIVITY = new CONDUCTIVITYValue());

		/// <summary>
		/// ability of a material to conduct electricity.
		/// </summary>
		public sealed class CONDUCTIVITYValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "CONDUCTIVITY";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.2";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// ability of a material to conduct electricity.";
		}
		private CUTTING_SPEEDValue _CUTTING_SPEED;
		/// <summary>
		/// speed difference (relative velocity) between the cutting mechanism and the surface of the workpiece it is operating on.
		/// </summary>
		public CUTTING_SPEEDValue CUTTING_SPEED => _CUTTING_SPEED ?? (_CUTTING_SPEED = new CUTTING_SPEEDValue());

		/// <summary>
		/// speed difference (relative velocity) between the cutting mechanism and the surface of the workpiece it is operating on.
		/// </summary>
		public sealed class CUTTING_SPEEDValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "CUTTING_SPEED";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.5";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// speed difference (relative velocity) between the cutting mechanism and the surface of the workpiece it is operating on.";
		}
		private DENSITYValue _DENSITY;
		/// <summary>
		/// volumetric mass of a material per unit volume of that material.
		/// </summary>
		public DENSITYValue DENSITY => _DENSITY ?? (_DENSITY = new DENSITYValue());

		/// <summary>
		/// volumetric mass of a material per unit volume of that material.
		/// </summary>
		public sealed class DENSITYValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "DENSITY";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.5";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// volumetric mass of a material per unit volume of that material.";
		}
		private DEPOSITION_ACCELERATION_VOLUMETRICValue _DEPOSITION_ACCELERATION_VOLUMETRIC;
		/// <summary>
		/// rate of change in spatial volume of material deposited in an additive manufacturing process.
		/// </summary>
		public DEPOSITION_ACCELERATION_VOLUMETRICValue DEPOSITION_ACCELERATION_VOLUMETRIC => _DEPOSITION_ACCELERATION_VOLUMETRIC ?? (_DEPOSITION_ACCELERATION_VOLUMETRIC = new DEPOSITION_ACCELERATION_VOLUMETRICValue());

		/// <summary>
		/// rate of change in spatial volume of material deposited in an additive manufacturing process.
		/// </summary>
		public sealed class DEPOSITION_ACCELERATION_VOLUMETRICValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "DEPOSITION_ACCELERATION_VOLUMETRIC";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.5";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// rate of change in spatial volume of material deposited in an additive manufacturing process.";
		}
		private DEPOSITION_DENSITYValue _DEPOSITION_DENSITY;
		/// <summary>
		/// density of the material deposited in an additive manufacturing process per unit of volume.
		/// </summary>
		public DEPOSITION_DENSITYValue DEPOSITION_DENSITY => _DEPOSITION_DENSITY ?? (_DEPOSITION_DENSITY = new DEPOSITION_DENSITYValue());

		/// <summary>
		/// density of the material deposited in an additive manufacturing process per unit of volume.
		/// </summary>
		public sealed class DEPOSITION_DENSITYValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "DEPOSITION_DENSITY";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.5";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// density of the material deposited in an additive manufacturing process per unit of volume.";
		}
		private DEPOSITION_MASSValue _DEPOSITION_MASS;
		/// <summary>
		/// mass of the material deposited in an additive manufacturing process.
		/// </summary>
		public DEPOSITION_MASSValue DEPOSITION_MASS => _DEPOSITION_MASS ?? (_DEPOSITION_MASS = new DEPOSITION_MASSValue());

		/// <summary>
		/// mass of the material deposited in an additive manufacturing process.
		/// </summary>
		public sealed class DEPOSITION_MASSValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "DEPOSITION_MASS";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.5";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// mass of the material deposited in an additive manufacturing process.";
		}
		private DEPOSITION_RATE_VOLUMETRICValue _DEPOSITION_RATE_VOLUMETRIC;
		/// <summary>
		/// rate at which a spatial volume of material is deposited in an additive manufacturing process.
		/// </summary>
		public DEPOSITION_RATE_VOLUMETRICValue DEPOSITION_RATE_VOLUMETRIC => _DEPOSITION_RATE_VOLUMETRIC ?? (_DEPOSITION_RATE_VOLUMETRIC = new DEPOSITION_RATE_VOLUMETRICValue());

		/// <summary>
		/// rate at which a spatial volume of material is deposited in an additive manufacturing process.
		/// </summary>
		public sealed class DEPOSITION_RATE_VOLUMETRICValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "DEPOSITION_RATE_VOLUMETRIC";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.5";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// rate at which a spatial volume of material is deposited in an additive manufacturing process.";
		}
		private DEPOSITION_VOLUMEValue _DEPOSITION_VOLUME;
		/// <summary>
		/// spatial volume of material to be deposited in an additive manufacturing process.
		/// </summary>
		public DEPOSITION_VOLUMEValue DEPOSITION_VOLUME => _DEPOSITION_VOLUME ?? (_DEPOSITION_VOLUME = new DEPOSITION_VOLUMEValue());

		/// <summary>
		/// spatial volume of material to be deposited in an additive manufacturing process.
		/// </summary>
		public sealed class DEPOSITION_VOLUMEValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "DEPOSITION_VOLUME";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.5";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// spatial volume of material to be deposited in an additive manufacturing process.";
		}
		private DISPLACEMENTValue _DISPLACEMENT;
		/// <summary>
		/// change in position of an object.
		/// </summary>
		public DISPLACEMENTValue DISPLACEMENT => _DISPLACEMENT ?? (_DISPLACEMENT = new DISPLACEMENTValue());

		/// <summary>
		/// change in position of an object.
		/// </summary>
		public sealed class DISPLACEMENTValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "DISPLACEMENT";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.0";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// change in position of an object.";
		}
		private ELECTRICAL_ENERGYValue _ELECTRICAL_ENERGY;
		/// <summary>
		/// <see cref="Wattage">Wattage</see> used or generated by a component over an interval of time.
		/// </summary>
		public ELECTRICAL_ENERGYValue ELECTRICAL_ENERGY => _ELECTRICAL_ENERGY ?? (_ELECTRICAL_ENERGY = new ELECTRICAL_ENERGYValue());

		/// <summary>
		/// <see cref="Wattage">Wattage</see> used or generated by a component over an interval of time.
		/// </summary>
		public sealed class ELECTRICAL_ENERGYValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "ELECTRICAL_ENERGY";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.2";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// <see cref=""Wattage"">Wattage</see> used or generated by a component over an interval of time.";
		}
		private EQUIPMENT_TIMERValue _EQUIPMENT_TIMER;
		/// <summary>
		/// amount of time a piece of equipment or a sub-part of a piece of equipment has performed specific activities.
		/// </summary>
		public EQUIPMENT_TIMERValue EQUIPMENT_TIMER => _EQUIPMENT_TIMER ?? (_EQUIPMENT_TIMER = new EQUIPMENT_TIMERValue());

		/// <summary>
		/// amount of time a piece of equipment or a sub-part of a piece of equipment has performed specific activities.
		/// </summary>
		public sealed class EQUIPMENT_TIMERValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "EQUIPMENT_TIMER";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.4";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// amount of time a piece of equipment or a sub-part of a piece of equipment has performed specific activities.";
		}
		private FILL_LEVELValue _FILL_LEVEL;
		/// <summary>
		/// amount of a substance remaining compared to the planned maximum amount of that substance.
		/// </summary>
		public FILL_LEVELValue FILL_LEVEL => _FILL_LEVEL ?? (_FILL_LEVEL = new FILL_LEVELValue());

		/// <summary>
		/// amount of a substance remaining compared to the planned maximum amount of that substance.
		/// </summary>
		public sealed class FILL_LEVELValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "FILL_LEVEL";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.2";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// amount of a substance remaining compared to the planned maximum amount of that substance.";
		}
		private FLOWValue _FLOW;
		/// <summary>
		/// rate of flow of a fluid.
		/// </summary>
		public FLOWValue FLOW => _FLOW ?? (_FLOW = new FLOWValue());

		/// <summary>
		/// rate of flow of a fluid.
		/// </summary>
		public sealed class FLOWValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "FLOW";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.2";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// rate of flow of a fluid.";
		}
		private FREQUENCYValue _FREQUENCY;
		/// <summary>
		/// number of occurrences of a repeating event per unit time.
		/// </summary>
		public FREQUENCYValue FREQUENCY => _FREQUENCY ?? (_FREQUENCY = new FREQUENCYValue());

		/// <summary>
		/// number of occurrences of a repeating event per unit time.
		/// </summary>
		public sealed class FREQUENCYValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "FREQUENCY";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.0";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// number of occurrences of a repeating event per unit time.";
		}
		private GLOBAL_POSITIONValue _GLOBAL_POSITION;
		/// <summary>
		/// position in three-dimensional space.  <b>DEPRECATED</b> in Version 1.1.
		/// </summary>
		public GLOBAL_POSITIONValue GLOBAL_POSITION => _GLOBAL_POSITION ?? (_GLOBAL_POSITION = new GLOBAL_POSITIONValue());

		/// <summary>
		/// position in three-dimensional space.  <b>DEPRECATED</b> in Version 1.1.
		/// </summary>
		public sealed class GLOBAL_POSITIONValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "GLOBAL_POSITION";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.0";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "1.1";
			
			/// <inheritdoc />
			public string Summary => @"/// position in three-dimensional space.  <b>DEPRECATED</b> in Version 1.1.";
		}
		private LENGTHValue _LENGTH;
		/// <summary>
		/// length of an object.
		/// </summary>
		public LENGTHValue LENGTH => _LENGTH ?? (_LENGTH = new LENGTHValue());

		/// <summary>
		/// length of an object.
		/// </summary>
		public sealed class LENGTHValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "LENGTH";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.3";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// length of an object.";
		}
		private LEVELValue _LEVEL;
		/// <summary>
		/// level of a resource.  <b>DEPRECATED</b> in <i>Version 1.2</i>s.  See <c>FILL_LEVEL</c>.
		/// </summary>
		public LEVELValue LEVEL => _LEVEL ?? (_LEVEL = new LEVELValue());

		/// <summary>
		/// level of a resource.  <b>DEPRECATED</b> in <i>Version 1.2</i>s.  See <c>FILL_LEVEL</c>.
		/// </summary>
		public sealed class LEVELValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "LEVEL";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.1";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "1.2";
			
			/// <inheritdoc />
			public string Summary => @"/// level of a resource.  <b>DEPRECATED</b> in <i>Version 1.2</i>s.  See <c>FILL_LEVEL</c>.";
		}
		private LINEAR_FORCEValue _LINEAR_FORCE;
		/// <summary>
		/// <i>force</i> applied to a mass in one direction only.
		/// </summary>
		public LINEAR_FORCEValue LINEAR_FORCE => _LINEAR_FORCE ?? (_LINEAR_FORCE = new LINEAR_FORCEValue());

		/// <summary>
		/// <i>force</i> applied to a mass in one direction only.
		/// </summary>
		public sealed class LINEAR_FORCEValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "LINEAR_FORCE";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.2";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// <i>force</i> applied to a mass in one direction only.";
		}
		private LOADValue _LOAD;
		/// <summary>
		/// actual versus the standard rating of a piece of equipment.
		/// </summary>
		public LOADValue LOAD => _LOAD ?? (_LOAD = new LOADValue());

		/// <summary>
		/// actual versus the standard rating of a piece of equipment.
		/// </summary>
		public sealed class LOADValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "LOAD";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.0";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// actual versus the standard rating of a piece of equipment.";
		}
		private MASSValue _MASS;
		/// <summary>
		/// mass of an object(s) or an amount of material.
		/// </summary>
		public MASSValue MASS => _MASS ?? (_MASS = new MASSValue());

		/// <summary>
		/// mass of an object(s) or an amount of material.
		/// </summary>
		public sealed class MASSValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "MASS";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.2";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// mass of an object(s) or an amount of material.";
		}
		private PATH_FEEDRATEValue _PATH_FEEDRATE;
		/// <summary>
		/// feedrate for the axes, or a single axis, associated with a <see cref="Path">Path</see> component.
		/// </summary>
		public PATH_FEEDRATEValue PATH_FEEDRATE => _PATH_FEEDRATE ?? (_PATH_FEEDRATE = new PATH_FEEDRATEValue());

		/// <summary>
		/// feedrate for the axes, or a single axis, associated with a <see cref="Path">Path</see> component.
		/// </summary>
		public sealed class PATH_FEEDRATEValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "PATH_FEEDRATE";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.0";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// feedrate for the axes, or a single axis, associated with a <see cref=""Path"">Path</see> component.";
		}
		private PATH_FEEDRATE_PER_REVOLUTIONValue _PATH_FEEDRATE_PER_REVOLUTION;
		/// <summary>
		/// feedrate for the axes, or a single axis.
		/// </summary>
		public PATH_FEEDRATE_PER_REVOLUTIONValue PATH_FEEDRATE_PER_REVOLUTION => _PATH_FEEDRATE_PER_REVOLUTION ?? (_PATH_FEEDRATE_PER_REVOLUTION = new PATH_FEEDRATE_PER_REVOLUTIONValue());

		/// <summary>
		/// feedrate for the axes, or a single axis.
		/// </summary>
		public sealed class PATH_FEEDRATE_PER_REVOLUTIONValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "PATH_FEEDRATE_PER_REVOLUTION";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.5";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// feedrate for the axes, or a single axis.";
		}
		private PATH_POSITIONValue _PATH_POSITION;
		/// <summary>
		/// position of a control point associated with a <see cref="Controller">Controller</see> or a <see cref="Path">Path</see>.
		/// </summary>
		public PATH_POSITIONValue PATH_POSITION => _PATH_POSITION ?? (_PATH_POSITION = new PATH_POSITIONValue());

		/// <summary>
		/// position of a control point associated with a <see cref="Controller">Controller</see> or a <see cref="Path">Path</see>.
		/// </summary>
		public sealed class PATH_POSITIONValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "PATH_POSITION";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.1";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// position of a control point associated with a <see cref=""Controller"">Controller</see> or a <see cref=""Path"">Path</see>.";
		}
		private PHValue _PH;
		/// <summary>
		/// acidity or alkalinity of a solution.
		/// </summary>
		public PHValue PH => _PH ?? (_PH = new PHValue());

		/// <summary>
		/// acidity or alkalinity of a solution.
		/// </summary>
		public sealed class PHValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "PH";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.1";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// acidity or alkalinity of a solution.";
		}
		private POSITIONValue _POSITION;
		/// <summary>
		/// point along an axis in a <i>cartesian coordinate system</i>.
		/// </summary>
		public POSITIONValue POSITION => _POSITION ?? (_POSITION = new POSITIONValue());

		/// <summary>
		/// point along an axis in a <i>cartesian coordinate system</i>.
		/// </summary>
		public sealed class POSITIONValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "POSITION";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.0";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// point along an axis in a <i>cartesian coordinate system</i>.";
		}
		private POWER_FACTORValue _POWER_FACTOR;
		/// <summary>
		/// ratio of real power flowing to a load to the apparent power in that AC circuit.
		/// </summary>
		public POWER_FACTORValue POWER_FACTOR => _POWER_FACTOR ?? (_POWER_FACTOR = new POWER_FACTORValue());

		/// <summary>
		/// ratio of real power flowing to a load to the apparent power in that AC circuit.
		/// </summary>
		public sealed class POWER_FACTORValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "POWER_FACTOR";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.2";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// ratio of real power flowing to a load to the apparent power in that AC circuit.";
		}
		private PRESSUREValue _PRESSURE;
		/// <summary>
		/// force per unit area measured relative to atmospheric pressure.   Commonly referred to as gauge pressure.
		/// </summary>
		public PRESSUREValue PRESSURE => _PRESSURE ?? (_PRESSURE = new PRESSUREValue());

		/// <summary>
		/// force per unit area measured relative to atmospheric pressure.   Commonly referred to as gauge pressure.
		/// </summary>
		public sealed class PRESSUREValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "PRESSURE";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.0";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// force per unit area measured relative to atmospheric pressure.   Commonly referred to as gauge pressure.";
		}
		private PROCESS_TIMERValue _PROCESS_TIMER;
		/// <summary>
		/// amount of time a piece of equipment has performed different types of activities associated with the process being performed at that piece of equipment.
		/// </summary>
		public PROCESS_TIMERValue PROCESS_TIMER => _PROCESS_TIMER ?? (_PROCESS_TIMER = new PROCESS_TIMERValue());

		/// <summary>
		/// amount of time a piece of equipment has performed different types of activities associated with the process being performed at that piece of equipment.
		/// </summary>
		public sealed class PROCESS_TIMERValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "PROCESS_TIMER";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.4";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// amount of time a piece of equipment has performed different types of activities associated with the process being performed at that piece of equipment.";
		}
		private RESISTANCEValue _RESISTANCE;
		/// <summary>
		/// degree to which a substance opposes the passage of an electric current.
		/// </summary>
		public RESISTANCEValue RESISTANCE => _RESISTANCE ?? (_RESISTANCE = new RESISTANCEValue());

		/// <summary>
		/// degree to which a substance opposes the passage of an electric current.
		/// </summary>
		public sealed class RESISTANCEValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "RESISTANCE";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.2";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// degree to which a substance opposes the passage of an electric current.";
		}
		private ROTARY_VELOCITYValue _ROTARY_VELOCITY;
		/// <summary>
		/// rotational speed of a rotary axis.
		/// </summary>
		public ROTARY_VELOCITYValue ROTARY_VELOCITY => _ROTARY_VELOCITY ?? (_ROTARY_VELOCITY = new ROTARY_VELOCITYValue());

		/// <summary>
		/// rotational speed of a rotary axis.
		/// </summary>
		public sealed class ROTARY_VELOCITYValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "ROTARY_VELOCITY";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.2";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// rotational speed of a rotary axis.";
		}
		private SOUND_LEVELValue _SOUND_LEVEL;
		/// <summary>
		/// sound level or sound pressure level relative to atmospheric pressure.
		/// </summary>
		public SOUND_LEVELValue SOUND_LEVEL => _SOUND_LEVEL ?? (_SOUND_LEVEL = new SOUND_LEVELValue());

		/// <summary>
		/// sound level or sound pressure level relative to atmospheric pressure.
		/// </summary>
		public sealed class SOUND_LEVELValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "SOUND_LEVEL";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.2";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// sound level or sound pressure level relative to atmospheric pressure.";
		}
		private SPINDLE_SPEEDValue _SPINDLE_SPEED;
		/// <summary>
		/// rotational speed of the rotary axis.  <b>DEPRECATED</b> in <i>Version 1.2</i>s.  Replaced by <c>ROTARY_VELOCITY</c>.
		/// </summary>
		public SPINDLE_SPEEDValue SPINDLE_SPEED => _SPINDLE_SPEED ?? (_SPINDLE_SPEED = new SPINDLE_SPEEDValue());

		/// <summary>
		/// rotational speed of the rotary axis.  <b>DEPRECATED</b> in <i>Version 1.2</i>s.  Replaced by <c>ROTARY_VELOCITY</c>.
		/// </summary>
		public sealed class SPINDLE_SPEEDValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "SPINDLE_SPEED";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.0";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "1.2";
			
			/// <inheritdoc />
			public string Summary => @"/// rotational speed of the rotary axis.  <b>DEPRECATED</b> in <i>Version 1.2</i>s.  Replaced by <c>ROTARY_VELOCITY</c>.";
		}
		private STRAINValue _STRAIN;
		/// <summary>
		/// amount of deformation per unit length of an object when a load is applied.
		/// </summary>
		public STRAINValue STRAIN => _STRAIN ?? (_STRAIN = new STRAINValue());

		/// <summary>
		/// amount of deformation per unit length of an object when a load is applied.
		/// </summary>
		public sealed class STRAINValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "STRAIN";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.2";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// amount of deformation per unit length of an object when a load is applied.";
		}
		private TEMPERATUREValue _TEMPERATURE;
		/// <summary>
		/// degree of hotness or coldness measured on a definite scale.
		/// </summary>
		public TEMPERATUREValue TEMPERATURE => _TEMPERATURE ?? (_TEMPERATURE = new TEMPERATUREValue());

		/// <summary>
		/// degree of hotness or coldness measured on a definite scale.
		/// </summary>
		public sealed class TEMPERATUREValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "TEMPERATURE";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.0";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// degree of hotness or coldness measured on a definite scale.";
		}
		private TENSIONValue _TENSION;
		/// <summary>
		/// force that stretches or elongates an object.
		/// </summary>
		public TENSIONValue TENSION => _TENSION ?? (_TENSION = new TENSIONValue());

		/// <summary>
		/// force that stretches or elongates an object.
		/// </summary>
		public sealed class TENSIONValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "TENSION";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.4";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// force that stretches or elongates an object.";
		}
		private TILTValue _TILT;
		/// <summary>
		/// angular displacement.
		/// </summary>
		public TILTValue TILT => _TILT ?? (_TILT = new TILTValue());

		/// <summary>
		/// angular displacement.
		/// </summary>
		public sealed class TILTValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "TILT";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.2";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// angular displacement.";
		}
		private TORQUEValue _TORQUE;
		/// <summary>
		/// turning force exerted on an object or by an object.
		/// </summary>
		public TORQUEValue TORQUE => _TORQUE ?? (_TORQUE = new TORQUEValue());

		/// <summary>
		/// turning force exerted on an object or by an object.
		/// </summary>
		public sealed class TORQUEValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "TORQUE";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.0";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// turning force exerted on an object or by an object.";
		}
		private VELOCITYValue _VELOCITY;
		/// <summary>
		/// rate of change of position of a <see cref="Component">Component</see>.
		/// </summary>
		public VELOCITYValue VELOCITY => _VELOCITY ?? (_VELOCITY = new VELOCITYValue());

		/// <summary>
		/// rate of change of position of a <see cref="Component">Component</see>.
		/// </summary>
		public sealed class VELOCITYValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "VELOCITY";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.0";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// rate of change of position of a <see cref=""Component"">Component</see>.";
		}
		private VISCOSITYValue _VISCOSITY;
		/// <summary>
		/// fluid's resistance to flow.
		/// </summary>
		public VISCOSITYValue VISCOSITY => _VISCOSITY ?? (_VISCOSITY = new VISCOSITYValue());

		/// <summary>
		/// fluid's resistance to flow.
		/// </summary>
		public sealed class VISCOSITYValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "VISCOSITY";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.2";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// fluid's resistance to flow.";
		}
		private VOLTAGEValue _VOLTAGE;
		/// <summary>
		/// electrical potential between two points.  <b>DEPRECATED</b> in <i>Version 1.6</i>s. Replaced by <c>VOLTAGE_AC</c> and <c>VOLTAGE_DC</c>.
		/// </summary>
		public VOLTAGEValue VOLTAGE => _VOLTAGE ?? (_VOLTAGE = new VOLTAGEValue());

		/// <summary>
		/// electrical potential between two points.  <b>DEPRECATED</b> in <i>Version 1.6</i>s. Replaced by <c>VOLTAGE_AC</c> and <c>VOLTAGE_DC</c>.
		/// </summary>
		public sealed class VOLTAGEValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "VOLTAGE";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.0";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "1.6";
			
			/// <inheritdoc />
			public string Summary => @"/// electrical potential between two points.  <b>DEPRECATED</b> in <i>Version 1.6</i>s. Replaced by <c>VOLTAGE_AC</c> and <c>VOLTAGE_DC</c>.";
		}
		private VOLT_AMPEREValue _VOLT_AMPERE;
		/// <summary>
		/// apparent power in an electrical circuit, equal to the product of root-mean-square (RMS) voltage and RMS current (commonly referred to as VA).
		/// </summary>
		public VOLT_AMPEREValue VOLT_AMPERE => _VOLT_AMPERE ?? (_VOLT_AMPERE = new VOLT_AMPEREValue());

		/// <summary>
		/// apparent power in an electrical circuit, equal to the product of root-mean-square (RMS) voltage and RMS current (commonly referred to as VA).
		/// </summary>
		public sealed class VOLT_AMPEREValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "VOLT_AMPERE";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.2";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// apparent power in an electrical circuit, equal to the product of root-mean-square (RMS) voltage and RMS current (commonly referred to as VA).";
		}
		private VOLT_AMPERE_REACTIVEValue _VOLT_AMPERE_REACTIVE;
		/// <summary>
		/// reactive power in an AC electrical circuit (commonly referred to as VAR).
		/// </summary>
		public VOLT_AMPERE_REACTIVEValue VOLT_AMPERE_REACTIVE => _VOLT_AMPERE_REACTIVE ?? (_VOLT_AMPERE_REACTIVE = new VOLT_AMPERE_REACTIVEValue());

		/// <summary>
		/// reactive power in an AC electrical circuit (commonly referred to as VAR).
		/// </summary>
		public sealed class VOLT_AMPERE_REACTIVEValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "VOLT_AMPERE_REACTIVE";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.2";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// reactive power in an AC electrical circuit (commonly referred to as VAR).";
		}
		private VOLUME_FLUIDValue _VOLUME_FLUID;
		/// <summary>
		/// fluid volume of an object or container.
		/// </summary>
		public VOLUME_FLUIDValue VOLUME_FLUID => _VOLUME_FLUID ?? (_VOLUME_FLUID = new VOLUME_FLUIDValue());

		/// <summary>
		/// fluid volume of an object or container.
		/// </summary>
		public sealed class VOLUME_FLUIDValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "VOLUME_FLUID";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.5";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// fluid volume of an object or container.";
		}
		private VOLUME_SPATIALValue _VOLUME_SPATIAL;
		/// <summary>
		/// geometric volume of an object or container.
		/// </summary>
		public VOLUME_SPATIALValue VOLUME_SPATIAL => _VOLUME_SPATIAL ?? (_VOLUME_SPATIAL = new VOLUME_SPATIALValue());

		/// <summary>
		/// geometric volume of an object or container.
		/// </summary>
		public sealed class VOLUME_SPATIALValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "VOLUME_SPATIAL";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.5";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// geometric volume of an object or container.";
		}
		private WATTAGEValue _WATTAGE;
		/// <summary>
		/// power flowing through or dissipated by an electrical circuit or piece of equipment.
		/// </summary>
		public WATTAGEValue WATTAGE => _WATTAGE ?? (_WATTAGE = new WATTAGEValue());

		/// <summary>
		/// power flowing through or dissipated by an electrical circuit or piece of equipment.
		/// </summary>
		public sealed class WATTAGEValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "WATTAGE";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.0";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// power flowing through or dissipated by an electrical circuit or piece of equipment.";
		}
		private AMPERAGE_ACValue _AMPERAGE_AC;
		/// <summary>
		/// electrical current that reverses direction at regular short intervals.
		/// </summary>
		public AMPERAGE_ACValue AMPERAGE_AC => _AMPERAGE_AC ?? (_AMPERAGE_AC = new AMPERAGE_ACValue());

		/// <summary>
		/// electrical current that reverses direction at regular short intervals.
		/// </summary>
		public sealed class AMPERAGE_ACValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "AMPERAGE_AC";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.6";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// electrical current that reverses direction at regular short intervals.";
		}
		private AMPERAGE_DCValue _AMPERAGE_DC;
		/// <summary>
		/// electric current flowing in one direction only.
		/// </summary>
		public AMPERAGE_DCValue AMPERAGE_DC => _AMPERAGE_DC ?? (_AMPERAGE_DC = new AMPERAGE_DCValue());

		/// <summary>
		/// electric current flowing in one direction only.
		/// </summary>
		public sealed class AMPERAGE_DCValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "AMPERAGE_DC";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.6";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// electric current flowing in one direction only.";
		}
		private VOLTAGE_ACValue _VOLTAGE_AC;
		/// <summary>
		/// electrical potential between two points in an electrical circuit in which the current periodically reverses direction.
		/// </summary>
		public VOLTAGE_ACValue VOLTAGE_AC => _VOLTAGE_AC ?? (_VOLTAGE_AC = new VOLTAGE_ACValue());

		/// <summary>
		/// electrical potential between two points in an electrical circuit in which the current periodically reverses direction.
		/// </summary>
		public sealed class VOLTAGE_ACValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "VOLTAGE_AC";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.6";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// electrical potential between two points in an electrical circuit in which the current periodically reverses direction.";
		}
		private VOLTAGE_DCValue _VOLTAGE_DC;
		/// <summary>
		/// electrical potential between two points in an electrical circuit in which the current is unidirectional.
		/// </summary>
		public VOLTAGE_DCValue VOLTAGE_DC => _VOLTAGE_DC ?? (_VOLTAGE_DC = new VOLTAGE_DCValue());

		/// <summary>
		/// electrical potential between two points in an electrical circuit in which the current is unidirectional.
		/// </summary>
		public sealed class VOLTAGE_DCValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "VOLTAGE_DC";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.6";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// electrical potential between two points in an electrical circuit in which the current is unidirectional.";
		}
		private X_DIMENSIONValue _X_DIMENSION;
		/// <summary>
		/// dimension of an entity relative to the X direction of the referenced coordinate system. 
		/// </summary>
		public X_DIMENSIONValue X_DIMENSION => _X_DIMENSION ?? (_X_DIMENSION = new X_DIMENSIONValue());

		/// <summary>
		/// dimension of an entity relative to the X direction of the referenced coordinate system. 
		/// </summary>
		public sealed class X_DIMENSIONValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "X_DIMENSION";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.6";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// dimension of an entity relative to the X direction of the referenced coordinate system. ";
		}
		private Y_DIMENSIONValue _Y_DIMENSION;
		/// <summary>
		/// dimension of an entity relative to the Y direction of the referenced coordinate system.
		/// </summary>
		public Y_DIMENSIONValue Y_DIMENSION => _Y_DIMENSION ?? (_Y_DIMENSION = new Y_DIMENSIONValue());

		/// <summary>
		/// dimension of an entity relative to the Y direction of the referenced coordinate system.
		/// </summary>
		public sealed class Y_DIMENSIONValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "Y_DIMENSION";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.6";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// dimension of an entity relative to the Y direction of the referenced coordinate system.";
		}
		private Z_DIMENSIONValue _Z_DIMENSION;
		/// <summary>
		/// dimension of an entity relative to the Z direction of the referenced coordinate system.
		/// </summary>
		public Z_DIMENSIONValue Z_DIMENSION => _Z_DIMENSION ?? (_Z_DIMENSION = new Z_DIMENSIONValue());

		/// <summary>
		/// dimension of an entity relative to the Z direction of the referenced coordinate system.
		/// </summary>
		public sealed class Z_DIMENSIONValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "Z_DIMENSION";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.6";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// dimension of an entity relative to the Z direction of the referenced coordinate system.";
		}
		private DIAMETERValue _DIAMETER;
		/// <summary>
		/// dimension of a diameter.
		/// </summary>
		public DIAMETERValue DIAMETER => _DIAMETER ?? (_DIAMETER = new DIAMETERValue());

		/// <summary>
		/// dimension of a diameter.
		/// </summary>
		public sealed class DIAMETERValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "DIAMETER";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.6";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// dimension of a diameter.";
		}
		private ORIENTATIONValue _ORIENTATION;
		/// <summary>
		/// angular position of a plane or vector relative to a <i>cartesian coordinate system</i>
		/// </summary>
		public ORIENTATIONValue ORIENTATION => _ORIENTATION ?? (_ORIENTATION = new ORIENTATIONValue());

		/// <summary>
		/// angular position of a plane or vector relative to a <i>cartesian coordinate system</i>
		/// </summary>
		public sealed class ORIENTATIONValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "ORIENTATION";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.6";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// angular position of a plane or vector relative to a <i>cartesian coordinate system</i>";
		}
		private HUMIDITY_RELATIVEValue _HUMIDITY_RELATIVE;
		/// <summary>
		/// amount of water vapor present expressed as a percent to reach saturation at the same temperature.
		/// </summary>
		public HUMIDITY_RELATIVEValue HUMIDITY_RELATIVE => _HUMIDITY_RELATIVE ?? (_HUMIDITY_RELATIVE = new HUMIDITY_RELATIVEValue());

		/// <summary>
		/// amount of water vapor present expressed as a percent to reach saturation at the same temperature.
		/// </summary>
		public sealed class HUMIDITY_RELATIVEValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "HUMIDITY_RELATIVE";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.6";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// amount of water vapor present expressed as a percent to reach saturation at the same temperature.";
		}
		private HUMIDITY_ABSOLUTEValue _HUMIDITY_ABSOLUTE;
		/// <summary>
		/// amount of water vapor expressed in grams per cubic meter.
		/// </summary>
		public HUMIDITY_ABSOLUTEValue HUMIDITY_ABSOLUTE => _HUMIDITY_ABSOLUTE ?? (_HUMIDITY_ABSOLUTE = new HUMIDITY_ABSOLUTEValue());

		/// <summary>
		/// amount of water vapor expressed in grams per cubic meter.
		/// </summary>
		public sealed class HUMIDITY_ABSOLUTEValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "HUMIDITY_ABSOLUTE";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.6";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// amount of water vapor expressed in grams per cubic meter.";
		}
		private HUMIDITY_SPECIFICValue _HUMIDITY_SPECIFIC;
		/// <summary>
		/// ratio of the water vapor present over the total weight of the water vapor and air present expressed as a percent.
		/// </summary>
		public HUMIDITY_SPECIFICValue HUMIDITY_SPECIFIC => _HUMIDITY_SPECIFIC ?? (_HUMIDITY_SPECIFIC = new HUMIDITY_SPECIFICValue());

		/// <summary>
		/// ratio of the water vapor present over the total weight of the water vapor and air present expressed as a percent.
		/// </summary>
		public sealed class HUMIDITY_SPECIFICValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "HUMIDITY_SPECIFIC";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.6";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// ratio of the water vapor present over the total weight of the water vapor and air present expressed as a percent.";
		}
		private OBSERVATION_UPDATE_RATEValue _OBSERVATION_UPDATE_RATE;
		/// <summary>
		/// average rate of change of values for data items in the MTConnect streams. The average is computed over a rolling window defined by the implementation.
		/// </summary>
		public OBSERVATION_UPDATE_RATEValue OBSERVATION_UPDATE_RATE => _OBSERVATION_UPDATE_RATE ?? (_OBSERVATION_UPDATE_RATE = new OBSERVATION_UPDATE_RATEValue());

		/// <summary>
		/// average rate of change of values for data items in the MTConnect streams. The average is computed over a rolling window defined by the implementation.
		/// </summary>
		public sealed class OBSERVATION_UPDATE_RATEValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "OBSERVATION_UPDATE_RATE";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.7";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// average rate of change of values for data items in the MTConnect streams. The average is computed over a rolling window defined by the implementation.";
		}
		private ASSET_UPDATE_RATEValue _ASSET_UPDATE_RATE;
		/// <summary>
		/// average rate of change of values for assets in the MTConnect streams.   The average is computed over a rolling window defined by the implementation.
		/// </summary>
		public ASSET_UPDATE_RATEValue ASSET_UPDATE_RATE => _ASSET_UPDATE_RATE ?? (_ASSET_UPDATE_RATE = new ASSET_UPDATE_RATEValue());

		/// <summary>
		/// average rate of change of values for assets in the MTConnect streams.   The average is computed over a rolling window defined by the implementation.
		/// </summary>
		public sealed class ASSET_UPDATE_RATEValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "ASSET_UPDATE_RATE";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.7";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// average rate of change of values for assets in the MTConnect streams.   The average is computed over a rolling window defined by the implementation.";
		}
		private PRESSURIZATION_RATEValue _PRESSURIZATION_RATE;
		/// <summary>
		/// change of pressure per unit time.
		/// </summary>
		public PRESSURIZATION_RATEValue PRESSURIZATION_RATE => _PRESSURIZATION_RATE ?? (_PRESSURIZATION_RATE = new PRESSURIZATION_RATEValue());

		/// <summary>
		/// change of pressure per unit time.
		/// </summary>
		public sealed class PRESSURIZATION_RATEValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "PRESSURIZATION_RATE";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.7";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// change of pressure per unit time.";
		}
		private DECELERATIONValue _DECELERATION;
		/// <summary>
		/// negative rate of change of velocity.
		/// </summary>
		public DECELERATIONValue DECELERATION => _DECELERATION ?? (_DECELERATION = new DECELERATIONValue());

		/// <summary>
		/// negative rate of change of velocity.
		/// </summary>
		public sealed class DECELERATIONValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "DECELERATION";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.7";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// negative rate of change of velocity.";
		}
		private ANGULAR_DECELERATIONValue _ANGULAR_DECELERATION;
		/// <summary>
		/// negative rate of change of angular velocity.
		/// </summary>
		public ANGULAR_DECELERATIONValue ANGULAR_DECELERATION => _ANGULAR_DECELERATION ?? (_ANGULAR_DECELERATION = new ANGULAR_DECELERATIONValue());

		/// <summary>
		/// negative rate of change of angular velocity.
		/// </summary>
		public sealed class ANGULAR_DECELERATIONValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "ANGULAR_DECELERATION";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.7";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// negative rate of change of angular velocity.";
		}
		private PRESSURE_ABSOLUTEValue _PRESSURE_ABSOLUTE;
		/// <summary>
		/// force per unit area measured relative to a vacuum.
		/// </summary>
		public PRESSURE_ABSOLUTEValue PRESSURE_ABSOLUTE => _PRESSURE_ABSOLUTE ?? (_PRESSURE_ABSOLUTE = new PRESSURE_ABSOLUTEValue());

		/// <summary>
		/// force per unit area measured relative to a vacuum.
		/// </summary>
		public sealed class PRESSURE_ABSOLUTEValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "PRESSURE_ABSOLUTE";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.7";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// force per unit area measured relative to a vacuum.";
		}
		private OPENNESSValue _OPENNESS;
		/// <summary>
		/// percentage open where 100% is fully open and 0% is fully closed.
		/// </summary>
		public OPENNESSValue OPENNESS => _OPENNESS ?? (_OPENNESS = new OPENNESSValue());

		/// <summary>
		/// percentage open where 100% is fully open and 0% is fully closed.
		/// </summary>
		public sealed class OPENNESSValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "OPENNESS";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "2.0";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// percentage open where 100% is fully open and 0% is fully closed.";
		}
		private DEW_POINTValue _DEW_POINT;
		/// <summary>
		/// temperature at which moisture begins to condense, corresponding to saturation for a given absolute humidity.
		/// </summary>
		public DEW_POINTValue DEW_POINT => _DEW_POINT ?? (_DEW_POINT = new DEW_POINTValue());

		/// <summary>
		/// temperature at which moisture begins to condense, corresponding to saturation for a given absolute humidity.
		/// </summary>
		public sealed class DEW_POINTValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "DEW_POINT";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "2.1";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// temperature at which moisture begins to condense, corresponding to saturation for a given absolute humidity.";
		}
		private GRAVITATIONAL_FORCEValue _GRAVITATIONAL_FORCE;
		/// <summary>
		/// force relative to earth's gravity.
		/// </summary>
		public GRAVITATIONAL_FORCEValue GRAVITATIONAL_FORCE => _GRAVITATIONAL_FORCE ?? (_GRAVITATIONAL_FORCE = new GRAVITATIONAL_FORCEValue());

		/// <summary>
		/// force relative to earth's gravity.
		/// </summary>
		public sealed class GRAVITATIONAL_FORCEValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "GRAVITATIONAL_FORCE";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "2.1";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// force relative to earth's gravity.";
		}
		private GRAVITATIONAL_ACCELERATIONValue _GRAVITATIONAL_ACCELERATION;
		/// <summary>
		/// acceleration relative to Earth's gravity of 9.80665 <c>METER/SECOND^2</c>.
		/// </summary>
		public GRAVITATIONAL_ACCELERATIONValue GRAVITATIONAL_ACCELERATION => _GRAVITATIONAL_ACCELERATION ?? (_GRAVITATIONAL_ACCELERATION = new GRAVITATIONAL_ACCELERATIONValue());

		/// <summary>
		/// acceleration relative to Earth's gravity of 9.80665 <c>METER/SECOND^2</c>.
		/// </summary>
		public sealed class GRAVITATIONAL_ACCELERATIONValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "GRAVITATIONAL_ACCELERATION";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "2.1";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// acceleration relative to Earth's gravity of 9.80665 <c>METER/SECOND^2</c>.";
		}
		private BATTERY_CAPACITYValue _BATTERY_CAPACITY;
		/// <summary>
		/// maximum rated charge a battery is capable of maintaining based on the battery discharging at a specified current over a specified time period.
		/// </summary>
		public BATTERY_CAPACITYValue BATTERY_CAPACITY => _BATTERY_CAPACITY ?? (_BATTERY_CAPACITY = new BATTERY_CAPACITYValue());

		/// <summary>
		/// maximum rated charge a battery is capable of maintaining based on the battery discharging at a specified current over a specified time period.
		/// </summary>
		public sealed class BATTERY_CAPACITYValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "BATTERY_CAPACITY";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "2.1";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// maximum rated charge a battery is capable of maintaining based on the battery discharging at a specified current over a specified time period.";
		}
		private DISCHARGE_RATEValue _DISCHARGE_RATE;
		/// <summary>
		/// value of current being drawn from the <see cref="Component">Component</see>.
		/// </summary>
		public DISCHARGE_RATEValue DISCHARGE_RATE => _DISCHARGE_RATE ?? (_DISCHARGE_RATE = new DISCHARGE_RATEValue());

		/// <summary>
		/// value of current being drawn from the <see cref="Component">Component</see>.
		/// </summary>
		public sealed class DISCHARGE_RATEValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "DISCHARGE_RATE";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "2.1";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// value of current being drawn from the <see cref=""Component"">Component</see>.";
		}
		private CHARGE_RATEValue _CHARGE_RATE;
		/// <summary>
		/// value of the current being supplied to the <see cref="Component">Component</see> for the purpose of charging.
		/// </summary>
		public CHARGE_RATEValue CHARGE_RATE => _CHARGE_RATE ?? (_CHARGE_RATE = new CHARGE_RATEValue());

		/// <summary>
		/// value of the current being supplied to the <see cref="Component">Component</see> for the purpose of charging.
		/// </summary>
		public sealed class CHARGE_RATEValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "CHARGE_RATE";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "2.1";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// value of the current being supplied to the <see cref=""Component"">Component</see> for the purpose of charging.";
		}
		private BATTERY_CHARGEValue _BATTERY_CHARGE;
		/// <summary>
		/// value of the battery's present capacity expressed as a percentage of the battery's maximum rated capacity.
		/// </summary>
		public BATTERY_CHARGEValue BATTERY_CHARGE => _BATTERY_CHARGE ?? (_BATTERY_CHARGE = new BATTERY_CHARGEValue());

		/// <summary>
		/// value of the battery's present capacity expressed as a percentage of the battery's maximum rated capacity.
		/// </summary>
		public sealed class BATTERY_CHARGEValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "BATTERY_CHARGE";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "2.1";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// value of the battery's present capacity expressed as a percentage of the battery's maximum rated capacity.";
		}
		private SETTLING_ERRORValue _SETTLING_ERROR;
		/// <summary>
		/// difference between actual and commanded position at the end of a motion.
		/// </summary>
		public SETTLING_ERRORValue SETTLING_ERROR => _SETTLING_ERROR ?? (_SETTLING_ERROR = new SETTLING_ERRORValue());

		/// <summary>
		/// difference between actual and commanded position at the end of a motion.
		/// </summary>
		public sealed class SETTLING_ERRORValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "SETTLING_ERROR";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "2.1";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// difference between actual and commanded position at the end of a motion.";
		}
		private FOLLOWING_ERRORValue _FOLLOWING_ERROR;
		/// <summary>
		/// difference between actual and commanded position at any specific point in time during a motion.
		/// </summary>
		public FOLLOWING_ERRORValue FOLLOWING_ERROR => _FOLLOWING_ERROR ?? (_FOLLOWING_ERROR = new FOLLOWING_ERRORValue());

		/// <summary>
		/// difference between actual and commanded position at any specific point in time during a motion.
		/// </summary>
		public sealed class FOLLOWING_ERRORValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "FOLLOWING_ERROR";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "2.1";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// difference between actual and commanded position at any specific point in time during a motion.";
		}
		private SETTLING_ERROR_LINEARValue _SETTLING_ERROR_LINEAR;
		/// <summary>
		/// difference between the commanded encoder/resolver position, and the actual encoder/resolver position when motion is complete.
		/// </summary>
		public SETTLING_ERROR_LINEARValue SETTLING_ERROR_LINEAR => _SETTLING_ERROR_LINEAR ?? (_SETTLING_ERROR_LINEAR = new SETTLING_ERROR_LINEARValue());

		/// <summary>
		/// difference between the commanded encoder/resolver position, and the actual encoder/resolver position when motion is complete.
		/// </summary>
		public sealed class SETTLING_ERROR_LINEARValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "SETTLING_ERROR_LINEAR";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "2.1";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// difference between the commanded encoder/resolver position, and the actual encoder/resolver position when motion is complete.";
		}
		private SETTLING_ERROR_ANGULARValue _SETTLING_ERROR_ANGULAR;
		/// <summary>
		/// angular difference between the commanded encoder/resolver position, and the actual encoder/resolver position when motion is complete.
		/// </summary>
		public SETTLING_ERROR_ANGULARValue SETTLING_ERROR_ANGULAR => _SETTLING_ERROR_ANGULAR ?? (_SETTLING_ERROR_ANGULAR = new SETTLING_ERROR_ANGULARValue());

		/// <summary>
		/// angular difference between the commanded encoder/resolver position, and the actual encoder/resolver position when motion is complete.
		/// </summary>
		public sealed class SETTLING_ERROR_ANGULARValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "SETTLING_ERROR_ANGULAR";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "2.1";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// angular difference between the commanded encoder/resolver position, and the actual encoder/resolver position when motion is complete.";
		}
		private FOLLOWING_ERROR_LINEARValue _FOLLOWING_ERROR_LINEAR;
		/// <summary>
		/// difference between the commanded encoder/resolver position and the actual encoder/resolver position at any specified point in time during a motion.
		/// </summary>
		public FOLLOWING_ERROR_LINEARValue FOLLOWING_ERROR_LINEAR => _FOLLOWING_ERROR_LINEAR ?? (_FOLLOWING_ERROR_LINEAR = new FOLLOWING_ERROR_LINEARValue());

		/// <summary>
		/// difference between the commanded encoder/resolver position and the actual encoder/resolver position at any specified point in time during a motion.
		/// </summary>
		public sealed class FOLLOWING_ERROR_LINEARValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "FOLLOWING_ERROR_LINEAR";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "2.1";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// difference between the commanded encoder/resolver position and the actual encoder/resolver position at any specified point in time during a motion.";
		}
		private FOLLOWING_ERROR_ANGULARValue _FOLLOWING_ERROR_ANGULAR;
		/// <summary>
		/// angular difference between the commanded encoder/resolver position and the actual encoder/resolver position at any specified point in time during a motion.
		/// </summary>
		public FOLLOWING_ERROR_ANGULARValue FOLLOWING_ERROR_ANGULAR => _FOLLOWING_ERROR_ANGULAR ?? (_FOLLOWING_ERROR_ANGULAR = new FOLLOWING_ERROR_ANGULARValue());

		/// <summary>
		/// angular difference between the commanded encoder/resolver position and the actual encoder/resolver position at any specified point in time during a motion.
		/// </summary>
		public sealed class FOLLOWING_ERROR_ANGULARValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "FOLLOWING_ERROR_ANGULAR";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "2.1";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// angular difference between the commanded encoder/resolver position and the actual encoder/resolver position at any specified point in time during a motion.";
		}
		private DISPLACEMENT_LINEARValue _DISPLACEMENT_LINEAR;
		/// <summary>
		/// absolute value of the change in position along a vector.
		/// </summary>
		public DISPLACEMENT_LINEARValue DISPLACEMENT_LINEAR => _DISPLACEMENT_LINEAR ?? (_DISPLACEMENT_LINEAR = new DISPLACEMENT_LINEARValue());

		/// <summary>
		/// absolute value of the change in position along a vector.
		/// </summary>
		public sealed class DISPLACEMENT_LINEARValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "DISPLACEMENT_LINEAR";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "2.1";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// absolute value of the change in position along a vector.";
		}
		private DISPLACEMENT_ANGULARValue _DISPLACEMENT_ANGULAR;
		/// <summary>
		/// absolute value of the change in angular position around a vector
		/// </summary>
		public DISPLACEMENT_ANGULARValue DISPLACEMENT_ANGULAR => _DISPLACEMENT_ANGULAR ?? (_DISPLACEMENT_ANGULAR = new DISPLACEMENT_ANGULARValue());

		/// <summary>
		/// absolute value of the change in angular position around a vector
		/// </summary>
		public sealed class DISPLACEMENT_ANGULARValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "DISPLACEMENT_ANGULAR";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "2.1";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// absolute value of the change in angular position around a vector";
		}
		private POSITION_CARTESIANValue _POSITION_CARTESIAN;
		/// <summary>
		/// point in a <i>cartesian coordinate system</i>.
		/// </summary>
		public POSITION_CARTESIANValue POSITION_CARTESIAN => _POSITION_CARTESIAN ?? (_POSITION_CARTESIAN = new POSITION_CARTESIANValue());

		/// <summary>
		/// point in a <i>cartesian coordinate system</i>.
		/// </summary>
		public sealed class POSITION_CARTESIANValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "POSITION_CARTESIAN";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "2.1";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// point in a <i>cartesian coordinate system</i>.";
		}
	}
}