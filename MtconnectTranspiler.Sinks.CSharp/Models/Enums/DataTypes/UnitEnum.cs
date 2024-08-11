using System;
using System.CodeDom.Compiler;using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;

namespace Mtconnect.DataTypes
{
	/// <summary>
	/// View in the MTConnect Model browser <seealso href="https://model.mtconnect.org/#Enumeration__EAID_8FEC81E4_8E1F_4f45_820B_F9F25DD83F9A">model.mtconnect.org</seealso>
	/// </summary>
	/// <remarks>
	/// <list type="bullet">
	/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
	/// </list>
	/// </remarks>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.3.0.0")]
	public enum UnitEnum
	{
		/// <summary>
		/// amps.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>
		AMPERE,
		/// <summary>
		/// degrees Celsius.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>
		CELSIUS,
		/// <summary>
		/// count of something.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>
		COUNT,
		/// <summary>
		/// sound level.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.2">v1.2</see></item>
		/// </list>
		/// </remarks>
		DECIBEL,
		/// <summary>
		/// angle in degrees.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>
		DEGREE,
		/// <summary>
		/// space-delimited, floating-point representation of the angular rotation in degrees around the X, Y, and Z axes relative to a cartesian coordinate system respectively in order as A, B, and C.   If any of the rotations is not known, it <b>MUST</b> be zero (0).
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.6">v1.6</see></item>
		/// </list>
		/// </remarks>
		DEGREE_3D,
		/// <summary>
		/// angular degrees per second.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>
		DEGREE_PER_SECOND,
		/// <summary>
		/// angular acceleration in degrees per second squared.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>
		DEGREE_PER_SECOND_SQUARED,
		/// <summary>
		/// frequency measured in cycles per second.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>
		HERTZ,
		/// <summary>
		/// measurement of energy.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.1">v1.1</see></item>
		/// </list>
		/// </remarks>
		JOULE,
		/// <summary>
		/// kilograms.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>
		KILOGRAM,
		/// <summary>
		/// measurement of volume of a fluid.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>
		LITER,
		/// <summary>
		/// liters per second.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.2">v1.2</see></item>
		/// </list>
		/// </remarks>
		LITER_PER_SECOND,
		/// <summary>
		/// measurement of tilt.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.2">v1.2</see></item>
		/// </list>
		/// </remarks>
		MICRO_RADIAN,
		/// <summary>
		/// millimeters.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>
		MILLIMETER,
		/// <summary>
		/// point in space identified by X, Y, and Z positions and represented by a space-delimited set of numbers each expressed in millimeters.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.1">v1.1</see></item>
		/// </list>
		/// </remarks>
		MILLIMETER_3D,
		/// <summary>
		/// millimeters per revolution.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.5">v1.5</see></item>
		/// </list>
		/// </remarks>
		MILLIMETER_PER_REVOLUTION,
		/// <summary>
		/// millimeters per second.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>
		MILLIMETER_PER_SECOND,
		/// <summary>
		/// acceleration in millimeters per second squared.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>
		MILLIMETER_PER_SECOND_SQUARED,
		/// <summary>
		/// force in Newtons.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>
		NEWTON,
		/// <summary>
		/// torque, a unit for force times distance.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>
		NEWTON_METER,
		/// <summary>
		/// measure of electrical resistance.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.2">v1.2</see></item>
		/// </list>
		/// </remarks>
		OHM,
		/// <summary>
		/// pressure in Newtons per square meter.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>
		PASCAL,
		/// <summary>
		/// measurement of viscosity.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.2">v1.2</see></item>
		/// </list>
		/// </remarks>
		PASCAL_SECOND,
		/// <summary>
		/// percentage.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>
		PERCENT,
		/// <summary>
		/// measure of the acidity or alkalinity of a solution.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.1">v1.1</see></item>
		/// </list>
		/// </remarks>
		PH,
		/// <summary>
		/// revolutions per minute.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>
		REVOLUTION_PER_MINUTE,
		/// <summary>
		/// measurement of time.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>
		SECOND,
		/// <summary>
		/// measurement of electrical conductivity.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.2">v1.2</see></item>
		/// </list>
		/// </remarks>
		SIEMENS_PER_METER,
		/// <summary>
		/// volts.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>
		VOLT,
		/// <summary>
		/// measurement of the apparent power in an electrical circuit, equal to the product of root-mean-square (RMS) voltage and RMS current (commonly referred to as VA).
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.2">v1.2</see></item>
		/// </list>
		/// </remarks>
		VOLT_AMPERE,
		/// <summary>
		/// measurement of reactive power in an AC electrical circuit (commonly referred to as VAR).
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.2">v1.2</see></item>
		/// </list>
		/// </remarks>
		VOLT_AMPERE_REACTIVE,
		/// <summary>
		/// watts.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>
		WATT,
		/// <summary>
		/// measurement of electrical energy, equal to one Joule.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.2">v1.2</see></item>
		/// </list>
		/// </remarks>
		WATT_SECOND,
		/// <summary>
		/// gram per cubic meter.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.6">v1.6</see></item>
		/// </list>
		/// </remarks>
		GRAM_PER_CUBIC_METER,
		/// <summary>
		/// geometric volume in millimeters.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.5">v1.5</see></item>
		/// </list>
		/// </remarks>
		CUBIC_MILLIMETER,
		/// <summary>
		/// change of geometric volume per second.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.5">v1.5</see></item>
		/// </list>
		/// </remarks>
		CUBIC_MILLIMETER_PER_SECOND,
		/// <summary>
		/// change in geometric volume per second squared.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.5">v1.5</see></item>
		/// </list>
		/// </remarks>
		CUBIC_MILLIMETER_PER_SECOND_SQUARED,
		/// <summary>
		/// milligram.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.5">v1.5</see></item>
		/// </list>
		/// </remarks>
		MILLIGRAM,
		/// <summary>
		/// milligram per cubic millimeter.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.5">v1.5</see></item>
		/// </list>
		/// </remarks>
		MILLIGRAM_PER_CUBIC_MILLIMETER,
		/// <summary>
		/// milliliter.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.5">v1.5</see></item>
		/// </list>
		/// </remarks>
		MILLILITER,
		/// <summary>
		/// counts per second.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.7">v1.7</see></item>
		/// </list>
		/// </remarks>
		COUNT_PER_SECOND,
		/// <summary>
		/// pascal per second.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.7">v1.7</see></item>
		/// </list>
		/// </remarks>
		PASCAL_PER_SECOND,
		/// <summary>
		/// 3D Unit Vector.  Space delimited list of three floating point numbers.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.7">v1.7</see></item>
		/// </list>
		/// </remarks>
		UNIT_VECTOR_3D,
		/// <summary>
		/// revolutions per second squared.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.6">v1.6</see></item>
		/// </list>
		/// </remarks>
		REVOLUTION_PER_SECOND_SQUARED,
		/// <summary>
		/// rotational velocity in revolution per second.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.1">v1.1</see></item>
		/// </list>
		/// </remarks>
		REVOLUTION_PER_SECOND,
		/// <summary>
		/// gram.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.2">v1.2</see></item>
		/// </list>
		/// </remarks>
		GRAM,
		/// <summary>
		/// acceleration in meters per second squared.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_2.1">v2.1</see></item>
		/// </list>
		/// </remarks>
		METER_PER_SECOND_SQUARED,
		/// <summary>
		/// electric charge in coulombs (C).
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_2.1">v2.1</see></item>
		/// </list>
		/// </remarks>
		COULOMB,
	}

	/// <summary>
	/// View in the MTConnect Model browser <seealso href="https://model.mtconnect.org/#Enumeration__EAID_8FEC81E4_8E1F_4f45_820B_F9F25DD83F9A">model.mtconnect.org</seealso>
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.3.0.0")]
	public sealed class UnitEnumMetaClass : IEnum
	{
		/// <inheritdoc />
		public string Name => "UnitEnum";
		
		/// <inheritdoc />
		public Type DataType => null;
		
		public Type Instance => typeof(UnitEnum);

		/// <inheritdoc />
		public string NormativeVersion => "1.0";
		
		/// <inheritdoc />
		public string DeprecatedVersion => "";
		
		/// <inheritdoc />
		public string Summary => @"";
		
		/// <inheritdoc />
		public IEnumInstance[] Values => new IEnumInstance[] {
		AMPERE,
		CELSIUS,
		COUNT,
		DECIBEL,
		DEGREE,
		DEGREE_3D,
		DEGREE_PER_SECOND,
		DEGREE_PER_SECOND_SQUARED,
		HERTZ,
		JOULE,
		KILOGRAM,
		LITER,
		LITER_PER_SECOND,
		MICRO_RADIAN,
		MILLIMETER,
		MILLIMETER_3D,
		MILLIMETER_PER_REVOLUTION,
		MILLIMETER_PER_SECOND,
		MILLIMETER_PER_SECOND_SQUARED,
		NEWTON,
		NEWTON_METER,
		OHM,
		PASCAL,
		PASCAL_SECOND,
		PERCENT,
		PH,
		REVOLUTION_PER_MINUTE,
		SECOND,
		SIEMENS_PER_METER,
		VOLT,
		VOLT_AMPERE,
		VOLT_AMPERE_REACTIVE,
		WATT,
		WATT_SECOND,
		GRAM_PER_CUBIC_METER,
		CUBIC_MILLIMETER,
		CUBIC_MILLIMETER_PER_SECOND,
		CUBIC_MILLIMETER_PER_SECOND_SQUARED,
		MILLIGRAM,
		MILLIGRAM_PER_CUBIC_MILLIMETER,
		MILLILITER,
		COUNT_PER_SECOND,
		PASCAL_PER_SECOND,
		UNIT_VECTOR_3D,
		REVOLUTION_PER_SECOND_SQUARED,
		REVOLUTION_PER_SECOND,
		GRAM,
		METER_PER_SECOND_SQUARED,
		COULOMB,
		};

		private AMPEREValue _AMPERE;
		/// <summary>
		/// amps.
		/// </summary>
		public AMPEREValue AMPERE => _AMPERE ?? (_AMPERE = new AMPEREValue());

		/// <summary>
		/// amps.
		/// </summary>
		public sealed class AMPEREValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "AMPERE";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.0";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// amps.";
		}
		private CELSIUSValue _CELSIUS;
		/// <summary>
		/// degrees Celsius.
		/// </summary>
		public CELSIUSValue CELSIUS => _CELSIUS ?? (_CELSIUS = new CELSIUSValue());

		/// <summary>
		/// degrees Celsius.
		/// </summary>
		public sealed class CELSIUSValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "CELSIUS";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.0";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// degrees Celsius.";
		}
		private COUNTValue _COUNT;
		/// <summary>
		/// count of something.
		/// </summary>
		public COUNTValue COUNT => _COUNT ?? (_COUNT = new COUNTValue());

		/// <summary>
		/// count of something.
		/// </summary>
		public sealed class COUNTValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "COUNT";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.0";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// count of something.";
		}
		private DECIBELValue _DECIBEL;
		/// <summary>
		/// sound level.
		/// </summary>
		public DECIBELValue DECIBEL => _DECIBEL ?? (_DECIBEL = new DECIBELValue());

		/// <summary>
		/// sound level.
		/// </summary>
		public sealed class DECIBELValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "DECIBEL";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.2";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// sound level.";
		}
		private DEGREEValue _DEGREE;
		/// <summary>
		/// angle in degrees.
		/// </summary>
		public DEGREEValue DEGREE => _DEGREE ?? (_DEGREE = new DEGREEValue());

		/// <summary>
		/// angle in degrees.
		/// </summary>
		public sealed class DEGREEValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "DEGREE";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.0";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// angle in degrees.";
		}
		private DEGREE_3DValue _DEGREE_3D;
		/// <summary>
		/// space-delimited, floating-point representation of the angular rotation in degrees around the X, Y, and Z axes relative to a cartesian coordinate system respectively in order as A, B, and C.   If any of the rotations is not known, it <b>MUST</b> be zero (0).
		/// </summary>
		public DEGREE_3DValue DEGREE_3D => _DEGREE_3D ?? (_DEGREE_3D = new DEGREE_3DValue());

		/// <summary>
		/// space-delimited, floating-point representation of the angular rotation in degrees around the X, Y, and Z axes relative to a cartesian coordinate system respectively in order as A, B, and C.   If any of the rotations is not known, it <b>MUST</b> be zero (0).
		/// </summary>
		public sealed class DEGREE_3DValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "DEGREE_3D";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.6";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// space-delimited, floating-point representation of the angular rotation in degrees around the X, Y, and Z axes relative to a cartesian coordinate system respectively in order as A, B, and C.   If any of the rotations is not known, it <b>MUST</b> be zero (0).";
		}
		private DEGREE_PER_SECONDValue _DEGREE_PER_SECOND;
		/// <summary>
		/// angular degrees per second.
		/// </summary>
		public DEGREE_PER_SECONDValue DEGREE_PER_SECOND => _DEGREE_PER_SECOND ?? (_DEGREE_PER_SECOND = new DEGREE_PER_SECONDValue());

		/// <summary>
		/// angular degrees per second.
		/// </summary>
		public sealed class DEGREE_PER_SECONDValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "DEGREE/SECOND";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.0";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// angular degrees per second.";
		}
		private DEGREE_PER_SECOND_SQUAREDValue _DEGREE_PER_SECOND_SQUARED;
		/// <summary>
		/// angular acceleration in degrees per second squared.
		/// </summary>
		public DEGREE_PER_SECOND_SQUAREDValue DEGREE_PER_SECOND_SQUARED => _DEGREE_PER_SECOND_SQUARED ?? (_DEGREE_PER_SECOND_SQUARED = new DEGREE_PER_SECOND_SQUAREDValue());

		/// <summary>
		/// angular acceleration in degrees per second squared.
		/// </summary>
		public sealed class DEGREE_PER_SECOND_SQUAREDValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "DEGREE/SECOND^2";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.0";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// angular acceleration in degrees per second squared.";
		}
		private HERTZValue _HERTZ;
		/// <summary>
		/// frequency measured in cycles per second.
		/// </summary>
		public HERTZValue HERTZ => _HERTZ ?? (_HERTZ = new HERTZValue());

		/// <summary>
		/// frequency measured in cycles per second.
		/// </summary>
		public sealed class HERTZValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "HERTZ";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.0";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// frequency measured in cycles per second.";
		}
		private JOULEValue _JOULE;
		/// <summary>
		/// measurement of energy.
		/// </summary>
		public JOULEValue JOULE => _JOULE ?? (_JOULE = new JOULEValue());

		/// <summary>
		/// measurement of energy.
		/// </summary>
		public sealed class JOULEValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "JOULE";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.1";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// measurement of energy.";
		}
		private KILOGRAMValue _KILOGRAM;
		/// <summary>
		/// kilograms.
		/// </summary>
		public KILOGRAMValue KILOGRAM => _KILOGRAM ?? (_KILOGRAM = new KILOGRAMValue());

		/// <summary>
		/// kilograms.
		/// </summary>
		public sealed class KILOGRAMValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "KILOGRAM";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.0";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// kilograms.";
		}
		private LITERValue _LITER;
		/// <summary>
		/// measurement of volume of a fluid.
		/// </summary>
		public LITERValue LITER => _LITER ?? (_LITER = new LITERValue());

		/// <summary>
		/// measurement of volume of a fluid.
		/// </summary>
		public sealed class LITERValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "LITER";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.0";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// measurement of volume of a fluid.";
		}
		private LITER_PER_SECONDValue _LITER_PER_SECOND;
		/// <summary>
		/// liters per second.
		/// </summary>
		public LITER_PER_SECONDValue LITER_PER_SECOND => _LITER_PER_SECOND ?? (_LITER_PER_SECOND = new LITER_PER_SECONDValue());

		/// <summary>
		/// liters per second.
		/// </summary>
		public sealed class LITER_PER_SECONDValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "LITER/SECOND";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.2";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// liters per second.";
		}
		private MICRO_RADIANValue _MICRO_RADIAN;
		/// <summary>
		/// measurement of tilt.
		/// </summary>
		public MICRO_RADIANValue MICRO_RADIAN => _MICRO_RADIAN ?? (_MICRO_RADIAN = new MICRO_RADIANValue());

		/// <summary>
		/// measurement of tilt.
		/// </summary>
		public sealed class MICRO_RADIANValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "MICRO_RADIAN";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.2";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// measurement of tilt.";
		}
		private MILLIMETERValue _MILLIMETER;
		/// <summary>
		/// millimeters.
		/// </summary>
		public MILLIMETERValue MILLIMETER => _MILLIMETER ?? (_MILLIMETER = new MILLIMETERValue());

		/// <summary>
		/// millimeters.
		/// </summary>
		public sealed class MILLIMETERValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "MILLIMETER";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.0";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// millimeters.";
		}
		private MILLIMETER_3DValue _MILLIMETER_3D;
		/// <summary>
		/// point in space identified by X, Y, and Z positions and represented by a space-delimited set of numbers each expressed in millimeters.
		/// </summary>
		public MILLIMETER_3DValue MILLIMETER_3D => _MILLIMETER_3D ?? (_MILLIMETER_3D = new MILLIMETER_3DValue());

		/// <summary>
		/// point in space identified by X, Y, and Z positions and represented by a space-delimited set of numbers each expressed in millimeters.
		/// </summary>
		public sealed class MILLIMETER_3DValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "MILLIMETER_3D";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.1";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// point in space identified by X, Y, and Z positions and represented by a space-delimited set of numbers each expressed in millimeters.";
		}
		private MILLIMETER_PER_REVOLUTIONValue _MILLIMETER_PER_REVOLUTION;
		/// <summary>
		/// millimeters per revolution.
		/// </summary>
		public MILLIMETER_PER_REVOLUTIONValue MILLIMETER_PER_REVOLUTION => _MILLIMETER_PER_REVOLUTION ?? (_MILLIMETER_PER_REVOLUTION = new MILLIMETER_PER_REVOLUTIONValue());

		/// <summary>
		/// millimeters per revolution.
		/// </summary>
		public sealed class MILLIMETER_PER_REVOLUTIONValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "MILLIMETER/REVOLUTION";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.5";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// millimeters per revolution.";
		}
		private MILLIMETER_PER_SECONDValue _MILLIMETER_PER_SECOND;
		/// <summary>
		/// millimeters per second.
		/// </summary>
		public MILLIMETER_PER_SECONDValue MILLIMETER_PER_SECOND => _MILLIMETER_PER_SECOND ?? (_MILLIMETER_PER_SECOND = new MILLIMETER_PER_SECONDValue());

		/// <summary>
		/// millimeters per second.
		/// </summary>
		public sealed class MILLIMETER_PER_SECONDValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "MILLIMETER/SECOND";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.0";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// millimeters per second.";
		}
		private MILLIMETER_PER_SECOND_SQUAREDValue _MILLIMETER_PER_SECOND_SQUARED;
		/// <summary>
		/// acceleration in millimeters per second squared.
		/// </summary>
		public MILLIMETER_PER_SECOND_SQUAREDValue MILLIMETER_PER_SECOND_SQUARED => _MILLIMETER_PER_SECOND_SQUARED ?? (_MILLIMETER_PER_SECOND_SQUARED = new MILLIMETER_PER_SECOND_SQUAREDValue());

		/// <summary>
		/// acceleration in millimeters per second squared.
		/// </summary>
		public sealed class MILLIMETER_PER_SECOND_SQUAREDValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "MILLIMETER/SECOND^2";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.0";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// acceleration in millimeters per second squared.";
		}
		private NEWTONValue _NEWTON;
		/// <summary>
		/// force in Newtons.
		/// </summary>
		public NEWTONValue NEWTON => _NEWTON ?? (_NEWTON = new NEWTONValue());

		/// <summary>
		/// force in Newtons.
		/// </summary>
		public sealed class NEWTONValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "NEWTON";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.0";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// force in Newtons.";
		}
		private NEWTON_METERValue _NEWTON_METER;
		/// <summary>
		/// torque, a unit for force times distance.
		/// </summary>
		public NEWTON_METERValue NEWTON_METER => _NEWTON_METER ?? (_NEWTON_METER = new NEWTON_METERValue());

		/// <summary>
		/// torque, a unit for force times distance.
		/// </summary>
		public sealed class NEWTON_METERValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "NEWTON_METER";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.0";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// torque, a unit for force times distance.";
		}
		private OHMValue _OHM;
		/// <summary>
		/// measure of electrical resistance.
		/// </summary>
		public OHMValue OHM => _OHM ?? (_OHM = new OHMValue());

		/// <summary>
		/// measure of electrical resistance.
		/// </summary>
		public sealed class OHMValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "OHM";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.2";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// measure of electrical resistance.";
		}
		private PASCALValue _PASCAL;
		/// <summary>
		/// pressure in Newtons per square meter.
		/// </summary>
		public PASCALValue PASCAL => _PASCAL ?? (_PASCAL = new PASCALValue());

		/// <summary>
		/// pressure in Newtons per square meter.
		/// </summary>
		public sealed class PASCALValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "PASCAL";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.0";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// pressure in Newtons per square meter.";
		}
		private PASCAL_SECONDValue _PASCAL_SECOND;
		/// <summary>
		/// measurement of viscosity.
		/// </summary>
		public PASCAL_SECONDValue PASCAL_SECOND => _PASCAL_SECOND ?? (_PASCAL_SECOND = new PASCAL_SECONDValue());

		/// <summary>
		/// measurement of viscosity.
		/// </summary>
		public sealed class PASCAL_SECONDValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "PASCAL_SECOND";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.2";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// measurement of viscosity.";
		}
		private PERCENTValue _PERCENT;
		/// <summary>
		/// percentage.
		/// </summary>
		public PERCENTValue PERCENT => _PERCENT ?? (_PERCENT = new PERCENTValue());

		/// <summary>
		/// percentage.
		/// </summary>
		public sealed class PERCENTValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "PERCENT";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.0";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// percentage.";
		}
		private PHValue _PH;
		/// <summary>
		/// measure of the acidity or alkalinity of a solution.
		/// </summary>
		public PHValue PH => _PH ?? (_PH = new PHValue());

		/// <summary>
		/// measure of the acidity or alkalinity of a solution.
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
			public string Summary => @"/// measure of the acidity or alkalinity of a solution.";
		}
		private REVOLUTION_PER_MINUTEValue _REVOLUTION_PER_MINUTE;
		/// <summary>
		/// revolutions per minute.
		/// </summary>
		public REVOLUTION_PER_MINUTEValue REVOLUTION_PER_MINUTE => _REVOLUTION_PER_MINUTE ?? (_REVOLUTION_PER_MINUTE = new REVOLUTION_PER_MINUTEValue());

		/// <summary>
		/// revolutions per minute.
		/// </summary>
		public sealed class REVOLUTION_PER_MINUTEValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "REVOLUTION/MINUTE";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.0";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// revolutions per minute.";
		}
		private SECONDValue _SECOND;
		/// <summary>
		/// measurement of time.
		/// </summary>
		public SECONDValue SECOND => _SECOND ?? (_SECOND = new SECONDValue());

		/// <summary>
		/// measurement of time.
		/// </summary>
		public sealed class SECONDValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "SECOND";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.0";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// measurement of time.";
		}
		private SIEMENS_PER_METERValue _SIEMENS_PER_METER;
		/// <summary>
		/// measurement of electrical conductivity.
		/// </summary>
		public SIEMENS_PER_METERValue SIEMENS_PER_METER => _SIEMENS_PER_METER ?? (_SIEMENS_PER_METER = new SIEMENS_PER_METERValue());

		/// <summary>
		/// measurement of electrical conductivity.
		/// </summary>
		public sealed class SIEMENS_PER_METERValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "SIEMENS/METER";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.2";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// measurement of electrical conductivity.";
		}
		private VOLTValue _VOLT;
		/// <summary>
		/// volts.
		/// </summary>
		public VOLTValue VOLT => _VOLT ?? (_VOLT = new VOLTValue());

		/// <summary>
		/// volts.
		/// </summary>
		public sealed class VOLTValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "VOLT";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.0";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// volts.";
		}
		private VOLT_AMPEREValue _VOLT_AMPERE;
		/// <summary>
		/// measurement of the apparent power in an electrical circuit, equal to the product of root-mean-square (RMS) voltage and RMS current (commonly referred to as VA).
		/// </summary>
		public VOLT_AMPEREValue VOLT_AMPERE => _VOLT_AMPERE ?? (_VOLT_AMPERE = new VOLT_AMPEREValue());

		/// <summary>
		/// measurement of the apparent power in an electrical circuit, equal to the product of root-mean-square (RMS) voltage and RMS current (commonly referred to as VA).
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
			public string Summary => @"/// measurement of the apparent power in an electrical circuit, equal to the product of root-mean-square (RMS) voltage and RMS current (commonly referred to as VA).";
		}
		private VOLT_AMPERE_REACTIVEValue _VOLT_AMPERE_REACTIVE;
		/// <summary>
		/// measurement of reactive power in an AC electrical circuit (commonly referred to as VAR).
		/// </summary>
		public VOLT_AMPERE_REACTIVEValue VOLT_AMPERE_REACTIVE => _VOLT_AMPERE_REACTIVE ?? (_VOLT_AMPERE_REACTIVE = new VOLT_AMPERE_REACTIVEValue());

		/// <summary>
		/// measurement of reactive power in an AC electrical circuit (commonly referred to as VAR).
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
			public string Summary => @"/// measurement of reactive power in an AC electrical circuit (commonly referred to as VAR).";
		}
		private WATTValue _WATT;
		/// <summary>
		/// watts.
		/// </summary>
		public WATTValue WATT => _WATT ?? (_WATT = new WATTValue());

		/// <summary>
		/// watts.
		/// </summary>
		public sealed class WATTValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "WATT";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.0";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// watts.";
		}
		private WATT_SECONDValue _WATT_SECOND;
		/// <summary>
		/// measurement of electrical energy, equal to one Joule.
		/// </summary>
		public WATT_SECONDValue WATT_SECOND => _WATT_SECOND ?? (_WATT_SECOND = new WATT_SECONDValue());

		/// <summary>
		/// measurement of electrical energy, equal to one Joule.
		/// </summary>
		public sealed class WATT_SECONDValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "WATT_SECOND";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.2";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// measurement of electrical energy, equal to one Joule.";
		}
		private GRAM_PER_CUBIC_METERValue _GRAM_PER_CUBIC_METER;
		/// <summary>
		/// gram per cubic meter.
		/// </summary>
		public GRAM_PER_CUBIC_METERValue GRAM_PER_CUBIC_METER => _GRAM_PER_CUBIC_METER ?? (_GRAM_PER_CUBIC_METER = new GRAM_PER_CUBIC_METERValue());

		/// <summary>
		/// gram per cubic meter.
		/// </summary>
		public sealed class GRAM_PER_CUBIC_METERValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "GRAM/CUBIC_METER";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.6";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// gram per cubic meter.";
		}
		private CUBIC_MILLIMETERValue _CUBIC_MILLIMETER;
		/// <summary>
		/// geometric volume in millimeters.
		/// </summary>
		public CUBIC_MILLIMETERValue CUBIC_MILLIMETER => _CUBIC_MILLIMETER ?? (_CUBIC_MILLIMETER = new CUBIC_MILLIMETERValue());

		/// <summary>
		/// geometric volume in millimeters.
		/// </summary>
		public sealed class CUBIC_MILLIMETERValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "CUBIC_MILLIMETER";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.5";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// geometric volume in millimeters.";
		}
		private CUBIC_MILLIMETER_PER_SECONDValue _CUBIC_MILLIMETER_PER_SECOND;
		/// <summary>
		/// change of geometric volume per second.
		/// </summary>
		public CUBIC_MILLIMETER_PER_SECONDValue CUBIC_MILLIMETER_PER_SECOND => _CUBIC_MILLIMETER_PER_SECOND ?? (_CUBIC_MILLIMETER_PER_SECOND = new CUBIC_MILLIMETER_PER_SECONDValue());

		/// <summary>
		/// change of geometric volume per second.
		/// </summary>
		public sealed class CUBIC_MILLIMETER_PER_SECONDValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "CUBIC_MILLIMETER/SECOND";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.5";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// change of geometric volume per second.";
		}
		private CUBIC_MILLIMETER_PER_SECOND_SQUAREDValue _CUBIC_MILLIMETER_PER_SECOND_SQUARED;
		/// <summary>
		/// change in geometric volume per second squared.
		/// </summary>
		public CUBIC_MILLIMETER_PER_SECOND_SQUAREDValue CUBIC_MILLIMETER_PER_SECOND_SQUARED => _CUBIC_MILLIMETER_PER_SECOND_SQUARED ?? (_CUBIC_MILLIMETER_PER_SECOND_SQUARED = new CUBIC_MILLIMETER_PER_SECOND_SQUAREDValue());

		/// <summary>
		/// change in geometric volume per second squared.
		/// </summary>
		public sealed class CUBIC_MILLIMETER_PER_SECOND_SQUAREDValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "CUBIC_MILLIMETER/SECOND^2";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.5";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// change in geometric volume per second squared.";
		}
		private MILLIGRAMValue _MILLIGRAM;
		/// <summary>
		/// milligram.
		/// </summary>
		public MILLIGRAMValue MILLIGRAM => _MILLIGRAM ?? (_MILLIGRAM = new MILLIGRAMValue());

		/// <summary>
		/// milligram.
		/// </summary>
		public sealed class MILLIGRAMValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "MILLIGRAM";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.5";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// milligram.";
		}
		private MILLIGRAM_PER_CUBIC_MILLIMETERValue _MILLIGRAM_PER_CUBIC_MILLIMETER;
		/// <summary>
		/// milligram per cubic millimeter.
		/// </summary>
		public MILLIGRAM_PER_CUBIC_MILLIMETERValue MILLIGRAM_PER_CUBIC_MILLIMETER => _MILLIGRAM_PER_CUBIC_MILLIMETER ?? (_MILLIGRAM_PER_CUBIC_MILLIMETER = new MILLIGRAM_PER_CUBIC_MILLIMETERValue());

		/// <summary>
		/// milligram per cubic millimeter.
		/// </summary>
		public sealed class MILLIGRAM_PER_CUBIC_MILLIMETERValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "MILLIGRAM/CUBIC_MILLIMETER";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.5";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// milligram per cubic millimeter.";
		}
		private MILLILITERValue _MILLILITER;
		/// <summary>
		/// milliliter.
		/// </summary>
		public MILLILITERValue MILLILITER => _MILLILITER ?? (_MILLILITER = new MILLILITERValue());

		/// <summary>
		/// milliliter.
		/// </summary>
		public sealed class MILLILITERValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "MILLILITER";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.5";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// milliliter.";
		}
		private COUNT_PER_SECONDValue _COUNT_PER_SECOND;
		/// <summary>
		/// counts per second.
		/// </summary>
		public COUNT_PER_SECONDValue COUNT_PER_SECOND => _COUNT_PER_SECOND ?? (_COUNT_PER_SECOND = new COUNT_PER_SECONDValue());

		/// <summary>
		/// counts per second.
		/// </summary>
		public sealed class COUNT_PER_SECONDValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "COUNT/SECOND";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.7";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// counts per second.";
		}
		private PASCAL_PER_SECONDValue _PASCAL_PER_SECOND;
		/// <summary>
		/// pascal per second.
		/// </summary>
		public PASCAL_PER_SECONDValue PASCAL_PER_SECOND => _PASCAL_PER_SECOND ?? (_PASCAL_PER_SECOND = new PASCAL_PER_SECONDValue());

		/// <summary>
		/// pascal per second.
		/// </summary>
		public sealed class PASCAL_PER_SECONDValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "PASCAL/SECOND";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.7";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// pascal per second.";
		}
		private UNIT_VECTOR_3DValue _UNIT_VECTOR_3D;
		/// <summary>
		/// 3D Unit Vector.  Space delimited list of three floating point numbers.
		/// </summary>
		public UNIT_VECTOR_3DValue UNIT_VECTOR_3D => _UNIT_VECTOR_3D ?? (_UNIT_VECTOR_3D = new UNIT_VECTOR_3DValue());

		/// <summary>
		/// 3D Unit Vector.  Space delimited list of three floating point numbers.
		/// </summary>
		public sealed class UNIT_VECTOR_3DValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "UNIT_VECTOR_3D";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.7";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// 3D Unit Vector.  Space delimited list of three floating point numbers.";
		}
		private REVOLUTION_PER_SECOND_SQUAREDValue _REVOLUTION_PER_SECOND_SQUARED;
		/// <summary>
		/// revolutions per second squared.
		/// </summary>
		public REVOLUTION_PER_SECOND_SQUAREDValue REVOLUTION_PER_SECOND_SQUARED => _REVOLUTION_PER_SECOND_SQUARED ?? (_REVOLUTION_PER_SECOND_SQUARED = new REVOLUTION_PER_SECOND_SQUAREDValue());

		/// <summary>
		/// revolutions per second squared.
		/// </summary>
		public sealed class REVOLUTION_PER_SECOND_SQUAREDValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "REVOLUTION/SECOND^2";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.6";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// revolutions per second squared.";
		}
		private REVOLUTION_PER_SECONDValue _REVOLUTION_PER_SECOND;
		/// <summary>
		/// rotational velocity in revolution per second.
		/// </summary>
		public REVOLUTION_PER_SECONDValue REVOLUTION_PER_SECOND => _REVOLUTION_PER_SECOND ?? (_REVOLUTION_PER_SECOND = new REVOLUTION_PER_SECONDValue());

		/// <summary>
		/// rotational velocity in revolution per second.
		/// </summary>
		public sealed class REVOLUTION_PER_SECONDValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "REVOLUTION/SECOND";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.1";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// rotational velocity in revolution per second.";
		}
		private GRAMValue _GRAM;
		/// <summary>
		/// gram.
		/// </summary>
		public GRAMValue GRAM => _GRAM ?? (_GRAM = new GRAMValue());

		/// <summary>
		/// gram.
		/// </summary>
		public sealed class GRAMValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "GRAM";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.2";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// gram.";
		}
		private METER_PER_SECOND_SQUAREDValue _METER_PER_SECOND_SQUARED;
		/// <summary>
		/// acceleration in meters per second squared.
		/// </summary>
		public METER_PER_SECOND_SQUAREDValue METER_PER_SECOND_SQUARED => _METER_PER_SECOND_SQUARED ?? (_METER_PER_SECOND_SQUARED = new METER_PER_SECOND_SQUAREDValue());

		/// <summary>
		/// acceleration in meters per second squared.
		/// </summary>
		public sealed class METER_PER_SECOND_SQUAREDValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "METER/SECOND^2";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "2.1";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// acceleration in meters per second squared.";
		}
		private COULOMBValue _COULOMB;
		/// <summary>
		/// electric charge in coulombs (C).
		/// </summary>
		public COULOMBValue COULOMB => _COULOMB ?? (_COULOMB = new COULOMBValue());

		/// <summary>
		/// electric charge in coulombs (C).
		/// </summary>
		public sealed class COULOMBValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "COULOMB";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "2.1";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// electric charge in coulombs (C).";
		}
	}
}