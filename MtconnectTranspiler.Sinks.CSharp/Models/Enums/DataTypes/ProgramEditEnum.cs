using System;
using System.CodeDom.Compiler;using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;

namespace Mtconnect.DataTypes
{
	/// <summary>
	/// View in the MTConnect Model browser <seealso href="https://model.mtconnect.org/#Enumeration___19_0_3_45f01b9_1580378417667_46066_2882">model.mtconnect.org</seealso>
	/// </summary>
	/// <remarks>
	/// <list type="bullet">
	/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.3">v1.3</see></item>
	/// </list>
	/// </remarks>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.3.0.0")]
	public enum ProgramEditEnum
	{
		/// <summary>
		/// <see cref="Controller">Controller</see> is in the program edit mode.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.3">v1.3</see></item>
		/// </list>
		/// </remarks>
		ACTIVE,
		/// <summary>
		/// <see cref="Controller">Controller</see> is capable of entering the program edit mode and no function is inhibiting a change to that mode.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.3">v1.3</see></item>
		/// </list>
		/// </remarks>
		READY,
		/// <summary>
		/// <see cref="Controller">Controller</see> is being inhibited by a function from entering the program edit mode.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.3">v1.3</see></item>
		/// </list>
		/// </remarks>
		NOT_READY,
	}

	/// <summary>
	/// View in the MTConnect Model browser <seealso href="https://model.mtconnect.org/#Enumeration___19_0_3_45f01b9_1580378417667_46066_2882">model.mtconnect.org</seealso>
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.3.0.0")]
	public sealed class ProgramEditEnumMetaClass : IEnum
	{
		/// <inheritdoc />
		public string Name => "ProgramEditEnum";
		
		/// <inheritdoc />
		public Type DataType => null;
		
		public Type Instance => typeof(ProgramEditEnum);

		/// <inheritdoc />
		public string NormativeVersion => "1.3";
		
		/// <inheritdoc />
		public string DeprecatedVersion => "";
		
		/// <inheritdoc />
		public string Summary => @"";
		
		/// <inheritdoc />
		public IEnumInstance[] Values => new IEnumInstance[] {
		ACTIVE,
		READY,
		NOT_READY,
		};

		private ACTIVEValue _ACTIVE;
		/// <summary>
		/// <see cref="Controller">Controller</see> is in the program edit mode.
		/// </summary>
		public ACTIVEValue ACTIVE => _ACTIVE ?? (_ACTIVE = new ACTIVEValue());

		/// <summary>
		/// <see cref="Controller">Controller</see> is in the program edit mode.
		/// </summary>
		public sealed class ACTIVEValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "ACTIVE";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.3";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// <see cref=""Controller"">Controller</see> is in the program edit mode.";
		}
		private READYValue _READY;
		/// <summary>
		/// <see cref="Controller">Controller</see> is capable of entering the program edit mode and no function is inhibiting a change to that mode.
		/// </summary>
		public READYValue READY => _READY ?? (_READY = new READYValue());

		/// <summary>
		/// <see cref="Controller">Controller</see> is capable of entering the program edit mode and no function is inhibiting a change to that mode.
		/// </summary>
		public sealed class READYValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "READY";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.3";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// <see cref=""Controller"">Controller</see> is capable of entering the program edit mode and no function is inhibiting a change to that mode.";
		}
		private NOT_READYValue _NOT_READY;
		/// <summary>
		/// <see cref="Controller">Controller</see> is being inhibited by a function from entering the program edit mode.
		/// </summary>
		public NOT_READYValue NOT_READY => _NOT_READY ?? (_NOT_READY = new NOT_READYValue());

		/// <summary>
		/// <see cref="Controller">Controller</see> is being inhibited by a function from entering the program edit mode.
		/// </summary>
		public sealed class NOT_READYValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "NOT_READY";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.3";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// <see cref=""Controller"">Controller</see> is being inhibited by a function from entering the program edit mode.";
		}
	}
}