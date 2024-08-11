using System;
using System.CodeDom.Compiler;using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;

namespace Mtconnect.DataTypes
{
	/// <summary>
	/// View in the MTConnect Model browser <seealso href="https://model.mtconnect.org/#Enumeration___19_0_3_68e0225_1612550811680_794757_187">model.mtconnect.org</seealso>
	/// </summary>
	/// <remarks>
	/// <list type="bullet">
	/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.4">v1.4</see></item>
	/// </list>
	/// </remarks>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.3.0.0")]
	public enum CompositionStateMotionEnum
	{
		/// <summary>
		/// position of the <see cref="Composition">Composition</see> is open to the point of a positive confirmation.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.4">v1.4</see></item>
		/// </list>
		/// </remarks>
		OPEN,
		/// <summary>
		/// position of the <see cref="Composition">Composition</see> is not open to the point of a positive confirmation and is not closed to the point of a positive confirmation.   It is in an intermediate position.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.4">v1.4</see></item>
		/// </list>
		/// </remarks>
		UNLATCHED,
		/// <summary>
		/// position of the <see cref="Composition">Composition</see> is closed to the point of a positive confirmation.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.4">v1.4</see></item>
		/// </list>
		/// </remarks>
		CLOSED,
	}

	/// <summary>
	/// View in the MTConnect Model browser <seealso href="https://model.mtconnect.org/#Enumeration___19_0_3_68e0225_1612550811680_794757_187">model.mtconnect.org</seealso>
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.3.0.0")]
	public sealed class CompositionStateMotionEnumMetaClass : IEnum
	{
		/// <inheritdoc />
		public string Name => "CompositionStateMotionEnum";
		
		/// <inheritdoc />
		public Type DataType => null;
		
		public Type Instance => typeof(CompositionStateMotionEnum);

		/// <inheritdoc />
		public string NormativeVersion => "1.4";
		
		/// <inheritdoc />
		public string DeprecatedVersion => "";
		
		/// <inheritdoc />
		public string Summary => @"";
		
		/// <inheritdoc />
		public IEnumInstance[] Values => new IEnumInstance[] {
		OPEN,
		UNLATCHED,
		CLOSED,
		};

		private OPENValue _OPEN;
		/// <summary>
		/// position of the <see cref="Composition">Composition</see> is open to the point of a positive confirmation.
		/// </summary>
		public OPENValue OPEN => _OPEN ?? (_OPEN = new OPENValue());

		/// <summary>
		/// position of the <see cref="Composition">Composition</see> is open to the point of a positive confirmation.
		/// </summary>
		public sealed class OPENValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "OPEN";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.4";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// position of the <see cref=""Composition"">Composition</see> is open to the point of a positive confirmation.";
		}
		private UNLATCHEDValue _UNLATCHED;
		/// <summary>
		/// position of the <see cref="Composition">Composition</see> is not open to the point of a positive confirmation and is not closed to the point of a positive confirmation.   It is in an intermediate position.
		/// </summary>
		public UNLATCHEDValue UNLATCHED => _UNLATCHED ?? (_UNLATCHED = new UNLATCHEDValue());

		/// <summary>
		/// position of the <see cref="Composition">Composition</see> is not open to the point of a positive confirmation and is not closed to the point of a positive confirmation.   It is in an intermediate position.
		/// </summary>
		public sealed class UNLATCHEDValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "UNLATCHED";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.4";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// position of the <see cref=""Composition"">Composition</see> is not open to the point of a positive confirmation and is not closed to the point of a positive confirmation.   It is in an intermediate position.";
		}
		private CLOSEDValue _CLOSED;
		/// <summary>
		/// position of the <see cref="Composition">Composition</see> is closed to the point of a positive confirmation.
		/// </summary>
		public CLOSEDValue CLOSED => _CLOSED ?? (_CLOSED = new CLOSEDValue());

		/// <summary>
		/// position of the <see cref="Composition">Composition</see> is closed to the point of a positive confirmation.
		/// </summary>
		public sealed class CLOSEDValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "CLOSED";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.4";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// position of the <see cref=""Composition"">Composition</see> is closed to the point of a positive confirmation.";
		}
	}
}