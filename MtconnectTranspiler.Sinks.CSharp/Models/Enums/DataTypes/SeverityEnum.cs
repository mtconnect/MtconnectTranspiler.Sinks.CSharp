#pragma warning disable CS1574 // XML comment has cref attribute that could not be resolved
#pragma warning disable CS1584 // XML comment has syntactically incorrect cref attribute
#pragma warning disable CS0618 // Type or member is obsolete
using System;
using System.CodeDom.Compiler;using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;

namespace Mtconnect.DataTypes
{
	/// <summary>﻿
	/// <br/> Visit <seealso href="https://model.mtconnect.org/#Enumeration___2024x_68e0225_1744802298969_10873_23682">model.mtconnect.org</seealso> for more information.
	/// </summary>
	/// <remarks>
	/// <list type="bullet">
	/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_2.6">v2.6</see></item>
	/// </list>
	/// </remarks>

	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.8.0.0")]
	public enum SeverityEnum
	{
		/// <summary>﻿exception violates compliance with the MTConnect Standard and validation can no longer continue.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_2.6">v2.6</see></item>
		/// </list>
		/// </remarks>

		FATAL,
		/// <summary>﻿exception violates compliance with the MTConnect Standard.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_2.6">v2.6</see></item>
		/// </list>
		/// </remarks>

		ERROR,
		/// <summary>﻿exception <b>MAY</b> violate compliance with the MTConnect Standard.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_2.6">v2.6</see></item>
		/// </list>
		/// </remarks>

		WARNING,
		/// <summary>﻿exception is considered informative.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_2.6">v2.6</see></item>
		/// </list>
		/// </remarks>

		INFO,
	}

	/// <summary>﻿
	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Enumeration___2024x_68e0225_1744802298969_10873_23682">model.mtconnect.org</seealso> for more information.
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.8.0.0")]
	public sealed class SeverityEnumMetaClass : IEnum
	{
		/// <summary>Constant value for <see cref="SeverityEnumMetaClass.ReferenceId" /></summary>
		public const string REFERENCE_ID = "_2024x_68e0225_1744802298969_10873_23682";
		/// <summary>Constant value for <see cref="SeverityEnumMetaClass.HelpUrl" /></summary>
		public const string HELP_URL = "https://model.mtconnect.org/#Enumeration___2024x_68e0225_1744802298969_10873_23682";
		/// <summary>Constant value for <see cref="SeverityEnumMetaClass.Name" /></summary>
		public const string NAME = "SeverityEnum";
		/// <summary>Constant value for <see cref="SeverityEnumMetaClass.NormativeVersion" /></summary>
		public const string NORMATIVE_VERSION = "2.6";
		/// <summary>Constant value for <see cref="SeverityEnumMetaClass.DeprecatedVersion" /></summary>
		public const string DEPRECATED_VERSION = "";
		/// <summary>Constant value for <see cref="SeverityEnumMetaClass.Summary" /></summary>
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
		public Type Instance => typeof(SeverityEnum);

		/// <inheritdoc />
		public string NormativeVersion => NORMATIVE_VERSION;
		
		/// <inheritdoc />
		public string DeprecatedVersion => DEPRECATED_VERSION;
		
		/// <inheritdoc />
		public string Summary => SUMMARY;
		
		/// <inheritdoc />
		public IEnumInstance[] Values => new IEnumInstance[] {
		FATAL,
		ERROR,
		WARNING,
		INFO,
		};

		private FATALValue _FATAL;
		/// <inheritdoc cref="FATALValue" path="/summary" />
		public FATALValue FATAL => _FATAL ?? (_FATAL = new FATALValue());

		/// <summary>﻿exception violates compliance with the MTConnect Standard and validation can no longer continue.<br /><br /><br />
		/// Value for SeverityEnum.<br/>
		/// <br/>See also <seealso cref="SeverityEnum">SeverityEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_2.6">v2.6</see></item>
		/// </list>
		/// </remarks>

		public sealed class FATALValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="FATALValue.Name" /></summary>
			public const string NAME = "FATAL";
			/// <summary>Constant value for <see cref="FATALValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "2.6";
			/// <summary>Constant value for <see cref="FATALValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="FATALValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;exception violates compliance with the MTConnect Standard and validation can no longer continue.&#10;
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
		private ERRORValue _ERROR;
		/// <inheritdoc cref="ERRORValue" path="/summary" />
		public ERRORValue ERROR => _ERROR ?? (_ERROR = new ERRORValue());

		/// <summary>﻿exception violates compliance with the MTConnect Standard.<br /><br /><br />
		/// Value for SeverityEnum.<br/>
		/// <br/>See also <seealso cref="SeverityEnum">SeverityEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_2.6">v2.6</see></item>
		/// </list>
		/// </remarks>

		public sealed class ERRORValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="ERRORValue.Name" /></summary>
			public const string NAME = "ERROR";
			/// <summary>Constant value for <see cref="ERRORValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "2.6";
			/// <summary>Constant value for <see cref="ERRORValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="ERRORValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;exception violates compliance with the MTConnect Standard.&#10;
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
		private WARNINGValue _WARNING;
		/// <inheritdoc cref="WARNINGValue" path="/summary" />
		public WARNINGValue WARNING => _WARNING ?? (_WARNING = new WARNINGValue());

		/// <summary>﻿exception <b>MAY</b> violate compliance with the MTConnect Standard.<br /><br /><br />
		/// Value for SeverityEnum.<br/>
		/// <br/>See also <seealso cref="SeverityEnum">SeverityEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_2.6">v2.6</see></item>
		/// </list>
		/// </remarks>

		public sealed class WARNINGValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="WARNINGValue.Name" /></summary>
			public const string NAME = "WARNING";
			/// <summary>Constant value for <see cref="WARNINGValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "2.6";
			/// <summary>Constant value for <see cref="WARNINGValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="WARNINGValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;exception **MAY** violate compliance with the MTConnect Standard.&#10;
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
		private INFOValue _INFO;
		/// <inheritdoc cref="INFOValue" path="/summary" />
		public INFOValue INFO => _INFO ?? (_INFO = new INFOValue());

		/// <summary>﻿exception is considered informative.<br /><br /><br />
		/// Value for SeverityEnum.<br/>
		/// <br/>See also <seealso cref="SeverityEnum">SeverityEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_2.6">v2.6</see></item>
		/// </list>
		/// </remarks>

		public sealed class INFOValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="INFOValue.Name" /></summary>
			public const string NAME = "INFO";
			/// <summary>Constant value for <see cref="INFOValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "2.6";
			/// <summary>Constant value for <see cref="INFOValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="INFOValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;exception is considered informative.&#10;
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
