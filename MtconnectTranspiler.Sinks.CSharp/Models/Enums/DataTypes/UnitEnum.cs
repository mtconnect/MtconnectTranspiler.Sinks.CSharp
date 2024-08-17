#pragma warning disable CS1574 // XML comment has cref attribute that could not be resolved
#pragma warning disable CS1584 // XML comment has syntactically incorrect cref attribute
using System;
using System.CodeDom.Compiler;using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;

namespace Mtconnect.DataTypes
{
	/// <summary>﻿
	/// <br/> Visit <seealso href="https://model.mtconnect.org/#Enumeration__EAID_8FEC81E4_8E1F_4f45_820B_F9F25DD83F9A">model.mtconnect.org</seealso> for more information.
	/// </summary>
	/// <remarks>
	/// <list type="bullet">
	/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
	/// </list>
	/// </remarks>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public enum UnitEnum
	{
		/// <summary>﻿amps.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>
		AMPERE,
		/// <summary>﻿degrees Celsius.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>
		CELSIUS,
		/// <summary>﻿count of something.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>
		COUNT,
		/// <summary>﻿sound level.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.2">v1.2</see></item>
		/// </list>
		/// </remarks>
		DECIBEL,
		/// <summary>﻿angle in degrees.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>
		DEGREE,
		/// <summary>﻿space-delimited, floating-point representation of the angular rotation in degrees around the X, Y, and Z axes relative to a cartesian coordinate system respectively in order as A, B, and C. <br /><br />If any of the rotations is not known, it <b>MUST</b> be zero (0).<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.6">v1.6</see></item>
		/// </list>
		/// </remarks>
		DEGREE_3D,
		/// <summary>﻿angular degrees per second.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>
		DEGREE_PER_SECOND,
		/// <summary>﻿angular acceleration in degrees per second squared.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>
		DEGREE_PER_SECOND_SQUARED,
		/// <summary>﻿frequency measured in cycles per second.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>
		HERTZ,
		/// <summary>﻿measurement of energy.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.1">v1.1</see></item>
		/// </list>
		/// </remarks>
		JOULE,
		/// <summary>﻿kilograms.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>
		KILOGRAM,
		/// <summary>﻿measurement of volume of a fluid.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>
		LITER,
		/// <summary>﻿liters per second.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.2">v1.2</see></item>
		/// </list>
		/// </remarks>
		LITER_PER_SECOND,
		/// <summary>﻿measurement of tilt.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.2">v1.2</see></item>
		/// </list>
		/// </remarks>
		MICRO_RADIAN,
		/// <summary>﻿millimeters.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>
		MILLIMETER,
		/// <summary>﻿point in space identified by X, Y, and Z positions and represented by a space-delimited set of numbers each expressed in millimeters.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.1">v1.1</see></item>
		/// </list>
		/// </remarks>
		MILLIMETER_3D,
		/// <summary>﻿millimeters per revolution.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.5">v1.5</see></item>
		/// </list>
		/// </remarks>
		MILLIMETER_PER_REVOLUTION,
		/// <summary>﻿millimeters per second.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>
		MILLIMETER_PER_SECOND,
		/// <summary>﻿acceleration in millimeters per second squared.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>
		MILLIMETER_PER_SECOND_SQUARED,
		/// <summary>﻿force in Newtons.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>
		NEWTON,
		/// <summary>﻿torque, a unit for force times distance.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>
		NEWTON_METER,
		/// <summary>﻿measure of electrical resistance.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.2">v1.2</see></item>
		/// </list>
		/// </remarks>
		OHM,
		/// <summary>﻿pressure in Newtons per square meter.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>
		PASCAL,
		/// <summary>﻿measurement of viscosity.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.2">v1.2</see></item>
		/// </list>
		/// </remarks>
		PASCAL_SECOND,
		/// <summary>﻿percentage.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>
		PERCENT,
		/// <summary>﻿measure of the acidity or alkalinity of a solution.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.1">v1.1</see></item>
		/// </list>
		/// </remarks>
		PH,
		/// <summary>﻿revolutions per minute.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>
		REVOLUTION_PER_MINUTE,
		/// <summary>﻿measurement of time.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>
		SECOND,
		/// <summary>﻿measurement of electrical conductivity.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.2">v1.2</see></item>
		/// </list>
		/// </remarks>
		SIEMENS_PER_METER,
		/// <summary>﻿volts.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>
		VOLT,
		/// <summary>﻿measurement of the apparent power in an electrical circuit, equal to the product of root-mean-square (RMS) voltage and RMS current (commonly referred to as VA).<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.2">v1.2</see></item>
		/// </list>
		/// </remarks>
		VOLT_AMPERE,
		/// <summary>﻿measurement of reactive power in an AC electrical circuit (commonly referred to as VAR).<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.2">v1.2</see></item>
		/// </list>
		/// </remarks>
		VOLT_AMPERE_REACTIVE,
		/// <summary>﻿watts.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>
		WATT,
		/// <summary>﻿measurement of electrical energy, equal to one Joule.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.2">v1.2</see></item>
		/// </list>
		/// </remarks>
		WATT_SECOND,
		/// <summary>﻿gram per cubic meter.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.6">v1.6</see></item>
		/// </list>
		/// </remarks>
		GRAM_PER_CUBIC_METER,
		/// <summary>﻿geometric volume in millimeters.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.5">v1.5</see></item>
		/// </list>
		/// </remarks>
		CUBIC_MILLIMETER,
		/// <summary>﻿change of geometric volume per second.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.5">v1.5</see></item>
		/// </list>
		/// </remarks>
		CUBIC_MILLIMETER_PER_SECOND,
		/// <summary>﻿change in geometric volume per second squared.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.5">v1.5</see></item>
		/// </list>
		/// </remarks>
		CUBIC_MILLIMETER_PER_SECOND_SQUARED,
		/// <summary>﻿milligram.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.5">v1.5</see></item>
		/// </list>
		/// </remarks>
		MILLIGRAM,
		/// <summary>﻿milligram per cubic millimeter.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.5">v1.5</see></item>
		/// </list>
		/// </remarks>
		MILLIGRAM_PER_CUBIC_MILLIMETER,
		/// <summary>﻿milliliter.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.5">v1.5</see></item>
		/// </list>
		/// </remarks>
		MILLILITER,
		/// <summary>﻿counts per second.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.7">v1.7</see></item>
		/// </list>
		/// </remarks>
		COUNT_PER_SECOND,
		/// <summary>﻿pascal per second.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.7">v1.7</see></item>
		/// </list>
		/// </remarks>
		PASCAL_PER_SECOND,
		/// <summary>﻿3D Unit Vector.<br /><br />Space delimited list of three floating point numbers.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.7">v1.7</see></item>
		/// </list>
		/// </remarks>
		UNIT_VECTOR_3D,
		/// <summary>﻿revolutions per second squared.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.6">v1.6</see></item>
		/// </list>
		/// </remarks>
		REVOLUTION_PER_SECOND_SQUARED,
		/// <summary>﻿rotational velocity in revolution per second.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.1">v1.1</see></item>
		/// </list>
		/// </remarks>
		REVOLUTION_PER_SECOND,
		/// <summary>﻿gram.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.2">v1.2</see></item>
		/// </list>
		/// </remarks>
		GRAM,
		/// <summary>﻿acceleration in meters per second squared.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_2.1">v2.1</see></item>
		/// </list>
		/// </remarks>
		METER_PER_SECOND_SQUARED,
		/// <summary>﻿electric charge in coulombs (C).<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_2.1">v2.1</see></item>
		/// </list>
		/// </remarks>
		COULOMB,
	}

	/// <summary>﻿
	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Enumeration__EAID_8FEC81E4_8E1F_4f45_820B_F9F25DD83F9A">model.mtconnect.org</seealso> for more information.
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public sealed class UnitEnumMetaClass : IEnum
	{
		/// <inheritdoc />
		public string Name => "UnitEnum";
		
		/// <inheritdoc />
		public Type DataType => null;
		
		/// <inheritdoc />
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
		/// <inheritdoc cref="AMPEREValue" path="/summary" />
		public AMPEREValue AMPERE => _AMPERE ?? (_AMPERE = new AMPEREValue());

		/// <summary>﻿amps.<br /><br /><br />
		/// Value for UnitEnum.<br/>
		/// <br/>See also <seealso cref="UnitEnum">UnitEnum</seealso>
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
			public string Summary => @"&#10;&#10;&#10;amps.&#10;
";
		}
		private CELSIUSValue _CELSIUS;
		/// <inheritdoc cref="CELSIUSValue" path="/summary" />
		public CELSIUSValue CELSIUS => _CELSIUS ?? (_CELSIUS = new CELSIUSValue());

		/// <summary>﻿degrees Celsius.<br /><br /><br />
		/// Value for UnitEnum.<br/>
		/// <br/>See also <seealso cref="UnitEnum">UnitEnum</seealso>
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
			public string Summary => @"&#10;&#10;&#10;degrees Celsius.&#10;
";
		}
		private COUNTValue _COUNT;
		/// <inheritdoc cref="COUNTValue" path="/summary" />
		public COUNTValue COUNT => _COUNT ?? (_COUNT = new COUNTValue());

		/// <summary>﻿count of something.<br /><br /><br />
		/// Value for UnitEnum.<br/>
		/// <br/>See also <seealso cref="UnitEnum">UnitEnum</seealso>
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
			public string Summary => @"&#10;&#10;&#10;count of something.&#10;
";
		}
		private DECIBELValue _DECIBEL;
		/// <inheritdoc cref="DECIBELValue" path="/summary" />
		public DECIBELValue DECIBEL => _DECIBEL ?? (_DECIBEL = new DECIBELValue());

		/// <summary>﻿sound level.<br /><br /><br />
		/// Value for UnitEnum.<br/>
		/// <br/>See also <seealso cref="UnitEnum">UnitEnum</seealso>
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
			public string Summary => @"&#10;&#10;&#10;sound level.&#10;
";
		}
		private DEGREEValue _DEGREE;
		/// <inheritdoc cref="DEGREEValue" path="/summary" />
		public DEGREEValue DEGREE => _DEGREE ?? (_DEGREE = new DEGREEValue());

		/// <summary>﻿angle in degrees.<br /><br /><br />
		/// Value for UnitEnum.<br/>
		/// <br/>See also <seealso cref="UnitEnum">UnitEnum</seealso>
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
			public string Summary => @"&#10;&#10;&#10;angle in degrees.&#10;
";
		}
		private DEGREE_3DValue _DEGREE_3D;
		/// <inheritdoc cref="DEGREE_3DValue" path="/summary" />
		public DEGREE_3DValue DEGREE_3D => _DEGREE_3D ?? (_DEGREE_3D = new DEGREE_3DValue());

		/// <summary>﻿space-delimited, floating-point representation of the angular rotation in degrees around the X, Y, and Z axes relative to a cartesian coordinate system respectively in order as A, B, and C. <br /><br />If any of the rotations is not known, it <b>MUST</b> be zero (0).<br /><br /><br />
		/// Value for UnitEnum.<br/>
		/// <br/>See also <seealso cref="UnitEnum">UnitEnum</seealso>
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
			public string Summary => @"&#10;&#10;&#10;space-delimited, floating-point representation of the angular rotation in degrees around the X, Y, and Z axes relative to a cartesian coordinate system respectively in order as A, B, and C. 

If any of the rotations is not known, it **MUST** be zero (0).&#10;
";
		}
		private DEGREE_PER_SECONDValue _DEGREE_PER_SECOND;
		/// <inheritdoc cref="DEGREE_PER_SECONDValue" path="/summary" />
		public DEGREE_PER_SECONDValue DEGREE_PER_SECOND => _DEGREE_PER_SECOND ?? (_DEGREE_PER_SECOND = new DEGREE_PER_SECONDValue());

		/// <summary>﻿angular degrees per second.<br /><br /><br />
		/// Value for UnitEnum.<br/>
		/// <br/>See also <seealso cref="UnitEnum">UnitEnum</seealso>
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
			public string Summary => @"&#10;&#10;&#10;angular degrees per second.&#10;
";
		}
		private DEGREE_PER_SECOND_SQUAREDValue _DEGREE_PER_SECOND_SQUARED;
		/// <inheritdoc cref="DEGREE_PER_SECOND_SQUAREDValue" path="/summary" />
		public DEGREE_PER_SECOND_SQUAREDValue DEGREE_PER_SECOND_SQUARED => _DEGREE_PER_SECOND_SQUARED ?? (_DEGREE_PER_SECOND_SQUARED = new DEGREE_PER_SECOND_SQUAREDValue());

		/// <summary>﻿angular acceleration in degrees per second squared.<br /><br /><br />
		/// Value for UnitEnum.<br/>
		/// <br/>See also <seealso cref="UnitEnum">UnitEnum</seealso>
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
			public string Summary => @"&#10;&#10;&#10;angular acceleration in degrees per second squared.&#10;
";
		}
		private HERTZValue _HERTZ;
		/// <inheritdoc cref="HERTZValue" path="/summary" />
		public HERTZValue HERTZ => _HERTZ ?? (_HERTZ = new HERTZValue());

		/// <summary>﻿frequency measured in cycles per second.<br /><br /><br />
		/// Value for UnitEnum.<br/>
		/// <br/>See also <seealso cref="UnitEnum">UnitEnum</seealso>
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
			public string Summary => @"&#10;&#10;&#10;frequency measured in cycles per second.&#10;
";
		}
		private JOULEValue _JOULE;
		/// <inheritdoc cref="JOULEValue" path="/summary" />
		public JOULEValue JOULE => _JOULE ?? (_JOULE = new JOULEValue());

		/// <summary>﻿measurement of energy.<br /><br /><br />
		/// Value for UnitEnum.<br/>
		/// <br/>See also <seealso cref="UnitEnum">UnitEnum</seealso>
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
			public string Summary => @"&#10;&#10;&#10;measurement of energy.&#10;
";
		}
		private KILOGRAMValue _KILOGRAM;
		/// <inheritdoc cref="KILOGRAMValue" path="/summary" />
		public KILOGRAMValue KILOGRAM => _KILOGRAM ?? (_KILOGRAM = new KILOGRAMValue());

		/// <summary>﻿kilograms.<br /><br /><br />
		/// Value for UnitEnum.<br/>
		/// <br/>See also <seealso cref="UnitEnum">UnitEnum</seealso>
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
			public string Summary => @"&#10;&#10;&#10;kilograms.&#10;
";
		}
		private LITERValue _LITER;
		/// <inheritdoc cref="LITERValue" path="/summary" />
		public LITERValue LITER => _LITER ?? (_LITER = new LITERValue());

		/// <summary>﻿measurement of volume of a fluid.<br /><br /><br />
		/// Value for UnitEnum.<br/>
		/// <br/>See also <seealso cref="UnitEnum">UnitEnum</seealso>
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
			public string Summary => @"&#10;&#10;&#10;measurement of volume of a fluid.&#10;
";
		}
		private LITER_PER_SECONDValue _LITER_PER_SECOND;
		/// <inheritdoc cref="LITER_PER_SECONDValue" path="/summary" />
		public LITER_PER_SECONDValue LITER_PER_SECOND => _LITER_PER_SECOND ?? (_LITER_PER_SECOND = new LITER_PER_SECONDValue());

		/// <summary>﻿liters per second.<br /><br /><br />
		/// Value for UnitEnum.<br/>
		/// <br/>See also <seealso cref="UnitEnum">UnitEnum</seealso>
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
			public string Summary => @"&#10;&#10;&#10;liters per second.&#10;
";
		}
		private MICRO_RADIANValue _MICRO_RADIAN;
		/// <inheritdoc cref="MICRO_RADIANValue" path="/summary" />
		public MICRO_RADIANValue MICRO_RADIAN => _MICRO_RADIAN ?? (_MICRO_RADIAN = new MICRO_RADIANValue());

		/// <summary>﻿measurement of tilt.<br /><br /><br />
		/// Value for UnitEnum.<br/>
		/// <br/>See also <seealso cref="UnitEnum">UnitEnum</seealso>
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
			public string Summary => @"&#10;&#10;&#10;measurement of tilt.&#10;
";
		}
		private MILLIMETERValue _MILLIMETER;
		/// <inheritdoc cref="MILLIMETERValue" path="/summary" />
		public MILLIMETERValue MILLIMETER => _MILLIMETER ?? (_MILLIMETER = new MILLIMETERValue());

		/// <summary>﻿millimeters.<br /><br /><br />
		/// Value for UnitEnum.<br/>
		/// <br/>See also <seealso cref="UnitEnum">UnitEnum</seealso>
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
			public string Summary => @"&#10;&#10;&#10;millimeters.&#10;
";
		}
		private MILLIMETER_3DValue _MILLIMETER_3D;
		/// <inheritdoc cref="MILLIMETER_3DValue" path="/summary" />
		public MILLIMETER_3DValue MILLIMETER_3D => _MILLIMETER_3D ?? (_MILLIMETER_3D = new MILLIMETER_3DValue());

		/// <summary>﻿point in space identified by X, Y, and Z positions and represented by a space-delimited set of numbers each expressed in millimeters.<br /><br /><br />
		/// Value for UnitEnum.<br/>
		/// <br/>See also <seealso cref="UnitEnum">UnitEnum</seealso>
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
			public string Summary => @"&#10;&#10;&#10;point in space identified by X, Y, and Z positions and represented by a space-delimited set of numbers each expressed in millimeters.&#10;
";
		}
		private MILLIMETER_PER_REVOLUTIONValue _MILLIMETER_PER_REVOLUTION;
		/// <inheritdoc cref="MILLIMETER_PER_REVOLUTIONValue" path="/summary" />
		public MILLIMETER_PER_REVOLUTIONValue MILLIMETER_PER_REVOLUTION => _MILLIMETER_PER_REVOLUTION ?? (_MILLIMETER_PER_REVOLUTION = new MILLIMETER_PER_REVOLUTIONValue());

		/// <summary>﻿millimeters per revolution.<br /><br /><br />
		/// Value for UnitEnum.<br/>
		/// <br/>See also <seealso cref="UnitEnum">UnitEnum</seealso>
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
			public string Summary => @"&#10;&#10;&#10;millimeters per revolution.&#10;
";
		}
		private MILLIMETER_PER_SECONDValue _MILLIMETER_PER_SECOND;
		/// <inheritdoc cref="MILLIMETER_PER_SECONDValue" path="/summary" />
		public MILLIMETER_PER_SECONDValue MILLIMETER_PER_SECOND => _MILLIMETER_PER_SECOND ?? (_MILLIMETER_PER_SECOND = new MILLIMETER_PER_SECONDValue());

		/// <summary>﻿millimeters per second.<br /><br /><br />
		/// Value for UnitEnum.<br/>
		/// <br/>See also <seealso cref="UnitEnum">UnitEnum</seealso>
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
			public string Summary => @"&#10;&#10;&#10;millimeters per second.&#10;
";
		}
		private MILLIMETER_PER_SECOND_SQUAREDValue _MILLIMETER_PER_SECOND_SQUARED;
		/// <inheritdoc cref="MILLIMETER_PER_SECOND_SQUAREDValue" path="/summary" />
		public MILLIMETER_PER_SECOND_SQUAREDValue MILLIMETER_PER_SECOND_SQUARED => _MILLIMETER_PER_SECOND_SQUARED ?? (_MILLIMETER_PER_SECOND_SQUARED = new MILLIMETER_PER_SECOND_SQUAREDValue());

		/// <summary>﻿acceleration in millimeters per second squared.<br /><br /><br />
		/// Value for UnitEnum.<br/>
		/// <br/>See also <seealso cref="UnitEnum">UnitEnum</seealso>
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
			public string Summary => @"&#10;&#10;&#10;acceleration in millimeters per second squared.&#10;
";
		}
		private NEWTONValue _NEWTON;
		/// <inheritdoc cref="NEWTONValue" path="/summary" />
		public NEWTONValue NEWTON => _NEWTON ?? (_NEWTON = new NEWTONValue());

		/// <summary>﻿force in Newtons.<br /><br /><br />
		/// Value for UnitEnum.<br/>
		/// <br/>See also <seealso cref="UnitEnum">UnitEnum</seealso>
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
			public string Summary => @"&#10;&#10;&#10;force in Newtons.&#10;
";
		}
		private NEWTON_METERValue _NEWTON_METER;
		/// <inheritdoc cref="NEWTON_METERValue" path="/summary" />
		public NEWTON_METERValue NEWTON_METER => _NEWTON_METER ?? (_NEWTON_METER = new NEWTON_METERValue());

		/// <summary>﻿torque, a unit for force times distance.<br /><br /><br />
		/// Value for UnitEnum.<br/>
		/// <br/>See also <seealso cref="UnitEnum">UnitEnum</seealso>
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
			public string Summary => @"&#10;&#10;&#10;torque, a unit for force times distance.&#10;
";
		}
		private OHMValue _OHM;
		/// <inheritdoc cref="OHMValue" path="/summary" />
		public OHMValue OHM => _OHM ?? (_OHM = new OHMValue());

		/// <summary>﻿measure of electrical resistance.<br /><br /><br />
		/// Value for UnitEnum.<br/>
		/// <br/>See also <seealso cref="UnitEnum">UnitEnum</seealso>
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
			public string Summary => @"&#10;&#10;&#10;measure of electrical resistance.&#10;
";
		}
		private PASCALValue _PASCAL;
		/// <inheritdoc cref="PASCALValue" path="/summary" />
		public PASCALValue PASCAL => _PASCAL ?? (_PASCAL = new PASCALValue());

		/// <summary>﻿pressure in Newtons per square meter.<br /><br /><br />
		/// Value for UnitEnum.<br/>
		/// <br/>See also <seealso cref="UnitEnum">UnitEnum</seealso>
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
			public string Summary => @"&#10;&#10;&#10;pressure in Newtons per square meter.&#10;
";
		}
		private PASCAL_SECONDValue _PASCAL_SECOND;
		/// <inheritdoc cref="PASCAL_SECONDValue" path="/summary" />
		public PASCAL_SECONDValue PASCAL_SECOND => _PASCAL_SECOND ?? (_PASCAL_SECOND = new PASCAL_SECONDValue());

		/// <summary>﻿measurement of viscosity.<br /><br /><br />
		/// Value for UnitEnum.<br/>
		/// <br/>See also <seealso cref="UnitEnum">UnitEnum</seealso>
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
			public string Summary => @"&#10;&#10;&#10;measurement of viscosity.&#10;
";
		}
		private PERCENTValue _PERCENT;
		/// <inheritdoc cref="PERCENTValue" path="/summary" />
		public PERCENTValue PERCENT => _PERCENT ?? (_PERCENT = new PERCENTValue());

		/// <summary>﻿percentage.<br /><br /><br />
		/// Value for UnitEnum.<br/>
		/// <br/>See also <seealso cref="UnitEnum">UnitEnum</seealso>
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
			public string Summary => @"&#10;&#10;&#10;percentage.&#10;
";
		}
		private PHValue _PH;
		/// <inheritdoc cref="PHValue" path="/summary" />
		public PHValue PH => _PH ?? (_PH = new PHValue());

		/// <summary>﻿measure of the acidity or alkalinity of a solution.<br /><br /><br />
		/// Value for UnitEnum.<br/>
		/// <br/>See also <seealso cref="UnitEnum">UnitEnum</seealso>
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
			public string Summary => @"&#10;&#10;&#10;measure of the acidity or alkalinity of a solution.&#10;
";
		}
		private REVOLUTION_PER_MINUTEValue _REVOLUTION_PER_MINUTE;
		/// <inheritdoc cref="REVOLUTION_PER_MINUTEValue" path="/summary" />
		public REVOLUTION_PER_MINUTEValue REVOLUTION_PER_MINUTE => _REVOLUTION_PER_MINUTE ?? (_REVOLUTION_PER_MINUTE = new REVOLUTION_PER_MINUTEValue());

		/// <summary>﻿revolutions per minute.<br /><br /><br />
		/// Value for UnitEnum.<br/>
		/// <br/>See also <seealso cref="UnitEnum">UnitEnum</seealso>
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
			public string Summary => @"&#10;&#10;&#10;revolutions per minute.&#10;
";
		}
		private SECONDValue _SECOND;
		/// <inheritdoc cref="SECONDValue" path="/summary" />
		public SECONDValue SECOND => _SECOND ?? (_SECOND = new SECONDValue());

		/// <summary>﻿measurement of time.<br /><br /><br />
		/// Value for UnitEnum.<br/>
		/// <br/>See also <seealso cref="UnitEnum">UnitEnum</seealso>
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
			public string Summary => @"&#10;&#10;&#10;measurement of time.&#10;
";
		}
		private SIEMENS_PER_METERValue _SIEMENS_PER_METER;
		/// <inheritdoc cref="SIEMENS_PER_METERValue" path="/summary" />
		public SIEMENS_PER_METERValue SIEMENS_PER_METER => _SIEMENS_PER_METER ?? (_SIEMENS_PER_METER = new SIEMENS_PER_METERValue());

		/// <summary>﻿measurement of electrical conductivity.<br /><br /><br />
		/// Value for UnitEnum.<br/>
		/// <br/>See also <seealso cref="UnitEnum">UnitEnum</seealso>
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
			public string Summary => @"&#10;&#10;&#10;measurement of electrical conductivity.&#10;
";
		}
		private VOLTValue _VOLT;
		/// <inheritdoc cref="VOLTValue" path="/summary" />
		public VOLTValue VOLT => _VOLT ?? (_VOLT = new VOLTValue());

		/// <summary>﻿volts.<br /><br /><br />
		/// Value for UnitEnum.<br/>
		/// <br/>See also <seealso cref="UnitEnum">UnitEnum</seealso>
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
			public string Summary => @"&#10;&#10;&#10;volts.&#10;
";
		}
		private VOLT_AMPEREValue _VOLT_AMPERE;
		/// <inheritdoc cref="VOLT_AMPEREValue" path="/summary" />
		public VOLT_AMPEREValue VOLT_AMPERE => _VOLT_AMPERE ?? (_VOLT_AMPERE = new VOLT_AMPEREValue());

		/// <summary>﻿measurement of the apparent power in an electrical circuit, equal to the product of root-mean-square (RMS) voltage and RMS current (commonly referred to as VA).<br /><br /><br />
		/// Value for UnitEnum.<br/>
		/// <br/>See also <seealso cref="UnitEnum">UnitEnum</seealso>
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
			public string Summary => @"&#10;&#10;&#10;measurement of the apparent power in an electrical circuit, equal to the product of root-mean-square (RMS) voltage and RMS current (commonly referred to as VA).&#10;
";
		}
		private VOLT_AMPERE_REACTIVEValue _VOLT_AMPERE_REACTIVE;
		/// <inheritdoc cref="VOLT_AMPERE_REACTIVEValue" path="/summary" />
		public VOLT_AMPERE_REACTIVEValue VOLT_AMPERE_REACTIVE => _VOLT_AMPERE_REACTIVE ?? (_VOLT_AMPERE_REACTIVE = new VOLT_AMPERE_REACTIVEValue());

		/// <summary>﻿measurement of reactive power in an AC electrical circuit (commonly referred to as VAR).<br /><br /><br />
		/// Value for UnitEnum.<br/>
		/// <br/>See also <seealso cref="UnitEnum">UnitEnum</seealso>
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
			public string Summary => @"&#10;&#10;&#10;measurement of reactive power in an AC electrical circuit (commonly referred to as VAR).&#10;
";
		}
		private WATTValue _WATT;
		/// <inheritdoc cref="WATTValue" path="/summary" />
		public WATTValue WATT => _WATT ?? (_WATT = new WATTValue());

		/// <summary>﻿watts.<br /><br /><br />
		/// Value for UnitEnum.<br/>
		/// <br/>See also <seealso cref="UnitEnum">UnitEnum</seealso>
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
			public string Summary => @"&#10;&#10;&#10;watts.&#10;
";
		}
		private WATT_SECONDValue _WATT_SECOND;
		/// <inheritdoc cref="WATT_SECONDValue" path="/summary" />
		public WATT_SECONDValue WATT_SECOND => _WATT_SECOND ?? (_WATT_SECOND = new WATT_SECONDValue());

		/// <summary>﻿measurement of electrical energy, equal to one Joule.<br /><br /><br />
		/// Value for UnitEnum.<br/>
		/// <br/>See also <seealso cref="UnitEnum">UnitEnum</seealso>
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
			public string Summary => @"&#10;&#10;&#10;measurement of electrical energy, equal to one Joule.&#10;
";
		}
		private GRAM_PER_CUBIC_METERValue _GRAM_PER_CUBIC_METER;
		/// <inheritdoc cref="GRAM_PER_CUBIC_METERValue" path="/summary" />
		public GRAM_PER_CUBIC_METERValue GRAM_PER_CUBIC_METER => _GRAM_PER_CUBIC_METER ?? (_GRAM_PER_CUBIC_METER = new GRAM_PER_CUBIC_METERValue());

		/// <summary>﻿gram per cubic meter.<br /><br /><br />
		/// Value for UnitEnum.<br/>
		/// <br/>See also <seealso cref="UnitEnum">UnitEnum</seealso>
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
			public string Summary => @"&#10;&#10;&#10;gram per cubic meter.&#10;
";
		}
		private CUBIC_MILLIMETERValue _CUBIC_MILLIMETER;
		/// <inheritdoc cref="CUBIC_MILLIMETERValue" path="/summary" />
		public CUBIC_MILLIMETERValue CUBIC_MILLIMETER => _CUBIC_MILLIMETER ?? (_CUBIC_MILLIMETER = new CUBIC_MILLIMETERValue());

		/// <summary>﻿geometric volume in millimeters.<br /><br /><br />
		/// Value for UnitEnum.<br/>
		/// <br/>See also <seealso cref="UnitEnum">UnitEnum</seealso>
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
			public string Summary => @"&#10;&#10;&#10;geometric volume in millimeters.&#10;
";
		}
		private CUBIC_MILLIMETER_PER_SECONDValue _CUBIC_MILLIMETER_PER_SECOND;
		/// <inheritdoc cref="CUBIC_MILLIMETER_PER_SECONDValue" path="/summary" />
		public CUBIC_MILLIMETER_PER_SECONDValue CUBIC_MILLIMETER_PER_SECOND => _CUBIC_MILLIMETER_PER_SECOND ?? (_CUBIC_MILLIMETER_PER_SECOND = new CUBIC_MILLIMETER_PER_SECONDValue());

		/// <summary>﻿change of geometric volume per second.<br /><br /><br />
		/// Value for UnitEnum.<br/>
		/// <br/>See also <seealso cref="UnitEnum">UnitEnum</seealso>
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
			public string Summary => @"&#10;&#10;&#10;change of geometric volume per second.&#10;
";
		}
		private CUBIC_MILLIMETER_PER_SECOND_SQUAREDValue _CUBIC_MILLIMETER_PER_SECOND_SQUARED;
		/// <inheritdoc cref="CUBIC_MILLIMETER_PER_SECOND_SQUAREDValue" path="/summary" />
		public CUBIC_MILLIMETER_PER_SECOND_SQUAREDValue CUBIC_MILLIMETER_PER_SECOND_SQUARED => _CUBIC_MILLIMETER_PER_SECOND_SQUARED ?? (_CUBIC_MILLIMETER_PER_SECOND_SQUARED = new CUBIC_MILLIMETER_PER_SECOND_SQUAREDValue());

		/// <summary>﻿change in geometric volume per second squared.<br /><br /><br />
		/// Value for UnitEnum.<br/>
		/// <br/>See also <seealso cref="UnitEnum">UnitEnum</seealso>
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
			public string Summary => @"&#10;&#10;&#10;change in geometric volume per second squared.&#10;
";
		}
		private MILLIGRAMValue _MILLIGRAM;
		/// <inheritdoc cref="MILLIGRAMValue" path="/summary" />
		public MILLIGRAMValue MILLIGRAM => _MILLIGRAM ?? (_MILLIGRAM = new MILLIGRAMValue());

		/// <summary>﻿milligram.<br /><br /><br />
		/// Value for UnitEnum.<br/>
		/// <br/>See also <seealso cref="UnitEnum">UnitEnum</seealso>
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
			public string Summary => @"&#10;&#10;&#10;milligram.&#10;
";
		}
		private MILLIGRAM_PER_CUBIC_MILLIMETERValue _MILLIGRAM_PER_CUBIC_MILLIMETER;
		/// <inheritdoc cref="MILLIGRAM_PER_CUBIC_MILLIMETERValue" path="/summary" />
		public MILLIGRAM_PER_CUBIC_MILLIMETERValue MILLIGRAM_PER_CUBIC_MILLIMETER => _MILLIGRAM_PER_CUBIC_MILLIMETER ?? (_MILLIGRAM_PER_CUBIC_MILLIMETER = new MILLIGRAM_PER_CUBIC_MILLIMETERValue());

		/// <summary>﻿milligram per cubic millimeter.<br /><br /><br />
		/// Value for UnitEnum.<br/>
		/// <br/>See also <seealso cref="UnitEnum">UnitEnum</seealso>
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
			public string Summary => @"&#10;&#10;&#10;milligram per cubic millimeter.&#10;
";
		}
		private MILLILITERValue _MILLILITER;
		/// <inheritdoc cref="MILLILITERValue" path="/summary" />
		public MILLILITERValue MILLILITER => _MILLILITER ?? (_MILLILITER = new MILLILITERValue());

		/// <summary>﻿milliliter.<br /><br /><br />
		/// Value for UnitEnum.<br/>
		/// <br/>See also <seealso cref="UnitEnum">UnitEnum</seealso>
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
			public string Summary => @"&#10;&#10;&#10;milliliter.&#10;
";
		}
		private COUNT_PER_SECONDValue _COUNT_PER_SECOND;
		/// <inheritdoc cref="COUNT_PER_SECONDValue" path="/summary" />
		public COUNT_PER_SECONDValue COUNT_PER_SECOND => _COUNT_PER_SECOND ?? (_COUNT_PER_SECOND = new COUNT_PER_SECONDValue());

		/// <summary>﻿counts per second.<br /><br /><br />
		/// Value for UnitEnum.<br/>
		/// <br/>See also <seealso cref="UnitEnum">UnitEnum</seealso>
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
			public string Summary => @"&#10;&#10;&#10;counts per second.&#10;
";
		}
		private PASCAL_PER_SECONDValue _PASCAL_PER_SECOND;
		/// <inheritdoc cref="PASCAL_PER_SECONDValue" path="/summary" />
		public PASCAL_PER_SECONDValue PASCAL_PER_SECOND => _PASCAL_PER_SECOND ?? (_PASCAL_PER_SECOND = new PASCAL_PER_SECONDValue());

		/// <summary>﻿pascal per second.<br /><br /><br />
		/// Value for UnitEnum.<br/>
		/// <br/>See also <seealso cref="UnitEnum">UnitEnum</seealso>
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
			public string Summary => @"&#10;&#10;&#10;pascal per second.&#10;
";
		}
		private UNIT_VECTOR_3DValue _UNIT_VECTOR_3D;
		/// <inheritdoc cref="UNIT_VECTOR_3DValue" path="/summary" />
		public UNIT_VECTOR_3DValue UNIT_VECTOR_3D => _UNIT_VECTOR_3D ?? (_UNIT_VECTOR_3D = new UNIT_VECTOR_3DValue());

		/// <summary>﻿3D Unit Vector.<br /><br />Space delimited list of three floating point numbers.<br /><br /><br />
		/// Value for UnitEnum.<br/>
		/// <br/>See also <seealso cref="UnitEnum">UnitEnum</seealso>
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
			public string Summary => @"&#10;&#10;&#10;3D Unit Vector.

Space delimited list of three floating point numbers.&#10;
";
		}
		private REVOLUTION_PER_SECOND_SQUAREDValue _REVOLUTION_PER_SECOND_SQUARED;
		/// <inheritdoc cref="REVOLUTION_PER_SECOND_SQUAREDValue" path="/summary" />
		public REVOLUTION_PER_SECOND_SQUAREDValue REVOLUTION_PER_SECOND_SQUARED => _REVOLUTION_PER_SECOND_SQUARED ?? (_REVOLUTION_PER_SECOND_SQUARED = new REVOLUTION_PER_SECOND_SQUAREDValue());

		/// <summary>﻿revolutions per second squared.<br /><br /><br />
		/// Value for UnitEnum.<br/>
		/// <br/>See also <seealso cref="UnitEnum">UnitEnum</seealso>
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
			public string Summary => @"&#10;&#10;&#10;revolutions per second squared.&#10;
";
		}
		private REVOLUTION_PER_SECONDValue _REVOLUTION_PER_SECOND;
		/// <inheritdoc cref="REVOLUTION_PER_SECONDValue" path="/summary" />
		public REVOLUTION_PER_SECONDValue REVOLUTION_PER_SECOND => _REVOLUTION_PER_SECOND ?? (_REVOLUTION_PER_SECOND = new REVOLUTION_PER_SECONDValue());

		/// <summary>﻿rotational velocity in revolution per second.<br /><br /><br />
		/// Value for UnitEnum.<br/>
		/// <br/>See also <seealso cref="UnitEnum">UnitEnum</seealso>
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
			public string Summary => @"&#10;&#10;&#10;rotational velocity in revolution per second.&#10;
";
		}
		private GRAMValue _GRAM;
		/// <inheritdoc cref="GRAMValue" path="/summary" />
		public GRAMValue GRAM => _GRAM ?? (_GRAM = new GRAMValue());

		/// <summary>﻿gram.<br /><br /><br />
		/// Value for UnitEnum.<br/>
		/// <br/>See also <seealso cref="UnitEnum">UnitEnum</seealso>
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
			public string Summary => @"&#10;&#10;&#10;gram.&#10;
";
		}
		private METER_PER_SECOND_SQUAREDValue _METER_PER_SECOND_SQUARED;
		/// <inheritdoc cref="METER_PER_SECOND_SQUAREDValue" path="/summary" />
		public METER_PER_SECOND_SQUAREDValue METER_PER_SECOND_SQUARED => _METER_PER_SECOND_SQUARED ?? (_METER_PER_SECOND_SQUARED = new METER_PER_SECOND_SQUAREDValue());

		/// <summary>﻿acceleration in meters per second squared.<br /><br /><br />
		/// Value for UnitEnum.<br/>
		/// <br/>See also <seealso cref="UnitEnum">UnitEnum</seealso>
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
			public string Summary => @"&#10;&#10;&#10;acceleration in meters per second squared.&#10;
";
		}
		private COULOMBValue _COULOMB;
		/// <inheritdoc cref="COULOMBValue" path="/summary" />
		public COULOMBValue COULOMB => _COULOMB ?? (_COULOMB = new COULOMBValue());

		/// <summary>﻿electric charge in coulombs (C).<br /><br /><br />
		/// Value for UnitEnum.<br/>
		/// <br/>See also <seealso cref="UnitEnum">UnitEnum</seealso>
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
			public string Summary => @"&#10;&#10;&#10;electric charge in coulombs (C).&#10;
";
		}
	}
}