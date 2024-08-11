using System;
using System.CodeDom.Compiler;using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;

namespace Mtconnect.DataTypes
{
	/// <summary>
	/// View in the MTConnect Model browser <seealso href="https://model.mtconnect.org/#Enumeration___19_0_3_91b028d_1579277872728_249968_3735">model.mtconnect.org</seealso>
	/// </summary>
	/// <remarks>
	/// <list type="bullet">
	/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
	/// </list>
	/// </remarks>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.3.0.0")]
	public enum CategoryEnum
	{
		/// <summary>
		/// continuously variable or analog data value.   A continuous value can be measured at any point-in-time and will always produce a result.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>
		SAMPLE,
		/// <summary>
		/// discrete piece of information from the piece of equipment.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// </list>
		/// </remarks>
		EVENT,
		/// <summary>
		/// information about the health of a piece of equipment and its ability to function.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.1">v1.1</see></item>
		/// </list>
		/// </remarks>
		CONDITION,
	}

	/// <summary>
	/// View in the MTConnect Model browser <seealso href="https://model.mtconnect.org/#Enumeration___19_0_3_91b028d_1579277872728_249968_3735">model.mtconnect.org</seealso>
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.3.0.0")]
	public sealed class CategoryEnumMetaClass : IEnum
	{
		/// <inheritdoc />
		public string Name => "CategoryEnum";
		
		/// <inheritdoc />
		public Type DataType => null;
		
		public Type Instance => typeof(CategoryEnum);

		/// <inheritdoc />
		public string NormativeVersion => "1.0";
		
		/// <inheritdoc />
		public string DeprecatedVersion => "";
		
		/// <inheritdoc />
		public string Summary => @"";
		
		/// <inheritdoc />
		public IEnumInstance[] Values => new IEnumInstance[] {
		SAMPLE,
		EVENT,
		CONDITION,
		};

		private SAMPLEValue _SAMPLE;
		/// <summary>
		/// continuously variable or analog data value.   A continuous value can be measured at any point-in-time and will always produce a result.
		/// </summary>
		public SAMPLEValue SAMPLE => _SAMPLE ?? (_SAMPLE = new SAMPLEValue());

		/// <summary>
		/// continuously variable or analog data value.   A continuous value can be measured at any point-in-time and will always produce a result.
		/// </summary>
		public sealed class SAMPLEValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "SAMPLE";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.0";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// continuously variable or analog data value.   A continuous value can be measured at any point-in-time and will always produce a result.";
		}
		private EVENTValue _EVENT;
		/// <summary>
		/// discrete piece of information from the piece of equipment.
		/// </summary>
		public EVENTValue EVENT => _EVENT ?? (_EVENT = new EVENTValue());

		/// <summary>
		/// discrete piece of information from the piece of equipment.
		/// </summary>
		public sealed class EVENTValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "EVENT";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.0";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// discrete piece of information from the piece of equipment.";
		}
		private CONDITIONValue _CONDITION;
		/// <summary>
		/// information about the health of a piece of equipment and its ability to function.
		/// </summary>
		public CONDITIONValue CONDITION => _CONDITION ?? (_CONDITION = new CONDITIONValue());

		/// <summary>
		/// information about the health of a piece of equipment and its ability to function.
		/// </summary>
		public sealed class CONDITIONValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "CONDITION";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.1";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// information about the health of a piece of equipment and its ability to function.";
		}
	}
}