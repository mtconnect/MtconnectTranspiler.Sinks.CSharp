#pragma warning disable CS1574 // XML comment has cref attribute that could not be resolved
#pragma warning disable CS1584 // XML comment has syntactically incorrect cref attribute
#pragma warning disable CS0618 // Type or member is obsolete
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
		/// <summary>Constant value for <see cref="ValveStateEnumMetaClass.ReferenceId" /></summary>
		public const string REFERENCE_ID = "_19_0_3_68e0225_1622456100008_63209_110";
		/// <summary>Constant value for <see cref="ValveStateEnumMetaClass.HelpUrl" /></summary>
		public const string HELP_URL = "https://model.mtconnect.org/#Enumeration___19_0_3_68e0225_1622456100008_63209_110";
		/// <summary>Constant value for <see cref="ValveStateEnumMetaClass.Name" /></summary>
		public const string NAME = "ValveStateEnum";
		/// <summary>Constant value for <see cref="ValveStateEnumMetaClass.NormativeVersion" /></summary>
		public const string NORMATIVE_VERSION = "1.8";
		/// <summary>Constant value for <see cref="ValveStateEnumMetaClass.DeprecatedVersion" /></summary>
		public const string DEPRECATED_VERSION = "";
		/// <summary>Constant value for <see cref="ValveStateEnumMetaClass.Summary" /></summary>
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
		public Type Instance => typeof(ValveStateEnum);

		/// <inheritdoc />
		public string NormativeVersion => NORMATIVE_VERSION;
		
		/// <inheritdoc />
		public string DeprecatedVersion => DEPRECATED_VERSION;
		
		/// <inheritdoc />
		public string Summary => SUMMARY;
		
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
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.8">v1.8</see></item>
		/// </list>
		/// </remarks>

		public sealed class OPENValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="OPENValue.Name" /></summary>
			public const string NAME = "OPEN";
			/// <summary>Constant value for <see cref="OPENValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.8";
			/// <summary>Constant value for <see cref="OPENValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="OPENValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;{{block(ValveState)}} where flow is allowed and the aperture is static.

> Note: For a binary value, `OPEN` indicates the valve has the maximum possible aperture.&#10;
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
		private OPENINGValue _OPENING;
		/// <inheritdoc cref="OPENINGValue" path="/summary" />
		public OPENINGValue OPENING => _OPENING ?? (_OPENING = new OPENINGValue());

		/// <summary>﻿valve is transitioning from a <c>CLOSED</c> state to an <c>OPEN</c> state.<br /><br /><br />
		/// Value for ValveStateEnum.<br/>
		/// <br/>See also <seealso cref="ValveStateEnum">ValveStateEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.8">v1.8</see></item>
		/// </list>
		/// </remarks>

		public sealed class OPENINGValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="OPENINGValue.Name" /></summary>
			public const string NAME = "OPENING";
			/// <summary>Constant value for <see cref="OPENINGValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.8";
			/// <summary>Constant value for <see cref="OPENINGValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="OPENINGValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;valve is transitioning from a `CLOSED` state to an `OPEN` state.&#10;
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
		private CLOSEDValue _CLOSED;
		/// <inheritdoc cref="CLOSEDValue" path="/summary" />
		public CLOSEDValue CLOSED => _CLOSED ?? (_CLOSED = new CLOSEDValue());

		/// <summary>﻿<see cref="ValveState">ValveState</see> where flow is not possible, the aperture is static, and the valve is completely shut.<br /><br /><br />
		/// Value for ValveStateEnum.<br/>
		/// <br/>See also <seealso cref="ValveStateEnum">ValveStateEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.8">v1.8</see></item>
		/// </list>
		/// </remarks>

		public sealed class CLOSEDValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="CLOSEDValue.Name" /></summary>
			public const string NAME = "CLOSED";
			/// <summary>Constant value for <see cref="CLOSEDValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.8";
			/// <summary>Constant value for <see cref="CLOSEDValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="CLOSEDValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;{{block(ValveState)}} where flow is not possible, the aperture is static, and the valve is completely shut.&#10;
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
		private CLOSINGValue _CLOSING;
		/// <inheritdoc cref="CLOSINGValue" path="/summary" />
		public CLOSINGValue CLOSING => _CLOSING ?? (_CLOSING = new CLOSINGValue());

		/// <summary>﻿valve is transitioning from an <c>OPEN</c> state to a <c>CLOSED</c> state.<br /><br /><br />
		/// Value for ValveStateEnum.<br/>
		/// <br/>See also <seealso cref="ValveStateEnum">ValveStateEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.8">v1.8</see></item>
		/// </list>
		/// </remarks>

		public sealed class CLOSINGValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="CLOSINGValue.Name" /></summary>
			public const string NAME = "CLOSING";
			/// <summary>Constant value for <see cref="CLOSINGValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.8";
			/// <summary>Constant value for <see cref="CLOSINGValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="CLOSINGValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;valve is transitioning from an `OPEN` state to a `CLOSED` state.&#10;
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