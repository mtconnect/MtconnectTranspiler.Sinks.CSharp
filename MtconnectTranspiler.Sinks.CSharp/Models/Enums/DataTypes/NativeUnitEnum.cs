#pragma warning disable 0618
#pragma warning disable 1574
using System;
using System.CodeDom.Compiler;

namespace Mtconnect.DataTypes
{
	/// <summary>
	/// View in the MTConnect Model browser <seealso href="https://model.mtconnect.org/#Enumeration__EAID_678122A4_E8FD_4243_8427_6B7E0E78D5F5">model.mtconnect.org</seealso>
	/// </summary>
	/// <remarks>
	/// <list type="bullet">
	/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_">v</see></item>
	/// <item><b>Deprecated</b>: <see href="https://model.mtconnect.org/#_Version_">v</see></item>
	/// </list>
	/// </remarks>
	[Obsolete("Deprecated in v according to https://model.mtconnect.org/#_Version_")]
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "1.0.15.3")]
	public enum NativeUnitEnum
	{
		/// <summary>
		/// measure of viscosity.
		/// </summary>
		CENTIPOISE,
		/// <summary>
		/// rotational velocity in degrees per minute.
		/// </summary>
		DEGREE_PER_MINUTE,
		/// <summary>
		/// temperature in Fahrenheit.
		/// </summary>
		FAHRENHEIT,
		/// <summary>
		/// feet.
		/// </summary>
		FOOT,
		/// <summary>
		/// feet per minute.
		/// </summary>
		FOOT_PER_MINUTE,
		/// <summary>
		/// feet per second.
		/// </summary>
		FOOT_PER_SECOND,
		/// <summary>
		/// acceleration in feet per second squared.
		/// </summary>
		FOOT_PER_SECOND_SQUARED,
		/// <summary>
		/// point in space identified by X, Y, and Z positions and represented by a space-delimited set of numbers each expressed in feet.
		/// </summary>
		FOOT_3D,
		/// <summary>
		/// gallons per minute.
		/// </summary>
		GALLON_PER_MINUTE,
		/// <summary>
		/// measurement of time in hours.
		/// </summary>
		HOUR,
		/// <summary>
		/// inches.
		/// </summary>
		INCH,
		/// <summary>
		/// inches per minute.
		/// </summary>
		INCH_PER_MINUTE,
		/// <summary>
		/// inches per second.
		/// </summary>
		INCH_PER_SECOND,
		/// <summary>
		/// acceleration in inches per second squared.
		/// </summary>
		INCH_PER_SECOND_SQUARED,
		/// <summary>
		/// measure of torque in inch pounds.
		/// </summary>
		INCH_POUND,
		/// <summary>
		/// point in space identified by X, Y, and Z positions and represented by a space-delimited set of numbers each expressed in inches.
		/// </summary>
		INCH_3D,
		/// <summary>
		/// measurement of temperature.
		/// </summary>
		KELVIN,
		/// <summary>
		/// measurement in kilowatt.
		/// </summary>
		KILOWATT,
		/// <summary>
		/// kilowatt hours which is 3.6 mega joules.
		/// </summary>
		KILOWATT_HOUR,
		/// <summary>
		/// measurement of rate of flow of a fluid.
		/// </summary>
		LITER_PER_MINUTE,
		/// <summary>
		/// velocity in millimeters per minute.
		/// </summary>
		MILLIMETER_PER_MINUTE,
		/// <summary>
		/// measurement of time in minutes.
		/// </summary>
		MINUTE,
		/// <summary>
		/// unsupported unit.
		/// </summary>
		OTHER,
		/// <summary>
		/// US pounds.
		/// </summary>
		POUND,
		/// <summary>
		/// pressure in pounds per square inch (PSI).
		/// </summary>
		POUND_PER_INCH_SQUARED,
		/// <summary>
		/// angle in radians.
		/// </summary>
		RADIAN,
		/// <summary>
		/// velocity in radians per minute.
		/// </summary>
		RADIAN_PER_MINUTE,
		/// <summary>
		/// rotational acceleration in radian per second squared.
		/// </summary>
		RADIAN_PER_SECOND,
		/// <summary>
		/// rotational acceleration in radian per second squared.
		/// </summary>
		RADIAN_PER_SECOND_SQUARED,
		/// <summary>
		/// pressure in Bar.
		/// </summary>
		BAR,
		/// <summary>
		/// pressure in Torr.
		/// </summary>
		TORR,
		/// <summary>
		/// pressure in Millimeter of Mercury (mmHg).
		/// </summary>
		MILLIMETER_MERCURY,
		/// <summary>
		/// pascal per minute.
		/// </summary>
		PASCAL_PER_MINUTE,
		/// <summary>
		/// <i>MASS\times GRAVITATIONAL_ACCELERATION</i>s (g) given in <c>METER/SECOND^2</c>.
		/// </summary>
		GRAVITATIONAL_FORCE,
		/// <summary>
		/// acceleration relative to earth's gravity given in <c>METER/SECOND^2</c>.  > Note 1 to entry: At different points on Earth's surface, the free-fall acceleration ranges from 9.764 to 9.834 m/s2 (Wikipedia: Gravitational Acceleration). The constant can be customized depending on the location in the universe.  > Note 2 to entry: In the standard, it is assumed that Earth's average value of gravitational acceleration is 9.90665 m/s2.
		/// </summary>
		GRAVITATIONAL_ACCELERATION,
		/// <summary>
		/// electric charge in ampere hour.
		/// </summary>
		AMPERE_HOUR,
		/// <summary>
		/// change of geometric volume in cubic foot per hour.
		/// </summary>
		CUBIC_FOOT_PER_HOUR,
		/// <summary>
		/// change of geometric volume in cubic foot per minute.
		/// </summary>
		CUBIC_FOOT_PER_MINUTE,
	}
}