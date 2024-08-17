#pragma warning disable CS1574 // XML comment has cref attribute that could not be resolved
#pragma warning disable CS1584 // XML comment has syntactically incorrect cref attribute
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
		/// <inheritdoc />
		public string Name => "MotionActuationTypeEnum";
		
		/// <inheritdoc />
		public Type DataType => null;
		
		/// <inheritdoc />
		public Type Instance => typeof(MotionActuationTypeEnum);

		/// <inheritdoc />
		public string NormativeVersion => "1.7";
		
		/// <inheritdoc />
		public string DeprecatedVersion => "";
		
		/// <inheritdoc />
		public string Summary => @"";
		
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
		public sealed class DIRECTValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "DIRECT";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.7";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"&#10;&#10;&#10;movement is initiated by the component.&#10;
";
		}
		private VIRTUALValue _VIRTUAL;
		/// <inheritdoc cref="VIRTUALValue" path="/summary" />
		public VIRTUALValue VIRTUAL => _VIRTUAL ?? (_VIRTUAL = new VIRTUALValue());

		/// <summary>﻿motion is computed and is used for expressing an imaginary movement.<br /><br /><br />
		/// Value for MotionActuationTypeEnum.<br/>
		/// <br/>See also <seealso cref="MotionActuationTypeEnum">MotionActuationTypeEnum</seealso>
		/// </summary>
		public sealed class VIRTUALValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "VIRTUAL";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.7";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"&#10;&#10;&#10;motion is computed and is used for expressing an imaginary movement.&#10;
";
		}
		private NONEValue _NONE;
		/// <inheritdoc cref="NONEValue" path="/summary" />
		public NONEValue NONE => _NONE ?? (_NONE = new NONEValue());

		/// <summary>﻿no actuation of this axis.<br /><br />&gt; Note: Actuation of <c>NONE</c> can be either a derived <c>REVOLUTE</c> or <c>PRISMATIC</c> motion or static <c>FIXED</c> relationship.<br /><br /><br />
		/// Value for MotionActuationTypeEnum.<br/>
		/// <br/>See also <seealso cref="MotionActuationTypeEnum">MotionActuationTypeEnum</seealso>
		/// </summary>
		public sealed class NONEValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "NONE";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.7";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"&#10;&#10;&#10;no actuation of this axis.

> Note: Actuation of `NONE` can be either a derived `REVOLUTE` or `PRISMATIC` motion or static `FIXED` relationship.&#10;
";
		}
	}
}