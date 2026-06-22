#pragma warning disable CS1574 // XML comment has cref attribute that could not be resolved
#pragma warning disable CS1584 // XML comment has syntactically incorrect cref attribute
#pragma warning disable CS0618 // Type or member is obsolete
using System;
using System.CodeDom.Compiler;using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;

namespace Mtconnect.DataTypes
{
	/// <summary>﻿
	/// <br/> Visit <seealso href="https://model.mtconnect.org/#Enumeration___2024x_3_3870182_1764601806417_374523_38">model.mtconnect.org</seealso> for more information.
	/// </summary>
	/// <remarks>
	/// <list type="bullet">
	/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_2.7">v2.7</see></item>
	/// </list>
	/// </remarks>

	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.8.0.0")]
	public enum PartIdentifierEnum
	{
		/// <summary>﻿unique serialized part identifier.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_2.7">v2.7</see></item>
		/// </list>
		/// </remarks>

		UNIQUE_IDENTIFIER,
		/// <summary>﻿identifier for a group of parts or a piece of raw material that will be transformed into multiple parts<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_2.7">v2.7</see></item>
		/// </list>
		/// </remarks>

		GROUP_IDENTIFIER,
	}

	/// <summary>﻿
	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Enumeration___2024x_3_3870182_1764601806417_374523_38">model.mtconnect.org</seealso> for more information.
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.8.0.0")]
	public sealed class PartIdentifierEnumMetaClass : IEnum
	{
		/// <summary>Constant value for <see cref="PartIdentifierEnumMetaClass.ReferenceId" /></summary>
		public const string REFERENCE_ID = "_2024x_3_3870182_1764601806417_374523_38";
		/// <summary>Constant value for <see cref="PartIdentifierEnumMetaClass.HelpUrl" /></summary>
		public const string HELP_URL = "https://model.mtconnect.org/#Enumeration___2024x_3_3870182_1764601806417_374523_38";
		/// <summary>Constant value for <see cref="PartIdentifierEnumMetaClass.Name" /></summary>
		public const string NAME = "PartIdentifierEnum";
		/// <summary>Constant value for <see cref="PartIdentifierEnumMetaClass.NormativeVersion" /></summary>
		public const string NORMATIVE_VERSION = "2.7";
		/// <summary>Constant value for <see cref="PartIdentifierEnumMetaClass.DeprecatedVersion" /></summary>
		public const string DEPRECATED_VERSION = "";
		/// <summary>Constant value for <see cref="PartIdentifierEnumMetaClass.Summary" /></summary>
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
		public Type Instance => typeof(PartIdentifierEnum);

		/// <inheritdoc />
		public string NormativeVersion => NORMATIVE_VERSION;
		
		/// <inheritdoc />
		public string DeprecatedVersion => DEPRECATED_VERSION;
		
		/// <inheritdoc />
		public string Summary => SUMMARY;
		
		/// <inheritdoc />
		public IEnumInstance[] Values => new IEnumInstance[] {
		UNIQUE_IDENTIFIER,
		GROUP_IDENTIFIER,
		};

		private UNIQUE_IDENTIFIERValue _UNIQUE_IDENTIFIER;
		/// <inheritdoc cref="UNIQUE_IDENTIFIERValue" path="/summary" />
		public UNIQUE_IDENTIFIERValue UNIQUE_IDENTIFIER => _UNIQUE_IDENTIFIER ?? (_UNIQUE_IDENTIFIER = new UNIQUE_IDENTIFIERValue());

		/// <summary>﻿unique serialized part identifier.<br /><br /><br />
		/// Value for PartIdentifierEnum.<br/>
		/// <br/>See also <seealso cref="PartIdentifierEnum">PartIdentifierEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_2.7">v2.7</see></item>
		/// </list>
		/// </remarks>

		public sealed class UNIQUE_IDENTIFIERValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="UNIQUE_IDENTIFIERValue.Name" /></summary>
			public const string NAME = "UNIQUE_IDENTIFIER";
			/// <summary>Constant value for <see cref="UNIQUE_IDENTIFIERValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "2.7";
			/// <summary>Constant value for <see cref="UNIQUE_IDENTIFIERValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="UNIQUE_IDENTIFIERValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;unique serialized part identifier.&#10;
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
		private GROUP_IDENTIFIERValue _GROUP_IDENTIFIER;
		/// <inheritdoc cref="GROUP_IDENTIFIERValue" path="/summary" />
		public GROUP_IDENTIFIERValue GROUP_IDENTIFIER => _GROUP_IDENTIFIER ?? (_GROUP_IDENTIFIER = new GROUP_IDENTIFIERValue());

		/// <summary>﻿identifier for a group of parts or a piece of raw material that will be transformed into multiple parts<br /><br /><br />
		/// Value for PartIdentifierEnum.<br/>
		/// <br/>See also <seealso cref="PartIdentifierEnum">PartIdentifierEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_2.7">v2.7</see></item>
		/// </list>
		/// </remarks>

		public sealed class GROUP_IDENTIFIERValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="GROUP_IDENTIFIERValue.Name" /></summary>
			public const string NAME = "GROUP_IDENTIFIER";
			/// <summary>Constant value for <see cref="GROUP_IDENTIFIERValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "2.7";
			/// <summary>Constant value for <see cref="GROUP_IDENTIFIERValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="GROUP_IDENTIFIERValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;identifier for a group of parts or a piece of raw material that will be transformed into multiple parts&#10;
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
