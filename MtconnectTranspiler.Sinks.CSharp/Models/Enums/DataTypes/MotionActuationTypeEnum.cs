#pragma warning disable CS1574 // XML comment has cref attribute that could not be resolved
#pragma warning disable CS1584 // XML comment has syntactically incorrect cref attribute
#pragma warning disable CS0618 // Type or member is obsolete
using System;
using System.CodeDom.Compiler;using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;

namespace Mtconnect.DataTypes
{
	/// <summary>﻿
	/// <br/> Visit <seealso href="https://model.mtconnect.org/#Enumeration__EAID_C5CA1571_EA21_4123_942E_7329B6C61618">model.mtconnect.org</seealso> for more information.
	/// </summary>
	/// <remarks>
	/// <list type="bullet">
	/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.7">v1.7</see></item>
	/// </list>
	/// </remarks>

	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public enum MotionActuationTypeEnum
	{
		/// <summary>﻿movement is initiated by the component.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.7">v1.7</see></item>
		/// </list>
		/// </remarks>

		DIRECT,
		/// <summary>﻿motion is computed and is used for expressing an imaginary movement.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.7">v1.7</see></item>
		/// </list>
		/// </remarks>

		VIRTUAL,
		/// <summary>﻿no actuation of this axis.<br /><br />&gt; Note: Actuation of <c>NONE</c> can be either a derived <c>REVOLUTE</c> or <c>PRISMATIC</c> motion or static <c>FIXED</c> relationship.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.7">v1.7</see></item>
		/// </list>
		/// </remarks>

		NONE,
	}

	/// <summary>﻿
	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Enumeration__EAID_C5CA1571_EA21_4123_942E_7329B6C61618">model.mtconnect.org</seealso> for more information.
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public sealed class MotionActuationTypeEnumMetaClass : IEnum
	{
		/// <summary>Constant value for <see cref="MotionActuationTypeEnumMetaClass.ReferenceId" /></summary>
		public const string REFERENCE_ID = "EAID_C5CA1571_EA21_4123_942E_7329B6C61618";
		/// <summary>Constant value for <see cref="MotionActuationTypeEnumMetaClass.HelpUrl" /></summary>
		public const string HELP_URL = "https://model.mtconnect.org/#Enumeration__EAID_C5CA1571_EA21_4123_942E_7329B6C61618";
		/// <summary>Constant value for <see cref="MotionActuationTypeEnumMetaClass.Name" /></summary>
		public const string NAME = "MotionActuationTypeEnum";
		/// <summary>Constant value for <see cref="MotionActuationTypeEnumMetaClass.NormativeVersion" /></summary>
		public const string NORMATIVE_VERSION = "1.7";
		/// <summary>Constant value for <see cref="MotionActuationTypeEnumMetaClass.DeprecatedVersion" /></summary>
		public const string DEPRECATED_VERSION = "";
		/// <summary>Constant value for <see cref="MotionActuationTypeEnumMetaClass.Summary" /></summary>
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
		public Type Instance => typeof(MotionActuationTypeEnum);

		/// <inheritdoc />
		public string NormativeVersion => NORMATIVE_VERSION;
		
		/// <inheritdoc />
		public string DeprecatedVersion => DEPRECATED_VERSION;
		
		/// <inheritdoc />
		public string Summary => SUMMARY;
		
		/// <inheritdoc />
		public IEnumInstance[] Values => new IEnumInstance[] {
		DIRECT,
		VIRTUAL,
		NONE,
		};

		private DIRECTValue _DIRECT;
		/// <inheritdoc cref="DIRECTValue" path="/summary" />
		public DIRECTValue DIRECT => _DIRECT ?? (_DIRECT = new DIRECTValue());

		/// <summary>﻿movement is initiated by the component.<br /><br /><br />
		/// Value for MotionActuationTypeEnum.<br/>
		/// <br/>See also <seealso cref="MotionActuationTypeEnum">MotionActuationTypeEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.7">v1.7</see></item>
		/// </list>
		/// </remarks>

		public sealed class DIRECTValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="DIRECTValue.Name" /></summary>
			public const string NAME = "DIRECT";
			/// <summary>Constant value for <see cref="DIRECTValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.7";
			/// <summary>Constant value for <see cref="DIRECTValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="DIRECTValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;movement is initiated by the component.&#10;
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
		private VIRTUALValue _VIRTUAL;
		/// <inheritdoc cref="VIRTUALValue" path="/summary" />
		public VIRTUALValue VIRTUAL => _VIRTUAL ?? (_VIRTUAL = new VIRTUALValue());

		/// <summary>﻿motion is computed and is used for expressing an imaginary movement.<br /><br /><br />
		/// Value for MotionActuationTypeEnum.<br/>
		/// <br/>See also <seealso cref="MotionActuationTypeEnum">MotionActuationTypeEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.7">v1.7</see></item>
		/// </list>
		/// </remarks>

		public sealed class VIRTUALValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="VIRTUALValue.Name" /></summary>
			public const string NAME = "VIRTUAL";
			/// <summary>Constant value for <see cref="VIRTUALValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.7";
			/// <summary>Constant value for <see cref="VIRTUALValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="VIRTUALValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;motion is computed and is used for expressing an imaginary movement.&#10;
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
		private NONEValue _NONE;
		/// <inheritdoc cref="NONEValue" path="/summary" />
		public NONEValue NONE => _NONE ?? (_NONE = new NONEValue());

		/// <summary>﻿no actuation of this axis.<br /><br />&gt; Note: Actuation of <c>NONE</c> can be either a derived <c>REVOLUTE</c> or <c>PRISMATIC</c> motion or static <c>FIXED</c> relationship.<br /><br /><br />
		/// Value for MotionActuationTypeEnum.<br/>
		/// <br/>See also <seealso cref="MotionActuationTypeEnum">MotionActuationTypeEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.7">v1.7</see></item>
		/// </list>
		/// </remarks>

		public sealed class NONEValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="NONEValue.Name" /></summary>
			public const string NAME = "NONE";
			/// <summary>Constant value for <see cref="NONEValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.7";
			/// <summary>Constant value for <see cref="NONEValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="NONEValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;no actuation of this axis.

> Note: Actuation of `NONE` can be either a derived `REVOLUTE` or `PRISMATIC` motion or static `FIXED` relationship.&#10;
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