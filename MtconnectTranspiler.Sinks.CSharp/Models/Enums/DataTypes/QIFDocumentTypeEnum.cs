#pragma warning disable CS1574 // XML comment has cref attribute that could not be resolved
#pragma warning disable CS1584 // XML comment has syntactically incorrect cref attribute
#pragma warning disable CS0618 // Type or member is obsolete
using System;
using System.CodeDom.Compiler;using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;

namespace Mtconnect.DataTypes
{
	/// <summary>﻿
	/// <br/> Visit <seealso href="https://model.mtconnect.org/#Enumeration___19_0_3_68e0225_1622119656767_412574_1812">model.mtconnect.org</seealso> for more information.
	/// </summary>
	/// <remarks>
	/// <list type="bullet">
	/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.8">v1.8</see></item>
	/// </list>
	/// </remarks>

	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public enum QIFDocumentTypeEnum
	{
		/// <summary>﻿
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.8">v1.8</see></item>
		/// </list>
		/// </remarks>

		MEASUREMENT_RESOURCE,
		/// <summary>﻿
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.8">v1.8</see></item>
		/// </list>
		/// </remarks>

		PLAN,
		/// <summary>﻿
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.8">v1.8</see></item>
		/// </list>
		/// </remarks>

		PRODUCT,
		/// <summary>﻿
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.8">v1.8</see></item>
		/// </list>
		/// </remarks>

		RESULTS,
		/// <summary>﻿
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.8">v1.8</see></item>
		/// </list>
		/// </remarks>

		RULES,
		/// <summary>﻿
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.8">v1.8</see></item>
		/// </list>
		/// </remarks>

		STATISTICS,
	}

	/// <summary>﻿
	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Enumeration___19_0_3_68e0225_1622119656767_412574_1812">model.mtconnect.org</seealso> for more information.
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public sealed class QIFDocumentTypeEnumMetaClass : IEnum
	{
		/// <summary>Constant value for <see cref="QIFDocumentTypeEnumMetaClass.ReferenceId" /></summary>
		public const string REFERENCE_ID = "_19_0_3_68e0225_1622119656767_412574_1812";
		/// <summary>Constant value for <see cref="QIFDocumentTypeEnumMetaClass.HelpUrl" /></summary>
		public const string HELP_URL = "https://model.mtconnect.org/#Enumeration___19_0_3_68e0225_1622119656767_412574_1812";
		/// <summary>Constant value for <see cref="QIFDocumentTypeEnumMetaClass.Name" /></summary>
		public const string NAME = "QIFDocumentTypeEnum";
		/// <summary>Constant value for <see cref="QIFDocumentTypeEnumMetaClass.NormativeVersion" /></summary>
		public const string NORMATIVE_VERSION = "1.8";
		/// <summary>Constant value for <see cref="QIFDocumentTypeEnumMetaClass.DeprecatedVersion" /></summary>
		public const string DEPRECATED_VERSION = "";
		/// <summary>Constant value for <see cref="QIFDocumentTypeEnumMetaClass.Summary" /></summary>
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
		public Type Instance => typeof(QIFDocumentTypeEnum);

		/// <inheritdoc />
		public string NormativeVersion => NORMATIVE_VERSION;
		
		/// <inheritdoc />
		public string DeprecatedVersion => DEPRECATED_VERSION;
		
		/// <inheritdoc />
		public string Summary => SUMMARY;
		
		/// <inheritdoc />
		public IEnumInstance[] Values => new IEnumInstance[] {
		MEASUREMENT_RESOURCE,
		PLAN,
		PRODUCT,
		RESULTS,
		RULES,
		STATISTICS,
		};

		private MEASUREMENT_RESOURCEValue _MEASUREMENT_RESOURCE;
		/// <inheritdoc cref="MEASUREMENT_RESOURCEValue" path="/summary" />
		public MEASUREMENT_RESOURCEValue MEASUREMENT_RESOURCE => _MEASUREMENT_RESOURCE ?? (_MEASUREMENT_RESOURCE = new MEASUREMENT_RESOURCEValue());

		/// <summary>﻿
		/// Value for QIFDocumentTypeEnum.<br/>
		/// <br/>See also <seealso cref="QIFDocumentTypeEnum">QIFDocumentTypeEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.8">v1.8</see></item>
		/// </list>
		/// </remarks>

		public sealed class MEASUREMENT_RESOURCEValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="MEASUREMENT_RESOURCEValue.Name" /></summary>
			public const string NAME = "MEASUREMENT_RESOURCE";
			/// <summary>Constant value for <see cref="MEASUREMENT_RESOURCEValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.8";
			/// <summary>Constant value for <see cref="MEASUREMENT_RESOURCEValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="MEASUREMENT_RESOURCEValue.Summary" /></summary>
			public const string SUMMARY = @"";

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
		private PLANValue _PLAN;
		/// <inheritdoc cref="PLANValue" path="/summary" />
		public PLANValue PLAN => _PLAN ?? (_PLAN = new PLANValue());

		/// <summary>﻿
		/// Value for QIFDocumentTypeEnum.<br/>
		/// <br/>See also <seealso cref="QIFDocumentTypeEnum">QIFDocumentTypeEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.8">v1.8</see></item>
		/// </list>
		/// </remarks>

		public sealed class PLANValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="PLANValue.Name" /></summary>
			public const string NAME = "PLAN";
			/// <summary>Constant value for <see cref="PLANValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.8";
			/// <summary>Constant value for <see cref="PLANValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="PLANValue.Summary" /></summary>
			public const string SUMMARY = @"";

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
		private PRODUCTValue _PRODUCT;
		/// <inheritdoc cref="PRODUCTValue" path="/summary" />
		public PRODUCTValue PRODUCT => _PRODUCT ?? (_PRODUCT = new PRODUCTValue());

		/// <summary>﻿
		/// Value for QIFDocumentTypeEnum.<br/>
		/// <br/>See also <seealso cref="QIFDocumentTypeEnum">QIFDocumentTypeEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.8">v1.8</see></item>
		/// </list>
		/// </remarks>

		public sealed class PRODUCTValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="PRODUCTValue.Name" /></summary>
			public const string NAME = "PRODUCT";
			/// <summary>Constant value for <see cref="PRODUCTValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.8";
			/// <summary>Constant value for <see cref="PRODUCTValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="PRODUCTValue.Summary" /></summary>
			public const string SUMMARY = @"";

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
		private RESULTSValue _RESULTS;
		/// <inheritdoc cref="RESULTSValue" path="/summary" />
		public RESULTSValue RESULTS => _RESULTS ?? (_RESULTS = new RESULTSValue());

		/// <summary>﻿
		/// Value for QIFDocumentTypeEnum.<br/>
		/// <br/>See also <seealso cref="QIFDocumentTypeEnum">QIFDocumentTypeEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.8">v1.8</see></item>
		/// </list>
		/// </remarks>

		public sealed class RESULTSValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="RESULTSValue.Name" /></summary>
			public const string NAME = "RESULTS";
			/// <summary>Constant value for <see cref="RESULTSValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.8";
			/// <summary>Constant value for <see cref="RESULTSValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="RESULTSValue.Summary" /></summary>
			public const string SUMMARY = @"";

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
		private RULESValue _RULES;
		/// <inheritdoc cref="RULESValue" path="/summary" />
		public RULESValue RULES => _RULES ?? (_RULES = new RULESValue());

		/// <summary>﻿
		/// Value for QIFDocumentTypeEnum.<br/>
		/// <br/>See also <seealso cref="QIFDocumentTypeEnum">QIFDocumentTypeEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.8">v1.8</see></item>
		/// </list>
		/// </remarks>

		public sealed class RULESValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="RULESValue.Name" /></summary>
			public const string NAME = "RULES";
			/// <summary>Constant value for <see cref="RULESValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.8";
			/// <summary>Constant value for <see cref="RULESValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="RULESValue.Summary" /></summary>
			public const string SUMMARY = @"";

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
		private STATISTICSValue _STATISTICS;
		/// <inheritdoc cref="STATISTICSValue" path="/summary" />
		public STATISTICSValue STATISTICS => _STATISTICS ?? (_STATISTICS = new STATISTICSValue());

		/// <summary>﻿
		/// Value for QIFDocumentTypeEnum.<br/>
		/// <br/>See also <seealso cref="QIFDocumentTypeEnum">QIFDocumentTypeEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.8">v1.8</see></item>
		/// </list>
		/// </remarks>

		public sealed class STATISTICSValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="STATISTICSValue.Name" /></summary>
			public const string NAME = "STATISTICS";
			/// <summary>Constant value for <see cref="STATISTICSValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.8";
			/// <summary>Constant value for <see cref="STATISTICSValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="STATISTICSValue.Summary" /></summary>
			public const string SUMMARY = @"";

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