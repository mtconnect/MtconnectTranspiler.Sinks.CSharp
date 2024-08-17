#pragma warning disable CS1574 // XML comment has cref attribute that could not be resolved
#pragma warning disable CS1584 // XML comment has syntactically incorrect cref attribute
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
		/// <inheritdoc />
		public string Name => "QIFDocumentTypeEnum";
		
		/// <inheritdoc />
		public Type DataType => null;
		
		/// <inheritdoc />
		public Type Instance => typeof(QIFDocumentTypeEnum);

		/// <inheritdoc />
		public string NormativeVersion => "1.8";
		
		/// <inheritdoc />
		public string DeprecatedVersion => "";
		
		/// <inheritdoc />
		public string Summary => @"";
		
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
		public sealed class MEASUREMENT_RESOURCEValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "MEASUREMENT_RESOURCE";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.8";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"";
		}
		private PLANValue _PLAN;
		/// <inheritdoc cref="PLANValue" path="/summary" />
		public PLANValue PLAN => _PLAN ?? (_PLAN = new PLANValue());

		/// <summary>﻿
		/// Value for QIFDocumentTypeEnum.<br/>
		/// <br/>See also <seealso cref="QIFDocumentTypeEnum">QIFDocumentTypeEnum</seealso>
		/// </summary>
		public sealed class PLANValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "PLAN";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.8";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"";
		}
		private PRODUCTValue _PRODUCT;
		/// <inheritdoc cref="PRODUCTValue" path="/summary" />
		public PRODUCTValue PRODUCT => _PRODUCT ?? (_PRODUCT = new PRODUCTValue());

		/// <summary>﻿
		/// Value for QIFDocumentTypeEnum.<br/>
		/// <br/>See also <seealso cref="QIFDocumentTypeEnum">QIFDocumentTypeEnum</seealso>
		/// </summary>
		public sealed class PRODUCTValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "PRODUCT";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.8";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"";
		}
		private RESULTSValue _RESULTS;
		/// <inheritdoc cref="RESULTSValue" path="/summary" />
		public RESULTSValue RESULTS => _RESULTS ?? (_RESULTS = new RESULTSValue());

		/// <summary>﻿
		/// Value for QIFDocumentTypeEnum.<br/>
		/// <br/>See also <seealso cref="QIFDocumentTypeEnum">QIFDocumentTypeEnum</seealso>
		/// </summary>
		public sealed class RESULTSValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "RESULTS";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.8";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"";
		}
		private RULESValue _RULES;
		/// <inheritdoc cref="RULESValue" path="/summary" />
		public RULESValue RULES => _RULES ?? (_RULES = new RULESValue());

		/// <summary>﻿
		/// Value for QIFDocumentTypeEnum.<br/>
		/// <br/>See also <seealso cref="QIFDocumentTypeEnum">QIFDocumentTypeEnum</seealso>
		/// </summary>
		public sealed class RULESValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "RULES";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.8";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"";
		}
		private STATISTICSValue _STATISTICS;
		/// <inheritdoc cref="STATISTICSValue" path="/summary" />
		public STATISTICSValue STATISTICS => _STATISTICS ?? (_STATISTICS = new STATISTICSValue());

		/// <summary>﻿
		/// Value for QIFDocumentTypeEnum.<br/>
		/// <br/>See also <seealso cref="QIFDocumentTypeEnum">QIFDocumentTypeEnum</seealso>
		/// </summary>
		public sealed class STATISTICSValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "STATISTICS";
			
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