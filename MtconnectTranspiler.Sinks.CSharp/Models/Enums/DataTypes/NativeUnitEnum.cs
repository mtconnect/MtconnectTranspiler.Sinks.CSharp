#pragma warning disable CS1574 // XML comment has cref attribute that could not be resolved
#pragma warning disable CS1584 // XML comment has syntactically incorrect cref attribute
#pragma warning disable CS0618 // Type or member is obsolete
using System;
using System.CodeDom.Compiler;using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;

namespace Mtconnect.DataTypes
{
	/// <summary>﻿
	/// <br/> Visit <seealso href="https://model.mtconnect.org/#Enumeration__EAID_678122A4_E8FD_4243_8427_6B7E0E78D5F5">model.mtconnect.org</seealso> for more information.
	/// </summary>
	/// <remarks>
	/// <list type="bullet">
	/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.1">v1.1</see></item>
	/// </list>
	/// </remarks>

	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public enum NativeUnitEnum
	{
		/// <summary>﻿measure of viscosity.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.1">v1.1</see></item>
		/// </list>
		/// </remarks>

		CENTIPOISE,
		/// <summary>﻿rotational velocity in degrees per minute.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.1">v1.1</see></item>
		/// </list>
		/// </remarks>

		DEGREE_PER_MINUTE,
		/// <summary>﻿temperature in Fahrenheit.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.1">v1.1</see></item>
		/// </list>
		/// </remarks>

		FAHRENHEIT,
		/// <summary>﻿feet.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.1">v1.1</see></item>
		/// </list>
		/// </remarks>

		FOOT,
		/// <summary>﻿feet per minute.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.1">v1.1</see></item>
		/// </list>
		/// </remarks>

		FOOT_PER_MINUTE,
		/// <summary>﻿feet per second.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.1">v1.1</see></item>
		/// </list>
		/// </remarks>

		FOOT_PER_SECOND,
		/// <summary>﻿acceleration in feet per second squared.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.1">v1.1</see></item>
		/// </list>
		/// </remarks>

		FOOT_PER_SECOND_SQUARED,
		/// <summary>﻿point in space identified by X, Y, and Z positions and represented by a space-delimited set of numbers each expressed in feet.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.1">v1.1</see></item>
		/// </list>
		/// </remarks>

		FOOT_3D,
		/// <summary>﻿gallons per minute.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.1">v1.1</see></item>
		/// </list>
		/// </remarks>

		GALLON_PER_MINUTE,
		/// <summary>﻿measurement of time in hours.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.1">v1.1</see></item>
		/// </list>
		/// </remarks>

		HOUR,
		/// <summary>﻿inches.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.1">v1.1</see></item>
		/// </list>
		/// </remarks>

		INCH,
		/// <summary>﻿inches per minute.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.1">v1.1</see></item>
		/// </list>
		/// </remarks>

		INCH_PER_MINUTE,
		/// <summary>﻿inches per second.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.1">v1.1</see></item>
		/// </list>
		/// </remarks>

		INCH_PER_SECOND,
		/// <summary>﻿acceleration in inches per second squared.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.1">v1.1</see></item>
		/// </list>
		/// </remarks>

		INCH_PER_SECOND_SQUARED,
		/// <summary>﻿measure of torque in inch pounds.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.1">v1.1</see></item>
		/// </list>
		/// </remarks>

		INCH_POUND,
		/// <summary>﻿point in space identified by X, Y, and Z positions and represented by a space-delimited set of numbers each expressed in inches.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.1">v1.1</see></item>
		/// </list>
		/// </remarks>

		INCH_3D,
		/// <summary>﻿measurement of temperature.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.1">v1.1</see></item>
		/// </list>
		/// </remarks>

		KELVIN,
		/// <summary>﻿measurement in kilowatt.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.1">v1.1</see></item>
		/// </list>
		/// </remarks>

		KILOWATT,
		/// <summary>﻿kilowatt hours which is 3.6 mega joules.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.1">v1.1</see></item>
		/// </list>
		/// </remarks>

		KILOWATT_HOUR,
		/// <summary>﻿measurement of rate of flow of a fluid.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.1">v1.1</see></item>
		/// </list>
		/// </remarks>

		LITER_PER_MINUTE,
		/// <summary>﻿velocity in millimeters per minute.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.1">v1.1</see></item>
		/// </list>
		/// </remarks>

		MILLIMETER_PER_MINUTE,
		/// <summary>﻿measurement of time in minutes.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.1">v1.1</see></item>
		/// </list>
		/// </remarks>

		MINUTE,
		/// <summary>﻿unsupported unit.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.1">v1.1</see></item>
		/// </list>
		/// </remarks>

		OTHER,
		/// <summary>﻿US pounds.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.1">v1.1</see></item>
		/// </list>
		/// </remarks>

		POUND,
		/// <summary>﻿pressure in pounds per square inch (PSI).<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.1">v1.1</see></item>
		/// </list>
		/// </remarks>

		POUND_PER_INCH_SQUARED,
		/// <summary>﻿angle in radians.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.1">v1.1</see></item>
		/// </list>
		/// </remarks>

		RADIAN,
		/// <summary>﻿velocity in radians per minute.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.1">v1.1</see></item>
		/// </list>
		/// </remarks>

		RADIAN_PER_MINUTE,
		/// <summary>﻿rotational acceleration in radian per second squared.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.1">v1.1</see></item>
		/// </list>
		/// </remarks>

		RADIAN_PER_SECOND,
		/// <summary>﻿rotational acceleration in radian per second squared.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.1">v1.1</see></item>
		/// </list>
		/// </remarks>

		RADIAN_PER_SECOND_SQUARED,
		/// <summary>﻿pressure in Bar.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.1">v1.1</see></item>
		/// </list>
		/// </remarks>

		BAR,
		/// <summary>﻿pressure in Torr.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.1">v1.1</see></item>
		/// </list>
		/// </remarks>

		TORR,
		/// <summary>﻿pressure in Millimeter of Mercury (mmHg).<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.1">v1.1</see></item>
		/// </list>
		/// </remarks>

		MILLIMETER_MERCURY,
		/// <summary>﻿pascal per minute.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.1">v1.1</see></item>
		/// </list>
		/// </remarks>

		PASCAL_PER_MINUTE,
		/// <summary>﻿<i>MASS\times GRAVITATIONAL_ACCELERATION</i> (g) given in <c>METER/SECOND^2</c>.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.1">v1.1</see></item>
		/// </list>
		/// </remarks>

		GRAVITATIONAL_FORCE,
		/// <summary>﻿acceleration relative to earth's gravity given in <c>METER/SECOND^2</c>.<br /><br />&gt; Note 1 to entry: At different points on Earth's surface, the free-fall acceleration ranges from 9.764 to 9.834 m/s2 (Wikipedia: Gravitational Acceleration). The constant can be customized depending on the location in the universe.<br /><br />&gt; Note 2 to entry: In the standard, it is assumed that Earth's average value of gravitational acceleration is 9.90665 m/s2.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.1">v1.1</see></item>
		/// </list>
		/// </remarks>

		GRAVITATIONAL_ACCELERATION,
		/// <summary>﻿electric charge in ampere hour.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.1">v1.1</see></item>
		/// </list>
		/// </remarks>

		AMPERE_HOUR,
		/// <summary>﻿change of geometric volume in cubic foot per hour.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.1">v1.1</see></item>
		/// </list>
		/// </remarks>

		CUBIC_FOOT_PER_HOUR,
		/// <summary>﻿change of geometric volume in cubic foot per minute.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.1">v1.1</see></item>
		/// </list>
		/// </remarks>

		CUBIC_FOOT_PER_MINUTE,
	}

	/// <summary>﻿
	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Enumeration__EAID_678122A4_E8FD_4243_8427_6B7E0E78D5F5">model.mtconnect.org</seealso> for more information.
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public sealed class NativeUnitEnumMetaClass : IEnum
	{
		/// <summary>Constant value for <see cref="NativeUnitEnumMetaClass.ReferenceId" /></summary>
		public const string REFERENCE_ID = "EAID_678122A4_E8FD_4243_8427_6B7E0E78D5F5";
		/// <summary>Constant value for <see cref="NativeUnitEnumMetaClass.HelpUrl" /></summary>
		public const string HELP_URL = "https://model.mtconnect.org/#Enumeration__EAID_678122A4_E8FD_4243_8427_6B7E0E78D5F5";
		/// <summary>Constant value for <see cref="NativeUnitEnumMetaClass.Name" /></summary>
		public const string NAME = "NativeUnitEnum";
		/// <summary>Constant value for <see cref="NativeUnitEnumMetaClass.NormativeVersion" /></summary>
		public const string NORMATIVE_VERSION = "1.1";
		/// <summary>Constant value for <see cref="NativeUnitEnumMetaClass.DeprecatedVersion" /></summary>
		public const string DEPRECATED_VERSION = "";
		/// <summary>Constant value for <see cref="NativeUnitEnumMetaClass.Summary" /></summary>
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
		public Type Instance => typeof(NativeUnitEnum);

		/// <inheritdoc />
		public string NormativeVersion => NORMATIVE_VERSION;
		
		/// <inheritdoc />
		public string DeprecatedVersion => DEPRECATED_VERSION;
		
		/// <inheritdoc />
		public string Summary => SUMMARY;
		
		/// <inheritdoc />
		public IEnumInstance[] Values => new IEnumInstance[] {
		CENTIPOISE,
		DEGREE_PER_MINUTE,
		FAHRENHEIT,
		FOOT,
		FOOT_PER_MINUTE,
		FOOT_PER_SECOND,
		FOOT_PER_SECOND_SQUARED,
		FOOT_3D,
		GALLON_PER_MINUTE,
		HOUR,
		INCH,
		INCH_PER_MINUTE,
		INCH_PER_SECOND,
		INCH_PER_SECOND_SQUARED,
		INCH_POUND,
		INCH_3D,
		KELVIN,
		KILOWATT,
		KILOWATT_HOUR,
		LITER_PER_MINUTE,
		MILLIMETER_PER_MINUTE,
		MINUTE,
		OTHER,
		POUND,
		POUND_PER_INCH_SQUARED,
		RADIAN,
		RADIAN_PER_MINUTE,
		RADIAN_PER_SECOND,
		RADIAN_PER_SECOND_SQUARED,
		BAR,
		TORR,
		MILLIMETER_MERCURY,
		PASCAL_PER_MINUTE,
		GRAVITATIONAL_FORCE,
		GRAVITATIONAL_ACCELERATION,
		AMPERE_HOUR,
		CUBIC_FOOT_PER_HOUR,
		CUBIC_FOOT_PER_MINUTE,
		};

		private CENTIPOISEValue _CENTIPOISE;
		/// <inheritdoc cref="CENTIPOISEValue" path="/summary" />
		public CENTIPOISEValue CENTIPOISE => _CENTIPOISE ?? (_CENTIPOISE = new CENTIPOISEValue());

		/// <summary>﻿measure of viscosity.<br /><br /><br />
		/// Value for NativeUnitEnum.<br/>
		/// <br/>See also <seealso cref="NativeUnitEnum">NativeUnitEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.1">v1.1</see></item>
		/// </list>
		/// </remarks>

		public sealed class CENTIPOISEValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="CENTIPOISEValue.Name" /></summary>
			public const string NAME = "CENTIPOISE";
			/// <summary>Constant value for <see cref="CENTIPOISEValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.2";
			/// <summary>Constant value for <see cref="CENTIPOISEValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="CENTIPOISEValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;measure of viscosity.&#10;
";

			/// <inheritdoc />
			public string Name => NAME;
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => NORMATIVE_VERSION;
			
			/// <inheritdoc />
			public string DeprecatedVersion => DEPRECATED_VERSION;
			
			/// <inheritdoc />
			public string Summary => SUMMARY;
		}
		private DEGREE_PER_MINUTEValue _DEGREE_PER_MINUTE;
		/// <inheritdoc cref="DEGREE_PER_MINUTEValue" path="/summary" />
		public DEGREE_PER_MINUTEValue DEGREE_PER_MINUTE => _DEGREE_PER_MINUTE ?? (_DEGREE_PER_MINUTE = new DEGREE_PER_MINUTEValue());

		/// <summary>﻿rotational velocity in degrees per minute.<br /><br /><br />
		/// Value for NativeUnitEnum.<br/>
		/// <br/>See also <seealso cref="NativeUnitEnum">NativeUnitEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.1">v1.1</see></item>
		/// </list>
		/// </remarks>

		public sealed class DEGREE_PER_MINUTEValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="DEGREE_PER_MINUTEValue.Name" /></summary>
			public const string NAME = "DEGREE/MINUTE";
			/// <summary>Constant value for <see cref="DEGREE_PER_MINUTEValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.1";
			/// <summary>Constant value for <see cref="DEGREE_PER_MINUTEValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="DEGREE_PER_MINUTEValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;rotational velocity in degrees per minute.&#10;
";

			/// <inheritdoc />
			public string Name => NAME;
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => NORMATIVE_VERSION;
			
			/// <inheritdoc />
			public string DeprecatedVersion => DEPRECATED_VERSION;
			
			/// <inheritdoc />
			public string Summary => SUMMARY;
		}
		private FAHRENHEITValue _FAHRENHEIT;
		/// <inheritdoc cref="FAHRENHEITValue" path="/summary" />
		public FAHRENHEITValue FAHRENHEIT => _FAHRENHEIT ?? (_FAHRENHEIT = new FAHRENHEITValue());

		/// <summary>﻿temperature in Fahrenheit.<br /><br /><br />
		/// Value for NativeUnitEnum.<br/>
		/// <br/>See also <seealso cref="NativeUnitEnum">NativeUnitEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.1">v1.1</see></item>
		/// </list>
		/// </remarks>

		public sealed class FAHRENHEITValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="FAHRENHEITValue.Name" /></summary>
			public const string NAME = "FAHRENHEIT";
			/// <summary>Constant value for <see cref="FAHRENHEITValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.1";
			/// <summary>Constant value for <see cref="FAHRENHEITValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="FAHRENHEITValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;temperature in Fahrenheit.&#10;
";

			/// <inheritdoc />
			public string Name => NAME;
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => NORMATIVE_VERSION;
			
			/// <inheritdoc />
			public string DeprecatedVersion => DEPRECATED_VERSION;
			
			/// <inheritdoc />
			public string Summary => SUMMARY;
		}
		private FOOTValue _FOOT;
		/// <inheritdoc cref="FOOTValue" path="/summary" />
		public FOOTValue FOOT => _FOOT ?? (_FOOT = new FOOTValue());

		/// <summary>﻿feet.<br /><br /><br />
		/// Value for NativeUnitEnum.<br/>
		/// <br/>See also <seealso cref="NativeUnitEnum">NativeUnitEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.1">v1.1</see></item>
		/// </list>
		/// </remarks>

		public sealed class FOOTValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="FOOTValue.Name" /></summary>
			public const string NAME = "FOOT";
			/// <summary>Constant value for <see cref="FOOTValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.1";
			/// <summary>Constant value for <see cref="FOOTValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="FOOTValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;feet.&#10;
";

			/// <inheritdoc />
			public string Name => NAME;
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => NORMATIVE_VERSION;
			
			/// <inheritdoc />
			public string DeprecatedVersion => DEPRECATED_VERSION;
			
			/// <inheritdoc />
			public string Summary => SUMMARY;
		}
		private FOOT_PER_MINUTEValue _FOOT_PER_MINUTE;
		/// <inheritdoc cref="FOOT_PER_MINUTEValue" path="/summary" />
		public FOOT_PER_MINUTEValue FOOT_PER_MINUTE => _FOOT_PER_MINUTE ?? (_FOOT_PER_MINUTE = new FOOT_PER_MINUTEValue());

		/// <summary>﻿feet per minute.<br /><br /><br />
		/// Value for NativeUnitEnum.<br/>
		/// <br/>See also <seealso cref="NativeUnitEnum">NativeUnitEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.1">v1.1</see></item>
		/// </list>
		/// </remarks>

		public sealed class FOOT_PER_MINUTEValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="FOOT_PER_MINUTEValue.Name" /></summary>
			public const string NAME = "FOOT/MINUTE";
			/// <summary>Constant value for <see cref="FOOT_PER_MINUTEValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.1";
			/// <summary>Constant value for <see cref="FOOT_PER_MINUTEValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="FOOT_PER_MINUTEValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;feet per minute.&#10;
";

			/// <inheritdoc />
			public string Name => NAME;
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => NORMATIVE_VERSION;
			
			/// <inheritdoc />
			public string DeprecatedVersion => DEPRECATED_VERSION;
			
			/// <inheritdoc />
			public string Summary => SUMMARY;
		}
		private FOOT_PER_SECONDValue _FOOT_PER_SECOND;
		/// <inheritdoc cref="FOOT_PER_SECONDValue" path="/summary" />
		public FOOT_PER_SECONDValue FOOT_PER_SECOND => _FOOT_PER_SECOND ?? (_FOOT_PER_SECOND = new FOOT_PER_SECONDValue());

		/// <summary>﻿feet per second.<br /><br /><br />
		/// Value for NativeUnitEnum.<br/>
		/// <br/>See also <seealso cref="NativeUnitEnum">NativeUnitEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.1">v1.1</see></item>
		/// </list>
		/// </remarks>

		public sealed class FOOT_PER_SECONDValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="FOOT_PER_SECONDValue.Name" /></summary>
			public const string NAME = "FOOT/SECOND";
			/// <summary>Constant value for <see cref="FOOT_PER_SECONDValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.1";
			/// <summary>Constant value for <see cref="FOOT_PER_SECONDValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="FOOT_PER_SECONDValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;feet per second.&#10;
";

			/// <inheritdoc />
			public string Name => NAME;
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => NORMATIVE_VERSION;
			
			/// <inheritdoc />
			public string DeprecatedVersion => DEPRECATED_VERSION;
			
			/// <inheritdoc />
			public string Summary => SUMMARY;
		}
		private FOOT_PER_SECOND_SQUAREDValue _FOOT_PER_SECOND_SQUARED;
		/// <inheritdoc cref="FOOT_PER_SECOND_SQUAREDValue" path="/summary" />
		public FOOT_PER_SECOND_SQUAREDValue FOOT_PER_SECOND_SQUARED => _FOOT_PER_SECOND_SQUARED ?? (_FOOT_PER_SECOND_SQUARED = new FOOT_PER_SECOND_SQUAREDValue());

		/// <summary>﻿acceleration in feet per second squared.<br /><br /><br />
		/// Value for NativeUnitEnum.<br/>
		/// <br/>See also <seealso cref="NativeUnitEnum">NativeUnitEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.1">v1.1</see></item>
		/// </list>
		/// </remarks>

		public sealed class FOOT_PER_SECOND_SQUAREDValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="FOOT_PER_SECOND_SQUAREDValue.Name" /></summary>
			public const string NAME = "FOOT/SECOND^2";
			/// <summary>Constant value for <see cref="FOOT_PER_SECOND_SQUAREDValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.1";
			/// <summary>Constant value for <see cref="FOOT_PER_SECOND_SQUAREDValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="FOOT_PER_SECOND_SQUAREDValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;acceleration in feet per second squared.&#10;
";

			/// <inheritdoc />
			public string Name => NAME;
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => NORMATIVE_VERSION;
			
			/// <inheritdoc />
			public string DeprecatedVersion => DEPRECATED_VERSION;
			
			/// <inheritdoc />
			public string Summary => SUMMARY;
		}
		private FOOT_3DValue _FOOT_3D;
		/// <inheritdoc cref="FOOT_3DValue" path="/summary" />
		public FOOT_3DValue FOOT_3D => _FOOT_3D ?? (_FOOT_3D = new FOOT_3DValue());

		/// <summary>﻿point in space identified by X, Y, and Z positions and represented by a space-delimited set of numbers each expressed in feet.<br /><br /><br />
		/// Value for NativeUnitEnum.<br/>
		/// <br/>See also <seealso cref="NativeUnitEnum">NativeUnitEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.1">v1.1</see></item>
		/// </list>
		/// </remarks>

		public sealed class FOOT_3DValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="FOOT_3DValue.Name" /></summary>
			public const string NAME = "FOOT_3D";
			/// <summary>Constant value for <see cref="FOOT_3DValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.1";
			/// <summary>Constant value for <see cref="FOOT_3DValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="FOOT_3DValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;point in space identified by X, Y, and Z positions and represented by a space-delimited set of numbers each expressed in feet.&#10;
";

			/// <inheritdoc />
			public string Name => NAME;
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => NORMATIVE_VERSION;
			
			/// <inheritdoc />
			public string DeprecatedVersion => DEPRECATED_VERSION;
			
			/// <inheritdoc />
			public string Summary => SUMMARY;
		}
		private GALLON_PER_MINUTEValue _GALLON_PER_MINUTE;
		/// <inheritdoc cref="GALLON_PER_MINUTEValue" path="/summary" />
		public GALLON_PER_MINUTEValue GALLON_PER_MINUTE => _GALLON_PER_MINUTE ?? (_GALLON_PER_MINUTE = new GALLON_PER_MINUTEValue());

		/// <summary>﻿gallons per minute.<br /><br /><br />
		/// Value for NativeUnitEnum.<br/>
		/// <br/>See also <seealso cref="NativeUnitEnum">NativeUnitEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.1">v1.1</see></item>
		/// </list>
		/// </remarks>

		public sealed class GALLON_PER_MINUTEValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="GALLON_PER_MINUTEValue.Name" /></summary>
			public const string NAME = "GALLON/MINUTE";
			/// <summary>Constant value for <see cref="GALLON_PER_MINUTEValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.1";
			/// <summary>Constant value for <see cref="GALLON_PER_MINUTEValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="GALLON_PER_MINUTEValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;gallons per minute.&#10;
";

			/// <inheritdoc />
			public string Name => NAME;
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => NORMATIVE_VERSION;
			
			/// <inheritdoc />
			public string DeprecatedVersion => DEPRECATED_VERSION;
			
			/// <inheritdoc />
			public string Summary => SUMMARY;
		}
		private HOURValue _HOUR;
		/// <inheritdoc cref="HOURValue" path="/summary" />
		public HOURValue HOUR => _HOUR ?? (_HOUR = new HOURValue());

		/// <summary>﻿measurement of time in hours.<br /><br /><br />
		/// Value for NativeUnitEnum.<br/>
		/// <br/>See also <seealso cref="NativeUnitEnum">NativeUnitEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.1">v1.1</see></item>
		/// </list>
		/// </remarks>

		public sealed class HOURValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="HOURValue.Name" /></summary>
			public const string NAME = "HOUR";
			/// <summary>Constant value for <see cref="HOURValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.5";
			/// <summary>Constant value for <see cref="HOURValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="HOURValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;measurement of time in hours.&#10;
";

			/// <inheritdoc />
			public string Name => NAME;
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => NORMATIVE_VERSION;
			
			/// <inheritdoc />
			public string DeprecatedVersion => DEPRECATED_VERSION;
			
			/// <inheritdoc />
			public string Summary => SUMMARY;
		}
		private INCHValue _INCH;
		/// <inheritdoc cref="INCHValue" path="/summary" />
		public INCHValue INCH => _INCH ?? (_INCH = new INCHValue());

		/// <summary>﻿inches.<br /><br /><br />
		/// Value for NativeUnitEnum.<br/>
		/// <br/>See also <seealso cref="NativeUnitEnum">NativeUnitEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.1">v1.1</see></item>
		/// </list>
		/// </remarks>

		public sealed class INCHValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="INCHValue.Name" /></summary>
			public const string NAME = "INCH";
			/// <summary>Constant value for <see cref="INCHValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.1";
			/// <summary>Constant value for <see cref="INCHValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="INCHValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;inches.&#10;
";

			/// <inheritdoc />
			public string Name => NAME;
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => NORMATIVE_VERSION;
			
			/// <inheritdoc />
			public string DeprecatedVersion => DEPRECATED_VERSION;
			
			/// <inheritdoc />
			public string Summary => SUMMARY;
		}
		private INCH_PER_MINUTEValue _INCH_PER_MINUTE;
		/// <inheritdoc cref="INCH_PER_MINUTEValue" path="/summary" />
		public INCH_PER_MINUTEValue INCH_PER_MINUTE => _INCH_PER_MINUTE ?? (_INCH_PER_MINUTE = new INCH_PER_MINUTEValue());

		/// <summary>﻿inches per minute.<br /><br /><br />
		/// Value for NativeUnitEnum.<br/>
		/// <br/>See also <seealso cref="NativeUnitEnum">NativeUnitEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.1">v1.1</see></item>
		/// </list>
		/// </remarks>

		public sealed class INCH_PER_MINUTEValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="INCH_PER_MINUTEValue.Name" /></summary>
			public const string NAME = "INCH/MINUTE";
			/// <summary>Constant value for <see cref="INCH_PER_MINUTEValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.1";
			/// <summary>Constant value for <see cref="INCH_PER_MINUTEValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="INCH_PER_MINUTEValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;inches per minute.&#10;
";

			/// <inheritdoc />
			public string Name => NAME;
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => NORMATIVE_VERSION;
			
			/// <inheritdoc />
			public string DeprecatedVersion => DEPRECATED_VERSION;
			
			/// <inheritdoc />
			public string Summary => SUMMARY;
		}
		private INCH_PER_SECONDValue _INCH_PER_SECOND;
		/// <inheritdoc cref="INCH_PER_SECONDValue" path="/summary" />
		public INCH_PER_SECONDValue INCH_PER_SECOND => _INCH_PER_SECOND ?? (_INCH_PER_SECOND = new INCH_PER_SECONDValue());

		/// <summary>﻿inches per second.<br /><br /><br />
		/// Value for NativeUnitEnum.<br/>
		/// <br/>See also <seealso cref="NativeUnitEnum">NativeUnitEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.1">v1.1</see></item>
		/// </list>
		/// </remarks>

		public sealed class INCH_PER_SECONDValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="INCH_PER_SECONDValue.Name" /></summary>
			public const string NAME = "INCH/SECOND";
			/// <summary>Constant value for <see cref="INCH_PER_SECONDValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.1";
			/// <summary>Constant value for <see cref="INCH_PER_SECONDValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="INCH_PER_SECONDValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;inches per second.&#10;
";

			/// <inheritdoc />
			public string Name => NAME;
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => NORMATIVE_VERSION;
			
			/// <inheritdoc />
			public string DeprecatedVersion => DEPRECATED_VERSION;
			
			/// <inheritdoc />
			public string Summary => SUMMARY;
		}
		private INCH_PER_SECOND_SQUAREDValue _INCH_PER_SECOND_SQUARED;
		/// <inheritdoc cref="INCH_PER_SECOND_SQUAREDValue" path="/summary" />
		public INCH_PER_SECOND_SQUAREDValue INCH_PER_SECOND_SQUARED => _INCH_PER_SECOND_SQUARED ?? (_INCH_PER_SECOND_SQUARED = new INCH_PER_SECOND_SQUAREDValue());

		/// <summary>﻿acceleration in inches per second squared.<br /><br /><br />
		/// Value for NativeUnitEnum.<br/>
		/// <br/>See also <seealso cref="NativeUnitEnum">NativeUnitEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.1">v1.1</see></item>
		/// </list>
		/// </remarks>

		public sealed class INCH_PER_SECOND_SQUAREDValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="INCH_PER_SECOND_SQUAREDValue.Name" /></summary>
			public const string NAME = "INCH/SECOND^2";
			/// <summary>Constant value for <see cref="INCH_PER_SECOND_SQUAREDValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.1";
			/// <summary>Constant value for <see cref="INCH_PER_SECOND_SQUAREDValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="INCH_PER_SECOND_SQUAREDValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;acceleration in inches per second squared.&#10;
";

			/// <inheritdoc />
			public string Name => NAME;
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => NORMATIVE_VERSION;
			
			/// <inheritdoc />
			public string DeprecatedVersion => DEPRECATED_VERSION;
			
			/// <inheritdoc />
			public string Summary => SUMMARY;
		}
		private INCH_POUNDValue _INCH_POUND;
		/// <inheritdoc cref="INCH_POUNDValue" path="/summary" />
		public INCH_POUNDValue INCH_POUND => _INCH_POUND ?? (_INCH_POUND = new INCH_POUNDValue());

		/// <summary>﻿measure of torque in inch pounds.<br /><br /><br />
		/// Value for NativeUnitEnum.<br/>
		/// <br/>See also <seealso cref="NativeUnitEnum">NativeUnitEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.1">v1.1</see></item>
		/// </list>
		/// </remarks>

		public sealed class INCH_POUNDValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="INCH_POUNDValue.Name" /></summary>
			public const string NAME = "INCH_POUND";
			/// <summary>Constant value for <see cref="INCH_POUNDValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.1";
			/// <summary>Constant value for <see cref="INCH_POUNDValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="INCH_POUNDValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;measure of torque in inch pounds.&#10;
";

			/// <inheritdoc />
			public string Name => NAME;
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => NORMATIVE_VERSION;
			
			/// <inheritdoc />
			public string DeprecatedVersion => DEPRECATED_VERSION;
			
			/// <inheritdoc />
			public string Summary => SUMMARY;
		}
		private INCH_3DValue _INCH_3D;
		/// <inheritdoc cref="INCH_3DValue" path="/summary" />
		public INCH_3DValue INCH_3D => _INCH_3D ?? (_INCH_3D = new INCH_3DValue());

		/// <summary>﻿point in space identified by X, Y, and Z positions and represented by a space-delimited set of numbers each expressed in inches.<br /><br /><br />
		/// Value for NativeUnitEnum.<br/>
		/// <br/>See also <seealso cref="NativeUnitEnum">NativeUnitEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.1">v1.1</see></item>
		/// </list>
		/// </remarks>

		public sealed class INCH_3DValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="INCH_3DValue.Name" /></summary>
			public const string NAME = "INCH_3D";
			/// <summary>Constant value for <see cref="INCH_3DValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.1";
			/// <summary>Constant value for <see cref="INCH_3DValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="INCH_3DValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;point in space identified by X, Y, and Z positions and represented by a space-delimited set of numbers each expressed in inches.&#10;
";

			/// <inheritdoc />
			public string Name => NAME;
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => NORMATIVE_VERSION;
			
			/// <inheritdoc />
			public string DeprecatedVersion => DEPRECATED_VERSION;
			
			/// <inheritdoc />
			public string Summary => SUMMARY;
		}
		private KELVINValue _KELVIN;
		/// <inheritdoc cref="KELVINValue" path="/summary" />
		public KELVINValue KELVIN => _KELVIN ?? (_KELVIN = new KELVINValue());

		/// <summary>﻿measurement of temperature.<br /><br /><br />
		/// Value for NativeUnitEnum.<br/>
		/// <br/>See also <seealso cref="NativeUnitEnum">NativeUnitEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.1">v1.1</see></item>
		/// </list>
		/// </remarks>

		public sealed class KELVINValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="KELVINValue.Name" /></summary>
			public const string NAME = "KELVIN";
			/// <summary>Constant value for <see cref="KELVINValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.3";
			/// <summary>Constant value for <see cref="KELVINValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="KELVINValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;measurement of temperature.&#10;
";

			/// <inheritdoc />
			public string Name => NAME;
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => NORMATIVE_VERSION;
			
			/// <inheritdoc />
			public string DeprecatedVersion => DEPRECATED_VERSION;
			
			/// <inheritdoc />
			public string Summary => SUMMARY;
		}
		private KILOWATTValue _KILOWATT;
		/// <inheritdoc cref="KILOWATTValue" path="/summary" />
		public KILOWATTValue KILOWATT => _KILOWATT ?? (_KILOWATT = new KILOWATTValue());

		/// <summary>﻿measurement in kilowatt.<br /><br /><br />
		/// Value for NativeUnitEnum.<br/>
		/// <br/>See also <seealso cref="NativeUnitEnum">NativeUnitEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.1">v1.1</see></item>
		/// </list>
		/// </remarks>

		public sealed class KILOWATTValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="KILOWATTValue.Name" /></summary>
			public const string NAME = "KILOWATT";
			/// <summary>Constant value for <see cref="KILOWATTValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.1";
			/// <summary>Constant value for <see cref="KILOWATTValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="KILOWATTValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;measurement in kilowatt.&#10;
";

			/// <inheritdoc />
			public string Name => NAME;
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => NORMATIVE_VERSION;
			
			/// <inheritdoc />
			public string DeprecatedVersion => DEPRECATED_VERSION;
			
			/// <inheritdoc />
			public string Summary => SUMMARY;
		}
		private KILOWATT_HOURValue _KILOWATT_HOUR;
		/// <inheritdoc cref="KILOWATT_HOURValue" path="/summary" />
		public KILOWATT_HOURValue KILOWATT_HOUR => _KILOWATT_HOUR ?? (_KILOWATT_HOUR = new KILOWATT_HOURValue());

		/// <summary>﻿kilowatt hours which is 3.6 mega joules.<br /><br /><br />
		/// Value for NativeUnitEnum.<br/>
		/// <br/>See also <seealso cref="NativeUnitEnum">NativeUnitEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.1">v1.1</see></item>
		/// </list>
		/// </remarks>

		public sealed class KILOWATT_HOURValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="KILOWATT_HOURValue.Name" /></summary>
			public const string NAME = "KILOWATT_HOUR";
			/// <summary>Constant value for <see cref="KILOWATT_HOURValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.1";
			/// <summary>Constant value for <see cref="KILOWATT_HOURValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="KILOWATT_HOURValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;kilowatt hours which is 3.6 mega joules.&#10;
";

			/// <inheritdoc />
			public string Name => NAME;
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => NORMATIVE_VERSION;
			
			/// <inheritdoc />
			public string DeprecatedVersion => DEPRECATED_VERSION;
			
			/// <inheritdoc />
			public string Summary => SUMMARY;
		}
		private LITER_PER_MINUTEValue _LITER_PER_MINUTE;
		/// <inheritdoc cref="LITER_PER_MINUTEValue" path="/summary" />
		public LITER_PER_MINUTEValue LITER_PER_MINUTE => _LITER_PER_MINUTE ?? (_LITER_PER_MINUTE = new LITER_PER_MINUTEValue());

		/// <summary>﻿measurement of rate of flow of a fluid.<br /><br /><br />
		/// Value for NativeUnitEnum.<br/>
		/// <br/>See also <seealso cref="NativeUnitEnum">NativeUnitEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.1">v1.1</see></item>
		/// </list>
		/// </remarks>

		public sealed class LITER_PER_MINUTEValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="LITER_PER_MINUTEValue.Name" /></summary>
			public const string NAME = "LITER/MINUTE";
			/// <summary>Constant value for <see cref="LITER_PER_MINUTEValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.2";
			/// <summary>Constant value for <see cref="LITER_PER_MINUTEValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="LITER_PER_MINUTEValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;measurement of rate of flow of a fluid.&#10;
";

			/// <inheritdoc />
			public string Name => NAME;
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => NORMATIVE_VERSION;
			
			/// <inheritdoc />
			public string DeprecatedVersion => DEPRECATED_VERSION;
			
			/// <inheritdoc />
			public string Summary => SUMMARY;
		}
		private MILLIMETER_PER_MINUTEValue _MILLIMETER_PER_MINUTE;
		/// <inheritdoc cref="MILLIMETER_PER_MINUTEValue" path="/summary" />
		public MILLIMETER_PER_MINUTEValue MILLIMETER_PER_MINUTE => _MILLIMETER_PER_MINUTE ?? (_MILLIMETER_PER_MINUTE = new MILLIMETER_PER_MINUTEValue());

		/// <summary>﻿velocity in millimeters per minute.<br /><br /><br />
		/// Value for NativeUnitEnum.<br/>
		/// <br/>See also <seealso cref="NativeUnitEnum">NativeUnitEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.1">v1.1</see></item>
		/// </list>
		/// </remarks>

		public sealed class MILLIMETER_PER_MINUTEValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="MILLIMETER_PER_MINUTEValue.Name" /></summary>
			public const string NAME = "MILLIMETER/MINUTE";
			/// <summary>Constant value for <see cref="MILLIMETER_PER_MINUTEValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.1";
			/// <summary>Constant value for <see cref="MILLIMETER_PER_MINUTEValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="MILLIMETER_PER_MINUTEValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;velocity in millimeters per minute.&#10;
";

			/// <inheritdoc />
			public string Name => NAME;
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => NORMATIVE_VERSION;
			
			/// <inheritdoc />
			public string DeprecatedVersion => DEPRECATED_VERSION;
			
			/// <inheritdoc />
			public string Summary => SUMMARY;
		}
		private MINUTEValue _MINUTE;
		/// <inheritdoc cref="MINUTEValue" path="/summary" />
		public MINUTEValue MINUTE => _MINUTE ?? (_MINUTE = new MINUTEValue());

		/// <summary>﻿measurement of time in minutes.<br /><br /><br />
		/// Value for NativeUnitEnum.<br/>
		/// <br/>See also <seealso cref="NativeUnitEnum">NativeUnitEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.1">v1.1</see></item>
		/// </list>
		/// </remarks>

		public sealed class MINUTEValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="MINUTEValue.Name" /></summary>
			public const string NAME = "MINUTE";
			/// <summary>Constant value for <see cref="MINUTEValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.5";
			/// <summary>Constant value for <see cref="MINUTEValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="MINUTEValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;measurement of time in minutes.&#10;
";

			/// <inheritdoc />
			public string Name => NAME;
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => NORMATIVE_VERSION;
			
			/// <inheritdoc />
			public string DeprecatedVersion => DEPRECATED_VERSION;
			
			/// <inheritdoc />
			public string Summary => SUMMARY;
		}
		private OTHERValue _OTHER;
		/// <inheritdoc cref="OTHERValue" path="/summary" />
		public OTHERValue OTHER => _OTHER ?? (_OTHER = new OTHERValue());

		/// <summary>﻿unsupported unit.<br /><br /><br />
		/// Value for NativeUnitEnum.<br/>
		/// <br/>See also <seealso cref="NativeUnitEnum">NativeUnitEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.1">v1.1</see></item>
		/// </list>
		/// </remarks>

		public sealed class OTHERValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="OTHERValue.Name" /></summary>
			public const string NAME = "OTHER";
			/// <summary>Constant value for <see cref="OTHERValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.1";
			/// <summary>Constant value for <see cref="OTHERValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="OTHERValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;unsupported unit.&#10;
";

			/// <inheritdoc />
			public string Name => NAME;
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => NORMATIVE_VERSION;
			
			/// <inheritdoc />
			public string DeprecatedVersion => DEPRECATED_VERSION;
			
			/// <inheritdoc />
			public string Summary => SUMMARY;
		}
		private POUNDValue _POUND;
		/// <inheritdoc cref="POUNDValue" path="/summary" />
		public POUNDValue POUND => _POUND ?? (_POUND = new POUNDValue());

		/// <summary>﻿US pounds.<br /><br /><br />
		/// Value for NativeUnitEnum.<br/>
		/// <br/>See also <seealso cref="NativeUnitEnum">NativeUnitEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.1">v1.1</see></item>
		/// </list>
		/// </remarks>

		public sealed class POUNDValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="POUNDValue.Name" /></summary>
			public const string NAME = "POUND";
			/// <summary>Constant value for <see cref="POUNDValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.1";
			/// <summary>Constant value for <see cref="POUNDValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="POUNDValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;US pounds.&#10;
";

			/// <inheritdoc />
			public string Name => NAME;
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => NORMATIVE_VERSION;
			
			/// <inheritdoc />
			public string DeprecatedVersion => DEPRECATED_VERSION;
			
			/// <inheritdoc />
			public string Summary => SUMMARY;
		}
		private POUND_PER_INCH_SQUAREDValue _POUND_PER_INCH_SQUARED;
		/// <inheritdoc cref="POUND_PER_INCH_SQUAREDValue" path="/summary" />
		public POUND_PER_INCH_SQUAREDValue POUND_PER_INCH_SQUARED => _POUND_PER_INCH_SQUARED ?? (_POUND_PER_INCH_SQUARED = new POUND_PER_INCH_SQUAREDValue());

		/// <summary>﻿pressure in pounds per square inch (PSI).<br /><br /><br />
		/// Value for NativeUnitEnum.<br/>
		/// <br/>See also <seealso cref="NativeUnitEnum">NativeUnitEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.1">v1.1</see></item>
		/// </list>
		/// </remarks>

		public sealed class POUND_PER_INCH_SQUAREDValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="POUND_PER_INCH_SQUAREDValue.Name" /></summary>
			public const string NAME = "POUND/INCH^2";
			/// <summary>Constant value for <see cref="POUND_PER_INCH_SQUAREDValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.1";
			/// <summary>Constant value for <see cref="POUND_PER_INCH_SQUAREDValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="POUND_PER_INCH_SQUAREDValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;pressure in pounds per square inch (PSI).&#10;
";

			/// <inheritdoc />
			public string Name => NAME;
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => NORMATIVE_VERSION;
			
			/// <inheritdoc />
			public string DeprecatedVersion => DEPRECATED_VERSION;
			
			/// <inheritdoc />
			public string Summary => SUMMARY;
		}
		private RADIANValue _RADIAN;
		/// <inheritdoc cref="RADIANValue" path="/summary" />
		public RADIANValue RADIAN => _RADIAN ?? (_RADIAN = new RADIANValue());

		/// <summary>﻿angle in radians.<br /><br /><br />
		/// Value for NativeUnitEnum.<br/>
		/// <br/>See also <seealso cref="NativeUnitEnum">NativeUnitEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.1">v1.1</see></item>
		/// </list>
		/// </remarks>

		public sealed class RADIANValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="RADIANValue.Name" /></summary>
			public const string NAME = "RADIAN";
			/// <summary>Constant value for <see cref="RADIANValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.1";
			/// <summary>Constant value for <see cref="RADIANValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="RADIANValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;angle in radians.&#10;
";

			/// <inheritdoc />
			public string Name => NAME;
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => NORMATIVE_VERSION;
			
			/// <inheritdoc />
			public string DeprecatedVersion => DEPRECATED_VERSION;
			
			/// <inheritdoc />
			public string Summary => SUMMARY;
		}
		private RADIAN_PER_MINUTEValue _RADIAN_PER_MINUTE;
		/// <inheritdoc cref="RADIAN_PER_MINUTEValue" path="/summary" />
		public RADIAN_PER_MINUTEValue RADIAN_PER_MINUTE => _RADIAN_PER_MINUTE ?? (_RADIAN_PER_MINUTE = new RADIAN_PER_MINUTEValue());

		/// <summary>﻿velocity in radians per minute.<br /><br /><br />
		/// Value for NativeUnitEnum.<br/>
		/// <br/>See also <seealso cref="NativeUnitEnum">NativeUnitEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.1">v1.1</see></item>
		/// </list>
		/// </remarks>

		public sealed class RADIAN_PER_MINUTEValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="RADIAN_PER_MINUTEValue.Name" /></summary>
			public const string NAME = "RADIAN/MINUTE";
			/// <summary>Constant value for <see cref="RADIAN_PER_MINUTEValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.1";
			/// <summary>Constant value for <see cref="RADIAN_PER_MINUTEValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="RADIAN_PER_MINUTEValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;velocity in radians per minute.&#10;
";

			/// <inheritdoc />
			public string Name => NAME;
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => NORMATIVE_VERSION;
			
			/// <inheritdoc />
			public string DeprecatedVersion => DEPRECATED_VERSION;
			
			/// <inheritdoc />
			public string Summary => SUMMARY;
		}
		private RADIAN_PER_SECONDValue _RADIAN_PER_SECOND;
		/// <inheritdoc cref="RADIAN_PER_SECONDValue" path="/summary" />
		public RADIAN_PER_SECONDValue RADIAN_PER_SECOND => _RADIAN_PER_SECOND ?? (_RADIAN_PER_SECOND = new RADIAN_PER_SECONDValue());

		/// <summary>﻿rotational acceleration in radian per second squared.<br /><br /><br />
		/// Value for NativeUnitEnum.<br/>
		/// <br/>See also <seealso cref="NativeUnitEnum">NativeUnitEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.1">v1.1</see></item>
		/// </list>
		/// </remarks>

		public sealed class RADIAN_PER_SECONDValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="RADIAN_PER_SECONDValue.Name" /></summary>
			public const string NAME = "RADIAN/SECOND";
			/// <summary>Constant value for <see cref="RADIAN_PER_SECONDValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.1";
			/// <summary>Constant value for <see cref="RADIAN_PER_SECONDValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="RADIAN_PER_SECONDValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;rotational acceleration in radian per second squared.&#10;
";

			/// <inheritdoc />
			public string Name => NAME;
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => NORMATIVE_VERSION;
			
			/// <inheritdoc />
			public string DeprecatedVersion => DEPRECATED_VERSION;
			
			/// <inheritdoc />
			public string Summary => SUMMARY;
		}
		private RADIAN_PER_SECOND_SQUAREDValue _RADIAN_PER_SECOND_SQUARED;
		/// <inheritdoc cref="RADIAN_PER_SECOND_SQUAREDValue" path="/summary" />
		public RADIAN_PER_SECOND_SQUAREDValue RADIAN_PER_SECOND_SQUARED => _RADIAN_PER_SECOND_SQUARED ?? (_RADIAN_PER_SECOND_SQUARED = new RADIAN_PER_SECOND_SQUAREDValue());

		/// <summary>﻿rotational acceleration in radian per second squared.<br /><br /><br />
		/// Value for NativeUnitEnum.<br/>
		/// <br/>See also <seealso cref="NativeUnitEnum">NativeUnitEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.1">v1.1</see></item>
		/// </list>
		/// </remarks>

		public sealed class RADIAN_PER_SECOND_SQUAREDValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="RADIAN_PER_SECOND_SQUAREDValue.Name" /></summary>
			public const string NAME = "RADIAN/SECOND^2";
			/// <summary>Constant value for <see cref="RADIAN_PER_SECOND_SQUAREDValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.1";
			/// <summary>Constant value for <see cref="RADIAN_PER_SECOND_SQUAREDValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="RADIAN_PER_SECOND_SQUAREDValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;rotational acceleration in radian per second squared.&#10;
";

			/// <inheritdoc />
			public string Name => NAME;
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => NORMATIVE_VERSION;
			
			/// <inheritdoc />
			public string DeprecatedVersion => DEPRECATED_VERSION;
			
			/// <inheritdoc />
			public string Summary => SUMMARY;
		}
		private BARValue _BAR;
		/// <inheritdoc cref="BARValue" path="/summary" />
		public BARValue BAR => _BAR ?? (_BAR = new BARValue());

		/// <summary>﻿pressure in Bar.<br /><br /><br />
		/// Value for NativeUnitEnum.<br/>
		/// <br/>See also <seealso cref="NativeUnitEnum">NativeUnitEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.1">v1.1</see></item>
		/// </list>
		/// </remarks>

		public sealed class BARValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="BARValue.Name" /></summary>
			public const string NAME = "BAR";
			/// <summary>Constant value for <see cref="BARValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.7";
			/// <summary>Constant value for <see cref="BARValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="BARValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;pressure in Bar.&#10;
";

			/// <inheritdoc />
			public string Name => NAME;
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => NORMATIVE_VERSION;
			
			/// <inheritdoc />
			public string DeprecatedVersion => DEPRECATED_VERSION;
			
			/// <inheritdoc />
			public string Summary => SUMMARY;
		}
		private TORRValue _TORR;
		/// <inheritdoc cref="TORRValue" path="/summary" />
		public TORRValue TORR => _TORR ?? (_TORR = new TORRValue());

		/// <summary>﻿pressure in Torr.<br /><br /><br />
		/// Value for NativeUnitEnum.<br/>
		/// <br/>See also <seealso cref="NativeUnitEnum">NativeUnitEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.1">v1.1</see></item>
		/// </list>
		/// </remarks>

		public sealed class TORRValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="TORRValue.Name" /></summary>
			public const string NAME = "TORR";
			/// <summary>Constant value for <see cref="TORRValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.7";
			/// <summary>Constant value for <see cref="TORRValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="TORRValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;pressure in Torr.&#10;
";

			/// <inheritdoc />
			public string Name => NAME;
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => NORMATIVE_VERSION;
			
			/// <inheritdoc />
			public string DeprecatedVersion => DEPRECATED_VERSION;
			
			/// <inheritdoc />
			public string Summary => SUMMARY;
		}
		private MILLIMETER_MERCURYValue _MILLIMETER_MERCURY;
		/// <inheritdoc cref="MILLIMETER_MERCURYValue" path="/summary" />
		public MILLIMETER_MERCURYValue MILLIMETER_MERCURY => _MILLIMETER_MERCURY ?? (_MILLIMETER_MERCURY = new MILLIMETER_MERCURYValue());

		/// <summary>﻿pressure in Millimeter of Mercury (mmHg).<br /><br /><br />
		/// Value for NativeUnitEnum.<br/>
		/// <br/>See also <seealso cref="NativeUnitEnum">NativeUnitEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.1">v1.1</see></item>
		/// </list>
		/// </remarks>

		public sealed class MILLIMETER_MERCURYValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="MILLIMETER_MERCURYValue.Name" /></summary>
			public const string NAME = "MILLIMETER_MERCURY";
			/// <summary>Constant value for <see cref="MILLIMETER_MERCURYValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.7";
			/// <summary>Constant value for <see cref="MILLIMETER_MERCURYValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="MILLIMETER_MERCURYValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;pressure in Millimeter of Mercury (mmHg).&#10;
";

			/// <inheritdoc />
			public string Name => NAME;
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => NORMATIVE_VERSION;
			
			/// <inheritdoc />
			public string DeprecatedVersion => DEPRECATED_VERSION;
			
			/// <inheritdoc />
			public string Summary => SUMMARY;
		}
		private PASCAL_PER_MINUTEValue _PASCAL_PER_MINUTE;
		/// <inheritdoc cref="PASCAL_PER_MINUTEValue" path="/summary" />
		public PASCAL_PER_MINUTEValue PASCAL_PER_MINUTE => _PASCAL_PER_MINUTE ?? (_PASCAL_PER_MINUTE = new PASCAL_PER_MINUTEValue());

		/// <summary>﻿pascal per minute.<br /><br /><br />
		/// Value for NativeUnitEnum.<br/>
		/// <br/>See also <seealso cref="NativeUnitEnum">NativeUnitEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.1">v1.1</see></item>
		/// </list>
		/// </remarks>

		public sealed class PASCAL_PER_MINUTEValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="PASCAL_PER_MINUTEValue.Name" /></summary>
			public const string NAME = "PASCAL/MINUTE";
			/// <summary>Constant value for <see cref="PASCAL_PER_MINUTEValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.7";
			/// <summary>Constant value for <see cref="PASCAL_PER_MINUTEValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="PASCAL_PER_MINUTEValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;pascal per minute.&#10;
";

			/// <inheritdoc />
			public string Name => NAME;
			
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

		/// <summary>﻿<i>MASS\times GRAVITATIONAL_ACCELERATION</i> (g) given in <c>METER/SECOND^2</c>.<br /><br /><br />
		/// Value for NativeUnitEnum.<br/>
		/// <br/>See also <seealso cref="NativeUnitEnum">NativeUnitEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.1">v1.1</see></item>
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
			public const string SUMMARY = @"&#10;&#10;&#10;$$MASS\\times GRAVITATIONAL_ACCELERATION$$ (g) given in `METER/SECOND^2`.&#10;
";

			/// <inheritdoc />
			public string Name => NAME;
			
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

		/// <summary>﻿acceleration relative to earth's gravity given in <c>METER/SECOND^2</c>.<br /><br />&gt; Note 1 to entry: At different points on Earth's surface, the free-fall acceleration ranges from 9.764 to 9.834 m/s2 (Wikipedia: Gravitational Acceleration). The constant can be customized depending on the location in the universe.<br /><br />&gt; Note 2 to entry: In the standard, it is assumed that Earth's average value of gravitational acceleration is 9.90665 m/s2.<br /><br /><br />
		/// Value for NativeUnitEnum.<br/>
		/// <br/>See also <seealso cref="NativeUnitEnum">NativeUnitEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.1">v1.1</see></item>
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
			public const string SUMMARY = @"&#10;&#10;&#10;acceleration relative to earth's gravity given in `METER/SECOND^2`.

> Note 1 to entry: At different points on Earth's surface, the free-fall acceleration ranges from 9.764 to 9.834 m/s2 (Wikipedia: Gravitational Acceleration). The constant can be customized depending on the location in the universe.

> Note 2 to entry: In the standard, it is assumed that Earth's average value of gravitational acceleration is 9.90665 m/s2.&#10;
";

			/// <inheritdoc />
			public string Name => NAME;
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => NORMATIVE_VERSION;
			
			/// <inheritdoc />
			public string DeprecatedVersion => DEPRECATED_VERSION;
			
			/// <inheritdoc />
			public string Summary => SUMMARY;
		}
		private AMPERE_HOURValue _AMPERE_HOUR;
		/// <inheritdoc cref="AMPERE_HOURValue" path="/summary" />
		public AMPERE_HOURValue AMPERE_HOUR => _AMPERE_HOUR ?? (_AMPERE_HOUR = new AMPERE_HOURValue());

		/// <summary>﻿electric charge in ampere hour.<br /><br /><br />
		/// Value for NativeUnitEnum.<br/>
		/// <br/>See also <seealso cref="NativeUnitEnum">NativeUnitEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.1">v1.1</see></item>
		/// </list>
		/// </remarks>

		public sealed class AMPERE_HOURValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="AMPERE_HOURValue.Name" /></summary>
			public const string NAME = "AMPERE_HOUR";
			/// <summary>Constant value for <see cref="AMPERE_HOURValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "2.1";
			/// <summary>Constant value for <see cref="AMPERE_HOURValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="AMPERE_HOURValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;electric charge in ampere hour.&#10;
";

			/// <inheritdoc />
			public string Name => NAME;
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => NORMATIVE_VERSION;
			
			/// <inheritdoc />
			public string DeprecatedVersion => DEPRECATED_VERSION;
			
			/// <inheritdoc />
			public string Summary => SUMMARY;
		}
		private CUBIC_FOOT_PER_HOURValue _CUBIC_FOOT_PER_HOUR;
		/// <inheritdoc cref="CUBIC_FOOT_PER_HOURValue" path="/summary" />
		public CUBIC_FOOT_PER_HOURValue CUBIC_FOOT_PER_HOUR => _CUBIC_FOOT_PER_HOUR ?? (_CUBIC_FOOT_PER_HOUR = new CUBIC_FOOT_PER_HOURValue());

		/// <summary>﻿change of geometric volume in cubic foot per hour.<br /><br /><br />
		/// Value for NativeUnitEnum.<br/>
		/// <br/>See also <seealso cref="NativeUnitEnum">NativeUnitEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.1">v1.1</see></item>
		/// </list>
		/// </remarks>

		public sealed class CUBIC_FOOT_PER_HOURValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="CUBIC_FOOT_PER_HOURValue.Name" /></summary>
			public const string NAME = "CUBIC_FOOT/HOUR";
			/// <summary>Constant value for <see cref="CUBIC_FOOT_PER_HOURValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "2.3";
			/// <summary>Constant value for <see cref="CUBIC_FOOT_PER_HOURValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="CUBIC_FOOT_PER_HOURValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;change of geometric volume in cubic foot per hour.&#10;
";

			/// <inheritdoc />
			public string Name => NAME;
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => NORMATIVE_VERSION;
			
			/// <inheritdoc />
			public string DeprecatedVersion => DEPRECATED_VERSION;
			
			/// <inheritdoc />
			public string Summary => SUMMARY;
		}
		private CUBIC_FOOT_PER_MINUTEValue _CUBIC_FOOT_PER_MINUTE;
		/// <inheritdoc cref="CUBIC_FOOT_PER_MINUTEValue" path="/summary" />
		public CUBIC_FOOT_PER_MINUTEValue CUBIC_FOOT_PER_MINUTE => _CUBIC_FOOT_PER_MINUTE ?? (_CUBIC_FOOT_PER_MINUTE = new CUBIC_FOOT_PER_MINUTEValue());

		/// <summary>﻿change of geometric volume in cubic foot per minute.<br /><br /><br />
		/// Value for NativeUnitEnum.<br/>
		/// <br/>See also <seealso cref="NativeUnitEnum">NativeUnitEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.1">v1.1</see></item>
		/// </list>
		/// </remarks>

		public sealed class CUBIC_FOOT_PER_MINUTEValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="CUBIC_FOOT_PER_MINUTEValue.Name" /></summary>
			public const string NAME = "CUBIC_FOOT/MINUTE";
			/// <summary>Constant value for <see cref="CUBIC_FOOT_PER_MINUTEValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "2.3";
			/// <summary>Constant value for <see cref="CUBIC_FOOT_PER_MINUTEValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="CUBIC_FOOT_PER_MINUTEValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;change of geometric volume in cubic foot per minute.&#10;
";

			/// <inheritdoc />
			public string Name => NAME;
			
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