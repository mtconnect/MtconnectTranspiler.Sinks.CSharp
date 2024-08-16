using System;
using System.CodeDom.Compiler;using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;

namespace Mtconnect.DataTypes
{
	/// <summary>
	/// View in the MTConnect Model browser <seealso href="https://model.mtconnect.org/#Enumeration__EAID_C5CA1571_EA21_4123_942E_7329B6C61618">model.mtconnect.org</seealso>
	﻿
	/// </summary>
	/// <remarks>
	/// <list type="bullet">
	/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.7">v1.7</see></item>
	/// </list>
	/// </remarks>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public enum MotionActuationTypeEnum
	{
		/// <summary>
		﻿/// movement is initiated by the component.<br/><br />

		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.7">v1.7</see></item>
		/// </list>
		/// </remarks>
		DIRECT,
		/// <summary>
		﻿/// motion is computed and is used for expressing an imaginary movement.<br/><br />

		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.7">v1.7</see></item>
		/// </list>
		/// </remarks>
		VIRTUAL,
		/// <summary>
		﻿/// no actuation of this axis.<br /><br />> Note: Actuation of <c>NONE</c> can be either a derived <c>REVOLUTE</c> or <c>PRISMATIC</c> motion or static <c>FIXED</c> relationship.<br/><br />

		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.7">v1.7</see></item>
		/// </list>
		/// </remarks>
		NONE,
	}

	/// <summary>
	/// View in the MTConnect Model browser <seealso href="https://model.mtconnect.org/#Enumeration__EAID_C5CA1571_EA21_4123_942E_7329B6C61618">model.mtconnect.org</seealso>
	﻿
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public sealed class MotionActuationTypeEnumMetaClass : IEnum
	{
		/// <inheritdoc />
		public string Name => "MotionActuationTypeEnum";
		
		/// <inheritdoc />
		public Type DataType => null;
		
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
		/// <summary>
		﻿/// movement is initiated by the component.<br/><br />

		/// </summary>
		public DIRECTValue DIRECT => _DIRECT ?? (_DIRECT = new DIRECTValue());

		/// <summary>
		﻿/// movement is initiated by the component.<br/><br />

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
		/// <summary>
		﻿/// motion is computed and is used for expressing an imaginary movement.<br/><br />

		/// </summary>
		public VIRTUALValue VIRTUAL => _VIRTUAL ?? (_VIRTUAL = new VIRTUALValue());

		/// <summary>
		﻿/// motion is computed and is used for expressing an imaginary movement.<br/><br />

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
		/// <summary>
		﻿/// no actuation of this axis.<br /><br />> Note: Actuation of <c>NONE</c> can be either a derived <c>REVOLUTE</c> or <c>PRISMATIC</c> motion or static <c>FIXED</c> relationship.<br/><br />

		/// </summary>
		public NONEValue NONE => _NONE ?? (_NONE = new NONEValue());

		/// <summary>
		﻿/// no actuation of this axis.<br /><br />> Note: Actuation of <c>NONE</c> can be either a derived <c>REVOLUTE</c> or <c>PRISMATIC</c> motion or static <c>FIXED</c> relationship.<br/><br />

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