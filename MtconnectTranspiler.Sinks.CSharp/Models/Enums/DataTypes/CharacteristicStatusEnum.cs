using System;
using System.CodeDom.Compiler;using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;

namespace Mtconnect.DataTypes
{
	/// <summary>
	/// View in the MTConnect Model browser <seealso href="https://model.mtconnect.org/#Enumeration___19_0_3_68e0225_1678195723846_572772_17405">model.mtconnect.org</seealso>
	﻿
	/// </summary>
	/// <remarks>
	/// <list type="bullet">
	/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_2.2">v2.2</see></item>
	/// </list>
	/// </remarks>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public enum CharacteristicStatusEnum
	{
		/// <summary>
		﻿/// measurement is within acceptable tolerances.<br/><br />

		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_2.2">v2.2</see></item>
		/// </list>
		/// </remarks>
		PASS,
		/// <summary>
		﻿/// measurement is not within acceptable tolerances.<br/><br />

		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_2.2">v2.2</see></item>
		/// </list>
		/// </remarks>
		FAIL,
		/// <summary>
		﻿/// failed, but acceptable constraints achievable by utilizing additional manufacturing processes.<br/><br />

		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_2.2">v2.2</see></item>
		/// </list>
		/// </remarks>
		REWORK,
		/// <summary>
		﻿/// measurement is indeterminate due to an equipment failure.<br/><br />

		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_2.2">v2.2</see></item>
		/// </list>
		/// </remarks>
		SYSTEM_ERROR,
		/// <summary>
		﻿/// measurement cannot be determined.<br/><br />

		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_2.2">v2.2</see></item>
		/// </list>
		/// </remarks>
		INDETERMINATE,
		/// <summary>
		﻿/// measurement cannot be evaluated.<br/><br />

		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_2.2">v2.2</see></item>
		/// </list>
		/// </remarks>
		NOT_ANALYZED,
		/// <summary>
		﻿/// nominal provided without tolerance limits. <seealso href="https://www.google.com/search?q=QIF 3:2018 5.10.2.6&btnI=I">QIF 3:2018 5.10.2.6</seealso><br/><br />

		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_2.2">v2.2</see></item>
		/// </list>
		/// </remarks>
		BASIC_OR_THEORETIC_EXACT_DIMENSION,
		/// <summary>
		﻿/// status of measurement cannot be determined.<br/><br />

		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_2.2">v2.2</see></item>
		/// </list>
		/// </remarks>
		UNDEFINED,
	}

	/// <summary>
	/// View in the MTConnect Model browser <seealso href="https://model.mtconnect.org/#Enumeration___19_0_3_68e0225_1678195723846_572772_17405">model.mtconnect.org</seealso>
	﻿
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public sealed class CharacteristicStatusEnumMetaClass : IEnum
	{
		/// <inheritdoc />
		public string Name => "CharacteristicStatusEnum";
		
		/// <inheritdoc />
		public Type DataType => null;
		
		public Type Instance => typeof(CharacteristicStatusEnum);

		/// <inheritdoc />
		public string NormativeVersion => "2.2";
		
		/// <inheritdoc />
		public string DeprecatedVersion => "";
		
		/// <inheritdoc />
		public string Summary => @"";
		
		/// <inheritdoc />
		public IEnumInstance[] Values => new IEnumInstance[] {
		PASS,
		FAIL,
		REWORK,
		SYSTEM_ERROR,
		INDETERMINATE,
		NOT_ANALYZED,
		BASIC_OR_THEORETIC_EXACT_DIMENSION,
		UNDEFINED,
		};

		private PASSValue _PASS;
		/// <summary>
		﻿/// measurement is within acceptable tolerances.<br/><br />

		/// </summary>
		public PASSValue PASS => _PASS ?? (_PASS = new PASSValue());

		/// <summary>
		﻿/// measurement is within acceptable tolerances.<br/><br />

		/// </summary>
		public sealed class PASSValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "PASS";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "2.2";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"&#10;&#10;&#10;measurement is within acceptable tolerances.&#10;
";
		}
		private FAILValue _FAIL;
		/// <summary>
		﻿/// measurement is not within acceptable tolerances.<br/><br />

		/// </summary>
		public FAILValue FAIL => _FAIL ?? (_FAIL = new FAILValue());

		/// <summary>
		﻿/// measurement is not within acceptable tolerances.<br/><br />

		/// </summary>
		public sealed class FAILValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "FAIL";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "2.2";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"&#10;&#10;&#10;measurement is not within acceptable tolerances.&#10;
";
		}
		private REWORKValue _REWORK;
		/// <summary>
		﻿/// failed, but acceptable constraints achievable by utilizing additional manufacturing processes.<br/><br />

		/// </summary>
		public REWORKValue REWORK => _REWORK ?? (_REWORK = new REWORKValue());

		/// <summary>
		﻿/// failed, but acceptable constraints achievable by utilizing additional manufacturing processes.<br/><br />

		/// </summary>
		public sealed class REWORKValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "REWORK";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "2.2";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"&#10;&#10;&#10;failed, but acceptable constraints achievable by utilizing additional manufacturing processes.&#10;
";
		}
		private SYSTEM_ERRORValue _SYSTEM_ERROR;
		/// <summary>
		﻿/// measurement is indeterminate due to an equipment failure.<br/><br />

		/// </summary>
		public SYSTEM_ERRORValue SYSTEM_ERROR => _SYSTEM_ERROR ?? (_SYSTEM_ERROR = new SYSTEM_ERRORValue());

		/// <summary>
		﻿/// measurement is indeterminate due to an equipment failure.<br/><br />

		/// </summary>
		public sealed class SYSTEM_ERRORValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "SYSTEM_ERROR";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "2.2";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"&#10;&#10;&#10;measurement is indeterminate due to an equipment failure.&#10;
";
		}
		private INDETERMINATEValue _INDETERMINATE;
		/// <summary>
		﻿/// measurement cannot be determined.<br/><br />

		/// </summary>
		public INDETERMINATEValue INDETERMINATE => _INDETERMINATE ?? (_INDETERMINATE = new INDETERMINATEValue());

		/// <summary>
		﻿/// measurement cannot be determined.<br/><br />

		/// </summary>
		public sealed class INDETERMINATEValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "INDETERMINATE";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "2.2";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"&#10;&#10;&#10;measurement cannot be determined.&#10;
";
		}
		private NOT_ANALYZEDValue _NOT_ANALYZED;
		/// <summary>
		﻿/// measurement cannot be evaluated.<br/><br />

		/// </summary>
		public NOT_ANALYZEDValue NOT_ANALYZED => _NOT_ANALYZED ?? (_NOT_ANALYZED = new NOT_ANALYZEDValue());

		/// <summary>
		﻿/// measurement cannot be evaluated.<br/><br />

		/// </summary>
		public sealed class NOT_ANALYZEDValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "NOT_ANALYZED";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "2.2";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"&#10;&#10;&#10;measurement cannot be evaluated.&#10;
";
		}
		private BASIC_OR_THEORETIC_EXACT_DIMENSIONValue _BASIC_OR_THEORETIC_EXACT_DIMENSION;
		/// <summary>
		﻿/// nominal provided without tolerance limits. <seealso href="https://www.google.com/search?q=QIF 3:2018 5.10.2.6&btnI=I">QIF 3:2018 5.10.2.6</seealso><br/><br />

		/// </summary>
		public BASIC_OR_THEORETIC_EXACT_DIMENSIONValue BASIC_OR_THEORETIC_EXACT_DIMENSION => _BASIC_OR_THEORETIC_EXACT_DIMENSION ?? (_BASIC_OR_THEORETIC_EXACT_DIMENSION = new BASIC_OR_THEORETIC_EXACT_DIMENSIONValue());

		/// <summary>
		﻿/// nominal provided without tolerance limits. <seealso href="https://www.google.com/search?q=QIF 3:2018 5.10.2.6&btnI=I">QIF 3:2018 5.10.2.6</seealso><br/><br />

		/// </summary>
		public sealed class BASIC_OR_THEORETIC_EXACT_DIMENSIONValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "BASIC_OR_THEORETIC_EXACT_DIMENSION";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "2.2";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"&#10;&#10;&#10;nominal provided without tolerance limits. {{cite(QIF 3:2018 5.10.2.6)}}&#10;
";
		}
		private UNDEFINEDValue _UNDEFINED;
		/// <summary>
		﻿/// status of measurement cannot be determined.<br/><br />

		/// </summary>
		public UNDEFINEDValue UNDEFINED => _UNDEFINED ?? (_UNDEFINED = new UNDEFINEDValue());

		/// <summary>
		﻿/// status of measurement cannot be determined.<br/><br />

		/// </summary>
		public sealed class UNDEFINEDValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "UNDEFINED";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "2.2";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"&#10;&#10;&#10;status of measurement cannot be determined.&#10;
";
		}
	}
}