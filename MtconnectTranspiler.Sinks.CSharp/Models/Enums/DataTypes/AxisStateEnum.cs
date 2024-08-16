using System;
using System.CodeDom.Compiler;using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;

namespace Mtconnect.DataTypes
{
	/// <summary>
	/// View in the MTConnect Model browser <seealso href="https://model.mtconnect.org/#Enumeration___19_0_3_45f01b9_1580378417658_841501_2872">model.mtconnect.org</seealso>
	﻿
	/// </summary>
	/// <remarks>
	/// <list type="bullet">
	/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.3">v1.3</see></item>
	/// </list>
	/// </remarks>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public enum AxisStateEnum
	{
		/// <summary>
		﻿/// axis is in its home position.<br/><br />

		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.3">v1.3</see></item>
		/// </list>
		/// </remarks>
		HOME,
		/// <summary>
		﻿/// axis is in motion.<br/><br />

		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.3">v1.3</see></item>
		/// </list>
		/// </remarks>
		TRAVEL,
		/// <summary>
		﻿/// axis has been moved to a fixed position and is being maintained in that position either electrically or mechanically. <br /><br />Action is required to release the axis from this position.<br/><br />

		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.3">v1.3</see></item>
		/// </list>
		/// </remarks>
		PARKED,
		/// <summary>
		﻿/// axis is stopped.<br/><br />

		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.3">v1.3</see></item>
		/// </list>
		/// </remarks>
		STOPPED,
	}

	/// <summary>
	/// View in the MTConnect Model browser <seealso href="https://model.mtconnect.org/#Enumeration___19_0_3_45f01b9_1580378417658_841501_2872">model.mtconnect.org</seealso>
	﻿
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public sealed class AxisStateEnumMetaClass : IEnum
	{
		/// <inheritdoc />
		public string Name => "AxisStateEnum";
		
		/// <inheritdoc />
		public Type DataType => null;
		
		public Type Instance => typeof(AxisStateEnum);

		/// <inheritdoc />
		public string NormativeVersion => "1.3";
		
		/// <inheritdoc />
		public string DeprecatedVersion => "";
		
		/// <inheritdoc />
		public string Summary => @"";
		
		/// <inheritdoc />
		public IEnumInstance[] Values => new IEnumInstance[] {
		HOME,
		TRAVEL,
		PARKED,
		STOPPED,
		};

		private HOMEValue _HOME;
		/// <summary>
		﻿/// axis is in its home position.<br/><br />

		/// </summary>
		public HOMEValue HOME => _HOME ?? (_HOME = new HOMEValue());

		/// <summary>
		﻿/// axis is in its home position.<br/><br />

		/// </summary>
		public sealed class HOMEValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "HOME";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.3";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"&#10;&#10;&#10;axis is in its home position.&#10;
";
		}
		private TRAVELValue _TRAVEL;
		/// <summary>
		﻿/// axis is in motion.<br/><br />

		/// </summary>
		public TRAVELValue TRAVEL => _TRAVEL ?? (_TRAVEL = new TRAVELValue());

		/// <summary>
		﻿/// axis is in motion.<br/><br />

		/// </summary>
		public sealed class TRAVELValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "TRAVEL";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.3";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"&#10;&#10;&#10;axis is in motion.&#10;
";
		}
		private PARKEDValue _PARKED;
		/// <summary>
		﻿/// axis has been moved to a fixed position and is being maintained in that position either electrically or mechanically. <br /><br />Action is required to release the axis from this position.<br/><br />

		/// </summary>
		public PARKEDValue PARKED => _PARKED ?? (_PARKED = new PARKEDValue());

		/// <summary>
		﻿/// axis has been moved to a fixed position and is being maintained in that position either electrically or mechanically. <br /><br />Action is required to release the axis from this position.<br/><br />

		/// </summary>
		public sealed class PARKEDValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "PARKED";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.3";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"&#10;&#10;&#10;axis has been moved to a fixed position and is being maintained in that position either electrically or mechanically. 

Action is required to release the axis from this position.&#10;
";
		}
		private STOPPEDValue _STOPPED;
		/// <summary>
		﻿/// axis is stopped.<br/><br />

		/// </summary>
		public STOPPEDValue STOPPED => _STOPPED ?? (_STOPPED = new STOPPEDValue());

		/// <summary>
		﻿/// axis is stopped.<br/><br />

		/// </summary>
		public sealed class STOPPEDValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "STOPPED";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.3";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"&#10;&#10;&#10;axis is stopped.&#10;
";
		}
	}
}