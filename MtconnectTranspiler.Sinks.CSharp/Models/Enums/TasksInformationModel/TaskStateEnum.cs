using System;
using System.CodeDom.Compiler;using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;

namespace Mtconnect.InterfaceInteractionModel.MultiDeviceInteractionModel.TasksInformationModel
{
	/// <summary>
	/// View in the MTConnect Model browser <seealso href="https://model.mtconnect.org/#Enumeration___19_0_3_68e0225_1622721899109_23146_2663">model.mtconnect.org</seealso>
	﻿
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public enum TaskStateEnum
	{
		/// <summary>
		﻿
		/// </summary>
		INACTIVE,
		/// <summary>
		﻿
		/// </summary>
		PREPARING,
		/// <summary>
		﻿
		/// </summary>
		COMMITTING,
		/// <summary>
		﻿
		/// </summary>
		COMMITTED,
		/// <summary>
		﻿
		/// </summary>
		COMPLETE,
		/// <summary>
		﻿
		/// </summary>
		FAIL,
	}

	/// <summary>
	/// View in the MTConnect Model browser <seealso href="https://model.mtconnect.org/#Enumeration___19_0_3_68e0225_1622721899109_23146_2663">model.mtconnect.org</seealso>
	﻿
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public sealed class TaskStateEnumMetaClass : IEnum
	{
		/// <inheritdoc />
		public string Name => "TaskStateEnum";
		
		/// <inheritdoc />
		public Type DataType => null;
		
		public Type Instance => typeof(TaskStateEnum);

		/// <inheritdoc />
		public string NormativeVersion => "";
		
		/// <inheritdoc />
		public string DeprecatedVersion => "";
		
		/// <inheritdoc />
		public string Summary => @"";
		
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
		public INACTIVEValue INACTIVE => _INACTIVE ?? (_INACTIVE = new INACTIVEValue());

		public sealed class INACTIVEValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "INACTIVE";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"";
		}
		private PREPARINGValue _PREPARING;
		public PREPARINGValue PREPARING => _PREPARING ?? (_PREPARING = new PREPARINGValue());

		public sealed class PREPARINGValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "PREPARING";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"";
		}
		private COMMITTINGValue _COMMITTING;
		public COMMITTINGValue COMMITTING => _COMMITTING ?? (_COMMITTING = new COMMITTINGValue());

		public sealed class COMMITTINGValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "COMMITTING";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"";
		}
		private COMMITTEDValue _COMMITTED;
		public COMMITTEDValue COMMITTED => _COMMITTED ?? (_COMMITTED = new COMMITTEDValue());

		public sealed class COMMITTEDValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "COMMITTED";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"";
		}
		private COMPLETEValue _COMPLETE;
		public COMPLETEValue COMPLETE => _COMPLETE ?? (_COMPLETE = new COMPLETEValue());

		public sealed class COMPLETEValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "COMPLETE";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"";
		}
		private FAILValue _FAIL;
		public FAILValue FAIL => _FAIL ?? (_FAIL = new FAILValue());

		public sealed class FAILValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "FAIL";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"";
		}
	}
}