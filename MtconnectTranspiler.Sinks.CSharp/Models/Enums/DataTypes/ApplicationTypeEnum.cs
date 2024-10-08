#pragma warning disable CS1574 // XML comment has cref attribute that could not be resolved
#pragma warning disable CS1584 // XML comment has syntactically incorrect cref attribute
#pragma warning disable CS0618 // Type or member is obsolete
using System;
using System.CodeDom.Compiler;using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;

namespace Mtconnect.DataTypes
{
	/// <summary>﻿
	/// <br/> Visit <seealso href="https://model.mtconnect.org/#Enumeration___19_0_3_45f01b9_1589825656758_905757_799">model.mtconnect.org</seealso> for more information.
	/// </summary>
	/// <remarks>
	/// <list type="bullet">
	/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.7">v1.7</see></item>
	/// </list>
	/// </remarks>

	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public enum ApplicationTypeEnum
	{
		/// <summary>﻿computer aided design files or drawings.<br /><br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.7">v1.7</see></item>
		/// </list>
		/// </remarks>

		DESIGN,
		/// <summary>﻿generic data.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.7">v1.7</see></item>
		/// </list>
		/// </remarks>

		DATA,
		/// <summary>﻿documentation regarding a category of file.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.7">v1.7</see></item>
		/// </list>
		/// </remarks>

		DOCUMENTATION,
		/// <summary>﻿user instructions regarding the execution of a task.<br /><br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.7">v1.7</see></item>
		/// </list>
		/// </remarks>

		INSTRUCTIONS,
		/// <summary>﻿data related to the history of a machine or process.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.7">v1.7</see></item>
		/// </list>
		/// </remarks>

		LOG,
		/// <summary>﻿machine instructions to perform a process.<br /><br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.7">v1.7</see></item>
		/// </list>
		/// </remarks>

		PRODUCTION_PROGRAM,
	}

	/// <summary>﻿
	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Enumeration___19_0_3_45f01b9_1589825656758_905757_799">model.mtconnect.org</seealso> for more information.
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public sealed class ApplicationTypeEnumMetaClass : IEnum
	{
		/// <summary>Constant value for <see cref="ApplicationTypeEnumMetaClass.ReferenceId" /></summary>
		public const string REFERENCE_ID = "_19_0_3_45f01b9_1589825656758_905757_799";
		/// <summary>Constant value for <see cref="ApplicationTypeEnumMetaClass.HelpUrl" /></summary>
		public const string HELP_URL = "https://model.mtconnect.org/#Enumeration___19_0_3_45f01b9_1589825656758_905757_799";
		/// <summary>Constant value for <see cref="ApplicationTypeEnumMetaClass.Name" /></summary>
		public const string NAME = "ApplicationTypeEnum";
		/// <summary>Constant value for <see cref="ApplicationTypeEnumMetaClass.NormativeVersion" /></summary>
		public const string NORMATIVE_VERSION = "1.7";
		/// <summary>Constant value for <see cref="ApplicationTypeEnumMetaClass.DeprecatedVersion" /></summary>
		public const string DEPRECATED_VERSION = "";
		/// <summary>Constant value for <see cref="ApplicationTypeEnumMetaClass.Summary" /></summary>
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
		public Type Instance => typeof(ApplicationTypeEnum);

		/// <inheritdoc />
		public string NormativeVersion => NORMATIVE_VERSION;
		
		/// <inheritdoc />
		public string DeprecatedVersion => DEPRECATED_VERSION;
		
		/// <inheritdoc />
		public string Summary => SUMMARY;
		
		/// <inheritdoc />
		public IEnumInstance[] Values => new IEnumInstance[] {
		DESIGN,
		DATA,
		DOCUMENTATION,
		INSTRUCTIONS,
		LOG,
		PRODUCTION_PROGRAM,
		};

		private DESIGNValue _DESIGN;
		/// <inheritdoc cref="DESIGNValue" path="/summary" />
		public DESIGNValue DESIGN => _DESIGN ?? (_DESIGN = new DESIGNValue());

		/// <summary>﻿computer aided design files or drawings.<br /><br /><br /><br />
		/// Value for ApplicationTypeEnum.<br/>
		/// <br/>See also <seealso cref="ApplicationTypeEnum">ApplicationTypeEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.7">v1.7</see></item>
		/// </list>
		/// </remarks>

		public sealed class DESIGNValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="DESIGNValue.Name" /></summary>
			public const string NAME = "DESIGN";
			/// <summary>Constant value for <see cref="DESIGNValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.7";
			/// <summary>Constant value for <see cref="DESIGNValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="DESIGNValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;computer aided design files or drawings.&#10;
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
		private DATAValue _DATA;
		/// <inheritdoc cref="DATAValue" path="/summary" />
		public DATAValue DATA => _DATA ?? (_DATA = new DATAValue());

		/// <summary>﻿generic data.<br /><br /><br />
		/// Value for ApplicationTypeEnum.<br/>
		/// <br/>See also <seealso cref="ApplicationTypeEnum">ApplicationTypeEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.7">v1.7</see></item>
		/// </list>
		/// </remarks>

		public sealed class DATAValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="DATAValue.Name" /></summary>
			public const string NAME = "DATA";
			/// <summary>Constant value for <see cref="DATAValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.7";
			/// <summary>Constant value for <see cref="DATAValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="DATAValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;generic data.&#10;
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
		private DOCUMENTATIONValue _DOCUMENTATION;
		/// <inheritdoc cref="DOCUMENTATIONValue" path="/summary" />
		public DOCUMENTATIONValue DOCUMENTATION => _DOCUMENTATION ?? (_DOCUMENTATION = new DOCUMENTATIONValue());

		/// <summary>﻿documentation regarding a category of file.<br /><br /><br />
		/// Value for ApplicationTypeEnum.<br/>
		/// <br/>See also <seealso cref="ApplicationTypeEnum">ApplicationTypeEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.7">v1.7</see></item>
		/// </list>
		/// </remarks>

		public sealed class DOCUMENTATIONValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="DOCUMENTATIONValue.Name" /></summary>
			public const string NAME = "DOCUMENTATION";
			/// <summary>Constant value for <see cref="DOCUMENTATIONValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.7";
			/// <summary>Constant value for <see cref="DOCUMENTATIONValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="DOCUMENTATIONValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;documentation regarding a category of file.&#10;
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
		private INSTRUCTIONSValue _INSTRUCTIONS;
		/// <inheritdoc cref="INSTRUCTIONSValue" path="/summary" />
		public INSTRUCTIONSValue INSTRUCTIONS => _INSTRUCTIONS ?? (_INSTRUCTIONS = new INSTRUCTIONSValue());

		/// <summary>﻿user instructions regarding the execution of a task.<br /><br /><br /><br />
		/// Value for ApplicationTypeEnum.<br/>
		/// <br/>See also <seealso cref="ApplicationTypeEnum">ApplicationTypeEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.7">v1.7</see></item>
		/// </list>
		/// </remarks>

		public sealed class INSTRUCTIONSValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="INSTRUCTIONSValue.Name" /></summary>
			public const string NAME = "INSTRUCTIONS";
			/// <summary>Constant value for <see cref="INSTRUCTIONSValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.7";
			/// <summary>Constant value for <see cref="INSTRUCTIONSValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="INSTRUCTIONSValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;user instructions regarding the execution of a task.&#10;
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
		private LOGValue _LOG;
		/// <inheritdoc cref="LOGValue" path="/summary" />
		public LOGValue LOG => _LOG ?? (_LOG = new LOGValue());

		/// <summary>﻿data related to the history of a machine or process.<br /><br /><br />
		/// Value for ApplicationTypeEnum.<br/>
		/// <br/>See also <seealso cref="ApplicationTypeEnum">ApplicationTypeEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.7">v1.7</see></item>
		/// </list>
		/// </remarks>

		public sealed class LOGValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="LOGValue.Name" /></summary>
			public const string NAME = "LOG";
			/// <summary>Constant value for <see cref="LOGValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.7";
			/// <summary>Constant value for <see cref="LOGValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="LOGValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;data related to the history of a machine or process.&#10;
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
		private PRODUCTION_PROGRAMValue _PRODUCTION_PROGRAM;
		/// <inheritdoc cref="PRODUCTION_PROGRAMValue" path="/summary" />
		public PRODUCTION_PROGRAMValue PRODUCTION_PROGRAM => _PRODUCTION_PROGRAM ?? (_PRODUCTION_PROGRAM = new PRODUCTION_PROGRAMValue());

		/// <summary>﻿machine instructions to perform a process.<br /><br /><br /><br />
		/// Value for ApplicationTypeEnum.<br/>
		/// <br/>See also <seealso cref="ApplicationTypeEnum">ApplicationTypeEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.7">v1.7</see></item>
		/// </list>
		/// </remarks>

		public sealed class PRODUCTION_PROGRAMValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="PRODUCTION_PROGRAMValue.Name" /></summary>
			public const string NAME = "PRODUCTION_PROGRAM";
			/// <summary>Constant value for <see cref="PRODUCTION_PROGRAMValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.7";
			/// <summary>Constant value for <see cref="PRODUCTION_PROGRAMValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="PRODUCTION_PROGRAMValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;machine instructions to perform a process.&#10;
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