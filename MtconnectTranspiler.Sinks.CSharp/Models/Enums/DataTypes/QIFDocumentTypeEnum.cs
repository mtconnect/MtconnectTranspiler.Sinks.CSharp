using System;
using System.CodeDom.Compiler;using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;

namespace Mtconnect.DataTypes
{
	/// <summary>
	/// View in the MTConnect Model browser <seealso href="https://model.mtconnect.org/#Enumeration___19_0_3_68e0225_1622119656767_412574_1812">model.mtconnect.org</seealso>
	﻿
	/// </summary>
	/// <remarks>
	/// <list type="bullet">
	/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.8">v1.8</see></item>
	/// </list>
	/// </remarks>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public enum QIFDocumentTypeEnum
	{
		/// <summary>
		﻿
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.8">v1.8</see></item>
		/// </list>
		/// </remarks>
		MEASUREMENT_RESOURCE,
		/// <summary>
		﻿
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.8">v1.8</see></item>
		/// </list>
		/// </remarks>
		PLAN,
		/// <summary>
		﻿
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.8">v1.8</see></item>
		/// </list>
		/// </remarks>
		PRODUCT,
		/// <summary>
		﻿
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.8">v1.8</see></item>
		/// </list>
		/// </remarks>
		RESULTS,
		/// <summary>
		﻿
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.8">v1.8</see></item>
		/// </list>
		/// </remarks>
		RULES,
		/// <summary>
		﻿
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.8">v1.8</see></item>
		/// </list>
		/// </remarks>
		STATISTICS,
	}

	/// <summary>
	/// View in the MTConnect Model browser <seealso href="https://model.mtconnect.org/#Enumeration___19_0_3_68e0225_1622119656767_412574_1812">model.mtconnect.org</seealso>
	﻿
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public sealed class QIFDocumentTypeEnumMetaClass : IEnum
	{
		/// <inheritdoc />
		public string Name => "QIFDocumentTypeEnum";
		
		/// <inheritdoc />
		public Type DataType => null;
		
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
		public MEASUREMENT_RESOURCEValue MEASUREMENT_RESOURCE => _MEASUREMENT_RESOURCE ?? (_MEASUREMENT_RESOURCE = new MEASUREMENT_RESOURCEValue());

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
		public PLANValue PLAN => _PLAN ?? (_PLAN = new PLANValue());

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
		public PRODUCTValue PRODUCT => _PRODUCT ?? (_PRODUCT = new PRODUCTValue());

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
		public RESULTSValue RESULTS => _RESULTS ?? (_RESULTS = new RESULTSValue());

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
		public RULESValue RULES => _RULES ?? (_RULES = new RULESValue());

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
		public STATISTICSValue STATISTICS => _STATISTICS ?? (_STATISTICS = new STATISTICSValue());

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