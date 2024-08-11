using System;
using System.CodeDom.Compiler;using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;

namespace Mtconnect.DataTypes
{
	/// <summary>
	/// View in the MTConnect Model browser <seealso href="https://model.mtconnect.org/#Enumeration___19_0_3_68e0225_1633610276495_636137_441">model.mtconnect.org</seealso>
	/// </summary>
	/// <remarks>
	/// <list type="bullet">
	/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.1">v1.1</see></item>
	/// </list>
	/// </remarks>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.3.0.0")]
	public enum ConditionStateEnum
	{
		/// <summary>
		/// <i>condition state</i> that indicates operation within specified limits.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.1">v1.1</see></item>
		/// </list>
		/// </remarks>
		NORMAL,
		/// <summary>
		/// <i>condition state</i> that requires concern and supervision and may become hazardous if no action is taken.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.1">v1.1</see></item>
		/// </list>
		/// </remarks>
		WARNING,
		/// <summary>
		/// <i>condition state</i> that requires intervention to continue operation to function properly.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.1">v1.1</see></item>
		/// </list>
		/// </remarks>
		FAULT,
	}

	/// <summary>
	/// View in the MTConnect Model browser <seealso href="https://model.mtconnect.org/#Enumeration___19_0_3_68e0225_1633610276495_636137_441">model.mtconnect.org</seealso>
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.3.0.0")]
	public sealed class ConditionStateEnumMetaClass : IEnum
	{
		/// <inheritdoc />
		public string Name => "ConditionStateEnum";
		
		/// <inheritdoc />
		public Type DataType => null;
		
		public Type Instance => typeof(ConditionStateEnum);

		/// <inheritdoc />
		public string NormativeVersion => "1.1";
		
		/// <inheritdoc />
		public string DeprecatedVersion => "";
		
		/// <inheritdoc />
		public string Summary => @"";
		
		/// <inheritdoc />
		public IEnumInstance[] Values => new IEnumInstance[] {
		Normal,
		Warning,
		Fault,
		};

		private NormalValue _Normal;
		/// <summary>
		/// <i>condition state</i> that indicates operation within specified limits.
		/// </summary>
		public NormalValue Normal => _Normal ?? (_Normal = new NormalValue());

		/// <summary>
		/// <i>condition state</i> that indicates operation within specified limits.
		/// </summary>
		public sealed class NormalValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "Normal";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.1";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// <i>condition state</i> that indicates operation within specified limits.";
		}
		private WarningValue _Warning;
		/// <summary>
		/// <i>condition state</i> that requires concern and supervision and may become hazardous if no action is taken.
		/// </summary>
		public WarningValue Warning => _Warning ?? (_Warning = new WarningValue());

		/// <summary>
		/// <i>condition state</i> that requires concern and supervision and may become hazardous if no action is taken.
		/// </summary>
		public sealed class WarningValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "Warning";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.1";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// <i>condition state</i> that requires concern and supervision and may become hazardous if no action is taken.";
		}
		private FaultValue _Fault;
		/// <summary>
		/// <i>condition state</i> that requires intervention to continue operation to function properly.
		/// </summary>
		public FaultValue Fault => _Fault ?? (_Fault = new FaultValue());

		/// <summary>
		/// <i>condition state</i> that requires intervention to continue operation to function properly.
		/// </summary>
		public sealed class FaultValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "Fault";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.1";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"/// <i>condition state</i> that requires intervention to continue operation to function properly.";
		}
	}
}