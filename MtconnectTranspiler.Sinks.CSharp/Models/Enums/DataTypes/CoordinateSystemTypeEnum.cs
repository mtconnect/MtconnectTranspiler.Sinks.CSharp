#pragma warning disable CS1574 // XML comment has cref attribute that could not be resolved
#pragma warning disable CS1584 // XML comment has syntactically incorrect cref attribute
using System;
using System.CodeDom.Compiler;using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;

namespace Mtconnect.DataTypes
{
	/// <summary>﻿
	/// <br/> Visit <seealso href="https://model.mtconnect.org/#Enumeration___19_0_3_45f01b9_1579107560604_392738_163543">model.mtconnect.org</seealso> for more information.
	/// </summary>
	/// <remarks>
	/// <list type="bullet">
	/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.6">v1.6</see></item>
	/// </list>
	/// </remarks>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public enum CoordinateSystemTypeEnum
	{
		/// <summary>﻿stationary coordinate system referenced to earth, which is independent of the robot motion. <seealso href="https://www.google.com/search?q=ISO 9787:2013&btnI=I">ISO 9787:2013</seealso><br /><br />For non-robotic devices, stationary coordinate system referenced to earth, which is independent of the motion of a piece of equipment.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.6">v1.6</see></item>
		/// </list>
		/// </remarks>
		WORLD,
		/// <summary>﻿coordinate system referenced to the base mounting surface. <seealso href="https://www.google.com/search?q=ISO 9787:2013&btnI=I">ISO 9787:2013</seealso><br /><br />A base mounting surface is a connection surface between the arm and its supporting structure.<seealso href="https://www.google.com/search?q=ISO 9787:2013&btnI=I">ISO 9787:2013</seealso><br /><br />For non-robotic devices, it is the connection surface between the device and its supporting structure.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.6">v1.6</see></item>
		/// </list>
		/// </remarks>
		BASE,
		/// <summary>﻿coordinate system referenced to the object. <seealso href="https://www.google.com/search?q=ISO 9787:2013&btnI=I">ISO 9787:2013</seealso><br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.6">v1.6</see></item>
		/// </list>
		/// </remarks>
		OBJECT,
		/// <summary>﻿coordinate system referenced to the site of the task. <seealso href="https://www.google.com/search?q=ISO 9787:2013&btnI=I">ISO 9787:2013</seealso><br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.6">v1.6</see></item>
		/// </list>
		/// </remarks>
		TASK,
		/// <summary>﻿coordinate system referenced to the mechanical interface. <seealso href="https://www.google.com/search?q=ISO 9787:2013&btnI=I">ISO 9787:2013</seealso><br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.6">v1.6</see></item>
		/// </list>
		/// </remarks>
		MECHANICAL_INTERFACE,
		/// <summary>﻿coordinate system referenced to the tool or to the end effector attached to the mechanical interface. <seealso href="https://www.google.com/search?q=ISO 9787:2013&btnI=I">ISO 9787:2013</seealso><br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.6">v1.6</see></item>
		/// </list>
		/// </remarks>
		TOOL,
		/// <summary>﻿coordinate system referenced to one of the components of a mobile platform. <seealso href="https://www.google.com/search?q=ISO 8373:2012&btnI=I">ISO 8373:2012</seealso><br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.6">v1.6</see></item>
		/// </list>
		/// </remarks>
		MOBILE_PLATFORM,
		/// <summary>﻿coordinate system referenced to the home position and orientation of the primary axes of a piece of equipment.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.6">v1.6</see></item>
		/// </list>
		/// </remarks>
		MACHINE,
		/// <summary>﻿coordinate system referenced to the sensor which monitors the site of the task. <seealso href="https://www.google.com/search?q=ISO 9787:2013&btnI=I">ISO 9787:2013</seealso><br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.6">v1.6</see></item>
		/// </list>
		/// </remarks>
		CAMERA,
	}

	/// <summary>﻿
	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Enumeration___19_0_3_45f01b9_1579107560604_392738_163543">model.mtconnect.org</seealso> for more information.
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public sealed class CoordinateSystemTypeEnumMetaClass : IEnum
	{
		/// <inheritdoc />
		public string Name => "CoordinateSystemTypeEnum";
		
		/// <inheritdoc />
		public Type DataType => null;
		
		/// <inheritdoc />
		public Type Instance => typeof(CoordinateSystemTypeEnum);

		/// <inheritdoc />
		public string NormativeVersion => "1.6";
		
		/// <inheritdoc />
		public string DeprecatedVersion => "";
		
		/// <inheritdoc />
		public string Summary => @"";
		
		/// <inheritdoc />
		public IEnumInstance[] Values => new IEnumInstance[] {
		WORLD,
		BASE,
		OBJECT,
		TASK,
		MECHANICAL_INTERFACE,
		TOOL,
		MOBILE_PLATFORM,
		MACHINE,
		CAMERA,
		};

		private WORLDValue _WORLD;
		/// <inheritdoc cref="WORLDValue" path="/summary" />
		public WORLDValue WORLD => _WORLD ?? (_WORLD = new WORLDValue());

		/// <summary>﻿stationary coordinate system referenced to earth, which is independent of the robot motion. <seealso href="https://www.google.com/search?q=ISO 9787:2013&btnI=I">ISO 9787:2013</seealso><br /><br />For non-robotic devices, stationary coordinate system referenced to earth, which is independent of the motion of a piece of equipment.<br /><br /><br />
		/// Value for CoordinateSystemTypeEnum.<br/>
		/// <br/>See also <seealso cref="CoordinateSystemTypeEnum">CoordinateSystemTypeEnum</seealso>
		/// </summary>
		public sealed class WORLDValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "WORLD";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.6";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"&#10;&#10;&#10;stationary coordinate system referenced to earth, which is independent of the robot motion. {{cite(ISO 9787:2013)}}

For non-robotic devices, stationary coordinate system referenced to earth, which is independent of the motion of a piece of equipment.&#10;
";
		}
		private BASEValue _BASE;
		/// <inheritdoc cref="BASEValue" path="/summary" />
		public BASEValue BASE => _BASE ?? (_BASE = new BASEValue());

		/// <summary>﻿coordinate system referenced to the base mounting surface. <seealso href="https://www.google.com/search?q=ISO 9787:2013&btnI=I">ISO 9787:2013</seealso><br /><br />A base mounting surface is a connection surface between the arm and its supporting structure.<seealso href="https://www.google.com/search?q=ISO 9787:2013&btnI=I">ISO 9787:2013</seealso><br /><br />For non-robotic devices, it is the connection surface between the device and its supporting structure.<br /><br /><br />
		/// Value for CoordinateSystemTypeEnum.<br/>
		/// <br/>See also <seealso cref="CoordinateSystemTypeEnum">CoordinateSystemTypeEnum</seealso>
		/// </summary>
		public sealed class BASEValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "BASE";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.6";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"&#10;&#10;&#10;coordinate system referenced to the base mounting surface. {{cite(ISO 9787:2013)}}

A base mounting surface is a connection surface between the arm and its supporting structure.{{cite(ISO 9787:2013)}}

For non-robotic devices, it is the connection surface between the device and its supporting structure.&#10;
";
		}
		private OBJECTValue _OBJECT;
		/// <inheritdoc cref="OBJECTValue" path="/summary" />
		public OBJECTValue OBJECT => _OBJECT ?? (_OBJECT = new OBJECTValue());

		/// <summary>﻿coordinate system referenced to the object. <seealso href="https://www.google.com/search?q=ISO 9787:2013&btnI=I">ISO 9787:2013</seealso><br /><br /><br />
		/// Value for CoordinateSystemTypeEnum.<br/>
		/// <br/>See also <seealso cref="CoordinateSystemTypeEnum">CoordinateSystemTypeEnum</seealso>
		/// </summary>
		public sealed class OBJECTValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "OBJECT";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.6";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"&#10;&#10;&#10;coordinate system referenced to the object. {{cite(ISO 9787:2013)}}&#10;
";
		}
		private TASKValue _TASK;
		/// <inheritdoc cref="TASKValue" path="/summary" />
		public TASKValue TASK => _TASK ?? (_TASK = new TASKValue());

		/// <summary>﻿coordinate system referenced to the site of the task. <seealso href="https://www.google.com/search?q=ISO 9787:2013&btnI=I">ISO 9787:2013</seealso><br /><br /><br />
		/// Value for CoordinateSystemTypeEnum.<br/>
		/// <br/>See also <seealso cref="CoordinateSystemTypeEnum">CoordinateSystemTypeEnum</seealso>
		/// </summary>
		public sealed class TASKValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "TASK";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.6";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"&#10;&#10;&#10;coordinate system referenced to the site of the task. {{cite(ISO 9787:2013)}}&#10;
";
		}
		private MECHANICAL_INTERFACEValue _MECHANICAL_INTERFACE;
		/// <inheritdoc cref="MECHANICAL_INTERFACEValue" path="/summary" />
		public MECHANICAL_INTERFACEValue MECHANICAL_INTERFACE => _MECHANICAL_INTERFACE ?? (_MECHANICAL_INTERFACE = new MECHANICAL_INTERFACEValue());

		/// <summary>﻿coordinate system referenced to the mechanical interface. <seealso href="https://www.google.com/search?q=ISO 9787:2013&btnI=I">ISO 9787:2013</seealso><br /><br /><br />
		/// Value for CoordinateSystemTypeEnum.<br/>
		/// <br/>See also <seealso cref="CoordinateSystemTypeEnum">CoordinateSystemTypeEnum</seealso>
		/// </summary>
		public sealed class MECHANICAL_INTERFACEValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "MECHANICAL_INTERFACE";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.6";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"&#10;&#10;&#10;coordinate system referenced to the mechanical interface. {{cite(ISO 9787:2013)}}&#10;
";
		}
		private TOOLValue _TOOL;
		/// <inheritdoc cref="TOOLValue" path="/summary" />
		public TOOLValue TOOL => _TOOL ?? (_TOOL = new TOOLValue());

		/// <summary>﻿coordinate system referenced to the tool or to the end effector attached to the mechanical interface. <seealso href="https://www.google.com/search?q=ISO 9787:2013&btnI=I">ISO 9787:2013</seealso><br /><br /><br />
		/// Value for CoordinateSystemTypeEnum.<br/>
		/// <br/>See also <seealso cref="CoordinateSystemTypeEnum">CoordinateSystemTypeEnum</seealso>
		/// </summary>
		public sealed class TOOLValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "TOOL";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.6";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"&#10;&#10;&#10;coordinate system referenced to the tool or to the end effector attached to the mechanical interface. {{cite(ISO 9787:2013)}}&#10;
";
		}
		private MOBILE_PLATFORMValue _MOBILE_PLATFORM;
		/// <inheritdoc cref="MOBILE_PLATFORMValue" path="/summary" />
		public MOBILE_PLATFORMValue MOBILE_PLATFORM => _MOBILE_PLATFORM ?? (_MOBILE_PLATFORM = new MOBILE_PLATFORMValue());

		/// <summary>﻿coordinate system referenced to one of the components of a mobile platform. <seealso href="https://www.google.com/search?q=ISO 8373:2012&btnI=I">ISO 8373:2012</seealso><br /><br /><br />
		/// Value for CoordinateSystemTypeEnum.<br/>
		/// <br/>See also <seealso cref="CoordinateSystemTypeEnum">CoordinateSystemTypeEnum</seealso>
		/// </summary>
		public sealed class MOBILE_PLATFORMValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "MOBILE_PLATFORM";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.6";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"&#10;&#10;&#10;coordinate system referenced to one of the components of a mobile platform. {{cite(ISO 8373:2012)}}&#10;
";
		}
		private MACHINEValue _MACHINE;
		/// <inheritdoc cref="MACHINEValue" path="/summary" />
		public MACHINEValue MACHINE => _MACHINE ?? (_MACHINE = new MACHINEValue());

		/// <summary>﻿coordinate system referenced to the home position and orientation of the primary axes of a piece of equipment.<br /><br /><br />
		/// Value for CoordinateSystemTypeEnum.<br/>
		/// <br/>See also <seealso cref="CoordinateSystemTypeEnum">CoordinateSystemTypeEnum</seealso>
		/// </summary>
		public sealed class MACHINEValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "MACHINE";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.6";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"&#10;&#10;&#10;coordinate system referenced to the home position and orientation of the primary axes of a piece of equipment.&#10;
";
		}
		private CAMERAValue _CAMERA;
		/// <inheritdoc cref="CAMERAValue" path="/summary" />
		public CAMERAValue CAMERA => _CAMERA ?? (_CAMERA = new CAMERAValue());

		/// <summary>﻿coordinate system referenced to the sensor which monitors the site of the task. <seealso href="https://www.google.com/search?q=ISO 9787:2013&btnI=I">ISO 9787:2013</seealso><br /><br /><br />
		/// Value for CoordinateSystemTypeEnum.<br/>
		/// <br/>See also <seealso cref="CoordinateSystemTypeEnum">CoordinateSystemTypeEnum</seealso>
		/// </summary>
		public sealed class CAMERAValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "CAMERA";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.6";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"&#10;&#10;&#10;coordinate system referenced to the sensor which monitors the site of the task. {{cite(ISO 9787:2013)}}&#10;
";
		}
	}
}