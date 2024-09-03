#pragma warning disable CS1574 // XML comment has cref attribute that could not be resolved
#pragma warning disable CS1584 // XML comment has syntactically incorrect cref attribute
#pragma warning disable CS0618 // Type or member is obsolete
using System;
using System.CodeDom.Compiler;using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;

namespace Mtconnect.DataTypes
{
	/// <summary>﻿
	/// <br/> Visit <seealso href="https://model.mtconnect.org/#Enumeration___19_0_3_68e0225_1605550283222_680737_1925">model.mtconnect.org</seealso> for more information.
	/// </summary>
	/// <remarks>
	/// <list type="bullet">
	/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.8">v1.8</see></item>
	/// </list>
	/// </remarks>

	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public enum ProcessStateEnum
	{
		/// <summary>﻿device is preparing to execute the process occurrence.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.8">v1.8</see></item>
		/// </list>
		/// </remarks>

		INITIALIZING,
		/// <summary>﻿process occurrence is ready to be executed.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.8">v1.8</see></item>
		/// </list>
		/// </remarks>

		READY,
		/// <summary>﻿process occurrence is actively executing.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.8">v1.8</see></item>
		/// </list>
		/// </remarks>

		ACTIVE,
		/// <summary>﻿process occurrence is now finished.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.8">v1.8</see></item>
		/// </list>
		/// </remarks>

		COMPLETE,
		/// <summary>﻿process occurrence has been stopped and may be resumed.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.8">v1.8</see></item>
		/// </list>
		/// </remarks>

		INTERRUPTED,
		/// <summary>﻿process occurrence has come to a premature end and cannot be resumed.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.8">v1.8</see></item>
		/// </list>
		/// </remarks>

		ABORTED,
	}

	/// <summary>﻿
	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Enumeration___19_0_3_68e0225_1605550283222_680737_1925">model.mtconnect.org</seealso> for more information.
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public sealed class ProcessStateEnumMetaClass : IEnum
	{
		/// <summary>Constant value for <see cref="ProcessStateEnumMetaClass.ReferenceId" /></summary>
		public const string REFERENCE_ID = "_19_0_3_68e0225_1605550283222_680737_1925";
		/// <summary>Constant value for <see cref="ProcessStateEnumMetaClass.HelpUrl" /></summary>
		public const string HELP_URL = "https://model.mtconnect.org/#Enumeration___19_0_3_68e0225_1605550283222_680737_1925";
		/// <summary>Constant value for <see cref="ProcessStateEnumMetaClass.Name" /></summary>
		public const string NAME = "ProcessStateEnum";
		/// <summary>Constant value for <see cref="ProcessStateEnumMetaClass.NormativeVersion" /></summary>
		public const string NORMATIVE_VERSION = "1.8";
		/// <summary>Constant value for <see cref="ProcessStateEnumMetaClass.DeprecatedVersion" /></summary>
		public const string DEPRECATED_VERSION = "";
		/// <summary>Constant value for <see cref="ProcessStateEnumMetaClass.Summary" /></summary>
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
		public Type Instance => typeof(ProcessStateEnum);

		/// <inheritdoc />
		public string NormativeVersion => NORMATIVE_VERSION;
		
		/// <inheritdoc />
		public string DeprecatedVersion => DEPRECATED_VERSION;
		
		/// <inheritdoc />
		public string Summary => SUMMARY;
		
		/// <inheritdoc />
		public IEnumInstance[] Values => new IEnumInstance[] {
		INITIALIZING,
		READY,
		ACTIVE,
		COMPLETE,
		INTERRUPTED,
		ABORTED,
		};

		private INITIALIZINGValue _INITIALIZING;
		/// <inheritdoc cref="INITIALIZINGValue" path="/summary" />
		public INITIALIZINGValue INITIALIZING => _INITIALIZING ?? (_INITIALIZING = new INITIALIZINGValue());

		/// <summary>﻿device is preparing to execute the process occurrence.<br /><br /><br />
		/// Value for ProcessStateEnum.<br/>
		/// <br/>See also <seealso cref="ProcessStateEnum">ProcessStateEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.8">v1.8</see></item>
		/// </list>
		/// </remarks>

		public sealed class INITIALIZINGValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="INITIALIZINGValue.Name" /></summary>
			public const string NAME = "INITIALIZING";
			/// <summary>Constant value for <see cref="INITIALIZINGValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.8";
			/// <summary>Constant value for <see cref="INITIALIZINGValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="INITIALIZINGValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;device is preparing to execute the process occurrence.&#10;
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
		private READYValue _READY;
		/// <inheritdoc cref="READYValue" path="/summary" />
		public READYValue READY => _READY ?? (_READY = new READYValue());

		/// <summary>﻿process occurrence is ready to be executed.<br /><br /><br />
		/// Value for ProcessStateEnum.<br/>
		/// <br/>See also <seealso cref="ProcessStateEnum">ProcessStateEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.8">v1.8</see></item>
		/// </list>
		/// </remarks>

		public sealed class READYValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="READYValue.Name" /></summary>
			public const string NAME = "READY";
			/// <summary>Constant value for <see cref="READYValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.8";
			/// <summary>Constant value for <see cref="READYValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="READYValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;process occurrence is ready to be executed.&#10;
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
		private ACTIVEValue _ACTIVE;
		/// <inheritdoc cref="ACTIVEValue" path="/summary" />
		public ACTIVEValue ACTIVE => _ACTIVE ?? (_ACTIVE = new ACTIVEValue());

		/// <summary>﻿process occurrence is actively executing.<br /><br /><br />
		/// Value for ProcessStateEnum.<br/>
		/// <br/>See also <seealso cref="ProcessStateEnum">ProcessStateEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.8">v1.8</see></item>
		/// </list>
		/// </remarks>

		public sealed class ACTIVEValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="ACTIVEValue.Name" /></summary>
			public const string NAME = "ACTIVE";
			/// <summary>Constant value for <see cref="ACTIVEValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.8";
			/// <summary>Constant value for <see cref="ACTIVEValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="ACTIVEValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;process occurrence is actively executing.&#10;
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
		private COMPLETEValue _COMPLETE;
		/// <inheritdoc cref="COMPLETEValue" path="/summary" />
		public COMPLETEValue COMPLETE => _COMPLETE ?? (_COMPLETE = new COMPLETEValue());

		/// <summary>﻿process occurrence is now finished.<br /><br /><br />
		/// Value for ProcessStateEnum.<br/>
		/// <br/>See also <seealso cref="ProcessStateEnum">ProcessStateEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.8">v1.8</see></item>
		/// </list>
		/// </remarks>

		public sealed class COMPLETEValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="COMPLETEValue.Name" /></summary>
			public const string NAME = "COMPLETE";
			/// <summary>Constant value for <see cref="COMPLETEValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.8";
			/// <summary>Constant value for <see cref="COMPLETEValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="COMPLETEValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;process occurrence is now finished.&#10;
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
		private INTERRUPTEDValue _INTERRUPTED;
		/// <inheritdoc cref="INTERRUPTEDValue" path="/summary" />
		public INTERRUPTEDValue INTERRUPTED => _INTERRUPTED ?? (_INTERRUPTED = new INTERRUPTEDValue());

		/// <summary>﻿process occurrence has been stopped and may be resumed.<br /><br /><br />
		/// Value for ProcessStateEnum.<br/>
		/// <br/>See also <seealso cref="ProcessStateEnum">ProcessStateEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.8">v1.8</see></item>
		/// </list>
		/// </remarks>

		public sealed class INTERRUPTEDValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="INTERRUPTEDValue.Name" /></summary>
			public const string NAME = "INTERRUPTED";
			/// <summary>Constant value for <see cref="INTERRUPTEDValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.8";
			/// <summary>Constant value for <see cref="INTERRUPTEDValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="INTERRUPTEDValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;process occurrence has been stopped and may be resumed.&#10;
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
		private ABORTEDValue _ABORTED;
		/// <inheritdoc cref="ABORTEDValue" path="/summary" />
		public ABORTEDValue ABORTED => _ABORTED ?? (_ABORTED = new ABORTEDValue());

		/// <summary>﻿process occurrence has come to a premature end and cannot be resumed.<br /><br /><br />
		/// Value for ProcessStateEnum.<br/>
		/// <br/>See also <seealso cref="ProcessStateEnum">ProcessStateEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.8">v1.8</see></item>
		/// </list>
		/// </remarks>

		public sealed class ABORTEDValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="ABORTEDValue.Name" /></summary>
			public const string NAME = "ABORTED";
			/// <summary>Constant value for <see cref="ABORTEDValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.8";
			/// <summary>Constant value for <see cref="ABORTEDValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="ABORTEDValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;process occurrence has come to a premature end and cannot be resumed.&#10;
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