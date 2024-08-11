using System;
using System.CodeDom.Compiler;using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;

namespace Mtconnect.DataTypes
{
	/// <summary>
	/// View in the MTConnect Model browser <seealso href="https://model.mtconnect.org/#Enumeration___19_0_3_45f01b9_1580378417663_685842_2877">model.mtconnect.org</seealso>
	/// </summary>
	/// <remarks>
	/// <list type="bullet">
	/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.3">v1.3</see></item>
	/// </list>
	/// </remarks>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.3.0.0")]
	public enum EndOfBarEnum
	{
		/// <summary>
		/// <see cref="EndOfBar">EndOfBar</see> has been reached.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.3">v1.3</see></item>
		/// </list>
		/// </remarks>
		YES,
		/// <summary>
		/// <see cref="EndOfBar">EndOfBar</see> has not been reached.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.3">v1.3</see></item>
		/// </list>
		/// </remarks>
		NO,
	}

	/// <summary>
	/// View in the MTConnect Model browser <seealso href="https://model.mtconnect.org/#Enumeration___19_0_3_45f01b9_1580378417663_685842_2877">model.mtconnect.org</seealso>
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.3.0.0")]
	public sealed class EndOfBarEnumMetaClass : IEnum
	{
		/// <inheritdoc />
		public string Name => "EndOfBarEnum";
		
		/// <inheritdoc />
		public Type DataType => null;
		
		public Type Instance => typeof(EndOfBarEnum);

		/// <inheritdoc />
		public string NormativeVersion => "1.3";
		
		/// <inheritdoc />
		public string DeprecatedVersion => "";
		
		/// <inheritdoc />
		public string Summary => @"";
		
		/// <inheritdoc />
		public IEnumInstance[] Values => new IEnumInstance[] {
		YES,
		NO,
		};

		private YESValue _YES;
		/// <summary>
		/// <see cref="EndOfBar">EndOfBar</see> has been reached.
		/// </summary>
		public YESValue YES => _YES ?? (_YES = new YESValue());

		/// <summary>
		/// <see cref="EndOfBar">EndOfBar</see> has been reached.
		/// </summary>
		public sealed class YESValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "YES";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.3";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// <see cref=""EndOfBar"">EndOfBar</see> has been reached.";
		}
		private NOValue _NO;
		/// <summary>
		/// <see cref="EndOfBar">EndOfBar</see> has not been reached.
		/// </summary>
		public NOValue NO => _NO ?? (_NO = new NOValue());

		/// <summary>
		/// <see cref="EndOfBar">EndOfBar</see> has not been reached.
		/// </summary>
		public sealed class NOValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "NO";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.3";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// <see cref=""EndOfBar"">EndOfBar</see> has not been reached.";
		}
	}
}