using System;
using System.CodeDom.Compiler;using MtconnectTranspiler.Sinks.CSharp.Contracts.Interfaces;

namespace Mtconnect.DataTypes
{
	/// <summary>
	/// View in the MTConnect Model browser <seealso href="https://model.mtconnect.org/#Enumeration___19_0_3_45f01b9_1580378417657_726565_2871">model.mtconnect.org</seealso>
	﻿
	/// </summary>
	/// <remarks>
	/// <list type="bullet">
	/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.1">v1.1</see></item>
	/// </list>
	/// </remarks>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public enum AxisCouplingEnum
	{
		/// <summary>
		﻿/// axes are physically connected to each other and operate as a single unit.<br/><br />

		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.1">v1.1</see></item>
		/// </list>
		/// </remarks>
		TANDEM,
		/// <summary>
		﻿/// axes are not physically connected to each other but are operating together in lockstep.<br/><br />

		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.1">v1.1</see></item>
		/// </list>
		/// </remarks>
		SYNCHRONOUS,
		/// <summary>
		﻿/// axis is the master of the <see cref="CoupledAxes">CoupledAxes</see>.<br/><br />

		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.1">v1.1</see></item>
		/// </list>
		/// </remarks>
		MASTER,
		/// <summary>
		﻿/// axis is a slave to the <see cref="CoupledAxes">CoupledAxes</see>.<br/><br />

		/// </summary>
		/// <remarks>
		/// <list type="bullet">
		/// <item><b>Introduced</b>: <see href="https://model.mtconnect.org/#_Version_1.1">v1.1</see></item>
		/// </list>
		/// </remarks>
		SLAVE,
	}

	/// <summary>
	/// View in the MTConnect Model browser <seealso href="https://model.mtconnect.org/#Enumeration___19_0_3_45f01b9_1580378417657_726565_2871">model.mtconnect.org</seealso>
	﻿
	/// </summary>
	[GeneratedCode("MtconnectTranspiler.Sinks.CSharp", "2.4.0.0")]
	public sealed class AxisCouplingEnumMetaClass : IEnum
	{
		/// <inheritdoc />
		public string Name => "AxisCouplingEnum";
		
		/// <inheritdoc />
		public Type DataType => null;
		
		public Type Instance => typeof(AxisCouplingEnum);

		/// <inheritdoc />
		public string NormativeVersion => "1.1";
		
		/// <inheritdoc />
		public string DeprecatedVersion => "";
		
		/// <inheritdoc />
		public string Summary => @"";
		
		/// <inheritdoc />
		public IEnumInstance[] Values => new IEnumInstance[] {
		TANDEM,
		SYNCHRONOUS,
		MASTER,
		SLAVE,
		};

		private TANDEMValue _TANDEM;
		/// <summary>
		﻿/// axes are physically connected to each other and operate as a single unit.<br/><br />

		/// </summary>
		public TANDEMValue TANDEM => _TANDEM ?? (_TANDEM = new TANDEMValue());

		/// <summary>
		﻿/// axes are physically connected to each other and operate as a single unit.<br/><br />

		/// </summary>
		public sealed class TANDEMValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "TANDEM";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.1";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"&#10;&#10;&#10;axes are physically connected to each other and operate as a single unit.&#10;
";
		}
		private SYNCHRONOUSValue _SYNCHRONOUS;
		/// <summary>
		﻿/// axes are not physically connected to each other but are operating together in lockstep.<br/><br />

		/// </summary>
		public SYNCHRONOUSValue SYNCHRONOUS => _SYNCHRONOUS ?? (_SYNCHRONOUS = new SYNCHRONOUSValue());

		/// <summary>
		﻿/// axes are not physically connected to each other but are operating together in lockstep.<br/><br />

		/// </summary>
		public sealed class SYNCHRONOUSValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "SYNCHRONOUS";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.1";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"&#10;&#10;&#10;axes are not physically connected to each other but are operating together in lockstep.&#10;
";
		}
		private MASTERValue _MASTER;
		/// <summary>
		﻿/// axis is the master of the <see cref="CoupledAxes">CoupledAxes</see>.<br/><br />

		/// </summary>
		public MASTERValue MASTER => _MASTER ?? (_MASTER = new MASTERValue());

		/// <summary>
		﻿/// axis is the master of the <see cref="CoupledAxes">CoupledAxes</see>.<br/><br />

		/// </summary>
		public sealed class MASTERValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "MASTER";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.1";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"&#10;&#10;&#10;axis is the master of the {{block(CoupledAxes)}}.&#10;
";
		}
		private SLAVEValue _SLAVE;
		/// <summary>
		﻿/// axis is a slave to the <see cref="CoupledAxes">CoupledAxes</see>.<br/><br />

		/// </summary>
		public SLAVEValue SLAVE => _SLAVE ?? (_SLAVE = new SLAVEValue());

		/// <summary>
		﻿/// axis is a slave to the <see cref="CoupledAxes">CoupledAxes</see>.<br/><br />

		/// </summary>
		public sealed class SLAVEValue : IEnumInstance
		{
			/// <inheritdoc />
			public string Name => "SLAVE";
			
			/// <inheritdoc />
			public object Value => null; // TODO: Add value, based on type.
			
			/// <inheritdoc />
			public string NormativeVersion => "1.1";
			
			/// <inheritdoc />
			public string DeprecatedVersion => "";
			
			/// <inheritdoc />
			public string Summary => @"&#10;&#10;&#10;axis is a slave to the {{block(CoupledAxes)}}.&#10;
";
		}
	}
}