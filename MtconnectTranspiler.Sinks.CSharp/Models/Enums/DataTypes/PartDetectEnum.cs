using System;
using System.CodeDom.Compiler;using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;

namespace Mtconnect.DataTypes
{
	/// <summary>
	/// View in the MTConnect Model browser <seealso href="https://model.mtconnect.org/#Enumeration___19_0_3_45f01b9_1581206093299_877100_76">model.mtconnect.org</seealso>
	/// </summary>
	/// <remarks>
	/// <list type="bullet">
	/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.5">v1.5</see></item>
	/// </list>
	/// </remarks>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.3.0.0")]
	public enum PartDetectEnum
	{
		/// <summary>
		/// part or work piece is detected or is present.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.5">v1.5</see></item>
		/// </list>
		/// </remarks>
		PRESENT,
		/// <summary>
		/// part or work piece is not detected or is not present.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.5">v1.5</see></item>
		/// </list>
		/// </remarks>
		NOT_PRESENT,
	}

	/// <summary>
	/// View in the MTConnect Model browser <seealso href="https://model.mtconnect.org/#Enumeration___19_0_3_45f01b9_1581206093299_877100_76">model.mtconnect.org</seealso>
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.3.0.0")]
	public sealed class PartDetectEnumMetaClass : IEnum
	{
		/// <inheritdoc />
		public string Name => "PartDetectEnum";
		
		/// <inheritdoc />
		public Type DataType => null;
		
		public Type Instance => typeof(PartDetectEnum);

		/// <inheritdoc />
		public string NormativeVersion => "1.5";
		
		/// <inheritdoc />
		public string DeprecatedVersion => "";
		
		/// <inheritdoc />
		public string Summary => @"";
		
		/// <inheritdoc />
		public IEnumInstance[] Values => new IEnumInstance[] {
		PRESENT,
		NOT_PRESENT,
		};

		private PRESENTValue _PRESENT;
		/// <summary>
		/// part or work piece is detected or is present.
		/// </summary>
		public PRESENTValue PRESENT => _PRESENT ?? (_PRESENT = new PRESENTValue());

		/// <summary>
		/// part or work piece is detected or is present.
		/// </summary>
		public sealed class PRESENTValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "PRESENT";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.5";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// part or work piece is detected or is present.";
		}
		private NOT_PRESENTValue _NOT_PRESENT;
		/// <summary>
		/// part or work piece is not detected or is not present.
		/// </summary>
		public NOT_PRESENTValue NOT_PRESENT => _NOT_PRESENT ?? (_NOT_PRESENT = new NOT_PRESENTValue());

		/// <summary>
		/// part or work piece is not detected or is not present.
		/// </summary>
		public sealed class NOT_PRESENTValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "NOT_PRESENT";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.5";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// part or work piece is not detected or is not present.";
		}
	}
}