#pragma warning disable CS1574 // XML comment has cref attribute that could not be resolved
#pragma warning disable CS1584 // XML comment has syntactically incorrect cref attribute
using System;
using System.CodeDom.Compiler;using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;

namespace Mtconnect.DataTypes
{
	/// <summary>﻿
	/// <br/> Visit <seealso href="https://model.mtconnect.org/#Enumeration___19_0_3_68e0225_1618830616283_5956_278">model.mtconnect.org</seealso> for more information.
	/// </summary>
	/// <remarks>
	/// <list type="bullet">
	/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.8">v1.8</see></item>
	/// </list>
	/// </remarks>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public enum FormEnum
	{
		/// <summary>﻿
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.8">v1.8</see></item>
		/// </list>
		/// </remarks>
		BAR,
		/// <summary>﻿
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.8">v1.8</see></item>
		/// </list>
		/// </remarks>
		SHEET,
		/// <summary>﻿
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.8">v1.8</see></item>
		/// </list>
		/// </remarks>
		BLOCK,
		/// <summary>﻿
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.8">v1.8</see></item>
		/// </list>
		/// </remarks>
		CASTING,
		/// <summary>﻿
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.8">v1.8</see></item>
		/// </list>
		/// </remarks>
		POWDER,
		/// <summary>﻿
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.8">v1.8</see></item>
		/// </list>
		/// </remarks>
		LIQUID,
		/// <summary>﻿
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.8">v1.8</see></item>
		/// </list>
		/// </remarks>
		GEL,
		/// <summary>﻿
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.8">v1.8</see></item>
		/// </list>
		/// </remarks>
		FILAMENT,
		/// <summary>﻿
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.8">v1.8</see></item>
		/// </list>
		/// </remarks>
		GAS,
	}

	/// <summary>﻿
	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Enumeration___19_0_3_68e0225_1618830616283_5956_278">model.mtconnect.org</seealso> for more information.
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public sealed class FormEnumMetaClass : IEnum
	{
		/// <inheritdoc />
		public string Name => "FormEnum";
		
		/// <inheritdoc />
		public Type DataType => null;
		
		/// <inheritdoc />
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
		/// <inheritdoc cref="BARValue" path="/summary" />
		public BARValue BAR => _BAR ?? (_BAR = new BARValue());

		/// <summary>﻿
		/// Value for FormEnum.<br/>
		/// <br/>See also <seealso cref="FormEnum">FormEnum</seealso>
		/// </summary>
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
		/// <inheritdoc cref="SHEETValue" path="/summary" />
		public SHEETValue SHEET => _SHEET ?? (_SHEET = new SHEETValue());

		/// <summary>﻿
		/// Value for FormEnum.<br/>
		/// <br/>See also <seealso cref="FormEnum">FormEnum</seealso>
		/// </summary>
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
		/// <inheritdoc cref="BLOCKValue" path="/summary" />
		public BLOCKValue BLOCK => _BLOCK ?? (_BLOCK = new BLOCKValue());

		/// <summary>﻿
		/// Value for FormEnum.<br/>
		/// <br/>See also <seealso cref="FormEnum">FormEnum</seealso>
		/// </summary>
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
		/// <inheritdoc cref="CASTINGValue" path="/summary" />
		public CASTINGValue CASTING => _CASTING ?? (_CASTING = new CASTINGValue());

		/// <summary>﻿
		/// Value for FormEnum.<br/>
		/// <br/>See also <seealso cref="FormEnum">FormEnum</seealso>
		/// </summary>
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
		/// <inheritdoc cref="POWDERValue" path="/summary" />
		public POWDERValue POWDER => _POWDER ?? (_POWDER = new POWDERValue());

		/// <summary>﻿
		/// Value for FormEnum.<br/>
		/// <br/>See also <seealso cref="FormEnum">FormEnum</seealso>
		/// </summary>
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
		/// <inheritdoc cref="LIQUIDValue" path="/summary" />
		public LIQUIDValue LIQUID => _LIQUID ?? (_LIQUID = new LIQUIDValue());

		/// <summary>﻿
		/// Value for FormEnum.<br/>
		/// <br/>See also <seealso cref="FormEnum">FormEnum</seealso>
		/// </summary>
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
		/// <inheritdoc cref="GELValue" path="/summary" />
		public GELValue GEL => _GEL ?? (_GEL = new GELValue());

		/// <summary>﻿
		/// Value for FormEnum.<br/>
		/// <br/>See also <seealso cref="FormEnum">FormEnum</seealso>
		/// </summary>
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
		/// <inheritdoc cref="FILAMENTValue" path="/summary" />
		public FILAMENTValue FILAMENT => _FILAMENT ?? (_FILAMENT = new FILAMENTValue());

		/// <summary>﻿
		/// Value for FormEnum.<br/>
		/// <br/>See also <seealso cref="FormEnum">FormEnum</seealso>
		/// </summary>
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
		/// <inheritdoc cref="GASValue" path="/summary" />
		public GASValue GAS => _GAS ?? (_GAS = new GASValue());

		/// <summary>﻿
		/// Value for FormEnum.<br/>
		/// <br/>See also <seealso cref="FormEnum">FormEnum</seealso>
		/// </summary>
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