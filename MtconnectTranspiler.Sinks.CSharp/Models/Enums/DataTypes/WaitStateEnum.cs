#pragma warning disable CS1574 // XML comment has cref attribute that could not be resolved
#pragma warning disable CS1584 // XML comment has syntactically incorrect cref attribute
#pragma warning disable CS0618 // Type or member is obsolete
using System;
using System.CodeDom.Compiler;using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;

namespace Mtconnect.DataTypes
{
	/// <summary>﻿
	/// <br/> Visit <seealso href="https://model.mtconnect.org/#Enumeration___19_0_3_45f01b9_1581143980612_724749_76">model.mtconnect.org</seealso> for more information.
	/// </summary>
	/// <remarks>
	/// <list type="bullet">
	/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.5">v1.5</see></item>
	/// </list>
	/// </remarks>

	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public enum WaitStateEnum
	{
		/// <summary>﻿execution is waiting while the equipment is powering up and is not currently available to begin producing parts or products.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.5">v1.5</see></item>
		/// </list>
		/// </remarks>

		POWERING_UP,
		/// <summary>﻿execution is waiting while the equipment is powering down but has not fully reached a stopped state.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.5">v1.5</see></item>
		/// </list>
		/// </remarks>

		POWERING_DOWN,
		/// <summary>﻿execution is waiting while one or more discrete workpieces are being loaded.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.5">v1.5</see></item>
		/// </list>
		/// </remarks>

		PART_LOAD,
		/// <summary>﻿execution is waiting while one or more discrete workpieces are being unloaded.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.5">v1.5</see></item>
		/// </list>
		/// </remarks>

		PART_UNLOAD,
		/// <summary>﻿execution is waiting while a tool or tooling is being loaded.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.5">v1.5</see></item>
		/// </list>
		/// </remarks>

		TOOL_LOAD,
		/// <summary>﻿execution is waiting while a tool or tooling is being unloaded.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.5">v1.5</see></item>
		/// </list>
		/// </remarks>

		TOOL_UNLOAD,
		/// <summary>﻿execution is waiting while material is being loaded.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.5">v1.5</see></item>
		/// </list>
		/// </remarks>

		MATERIAL_LOAD,
		/// <summary>﻿execution is waiting while material is being unloaded.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.5">v1.5</see></item>
		/// </list>
		/// </remarks>

		MATERIAL_UNLOAD,
		/// <summary>﻿execution is waiting while another process is completed before the execution can resume.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.5">v1.5</see></item>
		/// </list>
		/// </remarks>

		SECONDARY_PROCESS,
		/// <summary>﻿execution is waiting while the equipment is pausing but the piece of equipment has not yet reached a fully paused state.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.5">v1.5</see></item>
		/// </list>
		/// </remarks>

		PAUSING,
		/// <summary>﻿execution is waiting while the equipment is resuming the production cycle but has not yet resumed execution.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.5">v1.5</see></item>
		/// </list>
		/// </remarks>

		RESUMING,
	}

	/// <summary>﻿
	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Enumeration___19_0_3_45f01b9_1581143980612_724749_76">model.mtconnect.org</seealso> for more information.
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public sealed class WaitStateEnumMetaClass : IEnum
	{
		/// <summary>Constant value for <see cref="WaitStateEnumMetaClass.ReferenceId" /></summary>
		public const string REFERENCE_ID = "_19_0_3_45f01b9_1581143980612_724749_76";
		/// <summary>Constant value for <see cref="WaitStateEnumMetaClass.HelpUrl" /></summary>
		public const string HELP_URL = "https://model.mtconnect.org/#Enumeration___19_0_3_45f01b9_1581143980612_724749_76";
		/// <summary>Constant value for <see cref="WaitStateEnumMetaClass.Name" /></summary>
		public const string NAME = "WaitStateEnum";
		/// <summary>Constant value for <see cref="WaitStateEnumMetaClass.NormativeVersion" /></summary>
		public const string NORMATIVE_VERSION = "1.5";
		/// <summary>Constant value for <see cref="WaitStateEnumMetaClass.DeprecatedVersion" /></summary>
		public const string DEPRECATED_VERSION = "";
		/// <summary>Constant value for <see cref="WaitStateEnumMetaClass.Summary" /></summary>
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
		public Type Instance => typeof(WaitStateEnum);

		/// <inheritdoc />
		public string NormativeVersion => NORMATIVE_VERSION;
		
		/// <inheritdoc />
		public string DeprecatedVersion => DEPRECATED_VERSION;
		
		/// <inheritdoc />
		public string Summary => SUMMARY;
		
		/// <inheritdoc />
		public IEnumInstance[] Values => new IEnumInstance[] {
		POWERING_UP,
		POWERING_DOWN,
		PART_LOAD,
		PART_UNLOAD,
		TOOL_LOAD,
		TOOL_UNLOAD,
		MATERIAL_LOAD,
		MATERIAL_UNLOAD,
		SECONDARY_PROCESS,
		PAUSING,
		RESUMING,
		};

		private POWERING_UPValue _POWERING_UP;
		/// <inheritdoc cref="POWERING_UPValue" path="/summary" />
		public POWERING_UPValue POWERING_UP => _POWERING_UP ?? (_POWERING_UP = new POWERING_UPValue());

		/// <summary>﻿execution is waiting while the equipment is powering up and is not currently available to begin producing parts or products.<br /><br /><br />
		/// Value for WaitStateEnum.<br/>
		/// <br/>See also <seealso cref="WaitStateEnum">WaitStateEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.5">v1.5</see></item>
		/// </list>
		/// </remarks>

		public sealed class POWERING_UPValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="POWERING_UPValue.Name" /></summary>
			public const string NAME = "POWERING_UP";
			/// <summary>Constant value for <see cref="POWERING_UPValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.5";
			/// <summary>Constant value for <see cref="POWERING_UPValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="POWERING_UPValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;execution is waiting while the equipment is powering up and is not currently available to begin producing parts or products.&#10;
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
		private POWERING_DOWNValue _POWERING_DOWN;
		/// <inheritdoc cref="POWERING_DOWNValue" path="/summary" />
		public POWERING_DOWNValue POWERING_DOWN => _POWERING_DOWN ?? (_POWERING_DOWN = new POWERING_DOWNValue());

		/// <summary>﻿execution is waiting while the equipment is powering down but has not fully reached a stopped state.<br /><br /><br />
		/// Value for WaitStateEnum.<br/>
		/// <br/>See also <seealso cref="WaitStateEnum">WaitStateEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.5">v1.5</see></item>
		/// </list>
		/// </remarks>

		public sealed class POWERING_DOWNValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="POWERING_DOWNValue.Name" /></summary>
			public const string NAME = "POWERING_DOWN";
			/// <summary>Constant value for <see cref="POWERING_DOWNValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.5";
			/// <summary>Constant value for <see cref="POWERING_DOWNValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="POWERING_DOWNValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;execution is waiting while the equipment is powering down but has not fully reached a stopped state.&#10;
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
		private PART_LOADValue _PART_LOAD;
		/// <inheritdoc cref="PART_LOADValue" path="/summary" />
		public PART_LOADValue PART_LOAD => _PART_LOAD ?? (_PART_LOAD = new PART_LOADValue());

		/// <summary>﻿execution is waiting while one or more discrete workpieces are being loaded.<br /><br /><br />
		/// Value for WaitStateEnum.<br/>
		/// <br/>See also <seealso cref="WaitStateEnum">WaitStateEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.5">v1.5</see></item>
		/// </list>
		/// </remarks>

		public sealed class PART_LOADValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="PART_LOADValue.Name" /></summary>
			public const string NAME = "PART_LOAD";
			/// <summary>Constant value for <see cref="PART_LOADValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.5";
			/// <summary>Constant value for <see cref="PART_LOADValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="PART_LOADValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;execution is waiting while one or more discrete workpieces are being loaded.&#10;
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
		private PART_UNLOADValue _PART_UNLOAD;
		/// <inheritdoc cref="PART_UNLOADValue" path="/summary" />
		public PART_UNLOADValue PART_UNLOAD => _PART_UNLOAD ?? (_PART_UNLOAD = new PART_UNLOADValue());

		/// <summary>﻿execution is waiting while one or more discrete workpieces are being unloaded.<br /><br /><br />
		/// Value for WaitStateEnum.<br/>
		/// <br/>See also <seealso cref="WaitStateEnum">WaitStateEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.5">v1.5</see></item>
		/// </list>
		/// </remarks>

		public sealed class PART_UNLOADValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="PART_UNLOADValue.Name" /></summary>
			public const string NAME = "PART_UNLOAD";
			/// <summary>Constant value for <see cref="PART_UNLOADValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.5";
			/// <summary>Constant value for <see cref="PART_UNLOADValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="PART_UNLOADValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;execution is waiting while one or more discrete workpieces are being unloaded.&#10;
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
		private TOOL_LOADValue _TOOL_LOAD;
		/// <inheritdoc cref="TOOL_LOADValue" path="/summary" />
		public TOOL_LOADValue TOOL_LOAD => _TOOL_LOAD ?? (_TOOL_LOAD = new TOOL_LOADValue());

		/// <summary>﻿execution is waiting while a tool or tooling is being loaded.<br /><br /><br />
		/// Value for WaitStateEnum.<br/>
		/// <br/>See also <seealso cref="WaitStateEnum">WaitStateEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.5">v1.5</see></item>
		/// </list>
		/// </remarks>

		public sealed class TOOL_LOADValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="TOOL_LOADValue.Name" /></summary>
			public const string NAME = "TOOL_LOAD";
			/// <summary>Constant value for <see cref="TOOL_LOADValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.5";
			/// <summary>Constant value for <see cref="TOOL_LOADValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="TOOL_LOADValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;execution is waiting while a tool or tooling is being loaded.&#10;
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
		private TOOL_UNLOADValue _TOOL_UNLOAD;
		/// <inheritdoc cref="TOOL_UNLOADValue" path="/summary" />
		public TOOL_UNLOADValue TOOL_UNLOAD => _TOOL_UNLOAD ?? (_TOOL_UNLOAD = new TOOL_UNLOADValue());

		/// <summary>﻿execution is waiting while a tool or tooling is being unloaded.<br /><br /><br />
		/// Value for WaitStateEnum.<br/>
		/// <br/>See also <seealso cref="WaitStateEnum">WaitStateEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.5">v1.5</see></item>
		/// </list>
		/// </remarks>

		public sealed class TOOL_UNLOADValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="TOOL_UNLOADValue.Name" /></summary>
			public const string NAME = "TOOL_UNLOAD";
			/// <summary>Constant value for <see cref="TOOL_UNLOADValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.5";
			/// <summary>Constant value for <see cref="TOOL_UNLOADValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="TOOL_UNLOADValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;execution is waiting while a tool or tooling is being unloaded.&#10;
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
		private MATERIAL_LOADValue _MATERIAL_LOAD;
		/// <inheritdoc cref="MATERIAL_LOADValue" path="/summary" />
		public MATERIAL_LOADValue MATERIAL_LOAD => _MATERIAL_LOAD ?? (_MATERIAL_LOAD = new MATERIAL_LOADValue());

		/// <summary>﻿execution is waiting while material is being loaded.<br /><br /><br />
		/// Value for WaitStateEnum.<br/>
		/// <br/>See also <seealso cref="WaitStateEnum">WaitStateEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.5">v1.5</see></item>
		/// </list>
		/// </remarks>

		public sealed class MATERIAL_LOADValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="MATERIAL_LOADValue.Name" /></summary>
			public const string NAME = "MATERIAL_LOAD";
			/// <summary>Constant value for <see cref="MATERIAL_LOADValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.5";
			/// <summary>Constant value for <see cref="MATERIAL_LOADValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="MATERIAL_LOADValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;execution is waiting while material is being loaded.&#10;
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
		private MATERIAL_UNLOADValue _MATERIAL_UNLOAD;
		/// <inheritdoc cref="MATERIAL_UNLOADValue" path="/summary" />
		public MATERIAL_UNLOADValue MATERIAL_UNLOAD => _MATERIAL_UNLOAD ?? (_MATERIAL_UNLOAD = new MATERIAL_UNLOADValue());

		/// <summary>﻿execution is waiting while material is being unloaded.<br /><br /><br />
		/// Value for WaitStateEnum.<br/>
		/// <br/>See also <seealso cref="WaitStateEnum">WaitStateEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.5">v1.5</see></item>
		/// </list>
		/// </remarks>

		public sealed class MATERIAL_UNLOADValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="MATERIAL_UNLOADValue.Name" /></summary>
			public const string NAME = "MATERIAL_UNLOAD";
			/// <summary>Constant value for <see cref="MATERIAL_UNLOADValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.5";
			/// <summary>Constant value for <see cref="MATERIAL_UNLOADValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="MATERIAL_UNLOADValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;execution is waiting while material is being unloaded.&#10;
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
		private SECONDARY_PROCESSValue _SECONDARY_PROCESS;
		/// <inheritdoc cref="SECONDARY_PROCESSValue" path="/summary" />
		public SECONDARY_PROCESSValue SECONDARY_PROCESS => _SECONDARY_PROCESS ?? (_SECONDARY_PROCESS = new SECONDARY_PROCESSValue());

		/// <summary>﻿execution is waiting while another process is completed before the execution can resume.<br /><br /><br />
		/// Value for WaitStateEnum.<br/>
		/// <br/>See also <seealso cref="WaitStateEnum">WaitStateEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.5">v1.5</see></item>
		/// </list>
		/// </remarks>

		public sealed class SECONDARY_PROCESSValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="SECONDARY_PROCESSValue.Name" /></summary>
			public const string NAME = "SECONDARY_PROCESS";
			/// <summary>Constant value for <see cref="SECONDARY_PROCESSValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.5";
			/// <summary>Constant value for <see cref="SECONDARY_PROCESSValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="SECONDARY_PROCESSValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;execution is waiting while another process is completed before the execution can resume.&#10;
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
		private PAUSINGValue _PAUSING;
		/// <inheritdoc cref="PAUSINGValue" path="/summary" />
		public PAUSINGValue PAUSING => _PAUSING ?? (_PAUSING = new PAUSINGValue());

		/// <summary>﻿execution is waiting while the equipment is pausing but the piece of equipment has not yet reached a fully paused state.<br /><br /><br />
		/// Value for WaitStateEnum.<br/>
		/// <br/>See also <seealso cref="WaitStateEnum">WaitStateEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.5">v1.5</see></item>
		/// </list>
		/// </remarks>

		public sealed class PAUSINGValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="PAUSINGValue.Name" /></summary>
			public const string NAME = "PAUSING";
			/// <summary>Constant value for <see cref="PAUSINGValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.5";
			/// <summary>Constant value for <see cref="PAUSINGValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="PAUSINGValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;execution is waiting while the equipment is pausing but the piece of equipment has not yet reached a fully paused state.&#10;
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
		private RESUMINGValue _RESUMING;
		/// <inheritdoc cref="RESUMINGValue" path="/summary" />
		public RESUMINGValue RESUMING => _RESUMING ?? (_RESUMING = new RESUMINGValue());

		/// <summary>﻿execution is waiting while the equipment is resuming the production cycle but has not yet resumed execution.<br /><br /><br />
		/// Value for WaitStateEnum.<br/>
		/// <br/>See also <seealso cref="WaitStateEnum">WaitStateEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.5">v1.5</see></item>
		/// </list>
		/// </remarks>

		public sealed class RESUMINGValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="RESUMINGValue.Name" /></summary>
			public const string NAME = "RESUMING";
			/// <summary>Constant value for <see cref="RESUMINGValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.5";
			/// <summary>Constant value for <see cref="RESUMINGValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="RESUMINGValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;execution is waiting while the equipment is resuming the production cycle but has not yet resumed execution.&#10;
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