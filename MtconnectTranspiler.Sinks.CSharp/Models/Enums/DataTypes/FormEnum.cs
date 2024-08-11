using System;
using System.CodeDom.Compiler;using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;

namespace Mtconnect.DataTypes
{
	/// <summary>
	/// View in the MTConnect Model browser <seealso href="https://model.mtconnect.org/#Enumeration___19_0_3_68e0225_1618830616283_5956_278">model.mtconnect.org</seealso>
	/// </summary>
	/// <remarks>
	/// <list type="bullet">
	/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.8">v1.8</see></item>
	/// </list>
	/// </remarks>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.3.0.0")]
	public enum FormEnum
	{
		/// <summary>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.8">v1.8</see></item>
		/// </list>
		/// </remarks>
		BAR,
		/// <summary>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.8">v1.8</see></item>
		/// </list>
		/// </remarks>
		SHEET,
		/// <summary>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.8">v1.8</see></item>
		/// </list>
		/// </remarks>
		BLOCK,
		/// <summary>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.8">v1.8</see></item>
		/// </list>
		/// </remarks>
		CASTING,
		/// <summary>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.8">v1.8</see></item>
		/// </list>
		/// </remarks>
		POWDER,
		/// <summary>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.8">v1.8</see></item>
		/// </list>
		/// </remarks>
		LIQUID,
		/// <summary>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.8">v1.8</see></item>
		/// </list>
		/// </remarks>
		GEL,
		/// <summary>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.8">v1.8</see></item>
		/// </list>
		/// </remarks>
		FILAMENT,
		/// <summary>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.8">v1.8</see></item>
		/// </list>
		/// </remarks>
		GAS,
	}

	/// <summary>
	/// View in the MTConnect Model browser <seealso href="https://model.mtconnect.org/#Enumeration___19_0_3_68e0225_1618830616283_5956_278">model.mtconnect.org</seealso>
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.3.0.0")]
	public sealed class FormEnumMetaClass : IEnum
	{
		/// <inheritdoc />
		public string Name => "FormEnum";
		
		/// <inheritdoc />
		public Type DataType => null;
		
		public Type Instance => typeof(FormEnum);

		/// <inheritdoc />
		public string NormativeVersion => "1.8";
		
		/// <inheritdoc />
		public string DeprecatedVersion => "";
		
		/// <inheritdoc />
		public string Summary => @"";
		
		/// <inheritdoc />
		public IEnumInstance[] Values => new IEnumInstance[] {
		BAR,
		SHEET,
		BLOCK,
		CASTING,
		POWDER,
		LIQUID,
		GEL,
		FILAMENT,
		GAS,
		};

		private BARValue _BAR;
		public BARValue BAR => _BAR ?? (_BAR = new BARValue());

		public sealed class BARValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "BAR";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.8";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"";
		}
		private SHEETValue _SHEET;
		public SHEETValue SHEET => _SHEET ?? (_SHEET = new SHEETValue());

		public sealed class SHEETValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "SHEET";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.8";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"";
		}
		private BLOCKValue _BLOCK;
		public BLOCKValue BLOCK => _BLOCK ?? (_BLOCK = new BLOCKValue());

		public sealed class BLOCKValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "BLOCK";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.8";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"";
		}
		private CASTINGValue _CASTING;
		public CASTINGValue CASTING => _CASTING ?? (_CASTING = new CASTINGValue());

		public sealed class CASTINGValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "CASTING";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.8";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"";
		}
		private POWDERValue _POWDER;
		public POWDERValue POWDER => _POWDER ?? (_POWDER = new POWDERValue());

		public sealed class POWDERValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "POWDER";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.8";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"";
		}
		private LIQUIDValue _LIQUID;
		public LIQUIDValue LIQUID => _LIQUID ?? (_LIQUID = new LIQUIDValue());

		public sealed class LIQUIDValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "LIQUID";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.8";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"";
		}
		private GELValue _GEL;
		public GELValue GEL => _GEL ?? (_GEL = new GELValue());

		public sealed class GELValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "GEL";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.8";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"";
		}
		private FILAMENTValue _FILAMENT;
		public FILAMENTValue FILAMENT => _FILAMENT ?? (_FILAMENT = new FILAMENTValue());

		public sealed class FILAMENTValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "FILAMENT";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.8";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"";
		}
		private GASValue _GAS;
		public GASValue GAS => _GAS ?? (_GAS = new GASValue());

		public sealed class GASValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "GAS";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.8";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"";
		}
	}
}