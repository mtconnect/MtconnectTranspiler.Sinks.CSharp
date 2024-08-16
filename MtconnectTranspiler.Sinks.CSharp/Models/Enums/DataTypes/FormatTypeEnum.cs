using System;
using System.CodeDom.Compiler;using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;

namespace Mtconnect.DataTypes
{
	/// <summary>
	/// View in the MTConnect Model browser <seealso href="https://model.mtconnect.org/#Enumeration___19_0_3_91b028d_1579537199908_332626_9197">model.mtconnect.org</seealso>
	﻿
	/// </summary>
	/// <remarks>
	/// <list type="bullet">
	/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.2">v1.2</see></item>
	/// </list>
	/// </remarks>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public enum FormatTypeEnum
	{
		/// <summary>
		﻿/// document will confirm to the ISO 10303 Part 21 standard.<br /><br/><br />

		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.2">v1.2</see></item>
		/// </list>
		/// </remarks>
		EXPRESS,
		/// <summary>
		﻿/// document will be a text representation of the tool data.<br /><br/><br />

		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.2">v1.2</see></item>
		/// </list>
		/// </remarks>
		TEXT,
		/// <summary>
		﻿/// document will be provided in an undefined format.<br/><br />

		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.2">v1.2</see></item>
		/// </list>
		/// </remarks>
		UNDEFINED,
		/// <summary>
		﻿/// default value for the definition. The content will be an <i>XML</i> document.<br/><br />

		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.2">v1.2</see></item>
		/// </list>
		/// </remarks>
		XML,
	}

	/// <summary>
	/// View in the MTConnect Model browser <seealso href="https://model.mtconnect.org/#Enumeration___19_0_3_91b028d_1579537199908_332626_9197">model.mtconnect.org</seealso>
	﻿
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public sealed class FormatTypeEnumMetaClass : IEnum
	{
		/// <inheritdoc />
		public string Name => "FormatTypeEnum";
		
		/// <inheritdoc />
		public Type DataType => null;
		
		public Type Instance => typeof(FormatTypeEnum);

		/// <inheritdoc />
		public string NormativeVersion => "1.2";
		
		/// <inheritdoc />
		public string DeprecatedVersion => "";
		
		/// <inheritdoc />
		public string Summary => @"";
		
		/// <inheritdoc />
		public IEnumInstance[] Values => new IEnumInstance[] {
		EXPRESS,
		TEXT,
		UNDEFINED,
		XML,
		};

		private EXPRESSValue _EXPRESS;
		/// <summary>
		﻿/// document will confirm to the ISO 10303 Part 21 standard.<br /><br/><br />

		/// </summary>
		public EXPRESSValue EXPRESS => _EXPRESS ?? (_EXPRESS = new EXPRESSValue());

		/// <summary>
		﻿/// document will confirm to the ISO 10303 Part 21 standard.<br /><br/><br />

		/// </summary>
		public sealed class EXPRESSValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "EXPRESS";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.2";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"&#10;&#10;&#10;document will confirm to the ISO 10303 Part 21 standard.&#10;
";
		}
		private TEXTValue _TEXT;
		/// <summary>
		﻿/// document will be a text representation of the tool data.<br /><br/><br />

		/// </summary>
		public TEXTValue TEXT => _TEXT ?? (_TEXT = new TEXTValue());

		/// <summary>
		﻿/// document will be a text representation of the tool data.<br /><br/><br />

		/// </summary>
		public sealed class TEXTValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "TEXT";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.2";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"&#10;&#10;&#10;document will be a text representation of the tool data.&#10;
";
		}
		private UNDEFINEDValue _UNDEFINED;
		/// <summary>
		﻿/// document will be provided in an undefined format.<br/><br />

		/// </summary>
		public UNDEFINEDValue UNDEFINED => _UNDEFINED ?? (_UNDEFINED = new UNDEFINEDValue());

		/// <summary>
		﻿/// document will be provided in an undefined format.<br/><br />

		/// </summary>
		public sealed class UNDEFINEDValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "UNDEFINED";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.2";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"&#10;&#10;&#10;document will be provided in an undefined format.&#10;
";
		}
		private XMLValue _XML;
		/// <summary>
		﻿/// default value for the definition. The content will be an <i>XML</i> document.<br/><br />

		/// </summary>
		public XMLValue XML => _XML ?? (_XML = new XMLValue());

		/// <summary>
		﻿/// default value for the definition. The content will be an <i>XML</i> document.<br/><br />

		/// </summary>
		public sealed class XMLValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "XML";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.2";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"&#10;&#10;&#10;default value for the definition. The content will be an {{term(XML)}} document.&#10;
";
		}
	}
}