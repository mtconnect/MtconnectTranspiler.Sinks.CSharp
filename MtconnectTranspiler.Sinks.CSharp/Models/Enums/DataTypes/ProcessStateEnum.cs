using System;
using System.CodeDom.Compiler;using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;

namespace Mtconnect.DataTypes
{
	/// <summary>
	/// View in the MTConnect Model browser <seealso href="https://model.mtconnect.org/#Enumeration___19_0_3_68e0225_1605550283222_680737_1925">model.mtconnect.org</seealso>
	/// </summary>
	/// <remarks>
	/// <list type="bullet">
	/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.8">v1.8</see></item>
	/// </list>
	/// </remarks>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.3.0.0")]
	public enum ProcessStateEnum
	{
		/// <summary>
		/// device is preparing to execute the process occurrence.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.8">v1.8</see></item>
		/// </list>
		/// </remarks>
		INITIALIZING,
		/// <summary>
		/// process occurrence is ready to be executed.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.8">v1.8</see></item>
		/// </list>
		/// </remarks>
		READY,
		/// <summary>
		/// process occurrence is actively executing.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.8">v1.8</see></item>
		/// </list>
		/// </remarks>
		ACTIVE,
		/// <summary>
		/// process occurrence is now finished.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.8">v1.8</see></item>
		/// </list>
		/// </remarks>
		COMPLETE,
		/// <summary>
		/// process occurrence has been stopped and may be resumed.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.8">v1.8</see></item>
		/// </list>
		/// </remarks>
		INTERRUPTED,
		/// <summary>
		/// process occurrence has come to a premature end and cannot be resumed.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.8">v1.8</see></item>
		/// </list>
		/// </remarks>
		ABORTED,
	}

	/// <summary>
	/// View in the MTConnect Model browser <seealso href="https://model.mtconnect.org/#Enumeration___19_0_3_68e0225_1605550283222_680737_1925">model.mtconnect.org</seealso>
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.3.0.0")]
	public sealed class ProcessStateEnumMetaClass : IEnum
	{
		/// <inheritdoc />
		public string Name => "ProcessStateEnum";
		
		/// <inheritdoc />
		public Type DataType => null;
		
		public Type Instance => typeof(ProcessStateEnum);

		/// <inheritdoc />
		public string NormativeVersion => "1.8";
		
		/// <inheritdoc />
		public string DeprecatedVersion => "";
		
		/// <inheritdoc />
		public string Summary => @"";
		
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
		/// <summary>
		/// device is preparing to execute the process occurrence.
		/// </summary>
		public INITIALIZINGValue INITIALIZING => _INITIALIZING ?? (_INITIALIZING = new INITIALIZINGValue());

		/// <summary>
		/// device is preparing to execute the process occurrence.
		/// </summary>
		public sealed class INITIALIZINGValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "INITIALIZING";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.8";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// device is preparing to execute the process occurrence.";
		}
		private READYValue _READY;
		/// <summary>
		/// process occurrence is ready to be executed.
		/// </summary>
		public READYValue READY => _READY ?? (_READY = new READYValue());

		/// <summary>
		/// process occurrence is ready to be executed.
		/// </summary>
		public sealed class READYValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "READY";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.8";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// process occurrence is ready to be executed.";
		}
		private ACTIVEValue _ACTIVE;
		/// <summary>
		/// process occurrence is actively executing.
		/// </summary>
		public ACTIVEValue ACTIVE => _ACTIVE ?? (_ACTIVE = new ACTIVEValue());

		/// <summary>
		/// process occurrence is actively executing.
		/// </summary>
		public sealed class ACTIVEValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "ACTIVE";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.8";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// process occurrence is actively executing.";
		}
		private COMPLETEValue _COMPLETE;
		/// <summary>
		/// process occurrence is now finished.
		/// </summary>
		public COMPLETEValue COMPLETE => _COMPLETE ?? (_COMPLETE = new COMPLETEValue());

		/// <summary>
		/// process occurrence is now finished.
		/// </summary>
		public sealed class COMPLETEValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "COMPLETE";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.8";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// process occurrence is now finished.";
		}
		private INTERRUPTEDValue _INTERRUPTED;
		/// <summary>
		/// process occurrence has been stopped and may be resumed.
		/// </summary>
		public INTERRUPTEDValue INTERRUPTED => _INTERRUPTED ?? (_INTERRUPTED = new INTERRUPTEDValue());

		/// <summary>
		/// process occurrence has been stopped and may be resumed.
		/// </summary>
		public sealed class INTERRUPTEDValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "INTERRUPTED";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.8";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// process occurrence has been stopped and may be resumed.";
		}
		private ABORTEDValue _ABORTED;
		/// <summary>
		/// process occurrence has come to a premature end and cannot be resumed.
		/// </summary>
		public ABORTEDValue ABORTED => _ABORTED ?? (_ABORTED = new ABORTEDValue());

		/// <summary>
		/// process occurrence has come to a premature end and cannot be resumed.
		/// </summary>
		public sealed class ABORTEDValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "ABORTED";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.8";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// process occurrence has come to a premature end and cannot be resumed.";
		}
	}
}