#pragma warning disable CS1574 // XML comment has cref attribute that could not be resolved
#pragma warning disable CS1584 // XML comment has syntactically incorrect cref attribute
#pragma warning disable CS0618 // Type or member is obsolete
using System;
using System.CodeDom.Compiler;using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;

namespace Mtconnect.DataTypes
{
	/// <summary>﻿
	/// <br/> Visit <seealso href="https://model.mtconnect.org/#Enumeration___2024x_68e0225_1744716359774_334841_23505">model.mtconnect.org</seealso> for more information.
	/// </summary>
	/// <remarks>
	/// <list type="bullet">
	/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_2.6">v2.6</see></item>
	/// </list>
	/// </remarks>

	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.6.0.0")]
	public enum QueryParameterEnum
	{
		/// <summary>﻿See <c>device</c> parameter of <see cref="Agent::Operation">Agent::Operation</see> types.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_2.6">v2.6</see></item>
		/// </list>
		/// </remarks>

		DEVICE,
		/// <summary>﻿See <c>deviceType</c> parameter of <see cref="Agent::Operation">Agent::Operation</see> types.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_2.6">v2.6</see></item>
		/// </list>
		/// </remarks>

		DEVICETYPE,
		/// <summary>﻿See <c>path</c> parameter of <see cref="Agent::Operation">Agent::Operation</see> types.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_2.6">v2.6</see></item>
		/// </list>
		/// </remarks>

		PATH,
		/// <summary>﻿See <c>from</c> parameter of <see cref="Agent::Operation">Agent::Operation</see> types.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_2.6">v2.6</see></item>
		/// </list>
		/// </remarks>

		FROM,
		/// <summary>﻿See <c>count</c> parameter of <see cref="Agent::Operation">Agent::Operation</see> types.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_2.6">v2.6</see></item>
		/// </list>
		/// </remarks>

		COUNT,
		/// <summary>﻿See <c>interval</c> parameter of <see cref="Agent::Operation">Agent::Operation</see> types.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_2.6">v2.6</see></item>
		/// </list>
		/// </remarks>

		INTERVAL,
		/// <summary>﻿See <c>heartbeat</c> parameter of <see cref="Agent::Operation">Agent::Operation</see> types.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_2.6">v2.6</see></item>
		/// </list>
		/// </remarks>

		HEARTBEAT,
	}

	/// <summary>﻿
	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Enumeration___2024x_68e0225_1744716359774_334841_23505">model.mtconnect.org</seealso> for more information.
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.6.0.0")]
	public sealed class QueryParameterEnumMetaClass : IEnum
	{
		/// <summary>Constant value for <see cref="QueryParameterEnumMetaClass.ReferenceId" /></summary>
		public const string REFERENCE_ID = "_2024x_68e0225_1744716359774_334841_23505";
		/// <summary>Constant value for <see cref="QueryParameterEnumMetaClass.HelpUrl" /></summary>
		public const string HELP_URL = "https://model.mtconnect.org/#Enumeration___2024x_68e0225_1744716359774_334841_23505";
		/// <summary>Constant value for <see cref="QueryParameterEnumMetaClass.Name" /></summary>
		public const string NAME = "QueryParameterEnum";
		/// <summary>Constant value for <see cref="QueryParameterEnumMetaClass.NormativeVersion" /></summary>
		public const string NORMATIVE_VERSION = "2.6";
		/// <summary>Constant value for <see cref="QueryParameterEnumMetaClass.DeprecatedVersion" /></summary>
		public const string DEPRECATED_VERSION = "";
		/// <summary>Constant value for <see cref="QueryParameterEnumMetaClass.Summary" /></summary>
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
		public Type Instance => typeof(QueryParameterEnum);

		/// <inheritdoc />
		public string NormativeVersion => NORMATIVE_VERSION;
		
		/// <inheritdoc />
		public string DeprecatedVersion => DEPRECATED_VERSION;
		
		/// <inheritdoc />
		public string Summary => SUMMARY;
		
		/// <inheritdoc />
		public IEnumInstance[] Values => new IEnumInstance[] {
		device,
		deviceType,
		path,
		from,
		count,
		interval,
		heartbeat,
		};

		private deviceValue _device;
		/// <inheritdoc cref="deviceValue" path="/summary" />
		public deviceValue device => _device ?? (_device = new deviceValue());

		/// <summary>﻿See <c>device</c> parameter of <see cref="Agent::Operation">Agent::Operation</see> types.<br /><br /><br />
		/// Value for QueryParameterEnum.<br/>
		/// <br/>See also <seealso cref="QueryParameterEnum">QueryParameterEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_2.6">v2.6</see></item>
		/// </list>
		/// </remarks>

		public sealed class deviceValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="deviceValue.Name" /></summary>
			public const string NAME = "device";
			/// <summary>Constant value for <see cref="deviceValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "2.6";
			/// <summary>Constant value for <see cref="deviceValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="deviceValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;See `device` parameter of {{block(Agent::Operation)}} types.&#10;
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
		private deviceTypeValue _deviceType;
		/// <inheritdoc cref="deviceTypeValue" path="/summary" />
		public deviceTypeValue deviceType => _deviceType ?? (_deviceType = new deviceTypeValue());

		/// <summary>﻿See <c>deviceType</c> parameter of <see cref="Agent::Operation">Agent::Operation</see> types.<br /><br /><br />
		/// Value for QueryParameterEnum.<br/>
		/// <br/>See also <seealso cref="QueryParameterEnum">QueryParameterEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_2.6">v2.6</see></item>
		/// </list>
		/// </remarks>

		public sealed class deviceTypeValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="deviceTypeValue.Name" /></summary>
			public const string NAME = "deviceType";
			/// <summary>Constant value for <see cref="deviceTypeValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "2.6";
			/// <summary>Constant value for <see cref="deviceTypeValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="deviceTypeValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;See `deviceType` parameter of {{block(Agent::Operation)}} types.&#10;
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
		private pathValue _path;
		/// <inheritdoc cref="pathValue" path="/summary" />
		public pathValue path => _path ?? (_path = new pathValue());

		/// <summary>﻿See <c>path</c> parameter of <see cref="Agent::Operation">Agent::Operation</see> types.<br /><br /><br />
		/// Value for QueryParameterEnum.<br/>
		/// <br/>See also <seealso cref="QueryParameterEnum">QueryParameterEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_2.6">v2.6</see></item>
		/// </list>
		/// </remarks>

		public sealed class pathValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="pathValue.Name" /></summary>
			public const string NAME = "path";
			/// <summary>Constant value for <see cref="pathValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "2.6";
			/// <summary>Constant value for <see cref="pathValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="pathValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;See `path` parameter of {{block(Agent::Operation)}} types.&#10;
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
		private fromValue _from;
		/// <inheritdoc cref="fromValue" path="/summary" />
		public fromValue from => _from ?? (_from = new fromValue());

		/// <summary>﻿See <c>from</c> parameter of <see cref="Agent::Operation">Agent::Operation</see> types.<br /><br /><br />
		/// Value for QueryParameterEnum.<br/>
		/// <br/>See also <seealso cref="QueryParameterEnum">QueryParameterEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_2.6">v2.6</see></item>
		/// </list>
		/// </remarks>

		public sealed class fromValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="fromValue.Name" /></summary>
			public const string NAME = "from";
			/// <summary>Constant value for <see cref="fromValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "2.6";
			/// <summary>Constant value for <see cref="fromValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="fromValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;See `from` parameter of {{block(Agent::Operation)}} types.&#10;
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
		private countValue _count;
		/// <inheritdoc cref="countValue" path="/summary" />
		public countValue count => _count ?? (_count = new countValue());

		/// <summary>﻿See <c>count</c> parameter of <see cref="Agent::Operation">Agent::Operation</see> types.<br /><br /><br />
		/// Value for QueryParameterEnum.<br/>
		/// <br/>See also <seealso cref="QueryParameterEnum">QueryParameterEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_2.6">v2.6</see></item>
		/// </list>
		/// </remarks>

		public sealed class countValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="countValue.Name" /></summary>
			public const string NAME = "count";
			/// <summary>Constant value for <see cref="countValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "2.6";
			/// <summary>Constant value for <see cref="countValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="countValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;See `count` parameter of {{block(Agent::Operation)}} types.&#10;
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
		private intervalValue _interval;
		/// <inheritdoc cref="intervalValue" path="/summary" />
		public intervalValue interval => _interval ?? (_interval = new intervalValue());

		/// <summary>﻿See <c>interval</c> parameter of <see cref="Agent::Operation">Agent::Operation</see> types.<br /><br /><br />
		/// Value for QueryParameterEnum.<br/>
		/// <br/>See also <seealso cref="QueryParameterEnum">QueryParameterEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_2.6">v2.6</see></item>
		/// </list>
		/// </remarks>

		public sealed class intervalValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="intervalValue.Name" /></summary>
			public const string NAME = "interval";
			/// <summary>Constant value for <see cref="intervalValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "2.6";
			/// <summary>Constant value for <see cref="intervalValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="intervalValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;See `interval` parameter of {{block(Agent::Operation)}} types.&#10;
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
		private heartbeatValue _heartbeat;
		/// <inheritdoc cref="heartbeatValue" path="/summary" />
		public heartbeatValue heartbeat => _heartbeat ?? (_heartbeat = new heartbeatValue());

		/// <summary>﻿See <c>heartbeat</c> parameter of <see cref="Agent::Operation">Agent::Operation</see> types.<br /><br /><br />
		/// Value for QueryParameterEnum.<br/>
		/// <br/>See also <seealso cref="QueryParameterEnum">QueryParameterEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_2.6">v2.6</see></item>
		/// </list>
		/// </remarks>

		public sealed class heartbeatValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="heartbeatValue.Name" /></summary>
			public const string NAME = "heartbeat";
			/// <summary>Constant value for <see cref="heartbeatValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "2.6";
			/// <summary>Constant value for <see cref="heartbeatValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="heartbeatValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;See `heartbeat` parameter of {{block(Agent::Operation)}} types.&#10;
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