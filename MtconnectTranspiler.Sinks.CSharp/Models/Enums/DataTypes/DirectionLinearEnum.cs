using System;
using System.CodeDom.Compiler;using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;

namespace Mtconnect.DataTypes
{
	/// <summary>
	/// View in the MTConnect Model browser <seealso href="https://model.mtconnect.org/#Enumeration___19_0_3_91b028d_1587753011315_305832_4223">model.mtconnect.org</seealso>
	/// </summary>
	/// <remarks>
	/// <list type="bullet">
	/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.4">v1.4</see></item>
	/// </list>
	/// </remarks>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.3.0.0")]
	public enum DirectionLinearEnum
	{
		/// <summary>
		/// linear position is increasing.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.4">v1.4</see></item>
		/// </list>
		/// </remarks>
		POSITIVE,
		/// <summary>
		/// linear position is decreasing.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.4">v1.4</see></item>
		/// </list>
		/// </remarks>
		NEGATIVE,
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
	/// View in the MTConnect Model browser <seealso href="https://model.mtconnect.org/#Enumeration___19_0_3_91b028d_1587753011315_305832_4223">model.mtconnect.org</seealso>
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.3.0.0")]
	public sealed class DirectionLinearEnumMetaClass : IEnum
	{
		/// <inheritdoc />
		public string Name => "DirectionLinearEnum";
		
		/// <inheritdoc />
		public Type DataType => null;
		
		public Type Instance => typeof(DirectionLinearEnum);

		/// <inheritdoc />
		public string NormativeVersion => "1.4";
		
		/// <inheritdoc />
		public string DeprecatedVersion => "";
		
		/// <inheritdoc />
		public string Summary => @"";
		
		/// <inheritdoc />
		public IEnumInstance[] Values => new IEnumInstance[] {
		POSITIVE,
		NEGATIVE,
		NONE,
		};

		private POSITIVEValue _POSITIVE;
		/// <summary>
		/// linear position is increasing.
		/// </summary>
		public POSITIVEValue POSITIVE => _POSITIVE ?? (_POSITIVE = new POSITIVEValue());

		/// <summary>
		/// linear position is increasing.
		/// </summary>
		public sealed class POSITIVEValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "POSITIVE";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.4";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// linear position is increasing.";
		}
		private NEGATIVEValue _NEGATIVE;
		/// <summary>
		/// linear position is decreasing.
		/// </summary>
		public NEGATIVEValue NEGATIVE => _NEGATIVE ?? (_NEGATIVE = new NEGATIVEValue());

		/// <summary>
		/// linear position is decreasing.
		/// </summary>
		public sealed class NEGATIVEValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "NEGATIVE";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.4";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// linear position is decreasing.";
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