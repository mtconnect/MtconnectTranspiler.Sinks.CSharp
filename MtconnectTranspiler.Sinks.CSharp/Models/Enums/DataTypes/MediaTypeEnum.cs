#pragma warning disable CS1574 // XML comment has cref attribute that could not be resolved
#pragma warning disable CS1584 // XML comment has syntactically incorrect cref attribute
using System;
using System.CodeDom.Compiler;using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;

namespace Mtconnect.DataTypes
{
	/// <summary>﻿
	/// <br/> Visit <seealso href="https://model.mtconnect.org/#Enumeration___19_0_3_68e0225_1605297694306_501792_610">model.mtconnect.org</seealso> for more information.
	/// </summary>
	/// <remarks>
	/// <list type="bullet">
	/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.7">v1.7</see></item>
	/// </list>
	/// </remarks>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public enum MediaTypeEnum
	{
		/// <summary>﻿ISO 10303 STEP AP203 or AP242 format.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.7">v1.7</see></item>
		/// </list>
		/// </remarks>
		STEP,
		/// <summary>﻿STereoLithography file format.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.7">v1.7</see></item>
		/// </list>
		/// </remarks>
		STL,
		/// <summary>﻿Geometry Description Markup Language.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.7">v1.7</see></item>
		/// </list>
		/// </remarks>
		GDML,
		/// <summary>﻿Wavefront OBJ file format.<br /><br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.7">v1.7</see></item>
		/// </list>
		/// </remarks>
		OBJ,
		/// <summary>﻿ISO 17506.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.7">v1.7</see></item>
		/// </list>
		/// </remarks>
		COLLADA,
		/// <summary>﻿Initial Graphics Exchange Specification.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.7">v1.7</see></item>
		/// </list>
		/// </remarks>
		IGES,
		/// <summary>﻿Autodesk file format.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.7">v1.7</see></item>
		/// </list>
		/// </remarks>
		_3DS,
		/// <summary>﻿Dassault file format.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.7">v1.7</see></item>
		/// </list>
		/// </remarks>
		ACIS,
		/// <summary>﻿Parasolid XT Siemens data interchange format.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.7">v1.7</see></item>
		/// </list>
		/// </remarks>
		X_T,
	}

	/// <summary>﻿
	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Enumeration___19_0_3_68e0225_1605297694306_501792_610">model.mtconnect.org</seealso> for more information.
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public sealed class MediaTypeEnumMetaClass : IEnum
	{
		/// <inheritdoc />
		public string Name => "MediaTypeEnum";
		
		/// <inheritdoc />
		public Type DataType => null;
		
		/// <inheritdoc />
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
		/// <inheritdoc cref="STEPValue" path="/summary" />
		public STEPValue STEP => _STEP ?? (_STEP = new STEPValue());

		/// <summary>﻿ISO 10303 STEP AP203 or AP242 format.<br /><br /><br />
		/// Value for MediaTypeEnum.<br/>
		/// <br/>See also <seealso cref="MediaTypeEnum">MediaTypeEnum</seealso>
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
			public string Summary => @"&#10;&#10;&#10;ISO 10303 STEP AP203 or AP242 format.&#10;
";
		}
		private STLValue _STL;
		/// <inheritdoc cref="STLValue" path="/summary" />
		public STLValue STL => _STL ?? (_STL = new STLValue());

		/// <summary>﻿STereoLithography file format.<br /><br /><br />
		/// Value for MediaTypeEnum.<br/>
		/// <br/>See also <seealso cref="MediaTypeEnum">MediaTypeEnum</seealso>
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
			public string Summary => @"&#10;&#10;&#10;STereoLithography file format.&#10;
";
		}
		private GDMLValue _GDML;
		/// <inheritdoc cref="GDMLValue" path="/summary" />
		public GDMLValue GDML => _GDML ?? (_GDML = new GDMLValue());

		/// <summary>﻿Geometry Description Markup Language.<br /><br /><br />
		/// Value for MediaTypeEnum.<br/>
		/// <br/>See also <seealso cref="MediaTypeEnum">MediaTypeEnum</seealso>
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
			public string Summary => @"&#10;&#10;&#10;Geometry Description Markup Language.&#10;
";
		}
		private OBJValue _OBJ;
		/// <inheritdoc cref="OBJValue" path="/summary" />
		public OBJValue OBJ => _OBJ ?? (_OBJ = new OBJValue());

		/// <summary>﻿Wavefront OBJ file format.<br /><br /><br /><br />
		/// Value for MediaTypeEnum.<br/>
		/// <br/>See also <seealso cref="MediaTypeEnum">MediaTypeEnum</seealso>
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
			public string Summary => @"&#10;&#10;&#10;Wavefront OBJ file format.&#10;
";
		}
		private COLLADAValue _COLLADA;
		/// <inheritdoc cref="COLLADAValue" path="/summary" />
		public COLLADAValue COLLADA => _COLLADA ?? (_COLLADA = new COLLADAValue());

		/// <summary>﻿ISO 17506.<br /><br /><br />
		/// Value for MediaTypeEnum.<br/>
		/// <br/>See also <seealso cref="MediaTypeEnum">MediaTypeEnum</seealso>
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
			public string Summary => @"&#10;&#10;&#10;ISO 17506.&#10;
";
		}
		private IGESValue _IGES;
		/// <inheritdoc cref="IGESValue" path="/summary" />
		public IGESValue IGES => _IGES ?? (_IGES = new IGESValue());

		/// <summary>﻿Initial Graphics Exchange Specification.<br /><br /><br />
		/// Value for MediaTypeEnum.<br/>
		/// <br/>See also <seealso cref="MediaTypeEnum">MediaTypeEnum</seealso>
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
			public string Summary => @"&#10;&#10;&#10;Initial Graphics Exchange Specification.&#10;
";
		}
		private _3DSValue __3DS;
		/// <inheritdoc cref="_3DSValue" path="/summary" />
		public _3DSValue _3DS => __3DS ?? (__3DS = new _3DSValue());

		/// <summary>﻿Autodesk file format.<br /><br /><br />
		/// Value for MediaTypeEnum.<br/>
		/// <br/>See also <seealso cref="MediaTypeEnum">MediaTypeEnum</seealso>
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
			public string Summary => @"&#10;&#10;&#10;Autodesk file format.&#10;
";
		}
		private ACISValue _ACIS;
		/// <inheritdoc cref="ACISValue" path="/summary" />
		public ACISValue ACIS => _ACIS ?? (_ACIS = new ACISValue());

		/// <summary>﻿Dassault file format.<br /><br /><br />
		/// Value for MediaTypeEnum.<br/>
		/// <br/>See also <seealso cref="MediaTypeEnum">MediaTypeEnum</seealso>
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
			public string Summary => @"&#10;&#10;&#10;Dassault file format.&#10;
";
		}
		private X_TValue _X_T;
		/// <inheritdoc cref="X_TValue" path="/summary" />
		public X_TValue X_T => _X_T ?? (_X_T = new X_TValue());

		/// <summary>﻿Parasolid XT Siemens data interchange format.<br /><br /><br />
		/// Value for MediaTypeEnum.<br/>
		/// <br/>See also <seealso cref="MediaTypeEnum">MediaTypeEnum</seealso>
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
			public string Summary => @"&#10;&#10;&#10;Parasolid XT Siemens data interchange format.&#10;
";
		}
	}
}