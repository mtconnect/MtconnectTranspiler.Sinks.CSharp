using System;
using System.CodeDom.Compiler;using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;

namespace Mtconnect.DataTypes
{
	/// <summary>
	/// View in the MTConnect Model browser <seealso href="https://model.mtconnect.org/#Enumeration___19_0_3_68e0225_1643968895333_107274_240">model.mtconnect.org</seealso>
	/// </summary>
	/// <remarks>
	/// <list type="bullet">
	/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
	/// <item><b>Deprecated</b>: <see href="https://model.mtconnect.org/#_Version_1.1">v1.1</see></item>
	/// </list>
	/// </remarks>
	[Obsolete("Deprecated in v1.1 according to https://model.mtconnect.org/#_Version_1.1")]
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.3.0.0")]
	public enum AlarmCodeEnum
	{
		/// <summary>
		/// spindle crashed.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// <item><b>Deprecated</b>: <see href="https://model.mtconnect.org/#_Version_1.1">v1.1</see></item>
		/// </list>
		/// </remarks>
		[Obsolete("Deprecated in v1.1 according to https://model.mtconnect.org/#_Version_1.1")]
		CRASH,
		/// <summary>
		/// component jammed.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// <item><b>Deprecated</b>: <see href="https://model.mtconnect.org/#_Version_1.1">v1.1</see></item>
		/// </list>
		/// </remarks>
		[Obsolete("Deprecated in v1.1 according to https://model.mtconnect.org/#_Version_1.1")]
		JAM,
		/// <summary>
		/// component failed.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// <item><b>Deprecated</b>: <see href="https://model.mtconnect.org/#_Version_1.1">v1.1</see></item>
		/// </list>
		/// </remarks>
		[Obsolete("Deprecated in v1.1 according to https://model.mtconnect.org/#_Version_1.1")]
		FAILURE,
		/// <summary>
		/// fault occurred on the component.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// <item><b>Deprecated</b>: <see href="https://model.mtconnect.org/#_Version_1.1">v1.1</see></item>
		/// </list>
		/// </remarks>
		[Obsolete("Deprecated in v1.1 according to https://model.mtconnect.org/#_Version_1.1")]
		FAULT,
		/// <summary>
		/// component has stalled and cannot move.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// <item><b>Deprecated</b>: <see href="https://model.mtconnect.org/#_Version_1.1">v1.1</see></item>
		/// </list>
		/// </remarks>
		[Obsolete("Deprecated in v1.1 according to https://model.mtconnect.org/#_Version_1.1")]
		STALLED,
		/// <summary>
		/// component is overloaded.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// <item><b>Deprecated</b>: <see href="https://model.mtconnect.org/#_Version_1.1">v1.1</see></item>
		/// </list>
		/// </remarks>
		[Obsolete("Deprecated in v1.1 according to https://model.mtconnect.org/#_Version_1.1")]
		OVERLOAD,
		/// <summary>
		/// ESTOP button was pressed.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// <item><b>Deprecated</b>: <see href="https://model.mtconnect.org/#_Version_1.1">v1.1</see></item>
		/// </list>
		/// </remarks>
		[Obsolete("Deprecated in v1.1 according to https://model.mtconnect.org/#_Version_1.1")]
		ESTOP,
		/// <summary>
		/// problem with the material.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// <item><b>Deprecated</b>: <see href="https://model.mtconnect.org/#_Version_1.1">v1.1</see></item>
		/// </list>
		/// </remarks>
		[Obsolete("Deprecated in v1.1 according to https://model.mtconnect.org/#_Version_1.1")]
		MATERIAL,
		/// <summary>
		/// system message.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// <item><b>Deprecated</b>: <see href="https://model.mtconnect.org/#_Version_1.1">v1.1</see></item>
		/// </list>
		/// </remarks>
		[Obsolete("Deprecated in v1.1 according to https://model.mtconnect.org/#_Version_1.1")]
		MESSAGE,
		/// <summary>
		/// alarm is not in any of the above categories.
		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.0">v1.0</see></item>
		/// <item><b>Deprecated</b>: <see href="https://model.mtconnect.org/#_Version_1.1">v1.1</see></item>
		/// </list>
		/// </remarks>
		[Obsolete("Deprecated in v1.1 according to https://model.mtconnect.org/#_Version_1.1")]
		OTHER,
	}

	/// <summary>
	/// View in the MTConnect Model browser <seealso href="https://model.mtconnect.org/#Enumeration___19_0_3_68e0225_1643968895333_107274_240">model.mtconnect.org</seealso>
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.3.0.0")]
	public sealed class AlarmCodeEnumMetaClass : IEnum
	{
		/// <inheritdoc />
		public string Name => "AlarmCodeEnum";
		
		/// <inheritdoc />
		public Type DataType => null;
		
		public Type Instance => typeof(AlarmCodeEnum);

		/// <inheritdoc />
		public string NormativeVersion => "1.0";
		
		/// <inheritdoc />
		public string DeprecatedVersion => "1.1";
		
		/// <inheritdoc />
		public string Summary => @"";
		
		/// <inheritdoc />
		public IEnumInstance[] Values => new IEnumInstance[] {
		CRASH,
		JAM,
		FAILURE,
		FAULT,
		STALLED,
		OVERLOAD,
		ESTOP,
		MATERIAL,
		MESSAGE,
		OTHER,
		};

		private CRASHValue _CRASH;
		/// <summary>
		/// spindle crashed.
		/// </summary>
		public CRASHValue CRASH => _CRASH ?? (_CRASH = new CRASHValue());

		/// <summary>
		/// spindle crashed.
		/// </summary>
		public sealed class CRASHValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "CRASH";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.0";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "1.1";
			
			/// <inheritdoc />
			public string Summary => @"/// spindle crashed.";
		}
		private JAMValue _JAM;
		/// <summary>
		/// component jammed.
		/// </summary>
		public JAMValue JAM => _JAM ?? (_JAM = new JAMValue());

		/// <summary>
		/// component jammed.
		/// </summary>
		public sealed class JAMValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "JAM";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.0";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "1.1";
			
			/// <inheritdoc />
			public string Summary => @"/// component jammed.";
		}
		private FAILUREValue _FAILURE;
		/// <summary>
		/// component failed.
		/// </summary>
		public FAILUREValue FAILURE => _FAILURE ?? (_FAILURE = new FAILUREValue());

		/// <summary>
		/// component failed.
		/// </summary>
		public sealed class FAILUREValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "FAILURE";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.0";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "1.1";
			
			/// <inheritdoc />
			public string Summary => @"/// component failed.";
		}
		private FAULTValue _FAULT;
		/// <summary>
		/// fault occurred on the component.
		/// </summary>
		public FAULTValue FAULT => _FAULT ?? (_FAULT = new FAULTValue());

		/// <summary>
		/// fault occurred on the component.
		/// </summary>
		public sealed class FAULTValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "FAULT";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.0";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "1.1";
			
			/// <inheritdoc />
			public string Summary => @"/// fault occurred on the component.";
		}
		private STALLEDValue _STALLED;
		/// <summary>
		/// component has stalled and cannot move.
		/// </summary>
		public STALLEDValue STALLED => _STALLED ?? (_STALLED = new STALLEDValue());

		/// <summary>
		/// component has stalled and cannot move.
		/// </summary>
		public sealed class STALLEDValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "STALLED";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.0";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "1.1";
			
			/// <inheritdoc />
			public string Summary => @"/// component has stalled and cannot move.";
		}
		private OVERLOADValue _OVERLOAD;
		/// <summary>
		/// component is overloaded.
		/// </summary>
		public OVERLOADValue OVERLOAD => _OVERLOAD ?? (_OVERLOAD = new OVERLOADValue());

		/// <summary>
		/// component is overloaded.
		/// </summary>
		public sealed class OVERLOADValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "OVERLOAD";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.0";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "1.1";
			
			/// <inheritdoc />
			public string Summary => @"/// component is overloaded.";
		}
		private ESTOPValue _ESTOP;
		/// <summary>
		/// ESTOP button was pressed.
		/// </summary>
		public ESTOPValue ESTOP => _ESTOP ?? (_ESTOP = new ESTOPValue());

		/// <summary>
		/// ESTOP button was pressed.
		/// </summary>
		public sealed class ESTOPValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "ESTOP";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.0";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "1.1";
			
			/// <inheritdoc />
			public string Summary => @"/// ESTOP button was pressed.";
		}
		private MATERIALValue _MATERIAL;
		/// <summary>
		/// problem with the material.
		/// </summary>
		public MATERIALValue MATERIAL => _MATERIAL ?? (_MATERIAL = new MATERIALValue());

		/// <summary>
		/// problem with the material.
		/// </summary>
		public sealed class MATERIALValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "MATERIAL";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.0";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "1.1";
			
			/// <inheritdoc />
			public string Summary => @"/// problem with the material.";
		}
		private MESSAGEValue _MESSAGE;
		/// <summary>
		/// system message.
		/// </summary>
		public MESSAGEValue MESSAGE => _MESSAGE ?? (_MESSAGE = new MESSAGEValue());

		/// <summary>
		/// system message.
		/// </summary>
		public sealed class MESSAGEValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "MESSAGE";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.0";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "1.1";
			
			/// <inheritdoc />
			public string Summary => @"/// system message.";
		}
		private OTHERValue _OTHER;
		/// <summary>
		/// alarm is not in any of the above categories.
		/// </summary>
		public OTHERValue OTHER => _OTHER ?? (_OTHER = new OTHERValue());

		/// <summary>
		/// alarm is not in any of the above categories.
		/// </summary>
		public sealed class OTHERValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "OTHER";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.0";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "1.1";
			
			/// <inheritdoc />
			public string Summary => @"/// alarm is not in any of the above categories.";
		}
	}
}