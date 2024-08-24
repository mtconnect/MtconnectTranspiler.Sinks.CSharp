#pragma warning disable CS1574 // XML comment has cref attribute that could not be resolved
#pragma warning disable CS1584 // XML comment has syntactically incorrect cref attribute
#pragma warning disable CS0618 // Type or member is obsolete
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
		/// <summary>Constant value for <see cref="MediaTypeEnumMetaClass.ReferenceId" /></summary>
		public const string REFERENCE_ID = "_19_0_3_68e0225_1605297694306_501792_610";
		/// <summary>Constant value for <see cref="MediaTypeEnumMetaClass.HelpUrl" /></summary>
		public const string HELP_URL = "https://model.mtconnect.org/#Enumeration___19_0_3_68e0225_1605297694306_501792_610";
		/// <summary>Constant value for <see cref="MediaTypeEnumMetaClass.Name" /></summary>
		public const string NAME = "MediaTypeEnum";
		/// <summary>Constant value for <see cref="MediaTypeEnumMetaClass.NormativeVersion" /></summary>
		public const string NORMATIVE_VERSION = "1.7";
		/// <summary>Constant value for <see cref="MediaTypeEnumMetaClass.DeprecatedVersion" /></summary>
		public const string DEPRECATED_VERSION = "";
		/// <summary>Constant value for <see cref="MediaTypeEnumMetaClass.Summary" /></summary>
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
		public Type Instance => typeof(MediaTypeEnum);

		/// <inheritdoc />
		public string NormativeVersion => NORMATIVE_VERSION;
		
		/// <inheritdoc />
		public string DeprecatedVersion => DEPRECATED_VERSION;
		
		/// <inheritdoc />
		public string Summary => SUMMARY;
		
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
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.7">v1.7</see></item>
		/// </list>
		/// </remarks>

		public sealed class STEPValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="STEPValue.Name" /></summary>
			public const string NAME = "STEP";
			/// <summary>Constant value for <see cref="STEPValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.7";
			/// <summary>Constant value for <see cref="STEPValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="STEPValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;ISO 10303 STEP AP203 or AP242 format.&#10;
";

			/// <inheritdoc />
			public string Name => NAME;
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => NORMATIVE_VERSION;
			
			/// <inheritdoc />
			public string DeprecatedVersion => DEPRECATED_VERSION;
			
			/// <inheritdoc />
			public string Summary => SUMMARY;
		}
		private STLValue _STL;
		/// <inheritdoc cref="STLValue" path="/summary" />
		public STLValue STL => _STL ?? (_STL = new STLValue());

		/// <summary>﻿STereoLithography file format.<br /><br /><br />
		/// Value for MediaTypeEnum.<br/>
		/// <br/>See also <seealso cref="MediaTypeEnum">MediaTypeEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.7">v1.7</see></item>
		/// </list>
		/// </remarks>

		public sealed class STLValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="STLValue.Name" /></summary>
			public const string NAME = "STL";
			/// <summary>Constant value for <see cref="STLValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.7";
			/// <summary>Constant value for <see cref="STLValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="STLValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;STereoLithography file format.&#10;
";

			/// <inheritdoc />
			public string Name => NAME;
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => NORMATIVE_VERSION;
			
			/// <inheritdoc />
			public string DeprecatedVersion => DEPRECATED_VERSION;
			
			/// <inheritdoc />
			public string Summary => SUMMARY;
		}
		private GDMLValue _GDML;
		/// <inheritdoc cref="GDMLValue" path="/summary" />
		public GDMLValue GDML => _GDML ?? (_GDML = new GDMLValue());

		/// <summary>﻿Geometry Description Markup Language.<br /><br /><br />
		/// Value for MediaTypeEnum.<br/>
		/// <br/>See also <seealso cref="MediaTypeEnum">MediaTypeEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.7">v1.7</see></item>
		/// </list>
		/// </remarks>

		public sealed class GDMLValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="GDMLValue.Name" /></summary>
			public const string NAME = "GDML";
			/// <summary>Constant value for <see cref="GDMLValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.7";
			/// <summary>Constant value for <see cref="GDMLValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="GDMLValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;Geometry Description Markup Language.&#10;
";

			/// <inheritdoc />
			public string Name => NAME;
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => NORMATIVE_VERSION;
			
			/// <inheritdoc />
			public string DeprecatedVersion => DEPRECATED_VERSION;
			
			/// <inheritdoc />
			public string Summary => SUMMARY;
		}
		private OBJValue _OBJ;
		/// <inheritdoc cref="OBJValue" path="/summary" />
		public OBJValue OBJ => _OBJ ?? (_OBJ = new OBJValue());

		/// <summary>﻿Wavefront OBJ file format.<br /><br /><br /><br />
		/// Value for MediaTypeEnum.<br/>
		/// <br/>See also <seealso cref="MediaTypeEnum">MediaTypeEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.7">v1.7</see></item>
		/// </list>
		/// </remarks>

		public sealed class OBJValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="OBJValue.Name" /></summary>
			public const string NAME = "OBJ";
			/// <summary>Constant value for <see cref="OBJValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.7";
			/// <summary>Constant value for <see cref="OBJValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="OBJValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;Wavefront OBJ file format.&#10;
";

			/// <inheritdoc />
			public string Name => NAME;
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => NORMATIVE_VERSION;
			
			/// <inheritdoc />
			public string DeprecatedVersion => DEPRECATED_VERSION;
			
			/// <inheritdoc />
			public string Summary => SUMMARY;
		}
		private COLLADAValue _COLLADA;
		/// <inheritdoc cref="COLLADAValue" path="/summary" />
		public COLLADAValue COLLADA => _COLLADA ?? (_COLLADA = new COLLADAValue());

		/// <summary>﻿ISO 17506.<br /><br /><br />
		/// Value for MediaTypeEnum.<br/>
		/// <br/>See also <seealso cref="MediaTypeEnum">MediaTypeEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.7">v1.7</see></item>
		/// </list>
		/// </remarks>

		public sealed class COLLADAValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="COLLADAValue.Name" /></summary>
			public const string NAME = "COLLADA";
			/// <summary>Constant value for <see cref="COLLADAValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.7";
			/// <summary>Constant value for <see cref="COLLADAValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="COLLADAValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;ISO 17506.&#10;
";

			/// <inheritdoc />
			public string Name => NAME;
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => NORMATIVE_VERSION;
			
			/// <inheritdoc />
			public string DeprecatedVersion => DEPRECATED_VERSION;
			
			/// <inheritdoc />
			public string Summary => SUMMARY;
		}
		private IGESValue _IGES;
		/// <inheritdoc cref="IGESValue" path="/summary" />
		public IGESValue IGES => _IGES ?? (_IGES = new IGESValue());

		/// <summary>﻿Initial Graphics Exchange Specification.<br /><br /><br />
		/// Value for MediaTypeEnum.<br/>
		/// <br/>See also <seealso cref="MediaTypeEnum">MediaTypeEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.7">v1.7</see></item>
		/// </list>
		/// </remarks>

		public sealed class IGESValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="IGESValue.Name" /></summary>
			public const string NAME = "IGES";
			/// <summary>Constant value for <see cref="IGESValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.7";
			/// <summary>Constant value for <see cref="IGESValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="IGESValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;Initial Graphics Exchange Specification.&#10;
";

			/// <inheritdoc />
			public string Name => NAME;
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => NORMATIVE_VERSION;
			
			/// <inheritdoc />
			public string DeprecatedVersion => DEPRECATED_VERSION;
			
			/// <inheritdoc />
			public string Summary => SUMMARY;
		}
		private _3DSValue __3DS;
		/// <inheritdoc cref="_3DSValue" path="/summary" />
		public _3DSValue _3DS => __3DS ?? (__3DS = new _3DSValue());

		/// <summary>﻿Autodesk file format.<br /><br /><br />
		/// Value for MediaTypeEnum.<br/>
		/// <br/>See also <seealso cref="MediaTypeEnum">MediaTypeEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.7">v1.7</see></item>
		/// </list>
		/// </remarks>

		public sealed class _3DSValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="_3DSValue.Name" /></summary>
			public const string NAME = "3DS";
			/// <summary>Constant value for <see cref="_3DSValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.7";
			/// <summary>Constant value for <see cref="_3DSValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="_3DSValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;Autodesk file format.&#10;
";

			/// <inheritdoc />
			public string Name => NAME;
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => NORMATIVE_VERSION;
			
			/// <inheritdoc />
			public string DeprecatedVersion => DEPRECATED_VERSION;
			
			/// <inheritdoc />
			public string Summary => SUMMARY;
		}
		private ACISValue _ACIS;
		/// <inheritdoc cref="ACISValue" path="/summary" />
		public ACISValue ACIS => _ACIS ?? (_ACIS = new ACISValue());

		/// <summary>﻿Dassault file format.<br /><br /><br />
		/// Value for MediaTypeEnum.<br/>
		/// <br/>See also <seealso cref="MediaTypeEnum">MediaTypeEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.7">v1.7</see></item>
		/// </list>
		/// </remarks>

		public sealed class ACISValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="ACISValue.Name" /></summary>
			public const string NAME = "ACIS";
			/// <summary>Constant value for <see cref="ACISValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.7";
			/// <summary>Constant value for <see cref="ACISValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="ACISValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;Dassault file format.&#10;
";

			/// <inheritdoc />
			public string Name => NAME;
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => NORMATIVE_VERSION;
			
			/// <inheritdoc />
			public string DeprecatedVersion => DEPRECATED_VERSION;
			
			/// <inheritdoc />
			public string Summary => SUMMARY;
		}
		private X_TValue _X_T;
		/// <inheritdoc cref="X_TValue" path="/summary" />
		public X_TValue X_T => _X_T ?? (_X_T = new X_TValue());

		/// <summary>﻿Parasolid XT Siemens data interchange format.<br /><br /><br />
		/// Value for MediaTypeEnum.<br/>
		/// <br/>See also <seealso cref="MediaTypeEnum">MediaTypeEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.7">v1.7</see></item>
		/// </list>
		/// </remarks>

		public sealed class X_TValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="X_TValue.Name" /></summary>
			public const string NAME = "X_T";
			/// <summary>Constant value for <see cref="X_TValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.7";
			/// <summary>Constant value for <see cref="X_TValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="X_TValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;Parasolid XT Siemens data interchange format.&#10;
";

			/// <inheritdoc />
			public string Name => NAME;
			
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