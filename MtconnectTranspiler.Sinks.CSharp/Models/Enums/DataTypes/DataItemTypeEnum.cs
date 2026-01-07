#pragma warning disable CS1574 // XML comment has cref attribute that could not be resolved
#pragma warning disable CS1584 // XML comment has syntactically incorrect cref attribute
#pragma warning disable CS0618 // Type or member is obsolete
using System;
using System.CodeDom.Compiler;using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;

namespace Mtconnect.DataTypes
{
	/// <summary>﻿
	/// <br/> Visit <seealso href="https://model.mtconnect.org/#Enumeration___19_0_3_45f01b9_1579563576485_587701_22033">model.mtconnect.org</seealso> for more information.
	/// </summary>
	/// <remarks>
	/// <list type="bullet">
	/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
	/// </list>
	/// </remarks>

	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.6.0.0")]
	public enum DataItemTypeEnum
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
		/// <summary>﻿maximum amount of fluid that can be held by a container.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		CAPACITY_FLUID,
		/// <summary>﻿maximum amount of material that can be held by a container.<br /><br /><br />
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
		/// <summary>﻿inability of a material to conduct electricity.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		RESISTIVITY,
		/// <summary>﻿amount of a substance in a container.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		FILL_HEIGHT,
		/// <summary>﻿number of particles counted by their size or other characteristics.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		PARTICLE_COUNT,
		/// <summary>﻿size of particles counted by their size or other characteristics.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		PARTICLE_SIZE,
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
		/// <summary>﻿<see cref="Asset.assetId">assetId in Asset</see> of the <see cref="Asset">Asset</see> that has been changed.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		ASSET_CHANGED,
		/// <summary>﻿<see cref="Asset.assetId">assetId in Asset</see> of the <see cref="Asset">Asset</see> that has been removed.<br /><br /><br />
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
		/// <summary>﻿identifier of the tool currently in use for a given <c>Path</c>.<br /><br /><b>DEPRECATED</b> in <i>Version 1.2.0</i>.   See <c>TOOL_NUMBER</c>.<br /><br /><br />
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
		/// <summary>﻿set of limits used to indicate whether a process variable is stable and in control.<br /><br /><b>DEPRECATED</b> in <i>Version 2.5</i>. Replaced by <c>CONTROL_LIMITS</c>.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		CONTROL_LIMIT,
		/// <summary>﻿set of limits defining a range of values designating acceptable performance for a variable.<br /><br /><b>DEPRECATED</b> in <i>Version 2.5</i>. Replaced by  <c>SPECIFICATION_LIMITS</c>.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		SPECIFICATION_LIMIT,
		/// <summary>﻿set of limits used to trigger warning or alarm indicators.<br /><br /><b>DEPRECATED</b> in <i>Version 2.5</i>. Replaced by  <c>ALARM_LIMITS</c>.<br /><br /><br />
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

		ACTIVE_POWER_SOURCE,
		/// <summary>﻿textual description of the location of an object or activity.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		LOCATION_NARRATIVE,
		/// <summary>﻿dimension between two surfaces of an object, usually the dimension of smallest measure, for example an additive layer, or a depth of cut.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		THICKNESS,
		/// <summary>﻿absolute geographic location defined by two coordinates, longitude and latitude and an elevation.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		LOCATION_SPATIAL_GEOGRAPHIC,
		/// <summary>﻿sequence of a part in a group of parts.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		PART_INDEX,
		/// <summary>﻿<see cref="Asset.assetId">assetId in Asset</see> of the <see cref="Asset">Asset</see>s associated with a <see cref="Component">Component</see>.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		ASSOCIATED_ASSET_ID,
		/// <summary>﻿<see cref="Asset.assetId">assetId in Asset</see> of the <see cref="Asset">Asset</see> that has been added.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		ASSET_ADDED,
		/// <summary>﻿operational state of an <see cref="Interface">Interface</see>.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		INTERFACE_STATE,
		/// <summary>﻿operating state of the service to advance material or feed product to a piece of equipment from a continuous or bulk source.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		MATERIAL_FEED,
		/// <summary>﻿operating state of the service to change the type of material or product being loaded or fed to a piece of equipment.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		MATERIAL_CHANGE,
		/// <summary>﻿operating state of the service to remove or retract material or product.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		MATERIAL_RETRACT,
		/// <summary>﻿operating state of the service to change the part or product associated with a piece of equipment to a different part or product.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		PART_CHANGE,
		/// <summary>﻿operating state of the service to load a piece of material or product.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		MATERIAL_LOAD,
		/// <summary>﻿operating state of the service to unload a piece of material or product.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		MATERIAL_UNLOAD,
		/// <summary>﻿operating state of the service to open a chuck.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		OPEN_CHUCK,
		/// <summary>﻿operating state of the service to open a door.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		OPEN_DOOR,
		/// <summary>﻿operating state of the service to close a chuck.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		CLOSE_CHUCK,
		/// <summary>﻿operating state of the service to close a door.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		CLOSE_DOOR,
	}

	/// <summary>﻿
	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Enumeration___19_0_3_45f01b9_1579563576485_587701_22033">model.mtconnect.org</seealso> for more information.
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.6.0.0")]
	public sealed class DataItemTypeEnumMetaClass : IEnum
	{
		/// <summary>Constant value for <see cref="DataItemTypeEnumMetaClass.ReferenceId" /></summary>
		public const string REFERENCE_ID = "_19_0_3_45f01b9_1579563576485_587701_22033";
		/// <summary>Constant value for <see cref="DataItemTypeEnumMetaClass.HelpUrl" /></summary>
		public const string HELP_URL = "https://model.mtconnect.org/#Enumeration___19_0_3_45f01b9_1579563576485_587701_22033";
		/// <summary>Constant value for <see cref="DataItemTypeEnumMetaClass.Name" /></summary>
		public const string NAME = "DataItemTypeEnum";
		/// <summary>Constant value for <see cref="DataItemTypeEnumMetaClass.NormativeVersion" /></summary>
		public const string NORMATIVE_VERSION = "1.0";
		/// <summary>Constant value for <see cref="DataItemTypeEnumMetaClass.DeprecatedVersion" /></summary>
		public const string DEPRECATED_VERSION = "";
		/// <summary>Constant value for <see cref="DataItemTypeEnumMetaClass.Summary" /></summary>
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
		public Type Instance => typeof(DataItemTypeEnum);

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
		RESISTIVITY,
		FILL_HEIGHT,
		PARTICLE_COUNT,
		PARTICLE_SIZE,
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
		ACTIVE_POWER_SOURCE,
		LOCATION_NARRATIVE,
		THICKNESS,
		LOCATION_SPATIAL_GEOGRAPHIC,
		PART_INDEX,
		ASSOCIATED_ASSET_ID,
		ASSET_ADDED,
		INTERFACE_STATE,
		MATERIAL_FEED,
		MATERIAL_CHANGE,
		MATERIAL_RETRACT,
		PART_CHANGE,
		MATERIAL_LOAD,
		MATERIAL_UNLOAD,
		OPEN_CHUCK,
		OPEN_DOOR,
		CLOSE_CHUCK,
		CLOSE_DOOR,
		};

		private ACCELERATIONValue _ACCELERATION;
		/// <inheritdoc cref="ACCELERATIONValue" path="/summary" />
		public ACCELERATIONValue ACCELERATION => _ACCELERATION ?? (_ACCELERATION = new ACCELERATIONValue());

		/// <summary>﻿positive rate of change of velocity.<br /><br /><br />
		/// Value for DataItemTypeEnum.<br/>
		/// <br/>See also <seealso cref="DataItemTypeEnum">DataItemTypeEnum</seealso>
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
		/// Value for DataItemTypeEnum.<br/>
		/// <br/>See also <seealso cref="DataItemTypeEnum">DataItemTypeEnum</seealso>
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
		/// Value for DataItemTypeEnum.<br/>
		/// <br/>See also <seealso cref="DataItemTypeEnum">DataItemTypeEnum</seealso>
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
		/// Value for DataItemTypeEnum.<br/>
		/// <br/>See also <seealso cref="DataItemTypeEnum">DataItemTypeEnum</seealso>
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
		/// Value for DataItemTypeEnum.<br/>
		/// <br/>See also <seealso cref="DataItemTypeEnum">DataItemTypeEnum</seealso>
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
		/// Value for DataItemTypeEnum.<br/>
		/// <br/>See also <seealso cref="DataItemTypeEnum">DataItemTypeEnum</seealso>
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
		/// Value for DataItemTypeEnum.<br/>
		/// <br/>See also <seealso cref="DataItemTypeEnum">DataItemTypeEnum</seealso>
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

		/// <summary>﻿maximum amount of fluid that can be held by a container.<br /><br /><br />
		/// Value for DataItemTypeEnum.<br/>
		/// <br/>See also <seealso cref="DataItemTypeEnum">DataItemTypeEnum</seealso>
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
			public const string SUMMARY = @"&#10;&#10;&#10;maximum amount of fluid that can be held by a container.&#10;
";

			/// <inheritdoc />
			public string Name => NAME;
			
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

		/// <summary>﻿maximum amount of material that can be held by a container.<br /><br /><br />
		/// Value for DataItemTypeEnum.<br/>
		/// <br/>See also <seealso cref="DataItemTypeEnum">DataItemTypeEnum</seealso>
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
			public const string SUMMARY = @"&#10;&#10;&#10;maximum amount of material that can be held by a container.&#10;
";

			/// <inheritdoc />
			public string Name => NAME;
			
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
		/// Value for DataItemTypeEnum.<br/>
		/// <br/>See also <seealso cref="DataItemTypeEnum">DataItemTypeEnum</seealso>
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
		/// Value for DataItemTypeEnum.<br/>
		/// <br/>See also <seealso cref="DataItemTypeEnum">DataItemTypeEnum</seealso>
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
		/// Value for DataItemTypeEnum.<br/>
		/// <br/>See also <seealso cref="DataItemTypeEnum">DataItemTypeEnum</seealso>
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
		/// Value for DataItemTypeEnum.<br/>
		/// <br/>See also <seealso cref="DataItemTypeEnum">DataItemTypeEnum</seealso>
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
		/// Value for DataItemTypeEnum.<br/>
		/// <br/>See also <seealso cref="DataItemTypeEnum">DataItemTypeEnum</seealso>
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
		/// Value for DataItemTypeEnum.<br/>
		/// <br/>See also <seealso cref="DataItemTypeEnum">DataItemTypeEnum</seealso>
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
		/// Value for DataItemTypeEnum.<br/>
		/// <br/>See also <seealso cref="DataItemTypeEnum">DataItemTypeEnum</seealso>
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
		/// Value for DataItemTypeEnum.<br/>
		/// <br/>See also <seealso cref="DataItemTypeEnum">DataItemTypeEnum</seealso>
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
		/// Value for DataItemTypeEnum.<br/>
		/// <br/>See also <seealso cref="DataItemTypeEnum">DataItemTypeEnum</seealso>
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
		/// Value for DataItemTypeEnum.<br/>
		/// <br/>See also <seealso cref="DataItemTypeEnum">DataItemTypeEnum</seealso>
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
		/// Value for DataItemTypeEnum.<br/>
		/// <br/>See also <seealso cref="DataItemTypeEnum">DataItemTypeEnum</seealso>
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
		/// Value for DataItemTypeEnum.<br/>
		/// <br/>See also <seealso cref="DataItemTypeEnum">DataItemTypeEnum</seealso>
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
		/// Value for DataItemTypeEnum.<br/>
		/// <br/>See also <seealso cref="DataItemTypeEnum">DataItemTypeEnum</seealso>
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
		/// Value for DataItemTypeEnum.<br/>
		/// <br/>See also <seealso cref="DataItemTypeEnum">DataItemTypeEnum</seealso>
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
		/// Value for DataItemTypeEnum.<br/>
		/// <br/>See also <seealso cref="DataItemTypeEnum">DataItemTypeEnum</seealso>
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
		/// Value for DataItemTypeEnum.<br/>
		/// <br/>See also <seealso cref="DataItemTypeEnum">DataItemTypeEnum</seealso>
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
		/// Value for DataItemTypeEnum.<br/>
		/// <br/>See also <seealso cref="DataItemTypeEnum">DataItemTypeEnum</seealso>
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
		/// Value for DataItemTypeEnum.<br/>
		/// <br/>See also <seealso cref="DataItemTypeEnum">DataItemTypeEnum</seealso>
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
		/// Value for DataItemTypeEnum.<br/>
		/// <br/>See also <seealso cref="DataItemTypeEnum">DataItemTypeEnum</seealso>
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
		/// Value for DataItemTypeEnum.<br/>
		/// <br/>See also <seealso cref="DataItemTypeEnum">DataItemTypeEnum</seealso>
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
		/// Value for DataItemTypeEnum.<br/>
		/// <br/>See also <seealso cref="DataItemTypeEnum">DataItemTypeEnum</seealso>
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
		/// Value for DataItemTypeEnum.<br/>
		/// <br/>See also <seealso cref="DataItemTypeEnum">DataItemTypeEnum</seealso>
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
		/// Value for DataItemTypeEnum.<br/>
		/// <br/>See also <seealso cref="DataItemTypeEnum">DataItemTypeEnum</seealso>
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
		/// Value for DataItemTypeEnum.<br/>
		/// <br/>See also <seealso cref="DataItemTypeEnum">DataItemTypeEnum</seealso>
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
		/// Value for DataItemTypeEnum.<br/>
		/// <br/>See also <seealso cref="DataItemTypeEnum">DataItemTypeEnum</seealso>
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
		/// Value for DataItemTypeEnum.<br/>
		/// <br/>See also <seealso cref="DataItemTypeEnum">DataItemTypeEnum</seealso>
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
		/// Value for DataItemTypeEnum.<br/>
		/// <br/>See also <seealso cref="DataItemTypeEnum">DataItemTypeEnum</seealso>
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
		/// Value for DataItemTypeEnum.<br/>
		/// <br/>See also <seealso cref="DataItemTypeEnum">DataItemTypeEnum</seealso>
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
		/// Value for DataItemTypeEnum.<br/>
		/// <br/>See also <seealso cref="DataItemTypeEnum">DataItemTypeEnum</seealso>
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
		/// Value for DataItemTypeEnum.<br/>
		/// <br/>See also <seealso cref="DataItemTypeEnum">DataItemTypeEnum</seealso>
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
		/// Value for DataItemTypeEnum.<br/>
		/// <br/>See also <seealso cref="DataItemTypeEnum">DataItemTypeEnum</seealso>
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
		/// Value for DataItemTypeEnum.<br/>
		/// <br/>See also <seealso cref="DataItemTypeEnum">DataItemTypeEnum</seealso>
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
		/// Value for DataItemTypeEnum.<br/>
		/// <br/>See also <seealso cref="DataItemTypeEnum">DataItemTypeEnum</seealso>
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
		/// Value for DataItemTypeEnum.<br/>
		/// <br/>See also <seealso cref="DataItemTypeEnum">DataItemTypeEnum</seealso>
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
		/// Value for DataItemTypeEnum.<br/>
		/// <br/>See also <seealso cref="DataItemTypeEnum">DataItemTypeEnum</seealso>
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
		/// Value for DataItemTypeEnum.<br/>
		/// <br/>See also <seealso cref="DataItemTypeEnum">DataItemTypeEnum</seealso>
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
		/// Value for DataItemTypeEnum.<br/>
		/// <br/>See also <seealso cref="DataItemTypeEnum">DataItemTypeEnum</seealso>
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
		/// Value for DataItemTypeEnum.<br/>
		/// <br/>See also <seealso cref="DataItemTypeEnum">DataItemTypeEnum</seealso>
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
		/// Value for DataItemTypeEnum.<br/>
		/// <br/>See also <seealso cref="DataItemTypeEnum">DataItemTypeEnum</seealso>
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
		/// Value for DataItemTypeEnum.<br/>
		/// <br/>See also <seealso cref="DataItemTypeEnum">DataItemTypeEnum</seealso>
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
		/// Value for DataItemTypeEnum.<br/>
		/// <br/>See also <seealso cref="DataItemTypeEnum">DataItemTypeEnum</seealso>
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
		/// Value for DataItemTypeEnum.<br/>
		/// <br/>See also <seealso cref="DataItemTypeEnum">DataItemTypeEnum</seealso>
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
		/// Value for DataItemTypeEnum.<br/>
		/// <br/>See also <seealso cref="DataItemTypeEnum">DataItemTypeEnum</seealso>
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
		/// Value for DataItemTypeEnum.<br/>
		/// <br/>See also <seealso cref="DataItemTypeEnum">DataItemTypeEnum</seealso>
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
		/// Value for DataItemTypeEnum.<br/>
		/// <br/>See also <seealso cref="DataItemTypeEnum">DataItemTypeEnum</seealso>
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
		/// Value for DataItemTypeEnum.<br/>
		/// <br/>See also <seealso cref="DataItemTypeEnum">DataItemTypeEnum</seealso>
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
		/// Value for DataItemTypeEnum.<br/>
		/// <br/>See also <seealso cref="DataItemTypeEnum">DataItemTypeEnum</seealso>
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
		/// Value for DataItemTypeEnum.<br/>
		/// <br/>See also <seealso cref="DataItemTypeEnum">DataItemTypeEnum</seealso>
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
		/// Value for DataItemTypeEnum.<br/>
		/// <br/>See also <seealso cref="DataItemTypeEnum">DataItemTypeEnum</seealso>
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
		/// Value for DataItemTypeEnum.<br/>
		/// <br/>See also <seealso cref="DataItemTypeEnum">DataItemTypeEnum</seealso>
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
		/// Value for DataItemTypeEnum.<br/>
		/// <br/>See also <seealso cref="DataItemTypeEnum">DataItemTypeEnum</seealso>
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
		/// Value for DataItemTypeEnum.<br/>
		/// <br/>See also <seealso cref="DataItemTypeEnum">DataItemTypeEnum</seealso>
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
		/// Value for DataItemTypeEnum.<br/>
		/// <br/>See also <seealso cref="DataItemTypeEnum">DataItemTypeEnum</seealso>
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
		/// Value for DataItemTypeEnum.<br/>
		/// <br/>See also <seealso cref="DataItemTypeEnum">DataItemTypeEnum</seealso>
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
		/// Value for DataItemTypeEnum.<br/>
		/// <br/>See also <seealso cref="DataItemTypeEnum">DataItemTypeEnum</seealso>
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
		/// Value for DataItemTypeEnum.<br/>
		/// <br/>See also <seealso cref="DataItemTypeEnum">DataItemTypeEnum</seealso>
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
		/// Value for DataItemTypeEnum.<br/>
		/// <br/>See also <seealso cref="DataItemTypeEnum">DataItemTypeEnum</seealso>
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
		/// Value for DataItemTypeEnum.<br/>
		/// <br/>See also <seealso cref="DataItemTypeEnum">DataItemTypeEnum</seealso>
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
		/// Value for DataItemTypeEnum.<br/>
		/// <br/>See also <seealso cref="DataItemTypeEnum">DataItemTypeEnum</seealso>
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
		/// Value for DataItemTypeEnum.<br/>
		/// <br/>See also <seealso cref="DataItemTypeEnum">DataItemTypeEnum</seealso>
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
		/// Value for DataItemTypeEnum.<br/>
		/// <br/>See also <seealso cref="DataItemTypeEnum">DataItemTypeEnum</seealso>
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
		/// Value for DataItemTypeEnum.<br/>
		/// <br/>See also <seealso cref="DataItemTypeEnum">DataItemTypeEnum</seealso>
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
		/// Value for DataItemTypeEnum.<br/>
		/// <br/>See also <seealso cref="DataItemTypeEnum">DataItemTypeEnum</seealso>
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
		/// Value for DataItemTypeEnum.<br/>
		/// <br/>See also <seealso cref="DataItemTypeEnum">DataItemTypeEnum</seealso>
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
		/// Value for DataItemTypeEnum.<br/>
		/// <br/>See also <seealso cref="DataItemTypeEnum">DataItemTypeEnum</seealso>
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
		/// Value for DataItemTypeEnum.<br/>
		/// <br/>See also <seealso cref="DataItemTypeEnum">DataItemTypeEnum</seealso>
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
		/// Value for DataItemTypeEnum.<br/>
		/// <br/>See also <seealso cref="DataItemTypeEnum">DataItemTypeEnum</seealso>
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
		/// Value for DataItemTypeEnum.<br/>
		/// <br/>See also <seealso cref="DataItemTypeEnum">DataItemTypeEnum</seealso>
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
		/// Value for DataItemTypeEnum.<br/>
		/// <br/>See also <seealso cref="DataItemTypeEnum">DataItemTypeEnum</seealso>
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
		/// Value for DataItemTypeEnum.<br/>
		/// <br/>See also <seealso cref="DataItemTypeEnum">DataItemTypeEnum</seealso>
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
		/// Value for DataItemTypeEnum.<br/>
		/// <br/>See also <seealso cref="DataItemTypeEnum">DataItemTypeEnum</seealso>
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
		/// Value for DataItemTypeEnum.<br/>
		/// <br/>See also <seealso cref="DataItemTypeEnum">DataItemTypeEnum</seealso>
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
		/// Value for DataItemTypeEnum.<br/>
		/// <br/>See also <seealso cref="DataItemTypeEnum">DataItemTypeEnum</seealso>
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
		/// Value for DataItemTypeEnum.<br/>
		/// <br/>See also <seealso cref="DataItemTypeEnum">DataItemTypeEnum</seealso>
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
		/// Value for DataItemTypeEnum.<br/>
		/// <br/>See also <seealso cref="DataItemTypeEnum">DataItemTypeEnum</seealso>
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
		/// Value for DataItemTypeEnum.<br/>
		/// <br/>See also <seealso cref="DataItemTypeEnum">DataItemTypeEnum</seealso>
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
		/// Value for DataItemTypeEnum.<br/>
		/// <br/>See also <seealso cref="DataItemTypeEnum">DataItemTypeEnum</seealso>
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
		/// Value for DataItemTypeEnum.<br/>
		/// <br/>See also <seealso cref="DataItemTypeEnum">DataItemTypeEnum</seealso>
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
		/// Value for DataItemTypeEnum.<br/>
		/// <br/>See also <seealso cref="DataItemTypeEnum">DataItemTypeEnum</seealso>
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
		/// Value for DataItemTypeEnum.<br/>
		/// <br/>See also <seealso cref="DataItemTypeEnum">DataItemTypeEnum</seealso>
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
		/// Value for DataItemTypeEnum.<br/>
		/// <br/>See also <seealso cref="DataItemTypeEnum">DataItemTypeEnum</seealso>
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
		private RESISTIVITYValue _RESISTIVITY;
		/// <inheritdoc cref="RESISTIVITYValue" path="/summary" />
		public RESISTIVITYValue RESISTIVITY => _RESISTIVITY ?? (_RESISTIVITY = new RESISTIVITYValue());

		/// <summary>﻿inability of a material to conduct electricity.<br /><br /><br />
		/// Value for DataItemTypeEnum.<br/>
		/// <br/>See also <seealso cref="DataItemTypeEnum">DataItemTypeEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		public sealed class RESISTIVITYValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="RESISTIVITYValue.Name" /></summary>
			public const string NAME = "RESISTIVITY";
			/// <summary>Constant value for <see cref="RESISTIVITYValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "2.5";
			/// <summary>Constant value for <see cref="RESISTIVITYValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="RESISTIVITYValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;inability of a material to conduct electricity.&#10;
";

			/// <inheritdoc />
			public string Name => NAME;
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => NORMATIVE_VERSION;
			
			/// <inheritdoc />
			public string DeprecatedVersion => DEPRECATED_VERSION;
			
			/// <inheritdoc />
			public string Summary => SUMMARY;
		}
		private FILL_HEIGHTValue _FILL_HEIGHT;
		/// <inheritdoc cref="FILL_HEIGHTValue" path="/summary" />
		public FILL_HEIGHTValue FILL_HEIGHT => _FILL_HEIGHT ?? (_FILL_HEIGHT = new FILL_HEIGHTValue());

		/// <summary>﻿amount of a substance in a container.<br /><br /><br />
		/// Value for DataItemTypeEnum.<br/>
		/// <br/>See also <seealso cref="DataItemTypeEnum">DataItemTypeEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		public sealed class FILL_HEIGHTValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="FILL_HEIGHTValue.Name" /></summary>
			public const string NAME = "FILL_HEIGHT";
			/// <summary>Constant value for <see cref="FILL_HEIGHTValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "2.5";
			/// <summary>Constant value for <see cref="FILL_HEIGHTValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="FILL_HEIGHTValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;amount of a substance in a container.&#10;
";

			/// <inheritdoc />
			public string Name => NAME;
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => NORMATIVE_VERSION;
			
			/// <inheritdoc />
			public string DeprecatedVersion => DEPRECATED_VERSION;
			
			/// <inheritdoc />
			public string Summary => SUMMARY;
		}
		private PARTICLE_COUNTValue _PARTICLE_COUNT;
		/// <inheritdoc cref="PARTICLE_COUNTValue" path="/summary" />
		public PARTICLE_COUNTValue PARTICLE_COUNT => _PARTICLE_COUNT ?? (_PARTICLE_COUNT = new PARTICLE_COUNTValue());

		/// <summary>﻿number of particles counted by their size or other characteristics.<br /><br /><br />
		/// Value for DataItemTypeEnum.<br/>
		/// <br/>See also <seealso cref="DataItemTypeEnum">DataItemTypeEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		public sealed class PARTICLE_COUNTValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="PARTICLE_COUNTValue.Name" /></summary>
			public const string NAME = "PARTICLE_COUNT";
			/// <summary>Constant value for <see cref="PARTICLE_COUNTValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "2.5";
			/// <summary>Constant value for <see cref="PARTICLE_COUNTValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="PARTICLE_COUNTValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;number of particles counted by their size or other characteristics.&#10;
";

			/// <inheritdoc />
			public string Name => NAME;
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => NORMATIVE_VERSION;
			
			/// <inheritdoc />
			public string DeprecatedVersion => DEPRECATED_VERSION;
			
			/// <inheritdoc />
			public string Summary => SUMMARY;
		}
		private PARTICLE_SIZEValue _PARTICLE_SIZE;
		/// <inheritdoc cref="PARTICLE_SIZEValue" path="/summary" />
		public PARTICLE_SIZEValue PARTICLE_SIZE => _PARTICLE_SIZE ?? (_PARTICLE_SIZE = new PARTICLE_SIZEValue());

		/// <summary>﻿size of particles counted by their size or other characteristics.<br /><br /><br />
		/// Value for DataItemTypeEnum.<br/>
		/// <br/>See also <seealso cref="DataItemTypeEnum">DataItemTypeEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		public sealed class PARTICLE_SIZEValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="PARTICLE_SIZEValue.Name" /></summary>
			public const string NAME = "PARTICLE_SIZE";
			/// <summary>Constant value for <see cref="PARTICLE_SIZEValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "2.5";
			/// <summary>Constant value for <see cref="PARTICLE_SIZEValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="PARTICLE_SIZEValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;size of particles counted by their size or other characteristics.&#10;
";

			/// <inheritdoc />
			public string Name => NAME;
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => NORMATIVE_VERSION;
			
			/// <inheritdoc />
			public string DeprecatedVersion => DEPRECATED_VERSION;
			
			/// <inheritdoc />
			public string Summary => SUMMARY;
		}
		private ACTIVE_AXESValue _ACTIVE_AXES;
		/// <inheritdoc cref="ACTIVE_AXESValue" path="/summary" />
		public ACTIVE_AXESValue ACTIVE_AXES => _ACTIVE_AXES ?? (_ACTIVE_AXES = new ACTIVE_AXESValue());

		/// <summary>﻿set of axes currently associated with a <see cref="Path">Path</see> or <see cref="Controller">Controller</see>.<br /><br /><br />
		/// Value for DataItemTypeEnum.<br/>
		/// <br/>See also <seealso cref="DataItemTypeEnum">DataItemTypeEnum</seealso>
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
		/// Value for DataItemTypeEnum.<br/>
		/// <br/>See also <seealso cref="DataItemTypeEnum">DataItemTypeEnum</seealso>
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
		/// Value for DataItemTypeEnum.<br/>
		/// <br/>See also <seealso cref="DataItemTypeEnum">DataItemTypeEnum</seealso>
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

		/// <summary>﻿<see cref="Asset.assetId">assetId in Asset</see> of the <see cref="Asset">Asset</see> that has been changed.<br /><br /><br />
		/// Value for DataItemTypeEnum.<br/>
		/// <br/>See also <seealso cref="DataItemTypeEnum">DataItemTypeEnum</seealso>
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
			public const string SUMMARY = @"&#10;&#10;&#10;{{property(Asset::assetId)}} of the {{block(Asset)}} that has been changed.&#10;
";

			/// <inheritdoc />
			public string Name => NAME;
			
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

		/// <summary>﻿<see cref="Asset.assetId">assetId in Asset</see> of the <see cref="Asset">Asset</see> that has been removed.<br /><br /><br />
		/// Value for DataItemTypeEnum.<br/>
		/// <br/>See also <seealso cref="DataItemTypeEnum">DataItemTypeEnum</seealso>
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
			public const string SUMMARY = @"&#10;&#10;&#10;{{property(Asset::assetId)}} of the {{block(Asset)}} that has been removed.&#10;
";

			/// <inheritdoc />
			public string Name => NAME;
			
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
		/// Value for DataItemTypeEnum.<br/>
		/// <br/>See also <seealso cref="DataItemTypeEnum">DataItemTypeEnum</seealso>
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
		/// Value for DataItemTypeEnum.<br/>
		/// <br/>See also <seealso cref="DataItemTypeEnum">DataItemTypeEnum</seealso>
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
		/// Value for DataItemTypeEnum.<br/>
		/// <br/>See also <seealso cref="DataItemTypeEnum">DataItemTypeEnum</seealso>
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
		/// Value for DataItemTypeEnum.<br/>
		/// <br/>See also <seealso cref="DataItemTypeEnum">DataItemTypeEnum</seealso>
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
		/// Value for DataItemTypeEnum.<br/>
		/// <br/>See also <seealso cref="DataItemTypeEnum">DataItemTypeEnum</seealso>
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
		/// Value for DataItemTypeEnum.<br/>
		/// <br/>See also <seealso cref="DataItemTypeEnum">DataItemTypeEnum</seealso>
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
		/// Value for DataItemTypeEnum.<br/>
		/// <br/>See also <seealso cref="DataItemTypeEnum">DataItemTypeEnum</seealso>
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
		/// Value for DataItemTypeEnum.<br/>
		/// <br/>See also <seealso cref="DataItemTypeEnum">DataItemTypeEnum</seealso>
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
		/// Value for DataItemTypeEnum.<br/>
		/// <br/>See also <seealso cref="DataItemTypeEnum">DataItemTypeEnum</seealso>
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
		/// Value for DataItemTypeEnum.<br/>
		/// <br/>See also <seealso cref="DataItemTypeEnum">DataItemTypeEnum</seealso>
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
		/// Value for DataItemTypeEnum.<br/>
		/// <br/>See also <seealso cref="DataItemTypeEnum">DataItemTypeEnum</seealso>
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
		/// Value for DataItemTypeEnum.<br/>
		/// <br/>See also <seealso cref="DataItemTypeEnum">DataItemTypeEnum</seealso>
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
		/// Value for DataItemTypeEnum.<br/>
		/// <br/>See also <seealso cref="DataItemTypeEnum">DataItemTypeEnum</seealso>
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
		/// Value for DataItemTypeEnum.<br/>
		/// <br/>See also <seealso cref="DataItemTypeEnum">DataItemTypeEnum</seealso>
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
		/// Value for DataItemTypeEnum.<br/>
		/// <br/>See also <seealso cref="DataItemTypeEnum">DataItemTypeEnum</seealso>
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
		/// Value for DataItemTypeEnum.<br/>
		/// <br/>See also <seealso cref="DataItemTypeEnum">DataItemTypeEnum</seealso>
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
		/// Value for DataItemTypeEnum.<br/>
		/// <br/>See also <seealso cref="DataItemTypeEnum">DataItemTypeEnum</seealso>
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
		/// Value for DataItemTypeEnum.<br/>
		/// <br/>See also <seealso cref="DataItemTypeEnum">DataItemTypeEnum</seealso>
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
		/// Value for DataItemTypeEnum.<br/>
		/// <br/>See also <seealso cref="DataItemTypeEnum">DataItemTypeEnum</seealso>
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
		/// Value for DataItemTypeEnum.<br/>
		/// <br/>See also <seealso cref="DataItemTypeEnum">DataItemTypeEnum</seealso>
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
		/// Value for DataItemTypeEnum.<br/>
		/// <br/>See also <seealso cref="DataItemTypeEnum">DataItemTypeEnum</seealso>
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
		/// Value for DataItemTypeEnum.<br/>
		/// <br/>See also <seealso cref="DataItemTypeEnum">DataItemTypeEnum</seealso>
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
		/// Value for DataItemTypeEnum.<br/>
		/// <br/>See also <seealso cref="DataItemTypeEnum">DataItemTypeEnum</seealso>
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
		/// Value for DataItemTypeEnum.<br/>
		/// <br/>See also <seealso cref="DataItemTypeEnum">DataItemTypeEnum</seealso>
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
		/// Value for DataItemTypeEnum.<br/>
		/// <br/>See also <seealso cref="DataItemTypeEnum">DataItemTypeEnum</seealso>
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
		/// Value for DataItemTypeEnum.<br/>
		/// <br/>See also <seealso cref="DataItemTypeEnum">DataItemTypeEnum</seealso>
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
		/// Value for DataItemTypeEnum.<br/>
		/// <br/>See also <seealso cref="DataItemTypeEnum">DataItemTypeEnum</seealso>
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
		/// Value for DataItemTypeEnum.<br/>
		/// <br/>See also <seealso cref="DataItemTypeEnum">DataItemTypeEnum</seealso>
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
		/// Value for DataItemTypeEnum.<br/>
		/// <br/>See also <seealso cref="DataItemTypeEnum">DataItemTypeEnum</seealso>
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
		/// Value for DataItemTypeEnum.<br/>
		/// <br/>See also <seealso cref="DataItemTypeEnum">DataItemTypeEnum</seealso>
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
		/// Value for DataItemTypeEnum.<br/>
		/// <br/>See also <seealso cref="DataItemTypeEnum">DataItemTypeEnum</seealso>
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
		/// Value for DataItemTypeEnum.<br/>
		/// <br/>See also <seealso cref="DataItemTypeEnum">DataItemTypeEnum</seealso>
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
		/// Value for DataItemTypeEnum.<br/>
		/// <br/>See also <seealso cref="DataItemTypeEnum">DataItemTypeEnum</seealso>
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
		/// Value for DataItemTypeEnum.<br/>
		/// <br/>See also <seealso cref="DataItemTypeEnum">DataItemTypeEnum</seealso>
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
		/// Value for DataItemTypeEnum.<br/>
		/// <br/>See also <seealso cref="DataItemTypeEnum">DataItemTypeEnum</seealso>
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
		/// Value for DataItemTypeEnum.<br/>
		/// <br/>See also <seealso cref="DataItemTypeEnum">DataItemTypeEnum</seealso>
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
		/// Value for DataItemTypeEnum.<br/>
		/// <br/>See also <seealso cref="DataItemTypeEnum">DataItemTypeEnum</seealso>
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
		/// Value for DataItemTypeEnum.<br/>
		/// <br/>See also <seealso cref="DataItemTypeEnum">DataItemTypeEnum</seealso>
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
		/// Value for DataItemTypeEnum.<br/>
		/// <br/>See also <seealso cref="DataItemTypeEnum">DataItemTypeEnum</seealso>
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
		/// Value for DataItemTypeEnum.<br/>
		/// <br/>See also <seealso cref="DataItemTypeEnum">DataItemTypeEnum</seealso>
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
		/// Value for DataItemTypeEnum.<br/>
		/// <br/>See also <seealso cref="DataItemTypeEnum">DataItemTypeEnum</seealso>
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
		/// Value for DataItemTypeEnum.<br/>
		/// <br/>See also <seealso cref="DataItemTypeEnum">DataItemTypeEnum</seealso>
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
		/// Value for DataItemTypeEnum.<br/>
		/// <br/>See also <seealso cref="DataItemTypeEnum">DataItemTypeEnum</seealso>
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
		/// Value for DataItemTypeEnum.<br/>
		/// <br/>See also <seealso cref="DataItemTypeEnum">DataItemTypeEnum</seealso>
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
		/// Value for DataItemTypeEnum.<br/>
		/// <br/>See also <seealso cref="DataItemTypeEnum">DataItemTypeEnum</seealso>
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
		/// Value for DataItemTypeEnum.<br/>
		/// <br/>See also <seealso cref="DataItemTypeEnum">DataItemTypeEnum</seealso>
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
		/// Value for DataItemTypeEnum.<br/>
		/// <br/>See also <seealso cref="DataItemTypeEnum">DataItemTypeEnum</seealso>
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
		/// Value for DataItemTypeEnum.<br/>
		/// <br/>See also <seealso cref="DataItemTypeEnum">DataItemTypeEnum</seealso>
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
		/// Value for DataItemTypeEnum.<br/>
		/// <br/>See also <seealso cref="DataItemTypeEnum">DataItemTypeEnum</seealso>
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
		/// Value for DataItemTypeEnum.<br/>
		/// <br/>See also <seealso cref="DataItemTypeEnum">DataItemTypeEnum</seealso>
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
		/// Value for DataItemTypeEnum.<br/>
		/// <br/>See also <seealso cref="DataItemTypeEnum">DataItemTypeEnum</seealso>
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
		/// Value for DataItemTypeEnum.<br/>
		/// <br/>See also <seealso cref="DataItemTypeEnum">DataItemTypeEnum</seealso>
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
		/// Value for DataItemTypeEnum.<br/>
		/// <br/>See also <seealso cref="DataItemTypeEnum">DataItemTypeEnum</seealso>
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
		/// Value for DataItemTypeEnum.<br/>
		/// <br/>See also <seealso cref="DataItemTypeEnum">DataItemTypeEnum</seealso>
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
		/// Value for DataItemTypeEnum.<br/>
		/// <br/>See also <seealso cref="DataItemTypeEnum">DataItemTypeEnum</seealso>
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

		/// <summary>﻿identifier of the tool currently in use for a given <c>Path</c>.<br /><br /><b>DEPRECATED</b> in <i>Version 1.2.0</i>.   See <c>TOOL_NUMBER</c>.<br /><br /><br />
		/// Value for DataItemTypeEnum.<br/>
		/// <br/>See also <seealso cref="DataItemTypeEnum">DataItemTypeEnum</seealso>
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

**DEPRECATED** in *Version 1.2.0*.   See `TOOL_NUMBER`.&#10;
";

			/// <inheritdoc />
			public string Name => NAME;
			
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
		/// Value for DataItemTypeEnum.<br/>
		/// <br/>See also <seealso cref="DataItemTypeEnum">DataItemTypeEnum</seealso>
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
		/// Value for DataItemTypeEnum.<br/>
		/// <br/>See also <seealso cref="DataItemTypeEnum">DataItemTypeEnum</seealso>
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
		/// Value for DataItemTypeEnum.<br/>
		/// <br/>See also <seealso cref="DataItemTypeEnum">DataItemTypeEnum</seealso>
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
		/// Value for DataItemTypeEnum.<br/>
		/// <br/>See also <seealso cref="DataItemTypeEnum">DataItemTypeEnum</seealso>
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
		/// Value for DataItemTypeEnum.<br/>
		/// <br/>See also <seealso cref="DataItemTypeEnum">DataItemTypeEnum</seealso>
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
		/// Value for DataItemTypeEnum.<br/>
		/// <br/>See also <seealso cref="DataItemTypeEnum">DataItemTypeEnum</seealso>
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
		/// Value for DataItemTypeEnum.<br/>
		/// <br/>See also <seealso cref="DataItemTypeEnum">DataItemTypeEnum</seealso>
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
		/// Value for DataItemTypeEnum.<br/>
		/// <br/>See also <seealso cref="DataItemTypeEnum">DataItemTypeEnum</seealso>
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
		/// Value for DataItemTypeEnum.<br/>
		/// <br/>See also <seealso cref="DataItemTypeEnum">DataItemTypeEnum</seealso>
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
		/// Value for DataItemTypeEnum.<br/>
		/// <br/>See also <seealso cref="DataItemTypeEnum">DataItemTypeEnum</seealso>
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
		/// Value for DataItemTypeEnum.<br/>
		/// <br/>See also <seealso cref="DataItemTypeEnum">DataItemTypeEnum</seealso>
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
		/// Value for DataItemTypeEnum.<br/>
		/// <br/>See also <seealso cref="DataItemTypeEnum">DataItemTypeEnum</seealso>
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
		/// Value for DataItemTypeEnum.<br/>
		/// <br/>See also <seealso cref="DataItemTypeEnum">DataItemTypeEnum</seealso>
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
		/// Value for DataItemTypeEnum.<br/>
		/// <br/>See also <seealso cref="DataItemTypeEnum">DataItemTypeEnum</seealso>
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
		/// Value for DataItemTypeEnum.<br/>
		/// <br/>See also <seealso cref="DataItemTypeEnum">DataItemTypeEnum</seealso>
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
		/// Value for DataItemTypeEnum.<br/>
		/// <br/>See also <seealso cref="DataItemTypeEnum">DataItemTypeEnum</seealso>
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
		/// Value for DataItemTypeEnum.<br/>
		/// <br/>See also <seealso cref="DataItemTypeEnum">DataItemTypeEnum</seealso>
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
		/// Value for DataItemTypeEnum.<br/>
		/// <br/>See also <seealso cref="DataItemTypeEnum">DataItemTypeEnum</seealso>
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
		/// Value for DataItemTypeEnum.<br/>
		/// <br/>See also <seealso cref="DataItemTypeEnum">DataItemTypeEnum</seealso>
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
		/// Value for DataItemTypeEnum.<br/>
		/// <br/>See also <seealso cref="DataItemTypeEnum">DataItemTypeEnum</seealso>
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
		/// Value for DataItemTypeEnum.<br/>
		/// <br/>See also <seealso cref="DataItemTypeEnum">DataItemTypeEnum</seealso>
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
		/// Value for DataItemTypeEnum.<br/>
		/// <br/>See also <seealso cref="DataItemTypeEnum">DataItemTypeEnum</seealso>
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
		/// Value for DataItemTypeEnum.<br/>
		/// <br/>See also <seealso cref="DataItemTypeEnum">DataItemTypeEnum</seealso>
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
		/// Value for DataItemTypeEnum.<br/>
		/// <br/>See also <seealso cref="DataItemTypeEnum">DataItemTypeEnum</seealso>
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
		/// Value for DataItemTypeEnum.<br/>
		/// <br/>See also <seealso cref="DataItemTypeEnum">DataItemTypeEnum</seealso>
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
		/// Value for DataItemTypeEnum.<br/>
		/// <br/>See also <seealso cref="DataItemTypeEnum">DataItemTypeEnum</seealso>
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
		/// Value for DataItemTypeEnum.<br/>
		/// <br/>See also <seealso cref="DataItemTypeEnum">DataItemTypeEnum</seealso>
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
		/// Value for DataItemTypeEnum.<br/>
		/// <br/>See also <seealso cref="DataItemTypeEnum">DataItemTypeEnum</seealso>
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
		/// Value for DataItemTypeEnum.<br/>
		/// <br/>See also <seealso cref="DataItemTypeEnum">DataItemTypeEnum</seealso>
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
		/// Value for DataItemTypeEnum.<br/>
		/// <br/>See also <seealso cref="DataItemTypeEnum">DataItemTypeEnum</seealso>
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
		/// Value for DataItemTypeEnum.<br/>
		/// <br/>See also <seealso cref="DataItemTypeEnum">DataItemTypeEnum</seealso>
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

		/// <summary>﻿set of limits used to indicate whether a process variable is stable and in control.<br /><br /><b>DEPRECATED</b> in <i>Version 2.5</i>. Replaced by <c>CONTROL_LIMITS</c>.<br /><br /><br />
		/// Value for DataItemTypeEnum.<br/>
		/// <br/>See also <seealso cref="DataItemTypeEnum">DataItemTypeEnum</seealso>
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
			public const string DEPRECATED_VERSION = "2.5";
			/// <summary>Constant value for <see cref="CONTROL_LIMITValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;set of limits used to indicate whether a process variable is stable and in control.

**DEPRECATED** in *Version 2.5*. Replaced by `CONTROL_LIMITS`.&#10;
";

			/// <inheritdoc />
			public string Name => NAME;
			
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

		/// <summary>﻿set of limits defining a range of values designating acceptable performance for a variable.<br /><br /><b>DEPRECATED</b> in <i>Version 2.5</i>. Replaced by  <c>SPECIFICATION_LIMITS</c>.<br /><br /><br />
		/// Value for DataItemTypeEnum.<br/>
		/// <br/>See also <seealso cref="DataItemTypeEnum">DataItemTypeEnum</seealso>
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
			public const string DEPRECATED_VERSION = "2.5";
			/// <summary>Constant value for <see cref="SPECIFICATION_LIMITValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;set of limits defining a range of values designating acceptable performance for a variable.

**DEPRECATED** in *Version 2.5*. Replaced by  `SPECIFICATION_LIMITS`.&#10;
";

			/// <inheritdoc />
			public string Name => NAME;
			
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

		/// <summary>﻿set of limits used to trigger warning or alarm indicators.<br /><br /><b>DEPRECATED</b> in <i>Version 2.5</i>. Replaced by  <c>ALARM_LIMITS</c>.<br /><br /><br />
		/// Value for DataItemTypeEnum.<br/>
		/// <br/>See also <seealso cref="DataItemTypeEnum">DataItemTypeEnum</seealso>
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
			public const string DEPRECATED_VERSION = "2.5";
			/// <summary>Constant value for <see cref="ALARM_LIMITValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;set of limits used to trigger warning or alarm indicators.

**DEPRECATED** in *Version 2.5*. Replaced by  `ALARM_LIMITS`.&#10;
";

			/// <inheritdoc />
			public string Name => NAME;
			
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
		/// Value for DataItemTypeEnum.<br/>
		/// <br/>See also <seealso cref="DataItemTypeEnum">DataItemTypeEnum</seealso>
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
		/// Value for DataItemTypeEnum.<br/>
		/// <br/>See also <seealso cref="DataItemTypeEnum">DataItemTypeEnum</seealso>
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
		/// Value for DataItemTypeEnum.<br/>
		/// <br/>See also <seealso cref="DataItemTypeEnum">DataItemTypeEnum</seealso>
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
		/// Value for DataItemTypeEnum.<br/>
		/// <br/>See also <seealso cref="DataItemTypeEnum">DataItemTypeEnum</seealso>
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
		/// Value for DataItemTypeEnum.<br/>
		/// <br/>See also <seealso cref="DataItemTypeEnum">DataItemTypeEnum</seealso>
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
		/// Value for DataItemTypeEnum.<br/>
		/// <br/>See also <seealso cref="DataItemTypeEnum">DataItemTypeEnum</seealso>
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
		/// Value for DataItemTypeEnum.<br/>
		/// <br/>See also <seealso cref="DataItemTypeEnum">DataItemTypeEnum</seealso>
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
		/// Value for DataItemTypeEnum.<br/>
		/// <br/>See also <seealso cref="DataItemTypeEnum">DataItemTypeEnum</seealso>
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
		/// Value for DataItemTypeEnum.<br/>
		/// <br/>See also <seealso cref="DataItemTypeEnum">DataItemTypeEnum</seealso>
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
		/// Value for DataItemTypeEnum.<br/>
		/// <br/>See also <seealso cref="DataItemTypeEnum">DataItemTypeEnum</seealso>
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
		/// Value for DataItemTypeEnum.<br/>
		/// <br/>See also <seealso cref="DataItemTypeEnum">DataItemTypeEnum</seealso>
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
		/// Value for DataItemTypeEnum.<br/>
		/// <br/>See also <seealso cref="DataItemTypeEnum">DataItemTypeEnum</seealso>
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
		/// Value for DataItemTypeEnum.<br/>
		/// <br/>See also <seealso cref="DataItemTypeEnum">DataItemTypeEnum</seealso>
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
		/// Value for DataItemTypeEnum.<br/>
		/// <br/>See also <seealso cref="DataItemTypeEnum">DataItemTypeEnum</seealso>
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
		/// Value for DataItemTypeEnum.<br/>
		/// <br/>See also <seealso cref="DataItemTypeEnum">DataItemTypeEnum</seealso>
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
		/// Value for DataItemTypeEnum.<br/>
		/// <br/>See also <seealso cref="DataItemTypeEnum">DataItemTypeEnum</seealso>
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
		/// Value for DataItemTypeEnum.<br/>
		/// <br/>See also <seealso cref="DataItemTypeEnum">DataItemTypeEnum</seealso>
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
		/// Value for DataItemTypeEnum.<br/>
		/// <br/>See also <seealso cref="DataItemTypeEnum">DataItemTypeEnum</seealso>
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
		/// Value for DataItemTypeEnum.<br/>
		/// <br/>See also <seealso cref="DataItemTypeEnum">DataItemTypeEnum</seealso>
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
		/// Value for DataItemTypeEnum.<br/>
		/// <br/>See also <seealso cref="DataItemTypeEnum">DataItemTypeEnum</seealso>
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
		/// Value for DataItemTypeEnum.<br/>
		/// <br/>See also <seealso cref="DataItemTypeEnum">DataItemTypeEnum</seealso>
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
		/// Value for DataItemTypeEnum.<br/>
		/// <br/>See also <seealso cref="DataItemTypeEnum">DataItemTypeEnum</seealso>
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
		/// Value for DataItemTypeEnum.<br/>
		/// <br/>See also <seealso cref="DataItemTypeEnum">DataItemTypeEnum</seealso>
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
		/// Value for DataItemTypeEnum.<br/>
		/// <br/>See also <seealso cref="DataItemTypeEnum">DataItemTypeEnum</seealso>
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
		/// Value for DataItemTypeEnum.<br/>
		/// <br/>See also <seealso cref="DataItemTypeEnum">DataItemTypeEnum</seealso>
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
		/// Value for DataItemTypeEnum.<br/>
		/// <br/>See also <seealso cref="DataItemTypeEnum">DataItemTypeEnum</seealso>
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
		/// Value for DataItemTypeEnum.<br/>
		/// <br/>See also <seealso cref="DataItemTypeEnum">DataItemTypeEnum</seealso>
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
		/// Value for DataItemTypeEnum.<br/>
		/// <br/>See also <seealso cref="DataItemTypeEnum">DataItemTypeEnum</seealso>
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
		/// Value for DataItemTypeEnum.<br/>
		/// <br/>See also <seealso cref="DataItemTypeEnum">DataItemTypeEnum</seealso>
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
		/// Value for DataItemTypeEnum.<br/>
		/// <br/>See also <seealso cref="DataItemTypeEnum">DataItemTypeEnum</seealso>
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
		/// Value for DataItemTypeEnum.<br/>
		/// <br/>See also <seealso cref="DataItemTypeEnum">DataItemTypeEnum</seealso>
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
		/// Value for DataItemTypeEnum.<br/>
		/// <br/>See also <seealso cref="DataItemTypeEnum">DataItemTypeEnum</seealso>
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
		/// Value for DataItemTypeEnum.<br/>
		/// <br/>See also <seealso cref="DataItemTypeEnum">DataItemTypeEnum</seealso>
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
		/// Value for DataItemTypeEnum.<br/>
		/// <br/>See also <seealso cref="DataItemTypeEnum">DataItemTypeEnum</seealso>
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
		/// Value for DataItemTypeEnum.<br/>
		/// <br/>See also <seealso cref="DataItemTypeEnum">DataItemTypeEnum</seealso>
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
		/// Value for DataItemTypeEnum.<br/>
		/// <br/>See also <seealso cref="DataItemTypeEnum">DataItemTypeEnum</seealso>
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
		/// Value for DataItemTypeEnum.<br/>
		/// <br/>See also <seealso cref="DataItemTypeEnum">DataItemTypeEnum</seealso>
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
		/// Value for DataItemTypeEnum.<br/>
		/// <br/>See also <seealso cref="DataItemTypeEnum">DataItemTypeEnum</seealso>
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
		private ACTIVE_POWER_SOURCEValue _ACTIVE_POWER_SOURCE;
		/// <inheritdoc cref="ACTIVE_POWER_SOURCEValue" path="/summary" />
		public ACTIVE_POWER_SOURCEValue ACTIVE_POWER_SOURCE => _ACTIVE_POWER_SOURCE ?? (_ACTIVE_POWER_SOURCE = new ACTIVE_POWER_SOURCEValue());

		/// <summary>﻿active energy source for the <see cref="Component">Component</see>.<br /><br /><br />
		/// Value for DataItemTypeEnum.<br/>
		/// <br/>See also <seealso cref="DataItemTypeEnum">DataItemTypeEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		public sealed class ACTIVE_POWER_SOURCEValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="ACTIVE_POWER_SOURCEValue.Name" /></summary>
			public const string NAME = "ACTIVE_POWER_SOURCE";
			/// <summary>Constant value for <see cref="ACTIVE_POWER_SOURCEValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "2.3";
			/// <summary>Constant value for <see cref="ACTIVE_POWER_SOURCEValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="ACTIVE_POWER_SOURCEValue.Summary" /></summary>
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
		private LOCATION_NARRATIVEValue _LOCATION_NARRATIVE;
		/// <inheritdoc cref="LOCATION_NARRATIVEValue" path="/summary" />
		public LOCATION_NARRATIVEValue LOCATION_NARRATIVE => _LOCATION_NARRATIVE ?? (_LOCATION_NARRATIVE = new LOCATION_NARRATIVEValue());

		/// <summary>﻿textual description of the location of an object or activity.<br /><br /><br />
		/// Value for DataItemTypeEnum.<br/>
		/// <br/>See also <seealso cref="DataItemTypeEnum">DataItemTypeEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		public sealed class LOCATION_NARRATIVEValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="LOCATION_NARRATIVEValue.Name" /></summary>
			public const string NAME = "LOCATION_NARRATIVE";
			/// <summary>Constant value for <see cref="LOCATION_NARRATIVEValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "2.4";
			/// <summary>Constant value for <see cref="LOCATION_NARRATIVEValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="LOCATION_NARRATIVEValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;textual description of the location of an object or activity.&#10;
";

			/// <inheritdoc />
			public string Name => NAME;
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => NORMATIVE_VERSION;
			
			/// <inheritdoc />
			public string DeprecatedVersion => DEPRECATED_VERSION;
			
			/// <inheritdoc />
			public string Summary => SUMMARY;
		}
		private THICKNESSValue _THICKNESS;
		/// <inheritdoc cref="THICKNESSValue" path="/summary" />
		public THICKNESSValue THICKNESS => _THICKNESS ?? (_THICKNESS = new THICKNESSValue());

		/// <summary>﻿dimension between two surfaces of an object, usually the dimension of smallest measure, for example an additive layer, or a depth of cut.<br /><br /><br />
		/// Value for DataItemTypeEnum.<br/>
		/// <br/>See also <seealso cref="DataItemTypeEnum">DataItemTypeEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		public sealed class THICKNESSValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="THICKNESSValue.Name" /></summary>
			public const string NAME = "THICKNESS";
			/// <summary>Constant value for <see cref="THICKNESSValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "2.4";
			/// <summary>Constant value for <see cref="THICKNESSValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="THICKNESSValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;dimension between two surfaces of an object, usually the dimension of smallest measure, for example an additive layer, or a depth of cut.&#10;
";

			/// <inheritdoc />
			public string Name => NAME;
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => NORMATIVE_VERSION;
			
			/// <inheritdoc />
			public string DeprecatedVersion => DEPRECATED_VERSION;
			
			/// <inheritdoc />
			public string Summary => SUMMARY;
		}
		private LOCATION_SPATIAL_GEOGRAPHICValue _LOCATION_SPATIAL_GEOGRAPHIC;
		/// <inheritdoc cref="LOCATION_SPATIAL_GEOGRAPHICValue" path="/summary" />
		public LOCATION_SPATIAL_GEOGRAPHICValue LOCATION_SPATIAL_GEOGRAPHIC => _LOCATION_SPATIAL_GEOGRAPHIC ?? (_LOCATION_SPATIAL_GEOGRAPHIC = new LOCATION_SPATIAL_GEOGRAPHICValue());

		/// <summary>﻿absolute geographic location defined by two coordinates, longitude and latitude and an elevation.<br /><br /><br />
		/// Value for DataItemTypeEnum.<br/>
		/// <br/>See also <seealso cref="DataItemTypeEnum">DataItemTypeEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		public sealed class LOCATION_SPATIAL_GEOGRAPHICValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="LOCATION_SPATIAL_GEOGRAPHICValue.Name" /></summary>
			public const string NAME = "LOCATION_SPATIAL_GEOGRAPHIC";
			/// <summary>Constant value for <see cref="LOCATION_SPATIAL_GEOGRAPHICValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "2.4";
			/// <summary>Constant value for <see cref="LOCATION_SPATIAL_GEOGRAPHICValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="LOCATION_SPATIAL_GEOGRAPHICValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;absolute geographic location defined by two coordinates, longitude and latitude and an elevation.&#10;
";

			/// <inheritdoc />
			public string Name => NAME;
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => NORMATIVE_VERSION;
			
			/// <inheritdoc />
			public string DeprecatedVersion => DEPRECATED_VERSION;
			
			/// <inheritdoc />
			public string Summary => SUMMARY;
		}
		private PART_INDEXValue _PART_INDEX;
		/// <inheritdoc cref="PART_INDEXValue" path="/summary" />
		public PART_INDEXValue PART_INDEX => _PART_INDEX ?? (_PART_INDEX = new PART_INDEXValue());

		/// <summary>﻿sequence of a part in a group of parts.<br /><br /><br />
		/// Value for DataItemTypeEnum.<br/>
		/// <br/>See also <seealso cref="DataItemTypeEnum">DataItemTypeEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		public sealed class PART_INDEXValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="PART_INDEXValue.Name" /></summary>
			public const string NAME = "PART_INDEX";
			/// <summary>Constant value for <see cref="PART_INDEXValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "2.5";
			/// <summary>Constant value for <see cref="PART_INDEXValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="PART_INDEXValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;sequence of a part in a group of parts.&#10;
";

			/// <inheritdoc />
			public string Name => NAME;
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => NORMATIVE_VERSION;
			
			/// <inheritdoc />
			public string DeprecatedVersion => DEPRECATED_VERSION;
			
			/// <inheritdoc />
			public string Summary => SUMMARY;
		}
		private ASSOCIATED_ASSET_IDValue _ASSOCIATED_ASSET_ID;
		/// <inheritdoc cref="ASSOCIATED_ASSET_IDValue" path="/summary" />
		public ASSOCIATED_ASSET_IDValue ASSOCIATED_ASSET_ID => _ASSOCIATED_ASSET_ID ?? (_ASSOCIATED_ASSET_ID = new ASSOCIATED_ASSET_IDValue());

		/// <summary>﻿<see cref="Asset.assetId">assetId in Asset</see> of the <see cref="Asset">Asset</see>s associated with a <see cref="Component">Component</see>.<br /><br /><br />
		/// Value for DataItemTypeEnum.<br/>
		/// <br/>See also <seealso cref="DataItemTypeEnum">DataItemTypeEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		public sealed class ASSOCIATED_ASSET_IDValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="ASSOCIATED_ASSET_IDValue.Name" /></summary>
			public const string NAME = "ASSOCIATED_ASSET_ID";
			/// <summary>Constant value for <see cref="ASSOCIATED_ASSET_IDValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "2.6";
			/// <summary>Constant value for <see cref="ASSOCIATED_ASSET_IDValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="ASSOCIATED_ASSET_IDValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;{{property(Asset::assetId)}} of the {{block(Asset)}}s associated with a {{block(Component)}}.&#10;
";

			/// <inheritdoc />
			public string Name => NAME;
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => NORMATIVE_VERSION;
			
			/// <inheritdoc />
			public string DeprecatedVersion => DEPRECATED_VERSION;
			
			/// <inheritdoc />
			public string Summary => SUMMARY;
		}
		private ASSET_ADDEDValue _ASSET_ADDED;
		/// <inheritdoc cref="ASSET_ADDEDValue" path="/summary" />
		public ASSET_ADDEDValue ASSET_ADDED => _ASSET_ADDED ?? (_ASSET_ADDED = new ASSET_ADDEDValue());

		/// <summary>﻿<see cref="Asset.assetId">assetId in Asset</see> of the <see cref="Asset">Asset</see> that has been added.<br /><br /><br />
		/// Value for DataItemTypeEnum.<br/>
		/// <br/>See also <seealso cref="DataItemTypeEnum">DataItemTypeEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		public sealed class ASSET_ADDEDValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="ASSET_ADDEDValue.Name" /></summary>
			public const string NAME = "ASSET_ADDED";
			/// <summary>Constant value for <see cref="ASSET_ADDEDValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "2.6";
			/// <summary>Constant value for <see cref="ASSET_ADDEDValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="ASSET_ADDEDValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;{{property(Asset::assetId)}} of the {{block(Asset)}} that has been added.&#10;
";

			/// <inheritdoc />
			public string Name => NAME;
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => NORMATIVE_VERSION;
			
			/// <inheritdoc />
			public string DeprecatedVersion => DEPRECATED_VERSION;
			
			/// <inheritdoc />
			public string Summary => SUMMARY;
		}
		private INTERFACE_STATEValue _INTERFACE_STATE;
		/// <inheritdoc cref="INTERFACE_STATEValue" path="/summary" />
		public INTERFACE_STATEValue INTERFACE_STATE => _INTERFACE_STATE ?? (_INTERFACE_STATE = new INTERFACE_STATEValue());

		/// <summary>﻿operational state of an <see cref="Interface">Interface</see>.<br /><br /><br />
		/// Value for DataItemTypeEnum.<br/>
		/// <br/>See also <seealso cref="DataItemTypeEnum">DataItemTypeEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		public sealed class INTERFACE_STATEValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="INTERFACE_STATEValue.Name" /></summary>
			public const string NAME = "INTERFACE_STATE";
			/// <summary>Constant value for <see cref="INTERFACE_STATEValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.3";
			/// <summary>Constant value for <see cref="INTERFACE_STATEValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="INTERFACE_STATEValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;operational state of an {{block(Interface)}}.&#10;
";

			/// <inheritdoc />
			public string Name => NAME;
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => NORMATIVE_VERSION;
			
			/// <inheritdoc />
			public string DeprecatedVersion => DEPRECATED_VERSION;
			
			/// <inheritdoc />
			public string Summary => SUMMARY;
		}
		private MATERIAL_FEEDValue _MATERIAL_FEED;
		/// <inheritdoc cref="MATERIAL_FEEDValue" path="/summary" />
		public MATERIAL_FEEDValue MATERIAL_FEED => _MATERIAL_FEED ?? (_MATERIAL_FEED = new MATERIAL_FEEDValue());

		/// <summary>﻿operating state of the service to advance material or feed product to a piece of equipment from a continuous or bulk source.<br /><br /><br />
		/// Value for DataItemTypeEnum.<br/>
		/// <br/>See also <seealso cref="DataItemTypeEnum">DataItemTypeEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		public sealed class MATERIAL_FEEDValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="MATERIAL_FEEDValue.Name" /></summary>
			public const string NAME = "MATERIAL_FEED";
			/// <summary>Constant value for <see cref="MATERIAL_FEEDValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.3";
			/// <summary>Constant value for <see cref="MATERIAL_FEEDValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="MATERIAL_FEEDValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;operating state of the service to advance material or feed product to a piece of equipment from a continuous or bulk source.&#10;
";

			/// <inheritdoc />
			public string Name => NAME;
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => NORMATIVE_VERSION;
			
			/// <inheritdoc />
			public string DeprecatedVersion => DEPRECATED_VERSION;
			
			/// <inheritdoc />
			public string Summary => SUMMARY;
		}
		private MATERIAL_CHANGEValue _MATERIAL_CHANGE;
		/// <inheritdoc cref="MATERIAL_CHANGEValue" path="/summary" />
		public MATERIAL_CHANGEValue MATERIAL_CHANGE => _MATERIAL_CHANGE ?? (_MATERIAL_CHANGE = new MATERIAL_CHANGEValue());

		/// <summary>﻿operating state of the service to change the type of material or product being loaded or fed to a piece of equipment.<br /><br /><br />
		/// Value for DataItemTypeEnum.<br/>
		/// <br/>See also <seealso cref="DataItemTypeEnum">DataItemTypeEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		public sealed class MATERIAL_CHANGEValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="MATERIAL_CHANGEValue.Name" /></summary>
			public const string NAME = "MATERIAL_CHANGE";
			/// <summary>Constant value for <see cref="MATERIAL_CHANGEValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.3";
			/// <summary>Constant value for <see cref="MATERIAL_CHANGEValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="MATERIAL_CHANGEValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;operating state of the service to change the type of material or product being loaded or fed to a piece of equipment.&#10;
";

			/// <inheritdoc />
			public string Name => NAME;
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => NORMATIVE_VERSION;
			
			/// <inheritdoc />
			public string DeprecatedVersion => DEPRECATED_VERSION;
			
			/// <inheritdoc />
			public string Summary => SUMMARY;
		}
		private MATERIAL_RETRACTValue _MATERIAL_RETRACT;
		/// <inheritdoc cref="MATERIAL_RETRACTValue" path="/summary" />
		public MATERIAL_RETRACTValue MATERIAL_RETRACT => _MATERIAL_RETRACT ?? (_MATERIAL_RETRACT = new MATERIAL_RETRACTValue());

		/// <summary>﻿operating state of the service to remove or retract material or product.<br /><br /><br />
		/// Value for DataItemTypeEnum.<br/>
		/// <br/>See also <seealso cref="DataItemTypeEnum">DataItemTypeEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		public sealed class MATERIAL_RETRACTValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="MATERIAL_RETRACTValue.Name" /></summary>
			public const string NAME = "MATERIAL_RETRACT";
			/// <summary>Constant value for <see cref="MATERIAL_RETRACTValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.3";
			/// <summary>Constant value for <see cref="MATERIAL_RETRACTValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="MATERIAL_RETRACTValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;operating state of the service to remove or retract material or product.&#10;
";

			/// <inheritdoc />
			public string Name => NAME;
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => NORMATIVE_VERSION;
			
			/// <inheritdoc />
			public string DeprecatedVersion => DEPRECATED_VERSION;
			
			/// <inheritdoc />
			public string Summary => SUMMARY;
		}
		private PART_CHANGEValue _PART_CHANGE;
		/// <inheritdoc cref="PART_CHANGEValue" path="/summary" />
		public PART_CHANGEValue PART_CHANGE => _PART_CHANGE ?? (_PART_CHANGE = new PART_CHANGEValue());

		/// <summary>﻿operating state of the service to change the part or product associated with a piece of equipment to a different part or product.<br /><br /><br />
		/// Value for DataItemTypeEnum.<br/>
		/// <br/>See also <seealso cref="DataItemTypeEnum">DataItemTypeEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		public sealed class PART_CHANGEValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="PART_CHANGEValue.Name" /></summary>
			public const string NAME = "PART_CHANGE";
			/// <summary>Constant value for <see cref="PART_CHANGEValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.3";
			/// <summary>Constant value for <see cref="PART_CHANGEValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="PART_CHANGEValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;operating state of the service to change the part or product associated with a piece of equipment to a different part or product.&#10;
";

			/// <inheritdoc />
			public string Name => NAME;
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => NORMATIVE_VERSION;
			
			/// <inheritdoc />
			public string DeprecatedVersion => DEPRECATED_VERSION;
			
			/// <inheritdoc />
			public string Summary => SUMMARY;
		}
		private MATERIAL_LOADValue _MATERIAL_LOAD;
		/// <inheritdoc cref="MATERIAL_LOADValue" path="/summary" />
		public MATERIAL_LOADValue MATERIAL_LOAD => _MATERIAL_LOAD ?? (_MATERIAL_LOAD = new MATERIAL_LOADValue());

		/// <summary>﻿operating state of the service to load a piece of material or product.<br /><br /><br />
		/// Value for DataItemTypeEnum.<br/>
		/// <br/>See also <seealso cref="DataItemTypeEnum">DataItemTypeEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		public sealed class MATERIAL_LOADValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="MATERIAL_LOADValue.Name" /></summary>
			public const string NAME = "MATERIAL_LOAD";
			/// <summary>Constant value for <see cref="MATERIAL_LOADValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.3";
			/// <summary>Constant value for <see cref="MATERIAL_LOADValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="MATERIAL_LOADValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;operating state of the service to load a piece of material or product.&#10;
";

			/// <inheritdoc />
			public string Name => NAME;
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => NORMATIVE_VERSION;
			
			/// <inheritdoc />
			public string DeprecatedVersion => DEPRECATED_VERSION;
			
			/// <inheritdoc />
			public string Summary => SUMMARY;
		}
		private MATERIAL_UNLOADValue _MATERIAL_UNLOAD;
		/// <inheritdoc cref="MATERIAL_UNLOADValue" path="/summary" />
		public MATERIAL_UNLOADValue MATERIAL_UNLOAD => _MATERIAL_UNLOAD ?? (_MATERIAL_UNLOAD = new MATERIAL_UNLOADValue());

		/// <summary>﻿operating state of the service to unload a piece of material or product.<br /><br /><br />
		/// Value for DataItemTypeEnum.<br/>
		/// <br/>See also <seealso cref="DataItemTypeEnum">DataItemTypeEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		public sealed class MATERIAL_UNLOADValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="MATERIAL_UNLOADValue.Name" /></summary>
			public const string NAME = "MATERIAL_UNLOAD";
			/// <summary>Constant value for <see cref="MATERIAL_UNLOADValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.3";
			/// <summary>Constant value for <see cref="MATERIAL_UNLOADValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="MATERIAL_UNLOADValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;operating state of the service to unload a piece of material or product.&#10;
";

			/// <inheritdoc />
			public string Name => NAME;
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => NORMATIVE_VERSION;
			
			/// <inheritdoc />
			public string DeprecatedVersion => DEPRECATED_VERSION;
			
			/// <inheritdoc />
			public string Summary => SUMMARY;
		}
		private OPEN_CHUCKValue _OPEN_CHUCK;
		/// <inheritdoc cref="OPEN_CHUCKValue" path="/summary" />
		public OPEN_CHUCKValue OPEN_CHUCK => _OPEN_CHUCK ?? (_OPEN_CHUCK = new OPEN_CHUCKValue());

		/// <summary>﻿operating state of the service to open a chuck.<br /><br /><br />
		/// Value for DataItemTypeEnum.<br/>
		/// <br/>See also <seealso cref="DataItemTypeEnum">DataItemTypeEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		public sealed class OPEN_CHUCKValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="OPEN_CHUCKValue.Name" /></summary>
			public const string NAME = "OPEN_CHUCK";
			/// <summary>Constant value for <see cref="OPEN_CHUCKValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.3";
			/// <summary>Constant value for <see cref="OPEN_CHUCKValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="OPEN_CHUCKValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;operating state of the service to open a chuck.&#10;
";

			/// <inheritdoc />
			public string Name => NAME;
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => NORMATIVE_VERSION;
			
			/// <inheritdoc />
			public string DeprecatedVersion => DEPRECATED_VERSION;
			
			/// <inheritdoc />
			public string Summary => SUMMARY;
		}
		private OPEN_DOORValue _OPEN_DOOR;
		/// <inheritdoc cref="OPEN_DOORValue" path="/summary" />
		public OPEN_DOORValue OPEN_DOOR => _OPEN_DOOR ?? (_OPEN_DOOR = new OPEN_DOORValue());

		/// <summary>﻿operating state of the service to open a door.<br /><br /><br />
		/// Value for DataItemTypeEnum.<br/>
		/// <br/>See also <seealso cref="DataItemTypeEnum">DataItemTypeEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		public sealed class OPEN_DOORValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="OPEN_DOORValue.Name" /></summary>
			public const string NAME = "OPEN_DOOR";
			/// <summary>Constant value for <see cref="OPEN_DOORValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.3";
			/// <summary>Constant value for <see cref="OPEN_DOORValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="OPEN_DOORValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;operating state of the service to open a door.&#10;
";

			/// <inheritdoc />
			public string Name => NAME;
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => NORMATIVE_VERSION;
			
			/// <inheritdoc />
			public string DeprecatedVersion => DEPRECATED_VERSION;
			
			/// <inheritdoc />
			public string Summary => SUMMARY;
		}
		private CLOSE_CHUCKValue _CLOSE_CHUCK;
		/// <inheritdoc cref="CLOSE_CHUCKValue" path="/summary" />
		public CLOSE_CHUCKValue CLOSE_CHUCK => _CLOSE_CHUCK ?? (_CLOSE_CHUCK = new CLOSE_CHUCKValue());

		/// <summary>﻿operating state of the service to close a chuck.<br /><br /><br />
		/// Value for DataItemTypeEnum.<br/>
		/// <br/>See also <seealso cref="DataItemTypeEnum">DataItemTypeEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		public sealed class CLOSE_CHUCKValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="CLOSE_CHUCKValue.Name" /></summary>
			public const string NAME = "CLOSE_CHUCK";
			/// <summary>Constant value for <see cref="CLOSE_CHUCKValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.3";
			/// <summary>Constant value for <see cref="CLOSE_CHUCKValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="CLOSE_CHUCKValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;operating state of the service to close a chuck.&#10;
";

			/// <inheritdoc />
			public string Name => NAME;
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => NORMATIVE_VERSION;
			
			/// <inheritdoc />
			public string DeprecatedVersion => DEPRECATED_VERSION;
			
			/// <inheritdoc />
			public string Summary => SUMMARY;
		}
		private CLOSE_DOORValue _CLOSE_DOOR;
		/// <inheritdoc cref="CLOSE_DOORValue" path="/summary" />
		public CLOSE_DOORValue CLOSE_DOOR => _CLOSE_DOOR ?? (_CLOSE_DOOR = new CLOSE_DOORValue());

		/// <summary>﻿operating state of the service to close a door.<br /><br /><br />
		/// Value for DataItemTypeEnum.<br/>
		/// <br/>See also <seealso cref="DataItemTypeEnum">DataItemTypeEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>

		public sealed class CLOSE_DOORValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="CLOSE_DOORValue.Name" /></summary>
			public const string NAME = "CLOSE_DOOR";
			/// <summary>Constant value for <see cref="CLOSE_DOORValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.3";
			/// <summary>Constant value for <see cref="CLOSE_DOORValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="CLOSE_DOORValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;operating state of the service to close a door.&#10;
";

			/// <inheritdoc />
			public string Name => NAME;
			
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