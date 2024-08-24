#pragma warning disable CS1574 // XML comment has cref attribute that could not be resolved
#pragma warning disable CS1584 // XML comment has syntactically incorrect cref attribute
#pragma warning disable CS0618 // Type or member is obsolete
using System;
using System.CodeDom.Compiler;using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;

namespace Mtconnect.DataTypes
{
	/// <summary>﻿
	/// <br/> Visit <seealso href="https://model.mtconnect.org/#Enumeration___19_0_3_68e0225_1678195766304_380006_17434">model.mtconnect.org</seealso> for more information.
	/// </summary>
	/// <remarks>
	/// <list type="bullet">
	/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_2.2">v2.2</see></item>
	/// </list>
	/// </remarks>

	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public enum UncertaintyTypeEnum
	{
		/// <summary>﻿<i>combined standard uncertainty</i>.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_2.2">v2.2</see></item>
		/// </list>
		/// </remarks>

		COMBINED,
		/// <summary>﻿<i>standard uncertainty</i> using arithmetic mean or average the observations. <seealso href="https://www.google.com/search?q=JCGM 100:2008 4.2&amp;btnI=I">JCGM 100:2008 4.2</seealso><br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_2.2">v2.2</see></item>
		/// </list>
		/// </remarks>

		MEAN,
	}

	/// <summary>﻿
	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Enumeration___19_0_3_68e0225_1678195766304_380006_17434">model.mtconnect.org</seealso> for more information.
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public sealed class UncertaintyTypeEnumMetaClass : IEnum
	{
		/// <summary>Constant value for <see cref="UncertaintyTypeEnumMetaClass.ReferenceId" /></summary>
		public const string REFERENCE_ID = "_19_0_3_68e0225_1678195766304_380006_17434";
		/// <summary>Constant value for <see cref="UncertaintyTypeEnumMetaClass.HelpUrl" /></summary>
		public const string HELP_URL = "https://model.mtconnect.org/#Enumeration___19_0_3_68e0225_1678195766304_380006_17434";
		/// <summary>Constant value for <see cref="UncertaintyTypeEnumMetaClass.Name" /></summary>
		public const string NAME = "UncertaintyTypeEnum";
		/// <summary>Constant value for <see cref="UncertaintyTypeEnumMetaClass.NormativeVersion" /></summary>
		public const string NORMATIVE_VERSION = "2.2";
		/// <summary>Constant value for <see cref="UncertaintyTypeEnumMetaClass.DeprecatedVersion" /></summary>
		public const string DEPRECATED_VERSION = "";
		/// <summary>Constant value for <see cref="UncertaintyTypeEnumMetaClass.Summary" /></summary>
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
		public Type Instance => typeof(UncertaintyTypeEnum);

		/// <inheritdoc />
		public string NormativeVersion => NORMATIVE_VERSION;
		
		/// <inheritdoc />
		public string DeprecatedVersion => DEPRECATED_VERSION;
		
		/// <inheritdoc />
		public string Summary => SUMMARY;
		
		/// <inheritdoc />
		public IEnumInstance[] Values => new IEnumInstance[] {
		COMBINED,
		MEAN,
		};

		private COMBINEDValue _COMBINED;
		/// <inheritdoc cref="COMBINEDValue" path="/summary" />
		public COMBINEDValue COMBINED => _COMBINED ?? (_COMBINED = new COMBINEDValue());

		/// <summary>﻿<i>combined standard uncertainty</i>.<br /><br /><br />
		/// Value for UncertaintyTypeEnum.<br/>
		/// <br/>See also <seealso cref="UncertaintyTypeEnum">UncertaintyTypeEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_2.2">v2.2</see></item>
		/// </list>
		/// </remarks>

		public sealed class COMBINEDValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="COMBINEDValue.Name" /></summary>
			public const string NAME = "COMBINED";
			/// <summary>Constant value for <see cref="COMBINEDValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "2.2";
			/// <summary>Constant value for <see cref="COMBINEDValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="COMBINEDValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;{{term(combined standard uncertainty)}}.&#10;
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
		private MEANValue _MEAN;
		/// <inheritdoc cref="MEANValue" path="/summary" />
		public MEANValue MEAN => _MEAN ?? (_MEAN = new MEANValue());

		/// <summary>﻿<i>standard uncertainty</i> using arithmetic mean or average the observations. <seealso href="https://www.google.com/search?q=JCGM 100:2008 4.2&amp;btnI=I">JCGM 100:2008 4.2</seealso><br /><br /><br />
		/// Value for UncertaintyTypeEnum.<br/>
		/// <br/>See also <seealso cref="UncertaintyTypeEnum">UncertaintyTypeEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_2.2">v2.2</see></item>
		/// </list>
		/// </remarks>

		public sealed class MEANValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="MEANValue.Name" /></summary>
			public const string NAME = "MEAN";
			/// <summary>Constant value for <see cref="MEANValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "2.2";
			/// <summary>Constant value for <see cref="MEANValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="MEANValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;{{term(standard uncertainty)}} using arithmetic mean or average the observations. {{cite(JCGM 100:2008 4.2)}}&#10;
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