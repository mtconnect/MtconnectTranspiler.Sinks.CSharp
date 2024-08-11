using System;
using System.CodeDom.Compiler;using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;

namespace Mtconnect.DataTypes
{
	/// <summary>
	/// View in the MTConnect Model browser <seealso href="https://model.mtconnect.org/#Enumeration___19_0_3_68e0225_1612550799197_550203_137">model.mtconnect.org</seealso>
	/// </summary>
	/// <remarks>
	/// <list type="bullet">
	/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.4">v1.4</see></item>
	/// </list>
	/// </remarks>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.3.0.0")]
	public enum CompositionStateVerticalEnum
	{
		/// <summary>
		/// position of the <see cref="Composition">Composition</see> element is oriented in an upward direction to the point of a positive confirmation.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.4">v1.4</see></item>
		/// </list>
		/// </remarks>
		UP,
		/// <summary>
		/// position of the <see cref="Composition">Composition</see> element is oriented in a downward direction to the point of a positive confirmation.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.4">v1.4</see></item>
		/// </list>
		/// </remarks>
		DOWN,
		/// <summary>
		/// position of the <see cref="Composition">Composition</see> element is not oriented in an upward direction to the point of a positive confirmation and is not oriented in a downward direction to the point of a positive confirmation.   It is in an intermediate position.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.4">v1.4</see></item>
		/// </list>
		/// </remarks>
		TRANSITIONING,
	}

	/// <summary>
	/// View in the MTConnect Model browser <seealso href="https://model.mtconnect.org/#Enumeration___19_0_3_68e0225_1612550799197_550203_137">model.mtconnect.org</seealso>
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.3.0.0")]
	public sealed class CompositionStateVerticalEnumMetaClass : IEnum
	{
		/// <inheritdoc />
		public string Name => "CompositionStateVerticalEnum";
		
		/// <inheritdoc />
		public Type DataType => null;
		
		public Type Instance => typeof(CompositionStateVerticalEnum);

		/// <inheritdoc />
		public string NormativeVersion => "1.4";
		
		/// <inheritdoc />
		public string DeprecatedVersion => "";
		
		/// <inheritdoc />
		public string Summary => @"";
		
		/// <inheritdoc />
		public IEnumInstance[] Values => new IEnumInstance[] {
		UP,
		DOWN,
		TRANSITIONING,
		};

		private UPValue _UP;
		/// <summary>
		/// position of the <see cref="Composition">Composition</see> element is oriented in an upward direction to the point of a positive confirmation.
		/// </summary>
		public UPValue UP => _UP ?? (_UP = new UPValue());

		/// <summary>
		/// position of the <see cref="Composition">Composition</see> element is oriented in an upward direction to the point of a positive confirmation.
		/// </summary>
		public sealed class UPValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "UP";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.4";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// position of the <see cref=""Composition"">Composition</see> element is oriented in an upward direction to the point of a positive confirmation.";
		}
		private DOWNValue _DOWN;
		/// <summary>
		/// position of the <see cref="Composition">Composition</see> element is oriented in a downward direction to the point of a positive confirmation.
		/// </summary>
		public DOWNValue DOWN => _DOWN ?? (_DOWN = new DOWNValue());

		/// <summary>
		/// position of the <see cref="Composition">Composition</see> element is oriented in a downward direction to the point of a positive confirmation.
		/// </summary>
		public sealed class DOWNValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "DOWN";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.4";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// position of the <see cref=""Composition"">Composition</see> element is oriented in a downward direction to the point of a positive confirmation.";
		}
		private TRANSITIONINGValue _TRANSITIONING;
		/// <summary>
		/// position of the <see cref="Composition">Composition</see> element is not oriented in an upward direction to the point of a positive confirmation and is not oriented in a downward direction to the point of a positive confirmation.   It is in an intermediate position.
		/// </summary>
		public TRANSITIONINGValue TRANSITIONING => _TRANSITIONING ?? (_TRANSITIONING = new TRANSITIONINGValue());

		/// <summary>
		/// position of the <see cref="Composition">Composition</see> element is not oriented in an upward direction to the point of a positive confirmation and is not oriented in a downward direction to the point of a positive confirmation.   It is in an intermediate position.
		/// </summary>
		public sealed class TRANSITIONINGValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "TRANSITIONING";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.4";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// position of the <see cref=""Composition"">Composition</see> element is not oriented in an upward direction to the point of a positive confirmation and is not oriented in a downward direction to the point of a positive confirmation.   It is in an intermediate position.";
		}
	}
}