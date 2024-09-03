#pragma warning disable CS1574 // XML comment has cref attribute that could not be resolved
#pragma warning disable CS1584 // XML comment has syntactically incorrect cref attribute
#pragma warning disable CS0618 // Type or member is obsolete
using System;
using System.CodeDom.Compiler;using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;

namespace Mtconnect.DataTypes
{
	/// <summary>﻿
	/// <br/> Visit <seealso href="https://model.mtconnect.org/#Enumeration___19_0_3_45f01b9_1580398370126_672808_12777">model.mtconnect.org</seealso> for more information.
	/// </summary>
	/// <remarks>
	/// <list type="bullet">
	/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
	/// </list>
	/// </remarks>

	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public enum SampleEnum
	{
		/// <summary>﻿positive rate of change of velocity.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		ACCELERATION,
		/// <summary>﻿accumulated time for an activity or event.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		ACCUMULATED_TIME,
		/// <summary>﻿strength of electrical current.<br /><br /><b>DEPRECATED</b> in <i>Version 1.6</i>. Replaced by <c>AMPERAGE_AC</c> and <c>AMPERAGE_DC</c>.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		AMPERAGE,
		/// <summary>﻿angular position.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		ANGLE,
		/// <summary>﻿positive rate of change of angular velocity.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		ANGULAR_ACCELERATION,
		/// <summary>﻿rate of change of angular position.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		ANGULAR_VELOCITY,
		/// <summary>﻿feedrate of a linear axis.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		AXIS_FEEDRATE,
		/// <summary>﻿fluid capacity of an object or container.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		CAPACITY_FLUID,
		/// <summary>﻿geometric capacity of an object or container.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		CAPACITY_SPATIAL,
		/// <summary>﻿percentage of one component within a mixture of components.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		CONCENTRATION,
		/// <summary>﻿ability of a material to conduct electricity.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		CONDUCTIVITY,
		/// <summary>﻿speed difference (relative velocity) between the cutting mechanism and the surface of the workpiece it is operating on.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		CUTTING_SPEED,
		/// <summary>﻿volumetric mass of a material per unit volume of that material.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		DENSITY,
		/// <summary>﻿rate of change in spatial volume of material deposited in an additive manufacturing process.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		DEPOSITION_ACCELERATION_VOLUMETRIC,
		/// <summary>﻿density of the material deposited in an additive manufacturing process per unit of volume.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		DEPOSITION_DENSITY,
		/// <summary>﻿mass of the material deposited in an additive manufacturing process.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		DEPOSITION_MASS,
		/// <summary>﻿rate at which a spatial volume of material is deposited in an additive manufacturing process.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		DEPOSITION_RATE_VOLUMETRIC,
		/// <summary>﻿spatial volume of material to be deposited in an additive manufacturing process.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		DEPOSITION_VOLUME,
		/// <summary>﻿change in position of an object.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		DISPLACEMENT,
		/// <summary>﻿<see cref="Wattage">Wattage</see> used or generated by a component over an interval of time.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		ELECTRICAL_ENERGY,
		/// <summary>﻿amount of time a piece of equipment or a sub-part of a piece of equipment has performed specific activities.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		EQUIPMENT_TIMER,
		/// <summary>﻿amount of a substance remaining compared to the planned maximum amount of that substance.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		FILL_LEVEL,
		/// <summary>﻿rate of flow of a fluid.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		FLOW,
		/// <summary>﻿number of occurrences of a repeating event per unit time.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		FREQUENCY,
		/// <summary>﻿position in three-dimensional space.<br /><br /><b>DEPRECATED</b> in Version 1.1.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		GLOBAL_POSITION,
		/// <summary>﻿length of an object.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		LENGTH,
		/// <summary>﻿level of a resource.<br /><br /><b>DEPRECATED</b> in <i>Version 1.2</i>.  See <c>FILL_LEVEL</c>.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		LEVEL,
		/// <summary>﻿<i>force</i> applied to a mass in one direction only.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		LINEAR_FORCE,
		/// <summary>﻿actual versus the standard rating of a piece of equipment.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		LOAD,
		/// <summary>﻿mass of an object(s) or an amount of material.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		MASS,
		/// <summary>﻿feedrate for the axes, or a single axis, associated with a <see cref="Path">Path</see> component.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		PATH_FEEDRATE,
		/// <summary>﻿feedrate for the axes, or a single axis.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		PATH_FEEDRATE_PER_REVOLUTION,
		/// <summary>﻿position of a control point associated with a <see cref="Controller">Controller</see> or a <see cref="Path">Path</see>.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		PATH_POSITION,
		/// <summary>﻿acidity or alkalinity of a solution.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		PH,
		/// <summary>﻿point along an axis in a <i>cartesian coordinate system</i>.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		POSITION,
		/// <summary>﻿ratio of real power flowing to a load to the apparent power in that AC circuit.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		POWER_FACTOR,
		/// <summary>﻿force per unit area measured relative to atmospheric pressure. <br /><br />Commonly referred to as gauge pressure.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		PRESSURE,
		/// <summary>﻿amount of time a piece of equipment has performed different types of activities associated with the process being performed at that piece of equipment.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		PROCESS_TIMER,
		/// <summary>﻿degree to which a substance opposes the passage of an electric current.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		RESISTANCE,
		/// <summary>﻿rotational speed of a rotary axis.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		ROTARY_VELOCITY,
		/// <summary>﻿sound level or sound pressure level relative to atmospheric pressure.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		SOUND_LEVEL,
		/// <summary>﻿rotational speed of the rotary axis.<br /><br /><b>DEPRECATED</b> in <i>Version 1.2</i>.  Replaced by <c>ROTARY_VELOCITY</c>.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		SPINDLE_SPEED,
		/// <summary>﻿amount of deformation per unit length of an object when a load is applied.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		STRAIN,
		/// <summary>﻿degree of hotness or coldness measured on a definite scale.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		TEMPERATURE,
		/// <summary>﻿force that stretches or elongates an object.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		TENSION,
		/// <summary>﻿angular displacement.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		TILT,
		/// <summary>﻿turning force exerted on an object or by an object.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		TORQUE,
		/// <summary>﻿rate of change of position of a <see cref="Component">Component</see>.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		VELOCITY,
		/// <summary>﻿fluid's resistance to flow.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		VISCOSITY,
		/// <summary>﻿electrical potential between two points.<br /><br /><b>DEPRECATED</b> in <i>Version 1.6</i>. Replaced by <c>VOLTAGE_AC</c> and <c>VOLTAGE_DC</c>.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		VOLTAGE,
		/// <summary>﻿apparent power in an electrical circuit, equal to the product of root-mean-square (RMS) voltage and RMS current (commonly referred to as VA).<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		VOLT_AMPERE,
		/// <summary>﻿reactive power in an AC electrical circuit (commonly referred to as VAR).<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		VOLT_AMPERE_REACTIVE,
		/// <summary>﻿fluid volume of an object or container.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		VOLUME_FLUID,
		/// <summary>﻿geometric volume of an object or container.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		VOLUME_SPATIAL,
		/// <summary>﻿power flowing through or dissipated by an electrical circuit or piece of equipment.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		WATTAGE,
		/// <summary>﻿electrical current that reverses direction at regular short intervals.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		AMPERAGE_AC,
		/// <summary>﻿electric current flowing in one direction only.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		AMPERAGE_DC,
		/// <summary>﻿electrical potential between two points in an electrical circuit in which the current periodically reverses direction.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		VOLTAGE_AC,
		/// <summary>﻿electrical potential between two points in an electrical circuit in which the current is unidirectional.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		VOLTAGE_DC,
		/// <summary>﻿dimension of an entity relative to the X direction of the referenced coordinate system.<br /><br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		X_DIMENSION,
		/// <summary>﻿dimension of an entity relative to the Y direction of the referenced coordinate system.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		Y_DIMENSION,
		/// <summary>﻿dimension of an entity relative to the Z direction of the referenced coordinate system.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		Z_DIMENSION,
		/// <summary>﻿dimension of a diameter.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		DIAMETER,
		/// <summary>﻿angular position of a plane or vector relative to a <i>cartesian coordinate system</i><br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		ORIENTATION,
		/// <summary>﻿amount of water vapor present expressed as a percent to reach saturation at the same temperature.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		HUMIDITY_RELATIVE,
		/// <summary>﻿amount of water vapor expressed in grams per cubic meter.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		HUMIDITY_ABSOLUTE,
		/// <summary>﻿ratio of the water vapor present over the total weight of the water vapor and air present expressed as a percent.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		HUMIDITY_SPECIFIC,
		/// <summary>﻿average rate of change of values for data items in the MTConnect streams. The average is computed over a rolling window defined by the implementation.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		OBSERVATION_UPDATE_RATE,
		/// <summary>﻿average rate of change of values for assets in the MTConnect streams. <br /><br />The average is computed over a rolling window defined by the implementation.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		ASSET_UPDATE_RATE,
		/// <summary>﻿change of pressure per unit time.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		PRESSURIZATION_RATE,
		/// <summary>﻿negative rate of change of velocity.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		DECELERATION,
		/// <summary>﻿negative rate of change of angular velocity.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		ANGULAR_DECELERATION,
		/// <summary>﻿force per unit area measured relative to a vacuum.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		PRESSURE_ABSOLUTE,
		/// <summary>﻿percentage open where 100% is fully open and 0% is fully closed.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		OPENNESS,
		/// <summary>﻿temperature at which moisture begins to condense, corresponding to saturation for a given absolute humidity.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		DEW_POINT,
		/// <summary>﻿force relative to earth's gravity.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		GRAVITATIONAL_FORCE,
		/// <summary>﻿acceleration relative to Earth's gravity of 9.80665 <c>METER/SECOND^2</c>.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		GRAVITATIONAL_ACCELERATION,
		/// <summary>﻿maximum rated charge a battery is capable of maintaining based on the battery discharging at a specified current over a specified time period.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		BATTERY_CAPACITY,
		/// <summary>﻿value of current being drawn from the <see cref="Component">Component</see>.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		DISCHARGE_RATE,
		/// <summary>﻿value of the current being supplied to the <see cref="Component">Component</see> for the purpose of charging.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		CHARGE_RATE,
		/// <summary>﻿value of the battery's present capacity expressed as a percentage of the battery's maximum rated capacity.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		BATTERY_CHARGE,
		/// <summary>﻿difference between actual and commanded position at the end of a motion.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		SETTLING_ERROR,
		/// <summary>﻿difference between actual and commanded position at any specific point in time during a motion.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		FOLLOWING_ERROR,
		/// <summary>﻿difference between the commanded encoder/resolver position, and the actual encoder/resolver position when motion is complete.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		SETTLING_ERROR_LINEAR,
		/// <summary>﻿angular difference between the commanded encoder/resolver position, and the actual encoder/resolver position when motion is complete.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		SETTLING_ERROR_ANGULAR,
		/// <summary>﻿difference between the commanded encoder/resolver position and the actual encoder/resolver position at any specified point in time during a motion.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		FOLLOWING_ERROR_LINEAR,
		/// <summary>﻿angular difference between the commanded encoder/resolver position and the actual encoder/resolver position at any specified point in time during a motion.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		FOLLOWING_ERROR_ANGULAR,
		/// <summary>﻿absolute value of the change in position along a vector.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		DISPLACEMENT_LINEAR,
		/// <summary>﻿absolute value of the change in angular position around a vector<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		DISPLACEMENT_ANGULAR,
		/// <summary>﻿point in a <i>cartesian coordinate system</i>.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		POSITION_CARTESIAN,
	}

	/// <summary>﻿
	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Enumeration___19_0_3_45f01b9_1580398370126_672808_12777">model.mtconnect.org</seealso> for more information.
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public sealed class SampleEnumMetaClass : IEnum
	{
		/// <summary>Constant value for <see cref="SampleEnumMetaClass.ReferenceId" /></summary>
		public const string REFERENCE_ID = "_19_0_3_45f01b9_1580398370126_672808_12777";
		/// <summary>Constant value for <see cref="SampleEnumMetaClass.HelpUrl" /></summary>
		public const string HELP_URL = "https://model.mtconnect.org/#Enumeration___19_0_3_45f01b9_1580398370126_672808_12777";
		/// <summary>Constant value for <see cref="SampleEnumMetaClass.Name" /></summary>
		public const string NAME = "SampleEnum";
		/// <summary>Constant value for <see cref="SampleEnumMetaClass.NormativeVersion" /></summary>
		public const string NORMATIVE_VERSION = "1.0";
		/// <summary>Constant value for <see cref="SampleEnumMetaClass.DeprecatedVersion" /></summary>
		public const string DEPRECATED_VERSION = "";
		/// <summary>Constant value for <see cref="SampleEnumMetaClass.Summary" /></summary>
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
		public Type Instance => typeof(SampleEnum);

		/// <inheritdoc />
		public string NormativeVersion => NORMATIVE_VERSION;
		
		/// <inheritdoc />
		public string DeprecatedVersion => DEPRECATED_VERSION;
		
		/// <inheritdoc />
		public string Summary => SUMMARY;
		
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
		/// <inheritdoc cref="ACCELERATIONValue" path="/summary" />
		public ACCELERATIONValue ACCELERATION => _ACCELERATION ?? (_ACCELERATION = new ACCELERATIONValue());

		/// <summary>﻿positive rate of change of velocity.<br /><br /><br />
		/// Value for SampleEnum.<br/>
		/// <br/>See also <seealso cref="SampleEnum">SampleEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		public sealed class ACCELERATIONValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="ACCELERATIONValue.Name" /></summary>
			public const string NAME = "ACCELERATION";
			/// <summary>Constant value for <see cref="ACCELERATIONValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.0";
			/// <summary>Constant value for <see cref="ACCELERATIONValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="ACCELERATIONValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;positive rate of change of velocity.&#10;
";

			/// <inheritdoc />
			public string Name => NAME;
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => NORMATIVE_VERSION;
			
			/// <inheritdoc />
			public string DeprecatedVersion => DEPRECATED_VERSION;
			
			/// <inheritdoc />
			public string Summary => SUMMARY;
		}
		private ACCUMULATED_TIMEValue _ACCUMULATED_TIME;
		/// <inheritdoc cref="ACCUMULATED_TIMEValue" path="/summary" />
		public ACCUMULATED_TIMEValue ACCUMULATED_TIME => _ACCUMULATED_TIME ?? (_ACCUMULATED_TIME = new ACCUMULATED_TIMEValue());

		/// <summary>﻿accumulated time for an activity or event.<br /><br /><br />
		/// Value for SampleEnum.<br/>
		/// <br/>See also <seealso cref="SampleEnum">SampleEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		public sealed class ACCUMULATED_TIMEValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="ACCUMULATED_TIMEValue.Name" /></summary>
			public const string NAME = "ACCUMULATED_TIME";
			/// <summary>Constant value for <see cref="ACCUMULATED_TIMEValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.2";
			/// <summary>Constant value for <see cref="ACCUMULATED_TIMEValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="ACCUMULATED_TIMEValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;accumulated time for an activity or event.&#10;
";

			/// <inheritdoc />
			public string Name => NAME;
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => NORMATIVE_VERSION;
			
			/// <inheritdoc />
			public string DeprecatedVersion => DEPRECATED_VERSION;
			
			/// <inheritdoc />
			public string Summary => SUMMARY;
		}
		private AMPERAGEValue _AMPERAGE;
		/// <inheritdoc cref="AMPERAGEValue" path="/summary" />
		public AMPERAGEValue AMPERAGE => _AMPERAGE ?? (_AMPERAGE = new AMPERAGEValue());

		/// <summary>﻿strength of electrical current.<br /><br /><b>DEPRECATED</b> in <i>Version 1.6</i>. Replaced by <c>AMPERAGE_AC</c> and <c>AMPERAGE_DC</c>.<br /><br /><br />
		/// Value for SampleEnum.<br/>
		/// <br/>See also <seealso cref="SampleEnum">SampleEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		public sealed class AMPERAGEValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="AMPERAGEValue.Name" /></summary>
			public const string NAME = "AMPERAGE";
			/// <summary>Constant value for <see cref="AMPERAGEValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.0";
			/// <summary>Constant value for <see cref="AMPERAGEValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "1.6";
			/// <summary>Constant value for <see cref="AMPERAGEValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;strength of electrical current.

**DEPRECATED** in *Version 1.6*. Replaced by `AMPERAGE_AC` and `AMPERAGE_DC`.&#10;
";

			/// <inheritdoc />
			public string Name => NAME;
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => NORMATIVE_VERSION;
			
			/// <inheritdoc />
			public string DeprecatedVersion => DEPRECATED_VERSION;
			
			/// <inheritdoc />
			public string Summary => SUMMARY;
		}
		private ANGLEValue _ANGLE;
		/// <inheritdoc cref="ANGLEValue" path="/summary" />
		public ANGLEValue ANGLE => _ANGLE ?? (_ANGLE = new ANGLEValue());

		/// <summary>﻿angular position.<br /><br /><br />
		/// Value for SampleEnum.<br/>
		/// <br/>See also <seealso cref="SampleEnum">SampleEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		public sealed class ANGLEValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="ANGLEValue.Name" /></summary>
			public const string NAME = "ANGLE";
			/// <summary>Constant value for <see cref="ANGLEValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.0";
			/// <summary>Constant value for <see cref="ANGLEValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="ANGLEValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;angular position.&#10;
";

			/// <inheritdoc />
			public string Name => NAME;
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => NORMATIVE_VERSION;
			
			/// <inheritdoc />
			public string DeprecatedVersion => DEPRECATED_VERSION;
			
			/// <inheritdoc />
			public string Summary => SUMMARY;
		}
		private ANGULAR_ACCELERATIONValue _ANGULAR_ACCELERATION;
		/// <inheritdoc cref="ANGULAR_ACCELERATIONValue" path="/summary" />
		public ANGULAR_ACCELERATIONValue ANGULAR_ACCELERATION => _ANGULAR_ACCELERATION ?? (_ANGULAR_ACCELERATION = new ANGULAR_ACCELERATIONValue());

		/// <summary>﻿positive rate of change of angular velocity.<br /><br /><br />
		/// Value for SampleEnum.<br/>
		/// <br/>See also <seealso cref="SampleEnum">SampleEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		public sealed class ANGULAR_ACCELERATIONValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="ANGULAR_ACCELERATIONValue.Name" /></summary>
			public const string NAME = "ANGULAR_ACCELERATION";
			/// <summary>Constant value for <see cref="ANGULAR_ACCELERATIONValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.0";
			/// <summary>Constant value for <see cref="ANGULAR_ACCELERATIONValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="ANGULAR_ACCELERATIONValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;positive rate of change of angular velocity.&#10;
";

			/// <inheritdoc />
			public string Name => NAME;
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => NORMATIVE_VERSION;
			
			/// <inheritdoc />
			public string DeprecatedVersion => DEPRECATED_VERSION;
			
			/// <inheritdoc />
			public string Summary => SUMMARY;
		}
		private ANGULAR_VELOCITYValue _ANGULAR_VELOCITY;
		/// <inheritdoc cref="ANGULAR_VELOCITYValue" path="/summary" />
		public ANGULAR_VELOCITYValue ANGULAR_VELOCITY => _ANGULAR_VELOCITY ?? (_ANGULAR_VELOCITY = new ANGULAR_VELOCITYValue());

		/// <summary>﻿rate of change of angular position.<br /><br /><br />
		/// Value for SampleEnum.<br/>
		/// <br/>See also <seealso cref="SampleEnum">SampleEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		public sealed class ANGULAR_VELOCITYValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="ANGULAR_VELOCITYValue.Name" /></summary>
			public const string NAME = "ANGULAR_VELOCITY";
			/// <summary>Constant value for <see cref="ANGULAR_VELOCITYValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.0";
			/// <summary>Constant value for <see cref="ANGULAR_VELOCITYValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="ANGULAR_VELOCITYValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;rate of change of angular position.&#10;
";

			/// <inheritdoc />
			public string Name => NAME;
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => NORMATIVE_VERSION;
			
			/// <inheritdoc />
			public string DeprecatedVersion => DEPRECATED_VERSION;
			
			/// <inheritdoc />
			public string Summary => SUMMARY;
		}
		private AXIS_FEEDRATEValue _AXIS_FEEDRATE;
		/// <inheritdoc cref="AXIS_FEEDRATEValue" path="/summary" />
		public AXIS_FEEDRATEValue AXIS_FEEDRATE => _AXIS_FEEDRATE ?? (_AXIS_FEEDRATE = new AXIS_FEEDRATEValue());

		/// <summary>﻿feedrate of a linear axis.<br /><br /><br />
		/// Value for SampleEnum.<br/>
		/// <br/>See also <seealso cref="SampleEnum">SampleEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		public sealed class AXIS_FEEDRATEValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="AXIS_FEEDRATEValue.Name" /></summary>
			public const string NAME = "AXIS_FEEDRATE";
			/// <summary>Constant value for <see cref="AXIS_FEEDRATEValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.0";
			/// <summary>Constant value for <see cref="AXIS_FEEDRATEValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="AXIS_FEEDRATEValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;feedrate of a linear axis.&#10;
";

			/// <inheritdoc />
			public string Name => NAME;
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => NORMATIVE_VERSION;
			
			/// <inheritdoc />
			public string DeprecatedVersion => DEPRECATED_VERSION;
			
			/// <inheritdoc />
			public string Summary => SUMMARY;
		}
		private CAPACITY_FLUIDValue _CAPACITY_FLUID;
		/// <inheritdoc cref="CAPACITY_FLUIDValue" path="/summary" />
		public CAPACITY_FLUIDValue CAPACITY_FLUID => _CAPACITY_FLUID ?? (_CAPACITY_FLUID = new CAPACITY_FLUIDValue());

		/// <summary>﻿fluid capacity of an object or container.<br /><br /><br />
		/// Value for SampleEnum.<br/>
		/// <br/>See also <seealso cref="SampleEnum">SampleEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		public sealed class CAPACITY_FLUIDValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="CAPACITY_FLUIDValue.Name" /></summary>
			public const string NAME = "CAPACITY_FLUID";
			/// <summary>Constant value for <see cref="CAPACITY_FLUIDValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.5";
			/// <summary>Constant value for <see cref="CAPACITY_FLUIDValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="CAPACITY_FLUIDValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;fluid capacity of an object or container.&#10;
";

			/// <inheritdoc />
			public string Name => NAME;
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => NORMATIVE_VERSION;
			
			/// <inheritdoc />
			public string DeprecatedVersion => DEPRECATED_VERSION;
			
			/// <inheritdoc />
			public string Summary => SUMMARY;
		}
		private CAPACITY_SPATIALValue _CAPACITY_SPATIAL;
		/// <inheritdoc cref="CAPACITY_SPATIALValue" path="/summary" />
		public CAPACITY_SPATIALValue CAPACITY_SPATIAL => _CAPACITY_SPATIAL ?? (_CAPACITY_SPATIAL = new CAPACITY_SPATIALValue());

		/// <summary>﻿geometric capacity of an object or container.<br /><br /><br />
		/// Value for SampleEnum.<br/>
		/// <br/>See also <seealso cref="SampleEnum">SampleEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		public sealed class CAPACITY_SPATIALValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="CAPACITY_SPATIALValue.Name" /></summary>
			public const string NAME = "CAPACITY_SPATIAL";
			/// <summary>Constant value for <see cref="CAPACITY_SPATIALValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.5";
			/// <summary>Constant value for <see cref="CAPACITY_SPATIALValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="CAPACITY_SPATIALValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;geometric capacity of an object or container.&#10;
";

			/// <inheritdoc />
			public string Name => NAME;
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => NORMATIVE_VERSION;
			
			/// <inheritdoc />
			public string DeprecatedVersion => DEPRECATED_VERSION;
			
			/// <inheritdoc />
			public string Summary => SUMMARY;
		}
		private CONCENTRATIONValue _CONCENTRATION;
		/// <inheritdoc cref="CONCENTRATIONValue" path="/summary" />
		public CONCENTRATIONValue CONCENTRATION => _CONCENTRATION ?? (_CONCENTRATION = new CONCENTRATIONValue());

		/// <summary>﻿percentage of one component within a mixture of components.<br /><br /><br />
		/// Value for SampleEnum.<br/>
		/// <br/>See also <seealso cref="SampleEnum">SampleEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		public sealed class CONCENTRATIONValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="CONCENTRATIONValue.Name" /></summary>
			public const string NAME = "CONCENTRATION";
			/// <summary>Constant value for <see cref="CONCENTRATIONValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.2";
			/// <summary>Constant value for <see cref="CONCENTRATIONValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="CONCENTRATIONValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;percentage of one component within a mixture of components.&#10;
";

			/// <inheritdoc />
			public string Name => NAME;
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => NORMATIVE_VERSION;
			
			/// <inheritdoc />
			public string DeprecatedVersion => DEPRECATED_VERSION;
			
			/// <inheritdoc />
			public string Summary => SUMMARY;
		}
		private CONDUCTIVITYValue _CONDUCTIVITY;
		/// <inheritdoc cref="CONDUCTIVITYValue" path="/summary" />
		public CONDUCTIVITYValue CONDUCTIVITY => _CONDUCTIVITY ?? (_CONDUCTIVITY = new CONDUCTIVITYValue());

		/// <summary>﻿ability of a material to conduct electricity.<br /><br /><br />
		/// Value for SampleEnum.<br/>
		/// <br/>See also <seealso cref="SampleEnum">SampleEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		public sealed class CONDUCTIVITYValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="CONDUCTIVITYValue.Name" /></summary>
			public const string NAME = "CONDUCTIVITY";
			/// <summary>Constant value for <see cref="CONDUCTIVITYValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.2";
			/// <summary>Constant value for <see cref="CONDUCTIVITYValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="CONDUCTIVITYValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;ability of a material to conduct electricity.&#10;
";

			/// <inheritdoc />
			public string Name => NAME;
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => NORMATIVE_VERSION;
			
			/// <inheritdoc />
			public string DeprecatedVersion => DEPRECATED_VERSION;
			
			/// <inheritdoc />
			public string Summary => SUMMARY;
		}
		private CUTTING_SPEEDValue _CUTTING_SPEED;
		/// <inheritdoc cref="CUTTING_SPEEDValue" path="/summary" />
		public CUTTING_SPEEDValue CUTTING_SPEED => _CUTTING_SPEED ?? (_CUTTING_SPEED = new CUTTING_SPEEDValue());

		/// <summary>﻿speed difference (relative velocity) between the cutting mechanism and the surface of the workpiece it is operating on.<br /><br /><br />
		/// Value for SampleEnum.<br/>
		/// <br/>See also <seealso cref="SampleEnum">SampleEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		public sealed class CUTTING_SPEEDValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="CUTTING_SPEEDValue.Name" /></summary>
			public const string NAME = "CUTTING_SPEED";
			/// <summary>Constant value for <see cref="CUTTING_SPEEDValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.5";
			/// <summary>Constant value for <see cref="CUTTING_SPEEDValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="CUTTING_SPEEDValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;speed difference (relative velocity) between the cutting mechanism and the surface of the workpiece it is operating on.&#10;
";

			/// <inheritdoc />
			public string Name => NAME;
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => NORMATIVE_VERSION;
			
			/// <inheritdoc />
			public string DeprecatedVersion => DEPRECATED_VERSION;
			
			/// <inheritdoc />
			public string Summary => SUMMARY;
		}
		private DENSITYValue _DENSITY;
		/// <inheritdoc cref="DENSITYValue" path="/summary" />
		public DENSITYValue DENSITY => _DENSITY ?? (_DENSITY = new DENSITYValue());

		/// <summary>﻿volumetric mass of a material per unit volume of that material.<br /><br /><br />
		/// Value for SampleEnum.<br/>
		/// <br/>See also <seealso cref="SampleEnum">SampleEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		public sealed class DENSITYValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="DENSITYValue.Name" /></summary>
			public const string NAME = "DENSITY";
			/// <summary>Constant value for <see cref="DENSITYValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.5";
			/// <summary>Constant value for <see cref="DENSITYValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="DENSITYValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;volumetric mass of a material per unit volume of that material.&#10;
";

			/// <inheritdoc />
			public string Name => NAME;
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => NORMATIVE_VERSION;
			
			/// <inheritdoc />
			public string DeprecatedVersion => DEPRECATED_VERSION;
			
			/// <inheritdoc />
			public string Summary => SUMMARY;
		}
		private DEPOSITION_ACCELERATION_VOLUMETRICValue _DEPOSITION_ACCELERATION_VOLUMETRIC;
		/// <inheritdoc cref="DEPOSITION_ACCELERATION_VOLUMETRICValue" path="/summary" />
		public DEPOSITION_ACCELERATION_VOLUMETRICValue DEPOSITION_ACCELERATION_VOLUMETRIC => _DEPOSITION_ACCELERATION_VOLUMETRIC ?? (_DEPOSITION_ACCELERATION_VOLUMETRIC = new DEPOSITION_ACCELERATION_VOLUMETRICValue());

		/// <summary>﻿rate of change in spatial volume of material deposited in an additive manufacturing process.<br /><br /><br />
		/// Value for SampleEnum.<br/>
		/// <br/>See also <seealso cref="SampleEnum">SampleEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		public sealed class DEPOSITION_ACCELERATION_VOLUMETRICValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="DEPOSITION_ACCELERATION_VOLUMETRICValue.Name" /></summary>
			public const string NAME = "DEPOSITION_ACCELERATION_VOLUMETRIC";
			/// <summary>Constant value for <see cref="DEPOSITION_ACCELERATION_VOLUMETRICValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.5";
			/// <summary>Constant value for <see cref="DEPOSITION_ACCELERATION_VOLUMETRICValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="DEPOSITION_ACCELERATION_VOLUMETRICValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;rate of change in spatial volume of material deposited in an additive manufacturing process.&#10;
";

			/// <inheritdoc />
			public string Name => NAME;
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => NORMATIVE_VERSION;
			
			/// <inheritdoc />
			public string DeprecatedVersion => DEPRECATED_VERSION;
			
			/// <inheritdoc />
			public string Summary => SUMMARY;
		}
		private DEPOSITION_DENSITYValue _DEPOSITION_DENSITY;
		/// <inheritdoc cref="DEPOSITION_DENSITYValue" path="/summary" />
		public DEPOSITION_DENSITYValue DEPOSITION_DENSITY => _DEPOSITION_DENSITY ?? (_DEPOSITION_DENSITY = new DEPOSITION_DENSITYValue());

		/// <summary>﻿density of the material deposited in an additive manufacturing process per unit of volume.<br /><br /><br />
		/// Value for SampleEnum.<br/>
		/// <br/>See also <seealso cref="SampleEnum">SampleEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		public sealed class DEPOSITION_DENSITYValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="DEPOSITION_DENSITYValue.Name" /></summary>
			public const string NAME = "DEPOSITION_DENSITY";
			/// <summary>Constant value for <see cref="DEPOSITION_DENSITYValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.5";
			/// <summary>Constant value for <see cref="DEPOSITION_DENSITYValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="DEPOSITION_DENSITYValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;density of the material deposited in an additive manufacturing process per unit of volume.&#10;
";

			/// <inheritdoc />
			public string Name => NAME;
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => NORMATIVE_VERSION;
			
			/// <inheritdoc />
			public string DeprecatedVersion => DEPRECATED_VERSION;
			
			/// <inheritdoc />
			public string Summary => SUMMARY;
		}
		private DEPOSITION_MASSValue _DEPOSITION_MASS;
		/// <inheritdoc cref="DEPOSITION_MASSValue" path="/summary" />
		public DEPOSITION_MASSValue DEPOSITION_MASS => _DEPOSITION_MASS ?? (_DEPOSITION_MASS = new DEPOSITION_MASSValue());

		/// <summary>﻿mass of the material deposited in an additive manufacturing process.<br /><br /><br />
		/// Value for SampleEnum.<br/>
		/// <br/>See also <seealso cref="SampleEnum">SampleEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		public sealed class DEPOSITION_MASSValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="DEPOSITION_MASSValue.Name" /></summary>
			public const string NAME = "DEPOSITION_MASS";
			/// <summary>Constant value for <see cref="DEPOSITION_MASSValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.5";
			/// <summary>Constant value for <see cref="DEPOSITION_MASSValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="DEPOSITION_MASSValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;mass of the material deposited in an additive manufacturing process.&#10;
";

			/// <inheritdoc />
			public string Name => NAME;
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => NORMATIVE_VERSION;
			
			/// <inheritdoc />
			public string DeprecatedVersion => DEPRECATED_VERSION;
			
			/// <inheritdoc />
			public string Summary => SUMMARY;
		}
		private DEPOSITION_RATE_VOLUMETRICValue _DEPOSITION_RATE_VOLUMETRIC;
		/// <inheritdoc cref="DEPOSITION_RATE_VOLUMETRICValue" path="/summary" />
		public DEPOSITION_RATE_VOLUMETRICValue DEPOSITION_RATE_VOLUMETRIC => _DEPOSITION_RATE_VOLUMETRIC ?? (_DEPOSITION_RATE_VOLUMETRIC = new DEPOSITION_RATE_VOLUMETRICValue());

		/// <summary>﻿rate at which a spatial volume of material is deposited in an additive manufacturing process.<br /><br /><br />
		/// Value for SampleEnum.<br/>
		/// <br/>See also <seealso cref="SampleEnum">SampleEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		public sealed class DEPOSITION_RATE_VOLUMETRICValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="DEPOSITION_RATE_VOLUMETRICValue.Name" /></summary>
			public const string NAME = "DEPOSITION_RATE_VOLUMETRIC";
			/// <summary>Constant value for <see cref="DEPOSITION_RATE_VOLUMETRICValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.5";
			/// <summary>Constant value for <see cref="DEPOSITION_RATE_VOLUMETRICValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="DEPOSITION_RATE_VOLUMETRICValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;rate at which a spatial volume of material is deposited in an additive manufacturing process.&#10;
";

			/// <inheritdoc />
			public string Name => NAME;
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => NORMATIVE_VERSION;
			
			/// <inheritdoc />
			public string DeprecatedVersion => DEPRECATED_VERSION;
			
			/// <inheritdoc />
			public string Summary => SUMMARY;
		}
		private DEPOSITION_VOLUMEValue _DEPOSITION_VOLUME;
		/// <inheritdoc cref="DEPOSITION_VOLUMEValue" path="/summary" />
		public DEPOSITION_VOLUMEValue DEPOSITION_VOLUME => _DEPOSITION_VOLUME ?? (_DEPOSITION_VOLUME = new DEPOSITION_VOLUMEValue());

		/// <summary>﻿spatial volume of material to be deposited in an additive manufacturing process.<br /><br /><br />
		/// Value for SampleEnum.<br/>
		/// <br/>See also <seealso cref="SampleEnum">SampleEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		public sealed class DEPOSITION_VOLUMEValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="DEPOSITION_VOLUMEValue.Name" /></summary>
			public const string NAME = "DEPOSITION_VOLUME";
			/// <summary>Constant value for <see cref="DEPOSITION_VOLUMEValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.5";
			/// <summary>Constant value for <see cref="DEPOSITION_VOLUMEValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="DEPOSITION_VOLUMEValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;spatial volume of material to be deposited in an additive manufacturing process.&#10;
";

			/// <inheritdoc />
			public string Name => NAME;
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => NORMATIVE_VERSION;
			
			/// <inheritdoc />
			public string DeprecatedVersion => DEPRECATED_VERSION;
			
			/// <inheritdoc />
			public string Summary => SUMMARY;
		}
		private DISPLACEMENTValue _DISPLACEMENT;
		/// <inheritdoc cref="DISPLACEMENTValue" path="/summary" />
		public DISPLACEMENTValue DISPLACEMENT => _DISPLACEMENT ?? (_DISPLACEMENT = new DISPLACEMENTValue());

		/// <summary>﻿change in position of an object.<br /><br /><br />
		/// Value for SampleEnum.<br/>
		/// <br/>See also <seealso cref="SampleEnum">SampleEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		public sealed class DISPLACEMENTValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="DISPLACEMENTValue.Name" /></summary>
			public const string NAME = "DISPLACEMENT";
			/// <summary>Constant value for <see cref="DISPLACEMENTValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.0";
			/// <summary>Constant value for <see cref="DISPLACEMENTValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="DISPLACEMENTValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;change in position of an object.&#10;
";

			/// <inheritdoc />
			public string Name => NAME;
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => NORMATIVE_VERSION;
			
			/// <inheritdoc />
			public string DeprecatedVersion => DEPRECATED_VERSION;
			
			/// <inheritdoc />
			public string Summary => SUMMARY;
		}
		private ELECTRICAL_ENERGYValue _ELECTRICAL_ENERGY;
		/// <inheritdoc cref="ELECTRICAL_ENERGYValue" path="/summary" />
		public ELECTRICAL_ENERGYValue ELECTRICAL_ENERGY => _ELECTRICAL_ENERGY ?? (_ELECTRICAL_ENERGY = new ELECTRICAL_ENERGYValue());

		/// <summary>﻿<see cref="Wattage">Wattage</see> used or generated by a component over an interval of time.<br /><br /><br />
		/// Value for SampleEnum.<br/>
		/// <br/>See also <seealso cref="SampleEnum">SampleEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		public sealed class ELECTRICAL_ENERGYValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="ELECTRICAL_ENERGYValue.Name" /></summary>
			public const string NAME = "ELECTRICAL_ENERGY";
			/// <summary>Constant value for <see cref="ELECTRICAL_ENERGYValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.2";
			/// <summary>Constant value for <see cref="ELECTRICAL_ENERGYValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="ELECTRICAL_ENERGYValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;{{block(Wattage)}} used or generated by a component over an interval of time.&#10;
";

			/// <inheritdoc />
			public string Name => NAME;
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => NORMATIVE_VERSION;
			
			/// <inheritdoc />
			public string DeprecatedVersion => DEPRECATED_VERSION;
			
			/// <inheritdoc />
			public string Summary => SUMMARY;
		}
		private EQUIPMENT_TIMERValue _EQUIPMENT_TIMER;
		/// <inheritdoc cref="EQUIPMENT_TIMERValue" path="/summary" />
		public EQUIPMENT_TIMERValue EQUIPMENT_TIMER => _EQUIPMENT_TIMER ?? (_EQUIPMENT_TIMER = new EQUIPMENT_TIMERValue());

		/// <summary>﻿amount of time a piece of equipment or a sub-part of a piece of equipment has performed specific activities.<br /><br /><br />
		/// Value for SampleEnum.<br/>
		/// <br/>See also <seealso cref="SampleEnum">SampleEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		public sealed class EQUIPMENT_TIMERValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="EQUIPMENT_TIMERValue.Name" /></summary>
			public const string NAME = "EQUIPMENT_TIMER";
			/// <summary>Constant value for <see cref="EQUIPMENT_TIMERValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.4";
			/// <summary>Constant value for <see cref="EQUIPMENT_TIMERValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="EQUIPMENT_TIMERValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;amount of time a piece of equipment or a sub-part of a piece of equipment has performed specific activities.&#10;
";

			/// <inheritdoc />
			public string Name => NAME;
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => NORMATIVE_VERSION;
			
			/// <inheritdoc />
			public string DeprecatedVersion => DEPRECATED_VERSION;
			
			/// <inheritdoc />
			public string Summary => SUMMARY;
		}
		private FILL_LEVELValue _FILL_LEVEL;
		/// <inheritdoc cref="FILL_LEVELValue" path="/summary" />
		public FILL_LEVELValue FILL_LEVEL => _FILL_LEVEL ?? (_FILL_LEVEL = new FILL_LEVELValue());

		/// <summary>﻿amount of a substance remaining compared to the planned maximum amount of that substance.<br /><br /><br />
		/// Value for SampleEnum.<br/>
		/// <br/>See also <seealso cref="SampleEnum">SampleEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		public sealed class FILL_LEVELValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="FILL_LEVELValue.Name" /></summary>
			public const string NAME = "FILL_LEVEL";
			/// <summary>Constant value for <see cref="FILL_LEVELValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.2";
			/// <summary>Constant value for <see cref="FILL_LEVELValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="FILL_LEVELValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;amount of a substance remaining compared to the planned maximum amount of that substance.&#10;
";

			/// <inheritdoc />
			public string Name => NAME;
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => NORMATIVE_VERSION;
			
			/// <inheritdoc />
			public string DeprecatedVersion => DEPRECATED_VERSION;
			
			/// <inheritdoc />
			public string Summary => SUMMARY;
		}
		private FLOWValue _FLOW;
		/// <inheritdoc cref="FLOWValue" path="/summary" />
		public FLOWValue FLOW => _FLOW ?? (_FLOW = new FLOWValue());

		/// <summary>﻿rate of flow of a fluid.<br /><br /><br />
		/// Value for SampleEnum.<br/>
		/// <br/>See also <seealso cref="SampleEnum">SampleEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		public sealed class FLOWValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="FLOWValue.Name" /></summary>
			public const string NAME = "FLOW";
			/// <summary>Constant value for <see cref="FLOWValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.2";
			/// <summary>Constant value for <see cref="FLOWValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="FLOWValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;rate of flow of a fluid.&#10;
";

			/// <inheritdoc />
			public string Name => NAME;
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => NORMATIVE_VERSION;
			
			/// <inheritdoc />
			public string DeprecatedVersion => DEPRECATED_VERSION;
			
			/// <inheritdoc />
			public string Summary => SUMMARY;
		}
		private FREQUENCYValue _FREQUENCY;
		/// <inheritdoc cref="FREQUENCYValue" path="/summary" />
		public FREQUENCYValue FREQUENCY => _FREQUENCY ?? (_FREQUENCY = new FREQUENCYValue());

		/// <summary>﻿number of occurrences of a repeating event per unit time.<br /><br /><br />
		/// Value for SampleEnum.<br/>
		/// <br/>See also <seealso cref="SampleEnum">SampleEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		public sealed class FREQUENCYValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="FREQUENCYValue.Name" /></summary>
			public const string NAME = "FREQUENCY";
			/// <summary>Constant value for <see cref="FREQUENCYValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.0";
			/// <summary>Constant value for <see cref="FREQUENCYValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="FREQUENCYValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;number of occurrences of a repeating event per unit time.&#10;
";

			/// <inheritdoc />
			public string Name => NAME;
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => NORMATIVE_VERSION;
			
			/// <inheritdoc />
			public string DeprecatedVersion => DEPRECATED_VERSION;
			
			/// <inheritdoc />
			public string Summary => SUMMARY;
		}
		private GLOBAL_POSITIONValue _GLOBAL_POSITION;
		/// <inheritdoc cref="GLOBAL_POSITIONValue" path="/summary" />
		public GLOBAL_POSITIONValue GLOBAL_POSITION => _GLOBAL_POSITION ?? (_GLOBAL_POSITION = new GLOBAL_POSITIONValue());

		/// <summary>﻿position in three-dimensional space.<br /><br /><b>DEPRECATED</b> in Version 1.1.<br /><br /><br />
		/// Value for SampleEnum.<br/>
		/// <br/>See also <seealso cref="SampleEnum">SampleEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		public sealed class GLOBAL_POSITIONValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="GLOBAL_POSITIONValue.Name" /></summary>
			public const string NAME = "GLOBAL_POSITION";
			/// <summary>Constant value for <see cref="GLOBAL_POSITIONValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.0";
			/// <summary>Constant value for <see cref="GLOBAL_POSITIONValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "1.1";
			/// <summary>Constant value for <see cref="GLOBAL_POSITIONValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;position in three-dimensional space.

**DEPRECATED** in Version 1.1.&#10;
";

			/// <inheritdoc />
			public string Name => NAME;
			
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

		/// <summary>﻿length of an object.<br /><br /><br />
		/// Value for SampleEnum.<br/>
		/// <br/>See also <seealso cref="SampleEnum">SampleEnum</seealso>
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
			public const string NORMATIVE_VERSION = "1.3";
			/// <summary>Constant value for <see cref="LENGTHValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="LENGTHValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;length of an object.&#10;
";

			/// <inheritdoc />
			public string Name => NAME;
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => NORMATIVE_VERSION;
			
			/// <inheritdoc />
			public string DeprecatedVersion => DEPRECATED_VERSION;
			
			/// <inheritdoc />
			public string Summary => SUMMARY;
		}
		private LEVELValue _LEVEL;
		/// <inheritdoc cref="LEVELValue" path="/summary" />
		public LEVELValue LEVEL => _LEVEL ?? (_LEVEL = new LEVELValue());

		/// <summary>﻿level of a resource.<br /><br /><b>DEPRECATED</b> in <i>Version 1.2</i>.  See <c>FILL_LEVEL</c>.<br /><br /><br />
		/// Value for SampleEnum.<br/>
		/// <br/>See also <seealso cref="SampleEnum">SampleEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		public sealed class LEVELValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="LEVELValue.Name" /></summary>
			public const string NAME = "LEVEL";
			/// <summary>Constant value for <see cref="LEVELValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.1";
			/// <summary>Constant value for <see cref="LEVELValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "1.2";
			/// <summary>Constant value for <see cref="LEVELValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;level of a resource.

**DEPRECATED** in *Version 1.2*.  See `FILL_LEVEL`.&#10;
";

			/// <inheritdoc />
			public string Name => NAME;
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => NORMATIVE_VERSION;
			
			/// <inheritdoc />
			public string DeprecatedVersion => DEPRECATED_VERSION;
			
			/// <inheritdoc />
			public string Summary => SUMMARY;
		}
		private LINEAR_FORCEValue _LINEAR_FORCE;
		/// <inheritdoc cref="LINEAR_FORCEValue" path="/summary" />
		public LINEAR_FORCEValue LINEAR_FORCE => _LINEAR_FORCE ?? (_LINEAR_FORCE = new LINEAR_FORCEValue());

		/// <summary>﻿<i>force</i> applied to a mass in one direction only.<br /><br /><br />
		/// Value for SampleEnum.<br/>
		/// <br/>See also <seealso cref="SampleEnum">SampleEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		public sealed class LINEAR_FORCEValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="LINEAR_FORCEValue.Name" /></summary>
			public const string NAME = "LINEAR_FORCE";
			/// <summary>Constant value for <see cref="LINEAR_FORCEValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.2";
			/// <summary>Constant value for <see cref="LINEAR_FORCEValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="LINEAR_FORCEValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;{{term(force)}} applied to a mass in one direction only.&#10;
";

			/// <inheritdoc />
			public string Name => NAME;
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => NORMATIVE_VERSION;
			
			/// <inheritdoc />
			public string DeprecatedVersion => DEPRECATED_VERSION;
			
			/// <inheritdoc />
			public string Summary => SUMMARY;
		}
		private LOADValue _LOAD;
		/// <inheritdoc cref="LOADValue" path="/summary" />
		public LOADValue LOAD => _LOAD ?? (_LOAD = new LOADValue());

		/// <summary>﻿actual versus the standard rating of a piece of equipment.<br /><br /><br />
		/// Value for SampleEnum.<br/>
		/// <br/>See also <seealso cref="SampleEnum">SampleEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		public sealed class LOADValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="LOADValue.Name" /></summary>
			public const string NAME = "LOAD";
			/// <summary>Constant value for <see cref="LOADValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.0";
			/// <summary>Constant value for <see cref="LOADValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="LOADValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;actual versus the standard rating of a piece of equipment.&#10;
";

			/// <inheritdoc />
			public string Name => NAME;
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => NORMATIVE_VERSION;
			
			/// <inheritdoc />
			public string DeprecatedVersion => DEPRECATED_VERSION;
			
			/// <inheritdoc />
			public string Summary => SUMMARY;
		}
		private MASSValue _MASS;
		/// <inheritdoc cref="MASSValue" path="/summary" />
		public MASSValue MASS => _MASS ?? (_MASS = new MASSValue());

		/// <summary>﻿mass of an object(s) or an amount of material.<br /><br /><br />
		/// Value for SampleEnum.<br/>
		/// <br/>See also <seealso cref="SampleEnum">SampleEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		public sealed class MASSValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="MASSValue.Name" /></summary>
			public const string NAME = "MASS";
			/// <summary>Constant value for <see cref="MASSValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.2";
			/// <summary>Constant value for <see cref="MASSValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="MASSValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;mass of an object(s) or an amount of material.&#10;
";

			/// <inheritdoc />
			public string Name => NAME;
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => NORMATIVE_VERSION;
			
			/// <inheritdoc />
			public string DeprecatedVersion => DEPRECATED_VERSION;
			
			/// <inheritdoc />
			public string Summary => SUMMARY;
		}
		private PATH_FEEDRATEValue _PATH_FEEDRATE;
		/// <inheritdoc cref="PATH_FEEDRATEValue" path="/summary" />
		public PATH_FEEDRATEValue PATH_FEEDRATE => _PATH_FEEDRATE ?? (_PATH_FEEDRATE = new PATH_FEEDRATEValue());

		/// <summary>﻿feedrate for the axes, or a single axis, associated with a <see cref="Path">Path</see> component.<br /><br /><br />
		/// Value for SampleEnum.<br/>
		/// <br/>See also <seealso cref="SampleEnum">SampleEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		public sealed class PATH_FEEDRATEValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="PATH_FEEDRATEValue.Name" /></summary>
			public const string NAME = "PATH_FEEDRATE";
			/// <summary>Constant value for <see cref="PATH_FEEDRATEValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.0";
			/// <summary>Constant value for <see cref="PATH_FEEDRATEValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="PATH_FEEDRATEValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;feedrate for the axes, or a single axis, associated with a {{block(Path)}} component.&#10;
";

			/// <inheritdoc />
			public string Name => NAME;
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => NORMATIVE_VERSION;
			
			/// <inheritdoc />
			public string DeprecatedVersion => DEPRECATED_VERSION;
			
			/// <inheritdoc />
			public string Summary => SUMMARY;
		}
		private PATH_FEEDRATE_PER_REVOLUTIONValue _PATH_FEEDRATE_PER_REVOLUTION;
		/// <inheritdoc cref="PATH_FEEDRATE_PER_REVOLUTIONValue" path="/summary" />
		public PATH_FEEDRATE_PER_REVOLUTIONValue PATH_FEEDRATE_PER_REVOLUTION => _PATH_FEEDRATE_PER_REVOLUTION ?? (_PATH_FEEDRATE_PER_REVOLUTION = new PATH_FEEDRATE_PER_REVOLUTIONValue());

		/// <summary>﻿feedrate for the axes, or a single axis.<br /><br /><br />
		/// Value for SampleEnum.<br/>
		/// <br/>See also <seealso cref="SampleEnum">SampleEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		public sealed class PATH_FEEDRATE_PER_REVOLUTIONValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="PATH_FEEDRATE_PER_REVOLUTIONValue.Name" /></summary>
			public const string NAME = "PATH_FEEDRATE_PER_REVOLUTION";
			/// <summary>Constant value for <see cref="PATH_FEEDRATE_PER_REVOLUTIONValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.5";
			/// <summary>Constant value for <see cref="PATH_FEEDRATE_PER_REVOLUTIONValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="PATH_FEEDRATE_PER_REVOLUTIONValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;feedrate for the axes, or a single axis.&#10;
";

			/// <inheritdoc />
			public string Name => NAME;
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => NORMATIVE_VERSION;
			
			/// <inheritdoc />
			public string DeprecatedVersion => DEPRECATED_VERSION;
			
			/// <inheritdoc />
			public string Summary => SUMMARY;
		}
		private PATH_POSITIONValue _PATH_POSITION;
		/// <inheritdoc cref="PATH_POSITIONValue" path="/summary" />
		public PATH_POSITIONValue PATH_POSITION => _PATH_POSITION ?? (_PATH_POSITION = new PATH_POSITIONValue());

		/// <summary>﻿position of a control point associated with a <see cref="Controller">Controller</see> or a <see cref="Path">Path</see>.<br /><br /><br />
		/// Value for SampleEnum.<br/>
		/// <br/>See also <seealso cref="SampleEnum">SampleEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		public sealed class PATH_POSITIONValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="PATH_POSITIONValue.Name" /></summary>
			public const string NAME = "PATH_POSITION";
			/// <summary>Constant value for <see cref="PATH_POSITIONValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.1";
			/// <summary>Constant value for <see cref="PATH_POSITIONValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="PATH_POSITIONValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;position of a control point associated with a {{block(Controller)}} or a {{block(Path)}}.&#10;
";

			/// <inheritdoc />
			public string Name => NAME;
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => NORMATIVE_VERSION;
			
			/// <inheritdoc />
			public string DeprecatedVersion => DEPRECATED_VERSION;
			
			/// <inheritdoc />
			public string Summary => SUMMARY;
		}
		private PHValue _PH;
		/// <inheritdoc cref="PHValue" path="/summary" />
		public PHValue PH => _PH ?? (_PH = new PHValue());

		/// <summary>﻿acidity or alkalinity of a solution.<br /><br /><br />
		/// Value for SampleEnum.<br/>
		/// <br/>See also <seealso cref="SampleEnum">SampleEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		public sealed class PHValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="PHValue.Name" /></summary>
			public const string NAME = "PH";
			/// <summary>Constant value for <see cref="PHValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.1";
			/// <summary>Constant value for <see cref="PHValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="PHValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;acidity or alkalinity of a solution.&#10;
";

			/// <inheritdoc />
			public string Name => NAME;
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => NORMATIVE_VERSION;
			
			/// <inheritdoc />
			public string DeprecatedVersion => DEPRECATED_VERSION;
			
			/// <inheritdoc />
			public string Summary => SUMMARY;
		}
		private POSITIONValue _POSITION;
		/// <inheritdoc cref="POSITIONValue" path="/summary" />
		public POSITIONValue POSITION => _POSITION ?? (_POSITION = new POSITIONValue());

		/// <summary>﻿point along an axis in a <i>cartesian coordinate system</i>.<br /><br /><br />
		/// Value for SampleEnum.<br/>
		/// <br/>See also <seealso cref="SampleEnum">SampleEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		public sealed class POSITIONValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="POSITIONValue.Name" /></summary>
			public const string NAME = "POSITION";
			/// <summary>Constant value for <see cref="POSITIONValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.0";
			/// <summary>Constant value for <see cref="POSITIONValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="POSITIONValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;point along an axis in a {{term(cartesian coordinate system)}}.&#10;
";

			/// <inheritdoc />
			public string Name => NAME;
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => NORMATIVE_VERSION;
			
			/// <inheritdoc />
			public string DeprecatedVersion => DEPRECATED_VERSION;
			
			/// <inheritdoc />
			public string Summary => SUMMARY;
		}
		private POWER_FACTORValue _POWER_FACTOR;
		/// <inheritdoc cref="POWER_FACTORValue" path="/summary" />
		public POWER_FACTORValue POWER_FACTOR => _POWER_FACTOR ?? (_POWER_FACTOR = new POWER_FACTORValue());

		/// <summary>﻿ratio of real power flowing to a load to the apparent power in that AC circuit.<br /><br /><br />
		/// Value for SampleEnum.<br/>
		/// <br/>See also <seealso cref="SampleEnum">SampleEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		public sealed class POWER_FACTORValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="POWER_FACTORValue.Name" /></summary>
			public const string NAME = "POWER_FACTOR";
			/// <summary>Constant value for <see cref="POWER_FACTORValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.2";
			/// <summary>Constant value for <see cref="POWER_FACTORValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="POWER_FACTORValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;ratio of real power flowing to a load to the apparent power in that AC circuit.&#10;
";

			/// <inheritdoc />
			public string Name => NAME;
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => NORMATIVE_VERSION;
			
			/// <inheritdoc />
			public string DeprecatedVersion => DEPRECATED_VERSION;
			
			/// <inheritdoc />
			public string Summary => SUMMARY;
		}
		private PRESSUREValue _PRESSURE;
		/// <inheritdoc cref="PRESSUREValue" path="/summary" />
		public PRESSUREValue PRESSURE => _PRESSURE ?? (_PRESSURE = new PRESSUREValue());

		/// <summary>﻿force per unit area measured relative to atmospheric pressure. <br /><br />Commonly referred to as gauge pressure.<br /><br /><br />
		/// Value for SampleEnum.<br/>
		/// <br/>See also <seealso cref="SampleEnum">SampleEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		public sealed class PRESSUREValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="PRESSUREValue.Name" /></summary>
			public const string NAME = "PRESSURE";
			/// <summary>Constant value for <see cref="PRESSUREValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.0";
			/// <summary>Constant value for <see cref="PRESSUREValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="PRESSUREValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;force per unit area measured relative to atmospheric pressure. 

Commonly referred to as gauge pressure.&#10;
";

			/// <inheritdoc />
			public string Name => NAME;
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => NORMATIVE_VERSION;
			
			/// <inheritdoc />
			public string DeprecatedVersion => DEPRECATED_VERSION;
			
			/// <inheritdoc />
			public string Summary => SUMMARY;
		}
		private PROCESS_TIMERValue _PROCESS_TIMER;
		/// <inheritdoc cref="PROCESS_TIMERValue" path="/summary" />
		public PROCESS_TIMERValue PROCESS_TIMER => _PROCESS_TIMER ?? (_PROCESS_TIMER = new PROCESS_TIMERValue());

		/// <summary>﻿amount of time a piece of equipment has performed different types of activities associated with the process being performed at that piece of equipment.<br /><br /><br />
		/// Value for SampleEnum.<br/>
		/// <br/>See also <seealso cref="SampleEnum">SampleEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		public sealed class PROCESS_TIMERValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="PROCESS_TIMERValue.Name" /></summary>
			public const string NAME = "PROCESS_TIMER";
			/// <summary>Constant value for <see cref="PROCESS_TIMERValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.4";
			/// <summary>Constant value for <see cref="PROCESS_TIMERValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="PROCESS_TIMERValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;amount of time a piece of equipment has performed different types of activities associated with the process being performed at that piece of equipment.&#10;
";

			/// <inheritdoc />
			public string Name => NAME;
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => NORMATIVE_VERSION;
			
			/// <inheritdoc />
			public string DeprecatedVersion => DEPRECATED_VERSION;
			
			/// <inheritdoc />
			public string Summary => SUMMARY;
		}
		private RESISTANCEValue _RESISTANCE;
		/// <inheritdoc cref="RESISTANCEValue" path="/summary" />
		public RESISTANCEValue RESISTANCE => _RESISTANCE ?? (_RESISTANCE = new RESISTANCEValue());

		/// <summary>﻿degree to which a substance opposes the passage of an electric current.<br /><br /><br />
		/// Value for SampleEnum.<br/>
		/// <br/>See also <seealso cref="SampleEnum">SampleEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		public sealed class RESISTANCEValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="RESISTANCEValue.Name" /></summary>
			public const string NAME = "RESISTANCE";
			/// <summary>Constant value for <see cref="RESISTANCEValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.2";
			/// <summary>Constant value for <see cref="RESISTANCEValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="RESISTANCEValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;degree to which a substance opposes the passage of an electric current.&#10;
";

			/// <inheritdoc />
			public string Name => NAME;
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => NORMATIVE_VERSION;
			
			/// <inheritdoc />
			public string DeprecatedVersion => DEPRECATED_VERSION;
			
			/// <inheritdoc />
			public string Summary => SUMMARY;
		}
		private ROTARY_VELOCITYValue _ROTARY_VELOCITY;
		/// <inheritdoc cref="ROTARY_VELOCITYValue" path="/summary" />
		public ROTARY_VELOCITYValue ROTARY_VELOCITY => _ROTARY_VELOCITY ?? (_ROTARY_VELOCITY = new ROTARY_VELOCITYValue());

		/// <summary>﻿rotational speed of a rotary axis.<br /><br /><br />
		/// Value for SampleEnum.<br/>
		/// <br/>See also <seealso cref="SampleEnum">SampleEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		public sealed class ROTARY_VELOCITYValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="ROTARY_VELOCITYValue.Name" /></summary>
			public const string NAME = "ROTARY_VELOCITY";
			/// <summary>Constant value for <see cref="ROTARY_VELOCITYValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.2";
			/// <summary>Constant value for <see cref="ROTARY_VELOCITYValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="ROTARY_VELOCITYValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;rotational speed of a rotary axis.&#10;
";

			/// <inheritdoc />
			public string Name => NAME;
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => NORMATIVE_VERSION;
			
			/// <inheritdoc />
			public string DeprecatedVersion => DEPRECATED_VERSION;
			
			/// <inheritdoc />
			public string Summary => SUMMARY;
		}
		private SOUND_LEVELValue _SOUND_LEVEL;
		/// <inheritdoc cref="SOUND_LEVELValue" path="/summary" />
		public SOUND_LEVELValue SOUND_LEVEL => _SOUND_LEVEL ?? (_SOUND_LEVEL = new SOUND_LEVELValue());

		/// <summary>﻿sound level or sound pressure level relative to atmospheric pressure.<br /><br /><br />
		/// Value for SampleEnum.<br/>
		/// <br/>See also <seealso cref="SampleEnum">SampleEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		public sealed class SOUND_LEVELValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="SOUND_LEVELValue.Name" /></summary>
			public const string NAME = "SOUND_LEVEL";
			/// <summary>Constant value for <see cref="SOUND_LEVELValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.2";
			/// <summary>Constant value for <see cref="SOUND_LEVELValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="SOUND_LEVELValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;sound level or sound pressure level relative to atmospheric pressure.&#10;
";

			/// <inheritdoc />
			public string Name => NAME;
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => NORMATIVE_VERSION;
			
			/// <inheritdoc />
			public string DeprecatedVersion => DEPRECATED_VERSION;
			
			/// <inheritdoc />
			public string Summary => SUMMARY;
		}
		private SPINDLE_SPEEDValue _SPINDLE_SPEED;
		/// <inheritdoc cref="SPINDLE_SPEEDValue" path="/summary" />
		public SPINDLE_SPEEDValue SPINDLE_SPEED => _SPINDLE_SPEED ?? (_SPINDLE_SPEED = new SPINDLE_SPEEDValue());

		/// <summary>﻿rotational speed of the rotary axis.<br /><br /><b>DEPRECATED</b> in <i>Version 1.2</i>.  Replaced by <c>ROTARY_VELOCITY</c>.<br /><br /><br />
		/// Value for SampleEnum.<br/>
		/// <br/>See also <seealso cref="SampleEnum">SampleEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		public sealed class SPINDLE_SPEEDValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="SPINDLE_SPEEDValue.Name" /></summary>
			public const string NAME = "SPINDLE_SPEED";
			/// <summary>Constant value for <see cref="SPINDLE_SPEEDValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.0";
			/// <summary>Constant value for <see cref="SPINDLE_SPEEDValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "1.2";
			/// <summary>Constant value for <see cref="SPINDLE_SPEEDValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;rotational speed of the rotary axis.

**DEPRECATED** in *Version 1.2*.  Replaced by `ROTARY_VELOCITY`.&#10;
";

			/// <inheritdoc />
			public string Name => NAME;
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => NORMATIVE_VERSION;
			
			/// <inheritdoc />
			public string DeprecatedVersion => DEPRECATED_VERSION;
			
			/// <inheritdoc />
			public string Summary => SUMMARY;
		}
		private STRAINValue _STRAIN;
		/// <inheritdoc cref="STRAINValue" path="/summary" />
		public STRAINValue STRAIN => _STRAIN ?? (_STRAIN = new STRAINValue());

		/// <summary>﻿amount of deformation per unit length of an object when a load is applied.<br /><br /><br />
		/// Value for SampleEnum.<br/>
		/// <br/>See also <seealso cref="SampleEnum">SampleEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		public sealed class STRAINValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="STRAINValue.Name" /></summary>
			public const string NAME = "STRAIN";
			/// <summary>Constant value for <see cref="STRAINValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.2";
			/// <summary>Constant value for <see cref="STRAINValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="STRAINValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;amount of deformation per unit length of an object when a load is applied.&#10;
";

			/// <inheritdoc />
			public string Name => NAME;
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => NORMATIVE_VERSION;
			
			/// <inheritdoc />
			public string DeprecatedVersion => DEPRECATED_VERSION;
			
			/// <inheritdoc />
			public string Summary => SUMMARY;
		}
		private TEMPERATUREValue _TEMPERATURE;
		/// <inheritdoc cref="TEMPERATUREValue" path="/summary" />
		public TEMPERATUREValue TEMPERATURE => _TEMPERATURE ?? (_TEMPERATURE = new TEMPERATUREValue());

		/// <summary>﻿degree of hotness or coldness measured on a definite scale.<br /><br /><br />
		/// Value for SampleEnum.<br/>
		/// <br/>See also <seealso cref="SampleEnum">SampleEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		public sealed class TEMPERATUREValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="TEMPERATUREValue.Name" /></summary>
			public const string NAME = "TEMPERATURE";
			/// <summary>Constant value for <see cref="TEMPERATUREValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.0";
			/// <summary>Constant value for <see cref="TEMPERATUREValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="TEMPERATUREValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;degree of hotness or coldness measured on a definite scale.&#10;
";

			/// <inheritdoc />
			public string Name => NAME;
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => NORMATIVE_VERSION;
			
			/// <inheritdoc />
			public string DeprecatedVersion => DEPRECATED_VERSION;
			
			/// <inheritdoc />
			public string Summary => SUMMARY;
		}
		private TENSIONValue _TENSION;
		/// <inheritdoc cref="TENSIONValue" path="/summary" />
		public TENSIONValue TENSION => _TENSION ?? (_TENSION = new TENSIONValue());

		/// <summary>﻿force that stretches or elongates an object.<br /><br /><br />
		/// Value for SampleEnum.<br/>
		/// <br/>See also <seealso cref="SampleEnum">SampleEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		public sealed class TENSIONValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="TENSIONValue.Name" /></summary>
			public const string NAME = "TENSION";
			/// <summary>Constant value for <see cref="TENSIONValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.4";
			/// <summary>Constant value for <see cref="TENSIONValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="TENSIONValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;force that stretches or elongates an object.&#10;
";

			/// <inheritdoc />
			public string Name => NAME;
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => NORMATIVE_VERSION;
			
			/// <inheritdoc />
			public string DeprecatedVersion => DEPRECATED_VERSION;
			
			/// <inheritdoc />
			public string Summary => SUMMARY;
		}
		private TILTValue _TILT;
		/// <inheritdoc cref="TILTValue" path="/summary" />
		public TILTValue TILT => _TILT ?? (_TILT = new TILTValue());

		/// <summary>﻿angular displacement.<br /><br /><br />
		/// Value for SampleEnum.<br/>
		/// <br/>See also <seealso cref="SampleEnum">SampleEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		public sealed class TILTValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="TILTValue.Name" /></summary>
			public const string NAME = "TILT";
			/// <summary>Constant value for <see cref="TILTValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.2";
			/// <summary>Constant value for <see cref="TILTValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="TILTValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;angular displacement.&#10;
";

			/// <inheritdoc />
			public string Name => NAME;
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => NORMATIVE_VERSION;
			
			/// <inheritdoc />
			public string DeprecatedVersion => DEPRECATED_VERSION;
			
			/// <inheritdoc />
			public string Summary => SUMMARY;
		}
		private TORQUEValue _TORQUE;
		/// <inheritdoc cref="TORQUEValue" path="/summary" />
		public TORQUEValue TORQUE => _TORQUE ?? (_TORQUE = new TORQUEValue());

		/// <summary>﻿turning force exerted on an object or by an object.<br /><br /><br />
		/// Value for SampleEnum.<br/>
		/// <br/>See also <seealso cref="SampleEnum">SampleEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		public sealed class TORQUEValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="TORQUEValue.Name" /></summary>
			public const string NAME = "TORQUE";
			/// <summary>Constant value for <see cref="TORQUEValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.0";
			/// <summary>Constant value for <see cref="TORQUEValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="TORQUEValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;turning force exerted on an object or by an object.&#10;
";

			/// <inheritdoc />
			public string Name => NAME;
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => NORMATIVE_VERSION;
			
			/// <inheritdoc />
			public string DeprecatedVersion => DEPRECATED_VERSION;
			
			/// <inheritdoc />
			public string Summary => SUMMARY;
		}
		private VELOCITYValue _VELOCITY;
		/// <inheritdoc cref="VELOCITYValue" path="/summary" />
		public VELOCITYValue VELOCITY => _VELOCITY ?? (_VELOCITY = new VELOCITYValue());

		/// <summary>﻿rate of change of position of a <see cref="Component">Component</see>.<br /><br /><br />
		/// Value for SampleEnum.<br/>
		/// <br/>See also <seealso cref="SampleEnum">SampleEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		public sealed class VELOCITYValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="VELOCITYValue.Name" /></summary>
			public const string NAME = "VELOCITY";
			/// <summary>Constant value for <see cref="VELOCITYValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.0";
			/// <summary>Constant value for <see cref="VELOCITYValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="VELOCITYValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;rate of change of position of a {{block(Component)}}.&#10;
";

			/// <inheritdoc />
			public string Name => NAME;
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => NORMATIVE_VERSION;
			
			/// <inheritdoc />
			public string DeprecatedVersion => DEPRECATED_VERSION;
			
			/// <inheritdoc />
			public string Summary => SUMMARY;
		}
		private VISCOSITYValue _VISCOSITY;
		/// <inheritdoc cref="VISCOSITYValue" path="/summary" />
		public VISCOSITYValue VISCOSITY => _VISCOSITY ?? (_VISCOSITY = new VISCOSITYValue());

		/// <summary>﻿fluid's resistance to flow.<br /><br /><br />
		/// Value for SampleEnum.<br/>
		/// <br/>See also <seealso cref="SampleEnum">SampleEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		public sealed class VISCOSITYValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="VISCOSITYValue.Name" /></summary>
			public const string NAME = "VISCOSITY";
			/// <summary>Constant value for <see cref="VISCOSITYValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.2";
			/// <summary>Constant value for <see cref="VISCOSITYValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="VISCOSITYValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;fluid's resistance to flow.&#10;
";

			/// <inheritdoc />
			public string Name => NAME;
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => NORMATIVE_VERSION;
			
			/// <inheritdoc />
			public string DeprecatedVersion => DEPRECATED_VERSION;
			
			/// <inheritdoc />
			public string Summary => SUMMARY;
		}
		private VOLTAGEValue _VOLTAGE;
		/// <inheritdoc cref="VOLTAGEValue" path="/summary" />
		public VOLTAGEValue VOLTAGE => _VOLTAGE ?? (_VOLTAGE = new VOLTAGEValue());

		/// <summary>﻿electrical potential between two points.<br /><br /><b>DEPRECATED</b> in <i>Version 1.6</i>. Replaced by <c>VOLTAGE_AC</c> and <c>VOLTAGE_DC</c>.<br /><br /><br />
		/// Value for SampleEnum.<br/>
		/// <br/>See also <seealso cref="SampleEnum">SampleEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		public sealed class VOLTAGEValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="VOLTAGEValue.Name" /></summary>
			public const string NAME = "VOLTAGE";
			/// <summary>Constant value for <see cref="VOLTAGEValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.0";
			/// <summary>Constant value for <see cref="VOLTAGEValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "1.6";
			/// <summary>Constant value for <see cref="VOLTAGEValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;electrical potential between two points.

**DEPRECATED** in *Version 1.6*. Replaced by `VOLTAGE_AC` and `VOLTAGE_DC`.&#10;
";

			/// <inheritdoc />
			public string Name => NAME;
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => NORMATIVE_VERSION;
			
			/// <inheritdoc />
			public string DeprecatedVersion => DEPRECATED_VERSION;
			
			/// <inheritdoc />
			public string Summary => SUMMARY;
		}
		private VOLT_AMPEREValue _VOLT_AMPERE;
		/// <inheritdoc cref="VOLT_AMPEREValue" path="/summary" />
		public VOLT_AMPEREValue VOLT_AMPERE => _VOLT_AMPERE ?? (_VOLT_AMPERE = new VOLT_AMPEREValue());

		/// <summary>﻿apparent power in an electrical circuit, equal to the product of root-mean-square (RMS) voltage and RMS current (commonly referred to as VA).<br /><br /><br />
		/// Value for SampleEnum.<br/>
		/// <br/>See also <seealso cref="SampleEnum">SampleEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		public sealed class VOLT_AMPEREValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="VOLT_AMPEREValue.Name" /></summary>
			public const string NAME = "VOLT_AMPERE";
			/// <summary>Constant value for <see cref="VOLT_AMPEREValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.2";
			/// <summary>Constant value for <see cref="VOLT_AMPEREValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="VOLT_AMPEREValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;apparent power in an electrical circuit, equal to the product of root-mean-square (RMS) voltage and RMS current (commonly referred to as VA).&#10;
";

			/// <inheritdoc />
			public string Name => NAME;
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => NORMATIVE_VERSION;
			
			/// <inheritdoc />
			public string DeprecatedVersion => DEPRECATED_VERSION;
			
			/// <inheritdoc />
			public string Summary => SUMMARY;
		}
		private VOLT_AMPERE_REACTIVEValue _VOLT_AMPERE_REACTIVE;
		/// <inheritdoc cref="VOLT_AMPERE_REACTIVEValue" path="/summary" />
		public VOLT_AMPERE_REACTIVEValue VOLT_AMPERE_REACTIVE => _VOLT_AMPERE_REACTIVE ?? (_VOLT_AMPERE_REACTIVE = new VOLT_AMPERE_REACTIVEValue());

		/// <summary>﻿reactive power in an AC electrical circuit (commonly referred to as VAR).<br /><br /><br />
		/// Value for SampleEnum.<br/>
		/// <br/>See also <seealso cref="SampleEnum">SampleEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		public sealed class VOLT_AMPERE_REACTIVEValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="VOLT_AMPERE_REACTIVEValue.Name" /></summary>
			public const string NAME = "VOLT_AMPERE_REACTIVE";
			/// <summary>Constant value for <see cref="VOLT_AMPERE_REACTIVEValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.2";
			/// <summary>Constant value for <see cref="VOLT_AMPERE_REACTIVEValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="VOLT_AMPERE_REACTIVEValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;reactive power in an AC electrical circuit (commonly referred to as VAR).&#10;
";

			/// <inheritdoc />
			public string Name => NAME;
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => NORMATIVE_VERSION;
			
			/// <inheritdoc />
			public string DeprecatedVersion => DEPRECATED_VERSION;
			
			/// <inheritdoc />
			public string Summary => SUMMARY;
		}
		private VOLUME_FLUIDValue _VOLUME_FLUID;
		/// <inheritdoc cref="VOLUME_FLUIDValue" path="/summary" />
		public VOLUME_FLUIDValue VOLUME_FLUID => _VOLUME_FLUID ?? (_VOLUME_FLUID = new VOLUME_FLUIDValue());

		/// <summary>﻿fluid volume of an object or container.<br /><br /><br />
		/// Value for SampleEnum.<br/>
		/// <br/>See also <seealso cref="SampleEnum">SampleEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		public sealed class VOLUME_FLUIDValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="VOLUME_FLUIDValue.Name" /></summary>
			public const string NAME = "VOLUME_FLUID";
			/// <summary>Constant value for <see cref="VOLUME_FLUIDValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.5";
			/// <summary>Constant value for <see cref="VOLUME_FLUIDValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="VOLUME_FLUIDValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;fluid volume of an object or container.&#10;
";

			/// <inheritdoc />
			public string Name => NAME;
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => NORMATIVE_VERSION;
			
			/// <inheritdoc />
			public string DeprecatedVersion => DEPRECATED_VERSION;
			
			/// <inheritdoc />
			public string Summary => SUMMARY;
		}
		private VOLUME_SPATIALValue _VOLUME_SPATIAL;
		/// <inheritdoc cref="VOLUME_SPATIALValue" path="/summary" />
		public VOLUME_SPATIALValue VOLUME_SPATIAL => _VOLUME_SPATIAL ?? (_VOLUME_SPATIAL = new VOLUME_SPATIALValue());

		/// <summary>﻿geometric volume of an object or container.<br /><br /><br />
		/// Value for SampleEnum.<br/>
		/// <br/>See also <seealso cref="SampleEnum">SampleEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		public sealed class VOLUME_SPATIALValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="VOLUME_SPATIALValue.Name" /></summary>
			public const string NAME = "VOLUME_SPATIAL";
			/// <summary>Constant value for <see cref="VOLUME_SPATIALValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.5";
			/// <summary>Constant value for <see cref="VOLUME_SPATIALValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="VOLUME_SPATIALValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;geometric volume of an object or container.&#10;
";

			/// <inheritdoc />
			public string Name => NAME;
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => NORMATIVE_VERSION;
			
			/// <inheritdoc />
			public string DeprecatedVersion => DEPRECATED_VERSION;
			
			/// <inheritdoc />
			public string Summary => SUMMARY;
		}
		private WATTAGEValue _WATTAGE;
		/// <inheritdoc cref="WATTAGEValue" path="/summary" />
		public WATTAGEValue WATTAGE => _WATTAGE ?? (_WATTAGE = new WATTAGEValue());

		/// <summary>﻿power flowing through or dissipated by an electrical circuit or piece of equipment.<br /><br /><br />
		/// Value for SampleEnum.<br/>
		/// <br/>See also <seealso cref="SampleEnum">SampleEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		public sealed class WATTAGEValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="WATTAGEValue.Name" /></summary>
			public const string NAME = "WATTAGE";
			/// <summary>Constant value for <see cref="WATTAGEValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.0";
			/// <summary>Constant value for <see cref="WATTAGEValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="WATTAGEValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;power flowing through or dissipated by an electrical circuit or piece of equipment.&#10;
";

			/// <inheritdoc />
			public string Name => NAME;
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => NORMATIVE_VERSION;
			
			/// <inheritdoc />
			public string DeprecatedVersion => DEPRECATED_VERSION;
			
			/// <inheritdoc />
			public string Summary => SUMMARY;
		}
		private AMPERAGE_ACValue _AMPERAGE_AC;
		/// <inheritdoc cref="AMPERAGE_ACValue" path="/summary" />
		public AMPERAGE_ACValue AMPERAGE_AC => _AMPERAGE_AC ?? (_AMPERAGE_AC = new AMPERAGE_ACValue());

		/// <summary>﻿electrical current that reverses direction at regular short intervals.<br /><br /><br />
		/// Value for SampleEnum.<br/>
		/// <br/>See also <seealso cref="SampleEnum">SampleEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		public sealed class AMPERAGE_ACValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="AMPERAGE_ACValue.Name" /></summary>
			public const string NAME = "AMPERAGE_AC";
			/// <summary>Constant value for <see cref="AMPERAGE_ACValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.6";
			/// <summary>Constant value for <see cref="AMPERAGE_ACValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="AMPERAGE_ACValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;electrical current that reverses direction at regular short intervals.&#10;
";

			/// <inheritdoc />
			public string Name => NAME;
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => NORMATIVE_VERSION;
			
			/// <inheritdoc />
			public string DeprecatedVersion => DEPRECATED_VERSION;
			
			/// <inheritdoc />
			public string Summary => SUMMARY;
		}
		private AMPERAGE_DCValue _AMPERAGE_DC;
		/// <inheritdoc cref="AMPERAGE_DCValue" path="/summary" />
		public AMPERAGE_DCValue AMPERAGE_DC => _AMPERAGE_DC ?? (_AMPERAGE_DC = new AMPERAGE_DCValue());

		/// <summary>﻿electric current flowing in one direction only.<br /><br /><br />
		/// Value for SampleEnum.<br/>
		/// <br/>See also <seealso cref="SampleEnum">SampleEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		public sealed class AMPERAGE_DCValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="AMPERAGE_DCValue.Name" /></summary>
			public const string NAME = "AMPERAGE_DC";
			/// <summary>Constant value for <see cref="AMPERAGE_DCValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.6";
			/// <summary>Constant value for <see cref="AMPERAGE_DCValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="AMPERAGE_DCValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;electric current flowing in one direction only.&#10;
";

			/// <inheritdoc />
			public string Name => NAME;
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => NORMATIVE_VERSION;
			
			/// <inheritdoc />
			public string DeprecatedVersion => DEPRECATED_VERSION;
			
			/// <inheritdoc />
			public string Summary => SUMMARY;
		}
		private VOLTAGE_ACValue _VOLTAGE_AC;
		/// <inheritdoc cref="VOLTAGE_ACValue" path="/summary" />
		public VOLTAGE_ACValue VOLTAGE_AC => _VOLTAGE_AC ?? (_VOLTAGE_AC = new VOLTAGE_ACValue());

		/// <summary>﻿electrical potential between two points in an electrical circuit in which the current periodically reverses direction.<br /><br /><br />
		/// Value for SampleEnum.<br/>
		/// <br/>See also <seealso cref="SampleEnum">SampleEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		public sealed class VOLTAGE_ACValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="VOLTAGE_ACValue.Name" /></summary>
			public const string NAME = "VOLTAGE_AC";
			/// <summary>Constant value for <see cref="VOLTAGE_ACValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.6";
			/// <summary>Constant value for <see cref="VOLTAGE_ACValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="VOLTAGE_ACValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;electrical potential between two points in an electrical circuit in which the current periodically reverses direction.&#10;
";

			/// <inheritdoc />
			public string Name => NAME;
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => NORMATIVE_VERSION;
			
			/// <inheritdoc />
			public string DeprecatedVersion => DEPRECATED_VERSION;
			
			/// <inheritdoc />
			public string Summary => SUMMARY;
		}
		private VOLTAGE_DCValue _VOLTAGE_DC;
		/// <inheritdoc cref="VOLTAGE_DCValue" path="/summary" />
		public VOLTAGE_DCValue VOLTAGE_DC => _VOLTAGE_DC ?? (_VOLTAGE_DC = new VOLTAGE_DCValue());

		/// <summary>﻿electrical potential between two points in an electrical circuit in which the current is unidirectional.<br /><br /><br />
		/// Value for SampleEnum.<br/>
		/// <br/>See also <seealso cref="SampleEnum">SampleEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		public sealed class VOLTAGE_DCValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="VOLTAGE_DCValue.Name" /></summary>
			public const string NAME = "VOLTAGE_DC";
			/// <summary>Constant value for <see cref="VOLTAGE_DCValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.6";
			/// <summary>Constant value for <see cref="VOLTAGE_DCValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="VOLTAGE_DCValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;electrical potential between two points in an electrical circuit in which the current is unidirectional.&#10;
";

			/// <inheritdoc />
			public string Name => NAME;
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => NORMATIVE_VERSION;
			
			/// <inheritdoc />
			public string DeprecatedVersion => DEPRECATED_VERSION;
			
			/// <inheritdoc />
			public string Summary => SUMMARY;
		}
		private X_DIMENSIONValue _X_DIMENSION;
		/// <inheritdoc cref="X_DIMENSIONValue" path="/summary" />
		public X_DIMENSIONValue X_DIMENSION => _X_DIMENSION ?? (_X_DIMENSION = new X_DIMENSIONValue());

		/// <summary>﻿dimension of an entity relative to the X direction of the referenced coordinate system.<br /><br /><br /><br />
		/// Value for SampleEnum.<br/>
		/// <br/>See also <seealso cref="SampleEnum">SampleEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		public sealed class X_DIMENSIONValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="X_DIMENSIONValue.Name" /></summary>
			public const string NAME = "X_DIMENSION";
			/// <summary>Constant value for <see cref="X_DIMENSIONValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.6";
			/// <summary>Constant value for <see cref="X_DIMENSIONValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="X_DIMENSIONValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;dimension of an entity relative to the X direction of the referenced coordinate system.&#10;
";

			/// <inheritdoc />
			public string Name => NAME;
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => NORMATIVE_VERSION;
			
			/// <inheritdoc />
			public string DeprecatedVersion => DEPRECATED_VERSION;
			
			/// <inheritdoc />
			public string Summary => SUMMARY;
		}
		private Y_DIMENSIONValue _Y_DIMENSION;
		/// <inheritdoc cref="Y_DIMENSIONValue" path="/summary" />
		public Y_DIMENSIONValue Y_DIMENSION => _Y_DIMENSION ?? (_Y_DIMENSION = new Y_DIMENSIONValue());

		/// <summary>﻿dimension of an entity relative to the Y direction of the referenced coordinate system.<br /><br /><br />
		/// Value for SampleEnum.<br/>
		/// <br/>See also <seealso cref="SampleEnum">SampleEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		public sealed class Y_DIMENSIONValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="Y_DIMENSIONValue.Name" /></summary>
			public const string NAME = "Y_DIMENSION";
			/// <summary>Constant value for <see cref="Y_DIMENSIONValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.6";
			/// <summary>Constant value for <see cref="Y_DIMENSIONValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="Y_DIMENSIONValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;dimension of an entity relative to the Y direction of the referenced coordinate system.&#10;
";

			/// <inheritdoc />
			public string Name => NAME;
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => NORMATIVE_VERSION;
			
			/// <inheritdoc />
			public string DeprecatedVersion => DEPRECATED_VERSION;
			
			/// <inheritdoc />
			public string Summary => SUMMARY;
		}
		private Z_DIMENSIONValue _Z_DIMENSION;
		/// <inheritdoc cref="Z_DIMENSIONValue" path="/summary" />
		public Z_DIMENSIONValue Z_DIMENSION => _Z_DIMENSION ?? (_Z_DIMENSION = new Z_DIMENSIONValue());

		/// <summary>﻿dimension of an entity relative to the Z direction of the referenced coordinate system.<br /><br /><br />
		/// Value for SampleEnum.<br/>
		/// <br/>See also <seealso cref="SampleEnum">SampleEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		public sealed class Z_DIMENSIONValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="Z_DIMENSIONValue.Name" /></summary>
			public const string NAME = "Z_DIMENSION";
			/// <summary>Constant value for <see cref="Z_DIMENSIONValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.6";
			/// <summary>Constant value for <see cref="Z_DIMENSIONValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="Z_DIMENSIONValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;dimension of an entity relative to the Z direction of the referenced coordinate system.&#10;
";

			/// <inheritdoc />
			public string Name => NAME;
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => NORMATIVE_VERSION;
			
			/// <inheritdoc />
			public string DeprecatedVersion => DEPRECATED_VERSION;
			
			/// <inheritdoc />
			public string Summary => SUMMARY;
		}
		private DIAMETERValue _DIAMETER;
		/// <inheritdoc cref="DIAMETERValue" path="/summary" />
		public DIAMETERValue DIAMETER => _DIAMETER ?? (_DIAMETER = new DIAMETERValue());

		/// <summary>﻿dimension of a diameter.<br /><br /><br />
		/// Value for SampleEnum.<br/>
		/// <br/>See also <seealso cref="SampleEnum">SampleEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		public sealed class DIAMETERValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="DIAMETERValue.Name" /></summary>
			public const string NAME = "DIAMETER";
			/// <summary>Constant value for <see cref="DIAMETERValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.6";
			/// <summary>Constant value for <see cref="DIAMETERValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="DIAMETERValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;dimension of a diameter.&#10;
";

			/// <inheritdoc />
			public string Name => NAME;
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => NORMATIVE_VERSION;
			
			/// <inheritdoc />
			public string DeprecatedVersion => DEPRECATED_VERSION;
			
			/// <inheritdoc />
			public string Summary => SUMMARY;
		}
		private ORIENTATIONValue _ORIENTATION;
		/// <inheritdoc cref="ORIENTATIONValue" path="/summary" />
		public ORIENTATIONValue ORIENTATION => _ORIENTATION ?? (_ORIENTATION = new ORIENTATIONValue());

		/// <summary>﻿angular position of a plane or vector relative to a <i>cartesian coordinate system</i><br /><br /><br />
		/// Value for SampleEnum.<br/>
		/// <br/>See also <seealso cref="SampleEnum">SampleEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		public sealed class ORIENTATIONValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="ORIENTATIONValue.Name" /></summary>
			public const string NAME = "ORIENTATION";
			/// <summary>Constant value for <see cref="ORIENTATIONValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.6";
			/// <summary>Constant value for <see cref="ORIENTATIONValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="ORIENTATIONValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;angular position of a plane or vector relative to a {{term(cartesian coordinate system)}}&#10;
";

			/// <inheritdoc />
			public string Name => NAME;
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => NORMATIVE_VERSION;
			
			/// <inheritdoc />
			public string DeprecatedVersion => DEPRECATED_VERSION;
			
			/// <inheritdoc />
			public string Summary => SUMMARY;
		}
		private HUMIDITY_RELATIVEValue _HUMIDITY_RELATIVE;
		/// <inheritdoc cref="HUMIDITY_RELATIVEValue" path="/summary" />
		public HUMIDITY_RELATIVEValue HUMIDITY_RELATIVE => _HUMIDITY_RELATIVE ?? (_HUMIDITY_RELATIVE = new HUMIDITY_RELATIVEValue());

		/// <summary>﻿amount of water vapor present expressed as a percent to reach saturation at the same temperature.<br /><br /><br />
		/// Value for SampleEnum.<br/>
		/// <br/>See also <seealso cref="SampleEnum">SampleEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		public sealed class HUMIDITY_RELATIVEValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="HUMIDITY_RELATIVEValue.Name" /></summary>
			public const string NAME = "HUMIDITY_RELATIVE";
			/// <summary>Constant value for <see cref="HUMIDITY_RELATIVEValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.6";
			/// <summary>Constant value for <see cref="HUMIDITY_RELATIVEValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="HUMIDITY_RELATIVEValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;amount of water vapor present expressed as a percent to reach saturation at the same temperature.&#10;
";

			/// <inheritdoc />
			public string Name => NAME;
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => NORMATIVE_VERSION;
			
			/// <inheritdoc />
			public string DeprecatedVersion => DEPRECATED_VERSION;
			
			/// <inheritdoc />
			public string Summary => SUMMARY;
		}
		private HUMIDITY_ABSOLUTEValue _HUMIDITY_ABSOLUTE;
		/// <inheritdoc cref="HUMIDITY_ABSOLUTEValue" path="/summary" />
		public HUMIDITY_ABSOLUTEValue HUMIDITY_ABSOLUTE => _HUMIDITY_ABSOLUTE ?? (_HUMIDITY_ABSOLUTE = new HUMIDITY_ABSOLUTEValue());

		/// <summary>﻿amount of water vapor expressed in grams per cubic meter.<br /><br /><br />
		/// Value for SampleEnum.<br/>
		/// <br/>See also <seealso cref="SampleEnum">SampleEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		public sealed class HUMIDITY_ABSOLUTEValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="HUMIDITY_ABSOLUTEValue.Name" /></summary>
			public const string NAME = "HUMIDITY_ABSOLUTE";
			/// <summary>Constant value for <see cref="HUMIDITY_ABSOLUTEValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.6";
			/// <summary>Constant value for <see cref="HUMIDITY_ABSOLUTEValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="HUMIDITY_ABSOLUTEValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;amount of water vapor expressed in grams per cubic meter.&#10;
";

			/// <inheritdoc />
			public string Name => NAME;
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => NORMATIVE_VERSION;
			
			/// <inheritdoc />
			public string DeprecatedVersion => DEPRECATED_VERSION;
			
			/// <inheritdoc />
			public string Summary => SUMMARY;
		}
		private HUMIDITY_SPECIFICValue _HUMIDITY_SPECIFIC;
		/// <inheritdoc cref="HUMIDITY_SPECIFICValue" path="/summary" />
		public HUMIDITY_SPECIFICValue HUMIDITY_SPECIFIC => _HUMIDITY_SPECIFIC ?? (_HUMIDITY_SPECIFIC = new HUMIDITY_SPECIFICValue());

		/// <summary>﻿ratio of the water vapor present over the total weight of the water vapor and air present expressed as a percent.<br /><br /><br />
		/// Value for SampleEnum.<br/>
		/// <br/>See also <seealso cref="SampleEnum">SampleEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		public sealed class HUMIDITY_SPECIFICValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="HUMIDITY_SPECIFICValue.Name" /></summary>
			public const string NAME = "HUMIDITY_SPECIFIC";
			/// <summary>Constant value for <see cref="HUMIDITY_SPECIFICValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.6";
			/// <summary>Constant value for <see cref="HUMIDITY_SPECIFICValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="HUMIDITY_SPECIFICValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;ratio of the water vapor present over the total weight of the water vapor and air present expressed as a percent.&#10;
";

			/// <inheritdoc />
			public string Name => NAME;
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => NORMATIVE_VERSION;
			
			/// <inheritdoc />
			public string DeprecatedVersion => DEPRECATED_VERSION;
			
			/// <inheritdoc />
			public string Summary => SUMMARY;
		}
		private OBSERVATION_UPDATE_RATEValue _OBSERVATION_UPDATE_RATE;
		/// <inheritdoc cref="OBSERVATION_UPDATE_RATEValue" path="/summary" />
		public OBSERVATION_UPDATE_RATEValue OBSERVATION_UPDATE_RATE => _OBSERVATION_UPDATE_RATE ?? (_OBSERVATION_UPDATE_RATE = new OBSERVATION_UPDATE_RATEValue());

		/// <summary>﻿average rate of change of values for data items in the MTConnect streams. The average is computed over a rolling window defined by the implementation.<br /><br /><br />
		/// Value for SampleEnum.<br/>
		/// <br/>See also <seealso cref="SampleEnum">SampleEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		public sealed class OBSERVATION_UPDATE_RATEValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="OBSERVATION_UPDATE_RATEValue.Name" /></summary>
			public const string NAME = "OBSERVATION_UPDATE_RATE";
			/// <summary>Constant value for <see cref="OBSERVATION_UPDATE_RATEValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.7";
			/// <summary>Constant value for <see cref="OBSERVATION_UPDATE_RATEValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="OBSERVATION_UPDATE_RATEValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;average rate of change of values for data items in the MTConnect streams. The average is computed over a rolling window defined by the implementation.&#10;
";

			/// <inheritdoc />
			public string Name => NAME;
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => NORMATIVE_VERSION;
			
			/// <inheritdoc />
			public string DeprecatedVersion => DEPRECATED_VERSION;
			
			/// <inheritdoc />
			public string Summary => SUMMARY;
		}
		private ASSET_UPDATE_RATEValue _ASSET_UPDATE_RATE;
		/// <inheritdoc cref="ASSET_UPDATE_RATEValue" path="/summary" />
		public ASSET_UPDATE_RATEValue ASSET_UPDATE_RATE => _ASSET_UPDATE_RATE ?? (_ASSET_UPDATE_RATE = new ASSET_UPDATE_RATEValue());

		/// <summary>﻿average rate of change of values for assets in the MTConnect streams. <br /><br />The average is computed over a rolling window defined by the implementation.<br /><br /><br />
		/// Value for SampleEnum.<br/>
		/// <br/>See also <seealso cref="SampleEnum">SampleEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		public sealed class ASSET_UPDATE_RATEValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="ASSET_UPDATE_RATEValue.Name" /></summary>
			public const string NAME = "ASSET_UPDATE_RATE";
			/// <summary>Constant value for <see cref="ASSET_UPDATE_RATEValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.7";
			/// <summary>Constant value for <see cref="ASSET_UPDATE_RATEValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="ASSET_UPDATE_RATEValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;average rate of change of values for assets in the MTConnect streams. 

The average is computed over a rolling window defined by the implementation.&#10;
";

			/// <inheritdoc />
			public string Name => NAME;
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => NORMATIVE_VERSION;
			
			/// <inheritdoc />
			public string DeprecatedVersion => DEPRECATED_VERSION;
			
			/// <inheritdoc />
			public string Summary => SUMMARY;
		}
		private PRESSURIZATION_RATEValue _PRESSURIZATION_RATE;
		/// <inheritdoc cref="PRESSURIZATION_RATEValue" path="/summary" />
		public PRESSURIZATION_RATEValue PRESSURIZATION_RATE => _PRESSURIZATION_RATE ?? (_PRESSURIZATION_RATE = new PRESSURIZATION_RATEValue());

		/// <summary>﻿change of pressure per unit time.<br /><br /><br />
		/// Value for SampleEnum.<br/>
		/// <br/>See also <seealso cref="SampleEnum">SampleEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		public sealed class PRESSURIZATION_RATEValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="PRESSURIZATION_RATEValue.Name" /></summary>
			public const string NAME = "PRESSURIZATION_RATE";
			/// <summary>Constant value for <see cref="PRESSURIZATION_RATEValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.7";
			/// <summary>Constant value for <see cref="PRESSURIZATION_RATEValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="PRESSURIZATION_RATEValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;change of pressure per unit time.&#10;
";

			/// <inheritdoc />
			public string Name => NAME;
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => NORMATIVE_VERSION;
			
			/// <inheritdoc />
			public string DeprecatedVersion => DEPRECATED_VERSION;
			
			/// <inheritdoc />
			public string Summary => SUMMARY;
		}
		private DECELERATIONValue _DECELERATION;
		/// <inheritdoc cref="DECELERATIONValue" path="/summary" />
		public DECELERATIONValue DECELERATION => _DECELERATION ?? (_DECELERATION = new DECELERATIONValue());

		/// <summary>﻿negative rate of change of velocity.<br /><br /><br />
		/// Value for SampleEnum.<br/>
		/// <br/>See also <seealso cref="SampleEnum">SampleEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		public sealed class DECELERATIONValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="DECELERATIONValue.Name" /></summary>
			public const string NAME = "DECELERATION";
			/// <summary>Constant value for <see cref="DECELERATIONValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.7";
			/// <summary>Constant value for <see cref="DECELERATIONValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="DECELERATIONValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;negative rate of change of velocity.&#10;
";

			/// <inheritdoc />
			public string Name => NAME;
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => NORMATIVE_VERSION;
			
			/// <inheritdoc />
			public string DeprecatedVersion => DEPRECATED_VERSION;
			
			/// <inheritdoc />
			public string Summary => SUMMARY;
		}
		private ANGULAR_DECELERATIONValue _ANGULAR_DECELERATION;
		/// <inheritdoc cref="ANGULAR_DECELERATIONValue" path="/summary" />
		public ANGULAR_DECELERATIONValue ANGULAR_DECELERATION => _ANGULAR_DECELERATION ?? (_ANGULAR_DECELERATION = new ANGULAR_DECELERATIONValue());

		/// <summary>﻿negative rate of change of angular velocity.<br /><br /><br />
		/// Value for SampleEnum.<br/>
		/// <br/>See also <seealso cref="SampleEnum">SampleEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		public sealed class ANGULAR_DECELERATIONValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="ANGULAR_DECELERATIONValue.Name" /></summary>
			public const string NAME = "ANGULAR_DECELERATION";
			/// <summary>Constant value for <see cref="ANGULAR_DECELERATIONValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.7";
			/// <summary>Constant value for <see cref="ANGULAR_DECELERATIONValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="ANGULAR_DECELERATIONValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;negative rate of change of angular velocity.&#10;
";

			/// <inheritdoc />
			public string Name => NAME;
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => NORMATIVE_VERSION;
			
			/// <inheritdoc />
			public string DeprecatedVersion => DEPRECATED_VERSION;
			
			/// <inheritdoc />
			public string Summary => SUMMARY;
		}
		private PRESSURE_ABSOLUTEValue _PRESSURE_ABSOLUTE;
		/// <inheritdoc cref="PRESSURE_ABSOLUTEValue" path="/summary" />
		public PRESSURE_ABSOLUTEValue PRESSURE_ABSOLUTE => _PRESSURE_ABSOLUTE ?? (_PRESSURE_ABSOLUTE = new PRESSURE_ABSOLUTEValue());

		/// <summary>﻿force per unit area measured relative to a vacuum.<br /><br /><br />
		/// Value for SampleEnum.<br/>
		/// <br/>See also <seealso cref="SampleEnum">SampleEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		public sealed class PRESSURE_ABSOLUTEValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="PRESSURE_ABSOLUTEValue.Name" /></summary>
			public const string NAME = "PRESSURE_ABSOLUTE";
			/// <summary>Constant value for <see cref="PRESSURE_ABSOLUTEValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.7";
			/// <summary>Constant value for <see cref="PRESSURE_ABSOLUTEValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="PRESSURE_ABSOLUTEValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;force per unit area measured relative to a vacuum.&#10;
";

			/// <inheritdoc />
			public string Name => NAME;
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => NORMATIVE_VERSION;
			
			/// <inheritdoc />
			public string DeprecatedVersion => DEPRECATED_VERSION;
			
			/// <inheritdoc />
			public string Summary => SUMMARY;
		}
		private OPENNESSValue _OPENNESS;
		/// <inheritdoc cref="OPENNESSValue" path="/summary" />
		public OPENNESSValue OPENNESS => _OPENNESS ?? (_OPENNESS = new OPENNESSValue());

		/// <summary>﻿percentage open where 100% is fully open and 0% is fully closed.<br /><br /><br />
		/// Value for SampleEnum.<br/>
		/// <br/>See also <seealso cref="SampleEnum">SampleEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		public sealed class OPENNESSValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="OPENNESSValue.Name" /></summary>
			public const string NAME = "OPENNESS";
			/// <summary>Constant value for <see cref="OPENNESSValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "2.0";
			/// <summary>Constant value for <see cref="OPENNESSValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="OPENNESSValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;percentage open where 100% is fully open and 0% is fully closed.&#10;
";

			/// <inheritdoc />
			public string Name => NAME;
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => NORMATIVE_VERSION;
			
			/// <inheritdoc />
			public string DeprecatedVersion => DEPRECATED_VERSION;
			
			/// <inheritdoc />
			public string Summary => SUMMARY;
		}
		private DEW_POINTValue _DEW_POINT;
		/// <inheritdoc cref="DEW_POINTValue" path="/summary" />
		public DEW_POINTValue DEW_POINT => _DEW_POINT ?? (_DEW_POINT = new DEW_POINTValue());

		/// <summary>﻿temperature at which moisture begins to condense, corresponding to saturation for a given absolute humidity.<br /><br /><br />
		/// Value for SampleEnum.<br/>
		/// <br/>See also <seealso cref="SampleEnum">SampleEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		public sealed class DEW_POINTValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="DEW_POINTValue.Name" /></summary>
			public const string NAME = "DEW_POINT";
			/// <summary>Constant value for <see cref="DEW_POINTValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "2.1";
			/// <summary>Constant value for <see cref="DEW_POINTValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="DEW_POINTValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;temperature at which moisture begins to condense, corresponding to saturation for a given absolute humidity.&#10;
";

			/// <inheritdoc />
			public string Name => NAME;
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => NORMATIVE_VERSION;
			
			/// <inheritdoc />
			public string DeprecatedVersion => DEPRECATED_VERSION;
			
			/// <inheritdoc />
			public string Summary => SUMMARY;
		}
		private GRAVITATIONAL_FORCEValue _GRAVITATIONAL_FORCE;
		/// <inheritdoc cref="GRAVITATIONAL_FORCEValue" path="/summary" />
		public GRAVITATIONAL_FORCEValue GRAVITATIONAL_FORCE => _GRAVITATIONAL_FORCE ?? (_GRAVITATIONAL_FORCE = new GRAVITATIONAL_FORCEValue());

		/// <summary>﻿force relative to earth's gravity.<br /><br /><br />
		/// Value for SampleEnum.<br/>
		/// <br/>See also <seealso cref="SampleEnum">SampleEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		public sealed class GRAVITATIONAL_FORCEValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="GRAVITATIONAL_FORCEValue.Name" /></summary>
			public const string NAME = "GRAVITATIONAL_FORCE";
			/// <summary>Constant value for <see cref="GRAVITATIONAL_FORCEValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "2.1";
			/// <summary>Constant value for <see cref="GRAVITATIONAL_FORCEValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="GRAVITATIONAL_FORCEValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;force relative to earth's gravity.&#10;
";

			/// <inheritdoc />
			public string Name => NAME;
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => NORMATIVE_VERSION;
			
			/// <inheritdoc />
			public string DeprecatedVersion => DEPRECATED_VERSION;
			
			/// <inheritdoc />
			public string Summary => SUMMARY;
		}
		private GRAVITATIONAL_ACCELERATIONValue _GRAVITATIONAL_ACCELERATION;
		/// <inheritdoc cref="GRAVITATIONAL_ACCELERATIONValue" path="/summary" />
		public GRAVITATIONAL_ACCELERATIONValue GRAVITATIONAL_ACCELERATION => _GRAVITATIONAL_ACCELERATION ?? (_GRAVITATIONAL_ACCELERATION = new GRAVITATIONAL_ACCELERATIONValue());

		/// <summary>﻿acceleration relative to Earth's gravity of 9.80665 <c>METER/SECOND^2</c>.<br /><br /><br />
		/// Value for SampleEnum.<br/>
		/// <br/>See also <seealso cref="SampleEnum">SampleEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		public sealed class GRAVITATIONAL_ACCELERATIONValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="GRAVITATIONAL_ACCELERATIONValue.Name" /></summary>
			public const string NAME = "GRAVITATIONAL_ACCELERATION";
			/// <summary>Constant value for <see cref="GRAVITATIONAL_ACCELERATIONValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "2.1";
			/// <summary>Constant value for <see cref="GRAVITATIONAL_ACCELERATIONValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="GRAVITATIONAL_ACCELERATIONValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;acceleration relative to Earth's gravity of 9.80665 `METER/SECOND^2`.&#10;
";

			/// <inheritdoc />
			public string Name => NAME;
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => NORMATIVE_VERSION;
			
			/// <inheritdoc />
			public string DeprecatedVersion => DEPRECATED_VERSION;
			
			/// <inheritdoc />
			public string Summary => SUMMARY;
		}
		private BATTERY_CAPACITYValue _BATTERY_CAPACITY;
		/// <inheritdoc cref="BATTERY_CAPACITYValue" path="/summary" />
		public BATTERY_CAPACITYValue BATTERY_CAPACITY => _BATTERY_CAPACITY ?? (_BATTERY_CAPACITY = new BATTERY_CAPACITYValue());

		/// <summary>﻿maximum rated charge a battery is capable of maintaining based on the battery discharging at a specified current over a specified time period.<br /><br /><br />
		/// Value for SampleEnum.<br/>
		/// <br/>See also <seealso cref="SampleEnum">SampleEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		public sealed class BATTERY_CAPACITYValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="BATTERY_CAPACITYValue.Name" /></summary>
			public const string NAME = "BATTERY_CAPACITY";
			/// <summary>Constant value for <see cref="BATTERY_CAPACITYValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "2.1";
			/// <summary>Constant value for <see cref="BATTERY_CAPACITYValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="BATTERY_CAPACITYValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;maximum rated charge a battery is capable of maintaining based on the battery discharging at a specified current over a specified time period.&#10;
";

			/// <inheritdoc />
			public string Name => NAME;
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => NORMATIVE_VERSION;
			
			/// <inheritdoc />
			public string DeprecatedVersion => DEPRECATED_VERSION;
			
			/// <inheritdoc />
			public string Summary => SUMMARY;
		}
		private DISCHARGE_RATEValue _DISCHARGE_RATE;
		/// <inheritdoc cref="DISCHARGE_RATEValue" path="/summary" />
		public DISCHARGE_RATEValue DISCHARGE_RATE => _DISCHARGE_RATE ?? (_DISCHARGE_RATE = new DISCHARGE_RATEValue());

		/// <summary>﻿value of current being drawn from the <see cref="Component">Component</see>.<br /><br /><br />
		/// Value for SampleEnum.<br/>
		/// <br/>See also <seealso cref="SampleEnum">SampleEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		public sealed class DISCHARGE_RATEValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="DISCHARGE_RATEValue.Name" /></summary>
			public const string NAME = "DISCHARGE_RATE";
			/// <summary>Constant value for <see cref="DISCHARGE_RATEValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "2.1";
			/// <summary>Constant value for <see cref="DISCHARGE_RATEValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="DISCHARGE_RATEValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;value of current being drawn from the {{block(Component)}}.&#10;
";

			/// <inheritdoc />
			public string Name => NAME;
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => NORMATIVE_VERSION;
			
			/// <inheritdoc />
			public string DeprecatedVersion => DEPRECATED_VERSION;
			
			/// <inheritdoc />
			public string Summary => SUMMARY;
		}
		private CHARGE_RATEValue _CHARGE_RATE;
		/// <inheritdoc cref="CHARGE_RATEValue" path="/summary" />
		public CHARGE_RATEValue CHARGE_RATE => _CHARGE_RATE ?? (_CHARGE_RATE = new CHARGE_RATEValue());

		/// <summary>﻿value of the current being supplied to the <see cref="Component">Component</see> for the purpose of charging.<br /><br /><br />
		/// Value for SampleEnum.<br/>
		/// <br/>See also <seealso cref="SampleEnum">SampleEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		public sealed class CHARGE_RATEValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="CHARGE_RATEValue.Name" /></summary>
			public const string NAME = "CHARGE_RATE";
			/// <summary>Constant value for <see cref="CHARGE_RATEValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "2.1";
			/// <summary>Constant value for <see cref="CHARGE_RATEValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="CHARGE_RATEValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;value of the current being supplied to the {{block(Component)}} for the purpose of charging.&#10;
";

			/// <inheritdoc />
			public string Name => NAME;
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => NORMATIVE_VERSION;
			
			/// <inheritdoc />
			public string DeprecatedVersion => DEPRECATED_VERSION;
			
			/// <inheritdoc />
			public string Summary => SUMMARY;
		}
		private BATTERY_CHARGEValue _BATTERY_CHARGE;
		/// <inheritdoc cref="BATTERY_CHARGEValue" path="/summary" />
		public BATTERY_CHARGEValue BATTERY_CHARGE => _BATTERY_CHARGE ?? (_BATTERY_CHARGE = new BATTERY_CHARGEValue());

		/// <summary>﻿value of the battery's present capacity expressed as a percentage of the battery's maximum rated capacity.<br /><br /><br />
		/// Value for SampleEnum.<br/>
		/// <br/>See also <seealso cref="SampleEnum">SampleEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		public sealed class BATTERY_CHARGEValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="BATTERY_CHARGEValue.Name" /></summary>
			public const string NAME = "BATTERY_CHARGE";
			/// <summary>Constant value for <see cref="BATTERY_CHARGEValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "2.1";
			/// <summary>Constant value for <see cref="BATTERY_CHARGEValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="BATTERY_CHARGEValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;value of the battery's present capacity expressed as a percentage of the battery's maximum rated capacity.&#10;
";

			/// <inheritdoc />
			public string Name => NAME;
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => NORMATIVE_VERSION;
			
			/// <inheritdoc />
			public string DeprecatedVersion => DEPRECATED_VERSION;
			
			/// <inheritdoc />
			public string Summary => SUMMARY;
		}
		private SETTLING_ERRORValue _SETTLING_ERROR;
		/// <inheritdoc cref="SETTLING_ERRORValue" path="/summary" />
		public SETTLING_ERRORValue SETTLING_ERROR => _SETTLING_ERROR ?? (_SETTLING_ERROR = new SETTLING_ERRORValue());

		/// <summary>﻿difference between actual and commanded position at the end of a motion.<br /><br /><br />
		/// Value for SampleEnum.<br/>
		/// <br/>See also <seealso cref="SampleEnum">SampleEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		public sealed class SETTLING_ERRORValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="SETTLING_ERRORValue.Name" /></summary>
			public const string NAME = "SETTLING_ERROR";
			/// <summary>Constant value for <see cref="SETTLING_ERRORValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "2.1";
			/// <summary>Constant value for <see cref="SETTLING_ERRORValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="SETTLING_ERRORValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;difference between actual and commanded position at the end of a motion.&#10;
";

			/// <inheritdoc />
			public string Name => NAME;
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => NORMATIVE_VERSION;
			
			/// <inheritdoc />
			public string DeprecatedVersion => DEPRECATED_VERSION;
			
			/// <inheritdoc />
			public string Summary => SUMMARY;
		}
		private FOLLOWING_ERRORValue _FOLLOWING_ERROR;
		/// <inheritdoc cref="FOLLOWING_ERRORValue" path="/summary" />
		public FOLLOWING_ERRORValue FOLLOWING_ERROR => _FOLLOWING_ERROR ?? (_FOLLOWING_ERROR = new FOLLOWING_ERRORValue());

		/// <summary>﻿difference between actual and commanded position at any specific point in time during a motion.<br /><br /><br />
		/// Value for SampleEnum.<br/>
		/// <br/>See also <seealso cref="SampleEnum">SampleEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		public sealed class FOLLOWING_ERRORValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="FOLLOWING_ERRORValue.Name" /></summary>
			public const string NAME = "FOLLOWING_ERROR";
			/// <summary>Constant value for <see cref="FOLLOWING_ERRORValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "2.1";
			/// <summary>Constant value for <see cref="FOLLOWING_ERRORValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="FOLLOWING_ERRORValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;difference between actual and commanded position at any specific point in time during a motion.&#10;
";

			/// <inheritdoc />
			public string Name => NAME;
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => NORMATIVE_VERSION;
			
			/// <inheritdoc />
			public string DeprecatedVersion => DEPRECATED_VERSION;
			
			/// <inheritdoc />
			public string Summary => SUMMARY;
		}
		private SETTLING_ERROR_LINEARValue _SETTLING_ERROR_LINEAR;
		/// <inheritdoc cref="SETTLING_ERROR_LINEARValue" path="/summary" />
		public SETTLING_ERROR_LINEARValue SETTLING_ERROR_LINEAR => _SETTLING_ERROR_LINEAR ?? (_SETTLING_ERROR_LINEAR = new SETTLING_ERROR_LINEARValue());

		/// <summary>﻿difference between the commanded encoder/resolver position, and the actual encoder/resolver position when motion is complete.<br /><br /><br />
		/// Value for SampleEnum.<br/>
		/// <br/>See also <seealso cref="SampleEnum">SampleEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		public sealed class SETTLING_ERROR_LINEARValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="SETTLING_ERROR_LINEARValue.Name" /></summary>
			public const string NAME = "SETTLING_ERROR_LINEAR";
			/// <summary>Constant value for <see cref="SETTLING_ERROR_LINEARValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "2.1";
			/// <summary>Constant value for <see cref="SETTLING_ERROR_LINEARValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="SETTLING_ERROR_LINEARValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;difference between the commanded encoder/resolver position, and the actual encoder/resolver position when motion is complete.&#10;
";

			/// <inheritdoc />
			public string Name => NAME;
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => NORMATIVE_VERSION;
			
			/// <inheritdoc />
			public string DeprecatedVersion => DEPRECATED_VERSION;
			
			/// <inheritdoc />
			public string Summary => SUMMARY;
		}
		private SETTLING_ERROR_ANGULARValue _SETTLING_ERROR_ANGULAR;
		/// <inheritdoc cref="SETTLING_ERROR_ANGULARValue" path="/summary" />
		public SETTLING_ERROR_ANGULARValue SETTLING_ERROR_ANGULAR => _SETTLING_ERROR_ANGULAR ?? (_SETTLING_ERROR_ANGULAR = new SETTLING_ERROR_ANGULARValue());

		/// <summary>﻿angular difference between the commanded encoder/resolver position, and the actual encoder/resolver position when motion is complete.<br /><br /><br />
		/// Value for SampleEnum.<br/>
		/// <br/>See also <seealso cref="SampleEnum">SampleEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		public sealed class SETTLING_ERROR_ANGULARValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="SETTLING_ERROR_ANGULARValue.Name" /></summary>
			public const string NAME = "SETTLING_ERROR_ANGULAR";
			/// <summary>Constant value for <see cref="SETTLING_ERROR_ANGULARValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "2.1";
			/// <summary>Constant value for <see cref="SETTLING_ERROR_ANGULARValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="SETTLING_ERROR_ANGULARValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;angular difference between the commanded encoder/resolver position, and the actual encoder/resolver position when motion is complete.&#10;
";

			/// <inheritdoc />
			public string Name => NAME;
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => NORMATIVE_VERSION;
			
			/// <inheritdoc />
			public string DeprecatedVersion => DEPRECATED_VERSION;
			
			/// <inheritdoc />
			public string Summary => SUMMARY;
		}
		private FOLLOWING_ERROR_LINEARValue _FOLLOWING_ERROR_LINEAR;
		/// <inheritdoc cref="FOLLOWING_ERROR_LINEARValue" path="/summary" />
		public FOLLOWING_ERROR_LINEARValue FOLLOWING_ERROR_LINEAR => _FOLLOWING_ERROR_LINEAR ?? (_FOLLOWING_ERROR_LINEAR = new FOLLOWING_ERROR_LINEARValue());

		/// <summary>﻿difference between the commanded encoder/resolver position and the actual encoder/resolver position at any specified point in time during a motion.<br /><br /><br />
		/// Value for SampleEnum.<br/>
		/// <br/>See also <seealso cref="SampleEnum">SampleEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		public sealed class FOLLOWING_ERROR_LINEARValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="FOLLOWING_ERROR_LINEARValue.Name" /></summary>
			public const string NAME = "FOLLOWING_ERROR_LINEAR";
			/// <summary>Constant value for <see cref="FOLLOWING_ERROR_LINEARValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "2.1";
			/// <summary>Constant value for <see cref="FOLLOWING_ERROR_LINEARValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="FOLLOWING_ERROR_LINEARValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;difference between the commanded encoder/resolver position and the actual encoder/resolver position at any specified point in time during a motion.&#10;
";

			/// <inheritdoc />
			public string Name => NAME;
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => NORMATIVE_VERSION;
			
			/// <inheritdoc />
			public string DeprecatedVersion => DEPRECATED_VERSION;
			
			/// <inheritdoc />
			public string Summary => SUMMARY;
		}
		private FOLLOWING_ERROR_ANGULARValue _FOLLOWING_ERROR_ANGULAR;
		/// <inheritdoc cref="FOLLOWING_ERROR_ANGULARValue" path="/summary" />
		public FOLLOWING_ERROR_ANGULARValue FOLLOWING_ERROR_ANGULAR => _FOLLOWING_ERROR_ANGULAR ?? (_FOLLOWING_ERROR_ANGULAR = new FOLLOWING_ERROR_ANGULARValue());

		/// <summary>﻿angular difference between the commanded encoder/resolver position and the actual encoder/resolver position at any specified point in time during a motion.<br /><br /><br />
		/// Value for SampleEnum.<br/>
		/// <br/>See also <seealso cref="SampleEnum">SampleEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		public sealed class FOLLOWING_ERROR_ANGULARValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="FOLLOWING_ERROR_ANGULARValue.Name" /></summary>
			public const string NAME = "FOLLOWING_ERROR_ANGULAR";
			/// <summary>Constant value for <see cref="FOLLOWING_ERROR_ANGULARValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "2.1";
			/// <summary>Constant value for <see cref="FOLLOWING_ERROR_ANGULARValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="FOLLOWING_ERROR_ANGULARValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;angular difference between the commanded encoder/resolver position and the actual encoder/resolver position at any specified point in time during a motion.&#10;
";

			/// <inheritdoc />
			public string Name => NAME;
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => NORMATIVE_VERSION;
			
			/// <inheritdoc />
			public string DeprecatedVersion => DEPRECATED_VERSION;
			
			/// <inheritdoc />
			public string Summary => SUMMARY;
		}
		private DISPLACEMENT_LINEARValue _DISPLACEMENT_LINEAR;
		/// <inheritdoc cref="DISPLACEMENT_LINEARValue" path="/summary" />
		public DISPLACEMENT_LINEARValue DISPLACEMENT_LINEAR => _DISPLACEMENT_LINEAR ?? (_DISPLACEMENT_LINEAR = new DISPLACEMENT_LINEARValue());

		/// <summary>﻿absolute value of the change in position along a vector.<br /><br /><br />
		/// Value for SampleEnum.<br/>
		/// <br/>See also <seealso cref="SampleEnum">SampleEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		public sealed class DISPLACEMENT_LINEARValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="DISPLACEMENT_LINEARValue.Name" /></summary>
			public const string NAME = "DISPLACEMENT_LINEAR";
			/// <summary>Constant value for <see cref="DISPLACEMENT_LINEARValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "2.1";
			/// <summary>Constant value for <see cref="DISPLACEMENT_LINEARValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="DISPLACEMENT_LINEARValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;absolute value of the change in position along a vector.&#10;
";

			/// <inheritdoc />
			public string Name => NAME;
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => NORMATIVE_VERSION;
			
			/// <inheritdoc />
			public string DeprecatedVersion => DEPRECATED_VERSION;
			
			/// <inheritdoc />
			public string Summary => SUMMARY;
		}
		private DISPLACEMENT_ANGULARValue _DISPLACEMENT_ANGULAR;
		/// <inheritdoc cref="DISPLACEMENT_ANGULARValue" path="/summary" />
		public DISPLACEMENT_ANGULARValue DISPLACEMENT_ANGULAR => _DISPLACEMENT_ANGULAR ?? (_DISPLACEMENT_ANGULAR = new DISPLACEMENT_ANGULARValue());

		/// <summary>﻿absolute value of the change in angular position around a vector<br /><br /><br />
		/// Value for SampleEnum.<br/>
		/// <br/>See also <seealso cref="SampleEnum">SampleEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		public sealed class DISPLACEMENT_ANGULARValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="DISPLACEMENT_ANGULARValue.Name" /></summary>
			public const string NAME = "DISPLACEMENT_ANGULAR";
			/// <summary>Constant value for <see cref="DISPLACEMENT_ANGULARValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "2.1";
			/// <summary>Constant value for <see cref="DISPLACEMENT_ANGULARValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="DISPLACEMENT_ANGULARValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;absolute value of the change in angular position around a vector&#10;
";

			/// <inheritdoc />
			public string Name => NAME;
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => NORMATIVE_VERSION;
			
			/// <inheritdoc />
			public string DeprecatedVersion => DEPRECATED_VERSION;
			
			/// <inheritdoc />
			public string Summary => SUMMARY;
		}
		private POSITION_CARTESIANValue _POSITION_CARTESIAN;
		/// <inheritdoc cref="POSITION_CARTESIANValue" path="/summary" />
		public POSITION_CARTESIANValue POSITION_CARTESIAN => _POSITION_CARTESIAN ?? (_POSITION_CARTESIAN = new POSITION_CARTESIANValue());

		/// <summary>﻿point in a <i>cartesian coordinate system</i>.<br /><br /><br />
		/// Value for SampleEnum.<br/>
		/// <br/>See also <seealso cref="SampleEnum">SampleEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		public sealed class POSITION_CARTESIANValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="POSITION_CARTESIANValue.Name" /></summary>
			public const string NAME = "POSITION_CARTESIAN";
			/// <summary>Constant value for <see cref="POSITION_CARTESIANValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "2.1";
			/// <summary>Constant value for <see cref="POSITION_CARTESIANValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="POSITION_CARTESIANValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;point in a {{term(cartesian coordinate system)}}.&#10;
";

			/// <inheritdoc />
			public string Name => NAME;
			
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