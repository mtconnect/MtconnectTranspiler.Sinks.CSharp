using System;
using System.CodeDom.Compiler;using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;

namespace Mtconnect.DataTypes
{
	/// <summary>
	/// View in the MTConnect Model browser <seealso href="https://model.mtconnect.org/#Enumeration___19_0_3_68e0225_1605104600701_22176_1030">model.mtconnect.org</seealso>
	/// </summary>
	/// <remarks>
	/// <list type="bullet">
	/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.7">v1.7</see></item>
	/// </list>
	/// </remarks>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.3.0.0")]
	public enum ConnectionStatusEnum
	{
		/// <summary>
		/// no connection at all.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.7">v1.7</see></item>
		/// </list>
		/// </remarks>
		CLOSED,
		/// <summary>
		/// <i>agent</i> is waiting for a connection request from an <i>adapter</i>.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.7">v1.7</see></item>
		/// </list>
		/// </remarks>
		LISTEN,
		/// <summary>
		/// open connection.  The normal state for the data transfer phase of the connection.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.7">v1.7</see></item>
		/// </list>
		/// </remarks>
		ESTABLISHED,
	}

	/// <summary>
	/// View in the MTConnect Model browser <seealso href="https://model.mtconnect.org/#Enumeration___19_0_3_68e0225_1605104600701_22176_1030">model.mtconnect.org</seealso>
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.3.0.0")]
	public sealed class ConnectionStatusEnumMetaClass : IEnum
	{
		/// <inheritdoc />
		public string Name => "ConnectionStatusEnum";
		
		/// <inheritdoc />
		public Type DataType => null;
		
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
		/// <summary>
		/// no connection at all.
		/// </summary>
		public CLOSEDValue CLOSED => _CLOSED ?? (_CLOSED = new CLOSEDValue());

		/// <summary>
		/// no connection at all.
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
			public string Summary => @"/// no connection at all.";
		}
		private LISTENValue _LISTEN;
		/// <summary>
		/// <i>agent</i> is waiting for a connection request from an <i>adapter</i>.
		/// </summary>
		public LISTENValue LISTEN => _LISTEN ?? (_LISTEN = new LISTENValue());

		/// <summary>
		/// <i>agent</i> is waiting for a connection request from an <i>adapter</i>.
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
			public string Summary => @"/// <i>agent</i> is waiting for a connection request from an <i>adapter</i>.";
		}
		private ESTABLISHEDValue _ESTABLISHED;
		/// <summary>
		/// open connection.  The normal state for the data transfer phase of the connection.
		/// </summary>
		public ESTABLISHEDValue ESTABLISHED => _ESTABLISHED ?? (_ESTABLISHED = new ESTABLISHEDValue());

		/// <summary>
		/// open connection.  The normal state for the data transfer phase of the connection.
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
			public string Summary => @"/// open connection.  The normal state for the data transfer phase of the connection.";
		}
	}
}