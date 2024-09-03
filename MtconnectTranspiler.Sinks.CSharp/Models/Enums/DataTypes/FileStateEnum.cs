#pragma warning disable CS1574 // XML comment has cref attribute that could not be resolved
#pragma warning disable CS1584 // XML comment has syntactically incorrect cref attribute
#pragma warning disable CS0618 // Type or member is obsolete
using System;
using System.CodeDom.Compiler;using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;

namespace Mtconnect.DataTypes
{
	/// <summary>﻿
	/// <br/> Visit <seealso href="https://model.mtconnect.org/#Enumeration___19_0_3_68e0225_1605276722719_257725_310">model.mtconnect.org</seealso> for more information.
	/// </summary>
	/// <remarks>
	/// <list type="bullet">
	/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.7">v1.7</see></item>
	/// </list>
	/// </remarks>

	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public enum FileStateEnum
	{
		/// <summary>﻿used for processes other than production or otherwise defined.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.7">v1.7</see></item>
		/// </list>
		/// </remarks>

		EXPERIMENTAL,
		/// <summary>﻿used for production processes.<br /><br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.7">v1.7</see></item>
		/// </list>
		/// </remarks>

		PRODUCTION,
		/// <summary>﻿content is modified from <c>PRODUCTION</c> or <c>EXPERIMENTAL</c>.<br /><br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.7">v1.7</see></item>
		/// </list>
		/// </remarks>

		REVISION,
	}

	/// <summary>﻿
	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Enumeration___19_0_3_68e0225_1605276722719_257725_310">model.mtconnect.org</seealso> for more information.
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public sealed class FileStateEnumMetaClass : IEnum
	{
		/// <summary>Constant value for <see cref="FileStateEnumMetaClass.ReferenceId" /></summary>
		public const string REFERENCE_ID = "_19_0_3_68e0225_1605276722719_257725_310";
		/// <summary>Constant value for <see cref="FileStateEnumMetaClass.HelpUrl" /></summary>
		public const string HELP_URL = "https://model.mtconnect.org/#Enumeration___19_0_3_68e0225_1605276722719_257725_310";
		/// <summary>Constant value for <see cref="FileStateEnumMetaClass.Name" /></summary>
		public const string NAME = "FileStateEnum";
		/// <summary>Constant value for <see cref="FileStateEnumMetaClass.NormativeVersion" /></summary>
		public const string NORMATIVE_VERSION = "1.7";
		/// <summary>Constant value for <see cref="FileStateEnumMetaClass.DeprecatedVersion" /></summary>
		public const string DEPRECATED_VERSION = "";
		/// <summary>Constant value for <see cref="FileStateEnumMetaClass.Summary" /></summary>
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
		public Type Instance => typeof(FileStateEnum);

		/// <inheritdoc />
		public string NormativeVersion => NORMATIVE_VERSION;
		
		/// <inheritdoc />
		public string DeprecatedVersion => DEPRECATED_VERSION;
		
		/// <inheritdoc />
		public string Summary => SUMMARY;
		
		/// <inheritdoc />
		public IEnumInstance[] Values => new IEnumInstance[] {
		EXPERIMENTAL,
		PRODUCTION,
		REVISION,
		};

		private EXPERIMENTALValue _EXPERIMENTAL;
		/// <inheritdoc cref="EXPERIMENTALValue" path="/summary" />
		public EXPERIMENTALValue EXPERIMENTAL => _EXPERIMENTAL ?? (_EXPERIMENTAL = new EXPERIMENTALValue());

		/// <summary>﻿used for processes other than production or otherwise defined.<br /><br /><br />
		/// Value for FileStateEnum.<br/>
		/// <br/>See also <seealso cref="FileStateEnum">FileStateEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.7">v1.7</see></item>
		/// </list>
		/// </remarks>

		public sealed class EXPERIMENTALValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="EXPERIMENTALValue.Name" /></summary>
			public const string NAME = "EXPERIMENTAL";
			/// <summary>Constant value for <see cref="EXPERIMENTALValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.7";
			/// <summary>Constant value for <see cref="EXPERIMENTALValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="EXPERIMENTALValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;used for processes other than production or otherwise defined.&#10;
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
		private PRODUCTIONValue _PRODUCTION;
		/// <inheritdoc cref="PRODUCTIONValue" path="/summary" />
		public PRODUCTIONValue PRODUCTION => _PRODUCTION ?? (_PRODUCTION = new PRODUCTIONValue());

		/// <summary>﻿used for production processes.<br /><br /><br /><br />
		/// Value for FileStateEnum.<br/>
		/// <br/>See also <seealso cref="FileStateEnum">FileStateEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.7">v1.7</see></item>
		/// </list>
		/// </remarks>

		public sealed class PRODUCTIONValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="PRODUCTIONValue.Name" /></summary>
			public const string NAME = "PRODUCTION";
			/// <summary>Constant value for <see cref="PRODUCTIONValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.7";
			/// <summary>Constant value for <see cref="PRODUCTIONValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="PRODUCTIONValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;used for production processes.&#10;
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
		private REVISIONValue _REVISION;
		/// <inheritdoc cref="REVISIONValue" path="/summary" />
		public REVISIONValue REVISION => _REVISION ?? (_REVISION = new REVISIONValue());

		/// <summary>﻿content is modified from <c>PRODUCTION</c> or <c>EXPERIMENTAL</c>.<br /><br /><br /><br />
		/// Value for FileStateEnum.<br/>
		/// <br/>See also <seealso cref="FileStateEnum">FileStateEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.7">v1.7</see></item>
		/// </list>
		/// </remarks>

		public sealed class REVISIONValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="REVISIONValue.Name" /></summary>
			public const string NAME = "REVISION";
			/// <summary>Constant value for <see cref="REVISIONValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.7";
			/// <summary>Constant value for <see cref="REVISIONValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="REVISIONValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;content is modified from `PRODUCTION` or `EXPERIMENTAL`.&#10;
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