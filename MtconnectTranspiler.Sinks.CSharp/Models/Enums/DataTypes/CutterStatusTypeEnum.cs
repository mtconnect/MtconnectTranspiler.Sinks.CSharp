#pragma warning disable CS1574 // XML comment has cref attribute that could not be resolved
#pragma warning disable CS1584 // XML comment has syntactically incorrect cref attribute
#pragma warning disable CS0618 // Type or member is obsolete
using System;
using System.CodeDom.Compiler;using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;

namespace Mtconnect.DataTypes
{
	/// <summary>﻿
	/// <br/> Visit <seealso href="https://model.mtconnect.org/#Enumeration__EAID_782BD14C_FE49_4276_B7D0_7B42DA63B37F">model.mtconnect.org</seealso> for more information.
	/// </summary>
	/// <remarks>
	/// <list type="bullet">
	/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.2">v1.2</see></item>
	/// </list>
	/// </remarks>

	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public enum CutterStatusTypeEnum
	{
		/// <summary>﻿new tool that has not been used or first use. <br /><br />Marks the start of the tool history.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.2">v1.2</see></item>
		/// </list>
		/// </remarks>

		NEW,
		/// <summary>﻿tool is available for use. <br /><br />If this is not present, the tool is currently not ready to be used.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.2">v1.2</see></item>
		/// </list>
		/// </remarks>

		AVAILABLE,
		/// <summary>﻿tool is unavailable for use in metal removal. <br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.2">v1.2</see></item>
		/// </list>
		/// </remarks>

		UNAVAILABLE,
		/// <summary>﻿tool is has been committed to a piece of equipment for use and is not available for use in any other piece of equipment.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.2">v1.2</see></item>
		/// </list>
		/// </remarks>

		ALLOCATED,
		/// <summary>﻿tool has not been committed to a process and can be allocated.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.2">v1.2</see></item>
		/// </list>
		/// </remarks>

		UNALLOCATED,
		/// <summary>﻿tool has been measured.<br /><br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.2">v1.2</see></item>
		/// </list>
		/// </remarks>

		MEASURED,
		/// <summary>﻿tool has been reconditioned.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.2">v1.2</see></item>
		/// </list>
		/// </remarks>

		RECONDITIONED,
		/// <summary>﻿tool is in process and has remaining tool life.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.2">v1.2</see></item>
		/// </list>
		/// </remarks>

		USED,
		/// <summary>﻿tool has reached the end of its useful life.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.2">v1.2</see></item>
		/// </list>
		/// </remarks>

		EXPIRED,
		/// <summary>﻿premature tool failure.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.2">v1.2</see></item>
		/// </list>
		/// </remarks>

		BROKEN,
		/// <summary>﻿tool cannot be used until it is entered into the system.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.2">v1.2</see></item>
		/// </list>
		/// </remarks>

		NOT_REGISTERED,
		/// <summary>﻿tool is an indeterminate state. This is the default value.<br /><br /><br />
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.2">v1.2</see></item>
		/// </list>
		/// </remarks>

		UNKNOWN,
	}

	/// <summary>﻿
	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Enumeration__EAID_782BD14C_FE49_4276_B7D0_7B42DA63B37F">model.mtconnect.org</seealso> for more information.
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public sealed class CutterStatusTypeEnumMetaClass : IEnum
	{
		/// <summary>Constant value for <see cref="CutterStatusTypeEnumMetaClass.ReferenceId" /></summary>
		public const string REFERENCE_ID = "EAID_782BD14C_FE49_4276_B7D0_7B42DA63B37F";
		/// <summary>Constant value for <see cref="CutterStatusTypeEnumMetaClass.HelpUrl" /></summary>
		public const string HELP_URL = "https://model.mtconnect.org/#Enumeration__EAID_782BD14C_FE49_4276_B7D0_7B42DA63B37F";
		/// <summary>Constant value for <see cref="CutterStatusTypeEnumMetaClass.Name" /></summary>
		public const string NAME = "CutterStatusTypeEnum";
		/// <summary>Constant value for <see cref="CutterStatusTypeEnumMetaClass.NormativeVersion" /></summary>
		public const string NORMATIVE_VERSION = "1.2";
		/// <summary>Constant value for <see cref="CutterStatusTypeEnumMetaClass.DeprecatedVersion" /></summary>
		public const string DEPRECATED_VERSION = "";
		/// <summary>Constant value for <see cref="CutterStatusTypeEnumMetaClass.Summary" /></summary>
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
		public Type Instance => typeof(CutterStatusTypeEnum);

		/// <inheritdoc />
		public string NormativeVersion => NORMATIVE_VERSION;
		
		/// <inheritdoc />
		public string DeprecatedVersion => DEPRECATED_VERSION;
		
		/// <inheritdoc />
		public string Summary => SUMMARY;
		
		/// <inheritdoc />
		public IEnumInstance[] Values => new IEnumInstance[] {
		NEW,
		AVAILABLE,
		UNAVAILABLE,
		ALLOCATED,
		UNALLOCATED,
		MEASURED,
		RECONDITIONED,
		USED,
		EXPIRED,
		BROKEN,
		NOT_REGISTERED,
		UNKNOWN,
		};

		private NEWValue _NEW;
		/// <inheritdoc cref="NEWValue" path="/summary" />
		public NEWValue NEW => _NEW ?? (_NEW = new NEWValue());

		/// <summary>﻿new tool that has not been used or first use. <br /><br />Marks the start of the tool history.<br /><br /><br />
		/// Value for CutterStatusTypeEnum.<br/>
		/// <br/>See also <seealso cref="CutterStatusTypeEnum">CutterStatusTypeEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.2">v1.2</see></item>
		/// </list>
		/// </remarks>

		public sealed class NEWValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="NEWValue.Name" /></summary>
			public const string NAME = "NEW";
			/// <summary>Constant value for <see cref="NEWValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.2";
			/// <summary>Constant value for <see cref="NEWValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="NEWValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;new tool that has not been used or first use. 

Marks the start of the tool history.&#10;
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
		private AVAILABLEValue _AVAILABLE;
		/// <inheritdoc cref="AVAILABLEValue" path="/summary" />
		public AVAILABLEValue AVAILABLE => _AVAILABLE ?? (_AVAILABLE = new AVAILABLEValue());

		/// <summary>﻿tool is available for use. <br /><br />If this is not present, the tool is currently not ready to be used.<br /><br /><br />
		/// Value for CutterStatusTypeEnum.<br/>
		/// <br/>See also <seealso cref="CutterStatusTypeEnum">CutterStatusTypeEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.2">v1.2</see></item>
		/// </list>
		/// </remarks>

		public sealed class AVAILABLEValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="AVAILABLEValue.Name" /></summary>
			public const string NAME = "AVAILABLE";
			/// <summary>Constant value for <see cref="AVAILABLEValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.2";
			/// <summary>Constant value for <see cref="AVAILABLEValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="AVAILABLEValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;tool is available for use. 

If this is not present, the tool is currently not ready to be used.&#10;
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
		private UNAVAILABLEValue _UNAVAILABLE;
		/// <inheritdoc cref="UNAVAILABLEValue" path="/summary" />
		public UNAVAILABLEValue UNAVAILABLE => _UNAVAILABLE ?? (_UNAVAILABLE = new UNAVAILABLEValue());

		/// <summary>﻿tool is unavailable for use in metal removal. <br /><br /><br />
		/// Value for CutterStatusTypeEnum.<br/>
		/// <br/>See also <seealso cref="CutterStatusTypeEnum">CutterStatusTypeEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.2">v1.2</see></item>
		/// </list>
		/// </remarks>

		public sealed class UNAVAILABLEValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="UNAVAILABLEValue.Name" /></summary>
			public const string NAME = "UNAVAILABLE";
			/// <summary>Constant value for <see cref="UNAVAILABLEValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.2";
			/// <summary>Constant value for <see cref="UNAVAILABLEValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="UNAVAILABLEValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;tool is unavailable for use in metal removal. &#10;
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
		private ALLOCATEDValue _ALLOCATED;
		/// <inheritdoc cref="ALLOCATEDValue" path="/summary" />
		public ALLOCATEDValue ALLOCATED => _ALLOCATED ?? (_ALLOCATED = new ALLOCATEDValue());

		/// <summary>﻿tool is has been committed to a piece of equipment for use and is not available for use in any other piece of equipment.<br /><br /><br />
		/// Value for CutterStatusTypeEnum.<br/>
		/// <br/>See also <seealso cref="CutterStatusTypeEnum">CutterStatusTypeEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.2">v1.2</see></item>
		/// </list>
		/// </remarks>

		public sealed class ALLOCATEDValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="ALLOCATEDValue.Name" /></summary>
			public const string NAME = "ALLOCATED";
			/// <summary>Constant value for <see cref="ALLOCATEDValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.2";
			/// <summary>Constant value for <see cref="ALLOCATEDValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="ALLOCATEDValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;tool is has been committed to a piece of equipment for use and is not available for use in any other piece of equipment.&#10;
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
		private UNALLOCATEDValue _UNALLOCATED;
		/// <inheritdoc cref="UNALLOCATEDValue" path="/summary" />
		public UNALLOCATEDValue UNALLOCATED => _UNALLOCATED ?? (_UNALLOCATED = new UNALLOCATEDValue());

		/// <summary>﻿tool has not been committed to a process and can be allocated.<br /><br /><br />
		/// Value for CutterStatusTypeEnum.<br/>
		/// <br/>See also <seealso cref="CutterStatusTypeEnum">CutterStatusTypeEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.2">v1.2</see></item>
		/// </list>
		/// </remarks>

		public sealed class UNALLOCATEDValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="UNALLOCATEDValue.Name" /></summary>
			public const string NAME = "UNALLOCATED";
			/// <summary>Constant value for <see cref="UNALLOCATEDValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.2";
			/// <summary>Constant value for <see cref="UNALLOCATEDValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="UNALLOCATEDValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;tool has not been committed to a process and can be allocated.&#10;
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
		private MEASUREDValue _MEASURED;
		/// <inheritdoc cref="MEASUREDValue" path="/summary" />
		public MEASUREDValue MEASURED => _MEASURED ?? (_MEASURED = new MEASUREDValue());

		/// <summary>﻿tool has been measured.<br /><br /><br /><br />
		/// Value for CutterStatusTypeEnum.<br/>
		/// <br/>See also <seealso cref="CutterStatusTypeEnum">CutterStatusTypeEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.2">v1.2</see></item>
		/// </list>
		/// </remarks>

		public sealed class MEASUREDValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="MEASUREDValue.Name" /></summary>
			public const string NAME = "MEASURED";
			/// <summary>Constant value for <see cref="MEASUREDValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.2";
			/// <summary>Constant value for <see cref="MEASUREDValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="MEASUREDValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;tool has been measured.&#10;
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
		private RECONDITIONEDValue _RECONDITIONED;
		/// <inheritdoc cref="RECONDITIONEDValue" path="/summary" />
		public RECONDITIONEDValue RECONDITIONED => _RECONDITIONED ?? (_RECONDITIONED = new RECONDITIONEDValue());

		/// <summary>﻿tool has been reconditioned.<br /><br /><br />
		/// Value for CutterStatusTypeEnum.<br/>
		/// <br/>See also <seealso cref="CutterStatusTypeEnum">CutterStatusTypeEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.2">v1.2</see></item>
		/// </list>
		/// </remarks>

		public sealed class RECONDITIONEDValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="RECONDITIONEDValue.Name" /></summary>
			public const string NAME = "RECONDITIONED";
			/// <summary>Constant value for <see cref="RECONDITIONEDValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.2";
			/// <summary>Constant value for <see cref="RECONDITIONEDValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="RECONDITIONEDValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;tool has been reconditioned.&#10;
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
		private USEDValue _USED;
		/// <inheritdoc cref="USEDValue" path="/summary" />
		public USEDValue USED => _USED ?? (_USED = new USEDValue());

		/// <summary>﻿tool is in process and has remaining tool life.<br /><br /><br />
		/// Value for CutterStatusTypeEnum.<br/>
		/// <br/>See also <seealso cref="CutterStatusTypeEnum">CutterStatusTypeEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.2">v1.2</see></item>
		/// </list>
		/// </remarks>

		public sealed class USEDValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="USEDValue.Name" /></summary>
			public const string NAME = "USED";
			/// <summary>Constant value for <see cref="USEDValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.2";
			/// <summary>Constant value for <see cref="USEDValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="USEDValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;tool is in process and has remaining tool life.&#10;
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
		private EXPIREDValue _EXPIRED;
		/// <inheritdoc cref="EXPIREDValue" path="/summary" />
		public EXPIREDValue EXPIRED => _EXPIRED ?? (_EXPIRED = new EXPIREDValue());

		/// <summary>﻿tool has reached the end of its useful life.<br /><br /><br />
		/// Value for CutterStatusTypeEnum.<br/>
		/// <br/>See also <seealso cref="CutterStatusTypeEnum">CutterStatusTypeEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.2">v1.2</see></item>
		/// </list>
		/// </remarks>

		public sealed class EXPIREDValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="EXPIREDValue.Name" /></summary>
			public const string NAME = "EXPIRED";
			/// <summary>Constant value for <see cref="EXPIREDValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.2";
			/// <summary>Constant value for <see cref="EXPIREDValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="EXPIREDValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;tool has reached the end of its useful life.&#10;
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
		private BROKENValue _BROKEN;
		/// <inheritdoc cref="BROKENValue" path="/summary" />
		public BROKENValue BROKEN => _BROKEN ?? (_BROKEN = new BROKENValue());

		/// <summary>﻿premature tool failure.<br /><br /><br />
		/// Value for CutterStatusTypeEnum.<br/>
		/// <br/>See also <seealso cref="CutterStatusTypeEnum">CutterStatusTypeEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.2">v1.2</see></item>
		/// </list>
		/// </remarks>

		public sealed class BROKENValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="BROKENValue.Name" /></summary>
			public const string NAME = "BROKEN";
			/// <summary>Constant value for <see cref="BROKENValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.2";
			/// <summary>Constant value for <see cref="BROKENValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="BROKENValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;premature tool failure.&#10;
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
		private NOT_REGISTEREDValue _NOT_REGISTERED;
		/// <inheritdoc cref="NOT_REGISTEREDValue" path="/summary" />
		public NOT_REGISTEREDValue NOT_REGISTERED => _NOT_REGISTERED ?? (_NOT_REGISTERED = new NOT_REGISTEREDValue());

		/// <summary>﻿tool cannot be used until it is entered into the system.<br /><br /><br />
		/// Value for CutterStatusTypeEnum.<br/>
		/// <br/>See also <seealso cref="CutterStatusTypeEnum">CutterStatusTypeEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.2">v1.2</see></item>
		/// </list>
		/// </remarks>

		public sealed class NOT_REGISTEREDValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="NOT_REGISTEREDValue.Name" /></summary>
			public const string NAME = "NOT_REGISTERED";
			/// <summary>Constant value for <see cref="NOT_REGISTEREDValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.2";
			/// <summary>Constant value for <see cref="NOT_REGISTEREDValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="NOT_REGISTEREDValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;tool cannot be used until it is entered into the system.&#10;
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
		private UNKNOWNValue _UNKNOWN;
		/// <inheritdoc cref="UNKNOWNValue" path="/summary" />
		public UNKNOWNValue UNKNOWN => _UNKNOWN ?? (_UNKNOWN = new UNKNOWNValue());

		/// <summary>﻿tool is an indeterminate state. This is the default value.<br /><br /><br />
		/// Value for CutterStatusTypeEnum.<br/>
		/// <br/>See also <seealso cref="CutterStatusTypeEnum">CutterStatusTypeEnum</seealso>
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.2">v1.2</see></item>
		/// </list>
		/// </remarks>

		public sealed class UNKNOWNValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="UNKNOWNValue.Name" /></summary>
			public const string NAME = "UNKNOWN";
			/// <summary>Constant value for <see cref="UNKNOWNValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "1.2";
			/// <summary>Constant value for <see cref="UNKNOWNValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="UNKNOWNValue.Summary" /></summary>
			public const string SUMMARY = @"&#10;&#10;&#10;tool is an indeterminate state. This is the default value.&#10;
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