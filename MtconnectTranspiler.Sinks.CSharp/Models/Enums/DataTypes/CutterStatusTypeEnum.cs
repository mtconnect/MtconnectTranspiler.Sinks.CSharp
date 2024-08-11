using System;
using System.CodeDom.Compiler;using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;

namespace Mtconnect.DataTypes
{
	/// <summary>
	/// View in the MTConnect Model browser <seealso href="https://model.mtconnect.org/#Enumeration__EAID_782BD14C_FE49_4276_B7D0_7B42DA63B37F">model.mtconnect.org</seealso>
	/// </summary>
	/// <remarks>
	/// <list type="bullet">
	/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.2">v1.2</see></item>
	/// </list>
	/// </remarks>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.3.0.0")]
	public enum CutterStatusTypeEnum
	{
		/// <summary>
		/// new tool that has not been used or first use.   Marks the start of the tool history.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.2">v1.2</see></item>
		/// </list>
		/// </remarks>
		NEW,
		/// <summary>
		/// tool is available for use.   If this is not present, the tool is currently not ready to be used.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.2">v1.2</see></item>
		/// </list>
		/// </remarks>
		AVAILABLE,
		/// <summary>
		/// tool is unavailable for use in metal removal. 
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.2">v1.2</see></item>
		/// </list>
		/// </remarks>
		UNAVAILABLE,
		/// <summary>
		/// tool is has been committed to a piece of equipment for use and is not available for use in any other piece of equipment.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.2">v1.2</see></item>
		/// </list>
		/// </remarks>
		ALLOCATED,
		/// <summary>
		/// tool has not been committed to a process and can be allocated.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.2">v1.2</see></item>
		/// </list>
		/// </remarks>
		UNALLOCATED,
		/// <summary>
		/// tool has been measured. 
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.2">v1.2</see></item>
		/// </list>
		/// </remarks>
		MEASURED,
		/// <summary>
		/// tool has been reconditioned.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.2">v1.2</see></item>
		/// </list>
		/// </remarks>
		RECONDITIONED,
		/// <summary>
		/// tool is in process and has remaining tool life.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.2">v1.2</see></item>
		/// </list>
		/// </remarks>
		USED,
		/// <summary>
		/// tool has reached the end of its useful life.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.2">v1.2</see></item>
		/// </list>
		/// </remarks>
		EXPIRED,
		/// <summary>
		/// premature tool failure.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.2">v1.2</see></item>
		/// </list>
		/// </remarks>
		BROKEN,
		/// <summary>
		/// tool cannot be used until it is entered into the system.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.2">v1.2</see></item>
		/// </list>
		/// </remarks>
		NOT_REGISTERED,
		/// <summary>
		/// tool is an indeterminate state. This is the default value.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.2">v1.2</see></item>
		/// </list>
		/// </remarks>
		UNKNOWN,
	}

	/// <summary>
	/// View in the MTConnect Model browser <seealso href="https://model.mtconnect.org/#Enumeration__EAID_782BD14C_FE49_4276_B7D0_7B42DA63B37F">model.mtconnect.org</seealso>
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.3.0.0")]
	public sealed class CutterStatusTypeEnumMetaClass : IEnum
	{
		/// <inheritdoc />
		public string Name => "CutterStatusTypeEnum";
		
		/// <inheritdoc />
		public Type DataType => null;
		
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
		/// <summary>
		/// new tool that has not been used or first use.   Marks the start of the tool history.
		/// </summary>
		public NEWValue NEW => _NEW ?? (_NEW = new NEWValue());

		/// <summary>
		/// new tool that has not been used or first use.   Marks the start of the tool history.
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
			public string Summary => @"/// new tool that has not been used or first use.   Marks the start of the tool history.";
		}
		private AVAILABLEValue _AVAILABLE;
		/// <summary>
		/// tool is available for use.   If this is not present, the tool is currently not ready to be used.
		/// </summary>
		public AVAILABLEValue AVAILABLE => _AVAILABLE ?? (_AVAILABLE = new AVAILABLEValue());

		/// <summary>
		/// tool is available for use.   If this is not present, the tool is currently not ready to be used.
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
			public string Summary => @"/// tool is available for use.   If this is not present, the tool is currently not ready to be used.";
		}
		private UNAVAILABLEValue _UNAVAILABLE;
		/// <summary>
		/// tool is unavailable for use in metal removal. 
		/// </summary>
		public UNAVAILABLEValue UNAVAILABLE => _UNAVAILABLE ?? (_UNAVAILABLE = new UNAVAILABLEValue());

		/// <summary>
		/// tool is unavailable for use in metal removal. 
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
			public string Summary => @"/// tool is unavailable for use in metal removal. ";
		}
		private ALLOCATEDValue _ALLOCATED;
		/// <summary>
		/// tool is has been committed to a piece of equipment for use and is not available for use in any other piece of equipment.
		/// </summary>
		public ALLOCATEDValue ALLOCATED => _ALLOCATED ?? (_ALLOCATED = new ALLOCATEDValue());

		/// <summary>
		/// tool is has been committed to a piece of equipment for use and is not available for use in any other piece of equipment.
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
			public string Summary => @"/// tool is has been committed to a piece of equipment for use and is not available for use in any other piece of equipment.";
		}
		private UNALLOCATEDValue _UNALLOCATED;
		/// <summary>
		/// tool has not been committed to a process and can be allocated.
		/// </summary>
		public UNALLOCATEDValue UNALLOCATED => _UNALLOCATED ?? (_UNALLOCATED = new UNALLOCATEDValue());

		/// <summary>
		/// tool has not been committed to a process and can be allocated.
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
			public string Summary => @"/// tool has not been committed to a process and can be allocated.";
		}
		private MEASUREDValue _MEASURED;
		/// <summary>
		/// tool has been measured. 
		/// </summary>
		public MEASUREDValue MEASURED => _MEASURED ?? (_MEASURED = new MEASUREDValue());

		/// <summary>
		/// tool has been measured. 
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
			public string Summary => @"/// tool has been measured. ";
		}
		private RECONDITIONEDValue _RECONDITIONED;
		/// <summary>
		/// tool has been reconditioned.
		/// </summary>
		public RECONDITIONEDValue RECONDITIONED => _RECONDITIONED ?? (_RECONDITIONED = new RECONDITIONEDValue());

		/// <summary>
		/// tool has been reconditioned.
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
			public string Summary => @"/// tool has been reconditioned.";
		}
		private USEDValue _USED;
		/// <summary>
		/// tool is in process and has remaining tool life.
		/// </summary>
		public USEDValue USED => _USED ?? (_USED = new USEDValue());

		/// <summary>
		/// tool is in process and has remaining tool life.
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
			public string Summary => @"/// tool is in process and has remaining tool life.";
		}
		private EXPIREDValue _EXPIRED;
		/// <summary>
		/// tool has reached the end of its useful life.
		/// </summary>
		public EXPIREDValue EXPIRED => _EXPIRED ?? (_EXPIRED = new EXPIREDValue());

		/// <summary>
		/// tool has reached the end of its useful life.
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
			public string Summary => @"/// tool has reached the end of its useful life.";
		}
		private BROKENValue _BROKEN;
		/// <summary>
		/// premature tool failure.
		/// </summary>
		public BROKENValue BROKEN => _BROKEN ?? (_BROKEN = new BROKENValue());

		/// <summary>
		/// premature tool failure.
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
			public string Summary => @"/// premature tool failure.";
		}
		private NOT_REGISTEREDValue _NOT_REGISTERED;
		/// <summary>
		/// tool cannot be used until it is entered into the system.
		/// </summary>
		public NOT_REGISTEREDValue NOT_REGISTERED => _NOT_REGISTERED ?? (_NOT_REGISTERED = new NOT_REGISTEREDValue());

		/// <summary>
		/// tool cannot be used until it is entered into the system.
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
			public string Summary => @"/// tool cannot be used until it is entered into the system.";
		}
		private UNKNOWNValue _UNKNOWN;
		/// <summary>
		/// tool is an indeterminate state. This is the default value.
		/// </summary>
		public UNKNOWNValue UNKNOWN => _UNKNOWN ?? (_UNKNOWN = new UNKNOWNValue());

		/// <summary>
		/// tool is an indeterminate state. This is the default value.
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
			public string Summary => @"/// tool is an indeterminate state. This is the default value.";
		}
	}
}