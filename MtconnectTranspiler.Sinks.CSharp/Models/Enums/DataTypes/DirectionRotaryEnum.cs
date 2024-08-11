using System;
using System.CodeDom.Compiler;using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;

namespace Mtconnect.DataTypes
{
	/// <summary>
	/// View in the MTConnect Model browser <seealso href="https://model.mtconnect.org/#Enumeration___19_0_3_91b028d_1587753036369_787594_4254">model.mtconnect.org</seealso>
	/// </summary>
	/// <remarks>
	/// <list type="bullet">
	/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.4">v1.4</see></item>
	/// </list>
	/// </remarks>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.3.0.0")]
	public enum DirectionRotaryEnum
	{
		/// <summary>
		/// clockwise rotation using the right-hand rule.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.4">v1.4</see></item>
		/// </list>
		/// </remarks>
		CLOCKWISE,
		/// <summary>
		/// counter-clockwise rotation using the right-hand rule.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.4">v1.4</see></item>
		/// </list>
		/// </remarks>
		COUNTER_CLOCKWISE,
		/// <summary>
		/// no direction.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.6">v1.6</see></item>
		/// </list>
		/// </remarks>
		NONE,
	}

	/// <summary>
	/// View in the MTConnect Model browser <seealso href="https://model.mtconnect.org/#Enumeration___19_0_3_91b028d_1587753036369_787594_4254">model.mtconnect.org</seealso>
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.3.0.0")]
	public sealed class DirectionRotaryEnumMetaClass : IEnum
	{
		/// <inheritdoc />
		public string Name => "DirectionRotaryEnum";
		
		/// <inheritdoc />
		public Type DataType => null;
		
		public Type Instance => typeof(DirectionRotaryEnum);

		/// <inheritdoc />
		public string NormativeVersion => "1.4";
		
		/// <inheritdoc />
		public string DeprecatedVersion => "";
		
		/// <inheritdoc />
		public string Summary => @"";
		
		/// <inheritdoc />
		public IEnumInstance[] Values => new IEnumInstance[] {
		CLOCKWISE,
		COUNTER_CLOCKWISE,
		NONE,
		};

		private CLOCKWISEValue _CLOCKWISE;
		/// <summary>
		/// clockwise rotation using the right-hand rule.
		/// </summary>
		public CLOCKWISEValue CLOCKWISE => _CLOCKWISE ?? (_CLOCKWISE = new CLOCKWISEValue());

		/// <summary>
		/// clockwise rotation using the right-hand rule.
		/// </summary>
		public sealed class CLOCKWISEValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "CLOCKWISE";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.4";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// clockwise rotation using the right-hand rule.";
		}
		private COUNTER_CLOCKWISEValue _COUNTER_CLOCKWISE;
		/// <summary>
		/// counter-clockwise rotation using the right-hand rule.
		/// </summary>
		public COUNTER_CLOCKWISEValue COUNTER_CLOCKWISE => _COUNTER_CLOCKWISE ?? (_COUNTER_CLOCKWISE = new COUNTER_CLOCKWISEValue());

		/// <summary>
		/// counter-clockwise rotation using the right-hand rule.
		/// </summary>
		public sealed class COUNTER_CLOCKWISEValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "COUNTER_CLOCKWISE";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.4";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// counter-clockwise rotation using the right-hand rule.";
		}
		private NONEValue _NONE;
		/// <summary>
		/// no direction.
		/// </summary>
		public NONEValue NONE => _NONE ?? (_NONE = new NONEValue());

		/// <summary>
		/// no direction.
		/// </summary>
		public sealed class NONEValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "NONE";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.6";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// no direction.";
		}
	}
}