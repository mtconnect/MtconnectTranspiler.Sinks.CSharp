#pragma warning disable CS1574 // XML comment has cref attribute that could not be resolved
#pragma warning disable CS1584 // XML comment has syntactically incorrect cref attribute
#pragma warning disable CS0618 // Type or member is obsolete
using System;
using System.CodeDom.Compiler;using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;

namespace Mtconnect.DataTypes
{
	/// <summary>﻿
	/// <br/> Visit <seealso href="https://model.mtconnect.org/#Enumeration___19_0_3_68e0225_1678195723846_572772_17405">model.mtconnect.org</seealso> for more information.
	/// </summary>
	/// <remarks>
	/// <list type="bullet">
	/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_2.2">v2.2</see></item>
	/// </list>
	/// </remarks>

	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public enum CharacteristicStatusEnum
	{
		/// <summary>﻿measurement is within acceptable tolerances.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_2.2">v2.2</see></item>
		/// </list>
		/// </remarks>

		PASS,
		/// <summary>﻿measurement is not within acceptable tolerances.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_2.2">v2.2</see></item>
		/// </list>
		/// </remarks>

		FAIL,
		/// <summary>﻿failed, but acceptable constraints achievable by utilizing additional manufacturing processes.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_2.2">v2.2</see></item>
		/// </list>
		/// </remarks>

		REWORK,
		/// <summary>﻿measurement is indeterminate due to an equipment failure.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_2.2">v2.2</see></item>
		/// </list>
		/// </remarks>

		SYSTEM_ERROR,
		/// <summary>﻿measurement cannot be determined.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_2.2">v2.2</see></item>
		/// </list>
		/// </remarks>

		INDETERMINATE,
		/// <summary>﻿measurement cannot be evaluated.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_2.2">v2.2</see></item>
		/// </list>
		/// </remarks>

		NOT_ANALYZED,
		/// <summary>﻿nominal provided without tolerance limits. <seealso href="https://www.google.com/search?q=QIF 3:2018 5.10.2.6&amp;btnI=I">QIF 3:2018 5.10.2.6</seealso><br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_2.2">v2.2</see></item>
		/// </list>
		/// </remarks>

		BASIC_OR_THEORETIC_EXACT_DIMENSION,
		/// <summary>﻿status of measurement cannot be determined.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_2.2">v2.2</see></item>
		/// </list>
		/// </remarks>

		UNDEFINED,
	}

	/// <summary>﻿
	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Enumeration___19_0_3_68e0225_1678195723846_572772_17405">model.mtconnect.org</seealso> for more information.
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public sealed class CharacteristicStatusEnumMetaClass : IEnum
	{
		/// <summary>Constant value for <see cref="CharacteristicStatusEnumMetaClass.ReferenceId" /></summary>
		public const string REFERENCE_ID = "_19_0_3_68e0225_1678195723846_572772_17405";
		/// <summary>Constant value for <see cref="CharacteristicStatusEnumMetaClass.HelpUrl" /></summary>
		public const string HELP_URL = "https://model.mtconnect.org/#Enumeration___19_0_3_68e0225_1678195723846_572772_17405";
		/// <summary>Constant value for <see cref="CharacteristicStatusEnumMetaClass.Name" /></summary>
		public const string NAME = "CharacteristicStatusEnum";
		/// <summary>Constant value for <see cref="CharacteristicStatusEnumMetaClass.NormativeVersion" /></summary>
		public const string NORMATIVE_VERSION = "2.2";
		/// <summary>Constant value for <see cref="CharacteristicStatusEnumMetaClass.DeprecatedVersion" /></summary>
		public const string DEPRECATED_VERSION = "";
		/// <summary>Constant value for <see cref="CharacteristicStatusEnumMetaClass.Summary" /></summary>
		public const string SUMMARY = @"";

		/// <inheritdoc />
		public string ReferenceId => REFERENCE_ID;
		
		/// <inheritdoc />
		public string HelpUrl => HELP_URL;

		/// <inheritdoc />
		public string Name => NAME;
		
		/// <inheritdoc />
		public Type DataType => null;
		
		/// <inheritdoc />
		public Type Instance => typeof(CharacteristicStatusEnum);

		/// <inheritdoc />
		public string NormativeVersion => NORMATIVE_VERSION;
		
		/// <inheritdoc />
		public string DeprecatedVersion => DEPRECATED_VERSION;
		
		/// <inheritdoc />
		public string Summary => SUMMARY;
		
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
		/// <inheritdoc cref="PASSValue" path="/summary" />
		public PASSValue PASS => _PASS ?? (_PASS = new PASSValue());

		/// <summary>﻿measurement is within acceptable tolerances.<br /><br /><br />
		/// Value for CharacteristicStatusEnum.<br/>
		/// <br/>See also <seealso cref="CharacteristicStatusEnum">CharacteristicStatusEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_2.2">v2.2</see></item>
		/// </list>
		/// </remarks>

		public sealed class PASSValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="PASSValue.Name" /></summary>
			public const string NAME = "PASS";
			/// <summary>Constant value for <see cref="PASSValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "2.2";
			/// <summary>Constant value for <see cref="PASSValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="PASSValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;measurement is within acceptable tolerances.&#10;
";

			/// <inheritdoc />
			public string Name => NAME;
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => NORMATIVE_VERSION;
			
			/// <inheritdoc />
			public string DeprecatedVersion => DEPRECATED_VERSION;
			
			/// <inheritdoc />
			public string Summary => SUMMARY;
		}
		private FAILValue _FAIL;
		/// <inheritdoc cref="FAILValue" path="/summary" />
		public FAILValue FAIL => _FAIL ?? (_FAIL = new FAILValue());

		/// <summary>﻿measurement is not within acceptable tolerances.<br /><br /><br />
		/// Value for CharacteristicStatusEnum.<br/>
		/// <br/>See also <seealso cref="CharacteristicStatusEnum">CharacteristicStatusEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_2.2">v2.2</see></item>
		/// </list>
		/// </remarks>

		public sealed class FAILValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="FAILValue.Name" /></summary>
			public const string NAME = "FAIL";
			/// <summary>Constant value for <see cref="FAILValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "2.2";
			/// <summary>Constant value for <see cref="FAILValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="FAILValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;measurement is not within acceptable tolerances.&#10;
";

			/// <inheritdoc />
			public string Name => NAME;
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => NORMATIVE_VERSION;
			
			/// <inheritdoc />
			public string DeprecatedVersion => DEPRECATED_VERSION;
			
			/// <inheritdoc />
			public string Summary => SUMMARY;
		}
		private REWORKValue _REWORK;
		/// <inheritdoc cref="REWORKValue" path="/summary" />
		public REWORKValue REWORK => _REWORK ?? (_REWORK = new REWORKValue());

		/// <summary>﻿failed, but acceptable constraints achievable by utilizing additional manufacturing processes.<br /><br /><br />
		/// Value for CharacteristicStatusEnum.<br/>
		/// <br/>See also <seealso cref="CharacteristicStatusEnum">CharacteristicStatusEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_2.2">v2.2</see></item>
		/// </list>
		/// </remarks>

		public sealed class REWORKValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="REWORKValue.Name" /></summary>
			public const string NAME = "REWORK";
			/// <summary>Constant value for <see cref="REWORKValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "2.2";
			/// <summary>Constant value for <see cref="REWORKValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="REWORKValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;failed, but acceptable constraints achievable by utilizing additional manufacturing processes.&#10;
";

			/// <inheritdoc />
			public string Name => NAME;
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => NORMATIVE_VERSION;
			
			/// <inheritdoc />
			public string DeprecatedVersion => DEPRECATED_VERSION;
			
			/// <inheritdoc />
			public string Summary => SUMMARY;
		}
		private SYSTEM_ERRORValue _SYSTEM_ERROR;
		/// <inheritdoc cref="SYSTEM_ERRORValue" path="/summary" />
		public SYSTEM_ERRORValue SYSTEM_ERROR => _SYSTEM_ERROR ?? (_SYSTEM_ERROR = new SYSTEM_ERRORValue());

		/// <summary>﻿measurement is indeterminate due to an equipment failure.<br /><br /><br />
		/// Value for CharacteristicStatusEnum.<br/>
		/// <br/>See also <seealso cref="CharacteristicStatusEnum">CharacteristicStatusEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_2.2">v2.2</see></item>
		/// </list>
		/// </remarks>

		public sealed class SYSTEM_ERRORValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="SYSTEM_ERRORValue.Name" /></summary>
			public const string NAME = "SYSTEM_ERROR";
			/// <summary>Constant value for <see cref="SYSTEM_ERRORValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "2.2";
			/// <summary>Constant value for <see cref="SYSTEM_ERRORValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="SYSTEM_ERRORValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;measurement is indeterminate due to an equipment failure.&#10;
";

			/// <inheritdoc />
			public string Name => NAME;
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => NORMATIVE_VERSION;
			
			/// <inheritdoc />
			public string DeprecatedVersion => DEPRECATED_VERSION;
			
			/// <inheritdoc />
			public string Summary => SUMMARY;
		}
		private INDETERMINATEValue _INDETERMINATE;
		/// <inheritdoc cref="INDETERMINATEValue" path="/summary" />
		public INDETERMINATEValue INDETERMINATE => _INDETERMINATE ?? (_INDETERMINATE = new INDETERMINATEValue());

		/// <summary>﻿measurement cannot be determined.<br /><br /><br />
		/// Value for CharacteristicStatusEnum.<br/>
		/// <br/>See also <seealso cref="CharacteristicStatusEnum">CharacteristicStatusEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_2.2">v2.2</see></item>
		/// </list>
		/// </remarks>

		public sealed class INDETERMINATEValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="INDETERMINATEValue.Name" /></summary>
			public const string NAME = "INDETERMINATE";
			/// <summary>Constant value for <see cref="INDETERMINATEValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "2.2";
			/// <summary>Constant value for <see cref="INDETERMINATEValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="INDETERMINATEValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;measurement cannot be determined.&#10;
";

			/// <inheritdoc />
			public string Name => NAME;
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => NORMATIVE_VERSION;
			
			/// <inheritdoc />
			public string DeprecatedVersion => DEPRECATED_VERSION;
			
			/// <inheritdoc />
			public string Summary => SUMMARY;
		}
		private NOT_ANALYZEDValue _NOT_ANALYZED;
		/// <inheritdoc cref="NOT_ANALYZEDValue" path="/summary" />
		public NOT_ANALYZEDValue NOT_ANALYZED => _NOT_ANALYZED ?? (_NOT_ANALYZED = new NOT_ANALYZEDValue());

		/// <summary>﻿measurement cannot be evaluated.<br /><br /><br />
		/// Value for CharacteristicStatusEnum.<br/>
		/// <br/>See also <seealso cref="CharacteristicStatusEnum">CharacteristicStatusEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_2.2">v2.2</see></item>
		/// </list>
		/// </remarks>

		public sealed class NOT_ANALYZEDValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="NOT_ANALYZEDValue.Name" /></summary>
			public const string NAME = "NOT_ANALYZED";
			/// <summary>Constant value for <see cref="NOT_ANALYZEDValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "2.2";
			/// <summary>Constant value for <see cref="NOT_ANALYZEDValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="NOT_ANALYZEDValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;measurement cannot be evaluated.&#10;
";

			/// <inheritdoc />
			public string Name => NAME;
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => NORMATIVE_VERSION;
			
			/// <inheritdoc />
			public string DeprecatedVersion => DEPRECATED_VERSION;
			
			/// <inheritdoc />
			public string Summary => SUMMARY;
		}
		private BASIC_OR_THEORETIC_EXACT_DIMENSIONValue _BASIC_OR_THEORETIC_EXACT_DIMENSION;
		/// <inheritdoc cref="BASIC_OR_THEORETIC_EXACT_DIMENSIONValue" path="/summary" />
		public BASIC_OR_THEORETIC_EXACT_DIMENSIONValue BASIC_OR_THEORETIC_EXACT_DIMENSION => _BASIC_OR_THEORETIC_EXACT_DIMENSION ?? (_BASIC_OR_THEORETIC_EXACT_DIMENSION = new BASIC_OR_THEORETIC_EXACT_DIMENSIONValue());

		/// <summary>﻿nominal provided without tolerance limits. <seealso href="https://www.google.com/search?q=QIF 3:2018 5.10.2.6&amp;btnI=I">QIF 3:2018 5.10.2.6</seealso><br /><br /><br />
		/// Value for CharacteristicStatusEnum.<br/>
		/// <br/>See also <seealso cref="CharacteristicStatusEnum">CharacteristicStatusEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_2.2">v2.2</see></item>
		/// </list>
		/// </remarks>

		public sealed class BASIC_OR_THEORETIC_EXACT_DIMENSIONValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="BASIC_OR_THEORETIC_EXACT_DIMENSIONValue.Name" /></summary>
			public const string NAME = "BASIC_OR_THEORETIC_EXACT_DIMENSION";
			/// <summary>Constant value for <see cref="BASIC_OR_THEORETIC_EXACT_DIMENSIONValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "2.2";
			/// <summary>Constant value for <see cref="BASIC_OR_THEORETIC_EXACT_DIMENSIONValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="BASIC_OR_THEORETIC_EXACT_DIMENSIONValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;nominal provided without tolerance limits. {{cite(QIF 3:2018 5.10.2.6)}}&#10;
";

			/// <inheritdoc />
			public string Name => NAME;
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => NORMATIVE_VERSION;
			
			/// <inheritdoc />
			public string DeprecatedVersion => DEPRECATED_VERSION;
			
			/// <inheritdoc />
			public string Summary => SUMMARY;
		}
		private UNDEFINEDValue _UNDEFINED;
		/// <inheritdoc cref="UNDEFINEDValue" path="/summary" />
		public UNDEFINEDValue UNDEFINED => _UNDEFINED ?? (_UNDEFINED = new UNDEFINEDValue());

		/// <summary>﻿status of measurement cannot be determined.<br /><br /><br />
		/// Value for CharacteristicStatusEnum.<br/>
		/// <br/>See also <seealso cref="CharacteristicStatusEnum">CharacteristicStatusEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_2.2">v2.2</see></item>
		/// </list>
		/// </remarks>

		public sealed class UNDEFINEDValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="UNDEFINEDValue.Name" /></summary>
			public const string NAME = "UNDEFINED";
			/// <summary>Constant value for <see cref="UNDEFINEDValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "2.2";
			/// <summary>Constant value for <see cref="UNDEFINEDValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="UNDEFINEDValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;status of measurement cannot be determined.&#10;
";

			/// <inheritdoc />
			public string Name => NAME;
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => NORMATIVE_VERSION;
			
			/// <inheritdoc />
			public string DeprecatedVersion => DEPRECATED_VERSION;
			
			/// <inheritdoc />
			public string Summary => SUMMARY;
		}
	}
}