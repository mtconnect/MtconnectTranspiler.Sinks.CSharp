using System;
using System.CodeDom.Compiler;using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;

namespace Mtconnect.DataTypes
{
	/// <summary>
	/// View in the MTConnect Model browser <seealso href="https://model.mtconnect.org/#Enumeration___19_0_3_68e0225_1678195766304_380006_17434">model.mtconnect.org</seealso>
	﻿
	/// </summary>
	/// <remarks>
	/// <list type="bullet">
	/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_2.2">v2.2</see></item>
	/// </list>
	/// </remarks>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public enum UncertaintyTypeEnum
	{
		/// <summary>
		﻿/// <i>combined standard uncertainty</i>.<br/><br />

		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_2.2">v2.2</see></item>
		/// </list>
		/// </remarks>
		COMBINED,
		/// <summary>
		﻿/// <i>standard uncertainty</i> using arithmetic mean or average the observations. <seealso href="https://www.google.com/search?q=JCGM 100:2008 4.2&btnI=I">JCGM 100:2008 4.2</seealso><br/><br />

		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_2.2">v2.2</see></item>
		/// </list>
		/// </remarks>
		MEAN,
	}

	/// <summary>
	/// View in the MTConnect Model browser <seealso href="https://model.mtconnect.org/#Enumeration___19_0_3_68e0225_1678195766304_380006_17434">model.mtconnect.org</seealso>
	﻿
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public sealed class UncertaintyTypeEnumMetaClass : IEnum
	{
		/// <inheritdoc />
		public string Name => "UncertaintyTypeEnum";
		
		/// <inheritdoc />
		public Type DataType => null;
		
		public Type Instance => typeof(UncertaintyTypeEnum);

		/// <inheritdoc />
		public string NormativeVersion => "2.2";
		
		/// <inheritdoc />
		public string DeprecatedVersion => "";
		
		/// <inheritdoc />
		public string Summary => @"";
		
		/// <inheritdoc />
		public IEnumInstance[] Values => new IEnumInstance[] {
		COMBINED,
		MEAN,
		};

		private COMBINEDValue _COMBINED;
		/// <summary>
		﻿/// <i>combined standard uncertainty</i>.<br/><br />

		/// </summary>
		public COMBINEDValue COMBINED => _COMBINED ?? (_COMBINED = new COMBINEDValue());

		/// <summary>
		﻿/// <i>combined standard uncertainty</i>.<br/><br />

		/// </summary>
		public sealed class COMBINEDValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "COMBINED";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "2.2";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"&#10;&#10;&#10;{{term(combined standard uncertainty)}}.&#10;
";
		}
		private MEANValue _MEAN;
		/// <summary>
		﻿/// <i>standard uncertainty</i> using arithmetic mean or average the observations. <seealso href="https://www.google.com/search?q=JCGM 100:2008 4.2&btnI=I">JCGM 100:2008 4.2</seealso><br/><br />

		/// </summary>
		public MEANValue MEAN => _MEAN ?? (_MEAN = new MEANValue());

		/// <summary>
		﻿/// <i>standard uncertainty</i> using arithmetic mean or average the observations. <seealso href="https://www.google.com/search?q=JCGM 100:2008 4.2&btnI=I">JCGM 100:2008 4.2</seealso><br/><br />

		/// </summary>
		public sealed class MEANValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "MEAN";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "2.2";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"&#10;&#10;&#10;{{term(standard uncertainty)}} using arithmetic mean or average the observations. {{cite(JCGM 100:2008 4.2)}}&#10;
";
		}
	}
}