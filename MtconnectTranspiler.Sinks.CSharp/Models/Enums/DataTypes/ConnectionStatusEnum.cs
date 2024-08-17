#pragma warning disable CS1574 // XML comment has cref attribute that could not be resolved
#pragma warning disable CS1584 // XML comment has syntactically incorrect cref attribute
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
		/// <inheritdoc />
		public string Name => "ConnectionStatusEnum";
		
		/// <inheritdoc />
		public Type DataType => null;
		
		/// <inheritdoc />
		public Type Instance => typeof(ConnectionStatusEnum);

		/// <inheritdoc />
		public string NormativeVersion => "1.7";
		
		/// <inheritdoc />
		public string DeprecatedVersion => "";
		
		/// <inheritdoc />
		public string Summary => @"";
		
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
		public sealed class CLOSEDValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "CLOSED";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.7";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"&#10;&#10;&#10;no connection at all.&#10;
";
		}
		private LISTENValue _LISTEN;
		/// <inheritdoc cref="LISTENValue" path="/summary" />
		public LISTENValue LISTEN => _LISTEN ?? (_LISTEN = new LISTENValue());

		/// <summary>﻿<i>agent</i> is waiting for a connection request from an <i>adapter</i>.<br /><br /><br />
		/// Value for ConnectionStatusEnum.<br/>
		/// <br/>See also <seealso cref="ConnectionStatusEnum">ConnectionStatusEnum</seealso>
		/// </summary>
		public sealed class LISTENValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "LISTEN";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.7";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"&#10;&#10;&#10;{{term(agent)}} is waiting for a connection request from an {{term(adapter)}}.&#10;
";
		}
		private ESTABLISHEDValue _ESTABLISHED;
		/// <inheritdoc cref="ESTABLISHEDValue" path="/summary" />
		public ESTABLISHEDValue ESTABLISHED => _ESTABLISHED ?? (_ESTABLISHED = new ESTABLISHEDValue());

		/// <summary>﻿open connection.<br /><br />The normal state for the data transfer phase of the connection.<br /><br /><br />
		/// Value for ConnectionStatusEnum.<br/>
		/// <br/>See also <seealso cref="ConnectionStatusEnum">ConnectionStatusEnum</seealso>
		/// </summary>
		public sealed class ESTABLISHEDValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "ESTABLISHED";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.7";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"&#10;&#10;&#10;open connection.

The normal state for the data transfer phase of the connection.&#10;
";
		}
	}
}