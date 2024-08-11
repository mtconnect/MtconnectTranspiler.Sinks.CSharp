using System;
using System.CodeDom.Compiler;using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;

namespace Mtconnect.DataTypes
{
	/// <summary>
	/// View in the MTConnect Model browser <seealso href="https://model.mtconnect.org/#Enumeration___19_0_3_68e0225_1632488689397_578974_93">model.mtconnect.org</seealso>
	/// </summary>
	/// <remarks>
	/// <list type="bullet">
	/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.1">v1.1</see></item>
	/// </list>
	/// </remarks>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.3.0.0")]
	public enum DoorStateEnum
	{
		/// <summary>
		/// <see cref="Door">Door</see> is open to the point of a positive confirmation.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.1">v1.1</see></item>
		/// </list>
		/// </remarks>
		OPEN,
		/// <summary>
		/// <see cref="Door">Door</see> is closed to the point of a positive confirmation.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.1">v1.1</see></item>
		/// </list>
		/// </remarks>
		CLOSED,
		/// <summary>
		/// <see cref="Door">Door</see> is not closed to the point of a positive confirmation and not open to the point of a positive confirmation.   It is in an intermediate position.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.2">v1.2</see></item>
		/// </list>
		/// </remarks>
		UNLATCHED,
	}

	/// <summary>
	/// View in the MTConnect Model browser <seealso href="https://model.mtconnect.org/#Enumeration___19_0_3_68e0225_1632488689397_578974_93">model.mtconnect.org</seealso>
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.3.0.0")]
	public sealed class DoorStateEnumMetaClass : IEnum
	{
		/// <inheritdoc />
		public string Name => "DoorStateEnum";
		
		/// <inheritdoc />
		public Type DataType => null;
		
		public Type Instance => typeof(DoorStateEnum);

		/// <inheritdoc />
		public string NormativeVersion => "1.1";
		
		/// <inheritdoc />
		public string DeprecatedVersion => "";
		
		/// <inheritdoc />
		public string Summary => @"";
		
		/// <inheritdoc />
		public IEnumInstance[] Values => new IEnumInstance[] {
		OPEN,
		CLOSED,
		UNLATCHED,
		};

		private OPENValue _OPEN;
		/// <summary>
		/// <see cref="Door">Door</see> is open to the point of a positive confirmation.
		/// </summary>
		public OPENValue OPEN => _OPEN ?? (_OPEN = new OPENValue());

		/// <summary>
		/// <see cref="Door">Door</see> is open to the point of a positive confirmation.
		/// </summary>
		public sealed class OPENValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "OPEN";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.1";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// <see cref=""Door"">Door</see> is open to the point of a positive confirmation.";
		}
		private CLOSEDValue _CLOSED;
		/// <summary>
		/// <see cref="Door">Door</see> is closed to the point of a positive confirmation.
		/// </summary>
		public CLOSEDValue CLOSED => _CLOSED ?? (_CLOSED = new CLOSEDValue());

		/// <summary>
		/// <see cref="Door">Door</see> is closed to the point of a positive confirmation.
		/// </summary>
		public sealed class CLOSEDValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "CLOSED";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.1";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// <see cref=""Door"">Door</see> is closed to the point of a positive confirmation.";
		}
		private UNLATCHEDValue _UNLATCHED;
		/// <summary>
		/// <see cref="Door">Door</see> is not closed to the point of a positive confirmation and not open to the point of a positive confirmation.   It is in an intermediate position.
		/// </summary>
		public UNLATCHEDValue UNLATCHED => _UNLATCHED ?? (_UNLATCHED = new UNLATCHEDValue());

		/// <summary>
		/// <see cref="Door">Door</see> is not closed to the point of a positive confirmation and not open to the point of a positive confirmation.   It is in an intermediate position.
		/// </summary>
		public sealed class UNLATCHEDValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "UNLATCHED";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.2";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// <see cref=""Door"">Door</see> is not closed to the point of a positive confirmation and not open to the point of a positive confirmation.   It is in an intermediate position.";
		}
	}
}