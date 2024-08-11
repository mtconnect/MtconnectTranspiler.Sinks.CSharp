using System;
using System.CodeDom.Compiler;using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;

namespace Mtconnect.DataTypes
{
	/// <summary>
	/// View in the MTConnect Model browser <seealso href="https://model.mtconnect.org/#Enumeration___19_0_3_68e0225_1677589978293_52377_922">model.mtconnect.org</seealso>
	/// </summary>
	/// <remarks>
	/// <list type="bullet">
	/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_2.2">v2.2</see></item>
	/// </list>
	/// </remarks>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.3.0.0")]
	public enum SensorStateDetectEnum
	{
		/// <summary>
		/// sensor is active and the threshold has been met.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_2.2">v2.2</see></item>
		/// </list>
		/// </remarks>
		DETECTED,
		/// <summary>
		/// sensor is active and ready but the threshold has not been met.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_2.2">v2.2</see></item>
		/// </list>
		/// </remarks>
		NOT_DETECTED,
		/// <summary>
		/// sensor is active, but the state cannot be determined.  > Note: unknown covers situations where the sensor reading is unstable.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_2.2">v2.2</see></item>
		/// </list>
		/// </remarks>
		UNKNOWN,
	}

	/// <summary>
	/// View in the MTConnect Model browser <seealso href="https://model.mtconnect.org/#Enumeration___19_0_3_68e0225_1677589978293_52377_922">model.mtconnect.org</seealso>
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.3.0.0")]
	public sealed class SensorStateDetectEnumMetaClass : IEnum
	{
		/// <inheritdoc />
		public string Name => "SensorStateDetectEnum";
		
		/// <inheritdoc />
		public Type DataType => null;
		
		public Type Instance => typeof(SensorStateDetectEnum);

		/// <inheritdoc />
		public string NormativeVersion => "2.2";
		
		/// <inheritdoc />
		public string DeprecatedVersion => "";
		
		/// <inheritdoc />
		public string Summary => @"";
		
		/// <inheritdoc />
		public IEnumInstance[] Values => new IEnumInstance[] {
		DETECTED,
		NOT_DETECTED,
		UNKNOWN,
		};

		private DETECTEDValue _DETECTED;
		/// <summary>
		/// sensor is active and the threshold has been met.
		/// </summary>
		public DETECTEDValue DETECTED => _DETECTED ?? (_DETECTED = new DETECTEDValue());

		/// <summary>
		/// sensor is active and the threshold has been met.
		/// </summary>
		public sealed class DETECTEDValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "DETECTED";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "2.2";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// sensor is active and the threshold has been met.";
		}
		private NOT_DETECTEDValue _NOT_DETECTED;
		/// <summary>
		/// sensor is active and ready but the threshold has not been met.
		/// </summary>
		public NOT_DETECTEDValue NOT_DETECTED => _NOT_DETECTED ?? (_NOT_DETECTED = new NOT_DETECTEDValue());

		/// <summary>
		/// sensor is active and ready but the threshold has not been met.
		/// </summary>
		public sealed class NOT_DETECTEDValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "NOT_DETECTED";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "2.2";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// sensor is active and ready but the threshold has not been met.";
		}
		private UNKNOWNValue _UNKNOWN;
		/// <summary>
		/// sensor is active, but the state cannot be determined.  > Note: unknown covers situations where the sensor reading is unstable.
		/// </summary>
		public UNKNOWNValue UNKNOWN => _UNKNOWN ?? (_UNKNOWN = new UNKNOWNValue());

		/// <summary>
		/// sensor is active, but the state cannot be determined.  > Note: unknown covers situations where the sensor reading is unstable.
		/// </summary>
		public sealed class UNKNOWNValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "UNKNOWN";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "2.2";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// sensor is active, but the state cannot be determined.  > Note: unknown covers situations where the sensor reading is unstable.";
		}
	}
}