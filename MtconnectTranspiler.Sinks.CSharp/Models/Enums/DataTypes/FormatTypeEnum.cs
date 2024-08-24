#pragma warning disable CS1574 // XML comment has cref attribute that could not be resolved
#pragma warning disable CS1584 // XML comment has syntactically incorrect cref attribute
#pragma warning disable CS0618 // Type or member is obsolete
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
		/// <summary>Constant value for <see cref="FormatTypeEnumMetaClass.ReferenceId" /></summary>
		public const string REFERENCE_ID = "_19_0_3_91b028d_1579537199908_332626_9197";
		/// <summary>Constant value for <see cref="FormatTypeEnumMetaClass.HelpUrl" /></summary>
		public const string HELP_URL = "https://model.mtconnect.org/#Enumeration___19_0_3_91b028d_1579537199908_332626_9197";
		/// <summary>Constant value for <see cref="FormatTypeEnumMetaClass.Name" /></summary>
		public const string NAME = "FormatTypeEnum";
		/// <summary>Constant value for <see cref="FormatTypeEnumMetaClass.NormativeVersion" /></summary>
		public const string NORMATIVE_VERSION = "1.2";
		/// <summary>Constant value for <see cref="FormatTypeEnumMetaClass.DeprecatedVersion" /></summary>
		public const string DEPRECATED_VERSION = "";
		/// <summary>Constant value for <see cref="FormatTypeEnumMetaClass.Summary" /></summary>
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
		public Type Instance => typeof(FormatTypeEnum);

		/// <inheritdoc />
		public string NormativeVersion => NORMATIVE_VERSION;
		
		/// <inheritdoc />
		public string DeprecatedVersion => DEPRECATED_VERSION;
		
		/// <inheritdoc />
		public string Summary => SUMMARY;
		
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
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.2">v1.2</see></item>
		/// </list>
		/// </remarks>

		public sealed class EXPRESSValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="EXPRESSValue.Name" /></summary>
			public const string NAME = "EXPRESS";
			/// <summary>Constant value for <see cref="EXPRESSValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.2";
			/// <summary>Constant value for <see cref="EXPRESSValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="EXPRESSValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;document will confirm to the ISO 10303 Part 21 standard.&#10;
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
		private TEXTValue _TEXT;
		/// <inheritdoc cref="TEXTValue" path="/summary" />
		public TEXTValue TEXT => _TEXT ?? (_TEXT = new TEXTValue());

		/// <summary>﻿document will be a text representation of the tool data.<br /><br /><br /><br />
		/// Value for FormatTypeEnum.<br/>
		/// <br/>See also <seealso cref="FormatTypeEnum">FormatTypeEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.2">v1.2</see></item>
		/// </list>
		/// </remarks>

		public sealed class TEXTValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="TEXTValue.Name" /></summary>
			public const string NAME = "TEXT";
			/// <summary>Constant value for <see cref="TEXTValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.2";
			/// <summary>Constant value for <see cref="TEXTValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="TEXTValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;document will be a text representation of the tool data.&#10;
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

		/// <summary>﻿document will be provided in an undefined format.<br /><br /><br />
		/// Value for FormatTypeEnum.<br/>
		/// <br/>See also <seealso cref="FormatTypeEnum">FormatTypeEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.2">v1.2</see></item>
		/// </list>
		/// </remarks>

		public sealed class UNDEFINEDValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="UNDEFINEDValue.Name" /></summary>
			public const string NAME = "UNDEFINED";
			/// <summary>Constant value for <see cref="UNDEFINEDValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.2";
			/// <summary>Constant value for <see cref="UNDEFINEDValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="UNDEFINEDValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;document will be provided in an undefined format.&#10;
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
		private XMLValue _XML;
		/// <inheritdoc cref="XMLValue" path="/summary" />
		public XMLValue XML => _XML ?? (_XML = new XMLValue());

		/// <summary>﻿default value for the definition. The content will be an <i>XML</i> document.<br /><br /><br />
		/// Value for FormatTypeEnum.<br/>
		/// <br/>See also <seealso cref="FormatTypeEnum">FormatTypeEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.2">v1.2</see></item>
		/// </list>
		/// </remarks>

		public sealed class XMLValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="XMLValue.Name" /></summary>
			public const string NAME = "XML";
			/// <summary>Constant value for <see cref="XMLValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.2";
			/// <summary>Constant value for <see cref="XMLValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="XMLValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;default value for the definition. The content will be an {{term(XML)}} document.&#10;
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