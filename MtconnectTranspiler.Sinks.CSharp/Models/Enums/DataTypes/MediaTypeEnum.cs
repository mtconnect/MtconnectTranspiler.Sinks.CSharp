using System;
using System.CodeDom.Compiler;using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;

namespace Mtconnect.DataTypes
{
	/// <summary>
	/// View in the MTConnect Model browser <seealso href="https://model.mtconnect.org/#Enumeration___19_0_3_68e0225_1605297694306_501792_610">model.mtconnect.org</seealso>
	/// </summary>
	/// <remarks>
	/// <list type="bullet">
	/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.7">v1.7</see></item>
	/// </list>
	/// </remarks>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.3.0.0")]
	public enum MediaTypeEnum
	{
		/// <summary>
		/// ISO 10303 STEP AP203 or AP242 format.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.7">v1.7</see></item>
		/// </list>
		/// </remarks>
		STEP,
		/// <summary>
		/// STereoLithography file format.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.7">v1.7</see></item>
		/// </list>
		/// </remarks>
		STL,
		/// <summary>
		/// Geometry Description Markup Language.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.7">v1.7</see></item>
		/// </list>
		/// </remarks>
		GDML,
		/// <summary>
		/// Wavefront OBJ file format. 
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.7">v1.7</see></item>
		/// </list>
		/// </remarks>
		OBJ,
		/// <summary>
		/// ISO 17506.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.7">v1.7</see></item>
		/// </list>
		/// </remarks>
		COLLADA,
		/// <summary>
		/// Initial Graphics Exchange Specification.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.7">v1.7</see></item>
		/// </list>
		/// </remarks>
		IGES,
		/// <summary>
		/// Autodesk file format.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.7">v1.7</see></item>
		/// </list>
		/// </remarks>
		_3DS,
		/// <summary>
		/// Dassault file format.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.7">v1.7</see></item>
		/// </list>
		/// </remarks>
		ACIS,
		/// <summary>
		/// Parasolid XT Siemens data interchange format.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.7">v1.7</see></item>
		/// </list>
		/// </remarks>
		X_T,
	}

	/// <summary>
	/// View in the MTConnect Model browser <seealso href="https://model.mtconnect.org/#Enumeration___19_0_3_68e0225_1605297694306_501792_610">model.mtconnect.org</seealso>
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.3.0.0")]
	public sealed class MediaTypeEnumMetaClass : IEnum
	{
		/// <inheritdoc />
		public string Name => "MediaTypeEnum";
		
		/// <inheritdoc />
		public Type DataType => null;
		
		public Type Instance => typeof(MediaTypeEnum);

		/// <inheritdoc />
		public string NormativeVersion => "1.7";
		
		/// <inheritdoc />
		public string DeprecatedVersion => "";
		
		/// <inheritdoc />
		public string Summary => @"";
		
		/// <inheritdoc />
		public IEnumInstance[] Values => new IEnumInstance[] {
		STEP,
		STL,
		GDML,
		OBJ,
		COLLADA,
		IGES,
		_3DS,
		ACIS,
		X_T,
		};

		private STEPValue _STEP;
		/// <summary>
		/// ISO 10303 STEP AP203 or AP242 format.
		/// </summary>
		public STEPValue STEP => _STEP ?? (_STEP = new STEPValue());

		/// <summary>
		/// ISO 10303 STEP AP203 or AP242 format.
		/// </summary>
		public sealed class STEPValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "STEP";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.7";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// ISO 10303 STEP AP203 or AP242 format.";
		}
		private STLValue _STL;
		/// <summary>
		/// STereoLithography file format.
		/// </summary>
		public STLValue STL => _STL ?? (_STL = new STLValue());

		/// <summary>
		/// STereoLithography file format.
		/// </summary>
		public sealed class STLValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "STL";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.7";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// STereoLithography file format.";
		}
		private GDMLValue _GDML;
		/// <summary>
		/// Geometry Description Markup Language.
		/// </summary>
		public GDMLValue GDML => _GDML ?? (_GDML = new GDMLValue());

		/// <summary>
		/// Geometry Description Markup Language.
		/// </summary>
		public sealed class GDMLValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "GDML";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.7";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// Geometry Description Markup Language.";
		}
		private OBJValue _OBJ;
		/// <summary>
		/// Wavefront OBJ file format. 
		/// </summary>
		public OBJValue OBJ => _OBJ ?? (_OBJ = new OBJValue());

		/// <summary>
		/// Wavefront OBJ file format. 
		/// </summary>
		public sealed class OBJValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "OBJ";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.7";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// Wavefront OBJ file format. ";
		}
		private COLLADAValue _COLLADA;
		/// <summary>
		/// ISO 17506.
		/// </summary>
		public COLLADAValue COLLADA => _COLLADA ?? (_COLLADA = new COLLADAValue());

		/// <summary>
		/// ISO 17506.
		/// </summary>
		public sealed class COLLADAValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "COLLADA";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.7";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// ISO 17506.";
		}
		private IGESValue _IGES;
		/// <summary>
		/// Initial Graphics Exchange Specification.
		/// </summary>
		public IGESValue IGES => _IGES ?? (_IGES = new IGESValue());

		/// <summary>
		/// Initial Graphics Exchange Specification.
		/// </summary>
		public sealed class IGESValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "IGES";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.7";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// Initial Graphics Exchange Specification.";
		}
		private _3DSValue __3DS;
		/// <summary>
		/// Autodesk file format.
		/// </summary>
		public _3DSValue _3DS => __3DS ?? (__3DS = new _3DSValue());

		/// <summary>
		/// Autodesk file format.
		/// </summary>
		public sealed class _3DSValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "3DS";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.7";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// Autodesk file format.";
		}
		private ACISValue _ACIS;
		/// <summary>
		/// Dassault file format.
		/// </summary>
		public ACISValue ACIS => _ACIS ?? (_ACIS = new ACISValue());

		/// <summary>
		/// Dassault file format.
		/// </summary>
		public sealed class ACISValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "ACIS";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.7";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// Dassault file format.";
		}
		private X_TValue _X_T;
		/// <summary>
		/// Parasolid XT Siemens data interchange format.
		/// </summary>
		public X_TValue X_T => _X_T ?? (_X_T = new X_TValue());

		/// <summary>
		/// Parasolid XT Siemens data interchange format.
		/// </summary>
		public sealed class X_TValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "X_T";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.7";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// Parasolid XT Siemens data interchange format.";
		}
	}
}