#pragma warning disable CS1574 // XML comment has cref attribute that could not be resolved
#pragma warning disable CS1584 // XML comment has syntactically incorrect cref attribute
using System;
using System.CodeDom.Compiler;using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;

namespace Mtconnect.DataTypes
{
	/// <summary>﻿
	/// <br/> Visit <seealso href="https://model.mtconnect.org/#Enumeration___19_0_3_68e0225_1622456100008_63209_110">model.mtconnect.org</seealso> for more information.
	/// </summary>
	/// <remarks>
	/// <list type="bullet">
	/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.8">v1.8</see></item>
	/// </list>
	/// </remarks>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public enum ValveStateEnum
	{
		/// <summary>﻿<see cref="ValveState">ValveState</see> where flow is allowed and the aperture is static.<br /><br />&gt; Note: For a binary value, <c>OPEN</c> indicates the valve has the maximum possible aperture.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.8">v1.8</see></item>
		/// </list>
		/// </remarks>
		OPEN,
		/// <summary>﻿valve is transitioning from a <c>CLOSED</c> state to an <c>OPEN</c> state.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.8">v1.8</see></item>
		/// </list>
		/// </remarks>
		OPENING,
		/// <summary>﻿<see cref="ValveState">ValveState</see> where flow is not possible, the aperture is static, and the valve is completely shut.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.8">v1.8</see></item>
		/// </list>
		/// </remarks>
		CLOSED,
		/// <summary>﻿valve is transitioning from an <c>OPEN</c> state to a <c>CLOSED</c> state.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.8">v1.8</see></item>
		/// </list>
		/// </remarks>
		CLOSING,
	}

	/// <summary>﻿
	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Enumeration___19_0_3_68e0225_1622456100008_63209_110">model.mtconnect.org</seealso> for more information.
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public sealed class ValveStateEnumMetaClass : IEnum
	{
		/// <inheritdoc />
		public string Name => "ValveStateEnum";
		
		/// <inheritdoc />
		public Type DataType => null;
		
		/// <inheritdoc />
		public Type Instance => typeof(ValveStateEnum);

		/// <inheritdoc />
		public string NormativeVersion => "1.8";
		
		/// <inheritdoc />
		public string DeprecatedVersion => "";
		
		/// <inheritdoc />
		public string Summary => @"";
		
		/// <inheritdoc />
		public IEnumInstance[] Values => new IEnumInstance[] {
		OPEN,
		OPENING,
		CLOSED,
		CLOSING,
		};

		private OPENValue _OPEN;
		/// <inheritdoc cref="OPENValue" path="/summary" />
		public OPENValue OPEN => _OPEN ?? (_OPEN = new OPENValue());

		/// <summary>﻿<see cref="ValveState">ValveState</see> where flow is allowed and the aperture is static.<br /><br />&gt; Note: For a binary value, <c>OPEN</c> indicates the valve has the maximum possible aperture.<br /><br /><br />
		/// Value for ValveStateEnum.<br/>
		/// <br/>See also <seealso cref="ValveStateEnum">ValveStateEnum</seealso>
		/// </summary>
		public sealed class OPENValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "OPEN";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.8";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"&#10;&#10;&#10;{{block(ValveState)}} where flow is allowed and the aperture is static.

> Note: For a binary value, `OPEN` indicates the valve has the maximum possible aperture.&#10;
";
		}
		private OPENINGValue _OPENING;
		/// <inheritdoc cref="OPENINGValue" path="/summary" />
		public OPENINGValue OPENING => _OPENING ?? (_OPENING = new OPENINGValue());

		/// <summary>﻿valve is transitioning from a <c>CLOSED</c> state to an <c>OPEN</c> state.<br /><br /><br />
		/// Value for ValveStateEnum.<br/>
		/// <br/>See also <seealso cref="ValveStateEnum">ValveStateEnum</seealso>
		/// </summary>
		public sealed class OPENINGValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "OPENING";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.8";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"&#10;&#10;&#10;valve is transitioning from a `CLOSED` state to an `OPEN` state.&#10;
";
		}
		private CLOSEDValue _CLOSED;
		/// <inheritdoc cref="CLOSEDValue" path="/summary" />
		public CLOSEDValue CLOSED => _CLOSED ?? (_CLOSED = new CLOSEDValue());

		/// <summary>﻿<see cref="ValveState">ValveState</see> where flow is not possible, the aperture is static, and the valve is completely shut.<br /><br /><br />
		/// Value for ValveStateEnum.<br/>
		/// <br/>See also <seealso cref="ValveStateEnum">ValveStateEnum</seealso>
		/// </summary>
		public sealed class CLOSEDValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "CLOSED";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.8";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"&#10;&#10;&#10;{{block(ValveState)}} where flow is not possible, the aperture is static, and the valve is completely shut.&#10;
";
		}
		private CLOSINGValue _CLOSING;
		/// <inheritdoc cref="CLOSINGValue" path="/summary" />
		public CLOSINGValue CLOSING => _CLOSING ?? (_CLOSING = new CLOSINGValue());

		/// <summary>﻿valve is transitioning from an <c>OPEN</c> state to a <c>CLOSED</c> state.<br /><br /><br />
		/// Value for ValveStateEnum.<br/>
		/// <br/>See also <seealso cref="ValveStateEnum">ValveStateEnum</seealso>
		/// </summary>
		public sealed class CLOSINGValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "CLOSING";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.8";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"&#10;&#10;&#10;valve is transitioning from an `OPEN` state to a `CLOSED` state.&#10;
";
		}
	}
}