using System;
using System.CodeDom.Compiler;using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;

namespace Mtconnect.DataTypes
{
	/// <summary>
	/// View in the MTConnect Model browser <seealso href="https://model.mtconnect.org/#Enumeration__EAID_CFE5DAF7_7F0E_40ce_B920_5151D846B636">model.mtconnect.org</seealso>
	/// </summary>
	/// <remarks>
	/// <list type="bullet">
	/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.2">v1.2</see></item>
	/// </list>
	/// </remarks>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.3.0.0")]
	public enum CountDirectionTypeEnum
	{
		/// <summary>
		/// tool life counts up from zero to the maximum. 
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.2">v1.2</see></item>
		/// </list>
		/// </remarks>
		UP,
		/// <summary>
		/// tool life counts down from the maximum to zero.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.2">v1.2</see></item>
		/// </list>
		/// </remarks>
		DOWN,
	}

	/// <summary>
	/// View in the MTConnect Model browser <seealso href="https://model.mtconnect.org/#Enumeration__EAID_CFE5DAF7_7F0E_40ce_B920_5151D846B636">model.mtconnect.org</seealso>
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.3.0.0")]
	public sealed class CountDirectionTypeEnumMetaClass : IEnum
	{
		/// <inheritdoc />
		public string Name => "CountDirectionTypeEnum";
		
		/// <inheritdoc />
		public Type DataType => null;
		
		public Type Instance => typeof(CountDirectionTypeEnum);

		/// <inheritdoc />
		public string NormativeVersion => "1.2";
		
		/// <inheritdoc />
		public string DeprecatedVersion => "";
		
		/// <inheritdoc />
		public string Summary => @"";
		
		/// <inheritdoc />
		public IEnumInstance[] Values => new IEnumInstance[] {
		UP,
		DOWN,
		};

		private UPValue _UP;
		/// <summary>
		/// tool life counts up from zero to the maximum. 
		/// </summary>
		public UPValue UP => _UP ?? (_UP = new UPValue());

		/// <summary>
		/// tool life counts up from zero to the maximum. 
		/// </summary>
		public sealed class UPValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "UP";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.2";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// tool life counts up from zero to the maximum. ";
		}
		private DOWNValue _DOWN;
		/// <summary>
		/// tool life counts down from the maximum to zero.
		/// </summary>
		public DOWNValue DOWN => _DOWN ?? (_DOWN = new DOWNValue());

		/// <summary>
		/// tool life counts down from the maximum to zero.
		/// </summary>
		public sealed class DOWNValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "DOWN";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.2";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// tool life counts down from the maximum to zero.";
		}
	}
}