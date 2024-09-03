#pragma warning disable CS1574 // XML comment has cref attribute that could not be resolved
#pragma warning disable CS1584 // XML comment has syntactically incorrect cref attribute
#pragma warning disable CS0618 // Type or member is obsolete
using System;
using System.CodeDom.Compiler;using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;

namespace Mtconnect.DataTypes
{
	/// <summary>﻿
	/// <br/> Visit <seealso href="https://model.mtconnect.org/#Enumeration___19_0_3_68e0225_1605104600701_22176_1030">model.mtconnect.org</seealso> for more information.
	/// </summary>
	/// <remarks>
	/// <list type="bullet">
	/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.7">v1.7</see></item>
	/// </list>
	/// </remarks>

	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public enum ConnectionStatusEnum
	{
		/// <summary>﻿no connection at all.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.7">v1.7</see></item>
		/// </list>
		/// </remarks>

		CLOSED,
		/// <summary>﻿<i>agent</i> is waiting for a connection request from an <i>adapter</i>.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.7">v1.7</see></item>
		/// </list>
		/// </remarks>

		LISTEN,
		/// <summary>﻿open connection.<br /><br />The normal state for the data transfer phase of the connection.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.7">v1.7</see></item>
		/// </list>
		/// </remarks>

		ESTABLISHED,
	}

	/// <summary>﻿
	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Enumeration___19_0_3_68e0225_1605104600701_22176_1030">model.mtconnect.org</seealso> for more information.
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public sealed class ConnectionStatusEnumMetaClass : IEnum
	{
		/// <summary>Constant value for <see cref="ConnectionStatusEnumMetaClass.ReferenceId" /></summary>
		public const string REFERENCE_ID = "_19_0_3_68e0225_1605104600701_22176_1030";
		/// <summary>Constant value for <see cref="ConnectionStatusEnumMetaClass.HelpUrl" /></summary>
		public const string HELP_URL = "https://model.mtconnect.org/#Enumeration___19_0_3_68e0225_1605104600701_22176_1030";
		/// <summary>Constant value for <see cref="ConnectionStatusEnumMetaClass.Name" /></summary>
		public const string NAME = "ConnectionStatusEnum";
		/// <summary>Constant value for <see cref="ConnectionStatusEnumMetaClass.NormativeVersion" /></summary>
		public const string NORMATIVE_VERSION = "1.7";
		/// <summary>Constant value for <see cref="ConnectionStatusEnumMetaClass.DeprecatedVersion" /></summary>
		public const string DEPRECATED_VERSION = "";
		/// <summary>Constant value for <see cref="ConnectionStatusEnumMetaClass.Summary" /></summary>
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
		public Type Instance => typeof(ConnectionStatusEnum);

		/// <inheritdoc />
		public string NormativeVersion => NORMATIVE_VERSION;
		
		/// <inheritdoc />
		public string DeprecatedVersion => DEPRECATED_VERSION;
		
		/// <inheritdoc />
		public string Summary => SUMMARY;
		
		/// <inheritdoc />
		public IEnumInstance[] Values => new IEnumInstance[] {
		CLOSED,
		LISTEN,
		ESTABLISHED,
		};

		private CLOSEDValue _CLOSED;
		/// <inheritdoc cref="CLOSEDValue" path="/summary" />
		public CLOSEDValue CLOSED => _CLOSED ?? (_CLOSED = new CLOSEDValue());

		/// <summary>﻿no connection at all.<br /><br /><br />
		/// Value for ConnectionStatusEnum.<br/>
		/// <br/>See also <seealso cref="ConnectionStatusEnum">ConnectionStatusEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.7">v1.7</see></item>
		/// </list>
		/// </remarks>

		public sealed class CLOSEDValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="CLOSEDValue.Name" /></summary>
			public const string NAME = "CLOSED";
			/// <summary>Constant value for <see cref="CLOSEDValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.7";
			/// <summary>Constant value for <see cref="CLOSEDValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="CLOSEDValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;no connection at all.&#10;
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
		private LISTENValue _LISTEN;
		/// <inheritdoc cref="LISTENValue" path="/summary" />
		public LISTENValue LISTEN => _LISTEN ?? (_LISTEN = new LISTENValue());

		/// <summary>﻿<i>agent</i> is waiting for a connection request from an <i>adapter</i>.<br /><br /><br />
		/// Value for ConnectionStatusEnum.<br/>
		/// <br/>See also <seealso cref="ConnectionStatusEnum">ConnectionStatusEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.7">v1.7</see></item>
		/// </list>
		/// </remarks>

		public sealed class LISTENValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="LISTENValue.Name" /></summary>
			public const string NAME = "LISTEN";
			/// <summary>Constant value for <see cref="LISTENValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.7";
			/// <summary>Constant value for <see cref="LISTENValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="LISTENValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;{{term(agent)}} is waiting for a connection request from an {{term(adapter)}}.&#10;
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
		private ESTABLISHEDValue _ESTABLISHED;
		/// <inheritdoc cref="ESTABLISHEDValue" path="/summary" />
		public ESTABLISHEDValue ESTABLISHED => _ESTABLISHED ?? (_ESTABLISHED = new ESTABLISHEDValue());

		/// <summary>﻿open connection.<br /><br />The normal state for the data transfer phase of the connection.<br /><br /><br />
		/// Value for ConnectionStatusEnum.<br/>
		/// <br/>See also <seealso cref="ConnectionStatusEnum">ConnectionStatusEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.7">v1.7</see></item>
		/// </list>
		/// </remarks>

		public sealed class ESTABLISHEDValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="ESTABLISHEDValue.Name" /></summary>
			public const string NAME = "ESTABLISHED";
			/// <summary>Constant value for <see cref="ESTABLISHEDValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.7";
			/// <summary>Constant value for <see cref="ESTABLISHEDValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="ESTABLISHEDValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;open connection.

The normal state for the data transfer phase of the connection.&#10;
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