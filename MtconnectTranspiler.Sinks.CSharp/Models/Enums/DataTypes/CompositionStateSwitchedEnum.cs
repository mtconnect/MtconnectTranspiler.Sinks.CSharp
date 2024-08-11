using System;
using System.CodeDom.Compiler;using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;

namespace Mtconnect.DataTypes
{
	/// <summary>
	/// View in the MTConnect Model browser <seealso href="https://model.mtconnect.org/#Enumeration___19_0_3_68e0225_1612550781451_530503_112">model.mtconnect.org</seealso>
	/// </summary>
	/// <remarks>
	/// <list type="bullet">
	/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.4">v1.4</see></item>
	/// </list>
	/// </remarks>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.3.0.0")]
	public enum CompositionStateSwitchedEnum
	{
		/// <summary>
		/// activation state of the <see cref="Composition">Composition</see> is in an <c>ON</c> condition, it is operating, or it is powered.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.4">v1.4</see></item>
		/// </list>
		/// </remarks>
		ON,
		/// <summary>
		/// activation state of the <see cref="Composition">Composition</see> is in an <c>OFF</c> condition, it is not operating, or it is not powered.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.4">v1.4</see></item>
		/// </list>
		/// </remarks>
		OFF,
	}

	/// <summary>
	/// View in the MTConnect Model browser <seealso href="https://model.mtconnect.org/#Enumeration___19_0_3_68e0225_1612550781451_530503_112">model.mtconnect.org</seealso>
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.3.0.0")]
	public sealed class CompositionStateSwitchedEnumMetaClass : IEnum
	{
		/// <inheritdoc />
		public string Name => "CompositionStateSwitchedEnum";
		
		/// <inheritdoc />
		public Type DataType => null;
		
		public Type Instance => typeof(CompositionStateSwitchedEnum);

		/// <inheritdoc />
		public string NormativeVersion => "1.4";
		
		/// <inheritdoc />
		public string DeprecatedVersion => "";
		
		/// <inheritdoc />
		public string Summary => @"";
		
		/// <inheritdoc />
		public IEnumInstance[] Values => new IEnumInstance[] {
		ON,
		OFF,
		};

		private ONValue _ON;
		/// <summary>
		/// activation state of the <see cref="Composition">Composition</see> is in an <c>ON</c> condition, it is operating, or it is powered.
		/// </summary>
		public ONValue ON => _ON ?? (_ON = new ONValue());

		/// <summary>
		/// activation state of the <see cref="Composition">Composition</see> is in an <c>ON</c> condition, it is operating, or it is powered.
		/// </summary>
		public sealed class ONValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "ON";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.4";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// activation state of the <see cref=""Composition"">Composition</see> is in an <c>ON</c> condition, it is operating, or it is powered.";
		}
		private OFFValue _OFF;
		/// <summary>
		/// activation state of the <see cref="Composition">Composition</see> is in an <c>OFF</c> condition, it is not operating, or it is not powered.
		/// </summary>
		public OFFValue OFF => _OFF ?? (_OFF = new OFFValue());

		/// <summary>
		/// activation state of the <see cref="Composition">Composition</see> is in an <c>OFF</c> condition, it is not operating, or it is not powered.
		/// </summary>
		public sealed class OFFValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "OFF";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.4";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// activation state of the <see cref=""Composition"">Composition</see> is in an <c>OFF</c> condition, it is not operating, or it is not powered.";
		}
	}
}