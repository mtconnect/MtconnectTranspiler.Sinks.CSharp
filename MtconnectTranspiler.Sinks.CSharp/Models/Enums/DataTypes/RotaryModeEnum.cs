using System;
using System.CodeDom.Compiler;using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;

namespace Mtconnect.DataTypes
{
	/// <summary>
	/// View in the MTConnect Model browser <seealso href="https://model.mtconnect.org/#Enumeration___19_0_3_45f01b9_1580378417668_463137_2883">model.mtconnect.org</seealso>
	/// </summary>
	/// <remarks>
	/// <list type="bullet">
	/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.1">v1.1</see></item>
	/// </list>
	/// </remarks>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.3.0.0")]
	public enum RotaryModeEnum
	{
		/// <summary>
		/// axis is functioning as a spindle.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.1">v1.1</see></item>
		/// </list>
		/// </remarks>
		SPINDLE,
		/// <summary>
		/// axis is configured to index.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.1">v1.1</see></item>
		/// </list>
		/// </remarks>
		INDEX,
		/// <summary>
		/// position of the axis is being interpolated.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.1">v1.1</see></item>
		/// </list>
		/// </remarks>
		CONTOUR,
	}

	/// <summary>
	/// View in the MTConnect Model browser <seealso href="https://model.mtconnect.org/#Enumeration___19_0_3_45f01b9_1580378417668_463137_2883">model.mtconnect.org</seealso>
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.3.0.0")]
	public sealed class RotaryModeEnumMetaClass : IEnum
	{
		/// <inheritdoc />
		public string Name => "RotaryModeEnum";
		
		/// <inheritdoc />
		public Type DataType => null;
		
		public Type Instance => typeof(RotaryModeEnum);

		/// <inheritdoc />
		public string NormativeVersion => "1.1";
		
		/// <inheritdoc />
		public string DeprecatedVersion => "";
		
		/// <inheritdoc />
		public string Summary => @"";
		
		/// <inheritdoc />
		public IEnumInstance[] Values => new IEnumInstance[] {
		SPINDLE,
		INDEX,
		CONTOUR,
		};

		private SPINDLEValue _SPINDLE;
		/// <summary>
		/// axis is functioning as a spindle.
		/// </summary>
		public SPINDLEValue SPINDLE => _SPINDLE ?? (_SPINDLE = new SPINDLEValue());

		/// <summary>
		/// axis is functioning as a spindle.
		/// </summary>
		public sealed class SPINDLEValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "SPINDLE";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.1";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// axis is functioning as a spindle.";
		}
		private INDEXValue _INDEX;
		/// <summary>
		/// axis is configured to index.
		/// </summary>
		public INDEXValue INDEX => _INDEX ?? (_INDEX = new INDEXValue());

		/// <summary>
		/// axis is configured to index.
		/// </summary>
		public sealed class INDEXValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "INDEX";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.1";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// axis is configured to index.";
		}
		private CONTOURValue _CONTOUR;
		/// <summary>
		/// position of the axis is being interpolated.
		/// </summary>
		public CONTOURValue CONTOUR => _CONTOUR ?? (_CONTOUR = new CONTOURValue());

		/// <summary>
		/// position of the axis is being interpolated.
		/// </summary>
		public sealed class CONTOURValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "CONTOUR";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.1";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// position of the axis is being interpolated.";
		}
	}
}