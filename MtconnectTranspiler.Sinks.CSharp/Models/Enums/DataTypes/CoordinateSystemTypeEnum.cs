#pragma warning disable 0618
#pragma warning disable 1574
using System;
using System.CodeDom.Compiler;

namespace Mtconnect.DataTypes
{
	/// <summary>
	/// View in the MTConnect Model browser <seealso href="https://model.mtconnect.org/#Enumeration___19_0_3_45f01b9_1579107560604_392738_163543">model.mtconnect.org</seealso>
	/// </summary>
	/// <remarks>
	/// <list type="bullet">
	/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_">v</see></item>
	/// <item><b>Deprecated</b>: <see href="https://model.mtconnect.org/#_Version_">v</see></item>
	/// </list>
	/// </remarks>
	[Obsolete("Deprecated in v according to https://model.mtconnect.org/#_Version_")]
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "1.0.15.3")]
	public enum CoordinateSystemTypeEnum
	{
		/// <summary>
		/// stationary coordinate system referenced to earth, which is independent of the robot motion. <seealso href="https://www.google.com/search?q=ISO 9787:2013&btnI=I">ISO 9787:2013</seealso>  For non-robotic devices, stationary coordinate system referenced to earth, which is independent of the motion of a piece of equipment.
		/// </summary>
		WORLD,
		/// <summary>
		/// coordinate system referenced to the base mounting surface. <seealso href="https://www.google.com/search?q=ISO 9787:2013&btnI=I">ISO 9787:2013</seealso>  A base mounting surface is a connection surface between the arm and its supporting structure.<seealso href="https://www.google.com/search?q=ISO 9787:2013&btnI=I">ISO 9787:2013</seealso>  For non-robotic devices, it is the connection surface between the device and its supporting structure.
		/// </summary>
		BASE,
		/// <summary>
		/// coordinate system referenced to the object. <seealso href="https://www.google.com/search?q=ISO 9787:2013&btnI=I">ISO 9787:2013</seealso>
		/// </summary>
		OBJECT,
		/// <summary>
		/// coordinate system referenced to the site of the task. <seealso href="https://www.google.com/search?q=ISO 9787:2013&btnI=I">ISO 9787:2013</seealso>
		/// </summary>
		TASK,
		/// <summary>
		/// coordinate system referenced to the mechanical interface. <seealso href="https://www.google.com/search?q=ISO 9787:2013&btnI=I">ISO 9787:2013</seealso>
		/// </summary>
		MECHANICAL_INTERFACE,
		/// <summary>
		/// coordinate system referenced to the tool or to the end effector attached to the mechanical interface. <seealso href="https://www.google.com/search?q=ISO 9787:2013&btnI=I">ISO 9787:2013</seealso>
		/// </summary>
		TOOL,
		/// <summary>
		/// coordinate system referenced to one of the components of a mobile platform. <seealso href="https://www.google.com/search?q=ISO 8373:2012&btnI=I">ISO 8373:2012</seealso>
		/// </summary>
		MOBILE_PLATFORM,
		/// <summary>
		/// coordinate system referenced to the home position and orientation of the primary axes of a piece of equipment.
		/// </summary>
		MACHINE,
		/// <summary>
		/// coordinate system referenced to the sensor which monitors the site of the task. <seealso href="https://www.google.com/search?q=ISO 9787:2013&btnI=I">ISO 9787:2013</seealso>
		/// </summary>
		CAMERA,
	}
}