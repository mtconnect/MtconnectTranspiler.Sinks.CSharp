#pragma warning disable 0618
#pragma warning disable 1574
using System;
using System.CodeDom.Compiler;

namespace Mtconnect.DataTypes
{
	/// <summary>
	/// View in the MTConnect Model browser <seealso href="https://model.mtconnect.org/#Enumeration___19_0_3_68e0225_1605297694306_501792_610">model.mtconnect.org</seealso>
	/// </summary>
	/// <remarks>
	/// <list type="bullet">
	/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_">v</see></item>
	/// <item><b>Deprecated</b>: <see href="https://model.mtconnect.org/#_Version_">v</see></item>
	/// </list>
	/// </remarks>
	[Obsolete("Deprecated in v according to https://model.mtconnect.org/#_Version_")]
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "1.0.15.3")]
	public enum MediaTypeEnum
	{
		/// <summary>
		/// ISO 10303 STEP AP203 or AP242 format.
		/// </summary>
		STEP,
		/// <summary>
		/// STereoLithography file format.
		/// </summary>
		STL,
		/// <summary>
		/// Geometry Description Markup Language.
		/// </summary>
		GDML,
		/// <summary>
		/// Wavefront OBJ file format. 
		/// </summary>
		OBJ,
		/// <summary>
		/// ISO 17506.
		/// </summary>
		COLLADA,
		/// <summary>
		/// Initial Graphics Exchange Specification.
		/// </summary>
		IGES,
		/// <summary>
		/// Autodesk file format.
		/// </summary>
		_3DS,
		/// <summary>
		/// Dassault file format.
		/// </summary>
		ACIS,
		/// <summary>
		/// Parasolid XT Siemens data interchange format.
		/// </summary>
		X_T,
	}
}