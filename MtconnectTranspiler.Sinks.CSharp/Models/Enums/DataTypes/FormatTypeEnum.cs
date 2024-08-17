#pragma warning disable CS1574 // XML comment has cref attribute that could not be resolved
#pragma warning disable CS1584 // XML comment has syntactically incorrect cref attribute
using System;
using System.CodeDom.Compiler;using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;

namespace Mtconnect.DataTypes
{
	/// <summary>﻿
	/// <br/> Visit <seealso href="https://model.mtconnect.org/#Enumeration___19_0_3_91b028d_1579537199908_332626_9197">model.mtconnect.org</seealso> for more information.
	/// </summary>
	/// <remarks>
	/// <list type="bullet">
	/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.2">v1.2</see></item>
	/// </list>
	/// </remarks>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public enum FormatTypeEnum
	{
		/// <summary>﻿document will confirm to the ISO 10303 Part 21 standard.<br /><br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.2">v1.2</see></item>
		/// </list>
		/// </remarks>
		EXPRESS,
		/// <summary>﻿document will be a text representation of the tool data.<br /><br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.2">v1.2</see></item>
		/// </list>
		/// </remarks>
		TEXT,
		/// <summary>﻿document will be provided in an undefined format.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.2">v1.2</see></item>
		/// </list>
		/// </remarks>
		UNDEFINED,
		/// <summary>﻿default value for the definition. The content will be an <i>XML</i> document.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.2">v1.2</see></item>
		/// </list>
		/// </remarks>
		XML,
	}

	/// <summary>﻿
	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Enumeration___19_0_3_91b028d_1579537199908_332626_9197">model.mtconnect.org</seealso> for more information.
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public sealed class FormatTypeEnumMetaClass : IEnum
	{
		/// <inheritdoc />
		public string Name => "FormatTypeEnum";
		
		/// <inheritdoc />
		public Type DataType => null;
		
		/// <inheritdoc />
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
		/// <inheritdoc cref="EXPRESSValue" path="/summary" />
		public EXPRESSValue EXPRESS => _EXPRESS ?? (_EXPRESS = new EXPRESSValue());

		/// <summary>﻿document will confirm to the ISO 10303 Part 21 standard.<br /><br /><br /><br />
		/// Value for FormatTypeEnum.<br/>
		/// <br/>See also <seealso cref="FormatTypeEnum">FormatTypeEnum</seealso>
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
		/// <inheritdoc cref="TEXTValue" path="/summary" />
		public TEXTValue TEXT => _TEXT ?? (_TEXT = new TEXTValue());

		/// <summary>﻿document will be a text representation of the tool data.<br /><br /><br /><br />
		/// Value for FormatTypeEnum.<br/>
		/// <br/>See also <seealso cref="FormatTypeEnum">FormatTypeEnum</seealso>
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
		/// <inheritdoc cref="UNDEFINEDValue" path="/summary" />
		public UNDEFINEDValue UNDEFINED => _UNDEFINED ?? (_UNDEFINED = new UNDEFINEDValue());

		/// <summary>﻿document will be provided in an undefined format.<br /><br /><br />
		/// Value for FormatTypeEnum.<br/>
		/// <br/>See also <seealso cref="FormatTypeEnum">FormatTypeEnum</seealso>
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
		/// <inheritdoc cref="XMLValue" path="/summary" />
		public XMLValue XML => _XML ?? (_XML = new XMLValue());

		/// <summary>﻿default value for the definition. The content will be an <i>XML</i> document.<br /><br /><br />
		/// Value for FormatTypeEnum.<br/>
		/// <br/>See also <seealso cref="FormatTypeEnum">FormatTypeEnum</seealso>
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