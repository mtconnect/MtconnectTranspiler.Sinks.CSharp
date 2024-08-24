#pragma warning disable CS1574 // XML comment has cref attribute that could not be resolved
#pragma warning disable CS1584 // XML comment has syntactically incorrect cref attribute
#pragma warning disable CS0618 // Type or member is obsolete
using System;
using System.CodeDom.Compiler;using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;

namespace Mtconnect.InterfaceInteractionModel.MultiDeviceInteractionModel.TasksInformationModel
{
	/// <summary>﻿
	/// <br/> Visit <seealso href="https://model.mtconnect.org/#Enumeration___19_0_3_68e0225_1622721899109_23146_2663">model.mtconnect.org</seealso> for more information.
	/// </summary>
	
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public enum TaskStateEnum
	{
		/// <summary>﻿
		/// </summary>
		
		INACTIVE,
		/// <summary>﻿
		/// </summary>
		
		PREPARING,
		/// <summary>﻿
		/// </summary>
		
		COMMITTING,
		/// <summary>﻿
		/// </summary>
		
		COMMITTED,
		/// <summary>﻿
		/// </summary>
		
		COMPLETE,
		/// <summary>﻿
		/// </summary>
		
		FAIL,
	}

	/// <summary>﻿
	/// <br/>Visit <seealso href="https://model.mtconnect.org/#Enumeration___19_0_3_68e0225_1622721899109_23146_2663">model.mtconnect.org</seealso> for more information.
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public sealed class TaskStateEnumMetaClass : IEnum
	{
		/// <summary>Constant value for <see cref="TaskStateEnumMetaClass.ReferenceId" /></summary>
		public const string REFERENCE_ID = "_19_0_3_68e0225_1622721899109_23146_2663";
		/// <summary>Constant value for <see cref="TaskStateEnumMetaClass.HelpUrl" /></summary>
		public const string HELP_URL = "https://model.mtconnect.org/#Enumeration___19_0_3_68e0225_1622721899109_23146_2663";
		/// <summary>Constant value for <see cref="TaskStateEnumMetaClass.Name" /></summary>
		public const string NAME = "TaskStateEnum";
		/// <summary>Constant value for <see cref="TaskStateEnumMetaClass.NormativeVersion" /></summary>
		public const string NORMATIVE_VERSION = "";
		/// <summary>Constant value for <see cref="TaskStateEnumMetaClass.DeprecatedVersion" /></summary>
		public const string DEPRECATED_VERSION = "";
		/// <summary>Constant value for <see cref="TaskStateEnumMetaClass.Summary" /></summary>
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
		public Type Instance => typeof(TaskStateEnum);

		/// <inheritdoc />
		public string NormativeVersion => NORMATIVE_VERSION;
		
		/// <inheritdoc />
		public string DeprecatedVersion => DEPRECATED_VERSION;
		
		/// <inheritdoc />
		public string Summary => SUMMARY;
		
		/// <inheritdoc />
		public IEnumInstance[] Values => new IEnumInstance[] {
		INACTIVE,
		PREPARING,
		COMMITTING,
		COMMITTED,
		COMPLETE,
		FAIL,
		};

		private INACTIVEValue _INACTIVE;
		/// <inheritdoc cref="INACTIVEValue" path="/summary" />
		public INACTIVEValue INACTIVE => _INACTIVE ?? (_INACTIVE = new INACTIVEValue());

		/// <summary>﻿
		/// Value for TaskStateEnum.<br/>
		/// <br/>See also <seealso cref="TaskStateEnum">TaskStateEnum</seealso>
		/// </summary>
		
		public sealed class INACTIVEValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="INACTIVEValue.Name" /></summary>
			public const string NAME = "INACTIVE";
			/// <summary>Constant value for <see cref="INACTIVEValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "";
			/// <summary>Constant value for <see cref="INACTIVEValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="INACTIVEValue.Summary" /></summary>
			public const string SUMMARY = @"";

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
		private PREPARINGValue _PREPARING;
		/// <inheritdoc cref="PREPARINGValue" path="/summary" />
		public PREPARINGValue PREPARING => _PREPARING ?? (_PREPARING = new PREPARINGValue());

		/// <summary>﻿
		/// Value for TaskStateEnum.<br/>
		/// <br/>See also <seealso cref="TaskStateEnum">TaskStateEnum</seealso>
		/// </summary>
		
		public sealed class PREPARINGValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="PREPARINGValue.Name" /></summary>
			public const string NAME = "PREPARING";
			/// <summary>Constant value for <see cref="PREPARINGValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "";
			/// <summary>Constant value for <see cref="PREPARINGValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="PREPARINGValue.Summary" /></summary>
			public const string SUMMARY = @"";

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
		private COMMITTINGValue _COMMITTING;
		/// <inheritdoc cref="COMMITTINGValue" path="/summary" />
		public COMMITTINGValue COMMITTING => _COMMITTING ?? (_COMMITTING = new COMMITTINGValue());

		/// <summary>﻿
		/// Value for TaskStateEnum.<br/>
		/// <br/>See also <seealso cref="TaskStateEnum">TaskStateEnum</seealso>
		/// </summary>
		
		public sealed class COMMITTINGValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="COMMITTINGValue.Name" /></summary>
			public const string NAME = "COMMITTING";
			/// <summary>Constant value for <see cref="COMMITTINGValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "";
			/// <summary>Constant value for <see cref="COMMITTINGValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="COMMITTINGValue.Summary" /></summary>
			public const string SUMMARY = @"";

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
		private COMMITTEDValue _COMMITTED;
		/// <inheritdoc cref="COMMITTEDValue" path="/summary" />
		public COMMITTEDValue COMMITTED => _COMMITTED ?? (_COMMITTED = new COMMITTEDValue());

		/// <summary>﻿
		/// Value for TaskStateEnum.<br/>
		/// <br/>See also <seealso cref="TaskStateEnum">TaskStateEnum</seealso>
		/// </summary>
		
		public sealed class COMMITTEDValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="COMMITTEDValue.Name" /></summary>
			public const string NAME = "COMMITTED";
			/// <summary>Constant value for <see cref="COMMITTEDValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "";
			/// <summary>Constant value for <see cref="COMMITTEDValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="COMMITTEDValue.Summary" /></summary>
			public const string SUMMARY = @"";

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

		/// <summary>﻿
		/// Value for TaskStateEnum.<br/>
		/// <br/>See also <seealso cref="TaskStateEnum">TaskStateEnum</seealso>
		/// </summary>
		
		public sealed class COMPLETEValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="COMPLETEValue.Name" /></summary>
			public const string NAME = "COMPLETE";
			/// <summary>Constant value for <see cref="COMPLETEValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "";
			/// <summary>Constant value for <see cref="COMPLETEValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="COMPLETEValue.Summary" /></summary>
			public const string SUMMARY = @"";

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
		private FAILValue _FAIL;
		/// <inheritdoc cref="FAILValue" path="/summary" />
		public FAILValue FAIL => _FAIL ?? (_FAIL = new FAILValue());

		/// <summary>﻿
		/// Value for TaskStateEnum.<br/>
		/// <br/>See also <seealso cref="TaskStateEnum">TaskStateEnum</seealso>
		/// </summary>
		
		public sealed class FAILValue : IEnumInstance
		{
			/// <summary>Constant value for <see cref="FAILValue.Name" /></summary>
			public const string NAME = "FAIL";
			/// <summary>Constant value for <see cref="FAILValue.NormativeVersion" /></summary>
			public const string NORMATIVE_VERSION = "";
			/// <summary>Constant value for <see cref="FAILValue.DeprecatedVersion" /></summary>
			public const string DEPRECATED_VERSION = "";
			/// <summary>Constant value for <see cref="FAILValue.Summary" /></summary>
			public const string SUMMARY = @"";

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