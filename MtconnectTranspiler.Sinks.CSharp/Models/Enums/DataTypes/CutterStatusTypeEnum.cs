#pragma warning disable CS1574 // XML comment has cref attribute that could not be resolved
#pragma warning disable CS1584 // XML comment has syntactically incorrect cref attribute
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
		/// <inheritdoc />
		public string Name => "CutterStatusTypeEnum";
		
		/// <inheritdoc />
		public Type DataType => null;
		
		/// <inheritdoc />
		public Type Instance => typeof(CutterStatusTypeEnum);

		/// <inheritdoc />
		public string NormativeVersion => "1.2";
		
		/// <inheritdoc />
		public string DeprecatedVersion => "";
		
		/// <inheritdoc />
		public string Summary => @"";
		
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
		public sealed class NEWValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "NEW";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.2";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"&#10;&#10;&#10;new tool that has not been used or first use. 

Marks the start of the tool history.&#10;
";
		}
		private AVAILABLEValue _AVAILABLE;
		/// <inheritdoc cref="AVAILABLEValue" path="/summary" />
		public AVAILABLEValue AVAILABLE => _AVAILABLE ?? (_AVAILABLE = new AVAILABLEValue());

		/// <summary>﻿tool is available for use. <br /><br />If this is not present, the tool is currently not ready to be used.<br /><br /><br />
		/// Value for CutterStatusTypeEnum.<br/>
		/// <br/>See also <seealso cref="CutterStatusTypeEnum">CutterStatusTypeEnum</seealso>
		/// </summary>
		public sealed class AVAILABLEValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "AVAILABLE";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.2";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"&#10;&#10;&#10;tool is available for use. 

If this is not present, the tool is currently not ready to be used.&#10;
";
		}
		private UNAVAILABLEValue _UNAVAILABLE;
		/// <inheritdoc cref="UNAVAILABLEValue" path="/summary" />
		public UNAVAILABLEValue UNAVAILABLE => _UNAVAILABLE ?? (_UNAVAILABLE = new UNAVAILABLEValue());

		/// <summary>﻿tool is unavailable for use in metal removal. <br /><br /><br />
		/// Value for CutterStatusTypeEnum.<br/>
		/// <br/>See also <seealso cref="CutterStatusTypeEnum">CutterStatusTypeEnum</seealso>
		/// </summary>
		public sealed class UNAVAILABLEValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "UNAVAILABLE";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.2";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"&#10;&#10;&#10;tool is unavailable for use in metal removal. &#10;
";
		}
		private ALLOCATEDValue _ALLOCATED;
		/// <inheritdoc cref="ALLOCATEDValue" path="/summary" />
		public ALLOCATEDValue ALLOCATED => _ALLOCATED ?? (_ALLOCATED = new ALLOCATEDValue());

		/// <summary>﻿tool is has been committed to a piece of equipment for use and is not available for use in any other piece of equipment.<br /><br /><br />
		/// Value for CutterStatusTypeEnum.<br/>
		/// <br/>See also <seealso cref="CutterStatusTypeEnum">CutterStatusTypeEnum</seealso>
		/// </summary>
		public sealed class ALLOCATEDValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "ALLOCATED";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.2";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"&#10;&#10;&#10;tool is has been committed to a piece of equipment for use and is not available for use in any other piece of equipment.&#10;
";
		}
		private UNALLOCATEDValue _UNALLOCATED;
		/// <inheritdoc cref="UNALLOCATEDValue" path="/summary" />
		public UNALLOCATEDValue UNALLOCATED => _UNALLOCATED ?? (_UNALLOCATED = new UNALLOCATEDValue());

		/// <summary>﻿tool has not been committed to a process and can be allocated.<br /><br /><br />
		/// Value for CutterStatusTypeEnum.<br/>
		/// <br/>See also <seealso cref="CutterStatusTypeEnum">CutterStatusTypeEnum</seealso>
		/// </summary>
		public sealed class UNALLOCATEDValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "UNALLOCATED";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.2";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"&#10;&#10;&#10;tool has not been committed to a process and can be allocated.&#10;
";
		}
		private MEASUREDValue _MEASURED;
		/// <inheritdoc cref="MEASUREDValue" path="/summary" />
		public MEASUREDValue MEASURED => _MEASURED ?? (_MEASURED = new MEASUREDValue());

		/// <summary>﻿tool has been measured.<br /><br /><br /><br />
		/// Value for CutterStatusTypeEnum.<br/>
		/// <br/>See also <seealso cref="CutterStatusTypeEnum">CutterStatusTypeEnum</seealso>
		/// </summary>
		public sealed class MEASUREDValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "MEASURED";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.2";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"&#10;&#10;&#10;tool has been measured.&#10;
";
		}
		private RECONDITIONEDValue _RECONDITIONED;
		/// <inheritdoc cref="RECONDITIONEDValue" path="/summary" />
		public RECONDITIONEDValue RECONDITIONED => _RECONDITIONED ?? (_RECONDITIONED = new RECONDITIONEDValue());

		/// <summary>﻿tool has been reconditioned.<br /><br /><br />
		/// Value for CutterStatusTypeEnum.<br/>
		/// <br/>See also <seealso cref="CutterStatusTypeEnum">CutterStatusTypeEnum</seealso>
		/// </summary>
		public sealed class RECONDITIONEDValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "RECONDITIONED";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.2";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"&#10;&#10;&#10;tool has been reconditioned.&#10;
";
		}
		private USEDValue _USED;
		/// <inheritdoc cref="USEDValue" path="/summary" />
		public USEDValue USED => _USED ?? (_USED = new USEDValue());

		/// <summary>﻿tool is in process and has remaining tool life.<br /><br /><br />
		/// Value for CutterStatusTypeEnum.<br/>
		/// <br/>See also <seealso cref="CutterStatusTypeEnum">CutterStatusTypeEnum</seealso>
		/// </summary>
		public sealed class USEDValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "USED";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.2";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"&#10;&#10;&#10;tool is in process and has remaining tool life.&#10;
";
		}
		private EXPIREDValue _EXPIRED;
		/// <inheritdoc cref="EXPIREDValue" path="/summary" />
		public EXPIREDValue EXPIRED => _EXPIRED ?? (_EXPIRED = new EXPIREDValue());

		/// <summary>﻿tool has reached the end of its useful life.<br /><br /><br />
		/// Value for CutterStatusTypeEnum.<br/>
		/// <br/>See also <seealso cref="CutterStatusTypeEnum">CutterStatusTypeEnum</seealso>
		/// </summary>
		public sealed class EXPIREDValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "EXPIRED";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.2";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"&#10;&#10;&#10;tool has reached the end of its useful life.&#10;
";
		}
		private BROKENValue _BROKEN;
		/// <inheritdoc cref="BROKENValue" path="/summary" />
		public BROKENValue BROKEN => _BROKEN ?? (_BROKEN = new BROKENValue());

		/// <summary>﻿premature tool failure.<br /><br /><br />
		/// Value for CutterStatusTypeEnum.<br/>
		/// <br/>See also <seealso cref="CutterStatusTypeEnum">CutterStatusTypeEnum</seealso>
		/// </summary>
		public sealed class BROKENValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "BROKEN";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.2";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"&#10;&#10;&#10;premature tool failure.&#10;
";
		}
		private NOT_REGISTEREDValue _NOT_REGISTERED;
		/// <inheritdoc cref="NOT_REGISTEREDValue" path="/summary" />
		public NOT_REGISTEREDValue NOT_REGISTERED => _NOT_REGISTERED ?? (_NOT_REGISTERED = new NOT_REGISTEREDValue());

		/// <summary>﻿tool cannot be used until it is entered into the system.<br /><br /><br />
		/// Value for CutterStatusTypeEnum.<br/>
		/// <br/>See also <seealso cref="CutterStatusTypeEnum">CutterStatusTypeEnum</seealso>
		/// </summary>
		public sealed class NOT_REGISTEREDValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "NOT_REGISTERED";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.2";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"&#10;&#10;&#10;tool cannot be used until it is entered into the system.&#10;
";
		}
		private UNKNOWNValue _UNKNOWN;
		/// <inheritdoc cref="UNKNOWNValue" path="/summary" />
		public UNKNOWNValue UNKNOWN => _UNKNOWN ?? (_UNKNOWN = new UNKNOWNValue());

		/// <summary>﻿tool is an indeterminate state. This is the default value.<br /><br /><br />
		/// Value for CutterStatusTypeEnum.<br/>
		/// <br/>See also <seealso cref="CutterStatusTypeEnum">CutterStatusTypeEnum</seealso>
		/// </summary>
		public sealed class UNKNOWNValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "UNKNOWN";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.2";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"&#10;&#10;&#10;tool is an indeterminate state. This is the default value.&#10;
";
		}
	}
}